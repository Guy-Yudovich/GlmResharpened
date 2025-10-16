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
public class UintSwizzleVec2Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new uvec2(0u, 3u);
            var v = ov.swizzle.xx;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec2(1u, 8u);
            var v = ov.swizzle.xxx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(6u, 3u);
            var v = ov.swizzle.xxxx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(3u, 0u);
            var v = ov.swizzle.xxxy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(1u, 1u);
            var v = ov.swizzle.xxy;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(3u, 8u);
            var v = ov.swizzle.xxyx;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(9u, 9u);
            var v = ov.swizzle.xxyy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(3u, 2u);
            var v = ov.swizzle.xy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec2(0u, 7u);
            var v = ov.swizzle.xyx;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(2u, 2u);
            var v = ov.swizzle.xyxx;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(5u, 9u);
            var v = ov.swizzle.xyxy;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(1u, 3u);
            var v = ov.swizzle.xyy;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(4u, 3u);
            var v = ov.swizzle.xyyx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(8u, 8u);
            var v = ov.swizzle.xyyy;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(9u, 4u);
            var v = ov.swizzle.yx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec2(6u, 7u);
            var v = ov.swizzle.yxx;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(2u, 4u);
            var v = ov.swizzle.yxxx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(4u, 2u);
            var v = ov.swizzle.yxxy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(9u, 0u);
            var v = ov.swizzle.yxy;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(7u, 9u);
            var v = ov.swizzle.yxyx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(8u, 2u);
            var v = ov.swizzle.yxyy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(0u, 3u);
            var v = ov.swizzle.yy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec2(6u, 9u);
            var v = ov.swizzle.yyx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(4u, 1u);
            var v = ov.swizzle.yyxx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(2u, 4u);
            var v = ov.swizzle.yyxy;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(4u, 2u);
            var v = ov.swizzle.yyy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(9u, 1u);
            var v = ov.swizzle.yyyx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(2u, 0u);
            var v = ov.swizzle.yyyy;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new uvec2(8u, 9u);
            var v = ov.swizzle.rr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec2(9u, 5u);
            var v = ov.swizzle.rrr;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(7u, 9u);
            var v = ov.swizzle.rrrr;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(0u, 5u);
            var v = ov.swizzle.rrrg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(0u, 0u);
            var v = ov.swizzle.rrg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(1u, 9u);
            var v = ov.swizzle.rrgr;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(8u, 9u);
            var v = ov.swizzle.rrgg;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(7u, 8u);
            var v = ov.swizzle.rg;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec2(6u, 8u);
            var v = ov.swizzle.rgr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(7u, 6u);
            var v = ov.swizzle.rgrr;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(1u, 5u);
            var v = ov.swizzle.rgrg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(1u, 8u);
            var v = ov.swizzle.rgg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(3u, 4u);
            var v = ov.swizzle.rggr;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(6u, 3u);
            var v = ov.swizzle.rggg;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(8u, 7u);
            var v = ov.swizzle.gr;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec2(6u, 4u);
            var v = ov.swizzle.grr;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(5u, 2u);
            var v = ov.swizzle.grrr;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(7u, 0u);
            var v = ov.swizzle.grrg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(1u, 9u);
            var v = ov.swizzle.grg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(6u, 0u);
            var v = ov.swizzle.grgr;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(6u, 7u);
            var v = ov.swizzle.grgg;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(9u, 1u);
            var v = ov.swizzle.gg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec2(7u, 5u);
            var v = ov.swizzle.ggr;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(6u, 3u);
            var v = ov.swizzle.ggrr;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(1u, 9u);
            var v = ov.swizzle.ggrg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(4u, 4u);
            var v = ov.swizzle.ggg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec2(4u, 0u);
            var v = ov.swizzle.gggr;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec2(4u, 2u);
            var v = ov.swizzle.gggg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new uvec2(7u, 2u);
            var v1 = new uvec2(3u, 6u);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(3u, Is.EqualTo(v0.x));
            Assert.That(6u, Is.EqualTo(v0.y));
        
            Assert.That(7u, Is.EqualTo(v2.x));
            Assert.That(2u, Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            uvec2 v0 = new uvec2(9u, 0u);
            uint v1 = 8u;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(8u, Is.EqualTo(v0.x));
            Assert.That(0u, Is.EqualTo(v0.y));
        
            Assert.That(9u, Is.EqualTo(v2));
        }
        {
            uvec2 v0 = new uvec2(1u, 6u);
            uint v1 = 0u;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(1u, Is.EqualTo(v0.x));
            Assert.That(0u, Is.EqualTo(v0.y));
        
            Assert.That(6u, Is.EqualTo(v2));
        }
        {
            uvec2 v0 = new uvec2(6u, 9u);
            uvec2 v1 = new uvec2(2u, 7u);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(2u, Is.EqualTo(v0.x));
            Assert.That(7u, Is.EqualTo(v0.y));
        
            Assert.That(6u, Is.EqualTo(v2.x));
            Assert.That(9u, Is.EqualTo(v2.y));
        }
    }

}
