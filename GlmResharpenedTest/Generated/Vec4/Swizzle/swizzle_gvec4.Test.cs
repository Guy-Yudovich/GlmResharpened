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
            var ov = new gvec4<string>("((-83)4)", "(72)", "1", "((-42)9)");
            var v = ov.swizzle.xx;
            Assert.That("((-83)4)", Is.EqualTo(v.x));
            Assert.That("((-83)4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("null", "(96)", "((1-8)5)", "(41)");
            var v = ov.swizzle.xxx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((6-3)4)", "(-57)", "(-57)", "null");
            var v = ov.swizzle.xxxx;
            Assert.That("((6-3)4)", Is.EqualTo(v.x));
            Assert.That("((6-3)4)", Is.EqualTo(v.y));
            Assert.That("((6-3)4)", Is.EqualTo(v.z));
            Assert.That("((6-3)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-1)", "", "((-2-3)0)", "0");
            var v = ov.swizzle.xxxy;
            Assert.That("(-3-1)", Is.EqualTo(v.x));
            Assert.That("(-3-1)", Is.EqualTo(v.y));
            Assert.That("(-3-1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-32)", "((2-4)0)", "4", "((2-4)0)");
            var v = ov.swizzle.xxxz;
            Assert.That("(-32)", Is.EqualTo(v.x));
            Assert.That("(-32)", Is.EqualTo(v.y));
            Assert.That("(-32)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(17)", "(17)", "(-4-4)");
            var v = ov.swizzle.xxxw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-4-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-7)-2)", "((-4-4)-6)", "(-2-7)", "((0-7)-2)");
            var v = ov.swizzle.xxy;
            Assert.That("((0-7)-2)", Is.EqualTo(v.x));
            Assert.That("((0-7)-2)", Is.EqualTo(v.y));
            Assert.That("((-4-4)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-7", "-9", "-9", "-7");
            var v = ov.swizzle.xxyx;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-67)", "((-86)-7)", "((89)-7)", "null");
            var v = ov.swizzle.xxyy;
            Assert.That("(-67)", Is.EqualTo(v.x));
            Assert.That("(-67)", Is.EqualTo(v.y));
            Assert.That("((-86)-7)", Is.EqualTo(v.z));
            Assert.That("((-86)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-7)2)", "1", "((-20)-6)", "((2-7)2)");
            var v = ov.swizzle.xxyz;
            Assert.That("((2-7)2)", Is.EqualTo(v.x));
            Assert.That("((2-7)2)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("((-20)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-99)0)", "4", "(-11)");
            var v = ov.swizzle.xxyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-99)0)", Is.EqualTo(v.z));
            Assert.That("(-11)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-4)-4)", "2", "(-6-6)", "((7-4)-4)");
            var v = ov.swizzle.xxz;
            Assert.That("((7-4)-4)", Is.EqualTo(v.x));
            Assert.That("((7-4)-4)", Is.EqualTo(v.y));
            Assert.That("(-6-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "3", "(-7-1)", "6");
            var v = ov.swizzle.xxzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-7-1)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "null", "((69)-9)", "");
            var v = ov.swizzle.xxzy;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((69)-9)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-5", "(1-9)", "((1-1)-4)");
            var v = ov.swizzle.xxzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(1-9)", Is.EqualTo(v.z));
            Assert.That("(1-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "-2", "((26)-2)");
            var v = ov.swizzle.xxzw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("((26)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "4", "(7-8)", "8");
            var v = ov.swizzle.xxw;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-8-6)-5)", "", "(69)", "((-8-7)-2)");
            var v = ov.swizzle.xxwx;
            Assert.That("((-8-6)-5)", Is.EqualTo(v.x));
            Assert.That("((-8-6)-5)", Is.EqualTo(v.y));
            Assert.That("((-8-7)-2)", Is.EqualTo(v.z));
            Assert.That("((-8-6)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "null", "(-27)");
            var v = ov.swizzle.xxwy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-27)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((91)0)", "9", "((9-8)3)");
            var v = ov.swizzle.xxwz;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("((9-8)3)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-42)", "((24)-8)", "8", "(5-9)");
            var v = ov.swizzle.xxww;
            Assert.That("(-42)", Is.EqualTo(v.x));
            Assert.That("(-42)", Is.EqualTo(v.y));
            Assert.That("(5-9)", Is.EqualTo(v.z));
            Assert.That("(5-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-7)", "", "-1", "-1");
            var v = ov.swizzle.xy;
            Assert.That("(2-7)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-5", "((11)0)", "(68)", "-7");
            var v = ov.swizzle.xyx;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("((11)0)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((93)1)", "", "((93)1)", "((3-1)-5)");
            var v = ov.swizzle.xyxx;
            Assert.That("((93)1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((93)1)", Is.EqualTo(v.z));
            Assert.That("((93)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "(-33)", "-8");
            var v = ov.swizzle.xyxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "-8", "(5-9)", "(8-2)");
            var v = ov.swizzle.xyxz;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("(5-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "(-2-8)", "1", "6");
            var v = ov.swizzle.xyxw;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(-2-8)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-18)-8)", "((24)-2)", "4", "(4-8)");
            var v = ov.swizzle.xyy;
            Assert.That("((-18)-8)", Is.EqualTo(v.x));
            Assert.That("((24)-2)", Is.EqualTo(v.y));
            Assert.That("((24)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "((4-7)-1)", "(-85)", "2");
            var v = ov.swizzle.xyyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((4-7)-1)", Is.EqualTo(v.y));
            Assert.That("((4-7)-1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(94)", "(8-2)", "4");
            var v = ov.swizzle.xyyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(94)", Is.EqualTo(v.y));
            Assert.That("(94)", Is.EqualTo(v.z));
            Assert.That("(94)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "(25)", "1", "((9-3)-1)");
            var v = ov.swizzle.xyyz;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(25)", Is.EqualTo(v.y));
            Assert.That("(25)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(3-2)", "6", "(01)", "null");
            var v = ov.swizzle.xyyw;
            Assert.That("(3-2)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "", "(-6-8)", "(66)");
            var v = ov.swizzle.xyz;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-6-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-1-9)", "(-93)", "((8-7)-8)", "((-31)4)");
            var v = ov.swizzle.xyzx;
            Assert.That("(-1-9)", Is.EqualTo(v.x));
            Assert.That("(-93)", Is.EqualTo(v.y));
            Assert.That("((8-7)-8)", Is.EqualTo(v.z));
            Assert.That("(-1-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "-5", "-5", "-7");
            var v = ov.swizzle.xyzy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-8)0)", "((-2-8)0)", "", "null");
            var v = ov.swizzle.xyzz;
            Assert.That("((-2-8)0)", Is.EqualTo(v.x));
            Assert.That("((-2-8)0)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-57)-5)", "((4-8)-5)", "-4", "(39)");
            var v = ov.swizzle.xyzw;
            Assert.That("((-57)-5)", Is.EqualTo(v.x));
            Assert.That("((4-8)-5)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(39)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "((68)-4)", "", "((5-5)1)");
            var v = ov.swizzle.xyw;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((68)-4)", Is.EqualTo(v.y));
            Assert.That("((5-5)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-3", "(5-6)", "(-11)", "-4");
            var v = ov.swizzle.xywx;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(5-6)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "", "(7-1)", "3");
            var v = ov.swizzle.xywy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-24)1)", "(-6-7)", "null", "null");
            var v = ov.swizzle.xywz;
            Assert.That("((-24)1)", Is.EqualTo(v.x));
            Assert.That("(-6-7)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-4)-9)", "-4", "-4", "(4-5)");
            var v = ov.swizzle.xyww;
            Assert.That("((-5-4)-9)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(4-5)", Is.EqualTo(v.z));
            Assert.That("(4-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((93)5)", "(75)", "", "(75)");
            var v = ov.swizzle.xz;
            Assert.That("((93)5)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-87)", "(28)", "((-6-6)2)", "-2");
            var v = ov.swizzle.xzx;
            Assert.That("(-87)", Is.EqualTo(v.x));
            Assert.That("((-6-6)2)", Is.EqualTo(v.y));
            Assert.That("(-87)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("3", "((-3-2)-7)", "3", "((-3-2)-7)");
            var v = ov.swizzle.xzxx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(78)", "(-23)", "(78)", "(-23)");
            var v = ov.swizzle.xzxy;
            Assert.That("(78)", Is.EqualTo(v.x));
            Assert.That("(78)", Is.EqualTo(v.y));
            Assert.That("(78)", Is.EqualTo(v.z));
            Assert.That("(-23)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-1)6)", "(-71)", "0", "((40)6)");
            var v = ov.swizzle.xzxz;
            Assert.That("((5-1)6)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((5-1)6)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-4)", "", "9", "((-3-7)7)");
            var v = ov.swizzle.xzxw;
            Assert.That("(-5-4)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("(-5-4)", Is.EqualTo(v.z));
            Assert.That("((-3-7)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-1)", "-9", "((61)8)", "");
            var v = ov.swizzle.xzy;
            Assert.That("(-9-1)", Is.EqualTo(v.x));
            Assert.That("((61)8)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(-32)", "((09)-9)", "null");
            var v = ov.swizzle.xzyx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((09)-9)", Is.EqualTo(v.y));
            Assert.That("(-32)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-4-9)4)", "(61)", "");
            var v = ov.swizzle.xzyy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(61)", Is.EqualTo(v.y));
            Assert.That("((-4-9)4)", Is.EqualTo(v.z));
            Assert.That("((-4-9)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-6)8)", "-8", "null", "-8");
            var v = ov.swizzle.xzyz;
            Assert.That("((-1-6)8)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-6)5)", "(22)", "", "((-9-6)5)");
            var v = ov.swizzle.xzyw;
            Assert.That("((-9-6)5)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(22)", Is.EqualTo(v.z));
            Assert.That("((-9-6)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-6)", "(11)", "-7", "");
            var v = ov.swizzle.xzz;
            Assert.That("(8-6)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-4-2)-4)", "-4", "(76)", "-4");
            var v = ov.swizzle.xzzx;
            Assert.That("((-4-2)-4)", Is.EqualTo(v.x));
            Assert.That("(76)", Is.EqualTo(v.y));
            Assert.That("(76)", Is.EqualTo(v.z));
            Assert.That("((-4-2)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((-2-3)5)", "", "(24)");
            var v = ov.swizzle.xzzy;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-2-3)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-5)", "(4-2)", "2", "((7-7)-1)");
            var v = ov.swizzle.xzzz;
            Assert.That("(2-5)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "", "0", "((-91)-9)");
            var v = ov.swizzle.xzzw;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("((-91)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-3)-4)", "((3-3)-4)", "((-8-2)-2)", "0");
            var v = ov.swizzle.xzw;
            Assert.That("((3-3)-4)", Is.EqualTo(v.x));
            Assert.That("((-8-2)-2)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-3-3)", "((47)-5)", "((03)6)", "-2");
            var v = ov.swizzle.xzwx;
            Assert.That("(-3-3)", Is.EqualTo(v.x));
            Assert.That("((03)6)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("(-3-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(-7-9)", "", "null");
            var v = ov.swizzle.xzwy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-7-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((89)7)", "", "(5-1)", "((89)7)");
            var v = ov.swizzle.xzwz;
            Assert.That("((89)7)", Is.EqualTo(v.x));
            Assert.That("(5-1)", Is.EqualTo(v.y));
            Assert.That("((89)7)", Is.EqualTo(v.z));
            Assert.That("(5-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((6-2)-6)", "((38)4)", "((6-2)-6)", "-8");
            var v = ov.swizzle.xzww;
            Assert.That("((6-2)-6)", Is.EqualTo(v.x));
            Assert.That("((6-2)-6)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "7", "-3", "8");
            var v = ov.swizzle.xw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("0", "null", "0", "(38)");
            var v = ov.swizzle.xwx;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(38)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((81)-6)", "((81)-6)", "(-5-6)", "-2");
            var v = ov.swizzle.xwxx;
            Assert.That("((81)-6)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((81)-6)", Is.EqualTo(v.z));
            Assert.That("((81)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-3)", "((-41)6)", "", "(69)");
            var v = ov.swizzle.xwxy;
            Assert.That("(0-3)", Is.EqualTo(v.x));
            Assert.That("(69)", Is.EqualTo(v.y));
            Assert.That("(0-3)", Is.EqualTo(v.z));
            Assert.That("((-41)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(67)", "((81)-1)", "((-61)7)", "((-11)-1)");
            var v = ov.swizzle.xwxz;
            Assert.That("(67)", Is.EqualTo(v.x));
            Assert.That("((-11)-1)", Is.EqualTo(v.y));
            Assert.That("(67)", Is.EqualTo(v.z));
            Assert.That("((-61)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-9-2)-5)", "(-4-2)", "-5");
            var v = ov.swizzle.xwxw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-2)-6)", "", "((1-8)1)", "5");
            var v = ov.swizzle.xwy;
            Assert.That("((2-2)-6)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-78)", "-8", "8", "((4-2)-1)");
            var v = ov.swizzle.xwyx;
            Assert.That("(-78)", Is.EqualTo(v.x));
            Assert.That("((4-2)-1)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("(-78)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-90)-1)", "", "", "(50)");
            var v = ov.swizzle.xwyy;
            Assert.That("((-90)-1)", Is.EqualTo(v.x));
            Assert.That("(50)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-7)", "null", "((87)5)", "((31)6)");
            var v = ov.swizzle.xwyz;
            Assert.That("(-6-7)", Is.EqualTo(v.x));
            Assert.That("((31)6)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((87)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-9)9)", "-3", "(31)", "(31)");
            var v = ov.swizzle.xwyw;
            Assert.That("((-8-9)9)", Is.EqualTo(v.x));
            Assert.That("(31)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(31)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(1-6)", "(27)", "-2");
            var v = ov.swizzle.xwz;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("(27)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(6-3)", "null", "(5-1)", "((21)6)");
            var v = ov.swizzle.xwzx;
            Assert.That("(6-3)", Is.EqualTo(v.x));
            Assert.That("((21)6)", Is.EqualTo(v.y));
            Assert.That("(5-1)", Is.EqualTo(v.z));
            Assert.That("(6-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-2)-8)", "4", "4", "4");
            var v = ov.swizzle.xwzy;
            Assert.That("((5-2)-8)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-5", "null", "-1");
            var v = ov.swizzle.xwzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "(-17)", "-5", "((-26)5)");
            var v = ov.swizzle.xwzw;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((-26)5)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("((-26)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "2", "8", "2");
            var v = ov.swizzle.xww;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((0-7)-7)", "(-44)", "null", "null");
            var v = ov.swizzle.xwwx;
            Assert.That("((0-7)-7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((0-7)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-23)9)", "-9", "6", "((-61)5)");
            var v = ov.swizzle.xwwy;
            Assert.That("((-23)9)", Is.EqualTo(v.x));
            Assert.That("((-61)5)", Is.EqualTo(v.y));
            Assert.That("((-61)5)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((5-3)-2)", "((5-3)-2)", "3");
            var v = ov.swizzle.xwwz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("((5-3)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(28)", "((33)-7)", "((-65)0)", "7");
            var v = ov.swizzle.xwww;
            Assert.That("(28)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((57)4)", "((4-2)-6)", "(-63)");
            var v = ov.swizzle.yx;
            Assert.That("((57)4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(36)", "((-90)0)", "((-90)0)", "7");
            var v = ov.swizzle.yxx;
            Assert.That("((-90)0)", Is.EqualTo(v.x));
            Assert.That("(36)", Is.EqualTo(v.y));
            Assert.That("(36)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-8-1)-8)", "null", "((-8-1)-8)", "((3-5)1)");
            var v = ov.swizzle.yxxx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-8-1)-8)", Is.EqualTo(v.y));
            Assert.That("((-8-1)-8)", Is.EqualTo(v.z));
            Assert.That("((-8-1)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-8)-4)", "((2-9)8)", "", "-5");
            var v = ov.swizzle.yxxy;
            Assert.That("((2-9)8)", Is.EqualTo(v.x));
            Assert.That("((-5-8)-4)", Is.EqualTo(v.y));
            Assert.That("((-5-8)-4)", Is.EqualTo(v.z));
            Assert.That("((2-9)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "-4", "((0-3)-7)", "(93)");
            var v = ov.swizzle.yxxz;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("((0-3)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "(23)", "(-96)", "(-8-6)");
            var v = ov.swizzle.yxxw;
            Assert.That("(23)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("(-8-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-6)", "-1", "(0-6)", "((-8-6)2)");
            var v = ov.swizzle.yxy;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("(0-6)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "5", "((9-9)7)", "(-57)");
            var v = ov.swizzle.yxyx;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((70)-8)", "-5", "-1", "(9-2)");
            var v = ov.swizzle.yxyy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("((70)-8)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((91)9)", "(0-5)", "((25)-3)", "(-41)");
            var v = ov.swizzle.yxyz;
            Assert.That("(0-5)", Is.EqualTo(v.x));
            Assert.That("((91)9)", Is.EqualTo(v.y));
            Assert.That("(0-5)", Is.EqualTo(v.z));
            Assert.That("((25)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-9)", "(78)", "(8-9)", "((-1-4)0)");
            var v = ov.swizzle.yxyw;
            Assert.That("(78)", Is.EqualTo(v.x));
            Assert.That("(8-9)", Is.EqualTo(v.y));
            Assert.That("(78)", Is.EqualTo(v.z));
            Assert.That("((-1-4)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-5)", "4", "4", "((2-3)-4)");
            var v = ov.swizzle.yxz;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("(6-5)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(5-4)", "(7-2)", "(7-2)", "(-32)");
            var v = ov.swizzle.yxzx;
            Assert.That("(7-2)", Is.EqualTo(v.x));
            Assert.That("(5-4)", Is.EqualTo(v.y));
            Assert.That("(7-2)", Is.EqualTo(v.z));
            Assert.That("(5-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((46)9)", "((46)9)", "");
            var v = ov.swizzle.yxzy;
            Assert.That("((46)9)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((46)9)", Is.EqualTo(v.z));
            Assert.That("((46)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-4)8)", "null", "((-76)3)", "((-70)3)");
            var v = ov.swizzle.yxzz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((9-4)8)", Is.EqualTo(v.y));
            Assert.That("((-76)3)", Is.EqualTo(v.z));
            Assert.That("((-76)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((39)3)", "-9", "((-3-7)-7)", "(-7-1)");
            var v = ov.swizzle.yxzw;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((39)3)", Is.EqualTo(v.y));
            Assert.That("((-3-7)-7)", Is.EqualTo(v.z));
            Assert.That("(-7-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-2", "(34)", "((-99)-7)");
            var v = ov.swizzle.yxw;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-99)-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(18)", "((3-4)5)", "((24)1)");
            var v = ov.swizzle.yxwx;
            Assert.That("(18)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((24)1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((85)-7)", "7", "(-63)", "(-2-5)");
            var v = ov.swizzle.yxwy;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((85)-7)", Is.EqualTo(v.y));
            Assert.That("(-2-5)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-9)-4)", "", "((81)6)", "2");
            var v = ov.swizzle.yxwz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-6-9)-4)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("((81)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "4", "(13)", "(-3-9)");
            var v = ov.swizzle.yxww;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("(-3-9)", Is.EqualTo(v.z));
            Assert.That("(-3-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-2)-8)", "-6", "-6", "((-4-2)-8)");
            var v = ov.swizzle.yy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((3-8)3)", "5", "", "(-88)");
            var v = ov.swizzle.yyx;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("((3-8)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("4", "((23)8)", "4", "((-4-6)-8)");
            var v = ov.swizzle.yyxx;
            Assert.That("((23)8)", Is.EqualTo(v.x));
            Assert.That("((23)8)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-9", "(-9-9)", "9");
            var v = ov.swizzle.yyxy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((-7-4)-6)", "0", "0");
            var v = ov.swizzle.yyxz;
            Assert.That("((-7-4)-6)", Is.EqualTo(v.x));
            Assert.That("((-7-4)-6)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-1)1)", "((-9-1)1)", "((-9-1)1)", "(57)");
            var v = ov.swizzle.yyxw;
            Assert.That("((-9-1)1)", Is.EqualTo(v.x));
            Assert.That("((-9-1)1)", Is.EqualTo(v.y));
            Assert.That("((-9-1)1)", Is.EqualTo(v.z));
            Assert.That("(57)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "8", "(95)", "((-55)-9)");
            var v = ov.swizzle.yyy;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-7", "(62)", "(9-9)", "");
            var v = ov.swizzle.yyyx;
            Assert.That("(62)", Is.EqualTo(v.x));
            Assert.That("(62)", Is.EqualTo(v.y));
            Assert.That("(62)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "7", "((8-7)7)", "null");
            var v = ov.swizzle.yyyy;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "5", "(4-8)", "5");
            var v = ov.swizzle.yyyz;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("(4-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(86)", "((02)-7)", "(6-7)");
            var v = ov.swizzle.yyyw;
            Assert.That("(86)", Is.EqualTo(v.x));
            Assert.That("(86)", Is.EqualTo(v.y));
            Assert.That("(86)", Is.EqualTo(v.z));
            Assert.That("(6-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "(-77)", "(-63)", "((4-9)-9)");
            var v = ov.swizzle.yyz;
            Assert.That("(-77)", Is.EqualTo(v.x));
            Assert.That("(-77)", Is.EqualTo(v.y));
            Assert.That("(-63)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("0", "(-14)", "(97)", "((4-6)-2)");
            var v = ov.swizzle.yyzx;
            Assert.That("(-14)", Is.EqualTo(v.x));
            Assert.That("(-14)", Is.EqualTo(v.y));
            Assert.That("(97)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-9)", "(-9-9)", "null", "6");
            var v = ov.swizzle.yyzy;
            Assert.That("(-9-9)", Is.EqualTo(v.x));
            Assert.That("(-9-9)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-9-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(06)", "(06)", "((-12)1)", "((9-5)-9)");
            var v = ov.swizzle.yyzz;
            Assert.That("(06)", Is.EqualTo(v.x));
            Assert.That("(06)", Is.EqualTo(v.y));
            Assert.That("((-12)1)", Is.EqualTo(v.z));
            Assert.That("((-12)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-79)", "null", "null", "((45)6)");
            var v = ov.swizzle.yyzw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((45)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-5-6)-6)", "((-8-6)8)", "null");
            var v = ov.swizzle.yyw;
            Assert.That("((-5-6)-6)", Is.EqualTo(v.x));
            Assert.That("((-5-6)-6)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((6-3)3)", "(88)", "", "(88)");
            var v = ov.swizzle.yywx;
            Assert.That("(88)", Is.EqualTo(v.x));
            Assert.That("(88)", Is.EqualTo(v.y));
            Assert.That("(88)", Is.EqualTo(v.z));
            Assert.That("((6-3)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "7", "-4", "7");
            var v = ov.swizzle.yywy;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-8)-1)", "", "(48)", "3");
            var v = ov.swizzle.yywz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("(48)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "((-20)-5)", "((-4-7)0)", "(4-4)");
            var v = ov.swizzle.yyww;
            Assert.That("((-20)-5)", Is.EqualTo(v.x));
            Assert.That("((-20)-5)", Is.EqualTo(v.y));
            Assert.That("(4-4)", Is.EqualTo(v.z));
            Assert.That("(4-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-88)-4)", "9", "-9", "(3-9)");
            var v = ov.swizzle.yz;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("9", "null", "7", "(-9-6)");
            var v = ov.swizzle.yzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "null", "(-91)", "((-2-6)9)");
            var v = ov.swizzle.yzxx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-91)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(3-7)", "1", "1", "(3-7)");
            var v = ov.swizzle.yzxy;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("(3-7)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-7)", "", "null", "((-6-7)7)");
            var v = ov.swizzle.yzxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(8-7)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((08)-2)", "null", "(4-5)", "-3");
            var v = ov.swizzle.yzxw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(4-5)", Is.EqualTo(v.y));
            Assert.That("((08)-2)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((62)-6)", "((24)2)", "((-6-8)3)", "(75)");
            var v = ov.swizzle.yzy;
            Assert.That("((24)2)", Is.EqualTo(v.x));
            Assert.That("((-6-8)3)", Is.EqualTo(v.y));
            Assert.That("((24)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-9-6)3)", "(-9-5)", "null", "(-9-5)");
            var v = ov.swizzle.yzyx;
            Assert.That("(-9-5)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-9-5)", Is.EqualTo(v.z));
            Assert.That("((-9-6)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "(3-3)", "(92)", "-1");
            var v = ov.swizzle.yzyy;
            Assert.That("(3-3)", Is.EqualTo(v.x));
            Assert.That("(92)", Is.EqualTo(v.y));
            Assert.That("(3-3)", Is.EqualTo(v.z));
            Assert.That("(3-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "(3-8)", "(-3-1)", "((53)4)");
            var v = ov.swizzle.yzyz;
            Assert.That("(3-8)", Is.EqualTo(v.x));
            Assert.That("(-3-1)", Is.EqualTo(v.y));
            Assert.That("(3-8)", Is.EqualTo(v.z));
            Assert.That("(-3-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "-7", "((-1-7)-9)", "");
            var v = ov.swizzle.yzyw;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-1-7)-9)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-9)", "(07)", "(07)", "(-9-9)");
            var v = ov.swizzle.yzz;
            Assert.That("(07)", Is.EqualTo(v.x));
            Assert.That("(07)", Is.EqualTo(v.y));
            Assert.That("(07)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "null", "null", "4");
            var v = ov.swizzle.yzzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-2)-3)", "", "(-54)", "");
            var v = ov.swizzle.yzzy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-54)", Is.EqualTo(v.y));
            Assert.That("(-54)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "(0-2)", "(99)", "(99)");
            var v = ov.swizzle.yzzz;
            Assert.That("(0-2)", Is.EqualTo(v.x));
            Assert.That("(99)", Is.EqualTo(v.y));
            Assert.That("(99)", Is.EqualTo(v.z));
            Assert.That("(99)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "8", "(27)", "null");
            var v = ov.swizzle.yzzw;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(27)", Is.EqualTo(v.y));
            Assert.That("(27)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "", "((3-6)-3)");
            var v = ov.swizzle.yzw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((3-6)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("8", "((-5-2)-5)", "8", "8");
            var v = ov.swizzle.yzwx;
            Assert.That("((-5-2)-5)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(89)", "", "4");
            var v = ov.swizzle.yzwy;
            Assert.That("(89)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(89)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "", "(00)");
            var v = ov.swizzle.yzwz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(00)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "((04)-1)", "((04)-1)", "((61)-6)");
            var v = ov.swizzle.yzww;
            Assert.That("((04)-1)", Is.EqualTo(v.x));
            Assert.That("((04)-1)", Is.EqualTo(v.y));
            Assert.That("((61)-6)", Is.EqualTo(v.z));
            Assert.That("((61)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(07)", "(07)", "(36)");
            var v = ov.swizzle.yw;
            Assert.That("(07)", Is.EqualTo(v.x));
            Assert.That("(36)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("null", "2", "-2", "((-5-2)7)");
            var v = ov.swizzle.ywx;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("((-5-2)7)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "null", "(9-2)", "(3-9)");
            var v = ov.swizzle.ywxx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(3-9)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "null", "", "(2-6)");
            var v = ov.swizzle.ywxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(2-6)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-4", "5", "-4");
            var v = ov.swizzle.ywxz;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-5)-1)", "null", "7", "(63)");
            var v = ov.swizzle.ywxw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(63)", Is.EqualTo(v.y));
            Assert.That("((-2-5)-1)", Is.EqualTo(v.z));
            Assert.That("(63)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "(-30)", "((24)-5)", "((-7-2)8)");
            var v = ov.swizzle.ywy;
            Assert.That("(-30)", Is.EqualTo(v.x));
            Assert.That("((-7-2)8)", Is.EqualTo(v.y));
            Assert.That("(-30)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-8", "((-72)1)", "((-58)-6)", "(-2-2)");
            var v = ov.swizzle.ywyx;
            Assert.That("((-72)1)", Is.EqualTo(v.x));
            Assert.That("(-2-2)", Is.EqualTo(v.y));
            Assert.That("((-72)1)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-1)", "((-7-9)8)", "(-9-1)", "(57)");
            var v = ov.swizzle.ywyy;
            Assert.That("((-7-9)8)", Is.EqualTo(v.x));
            Assert.That("(57)", Is.EqualTo(v.y));
            Assert.That("((-7-9)8)", Is.EqualTo(v.z));
            Assert.That("((-7-9)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(79)", "0", "((2-4)-7)");
            var v = ov.swizzle.ywyz;
            Assert.That("(79)", Is.EqualTo(v.x));
            Assert.That("((2-4)-7)", Is.EqualTo(v.y));
            Assert.That("(79)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-59)", "", "null", "((7-9)1)");
            var v = ov.swizzle.ywyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((7-9)1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((7-9)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "(78)", "2");
            var v = ov.swizzle.ywz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(78)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((1-8)-8)", "1", "(2-8)", "(2-8)");
            var v = ov.swizzle.ywzx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(2-8)", Is.EqualTo(v.y));
            Assert.That("(2-8)", Is.EqualTo(v.z));
            Assert.That("((1-8)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(90)", "((-35)-6)", "(-67)", "(90)");
            var v = ov.swizzle.ywzy;
            Assert.That("((-35)-6)", Is.EqualTo(v.x));
            Assert.That("(90)", Is.EqualTo(v.y));
            Assert.That("(-67)", Is.EqualTo(v.z));
            Assert.That("((-35)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-7)3)", "(-11)", "null", "null");
            var v = ov.swizzle.ywzz;
            Assert.That("(-11)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((8-1)-7)", "(3-6)", "((8-1)-7)");
            var v = ov.swizzle.ywzw;
            Assert.That("((8-1)-7)", Is.EqualTo(v.x));
            Assert.That("((8-1)-7)", Is.EqualTo(v.y));
            Assert.That("(3-6)", Is.EqualTo(v.z));
            Assert.That("((8-1)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((99)2)", "", "(26)", "((3-5)-7)");
            var v = ov.swizzle.yww;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((3-5)-7)", Is.EqualTo(v.y));
            Assert.That("((3-5)-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "", "((7-4)-2)", "null");
            var v = ov.swizzle.ywwx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-78)-2)", "(-85)", "");
            var v = ov.swizzle.ywwy;
            Assert.That("((-78)-2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-78)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-62)", "7", "((81)3)", "-7");
            var v = ov.swizzle.ywwz;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((81)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(81)", "", "null", "");
            var v = ov.swizzle.ywww;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-94)-2)", "((-3-4)-7)", "null", "");
            var v = ov.swizzle.zx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-94)-2)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-64)", "4", "(-64)", "(-4-2)");
            var v = ov.swizzle.zxx;
            Assert.That("(-64)", Is.EqualTo(v.x));
            Assert.That("(-64)", Is.EqualTo(v.y));
            Assert.That("(-64)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((61)4)", "null", "((-4-2)9)");
            var v = ov.swizzle.zxxx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "(-9-7)", "3", "");
            var v = ov.swizzle.zxxy;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("(-9-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "", "((-7-1)2)", "-6");
            var v = ov.swizzle.zxxz;
            Assert.That("((-7-1)2)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("((-7-1)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-5-3)-1)", "(6-8)", "");
            var v = ov.swizzle.zxxw;
            Assert.That("(6-8)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((-77)5)", "-1", "(33)");
            var v = ov.swizzle.zxy;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((-77)5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(-14)", "4", "(-23)");
            var v = ov.swizzle.zxyx;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-14)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "-9", "", "(-9-3)");
            var v = ov.swizzle.zxyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "2", "(-5-6)", "null");
            var v = ov.swizzle.zxyz;
            Assert.That("(-5-6)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("(-5-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((47)9)", "((47)9)", "((47)9)");
            var v = ov.swizzle.zxyw;
            Assert.That("((47)9)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((47)9)", Is.EqualTo(v.z));
            Assert.That("((47)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-4)7)", "((-7-7)-1)", "((3-4)7)", "-3");
            var v = ov.swizzle.zxz;
            Assert.That("((3-4)7)", Is.EqualTo(v.x));
            Assert.That("((3-4)7)", Is.EqualTo(v.y));
            Assert.That("((3-4)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "null", "(-42)", "((18)7)");
            var v = ov.swizzle.zxzx;
            Assert.That("(-42)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-42)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "2", "(07)", "2");
            var v = ov.swizzle.zxzy;
            Assert.That("(07)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(07)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-3)", "-5", "null", "-5");
            var v = ov.swizzle.zxzz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(5-3)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-7)7)", "", "(-41)", "null");
            var v = ov.swizzle.zxzw;
            Assert.That("(-41)", Is.EqualTo(v.x));
            Assert.That("((-3-7)7)", Is.EqualTo(v.y));
            Assert.That("(-41)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((6-5)9)", "(7-3)", "((22)0)", "");
            var v = ov.swizzle.zxw;
            Assert.That("((22)0)", Is.EqualTo(v.x));
            Assert.That("((6-5)9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "-1", "(-42)", "2");
            var v = ov.swizzle.zxwx;
            Assert.That("(-42)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-8)-4)", "((-19)7)", "4", "(30)");
            var v = ov.swizzle.zxwy;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((-2-8)-4)", Is.EqualTo(v.y));
            Assert.That("(30)", Is.EqualTo(v.z));
            Assert.That("((-19)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-30)", "2", "2", "null");
            var v = ov.swizzle.zxwz;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-30)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-2)", "5", "null", "null");
            var v = ov.swizzle.zxww;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(8-2)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "5", "(8-8)", "((57)6)");
            var v = ov.swizzle.zy;
            Assert.That("(8-8)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("8", "(03)", "((-4-9)3)", "");
            var v = ov.swizzle.zyx;
            Assert.That("((-4-9)3)", Is.EqualTo(v.x));
            Assert.That("(03)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "((33)-3)", "((-24)2)", "((-24)2)");
            var v = ov.swizzle.zyxx;
            Assert.That("((-24)2)", Is.EqualTo(v.x));
            Assert.That("((33)-3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "2", "-4", "((-66)-5)");
            var v = ov.swizzle.zyxy;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((3-6)-6)", "((3-6)-6)", "-2");
            var v = ov.swizzle.zyxz;
            Assert.That("((3-6)-6)", Is.EqualTo(v.x));
            Assert.That("((3-6)-6)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((3-6)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-84)-8)", "((2-9)-8)", "(-1-5)", "((-84)-8)");
            var v = ov.swizzle.zyxw;
            Assert.That("(-1-5)", Is.EqualTo(v.x));
            Assert.That("((2-9)-8)", Is.EqualTo(v.y));
            Assert.That("((-84)-8)", Is.EqualTo(v.z));
            Assert.That("((-84)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "(-58)", "", "7");
            var v = ov.swizzle.zyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-58)", Is.EqualTo(v.y));
            Assert.That("(-58)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(-37)", "(-37)", "-9");
            var v = ov.swizzle.zyyx;
            Assert.That("(-37)", Is.EqualTo(v.x));
            Assert.That("(-37)", Is.EqualTo(v.y));
            Assert.That("(-37)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-3)6)", "((-5-3)6)", "(-6-5)", "-2");
            var v = ov.swizzle.zyyy;
            Assert.That("(-6-5)", Is.EqualTo(v.x));
            Assert.That("((-5-3)6)", Is.EqualTo(v.y));
            Assert.That("((-5-3)6)", Is.EqualTo(v.z));
            Assert.That("((-5-3)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-6)", "-8", "null", "null");
            var v = ov.swizzle.zyyz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-7)", "null", "((-8-7)7)", "((-8-7)7)");
            var v = ov.swizzle.zyyw;
            Assert.That("((-8-7)7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-8-7)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(24)", "((8-6)-2)", "((8-6)-2)", "3");
            var v = ov.swizzle.zyz;
            Assert.That("((8-6)-2)", Is.EqualTo(v.x));
            Assert.That("((8-6)-2)", Is.EqualTo(v.y));
            Assert.That("((8-6)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-8", "-5", "null", "null");
            var v = ov.swizzle.zyzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-3)", "((-65)-6)", "((-3-4)-9)", "6");
            var v = ov.swizzle.zyzy;
            Assert.That("((-3-4)-9)", Is.EqualTo(v.x));
            Assert.That("((-65)-6)", Is.EqualTo(v.y));
            Assert.That("((-3-4)-9)", Is.EqualTo(v.z));
            Assert.That("((-65)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((01)-8)", "(0-5)", "((93)-7)");
            var v = ov.swizzle.zyzz;
            Assert.That("(0-5)", Is.EqualTo(v.x));
            Assert.That("((01)-8)", Is.EqualTo(v.y));
            Assert.That("(0-5)", Is.EqualTo(v.z));
            Assert.That("(0-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-11)", "(1-8)", "((5-5)8)", "8");
            var v = ov.swizzle.zyzw;
            Assert.That("((5-5)8)", Is.EqualTo(v.x));
            Assert.That("(1-8)", Is.EqualTo(v.y));
            Assert.That("((5-5)8)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "((63)-4)", "(-47)", "-9");
            var v = ov.swizzle.zyw;
            Assert.That("(-47)", Is.EqualTo(v.x));
            Assert.That("((63)-4)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "-1", "-1", "((-10)1)");
            var v = ov.swizzle.zywx;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((-10)1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "-6", "-6", "3");
            var v = ov.swizzle.zywy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-1)-4)", "(-5-3)", "(55)", "1");
            var v = ov.swizzle.zywz;
            Assert.That("(55)", Is.EqualTo(v.x));
            Assert.That("(-5-3)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("(55)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-3)", "-3", "((84)-4)", "-3");
            var v = ov.swizzle.zyww;
            Assert.That("((84)-4)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(39)", "-6", "((-72)8)", "(31)");
            var v = ov.swizzle.zz;
            Assert.That("((-72)8)", Is.EqualTo(v.x));
            Assert.That("((-72)8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(37)", "", "null", "((-9-7)-8)");
            var v = ov.swizzle.zzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(37)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-1", "((-94)-3)", "(9-8)", "null");
            var v = ov.swizzle.zzxx;
            Assert.That("(9-8)", Is.EqualTo(v.x));
            Assert.That("(9-8)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-34)", "-3", "-1", "((-1-5)-9)");
            var v = ov.swizzle.zzxy;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(-34)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-7)", "(-85)", "((5-5)5)", "((5-5)5)");
            var v = ov.swizzle.zzxz;
            Assert.That("((5-5)5)", Is.EqualTo(v.x));
            Assert.That("((5-5)5)", Is.EqualTo(v.y));
            Assert.That("(-8-7)", Is.EqualTo(v.z));
            Assert.That("((5-5)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "(3-3)", "((-6-6)-7)", "");
            var v = ov.swizzle.zzxw;
            Assert.That("((-6-6)-7)", Is.EqualTo(v.x));
            Assert.That("((-6-6)-7)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-80)7)", "(81)", "((-57)-9)");
            var v = ov.swizzle.zzy;
            Assert.That("(81)", Is.EqualTo(v.x));
            Assert.That("(81)", Is.EqualTo(v.y));
            Assert.That("((-80)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("9", "9", "(-18)", "((-46)-6)");
            var v = ov.swizzle.zzyx;
            Assert.That("(-18)", Is.EqualTo(v.x));
            Assert.That("(-18)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-15)", "((35)5)", "(-15)", "((35)5)");
            var v = ov.swizzle.zzyy;
            Assert.That("(-15)", Is.EqualTo(v.x));
            Assert.That("(-15)", Is.EqualTo(v.y));
            Assert.That("((35)5)", Is.EqualTo(v.z));
            Assert.That("((35)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "7", "(5-6)", "");
            var v = ov.swizzle.zzyz;
            Assert.That("(5-6)", Is.EqualTo(v.x));
            Assert.That("(5-6)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(5-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(3-3)", "((-87)-9)", "-9", "((9-4)9)");
            var v = ov.swizzle.zzyw;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((-87)-9)", Is.EqualTo(v.z));
            Assert.That("((9-4)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-32)", "5", "((26)-1)", "((75)-3)");
            var v = ov.swizzle.zzz;
            Assert.That("((26)-1)", Is.EqualTo(v.x));
            Assert.That("((26)-1)", Is.EqualTo(v.y));
            Assert.That("((26)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-5", "(0-1)", "-5", "((6-4)-2)");
            var v = ov.swizzle.zzzx;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-92)", "", "((98)-1)", "((-81)5)");
            var v = ov.swizzle.zzzy;
            Assert.That("((98)-1)", Is.EqualTo(v.x));
            Assert.That("((98)-1)", Is.EqualTo(v.y));
            Assert.That("((98)-1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(45)", "", "(6-5)", "(45)");
            var v = ov.swizzle.zzzz;
            Assert.That("(6-5)", Is.EqualTo(v.x));
            Assert.That("(6-5)", Is.EqualTo(v.y));
            Assert.That("(6-5)", Is.EqualTo(v.z));
            Assert.That("(6-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-2-7)4)", "(-88)", "9");
            var v = ov.swizzle.zzzw;
            Assert.That("(-88)", Is.EqualTo(v.x));
            Assert.That("(-88)", Is.EqualTo(v.y));
            Assert.That("(-88)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "-5", "((-6-1)7)", "");
            var v = ov.swizzle.zzw;
            Assert.That("((-6-1)7)", Is.EqualTo(v.x));
            Assert.That("((-6-1)7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-6", "(13)", "((08)-9)", "");
            var v = ov.swizzle.zzwx;
            Assert.That("((08)-9)", Is.EqualTo(v.x));
            Assert.That("((08)-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(16)", "-1", "((00)-1)", "");
            var v = ov.swizzle.zzwy;
            Assert.That("((00)-1)", Is.EqualTo(v.x));
            Assert.That("((00)-1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-4)", "(-5-4)", "4", "((37)3)");
            var v = ov.swizzle.zzwz;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((37)3)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "0", "(-2-3)", "((60)-8)");
            var v = ov.swizzle.zzww;
            Assert.That("(-2-3)", Is.EqualTo(v.x));
            Assert.That("(-2-3)", Is.EqualTo(v.y));
            Assert.That("((60)-8)", Is.EqualTo(v.z));
            Assert.That("((60)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((-5-3)8)", "5", "");
            var v = ov.swizzle.zw;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-9-6)3)", "", "((3-2)1)", "-5");
            var v = ov.swizzle.zwx;
            Assert.That("((3-2)1)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("((-9-6)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((5-1)1)", "((5-1)1)", "((5-1)1)", "2");
            var v = ov.swizzle.zwxx;
            Assert.That("((5-1)1)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((5-1)1)", Is.EqualTo(v.z));
            Assert.That("((5-1)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-60)", "", "-8", "null");
            var v = ov.swizzle.zwxy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-60)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(9-1)", "(9-1)", "-2");
            var v = ov.swizzle.zwxz;
            Assert.That("(9-1)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-5-9)", "-4", "4");
            var v = ov.swizzle.zwxw;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(18)", "4", "null");
            var v = ov.swizzle.zwy;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(18)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((00)8)", "((00)8)", "((00)8)", "-9");
            var v = ov.swizzle.zwyx;
            Assert.That("((00)8)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((00)8)", Is.EqualTo(v.z));
            Assert.That("((00)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-3)6)", "null", "", "");
            var v = ov.swizzle.zwyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(87)", "((-77)5)", "(87)", "(8-8)");
            var v = ov.swizzle.zwyz;
            Assert.That("(87)", Is.EqualTo(v.x));
            Assert.That("(8-8)", Is.EqualTo(v.y));
            Assert.That("((-77)5)", Is.EqualTo(v.z));
            Assert.That("(87)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-2)3)", "6", "-2", "((48)3)");
            var v = ov.swizzle.zwyw;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((48)3)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("((48)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-30)", "((92)0)", "(-4-4)", "5");
            var v = ov.swizzle.zwz;
            Assert.That("(-4-4)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(-4-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((80)-1)", "2", "((-3-4)4)", "-2");
            var v = ov.swizzle.zwzx;
            Assert.That("((-3-4)4)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((-3-4)4)", Is.EqualTo(v.z));
            Assert.That("((80)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-79)", "0", "0", "(-43)");
            var v = ov.swizzle.zwzy;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(-43)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(75)", "null", "-5");
            var v = ov.swizzle.zwzz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-7)", "((-2-9)-3)", "((8-5)-2)", "((79)6)");
            var v = ov.swizzle.zwzw;
            Assert.That("((8-5)-2)", Is.EqualTo(v.x));
            Assert.That("((79)6)", Is.EqualTo(v.y));
            Assert.That("((8-5)-2)", Is.EqualTo(v.z));
            Assert.That("((79)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(5-5)", "7", "0");
            var v = ov.swizzle.zww;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(95)", "(8-9)", "((-5-7)5)", "(95)");
            var v = ov.swizzle.zwwx;
            Assert.That("((-5-7)5)", Is.EqualTo(v.x));
            Assert.That("(95)", Is.EqualTo(v.y));
            Assert.That("(95)", Is.EqualTo(v.z));
            Assert.That("(95)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(75)", "(-84)", "((17)-8)");
            var v = ov.swizzle.zwwy;
            Assert.That("(-84)", Is.EqualTo(v.x));
            Assert.That("((17)-8)", Is.EqualTo(v.y));
            Assert.That("((17)-8)", Is.EqualTo(v.z));
            Assert.That("(75)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-8)-4)", "((-5-8)-4)", "((-5-8)-4)", "((-89)6)");
            var v = ov.swizzle.zwwz;
            Assert.That("((-5-8)-4)", Is.EqualTo(v.x));
            Assert.That("((-89)6)", Is.EqualTo(v.y));
            Assert.That("((-89)6)", Is.EqualTo(v.z));
            Assert.That("((-5-8)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((69)-6)", "(41)", "-2");
            var v = ov.swizzle.zwww;
            Assert.That("(41)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(70)", "((42)7)", "(-29)", "((42)7)");
            var v = ov.swizzle.wx;
            Assert.That("((42)7)", Is.EqualTo(v.x));
            Assert.That("(70)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-9-7)6)", "((4-4)3)", "(-84)", "8");
            var v = ov.swizzle.wxx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((-9-7)6)", Is.EqualTo(v.y));
            Assert.That("((-9-7)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(42)", "null", "(48)");
            var v = ov.swizzle.wxxx;
            Assert.That("(48)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-4)", "((-55)8)", "(95)", "((-24)-9)");
            var v = ov.swizzle.wxxy;
            Assert.That("((-24)-9)", Is.EqualTo(v.x));
            Assert.That("(1-4)", Is.EqualTo(v.y));
            Assert.That("(1-4)", Is.EqualTo(v.z));
            Assert.That("((-55)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "((0-5)-6)", "((0-5)-6)");
            var v = ov.swizzle.wxxz;
            Assert.That("((0-5)-6)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((0-5)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((02)8)", "((-94)-7)", "-3");
            var v = ov.swizzle.wxxw;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((48)9)", "null", "((-6-4)1)");
            var v = ov.swizzle.wxy;
            Assert.That("((-6-4)1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((48)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("1", "((5-4)9)", "", "(3-9)");
            var v = ov.swizzle.wxyx;
            Assert.That("(3-9)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("((5-4)9)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "-4", "(-9-8)", "((8-8)9)");
            var v = ov.swizzle.wxyy;
            Assert.That("((8-8)9)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "(-1-8)", "null", "7");
            var v = ov.swizzle.wxyz;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("(-1-8)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-3)", "3", "(-49)", "((-3-9)2)");
            var v = ov.swizzle.wxyw;
            Assert.That("((-3-9)2)", Is.EqualTo(v.x));
            Assert.That("(0-3)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("((-3-9)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-8)-8)", "9", "-6", "9");
            var v = ov.swizzle.wxz;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((2-8)-8)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-9-1)", "((-64)3)", "", "(2-5)");
            var v = ov.swizzle.wxzx;
            Assert.That("(2-5)", Is.EqualTo(v.x));
            Assert.That("(-9-1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(03)", "", "0", "1");
            var v = ov.swizzle.wxzy;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(03)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((05)-1)", "((-1-8)6)", "");
            var v = ov.swizzle.wxzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-1-8)6)", Is.EqualTo(v.z));
            Assert.That("((-1-8)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "2", "((00)-7)");
            var v = ov.swizzle.wxzw;
            Assert.That("((00)-7)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("((00)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-9", "(-3-2)", "");
            var v = ov.swizzle.wxw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((0-1)9)", "(-35)", "null", "((4-9)-4)");
            var v = ov.swizzle.wxwx;
            Assert.That("((4-9)-4)", Is.EqualTo(v.x));
            Assert.That("((0-1)9)", Is.EqualTo(v.y));
            Assert.That("((4-9)-4)", Is.EqualTo(v.z));
            Assert.That("((0-1)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "(-9-9)", "(9-7)", "((7-7)0)");
            var v = ov.swizzle.wxwy;
            Assert.That("((7-7)0)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((7-7)0)", Is.EqualTo(v.z));
            Assert.That("(-9-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(70)", "-5", "(31)", "(70)");
            var v = ov.swizzle.wxwz;
            Assert.That("(70)", Is.EqualTo(v.x));
            Assert.That("(70)", Is.EqualTo(v.y));
            Assert.That("(70)", Is.EqualTo(v.z));
            Assert.That("(31)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-86)", "null", "3");
            var v = ov.swizzle.wxww;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-5)", "", "(-80)", "((-42)-6)");
            var v = ov.swizzle.wy;
            Assert.That("((-42)-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("null", "-7", "((-3-2)-9)", "3");
            var v = ov.swizzle.wyx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-90)", "-1", "((29)-2)", "(-90)");
            var v = ov.swizzle.wyxx;
            Assert.That("(-90)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(-90)", Is.EqualTo(v.z));
            Assert.That("(-90)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "-4", "(78)", "((98)-7)");
            var v = ov.swizzle.wyxy;
            Assert.That("((98)-7)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(8-8)", "(-2-3)", "((-14)4)");
            var v = ov.swizzle.wyxz;
            Assert.That("((-14)4)", Is.EqualTo(v.x));
            Assert.That("(8-8)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-2-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(00)", "-8", "null", "((-70)0)");
            var v = ov.swizzle.wyxw;
            Assert.That("((-70)0)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(00)", Is.EqualTo(v.z));
            Assert.That("((-70)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((0-6)6)", "9", "-5");
            var v = ov.swizzle.wyy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("((0-6)6)", Is.EqualTo(v.y));
            Assert.That("((0-6)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-39)-5)", "((3-3)8)", "((-39)-5)", "((3-3)8)");
            var v = ov.swizzle.wyyx;
            Assert.That("((3-3)8)", Is.EqualTo(v.x));
            Assert.That("((3-3)8)", Is.EqualTo(v.y));
            Assert.That("((3-3)8)", Is.EqualTo(v.z));
            Assert.That("((-39)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-5)", "8", "(-18)", "3");
            var v = ov.swizzle.wyyy;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "(-42)", "", "-2");
            var v = ov.swizzle.wyyz;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("(-42)", Is.EqualTo(v.y));
            Assert.That("(-42)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-6)-3)", "", "", "");
            var v = ov.swizzle.wyyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "4", "((-42)-8)", "-4");
            var v = ov.swizzle.wyz;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((-42)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("7", "((-81)-6)", "null", "-4");
            var v = ov.swizzle.wyzx;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("((-81)-6)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "null", "-1", "");
            var v = ov.swizzle.wyzy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "null", "(-9-4)", "8");
            var v = ov.swizzle.wyzz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-9-4)", Is.EqualTo(v.z));
            Assert.That("(-9-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "(14)", "");
            var v = ov.swizzle.wyzw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(14)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-6)", "((-84)-3)", "null", "5");
            var v = ov.swizzle.wyw;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("((-84)-3)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(64)", "", "1");
            var v = ov.swizzle.wywx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(64)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(22)", "((08)0)", "((-31)1)", "1");
            var v = ov.swizzle.wywy;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((08)0)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("((08)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((31)-6)", "((-1-4)4)", "(2-5)");
            var v = ov.swizzle.wywz;
            Assert.That("(2-5)", Is.EqualTo(v.x));
            Assert.That("((31)-6)", Is.EqualTo(v.y));
            Assert.That("(2-5)", Is.EqualTo(v.z));
            Assert.That("((-1-4)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((97)-3)", "8", "(9-7)", "((34)-7)");
            var v = ov.swizzle.wyww;
            Assert.That("((34)-7)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("((34)-7)", Is.EqualTo(v.z));
            Assert.That("((34)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-91)-7)", "(43)", "(1-3)");
            var v = ov.swizzle.wz;
            Assert.That("(1-3)", Is.EqualTo(v.x));
            Assert.That("(43)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("3", "(-37)", "null", "(-84)");
            var v = ov.swizzle.wzx;
            Assert.That("(-84)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-46)", "(-46)", "((45)2)", "((-7-5)-8)");
            var v = ov.swizzle.wzxx;
            Assert.That("((-7-5)-8)", Is.EqualTo(v.x));
            Assert.That("((45)2)", Is.EqualTo(v.y));
            Assert.That("(-46)", Is.EqualTo(v.z));
            Assert.That("(-46)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-1)", "", "null", "6");
            var v = ov.swizzle.wzxy;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-3-1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "(-4-4)", "-1", "((01)-9)");
            var v = ov.swizzle.wzxz;
            Assert.That("((01)-9)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "", "(-8-2)", "");
            var v = ov.swizzle.wzxw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-8-2)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-52)", "-6", "(31)", "(31)");
            var v = ov.swizzle.wzy;
            Assert.That("(31)", Is.EqualTo(v.x));
            Assert.That("(31)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-4-2)1)", "-1", "-7", "-7");
            var v = ov.swizzle.wzyx;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("((-4-2)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(10)", "5", "(74)", "null");
            var v = ov.swizzle.wzyy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(74)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-71)-4)", "((-4-2)5)", "1");
            var v = ov.swizzle.wzyz;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((-4-2)5)", Is.EqualTo(v.y));
            Assert.That("((-71)-4)", Is.EqualTo(v.z));
            Assert.That("((-4-2)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-1)-7)", "((5-9)-3)", "null", "((7-5)2)");
            var v = ov.swizzle.wzyw;
            Assert.That("((7-5)2)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((5-9)-3)", Is.EqualTo(v.z));
            Assert.That("((7-5)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "2", "((-8-1)-8)");
            var v = ov.swizzle.wzz;
            Assert.That("((-8-1)-8)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("8", "((-42)-6)", "-3", "(00)");
            var v = ov.swizzle.wzzx;
            Assert.That("(00)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((-93)-2)", "((35)-7)", "(-28)");
            var v = ov.swizzle.wzzy;
            Assert.That("(-28)", Is.EqualTo(v.x));
            Assert.That("((35)-7)", Is.EqualTo(v.y));
            Assert.That("((35)-7)", Is.EqualTo(v.z));
            Assert.That("((-93)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "((01)-3)", "(3-1)", "-8");
            var v = ov.swizzle.wzzz;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(3-1)", Is.EqualTo(v.y));
            Assert.That("(3-1)", Is.EqualTo(v.z));
            Assert.That("(3-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-4)-4)", "2", "((64)-8)", "((64)-8)");
            var v = ov.swizzle.wzzw;
            Assert.That("((64)-8)", Is.EqualTo(v.x));
            Assert.That("((64)-8)", Is.EqualTo(v.y));
            Assert.That("((64)-8)", Is.EqualTo(v.z));
            Assert.That("((64)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-9)8)", "(-8-9)", "(-58)", "-3");
            var v = ov.swizzle.wzw;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(-58)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((0-8)-5)", "((0-8)-5)", "((65)-5)", "");
            var v = ov.swizzle.wzwx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((65)-5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((0-8)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((0-5)-2)", "(-54)", "(-4-2)");
            var v = ov.swizzle.wzwy;
            Assert.That("(-4-2)", Is.EqualTo(v.x));
            Assert.That("(-54)", Is.EqualTo(v.y));
            Assert.That("(-4-2)", Is.EqualTo(v.z));
            Assert.That("((0-5)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-3)", "((-8-9)1)", "7", "7");
            var v = ov.swizzle.wzwz;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "null", "null", "(-67)");
            var v = ov.swizzle.wzww;
            Assert.That("(-67)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-67)", Is.EqualTo(v.z));
            Assert.That("(-67)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-2)6)", "((-8-7)7)", "-8", "(7-9)");
            var v = ov.swizzle.ww;
            Assert.That("(7-9)", Is.EqualTo(v.x));
            Assert.That("(7-9)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("7", "((-6-1)1)", "", "(45)");
            var v = ov.swizzle.wwx;
            Assert.That("(45)", Is.EqualTo(v.x));
            Assert.That("(45)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "", "5", "");
            var v = ov.swizzle.wwxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "(-9-2)", "(08)", "(91)");
            var v = ov.swizzle.wwxy;
            Assert.That("(91)", Is.EqualTo(v.x));
            Assert.That("(91)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(-9-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "null", "(-4-7)", "((2-4)1)");
            var v = ov.swizzle.wwxz;
            Assert.That("((2-4)1)", Is.EqualTo(v.x));
            Assert.That("((2-4)1)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(-4-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "((7-1)6)", "", "(-6-7)");
            var v = ov.swizzle.wwxw;
            Assert.That("(-6-7)", Is.EqualTo(v.x));
            Assert.That("(-6-7)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(-6-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-5)-7)", "((-8-5)-7)", "", "-6");
            var v = ov.swizzle.wwy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("((-8-5)-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("9", "((04)-5)", "0", "((2-3)8)");
            var v = ov.swizzle.wwyx;
            Assert.That("((2-3)8)", Is.EqualTo(v.x));
            Assert.That("((2-3)8)", Is.EqualTo(v.y));
            Assert.That("((04)-5)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-2)-1)", "(-9-9)", "5", "(90)");
            var v = ov.swizzle.wwyy;
            Assert.That("(90)", Is.EqualTo(v.x));
            Assert.That("(90)", Is.EqualTo(v.y));
            Assert.That("(-9-9)", Is.EqualTo(v.z));
            Assert.That("(-9-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "(70)", "-4");
            var v = ov.swizzle.wwyz;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(70)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "6", "7", "((-83)-2)");
            var v = ov.swizzle.wwyw;
            Assert.That("((-83)-2)", Is.EqualTo(v.x));
            Assert.That("((-83)-2)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("((-83)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((-1-7)-6)", "(-4-1)", "null");
            var v = ov.swizzle.wwz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-4-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(61)", "-5", "", "-5");
            var v = ov.swizzle.wwzx;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(61)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "", "5", "5");
            var v = ov.swizzle.wwzy;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-8)-9)", "((-6-7)-7)", "(91)", "-4");
            var v = ov.swizzle.wwzz;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(91)", Is.EqualTo(v.z));
            Assert.That("(91)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-5)7)", "-4", "-7", "-4");
            var v = ov.swizzle.wwzw;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "6", "6", "-3");
            var v = ov.swizzle.www;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "", "(-27)", "-8");
            var v = ov.swizzle.wwwx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(-2-4)", "((9-7)0)", "2");
            var v = ov.swizzle.wwwy;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("(-2-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((-4-4)0)", "(-5-5)", "((6-8)6)");
            var v = ov.swizzle.wwwz;
            Assert.That("((6-8)6)", Is.EqualTo(v.x));
            Assert.That("((6-8)6)", Is.EqualTo(v.y));
            Assert.That("((6-8)6)", Is.EqualTo(v.z));
            Assert.That("(-5-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "", "((6-6)-9)");
            var v = ov.swizzle.wwww;
            Assert.That("((6-6)-9)", Is.EqualTo(v.x));
            Assert.That("((6-6)-9)", Is.EqualTo(v.y));
            Assert.That("((6-6)-9)", Is.EqualTo(v.z));
            Assert.That("((6-6)-9)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec4<string>("(27)", "1", "((4-9)-4)", "5");
            var v = ov.swizzle.rr;
            Assert.That("(27)", Is.EqualTo(v.x));
            Assert.That("(27)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("1", "null", "1", "(8-3)");
            var v = ov.swizzle.rrr;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-5-9)", "5", "(64)", "((6-9)-6)");
            var v = ov.swizzle.rrrr;
            Assert.That("(-5-9)", Is.EqualTo(v.x));
            Assert.That("(-5-9)", Is.EqualTo(v.y));
            Assert.That("(-5-9)", Is.EqualTo(v.z));
            Assert.That("(-5-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-4)", "(2-9)", "1", "((-31)-9)");
            var v = ov.swizzle.rrrg;
            Assert.That("(9-4)", Is.EqualTo(v.x));
            Assert.That("(9-4)", Is.EqualTo(v.y));
            Assert.That("(9-4)", Is.EqualTo(v.z));
            Assert.That("(2-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((86)0)", "((90)5)", "((90)5)", "5");
            var v = ov.swizzle.rrrb;
            Assert.That("((86)0)", Is.EqualTo(v.x));
            Assert.That("((86)0)", Is.EqualTo(v.y));
            Assert.That("((86)0)", Is.EqualTo(v.z));
            Assert.That("((90)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((44)0)", "-6", "((-12)-8)", "(-3-2)");
            var v = ov.swizzle.rrra;
            Assert.That("((44)0)", Is.EqualTo(v.x));
            Assert.That("((44)0)", Is.EqualTo(v.y));
            Assert.That("((44)0)", Is.EqualTo(v.z));
            Assert.That("(-3-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-4)", "null", "(-5-1)", "8");
            var v = ov.swizzle.rrg;
            Assert.That("(-6-4)", Is.EqualTo(v.x));
            Assert.That("(-6-4)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(90)", "((62)-9)", "(00)", "0");
            var v = ov.swizzle.rrgr;
            Assert.That("(90)", Is.EqualTo(v.x));
            Assert.That("(90)", Is.EqualTo(v.y));
            Assert.That("((62)-9)", Is.EqualTo(v.z));
            Assert.That("(90)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-4)2)", "((90)6)", "((3-4)2)", "null");
            var v = ov.swizzle.rrgg;
            Assert.That("((3-4)2)", Is.EqualTo(v.x));
            Assert.That("((3-4)2)", Is.EqualTo(v.y));
            Assert.That("((90)6)", Is.EqualTo(v.z));
            Assert.That("((90)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((98)-6)", "(-43)", "-3", "((9-7)-2)");
            var v = ov.swizzle.rrgb;
            Assert.That("((98)-6)", Is.EqualTo(v.x));
            Assert.That("((98)-6)", Is.EqualTo(v.y));
            Assert.That("(-43)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-9", "((4-8)2)", "0");
            var v = ov.swizzle.rrga;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-1)7)", "null", "null", "2");
            var v = ov.swizzle.rrb;
            Assert.That("((-3-1)7)", Is.EqualTo(v.x));
            Assert.That("((-3-1)7)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-85)", "(-85)", "-1", "(76)");
            var v = ov.swizzle.rrbr;
            Assert.That("(-85)", Is.EqualTo(v.x));
            Assert.That("(-85)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("(-85)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((62)4)", "(-18)", "(-18)", "(-5-9)");
            var v = ov.swizzle.rrbg;
            Assert.That("((62)4)", Is.EqualTo(v.x));
            Assert.That("((62)4)", Is.EqualTo(v.y));
            Assert.That("(-18)", Is.EqualTo(v.z));
            Assert.That("(-18)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-40)", "(-40)", "(-4-5)", "((-45)-8)");
            var v = ov.swizzle.rrbb;
            Assert.That("(-40)", Is.EqualTo(v.x));
            Assert.That("(-40)", Is.EqualTo(v.y));
            Assert.That("(-4-5)", Is.EqualTo(v.z));
            Assert.That("(-4-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "((-5-3)6)", "(-2-4)", "((-5-3)6)");
            var v = ov.swizzle.rrba;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(-2-4)", Is.EqualTo(v.z));
            Assert.That("((-5-3)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "", "null", "((53)-9)");
            var v = ov.swizzle.rra;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("((53)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((72)4)", "((32)6)", "-8", "(89)");
            var v = ov.swizzle.rrar;
            Assert.That("((72)4)", Is.EqualTo(v.x));
            Assert.That("((72)4)", Is.EqualTo(v.y));
            Assert.That("(89)", Is.EqualTo(v.z));
            Assert.That("((72)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "", "");
            var v = ov.swizzle.rrag;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-61)", "-1", "9", "-2");
            var v = ov.swizzle.rrab;
            Assert.That("(-61)", Is.EqualTo(v.x));
            Assert.That("(-61)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "((8-3)3)", "", "null");
            var v = ov.swizzle.rraa;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "((-6-6)7)", "-6", "5");
            var v = ov.swizzle.rg;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((-6-6)7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(75)", "", "6", "null");
            var v = ov.swizzle.rgr;
            Assert.That("(75)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(75)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-54)-7)", "(4-6)", "(4-6)", "5");
            var v = ov.swizzle.rgrr;
            Assert.That("((-54)-7)", Is.EqualTo(v.x));
            Assert.That("(4-6)", Is.EqualTo(v.y));
            Assert.That("((-54)-7)", Is.EqualTo(v.z));
            Assert.That("((-54)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-48)", "2", "3", "(-48)");
            var v = ov.swizzle.rgrg;
            Assert.That("(-48)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(-48)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-1)", "-3", "(-80)", "((7-3)0)");
            var v = ov.swizzle.rgrb;
            Assert.That("(2-1)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(2-1)", Is.EqualTo(v.z));
            Assert.That("(-80)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "(-3-8)", "((1-3)-4)", "(-72)");
            var v = ov.swizzle.rgra;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(-3-8)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("(-72)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "((-1-3)-2)", "((-6-9)-9)", "9");
            var v = ov.swizzle.rgg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((-1-3)-2)", Is.EqualTo(v.y));
            Assert.That("((-1-3)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("8", "4", "9", "((9-1)-1)");
            var v = ov.swizzle.rggr;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "3", "-3", "");
            var v = ov.swizzle.rggg;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-1)7)", "6", "(-16)", "6");
            var v = ov.swizzle.rggb;
            Assert.That("((-3-1)7)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("(-16)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-2-9)", "(-2-9)", "((0-1)5)");
            var v = ov.swizzle.rgga;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-2-9)", Is.EqualTo(v.y));
            Assert.That("(-2-9)", Is.EqualTo(v.z));
            Assert.That("((0-1)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-8)1)", "-2", "((-14)1)", "-2");
            var v = ov.swizzle.rgb;
            Assert.That("((5-8)1)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((-14)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-22)", "((-5-3)-1)", "-9", "(-22)");
            var v = ov.swizzle.rgbr;
            Assert.That("(-22)", Is.EqualTo(v.x));
            Assert.That("((-5-3)-1)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("(-22)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((05)7)", "((55)1)", "-7");
            var v = ov.swizzle.rgbg;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((05)7)", Is.EqualTo(v.y));
            Assert.That("((55)1)", Is.EqualTo(v.z));
            Assert.That("((05)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-4", "(-44)", "((9-2)7)");
            var v = ov.swizzle.rgbb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(-44)", Is.EqualTo(v.z));
            Assert.That("(-44)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((03)-2)", "(4-1)", "null");
            var v = ov.swizzle.rgba;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((03)-2)", Is.EqualTo(v.y));
            Assert.That("(4-1)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-56)2)", "((-56)2)", "-7", "((-56)2)");
            var v = ov.swizzle.rga;
            Assert.That("((-56)2)", Is.EqualTo(v.x));
            Assert.That("((-56)2)", Is.EqualTo(v.y));
            Assert.That("((-56)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(2-6)", "(2-6)", "((-1-5)9)", "null");
            var v = ov.swizzle.rgar;
            Assert.That("(2-6)", Is.EqualTo(v.x));
            Assert.That("(2-6)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(2-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-3)4)", "((8-6)8)", "((-56)-9)", "((8-6)8)");
            var v = ov.swizzle.rgag;
            Assert.That("((8-3)4)", Is.EqualTo(v.x));
            Assert.That("((8-6)8)", Is.EqualTo(v.y));
            Assert.That("((8-6)8)", Is.EqualTo(v.z));
            Assert.That("((8-6)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(08)", "((-90)-1)", "");
            var v = ov.swizzle.rgab;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(08)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-90)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-9)0)", "null", "((1-9)0)", "(-1-9)");
            var v = ov.swizzle.rgaa;
            Assert.That("((1-9)0)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-1-9)", Is.EqualTo(v.z));
            Assert.That("(-1-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-86)0)", "(73)", "", "(17)");
            var v = ov.swizzle.rb;
            Assert.That("((-86)0)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("9", "6", "(-58)", "((1-4)-6)");
            var v = ov.swizzle.rbr;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(-58)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((-58)3)", "((-6-4)2)", "((-58)3)");
            var v = ov.swizzle.rbrr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-6-4)2)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(-43)", "null", "(-43)");
            var v = ov.swizzle.rbrg;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("(-43)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((-56)6)", "((33)5)", "");
            var v = ov.swizzle.rbrb;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("((33)5)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("((33)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "", "", "(-7-3)");
            var v = ov.swizzle.rbra;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("(-7-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-98)", "(86)", "-6", "((62)-7)");
            var v = ov.swizzle.rbg;
            Assert.That("(-98)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(86)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "7", "-7", "(42)");
            var v = ov.swizzle.rbgr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(95)", "((-22)-7)", "(95)", "-2");
            var v = ov.swizzle.rbgg;
            Assert.That("(95)", Is.EqualTo(v.x));
            Assert.That("(95)", Is.EqualTo(v.y));
            Assert.That("((-22)-7)", Is.EqualTo(v.z));
            Assert.That("((-22)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((79)7)", "((79)7)", "((79)7)", "(95)");
            var v = ov.swizzle.rbgb;
            Assert.That("((79)7)", Is.EqualTo(v.x));
            Assert.That("((79)7)", Is.EqualTo(v.y));
            Assert.That("((79)7)", Is.EqualTo(v.z));
            Assert.That("((79)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(-77)", "", "(-77)");
            var v = ov.swizzle.rbga;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-77)", Is.EqualTo(v.z));
            Assert.That("(-77)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-35)-6)", "-2", "((-35)-6)", "null");
            var v = ov.swizzle.rbb;
            Assert.That("((-35)-6)", Is.EqualTo(v.x));
            Assert.That("((-35)-6)", Is.EqualTo(v.y));
            Assert.That("((-35)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((9-9)-8)", "((9-9)-8)", "", "null");
            var v = ov.swizzle.rbbr;
            Assert.That("((9-9)-8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((9-9)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-20)", "", "1");
            var v = ov.swizzle.rbbg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-20)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-6-2)4)", "(-19)", "(81)");
            var v = ov.swizzle.rbbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-19)", Is.EqualTo(v.y));
            Assert.That("(-19)", Is.EqualTo(v.z));
            Assert.That("(-19)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-1)", "((-7-8)-7)", "-7", "((4-9)-8)");
            var v = ov.swizzle.rbba;
            Assert.That("(-8-1)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((4-9)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(82)", "((-7-9)7)", "((-8-1)9)", "null");
            var v = ov.swizzle.rba;
            Assert.That("(82)", Is.EqualTo(v.x));
            Assert.That("((-8-1)9)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-58)", "((-75)8)", "((31)-3)", "7");
            var v = ov.swizzle.rbar;
            Assert.That("(-58)", Is.EqualTo(v.x));
            Assert.That("((31)-3)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(-58)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "(-95)", "(-62)", "");
            var v = ov.swizzle.rbag;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(-62)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-95)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-9)", "(-6-7)", "null", "((-9-3)-2)");
            var v = ov.swizzle.rbab;
            Assert.That("(9-9)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-9-3)-2)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-42)", "null", "((-6-1)8)", "((8-2)-4)");
            var v = ov.swizzle.rbaa;
            Assert.That("(-42)", Is.EqualTo(v.x));
            Assert.That("((-6-1)8)", Is.EqualTo(v.y));
            Assert.That("((8-2)-4)", Is.EqualTo(v.z));
            Assert.That("((8-2)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-69)-5)", "2", "(23)", "-1");
            var v = ov.swizzle.ra;
            Assert.That("((-69)-5)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("", "((-55)-9)", "-9", "-3");
            var v = ov.swizzle.rar;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("7", "(39)", "((-72)5)", "((5-3)7)");
            var v = ov.swizzle.rarr;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((5-3)7)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-4)8)", "3", "((0-7)7)", "((0-7)7)");
            var v = ov.swizzle.rarg;
            Assert.That("((-9-4)8)", Is.EqualTo(v.x));
            Assert.That("((0-7)7)", Is.EqualTo(v.y));
            Assert.That("((-9-4)8)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-5)3)", "", "(-4-3)", "");
            var v = ov.swizzle.rarb;
            Assert.That("((5-5)3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((5-5)3)", Is.EqualTo(v.z));
            Assert.That("(-4-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-7", "(07)", "-7");
            var v = ov.swizzle.rara;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(76)", "2", "2", "((8-5)-2)");
            var v = ov.swizzle.rag;
            Assert.That("(76)", Is.EqualTo(v.x));
            Assert.That("((8-5)-2)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-7", "((8-7)-6)", "(-6-9)", "-7");
            var v = ov.swizzle.ragr;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((8-7)-6)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-46)6)", "((8-9)-1)", "(86)", "((8-9)-1)");
            var v = ov.swizzle.ragg;
            Assert.That("((-46)6)", Is.EqualTo(v.x));
            Assert.That("((8-9)-1)", Is.EqualTo(v.y));
            Assert.That("((8-9)-1)", Is.EqualTo(v.z));
            Assert.That("((8-9)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((49)-4)", "9", "((49)-4)", "((-2-3)0)");
            var v = ov.swizzle.ragb;
            Assert.That("((49)-4)", Is.EqualTo(v.x));
            Assert.That("((-2-3)0)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("((49)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "null", "(03)", "(03)");
            var v = ov.swizzle.raga;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(03)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(03)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "", "8", "(01)");
            var v = ov.swizzle.rab;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("(01)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-3", "0", "null", "((-50)-5)");
            var v = ov.swizzle.rabr;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("((-50)-5)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-61)-8)", "4", "(3-7)", "(12)");
            var v = ov.swizzle.rabg;
            Assert.That("((-61)-8)", Is.EqualTo(v.x));
            Assert.That("(12)", Is.EqualTo(v.y));
            Assert.That("(3-7)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-2", "null", "-2");
            var v = ov.swizzle.rabb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-6)", "((-9-7)-6)", "((20)2)", "4");
            var v = ov.swizzle.raba;
            Assert.That("(-5-6)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((20)2)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "6", "6");
            var v = ov.swizzle.raa;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((10)0)", "(69)", "((-2-6)2)", "null");
            var v = ov.swizzle.raar;
            Assert.That("((10)0)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((10)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "9", "(-56)", "-9");
            var v = ov.swizzle.raag;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "((-7-6)1)", "-9", "null");
            var v = ov.swizzle.raab;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(25)", "null", "", "((-78)-5)");
            var v = ov.swizzle.raaa;
            Assert.That("(25)", Is.EqualTo(v.x));
            Assert.That("((-78)-5)", Is.EqualTo(v.y));
            Assert.That("((-78)-5)", Is.EqualTo(v.z));
            Assert.That("((-78)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "3", "null", "((-91)-8)");
            var v = ov.swizzle.gr;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-1-3)7)", "((68)0)", "((-1-3)7)", "(11)");
            var v = ov.swizzle.grr;
            Assert.That("((68)0)", Is.EqualTo(v.x));
            Assert.That("((-1-3)7)", Is.EqualTo(v.y));
            Assert.That("((-1-3)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-96)2)", "-7", "-9", "((-2-3)-7)");
            var v = ov.swizzle.grrr;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-96)2)", Is.EqualTo(v.y));
            Assert.That("((-96)2)", Is.EqualTo(v.z));
            Assert.That("((-96)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "((-30)-2)", "(8-6)", "(8-6)");
            var v = ov.swizzle.grrg;
            Assert.That("((-30)-2)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("((-30)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-67)", "8", "null", "null");
            var v = ov.swizzle.grrb;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(-67)", Is.EqualTo(v.y));
            Assert.That("(-67)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-29)", "0", "-6", "((-53)4)");
            var v = ov.swizzle.grra;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(-29)", Is.EqualTo(v.y));
            Assert.That("(-29)", Is.EqualTo(v.z));
            Assert.That("((-53)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(51)", "(3-9)", "", "null");
            var v = ov.swizzle.grg;
            Assert.That("(3-9)", Is.EqualTo(v.x));
            Assert.That("(51)", Is.EqualTo(v.y));
            Assert.That("(3-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "-5", "((5-6)8)", "(-41)");
            var v = ov.swizzle.grgr;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "((79)-6)", "((-2-6)-7)");
            var v = ov.swizzle.grgg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-9)", "(9-9)", "", "((-2-6)-9)");
            var v = ov.swizzle.grgb;
            Assert.That("(9-9)", Is.EqualTo(v.x));
            Assert.That("(9-9)", Is.EqualTo(v.y));
            Assert.That("(9-9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(51)", "(51)", "-9", "(00)");
            var v = ov.swizzle.grga;
            Assert.That("(51)", Is.EqualTo(v.x));
            Assert.That("(51)", Is.EqualTo(v.y));
            Assert.That("(51)", Is.EqualTo(v.z));
            Assert.That("(00)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-74)", "((2-2)-7)", "-8", "((-2-6)4)");
            var v = ov.swizzle.grb;
            Assert.That("((2-2)-7)", Is.EqualTo(v.x));
            Assert.That("(-74)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((00)2)", "-1", "((00)2)", "(-3-1)");
            var v = ov.swizzle.grbr;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((00)2)", Is.EqualTo(v.y));
            Assert.That("((00)2)", Is.EqualTo(v.z));
            Assert.That("((00)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(85)", "0", "((95)8)", "(-40)");
            var v = ov.swizzle.grbg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(85)", Is.EqualTo(v.y));
            Assert.That("((95)8)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-14)4)", "-9", "(1-5)", "(1-5)");
            var v = ov.swizzle.grbb;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((-14)4)", Is.EqualTo(v.y));
            Assert.That("(1-5)", Is.EqualTo(v.z));
            Assert.That("(1-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-7)7)", "((71)-6)", "((71)-6)", "((-7-7)-2)");
            var v = ov.swizzle.grba;
            Assert.That("((71)-6)", Is.EqualTo(v.x));
            Assert.That("((-8-7)7)", Is.EqualTo(v.y));
            Assert.That("((71)-6)", Is.EqualTo(v.z));
            Assert.That("((-7-7)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-1)6)", "8", "(-5-3)", "(1-3)");
            var v = ov.swizzle.gra;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((-6-1)6)", Is.EqualTo(v.y));
            Assert.That("(1-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-1", "((54)2)", "null", "7");
            var v = ov.swizzle.grar;
            Assert.That("((54)2)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "(13)", "((21)2)", "null");
            var v = ov.swizzle.grag;
            Assert.That("(13)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(13)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(94)", "((-7-6)6)", "2");
            var v = ov.swizzle.grab;
            Assert.That("(94)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("((-7-6)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((3-1)6)", "((3-1)6)", "null");
            var v = ov.swizzle.graa;
            Assert.That("((3-1)6)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "(81)", "(-6-8)", "");
            var v = ov.swizzle.gg;
            Assert.That("(81)", Is.EqualTo(v.x));
            Assert.That("(81)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-1", "((61)3)", "null", "-3");
            var v = ov.swizzle.ggr;
            Assert.That("((61)3)", Is.EqualTo(v.x));
            Assert.That("((61)3)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(06)", "4", "null", "-7");
            var v = ov.swizzle.ggrr;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("(06)", Is.EqualTo(v.z));
            Assert.That("(06)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(15)", "8", "((82)7)", "null");
            var v = ov.swizzle.ggrg;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(15)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "-8", "");
            var v = ov.swizzle.ggrb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((97)2)", "(93)", "((-67)7)", "((97)2)");
            var v = ov.swizzle.ggra;
            Assert.That("(93)", Is.EqualTo(v.x));
            Assert.That("(93)", Is.EqualTo(v.y));
            Assert.That("((97)2)", Is.EqualTo(v.z));
            Assert.That("((97)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-18)6)", "((-3-5)8)", "(27)");
            var v = ov.swizzle.ggg;
            Assert.That("((-18)6)", Is.EqualTo(v.x));
            Assert.That("((-18)6)", Is.EqualTo(v.y));
            Assert.That("((-18)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((-38)5)", "((-38)5)", "null");
            var v = ov.swizzle.gggr;
            Assert.That("((-38)5)", Is.EqualTo(v.x));
            Assert.That("((-38)5)", Is.EqualTo(v.y));
            Assert.That("((-38)5)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-37)-8)", "", "(18)", "-1");
            var v = ov.swizzle.gggg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-51)", "(6-8)", "7", "((-3-4)-8)");
            var v = ov.swizzle.gggb;
            Assert.That("(6-8)", Is.EqualTo(v.x));
            Assert.That("(6-8)", Is.EqualTo(v.y));
            Assert.That("(6-8)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "(-39)", "((-72)-3)");
            var v = ov.swizzle.ggga;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-72)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-6-8)", "((-2-3)5)", "4");
            var v = ov.swizzle.ggb;
            Assert.That("(-6-8)", Is.EqualTo(v.x));
            Assert.That("(-6-8)", Is.EqualTo(v.y));
            Assert.That("((-2-3)5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(34)", "((11)3)", "((1-7)-7)", "7");
            var v = ov.swizzle.ggbr;
            Assert.That("((11)3)", Is.EqualTo(v.x));
            Assert.That("((11)3)", Is.EqualTo(v.y));
            Assert.That("((1-7)-7)", Is.EqualTo(v.z));
            Assert.That("(34)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(60)", "((-3-3)-5)", "((-3-3)-5)", "((-7-5)0)");
            var v = ov.swizzle.ggbg;
            Assert.That("((-3-3)-5)", Is.EqualTo(v.x));
            Assert.That("((-3-3)-5)", Is.EqualTo(v.y));
            Assert.That("((-3-3)-5)", Is.EqualTo(v.z));
            Assert.That("((-3-3)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-8", "null", "(-1-8)");
            var v = ov.swizzle.ggbb;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "(-7-1)", "null", "((-88)-8)");
            var v = ov.swizzle.ggba;
            Assert.That("(-7-1)", Is.EqualTo(v.x));
            Assert.That("(-7-1)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-88)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-74)", "", "((72)-4)", "((9-8)6)");
            var v = ov.swizzle.gga;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((9-8)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((8-3)-2)", "(92)", "(-49)", "3");
            var v = ov.swizzle.ggar;
            Assert.That("(92)", Is.EqualTo(v.x));
            Assert.That("(92)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("((8-3)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-1", "((8-4)-8)", "((-8-4)0)");
            var v = ov.swizzle.ggag;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((-8-4)0)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-7)8)", "", "-9", "(-44)");
            var v = ov.swizzle.ggab;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-44)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "8", "8", "((-26)9)");
            var v = ov.swizzle.ggaa;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("((-26)9)", Is.EqualTo(v.z));
            Assert.That("((-26)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "9", "((-33)-9)", "(-5-2)");
            var v = ov.swizzle.gb;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((-33)-9)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-71)-2)", "(-78)", "(7-3)", "(07)");
            var v = ov.swizzle.gbr;
            Assert.That("(-78)", Is.EqualTo(v.x));
            Assert.That("(7-3)", Is.EqualTo(v.y));
            Assert.That("((-71)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((6-8)8)", "9", "4", "7");
            var v = ov.swizzle.gbrr;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((6-8)8)", Is.EqualTo(v.z));
            Assert.That("((6-8)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "(9-6)", "null", "9");
            var v = ov.swizzle.gbrg;
            Assert.That("(9-6)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("(9-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "(8-7)", "null", "6");
            var v = ov.swizzle.gbrb;
            Assert.That("(8-7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-49)-5)", "(56)", "3", "((10)0)");
            var v = ov.swizzle.gbra;
            Assert.That("(56)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((-49)-5)", Is.EqualTo(v.z));
            Assert.That("((10)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "(-86)", "((-48)-9)", "-8");
            var v = ov.swizzle.gbg;
            Assert.That("(-86)", Is.EqualTo(v.x));
            Assert.That("((-48)-9)", Is.EqualTo(v.y));
            Assert.That("(-86)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(5-1)", "", "(9-1)", "-5");
            var v = ov.swizzle.gbgr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(9-1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(5-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "6", "6", "((-31)6)");
            var v = ov.swizzle.gbgg;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((81)8)", "((-43)0)", "((81)8)", "5");
            var v = ov.swizzle.gbgb;
            Assert.That("((-43)0)", Is.EqualTo(v.x));
            Assert.That("((81)8)", Is.EqualTo(v.y));
            Assert.That("((-43)0)", Is.EqualTo(v.z));
            Assert.That("((81)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-8)", "((9-4)-6)", "(2-8)", "");
            var v = ov.swizzle.gbga;
            Assert.That("((9-4)-6)", Is.EqualTo(v.x));
            Assert.That("(2-8)", Is.EqualTo(v.y));
            Assert.That("((9-4)-6)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "(-5-8)", "(3-5)", "9");
            var v = ov.swizzle.gbb;
            Assert.That("(-5-8)", Is.EqualTo(v.x));
            Assert.That("(3-5)", Is.EqualTo(v.y));
            Assert.That("(3-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((36)-3)", "-5", "(61)", "(93)");
            var v = ov.swizzle.gbbr;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("(61)", Is.EqualTo(v.y));
            Assert.That("(61)", Is.EqualTo(v.z));
            Assert.That("((36)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "(18)", "(-9-5)", "5");
            var v = ov.swizzle.gbbg;
            Assert.That("(18)", Is.EqualTo(v.x));
            Assert.That("(-9-5)", Is.EqualTo(v.y));
            Assert.That("(-9-5)", Is.EqualTo(v.z));
            Assert.That("(18)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(47)", "((81)-1)", "3", "");
            var v = ov.swizzle.gbbb;
            Assert.That("((81)-1)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(7-4)", "(-5-4)", "(7-4)");
            var v = ov.swizzle.gbba;
            Assert.That("(7-4)", Is.EqualTo(v.x));
            Assert.That("(-5-4)", Is.EqualTo(v.y));
            Assert.That("(-5-4)", Is.EqualTo(v.z));
            Assert.That("(7-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-6", "((9-4)-9)", "");
            var v = ov.swizzle.gba;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((9-4)-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-3-5)4)", "-6", "(2-3)", "-6");
            var v = ov.swizzle.gbar;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("(2-3)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((-3-5)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "-2", "((-6-9)5)", "(6-8)");
            var v = ov.swizzle.gbag;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((-6-9)5)", Is.EqualTo(v.y));
            Assert.That("(6-8)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((3-7)-3)", "(-26)", "(21)");
            var v = ov.swizzle.gbab;
            Assert.That("((3-7)-3)", Is.EqualTo(v.x));
            Assert.That("(-26)", Is.EqualTo(v.y));
            Assert.That("(21)", Is.EqualTo(v.z));
            Assert.That("(-26)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-7)", "((58)-8)", "((15)5)", "((12)-5)");
            var v = ov.swizzle.gbaa;
            Assert.That("((58)-8)", Is.EqualTo(v.x));
            Assert.That("((15)5)", Is.EqualTo(v.y));
            Assert.That("((12)-5)", Is.EqualTo(v.z));
            Assert.That("((12)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "(-58)", "(-58)", "1");
            var v = ov.swizzle.ga;
            Assert.That("(-58)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-84)0)", "(5-9)", "(-77)", "-9");
            var v = ov.swizzle.gar;
            Assert.That("(5-9)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((-84)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("4", "(37)", "((19)-3)", "((-23)7)");
            var v = ov.swizzle.garr;
            Assert.That("(37)", Is.EqualTo(v.x));
            Assert.That("((-23)7)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-84)", "-9", "(7-4)", "-8");
            var v = ov.swizzle.garg;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(-84)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "7", "(56)", "");
            var v = ov.swizzle.garb;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("(56)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "-1", "-7", "");
            var v = ov.swizzle.gara;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-7-2)-3)", "((43)7)", "((43)7)");
            var v = ov.swizzle.gag;
            Assert.That("((-7-2)-3)", Is.EqualTo(v.x));
            Assert.That("((43)7)", Is.EqualTo(v.y));
            Assert.That("((-7-2)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((-2-2)8)", "-9", "-4");
            var v = ov.swizzle.gagr;
            Assert.That("((-2-2)8)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((-2-2)8)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "((-91)2)", "((-91)2)");
            var v = ov.swizzle.gagg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-91)2)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "-1", "4", "-1");
            var v = ov.swizzle.gagb;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((87)8)", "(-81)", "", "(-30)");
            var v = ov.swizzle.gaga;
            Assert.That("(-81)", Is.EqualTo(v.x));
            Assert.That("(-30)", Is.EqualTo(v.y));
            Assert.That("(-81)", Is.EqualTo(v.z));
            Assert.That("(-30)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-25)", "-8", "(-25)", "5");
            var v = ov.swizzle.gab;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(-25)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(5-7)", "", "(34)", "-6");
            var v = ov.swizzle.gabr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(34)", Is.EqualTo(v.z));
            Assert.That("(5-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "((-41)-8)", "7", "(-2-5)");
            var v = ov.swizzle.gabg;
            Assert.That("((-41)-8)", Is.EqualTo(v.x));
            Assert.That("(-2-5)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((-41)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-12)", "null", "-8", "(-12)");
            var v = ov.swizzle.gabb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-12)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-53)9)", "-9", "", "(3-7)");
            var v = ov.swizzle.gaba;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("(3-7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(3-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(00)", "0", "(-72)", "-1");
            var v = ov.swizzle.gaa;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-42)3)", "((-24)0)", "0", "(27)");
            var v = ov.swizzle.gaar;
            Assert.That("((-24)0)", Is.EqualTo(v.x));
            Assert.That("(27)", Is.EqualTo(v.y));
            Assert.That("(27)", Is.EqualTo(v.z));
            Assert.That("((-42)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-2)", "(-7-2)", "", "null");
            var v = ov.swizzle.gaag;
            Assert.That("(-7-2)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-7-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "((-8-1)-4)", "(69)", "4");
            var v = ov.swizzle.gaab;
            Assert.That("((-8-1)-4)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(69)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "7", "null");
            var v = ov.swizzle.gaaa;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(60)", "", "(6-9)", "-3");
            var v = ov.swizzle.br;
            Assert.That("(6-9)", Is.EqualTo(v.x));
            Assert.That("(60)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-27)", "((4-5)4)", "9", "((4-5)4)");
            var v = ov.swizzle.brr;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(-27)", Is.EqualTo(v.y));
            Assert.That("(-27)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(7-5)", "((-25)-9)", "-8");
            var v = ov.swizzle.brrr;
            Assert.That("((-25)-9)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "6", "");
            var v = ov.swizzle.brrg;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "(65)", "((71)-6)");
            var v = ov.swizzle.brrb;
            Assert.That("(65)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(65)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "((-47)5)", "-3", "(-96)");
            var v = ov.swizzle.brra;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("(-96)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((65)1)", "((08)1)", "(41)", "(83)");
            var v = ov.swizzle.brg;
            Assert.That("(41)", Is.EqualTo(v.x));
            Assert.That("((65)1)", Is.EqualTo(v.y));
            Assert.That("((08)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("8", "(-99)", "(4-5)", "((88)-3)");
            var v = ov.swizzle.brgr;
            Assert.That("(4-5)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-99)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-97)", "(2-3)", "2", "(-97)");
            var v = ov.swizzle.brgg;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-97)", Is.EqualTo(v.y));
            Assert.That("(2-3)", Is.EqualTo(v.z));
            Assert.That("(2-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-94)-9)", "8", "8", "(-5-4)");
            var v = ov.swizzle.brgb;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((-94)-9)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((45)-3)", "((45)-3)", "", "-7");
            var v = ov.swizzle.brga;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((45)-3)", Is.EqualTo(v.y));
            Assert.That("((45)-3)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-54)", "8", "8");
            var v = ov.swizzle.brb;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((5-4)-7)", "((1-4)6)", "null", "-8");
            var v = ov.swizzle.brbr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((5-4)-7)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((5-4)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-8)", "null", "((9-4)9)", "((20)-1)");
            var v = ov.swizzle.brbg;
            Assert.That("((9-4)9)", Is.EqualTo(v.x));
            Assert.That("(-4-8)", Is.EqualTo(v.y));
            Assert.That("((9-4)9)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((49)4)", "1", "1", "1");
            var v = ov.swizzle.brbb;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((49)4)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(-7-7)", "(-7-2)", "(-7-7)");
            var v = ov.swizzle.brba;
            Assert.That("(-7-2)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("(-7-2)", Is.EqualTo(v.z));
            Assert.That("(-7-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-7)4)", "(-7-1)", "-6", "((37)-7)");
            var v = ov.swizzle.bra;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((-3-7)4)", Is.EqualTo(v.y));
            Assert.That("((37)-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-5-9)", "(86)", "((10)4)", "((-8-8)-9)");
            var v = ov.swizzle.brar;
            Assert.That("((10)4)", Is.EqualTo(v.x));
            Assert.That("(-5-9)", Is.EqualTo(v.y));
            Assert.That("((-8-8)-9)", Is.EqualTo(v.z));
            Assert.That("(-5-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(22)", "null", "5", "0");
            var v = ov.swizzle.brag;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(22)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-9-4)-6)", "(9-3)", "null");
            var v = ov.swizzle.brab;
            Assert.That("(9-3)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(9-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-6-2)", "-5", "((-7-9)-4)");
            var v = ov.swizzle.braa;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-7-9)-4)", Is.EqualTo(v.z));
            Assert.That("((-7-9)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-6)-1)", "(-1-9)", "-8", "(-49)");
            var v = ov.swizzle.bg;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(-1-9)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("8", "-3", "(-5-7)", "-1");
            var v = ov.swizzle.bgr;
            Assert.That("(-5-7)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(7-8)", "-3", "((-6-9)-9)", "((3-7)-1)");
            var v = ov.swizzle.bgrr;
            Assert.That("((-6-9)-9)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(7-8)", Is.EqualTo(v.z));
            Assert.That("(7-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-43)", "7", "-9", "((-4-9)-8)");
            var v = ov.swizzle.bgrg;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(-43)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "((4-1)-5)", "", "0");
            var v = ov.swizzle.bgrb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((4-1)-5)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "((-44)0)", "((-47)4)", "(9-9)");
            var v = ov.swizzle.bgra;
            Assert.That("((-47)4)", Is.EqualTo(v.x));
            Assert.That("((-44)0)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("(9-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "((13)-1)", "");
            var v = ov.swizzle.bgg;
            Assert.That("((13)-1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "null", "((4-4)3)", "-4");
            var v = ov.swizzle.bggr;
            Assert.That("((4-4)3)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "-8", "(55)", "((-5-2)-2)");
            var v = ov.swizzle.bggg;
            Assert.That("(55)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(26)", "3", "(0-5)", "");
            var v = ov.swizzle.bggb;
            Assert.That("(0-5)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("(0-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((95)2)", "((95)2)", "((61)-7)");
            var v = ov.swizzle.bgga;
            Assert.That("((95)2)", Is.EqualTo(v.x));
            Assert.That("((95)2)", Is.EqualTo(v.y));
            Assert.That("((95)2)", Is.EqualTo(v.z));
            Assert.That("((61)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "", "(91)", "((1-6)9)");
            var v = ov.swizzle.bgb;
            Assert.That("(91)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(91)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(-45)", "(1-7)", "3");
            var v = ov.swizzle.bgbr;
            Assert.That("(1-7)", Is.EqualTo(v.x));
            Assert.That("(-45)", Is.EqualTo(v.y));
            Assert.That("(1-7)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((89)-3)", "((9-3)-5)", "((89)-3)", "((9-3)-5)");
            var v = ov.swizzle.bgbg;
            Assert.That("((89)-3)", Is.EqualTo(v.x));
            Assert.That("((9-3)-5)", Is.EqualTo(v.y));
            Assert.That("((89)-3)", Is.EqualTo(v.z));
            Assert.That("((9-3)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((96)-9)", "0", "((96)-9)", "((-19)9)");
            var v = ov.swizzle.bgbb;
            Assert.That("((96)-9)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((96)-9)", Is.EqualTo(v.z));
            Assert.That("((96)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-5)-3)", "(41)", "((57)-4)", "-9");
            var v = ov.swizzle.bgba;
            Assert.That("((57)-4)", Is.EqualTo(v.x));
            Assert.That("(41)", Is.EqualTo(v.y));
            Assert.That("((57)-4)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-4)", "(6-4)", "null", "((4-9)0)");
            var v = ov.swizzle.bga;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(6-4)", Is.EqualTo(v.y));
            Assert.That("((4-9)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((28)5)", "(49)", "(49)", "-8");
            var v = ov.swizzle.bgar;
            Assert.That("(49)", Is.EqualTo(v.x));
            Assert.That("(49)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("((28)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-9)2)", "2", "2", "");
            var v = ov.swizzle.bgag;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "8", "(-48)", "((-49)2)");
            var v = ov.swizzle.bgab;
            Assert.That("(-48)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("((-49)2)", Is.EqualTo(v.z));
            Assert.That("(-48)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-8-9)", "((-7-5)-1)", "4");
            var v = ov.swizzle.bgaa;
            Assert.That("((-7-5)-1)", Is.EqualTo(v.x));
            Assert.That("(-8-9)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-3)", "null", "(-6-4)", "-2");
            var v = ov.swizzle.bb;
            Assert.That("(-6-4)", Is.EqualTo(v.x));
            Assert.That("(-6-4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("", "5", "(-14)", "5");
            var v = ov.swizzle.bbr;
            Assert.That("(-14)", Is.EqualTo(v.x));
            Assert.That("(-14)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-2-7)8)", "(-5-2)", "((35)1)", "((-2-7)8)");
            var v = ov.swizzle.bbrr;
            Assert.That("((35)1)", Is.EqualTo(v.x));
            Assert.That("((35)1)", Is.EqualTo(v.y));
            Assert.That("((-2-7)8)", Is.EqualTo(v.z));
            Assert.That("((-2-7)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((94)1)", "", "-4", "((16)4)");
            var v = ov.swizzle.bbrg;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((94)1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "(2-3)", "((-96)-3)", "-1");
            var v = ov.swizzle.bbrb;
            Assert.That("((-96)-3)", Is.EqualTo(v.x));
            Assert.That("((-96)-3)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("((-96)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((53)-1)", "(-40)", "null", "(44)");
            var v = ov.swizzle.bbra;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((53)-1)", Is.EqualTo(v.z));
            Assert.That("(44)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "-2", "null", "");
            var v = ov.swizzle.bbg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((-6-5)-5)", "((22)-5)", "-9");
            var v = ov.swizzle.bbgr;
            Assert.That("((22)-5)", Is.EqualTo(v.x));
            Assert.That("((22)-5)", Is.EqualTo(v.y));
            Assert.That("((-6-5)-5)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "-2", "1", "");
            var v = ov.swizzle.bbgg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-86)0)", "", "8");
            var v = ov.swizzle.bbgb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-86)0)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-3)", "9", "null", "((0-6)-2)");
            var v = ov.swizzle.bbga;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("((0-6)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "9", "((-62)2)", "((-3-8)2)");
            var v = ov.swizzle.bbb;
            Assert.That("((-62)2)", Is.EqualTo(v.x));
            Assert.That("((-62)2)", Is.EqualTo(v.y));
            Assert.That("((-62)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-9", "-8", "4", "((04)6)");
            var v = ov.swizzle.bbbr;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-7)-3)", "-3", "8", "");
            var v = ov.swizzle.bbbg;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((87)4)", "((-67)8)", "(-8-8)", "(79)");
            var v = ov.swizzle.bbbb;
            Assert.That("(-8-8)", Is.EqualTo(v.x));
            Assert.That("(-8-8)", Is.EqualTo(v.y));
            Assert.That("(-8-8)", Is.EqualTo(v.z));
            Assert.That("(-8-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-7)", "((83)7)", "(-6-2)", "(-6-2)");
            var v = ov.swizzle.bbba;
            Assert.That("(-6-2)", Is.EqualTo(v.x));
            Assert.That("(-6-2)", Is.EqualTo(v.y));
            Assert.That("(-6-2)", Is.EqualTo(v.z));
            Assert.That("(-6-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((28)7)", "((-85)7)", "4", "4");
            var v = ov.swizzle.bba;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(8-7)", "((-7-2)5)", "(8-7)", "((-9-1)5)");
            var v = ov.swizzle.bbar;
            Assert.That("(8-7)", Is.EqualTo(v.x));
            Assert.That("(8-7)", Is.EqualTo(v.y));
            Assert.That("((-9-1)5)", Is.EqualTo(v.z));
            Assert.That("(8-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "(79)", "((6-6)0)", "(79)");
            var v = ov.swizzle.bbag;
            Assert.That("((6-6)0)", Is.EqualTo(v.x));
            Assert.That("((6-6)0)", Is.EqualTo(v.y));
            Assert.That("(79)", Is.EqualTo(v.z));
            Assert.That("(79)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "null", "null", "-3");
            var v = ov.swizzle.bbab;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(45)", "(-10)", "-7");
            var v = ov.swizzle.bbaa;
            Assert.That("(-10)", Is.EqualTo(v.x));
            Assert.That("(-10)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-1)", "", "-2", "-4");
            var v = ov.swizzle.ba;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((68)4)", "((38)8)", "5", "((68)4)");
            var v = ov.swizzle.bar;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("((68)4)", Is.EqualTo(v.y));
            Assert.That("((68)4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-2-1)5)", "8", "(14)", "((20)8)");
            var v = ov.swizzle.barr;
            Assert.That("(14)", Is.EqualTo(v.x));
            Assert.That("((20)8)", Is.EqualTo(v.y));
            Assert.That("((-2-1)5)", Is.EqualTo(v.z));
            Assert.That("((-2-1)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((1-5)6)", "(-7-4)", "5");
            var v = ov.swizzle.barg;
            Assert.That("(-7-4)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((1-5)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "null", "((42)-7)", "-3");
            var v = ov.swizzle.barb;
            Assert.That("((42)-7)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((42)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-85)", "(-3-5)", "4", "((-17)-3)");
            var v = ov.swizzle.bara;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((-17)-3)", Is.EqualTo(v.y));
            Assert.That("(-85)", Is.EqualTo(v.z));
            Assert.That("((-17)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-58)", "(2-8)", "null", "(2-8)");
            var v = ov.swizzle.bag;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(2-8)", Is.EqualTo(v.y));
            Assert.That("(2-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-7", "((-7-5)1)", "", "((-7-5)1)");
            var v = ov.swizzle.bagr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-7-5)1)", Is.EqualTo(v.y));
            Assert.That("((-7-5)1)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-90)9)", "(-80)", "null", "(-80)");
            var v = ov.swizzle.bagg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-80)", Is.EqualTo(v.y));
            Assert.That("(-80)", Is.EqualTo(v.z));
            Assert.That("(-80)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-4-7)", "-9", "((-51)7)");
            var v = ov.swizzle.bagb;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((-51)7)", Is.EqualTo(v.y));
            Assert.That("(-4-7)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-76)", "1", "(00)", "(-8-2)");
            var v = ov.swizzle.baga;
            Assert.That("(00)", Is.EqualTo(v.x));
            Assert.That("(-8-2)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("(-8-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "3", "null", "8");
            var v = ov.swizzle.bab;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-1-1)", "-2", "", "((45)-7)");
            var v = ov.swizzle.babr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((45)-7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-1-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((31)2)", "(7-7)", "((-6-7)-5)", "((-6-7)-5)");
            var v = ov.swizzle.babg;
            Assert.That("((-6-7)-5)", Is.EqualTo(v.x));
            Assert.That("((-6-7)-5)", Is.EqualTo(v.y));
            Assert.That("((-6-7)-5)", Is.EqualTo(v.z));
            Assert.That("(7-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-16)-8)", "", "-6", "4");
            var v = ov.swizzle.babb;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((8-2)8)", "(8-1)", "(-63)");
            var v = ov.swizzle.baba;
            Assert.That("(8-1)", Is.EqualTo(v.x));
            Assert.That("(-63)", Is.EqualTo(v.y));
            Assert.That("(8-1)", Is.EqualTo(v.z));
            Assert.That("(-63)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-56)", "5", "null", "");
            var v = ov.swizzle.baa;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(7-1)", "((-6-7)5)", "null", "4");
            var v = ov.swizzle.baar;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(7-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-9)", "null", "((28)-7)", "((-65)6)");
            var v = ov.swizzle.baag;
            Assert.That("((28)-7)", Is.EqualTo(v.x));
            Assert.That("((-65)6)", Is.EqualTo(v.y));
            Assert.That("((-65)6)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "((-10)7)", "(-16)", "");
            var v = ov.swizzle.baab;
            Assert.That("(-16)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-16)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-5)6)", "((8-5)6)", "(18)", "-9");
            var v = ov.swizzle.baaa;
            Assert.That("(18)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-5)", "((08)1)", "((08)1)", "((08)1)");
            var v = ov.swizzle.ar;
            Assert.That("((08)1)", Is.EqualTo(v.x));
            Assert.That("(8-5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-8-5)", "", "(-53)", "(-53)");
            var v = ov.swizzle.arr;
            Assert.That("(-53)", Is.EqualTo(v.x));
            Assert.That("(-8-5)", Is.EqualTo(v.y));
            Assert.That("(-8-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-9-3)", "(-9-3)", "((7-5)-2)", "((7-5)-2)");
            var v = ov.swizzle.arrr;
            Assert.That("((7-5)-2)", Is.EqualTo(v.x));
            Assert.That("(-9-3)", Is.EqualTo(v.y));
            Assert.That("(-9-3)", Is.EqualTo(v.z));
            Assert.That("(-9-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-18)-7)", "(-1-3)", "null", "(8-1)");
            var v = ov.swizzle.arrg;
            Assert.That("(8-1)", Is.EqualTo(v.x));
            Assert.That("((-18)-7)", Is.EqualTo(v.y));
            Assert.That("((-18)-7)", Is.EqualTo(v.z));
            Assert.That("(-1-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-95)", "(0-8)", "", "((61)-5)");
            var v = ov.swizzle.arrb;
            Assert.That("((61)-5)", Is.EqualTo(v.x));
            Assert.That("(-95)", Is.EqualTo(v.y));
            Assert.That("(-95)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((1-4)4)", "2", "");
            var v = ov.swizzle.arra;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-39)", "(4-1)", "(45)", "-3");
            var v = ov.swizzle.arg;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(-39)", Is.EqualTo(v.y));
            Assert.That("(4-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-7", "(-6-4)", "8", "8");
            var v = ov.swizzle.argr;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(-6-4)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-1)-8)", "1", "((3-5)-7)", "1");
            var v = ov.swizzle.argg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((-9-1)-8)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "((-98)2)", "", "8");
            var v = ov.swizzle.argb;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((-98)2)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-8)-2)", "2", "", "-1");
            var v = ov.swizzle.arga;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((-4-8)-2)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "(29)", "(41)", "");
            var v = ov.swizzle.arb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("(41)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((67)3)", "", "-2", "(66)");
            var v = ov.swizzle.arbr;
            Assert.That("(66)", Is.EqualTo(v.x));
            Assert.That("((67)3)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("((67)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-4)-3)", "((-68)8)", "((-68)8)", "((-1-4)-3)");
            var v = ov.swizzle.arbg;
            Assert.That("((-1-4)-3)", Is.EqualTo(v.x));
            Assert.That("((-1-4)-3)", Is.EqualTo(v.y));
            Assert.That("((-68)8)", Is.EqualTo(v.z));
            Assert.That("((-68)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "(-85)", "-8", "((-1-5)2)");
            var v = ov.swizzle.arbb;
            Assert.That("((-1-5)2)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-7", "-7", "((-9-5)-1)");
            var v = ov.swizzle.arba;
            Assert.That("((-9-5)-1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((-9-5)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "9", "", "-8");
            var v = ov.swizzle.ara;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("1", "2", "6", "((13)-1)");
            var v = ov.swizzle.arar;
            Assert.That("((13)-1)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("((13)-1)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "((-84)-5)", "-8", "null");
            var v = ov.swizzle.arag;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-84)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-4)", "(-2-8)", "1", "");
            var v = ov.swizzle.arab;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-8-4)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((18)2)", "null", "((18)2)");
            var v = ov.swizzle.araa;
            Assert.That("((18)2)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((18)2)", Is.EqualTo(v.z));
            Assert.That("((18)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((15)8)", "(8-6)", "", "(69)");
            var v = ov.swizzle.ag;
            Assert.That("(69)", Is.EqualTo(v.x));
            Assert.That("(8-6)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((9-3)-5)", "-4", "null", "((81)-5)");
            var v = ov.swizzle.agr;
            Assert.That("((81)-5)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((9-3)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(6-1)", "(6-1)", "((-5-6)-7)", "");
            var v = ov.swizzle.agrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(6-1)", Is.EqualTo(v.y));
            Assert.That("(6-1)", Is.EqualTo(v.z));
            Assert.That("(6-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-2)", "(-36)", "((-6-8)-2)", "(7-2)");
            var v = ov.swizzle.agrg;
            Assert.That("(7-2)", Is.EqualTo(v.x));
            Assert.That("(-36)", Is.EqualTo(v.y));
            Assert.That("(7-2)", Is.EqualTo(v.z));
            Assert.That("(-36)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-8)9)", "(-95)", "0", "((4-8)9)");
            var v = ov.swizzle.agrb;
            Assert.That("((4-8)9)", Is.EqualTo(v.x));
            Assert.That("(-95)", Is.EqualTo(v.y));
            Assert.That("((4-8)9)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((04)7)", "4", "4", "(4-1)");
            var v = ov.swizzle.agra;
            Assert.That("(4-1)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((04)7)", Is.EqualTo(v.z));
            Assert.That("(4-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((0-6)-2)", "((0-6)-2)", "null");
            var v = ov.swizzle.agg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((0-6)-2)", Is.EqualTo(v.y));
            Assert.That("((0-6)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-8-7)9)", "(73)", "-9", "1");
            var v = ov.swizzle.aggr;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(73)", Is.EqualTo(v.y));
            Assert.That("(73)", Is.EqualTo(v.z));
            Assert.That("((-8-7)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((45)-8)", "-2", "(15)", "(15)");
            var v = ov.swizzle.aggg;
            Assert.That("(15)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "(-70)", "((5-1)-2)", "((5-1)-2)");
            var v = ov.swizzle.aggb;
            Assert.That("((5-1)-2)", Is.EqualTo(v.x));
            Assert.That("(-70)", Is.EqualTo(v.y));
            Assert.That("(-70)", Is.EqualTo(v.z));
            Assert.That("((5-1)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "(-5-2)", "0");
            var v = ov.swizzle.agga;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-3)", "", "null", "-2");
            var v = ov.swizzle.agb;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-1", "(-4-4)", "-1", "");
            var v = ov.swizzle.agbr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-4-4)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-4)-1)", "null", "((-5-5)7)", "null");
            var v = ov.swizzle.agbg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-5-5)7)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-8", "null", "((06)8)");
            var v = ov.swizzle.agbb;
            Assert.That("((06)8)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "3", "((6-8)1)", "null");
            var v = ov.swizzle.agba;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((6-8)1)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-8)", "(-50)", "(-5-8)", "9");
            var v = ov.swizzle.aga;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(-50)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "-9", "3", "-2");
            var v = ov.swizzle.agar;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((07)-5)", "((9-5)3)", "((13)3)", "");
            var v = ov.swizzle.agag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((9-5)3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((9-5)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-4)0)", "((-46)8)", "6", "((-46)8)");
            var v = ov.swizzle.agab;
            Assert.That("((-46)8)", Is.EqualTo(v.x));
            Assert.That("((-46)8)", Is.EqualTo(v.y));
            Assert.That("((-46)8)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((49)1)", "((8-8)-7)", "((49)1)", "(74)");
            var v = ov.swizzle.agaa;
            Assert.That("(74)", Is.EqualTo(v.x));
            Assert.That("((8-8)-7)", Is.EqualTo(v.y));
            Assert.That("(74)", Is.EqualTo(v.z));
            Assert.That("(74)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "8", "((2-6)-4)", "((-4-2)6)");
            var v = ov.swizzle.ab;
            Assert.That("((-4-2)6)", Is.EqualTo(v.x));
            Assert.That("((2-6)-4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(62)", "((1-9)7)", "(-76)", "null");
            var v = ov.swizzle.abr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-76)", Is.EqualTo(v.y));
            Assert.That("(62)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(83)", "-1", "((33)-1)", "-9");
            var v = ov.swizzle.abrr;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((33)-1)", Is.EqualTo(v.y));
            Assert.That("(83)", Is.EqualTo(v.z));
            Assert.That("(83)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-4)", "(6-7)", "((7-6)-4)", "(99)");
            var v = ov.swizzle.abrg;
            Assert.That("(99)", Is.EqualTo(v.x));
            Assert.That("((7-6)-4)", Is.EqualTo(v.y));
            Assert.That("(0-4)", Is.EqualTo(v.z));
            Assert.That("(6-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "9", "(5-5)", "-9");
            var v = ov.swizzle.abrb;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("(5-5)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(5-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-4)9)", "(-8-2)", "((2-2)9)", "(8-6)");
            var v = ov.swizzle.abra;
            Assert.That("(8-6)", Is.EqualTo(v.x));
            Assert.That("((2-2)9)", Is.EqualTo(v.y));
            Assert.That("((5-4)9)", Is.EqualTo(v.z));
            Assert.That("(8-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-32)9)", "", "", "4");
            var v = ov.swizzle.abg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((3-6)-3)", "-4", "(77)", "5");
            var v = ov.swizzle.abgr;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(77)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("((3-6)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(36)", "", "((9-4)-9)", "(-87)");
            var v = ov.swizzle.abgg;
            Assert.That("(-87)", Is.EqualTo(v.x));
            Assert.That("((9-4)-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-63)-2)", "-5", "(9-5)", "(-42)");
            var v = ov.swizzle.abgb;
            Assert.That("(-42)", Is.EqualTo(v.x));
            Assert.That("(9-5)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("(9-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-3-7)", "7", "((41)1)");
            var v = ov.swizzle.abga;
            Assert.That("((41)1)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(-3-7)", Is.EqualTo(v.z));
            Assert.That("((41)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-6)8)", "5", "((3-6)-3)", "5");
            var v = ov.swizzle.abb;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("((3-6)-3)", Is.EqualTo(v.y));
            Assert.That("((3-6)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("7", "((-4-2)5)", "-4", "(66)");
            var v = ov.swizzle.abbr;
            Assert.That("(66)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-7)2)", "(7-1)", "(7-1)", "8");
            var v = ov.swizzle.abbg;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(7-1)", Is.EqualTo(v.y));
            Assert.That("(7-1)", Is.EqualTo(v.z));
            Assert.That("(7-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-1)", "(-3-2)", "-7", "null");
            var v = ov.swizzle.abbb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "1", "((-72)-7)", "-6");
            var v = ov.swizzle.abba;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((-72)-7)", Is.EqualTo(v.y));
            Assert.That("((-72)-7)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-80)-8)", "", "((3-2)-5)", "((-8-9)-6)");
            var v = ov.swizzle.aba;
            Assert.That("((-8-9)-6)", Is.EqualTo(v.x));
            Assert.That("((3-2)-5)", Is.EqualTo(v.y));
            Assert.That("((-8-9)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-3-6)", "((8-3)5)", "null", "7");
            var v = ov.swizzle.abar;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(-3-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "(66)", "", "(66)");
            var v = ov.swizzle.abag;
            Assert.That("(66)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(66)", Is.EqualTo(v.z));
            Assert.That("(66)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-3)3)", "1", "null", "(76)");
            var v = ov.swizzle.abab;
            Assert.That("(76)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(76)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "6", "6", "6");
            var v = ov.swizzle.abaa;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(14)", "", "-5", "");
            var v = ov.swizzle.aa;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(45)", "((-70)2)", "-8", "null");
            var v = ov.swizzle.aar;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(45)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "((6-9)-9)", "(35)", "(-2-3)");
            var v = ov.swizzle.aarr;
            Assert.That("(-2-3)", Is.EqualTo(v.x));
            Assert.That("(-2-3)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((9-7)-6)", "6", "(98)");
            var v = ov.swizzle.aarg;
            Assert.That("(98)", Is.EqualTo(v.x));
            Assert.That("(98)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((9-7)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-22)", "8", "((4-5)9)", "8");
            var v = ov.swizzle.aarb;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-22)", Is.EqualTo(v.z));
            Assert.That("((4-5)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-37)8)", "(7-7)", "null", "((-37)8)");
            var v = ov.swizzle.aara;
            Assert.That("((-37)8)", Is.EqualTo(v.x));
            Assert.That("((-37)8)", Is.EqualTo(v.y));
            Assert.That("((-37)8)", Is.EqualTo(v.z));
            Assert.That("((-37)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-96)", "null", "((12)-8)", "");
            var v = ov.swizzle.aag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("1", "(-11)", "(7-1)", "((-69)2)");
            var v = ov.swizzle.aagr;
            Assert.That("((-69)2)", Is.EqualTo(v.x));
            Assert.That("((-69)2)", Is.EqualTo(v.y));
            Assert.That("(-11)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "", "(59)", "((3-7)-7)");
            var v = ov.swizzle.aagg;
            Assert.That("((3-7)-7)", Is.EqualTo(v.x));
            Assert.That("((3-7)-7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "3", "(9-6)", "(9-6)");
            var v = ov.swizzle.aagb;
            Assert.That("(9-6)", Is.EqualTo(v.x));
            Assert.That("(9-6)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("(9-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "1", "", "(41)");
            var v = ov.swizzle.aaga;
            Assert.That("(41)", Is.EqualTo(v.x));
            Assert.That("(41)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("(41)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "(82)", "-3", "(82)");
            var v = ov.swizzle.aab;
            Assert.That("(82)", Is.EqualTo(v.x));
            Assert.That("(82)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(3-4)", "(3-4)", "null", "((-68)5)");
            var v = ov.swizzle.aabr;
            Assert.That("((-68)5)", Is.EqualTo(v.x));
            Assert.That("((-68)5)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(3-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-8)2)", "((1-8)2)", "-7", "null");
            var v = ov.swizzle.aabg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((1-8)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-3)", "((-7-1)-5)", "1", "((-8-5)-9)");
            var v = ov.swizzle.aabb;
            Assert.That("((-8-5)-9)", Is.EqualTo(v.x));
            Assert.That("((-8-5)-9)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((23)-6)", "(8-3)", "2");
            var v = ov.swizzle.aaba;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(8-3)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-4)-9)", "7", "1", "((2-4)-9)");
            var v = ov.swizzle.aaa;
            Assert.That("((2-4)-9)", Is.EqualTo(v.x));
            Assert.That("((2-4)-9)", Is.EqualTo(v.y));
            Assert.That("((2-4)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((-16)-9)", "-9", "-4");
            var v = ov.swizzle.aaar;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-59)9)", "((6-2)9)", "-7", "0");
            var v = ov.swizzle.aaag;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("((6-2)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-88)", "((5-2)6)", "-6", "(8-2)");
            var v = ov.swizzle.aaab;
            Assert.That("(8-2)", Is.EqualTo(v.x));
            Assert.That("(8-2)", Is.EqualTo(v.y));
            Assert.That("(8-2)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((87)3)", "((87)3)", "(-1-4)", "((87)3)");
            var v = ov.swizzle.aaaa;
            Assert.That("((87)3)", Is.EqualTo(v.x));
            Assert.That("((87)3)", Is.EqualTo(v.y));
            Assert.That("((87)3)", Is.EqualTo(v.z));
            Assert.That("((87)3)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec4<string>("null", "", "((-2-3)9)", "6");
            var v1 = new gvec2<string>("-9", "null");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-9", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("((-2-3)9)", Is.EqualTo(v0.z));
            Assert.That("6", Is.EqualTo(v0.w));
        
            Assert.That("null", Is.EqualTo(v2.x));
            Assert.That("", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("-5", "-4", "", "null");
            var v1 = new gvec2<string>("-8", "-6");
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-8", Is.EqualTo(v0.x));
            Assert.That("-4", Is.EqualTo(v0.y));
            Assert.That("-6", Is.EqualTo(v0.z));
            Assert.That("null", Is.EqualTo(v0.w));
        
            Assert.That("-5", Is.EqualTo(v2.x));
            Assert.That("", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("null", "(57)", "null", "(67)");
            var v1 = new gvec2<string>("9", "(-41)");
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("9", Is.EqualTo(v0.y));
            Assert.That("(-41)", Is.EqualTo(v0.z));
            Assert.That("(67)", Is.EqualTo(v0.w));
        
            Assert.That("(57)", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("", "null", "(3-4)", "((-8-9)-2)");
            var v1 = new gvec3<string>("(1-5)", "(-3-6)", "(8-6)");
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(1-5)", Is.EqualTo(v0.x));
            Assert.That("(-3-6)", Is.EqualTo(v0.y));
            Assert.That("(8-6)", Is.EqualTo(v0.z));
            Assert.That("((-8-9)-2)", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
            Assert.That("(3-4)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("((3-9)-2)", "(-3-6)", "((-61)-2)", "null");
            var v1 = new gvec2<string>("((3-8)9)", "null");
            var v2 = v0.xw;
            v0.xw = v1;
            var v3 = v0.xw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((3-8)9)", Is.EqualTo(v0.x));
            Assert.That("(-3-6)", Is.EqualTo(v0.y));
            Assert.That("((-61)-2)", Is.EqualTo(v0.z));
            Assert.That("null", Is.EqualTo(v0.w));
        
            Assert.That("((3-9)-2)", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(-4-5)", "null", "", "8");
            var v1 = new gvec2<string>("", "6");
            var v2 = v0.yw;
            v0.yw = v1;
            var v3 = v0.yw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-4-5)", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That("6", Is.EqualTo(v0.w));
        
            Assert.That("null", Is.EqualTo(v2.x));
            Assert.That("8", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("7", "", "((43)-8)", "null");
            var v1 = new gvec3<string>("((1-6)-8)", "0", "");
            var v2 = v0.xyw;
            v0.xyw = v1;
            var v3 = v0.xyw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((1-6)-8)", Is.EqualTo(v0.x));
            Assert.That("0", Is.EqualTo(v0.y));
            Assert.That("((43)-8)", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("7", Is.EqualTo(v2.x));
            Assert.That("", Is.EqualTo(v2.y));
            Assert.That("null", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("-7", "8", "", "((-8-9)-7)");
            var v1 = new gvec2<string>("-2", "-6");
            var v2 = v0.zw;
            v0.zw = v1;
            var v3 = v0.zw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-7", Is.EqualTo(v0.x));
            Assert.That("8", Is.EqualTo(v0.y));
            Assert.That("-2", Is.EqualTo(v0.z));
            Assert.That("-6", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("((-8-9)-7)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((-9-9)-2)", "1", "1", "-8");
            var v1 = new gvec3<string>("-1", "(63)", "null");
            var v2 = v0.xzw;
            v0.xzw = v1;
            var v3 = v0.xzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-1", Is.EqualTo(v0.x));
            Assert.That("1", Is.EqualTo(v0.y));
            Assert.That("(63)", Is.EqualTo(v0.z));
            Assert.That("null", Is.EqualTo(v0.w));
        
            Assert.That("((-9-9)-2)", Is.EqualTo(v2.x));
            Assert.That("1", Is.EqualTo(v2.y));
            Assert.That("-8", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("null", "(-44)", "((-90)-5)", "6");
            var v1 = new gvec3<string>("(-1-3)", "6", "");
            var v2 = v0.yzw;
            v0.yzw = v1;
            var v3 = v0.yzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("(-1-3)", Is.EqualTo(v0.y));
            Assert.That("6", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("(-44)", Is.EqualTo(v2.x));
            Assert.That("((-90)-5)", Is.EqualTo(v2.y));
            Assert.That("6", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(8-7)", "-1", "0", "((8-5)4)");
            var v1 = new gvec4<string>("((-80)-6)", "(40)", "-7", "((-4-2)-3)");
            var v2 = v0.xyzw;
            v0.xyzw = v1;
            var v3 = v0.xyzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-80)-6)", Is.EqualTo(v0.x));
            Assert.That("(40)", Is.EqualTo(v0.y));
            Assert.That("-7", Is.EqualTo(v0.z));
            Assert.That("((-4-2)-3)", Is.EqualTo(v0.w));
        
            Assert.That("(8-7)", Is.EqualTo(v2.x));
            Assert.That("-1", Is.EqualTo(v2.y));
            Assert.That("0", Is.EqualTo(v2.z));
            Assert.That("((8-5)4)", Is.EqualTo(v2.w));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new gvec4<string>("(36)", "-1", "null", "0");
            var v1 = "((-74)4)";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-74)4)", Is.EqualTo(v0.x));
            Assert.That("-1", Is.EqualTo(v0.y));
            Assert.That("null", Is.EqualTo(v0.z));
            Assert.That("0", Is.EqualTo(v0.w));
        
            Assert.That("(36)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("", "null", "null", "(20)");
            var v1 = "null";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("null", Is.EqualTo(v0.z));
            Assert.That("(20)", Is.EqualTo(v0.w));
        
            Assert.That("null", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("(-92)", "(-28)", "((94)1)", "((94)1)");
            var v1 = new gvec2<string>("null", "((-2-3)-9)");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("((-2-3)-9)", Is.EqualTo(v0.y));
            Assert.That("((94)1)", Is.EqualTo(v0.z));
            Assert.That("((94)1)", Is.EqualTo(v0.w));
        
            Assert.That("(-92)", Is.EqualTo(v2.x));
            Assert.That("(-28)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("", "(62)", "((14)8)", "1");
            var v1 = "4";
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("(62)", Is.EqualTo(v0.y));
            Assert.That("4", Is.EqualTo(v0.z));
            Assert.That("1", Is.EqualTo(v0.w));
        
            Assert.That("((14)8)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("((-43)7)", "((78)-2)", "null", "");
            var v1 = new gvec2<string>("((4-9)-2)", "-6");
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((4-9)-2)", Is.EqualTo(v0.x));
            Assert.That("((78)-2)", Is.EqualTo(v0.y));
            Assert.That("-6", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("((-43)7)", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("3", "3", "(07)", "-5");
            var v1 = new gvec2<string>("(-79)", "-7");
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("3", Is.EqualTo(v0.x));
            Assert.That("(-79)", Is.EqualTo(v0.y));
            Assert.That("-7", Is.EqualTo(v0.z));
            Assert.That("-5", Is.EqualTo(v0.w));
        
            Assert.That("3", Is.EqualTo(v2.x));
            Assert.That("(07)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((7-2)-6)", "3", "(14)", "((7-2)-6)");
            var v1 = new gvec3<string>("((0-5)1)", "((42)-5)", "6");
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((0-5)1)", Is.EqualTo(v0.x));
            Assert.That("((42)-5)", Is.EqualTo(v0.y));
            Assert.That("6", Is.EqualTo(v0.z));
            Assert.That("((7-2)-6)", Is.EqualTo(v0.w));
        
            Assert.That("((7-2)-6)", Is.EqualTo(v2.x));
            Assert.That("3", Is.EqualTo(v2.y));
            Assert.That("(14)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("-5", "((13)8)", "-5", "((-26)-4)");
            var v1 = "(-41)";
            var v2 = v0.a;
            v0.a = v1;
            var v3 = v0.a;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-5", Is.EqualTo(v0.x));
            Assert.That("((13)8)", Is.EqualTo(v0.y));
            Assert.That("-5", Is.EqualTo(v0.z));
            Assert.That("(-41)", Is.EqualTo(v0.w));
        
            Assert.That("((-26)-4)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("-9", "(-68)", "((-65)-6)", "-9");
            var v1 = new gvec2<string>("((-81)4)", "-4");
            var v2 = v0.ra;
            v0.ra = v1;
            var v3 = v0.ra;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-81)4)", Is.EqualTo(v0.x));
            Assert.That("(-68)", Is.EqualTo(v0.y));
            Assert.That("((-65)-6)", Is.EqualTo(v0.z));
            Assert.That("-4", Is.EqualTo(v0.w));
        
            Assert.That("-9", Is.EqualTo(v2.x));
            Assert.That("-9", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("6", "6", "((53)1)", "(9-9)");
            var v1 = new gvec2<string>("((8-4)5)", "(-17)");
            var v2 = v0.ga;
            v0.ga = v1;
            var v3 = v0.ga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("6", Is.EqualTo(v0.x));
            Assert.That("((8-4)5)", Is.EqualTo(v0.y));
            Assert.That("((53)1)", Is.EqualTo(v0.z));
            Assert.That("(-17)", Is.EqualTo(v0.w));
        
            Assert.That("6", Is.EqualTo(v2.x));
            Assert.That("(9-9)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(-89)", "(-49)", "-6", "-4");
            var v1 = new gvec3<string>("(-51)", "((9-3)7)", "null");
            var v2 = v0.rga;
            v0.rga = v1;
            var v3 = v0.rga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-51)", Is.EqualTo(v0.x));
            Assert.That("((9-3)7)", Is.EqualTo(v0.y));
            Assert.That("-6", Is.EqualTo(v0.z));
            Assert.That("null", Is.EqualTo(v0.w));
        
            Assert.That("(-89)", Is.EqualTo(v2.x));
            Assert.That("(-49)", Is.EqualTo(v2.y));
            Assert.That("-4", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(-74)", "null", "8", "8");
            var v1 = new gvec2<string>("(-7-9)", "(-7-9)");
            var v2 = v0.ba;
            v0.ba = v1;
            var v3 = v0.ba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-74)", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("(-7-9)", Is.EqualTo(v0.z));
            Assert.That("(-7-9)", Is.EqualTo(v0.w));
        
            Assert.That("8", Is.EqualTo(v2.x));
            Assert.That("8", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("-7", "(-49)", "2", "null");
            var v1 = new gvec3<string>("(7-3)", "-1", "((41)-1)");
            var v2 = v0.rba;
            v0.rba = v1;
            var v3 = v0.rba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(7-3)", Is.EqualTo(v0.x));
            Assert.That("(-49)", Is.EqualTo(v0.y));
            Assert.That("-1", Is.EqualTo(v0.z));
            Assert.That("((41)-1)", Is.EqualTo(v0.w));
        
            Assert.That("-7", Is.EqualTo(v2.x));
            Assert.That("2", Is.EqualTo(v2.y));
            Assert.That("null", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(41)", "", "((9-4)7)", "((-7-7)3)");
            var v1 = new gvec3<string>("-8", "null", "(-7-8)");
            var v2 = v0.gba;
            v0.gba = v1;
            var v3 = v0.gba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(41)", Is.EqualTo(v0.x));
            Assert.That("-8", Is.EqualTo(v0.y));
            Assert.That("null", Is.EqualTo(v0.z));
            Assert.That("(-7-8)", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("((9-4)7)", Is.EqualTo(v2.y));
            Assert.That("((-7-7)3)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(-29)", "-2", "", "(-29)");
            var v1 = new gvec4<string>("2", "2", "((6-3)9)", "(-2-9)");
            var v2 = v0.rgba;
            v0.rgba = v1;
            var v3 = v0.rgba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("2", Is.EqualTo(v0.x));
            Assert.That("2", Is.EqualTo(v0.y));
            Assert.That("((6-3)9)", Is.EqualTo(v0.z));
            Assert.That("(-2-9)", Is.EqualTo(v0.w));
        
            Assert.That("(-29)", Is.EqualTo(v2.x));
            Assert.That("-2", Is.EqualTo(v2.y));
            Assert.That("", Is.EqualTo(v2.z));
            Assert.That("(-29)", Is.EqualTo(v2.w));
        }
    }

}
