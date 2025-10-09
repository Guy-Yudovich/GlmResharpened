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
public class DoubleSwizzleVec3Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new dvec3(7.5d, 0.0, 8.5d);
            var v = ov.swizzle.xx;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(-6.5d, -5d, 0.0);
            var v = ov.swizzle.xxx;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(5.5d, 4.5d, 7d);
            var v = ov.swizzle.xxxx;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-8d, -0.5d, -6.5d);
            var v = ov.swizzle.xxxy;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(-8d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(7.5d, 5.5d, -4.5d);
            var v = ov.swizzle.xxxz;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(7.5d, -3.5d, -5.5d);
            var v = ov.swizzle.xxy;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-8.5d, -2d, 3d);
            var v = ov.swizzle.xxyx;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-7d, 7d, 3.5d);
            var v = ov.swizzle.xxyy;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-5d, -2d, 2.5d);
            var v = ov.swizzle.xxyz;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(9.5d, 2d, -9.5d);
            var v = ov.swizzle.xxz;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-8.5d, 0.5d, -1d);
            var v = ov.swizzle.xxzx;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-4.5d, 9d, -6d);
            var v = ov.swizzle.xxzy;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-6d, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(6d, -6.5d, 4.5d);
            var v = ov.swizzle.xxzz;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-1d, 7d, 9.5d);
            var v = ov.swizzle.xy;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(1.5d, 9.5d, 9d);
            var v = ov.swizzle.xyx;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-5.5d, -1d, 6.5d);
            var v = ov.swizzle.xyxx;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(4d, -5.5d, 7d);
            var v = ov.swizzle.xyxy;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2.5d, 9.5d, -2.5d);
            var v = ov.swizzle.xyxz;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(1.5d, -8.5d, 2.5d);
            var v = ov.swizzle.xyy;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(5d, 7d, 2d);
            var v = ov.swizzle.xyyx;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(8d, 6.5d, 1.5d);
            var v = ov.swizzle.xyyy;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2.5d, 6.5d, 9.5d);
            var v = ov.swizzle.xyyz;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2d, -3d, -3.5d);
            var v = ov.swizzle.xyz;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(8d, 0.5d, 2d);
            var v = ov.swizzle.xyzx;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
            Assert.That(8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-0.5d, 9d, 4d);
            var v = ov.swizzle.xyzy;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(3d, -4.5d, 7d);
            var v = ov.swizzle.xyzz;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-6.5d, 1.5d, 0.0);
            var v = ov.swizzle.xz;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(5.5d, 4.5d, -9d);
            var v = ov.swizzle.xzx;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-3d, 4.5d, 1.5d);
            var v = ov.swizzle.xzxx;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-5.5d, 3.5d, -1.5d);
            var v = ov.swizzle.xzxy;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-5.5d, 1.0, -6d);
            var v = ov.swizzle.xzxz;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(1.5d, 2d, -2d);
            var v = ov.swizzle.xzy;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(8d, 3d, 3d);
            var v = ov.swizzle.xzyx;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-1d, -2d, 8.5d);
            var v = ov.swizzle.xzyy;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-1d, 6.5d, 3.5d);
            var v = ov.swizzle.xzyz;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(4d, 7.5d, -0.5d);
            var v = ov.swizzle.xzz;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-6.5d, -2.5d, 5.5d);
            var v = ov.swizzle.xzzx;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-4.5d, -7.5d, -7d);
            var v = ov.swizzle.xzzy;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2d, -3d, 1.0);
            var v = ov.swizzle.xzzz;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-3d, -5d, 2d);
            var v = ov.swizzle.yx;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(7d, -1.5d, -9d);
            var v = ov.swizzle.yxx;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(7.5d, -4.5d, -0.5d);
            var v = ov.swizzle.yxxx;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2.5d, 7.5d, 6d);
            var v = ov.swizzle.yxxy;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2.5d, 5.5d, -8.5d);
            var v = ov.swizzle.yxxz;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(4d, -3d, -9.5d);
            var v = ov.swizzle.yxy;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(2d, -4.5d, 8.5d);
            var v = ov.swizzle.yxyx;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(2d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-3.5d, 7d, 6.5d);
            var v = ov.swizzle.yxyy;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2d, 0.0, 5d);
            var v = ov.swizzle.yxyz;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(2d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2.5d, 8.5d, -9.5d);
            var v = ov.swizzle.yxz;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(8.5d, -0.5d, 0.5d);
            var v = ov.swizzle.yxzx;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(9d, 5.5d, -0.5d);
            var v = ov.swizzle.yxzy;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(1.0, 3d, -6.5d);
            var v = ov.swizzle.yxzz;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-9d, -3d, -2d);
            var v = ov.swizzle.yy;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(3d, -8d, 0.0);
            var v = ov.swizzle.yyx;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-7.5d, 0.5d, 2.5d);
            var v = ov.swizzle.yyxx;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-5d, -9.5d, 8d);
            var v = ov.swizzle.yyxy;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(-9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(7.5d, 0.0, -2.5d);
            var v = ov.swizzle.yyxz;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2d, -3.5d, 6d);
            var v = ov.swizzle.yyy;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(5d, 5d, -2.5d);
            var v = ov.swizzle.yyyx;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-4d, 5d, -3.5d);
            var v = ov.swizzle.yyyy;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(9d, -0.5d, 7d);
            var v = ov.swizzle.yyyz;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-7d, -7.5d, 9.5d);
            var v = ov.swizzle.yyz;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(1.5d, 3d, 9d);
            var v = ov.swizzle.yyzx;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(6.5d, -6.5d, -3d);
            var v = ov.swizzle.yyzy;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2.5d, -7.5d, 0.5d);
            var v = ov.swizzle.yyzz;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(6.5d, -9.5d, 9d);
            var v = ov.swizzle.yz;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(-4d, -8d, -9d);
            var v = ov.swizzle.yzx;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-1d, 1.0, -0.5d);
            var v = ov.swizzle.yzxx;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2d, 6d, 8d);
            var v = ov.swizzle.yzxy;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-6.5d, 5.5d, 7.5d);
            var v = ov.swizzle.yzxz;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(6.5d, 5d, 6d);
            var v = ov.swizzle.yzy;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-4.5d, 4.5d, -0.5d);
            var v = ov.swizzle.yzyx;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2.5d, 4d, 7d);
            var v = ov.swizzle.yzyy;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2.5d, -6.5d, -7d);
            var v = ov.swizzle.yzyz;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(9.5d, 0.0, -7d);
            var v = ov.swizzle.yzz;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-5d, -6d, 4d);
            var v = ov.swizzle.yzzx;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-7d, 8d, -4.5d);
            var v = ov.swizzle.yzzy;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-7d, 0.0, -2.5d);
            var v = ov.swizzle.yzzz;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(7d, 9.5d, -2.5d);
            var v = ov.swizzle.zx;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(-9d, -4d, -6d);
            var v = ov.swizzle.zxx;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(1.5d, 8d, 7d);
            var v = ov.swizzle.zxxx;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2d, 0.0, -7d);
            var v = ov.swizzle.zxxy;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(5d, 1.0, -1.5d);
            var v = ov.swizzle.zxxz;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(-1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(1.0, 4d, -5d);
            var v = ov.swizzle.zxy;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(1.0, -8.5d, 5.5d);
            var v = ov.swizzle.zxyx;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(1.0, -1d, 0.0);
            var v = ov.swizzle.zxyy;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2d, -1.5d, 1.5d);
            var v = ov.swizzle.zxyz;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(4d, 5d, -3.5d);
            var v = ov.swizzle.zxz;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-3d, -9d, 5d);
            var v = ov.swizzle.zxzx;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-9d, -8d, 4.5d);
            var v = ov.swizzle.zxzy;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(-8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(1.0, -4d, 0.5d);
            var v = ov.swizzle.zxzz;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2.5d, 1.0, -4d);
            var v = ov.swizzle.zy;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(8d, -1.5d, 0.0);
            var v = ov.swizzle.zyx;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(8d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(0.0, 8d, -5d);
            var v = ov.swizzle.zyxx;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-7d, -5d, 4d);
            var v = ov.swizzle.zyxy;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(9d, -5d, -9d);
            var v = ov.swizzle.zyxz;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2.5d, 5d, -1.5d);
            var v = ov.swizzle.zyy;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-2.5d, 6d, -3.5d);
            var v = ov.swizzle.zyyx;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-5.5d, -3.5d, 3d);
            var v = ov.swizzle.zyyy;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-7.5d, 9.5d, -8.5d);
            var v = ov.swizzle.zyyz;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2d, -2.5d, -6.5d);
            var v = ov.swizzle.zyz;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(3.5d, 0.0, 1.5d);
            var v = ov.swizzle.zyzx;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-4.5d, 9d, -9.5d);
            var v = ov.swizzle.zyzy;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-8.5d, 3.5d, -6.5d);
            var v = ov.swizzle.zyzz;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(9.5d, -2d, -9.5d);
            var v = ov.swizzle.zz;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(-7d, -1.5d, 1.5d);
            var v = ov.swizzle.zzx;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-7.5d, 2d, 3d);
            var v = ov.swizzle.zzxx;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2.5d, -2.5d, -3d);
            var v = ov.swizzle.zzxy;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(6d, -5d, 6d);
            var v = ov.swizzle.zzxz;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(4d, 7d, -5d);
            var v = ov.swizzle.zzy;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-1d, -2.5d, -1.5d);
            var v = ov.swizzle.zzyx;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-9.5d, -0.5d, -8.5d);
            var v = ov.swizzle.zzyy;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-0.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(1.5d, -6.5d, -5d);
            var v = ov.swizzle.zzyz;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-4d, -4.5d, 5d);
            var v = ov.swizzle.zzz;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(8.5d, -1d, -2d);
            var v = ov.swizzle.zzzx;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(5d, -2.5d, 5.5d);
            var v = ov.swizzle.zzzy;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(5d, 7d, 8.5d);
            var v = ov.swizzle.zzzz;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new dvec3(5d, -2d, 4d);
            var v = ov.swizzle.rr;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(7.5d, -4.5d, -7d);
            var v = ov.swizzle.rrr;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-7.5d, -8.5d, 5.5d);
            var v = ov.swizzle.rrrr;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-8.5d, -7.5d, 2.5d);
            var v = ov.swizzle.rrrg;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-9.5d, 1.0, -8.5d);
            var v = ov.swizzle.rrrb;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-1d, 0.0, -3.5d);
            var v = ov.swizzle.rrg;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(4.5d, -4d, 4.5d);
            var v = ov.swizzle.rrgr;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(8.5d, -1.5d, -9.5d);
            var v = ov.swizzle.rrgg;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(-1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(0.5d, 6d, 3d);
            var v = ov.swizzle.rrgb;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(8d, -1.5d, 7.5d);
            var v = ov.swizzle.rrb;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(3.5d, 2.5d, 5d);
            var v = ov.swizzle.rrbr;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-5.5d, 8d, -8d);
            var v = ov.swizzle.rrbg;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-8d, Is.EqualTo(v.z));
            Assert.That(8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2.5d, 2d, -3.5d);
            var v = ov.swizzle.rrbb;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-5d, -2d, 6.5d);
            var v = ov.swizzle.rg;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(-7.5d, 6.5d, -3d);
            var v = ov.swizzle.rgr;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(5.5d, -7d, 3d);
            var v = ov.swizzle.rgrr;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(8.5d, 8.5d, 1.5d);
            var v = ov.swizzle.rgrg;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2.5d, -5.5d, 4d);
            var v = ov.swizzle.rgrb;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(1.0, 6d, -5.5d);
            var v = ov.swizzle.rgg;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-5.5d, 7d, -8d);
            var v = ov.swizzle.rggr;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-4d, -4d, 3.5d);
            var v = ov.swizzle.rggg;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(7.5d, -1.5d, -0.5d);
            var v = ov.swizzle.rggb;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-3.5d, 5.5d, 2.5d);
            var v = ov.swizzle.rgb;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(3d, -6.5d, 8.5d);
            var v = ov.swizzle.rgbr;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(9.5d, -9.5d, 1.0);
            var v = ov.swizzle.rgbg;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(-9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(7.5d, -7d, 2.5d);
            var v = ov.swizzle.rgbb;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(6d, 4.5d, -0.5d);
            var v = ov.swizzle.rb;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(9.5d, -1d, 0.5d);
            var v = ov.swizzle.rbr;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(6d, 1.0, 8d);
            var v = ov.swizzle.rbrr;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(1.0, -6.5d, 1.0);
            var v = ov.swizzle.rbrg;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(4.5d, 3d, 5.5d);
            var v = ov.swizzle.rbrb;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(8d, 1.0, 8.5d);
            var v = ov.swizzle.rbg;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(3d, -4.5d, 7d);
            var v = ov.swizzle.rbgr;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-5.5d, 8d, -7.5d);
            var v = ov.swizzle.rbgg;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(8d, Is.EqualTo(v.z));
            Assert.That(8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-1d, 4.5d, -5d);
            var v = ov.swizzle.rbgb;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(3.5d, 2.5d, 3d);
            var v = ov.swizzle.rbb;
            Assert.That(3.5d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(2d, 3d, 0.5d);
            var v = ov.swizzle.rbbr;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2.5d, -7d, -3d);
            var v = ov.swizzle.rbbg;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-3d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-0.5d, -4d, 2d);
            var v = ov.swizzle.rbbb;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(2d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
            Assert.That(2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(3d, 1.5d, -2.5d);
            var v = ov.swizzle.gr;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(-9.5d, -4.5d, -3d);
            var v = ov.swizzle.grr;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(0.5d, 9d, -9d);
            var v = ov.swizzle.grrr;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2d, 1.5d, -9d);
            var v = ov.swizzle.grrg;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(2d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(3d, 4.5d, 1.5d);
            var v = ov.swizzle.grrb;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-5.5d, -6.5d, -3.5d);
            var v = ov.swizzle.grg;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(6d, -1.5d, -6d);
            var v = ov.swizzle.grgr;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-5d, -4d, 8d);
            var v = ov.swizzle.grgg;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(5d, 8.5d, -9d);
            var v = ov.swizzle.grgb;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2d, 2d, -2.5d);
            var v = ov.swizzle.grb;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-7.5d, -9.5d, -2.5d);
            var v = ov.swizzle.grbr;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(5.5d, 0.0, 4.5d);
            var v = ov.swizzle.grbg;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-8.5d, 3d, -6.5d);
            var v = ov.swizzle.grbb;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(9d, -9.5d, -4.5d);
            var v = ov.swizzle.gg;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(6.5d, 0.5d, 1.0);
            var v = ov.swizzle.ggr;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-5.5d, 9.5d, 9d);
            var v = ov.swizzle.ggrr;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(8.5d, 7d, 3.5d);
            var v = ov.swizzle.ggrg;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-3.5d, -7.5d, -3.5d);
            var v = ov.swizzle.ggrb;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2.5d, -1.5d, -7d);
            var v = ov.swizzle.ggg;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-8d, -5d, -2.5d);
            var v = ov.swizzle.gggr;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(-8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(4.5d, -9d, 7d);
            var v = ov.swizzle.gggg;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(-9d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2.5d, -8.5d, -2d);
            var v = ov.swizzle.gggb;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2.5d, 7d, 4.5d);
            var v = ov.swizzle.ggb;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(7.5d, 2d, -9.5d);
            var v = ov.swizzle.ggbr;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(2d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(3d, 7.5d, 7d);
            var v = ov.swizzle.ggbg;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(0.5d, -8d, -5.5d);
            var v = ov.swizzle.ggbb;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(6d, -8.5d, 9.5d);
            var v = ov.swizzle.gb;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(9d, -4d, 4.5d);
            var v = ov.swizzle.gbr;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(3.5d, 6.5d, 7.5d);
            var v = ov.swizzle.gbrr;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(3.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(1.0, 8d, -2d);
            var v = ov.swizzle.gbrg;
            Assert.That(8d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-7d, 3d, -0.5d);
            var v = ov.swizzle.gbrb;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(6.5d, -5d, 1.0);
            var v = ov.swizzle.gbg;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-8d, 4d, 8d);
            var v = ov.swizzle.gbgr;
            Assert.That(4d, Is.EqualTo(v.x));
            Assert.That(8d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(-8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(0.5d, 2.5d, 1.5d);
            var v = ov.swizzle.gbgg;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-5d, 0.0, 5d);
            var v = ov.swizzle.gbgb;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-4d, -6.5d, -5.5d);
            var v = ov.swizzle.gbb;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-8d, 6.5d, 9d);
            var v = ov.swizzle.gbbr;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(-8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(3.5d, -2d, 3.5d);
            var v = ov.swizzle.gbbg;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2.5d, -4.5d, 5d);
            var v = ov.swizzle.gbbb;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-3d, 8.5d, -5.5d);
            var v = ov.swizzle.br;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(-4d, 1.5d, 9.5d);
            var v = ov.swizzle.brr;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-6.5d, -8.5d, 9.5d);
            var v = ov.swizzle.brrr;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(1.5d, 6d, -7.5d);
            var v = ov.swizzle.brrg;
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(6d, -3d, -4d);
            var v = ov.swizzle.brrb;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-5d, -7d, -0.5d);
            var v = ov.swizzle.brg;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(7d, 4.5d, -3d);
            var v = ov.swizzle.brgr;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-1.5d, -9.5d, -3d);
            var v = ov.swizzle.brgg;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
            Assert.That(-9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-4d, -6.5d, -2d);
            var v = ov.swizzle.brgb;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(1.0, -6.5d, 2.5d);
            var v = ov.swizzle.brb;
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(5.5d, 8d, 0.5d);
            var v = ov.swizzle.brbr;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(6.5d, 5d, 5d);
            var v = ov.swizzle.brbg;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-4.5d, -6d, 1.0);
            var v = ov.swizzle.brbb;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2.5d, 2.5d, -9d);
            var v = ov.swizzle.bg;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(2.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(6d, -6.5d, -6d);
            var v = ov.swizzle.bgr;
            Assert.That(-6d, Is.EqualTo(v.x));
            Assert.That(-6.5d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(1.0, -2d, -5.5d);
            var v = ov.swizzle.bgrr;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(6.5d, -9d, 4.5d);
            var v = ov.swizzle.bgrg;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(-9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(4d, -9d, 0.5d);
            var v = ov.swizzle.bgrb;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(-9d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2.5d, -4.5d, -9d);
            var v = ov.swizzle.bgg;
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-1d, 9.5d, 7d);
            var v = ov.swizzle.bggr;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2.5d, -7.5d, 8.5d);
            var v = ov.swizzle.bggg;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-7.5d, Is.EqualTo(v.z));
            Assert.That(-7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(7d, 5.5d, 8.5d);
            var v = ov.swizzle.bggb;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(2.5d, -1d, 7d);
            var v = ov.swizzle.bgb;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(8d, 0.5d, 0.0);
            var v = ov.swizzle.bgbr;
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(8d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2.5d, -6d, 2d);
            var v = ov.swizzle.bgbg;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(3.5d, -7.5d, 6.5d);
            var v = ov.swizzle.bgbb;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(6.5d, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(7.5d, -3d, -2d);
            var v = ov.swizzle.bb;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec3(-1.5d, 4d, 3d);
            var v = ov.swizzle.bbr;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(7.5d, 0.5d, -0.5d);
            var v = ov.swizzle.bbrr;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(0.0, 3d, -9.5d);
            var v = ov.swizzle.bbrg;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-2.5d, -4d, -7d);
            var v = ov.swizzle.bbrb;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(4.5d, 4d, 9d);
            var v = ov.swizzle.bbg;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-8.5d, 9.5d, -2.5d);
            var v = ov.swizzle.bbgr;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-8d, 9d, 1.0);
            var v = ov.swizzle.bbgg;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(1.0, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-7d, -2.5d, -0.5d);
            var v = ov.swizzle.bbgb;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(4.5d, -8d, 3d);
            var v = ov.swizzle.bbb;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec3(-2.5d, 9.5d, 2d);
            var v = ov.swizzle.bbbr;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(2d, Is.EqualTo(v.y));
            Assert.That(2d, Is.EqualTo(v.z));
            Assert.That(-2.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(-7.5d, -4d, -2.5d);
            var v = ov.swizzle.bbbg;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec3(5.5d, 8.5d, -7d);
            var v = ov.swizzle.bbbb;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new dvec3(7d, -9d, 2.5d);
            var v1 = new dvec2(7.5d, -5d);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(7.5d, Is.EqualTo(v0.x));
            Assert.That(-5d, Is.EqualTo(v0.y));
            Assert.That(2.5d, Is.EqualTo(v0.z));
        
            Assert.That(7d, Is.EqualTo(v2.x));
            Assert.That(-9d, Is.EqualTo(v2.y));
        }
        {
            var v0 = new dvec3(4.5d, -4d, -6d);
            var v1 = new dvec2(6d, 0.5d);
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(6d, Is.EqualTo(v0.x));
            Assert.That(-4d, Is.EqualTo(v0.y));
            Assert.That(0.5d, Is.EqualTo(v0.z));
        
            Assert.That(4.5d, Is.EqualTo(v2.x));
            Assert.That(-6d, Is.EqualTo(v2.y));
        }
        {
            var v0 = new dvec3(0.0, -0.5d, 2.5d);
            var v1 = new dvec2(1.0, 0.0);
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(0.0, Is.EqualTo(v0.x));
            Assert.That(1.0, Is.EqualTo(v0.y));
            Assert.That(0.0, Is.EqualTo(v0.z));
        
            Assert.That(-0.5d, Is.EqualTo(v2.x));
            Assert.That(2.5d, Is.EqualTo(v2.y));
        }
        {
            var v0 = new dvec3(9d, -6d, -1d);
            var v1 = new dvec3(5d, -1d, -7d);
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(5d, Is.EqualTo(v0.x));
            Assert.That(-1d, Is.EqualTo(v0.y));
            Assert.That(-7d, Is.EqualTo(v0.z));
        
            Assert.That(9d, Is.EqualTo(v2.x));
            Assert.That(-6d, Is.EqualTo(v2.y));
            Assert.That(-1d, Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new dvec3(-8d, 8.5d, -3d);
            var v1 = -2d;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-2d, Is.EqualTo(v0.x));
            Assert.That(8.5d, Is.EqualTo(v0.y));
            Assert.That(-3d, Is.EqualTo(v0.z));
        
            Assert.That(-8d, Is.EqualTo(v2));
        }
        {
            var v0 = new dvec3(-0.5d, 9.5d, -6.5d);
            var v1 = 4d;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-0.5d, Is.EqualTo(v0.x));
            Assert.That(4d, Is.EqualTo(v0.y));
            Assert.That(-6.5d, Is.EqualTo(v0.z));
        
            Assert.That(9.5d, Is.EqualTo(v2));
        }
        {
            var v0 = new dvec3(3.5d, 9.5d, -4d);
            var v1 = new dvec2(-9d, -3d);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-9d, Is.EqualTo(v0.x));
            Assert.That(-3d, Is.EqualTo(v0.y));
            Assert.That(-4d, Is.EqualTo(v0.z));
        
            Assert.That(3.5d, Is.EqualTo(v2.x));
            Assert.That(9.5d, Is.EqualTo(v2.y));
        }
        {
            var v0 = new dvec3(-8.5d, -7.5d, 0.0);
            var v1 = -6d;
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-8.5d, Is.EqualTo(v0.x));
            Assert.That(-7.5d, Is.EqualTo(v0.y));
            Assert.That(-6d, Is.EqualTo(v0.z));
        
            Assert.That(0.0, Is.EqualTo(v2));
        }
        {
            var v0 = new dvec3(6d, -7d, -8.5d);
            var v1 = new dvec2(9d, 5d);
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(9d, Is.EqualTo(v0.x));
            Assert.That(-7d, Is.EqualTo(v0.y));
            Assert.That(5d, Is.EqualTo(v0.z));
        
            Assert.That(6d, Is.EqualTo(v2.x));
            Assert.That(-8.5d, Is.EqualTo(v2.y));
        }
        {
            var v0 = new dvec3(2.5d, 2d, -8d);
            var v1 = new dvec2(4.5d, 9.5d);
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(2.5d, Is.EqualTo(v0.x));
            Assert.That(4.5d, Is.EqualTo(v0.y));
            Assert.That(9.5d, Is.EqualTo(v0.z));
        
            Assert.That(2d, Is.EqualTo(v2.x));
            Assert.That(-8d, Is.EqualTo(v2.y));
        }
        {
            var v0 = new dvec3(3.5d, 5.5d, -7.5d);
            var v1 = new dvec3(7.5d, -8d, 8.5d);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(7.5d, Is.EqualTo(v0.x));
            Assert.That(-8d, Is.EqualTo(v0.y));
            Assert.That(8.5d, Is.EqualTo(v0.z));
        
            Assert.That(3.5d, Is.EqualTo(v2.x));
            Assert.That(5.5d, Is.EqualTo(v2.y));
            Assert.That(-7.5d, Is.EqualTo(v2.z));
        }
    }

}
