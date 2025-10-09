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

namespace GlmResharpenedTest.Generated.Vec2_Swizzle;

[TestFixture]
public class ComplexSwizzleVec2Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new cvec2(new Complex(3.5d, -4d), new Complex(3.5d, 3d));
            var v = ov.swizzle.xx;
            Assert.That(new Complex(3.5d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, -4d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec2(new Complex(2d, -9.5d), new Complex(1.5d, 8d));
            var v = ov.swizzle.xxx;
            Assert.That(new Complex(2d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2d, -9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(-7d, -3d), new Complex(8.5d, 8.5d));
            var v = ov.swizzle.xxxx;
            Assert.That(new Complex(-7d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(-6.5d, 4.5d), new Complex(4.5d, 7d));
            var v = ov.swizzle.xxxy;
            Assert.That(new Complex(-6.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, 7d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(-3.5d, 3d), new Complex(-8.5d, -4d));
            var v = ov.swizzle.xxy;
            Assert.That(new Complex(-3.5d, 3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, 3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, -4d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(-8.5d, -4.5d), new Complex(-2.5d, 8d));
            var v = ov.swizzle.xxyx;
            Assert.That(new Complex(-8.5d, -4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, -4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2.5d, 8d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, -4.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(3.5d, 7d), new Complex(-2d, 1.5d));
            var v = ov.swizzle.xxyy;
            Assert.That(new Complex(3.5d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-2d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-2d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(3.5d, 1.5d), new Complex(5d, -5.5d));
            var v = ov.swizzle.xy;
            Assert.That(new Complex(3.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(5d, -5.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec2(new Complex(-8d, -4d), new Complex(6d, -5.5d));
            var v = ov.swizzle.xyx;
            Assert.That(new Complex(-8d, -4d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, -4d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(3.5d, 7.5d), new Complex(-6.5d, 5.5d));
            var v = ov.swizzle.xyxx;
            Assert.That(new Complex(3.5d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-6.5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(3.5d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(-7d, -1d), new Complex(-1d, -8d));
            var v = ov.swizzle.xyxy;
            Assert.That(new Complex(-7d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -8d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(4d, -8d), new Complex(8.5d, -8d));
            var v = ov.swizzle.xyy;
            Assert.That(new Complex(4d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, -8d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(0.0, 3.5d), new Complex(-8d, 7.5d));
            var v = ov.swizzle.xyyx;
            Assert.That(new Complex(0.0, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, 7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(7d, 1.5d), new Complex(7d, -0.5d));
            var v = ov.swizzle.xyyy;
            Assert.That(new Complex(7d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, -0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(7d, -0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(7d, -0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(0.0, -6d), new Complex(3d, -9.5d));
            var v = ov.swizzle.yx;
            Assert.That(new Complex(3d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, -6d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec2(new Complex(3.5d, -2.5d), new Complex(-8d, 9d));
            var v = ov.swizzle.yxx;
            Assert.That(new Complex(-8d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(3.5d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3.5d, -2.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(4d, -3d), new Complex(2d, -3.5d));
            var v = ov.swizzle.yxxx;
            Assert.That(new Complex(2d, -3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(4d, -3d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(-1.5d, 4.5d), new Complex(-7.5d, 8.5d));
            var v = ov.swizzle.yxxy;
            Assert.That(new Complex(-7.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, 8.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(2d, -5.5d), new Complex(-9.5d, 9.5d));
            var v = ov.swizzle.yxy;
            Assert.That(new Complex(-9.5d, 9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(2d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, 9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(8.5d, 5d), new Complex(8d, 4d));
            var v = ov.swizzle.yxyx;
            Assert.That(new Complex(8d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(8d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, 5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(9.5d, 7.5d), new Complex(-1d, -1d));
            var v = ov.swizzle.yxyy;
            Assert.That(new Complex(-1d, -1d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, -1d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1d, -1d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(3d, -9d), new Complex(-7d, 0.0));
            var v = ov.swizzle.yy;
            Assert.That(new Complex(-7d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, 0.0), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec2(new Complex(-6.5d, 1.5d), new Complex(-9d, 0.0));
            var v = ov.swizzle.yyx;
            Assert.That(new Complex(-9d, 0.0), Is.EqualTo(v.x));
            Assert.That(new Complex(-9d, 0.0), Is.EqualTo(v.y));
            Assert.That(new Complex(-6.5d, 1.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(6d, 1.5d), new Complex(-7d, -9d));
            var v = ov.swizzle.yyxx;
            Assert.That(new Complex(-7d, -9d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, -9d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(-3.5d, -4d), new Complex(0.0, 5.5d));
            var v = ov.swizzle.yyxy;
            Assert.That(new Complex(0.0, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(0.0, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, -4d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, 5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(4d, -7.5d), new Complex(4.5d, -8d));
            var v = ov.swizzle.yyy;
            Assert.That(new Complex(4.5d, -8d), Is.EqualTo(v.x));
            Assert.That(new Complex(4.5d, -8d), Is.EqualTo(v.y));
            Assert.That(new Complex(4.5d, -8d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(-9d, -6d), new Complex(-7d, 1.5d));
            var v = ov.swizzle.yyyx;
            Assert.That(new Complex(-7d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7d, 1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9d, -6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(6d, 0.5d), new Complex(-7.5d, 4.5d));
            var v = ov.swizzle.yyyy;
            Assert.That(new Complex(-7.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 4.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7.5d, 4.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-7.5d, 4.5d), Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new cvec2(new Complex(-4.5d, -2d), new Complex(-8.5d, -1.5d));
            var v = ov.swizzle.rr;
            Assert.That(new Complex(-4.5d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-4.5d, -2d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec2(new Complex(6.5d, 5.5d), new Complex(-7d, -4.5d));
            var v = ov.swizzle.rrr;
            Assert.That(new Complex(6.5d, 5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, 5.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(6d, 3.5d), new Complex(-6.5d, 0.0));
            var v = ov.swizzle.rrrr;
            Assert.That(new Complex(6d, 3.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 3.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6d, 3.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, 3.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(6.5d, -7.5d), new Complex(6d, -5.5d));
            var v = ov.swizzle.rrrg;
            Assert.That(new Complex(6.5d, -7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, -7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, -7.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(8.5d, -9.5d), new Complex(-7d, 1.5d));
            var v = ov.swizzle.rrg;
            Assert.That(new Complex(8.5d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, -9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-7d, 1.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(-1.5d, 0.5d), new Complex(-8d, -7d));
            var v = ov.swizzle.rrgr;
            Assert.That(new Complex(-1.5d, 0.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, 0.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8d, -7d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, 0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(-1d, -2d), new Complex(5d, 2.5d));
            var v = ov.swizzle.rrgg;
            Assert.That(new Complex(-1d, -2d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, -2d), Is.EqualTo(v.y));
            Assert.That(new Complex(5d, 2.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(5d, 2.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(7.5d, 4d), new Complex(2.5d, 4.5d));
            var v = ov.swizzle.rg;
            Assert.That(new Complex(7.5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(2.5d, 4.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec2(new Complex(3d, -9.5d), new Complex(4d, -2.5d));
            var v = ov.swizzle.rgr;
            Assert.That(new Complex(3d, -9.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(4d, -2.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(3d, -9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(-9.5d, 1.5d), new Complex(-7.5d, -7d));
            var v = ov.swizzle.rgrr;
            Assert.That(new Complex(-9.5d, 1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, -7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, 1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(-9.5d, 1.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(-3.5d, 4d), new Complex(-1.5d, -5.5d));
            var v = ov.swizzle.rgrg;
            Assert.That(new Complex(-3.5d, 4d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1.5d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-3.5d, 4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-1.5d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(-5.5d, -3d), new Complex(-1d, 9.5d));
            var v = ov.swizzle.rgg;
            Assert.That(new Complex(-5.5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-1d, 9.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-1d, 9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(-3.5d, -6.5d), new Complex(-5.5d, 7d));
            var v = ov.swizzle.rggr;
            Assert.That(new Complex(-3.5d, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-5.5d, 7d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3.5d, -6.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(6.5d, 4.5d), new Complex(8.5d, 6d));
            var v = ov.swizzle.rggg;
            Assert.That(new Complex(6.5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(8.5d, 6d), Is.EqualTo(v.y));
            Assert.That(new Complex(8.5d, 6d), Is.EqualTo(v.z));
            Assert.That(new Complex(8.5d, 6d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(-5d, -2.5d), new Complex(-3.5d, 2.5d));
            var v = ov.swizzle.gr;
            Assert.That(new Complex(-3.5d, 2.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-5d, -2.5d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec2(new Complex(-8.5d, 5.5d), new Complex(-5d, 4.5d));
            var v = ov.swizzle.grr;
            Assert.That(new Complex(-5d, 4.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-8.5d, 5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-8.5d, 5.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(9d, -5.5d), new Complex(3d, 1.0));
            var v = ov.swizzle.grrr;
            Assert.That(new Complex(3d, 1.0), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, -5.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9d, -5.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(9d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(-0.5d, -3d), new Complex(-8.5d, -5.5d));
            var v = ov.swizzle.grrg;
            Assert.That(new Complex(-8.5d, -5.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, -3d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, -3d), Is.EqualTo(v.z));
            Assert.That(new Complex(-8.5d, -5.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(-7.5d, 5d), new Complex(1.0, -6.5d));
            var v = ov.swizzle.grg;
            Assert.That(new Complex(1.0, -6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-7.5d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(1.0, -6.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(6d, 5d), new Complex(4d, 6.5d));
            var v = ov.swizzle.grgr;
            Assert.That(new Complex(4d, 6.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(4d, 6.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6d, 5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(6.5d, 7d), new Complex(-4d, 9d));
            var v = ov.swizzle.grgg;
            Assert.That(new Complex(-4d, 9d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(-4d, 9d), Is.EqualTo(v.z));
            Assert.That(new Complex(-4d, 9d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(-3d, -1d), new Complex(-9.5d, -3d));
            var v = ov.swizzle.gg;
            Assert.That(new Complex(-9.5d, -3d), Is.EqualTo(v.x));
            Assert.That(new Complex(-9.5d, -3d), Is.EqualTo(v.y));
        }
        {
            var ov = new cvec2(new Complex(-9.5d, -9.5d), new Complex(7d, 5d));
            var v = ov.swizzle.ggr;
            Assert.That(new Complex(7d, 5d), Is.EqualTo(v.x));
            Assert.That(new Complex(7d, 5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-9.5d, -9.5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(0.0, -0.5d), new Complex(9d, 7d));
            var v = ov.swizzle.ggrr;
            Assert.That(new Complex(9d, 7d), Is.EqualTo(v.x));
            Assert.That(new Complex(9d, 7d), Is.EqualTo(v.y));
            Assert.That(new Complex(0.0, -0.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(0.0, -0.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(2.5d, -4d), new Complex(-3.5d, 7.5d));
            var v = ov.swizzle.ggrg;
            Assert.That(new Complex(-3.5d, 7.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-3.5d, 7.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(2.5d, -4d), Is.EqualTo(v.z));
            Assert.That(new Complex(-3.5d, 7.5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(-8.5d, 2.5d), new Complex(-0.5d, -5d));
            var v = ov.swizzle.ggg;
            Assert.That(new Complex(-0.5d, -5d), Is.EqualTo(v.x));
            Assert.That(new Complex(-0.5d, -5d), Is.EqualTo(v.y));
            Assert.That(new Complex(-0.5d, -5d), Is.EqualTo(v.z));
        }
        {
            var ov = new cvec2(new Complex(4.5d, -5d), new Complex(9.5d, 8.5d));
            var v = ov.swizzle.gggr;
            Assert.That(new Complex(9.5d, 8.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(9.5d, 8.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(9.5d, 8.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(4.5d, -5d), Is.EqualTo(v.w));
        }
        {
            var ov = new cvec2(new Complex(6.5d, 2.5d), new Complex(6.5d, -1.5d));
            var v = ov.swizzle.gggg;
            Assert.That(new Complex(6.5d, -1.5d), Is.EqualTo(v.x));
            Assert.That(new Complex(6.5d, -1.5d), Is.EqualTo(v.y));
            Assert.That(new Complex(6.5d, -1.5d), Is.EqualTo(v.z));
            Assert.That(new Complex(6.5d, -1.5d), Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new cvec2(new Complex(9.5d, 2.5d), new Complex(-7.5d, 5.5d));
            var v1 = new cvec2(new Complex(-3.5d, 6d), new Complex(-5d, -2d));
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-3.5d, 6d), Is.EqualTo(v0.x));
            Assert.That(new Complex(-5d, -2d), Is.EqualTo(v0.y));
        
            Assert.That(new Complex(9.5d, 2.5d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-7.5d, 5.5d), Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new cvec2(new Complex(-3d, -3.5d), new Complex(5.5d, 5d));
            var v1 = new Complex(-1.5d, -8.5d);
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(-1.5d, -8.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(5.5d, 5d), Is.EqualTo(v0.y));
        
            Assert.That(new Complex(-3d, -3.5d), Is.EqualTo(v2));
        }
        {
            var v0 = new cvec2(new Complex(2d, 0.5d), new Complex(2d, 2.5d));
            var v1 = new Complex(9.5d, -6.5d);
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(2d, 0.5d), Is.EqualTo(v0.x));
            Assert.That(new Complex(9.5d, -6.5d), Is.EqualTo(v0.y));
        
            Assert.That(new Complex(2d, 2.5d), Is.EqualTo(v2));
        }
        {
            var v0 = new cvec2(new Complex(6.5d, 6d), new Complex(-5.5d, -9.5d));
            var v1 = new cvec2(new Complex(0.0, -4d), new Complex(9.5d, 6d));
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(new Complex(0.0, -4d), Is.EqualTo(v0.x));
            Assert.That(new Complex(9.5d, 6d), Is.EqualTo(v0.y));
        
            Assert.That(new Complex(6.5d, 6d), Is.EqualTo(v2.x));
            Assert.That(new Complex(-5.5d, -9.5d), Is.EqualTo(v2.y));
        }
    }

}
