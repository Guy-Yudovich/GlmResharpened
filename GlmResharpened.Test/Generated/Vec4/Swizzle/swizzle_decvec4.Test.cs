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
public class DecimalSwizzleVec4Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new decvec4(2m, -8.5m, -9m, 7m);
            var v = ov.swizzle.xx;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(5m, -1.5m, 6.5m, -7m);
            var v = ov.swizzle.xxx;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(8m, -4.5m, 1m, 2.5m);
            var v = ov.swizzle.xxxx;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, -7m, 0m, -4.5m);
            var v = ov.swizzle.xxxy;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1m, 5.5m, 7m, -3.5m);
            var v = ov.swizzle.xxxz;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9.5m, -8m, 8.5m, 8m);
            var v = ov.swizzle.xxxw;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3m, -4m, 1m, 6m);
            var v = ov.swizzle.xxy;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-5.5m, -2.5m, -2m, 2m);
            var v = ov.swizzle.xxyx;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0m, -3m, -7m, -4m);
            var v = ov.swizzle.xxyy;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, 9.5m, -3m, -9.5m);
            var v = ov.swizzle.xxyz;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4.5m, -2m, -1m, 0.5m);
            var v = ov.swizzle.xxyw;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, 9m, 7m, 8.5m);
            var v = ov.swizzle.xxz;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(8.5m, 3.5m, -8.5m, -7m);
            var v = ov.swizzle.xxzx;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, 5m, -2m, -4.5m);
            var v = ov.swizzle.xxzy;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, -1m, 4.5m, 1.5m);
            var v = ov.swizzle.xxzz;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2.5m, 0.5m, 3.5m, -8.5m);
            var v = ov.swizzle.xxzw;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3m, 8.5m, 1.5m, 8m);
            var v = ov.swizzle.xxw;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(0m, -3.5m, 1m, 2m);
            var v = ov.swizzle.xxwx;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, -1.5m, 1m, -2.5m);
            var v = ov.swizzle.xxwy;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, 8m, 4.5m, 3m);
            var v = ov.swizzle.xxwz;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, 3m, 8m, 0.5m);
            var v = ov.swizzle.xxww;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, 5.5m, 7.5m, 5.5m);
            var v = ov.swizzle.xy;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(0m, 2.5m, 2.5m, -4m);
            var v = ov.swizzle.xyx;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(4m, -7.5m, 2.5m, 4.5m);
            var v = ov.swizzle.xyxx;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9m, -0.5m, -7m, -5m);
            var v = ov.swizzle.xyxy;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(-0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8m, 8.5m, 8.5m, -2m);
            var v = ov.swizzle.xyxz;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2.5m, -9m, 4.5m, -8m);
            var v = ov.swizzle.xyxw;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3m, -5.5m, -8m, -3m);
            var v = ov.swizzle.xyy;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-6m, 1.5m, -5.5m, -6.5m);
            var v = ov.swizzle.xyyx;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, 3m, -5m, -8m);
            var v = ov.swizzle.xyyy;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1m, 6.5m, 8m, 7m);
            var v = ov.swizzle.xyyz;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, -2.5m, 7.5m, 0m);
            var v = ov.swizzle.xyyw;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5.5m, 6m, 8m, -7m);
            var v = ov.swizzle.xyz;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(2.5m, -9.5m, -4.5m, 7m);
            var v = ov.swizzle.xyzx;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, 6.5m, 7.5m, -2.5m);
            var v = ov.swizzle.xyzy;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1m, -9m, 1.5m, -6m);
            var v = ov.swizzle.xyzz;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, -9m, 8.5m, -3m);
            var v = ov.swizzle.xyzw;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, 9m, -3m, -5m);
            var v = ov.swizzle.xyw;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-5m, 8.5m, -4m, -7.5m);
            var v = ov.swizzle.xywx;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(-5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0.5m, 0.5m, -8m, 4m);
            var v = ov.swizzle.xywy;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8.5m, 3.5m, -7.5m, 7.5m);
            var v = ov.swizzle.xywz;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6m, 0m, -8.5m, 6.5m);
            var v = ov.swizzle.xyww;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, -6m, -7m, -4.5m);
            var v = ov.swizzle.xz;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(5m, -2.5m, -7m, -7.5m);
            var v = ov.swizzle.xzx;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(4m, 2.5m, 4.5m, -4m);
            var v = ov.swizzle.xzxx;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, -5.5m, 3m, -4.5m);
            var v = ov.swizzle.xzxy;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, 3.5m, 2m, 3.5m);
            var v = ov.swizzle.xzxz;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, 3m, -8m, -6m);
            var v = ov.swizzle.xzxw;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8m, 3.5m, 6m, 7m);
            var v = ov.swizzle.xzy;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(7.5m, 3.5m, 0m, -3m);
            var v = ov.swizzle.xzyx;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8.5m, 1m, 7m, -8.5m);
            var v = ov.swizzle.xzyy;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, -2.5m, 9m, -2.5m);
            var v = ov.swizzle.xzyz;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8.5m, 1.5m, -7m, 7.5m);
            var v = ov.swizzle.xzyw;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6.5m, 4m, -5m, 6.5m);
            var v = ov.swizzle.xzz;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(0.5m, 6.5m, 4m, -7.5m);
            var v = ov.swizzle.xzzx;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8.5m, -2.5m, 0.5m, 2m);
            var v = ov.swizzle.xzzy;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8.5m, 0m, 7m, -3m);
            var v = ov.swizzle.xzzz;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8.5m, 9m, -4.5m, -1m);
            var v = ov.swizzle.xzzw;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2.5m, -8.5m, -6m, -2.5m);
            var v = ov.swizzle.xzw;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-7m, -7.5m, 2.5m, 5m);
            var v = ov.swizzle.xzwx;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, -6m, -3m, -5m);
            var v = ov.swizzle.xzwy;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3.5m, -9.5m, -9.5m, -4m);
            var v = ov.swizzle.xzwz;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8m, 9m, -8m, 0m);
            var v = ov.swizzle.xzww;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, -8m, -5m, -2m);
            var v = ov.swizzle.xw;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(-2m, 4m, -7.5m, 2.5m);
            var v = ov.swizzle.xwx;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-9.5m, 7.5m, 5m, -2m);
            var v = ov.swizzle.xwxx;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, 6m, 5m, -6m);
            var v = ov.swizzle.xwxy;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1.5m, -2.5m, -9.5m, 7m);
            var v = ov.swizzle.xwxz;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4m, 8.5m, 8.5m, -7.5m);
            var v = ov.swizzle.xwxw;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5m, -5m, -7m, -9m);
            var v = ov.swizzle.xwy;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-8.5m, 3.5m, 4.5m, -2m);
            var v = ov.swizzle.xwyx;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, -5.5m, -8.5m, -4m);
            var v = ov.swizzle.xwyy;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, 3m, -6m, -2m);
            var v = ov.swizzle.xwyz;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9.5m, 9.5m, -3.5m, -3.5m);
            var v = ov.swizzle.xwyw;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1m, 0m, 8m, -9.5m);
            var v = ov.swizzle.xwz;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-4m, 4m, -4.5m, 0.5m);
            var v = ov.swizzle.xwzx;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, 9m, 6.5m, 1.5m);
            var v = ov.swizzle.xwzy;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9.5m, 3.5m, 7.5m, 6.5m);
            var v = ov.swizzle.xwzz;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1.5m, 3m, -2m, -3.5m);
            var v = ov.swizzle.xwzw;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3m, 3.5m, -9.5m, -7.5m);
            var v = ov.swizzle.xww;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-4.5m, 1.5m, 9m, -5.5m);
            var v = ov.swizzle.xwwx;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2m, 7m, 7m, 5m);
            var v = ov.swizzle.xwwy;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3m, -2m, -2m, -4m);
            var v = ov.swizzle.xwwz;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, 7.5m, 4m, -7m);
            var v = ov.swizzle.xwww;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8m, 3m, -7.5m, -7.5m);
            var v = ov.swizzle.yx;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(-1.5m, 0.5m, 4.5m, -3m);
            var v = ov.swizzle.yxx;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(6m, -9m, -5.5m, 6.5m);
            var v = ov.swizzle.yxxx;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1.5m, 9.5m, -6.5m, -7m);
            var v = ov.swizzle.yxxy;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9.5m, -3.5m, 4.5m, -7.5m);
            var v = ov.swizzle.yxxz;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, 0m, -9m, -7.5m);
            var v = ov.swizzle.yxxw;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, 1.5m, -8m, 7m);
            var v = ov.swizzle.yxy;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-8.5m, -6.5m, -0.5m, 1.5m);
            var v = ov.swizzle.yxyx;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8.5m, 4.5m, -8m, 9.5m);
            var v = ov.swizzle.yxyy;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2m, 8.5m, 4.5m, 5.5m);
            var v = ov.swizzle.yxyz;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, 7.5m, -7m, 3.5m);
            var v = ov.swizzle.yxyw;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, -1m, -7m, -4m);
            var v = ov.swizzle.yxz;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-1.5m, 5.5m, 3.5m, -8.5m);
            var v = ov.swizzle.yxzx;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, -7.5m, -7.5m, 7m);
            var v = ov.swizzle.yxzy;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4.5m, 0m, -9m, 7.5m);
            var v = ov.swizzle.yxzz;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2m, -3.5m, 1.5m, -5.5m);
            var v = ov.swizzle.yxzw;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, 2.5m, 7.5m, 3.5m);
            var v = ov.swizzle.yxw;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-7.5m, -5.5m, 5m, -7.5m);
            var v = ov.swizzle.yxwx;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, 9.5m, -4.5m, 7.5m);
            var v = ov.swizzle.yxwy;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6.5m, -3.5m, 7.5m, 1.5m);
            var v = ov.swizzle.yxwz;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, 4m, -9.5m, -3.5m);
            var v = ov.swizzle.yxww;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, 8m, -0.5m, -6m);
            var v = ov.swizzle.yy;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(-3m, 9m, -5m, -1m);
            var v = ov.swizzle.yyx;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-9m, 7.5m, -6.5m, -2m);
            var v = ov.swizzle.yyxx;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, 3.5m, 3m, 1.5m);
            var v = ov.swizzle.yyxy;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, -5.5m, 2.5m, 3m);
            var v = ov.swizzle.yyxz;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, -2m, -0.5m, 2m);
            var v = ov.swizzle.yyxw;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, -4.5m, -5.5m, 9.5m);
            var v = ov.swizzle.yyy;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(3m, -1.5m, -6.5m, 6m);
            var v = ov.swizzle.yyyx;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, 4m, 5.5m, -8.5m);
            var v = ov.swizzle.yyyy;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3m, -8.5m, -8.5m, -2m);
            var v = ov.swizzle.yyyz;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9m, 4.5m, 2m, 4.5m);
            var v = ov.swizzle.yyyw;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6m, -4m, 1.5m, 0.5m);
            var v = ov.swizzle.yyz;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-7.5m, 5m, -8m, -0.5m);
            var v = ov.swizzle.yyzx;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3m, -6m, 6.5m, -7m);
            var v = ov.swizzle.yyzy;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9.5m, -3.5m, -9m, -1.5m);
            var v = ov.swizzle.yyzz;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3.5m, -6m, 7m, 1.5m);
            var v = ov.swizzle.yyzw;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, -7m, 5m, 0m);
            var v = ov.swizzle.yyw;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(8.5m, -6.5m, -1.5m, 2.5m);
            var v = ov.swizzle.yywx;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3m, -9.5m, 4.5m, 4.5m);
            var v = ov.swizzle.yywy;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9m, 4.5m, -2.5m, -5.5m);
            var v = ov.swizzle.yywz;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, 3.5m, -7m, 7.5m);
            var v = ov.swizzle.yyww;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1m, 4.5m, 3.5m, 0.5m);
            var v = ov.swizzle.yz;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(8m, -8m, 0m, -8m);
            var v = ov.swizzle.yzx;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(2m, 2.5m, -4.5m, 3.5m);
            var v = ov.swizzle.yzxx;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2.5m, -1m, -8.5m, 9.5m);
            var v = ov.swizzle.yzxy;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7m, 1.5m, 2.5m, 9.5m);
            var v = ov.swizzle.yzxz;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8m, -3.5m, -3.5m, 3.5m);
            var v = ov.swizzle.yzxw;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8.5m, 1m, 7m, -4.5m);
            var v = ov.swizzle.yzy;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(9.5m, 4.5m, 5.5m, 2.5m);
            var v = ov.swizzle.yzyx;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9.5m, 9m, -8.5m, -9m);
            var v = ov.swizzle.yzyy;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6.5m, -5m, 2.5m, -9.5m);
            var v = ov.swizzle.yzyz;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, -1m, -0.5m, -1m);
            var v = ov.swizzle.yzyw;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5.5m, 0m, 7m, 8.5m);
            var v = ov.swizzle.yzz;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-4m, -2.5m, -6m, 1m);
            var v = ov.swizzle.yzzx;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1m, -7m, -9.5m, -5.5m);
            var v = ov.swizzle.yzzy;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8m, 0m, 8m, 6m);
            var v = ov.swizzle.yzzz;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1m, -5m, -9m, 7m);
            var v = ov.swizzle.yzzw;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, 2.5m, 4.5m, -7m);
            var v = ov.swizzle.yzw;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(0.5m, 1m, -7m, 3.5m);
            var v = ov.swizzle.yzwx;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8.5m, -2m, -7m, 6m);
            var v = ov.swizzle.yzwy;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6.5m, -5m, 7.5m, -9.5m);
            var v = ov.swizzle.yzwz;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, 8m, -2m, -2m);
            var v = ov.swizzle.yzww;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9m, 3.5m, 1.5m, -7.5m);
            var v = ov.swizzle.yw;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(0.5m, 6.5m, -1m, -6.5m);
            var v = ov.swizzle.ywx;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(5m, -3.5m, 9m, 6m);
            var v = ov.swizzle.ywxx;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
            Assert.That(5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2.5m, -7.5m, -3m, 2m);
            var v = ov.swizzle.ywxy;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, 0.5m, 8m, -2m);
            var v = ov.swizzle.ywxz;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1m, -6.5m, 3m, -0.5m);
            var v = ov.swizzle.ywxw;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(-0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9.5m, -3m, -1.5m, 3.5m);
            var v = ov.swizzle.ywy;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(2m, -1.5m, -2m, 1m);
            var v = ov.swizzle.ywyx;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3m, 6m, -0.5m, 4m);
            var v = ov.swizzle.ywyy;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1m, -3m, -2.5m, 3.5m);
            var v = ov.swizzle.ywyz;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0.5m, 3.5m, -2.5m, -2m);
            var v = ov.swizzle.ywyw;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1m, -1m, -5m, -5m);
            var v = ov.swizzle.ywz;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(1m, 4.5m, -5m, 4m);
            var v = ov.swizzle.ywzx;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0m, 9.5m, 1m, 6.5m);
            var v = ov.swizzle.ywzy;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, 1m, -7.5m, -8m);
            var v = ov.swizzle.ywzz;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8m, -7m, -9.5m, -8m);
            var v = ov.swizzle.ywzw;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, 8m, 3m, -4.5m);
            var v = ov.swizzle.yww;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(3.5m, 7m, 1m, 3.5m);
            var v = ov.swizzle.ywwx;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, -5m, -7.5m, -7m);
            var v = ov.swizzle.ywwy;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5.5m, 1.5m, -1.5m, -0.5m);
            var v = ov.swizzle.ywwz;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, -3m, 2.5m, 8m);
            var v = ov.swizzle.ywww;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, 7m, 1m, 4m);
            var v = ov.swizzle.zx;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(4m, 2.5m, -6m, 9.5m);
            var v = ov.swizzle.zxx;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(0.5m, 9m, -4.5m, -3m);
            var v = ov.swizzle.zxxx;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, 9m, 8.5m, 3.5m);
            var v = ov.swizzle.zxxy;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7m, 0.5m, -7.5m, 4.5m);
            var v = ov.swizzle.zxxz;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, -8.5m, 1m, -4.5m);
            var v = ov.swizzle.zxxw;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8m, -4.5m, 0m, 7.5m);
            var v = ov.swizzle.zxy;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-4m, 2.5m, -9.5m, 5.5m);
            var v = ov.swizzle.zxyx;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4.5m, -2m, 3m, 6m);
            var v = ov.swizzle.zxyy;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7m, 8.5m, -8.5m, 0m);
            var v = ov.swizzle.zxyz;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2.5m, 1m, 2m, 3.5m);
            var v = ov.swizzle.zxyw;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0.5m, 8m, 2m, -3.5m);
            var v = ov.swizzle.zxz;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(3.5m, 5.5m, -7.5m, 7m);
            var v = ov.swizzle.zxzx;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, 7.5m, -5m, 3.5m);
            var v = ov.swizzle.zxzy;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, -6m, -2.5m, -9.5m);
            var v = ov.swizzle.zxzz;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2.5m, -8m, -3.5m, 7.5m);
            var v = ov.swizzle.zxzw;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, -0.5m, -1.5m, 2m);
            var v = ov.swizzle.zxw;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(5m, 1.5m, -4.5m, 8m);
            var v = ov.swizzle.zxwx;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9m, -7.5m, 1m, 2.5m);
            var v = ov.swizzle.zxwy;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9m, 7m, 5.5m, 8m);
            var v = ov.swizzle.zxwz;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, -4m, 4m, -9m);
            var v = ov.swizzle.zxww;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1m, -3m, 4m, -2.5m);
            var v = ov.swizzle.zy;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(6.5m, -1m, 0m, 1.5m);
            var v = ov.swizzle.zyx;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-2m, 0m, 8m, -4m);
            var v = ov.swizzle.zyxx;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5m, 4m, 4m, 1m);
            var v = ov.swizzle.zyxy;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8.5m, 0m, -8.5m, 1m);
            var v = ov.swizzle.zyxz;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9m, -4m, 8.5m, 8m);
            var v = ov.swizzle.zyxw;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6.5m, -6.5m, -4m, 8.5m);
            var v = ov.swizzle.zyy;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-8.5m, -8m, 8.5m, -8m);
            var v = ov.swizzle.zyyx;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, 7m, -2.5m, -6m);
            var v = ov.swizzle.zyyy;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, 0m, 6m, 5.5m);
            var v = ov.swizzle.zyyz;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, 3.5m, 6.5m, 8m);
            var v = ov.swizzle.zyyw;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, -2.5m, -7m, -4m);
            var v = ov.swizzle.zyz;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(3m, 4.5m, -1.5m, -8.5m);
            var v = ov.swizzle.zyzx;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, 2m, 9m, 6.5m);
            var v = ov.swizzle.zyzy;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5m, 6.5m, 1.5m, -3m);
            var v = ov.swizzle.zyzz;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6.5m, 1m, -1m, 4.5m);
            var v = ov.swizzle.zyzw;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, 0.5m, 0m, 6m);
            var v = ov.swizzle.zyw;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-8m, -1.5m, -7m, -9.5m);
            var v = ov.swizzle.zywx;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, -3.5m, 9m, -6m);
            var v = ov.swizzle.zywy;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8m, -0.5m, 5.5m, 8m);
            var v = ov.swizzle.zywz;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, 0m, 5.5m, -2.5m);
            var v = ov.swizzle.zyww;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, -7m, -4.5m, -1m);
            var v = ov.swizzle.zz;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(8.5m, 0.5m, 1m, -1.5m);
            var v = ov.swizzle.zzx;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(8m, 3.5m, 8.5m, 0.5m);
            var v = ov.swizzle.zzxx;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6.5m, 1m, 6m, -6.5m);
            var v = ov.swizzle.zzxy;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3.5m, 9m, 5.5m, -5m);
            var v = ov.swizzle.zzxz;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, 7m, -2.5m, 7m);
            var v = ov.swizzle.zzxw;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2.5m, 3.5m, -9m, -4.5m);
            var v = ov.swizzle.zzy;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(0m, -7.5m, 6m, 5.5m);
            var v = ov.swizzle.zzyx;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, -5.5m, 4m, -4.5m);
            var v = ov.swizzle.zzyy;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, 0.5m, 8m, -2.5m);
            var v = ov.swizzle.zzyz;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2.5m, -0.5m, -2m, 1m);
            var v = ov.swizzle.zzyw;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2.5m, -9.5m, 2.5m, -6m);
            var v = ov.swizzle.zzz;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-6.5m, -3m, -7.5m, 6.5m);
            var v = ov.swizzle.zzzx;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(-6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4m, -8.5m, 9m, -7.5m);
            var v = ov.swizzle.zzzy;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0.5m, -7m, -8m, 4m);
            var v = ov.swizzle.zzzz;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1m, -6m, -1.5m, -3.5m);
            var v = ov.swizzle.zzzw;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3.5m, 2m, -6.5m, 8.5m);
            var v = ov.swizzle.zzw;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(7.5m, -8.5m, -7m, 6.5m);
            var v = ov.swizzle.zzwx;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1m, 8m, -2.5m, -1.5m);
            var v = ov.swizzle.zzwy;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6.5m, -3.5m, -9.5m, -2m);
            var v = ov.swizzle.zzwz;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0m, 3m, 2m, -2.5m);
            var v = ov.swizzle.zzww;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0m, 9m, 1.5m, -4.5m);
            var v = ov.swizzle.zw;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(-5m, -6.5m, 5.5m, -1.5m);
            var v = ov.swizzle.zwx;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-2m, 3m, -7m, -2m);
            var v = ov.swizzle.zwxx;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0m, -4.5m, -5m, -5.5m);
            var v = ov.swizzle.zwxy;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6.5m, 4.5m, -9m, 2m);
            var v = ov.swizzle.zwxz;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5.5m, -3.5m, 5.5m, 6.5m);
            var v = ov.swizzle.zwxw;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, -7.5m, -4.5m, 4m);
            var v = ov.swizzle.zwy;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(7.5m, 5m, 3m, 7m);
            var v = ov.swizzle.zwyx;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3m, 0m, -3.5m, -7m);
            var v = ov.swizzle.zwyy;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2m, 8.5m, -5.5m, -4m);
            var v = ov.swizzle.zwyz;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4.5m, -0.5m, -5.5m, 7.5m);
            var v = ov.swizzle.zwyw;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, -5m, -2.5m, -2m);
            var v = ov.swizzle.zwz;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-2m, 6.5m, -5m, 6m);
            var v = ov.swizzle.zwzx;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4.5m, 0m, 2.5m, -5m);
            var v = ov.swizzle.zwzy;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5m, 4.5m, 1.5m, 3.5m);
            var v = ov.swizzle.zwzz;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, 1.5m, 1.5m, 6m);
            var v = ov.swizzle.zwzw;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9.5m, 8m, 8.5m, 0m);
            var v = ov.swizzle.zww;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(8.5m, 8.5m, -2m, 8.5m);
            var v = ov.swizzle.zwwx;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1m, 4m, -7m, 6m);
            var v = ov.swizzle.zwwy;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1m, 7.5m, 4m, -8m);
            var v = ov.swizzle.zwwz;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, -4m, 3.5m, 0m);
            var v = ov.swizzle.zwww;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0.5m, 7.5m, -6.5m, -3m);
            var v = ov.swizzle.wx;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(7m, -2m, 1m, -8m);
            var v = ov.swizzle.wxx;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(6m, 1.5m, -7m, 4.5m);
            var v = ov.swizzle.wxxx;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, -8m, 7.5m, -6.5m);
            var v = ov.swizzle.wxxy;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, -3.5m, -4m, -3m);
            var v = ov.swizzle.wxxz;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, -7m, 6.5m, -9.5m);
            var v = ov.swizzle.wxxw;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6.5m, -4.5m, -3m, -7m);
            var v = ov.swizzle.wxy;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-0.5m, -3m, 8.5m, -5.5m);
            var v = ov.swizzle.wxyx;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
            Assert.That(-0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8.5m, 0.5m, -6m, 2m);
            var v = ov.swizzle.wxyy;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3.5m, -4.5m, 2.5m, -3.5m);
            var v = ov.swizzle.wxyz;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6.5m, 4.5m, 2.5m, -9m);
            var v = ov.swizzle.wxyw;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1.5m, -6.5m, 8m, -5.5m);
            var v = ov.swizzle.wxz;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(0m, -7.5m, 1m, 7m);
            var v = ov.swizzle.wxzx;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0m, -9.5m, -7m, -4m);
            var v = ov.swizzle.wxzy;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0m, 2m, -0.5m, -7.5m);
            var v = ov.swizzle.wxzz;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(-0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8.5m, -5.5m, -1.5m, 3.5m);
            var v = ov.swizzle.wxzw;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2.5m, 3.5m, 5.5m, 6m);
            var v = ov.swizzle.wxw;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(1m, 5.5m, 6.5m, 1.5m);
            var v = ov.swizzle.wxwx;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, -2.5m, -7m, 0.5m);
            var v = ov.swizzle.wxwy;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, -7m, 2.5m, 0m);
            var v = ov.swizzle.wxwz;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, -0.5m, -7m, 7m);
            var v = ov.swizzle.wxww;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2m, 0.5m, -6.5m, -9m);
            var v = ov.swizzle.wy;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(-4m, 2m, 1m, -5.5m);
            var v = ov.swizzle.wyx;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(6.5m, 9m, -1.5m, -2m);
            var v = ov.swizzle.wyxx;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, 8.5m, -2.5m, 4.5m);
            var v = ov.swizzle.wyxy;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2.5m, 2m, -7.5m, 4m);
            var v = ov.swizzle.wyxz;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3.5m, -1m, -4m, -4m);
            var v = ov.swizzle.wyxw;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, -3.5m, -0.5m, -5.5m);
            var v = ov.swizzle.wyy;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(9m, -1.5m, 5m, 9m);
            var v = ov.swizzle.wyyx;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7m, -8.5m, -7.5m, 1m);
            var v = ov.swizzle.wyyy;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9m, -7m, 3.5m, 9.5m);
            var v = ov.swizzle.wyyz;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, -2m, 5.5m, -5.5m);
            var v = ov.swizzle.wyyw;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9.5m, 4m, -5.5m, -4.5m);
            var v = ov.swizzle.wyz;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(0.5m, 7.5m, -4m, -5m);
            var v = ov.swizzle.wyzx;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, -2m, -8.5m, 0m);
            var v = ov.swizzle.wyzy;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6m, 9m, -6m, -2.5m);
            var v = ov.swizzle.wyzz;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3m, -8m, -5m, 7m);
            var v = ov.swizzle.wyzw;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3m, -8m, 4m, -4.5m);
            var v = ov.swizzle.wyw;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-7m, -4.5m, -4.5m, 9m);
            var v = ov.swizzle.wywx;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8m, -6.5m, -2m, -4m);
            var v = ov.swizzle.wywy;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(-6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6m, 0.5m, -4m, 8.5m);
            var v = ov.swizzle.wywz;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, 3m, 4.5m, -2m);
            var v = ov.swizzle.wyww;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, 1.5m, 2m, 5.5m);
            var v = ov.swizzle.wz;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(9.5m, -8.5m, -4.5m, 9.5m);
            var v = ov.swizzle.wzx;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(0m, 5m, -3.5m, -5m);
            var v = ov.swizzle.wzxx;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, -2.5m, -9.5m, -8.5m);
            var v = ov.swizzle.wzxy;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9.5m, 9.5m, 8m, 4m);
            var v = ov.swizzle.wzxz;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3m, 3m, 5m, -5.5m);
            var v = ov.swizzle.wzxw;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9.5m, 7m, -4.5m, -3.5m);
            var v = ov.swizzle.wzy;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(5.5m, -8m, -4.5m, 9m);
            var v = ov.swizzle.wzyx;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, 2m, 3.5m, -3m);
            var v = ov.swizzle.wzyy;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6m, 8m, -4.5m, 6.5m);
            var v = ov.swizzle.wzyz;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9.5m, -4.5m, 9m, 2m);
            var v = ov.swizzle.wzyw;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, 6.5m, -7m, -1.5m);
            var v = ov.swizzle.wzz;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-1m, 3.5m, 8.5m, 2m);
            var v = ov.swizzle.wzzx;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5.5m, -0.5m, 9.5m, -1m);
            var v = ov.swizzle.wzzy;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(-0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3.5m, -9m, 5.5m, 2.5m);
            var v = ov.swizzle.wzzz;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5.5m, 9.5m, 4m, -6.5m);
            var v = ov.swizzle.wzzw;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(-6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8.5m, -6m, 1.5m, 4.5m);
            var v = ov.swizzle.wzw;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(3.5m, 6m, 5m, 1.5m);
            var v = ov.swizzle.wzwx;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, -2m, 5m, -2.5m);
            var v = ov.swizzle.wzwy;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, 2m, -2.5m, 3m);
            var v = ov.swizzle.wzwz;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, 7.5m, -6m, 2m);
            var v = ov.swizzle.wzww;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9.5m, -7.5m, -5m, 4.5m);
            var v = ov.swizzle.ww;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(3m, -6.5m, -2.5m, 6.5m);
            var v = ov.swizzle.wwx;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-4m, 3.5m, 1m, 0m);
            var v = ov.swizzle.wwxx;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8.5m, -3.5m, -7.5m, -8.5m);
            var v = ov.swizzle.wwxy;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4m, -7.5m, 4.5m, 3m);
            var v = ov.swizzle.wwxz;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1.5m, 7m, -1.5m, -6.5m);
            var v = ov.swizzle.wwxw;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(-6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, -2m, -6m, -6.5m);
            var v = ov.swizzle.wwy;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(2.5m, 2.5m, 1m, 8.5m);
            var v = ov.swizzle.wwyx;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6.5m, 1m, 2m, 9.5m);
            var v = ov.swizzle.wwyy;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1m, 7.5m, 1.5m, -1m);
            var v = ov.swizzle.wwyz;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9.5m, 8m, -7m, -8.5m);
            var v = ov.swizzle.wwyw;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1m, 4m, 6m, 7m);
            var v = ov.swizzle.wwz;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-8.5m, 5m, 8.5m, 8m);
            var v = ov.swizzle.wwzx;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, -3m, -5m, -3m);
            var v = ov.swizzle.wwzy;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, 1.5m, -1m, 2.5m);
            var v = ov.swizzle.wwzz;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7m, 3m, 4m, -7.5m);
            var v = ov.swizzle.wwzw;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2.5m, 2m, -7m, -9m);
            var v = ov.swizzle.www;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-5.5m, -7.5m, -9m, 7m);
            var v = ov.swizzle.wwwx;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, -5.5m, -6.5m, -9m);
            var v = ov.swizzle.wwwy;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0.5m, 7m, -2m, -9m);
            var v = ov.swizzle.wwwz;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4m, 7m, 2m, -3.5m);
            var v = ov.swizzle.wwww;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new decvec4(0.5m, 4m, 7m, 1.5m);
            var v = ov.swizzle.rr;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(-4.5m, -2.5m, 8m, 7m);
            var v = ov.swizzle.rrr;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(5.5m, -3m, 5m, -8m);
            var v = ov.swizzle.rrrr;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, -1.5m, -5m, -3.5m);
            var v = ov.swizzle.rrrg;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9m, 9m, -3m, 1m);
            var v = ov.swizzle.rrrb;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4.5m, 4m, -1m, -2.5m);
            var v = ov.swizzle.rrra;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8m, -9.5m, -2m, -3.5m);
            var v = ov.swizzle.rrg;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(0m, 0.5m, -8m, -4m);
            var v = ov.swizzle.rrgr;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6m, 2m, 7.5m, 6.5m);
            var v = ov.swizzle.rrgg;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, 2.5m, 0m, -9m);
            var v = ov.swizzle.rrgb;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5m, 2m, 0.5m, -2m);
            var v = ov.swizzle.rrga;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1m, -3.5m, 2m, 8.5m);
            var v = ov.swizzle.rrb;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(7m, 9m, 4.5m, -3m);
            var v = ov.swizzle.rrbr;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, 8m, 6.5m, -3.5m);
            var v = ov.swizzle.rrbg;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, -9.5m, -3m, 4m);
            var v = ov.swizzle.rrbb;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6m, -6.5m, 7m, 5m);
            var v = ov.swizzle.rrba;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5.5m, 1.5m, 2m, 3m);
            var v = ov.swizzle.rra;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(1.5m, -8m, 2m, -2.5m);
            var v = ov.swizzle.rrar;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9m, 4.5m, -2.5m, -7.5m);
            var v = ov.swizzle.rrag;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, 8.5m, -3.5m, 2.5m);
            var v = ov.swizzle.rrab;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8m, -3m, -9m, 0.5m);
            var v = ov.swizzle.rraa;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6.5m, 5m, 0.5m, 6m);
            var v = ov.swizzle.rg;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(5m, -2m, 2m, 3m);
            var v = ov.swizzle.rgr;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-9m, 5.5m, 3m, 2.5m);
            var v = ov.swizzle.rgrr;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5.5m, -4.5m, -7m, 9m);
            var v = ov.swizzle.rgrg;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, 9.5m, 7m, -0.5m);
            var v = ov.swizzle.rgrb;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7m, 6m, 2m, 0.5m);
            var v = ov.swizzle.rgra;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, -5m, -2m, 5.5m);
            var v = ov.swizzle.rgg;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(4.5m, -8.5m, -2.5m, 2m);
            var v = ov.swizzle.rggr;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3m, -7m, 9m, -0.5m);
            var v = ov.swizzle.rggg;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1m, 5.5m, 7.5m, -9.5m);
            var v = ov.swizzle.rggb;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6m, 8.5m, 8m, -4m);
            var v = ov.swizzle.rgga;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0.5m, 5.5m, -3.5m, -1.5m);
            var v = ov.swizzle.rgb;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-7.5m, -6m, 8m, -8m);
            var v = ov.swizzle.rgbr;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, 0.5m, -6.5m, -0.5m);
            var v = ov.swizzle.rgbg;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, 0m, -4.5m, 1.5m);
            var v = ov.swizzle.rgbb;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9.5m, 6m, 9m, 7.5m);
            var v = ov.swizzle.rgba;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8m, 1m, -1.5m, -8m);
            var v = ov.swizzle.rga;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-6m, -2.5m, 7m, -1.5m);
            var v = ov.swizzle.rgar;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1m, -1.5m, -4m, 8m);
            var v = ov.swizzle.rgag;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8.5m, -1.5m, 9.5m, -2.5m);
            var v = ov.swizzle.rgab;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1.5m, -6.5m, -4m, -8m);
            var v = ov.swizzle.rgaa;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2m, 8m, 6.5m, -4m);
            var v = ov.swizzle.rb;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(4.5m, -9.5m, -2.5m, 1m);
            var v = ov.swizzle.rbr;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-1m, 6m, -9.5m, 8m);
            var v = ov.swizzle.rbrr;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, -1m, 5m, -0.5m);
            var v = ov.swizzle.rbrg;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, 8m, -3m, 5.5m);
            var v = ov.swizzle.rbrb;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7m, -9.5m, -7m, -8m);
            var v = ov.swizzle.rbra;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, -4m, 0.5m, -5m);
            var v = ov.swizzle.rbg;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(0m, 7.5m, 3m, -6m);
            var v = ov.swizzle.rbgr;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, 1.5m, -4.5m, 9.5m);
            var v = ov.swizzle.rbgg;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4m, -5m, -5.5m, 5.5m);
            var v = ov.swizzle.rbgb;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0m, 6m, -8m, 5.5m);
            var v = ov.swizzle.rbga;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7m, 4m, -9.5m, -2.5m);
            var v = ov.swizzle.rbb;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-7.5m, -1m, -8.5m, -9.5m);
            var v = ov.swizzle.rbbr;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1m, -8m, -1m, 1.5m);
            var v = ov.swizzle.rbbg;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2.5m, -9m, 7.5m, -8.5m);
            var v = ov.swizzle.rbbb;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0.5m, -2m, 0m, -3m);
            var v = ov.swizzle.rbba;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, 4m, -5m, 7.5m);
            var v = ov.swizzle.rba;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-4.5m, 5m, -5.5m, 1.5m);
            var v = ov.swizzle.rbar;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, -8m, 5.5m, 1m);
            var v = ov.swizzle.rbag;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, -7.5m, 9m, -2m);
            var v = ov.swizzle.rbab;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, 2m, 2.5m, 0.5m);
            var v = ov.swizzle.rbaa;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, -5.5m, 5m, -5m);
            var v = ov.swizzle.ra;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(-9.5m, 3.5m, 7m, -3.5m);
            var v = ov.swizzle.rar;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-8m, 3m, 5m, -1.5m);
            var v = ov.swizzle.rarr;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, 4m, 2.5m, 3m);
            var v = ov.swizzle.rarg;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, -6.5m, 1m, -7m);
            var v = ov.swizzle.rarb;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3.5m, -0.5m, 5.5m, 2.5m);
            var v = ov.swizzle.rara;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6.5m, 9m, -0.5m, 9m);
            var v = ov.swizzle.rag;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(8m, -4.5m, -2.5m, -2.5m);
            var v = ov.swizzle.ragr;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9.5m, -1m, 5.5m, -9m);
            var v = ov.swizzle.ragg;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9.5m, 9.5m, -7m, 2.5m);
            var v = ov.swizzle.ragb;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8.5m, 7.5m, -4m, -8.5m);
            var v = ov.swizzle.raga;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3m, 6m, 5.5m, 7.5m);
            var v = ov.swizzle.rab;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(0.5m, 6m, -7.5m, -1m);
            var v = ov.swizzle.rabr;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0m, -6m, 3m, -1.5m);
            var v = ov.swizzle.rabg;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, -3m, 1.5m, -1m);
            var v = ov.swizzle.rabb;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4m, 7.5m, -8m, 2.5m);
            var v = ov.swizzle.raba;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6m, -8m, 8m, 5.5m);
            var v = ov.swizzle.raa;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(9m, -3m, 3m, 0.5m);
            var v = ov.swizzle.raar;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, 9m, -8m, -0.5m);
            var v = ov.swizzle.raag;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5m, -4m, -9.5m, -7m);
            var v = ov.swizzle.raab;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, 1.5m, -9.5m, 1m);
            var v = ov.swizzle.raaa;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3m, -7m, -3.5m, 3m);
            var v = ov.swizzle.gr;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(6m, 7m, 0.5m, -3.5m);
            var v = ov.swizzle.grr;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(7m, 6m, -2.5m, 0m);
            var v = ov.swizzle.grrr;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9.5m, -8.5m, 5m, 4.5m);
            var v = ov.swizzle.grrg;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8.5m, 0m, -1.5m, -7m);
            var v = ov.swizzle.grrb;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, 2.5m, 5m, 0.5m);
            var v = ov.swizzle.grra;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, -5m, -3m, -5m);
            var v = ov.swizzle.grg;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(2.5m, -5m, 7.5m, -4m);
            var v = ov.swizzle.grgr;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8m, -6m, -0.5m, 9.5m);
            var v = ov.swizzle.grgg;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, 4m, -1.5m, 2m);
            var v = ov.swizzle.grgb;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, -8m, -7.5m, 8.5m);
            var v = ov.swizzle.grga;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6.5m, -8m, 8m, 4.5m);
            var v = ov.swizzle.grb;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(8m, -4.5m, -8m, -3m);
            var v = ov.swizzle.grbr;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, 2m, 8.5m, -1m);
            var v = ov.swizzle.grbg;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2m, 5.5m, 6m, 2.5m);
            var v = ov.swizzle.grbb;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, -5m, 4.5m, 2.5m);
            var v = ov.swizzle.grba;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9m, -4m, -7.5m, 4m);
            var v = ov.swizzle.gra;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(2.5m, 6m, 3m, 4.5m);
            var v = ov.swizzle.grar;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3m, -3.5m, 5.5m, -4.5m);
            var v = ov.swizzle.grag;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1m, 6m, 7m, -9.5m);
            var v = ov.swizzle.grab;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, -9m, 6m, 6m);
            var v = ov.swizzle.graa;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, -5.5m, -1m, -6m);
            var v = ov.swizzle.gg;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(-7m, -8m, -1.5m, 5.5m);
            var v = ov.swizzle.ggr;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(8.5m, 5.5m, 7m, 6m);
            var v = ov.swizzle.ggrr;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, -0.5m, -0.5m, 9m);
            var v = ov.swizzle.ggrg;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5.5m, 4m, 1m, 1m);
            var v = ov.swizzle.ggrb;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, -6.5m, 0m, -6m);
            var v = ov.swizzle.ggra;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7m, -4m, 0m, 5m);
            var v = ov.swizzle.ggg;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-1.5m, -3.5m, -3.5m, -5m);
            var v = ov.swizzle.gggr;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8m, -2.5m, 5.5m, -3.5m);
            var v = ov.swizzle.gggg;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, 6m, -2.5m, -4m);
            var v = ov.swizzle.gggb;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9m, 7m, 6.5m, -7m);
            var v = ov.swizzle.ggga;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8m, -1.5m, 1m, -8.5m);
            var v = ov.swizzle.ggb;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-7m, 8.5m, -5.5m, 1m);
            var v = ov.swizzle.ggbr;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, 4m, -5.5m, -4m);
            var v = ov.swizzle.ggbg;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6.5m, 4.5m, 7m, 3m);
            var v = ov.swizzle.ggbb;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8m, -7.5m, 7m, -2m);
            var v = ov.swizzle.ggba;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9m, 3.5m, 8.5m, 6.5m);
            var v = ov.swizzle.gga;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(4.5m, 3m, 6m, -1.5m);
            var v = ov.swizzle.ggar;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, -1.5m, -6.5m, -5m);
            var v = ov.swizzle.ggag;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2.5m, -6.5m, 8.5m, -9m);
            var v = ov.swizzle.ggab;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2m, -9m, -1.5m, -0.5m);
            var v = ov.swizzle.ggaa;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(-0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, -5.5m, 8.5m, 3m);
            var v = ov.swizzle.gb;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(2m, -8.5m, 2m, 7m);
            var v = ov.swizzle.gbr;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(9.5m, -5.5m, 5.5m, 6.5m);
            var v = ov.swizzle.gbrr;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9.5m, -4.5m, 7m, -4.5m);
            var v = ov.swizzle.gbrg;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, 4m, -2.5m, -3m);
            var v = ov.swizzle.gbrb;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, 6.5m, -4.5m, -1.5m);
            var v = ov.swizzle.gbra;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, 9m, -2.5m, 0m);
            var v = ov.swizzle.gbg;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(6.5m, -0.5m, 1.5m, 8.5m);
            var v = ov.swizzle.gbgr;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, -8m, 8m, -3.5m);
            var v = ov.swizzle.gbgg;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, 5.5m, 3.5m, -3m);
            var v = ov.swizzle.gbgb;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1m, 9.5m, -0.5m, 2.5m);
            var v = ov.swizzle.gbga;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, -2.5m, -5m, 2m);
            var v = ov.swizzle.gbb;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-6m, -3m, 0.5m, 6m);
            var v = ov.swizzle.gbbr;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2.5m, -5m, 8.5m, 5m);
            var v = ov.swizzle.gbbg;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(-5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8.5m, 9m, -8.5m, 3.5m);
            var v = ov.swizzle.gbbb;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, 1m, -1m, 9m);
            var v = ov.swizzle.gbba;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2.5m, 7.5m, 1m, -7.5m);
            var v = ov.swizzle.gba;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-6m, -8.5m, 0.5m, 3.5m);
            var v = ov.swizzle.gbar;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1m, -5m, -2m, 2.5m);
            var v = ov.swizzle.gbag;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(-5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, 3.5m, 5.5m, 4.5m);
            var v = ov.swizzle.gbab;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, -5.5m, -5.5m, -5.5m);
            var v = ov.swizzle.gbaa;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8.5m, -5.5m, 6m, -9m);
            var v = ov.swizzle.ga;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(-9.5m, 3m, -2.5m, -4.5m);
            var v = ov.swizzle.gar;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-4m, 0m, -8m, 9.5m);
            var v = ov.swizzle.garr;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1.5m, -9m, 9.5m, 5.5m);
            var v = ov.swizzle.garg;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4.5m, 3.5m, -2.5m, 4.5m);
            var v = ov.swizzle.garb;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, 6.5m, 5.5m, -8m);
            var v = ov.swizzle.gara;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3m, 5m, 9.5m, 5m);
            var v = ov.swizzle.gag;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-4m, -2.5m, 8.5m, 9m);
            var v = ov.swizzle.gagr;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8m, -2.5m, -2m, 7m);
            var v = ov.swizzle.gagg;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, -6.5m, 1m, -3m);
            var v = ov.swizzle.gagb;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, 5m, -9.5m, -1m);
            var v = ov.swizzle.gaga;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6.5m, -2m, 3m, -1.5m);
            var v = ov.swizzle.gab;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(3.5m, 9.5m, 9m, 1m);
            var v = ov.swizzle.gabr;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, 0.5m, 1m, 2m);
            var v = ov.swizzle.gabg;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, -1.5m, -5m, -4m);
            var v = ov.swizzle.gabb;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(-5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4m, -7.5m, -2m, -2.5m);
            var v = ov.swizzle.gaba;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, 8m, -7.5m, 1m);
            var v = ov.swizzle.gaa;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(7m, 1.5m, 4m, 2m);
            var v = ov.swizzle.gaar;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, -4m, 0m, -7m);
            var v = ov.swizzle.gaag;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, -4.5m, -7.5m, 2.5m);
            var v = ov.swizzle.gaab;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, -1m, -2m, -4m);
            var v = ov.swizzle.gaaa;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, 6.5m, -3m, -2.5m);
            var v = ov.swizzle.br;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(-3.5m, 9m, -9m, 2m);
            var v = ov.swizzle.brr;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(7m, -1.5m, 8m, -2m);
            var v = ov.swizzle.brrr;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, 2.5m, 8m, -1.5m);
            var v = ov.swizzle.brrg;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, 2m, -8.5m, 1m);
            var v = ov.swizzle.brrb;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5.5m, 7m, -1m, -6.5m);
            var v = ov.swizzle.brra;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(-6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, -5.5m, -4.5m, 3m);
            var v = ov.swizzle.brg;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(6m, -6.5m, -1m, 3.5m);
            var v = ov.swizzle.brgr;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9m, 7.5m, 9m, 5m);
            var v = ov.swizzle.brgg;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6.5m, 4.5m, -5m, 7.5m);
            var v = ov.swizzle.brgb;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(-5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2m, 2m, 4.5m, 2m);
            var v = ov.swizzle.brga;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, -1.5m, -6.5m, -5.5m);
            var v = ov.swizzle.brb;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-7m, 4.5m, 2m, 0m);
            var v = ov.swizzle.brbr;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0.5m, -1m, -9m, 9m);
            var v = ov.swizzle.brbg;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3.5m, -0.5m, 7.5m, 1m);
            var v = ov.swizzle.brbb;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, -6m, 5.5m, -4.5m);
            var v = ov.swizzle.brba;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, -5m, 2m, 6.5m);
            var v = ov.swizzle.bra;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-7.5m, 3m, 1.5m, 4.5m);
            var v = ov.swizzle.brar;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2.5m, -6.5m, -0.5m, 2.5m);
            var v = ov.swizzle.brag;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(-6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, 7m, -7m, 1m);
            var v = ov.swizzle.brab;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0m, 0m, -2.5m, -3m);
            var v = ov.swizzle.braa;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9.5m, -1m, 2m, 9.5m);
            var v = ov.swizzle.bg;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(-9m, 0m, -9m, 6m);
            var v = ov.swizzle.bgr;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(6.5m, -3m, -3m, 6.5m);
            var v = ov.swizzle.bgrr;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, 8m, -3.5m, 1.5m);
            var v = ov.swizzle.bgrg;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4.5m, -2.5m, 2m, -4m);
            var v = ov.swizzle.bgrb;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, 7m, -4m, 7m);
            var v = ov.swizzle.bgra;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8.5m, -3.5m, 6.5m, -8m);
            var v = ov.swizzle.bgg;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-2m, 6.5m, 1m, -5.5m);
            var v = ov.swizzle.bggr;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1.5m, -7.5m, 5m, 6m);
            var v = ov.swizzle.bggg;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3m, 3m, -8m, -7.5m);
            var v = ov.swizzle.bggb;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, -5.5m, 7.5m, -4m);
            var v = ov.swizzle.bgga;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9m, 2.5m, -4.5m, 5m);
            var v = ov.swizzle.bgb;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-7.5m, -3.5m, -6m, -4m);
            var v = ov.swizzle.bgbr;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8.5m, -4m, -1m, -2m);
            var v = ov.swizzle.bgbg;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6.5m, 4.5m, -8m, 2.5m);
            var v = ov.swizzle.bgbb;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3m, 1m, 5.5m, 0m);
            var v = ov.swizzle.bgba;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2m, -0.5m, 8m, -5.5m);
            var v = ov.swizzle.bga;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(2m, -9m, -8m, -7.5m);
            var v = ov.swizzle.bgar;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9m, -9.5m, -0.5m, -8m);
            var v = ov.swizzle.bgag;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9m, 0m, 8.5m, -1.5m);
            var v = ov.swizzle.bgab;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0m, 1.5m, 5.5m, -4.5m);
            var v = ov.swizzle.bgaa;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9.5m, -1.5m, -4.5m, -5m);
            var v = ov.swizzle.bb;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(-2m, 3.5m, 9m, -8m);
            var v = ov.swizzle.bbr;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-4.5m, -4.5m, -9m, -7.5m);
            var v = ov.swizzle.bbrr;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, 7.5m, 1m, -9.5m);
            var v = ov.swizzle.bbrg;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, 0m, 2m, 3m);
            var v = ov.swizzle.bbrb;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8m, 4.5m, 4m, -9m);
            var v = ov.swizzle.bbra;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, 3.5m, 1m, 6.5m);
            var v = ov.swizzle.bbg;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(6.5m, 0.5m, 1.5m, -2m);
            var v = ov.swizzle.bbgr;
            Assert.That(1.5m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, -1m, -9.5m, -5.5m);
            var v = ov.swizzle.bbgg;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3m, 3.5m, -3m, 8m);
            var v = ov.swizzle.bbgb;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(8m, 9.5m, 7.5m, -5.5m);
            var v = ov.swizzle.bbga;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1m, 7m, -1.5m, -3m);
            var v = ov.swizzle.bbb;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(8.5m, -8m, 3m, 9.5m);
            var v = ov.swizzle.bbbr;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, 2.5m, -6m, -3.5m);
            var v = ov.swizzle.bbbg;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, 6m, 0.5m, -9m);
            var v = ov.swizzle.bbbb;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, -4m, -7.5m, 5.5m);
            var v = ov.swizzle.bbba;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, 6m, -6m, -8m);
            var v = ov.swizzle.bba;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-7m, -8m, -6m, 1.5m);
            var v = ov.swizzle.bbar;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1.5m, 3.5m, 4.5m, 8m);
            var v = ov.swizzle.bbag;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, -9.5m, -8m, -7m);
            var v = ov.swizzle.bbab;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4m, -0.5m, 7.5m, -8m);
            var v = ov.swizzle.bbaa;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3.5m, 1.5m, -6.5m, -4m);
            var v = ov.swizzle.ba;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(4.5m, 4.5m, 0m, 6.5m);
            var v = ov.swizzle.bar;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(2m, 4.5m, -7m, 5.5m);
            var v = ov.swizzle.barr;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, 1m, 0.5m, 4.5m);
            var v = ov.swizzle.barg;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, -1m, 5.5m, -8.5m);
            var v = ov.swizzle.barb;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2m, -3m, -2m, 5.5m);
            var v = ov.swizzle.bara;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, 6m, -0.5m, 3m);
            var v = ov.swizzle.bag;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-0.5m, -4m, -4m, 2m);
            var v = ov.swizzle.bagr;
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(-0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6m, 4m, 8m, 2m);
            var v = ov.swizzle.bagg;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6.5m, 1m, -6.5m, -7.5m);
            var v = ov.swizzle.bagb;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(-6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, -9m, -1.5m, 4.5m);
            var v = ov.swizzle.baga;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6m, 8.5m, 2.5m, 5.5m);
            var v = ov.swizzle.bab;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(0.5m, -6.5m, -4.5m, 3.5m);
            var v = ov.swizzle.babr;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, -7m, -6m, -4m);
            var v = ov.swizzle.babg;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9.5m, -1.5m, -7m, -1.5m);
            var v = ov.swizzle.babb;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-7m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, 7.5m, 7m, -0.5m);
            var v = ov.swizzle.baba;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(-0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9.5m, -5m, -9.5m, -3m);
            var v = ov.swizzle.baa;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(2.5m, -1.5m, -2m, -0.5m);
            var v = ov.swizzle.baar;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2.5m, -3m, 3m, -6.5m);
            var v = ov.swizzle.baag;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, -8m, -9.5m, 8.5m);
            var v = ov.swizzle.baab;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5m, 4.5m, -3m, 6m);
            var v = ov.swizzle.baaa;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1.5m, -9.5m, 8m, 8.5m);
            var v = ov.swizzle.ar;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(-0.5m, 5.5m, -7.5m, 5.5m);
            var v = ov.swizzle.arr;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-4.5m, 5.5m, -7m, -9.5m);
            var v = ov.swizzle.arrr;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2m, 9.5m, -4m, 1m);
            var v = ov.swizzle.arrg;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9m, -9m, 2m, 2m);
            var v = ov.swizzle.arrb;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2m, 5.5m, 6m, -9.5m);
            var v = ov.swizzle.arra;
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3m, 3.5m, -0.5m, 2m);
            var v = ov.swizzle.arg;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(7m, -8m, -3m, -1m);
            var v = ov.swizzle.argr;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, 0m, 0m, 9.5m);
            var v = ov.swizzle.argg;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, -8.5m, -5.5m, 7.5m);
            var v = ov.swizzle.argb;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, -6m, 3m, 2.5m);
            var v = ov.swizzle.arga;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
            Assert.That(2.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6.5m, -5.5m, -1m, -4.5m);
            var v = ov.swizzle.arb;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(3m, -8m, -9.5m, 5.5m);
            var v = ov.swizzle.arbr;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
            Assert.That(3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, -1m, 5.5m, 3.5m);
            var v = ov.swizzle.arbg;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, -0.5m, -3.5m, 6.5m);
            var v = ov.swizzle.arbb;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, -9m, -2.5m, 7m);
            var v = ov.swizzle.arba;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, 6m, 6.5m, -2m);
            var v = ov.swizzle.ara;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(9.5m, -5m, 5.5m, 7.5m);
            var v = ov.swizzle.arar;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5.5m, 5m, 6.5m, 5.5m);
            var v = ov.swizzle.arag;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, -4m, -5.5m, -0.5m);
            var v = ov.swizzle.arab;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, 3m, 9.5m, -0.5m);
            var v = ov.swizzle.araa;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
            Assert.That(-0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, -7m, -9m, -3m);
            var v = ov.swizzle.ag;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(5m, 6m, -4.5m, -7m);
            var v = ov.swizzle.agr;
            Assert.That(-7m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(5.5m, -1.5m, 0.5m, -3.5m);
            var v = ov.swizzle.agrr;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(5.5m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1.5m, 6.5m, 9m, -0.5m);
            var v = ov.swizzle.agrg;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2.5m, 9.5m, -4.5m, -0.5m);
            var v = ov.swizzle.agrb;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6.5m, -7.5m, 9.5m, -3.5m);
            var v = ov.swizzle.agra;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, 9.5m, 1m, 0m);
            var v = ov.swizzle.agg;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(4m, 6.5m, -4m, 2m);
            var v = ov.swizzle.aggr;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9.5m, 7.5m, 9m, 4m);
            var v = ov.swizzle.aggg;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-2.5m, -6.5m, 5m, 2.5m);
            var v = ov.swizzle.aggb;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, -9m, 2m, 7m);
            var v = ov.swizzle.agga;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5m, 9m, 7m, 5.5m);
            var v = ov.swizzle.agb;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(4m, 4.5m, 1m, -6.5m);
            var v = ov.swizzle.agbr;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9m, -1m, 6m, -6m);
            var v = ov.swizzle.agbg;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, 3.5m, 8.5m, 6m);
            var v = ov.swizzle.agbb;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5m, -4.5m, -2m, 8.5m);
            var v = ov.swizzle.agba;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, -1.5m, 6m, 0.5m);
            var v = ov.swizzle.aga;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-3.5m, 4m, 2m, 4m);
            var v = ov.swizzle.agar;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3.5m, 3.5m, 9.5m, 3m);
            var v = ov.swizzle.agag;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-9m, 2.5m, -1m, 3m);
            var v = ov.swizzle.agab;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(-1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2.5m, 5m, 6.5m, 9m);
            var v = ov.swizzle.agaa;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(9m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(5.5m, 0.5m, -5.5m, 9m);
            var v = ov.swizzle.ab;
            Assert.That(9m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(1.5m, 4.5m, -2.5m, 4.5m);
            var v = ov.swizzle.abr;
            Assert.That(4.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-5.5m, 8.5m, -3.5m, 3m);
            var v = ov.swizzle.abrr;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, 4m, 3.5m, -2.5m);
            var v = ov.swizzle.abrg;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3m, -7m, 9m, 9.5m);
            var v = ov.swizzle.abrb;
            Assert.That(9.5m, Is.EqualTo(v.x));
            Assert.That(9m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(2.5m, 7.5m, -0.5m, -4.5m);
            var v = ov.swizzle.abra;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-1m, 3m, 6.5m, -4.5m);
            var v = ov.swizzle.abg;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-7.5m, 4.5m, -5m, 0m);
            var v = ov.swizzle.abgr;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-0.5m, 1m, 3m, -5.5m);
            var v = ov.swizzle.abgg;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(1m, Is.EqualTo(v.z));
            Assert.That(1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(3m, 6.5m, 9.5m, 2.5m);
            var v = ov.swizzle.abgb;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, 8m, -9.5m, 5.5m);
            var v = ov.swizzle.abga;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, 6.5m, 6.5m, -5m);
            var v = ov.swizzle.abb;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(8.5m, -5.5m, 0m, -6m);
            var v = ov.swizzle.abbr;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6.5m, 6.5m, -8m, 7.5m);
            var v = ov.swizzle.abbg;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
            Assert.That(6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0m, 8.5m, 9.5m, -1.5m);
            var v = ov.swizzle.abbb;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7.5m, 2m, -2m, -0.5m);
            var v = ov.swizzle.abba;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5.5m, -3.5m, -4m, 5m);
            var v = ov.swizzle.aba;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(1m, 9m, -5.5m, 7m);
            var v = ov.swizzle.abar;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(1m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7m, -7m, -7.5m, -6.5m);
            var v = ov.swizzle.abag;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(-7m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-8m, 4.5m, -8m, -5m);
            var v = ov.swizzle.abab;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6m, -8.5m, -2.5m, 8.5m);
            var v = ov.swizzle.abaa;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(4.5m, 9.5m, 3m, 3.5m);
            var v = ov.swizzle.aa;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec4(-5.5m, 5m, -5.5m, 4m);
            var v = ov.swizzle.aar;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(7.5m, -2m, 4.5m, -5m);
            var v = ov.swizzle.aarr;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(6.5m, 0.5m, -1m, -8.5m);
            var v = ov.swizzle.aarg;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(6.5m, Is.EqualTo(v.z));
            Assert.That(0.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, 1.5m, -4m, -0.5m);
            var v = ov.swizzle.aarb;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0m, 2.5m, 8.5m, -9m);
            var v = ov.swizzle.aara;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4m, 4.5m, -9.5m, 5m);
            var v = ov.swizzle.aag;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(5m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-8.5m, -5.5m, -8.5m, -6m);
            var v = ov.swizzle.aagr;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-5m, -4m, 5.5m, -5.5m);
            var v = ov.swizzle.aagg;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(-4m, Is.EqualTo(v.z));
            Assert.That(-4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-7.5m, -8.5m, -8.5m, 5.5m);
            var v = ov.swizzle.aagb;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-3.5m, -9m, 9m, 4m);
            var v = ov.swizzle.aaga;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6.5m, 7m, -3.5m, -1.5m);
            var v = ov.swizzle.aab;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(-5.5m, 7.5m, 2.5m, -5m);
            var v = ov.swizzle.aabr;
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7m, 8.5m, 7.5m, 1m);
            var v = ov.swizzle.aabg;
            Assert.That(1m, Is.EqualTo(v.x));
            Assert.That(1m, Is.EqualTo(v.y));
            Assert.That(7.5m, Is.EqualTo(v.z));
            Assert.That(8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(0m, -4.5m, -9m, -0.5m);
            var v = ov.swizzle.aabb;
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-4.5m, -8m, -5.5m, -3m);
            var v = ov.swizzle.aaba;
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(-3m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(1.5m, -8m, 9.5m, -7.5m);
            var v = ov.swizzle.aaa;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec4(5.5m, -3.5m, 8.5m, 0m);
            var v = ov.swizzle.aaar;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(9m, -8m, 2m, -8.5m);
            var v = ov.swizzle.aaag;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(-6.5m, 4.5m, 5.5m, 6m);
            var v = ov.swizzle.aaab;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec4(7m, 2.5m, -7.5m, -6.5m);
            var v = ov.swizzle.aaaa;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(-6.5m, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new decvec4(3m, 8.5m, 1m, 6m);
            var v1 = new decvec2(-9.5m, 8.5m);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-9.5m, Is.EqualTo(v0.x));
            Assert.That(8.5m, Is.EqualTo(v0.y));
            Assert.That(1m, Is.EqualTo(v0.z));
            Assert.That(6m, Is.EqualTo(v0.w));
        
            Assert.That(3m, Is.EqualTo(v2.x));
            Assert.That(8.5m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec4(4.5m, -2m, 1.5m, -3m);
            var v1 = new decvec2(-5.5m, 8m);
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-5.5m, Is.EqualTo(v0.x));
            Assert.That(-2m, Is.EqualTo(v0.y));
            Assert.That(8m, Is.EqualTo(v0.z));
            Assert.That(-3m, Is.EqualTo(v0.w));
        
            Assert.That(4.5m, Is.EqualTo(v2.x));
            Assert.That(1.5m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec4(5.5m, -1.5m, 1.5m, 0m);
            var v1 = new decvec2(-6.5m, 8m);
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(5.5m, Is.EqualTo(v0.x));
            Assert.That(-6.5m, Is.EqualTo(v0.y));
            Assert.That(8m, Is.EqualTo(v0.z));
            Assert.That(0m, Is.EqualTo(v0.w));
        
            Assert.That(-1.5m, Is.EqualTo(v2.x));
            Assert.That(1.5m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec4(-6m, 5m, -1m, -8.5m);
            var v1 = new decvec3(-5.5m, 6m, 4m);
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-5.5m, Is.EqualTo(v0.x));
            Assert.That(6m, Is.EqualTo(v0.y));
            Assert.That(4m, Is.EqualTo(v0.z));
            Assert.That(-8.5m, Is.EqualTo(v0.w));
        
            Assert.That(-6m, Is.EqualTo(v2.x));
            Assert.That(5m, Is.EqualTo(v2.y));
            Assert.That(-1m, Is.EqualTo(v2.z));
        }
        {
            var v0 = new decvec4(1.5m, 5m, -7m, -0.5m);
            var v1 = new decvec2(7m, -8.5m);
            var v2 = v0.xw;
            v0.xw = v1;
            var v3 = v0.xw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(7m, Is.EqualTo(v0.x));
            Assert.That(5m, Is.EqualTo(v0.y));
            Assert.That(-7m, Is.EqualTo(v0.z));
            Assert.That(-8.5m, Is.EqualTo(v0.w));
        
            Assert.That(1.5m, Is.EqualTo(v2.x));
            Assert.That(-0.5m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec4(9.5m, -4m, -4m, 2m);
            var v1 = new decvec2(-2m, -1.5m);
            var v2 = v0.yw;
            v0.yw = v1;
            var v3 = v0.yw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(9.5m, Is.EqualTo(v0.x));
            Assert.That(-2m, Is.EqualTo(v0.y));
            Assert.That(-4m, Is.EqualTo(v0.z));
            Assert.That(-1.5m, Is.EqualTo(v0.w));
        
            Assert.That(-4m, Is.EqualTo(v2.x));
            Assert.That(2m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec4(-5m, 4m, 3m, 2m);
            var v1 = new decvec3(-6.5m, -8.5m, 9.5m);
            var v2 = v0.xyw;
            v0.xyw = v1;
            var v3 = v0.xyw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-6.5m, Is.EqualTo(v0.x));
            Assert.That(-8.5m, Is.EqualTo(v0.y));
            Assert.That(3m, Is.EqualTo(v0.z));
            Assert.That(9.5m, Is.EqualTo(v0.w));
        
            Assert.That(-5m, Is.EqualTo(v2.x));
            Assert.That(4m, Is.EqualTo(v2.y));
            Assert.That(2m, Is.EqualTo(v2.z));
        }
        {
            var v0 = new decvec4(-6.5m, 1.5m, -3.5m, 1.5m);
            var v1 = new decvec2(8m, -3.5m);
            var v2 = v0.zw;
            v0.zw = v1;
            var v3 = v0.zw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-6.5m, Is.EqualTo(v0.x));
            Assert.That(1.5m, Is.EqualTo(v0.y));
            Assert.That(8m, Is.EqualTo(v0.z));
            Assert.That(-3.5m, Is.EqualTo(v0.w));
        
            Assert.That(-3.5m, Is.EqualTo(v2.x));
            Assert.That(1.5m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec4(0m, -3m, -6.5m, -3.5m);
            var v1 = new decvec3(-4.5m, -6.5m, -4m);
            var v2 = v0.xzw;
            v0.xzw = v1;
            var v3 = v0.xzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-4.5m, Is.EqualTo(v0.x));
            Assert.That(-3m, Is.EqualTo(v0.y));
            Assert.That(-6.5m, Is.EqualTo(v0.z));
            Assert.That(-4m, Is.EqualTo(v0.w));
        
            Assert.That(0m, Is.EqualTo(v2.x));
            Assert.That(-6.5m, Is.EqualTo(v2.y));
            Assert.That(-3.5m, Is.EqualTo(v2.z));
        }
        {
            var v0 = new decvec4(5.5m, 1m, -1.5m, 2.5m);
            var v1 = new decvec3(-7m, -7.5m, -5.5m);
            var v2 = v0.yzw;
            v0.yzw = v1;
            var v3 = v0.yzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(5.5m, Is.EqualTo(v0.x));
            Assert.That(-7m, Is.EqualTo(v0.y));
            Assert.That(-7.5m, Is.EqualTo(v0.z));
            Assert.That(-5.5m, Is.EqualTo(v0.w));
        
            Assert.That(1m, Is.EqualTo(v2.x));
            Assert.That(-1.5m, Is.EqualTo(v2.y));
            Assert.That(2.5m, Is.EqualTo(v2.z));
        }
        {
            var v0 = new decvec4(2.5m, -5.5m, 5.5m, -8.5m);
            var v1 = new decvec4(-3.5m, -9.5m, -2m, 7m);
            var v2 = v0.xyzw;
            v0.xyzw = v1;
            var v3 = v0.xyzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-3.5m, Is.EqualTo(v0.x));
            Assert.That(-9.5m, Is.EqualTo(v0.y));
            Assert.That(-2m, Is.EqualTo(v0.z));
            Assert.That(7m, Is.EqualTo(v0.w));
        
            Assert.That(2.5m, Is.EqualTo(v2.x));
            Assert.That(-5.5m, Is.EqualTo(v2.y));
            Assert.That(5.5m, Is.EqualTo(v2.z));
            Assert.That(-8.5m, Is.EqualTo(v2.w));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new decvec4(-8m, -8.5m, 5.5m, -2m);
            var v1 = -7.5m;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-7.5m, Is.EqualTo(v0.x));
            Assert.That(-8.5m, Is.EqualTo(v0.y));
            Assert.That(5.5m, Is.EqualTo(v0.z));
            Assert.That(-2m, Is.EqualTo(v0.w));
        
            Assert.That(-8m, Is.EqualTo(v2));
        }
        {
            var v0 = new decvec4(-5.5m, 0m, 8m, -0.5m);
            var v1 = 6m;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-5.5m, Is.EqualTo(v0.x));
            Assert.That(6m, Is.EqualTo(v0.y));
            Assert.That(8m, Is.EqualTo(v0.z));
            Assert.That(-0.5m, Is.EqualTo(v0.w));
        
            Assert.That(0m, Is.EqualTo(v2));
        }
        {
            var v0 = new decvec4(5.5m, -0.5m, 6m, 9.5m);
            var v1 = new decvec2(0m, -2.5m);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(0m, Is.EqualTo(v0.x));
            Assert.That(-2.5m, Is.EqualTo(v0.y));
            Assert.That(6m, Is.EqualTo(v0.z));
            Assert.That(9.5m, Is.EqualTo(v0.w));
        
            Assert.That(5.5m, Is.EqualTo(v2.x));
            Assert.That(-0.5m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec4(4.5m, -7m, -3.5m, 0m);
            var v1 = 9.5m;
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4.5m, Is.EqualTo(v0.x));
            Assert.That(-7m, Is.EqualTo(v0.y));
            Assert.That(9.5m, Is.EqualTo(v0.z));
            Assert.That(0m, Is.EqualTo(v0.w));
        
            Assert.That(-3.5m, Is.EqualTo(v2));
        }
        {
            var v0 = new decvec4(7.5m, -2.5m, -9.5m, -7m);
            var v1 = new decvec2(-2.5m, -2m);
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-2.5m, Is.EqualTo(v0.x));
            Assert.That(-2.5m, Is.EqualTo(v0.y));
            Assert.That(-2m, Is.EqualTo(v0.z));
            Assert.That(-7m, Is.EqualTo(v0.w));
        
            Assert.That(7.5m, Is.EqualTo(v2.x));
            Assert.That(-9.5m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec4(-8m, -6m, 8m, -6.5m);
            var v1 = new decvec2(-7m, -8m);
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-8m, Is.EqualTo(v0.x));
            Assert.That(-7m, Is.EqualTo(v0.y));
            Assert.That(-8m, Is.EqualTo(v0.z));
            Assert.That(-6.5m, Is.EqualTo(v0.w));
        
            Assert.That(-6m, Is.EqualTo(v2.x));
            Assert.That(8m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec4(9m, -2.5m, -7m, -8m);
            var v1 = new decvec3(9m, 6.5m, -2m);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(9m, Is.EqualTo(v0.x));
            Assert.That(6.5m, Is.EqualTo(v0.y));
            Assert.That(-2m, Is.EqualTo(v0.z));
            Assert.That(-8m, Is.EqualTo(v0.w));
        
            Assert.That(9m, Is.EqualTo(v2.x));
            Assert.That(-2.5m, Is.EqualTo(v2.y));
            Assert.That(-7m, Is.EqualTo(v2.z));
        }
        {
            var v0 = new decvec4(-5m, -4m, 2.5m, -4.5m);
            var v1 = 4m;
            var v2 = v0.a;
            v0.a = v1;
            var v3 = v0.a;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-5m, Is.EqualTo(v0.x));
            Assert.That(-4m, Is.EqualTo(v0.y));
            Assert.That(2.5m, Is.EqualTo(v0.z));
            Assert.That(4m, Is.EqualTo(v0.w));
        
            Assert.That(-4.5m, Is.EqualTo(v2));
        }
        {
            var v0 = new decvec4(-3.5m, 1m, 8m, 5m);
            var v1 = new decvec2(-7.5m, 9.5m);
            var v2 = v0.ra;
            v0.ra = v1;
            var v3 = v0.ra;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-7.5m, Is.EqualTo(v0.x));
            Assert.That(1m, Is.EqualTo(v0.y));
            Assert.That(8m, Is.EqualTo(v0.z));
            Assert.That(9.5m, Is.EqualTo(v0.w));
        
            Assert.That(-3.5m, Is.EqualTo(v2.x));
            Assert.That(5m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec4(8m, 6m, 1m, 5.5m);
            var v1 = new decvec2(-8.5m, 4.5m);
            var v2 = v0.ga;
            v0.ga = v1;
            var v3 = v0.ga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(8m, Is.EqualTo(v0.x));
            Assert.That(-8.5m, Is.EqualTo(v0.y));
            Assert.That(1m, Is.EqualTo(v0.z));
            Assert.That(4.5m, Is.EqualTo(v0.w));
        
            Assert.That(6m, Is.EqualTo(v2.x));
            Assert.That(5.5m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec4(-5m, 5.5m, 4.5m, -2m);
            var v1 = new decvec3(-7.5m, 2.5m, -8.5m);
            var v2 = v0.rga;
            v0.rga = v1;
            var v3 = v0.rga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-7.5m, Is.EqualTo(v0.x));
            Assert.That(2.5m, Is.EqualTo(v0.y));
            Assert.That(4.5m, Is.EqualTo(v0.z));
            Assert.That(-8.5m, Is.EqualTo(v0.w));
        
            Assert.That(-5m, Is.EqualTo(v2.x));
            Assert.That(5.5m, Is.EqualTo(v2.y));
            Assert.That(-2m, Is.EqualTo(v2.z));
        }
        {
            var v0 = new decvec4(-5.5m, -9m, -1m, 7.5m);
            var v1 = new decvec2(-2m, -5.5m);
            var v2 = v0.ba;
            v0.ba = v1;
            var v3 = v0.ba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-5.5m, Is.EqualTo(v0.x));
            Assert.That(-9m, Is.EqualTo(v0.y));
            Assert.That(-2m, Is.EqualTo(v0.z));
            Assert.That(-5.5m, Is.EqualTo(v0.w));
        
            Assert.That(-1m, Is.EqualTo(v2.x));
            Assert.That(7.5m, Is.EqualTo(v2.y));
        }
        {
            var v0 = new decvec4(8m, -5.5m, -9.5m, -4m);
            var v1 = new decvec3(-3.5m, -3.5m, 4m);
            var v2 = v0.rba;
            v0.rba = v1;
            var v3 = v0.rba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-3.5m, Is.EqualTo(v0.x));
            Assert.That(-5.5m, Is.EqualTo(v0.y));
            Assert.That(-3.5m, Is.EqualTo(v0.z));
            Assert.That(4m, Is.EqualTo(v0.w));
        
            Assert.That(8m, Is.EqualTo(v2.x));
            Assert.That(-9.5m, Is.EqualTo(v2.y));
            Assert.That(-4m, Is.EqualTo(v2.z));
        }
        {
            var v0 = new decvec4(2m, -6m, 0.5m, -4.5m);
            var v1 = new decvec3(2m, -3m, 4.5m);
            var v2 = v0.gba;
            v0.gba = v1;
            var v3 = v0.gba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(2m, Is.EqualTo(v0.x));
            Assert.That(2m, Is.EqualTo(v0.y));
            Assert.That(-3m, Is.EqualTo(v0.z));
            Assert.That(4.5m, Is.EqualTo(v0.w));
        
            Assert.That(-6m, Is.EqualTo(v2.x));
            Assert.That(0.5m, Is.EqualTo(v2.y));
            Assert.That(-4.5m, Is.EqualTo(v2.z));
        }
        {
            var v0 = new decvec4(9m, -5m, 9m, -6m);
            var v1 = new decvec4(-4m, 5m, -6.5m, 3m);
            var v2 = v0.rgba;
            v0.rgba = v1;
            var v3 = v0.rgba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-4m, Is.EqualTo(v0.x));
            Assert.That(5m, Is.EqualTo(v0.y));
            Assert.That(-6.5m, Is.EqualTo(v0.z));
            Assert.That(3m, Is.EqualTo(v0.w));
        
            Assert.That(9m, Is.EqualTo(v2.x));
            Assert.That(-5m, Is.EqualTo(v2.y));
            Assert.That(9m, Is.EqualTo(v2.z));
            Assert.That(-6m, Is.EqualTo(v2.w));
        }
    }

}
