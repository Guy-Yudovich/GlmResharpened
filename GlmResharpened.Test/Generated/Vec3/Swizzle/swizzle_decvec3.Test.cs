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
public class DecimalSwizzleVec3Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new decvec3(-5m, -3m, 3m);
            var v = ov.swizzle.xx;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(7m, 4.5m, -6.5m);
            var v = ov.swizzle.xxx;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-9m, 2.5m, -0.5m);
            var v = ov.swizzle.xxxx;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(6.5m, 8m, 4.5m);
            var v = ov.swizzle.xxxy;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(9m, -5.5m, 6.5m);
            var v = ov.swizzle.xxxz;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-2m, -1m, -3.5m);
            var v = ov.swizzle.xxy;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(2m, -0.5m, -7.5m);
            var v = ov.swizzle.xxyx;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(4.5m, -5m, -5m);
            var v = ov.swizzle.xxyy;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(-5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(3m, 3.5m, 9m);
            var v = ov.swizzle.xxyz;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-5m, -2.5m, 4.5m);
            var v = ov.swizzle.xxz;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-1m, -5.5m, 4m);
            var v = ov.swizzle.xxzx;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-7.5m, 0.5m, -4.5m);
            var v = ov.swizzle.xxzy;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-1m, -9.5m, 7m);
            var v = ov.swizzle.xxzz;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(9m, 9.5m, 5m);
            var v = ov.swizzle.xy;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(6.5m, 9m, -5.5m);
            var v = ov.swizzle.xyx;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-7.5m, -7.5m, -5m);
            var v = ov.swizzle.xyxx;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(2m, -1.5m, -3.5m);
            var v = ov.swizzle.xyxy;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(7m, -5m, 4.5m);
            var v = ov.swizzle.xyxz;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(3.5m, -9.5m, 7.5m);
            var v = ov.swizzle.xyy;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-1.5m, 3m, 0m);
            var v = ov.swizzle.xyyx;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-4m, 4m, 5m);
            var v = ov.swizzle.xyyy;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(4.5m, -3.5m, -5.5m);
            var v = ov.swizzle.xyyz;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-0.5m, -2.5m, 3.5m);
            var v = ov.swizzle.xyz;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-1m, 1m, 1.5m);
            var v = ov.swizzle.xyzx;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-8m, 2.5m, 0.5m);
            var v = ov.swizzle.xyzy;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-6m, 7.5m, 5m);
            var v = ov.swizzle.xyzz;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
            Assert.That(5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(0.5m, -7.5m, -1m);
            var v = ov.swizzle.xz;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(4.5m, -2m, 8.5m);
            var v = ov.swizzle.xzx;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(8m, 3m, 8m);
            var v = ov.swizzle.xzxx;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(9m, -1.5m, 9m);
            var v = ov.swizzle.xzxy;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-1.5m, -7.5m, -7m);
            var v = ov.swizzle.xzxz;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(7m, 5.5m, 5.5m);
            var v = ov.swizzle.xzy;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(9.5m, 1m, -5.5m);
            var v = ov.swizzle.xzyx;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(0m, 2.5m, 5.5m);
            var v = ov.swizzle.xzyy;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-8.5m, 2.5m, -2.5m);
            var v = ov.swizzle.xzyz;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(4.5m, -0.5m, -6.5m);
            var v = ov.swizzle.xzz;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(4m, -7m, -7.5m);
            var v = ov.swizzle.xzzx;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(2.5m, 8.5m, -7.5m);
            var v = ov.swizzle.xzzy;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-0.5m, -9m, 3.5m);
            var v = ov.swizzle.xzzz;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(7m, -3.5m, -7.5m);
            var v = ov.swizzle.yx;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(-5m, -9.5m, 8.5m);
            var v = ov.swizzle.yxx;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-6.5m, -6.5m, -9m);
            var v = ov.swizzle.yxxx;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(-6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-4m, 9m, 6.5m);
            var v = ov.swizzle.yxxy;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(4.5m, -7m, 6.5m);
            var v = ov.swizzle.yxxz;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-8.5m, -0.5m, -0.5m);
            var v = ov.swizzle.yxy;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-6m, -4m, -9.5m);
            var v = ov.swizzle.yxyx;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-1m, -4m, -4m);
            var v = ov.swizzle.yxyy;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-3.5m, 5m, -2m);
            var v = ov.swizzle.yxyz;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-1.5m, 5.5m, -6.5m);
            var v = ov.swizzle.yxz;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(4.5m, -8m, -6m);
            var v = ov.swizzle.yxzx;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(2m, 2.5m, -6m);
            var v = ov.swizzle.yxzy;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(2m, -4.5m, -3m);
            var v = ov.swizzle.yxzz;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(6.5m, 7.5m, 8m);
            var v = ov.swizzle.yy;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(7m, -8.5m, -9.5m);
            var v = ov.swizzle.yyx;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-3.5m, 9m, 0m);
            var v = ov.swizzle.yyxx;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-3.5m, -1m, 8m);
            var v = ov.swizzle.yyxy;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(3.5m, -4m, 5m);
            var v = ov.swizzle.yyxz;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-4m, 6.5m, -2m);
            var v = ov.swizzle.yyy;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(7m, -0.5m, -4m);
            var v = ov.swizzle.yyyx;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-2.5m, 5.5m, -2.5m);
            var v = ov.swizzle.yyyy;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(5.5m, -9.5m, 2.5m);
            var v = ov.swizzle.yyyz;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-9.5m, 2.5m, -5.5m);
            var v = ov.swizzle.yyz;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-9.5m, -9m, 3m);
            var v = ov.swizzle.yyzx;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-6m, -9.5m, -6m);
            var v = ov.swizzle.yyzy;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-1m, 3m, 3.5m);
            var v = ov.swizzle.yyzz;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(4.5m, 9.5m, 6.5m);
            var v = ov.swizzle.yz;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(-2m, 1m, -4.5m);
            var v = ov.swizzle.yzx;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-5m, 1m, 3m);
            var v = ov.swizzle.yzxx;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(-5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-1m, -0.5m, 6.5m);
            var v = ov.swizzle.yzxy;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(-0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(4m, 5.5m, 6.5m);
            var v = ov.swizzle.yzxz;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(9.5m, 8m, 1m);
            var v = ov.swizzle.yzy;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-8.5m, -3m, 0m);
            var v = ov.swizzle.yzyx;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-2.5m, 6m, -8m);
            var v = ov.swizzle.yzyy;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-6m, 6m, 2.5m);
            var v = ov.swizzle.yzyz;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(4m, -7m, 4.5m);
            var v = ov.swizzle.yzz;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(0.5m, 2m, 3.5m);
            var v = ov.swizzle.yzzx;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-8m, -3m, -0.5m);
            var v = ov.swizzle.yzzy;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-8m, -6m, 4.5m);
            var v = ov.swizzle.yzzz;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(2m, -8.5m, -8m);
            var v = ov.swizzle.zx;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(-1.5m, 9m, 3m);
            var v = ov.swizzle.zxx;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-1.5m, -5m, -5.5m);
            var v = ov.swizzle.zxxx;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(7m, -7m, -1m);
            var v = ov.swizzle.zxxy;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-4m, -0.5m, 0.5m);
            var v = ov.swizzle.zxxz;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(2.5m, 7m, 3.5m);
            var v = ov.swizzle.zxy;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-8m, 5.5m, 4.5m);
            var v = ov.swizzle.zxyx;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(3.5m, 9m, -5.5m);
            var v = ov.swizzle.zxyy;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(9m, -9.5m, -3.5m);
            var v = ov.swizzle.zxyz;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(2m, -3.5m, -7.5m);
            var v = ov.swizzle.zxz;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(7m, -8.5m, 3.5m);
            var v = ov.swizzle.zxzx;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(7m, -9m, 1.5m);
            var v = ov.swizzle.zxzy;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-6.5m, 8.5m, 6.5m);
            var v = ov.swizzle.zxzz;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-4m, -2.5m, 1.5m);
            var v = ov.swizzle.zy;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(7m, 7.5m, 0m);
            var v = ov.swizzle.zyx;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-6.5m, -6m, -4m);
            var v = ov.swizzle.zyxx;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(-6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(2m, -3.5m, 4m);
            var v = ov.swizzle.zyxy;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(5.5m, 9.5m, -9.5m);
            var v = ov.swizzle.zyxz;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(0m, 9m, -2m);
            var v = ov.swizzle.zyy;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(4.5m, -9m, -0.5m);
            var v = ov.swizzle.zyyx;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-8m, -3.5m, -0.5m);
            var v = ov.swizzle.zyyy;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(1m, 9.5m, 5.5m);
            var v = ov.swizzle.zyyz;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-7m, 6m, -1m);
            var v = ov.swizzle.zyz;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(9.5m, 9m, 8m);
            var v = ov.swizzle.zyzx;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(7.5m, 4m, 8m);
            var v = ov.swizzle.zyzy;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(3m, -4.5m, -2m);
            var v = ov.swizzle.zyzz;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-5.5m, -3.5m, 3m);
            var v = ov.swizzle.zz;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(-2m, 0m, 0m);
            var v = ov.swizzle.zzx;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-7m, -3m, -7.5m);
            var v = ov.swizzle.zzxx;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-4m, 7m, 8m);
            var v = ov.swizzle.zzxy;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-9.5m, -1.5m, -9.5m);
            var v = ov.swizzle.zzxz;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(6m, 6.5m, 1m);
            var v = ov.swizzle.zzy;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(2m, 6m, 8.5m);
            var v = ov.swizzle.zzyx;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(5m, 6m, 9m);
            var v = ov.swizzle.zzyy;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(3m, 3m, -6m);
            var v = ov.swizzle.zzyz;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(6.5m, 8.5m, 5.5m);
            var v = ov.swizzle.zzz;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-2m, 7.5m, -4.5m);
            var v = ov.swizzle.zzzx;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(9.5m, -1m, 2.5m);
            var v = ov.swizzle.zzzy;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-3.5m, 5m, -4.5m);
            var v = ov.swizzle.zzzz;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new decvec3(-4.5m, -4.5m, -6m);
            var v = ov.swizzle.rr;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(-6m, 7m, 2m);
            var v = ov.swizzle.rrr;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(6m, -9m, -1.5m);
            var v = ov.swizzle.rrrr;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-5m, 6.5m, -9m);
            var v = ov.swizzle.rrrg;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-1.5m, -1.5m, 6m);
            var v = ov.swizzle.rrrb;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(3m, 2.5m, 7m);
            var v = ov.swizzle.rrg;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(4m, 3.5m, 7m);
            var v = ov.swizzle.rrgr;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(4m, -9.5m, 4m);
            var v = ov.swizzle.rrgg;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(5m, -6m, 1.5m);
            var v = ov.swizzle.rrgb;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
            Assert.That(1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-9m, -6.5m, -4m);
            var v = ov.swizzle.rrb;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(6m, -5m, 8.5m);
            var v = ov.swizzle.rrbr;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(4.5m, -6m, -6.5m);
            var v = ov.swizzle.rrbg;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(7.5m, -7m, 8.5m);
            var v = ov.swizzle.rrbb;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(1m, -3.5m, -1.5m);
            var v = ov.swizzle.rg;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(7m, 5.5m, 4.5m);
            var v = ov.swizzle.rgr;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(9m, 3.5m, -5.5m);
            var v = ov.swizzle.rgrr;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(7m, 2.5m, -7m);
            var v = ov.swizzle.rgrg;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-2.5m, 0m, 5.5m);
            var v = ov.swizzle.rgrb;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-6.5m, -8.5m, 4m);
            var v = ov.swizzle.rgg;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-1m, 9m, 2.5m);
            var v = ov.swizzle.rggr;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-1m, -1.5m, 5.5m);
            var v = ov.swizzle.rggg;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-5m, 8m, -7.5m);
            var v = ov.swizzle.rggb;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-8.5m, 4.5m, -2m);
            var v = ov.swizzle.rgb;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-6.5m, 5m, -5m);
            var v = ov.swizzle.rgbr;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(-6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(9m, 2m, 7m);
            var v = ov.swizzle.rgbg;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-9.5m, 7.5m, -5.5m);
            var v = ov.swizzle.rgbb;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(9m, 5.5m, -7.5m);
            var v = ov.swizzle.rb;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(6m, -1m, 1.5m);
            var v = ov.swizzle.rbr;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(6.5m, -9m, -4m);
            var v = ov.swizzle.rbrr;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(2m, -1m, 5.5m);
            var v = ov.swizzle.rbrg;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-8m, -2.5m, 7m);
            var v = ov.swizzle.rbrb;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(5m, 1.5m, 8.5m);
            var v = ov.swizzle.rbg;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(3.5m, 2.5m, -2.5m);
            var v = ov.swizzle.rbgr;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-3m, -0.5m, 9.5m);
            var v = ov.swizzle.rbgg;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(-0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-2m, -4.5m, -3.5m);
            var v = ov.swizzle.rbgb;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(1m, -8m, 7.5m);
            var v = ov.swizzle.rbb;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-1.5m, 3m, -5.5m);
            var v = ov.swizzle.rbbr;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-8.5m, 0m, -4m);
            var v = ov.swizzle.rbbg;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(9m, 3m, -7m);
            var v = ov.swizzle.rbbb;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(3m, -8m, -0.5m);
            var v = ov.swizzle.gr;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(7m, -8m, -6.5m);
            var v = ov.swizzle.grr;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-7m, 4m, -9m);
            var v = ov.swizzle.grrr;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(7m, 3m, -2m);
            var v = ov.swizzle.grrg;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(9m, -3.5m, 4m);
            var v = ov.swizzle.grrb;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(6.5m, 7.5m, 6m);
            var v = ov.swizzle.grg;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-7.5m, 5.5m, -3.5m);
            var v = ov.swizzle.grgr;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(4m, 5.5m, 1m);
            var v = ov.swizzle.grgg;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-7m, -5m, 7m);
            var v = ov.swizzle.grgb;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-1m, 7.5m, -2.5m);
            var v = ov.swizzle.grb;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(3.5m, 5.5m, -1.5m);
            var v = ov.swizzle.grbr;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-7.5m, -0.5m, -4m);
            var v = ov.swizzle.grbg;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(-0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(8.5m, 5m, -1m);
            var v = ov.swizzle.grbb;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-7m, 5.5m, -9.5m);
            var v = ov.swizzle.gg;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(7m, 3.5m, -4m);
            var v = ov.swizzle.ggr;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-3.5m, -9m, -7m);
            var v = ov.swizzle.ggrr;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-9m, -5.5m, 3m);
            var v = ov.swizzle.ggrg;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(7m, -1.5m, 8m);
            var v = ov.swizzle.ggrb;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(0.5m, 9.5m, -6.5m);
            var v = ov.swizzle.ggg;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-2.5m, 1.5m, 2m);
            var v = ov.swizzle.gggr;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-6m, 5m, 6m);
            var v = ov.swizzle.gggg;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
            Assert.That(5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(2.5m, -5m, 7m);
            var v = ov.swizzle.gggb;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-6.5m, -1.5m, 7.5m);
            var v = ov.swizzle.ggb;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(1.5m, 8.5m, 1.5m);
            var v = ov.swizzle.ggbr;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(6.5m, 5m, 0m);
            var v = ov.swizzle.ggbg;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(5m, 7.5m, 1m);
            var v = ov.swizzle.ggbb;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-2.5m, 0.5m, 6.5m);
            var v = ov.swizzle.gb;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(0.5m, 2.5m, -4m);
            var v = ov.swizzle.gbr;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-5.5m, -3.5m, 7m);
            var v = ov.swizzle.gbrr;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-9.5m, 1.5m, 0.5m);
            var v = ov.swizzle.gbrg;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(0.5m, -1m, -5m);
            var v = ov.swizzle.gbrb;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(-5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(7m, 0m, -0.5m);
            var v = ov.swizzle.gbg;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-3m, -6m, -9m);
            var v = ov.swizzle.gbgr;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(6m, 2m, 1.5m);
            var v = ov.swizzle.gbgg;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-9.5m, -2.5m, -4.5m);
            var v = ov.swizzle.gbgb;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-2m, -1m, -7.5m);
            var v = ov.swizzle.gbb;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(8m, -4.5m, 2m);
            var v = ov.swizzle.gbbr;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-8.5m, 9.5m, 0m);
            var v = ov.swizzle.gbbg;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(6m, -4.5m, -3m);
            var v = ov.swizzle.gbbb;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(3.5m, 7m, -1.5m);
            var v = ov.swizzle.br;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(9.5m, 3m, 6.5m);
            var v = ov.swizzle.brr;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(7m, 0m, -1.5m);
            var v = ov.swizzle.brrr;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-7m, -1.5m, 5m);
            var v = ov.swizzle.brrg;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-1m, 2.5m, -8.5m);
            var v = ov.swizzle.brrb;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-6.5m, -8.5m, -2.5m);
            var v = ov.swizzle.brg;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(5m, -1m, 5m);
            var v = ov.swizzle.brgr;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-1.5m, -2m, -5m);
            var v = ov.swizzle.brgg;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-3.5m, -1m, 6m);
            var v = ov.swizzle.brgb;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-2.5m, 8m, -1m);
            var v = ov.swizzle.brb;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-4m, 1m, -5m);
            var v = ov.swizzle.brbr;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-6m, -9.5m, 7m);
            var v = ov.swizzle.brbg;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(0.5m, 6m, 9.5m);
            var v = ov.swizzle.brbb;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(4.5m, -2m, -2.5m);
            var v = ov.swizzle.bg;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(7.5m, 5.5m, -6.5m);
            var v = ov.swizzle.bgr;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-7m, 7.5m, 2.5m);
            var v = ov.swizzle.bgrr;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-8.5m, 8.5m, -9m);
            var v = ov.swizzle.bgrg;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-3m, 0m, -5m);
            var v = ov.swizzle.bgrb;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
            Assert.That(-5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(7m, 5m, 6.5m);
            var v = ov.swizzle.bgg;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-4m, -4m, 2.5m);
            var v = ov.swizzle.bggr;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(0.5m, -9.5m, 1.5m);
            var v = ov.swizzle.bggg;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-8m, 3m, -3.5m);
            var v = ov.swizzle.bggb;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(0.5m, 5.5m, -3m);
            var v = ov.swizzle.bgb;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-4m, 2.5m, -5m);
            var v = ov.swizzle.bgbr;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-1.5m, -2m, 8.5m);
            var v = ov.swizzle.bgbg;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-9m, 1.5m, -7m);
            var v = ov.swizzle.bgbb;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(1.5m, 9m, -4m);
            var v = ov.swizzle.bb;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec3(-4m, 6m, -1m);
            var v = ov.swizzle.bbr;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(2.5m, 0m, 0m);
            var v = ov.swizzle.bbrr;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(0m, 7m, -5m);
            var v = ov.swizzle.bbrg;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-2m, -7m, 3.5m);
            var v = ov.swizzle.bbrb;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(6m, 3m, 2.5m);
            var v = ov.swizzle.bbg;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(5.5m, -9.5m, 2.5m);
            var v = ov.swizzle.bbgr;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(6.5m, -3.5m, 1m);
            var v = ov.swizzle.bbgg;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-9.5m, 6m, 6m);
            var v = ov.swizzle.bbgb;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(3m, -4.5m, -0.5m);
            var v = ov.swizzle.bbb;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec3(-6m, -0.5m, -4m);
            var v = ov.swizzle.bbbr;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-9m, -7.5m, 3m);
            var v = ov.swizzle.bbbg;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec3(-9m, -6m, -3m);
            var v = ov.swizzle.bbbb;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new decvec3(5m, -6m, 6.5m);
            var v1 = new decvec2(-4.5m, -3.5m);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-4.5m, Is.EqualTo(v0.x));
            Assert.That(-3.5m, Is.EqualTo(v0.y));
            Assert.That(6.5m, Is.EqualTo(v0.z));
        
            Assert.That(5m, Is.EqualTo(v2.x));
            Assert.That(-6m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec3(5.5m, 3m, 9.5m);
            var v1 = new decvec2(-5m, 1m);
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-5m, Is.EqualTo(v0.x));
            Assert.That(3m, Is.EqualTo(v0.y));
            Assert.That(1m, Is.EqualTo(v0.z));
        
            Assert.That(5.5m, Is.EqualTo(v2.x));
            Assert.That(9.5m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec3(5m, 9.5m, 8.5m);
            var v1 = new decvec2(9.5m, -4m);
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(5m, Is.EqualTo(v0.x));
            Assert.That(9.5m, Is.EqualTo(v0.y));
            Assert.That(-4m, Is.EqualTo(v0.z));
        
            Assert.That(9.5m, Is.EqualTo(v2.x));
            Assert.That(8.5m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec3(-0.5m, 8m, 9m);
            var v1 = new decvec3(-5m, -1m, 0m);
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-5m, Is.EqualTo(v0.x));
            Assert.That(-1m, Is.EqualTo(v0.y));
            Assert.That(0m, Is.EqualTo(v0.z));
        
            Assert.That(-0.5m, Is.EqualTo(v2.x));
            Assert.That(8m, Is.EqualTo(v2.y));
            Assert.That(9m, Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            decvec3 v0 = new decvec3(8.5m, -4.5m, 7m);
            decimal v1 = 9.5m;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(9.5m, Is.EqualTo(v0.x));
            Assert.That(-4.5m, Is.EqualTo(v0.y));
            Assert.That(7m, Is.EqualTo(v0.z));
        
            Assert.That(8.5m, Is.EqualTo(v2));
        }
        {
            decvec3 v0 = new decvec3(-6.5m, 9.5m, -0.5m);
            decimal v1 = 3.5m;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-6.5m, Is.EqualTo(v0.x));
            Assert.That(3.5m, Is.EqualTo(v0.y));
            Assert.That(-0.5m, Is.EqualTo(v0.z));
        
            Assert.That(9.5m, Is.EqualTo(v2));
        }
        {
            decvec3 v0 = new decvec3(5m, 2m, 0.5m);
            decvec2 v1 = new decvec2(0.5m, -5m);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(0.5m, Is.EqualTo(v0.x));
            Assert.That(-5m, Is.EqualTo(v0.y));
            Assert.That(0.5m, Is.EqualTo(v0.z));
        
            Assert.That(5m, Is.EqualTo(v2.x));
            Assert.That(2m, Is.EqualTo(v2.y));
        }
        {
            decvec3 v0 = new decvec3(-8m, 5.5m, -1.5m);
            decimal v1 = -9m;
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-8m, Is.EqualTo(v0.x));
            Assert.That(5.5m, Is.EqualTo(v0.y));
            Assert.That(-9m, Is.EqualTo(v0.z));
        
            Assert.That(-1.5m, Is.EqualTo(v2));
        }
        {
            decvec3 v0 = new decvec3(6.5m, -9m, -3.5m);
            decvec2 v1 = new decvec2(-1m, 7m);
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-1m, Is.EqualTo(v0.x));
            Assert.That(-9m, Is.EqualTo(v0.y));
            Assert.That(7m, Is.EqualTo(v0.z));
        
            Assert.That(6.5m, Is.EqualTo(v2.x));
            Assert.That(-3.5m, Is.EqualTo(v2.y));
        }
        {
            decvec3 v0 = new decvec3(3m, 2.5m, 9.5m);
            decvec2 v1 = new decvec2(1.5m, 0.5m);
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(3m, Is.EqualTo(v0.x));
            Assert.That(1.5m, Is.EqualTo(v0.y));
            Assert.That(0.5m, Is.EqualTo(v0.z));
        
            Assert.That(2.5m, Is.EqualTo(v2.x));
            Assert.That(9.5m, Is.EqualTo(v2.y));
        }
        {
            decvec3 v0 = new decvec3(2.5m, -0.5m, -9.5m);
            decvec3 v1 = new decvec3(4m, 5.5m, -6.5m);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4m, Is.EqualTo(v0.x));
            Assert.That(5.5m, Is.EqualTo(v0.y));
            Assert.That(-6.5m, Is.EqualTo(v0.z));
        
            Assert.That(2.5m, Is.EqualTo(v2.x));
            Assert.That(-0.5m, Is.EqualTo(v2.y));
            Assert.That(-9.5m, Is.EqualTo(v2.z));
        }
    }

}
