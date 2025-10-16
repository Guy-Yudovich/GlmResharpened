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
public class IntSwizzleVec4Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new ivec4(6, 7, 5, 9);
            var v = ov.swizzle.xx;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(-9, 7, 9, -6);
            var v = ov.swizzle.xxx;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-6, -9, 7, 3);
            var v = ov.swizzle.xxxx;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, 1, 3, -8);
            var v = ov.swizzle.xxxy;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, 0, -4, -6);
            var v = ov.swizzle.xxxz;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 7, 9, 4);
            var v = ov.swizzle.xxxw;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, -3, -4, -5);
            var v = ov.swizzle.xxy;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(9, -5, 6, 4);
            var v = ov.swizzle.xxyx;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, -6, -6, -8);
            var v = ov.swizzle.xxyy;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, -2, -7, 5);
            var v = ov.swizzle.xxyz;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -6, -7, -4);
            var v = ov.swizzle.xxyw;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, -4, 2, -9);
            var v = ov.swizzle.xxz;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(6, 3, -8, 1);
            var v = ov.swizzle.xxzx;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, -2, 6, -8);
            var v = ov.swizzle.xxzy;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 1, -3, 5);
            var v = ov.swizzle.xxzz;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -4, 5, 0);
            var v = ov.swizzle.xxzw;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 2, 1, 4);
            var v = ov.swizzle.xxw;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(4, 5, -9, 4);
            var v = ov.swizzle.xxwx;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, 7, -8, 1);
            var v = ov.swizzle.xxwy;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, -6, 2, 2);
            var v = ov.swizzle.xxwz;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, -5, 8, 6);
            var v = ov.swizzle.xxww;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 5, -4, -1);
            var v = ov.swizzle.xy;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(8, -8, -9, -8);
            var v = ov.swizzle.xyx;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-8, -2, -2, 3);
            var v = ov.swizzle.xyxx;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, -7, 1, -9);
            var v = ov.swizzle.xyxy;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, -8, -4, 0);
            var v = ov.swizzle.xyxz;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, -3, -9, 2);
            var v = ov.swizzle.xyxw;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 4, 8, 2);
            var v = ov.swizzle.xyy;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-8, -1, -5, -9);
            var v = ov.swizzle.xyyx;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, -8, 3, 7);
            var v = ov.swizzle.xyyy;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 9, -5, 6);
            var v = ov.swizzle.xyyz;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 0, 6, -1);
            var v = ov.swizzle.xyyw;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, -5, 9, -3);
            var v = ov.swizzle.xyz;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-5, 2, 8, -2);
            var v = ov.swizzle.xyzx;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, 8, 2, 3);
            var v = ov.swizzle.xyzy;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, -2, -7, 4);
            var v = ov.swizzle.xyzz;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, -7, -9, 6);
            var v = ov.swizzle.xyzw;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, -3, -8, -3);
            var v = ov.swizzle.xyw;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-3, -3, -1, 2);
            var v = ov.swizzle.xywx;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, 7, -4, 3);
            var v = ov.swizzle.xywy;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, 8, 6, -7);
            var v = ov.swizzle.xywz;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -6, 7, -5);
            var v = ov.swizzle.xyww;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, 3, -8, -6);
            var v = ov.swizzle.xz;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(-6, 0, 1, -6);
            var v = ov.swizzle.xzx;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-2, 9, -7, 8);
            var v = ov.swizzle.xzxx;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, -9, -4, 2);
            var v = ov.swizzle.xzxy;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -7, 0, 1);
            var v = ov.swizzle.xzxz;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, 5, 7, -3);
            var v = ov.swizzle.xzxw;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -9, -6, -7);
            var v = ov.swizzle.xzy;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(5, 0, 8, -3);
            var v = ov.swizzle.xzyx;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, 3, 4, -3);
            var v = ov.swizzle.xzyy;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 1, -7, -2);
            var v = ov.swizzle.xzyz;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -5, 9, -3);
            var v = ov.swizzle.xzyw;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, 5, 1, 7);
            var v = ov.swizzle.xzz;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-4, 3, -9, -8);
            var v = ov.swizzle.xzzx;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 5, 3, -6);
            var v = ov.swizzle.xzzy;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 4, 1, -6);
            var v = ov.swizzle.xzzz;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 3, 9, -2);
            var v = ov.swizzle.xzzw;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 4, -8, -8);
            var v = ov.swizzle.xzw;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-5, 1, 7, -5);
            var v = ov.swizzle.xzwx;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, 7, 9, -7);
            var v = ov.swizzle.xzwy;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -4, 3, 8);
            var v = ov.swizzle.xzwz;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, 8, 3, 2);
            var v = ov.swizzle.xzww;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -1, -7, 3);
            var v = ov.swizzle.xw;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(0, 8, -7, 9);
            var v = ov.swizzle.xwx;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(0, 0, 7, 7);
            var v = ov.swizzle.xwxx;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, -8, -2, 4);
            var v = ov.swizzle.xwxy;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, 3, -3, -3);
            var v = ov.swizzle.xwxz;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 4, -8, 7);
            var v = ov.swizzle.xwxw;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 5, 0, 0);
            var v = ov.swizzle.xwy;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(1, -3, -9, -5);
            var v = ov.swizzle.xwyx;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, 7, -1, 9);
            var v = ov.swizzle.xwyy;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, -5, -7, 5);
            var v = ov.swizzle.xwyz;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, -7, -5, -9);
            var v = ov.swizzle.xwyw;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, 1, -3, -7);
            var v = ov.swizzle.xwz;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(2, -8, 2, -3);
            var v = ov.swizzle.xwzx;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 9, 6, -6);
            var v = ov.swizzle.xwzy;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, 8, 6, -4);
            var v = ov.swizzle.xwzz;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, -7, 8, 7);
            var v = ov.swizzle.xwzw;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -3, 6, -6);
            var v = ov.swizzle.xww;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(7, 1, -8, -2);
            var v = ov.swizzle.xwwx;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 6, 8, -7);
            var v = ov.swizzle.xwwy;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, -8, 7, -4);
            var v = ov.swizzle.xwwz;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 3, -8, 2);
            var v = ov.swizzle.xwww;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, 5, -8, 9);
            var v = ov.swizzle.yx;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(1, -5, -7, -7);
            var v = ov.swizzle.yxx;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(7, 3, -8, 6);
            var v = ov.swizzle.yxxx;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, 7, -8, 6);
            var v = ov.swizzle.yxxy;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -7, 8, 0);
            var v = ov.swizzle.yxxz;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -1, 6, 9);
            var v = ov.swizzle.yxxw;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, 8, 6, -4);
            var v = ov.swizzle.yxy;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(1, -2, 0, 4);
            var v = ov.swizzle.yxyx;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 5, -7, -4);
            var v = ov.swizzle.yxyy;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -6, -4, -3);
            var v = ov.swizzle.yxyz;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, 0, 3, 2);
            var v = ov.swizzle.yxyw;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 2, 8, 1);
            var v = ov.swizzle.yxz;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-9, 0, -9, -6);
            var v = ov.swizzle.yxzx;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -7, 2, -9);
            var v = ov.swizzle.yxzy;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, 8, 9, -3);
            var v = ov.swizzle.yxzz;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 3, -6, -5);
            var v = ov.swizzle.yxzw;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, -4, 7, 2);
            var v = ov.swizzle.yxw;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(9, 4, -3, -8);
            var v = ov.swizzle.yxwx;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, -6, -7, -9);
            var v = ov.swizzle.yxwy;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, 4, 1, -8);
            var v = ov.swizzle.yxwz;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, 5, -4, 0);
            var v = ov.swizzle.yxww;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, 4, 9, 1);
            var v = ov.swizzle.yy;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(3, -8, -5, 4);
            var v = ov.swizzle.yyx;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(6, 0, 4, -9);
            var v = ov.swizzle.yyxx;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 7, 0, -4);
            var v = ov.swizzle.yyxy;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 5, -1, -5);
            var v = ov.swizzle.yyxz;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 1, -3, -7);
            var v = ov.swizzle.yyxw;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, 2, -2, -4);
            var v = ov.swizzle.yyy;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(6, -1, -3, 2);
            var v = ov.swizzle.yyyx;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, -6, 2, -7);
            var v = ov.swizzle.yyyy;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, 6, -9, -2);
            var v = ov.swizzle.yyyz;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, 8, -1, 2);
            var v = ov.swizzle.yyyw;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, -7, -5, -8);
            var v = ov.swizzle.yyz;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(4, 7, 3, -3);
            var v = ov.swizzle.yyzx;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -8, -3, -1);
            var v = ov.swizzle.yyzy;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -3, 1, 0);
            var v = ov.swizzle.yyzz;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 0, -7, -5);
            var v = ov.swizzle.yyzw;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, 2, 9, 7);
            var v = ov.swizzle.yyw;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(5, 2, -1, 7);
            var v = ov.swizzle.yywx;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, -9, 6, -8);
            var v = ov.swizzle.yywy;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, -1, 5, 2);
            var v = ov.swizzle.yywz;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, -3, 9, -9);
            var v = ov.swizzle.yyww;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 0, 7, -2);
            var v = ov.swizzle.yz;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(2, -2, 5, -1);
            var v = ov.swizzle.yzx;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(4, -8, 6, 7);
            var v = ov.swizzle.yzxx;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, -6, -5, 7);
            var v = ov.swizzle.yzxy;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 6, -3, 1);
            var v = ov.swizzle.yzxz;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -5, 6, -5);
            var v = ov.swizzle.yzxw;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -4, 1, 0);
            var v = ov.swizzle.yzy;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(6, -9, -3, -2);
            var v = ov.swizzle.yzyx;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, -8, 6, 6);
            var v = ov.swizzle.yzyy;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -7, 5, -4);
            var v = ov.swizzle.yzyz;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 0, 3, 8);
            var v = ov.swizzle.yzyw;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, -8, 7, -4);
            var v = ov.swizzle.yzz;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-6, -7, -4, 0);
            var v = ov.swizzle.yzzx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, 8, 2, -3);
            var v = ov.swizzle.yzzy;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -3, 0, 8);
            var v = ov.swizzle.yzzz;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, 4, 3, 5);
            var v = ov.swizzle.yzzw;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, -4, -8, -3);
            var v = ov.swizzle.yzw;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(8, 7, -3, 9);
            var v = ov.swizzle.yzwx;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, -9, 5, -6);
            var v = ov.swizzle.yzwy;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, -7, 2, -3);
            var v = ov.swizzle.yzwz;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 6, 4, 8);
            var v = ov.swizzle.yzww;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, -3, -1, 1);
            var v = ov.swizzle.yw;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(-5, -3, -3, 1);
            var v = ov.swizzle.ywx;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-7, -6, 3, -1);
            var v = ov.swizzle.ywxx;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, -7, 3, -8);
            var v = ov.swizzle.ywxy;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -5, 5, 7);
            var v = ov.swizzle.ywxz;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 4, -8, 1);
            var v = ov.swizzle.ywxw;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, 5, 2, -6);
            var v = ov.swizzle.ywy;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-1, 6, 2, 3);
            var v = ov.swizzle.ywyx;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -4, 1, -2);
            var v = ov.swizzle.ywyy;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, -6, -7, -5);
            var v = ov.swizzle.ywyz;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -1, -2, 4);
            var v = ov.swizzle.ywyw;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -4, 0, -4);
            var v = ov.swizzle.ywz;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-4, 3, -3, -1);
            var v = ov.swizzle.ywzx;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, -7, 4, 0);
            var v = ov.swizzle.ywzy;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, 9, -8, 9);
            var v = ov.swizzle.ywzz;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, -7, -1, -1);
            var v = ov.swizzle.ywzw;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 0, -1, 1);
            var v = ov.swizzle.yww;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-6, -2, -5, 4);
            var v = ov.swizzle.ywwx;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 9, -3, -3);
            var v = ov.swizzle.ywwy;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -3, 5, 8);
            var v = ov.swizzle.ywwz;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 7, 1, 6);
            var v = ov.swizzle.ywww;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -2, 1, 3);
            var v = ov.swizzle.zx;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(8, 1, -7, -3);
            var v = ov.swizzle.zxx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-7, 6, 3, -8);
            var v = ov.swizzle.zxxx;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, 1, -2, -5);
            var v = ov.swizzle.zxxy;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, -8, -7, 2);
            var v = ov.swizzle.zxxz;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 8, -2, -1);
            var v = ov.swizzle.zxxw;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, -2, 7, 0);
            var v = ov.swizzle.zxy;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(3, 9, 4, 3);
            var v = ov.swizzle.zxyx;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 3, -7, 1);
            var v = ov.swizzle.zxyy;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 7, -2, -5);
            var v = ov.swizzle.zxyz;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, 2, 6, -1);
            var v = ov.swizzle.zxyw;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, -5, -3, -1);
            var v = ov.swizzle.zxz;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(1, -1, 5, 6);
            var v = ov.swizzle.zxzx;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, -9, -8, 5);
            var v = ov.swizzle.zxzy;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, 9, -9, -7);
            var v = ov.swizzle.zxzz;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, -7, 8, 6);
            var v = ov.swizzle.zxzw;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 0, 2, -6);
            var v = ov.swizzle.zxw;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(3, 9, -6, -5);
            var v = ov.swizzle.zxwx;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 2, 7, 5);
            var v = ov.swizzle.zxwy;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 0, 4, 8);
            var v = ov.swizzle.zxwz;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, -7, -8, -3);
            var v = ov.swizzle.zxww;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, -8, -3, -5);
            var v = ov.swizzle.zy;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(4, -2, 1, 8);
            var v = ov.swizzle.zyx;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(8, -5, 1, -7);
            var v = ov.swizzle.zyxx;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, -9, 9, 5);
            var v = ov.swizzle.zyxy;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -6, 6, -2);
            var v = ov.swizzle.zyxz;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -1, 0, 6);
            var v = ov.swizzle.zyxw;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, -3, 3, -8);
            var v = ov.swizzle.zyy;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(4, 9, -8, -6);
            var v = ov.swizzle.zyyx;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, -6, 2, 3);
            var v = ov.swizzle.zyyy;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 7, -1, -2);
            var v = ov.swizzle.zyyz;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 7, 6, -1);
            var v = ov.swizzle.zyyw;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, -1, -2, 1);
            var v = ov.swizzle.zyz;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-1, -8, -7, 2);
            var v = ov.swizzle.zyzx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, 6, -8, -3);
            var v = ov.swizzle.zyzy;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 5, 3, -2);
            var v = ov.swizzle.zyzz;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 3, 3, -8);
            var v = ov.swizzle.zyzw;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, 4, -8, -6);
            var v = ov.swizzle.zyw;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-6, 5, -8, 3);
            var v = ov.swizzle.zywx;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, -5, 3, 6);
            var v = ov.swizzle.zywy;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 8, 5, 0);
            var v = ov.swizzle.zywz;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 2, 7, 5);
            var v = ov.swizzle.zyww;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -5, 6, -1);
            var v = ov.swizzle.zz;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(-8, 9, 4, 2);
            var v = ov.swizzle.zzx;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(4, -9, 4, 4);
            var v = ov.swizzle.zzxx;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, 7, -4, -6);
            var v = ov.swizzle.zzxy;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -5, 4, 4);
            var v = ov.swizzle.zzxz;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -4, -6, -4);
            var v = ov.swizzle.zzxw;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, -1, 8, 8);
            var v = ov.swizzle.zzy;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-9, 3, 9, 4);
            var v = ov.swizzle.zzyx;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -7, 6, 1);
            var v = ov.swizzle.zzyy;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 7, -8, 6);
            var v = ov.swizzle.zzyz;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -6, -9, 6);
            var v = ov.swizzle.zzyw;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, -8, 2, -7);
            var v = ov.swizzle.zzz;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-5, 8, 7, 5);
            var v = ov.swizzle.zzzx;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 2, 5, -8);
            var v = ov.swizzle.zzzy;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, -2, 7, 6);
            var v = ov.swizzle.zzzz;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, -6, 2, 0);
            var v = ov.swizzle.zzzw;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, -9, 8, 6);
            var v = ov.swizzle.zzw;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(0, -2, -8, 4);
            var v = ov.swizzle.zzwx;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -7, 4, 4);
            var v = ov.swizzle.zzwy;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, 8, 3, 4);
            var v = ov.swizzle.zzwz;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, -2, -4, -1);
            var v = ov.swizzle.zzww;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 4, 6, -3);
            var v = ov.swizzle.zw;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(-2, 8, 2, 5);
            var v = ov.swizzle.zwx;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-9, -1, 5, 4);
            var v = ov.swizzle.zwxx;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -8, -8, -1);
            var v = ov.swizzle.zwxy;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, -6, -6, 2);
            var v = ov.swizzle.zwxz;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, 2, 8, 0);
            var v = ov.swizzle.zwxw;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, 1, 3, 9);
            var v = ov.swizzle.zwy;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(8, 2, -8, 8);
            var v = ov.swizzle.zwyx;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, -1, 4, 4);
            var v = ov.swizzle.zwyy;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, -5, -5, -2);
            var v = ov.swizzle.zwyz;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, -3, 5, 5);
            var v = ov.swizzle.zwyw;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -9, 9, -6);
            var v = ov.swizzle.zwz;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-1, -3, -5, -3);
            var v = ov.swizzle.zwzx;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -1, 0, -3);
            var v = ov.swizzle.zwzy;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 5, -5, 9);
            var v = ov.swizzle.zwzz;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, -3, -7, -6);
            var v = ov.swizzle.zwzw;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -6, 3, 2);
            var v = ov.swizzle.zww;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-3, -4, -7, -4);
            var v = ov.swizzle.zwwx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, 3, -4, -7);
            var v = ov.swizzle.zwwy;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, 2, 8, -8);
            var v = ov.swizzle.zwwz;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, 7, -8, -5);
            var v = ov.swizzle.zwww;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 5, -3, 9);
            var v = ov.swizzle.wx;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(9, -2, 8, 7);
            var v = ov.swizzle.wxx;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-9, 4, 6, -5);
            var v = ov.swizzle.wxxx;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 8, -3, -6);
            var v = ov.swizzle.wxxy;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 7, 2, -6);
            var v = ov.swizzle.wxxz;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 1, -2, -2);
            var v = ov.swizzle.wxxw;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, 2, -6, -2);
            var v = ov.swizzle.wxy;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-7, -7, -9, -7);
            var v = ov.swizzle.wxyx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, 1, 8, 6);
            var v = ov.swizzle.wxyy;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, -3, -3, 1);
            var v = ov.swizzle.wxyz;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 9, -4, -6);
            var v = ov.swizzle.wxyw;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -8, 2, 7);
            var v = ov.swizzle.wxz;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(8, -3, 2, 3);
            var v = ov.swizzle.wxzx;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 2, -9, 5);
            var v = ov.swizzle.wxzy;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, 1, -2, 6);
            var v = ov.swizzle.wxzz;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -6, 9, 2);
            var v = ov.swizzle.wxzw;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 9, 1, -3);
            var v = ov.swizzle.wxw;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(0, 6, -3, 2);
            var v = ov.swizzle.wxwx;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, 0, -1, 5);
            var v = ov.swizzle.wxwy;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, -5, -4, -9);
            var v = ov.swizzle.wxwz;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, 8, 2, 4);
            var v = ov.swizzle.wxww;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -6, -2, -2);
            var v = ov.swizzle.wy;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(2, 2, -2, 0);
            var v = ov.swizzle.wyx;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(0, 5, 6, 8);
            var v = ov.swizzle.wyxx;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, -1, -1, 6);
            var v = ov.swizzle.wyxy;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 8, 6, 2);
            var v = ov.swizzle.wyxz;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, -9, 8, 4);
            var v = ov.swizzle.wyxw;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -4, -8, -8);
            var v = ov.swizzle.wyy;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(6, -3, 6, 6);
            var v = ov.swizzle.wyyx;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, 5, 6, 8);
            var v = ov.swizzle.wyyy;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, 8, -1, -7);
            var v = ov.swizzle.wyyz;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -2, 2, 8);
            var v = ov.swizzle.wyyw;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 1, 6, -6);
            var v = ov.swizzle.wyz;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(3, 6, 2, -1);
            var v = ov.swizzle.wyzx;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 0, 4, -6);
            var v = ov.swizzle.wyzy;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, 6, 0, 7);
            var v = ov.swizzle.wyzz;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, -3, -3, 7);
            var v = ov.swizzle.wyzw;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, 0, -5, -3);
            var v = ov.swizzle.wyw;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(3, 2, 9, 6);
            var v = ov.swizzle.wywx;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 8, 6, 6);
            var v = ov.swizzle.wywy;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -9, -2, 9);
            var v = ov.swizzle.wywz;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 1, -4, -9);
            var v = ov.swizzle.wyww;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, -5, 4, -3);
            var v = ov.swizzle.wz;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(1, -1, 1, -1);
            var v = ov.swizzle.wzx;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(8, 2, -3, 1);
            var v = ov.swizzle.wzxx;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, -4, 9, -3);
            var v = ov.swizzle.wzxy;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, -3, -2, 1);
            var v = ov.swizzle.wzxz;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -5, -3, -3);
            var v = ov.swizzle.wzxw;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, -7, -8, 6);
            var v = ov.swizzle.wzy;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-5, 9, 0, 2);
            var v = ov.swizzle.wzyx;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, -3, -8, 3);
            var v = ov.swizzle.wzyy;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 1, -2, -2);
            var v = ov.swizzle.wzyz;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -8, -8, -5);
            var v = ov.swizzle.wzyw;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 5, 7, 2);
            var v = ov.swizzle.wzz;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(9, -8, 2, -4);
            var v = ov.swizzle.wzzx;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, -3, 2, -4);
            var v = ov.swizzle.wzzy;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, -2, -9, 3);
            var v = ov.swizzle.wzzz;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, -5, -6, -8);
            var v = ov.swizzle.wzzw;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, 9, 2, 5);
            var v = ov.swizzle.wzw;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-5, 5, -7, 4);
            var v = ov.swizzle.wzwx;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, -9, 1, -9);
            var v = ov.swizzle.wzwy;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -8, -6, 7);
            var v = ov.swizzle.wzwz;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, -6, -7, -6);
            var v = ov.swizzle.wzww;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 6, -4, 5);
            var v = ov.swizzle.ww;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(-1, 4, 2, 3);
            var v = ov.swizzle.wwx;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(2, 7, -9, 5);
            var v = ov.swizzle.wwxx;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, -9, -2, 5);
            var v = ov.swizzle.wwxy;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, 2, 7, 3);
            var v = ov.swizzle.wwxz;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -8, -2, 9);
            var v = ov.swizzle.wwxw;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, 2, -6, 2);
            var v = ov.swizzle.wwy;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-5, -2, -5, -7);
            var v = ov.swizzle.wwyx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -9, -1, -5);
            var v = ov.swizzle.wwyy;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, -6, -4, -1);
            var v = ov.swizzle.wwyz;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, -4, 2, -4);
            var v = ov.swizzle.wwyw;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, -6, -6, -8);
            var v = ov.swizzle.wwz;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(5, -1, 4, 5);
            var v = ov.swizzle.wwzx;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, -4, -6, 8);
            var v = ov.swizzle.wwzy;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, 4, -5, 8);
            var v = ov.swizzle.wwzz;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, -9, 8, -1);
            var v = ov.swizzle.wwzw;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 2, 7, 2);
            var v = ov.swizzle.www;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(7, -6, 9, 6);
            var v = ov.swizzle.wwwx;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, -6, -9, 6);
            var v = ov.swizzle.wwwy;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, -8, 9, -4);
            var v = ov.swizzle.wwwz;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, -7, -6, 3);
            var v = ov.swizzle.wwww;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new ivec4(-6, 2, 1, -6);
            var v = ov.swizzle.rr;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(7, 5, -3, 7);
            var v = ov.swizzle.rrr;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(2, -2, -5, 9);
            var v = ov.swizzle.rrrr;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, -8, 1, 4);
            var v = ov.swizzle.rrrg;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -2, 0, 5);
            var v = ov.swizzle.rrrb;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, -9, -2, 7);
            var v = ov.swizzle.rrra;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, -8, 4, 0);
            var v = ov.swizzle.rrg;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(8, -8, -8, -8);
            var v = ov.swizzle.rrgr;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, 8, 5, 0);
            var v = ov.swizzle.rrgg;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 5, 7, -2);
            var v = ov.swizzle.rrgb;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, -3, -5, 2);
            var v = ov.swizzle.rrga;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, -5, -5, 7);
            var v = ov.swizzle.rrb;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(0, -2, 1, 0);
            var v = ov.swizzle.rrbr;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -2, 3, -7);
            var v = ov.swizzle.rrbg;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, -3, -1, 9);
            var v = ov.swizzle.rrbb;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -3, -8, 3);
            var v = ov.swizzle.rrba;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -7, 8, -3);
            var v = ov.swizzle.rra;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-3, 1, -1, 9);
            var v = ov.swizzle.rrar;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 7, 2, 5);
            var v = ov.swizzle.rrag;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, 8, 3, 9);
            var v = ov.swizzle.rrab;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, -6, -9, -6);
            var v = ov.swizzle.rraa;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -7, -7, 7);
            var v = ov.swizzle.rg;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(5, 8, 8, 0);
            var v = ov.swizzle.rgr;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-4, -7, -2, 9);
            var v = ov.swizzle.rgrr;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -2, 7, 7);
            var v = ov.swizzle.rgrg;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 1, -5, -9);
            var v = ov.swizzle.rgrb;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -1, -5, -3);
            var v = ov.swizzle.rgra;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, -7, -3, 1);
            var v = ov.swizzle.rgg;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(9, 0, 6, 4);
            var v = ov.swizzle.rggr;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 2, 6, -6);
            var v = ov.swizzle.rggg;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, 0, 7, 4);
            var v = ov.swizzle.rggb;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -1, -6, 6);
            var v = ov.swizzle.rgga;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -2, -1, -2);
            var v = ov.swizzle.rgb;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(1, -6, 4, 1);
            var v = ov.swizzle.rgbr;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 0, -6, 5);
            var v = ov.swizzle.rgbg;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, 4, -8, 7);
            var v = ov.swizzle.rgbb;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 6, -1, -4);
            var v = ov.swizzle.rgba;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, 7, -7, -2);
            var v = ov.swizzle.rga;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(4, -1, 7, 4);
            var v = ov.swizzle.rgar;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, 9, 6, 9);
            var v = ov.swizzle.rgag;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 7, -7, -7);
            var v = ov.swizzle.rgab;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, 0, 0, -3);
            var v = ov.swizzle.rgaa;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 4, 2, -2);
            var v = ov.swizzle.rb;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(5, 0, -4, -5);
            var v = ov.swizzle.rbr;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(2, -9, 8, 5);
            var v = ov.swizzle.rbrr;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, 1, -6, 7);
            var v = ov.swizzle.rbrg;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -9, 6, 9);
            var v = ov.swizzle.rbrb;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, -9, 6, -1);
            var v = ov.swizzle.rbra;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 5, 9, -4);
            var v = ov.swizzle.rbg;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(6, 1, 1, -4);
            var v = ov.swizzle.rbgr;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, -7, -8, 5);
            var v = ov.swizzle.rbgg;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 4, 5, 4);
            var v = ov.swizzle.rbgb;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -2, 2, -5);
            var v = ov.swizzle.rbga;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 1, 8, -3);
            var v = ov.swizzle.rbb;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-2, 8, 1, 6);
            var v = ov.swizzle.rbbr;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -1, 4, -6);
            var v = ov.swizzle.rbbg;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, -2, -9, -9);
            var v = ov.swizzle.rbbb;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, -9, 7, 0);
            var v = ov.swizzle.rbba;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -4, -8, 2);
            var v = ov.swizzle.rba;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(3, 9, 3, 9);
            var v = ov.swizzle.rbar;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 2, -3, -6);
            var v = ov.swizzle.rbag;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -2, 9, -1);
            var v = ov.swizzle.rbab;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, -7, 2, -8);
            var v = ov.swizzle.rbaa;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, -4, 0, -5);
            var v = ov.swizzle.ra;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(-2, 1, 7, -2);
            var v = ov.swizzle.rar;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(5, 5, -4, -7);
            var v = ov.swizzle.rarr;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 1, -7, 6);
            var v = ov.swizzle.rarg;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, 6, 9, 1);
            var v = ov.swizzle.rarb;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, -2, -3, -1);
            var v = ov.swizzle.rara;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, 8, -9, 5);
            var v = ov.swizzle.rag;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(2, 7, 3, -3);
            var v = ov.swizzle.ragr;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, 9, 0, 2);
            var v = ov.swizzle.ragg;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 3, -1, 2);
            var v = ov.swizzle.ragb;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, -2, 3, 7);
            var v = ov.swizzle.raga;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, -6, -2, -5);
            var v = ov.swizzle.rab;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-4, 2, 7, 9);
            var v = ov.swizzle.rabr;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, 0, -3, 7);
            var v = ov.swizzle.rabg;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 8, -7, 2);
            var v = ov.swizzle.rabb;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, 1, 9, -8);
            var v = ov.swizzle.raba;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, 1, -9, -4);
            var v = ov.swizzle.raa;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(1, -4, -3, -9);
            var v = ov.swizzle.raar;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 6, -9, -3);
            var v = ov.swizzle.raag;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 5, 3, 1);
            var v = ov.swizzle.raab;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, 3, -1, -9);
            var v = ov.swizzle.raaa;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, -3, 5, -6);
            var v = ov.swizzle.gr;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(-7, -3, 1, 3);
            var v = ov.swizzle.grr;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(5, 7, -9, 0);
            var v = ov.swizzle.grrr;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 5, 4, 5);
            var v = ov.swizzle.grrg;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, -7, -4, 0);
            var v = ov.swizzle.grrb;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, 7, -4, -9);
            var v = ov.swizzle.grra;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -9, -9, -5);
            var v = ov.swizzle.grg;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(5, -6, 5, -8);
            var v = ov.swizzle.grgr;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, -1, -8, 9);
            var v = ov.swizzle.grgg;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 2, -6, 7);
            var v = ov.swizzle.grgb;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, 8, -4, 7);
            var v = ov.swizzle.grga;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, -9, -1, 2);
            var v = ov.swizzle.grb;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(0, -7, 5, -9);
            var v = ov.swizzle.grbr;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, -1, 8, -1);
            var v = ov.swizzle.grbg;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 5, -5, -7);
            var v = ov.swizzle.grbb;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 6, -8, 8);
            var v = ov.swizzle.grba;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, 0, 9, -1);
            var v = ov.swizzle.gra;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(6, -5, -1, -3);
            var v = ov.swizzle.grar;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, 5, 7, 1);
            var v = ov.swizzle.grag;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, 5, -2, 1);
            var v = ov.swizzle.grab;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, -7, -4, 7);
            var v = ov.swizzle.graa;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, 5, 8, -9);
            var v = ov.swizzle.gg;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(1, 6, -1, 9);
            var v = ov.swizzle.ggr;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(7, -9, -5, 5);
            var v = ov.swizzle.ggrr;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, 4, 5, 6);
            var v = ov.swizzle.ggrg;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, 0, -5, 5);
            var v = ov.swizzle.ggrb;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, -2, -8, 3);
            var v = ov.swizzle.ggra;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, 7, -7, -2);
            var v = ov.swizzle.ggg;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-3, -4, 8, -6);
            var v = ov.swizzle.gggr;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, 9, -9, -6);
            var v = ov.swizzle.gggg;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -1, 9, 0);
            var v = ov.swizzle.gggb;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 0, 5, 1);
            var v = ov.swizzle.ggga;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, 2, -1, 8);
            var v = ov.swizzle.ggb;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(0, 5, -2, 7);
            var v = ov.swizzle.ggbr;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 8, 1, -8);
            var v = ov.swizzle.ggbg;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, 4, -6, -3);
            var v = ov.swizzle.ggbb;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, -8, -6, -3);
            var v = ov.swizzle.ggba;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, -9, -3, 0);
            var v = ov.swizzle.gga;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(5, 8, -5, -8);
            var v = ov.swizzle.ggar;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, -5, 0, 5);
            var v = ov.swizzle.ggag;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, -7, -3, 0);
            var v = ov.swizzle.ggab;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, 8, -2, 7);
            var v = ov.swizzle.ggaa;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 1, -4, 3);
            var v = ov.swizzle.gb;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(8, 0, 9, 6);
            var v = ov.swizzle.gbr;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-5, -6, -1, 5);
            var v = ov.swizzle.gbrr;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, -2, -2, -2);
            var v = ov.swizzle.gbrg;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, -1, 2, -1);
            var v = ov.swizzle.gbrb;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, -4, -7, 6);
            var v = ov.swizzle.gbra;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, -5, -2, 9);
            var v = ov.swizzle.gbg;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-2, -5, -5, 0);
            var v = ov.swizzle.gbgr;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 7, -2, 7);
            var v = ov.swizzle.gbgg;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 9, -1, 4);
            var v = ov.swizzle.gbgb;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, 7, 3, -4);
            var v = ov.swizzle.gbga;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, -5, 0, -4);
            var v = ov.swizzle.gbb;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(4, 1, -1, 6);
            var v = ov.swizzle.gbbr;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, 1, -7, 7);
            var v = ov.swizzle.gbbg;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, 6, -5, -4);
            var v = ov.swizzle.gbbb;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, 0, -4, -9);
            var v = ov.swizzle.gbba;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -1, -9, -7);
            var v = ov.swizzle.gba;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(0, 3, 5, -9);
            var v = ov.swizzle.gbar;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, -7, -2, 2);
            var v = ov.swizzle.gbag;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, 3, 3, -3);
            var v = ov.swizzle.gbab;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -7, 4, -1);
            var v = ov.swizzle.gbaa;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, 8, -3, 4);
            var v = ov.swizzle.ga;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(9, 3, 3, -8);
            var v = ov.swizzle.gar;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-4, -7, -6, -8);
            var v = ov.swizzle.garr;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, 3, -3, -2);
            var v = ov.swizzle.garg;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 3, -3, 1);
            var v = ov.swizzle.garb;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -2, 6, 8);
            var v = ov.swizzle.gara;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, -4, -7, 0);
            var v = ov.swizzle.gag;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(3, 2, -9, -2);
            var v = ov.swizzle.gagr;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 3, -5, -2);
            var v = ov.swizzle.gagg;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -5, 6, -6);
            var v = ov.swizzle.gagb;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, 7, 4, 1);
            var v = ov.swizzle.gaga;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, -3, 8, 6);
            var v = ov.swizzle.gab;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-1, -1, -7, -1);
            var v = ov.swizzle.gabr;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, 3, -5, -2);
            var v = ov.swizzle.gabg;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 4, -5, -5);
            var v = ov.swizzle.gabb;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, 3, -5, -2);
            var v = ov.swizzle.gaba;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 3, 2, 9);
            var v = ov.swizzle.gaa;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(7, 0, -5, 0);
            var v = ov.swizzle.gaar;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -6, 1, 7);
            var v = ov.swizzle.gaag;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 4, 7, -6);
            var v = ov.swizzle.gaab;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 9, 9, -2);
            var v = ov.swizzle.gaaa;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 8, 7, -3);
            var v = ov.swizzle.br;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(7, 3, 9, -3);
            var v = ov.swizzle.brr;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-9, -1, 9, -6);
            var v = ov.swizzle.brrr;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -2, 3, -7);
            var v = ov.swizzle.brrg;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, -8, -8, 9);
            var v = ov.swizzle.brrb;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, -7, -4, 7);
            var v = ov.swizzle.brra;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 7, 3, -6);
            var v = ov.swizzle.brg;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-6, -9, 9, -6);
            var v = ov.swizzle.brgr;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 2, 7, 9);
            var v = ov.swizzle.brgg;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 8, 2, 4);
            var v = ov.swizzle.brgb;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, 1, 0, 5);
            var v = ov.swizzle.brga;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, 5, -5, -6);
            var v = ov.swizzle.brb;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(1, 9, 4, 6);
            var v = ov.swizzle.brbr;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, 0, -6, 6);
            var v = ov.swizzle.brbg;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -9, -1, -9);
            var v = ov.swizzle.brbb;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, -4, -6, 0);
            var v = ov.swizzle.brba;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -3, 2, 8);
            var v = ov.swizzle.bra;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(3, -4, 1, 2);
            var v = ov.swizzle.brar;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, -4, -9, -5);
            var v = ov.swizzle.brag;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 7, 0, -5);
            var v = ov.swizzle.brab;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 7, -5, 6);
            var v = ov.swizzle.braa;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, 2, 4, -3);
            var v = ov.swizzle.bg;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(6, 0, -5, -6);
            var v = ov.swizzle.bgr;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-7, 2, 4, -6);
            var v = ov.swizzle.bgrr;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 0, 4, -3);
            var v = ov.swizzle.bgrg;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, 5, -2, 6);
            var v = ov.swizzle.bgrb;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, 2, 9, -7);
            var v = ov.swizzle.bgra;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, 1, -1, 6);
            var v = ov.swizzle.bgg;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-9, -5, 6, -2);
            var v = ov.swizzle.bggr;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 9, 5, -7);
            var v = ov.swizzle.bggg;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, 9, 2, 3);
            var v = ov.swizzle.bggb;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, 4, 4, -4);
            var v = ov.swizzle.bgga;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, 2, 9, -6);
            var v = ov.swizzle.bgb;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(3, 7, -3, 6);
            var v = ov.swizzle.bgbr;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 7, -7, -2);
            var v = ov.swizzle.bgbg;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 6, -2, 5);
            var v = ov.swizzle.bgbb;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, 8, -7, 1);
            var v = ov.swizzle.bgba;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, -3, -7, -4);
            var v = ov.swizzle.bga;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-4, 6, 4, -3);
            var v = ov.swizzle.bgar;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, 7, 7, 3);
            var v = ov.swizzle.bgag;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -6, 8, -8);
            var v = ov.swizzle.bgab;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, -4, 3, -1);
            var v = ov.swizzle.bgaa;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, -9, -5, 9);
            var v = ov.swizzle.bb;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(-2, -3, 4, 1);
            var v = ov.swizzle.bbr;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-7, -6, -3, -1);
            var v = ov.swizzle.bbrr;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 2, -7, -6);
            var v = ov.swizzle.bbrg;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, -5, 1, -6);
            var v = ov.swizzle.bbrb;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, -9, 3, 7);
            var v = ov.swizzle.bbra;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -4, -4, -6);
            var v = ov.swizzle.bbg;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-8, -4, -5, -5);
            var v = ov.swizzle.bbgr;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 5, -9, -7);
            var v = ov.swizzle.bbgg;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 7, 2, 0);
            var v = ov.swizzle.bbgb;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 3, -5, 6);
            var v = ov.swizzle.bbga;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -7, -6, -5);
            var v = ov.swizzle.bbb;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-8, -3, -3, -5);
            var v = ov.swizzle.bbbr;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, 6, 7, 2);
            var v = ov.swizzle.bbbg;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 6, 9, -8);
            var v = ov.swizzle.bbbb;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 8, 2, 3);
            var v = ov.swizzle.bbba;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, -8, 5, 1);
            var v = ov.swizzle.bba;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(3, 0, -8, -7);
            var v = ov.swizzle.bbar;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 0, -4, -9);
            var v = ov.swizzle.bbag;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, -7, -3, 3);
            var v = ov.swizzle.bbab;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -9, -7, 5);
            var v = ov.swizzle.bbaa;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, -9, 2, -8);
            var v = ov.swizzle.ba;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(-8, -6, 1, -1);
            var v = ov.swizzle.bar;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-7, 3, 2, -3);
            var v = ov.swizzle.barr;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -1, 4, -7);
            var v = ov.swizzle.barg;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -5, -1, -7);
            var v = ov.swizzle.barb;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -5, 1, -1);
            var v = ov.swizzle.bara;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, 7, -8, -8);
            var v = ov.swizzle.bag;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-4, 6, 0, -9);
            var v = ov.swizzle.bagr;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, -7, 2, 2);
            var v = ov.swizzle.bagg;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 6, 3, 7);
            var v = ov.swizzle.bagb;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, 6, 0, 8);
            var v = ov.swizzle.baga;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 0, -9, -3);
            var v = ov.swizzle.bab;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-2, -6, -2, 2);
            var v = ov.swizzle.babr;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 0, -1, 5);
            var v = ov.swizzle.babg;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -1, 5, 9);
            var v = ov.swizzle.babb;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 3, -7, -1);
            var v = ov.swizzle.baba;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, 2, 2, 2);
            var v = ov.swizzle.baa;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(8, 2, 1, 4);
            var v = ov.swizzle.baar;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, 3, -8, 7);
            var v = ov.swizzle.baag;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -3, -3, -2);
            var v = ov.swizzle.baab;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 4, 6, -7);
            var v = ov.swizzle.baaa;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -7, -1, -1);
            var v = ov.swizzle.ar;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(6, -6, 4, 3);
            var v = ov.swizzle.arr;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(1, -4, 8, -5);
            var v = ov.swizzle.arrr;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, 8, 5, -6);
            var v = ov.swizzle.arrg;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, -7, 4, 8);
            var v = ov.swizzle.arrb;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, 6, -1, 3);
            var v = ov.swizzle.arra;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, 3, -1, 4);
            var v = ov.swizzle.arg;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-8, -3, 1, -4);
            var v = ov.swizzle.argr;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -9, -6, 5);
            var v = ov.swizzle.argg;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -2, -6, -3);
            var v = ov.swizzle.argb;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-7, -8, 2, -7);
            var v = ov.swizzle.arga;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 3, -8, 6);
            var v = ov.swizzle.arb;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(6, -6, -4, -1);
            var v = ov.swizzle.arbr;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, -7, 2, 7);
            var v = ov.swizzle.arbg;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, 6, 8, 3);
            var v = ov.swizzle.arbb;
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 0, 4, 7);
            var v = ov.swizzle.arba;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -5, -8, 9);
            var v = ov.swizzle.ara;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-2, -9, 4, 5);
            var v = ov.swizzle.arar;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -1, -1, -6);
            var v = ov.swizzle.arag;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, -3, 8, -8);
            var v = ov.swizzle.arab;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 4, -7, 1);
            var v = ov.swizzle.araa;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, 9, -4, 0);
            var v = ov.swizzle.ag;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(-7, 8, -9, 4);
            var v = ov.swizzle.agr;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(2, -3, 7, -7);
            var v = ov.swizzle.agrr;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, -4, 5, -9);
            var v = ov.swizzle.agrg;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 7, -4, 7);
            var v = ov.swizzle.agrb;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, 7, 9, 8);
            var v = ov.swizzle.agra;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 6, 2, -3);
            var v = ov.swizzle.agg;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-8, -1, -8, 0);
            var v = ov.swizzle.aggr;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, 2, 8, 2);
            var v = ov.swizzle.aggg;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, -8, -3, 2);
            var v = ov.swizzle.aggb;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, -9, 2, 7);
            var v = ov.swizzle.agga;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, -4, 1, 9);
            var v = ov.swizzle.agb;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(7, 8, -3, -6);
            var v = ov.swizzle.agbr;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, 9, 8, -1);
            var v = ov.swizzle.agbg;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, 5, -4, 9);
            var v = ov.swizzle.agbb;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 6, 6, -1);
            var v = ov.swizzle.agba;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, 7, -5, -1);
            var v = ov.swizzle.aga;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(5, 2, -8, 6);
            var v = ov.swizzle.agar;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -1, 6, -3);
            var v = ov.swizzle.agag;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, 2, 4, -2);
            var v = ov.swizzle.agab;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(4, -3, 4, 8);
            var v = ov.swizzle.agaa;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 1, 9, -2);
            var v = ov.swizzle.ab;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(-3, -7, 2, -6);
            var v = ov.swizzle.abr;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(3, 2, -6, -3);
            var v = ov.swizzle.abrr;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-3, -2, -3, -5);
            var v = ov.swizzle.abrg;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, -1, 3, 5);
            var v = ov.swizzle.abrb;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, 6, 1, -9);
            var v = ov.swizzle.abra;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, -6, 6, -7);
            var v = ov.swizzle.abg;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(0, 2, 4, -2);
            var v = ov.swizzle.abgr;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, -7, -3, -3);
            var v = ov.swizzle.abgg;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 2, -8, 7);
            var v = ov.swizzle.abgb;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, 2, 2, -2);
            var v = ov.swizzle.abga;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-5, -4, -9, -3);
            var v = ov.swizzle.abb;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(8, 9, -3, -4);
            var v = ov.swizzle.abbr;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, -9, -8, -2);
            var v = ov.swizzle.abbg;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-9, -1, 8, -6);
            var v = ov.swizzle.abbb;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-1, 4, -6, 0);
            var v = ov.swizzle.abba;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 3, -1, -5);
            var v = ov.swizzle.aba;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-8, -9, -7, -5);
            var v = ov.swizzle.abar;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -6, 4, 7);
            var v = ov.swizzle.abag;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(3, 8, 4, 8);
            var v = ov.swizzle.abab;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, -3, 8, 9);
            var v = ov.swizzle.abaa;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(9, 9, 2, 2);
            var v = ov.swizzle.aa;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec4(-9, 0, -3, 6);
            var v = ov.swizzle.aar;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-4, 1, -7, -5);
            var v = ov.swizzle.aarr;
            Assert.That(-5, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(6, 1, -4, -1);
            var v = ov.swizzle.aarg;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(2, 4, -4, 8);
            var v = ov.swizzle.aarb;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, -7, 1, -4);
            var v = ov.swizzle.aara;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-4, 9, 8, -1);
            var v = ov.swizzle.aag;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(6, -9, 0, -8);
            var v = ov.swizzle.aagr;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, 5, -1, 7);
            var v = ov.swizzle.aagg;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(0, 7, -5, -8);
            var v = ov.swizzle.aagb;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(5, 9, 1, -1);
            var v = ov.swizzle.aaga;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, 8, 1, 1);
            var v = ov.swizzle.aab;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-4, -3, 6, -2);
            var v = ov.swizzle.aabr;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-8, -9, -8, -2);
            var v = ov.swizzle.aabg;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 8, 8, 9);
            var v = ov.swizzle.aabb;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(8, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-2, 2, 0, -4);
            var v = ov.swizzle.aaba;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(1, -8, -9, 1);
            var v = ov.swizzle.aaa;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec4(-1, 6, 9, -4);
            var v = ov.swizzle.aaar;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(8, -6, 3, 1);
            var v = ov.swizzle.aaag;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(-6, -1, -5, 4);
            var v = ov.swizzle.aaab;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec4(7, 6, -6, -3);
            var v = ov.swizzle.aaaa;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new ivec4(-2, 9, 2, -4);
            var v1 = new ivec2(1, -8);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(1, Is.EqualTo(v0.x));
            Assert.That(-8, Is.EqualTo(v0.y));
            Assert.That(2, Is.EqualTo(v0.z));
            Assert.That(-4, Is.EqualTo(v0.w));
        
            Assert.That(-2, Is.EqualTo(v2.x));
            Assert.That(9, Is.EqualTo(v2.y));
        }
        {
            var v0 = new ivec4(2, -1, 5, 8);
            var v1 = new ivec2(7, -8);
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(7, Is.EqualTo(v0.x));
            Assert.That(-1, Is.EqualTo(v0.y));
            Assert.That(-8, Is.EqualTo(v0.z));
            Assert.That(8, Is.EqualTo(v0.w));
        
            Assert.That(2, Is.EqualTo(v2.x));
            Assert.That(5, Is.EqualTo(v2.y));
        }
        {
            var v0 = new ivec4(-5, 6, 9, 9);
            var v1 = new ivec2(-5, 4);
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-5, Is.EqualTo(v0.x));
            Assert.That(-5, Is.EqualTo(v0.y));
            Assert.That(4, Is.EqualTo(v0.z));
            Assert.That(9, Is.EqualTo(v0.w));
        
            Assert.That(6, Is.EqualTo(v2.x));
            Assert.That(9, Is.EqualTo(v2.y));
        }
        {
            var v0 = new ivec4(2, 9, -7, 5);
            var v1 = new ivec3(4, 5, -3);
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4, Is.EqualTo(v0.x));
            Assert.That(5, Is.EqualTo(v0.y));
            Assert.That(-3, Is.EqualTo(v0.z));
            Assert.That(5, Is.EqualTo(v0.w));
        
            Assert.That(2, Is.EqualTo(v2.x));
            Assert.That(9, Is.EqualTo(v2.y));
            Assert.That(-7, Is.EqualTo(v2.z));
        }
        {
            var v0 = new ivec4(3, -8, -3, 9);
            var v1 = new ivec2(-8, -9);
            var v2 = v0.xw;
            v0.xw = v1;
            var v3 = v0.xw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-8, Is.EqualTo(v0.x));
            Assert.That(-8, Is.EqualTo(v0.y));
            Assert.That(-3, Is.EqualTo(v0.z));
            Assert.That(-9, Is.EqualTo(v0.w));
        
            Assert.That(3, Is.EqualTo(v2.x));
            Assert.That(9, Is.EqualTo(v2.y));
        }
        {
            var v0 = new ivec4(6, -1, 5, -6);
            var v1 = new ivec2(3, -4);
            var v2 = v0.yw;
            v0.yw = v1;
            var v3 = v0.yw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(6, Is.EqualTo(v0.x));
            Assert.That(3, Is.EqualTo(v0.y));
            Assert.That(5, Is.EqualTo(v0.z));
            Assert.That(-4, Is.EqualTo(v0.w));
        
            Assert.That(-1, Is.EqualTo(v2.x));
            Assert.That(-6, Is.EqualTo(v2.y));
        }
        {
            var v0 = new ivec4(7, 6, -2, 9);
            var v1 = new ivec3(-7, 9, -3);
            var v2 = v0.xyw;
            v0.xyw = v1;
            var v3 = v0.xyw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-7, Is.EqualTo(v0.x));
            Assert.That(9, Is.EqualTo(v0.y));
            Assert.That(-2, Is.EqualTo(v0.z));
            Assert.That(-3, Is.EqualTo(v0.w));
        
            Assert.That(7, Is.EqualTo(v2.x));
            Assert.That(6, Is.EqualTo(v2.y));
            Assert.That(9, Is.EqualTo(v2.z));
        }
        {
            var v0 = new ivec4(-6, 8, 4, -5);
            var v1 = new ivec2(-8, 0);
            var v2 = v0.zw;
            v0.zw = v1;
            var v3 = v0.zw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-6, Is.EqualTo(v0.x));
            Assert.That(8, Is.EqualTo(v0.y));
            Assert.That(-8, Is.EqualTo(v0.z));
            Assert.That(0, Is.EqualTo(v0.w));
        
            Assert.That(4, Is.EqualTo(v2.x));
            Assert.That(-5, Is.EqualTo(v2.y));
        }
        {
            var v0 = new ivec4(7, -8, 7, -8);
            var v1 = new ivec3(-9, 6, 4);
            var v2 = v0.xzw;
            v0.xzw = v1;
            var v3 = v0.xzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-9, Is.EqualTo(v0.x));
            Assert.That(-8, Is.EqualTo(v0.y));
            Assert.That(6, Is.EqualTo(v0.z));
            Assert.That(4, Is.EqualTo(v0.w));
        
            Assert.That(7, Is.EqualTo(v2.x));
            Assert.That(7, Is.EqualTo(v2.y));
            Assert.That(-8, Is.EqualTo(v2.z));
        }
        {
            var v0 = new ivec4(-7, 0, -7, 0);
            var v1 = new ivec3(9, 1, 7);
            var v2 = v0.yzw;
            v0.yzw = v1;
            var v3 = v0.yzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-7, Is.EqualTo(v0.x));
            Assert.That(9, Is.EqualTo(v0.y));
            Assert.That(1, Is.EqualTo(v0.z));
            Assert.That(7, Is.EqualTo(v0.w));
        
            Assert.That(0, Is.EqualTo(v2.x));
            Assert.That(-7, Is.EqualTo(v2.y));
            Assert.That(0, Is.EqualTo(v2.z));
        }
        {
            var v0 = new ivec4(8, 1, 6, 8);
            var v1 = new ivec4(9, 5, -6, 7);
            var v2 = v0.xyzw;
            v0.xyzw = v1;
            var v3 = v0.xyzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(9, Is.EqualTo(v0.x));
            Assert.That(5, Is.EqualTo(v0.y));
            Assert.That(-6, Is.EqualTo(v0.z));
            Assert.That(7, Is.EqualTo(v0.w));
        
            Assert.That(8, Is.EqualTo(v2.x));
            Assert.That(1, Is.EqualTo(v2.y));
            Assert.That(6, Is.EqualTo(v2.z));
            Assert.That(8, Is.EqualTo(v2.w));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            ivec4 v0 = new ivec4(-3, 1, 2, 3);
            int v1 = 8;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(8, Is.EqualTo(v0.x));
            Assert.That(1, Is.EqualTo(v0.y));
            Assert.That(2, Is.EqualTo(v0.z));
            Assert.That(3, Is.EqualTo(v0.w));
        
            Assert.That(-3, Is.EqualTo(v2));
        }
        {
            ivec4 v0 = new ivec4(2, 1, -9, -7);
            int v1 = -9;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(2, Is.EqualTo(v0.x));
            Assert.That(-9, Is.EqualTo(v0.y));
            Assert.That(-9, Is.EqualTo(v0.z));
            Assert.That(-7, Is.EqualTo(v0.w));
        
            Assert.That(1, Is.EqualTo(v2));
        }
        {
            ivec4 v0 = new ivec4(-7, -4, 5, -1);
            ivec2 v1 = new ivec2(-6, -3);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-6, Is.EqualTo(v0.x));
            Assert.That(-3, Is.EqualTo(v0.y));
            Assert.That(5, Is.EqualTo(v0.z));
            Assert.That(-1, Is.EqualTo(v0.w));
        
            Assert.That(-7, Is.EqualTo(v2.x));
            Assert.That(-4, Is.EqualTo(v2.y));
        }
        {
            ivec4 v0 = new ivec4(6, -5, 1, -2);
            int v1 = 7;
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(6, Is.EqualTo(v0.x));
            Assert.That(-5, Is.EqualTo(v0.y));
            Assert.That(7, Is.EqualTo(v0.z));
            Assert.That(-2, Is.EqualTo(v0.w));
        
            Assert.That(1, Is.EqualTo(v2));
        }
        {
            ivec4 v0 = new ivec4(-2, 4, 9, 5);
            ivec2 v1 = new ivec2(5, -5);
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(5, Is.EqualTo(v0.x));
            Assert.That(4, Is.EqualTo(v0.y));
            Assert.That(-5, Is.EqualTo(v0.z));
            Assert.That(5, Is.EqualTo(v0.w));
        
            Assert.That(-2, Is.EqualTo(v2.x));
            Assert.That(9, Is.EqualTo(v2.y));
        }
        {
            ivec4 v0 = new ivec4(4, -5, 1, -2);
            ivec2 v1 = new ivec2(-2, 3);
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4, Is.EqualTo(v0.x));
            Assert.That(-2, Is.EqualTo(v0.y));
            Assert.That(3, Is.EqualTo(v0.z));
            Assert.That(-2, Is.EqualTo(v0.w));
        
            Assert.That(-5, Is.EqualTo(v2.x));
            Assert.That(1, Is.EqualTo(v2.y));
        }
        {
            ivec4 v0 = new ivec4(-4, -4, -4, -9);
            ivec3 v1 = new ivec3(7, -3, -4);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(7, Is.EqualTo(v0.x));
            Assert.That(-3, Is.EqualTo(v0.y));
            Assert.That(-4, Is.EqualTo(v0.z));
            Assert.That(-9, Is.EqualTo(v0.w));
        
            Assert.That(-4, Is.EqualTo(v2.x));
            Assert.That(-4, Is.EqualTo(v2.y));
            Assert.That(-4, Is.EqualTo(v2.z));
        }
        {
            ivec4 v0 = new ivec4(-3, 5, 8, 5);
            int v1 = -2;
            var v2 = v0.a;
            v0.a = v1;
            var v3 = v0.a;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-3, Is.EqualTo(v0.x));
            Assert.That(5, Is.EqualTo(v0.y));
            Assert.That(8, Is.EqualTo(v0.z));
            Assert.That(-2, Is.EqualTo(v0.w));
        
            Assert.That(5, Is.EqualTo(v2));
        }
        {
            ivec4 v0 = new ivec4(8, -8, 2, 9);
            ivec2 v1 = new ivec2(4, 6);
            var v2 = v0.ra;
            v0.ra = v1;
            var v3 = v0.ra;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4, Is.EqualTo(v0.x));
            Assert.That(-8, Is.EqualTo(v0.y));
            Assert.That(2, Is.EqualTo(v0.z));
            Assert.That(6, Is.EqualTo(v0.w));
        
            Assert.That(8, Is.EqualTo(v2.x));
            Assert.That(9, Is.EqualTo(v2.y));
        }
        {
            ivec4 v0 = new ivec4(6, -5, 9, 2);
            ivec2 v1 = new ivec2(0, -6);
            var v2 = v0.ga;
            v0.ga = v1;
            var v3 = v0.ga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(6, Is.EqualTo(v0.x));
            Assert.That(0, Is.EqualTo(v0.y));
            Assert.That(9, Is.EqualTo(v0.z));
            Assert.That(-6, Is.EqualTo(v0.w));
        
            Assert.That(-5, Is.EqualTo(v2.x));
            Assert.That(2, Is.EqualTo(v2.y));
        }
        {
            ivec4 v0 = new ivec4(-3, -8, 2, 7);
            ivec3 v1 = new ivec3(-6, 3, -5);
            var v2 = v0.rga;
            v0.rga = v1;
            var v3 = v0.rga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-6, Is.EqualTo(v0.x));
            Assert.That(3, Is.EqualTo(v0.y));
            Assert.That(2, Is.EqualTo(v0.z));
            Assert.That(-5, Is.EqualTo(v0.w));
        
            Assert.That(-3, Is.EqualTo(v2.x));
            Assert.That(-8, Is.EqualTo(v2.y));
            Assert.That(7, Is.EqualTo(v2.z));
        }
        {
            ivec4 v0 = new ivec4(6, 5, -1, -2);
            ivec2 v1 = new ivec2(-6, 2);
            var v2 = v0.ba;
            v0.ba = v1;
            var v3 = v0.ba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(6, Is.EqualTo(v0.x));
            Assert.That(5, Is.EqualTo(v0.y));
            Assert.That(-6, Is.EqualTo(v0.z));
            Assert.That(2, Is.EqualTo(v0.w));
        
            Assert.That(-1, Is.EqualTo(v2.x));
            Assert.That(-2, Is.EqualTo(v2.y));
        }
        {
            ivec4 v0 = new ivec4(-4, -8, 1, 6);
            ivec3 v1 = new ivec3(-8, 1, 3);
            var v2 = v0.rba;
            v0.rba = v1;
            var v3 = v0.rba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-8, Is.EqualTo(v0.x));
            Assert.That(-8, Is.EqualTo(v0.y));
            Assert.That(1, Is.EqualTo(v0.z));
            Assert.That(3, Is.EqualTo(v0.w));
        
            Assert.That(-4, Is.EqualTo(v2.x));
            Assert.That(1, Is.EqualTo(v2.y));
            Assert.That(6, Is.EqualTo(v2.z));
        }
        {
            ivec4 v0 = new ivec4(-8, -8, -6, 7);
            ivec3 v1 = new ivec3(-2, -5, -1);
            var v2 = v0.gba;
            v0.gba = v1;
            var v3 = v0.gba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-8, Is.EqualTo(v0.x));
            Assert.That(-2, Is.EqualTo(v0.y));
            Assert.That(-5, Is.EqualTo(v0.z));
            Assert.That(-1, Is.EqualTo(v0.w));
        
            Assert.That(-8, Is.EqualTo(v2.x));
            Assert.That(-6, Is.EqualTo(v2.y));
            Assert.That(7, Is.EqualTo(v2.z));
        }
        {
            ivec4 v0 = new ivec4(-5, 4, -7, -3);
            ivec4 v1 = new ivec4(-1, -3, -7, 6);
            var v2 = v0.rgba;
            v0.rgba = v1;
            var v3 = v0.rgba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-1, Is.EqualTo(v0.x));
            Assert.That(-3, Is.EqualTo(v0.y));
            Assert.That(-7, Is.EqualTo(v0.z));
            Assert.That(6, Is.EqualTo(v0.w));
        
            Assert.That(-5, Is.EqualTo(v2.x));
            Assert.That(4, Is.EqualTo(v2.y));
            Assert.That(-7, Is.EqualTo(v2.z));
            Assert.That(-3, Is.EqualTo(v2.w));
        }
    }

}
