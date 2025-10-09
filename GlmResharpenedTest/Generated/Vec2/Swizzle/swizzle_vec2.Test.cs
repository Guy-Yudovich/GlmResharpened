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
public class FloatSwizzleVec2Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new vec2(3f, 1f);
            var v = ov.swizzle.xx;
            Assert.That(3f, Is.EqualTo(v.x));
            Assert.That(3f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(-5f, -0.5f);
            var v = ov.swizzle.xxx;
            Assert.That(-5f, Is.EqualTo(v.x));
            Assert.That(-5f, Is.EqualTo(v.y));
            Assert.That(-5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(2f, 9.5f);
            var v = ov.swizzle.xxxx;
            Assert.That(2f, Is.EqualTo(v.x));
            Assert.That(2f, Is.EqualTo(v.y));
            Assert.That(2f, Is.EqualTo(v.z));
            Assert.That(2f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-0.5f, -1.5f);
            var v = ov.swizzle.xxxy;
            Assert.That(-0.5f, Is.EqualTo(v.x));
            Assert.That(-0.5f, Is.EqualTo(v.y));
            Assert.That(-0.5f, Is.EqualTo(v.z));
            Assert.That(-1.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-8f, -2f);
            var v = ov.swizzle.xxy;
            Assert.That(-8f, Is.EqualTo(v.x));
            Assert.That(-8f, Is.EqualTo(v.y));
            Assert.That(-2f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-4f, -1.5f);
            var v = ov.swizzle.xxyx;
            Assert.That(-4f, Is.EqualTo(v.x));
            Assert.That(-4f, Is.EqualTo(v.y));
            Assert.That(-1.5f, Is.EqualTo(v.z));
            Assert.That(-4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-9.5f, -1.5f);
            var v = ov.swizzle.xxyy;
            Assert.That(-9.5f, Is.EqualTo(v.x));
            Assert.That(-9.5f, Is.EqualTo(v.y));
            Assert.That(-1.5f, Is.EqualTo(v.z));
            Assert.That(-1.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(7.5f, -4f);
            var v = ov.swizzle.xy;
            Assert.That(7.5f, Is.EqualTo(v.x));
            Assert.That(-4f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(-9f, 8f);
            var v = ov.swizzle.xyx;
            Assert.That(-9f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(4.5f, 7.5f);
            var v = ov.swizzle.xyxx;
            Assert.That(4.5f, Is.EqualTo(v.x));
            Assert.That(7.5f, Is.EqualTo(v.y));
            Assert.That(4.5f, Is.EqualTo(v.z));
            Assert.That(4.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(7.5f, 4f);
            var v = ov.swizzle.xyxy;
            Assert.That(7.5f, Is.EqualTo(v.x));
            Assert.That(4f, Is.EqualTo(v.y));
            Assert.That(7.5f, Is.EqualTo(v.z));
            Assert.That(4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-1.5f, -5f);
            var v = ov.swizzle.xyy;
            Assert.That(-1.5f, Is.EqualTo(v.x));
            Assert.That(-5f, Is.EqualTo(v.y));
            Assert.That(-5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-2.5f, -8f);
            var v = ov.swizzle.xyyx;
            Assert.That(-2.5f, Is.EqualTo(v.x));
            Assert.That(-8f, Is.EqualTo(v.y));
            Assert.That(-8f, Is.EqualTo(v.z));
            Assert.That(-2.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(8f, 5f);
            var v = ov.swizzle.xyyy;
            Assert.That(8f, Is.EqualTo(v.x));
            Assert.That(5f, Is.EqualTo(v.y));
            Assert.That(5f, Is.EqualTo(v.z));
            Assert.That(5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-6f, -2.5f);
            var v = ov.swizzle.yx;
            Assert.That(-2.5f, Is.EqualTo(v.x));
            Assert.That(-6f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(1f, 7.5f);
            var v = ov.swizzle.yxx;
            Assert.That(7.5f, Is.EqualTo(v.x));
            Assert.That(1f, Is.EqualTo(v.y));
            Assert.That(1f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(0.5f, -6f);
            var v = ov.swizzle.yxxx;
            Assert.That(-6f, Is.EqualTo(v.x));
            Assert.That(0.5f, Is.EqualTo(v.y));
            Assert.That(0.5f, Is.EqualTo(v.z));
            Assert.That(0.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-2f, -9f);
            var v = ov.swizzle.yxxy;
            Assert.That(-9f, Is.EqualTo(v.x));
            Assert.That(-2f, Is.EqualTo(v.y));
            Assert.That(-2f, Is.EqualTo(v.z));
            Assert.That(-9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-3.5f, -8f);
            var v = ov.swizzle.yxy;
            Assert.That(-8f, Is.EqualTo(v.x));
            Assert.That(-3.5f, Is.EqualTo(v.y));
            Assert.That(-8f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-3f, 0.5f);
            var v = ov.swizzle.yxyx;
            Assert.That(0.5f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(0.5f, Is.EqualTo(v.z));
            Assert.That(-3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(8f, -5.5f);
            var v = ov.swizzle.yxyy;
            Assert.That(-5.5f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
            Assert.That(-5.5f, Is.EqualTo(v.z));
            Assert.That(-5.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(3f, -7.5f);
            var v = ov.swizzle.yy;
            Assert.That(-7.5f, Is.EqualTo(v.x));
            Assert.That(-7.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(8.5f, 7.5f);
            var v = ov.swizzle.yyx;
            Assert.That(7.5f, Is.EqualTo(v.x));
            Assert.That(7.5f, Is.EqualTo(v.y));
            Assert.That(8.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-7f, -0.5f);
            var v = ov.swizzle.yyxx;
            Assert.That(-0.5f, Is.EqualTo(v.x));
            Assert.That(-0.5f, Is.EqualTo(v.y));
            Assert.That(-7f, Is.EqualTo(v.z));
            Assert.That(-7f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-6.5f, -4f);
            var v = ov.swizzle.yyxy;
            Assert.That(-4f, Is.EqualTo(v.x));
            Assert.That(-4f, Is.EqualTo(v.y));
            Assert.That(-6.5f, Is.EqualTo(v.z));
            Assert.That(-4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(5f, -9f);
            var v = ov.swizzle.yyy;
            Assert.That(-9f, Is.EqualTo(v.x));
            Assert.That(-9f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(6f, -9f);
            var v = ov.swizzle.yyyx;
            Assert.That(-9f, Is.EqualTo(v.x));
            Assert.That(-9f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
            Assert.That(6f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-9.5f, 8.5f);
            var v = ov.swizzle.yyyy;
            Assert.That(8.5f, Is.EqualTo(v.x));
            Assert.That(8.5f, Is.EqualTo(v.y));
            Assert.That(8.5f, Is.EqualTo(v.z));
            Assert.That(8.5f, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new vec2(6.5f, 6.5f);
            var v = ov.swizzle.rr;
            Assert.That(6.5f, Is.EqualTo(v.x));
            Assert.That(6.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(3.5f, 9f);
            var v = ov.swizzle.rrr;
            Assert.That(3.5f, Is.EqualTo(v.x));
            Assert.That(3.5f, Is.EqualTo(v.y));
            Assert.That(3.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-3f, -2.5f);
            var v = ov.swizzle.rrrr;
            Assert.That(-3f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(-3f, Is.EqualTo(v.z));
            Assert.That(-3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(0.5f, 9f);
            var v = ov.swizzle.rrrg;
            Assert.That(0.5f, Is.EqualTo(v.x));
            Assert.That(0.5f, Is.EqualTo(v.y));
            Assert.That(0.5f, Is.EqualTo(v.z));
            Assert.That(9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(6.5f, -5f);
            var v = ov.swizzle.rrg;
            Assert.That(6.5f, Is.EqualTo(v.x));
            Assert.That(6.5f, Is.EqualTo(v.y));
            Assert.That(-5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-3f, -9.5f);
            var v = ov.swizzle.rrgr;
            Assert.That(-3f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(-9.5f, Is.EqualTo(v.z));
            Assert.That(-3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(8f, 0f);
            var v = ov.swizzle.rrgg;
            Assert.That(8f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
            Assert.That(0f, Is.EqualTo(v.z));
            Assert.That(0f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(4.5f, 0.5f);
            var v = ov.swizzle.rg;
            Assert.That(4.5f, Is.EqualTo(v.x));
            Assert.That(0.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(0f, 7f);
            var v = ov.swizzle.rgr;
            Assert.That(0f, Is.EqualTo(v.x));
            Assert.That(7f, Is.EqualTo(v.y));
            Assert.That(0f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-0.5f, 0f);
            var v = ov.swizzle.rgrr;
            Assert.That(-0.5f, Is.EqualTo(v.x));
            Assert.That(0f, Is.EqualTo(v.y));
            Assert.That(-0.5f, Is.EqualTo(v.z));
            Assert.That(-0.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-9.5f, -8f);
            var v = ov.swizzle.rgrg;
            Assert.That(-9.5f, Is.EqualTo(v.x));
            Assert.That(-8f, Is.EqualTo(v.y));
            Assert.That(-9.5f, Is.EqualTo(v.z));
            Assert.That(-8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-9.5f, -9f);
            var v = ov.swizzle.rgg;
            Assert.That(-9.5f, Is.EqualTo(v.x));
            Assert.That(-9f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(3f, 1.5f);
            var v = ov.swizzle.rggr;
            Assert.That(3f, Is.EqualTo(v.x));
            Assert.That(1.5f, Is.EqualTo(v.y));
            Assert.That(1.5f, Is.EqualTo(v.z));
            Assert.That(3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-3.5f, -6.5f);
            var v = ov.swizzle.rggg;
            Assert.That(-3.5f, Is.EqualTo(v.x));
            Assert.That(-6.5f, Is.EqualTo(v.y));
            Assert.That(-6.5f, Is.EqualTo(v.z));
            Assert.That(-6.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-6.5f, 7.5f);
            var v = ov.swizzle.gr;
            Assert.That(7.5f, Is.EqualTo(v.x));
            Assert.That(-6.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(-2f, 5f);
            var v = ov.swizzle.grr;
            Assert.That(5f, Is.EqualTo(v.x));
            Assert.That(-2f, Is.EqualTo(v.y));
            Assert.That(-2f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(2f, 3f);
            var v = ov.swizzle.grrr;
            Assert.That(3f, Is.EqualTo(v.x));
            Assert.That(2f, Is.EqualTo(v.y));
            Assert.That(2f, Is.EqualTo(v.z));
            Assert.That(2f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-8.5f, -0.5f);
            var v = ov.swizzle.grrg;
            Assert.That(-0.5f, Is.EqualTo(v.x));
            Assert.That(-8.5f, Is.EqualTo(v.y));
            Assert.That(-8.5f, Is.EqualTo(v.z));
            Assert.That(-0.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(8f, -3.5f);
            var v = ov.swizzle.grg;
            Assert.That(-3.5f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
            Assert.That(-3.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-9f, 2.5f);
            var v = ov.swizzle.grgr;
            Assert.That(2.5f, Is.EqualTo(v.x));
            Assert.That(-9f, Is.EqualTo(v.y));
            Assert.That(2.5f, Is.EqualTo(v.z));
            Assert.That(-9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-5f, 8.5f);
            var v = ov.swizzle.grgg;
            Assert.That(8.5f, Is.EqualTo(v.x));
            Assert.That(-5f, Is.EqualTo(v.y));
            Assert.That(8.5f, Is.EqualTo(v.z));
            Assert.That(8.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-2.5f, -2.5f);
            var v = ov.swizzle.gg;
            Assert.That(-2.5f, Is.EqualTo(v.x));
            Assert.That(-2.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(5.5f, 3f);
            var v = ov.swizzle.ggr;
            Assert.That(3f, Is.EqualTo(v.x));
            Assert.That(3f, Is.EqualTo(v.y));
            Assert.That(5.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-3.5f, 4f);
            var v = ov.swizzle.ggrr;
            Assert.That(4f, Is.EqualTo(v.x));
            Assert.That(4f, Is.EqualTo(v.y));
            Assert.That(-3.5f, Is.EqualTo(v.z));
            Assert.That(-3.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-9f, 4.5f);
            var v = ov.swizzle.ggrg;
            Assert.That(4.5f, Is.EqualTo(v.x));
            Assert.That(4.5f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
            Assert.That(4.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-3.5f, 3f);
            var v = ov.swizzle.ggg;
            Assert.That(3f, Is.EqualTo(v.x));
            Assert.That(3f, Is.EqualTo(v.y));
            Assert.That(3f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(0.5f, -0.5f);
            var v = ov.swizzle.gggr;
            Assert.That(-0.5f, Is.EqualTo(v.x));
            Assert.That(-0.5f, Is.EqualTo(v.y));
            Assert.That(-0.5f, Is.EqualTo(v.z));
            Assert.That(0.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(9.5f, -9f);
            var v = ov.swizzle.gggg;
            Assert.That(-9f, Is.EqualTo(v.x));
            Assert.That(-9f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
            Assert.That(-9f, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new vec2(-3.5f, -5.5f);
            var v1 = new vec2(-4.5f, -2f);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-4.5f, Is.EqualTo(v0.x));
            Assert.That(-2f, Is.EqualTo(v0.y));
        
            Assert.That(-3.5f, Is.EqualTo(v2.x));
            Assert.That(-5.5f, Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new vec2(9.5f, 6f);
            var v1 = -1.5f;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-1.5f, Is.EqualTo(v0.x));
            Assert.That(6f, Is.EqualTo(v0.y));
        
            Assert.That(9.5f, Is.EqualTo(v2));
        }
        {
            var v0 = new vec2(-6.5f, 2.5f);
            var v1 = -8.5f;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-6.5f, Is.EqualTo(v0.x));
            Assert.That(-8.5f, Is.EqualTo(v0.y));
        
            Assert.That(2.5f, Is.EqualTo(v2));
        }
        {
            var v0 = new vec2(5.5f, -3f);
            var v1 = new vec2(8.5f, 0f);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(8.5f, Is.EqualTo(v0.x));
            Assert.That(0f, Is.EqualTo(v0.y));
        
            Assert.That(5.5f, Is.EqualTo(v2.x));
            Assert.That(-3f, Is.EqualTo(v2.y));
        }
    }

}
