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
public class HalfSwizzleVec2Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new hvec2(((Half)(-4)), ((Half)(-7.5)));
            var v = ov.swizzle.xx;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec2(((Half)(-5)), ((Half)(-2.5)));
            var v = ov.swizzle.xxx;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(4)), ((Half)(-4.5)));
            var v = ov.swizzle.xxxx;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-2)), ((Half)(-8)));
            var v = ov.swizzle.xxxy;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2)), Is.EqualTo(v.z));
            Assert.That(((Half)(-8)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-7)), ((Half)(-6.5)));
            var v = ov.swizzle.xxy;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(-5.5)), ((Half)(-4.5)));
            var v = ov.swizzle.xxyx;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-1.5)), Half.Zero);
            var v = ov.swizzle.xxyy;
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(4)), ((Half)(-8.5)));
            var v = ov.swizzle.xy;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec2(((Half)(9.5)), ((Half)(-9)));
            var v = ov.swizzle.xyx;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(0.5)), ((Half)(-9)));
            var v = ov.swizzle.xyxx;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(2)), ((Half)(9.5)));
            var v = ov.swizzle.xyxy;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(3.5)), ((Half)(-8)));
            var v = ov.swizzle.xyy;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(-2.5)), ((Half)(-1.5)));
            var v = ov.swizzle.xyyx;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(4)), Half.Zero);
            var v = ov.swizzle.xyyy;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-6)), ((Half)(-7)));
            var v = ov.swizzle.yx;
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec2(((Half)(-4.5)), ((Half)(4)));
            var v = ov.swizzle.yxx;
            Assert.That(((Half)(4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(4.5)), ((Half)(3)));
            var v = ov.swizzle.yxxx;
            Assert.That(((Half)(3)), Is.EqualTo(v.x));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-3.5)), ((Half)(-6.5)));
            var v = ov.swizzle.yxxy;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(7)), ((Half)(-5.5)));
            var v = ov.swizzle.yxy;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(7.5)), ((Half)(9.5)));
            var v = ov.swizzle.yxyx;
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(2.5)), ((Half)(-7.5)));
            var v = ov.swizzle.yxyy;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-1)), ((Half)(-0.5)));
            var v = ov.swizzle.yy;
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec2(((Half)(7.5)), ((Half)(-5.5)));
            var v = ov.swizzle.yyx;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(-5)), ((Half)(8)));
            var v = ov.swizzle.yyxx;
            Assert.That(((Half)(8)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-7)), ((Half)(-5.5)));
            var v = ov.swizzle.yyxy;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-3.5)), ((Half)(-5)));
            var v = ov.swizzle.yyy;
            Assert.That(((Half)(-5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(3.5)), ((Half)(2.5)));
            var v = ov.swizzle.yyyx;
            Assert.That(((Half)(2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(8)), ((Half)(-4)));
            var v = ov.swizzle.yyyy;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new hvec2(((Half)(-5.5)), ((Half)(-5)));
            var v = ov.swizzle.rr;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec2(((Half)(-4.5)), ((Half)(-6)));
            var v = ov.swizzle.rrr;
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(-7.5)), ((Half)(-0.5)));
            var v = ov.swizzle.rrrr;
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-6.5)), ((Half)(2)));
            var v = ov.swizzle.rrrg;
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-2)), ((Half)(8.5)));
            var v = ov.swizzle.rrg;
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(6.5)), ((Half)(-9)));
            var v = ov.swizzle.rrgr;
            Assert.That(((Half)(6.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-1)), ((Half)(-6.5)));
            var v = ov.swizzle.rrgg;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-1)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(6)), ((Half)(-8)));
            var v = ov.swizzle.rg;
            Assert.That(((Half)(6)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec2(((Half)(7)), ((Half)(6.5)));
            var v = ov.swizzle.rgr;
            Assert.That(((Half)(7)), Is.EqualTo(v.x));
            Assert.That(((Half)(6.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(7)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(3.5)), ((Half)(9.5)));
            var v = ov.swizzle.rgrr;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(0.5)), ((Half)(7.5)));
            var v = ov.swizzle.rgrg;
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-5.5)), ((Half)(5.5)));
            var v = ov.swizzle.rgg;
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(5.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(2)), ((Half)(-8)));
            var v = ov.swizzle.rggr;
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8)), Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-3)), ((Half)(4)));
            var v = ov.swizzle.rggg;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(((Half)(4)), Is.EqualTo(v.z));
            Assert.That(((Half)(4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(3)), ((Half)(-3)));
            var v = ov.swizzle.gr;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(3)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec2(((Half)(-6)), ((Half)(-1)));
            var v = ov.swizzle.grr;
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(2)), ((Half)(-8.5)));
            var v = ov.swizzle.grrr;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
            Assert.That(((Half)(2)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-9)), ((Half)(-4)));
            var v = ov.swizzle.grrg;
            Assert.That(((Half)(-4)), Is.EqualTo(v.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v.y));
            Assert.That(((Half)(-9)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-5)), ((Half)(-3)));
            var v = ov.swizzle.grg;
            Assert.That(((Half)(-3)), Is.EqualTo(v.x));
            Assert.That(((Half)(-5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-3)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(-4.5)), ((Half)(-2.5)));
            var v = ov.swizzle.grgr;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(4)), Half.One);
            var v = ov.swizzle.grgg;
            Assert.That(Half.One, Is.EqualTo(v.x));
            Assert.That(((Half)(4)), Is.EqualTo(v.y));
            Assert.That(Half.One, Is.EqualTo(v.z));
            Assert.That(Half.One, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-1)), ((Half)(-8)));
            var v = ov.swizzle.gg;
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v.y));
        }
        {
            var ov = new hvec2(((Half)(-1)), ((Half)(-8.5)));
            var v = ov.swizzle.ggr;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(-1)), ((Half)(-3.5)));
            var v = ov.swizzle.ggrr;
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-1)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(3)), Half.Zero);
            var v = ov.swizzle.ggrg;
            Assert.That(Half.Zero, Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(3)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(5)), ((Half)(-8.5)));
            var v = ov.swizzle.ggg;
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-8.5)), Is.EqualTo(v.z));
        }
        {
            var ov = new hvec2(((Half)(-1.5)), ((Half)(3.5)));
            var v = ov.swizzle.gggr;
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.w));
        }
        {
            var ov = new hvec2(((Half)(-7.5)), ((Half)(-2.5)));
            var v = ov.swizzle.gggg;
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(-2.5)), Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new hvec2(((Half)(-6.5)), ((Half)(-9)));
            var v1 = new hvec2(((Half)(-8.5)), ((Half)(9)));
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-8.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(9)), Is.EqualTo(v0.y));
        
            Assert.That(((Half)(-6.5)), Is.EqualTo(v2.x));
            Assert.That(((Half)(-9)), Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            hvec2 v0 = new hvec2(((Half)(0.5)), ((Half)(8)));
            Half v1 = ((Half)(((Half)(-1))));
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(-1)), Is.EqualTo(v0.x));
            Assert.That(((Half)(8)), Is.EqualTo(v0.y));
        
            Assert.That(((Half)(0.5)), Is.EqualTo(v2));
        }
        {
            hvec2 v0 = new hvec2(((Half)(4.5)), ((Half)(-5)));
            Half v1 = ((Half)(((Half)(8))));
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(4.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(8)), Is.EqualTo(v0.y));
        
            Assert.That(((Half)(-5)), Is.EqualTo(v2));
        }
        {
            hvec2 v0 = new hvec2(Half.One, ((Half)(-6)));
            hvec2 v1 = new hvec2(((Half)(9.5)), ((Half)(-8)));
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(((Half)(9.5)), Is.EqualTo(v0.x));
            Assert.That(((Half)(-8)), Is.EqualTo(v0.y));
        
            Assert.That(Half.One, Is.EqualTo(v2.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v2.y));
        }
    }

}
