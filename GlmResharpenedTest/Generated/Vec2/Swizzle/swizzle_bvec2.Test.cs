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
public class BoolSwizzleVec2Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new bvec2(true, true);
            var v = ov.swizzle.xx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec2(true, true);
            var v = ov.swizzle.xxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.xxxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, true);
            var v = ov.swizzle.xxxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.xxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.xxyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(true, false);
            var v = ov.swizzle.xxyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.xy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec2(true, true);
            var v = ov.swizzle.xyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(false, true);
            var v = ov.swizzle.xyxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, true);
            var v = ov.swizzle.xyxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.xyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(false, true);
            var v = ov.swizzle.xyyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.xyyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, true);
            var v = ov.swizzle.yx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.yxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(false, true);
            var v = ov.swizzle.yxxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(true, false);
            var v = ov.swizzle.yxxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(true, true);
            var v = ov.swizzle.yxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.yxyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(true, false);
            var v = ov.swizzle.yxyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(true, true);
            var v = ov.swizzle.yy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec2(true, true);
            var v = ov.swizzle.yyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(false, true);
            var v = ov.swizzle.yyxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, true);
            var v = ov.swizzle.yyxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(true, false);
            var v = ov.swizzle.yyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(true, true);
            var v = ov.swizzle.yyyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.yyyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.rr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec2(true, true);
            var v = ov.swizzle.rrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(false, true);
            var v = ov.swizzle.rrrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(true, false);
            var v = ov.swizzle.rrrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, true);
            var v = ov.swizzle.rrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(true, true);
            var v = ov.swizzle.rrgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, true);
            var v = ov.swizzle.rrgg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, true);
            var v = ov.swizzle.rg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec2(true, false);
            var v = ov.swizzle.rgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(true, false);
            var v = ov.swizzle.rgrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(true, false);
            var v = ov.swizzle.rgrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(true, true);
            var v = ov.swizzle.rgg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.rggr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.rggg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.gr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec2(false, true);
            var v = ov.swizzle.grr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(true, true);
            var v = ov.swizzle.grrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(true, false);
            var v = ov.swizzle.grrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.grg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(true, false);
            var v = ov.swizzle.grgr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, true);
            var v = ov.swizzle.grgg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(true, false);
            var v = ov.swizzle.gg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec2(true, true);
            var v = ov.swizzle.ggr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(true, false);
            var v = ov.swizzle.ggrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.ggrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.ggg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec2(false, false);
            var v = ov.swizzle.gggr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec2(true, true);
            var v = ov.swizzle.gggg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new bvec2(false, false);
            var v1 = new bvec2(false, true);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new bvec2(false, true);
            var v1 = true;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
        
            Assert.That(false, Is.EqualTo(v2));
        }
        {
            var v0 = new bvec2(false, true);
            var v1 = false;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
        
            Assert.That(true, Is.EqualTo(v2));
        }
        {
            var v0 = new bvec2(true, true);
            var v1 = new bvec2(false, false);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
        }
    }

}
