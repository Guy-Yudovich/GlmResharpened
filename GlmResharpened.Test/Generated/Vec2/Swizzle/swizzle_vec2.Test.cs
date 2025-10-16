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
            var ov = new vec2(-6f, 6f);
            var v = ov.swizzle.xx;
            Assert.That(-6f, Is.EqualTo(v.x));
            Assert.That(-6f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(0.5f, 1f);
            var v = ov.swizzle.xxx;
            Assert.That(0.5f, Is.EqualTo(v.x));
            Assert.That(0.5f, Is.EqualTo(v.y));
            Assert.That(0.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(2f, -3.5f);
            var v = ov.swizzle.xxxx;
            Assert.That(2f, Is.EqualTo(v.x));
            Assert.That(2f, Is.EqualTo(v.y));
            Assert.That(2f, Is.EqualTo(v.z));
            Assert.That(2f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(2.5f, 9f);
            var v = ov.swizzle.xxxy;
            Assert.That(2.5f, Is.EqualTo(v.x));
            Assert.That(2.5f, Is.EqualTo(v.y));
            Assert.That(2.5f, Is.EqualTo(v.z));
            Assert.That(9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(1.5f, 9f);
            var v = ov.swizzle.xxy;
            Assert.That(1.5f, Is.EqualTo(v.x));
            Assert.That(1.5f, Is.EqualTo(v.y));
            Assert.That(9f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-6f, -6.5f);
            var v = ov.swizzle.xxyx;
            Assert.That(-6f, Is.EqualTo(v.x));
            Assert.That(-6f, Is.EqualTo(v.y));
            Assert.That(-6.5f, Is.EqualTo(v.z));
            Assert.That(-6f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(2f, 7.5f);
            var v = ov.swizzle.xxyy;
            Assert.That(2f, Is.EqualTo(v.x));
            Assert.That(2f, Is.EqualTo(v.y));
            Assert.That(7.5f, Is.EqualTo(v.z));
            Assert.That(7.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-8.5f, 0.5f);
            var v = ov.swizzle.xy;
            Assert.That(-8.5f, Is.EqualTo(v.x));
            Assert.That(0.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(3f, 0.5f);
            var v = ov.swizzle.xyx;
            Assert.That(3f, Is.EqualTo(v.x));
            Assert.That(0.5f, Is.EqualTo(v.y));
            Assert.That(3f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(4f, -7.5f);
            var v = ov.swizzle.xyxx;
            Assert.That(4f, Is.EqualTo(v.x));
            Assert.That(-7.5f, Is.EqualTo(v.y));
            Assert.That(4f, Is.EqualTo(v.z));
            Assert.That(4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(6.5f, -7.5f);
            var v = ov.swizzle.xyxy;
            Assert.That(6.5f, Is.EqualTo(v.x));
            Assert.That(-7.5f, Is.EqualTo(v.y));
            Assert.That(6.5f, Is.EqualTo(v.z));
            Assert.That(-7.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(4.5f, -4.5f);
            var v = ov.swizzle.xyy;
            Assert.That(4.5f, Is.EqualTo(v.x));
            Assert.That(-4.5f, Is.EqualTo(v.y));
            Assert.That(-4.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-8.5f, 3f);
            var v = ov.swizzle.xyyx;
            Assert.That(-8.5f, Is.EqualTo(v.x));
            Assert.That(3f, Is.EqualTo(v.y));
            Assert.That(3f, Is.EqualTo(v.z));
            Assert.That(-8.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-6.5f, 2f);
            var v = ov.swizzle.xyyy;
            Assert.That(-6.5f, Is.EqualTo(v.x));
            Assert.That(2f, Is.EqualTo(v.y));
            Assert.That(2f, Is.EqualTo(v.z));
            Assert.That(2f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(0.5f, 4f);
            var v = ov.swizzle.yx;
            Assert.That(4f, Is.EqualTo(v.x));
            Assert.That(0.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(-9f, -3f);
            var v = ov.swizzle.yxx;
            Assert.That(-3f, Is.EqualTo(v.x));
            Assert.That(-9f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-1.5f, -9.5f);
            var v = ov.swizzle.yxxx;
            Assert.That(-9.5f, Is.EqualTo(v.x));
            Assert.That(-1.5f, Is.EqualTo(v.y));
            Assert.That(-1.5f, Is.EqualTo(v.z));
            Assert.That(-1.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-0.5f, 1f);
            var v = ov.swizzle.yxxy;
            Assert.That(1f, Is.EqualTo(v.x));
            Assert.That(-0.5f, Is.EqualTo(v.y));
            Assert.That(-0.5f, Is.EqualTo(v.z));
            Assert.That(1f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(6.5f, -9f);
            var v = ov.swizzle.yxy;
            Assert.That(-9f, Is.EqualTo(v.x));
            Assert.That(6.5f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(6f, 7f);
            var v = ov.swizzle.yxyx;
            Assert.That(7f, Is.EqualTo(v.x));
            Assert.That(6f, Is.EqualTo(v.y));
            Assert.That(7f, Is.EqualTo(v.z));
            Assert.That(6f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-5.5f, 5f);
            var v = ov.swizzle.yxyy;
            Assert.That(5f, Is.EqualTo(v.x));
            Assert.That(-5.5f, Is.EqualTo(v.y));
            Assert.That(5f, Is.EqualTo(v.z));
            Assert.That(5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(8.5f, 3.5f);
            var v = ov.swizzle.yy;
            Assert.That(3.5f, Is.EqualTo(v.x));
            Assert.That(3.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(3.5f, -6f);
            var v = ov.swizzle.yyx;
            Assert.That(-6f, Is.EqualTo(v.x));
            Assert.That(-6f, Is.EqualTo(v.y));
            Assert.That(3.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-2f, 7.5f);
            var v = ov.swizzle.yyxx;
            Assert.That(7.5f, Is.EqualTo(v.x));
            Assert.That(7.5f, Is.EqualTo(v.y));
            Assert.That(-2f, Is.EqualTo(v.z));
            Assert.That(-2f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(0.5f, -3f);
            var v = ov.swizzle.yyxy;
            Assert.That(-3f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(0.5f, Is.EqualTo(v.z));
            Assert.That(-3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-0.5f, 5f);
            var v = ov.swizzle.yyy;
            Assert.That(5f, Is.EqualTo(v.x));
            Assert.That(5f, Is.EqualTo(v.y));
            Assert.That(5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(6f, -5.5f);
            var v = ov.swizzle.yyyx;
            Assert.That(-5.5f, Is.EqualTo(v.x));
            Assert.That(-5.5f, Is.EqualTo(v.y));
            Assert.That(-5.5f, Is.EqualTo(v.z));
            Assert.That(6f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(7.5f, 3.5f);
            var v = ov.swizzle.yyyy;
            Assert.That(3.5f, Is.EqualTo(v.x));
            Assert.That(3.5f, Is.EqualTo(v.y));
            Assert.That(3.5f, Is.EqualTo(v.z));
            Assert.That(3.5f, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new vec2(0f, -9.5f);
            var v = ov.swizzle.rr;
            Assert.That(0f, Is.EqualTo(v.x));
            Assert.That(0f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(6f, 3.5f);
            var v = ov.swizzle.rrr;
            Assert.That(6f, Is.EqualTo(v.x));
            Assert.That(6f, Is.EqualTo(v.y));
            Assert.That(6f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(4f, -9f);
            var v = ov.swizzle.rrrr;
            Assert.That(4f, Is.EqualTo(v.x));
            Assert.That(4f, Is.EqualTo(v.y));
            Assert.That(4f, Is.EqualTo(v.z));
            Assert.That(4f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(9f, -7.5f);
            var v = ov.swizzle.rrrg;
            Assert.That(9f, Is.EqualTo(v.x));
            Assert.That(9f, Is.EqualTo(v.y));
            Assert.That(9f, Is.EqualTo(v.z));
            Assert.That(-7.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-8.5f, -6.5f);
            var v = ov.swizzle.rrg;
            Assert.That(-8.5f, Is.EqualTo(v.x));
            Assert.That(-8.5f, Is.EqualTo(v.y));
            Assert.That(-6.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-9f, 0.5f);
            var v = ov.swizzle.rrgr;
            Assert.That(-9f, Is.EqualTo(v.x));
            Assert.That(-9f, Is.EqualTo(v.y));
            Assert.That(0.5f, Is.EqualTo(v.z));
            Assert.That(-9f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-7.5f, 9.5f);
            var v = ov.swizzle.rrgg;
            Assert.That(-7.5f, Is.EqualTo(v.x));
            Assert.That(-7.5f, Is.EqualTo(v.y));
            Assert.That(9.5f, Is.EqualTo(v.z));
            Assert.That(9.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-7f, -4.5f);
            var v = ov.swizzle.rg;
            Assert.That(-7f, Is.EqualTo(v.x));
            Assert.That(-4.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(6f, 6f);
            var v = ov.swizzle.rgr;
            Assert.That(6f, Is.EqualTo(v.x));
            Assert.That(6f, Is.EqualTo(v.y));
            Assert.That(6f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-7f, 9f);
            var v = ov.swizzle.rgrr;
            Assert.That(-7f, Is.EqualTo(v.x));
            Assert.That(9f, Is.EqualTo(v.y));
            Assert.That(-7f, Is.EqualTo(v.z));
            Assert.That(-7f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(3.5f, -1.5f);
            var v = ov.swizzle.rgrg;
            Assert.That(3.5f, Is.EqualTo(v.x));
            Assert.That(-1.5f, Is.EqualTo(v.y));
            Assert.That(3.5f, Is.EqualTo(v.z));
            Assert.That(-1.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-4.5f, -9f);
            var v = ov.swizzle.rgg;
            Assert.That(-4.5f, Is.EqualTo(v.x));
            Assert.That(-9f, Is.EqualTo(v.y));
            Assert.That(-9f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(1f, -4f);
            var v = ov.swizzle.rggr;
            Assert.That(1f, Is.EqualTo(v.x));
            Assert.That(-4f, Is.EqualTo(v.y));
            Assert.That(-4f, Is.EqualTo(v.z));
            Assert.That(1f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(7.5f, -1f);
            var v = ov.swizzle.rggg;
            Assert.That(7.5f, Is.EqualTo(v.x));
            Assert.That(-1f, Is.EqualTo(v.y));
            Assert.That(-1f, Is.EqualTo(v.z));
            Assert.That(-1f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(3f, 1f);
            var v = ov.swizzle.gr;
            Assert.That(1f, Is.EqualTo(v.x));
            Assert.That(3f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(-4.5f, 0f);
            var v = ov.swizzle.grr;
            Assert.That(0f, Is.EqualTo(v.x));
            Assert.That(-4.5f, Is.EqualTo(v.y));
            Assert.That(-4.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-8f, -0.5f);
            var v = ov.swizzle.grrr;
            Assert.That(-0.5f, Is.EqualTo(v.x));
            Assert.That(-8f, Is.EqualTo(v.y));
            Assert.That(-8f, Is.EqualTo(v.z));
            Assert.That(-8f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(4.5f, -3f);
            var v = ov.swizzle.grrg;
            Assert.That(-3f, Is.EqualTo(v.x));
            Assert.That(4.5f, Is.EqualTo(v.y));
            Assert.That(4.5f, Is.EqualTo(v.z));
            Assert.That(-3f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(3.5f, 8f);
            var v = ov.swizzle.grg;
            Assert.That(8f, Is.EqualTo(v.x));
            Assert.That(3.5f, Is.EqualTo(v.y));
            Assert.That(8f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(-6f, 3f);
            var v = ov.swizzle.grgr;
            Assert.That(3f, Is.EqualTo(v.x));
            Assert.That(-6f, Is.EqualTo(v.y));
            Assert.That(3f, Is.EqualTo(v.z));
            Assert.That(-6f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(2f, -3.5f);
            var v = ov.swizzle.grgg;
            Assert.That(-3.5f, Is.EqualTo(v.x));
            Assert.That(2f, Is.EqualTo(v.y));
            Assert.That(-3.5f, Is.EqualTo(v.z));
            Assert.That(-3.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(9f, 5.5f);
            var v = ov.swizzle.gg;
            Assert.That(5.5f, Is.EqualTo(v.x));
            Assert.That(5.5f, Is.EqualTo(v.y));
        }
        {
            var ov = new vec2(-2f, -8.5f);
            var v = ov.swizzle.ggr;
            Assert.That(-8.5f, Is.EqualTo(v.x));
            Assert.That(-8.5f, Is.EqualTo(v.y));
            Assert.That(-2f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(3.5f, -4f);
            var v = ov.swizzle.ggrr;
            Assert.That(-4f, Is.EqualTo(v.x));
            Assert.That(-4f, Is.EqualTo(v.y));
            Assert.That(3.5f, Is.EqualTo(v.z));
            Assert.That(3.5f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-4.5f, -6f);
            var v = ov.swizzle.ggrg;
            Assert.That(-6f, Is.EqualTo(v.x));
            Assert.That(-6f, Is.EqualTo(v.y));
            Assert.That(-4.5f, Is.EqualTo(v.z));
            Assert.That(-6f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-2.5f, 6.5f);
            var v = ov.swizzle.ggg;
            Assert.That(6.5f, Is.EqualTo(v.x));
            Assert.That(6.5f, Is.EqualTo(v.y));
            Assert.That(6.5f, Is.EqualTo(v.z));
        }
        {
            var ov = new vec2(1f, -7f);
            var v = ov.swizzle.gggr;
            Assert.That(-7f, Is.EqualTo(v.x));
            Assert.That(-7f, Is.EqualTo(v.y));
            Assert.That(-7f, Is.EqualTo(v.z));
            Assert.That(1f, Is.EqualTo(v.w));
        }
        {
            var ov = new vec2(-4.5f, -3f);
            var v = ov.swizzle.gggg;
            Assert.That(-3f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
            Assert.That(-3f, Is.EqualTo(v.z));
            Assert.That(-3f, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new vec2(3f, 3f);
            var v1 = new vec2(6.5f, 4.5f);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(6.5f, Is.EqualTo(v0.x));
            Assert.That(4.5f, Is.EqualTo(v0.y));
        
            Assert.That(3f, Is.EqualTo(v2.x));
            Assert.That(3f, Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            vec2 v0 = new vec2(-6.5f, 8f);
            float v1 = -2f;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-2f, Is.EqualTo(v0.x));
            Assert.That(8f, Is.EqualTo(v0.y));
        
            Assert.That(-6.5f, Is.EqualTo(v2));
        }
        {
            vec2 v0 = new vec2(8.5f, 9f);
            float v1 = 0.5f;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(8.5f, Is.EqualTo(v0.x));
            Assert.That(0.5f, Is.EqualTo(v0.y));
        
            Assert.That(9f, Is.EqualTo(v2));
        }
        {
            vec2 v0 = new vec2(5f, 0.5f);
            vec2 v1 = new vec2(-2.5f, -3.5f);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-2.5f, Is.EqualTo(v0.x));
            Assert.That(-3.5f, Is.EqualTo(v0.y));
        
            Assert.That(5f, Is.EqualTo(v2.x));
            Assert.That(0.5f, Is.EqualTo(v2.y));
        }
    }

}
