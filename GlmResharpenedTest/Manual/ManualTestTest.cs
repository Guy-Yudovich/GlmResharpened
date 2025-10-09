using System;

using GlmResharpened;

using Newtonsoft.Json;

using NUnit.Framework;

namespace GlmResharpenedTest.Manual;

[TestFixture]
public class ManualTestTest
{
	[Test]
	public void Test()
	{
		var v = new vec2(3);
		Assert.That(3, Is.EqualTo(v.x).Within(0.0001));
		Assert.That(3, Is.EqualTo(v.y).Within(0.0001));

		var v2 = glm.swizzle(v).rgrg;
		Assert.That(3, Is.EqualTo(v2.x).Within(0.0001));
		Assert.That(3, Is.EqualTo(v2.y).Within(0.0001));
		Assert.That(3, Is.EqualTo(v2.z).Within(0.0001));
		Assert.That(3, Is.EqualTo(v2.w).Within(0.0001));

		v.y += glm.Smoothstep(0, 1, v.x);

		v2.yw = new vec2(6);
		Assert.That(3, Is.EqualTo(v2.x).Within(0.0001));
		Assert.That(6, Is.EqualTo(v2.y).Within(0.0001));
		Assert.That(3, Is.EqualTo(v2.z).Within(0.0001));
		Assert.That(6, Is.EqualTo(v2.w).Within(0.0001));

		//Assert.AreEqual(1.0, 2.0, 0.1);
	}

	[Test]
	public void HalfTypeZero()
	{
		var v0 = (Half)(-5.5);
		var v1 = (Half)0.5;
		var v2 = (Half)0.5;
		var a = v0 * (v1 - v2);
		var b = v0 * v1 - v0 * v2;

		/*var f0 = new[] { -5.5f };
            var f1 = new[] { 0.5f };
            var f2 = new[] { 0.5f };
            var fa = f0[0] * (f1[0] - f2[0]);
            var fb = f0[0] * f1[0] - f0[0] * f2[0];

            Console.WriteLine(BitConverter.ToString(BitConverter.GetBytes(fa)));
            Console.WriteLine(BitConverter.ToString(BitConverter.GetBytes(fb)));
            Console.WriteLine(BitConverter.ToString(BitConverter.GetBytes(-fb)));

            Console.WriteLine(Half.GetBits(new Half(-5.5) * new Half(0.0)));
            Console.WriteLine(Half.GetBits(new Half(-5.5) * new Half(-0.0)));
            Console.WriteLine(Half.GetBits(new Half(5.5) * new Half(0.0)));
            Console.WriteLine(Half.GetBits(new Half(5.5) * new Half(-0.0)));
            Console.WriteLine(Half.GetBits(a));
            Console.WriteLine(Half.GetBits(b));*/
		Assert.That(a, Is.EqualTo(b));
	}

	[Test]
	public void HalfSerializationJson()
	{
		var h = (Half)2.2;
		var sh = JsonConvert.SerializeObject(h);
		Console.WriteLine(sh);

		var v0 = new hvec3((Half)(-2), (Half)(-4), (Half)3);
		var s0 = JsonConvert.SerializeObject(v0);

		var v1 = JsonConvert.DeserializeObject<hvec3>(s0);
		var s1 = JsonConvert.SerializeObject(v1);

		Assert.That(v0, Is.EqualTo(v1));
		Assert.That(s0, Is.EqualTo(s1));
	}
}
