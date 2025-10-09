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
            var ov = new gvec2<string>("((97)-1)", null);
            var v = ov.swizzle.xx;
            Assert.That("((97)-1)", Is.EqualTo(v.x));
            Assert.That("((97)-1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((-76)5)", "(1-3)");
            var v = ov.swizzle.xxx;
            Assert.That("((-76)5)", Is.EqualTo(v.x));
            Assert.That("((-76)5)", Is.EqualTo(v.y));
            Assert.That("((-76)5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("9", "8");
            var v = ov.swizzle.xxxx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((3-4)-9)", "(05)");
            var v = ov.swizzle.xxxy;
            Assert.That("((3-4)-9)", Is.EqualTo(v.x));
            Assert.That("((3-4)-9)", Is.EqualTo(v.y));
            Assert.That("((3-4)-9)", Is.EqualTo(v.z));
            Assert.That("(05)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-5", "-5");
            var v = ov.swizzle.xxy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("", null);
            var v = ov.swizzle.xxyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>(null, "((4-9)-7)");
            var v = ov.swizzle.xxyy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((4-9)-7)", Is.EqualTo(v.z));
            Assert.That("((4-9)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((4-8)-5)", "(-5-8)");
            var v = ov.swizzle.xy;
            Assert.That("((4-8)-5)", Is.EqualTo(v.x));
            Assert.That("(-5-8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("", "");
            var v = ov.swizzle.xyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((0-4)6)", "");
            var v = ov.swizzle.xyxx;
            Assert.That("((0-4)6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((0-4)6)", Is.EqualTo(v.z));
            Assert.That("((0-4)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("0", "-7");
            var v = ov.swizzle.xyxy;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-3-6)", "(05)");
            var v = ov.swizzle.xyy;
            Assert.That("(-3-6)", Is.EqualTo(v.x));
            Assert.That("(05)", Is.EqualTo(v.y));
            Assert.That("(05)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("", "");
            var v = ov.swizzle.xyyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("6", "(-23)");
            var v = ov.swizzle.xyyy;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("(-23)", Is.EqualTo(v.y));
            Assert.That("(-23)", Is.EqualTo(v.z));
            Assert.That("(-23)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((1-1)5)", "((1-1)5)");
            var v = ov.swizzle.yx;
            Assert.That("((1-1)5)", Is.EqualTo(v.x));
            Assert.That("((1-1)5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("5", "((7-4)5)");
            var v = ov.swizzle.yxx;
            Assert.That("((7-4)5)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(-6-1)", "((-75)-3)");
            var v = ov.swizzle.yxxx;
            Assert.That("((-75)-3)", Is.EqualTo(v.x));
            Assert.That("(-6-1)", Is.EqualTo(v.y));
            Assert.That("(-6-1)", Is.EqualTo(v.z));
            Assert.That("(-6-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("", "((-7-3)-6)");
            var v = ov.swizzle.yxxy;
            Assert.That("((-7-3)-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-7-3)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-67)", "(2-4)");
            var v = ov.swizzle.yxy;
            Assert.That("(2-4)", Is.EqualTo(v.x));
            Assert.That("(-67)", Is.EqualTo(v.y));
            Assert.That("(2-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((8-8)-4)", "8");
            var v = ov.swizzle.yxyx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((8-8)-4)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((8-8)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(34)", "(-43)");
            var v = ov.swizzle.yxyy;
            Assert.That("(-43)", Is.EqualTo(v.x));
            Assert.That("(34)", Is.EqualTo(v.y));
            Assert.That("(-43)", Is.EqualTo(v.z));
            Assert.That("(-43)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-1-5)8)", "8");
            var v = ov.swizzle.yy;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((-9-1)6)", "5");
            var v = ov.swizzle.yyx;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("((-9-1)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("5", "(-9-2)");
            var v = ov.swizzle.yyxx;
            Assert.That("(-9-2)", Is.EqualTo(v.x));
            Assert.That("(-9-2)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("9", "((1-8)-7)");
            var v = ov.swizzle.yyxy;
            Assert.That("((1-8)-7)", Is.EqualTo(v.x));
            Assert.That("((1-8)-7)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("((1-8)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((30)-9)", "(-82)");
            var v = ov.swizzle.yyy;
            Assert.That("(-82)", Is.EqualTo(v.x));
            Assert.That("(-82)", Is.EqualTo(v.y));
            Assert.That("(-82)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((51)-5)", "8");
            var v = ov.swizzle.yyyx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((51)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((31)-8)", "(33)");
            var v = ov.swizzle.yyyy;
            Assert.That("(33)", Is.EqualTo(v.x));
            Assert.That("(33)", Is.EqualTo(v.y));
            Assert.That("(33)", Is.EqualTo(v.z));
            Assert.That("(33)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec2<string>("((8-7)7)", "4");
            var v = ov.swizzle.rr;
            Assert.That("((8-7)7)", Is.EqualTo(v.x));
            Assert.That("((8-7)7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("(75)", "(75)");
            var v = ov.swizzle.rrr;
            Assert.That("(75)", Is.EqualTo(v.x));
            Assert.That("(75)", Is.EqualTo(v.y));
            Assert.That("(75)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(23)", "(8-3)");
            var v = ov.swizzle.rrrr;
            Assert.That("(23)", Is.EqualTo(v.x));
            Assert.That("(23)", Is.EqualTo(v.y));
            Assert.That("(23)", Is.EqualTo(v.z));
            Assert.That("(23)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("6", "0");
            var v = ov.swizzle.rrrg;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((2-2)-6)", "(2-3)");
            var v = ov.swizzle.rrg;
            Assert.That("((2-2)-6)", Is.EqualTo(v.x));
            Assert.That("((2-2)-6)", Is.EqualTo(v.y));
            Assert.That("(2-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(6-6)", "((-51)-5)");
            var v = ov.swizzle.rrgr;
            Assert.That("(6-6)", Is.EqualTo(v.x));
            Assert.That("(6-6)", Is.EqualTo(v.y));
            Assert.That("((-51)-5)", Is.EqualTo(v.z));
            Assert.That("(6-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(2-7)", "5");
            var v = ov.swizzle.rrgg;
            Assert.That("(2-7)", Is.EqualTo(v.x));
            Assert.That("(2-7)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("4", "(-9-7)");
            var v = ov.swizzle.rg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("(-9-7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>(null, "(79)");
            var v = ov.swizzle.rgr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(79)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(5-8)", "((-32)-8)");
            var v = ov.swizzle.rgrr;
            Assert.That("(5-8)", Is.EqualTo(v.x));
            Assert.That("((-32)-8)", Is.EqualTo(v.y));
            Assert.That("(5-8)", Is.EqualTo(v.z));
            Assert.That("(5-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-4", "");
            var v = ov.swizzle.rgrg;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-50)-2)", "(-28)");
            var v = ov.swizzle.rgg;
            Assert.That("((-50)-2)", Is.EqualTo(v.x));
            Assert.That("(-28)", Is.EqualTo(v.y));
            Assert.That("(-28)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(10)", "(10)");
            var v = ov.swizzle.rggr;
            Assert.That("(10)", Is.EqualTo(v.x));
            Assert.That("(10)", Is.EqualTo(v.y));
            Assert.That("(10)", Is.EqualTo(v.z));
            Assert.That("(10)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-1", "-1");
            var v = ov.swizzle.rggg;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((94)5)", "(37)");
            var v = ov.swizzle.gr;
            Assert.That("(37)", Is.EqualTo(v.x));
            Assert.That("((94)5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("-1", "");
            var v = ov.swizzle.grr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((-8-3)-6)", "((71)-9)");
            var v = ov.swizzle.grrr;
            Assert.That("((71)-9)", Is.EqualTo(v.x));
            Assert.That("((-8-3)-6)", Is.EqualTo(v.y));
            Assert.That("((-8-3)-6)", Is.EqualTo(v.z));
            Assert.That("((-8-3)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("7", "(-21)");
            var v = ov.swizzle.grrg;
            Assert.That("(-21)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(-21)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-1", "((23)7)");
            var v = ov.swizzle.grg;
            Assert.That("((23)7)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((23)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((9-8)4)", "3");
            var v = ov.swizzle.grgr;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((9-8)4)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("((9-8)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(31)", "(-6-5)");
            var v = ov.swizzle.grgg;
            Assert.That("(-6-5)", Is.EqualTo(v.x));
            Assert.That("(31)", Is.EqualTo(v.y));
            Assert.That("(-6-5)", Is.EqualTo(v.z));
            Assert.That("(-6-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((7-6)-3)", "-9");
            var v = ov.swizzle.gg;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((6-7)3)", "-1");
            var v = ov.swizzle.ggr;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((6-7)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("8", "(0-3)");
            var v = ov.swizzle.ggrr;
            Assert.That("(0-3)", Is.EqualTo(v.x));
            Assert.That("(0-3)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("", "-1");
            var v = ov.swizzle.ggrg;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((26)6)", "((26)6)");
            var v = ov.swizzle.ggg;
            Assert.That("((26)6)", Is.EqualTo(v.x));
            Assert.That("((26)6)", Is.EqualTo(v.y));
            Assert.That("((26)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(53)", "");
            var v = ov.swizzle.gggr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(53)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-44)", "((3-5)3)");
            var v = ov.swizzle.gggg;
            Assert.That("((3-5)3)", Is.EqualTo(v.x));
            Assert.That("((3-5)3)", Is.EqualTo(v.y));
            Assert.That("((3-5)3)", Is.EqualTo(v.z));
            Assert.That("((3-5)3)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec2<string>("((6-7)8)", "-1");
            var v1 = new gvec2<string>("", "-5");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("-5", Is.EqualTo(v0.y));
        
            Assert.That("((6-7)8)", Is.EqualTo(v2.x));
            Assert.That("-1", Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            gvec2<string> v0 = new gvec2<string>("-7", "");
            string v1 = "((49)0)";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((49)0)", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
        
            Assert.That("-7", Is.EqualTo(v2));
        }
        {
            gvec2<string> v0 = new gvec2<string>("-2", "(0-7)");
            string v1 = "";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-2", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
        
            Assert.That("(0-7)", Is.EqualTo(v2));
        }
        {
            gvec2<string> v0 = new gvec2<string>("(9-1)", "((5-4)5)");
            gvec2<string> v1 = new gvec2<string>("(78)", "((40)3)");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(78)", Is.EqualTo(v0.x));
            Assert.That("((40)3)", Is.EqualTo(v0.y));
        
            Assert.That("(9-1)", Is.EqualTo(v2.x));
            Assert.That("((5-4)5)", Is.EqualTo(v2.y));
        }
    }

}
