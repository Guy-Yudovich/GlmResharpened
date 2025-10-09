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

namespace GlmResharpenedTest.Generated.Vec4_Swizzle;

[TestFixture]
public class HalfSwizzleVec4Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(-4.5)), ((Half)(-1.5)), ((Half)(6.5)));
            var v = ov.swizzle.xx;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(-4)), ((Half)(-7)), ((Half)(5.5)));
            var v = ov.swizzle.xxx;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-8)), ((Half)(4.5)), ((Half)(-5.5)), ((Half)(-1.5)));
            var v = ov.swizzle.xxxx;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(-8.5)), ((Half)(-6.5)), Half.Zero);
            var v = ov.swizzle.xxxy;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), ((Half)(1.5)), ((Half)(7.5)), ((Half)(-8)));
            var v = ov.swizzle.xxxz;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(4)), ((Half)(3)), ((Half)(6)));
            var v = ov.swizzle.xxxw;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(5.5)), Half.Zero, ((Half)(-8)));
            var v = ov.swizzle.xxy;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(-1)), ((Half)(-7)), ((Half)(-7.5)));
            var v = ov.swizzle.xxyx;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(8.5)), Half.One, ((Half)(-5.5)));
            var v = ov.swizzle.xxyy;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(1.5)), ((Half)(-0.5)), Half.One, ((Half)(-6)));
            var v = ov.swizzle.xxyz;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(-3.5)), ((Half)(-8.5)), ((Half)(3.5)));
            var v = ov.swizzle.xxyw;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(6.5)), ((Half)(-8.5)), Half.Zero);
            var v = ov.swizzle.xxz;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(9)), ((Half)(6.5)), ((Half)(-7)));
            var v = ov.swizzle.xxzx;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(2.5)), ((Half)(-1)), ((Half)(-8)));
            var v = ov.swizzle.xxzy;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(-8.5)), ((Half)(7)), ((Half)(-9)));
            var v = ov.swizzle.xxzz;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(8.5)), ((Half)(2.5)), ((Half)(7)));
            var v = ov.swizzle.xxzw;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8)), ((Half)(2)), ((Half)(5)), ((Half)(5.5)));
            var v = ov.swizzle.xxw;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-9.5)), ((Half)(8.5)), ((Half)(8)), ((Half)(4.5)));
            var v = ov.swizzle.xxwx;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(-7.5)), ((Half)(4)), ((Half)(8)));
            var v = ov.swizzle.xxwy;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(9)), ((Half)(-8)), ((Half)(2.5)));
            var v = ov.swizzle.xxwz;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(9.5)), ((Half)(-1)), ((Half)(3.5)));
            var v = ov.swizzle.xxww;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(9.5)), ((Half)(-7)), ((Half)(1.5)));
            var v = ov.swizzle.xy;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(-6.5)), ((Half)(2)), ((Half)(-1)));
            var v = ov.swizzle.xyx;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(-6.5)), Half.One, ((Half)(-5)));
            var v = ov.swizzle.xyxx;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3.5)), ((Half)(-4)), ((Half)(-6)), ((Half)(-2.5)));
            var v = ov.swizzle.xyxy;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(0.5)), ((Half)(-4.5)), ((Half)(-8.5)), ((Half)(9)));
            var v = ov.swizzle.xyxz;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(2)), ((Half)(-2.5)), ((Half)(-6.5)));
            var v = ov.swizzle.xyxw;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), Half.One, ((Half)(5.5)), ((Half)(-2)));
            var v = ov.swizzle.xyy;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(-6)), ((Half)(4)), ((Half)(-4)));
            var v = ov.swizzle.xyyx;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(8.5)), ((Half)(3.5)), ((Half)(-8)));
            var v = ov.swizzle.xyyy;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4.5)), ((Half)(-5)), ((Half)(6)), ((Half)(7.5)));
            var v = ov.swizzle.xyyz;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(8.5)), ((Half)(-3)), ((Half)(6)));
            var v = ov.swizzle.xyyw;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9.5)), ((Half)(-0.5)), ((Half)(-5)), ((Half)(8)));
            var v = ov.swizzle.xyz;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(3.5)), ((Half)(1.5)), Half.One, ((Half)(0.5)));
            var v = ov.swizzle.xyzx;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9)), Half.Zero, ((Half)(3.5)), ((Half)(-2)));
            var v = ov.swizzle.xyzy;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(4.5)), ((Half)(3)), ((Half)(-3.5)));
            var v = ov.swizzle.xyzz;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(0.5)), ((Half)(8)), ((Half)(4)));
            var v = ov.swizzle.xyzw;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9)), ((Half)(-1.5)), ((Half)(-2.5)), ((Half)(5.5)));
            var v = ov.swizzle.xyw;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(8.5)), ((Half)(2)), ((Half)(-6)));
            var v = ov.swizzle.xywx;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8)), ((Half)(-6.5)), ((Half)(-4)), ((Half)(2)));
            var v = ov.swizzle.xywy;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(-8.5)), ((Half)(3)), ((Half)(7.5)));
            var v = ov.swizzle.xywz;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(-3.5)), ((Half)(-9)), ((Half)(-2)));
            var v = ov.swizzle.xyww;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(-5)), ((Half)(4.5)), ((Half)(-2.5)));
            var v = ov.swizzle.xz;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(5)), ((Half)(-8.5)), ((Half)(5)), ((Half)(0.5)));
            var v = ov.swizzle.xzx;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(-9.5)), ((Half)(9)), ((Half)(5)));
            var v = ov.swizzle.xzxx;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(7)), ((Half)(-1.5)), ((Half)(1.5)));
            var v = ov.swizzle.xzxy;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(-9)), ((Half)(-1.5)), ((Half)(5.5)));
            var v = ov.swizzle.xzxz;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(-4.5)), ((Half)(-2)), ((Half)(5.5)));
            var v = ov.swizzle.xzxw;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(0.5)), ((Half)(-7.5)), ((Half)(1.5)));
            var v = ov.swizzle.xzy;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(1.5)), ((Half)(5)), ((Half)(9.5)), Half.One);
            var v = ov.swizzle.xzyx;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(7.5)), ((Half)(0.5)), ((Half)(4)));
            var v = ov.swizzle.xzyy;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(9.5)), ((Half)(0.5)), ((Half)(9.5)));
            var v = ov.swizzle.xzyz;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(-2)), ((Half)(4)), ((Half)(8.5)));
            var v = ov.swizzle.xzyw;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(8)), ((Half)(-3)), ((Half)(-7.5)));
            var v = ov.swizzle.xzz;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(-2)), ((Half)(5.5)), ((Half)(7)));
            var v = ov.swizzle.xzzx;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(-6.5)), ((Half)(-7.5)), ((Half)(-0.5)));
            var v = ov.swizzle.xzzy;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(8.5)), Half.Zero, ((Half)(-5)));
            var v = ov.swizzle.xzzz;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(-5)), ((Half)(9.5)), ((Half)(5)));
            var v = ov.swizzle.xzzw;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(8)), ((Half)(3.5)), ((Half)(2.5)));
            var v = ov.swizzle.xzw;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-8)), ((Half)(-5.5)), ((Half)(7.5)), ((Half)(3)));
            var v = ov.swizzle.xzwx;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(-0.5)), ((Half)(2)), ((Half)(-8)));
            var v = ov.swizzle.xzwy;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(-4)), ((Half)(-7.5)), ((Half)(-7)));
            var v = ov.swizzle.xzwz;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), Half.Zero, ((Half)(8.5)), ((Half)(-9)));
            var v = ov.swizzle.xzww;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(2.5)), ((Half)(3)), ((Half)(-1.5)));
            var v = ov.swizzle.xw;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-5)), Half.Zero, Half.One, ((Half)(5.5)));
            var v = ov.swizzle.xwx;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(-5)), Half.Zero, ((Half)(-8)));
            var v = ov.swizzle.xwxx;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(9.5)), ((Half)(-8)), ((Half)(5)));
            var v = ov.swizzle.xwxy;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(-8.5)), ((Half)(3)), ((Half)(8)));
            var v = ov.swizzle.xwxz;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(2.5)), ((Half)(-9)), ((Half)(8)));
            var v = ov.swizzle.xwxw;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9.5)), ((Half)(4)), ((Half)(7)), ((Half)(-0.5)));
            var v = ov.swizzle.xwy;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-5.5)), ((Half)(8.5)), ((Half)(8.5)));
            var v = ov.swizzle.xwyx;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(-8.5)), ((Half)(4.5)), ((Half)(-1.5)));
            var v = ov.swizzle.xwyy;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(4)), ((Half)(-8)), ((Half)(-7)));
            var v = ov.swizzle.xwyz;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), Half.One, ((Half)(4)), ((Half)(-4)));
            var v = ov.swizzle.xwyw;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(-4.5)), ((Half)(5)), ((Half)(-7.5)));
            var v = ov.swizzle.xwz;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(-7)), Half.One, ((Half)(6.5)));
            var v = ov.swizzle.xwzx;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(0.5)), ((Half)(3)), ((Half)(-9)));
            var v = ov.swizzle.xwzy;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3)), ((Half)(5.5)), ((Half)(7)), ((Half)(9)));
            var v = ov.swizzle.xwzz;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(-2)), ((Half)(-9)), ((Half)(-5)));
            var v = ov.swizzle.xwzw;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(2)), ((Half)(2)), ((Half)(1.5)));
            var v = ov.swizzle.xww;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(-0.5)), Half.Zero, ((Half)(-1)));
            var v = ov.swizzle.xwwx;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(-2.5)), ((Half)(-4.5)), ((Half)(-4)));
            var v = ov.swizzle.xwwy;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(4)), ((Half)(-9.5)), ((Half)(5.5)));
            var v = ov.swizzle.xwwz;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9.5)), ((Half)(-3.5)), ((Half)(3.5)), ((Half)(9.5)));
            var v = ov.swizzle.xwww;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(2)), Half.One, ((Half)(-4.5)));
            var v = ov.swizzle.yx;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-5)), ((Half)(-5)), ((Half)(9)));
            var v = ov.swizzle.yxx;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(7)), ((Half)(-4.5)), ((Half)(-1)));
            var v = ov.swizzle.yxxx;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(0.5)), ((Half)(7.5)), ((Half)(-3.5)));
            var v = ov.swizzle.yxxy;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(-4)), ((Half)(-8)), ((Half)(6)));
            var v = ov.swizzle.yxxz;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(1.5)), ((Half)(3.5)), ((Half)(9)));
            var v = ov.swizzle.yxxw;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(-0.5)), ((Half)(2.5)), ((Half)(8)));
            var v = ov.swizzle.yxy;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(-3)), ((Half)(-1)), ((Half)(6)));
            var v = ov.swizzle.yxyx;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8)), ((Half)(-9)), ((Half)(3.5)), ((Half)(-4)));
            var v = ov.swizzle.yxyy;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(-8)), ((Half)(-5)), ((Half)(-0.5)));
            var v = ov.swizzle.yxyz;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(0.5)), ((Half)(-4)), ((Half)(4.5)));
            var v = ov.swizzle.yxyw;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(-5)), ((Half)(1.5)), ((Half)(7.5)));
            var v = ov.swizzle.yxz;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(4.5)), ((Half)(-3)), ((Half)(-4.5)));
            var v = ov.swizzle.yxzx;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(-3.5)), ((Half)(-6.5)), ((Half)(1.5)));
            var v = ov.swizzle.yxzy;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8)), ((Half)(1.5)), ((Half)(-9.5)), ((Half)(-2.5)));
            var v = ov.swizzle.yxzz;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(6)), ((Half)(5.5)), ((Half)(-5.5)));
            var v = ov.swizzle.yxzw;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(-8)), ((Half)(2.5)), ((Half)(2)));
            var v = ov.swizzle.yxw;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(-6.5)), ((Half)(-4.5)), ((Half)(4)));
            var v = ov.swizzle.yxwx;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9.5)), ((Half)(-1.5)), ((Half)(3.5)), ((Half)(-3.5)));
            var v = ov.swizzle.yxwy;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(8.5)), ((Half)(7)), ((Half)(0.5)));
            var v = ov.swizzle.yxwz;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(4.5)), Half.One, ((Half)(-8.5)));
            var v = ov.swizzle.yxww;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9.5)), ((Half)(-4.5)), ((Half)(8.5)), ((Half)(2.5)));
            var v = ov.swizzle.yy;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(2)), ((Half)(5)), ((Half)(9)));
            var v = ov.swizzle.yyx;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(-2.5)), ((Half)(6)), ((Half)(6)));
            var v = ov.swizzle.yyxx;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(0.5)), ((Half)(7.5)), ((Half)(-5.5)));
            var v = ov.swizzle.yyxy;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(-1.5)), Half.Zero, ((Half)(-5.5)));
            var v = ov.swizzle.yyxz;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9)), ((Half)(7)), ((Half)(-3.5)), ((Half)(-9.5)));
            var v = ov.swizzle.yyxw;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3.5)), ((Half)(6.5)), ((Half)(-4)), ((Half)(9)));
            var v = ov.swizzle.yyy;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(-0.5)), ((Half)(-0.5)), ((Half)(-1.5)));
            var v = ov.swizzle.yyyx;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5)), ((Half)(-4)), ((Half)(-5.5)), ((Half)(-2)));
            var v = ov.swizzle.yyyy;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9)), Half.Zero, ((Half)(6)), ((Half)(4.5)));
            var v = ov.swizzle.yyyz;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8)), ((Half)(-5)), ((Half)(7)), ((Half)(-3)));
            var v = ov.swizzle.yyyw;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(-3.5)), ((Half)(1.5)), ((Half)(-2.5)));
            var v = ov.swizzle.yyz;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(-5.5)), ((Half)(8)), ((Half)(9)));
            var v = ov.swizzle.yyzx;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(-7)), ((Half)(-2)), ((Half)(1.5)));
            var v = ov.swizzle.yyzy;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(-9)), ((Half)(9.5)), ((Half)(9.5)));
            var v = ov.swizzle.yyzz;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(5.5)), ((Half)(-2.5)), ((Half)(7)));
            var v = ov.swizzle.yyzw;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(-8)), Half.One, ((Half)(-8.5)));
            var v = ov.swizzle.yyw;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(5)), ((Half)(-3.5)), ((Half)(4)), ((Half)(-8.5)));
            var v = ov.swizzle.yywx;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(5)), ((Half)(5)), ((Half)(4.5)));
            var v = ov.swizzle.yywy;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(-4)), ((Half)(7.5)), ((Half)(6)));
            var v = ov.swizzle.yywz;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5)), ((Half)(-3.5)), ((Half)(8)), ((Half)(9.5)));
            var v = ov.swizzle.yyww;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(-9.5)), ((Half)(3.5)), ((Half)(-0.5)));
            var v = ov.swizzle.yz;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(3.5)), ((Half)(-3)), Half.Zero);
            var v = ov.swizzle.yzx;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(7)), ((Half)(6)), ((Half)(-7.5)));
            var v = ov.swizzle.yzxx;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(9.5)), ((Half)(-5)), ((Half)(4)));
            var v = ov.swizzle.yzxy;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4.5)), ((Half)(-1)), ((Half)(-7.5)), ((Half)(-5)));
            var v = ov.swizzle.yzxz;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9)), ((Half)(-1.5)), ((Half)(-2.5)), ((Half)(-0.5)));
            var v = ov.swizzle.yzxw;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(-7)), ((Half)(0.5)), ((Half)(-4.5)));
            var v = ov.swizzle.yzy;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(2.5)), ((Half)(3.5)), Half.One);
            var v = ov.swizzle.yzyx;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(-2.5)), ((Half)(-2.5)), ((Half)(-7)));
            var v = ov.swizzle.yzyy;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), ((Half)(-3)), ((Half)(-9)), ((Half)(-2)));
            var v = ov.swizzle.yzyz;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3)), ((Half)(3)), ((Half)(-9.5)), ((Half)(-4)));
            var v = ov.swizzle.yzyw;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9.5)), ((Half)(-5.5)), ((Half)(6)), Half.One);
            var v = ov.swizzle.yzz;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(3.5)), ((Half)(-8.5)), ((Half)(5.5)));
            var v = ov.swizzle.yzzx;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(3.5)), ((Half)(-8.5)), ((Half)(2.5)));
            var v = ov.swizzle.yzzy;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(4)), ((Half)(-8)), ((Half)(-4.5)));
            var v = ov.swizzle.yzzz;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(-1.5)), ((Half)(-9.5)), ((Half)(9)));
            var v = ov.swizzle.yzzw;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(4)), ((Half)(6.5)), Half.Zero);
            var v = ov.swizzle.yzw;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(7.5)), ((Half)(-9.5)), ((Half)(-3)));
            var v = ov.swizzle.yzwx;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(9)), ((Half)(2)), ((Half)(-5)));
            var v = ov.swizzle.yzwy;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8)), ((Half)(-4)), ((Half)(-0.5)), ((Half)(-2.5)));
            var v = ov.swizzle.yzwz;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9)), ((Half)(-0.5)), ((Half)(-3.5)), ((Half)(-2.5)));
            var v = ov.swizzle.yzww;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(8.5)), ((Half)(7.5)), ((Half)(2.5)));
            var v = ov.swizzle.yw;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(4.5)), ((Half)(-4.5)), ((Half)(-9)));
            var v = ov.swizzle.ywx;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(3.5)), ((Half)(9)), ((Half)(-5.5)));
            var v = ov.swizzle.ywxx;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), ((Half)(-1)), ((Half)(9.5)), ((Half)(4.5)));
            var v = ov.swizzle.ywxy;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(6)), ((Half)(-0.5)), Half.Zero);
            var v = ov.swizzle.ywxz;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3)), ((Half)(8)), ((Half)(3)), ((Half)(5.5)));
            var v = ov.swizzle.ywxw;
            Assert.That(((Half)(8)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(1.5)), ((Half)(5)), ((Half)(-5.5)), ((Half)(-9)));
            var v = ov.swizzle.ywy;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(0.5)), ((Half)(-6)), ((Half)(-3)));
            var v = ov.swizzle.ywyx;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(2.5)), ((Half)(8.5)), ((Half)(-6)));
            var v = ov.swizzle.ywyy;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(3)), ((Half)(4.5)), ((Half)(-7)));
            var v = ov.swizzle.ywyz;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3)), Half.Zero, ((Half)(-9)), ((Half)(8.5)));
            var v = ov.swizzle.ywyw;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(-9)), ((Half)(0.5)), ((Half)(7.5)));
            var v = ov.swizzle.ywz;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(4.5)), ((Half)(9.5)), ((Half)(3)));
            var v = ov.swizzle.ywzx;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9.5)), ((Half)(-4.5)), ((Half)(-5)), ((Half)(2)));
            var v = ov.swizzle.ywzy;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(2)), Half.One, Half.Zero);
            var v = ov.swizzle.ywzz;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(5)), ((Half)(3)), ((Half)(3)));
            var v = ov.swizzle.ywzw;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(6.5)), ((Half)(-7.5)), ((Half)(2.5)));
            var v = ov.swizzle.yww;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(-5.5)), ((Half)(-2.5)), ((Half)(-5.5)));
            var v = ov.swizzle.ywwx;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(-3)), ((Half)(-1.5)), ((Half)(-2)));
            var v = ov.swizzle.ywwy;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(0.5)), ((Half)(4)), ((Half)(4.5)), ((Half)(-2)));
            var v = ov.swizzle.ywwz;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(-3.5)), ((Half)(4)), ((Half)(-8.5)));
            var v = ov.swizzle.ywww;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(1.5)), ((Half)(-3)), ((Half)(-3)), ((Half)(-7)));
            var v = ov.swizzle.zx;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-8)), ((Half)(6.5)), ((Half)(-8.5)), ((Half)(4)));
            var v = ov.swizzle.zxx;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(3.5)), ((Half)(6)), ((Half)(7)));
            var v = ov.swizzle.zxxx;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(-5)), ((Half)(-7.5)), ((Half)(3)));
            var v = ov.swizzle.zxxy;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(8.5)), ((Half)(-3.5)), ((Half)(0.5)));
            var v = ov.swizzle.zxxz;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(-6)), ((Half)(1.5)), ((Half)(-2.5)));
            var v = ov.swizzle.zxxw;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(2)), ((Half)(-2)), ((Half)(0.5)));
            var v = ov.swizzle.zxy;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(-0.5)), ((Half)(-3.5)), ((Half)(-5.5)));
            var v = ov.swizzle.zxyx;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(-6.5)), ((Half)(-3)), ((Half)(4)));
            var v = ov.swizzle.zxyy;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), ((Half)(5)), ((Half)(-5)), ((Half)(-6)));
            var v = ov.swizzle.zxyz;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(-7.5)), ((Half)(-7.5)), ((Half)(-9)));
            var v = ov.swizzle.zxyw;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5)), ((Half)(-9.5)), ((Half)(-5)), ((Half)(-5)));
            var v = ov.swizzle.zxz;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(1.5)), ((Half)(-6)), ((Half)(-7)));
            var v = ov.swizzle.zxzx;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(-5)), ((Half)(-4)), ((Half)(-5)));
            var v = ov.swizzle.zxzy;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(-4.5)), ((Half)(-9)), ((Half)(-5)));
            var v = ov.swizzle.zxzz;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), ((Half)(1.5)), ((Half)(7.5)), ((Half)(-3)));
            var v = ov.swizzle.zxzw;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(-6.5)), ((Half)(6)), ((Half)(-4)));
            var v = ov.swizzle.zxw;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(-7)), ((Half)(-9.5)), ((Half)(1.5)));
            var v = ov.swizzle.zxwx;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(-1)), ((Half)(-1.5)), ((Half)(-4.5)));
            var v = ov.swizzle.zxwy;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(-3)), ((Half)(-7.5)), ((Half)(-7)));
            var v = ov.swizzle.zxwz;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(6.5)), ((Half)(7)), ((Half)(-6)));
            var v = ov.swizzle.zxww;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(8)), ((Half)(-6.5)), ((Half)(-3.5)));
            var v = ov.swizzle.zy;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(9)), ((Half)(7.5)), ((Half)(-6.5)), ((Half)(8.5)));
            var v = ov.swizzle.zyx;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(9.5)), ((Half)(1.5)), ((Half)(-2)));
            var v = ov.swizzle.zyxx;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4.5)), ((Half)(9)), ((Half)(-1)), ((Half)(-7.5)));
            var v = ov.swizzle.zyxy;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), Half.Zero, ((Half)(-3)), ((Half)(5)));
            var v = ov.swizzle.zyxz;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(-5.5)), ((Half)(4.5)), ((Half)(0.5)));
            var v = ov.swizzle.zyxw;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(-0.5)), ((Half)(-8.5)), ((Half)(8)));
            var v = ov.swizzle.zyy;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(2)), ((Half)(-1.5)), ((Half)(-2.5)));
            var v = ov.swizzle.zyyx;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(-7.5)), ((Half)(8.5)), ((Half)(9.5)));
            var v = ov.swizzle.zyyy;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(-9.5)), ((Half)(4)), ((Half)(4)));
            var v = ov.swizzle.zyyz;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(-7.5)), ((Half)(4)), ((Half)(-6.5)));
            var v = ov.swizzle.zyyw;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9)), ((Half)(-6)), Half.Zero, ((Half)(-4.5)));
            var v = ov.swizzle.zyz;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(9.5)), ((Half)(2)), ((Half)(-3.5)));
            var v = ov.swizzle.zyzx;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(2)), ((Half)(3)), ((Half)(-0.5)));
            var v = ov.swizzle.zyzy;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(2.5)), ((Half)(9.5)), ((Half)(-8.5)));
            var v = ov.swizzle.zyzz;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-5)), ((Half)(4.5)), ((Half)(-5.5)));
            var v = ov.swizzle.zyzw;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(3)), ((Half)(-1.5)), ((Half)(2)));
            var v = ov.swizzle.zyw;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(-2)), ((Half)(-7.5)), ((Half)(4.5)));
            var v = ov.swizzle.zywx;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(8)), ((Half)(-2)), ((Half)(0.5)));
            var v = ov.swizzle.zywy;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9.5)), ((Half)(-1)), ((Half)(-1)), ((Half)(-1)));
            var v = ov.swizzle.zywz;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(6.5)), ((Half)(7)), ((Half)(4)));
            var v = ov.swizzle.zyww;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9.5)), Half.One, ((Half)(3)), ((Half)(-8.5)));
            var v = ov.swizzle.zz;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-8)), ((Half)(8)), ((Half)(-4.5)), ((Half)(7)));
            var v = ov.swizzle.zzx;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-9.5)), ((Half)(-5.5)), ((Half)(-2.5)), ((Half)(-9)));
            var v = ov.swizzle.zzxx;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(-8.5)), ((Half)(-2)), ((Half)(-5)));
            var v = ov.swizzle.zzxy;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(7.5)), ((Half)(-4)), ((Half)(-0.5)));
            var v = ov.swizzle.zzxz;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(8)), ((Half)(0.5)), ((Half)(-5)));
            var v = ov.swizzle.zzxw;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(1.5)), ((Half)(-4)), ((Half)(9)), ((Half)(3)));
            var v = ov.swizzle.zzy;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(-0.5)), ((Half)(1.5)), ((Half)(-8.5)));
            var v = ov.swizzle.zzyx;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(0.5)), ((Half)(-4.5)), ((Half)(9)));
            var v = ov.swizzle.zzyy;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(7)), ((Half)(-4.5)), Half.One);
            var v = ov.swizzle.zzyz;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(-5)), ((Half)(-5)), ((Half)(-2)));
            var v = ov.swizzle.zzyw;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(2.5)), ((Half)(2)), ((Half)(9.5)));
            var v = ov.swizzle.zzz;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(6.5)), ((Half)(-7.5)), ((Half)(1.5)));
            var v = ov.swizzle.zzzx;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(-8)), ((Half)(-2.5)), ((Half)(0.5)));
            var v = ov.swizzle.zzzy;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(-0.5)), ((Half)(0.5)), ((Half)(4)));
            var v = ov.swizzle.zzzz;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9.5)), ((Half)(-8.5)), ((Half)(-3.5)), ((Half)(0.5)));
            var v = ov.swizzle.zzzw;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(6)), ((Half)(-2)), ((Half)(7.5)));
            var v = ov.swizzle.zzw;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(2)), ((Half)(-5)), ((Half)(-8.5)));
            var v = ov.swizzle.zzwx;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3)), ((Half)(-3)), ((Half)(2)), ((Half)(2)));
            var v = ov.swizzle.zzwy;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(-8)), ((Half)(2.5)), ((Half)(9.5)));
            var v = ov.swizzle.zzwz;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(-1)), ((Half)(4)), ((Half)(-4.5)));
            var v = ov.swizzle.zzww;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), Half.Zero, ((Half)(9.5)), ((Half)(0.5)));
            var v = ov.swizzle.zw;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(4.5)), ((Half)(7.5)), ((Half)(-1)));
            var v = ov.swizzle.zwx;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-8.5)), ((Half)(2)), ((Half)(6)));
            var v = ov.swizzle.zwxx;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(-5.5)), ((Half)(-9.5)), ((Half)(-6)));
            var v = ov.swizzle.zwxy;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9.5)), ((Half)(5)), ((Half)(3)), ((Half)(6.5)));
            var v = ov.swizzle.zwxz;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), Half.One, ((Half)(-9)), ((Half)(9)));
            var v = ov.swizzle.zwxw;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(-5.5)), ((Half)(6.5)), ((Half)(3.5)));
            var v = ov.swizzle.zwy;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(1.5)), ((Half)(3.5)), ((Half)(-1.5)));
            var v = ov.swizzle.zwyx;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), Half.Zero, ((Half)(-6.5)), ((Half)(2.5)));
            var v = ov.swizzle.zwyy;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(-7.5)), ((Half)(4.5)), Half.One);
            var v = ov.swizzle.zwyz;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(3)), ((Half)(3)), ((Half)(1.5)));
            var v = ov.swizzle.zwyw;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9)), ((Half)(6.5)), ((Half)(-4)), ((Half)(9)));
            var v = ov.swizzle.zwz;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(-7)), ((Half)(-9)), ((Half)(5)));
            var v = ov.swizzle.zwzx;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(8)), ((Half)(3)), ((Half)(5)));
            var v = ov.swizzle.zwzy;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(-0.5)), ((Half)(-5)), ((Half)(-9)));
            var v = ov.swizzle.zwzz;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(3)), ((Half)(-4)), ((Half)(-3.5)));
            var v = ov.swizzle.zwzw;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(-4)), ((Half)(0.5)), ((Half)(-1.5)));
            var v = ov.swizzle.zww;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(-2.5)), ((Half)(8)), ((Half)(8.5)));
            var v = ov.swizzle.zwwx;
            Assert.That(((Half)(8)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(2)), ((Half)(1.5)), ((Half)(-8)));
            var v = ov.swizzle.zwwy;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(-2.5)), ((Half)(9.5)), ((Half)(-9)));
            var v = ov.swizzle.zwwz;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(-2.5)), ((Half)(5.5)), ((Half)(-9)));
            var v = ov.swizzle.zwww;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(-2.5)), ((Half)(-8.5)), ((Half)(6)));
            var v = ov.swizzle.wx;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(-8)), ((Half)(-2)), ((Half)(-8)));
            var v = ov.swizzle.wxx;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(-5)), ((Half)(3)), Half.Zero);
            var v = ov.swizzle.wxxx;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(-7)), ((Half)(4)), ((Half)(6.5)));
            var v = ov.swizzle.wxxy;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5)), ((Half)(-3.5)), ((Half)(7)), ((Half)(-1)));
            var v = ov.swizzle.wxxz;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8)), ((Half)(-8.5)), ((Half)(4.5)), ((Half)(4)));
            var v = ov.swizzle.wxxw;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-3.5)), ((Half)(6)), ((Half)(3.5)));
            var v = ov.swizzle.wxy;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(0.5)), ((Half)(6.5)), ((Half)(8)), ((Half)(-1)));
            var v = ov.swizzle.wxyx;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8)), ((Half)(5.5)), ((Half)(-5)), Half.Zero);
            var v = ov.swizzle.wxyy;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(-5.5)), ((Half)(0.5)), ((Half)(-5.5)));
            var v = ov.swizzle.wxyz;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(1.5)), ((Half)(1.5)), ((Half)(6.5)));
            var v = ov.swizzle.wxyw;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(0.5)), ((Half)(-1.5)), ((Half)(-7.5)));
            var v = ov.swizzle.wxz;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(3)), ((Half)(-3)), ((Half)(-5.5)));
            var v = ov.swizzle.wxzx;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9)), ((Half)(-5.5)), ((Half)(9)), ((Half)(1.5)));
            var v = ov.swizzle.wxzy;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(-6)), ((Half)(-0.5)), ((Half)(-2)));
            var v = ov.swizzle.wxzz;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(-8)), ((Half)(-2.5)), ((Half)(-1)));
            var v = ov.swizzle.wxzw;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5)), ((Half)(3.5)), ((Half)(2.5)), ((Half)(4.5)));
            var v = ov.swizzle.wxw;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(3)), ((Half)(3)), ((Half)(-7.5)));
            var v = ov.swizzle.wxwx;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(-5.5)), ((Half)(5.5)), ((Half)(-8)));
            var v = ov.swizzle.wxwy;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(0.5)), ((Half)(7.5)), ((Half)(6)), ((Half)(-2.5)));
            var v = ov.swizzle.wxwz;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(-4.5)), ((Half)(9)), ((Half)(-2.5)));
            var v = ov.swizzle.wxww;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(-5.5)), ((Half)(1.5)), ((Half)(-5.5)));
            var v = ov.swizzle.wy;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-4.5)), ((Half)(-6.5)), ((Half)(7)), ((Half)(-6)));
            var v = ov.swizzle.wyx;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(-9)), ((Half)(-4)), ((Half)(8.5)));
            var v = ov.swizzle.wyxx;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(-9.5)), ((Half)(0.5)), ((Half)(5)));
            var v = ov.swizzle.wyxy;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(3.5)), ((Half)(-9.5)), ((Half)(-9.5)));
            var v = ov.swizzle.wyxz;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(1.5)), ((Half)(-0.5)), ((Half)(5.5)));
            var v = ov.swizzle.wyxw;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(2.5)), Half.Zero, ((Half)(5.5)));
            var v = ov.swizzle.wyy;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(9)), ((Half)(2)), ((Half)(-4)), ((Half)(-4.5)));
            var v = ov.swizzle.wyyx;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), Half.Zero, ((Half)(-2.5)), ((Half)(-7.5)));
            var v = ov.swizzle.wyyy;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(7)), ((Half)(9)), ((Half)(-9)));
            var v = ov.swizzle.wyyz;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(-2.5)), ((Half)(-1.5)), ((Half)(-7)));
            var v = ov.swizzle.wyyw;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(6.5)), ((Half)(-5)), ((Half)(9)));
            var v = ov.swizzle.wyz;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(7)), Half.Zero, ((Half)(-1.5)), ((Half)(3)));
            var v = ov.swizzle.wyzx;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5)), ((Half)(0.5)), ((Half)(-2.5)), ((Half)(2.5)));
            var v = ov.swizzle.wyzy;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(6.5)), ((Half)(5.5)), ((Half)(2.5)));
            var v = ov.swizzle.wyzz;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(-3)), ((Half)(5)), ((Half)(1.5)));
            var v = ov.swizzle.wyzw;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(-1.5)), ((Half)(0.5)), ((Half)(3)));
            var v = ov.swizzle.wyw;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(3.5)), ((Half)(8)), ((Half)(3)), ((Half)(0.5)));
            var v = ov.swizzle.wywx;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), Half.Zero, ((Half)(-6.5)), ((Half)(-3)));
            var v = ov.swizzle.wywy;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(-3)), ((Half)(-5.5)), ((Half)(2.5)));
            var v = ov.swizzle.wywz;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(1.5)), ((Half)(-2.5)), ((Half)(9)));
            var v = ov.swizzle.wyww;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(-1)), ((Half)(-9.5)), ((Half)(-7)));
            var v = ov.swizzle.wz;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-3)), ((Half)(4.5)), ((Half)(-2.5)), ((Half)(6)));
            var v = ov.swizzle.wzx;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(-7)), ((Half)(6.5)), ((Half)(-6.5)));
            var v = ov.swizzle.wzxx;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(6.5)), ((Half)(-2)), ((Half)(-6.5)));
            var v = ov.swizzle.wzxy;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5)), ((Half)(-1)), ((Half)(-7)), ((Half)(8.5)));
            var v = ov.swizzle.wzxz;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(8.5)), ((Half)(-9.5)), ((Half)(4)));
            var v = ov.swizzle.wzxw;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(-4)), ((Half)(-0.5)), ((Half)(-7.5)));
            var v = ov.swizzle.wzy;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(3)), ((Half)(-5)), ((Half)(1.5)));
            var v = ov.swizzle.wzyx;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4.5)), ((Half)(6.5)), ((Half)(-7)), ((Half)(4.5)));
            var v = ov.swizzle.wzyy;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8)), ((Half)(-4)), ((Half)(0.5)), ((Half)(8.5)));
            var v = ov.swizzle.wzyz;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(7.5)), ((Half)(-8)), ((Half)(6)));
            var v = ov.swizzle.wzyw;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(9.5)), ((Half)(2.5)), ((Half)(5)));
            var v = ov.swizzle.wzz;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(Half.Zero, Half.One, ((Half)(-3.5)), ((Half)(6)));
            var v = ov.swizzle.wzzx;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(-0.5)), ((Half)(-2)), ((Half)(-6)));
            var v = ov.swizzle.wzzy;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(0.5)), ((Half)(-5)), ((Half)(9)), ((Half)(9.5)));
            var v = ov.swizzle.wzzz;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(4)), ((Half)(4.5)), ((Half)(8)));
            var v = ov.swizzle.wzzw;
            Assert.That(((Half)(8)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(5)), ((Half)(8.5)), ((Half)(-5.5)));
            var v = ov.swizzle.wzw;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-9.5)), ((Half)(-8)), ((Half)(-4)), ((Half)(2.5)));
            var v = ov.swizzle.wzwx;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(-8)), ((Half)(-7)), Half.Zero);
            var v = ov.swizzle.wzwy;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9.5)), ((Half)(-4)), Half.Zero, ((Half)(7)));
            var v = ov.swizzle.wzwz;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(-5.5)), ((Half)(-8.5)), ((Half)(9)));
            var v = ov.swizzle.wzww;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8)), ((Half)(8)), ((Half)(-7)), ((Half)(6.5)));
            var v = ov.swizzle.ww;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), Half.Zero, ((Half)(4)), ((Half)(3.5)));
            var v = ov.swizzle.wwx;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(0.5)), ((Half)(3.5)), ((Half)(-7)));
            var v = ov.swizzle.wwxx;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(9)), ((Half)(4)), ((Half)(9.5)));
            var v = ov.swizzle.wwxy;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(7)), ((Half)(-3.5)), ((Half)(-6.5)));
            var v = ov.swizzle.wwxz;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(3.5)), ((Half)(-4.5)), ((Half)(6.5)));
            var v = ov.swizzle.wwxw;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(-2)), ((Half)(6.5)), ((Half)(-6)));
            var v = ov.swizzle.wwy;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-4)), Half.One, ((Half)(-7)), ((Half)(-8.5)));
            var v = ov.swizzle.wwyx;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(-4.5)), ((Half)(0.5)), ((Half)(2.5)));
            var v = ov.swizzle.wwyy;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(2)), Half.Zero, ((Half)(-9)));
            var v = ov.swizzle.wwyz;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(-8.5)), ((Half)(-2.5)), ((Half)(0.5)));
            var v = ov.swizzle.wwyw;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4.5)), ((Half)(9.5)), ((Half)(7.5)), ((Half)(9)));
            var v = ov.swizzle.wwz;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(8)), Half.One, ((Half)(6)), ((Half)(-5)));
            var v = ov.swizzle.wwzx;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(8.5)), ((Half)(-7.5)), ((Half)(-5.5)));
            var v = ov.swizzle.wwzy;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), ((Half)(-8.5)), ((Half)(-5.5)), ((Half)(-3)));
            var v = ov.swizzle.wwzz;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(-1.5)), ((Half)(-9.5)), ((Half)(2)));
            var v = ov.swizzle.wwzw;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(-2)), ((Half)(4.5)), ((Half)(-7)));
            var v = ov.swizzle.www;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-9)), ((Half)(-2)), ((Half)(-1)), ((Half)(9.5)));
            var v = ov.swizzle.wwwx;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(6)), ((Half)(9)), ((Half)(6)));
            var v = ov.swizzle.wwwy;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(4.5)), ((Half)(-1)), ((Half)(-3)));
            var v = ov.swizzle.wwwz;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(-3.5)), ((Half)(6)), ((Half)(-3)));
            var v = ov.swizzle.wwww;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-3)), ((Half)(-9.5)), Half.One);
            var v = ov.swizzle.rr;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(-3)), ((Half)(2)), Half.One);
            var v = ov.swizzle.rrr;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(2.5)), ((Half)(2)), ((Half)(-9)));
            var v = ov.swizzle.rrrr;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(7)), ((Half)(8)), ((Half)(2)));
            var v = ov.swizzle.rrrg;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(-3.5)), ((Half)(-3.5)), ((Half)(-9.5)));
            var v = ov.swizzle.rrrb;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(-9)), ((Half)(4)), ((Half)(-2.5)));
            var v = ov.swizzle.rrra;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(-4)), ((Half)(4.5)), ((Half)(-1)));
            var v = ov.swizzle.rrg;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(-3)), ((Half)(7.5)), ((Half)(-8.5)));
            var v = ov.swizzle.rrgr;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(-8.5)), ((Half)(2.5)), ((Half)(-6.5)));
            var v = ov.swizzle.rrgg;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(-5)), ((Half)(0.5)), ((Half)(7)));
            var v = ov.swizzle.rrgb;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(6.5)), ((Half)(9)), ((Half)(-6)));
            var v = ov.swizzle.rrga;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(4)), ((Half)(-7.5)), ((Half)(3.5)));
            var v = ov.swizzle.rrb;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(8.5)), ((Half)(5.5)), ((Half)(5)));
            var v = ov.swizzle.rrbr;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(-6)), ((Half)(9)), ((Half)(8.5)));
            var v = ov.swizzle.rrbg;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(3.5)), ((Half)(9.5)), ((Half)(-3.5)));
            var v = ov.swizzle.rrbb;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8)), ((Half)(2.5)), ((Half)(6)), ((Half)(-6.5)));
            var v = ov.swizzle.rrba;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(-8.5)), ((Half)(8)), ((Half)(-4)));
            var v = ov.swizzle.rra;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(-4.5)), Half.Zero, ((Half)(-8.5)));
            var v = ov.swizzle.rrar;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(-9)), ((Half)(9)), ((Half)(-3.5)));
            var v = ov.swizzle.rrag;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8)), ((Half)(-0.5)), ((Half)(-6.5)), ((Half)(8.5)));
            var v = ov.swizzle.rrab;
            Assert.That(((Half)(8)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(1.5)), Half.Zero, ((Half)(-6)), ((Half)(6.5)));
            var v = ov.swizzle.rraa;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8)), ((Half)(1.5)), ((Half)(-0.5)), ((Half)(4.5)));
            var v = ov.swizzle.rg;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(3.5)), ((Half)(-6)), ((Half)(8)));
            var v = ov.swizzle.rgr;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(3)), ((Half)(-0.5)), ((Half)(-8)));
            var v = ov.swizzle.rgrr;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(0.5)), ((Half)(-3.5)), ((Half)(-9.5)), ((Half)(-6.5)));
            var v = ov.swizzle.rgrg;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(8)), ((Half)(-8)), ((Half)(9)));
            var v = ov.swizzle.rgrb;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(-4)), ((Half)(9)), ((Half)(-4)));
            var v = ov.swizzle.rgra;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(-6.5)), ((Half)(0.5)), ((Half)(-8)));
            var v = ov.swizzle.rgg;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-1)), Half.One, ((Half)(4.5)), ((Half)(-7)));
            var v = ov.swizzle.rggr;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(9)), ((Half)(5)), ((Half)(3)));
            var v = ov.swizzle.rggg;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(-4)), ((Half)(2)), ((Half)(-7.5)));
            var v = ov.swizzle.rggb;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9)), ((Half)(1.5)), ((Half)(5)), ((Half)(2.5)));
            var v = ov.swizzle.rgga;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(0.5)), ((Half)(1.5)), ((Half)(6.5)), ((Half)(-7.5)));
            var v = ov.swizzle.rgb;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(8)), ((Half)(9.5)), ((Half)(2)), ((Half)(-6.5)));
            var v = ov.swizzle.rgbr;
            Assert.That(((Half)(8)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(((Half)(8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(6)), ((Half)(8.5)), ((Half)(4)));
            var v = ov.swizzle.rgbg;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(-6)), ((Half)(-1.5)), ((Half)(-1.5)));
            var v = ov.swizzle.rgbb;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(7.5)), ((Half)(8.5)), ((Half)(-4)));
            var v = ov.swizzle.rgba;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8)), ((Half)(-2)), ((Half)(2)), ((Half)(-8.5)));
            var v = ov.swizzle.rga;
            Assert.That(((Half)(8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(-7)), ((Half)(0.5)), ((Half)(-7.5)));
            var v = ov.swizzle.rgar;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5)), ((Half)(5.5)), ((Half)(9.5)), ((Half)(7)));
            var v = ov.swizzle.rgag;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(-7)), ((Half)(-5.5)), ((Half)(-5)));
            var v = ov.swizzle.rgab;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(7)), ((Half)(9)), ((Half)(-1)));
            var v = ov.swizzle.rgaa;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(-2)), ((Half)(4.5)), ((Half)(8)));
            var v = ov.swizzle.rb;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-2)), Half.One, ((Half)(-8.5)), ((Half)(-6)));
            var v = ov.swizzle.rbr;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-4.5)), ((Half)(-5)), ((Half)(-9)), ((Half)(-2)));
            var v = ov.swizzle.rbrr;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3.5)), ((Half)(1.5)), ((Half)(-5.5)), ((Half)(-8)));
            var v = ov.swizzle.rbrg;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(-6)), Half.One, ((Half)(1.5)));
            var v = ov.swizzle.rbrb;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8)), ((Half)(-9.5)), ((Half)(-7)), ((Half)(-2.5)));
            var v = ov.swizzle.rbra;
            Assert.That(((Half)(8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(1.5)), ((Half)(6.5)), ((Half)(5)));
            var v = ov.swizzle.rbg;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(-4)), Half.Zero, ((Half)(5.5)));
            var v = ov.swizzle.rbgr;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(-2.5)), ((Half)(-5)), ((Half)(7.5)));
            var v = ov.swizzle.rbgg;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(3.5)), ((Half)(8)), ((Half)(-9.5)));
            var v = ov.swizzle.rbgb;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(-4)), ((Half)(6.5)), ((Half)(1.5)));
            var v = ov.swizzle.rbga;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-1.5)), ((Half)(-5)), ((Half)(-6)));
            var v = ov.swizzle.rbb;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(3.5)), ((Half)(5)), ((Half)(-3.5)), ((Half)(-2)));
            var v = ov.swizzle.rbbr;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(-8)), Half.One, ((Half)(-8)));
            var v = ov.swizzle.rbbg;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(7)), Half.One, ((Half)(-8.5)));
            var v = ov.swizzle.rbbb;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(-6)), ((Half)(-5.5)), ((Half)(-2)));
            var v = ov.swizzle.rbba;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(-6.5)), ((Half)(-4.5)), ((Half)(5)));
            var v = ov.swizzle.rba;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-3.5)), Half.One, ((Half)(5.5)));
            var v = ov.swizzle.rbar;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(-8.5)), ((Half)(6.5)), ((Half)(5.5)));
            var v = ov.swizzle.rbag;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), ((Half)(-3.5)), ((Half)(9)), ((Half)(-9)));
            var v = ov.swizzle.rbab;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-9.5)), ((Half)(-2)), ((Half)(-3.5)));
            var v = ov.swizzle.rbaa;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(-0.5)), ((Half)(-0.5)), ((Half)(9)));
            var v = ov.swizzle.ra;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-4.5)), ((Half)(6.5)), ((Half)(3)), ((Half)(8)));
            var v = ov.swizzle.rar;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(-1.5)), ((Half)(-5)), ((Half)(-9.5)));
            var v = ov.swizzle.rarr;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(0.5)), ((Half)(-4.5)), ((Half)(-7)), ((Half)(3.5)));
            var v = ov.swizzle.rarg;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(8)), ((Half)(9.5)), ((Half)(6)));
            var v = ov.swizzle.rarb;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(1.5)), ((Half)(4)), ((Half)(-4.5)));
            var v = ov.swizzle.rara;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(6)), ((Half)(4.5)), ((Half)(7)));
            var v = ov.swizzle.rag;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(-7.5)), ((Half)(3)), ((Half)(-4.5)));
            var v = ov.swizzle.ragr;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(7.5)), ((Half)(-5.5)), ((Half)(-5.5)));
            var v = ov.swizzle.ragg;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(-5)), ((Half)(-8.5)), ((Half)(-9.5)));
            var v = ov.swizzle.ragb;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(2.5)), ((Half)(3)), ((Half)(-8)));
            var v = ov.swizzle.raga;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(-6)), ((Half)(4)), ((Half)(8.5)));
            var v = ov.swizzle.rab;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(9)), ((Half)(-7)), ((Half)(-6)), ((Half)(7)));
            var v = ov.swizzle.rabr;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9.5)), ((Half)(4)), ((Half)(-7.5)), ((Half)(6.5)));
            var v = ov.swizzle.rabg;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), ((Half)(3)), ((Half)(-1.5)), ((Half)(-8)));
            var v = ov.swizzle.rabb;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(5.5)), ((Half)(-1)), ((Half)(9)));
            var v = ov.swizzle.raba;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), ((Half)(0.5)), ((Half)(-6)), ((Half)(2.5)));
            var v = ov.swizzle.raa;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(2.5)), ((Half)(8.5)), ((Half)(-1.5)));
            var v = ov.swizzle.raar;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(-9.5)), ((Half)(-5.5)), ((Half)(-2)));
            var v = ov.swizzle.raag;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(-2.5)), ((Half)(-9)), ((Half)(5)));
            var v = ov.swizzle.raab;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(6.5)), ((Half)(8.5)), ((Half)(-7.5)));
            var v = ov.swizzle.raaa;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(6.5)), ((Half)(4)), ((Half)(9.5)));
            var v = ov.swizzle.gr;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(-1.5)), ((Half)(9.5)), ((Half)(1.5)));
            var v = ov.swizzle.grr;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(2)), ((Half)(-8)), ((Half)(-1.5)));
            var v = ov.swizzle.grrr;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(4.5)), ((Half)(3.5)), ((Half)(-6)));
            var v = ov.swizzle.grrg;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(-3)), ((Half)(8.5)), ((Half)(-7)));
            var v = ov.swizzle.grrb;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8)), ((Half)(-1.5)), ((Half)(-9.5)), Half.Zero);
            var v = ov.swizzle.grra;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(-1)), ((Half)(8)), ((Half)(7.5)));
            var v = ov.swizzle.grg;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-4.5)), ((Half)(-7.5)), ((Half)(-7)), ((Half)(5)));
            var v = ov.swizzle.grgr;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(-1.5)), ((Half)(2)), ((Half)(-1.5)));
            var v = ov.swizzle.grgg;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(-6)), ((Half)(-7)), ((Half)(-3)));
            var v = ov.swizzle.grgb;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(7)), Half.Zero, ((Half)(-4.5)));
            var v = ov.swizzle.grga;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(5.5)), ((Half)(0.5)), ((Half)(3.5)));
            var v = ov.swizzle.grb;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(2)), ((Half)(4)), ((Half)(-0.5)));
            var v = ov.swizzle.grbr;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(-7.5)), ((Half)(3)), ((Half)(-8)));
            var v = ov.swizzle.grbg;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(3)), ((Half)(-8)), ((Half)(4)));
            var v = ov.swizzle.grbb;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9)), ((Half)(2)), ((Half)(6)), ((Half)(5)));
            var v = ov.swizzle.grba;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(-2)), ((Half)(1.5)), ((Half)(3.5)));
            var v = ov.swizzle.gra;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(1.5)), ((Half)(4)), ((Half)(0.5)), ((Half)(-4.5)));
            var v = ov.swizzle.grar;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(-4.5)), ((Half)(-5.5)), ((Half)(9)));
            var v = ov.swizzle.grag;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(5.5)), ((Half)(7.5)), ((Half)(-4.5)));
            var v = ov.swizzle.grab;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(-6)), ((Half)(3)), ((Half)(-7.5)));
            var v = ov.swizzle.graa;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-2.5)), ((Half)(7)), ((Half)(-5)));
            var v = ov.swizzle.gg;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), ((Half)(-5.5)), ((Half)(-3)), ((Half)(-7.5)));
            var v = ov.swizzle.ggr;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(-3)), ((Half)(3.5)), ((Half)(0.5)));
            var v = ov.swizzle.ggrr;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(5.5)), ((Half)(9.5)), ((Half)(1.5)));
            var v = ov.swizzle.ggrg;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(6.5)), ((Half)(2)), ((Half)(-0.5)));
            var v = ov.swizzle.ggrb;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(-9.5)), ((Half)(3.5)), ((Half)(-3)));
            var v = ov.swizzle.ggra;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(4.5)), ((Half)(1.5)), ((Half)(-9.5)));
            var v = ov.swizzle.ggg;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(5)), ((Half)(2.5)), ((Half)(-5.5)), ((Half)(3)));
            var v = ov.swizzle.gggr;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9.5)), ((Half)(-5.5)), ((Half)(-1.5)), ((Half)(8.5)));
            var v = ov.swizzle.gggg;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(-6)), ((Half)(8)), ((Half)(6)));
            var v = ov.swizzle.gggb;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(8)), ((Half)(-2.5)), ((Half)(-6.5)));
            var v = ov.swizzle.ggga;
            Assert.That(((Half)(8)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(4.5)), ((Half)(8)), ((Half)(1.5)));
            var v = ov.swizzle.ggb;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(6)), ((Half)(-8.5)), ((Half)(-5.5)));
            var v = ov.swizzle.ggbr;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3)), ((Half)(-4)), ((Half)(-1)), ((Half)(7.5)));
            var v = ov.swizzle.ggbg;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3.5)), ((Half)(5.5)), ((Half)(-8)), ((Half)(0.5)));
            var v = ov.swizzle.ggbb;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3.5)), ((Half)(2.5)), ((Half)(-6)), ((Half)(5)));
            var v = ov.swizzle.ggba;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(-0.5)), ((Half)(1.5)), ((Half)(-7)));
            var v = ov.swizzle.gga;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(7)), Half.Zero, ((Half)(-2.5)), ((Half)(-0.5)));
            var v = ov.swizzle.ggar;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(5.5)), ((Half)(7.5)), ((Half)(3)));
            var v = ov.swizzle.ggag;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3.5)), ((Half)(-1)), ((Half)(-9.5)), ((Half)(2)));
            var v = ov.swizzle.ggab;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4.5)), ((Half)(9.5)), ((Half)(-5.5)), ((Half)(8.5)));
            var v = ov.swizzle.ggaa;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(9.5)), ((Half)(0.5)), ((Half)(-4.5)));
            var v = ov.swizzle.gb;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(0.5)), ((Half)(5)), ((Half)(8)));
            var v = ov.swizzle.gbr;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(-8)), ((Half)(-3)), ((Half)(9.5)));
            var v = ov.swizzle.gbrr;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(-7.5)), ((Half)(4.5)), ((Half)(2)));
            var v = ov.swizzle.gbrg;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(1.5)), ((Half)(-5.5)), ((Half)(5.5)));
            var v = ov.swizzle.gbrb;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9.5)), ((Half)(1.5)), ((Half)(6.5)), ((Half)(-8)));
            var v = ov.swizzle.gbra;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(6)), ((Half)(4)), ((Half)(-6.5)));
            var v = ov.swizzle.gbg;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(-6)), ((Half)(5)), ((Half)(3.5)));
            var v = ov.swizzle.gbgr;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(-7)), ((Half)(3.5)), ((Half)(0.5)));
            var v = ov.swizzle.gbgg;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9.5)), ((Half)(5)), ((Half)(3)), ((Half)(-7)));
            var v = ov.swizzle.gbgb;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(-9)), ((Half)(1.5)), ((Half)(9)));
            var v = ov.swizzle.gbga;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(8.5)), ((Half)(-1)), ((Half)(-1)));
            var v = ov.swizzle.gbb;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-7)), ((Half)(9.5)), ((Half)(3.5)));
            var v = ov.swizzle.gbbr;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(-0.5)), ((Half)(-9)), ((Half)(-9.5)));
            var v = ov.swizzle.gbbg;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(-3)), ((Half)(7)), ((Half)(6)));
            var v = ov.swizzle.gbbb;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(-7.5)), ((Half)(3.5)), ((Half)(-7.5)));
            var v = ov.swizzle.gbba;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3)), ((Half)(-9.5)), ((Half)(1.5)), ((Half)(-5)));
            var v = ov.swizzle.gba;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(4)), ((Half)(3)), ((Half)(7.5)));
            var v = ov.swizzle.gbar;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(6)), Half.Zero, Half.One);
            var v = ov.swizzle.gbag;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(-2.5)), ((Half)(5.5)), ((Half)(-9)));
            var v = ov.swizzle.gbab;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(3.5)), ((Half)(5)), ((Half)(8.5)));
            var v = ov.swizzle.gbaa;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(-2)), ((Half)(-8)), ((Half)(-9)));
            var v = ov.swizzle.ga;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(-4)), ((Half)(-2.5)), ((Half)(-3.5)));
            var v = ov.swizzle.gar;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(6.5)), ((Half)(0.5)), ((Half)(-3)));
            var v = ov.swizzle.garr;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4.5)), ((Half)(9)), ((Half)(7.5)), ((Half)(2)));
            var v = ov.swizzle.garg;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(6.5)), ((Half)(-6.5)), ((Half)(-3)));
            var v = ov.swizzle.garb;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), Half.One, ((Half)(5)), ((Half)(9)));
            var v = ov.swizzle.gara;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(-7)), ((Half)(-9.5)), ((Half)(-6)));
            var v = ov.swizzle.gag;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-0.5)), ((Half)(-2)), ((Half)(3.5)));
            var v = ov.swizzle.gagr;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(5.5)), ((Half)(5)), Half.Zero);
            var v = ov.swizzle.gagg;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(-3)), ((Half)(-7)), ((Half)(-5)));
            var v = ov.swizzle.gagb;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-7)), Half.Zero, ((Half)(1.5)));
            var v = ov.swizzle.gaga;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(-2.5)), ((Half)(-6)), ((Half)(0.5)));
            var v = ov.swizzle.gab;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(2.5)), ((Half)(-3)), ((Half)(9.5)));
            var v = ov.swizzle.gabr;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(3.5)), ((Half)(-5.5)), ((Half)(-5)));
            var v = ov.swizzle.gabg;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(7)), ((Half)(-0.5)), ((Half)(-8.5)));
            var v = ov.swizzle.gabb;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3.5)), ((Half)(-2)), ((Half)(9)), ((Half)(8)));
            var v = ov.swizzle.gaba;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4.5)), ((Half)(7.5)), ((Half)(6.5)), ((Half)(0.5)));
            var v = ov.swizzle.gaa;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(7.5)), Half.Zero, ((Half)(3.5)));
            var v = ov.swizzle.gaar;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9)), ((Half)(7)), ((Half)(5.5)), ((Half)(6.5)));
            var v = ov.swizzle.gaag;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(-4)), ((Half)(3.5)), Half.One);
            var v = ov.swizzle.gaab;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(-0.5)), ((Half)(-3.5)), ((Half)(-4.5)));
            var v = ov.swizzle.gaaa;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-2)), ((Half)(-6.5)), ((Half)(-6.5)));
            var v = ov.swizzle.br;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(0.5)), ((Half)(4.5)), ((Half)(4.5)));
            var v = ov.swizzle.brr;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(5.5)), ((Half)(-7.5)), ((Half)(4)));
            var v = ov.swizzle.brrr;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(2.5)), ((Half)(6)), ((Half)(-8)));
            var v = ov.swizzle.brrg;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(0.5)), ((Half)(-3.5)), ((Half)(-3.5)), ((Half)(2.5)));
            var v = ov.swizzle.brrb;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(-9)), ((Half)(-9.5)), ((Half)(2)));
            var v = ov.swizzle.brra;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(-2.5)), ((Half)(-4)), ((Half)(2.5)));
            var v = ov.swizzle.brg;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(-1.5)), ((Half)(-9.5)), ((Half)(3)));
            var v = ov.swizzle.brgr;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(-4.5)), ((Half)(1.5)), ((Half)(-3)));
            var v = ov.swizzle.brgg;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(-4)), ((Half)(-9.5)), ((Half)(-4)));
            var v = ov.swizzle.brgb;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(6)), ((Half)(9)), ((Half)(-6.5)));
            var v = ov.swizzle.brga;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(1.5)), ((Half)(-0.5)), ((Half)(8)));
            var v = ov.swizzle.brb;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(-5)), ((Half)(-2)), ((Half)(-6)));
            var v = ov.swizzle.brbr;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(3.5)), ((Half)(2.5)), ((Half)(7.5)));
            var v = ov.swizzle.brbg;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(1.5)), ((Half)(-9.5)), ((Half)(-4.5)), ((Half)(-6.5)));
            var v = ov.swizzle.brbb;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), Half.One, ((Half)(-9.5)), ((Half)(5.5)));
            var v = ov.swizzle.brba;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(-8)), ((Half)(-9)), ((Half)(-6.5)));
            var v = ov.swizzle.bra;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(3.5)), ((Half)(3)), ((Half)(-7)));
            var v = ov.swizzle.brar;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5)), ((Half)(-3)), ((Half)(-0.5)), ((Half)(-3.5)));
            var v = ov.swizzle.brag;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8)), ((Half)(7.5)), ((Half)(-7)), ((Half)(6)));
            var v = ov.swizzle.brab;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(4)), ((Half)(-5.5)), ((Half)(9.5)));
            var v = ov.swizzle.braa;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(4)), Half.Zero, ((Half)(3.5)));
            var v = ov.swizzle.bg;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(3.5)), ((Half)(-8.5)), ((Half)(5.5)));
            var v = ov.swizzle.bgr;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(6.5)), ((Half)(7.5)), Half.One);
            var v = ov.swizzle.bgrr;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(-5)), ((Half)(7)), ((Half)(8)));
            var v = ov.swizzle.bgrg;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(5)), ((Half)(8)), ((Half)(-4)));
            var v = ov.swizzle.bgrb;
            Assert.That(((Half)(8)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(4.5)), ((Half)(9)), ((Half)(0.5)));
            var v = ov.swizzle.bgra;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(6)), ((Half)(-0.5)), ((Half)(4.5)));
            var v = ov.swizzle.bgg;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(-9)), ((Half)(-5.5)), ((Half)(-2)));
            var v = ov.swizzle.bggr;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-8.5)), ((Half)(-9)), ((Half)(-2)));
            var v = ov.swizzle.bggg;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-4.5)), ((Half)(1.5)), ((Half)(7)));
            var v = ov.swizzle.bggb;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3)), ((Half)(8)), ((Half)(-0.5)), ((Half)(8)));
            var v = ov.swizzle.bgga;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
            Assert.That(((Half)(8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(-1.5)), ((Half)(9.5)), ((Half)(4.5)));
            var v = ov.swizzle.bgb;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(0.5)), ((Half)(8)), ((Half)(4.5)), ((Half)(2.5)));
            var v = ov.swizzle.bgbr;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(9)), ((Half)(-2.5)), ((Half)(-7.5)));
            var v = ov.swizzle.bgbg;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(-1)), ((Half)(0.5)), ((Half)(-4.5)));
            var v = ov.swizzle.bgbb;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(-2.5)), ((Half)(1.5)), ((Half)(8)));
            var v = ov.swizzle.bgba;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), ((Half)(-3.5)), ((Half)(-5.5)), ((Half)(5)));
            var v = ov.swizzle.bga;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(6.5)), ((Half)(1.5)), ((Half)(-2.5)));
            var v = ov.swizzle.bgar;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5)), Half.One, Half.One, ((Half)(2)));
            var v = ov.swizzle.bgag;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5)), Half.Zero, ((Half)(-5)), ((Half)(-5)));
            var v = ov.swizzle.bgab;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(4.5)), ((Half)(4)), ((Half)(5.5)));
            var v = ov.swizzle.bgaa;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4.5)), ((Half)(2.5)), ((Half)(-5)), ((Half)(7)));
            var v = ov.swizzle.bb;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(3.5)), ((Half)(7.5)), ((Half)(-6)), ((Half)(6)));
            var v = ov.swizzle.bbr;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(5)), ((Half)(2)), ((Half)(-3.5)));
            var v = ov.swizzle.bbrr;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(-9.5)), ((Half)(7.5)), ((Half)(-0.5)));
            var v = ov.swizzle.bbrg;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(4.5)), ((Half)(9.5)), ((Half)(4.5)));
            var v = ov.swizzle.bbrb;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(7)), ((Half)(-8)), ((Half)(4.5)));
            var v = ov.swizzle.bbra;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8)), ((Half)(-5.5)), ((Half)(-7)), ((Half)(4.5)));
            var v = ov.swizzle.bbg;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(-5)), ((Half)(-8)), ((Half)(-1)));
            var v = ov.swizzle.bbgr;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(6.5)), ((Half)(-5.5)), ((Half)(-9.5)));
            var v = ov.swizzle.bbgg;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(-7)), ((Half)(-2)), ((Half)(8.5)));
            var v = ov.swizzle.bbgb;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9.5)), ((Half)(-5.5)), ((Half)(1.5)), ((Half)(9)));
            var v = ov.swizzle.bbga;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(-6)), ((Half)(-3.5)), ((Half)(-4.5)));
            var v = ov.swizzle.bbb;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(-4.5)), ((Half)(-1)), ((Half)(-4)));
            var v = ov.swizzle.bbbr;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(9)), ((Half)(-8)), ((Half)(-8)));
            var v = ov.swizzle.bbbg;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(-9.5)), ((Half)(8.5)), ((Half)(8)));
            var v = ov.swizzle.bbbb;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(-7.5)), ((Half)(-1)), ((Half)(-9.5)));
            var v = ov.swizzle.bbba;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(2.5)), ((Half)(3)), ((Half)(-8.5)));
            var v = ov.swizzle.bba;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(-7)), ((Half)(-9)), ((Half)(-2.5)));
            var v = ov.swizzle.bbar;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), Half.Zero, ((Half)(-5)), ((Half)(2.5)));
            var v = ov.swizzle.bbag;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(7)), ((Half)(6.5)), ((Half)(2.5)));
            var v = ov.swizzle.bbab;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(1.5)), ((Half)(1.5)), ((Half)(-1)));
            var v = ov.swizzle.bbaa;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(4)), ((Half)(-5)), ((Half)(-2)));
            var v = ov.swizzle.ba;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-9)), ((Half)(6)), ((Half)(5)), ((Half)(0.5)));
            var v = ov.swizzle.bar;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-8)), ((Half)(2)), ((Half)(-8)), ((Half)(7.5)));
            var v = ov.swizzle.barr;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3)), ((Half)(-1)), ((Half)(-8.5)), ((Half)(6)));
            var v = ov.swizzle.barg;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3)), ((Half)(5)), ((Half)(-0.5)), ((Half)(-3.5)));
            var v = ov.swizzle.barb;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(-6.5)), ((Half)(1.5)), ((Half)(4.5)));
            var v = ov.swizzle.bara;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(-4.5)), Half.One, ((Half)(6)));
            var v = ov.swizzle.bag;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), ((Half)(6)), ((Half)(-1)), ((Half)(-0.5)));
            var v = ov.swizzle.bagr;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(0.5)), Half.Zero, ((Half)(-6)), ((Half)(-5.5)));
            var v = ov.swizzle.bagg;
            Assert.That(((Half)(-6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(1.5)), Half.One, ((Half)(-0.5)));
            var v = ov.swizzle.bagb;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(-1.5)), ((Half)(9)), ((Half)(-9)));
            var v = ov.swizzle.baga;
            Assert.That(((Half)(9)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(-7)), ((Half)(-9)), ((Half)(4)));
            var v = ov.swizzle.bab;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(-0.5)), ((Half)(-9.5)), ((Half)(3.5)));
            var v = ov.swizzle.babr;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(4)), ((Half)(3)), ((Half)(-8.5)));
            var v = ov.swizzle.babg;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3)), ((Half)(-8.5)), ((Half)(-7)), ((Half)(3.5)));
            var v = ov.swizzle.babb;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(9.5)), ((Half)(6)), ((Half)(-1)));
            var v = ov.swizzle.baba;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(-1.5)), ((Half)(6)), ((Half)(-3)));
            var v = ov.swizzle.baa;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(7.5)), ((Half)(-0.5)), ((Half)(-7.5)));
            var v = ov.swizzle.baar;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3)), Half.Zero, ((Half)(-5)), ((Half)(-8)));
            var v = ov.swizzle.baag;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(-2)), ((Half)(-1)), ((Half)(-9)));
            var v = ov.swizzle.baab;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5)), ((Half)(7.5)), ((Half)(-9.5)), ((Half)(4.5)));
            var v = ov.swizzle.baaa;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(-8)), ((Half)(-1.5)), ((Half)(-3.5)));
            var v = ov.swizzle.ar;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(5.5)), ((Half)(-1)), ((Half)(6.5)));
            var v = ov.swizzle.arr;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(8)), ((Half)(-4.5)), ((Half)(-2)));
            var v = ov.swizzle.arrr;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(8.5)), ((Half)(-2.5)), ((Half)(5.5)));
            var v = ov.swizzle.arrg;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9)), ((Half)(6)), ((Half)(9)), ((Half)(-0.5)));
            var v = ov.swizzle.arrb;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(8.5)), ((Half)(-0.5)), Half.Zero);
            var v = ov.swizzle.arra;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(-3.5)), ((Half)(6)), Half.One);
            var v = ov.swizzle.arg;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(9)), ((Half)(7.5)), ((Half)(-2.5)), ((Half)(7)));
            var v = ov.swizzle.argr;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9.5)), ((Half)(-2)), ((Half)(-5.5)), ((Half)(-5)));
            var v = ov.swizzle.argg;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9.5)), ((Half)(-8.5)), ((Half)(-6)), ((Half)(9.5)));
            var v = ov.swizzle.argb;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(3.5)), ((Half)(6)), ((Half)(4.5)));
            var v = ov.swizzle.arga;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(3)), ((Half)(6.5)), ((Half)(-5)));
            var v = ov.swizzle.arb;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), ((Half)(-6)), ((Half)(9)), ((Half)(9.5)));
            var v = ov.swizzle.arbr;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(0.5)), ((Half)(4.5)), ((Half)(-1.5)));
            var v = ov.swizzle.arbg;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(-2.5)), ((Half)(7.5)), ((Half)(-1)));
            var v = ov.swizzle.arbb;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(9)), ((Half)(-3.5)), ((Half)(-7)));
            var v = ov.swizzle.arba;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-7.5)), ((Half)(-7)), ((Half)(2.5)), ((Half)(-1)));
            var v = ov.swizzle.ara;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(-3)), ((Half)(5.5)), ((Half)(-1.5)));
            var v = ov.swizzle.arar;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(0.5)), ((Half)(-1)), Half.One, ((Half)(7)));
            var v = ov.swizzle.arag;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(1.5)), ((Half)(5.5)), ((Half)(-4.5)), ((Half)(-3.5)));
            var v = ov.swizzle.arab;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-0.5)), ((Half)(1.5)), ((Half)(-7)), ((Half)(3.5)));
            var v = ov.swizzle.araa;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2.5)), ((Half)(-2.5)), ((Half)(-9.5)), ((Half)(-0.5)));
            var v = ov.swizzle.ag;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(6.5)), ((Half)(-3.5)), ((Half)(-2)));
            var v = ov.swizzle.agr;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), ((Half)(5)), ((Half)(-1)), ((Half)(-8)));
            var v = ov.swizzle.agrr;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6)), ((Half)(0.5)), ((Half)(-3)), ((Half)(8.5)));
            var v = ov.swizzle.agrg;
            Assert.That(((Half)(8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1)), ((Half)(-3.5)), Half.One, ((Half)(-2)));
            var v = ov.swizzle.agrb;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8.5)), ((Half)(-8.5)), ((Half)(8)), ((Half)(-7)));
            var v = ov.swizzle.agra;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(-2.5)), ((Half)(7.5)), ((Half)(3.5)));
            var v = ov.swizzle.agg;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(-2)), ((Half)(-8.5)), ((Half)(6.5)));
            var v = ov.swizzle.aggr;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3.5)), ((Half)(3.5)), ((Half)(-0.5)), ((Half)(4.5)));
            var v = ov.swizzle.aggg;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(3)), ((Half)(3.5)), ((Half)(-8)));
            var v = ov.swizzle.aggb;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(-6.5)), ((Half)(4)), ((Half)(-4.5)));
            var v = ov.swizzle.agga;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9.5)), ((Half)(-5.5)), Half.Zero, Half.One);
            var v = ov.swizzle.agb;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(-2.5)), ((Half)(-5)), ((Half)(3)));
            var v = ov.swizzle.agbr;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(0.5)), ((Half)(4)), ((Half)(-3)), ((Half)(6)));
            var v = ov.swizzle.agbg;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-8)), ((Half)(3)), Half.Zero, ((Half)(-0.5)));
            var v = ov.swizzle.agbb;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8.5)), ((Half)(3.5)), ((Half)(9)), ((Half)(-2)));
            var v = ov.swizzle.agba;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5.5)), ((Half)(-4)), ((Half)(-4.5)), ((Half)(-4)));
            var v = ov.swizzle.aga;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(-8)), Half.One, ((Half)(6)));
            var v = ov.swizzle.agar;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(6)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(-6.5)), ((Half)(-4.5)), ((Half)(7.5)));
            var v = ov.swizzle.agag;
            Assert.That(((Half)(7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6)), ((Half)(-5.5)), ((Half)(-7)), ((Half)(3)));
            var v = ov.swizzle.agab;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(6.5)), ((Half)(9)), ((Half)(-5)));
            var v = ov.swizzle.agaa;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(6.5)), ((Half)(-8)), ((Half)(6)), ((Half)(-1.5)));
            var v = ov.swizzle.ab;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(-9.5)), ((Half)(-6.5)), ((Half)(-6)), ((Half)(3.5)));
            var v = ov.swizzle.abr;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(3)), ((Half)(-9)), ((Half)(2.5)));
            var v = ov.swizzle.abrr;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(((Half)(3)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4)), ((Half)(2.5)), Half.One, ((Half)(-3.5)));
            var v = ov.swizzle.abrg;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9.5)), ((Half)(-2.5)), Half.Zero, ((Half)(4)));
            var v = ov.swizzle.abrb;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-4.5)), ((Half)(7)), ((Half)(-1)), ((Half)(6)));
            var v = ov.swizzle.abra;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-9.5)), ((Half)(-6)), ((Half)(0.5)), ((Half)(4.5)));
            var v = ov.swizzle.abg;
            Assert.That(((Half)(4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(6.5)), ((Half)(3)), ((Half)(2)));
            var v = ov.swizzle.abgr;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(4.5)), ((Half)(-6)), ((Half)(5)));
            var v = ov.swizzle.abgg;
            Assert.That(((Half)(5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(6.5)), ((Half)(3.5)), ((Half)(-7)));
            var v = ov.swizzle.abgb;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.One, ((Half)(7)), ((Half)(3)), ((Half)(-0.5)));
            var v = ov.swizzle.abga;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(2.5)), ((Half)(-6.5)), ((Half)(-5.5)));
            var v = ov.swizzle.abb;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(0.5)), ((Half)(4)), ((Half)(9.5)));
            var v = ov.swizzle.abbr;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(5.5)), ((Half)(5)), ((Half)(-0.5)), ((Half)(-1.5)));
            var v = ov.swizzle.abbg;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7)), ((Half)(9.5)), ((Half)(8)), ((Half)(4)));
            var v = ov.swizzle.abbb;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
            Assert.That(((Half)(8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3.5)), ((Half)(-7.5)), ((Half)(7)), ((Half)(6)));
            var v = ov.swizzle.abba;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(-6)), ((Half)(9)), ((Half)(-9)));
            var v = ov.swizzle.aba;
            Assert.That(((Half)(-9)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-7)), ((Half)(5.5)), ((Half)(-9)), ((Half)(2)));
            var v = ov.swizzle.abar;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(-5.5)), ((Half)(2)), ((Half)(-8)));
            var v = ov.swizzle.abag;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(-7.5)), ((Half)(2)), ((Half)(-2.5)));
            var v = ov.swizzle.abab;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(6)), ((Half)(-2)), ((Half)(5.5)));
            var v = ov.swizzle.abaa;
            Assert.That(((Half)(5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2.5)), ((Half)(4)), ((Half)(7)), ((Half)(-8)));
            var v = ov.swizzle.aa;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec4(((Half)(4)), ((Half)(-2.5)), ((Half)(8.5)), ((Half)(7)));
            var v = ov.swizzle.aar;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-1.5)), ((Half)(-1.5)), ((Half)(-6.5)), ((Half)(-9.5)));
            var v = ov.swizzle.aarr;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(7.5)), ((Half)(-1.5)), ((Half)(-1.5)));
            var v = ov.swizzle.aarg;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(4)), ((Half)(6)), ((Half)(-2.5)));
            var v = ov.swizzle.aarb;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-2)), Half.One, ((Half)(4)), ((Half)(-2)));
            var v = ov.swizzle.aara;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(2)), ((Half)(-2)), ((Half)(-5.5)), ((Half)(-3.5)));
            var v = ov.swizzle.aag;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(-8.5)), ((Half)(-3)), ((Half)(-2.5)));
            var v = ov.swizzle.aagr;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9)), ((Half)(-2)), ((Half)(-5)), ((Half)(6.5)));
            var v = ov.swizzle.aagg;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(8)), ((Half)(1.5)), ((Half)(-4)), ((Half)(-0.5)));
            var v = ov.swizzle.aagb;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(7.5)), ((Half)(-2)), ((Half)(-5)), ((Half)(6)));
            var v = ov.swizzle.aaga;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(6)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(Half.Zero, ((Half)(-6.5)), ((Half)(-8)), ((Half)(6)));
            var v = ov.swizzle.aab;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(3.5)), ((Half)(-4)), ((Half)(4)), ((Half)(-2.5)));
            var v = ov.swizzle.aabr;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9.5)), ((Half)(-5.5)), ((Half)(-5.5)), ((Half)(1.5)));
            var v = ov.swizzle.aabg;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(9.5)), ((Half)(6.5)), ((Half)(-5)), ((Half)(3.5)));
            var v = ov.swizzle.aabb;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(3)), ((Half)(-3)), ((Half)(9)), ((Half)(7)));
            var v = ov.swizzle.aaba;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(9)), Is.EqualTo(v.z));
            Assert.That(((Half)(7)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-5)), ((Half)(6.5)), ((Half)(9)), ((Half)(-1.5)));
            var v = ov.swizzle.aaa;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec4(((Half)(-6.5)), ((Half)(2.5)), ((Half)(-9.5)), ((Half)(1.5)));
            var v = ov.swizzle.aaar;
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(0.5)), ((Half)(-8)), ((Half)(0.5)), Half.Zero);
            var v = ov.swizzle.aaag;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(-3.5)), ((Half)(8.5)), ((Half)(-1)), ((Half)(-9.5)));
            var v = ov.swizzle.aaab;
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec4(((Half)(4.5)), ((Half)(-8)), ((Half)(2.5)), ((Half)(-5.5)));
            var v = ov.swizzle.aaaa;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new hvec4(((Half)(5)), ((Half)(7)), ((Half)(8.5)), ((Half)(-9)));
            var v1 = new hvec2(((Half)(7.5)), ((Half)(-0.5)));
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(7.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v0.z));
            Assert.That(((Half)(-9)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(7)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec4(((Half)(8)), ((Half)(1.5)), ((Half)(6.5)), ((Half)(4.5)));
            var v1 = new hvec2(((Half)(1.5)), ((Half)(1.5)));
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(1.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(1.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(1.5)), Is.EqualTo(v0.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(8)), Is.EqualTo(v2.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec4(((Half)(-0.5)), ((Half)(3)), ((Half)(-3)), ((Half)(8)));
            var v1 = new hvec2(((Half)(-7)), ((Half)(7)));
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-0.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v0.y));
            Assert.That(((Half)(7)), Is.EqualTo(v0.z));
            Assert.That(((Half)(8)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(3)), Is.EqualTo(v2.x));
            Assert.That(((Half)(-3)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec4(((Half)(8)), ((Half)(-7.5)), ((Half)(-0.5)), ((Half)(-4)));
            var v1 = new hvec3(((Half)(-5)), ((Half)(-4)), Half.One);
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v0.y));
            Assert.That(Half.One, Is.EqualTo(v0.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(8)), Is.EqualTo(v2.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v2.y));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v2.z));
        }
        {
            var v0 = new hvec4(((Half)(-4)), ((Half)(-8)), ((Half)(-1.5)), ((Half)(8)));
            var v1 = new hvec2(((Half)(-2.5)), ((Half)(7)));
            var v2 = v0.xw;
            v0.xw = v1;
            var v3 = v0.xw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-2.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v0.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v0.z));
            Assert.That(((Half)(7)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(-4)), Is.EqualTo(v2.x));
            Assert.That(((Half)(8)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec4(((Half)(2)), ((Half)(3)), ((Half)(-6.5)), ((Half)(5.5)));
            var v1 = new hvec2(((Half)(3.5)), Half.Zero);
            var v2 = v0.yw;
            v0.yw = v1;
            var v3 = v0.yw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(2)), Is.EqualTo(v0.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v0.z));
            Assert.That(Half.Zero, Is.EqualTo(v0.w));
        
            Assert.That(((Half)(3)), Is.EqualTo(v2.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec4(((Half)(0.5)), ((Half)(7.5)), ((Half)(2)), ((Half)(2.5)));
            var v1 = new hvec3(((Half)(-5.5)), ((Half)(-6.5)), ((Half)(8)));
            var v2 = v0.xyw;
            v0.xyw = v1;
            var v3 = v0.xyw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-5.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(2)), Is.EqualTo(v0.z));
            Assert.That(((Half)(8)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(0.5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v2.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v2.z));
        }
        {
            var v0 = new hvec4(((Half)(-7)), ((Half)(2)), ((Half)(5)), ((Half)(9)));
            var v1 = new hvec2(((Half)(-5)), ((Half)(3)));
            var v2 = v0.zw;
            v0.zw = v1;
            var v3 = v0.zw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-7)), Is.EqualTo(v0.x));
            Assert.That(((Half)(2)), Is.EqualTo(v0.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v0.z));
            Assert.That(((Half)(3)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(9)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec4(((Half)(-7)), ((Half)(-2)), ((Half)(8)), ((Half)(5.5)));
            var v1 = new hvec3(((Half)(-5)), ((Half)(2.5)), ((Half)(2.5)));
            var v2 = v0.xzw;
            v0.xzw = v1;
            var v3 = v0.xzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v0.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v0.z));
            Assert.That(((Half)(2.5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(-7)), Is.EqualTo(v2.x));
            Assert.That(((Half)(8)), Is.EqualTo(v2.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v2.z));
        }
        {
            var v0 = new hvec4(((Half)(-5.5)), ((Half)(-7)), ((Half)(-6.5)), ((Half)(-2)));
            var v1 = new hvec3(((Half)(-9.5)), ((Half)(-7.5)), ((Half)(8)));
            var v2 = v0.yzw;
            v0.yzw = v1;
            var v3 = v0.yzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-5.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v0.z));
            Assert.That(((Half)(8)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(-7)), Is.EqualTo(v2.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v2.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v2.z));
        }
        {
            var v0 = new hvec4(((Half)(-3.5)), ((Half)(-0.5)), ((Half)(-1.5)), ((Half)(6)));
            var v1 = new hvec4(((Half)(7)), ((Half)(-9.5)), ((Half)(8)), ((Half)(-3.5)));
            var v2 = v0.xyzw;
            v0.xyzw = v1;
            var v3 = v0.xyzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(7)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(8)), Is.EqualTo(v0.z));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(-3.5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v2.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v2.z));
            Assert.That(((Half)(6)), Is.EqualTo(v2.w));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new hvec4(((Half)(-9.5)), ((Half)(-6.5)), ((Half)(-6)), ((Half)(-6)));
            var v1 = ((Half)(((Half)(-9.5))));
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-9.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v0.z));
            Assert.That(((Half)(-6)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(-9.5)), Is.EqualTo(v2));
        }
        {
            var v0 = new hvec4(((Half)(5)), ((Half)(7)), ((Half)(4)), ((Half)(8.5)));
            var v1 = ((Half)(((Half)(-8))));
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v0.y));
            Assert.That(((Half)(4)), Is.EqualTo(v0.z));
            Assert.That(((Half)(8.5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(7)), Is.EqualTo(v2));
        }
        {
            var v0 = new hvec4(((Half)(4)), ((Half)(4.5)), ((Half)(4.5)), ((Half)(-5.5)));
            var v1 = new hvec2(((Half)(-3)), ((Half)(3)));
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-3)), Is.EqualTo(v0.x));
            Assert.That(((Half)(3)), Is.EqualTo(v0.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v0.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(4)), Is.EqualTo(v2.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec4(((Half)(-6)), ((Half)(2)), ((Half)(-2)), ((Half)(9.5)));
            var v1 = ((Half)(((Half)(7.5))));
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-6)), Is.EqualTo(v0.x));
            Assert.That(((Half)(2)), Is.EqualTo(v0.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v0.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(-2)), Is.EqualTo(v2));
        }
        {
            var v0 = new hvec4(((Half)(-2.5)), ((Half)(-4.5)), ((Half)(-3.5)), ((Half)(9)));
            var v1 = new hvec2(((Half)(-8)), ((Half)(9.5)));
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-8)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v0.z));
            Assert.That(((Half)(9)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(-2.5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec4(((Half)(9.5)), ((Half)(0.5)), Half.One, ((Half)(3.5)));
            var v1 = new hvec2(((Half)(6.5)), ((Half)(-5)));
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(9.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v0.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(0.5)), Is.EqualTo(v2.x));
            Assert.That(Half.One, Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec4(((Half)(9.5)), ((Half)(-7.5)), ((Half)(6)), ((Half)(-5)));
            var v1 = new hvec3(((Half)(9.5)), ((Half)(7.5)), ((Half)(-4.5)));
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(9.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v0.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(9.5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v2.y));
            Assert.That(((Half)(6)), Is.EqualTo(v2.z));
        }
        {
            var v0 = new hvec4(((Half)(-2)), ((Half)(2.5)), ((Half)(-2)), ((Half)(-5)));
            var v1 = ((Half)(((Half)(-3))));
            var v2 = v0.a;
            v0.a = v1;
            var v3 = v0.a;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-2)), Is.EqualTo(v0.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v0.z));
            Assert.That(((Half)(-3)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(-5)), Is.EqualTo(v2));
        }
        {
            var v0 = new hvec4(((Half)(5.5)), ((Half)(3.5)), ((Half)(-5)), ((Half)(0.5)));
            var v1 = new hvec2(((Half)(3.5)), ((Half)(5.5)));
            var v2 = v0.ra;
            v0.ra = v1;
            var v3 = v0.ra;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(3.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v0.z));
            Assert.That(((Half)(5.5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(5.5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec4(((Half)(-7.5)), ((Half)(-3.5)), ((Half)(3.5)), ((Half)(7.5)));
            var v1 = new hvec2(((Half)(2.5)), ((Half)(7.5)));
            var v2 = v0.ga;
            v0.ga = v1;
            var v3 = v0.ga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-7.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v0.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(-3.5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec4(((Half)(0.5)), ((Half)(6)), Half.One, ((Half)(5)));
            var v1 = new hvec3(((Half)(8)), ((Half)(-5)), ((Half)(7.5)));
            var v2 = v0.rga;
            v0.rga = v1;
            var v3 = v0.rga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(8)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v0.y));
            Assert.That(Half.One, Is.EqualTo(v0.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(0.5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(6)), Is.EqualTo(v2.y));
            Assert.That(((Half)(5)), Is.EqualTo(v2.z));
        }
        {
            var v0 = new hvec4(((Half)(-5.5)), ((Half)(8)), ((Half)(-9)), ((Half)(5.5)));
            var v1 = new hvec2(((Half)(2)), ((Half)(5)));
            var v2 = v0.ba;
            v0.ba = v1;
            var v3 = v0.ba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-5.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(8)), Is.EqualTo(v0.y));
            Assert.That(((Half)(2)), Is.EqualTo(v0.z));
            Assert.That(((Half)(5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(-9)), Is.EqualTo(v2.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v2.y));
        }
        {
            var v0 = new hvec4(((Half)(-1.5)), ((Half)(-7)), ((Half)(4)), ((Half)(-3.5)));
            var v1 = new hvec3(((Half)(-1.5)), ((Half)(5)), ((Half)(-5)));
            var v2 = v0.rba;
            v0.rba = v1;
            var v3 = v0.rba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-1.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v0.y));
            Assert.That(((Half)(5)), Is.EqualTo(v0.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(-1.5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(4)), Is.EqualTo(v2.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v2.z));
        }
        {
            var v0 = new hvec4(((Half)(9)), ((Half)(-4)), ((Half)(-4)), ((Half)(-4.5)));
            var v1 = new hvec3(((Half)(-5.5)), ((Half)(8)), ((Half)(7.5)));
            var v2 = v0.gba;
            v0.gba = v1;
            var v3 = v0.gba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(9)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(8)), Is.EqualTo(v0.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(-4)), Is.EqualTo(v2.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v2.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v2.z));
        }
        {
            var v0 = new hvec4(((Half)(5)), ((Half)(-2)), ((Half)(-1)), ((Half)(-7.5)));
            var v1 = new hvec4(((Half)(2)), ((Half)(-0.5)), ((Half)(8)), ((Half)(-4.5)));
            var v2 = v0.rgba;
            v0.rgba = v1;
            var v3 = v0.rgba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(2)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v0.y));
            Assert.That(((Half)(8)), Is.EqualTo(v0.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v0.w));
        
            Assert.That(((Half)(5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v2.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v2.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v2.w));
        }
    }

}
