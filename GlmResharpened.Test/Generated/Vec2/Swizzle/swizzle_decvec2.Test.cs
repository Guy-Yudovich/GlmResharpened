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
public class DecimalSwizzleVec2Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new decvec2(-5.5m, -4m);
            var v = ov.swizzle.xx;
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec2(2.5m, 9m);
            var v = ov.swizzle.xxx;
            Assert.That(2.5m, Is.EqualTo(v.x));
            Assert.That(2.5m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(-2m, 8m);
            var v = ov.swizzle.xxxx;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(4m, -6.5m);
            var v = ov.swizzle.xxxy;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(-6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(6m, -4.5m);
            var v = ov.swizzle.xxy;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(-8m, -3.5m);
            var v = ov.swizzle.xxyx;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-3.5m, Is.EqualTo(v.z));
            Assert.That(-8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(6.5m, -3m);
            var v = ov.swizzle.xxyy;
            Assert.That(6.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
            Assert.That(-3m, Is.EqualTo(v.z));
            Assert.That(-3m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(-3.5m, -6.5m);
            var v = ov.swizzle.xy;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec2(0.5m, -8.5m);
            var v = ov.swizzle.xyx;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
            Assert.That(0.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(-2m, -3.5m);
            var v = ov.swizzle.xyxx;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(-2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(-2m, 1.5m);
            var v = ov.swizzle.xyxy;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(-2m, Is.EqualTo(v.z));
            Assert.That(1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(-1.5m, 9.5m);
            var v = ov.swizzle.xyy;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(5m, 3m);
            var v = ov.swizzle.xyyx;
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(3m, Is.EqualTo(v.y));
            Assert.That(3m, Is.EqualTo(v.z));
            Assert.That(5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(-7.5m, -5.5m);
            var v = ov.swizzle.xyyy;
            Assert.That(-7.5m, Is.EqualTo(v.x));
            Assert.That(-5.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
            Assert.That(-5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(-8.5m, 3m);
            var v = ov.swizzle.yx;
            Assert.That(3m, Is.EqualTo(v.x));
            Assert.That(-8.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec2(-1.5m, 7m);
            var v = ov.swizzle.yxx;
            Assert.That(7m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(-1.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(8m, 0m);
            var v = ov.swizzle.yxxx;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(0m, -3.5m);
            var v = ov.swizzle.yxxy;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(-3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(2m, 8m);
            var v = ov.swizzle.yxy;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(3.5m, -9m);
            var v = ov.swizzle.yxyx;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(8m, -9m);
            var v = ov.swizzle.yxyy;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(1.5m, -2.5m);
            var v = ov.swizzle.yy;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(-2.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec2(5m, 8m);
            var v = ov.swizzle.yyx;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(4m, 0m);
            var v = ov.swizzle.yyxx;
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(9.5m, -1.5m);
            var v = ov.swizzle.yyxy;
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(7m, 8.5m);
            var v = ov.swizzle.yyy;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(8.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(-6.5m, -6.5m);
            var v = ov.swizzle.yyyx;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(-6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(6.5m, 3.5m);
            var v = ov.swizzle.yyyy;
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new decvec2(4m, -4.5m);
            var v = ov.swizzle.rr;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec2(-1m, 7m);
            var v = ov.swizzle.rrr;
            Assert.That(-1m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(-6.5m, -8m);
            var v = ov.swizzle.rrrr;
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
            Assert.That(-6.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(6m, 6m);
            var v = ov.swizzle.rrrg;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(6m, Is.EqualTo(v.y));
            Assert.That(6m, Is.EqualTo(v.z));
            Assert.That(6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(7.5m, -4.5m);
            var v = ov.swizzle.rrg;
            Assert.That(7.5m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(-6m, 2.5m);
            var v = ov.swizzle.rrgr;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(2.5m, Is.EqualTo(v.z));
            Assert.That(-6m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(-4.5m, 9.5m);
            var v = ov.swizzle.rrgg;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-4.5m, Is.EqualTo(v.y));
            Assert.That(9.5m, Is.EqualTo(v.z));
            Assert.That(9.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(8.5m, -9.5m);
            var v = ov.swizzle.rg;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec2(8m, 7.5m);
            var v = ov.swizzle.rgr;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(7.5m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(-8.5m, -9.5m);
            var v = ov.swizzle.rgrr;
            Assert.That(-8.5m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(-8.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(-9m, 0m);
            var v = ov.swizzle.rgrg;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(0m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(6m, -1m);
            var v = ov.swizzle.rgg;
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(-1m, Is.EqualTo(v.y));
            Assert.That(-1m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(-9m, 7m);
            var v = ov.swizzle.rggr;
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(-9m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(4m, -5m);
            var v = ov.swizzle.rggg;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(-5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(6.5m, -2.5m);
            var v = ov.swizzle.gr;
            Assert.That(-2.5m, Is.EqualTo(v.x));
            Assert.That(6.5m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec2(-5m, -3.5m);
            var v = ov.swizzle.grr;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-5m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(-7.5m, -3.5m);
            var v = ov.swizzle.grrr;
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
            Assert.That(-7.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(3.5m, 2m);
            var v = ov.swizzle.grrg;
            Assert.That(2m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(-7.5m, -6m);
            var v = ov.swizzle.grg;
            Assert.That(-6m, Is.EqualTo(v.x));
            Assert.That(-7.5m, Is.EqualTo(v.y));
            Assert.That(-6m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(-1.5m, 8m);
            var v = ov.swizzle.grgr;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(-1.5m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(-1.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(4m, -4.5m);
            var v = ov.swizzle.grgg;
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(-4.5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(2m, -2m);
            var v = ov.swizzle.gg;
            Assert.That(-2m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
        }
        {
            var ov = new decvec2(-8.5m, 0.5m);
            var v = ov.swizzle.ggr;
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(0.5m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(2m, 8.5m);
            var v = ov.swizzle.ggrr;
            Assert.That(8.5m, Is.EqualTo(v.x));
            Assert.That(8.5m, Is.EqualTo(v.y));
            Assert.That(2m, Is.EqualTo(v.z));
            Assert.That(2m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(7m, 5.5m);
            var v = ov.swizzle.ggrg;
            Assert.That(5.5m, Is.EqualTo(v.x));
            Assert.That(5.5m, Is.EqualTo(v.y));
            Assert.That(7m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(7m, -8m);
            var v = ov.swizzle.ggg;
            Assert.That(-8m, Is.EqualTo(v.x));
            Assert.That(-8m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
        }
        {
            var ov = new decvec2(5.5m, 8m);
            var v = ov.swizzle.gggr;
            Assert.That(8m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(8m, Is.EqualTo(v.z));
            Assert.That(5.5m, Is.EqualTo(v.w));
        }
        {
            var ov = new decvec2(-2m, 4m);
            var v = ov.swizzle.gggg;
            Assert.That(4m, Is.EqualTo(v.x));
            Assert.That(4m, Is.EqualTo(v.y));
            Assert.That(4m, Is.EqualTo(v.z));
            Assert.That(4m, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new decvec2(-5m, -7m);
            var v1 = new decvec2(-3.5m, -2.5m);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-3.5m, Is.EqualTo(v0.x));
            Assert.That(-2.5m, Is.EqualTo(v0.y));
        
            Assert.That(-5m, Is.EqualTo(v2.x));
            Assert.That(-7m, Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            decvec2 v0 = new decvec2(8m, -2.5m);
            decimal v1 = 7.5m;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(7.5m, Is.EqualTo(v0.x));
            Assert.That(-2.5m, Is.EqualTo(v0.y));
        
            Assert.That(8m, Is.EqualTo(v2));
        }
        {
            decvec2 v0 = new decvec2(1m, 1m);
            decimal v1 = -4.5m;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(1m, Is.EqualTo(v0.x));
            Assert.That(-4.5m, Is.EqualTo(v0.y));
        
            Assert.That(1m, Is.EqualTo(v2));
        }
        {
            decvec2 v0 = new decvec2(-5m, -5.5m);
            decvec2 v1 = new decvec2(-5.5m, 1.5m);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(-5.5m, Is.EqualTo(v0.x));
            Assert.That(1.5m, Is.EqualTo(v0.y));
        
            Assert.That(-5m, Is.EqualTo(v2.x));
            Assert.That(-5.5m, Is.EqualTo(v2.y));
        }
    }

}
