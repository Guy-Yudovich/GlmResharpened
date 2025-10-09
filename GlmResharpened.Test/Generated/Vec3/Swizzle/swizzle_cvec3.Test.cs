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
public class ComplexSwizzleVec3Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new cvec3(new Complex(1.0, 8d), new Complex(-1.5d, 5.5d), new Complex(5.5d, 2d));
            var v = ov.swizzle.xx;
            Assert.That(new Complex(1.0, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 8d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(5d, -8.5d), new Complex(5d, 6d), new Complex(2d, 4d));
            var v = ov.swizzle.xxx;
            Assert.That(new Complex(5d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, -8.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(7d, 9d), new Complex(4d, 8.5d), new Complex(-0.5d, -7d));
            var v = ov.swizzle.xxxx;
            Assert.That(new Complex(7d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-8.5d, 5d), new Complex(-1.5d, -2.5d), new Complex(-1.5d, 2d));
            var v = ov.swizzle.xxxy;
            Assert.That(new Complex(-8.5d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, 5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-8.5d, 8.5d), new Complex(-6d, 5.5d), new Complex(7.5d, -3.5d));
            var v = ov.swizzle.xxxz;
            Assert.That(new Complex(-8.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(1.5d, -0.5d), new Complex(-0.5d, 3d), new Complex(-5.5d, -2d));
            var v = ov.swizzle.xxy;
            Assert.That(new Complex(1.5d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, 3d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(3d, 0.0), new Complex(1.0, -9.5d), new Complex(1.5d, -6d));
            var v = ov.swizzle.xxyx;
            Assert.That(new Complex(3d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-9d, 2.5d), new Complex(-2.5d, 5.5d), new Complex(0.5d, -5d));
            var v = ov.swizzle.xxyy;
            Assert.That(new Complex(-9d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-9d, -2.5d), new Complex(1.5d, 8.5d), new Complex(-0.5d, -5.5d));
            var v = ov.swizzle.xxyz;
            Assert.That(new Complex(-9d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(9d, -3.5d), new Complex(0.0, -7.5d), new Complex(-9.5d, 4d));
            var v = ov.swizzle.xxz;
            Assert.That(new Complex(9d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, 4d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-8.5d, 5d), new Complex(-8.5d, 5.5d), new Complex(-4.5d, 0.5d));
            var v = ov.swizzle.xxzx;
            Assert.That(new Complex(-8.5d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, 0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, 5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(9.5d, -5.5d), new Complex(-1d, -1.5d), new Complex(-6.5d, -3.5d));
            var v = ov.swizzle.xxzy;
            Assert.That(new Complex(9.5d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(8d, 3d), new Complex(4.5d, 9d), new Complex(0.5d, -6.5d));
            var v = ov.swizzle.xxzz;
            Assert.That(new Complex(8d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(3d, 6d), new Complex(-9.5d, -7d), new Complex(2.5d, 3d));
            var v = ov.swizzle.xy;
            Assert.That(new Complex(3d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, -7d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(5.5d, 1.5d), new Complex(-7.5d, -4d), new Complex(-1d, 4.5d));
            var v = ov.swizzle.xyx;
            Assert.That(new Complex(5.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, 1.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(8.5d, 2d), new Complex(1.0, 8d), new Complex(-1d, 0.0));
            var v = ov.swizzle.xyxx;
            Assert.That(new Complex(8.5d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 2d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, 2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-5d, -7d), new Complex(0.0, 7.5d), new Complex(-4d, 8d));
            var v = ov.swizzle.xyxy;
            Assert.That(new Complex(-5d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(8.5d, 9d), new Complex(5d, 4.5d), new Complex(-6d, -2d));
            var v = ov.swizzle.xyxz;
            Assert.That(new Complex(8.5d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-5.5d, 9.5d), new Complex(-7.5d, -7d), new Complex(0.0, 8.5d));
            var v = ov.swizzle.xyy;
            Assert.That(new Complex(-5.5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, -7d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(4d, -3.5d), new Complex(-3.5d, 3.5d), new Complex(-4d, 8d));
            var v = ov.swizzle.xyyx;
            Assert.That(new Complex(4d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-3d, -9.5d), new Complex(7.5d, -5.5d), new Complex(4d, -5d));
            var v = ov.swizzle.xyyy;
            Assert.That(new Complex(-3d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, -5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(9d, 9d), Complex.Zero, new Complex(6d, 0.5d));
            var v = ov.swizzle.xyyz;
            Assert.That(new Complex(9d, 9d), Is.EqualTo(v.x));
            Assert.That(Complex.Zero, Is.EqualTo(v.y));
            Assert.That(Complex.Zero, Is.EqualTo(v.z));
            Assert.That(new Complex(6d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(2d, -1d), new Complex(-7.5d, -5d), new Complex(5d, 4d));
            var v = ov.swizzle.xyz;
            Assert.That(new Complex(2d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 4d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-4d, 8.5d), new Complex(-6.5d, -5.5d), new Complex(4.5d, 4.5d));
            var v = ov.swizzle.xyzx;
            Assert.That(new Complex(-4d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(3.5d, -1.5d), new Complex(9.5d, 4.5d), new Complex(-7.5d, 2d));
            var v = ov.swizzle.xyzy;
            Assert.That(new Complex(3.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 2d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(9.5d, -2d), new Complex(-5.5d, 0.0), new Complex(5d, -9d));
            var v = ov.swizzle.xyzz;
            Assert.That(new Complex(9.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, -9d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, -9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-9d, -8d), new Complex(-8.5d, -4.5d), new Complex(0.5d, -1.5d));
            var v = ov.swizzle.xz;
            Assert.That(new Complex(-9d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, -1.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(-9d, -7.5d), new Complex(5.5d, 8d), new Complex(9.5d, -4.5d));
            var v = ov.swizzle.xzx;
            Assert.That(new Complex(-9d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, -7.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(5d, 4.5d), new Complex(-7.5d, 6.5d), new Complex(-5d, 9.5d));
            var v = ov.swizzle.xzxx;
            Assert.That(new Complex(5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(9d, -6d), new Complex(-5d, -7.5d), new Complex(-0.5d, -2d));
            var v = ov.swizzle.xzxy;
            Assert.That(new Complex(9d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-7.5d, -3.5d), new Complex(3d, -6d), new Complex(7d, -4d));
            var v = ov.swizzle.xzxz;
            Assert.That(new Complex(-7.5d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-7d, -3d), new Complex(0.5d, -2.5d), new Complex(-7.5d, 3.5d));
            var v = ov.swizzle.xzy;
            Assert.That(new Complex(-7d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, -2.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-2.5d, -2.5d), new Complex(-3.5d, -9d), new Complex(-7.5d, -4d));
            var v = ov.swizzle.xzyx;
            Assert.That(new Complex(-2.5d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -9d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(4d, 2d), new Complex(5.5d, 0.5d), new Complex(-9d, 3.5d));
            var v = ov.swizzle.xzyy;
            Assert.That(new Complex(4d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, 0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(4d, 4.5d), new Complex(0.0, -7d), new Complex(-8d, -3d));
            var v = ov.swizzle.xzyz;
            Assert.That(new Complex(4d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-9d, -5d), new Complex(4d, -9d), new Complex(6d, 0.0));
            var v = ov.swizzle.xzz;
            Assert.That(new Complex(-9d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 0.0), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(4.5d, 9d), new Complex(-4.5d, -1.5d), new Complex(8.5d, -6d));
            var v = ov.swizzle.xzzx;
            Assert.That(new Complex(4.5d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, -6d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(5.5d, -9d), new Complex(-3.5d, 7d), new Complex(5d, 6d));
            var v = ov.swizzle.xzzy;
            Assert.That(new Complex(5.5d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3.5d, 7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-6.5d, -9.5d), new Complex(3.5d, 7.5d), new Complex(2d, -4d));
            var v = ov.swizzle.xzzz;
            Assert.That(new Complex(-6.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -4d), Is.EqualTo(v.z));
            Assert.That(new Complex(2d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(4d, 0.5d), new Complex(3d, -4d), new Complex(-8d, 2d));
            var v = ov.swizzle.yx;
            Assert.That(new Complex(3d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 0.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(1.5d, 0.5d), new Complex(2.5d, 4.5d), new Complex(6d, 1.5d));
            var v = ov.swizzle.yxx;
            Assert.That(new Complex(2.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 0.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-6d, 3.5d), new Complex(2.5d, -2d), new Complex(-9.5d, 6d));
            var v = ov.swizzle.yxxx;
            Assert.That(new Complex(2.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-2.5d, -8d), new Complex(-7d, -3d), new Complex(9d, 4d));
            var v = ov.swizzle.yxxy;
            Assert.That(new Complex(-7d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(9.5d, 9d), new Complex(-2d, -6.5d), new Complex(7.5d, -8.5d));
            var v = ov.swizzle.yxxz;
            Assert.That(new Complex(-2d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-5.5d, 5d), new Complex(-5d, -4d), new Complex(-4.5d, 4.5d));
            var v = ov.swizzle.yxy;
            Assert.That(new Complex(-5d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, -4d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-1d, 3.5d), new Complex(-4d, -3.5d), new Complex(4.5d, 0.5d));
            var v = ov.swizzle.yxyx;
            Assert.That(new Complex(-4d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-7.5d, 9d), new Complex(-2.5d, -9.5d), new Complex(-8d, -5d));
            var v = ov.swizzle.yxyy;
            Assert.That(new Complex(-2.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(8d, 6.5d), new Complex(-6d, 6d), new Complex(-0.5d, 3.5d));
            var v = ov.swizzle.yxyz;
            Assert.That(new Complex(-6d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(0.5d, 5.5d), new Complex(-2.5d, 6d), new Complex(-8d, 8d));
            var v = ov.swizzle.yxz;
            Assert.That(new Complex(-2.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, 8d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(2d, 5d), new Complex(3.5d, 3.5d), new Complex(6.5d, -0.5d));
            var v = ov.swizzle.yxzx;
            Assert.That(new Complex(3.5d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, -0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2d, 5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-9.5d, -8d), new Complex(-7.5d, 4.5d), new Complex(-6.5d, 3d));
            var v = ov.swizzle.yxzy;
            Assert.That(new Complex(-7.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(4d, 9d), new Complex(-3d, -2d), new Complex(2d, 3.5d));
            var v = ov.swizzle.yxzz;
            Assert.That(new Complex(-3d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-3d, 0.0), new Complex(-0.5d, 1.0), new Complex(8d, 4d));
            var v = ov.swizzle.yy;
            Assert.That(new Complex(-0.5d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, 1.0), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(8.5d, 6d), new Complex(1.5d, 6.5d), new Complex(-1.5d, 5d));
            var v = ov.swizzle.yyx;
            Assert.That(new Complex(1.5d, 6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 6d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(6.5d, 5.5d), new Complex(4.5d, 9.5d), new Complex(-4d, 3d));
            var v = ov.swizzle.yyxx;
            Assert.That(new Complex(4.5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(0.0, 3.5d), new Complex(-2d, -2d), new Complex(-1d, 2.5d));
            var v = ov.swizzle.yyxy;
            Assert.That(new Complex(-2d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-9.5d, -2d), new Complex(-2d, -4.5d), new Complex(-9.5d, 9d));
            var v = ov.swizzle.yyxz;
            Assert.That(new Complex(-2d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(7d, -6.5d), new Complex(-6.5d, -9.5d), new Complex(-6d, 3.5d));
            var v = ov.swizzle.yyy;
            Assert.That(new Complex(-6.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, -9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(9.5d, -2.5d), new Complex(-7.5d, 1.5d), new Complex(-7d, -3.5d));
            var v = ov.swizzle.yyyx;
            Assert.That(new Complex(-7.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-7d, 7.5d), new Complex(-4.5d, 7.5d), new Complex(5d, 3d));
            var v = ov.swizzle.yyyy;
            Assert.That(new Complex(-4.5d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4.5d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(1.0, 6.5d), new Complex(-4.5d, 9d), new Complex(-6.5d, -9.5d));
            var v = ov.swizzle.yyyz;
            Assert.That(new Complex(-4.5d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6.5d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-3d, -6d), new Complex(-9d, 0.5d), new Complex(-0.5d, -1.5d));
            var v = ov.swizzle.yyz;
            Assert.That(new Complex(-9d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, -1.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-5d, -5d), new Complex(-9d, 4.5d), new Complex(1.0, 9.5d));
            var v = ov.swizzle.yyzx;
            Assert.That(new Complex(-9d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, -5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-7.5d, 9.5d), new Complex(8.5d, 2.5d), new Complex(-4.5d, -4.5d));
            var v = ov.swizzle.yyzy;
            Assert.That(new Complex(8.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-3.5d, -6.5d), new Complex(-5.5d, 3d), new Complex(5.5d, -6.5d));
            var v = ov.swizzle.yyzz;
            Assert.That(new Complex(-5.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(0.5d, 8d), new Complex(-3d, 1.0), new Complex(-8.5d, 6d));
            var v = ov.swizzle.yz;
            Assert.That(new Complex(-3d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 6d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(-6d, -1.5d), new Complex(0.5d, 0.0), new Complex(-5d, 2.5d));
            var v = ov.swizzle.yzx;
            Assert.That(new Complex(0.5d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, -1.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(6d, -4d), new Complex(-7.5d, 4.5d), new Complex(-7.5d, 6d));
            var v = ov.swizzle.yzxx;
            Assert.That(new Complex(-7.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, -4d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-7d, -7d), new Complex(-2d, 2.5d), new Complex(9.5d, -4d));
            var v = ov.swizzle.yzxy;
            Assert.That(new Complex(-2d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(6d, 8d), new Complex(4d, -7.5d), new Complex(0.5d, -9.5d));
            var v = ov.swizzle.yzxz;
            Assert.That(new Complex(4d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-3.5d, 7d), new Complex(5.5d, 2d), new Complex(3d, 1.0));
            var v = ov.swizzle.yzy;
            Assert.That(new Complex(5.5d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, 2d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(2d, 9.5d), new Complex(6.5d, 8d), new Complex(6d, -4.5d));
            var v = ov.swizzle.yzyx;
            Assert.That(new Complex(6.5d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(2d, 9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(4d, -5.5d), new Complex(-5.5d, -7d), new Complex(-6d, 7d));
            var v = ov.swizzle.yzyy;
            Assert.That(new Complex(-5.5d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-5.5d, -6d), new Complex(-3.5d, -8d), new Complex(2.5d, -8d));
            var v = ov.swizzle.yzyz;
            Assert.That(new Complex(-3.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(8d, 0.5d), new Complex(7.5d, -3d), new Complex(-3d, 2.5d));
            var v = ov.swizzle.yzz;
            Assert.That(new Complex(7.5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, 2.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(4.5d, -4.5d), new Complex(-8.5d, 9.5d), new Complex(9.5d, -7d));
            var v = ov.swizzle.yzzx;
            Assert.That(new Complex(-8.5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-8.5d, 9d), new Complex(9d, -6d), new Complex(9d, -1.5d));
            var v = ov.swizzle.yzzy;
            Assert.That(new Complex(9d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, -6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(6.5d, -9d), new Complex(1.0, 7d), new Complex(5.5d, 6.5d));
            var v = ov.swizzle.yzzz;
            Assert.That(new Complex(1.0, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, 6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(0.5d, -1d), new Complex(5.5d, -7.5d), new Complex(2d, -4d));
            var v = ov.swizzle.zx;
            Assert.That(new Complex(2d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, -1d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(1.0, -2d), new Complex(5.5d, 8.5d), new Complex(6d, 5.5d));
            var v = ov.swizzle.zxx;
            Assert.That(new Complex(6d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, -2d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(0.5d, -4d), new Complex(8d, 4d), new Complex(-5d, 9d));
            var v = ov.swizzle.zxxx;
            Assert.That(new Complex(-5d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, -4d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-2d, -9d), new Complex(6.5d, 2.5d), new Complex(3d, -1.5d));
            var v = ov.swizzle.zxxy;
            Assert.That(new Complex(3d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, -9d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-7.5d, -8.5d), new Complex(-6.5d, -7.5d), new Complex(-2.5d, 4.5d));
            var v = ov.swizzle.zxxz;
            Assert.That(new Complex(-2.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-1.5d, 6.5d), new Complex(-4.5d, -6.5d), new Complex(-1.5d, -5.5d));
            var v = ov.swizzle.zxy;
            Assert.That(new Complex(-1.5d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, -6.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(4d, 7.5d), new Complex(2.5d, -3d), new Complex(3d, -8.5d));
            var v = ov.swizzle.zxyx;
            Assert.That(new Complex(3d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-6.5d, -5d), new Complex(7.5d, -5.5d), new Complex(-4.5d, -7.5d));
            var v = ov.swizzle.zxyy;
            Assert.That(new Complex(-4.5d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, -5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7.5d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(8d, -3d), new Complex(-7.5d, 2.5d), new Complex(0.5d, 2.5d));
            var v = ov.swizzle.zxyz;
            Assert.That(new Complex(0.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(9.5d, 6.5d), new Complex(-4.5d, 8.5d), new Complex(5.5d, 5d));
            var v = ov.swizzle.zxz;
            Assert.That(new Complex(5.5d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, 5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-9.5d, 0.5d), new Complex(-0.5d, -1.5d), new Complex(3.5d, 3.5d));
            var v = ov.swizzle.zxzx;
            Assert.That(new Complex(3.5d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(7d, 5d), new Complex(-3d, -0.5d), new Complex(0.0, -4.5d));
            var v = ov.swizzle.zxzy;
            Assert.That(new Complex(0.0, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, -0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(4d, 9d), new Complex(3d, 9d), new Complex(-1.5d, -9d));
            var v = ov.swizzle.zxzz;
            Assert.That(new Complex(-1.5d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, -9d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, -9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(8d, 9d), new Complex(4.5d, 1.0), new Complex(-8d, -2d));
            var v = ov.swizzle.zy;
            Assert.That(new Complex(-8d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, 1.0), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(-8d, 5d), new Complex(7.5d, -2d), new Complex(0.0, -9d));
            var v = ov.swizzle.zyx;
            Assert.That(new Complex(0.0, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, 5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(9d, 1.0), new Complex(-3d, 2d), new Complex(8.5d, -8d));
            var v = ov.swizzle.zyxx;
            Assert.That(new Complex(8.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, 1.0), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, 1.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-2d, -8.5d), new Complex(2.5d, -4d), new Complex(-5.5d, 2.5d));
            var v = ov.swizzle.zyxy;
            Assert.That(new Complex(-5.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-7.5d, 3d), new Complex(1.5d, -9.5d), new Complex(8d, 5.5d));
            var v = ov.swizzle.zyxz;
            Assert.That(new Complex(8d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(8d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(2.5d, -4d), new Complex(6d, 3.5d), new Complex(7.5d, 8.5d));
            var v = ov.swizzle.zyy;
            Assert.That(new Complex(7.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 3.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-7d, 2.5d), new Complex(2.5d, 9.5d), new Complex(-4d, 4d));
            var v = ov.swizzle.zyyx;
            Assert.That(new Complex(-4d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-7d, 2d), new Complex(0.5d, -7d), new Complex(-6.5d, 5d));
            var v = ov.swizzle.zyyy;
            Assert.That(new Complex(-6.5d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-9.5d, 3d), new Complex(1.5d, -1.5d), new Complex(7d, 1.0));
            var v = ov.swizzle.zyyz;
            Assert.That(new Complex(7d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, 1.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(9d, 5.5d), new Complex(-5d, -3d), new Complex(9d, 0.5d));
            var v = ov.swizzle.zyz;
            Assert.That(new Complex(9d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, 0.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-2.5d, 7d), new Complex(-5.5d, -4.5d), new Complex(-7.5d, -1d));
            var v = ov.swizzle.zyzx;
            Assert.That(new Complex(-7.5d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, 7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(0.0, 3d), new Complex(6.5d, -1.5d), new Complex(8.5d, -1d));
            var v = ov.swizzle.zyzy;
            Assert.That(new Complex(8.5d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-3.5d, 8d), new Complex(5d, 6d), new Complex(0.0, 9d));
            var v = ov.swizzle.zyzz;
            Assert.That(new Complex(0.0, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-4.5d, 1.0), new Complex(9.5d, -1d), new Complex(9d, -2.5d));
            var v = ov.swizzle.zz;
            Assert.That(new Complex(9d, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -2.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(2.5d, -5d), new Complex(-1.5d, -4d), new Complex(3.5d, -4.5d));
            var v = ov.swizzle.zzx;
            Assert.That(new Complex(3.5d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, -5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-1d, -1d), new Complex(8.5d, -3.5d), new Complex(8.5d, 8d));
            var v = ov.swizzle.zzxx;
            Assert.That(new Complex(8.5d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -1d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-5.5d, 6.5d), new Complex(-5d, 2.5d), new Complex(5d, 3.5d));
            var v = ov.swizzle.zzxy;
            Assert.That(new Complex(5d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(2d, -2.5d), new Complex(-2.5d, -7d), new Complex(-1d, -1d));
            var v = ov.swizzle.zzxz;
            Assert.That(new Complex(-1d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -1d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-5d, -2d), new Complex(2.5d, 6d), new Complex(3d, -6.5d));
            var v = ov.swizzle.zzy;
            Assert.That(new Complex(3d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 6d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(5.5d, 5d), new Complex(8.5d, 1.0), new Complex(5d, -8.5d));
            var v = ov.swizzle.zzyx;
            Assert.That(new Complex(5d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 1.0), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, 5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(3.5d, -7d), new Complex(9.5d, 6d), new Complex(7.5d, -0.5d));
            var v = ov.swizzle.zzyy;
            Assert.That(new Complex(7.5d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-1.5d, -4.5d), new Complex(-4.5d, -3d), new Complex(7d, -3.5d));
            var v = ov.swizzle.zzyz;
            Assert.That(new Complex(7d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(2d, -9.5d), new Complex(-8.5d, 8.5d), new Complex(4.5d, 2.5d));
            var v = ov.swizzle.zzz;
            Assert.That(new Complex(4.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, 2.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-1d, -5.5d), new Complex(6d, 2d), new Complex(1.0, -4.5d));
            var v = ov.swizzle.zzzx;
            Assert.That(new Complex(1.0, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(7.5d, -3.5d), new Complex(2.5d, 1.5d), new Complex(3.5d, -1.5d));
            var v = ov.swizzle.zzzy;
            Assert.That(new Complex(3.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(3d, -5d), new Complex(-5.5d, -1.5d), new Complex(2d, 0.0));
            var v = ov.swizzle.zzzz;
            Assert.That(new Complex(2d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, 0.0), Is.EqualTo(v.z));
            Assert.That(new Complex(2d, 0.0), Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new cvec3(new Complex(8.5d, -5.5d), new Complex(8d, -3.5d), new Complex(-5.5d, 1.0));
            var v = ov.swizzle.rr;
            Assert.That(new Complex(8.5d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, -5.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(-8d, -2d), new Complex(6.5d, -9d), new Complex(-6.5d, -1.5d));
            var v = ov.swizzle.rrr;
            Assert.That(new Complex(-8d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, -2d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-9d, -2d), new Complex(5d, 5.5d), new Complex(-1.5d, 3.5d));
            var v = ov.swizzle.rrrr;
            Assert.That(new Complex(-9d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(1.5d, -1d), new Complex(-6d, -8d), new Complex(-4.5d, 4.5d));
            var v = ov.swizzle.rrrg;
            Assert.That(new Complex(1.5d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-6d, 8d), new Complex(6.5d, 8d), new Complex(4d, -5.5d));
            var v = ov.swizzle.rrrb;
            Assert.That(new Complex(-6d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-5.5d, -8d), new Complex(-5d, -0.5d), new Complex(9d, 8d));
            var v = ov.swizzle.rrg;
            Assert.That(new Complex(-5.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, -0.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(3d, -3.5d), new Complex(-8.5d, 0.5d), new Complex(8.5d, 2d));
            var v = ov.swizzle.rrgr;
            Assert.That(new Complex(3d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, 0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-9d, 2.5d), new Complex(7d, -5d), new Complex(-0.5d, -7.5d));
            var v = ov.swizzle.rrgg;
            Assert.That(new Complex(-9d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, -5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(0.5d, 3.5d), new Complex(-7d, -3.5d), new Complex(-2d, -4d));
            var v = ov.swizzle.rrgb;
            Assert.That(new Complex(0.5d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-5.5d, -4d), new Complex(9d, -6d), new Complex(-1.5d, 2.5d));
            var v = ov.swizzle.rrb;
            Assert.That(new Complex(-5.5d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, 2.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(6.5d, 7.5d), new Complex(-7d, 5.5d), new Complex(-7d, -3.5d));
            var v = ov.swizzle.rrbr;
            Assert.That(new Complex(6.5d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, -3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-6d, 0.5d), new Complex(5.5d, -9.5d), new Complex(-4.5d, -8.5d));
            var v = ov.swizzle.rrbg;
            Assert.That(new Complex(-6d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(0.0, 1.0), new Complex(3d, -9d), new Complex(-6d, -8.5d));
            var v = ov.swizzle.rrbb;
            Assert.That(new Complex(0.0, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(8d, 7d), new Complex(5d, -6.5d), new Complex(1.0, -9.5d));
            var v = ov.swizzle.rg;
            Assert.That(new Complex(8d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, -6.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(7d, -3.5d), new Complex(-5.5d, 5d), new Complex(7d, -2.5d));
            var v = ov.swizzle.rgr;
            Assert.That(new Complex(7d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -3.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(4.5d, -8d), new Complex(-5d, 9d), new Complex(-0.5d, -2d));
            var v = ov.swizzle.rgrr;
            Assert.That(new Complex(4.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(6.5d, -5d), new Complex(-9.5d, 9d), new Complex(-0.5d, -3d));
            var v = ov.swizzle.rgrg;
            Assert.That(new Complex(6.5d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, -5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(6.5d, 8d), new Complex(9d, -5d), new Complex(-4d, -2d));
            var v = ov.swizzle.rgrb;
            Assert.That(new Complex(6.5d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, -2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(1.5d, 2.5d), new Complex(-9d, -0.5d), new Complex(1.0, 9d));
            var v = ov.swizzle.rgg;
            Assert.That(new Complex(1.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9d, -0.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(4.5d, -9.5d), new Complex(-2.5d, -8d), new Complex(-9d, 0.5d));
            var v = ov.swizzle.rggr;
            Assert.That(new Complex(4.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-2d, -3d), new Complex(4.5d, 7.5d), new Complex(6.5d, -9d));
            var v = ov.swizzle.rggg;
            Assert.That(new Complex(-2d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(Complex.One, new Complex(4.5d, -3d), new Complex(8.5d, -6.5d));
            var v = ov.swizzle.rggb;
            Assert.That(Complex.One, Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(8d, 5d), new Complex(9.5d, -9d), new Complex(0.0, -3.5d));
            var v = ov.swizzle.rgb;
            Assert.That(new Complex(8d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, -3.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-9.5d, 2d), new Complex(-5.5d, -4d), new Complex(-2d, 8d));
            var v = ov.swizzle.rgbr;
            Assert.That(new Complex(-9.5d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, -4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, 2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(3.5d, -1.5d), new Complex(5.5d, -8d), new Complex(-6d, 4d));
            var v = ov.swizzle.rgbg;
            Assert.That(new Complex(3.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(6.5d, -8.5d), new Complex(-2d, 4d), new Complex(-5.5d, 9d));
            var v = ov.swizzle.rgbb;
            Assert.That(new Complex(6.5d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-8.5d, 2.5d), new Complex(6.5d, -5d), new Complex(2d, -4d));
            var v = ov.swizzle.rb;
            Assert.That(new Complex(-8.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -4d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(-6.5d, 1.0), new Complex(-2.5d, 8.5d), new Complex(0.5d, 6d));
            var v = ov.swizzle.rbr;
            Assert.That(new Complex(-6.5d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 1.0), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(9.5d, -9.5d), new Complex(0.0, -2.5d), new Complex(7d, -8d));
            var v = ov.swizzle.rbrr;
            Assert.That(new Complex(9.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(3d, -3d), new Complex(-5.5d, 8.5d), new Complex(-6d, -0.5d));
            var v = ov.swizzle.rbrg;
            Assert.That(new Complex(3d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-5.5d, 9d), new Complex(5d, -7.5d), new Complex(-7d, 0.0));
            var v = ov.swizzle.rbrb;
            Assert.That(new Complex(-5.5d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(6.5d, 0.5d), new Complex(6.5d, 4.5d), new Complex(-1d, -3.5d));
            var v = ov.swizzle.rbg;
            Assert.That(new Complex(6.5d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 4.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(5d, 0.0), new Complex(7d, -4.5d), new Complex(-0.5d, 2.5d));
            var v = ov.swizzle.rbgr;
            Assert.That(new Complex(5d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 0.0), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(9d, 4d), new Complex(-3.5d, -1d), new Complex(-5d, 1.5d));
            var v = ov.swizzle.rbgg;
            Assert.That(new Complex(9d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3.5d, -1d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-1.5d, -5.5d), new Complex(-7d, 9d), new Complex(5.5d, 5.5d));
            var v = ov.swizzle.rbgb;
            Assert.That(new Complex(-1.5d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-8d, 1.0), new Complex(2d, -9d), new Complex(-4d, 6.5d));
            var v = ov.swizzle.rbb;
            Assert.That(new Complex(-8d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, 6.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(8.5d, 6d), new Complex(5.5d, -1d), new Complex(7d, -6.5d));
            var v = ov.swizzle.rbbr;
            Assert.That(new Complex(8.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-8d, 0.0), new Complex(-3d, -4.5d), new Complex(1.5d, 2d));
            var v = ov.swizzle.rbbg;
            Assert.That(new Complex(-8d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-7d, -5d), new Complex(-0.5d, -1d), new Complex(6d, 7.5d));
            var v = ov.swizzle.rbbb;
            Assert.That(new Complex(-7d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(6d, -1d), new Complex(0.0, -9d), new Complex(3.5d, -5.5d));
            var v = ov.swizzle.gr;
            Assert.That(new Complex(0.0, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, -1d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(1.5d, 2d), new Complex(4d, 0.5d), new Complex(-5d, -9d));
            var v = ov.swizzle.grr;
            Assert.That(new Complex(4d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.5d, 2d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 2d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-5.5d, 6.5d), new Complex(5.5d, 3.5d), new Complex(-8d, 0.5d));
            var v = ov.swizzle.grrr;
            Assert.That(new Complex(5.5d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, 6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, 6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(5.5d, 7d), new Complex(6.5d, 7.5d), new Complex(8.5d, -5.5d));
            var v = ov.swizzle.grrg;
            Assert.That(new Complex(6.5d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(4d, -7d), new Complex(1.5d, -8d), new Complex(3d, -8d));
            var v = ov.swizzle.grrb;
            Assert.That(new Complex(1.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(4.5d, -7d), new Complex(-2d, -4.5d), new Complex(-1d, 2d));
            var v = ov.swizzle.grg;
            Assert.That(new Complex(-2d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, -4.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-2.5d, -7.5d), new Complex(4.5d, -8d), new Complex(-1d, -2.5d));
            var v = ov.swizzle.grgr;
            Assert.That(new Complex(4.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(4.5d, -1d), new Complex(-7.5d, -6d), new Complex(8.5d, 7d));
            var v = ov.swizzle.grgg;
            Assert.That(new Complex(-7.5d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, -1d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, -6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, -6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(3.5d, -7.5d), new Complex(5d, 6d), new Complex(-0.5d, -2.5d));
            var v = ov.swizzle.grgb;
            Assert.That(new Complex(5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(8d, 4d), new Complex(6d, 7d), new Complex(2.5d, 6.5d));
            var v = ov.swizzle.grb;
            Assert.That(new Complex(6d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, 6.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-4.5d, 7.5d), new Complex(-9.5d, -3d), new Complex(7d, -7.5d));
            var v = ov.swizzle.grbr;
            Assert.That(new Complex(-9.5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4.5d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(3d, -3.5d), new Complex(8.5d, 0.5d), new Complex(7d, 3d));
            var v = ov.swizzle.grbg;
            Assert.That(new Complex(8.5d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(6.5d, 8d), new Complex(-9d, 2d), new Complex(-8.5d, -8d));
            var v = ov.swizzle.grbb;
            Assert.That(new Complex(-9d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(0.0, -1d), new Complex(3d, -4.5d), new Complex(-8.5d, -7d));
            var v = ov.swizzle.gg;
            Assert.That(new Complex(3d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3d, -4.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(-8d, 3d), new Complex(-7.5d, 4.5d), new Complex(5d, -8.5d));
            var v = ov.swizzle.ggr;
            Assert.That(new Complex(-7.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, 3d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-6d, -3d), new Complex(3.5d, -1.5d), new Complex(3d, 1.5d));
            var v = ov.swizzle.ggrr;
            Assert.That(new Complex(3.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(4d, 2d), new Complex(-6.5d, -6.5d), new Complex(0.0, 7.5d));
            var v = ov.swizzle.ggrg;
            Assert.That(new Complex(-6.5d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -6.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, 2d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6.5d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-9.5d, 8.5d), new Complex(-0.5d, 2.5d), new Complex(4.5d, 2.5d));
            var v = ov.swizzle.ggrb;
            Assert.That(new Complex(-0.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(6.5d, 9d), new Complex(-2d, 9.5d), new Complex(-9d, 3d));
            var v = ov.swizzle.ggg;
            Assert.That(new Complex(-2d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, 9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(5.5d, -6d), new Complex(7.5d, -8.5d), new Complex(9.5d, -5.5d));
            var v = ov.swizzle.gggr;
            Assert.That(new Complex(7.5d, -8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5.5d, -6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-4.5d, 2.5d), new Complex(-6d, 0.5d), new Complex(-0.5d, -5.5d));
            var v = ov.swizzle.gggg;
            Assert.That(new Complex(-6d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, 0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-4.5d, 3.5d), new Complex(9d, 7d), new Complex(-7d, -7.5d));
            var v = ov.swizzle.gggb;
            Assert.That(new Complex(9d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(1.5d, 0.0), new Complex(0.0, -1.5d), new Complex(2.5d, -1.5d));
            var v = ov.swizzle.ggb;
            Assert.That(new Complex(0.0, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, -1.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(6.5d, -4d), new Complex(8.5d, 8d), new Complex(3.5d, -6.5d));
            var v = ov.swizzle.ggbr;
            Assert.That(new Complex(8.5d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, -4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-0.5d, -5.5d), new Complex(-2.5d, 9d), new Complex(0.5d, 1.5d));
            var v = ov.swizzle.ggbg;
            Assert.That(new Complex(-2.5d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2.5d, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(0.5d, 9d), new Complex(-7d, 4d), new Complex(9.5d, -8.5d));
            var v = ov.swizzle.ggbb;
            Assert.That(new Complex(-7d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(2.5d, -4.5d), new Complex(-8d, 6d), new Complex(-2d, -8d));
            var v = ov.swizzle.gb;
            Assert.That(new Complex(-8d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, -8d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(-4.5d, 4.5d), new Complex(3d, 9.5d), new Complex(-6.5d, -5.5d));
            var v = ov.swizzle.gbr;
            Assert.That(new Complex(3d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, 4.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(1.5d, 7.5d), new Complex(4d, 7.5d), new Complex(0.5d, -8.5d));
            var v = ov.swizzle.gbrr;
            Assert.That(new Complex(4d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.5d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.5d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-3d, -0.5d), new Complex(7d, -7d), new Complex(-3.5d, -1.5d));
            var v = ov.swizzle.gbrg;
            Assert.That(new Complex(7d, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, -0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-1.5d, 9.5d), new Complex(0.0, 0.5d), new Complex(-8.5d, -7.5d));
            var v = ov.swizzle.gbrb;
            Assert.That(new Complex(0.0, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-8.5d, 4.5d), new Complex(-5d, -8d), new Complex(-2.5d, 4.5d));
            var v = ov.swizzle.gbg;
            Assert.That(new Complex(-5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, -8d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(1.5d, 2.5d), new Complex(2.5d, -1d), new Complex(-3d, -5.5d));
            var v = ov.swizzle.gbgr;
            Assert.That(new Complex(2.5d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-1.5d, 8.5d), new Complex(-4.5d, -3d), new Complex(2.5d, 7.5d));
            var v = ov.swizzle.gbgg;
            Assert.That(new Complex(-4.5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4.5d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-2d, 3d), new Complex(7d, -0.5d), new Complex(-4.5d, -5d));
            var v = ov.swizzle.gbgb;
            Assert.That(new Complex(7d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4.5d, -5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(7d, -5d), new Complex(1.5d, -5d), new Complex(2d, -9.5d));
            var v = ov.swizzle.gbb;
            Assert.That(new Complex(1.5d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(3d, 8.5d), new Complex(5d, 8.5d), new Complex(5.5d, 5.5d));
            var v = ov.swizzle.gbbr;
            Assert.That(new Complex(5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5.5d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-9d, -7.5d), new Complex(2d, -0.5d), new Complex(-9.5d, -2d));
            var v = ov.swizzle.gbbg;
            Assert.That(new Complex(2d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(2d, -0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-1.5d, 3d), new Complex(9.5d, 8.5d), new Complex(-2d, -0.5d));
            var v = ov.swizzle.gbbb;
            Assert.That(new Complex(9.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, -0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, -0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(5d, 7.5d), new Complex(3.5d, 6.5d), new Complex(4d, 8d));
            var v = ov.swizzle.br;
            Assert.That(new Complex(4d, 8d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 7.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(-2.5d, 1.0), new Complex(-8d, 8d), new Complex(3.5d, -2d));
            var v = ov.swizzle.brr;
            Assert.That(new Complex(3.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, 1.0), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(5d, 7.5d), new Complex(7d, -3d), new Complex(7.5d, -6d));
            var v = ov.swizzle.brrr;
            Assert.That(new Complex(7.5d, -6d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-2d, 8.5d), new Complex(7d, -1.5d), new Complex(-2d, -0.5d));
            var v = ov.swizzle.brrg;
            Assert.That(new Complex(-2d, -0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(2d, 5.5d), new Complex(8.5d, -8d), new Complex(-5.5d, 4.5d));
            var v = ov.swizzle.brrb;
            Assert.That(new Complex(-5.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, 5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-3.5d, 5.5d), new Complex(3d, -5.5d), new Complex(2.5d, 3.5d));
            var v = ov.swizzle.brg;
            Assert.That(new Complex(2.5d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, -5.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-9d, -8.5d), new Complex(-4d, -0.5d), new Complex(6.5d, -1d));
            var v = ov.swizzle.brgr;
            Assert.That(new Complex(6.5d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, -0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(8.5d, 9d), new Complex(-5.5d, -9.5d), new Complex(-4d, -6.5d));
            var v = ov.swizzle.brgg;
            Assert.That(new Complex(-4d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5.5d, -9.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-2.5d, 8.5d), new Complex(8d, -1.5d), new Complex(1.0, -7d));
            var v = ov.swizzle.brgb;
            Assert.That(new Complex(1.0, -7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(0.5d, 3.5d), new Complex(9d, -5d), new Complex(8.5d, 0.0));
            var v = ov.swizzle.brb;
            Assert.That(new Complex(8.5d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(0.5d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 0.0), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(1.0, 7d), new Complex(3.5d, 0.5d), new Complex(-5d, -9.5d));
            var v = ov.swizzle.brbr;
            Assert.That(new Complex(-5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(1.0, 7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-6d, 3d), new Complex(-4.5d, 2.5d), new Complex(8.5d, -5d));
            var v = ov.swizzle.brbg;
            Assert.That(new Complex(8.5d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4.5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(8d, -3d), new Complex(1.0, 4.5d), new Complex(7d, 2d));
            var v = ov.swizzle.brbb;
            Assert.That(new Complex(7d, 2d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, 2d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, 2d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(9.5d, -3.5d), new Complex(5d, 3d), new Complex(0.0, -4d));
            var v = ov.swizzle.bg;
            Assert.That(new Complex(0.0, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, 3d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(-2.5d, 8.5d), new Complex(5.5d, -6d), new Complex(-6.5d, -5.5d));
            var v = ov.swizzle.bgr;
            Assert.That(new Complex(-6.5d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5.5d, -6d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, 8.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(0.5d, 1.5d), new Complex(1.0, 1.0), new Complex(7d, -9.5d));
            var v = ov.swizzle.bgrr;
            Assert.That(new Complex(7d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(0.5d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-1d, 9.5d), new Complex(2.5d, -2.5d), new Complex(9.5d, 4d));
            var v = ov.swizzle.bgrg;
            Assert.That(new Complex(9.5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2.5d, -2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-2.5d, -8d), new Complex(8d, -8.5d), new Complex(-3.5d, 6d));
            var v = ov.swizzle.bgrb;
            Assert.That(new Complex(-3.5d, 6d), Is.EqualTo(v.x));
            Assert.That(new Complex(8d, -8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, -8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3.5d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-6d, -8d), new Complex(7d, -1.5d), new Complex(9d, -4d));
            var v = ov.swizzle.bgg;
            Assert.That(new Complex(9d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -1.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(0.5d, -3.5d), new Complex(9.5d, 3d), new Complex(8d, -8d));
            var v = ov.swizzle.bggr;
            Assert.That(new Complex(8d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, 3d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.5d, -3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(1.5d, 3.5d), new Complex(-6d, 4d), new Complex(7.5d, 7.5d));
            var v = ov.swizzle.bggg;
            Assert.That(new Complex(7.5d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-6d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(9.5d, -5d), new Complex(-1d, -0.5d), new Complex(-4d, 7.5d));
            var v = ov.swizzle.bggb;
            Assert.That(new Complex(-4d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, -0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(7.5d, 9d), new Complex(-2.5d, 2.5d), new Complex(-3d, -6.5d));
            var v = ov.swizzle.bgb;
            Assert.That(new Complex(-3d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-2.5d, 2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3d, -6.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-3.5d, -9d), new Complex(-8d, -9.5d), new Complex(1.0, -2.5d));
            var v = ov.swizzle.bgbr;
            Assert.That(new Complex(1.0, -2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, -2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3.5d, -9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-4.5d, -0.5d), new Complex(-9d, 4.5d), new Complex(8d, -6.5d));
            var v = ov.swizzle.bgbg;
            Assert.That(new Complex(8d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, 4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(5.5d, 4.5d), new Complex(-1d, 8d), new Complex(-0.5d, 4d));
            var v = ov.swizzle.bgbb;
            Assert.That(new Complex(-0.5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, 8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-0.5d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(0.5d, 8.5d), new Complex(7.5d, 7d), new Complex(7d, -4.5d));
            var v = ov.swizzle.bb;
            Assert.That(new Complex(7d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, -4.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec3(new Complex(3.5d, 6.5d), new Complex(-9d, 2.5d), new Complex(-7d, -1.5d));
            var v = ov.swizzle.bbr;
            Assert.That(new Complex(-7d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, 6.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(8.5d, 6.5d), new Complex(-4d, -0.5d), new Complex(-4.5d, 7d));
            var v = ov.swizzle.bbrr;
            Assert.That(new Complex(-4.5d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, 6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-0.5d, -3d), new Complex(9.5d, -4.5d), new Complex(-8d, 1.0));
            var v = ov.swizzle.bbrg;
            Assert.That(new Complex(-8d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, 1.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-1.5d, 9.5d), new Complex(-8d, -2.5d), new Complex(2d, 0.5d));
            var v = ov.swizzle.bbrb;
            Assert.That(new Complex(2d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, 9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(8.5d, -5.5d), new Complex(7d, 0.5d), new Complex(-0.5d, 9.5d));
            var v = ov.swizzle.bbg;
            Assert.That(new Complex(-0.5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, 0.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(2d, -7d), new Complex(-1.5d, -6.5d), new Complex(-5.5d, -4.5d));
            var v = ov.swizzle.bbgr;
            Assert.That(new Complex(-5.5d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, -6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(2d, -7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(8d, -4.5d), new Complex(3.5d, -8.5d), new Complex(-4d, 9d));
            var v = ov.swizzle.bbgg;
            Assert.That(new Complex(-4d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4d, 9d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, -8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(4.5d, 7.5d), new Complex(-4.5d, -9.5d), new Complex(-5d, 4d));
            var v = ov.swizzle.bbgb;
            Assert.That(new Complex(-5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, 4d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4.5d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-5d, 4d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(7.5d, -6d), new Complex(1.0, -2.5d), new Complex(-0.5d, -3.5d));
            var v = ov.swizzle.bbb;
            Assert.That(new Complex(-0.5d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, -3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, -3.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec3(new Complex(-7d, -7.5d), new Complex(-9.5d, -5.5d), new Complex(7.5d, -9.5d));
            var v = ov.swizzle.bbbr;
            Assert.That(new Complex(7.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7.5d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7.5d, -9.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, -7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(-8.5d, 8d), new Complex(9.5d, -1.5d), new Complex(1.0, 4.5d));
            var v = ov.swizzle.bbbg;
            Assert.That(new Complex(1.0, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(1.0, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9.5d, -1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec3(new Complex(0.0, 1.5d), new Complex(7.5d, 7.5d), new Complex(6.5d, -2d));
            var v = ov.swizzle.bbbb;
            Assert.That(new Complex(6.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, -2d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, -2d), Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new cvec3(new Complex(2.5d, 8d), new Complex(1.5d, 6.5d), new Complex(-1.5d, 6.5d));
            var v1 = new cvec2(new Complex(-6.5d, -0.5d), new Complex(7.5d, -2.5d));
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-6.5d, -0.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(7.5d, -2.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-1.5d, 6.5d), Is.EqualTo(v0.z));
        
            Assert.That(new Complex(2.5d, 8d), Is.EqualTo(v2.x));
            Assert.That(new Complex(1.5d, 6.5d), Is.EqualTo(v2.y));
        }
        {
            var v0 = new cvec3(new Complex(-5d, 2d), new Complex(1.5d, -6.5d), new Complex(-2d, -2.5d));
            var v1 = new cvec2(new Complex(-5d, 4.5d), new Complex(-3.5d, 2d));
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-5d, 4.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(1.5d, -6.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-3.5d, 2d), Is.EqualTo(v0.z));
        
            Assert.That(new Complex(-5d, 2d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-2d, -2.5d), Is.EqualTo(v2.y));
        }
        {
            var v0 = new cvec3(new Complex(-3.5d, -5.5d), new Complex(3.5d, -7.5d), new Complex(-1d, -8.5d));
            var v1 = new cvec2(new Complex(1.5d, -9d), new Complex(-5d, 0.5d));
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-3.5d, -5.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(1.5d, -9d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-5d, 0.5d), Is.EqualTo(v0.z));
        
            Assert.That(new Complex(3.5d, -7.5d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-1d, -8.5d), Is.EqualTo(v2.y));
        }
        {
            var v0 = new cvec3(new Complex(9d, 7d), new Complex(-3.5d, 6.5d), new Complex(7d, -9.5d));
            var v1 = new cvec3(new Complex(-5d, 6.5d), new Complex(-6.5d, -9.5d), new Complex(9d, -6d));
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-5d, 6.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-6.5d, -9.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(9d, -6d), Is.EqualTo(v0.z));
        
            Assert.That(new Complex(9d, 7d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-3.5d, 6.5d), Is.EqualTo(v2.y));
            Assert.That(new Complex(7d, -9.5d), Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            cvec3 v0 = new cvec3(new Complex(-4.5d, -8d), new Complex(1.0, -1d), new Complex(9.5d, 6.5d));
            Complex v1 = new Complex(8.5d, 1.0);
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(8.5d, 1.0), Is.EqualTo(v0.x));
            Assert.That(new Complex(1.0, -1d), Is.EqualTo(v0.y));
            Assert.That(new Complex(9.5d, 6.5d), Is.EqualTo(v0.z));
        
            Assert.That(new Complex(-4.5d, -8d), Is.EqualTo(v2));
        }
        {
            cvec3 v0 = new cvec3(new Complex(4.5d, 9.5d), new Complex(-8d, 9.5d), new Complex(-8d, -9.5d));
            Complex v1 = new Complex(6d, 3d);
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(4.5d, 9.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(6d, 3d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-8d, -9.5d), Is.EqualTo(v0.z));
        
            Assert.That(new Complex(-8d, 9.5d), Is.EqualTo(v2));
        }
        {
            cvec3 v0 = new cvec3(new Complex(5d, 7.5d), new Complex(-3.5d, -4.5d), new Complex(-1d, -9.5d));
            cvec2 v1 = new cvec2(new Complex(-5.5d, -3.5d), new Complex(-2.5d, 6.5d));
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-5.5d, -3.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-2.5d, 6.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(-1d, -9.5d), Is.EqualTo(v0.z));
        
            Assert.That(new Complex(5d, 7.5d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-3.5d, -4.5d), Is.EqualTo(v2.y));
        }
        {
            cvec3 v0 = new cvec3(new Complex(9d, 9d), new Complex(6.5d, -5d), new Complex(8d, 5d));
            Complex v1 = new Complex(6.5d, -7.5d);
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(9d, 9d), Is.EqualTo(v0.x));
            Assert.That(new Complex(6.5d, -5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(6.5d, -7.5d), Is.EqualTo(v0.z));
        
            Assert.That(new Complex(8d, 5d), Is.EqualTo(v2));
        }
        {
            cvec3 v0 = new cvec3(new Complex(4.5d, -3.5d), new Complex(-9.5d, -9.5d), new Complex(8.5d, -0.5d));
            cvec2 v1 = new cvec2(new Complex(-9.5d, -6d), new Complex(2.5d, 3.5d));
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-9.5d, -6d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-9.5d, -9.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(2.5d, 3.5d), Is.EqualTo(v0.z));
        
            Assert.That(new Complex(4.5d, -3.5d), Is.EqualTo(v2.x));
            Assert.That(new Complex(8.5d, -0.5d), Is.EqualTo(v2.y));
        }
        {
            cvec3 v0 = new cvec3(new Complex(-6d, -4.5d), new Complex(7d, -8.5d), new Complex(-5d, 1.5d));
            cvec2 v1 = new cvec2(new Complex(-0.5d, -9.5d), new Complex(9d, -7d));
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-6d, -4.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-0.5d, -9.5d), Is.EqualTo(v0.y));
            Assert.That(new Complex(9d, -7d), Is.EqualTo(v0.z));
        
            Assert.That(new Complex(7d, -8.5d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-5d, 1.5d), Is.EqualTo(v2.y));
        }
        {
            cvec3 v0 = new cvec3(new Complex(-2.5d, -5.5d), new Complex(2d, 3.5d), new Complex(5d, -2d));
            cvec3 v1 = new cvec3(new Complex(-4d, -7.5d), new Complex(2.5d, -1d), new Complex(4d, -9d));
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-4d, -7.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(2.5d, -1d), Is.EqualTo(v0.y));
            Assert.That(new Complex(4d, -9d), Is.EqualTo(v0.z));
        
            Assert.That(new Complex(-2.5d, -5.5d), Is.EqualTo(v2.x));
            Assert.That(new Complex(2d, 3.5d), Is.EqualTo(v2.y));
            Assert.That(new Complex(5d, -2d), Is.EqualTo(v2.z));
        }
    }

}
