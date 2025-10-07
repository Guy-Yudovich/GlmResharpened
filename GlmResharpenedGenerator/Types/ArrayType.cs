using GlmResharpenedGenerator.Members;

namespace GlmResharpenedGenerator.Types;

internal class ArrayType : AbstractType
{
	/// <summary>
	/// Array suffix
	/// </summary>
	public string ArraySuffix { get; set; }

	public override string GenericSuffix => ""; // no suffix

	public ArrayType(BuiltinType type, string suffix = "[]")
	{
		BaseType = type;
		ArraySuffix = suffix;
	}

	public override string Name => BaseType.Name + ArraySuffix;

	public override string TypeComment => throw new NotSupportedException();

	public override IEnumerable<Member> GenerateMembers() => throw new NotSupportedException();
}
