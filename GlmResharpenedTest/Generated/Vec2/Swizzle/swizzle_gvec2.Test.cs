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
            var ov = new gvec2<string>("null", "-8");
            var v = ov.swizzle.xx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("null", "(-7-5)");
            var v = ov.swizzle.xxx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("", "((5-9)1)");
            var v = ov.swizzle.xxxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(03)", "-9");
            var v = ov.swizzle.xxxy;
            Assert.That("(03)", Is.EqualTo(v.x));
            Assert.That("(03)", Is.EqualTo(v.y));
            Assert.That("(03)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("", "3");
            var v = ov.swizzle.xxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("4", "2");
            var v = ov.swizzle.xxyx;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(08)", "0");
            var v = ov.swizzle.xxyy;
            Assert.That("(08)", Is.EqualTo(v.x));
            Assert.That("(08)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("2", "((-86)0)");
            var v = ov.swizzle.xy;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("((-86)0)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((-5-1)6)", "(15)");
            var v = ov.swizzle.xyx;
            Assert.That("((-5-1)6)", Is.EqualTo(v.x));
            Assert.That("(15)", Is.EqualTo(v.y));
            Assert.That("((-5-1)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("", "(44)");
            var v = ov.swizzle.xyxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(44)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(8-5)", "");
            var v = ov.swizzle.xyxy;
            Assert.That("(8-5)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(8-5)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-77)", "-5");
            var v = ov.swizzle.xyy;
            Assert.That("(-77)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("5", "((-88)-2)");
            var v = ov.swizzle.xyyx;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("((-88)-2)", Is.EqualTo(v.y));
            Assert.That("((-88)-2)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((39)-1)", "((-70)7)");
            var v = ov.swizzle.xyyy;
            Assert.That("((39)-1)", Is.EqualTo(v.x));
            Assert.That("((-70)7)", Is.EqualTo(v.y));
            Assert.That("((-70)7)", Is.EqualTo(v.z));
            Assert.That("((-70)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("0", "(6-3)");
            var v = ov.swizzle.yx;
            Assert.That("(6-3)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((-2-7)1)", "3");
            var v = ov.swizzle.yxx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((-2-7)1)", Is.EqualTo(v.y));
            Assert.That("((-2-7)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("null", "(-12)");
            var v = ov.swizzle.yxxx;
            Assert.That("(-12)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("0", "null");
            var v = ov.swizzle.yxxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-3-6)-2)", "(-3-2)");
            var v = ov.swizzle.yxy;
            Assert.That("(-3-2)", Is.EqualTo(v.x));
            Assert.That("((-3-6)-2)", Is.EqualTo(v.y));
            Assert.That("(-3-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("", "");
            var v = ov.swizzle.yxyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("9", "-4");
            var v = ov.swizzle.yxyy;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("", "(94)");
            var v = ov.swizzle.yy;
            Assert.That("(94)", Is.EqualTo(v.x));
            Assert.That("(94)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("0", "((55)-6)");
            var v = ov.swizzle.yyx;
            Assert.That("((55)-6)", Is.EqualTo(v.x));
            Assert.That("((55)-6)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("", "-5");
            var v = ov.swizzle.yyxx;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(31)", "((2-3)-8)");
            var v = ov.swizzle.yyxy;
            Assert.That("((2-3)-8)", Is.EqualTo(v.x));
            Assert.That("((2-3)-8)", Is.EqualTo(v.y));
            Assert.That("(31)", Is.EqualTo(v.z));
            Assert.That("((2-3)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-93)", "(5-4)");
            var v = ov.swizzle.yyy;
            Assert.That("(5-4)", Is.EqualTo(v.x));
            Assert.That("(5-4)", Is.EqualTo(v.y));
            Assert.That("(5-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((-98)-1)", "((4-7)-2)");
            var v = ov.swizzle.yyyx;
            Assert.That("((4-7)-2)", Is.EqualTo(v.x));
            Assert.That("((4-7)-2)", Is.EqualTo(v.y));
            Assert.That("((4-7)-2)", Is.EqualTo(v.z));
            Assert.That("((-98)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-6", "");
            var v = ov.swizzle.yyyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec2<string>("5", "");
            var v = ov.swizzle.rr;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("5", "((30)3)");
            var v = ov.swizzle.rrr;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("null", "3");
            var v = ov.swizzle.rrrr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((94)2)", "-5");
            var v = ov.swizzle.rrrg;
            Assert.That("((94)2)", Is.EqualTo(v.x));
            Assert.That("((94)2)", Is.EqualTo(v.y));
            Assert.That("((94)2)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-2", "((-69)7)");
            var v = ov.swizzle.rrg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((-69)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("-4", "3");
            var v = ov.swizzle.rrgr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-4-3)", "(-7-9)");
            var v = ov.swizzle.rrgg;
            Assert.That("(-4-3)", Is.EqualTo(v.x));
            Assert.That("(-4-3)", Is.EqualTo(v.y));
            Assert.That("(-7-9)", Is.EqualTo(v.z));
            Assert.That("(-7-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("3", "(-6-4)");
            var v = ov.swizzle.rg;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(-6-4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("(-77)", "null");
            var v = ov.swizzle.rgr;
            Assert.That("(-77)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-77)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(54)", "null");
            var v = ov.swizzle.rgrr;
            Assert.That("(54)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(54)", Is.EqualTo(v.z));
            Assert.That("(54)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(8-9)", "((73)3)");
            var v = ov.swizzle.rgrg;
            Assert.That("(8-9)", Is.EqualTo(v.x));
            Assert.That("((73)3)", Is.EqualTo(v.y));
            Assert.That("(8-9)", Is.EqualTo(v.z));
            Assert.That("((73)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((27)1)", "((50)1)");
            var v = ov.swizzle.rgg;
            Assert.That("((27)1)", Is.EqualTo(v.x));
            Assert.That("((50)1)", Is.EqualTo(v.y));
            Assert.That("((50)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((5-4)1)", "");
            var v = ov.swizzle.rggr;
            Assert.That("((5-4)1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((5-4)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(9-1)", "((-90)-8)");
            var v = ov.swizzle.rggg;
            Assert.That("(9-1)", Is.EqualTo(v.x));
            Assert.That("((-90)-8)", Is.EqualTo(v.y));
            Assert.That("((-90)-8)", Is.EqualTo(v.z));
            Assert.That("((-90)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("7", "(0-9)");
            var v = ov.swizzle.gr;
            Assert.That("(0-9)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("-4", "(81)");
            var v = ov.swizzle.grr;
            Assert.That("(81)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("null", "((5-2)-3)");
            var v = ov.swizzle.grrr;
            Assert.That("((5-2)-3)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-98)", "-7");
            var v = ov.swizzle.grrg;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(-98)", Is.EqualTo(v.y));
            Assert.That("(-98)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-11)8)", "((8-2)-8)");
            var v = ov.swizzle.grg;
            Assert.That("((8-2)-8)", Is.EqualTo(v.x));
            Assert.That("((-11)8)", Is.EqualTo(v.y));
            Assert.That("((8-2)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(-6-9)", "(30)");
            var v = ov.swizzle.grgr;
            Assert.That("(30)", Is.EqualTo(v.x));
            Assert.That("(-6-9)", Is.EqualTo(v.y));
            Assert.That("(30)", Is.EqualTo(v.z));
            Assert.That("(-6-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-83)", "(90)");
            var v = ov.swizzle.grgg;
            Assert.That("(90)", Is.EqualTo(v.x));
            Assert.That("(-83)", Is.EqualTo(v.y));
            Assert.That("(90)", Is.EqualTo(v.z));
            Assert.That("(90)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-47)1)", "4");
            var v = ov.swizzle.gg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("(55)", "null");
            var v = ov.swizzle.ggr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(55)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(-37)", "0");
            var v = ov.swizzle.ggrr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("(-37)", Is.EqualTo(v.z));
            Assert.That("(-37)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-5-7)", "(-3-6)");
            var v = ov.swizzle.ggrg;
            Assert.That("(-3-6)", Is.EqualTo(v.x));
            Assert.That("(-3-6)", Is.EqualTo(v.y));
            Assert.That("(-5-7)", Is.EqualTo(v.z));
            Assert.That("(-3-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(6-5)", "(-3-3)");
            var v = ov.swizzle.ggg;
            Assert.That("(-3-3)", Is.EqualTo(v.x));
            Assert.That("(-3-3)", Is.EqualTo(v.y));
            Assert.That("(-3-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("null", "8");
            var v = ov.swizzle.gggr;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-6", "-5");
            var v = ov.swizzle.gggg;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec2<string>("(-7-1)", "(92)");
            var v1 = new gvec2<string>("((-91)8)", "(-4-9)");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-91)8)", Is.EqualTo(v0.x));
            Assert.That("(-4-9)", Is.EqualTo(v0.y));
        
            Assert.That("(-7-1)", Is.EqualTo(v2.x));
            Assert.That("(92)", Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new gvec2<string>("3", "-6");
            var v1 = "null";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("-6", Is.EqualTo(v0.y));
        
            Assert.That("3", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec2<string>("((-42)-8)", "((-42)-8)");
            var v1 = "(-6-3)";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-42)-8)", Is.EqualTo(v0.x));
            Assert.That("(-6-3)", Is.EqualTo(v0.y));
        
            Assert.That("((-42)-8)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec2<string>("null", "(-52)");
            var v1 = new gvec2<string>("-2", "9");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-2", Is.EqualTo(v0.x));
            Assert.That("9", Is.EqualTo(v0.y));
        
            Assert.That("null", Is.EqualTo(v2.x));
            Assert.That("(-52)", Is.EqualTo(v2.y));
        }
    }

}
