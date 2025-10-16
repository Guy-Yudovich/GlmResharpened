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
public class LongSwizzleVec3Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new lvec3(9L, -4L, 1);
            var v = ov.swizzle.xx;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(1, 9L, 0);
            var v = ov.swizzle.xxx;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-9L, -1L, -5L);
            var v = ov.swizzle.xxxx;
            Assert.That(-9L, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(-9L, Is.EqualTo(v.z));
            Assert.That(-9L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(4L, 4L, -2L);
            var v = ov.swizzle.xxxy;
            Assert.That(4L, Is.EqualTo(v.x));
            Assert.That(4L, Is.EqualTo(v.y));
            Assert.That(4L, Is.EqualTo(v.z));
            Assert.That(4L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(5L, -8L, -8L);
            var v = ov.swizzle.xxxz;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(5L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
            Assert.That(-8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(6L, -3L, -3L);
            var v = ov.swizzle.xxy;
            Assert.That(6L, Is.EqualTo(v.x));
            Assert.That(6L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(7L, -6L, 4L);
            var v = ov.swizzle.xxyx;
            Assert.That(7L, Is.EqualTo(v.x));
            Assert.That(7L, Is.EqualTo(v.y));
            Assert.That(-6L, Is.EqualTo(v.z));
            Assert.That(7L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(3L, 1, 7L);
            var v = ov.swizzle.xxyy;
            Assert.That(3L, Is.EqualTo(v.x));
            Assert.That(3L, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(2L, 2L, 7L);
            var v = ov.swizzle.xxyz;
            Assert.That(2L, Is.EqualTo(v.x));
            Assert.That(2L, Is.EqualTo(v.y));
            Assert.That(2L, Is.EqualTo(v.z));
            Assert.That(7L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-5L, 5L, 4L);
            var v = ov.swizzle.xxz;
            Assert.That(-5L, Is.EqualTo(v.x));
            Assert.That(-5L, Is.EqualTo(v.y));
            Assert.That(4L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-3L, 4L, -8L);
            var v = ov.swizzle.xxzx;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(-3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(0, -3L, -3L);
            var v = ov.swizzle.xxzy;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
            Assert.That(-3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, -6L, -8L);
            var v = ov.swizzle.xxzz;
            Assert.That(-4L, Is.EqualTo(v.x));
            Assert.That(-4L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(-8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-6L, -3L, -4L);
            var v = ov.swizzle.xy;
            Assert.That(-6L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(0, 2L, 8L);
            var v = ov.swizzle.xyx;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(2L, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(3L, 4L, -6L);
            var v = ov.swizzle.xyxx;
            Assert.That(3L, Is.EqualTo(v.x));
            Assert.That(4L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
            Assert.That(3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(2L, 9L, -1L);
            var v = ov.swizzle.xyxy;
            Assert.That(2L, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(2L, Is.EqualTo(v.z));
            Assert.That(9L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-2L, 7L, -2L);
            var v = ov.swizzle.xyxz;
            Assert.That(-2L, Is.EqualTo(v.x));
            Assert.That(7L, Is.EqualTo(v.y));
            Assert.That(-2L, Is.EqualTo(v.z));
            Assert.That(-2L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(4L, 5L, -3L);
            var v = ov.swizzle.xyy;
            Assert.That(4L, Is.EqualTo(v.x));
            Assert.That(5L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-3L, -8L, 6L);
            var v = ov.swizzle.xyyx;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-8L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(-3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-3L, 3L, 5L);
            var v = ov.swizzle.xyyy;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(3L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
            Assert.That(3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-1L, -2L, 0);
            var v = ov.swizzle.xyyz;
            Assert.That(-1L, Is.EqualTo(v.x));
            Assert.That(-2L, Is.EqualTo(v.y));
            Assert.That(-2L, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, 4L, 4L);
            var v = ov.swizzle.xyz;
            Assert.That(-4L, Is.EqualTo(v.x));
            Assert.That(4L, Is.EqualTo(v.y));
            Assert.That(4L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(5L, -3L, -7L);
            var v = ov.swizzle.xyzx;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(-7L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, -1L, 2L);
            var v = ov.swizzle.xyzy;
            Assert.That(-4L, Is.EqualTo(v.x));
            Assert.That(-1L, Is.EqualTo(v.y));
            Assert.That(2L, Is.EqualTo(v.z));
            Assert.That(-1L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(9L, 2L, -8L);
            var v = ov.swizzle.xyzz;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(2L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(-8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-9L, -9L, -7L);
            var v = ov.swizzle.xz;
            Assert.That(-9L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(-1L, -3L, -5L);
            var v = ov.swizzle.xzx;
            Assert.That(-1L, Is.EqualTo(v.x));
            Assert.That(-5L, Is.EqualTo(v.y));
            Assert.That(-1L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-3L, 0, -6L);
            var v = ov.swizzle.xzxx;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-6L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
            Assert.That(-3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(6L, -5L, 6L);
            var v = ov.swizzle.xzxy;
            Assert.That(6L, Is.EqualTo(v.x));
            Assert.That(6L, Is.EqualTo(v.y));
            Assert.That(6L, Is.EqualTo(v.z));
            Assert.That(-5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-9L, 0, -8L);
            var v = ov.swizzle.xzxz;
            Assert.That(-9L, Is.EqualTo(v.x));
            Assert.That(-8L, Is.EqualTo(v.y));
            Assert.That(-9L, Is.EqualTo(v.z));
            Assert.That(-8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-1L, 3L, 9L);
            var v = ov.swizzle.xzy;
            Assert.That(-1L, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(8L, 9L, -1L);
            var v = ov.swizzle.xzyx;
            Assert.That(8L, Is.EqualTo(v.x));
            Assert.That(-1L, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
            Assert.That(8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(8L, 9L, 0);
            var v = ov.swizzle.xzyy;
            Assert.That(8L, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
            Assert.That(9L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-2L, -7L, -7L);
            var v = ov.swizzle.xzyz;
            Assert.That(-2L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(-7L, Is.EqualTo(v.z));
            Assert.That(-7L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, -7L, -7L);
            var v = ov.swizzle.xzz;
            Assert.That(-4L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(-7L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(8L, -5L, 3L);
            var v = ov.swizzle.xzzx;
            Assert.That(8L, Is.EqualTo(v.x));
            Assert.That(3L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
            Assert.That(8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, -4L, -8L);
            var v = ov.swizzle.xzzy;
            Assert.That(-4L, Is.EqualTo(v.x));
            Assert.That(-8L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(-4L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(9L, 1, 9L);
            var v = ov.swizzle.xzzz;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
            Assert.That(9L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-1L, -8L, -1L);
            var v = ov.swizzle.yx;
            Assert.That(-8L, Is.EqualTo(v.x));
            Assert.That(-1L, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(4L, 6L, 8L);
            var v = ov.swizzle.yxx;
            Assert.That(6L, Is.EqualTo(v.x));
            Assert.That(4L, Is.EqualTo(v.y));
            Assert.That(4L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-7L, 5L, -2L);
            var v = ov.swizzle.yxxx;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(-7L, Is.EqualTo(v.z));
            Assert.That(-7L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-9L, 3L, 6L);
            var v = ov.swizzle.yxxy;
            Assert.That(3L, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(-9L, Is.EqualTo(v.z));
            Assert.That(3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-3L, 0, -3L);
            var v = ov.swizzle.yxxz;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
            Assert.That(-3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, 9L, 9L);
            var v = ov.swizzle.yxy;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(7L, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-7L, -8L, -6L);
            var v = ov.swizzle.yxyx;
            Assert.That(-8L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(-7L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-7L, -9L, 2L);
            var v = ov.swizzle.yxyy;
            Assert.That(-9L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(-9L, Is.EqualTo(v.z));
            Assert.That(-9L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-8L, -7L, 0);
            var v = ov.swizzle.yxyz;
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(-8L, Is.EqualTo(v.y));
            Assert.That(-7L, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(3L, 5L, 5L);
            var v = ov.swizzle.yxz;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(3L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-9L, 1, 1);
            var v = ov.swizzle.yxzx;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(-9L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-9L, -8L, -1L);
            var v = ov.swizzle.yxzy;
            Assert.That(-8L, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(-1L, Is.EqualTo(v.z));
            Assert.That(-8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-9L, 4L, 2L);
            var v = ov.swizzle.yxzz;
            Assert.That(4L, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(2L, Is.EqualTo(v.z));
            Assert.That(2L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-1L, -5L, -1L);
            var v = ov.swizzle.yy;
            Assert.That(-5L, Is.EqualTo(v.x));
            Assert.That(-5L, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(4L, -5L, -4L);
            var v = ov.swizzle.yyx;
            Assert.That(-5L, Is.EqualTo(v.x));
            Assert.That(-5L, Is.EqualTo(v.y));
            Assert.That(4L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(9L, -6L, -4L);
            var v = ov.swizzle.yyxx;
            Assert.That(-6L, Is.EqualTo(v.x));
            Assert.That(-6L, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
            Assert.That(9L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-1L, 6L, 3L);
            var v = ov.swizzle.yyxy;
            Assert.That(6L, Is.EqualTo(v.x));
            Assert.That(6L, Is.EqualTo(v.y));
            Assert.That(-1L, Is.EqualTo(v.z));
            Assert.That(6L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(8L, -3L, 3L);
            var v = ov.swizzle.yyxz;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(8L, Is.EqualTo(v.z));
            Assert.That(3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, -3L, -8L);
            var v = ov.swizzle.yyy;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(8L, 5L, 9L);
            var v = ov.swizzle.yyyx;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(5L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
            Assert.That(8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(8L, -3L, 0);
            var v = ov.swizzle.yyyy;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
            Assert.That(-3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(5L, -9L, 1);
            var v = ov.swizzle.yyyz;
            Assert.That(-9L, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(-9L, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(5L, -4L, 2L);
            var v = ov.swizzle.yyz;
            Assert.That(-4L, Is.EqualTo(v.x));
            Assert.That(-4L, Is.EqualTo(v.y));
            Assert.That(2L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(1, 8L, 5L);
            var v = ov.swizzle.yyzx;
            Assert.That(8L, Is.EqualTo(v.x));
            Assert.That(8L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, 5L, 2L);
            var v = ov.swizzle.yyzy;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(5L, Is.EqualTo(v.y));
            Assert.That(2L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(4L, -2L, 4L);
            var v = ov.swizzle.yyzz;
            Assert.That(-2L, Is.EqualTo(v.x));
            Assert.That(-2L, Is.EqualTo(v.y));
            Assert.That(4L, Is.EqualTo(v.z));
            Assert.That(4L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(8L, 7L, 0);
            var v = ov.swizzle.yz;
            Assert.That(7L, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(6L, -2L, -9L);
            var v = ov.swizzle.yzx;
            Assert.That(-2L, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(6L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(1, 9L, 7L);
            var v = ov.swizzle.yzxx;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(7L, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-8L, 4L, 4L);
            var v = ov.swizzle.yzxy;
            Assert.That(4L, Is.EqualTo(v.x));
            Assert.That(4L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(4L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-3L, -1L, -8L);
            var v = ov.swizzle.yzxz;
            Assert.That(-1L, Is.EqualTo(v.x));
            Assert.That(-8L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
            Assert.That(-8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-2L, 2L, 1);
            var v = ov.swizzle.yzy;
            Assert.That(2L, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(2L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-1L, -8L, -5L);
            var v = ov.swizzle.yzyx;
            Assert.That(-8L, Is.EqualTo(v.x));
            Assert.That(-5L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(-1L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-2L, 4L, 2L);
            var v = ov.swizzle.yzyy;
            Assert.That(4L, Is.EqualTo(v.x));
            Assert.That(2L, Is.EqualTo(v.y));
            Assert.That(4L, Is.EqualTo(v.z));
            Assert.That(4L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-1L, 9L, -7L);
            var v = ov.swizzle.yzyz;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
            Assert.That(-7L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-8L, 1, 6L);
            var v = ov.swizzle.yzz;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(6L, Is.EqualTo(v.y));
            Assert.That(6L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(0, 8L, 1);
            var v = ov.swizzle.yzzx;
            Assert.That(8L, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, 0, -7L);
            var v = ov.swizzle.yzzy;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(-7L, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(9L, 1, 1);
            var v = ov.swizzle.yzzz;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(0, 4L, 9L);
            var v = ov.swizzle.zx;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(-4L, 6L, 8L);
            var v = ov.swizzle.zxx;
            Assert.That(8L, Is.EqualTo(v.x));
            Assert.That(-4L, Is.EqualTo(v.y));
            Assert.That(-4L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-7L, 7L, -8L);
            var v = ov.swizzle.zxxx;
            Assert.That(-8L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(-7L, Is.EqualTo(v.z));
            Assert.That(-7L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(6L, -5L, 3L);
            var v = ov.swizzle.zxxy;
            Assert.That(3L, Is.EqualTo(v.x));
            Assert.That(6L, Is.EqualTo(v.y));
            Assert.That(6L, Is.EqualTo(v.z));
            Assert.That(-5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(0, -4L, -3L);
            var v = ov.swizzle.zxxz;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(8L, -6L, 3L);
            var v = ov.swizzle.zxy;
            Assert.That(3L, Is.EqualTo(v.x));
            Assert.That(8L, Is.EqualTo(v.y));
            Assert.That(-6L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-7L, -5L, 2L);
            var v = ov.swizzle.zxyx;
            Assert.That(2L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(-5L, Is.EqualTo(v.z));
            Assert.That(-7L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(1, 3L, 8L);
            var v = ov.swizzle.zxyy;
            Assert.That(8L, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
            Assert.That(3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(1, -7L, -6L);
            var v = ov.swizzle.zxyz;
            Assert.That(-6L, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-7L, Is.EqualTo(v.z));
            Assert.That(-6L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(3L, -8L, -1L);
            var v = ov.swizzle.zxz;
            Assert.That(-1L, Is.EqualTo(v.x));
            Assert.That(3L, Is.EqualTo(v.y));
            Assert.That(-1L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(0, 2L, 0);
            var v = ov.swizzle.zxzx;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(0, 9L, -4L);
            var v = ov.swizzle.zxzy;
            Assert.That(-4L, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-4L, Is.EqualTo(v.z));
            Assert.That(9L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(5L, -8L, -7L);
            var v = ov.swizzle.zxzz;
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(5L, Is.EqualTo(v.y));
            Assert.That(-7L, Is.EqualTo(v.z));
            Assert.That(-7L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, -4L, 1);
            var v = ov.swizzle.zy;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-4L, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(-9L, -1L, 5L);
            var v = ov.swizzle.zyx;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(-1L, Is.EqualTo(v.y));
            Assert.That(-9L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(3L, 0, -5L);
            var v = ov.swizzle.zyxx;
            Assert.That(-5L, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
            Assert.That(3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, 5L, 3L);
            var v = ov.swizzle.zyxy;
            Assert.That(3L, Is.EqualTo(v.x));
            Assert.That(5L, Is.EqualTo(v.y));
            Assert.That(7L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, -2L, 6L);
            var v = ov.swizzle.zyxz;
            Assert.That(6L, Is.EqualTo(v.x));
            Assert.That(-2L, Is.EqualTo(v.y));
            Assert.That(-4L, Is.EqualTo(v.z));
            Assert.That(6L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-9L, -9L, 0);
            var v = ov.swizzle.zyy;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(-9L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(0, -3L, 9L);
            var v = ov.swizzle.zyyx;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-3L, -3L, 9L);
            var v = ov.swizzle.zyyy;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
            Assert.That(-3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(6L, 6L, -3L);
            var v = ov.swizzle.zyyz;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(6L, Is.EqualTo(v.y));
            Assert.That(6L, Is.EqualTo(v.z));
            Assert.That(-3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(2L, 0, 3L);
            var v = ov.swizzle.zyz;
            Assert.That(3L, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-8L, 3L, -7L);
            var v = ov.swizzle.zyzx;
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(3L, Is.EqualTo(v.y));
            Assert.That(-7L, Is.EqualTo(v.z));
            Assert.That(-8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(5L, 3L, 1);
            var v = ov.swizzle.zyzy;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(3L, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(0, 1, -3L);
            var v = ov.swizzle.zyzz;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
            Assert.That(-3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(2L, -7L, -7L);
            var v = ov.swizzle.zz;
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(0, -6L, -3L);
            var v = ov.swizzle.zzx;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(6L, 6L, 9L);
            var v = ov.swizzle.zzxx;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(6L, Is.EqualTo(v.z));
            Assert.That(6L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, 1, -1L);
            var v = ov.swizzle.zzxy;
            Assert.That(-1L, Is.EqualTo(v.x));
            Assert.That(-1L, Is.EqualTo(v.y));
            Assert.That(-4L, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, 4L, 5L);
            var v = ov.swizzle.zzxz;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(5L, Is.EqualTo(v.y));
            Assert.That(-4L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, 0, 0);
            var v = ov.swizzle.zzy;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-2L, -3L, 4L);
            var v = ov.swizzle.zzyx;
            Assert.That(4L, Is.EqualTo(v.x));
            Assert.That(4L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
            Assert.That(-2L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-3L, 1, -9L);
            var v = ov.swizzle.zzyy;
            Assert.That(-9L, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-2L, 8L, 2L);
            var v = ov.swizzle.zzyz;
            Assert.That(2L, Is.EqualTo(v.x));
            Assert.That(2L, Is.EqualTo(v.y));
            Assert.That(8L, Is.EqualTo(v.z));
            Assert.That(2L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(6L, 7L, 7L);
            var v = ov.swizzle.zzz;
            Assert.That(7L, Is.EqualTo(v.x));
            Assert.That(7L, Is.EqualTo(v.y));
            Assert.That(7L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(5L, -8L, -8L);
            var v = ov.swizzle.zzzx;
            Assert.That(-8L, Is.EqualTo(v.x));
            Assert.That(-8L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, -8L, -5L);
            var v = ov.swizzle.zzzy;
            Assert.That(-5L, Is.EqualTo(v.x));
            Assert.That(-5L, Is.EqualTo(v.y));
            Assert.That(-5L, Is.EqualTo(v.z));
            Assert.That(-8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-3L, -2L, -7L);
            var v = ov.swizzle.zzzz;
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(-7L, Is.EqualTo(v.z));
            Assert.That(-7L, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new lvec3(6L, -2L, 0);
            var v = ov.swizzle.rr;
            Assert.That(6L, Is.EqualTo(v.x));
            Assert.That(6L, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(5L, -7L, 5L);
            var v = ov.swizzle.rrr;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(5L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(7L, 0, 8L);
            var v = ov.swizzle.rrrr;
            Assert.That(7L, Is.EqualTo(v.x));
            Assert.That(7L, Is.EqualTo(v.y));
            Assert.That(7L, Is.EqualTo(v.z));
            Assert.That(7L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-9L, 5L, 3L);
            var v = ov.swizzle.rrrg;
            Assert.That(-9L, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(-9L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(9L, -9L, 3L);
            var v = ov.swizzle.rrrb;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
            Assert.That(3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-7L, 0, -8L);
            var v = ov.swizzle.rrg;
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-3L, 2L, 9L);
            var v = ov.swizzle.rrgr;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(2L, Is.EqualTo(v.z));
            Assert.That(-3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, 3L, -5L);
            var v = ov.swizzle.rrgg;
            Assert.That(7L, Is.EqualTo(v.x));
            Assert.That(7L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
            Assert.That(3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-5L, -4L, 2L);
            var v = ov.swizzle.rrgb;
            Assert.That(-5L, Is.EqualTo(v.x));
            Assert.That(-5L, Is.EqualTo(v.y));
            Assert.That(-4L, Is.EqualTo(v.z));
            Assert.That(2L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, 9L, 0);
            var v = ov.swizzle.rrb;
            Assert.That(7L, Is.EqualTo(v.x));
            Assert.That(7L, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-2L, -9L, -8L);
            var v = ov.swizzle.rrbr;
            Assert.That(-2L, Is.EqualTo(v.x));
            Assert.That(-2L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(-2L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, 8L, -2L);
            var v = ov.swizzle.rrbg;
            Assert.That(-4L, Is.EqualTo(v.x));
            Assert.That(-4L, Is.EqualTo(v.y));
            Assert.That(-2L, Is.EqualTo(v.z));
            Assert.That(8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(8L, 4L, -1L);
            var v = ov.swizzle.rrbb;
            Assert.That(8L, Is.EqualTo(v.x));
            Assert.That(8L, Is.EqualTo(v.y));
            Assert.That(-1L, Is.EqualTo(v.z));
            Assert.That(-1L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(3L, -7L, 3L);
            var v = ov.swizzle.rg;
            Assert.That(3L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(-8L, 6L, -8L);
            var v = ov.swizzle.rgr;
            Assert.That(-8L, Is.EqualTo(v.x));
            Assert.That(6L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(5L, -7L, -3L);
            var v = ov.swizzle.rgrr;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(5L, -6L, 6L);
            var v = ov.swizzle.rgrg;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(-6L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
            Assert.That(-6L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(1, -9L, -1L);
            var v = ov.swizzle.rgrb;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(-1L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(8L, -9L, 8L);
            var v = ov.swizzle.rgg;
            Assert.That(8L, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(-9L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(4L, 9L, 3L);
            var v = ov.swizzle.rggr;
            Assert.That(4L, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
            Assert.That(4L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(2L, 0, -1L);
            var v = ov.swizzle.rggg;
            Assert.That(2L, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(8L, 7L, 5L);
            var v = ov.swizzle.rggb;
            Assert.That(8L, Is.EqualTo(v.x));
            Assert.That(7L, Is.EqualTo(v.y));
            Assert.That(7L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(4L, -5L, -1L);
            var v = ov.swizzle.rgb;
            Assert.That(4L, Is.EqualTo(v.x));
            Assert.That(-5L, Is.EqualTo(v.y));
            Assert.That(-1L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-1L, 8L, -6L);
            var v = ov.swizzle.rgbr;
            Assert.That(-1L, Is.EqualTo(v.x));
            Assert.That(8L, Is.EqualTo(v.y));
            Assert.That(-6L, Is.EqualTo(v.z));
            Assert.That(-1L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, 8L, 5L);
            var v = ov.swizzle.rgbg;
            Assert.That(7L, Is.EqualTo(v.x));
            Assert.That(8L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
            Assert.That(8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(5L, 8L, -6L);
            var v = ov.swizzle.rgbb;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(8L, Is.EqualTo(v.y));
            Assert.That(-6L, Is.EqualTo(v.z));
            Assert.That(-6L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-7L, 8L, -6L);
            var v = ov.swizzle.rb;
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(-6L, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(9L, 1, -3L);
            var v = ov.swizzle.rbr;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-4L, -1L, 0);
            var v = ov.swizzle.rbrr;
            Assert.That(-4L, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-4L, Is.EqualTo(v.z));
            Assert.That(-4L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(6L, 5L, 9L);
            var v = ov.swizzle.rbrg;
            Assert.That(6L, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(6L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(3L, 3L, -4L);
            var v = ov.swizzle.rbrb;
            Assert.That(3L, Is.EqualTo(v.x));
            Assert.That(-4L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
            Assert.That(-4L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(6L, 0, -7L);
            var v = ov.swizzle.rbg;
            Assert.That(6L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-3L, 9L, -9L);
            var v = ov.swizzle.rbgr;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
            Assert.That(-3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-2L, 1, 1);
            var v = ov.swizzle.rbgg;
            Assert.That(-2L, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(2L, -5L, 7L);
            var v = ov.swizzle.rbgb;
            Assert.That(2L, Is.EqualTo(v.x));
            Assert.That(7L, Is.EqualTo(v.y));
            Assert.That(-5L, Is.EqualTo(v.z));
            Assert.That(7L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(9L, -3L, 9L);
            var v = ov.swizzle.rbb;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(5L, 3L, 9L);
            var v = ov.swizzle.rbbr;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-3L, 6L, 1);
            var v = ov.swizzle.rbbg;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(6L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, -3L, -8L);
            var v = ov.swizzle.rbbb;
            Assert.That(7L, Is.EqualTo(v.x));
            Assert.That(-8L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(-8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-7L, -5L, -7L);
            var v = ov.swizzle.gr;
            Assert.That(-5L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(5L, -7L, 9L);
            var v = ov.swizzle.grr;
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(5L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(0, 7L, 4L);
            var v = ov.swizzle.grrr;
            Assert.That(7L, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(2L, 1, 7L);
            var v = ov.swizzle.grrg;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(2L, Is.EqualTo(v.y));
            Assert.That(2L, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, -2L, -9L);
            var v = ov.swizzle.grrb;
            Assert.That(-2L, Is.EqualTo(v.x));
            Assert.That(7L, Is.EqualTo(v.y));
            Assert.That(7L, Is.EqualTo(v.z));
            Assert.That(-9L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-6L, 5L, 7L);
            var v = ov.swizzle.grg;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(-6L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-4L, 6L, 6L);
            var v = ov.swizzle.grgr;
            Assert.That(6L, Is.EqualTo(v.x));
            Assert.That(-4L, Is.EqualTo(v.y));
            Assert.That(6L, Is.EqualTo(v.z));
            Assert.That(-4L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(4L, 3L, -7L);
            var v = ov.swizzle.grgg;
            Assert.That(3L, Is.EqualTo(v.x));
            Assert.That(4L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
            Assert.That(3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(9L, 1, 1);
            var v = ov.swizzle.grgb;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-9L, 9L, -6L);
            var v = ov.swizzle.grb;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(-6L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-2L, -9L, 7L);
            var v = ov.swizzle.grbr;
            Assert.That(-9L, Is.EqualTo(v.x));
            Assert.That(-2L, Is.EqualTo(v.y));
            Assert.That(7L, Is.EqualTo(v.z));
            Assert.That(-2L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-9L, -5L, -5L);
            var v = ov.swizzle.grbg;
            Assert.That(-5L, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(-5L, Is.EqualTo(v.z));
            Assert.That(-5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(2L, 6L, 3L);
            var v = ov.swizzle.grbb;
            Assert.That(6L, Is.EqualTo(v.x));
            Assert.That(2L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
            Assert.That(3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-2L, 1, 6L);
            var v = ov.swizzle.gg;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(3L, 7L, -2L);
            var v = ov.swizzle.ggr;
            Assert.That(7L, Is.EqualTo(v.x));
            Assert.That(7L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(1, -8L, -1L);
            var v = ov.swizzle.ggrr;
            Assert.That(-8L, Is.EqualTo(v.x));
            Assert.That(-8L, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-1L, -6L, 1);
            var v = ov.swizzle.ggrg;
            Assert.That(-6L, Is.EqualTo(v.x));
            Assert.That(-6L, Is.EqualTo(v.y));
            Assert.That(-1L, Is.EqualTo(v.z));
            Assert.That(-6L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, -3L, 5L);
            var v = ov.swizzle.ggrb;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(-4L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-1L, -3L, -1L);
            var v = ov.swizzle.ggg;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-9L, -5L, -6L);
            var v = ov.swizzle.gggr;
            Assert.That(-5L, Is.EqualTo(v.x));
            Assert.That(-5L, Is.EqualTo(v.y));
            Assert.That(-5L, Is.EqualTo(v.z));
            Assert.That(-9L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, 0, -7L);
            var v = ov.swizzle.gggg;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, 9L, 1);
            var v = ov.swizzle.gggb;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(0, 8L, -6L);
            var v = ov.swizzle.ggb;
            Assert.That(8L, Is.EqualTo(v.x));
            Assert.That(8L, Is.EqualTo(v.y));
            Assert.That(-6L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(3L, -3L, -9L);
            var v = ov.swizzle.ggbr;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(-9L, Is.EqualTo(v.z));
            Assert.That(3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(3L, 2L, 5L);
            var v = ov.swizzle.ggbg;
            Assert.That(2L, Is.EqualTo(v.x));
            Assert.That(2L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
            Assert.That(2L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-9L, 1, -5L);
            var v = ov.swizzle.ggbb;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-5L, Is.EqualTo(v.z));
            Assert.That(-5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(5L, 8L, 3L);
            var v = ov.swizzle.gb;
            Assert.That(8L, Is.EqualTo(v.x));
            Assert.That(3L, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(-1L, 8L, -4L);
            var v = ov.swizzle.gbr;
            Assert.That(8L, Is.EqualTo(v.x));
            Assert.That(-4L, Is.EqualTo(v.y));
            Assert.That(-1L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-5L, -8L, 5L);
            var v = ov.swizzle.gbrr;
            Assert.That(-8L, Is.EqualTo(v.x));
            Assert.That(5L, Is.EqualTo(v.y));
            Assert.That(-5L, Is.EqualTo(v.z));
            Assert.That(-5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(1, 7L, 2L);
            var v = ov.swizzle.gbrg;
            Assert.That(7L, Is.EqualTo(v.x));
            Assert.That(2L, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(7L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(3L, 3L, -1L);
            var v = ov.swizzle.gbrb;
            Assert.That(3L, Is.EqualTo(v.x));
            Assert.That(-1L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
            Assert.That(-1L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, 3L, 1);
            var v = ov.swizzle.gbg;
            Assert.That(3L, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(9L, -5L, -8L);
            var v = ov.swizzle.gbgr;
            Assert.That(-5L, Is.EqualTo(v.x));
            Assert.That(-8L, Is.EqualTo(v.y));
            Assert.That(-5L, Is.EqualTo(v.z));
            Assert.That(9L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(9L, 1, 8L);
            var v = ov.swizzle.gbgg;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(8L, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, 6L, 2L);
            var v = ov.swizzle.gbgb;
            Assert.That(6L, Is.EqualTo(v.x));
            Assert.That(2L, Is.EqualTo(v.y));
            Assert.That(6L, Is.EqualTo(v.z));
            Assert.That(2L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(2L, 9L, 9L);
            var v = ov.swizzle.gbb;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(0, -2L, -2L);
            var v = ov.swizzle.gbbr;
            Assert.That(-2L, Is.EqualTo(v.x));
            Assert.That(-2L, Is.EqualTo(v.y));
            Assert.That(-2L, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-6L, -4L, 5L);
            var v = ov.swizzle.gbbg;
            Assert.That(-4L, Is.EqualTo(v.x));
            Assert.That(5L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
            Assert.That(-4L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-2L, -7L, -1L);
            var v = ov.swizzle.gbbb;
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(-1L, Is.EqualTo(v.y));
            Assert.That(-1L, Is.EqualTo(v.z));
            Assert.That(-1L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(3L, -3L, -2L);
            var v = ov.swizzle.br;
            Assert.That(-2L, Is.EqualTo(v.x));
            Assert.That(3L, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(-6L, -8L, 0);
            var v = ov.swizzle.brr;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-6L, Is.EqualTo(v.y));
            Assert.That(-6L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-4L, 0, 9L);
            var v = ov.swizzle.brrr;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(-4L, Is.EqualTo(v.y));
            Assert.That(-4L, Is.EqualTo(v.z));
            Assert.That(-4L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, -6L, -9L);
            var v = ov.swizzle.brrg;
            Assert.That(-9L, Is.EqualTo(v.x));
            Assert.That(7L, Is.EqualTo(v.y));
            Assert.That(7L, Is.EqualTo(v.z));
            Assert.That(-6L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(3L, 9L, 5L);
            var v = ov.swizzle.brrb;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(3L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-6L, -5L, 7L);
            var v = ov.swizzle.brg;
            Assert.That(7L, Is.EqualTo(v.x));
            Assert.That(-6L, Is.EqualTo(v.y));
            Assert.That(-5L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-4L, -6L, 2L);
            var v = ov.swizzle.brgr;
            Assert.That(2L, Is.EqualTo(v.x));
            Assert.That(-4L, Is.EqualTo(v.y));
            Assert.That(-6L, Is.EqualTo(v.z));
            Assert.That(-4L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-1L, -3L, 7L);
            var v = ov.swizzle.brgg;
            Assert.That(7L, Is.EqualTo(v.x));
            Assert.That(-1L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
            Assert.That(-3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-5L, 0, -6L);
            var v = ov.swizzle.brgb;
            Assert.That(-6L, Is.EqualTo(v.x));
            Assert.That(-5L, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-6L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-1L, 6L, 9L);
            var v = ov.swizzle.brb;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(-1L, Is.EqualTo(v.y));
            Assert.That(9L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(5L, -5L, 6L);
            var v = ov.swizzle.brbr;
            Assert.That(6L, Is.EqualTo(v.x));
            Assert.That(5L, Is.EqualTo(v.y));
            Assert.That(6L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(9L, 5L, 2L);
            var v = ov.swizzle.brbg;
            Assert.That(2L, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(2L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(6L, -4L, 2L);
            var v = ov.swizzle.brbb;
            Assert.That(2L, Is.EqualTo(v.x));
            Assert.That(6L, Is.EqualTo(v.y));
            Assert.That(2L, Is.EqualTo(v.z));
            Assert.That(2L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(7L, 0, 5L);
            var v = ov.swizzle.bg;
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(-3L, -4L, -4L);
            var v = ov.swizzle.bgr;
            Assert.That(-4L, Is.EqualTo(v.x));
            Assert.That(-4L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-1L, -7L, 1);
            var v = ov.swizzle.bgrr;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(-1L, Is.EqualTo(v.z));
            Assert.That(-1L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(5L, -9L, -8L);
            var v = ov.swizzle.bgrg;
            Assert.That(-8L, Is.EqualTo(v.x));
            Assert.That(-9L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
            Assert.That(-9L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-8L, -8L, 0);
            var v = ov.swizzle.bgrb;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-8L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(8L, -3L, -9L);
            var v = ov.swizzle.bgg;
            Assert.That(-9L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(3L, 0, -7L);
            var v = ov.swizzle.bggr;
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(4L, 3L, -3L);
            var v = ov.swizzle.bggg;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(3L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
            Assert.That(3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(0, 2L, 0);
            var v = ov.swizzle.bggb;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(2L, Is.EqualTo(v.y));
            Assert.That(2L, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-3L, -4L, 3L);
            var v = ov.swizzle.bgb;
            Assert.That(3L, Is.EqualTo(v.x));
            Assert.That(-4L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(2L, 9L, 1);
            var v = ov.swizzle.bgbr;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(2L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(5L, 5L, -6L);
            var v = ov.swizzle.bgbg;
            Assert.That(-6L, Is.EqualTo(v.x));
            Assert.That(5L, Is.EqualTo(v.y));
            Assert.That(-6L, Is.EqualTo(v.z));
            Assert.That(5L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-6L, -8L, -8L);
            var v = ov.swizzle.bgbb;
            Assert.That(-8L, Is.EqualTo(v.x));
            Assert.That(-8L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(-8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-4L, 4L, 3L);
            var v = ov.swizzle.bb;
            Assert.That(3L, Is.EqualTo(v.x));
            Assert.That(3L, Is.EqualTo(v.y));
        }
        {
            var ov = new lvec3(-4L, 4L, 6L);
            var v = ov.swizzle.bbr;
            Assert.That(6L, Is.EqualTo(v.x));
            Assert.That(6L, Is.EqualTo(v.y));
            Assert.That(-4L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-1L, 6L, -7L);
            var v = ov.swizzle.bbrr;
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(-1L, Is.EqualTo(v.z));
            Assert.That(-1L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(5L, 0, -3L);
            var v = ov.swizzle.bbrg;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(2L, 2L, -3L);
            var v = ov.swizzle.bbrb;
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(2L, Is.EqualTo(v.z));
            Assert.That(-3L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(4L, 3L, -7L);
            var v = ov.swizzle.bbg;
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(-2L, -2L, -2L);
            var v = ov.swizzle.bbgr;
            Assert.That(-2L, Is.EqualTo(v.x));
            Assert.That(-2L, Is.EqualTo(v.y));
            Assert.That(-2L, Is.EqualTo(v.z));
            Assert.That(-2L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-3L, -8L, 2L);
            var v = ov.swizzle.bbgg;
            Assert.That(2L, Is.EqualTo(v.x));
            Assert.That(2L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(-8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-7L, 3L, 9L);
            var v = ov.swizzle.bbgb;
            Assert.That(9L, Is.EqualTo(v.x));
            Assert.That(9L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
            Assert.That(9L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-6L, -3L, -2L);
            var v = ov.swizzle.bbb;
            Assert.That(-2L, Is.EqualTo(v.x));
            Assert.That(-2L, Is.EqualTo(v.y));
            Assert.That(-2L, Is.EqualTo(v.z));
        }
        {
            var ov = new lvec3(4L, -3L, -4L);
            var v = ov.swizzle.bbbr;
            Assert.That(-4L, Is.EqualTo(v.x));
            Assert.That(-4L, Is.EqualTo(v.y));
            Assert.That(-4L, Is.EqualTo(v.z));
            Assert.That(4L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(1, 8L, -6L);
            var v = ov.swizzle.bbbg;
            Assert.That(-6L, Is.EqualTo(v.x));
            Assert.That(-6L, Is.EqualTo(v.y));
            Assert.That(-6L, Is.EqualTo(v.z));
            Assert.That(8L, Is.EqualTo(v.w));
        }
        {
            var ov = new lvec3(-3L, -1L, -8L);
            var v = ov.swizzle.bbbb;
            Assert.That(-8L, Is.EqualTo(v.x));
            Assert.That(-8L, Is.EqualTo(v.y));
            Assert.That(-8L, Is.EqualTo(v.z));
            Assert.That(-8L, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new lvec3(3L, -2L, 4L);
            var v1 = new lvec2(-7L, 6L);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-7L, Is.EqualTo(v0.x));
            Assert.That(6L, Is.EqualTo(v0.y));
            Assert.That(4L, Is.EqualTo(v0.z));
        
            Assert.That(3L, Is.EqualTo(v2.x));
            Assert.That(-2L, Is.EqualTo(v2.y));
        }
        {
            var v0 = new lvec3(9L, 6L, -5L);
            var v1 = new lvec2(6L, -6L);
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(6L, Is.EqualTo(v0.x));
            Assert.That(6L, Is.EqualTo(v0.y));
            Assert.That(-6L, Is.EqualTo(v0.z));
        
            Assert.That(9L, Is.EqualTo(v2.x));
            Assert.That(-5L, Is.EqualTo(v2.y));
        }
        {
            var v0 = new lvec3(3L, -7L, -1L);
            var v1 = new lvec2(-3L, -2L);
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(3L, Is.EqualTo(v0.x));
            Assert.That(-3L, Is.EqualTo(v0.y));
            Assert.That(-2L, Is.EqualTo(v0.z));
        
            Assert.That(-7L, Is.EqualTo(v2.x));
            Assert.That(-1L, Is.EqualTo(v2.y));
        }
        {
            var v0 = new lvec3(-5L, -4L, 7L);
            var v1 = new lvec3(-9L, 1, 4L);
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-9L, Is.EqualTo(v0.x));
            Assert.That(1, Is.EqualTo(v0.y));
            Assert.That(4L, Is.EqualTo(v0.z));
        
            Assert.That(-5L, Is.EqualTo(v2.x));
            Assert.That(-4L, Is.EqualTo(v2.y));
            Assert.That(7L, Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            lvec3 v0 = new lvec3(9L, -4L, -9L);
            long v1 = -8L;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-8L, Is.EqualTo(v0.x));
            Assert.That(-4L, Is.EqualTo(v0.y));
            Assert.That(-9L, Is.EqualTo(v0.z));
        
            Assert.That(9L, Is.EqualTo(v2));
        }
        {
            lvec3 v0 = new lvec3(-6L, 7L, -9L);
            long v1 = 9L;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-6L, Is.EqualTo(v0.x));
            Assert.That(9L, Is.EqualTo(v0.y));
            Assert.That(-9L, Is.EqualTo(v0.z));
        
            Assert.That(7L, Is.EqualTo(v2));
        }
        {
            lvec3 v0 = new lvec3(-3L, -2L, 2L);
            lvec2 v1 = new lvec2(-8L, 5L);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-8L, Is.EqualTo(v0.x));
            Assert.That(5L, Is.EqualTo(v0.y));
            Assert.That(2L, Is.EqualTo(v0.z));
        
            Assert.That(-3L, Is.EqualTo(v2.x));
            Assert.That(-2L, Is.EqualTo(v2.y));
        }
        {
            lvec3 v0 = new lvec3(7L, 7L, 8L);
            long v1 = 8L;
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(7L, Is.EqualTo(v0.x));
            Assert.That(7L, Is.EqualTo(v0.y));
            Assert.That(8L, Is.EqualTo(v0.z));
        
            Assert.That(8L, Is.EqualTo(v2));
        }
        {
            lvec3 v0 = new lvec3(-6L, -2L, -6L);
            lvec2 v1 = new lvec2(-9L, -4L);
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-9L, Is.EqualTo(v0.x));
            Assert.That(-2L, Is.EqualTo(v0.y));
            Assert.That(-4L, Is.EqualTo(v0.z));
        
            Assert.That(-6L, Is.EqualTo(v2.x));
            Assert.That(-6L, Is.EqualTo(v2.y));
        }
        {
            lvec3 v0 = new lvec3(9L, -3L, -5L);
            lvec2 v1 = new lvec2(5L, -2L);
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(9L, Is.EqualTo(v0.x));
            Assert.That(5L, Is.EqualTo(v0.y));
            Assert.That(-2L, Is.EqualTo(v0.z));
        
            Assert.That(-3L, Is.EqualTo(v2.x));
            Assert.That(-5L, Is.EqualTo(v2.y));
        }
        {
            lvec3 v0 = new lvec3(3L, 3L, -7L);
            lvec3 v1 = new lvec3(-7L, 5L, -5L);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-7L, Is.EqualTo(v0.x));
            Assert.That(5L, Is.EqualTo(v0.y));
            Assert.That(-5L, Is.EqualTo(v0.z));
        
            Assert.That(3L, Is.EqualTo(v2.x));
            Assert.That(3L, Is.EqualTo(v2.y));
            Assert.That(-7L, Is.EqualTo(v2.z));
        }
    }

}
