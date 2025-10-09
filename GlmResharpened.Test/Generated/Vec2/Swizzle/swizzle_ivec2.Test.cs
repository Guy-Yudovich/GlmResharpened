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
public class IntSwizzleVec2Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new ivec2(7, -5);
            var v = ov.swizzle.xx;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec2(-9, 7);
            var v = ov.swizzle.xxx;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(5, -5);
            var v = ov.swizzle.xxxx;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(4, 0);
            var v = ov.swizzle.xxxy;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-1, 8);
            var v = ov.swizzle.xxy;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(-6, 3);
            var v = ov.swizzle.xxyx;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-6, 5);
            var v = ov.swizzle.xxyy;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(9, -1);
            var v = ov.swizzle.xy;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec2(-3, -9);
            var v = ov.swizzle.xyx;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(-7, 5);
            var v = ov.swizzle.xyxx;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(1, 1);
            var v = ov.swizzle.xyxy;
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-7, -5);
            var v = ov.swizzle.xyy;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(-9, 4);
            var v = ov.swizzle.xyyx;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(8, 7);
            var v = ov.swizzle.xyyy;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(5, 9);
            var v = ov.swizzle.yx;
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec2(5, -1);
            var v = ov.swizzle.yxx;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(-2, 0);
            var v = ov.swizzle.yxxx;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(-2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(1, -7);
            var v = ov.swizzle.yxxy;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(-7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-3, 2);
            var v = ov.swizzle.yxy;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(-1, -4);
            var v = ov.swizzle.yxyx;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-8, -4);
            var v = ov.swizzle.yxyy;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-9, 5);
            var v = ov.swizzle.yy;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec2(-5, 6);
            var v = ov.swizzle.yyx;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(7, -8);
            var v = ov.swizzle.yyxx;
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-3, 0);
            var v = ov.swizzle.yyxy;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-3, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(7, 4);
            var v = ov.swizzle.yyy;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(4, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(-5, 8);
            var v = ov.swizzle.yyyx;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(2, 6);
            var v = ov.swizzle.yyyy;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new ivec2(-4, 8);
            var v = ov.swizzle.rr;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec2(-7, 5);
            var v = ov.swizzle.rrr;
            Assert.That(-7, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-7, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(-4, -6);
            var v = ov.swizzle.rrrr;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(-4, Is.EqualTo(v.z));
            Assert.That(-4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(2, 2);
            var v = ov.swizzle.rrrg;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(8, 8);
            var v = ov.swizzle.rrg;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(-3, -9);
            var v = ov.swizzle.rrgr;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(-3, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(7, 9);
            var v = ov.swizzle.rrgg;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(7, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
            Assert.That(9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(8, 9);
            var v = ov.swizzle.rg;
            Assert.That(8, Is.EqualTo(v.x));
            Assert.That(9, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec2(2, 1);
            var v = ov.swizzle.rgr;
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(7, 0);
            var v = ov.swizzle.rgrr;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-6, 4);
            var v = ov.swizzle.rgrg;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(4, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(4, 2);
            var v = ov.swizzle.rgg;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(4, 5);
            var v = ov.swizzle.rggr;
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(5, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(4, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-3, -5);
            var v = ov.swizzle.rggg;
            Assert.That(-3, Is.EqualTo(v.x));
            Assert.That(-5, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(-5, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-6, -9);
            var v = ov.swizzle.gr;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec2(8, 7);
            var v = ov.swizzle.grr;
            Assert.That(7, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(0, -2);
            var v = ov.swizzle.grrr;
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-6, -9);
            var v = ov.swizzle.grrg;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
            Assert.That(-9, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-8, -9);
            var v = ov.swizzle.grg;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(-6, 5);
            var v = ov.swizzle.grgr;
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
            Assert.That(-6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-3, 6);
            var v = ov.swizzle.grgg;
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(-3, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-2, -9);
            var v = ov.swizzle.gg;
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-9, Is.EqualTo(v.y));
        }
        {
            var ov = new ivec2(9, -4);
            var v = ov.swizzle.ggr;
            Assert.That(-4, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(9, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(6, 0);
            var v = ov.swizzle.ggrr;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-9, 0);
            var v = ov.swizzle.ggrg;
            Assert.That(0, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(2, -6);
            var v = ov.swizzle.ggg;
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
        }
        {
            var ov = new ivec2(7, -1);
            var v = ov.swizzle.gggr;
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(-1, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var ov = new ivec2(-6, 8);
            var v = ov.swizzle.gggg;
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
            var v0 = new ivec2(7, -2);
            var v1 = new ivec2(0, -8);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(0, Is.EqualTo(v0.x));
            Assert.That(-8, Is.EqualTo(v0.y));
        
            Assert.That(7, Is.EqualTo(v2.x));
            Assert.That(-2, Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new ivec2(0, -5);
            var v1 = -1;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-1, Is.EqualTo(v0.x));
            Assert.That(-5, Is.EqualTo(v0.y));
        
            Assert.That(0, Is.EqualTo(v2));
        }
        {
            var v0 = new ivec2(5, -7);
            var v1 = -7;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(5, Is.EqualTo(v0.x));
            Assert.That(-7, Is.EqualTo(v0.y));
        
            Assert.That(-7, Is.EqualTo(v2));
        }
        {
            var v0 = new ivec2(2, 4);
            var v1 = new ivec2(1, -7);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(1, Is.EqualTo(v0.x));
            Assert.That(-7, Is.EqualTo(v0.y));
        
            Assert.That(2, Is.EqualTo(v2.x));
            Assert.That(4, Is.EqualTo(v2.y));
        }
    }

}
