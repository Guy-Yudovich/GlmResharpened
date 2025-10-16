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
public class DoubleSwizzleVec4Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new dvec4(5.5d, 8.5d, -1d, 6d);
            var v = ov.swizzle.xx;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(3.5d, -6.5d, 5d, 7d);
            var v = ov.swizzle.xxx;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(1.5d, -7d, -7.5d, -6.5d);
            var v = ov.swizzle.xxxx;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, 5.5d, -4d, 7.5d);
            var v = ov.swizzle.xxxy;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5d, 1.0, -1d, 9.5d);
            var v = ov.swizzle.xxxz;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5d, 3.5d, 5d, -7d);
            var v = ov.swizzle.xxxw;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2.5d, -4.5d, -2d, 7d);
            var v = ov.swizzle.xxy;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(8d, 4d, 4d, 0.0);
            var v = ov.swizzle.xxyx;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, -4d, -1.5d, -1.5d);
            var v = ov.swizzle.xxyy;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, -1.5d, -5.5d, -3.5d);
            var v = ov.swizzle.xxyz;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, 7.5d, 4d, -1d);
            var v = ov.swizzle.xxyw;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, 0.5d, 2.5d, 0.5d);
            var v = ov.swizzle.xxz;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(0.0, -2.5d, -8.5d, -2d);
            var v = ov.swizzle.xxzx;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, 5d, 0.5d, 2d);
            var v = ov.swizzle.xxzy;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3.5d, 4.5d, -4d, 7d);
            var v = ov.swizzle.xxzz;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, 8.5d, 9.5d, -2.5d);
            var v = ov.swizzle.xxzw;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3d, -8.5d, -4d, 9d);
            var v = ov.swizzle.xxw;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(6d, -3.5d, 8.5d, -3.5d);
            var v = ov.swizzle.xxwx;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8d, -5.5d, 0.0, 7d);
            var v = ov.swizzle.xxwy;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, 4.5d, -1.5d, 1.0);
            var v = ov.swizzle.xxwz;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(-1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3.5d, -8.5d, 6d, -8.5d);
            var v = ov.swizzle.xxww;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, 3.5d, 1.5d, 2d);
            var v = ov.swizzle.xy;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-5.5d, -3.5d, 4.5d, 4d);
            var v = ov.swizzle.xyx;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-4d, -6d, -5d, 0.0);
            var v = ov.swizzle.xyxx;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, -7d, 7.5d, 7d);
            var v = ov.swizzle.xyxy;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7d, -7.5d, -6.5d, -5d);
            var v = ov.swizzle.xyxz;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, 5.5d, 3.5d, -4.5d);
            var v = ov.swizzle.xyxw;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5d, -7.5d, -4d, 8.5d);
            var v = ov.swizzle.xyy;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(5d, -3d, -4d, -0.5d);
            var v = ov.swizzle.xyyx;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.5d, -8d, 3d, -9.5d);
            var v = ov.swizzle.xyyy;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(-8d, Is.EqualTo(v.z));
            Assert.That(-8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, -1d, -4.5d, -8.5d);
            var v = ov.swizzle.xyyz;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.5d, 4.5d, -2d, 1.0);
            var v = ov.swizzle.xyyw;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9d, 9.5d, 9d, -2d);
            var v = ov.swizzle.xyz;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(7.5d, -9.5d, -4.5d, -2d);
            var v = ov.swizzle.xyzx;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, 1.5d, 3.5d, -1.5d);
            var v = ov.swizzle.xyzy;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, 6d, 7.5d, 2d);
            var v = ov.swizzle.xyzz;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2d, 6.5d, 8.5d, 1.0);
            var v = ov.swizzle.xyzw;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, -3.5d, 8d, -8.5d);
            var v = ov.swizzle.xyw;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-4d, -8d, -8d, 5d);
            var v = ov.swizzle.xywx;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(6.5d, 1.0, -5.5d, 4.5d);
            var v = ov.swizzle.xywy;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, 1.5d, -5d, 5d);
            var v = ov.swizzle.xywz;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3d, 1.0, 1.0, -3.5d);
            var v = ov.swizzle.xyww;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, 2d, 1.5d, 9.5d);
            var v = ov.swizzle.xz;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-4.5d, -6d, -9.5d, -6.5d);
            var v = ov.swizzle.xzx;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-4d, -6.5d, 8d, 4.5d);
            var v = ov.swizzle.xzxx;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5.5d, -1d, 0.0, -5.5d);
            var v = ov.swizzle.xzxy;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.5d, -1.5d, 8.5d, -9d);
            var v = ov.swizzle.xzxz;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, -9d, -5d, 6.5d);
            var v = ov.swizzle.xzxw;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7d, 8.5d, 5d, 7d);
            var v = ov.swizzle.xzy;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(1.5d, 1.5d, 0.5d, -1d);
            var v = ov.swizzle.xzyx;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, -3d, -3d, 8.5d);
            var v = ov.swizzle.xzyy;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, 8d, 5.5d, 7.5d);
            var v = ov.swizzle.xzyz;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(8d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7.5d, 5.5d, 2.5d, -4d);
            var v = ov.swizzle.xzyw;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2.5d, -0.5d, 9.5d, -3d);
            var v = ov.swizzle.xzz;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(1.5d, 1.5d, -5d, -5.5d);
            var v = ov.swizzle.xzzx;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3d, -7.5d, -5.5d, 9d);
            var v = ov.swizzle.xzzy;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, 4.5d, 2.5d, -3.5d);
            var v = ov.swizzle.xzzz;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, -3d, 1.5d, -7.5d);
            var v = ov.swizzle.xzzw;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3.5d, 8.5d, 9.5d, -7.5d);
            var v = ov.swizzle.xzw;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(7.5d, 1.0, -0.5d, -7.5d);
            var v = ov.swizzle.xzwx;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3.5d, 0.0, -7.5d, 5d);
            var v = ov.swizzle.xzwy;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, 0.0, 4d, -9d);
            var v = ov.swizzle.xzwz;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
            Assert.That(4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, 2.5d, -7d, 0.0);
            var v = ov.swizzle.xzww;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7d, 5d, 6d, -3d);
            var v = ov.swizzle.xw;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-0.5d, 3d, -1d, 0.0);
            var v = ov.swizzle.xwx;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-7d, 8d, -2.5d, -4.5d);
            var v = ov.swizzle.xwxx;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, -1d, -8.5d, 3.5d);
            var v = ov.swizzle.xwxy;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, -7d, -6d, -0.5d);
            var v = ov.swizzle.xwxz;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2d, 2.5d, 1.5d, 3d);
            var v = ov.swizzle.xwxw;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, -8d, -5.5d, -1.5d);
            var v = ov.swizzle.xwy;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(-8d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-0.5d, -4d, -2.5d, -8d);
            var v = ov.swizzle.xwyx;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(6.5d, 1.5d, 4d, -2.5d);
            var v = ov.swizzle.xwyy;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2.5d, -2.5d, 3.5d, 3.5d);
            var v = ov.swizzle.xwyz;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.5d, -1.5d, 5d, -5.5d);
            var v = ov.swizzle.xwyw;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, 6.5d, 1.0, -5d);
            var v = ov.swizzle.xwz;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-9d, -1d, -0.5d, -7.5d);
            var v = ov.swizzle.xwzx;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7d, -2.5d, 8.5d, -5.5d);
            var v = ov.swizzle.xwzy;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5d, 3d, -2d, -1d);
            var v = ov.swizzle.xwzz;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, -6.5d, -1d, 2d);
            var v = ov.swizzle.xwzw;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(2d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7.5d, 8d, -0.5d, -4d);
            var v = ov.swizzle.xww;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(5d, 4.5d, 1.0, 1.0);
            var v = ov.swizzle.xwwx;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, -7.5d, 8.5d, -4d);
            var v = ov.swizzle.xwwy;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, 6d, -0.5d, 4d);
            var v = ov.swizzle.xwwz;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7d, 8d, 8d, -9d);
            var v = ov.swizzle.xwww;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, 5d, 0.0, 9d);
            var v = ov.swizzle.yx;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(3.5d, -8.5d, -2d, -0.5d);
            var v = ov.swizzle.yxx;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-6d, -6.5d, -4d, 8d);
            var v = ov.swizzle.yxxx;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(-6d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7d, 2d, 2d, 4d);
            var v = ov.swizzle.yxxy;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7d, -1.5d, 9d, -5.5d);
            var v = ov.swizzle.yxxz;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, -2.5d, 8.5d, 5.5d);
            var v = ov.swizzle.yxxw;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(8d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, -5.5d, 7.5d, 7d);
            var v = ov.swizzle.yxy;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-4d, 7d, 4.5d, -1d);
            var v = ov.swizzle.yxyx;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, 2.5d, -8d, -6d);
            var v = ov.swizzle.yxyy;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, -9.5d, -9.5d, -4.5d);
            var v = ov.swizzle.yxyz;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
            Assert.That(-9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, -3d, -3.5d, 0.0);
            var v = ov.swizzle.yxyw;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, 0.5d, 6.5d, -6.5d);
            var v = ov.swizzle.yxz;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(4d, -4.5d, 6.5d, -1.5d);
            var v = ov.swizzle.yxzx;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, -5.5d, 9d, 7.5d);
            var v = ov.swizzle.yxzy;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(6d, 5d, -8.5d, 8d);
            var v = ov.swizzle.yxzz;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, 3d, -5d, 8d);
            var v = ov.swizzle.yxzw;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, 2d, 4.5d, -4.5d);
            var v = ov.swizzle.yxw;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-5.5d, -3.5d, 6.5d, -1.5d);
            var v = ov.swizzle.yxwx;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7d, -5.5d, 1.0, 6.5d);
            var v = ov.swizzle.yxwy;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, 8.5d, -2.5d, 7.5d);
            var v = ov.swizzle.yxwz;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2.5d, -4d, 3d, -0.5d);
            var v = ov.swizzle.yxww;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, 5d, -2d, 0.5d);
            var v = ov.swizzle.yy;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-7.5d, -8.5d, 9d, 2d);
            var v = ov.swizzle.yyx;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(8.5d, -2d, 2d, -9d);
            var v = ov.swizzle.yyxx;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, -8d, -2d, 6d);
            var v = ov.swizzle.yyxy;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(-8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(6.5d, -2d, 8.5d, -9d);
            var v = ov.swizzle.yyxz;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, 8d, -9.5d, -5d);
            var v = ov.swizzle.yyxw;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7.5d, -4d, 6.5d, 8d);
            var v = ov.swizzle.yyy;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-9d, -6.5d, -7.5d, 8d);
            var v = ov.swizzle.yyyx;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, -3.5d, 7.5d, -6.5d);
            var v = ov.swizzle.yyyy;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.5d, 4d, 3d, 3d);
            var v = ov.swizzle.yyyz;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6d, 3.5d, -0.5d, 6.5d);
            var v = ov.swizzle.yyyw;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7.5d, -6.5d, 8.5d, -6.5d);
            var v = ov.swizzle.yyz;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-3.5d, -8.5d, 1.0, -6d);
            var v = ov.swizzle.yyzx;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5d, -5.5d, 0.0, 2d);
            var v = ov.swizzle.yyzy;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, 6.5d, 7d, 8d);
            var v = ov.swizzle.yyzz;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, 1.0, -5.5d, -5d);
            var v = ov.swizzle.yyzw;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, 3.5d, -9d, -2d);
            var v = ov.swizzle.yyw;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-8.5d, -0.5d, -6d, 2.5d);
            var v = ov.swizzle.yywx;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7d, 5.5d, 2d, 5.5d);
            var v = ov.swizzle.yywy;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, -6.5d, 3.5d, 9.5d);
            var v = ov.swizzle.yywz;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5d, -4d, -7.5d, 8.5d);
            var v = ov.swizzle.yyww;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7.5d, 5d, 3.5d, -6d);
            var v = ov.swizzle.yz;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-4.5d, 4.5d, 6.5d, 3.5d);
            var v = ov.swizzle.yzx;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(6.5d, 4.5d, -9d, -5d);
            var v = ov.swizzle.yzxx;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9d, -5d, 7d, -1.5d);
            var v = ov.swizzle.yzxy;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3d, -3.5d, 2d, 7.5d);
            var v = ov.swizzle.yzxz;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(2d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, 9d, 7d, -9.5d);
            var v = ov.swizzle.yzxw;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(-9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8.5d, 4d, -6.5d, 2d);
            var v = ov.swizzle.yzy;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(3d, 7d, 3.5d, -1d);
            var v = ov.swizzle.yzyx;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, -3.5d, 3.5d, -6.5d);
            var v = ov.swizzle.yzyy;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, 2d, -3.5d, -3.5d);
            var v = ov.swizzle.yzyz;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2.5d, -7.5d, 5.5d, -4d);
            var v = ov.swizzle.yzyw;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6d, -1.5d, -3.5d, 4d);
            var v = ov.swizzle.yzz;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-6d, 4d, 5.5d, -0.5d);
            var v = ov.swizzle.yzzx;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, -4.5d, 3.5d, -2d);
            var v = ov.swizzle.yzzy;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, -3d, 4.5d, -8.5d);
            var v = ov.swizzle.yzzz;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, 4.5d, 0.5d, -1.5d);
            var v = ov.swizzle.yzzw;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(-1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, 7d, 5.5d, -6.5d);
            var v = ov.swizzle.yzw;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-8.5d, -5.5d, -2.5d, 1.0);
            var v = ov.swizzle.yzwx;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, -6d, 4d, -7.5d);
            var v = ov.swizzle.yzwy;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, 4.5d, 3d, 3.5d);
            var v = ov.swizzle.yzwz;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, -9d, -3.5d, 8.5d);
            var v = ov.swizzle.yzww;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2d, 4d, 9.5d, 4.5d);
            var v = ov.swizzle.yw;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(2.5d, -8.5d, -4.5d, -2.5d);
            var v = ov.swizzle.ywx;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(7d, 5d, -5d, 7.5d);
            var v = ov.swizzle.ywxx;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2.5d, 6d, -2d, 8d);
            var v = ov.swizzle.ywxy;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2.5d, 2d, -6.5d, 2.5d);
            var v = ov.swizzle.ywxz;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7d, 4.5d, -0.5d, 5.5d);
            var v = ov.swizzle.ywxw;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, -1d, 7.5d, 4d);
            var v = ov.swizzle.ywy;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(9d, 1.0, 1.0, 2.5d);
            var v = ov.swizzle.ywyx;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, 1.5d, -6d, 6.5d);
            var v = ov.swizzle.ywyy;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7d, 1.0, 0.5d, 0.0);
            var v = ov.swizzle.ywyz;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, 0.0, 3.5d, 3.5d);
            var v = ov.swizzle.ywyw;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, 6d, 0.5d, 7d);
            var v = ov.swizzle.ywz;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-7.5d, 5.5d, 0.0, -7d);
            var v = ov.swizzle.ywzx;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5.5d, 3.5d, -8.5d, -8d);
            var v = ov.swizzle.ywzy;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6d, 4d, -4d, -7.5d);
            var v = ov.swizzle.ywzz;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, -9.5d, -8d, 5d);
            var v = ov.swizzle.ywzw;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(-8d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, -6.5d, -0.5d, 0.0);
            var v = ov.swizzle.yww;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(0.5d, -6d, 0.0, 1.5d);
            var v = ov.swizzle.ywwx;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2d, -6.5d, 3.5d, -7d);
            var v = ov.swizzle.ywwy;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, 5.5d, 4.5d, -4d);
            var v = ov.swizzle.ywwz;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, 0.5d, -7.5d, -5d);
            var v = ov.swizzle.ywww;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, -4.5d, 6.5d, -5d);
            var v = ov.swizzle.zx;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(9d, 8.5d, -8.5d, 3d);
            var v = ov.swizzle.zxx;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-1.5d, 8d, -7d, -9d);
            var v = ov.swizzle.zxxx;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(-1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, -2.5d, -0.5d, -8d);
            var v = ov.swizzle.zxxy;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8d, -0.5d, -7d, 6d);
            var v = ov.swizzle.zxxz;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(-8d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, 8d, 4d, -3d);
            var v = ov.swizzle.zxxw;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, 4d, -7d, -9.5d);
            var v = ov.swizzle.zxy;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(9d, 0.0, 1.0, 2.5d);
            var v = ov.swizzle.zxyx;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7.5d, 3d, 4d, -9d);
            var v = ov.swizzle.zxyy;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2.5d, -5d, 0.5d, 2.5d);
            var v = ov.swizzle.zxyz;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, 7.5d, 3d, 2d);
            var v = ov.swizzle.zxyw;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5d, -5d, 4.5d, -3d);
            var v = ov.swizzle.zxz;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(5d, -7d, 6.5d, 0.5d);
            var v = ov.swizzle.zxzx;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, -6d, -9.5d, 2.5d);
            var v = ov.swizzle.zxzy;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, -6.5d, -5d, 5d);
            var v = ov.swizzle.zxzz;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8.5d, 0.0, 3.5d, -2.5d);
            var v = ov.swizzle.zxzw;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7d, -5.5d, -8.5d, -9.5d);
            var v = ov.swizzle.zxw;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-7.5d, 9d, 1.5d, 2d);
            var v = ov.swizzle.zxwx;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, -5.5d, -2d, 7.5d);
            var v = ov.swizzle.zxwy;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5d, 1.0, 6d, -4.5d);
            var v = ov.swizzle.zxwz;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9d, 3d, -5d, 3.5d);
            var v = ov.swizzle.zxww;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3d, -1d, -9d, -7.5d);
            var v = ov.swizzle.zy;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-6.5d, -3d, 9.5d, 3d);
            var v = ov.swizzle.zyx;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(9.5d, -5.5d, -1d, 4.5d);
            var v = ov.swizzle.zyxx;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3d, -6d, 5.5d, -7.5d);
            var v = ov.swizzle.zyxy;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, -5d, 1.5d, 5.5d);
            var v = ov.swizzle.zyxz;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, 3.5d, 1.5d, -0.5d);
            var v = ov.swizzle.zyxw;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, -7.5d, -2.5d, -9d);
            var v = ov.swizzle.zyy;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-7d, -0.5d, 5.5d, -8d);
            var v = ov.swizzle.zyyx;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, 9.5d, -6.5d, 6.5d);
            var v = ov.swizzle.zyyy;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5d, 9.5d, 6.5d, 9d);
            var v = ov.swizzle.zyyz;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, -2.5d, 3d, -5d);
            var v = ov.swizzle.zyyw;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, -8d, 4.5d, -0.5d);
            var v = ov.swizzle.zyz;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(5d, -4.5d, 1.5d, 5.5d);
            var v = ov.swizzle.zyzx;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3d, -9d, 7d, -1d);
            var v = ov.swizzle.zyzy;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, 0.5d, -7d, 0.0);
            var v = ov.swizzle.zyzz;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, -8.5d, -2.5d, 9d);
            var v = ov.swizzle.zyzw;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, 3.5d, 8d, 3d);
            var v = ov.swizzle.zyw;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(2.5d, 8.5d, -6d, 5.5d);
            var v = ov.swizzle.zywx;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8d, -8.5d, -4.5d, 8.5d);
            var v = ov.swizzle.zywy;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.5d, -7d, -6d, -2.5d);
            var v = ov.swizzle.zywz;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, 7.5d, -3d, 1.5d);
            var v = ov.swizzle.zyww;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, 0.0, 4d, 6d);
            var v = ov.swizzle.zz;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(2.5d, -3d, -8d, -6d);
            var v = ov.swizzle.zzx;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-7.5d, 5.5d, -5.5d, 0.5d);
            var v = ov.swizzle.zzxx;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, 3.5d, -3.5d, -9.5d);
            var v = ov.swizzle.zzxy;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, 0.5d, 6.5d, 6d);
            var v = ov.swizzle.zzxz;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(8d, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, 5.5d, -7d, 1.5d);
            var v = ov.swizzle.zzxw;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(8d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, 9d, -8.5d, 2d);
            var v = ov.swizzle.zzy;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-4d, 0.5d, -2d, -1.5d);
            var v = ov.swizzle.zzyx;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, 5.5d, -1d, -1.5d);
            var v = ov.swizzle.zzyy;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, 1.0, -2d, -9.5d);
            var v = ov.swizzle.zzyz;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8.5d, 0.0, -3d, -6.5d);
            var v = ov.swizzle.zzyw;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7.5d, 4.5d, 7.5d, 6.5d);
            var v = ov.swizzle.zzz;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(1.5d, 5.5d, -8d, 8.5d);
            var v = ov.swizzle.zzzx;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(-8d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, 5d, -7.5d, 2d);
            var v = ov.swizzle.zzzy;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, -3d, -3d, -7.5d);
            var v = ov.swizzle.zzzz;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.5d, -5d, 1.0, 2.5d);
            var v = ov.swizzle.zzzw;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, 5.5d, -7.5d, 5d);
            var v = ov.swizzle.zzw;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-7.5d, 7.5d, 2.5d, 7d);
            var v = ov.swizzle.zzwx;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8d, -7d, -3.5d, 8d);
            var v = ov.swizzle.zzwy;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(8d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7.5d, 4.5d, 4.5d, 9.5d);
            var v = ov.swizzle.zzwz;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2d, -5.5d, -2d, -9d);
            var v = ov.swizzle.zzww;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2d, -4d, -2.5d, 2d);
            var v = ov.swizzle.zw;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(2d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-3d, 8d, 5d, -5d);
            var v = ov.swizzle.zwx;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-0.5d, -0.5d, -1.5d, 6d);
            var v = ov.swizzle.zwxx;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, -8.5d, 9.5d, 1.0);
            var v = ov.swizzle.zwxy;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3d, 2.5d, -5d, 3.5d);
            var v = ov.swizzle.zwxz;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2d, -1d, -8.5d, -4.5d);
            var v = ov.swizzle.zwxw;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, -4d, -8.5d, -0.5d);
            var v = ov.swizzle.zwy;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-9d, -3d, -1d, 7d);
            var v = ov.swizzle.zwyx;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3d, -7.5d, -9.5d, 9d);
            var v = ov.swizzle.zwyy;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, -9d, 2.5d, -4d);
            var v = ov.swizzle.zwyz;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.5d, -7d, -9d, -1.5d);
            var v = ov.swizzle.zwyw;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(-1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, -9d, 8d, 1.0);
            var v = ov.swizzle.zwz;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(8d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(5.5d, 2.5d, -3.5d, -9.5d);
            var v = ov.swizzle.zwzx;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, -8d, -6d, 1.0);
            var v = ov.swizzle.zwzy;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(-6d, Is.EqualTo(v.z));
            Assert.That(-8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3.5d, 2d, -6.5d, 9.5d);
            var v = ov.swizzle.zwzz;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, -7d, 6.5d, -6d);
            var v = ov.swizzle.zwzw;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, -8.5d, 2d, -8d);
            var v = ov.swizzle.zww;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(-8d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(1.0, -0.5d, 3.5d, 4.5d);
            var v = ov.swizzle.zwwx;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, 1.0, 2d, -3.5d);
            var v = ov.swizzle.zwwy;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2.5d, 2.5d, 6.5d, 0.0);
            var v = ov.swizzle.zwwz;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5d, -9d, 3.5d, -3.5d);
            var v = ov.swizzle.zwww;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, 0.5d, 8.5d, -4.5d);
            var v = ov.swizzle.wx;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(5d, -9d, -7d, 5d);
            var v = ov.swizzle.wxx;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(5.5d, 2.5d, -3.5d, -5d);
            var v = ov.swizzle.wxxx;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, 2d, 8d, 6d);
            var v = ov.swizzle.wxxy;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
            Assert.That(2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6d, 1.5d, 0.0, 5d);
            var v = ov.swizzle.wxxz;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(-6d, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, 2.5d, -9.5d, 7d);
            var v = ov.swizzle.wxxw;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6d, 0.5d, 9d, 0.0);
            var v = ov.swizzle.wxy;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(5d, -6.5d, 4.5d, 8d);
            var v = ov.swizzle.wxyx;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, -1d, -0.5d, -0.5d);
            var v = ov.swizzle.wxyy;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, -8d, -2d, -7.5d);
            var v = ov.swizzle.wxyz;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-8d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3d, -2.5d, 8.5d, 7d);
            var v = ov.swizzle.wxyw;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6d, -2.5d, 5d, -0.5d);
            var v = ov.swizzle.wxz;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-6.5d, 0.5d, -5.5d, -4d);
            var v = ov.swizzle.wxzx;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, -2.5d, -3.5d, 4.5d);
            var v = ov.swizzle.wxzy;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, 0.5d, 9d, -6d);
            var v = ov.swizzle.wxzz;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, -7d, 0.0, -3d);
            var v = ov.swizzle.wxzw;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, -8d, 1.5d, 9d);
            var v = ov.swizzle.wxw;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-4d, -9.5d, -5.5d, 8.5d);
            var v = ov.swizzle.wxwx;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, -8d, 3.5d, -2d);
            var v = ov.swizzle.wxwy;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(-8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, -2d, 2.5d, -1.5d);
            var v = ov.swizzle.wxwz;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, -8.5d, -7d, -6d);
            var v = ov.swizzle.wxww;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-6d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, -9.5d, -0.5d, 5.5d);
            var v = ov.swizzle.wy;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-5.5d, 5.5d, -8d, 2.5d);
            var v = ov.swizzle.wyx;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(7d, 6.5d, -4d, 5.5d);
            var v = ov.swizzle.wyxx;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2.5d, -3.5d, 8d, 7.5d);
            var v = ov.swizzle.wyxy;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5.5d, 6.5d, -6d, 3d);
            var v = ov.swizzle.wyxz;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(6d, -4.5d, 4.5d, 1.0);
            var v = ov.swizzle.wyxw;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, -5d, 9.5d, 8.5d);
            var v = ov.swizzle.wyy;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(7.5d, -8.5d, 1.5d, -1.5d);
            var v = ov.swizzle.wyyx;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, -4.5d, -3d, -9d);
            var v = ov.swizzle.wyyy;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, 6.5d, -4.5d, -8d);
            var v = ov.swizzle.wyyz;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, 1.5d, 1.5d, -6.5d);
            var v = ov.swizzle.wyyw;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, 7.5d, -5.5d, 8d);
            var v = ov.swizzle.wyz;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(3d, 4.5d, 3.5d, -1.5d);
            var v = ov.swizzle.wyzx;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, -4d, 8d, -4d);
            var v = ov.swizzle.wyzy;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(8d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, -1.5d, 1.0, 9d);
            var v = ov.swizzle.wyzz;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5.5d, -9d, 5.5d, -2.5d);
            var v = ov.swizzle.wyzw;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, -4.5d, 6.5d, 2d);
            var v = ov.swizzle.wyw;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-3d, 0.5d, 9d, 9.5d);
            var v = ov.swizzle.wywx;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, 7.5d, 1.0, -6d);
            var v = ov.swizzle.wywy;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(-6d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, -1d, 7.5d, 6.5d);
            var v = ov.swizzle.wywz;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.5d, 1.5d, 5.5d, 3d);
            var v = ov.swizzle.wyww;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, 2d, -6.5d, -4.5d);
            var v = ov.swizzle.wz;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-6d, 9.5d, 3.5d, 0.0);
            var v = ov.swizzle.wzx;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(-6d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(4.5d, -6d, -6.5d, -6.5d);
            var v = ov.swizzle.wzxx;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5.5d, 3d, -9d, -9d);
            var v = ov.swizzle.wzxy;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, -7.5d, 5.5d, -4d);
            var v = ov.swizzle.wzxz;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4.5d, 4.5d, -7d, 7d);
            var v = ov.swizzle.wzxw;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3d, 3.5d, -9.5d, -5d);
            var v = ov.swizzle.wzy;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(0.5d, 4d, -9d, 4d);
            var v = ov.swizzle.wzyx;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, 1.5d, 9.5d, 1.0);
            var v = ov.swizzle.wzyy;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, -1d, -2.5d, -4d);
            var v = ov.swizzle.wzyz;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(6.5d, 9d, 4d, 5.5d);
            var v = ov.swizzle.wzyw;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5d, -9d, -9.5d, 0.5d);
            var v = ov.swizzle.wzz;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(2.5d, -8d, 5.5d, 7d);
            var v = ov.swizzle.wzzx;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(6.5d, -7.5d, -9d, 3.5d);
            var v = ov.swizzle.wzzy;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4.5d, -6d, -3d, -7.5d);
            var v = ov.swizzle.wzzz;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, -8d, 9d, 0.5d);
            var v = ov.swizzle.wzzw;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(6.5d, -9d, 8.5d, 4d);
            var v = ov.swizzle.wzw;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(4d, -7d, -8d, 0.5d);
            var v = ov.swizzle.wzwx;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5.5d, -7.5d, -7d, -5d);
            var v = ov.swizzle.wzwy;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, -7.5d, 3.5d, 4.5d);
            var v = ov.swizzle.wzwz;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, -0.5d, -6.5d, -3d);
            var v = ov.swizzle.wzww;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9d, -2d, 7d, 2d);
            var v = ov.swizzle.ww;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(2d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-3d, 5d, -6d, -4.5d);
            var v = ov.swizzle.wwx;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(7.5d, 4d, 4.5d, -8d);
            var v = ov.swizzle.wwxx;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, -4d, 8.5d, 6.5d);
            var v = ov.swizzle.wwxy;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, -6d, -4.5d, -6d);
            var v = ov.swizzle.wwxz;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, 4d, -3d, -4d);
            var v = ov.swizzle.wwxw;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, 3d, 4d, 3d);
            var v = ov.swizzle.wwy;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-7.5d, -9d, 8d, -0.5d);
            var v = ov.swizzle.wwyx;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5.5d, 6.5d, -8.5d, -4.5d);
            var v = ov.swizzle.wwyy;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, 6.5d, 1.5d, 9.5d);
            var v = ov.swizzle.wwyz;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, 2.5d, 2.5d, 0.5d);
            var v = ov.swizzle.wwyw;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2.5d, 8.5d, -5d, -5d);
            var v = ov.swizzle.wwz;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-5.5d, 7.5d, -5d, 7.5d);
            var v = ov.swizzle.wwzx;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, 7d, -4d, 4d);
            var v = ov.swizzle.wwzy;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, 4.5d, 7.5d, 9d);
            var v = ov.swizzle.wwzz;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, -3d, 3d, -9d);
            var v = ov.swizzle.wwzw;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5.5d, 4d, -6.5d, 3d);
            var v = ov.swizzle.www;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(3.5d, -4d, -4.5d, -6.5d);
            var v = ov.swizzle.wwwx;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, -4.5d, -5d, 6d);
            var v = ov.swizzle.wwwy;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3d, -6.5d, -2.5d, 6d);
            var v = ov.swizzle.wwwz;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, -0.5d, -9.5d, -4.5d);
            var v = ov.swizzle.wwww;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new dvec4(9d, -6.5d, 3d, 6d);
            var v = ov.swizzle.rr;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-8.5d, 4d, 9.5d, 9.5d);
            var v = ov.swizzle.rrr;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(6d, 7d, -5.5d, 3d);
            var v = ov.swizzle.rrrr;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8.5d, 5d, 6.5d, 9d);
            var v = ov.swizzle.rrrg;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, -6.5d, -9d, 4d);
            var v = ov.swizzle.rrrb;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2.5d, -9.5d, 8.5d, 7d);
            var v = ov.swizzle.rrra;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2d, 8.5d, -3.5d, -5.5d);
            var v = ov.swizzle.rrg;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(0.5d, -5.5d, 5d, 5d);
            var v = ov.swizzle.rrgr;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7.5d, 5.5d, -7d, 7d);
            var v = ov.swizzle.rrgg;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2.5d, 6d, -3.5d, -2d);
            var v = ov.swizzle.rrgb;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, -7.5d, -7.5d, -7.5d);
            var v = ov.swizzle.rrga;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, -1.5d, 4d, -4.5d);
            var v = ov.swizzle.rrb;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-3d, 4d, -9d, 2.5d);
            var v = ov.swizzle.rrbr;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3d, 2d, -0.5d, -0.5d);
            var v = ov.swizzle.rrbg;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4.5d, 5.5d, 5.5d, -6.5d);
            var v = ov.swizzle.rrbb;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, -5d, 9d, -7.5d);
            var v = ov.swizzle.rrba;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, -9d, 6d, -4.5d);
            var v = ov.swizzle.rra;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-0.5d, -1.5d, -7.5d, 4d);
            var v = ov.swizzle.rrar;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7.5d, 6d, 2d, 5d);
            var v = ov.swizzle.rrag;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, -6d, -5.5d, -5.5d);
            var v = ov.swizzle.rrab;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, 1.0, -1d, -3.5d);
            var v = ov.swizzle.rraa;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, -3d, 2.5d, 4.5d);
            var v = ov.swizzle.rg;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(6d, -2.5d, -7.5d, 2.5d);
            var v = ov.swizzle.rgr;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-2d, 3d, 3.5d, -3.5d);
            var v = ov.swizzle.rgrr;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3d, 9.5d, -8.5d, 5d);
            var v = ov.swizzle.rgrg;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8.5d, -9d, 5.5d, -4.5d);
            var v = ov.swizzle.rgrb;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7.5d, -5d, 5.5d, 6d);
            var v = ov.swizzle.rgra;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, -5.5d, 0.5d, 9d);
            var v = ov.swizzle.rgg;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-1d, -1d, -0.5d, -8d);
            var v = ov.swizzle.rggr;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3d, -6.5d, -7d, -0.5d);
            var v = ov.swizzle.rggg;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, -2d, -9d, 1.0);
            var v = ov.swizzle.rggb;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5d, 0.5d, 3.5d, 4.5d);
            var v = ov.swizzle.rgga;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, -7d, 3.5d, 8.5d);
            var v = ov.swizzle.rgb;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(5.5d, -9d, 2d, -5d);
            var v = ov.swizzle.rgbr;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5d, -3.5d, 4d, 0.5d);
            var v = ov.swizzle.rgbg;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7d, -3.5d, 5.5d, -7.5d);
            var v = ov.swizzle.rgbb;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7.5d, -3d, -8.5d, 0.0);
            var v = ov.swizzle.rgba;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, -6d, -6.5d, -0.5d);
            var v = ov.swizzle.rga;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-6.5d, 1.5d, -9d, 9d);
            var v = ov.swizzle.rgar;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, 4.5d, -9d, 2.5d);
            var v = ov.swizzle.rgag;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7.5d, 1.0, 2.5d, -7.5d);
            var v = ov.swizzle.rgab;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.5d, 1.5d, -5d, 2.5d);
            var v = ov.swizzle.rgaa;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, -4d, -2d, -7d);
            var v = ov.swizzle.rb;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-9d, -3.5d, -2d, 0.0);
            var v = ov.swizzle.rbr;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-6d, 7.5d, 4d, 3.5d);
            var v = ov.swizzle.rbrr;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(-6d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, 2.5d, -9.5d, 8.5d);
            var v = ov.swizzle.rbrg;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(8d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3.5d, 3d, -6d, 3d);
            var v = ov.swizzle.rbrb;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, 3.5d, -6d, -2d);
            var v = ov.swizzle.rbra;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7d, -2d, 8d, -6d);
            var v = ov.swizzle.rbg;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(3.5d, -3d, 1.5d, 5d);
            var v = ov.swizzle.rbgr;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7.5d, -0.5d, 2.5d, 9.5d);
            var v = ov.swizzle.rbgg;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3d, 5d, 9d, 6.5d);
            var v = ov.swizzle.rbgb;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, -9d, 3.5d, 2d);
            var v = ov.swizzle.rbga;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
            Assert.That(2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, -4.5d, -6.5d, -0.5d);
            var v = ov.swizzle.rbb;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-8.5d, 3.5d, -1.5d, -3.5d);
            var v = ov.swizzle.rbbr;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6d, -2d, 3.5d, -5d);
            var v = ov.swizzle.rbbg;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, 9.5d, 9d, 6d);
            var v = ov.swizzle.rbbb;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8d, 5.5d, 6d, 3d);
            var v = ov.swizzle.rbba;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5d, 9.5d, 5.5d, -9d);
            var v = ov.swizzle.rba;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(0.0, -8.5d, 4.5d, -1.5d);
            var v = ov.swizzle.rbar;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, -9.5d, -6.5d, -9.5d);
            var v = ov.swizzle.rbag;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
            Assert.That(-9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, -3d, -7.5d, -7.5d);
            var v = ov.swizzle.rbab;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, -9d, 5.5d, 0.0);
            var v = ov.swizzle.rbaa;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, 4d, 0.5d, -3.5d);
            var v = ov.swizzle.ra;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(6.5d, -7d, 0.0, 3d);
            var v = ov.swizzle.rar;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(6.5d, 3d, -8d, -5.5d);
            var v = ov.swizzle.rarr;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3d, 0.5d, 7.5d, 0.5d);
            var v = ov.swizzle.rarg;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.5d, 3d, -0.5d, 9.5d);
            var v = ov.swizzle.rarb;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, 0.0, 2.5d, 5.5d);
            var v = ov.swizzle.rara;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, -3d, -6d, -3.5d);
            var v = ov.swizzle.rag;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-7d, -2.5d, -8d, 8.5d);
            var v = ov.swizzle.ragr;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, 6d, -9d, 0.0);
            var v = ov.swizzle.ragg;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9d, 8d, -6.5d, -6.5d);
            var v = ov.swizzle.ragb;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(8d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, 0.5d, 2.5d, 0.5d);
            var v = ov.swizzle.raga;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, 9.5d, 7d, 9d);
            var v = ov.swizzle.rab;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-5d, 2.5d, 2.5d, -4.5d);
            var v = ov.swizzle.rabr;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.5d, 5.5d, 0.0, -5.5d);
            var v = ov.swizzle.rabg;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2d, 4.5d, 8.5d, -5.5d);
            var v = ov.swizzle.rabb;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, -5d, -3.5d, 8d);
            var v = ov.swizzle.raba;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4.5d, -9d, -5.5d, 6d);
            var v = ov.swizzle.raa;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-2d, 7.5d, -8.5d, -8.5d);
            var v = ov.swizzle.raar;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8.5d, 5d, -9.5d, 8d);
            var v = ov.swizzle.raag;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(8d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, 2d, 4.5d, -0.5d);
            var v = ov.swizzle.raab;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, 5d, -1d, -4.5d);
            var v = ov.swizzle.raaa;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5.5d, 3.5d, 8d, 4d);
            var v = ov.swizzle.gr;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(5d, 4.5d, -1.5d, -5d);
            var v = ov.swizzle.grr;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-1d, 9.5d, -7.5d, 5d);
            var v = ov.swizzle.grrr;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3d, -5.5d, 5d, -7.5d);
            var v = ov.swizzle.grrg;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5d, 1.0, 7.5d, -8d);
            var v = ov.swizzle.grrb;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2d, -1d, 4d, -5.5d);
            var v = ov.swizzle.grra;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6d, 2.5d, -6d, 9d);
            var v = ov.swizzle.grg;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(0.0, 9d, -9d, 5.5d);
            var v = ov.swizzle.grgr;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3d, 1.0, -3d, 2.5d);
            var v = ov.swizzle.grgg;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, -9d, 1.0, -7d);
            var v = ov.swizzle.grgb;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9d, 5d, -1d, -8.5d);
            var v = ov.swizzle.grga;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, -4d, 4d, -5.5d);
            var v = ov.swizzle.grb;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(6.5d, -2d, -4d, 3d);
            var v = ov.swizzle.grbr;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7d, 2.5d, -4d, -5.5d);
            var v = ov.swizzle.grbg;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, -5.5d, -0.5d, -3d);
            var v = ov.swizzle.grbb;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, -8d, -5d, 1.0);
            var v = ov.swizzle.grba;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8.5d, -2.5d, 1.0, 2d);
            var v = ov.swizzle.gra;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-1d, -4d, -2d, 5.5d);
            var v = ov.swizzle.grar;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, -8.5d, 8d, 5d);
            var v = ov.swizzle.grag;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, -6.5d, 1.0, 1.0);
            var v = ov.swizzle.grab;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, 1.5d, -4d, -1.5d);
            var v = ov.swizzle.graa;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(-1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5.5d, -5d, -2.5d, -1d);
            var v = ov.swizzle.gg;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-1.5d, -0.5d, 2d, -3.5d);
            var v = ov.swizzle.ggr;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(0.5d, -1.5d, 8.5d, 1.5d);
            var v = ov.swizzle.ggrr;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.5d, 8d, 0.0, 5.5d);
            var v = ov.swizzle.ggrg;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2d, 1.0, -4d, -6.5d);
            var v = ov.swizzle.ggrb;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, -9d, 3d, -2.5d);
            var v = ov.swizzle.ggra;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, 8d, -5.5d, 5d);
            var v = ov.swizzle.ggg;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(8d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-6.5d, -2.5d, -5.5d, -2.5d);
            var v = ov.swizzle.gggr;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, -3.5d, 6d, 6d);
            var v = ov.swizzle.gggg;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, 0.5d, -5d, -8.5d);
            var v = ov.swizzle.gggb;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, -3.5d, 4d, -2d);
            var v = ov.swizzle.ggga;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7.5d, -7d, -4d, 1.5d);
            var v = ov.swizzle.ggb;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-6.5d, 5d, -0.5d, -2.5d);
            var v = ov.swizzle.ggbr;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7d, 0.5d, -1.5d, -6d);
            var v = ov.swizzle.ggbg;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, 9.5d, -2.5d, -9d);
            var v = ov.swizzle.ggbb;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5d, 7.5d, 3d, 2d);
            var v = ov.swizzle.ggba;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, -1d, -2.5d, 4d);
            var v = ov.swizzle.gga;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(2d, 4.5d, 5.5d, -8.5d);
            var v = ov.swizzle.ggar;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2.5d, 2.5d, -3d, -5d);
            var v = ov.swizzle.ggag;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, 2.5d, 4d, 6d);
            var v = ov.swizzle.ggab;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, 2.5d, -6.5d, -7d);
            var v = ov.swizzle.ggaa;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, 7.5d, -1d, -4d);
            var v = ov.swizzle.gb;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(8.5d, 0.5d, 5.5d, 0.0);
            var v = ov.swizzle.gbr;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(3d, 5.5d, -6d, -4d);
            var v = ov.swizzle.gbrr;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, 2d, 6d, -2d);
            var v = ov.swizzle.gbrg;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.5d, 8d, -0.5d, -1.5d);
            var v = ov.swizzle.gbrb;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, 7d, 9.5d, -5.5d);
            var v = ov.swizzle.gbra;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8d, -4d, 1.0, -8d);
            var v = ov.swizzle.gbg;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(4.5d, -8.5d, -4.5d, -3d);
            var v = ov.swizzle.gbgr;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, -3.5d, 4d, 6d);
            var v = ov.swizzle.gbgg;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, -3d, 6d, -2d);
            var v = ov.swizzle.gbgb;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, 4.5d, -8d, 1.5d);
            var v = ov.swizzle.gbga;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7d, 8.5d, 1.5d, -2d);
            var v = ov.swizzle.gbb;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-4.5d, 3.5d, -6d, -4.5d);
            var v = ov.swizzle.gbbr;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(-6d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3d, 4.5d, 6d, 0.5d);
            var v = ov.swizzle.gbbg;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7.5d, -3.5d, 5.5d, -4.5d);
            var v = ov.swizzle.gbbb;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, -7d, 6d, -7.5d);
            var v = ov.swizzle.gbba;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, 3d, 9.5d, 6.5d);
            var v = ov.swizzle.gba;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(7.5d, 9.5d, -2d, -7d);
            var v = ov.swizzle.gbar;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2d, -7d, 0.5d, -7d);
            var v = ov.swizzle.gbag;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, 8d, 7d, -9d);
            var v = ov.swizzle.gbab;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7.5d, 0.5d, 2.5d, 1.0);
            var v = ov.swizzle.gbaa;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, 9.5d, 9d, -9d);
            var v = ov.swizzle.ga;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-9.5d, -4d, 9d, -4d);
            var v = ov.swizzle.gar;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-7d, -7.5d, -5.5d, -7.5d);
            var v = ov.swizzle.garr;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, 5.5d, -8.5d, -4d);
            var v = ov.swizzle.garg;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, 5.5d, -4d, -3.5d);
            var v = ov.swizzle.garb;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8.5d, 8.5d, -6.5d, -3.5d);
            var v = ov.swizzle.gara;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, 0.5d, 0.0, -0.5d);
            var v = ov.swizzle.gag;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-9d, -6d, 2d, 8.5d);
            var v = ov.swizzle.gagr;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(-6d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, 4d, -8d, -2d);
            var v = ov.swizzle.gagg;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3.5d, -8.5d, -7d, -6.5d);
            var v = ov.swizzle.gagb;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.5d, 7.5d, 9.5d, -8.5d);
            var v = ov.swizzle.gaga;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3.5d, 8d, -1.5d, 4.5d);
            var v = ov.swizzle.gab;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-2.5d, 4.5d, -8.5d, -3.5d);
            var v = ov.swizzle.gabr;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6d, 6d, -9.5d, 5d);
            var v = ov.swizzle.gabg;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6d, -5.5d, -5d, 0.5d);
            var v = ov.swizzle.gabb;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, -9.5d, 5.5d, 1.0);
            var v = ov.swizzle.gaba;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, -4.5d, 7.5d, -6.5d);
            var v = ov.swizzle.gaa;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-8d, 9d, -9.5d, -8d);
            var v = ov.swizzle.gaar;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(-8d, Is.EqualTo(v.z));
            Assert.That(-8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, 0.5d, 5.5d, -5.5d);
            var v = ov.swizzle.gaag;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, 2d, 3.5d, 6.5d);
            var v = ov.swizzle.gaab;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, 6d, 1.0, -5.5d);
            var v = ov.swizzle.gaaa;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5.5d, -6d, -7.5d, -8d);
            var v = ov.swizzle.br;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-5.5d, -2d, 5.5d, 9d);
            var v = ov.swizzle.brr;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(5d, -2.5d, 9d, 9d);
            var v = ov.swizzle.brrr;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2d, 8.5d, 1.0, 7d);
            var v = ov.swizzle.brrg;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(2d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, 5d, -6d, -8d);
            var v = ov.swizzle.brrb;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, 2d, 7d, -4.5d);
            var v = ov.swizzle.brra;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, 6.5d, 6d, -4d);
            var v = ov.swizzle.brg;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(0.5d, -8d, -1.5d, 6d);
            var v = ov.swizzle.brgr;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(-8d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, -1d, 5d, 2d);
            var v = ov.swizzle.brgg;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3d, -9d, 8.5d, 6d);
            var v = ov.swizzle.brgb;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, -1d, -2d, 1.5d);
            var v = ov.swizzle.brga;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, -3.5d, -8.5d, 0.0);
            var v = ov.swizzle.brb;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(0.0, -4.5d, -4.5d, 6.5d);
            var v = ov.swizzle.brbr;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.5d, -5.5d, 9d, 3.5d);
            var v = ov.swizzle.brbg;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7d, 6.5d, 6d, -1.5d);
            var v = ov.swizzle.brbb;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, -8.5d, -9d, -1.5d);
            var v = ov.swizzle.brba;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
            Assert.That(-1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, 3d, 1.5d, 1.5d);
            var v = ov.swizzle.bra;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(3.5d, 8.5d, 4d, 2.5d);
            var v = ov.swizzle.brar;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(6d, 9d, 3d, 2d);
            var v = ov.swizzle.brag;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.5d, -6d, 4d, -4.5d);
            var v = ov.swizzle.brab;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5d, 6d, -3d, 4d);
            var v = ov.swizzle.braa;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3.5d, 2.5d, -6d, 4.5d);
            var v = ov.swizzle.bg;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(1.0, -2d, 4.5d, 6d);
            var v = ov.swizzle.bgr;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-3d, -1d, 1.0, 2.5d);
            var v = ov.swizzle.bgrr;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2.5d, -5.5d, 3.5d, -7d);
            var v = ov.swizzle.bgrg;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, 0.5d, 6d, 1.0);
            var v = ov.swizzle.bgrb;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8.5d, 3.5d, -0.5d, -8.5d);
            var v = ov.swizzle.bgra;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, 6d, 2d, 2.5d);
            var v = ov.swizzle.bgg;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(1.5d, -8.5d, -3d, 8.5d);
            var v = ov.swizzle.bggr;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7d, -4d, 4.5d, 5d);
            var v = ov.swizzle.bggg;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2.5d, 6.5d, -0.5d, -8.5d);
            var v = ov.swizzle.bggb;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3d, 7.5d, -9d, 5.5d);
            var v = ov.swizzle.bgga;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7d, -1d, -1d, 5d);
            var v = ov.swizzle.bgb;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-6.5d, -1.5d, 0.5d, -5.5d);
            var v = ov.swizzle.bgbr;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, -2d, -5.5d, 0.0);
            var v = ov.swizzle.bgbg;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2d, 5.5d, -5d, 4.5d);
            var v = ov.swizzle.bgbb;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, 2d, -5d, 1.5d);
            var v = ov.swizzle.bgba;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(2d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7.5d, 3d, -4.5d, -9d);
            var v = ov.swizzle.bga;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(0.5d, -2.5d, 0.5d, 8.5d);
            var v = ov.swizzle.bgar;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, -3.5d, 7.5d, -6.5d);
            var v = ov.swizzle.bgag;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, 4.5d, -3d, 8d);
            var v = ov.swizzle.bgab;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(8d, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(6.5d, 6.5d, 8d, 3d);
            var v = ov.swizzle.bgaa;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.5d, -1.5d, 9.5d, 6.5d);
            var v = ov.swizzle.bb;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-0.5d, 4.5d, 3d, 2.5d);
            var v = ov.swizzle.bbr;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-7.5d, 5.5d, -2d, 1.0);
            var v = ov.swizzle.bbrr;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, -2.5d, 7.5d, 4d);
            var v = ov.swizzle.bbrg;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, 2.5d, -6d, 5.5d);
            var v = ov.swizzle.bbrb;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, 2.5d, -5.5d, -4d);
            var v = ov.swizzle.bbra;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, 0.0, -3.5d, 8d);
            var v = ov.swizzle.bbg;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-7.5d, 5d, 8.5d, -2d);
            var v = ov.swizzle.bbgr;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, -2d, 0.0, 9d);
            var v = ov.swizzle.bbgg;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, -1.5d, -0.5d, 5.5d);
            var v = ov.swizzle.bbgb;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, 8.5d, -6d, 5d);
            var v = ov.swizzle.bbga;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, 6.5d, 0.0, -2.5d);
            var v = ov.swizzle.bbb;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(6.5d, 7d, -6.5d, 4d);
            var v = ov.swizzle.bbbr;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8.5d, -3d, 5d, 9.5d);
            var v = ov.swizzle.bbbg;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4d, -3.5d, -6.5d, -1.5d);
            var v = ov.swizzle.bbbb;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, 4.5d, 9d, -7d);
            var v = ov.swizzle.bbba;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7.5d, 0.0, 7d, -1d);
            var v = ov.swizzle.bba;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-2.5d, -1.5d, 0.0, 8.5d);
            var v = ov.swizzle.bbar;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2d, -8.5d, -2d, 0.0);
            var v = ov.swizzle.bbag;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6d, -8d, 9.5d, -7d);
            var v = ov.swizzle.bbab;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.0, 8.5d, -3d, -5d);
            var v = ov.swizzle.bbaa;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, 4.5d, 1.5d, -8.5d);
            var v = ov.swizzle.ba;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(5d, 1.0, 4d, -9d);
            var v = ov.swizzle.bar;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(5d, 0.0, -2.5d, 0.5d);
            var v = ov.swizzle.barr;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, 9.5d, 7d, -4d);
            var v = ov.swizzle.barg;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, -0.5d, 9.5d, 7d);
            var v = ov.swizzle.barb;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7d, -4.5d, 1.0, 9.5d);
            var v = ov.swizzle.bara;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, 5d, -6.5d, -2.5d);
            var v = ov.swizzle.bag;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-3.5d, 5d, -1.5d, 9d);
            var v = ov.swizzle.bagr;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7.5d, 4.5d, 4.5d, 3d);
            var v = ov.swizzle.bagg;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8d, -3.5d, 4d, -3.5d);
            var v = ov.swizzle.bagb;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, -7.5d, 3.5d, 1.0);
            var v = ov.swizzle.baga;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3.5d, -7.5d, -2d, -7d);
            var v = ov.swizzle.bab;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-1d, -3.5d, -2.5d, -2d);
            var v = ov.swizzle.babr;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, 4d, 7d, 7.5d);
            var v = ov.swizzle.babg;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(2.5d, 1.5d, -9.5d, 0.0);
            var v = ov.swizzle.babb;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
            Assert.That(-9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8d, -8d, 2.5d, 9.5d);
            var v = ov.swizzle.baba;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3d, -7d, 7d, 4.5d);
            var v = ov.swizzle.baa;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(4d, 4d, 4d, 3d);
            var v = ov.swizzle.baar;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, -4d, -5.5d, -4.5d);
            var v = ov.swizzle.baag;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.5d, 9.5d, 6d, -9.5d);
            var v = ov.swizzle.baab;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(4.5d, 5d, -7d, 9.5d);
            var v = ov.swizzle.baaa;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, -7d, -1d, -8d);
            var v = ov.swizzle.ar;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-2.5d, 6.5d, -1d, -7d);
            var v = ov.swizzle.arr;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(6d, 4d, 7d, 6d);
            var v = ov.swizzle.arrr;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, 4.5d, -0.5d, -6d);
            var v = ov.swizzle.arrg;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4d, -7d, -3d, 5d);
            var v = ov.swizzle.arrb;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7.5d, -5.5d, -2.5d, -4.5d);
            var v = ov.swizzle.arra;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, -7.5d, 6d, 3.5d);
            var v = ov.swizzle.arg;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-4.5d, 9.5d, 6d, -3d);
            var v = ov.swizzle.argr;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.0, 3.5d, -9.5d, 6.5d);
            var v = ov.swizzle.argg;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(6d, 0.5d, 6d, 8d);
            var v = ov.swizzle.argb;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3.5d, -1.5d, 6.5d, -9.5d);
            var v = ov.swizzle.arga;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(-9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(6d, -8d, 5.5d, 7.5d);
            var v = ov.swizzle.arb;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-1d, 0.5d, 5d, -7d);
            var v = ov.swizzle.arbr;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3.5d, -1d, -8d, 4.5d);
            var v = ov.swizzle.arbg;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(-8d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, -3.5d, 7.5d, 4d);
            var v = ov.swizzle.arbb;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(0.5d, -8d, 1.5d, 6d);
            var v = ov.swizzle.arba;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7.5d, 4.5d, 5d, 5.5d);
            var v = ov.swizzle.ara;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-4d, 2.5d, 9d, -6.5d);
            var v = ov.swizzle.arar;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, 3d, -3d, 3.5d);
            var v = ov.swizzle.arag;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, 7d, -8d, 2d);
            var v = ov.swizzle.arab;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
            Assert.That(-8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2.5d, 8d, -6.5d, 5.5d);
            var v = ov.swizzle.araa;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3.5d, 0.5d, -9d, 0.5d);
            var v = ov.swizzle.ag;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-6d, -3.5d, 6d, -8.5d);
            var v = ov.swizzle.agr;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-6d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(3.5d, 1.0, -8d, -6d);
            var v = ov.swizzle.agrr;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(6.5d, -0.5d, -7.5d, -2d);
            var v = ov.swizzle.agrg;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2d, 9.5d, -5.5d, -8d);
            var v = ov.swizzle.agrb;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8.5d, -6.5d, 5d, -0.5d);
            var v = ov.swizzle.agra;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, -5.5d, 6d, -7.5d);
            var v = ov.swizzle.agg;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(7d, 4.5d, -8d, -7.5d);
            var v = ov.swizzle.aggr;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5.5d, 6.5d, -3d, 7d);
            var v = ov.swizzle.aggg;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6d, -5d, -9.5d, -2.5d);
            var v = ov.swizzle.aggb;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(-9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, -0.5d, -0.5d, 8d);
            var v = ov.swizzle.agga;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, 6.5d, 6.5d, 8.5d);
            var v = ov.swizzle.agb;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-4.5d, 5d, 1.5d, -2.5d);
            var v = ov.swizzle.agbr;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, 5d, -5d, -1d);
            var v = ov.swizzle.agbg;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, -0.5d, 2.5d, 2.5d);
            var v = ov.swizzle.agbb;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, -4.5d, -3d, 8.5d);
            var v = ov.swizzle.agba;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6.5d, 6.5d, -9.5d, 0.0);
            var v = ov.swizzle.aga;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-7d, -5d, 6.5d, 7.5d);
            var v = ov.swizzle.agar;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9.5d, 7.5d, 2.5d, 1.5d);
            var v = ov.swizzle.agag;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3.5d, 7.5d, 3d, 1.0);
            var v = ov.swizzle.agab;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-2.5d, 7d, 6.5d, 1.0);
            var v = ov.swizzle.agaa;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(3d, 1.5d, 7.5d, 0.5d);
            var v = ov.swizzle.ab;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-7.5d, 2d, -6.5d, -3.5d);
            var v = ov.swizzle.abr;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-6.5d, -1.5d, 7d, 0.0);
            var v = ov.swizzle.abrr;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-6d, 1.5d, -4.5d, -0.5d);
            var v = ov.swizzle.abrg;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-6d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-7d, 6.5d, -7.5d, 9d);
            var v = ov.swizzle.abrb;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9d, 3.5d, 6d, -2.5d);
            var v = ov.swizzle.abra;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3d, -6.5d, -7d, -2.5d);
            var v = ov.swizzle.abg;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-3.5d, 1.5d, 4d, -2d);
            var v = ov.swizzle.abgr;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, -1d, 5.5d, 2.5d);
            var v = ov.swizzle.abgg;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(8.5d, 0.5d, -9d, -4d);
            var v = ov.swizzle.abgb;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(1.5d, -1d, -5d, 2.5d);
            var v = ov.swizzle.abga;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-0.5d, 1.5d, -6d, 2d);
            var v = ov.swizzle.abb;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(-6d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-2d, -5d, -4.5d, 1.5d);
            var v = ov.swizzle.abbr;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, -2.5d, 2.5d, 9d);
            var v = ov.swizzle.abbg;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4.5d, -1d, -7d, 8.5d);
            var v = ov.swizzle.abbb;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-4.5d, 6.5d, 0.0, 2.5d);
            var v = ov.swizzle.abba;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, 5.5d, -3d, 5d);
            var v = ov.swizzle.aba;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(5.5d, 3.5d, 1.5d, -3.5d);
            var v = ov.swizzle.abar;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8d, 7d, -9d, 8.5d);
            var v = ov.swizzle.abag;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, -4d, 7.5d, -7.5d);
            var v = ov.swizzle.abab;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(6d, -5d, -5d, -1d);
            var v = ov.swizzle.abaa;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5d, -3d, -4.5d, 1.0);
            var v = ov.swizzle.aa;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec4(-8d, -4.5d, 6d, -2.5d);
            var v = ov.swizzle.aar;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(-8d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-4d, -9.5d, -0.5d, 5.5d);
            var v = ov.swizzle.aarr;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, -7.5d, 8d, 3.5d);
            var v = ov.swizzle.aarg;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8d, -1d, 7d, -9d);
            var v = ov.swizzle.aarb;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(-8d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, 8.5d, -4d, -9d);
            var v = ov.swizzle.aara;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7d, 4.5d, 0.5d, -1d);
            var v = ov.swizzle.aag;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(-4d, 4.5d, 1.5d, -1d);
            var v = ov.swizzle.aagr;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-8.5d, -0.5d, -3.5d, -1d);
            var v = ov.swizzle.aagg;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1d, -2d, -2.5d, 9d);
            var v = ov.swizzle.aagb;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, 3d, -3d, 7.5d);
            var v = ov.swizzle.aaga;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-9d, -6.5d, -1.5d, 6.5d);
            var v = ov.swizzle.aab;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(5d, 3d, 3d, 6.5d);
            var v = ov.swizzle.aabr;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(7d, 6.5d, -2.5d, 7d);
            var v = ov.swizzle.aabg;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(9.5d, 6d, 3.5d, -5.5d);
            var v = ov.swizzle.aabb;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5.5d, 6.5d, -4d, -9d);
            var v = ov.swizzle.aaba;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-1.5d, -8d, -4d, -8.5d);
            var v = ov.swizzle.aaa;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec4(6.5d, 8.5d, -6.5d, 6d);
            var v = ov.swizzle.aaar;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-5.5d, 7.5d, 2.5d, -9.5d);
            var v = ov.swizzle.aaag;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(-3.5d, -6d, 9.5d, -5.5d);
            var v = ov.swizzle.aaab;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec4(5d, 3.5d, 5d, 9d);
            var v = ov.swizzle.aaaa;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new dvec4(7d, 1.0, 4d, -4d);
            var v1 = new dvec2(8.5d, 2d);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(8.5d, Is.EqualTo(v0.x));
            Assert.That(2d, Is.EqualTo(v0.y));
            Assert.That(4d, Is.EqualTo(v0.z));
            Assert.That(-4d, Is.EqualTo(v0.w));
        
            Assert.That(7d, Is.EqualTo(v2.x));
            Assert.That(1.0, Is.EqualTo(v2.y));
        }
        {
            var v0 = new dvec4(2.5d, 8.5d, 9d, 4.5d);
            var v1 = new dvec2(-7.5d, -1d);
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-7.5d, Is.EqualTo(v0.x));
            Assert.That(8.5d, Is.EqualTo(v0.y));
            Assert.That(-1d, Is.EqualTo(v0.z));
            Assert.That(4.5d, Is.EqualTo(v0.w));
        
            Assert.That(2.5d, Is.EqualTo(v2.x));
            Assert.That(9d, Is.EqualTo(v2.y));
        }
        {
            var v0 = new dvec4(-4d, 5d, -4.5d, -8.5d);
            var v1 = new dvec2(-2d, -2d);
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-4d, Is.EqualTo(v0.x));
            Assert.That(-2d, Is.EqualTo(v0.y));
            Assert.That(-2d, Is.EqualTo(v0.z));
            Assert.That(-8.5d, Is.EqualTo(v0.w));
        
            Assert.That(5d, Is.EqualTo(v2.x));
            Assert.That(-4.5d, Is.EqualTo(v2.y));
        }
        {
            var v0 = new dvec4(-3.5d, -2.5d, 3d, -0.5d);
            var v1 = new dvec3(5.5d, -9d, -3.5d);
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(5.5d, Is.EqualTo(v0.x));
            Assert.That(-9d, Is.EqualTo(v0.y));
            Assert.That(-3.5d, Is.EqualTo(v0.z));
            Assert.That(-0.5d, Is.EqualTo(v0.w));
        
            Assert.That(-3.5d, Is.EqualTo(v2.x));
            Assert.That(-2.5d, Is.EqualTo(v2.y));
            Assert.That(3d, Is.EqualTo(v2.z));
        }
        {
            var v0 = new dvec4(6d, -9d, 2d, 7d);
            var v1 = new dvec2(9d, -0.5d);
            var v2 = v0.xw;
            v0.xw = v1;
            var v3 = v0.xw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(9d, Is.EqualTo(v0.x));
            Assert.That(-9d, Is.EqualTo(v0.y));
            Assert.That(2d, Is.EqualTo(v0.z));
            Assert.That(-0.5d, Is.EqualTo(v0.w));
        
            Assert.That(6d, Is.EqualTo(v2.x));
            Assert.That(7d, Is.EqualTo(v2.y));
        }
        {
            var v0 = new dvec4(4d, -3.5d, 4.5d, -1.5d);
            var v1 = new dvec2(9.5d, -1.5d);
            var v2 = v0.yw;
            v0.yw = v1;
            var v3 = v0.yw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4d, Is.EqualTo(v0.x));
            Assert.That(9.5d, Is.EqualTo(v0.y));
            Assert.That(4.5d, Is.EqualTo(v0.z));
            Assert.That(-1.5d, Is.EqualTo(v0.w));
        
            Assert.That(-3.5d, Is.EqualTo(v2.x));
            Assert.That(-1.5d, Is.EqualTo(v2.y));
        }
        {
            var v0 = new dvec4(-9.5d, 2d, 8.5d, -4.5d);
            var v1 = new dvec3(9.5d, -1.5d, 7d);
            var v2 = v0.xyw;
            v0.xyw = v1;
            var v3 = v0.xyw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(9.5d, Is.EqualTo(v0.x));
            Assert.That(-1.5d, Is.EqualTo(v0.y));
            Assert.That(8.5d, Is.EqualTo(v0.z));
            Assert.That(7d, Is.EqualTo(v0.w));
        
            Assert.That(-9.5d, Is.EqualTo(v2.x));
            Assert.That(2d, Is.EqualTo(v2.y));
            Assert.That(-4.5d, Is.EqualTo(v2.z));
        }
        {
            var v0 = new dvec4(-7d, -9.5d, 5.5d, -7.5d);
            var v1 = new dvec2(-5.5d, -8.5d);
            var v2 = v0.zw;
            v0.zw = v1;
            var v3 = v0.zw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-7d, Is.EqualTo(v0.x));
            Assert.That(-9.5d, Is.EqualTo(v0.y));
            Assert.That(-5.5d, Is.EqualTo(v0.z));
            Assert.That(-8.5d, Is.EqualTo(v0.w));
        
            Assert.That(5.5d, Is.EqualTo(v2.x));
            Assert.That(-7.5d, Is.EqualTo(v2.y));
        }
        {
            var v0 = new dvec4(9.5d, 5d, 4d, -8d);
            var v1 = new dvec3(-7d, -9d, 5d);
            var v2 = v0.xzw;
            v0.xzw = v1;
            var v3 = v0.xzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-7d, Is.EqualTo(v0.x));
            Assert.That(5d, Is.EqualTo(v0.y));
            Assert.That(-9d, Is.EqualTo(v0.z));
            Assert.That(5d, Is.EqualTo(v0.w));
        
            Assert.That(9.5d, Is.EqualTo(v2.x));
            Assert.That(4d, Is.EqualTo(v2.y));
            Assert.That(-8d, Is.EqualTo(v2.z));
        }
        {
            var v0 = new dvec4(-3.5d, -2.5d, 1.5d, -6.5d);
            var v1 = new dvec3(-0.5d, 0.5d, 0.0);
            var v2 = v0.yzw;
            v0.yzw = v1;
            var v3 = v0.yzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-3.5d, Is.EqualTo(v0.x));
            Assert.That(-0.5d, Is.EqualTo(v0.y));
            Assert.That(0.5d, Is.EqualTo(v0.z));
            Assert.That(0.0, Is.EqualTo(v0.w));
        
            Assert.That(-2.5d, Is.EqualTo(v2.x));
            Assert.That(1.5d, Is.EqualTo(v2.y));
            Assert.That(-6.5d, Is.EqualTo(v2.z));
        }
        {
            var v0 = new dvec4(5d, -8d, -4.5d, -9.5d);
            var v1 = new dvec4(-8d, -3.5d, 2.5d, 1.5d);
            var v2 = v0.xyzw;
            v0.xyzw = v1;
            var v3 = v0.xyzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-8d, Is.EqualTo(v0.x));
            Assert.That(-3.5d, Is.EqualTo(v0.y));
            Assert.That(2.5d, Is.EqualTo(v0.z));
            Assert.That(1.5d, Is.EqualTo(v0.w));
        
            Assert.That(5d, Is.EqualTo(v2.x));
            Assert.That(-8d, Is.EqualTo(v2.y));
            Assert.That(-4.5d, Is.EqualTo(v2.z));
            Assert.That(-9.5d, Is.EqualTo(v2.w));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            dvec4 v0 = new dvec4(3d, -9.5d, 5d, -9.5d);
            double v1 = -6.5d;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-6.5d, Is.EqualTo(v0.x));
            Assert.That(-9.5d, Is.EqualTo(v0.y));
            Assert.That(5d, Is.EqualTo(v0.z));
            Assert.That(-9.5d, Is.EqualTo(v0.w));
        
            Assert.That(3d, Is.EqualTo(v2));
        }
        {
            dvec4 v0 = new dvec4(0.0, -7d, -6.5d, 6.5d);
            double v1 = -8.5d;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(0.0, Is.EqualTo(v0.x));
            Assert.That(-8.5d, Is.EqualTo(v0.y));
            Assert.That(-6.5d, Is.EqualTo(v0.z));
            Assert.That(6.5d, Is.EqualTo(v0.w));
        
            Assert.That(-7d, Is.EqualTo(v2));
        }
        {
            dvec4 v0 = new dvec4(-0.5d, -4d, -1.5d, -0.5d);
            dvec2 v1 = new dvec2(-2.5d, -3.5d);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-2.5d, Is.EqualTo(v0.x));
            Assert.That(-3.5d, Is.EqualTo(v0.y));
            Assert.That(-1.5d, Is.EqualTo(v0.z));
            Assert.That(-0.5d, Is.EqualTo(v0.w));
        
            Assert.That(-0.5d, Is.EqualTo(v2.x));
            Assert.That(-4d, Is.EqualTo(v2.y));
        }
        {
            dvec4 v0 = new dvec4(2.5d, -0.5d, -8.5d, -7d);
            double v1 = 6d;
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(2.5d, Is.EqualTo(v0.x));
            Assert.That(-0.5d, Is.EqualTo(v0.y));
            Assert.That(6d, Is.EqualTo(v0.z));
            Assert.That(-7d, Is.EqualTo(v0.w));
        
            Assert.That(-8.5d, Is.EqualTo(v2));
        }
        {
            dvec4 v0 = new dvec4(6d, -6.5d, -2d, -2d);
            dvec2 v1 = new dvec2(-4d, 6d);
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-4d, Is.EqualTo(v0.x));
            Assert.That(-6.5d, Is.EqualTo(v0.y));
            Assert.That(6d, Is.EqualTo(v0.z));
            Assert.That(-2d, Is.EqualTo(v0.w));
        
            Assert.That(6d, Is.EqualTo(v2.x));
            Assert.That(-2d, Is.EqualTo(v2.y));
        }
        {
            dvec4 v0 = new dvec4(4.5d, 3d, 0.5d, 4.5d);
            dvec2 v1 = new dvec2(3.5d, 3d);
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4.5d, Is.EqualTo(v0.x));
            Assert.That(3.5d, Is.EqualTo(v0.y));
            Assert.That(3d, Is.EqualTo(v0.z));
            Assert.That(4.5d, Is.EqualTo(v0.w));
        
            Assert.That(3d, Is.EqualTo(v2.x));
            Assert.That(0.5d, Is.EqualTo(v2.y));
        }
        {
            dvec4 v0 = new dvec4(5d, 3.5d, 7.5d, 8.5d);
            dvec3 v1 = new dvec3(-2d, 8.5d, -5d);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-2d, Is.EqualTo(v0.x));
            Assert.That(8.5d, Is.EqualTo(v0.y));
            Assert.That(-5d, Is.EqualTo(v0.z));
            Assert.That(8.5d, Is.EqualTo(v0.w));
        
            Assert.That(5d, Is.EqualTo(v2.x));
            Assert.That(3.5d, Is.EqualTo(v2.y));
            Assert.That(7.5d, Is.EqualTo(v2.z));
        }
        {
            dvec4 v0 = new dvec4(-7.5d, 7d, 9d, -0.5d);
            double v1 = 8.5d;
            var v2 = v0.a;
            v0.a = v1;
            var v3 = v0.a;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-7.5d, Is.EqualTo(v0.x));
            Assert.That(7d, Is.EqualTo(v0.y));
            Assert.That(9d, Is.EqualTo(v0.z));
            Assert.That(8.5d, Is.EqualTo(v0.w));
        
            Assert.That(-0.5d, Is.EqualTo(v2));
        }
        {
            dvec4 v0 = new dvec4(-7d, -2d, -4d, 2.5d);
            dvec2 v1 = new dvec2(-0.5d, -1.5d);
            var v2 = v0.ra;
            v0.ra = v1;
            var v3 = v0.ra;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-0.5d, Is.EqualTo(v0.x));
            Assert.That(-2d, Is.EqualTo(v0.y));
            Assert.That(-4d, Is.EqualTo(v0.z));
            Assert.That(-1.5d, Is.EqualTo(v0.w));
        
            Assert.That(-7d, Is.EqualTo(v2.x));
            Assert.That(2.5d, Is.EqualTo(v2.y));
        }
        {
            dvec4 v0 = new dvec4(6d, 1.0, 7.5d, -1.5d);
            dvec2 v1 = new dvec2(7.5d, 6.5d);
            var v2 = v0.ga;
            v0.ga = v1;
            var v3 = v0.ga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(6d, Is.EqualTo(v0.x));
            Assert.That(7.5d, Is.EqualTo(v0.y));
            Assert.That(7.5d, Is.EqualTo(v0.z));
            Assert.That(6.5d, Is.EqualTo(v0.w));
        
            Assert.That(1.0, Is.EqualTo(v2.x));
            Assert.That(-1.5d, Is.EqualTo(v2.y));
        }
        {
            dvec4 v0 = new dvec4(4.5d, 8d, 9d, 3.5d);
            dvec3 v1 = new dvec3(-6.5d, -9d, 5d);
            var v2 = v0.rga;
            v0.rga = v1;
            var v3 = v0.rga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-6.5d, Is.EqualTo(v0.x));
            Assert.That(-9d, Is.EqualTo(v0.y));
            Assert.That(9d, Is.EqualTo(v0.z));
            Assert.That(5d, Is.EqualTo(v0.w));
        
            Assert.That(4.5d, Is.EqualTo(v2.x));
            Assert.That(8d, Is.EqualTo(v2.y));
            Assert.That(3.5d, Is.EqualTo(v2.z));
        }
        {
            dvec4 v0 = new dvec4(-3.5d, 5.5d, 9d, -6.5d);
            dvec2 v1 = new dvec2(5.5d, 0.5d);
            var v2 = v0.ba;
            v0.ba = v1;
            var v3 = v0.ba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-3.5d, Is.EqualTo(v0.x));
            Assert.That(5.5d, Is.EqualTo(v0.y));
            Assert.That(5.5d, Is.EqualTo(v0.z));
            Assert.That(0.5d, Is.EqualTo(v0.w));
        
            Assert.That(9d, Is.EqualTo(v2.x));
            Assert.That(-6.5d, Is.EqualTo(v2.y));
        }
        {
            dvec4 v0 = new dvec4(-2.5d, -9.5d, 1.5d, 6d);
            dvec3 v1 = new dvec3(4.5d, 8.5d, 7.5d);
            var v2 = v0.rba;
            v0.rba = v1;
            var v3 = v0.rba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4.5d, Is.EqualTo(v0.x));
            Assert.That(-9.5d, Is.EqualTo(v0.y));
            Assert.That(8.5d, Is.EqualTo(v0.z));
            Assert.That(7.5d, Is.EqualTo(v0.w));
        
            Assert.That(-2.5d, Is.EqualTo(v2.x));
            Assert.That(1.5d, Is.EqualTo(v2.y));
            Assert.That(6d, Is.EqualTo(v2.z));
        }
        {
            dvec4 v0 = new dvec4(4.5d, -4d, 5.5d, 2d);
            dvec3 v1 = new dvec3(2.5d, 1.0, -5d);
            var v2 = v0.gba;
            v0.gba = v1;
            var v3 = v0.gba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4.5d, Is.EqualTo(v0.x));
            Assert.That(2.5d, Is.EqualTo(v0.y));
            Assert.That(1.0, Is.EqualTo(v0.z));
            Assert.That(-5d, Is.EqualTo(v0.w));
        
            Assert.That(-4d, Is.EqualTo(v2.x));
            Assert.That(5.5d, Is.EqualTo(v2.y));
            Assert.That(2d, Is.EqualTo(v2.z));
        }
        {
            dvec4 v0 = new dvec4(1.0, -2.5d, 2.5d, 5d);
            dvec4 v1 = new dvec4(-7d, 6.5d, 0.0, 4d);
            var v2 = v0.rgba;
            v0.rgba = v1;
            var v3 = v0.rgba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-7d, Is.EqualTo(v0.x));
            Assert.That(6.5d, Is.EqualTo(v0.y));
            Assert.That(0.0, Is.EqualTo(v0.z));
            Assert.That(4d, Is.EqualTo(v0.w));
        
            Assert.That(1.0, Is.EqualTo(v2.x));
            Assert.That(-2.5d, Is.EqualTo(v2.y));
            Assert.That(2.5d, Is.EqualTo(v2.z));
            Assert.That(5d, Is.EqualTo(v2.w));
        }
    }

}
