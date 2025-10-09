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
            var ov = new gvec4<string>(null, "1", "((-5-7)-8)", "((-8-8)0)");
            var v = ov.swizzle.xx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-11)", "((92)-4)", "(-74)", "-8");
            var v = ov.swizzle.xxx;
            Assert.That("(-11)", Is.EqualTo(v.x));
            Assert.That("(-11)", Is.EqualTo(v.y));
            Assert.That("(-11)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "((-3-7)4)", "1", "(-5-6)");
            var v = ov.swizzle.xxxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(-29)", "(2-2)", "-3");
            var v = ov.swizzle.xxxy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(-29)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "9", "((-21)-8)", "(-29)");
            var v = ov.swizzle.xxxz;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("((-21)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "0", "1", "(-52)");
            var v = ov.swizzle.xxxw;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("(-52)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "((-6-6)9)", "((-61)-1)", "((-61)-1)");
            var v = ov.swizzle.xxy;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((-6-6)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(16)", "(1-3)", "((6-9)9)", "");
            var v = ov.swizzle.xxyx;
            Assert.That("(16)", Is.EqualTo(v.x));
            Assert.That("(16)", Is.EqualTo(v.y));
            Assert.That("(1-3)", Is.EqualTo(v.z));
            Assert.That("(16)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "(-54)", "6", "(-54)");
            var v = ov.swizzle.xxyy;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(-54)", Is.EqualTo(v.z));
            Assert.That("(-54)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((18)-5)", "(02)", null, "(94)");
            var v = ov.swizzle.xxyz;
            Assert.That("((18)-5)", Is.EqualTo(v.x));
            Assert.That("((18)-5)", Is.EqualTo(v.y));
            Assert.That("(02)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-5)", "", "((7-3)-1)", "(6-1)");
            var v = ov.swizzle.xxyw;
            Assert.That("(6-5)", Is.EqualTo(v.x));
            Assert.That("(6-5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(6-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-9)", "(-7-9)", "7", null);
            var v = ov.swizzle.xxz;
            Assert.That("(-7-9)", Is.EqualTo(v.x));
            Assert.That("(-7-9)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-52)", "(-64)", "-3", "((-6-3)-5)");
            var v = ov.swizzle.xxzx;
            Assert.That("(-52)", Is.EqualTo(v.x));
            Assert.That("(-52)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(-52)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(29)", null, "((-66)9)", "-7");
            var v = ov.swizzle.xxzy;
            Assert.That("(29)", Is.EqualTo(v.x));
            Assert.That("(29)", Is.EqualTo(v.y));
            Assert.That("((-66)9)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "-5", "-5", "7");
            var v = ov.swizzle.xxzz;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((27)9)", "((9-9)4)", "-4", "((-71)9)");
            var v = ov.swizzle.xxzw;
            Assert.That("((27)9)", Is.EqualTo(v.x));
            Assert.That("((27)9)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("((-71)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "((80)5)", "((44)-2)", null);
            var v = ov.swizzle.xxw;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-4-1)", "(8-9)", "((-60)0)", "5");
            var v = ov.swizzle.xxwx;
            Assert.That("(-4-1)", Is.EqualTo(v.x));
            Assert.That("(-4-1)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("(-4-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-53)", "", "((-6-5)-9)", "((-5-7)-9)");
            var v = ov.swizzle.xxwy;
            Assert.That("(-53)", Is.EqualTo(v.x));
            Assert.That("(-53)", Is.EqualTo(v.y));
            Assert.That("((-5-7)-9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "(-82)", "(-39)", "-1");
            var v = ov.swizzle.xxwz;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("(-39)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "(14)", "-4", "((18)4)");
            var v = ov.swizzle.xxww;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((18)4)", Is.EqualTo(v.z));
            Assert.That("((18)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(48)", "((5-4)-2)", "(48)", "8");
            var v = ov.swizzle.xy;
            Assert.That("(48)", Is.EqualTo(v.x));
            Assert.That("((5-4)-2)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((1-4)4)", "(-91)", "(-91)", "(-16)");
            var v = ov.swizzle.xyx;
            Assert.That("((1-4)4)", Is.EqualTo(v.x));
            Assert.That("(-91)", Is.EqualTo(v.y));
            Assert.That("((1-4)4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("9", "((-96)-4)", "((91)-8)", "((91)-8)");
            var v = ov.swizzle.xyxx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((-96)-4)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-4)7)", "(18)", "(3-3)", "-2");
            var v = ov.swizzle.xyxy;
            Assert.That("((-1-4)7)", Is.EqualTo(v.x));
            Assert.That("(18)", Is.EqualTo(v.y));
            Assert.That("((-1-4)7)", Is.EqualTo(v.z));
            Assert.That("(18)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "((17)2)", "((17)2)", "-2");
            var v = ov.swizzle.xyxz;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((17)2)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("((17)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-66)7)", "(-9-2)", "((30)5)", "2");
            var v = ov.swizzle.xyxw;
            Assert.That("((-66)7)", Is.EqualTo(v.x));
            Assert.That("(-9-2)", Is.EqualTo(v.y));
            Assert.That("((-66)7)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(52)", null, "", "-9");
            var v = ov.swizzle.xyy;
            Assert.That("(52)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("3", "9", "((1-6)4)", "((-15)-2)");
            var v = ov.swizzle.xyyx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-86)-5)", "", "1");
            var v = ov.swizzle.xyyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-86)-5)", Is.EqualTo(v.y));
            Assert.That("((-86)-5)", Is.EqualTo(v.z));
            Assert.That("((-86)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(-4-8)", "2", "(-77)");
            var v = ov.swizzle.xyyz;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-4-8)", Is.EqualTo(v.y));
            Assert.That("(-4-8)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "-8", "(81)", "-2");
            var v = ov.swizzle.xyyw;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-1)-9)", "(9-9)", "-6", "");
            var v = ov.swizzle.xyz;
            Assert.That("((-3-1)-9)", Is.EqualTo(v.x));
            Assert.That("(9-9)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-15)7)", "(3-6)", "", "((6-5)-2)");
            var v = ov.swizzle.xyzx;
            Assert.That("((-15)7)", Is.EqualTo(v.x));
            Assert.That("(3-6)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-15)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(59)", "((-4-4)8)", null, "(-5-5)");
            var v = ov.swizzle.xyzy;
            Assert.That("(59)", Is.EqualTo(v.x));
            Assert.That("((-4-4)8)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((-4-4)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((40)-6)", "7", "((40)-6)", "(-53)");
            var v = ov.swizzle.xyzz;
            Assert.That("((40)-6)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("((40)-6)", Is.EqualTo(v.z));
            Assert.That("((40)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(26)", null, "1", "1");
            var v = ov.swizzle.xyzw;
            Assert.That("(26)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((83)-6)", "((3-7)1)", "((-72)1)", "(40)");
            var v = ov.swizzle.xyw;
            Assert.That("((83)-6)", Is.EqualTo(v.x));
            Assert.That("((3-7)1)", Is.EqualTo(v.y));
            Assert.That("(40)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(97)", null, "((92)9)", "-6");
            var v = ov.swizzle.xywx;
            Assert.That("(97)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("(97)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-97)5)", "6", "(79)", "-4");
            var v = ov.swizzle.xywy;
            Assert.That("((-97)5)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-21)", "-5", "((22)-1)");
            var v = ov.swizzle.xywz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-21)", Is.EqualTo(v.y));
            Assert.That("((22)-1)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((3-3)-6)", "1", "(7-2)");
            var v = ov.swizzle.xyww;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((3-3)-6)", Is.EqualTo(v.y));
            Assert.That("(7-2)", Is.EqualTo(v.z));
            Assert.That("(7-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-83)", "-2", "(96)", null);
            var v = ov.swizzle.xz;
            Assert.That("(-83)", Is.EqualTo(v.x));
            Assert.That("(96)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>(null, "((-19)1)", "((0-4)5)", "((-19)1)");
            var v = ov.swizzle.xzx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((0-4)5)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-1", "", "(91)", "((45)-1)");
            var v = ov.swizzle.xzxx;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("(91)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-60)", "", "((-7-8)-5)", "6");
            var v = ov.swizzle.xzxy;
            Assert.That("(-60)", Is.EqualTo(v.x));
            Assert.That("((-7-8)-5)", Is.EqualTo(v.y));
            Assert.That("(-60)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(39)", "(66)", null, "((-66)-6)");
            var v = ov.swizzle.xzxz;
            Assert.That("(39)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(39)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((76)7)", "", "9");
            var v = ov.swizzle.xzxw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-37)7)", "((-23)2)", "0", "");
            var v = ov.swizzle.xzy;
            Assert.That("((-37)7)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((-23)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("1", "(71)", "(3-4)", "((29)5)");
            var v = ov.swizzle.xzyx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(3-4)", Is.EqualTo(v.y));
            Assert.That("(71)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-2)", "((-93)-3)", "(-26)", null);
            var v = ov.swizzle.xzyy;
            Assert.That("(-6-2)", Is.EqualTo(v.x));
            Assert.That("(-26)", Is.EqualTo(v.y));
            Assert.That("((-93)-3)", Is.EqualTo(v.z));
            Assert.That("((-93)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((6-6)8)", null, "");
            var v = ov.swizzle.xzyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((6-6)8)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-7", "((91)-8)", null);
            var v = ov.swizzle.xzyw;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((91)-8)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-80)9)", "-8", null, "((-50)3)");
            var v = ov.swizzle.xzz;
            Assert.That("((-80)9)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(2-7)", "-2", "(91)", "(91)");
            var v = ov.swizzle.xzzx;
            Assert.That("(2-7)", Is.EqualTo(v.x));
            Assert.That("(91)", Is.EqualTo(v.y));
            Assert.That("(91)", Is.EqualTo(v.z));
            Assert.That("(2-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-3)-9)", "", null, "2");
            var v = ov.swizzle.xzzy;
            Assert.That("((8-3)-9)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-9-3)", "((6-1)4)", "-7");
            var v = ov.swizzle.xzzz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((6-1)4)", Is.EqualTo(v.y));
            Assert.That("((6-1)4)", Is.EqualTo(v.z));
            Assert.That("((6-1)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-8)3)", "(-60)", "(-65)", "((-5-6)6)");
            var v = ov.swizzle.xzzw;
            Assert.That("((0-8)3)", Is.EqualTo(v.x));
            Assert.That("(-65)", Is.EqualTo(v.y));
            Assert.That("(-65)", Is.EqualTo(v.z));
            Assert.That("((-5-6)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(02)", "(62)", null, "-2");
            var v = ov.swizzle.xzw;
            Assert.That("(02)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("3", "7", "((-6-8)-6)", "((-28)6)");
            var v = ov.swizzle.xzwx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((-6-8)-6)", Is.EqualTo(v.y));
            Assert.That("((-28)6)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-3)2)", "(-55)", "-1", "((-45)-3)");
            var v = ov.swizzle.xzwy;
            Assert.That("((-4-3)2)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((-45)-3)", Is.EqualTo(v.z));
            Assert.That("(-55)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-62)-9)", "((5-1)9)", "-5", "");
            var v = ov.swizzle.xzwz;
            Assert.That("((-62)-9)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(00)", "((03)-1)", "(7-1)");
            var v = ov.swizzle.xzww;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((03)-1)", Is.EqualTo(v.y));
            Assert.That("(7-1)", Is.EqualTo(v.z));
            Assert.That("(7-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-68)5)", "((-21)-1)", "-9", "");
            var v = ov.swizzle.xw;
            Assert.That("((-68)5)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-7", "(08)", "", "((-94)0)");
            var v = ov.swizzle.xwx;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-94)0)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((8-5)-8)", "(8-3)", "((8-5)-8)", "1");
            var v = ov.swizzle.xwxx;
            Assert.That("((8-5)-8)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("((8-5)-8)", Is.EqualTo(v.z));
            Assert.That("((8-5)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-64)-9)", "(-79)", "-8");
            var v = ov.swizzle.xwxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-64)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "-7", "-4", "((-10)-7)");
            var v = ov.swizzle.xwxz;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-10)-7)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-7)", "((8-3)0)", "((4-7)2)", "((12)8)");
            var v = ov.swizzle.xwxw;
            Assert.That("(-6-7)", Is.EqualTo(v.x));
            Assert.That("((12)8)", Is.EqualTo(v.y));
            Assert.That("(-6-7)", Is.EqualTo(v.z));
            Assert.That("((12)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-57)-2)", "-1", "", "(-82)");
            var v = ov.swizzle.xwy;
            Assert.That("((-57)-2)", Is.EqualTo(v.x));
            Assert.That("(-82)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-63)", "6", "(-6-6)", "(-63)");
            var v = ov.swizzle.xwyx;
            Assert.That("(-63)", Is.EqualTo(v.x));
            Assert.That("(-63)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("(-63)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(44)", "-5", "(-27)", "(1-8)");
            var v = ov.swizzle.xwyy;
            Assert.That("(44)", Is.EqualTo(v.x));
            Assert.That("(1-8)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(34)", "4", "((-2-8)-9)", "(-9-3)");
            var v = ov.swizzle.xwyz;
            Assert.That("(34)", Is.EqualTo(v.x));
            Assert.That("(-9-3)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("((-2-8)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "-2", "7", "7");
            var v = ov.swizzle.xwyw;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "7", "(-8-1)", "0");
            var v = ov.swizzle.xwz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("(-8-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-61)2)", null, "-4", "(2-9)");
            var v = ov.swizzle.xwzx;
            Assert.That("((-61)2)", Is.EqualTo(v.x));
            Assert.That("(2-9)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("((-61)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((9-2)0)", null, "((-13)-8)");
            var v = ov.swizzle.xwzy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-13)-8)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((9-2)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(55)", "-9", "((4-1)-5)", "((-1-1)-5)");
            var v = ov.swizzle.xwzz;
            Assert.That("(55)", Is.EqualTo(v.x));
            Assert.That("((-1-1)-5)", Is.EqualTo(v.y));
            Assert.That("((4-1)-5)", Is.EqualTo(v.z));
            Assert.That("((4-1)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "2", "1", "(9-7)");
            var v = ov.swizzle.xwzw;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(9-7)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("(9-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-4-2)", "((-14)8)", "((-27)1)");
            var v = ov.swizzle.xww;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-27)1)", Is.EqualTo(v.y));
            Assert.That("((-27)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "5", "-3", "((3-4)2)");
            var v = ov.swizzle.xwwx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((3-4)2)", Is.EqualTo(v.y));
            Assert.That("((3-4)2)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "(-22)", "((09)3)");
            var v = ov.swizzle.xwwy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((09)3)", Is.EqualTo(v.y));
            Assert.That("((09)3)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-7)", "((-5-7)-5)", "", "-5");
            var v = ov.swizzle.xwwz;
            Assert.That("(-2-7)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-6)-4)", "-1", "", "6");
            var v = ov.swizzle.xwww;
            Assert.That("((-9-6)-4)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-6)", "(5-6)", "(-6-8)", "0");
            var v = ov.swizzle.yx;
            Assert.That("(5-6)", Is.EqualTo(v.x));
            Assert.That("(5-6)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("7", "((6-8)-2)", "9", "");
            var v = ov.swizzle.yxx;
            Assert.That("((6-8)-2)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-5-9)1)", "", "", null);
            var v = ov.swizzle.yxxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-5-9)1)", Is.EqualTo(v.y));
            Assert.That("((-5-9)1)", Is.EqualTo(v.z));
            Assert.That("((-5-9)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-25)", "-7", "(84)", "(84)");
            var v = ov.swizzle.yxxy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(-25)", Is.EqualTo(v.y));
            Assert.That("(-25)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-3)-9)", "((-6-1)-6)", "((-11)8)", "(-3-3)");
            var v = ov.swizzle.yxxz;
            Assert.That("((-6-1)-6)", Is.EqualTo(v.x));
            Assert.That("((-3-3)-9)", Is.EqualTo(v.y));
            Assert.That("((-3-3)-9)", Is.EqualTo(v.z));
            Assert.That("((-11)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-4)", "((-85)1)", "", "(-3-4)");
            var v = ov.swizzle.yxxw;
            Assert.That("((-85)1)", Is.EqualTo(v.x));
            Assert.That("(-3-4)", Is.EqualTo(v.y));
            Assert.That("(-3-4)", Is.EqualTo(v.z));
            Assert.That("(-3-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-12)-2)", "((-16)-6)", "((-12)-2)", "");
            var v = ov.swizzle.yxy;
            Assert.That("((-16)-6)", Is.EqualTo(v.x));
            Assert.That("((-12)-2)", Is.EqualTo(v.y));
            Assert.That("((-16)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-8-9)-4)", "(-69)", "(-69)", "(-69)");
            var v = ov.swizzle.yxyx;
            Assert.That("(-69)", Is.EqualTo(v.x));
            Assert.That("((-8-9)-4)", Is.EqualTo(v.y));
            Assert.That("(-69)", Is.EqualTo(v.z));
            Assert.That("((-8-9)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(05)", "-5", null, "((-38)-5)");
            var v = ov.swizzle.yxyy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("(05)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "8", "((-40)9)", null);
            var v = ov.swizzle.yxyz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((-40)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(3-9)", "3", "(3-9)", "3");
            var v = ov.swizzle.yxyw;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(3-9)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(8-2)", null, "(8-2)");
            var v = ov.swizzle.yxz;
            Assert.That("(8-2)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("4", "(83)", "-9", null);
            var v = ov.swizzle.yxzx;
            Assert.That("(83)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-2)-1)", "(-9-4)", "((42)3)", "3");
            var v = ov.swizzle.yxzy;
            Assert.That("(-9-4)", Is.EqualTo(v.x));
            Assert.That("((2-2)-1)", Is.EqualTo(v.y));
            Assert.That("((42)3)", Is.EqualTo(v.z));
            Assert.That("(-9-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-67)", "-5", "-6");
            var v = ov.swizzle.yxzz;
            Assert.That("(-67)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "", null, "(-5-7)");
            var v = ov.swizzle.yxzw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(-5-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-96)", "-2", "((-49)-4)", "((07)-1)");
            var v = ov.swizzle.yxw;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("(-96)", Is.EqualTo(v.y));
            Assert.That("((07)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, null, "((62)-1)", "(0-3)");
            var v = ov.swizzle.yxwx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(0-3)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "((-45)0)", "", "(6-5)");
            var v = ov.swizzle.yxwy;
            Assert.That("((-45)0)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("(6-5)", Is.EqualTo(v.z));
            Assert.That("((-45)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-7)7)", "", "1", "(-18)");
            var v = ov.swizzle.yxwz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((5-7)7)", Is.EqualTo(v.y));
            Assert.That("(-18)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((95)-1)", "(-8-6)", "", "3");
            var v = ov.swizzle.yxww;
            Assert.That("(-8-6)", Is.EqualTo(v.x));
            Assert.That("((95)-1)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((80)5)", "(-80)", "(-80)", "((80)5)");
            var v = ov.swizzle.yy;
            Assert.That("(-80)", Is.EqualTo(v.x));
            Assert.That("(-80)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((47)-3)", "(-3-5)", "-7", "-4");
            var v = ov.swizzle.yyx;
            Assert.That("(-3-5)", Is.EqualTo(v.x));
            Assert.That("(-3-5)", Is.EqualTo(v.y));
            Assert.That("((47)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("6", "(5-3)", "6", "");
            var v = ov.swizzle.yyxx;
            Assert.That("(5-3)", Is.EqualTo(v.x));
            Assert.That("(5-3)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(21)", "(7-7)", "5");
            var v = ov.swizzle.yyxy;
            Assert.That("(21)", Is.EqualTo(v.x));
            Assert.That("(21)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(21)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-9)-6)", "((42)-1)", "((73)3)", "(-22)");
            var v = ov.swizzle.yyxz;
            Assert.That("((42)-1)", Is.EqualTo(v.x));
            Assert.That("((42)-1)", Is.EqualTo(v.y));
            Assert.That("((3-9)-6)", Is.EqualTo(v.z));
            Assert.That("((73)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "(-1-9)", "", "-2");
            var v = ov.swizzle.yyxw;
            Assert.That("(-1-9)", Is.EqualTo(v.x));
            Assert.That("(-1-9)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-3)1)", "(-15)", "(5-8)", "4");
            var v = ov.swizzle.yyy;
            Assert.That("(-15)", Is.EqualTo(v.x));
            Assert.That("(-15)", Is.EqualTo(v.y));
            Assert.That("(-15)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-7-8)8)", "-3", "(92)", null);
            var v = ov.swizzle.yyyx;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("((-7-8)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(46)", "((-45)-1)", "((52)7)", "-5");
            var v = ov.swizzle.yyyy;
            Assert.That("((-45)-1)", Is.EqualTo(v.x));
            Assert.That("((-45)-1)", Is.EqualTo(v.y));
            Assert.That("((-45)-1)", Is.EqualTo(v.z));
            Assert.That("((-45)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((24)5)", "((42)2)", null, "-2");
            var v = ov.swizzle.yyyz;
            Assert.That("((42)2)", Is.EqualTo(v.x));
            Assert.That("((42)2)", Is.EqualTo(v.y));
            Assert.That("((42)2)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-4)4)", "((25)-5)", "(7-1)", null);
            var v = ov.swizzle.yyyw;
            Assert.That("((25)-5)", Is.EqualTo(v.x));
            Assert.That("((25)-5)", Is.EqualTo(v.y));
            Assert.That("((25)-5)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-5)7)", "6", "3", null);
            var v = ov.swizzle.yyz;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(49)", "((1-3)3)", "-2", "-2");
            var v = ov.swizzle.yyzx;
            Assert.That("((1-3)3)", Is.EqualTo(v.x));
            Assert.That("((1-3)3)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("(49)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-3)", "((6-4)-2)", "(87)", "((6-4)-2)");
            var v = ov.swizzle.yyzy;
            Assert.That("((6-4)-2)", Is.EqualTo(v.x));
            Assert.That("((6-4)-2)", Is.EqualTo(v.y));
            Assert.That("(87)", Is.EqualTo(v.z));
            Assert.That("((6-4)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-87)", "-7", "((97)1)", "((58)-9)");
            var v = ov.swizzle.yyzz;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((97)1)", Is.EqualTo(v.z));
            Assert.That("((97)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "", "6", "((44)-7)");
            var v = ov.swizzle.yyzw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("((44)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-71)", "-4", "-1", "-4");
            var v = ov.swizzle.yyw;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "((5-1)6)", "((64)3)", "((46)4)");
            var v = ov.swizzle.yywx;
            Assert.That("((5-1)6)", Is.EqualTo(v.x));
            Assert.That("((5-1)6)", Is.EqualTo(v.y));
            Assert.That("((46)4)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(4-1)", "(6-6)", "-2");
            var v = ov.swizzle.yywy;
            Assert.That("(4-1)", Is.EqualTo(v.x));
            Assert.That("(4-1)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("(4-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(78)", "-1", "2", "(7-5)");
            var v = ov.swizzle.yywz;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(7-5)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((62)-6)", "", "-3", null);
            var v = ov.swizzle.yyww;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "4", null, "8");
            var v = ov.swizzle.yz;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>(null, "", "(-99)", null);
            var v = ov.swizzle.yzx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-99)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-40)4)", "-8", "-2", "((30)-4)");
            var v = ov.swizzle.yzxx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((-40)4)", Is.EqualTo(v.z));
            Assert.That("((-40)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-6)", "9", "-1", "(-28)");
            var v = ov.swizzle.yzxy;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(1-6)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "0", "(83)", "");
            var v = ov.swizzle.yzxz;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(83)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("(83)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-48)", "0", "((22)4)", "(6-7)");
            var v = ov.swizzle.yzxw;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((22)4)", Is.EqualTo(v.y));
            Assert.That("(-48)", Is.EqualTo(v.z));
            Assert.That("(6-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-9)-6)", "-7", "(19)", "-7");
            var v = ov.swizzle.yzy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(19)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-5-8)", "((-6-4)-5)", "-1", "2");
            var v = ov.swizzle.yzyx;
            Assert.That("((-6-4)-5)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((-6-4)-5)", Is.EqualTo(v.z));
            Assert.That("(-5-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-1", "", "8");
            var v = ov.swizzle.yzyy;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-5)", "", "-4", "");
            var v = ov.swizzle.yzyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((6-5)-4)", "((7-2)3)", "((6-5)-4)", "(62)");
            var v = ov.swizzle.yzyw;
            Assert.That("((7-2)3)", Is.EqualTo(v.x));
            Assert.That("((6-5)-4)", Is.EqualTo(v.y));
            Assert.That("((7-2)3)", Is.EqualTo(v.z));
            Assert.That("(62)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-5)", "((-62)-3)", null, "-3");
            var v = ov.swizzle.yzz;
            Assert.That("((-62)-3)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("3", "3", "((-8-2)8)", "(1-5)");
            var v = ov.swizzle.yzzx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((-8-2)8)", Is.EqualTo(v.y));
            Assert.That("((-8-2)8)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-6)8)", "((34)-6)", "(-49)", "((0-6)8)");
            var v = ov.swizzle.yzzy;
            Assert.That("((34)-6)", Is.EqualTo(v.x));
            Assert.That("(-49)", Is.EqualTo(v.y));
            Assert.That("(-49)", Is.EqualTo(v.z));
            Assert.That("((34)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "((-7-2)5)", "(3-5)", "((55)-2)");
            var v = ov.swizzle.yzzz;
            Assert.That("((-7-2)5)", Is.EqualTo(v.x));
            Assert.That("(3-5)", Is.EqualTo(v.y));
            Assert.That("(3-5)", Is.EqualTo(v.z));
            Assert.That("(3-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(-47)", "((10)-4)", "-7");
            var v = ov.swizzle.yzzw;
            Assert.That("(-47)", Is.EqualTo(v.x));
            Assert.That("((10)-4)", Is.EqualTo(v.y));
            Assert.That("((10)-4)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(73)", "((-17)5)", "3", "((6-7)5)");
            var v = ov.swizzle.yzw;
            Assert.That("((-17)5)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((6-7)5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "((94)1)", "((-49)1)", "((6-3)3)");
            var v = ov.swizzle.yzwx;
            Assert.That("((94)1)", Is.EqualTo(v.x));
            Assert.That("((-49)1)", Is.EqualTo(v.y));
            Assert.That("((6-3)3)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(93)", "((63)-3)", "", "((63)-3)");
            var v = ov.swizzle.yzwy;
            Assert.That("((63)-3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((63)-3)", Is.EqualTo(v.z));
            Assert.That("((63)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "-5", "((-16)6)", "-5");
            var v = ov.swizzle.yzwz;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("((-16)6)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("((-16)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "((0-9)5)", "(-36)", "7");
            var v = ov.swizzle.yzww;
            Assert.That("((0-9)5)", Is.EqualTo(v.x));
            Assert.That("(-36)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(73)", "3", "3", "((8-6)0)");
            var v = ov.swizzle.yw;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((8-6)0)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("", "7", "(-59)", "(-70)");
            var v = ov.swizzle.ywx;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(-70)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((3-7)-1)", "-8", "(15)", "((3-7)-1)");
            var v = ov.swizzle.ywxx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((3-7)-1)", Is.EqualTo(v.y));
            Assert.That("((3-7)-1)", Is.EqualTo(v.z));
            Assert.That("((3-7)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(61)", "2", "8");
            var v = ov.swizzle.ywxy;
            Assert.That("(61)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(61)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "((-15)-9)", "(17)", "((-6-7)4)");
            var v = ov.swizzle.ywxz;
            Assert.That("((-15)-9)", Is.EqualTo(v.x));
            Assert.That("((-6-7)4)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("(17)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((-42)6)", "(-2-2)", "-7");
            var v = ov.swizzle.ywxw;
            Assert.That("((-42)6)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "-9", "((2-9)-8)", "(-72)");
            var v = ov.swizzle.ywy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("(-72)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-37)3)", "7", "6", "(6-3)");
            var v = ov.swizzle.ywyx;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(6-3)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((-37)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(-84)", "(-84)", "-3");
            var v = ov.swizzle.ywyy;
            Assert.That("(-84)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(-84)", Is.EqualTo(v.z));
            Assert.That("(-84)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(-4-6)", "5", "(4-9)");
            var v = ov.swizzle.ywyz;
            Assert.That("(-4-6)", Is.EqualTo(v.x));
            Assert.That("(4-9)", Is.EqualTo(v.y));
            Assert.That("(-4-6)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((1-8)-5)", "-2", "((1-8)-5)");
            var v = ov.swizzle.ywyw;
            Assert.That("((1-8)-5)", Is.EqualTo(v.x));
            Assert.That("((1-8)-5)", Is.EqualTo(v.y));
            Assert.That("((1-8)-5)", Is.EqualTo(v.z));
            Assert.That("((1-8)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "((55)-5)", "((0-8)9)", "(63)");
            var v = ov.swizzle.ywz;
            Assert.That("((55)-5)", Is.EqualTo(v.x));
            Assert.That("(63)", Is.EqualTo(v.y));
            Assert.That("((0-8)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-2", "(-3-6)", null, "((-39)6)");
            var v = ov.swizzle.ywzx;
            Assert.That("(-3-6)", Is.EqualTo(v.x));
            Assert.That("((-39)6)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-2)-2)", "-5", "7", "");
            var v = ov.swizzle.ywzy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "-9", "(-98)", "((72)1)");
            var v = ov.swizzle.ywzz;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((72)1)", Is.EqualTo(v.y));
            Assert.That("(-98)", Is.EqualTo(v.z));
            Assert.That("(-98)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-5)", "(-26)", "", "-6");
            var v = ov.swizzle.ywzw;
            Assert.That("(-26)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-1)5)", "-3", "(-2-4)", "((-6-1)1)");
            var v = ov.swizzle.yww;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("((-6-1)1)", Is.EqualTo(v.y));
            Assert.That("((-6-1)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "5", null, "(3-2)");
            var v = ov.swizzle.ywwx;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(3-2)", Is.EqualTo(v.y));
            Assert.That("(3-2)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "", "(-18)", "(4-8)");
            var v = ov.swizzle.ywwy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(4-8)", Is.EqualTo(v.y));
            Assert.That("(4-8)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((73)-9)", "(-82)", null, "((7-9)7)");
            var v = ov.swizzle.ywwz;
            Assert.That("(-82)", Is.EqualTo(v.x));
            Assert.That("((7-9)7)", Is.EqualTo(v.y));
            Assert.That("((7-9)7)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-2)", "(-86)", "((-80)-1)", "((-78)-6)");
            var v = ov.swizzle.ywww;
            Assert.That("(-86)", Is.EqualTo(v.x));
            Assert.That("((-78)-6)", Is.EqualTo(v.y));
            Assert.That("((-78)-6)", Is.EqualTo(v.z));
            Assert.That("((-78)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-6)2)", "2", "-2", "((2-6)-4)");
            var v = ov.swizzle.zx;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((9-6)2)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-21)", "8", "8", null);
            var v = ov.swizzle.zxx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(-21)", Is.EqualTo(v.y));
            Assert.That("(-21)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "", "(12)", null);
            var v = ov.swizzle.zxxx;
            Assert.That("(12)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-33)", "((-3-5)-3)", "-7", "(-15)");
            var v = ov.swizzle.zxxy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(-33)", Is.EqualTo(v.y));
            Assert.That("(-33)", Is.EqualTo(v.z));
            Assert.That("((-3-5)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-3)", "(81)", "-2", "-2");
            var v = ov.swizzle.zxxz;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("(9-3)", Is.EqualTo(v.y));
            Assert.That("(9-3)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "-4", "(-6-6)", "(9-1)");
            var v = ov.swizzle.zxxw;
            Assert.That("(-6-6)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("(9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-6-3)", "(-6-3)", "4");
            var v = ov.swizzle.zxy;
            Assert.That("(-6-3)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(-6-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("1", "-6", "(13)", "1");
            var v = ov.swizzle.zxyx;
            Assert.That("(13)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-9)0)", "-3", "(-26)", "(-2-4)");
            var v = ov.swizzle.zxyy;
            Assert.That("(-26)", Is.EqualTo(v.x));
            Assert.That("((5-9)0)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "2", "(-9-6)", "(92)");
            var v = ov.swizzle.zxyz;
            Assert.That("(-9-6)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("(-9-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(77)", "9", "", "");
            var v = ov.swizzle.zxyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(77)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "", "9", "");
            var v = ov.swizzle.zxz;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-54)", null, "-4", "((59)-9)");
            var v = ov.swizzle.zxzx;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(-54)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(-54)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "2", "((-95)0)", "");
            var v = ov.swizzle.zxzy;
            Assert.That("((-95)0)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("((-95)0)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(25)", "7", "((-55)8)", "((-27)-2)");
            var v = ov.swizzle.zxzz;
            Assert.That("((-55)8)", Is.EqualTo(v.x));
            Assert.That("(25)", Is.EqualTo(v.y));
            Assert.That("((-55)8)", Is.EqualTo(v.z));
            Assert.That("((-55)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-3)-1)", "((20)6)", "", "7");
            var v = ov.swizzle.zxzw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-1-3)-1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(74)", "", "(-23)", null);
            var v = ov.swizzle.zxw;
            Assert.That("(-23)", Is.EqualTo(v.x));
            Assert.That("(74)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(28)", "2", null, "(-5-1)");
            var v = ov.swizzle.zxwx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(28)", Is.EqualTo(v.y));
            Assert.That("(-5-1)", Is.EqualTo(v.z));
            Assert.That("(28)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-4)", "0", "((-9-3)-3)", "");
            var v = ov.swizzle.zxwy;
            Assert.That("((-9-3)-3)", Is.EqualTo(v.x));
            Assert.That("(-3-4)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "((80)2)", "2", "(9-2)");
            var v = ov.swizzle.zxwz;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(9-2)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "(68)", "((-1-8)4)", "-7");
            var v = ov.swizzle.zxww;
            Assert.That("((-1-8)4)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-4)", "", "-3", "((2-6)-6)");
            var v = ov.swizzle.zy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("1", "(-8-7)", "(-8-9)", "((-36)0)");
            var v = ov.swizzle.zyx;
            Assert.That("(-8-9)", Is.EqualTo(v.x));
            Assert.That("(-8-7)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("7", "6", "", "7");
            var v = ov.swizzle.zyxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", null, "-1", "");
            var v = ov.swizzle.zyxy;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "", "(-10)", "-4");
            var v = ov.swizzle.zyxz;
            Assert.That("(-10)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(-10)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(21)", "-3", "(-65)", "3");
            var v = ov.swizzle.zyxw;
            Assert.That("(-65)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(21)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "8", "((63)8)", "((63)8)");
            var v = ov.swizzle.zyy;
            Assert.That("((63)8)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-45)", "-6", "(-45)", "((-3-4)1)");
            var v = ov.swizzle.zyyx;
            Assert.That("(-45)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("(-45)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-27)", "", "(81)");
            var v = ov.swizzle.zyyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-27)", Is.EqualTo(v.y));
            Assert.That("(-27)", Is.EqualTo(v.z));
            Assert.That("(-27)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-1)", "(8-1)", "(-9-9)", "((-8-5)0)");
            var v = ov.swizzle.zyyz;
            Assert.That("(-9-9)", Is.EqualTo(v.x));
            Assert.That("(8-1)", Is.EqualTo(v.y));
            Assert.That("(8-1)", Is.EqualTo(v.z));
            Assert.That("(-9-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", null, "(-8-9)", "(17)");
            var v = ov.swizzle.zyyw;
            Assert.That("(-8-9)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(17)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "(-9-9)", "(-9-9)", "(-9-9)");
            var v = ov.swizzle.zyz;
            Assert.That("(-9-9)", Is.EqualTo(v.x));
            Assert.That("(-9-9)", Is.EqualTo(v.y));
            Assert.That("(-9-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("9", "((-93)9)", "(-75)", "(-26)");
            var v = ov.swizzle.zyzx;
            Assert.That("(-75)", Is.EqualTo(v.x));
            Assert.That("((-93)9)", Is.EqualTo(v.y));
            Assert.That("(-75)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", null, "((81)-5)", "-9");
            var v = ov.swizzle.zyzy;
            Assert.That("((81)-5)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((81)-5)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-61)3)", "", "6", "(62)");
            var v = ov.swizzle.zyzz;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-4)-7)", "((4-4)-7)", "(-92)", "6");
            var v = ov.swizzle.zyzw;
            Assert.That("(-92)", Is.EqualTo(v.x));
            Assert.That("((4-4)-7)", Is.EqualTo(v.y));
            Assert.That("(-92)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-3)8)", null, "", "-2");
            var v = ov.swizzle.zyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(76)", "((45)5)", "(76)", "(04)");
            var v = ov.swizzle.zywx;
            Assert.That("(76)", Is.EqualTo(v.x));
            Assert.That("((45)5)", Is.EqualTo(v.y));
            Assert.That("(04)", Is.EqualTo(v.z));
            Assert.That("(76)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "", "(80)", "((6-4)-7)");
            var v = ov.swizzle.zywy;
            Assert.That("(80)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((6-4)-7)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-58)", "5", "8", null);
            var v = ov.swizzle.zywz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-3", "7", "");
            var v = ov.swizzle.zyww;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-8)1)", "-8", "(-63)", "-8");
            var v = ov.swizzle.zz;
            Assert.That("(-63)", Is.EqualTo(v.x));
            Assert.That("(-63)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-89)-8)", "8", "((4-7)5)", "8");
            var v = ov.swizzle.zzx;
            Assert.That("((4-7)5)", Is.EqualTo(v.x));
            Assert.That("((4-7)5)", Is.EqualTo(v.y));
            Assert.That("((-89)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(01)", "-7", "", "6");
            var v = ov.swizzle.zzxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(01)", Is.EqualTo(v.z));
            Assert.That("(01)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-6)-2)", "", "", "-8");
            var v = ov.swizzle.zzxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-2-6)-2)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((90)-2)", "((90)-2)", "-4", "(-1-9)");
            var v = ov.swizzle.zzxz;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((90)-2)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-6)-9)", "6", "(3-1)", "-3");
            var v = ov.swizzle.zzxw;
            Assert.That("(3-1)", Is.EqualTo(v.x));
            Assert.That("(3-1)", Is.EqualTo(v.y));
            Assert.That("((1-6)-9)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((00)-4)", "4", "((00)-4)", "");
            var v = ov.swizzle.zzy;
            Assert.That("((00)-4)", Is.EqualTo(v.x));
            Assert.That("((00)-4)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((46)-5)", "0", "0", "");
            var v = ov.swizzle.zzyx;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("((46)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-6)1)", "(-4-2)", "", "((6-6)2)");
            var v = ov.swizzle.zzyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-4-2)", Is.EqualTo(v.z));
            Assert.That("(-4-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-6)4)", "(35)", "((-53)-6)", "((-2-6)4)");
            var v = ov.swizzle.zzyz;
            Assert.That("((-53)-6)", Is.EqualTo(v.x));
            Assert.That("((-53)-6)", Is.EqualTo(v.y));
            Assert.That("(35)", Is.EqualTo(v.z));
            Assert.That("((-53)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-5)", "((-39)-1)", null, "((-39)-1)");
            var v = ov.swizzle.zzyw;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-39)-1)", Is.EqualTo(v.z));
            Assert.That("((-39)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "5", "(-30)", "((94)-1)");
            var v = ov.swizzle.zzz;
            Assert.That("(-30)", Is.EqualTo(v.x));
            Assert.That("(-30)", Is.EqualTo(v.y));
            Assert.That("(-30)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-3", "(78)", "-7", "-3");
            var v = ov.swizzle.zzzx;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((-1-1)-6)", "2", "2");
            var v = ov.swizzle.zzzy;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("((-1-1)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "9", "(92)", "(-78)");
            var v = ov.swizzle.zzzz;
            Assert.That("(92)", Is.EqualTo(v.x));
            Assert.That("(92)", Is.EqualTo(v.y));
            Assert.That("(92)", Is.EqualTo(v.z));
            Assert.That("(92)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "(8-6)", "(8-6)", "(8-6)");
            var v = ov.swizzle.zzzw;
            Assert.That("(8-6)", Is.EqualTo(v.x));
            Assert.That("(8-6)", Is.EqualTo(v.y));
            Assert.That("(8-6)", Is.EqualTo(v.z));
            Assert.That("(8-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(22)", "8", "6", "(0-4)");
            var v = ov.swizzle.zzw;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(0-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "(-24)", "", "1");
            var v = ov.swizzle.zzwx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-2)", "9", "((-58)-5)", null);
            var v = ov.swizzle.zzwy;
            Assert.That("((-58)-5)", Is.EqualTo(v.x));
            Assert.That("((-58)-5)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-9)", "(5-1)", null, "(-29)");
            var v = ov.swizzle.zzwz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(-29)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((57)0)", "((-8-6)7)", "(49)", "(49)");
            var v = ov.swizzle.zzww;
            Assert.That("(49)", Is.EqualTo(v.x));
            Assert.That("(49)", Is.EqualTo(v.y));
            Assert.That("(49)", Is.EqualTo(v.z));
            Assert.That("(49)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((54)-7)", "-4", "(-76)", "(75)");
            var v = ov.swizzle.zw;
            Assert.That("(-76)", Is.EqualTo(v.x));
            Assert.That("(75)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-20)7)", "((-4-9)2)", null, "-7");
            var v = ov.swizzle.zwx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((-20)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((64)-8)", "(-25)", "6", "7");
            var v = ov.swizzle.zwxx;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("((64)-8)", Is.EqualTo(v.z));
            Assert.That("((64)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "(09)", null, "((-8-6)-3)");
            var v = ov.swizzle.zwxy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-8-6)-3)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("(09)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "(-97)", null, "(-97)");
            var v = ov.swizzle.zwxz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-97)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-13)2)", "(-16)", "", "(-54)");
            var v = ov.swizzle.zwxw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-54)", Is.EqualTo(v.y));
            Assert.That("((-13)2)", Is.EqualTo(v.z));
            Assert.That("(-54)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-4)-8)", "2", "", "((-4-4)-8)");
            var v = ov.swizzle.zwy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-4-4)-8)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((46)2)", "((52)7)", "(72)", "((52)7)");
            var v = ov.swizzle.zwyx;
            Assert.That("(72)", Is.EqualTo(v.x));
            Assert.That("((52)7)", Is.EqualTo(v.y));
            Assert.That("((52)7)", Is.EqualTo(v.z));
            Assert.That("((46)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-7)", "(0-7)", "(65)", "-1");
            var v = ov.swizzle.zwyy;
            Assert.That("(65)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(0-7)", Is.EqualTo(v.z));
            Assert.That("(0-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-1)", "-1", "(6-6)", "-5");
            var v = ov.swizzle.zwyz;
            Assert.That("(6-6)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("(6-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "0", "", "");
            var v = ov.swizzle.zwyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-5)", "((94)8)", "((0-2)-1)", "((94)8)");
            var v = ov.swizzle.zwz;
            Assert.That("((0-2)-1)", Is.EqualTo(v.x));
            Assert.That("((94)8)", Is.EqualTo(v.y));
            Assert.That("((0-2)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((11)8)", "((-97)1)", "-8", "");
            var v = ov.swizzle.zwzx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("((11)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((-30)-6)", null, "-1");
            var v = ov.swizzle.zwzy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((-30)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "", "(3-9)", "((-5-5)9)");
            var v = ov.swizzle.zwzz;
            Assert.That("(3-9)", Is.EqualTo(v.x));
            Assert.That("((-5-5)9)", Is.EqualTo(v.y));
            Assert.That("(3-9)", Is.EqualTo(v.z));
            Assert.That("(3-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-96)", "(-85)", "");
            var v = ov.swizzle.zwzw;
            Assert.That("(-85)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-85)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "1", "((5-5)-7)", "1");
            var v = ov.swizzle.zww;
            Assert.That("((5-5)-7)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((18)-7)", "(52)", "((18)-7)", "-1");
            var v = ov.swizzle.zwwx;
            Assert.That("((18)-7)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("((18)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-9)-3)", "(-59)", "(-59)", "((18)-5)");
            var v = ov.swizzle.zwwy;
            Assert.That("(-59)", Is.EqualTo(v.x));
            Assert.That("((18)-5)", Is.EqualTo(v.y));
            Assert.That("((18)-5)", Is.EqualTo(v.z));
            Assert.That("(-59)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "((-27)6)", "((68)4)", "((8-7)-3)");
            var v = ov.swizzle.zwwz;
            Assert.That("((68)4)", Is.EqualTo(v.x));
            Assert.That("((8-7)-3)", Is.EqualTo(v.y));
            Assert.That("((8-7)-3)", Is.EqualTo(v.z));
            Assert.That("((68)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(41)", "((95)2)", "(-56)");
            var v = ov.swizzle.zwww;
            Assert.That("((95)2)", Is.EqualTo(v.x));
            Assert.That("(-56)", Is.EqualTo(v.y));
            Assert.That("(-56)", Is.EqualTo(v.z));
            Assert.That("(-56)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-9)-6)", "(-57)", "(-7-9)", "(37)");
            var v = ov.swizzle.wx;
            Assert.That("(37)", Is.EqualTo(v.x));
            Assert.That("((4-9)-6)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("6", "(-7-2)", "", null);
            var v = ov.swizzle.wxx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((9-2)-3)", "-3", "(56)", "-6");
            var v = ov.swizzle.wxxx;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((9-2)-3)", Is.EqualTo(v.y));
            Assert.That("((9-2)-3)", Is.EqualTo(v.z));
            Assert.That("((9-2)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "(12)", "(12)", "(61)");
            var v = ov.swizzle.wxxy;
            Assert.That("(61)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(12)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((92)-8)", null, null, "(-43)");
            var v = ov.swizzle.wxxz;
            Assert.That("(-43)", Is.EqualTo(v.x));
            Assert.That("((92)-8)", Is.EqualTo(v.y));
            Assert.That("((92)-8)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((49)-5)", "((-18)-5)", "0", "");
            var v = ov.swizzle.wxxw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((49)-5)", Is.EqualTo(v.y));
            Assert.That("((49)-5)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-1)7)", "-1", "9", "9");
            var v = ov.swizzle.wxy;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((5-1)7)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", null, "(66)", "7");
            var v = ov.swizzle.wxyx;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(-9-1)", "((-5-1)-2)", "((-5-1)-2)");
            var v = ov.swizzle.wxyy;
            Assert.That("((-5-1)-2)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(-9-1)", Is.EqualTo(v.z));
            Assert.That("(-9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-96)", "-9", "(8-5)", null);
            var v = ov.swizzle.wxyz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-96)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("(8-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-7)", "8", "((-84)4)", "((-84)4)");
            var v = ov.swizzle.wxyw;
            Assert.That("((-84)4)", Is.EqualTo(v.x));
            Assert.That("(-1-7)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((-84)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-7)", "3", "3", "-6");
            var v = ov.swizzle.wxz;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("(2-7)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((36)-6)", "((4-5)3)", "(-1-3)", "5");
            var v = ov.swizzle.wxzx;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("((36)-6)", Is.EqualTo(v.y));
            Assert.That("(-1-3)", Is.EqualTo(v.z));
            Assert.That("((36)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "8", "(33)", "(33)");
            var v = ov.swizzle.wxzy;
            Assert.That("(33)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("(33)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-21)", "-9", "((9-6)-2)");
            var v = ov.swizzle.wxzz;
            Assert.That("((9-6)-2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(-9-7)", "(-9-7)", "(03)");
            var v = ov.swizzle.wxzw;
            Assert.That("(03)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(-9-7)", Is.EqualTo(v.z));
            Assert.That("(03)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", null, "", "((-2-5)3)");
            var v = ov.swizzle.wxw;
            Assert.That("((-2-5)3)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((-2-5)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-1-1)", "(49)", "4", "((-9-1)5)");
            var v = ov.swizzle.wxwx;
            Assert.That("((-9-1)5)", Is.EqualTo(v.x));
            Assert.That("(-1-1)", Is.EqualTo(v.y));
            Assert.That("((-9-1)5)", Is.EqualTo(v.z));
            Assert.That("(-1-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-39)", "", "((-69)8)");
            var v = ov.swizzle.wxwy;
            Assert.That("((-69)8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-69)8)", Is.EqualTo(v.z));
            Assert.That("(-39)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(-78)", "", "9");
            var v = ov.swizzle.wxwz;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-99)0)", "(29)", "(-74)", "((-99)0)");
            var v = ov.swizzle.wxww;
            Assert.That("((-99)0)", Is.EqualTo(v.x));
            Assert.That("((-99)0)", Is.EqualTo(v.y));
            Assert.That("((-99)0)", Is.EqualTo(v.z));
            Assert.That("((-99)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-8)", "(-1-8)", "(60)", "7");
            var v = ov.swizzle.wy;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(-1-8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-62)2)", "(-92)", "((-13)8)", "0");
            var v = ov.swizzle.wyx;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(-92)", Is.EqualTo(v.y));
            Assert.That("((-62)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-40)", "(-40)", "", "((62)-8)");
            var v = ov.swizzle.wyxx;
            Assert.That("((62)-8)", Is.EqualTo(v.x));
            Assert.That("(-40)", Is.EqualTo(v.y));
            Assert.That("(-40)", Is.EqualTo(v.z));
            Assert.That("(-40)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-5)", "-5", "-9", "-9");
            var v = ov.swizzle.wyxy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(4-5)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((32)-9)", "", "((60)-6)", "5");
            var v = ov.swizzle.wyxz;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((32)-9)", Is.EqualTo(v.z));
            Assert.That("((60)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-54)", null, "((03)1)", "-2");
            var v = ov.swizzle.wyxw;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(-54)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-3", "", "(2-2)");
            var v = ov.swizzle.wyy;
            Assert.That("(2-2)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(68)", "", "-8");
            var v = ov.swizzle.wyyx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(68)", Is.EqualTo(v.y));
            Assert.That("(68)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "4", "", "4");
            var v = ov.swizzle.wyyy;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "8", "((54)-4)", "8");
            var v = ov.swizzle.wyyz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((54)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-3)", "(83)", "((-5-3)-6)", "");
            var v = ov.swizzle.wyyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(83)", Is.EqualTo(v.y));
            Assert.That("(83)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", null, "4", "(-9-5)");
            var v = ov.swizzle.wyz;
            Assert.That("(-9-5)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("3", null, "(-3-3)", "-1");
            var v = ov.swizzle.wyzx;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(-3-3)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-8)-3)", "(26)", "0", "0");
            var v = ov.swizzle.wyzy;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(26)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("(26)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-6)0)", "5", "((-9-6)0)", "1");
            var v = ov.swizzle.wyzz;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("((-9-6)0)", Is.EqualTo(v.z));
            Assert.That("((-9-6)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-7", "", "-7");
            var v = ov.swizzle.wyzw;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((52)-6)", "", "8", "-7");
            var v = ov.swizzle.wyw;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((7-7)-9)", "((7-7)-9)", "((-36)7)", "((-39)1)");
            var v = ov.swizzle.wywx;
            Assert.That("((-39)1)", Is.EqualTo(v.x));
            Assert.That("((7-7)-9)", Is.EqualTo(v.y));
            Assert.That("((-39)1)", Is.EqualTo(v.z));
            Assert.That("((7-7)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "((73)-9)", "", "((73)-9)");
            var v = ov.swizzle.wywy;
            Assert.That("((73)-9)", Is.EqualTo(v.x));
            Assert.That("((73)-9)", Is.EqualTo(v.y));
            Assert.That("((73)-9)", Is.EqualTo(v.z));
            Assert.That("((73)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "(-53)", "(1-9)");
            var v = ov.swizzle.wywz;
            Assert.That("(1-9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(1-9)", Is.EqualTo(v.z));
            Assert.That("(-53)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(37)", "(-92)", "(37)", null);
            var v = ov.swizzle.wyww;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-92)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "(-62)", "3", "4");
            var v = ov.swizzle.wz;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((68)7)", "(5-3)", null, "-8");
            var v = ov.swizzle.wzx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((68)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("9", null, "(98)", "9");
            var v = ov.swizzle.wzxx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(98)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(35)", "-3", "((5-3)4)");
            var v = ov.swizzle.wzxy;
            Assert.That("((5-3)4)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(35)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(72)", "(72)", "((94)-7)");
            var v = ov.swizzle.wzxz;
            Assert.That("((94)-7)", Is.EqualTo(v.x));
            Assert.That("(72)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(72)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "(3-6)", "(3-6)", "-6");
            var v = ov.swizzle.wzxw;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("(3-6)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-72)", "((4-7)-8)", "-7", "(36)");
            var v = ov.swizzle.wzy;
            Assert.That("(36)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((4-7)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-92)", "(-92)", "((-14)-7)", "-7");
            var v = ov.swizzle.wzyx;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-14)-7)", Is.EqualTo(v.y));
            Assert.That("(-92)", Is.EqualTo(v.z));
            Assert.That("(-92)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(-6-4)", "8", "-5");
            var v = ov.swizzle.wzyy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-6-4)", Is.EqualTo(v.z));
            Assert.That("(-6-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "(45)", "5", "6");
            var v = ov.swizzle.wzyz;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(45)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-9)3)", "((-6-9)3)", "(21)", null);
            var v = ov.swizzle.wzyw;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(21)", Is.EqualTo(v.y));
            Assert.That("((-6-9)3)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-5)-5)", "(-3-5)", "(85)", "((9-4)1)");
            var v = ov.swizzle.wzz;
            Assert.That("((9-4)1)", Is.EqualTo(v.x));
            Assert.That("(85)", Is.EqualTo(v.y));
            Assert.That("(85)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("6", "((86)-1)", null, "((86)-1)");
            var v = ov.swizzle.wzzx;
            Assert.That("((86)-1)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-96)", "((57)-5)", "((57)-5)", "(-55)");
            var v = ov.swizzle.wzzy;
            Assert.That("(-55)", Is.EqualTo(v.x));
            Assert.That("((57)-5)", Is.EqualTo(v.y));
            Assert.That("((57)-5)", Is.EqualTo(v.z));
            Assert.That("((57)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-5)", "(-31)", "(-31)", "(9-5)");
            var v = ov.swizzle.wzzz;
            Assert.That("(9-5)", Is.EqualTo(v.x));
            Assert.That("(-31)", Is.EqualTo(v.y));
            Assert.That("(-31)", Is.EqualTo(v.z));
            Assert.That("(-31)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "-2", "(-97)", "(75)");
            var v = ov.swizzle.wzzw;
            Assert.That("(75)", Is.EqualTo(v.x));
            Assert.That("(-97)", Is.EqualTo(v.y));
            Assert.That("(-97)", Is.EqualTo(v.z));
            Assert.That("(75)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-1", "-1", "(-18)");
            var v = ov.swizzle.wzw;
            Assert.That("(-18)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(-18)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-7-7)9)", "(8-2)", "(8-2)", "7");
            var v = ov.swizzle.wzwx;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(8-2)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((-7-7)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-2-5)5)", "-8", "-3");
            var v = ov.swizzle.wzwy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("((-2-5)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((4-8)-3)", "-1", "((4-8)-3)");
            var v = ov.swizzle.wzwz;
            Assert.That("((4-8)-3)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((4-8)-3)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((6-8)5)", "9", "(-66)", "4");
            var v = ov.swizzle.wzww;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("(-66)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", null, "(6-5)", "(00)");
            var v = ov.swizzle.ww;
            Assert.That("(00)", Is.EqualTo(v.x));
            Assert.That("(00)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-85)", "-5", "-3", "-3");
            var v = ov.swizzle.wwx;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(-85)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-8", "3", "3", "3");
            var v = ov.swizzle.wwxx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", null, "(78)", null);
            var v = ov.swizzle.wwxy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", null, "(-5-2)", "(-18)");
            var v = ov.swizzle.wwxz;
            Assert.That("(-18)", Is.EqualTo(v.x));
            Assert.That("(-18)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("(-5-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(-63)", "-8", "((-74)3)");
            var v = ov.swizzle.wwxw;
            Assert.That("((-74)3)", Is.EqualTo(v.x));
            Assert.That("((-74)3)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((-74)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-1)", "-7", "(-43)", "(-83)");
            var v = ov.swizzle.wwy;
            Assert.That("(-83)", Is.EqualTo(v.x));
            Assert.That("(-83)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-39)", "9", "(8-4)", "((-33)-1)");
            var v = ov.swizzle.wwyx;
            Assert.That("((-33)-1)", Is.EqualTo(v.x));
            Assert.That("((-33)-1)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("(-39)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-1)6)", "", "((-4-1)6)", "2");
            var v = ov.swizzle.wwyy;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-4)", "6", "8", "((-39)1)");
            var v = ov.swizzle.wwyz;
            Assert.That("((-39)1)", Is.EqualTo(v.x));
            Assert.That("((-39)1)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-11)6)", "((-11)6)", "(-70)", "(90)");
            var v = ov.swizzle.wwyw;
            Assert.That("(90)", Is.EqualTo(v.x));
            Assert.That("(90)", Is.EqualTo(v.y));
            Assert.That("((-11)6)", Is.EqualTo(v.z));
            Assert.That("(90)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "((0-5)-4)", "-6", "-1");
            var v = ov.swizzle.wwz;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("1", "(-3-3)", "9", "(99)");
            var v = ov.swizzle.wwzx;
            Assert.That("(99)", Is.EqualTo(v.x));
            Assert.That("(99)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((6-4)0)", "1", "((6-4)0)", "1");
            var v = ov.swizzle.wwzy;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("((6-4)0)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-8)8)", "7", "(-45)", null);
            var v = ov.swizzle.wwzz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(-45)", Is.EqualTo(v.z));
            Assert.That("(-45)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-55)2)", "((-55)2)", "", "(7-9)");
            var v = ov.swizzle.wwzw;
            Assert.That("(7-9)", Is.EqualTo(v.x));
            Assert.That("(7-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(7-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "-4", "", "((7-6)6)");
            var v = ov.swizzle.www;
            Assert.That("((7-6)6)", Is.EqualTo(v.x));
            Assert.That("((7-6)6)", Is.EqualTo(v.y));
            Assert.That("((7-6)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "3", "(19)", "(-55)");
            var v = ov.swizzle.wwwx;
            Assert.That("(-55)", Is.EqualTo(v.x));
            Assert.That("(-55)", Is.EqualTo(v.y));
            Assert.That("(-55)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, null, null, "(-4-3)");
            var v = ov.swizzle.wwwy;
            Assert.That("(-4-3)", Is.EqualTo(v.x));
            Assert.That("(-4-3)", Is.EqualTo(v.y));
            Assert.That("(-4-3)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-81)", "(-81)", "6", "((-4-9)-5)");
            var v = ov.swizzle.wwwz;
            Assert.That("((-4-9)-5)", Is.EqualTo(v.x));
            Assert.That("((-4-9)-5)", Is.EqualTo(v.y));
            Assert.That("((-4-9)-5)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-59)7)", "", "((-59)7)", "");
            var v = ov.swizzle.wwww;
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
            var ov = new gvec4<string>("-2", null, "(-3-1)", "((-5-6)1)");
            var v = ov.swizzle.rr;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-99)6)", "(-9-2)", "(-9-2)", "");
            var v = ov.swizzle.rrr;
            Assert.That("((-99)6)", Is.EqualTo(v.x));
            Assert.That("((-99)6)", Is.EqualTo(v.y));
            Assert.That("((-99)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((59)-5)", "-4", "0", "(-92)");
            var v = ov.swizzle.rrrr;
            Assert.That("((59)-5)", Is.EqualTo(v.x));
            Assert.That("((59)-5)", Is.EqualTo(v.y));
            Assert.That("((59)-5)", Is.EqualTo(v.z));
            Assert.That("((59)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-7)8)", null, "-3", "-3");
            var v = ov.swizzle.rrrg;
            Assert.That("((-2-7)8)", Is.EqualTo(v.x));
            Assert.That("((-2-7)8)", Is.EqualTo(v.y));
            Assert.That("((-2-7)8)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "(5-8)", "((-46)-7)", "((-7-7)-2)");
            var v = ov.swizzle.rrrb;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("((-46)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-6)", null, "(-7-6)", "");
            var v = ov.swizzle.rrra;
            Assert.That("(-7-6)", Is.EqualTo(v.x));
            Assert.That("(-7-6)", Is.EqualTo(v.y));
            Assert.That("(-7-6)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-1)-6)", "(-5-7)", "(23)", "(-5-7)");
            var v = ov.swizzle.rrg;
            Assert.That("((1-1)-6)", Is.EqualTo(v.x));
            Assert.That("((1-1)-6)", Is.EqualTo(v.y));
            Assert.That("(-5-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", null, "(-5-9)", "");
            var v = ov.swizzle.rrgr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-94)5)", "((-94)5)", "((-11)4)", "");
            var v = ov.swizzle.rrgg;
            Assert.That("((-94)5)", Is.EqualTo(v.x));
            Assert.That("((-94)5)", Is.EqualTo(v.y));
            Assert.That("((-94)5)", Is.EqualTo(v.z));
            Assert.That("((-94)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "(88)", "((-29)-7)", "((74)9)");
            var v = ov.swizzle.rrgb;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(88)", Is.EqualTo(v.z));
            Assert.That("((-29)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "-6", "6", "((-8-3)-5)");
            var v = ov.swizzle.rrga;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((-8-3)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-5-5)", "((30)0)", "(-6-7)");
            var v = ov.swizzle.rrb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((30)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-7", "(-67)", "(2-4)", "((9-5)6)");
            var v = ov.swizzle.rrbr;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(2-4)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-4)-4)", null, "((-4-8)-3)", "(-98)");
            var v = ov.swizzle.rrbg;
            Assert.That("((0-4)-4)", Is.EqualTo(v.x));
            Assert.That("((0-4)-4)", Is.EqualTo(v.y));
            Assert.That("((-4-8)-3)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-64)-3)", "-3", "((-64)-3)", "((-64)-3)");
            var v = ov.swizzle.rrbb;
            Assert.That("((-64)-3)", Is.EqualTo(v.x));
            Assert.That("((-64)-3)", Is.EqualTo(v.y));
            Assert.That("((-64)-3)", Is.EqualTo(v.z));
            Assert.That("((-64)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "((-10)-5)", "((-10)-5)", "7");
            var v = ov.swizzle.rrba;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("((-10)-5)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", null, "", "((-24)-2)");
            var v = ov.swizzle.rra;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-24)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((54)8)", "((54)8)", "(50)", "((09)-6)");
            var v = ov.swizzle.rrar;
            Assert.That("((54)8)", Is.EqualTo(v.x));
            Assert.That("((54)8)", Is.EqualTo(v.y));
            Assert.That("((09)-6)", Is.EqualTo(v.z));
            Assert.That("((54)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(25)", "(25)", "(7-9)");
            var v = ov.swizzle.rrag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(7-9)", Is.EqualTo(v.z));
            Assert.That("(25)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-6-1)-8)", null, "((1-5)-4)");
            var v = ov.swizzle.rrab;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((1-5)-4)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(-8-6)", "(8-7)", "(-30)");
            var v = ov.swizzle.rraa;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(-30)", Is.EqualTo(v.z));
            Assert.That("(-30)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "", "((58)-1)", "((-2-8)-1)");
            var v = ov.swizzle.rg;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((7-4)5)", "((71)-1)", "((7-4)5)", "(8-2)");
            var v = ov.swizzle.rgr;
            Assert.That("((7-4)5)", Is.EqualTo(v.x));
            Assert.That("((71)-1)", Is.EqualTo(v.y));
            Assert.That("((7-4)5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, null, "((29)-3)", "(-9-9)");
            var v = ov.swizzle.rgrr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-85)4)", "((-66)4)", "(-18)", "4");
            var v = ov.swizzle.rgrg;
            Assert.That("((-85)4)", Is.EqualTo(v.x));
            Assert.That("((-66)4)", Is.EqualTo(v.y));
            Assert.That("((-85)4)", Is.EqualTo(v.z));
            Assert.That("((-66)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((99)-1)", "(33)", "((-3-8)9)", "(-97)");
            var v = ov.swizzle.rgrb;
            Assert.That("((99)-1)", Is.EqualTo(v.x));
            Assert.That("(33)", Is.EqualTo(v.y));
            Assert.That("((99)-1)", Is.EqualTo(v.z));
            Assert.That("((-3-8)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "9", "9", "(97)");
            var v = ov.swizzle.rgra;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("(97)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(9-1)", "6", "((5-6)3)");
            var v = ov.swizzle.rgg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(9-1)", Is.EqualTo(v.y));
            Assert.That("(9-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("0", "(-48)", "6", null);
            var v = ov.swizzle.rggr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(-48)", Is.EqualTo(v.y));
            Assert.That("(-48)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((19)-1)", "-2", "((-27)-3)");
            var v = ov.swizzle.rggg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((19)-1)", Is.EqualTo(v.y));
            Assert.That("((19)-1)", Is.EqualTo(v.z));
            Assert.That("((19)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", null, "", "-7");
            var v = ov.swizzle.rggb;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-75)", "(-45)", "", "-9");
            var v = ov.swizzle.rgga;
            Assert.That("(-75)", Is.EqualTo(v.x));
            Assert.That("(-45)", Is.EqualTo(v.y));
            Assert.That("(-45)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(-12)", "(-12)", "-4");
            var v = ov.swizzle.rgb;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("(-12)", Is.EqualTo(v.y));
            Assert.That("(-12)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "((-76)-6)", "-8", "2");
            var v = ov.swizzle.rgbr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-76)-6)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((96)-1)", "8", "(64)", "(0-1)");
            var v = ov.swizzle.rgbg;
            Assert.That("((96)-1)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(64)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-2-1)8)", "(-99)", "-5");
            var v = ov.swizzle.rgbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-2-1)8)", Is.EqualTo(v.y));
            Assert.That("(-99)", Is.EqualTo(v.z));
            Assert.That("(-99)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-46)", "2", "", "((-50)0)");
            var v = ov.swizzle.rgba;
            Assert.That("(-46)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-50)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-2)4)", "1", "((-85)8)", "-5");
            var v = ov.swizzle.rga;
            Assert.That("((5-2)4)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(42)", "((57)0)", "((57)0)", "5");
            var v = ov.swizzle.rgar;
            Assert.That("(42)", Is.EqualTo(v.x));
            Assert.That("((57)0)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("(42)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-34)", "", "(4-1)", "-5");
            var v = ov.swizzle.rgag;
            Assert.That("(-34)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "((2-1)-6)", "((52)1)", "(10)");
            var v = ov.swizzle.rgab;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((2-1)-6)", Is.EqualTo(v.y));
            Assert.That("(10)", Is.EqualTo(v.z));
            Assert.That("((52)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(59)", null, "((-7-3)-5)", null);
            var v = ov.swizzle.rgaa;
            Assert.That("(59)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "7", "", "(-4-1)");
            var v = ov.swizzle.rb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>(null, "(-5-2)", "(-61)", "((-8-7)2)");
            var v = ov.swizzle.rbr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-61)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-4", "(60)", "(8-5)", "((-1-7)6)");
            var v = ov.swizzle.rbrr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(8-5)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "9", "(9-5)", "((-53)3)");
            var v = ov.swizzle.rbrg;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(9-5)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "(-96)", "-8", "-6");
            var v = ov.swizzle.rbrb;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-15)", "-8", "8", "-8");
            var v = ov.swizzle.rbra;
            Assert.That("(-15)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-15)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", null, "", "((7-4)3)");
            var v = ov.swizzle.rbg;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-85)", "((01)-3)", "(-62)", "(-46)");
            var v = ov.swizzle.rbgr;
            Assert.That("(-85)", Is.EqualTo(v.x));
            Assert.That("(-62)", Is.EqualTo(v.y));
            Assert.That("((01)-3)", Is.EqualTo(v.z));
            Assert.That("(-85)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-3)5)", "(60)", "3", "(2-1)");
            var v = ov.swizzle.rbgg;
            Assert.That("((3-3)5)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(60)", Is.EqualTo(v.z));
            Assert.That("(60)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "", "((-61)4)", "(-51)");
            var v = ov.swizzle.rbgb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-61)4)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-61)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-98)5)", null, "-7", "-9");
            var v = ov.swizzle.rbga;
            Assert.That("((-98)5)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "(15)", "0", "-3");
            var v = ov.swizzle.rbb;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(8-6)", "9", "((82)-5)", "2");
            var v = ov.swizzle.rbbr;
            Assert.That("(8-6)", Is.EqualTo(v.x));
            Assert.That("((82)-5)", Is.EqualTo(v.y));
            Assert.That("((82)-5)", Is.EqualTo(v.z));
            Assert.That("(8-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-5)8)", "(4-4)", "1", "((-7-5)8)");
            var v = ov.swizzle.rbbg;
            Assert.That("((-7-5)8)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("(4-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(05)", "((-75)8)", "", "8");
            var v = ov.swizzle.rbbb;
            Assert.That("(05)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-1)", "0", "(9-1)", "-8");
            var v = ov.swizzle.rbba;
            Assert.That("(9-1)", Is.EqualTo(v.x));
            Assert.That("(9-1)", Is.EqualTo(v.y));
            Assert.That("(9-1)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "9", "((-79)3)", "");
            var v = ov.swizzle.rba;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-79)3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-8", "(3-6)", "((-8-3)-1)", "(-5-9)");
            var v = ov.swizzle.rbar;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((-8-3)-1)", Is.EqualTo(v.y));
            Assert.That("(-5-9)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-3)", "(-2-3)", "9", "(83)");
            var v = ov.swizzle.rbag;
            Assert.That("(-2-3)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("(83)", Is.EqualTo(v.z));
            Assert.That("(-2-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-2)", "(4-2)", "8", "(4-2)");
            var v = ov.swizzle.rbab;
            Assert.That("(4-2)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(4-2)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", null, "1", "((-64)0)");
            var v = ov.swizzle.rbaa;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("((-64)0)", Is.EqualTo(v.z));
            Assert.That("((-64)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((17)-2)", "", "(8-3)", null);
            var v = ov.swizzle.ra;
            Assert.That("((17)-2)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("0", "((-23)-6)", "((-23)-6)", "((-52)7)");
            var v = ov.swizzle.rar;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((-52)7)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("8", "((-97)-2)", "8", null);
            var v = ov.swizzle.rarr;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-7)", "((-1-2)-8)", "((52)6)", "8");
            var v = ov.swizzle.rarg;
            Assert.That("(2-7)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(2-7)", Is.EqualTo(v.z));
            Assert.That("((-1-2)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-14)5)", "((1-4)-2)", "-7", "-7");
            var v = ov.swizzle.rarb;
            Assert.That("((-14)5)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((-14)5)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(1-1)", "9", "(-1-5)");
            var v = ov.swizzle.rara;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-1-5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-1-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-5)9)", "((4-1)-5)", "4", "((-5-3)8)");
            var v = ov.swizzle.rag;
            Assert.That("((-1-5)9)", Is.EqualTo(v.x));
            Assert.That("((-5-3)8)", Is.EqualTo(v.y));
            Assert.That("((4-1)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-64)", "-9", "-9", "(8-5)");
            var v = ov.swizzle.ragr;
            Assert.That("(-64)", Is.EqualTo(v.x));
            Assert.That("(8-5)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("(-64)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-2", "((-5-3)-4)", "7");
            var v = ov.swizzle.ragg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "((45)9)", "(-6-2)", "");
            var v = ov.swizzle.ragb;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((45)9)", Is.EqualTo(v.z));
            Assert.That("(-6-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", null, "(-16)", "((8-2)4)");
            var v = ov.swizzle.raga;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((8-2)4)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((8-2)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-8)", "((5-5)-1)", "2", "((5-5)-1)");
            var v = ov.swizzle.rab;
            Assert.That("(7-8)", Is.EqualTo(v.x));
            Assert.That("((5-5)-1)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("1", "((-2-6)1)", "((93)-8)", null);
            var v = ov.swizzle.rabr;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((93)-8)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((-8-6)-8)", "-3", "((-80)4)");
            var v = ov.swizzle.rabg;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((-80)4)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("((-8-6)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-1", "4", "4");
            var v = ov.swizzle.rabb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-2)", "((00)6)", "(32)", "(-3-2)");
            var v = ov.swizzle.raba;
            Assert.That("(-3-2)", Is.EqualTo(v.x));
            Assert.That("(-3-2)", Is.EqualTo(v.y));
            Assert.That("(32)", Is.EqualTo(v.z));
            Assert.That("(-3-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((48)-5)", "8", "(23)", "2");
            var v = ov.swizzle.raa;
            Assert.That("((48)-5)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "((41)2)", "((9-3)-1)", "(-6-3)");
            var v = ov.swizzle.raar;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-6-3)", Is.EqualTo(v.y));
            Assert.That("(-6-3)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-6)0)", "(8-2)", "((3-3)0)", "((3-3)0)");
            var v = ov.swizzle.raag;
            Assert.That("((-9-6)0)", Is.EqualTo(v.x));
            Assert.That("((3-3)0)", Is.EqualTo(v.y));
            Assert.That("((3-3)0)", Is.EqualTo(v.z));
            Assert.That("(8-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(72)", null, "(0-9)", "");
            var v = ov.swizzle.raab;
            Assert.That("(72)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(0-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "0", "((-94)-5)", null);
            var v = ov.swizzle.raaa;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", null, "-5", "((-72)5)");
            var v = ov.swizzle.gr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(6-7)", "5", "", "((11)-4)");
            var v = ov.swizzle.grr;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(6-7)", Is.EqualTo(v.y));
            Assert.That("(6-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "(-7-1)", "(-7-1)", "((87)2)");
            var v = ov.swizzle.grrr;
            Assert.That("(-7-1)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-1)", "", "(6-4)", "(66)");
            var v = ov.swizzle.grrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-9-1)", Is.EqualTo(v.y));
            Assert.That("(-9-1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-61)-3)", "5", "((-61)-3)", "(31)");
            var v = ov.swizzle.grrb;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("((-61)-3)", Is.EqualTo(v.y));
            Assert.That("((-61)-3)", Is.EqualTo(v.z));
            Assert.That("((-61)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-4-1)-6)", "", "-8");
            var v = ov.swizzle.grra;
            Assert.That("((-4-1)-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(78)", "-6", "(-1-4)", "((6-7)7)");
            var v = ov.swizzle.grg;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("(78)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", null, "((5-4)-9)", null);
            var v = ov.swizzle.grgr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "((-75)-1)", "", "(74)");
            var v = ov.swizzle.grgg;
            Assert.That("((-75)-1)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("((-75)-1)", Is.EqualTo(v.z));
            Assert.That("((-75)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-1-9)3)", "2", "6");
            var v = ov.swizzle.grgb;
            Assert.That("((-1-9)3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-1-9)3)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((-2-1)-4)", "9", "");
            var v = ov.swizzle.grga;
            Assert.That("((-2-1)-4)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("((-2-1)-4)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(07)", "(1-7)", "-1", "-1");
            var v = ov.swizzle.grb;
            Assert.That("(1-7)", Is.EqualTo(v.x));
            Assert.That("(07)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-6-9)-6)", "((-21)8)", "(-1-8)", "7");
            var v = ov.swizzle.grbr;
            Assert.That("((-21)8)", Is.EqualTo(v.x));
            Assert.That("((-6-9)-6)", Is.EqualTo(v.y));
            Assert.That("(-1-8)", Is.EqualTo(v.z));
            Assert.That("((-6-9)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "2", "((1-3)4)", "8");
            var v = ov.swizzle.grbg;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((1-3)4)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(33)", "((-5-1)1)", "((35)2)", "((35)2)");
            var v = ov.swizzle.grbb;
            Assert.That("((-5-1)1)", Is.EqualTo(v.x));
            Assert.That("(33)", Is.EqualTo(v.y));
            Assert.That("((35)2)", Is.EqualTo(v.z));
            Assert.That("((35)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((44)5)", "", "((-2-8)-9)", "(4-5)");
            var v = ov.swizzle.grba;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((44)5)", Is.EqualTo(v.y));
            Assert.That("((-2-8)-9)", Is.EqualTo(v.z));
            Assert.That("(4-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-3)", "(-99)", "-8", "");
            var v = ov.swizzle.gra;
            Assert.That("(-99)", Is.EqualTo(v.x));
            Assert.That("(2-3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(4-8)", "(4-8)", "1", null);
            var v = ov.swizzle.grar;
            Assert.That("(4-8)", Is.EqualTo(v.x));
            Assert.That("(4-8)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(4-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "-9", "(7-6)", "((-5-4)-3)");
            var v = ov.swizzle.grag;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("((-5-4)-3)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(-1-9)", null, "((-46)4)");
            var v = ov.swizzle.grab;
            Assert.That("(-1-9)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("((-46)4)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(03)", "-1", "(-97)", "((-9-4)9)");
            var v = ov.swizzle.graa;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("(03)", Is.EqualTo(v.y));
            Assert.That("((-9-4)9)", Is.EqualTo(v.z));
            Assert.That("((-9-4)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "((18)-7)", "(0-7)", "((18)-7)");
            var v = ov.swizzle.gg;
            Assert.That("((18)-7)", Is.EqualTo(v.x));
            Assert.That("((18)-7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-38)-8)", "", "6", null);
            var v = ov.swizzle.ggr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-38)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((9-6)-3)", "-3", "((-65)-7)", "(89)");
            var v = ov.swizzle.ggrr;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("((9-6)-3)", Is.EqualTo(v.z));
            Assert.That("((9-6)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-65)", "-6", "2", "(-65)");
            var v = ov.swizzle.ggrg;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(-65)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-88)", "(-88)", null, "(-88)");
            var v = ov.swizzle.ggrb;
            Assert.That("(-88)", Is.EqualTo(v.x));
            Assert.That("(-88)", Is.EqualTo(v.y));
            Assert.That("(-88)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "-3", "(19)", "-7");
            var v = ov.swizzle.ggra;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "0", "(39)", "((5-9)8)");
            var v = ov.swizzle.ggg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((48)-2)", "((48)-2)", "", "((-6-6)3)");
            var v = ov.swizzle.gggr;
            Assert.That("((48)-2)", Is.EqualTo(v.x));
            Assert.That("((48)-2)", Is.EqualTo(v.y));
            Assert.That("((48)-2)", Is.EqualTo(v.z));
            Assert.That("((48)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "", "", "(10)");
            var v = ov.swizzle.gggg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-98)-4)", "6", "-3", "((-98)-4)");
            var v = ov.swizzle.gggb;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", null, "((-4-8)4)", "-7");
            var v = ov.swizzle.ggga;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-5)", "", "((70)0)", "(66)");
            var v = ov.swizzle.ggb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((70)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(3-2)", "4", "9", "(3-2)");
            var v = ov.swizzle.ggbr;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("(3-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-99)", "-8", "-2");
            var v = ov.swizzle.ggbg;
            Assert.That("(-99)", Is.EqualTo(v.x));
            Assert.That("(-99)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("(-99)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-25)", "(55)", "((-3-2)-2)", "((-3-2)-2)");
            var v = ov.swizzle.ggbb;
            Assert.That("(55)", Is.EqualTo(v.x));
            Assert.That("(55)", Is.EqualTo(v.y));
            Assert.That("((-3-2)-2)", Is.EqualTo(v.z));
            Assert.That("((-3-2)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-15)-8)", "", "-2", "-6");
            var v = ov.swizzle.ggba;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-1)1)", "((3-1)1)", "((54)-3)", null);
            var v = ov.swizzle.gga;
            Assert.That("((3-1)1)", Is.EqualTo(v.x));
            Assert.That("((3-1)1)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("0", "((92)-9)", "(-84)", "((-48)-2)");
            var v = ov.swizzle.ggar;
            Assert.That("((92)-9)", Is.EqualTo(v.x));
            Assert.That("((92)-9)", Is.EqualTo(v.y));
            Assert.That("((-48)-2)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-69)", "((-7-5)5)", "((-51)-1)", null);
            var v = ov.swizzle.ggag;
            Assert.That("((-7-5)5)", Is.EqualTo(v.x));
            Assert.That("((-7-5)5)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((-7-5)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "((-90)-1)", "((2-8)0)", "(-4-5)");
            var v = ov.swizzle.ggab;
            Assert.That("((-90)-1)", Is.EqualTo(v.x));
            Assert.That("((-90)-1)", Is.EqualTo(v.y));
            Assert.That("(-4-5)", Is.EqualTo(v.z));
            Assert.That("((2-8)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(32)", "((4-9)-4)", "((66)-9)", "-1");
            var v = ov.swizzle.ggaa;
            Assert.That("((4-9)-4)", Is.EqualTo(v.x));
            Assert.That("((4-9)-4)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-13)", "((-11)-3)", "2", null);
            var v = ov.swizzle.gb;
            Assert.That("((-11)-3)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-1-6)", "(-1-6)", "((5-5)-2)", "((-3-9)-2)");
            var v = ov.swizzle.gbr;
            Assert.That("(-1-6)", Is.EqualTo(v.x));
            Assert.That("((5-5)-2)", Is.EqualTo(v.y));
            Assert.That("(-1-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-67)", "((35)2)", "-4", "7");
            var v = ov.swizzle.gbrr;
            Assert.That("((35)2)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(-67)", Is.EqualTo(v.z));
            Assert.That("(-67)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-31)2)", "-9", "5");
            var v = ov.swizzle.gbrg;
            Assert.That("((-31)2)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-31)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-7)9)", "(-9-2)", null, "((5-4)4)");
            var v = ov.swizzle.gbrb;
            Assert.That("(-9-2)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-8-7)9)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-7)", "(-69)", "((18)4)", "(0-9)");
            var v = ov.swizzle.gbra;
            Assert.That("(-69)", Is.EqualTo(v.x));
            Assert.That("((18)4)", Is.EqualTo(v.y));
            Assert.That("(-1-7)", Is.EqualTo(v.z));
            Assert.That("(0-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-72)-7)", "(-11)", "8", "((-72)-7)");
            var v = ov.swizzle.gbg;
            Assert.That("(-11)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-11)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-5-5)", "-3", "((9-3)3)", "(2-6)");
            var v = ov.swizzle.gbgr;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("((9-3)3)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(-5-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((80)-4)", "", "((80)-4)", "((21)-5)");
            var v = ov.swizzle.gbgg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((80)-4)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "((5-9)-3)", "((5-9)-3)", "-4");
            var v = ov.swizzle.gbgb;
            Assert.That("((5-9)-3)", Is.EqualTo(v.x));
            Assert.That("((5-9)-3)", Is.EqualTo(v.y));
            Assert.That("((5-9)-3)", Is.EqualTo(v.z));
            Assert.That("((5-9)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "(41)", "3");
            var v = ov.swizzle.gbga;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(41)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-1-5)", "-6", "((-8-1)9)");
            var v = ov.swizzle.gbb;
            Assert.That("(-1-5)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(6-1)", "(6-1)", "(6-1)", "-1");
            var v = ov.swizzle.gbbr;
            Assert.That("(6-1)", Is.EqualTo(v.x));
            Assert.That("(6-1)", Is.EqualTo(v.y));
            Assert.That("(6-1)", Is.EqualTo(v.z));
            Assert.That("(6-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(92)", "(-32)", "6", "((-72)2)");
            var v = ov.swizzle.gbbg;
            Assert.That("(-32)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("(-32)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-5)", "(-4-3)", "((-33)2)", "(-8-5)");
            var v = ov.swizzle.gbbb;
            Assert.That("(-4-3)", Is.EqualTo(v.x));
            Assert.That("((-33)2)", Is.EqualTo(v.y));
            Assert.That("((-33)2)", Is.EqualTo(v.z));
            Assert.That("((-33)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "-4", "(26)", "((9-8)-2)");
            var v = ov.swizzle.gbba;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(26)", Is.EqualTo(v.y));
            Assert.That("(26)", Is.EqualTo(v.z));
            Assert.That("((9-8)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-92)8)", "(50)", "(-7-8)", "2");
            var v = ov.swizzle.gba;
            Assert.That("(50)", Is.EqualTo(v.x));
            Assert.That("(-7-8)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(26)", null, "((6-4)2)", "-8");
            var v = ov.swizzle.gbar;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((6-4)2)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("(26)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", null, "-6", "(-20)");
            var v = ov.swizzle.gbag;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(-20)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(7-7)", "(7-7)", "");
            var v = ov.swizzle.gbab;
            Assert.That("(7-7)", Is.EqualTo(v.x));
            Assert.That("(7-7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(7-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "(5-5)", "1", "((-55)-9)");
            var v = ov.swizzle.gbaa;
            Assert.That("(5-5)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("((-55)-9)", Is.EqualTo(v.z));
            Assert.That("((-55)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "-7", "-7", "(45)");
            var v = ov.swizzle.ga;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(45)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-1-5)6)", "-1", null, "");
            var v = ov.swizzle.gar;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-1-5)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-5-7)5)", "", "", "-3");
            var v = ov.swizzle.garr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("((-5-7)5)", Is.EqualTo(v.z));
            Assert.That("((-5-7)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-6)-1)", "-5", "((-73)-8)", "");
            var v = ov.swizzle.garg;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((0-6)-1)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "(-8-6)", "((-8-8)-1)", "(-62)");
            var v = ov.swizzle.garb;
            Assert.That("(-8-6)", Is.EqualTo(v.x));
            Assert.That("(-62)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("((-8-8)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-6)-9)", "", "9", "(93)");
            var v = ov.swizzle.gara;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(93)", Is.EqualTo(v.y));
            Assert.That("((-2-6)-9)", Is.EqualTo(v.z));
            Assert.That("(93)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(21)", null, "5", "(-72)");
            var v = ov.swizzle.gag;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-72)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-6", "(5-8)", "(7-7)", "((-2-1)0)");
            var v = ov.swizzle.gagr;
            Assert.That("(5-8)", Is.EqualTo(v.x));
            Assert.That("((-2-1)0)", Is.EqualTo(v.y));
            Assert.That("(5-8)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-6)", "((27)5)", "3", "(-67)");
            var v = ov.swizzle.gagg;
            Assert.That("((27)5)", Is.EqualTo(v.x));
            Assert.That("(-67)", Is.EqualTo(v.y));
            Assert.That("((27)5)", Is.EqualTo(v.z));
            Assert.That("((27)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "-6", null, "-6");
            var v = ov.swizzle.gagb;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(40)", "(-3-2)", "(40)", "3");
            var v = ov.swizzle.gaga;
            Assert.That("(-3-2)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(-3-2)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-7)-5)", "(-51)", "", "(38)");
            var v = ov.swizzle.gab;
            Assert.That("(-51)", Is.EqualTo(v.x));
            Assert.That("(38)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-4-9)-2)", "(18)", "-4", "-6");
            var v = ov.swizzle.gabr;
            Assert.That("(18)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("((-4-9)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-2)0)", "4", "", "((51)-3)");
            var v = ov.swizzle.gabg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((51)-3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-97)", "(-28)", null, "((-65)-4)");
            var v = ov.swizzle.gabb;
            Assert.That("(-28)", Is.EqualTo(v.x));
            Assert.That("((-65)-4)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", null, "((11)9)", "-8");
            var v = ov.swizzle.gaba;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("((11)9)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((5-4)3)", "0", "(29)");
            var v = ov.swizzle.gaa;
            Assert.That("((5-4)3)", Is.EqualTo(v.x));
            Assert.That("(29)", Is.EqualTo(v.y));
            Assert.That("(29)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((93)-6)", "", "0", "((-47)-9)");
            var v = ov.swizzle.gaar;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-47)-9)", Is.EqualTo(v.y));
            Assert.That("((-47)-9)", Is.EqualTo(v.z));
            Assert.That("((93)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-3)", "((-1-4)-5)", "(-2-2)", "(-6-9)");
            var v = ov.swizzle.gaag;
            Assert.That("((-1-4)-5)", Is.EqualTo(v.x));
            Assert.That("(-6-9)", Is.EqualTo(v.y));
            Assert.That("(-6-9)", Is.EqualTo(v.z));
            Assert.That("((-1-4)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "9", null, "");
            var v = ov.swizzle.gaab;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-9)", "4", null, "((-7-8)3)");
            var v = ov.swizzle.gaaa;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((-7-8)3)", Is.EqualTo(v.y));
            Assert.That("((-7-8)3)", Is.EqualTo(v.z));
            Assert.That("((-7-8)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(09)", "-8", "(8-5)");
            var v = ov.swizzle.br;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((46)-8)", "-3", "((46)-8)", "-9");
            var v = ov.swizzle.brr;
            Assert.That("((46)-8)", Is.EqualTo(v.x));
            Assert.That("((46)-8)", Is.EqualTo(v.y));
            Assert.That("((46)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "((-57)1)", "", "5");
            var v = ov.swizzle.brrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-54)5)", "6", "-2", "-9");
            var v = ov.swizzle.brrg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((-54)5)", Is.EqualTo(v.y));
            Assert.That("((-54)5)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(20)", "((-2-6)5)", "");
            var v = ov.swizzle.brrb;
            Assert.That("((-2-6)5)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((-2-6)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((41)-2)", "(3-9)", null, "(36)");
            var v = ov.swizzle.brra;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((41)-2)", Is.EqualTo(v.y));
            Assert.That("((41)-2)", Is.EqualTo(v.z));
            Assert.That("(36)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(23)", "1", "(23)", "");
            var v = ov.swizzle.brg;
            Assert.That("(23)", Is.EqualTo(v.x));
            Assert.That("(23)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "(-5-4)", "9", null);
            var v = ov.swizzle.brgr;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(-5-4)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((71)9)", "-9", "", "(-43)");
            var v = ov.swizzle.brgg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((71)9)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(36)", "(18)", "9", "-7");
            var v = ov.swizzle.brgb;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(36)", Is.EqualTo(v.y));
            Assert.That("(18)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-1)", "((-39)0)", "", "((-39)0)");
            var v = ov.swizzle.brga;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-9-1)", Is.EqualTo(v.y));
            Assert.That("((-39)0)", Is.EqualTo(v.z));
            Assert.That("((-39)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((91)0)", "(71)", "(71)", "((35)1)");
            var v = ov.swizzle.brb;
            Assert.That("(71)", Is.EqualTo(v.x));
            Assert.That("((91)0)", Is.EqualTo(v.y));
            Assert.That("(71)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "(89)", "-6", "((28)7)");
            var v = ov.swizzle.brbr;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "-6", "-4", "(-9-3)");
            var v = ov.swizzle.brbg;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-5)", "((9-7)5)", "((4-6)-7)", "");
            var v = ov.swizzle.brbb;
            Assert.That("((4-6)-7)", Is.EqualTo(v.x));
            Assert.That("(5-5)", Is.EqualTo(v.y));
            Assert.That("((4-6)-7)", Is.EqualTo(v.z));
            Assert.That("((4-6)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-1)", "((-7-6)2)", "((8-4)9)", "((5-2)-9)");
            var v = ov.swizzle.brba;
            Assert.That("((8-4)9)", Is.EqualTo(v.x));
            Assert.That("(4-1)", Is.EqualTo(v.y));
            Assert.That("((8-4)9)", Is.EqualTo(v.z));
            Assert.That("((5-2)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-8)8)", "(-3-9)", null, "(-86)");
            var v = ov.swizzle.bra;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((2-8)8)", Is.EqualTo(v.y));
            Assert.That("(-86)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-5-6)", "(-5-6)", "((61)4)", "((9-3)-9)");
            var v = ov.swizzle.brar;
            Assert.That("((61)4)", Is.EqualTo(v.x));
            Assert.That("(-5-6)", Is.EqualTo(v.y));
            Assert.That("((9-3)-9)", Is.EqualTo(v.z));
            Assert.That("(-5-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-3)", "(14)", "(2-1)", "(-4-3)");
            var v = ov.swizzle.brag;
            Assert.That("(2-1)", Is.EqualTo(v.x));
            Assert.That("(-4-3)", Is.EqualTo(v.y));
            Assert.That("(-4-3)", Is.EqualTo(v.z));
            Assert.That("(14)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-2", "-2", "");
            var v = ov.swizzle.brab;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "7", "(-3-1)", "");
            var v = ov.swizzle.braa;
            Assert.That("(-3-1)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-1)8)", "((2-1)8)", "-6", "(82)");
            var v = ov.swizzle.bg;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((2-1)8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>(null, "(15)", "((-14)9)", "(-75)");
            var v = ov.swizzle.bgr;
            Assert.That("((-14)9)", Is.EqualTo(v.x));
            Assert.That("(15)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-5", "(0-6)", "(-6-6)", null);
            var v = ov.swizzle.bgrr;
            Assert.That("(-6-6)", Is.EqualTo(v.x));
            Assert.That("(0-6)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-4", "-4", "4");
            var v = ov.swizzle.bgrg;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(-3-5)", "1", "1");
            var v = ov.swizzle.bgrb;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(-3-5)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-23)2)", "", "(-29)", "((67)-3)");
            var v = ov.swizzle.bgra;
            Assert.That("(-29)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-23)2)", Is.EqualTo(v.z));
            Assert.That("((67)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((80)-8)", "((-70)2)", "(-9-9)", "6");
            var v = ov.swizzle.bgg;
            Assert.That("(-9-9)", Is.EqualTo(v.x));
            Assert.That("((-70)2)", Is.EqualTo(v.y));
            Assert.That("((-70)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("7", "", "(1-9)", "(96)");
            var v = ov.swizzle.bggr;
            Assert.That("(1-9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((14)2)", "((66)6)", "(6-2)", "((-71)2)");
            var v = ov.swizzle.bggg;
            Assert.That("(6-2)", Is.EqualTo(v.x));
            Assert.That("((66)6)", Is.EqualTo(v.y));
            Assert.That("((66)6)", Is.EqualTo(v.z));
            Assert.That("((66)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-54)", "-6", "(-88)", null);
            var v = ov.swizzle.bggb;
            Assert.That("(-88)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("(-88)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(23)", "(2-6)", "((01)0)", "(6-7)");
            var v = ov.swizzle.bgga;
            Assert.That("((01)0)", Is.EqualTo(v.x));
            Assert.That("(2-6)", Is.EqualTo(v.y));
            Assert.That("(2-6)", Is.EqualTo(v.z));
            Assert.That("(6-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((62)3)", "(2-2)", "(-9-1)", "((-7-6)-8)");
            var v = ov.swizzle.bgb;
            Assert.That("(-9-1)", Is.EqualTo(v.x));
            Assert.That("(2-2)", Is.EqualTo(v.y));
            Assert.That("(-9-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-58)", "-1", "(3-8)", "(3-8)");
            var v = ov.swizzle.bgbr;
            Assert.That("(3-8)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(3-8)", Is.EqualTo(v.z));
            Assert.That("(-58)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-4)0)", "(-39)", "((-34)1)", "(-39)");
            var v = ov.swizzle.bgbg;
            Assert.That("((-34)1)", Is.EqualTo(v.x));
            Assert.That("(-39)", Is.EqualTo(v.y));
            Assert.That("((-34)1)", Is.EqualTo(v.z));
            Assert.That("(-39)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", null, "((7-6)-9)", "((-83)6)");
            var v = ov.swizzle.bgbb;
            Assert.That("((7-6)-9)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((7-6)-9)", Is.EqualTo(v.z));
            Assert.That("((7-6)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-63)", "((53)0)", "((53)0)", "(-63)");
            var v = ov.swizzle.bgba;
            Assert.That("((53)0)", Is.EqualTo(v.x));
            Assert.That("((53)0)", Is.EqualTo(v.y));
            Assert.That("((53)0)", Is.EqualTo(v.z));
            Assert.That("(-63)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "0", "(9-4)", "7");
            var v = ov.swizzle.bga;
            Assert.That("(9-4)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-6", null, "", "-2");
            var v = ov.swizzle.bgar;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-98)-4)", "(73)", "((-98)-4)");
            var v = ov.swizzle.bgag;
            Assert.That("(73)", Is.EqualTo(v.x));
            Assert.That("((-98)-4)", Is.EqualTo(v.y));
            Assert.That("((-98)-4)", Is.EqualTo(v.z));
            Assert.That("((-98)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-8)-1)", "((1-1)-6)", "9", "((-68)0)");
            var v = ov.swizzle.bgab;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((1-1)-6)", Is.EqualTo(v.y));
            Assert.That("((-68)0)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-13)-4)", null, "4", "((73)-3)");
            var v = ov.swizzle.bgaa;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((73)-3)", Is.EqualTo(v.z));
            Assert.That("((73)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-11)-6)", "", "(03)", null);
            var v = ov.swizzle.bb;
            Assert.That("(03)", Is.EqualTo(v.x));
            Assert.That("(03)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-7-8)", "(-7-8)", "((-53)8)", "((53)-4)");
            var v = ov.swizzle.bbr;
            Assert.That("((-53)8)", Is.EqualTo(v.x));
            Assert.That("((-53)8)", Is.EqualTo(v.y));
            Assert.That("(-7-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-5", "-2", "(48)", "");
            var v = ov.swizzle.bbrr;
            Assert.That("(48)", Is.EqualTo(v.x));
            Assert.That("(48)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-26)-7)", "-1", "(4-6)", "(6-6)");
            var v = ov.swizzle.bbrg;
            Assert.That("(4-6)", Is.EqualTo(v.x));
            Assert.That("(4-6)", Is.EqualTo(v.y));
            Assert.That("((-26)-7)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-31)", "(-49)", "-5", "");
            var v = ov.swizzle.bbrb;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(-31)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "", "-2", "");
            var v = ov.swizzle.bbra;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-6-2)", "((11)-5)", "((11)-5)");
            var v = ov.swizzle.bbg;
            Assert.That("((11)-5)", Is.EqualTo(v.x));
            Assert.That("((11)-5)", Is.EqualTo(v.y));
            Assert.That("(-6-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("5", null, null, "5");
            var v = ov.swizzle.bbgr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-2)", "(-5-5)", "(-5-5)", "((-48)-8)");
            var v = ov.swizzle.bbgg;
            Assert.That("(-5-5)", Is.EqualTo(v.x));
            Assert.That("(-5-5)", Is.EqualTo(v.y));
            Assert.That("(-5-5)", Is.EqualTo(v.z));
            Assert.That("(-5-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-8-9)5)", "-6", "-7");
            var v = ov.swizzle.bbgb;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("((-8-9)5)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(3-9)", "((-33)-6)", null, "(-91)");
            var v = ov.swizzle.bbga;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-33)-6)", Is.EqualTo(v.z));
            Assert.That("(-91)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((3-8)-2)", "(52)", "(23)");
            var v = ov.swizzle.bbb;
            Assert.That("(52)", Is.EqualTo(v.x));
            Assert.That("(52)", Is.EqualTo(v.y));
            Assert.That("(52)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-4", "((89)9)", "(69)", "(69)");
            var v = ov.swizzle.bbbr;
            Assert.That("(69)", Is.EqualTo(v.x));
            Assert.That("(69)", Is.EqualTo(v.y));
            Assert.That("(69)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(43)", "-2", "((2-5)0)", "-7");
            var v = ov.swizzle.bbbg;
            Assert.That("((2-5)0)", Is.EqualTo(v.x));
            Assert.That("((2-5)0)", Is.EqualTo(v.y));
            Assert.That("((2-5)0)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "7", null, "(5-4)");
            var v = ov.swizzle.bbbb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-49)7)", "((-66)-9)", "9");
            var v = ov.swizzle.bbba;
            Assert.That("((-66)-9)", Is.EqualTo(v.x));
            Assert.That("((-66)-9)", Is.EqualTo(v.y));
            Assert.That("((-66)-9)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((2-4)-8)", "((-42)2)", "(95)");
            var v = ov.swizzle.bba;
            Assert.That("((-42)2)", Is.EqualTo(v.x));
            Assert.That("((-42)2)", Is.EqualTo(v.y));
            Assert.That("(95)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(48)", "(48)", "((-83)3)", null);
            var v = ov.swizzle.bbar;
            Assert.That("((-83)3)", Is.EqualTo(v.x));
            Assert.That("((-83)3)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(48)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-6", null, "((0-5)-5)");
            var v = ov.swizzle.bbag;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((0-5)-5)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-50)", null, "-2", "-2");
            var v = ov.swizzle.bbab;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-1-1)5)", "((-1-1)5)", "2");
            var v = ov.swizzle.bbaa;
            Assert.That("((-1-1)5)", Is.EqualTo(v.x));
            Assert.That("((-1-1)5)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-2)", "(-57)", "(-6-2)", "((-92)7)");
            var v = ov.swizzle.ba;
            Assert.That("(-6-2)", Is.EqualTo(v.x));
            Assert.That("((-92)7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>(null, "-4", "3", "((-2-4)-8)");
            var v = ov.swizzle.bar;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((-2-4)-8)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "(-34)", null, "(-34)");
            var v = ov.swizzle.barr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-34)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-6)-7)", "", "(89)", "-3");
            var v = ov.swizzle.barg;
            Assert.That("(89)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("((-5-6)-7)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "((62)1)", "");
            var v = ov.swizzle.barb;
            Assert.That("((62)1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((62)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", null, "(1-9)", "(-5-3)");
            var v = ov.swizzle.bara;
            Assert.That("(1-9)", Is.EqualTo(v.x));
            Assert.That("(-5-3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-5-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "", "-8", "((21)6)");
            var v = ov.swizzle.bag;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((21)6)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-8-6)-7)", "(-21)", "((8-1)-6)", "2");
            var v = ov.swizzle.bagr;
            Assert.That("((8-1)-6)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(-21)", Is.EqualTo(v.z));
            Assert.That("((-8-6)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((29)0)", "((84)5)", "((84)5)", null);
            var v = ov.swizzle.bagg;
            Assert.That("((84)5)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((84)5)", Is.EqualTo(v.z));
            Assert.That("((84)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(11)", "(11)", "(-39)");
            var v = ov.swizzle.bagb;
            Assert.That("(11)", Is.EqualTo(v.x));
            Assert.That("(-39)", Is.EqualTo(v.y));
            Assert.That("(11)", Is.EqualTo(v.z));
            Assert.That("(11)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-7)-6)", "(-56)", "((-17)8)", "5");
            var v = ov.swizzle.baga;
            Assert.That("((-17)8)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(-56)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-4)", "(-8-9)", "((2-3)7)", "((-5-3)4)");
            var v = ov.swizzle.bab;
            Assert.That("((2-3)7)", Is.EqualTo(v.x));
            Assert.That("((-5-3)4)", Is.EqualTo(v.y));
            Assert.That("((2-3)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "((-2-5)0)", "(40)", "(40)");
            var v = ov.swizzle.babr;
            Assert.That("(40)", Is.EqualTo(v.x));
            Assert.That("(40)", Is.EqualTo(v.y));
            Assert.That("(40)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(9-5)", "-4", "-6");
            var v = ov.swizzle.babg;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(9-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "((-41)-4)", "((91)-4)", "");
            var v = ov.swizzle.babb;
            Assert.That("((91)-4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((91)-4)", Is.EqualTo(v.z));
            Assert.That("((91)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-6", "((-26)-8)", "((3-7)-6)");
            var v = ov.swizzle.baba;
            Assert.That("((-26)-8)", Is.EqualTo(v.x));
            Assert.That("((3-7)-6)", Is.EqualTo(v.y));
            Assert.That("((-26)-8)", Is.EqualTo(v.z));
            Assert.That("((3-7)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(83)", "(83)", "((4-6)-4)", "((34)6)");
            var v = ov.swizzle.baa;
            Assert.That("((4-6)-4)", Is.EqualTo(v.x));
            Assert.That("((34)6)", Is.EqualTo(v.y));
            Assert.That("((34)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("7", "(-6-4)", "(-6-4)", "(-6-4)");
            var v = ov.swizzle.baar;
            Assert.That("(-6-4)", Is.EqualTo(v.x));
            Assert.That("(-6-4)", Is.EqualTo(v.y));
            Assert.That("(-6-4)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(1-4)", "((68)-5)", "(7-2)");
            var v = ov.swizzle.baag;
            Assert.That("((68)-5)", Is.EqualTo(v.x));
            Assert.That("(7-2)", Is.EqualTo(v.y));
            Assert.That("(7-2)", Is.EqualTo(v.z));
            Assert.That("(1-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-37)-8)", "", "", "(-26)");
            var v = ov.swizzle.baab;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-26)", Is.EqualTo(v.y));
            Assert.That("(-26)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-41)", "(-41)", "-9", "-8");
            var v = ov.swizzle.baaa;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((55)0)", "((55)3)", "((55)3)");
            var v = ov.swizzle.ar;
            Assert.That("((55)3)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((4-3)4)", "6", "5", "");
            var v = ov.swizzle.arr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((4-3)4)", Is.EqualTo(v.y));
            Assert.That("((4-3)4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-7-5)-4)", "4", "6", "6");
            var v = ov.swizzle.arrr;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("((-7-5)-4)", Is.EqualTo(v.y));
            Assert.That("((-7-5)-4)", Is.EqualTo(v.z));
            Assert.That("((-7-5)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-9)-3)", "-5", "((-34)6)", "((-34)6)");
            var v = ov.swizzle.arrg;
            Assert.That("((-34)6)", Is.EqualTo(v.x));
            Assert.That("((0-9)-3)", Is.EqualTo(v.y));
            Assert.That("((0-9)-3)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(21)", "((18)-7)", "((-77)-3)");
            var v = ov.swizzle.arrb;
            Assert.That("((-77)-3)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((18)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-8)", "((9-1)5)", "-8", "((9-1)5)");
            var v = ov.swizzle.arra;
            Assert.That("((9-1)5)", Is.EqualTo(v.x));
            Assert.That("(7-8)", Is.EqualTo(v.y));
            Assert.That("(7-8)", Is.EqualTo(v.z));
            Assert.That("((9-1)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "4", "4", "");
            var v = ov.swizzle.arg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-9", "-9", "(-2-7)", "3");
            var v = ov.swizzle.argr;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(75)", "", "(-26)");
            var v = ov.swizzle.argg;
            Assert.That("(-26)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(75)", Is.EqualTo(v.z));
            Assert.That("(75)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(3-9)", "(-9-1)", "((3-3)-4)");
            var v = ov.swizzle.argb;
            Assert.That("((3-3)-4)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(3-9)", Is.EqualTo(v.z));
            Assert.That("(-9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", null, "(2-8)", "-1");
            var v = ov.swizzle.arga;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((99)7)", "((99)7)", "(5-6)", "2");
            var v = ov.swizzle.arb;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("((99)7)", Is.EqualTo(v.y));
            Assert.That("(5-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-9", "-8", "((0-8)-7)", "");
            var v = ov.swizzle.arbr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((0-8)-7)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-23)-9)", "(5-7)", "((-7-8)7)", "9");
            var v = ov.swizzle.arbg;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((-23)-9)", Is.EqualTo(v.y));
            Assert.That("((-7-8)7)", Is.EqualTo(v.z));
            Assert.That("(5-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-1)", "", "5", "-1");
            var v = ov.swizzle.arbb;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("(8-1)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-5)-7)", "((-2-4)3)", "-9", "");
            var v = ov.swizzle.arba;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-5-5)-7)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "-1", "((68)-6)");
            var v = ov.swizzle.ara;
            Assert.That("((68)-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((68)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", null, "", "(18)");
            var v = ov.swizzle.arar;
            Assert.That("(18)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(18)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-1)", "-7", "((-2-2)0)", "(3-9)");
            var v = ov.swizzle.arag;
            Assert.That("(3-9)", Is.EqualTo(v.x));
            Assert.That("(-4-1)", Is.EqualTo(v.y));
            Assert.That("(3-9)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((17)2)", "(4-9)", null);
            var v = ov.swizzle.arab;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(4-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(58)", "(58)", "((-3-4)8)", "");
            var v = ov.swizzle.araa;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(58)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((19)-4)", null, "((19)-4)", "(-61)");
            var v = ov.swizzle.ag;
            Assert.That("(-61)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((7-9)-4)", "", "(-83)", "((7-9)-4)");
            var v = ov.swizzle.agr;
            Assert.That("((7-9)-4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((7-9)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-24)-2)", "((76)-7)", "", "((05)5)");
            var v = ov.swizzle.agrr;
            Assert.That("((05)5)", Is.EqualTo(v.x));
            Assert.That("((76)-7)", Is.EqualTo(v.y));
            Assert.That("((-24)-2)", Is.EqualTo(v.z));
            Assert.That("((-24)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((3-4)8)", null, "4");
            var v = ov.swizzle.agrg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((3-4)8)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((3-4)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-50)", "((24)3)", "(28)", "((-28)-1)");
            var v = ov.swizzle.agrb;
            Assert.That("((-28)-1)", Is.EqualTo(v.x));
            Assert.That("((24)3)", Is.EqualTo(v.y));
            Assert.That("(-50)", Is.EqualTo(v.z));
            Assert.That("(28)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-3)3)", "((8-3)3)", "(63)", "");
            var v = ov.swizzle.agra;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((8-3)3)", Is.EqualTo(v.y));
            Assert.That("((8-3)3)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-2)4)", "(-8-2)", "((-43)-2)", "(-70)");
            var v = ov.swizzle.agg;
            Assert.That("(-70)", Is.EqualTo(v.x));
            Assert.That("(-8-2)", Is.EqualTo(v.y));
            Assert.That("(-8-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((4-9)-2)", "", "", "((46)-6)");
            var v = ov.swizzle.aggr;
            Assert.That("((46)-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((4-9)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-2)", "(-8-2)", "((-84)7)", "(-40)");
            var v = ov.swizzle.aggg;
            Assert.That("(-40)", Is.EqualTo(v.x));
            Assert.That("(-8-2)", Is.EqualTo(v.y));
            Assert.That("(-8-2)", Is.EqualTo(v.z));
            Assert.That("(-8-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(5-9)", "(65)", null);
            var v = ov.swizzle.aggb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(5-9)", Is.EqualTo(v.y));
            Assert.That("(5-9)", Is.EqualTo(v.z));
            Assert.That("(65)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((59)0)", "((-68)-9)", "1", "6");
            var v = ov.swizzle.agga;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("((-68)-9)", Is.EqualTo(v.y));
            Assert.That("((-68)-9)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-7)5)", "((-2-9)-6)", "9", "(-83)");
            var v = ov.swizzle.agb;
            Assert.That("(-83)", Is.EqualTo(v.x));
            Assert.That("((-2-9)-6)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "(-48)", "((-84)-3)", "(-48)");
            var v = ov.swizzle.agbr;
            Assert.That("(-48)", Is.EqualTo(v.x));
            Assert.That("(-48)", Is.EqualTo(v.y));
            Assert.That("((-84)-3)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(53)", "-9", "((2-9)-2)", null);
            var v = ov.swizzle.agbg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((2-9)-2)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-2)", "3", "-2", "");
            var v = ov.swizzle.agbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-1)", "(94)", "-3", "((-42)-4)");
            var v = ov.swizzle.agba;
            Assert.That("((-42)-4)", Is.EqualTo(v.x));
            Assert.That("(94)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("((-42)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-5)9)", "((-8-7)-6)", null, "3");
            var v = ov.swizzle.aga;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((-8-7)-6)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-5", "", "-6", "1");
            var v = ov.swizzle.agar;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-15)2)", "((-28)3)", "((-15)2)", "(52)");
            var v = ov.swizzle.agag;
            Assert.That("(52)", Is.EqualTo(v.x));
            Assert.That("((-28)3)", Is.EqualTo(v.y));
            Assert.That("(52)", Is.EqualTo(v.z));
            Assert.That("((-28)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-5)-6)", "((1-5)-5)", "((1-5)-5)", null);
            var v = ov.swizzle.agab;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((1-5)-5)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((1-5)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", null, null, "((-6-9)6)");
            var v = ov.swizzle.agaa;
            Assert.That("((-6-9)6)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-6-9)6)", Is.EqualTo(v.z));
            Assert.That("((-6-9)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(94)", "((70)6)", "((70)6)", "((70)6)");
            var v = ov.swizzle.ab;
            Assert.That("((70)6)", Is.EqualTo(v.x));
            Assert.That("((70)6)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>(null, "((2-6)0)", "(-9-2)", "5");
            var v = ov.swizzle.abr;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(-9-2)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-79)0)", "1", "((-20)-9)", "");
            var v = ov.swizzle.abrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-20)-9)", Is.EqualTo(v.y));
            Assert.That("((-79)0)", Is.EqualTo(v.z));
            Assert.That("((-79)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "7", "", "((-56)5)");
            var v = ov.swizzle.abrg;
            Assert.That("((-56)5)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-79)-4)", "(09)", "-2", null);
            var v = ov.swizzle.abrb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((-79)-4)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "((49)-2)", "((49)-2)", "((1-6)-9)");
            var v = ov.swizzle.abra;
            Assert.That("((1-6)-9)", Is.EqualTo(v.x));
            Assert.That("((49)-2)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("((1-6)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-6)", "-1", "-1", "-1");
            var v = ov.swizzle.abg;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-7-2)4)", "-3", "((0-9)0)", "(-5-6)");
            var v = ov.swizzle.abgr;
            Assert.That("(-5-6)", Is.EqualTo(v.x));
            Assert.That("((0-9)0)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("((-7-2)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-5)5)", null, "((3-5)5)", "6");
            var v = ov.swizzle.abgg;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("((3-5)5)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-6)1)", "", "((-22)-8)", "((-22)-8)");
            var v = ov.swizzle.abgb;
            Assert.That("((-22)-8)", Is.EqualTo(v.x));
            Assert.That("((-22)-8)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-22)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "", "((8-7)1)", "-8");
            var v = ov.swizzle.abga;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((8-7)1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-9)", "(9-9)", "((7-3)-2)", "((7-3)-2)");
            var v = ov.swizzle.abb;
            Assert.That("((7-3)-2)", Is.EqualTo(v.x));
            Assert.That("((7-3)-2)", Is.EqualTo(v.y));
            Assert.That("((7-3)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-6", "4", "", "(-6-4)");
            var v = ov.swizzle.abbr;
            Assert.That("(-6-4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "4", "((8-2)9)", "(-5-5)");
            var v = ov.swizzle.abbg;
            Assert.That("(-5-5)", Is.EqualTo(v.x));
            Assert.That("((8-2)9)", Is.EqualTo(v.y));
            Assert.That("((8-2)9)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-4)9)", "((-8-4)9)", "9", "((-8-4)9)");
            var v = ov.swizzle.abbb;
            Assert.That("((-8-4)9)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "-5", "(-8-3)", "5");
            var v = ov.swizzle.abba;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(-8-3)", Is.EqualTo(v.y));
            Assert.That("(-8-3)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(80)", "0", "((-3-4)9)");
            var v = ov.swizzle.aba;
            Assert.That("((-3-4)9)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((-3-4)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-18)", "((9-9)-6)", "((7-9)2)", "(-18)");
            var v = ov.swizzle.abar;
            Assert.That("(-18)", Is.EqualTo(v.x));
            Assert.That("((7-9)2)", Is.EqualTo(v.y));
            Assert.That("(-18)", Is.EqualTo(v.z));
            Assert.That("(-18)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-5)-7)", "(-55)", "(-4-9)", "(9-6)");
            var v = ov.swizzle.abag;
            Assert.That("(9-6)", Is.EqualTo(v.x));
            Assert.That("(-4-9)", Is.EqualTo(v.y));
            Assert.That("(9-6)", Is.EqualTo(v.z));
            Assert.That("(-55)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-3)", "((94)5)", "9", null);
            var v = ov.swizzle.abab;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((3-9)-3)", "(73)", "0");
            var v = ov.swizzle.abaa;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(73)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-6)8)", "-8", "(29)", "1");
            var v = ov.swizzle.aa;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(32)", "(-7-9)", "((-14)-1)", "6");
            var v = ov.swizzle.aar;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(32)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "-5", "((5-9)8)", "-1");
            var v = ov.swizzle.aarr;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((-2-9)-8)", "(-2-9)", "((-9-7)-3)");
            var v = ov.swizzle.aarg;
            Assert.That("((-9-7)-3)", Is.EqualTo(v.x));
            Assert.That("((-9-7)-3)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("((-2-9)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-25)", "(-25)", "(-25)", "-7");
            var v = ov.swizzle.aarb;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(-25)", Is.EqualTo(v.z));
            Assert.That("(-25)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "-1", "((8-9)-1)", "((8-9)-1)");
            var v = ov.swizzle.aara;
            Assert.That("((8-9)-1)", Is.EqualTo(v.x));
            Assert.That("((8-9)-1)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("((8-9)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-90)", "-2", null, "((8-5)-3)");
            var v = ov.swizzle.aag;
            Assert.That("((8-5)-3)", Is.EqualTo(v.x));
            Assert.That("((8-5)-3)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("6", "(69)", "((-61)5)", "5");
            var v = ov.swizzle.aagr;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(69)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(36)", "-5", null, "");
            var v = ov.swizzle.aagg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-68)-5)", "(56)", "1", "((-68)-5)");
            var v = ov.swizzle.aagb;
            Assert.That("((-68)-5)", Is.EqualTo(v.x));
            Assert.That("((-68)-5)", Is.EqualTo(v.y));
            Assert.That("(56)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-2)-2)", "0", "2", "2");
            var v = ov.swizzle.aaga;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-3", "", null);
            var v = ov.swizzle.aab;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-73)", "-3", "((0-1)-8)", "7");
            var v = ov.swizzle.aabr;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("((0-1)-8)", Is.EqualTo(v.z));
            Assert.That("(-73)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((34)-8)", "((34)-8)", "(-25)", "((3-2)9)");
            var v = ov.swizzle.aabg;
            Assert.That("((3-2)9)", Is.EqualTo(v.x));
            Assert.That("((3-2)9)", Is.EqualTo(v.y));
            Assert.That("(-25)", Is.EqualTo(v.z));
            Assert.That("((34)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-9)9)", "(-27)", "-1", "((-3-3)3)");
            var v = ov.swizzle.aabb;
            Assert.That("((-3-3)3)", Is.EqualTo(v.x));
            Assert.That("((-3-3)3)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-5)-1)", "", "(0-6)", "((8-8)-8)");
            var v = ov.swizzle.aaba;
            Assert.That("((8-8)-8)", Is.EqualTo(v.x));
            Assert.That("((8-8)-8)", Is.EqualTo(v.y));
            Assert.That("(0-6)", Is.EqualTo(v.z));
            Assert.That("((8-8)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((39)-7)", "-3", "", "-8");
            var v = ov.swizzle.aaa;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("5", "-2", "(4-6)", "5");
            var v = ov.swizzle.aaar;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "4", "((-67)-4)");
            var v = ov.swizzle.aaag;
            Assert.That("((-67)-4)", Is.EqualTo(v.x));
            Assert.That("((-67)-4)", Is.EqualTo(v.y));
            Assert.That("((-67)-4)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", null, "5", "((-1-4)2)");
            var v = ov.swizzle.aaab;
            Assert.That("((-1-4)2)", Is.EqualTo(v.x));
            Assert.That("((-1-4)2)", Is.EqualTo(v.y));
            Assert.That("((-1-4)2)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-4)", "-7", "", null);
            var v = ov.swizzle.aaaa;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec4<string>(null, "(-14)", "-1", "-4");
            var v1 = new gvec2<string>(null, "0");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(null, Is.EqualTo(v0.x));
            Assert.That("0", Is.EqualTo(v0.y));
            Assert.That("-1", Is.EqualTo(v0.z));
            Assert.That("-4", Is.EqualTo(v0.w));
        
            Assert.That(null, Is.EqualTo(v2.x));
            Assert.That("(-14)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>(null, "5", "(99)", "(99)");
            var v1 = new gvec2<string>("0", "1");
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("0", Is.EqualTo(v0.x));
            Assert.That("5", Is.EqualTo(v0.y));
            Assert.That("1", Is.EqualTo(v0.z));
            Assert.That("(99)", Is.EqualTo(v0.w));
        
            Assert.That(null, Is.EqualTo(v2.x));
            Assert.That("(99)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(1-4)", "6", "((42)9)", null);
            var v1 = new gvec2<string>("(-68)", "-9");
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(1-4)", Is.EqualTo(v0.x));
            Assert.That("(-68)", Is.EqualTo(v0.y));
            Assert.That("-9", Is.EqualTo(v0.z));
            Assert.That(null, Is.EqualTo(v0.w));
        
            Assert.That("6", Is.EqualTo(v2.x));
            Assert.That("((42)9)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((-8-6)-2)", "(4-3)", "(-1-6)", "(4-3)");
            var v1 = new gvec3<string>("(-35)", "((-8-7)-8)", "((66)-7)");
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-35)", Is.EqualTo(v0.x));
            Assert.That("((-8-7)-8)", Is.EqualTo(v0.y));
            Assert.That("((66)-7)", Is.EqualTo(v0.z));
            Assert.That("(4-3)", Is.EqualTo(v0.w));
        
            Assert.That("((-8-6)-2)", Is.EqualTo(v2.x));
            Assert.That("(4-3)", Is.EqualTo(v2.y));
            Assert.That("(-1-6)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(-61)", "4", "(-26)", "(-61)");
            var v1 = new gvec2<string>("(54)", "-2");
            var v2 = v0.xw;
            v0.xw = v1;
            var v3 = v0.xw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(54)", Is.EqualTo(v0.x));
            Assert.That("4", Is.EqualTo(v0.y));
            Assert.That("(-26)", Is.EqualTo(v0.z));
            Assert.That("-2", Is.EqualTo(v0.w));
        
            Assert.That("(-61)", Is.EqualTo(v2.x));
            Assert.That("(-61)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((-59)3)", "(44)", "-5", "-3");
            var v1 = new gvec2<string>("((4-2)1)", "((4-2)1)");
            var v2 = v0.yw;
            v0.yw = v1;
            var v3 = v0.yw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-59)3)", Is.EqualTo(v0.x));
            Assert.That("((4-2)1)", Is.EqualTo(v0.y));
            Assert.That("-5", Is.EqualTo(v0.z));
            Assert.That("((4-2)1)", Is.EqualTo(v0.w));
        
            Assert.That("(44)", Is.EqualTo(v2.x));
            Assert.That("-3", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((05)9)", "((-71)1)", "0", "4");
            var v1 = new gvec3<string>("((-2-3)8)", "((-24)-2)", "((-26)5)");
            var v2 = v0.xyw;
            v0.xyw = v1;
            var v3 = v0.xyw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-2-3)8)", Is.EqualTo(v0.x));
            Assert.That("((-24)-2)", Is.EqualTo(v0.y));
            Assert.That("0", Is.EqualTo(v0.z));
            Assert.That("((-26)5)", Is.EqualTo(v0.w));
        
            Assert.That("((05)9)", Is.EqualTo(v2.x));
            Assert.That("((-71)1)", Is.EqualTo(v2.y));
            Assert.That("4", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("((02)6)", "(9-2)", null, "((02)6)");
            var v1 = new gvec2<string>("((-47)-1)", "(-4-9)");
            var v2 = v0.zw;
            v0.zw = v1;
            var v3 = v0.zw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((02)6)", Is.EqualTo(v0.x));
            Assert.That("(9-2)", Is.EqualTo(v0.y));
            Assert.That("((-47)-1)", Is.EqualTo(v0.z));
            Assert.That("(-4-9)", Is.EqualTo(v0.w));
        
            Assert.That(null, Is.EqualTo(v2.x));
            Assert.That("((02)6)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(-80)", "2", null, "-9");
            var v1 = new gvec3<string>("", "((-1-8)6)", "5");
            var v2 = v0.xzw;
            v0.xzw = v1;
            var v3 = v0.xzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("2", Is.EqualTo(v0.y));
            Assert.That("((-1-8)6)", Is.EqualTo(v0.z));
            Assert.That("5", Is.EqualTo(v0.w));
        
            Assert.That("(-80)", Is.EqualTo(v2.x));
            Assert.That(null, Is.EqualTo(v2.y));
            Assert.That("-9", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("-2", "((-87)9)", "-2", "((7-9)5)");
            var v1 = new gvec3<string>("((32)-5)", "((-32)7)", "(7-9)");
            var v2 = v0.yzw;
            v0.yzw = v1;
            var v3 = v0.yzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-2", Is.EqualTo(v0.x));
            Assert.That("((32)-5)", Is.EqualTo(v0.y));
            Assert.That("((-32)7)", Is.EqualTo(v0.z));
            Assert.That("(7-9)", Is.EqualTo(v0.w));
        
            Assert.That("((-87)9)", Is.EqualTo(v2.x));
            Assert.That("-2", Is.EqualTo(v2.y));
            Assert.That("((7-9)5)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>(null, "((-47)4)", "2", "((-4-1)-7)");
            var v1 = new gvec4<string>("((-9-5)2)", "(-44)", "((-8-1)3)", "(-44)");
            var v2 = v0.xyzw;
            v0.xyzw = v1;
            var v3 = v0.xyzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-9-5)2)", Is.EqualTo(v0.x));
            Assert.That("(-44)", Is.EqualTo(v0.y));
            Assert.That("((-8-1)3)", Is.EqualTo(v0.z));
            Assert.That("(-44)", Is.EqualTo(v0.w));
        
            Assert.That(null, Is.EqualTo(v2.x));
            Assert.That("((-47)4)", Is.EqualTo(v2.y));
            Assert.That("2", Is.EqualTo(v2.z));
            Assert.That("((-4-1)-7)", Is.EqualTo(v2.w));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            gvec4<string> v0 = new gvec4<string>("((19)-9)", "-8", "-5", "((19)-9)");
            string v1 = null;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(null, Is.EqualTo(v0.x));
            Assert.That("-8", Is.EqualTo(v0.y));
            Assert.That("-5", Is.EqualTo(v0.z));
            Assert.That("((19)-9)", Is.EqualTo(v0.w));
        
            Assert.That("((19)-9)", Is.EqualTo(v2));
        }
        {
            gvec4<string> v0 = new gvec4<string>("((-60)5)", "0", "((-88)6)", "((5-6)0)");
            string v1 = "";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-60)5)", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("((-88)6)", Is.EqualTo(v0.z));
            Assert.That("((5-6)0)", Is.EqualTo(v0.w));
        
            Assert.That("0", Is.EqualTo(v2));
        }
        {
            gvec4<string> v0 = new gvec4<string>("(-46)", "((-29)-7)", null, "0");
            gvec2<string> v1 = new gvec2<string>("((-38)6)", "((-38)6)");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-38)6)", Is.EqualTo(v0.x));
            Assert.That("((-38)6)", Is.EqualTo(v0.y));
            Assert.That(null, Is.EqualTo(v0.z));
            Assert.That("0", Is.EqualTo(v0.w));
        
            Assert.That("(-46)", Is.EqualTo(v2.x));
            Assert.That("((-29)-7)", Is.EqualTo(v2.y));
        }
        {
            gvec4<string> v0 = new gvec4<string>("(50)", null, "1", "1");
            string v1 = "-8";
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(50)", Is.EqualTo(v0.x));
            Assert.That(null, Is.EqualTo(v0.y));
            Assert.That("-8", Is.EqualTo(v0.z));
            Assert.That("1", Is.EqualTo(v0.w));
        
            Assert.That("1", Is.EqualTo(v2));
        }
        {
            gvec4<string> v0 = new gvec4<string>("(-7-2)", "((48)1)", "((43)1)", "-2");
            gvec2<string> v1 = new gvec2<string>("", "((3-3)1)");
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("((48)1)", Is.EqualTo(v0.y));
            Assert.That("((3-3)1)", Is.EqualTo(v0.z));
            Assert.That("-2", Is.EqualTo(v0.w));
        
            Assert.That("(-7-2)", Is.EqualTo(v2.x));
            Assert.That("((43)1)", Is.EqualTo(v2.y));
        }
        {
            gvec4<string> v0 = new gvec4<string>("(26)", null, "6", "");
            gvec2<string> v1 = new gvec2<string>("(-97)", "9");
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(26)", Is.EqualTo(v0.x));
            Assert.That("(-97)", Is.EqualTo(v0.y));
            Assert.That("9", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That(null, Is.EqualTo(v2.x));
            Assert.That("6", Is.EqualTo(v2.y));
        }
        {
            gvec4<string> v0 = new gvec4<string>("3", "((3-3)-2)", "((-8-8)1)", "((-5-9)-5)");
            gvec3<string> v1 = new gvec3<string>("(-14)", "-3", null);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-14)", Is.EqualTo(v0.x));
            Assert.That("-3", Is.EqualTo(v0.y));
            Assert.That(null, Is.EqualTo(v0.z));
            Assert.That("((-5-9)-5)", Is.EqualTo(v0.w));
        
            Assert.That("3", Is.EqualTo(v2.x));
            Assert.That("((3-3)-2)", Is.EqualTo(v2.y));
            Assert.That("((-8-8)1)", Is.EqualTo(v2.z));
        }
        {
            gvec4<string> v0 = new gvec4<string>("((-1-8)2)", "8", "(37)", "(1-7)");
            string v1 = "3";
            var v2 = v0.a;
            v0.a = v1;
            var v3 = v0.a;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-1-8)2)", Is.EqualTo(v0.x));
            Assert.That("8", Is.EqualTo(v0.y));
            Assert.That("(37)", Is.EqualTo(v0.z));
            Assert.That("3", Is.EqualTo(v0.w));
        
            Assert.That("(1-7)", Is.EqualTo(v2));
        }
        {
            gvec4<string> v0 = new gvec4<string>(null, "", "(-4-7)", "9");
            gvec2<string> v1 = new gvec2<string>("((-43)9)", "-1");
            var v2 = v0.ra;
            v0.ra = v1;
            var v3 = v0.ra;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-43)9)", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("(-4-7)", Is.EqualTo(v0.z));
            Assert.That("-1", Is.EqualTo(v0.w));
        
            Assert.That(null, Is.EqualTo(v2.x));
            Assert.That("9", Is.EqualTo(v2.y));
        }
        {
            gvec4<string> v0 = new gvec4<string>("((5-5)9)", "((5-5)9)", "(51)", "6");
            gvec2<string> v1 = new gvec2<string>("(82)", "(26)");
            var v2 = v0.ga;
            v0.ga = v1;
            var v3 = v0.ga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((5-5)9)", Is.EqualTo(v0.x));
            Assert.That("(82)", Is.EqualTo(v0.y));
            Assert.That("(51)", Is.EqualTo(v0.z));
            Assert.That("(26)", Is.EqualTo(v0.w));
        
            Assert.That("((5-5)9)", Is.EqualTo(v2.x));
            Assert.That("6", Is.EqualTo(v2.y));
        }
        {
            gvec4<string> v0 = new gvec4<string>("3", "((3-7)-6)", "(05)", "-3");
            gvec3<string> v1 = new gvec3<string>("((9-1)-7)", "(16)", "(2-2)");
            var v2 = v0.rga;
            v0.rga = v1;
            var v3 = v0.rga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((9-1)-7)", Is.EqualTo(v0.x));
            Assert.That("(16)", Is.EqualTo(v0.y));
            Assert.That("(05)", Is.EqualTo(v0.z));
            Assert.That("(2-2)", Is.EqualTo(v0.w));
        
            Assert.That("3", Is.EqualTo(v2.x));
            Assert.That("((3-7)-6)", Is.EqualTo(v2.y));
            Assert.That("-3", Is.EqualTo(v2.z));
        }
        {
            gvec4<string> v0 = new gvec4<string>("(6-2)", "(6-7)", null, "(6-7)");
            gvec2<string> v1 = new gvec2<string>("(2-5)", "(-5-5)");
            var v2 = v0.ba;
            v0.ba = v1;
            var v3 = v0.ba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(6-2)", Is.EqualTo(v0.x));
            Assert.That("(6-7)", Is.EqualTo(v0.y));
            Assert.That("(2-5)", Is.EqualTo(v0.z));
            Assert.That("(-5-5)", Is.EqualTo(v0.w));
        
            Assert.That(null, Is.EqualTo(v2.x));
            Assert.That("(6-7)", Is.EqualTo(v2.y));
        }
        {
            gvec4<string> v0 = new gvec4<string>("", null, "((32)-5)", "-2");
            gvec3<string> v1 = new gvec3<string>("(21)", "", "(68)");
            var v2 = v0.rba;
            v0.rba = v1;
            var v3 = v0.rba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(21)", Is.EqualTo(v0.x));
            Assert.That(null, Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That("(68)", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("((32)-5)", Is.EqualTo(v2.y));
            Assert.That("-2", Is.EqualTo(v2.z));
        }
        {
            gvec4<string> v0 = new gvec4<string>("7", "", null, null);
            gvec3<string> v1 = new gvec3<string>(null, "(5-4)", "(-45)");
            var v2 = v0.gba;
            v0.gba = v1;
            var v3 = v0.gba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("7", Is.EqualTo(v0.x));
            Assert.That(null, Is.EqualTo(v0.y));
            Assert.That("(5-4)", Is.EqualTo(v0.z));
            Assert.That("(-45)", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That(null, Is.EqualTo(v2.y));
            Assert.That(null, Is.EqualTo(v2.z));
        }
        {
            gvec4<string> v0 = new gvec4<string>("((-3-2)7)", "6", "6", "((-3-8)5)");
            gvec4<string> v1 = new gvec4<string>("(76)", "((24)8)", "2", "0");
            var v2 = v0.rgba;
            v0.rgba = v1;
            var v3 = v0.rgba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(76)", Is.EqualTo(v0.x));
            Assert.That("((24)8)", Is.EqualTo(v0.y));
            Assert.That("2", Is.EqualTo(v0.z));
            Assert.That("0", Is.EqualTo(v0.w));
        
            Assert.That("((-3-2)7)", Is.EqualTo(v2.x));
            Assert.That("6", Is.EqualTo(v2.y));
            Assert.That("6", Is.EqualTo(v2.z));
            Assert.That("((-3-8)5)", Is.EqualTo(v2.w));
        }
    }

}
