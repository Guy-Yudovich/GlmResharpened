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
            var ov = new gvec2<string>("7", "null");
            var v = ov.swizzle.xx;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("", "(-90)");
            var v = ov.swizzle.xxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(0-9)", "((95)-4)");
            var v = ov.swizzle.xxxx;
            Assert.That("(0-9)", Is.EqualTo(v.x));
            Assert.That("(0-9)", Is.EqualTo(v.y));
            Assert.That("(0-9)", Is.EqualTo(v.z));
            Assert.That("(0-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("null", "((45)-1)");
            var v = ov.swizzle.xxxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((45)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-8", "((1-2)-3)");
            var v = ov.swizzle.xxy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("((1-2)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("8", "(-2-3)");
            var v = ov.swizzle.xxyx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-2-3)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-35)", "(-35)");
            var v = ov.swizzle.xxyy;
            Assert.That("(-35)", Is.EqualTo(v.x));
            Assert.That("(-35)", Is.EqualTo(v.y));
            Assert.That("(-35)", Is.EqualTo(v.z));
            Assert.That("(-35)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(7-5)", "((6-2)1)");
            var v = ov.swizzle.xy;
            Assert.That("(7-5)", Is.EqualTo(v.x));
            Assert.That("((6-2)1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((55)-8)", "2");
            var v = ov.swizzle.xyx;
            Assert.That("((55)-8)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((55)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(-53)", "(8-4)");
            var v = ov.swizzle.xyxx;
            Assert.That("(-53)", Is.EqualTo(v.x));
            Assert.That("(8-4)", Is.EqualTo(v.y));
            Assert.That("(-53)", Is.EqualTo(v.z));
            Assert.That("(-53)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-9", "((31)-1)");
            var v = ov.swizzle.xyxy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((31)-1)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("((31)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("null", "");
            var v = ov.swizzle.xyy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("-2", "((-55)-1)");
            var v = ov.swizzle.xyyx;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((-55)-1)", Is.EqualTo(v.y));
            Assert.That("((-55)-1)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-9-6)-3)", "((-24)-3)");
            var v = ov.swizzle.xyyy;
            Assert.That("((-9-6)-3)", Is.EqualTo(v.x));
            Assert.That("((-24)-3)", Is.EqualTo(v.y));
            Assert.That("((-24)-3)", Is.EqualTo(v.z));
            Assert.That("((-24)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("8", "");
            var v = ov.swizzle.yx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((-44)-6)", "-9");
            var v = ov.swizzle.yxx;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((-44)-6)", Is.EqualTo(v.y));
            Assert.That("((-44)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("null", "null");
            var v = ov.swizzle.yxxx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-3", "(1-5)");
            var v = ov.swizzle.yxxy;
            Assert.That("(1-5)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(1-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("null", "(81)");
            var v = ov.swizzle.yxy;
            Assert.That("(81)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(81)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((0-2)-5)", "-6");
            var v = ov.swizzle.yxyx;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((0-2)-5)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((0-2)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(1-9)", "9");
            var v = ov.swizzle.yxyy;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(1-9)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("", "-8");
            var v = ov.swizzle.yy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("null", "((5-5)-7)");
            var v = ov.swizzle.yyx;
            Assert.That("((5-5)-7)", Is.EqualTo(v.x));
            Assert.That("((5-5)-7)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("-2", "(-47)");
            var v = ov.swizzle.yyxx;
            Assert.That("(-47)", Is.EqualTo(v.x));
            Assert.That("(-47)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("null", "((0-4)-3)");
            var v = ov.swizzle.yyxy;
            Assert.That("((0-4)-3)", Is.EqualTo(v.x));
            Assert.That("((0-4)-3)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((0-4)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("null", "-5");
            var v = ov.swizzle.yyy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((-8-5)8)", "((-8-5)8)");
            var v = ov.swizzle.yyyx;
            Assert.That("((-8-5)8)", Is.EqualTo(v.x));
            Assert.That("((-8-5)8)", Is.EqualTo(v.y));
            Assert.That("((-8-5)8)", Is.EqualTo(v.z));
            Assert.That("((-8-5)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("null", "(-96)");
            var v = ov.swizzle.yyyy;
            Assert.That("(-96)", Is.EqualTo(v.x));
            Assert.That("(-96)", Is.EqualTo(v.y));
            Assert.That("(-96)", Is.EqualTo(v.z));
            Assert.That("(-96)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec2<string>("0", "-7");
            var v = ov.swizzle.rr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("", "null");
            var v = ov.swizzle.rrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("2", "((-9-6)-8)");
            var v = ov.swizzle.rrrr;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("", "null");
            var v = ov.swizzle.rrrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-9", "((-8-5)1)");
            var v = ov.swizzle.rrg;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((-8-5)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(7-6)", "(7-6)");
            var v = ov.swizzle.rrgr;
            Assert.That("(7-6)", Is.EqualTo(v.x));
            Assert.That("(7-6)", Is.EqualTo(v.y));
            Assert.That("(7-6)", Is.EqualTo(v.z));
            Assert.That("(7-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-7", "-2");
            var v = ov.swizzle.rrgg;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-59)5)", "1");
            var v = ov.swizzle.rg;
            Assert.That("((-59)5)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((-8-7)-9)", "((-8-7)-9)");
            var v = ov.swizzle.rgr;
            Assert.That("((-8-7)-9)", Is.EqualTo(v.x));
            Assert.That("((-8-7)-9)", Is.EqualTo(v.y));
            Assert.That("((-8-7)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("-7", "-7");
            var v = ov.swizzle.rgrr;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((40)-2)", "(43)");
            var v = ov.swizzle.rgrg;
            Assert.That("((40)-2)", Is.EqualTo(v.x));
            Assert.That("(43)", Is.EqualTo(v.y));
            Assert.That("((40)-2)", Is.EqualTo(v.z));
            Assert.That("(43)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("7", "7");
            var v = ov.swizzle.rgg;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((-43)-4)", "(28)");
            var v = ov.swizzle.rggr;
            Assert.That("((-43)-4)", Is.EqualTo(v.x));
            Assert.That("(28)", Is.EqualTo(v.y));
            Assert.That("(28)", Is.EqualTo(v.z));
            Assert.That("((-43)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-74)-2)", "((-74)-2)");
            var v = ov.swizzle.rggg;
            Assert.That("((-74)-2)", Is.EqualTo(v.x));
            Assert.That("((-74)-2)", Is.EqualTo(v.y));
            Assert.That("((-74)-2)", Is.EqualTo(v.z));
            Assert.That("((-74)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-82)3)", "((-80)4)");
            var v = ov.swizzle.gr;
            Assert.That("((-80)4)", Is.EqualTo(v.x));
            Assert.That("((-82)3)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("(81)", "(81)");
            var v = ov.swizzle.grr;
            Assert.That("(81)", Is.EqualTo(v.x));
            Assert.That("(81)", Is.EqualTo(v.y));
            Assert.That("(81)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(-1-9)", "(-1-9)");
            var v = ov.swizzle.grrr;
            Assert.That("(-1-9)", Is.EqualTo(v.x));
            Assert.That("(-1-9)", Is.EqualTo(v.y));
            Assert.That("(-1-9)", Is.EqualTo(v.z));
            Assert.That("(-1-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-3", "(-7-4)");
            var v = ov.swizzle.grrg;
            Assert.That("(-7-4)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(-7-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(33)", "7");
            var v = ov.swizzle.grg;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(33)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(3-4)", "");
            var v = ov.swizzle.grgr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(3-4)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(3-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(47)", "(-4-1)");
            var v = ov.swizzle.grgg;
            Assert.That("(-4-1)", Is.EqualTo(v.x));
            Assert.That("(47)", Is.EqualTo(v.y));
            Assert.That("(-4-1)", Is.EqualTo(v.z));
            Assert.That("(-4-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(06)", "(3-2)");
            var v = ov.swizzle.gg;
            Assert.That("(3-2)", Is.EqualTo(v.x));
            Assert.That("(3-2)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("(0-9)", "(-54)");
            var v = ov.swizzle.ggr;
            Assert.That("(-54)", Is.EqualTo(v.x));
            Assert.That("(-54)", Is.EqualTo(v.y));
            Assert.That("(0-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("5", "((-14)5)");
            var v = ov.swizzle.ggrr;
            Assert.That("((-14)5)", Is.EqualTo(v.x));
            Assert.That("((-14)5)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("null", "(76)");
            var v = ov.swizzle.ggrg;
            Assert.That("(76)", Is.EqualTo(v.x));
            Assert.That("(76)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(76)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-4-1)6)", "((-1-8)3)");
            var v = ov.swizzle.ggg;
            Assert.That("((-1-8)3)", Is.EqualTo(v.x));
            Assert.That("((-1-8)3)", Is.EqualTo(v.y));
            Assert.That("((-1-8)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((-12)-2)", "((82)-3)");
            var v = ov.swizzle.gggr;
            Assert.That("((82)-3)", Is.EqualTo(v.x));
            Assert.That("((82)-3)", Is.EqualTo(v.y));
            Assert.That("((82)-3)", Is.EqualTo(v.z));
            Assert.That("((-12)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((87)-9)", "(-81)");
            var v = ov.swizzle.gggg;
            Assert.That("(-81)", Is.EqualTo(v.x));
            Assert.That("(-81)", Is.EqualTo(v.y));
            Assert.That("(-81)", Is.EqualTo(v.z));
            Assert.That("(-81)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec2<string>("(11)", "(11)");
            var v1 = new gvec2<string>("-2", "(-4-8)");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-2", Is.EqualTo(v0.x));
            Assert.That("(-4-8)", Is.EqualTo(v0.y));
        
            Assert.That("(11)", Is.EqualTo(v2.x));
            Assert.That("(11)", Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new gvec2<string>("null", "-1");
            var v1 = "null";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("-1", Is.EqualTo(v0.y));
        
            Assert.That("null", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec2<string>("(19)", "-7");
            var v1 = "null";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(19)", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
        
            Assert.That("-7", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec2<string>("null", "(1-2)");
            var v1 = new gvec2<string>("", "(55)");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("(55)", Is.EqualTo(v0.y));
        
            Assert.That("null", Is.EqualTo(v2.x));
            Assert.That("(1-2)", Is.EqualTo(v2.y));
        }
    }

}
