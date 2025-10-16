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
public class IntSwizzleVec3Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new ivec3(-7, -8, 7);
            var v = ov.swizzle.xx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(-6, 7, -4);
            var v = ov.swizzle.xxx;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(6, -6, -2);
            var v = ov.swizzle.xxxx;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(6, -7, -2);
            var v = ov.swizzle.xxxy;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(1, -1, -1);
            var v = ov.swizzle.xxxz;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(9, -9, 5);
            var v = ov.swizzle.xxy;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-4, -7, -3);
            var v = ov.swizzle.xxyx;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(9, 6, 9);
            var v = ov.swizzle.xxyy;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-9, 0, -7);
            var v = ov.swizzle.xxyz;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-7, -4, -8);
            var v = ov.swizzle.xxz;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(7, 3, 1);
            var v = ov.swizzle.xxzx;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-2, -9, -6);
            var v = ov.swizzle.xxzy;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(1, 9, 8);
            var v = ov.swizzle.xxzz;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-7, -6, -6);
            var v = ov.swizzle.xy;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(5, -3, 8);
            var v = ov.swizzle.xyx;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-7, 8, 0);
            var v = ov.swizzle.xyxx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-9, 7, -5);
            var v = ov.swizzle.xyxy;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, 2, 1);
            var v = ov.swizzle.xyxz;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-1, 6, -1);
            var v = ov.swizzle.xyy;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-7, -7, 6);
            var v = ov.swizzle.xyyx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-7, 9, 2);
            var v = ov.swizzle.xyyy;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-4, -9, -4);
            var v = ov.swizzle.xyyz;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-1, 9, -2);
            var v = ov.swizzle.xyz;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-5, 7, 8);
            var v = ov.swizzle.xyzx;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-6, -7, 0);
            var v = ov.swizzle.xyzy;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-7, 3, -3);
            var v = ov.swizzle.xyzz;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, 1, -2);
            var v = ov.swizzle.xz;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(-6, -7, 5);
            var v = ov.swizzle.xzx;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(3, 7, 1);
            var v = ov.swizzle.xzxx;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-9, 1, -2);
            var v = ov.swizzle.xzxy;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(4, 3, -3);
            var v = ov.swizzle.xzxz;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(2, 0, 6);
            var v = ov.swizzle.xzy;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-4, -2, -4);
            var v = ov.swizzle.xzyx;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-5, 6, -9);
            var v = ov.swizzle.xzyy;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(8, 4, 0);
            var v = ov.swizzle.xzyz;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(5, 3, 4);
            var v = ov.swizzle.xzz;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(1, -4, 3);
            var v = ov.swizzle.xzzx;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-8, -7, -5);
            var v = ov.swizzle.xzzy;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-5, 0, -2);
            var v = ov.swizzle.xzzz;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-6, -1, -2);
            var v = ov.swizzle.yx;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(-3, -1, 7);
            var v = ov.swizzle.yxx;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-9, 9, 4);
            var v = ov.swizzle.yxxx;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-6, -4, -6);
            var v = ov.swizzle.yxxy;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-3, 2, -2);
            var v = ov.swizzle.yxxz;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-9, 5, -5);
            var v = ov.swizzle.yxy;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-2, 7, -3);
            var v = ov.swizzle.yxyx;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(5, -7, 3);
            var v = ov.swizzle.yxyy;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-6, -8, 7);
            var v = ov.swizzle.yxyz;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(8, 6, 6);
            var v = ov.swizzle.yxz;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-7, 6, 0);
            var v = ov.swizzle.yxzx;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-5, -7, 1);
            var v = ov.swizzle.yxzy;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(2, 2, -5);
            var v = ov.swizzle.yxzz;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-1, 8, -4);
            var v = ov.swizzle.yy;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(-5, 8, 9);
            var v = ov.swizzle.yyx;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(8, 7, -1);
            var v = ov.swizzle.yyxx;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-1, -8, -2);
            var v = ov.swizzle.yyxy;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, 3, -3);
            var v = ov.swizzle.yyxz;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-9, -1, -3);
            var v = ov.swizzle.yyy;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(7, -7, -2);
            var v = ov.swizzle.yyyx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, -1, 3);
            var v = ov.swizzle.yyyy;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-8, -8, 6);
            var v = ov.swizzle.yyyz;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-6, -8, 5);
            var v = ov.swizzle.yyz;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-1, -6, 2);
            var v = ov.swizzle.yyzx;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-9, 0, -8);
            var v = ov.swizzle.yyzy;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-8, 9, 7);
            var v = ov.swizzle.yyzz;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-4, 6, -1);
            var v = ov.swizzle.yz;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(-7, -7, 7);
            var v = ov.swizzle.yzx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-5, -7, 3);
            var v = ov.swizzle.yzxx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(6, -5, 6);
            var v = ov.swizzle.yzxy;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(7, -4, 5);
            var v = ov.swizzle.yzxz;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(2, -1, -8);
            var v = ov.swizzle.yzy;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-1, -7, -1);
            var v = ov.swizzle.yzyx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(2, -2, 9);
            var v = ov.swizzle.yzyy;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(4, 0, 2);
            var v = ov.swizzle.yzyz;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(8, 0, 2);
            var v = ov.swizzle.yzz;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-4, 0, 0);
            var v = ov.swizzle.yzzx;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(4, -4, 9);
            var v = ov.swizzle.yzzy;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(1, 3, -3);
            var v = ov.swizzle.yzzz;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-5, 2, 0);
            var v = ov.swizzle.zx;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(3, 8, 2);
            var v = ov.swizzle.zxx;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-9, 2, 2);
            var v = ov.swizzle.zxxx;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-7, -7, 9);
            var v = ov.swizzle.zxxy;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, 7, -3);
            var v = ov.swizzle.zxxz;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-7, -2, -5);
            var v = ov.swizzle.zxy;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(1, -2, -7);
            var v = ov.swizzle.zxyx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(5, 5, -7);
            var v = ov.swizzle.zxyy;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, -3, -5);
            var v = ov.swizzle.zxyz;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(5, 3, 0);
            var v = ov.swizzle.zxz;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-6, 1, 6);
            var v = ov.swizzle.zxzx;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(5, -5, -4);
            var v = ov.swizzle.zxzy;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(9, -8, 2);
            var v = ov.swizzle.zxzz;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(6, 5, -7);
            var v = ov.swizzle.zy;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(0, -2, 3);
            var v = ov.swizzle.zyx;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-3, -4, -2);
            var v = ov.swizzle.zyxx;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(7, 6, 2);
            var v = ov.swizzle.zyxy;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-4, 0, -2);
            var v = ov.swizzle.zyxz;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-5, 9, -7);
            var v = ov.swizzle.zyy;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(3, 2, -6);
            var v = ov.swizzle.zyyx;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(6, -3, -8);
            var v = ov.swizzle.zyyy;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(1, 1, -6);
            var v = ov.swizzle.zyyz;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(2, -4, -3);
            var v = ov.swizzle.zyz;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-8, 6, -3);
            var v = ov.swizzle.zyzx;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-3, -4, 6);
            var v = ov.swizzle.zyzy;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, 5, -4);
            var v = ov.swizzle.zyzz;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-4, 7, -8);
            var v = ov.swizzle.zz;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(3, -8, -6);
            var v = ov.swizzle.zzx;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-7, 1, 0);
            var v = ov.swizzle.zzxx;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-5, 9, 5);
            var v = ov.swizzle.zzxy;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-7, 6, -5);
            var v = ov.swizzle.zzxz;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(5, -9, -2);
            var v = ov.swizzle.zzy;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-8, -8, -1);
            var v = ov.swizzle.zzyx;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(6, 9, -9);
            var v = ov.swizzle.zzyy;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-9, 8, 0);
            var v = ov.swizzle.zzyz;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(8, 1, 5);
            var v = ov.swizzle.zzz;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(4, -5, 4);
            var v = ov.swizzle.zzzx;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(3, 8, -5);
            var v = ov.swizzle.zzzy;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-7, 3, -5);
            var v = ov.swizzle.zzzz;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new ivec3(5, -3, -9);
            var v = ov.swizzle.rr;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(9, -9, -9);
            var v = ov.swizzle.rrr;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-5, 6, 6);
            var v = ov.swizzle.rrrr;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(5, 4, 1);
            var v = ov.swizzle.rrrg;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, 8, -3);
            var v = ov.swizzle.rrrb;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-4, -3, 6);
            var v = ov.swizzle.rrg;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-9, 4, 2);
            var v = ov.swizzle.rrgr;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-7, -5, 2);
            var v = ov.swizzle.rrgg;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(2, -1, 1);
            var v = ov.swizzle.rrgb;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-8, 4, -6);
            var v = ov.swizzle.rrb;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-7, -9, 1);
            var v = ov.swizzle.rrbr;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-3, 2, 1);
            var v = ov.swizzle.rrbg;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-2, 6, -6);
            var v = ov.swizzle.rrbb;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(1, 3, -3);
            var v = ov.swizzle.rg;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(7, 3, -7);
            var v = ov.swizzle.rgr;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-2, 8, 6);
            var v = ov.swizzle.rgrr;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(6, 7, 4);
            var v = ov.swizzle.rgrg;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(1, 8, 2);
            var v = ov.swizzle.rgrb;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-8, 8, -8);
            var v = ov.swizzle.rgg;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-7, 7, 8);
            var v = ov.swizzle.rggr;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-8, -6, 1);
            var v = ov.swizzle.rggg;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-1, 7, 5);
            var v = ov.swizzle.rggb;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-9, 7, 6);
            var v = ov.swizzle.rgb;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-2, 2, 5);
            var v = ov.swizzle.rgbr;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-1, -8, 1);
            var v = ov.swizzle.rgbg;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(9, 9, -2);
            var v = ov.swizzle.rgbb;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(5, -1, 2);
            var v = ov.swizzle.rb;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(-5, -1, -7);
            var v = ov.swizzle.rbr;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-1, -5, -1);
            var v = ov.swizzle.rbrr;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-9, -4, -4);
            var v = ov.swizzle.rbrg;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(3, -5, -9);
            var v = ov.swizzle.rbrb;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(6, 3, 6);
            var v = ov.swizzle.rbg;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-1, -6, -5);
            var v = ov.swizzle.rbgr;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-1, -3, 0);
            var v = ov.swizzle.rbgg;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, -5, 4);
            var v = ov.swizzle.rbgb;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-9, -1, 9);
            var v = ov.swizzle.rbb;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(1, 8, -8);
            var v = ov.swizzle.rbbr;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(5, -1, -6);
            var v = ov.swizzle.rbbg;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(6, 2, 5);
            var v = ov.swizzle.rbbb;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(3, -9, -3);
            var v = ov.swizzle.gr;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(-5, 0, -4);
            var v = ov.swizzle.grr;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-2, 7, 7);
            var v = ov.swizzle.grrr;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(6, 3, -5);
            var v = ov.swizzle.grrg;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-5, -8, -3);
            var v = ov.swizzle.grrb;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-6, -4, -8);
            var v = ov.swizzle.grg;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(1, -4, -6);
            var v = ov.swizzle.grgr;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-2, -1, 4);
            var v = ov.swizzle.grgg;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, -7, 4);
            var v = ov.swizzle.grgb;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-5, -7, 3);
            var v = ov.swizzle.grb;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(2, 0, 0);
            var v = ov.swizzle.grbr;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, 7, -7);
            var v = ov.swizzle.grbg;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(2, -6, -2);
            var v = ov.swizzle.grbb;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(6, 8, 6);
            var v = ov.swizzle.gg;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(-7, -3, 6);
            var v = ov.swizzle.ggr;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-5, 5, -1);
            var v = ov.swizzle.ggrr;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(5, 8, -7);
            var v = ov.swizzle.ggrg;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-8, 4, 8);
            var v = ov.swizzle.ggrb;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(9, -1, 7);
            var v = ov.swizzle.ggg;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(7, -4, 2);
            var v = ov.swizzle.gggr;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(8, -6, 9);
            var v = ov.swizzle.gggg;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(3, 3, 2);
            var v = ov.swizzle.gggb;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-4, -4, 9);
            var v = ov.swizzle.ggb;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-6, -4, -7);
            var v = ov.swizzle.ggbr;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(5, -4, 5);
            var v = ov.swizzle.ggbg;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(8, -5, -8);
            var v = ov.swizzle.ggbb;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-8, 5, -1);
            var v = ov.swizzle.gb;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(-4, 9, 7);
            var v = ov.swizzle.gbr;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(5, 4, -5);
            var v = ov.swizzle.gbrr;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-2, -1, -6);
            var v = ov.swizzle.gbrg;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(8, -4, 1);
            var v = ov.swizzle.gbrb;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(9, -7, -2);
            var v = ov.swizzle.gbg;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-6, -4, 9);
            var v = ov.swizzle.gbgr;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(3, 0, -2);
            var v = ov.swizzle.gbgg;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, 9, -4);
            var v = ov.swizzle.gbgb;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-9, -2, -1);
            var v = ov.swizzle.gbb;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(2, 0, -6);
            var v = ov.swizzle.gbbr;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(9, 9, 8);
            var v = ov.swizzle.gbbg;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-1, -5, 5);
            var v = ov.swizzle.gbbb;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(1, -7, -8);
            var v = ov.swizzle.br;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(7, 2, 2);
            var v = ov.swizzle.brr;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-4, 7, 0);
            var v = ov.swizzle.brrr;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-6, -5, -6);
            var v = ov.swizzle.brrg;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-3, -2, 1);
            var v = ov.swizzle.brrb;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(8, -4, 4);
            var v = ov.swizzle.brg;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-9, -3, 0);
            var v = ov.swizzle.brgr;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-4, 6, -3);
            var v = ov.swizzle.brgg;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(4, 9, -1);
            var v = ov.swizzle.brgb;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, -8, 4);
            var v = ov.swizzle.brb;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-2, -9, 2);
            var v = ov.swizzle.brbr;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(6, -4, -6);
            var v = ov.swizzle.brbg;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-2, -6, -8);
            var v = ov.swizzle.brbb;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(9, 6, 1);
            var v = ov.swizzle.bg;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(-4, 3, -6);
            var v = ov.swizzle.bgr;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-4, 8, 8);
            var v = ov.swizzle.bgrr;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-5, 1, -5);
            var v = ov.swizzle.bgrg;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(4, -1, 1);
            var v = ov.swizzle.bgrb;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(5, 7, -1);
            var v = ov.swizzle.bgg;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(4, 2, -3);
            var v = ov.swizzle.bggr;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-2, -4, 8);
            var v = ov.swizzle.bggg;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-6, 3, -6);
            var v = ov.swizzle.bggb;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-4, 6, -7);
            var v = ov.swizzle.bgb;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(4, -7, -8);
            var v = ov.swizzle.bgbr;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(6, 9, 6);
            var v = ov.swizzle.bgbg;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-8, -9, 2);
            var v = ov.swizzle.bgbb;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-6, -1, 0);
            var v = ov.swizzle.bb;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec3(2, 4, -7);
            var v = ov.swizzle.bbr;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(8, 7, 7);
            var v = ov.swizzle.bbrr;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, 0, 5);
            var v = ov.swizzle.bbrg;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(4, 6, -3);
            var v = ov.swizzle.bbrb;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(4, -8, -2);
            var v = ov.swizzle.bbg;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-3, -8, 0);
            var v = ov.swizzle.bbgr;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(0, -9, 2);
            var v = ov.swizzle.bbgg;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-1, 9, 4);
            var v = ov.swizzle.bbgb;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-7, -7, 1);
            var v = ov.swizzle.bbb;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec3(-4, 6, 8);
            var v = ov.swizzle.bbbr;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(7, 8, -2);
            var v = ov.swizzle.bbbg;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec3(-3, 8, 8);
            var v = ov.swizzle.bbbb;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new ivec3(2, -9, 4);
            var v1 = new ivec2(-9, 9);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-9, Is.EqualTo(v0.x));
            Assert.That(9, Is.EqualTo(v0.y));
            Assert.That(4, Is.EqualTo(v0.z));
        
            Assert.That(2, Is.EqualTo(v2.x));
            Assert.That(-9, Is.EqualTo(v2.y));
        }
        {
            var v0 = new ivec3(3, 0, -2);
            var v1 = new ivec2(1, -5);
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(1, Is.EqualTo(v0.x));
            Assert.That(0, Is.EqualTo(v0.y));
            Assert.That(-5, Is.EqualTo(v0.z));
        
            Assert.That(3, Is.EqualTo(v2.x));
            Assert.That(-2, Is.EqualTo(v2.y));
        }
        {
            var v0 = new ivec3(-8, 6, -6);
            var v1 = new ivec2(-6, -7);
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-8, Is.EqualTo(v0.x));
            Assert.That(-6, Is.EqualTo(v0.y));
            Assert.That(-7, Is.EqualTo(v0.z));
        
            Assert.That(6, Is.EqualTo(v2.x));
            Assert.That(-6, Is.EqualTo(v2.y));
        }
        {
            var v0 = new ivec3(1, -8, 9);
            var v1 = new ivec3(2, -1, -3);
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(2, Is.EqualTo(v0.x));
            Assert.That(-1, Is.EqualTo(v0.y));
            Assert.That(-3, Is.EqualTo(v0.z));
        
            Assert.That(1, Is.EqualTo(v2.x));
            Assert.That(-8, Is.EqualTo(v2.y));
            Assert.That(9, Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            ivec3 v0 = new ivec3(2, -1, 0);
            int v1 = -7;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-7, Is.EqualTo(v0.x));
            Assert.That(-1, Is.EqualTo(v0.y));
            Assert.That(0, Is.EqualTo(v0.z));
        
            Assert.That(2, Is.EqualTo(v2));
        }
        {
            ivec3 v0 = new ivec3(0, -7, 4);
            int v1 = -8;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(0, Is.EqualTo(v0.x));
            Assert.That(-8, Is.EqualTo(v0.y));
            Assert.That(4, Is.EqualTo(v0.z));
        
            Assert.That(-7, Is.EqualTo(v2));
        }
        {
            ivec3 v0 = new ivec3(1, -2, 7);
            ivec2 v1 = new ivec2(5, 4);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(5, Is.EqualTo(v0.x));
            Assert.That(4, Is.EqualTo(v0.y));
            Assert.That(7, Is.EqualTo(v0.z));
        
            Assert.That(1, Is.EqualTo(v2.x));
            Assert.That(-2, Is.EqualTo(v2.y));
        }
        {
            ivec3 v0 = new ivec3(1, 8, 2);
            int v1 = 3;
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(1, Is.EqualTo(v0.x));
            Assert.That(8, Is.EqualTo(v0.y));
            Assert.That(3, Is.EqualTo(v0.z));
        
            Assert.That(2, Is.EqualTo(v2));
        }
        {
            ivec3 v0 = new ivec3(9, 0, -1);
            ivec2 v1 = new ivec2(-3, 9);
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-3, Is.EqualTo(v0.x));
            Assert.That(0, Is.EqualTo(v0.y));
            Assert.That(9, Is.EqualTo(v0.z));
        
            Assert.That(9, Is.EqualTo(v2.x));
            Assert.That(-1, Is.EqualTo(v2.y));
        }
        {
            ivec3 v0 = new ivec3(7, 4, 2);
            ivec2 v1 = new ivec2(-8, -2);
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(7, Is.EqualTo(v0.x));
            Assert.That(-8, Is.EqualTo(v0.y));
            Assert.That(-2, Is.EqualTo(v0.z));
        
            Assert.That(4, Is.EqualTo(v2.x));
            Assert.That(2, Is.EqualTo(v2.y));
        }
        {
            ivec3 v0 = new ivec3(3, -2, -9);
            ivec3 v1 = new ivec3(-2, -3, 4);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-2, Is.EqualTo(v0.x));
            Assert.That(-3, Is.EqualTo(v0.y));
            Assert.That(4, Is.EqualTo(v0.z));
        
            Assert.That(3, Is.EqualTo(v2.x));
            Assert.That(-2, Is.EqualTo(v2.y));
            Assert.That(-9, Is.EqualTo(v2.z));
        }
    }

}
