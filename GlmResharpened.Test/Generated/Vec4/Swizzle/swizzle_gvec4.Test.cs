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

namespace GlmResharpenedTest.Generated.Vec4_Swizzle;

[TestFixture]
public class TSwizzleVec4Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new gvec4<string>("((1-4)9)", "(1-2)", "4", "");
            var v = ov.swizzle.xx;
            Assert.That("((1-4)9)", Is.EqualTo(v.x));
            Assert.That("((1-4)9)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(64)", "5", "null", "5");
            var v = ov.swizzle.xxx;
            Assert.That("(64)", Is.EqualTo(v.x));
            Assert.That("(64)", Is.EqualTo(v.y));
            Assert.That("(64)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("4", "4", "(-35)", "((-45)0)");
            var v = ov.swizzle.xxxx;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(85)", "5", "((-12)8)", "null");
            var v = ov.swizzle.xxxy;
            Assert.That("(85)", Is.EqualTo(v.x));
            Assert.That("(85)", Is.EqualTo(v.y));
            Assert.That("(85)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((71)-8)", "7", "", "(6-5)");
            var v = ov.swizzle.xxxz;
            Assert.That("((71)-8)", Is.EqualTo(v.x));
            Assert.That("((71)-8)", Is.EqualTo(v.y));
            Assert.That("((71)-8)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "((-6-5)8)", "((-6-5)8)", "((10)5)");
            var v = ov.swizzle.xxxw;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((10)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-23)3)", "((-23)3)", "", "");
            var v = ov.swizzle.xxy;
            Assert.That("((-23)3)", Is.EqualTo(v.x));
            Assert.That("((-23)3)", Is.EqualTo(v.y));
            Assert.That("((-23)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(07)", "null", "(15)", "(15)");
            var v = ov.swizzle.xxyx;
            Assert.That("(07)", Is.EqualTo(v.x));
            Assert.That("(07)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(07)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-1)-8)", "-4", "(-8-2)", "(-8-1)");
            var v = ov.swizzle.xxyy;
            Assert.That("((9-1)-8)", Is.EqualTo(v.x));
            Assert.That("((9-1)-8)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-6)9)", "((5-6)9)", "((1-7)3)", "((36)-5)");
            var v = ov.swizzle.xxyz;
            Assert.That("((5-6)9)", Is.EqualTo(v.x));
            Assert.That("((5-6)9)", Is.EqualTo(v.y));
            Assert.That("((5-6)9)", Is.EqualTo(v.z));
            Assert.That("((1-7)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((90)-6)", "(50)", "-3", "((-72)7)");
            var v = ov.swizzle.xxyw;
            Assert.That("((90)-6)", Is.EqualTo(v.x));
            Assert.That("((90)-6)", Is.EqualTo(v.y));
            Assert.That("(50)", Is.EqualTo(v.z));
            Assert.That("((-72)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "null", "-1", "((-8-7)5)");
            var v = ov.swizzle.xxz;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("3", "((3-1)-8)", "", "");
            var v = ov.swizzle.xxzx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-52)9)", "((-52)9)", "", "null");
            var v = ov.swizzle.xxzy;
            Assert.That("((-52)9)", Is.EqualTo(v.x));
            Assert.That("((-52)9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-52)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((94)1)", "((2-6)-2)", "5", "5");
            var v = ov.swizzle.xxzz;
            Assert.That("((94)1)", Is.EqualTo(v.x));
            Assert.That("((94)1)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-40)", "2", "(-9-1)", "-6");
            var v = ov.swizzle.xxzw;
            Assert.That("(-40)", Is.EqualTo(v.x));
            Assert.That("(-40)", Is.EqualTo(v.y));
            Assert.That("(-9-1)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "", "-3", "null");
            var v = ov.swizzle.xxw;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(17)", "(35)", "-6");
            var v = ov.swizzle.xxwx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-3)", "7", "(78)", "3");
            var v = ov.swizzle.xxwy;
            Assert.That("(9-3)", Is.EqualTo(v.x));
            Assert.That("(9-3)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-81)", "(4-1)", "((-72)5)", "((6-8)4)");
            var v = ov.swizzle.xxwz;
            Assert.That("(-81)", Is.EqualTo(v.x));
            Assert.That("(-81)", Is.EqualTo(v.y));
            Assert.That("((6-8)4)", Is.EqualTo(v.z));
            Assert.That("((-72)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-8)-3)", "", "(55)", "");
            var v = ov.swizzle.xxww;
            Assert.That("((-2-8)-3)", Is.EqualTo(v.x));
            Assert.That("((-2-8)-3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "2", "(2-3)", "-7");
            var v = ov.swizzle.xy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-6", "", "((2-7)7)", "((1-4)-3)");
            var v = ov.swizzle.xyx;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-16)", "((-7-2)-2)", "(-28)", "-2");
            var v = ov.swizzle.xyxx;
            Assert.That("(-16)", Is.EqualTo(v.x));
            Assert.That("((-7-2)-2)", Is.EqualTo(v.y));
            Assert.That("(-16)", Is.EqualTo(v.z));
            Assert.That("(-16)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-26)-8)", "-4", "((22)-8)", "-4");
            var v = ov.swizzle.xyxy;
            Assert.That("((-26)-8)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((-26)-8)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-3)0)", "(4-7)", "(4-7)", "6");
            var v = ov.swizzle.xyxz;
            Assert.That("((-1-3)0)", Is.EqualTo(v.x));
            Assert.That("(4-7)", Is.EqualTo(v.y));
            Assert.That("((-1-3)0)", Is.EqualTo(v.z));
            Assert.That("(4-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "1", "1");
            var v = ov.swizzle.xyxw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "7", "null", "");
            var v = ov.swizzle.xyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-10)-7)", "(-3-1)", "-2", "-2");
            var v = ov.swizzle.xyyx;
            Assert.That("((-10)-7)", Is.EqualTo(v.x));
            Assert.That("(-3-1)", Is.EqualTo(v.y));
            Assert.That("(-3-1)", Is.EqualTo(v.z));
            Assert.That("((-10)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-44)", "-7", "-2", "-7");
            var v = ov.swizzle.xyyy;
            Assert.That("(-44)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "((7-4)6)", "(69)", "(69)");
            var v = ov.swizzle.xyyz;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((7-4)6)", Is.EqualTo(v.y));
            Assert.That("((7-4)6)", Is.EqualTo(v.z));
            Assert.That("(69)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-96)", "(73)", "(73)", "4");
            var v = ov.swizzle.xyyw;
            Assert.That("(-96)", Is.EqualTo(v.x));
            Assert.That("(73)", Is.EqualTo(v.y));
            Assert.That("(73)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-80)", "", "6", "null");
            var v = ov.swizzle.xyz;
            Assert.That("(-80)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(27)", "", "null");
            var v = ov.swizzle.xyzx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(27)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "((20)8)", "-6", "4");
            var v = ov.swizzle.xyzy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((20)8)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((20)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "6", "(94)", "(-4-8)");
            var v = ov.swizzle.xyzz;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(94)", Is.EqualTo(v.z));
            Assert.That("(94)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "-3", "null");
            var v = ov.swizzle.xyzw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((97)3)", "(-6-9)", "");
            var v = ov.swizzle.xyw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((97)3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "", "", "(58)");
            var v = ov.swizzle.xywx;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(58)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "null", "2", "");
            var v = ov.swizzle.xywy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((64)-6)", "((64)-6)", "((64)-6)", "1");
            var v = ov.swizzle.xywz;
            Assert.That("((64)-6)", Is.EqualTo(v.x));
            Assert.That("((64)-6)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("((64)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((08)-1)", "6", "((-7-8)7)", "(7-9)");
            var v = ov.swizzle.xyww;
            Assert.That("((08)-1)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(7-9)", Is.EqualTo(v.z));
            Assert.That("(7-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "6", "((7-4)-6)", "null");
            var v = ov.swizzle.xz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((7-4)-6)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("null", "(38)", "(2-4)", "null");
            var v = ov.swizzle.xzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(2-4)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(71)", "((7-8)2)", "((7-8)2)", "");
            var v = ov.swizzle.xzxx;
            Assert.That("(71)", Is.EqualTo(v.x));
            Assert.That("((7-8)2)", Is.EqualTo(v.y));
            Assert.That("(71)", Is.EqualTo(v.z));
            Assert.That("(71)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-1", "((-43)-1)", "(3-8)");
            var v = ov.swizzle.xzxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-43)-1)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "2", "((7-6)0)", "");
            var v = ov.swizzle.xzxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((7-6)0)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((7-6)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(5-3)", "(37)", "null");
            var v = ov.swizzle.xzxw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(37)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-22)0)", "((8-9)5)", "((-22)0)", "(-30)");
            var v = ov.swizzle.xzy;
            Assert.That("((-22)0)", Is.EqualTo(v.x));
            Assert.That("((-22)0)", Is.EqualTo(v.y));
            Assert.That("((8-9)5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-2", "(67)", "(6-6)", "-2");
            var v = ov.swizzle.xzyx;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("(6-6)", Is.EqualTo(v.y));
            Assert.That("(67)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-4)-6)", "4", "null", "(0-2)");
            var v = ov.swizzle.xzyy;
            Assert.That("((-4-4)-6)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((79)-3)", "((-3-9)6)", "((79)-3)", "null");
            var v = ov.swizzle.xzyz;
            Assert.That("((79)-3)", Is.EqualTo(v.x));
            Assert.That("((79)-3)", Is.EqualTo(v.y));
            Assert.That("((-3-9)6)", Is.EqualTo(v.z));
            Assert.That("((79)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "(-9-3)", "null", "((-1-5)0)");
            var v = ov.swizzle.xzyw;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-9-3)", Is.EqualTo(v.z));
            Assert.That("((-1-5)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-14)", "(-14)", "-3", "((45)1)");
            var v = ov.swizzle.xzz;
            Assert.That("(-14)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-8", "-8", "((-3-3)6)", "");
            var v = ov.swizzle.xzzx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((-3-3)6)", Is.EqualTo(v.y));
            Assert.That("((-3-3)6)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "((-67)-4)", "0", "null");
            var v = ov.swizzle.xzzy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("((-67)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-4)7)", "null", "(-6-5)", "");
            var v = ov.swizzle.xzzz;
            Assert.That("((-8-4)7)", Is.EqualTo(v.x));
            Assert.That("(-6-5)", Is.EqualTo(v.y));
            Assert.That("(-6-5)", Is.EqualTo(v.z));
            Assert.That("(-6-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "null", "(9-3)");
            var v = ov.swizzle.xzzw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(9-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-6)4)", "(-72)", "", "9");
            var v = ov.swizzle.xzw;
            Assert.That("((9-6)4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(72)", "", "((-15)3)", "3");
            var v = ov.swizzle.xzwx;
            Assert.That("(72)", Is.EqualTo(v.x));
            Assert.That("((-15)3)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("(72)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "(-9-3)", "(32)", "7");
            var v = ov.swizzle.xzwy;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("(32)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(-9-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-72)-2)", "null", "(-3-9)", "(-6-5)");
            var v = ov.swizzle.xzwz;
            Assert.That("((-72)-2)", Is.EqualTo(v.x));
            Assert.That("(-3-9)", Is.EqualTo(v.y));
            Assert.That("(-6-5)", Is.EqualTo(v.z));
            Assert.That("(-3-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "7", "-7");
            var v = ov.swizzle.xzww;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "((6-8)8)", "null", "-1");
            var v = ov.swizzle.xw;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-2-1)-4)", "((-70)-2)", "((-2-1)-4)", "7");
            var v = ov.swizzle.xwx;
            Assert.That("((-2-1)-4)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("((-2-1)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(14)", "(14)", "((-26)-5)", "(-8-4)");
            var v = ov.swizzle.xwxx;
            Assert.That("(14)", Is.EqualTo(v.x));
            Assert.That("(-8-4)", Is.EqualTo(v.y));
            Assert.That("(14)", Is.EqualTo(v.z));
            Assert.That("(14)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(-27)", "(-70)", "-9");
            var v = ov.swizzle.xwxy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("(-27)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "null", "(-40)");
            var v = ov.swizzle.xwxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-40)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "((-1-9)6)", "-1");
            var v = ov.swizzle.xwxw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-2)-6)", "-4", "((59)0)", "(5-4)");
            var v = ov.swizzle.xwy;
            Assert.That("((-1-2)-6)", Is.EqualTo(v.x));
            Assert.That("(5-4)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("9", "null", "(0-3)", "((-7-2)-8)");
            var v = ov.swizzle.xwyx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((-7-2)-8)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-74)", "-7", "(96)", "(9-5)");
            var v = ov.swizzle.xwyy;
            Assert.That("(-74)", Is.EqualTo(v.x));
            Assert.That("(9-5)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-85)-5)", "((02)5)", "null", "((02)5)");
            var v = ov.swizzle.xwyz;
            Assert.That("((-85)-5)", Is.EqualTo(v.x));
            Assert.That("((02)5)", Is.EqualTo(v.y));
            Assert.That("((02)5)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-27)4)", "", "((-5-1)4)", "((-59)9)");
            var v = ov.swizzle.xwyw;
            Assert.That("((-27)4)", Is.EqualTo(v.x));
            Assert.That("((-59)9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-59)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-89)1)", "((78)2)", "");
            var v = ov.swizzle.xwz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((78)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("8", "", "(-2-6)", "3");
            var v = ov.swizzle.xwzx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(-2-6)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-2)", "(61)", "", "8");
            var v = ov.swizzle.xwzy;
            Assert.That("(7-2)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(61)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "((5-1)-3)", "((-21)-9)", "-2");
            var v = ov.swizzle.xwzz;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((-21)-9)", Is.EqualTo(v.z));
            Assert.That("((-21)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(73)", "7", "((-45)3)");
            var v = ov.swizzle.xwzw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-45)3)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((-45)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((32)3)", "null", "", "null");
            var v = ov.swizzle.xww;
            Assert.That("((32)3)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((77)-4)", "(-48)", "(-48)", "(77)");
            var v = ov.swizzle.xwwx;
            Assert.That("((77)-4)", Is.EqualTo(v.x));
            Assert.That("(77)", Is.EqualTo(v.y));
            Assert.That("(77)", Is.EqualTo(v.z));
            Assert.That("((77)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-2)", "((02)-6)", "((6-6)8)", "-1");
            var v = ov.swizzle.xwwy;
            Assert.That("(-6-2)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("((02)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(-56)", "2", "(-56)");
            var v = ov.swizzle.xwwz;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-56)", Is.EqualTo(v.y));
            Assert.That("(-56)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(23)", "(-66)", "((17)-4)", "((63)6)");
            var v = ov.swizzle.xwww;
            Assert.That("(23)", Is.EqualTo(v.x));
            Assert.That("((63)6)", Is.EqualTo(v.y));
            Assert.That("((63)6)", Is.EqualTo(v.z));
            Assert.That("((63)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-68)7)", "-4", "", "((-87)4)");
            var v = ov.swizzle.yx;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("((-68)7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("", "((96)-5)", "", "(-6-1)");
            var v = ov.swizzle.yxx;
            Assert.That("((96)-5)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((9-4)-6)", "(-66)", "(-22)", "6");
            var v = ov.swizzle.yxxx;
            Assert.That("(-66)", Is.EqualTo(v.x));
            Assert.That("((9-4)-6)", Is.EqualTo(v.y));
            Assert.That("((9-4)-6)", Is.EqualTo(v.z));
            Assert.That("((9-4)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-87)", "-8", "(4-9)");
            var v = ov.swizzle.yxxy;
            Assert.That("(-87)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-87)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-8", "1", "((-22)-6)");
            var v = ov.swizzle.yxxz;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-1)", "null", "", "null");
            var v = ov.swizzle.yxxw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-8-1)", Is.EqualTo(v.y));
            Assert.That("(-8-1)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(49)", "(4-4)", "-2", "((-1-6)-1)");
            var v = ov.swizzle.yxy;
            Assert.That("(4-4)", Is.EqualTo(v.x));
            Assert.That("(49)", Is.EqualTo(v.y));
            Assert.That("(4-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(97)", "9", "9", "-2");
            var v = ov.swizzle.yxyx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(97)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("(97)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((68)4)", "((-99)-1)", "", "((57)-1)");
            var v = ov.swizzle.yxyy;
            Assert.That("((-99)-1)", Is.EqualTo(v.x));
            Assert.That("((68)4)", Is.EqualTo(v.y));
            Assert.That("((-99)-1)", Is.EqualTo(v.z));
            Assert.That("((-99)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-3)-9)", "null", "((3-3)-9)", "(-84)");
            var v = ov.swizzle.yxyz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((3-3)-9)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((3-3)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((18)7)", "((-12)-2)", "null", "4");
            var v = ov.swizzle.yxyw;
            Assert.That("((-12)-2)", Is.EqualTo(v.x));
            Assert.That("((18)7)", Is.EqualTo(v.y));
            Assert.That("((-12)-2)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-51)", "1", "", "(-51)");
            var v = ov.swizzle.yxz;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(-51)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "null", "9", "null");
            var v = ov.swizzle.yxzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "(-40)", "null", "");
            var v = ov.swizzle.yxzy;
            Assert.That("(-40)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-40)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-42)", "(5-6)", "-2", "null");
            var v = ov.swizzle.yxzz;
            Assert.That("(5-6)", Is.EqualTo(v.x));
            Assert.That("(-42)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "(37)", "((-8-9)1)", "5");
            var v = ov.swizzle.yxzw;
            Assert.That("(37)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("((-8-9)1)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(2-9)", "6", "6");
            var v = ov.swizzle.yxw;
            Assert.That("(2-9)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(56)", "(-34)", "((6-4)-9)", "5");
            var v = ov.swizzle.yxwx;
            Assert.That("(-34)", Is.EqualTo(v.x));
            Assert.That("(56)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("(56)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-64)", "", "((-4-9)-1)");
            var v = ov.swizzle.yxwy;
            Assert.That("(-64)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-4-9)-1)", Is.EqualTo(v.z));
            Assert.That("(-64)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(-9-6)", "((-85)0)", "((-20)-3)");
            var v = ov.swizzle.yxwz;
            Assert.That("(-9-6)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((-20)-3)", Is.EqualTo(v.z));
            Assert.That("((-85)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "0", "null", "null");
            var v = ov.swizzle.yxww;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "((-64)3)", "((-64)3)");
            var v = ov.swizzle.yy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-6", "(-12)", "((85)2)", "(2-4)");
            var v = ov.swizzle.yyx;
            Assert.That("(-12)", Is.EqualTo(v.x));
            Assert.That("(-12)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-1", "1", "((92)7)", "-9");
            var v = ov.swizzle.yyxx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-96)", "null", "(-96)", "((26)2)");
            var v = ov.swizzle.yyxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-96)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "5", "5", "((46)5)");
            var v = ov.swizzle.yyxz;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-7)", "8", "((-58)-9)", "null");
            var v = ov.swizzle.yyxw;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-2-7)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-35)-9)", "((01)-1)", "((-35)-9)", "((-35)-9)");
            var v = ov.swizzle.yyy;
            Assert.That("((01)-1)", Is.EqualTo(v.x));
            Assert.That("((01)-1)", Is.EqualTo(v.y));
            Assert.That("((01)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "null", "null", "((-6-4)0)");
            var v = ov.swizzle.yyyx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "(-7-3)", "(57)", "0");
            var v = ov.swizzle.yyyy;
            Assert.That("(-7-3)", Is.EqualTo(v.x));
            Assert.That("(-7-3)", Is.EqualTo(v.y));
            Assert.That("(-7-3)", Is.EqualTo(v.z));
            Assert.That("(-7-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(6-6)", "(6-6)", "0");
            var v = ov.swizzle.yyyz;
            Assert.That("(6-6)", Is.EqualTo(v.x));
            Assert.That("(6-6)", Is.EqualTo(v.y));
            Assert.That("(6-6)", Is.EqualTo(v.z));
            Assert.That("(6-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((02)-2)", "null", "(49)", "(8-7)");
            var v = ov.swizzle.yyyw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(8-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-9)", "(9-5)", "(-1-9)", "");
            var v = ov.swizzle.yyz;
            Assert.That("(9-5)", Is.EqualTo(v.x));
            Assert.That("(9-5)", Is.EqualTo(v.y));
            Assert.That("(-1-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-53)", "null", "((-10)-1)", "-9");
            var v = ov.swizzle.yyzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-10)-1)", Is.EqualTo(v.z));
            Assert.That("(-53)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((30)-9)", "-5", "0");
            var v = ov.swizzle.yyzy;
            Assert.That("((30)-9)", Is.EqualTo(v.x));
            Assert.That("((30)-9)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("((30)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "((-79)-9)", "-4", "");
            var v = ov.swizzle.yyzz;
            Assert.That("((-79)-9)", Is.EqualTo(v.x));
            Assert.That("((-79)-9)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-2)", "", "(-2-9)", "(-99)");
            var v = ov.swizzle.yyzw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-2-9)", Is.EqualTo(v.z));
            Assert.That("(-99)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "4", "((8-3)-7)", "(-1-2)");
            var v = ov.swizzle.yyw;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("(-1-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(91)", "((-23)2)", "-9", "((-23)2)");
            var v = ov.swizzle.yywx;
            Assert.That("((-23)2)", Is.EqualTo(v.x));
            Assert.That("((-23)2)", Is.EqualTo(v.y));
            Assert.That("((-23)2)", Is.EqualTo(v.z));
            Assert.That("(91)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(70)", "null", "((-13)1)", "(-67)");
            var v = ov.swizzle.yywy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-67)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "((83)3)", "", "-6");
            var v = ov.swizzle.yywz;
            Assert.That("((83)3)", Is.EqualTo(v.x));
            Assert.That("((83)3)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "((93)-3)", "-8");
            var v = ov.swizzle.yyww;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "-8", "null", "9");
            var v = ov.swizzle.yz;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-35)", "((-91)9)", "-8", "(-35)");
            var v = ov.swizzle.yzx;
            Assert.That("((-91)9)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(-35)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-1-7)", "-7", "(56)", "(79)");
            var v = ov.swizzle.yzxx;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(56)", Is.EqualTo(v.y));
            Assert.That("(-1-7)", Is.EqualTo(v.z));
            Assert.That("(-1-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "-7", "(0-8)", "(0-8)");
            var v = ov.swizzle.yzxy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(0-8)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "-2", "5", "(43)");
            var v = ov.swizzle.yzxz;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-1)-9)", "((0-9)4)", "((57)-7)", "((0-9)4)");
            var v = ov.swizzle.yzxw;
            Assert.That("((0-9)4)", Is.EqualTo(v.x));
            Assert.That("((57)-7)", Is.EqualTo(v.y));
            Assert.That("((-7-1)-9)", Is.EqualTo(v.z));
            Assert.That("((0-9)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "0", "null", "((53)-2)");
            var v = ov.swizzle.yzy;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-81)", "0", "(-81)", "(85)");
            var v = ov.swizzle.yzyx;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(-81)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("(-81)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "-3", "null", "(57)");
            var v = ov.swizzle.yzyy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(-9-9)", "(-1-8)", "0");
            var v = ov.swizzle.yzyz;
            Assert.That("(-9-9)", Is.EqualTo(v.x));
            Assert.That("(-1-8)", Is.EqualTo(v.y));
            Assert.That("(-9-9)", Is.EqualTo(v.z));
            Assert.That("(-1-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((03)3)", "-9", "null");
            var v = ov.swizzle.yzyw;
            Assert.That("((03)3)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((03)3)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-85)", "(3-7)", "(2-4)", "((4-2)0)");
            var v = ov.swizzle.yzz;
            Assert.That("(3-7)", Is.EqualTo(v.x));
            Assert.That("(2-4)", Is.EqualTo(v.y));
            Assert.That("(2-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-4", "-4", "-4", "");
            var v = ov.swizzle.yzzx;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "null", "-2", "-1");
            var v = ov.swizzle.yzzy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-2)", "-7", "0", "(-2-2)");
            var v = ov.swizzle.yzzz;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "(-80)", "5", "null");
            var v = ov.swizzle.yzzw;
            Assert.That("(-80)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(86)", "(97)", "(-38)", "(97)");
            var v = ov.swizzle.yzw;
            Assert.That("(97)", Is.EqualTo(v.x));
            Assert.That("(-38)", Is.EqualTo(v.y));
            Assert.That("(97)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-28)", "(-28)", "(-47)", "((-81)-2)");
            var v = ov.swizzle.yzwx;
            Assert.That("(-28)", Is.EqualTo(v.x));
            Assert.That("(-47)", Is.EqualTo(v.y));
            Assert.That("((-81)-2)", Is.EqualTo(v.z));
            Assert.That("(-28)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "(-32)", "(37)", "");
            var v = ov.swizzle.yzwy;
            Assert.That("(-32)", Is.EqualTo(v.x));
            Assert.That("(37)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-32)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-9)", "7", "((7-8)-5)", "((-6-1)7)");
            var v = ov.swizzle.yzwz;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((7-8)-5)", Is.EqualTo(v.y));
            Assert.That("((-6-1)7)", Is.EqualTo(v.z));
            Assert.That("((7-8)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(76)", "((1-6)-1)", "((76)2)", "((76)2)");
            var v = ov.swizzle.yzww;
            Assert.That("((1-6)-1)", Is.EqualTo(v.x));
            Assert.That("((76)2)", Is.EqualTo(v.y));
            Assert.That("((76)2)", Is.EqualTo(v.z));
            Assert.That("((76)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-45)", "", "(-54)", "");
            var v = ov.swizzle.yw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-9-4)8)", "((-9-4)8)", "", "(-2-1)");
            var v = ov.swizzle.ywx;
            Assert.That("((-9-4)8)", Is.EqualTo(v.x));
            Assert.That("(-2-1)", Is.EqualTo(v.y));
            Assert.That("((-9-4)8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-2", "-9", "((-32)5)", "-9");
            var v = ov.swizzle.ywxx;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "((84)-8)", "(-17)", "");
            var v = ov.swizzle.ywxy;
            Assert.That("((84)-8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("((84)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-7)-4)", "(83)", "", "((-8-7)-4)");
            var v = ov.swizzle.ywxz;
            Assert.That("(83)", Is.EqualTo(v.x));
            Assert.That("((-8-7)-4)", Is.EqualTo(v.y));
            Assert.That("((-8-7)-4)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-8)", "((-2-1)-3)", "(-1-7)", "");
            var v = ov.swizzle.ywxw;
            Assert.That("((-2-1)-3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-6-8)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((14)-1)", "null", "((-11)4)", "(-4-8)");
            var v = ov.swizzle.ywy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-4-8)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-8", "(-94)", "-8", "(1-8)");
            var v = ov.swizzle.ywyx;
            Assert.That("(-94)", Is.EqualTo(v.x));
            Assert.That("(1-8)", Is.EqualTo(v.y));
            Assert.That("(-94)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-4)-6)", "(-30)", "-2", "9");
            var v = ov.swizzle.ywyy;
            Assert.That("(-30)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("(-30)", Is.EqualTo(v.z));
            Assert.That("(-30)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-6)", "(-2-1)", "(-85)", "null");
            var v = ov.swizzle.ywyz;
            Assert.That("(-2-1)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-2-1)", Is.EqualTo(v.z));
            Assert.That("(-85)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-3)", "((86)7)", "-5", "((86)7)");
            var v = ov.swizzle.ywyw;
            Assert.That("((86)7)", Is.EqualTo(v.x));
            Assert.That("((86)7)", Is.EqualTo(v.y));
            Assert.That("((86)7)", Is.EqualTo(v.z));
            Assert.That("((86)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((21)1)", "-5", "((-33)-3)");
            var v = ov.swizzle.ywz;
            Assert.That("((21)1)", Is.EqualTo(v.x));
            Assert.That("((-33)-3)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-79)-2)", "null", "-9", "((-79)-2)");
            var v = ov.swizzle.ywzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-79)-2)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("((-79)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-1)", "3", "(72)", "(72)");
            var v = ov.swizzle.ywzy;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(72)", Is.EqualTo(v.y));
            Assert.That("(72)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "-6", "(3-1)", "((2-3)7)");
            var v = ov.swizzle.ywzz;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((2-3)7)", Is.EqualTo(v.y));
            Assert.That("(3-1)", Is.EqualTo(v.z));
            Assert.That("(3-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-6)", "", "((9-4)5)", "(1-6)");
            var v = ov.swizzle.ywzw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(1-6)", Is.EqualTo(v.y));
            Assert.That("((9-4)5)", Is.EqualTo(v.z));
            Assert.That("(1-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-68)", "((5-9)8)", "", "((2-4)-9)");
            var v = ov.swizzle.yww;
            Assert.That("((5-9)8)", Is.EqualTo(v.x));
            Assert.That("((2-4)-9)", Is.EqualTo(v.y));
            Assert.That("((2-4)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-7", "((4-9)5)", "8", "8");
            var v = ov.swizzle.ywwx;
            Assert.That("((4-9)5)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-92)-4)", "-7", "-7", "5");
            var v = ov.swizzle.ywwy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(61)", "null", "((-13)2)", "((22)-3)");
            var v = ov.swizzle.ywwz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((22)-3)", Is.EqualTo(v.y));
            Assert.That("((22)-3)", Is.EqualTo(v.z));
            Assert.That("((-13)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-1)1)", "((31)-6)", "-4", "(6-9)");
            var v = ov.swizzle.ywww;
            Assert.That("((31)-6)", Is.EqualTo(v.x));
            Assert.That("(6-9)", Is.EqualTo(v.y));
            Assert.That("(6-9)", Is.EqualTo(v.z));
            Assert.That("(6-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(67)", "(0-8)", "((22)-6)");
            var v = ov.swizzle.zx;
            Assert.That("(0-8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-9", "((58)-2)", "(-67)", "((15)-6)");
            var v = ov.swizzle.zxx;
            Assert.That("(-67)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "null", "-1", "(0-9)");
            var v = ov.swizzle.zxxx;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-15)", "((-30)4)", "((-6-7)-7)", "-3");
            var v = ov.swizzle.zxxy;
            Assert.That("((-6-7)-7)", Is.EqualTo(v.x));
            Assert.That("(-15)", Is.EqualTo(v.y));
            Assert.That("(-15)", Is.EqualTo(v.z));
            Assert.That("((-30)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "((-1-3)1)", "((-1-3)1)", "((15)3)");
            var v = ov.swizzle.zxxz;
            Assert.That("((-1-3)1)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((-1-3)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "4", "4", "1");
            var v = ov.swizzle.zxxw;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((5-1)1)", "null", "(47)");
            var v = ov.swizzle.zxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("((5-1)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-96)", "(-5-8)", "((-8-2)6)", "((-8-2)6)");
            var v = ov.swizzle.zxyx;
            Assert.That("((-8-2)6)", Is.EqualTo(v.x));
            Assert.That("(-96)", Is.EqualTo(v.y));
            Assert.That("(-5-8)", Is.EqualTo(v.z));
            Assert.That("(-96)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-44)", "((55)7)", "(-44)", "((19)0)");
            var v = ov.swizzle.zxyy;
            Assert.That("(-44)", Is.EqualTo(v.x));
            Assert.That("(-44)", Is.EqualTo(v.y));
            Assert.That("((55)7)", Is.EqualTo(v.z));
            Assert.That("((55)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-7)5)", "((-6-7)5)", "((-5-7)-1)", "9");
            var v = ov.swizzle.zxyz;
            Assert.That("((-5-7)-1)", Is.EqualTo(v.x));
            Assert.That("((-6-7)5)", Is.EqualTo(v.y));
            Assert.That("((-6-7)5)", Is.EqualTo(v.z));
            Assert.That("((-5-7)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(-4-4)", "-7", "-4");
            var v = ov.swizzle.zxyw;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(-4-4)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "", "null", "(58)");
            var v = ov.swizzle.zxz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-5", "((21)-3)", "(-87)", "-5");
            var v = ov.swizzle.zxzx;
            Assert.That("(-87)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(-87)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "", "-6", "((83)-2)");
            var v = ov.swizzle.zxzy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(37)", "", "-4", "");
            var v = ov.swizzle.zxzz;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(37)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "(-7-7)", "6", "");
            var v = ov.swizzle.zxzw;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-7)", "-6", "((-2-5)-2)", "");
            var v = ov.swizzle.zxw;
            Assert.That("((-2-5)-2)", Is.EqualTo(v.x));
            Assert.That("(6-7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-2-2)4)", "null", "(57)", "");
            var v = ov.swizzle.zxwx;
            Assert.That("(57)", Is.EqualTo(v.x));
            Assert.That("((-2-2)4)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-2-2)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "(7-6)", "");
            var v = ov.swizzle.zxwy;
            Assert.That("(7-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-21)", "(-21)", "((-5-2)-3)", "(0-2)");
            var v = ov.swizzle.zxwz;
            Assert.That("((-5-2)-3)", Is.EqualTo(v.x));
            Assert.That("(-21)", Is.EqualTo(v.y));
            Assert.That("(0-2)", Is.EqualTo(v.z));
            Assert.That("((-5-2)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-89)3)", "(-2-4)", "(9-9)", "(5-9)");
            var v = ov.swizzle.zxww;
            Assert.That("(9-9)", Is.EqualTo(v.x));
            Assert.That("((-89)3)", Is.EqualTo(v.y));
            Assert.That("(5-9)", Is.EqualTo(v.z));
            Assert.That("(5-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-3)4)", "(7-4)", "((-14)2)", "-1");
            var v = ov.swizzle.zy;
            Assert.That("((-14)2)", Is.EqualTo(v.x));
            Assert.That("(7-4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-80)3)", "3", "", "((-24)-8)");
            var v = ov.swizzle.zyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((-80)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("1", "(-55)", "1", "(-55)");
            var v = ov.swizzle.zyxx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(-55)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-3)", "(-6-3)", "(-74)", "(-74)");
            var v = ov.swizzle.zyxy;
            Assert.That("(-74)", Is.EqualTo(v.x));
            Assert.That("(-6-3)", Is.EqualTo(v.y));
            Assert.That("(-6-3)", Is.EqualTo(v.z));
            Assert.That("(-6-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(25)", "((6-5)5)", "(6-3)", "null");
            var v = ov.swizzle.zyxz;
            Assert.That("(6-3)", Is.EqualTo(v.x));
            Assert.That("((6-5)5)", Is.EqualTo(v.y));
            Assert.That("(25)", Is.EqualTo(v.z));
            Assert.That("(6-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "2", "1", "1");
            var v = ov.swizzle.zyxw;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((31)4)", "(-6-9)", "(6-4)");
            var v = ov.swizzle.zyy;
            Assert.That("(-6-9)", Is.EqualTo(v.x));
            Assert.That("((31)4)", Is.EqualTo(v.y));
            Assert.That("((31)4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((79)-7)", "3", "((-64)-5)", "((79)-7)");
            var v = ov.swizzle.zyyx;
            Assert.That("((-64)-5)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("((79)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-5)-3)", "(51)", "-2", "");
            var v = ov.swizzle.zyyy;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("(51)", Is.EqualTo(v.y));
            Assert.That("(51)", Is.EqualTo(v.z));
            Assert.That("(51)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(45)", "(-9-6)", "0");
            var v = ov.swizzle.zyyz;
            Assert.That("(-9-6)", Is.EqualTo(v.x));
            Assert.That("(45)", Is.EqualTo(v.y));
            Assert.That("(45)", Is.EqualTo(v.z));
            Assert.That("(-9-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-5)", "(-1-9)", "2", "(1-5)");
            var v = ov.swizzle.zyyw;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-1-9)", Is.EqualTo(v.y));
            Assert.That("(-1-9)", Is.EqualTo(v.z));
            Assert.That("(1-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-6", "-6", "8");
            var v = ov.swizzle.zyz;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(17)", "-8", "-8", "");
            var v = ov.swizzle.zyzx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("(17)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-5)4)", "null", "-9", "(-8-9)");
            var v = ov.swizzle.zyzy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-1)-4)", "(-48)", "((-9-2)-5)", "null");
            var v = ov.swizzle.zyzz;
            Assert.That("((-9-2)-5)", Is.EqualTo(v.x));
            Assert.That("(-48)", Is.EqualTo(v.y));
            Assert.That("((-9-2)-5)", Is.EqualTo(v.z));
            Assert.That("((-9-2)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-51)", "9", "9", "((28)-4)");
            var v = ov.swizzle.zyzw;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("((28)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(3-8)", "-3", "-3", "-2");
            var v = ov.swizzle.zyw;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "", "5", "null");
            var v = ov.swizzle.zywx;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-2)", "", "(15)", "null");
            var v = ov.swizzle.zywy;
            Assert.That("(15)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-6)", "(55)", "null", "3");
            var v = ov.swizzle.zywz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(55)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(90)", "", "7", "(90)");
            var v = ov.swizzle.zyww;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(90)", Is.EqualTo(v.z));
            Assert.That("(90)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-6)-2)", "(-5-9)", "((-5-6)-2)", "((-90)-8)");
            var v = ov.swizzle.zz;
            Assert.That("((-5-6)-2)", Is.EqualTo(v.x));
            Assert.That("((-5-6)-2)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-1", "", "(84)", "-3");
            var v = ov.swizzle.zzx;
            Assert.That("(84)", Is.EqualTo(v.x));
            Assert.That("(84)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((73)-1)", "null", "((-1-3)-1)", "");
            var v = ov.swizzle.zzxx;
            Assert.That("((-1-3)-1)", Is.EqualTo(v.x));
            Assert.That("((-1-3)-1)", Is.EqualTo(v.y));
            Assert.That("((73)-1)", Is.EqualTo(v.z));
            Assert.That("((73)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "-8", "", "((5-7)-6)");
            var v = ov.swizzle.zzxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "2", "2", "((-5-5)6)");
            var v = ov.swizzle.zzxz;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-22)", "((-4-9)4)", "null");
            var v = ov.swizzle.zzxw;
            Assert.That("((-4-9)4)", Is.EqualTo(v.x));
            Assert.That("((-4-9)4)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-1-6)", "(-1-6)", "null");
            var v = ov.swizzle.zzy;
            Assert.That("(-1-6)", Is.EqualTo(v.x));
            Assert.That("(-1-6)", Is.EqualTo(v.y));
            Assert.That("(-1-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("7", "((-7-9)4)", "null", "null");
            var v = ov.swizzle.zzyx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-7-9)4)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((-2-6)-8)", "3", "null");
            var v = ov.swizzle.zzyy;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((-2-6)-8)", Is.EqualTo(v.z));
            Assert.That("((-2-6)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-9)", "9", "", "((-30)6)");
            var v = ov.swizzle.zzyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-5)", "(9-9)", "(-32)", "");
            var v = ov.swizzle.zzyw;
            Assert.That("(-32)", Is.EqualTo(v.x));
            Assert.That("(-32)", Is.EqualTo(v.y));
            Assert.That("(9-9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "", "0", "((-40)5)");
            var v = ov.swizzle.zzz;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-3-8)", "(-8-8)", "((-6-1)4)", "((41)5)");
            var v = ov.swizzle.zzzx;
            Assert.That("((-6-1)4)", Is.EqualTo(v.x));
            Assert.That("((-6-1)4)", Is.EqualTo(v.y));
            Assert.That("((-6-1)4)", Is.EqualTo(v.z));
            Assert.That("(-3-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "null", "(17)", "((7-3)-8)");
            var v = ov.swizzle.zzzy;
            Assert.That("(17)", Is.EqualTo(v.x));
            Assert.That("(17)", Is.EqualTo(v.y));
            Assert.That("(17)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(8-6)", "-9", "((-2-2)8)");
            var v = ov.swizzle.zzzz;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((61)-3)", "null", "(-5-5)", "");
            var v = ov.swizzle.zzzw;
            Assert.That("(-5-5)", Is.EqualTo(v.x));
            Assert.That("(-5-5)", Is.EqualTo(v.y));
            Assert.That("(-5-5)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-6)-9)", "((-5-8)0)", "((-7-6)-9)", "5");
            var v = ov.swizzle.zzw;
            Assert.That("((-7-6)-9)", Is.EqualTo(v.x));
            Assert.That("((-7-6)-9)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(53)", "(-8-6)", "((0-1)3)", "(53)");
            var v = ov.swizzle.zzwx;
            Assert.That("((0-1)3)", Is.EqualTo(v.x));
            Assert.That("((0-1)3)", Is.EqualTo(v.y));
            Assert.That("(53)", Is.EqualTo(v.z));
            Assert.That("(53)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "(-41)", "");
            var v = ov.swizzle.zzwy;
            Assert.That("(-41)", Is.EqualTo(v.x));
            Assert.That("(-41)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(06)", "3", "((0-7)1)", "((0-7)1)");
            var v = ov.swizzle.zzwz;
            Assert.That("((0-7)1)", Is.EqualTo(v.x));
            Assert.That("((0-7)1)", Is.EqualTo(v.y));
            Assert.That("((0-7)1)", Is.EqualTo(v.z));
            Assert.That("((0-7)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "null", "-9", "");
            var v = ov.swizzle.zzww;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-3)", "(-63)", "", "-3");
            var v = ov.swizzle.zw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-40)-3)", "-6", "-6", "(-7-9)");
            var v = ov.swizzle.zwx;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("(-7-9)", Is.EqualTo(v.y));
            Assert.That("((-40)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((9-8)-3)", "", "7");
            var v = ov.swizzle.zwxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((37)5)", "((92)3)", "9", "(91)");
            var v = ov.swizzle.zwxy;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(91)", Is.EqualTo(v.y));
            Assert.That("((37)5)", Is.EqualTo(v.z));
            Assert.That("((92)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(3-5)", "((37)5)", "2");
            var v = ov.swizzle.zwxz;
            Assert.That("((37)5)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((37)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-45)8)", "-2", "3", "(-5-4)");
            var v = ov.swizzle.zwxw;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(-5-4)", Is.EqualTo(v.y));
            Assert.That("((-45)8)", Is.EqualTo(v.z));
            Assert.That("(-5-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "((-5-6)6)", "-2", "((3-3)-6)");
            var v = ov.swizzle.zwy;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((3-3)-6)", Is.EqualTo(v.y));
            Assert.That("((-5-6)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "-8", "(2-4)", "");
            var v = ov.swizzle.zwyx;
            Assert.That("(2-4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "((-16)1)", "4", "4");
            var v = ov.swizzle.zwyy;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((-16)1)", Is.EqualTo(v.z));
            Assert.That("((-16)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "((65)-2)", "-8", "((9-6)-7)");
            var v = ov.swizzle.zwyz;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((9-6)-7)", Is.EqualTo(v.y));
            Assert.That("((65)-2)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((98)-7)", "((0-6)-2)", "null", "");
            var v = ov.swizzle.zwyw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((0-6)-2)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "null", "(6-2)", "((67)0)");
            var v = ov.swizzle.zwz;
            Assert.That("(6-2)", Is.EqualTo(v.x));
            Assert.That("((67)0)", Is.EqualTo(v.y));
            Assert.That("(6-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((29)-1)", "(12)", "(30)");
            var v = ov.swizzle.zwzx;
            Assert.That("(12)", Is.EqualTo(v.x));
            Assert.That("(30)", Is.EqualTo(v.y));
            Assert.That("(12)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(25)", "((-21)-9)", "null", "8");
            var v = ov.swizzle.zwzy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-21)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-30)-3)", "((-30)-3)", "((-30)-3)", "(-9-9)");
            var v = ov.swizzle.zwzz;
            Assert.That("((-30)-3)", Is.EqualTo(v.x));
            Assert.That("(-9-9)", Is.EqualTo(v.y));
            Assert.That("((-30)-3)", Is.EqualTo(v.z));
            Assert.That("((-30)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "", "((-81)7)", "(-7-1)");
            var v = ov.swizzle.zwzw;
            Assert.That("((-81)7)", Is.EqualTo(v.x));
            Assert.That("(-7-1)", Is.EqualTo(v.y));
            Assert.That("((-81)7)", Is.EqualTo(v.z));
            Assert.That("(-7-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(6-5)", "((-22)3)", "null");
            var v = ov.swizzle.zww;
            Assert.That("((-22)3)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "0", "2", "");
            var v = ov.swizzle.zwwx;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((42)8)", "5", "-9");
            var v = ov.swizzle.zwwy;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("((42)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(3-4)", "((22)9)", "((9-6)0)");
            var v = ov.swizzle.zwwz;
            Assert.That("((22)9)", Is.EqualTo(v.x));
            Assert.That("((9-6)0)", Is.EqualTo(v.y));
            Assert.That("((9-6)0)", Is.EqualTo(v.z));
            Assert.That("((22)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-3)-4)", "-5", "(-21)", "((-3-1)5)");
            var v = ov.swizzle.zwww;
            Assert.That("(-21)", Is.EqualTo(v.x));
            Assert.That("((-3-1)5)", Is.EqualTo(v.y));
            Assert.That("((-3-1)5)", Is.EqualTo(v.z));
            Assert.That("((-3-1)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "", "3", "null");
            var v = ov.swizzle.wx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("null", "7", "((43)-3)", "5");
            var v = ov.swizzle.wxx;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-58)", "", "(20)", "(20)");
            var v = ov.swizzle.wxxx;
            Assert.That("(20)", Is.EqualTo(v.x));
            Assert.That("(-58)", Is.EqualTo(v.y));
            Assert.That("(-58)", Is.EqualTo(v.z));
            Assert.That("(-58)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-3)-2)", "4", "-1", "");
            var v = ov.swizzle.wxxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((9-3)-2)", Is.EqualTo(v.y));
            Assert.That("((9-3)-2)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-4)", "((6-8)5)", "2", "4");
            var v = ov.swizzle.wxxz;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("(7-4)", Is.EqualTo(v.y));
            Assert.That("(7-4)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(83)", "((97)9)", "-2");
            var v = ov.swizzle.wxxw;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-8)", "(3-1)", "((-1-9)6)", "-3");
            var v = ov.swizzle.wxy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(-9-8)", Is.EqualTo(v.y));
            Assert.That("(3-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((6-6)7)", "-6", "(78)", "(2-4)");
            var v = ov.swizzle.wxyx;
            Assert.That("(2-4)", Is.EqualTo(v.x));
            Assert.That("((6-6)7)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((6-6)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-1)0)", "", "", "(-70)");
            var v = ov.swizzle.wxyy;
            Assert.That("(-70)", Is.EqualTo(v.x));
            Assert.That("((4-1)0)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((33)-9)", "(-5-9)", "(4-1)", "((-6-3)3)");
            var v = ov.swizzle.wxyz;
            Assert.That("((-6-3)3)", Is.EqualTo(v.x));
            Assert.That("((33)-9)", Is.EqualTo(v.y));
            Assert.That("(-5-9)", Is.EqualTo(v.z));
            Assert.That("(4-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-5)0)", "-6", "((8-5)0)", "(3-7)");
            var v = ov.swizzle.wxyw;
            Assert.That("(3-7)", Is.EqualTo(v.x));
            Assert.That("((8-5)0)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("(3-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "(6-9)", "null", "8");
            var v = ov.swizzle.wxz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-1-2)", "(32)", "((-6-3)-1)", "3");
            var v = ov.swizzle.wxzx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(-1-2)", Is.EqualTo(v.y));
            Assert.That("((-6-3)-1)", Is.EqualTo(v.z));
            Assert.That("(-1-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-82)", "(-82)", "9");
            var v = ov.swizzle.wxzy;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-82)", Is.EqualTo(v.z));
            Assert.That("(-82)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "(-93)", "-5");
            var v = ov.swizzle.wxzz;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-93)", Is.EqualTo(v.z));
            Assert.That("(-93)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "-6", "(17)", "-6");
            var v = ov.swizzle.wxzw;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(17)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-92)", "(5-9)", "", "");
            var v = ov.swizzle.wxw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-92)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((-11)8)", "-1", "((-1-7)9)");
            var v = ov.swizzle.wxwx;
            Assert.That("((-1-7)9)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-1-7)9)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-77)5)", "((-77)5)", "(37)", "(37)");
            var v = ov.swizzle.wxwy;
            Assert.That("(37)", Is.EqualTo(v.x));
            Assert.That("((-77)5)", Is.EqualTo(v.y));
            Assert.That("(37)", Is.EqualTo(v.z));
            Assert.That("((-77)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(5-6)", "(5-6)", "");
            var v = ov.swizzle.wxwz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(5-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(20)", "((-40)8)", "((-40)8)");
            var v = ov.swizzle.wxww;
            Assert.That("((-40)8)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((-40)8)", Is.EqualTo(v.z));
            Assert.That("((-40)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-50)", "(23)", "9");
            var v = ov.swizzle.wy;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(-50)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((0-8)9)", "(7-1)", "((0-8)9)", "(7-1)");
            var v = ov.swizzle.wyx;
            Assert.That("(7-1)", Is.EqualTo(v.x));
            Assert.That("(7-1)", Is.EqualTo(v.y));
            Assert.That("((0-8)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-36)", "((64)5)", "((0-2)3)", "(-6-6)");
            var v = ov.swizzle.wyxx;
            Assert.That("(-6-6)", Is.EqualTo(v.x));
            Assert.That("((64)5)", Is.EqualTo(v.y));
            Assert.That("(-36)", Is.EqualTo(v.z));
            Assert.That("(-36)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-26)", "(86)", "(-26)", "(-26)");
            var v = ov.swizzle.wyxy;
            Assert.That("(-26)", Is.EqualTo(v.x));
            Assert.That("(86)", Is.EqualTo(v.y));
            Assert.That("(-26)", Is.EqualTo(v.z));
            Assert.That("(86)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-3)-7)", "-3", "-3", "(-60)");
            var v = ov.swizzle.wyxz;
            Assert.That("(-60)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("((-8-3)-7)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-20)-8)", "(-9-6)", "((-20)-8)", "((4-1)9)");
            var v = ov.swizzle.wyxw;
            Assert.That("((4-1)9)", Is.EqualTo(v.x));
            Assert.That("(-9-6)", Is.EqualTo(v.y));
            Assert.That("((-20)-8)", Is.EqualTo(v.z));
            Assert.That("((4-1)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "null", "5", "5");
            var v = ov.swizzle.wyy;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "6", "-3", "((-4-7)-7)");
            var v = ov.swizzle.wyyx;
            Assert.That("((-4-7)-7)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((38)-7)", "-2", "(9-5)");
            var v = ov.swizzle.wyyy;
            Assert.That("(9-5)", Is.EqualTo(v.x));
            Assert.That("((38)-7)", Is.EqualTo(v.y));
            Assert.That("((38)-7)", Is.EqualTo(v.z));
            Assert.That("((38)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "null", "((-37)-8)", "3");
            var v = ov.swizzle.wyyz;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-37)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((3-5)-8)", "9", "((-5-7)0)");
            var v = ov.swizzle.wyyw;
            Assert.That("((-5-7)0)", Is.EqualTo(v.x));
            Assert.That("((3-5)-8)", Is.EqualTo(v.y));
            Assert.That("((3-5)-8)", Is.EqualTo(v.z));
            Assert.That("((-5-7)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-83)", "(28)", "(-83)", "-2");
            var v = ov.swizzle.wyz;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("(28)", Is.EqualTo(v.y));
            Assert.That("(-83)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("7", "null", "(-55)", "");
            var v = ov.swizzle.wyzx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-55)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((61)5)", "(88)", "(88)", "((26)7)");
            var v = ov.swizzle.wyzy;
            Assert.That("((26)7)", Is.EqualTo(v.x));
            Assert.That("(88)", Is.EqualTo(v.y));
            Assert.That("(88)", Is.EqualTo(v.z));
            Assert.That("(88)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-5)-9)", "((09)-7)", "(-49)", "(-49)");
            var v = ov.swizzle.wyzz;
            Assert.That("(-49)", Is.EqualTo(v.x));
            Assert.That("((09)-7)", Is.EqualTo(v.y));
            Assert.That("(-49)", Is.EqualTo(v.z));
            Assert.That("(-49)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "-4", "null");
            var v = ov.swizzle.wyzw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-8)-1)", "((-30)8)", "", "(-9-8)");
            var v = ov.swizzle.wyw;
            Assert.That("(-9-8)", Is.EqualTo(v.x));
            Assert.That("((-30)8)", Is.EqualTo(v.y));
            Assert.That("(-9-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(2-2)", "", "5", "(2-2)");
            var v = ov.swizzle.wywx;
            Assert.That("(2-2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(2-2)", Is.EqualTo(v.z));
            Assert.That("(2-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-7)-7)", "((-7-7)-7)", "", "");
            var v = ov.swizzle.wywy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-7-7)-7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-7-7)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((56)-3)", "-2", "3", "3");
            var v = ov.swizzle.wywz;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-73)", "(-4-9)", "(-4-9)", "9");
            var v = ov.swizzle.wyww;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(-4-9)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-74)-3)", "((7-7)0)", "-6");
            var v = ov.swizzle.wz;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((7-7)0)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(5-8)", "", "2", "(9-4)");
            var v = ov.swizzle.wzx;
            Assert.That("(9-4)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(5-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((-1-4)9)", "-8", "((-1-4)9)");
            var v = ov.swizzle.wzxx;
            Assert.That("((-1-4)9)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-8)8)", "((9-4)6)", "((9-4)6)", "((-9-8)8)");
            var v = ov.swizzle.wzxy;
            Assert.That("((-9-8)8)", Is.EqualTo(v.x));
            Assert.That("((9-4)6)", Is.EqualTo(v.y));
            Assert.That("((-9-8)8)", Is.EqualTo(v.z));
            Assert.That("((9-4)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-5)", "-2", "", "(21)");
            var v = ov.swizzle.wzxz;
            Assert.That("(21)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-6-5)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-7", "((-4-4)-9)", "-7");
            var v = ov.swizzle.wzxw;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-4-4)-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((35)4)", "(-8-7)", "((2-9)-2)", "null");
            var v = ov.swizzle.wzy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((2-9)-2)", Is.EqualTo(v.y));
            Assert.That("(-8-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(46)", "((-83)-3)", "((-40)-5)", "");
            var v = ov.swizzle.wzyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-40)-5)", Is.EqualTo(v.y));
            Assert.That("((-83)-3)", Is.EqualTo(v.z));
            Assert.That("(46)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-19)", "(8-8)", "((1-5)8)");
            var v = ov.swizzle.wzyy;
            Assert.That("((1-5)8)", Is.EqualTo(v.x));
            Assert.That("(8-8)", Is.EqualTo(v.y));
            Assert.That("(-19)", Is.EqualTo(v.z));
            Assert.That("(-19)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-9)", "0", "((86)5)", "(-69)");
            var v = ov.swizzle.wzyz;
            Assert.That("(-69)", Is.EqualTo(v.x));
            Assert.That("((86)5)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("((86)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((61)6)", "-7", "(-1-1)", "null");
            var v = ov.swizzle.wzyw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-1-1)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-30)", "(-30)", "(-5-4)");
            var v = ov.swizzle.wzz;
            Assert.That("(-5-4)", Is.EqualTo(v.x));
            Assert.That("(-30)", Is.EqualTo(v.y));
            Assert.That("(-30)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((95)-3)", "((95)-3)", "(-96)", "");
            var v = ov.swizzle.wzzx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-96)", Is.EqualTo(v.y));
            Assert.That("(-96)", Is.EqualTo(v.z));
            Assert.That("((95)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-22)", "8", "(-22)", "null");
            var v = ov.swizzle.wzzy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-22)", Is.EqualTo(v.y));
            Assert.That("(-22)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((11)0)", "7", "7", "");
            var v = ov.swizzle.wzzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(08)", "null", "((8-6)2)", "4");
            var v = ov.swizzle.wzzw;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((8-6)2)", Is.EqualTo(v.y));
            Assert.That("((8-6)2)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-8)", "(28)", "null", "");
            var v = ov.swizzle.wzw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "5", "null", "((7-2)-7)");
            var v = ov.swizzle.wzwx;
            Assert.That("((7-2)-7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((7-2)-7)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-4)", "(-9-4)", "-1", "");
            var v = ov.swizzle.wzwy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-9-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(-88)", "-5", "((-4-3)1)");
            var v = ov.swizzle.wzwz;
            Assert.That("((-4-3)1)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("((-4-3)1)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "7", "((3-5)8)", "");
            var v = ov.swizzle.wzww;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((3-5)8)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-2)", "(-4-2)", "((-47)-7)", "(-4-2)");
            var v = ov.swizzle.ww;
            Assert.That("(-4-2)", Is.EqualTo(v.x));
            Assert.That("(-4-2)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-4", "(-8-7)", "(-8-7)", "");
            var v = ov.swizzle.wwx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((07)-8)", "((-53)-6)", "7", "((07)-8)");
            var v = ov.swizzle.wwxx;
            Assert.That("((07)-8)", Is.EqualTo(v.x));
            Assert.That("((07)-8)", Is.EqualTo(v.y));
            Assert.That("((07)-8)", Is.EqualTo(v.z));
            Assert.That("((07)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((5-2)1)", "(-81)", "((5-2)1)");
            var v = ov.swizzle.wwxy;
            Assert.That("((5-2)1)", Is.EqualTo(v.x));
            Assert.That("((5-2)1)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((5-2)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-1", "((-66)-1)", "(-57)");
            var v = ov.swizzle.wwxz;
            Assert.That("(-57)", Is.EqualTo(v.x));
            Assert.That("(-57)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-66)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-9)1)", "8", "(-7-4)", "6");
            var v = ov.swizzle.wwxw;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("((9-9)1)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "(-5-5)", "", "-4");
            var v = ov.swizzle.wwy;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(-5-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "6", "((-43)0)", "3");
            var v = ov.swizzle.wwyx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "(1-1)", "null", "(-9-6)");
            var v = ov.swizzle.wwyy;
            Assert.That("(-9-6)", Is.EqualTo(v.x));
            Assert.That("(-9-6)", Is.EqualTo(v.y));
            Assert.That("(1-1)", Is.EqualTo(v.z));
            Assert.That("(1-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "-9", "(9-5)");
            var v = ov.swizzle.wwyz;
            Assert.That("(9-5)", Is.EqualTo(v.x));
            Assert.That("(9-5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-24)-2)", "-2", "((-5-6)1)", "3");
            var v = ov.swizzle.wwyw;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-7", "(03)", "((-29)-3)");
            var v = ov.swizzle.wwz;
            Assert.That("((-29)-3)", Is.EqualTo(v.x));
            Assert.That("((-29)-3)", Is.EqualTo(v.y));
            Assert.That("(03)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-4", "((9-1)-8)", "(63)", "(63)");
            var v = ov.swizzle.wwzx;
            Assert.That("(63)", Is.EqualTo(v.x));
            Assert.That("(63)", Is.EqualTo(v.y));
            Assert.That("(63)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "9", "((0-2)3)", "(02)");
            var v = ov.swizzle.wwzy;
            Assert.That("(02)", Is.EqualTo(v.x));
            Assert.That("(02)", Is.EqualTo(v.y));
            Assert.That("((0-2)3)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "((98)1)", "((98)1)", "((98)1)");
            var v = ov.swizzle.wwzz;
            Assert.That("((98)1)", Is.EqualTo(v.x));
            Assert.That("((98)1)", Is.EqualTo(v.y));
            Assert.That("((98)1)", Is.EqualTo(v.z));
            Assert.That("((98)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(-8-7)", "(49)", "((1-8)-8)");
            var v = ov.swizzle.wwzw;
            Assert.That("((1-8)-8)", Is.EqualTo(v.x));
            Assert.That("((1-8)-8)", Is.EqualTo(v.y));
            Assert.That("(49)", Is.EqualTo(v.z));
            Assert.That("((1-8)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-7)-8)", "(7-6)", "((-93)7)", "-7");
            var v = ov.swizzle.www;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((52)1)", "", "(-86)", "((56)-9)");
            var v = ov.swizzle.wwwx;
            Assert.That("((56)-9)", Is.EqualTo(v.x));
            Assert.That("((56)-9)", Is.EqualTo(v.y));
            Assert.That("((56)-9)", Is.EqualTo(v.z));
            Assert.That("((52)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-25)", "-8", "-8", "null");
            var v = ov.swizzle.wwwy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((24)-1)", "(-4-9)", "((-14)-1)", "-2");
            var v = ov.swizzle.wwwz;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("((-14)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "3", "(-5-1)", "((-5-4)2)");
            var v = ov.swizzle.wwww;
            Assert.That("((-5-4)2)", Is.EqualTo(v.x));
            Assert.That("((-5-4)2)", Is.EqualTo(v.y));
            Assert.That("((-5-4)2)", Is.EqualTo(v.z));
            Assert.That("((-5-4)2)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec4<string>("6", "((-1-7)7)", "((-1-7)7)", "-7");
            var v = ov.swizzle.rr;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("8", "(-2-4)", "-7", "-7");
            var v = ov.swizzle.rrr;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-5", "-8", "(-8-3)", "(49)");
            var v = ov.swizzle.rrrr;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((26)-6)", "6", "-7", "6");
            var v = ov.swizzle.rrrg;
            Assert.That("((26)-6)", Is.EqualTo(v.x));
            Assert.That("((26)-6)", Is.EqualTo(v.y));
            Assert.That("((26)-6)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-7)6)", "1", "null", "-7");
            var v = ov.swizzle.rrrb;
            Assert.That("((-3-7)6)", Is.EqualTo(v.x));
            Assert.That("((-3-7)6)", Is.EqualTo(v.y));
            Assert.That("((-3-7)6)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(63)", "-5", "(63)", "null");
            var v = ov.swizzle.rrra;
            Assert.That("(63)", Is.EqualTo(v.x));
            Assert.That("(63)", Is.EqualTo(v.y));
            Assert.That("(63)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "((19)-4)", "(-38)", "(1-1)");
            var v = ov.swizzle.rrg;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("((19)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(8-2)", "(6-9)", "9", "((-1-4)-7)");
            var v = ov.swizzle.rrgr;
            Assert.That("(8-2)", Is.EqualTo(v.x));
            Assert.That("(8-2)", Is.EqualTo(v.y));
            Assert.That("(6-9)", Is.EqualTo(v.z));
            Assert.That("(8-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-25)-8)", "((-25)-8)", "5", "((-25)-8)");
            var v = ov.swizzle.rrgg;
            Assert.That("((-25)-8)", Is.EqualTo(v.x));
            Assert.That("((-25)-8)", Is.EqualTo(v.y));
            Assert.That("((-25)-8)", Is.EqualTo(v.z));
            Assert.That("((-25)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-5)-4)", "(73)", "(73)", "(4-7)");
            var v = ov.swizzle.rrgb;
            Assert.That("((0-5)-4)", Is.EqualTo(v.x));
            Assert.That("((0-5)-4)", Is.EqualTo(v.y));
            Assert.That("(73)", Is.EqualTo(v.z));
            Assert.That("(73)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "((-9-7)5)", "3", "((-79)6)");
            var v = ov.swizzle.rrga;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("((-9-7)5)", Is.EqualTo(v.z));
            Assert.That("((-79)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "((70)-4)", "((-8-1)9)", "(-7-2)");
            var v = ov.swizzle.rrb;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("((-8-1)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "((65)8)", "(79)", "(79)");
            var v = ov.swizzle.rrbr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(79)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(56)", "((77)8)", "-5");
            var v = ov.swizzle.rrbg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((77)8)", Is.EqualTo(v.z));
            Assert.That("(56)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-8-9)-6)", "(42)", "((5-4)0)");
            var v = ov.swizzle.rrbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(42)", Is.EqualTo(v.z));
            Assert.That("(42)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-7", "((2-7)-9)", "null");
            var v = ov.swizzle.rrba;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((2-7)-9)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "0", "(-16)", "(1-5)");
            var v = ov.swizzle.rra;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(1-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(79)", "-1", "((-58)-1)", "");
            var v = ov.swizzle.rrar;
            Assert.That("(79)", Is.EqualTo(v.x));
            Assert.That("(79)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(79)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "null", "0", "null");
            var v = ov.swizzle.rrag;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-7)", "-3", "((74)-8)", "((-7-4)8)");
            var v = ov.swizzle.rrab;
            Assert.That("(-9-7)", Is.EqualTo(v.x));
            Assert.That("(-9-7)", Is.EqualTo(v.y));
            Assert.That("((-7-4)8)", Is.EqualTo(v.z));
            Assert.That("((74)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "-7", "((-76)2)", "(7-2)");
            var v = ov.swizzle.rraa;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(7-2)", Is.EqualTo(v.z));
            Assert.That("(7-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "((-11)-9)", "(-2-4)", "(-2-4)");
            var v = ov.swizzle.rg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((-11)-9)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(60)", "((-4-5)-6)", "", "5");
            var v = ov.swizzle.rgr;
            Assert.That("(60)", Is.EqualTo(v.x));
            Assert.That("((-4-5)-6)", Is.EqualTo(v.y));
            Assert.That("(60)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("1", "((0-9)2)", "(-58)", "(-58)");
            var v = ov.swizzle.rgrr;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((0-9)2)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-51)-9)", "(95)", "((-51)-9)", "((-51)-9)");
            var v = ov.swizzle.rgrg;
            Assert.That("((-51)-9)", Is.EqualTo(v.x));
            Assert.That("(95)", Is.EqualTo(v.y));
            Assert.That("((-51)-9)", Is.EqualTo(v.z));
            Assert.That("(95)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "((63)-4)", "-6", "-8");
            var v = ov.swizzle.rgrb;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((63)-4)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-2)8)", "((-1-8)1)", "((3-2)8)", "(2-5)");
            var v = ov.swizzle.rgra;
            Assert.That("((3-2)8)", Is.EqualTo(v.x));
            Assert.That("((-1-8)1)", Is.EqualTo(v.y));
            Assert.That("((3-2)8)", Is.EqualTo(v.z));
            Assert.That("(2-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-57)", "(-59)", "((0-4)7)", "(-57)");
            var v = ov.swizzle.rgg;
            Assert.That("(-57)", Is.EqualTo(v.x));
            Assert.That("(-59)", Is.EqualTo(v.y));
            Assert.That("(-59)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("9", "(-68)", "-3", "(-9-5)");
            var v = ov.swizzle.rggr;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(-68)", Is.EqualTo(v.y));
            Assert.That("(-68)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-2)2)", "null", "(-96)", "7");
            var v = ov.swizzle.rggg;
            Assert.That("((-1-2)2)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-1)8)", "0", "", "0");
            var v = ov.swizzle.rggb;
            Assert.That("((2-1)8)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-8)4)", "null", "-1", "3");
            var v = ov.swizzle.rgga;
            Assert.That("((-8-8)4)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-94)", "-2", "(-1-9)");
            var v = ov.swizzle.rgb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-94)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("3", "7", "(4-2)", "3");
            var v = ov.swizzle.rgbr;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(4-2)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-86)-6)", "((-86)-6)", "-4", "((-86)-6)");
            var v = ov.swizzle.rgbg;
            Assert.That("((-86)-6)", Is.EqualTo(v.x));
            Assert.That("((-86)-6)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("((-86)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "2", "", "((84)-2)");
            var v = ov.swizzle.rgbb;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-9)-5)", "-7", "((7-3)2)", "((-6-9)-5)");
            var v = ov.swizzle.rgba;
            Assert.That("((-6-9)-5)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((7-3)2)", Is.EqualTo(v.z));
            Assert.That("((-6-9)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(63)", "2", "3", "");
            var v = ov.swizzle.rga;
            Assert.That("(63)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("0", "", "5", "(-8-8)");
            var v = ov.swizzle.rgar;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-8-8)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-2)", "(-5-3)", "9", "(-73)");
            var v = ov.swizzle.rgag;
            Assert.That("(-7-2)", Is.EqualTo(v.x));
            Assert.That("(-5-3)", Is.EqualTo(v.y));
            Assert.That("(-73)", Is.EqualTo(v.z));
            Assert.That("(-5-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "3", "5", "-4");
            var v = ov.swizzle.rgab;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-7)", "", "((-28)7)", "3");
            var v = ov.swizzle.rgaa;
            Assert.That("(4-7)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-3)-1)", "null", "", "((-25)-2)");
            var v = ov.swizzle.rb;
            Assert.That("((-8-3)-1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((11)0)", "((6-6)-6)", "", "5");
            var v = ov.swizzle.rbr;
            Assert.That("((11)0)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((11)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(79)", "null", "(79)");
            var v = ov.swizzle.rbrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(96)", "(96)", "(96)", "((3-1)8)");
            var v = ov.swizzle.rbrg;
            Assert.That("(96)", Is.EqualTo(v.x));
            Assert.That("(96)", Is.EqualTo(v.y));
            Assert.That("(96)", Is.EqualTo(v.z));
            Assert.That("(96)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-67)", "((6-2)-6)", "(72)", "(72)");
            var v = ov.swizzle.rbrb;
            Assert.That("(-67)", Is.EqualTo(v.x));
            Assert.That("(72)", Is.EqualTo(v.y));
            Assert.That("(-67)", Is.EqualTo(v.z));
            Assert.That("(72)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-1-9)-1)", "((-1-9)-1)", "((81)1)");
            var v = ov.swizzle.rbra;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-1-9)-1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((81)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((2-7)-8)", "-1", "null");
            var v = ov.swizzle.rbg;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((2-7)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-16)0)", "1", "-2", "7");
            var v = ov.swizzle.rbgr;
            Assert.That("((-16)0)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("((-16)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-6)-9)", "((-94)0)", "((-94)0)", "");
            var v = ov.swizzle.rbgg;
            Assert.That("((9-6)-9)", Is.EqualTo(v.x));
            Assert.That("((-94)0)", Is.EqualTo(v.y));
            Assert.That("((-94)0)", Is.EqualTo(v.z));
            Assert.That("((-94)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((45)-1)", "null", "(9-3)");
            var v = ov.swizzle.rbgb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((45)-1)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-8-2)0)", "null", "((-8-2)0)");
            var v = ov.swizzle.rbga;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-8-2)0)", Is.EqualTo(v.z));
            Assert.That("((-8-2)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "((6-3)-6)", "-4");
            var v = ov.swizzle.rbb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((6-3)-6)", Is.EqualTo(v.y));
            Assert.That("((6-3)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((1-7)-1)", "((-3-4)1)", "((-83)5)", "-7");
            var v = ov.swizzle.rbbr;
            Assert.That("((1-7)-1)", Is.EqualTo(v.x));
            Assert.That("((-83)5)", Is.EqualTo(v.y));
            Assert.That("((-83)5)", Is.EqualTo(v.z));
            Assert.That("((1-7)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((0-2)9)", "((58)8)", "null");
            var v = ov.swizzle.rbbg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((58)8)", Is.EqualTo(v.y));
            Assert.That("((58)8)", Is.EqualTo(v.z));
            Assert.That("((0-2)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-7)7)", "1", "1", "(-1-6)");
            var v = ov.swizzle.rbbb;
            Assert.That("((-7-7)7)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(69)", "(-9-6)", "((-56)-2)", "");
            var v = ov.swizzle.rbba;
            Assert.That("(69)", Is.EqualTo(v.x));
            Assert.That("((-56)-2)", Is.EqualTo(v.y));
            Assert.That("((-56)-2)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(-4-4)", "(-4-4)", "null");
            var v = ov.swizzle.rba;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-4-4)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(3-8)", "", "null", "");
            var v = ov.swizzle.rbar;
            Assert.That("(3-8)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(3-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "5", "(-5-6)", "5");
            var v = ov.swizzle.rbag;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("(-5-6)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-60)", "((8-9)8)", "null", "null");
            var v = ov.swizzle.rbab;
            Assert.That("(-60)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "0", "", "");
            var v = ov.swizzle.rbaa;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "", "-2", "-2");
            var v = ov.swizzle.ra;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-2", "((3-9)-3)", "(-40)", "-2");
            var v = ov.swizzle.rar;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(4-5)", "(-24)", "null", "((85)-1)");
            var v = ov.swizzle.rarr;
            Assert.That("(4-5)", Is.EqualTo(v.x));
            Assert.That("((85)-1)", Is.EqualTo(v.y));
            Assert.That("(4-5)", Is.EqualTo(v.z));
            Assert.That("(4-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-8)", "4", "((-1-2)7)", "(-16)");
            var v = ov.swizzle.rarg;
            Assert.That("(1-8)", Is.EqualTo(v.x));
            Assert.That("(-16)", Is.EqualTo(v.y));
            Assert.That("(1-8)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((-13)-8)", "null", "null");
            var v = ov.swizzle.rarb;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-64)7)", "-1", "", "null");
            var v = ov.swizzle.rara;
            Assert.That("((-64)7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-64)7)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-13)", "", "(3-6)", "(-13)");
            var v = ov.swizzle.rag;
            Assert.That("(-13)", Is.EqualTo(v.x));
            Assert.That("(-13)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-4", "(-98)", "-7", "");
            var v = ov.swizzle.ragr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-98)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(41)", "null", "((4-3)-4)");
            var v = ov.swizzle.ragg;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("((4-3)-4)", Is.EqualTo(v.y));
            Assert.That("(41)", Is.EqualTo(v.z));
            Assert.That("(41)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-1)-1)", "8", "(4-9)", "(4-9)");
            var v = ov.swizzle.ragb;
            Assert.That("((9-1)-1)", Is.EqualTo(v.x));
            Assert.That("(4-9)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("(4-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-64)-2)", "5", "", "((91)-4)");
            var v = ov.swizzle.raga;
            Assert.That("((-64)-2)", Is.EqualTo(v.x));
            Assert.That("((91)-4)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("((91)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-8)", "(4-7)", "((94)-1)", "null");
            var v = ov.swizzle.rab;
            Assert.That("(5-8)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((94)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-4", "(-38)", "(5-8)", "3");
            var v = ov.swizzle.rabr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(5-8)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(16)", "(16)", "", "((8-7)-1)");
            var v = ov.swizzle.rabg;
            Assert.That("(16)", Is.EqualTo(v.x));
            Assert.That("((8-7)-1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(16)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(60)", "((-2-5)-5)", "(5-1)", "(60)");
            var v = ov.swizzle.rabb;
            Assert.That("(60)", Is.EqualTo(v.x));
            Assert.That("(60)", Is.EqualTo(v.y));
            Assert.That("(5-1)", Is.EqualTo(v.z));
            Assert.That("(5-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-1)1)", "(-5-7)", "4", "(89)");
            var v = ov.swizzle.raba;
            Assert.That("((-4-1)1)", Is.EqualTo(v.x));
            Assert.That("(89)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(89)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "2", "2", "(12)");
            var v = ov.swizzle.raa;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(12)", Is.EqualTo(v.y));
            Assert.That("(12)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-1", "(-3-1)", "(7-9)", "((8-2)-8)");
            var v = ov.swizzle.raar;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((8-2)-8)", Is.EqualTo(v.y));
            Assert.That("((8-2)-8)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(2-4)", "((01)5)", "((01)5)");
            var v = ov.swizzle.raag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((01)5)", Is.EqualTo(v.y));
            Assert.That("((01)5)", Is.EqualTo(v.z));
            Assert.That("(2-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "(-9-1)", "(3-9)");
            var v = ov.swizzle.raab;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(3-9)", Is.EqualTo(v.y));
            Assert.That("(3-9)", Is.EqualTo(v.z));
            Assert.That("(-9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((34)-8)", "null", "(3-4)");
            var v = ov.swizzle.raaa;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(3-4)", Is.EqualTo(v.y));
            Assert.That("(3-4)", Is.EqualTo(v.z));
            Assert.That("(3-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "4", "((-1-7)-7)", "null");
            var v = ov.swizzle.gr;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("", "1", "null", "-9");
            var v = ov.swizzle.grr;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((7-1)-5)", "(64)", "((5-3)-6)");
            var v = ov.swizzle.grrr;
            Assert.That("((7-1)-5)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "(-8-3)", "6", "6");
            var v = ov.swizzle.grrg;
            Assert.That("(-8-3)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("(-8-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(28)", "(6-4)", "((-33)3)");
            var v = ov.swizzle.grrb;
            Assert.That("(28)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(6-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "(4-9)", "(4-9)", "(-19)");
            var v = ov.swizzle.grra;
            Assert.That("(4-9)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("(-19)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "4", "4", "((48)1)");
            var v = ov.swizzle.grg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((55)3)", "null", "-6", "(6-2)");
            var v = ov.swizzle.grgr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((55)3)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((55)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(21)", "0", "(55)");
            var v = ov.swizzle.grgg;
            Assert.That("(21)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(21)", Is.EqualTo(v.z));
            Assert.That("(21)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "(39)", "");
            var v = ov.swizzle.grgb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(39)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-9)", "((-3-9)-2)", "(39)", "6");
            var v = ov.swizzle.grga;
            Assert.That("((-3-9)-2)", Is.EqualTo(v.x));
            Assert.That("(4-9)", Is.EqualTo(v.y));
            Assert.That("((-3-9)-2)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-40)-2)", "((-40)-2)", "1", "(-67)");
            var v = ov.swizzle.grb;
            Assert.That("((-40)-2)", Is.EqualTo(v.x));
            Assert.That("((-40)-2)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("0", "((5-1)7)", "-4", "(-1-6)");
            var v = ov.swizzle.grbr;
            Assert.That("((5-1)7)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(0-3)", "((-3-7)-5)", "7");
            var v = ov.swizzle.grbg;
            Assert.That("(0-3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-3-7)-5)", Is.EqualTo(v.z));
            Assert.That("(0-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((92)3)", "", "null", "(58)");
            var v = ov.swizzle.grbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((92)3)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-1)", "((-78)3)", "-1", "-7");
            var v = ov.swizzle.grba;
            Assert.That("((-78)3)", Is.EqualTo(v.x));
            Assert.That("(8-1)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "null", "((27)-9)", "-2");
            var v = ov.swizzle.gra;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-83)", "4", "-8", "null");
            var v = ov.swizzle.grar;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("(-83)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-83)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-2)", "((8-6)-8)", "(7-9)", "((8-6)-8)");
            var v = ov.swizzle.grag;
            Assert.That("((8-6)-8)", Is.EqualTo(v.x));
            Assert.That("(-1-2)", Is.EqualTo(v.y));
            Assert.That("((8-6)-8)", Is.EqualTo(v.z));
            Assert.That("((8-6)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((30)6)", "((29)-1)", "(-33)", "((30)6)");
            var v = ov.swizzle.grab;
            Assert.That("((29)-1)", Is.EqualTo(v.x));
            Assert.That("((30)6)", Is.EqualTo(v.y));
            Assert.That("((30)6)", Is.EqualTo(v.z));
            Assert.That("(-33)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-57)-9)", "((-6-4)1)", "(51)", "(-3-8)");
            var v = ov.swizzle.graa;
            Assert.That("((-6-4)1)", Is.EqualTo(v.x));
            Assert.That("((-57)-9)", Is.EqualTo(v.y));
            Assert.That("(-3-8)", Is.EqualTo(v.z));
            Assert.That("(-3-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-9)", "-5", "(-15)", "-8");
            var v = ov.swizzle.gg;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(96)", "(-5-9)", "(96)", "((-58)-5)");
            var v = ov.swizzle.ggr;
            Assert.That("(-5-9)", Is.EqualTo(v.x));
            Assert.That("(-5-9)", Is.EqualTo(v.y));
            Assert.That("(96)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "4", "(-29)", "((-66)-4)");
            var v = ov.swizzle.ggrr;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-36)4)", "((-40)2)", "", "(-6-2)");
            var v = ov.swizzle.ggrg;
            Assert.That("((-40)2)", Is.EqualTo(v.x));
            Assert.That("((-40)2)", Is.EqualTo(v.y));
            Assert.That("((-36)4)", Is.EqualTo(v.z));
            Assert.That("((-40)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "-2", "-2", "((-30)-1)");
            var v = ov.swizzle.ggrb;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((79)-2)", "7", "", "((79)-2)");
            var v = ov.swizzle.ggra;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("((79)-2)", Is.EqualTo(v.z));
            Assert.That("((79)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-92)", "1", "null", "(78)");
            var v = ov.swizzle.ggg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-28)4)", "", "((-28)4)", "(-39)");
            var v = ov.swizzle.gggr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-28)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "6", "((-8-2)5)", "(-3-3)");
            var v = ov.swizzle.gggg;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "(-2-3)", "((-7-3)9)", "(-2-3)");
            var v = ov.swizzle.gggb;
            Assert.That("(-2-3)", Is.EqualTo(v.x));
            Assert.That("(-2-3)", Is.EqualTo(v.y));
            Assert.That("(-2-3)", Is.EqualTo(v.z));
            Assert.That("((-7-3)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((26)-5)", "", "", "((33)8)");
            var v = ov.swizzle.ggga;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((33)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-5)9)", "((1-2)0)", "0", "3");
            var v = ov.swizzle.ggb;
            Assert.That("((1-2)0)", Is.EqualTo(v.x));
            Assert.That("((1-2)0)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-79)-4)", "-5", "(8-8)", "((9-5)6)");
            var v = ov.swizzle.ggbr;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(8-8)", Is.EqualTo(v.z));
            Assert.That("((-79)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(84)", "4", "(84)", "((-49)-1)");
            var v = ov.swizzle.ggbg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("(84)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-13)-8)", "0", "-6", "null");
            var v = ov.swizzle.ggbb;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((65)-2)", "null", "-7", "");
            var v = ov.swizzle.ggba;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "-2", "", "(1-5)");
            var v = ov.swizzle.gga;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("(1-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "-2", "(60)", "null");
            var v = ov.swizzle.ggar;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "((-4-9)-5)", "null", "(00)");
            var v = ov.swizzle.ggag;
            Assert.That("((-4-9)-5)", Is.EqualTo(v.x));
            Assert.That("((-4-9)-5)", Is.EqualTo(v.y));
            Assert.That("(00)", Is.EqualTo(v.z));
            Assert.That("((-4-9)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(3-7)", "null", "((-9-9)-1)", "((30)2)");
            var v = ov.swizzle.ggab;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((30)2)", Is.EqualTo(v.z));
            Assert.That("((-9-9)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "null", "((30)-4)", "((-70)8)");
            var v = ov.swizzle.ggaa;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-70)8)", Is.EqualTo(v.z));
            Assert.That("((-70)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((4-9)-1)", "((7-6)9)", "-4");
            var v = ov.swizzle.gb;
            Assert.That("((4-9)-1)", Is.EqualTo(v.x));
            Assert.That("((7-6)9)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(8-1)", "((-92)-5)", "((-24)-6)", "null");
            var v = ov.swizzle.gbr;
            Assert.That("((-92)-5)", Is.EqualTo(v.x));
            Assert.That("((-24)-6)", Is.EqualTo(v.y));
            Assert.That("(8-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-2-8)0)", "null", "((-8-7)-2)", "");
            var v = ov.swizzle.gbrr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-8-7)-2)", Is.EqualTo(v.y));
            Assert.That("((-2-8)0)", Is.EqualTo(v.z));
            Assert.That("((-2-8)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-2)", "(6-6)", "((12)9)", "null");
            var v = ov.swizzle.gbrg;
            Assert.That("(6-6)", Is.EqualTo(v.x));
            Assert.That("((12)9)", Is.EqualTo(v.y));
            Assert.That("(-9-2)", Is.EqualTo(v.z));
            Assert.That("(6-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-2)-8)", "(-2-8)", "((-4-7)-1)", "((7-8)-6)");
            var v = ov.swizzle.gbrb;
            Assert.That("(-2-8)", Is.EqualTo(v.x));
            Assert.That("((-4-7)-1)", Is.EqualTo(v.y));
            Assert.That("((-2-2)-8)", Is.EqualTo(v.z));
            Assert.That("((-4-7)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-9)3)", "2", "", "-4");
            var v = ov.swizzle.gbra;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((3-9)3)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-56)", "((-5-7)-8)", "((-5-7)-8)", "3");
            var v = ov.swizzle.gbg;
            Assert.That("((-5-7)-8)", Is.EqualTo(v.x));
            Assert.That("((-5-7)-8)", Is.EqualTo(v.y));
            Assert.That("((-5-7)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((45)-6)", "8", "((45)-6)", "((15)-9)");
            var v = ov.swizzle.gbgr;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((45)-6)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((45)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "(-70)", "((6-2)5)");
            var v = ov.swizzle.gbgg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-70)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "((-31)6)", "(99)", "");
            var v = ov.swizzle.gbgb;
            Assert.That("((-31)6)", Is.EqualTo(v.x));
            Assert.That("(99)", Is.EqualTo(v.y));
            Assert.That("((-31)6)", Is.EqualTo(v.z));
            Assert.That("(99)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-38)", "8", "(-38)", "((-94)-9)");
            var v = ov.swizzle.gbga;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(-38)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((-94)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(53)", "((52)-9)", "null", "null");
            var v = ov.swizzle.gbb;
            Assert.That("((52)-9)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("9", "7", "9", "null");
            var v = ov.swizzle.gbbr;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-5-9)-7)", "(5-8)", "((-5-9)-7)");
            var v = ov.swizzle.gbbg;
            Assert.That("((-5-9)-7)", Is.EqualTo(v.x));
            Assert.That("(5-8)", Is.EqualTo(v.y));
            Assert.That("(5-8)", Is.EqualTo(v.z));
            Assert.That("((-5-9)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "-5", "2", "-4");
            var v = ov.swizzle.gbbb;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(66)", "null", "(66)", "(5-1)");
            var v = ov.swizzle.gbba;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(66)", Is.EqualTo(v.y));
            Assert.That("(66)", Is.EqualTo(v.z));
            Assert.That("(5-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-5)-3)", "((53)6)", "6", "(-44)");
            var v = ov.swizzle.gba;
            Assert.That("((53)6)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(-44)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((15)4)", "((3-7)5)", "null", "-5");
            var v = ov.swizzle.gbar;
            Assert.That("((3-7)5)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("((15)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-16)", "(1-1)", "(-16)", "(66)");
            var v = ov.swizzle.gbag;
            Assert.That("(1-1)", Is.EqualTo(v.x));
            Assert.That("(-16)", Is.EqualTo(v.y));
            Assert.That("(66)", Is.EqualTo(v.z));
            Assert.That("(1-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(4-8)", "(4-8)", "4");
            var v = ov.swizzle.gbab;
            Assert.That("(4-8)", Is.EqualTo(v.x));
            Assert.That("(4-8)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(4-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-7)", "(-4-9)", "((3-7)-6)", "(57)");
            var v = ov.swizzle.gbaa;
            Assert.That("(-4-9)", Is.EqualTo(v.x));
            Assert.That("((3-7)-6)", Is.EqualTo(v.y));
            Assert.That("(57)", Is.EqualTo(v.z));
            Assert.That("(57)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "2", "", "((5-9)0)");
            var v = ov.swizzle.ga;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("((5-9)0)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((01)-3)", "(89)", "(89)", "((4-7)-2)");
            var v = ov.swizzle.gar;
            Assert.That("(89)", Is.EqualTo(v.x));
            Assert.That("((4-7)-2)", Is.EqualTo(v.y));
            Assert.That("((01)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-36)3)", "2", "((-53)-9)", "(-4-4)");
            var v = ov.swizzle.garr;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-4-4)", Is.EqualTo(v.y));
            Assert.That("((-36)3)", Is.EqualTo(v.z));
            Assert.That("((-36)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-1)", "(-5-9)", "(-64)", "(-6-1)");
            var v = ov.swizzle.garg;
            Assert.That("(-5-9)", Is.EqualTo(v.x));
            Assert.That("(-6-1)", Is.EqualTo(v.y));
            Assert.That("(-6-1)", Is.EqualTo(v.z));
            Assert.That("(-5-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-88)-2)", "(77)", "((22)-7)", "2");
            var v = ov.swizzle.garb;
            Assert.That("(77)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((-88)-2)", Is.EqualTo(v.z));
            Assert.That("((22)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((15)6)", "(-67)", "((3-4)-3)", "((3-4)-3)");
            var v = ov.swizzle.gara;
            Assert.That("(-67)", Is.EqualTo(v.x));
            Assert.That("((3-4)-3)", Is.EqualTo(v.y));
            Assert.That("((15)6)", Is.EqualTo(v.z));
            Assert.That("((3-4)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((6-6)3)", "((6-6)3)", "(-57)", "((-1-6)2)");
            var v = ov.swizzle.gag;
            Assert.That("((6-6)3)", Is.EqualTo(v.x));
            Assert.That("((-1-6)2)", Is.EqualTo(v.y));
            Assert.That("((6-6)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((1-2)-3)", "(62)", "((1-2)-3)", "-9");
            var v = ov.swizzle.gagr;
            Assert.That("(62)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("(62)", Is.EqualTo(v.z));
            Assert.That("((1-2)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-8)", "((07)9)", "(-7-9)", "(9-8)");
            var v = ov.swizzle.gagg;
            Assert.That("((07)9)", Is.EqualTo(v.x));
            Assert.That("(9-8)", Is.EqualTo(v.y));
            Assert.That("((07)9)", Is.EqualTo(v.z));
            Assert.That("((07)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((59)-5)", "((-4-4)8)", "", "(65)");
            var v = ov.swizzle.gagb;
            Assert.That("((-4-4)8)", Is.EqualTo(v.x));
            Assert.That("(65)", Is.EqualTo(v.y));
            Assert.That("((-4-4)8)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-38)-9)", "(44)", "-5", "((09)-9)");
            var v = ov.swizzle.gaga;
            Assert.That("(44)", Is.EqualTo(v.x));
            Assert.That("((09)-9)", Is.EqualTo(v.y));
            Assert.That("(44)", Is.EqualTo(v.z));
            Assert.That("((09)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "-7", "((-19)-1)");
            var v = ov.swizzle.gab;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-19)-1)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-8-7)9)", "((-8-7)9)", "(-74)", "((-48)4)");
            var v = ov.swizzle.gabr;
            Assert.That("((-8-7)9)", Is.EqualTo(v.x));
            Assert.That("((-48)4)", Is.EqualTo(v.y));
            Assert.That("(-74)", Is.EqualTo(v.z));
            Assert.That("((-8-7)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-23)7)", "(3-6)", "(-4-1)");
            var v = ov.swizzle.gabg;
            Assert.That("((-23)7)", Is.EqualTo(v.x));
            Assert.That("(-4-1)", Is.EqualTo(v.y));
            Assert.That("(3-6)", Is.EqualTo(v.z));
            Assert.That("((-23)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((07)-9)", "((-72)-9)", "null", "");
            var v = ov.swizzle.gabb;
            Assert.That("((-72)-9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-3)-2)", "(04)", "null", "");
            var v = ov.swizzle.gaba;
            Assert.That("(04)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(18)", "((5-6)-1)", "-9", "null");
            var v = ov.swizzle.gaa;
            Assert.That("((5-6)-1)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("0", "null", "", "((-4-4)-3)");
            var v = ov.swizzle.gaar;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-4-4)-3)", Is.EqualTo(v.y));
            Assert.That("((-4-4)-3)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((20)1)", "null", "((-6-2)-2)", "(-97)");
            var v = ov.swizzle.gaag;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-97)", Is.EqualTo(v.y));
            Assert.That("(-97)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-3)-4)", "9", "((-4-7)-7)", "((-4-7)-7)");
            var v = ov.swizzle.gaab;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((-4-7)-7)", Is.EqualTo(v.y));
            Assert.That("((-4-7)-7)", Is.EqualTo(v.z));
            Assert.That("((-4-7)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(74)", "((18)7)", "2", "(2-3)");
            var v = ov.swizzle.gaaa;
            Assert.That("((18)7)", Is.EqualTo(v.x));
            Assert.That("(2-3)", Is.EqualTo(v.y));
            Assert.That("(2-3)", Is.EqualTo(v.z));
            Assert.That("(2-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-53)-9)", "-6", "null", "-6");
            var v = ov.swizzle.br;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-53)-9)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("7", "null", "((10)1)", "null");
            var v = ov.swizzle.brr;
            Assert.That("((10)1)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(17)", "(6-4)", "-4", "((-5-1)-9)");
            var v = ov.swizzle.brrr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(17)", Is.EqualTo(v.y));
            Assert.That("(17)", Is.EqualTo(v.z));
            Assert.That("(17)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(6-4)", "(81)", "-9");
            var v = ov.swizzle.brrg;
            Assert.That("(81)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(6-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-3)2)", "2", "-5", "9");
            var v = ov.swizzle.brrb;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("((-4-3)2)", Is.EqualTo(v.y));
            Assert.That("((-4-3)2)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((13)9)", "((13)9)", "(89)", "-7");
            var v = ov.swizzle.brra;
            Assert.That("(89)", Is.EqualTo(v.x));
            Assert.That("((13)9)", Is.EqualTo(v.y));
            Assert.That("((13)9)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((-2-8)0)", "(19)", "((5-3)8)");
            var v = ov.swizzle.brg;
            Assert.That("(19)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("((-2-8)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-6", "-7", "((-7-6)7)", "((-7-6)7)");
            var v = ov.swizzle.brgr;
            Assert.That("((-7-6)7)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(3-1)", "null", "-8");
            var v = ov.swizzle.brgg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(3-1)", Is.EqualTo(v.z));
            Assert.That("(3-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((69)-3)", "", "(-73)", "((69)-3)");
            var v = ov.swizzle.brgb;
            Assert.That("(-73)", Is.EqualTo(v.x));
            Assert.That("((69)-3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-73)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-53)", "-7", "2");
            var v = ov.swizzle.brga;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-53)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-8)-7)", "((1-5)2)", "(9-7)", "((5-7)8)");
            var v = ov.swizzle.brb;
            Assert.That("(9-7)", Is.EqualTo(v.x));
            Assert.That("((-8-8)-7)", Is.EqualTo(v.y));
            Assert.That("(9-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-6-8)", "1", "((04)-5)", "null");
            var v = ov.swizzle.brbr;
            Assert.That("((04)-5)", Is.EqualTo(v.x));
            Assert.That("(-6-8)", Is.EqualTo(v.y));
            Assert.That("((04)-5)", Is.EqualTo(v.z));
            Assert.That("(-6-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-6)6)", "(-9-5)", "((5-6)6)", "((-66)3)");
            var v = ov.swizzle.brbg;
            Assert.That("((5-6)6)", Is.EqualTo(v.x));
            Assert.That("((5-6)6)", Is.EqualTo(v.y));
            Assert.That("((5-6)6)", Is.EqualTo(v.z));
            Assert.That("(-9-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "(9-6)", "(-87)", "");
            var v = ov.swizzle.brbb;
            Assert.That("(-87)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("(-87)", Is.EqualTo(v.z));
            Assert.That("(-87)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-9", "((-12)-9)", "((-49)5)");
            var v = ov.swizzle.brba;
            Assert.That("((-12)-9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-12)-9)", Is.EqualTo(v.z));
            Assert.That("((-49)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-2)-8)", "", "(78)", "(78)");
            var v = ov.swizzle.bra;
            Assert.That("(78)", Is.EqualTo(v.x));
            Assert.That("((-6-2)-8)", Is.EqualTo(v.y));
            Assert.That("(78)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-59)", "4", "((-59)2)", "((-59)2)");
            var v = ov.swizzle.brar;
            Assert.That("((-59)2)", Is.EqualTo(v.x));
            Assert.That("(-59)", Is.EqualTo(v.y));
            Assert.That("((-59)2)", Is.EqualTo(v.z));
            Assert.That("(-59)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "(21)", "-3");
            var v = ov.swizzle.brag;
            Assert.That("(21)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-2)", "8", "null", "((-6-7)-7)");
            var v = ov.swizzle.brab;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(6-2)", Is.EqualTo(v.y));
            Assert.That("((-6-7)-7)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "null", "1", "null");
            var v = ov.swizzle.braa;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-73)-4)", "-8", "-9", "((-6-8)-5)");
            var v = ov.swizzle.bg;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("null", "((-92)-8)", "7", "((-9-8)9)");
            var v = ov.swizzle.bgr;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((-92)-8)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "", "", "4");
            var v = ov.swizzle.bgrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "((23)7)", "((23)7)", "-5");
            var v = ov.swizzle.bgrg;
            Assert.That("((23)7)", Is.EqualTo(v.x));
            Assert.That("((23)7)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("((23)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((53)3)", "(48)", "((53)3)");
            var v = ov.swizzle.bgrb;
            Assert.That("(48)", Is.EqualTo(v.x));
            Assert.That("((53)3)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("(48)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "8", "(02)", "-5");
            var v = ov.swizzle.bgra;
            Assert.That("(02)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(77)", "((56)-2)", "-5");
            var v = ov.swizzle.bgg;
            Assert.That("((56)-2)", Is.EqualTo(v.x));
            Assert.That("(77)", Is.EqualTo(v.y));
            Assert.That("(77)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(0-5)", "null", "((8-8)5)", "9");
            var v = ov.swizzle.bggr;
            Assert.That("((8-8)5)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(0-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(75)", "(-77)", "null", "4");
            var v = ov.swizzle.bggg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-77)", Is.EqualTo(v.y));
            Assert.That("(-77)", Is.EqualTo(v.z));
            Assert.That("(-77)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "(-80)", "(-51)", "null");
            var v = ov.swizzle.bggb;
            Assert.That("(-51)", Is.EqualTo(v.x));
            Assert.That("(-80)", Is.EqualTo(v.y));
            Assert.That("(-80)", Is.EqualTo(v.z));
            Assert.That("(-51)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-96)", "-6", "((8-4)9)", "8");
            var v = ov.swizzle.bgga;
            Assert.That("((8-4)9)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "", "((68)8)", "((2-2)0)");
            var v = ov.swizzle.bgb;
            Assert.That("((68)8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((68)8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-52)", "((61)-5)", "(2-1)", "null");
            var v = ov.swizzle.bgbr;
            Assert.That("(2-1)", Is.EqualTo(v.x));
            Assert.That("((61)-5)", Is.EqualTo(v.y));
            Assert.That("(2-1)", Is.EqualTo(v.z));
            Assert.That("(-52)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((91)0)", "((-91)9)", "(-74)", "-2");
            var v = ov.swizzle.bgbg;
            Assert.That("(-74)", Is.EqualTo(v.x));
            Assert.That("((-91)9)", Is.EqualTo(v.y));
            Assert.That("(-74)", Is.EqualTo(v.z));
            Assert.That("((-91)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((81)-9)", "(-6-6)", "(-36)");
            var v = ov.swizzle.bgbb;
            Assert.That("(-6-6)", Is.EqualTo(v.x));
            Assert.That("((81)-9)", Is.EqualTo(v.y));
            Assert.That("(-6-6)", Is.EqualTo(v.z));
            Assert.That("(-6-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "((01)-2)", "-3", "(01)");
            var v = ov.swizzle.bgba;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("((01)-2)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(01)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-1", "((-8-4)-4)", "(55)");
            var v = ov.swizzle.bga;
            Assert.That("((-8-4)-4)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(55)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-9", "((3-7)-8)", "(9-2)", "(03)");
            var v = ov.swizzle.bgar;
            Assert.That("(9-2)", Is.EqualTo(v.x));
            Assert.That("((3-7)-8)", Is.EqualTo(v.y));
            Assert.That("(03)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((90)-3)", "(85)", "((-9-8)5)", "");
            var v = ov.swizzle.bgag;
            Assert.That("((-9-8)5)", Is.EqualTo(v.x));
            Assert.That("(85)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(85)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-65)-8)", "8", "((69)8)");
            var v = ov.swizzle.bgab;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((-65)-8)", Is.EqualTo(v.y));
            Assert.That("((69)8)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(20)", "", "", "((-92)7)");
            var v = ov.swizzle.bgaa;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-92)7)", Is.EqualTo(v.z));
            Assert.That("((-92)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((55)3)", "3", "3");
            var v = ov.swizzle.bb;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(5-5)", "-9", "2", "(1-2)");
            var v = ov.swizzle.bbr;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(5-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("4", "", "((8-8)-6)", "(5-7)");
            var v = ov.swizzle.bbrr;
            Assert.That("((8-8)-6)", Is.EqualTo(v.x));
            Assert.That("((8-8)-6)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-3)", "(55)", "(-9-3)", "(55)");
            var v = ov.swizzle.bbrg;
            Assert.That("(-9-3)", Is.EqualTo(v.x));
            Assert.That("(-9-3)", Is.EqualTo(v.y));
            Assert.That("(-9-3)", Is.EqualTo(v.z));
            Assert.That("(55)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-9)", "(-71)", "(-1-9)", "((0-3)0)");
            var v = ov.swizzle.bbrb;
            Assert.That("(-1-9)", Is.EqualTo(v.x));
            Assert.That("(-1-9)", Is.EqualTo(v.y));
            Assert.That("(-1-9)", Is.EqualTo(v.z));
            Assert.That("(-1-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-63)-4)", "(9-7)", "((-63)-4)", "");
            var v = ov.swizzle.bbra;
            Assert.That("((-63)-4)", Is.EqualTo(v.x));
            Assert.That("((-63)-4)", Is.EqualTo(v.y));
            Assert.That("((-63)-4)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-2", "-8", "2");
            var v = ov.swizzle.bbg;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-7-8)", "-7", "((5-8)-1)", "(14)");
            var v = ov.swizzle.bbgr;
            Assert.That("((5-8)-1)", Is.EqualTo(v.x));
            Assert.That("((5-8)-1)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("(-7-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-2)5)", "(-17)", "null", "-5");
            var v = ov.swizzle.bbgg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-17)", Is.EqualTo(v.z));
            Assert.That("(-17)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(3-2)", "((-9-7)5)", "");
            var v = ov.swizzle.bbgb;
            Assert.That("((-9-7)5)", Is.EqualTo(v.x));
            Assert.That("((-9-7)5)", Is.EqualTo(v.y));
            Assert.That("(3-2)", Is.EqualTo(v.z));
            Assert.That("((-9-7)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "", "4", "null");
            var v = ov.swizzle.bbga;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-2)2)", "3", "2", "null");
            var v = ov.swizzle.bbb;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(8-1)", "(8-1)", "null", "((3-5)-4)");
            var v = ov.swizzle.bbbr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(8-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(22)", "(9-1)", "", "((-95)2)");
            var v = ov.swizzle.bbbg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-1)", "-5", "7", "null");
            var v = ov.swizzle.bbbb;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "3", "(34)", "((1-5)8)");
            var v = ov.swizzle.bbba;
            Assert.That("(34)", Is.EqualTo(v.x));
            Assert.That("(34)", Is.EqualTo(v.y));
            Assert.That("(34)", Is.EqualTo(v.z));
            Assert.That("((1-5)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "2", "(3-1)", "0");
            var v = ov.swizzle.bba;
            Assert.That("(3-1)", Is.EqualTo(v.x));
            Assert.That("(3-1)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-9-9)", "null", "((-97)9)", "((-10)-2)");
            var v = ov.swizzle.bbar;
            Assert.That("((-97)9)", Is.EqualTo(v.x));
            Assert.That("((-97)9)", Is.EqualTo(v.y));
            Assert.That("((-10)-2)", Is.EqualTo(v.z));
            Assert.That("(-9-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "(-25)", "-4", "((63)-4)");
            var v = ov.swizzle.bbag;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((63)-4)", Is.EqualTo(v.z));
            Assert.That("(-25)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-9", "((-12)-7)", "((96)6)");
            var v = ov.swizzle.bbab;
            Assert.That("((-12)-7)", Is.EqualTo(v.x));
            Assert.That("((-12)-7)", Is.EqualTo(v.y));
            Assert.That("((96)6)", Is.EqualTo(v.z));
            Assert.That("((-12)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-2)-5)", "(04)", "null", "-4");
            var v = ov.swizzle.bbaa;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-78)", "3", "((64)7)", "null");
            var v = ov.swizzle.ba;
            Assert.That("((64)7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-6", "((-23)-4)", "(-1-6)", "(57)");
            var v = ov.swizzle.bar;
            Assert.That("(-1-6)", Is.EqualTo(v.x));
            Assert.That("(57)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(-8-4)", "0", "(-8-4)");
            var v = ov.swizzle.barr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(-8-4)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "(-4-1)", "(-79)", "null");
            var v = ov.swizzle.barg;
            Assert.That("(-79)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("(-4-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-7)-1)", "(-13)", "((8-7)-1)", "3");
            var v = ov.swizzle.barb;
            Assert.That("((8-7)-1)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((8-7)-1)", Is.EqualTo(v.z));
            Assert.That("((8-7)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-1", "(34)", "8");
            var v = ov.swizzle.bara;
            Assert.That("(34)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((07)-6)", "-1", "((07)-6)", "null");
            var v = ov.swizzle.bag;
            Assert.That("((07)-6)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(09)", "((1-9)-5)", "(-51)", "0");
            var v = ov.swizzle.bagr;
            Assert.That("(-51)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((1-9)-5)", Is.EqualTo(v.z));
            Assert.That("(09)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((45)4)", "((7-2)0)", "null", "-5");
            var v = ov.swizzle.bagg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("((7-2)0)", Is.EqualTo(v.z));
            Assert.That("((7-2)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-6)", "(-5-6)", "0", "7");
            var v = ov.swizzle.bagb;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(-5-6)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-53)-1)", "((-53)-1)", "1", "((0-8)3)");
            var v = ov.swizzle.baga;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((0-8)3)", Is.EqualTo(v.y));
            Assert.That("((-53)-1)", Is.EqualTo(v.z));
            Assert.That("((0-8)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-32)", "(2-9)", "((-13)-6)", "-4");
            var v = ov.swizzle.bab;
            Assert.That("((-13)-6)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((-13)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(80)", "", "8");
            var v = ov.swizzle.babr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-49)", "((-20)7)", "((-80)-7)", "(-2-6)");
            var v = ov.swizzle.babg;
            Assert.That("((-80)-7)", Is.EqualTo(v.x));
            Assert.That("(-2-6)", Is.EqualTo(v.y));
            Assert.That("((-80)-7)", Is.EqualTo(v.z));
            Assert.That("((-20)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((15)3)", "(64)", "(0-5)", "(64)");
            var v = ov.swizzle.babb;
            Assert.That("(0-5)", Is.EqualTo(v.x));
            Assert.That("(64)", Is.EqualTo(v.y));
            Assert.That("(0-5)", Is.EqualTo(v.z));
            Assert.That("(0-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-1)6)", "6", "", "((8-7)-6)");
            var v = ov.swizzle.baba;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((8-7)-6)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((8-7)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-4)-5)", "", "null", "(7-5)");
            var v = ov.swizzle.baa;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(7-5)", Is.EqualTo(v.y));
            Assert.That("(7-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-41)-5)", "(-72)", "((58)4)", "-1");
            var v = ov.swizzle.baar;
            Assert.That("((58)4)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("((-41)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-54)", "(-54)", "((0-7)0)", "(41)");
            var v = ov.swizzle.baag;
            Assert.That("((0-7)0)", Is.EqualTo(v.x));
            Assert.That("(41)", Is.EqualTo(v.y));
            Assert.That("(41)", Is.EqualTo(v.z));
            Assert.That("(-54)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "8", "((9-7)-6)", "((8-2)-7)");
            var v = ov.swizzle.baab;
            Assert.That("((9-7)-6)", Is.EqualTo(v.x));
            Assert.That("((8-2)-7)", Is.EqualTo(v.y));
            Assert.That("((8-2)-7)", Is.EqualTo(v.z));
            Assert.That("((9-7)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-4)", "", "(-15)", "((-91)9)");
            var v = ov.swizzle.baaa;
            Assert.That("(-15)", Is.EqualTo(v.x));
            Assert.That("((-91)9)", Is.EqualTo(v.y));
            Assert.That("((-91)9)", Is.EqualTo(v.z));
            Assert.That("((-91)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "(-78)", "2", "-2");
            var v = ov.swizzle.ar;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(9-8)", "((-67)5)", "null", "(2-3)");
            var v = ov.swizzle.arr;
            Assert.That("(2-3)", Is.EqualTo(v.x));
            Assert.That("(9-8)", Is.EqualTo(v.y));
            Assert.That("(9-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-4-8)", "((-7-8)-9)", "(-5-2)", "(-4-8)");
            var v = ov.swizzle.arrr;
            Assert.That("(-4-8)", Is.EqualTo(v.x));
            Assert.That("(-4-8)", Is.EqualTo(v.y));
            Assert.That("(-4-8)", Is.EqualTo(v.z));
            Assert.That("(-4-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "((1-6)9)", "(-86)", "((1-6)9)");
            var v = ov.swizzle.arrg;
            Assert.That("((1-6)9)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((1-6)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-95)-2)", "((-95)-2)", "((2-4)1)");
            var v = ov.swizzle.arrb;
            Assert.That("((2-4)1)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-95)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-4)9)", "", "((-4-5)6)", "-1");
            var v = ov.swizzle.arra;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((-8-4)9)", Is.EqualTo(v.y));
            Assert.That("((-8-4)9)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "((6-6)8)", "-3");
            var v = ov.swizzle.arg;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-9", "null", "((96)5)", "(15)");
            var v = ov.swizzle.argr;
            Assert.That("(15)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-8)", "9", "(30)", "9");
            var v = ov.swizzle.argg;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(5-8)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "", "-1", "-1");
            var v = ov.swizzle.argb;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "((-54)5)", "((09)-7)");
            var v = ov.swizzle.arga;
            Assert.That("((09)-7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((09)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-90)", "null", "", "null");
            var v = ov.swizzle.arb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-90)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(10)", "5", "5", "5");
            var v = ov.swizzle.arbr;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(10)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("(10)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-50)1)", "((-61)7)", "(78)");
            var v = ov.swizzle.arbg;
            Assert.That("(78)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-61)7)", Is.EqualTo(v.z));
            Assert.That("((-50)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "", "", "(-6-3)");
            var v = ov.swizzle.arbb;
            Assert.That("(-6-3)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((7-4)-4)", "", "-8");
            var v = ov.swizzle.arba;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "null", "-1", "-3");
            var v = ov.swizzle.ara;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(3-9)", "", "(0-9)", "null");
            var v = ov.swizzle.arar;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(3-9)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(3-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "", "(-5-5)", "(69)");
            var v = ov.swizzle.arag;
            Assert.That("(69)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(69)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(23)", "((-4-7)1)", "null");
            var v = ov.swizzle.arab;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-4-7)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-37)", "((-3-7)1)", "((-50)-5)", "(-17)");
            var v = ov.swizzle.araa;
            Assert.That("(-17)", Is.EqualTo(v.x));
            Assert.That("(-37)", Is.EqualTo(v.y));
            Assert.That("(-17)", Is.EqualTo(v.z));
            Assert.That("(-17)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((21)8)", "((26)6)", "((21)8)", "((21)8)");
            var v = ov.swizzle.ag;
            Assert.That("((21)8)", Is.EqualTo(v.x));
            Assert.That("((26)6)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((52)1)", "-7", "(-4-8)", "");
            var v = ov.swizzle.agr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((52)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((8-2)4)", "((-8-9)-8)", "((8-2)4)", "(-1-8)");
            var v = ov.swizzle.agrr;
            Assert.That("(-1-8)", Is.EqualTo(v.x));
            Assert.That("((-8-9)-8)", Is.EqualTo(v.y));
            Assert.That("((8-2)4)", Is.EqualTo(v.z));
            Assert.That("((8-2)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((77)-9)", "", "((47)-2)", "");
            var v = ov.swizzle.agrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((77)-9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((-32)3)", "((-32)3)", "null");
            var v = ov.swizzle.agrb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-32)3)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("((-32)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-6)", "(91)", "((2-6)4)", "((2-6)4)");
            var v = ov.swizzle.agra;
            Assert.That("((2-6)4)", Is.EqualTo(v.x));
            Assert.That("(91)", Is.EqualTo(v.y));
            Assert.That("(-9-6)", Is.EqualTo(v.z));
            Assert.That("((2-6)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-8)", "9", "(-85)", "(-52)");
            var v = ov.swizzle.agg;
            Assert.That("(-52)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-4", "3", "(9-9)", "(82)");
            var v = ov.swizzle.aggr;
            Assert.That("(82)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(70)", "1", "1", "((-7-2)-4)");
            var v = ov.swizzle.aggg;
            Assert.That("((-7-2)-4)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-67)5)", "(81)", "(91)", "(81)");
            var v = ov.swizzle.aggb;
            Assert.That("(81)", Is.EqualTo(v.x));
            Assert.That("(81)", Is.EqualTo(v.y));
            Assert.That("(81)", Is.EqualTo(v.z));
            Assert.That("(91)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "((80)7)", "0", "-9");
            var v = ov.swizzle.agga;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((80)7)", Is.EqualTo(v.y));
            Assert.That("((80)7)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "((1-1)-3)", "2", "null");
            var v = ov.swizzle.agb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((1-1)-3)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("5", "null", "(-67)", "((11)6)");
            var v = ov.swizzle.agbr;
            Assert.That("((11)6)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-67)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((6-5)4)", "8", "((9-2)9)", "5");
            var v = ov.swizzle.agbg;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("((9-2)9)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-4-3)-9)", "((-4-3)-9)", "((-4-3)-9)");
            var v = ov.swizzle.agbb;
            Assert.That("((-4-3)-9)", Is.EqualTo(v.x));
            Assert.That("((-4-3)-9)", Is.EqualTo(v.y));
            Assert.That("((-4-3)-9)", Is.EqualTo(v.z));
            Assert.That("((-4-3)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-66)1)", "((-78)1)", "null");
            var v = ov.swizzle.agba;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-66)1)", Is.EqualTo(v.y));
            Assert.That("((-78)1)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "(26)", "(26)", "3");
            var v = ov.swizzle.aga;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(26)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("5", "(7-9)", "5", "");
            var v = ov.swizzle.agar;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(7-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "-1", "((6-3)-5)", "-2");
            var v = ov.swizzle.agag;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-51)", "(-17)", "((04)7)");
            var v = ov.swizzle.agab;
            Assert.That("((04)7)", Is.EqualTo(v.x));
            Assert.That("(-51)", Is.EqualTo(v.y));
            Assert.That("((04)7)", Is.EqualTo(v.z));
            Assert.That("(-17)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-9)", "((-2-7)6)", "(-2-2)", "((47)-6)");
            var v = ov.swizzle.agaa;
            Assert.That("((47)-6)", Is.EqualTo(v.x));
            Assert.That("((-2-7)6)", Is.EqualTo(v.y));
            Assert.That("((47)-6)", Is.EqualTo(v.z));
            Assert.That("((47)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-67)2)", "9", "((-93)-8)", "((0-5)-6)");
            var v = ov.swizzle.ab;
            Assert.That("((0-5)-6)", Is.EqualTo(v.x));
            Assert.That("((-93)-8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-45)2)", "3", "", "(-60)");
            var v = ov.swizzle.abr;
            Assert.That("(-60)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-45)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("3", "(4-4)", "3", "null");
            var v = ov.swizzle.abrr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "null", "null", "-3");
            var v = ov.swizzle.abrg;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(7-9)", "(7-9)", "5");
            var v = ov.swizzle.abrb;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(7-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(7-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((99)-2)", "(-56)", "6", "null");
            var v = ov.swizzle.abra;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("((99)-2)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-8)-3)", "((-36)-4)", "((93)-1)", "null");
            var v = ov.swizzle.abg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((93)-1)", Is.EqualTo(v.y));
            Assert.That("((-36)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-23)", "((4-5)-1)", "(1-3)", "((-65)4)");
            var v = ov.swizzle.abgr;
            Assert.That("((-65)4)", Is.EqualTo(v.x));
            Assert.That("(1-3)", Is.EqualTo(v.y));
            Assert.That("((4-5)-1)", Is.EqualTo(v.z));
            Assert.That("(-23)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "(-5-7)", "(-5-7)", "((-18)-5)");
            var v = ov.swizzle.abgg;
            Assert.That("((-18)-5)", Is.EqualTo(v.x));
            Assert.That("(-5-7)", Is.EqualTo(v.y));
            Assert.That("(-5-7)", Is.EqualTo(v.z));
            Assert.That("(-5-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "7", "-6", "((01)1)");
            var v = ov.swizzle.abgb;
            Assert.That("((01)1)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-35)", "(-35)", "7", "((-42)-5)");
            var v = ov.swizzle.abga;
            Assert.That("((-42)-5)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(-35)", Is.EqualTo(v.z));
            Assert.That("((-42)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((6-8)-3)", "(9-5)", "((-62)7)");
            var v = ov.swizzle.abb;
            Assert.That("((-62)7)", Is.EqualTo(v.x));
            Assert.That("(9-5)", Is.EqualTo(v.y));
            Assert.That("(9-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((9-9)8)", "(-11)", "-6", "(-35)");
            var v = ov.swizzle.abbr;
            Assert.That("(-35)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((9-9)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((-1-2)-2)", "-9", "(-4-1)");
            var v = ov.swizzle.abbg;
            Assert.That("(-4-1)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("((-1-2)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((5-5)4)", "((96)9)", "(-13)");
            var v = ov.swizzle.abbb;
            Assert.That("(-13)", Is.EqualTo(v.x));
            Assert.That("((96)9)", Is.EqualTo(v.y));
            Assert.That("((96)9)", Is.EqualTo(v.z));
            Assert.That("((96)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(-26)", "((-7-6)5)", "((29)-9)");
            var v = ov.swizzle.abba;
            Assert.That("((29)-9)", Is.EqualTo(v.x));
            Assert.That("((-7-6)5)", Is.EqualTo(v.y));
            Assert.That("((-7-6)5)", Is.EqualTo(v.z));
            Assert.That("((29)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "null", "((-2-4)9)");
            var v = ov.swizzle.aba;
            Assert.That("((-2-4)9)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-2-4)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((16)-5)", "-7", "(04)", "-7");
            var v = ov.swizzle.abar;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(04)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((16)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-62)", "((2-5)4)", "-5", "(-4-4)");
            var v = ov.swizzle.abag;
            Assert.That("(-4-4)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(-4-4)", Is.EqualTo(v.z));
            Assert.That("((2-5)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "6", "((-47)-3)", "6");
            var v = ov.swizzle.abab;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("((-47)-3)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("((-47)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(78)", "(78)", "((85)0)", "-8");
            var v = ov.swizzle.abaa;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((85)0)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-1)-2)", "((-87)6)", "((-87)6)", "2");
            var v = ov.swizzle.aa;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((12)-8)", "null", "null", "((1-9)-9)");
            var v = ov.swizzle.aar;
            Assert.That("((1-9)-9)", Is.EqualTo(v.x));
            Assert.That("((1-9)-9)", Is.EqualTo(v.y));
            Assert.That("((12)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "9", "(0-7)", "");
            var v = ov.swizzle.aarr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "", "3", "((-73)3)");
            var v = ov.swizzle.aarg;
            Assert.That("((-73)3)", Is.EqualTo(v.x));
            Assert.That("((-73)3)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "7", "", "((9-6)-6)");
            var v = ov.swizzle.aarb;
            Assert.That("((9-6)-6)", Is.EqualTo(v.x));
            Assert.That("((9-6)-6)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-2)8)", "(6-5)", "((39)-8)", "((7-9)9)");
            var v = ov.swizzle.aara;
            Assert.That("((7-9)9)", Is.EqualTo(v.x));
            Assert.That("((7-9)9)", Is.EqualTo(v.y));
            Assert.That("((-2-2)8)", Is.EqualTo(v.z));
            Assert.That("((7-9)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-1)-4)", "(30)", "-4", "((18)-1)");
            var v = ov.swizzle.aag;
            Assert.That("((18)-1)", Is.EqualTo(v.x));
            Assert.That("((18)-1)", Is.EqualTo(v.y));
            Assert.That("(30)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((19)-5)", "(46)", "((19)-5)", "1");
            var v = ov.swizzle.aagr;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("(46)", Is.EqualTo(v.z));
            Assert.That("((19)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-2", "", "null");
            var v = ov.swizzle.aagg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((20)5)", "", "-9", "(-3-7)");
            var v = ov.swizzle.aagb;
            Assert.That("(-3-7)", Is.EqualTo(v.x));
            Assert.That("(-3-7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((75)-3)", "(59)", "", "5");
            var v = ov.swizzle.aaga;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(59)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-81)", "(-81)", "(-20)", "((-33)-3)");
            var v = ov.swizzle.aab;
            Assert.That("((-33)-3)", Is.EqualTo(v.x));
            Assert.That("((-33)-3)", Is.EqualTo(v.y));
            Assert.That("(-20)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-85)-8)", "((-3-1)-4)", "(13)", "3");
            var v = ov.swizzle.aabr;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(13)", Is.EqualTo(v.z));
            Assert.That("((-85)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((45)-2)", "((56)-8)", "9", "");
            var v = ov.swizzle.aabg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("((56)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-2)-2)", "((-3-6)6)", "((85)-7)", "(-23)");
            var v = ov.swizzle.aabb;
            Assert.That("(-23)", Is.EqualTo(v.x));
            Assert.That("(-23)", Is.EqualTo(v.y));
            Assert.That("((85)-7)", Is.EqualTo(v.z));
            Assert.That("((85)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-1)", "(9-1)", "(87)", "7");
            var v = ov.swizzle.aaba;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(87)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((-7-1)-4)", "", "");
            var v = ov.swizzle.aaa;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-2", "(-9-5)", "(-41)", "(-41)");
            var v = ov.swizzle.aaar;
            Assert.That("(-41)", Is.EqualTo(v.x));
            Assert.That("(-41)", Is.EqualTo(v.y));
            Assert.That("(-41)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-2)8)", "(-36)", "null", "((6-3)-1)");
            var v = ov.swizzle.aaag;
            Assert.That("((6-3)-1)", Is.EqualTo(v.x));
            Assert.That("((6-3)-1)", Is.EqualTo(v.y));
            Assert.That("((6-3)-1)", Is.EqualTo(v.z));
            Assert.That("(-36)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-1", "((-13)-8)", "");
            var v = ov.swizzle.aaab;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-13)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(68)", "", "4", "");
            var v = ov.swizzle.aaaa;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec4<string>("(-78)", "null", "(-78)", "(97)");
            var v1 = new gvec2<string>("-9", "((-6-6)-9)");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-9", Is.EqualTo(v0.x));
            Assert.That("((-6-6)-9)", Is.EqualTo(v0.y));
            Assert.That("(-78)", Is.EqualTo(v0.z));
            Assert.That("(97)", Is.EqualTo(v0.w));
        
            Assert.That("(-78)", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("-1", "", "(03)", "-1");
            var v1 = new gvec2<string>("((6-9)6)", "(-8-7)");
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((6-9)6)", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("(-8-7)", Is.EqualTo(v0.z));
            Assert.That("-1", Is.EqualTo(v0.w));
        
            Assert.That("-1", Is.EqualTo(v2.x));
            Assert.That("(03)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("-6", "3", "9", "");
            var v1 = new gvec2<string>("-2", "((58)8)");
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-6", Is.EqualTo(v0.x));
            Assert.That("-2", Is.EqualTo(v0.y));
            Assert.That("((58)8)", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("3", Is.EqualTo(v2.x));
            Assert.That("9", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(02)", "null", "((2-4)5)", "(-92)");
            var v1 = new gvec3<string>("(20)", "((4-1)6)", "((0-3)-6)");
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(20)", Is.EqualTo(v0.x));
            Assert.That("((4-1)6)", Is.EqualTo(v0.y));
            Assert.That("((0-3)-6)", Is.EqualTo(v0.z));
            Assert.That("(-92)", Is.EqualTo(v0.w));
        
            Assert.That("(02)", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
            Assert.That("((2-4)5)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("((-29)9)", "(59)", "", "(1-5)");
            var v1 = new gvec2<string>("-9", "");
            var v2 = v0.xw;
            v0.xw = v1;
            var v3 = v0.xw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-9", Is.EqualTo(v0.x));
            Assert.That("(59)", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("((-29)9)", Is.EqualTo(v2.x));
            Assert.That("(1-5)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(19)", "null", "null", "(-5-5)");
            var v1 = new gvec2<string>("(10)", "1");
            var v2 = v0.yw;
            v0.yw = v1;
            var v3 = v0.yw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(19)", Is.EqualTo(v0.x));
            Assert.That("(10)", Is.EqualTo(v0.y));
            Assert.That("null", Is.EqualTo(v0.z));
            Assert.That("1", Is.EqualTo(v0.w));
        
            Assert.That("null", Is.EqualTo(v2.x));
            Assert.That("(-5-5)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(2-3)", "((-80)-7)", "0", "(-36)");
            var v1 = new gvec3<string>("4", "", "-7");
            var v2 = v0.xyw;
            v0.xyw = v1;
            var v3 = v0.xyw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("4", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("0", Is.EqualTo(v0.z));
            Assert.That("-7", Is.EqualTo(v0.w));
        
            Assert.That("(2-3)", Is.EqualTo(v2.x));
            Assert.That("((-80)-7)", Is.EqualTo(v2.y));
            Assert.That("(-36)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(-59)", "(20)", "(-59)", "((-7-1)0)");
            var v1 = new gvec2<string>("-9", "((-35)-3)");
            var v2 = v0.zw;
            v0.zw = v1;
            var v3 = v0.zw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-59)", Is.EqualTo(v0.x));
            Assert.That("(20)", Is.EqualTo(v0.y));
            Assert.That("-9", Is.EqualTo(v0.z));
            Assert.That("((-35)-3)", Is.EqualTo(v0.w));
        
            Assert.That("(-59)", Is.EqualTo(v2.x));
            Assert.That("((-7-1)0)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("", "6", "((-4-7)4)", "null");
            var v1 = new gvec3<string>("-2", "((0-3)3)", "");
            var v2 = v0.xzw;
            v0.xzw = v1;
            var v3 = v0.xzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-2", Is.EqualTo(v0.x));
            Assert.That("6", Is.EqualTo(v0.y));
            Assert.That("((0-3)3)", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("((-4-7)4)", Is.EqualTo(v2.y));
            Assert.That("null", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("9", "((08)-5)", "9", "((08)-5)");
            var v1 = new gvec3<string>("null", "-7", "null");
            var v2 = v0.yzw;
            v0.yzw = v1;
            var v3 = v0.yzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("9", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("-7", Is.EqualTo(v0.z));
            Assert.That("null", Is.EqualTo(v0.w));
        
            Assert.That("((08)-5)", Is.EqualTo(v2.x));
            Assert.That("9", Is.EqualTo(v2.y));
            Assert.That("((08)-5)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("null", "((-34)7)", "(-68)", "null");
            var v1 = new gvec4<string>("(41)", "8", "2", "((-34)-3)");
            var v2 = v0.xyzw;
            v0.xyzw = v1;
            var v3 = v0.xyzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(41)", Is.EqualTo(v0.x));
            Assert.That("8", Is.EqualTo(v0.y));
            Assert.That("2", Is.EqualTo(v0.z));
            Assert.That("((-34)-3)", Is.EqualTo(v0.w));
        
            Assert.That("null", Is.EqualTo(v2.x));
            Assert.That("((-34)7)", Is.EqualTo(v2.y));
            Assert.That("(-68)", Is.EqualTo(v2.z));
            Assert.That("null", Is.EqualTo(v2.w));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new gvec4<string>("((-20)4)", "", "((96)-2)", "(-21)");
            var v1 = "((90)-8)";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((90)-8)", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("((96)-2)", Is.EqualTo(v0.z));
            Assert.That("(-21)", Is.EqualTo(v0.w));
        
            Assert.That("((-20)4)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("(-62)", "(-6-1)", "(11)", "-1");
            var v1 = "null";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-62)", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("(11)", Is.EqualTo(v0.z));
            Assert.That("-1", Is.EqualTo(v0.w));
        
            Assert.That("(-6-1)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("(11)", "5", "(2-4)", "null");
            var v1 = new gvec2<string>("((10)-5)", "(-78)");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((10)-5)", Is.EqualTo(v0.x));
            Assert.That("(-78)", Is.EqualTo(v0.y));
            Assert.That("(2-4)", Is.EqualTo(v0.z));
            Assert.That("null", Is.EqualTo(v0.w));
        
            Assert.That("(11)", Is.EqualTo(v2.x));
            Assert.That("5", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(0-3)", "0", "-1", "((39)-2)");
            var v1 = "(45)";
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(0-3)", Is.EqualTo(v0.x));
            Assert.That("0", Is.EqualTo(v0.y));
            Assert.That("(45)", Is.EqualTo(v0.z));
            Assert.That("((39)-2)", Is.EqualTo(v0.w));
        
            Assert.That("-1", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("-4", "(20)", "(20)", "-4");
            var v1 = new gvec2<string>("(-81)", "null");
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-81)", Is.EqualTo(v0.x));
            Assert.That("(20)", Is.EqualTo(v0.y));
            Assert.That("null", Is.EqualTo(v0.z));
            Assert.That("-4", Is.EqualTo(v0.w));
        
            Assert.That("-4", Is.EqualTo(v2.x));
            Assert.That("(20)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("", "-9", "((6-6)-3)", "(4-1)");
            var v1 = new gvec2<string>("((40)5)", "((-34)-6)");
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("((40)5)", Is.EqualTo(v0.y));
            Assert.That("((-34)-6)", Is.EqualTo(v0.z));
            Assert.That("(4-1)", Is.EqualTo(v0.w));
        
            Assert.That("-9", Is.EqualTo(v2.x));
            Assert.That("((6-6)-3)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((-47)0)", "(-96)", "((-47)0)", "null");
            var v1 = new gvec3<string>("(-6-1)", "((2-2)-7)", "((-6-6)0)");
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-6-1)", Is.EqualTo(v0.x));
            Assert.That("((2-2)-7)", Is.EqualTo(v0.y));
            Assert.That("((-6-6)0)", Is.EqualTo(v0.z));
            Assert.That("null", Is.EqualTo(v0.w));
        
            Assert.That("((-47)0)", Is.EqualTo(v2.x));
            Assert.That("(-96)", Is.EqualTo(v2.y));
            Assert.That("((-47)0)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("((-75)6)", "null", "((-75)6)", "(-25)");
            var v1 = "-6";
            var v2 = v0.a;
            v0.a = v1;
            var v3 = v0.a;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-75)6)", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("((-75)6)", Is.EqualTo(v0.z));
            Assert.That("-6", Is.EqualTo(v0.w));
        
            Assert.That("(-25)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("(39)", "-6", "(-90)", "7");
            var v1 = new gvec2<string>("null", "-3");
            var v2 = v0.ra;
            v0.ra = v1;
            var v3 = v0.ra;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("-6", Is.EqualTo(v0.y));
            Assert.That("(-90)", Is.EqualTo(v0.z));
            Assert.That("-3", Is.EqualTo(v0.w));
        
            Assert.That("(39)", Is.EqualTo(v2.x));
            Assert.That("7", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("", "null", "((7-8)7)", "");
            var v1 = new gvec2<string>("((-37)1)", "1");
            var v2 = v0.ga;
            v0.ga = v1;
            var v3 = v0.ga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("((-37)1)", Is.EqualTo(v0.y));
            Assert.That("((7-8)7)", Is.EqualTo(v0.z));
            Assert.That("1", Is.EqualTo(v0.w));
        
            Assert.That("null", Is.EqualTo(v2.x));
            Assert.That("", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("", "(9-2)", "(9-2)", "-5");
            var v1 = new gvec3<string>("((26)-4)", "(-78)", "-7");
            var v2 = v0.rga;
            v0.rga = v1;
            var v3 = v0.rga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((26)-4)", Is.EqualTo(v0.x));
            Assert.That("(-78)", Is.EqualTo(v0.y));
            Assert.That("(9-2)", Is.EqualTo(v0.z));
            Assert.That("-7", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("(9-2)", Is.EqualTo(v2.y));
            Assert.That("-5", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("-7", "((-62)-5)", "((-92)-3)", "((56)8)");
            var v1 = new gvec2<string>("0", "0");
            var v2 = v0.ba;
            v0.ba = v1;
            var v3 = v0.ba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-7", Is.EqualTo(v0.x));
            Assert.That("((-62)-5)", Is.EqualTo(v0.y));
            Assert.That("0", Is.EqualTo(v0.z));
            Assert.That("0", Is.EqualTo(v0.w));
        
            Assert.That("((-92)-3)", Is.EqualTo(v2.x));
            Assert.That("((56)8)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(24)", "5", "((1-1)-1)", "(-6-9)");
            var v1 = new gvec3<string>("", "-3", "((-92)-2)");
            var v2 = v0.rba;
            v0.rba = v1;
            var v3 = v0.rba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("5", Is.EqualTo(v0.y));
            Assert.That("-3", Is.EqualTo(v0.z));
            Assert.That("((-92)-2)", Is.EqualTo(v0.w));
        
            Assert.That("(24)", Is.EqualTo(v2.x));
            Assert.That("((1-1)-1)", Is.EqualTo(v2.y));
            Assert.That("(-6-9)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("((0-1)2)", "4", "-2", "((60)1)");
            var v1 = new gvec3<string>("null", "5", "(9-4)");
            var v2 = v0.gba;
            v0.gba = v1;
            var v3 = v0.gba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((0-1)2)", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("5", Is.EqualTo(v0.z));
            Assert.That("(9-4)", Is.EqualTo(v0.w));
        
            Assert.That("4", Is.EqualTo(v2.x));
            Assert.That("-2", Is.EqualTo(v2.y));
            Assert.That("((60)1)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("-4", "((-30)-2)", "(83)", "((-40)3)");
            var v1 = new gvec4<string>("(7-4)", "(7-4)", "1", "(7-4)");
            var v2 = v0.rgba;
            v0.rgba = v1;
            var v3 = v0.rgba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(7-4)", Is.EqualTo(v0.x));
            Assert.That("(7-4)", Is.EqualTo(v0.y));
            Assert.That("1", Is.EqualTo(v0.z));
            Assert.That("(7-4)", Is.EqualTo(v0.w));
        
            Assert.That("-4", Is.EqualTo(v2.x));
            Assert.That("((-30)-2)", Is.EqualTo(v2.y));
            Assert.That("(83)", Is.EqualTo(v2.z));
            Assert.That("((-40)3)", Is.EqualTo(v2.w));
        }
    }

}
