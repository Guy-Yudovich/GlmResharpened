using GlmResharpenedGenerator.Types;

namespace GlmResharpenedGenerator.Tests;

/// <summary>
/// Random distribution tests
/// </summary>
internal class DistributionTestFunc : TestFunc
{
	public DistributionTestFunc(VectorType type, string name, string randomFuncName, string funcArgs, double avg, double variance) : base(type, name)
	{
		var dtype = new VectorType(BuiltinType.TypeDouble, type.Components);

		var code = new List<string>
		{
			$"var random = new Random({AbstractType.Random.Next()});",
			$"var sum = {dtype.Construct(dtype, dtype.ZeroValue)};",
			$"var sumSqr = {dtype.Construct(dtype, dtype.ZeroValue)};",
			"",
			"const int count = 50000;",
			"for (var _ = 0; _ < count; ++_)",
			"{",
			$"    var v = {type.Name}.{randomFuncName}(random{(string.IsNullOrEmpty(funcArgs) ? "" : ", " + funcArgs)});",
			$"    sum += ({dtype.Name})v;",
			$"    sumSqr += glm.Pow2(({dtype.Name})v);",
			"}",
			"",
			"var avg = sum / (double)count;",
			"var variance = sumSqr / (double)count - avg * avg;",
			""
		};
		for (var c = 0; c < type.Components; ++c)
			code.Add($"Assert.That(avg.{type.ArgOf(c)}, Is.EqualTo({avg}).Within(1.0));");

		code.Add("");
		for (var c = 0; c < type.Components; ++c)
			code.Add($"Assert.That(variance.{type.ArgOf(c)}, Is.EqualTo({variance}).Within(3.0));");

		Code = code;
	}
}
