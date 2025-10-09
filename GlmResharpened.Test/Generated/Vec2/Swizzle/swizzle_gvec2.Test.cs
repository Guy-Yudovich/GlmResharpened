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
            var ov = new gvec2<string>("-4", "-1");
            var v = ov.swizzle.xx;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((06)0)", "((-46)-6)");
            var v = ov.swizzle.xxx;
            Assert.That("((06)0)", Is.EqualTo(v.x));
            Assert.That("((06)0)", Is.EqualTo(v.y));
            Assert.That("((06)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((-9-7)-7)", "null");
            var v = ov.swizzle.xxxx;
            Assert.That("((-9-7)-7)", Is.EqualTo(v.x));
            Assert.That("((-9-7)-7)", Is.EqualTo(v.y));
            Assert.That("((-9-7)-7)", Is.EqualTo(v.z));
            Assert.That("((-9-7)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("", "2");
            var v = ov.swizzle.xxxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("null", "(-4-7)");
            var v = ov.swizzle.xxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-4-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((5-3)-7)", "((-97)-3)");
            var v = ov.swizzle.xxyx;
            Assert.That("((5-3)-7)", Is.EqualTo(v.x));
            Assert.That("((5-3)-7)", Is.EqualTo(v.y));
            Assert.That("((-97)-3)", Is.EqualTo(v.z));
            Assert.That("((5-3)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-4-4)", "(-7-6)");
            var v = ov.swizzle.xxyy;
            Assert.That("(-4-4)", Is.EqualTo(v.x));
            Assert.That("(-4-4)", Is.EqualTo(v.y));
            Assert.That("(-7-6)", Is.EqualTo(v.z));
            Assert.That("(-7-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(6-4)", "-7");
            var v = ov.swizzle.xy;
            Assert.That("(6-4)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("(25)", "-1");
            var v = ov.swizzle.xyx;
            Assert.That("(25)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(25)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(92)", "((-2-6)3)");
            var v = ov.swizzle.xyxx;
            Assert.That("(92)", Is.EqualTo(v.x));
            Assert.That("((-2-6)3)", Is.EqualTo(v.y));
            Assert.That("(92)", Is.EqualTo(v.z));
            Assert.That("(92)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-7", "");
            var v = ov.swizzle.xyxy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((22)-8)", "0");
            var v = ov.swizzle.xyy;
            Assert.That("((22)-8)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(-4-2)", "");
            var v = ov.swizzle.xyyx;
            Assert.That("(-4-2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-4-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("null", "6");
            var v = ov.swizzle.xyyy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("", "(50)");
            var v = ov.swizzle.yx;
            Assert.That("(50)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("null", "(-2-1)");
            var v = ov.swizzle.yxx;
            Assert.That("(-2-1)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((58)-8)", "4");
            var v = ov.swizzle.yxxx;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((58)-8)", Is.EqualTo(v.y));
            Assert.That("((58)-8)", Is.EqualTo(v.z));
            Assert.That("((58)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("", "(12)");
            var v = ov.swizzle.yxxy;
            Assert.That("(12)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(12)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("null", "(-67)");
            var v = ov.swizzle.yxy;
            Assert.That("(-67)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-67)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((0-3)-1)", "");
            var v = ov.swizzle.yxyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((0-3)-1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((0-3)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(59)", "2");
            var v = ov.swizzle.yxyy;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(59)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("-5", "null");
            var v = ov.swizzle.yy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((-3-7)5)", "5");
            var v = ov.swizzle.yyx;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("((-3-7)5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(43)", "((79)9)");
            var v = ov.swizzle.yyxx;
            Assert.That("((79)9)", Is.EqualTo(v.x));
            Assert.That("((79)9)", Is.EqualTo(v.y));
            Assert.That("(43)", Is.EqualTo(v.z));
            Assert.That("(43)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-13)", "null");
            var v = ov.swizzle.yyxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-13)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("1", "(2-7)");
            var v = ov.swizzle.yyy;
            Assert.That("(2-7)", Is.EqualTo(v.x));
            Assert.That("(2-7)", Is.EqualTo(v.y));
            Assert.That("(2-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("null", "0");
            var v = ov.swizzle.yyyx;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((87)0)", "(41)");
            var v = ov.swizzle.yyyy;
            Assert.That("(41)", Is.EqualTo(v.x));
            Assert.That("(41)", Is.EqualTo(v.y));
            Assert.That("(41)", Is.EqualTo(v.z));
            Assert.That("(41)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec2<string>("2", "((47)-1)");
            var v = ov.swizzle.rr;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((-1-7)-9)", "((-1-7)-9)");
            var v = ov.swizzle.rrr;
            Assert.That("((-1-7)-9)", Is.EqualTo(v.x));
            Assert.That("((-1-7)-9)", Is.EqualTo(v.y));
            Assert.That("((-1-7)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("4", "(73)");
            var v = ov.swizzle.rrrr;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-62)", "((55)3)");
            var v = ov.swizzle.rrrg;
            Assert.That("(-62)", Is.EqualTo(v.x));
            Assert.That("(-62)", Is.EqualTo(v.y));
            Assert.That("(-62)", Is.EqualTo(v.z));
            Assert.That("((55)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("3", "(-4-6)");
            var v = ov.swizzle.rrg;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(-4-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("(-8-1)", "1");
            var v = ov.swizzle.rrgr;
            Assert.That("(-8-1)", Is.EqualTo(v.x));
            Assert.That("(-8-1)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("(-8-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("", "(-16)");
            var v = ov.swizzle.rrgg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-16)", Is.EqualTo(v.z));
            Assert.That("(-16)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((54)-5)", "(5-6)");
            var v = ov.swizzle.rg;
            Assert.That("((54)-5)", Is.EqualTo(v.x));
            Assert.That("(5-6)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("1", "(9-2)");
            var v = ov.swizzle.rgr;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(9-2)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("-4", "(7-7)");
            var v = ov.swizzle.rgrr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(7-7)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(-1-3)", "((9-3)-7)");
            var v = ov.swizzle.rgrg;
            Assert.That("(-1-3)", Is.EqualTo(v.x));
            Assert.That("((9-3)-7)", Is.EqualTo(v.y));
            Assert.That("(-1-3)", Is.EqualTo(v.z));
            Assert.That("((9-3)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-1-9)-9)", "2");
            var v = ov.swizzle.rgg;
            Assert.That("((-1-9)-9)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("", "(2-5)");
            var v = ov.swizzle.rggr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(2-5)", Is.EqualTo(v.y));
            Assert.That("(2-5)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("null", "7");
            var v = ov.swizzle.rggg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((7-9)-8)", "");
            var v = ov.swizzle.gr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((7-9)-8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("((-50)2)", "-7");
            var v = ov.swizzle.grr;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-50)2)", Is.EqualTo(v.y));
            Assert.That("((-50)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("4", "((10)-1)");
            var v = ov.swizzle.grrr;
            Assert.That("((10)-1)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("3", "((-61)-2)");
            var v = ov.swizzle.grrg;
            Assert.That("((-61)-2)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("((-61)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((-6-6)8)", "((-6-6)8)");
            var v = ov.swizzle.grg;
            Assert.That("((-6-6)8)", Is.EqualTo(v.x));
            Assert.That("((-6-6)8)", Is.EqualTo(v.y));
            Assert.That("((-6-6)8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("((29)6)", "(3-4)");
            var v = ov.swizzle.grgr;
            Assert.That("(3-4)", Is.EqualTo(v.x));
            Assert.That("((29)6)", Is.EqualTo(v.y));
            Assert.That("(3-4)", Is.EqualTo(v.z));
            Assert.That("((29)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(9-3)", "((39)3)");
            var v = ov.swizzle.grgg;
            Assert.That("((39)3)", Is.EqualTo(v.x));
            Assert.That("(9-3)", Is.EqualTo(v.y));
            Assert.That("((39)3)", Is.EqualTo(v.z));
            Assert.That("((39)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("((06)8)", "");
            var v = ov.swizzle.gg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec2<string>("(12)", "((-4-2)4)");
            var v = ov.swizzle.ggr;
            Assert.That("((-4-2)4)", Is.EqualTo(v.x));
            Assert.That("((-4-2)4)", Is.EqualTo(v.y));
            Assert.That("(12)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("null", "((-87)-1)");
            var v = ov.swizzle.ggrr;
            Assert.That("((-87)-1)", Is.EqualTo(v.x));
            Assert.That("((-87)-1)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("(73)", "null");
            var v = ov.swizzle.ggrg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(73)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("1", "(35)");
            var v = ov.swizzle.ggg;
            Assert.That("(35)", Is.EqualTo(v.x));
            Assert.That("(35)", Is.EqualTo(v.y));
            Assert.That("(35)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec2<string>("-2", "(65)");
            var v = ov.swizzle.gggr;
            Assert.That("(65)", Is.EqualTo(v.x));
            Assert.That("(65)", Is.EqualTo(v.y));
            Assert.That("(65)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec2<string>("2", "6");
            var v = ov.swizzle.gggg;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec2<string>("(1-3)", "null");
            var v1 = new gvec2<string>("null", "(2-8)");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("(2-8)", Is.EqualTo(v0.y));
        
            Assert.That("(1-3)", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new gvec2<string>("((-40)8)", "null");
            var v1 = "((-63)1)";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-63)1)", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
        
            Assert.That("((-40)8)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec2<string>("((-23)-6)", "((0-6)-3)");
            var v1 = "-8";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-23)-6)", Is.EqualTo(v0.x));
            Assert.That("-8", Is.EqualTo(v0.y));
        
            Assert.That("((0-6)-3)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec2<string>("((-3-9)2)", "((-94)-3)");
            var v1 = new gvec2<string>("(-1-3)", "((-37)-2)");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-1-3)", Is.EqualTo(v0.x));
            Assert.That("((-37)-2)", Is.EqualTo(v0.y));
        
            Assert.That("((-3-9)2)", Is.EqualTo(v2.x));
            Assert.That("((-94)-3)", Is.EqualTo(v2.y));
        }
    }

}
