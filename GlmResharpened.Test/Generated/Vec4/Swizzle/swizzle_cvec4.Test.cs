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
public class ComplexSwizzleVec4Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new cvec4(new Complex(-3d, -3.5d), new Complex(8d, 1.5d), new Complex(-1d, -2.5d), new Complex(-9d, -5d));
            var v = ov.swizzle.xx;
            Assert.That(new Complex(-3d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -3.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(2.5d, 9d), new Complex(5.5d, -7d), new Complex(6d, 8d), new Complex(-2d, 7d));
            var v = ov.swizzle.xxx;
            Assert.That(new Complex(2.5d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 9d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(8.5d, 6d), new Complex(-6.5d, 2d), new Complex(-1d, -8d), new Complex(0.5d, 3d));
            var v = ov.swizzle.xxxx;
            Assert.That(new Complex(8.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6d, -0.5d), new Complex(1.0, 6d), new Complex(-6d, 4.5d), new Complex(2d, -1d));
            var v = ov.swizzle.xxxy;
            Assert.That(new Complex(-6d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, -0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4d, -5d), new Complex(4.5d, -8d), new Complex(-8.5d, -2.5d), new Complex(7.5d, 8.5d));
            var v = ov.swizzle.xxxz;
            Assert.That(new Complex(-4d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, 4.5d), new Complex(9d, 3.5d), new Complex(8.5d, 9.5d), new Complex(7d, -4.5d));
            var v = ov.swizzle.xxxw;
            Assert.That(new Complex(6.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3d, 9.5d), new Complex(-7d, -5d), new Complex(-5d, -2d), new Complex(-3.5d, 3.5d));
            var v = ov.swizzle.xxy;
            Assert.That(new Complex(-3d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, -5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, -0.5d), new Complex(-8d, -4.5d), new Complex(7d, -3.5d), new Complex(7.5d, 5.5d));
            var v = ov.swizzle.xxyx;
            Assert.That(new Complex(-8.5d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, -0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5.5d, 3d), new Complex(-4d, 6d), new Complex(-1d, -8.5d), new Complex(-1.5d, -1d));
            var v = ov.swizzle.xxyy;
            Assert.That(new Complex(5.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3d, -2d), new Complex(-9d, 9.5d), new Complex(-6d, -8d), new Complex(-4d, -8d));
            var v = ov.swizzle.xxyz;
            Assert.That(new Complex(-3d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, -0.5d), new Complex(-1.5d, 7.5d), new Complex(9d, 2d), new Complex(-9d, 1.0));
            var v = ov.swizzle.xxyw;
            Assert.That(new Complex(9.5d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, 1.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, -2d), new Complex(1.0, -6d), new Complex(5d, 8d), new Complex(-6.5d, -9d));
            var v = ov.swizzle.xxz;
            Assert.That(new Complex(-0.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 8d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(9.5d, -8.5d), new Complex(-5d, -1d), new Complex(-3.5d, -8d), new Complex(-8d, 0.0));
            var v = ov.swizzle.xxzx;
            Assert.That(new Complex(9.5d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3d, -7d), new Complex(-3d, -3d), new Complex(-7.5d, 6d), new Complex(2d, 0.5d));
            var v = ov.swizzle.xxzy;
            Assert.That(new Complex(-3d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9d, 1.5d), new Complex(2d, 9.5d), new Complex(5d, -3d), new Complex(-5d, 3.5d));
            var v = ov.swizzle.xxzz;
            Assert.That(new Complex(9d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, 2d), new Complex(-9.5d, -5d), new Complex(0.5d, -8d), new Complex(-9.5d, -9d));
            var v = ov.swizzle.xxzw;
            Assert.That(new Complex(-8.5d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, -9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, -5d), new Complex(-3d, -7.5d), new Complex(4.5d, 9.5d), new Complex(2d, -9.5d));
            var v = ov.swizzle.xxw;
            Assert.That(new Complex(-5d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(0.5d, -3.5d), new Complex(-1.5d, -5.5d), new Complex(-0.5d, 8.5d), new Complex(4.5d, -6d));
            var v = ov.swizzle.xxwx;
            Assert.That(new Complex(0.5d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, 7.5d), new Complex(7d, 6d), new Complex(8.5d, 8d), new Complex(7d, 4.5d));
            var v = ov.swizzle.xxwy;
            Assert.That(new Complex(-8d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.0, -0.5d), new Complex(-9.5d, 5.5d), new Complex(-9d, -4d), new Complex(-2d, -7.5d));
            var v = ov.swizzle.xxwz;
            Assert.That(new Complex(0.0, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, 4d), new Complex(1.5d, 3.5d), new Complex(-2.5d, -2d), new Complex(6d, -7d));
            var v = ov.swizzle.xxww;
            Assert.That(new Complex(-2d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, 6d), new Complex(0.5d, -4.5d), new Complex(-4.5d, -7d), new Complex(-7.5d, -1.5d));
            var v = ov.swizzle.xy;
            Assert.That(new Complex(2.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, -4.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(1.5d, 9.5d), new Complex(7d, -0.5d), new Complex(-8d, -7d), new Complex(9d, 9d));
            var v = ov.swizzle.xyx;
            Assert.That(new Complex(1.5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-4d, -5.5d), new Complex(0.0, -6.5d), new Complex(3.5d, -5d), new Complex(-9.5d, -2d));
            var v = ov.swizzle.xyxx;
            Assert.That(new Complex(-4d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8.5d, -9.5d), new Complex(-0.5d, -6.5d), new Complex(3d, -4.5d), new Complex(-6d, -2.5d));
            var v = ov.swizzle.xyxy;
            Assert.That(new Complex(8.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, -6d), new Complex(2d, -3.5d), new Complex(2.5d, 2.5d), new Complex(-1d, 5.5d));
            var v = ov.swizzle.xyxz;
            Assert.That(new Complex(6d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4.5d, -2d), new Complex(2.5d, 2d), new Complex(9.5d, 2d), new Complex(5d, 7d));
            var v = ov.swizzle.xyxw;
            Assert.That(new Complex(-4.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, 4d), new Complex(-4d, -1d), new Complex(1.0, 8.5d), new Complex(-0.5d, 6.5d));
            var v = ov.swizzle.xyy;
            Assert.That(new Complex(-5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -1d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, -3.5d), new Complex(3.5d, 0.5d), new Complex(3d, -2.5d), new Complex(-0.5d, 9d));
            var v = ov.swizzle.xyyx;
            Assert.That(new Complex(-5.5d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, 0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3.5d, 3d), new Complex(-6.5d, 9.5d), new Complex(-1.5d, -2d), new Complex(-5.5d, -0.5d));
            var v = ov.swizzle.xyyy;
            Assert.That(new Complex(3.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6.5d, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, 5d), new Complex(-3d, 9d), new Complex(-1d, -9.5d), new Complex(-7.5d, 5.5d));
            var v = ov.swizzle.xyyz;
            Assert.That(new Complex(-1.5d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1d, 5d), new Complex(-9.5d, -2.5d), new Complex(-9.5d, -0.5d), new Complex(-8d, -3d));
            var v = ov.swizzle.xyyw;
            Assert.That(new Complex(-1d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4d, 2.5d), new Complex(-8d, 4.5d), new Complex(9d, -5d), new Complex(-2d, 6d));
            var v = ov.swizzle.xyz;
            Assert.That(new Complex(-4d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, -5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-7d, 8d), new Complex(2d, -5.5d), new Complex(5d, 4d), new Complex(8d, -6d));
            var v = ov.swizzle.xyzx;
            Assert.That(new Complex(-7d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, 8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, 0.0), new Complex(-6d, -5d), new Complex(-7.5d, 4d), new Complex(0.0, 2d));
            var v = ov.swizzle.xyzy;
            Assert.That(new Complex(9.5d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, -5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, -7.5d), new Complex(-9.5d, 6d), new Complex(7d, -7.5d), new Complex(-8d, -2.5d));
            var v = ov.swizzle.xyzz;
            Assert.That(new Complex(1.5d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5d, -1.5d), new Complex(-1.5d, -8.5d), new Complex(-4.5d, -5.5d), new Complex(-9.5d, 4.5d));
            var v = ov.swizzle.xyzw;
            Assert.That(new Complex(5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, -5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, 5.5d), new Complex(4d, 3d), new Complex(-2.5d, 8d), new Complex(-5d, -8d));
            var v = ov.swizzle.xyw;
            Assert.That(new Complex(6.5d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, -8d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(1.0, 8d), new Complex(-9d, 5.5d), new Complex(-1.5d, -7.5d), new Complex(4.5d, 5d));
            var v = ov.swizzle.xywx;
            Assert.That(new Complex(1.0, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, 8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, 5d), new Complex(9d, 5.5d), new Complex(0.0, -1.5d), new Complex(4d, -6.5d));
            var v = ov.swizzle.xywy;
            Assert.That(new Complex(2.5d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, -2d), new Complex(-8.5d, -2.5d), new Complex(1.5d, -6d), new Complex(6.5d, 9d));
            var v = ov.swizzle.xywz;
            Assert.That(new Complex(-2d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.5d, -6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3d, 4.5d), new Complex(0.5d, 2.5d), new Complex(-3d, -4.5d), new Complex(-7.5d, 0.0));
            var v = ov.swizzle.xyww;
            Assert.That(new Complex(3d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, -5.5d), new Complex(5.5d, -1d), new Complex(0.5d, 8d), new Complex(-7d, -3.5d));
            var v = ov.swizzle.xz;
            Assert.That(new Complex(-1.5d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 8d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(1.0, 2.5d), new Complex(-1.5d, 7d), new Complex(3.5d, 7d), new Complex(7d, 6.5d));
            var v = ov.swizzle.xzx;
            Assert.That(new Complex(1.0, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 2.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(4d, -3.5d), new Complex(2.5d, 3.5d), new Complex(-7d, 4d), new Complex(-7.5d, -5.5d));
            var v = ov.swizzle.xzxx;
            Assert.That(new Complex(4d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5.5d, 3d), new Complex(9.5d, 5.5d), new Complex(-8.5d, -8d), new Complex(9d, -3.5d));
            var v = ov.swizzle.xzxy;
            Assert.That(new Complex(5.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, -4.5d), new Complex(4.5d, 6.5d), new Complex(9d, 5.5d), new Complex(7.5d, -4d));
            var v = ov.swizzle.xzxz;
            Assert.That(new Complex(1.5d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, 1.0), new Complex(-1d, 8.5d), new Complex(-7d, -1d), new Complex(-0.5d, 2d));
            var v = ov.swizzle.xzxw;
            Assert.That(new Complex(-5d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, 1.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, 2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, -4.5d), new Complex(-7d, -9.5d), new Complex(-1.5d, 1.5d), new Complex(9d, 2.5d));
            var v = ov.swizzle.xzy;
            Assert.That(new Complex(-5d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, -9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, 1.5d), new Complex(-2d, -2d), new Complex(-4d, 1.5d), new Complex(-5d, 6.5d));
            var v = ov.swizzle.xzyx;
            Assert.That(new Complex(-1.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, 4.5d), new Complex(3d, -8.5d), new Complex(2.5d, 9d), new Complex(1.0, -6.5d));
            var v = ov.swizzle.xzyy;
            Assert.That(new Complex(-5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4d, 4.5d), new Complex(9d, -9.5d), new Complex(-3d, -5.5d), new Complex(-4d, 1.0));
            var v = ov.swizzle.xzyz;
            Assert.That(new Complex(-4d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, -1.5d), new Complex(-9.5d, -6.5d), new Complex(-0.5d, -8d), new Complex(9.5d, -3d));
            var v = ov.swizzle.xzyw;
            Assert.That(new Complex(-3.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3.5d, 0.5d), new Complex(-9d, 3d), new Complex(9d, -9.5d), new Complex(-2d, -6d));
            var v = ov.swizzle.xzz;
            Assert.That(new Complex(3.5d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, -9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(0.0, 7d), new Complex(-8.5d, -2.5d), new Complex(4d, -7.5d), new Complex(8d, 7.5d));
            var v = ov.swizzle.xzzx;
            Assert.That(new Complex(0.0, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, 7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, 4.5d), new Complex(-6d, -2d), new Complex(6d, 6.5d), new Complex(-7d, -5.5d));
            var v = ov.swizzle.xzzy;
            Assert.That(new Complex(-9.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, 8.5d), new Complex(1.0, 3d), new Complex(1.0, 9.5d), new Complex(-4.5d, -2d));
            var v = ov.swizzle.xzzz;
            Assert.That(new Complex(-8d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, -7d), new Complex(-6.5d, -4d), new Complex(-9.5d, 5d), new Complex(3.5d, -4d));
            var v = ov.swizzle.xzzw;
            Assert.That(new Complex(9.5d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, 9.5d), new Complex(1.0, 6d), new Complex(6d, -1.5d), new Complex(1.5d, -9.5d));
            var v = ov.swizzle.xzw;
            Assert.That(new Complex(-8d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, -9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(7d, -6.5d), new Complex(-9d, 3.5d), new Complex(5.5d, 1.5d), new Complex(-7.5d, 3d));
            var v = ov.swizzle.xzwx;
            Assert.That(new Complex(7d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7.5d, 9d), new Complex(6.5d, 4.5d), new Complex(-1d, -5.5d), new Complex(4.5d, -9d));
            var v = ov.swizzle.xzwy;
            Assert.That(new Complex(-7.5d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -9d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7.5d, -9.5d), new Complex(-7d, 7.5d), new Complex(5.5d, -2d), new Complex(6.5d, -8.5d));
            var v = ov.swizzle.xzwz;
            Assert.That(new Complex(-7.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 8.5d), new Complex(-7d, -3d), new Complex(9d, -7.5d), new Complex(7d, 1.0));
            var v = ov.swizzle.xzww;
            Assert.That(new Complex(6d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, 1.0), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, 1.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, -2.5d), new Complex(4d, 1.5d), new Complex(5.5d, 1.0), new Complex(9.5d, -7.5d));
            var v = ov.swizzle.xw;
            Assert.That(new Complex(6d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, -7.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(6.5d, -5.5d), new Complex(-5d, -5.5d), new Complex(-6.5d, -5.5d), new Complex(-3d, -1.5d));
            var v = ov.swizzle.xwx;
            Assert.That(new Complex(6.5d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, -5.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(7d, -9d), new Complex(-1.5d, -3d), new Complex(-4d, -4.5d), new Complex(3d, -2d));
            var v = ov.swizzle.xwxx;
            Assert.That(new Complex(7d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -9d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, -9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.0, -5d), new Complex(6.5d, 4d), new Complex(-8.5d, -1d), new Complex(2.5d, -8.5d));
            var v = ov.swizzle.xwxy;
            Assert.That(new Complex(0.0, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, -5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, -3d), new Complex(-8d, 9.5d), new Complex(3d, 1.5d), new Complex(-8.5d, -5d));
            var v = ov.swizzle.xwxz;
            Assert.That(new Complex(-2d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4.5d, 5.5d), new Complex(-6.5d, -9d), new Complex(-2.5d, -1.5d), new Complex(-5.5d, 0.0));
            var v = ov.swizzle.xwxw;
            Assert.That(new Complex(-4.5d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, -3.5d), new Complex(-3d, -8d), new Complex(5.5d, 3d), new Complex(0.0, 8.5d));
            var v = ov.swizzle.xwy;
            Assert.That(new Complex(4d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, -8d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(5d, 1.5d), new Complex(5d, -8d), new Complex(-8d, -1d), new Complex(-6.5d, 2d));
            var v = ov.swizzle.xwyx;
            Assert.That(new Complex(5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3d, -0.5d), new Complex(-3d, 1.0), new Complex(-3.5d, -4.5d), new Complex(-4d, 5d));
            var v = ov.swizzle.xwyy;
            Assert.That(new Complex(-3d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, 1.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, 1.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 5d), new Complex(7d, 5d), new Complex(4.5d, 5.5d), new Complex(2.5d, 9.5d));
            var v = ov.swizzle.xwyz;
            Assert.That(new Complex(6d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, 8d), new Complex(-6.5d, 0.0), new Complex(-4d, -7.5d), new Complex(3.5d, 7.5d));
            var v = ov.swizzle.xwyw;
            Assert.That(new Complex(6.5d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, 7d), new Complex(7d, 9d), new Complex(4.5d, 1.0), new Complex(-3.5d, -6d));
            var v = ov.swizzle.xwz;
            Assert.That(new Complex(-6.5d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, -6d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, 1.0), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(6.5d, -3.5d), new Complex(2d, -0.5d), new Complex(-4.5d, 6d), new Complex(-1.5d, 9.5d));
            var v = ov.swizzle.xwzx;
            Assert.That(new Complex(6.5d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3d, -9d), new Complex(-0.5d, 6d), new Complex(-7.5d, 5d), new Complex(-5.5d, 7d));
            var v = ov.swizzle.xwzy;
            Assert.That(new Complex(-3d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, 3d), new Complex(-1d, 8.5d), new Complex(4.5d, 4.5d), new Complex(-5.5d, 4d));
            var v = ov.swizzle.xwzz;
            Assert.That(new Complex(-8d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, -9.5d), new Complex(-7.5d, -5.5d), new Complex(6d, 5.5d), new Complex(1.0, 8.5d));
            var v = ov.swizzle.xwzw;
            Assert.That(new Complex(-9.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9d, 9.5d), new Complex(1.5d, -7.5d), new Complex(0.5d, -6.5d), new Complex(-1.5d, -3d));
            var v = ov.swizzle.xww;
            Assert.That(new Complex(9d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, -3d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(9d, -7d), new Complex(7d, 3d), new Complex(-3.5d, -4d), new Complex(4d, 4d));
            var v = ov.swizzle.xwwx;
            Assert.That(new Complex(9d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, 3d), new Complex(-1d, 1.5d), new Complex(-4.5d, 6d), new Complex(2d, 2.5d));
            var v = ov.swizzle.xwwy;
            Assert.That(new Complex(-5.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8d, 5.5d), new Complex(3.5d, 0.5d), new Complex(0.0, 1.5d), new Complex(7.5d, -7d));
            var v = ov.swizzle.xwwz;
            Assert.That(new Complex(8d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9d, -6d), new Complex(8d, -3.5d), new Complex(4d, -2d), new Complex(3d, 0.0));
            var v = ov.swizzle.xwww;
            Assert.That(new Complex(-9d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, -2d), new Complex(-0.5d, -2d), new Complex(9d, -8.5d), new Complex(-5.5d, -7.5d));
            var v = ov.swizzle.yx;
            Assert.That(new Complex(-0.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, -2d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(0.5d, 6.5d), new Complex(2d, -5d), new Complex(6.5d, 2d), new Complex(5.5d, 6d));
            var v = ov.swizzle.yxx;
            Assert.That(new Complex(2d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, 6.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-3d, -2d), new Complex(-1d, -0.5d), new Complex(-3d, -8d), new Complex(-4d, -6.5d));
            var v = ov.swizzle.yxxx;
            Assert.That(new Complex(-1d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6d, 3d), new Complex(-2d, -8.5d), new Complex(-6.5d, 6.5d), new Complex(1.5d, -4.5d));
            var v = ov.swizzle.yxxy;
            Assert.That(new Complex(-2d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, -3.5d), new Complex(5d, -3.5d), new Complex(-6d, 6.5d), new Complex(-0.5d, -8.5d));
            var v = ov.swizzle.yxxz;
            Assert.That(new Complex(5d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, 6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, -5d), new Complex(-9.5d, 9.5d), new Complex(4d, 3.5d), new Complex(1.0, -3.5d));
            var v = ov.swizzle.yxxw;
            Assert.That(new Complex(-9.5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, -5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3d, 8.5d), new Complex(-9d, -1d), new Complex(-5d, -1d), new Complex(-5.5d, -3d));
            var v = ov.swizzle.yxy;
            Assert.That(new Complex(-9d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, -1d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-1d, 5d), new Complex(7.5d, -8d), new Complex(4d, -3.5d), new Complex(-1d, 2.5d));
            var v = ov.swizzle.yxyx;
            Assert.That(new Complex(7.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, 9d), new Complex(3d, 2.5d), new Complex(-8.5d, -2.5d), new Complex(-8.5d, -2.5d));
            var v = ov.swizzle.yxyy;
            Assert.That(new Complex(3d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, 9.5d), new Complex(5d, 8.5d), new Complex(7.5d, -7d), new Complex(7d, 0.0));
            var v = ov.swizzle.yxyz;
            Assert.That(new Complex(5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, 1.0), new Complex(1.5d, 6d), new Complex(1.5d, 3.5d), new Complex(-3d, -3d));
            var v = ov.swizzle.yxyw;
            Assert.That(new Complex(1.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8.5d, -4d), new Complex(-1d, -7.5d), new Complex(-2.5d, -0.5d), new Complex(7.5d, -4d));
            var v = ov.swizzle.yxz;
            Assert.That(new Complex(-1d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, -0.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(9d, 2.5d), new Complex(9d, 5d), new Complex(-9.5d, -1.5d), new Complex(-3d, -2.5d));
            var v = ov.swizzle.yxzx;
            Assert.That(new Complex(9d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, -0.5d), new Complex(-5d, 1.5d), new Complex(-3.5d, -3.5d), new Complex(0.0, 9d));
            var v = ov.swizzle.yxzy;
            Assert.That(new Complex(-5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, -7d), new Complex(7d, 2.5d), new Complex(-9.5d, -7.5d), new Complex(-2d, -6.5d));
            var v = ov.swizzle.yxzz;
            Assert.That(new Complex(7d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, 4d), new Complex(-2d, -2.5d), new Complex(-5.5d, 8.5d), new Complex(-5d, 3.5d));
            var v = ov.swizzle.yxzw;
            Assert.That(new Complex(-2d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 1.0), new Complex(1.0, -6.5d), new Complex(6.5d, -3d), new Complex(-2d, 9d));
            var v = ov.swizzle.yxw;
            Assert.That(new Complex(1.0, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, 9d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(0.5d, 4.5d), new Complex(2d, 6d), new Complex(9d, -6.5d), new Complex(-1d, -3.5d));
            var v = ov.swizzle.yxwx;
            Assert.That(new Complex(2d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8d, 8d), new Complex(8d, 4.5d), new Complex(-8d, -7d), new Complex(-3.5d, 7d));
            var v = ov.swizzle.yxwy;
            Assert.That(new Complex(8d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(8d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, 6d), new Complex(2.5d, -8.5d), new Complex(3d, -3d), new Complex(3.5d, -6d));
            var v = ov.swizzle.yxwz;
            Assert.That(new Complex(2.5d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, -7.5d), new Complex(-7d, 6.5d), new Complex(-4d, -9d), new Complex(0.0, 8.5d));
            var v = ov.swizzle.yxww;
            Assert.That(new Complex(-7d, 6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, -1.5d), new Complex(1.5d, 8.5d), new Complex(-9d, 2d), new Complex(2d, -7d));
            var v = ov.swizzle.yy;
            Assert.That(new Complex(1.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 8.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(-8d, 6d), new Complex(-8.5d, -5d), new Complex(7.5d, -1d), new Complex(-4d, 4d));
            var v = ov.swizzle.yyx;
            Assert.That(new Complex(-8.5d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, 6d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, -7d), new Complex(-4.5d, 2.5d), new Complex(-9d, 5.5d), new Complex(9.5d, -5d));
            var v = ov.swizzle.yyxx;
            Assert.That(new Complex(-4.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3.5d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 5d), new Complex(-6d, 7.5d), new Complex(6d, 9d), new Complex(6.5d, -1.5d));
            var v = ov.swizzle.yyxy;
            Assert.That(new Complex(-6d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, 8d), new Complex(-6d, -7d), new Complex(6d, -8d), new Complex(7d, -6.5d));
            var v = ov.swizzle.yyxz;
            Assert.That(new Complex(-6d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, -7.5d), new Complex(8d, 9.5d), new Complex(4d, -6d), new Complex(-6.5d, 2.5d));
            var v = ov.swizzle.yyxw;
            Assert.That(new Complex(8d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7.5d, -4d), new Complex(0.0, -6d), new Complex(-2d, 3d), new Complex(1.5d, 5.5d));
            var v = ov.swizzle.yyy;
            Assert.That(new Complex(0.0, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, -6d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, -6d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(4d, -8d), new Complex(-2.5d, 5d), new Complex(-8.5d, 0.0), new Complex(-1d, 5d));
            var v = ov.swizzle.yyyx;
            Assert.That(new Complex(-2.5d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8.5d, 8d), new Complex(-6.5d, 8.5d), new Complex(8.5d, 5d), new Complex(-5d, 2d));
            var v = ov.swizzle.yyyy;
            Assert.That(new Complex(-6.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6.5d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, -9.5d), new Complex(3.5d, 4.5d), new Complex(4.5d, 3d), new Complex(9d, -7d));
            var v = ov.swizzle.yyyz;
            Assert.That(new Complex(3.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, 3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, 6.5d), new Complex(6.5d, -9d), new Complex(-4.5d, 9d), new Complex(-6.5d, -7d));
            var v = ov.swizzle.yyyw;
            Assert.That(new Complex(6.5d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, -9d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6.5d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, 9.5d), new Complex(-9d, 2d), new Complex(-9.5d, 0.0), new Complex(-3d, 6d));
            var v = ov.swizzle.yyz;
            Assert.That(new Complex(-9d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, 0.0), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, 9d), new Complex(6d, -5.5d), new Complex(-9d, 5d), new Complex(-6d, 2d));
            var v = ov.swizzle.yyzx;
            Assert.That(new Complex(6d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3.5d, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1d, -7d), new Complex(5d, 3.5d), new Complex(1.0, -6d), new Complex(7d, -3.5d));
            var v = ov.swizzle.yyzy;
            Assert.That(new Complex(5d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2.5d, -9.5d), new Complex(5.5d, -1d), new Complex(5d, 2d), new Complex(-7d, -1.5d));
            var v = ov.swizzle.yyzz;
            Assert.That(new Complex(5.5d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 2d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9d, 8d), new Complex(5d, -3d), new Complex(8d, -5.5d), new Complex(9.5d, -1d));
            var v = ov.swizzle.yyzw;
            Assert.That(new Complex(5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, -5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -1d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, 0.5d), new Complex(8d, -1.5d), new Complex(1.0, 3d), new Complex(-6.5d, 7d));
            var v = ov.swizzle.yyw;
            Assert.That(new Complex(8d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 7d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-8d, 1.5d), new Complex(2.5d, 6d), new Complex(-4d, 5d), new Complex(-8.5d, -4d));
            var v = ov.swizzle.yywx;
            Assert.That(new Complex(2.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, -4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7.5d, -4d), new Complex(7.5d, 0.0), new Complex(2d, -4.5d), new Complex(3d, 1.0));
            var v = ov.swizzle.yywy;
            Assert.That(new Complex(7.5d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, 1.0), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, 0.5d), new Complex(-8.5d, 9.5d), new Complex(3.5d, 3.5d), new Complex(-9d, 8d));
            var v = ov.swizzle.yywz;
            Assert.That(new Complex(-8.5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, -6d), new Complex(8.5d, 6.5d), new Complex(5d, -5.5d), new Complex(7.5d, 4.5d));
            var v = ov.swizzle.yyww;
            Assert.That(new Complex(8.5d, 6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7d, 8.5d), new Complex(4d, 5.5d), new Complex(9.5d, -1.5d), new Complex(2.5d, -3d));
            var v = ov.swizzle.yz;
            Assert.That(new Complex(4d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, -1.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(-7.5d, -8.5d), new Complex(0.5d, -8d), new Complex(-2.5d, -7.5d), new Complex(-1.5d, 9d));
            var v = ov.swizzle.yzx;
            Assert.That(new Complex(0.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, -8.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, 0.5d), new Complex(-7d, -3d), new Complex(0.0, 5d), new Complex(9.5d, -6.5d));
            var v = ov.swizzle.yzxx;
            Assert.That(new Complex(-7d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, 0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2.5d, 2.5d), new Complex(-4.5d, 8.5d), new Complex(-8d, -4.5d), new Complex(-8.5d, 8d));
            var v = ov.swizzle.yzxy;
            Assert.That(new Complex(-4.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4.5d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, 7.5d), new Complex(6.5d, 2.5d), new Complex(4.5d, -5d), new Complex(4.5d, 2d));
            var v = ov.swizzle.yzxz;
            Assert.That(new Complex(6.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, -5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3.5d, -8d), new Complex(7.5d, 1.5d), new Complex(3.5d, -0.5d), new Complex(-4d, -7d));
            var v = ov.swizzle.yzxw;
            Assert.That(new Complex(7.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3d, 6d), new Complex(8.5d, -5d), new Complex(-6.5d, 5.5d), new Complex(5d, -8d));
            var v = ov.swizzle.yzy;
            Assert.That(new Complex(8.5d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(1.0, -5d), new Complex(-3.5d, 4.5d), new Complex(6.5d, -3d), new Complex(-1d, -3d));
            var v = ov.swizzle.yzyx;
            Assert.That(new Complex(-3.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, -5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, -0.5d), new Complex(-1d, 0.5d), new Complex(1.5d, -1d), new Complex(9.5d, 4.5d));
            var v = ov.swizzle.yzyy;
            Assert.That(new Complex(-1d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, 0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8d, 9.5d), new Complex(8d, 0.5d), new Complex(0.0, -5.5d), new Complex(-1.5d, -4d));
            var v = ov.swizzle.yzyz;
            Assert.That(new Complex(8d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, 0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, -7.5d), new Complex(-4.5d, 6.5d), new Complex(2.5d, -5.5d), new Complex(4d, 9.5d));
            var v = ov.swizzle.yzyw;
            Assert.That(new Complex(-4.5d, 6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, 2.5d), new Complex(3d, 1.0), new Complex(-6d, 8d), new Complex(8.5d, 1.5d));
            var v = ov.swizzle.yzz;
            Assert.That(new Complex(3d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, 8d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(3d, -3d), new Complex(-3d, -7.5d), new Complex(1.0, 9d), new Complex(-5.5d, -6.5d));
            var v = ov.swizzle.yzzx;
            Assert.That(new Complex(-3d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, -9d), new Complex(-2d, -8.5d), new Complex(4d, -5d), new Complex(-1d, 6d));
            var v = ov.swizzle.yzzy;
            Assert.That(new Complex(-2d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, -5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, 6d), new Complex(-3.5d, 9d), new Complex(-0.5d, 4d), new Complex(-5.5d, 6d));
            var v = ov.swizzle.yzzz;
            Assert.That(new Complex(-3.5d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, -9.5d), new Complex(-7.5d, 2d), new Complex(-3.5d, 3.5d), new Complex(1.0, 4.5d));
            var v = ov.swizzle.yzzw;
            Assert.That(new Complex(-7.5d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, 9.5d), new Complex(-0.5d, 3.5d), new Complex(9.5d, 4.5d), new Complex(-7d, 0.0));
            var v = ov.swizzle.yzw;
            Assert.That(new Complex(-0.5d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, 0.0), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(4.5d, -1.5d), new Complex(-8d, 0.5d), new Complex(-2d, 7d), new Complex(8d, 4d));
            var v = ov.swizzle.yzwx;
            Assert.That(new Complex(-8d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, 6d), new Complex(5d, 9.5d), new Complex(-0.5d, -9d), new Complex(7d, -9.5d));
            var v = ov.swizzle.yzwy;
            Assert.That(new Complex(5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5d, 4d), new Complex(-1.5d, -2.5d), new Complex(-7d, -5.5d), new Complex(0.0, 3d));
            var v = ov.swizzle.yzwz;
            Assert.That(new Complex(-1.5d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, 3d), new Complex(-4.5d, 3d), new Complex(2d, 3d), new Complex(-1.5d, 2.5d));
            var v = ov.swizzle.yzww;
            Assert.That(new Complex(-4.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4.5d, -7.5d), new Complex(-2d, -1.5d), new Complex(5d, 1.5d), new Complex(-1.5d, 6d));
            var v = ov.swizzle.yw;
            Assert.That(new Complex(-2d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, 6d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(6d, -3d), new Complex(-8.5d, 1.0), new Complex(-1.5d, -3.5d), new Complex(-6.5d, -0.5d));
            var v = ov.swizzle.ywx;
            Assert.That(new Complex(-8.5d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, -3d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, -3.5d), new Complex(-7d, -8d), new Complex(-8.5d, 1.5d), new Complex(-6.5d, -9.5d));
            var v = ov.swizzle.ywxx;
            Assert.That(new Complex(-7d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, 2d), new Complex(0.5d, -1.5d), new Complex(-5.5d, 9.5d), new Complex(6d, 7.5d));
            var v = ov.swizzle.ywxy;
            Assert.That(new Complex(0.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, 2d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3d, 7d), new Complex(9.5d, 8d), new Complex(4d, 1.0), new Complex(-4.5d, -6.5d));
            var v = ov.swizzle.ywxz;
            Assert.That(new Complex(9.5d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, 1.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.0, -3d), new Complex(3.5d, 4d), new Complex(-1.5d, -7d), new Complex(8.5d, -9.5d));
            var v = ov.swizzle.ywxw;
            Assert.That(new Complex(3.5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, 1.0), new Complex(6.5d, 5.5d), new Complex(4d, 9.5d), new Complex(-6.5d, -9d));
            var v = ov.swizzle.ywy;
            Assert.That(new Complex(6.5d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 5.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(8d, -5.5d), new Complex(-1.5d, 9.5d), new Complex(1.0, 1.0), new Complex(-7.5d, -6d));
            var v = ov.swizzle.ywyx;
            Assert.That(new Complex(-1.5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, -6d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(8d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9d, 6.5d), new Complex(8.5d, 0.0), new Complex(-7d, -2d), new Complex(8d, 9d));
            var v = ov.swizzle.ywyy;
            Assert.That(new Complex(8.5d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, 0.0), new Complex(-2d, -4.5d), new Complex(9d, -4.5d), new Complex(-4d, -5.5d));
            var v = ov.swizzle.ywyz;
            Assert.That(new Complex(-2d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, 4d), new Complex(-1.5d, -8d), new Complex(-1.5d, -9d), new Complex(-9d, -3.5d));
            var v = ov.swizzle.ywyw;
            Assert.That(new Complex(-1.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4.5d, 7d), new Complex(5d, 6.5d), new Complex(8d, -7d), new Complex(-5d, -7d));
            var v = ov.swizzle.ywz;
            Assert.That(new Complex(5d, 6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, -7d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(3d, -3.5d), new Complex(9d, -5.5d), new Complex(6.5d, 5.5d), new Complex(-6.5d, 4.5d));
            var v = ov.swizzle.ywzx;
            Assert.That(new Complex(9d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, 9.5d), new Complex(-7d, -9.5d), new Complex(-2.5d, -8d), new Complex(2.5d, -7d));
            var v = ov.swizzle.ywzy;
            Assert.That(new Complex(-7d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, -2d), new Complex(7d, -1d), new Complex(5d, 2d), new Complex(9d, -8d));
            var v = ov.swizzle.ywzz;
            Assert.That(new Complex(7d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 2d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6d, 0.0), new Complex(5d, 4d), new Complex(-5d, 3d), new Complex(1.5d, -3.5d));
            var v = ov.swizzle.ywzw;
            Assert.That(new Complex(5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.5d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6d, -5d), new Complex(9.5d, -5d), new Complex(3d, -8.5d), new Complex(1.0, 0.0));
            var v = ov.swizzle.yww;
            Assert.That(new Complex(9.5d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 0.0), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-4d, -5d), new Complex(-6d, -1.5d), new Complex(-6.5d, 6.5d), new Complex(1.5d, -7.5d));
            var v = ov.swizzle.ywwx;
            Assert.That(new Complex(-6d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, -5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, -7.5d), new Complex(0.5d, -8d), new Complex(5.5d, -8d), new Complex(-3d, 4.5d));
            var v = ov.swizzle.ywwy;
            Assert.That(new Complex(0.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, -5.5d), new Complex(8d, -1.5d), new Complex(-4d, 9d), new Complex(-7d, 3d));
            var v = ov.swizzle.ywwz;
            Assert.That(new Complex(8d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, -7d), new Complex(0.5d, -6.5d), new Complex(-9d, 1.5d), new Complex(8.5d, 9.5d));
            var v = ov.swizzle.ywww;
            Assert.That(new Complex(0.5d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, 3d), new Complex(-8d, 6d), new Complex(1.0, -4d), new Complex(2d, -5d));
            var v = ov.swizzle.zx;
            Assert.That(new Complex(1.0, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 3d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(-1d, -8.5d), new Complex(-5.5d, 4.5d), new Complex(-5.5d, 8.5d), new Complex(-6d, -2.5d));
            var v = ov.swizzle.zxx;
            Assert.That(new Complex(-5.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, -8.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(6d, -8.5d), new Complex(0.0, 4d), new Complex(8.5d, -6.5d), new Complex(-5.5d, 7.5d));
            var v = ov.swizzle.zxxx;
            Assert.That(new Complex(8.5d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4d, -2d), new Complex(6.5d, 3.5d), new Complex(3d, 9d), new Complex(-4.5d, 2.5d));
            var v = ov.swizzle.zxxy;
            Assert.That(new Complex(3d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2d, -4d), new Complex(7d, -4d), new Complex(0.0, 9.5d), new Complex(-2.5d, 7.5d));
            var v = ov.swizzle.zxxz;
            Assert.That(new Complex(0.0, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -4d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, -2.5d), new Complex(5d, -2d), new Complex(4.5d, -3d), new Complex(0.5d, -7.5d));
            var v = ov.swizzle.zxxw;
            Assert.That(new Complex(4.5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7.5d, 2d), new Complex(-4d, -8.5d), new Complex(-2.5d, 1.5d), new Complex(-5d, -8.5d));
            var v = ov.swizzle.zxy;
            Assert.That(new Complex(-2.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -8.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(4.5d, 0.0), new Complex(-1.5d, 9.5d), new Complex(-7.5d, 1.0), new Complex(-4.5d, -8d));
            var v = ov.swizzle.zxyx;
            Assert.That(new Complex(-7.5d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, -4d), new Complex(-6d, 4d), new Complex(9.5d, -7.5d), new Complex(8.5d, 8d));
            var v = ov.swizzle.zxyy;
            Assert.That(new Complex(9.5d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7.5d, 8.5d), new Complex(1.0, 4d), new Complex(0.5d, -9.5d), new Complex(-0.5d, -9.5d));
            var v = ov.swizzle.zxyz;
            Assert.That(new Complex(0.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, 0.5d), new Complex(7d, 7d), new Complex(-5.5d, 9.5d), new Complex(-0.5d, -5d));
            var v = ov.swizzle.zxyw;
            Assert.That(new Complex(-5.5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, -5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, 4.5d), new Complex(-1d, -8d), new Complex(9.5d, -7.5d), new Complex(7d, 1.5d));
            var v = ov.swizzle.zxz;
            Assert.That(new Complex(9.5d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, -7.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(5d, -7d), new Complex(-1.5d, -8d), new Complex(-4d, -2.5d), new Complex(-8.5d, 0.0));
            var v = ov.swizzle.zxzx;
            Assert.That(new Complex(-4d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, -8.5d), new Complex(1.5d, 3.5d), new Complex(-3d, 9d), new Complex(-3.5d, 0.5d));
            var v = ov.swizzle.zxzy;
            Assert.That(new Complex(-3d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.5d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, 3.5d), new Complex(-1d, 2.5d), new Complex(-8.5d, -2d), new Complex(6.5d, 9.5d));
            var v = ov.swizzle.zxzz;
            Assert.That(new Complex(-8.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7.5d, 3d), new Complex(9d, -5d), new Complex(-7.5d, -2.5d), new Complex(-8d, -8.5d));
            var v = ov.swizzle.zxzw;
            Assert.That(new Complex(-7.5d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9d, 2d), new Complex(-4d, 3d), new Complex(8.5d, -5.5d), new Complex(8.5d, 7d));
            var v = ov.swizzle.zxw;
            Assert.That(new Complex(8.5d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 7d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(7.5d, -1d), new Complex(5d, 0.0), new Complex(-2.5d, 3.5d), new Complex(1.0, 6d));
            var v = ov.swizzle.zxwx;
            Assert.That(new Complex(-2.5d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, -1d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, 4.5d), new Complex(-2d, -9.5d), new Complex(6.5d, 7d), new Complex(-9d, -8d));
            var v = ov.swizzle.zxwy;
            Assert.That(new Complex(6.5d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, -3d), new Complex(4d, 5.5d), new Complex(8.5d, -1.5d), new Complex(-1d, -7.5d));
            var v = ov.swizzle.zxwz;
            Assert.That(new Complex(8.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4d, 9.5d), new Complex(-9d, 7.5d), new Complex(9d, 1.0), new Complex(5d, -8.5d));
            var v = ov.swizzle.zxww;
            Assert.That(new Complex(9d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, 9d), new Complex(0.0, 9.5d), new Complex(5.5d, 6.5d), new Complex(4.5d, -9.5d));
            var v = ov.swizzle.zy;
            Assert.That(new Complex(5.5d, 6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, 9.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(2d, 2.5d), new Complex(-3d, -0.5d), new Complex(-5d, -3d), new Complex(-2.5d, 4d));
            var v = ov.swizzle.zyx;
            Assert.That(new Complex(-5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, 2.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, 2.5d), new Complex(3.5d, -9.5d), new Complex(2.5d, -6d), new Complex(-7.5d, -3d));
            var v = ov.swizzle.zyxx;
            Assert.That(new Complex(2.5d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4.5d, -9.5d), new Complex(6d, -6d), new Complex(-1d, -1d), new Complex(-8d, -1.5d));
            var v = ov.swizzle.zyxy;
            Assert.That(new Complex(-1d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, -6d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, -6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, 3.5d), new Complex(1.0, -3d), new Complex(-1d, -9.5d), new Complex(0.0, -4d));
            var v = ov.swizzle.zyxz;
            Assert.That(new Complex(-1d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.0, -7.5d), new Complex(-3d, -8d), new Complex(3d, 3d), new Complex(-7d, 8.5d));
            var v = ov.swizzle.zyxw;
            Assert.That(new Complex(3d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5.5d, -3.5d), new Complex(3.5d, 1.5d), new Complex(5d, -6d), new Complex(-8d, 6.5d));
            var v = ov.swizzle.zyy;
            Assert.That(new Complex(5d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, 1.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-3d, 3d), new Complex(9d, -1.5d), new Complex(-7.5d, 8.5d), new Complex(-8d, 4d));
            var v = ov.swizzle.zyyx;
            Assert.That(new Complex(-7.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, 3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.0, -2d), new Complex(-7d, 3d), new Complex(3d, 8d), new Complex(-8d, 1.0));
            var v = ov.swizzle.zyyy;
            Assert.That(new Complex(3d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, 3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, 7d), new Complex(4d, 2d), new Complex(5.5d, -3d), new Complex(-5.5d, -9d));
            var v = ov.swizzle.zyyz;
            Assert.That(new Complex(5.5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, 2d), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, -1.5d), new Complex(0.0, -2.5d), new Complex(-8.5d, -5d), new Complex(-5.5d, -4d));
            var v = ov.swizzle.zyyw;
            Assert.That(new Complex(-8.5d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, 4d), new Complex(-4d, 2.5d), new Complex(3.5d, 7.5d), new Complex(-4d, 4.5d));
            var v = ov.swizzle.zyz;
            Assert.That(new Complex(3.5d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, 7.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(4.5d, -4.5d), new Complex(-9.5d, 7.5d), new Complex(8.5d, -1.5d), new Complex(-3d, -5.5d));
            var v = ov.swizzle.zyzx;
            Assert.That(new Complex(8.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8d, -6d), new Complex(8d, -4.5d), new Complex(4d, 7.5d), new Complex(1.0, -0.5d));
            var v = ov.swizzle.zyzy;
            Assert.That(new Complex(4d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(8d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7.5d, 5.5d), new Complex(-8d, 5.5d), new Complex(8.5d, 4.5d), new Complex(9d, 1.0));
            var v = ov.swizzle.zyzz;
            Assert.That(new Complex(8.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7d, -2d), new Complex(6.5d, -7d), new Complex(-4d, 8.5d), new Complex(-1d, 2d));
            var v = ov.swizzle.zyzw;
            Assert.That(new Complex(-4d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1d, -9.5d), new Complex(-5d, 9d), new Complex(-8.5d, 9.5d), new Complex(8d, -5d));
            var v = ov.swizzle.zyw;
            Assert.That(new Complex(-8.5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, -5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(3d, 4d), new Complex(3.5d, 8d), new Complex(0.0, -9d), new Complex(7d, -0.5d));
            var v = ov.swizzle.zywx;
            Assert.That(new Complex(0.0, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 0.0), new Complex(-2.5d, 1.0), new Complex(9d, -3.5d), new Complex(9.5d, 4.5d));
            var v = ov.swizzle.zywy;
            Assert.That(new Complex(9d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, 1.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, 3d), new Complex(-9d, -0.5d), new Complex(7.5d, 4.5d), new Complex(-8.5d, 1.5d));
            var v = ov.swizzle.zywz;
            Assert.That(new Complex(7.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, 3.5d), new Complex(1.5d, -7.5d), new Complex(-5.5d, -1d), new Complex(2.5d, 5d));
            var v = ov.swizzle.zyww;
            Assert.That(new Complex(-5.5d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, 5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, 0.0), new Complex(9d, -2d), new Complex(8d, -3.5d), new Complex(1.5d, -3.5d));
            var v = ov.swizzle.zz;
            Assert.That(new Complex(8d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, -3.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(-2d, 3d), new Complex(1.0, -8d), new Complex(-9.5d, 5d), new Complex(9.5d, -2d));
            var v = ov.swizzle.zzx;
            Assert.That(new Complex(-9.5d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, 3d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(5d, 7d), new Complex(-3.5d, 9d), new Complex(-7d, 5d), new Complex(4.5d, -2d));
            var v = ov.swizzle.zzxx;
            Assert.That(new Complex(-7d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, -1.5d), new Complex(-1d, -1d), new Complex(-3d, 2.5d), new Complex(4d, 2.5d));
            var v = ov.swizzle.zzxy;
            Assert.That(new Complex(-3d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -1d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, 2.5d), new Complex(-4.5d, -8.5d), new Complex(-1d, -2.5d), new Complex(1.0, -4d));
            var v = ov.swizzle.zzxz;
            Assert.That(new Complex(-1d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, -7d), new Complex(0.5d, 6.5d), new Complex(6d, -7.5d), new Complex(-7.5d, -4d));
            var v = ov.swizzle.zzxw;
            Assert.That(new Complex(6d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8.5d, 9.5d), new Complex(5d, 2d), new Complex(9d, -3.5d), new Complex(-9d, 3d));
            var v = ov.swizzle.zzy;
            Assert.That(new Complex(9d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 2d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, 0.0), new Complex(-8d, 0.0), new Complex(9d, 7d), new Complex(-6d, 0.5d));
            var v = ov.swizzle.zzyx;
            Assert.That(new Complex(9d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3d, 3d), new Complex(-7.5d, 2.5d), new Complex(9.5d, 1.0), new Complex(1.0, 5d));
            var v = ov.swizzle.zzyy;
            Assert.That(new Complex(9.5d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5d, -8.5d), new Complex(0.5d, -4d), new Complex(7.5d, -2d), new Complex(1.0, -4.5d));
            var v = ov.swizzle.zzyz;
            Assert.That(new Complex(7.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, -4d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4d, 1.0), new Complex(1.0, 6d), new Complex(2d, -9d), new Complex(-9.5d, 0.5d));
            var v = ov.swizzle.zzyw;
            Assert.That(new Complex(2d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9d, 3.5d), new Complex(-6d, -4d), new Complex(-4d, 4d), new Complex(-8.5d, 1.5d));
            var v = ov.swizzle.zzz;
            Assert.That(new Complex(-4d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, 4d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(5d, 5.5d), new Complex(3.5d, 0.0), new Complex(-1.5d, 8.5d), new Complex(-5d, -1d));
            var v = ov.swizzle.zzzx;
            Assert.That(new Complex(-1.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, 2.5d), new Complex(-7.5d, 4.5d), new Complex(-2d, -2.5d), new Complex(-8.5d, 3d));
            var v = ov.swizzle.zzzy;
            Assert.That(new Complex(-2d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2d, -1.5d), new Complex(-2.5d, -2d), new Complex(2.5d, -3.5d), new Complex(5d, 8.5d));
            var v = ov.swizzle.zzzz;
            Assert.That(new Complex(2.5d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, 1.5d), new Complex(0.0, 9.5d), new Complex(-9d, 8d), new Complex(-1.5d, 6d));
            var v = ov.swizzle.zzzw;
            Assert.That(new Complex(-9d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6d, 9.5d), new Complex(0.0, -3d), new Complex(-7.5d, 5d), new Complex(3d, 3.5d));
            var v = ov.swizzle.zzw;
            Assert.That(new Complex(-7.5d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, 3.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-2d, 8d), new Complex(-2d, -5.5d), new Complex(9.5d, -1d), new Complex(2d, -7d));
            var v = ov.swizzle.zzwx;
            Assert.That(new Complex(9.5d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, 8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, 8d), new Complex(9d, 0.0), new Complex(-1.5d, -3d), new Complex(-9d, 7d));
            var v = ov.swizzle.zzwy;
            Assert.That(new Complex(-1.5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, -5d), new Complex(-3.5d, 1.5d), new Complex(-2d, -9d), new Complex(-6.5d, -6.5d));
            var v = ov.swizzle.zzwz;
            Assert.That(new Complex(-2d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, -9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, 8.5d), new Complex(-1.5d, 4.5d), new Complex(-3d, 6d), new Complex(-1.5d, 0.0));
            var v = ov.swizzle.zzww;
            Assert.That(new Complex(-3d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, 2d), new Complex(4.5d, 6.5d), new Complex(5.5d, 8.5d), new Complex(0.5d, 9d));
            var v = ov.swizzle.zw;
            Assert.That(new Complex(5.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 9d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(-1d, 3d), new Complex(-8d, 6.5d), new Complex(8.5d, -8d), new Complex(-9d, 8d));
            var v = ov.swizzle.zwx;
            Assert.That(new Complex(8.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, 3d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(7.5d, -2.5d), new Complex(1.5d, -1d), new Complex(9d, 3.5d), new Complex(-2d, 9.5d));
            var v = ov.swizzle.zwxx;
            Assert.That(new Complex(9d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7.5d, 8.5d), new Complex(-5d, -3d), new Complex(3d, -1.5d), new Complex(9d, -9d));
            var v = ov.swizzle.zwxy;
            Assert.That(new Complex(3d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4.5d, 7d), new Complex(9d, 8d), new Complex(9d, -8.5d), new Complex(4.5d, -1d));
            var v = ov.swizzle.zwxz;
            Assert.That(new Complex(9d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3.5d, -0.5d), new Complex(-3.5d, -9d), new Complex(-2.5d, 1.0), new Complex(-1d, 0.5d));
            var v = ov.swizzle.zwxw;
            Assert.That(new Complex(-2.5d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4.5d, -8.5d), new Complex(3.5d, -9d), new Complex(2.5d, -1.5d), new Complex(-6d, 6.5d));
            var v = ov.swizzle.zwy;
            Assert.That(new Complex(2.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -9d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-5d, 1.5d), new Complex(9d, 0.0), new Complex(-5d, 0.0), new Complex(2d, 4.5d));
            var v = ov.swizzle.zwyx;
            Assert.That(new Complex(-5d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, 3.5d), new Complex(1.5d, 7d), new Complex(9.5d, 4d), new Complex(-7.5d, 3d));
            var v = ov.swizzle.zwyy;
            Assert.That(new Complex(9.5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.5d, 7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, -5d), new Complex(1.5d, 6.5d), new Complex(3.5d, -0.5d), new Complex(3.5d, -2d));
            var v = ov.swizzle.zwyz;
            Assert.That(new Complex(3.5d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, -0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4d, 6d), new Complex(-8.5d, 0.0), new Complex(4d, 0.5d), new Complex(6.5d, 8.5d));
            var v = ov.swizzle.zwyw;
            Assert.That(new Complex(4d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, 6d), new Complex(-6d, -1d), new Complex(6.5d, 9d), new Complex(-4d, 0.0));
            var v = ov.swizzle.zwz;
            Assert.That(new Complex(6.5d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 9d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, 0.0), new Complex(1.0, 7.5d), new Complex(-0.5d, -6d), new Complex(-7.5d, -2.5d));
            var v = ov.swizzle.zwzx;
            Assert.That(new Complex(-0.5d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6.5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9d, -2d), new Complex(-8d, 5.5d), new Complex(4.5d, -2d), new Complex(2d, -8.5d));
            var v = ov.swizzle.zwzy;
            Assert.That(new Complex(4.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7d, 2.5d), new Complex(-4.5d, 6d), new Complex(5.5d, -1.5d), new Complex(-7d, -4.5d));
            var v = ov.swizzle.zwzz;
            Assert.That(new Complex(5.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, 8d), new Complex(-7.5d, -9d), new Complex(3d, -5d), new Complex(-1.5d, -5.5d));
            var v = ov.swizzle.zwzw;
            Assert.That(new Complex(3d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, -5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, 7d), new Complex(6d, 7.5d), new Complex(-5.5d, 6d), new Complex(1.5d, 0.5d));
            var v = ov.swizzle.zww;
            Assert.That(new Complex(-5.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 0.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-6d, 7d), new Complex(-7.5d, -4.5d), new Complex(5d, 1.0), new Complex(2d, 8d));
            var v = ov.swizzle.zwwx;
            Assert.That(new Complex(5d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, 7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6d, -9d), new Complex(-7d, 8d), new Complex(-8.5d, 2d), new Complex(-3d, -2.5d));
            var v = ov.swizzle.zwwy;
            Assert.That(new Complex(-8.5d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, 8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, -2.5d), new Complex(0.5d, 3d), new Complex(-2d, -6.5d), new Complex(-9d, 7d));
            var v = ov.swizzle.zwwz;
            Assert.That(new Complex(-2d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7.5d, 8d), new Complex(-9d, -4.5d), new Complex(3.5d, 6.5d), new Complex(-3d, 2.5d));
            var v = ov.swizzle.zwww;
            Assert.That(new Complex(3.5d, 6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, -4.5d), new Complex(2.5d, -3d), new Complex(-5.5d, -7.5d), new Complex(9d, 5.5d));
            var v = ov.swizzle.wx;
            Assert.That(new Complex(9d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, -4.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(6.5d, 6.5d), new Complex(6.5d, -7.5d), new Complex(-4d, 8d), new Complex(-9.5d, 8d));
            var v = ov.swizzle.wxx;
            Assert.That(new Complex(-9.5d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 6.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(6.5d, 8d), new Complex(-7d, 2d), new Complex(7d, 1.0), new Complex(1.5d, -2.5d));
            var v = ov.swizzle.wxxx;
            Assert.That(new Complex(1.5d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, 8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, -6.5d), new Complex(-7d, 5d), new Complex(-9.5d, -1.5d), new Complex(2.5d, 7d));
            var v = ov.swizzle.wxxy;
            Assert.That(new Complex(2.5d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, 5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, 4d), new Complex(4d, -8d), new Complex(7.5d, 2.5d), new Complex(0.0, -3d));
            var v = ov.swizzle.wxxz;
            Assert.That(new Complex(0.0, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, 5.5d), new Complex(-2.5d, 4d), new Complex(6d, 5d), new Complex(2d, 1.0));
            var v = ov.swizzle.wxxw;
            Assert.That(new Complex(2d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2d, 1.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7.5d, 3.5d), new Complex(-8.5d, -6.5d), new Complex(-8.5d, 3.5d), new Complex(-8d, -0.5d));
            var v = ov.swizzle.wxy;
            Assert.That(new Complex(-8d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, -6.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-3d, -8.5d), new Complex(-7d, -8d), new Complex(-9.5d, -6d), new Complex(6d, -8.5d));
            var v = ov.swizzle.wxyx;
            Assert.That(new Complex(6d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, -6.5d), new Complex(0.5d, -6.5d), new Complex(7d, 6.5d), new Complex(-5.5d, 4.5d));
            var v = ov.swizzle.wxyy;
            Assert.That(new Complex(-5.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, -5d), new Complex(-4d, 9d), new Complex(4.5d, 3.5d), new Complex(-9d, -3.5d));
            var v = ov.swizzle.wxyz;
            Assert.That(new Complex(-9d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8d, -5d), new Complex(-4.5d, 3.5d), new Complex(6d, 0.0), new Complex(9.5d, -7d));
            var v = ov.swizzle.wxyw;
            Assert.That(new Complex(9.5d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9d, 5d), new Complex(-0.5d, -5d), new Complex(6.5d, 3d), new Complex(4d, -9d));
            var v = ov.swizzle.wxz;
            Assert.That(new Complex(4d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 3d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(9d, -3d), new Complex(-9.5d, -6d), new Complex(-2.5d, 3d), new Complex(2.5d, -0.5d));
            var v = ov.swizzle.wxzx;
            Assert.That(new Complex(2.5d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, 3.5d), new Complex(3.5d, -8.5d), new Complex(-6d, 6.5d), new Complex(3.5d, -8.5d));
            var v = ov.swizzle.wxzy;
            Assert.That(new Complex(3.5d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, 5d), new Complex(-7.5d, -9d), new Complex(-3d, 1.0), new Complex(-6d, -2d));
            var v = ov.swizzle.wxzz;
            Assert.That(new Complex(-6d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, 1.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, 1.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, -3.5d), new Complex(5.5d, -9d), new Complex(6d, -4.5d), new Complex(-9d, -0.5d));
            var v = ov.swizzle.wxzw;
            Assert.That(new Complex(-9d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, -0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, -2.5d), new Complex(0.0, -9d), new Complex(3d, 2d), new Complex(-2.5d, 0.0));
            var v = ov.swizzle.wxw;
            Assert.That(new Complex(-2.5d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, 0.0), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(8d, 6d), new Complex(5.5d, 4.5d), new Complex(8d, 0.5d), new Complex(-8d, 2.5d));
            var v = ov.swizzle.wxwx;
            Assert.That(new Complex(-8d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(8d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9d, -5.5d), new Complex(-9d, 4d), new Complex(1.5d, 8.5d), new Complex(-2d, 0.0));
            var v = ov.swizzle.wxwy;
            Assert.That(new Complex(-2d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, 2d), new Complex(6d, -0.5d), new Complex(2.5d, 6.5d), new Complex(8d, -7d));
            var v = ov.swizzle.wxwz;
            Assert.That(new Complex(8d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, 6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4.5d, -9d), new Complex(-7d, -2d), new Complex(8d, -5d), new Complex(3.5d, 4d));
            var v = ov.swizzle.wxww;
            Assert.That(new Complex(3.5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, -4d), new Complex(-2.5d, -3.5d), new Complex(-4.5d, -1.5d), new Complex(5.5d, 2d));
            var v = ov.swizzle.wy;
            Assert.That(new Complex(5.5d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, -3.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(-4d, -4.5d), new Complex(-5d, -6d), new Complex(8.5d, -0.5d), new Complex(0.0, 3.5d));
            var v = ov.swizzle.wyx;
            Assert.That(new Complex(0.0, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, -6d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -4.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(1.0, 5d), new Complex(-9d, -9.5d), new Complex(3d, 7.5d), new Complex(-3d, 5.5d));
            var v = ov.swizzle.wyxx;
            Assert.That(new Complex(-3d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, 5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9d, 6d), new Complex(-2.5d, -2d), new Complex(2d, -2.5d), new Complex(8d, -5.5d));
            var v = ov.swizzle.wyxy;
            Assert.That(new Complex(8d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, 9d), new Complex(9d, 1.0), new Complex(6.5d, -2d), new Complex(-4d, -9d));
            var v = ov.swizzle.wyxz;
            Assert.That(new Complex(-4d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1d, -5.5d), new Complex(8d, 9d), new Complex(-6.5d, 3d), new Complex(2d, -3.5d));
            var v = ov.swizzle.wyxw;
            Assert.That(new Complex(2d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, -5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.0, -9.5d), new Complex(4d, 4.5d), new Complex(-3d, -6d), new Complex(-9d, -4d));
            var v = ov.swizzle.wyy;
            Assert.That(new Complex(-9d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, 4.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, -6.5d), new Complex(3d, -6.5d), new Complex(0.5d, 2.5d), new Complex(8.5d, -4d));
            var v = ov.swizzle.wyyx;
            Assert.That(new Complex(8.5d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2.5d, 2d), new Complex(-4d, -9.5d), new Complex(-0.5d, -5d), new Complex(8d, 8.5d));
            var v = ov.swizzle.wyyy;
            Assert.That(new Complex(8d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, 1.5d), new Complex(8d, 0.0), new Complex(-3d, -4d), new Complex(3.5d, 1.5d));
            var v = ov.swizzle.wyyz;
            Assert.That(new Complex(3.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7.5d, 4d), new Complex(7d, 4.5d), new Complex(-7d, -5.5d), new Complex(1.5d, 3d));
            var v = ov.swizzle.wyyw;
            Assert.That(new Complex(1.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.5d, 3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, 4d), new Complex(-9d, 1.0), new Complex(2.5d, 3.5d), new Complex(3.5d, 0.5d));
            var v = ov.swizzle.wyz;
            Assert.That(new Complex(3.5d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 3.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(3d, 9.5d), new Complex(-5.5d, 9d), new Complex(-6.5d, 6d), new Complex(-6d, -6d));
            var v = ov.swizzle.wyzx;
            Assert.That(new Complex(-6d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, 9.5d), new Complex(4.5d, 6.5d), new Complex(-7.5d, -9d), new Complex(-7.5d, 2d));
            var v = ov.swizzle.wyzy;
            Assert.That(new Complex(-7.5d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, -9d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, 6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, -8.5d), new Complex(-7.5d, 9.5d), new Complex(3.5d, -9.5d), new Complex(8d, -1.5d));
            var v = ov.swizzle.wyzz;
            Assert.That(new Complex(8d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.0, 7.5d), new Complex(-9.5d, -3d), new Complex(-2d, -1d), new Complex(7.5d, -6.5d));
            var v = ov.swizzle.wyzw;
            Assert.That(new Complex(7.5d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, -1.5d), new Complex(5d, -6.5d), new Complex(-3.5d, 2.5d), new Complex(4d, -5.5d));
            var v = ov.swizzle.wyw;
            Assert.That(new Complex(4d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, -5.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(7.5d, 6.5d), new Complex(3.5d, -0.5d), new Complex(3.5d, 3.5d), new Complex(-8d, 6d));
            var v = ov.swizzle.wywx;
            Assert.That(new Complex(-8d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, 6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, -1.5d), new Complex(2d, -9d), new Complex(-7d, -4d), new Complex(2d, -2.5d));
            var v = ov.swizzle.wywy;
            Assert.That(new Complex(2d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2d, -9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, -4.5d), new Complex(2.5d, 0.0), new Complex(-1.5d, -8.5d), new Complex(-6.5d, -8d));
            var v = ov.swizzle.wywz;
            Assert.That(new Complex(-6.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3d, 0.0), new Complex(-9d, -4.5d), new Complex(-5d, -3d), new Complex(5d, -2d));
            var v = ov.swizzle.wyww;
            Assert.That(new Complex(5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, -6d), new Complex(-5d, -4d), new Complex(-8d, -3d), new Complex(2.5d, 6d));
            var v = ov.swizzle.wz;
            Assert.That(new Complex(2.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, -3d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(2.5d, 1.0), new Complex(7d, -1d), new Complex(4d, -5d), new Complex(2.5d, 1.5d));
            var v = ov.swizzle.wzx;
            Assert.That(new Complex(2.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 1.0), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-5d, -8.5d), new Complex(3d, -6.5d), new Complex(1.5d, 1.5d), new Complex(-7d, -0.5d));
            var v = ov.swizzle.wzxx;
            Assert.That(new Complex(-7d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, -5.5d), new Complex(-9.5d, 1.0), new Complex(2d, -3d), new Complex(8d, -9d));
            var v = ov.swizzle.wzxy;
            Assert.That(new Complex(8d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, -5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, 1.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, 8d), new Complex(-1.5d, 7d), new Complex(5.5d, 4.5d), new Complex(-1d, 9d));
            var v = ov.swizzle.wzxz;
            Assert.That(new Complex(-1d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, -6d), new Complex(4d, 7.5d), new Complex(-9d, -1.5d), new Complex(-8d, -8d));
            var v = ov.swizzle.wzxw;
            Assert.That(new Complex(-8d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, -9.5d), new Complex(-9d, 0.5d), new Complex(0.5d, -7d), new Complex(-3d, -8.5d));
            var v = ov.swizzle.wzy;
            Assert.That(new Complex(-3d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, 0.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(4.5d, -8d), new Complex(9d, 9.5d), new Complex(6.5d, -1.5d), new Complex(-6.5d, -3d));
            var v = ov.swizzle.wzyx;
            Assert.That(new Complex(-6.5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, 8.5d), new Complex(5d, 7.5d), new Complex(-7d, 4d), new Complex(-4d, -2d));
            var v = ov.swizzle.wzyy;
            Assert.That(new Complex(-4d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, -1d), new Complex(4.5d, -3.5d), new Complex(-3d, -6.5d), new Complex(0.5d, -5.5d));
            var v = ov.swizzle.wzyz;
            Assert.That(new Complex(0.5d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, -3d), new Complex(1.0, 0.0), new Complex(2d, -5.5d), new Complex(3.5d, 2d));
            var v = ov.swizzle.wzyw;
            Assert.That(new Complex(3.5d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, 2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1d, -1.5d), new Complex(9.5d, -5.5d), new Complex(6d, 2d), new Complex(-2d, -7.5d));
            var v = ov.swizzle.wzz;
            Assert.That(new Complex(-2d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 2d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, -4.5d), new Complex(-9d, 9.5d), new Complex(1.5d, 9d), new Complex(-5.5d, 2.5d));
            var v = ov.swizzle.wzzx;
            Assert.That(new Complex(-5.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, 1.5d), new Complex(4d, 0.0), new Complex(-5d, 5.5d), new Complex(-6d, -6d));
            var v = ov.swizzle.wzzy;
            Assert.That(new Complex(-6d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5.5d, -4.5d), new Complex(9.5d, 4.5d), new Complex(-4d, -5.5d), new Complex(-3d, 8d));
            var v = ov.swizzle.wzzz;
            Assert.That(new Complex(-3d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, 3.5d), new Complex(1.5d, 4.5d), new Complex(8.5d, -3d), new Complex(4d, -9d));
            var v = ov.swizzle.wzzw;
            Assert.That(new Complex(4d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, -9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 4.5d), new Complex(8d, -7d), new Complex(-2d, -0.5d), new Complex(0.5d, -4.5d));
            var v = ov.swizzle.wzw;
            Assert.That(new Complex(0.5d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, -4.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(2d, 4.5d), new Complex(-0.5d, 0.0), new Complex(-8.5d, 8d), new Complex(7.5d, -6.5d));
            var v = ov.swizzle.wzwx;
            Assert.That(new Complex(7.5d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, -6.5d), new Complex(5d, 7d), new Complex(-8.5d, 7.5d), new Complex(-0.5d, -4d));
            var v = ov.swizzle.wzwy;
            Assert.That(new Complex(-0.5d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, -4d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2d, -1d), new Complex(-3.5d, -4.5d), new Complex(6d, -1.5d), new Complex(-8d, 5.5d));
            var v = ov.swizzle.wzwz;
            Assert.That(new Complex(-8d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3d, -4.5d), new Complex(-8d, 3.5d), new Complex(-6.5d, 6.5d), new Complex(-5d, -7d));
            var v = ov.swizzle.wzww;
            Assert.That(new Complex(-5d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9d, 0.5d), new Complex(-2d, 3.5d), new Complex(9.5d, -8.5d), new Complex(0.0, 5.5d));
            var v = ov.swizzle.ww;
            Assert.That(new Complex(0.0, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, 5.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(1.5d, 1.0), new Complex(0.0, -3.5d), new Complex(-8d, -2.5d), new Complex(-1.5d, -7d));
            var v = ov.swizzle.wwx;
            Assert.That(new Complex(-1.5d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 1.0), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, 0.0), new Complex(0.0, -2d), new Complex(-3d, -1.5d), new Complex(7.5d, -8d));
            var v = ov.swizzle.wwxx;
            Assert.That(new Complex(7.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2d, -2.5d), new Complex(8.5d, 5d), new Complex(-3.5d, 6d), new Complex(2d, 9d));
            var v = ov.swizzle.wwxy;
            Assert.That(new Complex(2d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, 5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2.5d, 3.5d), new Complex(-6d, -8d), new Complex(8d, -4.5d), new Complex(0.0, -7.5d));
            var v = ov.swizzle.wwxz;
            Assert.That(new Complex(0.0, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(8d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8.5d, 1.5d), new Complex(3.5d, -2.5d), new Complex(9d, 7d), new Complex(-8d, -8.5d));
            var v = ov.swizzle.wwxw;
            Assert.That(new Complex(-8d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, 2d), new Complex(-3.5d, -8.5d), new Complex(-4d, 3d), new Complex(8d, 8.5d));
            var v = ov.swizzle.wwy;
            Assert.That(new Complex(8d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -8.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(3.5d, 3d), new Complex(5.5d, -1.5d), new Complex(9.5d, -6.5d), new Complex(9.5d, 0.0));
            var v = ov.swizzle.wwyx;
            Assert.That(new Complex(9.5d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, 3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7d, 6.5d), new Complex(-6.5d, 4.5d), new Complex(-4.5d, -1.5d), new Complex(5.5d, 1.0));
            var v = ov.swizzle.wwyy;
            Assert.That(new Complex(5.5d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8d, 5.5d), new Complex(-1d, 1.5d), new Complex(9.5d, -6.5d), new Complex(2d, 5d));
            var v = ov.swizzle.wwyz;
            Assert.That(new Complex(2d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1d, -2d), new Complex(2.5d, 1.5d), new Complex(-7d, -8.5d), new Complex(-5d, 9d));
            var v = ov.swizzle.wwyw;
            Assert.That(new Complex(-5d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, -9.5d), new Complex(-5.5d, -9.5d), new Complex(-3.5d, -5.5d), new Complex(4d, 5d));
            var v = ov.swizzle.wwz;
            Assert.That(new Complex(4d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -5.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(0.0, -7d), new Complex(4d, -7d), new Complex(1.5d, 2d), new Complex(7.5d, 7d));
            var v = ov.swizzle.wwzx;
            Assert.That(new Complex(7.5d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 2d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9d, 5d), new Complex(-6.5d, -2d), new Complex(-6d, -4.5d), new Complex(-3.5d, 3d));
            var v = ov.swizzle.wwzy;
            Assert.That(new Complex(-3.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6.5d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2d, -5.5d), new Complex(-8.5d, 7.5d), new Complex(-8d, 2.5d), new Complex(4d, -9d));
            var v = ov.swizzle.wwzz;
            Assert.That(new Complex(4d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2.5d, -6.5d), new Complex(8d, -3.5d), new Complex(5.5d, -3d), new Complex(-4.5d, -2d));
            var v = ov.swizzle.wwzw;
            Assert.That(new Complex(-4.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4.5d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.0, -1.5d), new Complex(-4d, -1.5d), new Complex(-0.5d, -9.5d), new Complex(-9d, 3.5d));
            var v = ov.swizzle.www;
            Assert.That(new Complex(-9d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, 3.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-3d, -5d), new Complex(1.5d, 4d), new Complex(3.5d, -4d), new Complex(-6d, 9.5d));
            var v = ov.swizzle.wwwx;
            Assert.That(new Complex(-6d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, -5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6d, 5.5d), new Complex(6d, -8d), new Complex(0.5d, 9d), new Complex(5d, 7.5d));
            var v = ov.swizzle.wwwy;
            Assert.That(new Complex(5d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, 3d), new Complex(4.5d, 8.5d), new Complex(-3.5d, 1.0), new Complex(8.5d, -6.5d));
            var v = ov.swizzle.wwwz;
            Assert.That(new Complex(8.5d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3.5d, 1.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, 7.5d), new Complex(8d, 5.5d), new Complex(8d, -9d), new Complex(-1.5d, -4.5d));
            var v = ov.swizzle.wwww;
            Assert.That(new Complex(-1.5d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, -4.5d), Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new cvec4(new Complex(-2.5d, 8.5d), new Complex(6.5d, 0.0), new Complex(4.5d, 2d), new Complex(-2.5d, 9d));
            var v = ov.swizzle.rr;
            Assert.That(new Complex(-2.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 8.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(0.5d, 4d), new Complex(2d, 9d), new Complex(-0.5d, -5.5d), new Complex(9.5d, -6.5d));
            var v = ov.swizzle.rrr;
            Assert.That(new Complex(0.5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, 4d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(8d, -9.5d), new Complex(9d, 6d), new Complex(7d, -4d), new Complex(-6.5d, -9d));
            var v = ov.swizzle.rrrr;
            Assert.That(new Complex(8d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(8d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, -4.5d), new Complex(9.5d, -7.5d), new Complex(-8.5d, 0.0), new Complex(7d, -6d));
            var v = ov.swizzle.rrrg;
            Assert.That(new Complex(6.5d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1d, 4.5d), new Complex(-8d, 5.5d), new Complex(8d, -3d), new Complex(-1d, 6d));
            var v = ov.swizzle.rrrb;
            Assert.That(new Complex(-1d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(8d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, -8d), new Complex(3d, 0.5d), new Complex(8d, -1d), new Complex(-3d, -2.5d));
            var v = ov.swizzle.rrra;
            Assert.That(new Complex(9.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, 6.5d), new Complex(6d, -9d), new Complex(0.0, -5d), new Complex(-9d, -7.5d));
            var v = ov.swizzle.rrg;
            Assert.That(new Complex(2.5d, 6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, -9d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(7d, 9.5d), new Complex(-8.5d, 4d), new Complex(2d, -3d), new Complex(9d, 1.0));
            var v = ov.swizzle.rrgr;
            Assert.That(new Complex(7d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, -0.5d), new Complex(4d, -6d), new Complex(5d, -1d), new Complex(-7d, 1.0));
            var v = ov.swizzle.rrgg;
            Assert.That(new Complex(4d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, -6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, 4.5d), new Complex(-0.5d, 8.5d), new Complex(6d, 1.5d), new Complex(-8d, -2.5d));
            var v = ov.swizzle.rrgb;
            Assert.That(new Complex(-5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, 0.5d), new Complex(8d, -2d), new Complex(8.5d, -8.5d), new Complex(-7d, 2d));
            var v = ov.swizzle.rrga;
            Assert.That(new Complex(-8.5d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, 2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1d, -4d), new Complex(6.5d, -3.5d), new Complex(-6.5d, 1.5d), new Complex(5d, 6.5d));
            var v = ov.swizzle.rrb;
            Assert.That(new Complex(-1d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 1.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(4d, 3.5d), new Complex(-2d, 5d), new Complex(-1.5d, -6d), new Complex(-2.5d, 7d));
            var v = ov.swizzle.rrbr;
            Assert.That(new Complex(4d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, 4.5d), new Complex(-9.5d, -4d), new Complex(4.5d, 1.0), new Complex(-5.5d, 5d));
            var v = ov.swizzle.rrbg;
            Assert.That(new Complex(-8d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, 1.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2.5d, -2.5d), new Complex(-8.5d, -3d), new Complex(4.5d, -4d), new Complex(-6.5d, -5.5d));
            var v = ov.swizzle.rrbb;
            Assert.That(new Complex(-2.5d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -4d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.0, 3.5d), new Complex(-1d, 0.0), new Complex(1.5d, -7.5d), new Complex(-1.5d, -5d));
            var v = ov.swizzle.rrba;
            Assert.That(new Complex(1.0, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, -5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 2.5d), new Complex(8.5d, -3d), new Complex(-8d, -1.5d), new Complex(2.5d, 7d));
            var v = ov.swizzle.rra;
            Assert.That(new Complex(6d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 7d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(4.5d, 9d), new Complex(3d, 6.5d), new Complex(2.5d, -7.5d), new Complex(-8.5d, 6.5d));
            var v = ov.swizzle.rrar;
            Assert.That(new Complex(4.5d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, 2d), new Complex(0.5d, -3.5d), new Complex(-0.5d, -7d), new Complex(1.5d, 4d));
            var v = ov.swizzle.rrag;
            Assert.That(new Complex(-2d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5d, 9d), new Complex(2.5d, 8d), new Complex(2d, -2d), new Complex(6.5d, -1d));
            var v = ov.swizzle.rrab;
            Assert.That(new Complex(5d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(2d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, -2.5d), new Complex(4.5d, -9d), new Complex(-4d, -3.5d), new Complex(6.5d, 4.5d));
            var v = ov.swizzle.rraa;
            Assert.That(new Complex(-6.5d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, -0.5d), new Complex(-6d, 4d), new Complex(1.5d, 6d), new Complex(-4.5d, -5d));
            var v = ov.swizzle.rg;
            Assert.That(new Complex(2.5d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 4d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(-1d, -5d), new Complex(-7.5d, 5d), new Complex(-0.5d, -4d), new Complex(4.5d, -8.5d));
            var v = ov.swizzle.rgr;
            Assert.That(new Complex(-1d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, -5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(5.5d, -4.5d), new Complex(-5.5d, 6d), new Complex(-6d, 1.5d), new Complex(-1d, -1.5d));
            var v = ov.swizzle.rgrr;
            Assert.That(new Complex(5.5d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, 0.5d), new Complex(-1d, 3d), new Complex(9d, 7d), new Complex(-3d, 0.0));
            var v = ov.swizzle.rgrg;
            Assert.That(new Complex(-7d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, 0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, 6.5d), new Complex(1.5d, -5.5d), new Complex(-2d, -3.5d), new Complex(0.0, 4.5d));
            var v = ov.swizzle.rgrb;
            Assert.That(new Complex(-8d, 6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9d, -5.5d), new Complex(6d, -8d), new Complex(-6d, 3d), new Complex(-1.5d, 8d));
            var v = ov.swizzle.rgra;
            Assert.That(new Complex(-9d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, -5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, 8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, 7.5d), new Complex(2d, 4.5d), new Complex(-8d, 3.5d), new Complex(5.5d, -9d));
            var v = ov.swizzle.rgg;
            Assert.That(new Complex(0.5d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, 4.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-8d, 9.5d), new Complex(8.5d, 2d), new Complex(9.5d, 7.5d), new Complex(7d, -5d));
            var v = ov.swizzle.rggr;
            Assert.That(new Complex(-8d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8d, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, -4d), new Complex(4.5d, -1.5d), new Complex(5.5d, -3.5d), new Complex(1.5d, -1.5d));
            var v = ov.swizzle.rggg;
            Assert.That(new Complex(6.5d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7d, 3d), new Complex(3.5d, -3d), new Complex(-8.5d, 0.5d), new Complex(-3d, 1.0));
            var v = ov.swizzle.rggb;
            Assert.That(new Complex(7d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, -6.5d), new Complex(8.5d, 0.0), new Complex(-3.5d, -1d), new Complex(-2.5d, 6.5d));
            var v = ov.swizzle.rgga;
            Assert.That(new Complex(-5d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, 6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4d, 2.5d), new Complex(-8d, -2.5d), new Complex(-4d, -3d), new Complex(5.5d, 6d));
            var v = ov.swizzle.rgb;
            Assert.That(new Complex(-4d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -3d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-7.5d, 8.5d), new Complex(0.5d, -1d), new Complex(-8d, -2d), new Complex(2.5d, 2d));
            var v = ov.swizzle.rgbr;
            Assert.That(new Complex(-7.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7.5d, 0.5d), new Complex(-3d, 0.5d), new Complex(-8d, 8d), new Complex(-3.5d, 9d));
            var v = ov.swizzle.rgbg;
            Assert.That(new Complex(-7.5d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(Complex.Zero, new Complex(2d, 6.5d), new Complex(4.5d, -7d), new Complex(7d, -8d));
            var v = ov.swizzle.rgbb;
            Assert.That(Complex.Zero, Is.EqualTo(v.x));
            Assert.That(new Complex(2d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3d, 9d), new Complex(3.5d, 4.5d), new Complex(-6d, -9.5d), new Complex(7.5d, -7.5d));
            var v = ov.swizzle.rgba;
            Assert.That(new Complex(3d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, 8d), new Complex(8d, -5d), new Complex(-5d, -4d), new Complex(-6.5d, 1.0));
            var v = ov.swizzle.rga;
            Assert.That(new Complex(-5.5d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 1.0), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-5d, -7d), new Complex(-8d, -9.5d), new Complex(4d, 5.5d), new Complex(-4.5d, -6.5d));
            var v = ov.swizzle.rgar;
            Assert.That(new Complex(-5d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9d, 1.5d), new Complex(9.5d, -4.5d), new Complex(-3.5d, -1d), new Complex(-8.5d, -6.5d));
            var v = ov.swizzle.rgag;
            Assert.That(new Complex(9d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, 6d), new Complex(-1.5d, 7d), new Complex(-4d, -4d), new Complex(-3d, 8d));
            var v = ov.swizzle.rgab;
            Assert.That(new Complex(-8.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, -7.5d), new Complex(-6.5d, -2.5d), new Complex(-3d, -8d), new Complex(-1.5d, -1.5d));
            var v = ov.swizzle.rgaa;
            Assert.That(new Complex(-0.5d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, -1.5d), new Complex(7d, 2.5d), new Complex(-4.5d, -4.5d), new Complex(-6.5d, -8.5d));
            var v = ov.swizzle.rb;
            Assert.That(new Complex(-9.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, -4.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(-7d, -8d), new Complex(9d, -5d), new Complex(1.5d, -2.5d), new Complex(4d, 5d));
            var v = ov.swizzle.rbr;
            Assert.That(new Complex(-7d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, -8d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(8.5d, 5.5d), new Complex(-4d, -1d), new Complex(8d, 0.5d), new Complex(-8.5d, -1.5d));
            var v = ov.swizzle.rbrr;
            Assert.That(new Complex(8.5d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7.5d, -9d), new Complex(-1.5d, -0.5d), new Complex(3d, -4.5d), new Complex(5d, -6d));
            var v = ov.swizzle.rbrg;
            Assert.That(new Complex(-7.5d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, -9d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, -0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3d, -1d), new Complex(1.5d, -1d), new Complex(-9.5d, -2.5d), new Complex(4d, -7d));
            var v = ov.swizzle.rbrb;
            Assert.That(new Complex(3d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4.5d, -4d), new Complex(2.5d, -0.5d), new Complex(-7.5d, 9d), new Complex(-6.5d, 5d));
            var v = ov.swizzle.rbra;
            Assert.That(new Complex(-4.5d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, -4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6.5d, 5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2.5d, -9d), new Complex(6.5d, -4.5d), new Complex(5d, 1.0), new Complex(-2d, 1.5d));
            var v = ov.swizzle.rbg;
            Assert.That(new Complex(-2.5d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, -4.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, -7.5d), new Complex(-7.5d, 6d), new Complex(-8d, 6.5d), new Complex(-9.5d, -6.5d));
            var v = ov.swizzle.rbgr;
            Assert.That(new Complex(-0.5d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, -5d), new Complex(-2.5d, 1.5d), new Complex(-7d, 1.5d), new Complex(-6d, -5d));
            var v = ov.swizzle.rbgg;
            Assert.That(new Complex(-8.5d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, 0.5d), new Complex(1.5d, 2.5d), new Complex(5d, -7.5d), new Complex(5d, 0.0));
            var v = ov.swizzle.rbgb;
            Assert.That(new Complex(-6.5d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, 2.5d), new Complex(0.0, -2.5d), new Complex(-3.5d, -2.5d), new Complex(6.5d, -8.5d));
            var v = ov.swizzle.rbga;
            Assert.That(new Complex(-3.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, 2.5d), new Complex(4d, -8.5d), new Complex(9.5d, 4d), new Complex(2.5d, -8d));
            var v = ov.swizzle.rbb;
            Assert.That(new Complex(0.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, 4d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, -9.5d), new Complex(7d, 6.5d), new Complex(8d, 6.5d), new Complex(8.5d, -2d));
            var v = ov.swizzle.rbbr;
            Assert.That(new Complex(-5.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2d, 7.5d), new Complex(7d, 9.5d), new Complex(3d, -3d), new Complex(-2.5d, 9.5d));
            var v = ov.swizzle.rbbg;
            Assert.That(new Complex(2d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, -6.5d), new Complex(2d, -7d), new Complex(6.5d, 2d), new Complex(-9.5d, 2.5d));
            var v = ov.swizzle.rbbb;
            Assert.That(new Complex(-3.5d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 2d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, 2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, -2d), new Complex(-9d, 3.5d), new Complex(-5d, -5.5d), new Complex(-7d, -2.5d));
            var v = ov.swizzle.rbba;
            Assert.That(new Complex(4d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, -5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5.5d, -5d), new Complex(-0.5d, 6d), new Complex(0.0, -2d), new Complex(4.5d, -2.5d));
            var v = ov.swizzle.rba;
            Assert.That(new Complex(5.5d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -2.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-1d, 5.5d), new Complex(-1.5d, -1d), new Complex(-7.5d, -4.5d), new Complex(-2d, -8d));
            var v = ov.swizzle.rbar;
            Assert.That(new Complex(-1d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4.5d, -3.5d), new Complex(-5d, -4.5d), new Complex(-8d, -5.5d), new Complex(-5.5d, -5.5d));
            var v = ov.swizzle.rbag;
            Assert.That(new Complex(-4.5d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, -5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5d, 9.5d), new Complex(-4.5d, -1.5d), new Complex(2.5d, -3d), new Complex(-7.5d, 6.5d));
            var v = ov.swizzle.rbab;
            Assert.That(new Complex(5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7.5d, -8.5d), new Complex(-3d, -6.5d), new Complex(-1.5d, -1d), new Complex(-8.5d, -5.5d));
            var v = ov.swizzle.rbaa;
            Assert.That(new Complex(7.5d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, -5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3d, 8d), new Complex(-9.5d, -5.5d), new Complex(-7d, -6.5d), new Complex(-3d, -4d));
            var v = ov.swizzle.ra;
            Assert.That(new Complex(-3d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -4d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, -6d), new Complex(-0.5d, 1.5d), new Complex(-0.5d, 1.5d), new Complex(-8.5d, -1d));
            var v = ov.swizzle.rar;
            Assert.That(new Complex(-5.5d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, -6d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(5.5d, 0.5d), new Complex(-4.5d, 0.5d), new Complex(0.0, -2.5d), new Complex(6d, 6.5d));
            var v = ov.swizzle.rarr;
            Assert.That(new Complex(5.5d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, 0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, 3d), new Complex(8d, 8.5d), new Complex(1.0, 4d), new Complex(1.0, -6.5d));
            var v = ov.swizzle.rarg;
            Assert.That(new Complex(-3.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(8d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, 6d), new Complex(4d, -5d), new Complex(-8.5d, -9.5d), new Complex(6.5d, 9d));
            var v = ov.swizzle.rarb;
            Assert.That(new Complex(4d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, -2d), new Complex(7.5d, -8d), new Complex(-3d, -6.5d), new Complex(-1.5d, -3d));
            var v = ov.swizzle.rara;
            Assert.That(new Complex(-3.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, -5d), new Complex(-9d, -1.5d), new Complex(-8.5d, 8.5d), new Complex(0.0, 3.5d));
            var v = ov.swizzle.rag;
            Assert.That(new Complex(0.5d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, -1.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-1d, 4d), new Complex(-4d, 4d), new Complex(-6.5d, -1d), new Complex(1.5d, -1.5d));
            var v = ov.swizzle.ragr;
            Assert.That(new Complex(-1d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, -7.5d), new Complex(3.5d, 9.5d), new Complex(4d, -7d), new Complex(-5d, -1.5d));
            var v = ov.swizzle.ragg;
            Assert.That(new Complex(1.5d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, -7.5d), new Complex(-2.5d, 8.5d), new Complex(-1d, 8d), new Complex(-7.5d, 3d));
            var v = ov.swizzle.ragb;
            Assert.That(new Complex(-2d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8.5d, -9d), new Complex(1.0, -2d), new Complex(-6d, -1.5d), new Complex(9.5d, 6.5d));
            var v = ov.swizzle.raga;
            Assert.That(new Complex(8.5d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, 6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4d, 5.5d), new Complex(-1d, -4.5d), new Complex(8.5d, -8.5d), new Complex(7.5d, 0.0));
            var v = ov.swizzle.rab;
            Assert.That(new Complex(-4d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -8.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, -8.5d), new Complex(0.5d, -2.5d), new Complex(-8d, -2.5d), new Complex(3.5d, 4d));
            var v = ov.swizzle.rabr;
            Assert.That(new Complex(-5.5d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, 3d), new Complex(2.5d, 1.0), new Complex(5.5d, -3d), new Complex(-5d, 0.5d));
            var v = ov.swizzle.rabg;
            Assert.That(new Complex(2.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, 1.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 9.5d), new Complex(-0.5d, 9d), new Complex(-7.5d, 9.5d), new Complex(4d, -4.5d));
            var v = ov.swizzle.rabb;
            Assert.That(new Complex(6d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7d, 0.5d), new Complex(-1.5d, 6.5d), new Complex(-1d, 4d), new Complex(-7.5d, -6.5d));
            var v = ov.swizzle.raba;
            Assert.That(new Complex(7d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2d, -7d), new Complex(8d, 9.5d), new Complex(-6d, -5d), new Complex(2.5d, 3d));
            var v = ov.swizzle.raa;
            Assert.That(new Complex(2d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 3d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(4d, -9.5d), new Complex(-3.5d, -7d), new Complex(0.5d, 1.0), new Complex(-7d, 8d));
            var v = ov.swizzle.raar;
            Assert.That(new Complex(4d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4.5d, 5d), new Complex(9.5d, -6d), new Complex(7.5d, 1.5d), new Complex(-5.5d, 7.5d));
            var v = ov.swizzle.raag;
            Assert.That(new Complex(4.5d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, -2.5d), new Complex(-3d, -2.5d), new Complex(-4d, -6d), new Complex(-9d, -2.5d));
            var v = ov.swizzle.raab;
            Assert.That(new Complex(-8.5d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, -6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, 7d), new Complex(-5.5d, 8.5d), new Complex(-7d, -2d), new Complex(-9.5d, -8d));
            var v = ov.swizzle.raaa;
            Assert.That(new Complex(-8.5d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5.5d, -8d), new Complex(0.5d, 6d), new Complex(9.5d, -5.5d), new Complex(9.5d, -8.5d));
            var v = ov.swizzle.gr;
            Assert.That(new Complex(0.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, -8d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(8.5d, -2.5d), new Complex(-0.5d, -3.5d), new Complex(7d, -2.5d), new Complex(-6.5d, -2d));
            var v = ov.swizzle.grr;
            Assert.That(new Complex(-0.5d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -2.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(4d, 7.5d), new Complex(5d, -7.5d), new Complex(-4d, -2d), new Complex(9d, -8.5d));
            var v = ov.swizzle.grrr;
            Assert.That(new Complex(5d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, 7d), new Complex(4.5d, 4d), new Complex(7.5d, -7d), new Complex(4d, 4.5d));
            var v = ov.swizzle.grrg;
            Assert.That(new Complex(4.5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5.5d, -1d), new Complex(6d, -5d), new Complex(2.5d, -9d), new Complex(8.5d, 4d));
            var v = ov.swizzle.grrb;
            Assert.That(new Complex(6d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, -9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.0, -6.5d), new Complex(1.0, -6d), new Complex(8.5d, 8.5d), new Complex(2.5d, -2.5d));
            var v = ov.swizzle.grra;
            Assert.That(new Complex(1.0, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4.5d, 9d), new Complex(-1d, -3d), new Complex(4.5d, 2d), new Complex(4.5d, -2d));
            var v = ov.swizzle.grg;
            Assert.That(new Complex(-1d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, -3d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-5d, 2.5d), new Complex(3d, 9d), new Complex(-5.5d, -8d), new Complex(-6.5d, 2.5d));
            var v = ov.swizzle.grgr;
            Assert.That(new Complex(3d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, -7.5d), new Complex(0.5d, -3.5d), new Complex(-2.5d, 5d), new Complex(-3d, -1d));
            var v = ov.swizzle.grgg;
            Assert.That(new Complex(0.5d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9d, -5d), new Complex(-6d, 3.5d), new Complex(3.5d, -6d), new Complex(-5d, 3.5d));
            var v = ov.swizzle.grgb;
            Assert.That(new Complex(-6d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, -6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, -1.5d), new Complex(6d, -2.5d), new Complex(-2d, 9d), new Complex(-1.5d, -7.5d));
            var v = ov.swizzle.grga;
            Assert.That(new Complex(6d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, 2d), new Complex(-1.5d, 7d), new Complex(3.5d, -0.5d), new Complex(-2.5d, -6.5d));
            var v = ov.swizzle.grb;
            Assert.That(new Complex(-1.5d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -0.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-6d, -1d), new Complex(8d, -9d), new Complex(-5.5d, -6d), new Complex(-4d, 1.5d));
            var v = ov.swizzle.grbr;
            Assert.That(new Complex(8d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, -1d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, -9.5d), new Complex(-9d, 6d), new Complex(-9d, 2.5d), new Complex(3.5d, 9.5d));
            var v = ov.swizzle.grbg;
            Assert.That(new Complex(-9d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, 7d), new Complex(6d, 4.5d), new Complex(5d, 8d), new Complex(-1.5d, -3d));
            var v = ov.swizzle.grbb;
            Assert.That(new Complex(6d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5.5d, -6.5d), new Complex(-4d, -5d), new Complex(7d, -8d), new Complex(1.0, -4.5d));
            var v = ov.swizzle.grba;
            Assert.That(new Complex(-4d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7.5d, 3d), new Complex(0.5d, -9d), new Complex(7.5d, 9.5d), new Complex(0.0, -9d));
            var v = ov.swizzle.gra;
            Assert.That(new Complex(0.5d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, -9d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(6d, 6.5d), new Complex(-4.5d, 3d), new Complex(5.5d, -9.5d), new Complex(-9d, -6d));
            var v = ov.swizzle.grar;
            Assert.That(new Complex(-4.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, 6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3d, 8.5d), new Complex(-7d, -6.5d), new Complex(-9.5d, -5d), new Complex(3.5d, 6.5d));
            var v = ov.swizzle.grag;
            Assert.That(new Complex(-7d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, 6d), new Complex(-1d, -5d), new Complex(6d, -6.5d), new Complex(6d, 0.0));
            var v = ov.swizzle.grab;
            Assert.That(new Complex(-1d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, -6.5d), new Complex(6d, -8d), new Complex(-8d, 9.5d), new Complex(6d, -2d));
            var v = ov.swizzle.graa;
            Assert.That(new Complex(6d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9d, 4.5d), new Complex(9d, -4.5d), new Complex(1.5d, -3d), new Complex(3.5d, -5d));
            var v = ov.swizzle.gg;
            Assert.That(new Complex(9d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -4.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(-1d, 2.5d), new Complex(3.5d, 6d), new Complex(-7.5d, 3d), new Complex(2d, -8d));
            var v = ov.swizzle.ggr;
            Assert.That(new Complex(3.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, 2.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-1d, -7.5d), new Complex(5d, 1.0), new Complex(-9.5d, 9d), new Complex(4d, -1d));
            var v = ov.swizzle.ggrr;
            Assert.That(new Complex(5d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, 9d), new Complex(9d, -6.5d), new Complex(6d, -6d), new Complex(5.5d, -6.5d));
            var v = ov.swizzle.ggrg;
            Assert.That(new Complex(9d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, 8d), new Complex(3.5d, 7d), new Complex(-9.5d, -5.5d), new Complex(1.5d, 6d));
            var v = ov.swizzle.ggrb;
            Assert.That(new Complex(3.5d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3d, 8.5d), new Complex(4d, 7.5d), new Complex(0.0, 0.5d), new Complex(-5d, 4.5d));
            var v = ov.swizzle.ggra;
            Assert.That(new Complex(4d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8.5d, 2.5d), new Complex(-4.5d, 6.5d), new Complex(3d, 1.5d), new Complex(-9.5d, 0.5d));
            var v = ov.swizzle.ggg;
            Assert.That(new Complex(-4.5d, 6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, 6.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(0.0, 9d), new Complex(9.5d, 8d), new Complex(-1d, -2.5d), new Complex(-0.5d, 3d));
            var v = ov.swizzle.gggr;
            Assert.That(new Complex(9.5d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5.5d, -6d), new Complex(1.0, 3d), new Complex(-7.5d, 1.5d), new Complex(-2d, -7d));
            var v = ov.swizzle.gggg;
            Assert.That(new Complex(1.0, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, 3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, 6d), new Complex(4d, -7.5d), new Complex(-0.5d, -2.5d), new Complex(-4d, 0.5d));
            var v = ov.swizzle.gggb;
            Assert.That(new Complex(4d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2d, 8.5d), new Complex(3.5d, 0.0), new Complex(7d, 2.5d), new Complex(7d, 5.5d));
            var v = ov.swizzle.ggga;
            Assert.That(new Complex(3.5d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7.5d, -4d), new Complex(-6d, 1.0), new Complex(4.5d, -3.5d), new Complex(-9.5d, -7.5d));
            var v = ov.swizzle.ggb;
            Assert.That(new Complex(-6d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -3.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(3d, 7.5d), new Complex(-2d, 0.0), new Complex(-6d, 2.5d), new Complex(-5.5d, -5d));
            var v = ov.swizzle.ggbr;
            Assert.That(new Complex(-2d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, 4.5d), new Complex(-2.5d, 2.5d), new Complex(3.5d, -3d), new Complex(-4d, 4.5d));
            var v = ov.swizzle.ggbg;
            Assert.That(new Complex(-2.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8d, 2.5d), new Complex(-6d, -6d), new Complex(4.5d, -6.5d), new Complex(-4.5d, 5.5d));
            var v = ov.swizzle.ggbb;
            Assert.That(new Complex(-6d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, -6d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, -4d), new Complex(1.0, -1d), new Complex(2d, 6d), new Complex(-2d, -3d));
            var v = ov.swizzle.ggba;
            Assert.That(new Complex(1.0, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4.5d, -5d), new Complex(1.5d, 6d), new Complex(8d, 5.5d), new Complex(8.5d, 3d));
            var v = ov.swizzle.gga;
            Assert.That(new Complex(1.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 3d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-2.5d, 1.5d), new Complex(4.5d, 8.5d), new Complex(6.5d, -6d), new Complex(-4.5d, -4.5d));
            var v = ov.swizzle.ggar;
            Assert.That(new Complex(4.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3d, -9d), new Complex(5d, 1.5d), new Complex(-1.5d, 6d), new Complex(-9.5d, 8.5d));
            var v = ov.swizzle.ggag;
            Assert.That(new Complex(5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7.5d, 5d), new Complex(2.5d, 5.5d), new Complex(-8d, -8.5d), new Complex(-6.5d, -1.5d));
            var v = ov.swizzle.ggab;
            Assert.That(new Complex(2.5d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, 9d), new Complex(-5.5d, 8d), new Complex(-6d, 1.5d), new Complex(-0.5d, 8d));
            var v = ov.swizzle.ggaa;
            Assert.That(new Complex(-5.5d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, 8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, -5d), new Complex(-2.5d, -2d), new Complex(2d, 7d), new Complex(7d, -8.5d));
            var v = ov.swizzle.gb;
            Assert.That(new Complex(-2.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, 7d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(7d, 1.5d), new Complex(7d, 4.5d), new Complex(2d, -7.5d), new Complex(-6.5d, -0.5d));
            var v = ov.swizzle.gbr;
            Assert.That(new Complex(7d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, 1.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(9d, 8.5d), new Complex(3d, 0.5d), new Complex(-4.5d, -6d), new Complex(1.0, -4.5d));
            var v = ov.swizzle.gbrr;
            Assert.That(new Complex(3d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, -6d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, 1.5d), new Complex(6.5d, -9d), new Complex(-4d, -9.5d), new Complex(6d, 5d));
            var v = ov.swizzle.gbrg;
            Assert.That(new Complex(6.5d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, -9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 4d), new Complex(6.5d, -7.5d), new Complex(2.5d, 0.5d), new Complex(8d, 8.5d));
            var v = ov.swizzle.gbrb;
            Assert.That(new Complex(6.5d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, -4.5d), new Complex(1.5d, 7d), new Complex(-9.5d, 4.5d), new Complex(-8.5d, 0.0));
            var v = ov.swizzle.gbra;
            Assert.That(new Complex(1.5d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, -3.5d), new Complex(-3d, -2d), new Complex(-7d, -1.5d), new Complex(-6d, 7.5d));
            var v = ov.swizzle.gbg;
            Assert.That(new Complex(-3d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, -2d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(7.5d, 5.5d), new Complex(-1d, 2.5d), new Complex(4.5d, -4.5d), new Complex(5d, 2d));
            var v = ov.swizzle.gbgr;
            Assert.That(new Complex(-1d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4.5d, -9.5d), new Complex(-3d, 7.5d), new Complex(-1.5d, 8.5d), new Complex(7d, 0.0));
            var v = ov.swizzle.gbgg;
            Assert.That(new Complex(-3d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, 6.5d), new Complex(1.0, -2d), new Complex(0.5d, -1d), new Complex(-9d, 5.5d));
            var v = ov.swizzle.gbgb;
            Assert.That(new Complex(1.0, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -1d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, -4d), new Complex(-3d, -4.5d), new Complex(-5d, -5.5d), new Complex(9.5d, -1.5d));
            var v = ov.swizzle.gbga;
            Assert.That(new Complex(-3d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, -5d), new Complex(-3.5d, -9d), new Complex(0.5d, 6d), new Complex(0.0, -5.5d));
            var v = ov.swizzle.gbb;
            Assert.That(new Complex(-3.5d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, 6d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-9d, -3d), new Complex(-2d, -4d), new Complex(-7d, -7.5d), new Complex(4.5d, -2.5d));
            var v = ov.swizzle.gbbr;
            Assert.That(new Complex(-2d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, -9d), new Complex(6d, 0.5d), new Complex(-4d, -7.5d), new Complex(2.5d, 7d));
            var v = ov.swizzle.gbbg;
            Assert.That(new Complex(6d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, -6d), new Complex(-7.5d, 6d), new Complex(7d, 5.5d), new Complex(5.5d, -9d));
            var v = ov.swizzle.gbbb;
            Assert.That(new Complex(-7.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, 5d), new Complex(-3.5d, -4.5d), new Complex(-4.5d, 3.5d), new Complex(9.5d, 5d));
            var v = ov.swizzle.gbba;
            Assert.That(new Complex(-3.5d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, 5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9d, 4d), new Complex(-9.5d, -2d), new Complex(-7d, 5d), new Complex(-7d, 2.5d));
            var v = ov.swizzle.gba;
            Assert.That(new Complex(-9.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, 2.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(7d, -8d), new Complex(6d, -8d), new Complex(-8d, 8d), new Complex(4d, 0.5d));
            var v = ov.swizzle.gbar;
            Assert.That(new Complex(6d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, 0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 9d), new Complex(-3d, 2.5d), new Complex(-7d, -5.5d), new Complex(1.0, 7.5d));
            var v = ov.swizzle.gbag;
            Assert.That(new Complex(-3d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6d, -8.5d), new Complex(-8.5d, 5d), new Complex(9.5d, -4.5d), new Complex(-4d, 4d));
            var v = ov.swizzle.gbab;
            Assert.That(new Complex(-8.5d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, 4d), new Complex(-7d, 2d), new Complex(7.5d, -4.5d), new Complex(-3.5d, -9.5d));
            var v = ov.swizzle.gbaa;
            Assert.That(new Complex(-7d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3.5d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4.5d, -1d), new Complex(9.5d, 8.5d), new Complex(-4d, -6.5d), new Complex(-8d, -2.5d));
            var v = ov.swizzle.ga;
            Assert.That(new Complex(9.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, -2.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(9.5d, -5d), new Complex(6.5d, 1.5d), new Complex(0.0, -6.5d), new Complex(6d, -1.5d));
            var v = ov.swizzle.gar;
            Assert.That(new Complex(6.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, -5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(3.5d, -7d), new Complex(4.5d, 2.5d), new Complex(-1.5d, -0.5d), new Complex(5d, -2.5d));
            var v = ov.swizzle.garr;
            Assert.That(new Complex(4.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2.5d, 1.5d), new Complex(-6d, -8d), new Complex(0.5d, -7.5d), new Complex(1.0, 1.0));
            var v = ov.swizzle.garg;
            Assert.That(new Complex(-6d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9d, -1d), new Complex(-3d, -3d), new Complex(3.5d, 6d), new Complex(-2d, 2.5d));
            var v = ov.swizzle.garb;
            Assert.That(new Complex(-3d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4.5d, 4d), new Complex(-2d, 0.5d), new Complex(-1.5d, -6d), new Complex(-8d, -5.5d));
            var v = ov.swizzle.gara;
            Assert.That(new Complex(-2d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, 6d), new Complex(-2d, -6.5d), new Complex(-6d, -5.5d), new Complex(-3.5d, 9d));
            var v = ov.swizzle.gag;
            Assert.That(new Complex(-2d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, -6.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-7.5d, -7.5d), new Complex(4.5d, 0.5d), new Complex(-3d, -2d), new Complex(-5d, 1.0));
            var v = ov.swizzle.gagr;
            Assert.That(new Complex(4.5d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, 0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, 9.5d), new Complex(9.5d, -3d), new Complex(4d, 3.5d), new Complex(9d, 6d));
            var v = ov.swizzle.gagg;
            Assert.That(new Complex(9.5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5d, -3.5d), new Complex(8.5d, -9d), new Complex(-8d, -7d), new Complex(-1d, -3.5d));
            var v = ov.swizzle.gagb;
            Assert.That(new Complex(8.5d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -9d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5d, 3.5d), new Complex(-1d, -8d), new Complex(-2d, -3d), new Complex(-2d, -7d));
            var v = ov.swizzle.gaga;
            Assert.That(new Complex(-1d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4.5d, 3d), new Complex(-1d, 4.5d), new Complex(-5d, 5d), new Complex(0.0, 0.0));
            var v = ov.swizzle.gab;
            Assert.That(new Complex(-1d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, 5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(0.5d, -5.5d), new Complex(8.5d, -7.5d), new Complex(3d, 2.5d), new Complex(9d, 0.5d));
            var v = ov.swizzle.gabr;
            Assert.That(new Complex(8.5d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, 5.5d), new Complex(-4.5d, 1.5d), new Complex(2.5d, -5d), new Complex(-7.5d, -9d));
            var v = ov.swizzle.gabg;
            Assert.That(new Complex(-4.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, -5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4.5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, -9.5d), new Complex(5.5d, 8.5d), new Complex(-1.5d, -8.5d), new Complex(-2.5d, 0.5d));
            var v = ov.swizzle.gabb;
            Assert.That(new Complex(5.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, 5d), new Complex(-5d, -3d), new Complex(-4.5d, 6d), new Complex(8.5d, -2.5d));
            var v = ov.swizzle.gaba;
            Assert.That(new Complex(-5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7.5d, -8d), new Complex(-4d, -4.5d), new Complex(-7d, -1.5d), new Complex(-1.5d, -9d));
            var v = ov.swizzle.gaa;
            Assert.That(new Complex(-4d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, -9d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-1d, -6.5d), new Complex(-8.5d, -4d), new Complex(5.5d, -5d), new Complex(-1d, 2.5d));
            var v = ov.swizzle.gaar;
            Assert.That(new Complex(-8.5d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4.5d, 6.5d), new Complex(-7.5d, -8d), new Complex(5d, 7.5d), new Complex(-6.5d, -4.5d));
            var v = ov.swizzle.gaag;
            Assert.That(new Complex(-7.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.0, -5d), new Complex(-6d, 7.5d), new Complex(3.5d, -8.5d), new Complex(-9d, 9d));
            var v = ov.swizzle.gaab;
            Assert.That(new Complex(-6d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7.5d, -7d), new Complex(-6d, -8.5d), new Complex(5.5d, -3.5d), new Complex(-6.5d, 9.5d));
            var v = ov.swizzle.gaaa;
            Assert.That(new Complex(-6d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6.5d, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, 5.5d), new Complex(2d, -9.5d), new Complex(1.5d, 6d), new Complex(3d, 6d));
            var v = ov.swizzle.br;
            Assert.That(new Complex(1.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 5.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(6d, 6.5d), new Complex(-6.5d, -5d), new Complex(7.5d, -2.5d), new Complex(9d, -1.5d));
            var v = ov.swizzle.brr;
            Assert.That(new Complex(7.5d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 6.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(9d, 5.5d), new Complex(0.5d, -3.5d), new Complex(0.5d, -8.5d), new Complex(1.5d, -9.5d));
            var v = ov.swizzle.brrr;
            Assert.That(new Complex(0.5d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, -2d), new Complex(-3d, -4.5d), new Complex(-0.5d, 8.5d), new Complex(-1d, -6d));
            var v = ov.swizzle.brrg;
            Assert.That(new Complex(-0.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4.5d, 6d), new Complex(-3.5d, -2.5d), new Complex(-0.5d, -8d), new Complex(9d, 8d));
            var v = ov.swizzle.brrb;
            Assert.That(new Complex(-0.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3d, 4d), new Complex(2.5d, 9.5d), new Complex(-5d, 4.5d), new Complex(1.0, -6d));
            var v = ov.swizzle.brra;
            Assert.That(new Complex(-5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, -6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9d, 1.5d), new Complex(8d, -1.5d), new Complex(-7.5d, 1.0), new Complex(5.5d, -6.5d));
            var v = ov.swizzle.brg;
            Assert.That(new Complex(-7.5d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, -1.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(2d, -6d), new Complex(9d, 9d), new Complex(0.5d, -4d), new Complex(4d, -7.5d));
            var v = ov.swizzle.brgr;
            Assert.That(new Complex(0.5d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -6d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(2d, -6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9d, -2.5d), new Complex(1.0, 4d), new Complex(7d, -0.5d), new Complex(-9d, 6.5d));
            var v = ov.swizzle.brgg;
            Assert.That(new Complex(7d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, -9d), new Complex(-4d, -9.5d), new Complex(-8.5d, -8.5d), new Complex(-1.5d, 7d));
            var v = ov.swizzle.brgb;
            Assert.That(new Complex(-8.5d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, -2.5d), new Complex(-4.5d, -4.5d), new Complex(0.0, 4.5d), new Complex(4d, 7d));
            var v = ov.swizzle.brga;
            Assert.That(new Complex(0.0, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, 7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.5d, 7.5d), new Complex(-5d, -7d), new Complex(7.5d, -3d), new Complex(-2.5d, -0.5d));
            var v = ov.swizzle.brb;
            Assert.That(new Complex(7.5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, -3d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, 8.5d), new Complex(-6.5d, 2d), new Complex(-4.5d, 2d), new Complex(-1d, -2.5d));
            var v = ov.swizzle.brbr;
            Assert.That(new Complex(-4.5d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, 2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3.5d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2.5d, 2d), new Complex(-3.5d, -6d), new Complex(-9.5d, 2.5d), new Complex(7.5d, 6.5d));
            var v = ov.swizzle.brbg;
            Assert.That(new Complex(-9.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3.5d, -6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2.5d, -3.5d), new Complex(-0.5d, -0.5d), new Complex(-5.5d, -5d), new Complex(8.5d, 7d));
            var v = ov.swizzle.brbb;
            Assert.That(new Complex(-5.5d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, -5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, -5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.0, -1d), new Complex(2d, 1.0), new Complex(7d, 9d), new Complex(0.0, -5.5d));
            var v = ov.swizzle.brba;
            Assert.That(new Complex(7d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.0, -1d), new Complex(-4.5d, 6.5d), new Complex(-2d, 0.5d), new Complex(-4.5d, 5d));
            var v = ov.swizzle.bra;
            Assert.That(new Complex(-2d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, 5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(4d, 4.5d), new Complex(-1d, 0.0), new Complex(-2.5d, 7.5d), new Complex(-9.5d, -4.5d));
            var v = ov.swizzle.brar;
            Assert.That(new Complex(-2.5d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5d, 4d), new Complex(1.0, 7d), new Complex(-3.5d, -8.5d), new Complex(-8d, -9.5d));
            var v = ov.swizzle.brag;
            Assert.That(new Complex(-3.5d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, 7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, 2d), new Complex(-1d, -4.5d), new Complex(9d, -8d), new Complex(4d, -3d));
            var v = ov.swizzle.brab;
            Assert.That(new Complex(9d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, -6d), new Complex(4.5d, -2d), new Complex(8d, -7.5d), new Complex(-9.5d, -4d));
            var v = ov.swizzle.braa;
            Assert.That(new Complex(8d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, -6d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4.5d, 6d), new Complex(-9d, -5.5d), new Complex(-8d, -9.5d), new Complex(3.5d, -2d));
            var v = ov.swizzle.bg;
            Assert.That(new Complex(-8d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, -5.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, -2d), new Complex(9d, 3.5d), new Complex(2.5d, -1d), new Complex(3.5d, 0.5d));
            var v = ov.swizzle.bgr;
            Assert.That(new Complex(2.5d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, -2d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(0.5d, 4d), new Complex(-6.5d, -3d), new Complex(-3.5d, 5.5d), new Complex(-8.5d, -6.5d));
            var v = ov.swizzle.bgrr;
            Assert.That(new Complex(-3.5d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, -3d), new Complex(0.0, 8d), new Complex(3d, 4.5d), new Complex(5d, 8.5d));
            var v = ov.swizzle.bgrg;
            Assert.That(new Complex(3d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, 8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2d, -4.5d), new Complex(-3d, 5d), new Complex(-7.5d, 3.5d), new Complex(-6d, 5.5d));
            var v = ov.swizzle.bgrb;
            Assert.That(new Complex(-7.5d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5.5d, 5d), new Complex(4d, -6d), new Complex(5d, -8.5d), new Complex(-4.5d, 2.5d));
            var v = ov.swizzle.bgra;
            Assert.That(new Complex(5d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, -6d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, 4.5d), new Complex(2d, -1d), new Complex(5d, 1.5d), new Complex(-6d, 9.5d));
            var v = ov.swizzle.bgg;
            Assert.That(new Complex(5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -1d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, 8d), new Complex(-9.5d, 0.0), new Complex(-3.5d, 0.5d), new Complex(6d, 8.5d));
            var v = ov.swizzle.bggr;
            Assert.That(new Complex(-3.5d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, 8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3.5d, -9.5d), new Complex(-2.5d, 6.5d), new Complex(-6d, -7d), new Complex(-8.5d, -2.5d));
            var v = ov.swizzle.bggg;
            Assert.That(new Complex(-6d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, 6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7d, -5d), new Complex(-9d, -8d), new Complex(3d, 1.5d), new Complex(5.5d, 1.0));
            var v = ov.swizzle.bggb;
            Assert.That(new Complex(3d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, 0.5d), new Complex(4.5d, 6d), new Complex(0.5d, -9.5d), new Complex(-7.5d, 1.5d));
            var v = ov.swizzle.bgga;
            Assert.That(new Complex(0.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, -3d), new Complex(4d, 6.5d), new Complex(0.0, 4d), new Complex(1.5d, 2.5d));
            var v = ov.swizzle.bgb;
            Assert.That(new Complex(0.0, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, 4d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(6d, -1.5d), new Complex(3d, -8d), new Complex(1.0, -4.5d), new Complex(9.5d, 9d));
            var v = ov.swizzle.bgbr;
            Assert.That(new Complex(1.0, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, -7d), new Complex(2.5d, -2.5d), new Complex(-4.5d, 7d), new Complex(-9.5d, -0.5d));
            var v = ov.swizzle.bgbg;
            Assert.That(new Complex(-4.5d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4d, 0.0), new Complex(2.5d, -2.5d), new Complex(3.5d, -8d), new Complex(-8d, 9.5d));
            var v = ov.swizzle.bgbb;
            Assert.That(new Complex(3.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3d, 9.5d), new Complex(-6d, 9d), new Complex(-4d, -9.5d), new Complex(-1d, 2d));
            var v = ov.swizzle.bgba;
            Assert.That(new Complex(-4d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, -6.5d), new Complex(-9d, 4.5d), new Complex(-1.5d, 3d), new Complex(0.5d, -7d));
            var v = ov.swizzle.bga;
            Assert.That(new Complex(-1.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, -7d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, 1.5d), new Complex(-6.5d, 7d), new Complex(8.5d, -5.5d), new Complex(-5.5d, 6d));
            var v = ov.swizzle.bgar;
            Assert.That(new Complex(8.5d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8d, -2d), new Complex(-2.5d, 2.5d), new Complex(8.5d, 5d), new Complex(0.0, 6.5d));
            var v = ov.swizzle.bgag;
            Assert.That(new Complex(8.5d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4d, 5.5d), new Complex(-6.5d, 0.5d), new Complex(-1d, -8d), new Complex(4.5d, 5.5d));
            var v = ov.swizzle.bgab;
            Assert.That(new Complex(-1d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2d, 3d), new Complex(-4d, 9.5d), new Complex(9d, 8d), new Complex(-6d, -0.5d));
            var v = ov.swizzle.bgaa;
            Assert.That(new Complex(9d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, -0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, -0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, -3d), new Complex(-2.5d, -9.5d), new Complex(5.5d, -7.5d), new Complex(0.0, 0.5d));
            var v = ov.swizzle.bb;
            Assert.That(new Complex(5.5d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, -7.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(2d, -3.5d), new Complex(5.5d, -1.5d), new Complex(7d, -5.5d), new Complex(-5d, -1.5d));
            var v = ov.swizzle.bbr;
            Assert.That(new Complex(7d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -3.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, 0.0), new Complex(-4.5d, 2.5d), new Complex(0.5d, 9.5d), new Complex(2d, -8d));
            var v = ov.swizzle.bbrr;
            Assert.That(new Complex(0.5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-3.5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, -4.5d), new Complex(-9.5d, -6d), new Complex(-3.5d, 7d), new Complex(5.5d, -9d));
            var v = ov.swizzle.bbrg;
            Assert.That(new Complex(-3.5d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, -6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, 3.5d), new Complex(9d, -1.5d), new Complex(6d, 8.5d), new Complex(-5.5d, -9.5d));
            var v = ov.swizzle.bbrb;
            Assert.That(new Complex(6d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, 3.5d), new Complex(-8d, -9d), new Complex(0.5d, 5.5d), new Complex(-5.5d, -5.5d));
            var v = ov.swizzle.bbra;
            Assert.That(new Complex(0.5d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4.5d, -8.5d), new Complex(-5.5d, 9d), new Complex(5d, 1.5d), new Complex(0.5d, -1d));
            var v = ov.swizzle.bbg;
            Assert.That(new Complex(5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, 9d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-7.5d, 6d), new Complex(8.5d, -6.5d), new Complex(-6d, 3.5d), new Complex(0.5d, 0.0));
            var v = ov.swizzle.bbgr;
            Assert.That(new Complex(-6d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5d, 8.5d), new Complex(7.5d, 1.5d), new Complex(2.5d, -0.5d), new Complex(9d, 0.0));
            var v = ov.swizzle.bbgg;
            Assert.That(new Complex(2.5d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, -2d), new Complex(-2.5d, -1d), new Complex(-2.5d, -1.5d), new Complex(-0.5d, 3d));
            var v = ov.swizzle.bbgb;
            Assert.That(new Complex(-2.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, -7.5d), new Complex(-6.5d, 4.5d), new Complex(8.5d, 6d), new Complex(-6.5d, -9.5d));
            var v = ov.swizzle.bbga;
            Assert.That(new Complex(8.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6.5d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, 3.5d), new Complex(5.5d, -4.5d), new Complex(-8.5d, -1d), new Complex(4.5d, -9.5d));
            var v = ov.swizzle.bbb;
            Assert.That(new Complex(-8.5d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, -1d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(7.5d, -7.5d), new Complex(-5d, 8.5d), new Complex(-7d, 9.5d), new Complex(2.5d, -6d));
            var v = ov.swizzle.bbbr;
            Assert.That(new Complex(-7d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 8.5d), new Complex(-4.5d, -1.5d), new Complex(-1d, 3.5d), new Complex(9.5d, 4.5d));
            var v = ov.swizzle.bbbg;
            Assert.That(new Complex(-1d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4.5d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, -5.5d), new Complex(-1d, 6.5d), new Complex(6d, 9d), new Complex(-9d, -6d));
            var v = ov.swizzle.bbbb;
            Assert.That(new Complex(6d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, 5.5d), new Complex(-8d, -3d), new Complex(3.5d, -8.5d), new Complex(-2.5d, -8d));
            var v = ov.swizzle.bbba;
            Assert.That(new Complex(3.5d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8d, 6.5d), new Complex(0.0, 6.5d), new Complex(6.5d, -9.5d), new Complex(-7.5d, 4.5d));
            var v = ov.swizzle.bba;
            Assert.That(new Complex(6.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 4.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-2.5d, -3.5d), new Complex(-7d, 4d), new Complex(-2d, 4d), new Complex(0.5d, -6.5d));
            var v = ov.swizzle.bbar;
            Assert.That(new Complex(-2d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7.5d, 9.5d), new Complex(-8d, 5.5d), new Complex(8d, 6.5d), new Complex(-8.5d, 9.5d));
            var v = ov.swizzle.bbag;
            Assert.That(new Complex(8d, 6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, -3d), new Complex(7d, -3d), new Complex(-2.5d, 1.5d), new Complex(8.5d, 5.5d));
            var v = ov.swizzle.bbab;
            Assert.That(new Complex(-2.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2d, 7.5d), new Complex(-2d, -1d), new Complex(2.5d, -0.5d), new Complex(6d, 5d));
            var v = ov.swizzle.bbaa;
            Assert.That(new Complex(2.5d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, 5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, -8.5d), new Complex(-5.5d, -8d), new Complex(-6.5d, 0.0), new Complex(-8.5d, 9d));
            var v = ov.swizzle.ba;
            Assert.That(new Complex(-6.5d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 9d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, 6.5d), new Complex(2.5d, 5.5d), new Complex(-3d, -7d), new Complex(-3d, -4d));
            var v = ov.swizzle.bar;
            Assert.That(new Complex(-3d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, 6.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, 9.5d), new Complex(8d, 9d), new Complex(9.5d, 7d), new Complex(7.5d, 9d));
            var v = ov.swizzle.barr;
            Assert.That(new Complex(9.5d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, -3d), new Complex(-1d, -3.5d), new Complex(-4d, -7.5d), new Complex(5.5d, 4.5d));
            var v = ov.swizzle.barg;
            Assert.That(new Complex(-4d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, 5d), new Complex(8.5d, -7d), new Complex(6d, 2.5d), new Complex(-8.5d, -5d));
            var v = ov.swizzle.barb;
            Assert.That(new Complex(6d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3d, 2.5d), new Complex(-2.5d, -7d), new Complex(9d, -4d), new Complex(-0.5d, 2d));
            var v = ov.swizzle.bara;
            Assert.That(new Complex(9d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, 2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6d, 0.5d), new Complex(-0.5d, 3.5d), new Complex(-9.5d, -9d), new Complex(-0.5d, 8d));
            var v = ov.swizzle.bag;
            Assert.That(new Complex(-9.5d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, 3.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, 4d), new Complex(7d, -4d), new Complex(-6d, -7d), new Complex(-8d, -7.5d));
            var v = ov.swizzle.bagr;
            Assert.That(new Complex(-6d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4.5d, -6.5d), new Complex(-2.5d, -3d), new Complex(5d, 4.5d), new Complex(-4.5d, -9d));
            var v = ov.swizzle.bagg;
            Assert.That(new Complex(5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, 6.5d), new Complex(-6d, 7d), new Complex(5.5d, 8.5d), new Complex(4.5d, 0.5d));
            var v = ov.swizzle.bagb;
            Assert.That(new Complex(5.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3d, -3.5d), new Complex(8.5d, 1.5d), new Complex(9d, -8.5d), new Complex(-4d, -1.5d));
            var v = ov.swizzle.baga;
            Assert.That(new Complex(9d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9d, -2.5d), new Complex(-2d, -2.5d), new Complex(1.5d, -2.5d), new Complex(8d, -5.5d));
            var v = ov.swizzle.bab;
            Assert.That(new Complex(1.5d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, -2.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(3.5d, 1.5d), new Complex(1.5d, 7.5d), new Complex(9.5d, -0.5d), new Complex(4d, -8.5d));
            var v = ov.swizzle.babr;
            Assert.That(new Complex(9.5d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, -0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, -7d), new Complex(-2d, -3d), new Complex(2d, -2d), new Complex(4.5d, 3d));
            var v = ov.swizzle.babg;
            Assert.That(new Complex(2d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-5d, 1.0), new Complex(3.5d, 7.5d), new Complex(4d, -8d), new Complex(7.5d, 2d));
            var v = ov.swizzle.babb;
            Assert.That(new Complex(4d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3d, -4d), new Complex(-5.5d, 7d), new Complex(-0.5d, 8d), new Complex(-3d, -5.5d));
            var v = ov.swizzle.baba;
            Assert.That(new Complex(-0.5d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, 3.5d), new Complex(-8.5d, -5.5d), new Complex(-2d, -5.5d), new Complex(2d, 8.5d));
            var v = ov.swizzle.baa;
            Assert.That(new Complex(-2d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, 8.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(4d, -0.5d), new Complex(-0.5d, 3d), new Complex(-7d, 5.5d), new Complex(-6.5d, 6.5d));
            var v = ov.swizzle.baar;
            Assert.That(new Complex(-7d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, -0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2d, -6d), new Complex(-3d, 1.0), new Complex(-7d, -3.5d), new Complex(5d, 0.0));
            var v = ov.swizzle.baag;
            Assert.That(new Complex(-7d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, 1.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, 3.5d), new Complex(5.5d, -3.5d), new Complex(9d, -3d), new Complex(4d, 0.0));
            var v = ov.swizzle.baab;
            Assert.That(new Complex(9d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8.5d, 6d), new Complex(-1d, 3.5d), new Complex(5.5d, -8d), new Complex(2.5d, 7d));
            var v = ov.swizzle.baaa;
            Assert.That(new Complex(5.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, 7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7d, -5.5d), new Complex(-1d, 4.5d), new Complex(-4d, 3d), new Complex(-4d, 7d));
            var v = ov.swizzle.ar;
            Assert.That(new Complex(-4d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, -5.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, 8.5d), new Complex(-2d, 1.5d), new Complex(-1d, -5d), new Complex(-5.5d, 9.5d));
            var v = ov.swizzle.arr;
            Assert.That(new Complex(-5.5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, 8.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-1d, -2.5d), new Complex(8.5d, 5.5d), new Complex(-7.5d, -4d), new Complex(-9.5d, -9d));
            var v = ov.swizzle.arrr;
            Assert.That(new Complex(-9.5d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9d, -8.5d), new Complex(6.5d, 7.5d), new Complex(-8.5d, 4.5d), new Complex(8.5d, 3d));
            var v = ov.swizzle.arrg;
            Assert.That(new Complex(8.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.0, 0.0), new Complex(-1.5d, -3.5d), new Complex(3d, 2.5d), new Complex(4d, -3.5d));
            var v = ov.swizzle.arrb;
            Assert.That(new Complex(4d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4d, 9.5d), new Complex(-6d, 1.5d), new Complex(2d, 2d), new Complex(2.5d, -5d));
            var v = ov.swizzle.arra;
            Assert.That(new Complex(2.5d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, -5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4.5d, -2.5d), new Complex(7.5d, -2d), new Complex(-7d, 8d), new Complex(-9d, -6d));
            var v = ov.swizzle.arg;
            Assert.That(new Complex(-9d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, -2d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-5.5d, -7.5d), new Complex(0.0, -5d), new Complex(8.5d, 6.5d), new Complex(1.0, -9d));
            var v = ov.swizzle.argr;
            Assert.That(new Complex(1.0, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, -5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, 0.5d), new Complex(7.5d, 0.0), new Complex(4d, 7.5d), new Complex(-8.5d, 7.5d));
            var v = ov.swizzle.argg;
            Assert.That(new Complex(-8.5d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7d, -9d), new Complex(8.5d, -6d), new Complex(-8d, 9.5d), new Complex(2.5d, 8.5d));
            var v = ov.swizzle.argb;
            Assert.That(new Complex(2.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8d, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, -3.5d), new Complex(2.5d, 5.5d), new Complex(-3d, 7d), new Complex(3d, -9.5d));
            var v = ov.swizzle.arga;
            Assert.That(new Complex(3d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, -2.5d), new Complex(7.5d, 6d), new Complex(5.5d, -9.5d), new Complex(-9.5d, 5.5d));
            var v = ov.swizzle.arb;
            Assert.That(new Complex(-9.5d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, -9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-4d, -0.5d), new Complex(-2d, 9d), new Complex(3d, 7.5d), new Complex(9d, -8d));
            var v = ov.swizzle.arbr;
            Assert.That(new Complex(9d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, -0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 8.5d), new Complex(0.5d, -0.5d), new Complex(-8d, 5d), new Complex(1.5d, 3.5d));
            var v = ov.swizzle.arbg;
            Assert.That(new Complex(1.5d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(8d, -0.5d), new Complex(-8.5d, -1.5d), new Complex(-9d, -8.5d), new Complex(-2.5d, -3.5d));
            var v = ov.swizzle.arbb;
            Assert.That(new Complex(-2.5d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5.5d, -6.5d), new Complex(1.5d, 8.5d), new Complex(0.0, -5d), new Complex(-1d, 9d));
            var v = ov.swizzle.arba;
            Assert.That(new Complex(-1d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, -5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9.5d, 8.5d), new Complex(-9.5d, 3.5d), new Complex(1.5d, -0.5d), new Complex(-3d, -9.5d));
            var v = ov.swizzle.ara;
            Assert.That(new Complex(-3d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, -9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(1.5d, 8.5d), new Complex(9.5d, 7.5d), new Complex(0.5d, -6.5d), new Complex(1.0, -4.5d));
            var v = ov.swizzle.arar;
            Assert.That(new Complex(1.0, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.5d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(9d, -4.5d), new Complex(-1d, 3.5d), new Complex(-3.5d, 9.5d), new Complex(-7.5d, 4d));
            var v = ov.swizzle.arag;
            Assert.That(new Complex(-7.5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3d, -7.5d), new Complex(8.5d, -7.5d), new Complex(1.0, -4.5d), new Complex(7.5d, -9.5d));
            var v = ov.swizzle.arab;
            Assert.That(new Complex(7.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(1.0, 0.5d), new Complex(6.5d, -3d), new Complex(4d, -5.5d), new Complex(-3d, -1d));
            var v = ov.swizzle.araa;
            Assert.That(new Complex(-3d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, -1d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6.5d, -8d), new Complex(-0.5d, -7d), new Complex(4.5d, -9.5d), new Complex(8.5d, 0.0));
            var v = ov.swizzle.ag;
            Assert.That(new Complex(8.5d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, -7d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(-9d, 2.5d), new Complex(-4d, 4d), new Complex(-3d, 5d), new Complex(-3.5d, 0.5d));
            var v = ov.swizzle.agr;
            Assert.That(new Complex(-3.5d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, 2.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-9d, 2.5d), new Complex(1.5d, -3d), new Complex(7.5d, -6d), new Complex(-3.5d, -1.5d));
            var v = ov.swizzle.agrr;
            Assert.That(new Complex(-3.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2.5d, -9d), new Complex(1.0, 5.5d), new Complex(3d, -7.5d), new Complex(9d, 2.5d));
            var v = ov.swizzle.agrg;
            Assert.That(new Complex(9d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, -9d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5d, -6d), new Complex(-7.5d, 7.5d), new Complex(-1.5d, 7.5d), new Complex(-4d, 2.5d));
            var v = ov.swizzle.agrb;
            Assert.That(new Complex(-4d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8.5d, -3.5d), new Complex(2d, -1d), new Complex(9.5d, 3.5d), new Complex(6.5d, 4d));
            var v = ov.swizzle.agra;
            Assert.That(new Complex(6.5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3d, -1.5d), new Complex(6.5d, 1.0), new Complex(-1.5d, 8d), new Complex(-1d, 6d));
            var v = ov.swizzle.agg;
            Assert.That(new Complex(-1d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 1.0), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, 1.0), new Complex(-7.5d, 1.0), new Complex(-4.5d, 4.5d), new Complex(9.5d, 9d));
            var v = ov.swizzle.aggr;
            Assert.That(new Complex(9.5d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 1.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, 1.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2.5d, -3d), new Complex(-1.5d, 3d), new Complex(-4d, 2.5d), new Complex(-1d, -9.5d));
            var v = ov.swizzle.aggg;
            Assert.That(new Complex(-1d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, 3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, -4d), new Complex(3.5d, -1.5d), new Complex(3.5d, -2.5d), new Complex(-8d, 1.5d));
            var v = ov.swizzle.aggb;
            Assert.That(new Complex(-8d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2.5d, 0.5d), new Complex(3d, 1.5d), new Complex(-7.5d, 2.5d), new Complex(-9d, -2d));
            var v = ov.swizzle.agga;
            Assert.That(new Complex(-9d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4d, -8d), new Complex(0.0, 9d), new Complex(-0.5d, -4.5d), new Complex(1.0, -5.5d));
            var v = ov.swizzle.agb;
            Assert.That(new Complex(1.0, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, -4.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(4.5d, 8.5d), new Complex(1.5d, 3.5d), new Complex(2.5d, 1.0), new Complex(-9d, 3.5d));
            var v = ov.swizzle.agbr;
            Assert.That(new Complex(-9d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 1.0), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7d, -3d), new Complex(0.5d, 2.5d), new Complex(1.5d, -5.5d), new Complex(4.5d, 4d));
            var v = ov.swizzle.agbg;
            Assert.That(new Complex(4.5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, -5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, -5.5d), new Complex(8.5d, -5d), new Complex(4.5d, -1d), new Complex(-6.5d, 1.5d));
            var v = ov.swizzle.agbb;
            Assert.That(new Complex(-6.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, -1d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4.5d, 5.5d), new Complex(1.0, 6.5d), new Complex(6d, -3.5d), new Complex(7.5d, 1.5d));
            var v = ov.swizzle.agba;
            Assert.That(new Complex(7.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5d, -7d), new Complex(8.5d, 5d), new Complex(9.5d, -6d), new Complex(4d, -3d));
            var v = ov.swizzle.aga;
            Assert.That(new Complex(4d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, -3d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, 2d), new Complex(3.5d, 1.0), new Complex(-5.5d, -9d), new Complex(-2d, -2.5d));
            var v = ov.swizzle.agar;
            Assert.That(new Complex(-2d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, 2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, 9d), new Complex(-1d, 4d), new Complex(-2.5d, 2d), new Complex(-7d, 3.5d));
            var v = ov.swizzle.agag;
            Assert.That(new Complex(-7d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-9.5d, -8d), new Complex(-8.5d, -9d), new Complex(-7.5d, -4.5d), new Complex(3d, -6d));
            var v = ov.swizzle.agab;
            Assert.That(new Complex(3d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, -4d), new Complex(-3.5d, -6.5d), new Complex(-6d, 8d), new Complex(-1.5d, 8d));
            var v = ov.swizzle.agaa;
            Assert.That(new Complex(-1.5d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, 8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-0.5d, 9.5d), new Complex(5d, 9.5d), new Complex(1.5d, 5.5d), new Complex(6.5d, -9.5d));
            var v = ov.swizzle.ab;
            Assert.That(new Complex(6.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 5.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(6.5d, -9d), new Complex(-9.5d, -1.5d), new Complex(-8.5d, 5.5d), new Complex(-2.5d, 8.5d));
            var v = ov.swizzle.abr;
            Assert.That(new Complex(-2.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, -9d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(9.5d, -8d), new Complex(9d, 4.5d), new Complex(2.5d, 5.5d), new Complex(-4.5d, 1.5d));
            var v = ov.swizzle.abrr;
            Assert.That(new Complex(-4.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7.5d, 4d), new Complex(-4.5d, 0.0), new Complex(-3d, 2.5d), new Complex(-6d, -2d));
            var v = ov.swizzle.abrg;
            Assert.That(new Complex(-6d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4.5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.0, 4.5d), new Complex(-4.5d, -1d), new Complex(-4d, -7.5d), new Complex(1.0, 4.5d));
            var v = ov.swizzle.abrb;
            Assert.That(new Complex(1.0, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7d, -3d), new Complex(-9.5d, -2d), new Complex(0.5d, -6.5d), new Complex(7.5d, 8d));
            var v = ov.swizzle.abra;
            Assert.That(new Complex(7.5d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, 8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3d, -1.5d), new Complex(-4d, -0.5d), new Complex(-4d, -5.5d), new Complex(8d, 2d));
            var v = ov.swizzle.abg;
            Assert.That(new Complex(8d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -0.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-6d, -1.5d), new Complex(0.5d, 2.5d), new Complex(-7d, -5d), new Complex(9.5d, -3d));
            var v = ov.swizzle.abgr;
            Assert.That(new Complex(9.5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, -1.5d), new Complex(-9d, -8d), new Complex(7d, 0.5d), new Complex(9.5d, -7d));
            var v = ov.swizzle.abgg;
            Assert.That(new Complex(9.5d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 8d), new Complex(2d, 3.5d), new Complex(7d, 3.5d), new Complex(7d, -3d));
            var v = ov.swizzle.abgb;
            Assert.That(new Complex(7d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, 4d), new Complex(6.5d, -8.5d), new Complex(-3d, 9d), new Complex(-9d, -4d));
            var v = ov.swizzle.abga;
            Assert.That(new Complex(-9d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-8d, 8d), new Complex(1.0, 8d), new Complex(-9.5d, -0.5d), new Complex(5.5d, -8d));
            var v = ov.swizzle.abb;
            Assert.That(new Complex(5.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -0.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(7d, -5.5d), new Complex(6d, -1d), new Complex(2d, -9.5d), new Complex(-7.5d, 3d));
            var v = ov.swizzle.abbr;
            Assert.That(new Complex(-7.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-2d, 8.5d), new Complex(-4d, -2d), new Complex(-9.5d, 3.5d), new Complex(9d, -4.5d));
            var v = ov.swizzle.abbg;
            Assert.That(new Complex(9d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6d, -6d), new Complex(4.5d, -3.5d), new Complex(2.5d, -0.5d), new Complex(-7.5d, -1.5d));
            var v = ov.swizzle.abbb;
            Assert.That(new Complex(-7.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, -0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, -0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 1.0), new Complex(-3d, 0.5d), new Complex(-2d, 7d), new Complex(8d, -6.5d));
            var v = ov.swizzle.abba;
            Assert.That(new Complex(8d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(8d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(3.5d, -9d), new Complex(3.5d, -6.5d), new Complex(9.5d, 2d), new Complex(-8d, -5.5d));
            var v = ov.swizzle.aba;
            Assert.That(new Complex(-8d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, -5.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-7d, 8d), new Complex(-4d, -5d), new Complex(9d, 1.0), new Complex(8.5d, 0.0));
            var v = ov.swizzle.abar;
            Assert.That(new Complex(8.5d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, 8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, -6d), new Complex(6d, 6d), new Complex(0.5d, 0.5d), new Complex(-1d, 2.5d));
            var v = ov.swizzle.abag;
            Assert.That(new Complex(-1d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7d, 0.0), new Complex(-2d, 7d), new Complex(-9d, 8.5d), new Complex(2d, -7d));
            var v = ov.swizzle.abab;
            Assert.That(new Complex(2d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4.5d, 0.0), new Complex(-9d, 6d), new Complex(0.0, -6d), new Complex(9d, -5d));
            var v = ov.swizzle.abaa;
            Assert.That(new Complex(9d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, -6d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, -5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, -5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-1.5d, -1d), new Complex(5.5d, -2d), new Complex(-2.5d, -2d), new Complex(-3d, -5d));
            var v = ov.swizzle.aa;
            Assert.That(new Complex(-3d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec4(new Complex(8.5d, -5.5d), new Complex(8.5d, 4d), new Complex(-6.5d, 9.5d), new Complex(-2d, -7.5d));
            var v = ov.swizzle.aar;
            Assert.That(new Complex(-2d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -5.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-1d, 3d), new Complex(-3.5d, 4d), new Complex(1.0, 9d), new Complex(8.5d, -4d));
            var v = ov.swizzle.aarr;
            Assert.That(new Complex(8.5d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-4.5d, -1d), new Complex(3d, -5.5d), new Complex(-4.5d, 4.5d), new Complex(-5.5d, -4.5d));
            var v = ov.swizzle.aarg;
            Assert.That(new Complex(-5.5d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(2d, 6d), new Complex(2d, 2d), new Complex(-9d, 6d), new Complex(4.5d, 8d));
            var v = ov.swizzle.aarb;
            Assert.That(new Complex(4.5d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7.5d, 9d), new Complex(4d, -9d), new Complex(4d, -4.5d), new Complex(5d, 0.5d));
            var v = ov.swizzle.aara;
            Assert.That(new Complex(5d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, -8.5d), new Complex(8d, 9.5d), new Complex(2d, -6.5d), new Complex(4d, 6d));
            var v = ov.swizzle.aag;
            Assert.That(new Complex(4d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, 9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-5d, -3.5d), new Complex(0.5d, -1d), new Complex(-1.5d, -1.5d), new Complex(-2.5d, 4.5d));
            var v = ov.swizzle.aagr;
            Assert.That(new Complex(-2.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-3d, -2d), new Complex(1.0, 0.5d), new Complex(-8.5d, -3d), new Complex(8.5d, 7d));
            var v = ov.swizzle.aagg;
            Assert.That(new Complex(8.5d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(6d, 9d), new Complex(-3.5d, -4.5d), new Complex(-9.5d, 0.0), new Complex(-9d, 4d));
            var v = ov.swizzle.aagb;
            Assert.That(new Complex(-9d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, -6d), new Complex(7.5d, -9d), new Complex(-2.5d, 4.5d), new Complex(1.5d, -1d));
            var v = ov.swizzle.aaga;
            Assert.That(new Complex(1.5d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, -9d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.5d, -1d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(4d, 5.5d), new Complex(2.5d, -7d), new Complex(-3.5d, -8.5d), new Complex(3d, -4d));
            var v = ov.swizzle.aab;
            Assert.That(new Complex(3d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -8.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-3.5d, -4d), new Complex(5.5d, -3d), new Complex(0.0, 7d), new Complex(1.5d, 5.5d));
            var v = ov.swizzle.aabr;
            Assert.That(new Complex(1.5d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3.5d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(Complex.Zero, new Complex(6d, 7d), new Complex(-3d, 5d), new Complex(-6.5d, -0.5d));
            var v = ov.swizzle.aabg;
            Assert.That(new Complex(-6.5d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, 7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(0.5d, -5.5d), new Complex(-8.5d, -9.5d), new Complex(-0.5d, 4.5d), new Complex(-0.5d, -7.5d));
            var v = ov.swizzle.aabb;
            Assert.That(new Complex(-0.5d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(5.5d, -9d), new Complex(-9d, 1.5d), new Complex(6.5d, 6.5d), new Complex(-9.5d, 3.5d));
            var v = ov.swizzle.aaba;
            Assert.That(new Complex(-9.5d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(7.5d, -7d), new Complex(-4d, -5d), new Complex(-4.5d, 9.5d), new Complex(-6.5d, -8d));
            var v = ov.swizzle.aaa;
            Assert.That(new Complex(-6.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, -8d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, -1d), new Complex(-2.5d, -2.5d), new Complex(-8d, -4d), new Complex(-6d, -7.5d));
            var v = ov.swizzle.aaar;
            Assert.That(new Complex(-6d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6.5d, -1d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, 2d), Complex.One, new Complex(3d, 1.5d), new Complex(9.5d, 0.5d));
            var v = ov.swizzle.aaag;
            Assert.That(new Complex(9.5d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, 0.5d), Is.EqualTo(v.z));
            Assert.That(Complex.One, Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-7d, -5.5d), new Complex(-4d, -5d), new Complex(0.0, 2.5d), new Complex(1.5d, 4d));
            var v = ov.swizzle.aaab;
            Assert.That(new Complex(1.5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec4(new Complex(-6.5d, -9d), new Complex(9.5d, 9d), new Complex(-8d, 3.5d), new Complex(-9.5d, -3d));
            var v = ov.swizzle.aaaa;
            Assert.That(new Complex(-9.5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, -3d), Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new cvec4(new Complex(-4.5d, 7d), new Complex(-3d, 3d), new Complex(4d, -2d), new Complex(-3.5d, 6d));
            var v1 = new cvec2(new Complex(7.5d, 0.0), new Complex(-5d, -7d));
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(7.5d, 0.0), Is.EqualTo(v0.x));
            Assert.That(new Complex(-5d, -7d), Is.EqualTo(v0.y));
            Assert.That(new Complex(4d, -2d), Is.EqualTo(v0.z));
            Assert.That(new Complex(-3.5d, 6d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(-4.5d, 7d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-3d, 3d), Is.EqualTo(v2.y));
        }
        {
            var v0 = new cvec4(new Complex(2.5d, 6.5d), new Complex(2d, -3d), new Complex(-7d, 6d), new Complex(0.0, 1.0));
            var v1 = new cvec2(new Complex(-2d, -7d), new Complex(-8d, -1.5d));
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-2d, -7d), Is.EqualTo(v0.x));
            Assert.That(new Complex(2d, -3d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-8d, -1.5d), Is.EqualTo(v0.z));
            Assert.That(new Complex(0.0, 1.0), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(2.5d, 6.5d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-7d, 6d), Is.EqualTo(v2.y));
        }
        {
            var v0 = new cvec4(new Complex(5d, -3.5d), new Complex(-2d, 7d), new Complex(-2.5d, 8.5d), new Complex(-3.5d, -7d));
            var v1 = new cvec2(new Complex(-1d, 0.5d), new Complex(3d, 4.5d));
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(5d, -3.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-1d, 0.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(3d, 4.5d), Is.EqualTo(v0.z));
            Assert.That(new Complex(-3.5d, -7d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(-2d, 7d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-2.5d, 8.5d), Is.EqualTo(v2.y));
        }
        {
            var v0 = new cvec4(new Complex(7.5d, -6d), new Complex(-3.5d, 0.0), new Complex(5.5d, 6d), new Complex(5d, -7d));
            var v1 = new cvec3(new Complex(-0.5d, 2.5d), new Complex(9d, 9d), new Complex(6d, 1.5d));
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-0.5d, 2.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(9d, 9d), Is.EqualTo(v0.y));
            Assert.That(new Complex(6d, 1.5d), Is.EqualTo(v0.z));
            Assert.That(new Complex(5d, -7d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(7.5d, -6d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-3.5d, 0.0), Is.EqualTo(v2.y));
            Assert.That(new Complex(5.5d, 6d), Is.EqualTo(v2.z));
        }
        {
            var v0 = new cvec4(new Complex(8.5d, 6d), new Complex(-7.5d, 2.5d), new Complex(-7.5d, -4d), new Complex(-8.5d, -2d));
            var v1 = new cvec2(new Complex(-6.5d, 4.5d), new Complex(2.5d, -9d));
            var v2 = v0.xw;
            v0.xw = v1;
            var v3 = v0.xw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-6.5d, 4.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-7.5d, 2.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-7.5d, -4d), Is.EqualTo(v0.z));
            Assert.That(new Complex(2.5d, -9d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(8.5d, 6d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-8.5d, -2d), Is.EqualTo(v2.y));
        }
        {
            var v0 = new cvec4(new Complex(1.0, 9.5d), new Complex(-2d, -2.5d), new Complex(3.5d, -7d), new Complex(-1d, -7d));
            var v1 = new cvec2(new Complex(9.5d, -9d), new Complex(2d, 5d));
            var v2 = v0.yw;
            v0.yw = v1;
            var v3 = v0.yw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(1.0, 9.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(9.5d, -9d), Is.EqualTo(v0.y));
            Assert.That(new Complex(3.5d, -7d), Is.EqualTo(v0.z));
            Assert.That(new Complex(2d, 5d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(-2d, -2.5d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-1d, -7d), Is.EqualTo(v2.y));
        }
        {
            var v0 = new cvec4(new Complex(-2d, 4d), new Complex(4.5d, -5.5d), new Complex(-3.5d, -1.5d), new Complex(-4.5d, 6.5d));
            var v1 = new cvec3(new Complex(0.5d, -6.5d), new Complex(3.5d, -2d), new Complex(-6d, -8.5d));
            var v2 = v0.xyw;
            v0.xyw = v1;
            var v3 = v0.xyw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(0.5d, -6.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(3.5d, -2d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-3.5d, -1.5d), Is.EqualTo(v0.z));
            Assert.That(new Complex(-6d, -8.5d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(-2d, 4d), Is.EqualTo(v2.x));
            Assert.That(new Complex(4.5d, -5.5d), Is.EqualTo(v2.y));
            Assert.That(new Complex(-4.5d, 6.5d), Is.EqualTo(v2.z));
        }
        {
            var v0 = new cvec4(new Complex(-7d, 0.5d), new Complex(1.5d, -1d), new Complex(8d, 7d), new Complex(-5d, 5.5d));
            var v1 = new cvec2(new Complex(-6.5d, -1.5d), new Complex(8d, 9d));
            var v2 = v0.zw;
            v0.zw = v1;
            var v3 = v0.zw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-7d, 0.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(1.5d, -1d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-6.5d, -1.5d), Is.EqualTo(v0.z));
            Assert.That(new Complex(8d, 9d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(8d, 7d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-5d, 5.5d), Is.EqualTo(v2.y));
        }
        {
            var v0 = new cvec4(new Complex(4d, 1.0), new Complex(-1d, 9.5d), new Complex(7d, -0.5d), new Complex(-4.5d, 7d));
            var v1 = new cvec3(new Complex(8d, -2d), new Complex(-9d, -1.5d), new Complex(-6.5d, -1d));
            var v2 = v0.xzw;
            v0.xzw = v1;
            var v3 = v0.xzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(8d, -2d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-1d, 9.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-9d, -1.5d), Is.EqualTo(v0.z));
            Assert.That(new Complex(-6.5d, -1d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(4d, 1.0), Is.EqualTo(v2.x));
            Assert.That(new Complex(7d, -0.5d), Is.EqualTo(v2.y));
            Assert.That(new Complex(-4.5d, 7d), Is.EqualTo(v2.z));
        }
        {
            var v0 = new cvec4(new Complex(5.5d, 2d), new Complex(-9d, -3d), new Complex(8.5d, 4.5d), new Complex(2.5d, -5.5d));
            var v1 = new cvec3(new Complex(-1d, -9.5d), new Complex(-7.5d, 1.0), new Complex(3.5d, -2d));
            var v2 = v0.yzw;
            v0.yzw = v1;
            var v3 = v0.yzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(5.5d, 2d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-1d, -9.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-7.5d, 1.0), Is.EqualTo(v0.z));
            Assert.That(new Complex(3.5d, -2d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(-9d, -3d), Is.EqualTo(v2.x));
            Assert.That(new Complex(8.5d, 4.5d), Is.EqualTo(v2.y));
            Assert.That(new Complex(2.5d, -5.5d), Is.EqualTo(v2.z));
        }
        {
            var v0 = new cvec4(new Complex(7d, -6.5d), new Complex(9d, -5d), new Complex(5d, 8.5d), new Complex(-3d, 8d));
            var v1 = new cvec4(new Complex(0.0, -0.5d), new Complex(-1.5d, -9d), new Complex(-5.5d, 8d), new Complex(9.5d, -4.5d));
            var v2 = v0.xyzw;
            v0.xyzw = v1;
            var v3 = v0.xyzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(0.0, -0.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-1.5d, -9d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-5.5d, 8d), Is.EqualTo(v0.z));
            Assert.That(new Complex(9.5d, -4.5d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(7d, -6.5d), Is.EqualTo(v2.x));
            Assert.That(new Complex(9d, -5d), Is.EqualTo(v2.y));
            Assert.That(new Complex(5d, 8.5d), Is.EqualTo(v2.z));
            Assert.That(new Complex(-3d, 8d), Is.EqualTo(v2.w));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            cvec4 v0 = new cvec4(new Complex(-3.5d, -1.5d), new Complex(9d, -1d), new Complex(6d, 1.0), new Complex(7d, 3.5d));
            Complex v1 = new Complex(-4.5d, 9d);
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-4.5d, 9d), Is.EqualTo(v0.x));
            Assert.That(new Complex(9d, -1d), Is.EqualTo(v0.y));
            Assert.That(new Complex(6d, 1.0), Is.EqualTo(v0.z));
            Assert.That(new Complex(7d, 3.5d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(-3.5d, -1.5d), Is.EqualTo(v2));
        }
        {
            cvec4 v0 = new cvec4(new Complex(-2.5d, 8.5d), new Complex(-7d, 6d), new Complex(-9d, -3d), new Complex(-0.5d, -1.5d));
            Complex v1 = new Complex(-6d, 0.0);
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-2.5d, 8.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-6d, 0.0), Is.EqualTo(v0.y));
            Assert.That(new Complex(-9d, -3d), Is.EqualTo(v0.z));
            Assert.That(new Complex(-0.5d, -1.5d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(-7d, 6d), Is.EqualTo(v2));
        }
        {
            cvec4 v0 = new cvec4(new Complex(0.0, -1d), new Complex(6d, -5d), new Complex(6.5d, -9d), new Complex(-6.5d, -0.5d));
            cvec2 v1 = new cvec2(new Complex(-4.5d, -8.5d), new Complex(-8.5d, 1.5d));
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-4.5d, -8.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-8.5d, 1.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(6.5d, -9d), Is.EqualTo(v0.z));
            Assert.That(new Complex(-6.5d, -0.5d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(0.0, -1d), Is.EqualTo(v2.x));
            Assert.That(new Complex(6d, -5d), Is.EqualTo(v2.y));
        }
        {
            cvec4 v0 = new cvec4(new Complex(3.5d, -6d), new Complex(6.5d, 4.5d), new Complex(9d, -2.5d), new Complex(-8d, 9.5d));
            Complex v1 = new Complex(-6d, -7d);
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(3.5d, -6d), Is.EqualTo(v0.x));
            Assert.That(new Complex(6.5d, 4.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-6d, -7d), Is.EqualTo(v0.z));
            Assert.That(new Complex(-8d, 9.5d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(9d, -2.5d), Is.EqualTo(v2));
        }
        {
            cvec4 v0 = new cvec4(new Complex(0.5d, 7d), new Complex(0.5d, 2d), new Complex(-8.5d, 8.5d), new Complex(0.5d, -1.5d));
            cvec2 v1 = new cvec2(new Complex(-7.5d, -2.5d), new Complex(3d, -9d));
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-7.5d, -2.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(0.5d, 2d), Is.EqualTo(v0.y));
            Assert.That(new Complex(3d, -9d), Is.EqualTo(v0.z));
            Assert.That(new Complex(0.5d, -1.5d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(0.5d, 7d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-8.5d, 8.5d), Is.EqualTo(v2.y));
        }
        {
            cvec4 v0 = new cvec4(new Complex(-5d, -9d), new Complex(1.5d, 9d), new Complex(-7d, 6d), new Complex(1.5d, 1.0));
            cvec2 v1 = new cvec2(new Complex(6.5d, -8d), new Complex(-8d, 0.0));
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-5d, -9d), Is.EqualTo(v0.x));
            Assert.That(new Complex(6.5d, -8d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-8d, 0.0), Is.EqualTo(v0.z));
            Assert.That(new Complex(1.5d, 1.0), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(1.5d, 9d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-7d, 6d), Is.EqualTo(v2.y));
        }
        {
            cvec4 v0 = new cvec4(new Complex(6d, -8d), new Complex(-1d, -9.5d), new Complex(7.5d, 7d), new Complex(-4.5d, 9d));
            cvec3 v1 = new cvec3(new Complex(-8.5d, -7.5d), new Complex(5d, 5.5d), new Complex(-2.5d, 0.0));
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-8.5d, -7.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(5d, 5.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-2.5d, 0.0), Is.EqualTo(v0.z));
            Assert.That(new Complex(-4.5d, 9d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(6d, -8d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-1d, -9.5d), Is.EqualTo(v2.y));
            Assert.That(new Complex(7.5d, 7d), Is.EqualTo(v2.z));
        }
        {
            cvec4 v0 = new cvec4(new Complex(-7.5d, 6d), new Complex(-7d, -0.5d), new Complex(4d, -7d), new Complex(-8.5d, 8.5d));
            Complex v1 = new Complex(8.5d, 3.5d);
            var v2 = v0.a;
            v0.a = v1;
            var v3 = v0.a;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-7.5d, 6d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-7d, -0.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(4d, -7d), Is.EqualTo(v0.z));
            Assert.That(new Complex(8.5d, 3.5d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(-8.5d, 8.5d), Is.EqualTo(v2));
        }
        {
            cvec4 v0 = new cvec4(new Complex(5d, -2.5d), new Complex(7.5d, 6.5d), new Complex(-8.5d, -5d), new Complex(3.5d, -3d));
            cvec2 v1 = new cvec2(new Complex(1.0, -9.5d), new Complex(-5.5d, 1.0));
            var v2 = v0.ra;
            v0.ra = v1;
            var v3 = v0.ra;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(1.0, -9.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(7.5d, 6.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-8.5d, -5d), Is.EqualTo(v0.z));
            Assert.That(new Complex(-5.5d, 1.0), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(5d, -2.5d), Is.EqualTo(v2.x));
            Assert.That(new Complex(3.5d, -3d), Is.EqualTo(v2.y));
        }
        {
            cvec4 v0 = new cvec4(new Complex(0.0, -7.5d), new Complex(7.5d, 6.5d), new Complex(1.5d, 3d), new Complex(6.5d, 4.5d));
            cvec2 v1 = new cvec2(new Complex(6.5d, -8.5d), new Complex(-9.5d, 7d));
            var v2 = v0.ga;
            v0.ga = v1;
            var v3 = v0.ga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(0.0, -7.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(6.5d, -8.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(1.5d, 3d), Is.EqualTo(v0.z));
            Assert.That(new Complex(-9.5d, 7d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(7.5d, 6.5d), Is.EqualTo(v2.x));
            Assert.That(new Complex(6.5d, 4.5d), Is.EqualTo(v2.y));
        }
        {
            cvec4 v0 = new cvec4(new Complex(-4.5d, 3d), new Complex(-8d, 5d), new Complex(2d, -9.5d), new Complex(-5.5d, -7d));
            cvec3 v1 = new cvec3(new Complex(1.0, -3.5d), new Complex(-1.5d, 2d), new Complex(-3d, -9d));
            var v2 = v0.rga;
            v0.rga = v1;
            var v3 = v0.rga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(1.0, -3.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-1.5d, 2d), Is.EqualTo(v0.y));
            Assert.That(new Complex(2d, -9.5d), Is.EqualTo(v0.z));
            Assert.That(new Complex(-3d, -9d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(-4.5d, 3d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-8d, 5d), Is.EqualTo(v2.y));
            Assert.That(new Complex(-5.5d, -7d), Is.EqualTo(v2.z));
        }
        {
            cvec4 v0 = new cvec4(new Complex(-5.5d, 8.5d), new Complex(3d, 2.5d), new Complex(-0.5d, -4d), new Complex(-0.5d, 8.5d));
            cvec2 v1 = new cvec2(new Complex(-3d, 6d), new Complex(-1.5d, -3d));
            var v2 = v0.ba;
            v0.ba = v1;
            var v3 = v0.ba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-5.5d, 8.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(3d, 2.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-3d, 6d), Is.EqualTo(v0.z));
            Assert.That(new Complex(-1.5d, -3d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(-0.5d, -4d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-0.5d, 8.5d), Is.EqualTo(v2.y));
        }
        {
            cvec4 v0 = new cvec4(new Complex(6.5d, -7.5d), new Complex(-2d, 1.5d), new Complex(0.5d, 6.5d), new Complex(-6.5d, -3.5d));
            cvec3 v1 = new cvec3(new Complex(6.5d, 3.5d), new Complex(8.5d, -1.5d), new Complex(-4.5d, -1.5d));
            var v2 = v0.rba;
            v0.rba = v1;
            var v3 = v0.rba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(6.5d, 3.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-2d, 1.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(8.5d, -1.5d), Is.EqualTo(v0.z));
            Assert.That(new Complex(-4.5d, -1.5d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(6.5d, -7.5d), Is.EqualTo(v2.x));
            Assert.That(new Complex(0.5d, 6.5d), Is.EqualTo(v2.y));
            Assert.That(new Complex(-6.5d, -3.5d), Is.EqualTo(v2.z));
        }
        {
            cvec4 v0 = new cvec4(new Complex(8d, 2d), new Complex(-6.5d, 5d), new Complex(-5.5d, 9.5d), new Complex(-5.5d, 0.5d));
            cvec3 v1 = new cvec3(new Complex(-6.5d, 4d), new Complex(-7.5d, 5d), new Complex(-0.5d, -1.5d));
            var v2 = v0.gba;
            v0.gba = v1;
            var v3 = v0.gba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(8d, 2d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-6.5d, 4d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-7.5d, 5d), Is.EqualTo(v0.z));
            Assert.That(new Complex(-0.5d, -1.5d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(-6.5d, 5d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-5.5d, 9.5d), Is.EqualTo(v2.y));
            Assert.That(new Complex(-5.5d, 0.5d), Is.EqualTo(v2.z));
        }
        {
            cvec4 v0 = new cvec4(new Complex(3.5d, 5d), new Complex(0.5d, -8d), new Complex(8.5d, -7.5d), new Complex(-3.5d, 6.5d));
            cvec4 v1 = new cvec4(new Complex(9d, -5.5d), new Complex(-4d, 9.5d), new Complex(-7d, 8.5d), new Complex(0.0, 3d));
            var v2 = v0.rgba;
            v0.rgba = v1;
            var v3 = v0.rgba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(9d, -5.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-4d, 9.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-7d, 8.5d), Is.EqualTo(v0.z));
            Assert.That(new Complex(0.0, 3d), Is.EqualTo(v0.w));
        
            Assert.That(new Complex(3.5d, 5d), Is.EqualTo(v2.x));
            Assert.That(new Complex(0.5d, -8d), Is.EqualTo(v2.y));
            Assert.That(new Complex(8.5d, -7.5d), Is.EqualTo(v2.z));
            Assert.That(new Complex(-3.5d, 6.5d), Is.EqualTo(v2.w));
        }
    }

}
