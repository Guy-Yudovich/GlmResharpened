#pragma warning disable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
using Newtonsoft.Json;
using GlmResharpened;
using GlmResharpened.Swizzle;

namespace GlmResharpenedTest.Generated.Vec3_Swizzle;

[TestFixture]
public class HalfSwizzleVec3Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new hvec3(((Half)(-9)), ((Half)(7)), ((Half)(8)));
            var v = ov.swizzle.xx;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(-3.5)), ((Half)(-3)), ((Half)(-0.5)));
            var v = ov.swizzle.xxx;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-5.5)), ((Half)(-1.5)), ((Half)(2)));
            var v = ov.swizzle.xxxx;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(5)), ((Half)(-9.5)), ((Half)(4)));
            var v = ov.swizzle.xxxy;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(0.5)), ((Half)(-5)), ((Half)(-9.5)));
            var v = ov.swizzle.xxxz;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-7)), ((Half)(-9)), ((Half)(9)));
            var v = ov.swizzle.xxy;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(4.5)), ((Half)(-5.5)), ((Half)(-7.5)));
            var v = ov.swizzle.xxyx;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-1.5)), Half.Zero, ((Half)(3.5)));
            var v = ov.swizzle.xxyy;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(7.5)), ((Half)(-7)), ((Half)(2)));
            var v = ov.swizzle.xxyz;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(9)), ((Half)(0.5)), ((Half)(-5)));
            var v = ov.swizzle.xxz;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(Half.Zero, Half.One, ((Half)(-4)));
            var v = ov.swizzle.xxzx;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-7)), ((Half)(7)), ((Half)(5)));
            var v = ov.swizzle.xxzy;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(1.5)), ((Half)(-6)), ((Half)(6)));
            var v = ov.swizzle.xxzz;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-7.5)), ((Half)(-3.5)), ((Half)(-1)));
            var v = ov.swizzle.xy;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(-8.5)), ((Half)(3)), ((Half)(-1)));
            var v = ov.swizzle.xyx;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(3.5)), ((Half)(-9)), ((Half)(8)));
            var v = ov.swizzle.xyxx;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(7)), ((Half)(4)), Half.Zero);
            var v = ov.swizzle.xyxy;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(1.5)), ((Half)(4.5)), ((Half)(-6.5)));
            var v = ov.swizzle.xyxz;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(Half.Zero, ((Half)(1.5)), ((Half)(7)));
            var v = ov.swizzle.xyy;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-5)), ((Half)(-0.5)), ((Half)(6.5)));
            var v = ov.swizzle.xyyx;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-2.5)), ((Half)(-5)), ((Half)(8.5)));
            var v = ov.swizzle.xyyy;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-2.5)), ((Half)(4)), ((Half)(-8)));
            var v = ov.swizzle.xyyz;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(0.5)), ((Half)(-4)), ((Half)(7)));
            var v = ov.swizzle.xyz;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-5)), ((Half)(-4.5)), ((Half)(2)));
            var v = ov.swizzle.xyzx;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(2)), ((Half)(-2)), ((Half)(7.5)));
            var v = ov.swizzle.xyzy;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-1)), ((Half)(6)), ((Half)(7.5)));
            var v = ov.swizzle.xyzz;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-6.5)), ((Half)(3)), ((Half)(8.5)));
            var v = ov.swizzle.xz;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(3.5)), Half.One, ((Half)(-3.5)));
            var v = ov.swizzle.xzx;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-4)), ((Half)(9)), ((Half)(7)));
            var v = ov.swizzle.xzxx;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(1.5)), ((Half)(-6)), ((Half)(-7)));
            var v = ov.swizzle.xzxy;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(7.5)), ((Half)(-6)), ((Half)(-2.5)));
            var v = ov.swizzle.xzxz;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-1)), ((Half)(4.5)), ((Half)(-2)));
            var v = ov.swizzle.xzy;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-2)), ((Half)(4.5)), ((Half)(8.5)));
            var v = ov.swizzle.xzyx;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(2.5)), ((Half)(3)), ((Half)(4)));
            var v = ov.swizzle.xzyy;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(Half.One, ((Half)(2.5)), ((Half)(-9)));
            var v = ov.swizzle.xzyz;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(8.5)), ((Half)(-1.5)), ((Half)(-7.5)));
            var v = ov.swizzle.xzz;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-3.5)), ((Half)(-0.5)), ((Half)(-5.5)));
            var v = ov.swizzle.xzzx;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-1)), ((Half)(2.5)), ((Half)(-4.5)));
            var v = ov.swizzle.xzzy;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(8.5)), ((Half)(3.5)), ((Half)(-3)));
            var v = ov.swizzle.xzzz;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-3)), ((Half)(-3)), ((Half)(4.5)));
            var v = ov.swizzle.yx;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(-1)), ((Half)(9.5)), ((Half)(7.5)));
            var v = ov.swizzle.yxx;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(0.5)), ((Half)(-7)), ((Half)(9)));
            var v = ov.swizzle.yxxx;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-6)), ((Half)(2.5)), ((Half)(-7)));
            var v = ov.swizzle.yxxy;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-4.5)), ((Half)(9.5)), ((Half)(-3)));
            var v = ov.swizzle.yxxz;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(8.5)), ((Half)(1.5)), Half.Zero);
            var v = ov.swizzle.yxy;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(3.5)), ((Half)(2.5)), ((Half)(8)));
            var v = ov.swizzle.yxyx;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(6)), ((Half)(-6)), ((Half)(-7.5)));
            var v = ov.swizzle.yxyy;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-4.5)), ((Half)(5)), ((Half)(-2.5)));
            var v = ov.swizzle.yxyz;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(3.5)), ((Half)(-2.5)), ((Half)(-5.5)));
            var v = ov.swizzle.yxz;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(2)), ((Half)(-3)), Half.One);
            var v = ov.swizzle.yxzx;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(9.5)), ((Half)(9.5)), ((Half)(-8.5)));
            var v = ov.swizzle.yxzy;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(3)), ((Half)(-8.5)), ((Half)(4)));
            var v = ov.swizzle.yxzz;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(7)), ((Half)(-1)), ((Half)(-6)));
            var v = ov.swizzle.yy;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(9)), ((Half)(-7.5)), ((Half)(5.5)));
            var v = ov.swizzle.yyx;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(4)), Half.One, ((Half)(0.5)));
            var v = ov.swizzle.yyxx;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-1)), ((Half)(-2)), Half.Zero);
            var v = ov.swizzle.yyxy;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-5.5)), ((Half)(4)), Half.Zero);
            var v = ov.swizzle.yyxz;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(3)), ((Half)(6)), ((Half)(7.5)));
            var v = ov.swizzle.yyy;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-3)), ((Half)(-3.5)), ((Half)(3.5)));
            var v = ov.swizzle.yyyx;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(9)), ((Half)(7.5)), ((Half)(0.5)));
            var v = ov.swizzle.yyyy;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-4.5)), ((Half)(-3)), ((Half)(-9.5)));
            var v = ov.swizzle.yyyz;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-6)), ((Half)(-4.5)), Half.Zero);
            var v = ov.swizzle.yyz;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(2.5)), ((Half)(5.5)), ((Half)(9)));
            var v = ov.swizzle.yyzx;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(6.5)), ((Half)(-3.5)), ((Half)(-7.5)));
            var v = ov.swizzle.yyzy;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(3.5)), ((Half)(6.5)), ((Half)(3.5)));
            var v = ov.swizzle.yyzz;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-3.5)), ((Half)(-9.5)), ((Half)(4)));
            var v = ov.swizzle.yz;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(7.5)), ((Half)(-7.5)), ((Half)(-6)));
            var v = ov.swizzle.yzx;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-6.5)), ((Half)(-8)), ((Half)(7)));
            var v = ov.swizzle.yzxx;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(Half.Zero, ((Half)(6.5)), ((Half)(2.5)));
            var v = ov.swizzle.yzxy;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-5.5)), ((Half)(1.5)), ((Half)(5.5)));
            var v = ov.swizzle.yzxz;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-1)), ((Half)(7.5)), ((Half)(-4)));
            var v = ov.swizzle.yzy;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-4.5)), ((Half)(-5.5)), ((Half)(9)));
            var v = ov.swizzle.yzyx;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-6)), ((Half)(-1.5)), ((Half)(-6)));
            var v = ov.swizzle.yzyy;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(0.5)), ((Half)(-9)), ((Half)(-7)));
            var v = ov.swizzle.yzyz;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(1.5)), ((Half)(-1.5)), ((Half)(-9)));
            var v = ov.swizzle.yzz;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-9)), ((Half)(9)), ((Half)(9)));
            var v = ov.swizzle.yzzx;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(3)), ((Half)(-3.5)), ((Half)(6)));
            var v = ov.swizzle.yzzy;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-0.5)), ((Half)(-3)), ((Half)(-6)));
            var v = ov.swizzle.yzzz;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-5)), ((Half)(2)), ((Half)(5.5)));
            var v = ov.swizzle.zx;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(-2)), ((Half)(-6)), ((Half)(-0.5)));
            var v = ov.swizzle.zxx;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(7)), ((Half)(7)), ((Half)(4)));
            var v = ov.swizzle.zxxx;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-5)), ((Half)(-4.5)), ((Half)(-1.5)));
            var v = ov.swizzle.zxxy;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(8)), ((Half)(7)), ((Half)(-2)));
            var v = ov.swizzle.zxxz;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-5.5)), ((Half)(9)), ((Half)(1.5)));
            var v = ov.swizzle.zxy;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-1.5)), ((Half)(7)), ((Half)(2)));
            var v = ov.swizzle.zxyx;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(9.5)), ((Half)(2.5)), ((Half)(0.5)));
            var v = ov.swizzle.zxyy;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-1.5)), ((Half)(-8.5)), ((Half)(-3.5)));
            var v = ov.swizzle.zxyz;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-6.5)), ((Half)(-9.5)), ((Half)(4)));
            var v = ov.swizzle.zxz;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-0.5)), ((Half)(-8.5)), ((Half)(-5.5)));
            var v = ov.swizzle.zxzx;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(7.5)), ((Half)(-1)), ((Half)(-7.5)));
            var v = ov.swizzle.zxzy;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-4)), ((Half)(4)), ((Half)(-3)));
            var v = ov.swizzle.zxzz;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-2.5)), ((Half)(-7.5)), ((Half)(-1)));
            var v = ov.swizzle.zy;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(-2)), ((Half)(-7)), ((Half)(2)));
            var v = ov.swizzle.zyx;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(1.5)), ((Half)(-1)), Half.One);
            var v = ov.swizzle.zyxx;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(7.5)), ((Half)(-9)), ((Half)(-6)));
            var v = ov.swizzle.zyxy;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-5)), Half.One, ((Half)(5)));
            var v = ov.swizzle.zyxz;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-3)), ((Half)(-6)), ((Half)(-1)));
            var v = ov.swizzle.zyy;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(5)), ((Half)(-5.5)), ((Half)(4.5)));
            var v = ov.swizzle.zyyx;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(2)), ((Half)(-5.5)), ((Half)(-1.5)));
            var v = ov.swizzle.zyyy;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(9.5)), ((Half)(-3.5)), ((Half)(4)));
            var v = ov.swizzle.zyyz;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(3)), ((Half)(-1)), ((Half)(6.5)));
            var v = ov.swizzle.zyz;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(0.5)), ((Half)(9)), ((Half)(5)));
            var v = ov.swizzle.zyzx;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-9)), Half.One, ((Half)(-4.5)));
            var v = ov.swizzle.zyzy;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(1.5)), ((Half)(-2.5)), ((Half)(-5)));
            var v = ov.swizzle.zyzz;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-2.5)), ((Half)(7.5)), ((Half)(-1)));
            var v = ov.swizzle.zz;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(-5.5)), ((Half)(-3.5)), Half.Zero);
            var v = ov.swizzle.zzx;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-1.5)), ((Half)(-4)), ((Half)(-9.5)));
            var v = ov.swizzle.zzxx;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-9)), ((Half)(-4.5)), ((Half)(5.5)));
            var v = ov.swizzle.zzxy;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-2)), ((Half)(8)), ((Half)(-8.5)));
            var v = ov.swizzle.zzxz;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-8)), ((Half)(-5.5)), ((Half)(8.5)));
            var v = ov.swizzle.zzy;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-6.5)), ((Half)(-3)), ((Half)(1.5)));
            var v = ov.swizzle.zzyx;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(8.5)), ((Half)(-2.5)), ((Half)(9.5)));
            var v = ov.swizzle.zzyy;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(4)), ((Half)(7)), ((Half)(9)));
            var v = ov.swizzle.zzyz;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-1)), ((Half)(6.5)), Half.Zero);
            var v = ov.swizzle.zzz;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-9.5)), ((Half)(-8.5)), ((Half)(-1.5)));
            var v = ov.swizzle.zzzx;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(5.5)), ((Half)(-8)), ((Half)(-3.5)));
            var v = ov.swizzle.zzzy;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-5.5)), ((Half)(-9)), ((Half)(8.5)));
            var v = ov.swizzle.zzzz;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new hvec3(((Half)(-2.5)), ((Half)(-9.5)), ((Half)(-5)));
            var v = ov.swizzle.rr;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(Half.Zero, ((Half)(-6.5)), ((Half)(5)));
            var v = ov.swizzle.rrr;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-1)), ((Half)(-6)), ((Half)(-0.5)));
            var v = ov.swizzle.rrrr;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(9)), ((Half)(-3)), ((Half)(-4)));
            var v = ov.swizzle.rrrg;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-3)), ((Half)(-8.5)), ((Half)(-7)));
            var v = ov.swizzle.rrrb;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-0.5)), ((Half)(3.5)), ((Half)(-2)));
            var v = ov.swizzle.rrg;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(7)), ((Half)(-4.5)), ((Half)(-3)));
            var v = ov.swizzle.rrgr;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-1)), ((Half)(-8.5)), ((Half)(-8.5)));
            var v = ov.swizzle.rrgg;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-2)), ((Half)(-2)), ((Half)(-4)));
            var v = ov.swizzle.rrgb;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-9)), ((Half)(-6)), ((Half)(2.5)));
            var v = ov.swizzle.rrb;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-3)), ((Half)(3)), ((Half)(8)));
            var v = ov.swizzle.rrbr;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-6)), ((Half)(7)), ((Half)(6)));
            var v = ov.swizzle.rrbg;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-3)), ((Half)(5.5)), ((Half)(8.5)));
            var v = ov.swizzle.rrbb;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-4.5)), ((Half)(0.5)), ((Half)(7)));
            var v = ov.swizzle.rg;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(-2)), ((Half)(9.5)), ((Half)(-4)));
            var v = ov.swizzle.rgr;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(4)), ((Half)(-4.5)), ((Half)(-6)));
            var v = ov.swizzle.rgrr;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(Half.One, ((Half)(-9)), ((Half)(-5.5)));
            var v = ov.swizzle.rgrg;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(6.5)), ((Half)(-9)), Half.Zero);
            var v = ov.swizzle.rgrb;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-1)), ((Half)(-7)), ((Half)(8.5)));
            var v = ov.swizzle.rgg;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(4.5)), ((Half)(-1.5)), ((Half)(-2)));
            var v = ov.swizzle.rggr;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(2.5)), ((Half)(1.5)), Half.Zero);
            var v = ov.swizzle.rggg;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(7.5)), ((Half)(6.5)), ((Half)(8)));
            var v = ov.swizzle.rggb;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(4)), ((Half)(6.5)), ((Half)(-4)));
            var v = ov.swizzle.rgb;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(9)), ((Half)(-7)), ((Half)(8.5)));
            var v = ov.swizzle.rgbr;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-3)), ((Half)(-7.5)), ((Half)(4.5)));
            var v = ov.swizzle.rgbg;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(4)), ((Half)(8.5)), ((Half)(-8.5)));
            var v = ov.swizzle.rgbb;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(6)), ((Half)(7)), ((Half)(-3.5)));
            var v = ov.swizzle.rb;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(7.5)), ((Half)(-8)), ((Half)(6.5)));
            var v = ov.swizzle.rbr;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(7)), ((Half)(-7)), ((Half)(-4.5)));
            var v = ov.swizzle.rbrr;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(8)), ((Half)(5)), ((Half)(0.5)));
            var v = ov.swizzle.rbrg;
            Assert.That(((Half)(8)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
            Assert.That(((Half)(5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(7)), ((Half)(-8)), ((Half)(6)));
            var v = ov.swizzle.rbrb;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-2.5)), ((Half)(2.5)), ((Half)(8.5)));
            var v = ov.swizzle.rbg;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(6)), ((Half)(-5)), ((Half)(3)));
            var v = ov.swizzle.rbgr;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(5)), Half.Zero, ((Half)(-1.5)));
            var v = ov.swizzle.rbgg;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(Half.One, ((Half)(1.5)), Half.One);
            var v = ov.swizzle.rbgb;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-3.5)), ((Half)(-6.5)), ((Half)(6.5)));
            var v = ov.swizzle.rbb;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(5)), ((Half)(5)), ((Half)(-8)));
            var v = ov.swizzle.rbbr;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-7)), ((Half)(-2.5)), ((Half)(-8.5)));
            var v = ov.swizzle.rbbg;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-4.5)), ((Half)(4.5)), ((Half)(-4)));
            var v = ov.swizzle.rbbb;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(3)), ((Half)(-0.5)), ((Half)(-9)));
            var v = ov.swizzle.gr;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(-6.5)), ((Half)(6.5)), ((Half)(1.5)));
            var v = ov.swizzle.grr;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-6.5)), Half.One, ((Half)(9.5)));
            var v = ov.swizzle.grrr;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(1.5)), ((Half)(-3.5)), ((Half)(-0.5)));
            var v = ov.swizzle.grrg;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(5.5)), ((Half)(8.5)), ((Half)(-6.5)));
            var v = ov.swizzle.grrb;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-8)), Half.One, ((Half)(7)));
            var v = ov.swizzle.grg;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(8.5)), ((Half)(5.5)), ((Half)(-3.5)));
            var v = ov.swizzle.grgr;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(5.5)), ((Half)(-7.5)), ((Half)(4.5)));
            var v = ov.swizzle.grgg;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-1.5)), ((Half)(2)), Half.Zero);
            var v = ov.swizzle.grgb;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-2)), ((Half)(0.5)), ((Half)(1.5)));
            var v = ov.swizzle.grb;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-3.5)), ((Half)(2)), ((Half)(8.5)));
            var v = ov.swizzle.grbr;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-4.5)), ((Half)(3)), ((Half)(-4.5)));
            var v = ov.swizzle.grbg;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-5.5)), ((Half)(-7.5)), ((Half)(3)));
            var v = ov.swizzle.grbb;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(7.5)), ((Half)(-9)), ((Half)(-0.5)));
            var v = ov.swizzle.gg;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(2)), ((Half)(4.5)), ((Half)(7.5)));
            var v = ov.swizzle.ggr;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(7)), ((Half)(9)), ((Half)(7)));
            var v = ov.swizzle.ggrr;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(5.5)), ((Half)(9.5)), ((Half)(-4.5)));
            var v = ov.swizzle.ggrg;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-4)), ((Half)(-3.5)), ((Half)(9.5)));
            var v = ov.swizzle.ggrb;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-2.5)), ((Half)(8)), ((Half)(7)));
            var v = ov.swizzle.ggg;
            Assert.That(((Half)(8)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-4.5)), ((Half)(5.5)), ((Half)(3.5)));
            var v = ov.swizzle.gggr;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(0.5)), ((Half)(-1)), ((Half)(-2)));
            var v = ov.swizzle.gggg;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(7)), ((Half)(4)), ((Half)(-6.5)));
            var v = ov.swizzle.gggb;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(1.5)), ((Half)(-1)), ((Half)(4.5)));
            var v = ov.swizzle.ggb;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(8.5)), ((Half)(3.5)), ((Half)(-9.5)));
            var v = ov.swizzle.ggbr;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(3)), Half.Zero, ((Half)(-7)));
            var v = ov.swizzle.ggbg;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(7.5)), ((Half)(3.5)), ((Half)(-2.5)));
            var v = ov.swizzle.ggbb;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(6.5)), ((Half)(-8.5)), ((Half)(3.5)));
            var v = ov.swizzle.gb;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(3.5)), ((Half)(-7)), ((Half)(1.5)));
            var v = ov.swizzle.gbr;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(6)), ((Half)(-3)), ((Half)(-6)));
            var v = ov.swizzle.gbrr;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(8.5)), ((Half)(7.5)), ((Half)(5.5)));
            var v = ov.swizzle.gbrg;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-8)), ((Half)(8.5)), ((Half)(-3.5)));
            var v = ov.swizzle.gbrb;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-1)), ((Half)(6)), ((Half)(7)));
            var v = ov.swizzle.gbg;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-8)), ((Half)(4.5)), ((Half)(-0.5)));
            var v = ov.swizzle.gbgr;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-4)), ((Half)(-6)), ((Half)(9.5)));
            var v = ov.swizzle.gbgg;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-3)), ((Half)(7.5)), ((Half)(5)));
            var v = ov.swizzle.gbgb;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(5)), ((Half)(9)), ((Half)(-3.5)));
            var v = ov.swizzle.gbb;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-7.5)), ((Half)(0.5)), ((Half)(-5)));
            var v = ov.swizzle.gbbr;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-8.5)), ((Half)(-1.5)), ((Half)(-5)));
            var v = ov.swizzle.gbbg;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(9.5)), ((Half)(7.5)), ((Half)(3.5)));
            var v = ov.swizzle.gbbb;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-9.5)), Half.One, ((Half)(2.5)));
            var v = ov.swizzle.br;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(6)), ((Half)(2.5)), ((Half)(-3)));
            var v = ov.swizzle.brr;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(9.5)), ((Half)(-9.5)), ((Half)(5.5)));
            var v = ov.swizzle.brrr;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(3.5)), ((Half)(2.5)), ((Half)(4.5)));
            var v = ov.swizzle.brrg;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(8)), ((Half)(-9)), ((Half)(8.5)));
            var v = ov.swizzle.brrb;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(7.5)), ((Half)(-7.5)), ((Half)(4)));
            var v = ov.swizzle.brg;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(4.5)), ((Half)(-9.5)), ((Half)(-9.5)));
            var v = ov.swizzle.brgr;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-4.5)), Half.Zero, ((Half)(2)));
            var v = ov.swizzle.brgg;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(0.5)), ((Half)(-6)), ((Half)(7)));
            var v = ov.swizzle.brgb;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-9.5)), ((Half)(7.5)), ((Half)(9)));
            var v = ov.swizzle.brb;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-2)), ((Half)(-1)), ((Half)(9)));
            var v = ov.swizzle.brbr;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-5)), ((Half)(7.5)), ((Half)(3.5)));
            var v = ov.swizzle.brbg;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(7.5)), ((Half)(7)), ((Half)(-6.5)));
            var v = ov.swizzle.brbb;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-3.5)), ((Half)(-3)), ((Half)(-7)));
            var v = ov.swizzle.bg;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(-1)), ((Half)(-2)), ((Half)(-8)));
            var v = ov.swizzle.bgr;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(1.5)), ((Half)(-4)), ((Half)(-2)));
            var v = ov.swizzle.bgrr;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-7)), ((Half)(-6.5)), ((Half)(5)));
            var v = ov.swizzle.bgrg;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(9)), ((Half)(5)), ((Half)(-7)));
            var v = ov.swizzle.bgrb;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-3)), ((Half)(4.5)), Half.Zero);
            var v = ov.swizzle.bgg;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(-0.5)), ((Half)(-7)), ((Half)(-6)));
            var v = ov.swizzle.bggr;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(5)), ((Half)(-9.5)), ((Half)(-6.5)));
            var v = ov.swizzle.bggg;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-4.5)), ((Half)(-7.5)), ((Half)(-8.5)));
            var v = ov.swizzle.bggb;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-5.5)), ((Half)(4.5)), ((Half)(-8.5)));
            var v = ov.swizzle.bgb;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(4)), ((Half)(9.5)), ((Half)(-5)));
            var v = ov.swizzle.bgbr;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-8.5)), ((Half)(7)), ((Half)(7)));
            var v = ov.swizzle.bgbg;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(3)), ((Half)(-5)), ((Half)(-0.5)));
            var v = ov.swizzle.bgbb;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-4.5)), ((Half)(8.5)), ((Half)(2)));
            var v = ov.swizzle.bb;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec3(((Half)(6.5)), ((Half)(3)), ((Half)(-4)));
            var v = ov.swizzle.bbr;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(3)), Half.One, ((Half)(5)));
            var v = ov.swizzle.bbrr;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(2.5)), Half.One, ((Half)(3)));
            var v = ov.swizzle.bbrg;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(2.5)), ((Half)(7)), ((Half)(0.5)));
            var v = ov.swizzle.bbrb;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(6)), ((Half)(-8.5)), ((Half)(3.5)));
            var v = ov.swizzle.bbg;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(3.5)), ((Half)(-4.5)), ((Half)(0.5)));
            var v = ov.swizzle.bbgr;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(6.5)), ((Half)(6)), ((Half)(-9)));
            var v = ov.swizzle.bbgg;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(0.5)), ((Half)(-2)), ((Half)(-5.5)));
            var v = ov.swizzle.bbgb;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(0.5)), ((Half)(-0.5)), ((Half)(7.5)));
            var v = ov.swizzle.bbb;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec3(((Half)(9)), ((Half)(9)), ((Half)(-9.5)));
            var v = ov.swizzle.bbbr;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-2)), ((Half)(4)), ((Half)(-8)));
            var v = ov.swizzle.bbbg;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec3(((Half)(-4)), ((Half)(9)), ((Half)(-7)));
            var v = ov.swizzle.bbbb;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new hvec3(((Half)(-3.5)), ((Half)(-1)), ((Half)(-8.5)));
            var v1 = new hvec2(((Half)(4.5)), ((Half)(-7)));
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(4.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v0.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v0.z));
        
            Assert.That(((Half)(-3.5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec3(((Half)(5)), ((Half)(-3.5)), ((Half)(-8.5)));
            var v1 = new hvec2(((Half)(-3)), ((Half)(2)));
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-3)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(2)), Is.EqualTo(v0.z));
        
            Assert.That(((Half)(5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec3(((Half)(-1)), ((Half)(8)), ((Half)(9.5)));
            var v1 = new hvec2(((Half)(-7.5)), ((Half)(4)));
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-1)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(4)), Is.EqualTo(v0.z));
        
            Assert.That(((Half)(8)), Is.EqualTo(v2.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec3(((Half)(0.5)), ((Half)(-6.5)), ((Half)(-5.5)));
            var v1 = new hvec3(((Half)(2.5)), ((Half)(9.5)), ((Half)(8.5)));
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(2.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v0.z));
        
            Assert.That(((Half)(0.5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v2.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new hvec3(((Half)(9.5)), ((Half)(5)), ((Half)(-6.5)));
            var v1 = ((Half)(((Half)(-5))));
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v0.z));
        
            Assert.That(((Half)(9.5)), Is.EqualTo(v2));
        }
        {
            var v0 = new hvec3(((Half)(-2.5)), ((Half)(-0.5)), ((Half)(-1)));
            var v1 = ((Half)(((Half)(8.5))));
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-2.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v0.z));
        
            Assert.That(((Half)(-0.5)), Is.EqualTo(v2));
        }
        {
            var v0 = new hvec3(((Half)(-2.5)), ((Half)(-2.5)), ((Half)(4)));
            var v1 = new hvec2(((Half)(9.5)), ((Half)(5)));
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(9.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(4)), Is.EqualTo(v0.z));
        
            Assert.That(((Half)(-2.5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec3(Half.Zero, ((Half)(-8)), ((Half)(-9)));
            var v1 = ((Half)(((Half)(7))));
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(Half.Zero, Is.EqualTo(v0.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v0.y));
            Assert.That(((Half)(7)), Is.EqualTo(v0.z));
        
            Assert.That(((Half)(-9)), Is.EqualTo(v2));
        }
        {
            var v0 = new hvec3(((Half)(3.5)), ((Half)(-0.5)), ((Half)(2.5)));
            var v1 = new hvec2(((Half)(-1.5)), ((Half)(-7)));
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-1.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v0.z));
        
            Assert.That(((Half)(3.5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec3(((Half)(-4.5)), ((Half)(2)), Half.Zero);
            var v1 = new hvec2(((Half)(9.5)), ((Half)(8)));
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-4.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(8)), Is.EqualTo(v0.z));
        
            Assert.That(((Half)(2)), Is.EqualTo(v2.x));
            Assert.That(Half.Zero, Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec3(((Half)(4)), ((Half)(-6.5)), ((Half)(-6)));
            var v1 = new hvec3(((Half)(-7)), ((Half)(-0.5)), Half.One);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-7)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v0.y));
            Assert.That(Half.One, Is.EqualTo(v0.z));
        
            Assert.That(((Half)(4)), Is.EqualTo(v2.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v2.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v2.z));
        }
    }

}
