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
public class DoubleSwizzleVec2Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new dvec2(9.5d, 5.5d);
            var v = ov.swizzle.xx;
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec2(1.5d, -2.5d);
            var v = ov.swizzle.xxx;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(-4.5d, 8.5d);
            var v = ov.swizzle.xxxx;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-7d, 5d);
            var v = ov.swizzle.xxxy;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-8d, 6d);
            var v = ov.swizzle.xxy;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(8.5d, 5d);
            var v = ov.swizzle.xxyx;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-2d, -4.5d);
            var v = ov.swizzle.xxyy;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(-4.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-2.5d, 4d);
            var v = ov.swizzle.xy;
            Assert.That(-2.5d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec2(-2d, -4.5d);
            var v = ov.swizzle.xyx;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(8.5d, 3.5d);
            var v = ov.swizzle.xyxx;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(3.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(3d, -6d);
            var v = ov.swizzle.xyxy;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(9d, 5d);
            var v = ov.swizzle.xyy;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(7.5d, 0.0);
            var v = ov.swizzle.xyyx;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(0.0, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-4d, -5.5d);
            var v = ov.swizzle.xyyy;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-5.5d, -4d);
            var v = ov.swizzle.yx;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec2(-4.5d, -8d);
            var v = ov.swizzle.yxx;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(6d, -5.5d);
            var v = ov.swizzle.yxxx;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(6d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
            Assert.That(6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(4d, 1.5d);
            var v = ov.swizzle.yxxy;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(4d, Is.EqualTo(v.y));
            Assert.That(4d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(0.5d, 6d);
            var v = ov.swizzle.yxy;
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(5.5d, 9d);
            var v = ov.swizzle.yxyx;
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(3d, -8.5d);
            var v = ov.swizzle.yxyy;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(-8.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-5.5d, 7d);
            var v = ov.swizzle.yy;
            Assert.That(7d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec2(-2.5d, 6.5d);
            var v = ov.swizzle.yyx;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(-1d, 4.5d);
            var v = ov.swizzle.yyxx;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
            Assert.That(-1d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-8.5d, -3d);
            var v = ov.swizzle.yyxy;
            Assert.That(-3d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-8.5d, Is.EqualTo(v.z));
            Assert.That(-3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(0.0, -5d);
            var v = ov.swizzle.yyy;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(-6d, -3.5d);
            var v = ov.swizzle.yyyx;
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-3.5d, Is.EqualTo(v.z));
            Assert.That(-6d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-2.5d, -5.5d);
            var v = ov.swizzle.yyyy;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(-5.5d, Is.EqualTo(v.z));
            Assert.That(-5.5d, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new dvec2(-1.5d, -4.5d);
            var v = ov.swizzle.rr;
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec2(-2d, 8d);
            var v = ov.swizzle.rrr;
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(7.5d, -2d);
            var v = ov.swizzle.rrrr;
            Assert.That(7.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(7.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(8.5d, -7d);
            var v = ov.swizzle.rrrg;
            Assert.That(8.5d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(8.5d, Is.EqualTo(v.z));
            Assert.That(-7d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-8d, 7d);
            var v = ov.swizzle.rrg;
            Assert.That(-8d, Is.EqualTo(v.x));
            Assert.That(-8d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(6.5d, -6.5d);
            var v = ov.swizzle.rrgr;
            Assert.That(6.5d, Is.EqualTo(v.x));
            Assert.That(6.5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(6.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(5.5d, -9.5d);
            var v = ov.swizzle.rrgg;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(-9.5d, Is.EqualTo(v.z));
            Assert.That(-9.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-5.5d, -8.5d);
            var v = ov.swizzle.rg;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec2(-4.5d, -3.5d);
            var v = ov.swizzle.rgr;
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-3.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(1.5d, -5.5d);
            var v = ov.swizzle.rgrr;
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
            Assert.That(1.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-6.5d, -5d);
            var v = ov.swizzle.rgrg;
            Assert.That(-6.5d, Is.EqualTo(v.x));
            Assert.That(-5d, Is.EqualTo(v.y));
            Assert.That(-6.5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-5.5d, -2d);
            var v = ov.swizzle.rgg;
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(1.0, 7d);
            var v = ov.swizzle.rggr;
            Assert.That(1.0, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(7d, Is.EqualTo(v.z));
            Assert.That(1.0, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-8.5d, 9d);
            var v = ov.swizzle.rggg;
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-2.5d, 4.5d);
            var v = ov.swizzle.gr;
            Assert.That(4.5d, Is.EqualTo(v.x));
            Assert.That(-2.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec2(1.5d, 2d);
            var v = ov.swizzle.grr;
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(1.5d, Is.EqualTo(v.y));
            Assert.That(1.5d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(3d, -7d);
            var v = ov.swizzle.grrr;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(3d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(4.5d, 5.5d);
            var v = ov.swizzle.grrg;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(4.5d, Is.EqualTo(v.y));
            Assert.That(4.5d, Is.EqualTo(v.z));
            Assert.That(5.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-9.5d, -7d);
            var v = ov.swizzle.grg;
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(7.5d, 5.5d);
            var v = ov.swizzle.grgr;
            Assert.That(5.5d, Is.EqualTo(v.x));
            Assert.That(7.5d, Is.EqualTo(v.y));
            Assert.That(5.5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-7.5d, -5d);
            var v = ov.swizzle.grgg;
            Assert.That(-5d, Is.EqualTo(v.x));
            Assert.That(-7.5d, Is.EqualTo(v.y));
            Assert.That(-5d, Is.EqualTo(v.z));
            Assert.That(-5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-7.5d, -9.5d);
            var v = ov.swizzle.gg;
            Assert.That(-9.5d, Is.EqualTo(v.x));
            Assert.That(-9.5d, Is.EqualTo(v.y));
        }
        {
            var ov = new dvec2(-1d, -0.5d);
            var v = ov.swizzle.ggr;
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-0.5d, Is.EqualTo(v.y));
            Assert.That(-1d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(9d, -1d);
            var v = ov.swizzle.ggrr;
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(-1d, Is.EqualTo(v.y));
            Assert.That(9d, Is.EqualTo(v.z));
            Assert.That(9d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(2.5d, 0.5d);
            var v = ov.swizzle.ggrg;
            Assert.That(0.5d, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
            Assert.That(2.5d, Is.EqualTo(v.z));
            Assert.That(0.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-5.5d, 3d);
            var v = ov.swizzle.ggg;
            Assert.That(3d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
        }
        {
            var ov = new dvec2(7.5d, 5d);
            var v = ov.swizzle.gggr;
            Assert.That(5d, Is.EqualTo(v.x));
            Assert.That(5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(7.5d, Is.EqualTo(v.w));
        }
        {
            var ov = new dvec2(-4d, -4d);
            var v = ov.swizzle.gggg;
            Assert.That(-4d, Is.EqualTo(v.x));
            Assert.That(-4d, Is.EqualTo(v.y));
            Assert.That(-4d, Is.EqualTo(v.z));
            Assert.That(-4d, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new dvec2(-4.5d, 5d);
            var v1 = new dvec2(-5.5d, -3.5d);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-5.5d, Is.EqualTo(v0.x));
            Assert.That(-3.5d, Is.EqualTo(v0.y));
        
            Assert.That(-4.5d, Is.EqualTo(v2.x));
            Assert.That(5d, Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new dvec2(0.0, -1d);
            var v1 = -8.5d;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-8.5d, Is.EqualTo(v0.x));
            Assert.That(-1d, Is.EqualTo(v0.y));
        
            Assert.That(0.0, Is.EqualTo(v2));
        }
        {
            var v0 = new dvec2(-6.5d, 1.0);
            var v1 = 5.5d;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-6.5d, Is.EqualTo(v0.x));
            Assert.That(5.5d, Is.EqualTo(v0.y));
        
            Assert.That(1.0, Is.EqualTo(v2));
        }
        {
            var v0 = new dvec2(9.5d, 9.5d);
            var v1 = new dvec2(-6d, -3.5d);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-6d, Is.EqualTo(v0.x));
            Assert.That(-3.5d, Is.EqualTo(v0.y));
        
            Assert.That(9.5d, Is.EqualTo(v2.x));
            Assert.That(9.5d, Is.EqualTo(v2.y));
        }
    }

}
