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
public class TSwizzleVec2Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new gvec2<string>(null, "((-3-1)-9)");
            var v = ov.swizzle.xx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("(36)", "(-6-9)");
            var v = ov.swizzle.xxx;
            Assert.That("(36)", Is.EqualTo(v.x));
            Assert.That("(36)", Is.EqualTo(v.y));
            Assert.That("(36)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("-4", "");
            var v = ov.swizzle.xxxx;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>(null, "(-3-4)");
            var v = ov.swizzle.xxxy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(-3-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-22)-4)", "((-47)9)");
            var v = ov.swizzle.xxy;
            Assert.That("((-22)-4)", Is.EqualTo(v.x));
            Assert.That("((-22)-4)", Is.EqualTo(v.y));
            Assert.That("((-47)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((17)6)", "5");
            var v = ov.swizzle.xxyx;
            Assert.That("((17)6)", Is.EqualTo(v.x));
            Assert.That("((17)6)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("((17)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>(null, "((7-8)1)");
            var v = ov.swizzle.xxyy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((7-8)1)", Is.EqualTo(v.z));
            Assert.That("((7-8)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(99)", "0");
            var v = ov.swizzle.xy;
            Assert.That("(99)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("(-92)", "-2");
            var v = ov.swizzle.xyx;
            Assert.That("(-92)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("(-92)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("", "((3-6)-7)");
            var v = ov.swizzle.xyxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((3-6)-7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("6", "(-26)");
            var v = ov.swizzle.xyxy;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("(-26)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("(-26)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(25)", "((-59)-1)");
            var v = ov.swizzle.xyy;
            Assert.That("(25)", Is.EqualTo(v.x));
            Assert.That("((-59)-1)", Is.EqualTo(v.y));
            Assert.That("((-59)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>(null, "(-3-9)");
            var v = ov.swizzle.xyyx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-3-9)", Is.EqualTo(v.y));
            Assert.That("(-3-9)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((72)-4)", "-6");
            var v = ov.swizzle.xyyy;
            Assert.That("((72)-4)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-30)-4)", "((-30)-4)");
            var v = ov.swizzle.yx;
            Assert.That("((-30)-4)", Is.EqualTo(v.x));
            Assert.That("((-30)-4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("(9-6)", "5");
            var v = ov.swizzle.yxx;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(9-6)", Is.EqualTo(v.y));
            Assert.That("(9-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((98)9)", "");
            var v = ov.swizzle.yxxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((98)9)", Is.EqualTo(v.y));
            Assert.That("((98)9)", Is.EqualTo(v.z));
            Assert.That("((98)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-17)", "");
            var v = ov.swizzle.yxxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-17)", Is.EqualTo(v.y));
            Assert.That("(-17)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("7", "(-5-8)");
            var v = ov.swizzle.yxy;
            Assert.That("(-5-8)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(-5-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>(null, "((-96)-9)");
            var v = ov.swizzle.yxyx;
            Assert.That("((-96)-9)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-96)-9)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-1-1)-4)", "((-9-2)7)");
            var v = ov.swizzle.yxyy;
            Assert.That("((-9-2)7)", Is.EqualTo(v.x));
            Assert.That("((-1-1)-4)", Is.EqualTo(v.y));
            Assert.That("((-9-2)7)", Is.EqualTo(v.z));
            Assert.That("((-9-2)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(65)", "(65)");
            var v = ov.swizzle.yy;
            Assert.That("(65)", Is.EqualTo(v.x));
            Assert.That("(65)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("4", "-5");
            var v = ov.swizzle.yyx;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(05)", "(7-3)");
            var v = ov.swizzle.yyxx;
            Assert.That("(7-3)", Is.EqualTo(v.x));
            Assert.That("(7-3)", Is.EqualTo(v.y));
            Assert.That("(05)", Is.EqualTo(v.z));
            Assert.That("(05)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(57)", "-2");
            var v = ov.swizzle.yyxy;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("(57)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(6-5)", "(-6-9)");
            var v = ov.swizzle.yyy;
            Assert.That("(-6-9)", Is.EqualTo(v.x));
            Assert.That("(-6-9)", Is.EqualTo(v.y));
            Assert.That("(-6-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("7", "-2");
            var v = ov.swizzle.yyyx;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-1", "-2");
            var v = ov.swizzle.yyyy;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec2<string>("((-1-7)-5)", "((-1-7)-5)");
            var v = ov.swizzle.rr;
            Assert.That("((-1-7)-5)", Is.EqualTo(v.x));
            Assert.That("((-1-7)-5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((6-3)3)", "(69)");
            var v = ov.swizzle.rrr;
            Assert.That("((6-3)3)", Is.EqualTo(v.x));
            Assert.That("((6-3)3)", Is.EqualTo(v.y));
            Assert.That("((6-3)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>(null, "((0-2)4)");
            var v = ov.swizzle.rrrr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("3", "0");
            var v = ov.swizzle.rrrg;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("0", "((6-2)1)");
            var v = ov.swizzle.rrg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((6-2)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(4-4)", null);
            var v = ov.swizzle.rrgr;
            Assert.That("(4-4)", Is.EqualTo(v.x));
            Assert.That("(4-4)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(4-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(52)", "-8");
            var v = ov.swizzle.rrgg;
            Assert.That("(52)", Is.EqualTo(v.x));
            Assert.That("(52)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("7", "((5-9)8)");
            var v = ov.swizzle.rg;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((5-9)8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("-8", "-8");
            var v = ov.swizzle.rgr;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((6-5)-1)", "-9");
            var v = ov.swizzle.rgrr;
            Assert.That("((6-5)-1)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((6-5)-1)", Is.EqualTo(v.z));
            Assert.That("((6-5)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-53)", "((81)-8)");
            var v = ov.swizzle.rgrg;
            Assert.That("(-53)", Is.EqualTo(v.x));
            Assert.That("((81)-8)", Is.EqualTo(v.y));
            Assert.That("(-53)", Is.EqualTo(v.z));
            Assert.That("((81)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-1", "7");
            var v = ov.swizzle.rgg;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("2", "7");
            var v = ov.swizzle.rggr;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(7-5)", "(04)");
            var v = ov.swizzle.rggg;
            Assert.That("(7-5)", Is.EqualTo(v.x));
            Assert.That("(04)", Is.EqualTo(v.y));
            Assert.That("(04)", Is.EqualTo(v.z));
            Assert.That("(04)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(70)", "((9-1)5)");
            var v = ov.swizzle.gr;
            Assert.That("((9-1)5)", Is.EqualTo(v.x));
            Assert.That("(70)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("-1", "((42)-2)");
            var v = ov.swizzle.grr;
            Assert.That("((42)-2)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(04)", "1");
            var v = ov.swizzle.grrr;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(04)", Is.EqualTo(v.y));
            Assert.That("(04)", Is.EqualTo(v.z));
            Assert.That("(04)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-6", "(-7-2)");
            var v = ov.swizzle.grrg;
            Assert.That("(-7-2)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("(-7-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((01)-6)", "((-3-2)-6)");
            var v = ov.swizzle.grg;
            Assert.That("((-3-2)-6)", Is.EqualTo(v.x));
            Assert.That("((01)-6)", Is.EqualTo(v.y));
            Assert.That("((-3-2)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((-4-1)-5)", "8");
            var v = ov.swizzle.grgr;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((-4-1)-5)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((-4-1)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-1-4)6)", null);
            var v = ov.swizzle.grgg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-1-4)6)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>(null, "((0-1)1)");
            var v = ov.swizzle.gg;
            Assert.That("((0-1)1)", Is.EqualTo(v.x));
            Assert.That("((0-1)1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((-7-6)-8)", "((60)4)");
            var v = ov.swizzle.ggr;
            Assert.That("((60)4)", Is.EqualTo(v.x));
            Assert.That("((60)4)", Is.EqualTo(v.y));
            Assert.That("((-7-6)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(-83)", "(-91)");
            var v = ov.swizzle.ggrr;
            Assert.That("(-91)", Is.EqualTo(v.x));
            Assert.That("(-91)", Is.EqualTo(v.y));
            Assert.That("(-83)", Is.EqualTo(v.z));
            Assert.That("(-83)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-46)", "((34)-2)");
            var v = ov.swizzle.ggrg;
            Assert.That("((34)-2)", Is.EqualTo(v.x));
            Assert.That("((34)-2)", Is.EqualTo(v.y));
            Assert.That("(-46)", Is.EqualTo(v.z));
            Assert.That("((34)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-32)6)", "((-98)-9)");
            var v = ov.swizzle.ggg;
            Assert.That("((-98)-9)", Is.EqualTo(v.x));
            Assert.That("((-98)-9)", Is.EqualTo(v.y));
            Assert.That("((-98)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("0", "(6-5)");
            var v = ov.swizzle.gggr;
            Assert.That("(6-5)", Is.EqualTo(v.x));
            Assert.That("(6-5)", Is.EqualTo(v.y));
            Assert.That("(6-5)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("5", "(86)");
            var v = ov.swizzle.gggg;
            Assert.That("(86)", Is.EqualTo(v.x));
            Assert.That("(86)", Is.EqualTo(v.y));
            Assert.That("(86)", Is.EqualTo(v.z));
            Assert.That("(86)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec2<string>("((-6-3)8)", "");
            var v1 = new gvec2<string>("(-3-4)", "((-8-9)-2)");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-3-4)", Is.EqualTo(v0.x));
            Assert.That("((-8-9)-2)", Is.EqualTo(v0.y));
        
            Assert.That("((-6-3)8)", Is.EqualTo(v2.x));
            Assert.That("", Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            gvec2<string> v0 = new gvec2<string>("-3", null);
            string v1 = "((1-2)7)";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((1-2)7)", Is.EqualTo(v0.x));
            Assert.That(null, Is.EqualTo(v0.y));
        
            Assert.That("-3", Is.EqualTo(v2));
        }
        {
            gvec2<string> v0 = new gvec2<string>("-2", "((-9-2)9)");
            string v1 = "";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-2", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
        
            Assert.That("((-9-2)9)", Is.EqualTo(v2));
        }
        {
            gvec2<string> v0 = new gvec2<string>(null, "-9");
            gvec2<string> v1 = new gvec2<string>("1", "1");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("1", Is.EqualTo(v0.x));
            Assert.That("1", Is.EqualTo(v0.y));
        
            Assert.That(null, Is.EqualTo(v2.x));
            Assert.That("-9", Is.EqualTo(v2.y));
        }
    }

}
