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
            var ov = new gvec2<string>("((-86)-3)", "((00)4)");
            var v = ov.swizzle.xx;
            Assert.That("((-86)-3)", Is.EqualTo(v.x));
            Assert.That("((-86)-3)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("", "((-1-2)-2)");
            var v = ov.swizzle.xxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("0", "((-1-9)2)");
            var v = ov.swizzle.xxxx;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-72)", "6");
            var v = ov.swizzle.xxxy;
            Assert.That("(-72)", Is.EqualTo(v.x));
            Assert.That("(-72)", Is.EqualTo(v.y));
            Assert.That("(-72)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("7", "((-7-1)-7)");
            var v = ov.swizzle.xxy;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("((-7-1)-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("-6", "(-58)");
            var v = ov.swizzle.xxyx;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(-58)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("8", "6");
            var v = ov.swizzle.xxyy;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(53)", "(53)");
            var v = ov.swizzle.xy;
            Assert.That("(53)", Is.EqualTo(v.x));
            Assert.That("(53)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("(-96)", "(81)");
            var v = ov.swizzle.xyx;
            Assert.That("(-96)", Is.EqualTo(v.x));
            Assert.That("(81)", Is.EqualTo(v.y));
            Assert.That("(-96)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("6", "");
            var v = ov.swizzle.xyxx;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("3", "");
            var v = ov.swizzle.xyxy;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-9", "(8-7)");
            var v = ov.swizzle.xyy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("(8-7)", Is.EqualTo(v.y));
            Assert.That("(8-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("3", "((-6-3)3)");
            var v = ov.swizzle.xyyx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((-6-3)3)", Is.EqualTo(v.y));
            Assert.That("((-6-3)3)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-1-9)-3)", "");
            var v = ov.swizzle.xyyy;
            Assert.That("((-1-9)-3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((90)-1)", "(7-2)");
            var v = ov.swizzle.yx;
            Assert.That("(7-2)", Is.EqualTo(v.x));
            Assert.That("((90)-1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((-39)-4)", "-8");
            var v = ov.swizzle.yxx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((-39)-4)", Is.EqualTo(v.y));
            Assert.That("((-39)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("-3", "");
            var v = ov.swizzle.yxxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(7-2)", "(7-2)");
            var v = ov.swizzle.yxxy;
            Assert.That("(7-2)", Is.EqualTo(v.x));
            Assert.That("(7-2)", Is.EqualTo(v.y));
            Assert.That("(7-2)", Is.EqualTo(v.z));
            Assert.That("(7-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("null", "(-68)");
            var v = ov.swizzle.yxy;
            Assert.That("(-68)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-68)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("null", "8");
            var v = ov.swizzle.yxyx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("null", "-8");
            var v = ov.swizzle.yxyy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(1-7)", "null");
            var v = ov.swizzle.yy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((9-6)-6)", "((5-1)7)");
            var v = ov.swizzle.yyx;
            Assert.That("((5-1)7)", Is.EqualTo(v.x));
            Assert.That("((5-1)7)", Is.EqualTo(v.y));
            Assert.That("((9-6)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("null", "(-6-5)");
            var v = ov.swizzle.yyxx;
            Assert.That("(-6-5)", Is.EqualTo(v.x));
            Assert.That("(-6-5)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("7", "(-2-7)");
            var v = ov.swizzle.yyxy;
            Assert.That("(-2-7)", Is.EqualTo(v.x));
            Assert.That("(-2-7)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(-2-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-9-4)9)", "-8");
            var v = ov.swizzle.yyy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("", "-4");
            var v = ov.swizzle.yyyx;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(2-7)", "null");
            var v = ov.swizzle.yyyy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec2<string>("(-7-8)", "-2");
            var v = ov.swizzle.rr;
            Assert.That("(-7-8)", Is.EqualTo(v.x));
            Assert.That("(-7-8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("(27)", "-8");
            var v = ov.swizzle.rrr;
            Assert.That("(27)", Is.EqualTo(v.x));
            Assert.That("(27)", Is.EqualTo(v.y));
            Assert.That("(27)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("", "0");
            var v = ov.swizzle.rrrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("6", "(86)");
            var v = ov.swizzle.rrrg;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("(86)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(11)", "-8");
            var v = ov.swizzle.rrg;
            Assert.That("(11)", Is.EqualTo(v.x));
            Assert.That("(11)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(20)", "-4");
            var v = ov.swizzle.rrgr;
            Assert.That("(20)", Is.EqualTo(v.x));
            Assert.That("(20)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(20)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((6-1)-9)", "((01)-7)");
            var v = ov.swizzle.rrgg;
            Assert.That("((6-1)-9)", Is.EqualTo(v.x));
            Assert.That("((6-1)-9)", Is.EqualTo(v.y));
            Assert.That("((01)-7)", Is.EqualTo(v.z));
            Assert.That("((01)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(5-9)", "");
            var v = ov.swizzle.rg;
            Assert.That("(5-9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((-6-5)-6)", "");
            var v = ov.swizzle.rgr;
            Assert.That("((-6-5)-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-6-5)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((-93)0)", "null");
            var v = ov.swizzle.rgrr;
            Assert.That("((-93)0)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-93)0)", Is.EqualTo(v.z));
            Assert.That("((-93)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-2", "((-1-3)6)");
            var v = ov.swizzle.rgrg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((-1-3)6)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("((-1-3)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-29)", "1");
            var v = ov.swizzle.rgg;
            Assert.That("(-29)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(-4-9)", "(-78)");
            var v = ov.swizzle.rggr;
            Assert.That("(-4-9)", Is.EqualTo(v.x));
            Assert.That("(-78)", Is.EqualTo(v.y));
            Assert.That("(-78)", Is.EqualTo(v.z));
            Assert.That("(-4-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("null", "");
            var v = ov.swizzle.rggg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-4", "((-2-8)-2)");
            var v = ov.swizzle.gr;
            Assert.That("((-2-8)-2)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((-3-1)4)", "-7");
            var v = ov.swizzle.grr;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-3-1)4)", Is.EqualTo(v.y));
            Assert.That("((-3-1)4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(3-8)", "((-61)-9)");
            var v = ov.swizzle.grrr;
            Assert.That("((-61)-9)", Is.EqualTo(v.x));
            Assert.That("(3-8)", Is.EqualTo(v.y));
            Assert.That("(3-8)", Is.EqualTo(v.z));
            Assert.That("(3-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-7", "(-9-3)");
            var v = ov.swizzle.grrg;
            Assert.That("(-9-3)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("(-9-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-3-8)-4)", "null");
            var v = ov.swizzle.grg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-3-8)-4)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((71)4)", "-3");
            var v = ov.swizzle.grgr;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("((71)4)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("((71)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(7-1)", "1");
            var v = ov.swizzle.grgg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(7-1)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(84)", "(-9-9)");
            var v = ov.swizzle.gg;
            Assert.That("(-9-9)", Is.EqualTo(v.x));
            Assert.That("(-9-9)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("(-7-2)", "(-90)");
            var v = ov.swizzle.ggr;
            Assert.That("(-90)", Is.EqualTo(v.x));
            Assert.That("(-90)", Is.EqualTo(v.y));
            Assert.That("(-7-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((-9-5)-8)", "((-3-1)-8)");
            var v = ov.swizzle.ggrr;
            Assert.That("((-3-1)-8)", Is.EqualTo(v.x));
            Assert.That("((-3-1)-8)", Is.EqualTo(v.y));
            Assert.That("((-9-5)-8)", Is.EqualTo(v.z));
            Assert.That("((-9-5)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-90)", "((-2-7)0)");
            var v = ov.swizzle.ggrg;
            Assert.That("((-2-7)0)", Is.EqualTo(v.x));
            Assert.That("((-2-7)0)", Is.EqualTo(v.y));
            Assert.That("(-90)", Is.EqualTo(v.z));
            Assert.That("((-2-7)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-3", "(2-7)");
            var v = ov.swizzle.ggg;
            Assert.That("(2-7)", Is.EqualTo(v.x));
            Assert.That("(2-7)", Is.EqualTo(v.y));
            Assert.That("(2-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((83)-9)", "8");
            var v = ov.swizzle.gggr;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((83)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-1-9)0)", "(49)");
            var v = ov.swizzle.gggg;
            Assert.That("(49)", Is.EqualTo(v.x));
            Assert.That("(49)", Is.EqualTo(v.y));
            Assert.That("(49)", Is.EqualTo(v.z));
            Assert.That("(49)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec2<string>("((3-4)1)", "(72)");
            var v1 = new gvec2<string>("-6", "((33)-3)");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-6", Is.EqualTo(v0.x));
            Assert.That("((33)-3)", Is.EqualTo(v0.y));
        
            Assert.That("((3-4)1)", Is.EqualTo(v2.x));
            Assert.That("(72)", Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new gvec2<string>("(37)", "((-91)4)");
            var v1 = "(-15)";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-15)", Is.EqualTo(v0.x));
            Assert.That("((-91)4)", Is.EqualTo(v0.y));
        
            Assert.That("(37)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec2<string>("(59)", "(7-2)");
            var v1 = "4";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(59)", Is.EqualTo(v0.x));
            Assert.That("4", Is.EqualTo(v0.y));
        
            Assert.That("(7-2)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec2<string>("(1-6)", "7");
            var v1 = new gvec2<string>("6", "(3-2)");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("6", Is.EqualTo(v0.x));
            Assert.That("(3-2)", Is.EqualTo(v0.y));
        
            Assert.That("(1-6)", Is.EqualTo(v2.x));
            Assert.That("7", Is.EqualTo(v2.y));
        }
    }

}
