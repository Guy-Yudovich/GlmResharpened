using NUnit.Framework;

namespace GlmResharpenedTest.Manual;

[TestFixture]
public class MatrixMultTest
{
	[Test]
	public void Simple()
	{
		/*
             * 1 2
             * 3 4
             */
		var m1 = new mat2(1, 3, 2, 4);

		/*
             * 5 7
             * 6 8
             */
		var m2 = new mat2(5, 6, 7, 8);

		/*
             * 1 2 * 5 7 = 17 23
             * 3 4   6 8   39 53
             */
		var r = m1 * m2;
		Assert.That(r.m00, Is.EqualTo(17).Within(0.0001));
		Assert.That(r.m01, Is.EqualTo(39).Within(0.0001));
		Assert.That(r.m10, Is.EqualTo(23).Within(0.0001));
		Assert.That(r.m11, Is.EqualTo(53).Within(0.0001));
	}
}
