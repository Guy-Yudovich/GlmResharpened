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
public class FloatSwizzleVec3Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new vec3(-3.5f, 1.5f, 8.5f);
            var v = ov.swizzle.xx;
            Assert.That(-3.5f, Is.EqualTo(v.x));
            Assert.That(-3.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(-9.5f, 9.5f, -5.5f);
            var v = ov.swizzle.xxx;
            Assert.That(-9.5f, Is.EqualTo(v.x));
            Assert.That(-9.5f, Is.EqualTo(v.y));
            Assert.That(-9.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-4f, 3f, 9.5f);
            var v = ov.swizzle.xxxx;
            Assert.That(-4f, Is.EqualTo(v.x));
            Assert.That(-4f, Is.EqualTo(v.y));
            Assert.That(-4f, Is.EqualTo(v.z));
            Assert.That(-4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(0f, -3f, -3f);
            var v = ov.swizzle.xxxy;
            Assert.That(0f, Is.EqualTo(v.x));
            Assert.That(0f, Is.EqualTo(v.y));
            Assert.That(0f, Is.EqualTo(v.z));
            Assert.That(-3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-1f, -5f, -3f);
            var v = ov.swizzle.xxxz;
            Assert.That(-1f, Is.EqualTo(v.x));
            Assert.That(-1f, Is.EqualTo(v.y));
            Assert.That(-1f, Is.EqualTo(v.z));
            Assert.That(-3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-6.5f, 5f, -4f);
            var v = ov.swizzle.xxy;
            Assert.That(-6.5f, Is.EqualTo(v.x));
            Assert.That(-6.5f, Is.EqualTo(v.y));
            Assert.That(5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(2f, 0.5f, -2f);
            var v = ov.swizzle.xxyx;
            Assert.That(2f, Is.EqualTo(v.x));
            Assert.That(2f, Is.EqualTo(v.y));
            Assert.That(0.5f, Is.EqualTo(v.z));
            Assert.That(2f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-3f, -8.5f, 6f);
            var v = ov.swizzle.xxyy;
            Assert.That(-3f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(-8.5f, Is.EqualTo(v.z));
            Assert.That(-8.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(0f, -2.5f, -6f);
            var v = ov.swizzle.xxyz;
            Assert.That(0f, Is.EqualTo(v.x));
            Assert.That(0f, Is.EqualTo(v.y));
            Assert.That(-2.5f, Is.EqualTo(v.z));
            Assert.That(-6f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-4f, 9.5f, -9f);
            var v = ov.swizzle.xxz;
            Assert.That(-4f, Is.EqualTo(v.x));
            Assert.That(-4f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-1f, 8f, 2f);
            var v = ov.swizzle.xxzx;
            Assert.That(-1f, Is.EqualTo(v.x));
            Assert.That(-1f, Is.EqualTo(v.y));
            Assert.That(2f, Is.EqualTo(v.z));
            Assert.That(-1f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-7.5f, -0.5f, -8.5f);
            var v = ov.swizzle.xxzy;
            Assert.That(-7.5f, Is.EqualTo(v.x));
            Assert.That(-7.5f, Is.EqualTo(v.y));
            Assert.That(-8.5f, Is.EqualTo(v.z));
            Assert.That(-0.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(5.5f, 9f, -4f);
            var v = ov.swizzle.xxzz;
            Assert.That(5.5f, Is.EqualTo(v.x));
            Assert.That(5.5f, Is.EqualTo(v.y));
            Assert.That(-4f, Is.EqualTo(v.z));
            Assert.That(-4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(3f, -3f, -6.5f);
            var v = ov.swizzle.xy;
            Assert.That(3f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(-8f, 4.5f, -9f);
            var v = ov.swizzle.xyx;
            Assert.That(-8f, Is.EqualTo(v.x));
            Assert.That(4.5f, Is.EqualTo(v.y));
            Assert.That(-8f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(3f, 3f, -8f);
            var v = ov.swizzle.xyxx;
            Assert.That(3f, Is.EqualTo(v.x));
            Assert.That(3f, Is.EqualTo(v.y));
            Assert.That(3f, Is.EqualTo(v.z));
            Assert.That(3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-4.5f, -5f, 5f);
            var v = ov.swizzle.xyxy;
            Assert.That(-4.5f, Is.EqualTo(v.x));
            Assert.That(-5f, Is.EqualTo(v.y));
            Assert.That(-4.5f, Is.EqualTo(v.z));
            Assert.That(-5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(6.5f, -5f, 8f);
            var v = ov.swizzle.xyxz;
            Assert.That(6.5f, Is.EqualTo(v.x));
            Assert.That(-5f, Is.EqualTo(v.y));
            Assert.That(6.5f, Is.EqualTo(v.z));
            Assert.That(8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(1f, -3f, 9f);
            var v = ov.swizzle.xyy;
            Assert.That(1f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(-3f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(1.5f, -9f, -2f);
            var v = ov.swizzle.xyyx;
            Assert.That(1.5f, Is.EqualTo(v.x));
            Assert.That(-9f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
            Assert.That(1.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(8f, 9.5f, 4f);
            var v = ov.swizzle.xyyy;
            Assert.That(8f, Is.EqualTo(v.x));
            Assert.That(9.5f, Is.EqualTo(v.y));
            Assert.That(9.5f, Is.EqualTo(v.z));
            Assert.That(9.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-8.5f, 0.5f, 3f);
            var v = ov.swizzle.xyyz;
            Assert.That(-8.5f, Is.EqualTo(v.x));
            Assert.That(0.5f, Is.EqualTo(v.y));
            Assert.That(0.5f, Is.EqualTo(v.z));
            Assert.That(3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(9f, -1.5f, -3.5f);
            var v = ov.swizzle.xyz;
            Assert.That(9f, Is.EqualTo(v.x));
            Assert.That(-1.5f, Is.EqualTo(v.y));
            Assert.That(-3.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(2.5f, -1.5f, 5.5f);
            var v = ov.swizzle.xyzx;
            Assert.That(2.5f, Is.EqualTo(v.x));
            Assert.That(-1.5f, Is.EqualTo(v.y));
            Assert.That(5.5f, Is.EqualTo(v.z));
            Assert.That(2.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(9.5f, 8.5f, -7f);
            var v = ov.swizzle.xyzy;
            Assert.That(9.5f, Is.EqualTo(v.x));
            Assert.That(8.5f, Is.EqualTo(v.y));
            Assert.That(-7f, Is.EqualTo(v.z));
            Assert.That(8.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-1.5f, 5.5f, -2.5f);
            var v = ov.swizzle.xyzz;
            Assert.That(-1.5f, Is.EqualTo(v.x));
            Assert.That(5.5f, Is.EqualTo(v.y));
            Assert.That(-2.5f, Is.EqualTo(v.z));
            Assert.That(-2.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-2.5f, 7.5f, -5.5f);
            var v = ov.swizzle.xz;
            Assert.That(-2.5f, Is.EqualTo(v.x));
            Assert.That(-5.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(8.5f, -0.5f, -5.5f);
            var v = ov.swizzle.xzx;
            Assert.That(8.5f, Is.EqualTo(v.x));
            Assert.That(-5.5f, Is.EqualTo(v.y));
            Assert.That(8.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-4f, -5f, 4.5f);
            var v = ov.swizzle.xzxx;
            Assert.That(-4f, Is.EqualTo(v.x));
            Assert.That(4.5f, Is.EqualTo(v.y));
            Assert.That(-4f, Is.EqualTo(v.z));
            Assert.That(-4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(4.5f, -9.5f, -7f);
            var v = ov.swizzle.xzxy;
            Assert.That(4.5f, Is.EqualTo(v.x));
            Assert.That(-7f, Is.EqualTo(v.y));
            Assert.That(4.5f, Is.EqualTo(v.z));
            Assert.That(-9.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-1f, 3f, 1.5f);
            var v = ov.swizzle.xzxz;
            Assert.That(-1f, Is.EqualTo(v.x));
            Assert.That(1.5f, Is.EqualTo(v.y));
            Assert.That(-1f, Is.EqualTo(v.z));
            Assert.That(1.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(1f, 5.5f, -3f);
            var v = ov.swizzle.xzy;
            Assert.That(1f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(5.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-9f, 7.5f, 4f);
            var v = ov.swizzle.xzyx;
            Assert.That(-9f, Is.EqualTo(v.x));
            Assert.That(4f, Is.EqualTo(v.y));
            Assert.That(7.5f, Is.EqualTo(v.z));
            Assert.That(-9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-6f, 3.5f, -5f);
            var v = ov.swizzle.xzyy;
            Assert.That(-6f, Is.EqualTo(v.x));
            Assert.That(-5f, Is.EqualTo(v.y));
            Assert.That(3.5f, Is.EqualTo(v.z));
            Assert.That(3.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(1.5f, 2.5f, -3.5f);
            var v = ov.swizzle.xzyz;
            Assert.That(1.5f, Is.EqualTo(v.x));
            Assert.That(-3.5f, Is.EqualTo(v.y));
            Assert.That(2.5f, Is.EqualTo(v.z));
            Assert.That(-3.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(9f, 6.5f, -6f);
            var v = ov.swizzle.xzz;
            Assert.That(9f, Is.EqualTo(v.x));
            Assert.That(-6f, Is.EqualTo(v.y));
            Assert.That(-6f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(1.5f, -3f, -7f);
            var v = ov.swizzle.xzzx;
            Assert.That(1.5f, Is.EqualTo(v.x));
            Assert.That(-7f, Is.EqualTo(v.y));
            Assert.That(-7f, Is.EqualTo(v.z));
            Assert.That(1.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-6.5f, 4f, -8.5f);
            var v = ov.swizzle.xzzy;
            Assert.That(-6.5f, Is.EqualTo(v.x));
            Assert.That(-8.5f, Is.EqualTo(v.y));
            Assert.That(-8.5f, Is.EqualTo(v.z));
            Assert.That(4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-1.5f, 9f, -1f);
            var v = ov.swizzle.xzzz;
            Assert.That(-1.5f, Is.EqualTo(v.x));
            Assert.That(-1f, Is.EqualTo(v.y));
            Assert.That(-1f, Is.EqualTo(v.z));
            Assert.That(-1f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-9.5f, 6f, -5f);
            var v = ov.swizzle.yx;
            Assert.That(6f, Is.EqualTo(v.x));
            Assert.That(-9.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(9f, -5f, 8f);
            var v = ov.swizzle.yxx;
            Assert.That(-5f, Is.EqualTo(v.x));
            Assert.That(9f, Is.EqualTo(v.y));
            Assert.That(9f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(8f, -8.5f, -5.5f);
            var v = ov.swizzle.yxxx;
            Assert.That(-8.5f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
            Assert.That(8f, Is.EqualTo(v.z));
            Assert.That(8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(3f, 8.5f, 2f);
            var v = ov.swizzle.yxxy;
            Assert.That(8.5f, Is.EqualTo(v.x));
            Assert.That(3f, Is.EqualTo(v.y));
            Assert.That(3f, Is.EqualTo(v.z));
            Assert.That(8.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(4f, 9f, 7.5f);
            var v = ov.swizzle.yxxz;
            Assert.That(9f, Is.EqualTo(v.x));
            Assert.That(4f, Is.EqualTo(v.y));
            Assert.That(4f, Is.EqualTo(v.z));
            Assert.That(7.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-7.5f, -2f, 3f);
            var v = ov.swizzle.yxy;
            Assert.That(-2f, Is.EqualTo(v.x));
            Assert.That(-7.5f, Is.EqualTo(v.y));
            Assert.That(-2f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(8f, 6f, 6.5f);
            var v = ov.swizzle.yxyx;
            Assert.That(6f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
            Assert.That(6f, Is.EqualTo(v.z));
            Assert.That(8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(8.5f, 3f, -8f);
            var v = ov.swizzle.yxyy;
            Assert.That(3f, Is.EqualTo(v.x));
            Assert.That(8.5f, Is.EqualTo(v.y));
            Assert.That(3f, Is.EqualTo(v.z));
            Assert.That(3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-8f, 3f, 7f);
            var v = ov.swizzle.yxyz;
            Assert.That(3f, Is.EqualTo(v.x));
            Assert.That(-8f, Is.EqualTo(v.y));
            Assert.That(3f, Is.EqualTo(v.z));
            Assert.That(7f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(9.5f, -1.5f, 9.5f);
            var v = ov.swizzle.yxz;
            Assert.That(-1.5f, Is.EqualTo(v.x));
            Assert.That(9.5f, Is.EqualTo(v.y));
            Assert.That(9.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(9f, -3f, -4.5f);
            var v = ov.swizzle.yxzx;
            Assert.That(-3f, Is.EqualTo(v.x));
            Assert.That(9f, Is.EqualTo(v.y));
            Assert.That(-4.5f, Is.EqualTo(v.z));
            Assert.That(9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(2f, 8.5f, 0.5f);
            var v = ov.swizzle.yxzy;
            Assert.That(8.5f, Is.EqualTo(v.x));
            Assert.That(2f, Is.EqualTo(v.y));
            Assert.That(0.5f, Is.EqualTo(v.z));
            Assert.That(8.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-0.5f, 6f, -8f);
            var v = ov.swizzle.yxzz;
            Assert.That(6f, Is.EqualTo(v.x));
            Assert.That(-0.5f, Is.EqualTo(v.y));
            Assert.That(-8f, Is.EqualTo(v.z));
            Assert.That(-8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(6f, -6.5f, -2f);
            var v = ov.swizzle.yy;
            Assert.That(-6.5f, Is.EqualTo(v.x));
            Assert.That(-6.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(2f, 6f, 8.5f);
            var v = ov.swizzle.yyx;
            Assert.That(6f, Is.EqualTo(v.x));
            Assert.That(6f, Is.EqualTo(v.y));
            Assert.That(2f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-3f, -2.5f, 2f);
            var v = ov.swizzle.yyxx;
            Assert.That(-2.5f, Is.EqualTo(v.x));
            Assert.That(-2.5f, Is.EqualTo(v.y));
            Assert.That(-3f, Is.EqualTo(v.z));
            Assert.That(-3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-9f, 0f, 2.5f);
            var v = ov.swizzle.yyxy;
            Assert.That(0f, Is.EqualTo(v.x));
            Assert.That(0f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
            Assert.That(0f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-8f, -9f, 3f);
            var v = ov.swizzle.yyxz;
            Assert.That(-9f, Is.EqualTo(v.x));
            Assert.That(-9f, Is.EqualTo(v.y));
            Assert.That(-8f, Is.EqualTo(v.z));
            Assert.That(3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-5f, -7.5f, 3f);
            var v = ov.swizzle.yyy;
            Assert.That(-7.5f, Is.EqualTo(v.x));
            Assert.That(-7.5f, Is.EqualTo(v.y));
            Assert.That(-7.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(7.5f, 1.5f, -2f);
            var v = ov.swizzle.yyyx;
            Assert.That(1.5f, Is.EqualTo(v.x));
            Assert.That(1.5f, Is.EqualTo(v.y));
            Assert.That(1.5f, Is.EqualTo(v.z));
            Assert.That(7.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(0f, 9f, 3.5f);
            var v = ov.swizzle.yyyy;
            Assert.That(9f, Is.EqualTo(v.x));
            Assert.That(9f, Is.EqualTo(v.y));
            Assert.That(9f, Is.EqualTo(v.z));
            Assert.That(9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-5.5f, 3.5f, -4.5f);
            var v = ov.swizzle.yyyz;
            Assert.That(3.5f, Is.EqualTo(v.x));
            Assert.That(3.5f, Is.EqualTo(v.y));
            Assert.That(3.5f, Is.EqualTo(v.z));
            Assert.That(-4.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-8f, 2f, -1f);
            var v = ov.swizzle.yyz;
            Assert.That(2f, Is.EqualTo(v.x));
            Assert.That(2f, Is.EqualTo(v.y));
            Assert.That(-1f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(7f, 2.5f, 5f);
            var v = ov.swizzle.yyzx;
            Assert.That(2.5f, Is.EqualTo(v.x));
            Assert.That(2.5f, Is.EqualTo(v.y));
            Assert.That(5f, Is.EqualTo(v.z));
            Assert.That(7f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-4.5f, 2f, -5.5f);
            var v = ov.swizzle.yyzy;
            Assert.That(2f, Is.EqualTo(v.x));
            Assert.That(2f, Is.EqualTo(v.y));
            Assert.That(-5.5f, Is.EqualTo(v.z));
            Assert.That(2f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-4.5f, 5.5f, 7.5f);
            var v = ov.swizzle.yyzz;
            Assert.That(5.5f, Is.EqualTo(v.x));
            Assert.That(5.5f, Is.EqualTo(v.y));
            Assert.That(7.5f, Is.EqualTo(v.z));
            Assert.That(7.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-9.5f, 5f, -6f);
            var v = ov.swizzle.yz;
            Assert.That(5f, Is.EqualTo(v.x));
            Assert.That(-6f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(4f, -9.5f, -2.5f);
            var v = ov.swizzle.yzx;
            Assert.That(-9.5f, Is.EqualTo(v.x));
            Assert.That(-2.5f, Is.EqualTo(v.y));
            Assert.That(4f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(6f, 2.5f, 3.5f);
            var v = ov.swizzle.yzxx;
            Assert.That(2.5f, Is.EqualTo(v.x));
            Assert.That(3.5f, Is.EqualTo(v.y));
            Assert.That(6f, Is.EqualTo(v.z));
            Assert.That(6f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-8.5f, -2.5f, -7f);
            var v = ov.swizzle.yzxy;
            Assert.That(-2.5f, Is.EqualTo(v.x));
            Assert.That(-7f, Is.EqualTo(v.y));
            Assert.That(-8.5f, Is.EqualTo(v.z));
            Assert.That(-2.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-2.5f, 2.5f, -5f);
            var v = ov.swizzle.yzxz;
            Assert.That(2.5f, Is.EqualTo(v.x));
            Assert.That(-5f, Is.EqualTo(v.y));
            Assert.That(-2.5f, Is.EqualTo(v.z));
            Assert.That(-5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(6f, 5f, -3f);
            var v = ov.swizzle.yzy;
            Assert.That(5f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-8f, -8f, -3f);
            var v = ov.swizzle.yzyx;
            Assert.That(-8f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(-8f, Is.EqualTo(v.z));
            Assert.That(-8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-3f, 5.5f, -4.5f);
            var v = ov.swizzle.yzyy;
            Assert.That(5.5f, Is.EqualTo(v.x));
            Assert.That(-4.5f, Is.EqualTo(v.y));
            Assert.That(5.5f, Is.EqualTo(v.z));
            Assert.That(5.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(2.5f, -2f, 8f);
            var v = ov.swizzle.yzyz;
            Assert.That(-2f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
            Assert.That(-2f, Is.EqualTo(v.z));
            Assert.That(8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-2.5f, 2.5f, -7f);
            var v = ov.swizzle.yzz;
            Assert.That(2.5f, Is.EqualTo(v.x));
            Assert.That(-7f, Is.EqualTo(v.y));
            Assert.That(-7f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-9.5f, 0.5f, -3.5f);
            var v = ov.swizzle.yzzx;
            Assert.That(0.5f, Is.EqualTo(v.x));
            Assert.That(-3.5f, Is.EqualTo(v.y));
            Assert.That(-3.5f, Is.EqualTo(v.z));
            Assert.That(-9.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(6f, -8f, -3.5f);
            var v = ov.swizzle.yzzy;
            Assert.That(-8f, Is.EqualTo(v.x));
            Assert.That(-3.5f, Is.EqualTo(v.y));
            Assert.That(-3.5f, Is.EqualTo(v.z));
            Assert.That(-8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(6.5f, 6.5f, -0.5f);
            var v = ov.swizzle.yzzz;
            Assert.That(6.5f, Is.EqualTo(v.x));
            Assert.That(-0.5f, Is.EqualTo(v.y));
            Assert.That(-0.5f, Is.EqualTo(v.z));
            Assert.That(-0.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(5f, -8f, 1f);
            var v = ov.swizzle.zx;
            Assert.That(1f, Is.EqualTo(v.x));
            Assert.That(5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(1.5f, 6.5f, -5f);
            var v = ov.swizzle.zxx;
            Assert.That(-5f, Is.EqualTo(v.x));
            Assert.That(1.5f, Is.EqualTo(v.y));
            Assert.That(1.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(3.5f, -8.5f, 0f);
            var v = ov.swizzle.zxxx;
            Assert.That(0f, Is.EqualTo(v.x));
            Assert.That(3.5f, Is.EqualTo(v.y));
            Assert.That(3.5f, Is.EqualTo(v.z));
            Assert.That(3.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(0.5f, -9f, 6.5f);
            var v = ov.swizzle.zxxy;
            Assert.That(6.5f, Is.EqualTo(v.x));
            Assert.That(0.5f, Is.EqualTo(v.y));
            Assert.That(0.5f, Is.EqualTo(v.z));
            Assert.That(-9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-1f, 6f, -8f);
            var v = ov.swizzle.zxxz;
            Assert.That(-8f, Is.EqualTo(v.x));
            Assert.That(-1f, Is.EqualTo(v.y));
            Assert.That(-1f, Is.EqualTo(v.z));
            Assert.That(-8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-5.5f, 6f, -1f);
            var v = ov.swizzle.zxy;
            Assert.That(-1f, Is.EqualTo(v.x));
            Assert.That(-5.5f, Is.EqualTo(v.y));
            Assert.That(6f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(1.5f, -3f, 7f);
            var v = ov.swizzle.zxyx;
            Assert.That(7f, Is.EqualTo(v.x));
            Assert.That(1.5f, Is.EqualTo(v.y));
            Assert.That(-3f, Is.EqualTo(v.z));
            Assert.That(1.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-9f, -9.5f, 9.5f);
            var v = ov.swizzle.zxyy;
            Assert.That(9.5f, Is.EqualTo(v.x));
            Assert.That(-9f, Is.EqualTo(v.y));
            Assert.That(-9.5f, Is.EqualTo(v.z));
            Assert.That(-9.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-7f, 1f, 7.5f);
            var v = ov.swizzle.zxyz;
            Assert.That(7.5f, Is.EqualTo(v.x));
            Assert.That(-7f, Is.EqualTo(v.y));
            Assert.That(1f, Is.EqualTo(v.z));
            Assert.That(7.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(1.5f, -9.5f, -5f);
            var v = ov.swizzle.zxz;
            Assert.That(-5f, Is.EqualTo(v.x));
            Assert.That(1.5f, Is.EqualTo(v.y));
            Assert.That(-5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-0.5f, -1f, 9f);
            var v = ov.swizzle.zxzx;
            Assert.That(9f, Is.EqualTo(v.x));
            Assert.That(-0.5f, Is.EqualTo(v.y));
            Assert.That(9f, Is.EqualTo(v.z));
            Assert.That(-0.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-6.5f, -3f, 0f);
            var v = ov.swizzle.zxzy;
            Assert.That(0f, Is.EqualTo(v.x));
            Assert.That(-6.5f, Is.EqualTo(v.y));
            Assert.That(0f, Is.EqualTo(v.z));
            Assert.That(-3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-2f, -8.5f, 8.5f);
            var v = ov.swizzle.zxzz;
            Assert.That(8.5f, Is.EqualTo(v.x));
            Assert.That(-2f, Is.EqualTo(v.y));
            Assert.That(8.5f, Is.EqualTo(v.z));
            Assert.That(8.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(9f, 8.5f, 1.5f);
            var v = ov.swizzle.zy;
            Assert.That(1.5f, Is.EqualTo(v.x));
            Assert.That(8.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(8f, 6.5f, -4f);
            var v = ov.swizzle.zyx;
            Assert.That(-4f, Is.EqualTo(v.x));
            Assert.That(6.5f, Is.EqualTo(v.y));
            Assert.That(8f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-9.5f, 9f, -6.5f);
            var v = ov.swizzle.zyxx;
            Assert.That(-6.5f, Is.EqualTo(v.x));
            Assert.That(9f, Is.EqualTo(v.y));
            Assert.That(-9.5f, Is.EqualTo(v.z));
            Assert.That(-9.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(8f, -7.5f, -1f);
            var v = ov.swizzle.zyxy;
            Assert.That(-1f, Is.EqualTo(v.x));
            Assert.That(-7.5f, Is.EqualTo(v.y));
            Assert.That(8f, Is.EqualTo(v.z));
            Assert.That(-7.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-6f, 4f, -5.5f);
            var v = ov.swizzle.zyxz;
            Assert.That(-5.5f, Is.EqualTo(v.x));
            Assert.That(4f, Is.EqualTo(v.y));
            Assert.That(-6f, Is.EqualTo(v.z));
            Assert.That(-5.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-7.5f, -2.5f, 7.5f);
            var v = ov.swizzle.zyy;
            Assert.That(7.5f, Is.EqualTo(v.x));
            Assert.That(-2.5f, Is.EqualTo(v.y));
            Assert.That(-2.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(1f, -5f, 5.5f);
            var v = ov.swizzle.zyyx;
            Assert.That(5.5f, Is.EqualTo(v.x));
            Assert.That(-5f, Is.EqualTo(v.y));
            Assert.That(-5f, Is.EqualTo(v.z));
            Assert.That(1f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-7f, 2f, 0f);
            var v = ov.swizzle.zyyy;
            Assert.That(0f, Is.EqualTo(v.x));
            Assert.That(2f, Is.EqualTo(v.y));
            Assert.That(2f, Is.EqualTo(v.z));
            Assert.That(2f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-4.5f, 1f, 8f);
            var v = ov.swizzle.zyyz;
            Assert.That(8f, Is.EqualTo(v.x));
            Assert.That(1f, Is.EqualTo(v.y));
            Assert.That(1f, Is.EqualTo(v.z));
            Assert.That(8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-2.5f, -2.5f, 3.5f);
            var v = ov.swizzle.zyz;
            Assert.That(3.5f, Is.EqualTo(v.x));
            Assert.That(-2.5f, Is.EqualTo(v.y));
            Assert.That(3.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-7f, -3f, -4.5f);
            var v = ov.swizzle.zyzx;
            Assert.That(-4.5f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(-4.5f, Is.EqualTo(v.z));
            Assert.That(-7f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-2f, -8.5f, -5f);
            var v = ov.swizzle.zyzy;
            Assert.That(-5f, Is.EqualTo(v.x));
            Assert.That(-8.5f, Is.EqualTo(v.y));
            Assert.That(-5f, Is.EqualTo(v.z));
            Assert.That(-8.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-7f, -1f, -5.5f);
            var v = ov.swizzle.zyzz;
            Assert.That(-5.5f, Is.EqualTo(v.x));
            Assert.That(-1f, Is.EqualTo(v.y));
            Assert.That(-5.5f, Is.EqualTo(v.z));
            Assert.That(-5.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-3.5f, 6.5f, 2.5f);
            var v = ov.swizzle.zz;
            Assert.That(2.5f, Is.EqualTo(v.x));
            Assert.That(2.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(-4f, -7.5f, 7.5f);
            var v = ov.swizzle.zzx;
            Assert.That(7.5f, Is.EqualTo(v.x));
            Assert.That(7.5f, Is.EqualTo(v.y));
            Assert.That(-4f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(3f, -4f, 5f);
            var v = ov.swizzle.zzxx;
            Assert.That(5f, Is.EqualTo(v.x));
            Assert.That(5f, Is.EqualTo(v.y));
            Assert.That(3f, Is.EqualTo(v.z));
            Assert.That(3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-4.5f, 1f, -4.5f);
            var v = ov.swizzle.zzxy;
            Assert.That(-4.5f, Is.EqualTo(v.x));
            Assert.That(-4.5f, Is.EqualTo(v.y));
            Assert.That(-4.5f, Is.EqualTo(v.z));
            Assert.That(1f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(3f, 9f, 6f);
            var v = ov.swizzle.zzxz;
            Assert.That(6f, Is.EqualTo(v.x));
            Assert.That(6f, Is.EqualTo(v.y));
            Assert.That(3f, Is.EqualTo(v.z));
            Assert.That(6f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(2f, 3.5f, 5.5f);
            var v = ov.swizzle.zzy;
            Assert.That(5.5f, Is.EqualTo(v.x));
            Assert.That(5.5f, Is.EqualTo(v.y));
            Assert.That(3.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(1.5f, -6.5f, 5.5f);
            var v = ov.swizzle.zzyx;
            Assert.That(5.5f, Is.EqualTo(v.x));
            Assert.That(5.5f, Is.EqualTo(v.y));
            Assert.That(-6.5f, Is.EqualTo(v.z));
            Assert.That(1.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(5f, 2.5f, -7.5f);
            var v = ov.swizzle.zzyy;
            Assert.That(-7.5f, Is.EqualTo(v.x));
            Assert.That(-7.5f, Is.EqualTo(v.y));
            Assert.That(2.5f, Is.EqualTo(v.z));
            Assert.That(2.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(0.5f, 1.5f, 9f);
            var v = ov.swizzle.zzyz;
            Assert.That(9f, Is.EqualTo(v.x));
            Assert.That(9f, Is.EqualTo(v.y));
            Assert.That(1.5f, Is.EqualTo(v.z));
            Assert.That(9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-3.5f, 3f, -6.5f);
            var v = ov.swizzle.zzz;
            Assert.That(-6.5f, Is.EqualTo(v.x));
            Assert.That(-6.5f, Is.EqualTo(v.y));
            Assert.That(-6.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(8f, 4f, -7f);
            var v = ov.swizzle.zzzx;
            Assert.That(-7f, Is.EqualTo(v.x));
            Assert.That(-7f, Is.EqualTo(v.y));
            Assert.That(-7f, Is.EqualTo(v.z));
            Assert.That(8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-4f, -6f, -8f);
            var v = ov.swizzle.zzzy;
            Assert.That(-8f, Is.EqualTo(v.x));
            Assert.That(-8f, Is.EqualTo(v.y));
            Assert.That(-8f, Is.EqualTo(v.z));
            Assert.That(-6f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(3f, 2f, -9.5f);
            var v = ov.swizzle.zzzz;
            Assert.That(-9.5f, Is.EqualTo(v.x));
            Assert.That(-9.5f, Is.EqualTo(v.y));
            Assert.That(-9.5f, Is.EqualTo(v.z));
            Assert.That(-9.5f, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new vec3(-4f, 7f, -9.5f);
            var v = ov.swizzle.rr;
            Assert.That(-4f, Is.EqualTo(v.x));
            Assert.That(-4f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(6f, 5.5f, -8.5f);
            var v = ov.swizzle.rrr;
            Assert.That(6f, Is.EqualTo(v.x));
            Assert.That(6f, Is.EqualTo(v.y));
            Assert.That(6f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(1.5f, 1f, 0.5f);
            var v = ov.swizzle.rrrr;
            Assert.That(1.5f, Is.EqualTo(v.x));
            Assert.That(1.5f, Is.EqualTo(v.y));
            Assert.That(1.5f, Is.EqualTo(v.z));
            Assert.That(1.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-7.5f, -5f, -9f);
            var v = ov.swizzle.rrrg;
            Assert.That(-7.5f, Is.EqualTo(v.x));
            Assert.That(-7.5f, Is.EqualTo(v.y));
            Assert.That(-7.5f, Is.EqualTo(v.z));
            Assert.That(-5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-5.5f, 1.5f, -1f);
            var v = ov.swizzle.rrrb;
            Assert.That(-5.5f, Is.EqualTo(v.x));
            Assert.That(-5.5f, Is.EqualTo(v.y));
            Assert.That(-5.5f, Is.EqualTo(v.z));
            Assert.That(-1f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-3f, -7f, 7.5f);
            var v = ov.swizzle.rrg;
            Assert.That(-3f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(-7f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-1.5f, -9.5f, -8.5f);
            var v = ov.swizzle.rrgr;
            Assert.That(-1.5f, Is.EqualTo(v.x));
            Assert.That(-1.5f, Is.EqualTo(v.y));
            Assert.That(-9.5f, Is.EqualTo(v.z));
            Assert.That(-1.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(9f, 9f, 5.5f);
            var v = ov.swizzle.rrgg;
            Assert.That(9f, Is.EqualTo(v.x));
            Assert.That(9f, Is.EqualTo(v.y));
            Assert.That(9f, Is.EqualTo(v.z));
            Assert.That(9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(0.5f, -9.5f, 4f);
            var v = ov.swizzle.rrgb;
            Assert.That(0.5f, Is.EqualTo(v.x));
            Assert.That(0.5f, Is.EqualTo(v.y));
            Assert.That(-9.5f, Is.EqualTo(v.z));
            Assert.That(4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(9f, -1f, -9f);
            var v = ov.swizzle.rrb;
            Assert.That(9f, Is.EqualTo(v.x));
            Assert.That(9f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-8f, 5.5f, 9f);
            var v = ov.swizzle.rrbr;
            Assert.That(-8f, Is.EqualTo(v.x));
            Assert.That(-8f, Is.EqualTo(v.y));
            Assert.That(9f, Is.EqualTo(v.z));
            Assert.That(-8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-5f, 3.5f, -8f);
            var v = ov.swizzle.rrbg;
            Assert.That(-5f, Is.EqualTo(v.x));
            Assert.That(-5f, Is.EqualTo(v.y));
            Assert.That(-8f, Is.EqualTo(v.z));
            Assert.That(3.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(7.5f, -8f, 5f);
            var v = ov.swizzle.rrbb;
            Assert.That(7.5f, Is.EqualTo(v.x));
            Assert.That(7.5f, Is.EqualTo(v.y));
            Assert.That(5f, Is.EqualTo(v.z));
            Assert.That(5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-9f, 6.5f, -3.5f);
            var v = ov.swizzle.rg;
            Assert.That(-9f, Is.EqualTo(v.x));
            Assert.That(6.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(-2.5f, 6.5f, -5.5f);
            var v = ov.swizzle.rgr;
            Assert.That(-2.5f, Is.EqualTo(v.x));
            Assert.That(6.5f, Is.EqualTo(v.y));
            Assert.That(-2.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-7f, 7.5f, 4.5f);
            var v = ov.swizzle.rgrr;
            Assert.That(-7f, Is.EqualTo(v.x));
            Assert.That(7.5f, Is.EqualTo(v.y));
            Assert.That(-7f, Is.EqualTo(v.z));
            Assert.That(-7f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-1f, -2f, 4f);
            var v = ov.swizzle.rgrg;
            Assert.That(-1f, Is.EqualTo(v.x));
            Assert.That(-2f, Is.EqualTo(v.y));
            Assert.That(-1f, Is.EqualTo(v.z));
            Assert.That(-2f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(2.5f, 9f, 7f);
            var v = ov.swizzle.rgrb;
            Assert.That(2.5f, Is.EqualTo(v.x));
            Assert.That(9f, Is.EqualTo(v.y));
            Assert.That(2.5f, Is.EqualTo(v.z));
            Assert.That(7f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(8.5f, 4f, 8.5f);
            var v = ov.swizzle.rgg;
            Assert.That(8.5f, Is.EqualTo(v.x));
            Assert.That(4f, Is.EqualTo(v.y));
            Assert.That(4f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-4.5f, -6f, -6f);
            var v = ov.swizzle.rggr;
            Assert.That(-4.5f, Is.EqualTo(v.x));
            Assert.That(-6f, Is.EqualTo(v.y));
            Assert.That(-6f, Is.EqualTo(v.z));
            Assert.That(-4.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-7f, -8.5f, 0.5f);
            var v = ov.swizzle.rggg;
            Assert.That(-7f, Is.EqualTo(v.x));
            Assert.That(-8.5f, Is.EqualTo(v.y));
            Assert.That(-8.5f, Is.EqualTo(v.z));
            Assert.That(-8.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-1f, 4f, -9f);
            var v = ov.swizzle.rggb;
            Assert.That(-1f, Is.EqualTo(v.x));
            Assert.That(4f, Is.EqualTo(v.y));
            Assert.That(4f, Is.EqualTo(v.z));
            Assert.That(-9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(8f, 8f, 8.5f);
            var v = ov.swizzle.rgb;
            Assert.That(8f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
            Assert.That(8.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(3.5f, -5f, 8.5f);
            var v = ov.swizzle.rgbr;
            Assert.That(3.5f, Is.EqualTo(v.x));
            Assert.That(-5f, Is.EqualTo(v.y));
            Assert.That(8.5f, Is.EqualTo(v.z));
            Assert.That(3.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(2.5f, 8f, -6.5f);
            var v = ov.swizzle.rgbg;
            Assert.That(2.5f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
            Assert.That(-6.5f, Is.EqualTo(v.z));
            Assert.That(8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(5.5f, -7.5f, -3f);
            var v = ov.swizzle.rgbb;
            Assert.That(5.5f, Is.EqualTo(v.x));
            Assert.That(-7.5f, Is.EqualTo(v.y));
            Assert.That(-3f, Is.EqualTo(v.z));
            Assert.That(-3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-2f, -3f, -6.5f);
            var v = ov.swizzle.rb;
            Assert.That(-2f, Is.EqualTo(v.x));
            Assert.That(-6.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(9f, 9.5f, 9.5f);
            var v = ov.swizzle.rbr;
            Assert.That(9f, Is.EqualTo(v.x));
            Assert.That(9.5f, Is.EqualTo(v.y));
            Assert.That(9f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-5f, -4.5f, -3.5f);
            var v = ov.swizzle.rbrr;
            Assert.That(-5f, Is.EqualTo(v.x));
            Assert.That(-3.5f, Is.EqualTo(v.y));
            Assert.That(-5f, Is.EqualTo(v.z));
            Assert.That(-5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(2f, -7f, -1.5f);
            var v = ov.swizzle.rbrg;
            Assert.That(2f, Is.EqualTo(v.x));
            Assert.That(-1.5f, Is.EqualTo(v.y));
            Assert.That(2f, Is.EqualTo(v.z));
            Assert.That(-7f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-9f, -3f, 1f);
            var v = ov.swizzle.rbrb;
            Assert.That(-9f, Is.EqualTo(v.x));
            Assert.That(1f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
            Assert.That(1f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-0.5f, 2f, -6f);
            var v = ov.swizzle.rbg;
            Assert.That(-0.5f, Is.EqualTo(v.x));
            Assert.That(-6f, Is.EqualTo(v.y));
            Assert.That(2f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(5.5f, -7f, 1.5f);
            var v = ov.swizzle.rbgr;
            Assert.That(5.5f, Is.EqualTo(v.x));
            Assert.That(1.5f, Is.EqualTo(v.y));
            Assert.That(-7f, Is.EqualTo(v.z));
            Assert.That(5.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(4f, 8f, -1.5f);
            var v = ov.swizzle.rbgg;
            Assert.That(4f, Is.EqualTo(v.x));
            Assert.That(-1.5f, Is.EqualTo(v.y));
            Assert.That(8f, Is.EqualTo(v.z));
            Assert.That(8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(5.5f, -8f, 7.5f);
            var v = ov.swizzle.rbgb;
            Assert.That(5.5f, Is.EqualTo(v.x));
            Assert.That(7.5f, Is.EqualTo(v.y));
            Assert.That(-8f, Is.EqualTo(v.z));
            Assert.That(7.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(6f, 0f, 0f);
            var v = ov.swizzle.rbb;
            Assert.That(6f, Is.EqualTo(v.x));
            Assert.That(0f, Is.EqualTo(v.y));
            Assert.That(0f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-5.5f, 2f, -6.5f);
            var v = ov.swizzle.rbbr;
            Assert.That(-5.5f, Is.EqualTo(v.x));
            Assert.That(-6.5f, Is.EqualTo(v.y));
            Assert.That(-6.5f, Is.EqualTo(v.z));
            Assert.That(-5.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-3.5f, -4f, 3f);
            var v = ov.swizzle.rbbg;
            Assert.That(-3.5f, Is.EqualTo(v.x));
            Assert.That(3f, Is.EqualTo(v.y));
            Assert.That(3f, Is.EqualTo(v.z));
            Assert.That(-4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(3.5f, 6f, -8.5f);
            var v = ov.swizzle.rbbb;
            Assert.That(3.5f, Is.EqualTo(v.x));
            Assert.That(-8.5f, Is.EqualTo(v.y));
            Assert.That(-8.5f, Is.EqualTo(v.z));
            Assert.That(-8.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(1.5f, 6.5f, -9.5f);
            var v = ov.swizzle.gr;
            Assert.That(6.5f, Is.EqualTo(v.x));
            Assert.That(1.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(3.5f, 5f, 2.5f);
            var v = ov.swizzle.grr;
            Assert.That(5f, Is.EqualTo(v.x));
            Assert.That(3.5f, Is.EqualTo(v.y));
            Assert.That(3.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-1f, -4f, 1f);
            var v = ov.swizzle.grrr;
            Assert.That(-4f, Is.EqualTo(v.x));
            Assert.That(-1f, Is.EqualTo(v.y));
            Assert.That(-1f, Is.EqualTo(v.z));
            Assert.That(-1f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(6.5f, 2f, 6f);
            var v = ov.swizzle.grrg;
            Assert.That(2f, Is.EqualTo(v.x));
            Assert.That(6.5f, Is.EqualTo(v.y));
            Assert.That(6.5f, Is.EqualTo(v.z));
            Assert.That(2f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(7f, 9.5f, 4f);
            var v = ov.swizzle.grrb;
            Assert.That(9.5f, Is.EqualTo(v.x));
            Assert.That(7f, Is.EqualTo(v.y));
            Assert.That(7f, Is.EqualTo(v.z));
            Assert.That(4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-8.5f, 6f, 4f);
            var v = ov.swizzle.grg;
            Assert.That(6f, Is.EqualTo(v.x));
            Assert.That(-8.5f, Is.EqualTo(v.y));
            Assert.That(6f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(4.5f, -4f, -7.5f);
            var v = ov.swizzle.grgr;
            Assert.That(-4f, Is.EqualTo(v.x));
            Assert.That(4.5f, Is.EqualTo(v.y));
            Assert.That(-4f, Is.EqualTo(v.z));
            Assert.That(4.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(1f, 7f, -5.5f);
            var v = ov.swizzle.grgg;
            Assert.That(7f, Is.EqualTo(v.x));
            Assert.That(1f, Is.EqualTo(v.y));
            Assert.That(7f, Is.EqualTo(v.z));
            Assert.That(7f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-4.5f, -8f, -4f);
            var v = ov.swizzle.grgb;
            Assert.That(-8f, Is.EqualTo(v.x));
            Assert.That(-4.5f, Is.EqualTo(v.y));
            Assert.That(-8f, Is.EqualTo(v.z));
            Assert.That(-4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(4f, 3.5f, 9.5f);
            var v = ov.swizzle.grb;
            Assert.That(3.5f, Is.EqualTo(v.x));
            Assert.That(4f, Is.EqualTo(v.y));
            Assert.That(9.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(8.5f, 6.5f, 5.5f);
            var v = ov.swizzle.grbr;
            Assert.That(6.5f, Is.EqualTo(v.x));
            Assert.That(8.5f, Is.EqualTo(v.y));
            Assert.That(5.5f, Is.EqualTo(v.z));
            Assert.That(8.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(4.5f, 3f, -8.5f);
            var v = ov.swizzle.grbg;
            Assert.That(3f, Is.EqualTo(v.x));
            Assert.That(4.5f, Is.EqualTo(v.y));
            Assert.That(-8.5f, Is.EqualTo(v.z));
            Assert.That(3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-2f, -2f, 2f);
            var v = ov.swizzle.grbb;
            Assert.That(-2f, Is.EqualTo(v.x));
            Assert.That(-2f, Is.EqualTo(v.y));
            Assert.That(2f, Is.EqualTo(v.z));
            Assert.That(2f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(6.5f, -4.5f, 3f);
            var v = ov.swizzle.gg;
            Assert.That(-4.5f, Is.EqualTo(v.x));
            Assert.That(-4.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(5.5f, -1f, 8.5f);
            var v = ov.swizzle.ggr;
            Assert.That(-1f, Is.EqualTo(v.x));
            Assert.That(-1f, Is.EqualTo(v.y));
            Assert.That(5.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(3.5f, -7f, 3f);
            var v = ov.swizzle.ggrr;
            Assert.That(-7f, Is.EqualTo(v.x));
            Assert.That(-7f, Is.EqualTo(v.y));
            Assert.That(3.5f, Is.EqualTo(v.z));
            Assert.That(3.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-9f, 5f, 6f);
            var v = ov.swizzle.ggrg;
            Assert.That(5f, Is.EqualTo(v.x));
            Assert.That(5f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
            Assert.That(5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(9.5f, 8.5f, 2.5f);
            var v = ov.swizzle.ggrb;
            Assert.That(8.5f, Is.EqualTo(v.x));
            Assert.That(8.5f, Is.EqualTo(v.y));
            Assert.That(9.5f, Is.EqualTo(v.z));
            Assert.That(2.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(9.5f, 0.5f, -1.5f);
            var v = ov.swizzle.ggg;
            Assert.That(0.5f, Is.EqualTo(v.x));
            Assert.That(0.5f, Is.EqualTo(v.y));
            Assert.That(0.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(6.5f, 7f, -1.5f);
            var v = ov.swizzle.gggr;
            Assert.That(7f, Is.EqualTo(v.x));
            Assert.That(7f, Is.EqualTo(v.y));
            Assert.That(7f, Is.EqualTo(v.z));
            Assert.That(6.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-8f, 5f, -9.5f);
            var v = ov.swizzle.gggg;
            Assert.That(5f, Is.EqualTo(v.x));
            Assert.That(5f, Is.EqualTo(v.y));
            Assert.That(5f, Is.EqualTo(v.z));
            Assert.That(5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(2f, 7.5f, 5f);
            var v = ov.swizzle.gggb;
            Assert.That(7.5f, Is.EqualTo(v.x));
            Assert.That(7.5f, Is.EqualTo(v.y));
            Assert.That(7.5f, Is.EqualTo(v.z));
            Assert.That(5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-2f, -3f, 5.5f);
            var v = ov.swizzle.ggb;
            Assert.That(-3f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(5.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-5.5f, 8f, 5.5f);
            var v = ov.swizzle.ggbr;
            Assert.That(8f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
            Assert.That(5.5f, Is.EqualTo(v.z));
            Assert.That(-5.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(1f, 8.5f, -1.5f);
            var v = ov.swizzle.ggbg;
            Assert.That(8.5f, Is.EqualTo(v.x));
            Assert.That(8.5f, Is.EqualTo(v.y));
            Assert.That(-1.5f, Is.EqualTo(v.z));
            Assert.That(8.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-8f, 5f, 7.5f);
            var v = ov.swizzle.ggbb;
            Assert.That(5f, Is.EqualTo(v.x));
            Assert.That(5f, Is.EqualTo(v.y));
            Assert.That(7.5f, Is.EqualTo(v.z));
            Assert.That(7.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-4.5f, 1.5f, 0f);
            var v = ov.swizzle.gb;
            Assert.That(1.5f, Is.EqualTo(v.x));
            Assert.That(0f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(-1f, -3.5f, -1.5f);
            var v = ov.swizzle.gbr;
            Assert.That(-3.5f, Is.EqualTo(v.x));
            Assert.That(-1.5f, Is.EqualTo(v.y));
            Assert.That(-1f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(2.5f, 9.5f, 7.5f);
            var v = ov.swizzle.gbrr;
            Assert.That(9.5f, Is.EqualTo(v.x));
            Assert.That(7.5f, Is.EqualTo(v.y));
            Assert.That(2.5f, Is.EqualTo(v.z));
            Assert.That(2.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(2f, 5.5f, -4f);
            var v = ov.swizzle.gbrg;
            Assert.That(5.5f, Is.EqualTo(v.x));
            Assert.That(-4f, Is.EqualTo(v.y));
            Assert.That(2f, Is.EqualTo(v.z));
            Assert.That(5.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(2.5f, -5f, 3f);
            var v = ov.swizzle.gbrb;
            Assert.That(-5f, Is.EqualTo(v.x));
            Assert.That(3f, Is.EqualTo(v.y));
            Assert.That(2.5f, Is.EqualTo(v.z));
            Assert.That(3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-5f, -8f, -9.5f);
            var v = ov.swizzle.gbg;
            Assert.That(-8f, Is.EqualTo(v.x));
            Assert.That(-9.5f, Is.EqualTo(v.y));
            Assert.That(-8f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-6.5f, 3.5f, -3f);
            var v = ov.swizzle.gbgr;
            Assert.That(3.5f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(3.5f, Is.EqualTo(v.z));
            Assert.That(-6.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(2.5f, -7.5f, 4f);
            var v = ov.swizzle.gbgg;
            Assert.That(-7.5f, Is.EqualTo(v.x));
            Assert.That(4f, Is.EqualTo(v.y));
            Assert.That(-7.5f, Is.EqualTo(v.z));
            Assert.That(-7.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(8f, 4.5f, 6.5f);
            var v = ov.swizzle.gbgb;
            Assert.That(4.5f, Is.EqualTo(v.x));
            Assert.That(6.5f, Is.EqualTo(v.y));
            Assert.That(4.5f, Is.EqualTo(v.z));
            Assert.That(6.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-2f, 7.5f, 0f);
            var v = ov.swizzle.gbb;
            Assert.That(7.5f, Is.EqualTo(v.x));
            Assert.That(0f, Is.EqualTo(v.y));
            Assert.That(0f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(4f, -8.5f, -5.5f);
            var v = ov.swizzle.gbbr;
            Assert.That(-8.5f, Is.EqualTo(v.x));
            Assert.That(-5.5f, Is.EqualTo(v.y));
            Assert.That(-5.5f, Is.EqualTo(v.z));
            Assert.That(4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(1.5f, -2f, -7f);
            var v = ov.swizzle.gbbg;
            Assert.That(-2f, Is.EqualTo(v.x));
            Assert.That(-7f, Is.EqualTo(v.y));
            Assert.That(-7f, Is.EqualTo(v.z));
            Assert.That(-2f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-2.5f, 7f, -9f);
            var v = ov.swizzle.gbbb;
            Assert.That(7f, Is.EqualTo(v.x));
            Assert.That(-9f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
            Assert.That(-9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(2.5f, -1f, 8.5f);
            var v = ov.swizzle.br;
            Assert.That(8.5f, Is.EqualTo(v.x));
            Assert.That(2.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(8f, 8f, -8f);
            var v = ov.swizzle.brr;
            Assert.That(-8f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
            Assert.That(8f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-8.5f, 2.5f, 4.5f);
            var v = ov.swizzle.brrr;
            Assert.That(4.5f, Is.EqualTo(v.x));
            Assert.That(-8.5f, Is.EqualTo(v.y));
            Assert.That(-8.5f, Is.EqualTo(v.z));
            Assert.That(-8.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(1.5f, -2.5f, -9.5f);
            var v = ov.swizzle.brrg;
            Assert.That(-9.5f, Is.EqualTo(v.x));
            Assert.That(1.5f, Is.EqualTo(v.y));
            Assert.That(1.5f, Is.EqualTo(v.z));
            Assert.That(-2.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(8f, 4.5f, -3f);
            var v = ov.swizzle.brrb;
            Assert.That(-3f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
            Assert.That(8f, Is.EqualTo(v.z));
            Assert.That(-3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-5.5f, 2.5f, 8f);
            var v = ov.swizzle.brg;
            Assert.That(8f, Is.EqualTo(v.x));
            Assert.That(-5.5f, Is.EqualTo(v.y));
            Assert.That(2.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(6.5f, 1f, 2.5f);
            var v = ov.swizzle.brgr;
            Assert.That(2.5f, Is.EqualTo(v.x));
            Assert.That(6.5f, Is.EqualTo(v.y));
            Assert.That(1f, Is.EqualTo(v.z));
            Assert.That(6.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(2.5f, -8.5f, 1f);
            var v = ov.swizzle.brgg;
            Assert.That(1f, Is.EqualTo(v.x));
            Assert.That(2.5f, Is.EqualTo(v.y));
            Assert.That(-8.5f, Is.EqualTo(v.z));
            Assert.That(-8.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(7.5f, 8.5f, -4f);
            var v = ov.swizzle.brgb;
            Assert.That(-4f, Is.EqualTo(v.x));
            Assert.That(7.5f, Is.EqualTo(v.y));
            Assert.That(8.5f, Is.EqualTo(v.z));
            Assert.That(-4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-0.5f, 0f, 3f);
            var v = ov.swizzle.brb;
            Assert.That(3f, Is.EqualTo(v.x));
            Assert.That(-0.5f, Is.EqualTo(v.y));
            Assert.That(3f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-2.5f, -2.5f, -1f);
            var v = ov.swizzle.brbr;
            Assert.That(-1f, Is.EqualTo(v.x));
            Assert.That(-2.5f, Is.EqualTo(v.y));
            Assert.That(-1f, Is.EqualTo(v.z));
            Assert.That(-2.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(0f, 1.5f, -7.5f);
            var v = ov.swizzle.brbg;
            Assert.That(-7.5f, Is.EqualTo(v.x));
            Assert.That(0f, Is.EqualTo(v.y));
            Assert.That(-7.5f, Is.EqualTo(v.z));
            Assert.That(1.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-5f, -5.5f, -4f);
            var v = ov.swizzle.brbb;
            Assert.That(-4f, Is.EqualTo(v.x));
            Assert.That(-5f, Is.EqualTo(v.y));
            Assert.That(-4f, Is.EqualTo(v.z));
            Assert.That(-4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-2.5f, -2.5f, 1f);
            var v = ov.swizzle.bg;
            Assert.That(1f, Is.EqualTo(v.x));
            Assert.That(-2.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(1f, -9.5f, -1f);
            var v = ov.swizzle.bgr;
            Assert.That(-1f, Is.EqualTo(v.x));
            Assert.That(-9.5f, Is.EqualTo(v.y));
            Assert.That(1f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-9.5f, 5.5f, -3.5f);
            var v = ov.swizzle.bgrr;
            Assert.That(-3.5f, Is.EqualTo(v.x));
            Assert.That(5.5f, Is.EqualTo(v.y));
            Assert.That(-9.5f, Is.EqualTo(v.z));
            Assert.That(-9.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-2f, 6f, -9f);
            var v = ov.swizzle.bgrg;
            Assert.That(-9f, Is.EqualTo(v.x));
            Assert.That(6f, Is.EqualTo(v.y));
            Assert.That(-2f, Is.EqualTo(v.z));
            Assert.That(6f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(7f, 1.5f, 5f);
            var v = ov.swizzle.bgrb;
            Assert.That(5f, Is.EqualTo(v.x));
            Assert.That(1.5f, Is.EqualTo(v.y));
            Assert.That(7f, Is.EqualTo(v.z));
            Assert.That(5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-2.5f, 9.5f, 0.5f);
            var v = ov.swizzle.bgg;
            Assert.That(0.5f, Is.EqualTo(v.x));
            Assert.That(9.5f, Is.EqualTo(v.y));
            Assert.That(9.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(6.5f, -1f, 9f);
            var v = ov.swizzle.bggr;
            Assert.That(9f, Is.EqualTo(v.x));
            Assert.That(-1f, Is.EqualTo(v.y));
            Assert.That(-1f, Is.EqualTo(v.z));
            Assert.That(6.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(3f, 2.5f, 2.5f);
            var v = ov.swizzle.bggg;
            Assert.That(2.5f, Is.EqualTo(v.x));
            Assert.That(2.5f, Is.EqualTo(v.y));
            Assert.That(2.5f, Is.EqualTo(v.z));
            Assert.That(2.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(0.5f, 4f, 0f);
            var v = ov.swizzle.bggb;
            Assert.That(0f, Is.EqualTo(v.x));
            Assert.That(4f, Is.EqualTo(v.y));
            Assert.That(4f, Is.EqualTo(v.z));
            Assert.That(0f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(8f, 7f, 2f);
            var v = ov.swizzle.bgb;
            Assert.That(2f, Is.EqualTo(v.x));
            Assert.That(7f, Is.EqualTo(v.y));
            Assert.That(2f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(0.5f, 9f, 8f);
            var v = ov.swizzle.bgbr;
            Assert.That(8f, Is.EqualTo(v.x));
            Assert.That(9f, Is.EqualTo(v.y));
            Assert.That(8f, Is.EqualTo(v.z));
            Assert.That(0.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(5.5f, 9f, -5f);
            var v = ov.swizzle.bgbg;
            Assert.That(-5f, Is.EqualTo(v.x));
            Assert.That(9f, Is.EqualTo(v.y));
            Assert.That(-5f, Is.EqualTo(v.z));
            Assert.That(9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(0.5f, 0.5f, 0f);
            var v = ov.swizzle.bgbb;
            Assert.That(0f, Is.EqualTo(v.x));
            Assert.That(0.5f, Is.EqualTo(v.y));
            Assert.That(0f, Is.EqualTo(v.z));
            Assert.That(0f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(0.5f, -8f, 2f);
            var v = ov.swizzle.bb;
            Assert.That(2f, Is.EqualTo(v.x));
            Assert.That(2f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec3(-2.5f, -8f, 3.5f);
            var v = ov.swizzle.bbr;
            Assert.That(3.5f, Is.EqualTo(v.x));
            Assert.That(3.5f, Is.EqualTo(v.y));
            Assert.That(-2.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(-4.5f, -9.5f, 5.5f);
            var v = ov.swizzle.bbrr;
            Assert.That(5.5f, Is.EqualTo(v.x));
            Assert.That(5.5f, Is.EqualTo(v.y));
            Assert.That(-4.5f, Is.EqualTo(v.z));
            Assert.That(-4.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(5f, -4f, 2.5f);
            var v = ov.swizzle.bbrg;
            Assert.That(2.5f, Is.EqualTo(v.x));
            Assert.That(2.5f, Is.EqualTo(v.y));
            Assert.That(5f, Is.EqualTo(v.z));
            Assert.That(-4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(2.5f, -8f, -3f);
            var v = ov.swizzle.bbrb;
            Assert.That(-3f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(2.5f, Is.EqualTo(v.z));
            Assert.That(-3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(3f, -6.5f, 5.5f);
            var v = ov.swizzle.bbg;
            Assert.That(5.5f, Is.EqualTo(v.x));
            Assert.That(5.5f, Is.EqualTo(v.y));
            Assert.That(-6.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(9f, -1f, -5f);
            var v = ov.swizzle.bbgr;
            Assert.That(-5f, Is.EqualTo(v.x));
            Assert.That(-5f, Is.EqualTo(v.y));
            Assert.That(-1f, Is.EqualTo(v.z));
            Assert.That(9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-1f, -1f, -2.5f);
            var v = ov.swizzle.bbgg;
            Assert.That(-2.5f, Is.EqualTo(v.x));
            Assert.That(-2.5f, Is.EqualTo(v.y));
            Assert.That(-1f, Is.EqualTo(v.z));
            Assert.That(-1f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-5.5f, -8.5f, 6.5f);
            var v = ov.swizzle.bbgb;
            Assert.That(6.5f, Is.EqualTo(v.x));
            Assert.That(6.5f, Is.EqualTo(v.y));
            Assert.That(-8.5f, Is.EqualTo(v.z));
            Assert.That(6.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(9f, -2f, -7.5f);
            var v = ov.swizzle.bbb;
            Assert.That(-7.5f, Is.EqualTo(v.x));
            Assert.That(-7.5f, Is.EqualTo(v.y));
            Assert.That(-7.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec3(0.5f, 6.5f, 8f);
            var v = ov.swizzle.bbbr;
            Assert.That(8f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
            Assert.That(8f, Is.EqualTo(v.z));
            Assert.That(0.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(-0.5f, 6f, 3.5f);
            var v = ov.swizzle.bbbg;
            Assert.That(3.5f, Is.EqualTo(v.x));
            Assert.That(3.5f, Is.EqualTo(v.y));
            Assert.That(3.5f, Is.EqualTo(v.z));
            Assert.That(6f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec3(6f, -7f, -4f);
            var v = ov.swizzle.bbbb;
            Assert.That(-4f, Is.EqualTo(v.x));
            Assert.That(-4f, Is.EqualTo(v.y));
            Assert.That(-4f, Is.EqualTo(v.z));
            Assert.That(-4f, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new vec3(8.5f, -0.5f, -7f);
            var v1 = new vec2(6f, 3f);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(6f, Is.EqualTo(v0.x));
            Assert.That(3f, Is.EqualTo(v0.y));
            Assert.That(-7f, Is.EqualTo(v0.z));
        
            Assert.That(8.5f, Is.EqualTo(v2.x));
            Assert.That(-0.5f, Is.EqualTo(v2.y));
        }
        {
            var v0 = new vec3(2.5f, -1.5f, -5f);
            var v1 = new vec2(-5.5f, -3.5f);
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-5.5f, Is.EqualTo(v0.x));
            Assert.That(-1.5f, Is.EqualTo(v0.y));
            Assert.That(-3.5f, Is.EqualTo(v0.z));
        
            Assert.That(2.5f, Is.EqualTo(v2.x));
            Assert.That(-5f, Is.EqualTo(v2.y));
        }
        {
            var v0 = new vec3(-9f, 7f, -6.5f);
            var v1 = new vec2(6f, -8f);
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-9f, Is.EqualTo(v0.x));
            Assert.That(6f, Is.EqualTo(v0.y));
            Assert.That(-8f, Is.EqualTo(v0.z));
        
            Assert.That(7f, Is.EqualTo(v2.x));
            Assert.That(-6.5f, Is.EqualTo(v2.y));
        }
        {
            var v0 = new vec3(5.5f, -3.5f, 2f);
            var v1 = new vec3(8.5f, 8f, 4f);
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(8.5f, Is.EqualTo(v0.x));
            Assert.That(8f, Is.EqualTo(v0.y));
            Assert.That(4f, Is.EqualTo(v0.z));
        
            Assert.That(5.5f, Is.EqualTo(v2.x));
            Assert.That(-3.5f, Is.EqualTo(v2.y));
            Assert.That(2f, Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new vec3(3f, 2.5f, -3f);
            var v1 = 7.5f;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(7.5f, Is.EqualTo(v0.x));
            Assert.That(2.5f, Is.EqualTo(v0.y));
            Assert.That(-3f, Is.EqualTo(v0.z));
        
            Assert.That(3f, Is.EqualTo(v2));
        }
        {
            var v0 = new vec3(-4f, 2f, -9f);
            var v1 = 5f;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-4f, Is.EqualTo(v0.x));
            Assert.That(5f, Is.EqualTo(v0.y));
            Assert.That(-9f, Is.EqualTo(v0.z));
        
            Assert.That(2f, Is.EqualTo(v2));
        }
        {
            var v0 = new vec3(-0.5f, -0.5f, 1f);
            var v1 = new vec2(2.5f, 6.5f);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(2.5f, Is.EqualTo(v0.x));
            Assert.That(6.5f, Is.EqualTo(v0.y));
            Assert.That(1f, Is.EqualTo(v0.z));
        
            Assert.That(-0.5f, Is.EqualTo(v2.x));
            Assert.That(-0.5f, Is.EqualTo(v2.y));
        }
        {
            var v0 = new vec3(3f, -1f, -5.5f);
            var v1 = 3f;
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(3f, Is.EqualTo(v0.x));
            Assert.That(-1f, Is.EqualTo(v0.y));
            Assert.That(3f, Is.EqualTo(v0.z));
        
            Assert.That(-5.5f, Is.EqualTo(v2));
        }
        {
            var v0 = new vec3(-7.5f, 4f, -8f);
            var v1 = new vec2(-7f, -3.5f);
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-7f, Is.EqualTo(v0.x));
            Assert.That(4f, Is.EqualTo(v0.y));
            Assert.That(-3.5f, Is.EqualTo(v0.z));
        
            Assert.That(-7.5f, Is.EqualTo(v2.x));
            Assert.That(-8f, Is.EqualTo(v2.y));
        }
        {
            var v0 = new vec3(-4f, 4f, 1.5f);
            var v1 = new vec2(3f, -7f);
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-4f, Is.EqualTo(v0.x));
            Assert.That(3f, Is.EqualTo(v0.y));
            Assert.That(-7f, Is.EqualTo(v0.z));
        
            Assert.That(4f, Is.EqualTo(v2.x));
            Assert.That(1.5f, Is.EqualTo(v2.y));
        }
        {
            var v0 = new vec3(-4f, -9f, -6f);
            var v1 = new vec3(-8.5f, -5f, 6.5f);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-8.5f, Is.EqualTo(v0.x));
            Assert.That(-5f, Is.EqualTo(v0.y));
            Assert.That(6.5f, Is.EqualTo(v0.z));
        
            Assert.That(-4f, Is.EqualTo(v2.x));
            Assert.That(-9f, Is.EqualTo(v2.y));
            Assert.That(-6f, Is.EqualTo(v2.z));
        }
    }

}
