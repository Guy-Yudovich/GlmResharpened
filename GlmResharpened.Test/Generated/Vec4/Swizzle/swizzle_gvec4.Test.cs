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
            var ov = new gvec4<string>("8", "6", "", "((-93)-2)");
            var v = ov.swizzle.xx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(02)", "", "6", "(02)");
            var v = ov.swizzle.xxx;
            Assert.That("(02)", Is.EqualTo(v.x));
            Assert.That("(02)", Is.EqualTo(v.y));
            Assert.That("(02)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("3", "((-31)-6)", "(-51)", "((52)-4)");
            var v = ov.swizzle.xxxx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-2", "((6-4)5)", "-2");
            var v = ov.swizzle.xxxy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-1)-7)", "-2", "-9", null);
            var v = ov.swizzle.xxxz;
            Assert.That("((7-1)-7)", Is.EqualTo(v.x));
            Assert.That("((7-1)-7)", Is.EqualTo(v.y));
            Assert.That("((7-1)-7)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-2)", "(-9-2)", "-2", "");
            var v = ov.swizzle.xxxw;
            Assert.That("(-9-2)", Is.EqualTo(v.x));
            Assert.That("(-9-2)", Is.EqualTo(v.y));
            Assert.That("(-9-2)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((90)-9)", "(49)", "8", "((-4-5)-2)");
            var v = ov.swizzle.xxy;
            Assert.That("((90)-9)", Is.EqualTo(v.x));
            Assert.That("((90)-9)", Is.EqualTo(v.y));
            Assert.That("(49)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-1", null, "", "-3");
            var v = ov.swizzle.xxyx;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-8)1)", "-4", null, "(-84)");
            var v = ov.swizzle.xxyy;
            Assert.That("((3-8)1)", Is.EqualTo(v.x));
            Assert.That("((3-8)1)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-27)2)", "8", "((-27)2)", "((-2-8)-3)");
            var v = ov.swizzle.xxyz;
            Assert.That("((-27)2)", Is.EqualTo(v.x));
            Assert.That("((-27)2)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((-27)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-4)5)", "(1-7)", null, "-6");
            var v = ov.swizzle.xxyw;
            Assert.That("((-3-4)5)", Is.EqualTo(v.x));
            Assert.That("((-3-4)5)", Is.EqualTo(v.y));
            Assert.That("(1-7)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-7)5)", "(08)", "(26)", "-3");
            var v = ov.swizzle.xxz;
            Assert.That("((9-7)5)", Is.EqualTo(v.x));
            Assert.That("((9-7)5)", Is.EqualTo(v.y));
            Assert.That("(26)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-7", "-7", "", "((3-5)-9)");
            var v = ov.swizzle.xxzx;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((2-7)-7)", "-3", "-9");
            var v = ov.swizzle.xxzy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("((2-7)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-90)4)", "((79)-9)", "((1-4)8)", "(03)");
            var v = ov.swizzle.xxzz;
            Assert.That("((-90)4)", Is.EqualTo(v.x));
            Assert.That("((-90)4)", Is.EqualTo(v.y));
            Assert.That("((1-4)8)", Is.EqualTo(v.z));
            Assert.That("((1-4)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-3)", "4", null, "4");
            var v = ov.swizzle.xxzw;
            Assert.That("(8-3)", Is.EqualTo(v.x));
            Assert.That("(8-3)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "", "((3-2)1)", "(-7-3)");
            var v = ov.swizzle.xxw;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(-7-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(76)", "", "((-85)-9)", "(76)");
            var v = ov.swizzle.xxwx;
            Assert.That("(76)", Is.EqualTo(v.x));
            Assert.That("(76)", Is.EqualTo(v.y));
            Assert.That("(76)", Is.EqualTo(v.z));
            Assert.That("(76)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-65)", "(5-6)", "(-22)", "((-35)4)");
            var v = ov.swizzle.xxwy;
            Assert.That("(-65)", Is.EqualTo(v.x));
            Assert.That("(-65)", Is.EqualTo(v.y));
            Assert.That("((-35)4)", Is.EqualTo(v.z));
            Assert.That("(5-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-6)", "((-6-3)-9)", "((-6-3)-9)", "((-69)7)");
            var v = ov.swizzle.xxwz;
            Assert.That("(-7-6)", Is.EqualTo(v.x));
            Assert.That("(-7-6)", Is.EqualTo(v.y));
            Assert.That("((-69)7)", Is.EqualTo(v.z));
            Assert.That("((-6-3)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((77)0)", "((77)0)", null, "((15)-9)");
            var v = ov.swizzle.xxww;
            Assert.That("((77)0)", Is.EqualTo(v.x));
            Assert.That("((77)0)", Is.EqualTo(v.y));
            Assert.That("((15)-9)", Is.EqualTo(v.z));
            Assert.That("((15)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "2", "4", "(68)");
            var v = ov.swizzle.xy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-5-1)", "(-26)", "(-26)", "((5-2)9)");
            var v = ov.swizzle.xyx;
            Assert.That("(-5-1)", Is.EqualTo(v.x));
            Assert.That("(-26)", Is.EqualTo(v.y));
            Assert.That("(-5-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((5-5)7)", "((5-5)7)", "1", null);
            var v = ov.swizzle.xyxx;
            Assert.That("((5-5)7)", Is.EqualTo(v.x));
            Assert.That("((5-5)7)", Is.EqualTo(v.y));
            Assert.That("((5-5)7)", Is.EqualTo(v.z));
            Assert.That("((5-5)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-25)-2)", "(-8-2)", "(-8-2)", null);
            var v = ov.swizzle.xyxy;
            Assert.That("((-25)-2)", Is.EqualTo(v.x));
            Assert.That("(-8-2)", Is.EqualTo(v.y));
            Assert.That("((-25)-2)", Is.EqualTo(v.z));
            Assert.That("(-8-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "(64)", "(-55)", "");
            var v = ov.swizzle.xyxz;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(64)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(-55)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-9)", "2", "((-8-5)-3)", "((3-1)2)");
            var v = ov.swizzle.xyxw;
            Assert.That("(-1-9)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(-1-9)", Is.EqualTo(v.z));
            Assert.That("((3-1)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-7)-8)", "((-68)-9)", "((-1-7)-8)", "9");
            var v = ov.swizzle.xyy;
            Assert.That("((-1-7)-8)", Is.EqualTo(v.x));
            Assert.That("((-68)-9)", Is.EqualTo(v.y));
            Assert.That("((-68)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(16)", "(-5-6)", "8", "(16)");
            var v = ov.swizzle.xyyx;
            Assert.That("(16)", Is.EqualTo(v.x));
            Assert.That("(-5-6)", Is.EqualTo(v.y));
            Assert.That("(-5-6)", Is.EqualTo(v.z));
            Assert.That("(16)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((3-3)6)", "", "(-25)");
            var v = ov.swizzle.xyyy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((3-3)6)", Is.EqualTo(v.y));
            Assert.That("((3-3)6)", Is.EqualTo(v.z));
            Assert.That("((3-3)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "-4", "(9-7)", "-4");
            var v = ov.swizzle.xyyz;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(9-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-4)", "(-3-2)", "((7-4)-8)", "");
            var v = ov.swizzle.xyyw;
            Assert.That("(2-4)", Is.EqualTo(v.x));
            Assert.That("(-3-2)", Is.EqualTo(v.y));
            Assert.That("(-3-2)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-8)0)", "((-9-8)0)", "((-84)8)", null);
            var v = ov.swizzle.xyz;
            Assert.That("((-9-8)0)", Is.EqualTo(v.x));
            Assert.That("((-9-8)0)", Is.EqualTo(v.y));
            Assert.That("((-84)8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((9-9)7)", "(-5-7)", "-4", "5");
            var v = ov.swizzle.xyzx;
            Assert.That("((9-9)7)", Is.EqualTo(v.x));
            Assert.That("(-5-7)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("((9-9)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(15)", null, "9");
            var v = ov.swizzle.xyzy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(15)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(15)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(7-1)", null, "(54)");
            var v = ov.swizzle.xyzz;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(7-1)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-2", "", "(8-1)");
            var v = ov.swizzle.xyzw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(8-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "((-18)0)", "(-92)");
            var v = ov.swizzle.xyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-92)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((44)8)", "", "7", "");
            var v = ov.swizzle.xywx;
            Assert.That("((44)8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((44)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "((-1-3)-1)", "", "(-72)");
            var v = ov.swizzle.xywy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((-1-3)-1)", Is.EqualTo(v.y));
            Assert.That("(-72)", Is.EqualTo(v.z));
            Assert.That("((-1-3)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "(-33)", "((91)1)", "(-33)");
            var v = ov.swizzle.xywz;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(-33)", Is.EqualTo(v.y));
            Assert.That("(-33)", Is.EqualTo(v.z));
            Assert.That("((91)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-3)", "-6", "(5-3)", "");
            var v = ov.swizzle.xyww;
            Assert.That("(5-3)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-4)", "(6-4)", "(-3-4)", "2");
            var v = ov.swizzle.xz;
            Assert.That("(6-4)", Is.EqualTo(v.x));
            Assert.That("(-3-4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(3-4)", "-9", "", "(3-4)");
            var v = ov.swizzle.xzx;
            Assert.That("(3-4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(3-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("0", "6", "0", "0");
            var v = ov.swizzle.xzxx;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-3)", "", "(-55)", "((61)8)");
            var v = ov.swizzle.xzxy;
            Assert.That("(1-3)", Is.EqualTo(v.x));
            Assert.That("(-55)", Is.EqualTo(v.y));
            Assert.That("(1-3)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-10)", "-9", "-9");
            var v = ov.swizzle.xzxz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "(16)", "-3");
            var v = ov.swizzle.xzxw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(16)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "-7", "((51)2)", null);
            var v = ov.swizzle.xzy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((51)2)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "((-37)6)", "-2", "-2");
            var v = ov.swizzle.xzyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((-37)6)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-9)-9)", "(0-3)", null, "-1");
            var v = ov.swizzle.xzyy;
            Assert.That("((-5-9)-9)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(0-3)", Is.EqualTo(v.z));
            Assert.That("(0-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((5-1)-3)", null, null);
            var v = ov.swizzle.xzyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((5-1)-3)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(45)", "(4-7)", "((5-1)3)", "-6");
            var v = ov.swizzle.xzyw;
            Assert.That("(45)", Is.EqualTo(v.x));
            Assert.That("((5-1)3)", Is.EqualTo(v.y));
            Assert.That("(4-7)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "", null, "(-68)");
            var v = ov.swizzle.xzz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-2-9)", "0", "0", "");
            var v = ov.swizzle.xzzx;
            Assert.That("(-2-9)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("(-2-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "3", "(-49)", "3");
            var v = ov.swizzle.xzzy;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(-49)", Is.EqualTo(v.y));
            Assert.That("(-49)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-11)0)", "(-36)", "((-69)9)", "4");
            var v = ov.swizzle.xzzz;
            Assert.That("((-11)0)", Is.EqualTo(v.x));
            Assert.That("((-69)9)", Is.EqualTo(v.y));
            Assert.That("((-69)9)", Is.EqualTo(v.z));
            Assert.That("((-69)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-8)-4)", "8", "((-4-8)-4)", "((-9-7)-4)");
            var v = ov.swizzle.xzzw;
            Assert.That("((-4-8)-4)", Is.EqualTo(v.x));
            Assert.That("((-4-8)-4)", Is.EqualTo(v.y));
            Assert.That("((-4-8)-4)", Is.EqualTo(v.z));
            Assert.That("((-9-7)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((00)-9)", "(-39)", "5", "");
            var v = ov.swizzle.xzw;
            Assert.That("((00)-9)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-25)", "((-36)-3)", "2", "(-25)");
            var v = ov.swizzle.xzwx;
            Assert.That("(-25)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(-25)", Is.EqualTo(v.z));
            Assert.That("(-25)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-1)", "-1", "((1-7)5)", "((-13)3)");
            var v = ov.swizzle.xzwy;
            Assert.That("(8-1)", Is.EqualTo(v.x));
            Assert.That("((1-7)5)", Is.EqualTo(v.y));
            Assert.That("((-13)3)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-37)", "(5-8)", "-3");
            var v = ov.swizzle.xzwz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(5-8)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(5-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((71)4)", "(-82)", "", "((71)4)");
            var v = ov.swizzle.xzww;
            Assert.That("((71)4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((71)4)", Is.EqualTo(v.z));
            Assert.That("((71)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-2)-4)", "((7-7)7)", "-7", "(-4-5)");
            var v = ov.swizzle.xw;
            Assert.That("((-7-2)-4)", Is.EqualTo(v.x));
            Assert.That("(-4-5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-6-9)", "(7-3)", "(7-3)", "((-42)1)");
            var v = ov.swizzle.xwx;
            Assert.That("(-6-9)", Is.EqualTo(v.x));
            Assert.That("((-42)1)", Is.EqualTo(v.y));
            Assert.That("(-6-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-4-1)", "((-47)-8)", "-9", "");
            var v = ov.swizzle.xwxx;
            Assert.That("(-4-1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-4-1)", Is.EqualTo(v.z));
            Assert.That("(-4-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-7)0)", "((3-8)-1)", "(5-2)", "((3-8)-1)");
            var v = ov.swizzle.xwxy;
            Assert.That("((1-7)0)", Is.EqualTo(v.x));
            Assert.That("((3-8)-1)", Is.EqualTo(v.y));
            Assert.That("((1-7)0)", Is.EqualTo(v.z));
            Assert.That("((3-8)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((41)7)", "((4-8)5)", "(7-4)", "((4-8)5)");
            var v = ov.swizzle.xwxz;
            Assert.That("((41)7)", Is.EqualTo(v.x));
            Assert.That("((4-8)5)", Is.EqualTo(v.y));
            Assert.That("((41)7)", Is.EqualTo(v.z));
            Assert.That("(7-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "-7", "-7", "((14)-3)");
            var v = ov.swizzle.xwxw;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((14)-3)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((14)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "1", "-3", "(70)");
            var v = ov.swizzle.xwy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(70)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "((14)2)", "((14)2)", "((-84)-3)");
            var v = ov.swizzle.xwyx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-84)-3)", Is.EqualTo(v.y));
            Assert.That("((14)2)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-5)", "", "2", null);
            var v = ov.swizzle.xwyy;
            Assert.That("(1-5)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "", "", "-2");
            var v = ov.swizzle.xwyz;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "", null, "((-17)-5)");
            var v = ov.swizzle.xwyw;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((-17)-5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-17)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-7)", "", "-3", "(8-9)");
            var v = ov.swizzle.xwz;
            Assert.That("(1-7)", Is.EqualTo(v.x));
            Assert.That("(8-9)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("7", "(-57)", "(87)", "(87)");
            var v = ov.swizzle.xwzx;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(87)", Is.EqualTo(v.y));
            Assert.That("(87)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-7)-1)", "-7", "-2", "((-1-7)-1)");
            var v = ov.swizzle.xwzy;
            Assert.That("((-1-7)-1)", Is.EqualTo(v.x));
            Assert.That("((-1-7)-1)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-36)", "(-36)", "", "((80)9)");
            var v = ov.swizzle.xwzz;
            Assert.That("(-36)", Is.EqualTo(v.x));
            Assert.That("((80)9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "-9", "(4-7)", "(69)");
            var v = ov.swizzle.xwzw;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("(69)", Is.EqualTo(v.y));
            Assert.That("(4-7)", Is.EqualTo(v.z));
            Assert.That("(69)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-8)", "", "-4", "((33)-3)");
            var v = ov.swizzle.xww;
            Assert.That("(-7-8)", Is.EqualTo(v.x));
            Assert.That("((33)-3)", Is.EqualTo(v.y));
            Assert.That("((33)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-2", "((1-7)-8)", "", "((-8-5)-2)");
            var v = ov.swizzle.xwwx;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((-8-5)-2)", Is.EqualTo(v.y));
            Assert.That("((-8-5)-2)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-30)", "2", "-6", "((8-3)-5)");
            var v = ov.swizzle.xwwy;
            Assert.That("(-30)", Is.EqualTo(v.x));
            Assert.That("((8-3)-5)", Is.EqualTo(v.y));
            Assert.That("((8-3)-5)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-4-4)", "(9-1)", "4");
            var v = ov.swizzle.xwwz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(60)", "((-2-3)-9)", "6");
            var v = ov.swizzle.xwww;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(82)", "(82)", "-7", "((5-4)8)");
            var v = ov.swizzle.yx;
            Assert.That("(82)", Is.EqualTo(v.x));
            Assert.That("(82)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(61)", "(1-2)", "(1-2)", null);
            var v = ov.swizzle.yxx;
            Assert.That("(1-2)", Is.EqualTo(v.x));
            Assert.That("(61)", Is.EqualTo(v.y));
            Assert.That("(61)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("4", "((26)-8)", "4", "((26)-8)");
            var v = ov.swizzle.yxxx;
            Assert.That("((26)-8)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-3)", "-8", "-8", "-3");
            var v = ov.swizzle.yxxy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(5-3)", Is.EqualTo(v.y));
            Assert.That("(5-3)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "(-72)", "", "0");
            var v = ov.swizzle.yxxz;
            Assert.That("(-72)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-8)8)", "((0-8)8)", "((8-5)5)", "(-6-3)");
            var v = ov.swizzle.yxxw;
            Assert.That("((0-8)8)", Is.EqualTo(v.x));
            Assert.That("((0-8)8)", Is.EqualTo(v.y));
            Assert.That("((0-8)8)", Is.EqualTo(v.z));
            Assert.That("(-6-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(26)", "(3-9)", "(26)");
            var v = ov.swizzle.yxy;
            Assert.That("(26)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(26)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("4", "", null, "7");
            var v = ov.swizzle.yxyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "9", "3", "(43)");
            var v = ov.swizzle.yxyy;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-4)-1)", "((67)2)", "-1", "-7");
            var v = ov.swizzle.yxyz;
            Assert.That("((67)2)", Is.EqualTo(v.x));
            Assert.That("((-9-4)-1)", Is.EqualTo(v.y));
            Assert.That("((67)2)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-4)-5)", "(3-3)", "-7", "((-88)6)");
            var v = ov.swizzle.yxyw;
            Assert.That("(3-3)", Is.EqualTo(v.x));
            Assert.That("((9-4)-5)", Is.EqualTo(v.y));
            Assert.That("(3-3)", Is.EqualTo(v.z));
            Assert.That("((-88)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-1)1)", "1", "((0-4)5)", "-3");
            var v = ov.swizzle.yxz;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((-4-1)1)", Is.EqualTo(v.y));
            Assert.That("((0-4)5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-72)", "-4", "((-4-4)7)", "(1-1)");
            var v = ov.swizzle.yxzx;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(-72)", Is.EqualTo(v.y));
            Assert.That("((-4-4)7)", Is.EqualTo(v.z));
            Assert.That("(-72)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((1-7)5)", "(7-8)", "((-25)7)");
            var v = ov.swizzle.yxzy;
            Assert.That("((1-7)5)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(7-8)", Is.EqualTo(v.z));
            Assert.That("((1-7)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-3-4)", null, "(5-3)");
            var v = ov.swizzle.yxzz;
            Assert.That("(-3-4)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "((9-1)-2)", null, "");
            var v = ov.swizzle.yxzw;
            Assert.That("((9-1)-2)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-67)3)", null, "(7-8)", "(30)");
            var v = ov.swizzle.yxw;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-67)3)", Is.EqualTo(v.y));
            Assert.That("(30)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("8", "8", null, "3");
            var v = ov.swizzle.yxwx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "3", "((-9-1)3)", "");
            var v = ov.swizzle.yxwy;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "-8", "(05)", "(8-7)");
            var v = ov.swizzle.yxwz;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(8-7)", Is.EqualTo(v.z));
            Assert.That("(05)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-8", "((-1-6)-1)", "((-1-6)-1)");
            var v = ov.swizzle.yxww;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-1-6)-1)", Is.EqualTo(v.z));
            Assert.That("((-1-6)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "7", "((21)6)", "7");
            var v = ov.swizzle.yy;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-7-1)", "(-7-1)", "(60)", "((12)-2)");
            var v = ov.swizzle.yyx;
            Assert.That("(-7-1)", Is.EqualTo(v.x));
            Assert.That("(-7-1)", Is.EqualTo(v.y));
            Assert.That("(-7-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(97)", null, "((-16)2)");
            var v = ov.swizzle.yyxx;
            Assert.That("(97)", Is.EqualTo(v.x));
            Assert.That("(97)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(96)", "5", "6", "6");
            var v = ov.swizzle.yyxy;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(96)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-40)", "", "-2");
            var v = ov.swizzle.yyxz;
            Assert.That("(-40)", Is.EqualTo(v.x));
            Assert.That("(-40)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "6", "(-52)", "4");
            var v = ov.swizzle.yyxw;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(-6-2)", "((-6-3)-2)", null);
            var v = ov.swizzle.yyy;
            Assert.That("(-6-2)", Is.EqualTo(v.x));
            Assert.That("(-6-2)", Is.EqualTo(v.y));
            Assert.That("(-6-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "-8", "-6", "(-28)");
            var v = ov.swizzle.yyyx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-8)7)", "", null, null);
            var v = ov.swizzle.yyyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-3", "((94)1)", "((-44)-9)");
            var v = ov.swizzle.yyyz;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("((94)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "", "(6-5)", "((-8-7)-7)");
            var v = ov.swizzle.yyyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-8-7)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "((9-2)9)", "((-67)-4)", "((-67)-4)");
            var v = ov.swizzle.yyz;
            Assert.That("((9-2)9)", Is.EqualTo(v.x));
            Assert.That("((9-2)9)", Is.EqualTo(v.y));
            Assert.That("((-67)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "((37)5)", "(53)", "((9-3)3)");
            var v = ov.swizzle.yyzx;
            Assert.That("((37)5)", Is.EqualTo(v.x));
            Assert.That("((37)5)", Is.EqualTo(v.y));
            Assert.That("(53)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-8)", "((55)-1)", "(-18)", "(-22)");
            var v = ov.swizzle.yyzy;
            Assert.That("((55)-1)", Is.EqualTo(v.x));
            Assert.That("((55)-1)", Is.EqualTo(v.y));
            Assert.That("(-18)", Is.EqualTo(v.z));
            Assert.That("((55)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((61)7)", null, "((3-2)1)");
            var v = ov.swizzle.yyzz;
            Assert.That("((61)7)", Is.EqualTo(v.x));
            Assert.That("((61)7)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-75)9)", "(-24)", "6", "((9-4)3)");
            var v = ov.swizzle.yyzw;
            Assert.That("(-24)", Is.EqualTo(v.x));
            Assert.That("(-24)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("((9-4)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((6-4)5)", "(-7-2)", "8", "8");
            var v = ov.swizzle.yyw;
            Assert.That("(-7-2)", Is.EqualTo(v.x));
            Assert.That("(-7-2)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-3-9)", "(-7-9)", "1", "(-3-9)");
            var v = ov.swizzle.yywx;
            Assert.That("(-7-9)", Is.EqualTo(v.x));
            Assert.That("(-7-9)", Is.EqualTo(v.y));
            Assert.That("(-3-9)", Is.EqualTo(v.z));
            Assert.That("(-3-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-7)7)", "-9", "((38)4)", "(7-9)");
            var v = ov.swizzle.yywy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("(7-9)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-1)2)", "(2-2)", "0", "((-30)-5)");
            var v = ov.swizzle.yywz;
            Assert.That("(2-2)", Is.EqualTo(v.x));
            Assert.That("(2-2)", Is.EqualTo(v.y));
            Assert.That("((-30)-5)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-4)", "(-9-4)", "(-9-1)", null);
            var v = ov.swizzle.yyww;
            Assert.That("(-9-4)", Is.EqualTo(v.x));
            Assert.That("(-9-4)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "0", "0", "((76)6)");
            var v = ov.swizzle.yz;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>(null, "(-8-2)", "((39)-8)", "((39)-8)");
            var v = ov.swizzle.yzx;
            Assert.That("(-8-2)", Is.EqualTo(v.x));
            Assert.That("((39)-8)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-91)-3)", "(61)", "((-59)9)", "((-91)-3)");
            var v = ov.swizzle.yzxx;
            Assert.That("(61)", Is.EqualTo(v.x));
            Assert.That("((-59)9)", Is.EqualTo(v.y));
            Assert.That("((-91)-3)", Is.EqualTo(v.z));
            Assert.That("((-91)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "4", "((2-2)3)", "(-88)");
            var v = ov.swizzle.yzxy;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((2-2)3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((14)9)", "", "(5-2)", "(5-2)");
            var v = ov.swizzle.yzxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(5-2)", Is.EqualTo(v.y));
            Assert.That("((14)9)", Is.EqualTo(v.z));
            Assert.That("(5-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, null, "0", null);
            var v = ov.swizzle.yzxw;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(76)", "", "((26)-9)", "(9-6)");
            var v = ov.swizzle.yzy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((26)-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(4-8)", "-6", "4");
            var v = ov.swizzle.yzyx;
            Assert.That("(4-8)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(4-8)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-73)", "(-35)", "0", null);
            var v = ov.swizzle.yzyy;
            Assert.That("(-35)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("(-35)", Is.EqualTo(v.z));
            Assert.That("(-35)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "6", "", "((8-6)6)");
            var v = ov.swizzle.yzyz;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(9-3)", "(-96)", "");
            var v = ov.swizzle.yzyw;
            Assert.That("(9-3)", Is.EqualTo(v.x));
            Assert.That("(-96)", Is.EqualTo(v.y));
            Assert.That("(9-3)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", null, "4", "");
            var v = ov.swizzle.yzz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((57)0)", "", "-3", "((-9-4)5)");
            var v = ov.swizzle.yzzx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("((57)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-4)", "((9-8)2)", "(7-1)", "((9-8)2)");
            var v = ov.swizzle.yzzy;
            Assert.That("((9-8)2)", Is.EqualTo(v.x));
            Assert.That("(7-1)", Is.EqualTo(v.y));
            Assert.That("(7-1)", Is.EqualTo(v.z));
            Assert.That("((9-8)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((17)2)", "(-67)", "(-67)", "(-3-6)");
            var v = ov.swizzle.yzzz;
            Assert.That("(-67)", Is.EqualTo(v.x));
            Assert.That("(-67)", Is.EqualTo(v.y));
            Assert.That("(-67)", Is.EqualTo(v.z));
            Assert.That("(-67)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "(-13)", "", "(-13)");
            var v = ov.swizzle.yzzw;
            Assert.That("(-13)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-13)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((41)2)", "(14)", "(80)", "(14)");
            var v = ov.swizzle.yzw;
            Assert.That("(14)", Is.EqualTo(v.x));
            Assert.That("(80)", Is.EqualTo(v.y));
            Assert.That("(14)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((9-6)-5)", null, null, "-5");
            var v = ov.swizzle.yzwx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("((9-6)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-7)5)", "-9", "((-54)3)", "((-54)3)");
            var v = ov.swizzle.yzwy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((-54)3)", Is.EqualTo(v.y));
            Assert.That("((-54)3)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-87)", "((-5-1)6)", "1", null);
            var v = ov.swizzle.yzwz;
            Assert.That("((-5-1)6)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(22)", "-8", "(5-2)", "-8");
            var v = ov.swizzle.yzww;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(5-2)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((9-8)4)", "((9-5)1)", "((-96)0)");
            var v = ov.swizzle.yw;
            Assert.That("((9-8)4)", Is.EqualTo(v.x));
            Assert.That("((-96)0)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-78)", "-2", null, "((75)-5)");
            var v = ov.swizzle.ywx;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((75)-5)", Is.EqualTo(v.y));
            Assert.That("(-78)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, null, "((-5-4)-5)", "((-27)4)");
            var v = ov.swizzle.ywxx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-27)4)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-1", null, null);
            var v = ov.swizzle.ywxy;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((15)2)", "1", "7");
            var v = ov.swizzle.ywxz;
            Assert.That("((15)2)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-1)", "((-50)9)", "((-50)9)", "(9-1)");
            var v = ov.swizzle.ywxw;
            Assert.That("((-50)9)", Is.EqualTo(v.x));
            Assert.That("(9-1)", Is.EqualTo(v.y));
            Assert.That("(9-1)", Is.EqualTo(v.z));
            Assert.That("(9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "8", "", "(58)");
            var v = ov.swizzle.ywy;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(58)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((80)8)", "(-26)", null, "(-51)");
            var v = ov.swizzle.ywyx;
            Assert.That("(-26)", Is.EqualTo(v.x));
            Assert.That("(-51)", Is.EqualTo(v.y));
            Assert.That("(-26)", Is.EqualTo(v.z));
            Assert.That("((80)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "((89)-1)", "((81)-6)", "(-62)");
            var v = ov.swizzle.ywyy;
            Assert.That("((89)-1)", Is.EqualTo(v.x));
            Assert.That("(-62)", Is.EqualTo(v.y));
            Assert.That("((89)-1)", Is.EqualTo(v.z));
            Assert.That("((89)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-9)", null, "8", "(-2-9)");
            var v = ov.swizzle.ywyz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-2-9)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", null, "((-2-2)6)", "1");
            var v = ov.swizzle.ywyw;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((-80)6)", "-6", "((-80)6)");
            var v = ov.swizzle.ywz;
            Assert.That("((-80)6)", Is.EqualTo(v.x));
            Assert.That("((-80)6)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(2-4)", null, null, "((-53)4)");
            var v = ov.swizzle.ywzx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-53)4)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(2-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-1)5)", "((77)3)", null, "5");
            var v = ov.swizzle.ywzy;
            Assert.That("((77)3)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((77)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(27)", "((0-7)-7)", "(2-6)", "2");
            var v = ov.swizzle.ywzz;
            Assert.That("((0-7)-7)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(2-6)", Is.EqualTo(v.z));
            Assert.That("(2-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "", "((-3-3)0)", "");
            var v = ov.swizzle.ywzw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-3-3)0)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-1)", "-1", null, "((63)-2)");
            var v = ov.swizzle.yww;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((63)-2)", Is.EqualTo(v.y));
            Assert.That("((63)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((2-1)-6)", "((-98)-9)", "", "(54)");
            var v = ov.swizzle.ywwx;
            Assert.That("((-98)-9)", Is.EqualTo(v.x));
            Assert.That("(54)", Is.EqualTo(v.y));
            Assert.That("(54)", Is.EqualTo(v.z));
            Assert.That("((2-1)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-15)", "(-2-9)", "(-2-9)");
            var v = ov.swizzle.ywwy;
            Assert.That("(-15)", Is.EqualTo(v.x));
            Assert.That("(-2-9)", Is.EqualTo(v.y));
            Assert.That("(-2-9)", Is.EqualTo(v.z));
            Assert.That("(-15)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((77)6)", "", "(2-2)", null);
            var v = ov.swizzle.ywwz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(2-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-4)2)", "((-7-9)4)", "((2-4)2)", "((2-4)2)");
            var v = ov.swizzle.ywww;
            Assert.That("((-7-9)4)", Is.EqualTo(v.x));
            Assert.That("((2-4)2)", Is.EqualTo(v.y));
            Assert.That("((2-4)2)", Is.EqualTo(v.z));
            Assert.That("((2-4)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-94)-7)", "2", "(3-6)", "((-94)-7)");
            var v = ov.swizzle.zx;
            Assert.That("(3-6)", Is.EqualTo(v.x));
            Assert.That("((-94)-7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((2-3)4)", "((2-3)4)", "-2", null);
            var v = ov.swizzle.zxx;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((2-3)4)", Is.EqualTo(v.y));
            Assert.That("((2-3)4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("3", "(19)", "(19)", "(19)");
            var v = ov.swizzle.zxxx;
            Assert.That("(19)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(17)", null, "(17)", "((69)-4)");
            var v = ov.swizzle.zxxy;
            Assert.That("(17)", Is.EqualTo(v.x));
            Assert.That("(17)", Is.EqualTo(v.y));
            Assert.That("(17)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(90)", "-3", "(90)", "3");
            var v = ov.swizzle.zxxz;
            Assert.That("(90)", Is.EqualTo(v.x));
            Assert.That("(90)", Is.EqualTo(v.y));
            Assert.That("(90)", Is.EqualTo(v.z));
            Assert.That("(90)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-9", "((-1-3)9)", "(7-4)");
            var v = ov.swizzle.zxxw;
            Assert.That("((-1-3)9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(7-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-67)", "5", "(33)");
            var v = ov.swizzle.zxy;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(-67)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(3-7)", "(8-3)", "((-4-2)-6)", "(8-3)");
            var v = ov.swizzle.zxyx;
            Assert.That("((-4-2)-6)", Is.EqualTo(v.x));
            Assert.That("(3-7)", Is.EqualTo(v.y));
            Assert.That("(8-3)", Is.EqualTo(v.z));
            Assert.That("(3-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "((56)8)", "2", "((4-6)-2)");
            var v = ov.swizzle.zxyy;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((56)8)", Is.EqualTo(v.z));
            Assert.That("((56)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-4)", "((3-6)-4)", "((7-9)4)", "(-5-4)");
            var v = ov.swizzle.zxyz;
            Assert.That("((7-9)4)", Is.EqualTo(v.x));
            Assert.That("(-5-4)", Is.EqualTo(v.y));
            Assert.That("((3-6)-4)", Is.EqualTo(v.z));
            Assert.That("((7-9)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-6)7)", "-7", "(02)", "7");
            var v = ov.swizzle.zxyw;
            Assert.That("(02)", Is.EqualTo(v.x));
            Assert.That("((-3-6)7)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-41)", "", "(-85)");
            var v = ov.swizzle.zxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-3-9)0)", "8", "((-5-7)6)", null);
            var v = ov.swizzle.zxzx;
            Assert.That("((-5-7)6)", Is.EqualTo(v.x));
            Assert.That("((-3-9)0)", Is.EqualTo(v.y));
            Assert.That("((-5-7)6)", Is.EqualTo(v.z));
            Assert.That("((-3-9)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "(8-4)", "(07)", "((-2-9)-7)");
            var v = ov.swizzle.zxzy;
            Assert.That("(07)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("(07)", Is.EqualTo(v.z));
            Assert.That("(8-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-33)5)", "((72)9)", null, "(0-8)");
            var v = ov.swizzle.zxzz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-33)5)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((-79)6)", "1", "((21)-5)");
            var v = ov.swizzle.zxzw;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("((21)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-9)-2)", "(4-8)", "((3-8)7)", null);
            var v = ov.swizzle.zxw;
            Assert.That("((3-8)7)", Is.EqualTo(v.x));
            Assert.That("((4-9)-2)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "5", "3", "");
            var v = ov.swizzle.zxwx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((-45)3)", "(-50)", "-8");
            var v = ov.swizzle.zxwy;
            Assert.That("(-50)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("((-45)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-61)", "6", "(-5-8)");
            var v = ov.swizzle.zxwz;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-5-8)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-55)-4)", "((-55)-4)", "((-85)7)", "((-7-2)7)");
            var v = ov.swizzle.zxww;
            Assert.That("((-85)7)", Is.EqualTo(v.x));
            Assert.That("((-55)-4)", Is.EqualTo(v.y));
            Assert.That("((-7-2)7)", Is.EqualTo(v.z));
            Assert.That("((-7-2)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", null, "", "(-6-3)");
            var v = ov.swizzle.zy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-1", "((71)9)", "7", "(-72)");
            var v = ov.swizzle.zyx;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((71)9)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-8", "-8", "-8", "((24)-2)");
            var v = ov.swizzle.zyxx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((04)7)", "(-34)", "6");
            var v = ov.swizzle.zyxy;
            Assert.That("(-34)", Is.EqualTo(v.x));
            Assert.That("((04)7)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((04)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-8)", "0", "(72)", null);
            var v = ov.swizzle.zyxz;
            Assert.That("(72)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("(-4-8)", Is.EqualTo(v.z));
            Assert.That("(72)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(7-9)", "", "");
            var v = ov.swizzle.zyxw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(7-9)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-1)", "((1-8)-9)", "((1-8)-9)", "((1-8)-9)");
            var v = ov.swizzle.zyy;
            Assert.That("((1-8)-9)", Is.EqualTo(v.x));
            Assert.That("((1-8)-9)", Is.EqualTo(v.y));
            Assert.That("((1-8)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(13)", "((88)-5)", "4", null);
            var v = ov.swizzle.zyyx;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((88)-5)", Is.EqualTo(v.y));
            Assert.That("((88)-5)", Is.EqualTo(v.z));
            Assert.That("(13)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", null, "(-5-2)", "4");
            var v = ov.swizzle.zyyy;
            Assert.That("(-5-2)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-7)3)", "-8", null, "-8");
            var v = ov.swizzle.zyyz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "", "(5-2)", "((-52)-9)");
            var v = ov.swizzle.zyyw;
            Assert.That("(5-2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-52)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(86)", "(94)", "");
            var v = ov.swizzle.zyz;
            Assert.That("(94)", Is.EqualTo(v.x));
            Assert.That("(86)", Is.EqualTo(v.y));
            Assert.That("(94)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(1-9)", null, "((-77)-1)", "5");
            var v = ov.swizzle.zyzx;
            Assert.That("((-77)-1)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-77)-1)", Is.EqualTo(v.z));
            Assert.That("(1-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-47)-8)", null, "((-47)-8)", "(3-7)");
            var v = ov.swizzle.zyzy;
            Assert.That("((-47)-8)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-47)-8)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((52)-9)", "((52)-9)", null, "-9");
            var v = ov.swizzle.zyzz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((52)-9)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "", null, "");
            var v = ov.swizzle.zyzw;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((85)-6)", null, "((85)-6)", "(4-7)");
            var v = ov.swizzle.zyw;
            Assert.That("((85)-6)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(4-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-79)6)", "(34)", "(5-1)", "(5-1)");
            var v = ov.swizzle.zywx;
            Assert.That("(5-1)", Is.EqualTo(v.x));
            Assert.That("(34)", Is.EqualTo(v.y));
            Assert.That("(5-1)", Is.EqualTo(v.z));
            Assert.That("((-79)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-93)-8)", "(-25)", "8", "((0-3)-1)");
            var v = ov.swizzle.zywy;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(-25)", Is.EqualTo(v.y));
            Assert.That("((0-3)-1)", Is.EqualTo(v.z));
            Assert.That("(-25)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "(84)", "((60)-8)", "9");
            var v = ov.swizzle.zywz;
            Assert.That("((60)-8)", Is.EqualTo(v.x));
            Assert.That("(84)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("((60)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-60)-5)", "((8-1)8)", "(8-8)", "(6-6)");
            var v = ov.swizzle.zyww;
            Assert.That("(8-8)", Is.EqualTo(v.x));
            Assert.That("((8-1)8)", Is.EqualTo(v.y));
            Assert.That("(6-6)", Is.EqualTo(v.z));
            Assert.That("(6-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-9)-5)", "((4-9)-5)", "((0-8)8)", "(52)");
            var v = ov.swizzle.zz;
            Assert.That("((0-8)8)", Is.EqualTo(v.x));
            Assert.That("((0-8)8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((41)-4)", "(5-7)", "3", "-7");
            var v = ov.swizzle.zzx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((41)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-6-2)5)", "(5-7)", "((-6-2)5)", "((-46)5)");
            var v = ov.swizzle.zzxx;
            Assert.That("((-6-2)5)", Is.EqualTo(v.x));
            Assert.That("((-6-2)5)", Is.EqualTo(v.y));
            Assert.That("((-6-2)5)", Is.EqualTo(v.z));
            Assert.That("((-6-2)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "-4", "((-66)-3)", "-4");
            var v = ov.swizzle.zzxy;
            Assert.That("((-66)-3)", Is.EqualTo(v.x));
            Assert.That("((-66)-3)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((72)3)", null, "", "(23)");
            var v = ov.swizzle.zzxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((72)3)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-1)1)", "((4-1)1)", "((35)8)", "((-9-6)-7)");
            var v = ov.swizzle.zzxw;
            Assert.That("((35)8)", Is.EqualTo(v.x));
            Assert.That("((35)8)", Is.EqualTo(v.y));
            Assert.That("((4-1)1)", Is.EqualTo(v.z));
            Assert.That("((-9-6)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-1)8)", "((21)1)", "-1", "((-7-1)8)");
            var v = ov.swizzle.zzy;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((21)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-4", "((70)2)", "((-4-8)-8)", "(-6-2)");
            var v = ov.swizzle.zzyx;
            Assert.That("((-4-8)-8)", Is.EqualTo(v.x));
            Assert.That("((-4-8)-8)", Is.EqualTo(v.y));
            Assert.That("((70)2)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "((4-5)-2)", null, "((-83)-8)");
            var v = ov.swizzle.zzyy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((4-5)-2)", Is.EqualTo(v.z));
            Assert.That("((4-5)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "(-6-7)", "7", "((64)4)");
            var v = ov.swizzle.zzyz;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(-6-7)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "((-8-1)-8)", "((-64)-1)", "((-64)-1)");
            var v = ov.swizzle.zzyw;
            Assert.That("((-64)-1)", Is.EqualTo(v.x));
            Assert.That("((-64)-1)", Is.EqualTo(v.y));
            Assert.That("((-8-1)-8)", Is.EqualTo(v.z));
            Assert.That("((-64)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "7", "(72)", "(-5-1)");
            var v = ov.swizzle.zzz;
            Assert.That("(72)", Is.EqualTo(v.x));
            Assert.That("(72)", Is.EqualTo(v.y));
            Assert.That("(72)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-14)", "-4", "((-25)-4)", "");
            var v = ov.swizzle.zzzx;
            Assert.That("((-25)-4)", Is.EqualTo(v.x));
            Assert.That("((-25)-4)", Is.EqualTo(v.y));
            Assert.That("((-25)-4)", Is.EqualTo(v.z));
            Assert.That("(-14)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "((-8-1)6)", "(-4-8)", "(-3-6)");
            var v = ov.swizzle.zzzy;
            Assert.That("(-4-8)", Is.EqualTo(v.x));
            Assert.That("(-4-8)", Is.EqualTo(v.y));
            Assert.That("(-4-8)", Is.EqualTo(v.z));
            Assert.That("((-8-1)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "8", "5", "");
            var v = ov.swizzle.zzzz;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "((13)9)", "6", "7");
            var v = ov.swizzle.zzzw;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "(11)", "-2", "5");
            var v = ov.swizzle.zzw;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-2-7)5)", null, "((-2-7)5)", "(09)");
            var v = ov.swizzle.zzwx;
            Assert.That("((-2-7)5)", Is.EqualTo(v.x));
            Assert.That("((-2-7)5)", Is.EqualTo(v.y));
            Assert.That("(09)", Is.EqualTo(v.z));
            Assert.That("((-2-7)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-60)-7)", "(13)", "(47)", null);
            var v = ov.swizzle.zzwy;
            Assert.That("(47)", Is.EqualTo(v.x));
            Assert.That("(47)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(13)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-2)", null, "((15)3)", "((15)3)");
            var v = ov.swizzle.zzwz;
            Assert.That("((15)3)", Is.EqualTo(v.x));
            Assert.That("((15)3)", Is.EqualTo(v.y));
            Assert.That("((15)3)", Is.EqualTo(v.z));
            Assert.That("((15)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", null, "((80)1)");
            var v = ov.swizzle.zzww;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((80)1)", Is.EqualTo(v.z));
            Assert.That("((80)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-63)0)", "(9-5)", "3", "");
            var v = ov.swizzle.zw;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-14)", "(99)", "-2", "((45)6)");
            var v = ov.swizzle.zwx;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((45)6)", Is.EqualTo(v.y));
            Assert.That("(-14)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((3-8)-4)", "", "((3-8)-4)", "(-1-5)");
            var v = ov.swizzle.zwxx;
            Assert.That("((3-8)-4)", Is.EqualTo(v.x));
            Assert.That("(-1-5)", Is.EqualTo(v.y));
            Assert.That("((3-8)-4)", Is.EqualTo(v.z));
            Assert.That("((3-8)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-84)", null, "");
            var v = ov.swizzle.zwxy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(-84)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-4)2)", "(-76)", "7", "6");
            var v = ov.swizzle.zwxz;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("((-9-4)2)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-71)", "((-1-9)3)", "(-71)", "(1-7)");
            var v = ov.swizzle.zwxw;
            Assert.That("(-71)", Is.EqualTo(v.x));
            Assert.That("(1-7)", Is.EqualTo(v.y));
            Assert.That("(-71)", Is.EqualTo(v.z));
            Assert.That("(1-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(19)", "0", null, "-7");
            var v = ov.swizzle.zwy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("7", "", "((0-1)-9)", "(8-3)");
            var v = ov.swizzle.zwyx;
            Assert.That("((0-1)-9)", Is.EqualTo(v.x));
            Assert.That("(8-3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-2)-3)", "-5", null, "");
            var v = ov.swizzle.zwyy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-75)8)", "", "", "((-6-9)-3)");
            var v = ov.swizzle.zwyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-6-9)-3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((9-1)1)", "-9", "((-5-3)1)");
            var v = ov.swizzle.zwyw;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((-5-3)1)", Is.EqualTo(v.y));
            Assert.That("((9-1)1)", Is.EqualTo(v.z));
            Assert.That("((-5-3)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-5)", "-7", "", "-7");
            var v = ov.swizzle.zwz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("8", "-8", "((9-3)4)", "(-21)");
            var v = ov.swizzle.zwzx;
            Assert.That("((9-3)4)", Is.EqualTo(v.x));
            Assert.That("(-21)", Is.EqualTo(v.y));
            Assert.That("((9-3)4)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((35)4)", "1", "(-12)", "-5");
            var v = ov.swizzle.zwzy;
            Assert.That("(-12)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(-12)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-8)", "-5", "((-84)-9)", "(9-9)");
            var v = ov.swizzle.zwzz;
            Assert.That("((-84)-9)", Is.EqualTo(v.x));
            Assert.That("(9-9)", Is.EqualTo(v.y));
            Assert.That("((-84)-9)", Is.EqualTo(v.z));
            Assert.That("((-84)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-6)-2)", "(-1-5)", null, "((60)-5)");
            var v = ov.swizzle.zwzw;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((60)-5)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((60)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-9)-8)", "((5-9)-8)", "", "(96)");
            var v = ov.swizzle.zww;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(96)", Is.EqualTo(v.y));
            Assert.That("(96)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("9", "(34)", "", "7");
            var v = ov.swizzle.zwwx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(14)", "(-64)", "((9-2)-5)", "(-64)");
            var v = ov.swizzle.zwwy;
            Assert.That("((9-2)-5)", Is.EqualTo(v.x));
            Assert.That("(-64)", Is.EqualTo(v.y));
            Assert.That("(-64)", Is.EqualTo(v.z));
            Assert.That("(-64)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-1)-1)", null, "9", "(75)");
            var v = ov.swizzle.zwwz;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(75)", Is.EqualTo(v.y));
            Assert.That("(75)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-4)", null, "((4-9)-2)", "((-29)8)");
            var v = ov.swizzle.zwww;
            Assert.That("((4-9)-2)", Is.EqualTo(v.x));
            Assert.That("((-29)8)", Is.EqualTo(v.y));
            Assert.That("((-29)8)", Is.EqualTo(v.z));
            Assert.That("((-29)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(06)", "0", "", "(06)");
            var v = ov.swizzle.wx;
            Assert.That("(06)", Is.EqualTo(v.x));
            Assert.That("(06)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(6-6)", "((98)-5)", "0", "(54)");
            var v = ov.swizzle.wxx;
            Assert.That("(54)", Is.EqualTo(v.x));
            Assert.That("(6-6)", Is.EqualTo(v.y));
            Assert.That("(6-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((81)4)", "(-2-6)", "-5", "(39)");
            var v = ov.swizzle.wxxx;
            Assert.That("(39)", Is.EqualTo(v.x));
            Assert.That("((81)4)", Is.EqualTo(v.y));
            Assert.That("((81)4)", Is.EqualTo(v.z));
            Assert.That("((81)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((91)2)", "-7", null, "-7");
            var v = ov.swizzle.wxxy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((91)2)", Is.EqualTo(v.y));
            Assert.That("((91)2)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", null, "-9", "(6-6)");
            var v = ov.swizzle.wxxz;
            Assert.That("(6-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "((33)1)", "5", "((33)1)");
            var v = ov.swizzle.wxxw;
            Assert.That("((33)1)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("((33)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-7)", "-2", "9", "(5-3)");
            var v = ov.swizzle.wxy;
            Assert.That("(5-3)", Is.EqualTo(v.x));
            Assert.That("(8-7)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(2-9)", "(1-6)", null, "");
            var v = ov.swizzle.wxyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(2-9)", Is.EqualTo(v.y));
            Assert.That("(1-6)", Is.EqualTo(v.z));
            Assert.That("(2-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-9)2)", "-1", "-1", "-3");
            var v = ov.swizzle.wxyy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("((-9-9)2)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "((-2-2)-8)", "(6-7)", "3");
            var v = ov.swizzle.wxyz;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((-2-2)-8)", Is.EqualTo(v.z));
            Assert.That("(6-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-7)8)", "(88)", "7", "((-21)-1)");
            var v = ov.swizzle.wxyw;
            Assert.That("((-21)-1)", Is.EqualTo(v.x));
            Assert.That("((2-7)8)", Is.EqualTo(v.y));
            Assert.That("(88)", Is.EqualTo(v.z));
            Assert.That("((-21)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "((-18)-2)", "((-52)7)", "0");
            var v = ov.swizzle.wxz;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((-52)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(0-5)", null, "(-7-5)");
            var v = ov.swizzle.wxzx;
            Assert.That("(-7-5)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-6)-7)", "-3", "-3", "-9");
            var v = ov.swizzle.wxzy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((-6-6)-7)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "5", "((-1-9)4)", "");
            var v = ov.swizzle.wxzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-1-9)4)", Is.EqualTo(v.z));
            Assert.That("((-1-9)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-7)-4)", "(-85)", "-8", "");
            var v = ov.swizzle.wxzw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((5-7)-4)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((21)-4)", "1", "((41)8)", "((21)-4)");
            var v = ov.swizzle.wxw;
            Assert.That("((21)-4)", Is.EqualTo(v.x));
            Assert.That("((21)-4)", Is.EqualTo(v.y));
            Assert.That("((21)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-9", "", "((-1-9)-5)", "4");
            var v = ov.swizzle.wxwx;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(18)", "(-7-3)", "((-98)-4)", "-5");
            var v = ov.swizzle.wxwy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("(18)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("(-7-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-48)", "-3", "", null);
            var v = ov.swizzle.wxwz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-48)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-2)5)", "7", "-2", "((7-2)-9)");
            var v = ov.swizzle.wxww;
            Assert.That("((7-2)-9)", Is.EqualTo(v.x));
            Assert.That("((-5-2)5)", Is.EqualTo(v.y));
            Assert.That("((7-2)-9)", Is.EqualTo(v.z));
            Assert.That("((7-2)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-5", "((-54)7)", "((-6-2)6)");
            var v = ov.swizzle.wy;
            Assert.That("((-6-2)6)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("", "7", "(-21)", "((35)-2)");
            var v = ov.swizzle.wyx;
            Assert.That("((35)-2)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-9-9)-2)", "", "", null);
            var v = ov.swizzle.wyxx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-9-9)-2)", Is.EqualTo(v.z));
            Assert.That("((-9-9)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(62)", null, "-9", "(-66)");
            var v = ov.swizzle.wyxy;
            Assert.That("(-66)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(62)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-49)", "(68)", "(-9-1)", "(-49)");
            var v = ov.swizzle.wyxz;
            Assert.That("(-49)", Is.EqualTo(v.x));
            Assert.That("(68)", Is.EqualTo(v.y));
            Assert.That("(-49)", Is.EqualTo(v.z));
            Assert.That("(-9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-74)", "(4-1)", "", "-6");
            var v = ov.swizzle.wyxw;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("(4-1)", Is.EqualTo(v.y));
            Assert.That("(-74)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-7)3)", "((-8-8)2)", "(25)", "-6");
            var v = ov.swizzle.wyy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((-8-8)2)", Is.EqualTo(v.y));
            Assert.That("((-8-8)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-64)", "(-64)", "(-40)", "(-40)");
            var v = ov.swizzle.wyyx;
            Assert.That("(-40)", Is.EqualTo(v.x));
            Assert.That("(-64)", Is.EqualTo(v.y));
            Assert.That("(-64)", Is.EqualTo(v.z));
            Assert.That("(-64)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(88)", "((4-7)3)", "((9-9)-2)", "(88)");
            var v = ov.swizzle.wyyy;
            Assert.That("(88)", Is.EqualTo(v.x));
            Assert.That("((4-7)3)", Is.EqualTo(v.y));
            Assert.That("((4-7)3)", Is.EqualTo(v.z));
            Assert.That("((4-7)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-70)", "(-70)", "((-4-7)3)");
            var v = ov.swizzle.wyyz;
            Assert.That("((-4-7)3)", Is.EqualTo(v.x));
            Assert.That("(-70)", Is.EqualTo(v.y));
            Assert.That("(-70)", Is.EqualTo(v.z));
            Assert.That("(-70)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((2-8)5)", "((5-5)5)", "(-6-6)");
            var v = ov.swizzle.wyyw;
            Assert.That("(-6-6)", Is.EqualTo(v.x));
            Assert.That("((2-8)5)", Is.EqualTo(v.y));
            Assert.That("((2-8)5)", Is.EqualTo(v.z));
            Assert.That("(-6-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-2)6)", "((-6-5)6)", "((-6-5)6)", "4");
            var v = ov.swizzle.wyz;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((-6-5)6)", Is.EqualTo(v.y));
            Assert.That("((-6-5)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("9", "((1-9)-7)", "(-70)", "(7-9)");
            var v = ov.swizzle.wyzx;
            Assert.That("(7-9)", Is.EqualTo(v.x));
            Assert.That("((1-9)-7)", Is.EqualTo(v.y));
            Assert.That("(-70)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-9)", "((17)6)", "-8", "(-73)");
            var v = ov.swizzle.wyzy;
            Assert.That("(-73)", Is.EqualTo(v.x));
            Assert.That("((17)6)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("((17)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "(-59)", "((9-7)-9)", "3");
            var v = ov.swizzle.wyzz;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(-59)", Is.EqualTo(v.y));
            Assert.That("((9-7)-9)", Is.EqualTo(v.z));
            Assert.That("((9-7)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "-2", "-2", "((2-2)0)");
            var v = ov.swizzle.wyzw;
            Assert.That("((2-2)0)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("((2-2)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-52)3)", "((3-8)-1)", "((64)-7)", "(57)");
            var v = ov.swizzle.wyw;
            Assert.That("(57)", Is.EqualTo(v.x));
            Assert.That("((3-8)-1)", Is.EqualTo(v.y));
            Assert.That("(57)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(52)", "-1", "(4-5)", "(4-5)");
            var v = ov.swizzle.wywx;
            Assert.That("(4-5)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(4-5)", Is.EqualTo(v.z));
            Assert.That("(52)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-20)-7)", "((-31)5)", "(23)", "4");
            var v = ov.swizzle.wywy;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((-31)5)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("((-31)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(05)", "5", "((-90)-7)", "((38)-3)");
            var v = ov.swizzle.wywz;
            Assert.That("((38)-3)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("((38)-3)", Is.EqualTo(v.z));
            Assert.That("((-90)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "2", "(-69)", "(48)");
            var v = ov.swizzle.wyww;
            Assert.That("(48)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(48)", Is.EqualTo(v.z));
            Assert.That("(48)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(78)", "((-3-7)-3)", "((8-4)-2)");
            var v = ov.swizzle.wz;
            Assert.That("((8-4)-2)", Is.EqualTo(v.x));
            Assert.That("((-3-7)-3)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>(null, "((0-5)8)", "(-39)", "(11)");
            var v = ov.swizzle.wzx;
            Assert.That("(11)", Is.EqualTo(v.x));
            Assert.That("(-39)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((82)9)", "2", "", "((82)9)");
            var v = ov.swizzle.wzxx;
            Assert.That("((82)9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((82)9)", Is.EqualTo(v.z));
            Assert.That("((82)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(3-9)", null, "((-4-6)-2)");
            var v = ov.swizzle.wzxy;
            Assert.That("((-4-6)-2)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(3-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "((9-5)3)", "((73)8)", "(92)");
            var v = ov.swizzle.wzxz;
            Assert.That("(92)", Is.EqualTo(v.x));
            Assert.That("((73)8)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((73)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((57)4)", "(1-4)", "1", null);
            var v = ov.swizzle.wzxw;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("((57)4)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-24)7)", "((-24)7)", "((-7-2)3)");
            var v = ov.swizzle.wzy;
            Assert.That("((-7-2)3)", Is.EqualTo(v.x));
            Assert.That("((-24)7)", Is.EqualTo(v.y));
            Assert.That("((-24)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((0-4)8)", "(10)", "((9-2)-7)", null);
            var v = ov.swizzle.wzyx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((9-2)-7)", Is.EqualTo(v.y));
            Assert.That("(10)", Is.EqualTo(v.z));
            Assert.That("((0-4)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "-4", "(49)", "");
            var v = ov.swizzle.wzyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(49)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-81)5)", "8", "(45)", "((-81)5)");
            var v = ov.swizzle.wzyz;
            Assert.That("((-81)5)", Is.EqualTo(v.x));
            Assert.That("(45)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("(45)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((48)-9)", "-4", "(1-5)", "(2-7)");
            var v = ov.swizzle.wzyw;
            Assert.That("(2-7)", Is.EqualTo(v.x));
            Assert.That("(1-5)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(2-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(11)", "", "(-9-7)", "6");
            var v = ov.swizzle.wzz;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("(-9-7)", Is.EqualTo(v.y));
            Assert.That("(-9-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(96)", "-6", "(-73)", "((6-5)7)");
            var v = ov.swizzle.wzzx;
            Assert.That("((6-5)7)", Is.EqualTo(v.x));
            Assert.That("(-73)", Is.EqualTo(v.y));
            Assert.That("(-73)", Is.EqualTo(v.z));
            Assert.That("(96)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-9)2)", "((-1-9)7)", "-3", "7");
            var v = ov.swizzle.wzzy;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("((-1-9)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-16)-3)", "1", "((-48)-8)", "(-34)");
            var v = ov.swizzle.wzzz;
            Assert.That("(-34)", Is.EqualTo(v.x));
            Assert.That("((-48)-8)", Is.EqualTo(v.y));
            Assert.That("((-48)-8)", Is.EqualTo(v.z));
            Assert.That("((-48)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "((-68)-8)", "(-91)", "((-68)-8)");
            var v = ov.swizzle.wzzw;
            Assert.That("((-68)-8)", Is.EqualTo(v.x));
            Assert.That("(-91)", Is.EqualTo(v.y));
            Assert.That("(-91)", Is.EqualTo(v.z));
            Assert.That("((-68)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-1)-1)", "(-1-9)", "-8", "((-90)3)");
            var v = ov.swizzle.wzw;
            Assert.That("((-90)3)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("((-90)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "(-89)", "-7", "((-56)0)");
            var v = ov.swizzle.wzwx;
            Assert.That("((-56)0)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((-56)0)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-6)-2)", "(74)", "((-5-6)-2)", "(74)");
            var v = ov.swizzle.wzwy;
            Assert.That("(74)", Is.EqualTo(v.x));
            Assert.That("((-5-6)-2)", Is.EqualTo(v.y));
            Assert.That("(74)", Is.EqualTo(v.z));
            Assert.That("(74)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(8-7)", "-6", "((-3-6)-4)");
            var v = ov.swizzle.wzwz;
            Assert.That("((-3-6)-4)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("((-3-6)-4)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "-7", "(72)", "(72)");
            var v = ov.swizzle.wzww;
            Assert.That("(72)", Is.EqualTo(v.x));
            Assert.That("(72)", Is.EqualTo(v.y));
            Assert.That("(72)", Is.EqualTo(v.z));
            Assert.That("(72)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-4)", null, "", "(96)");
            var v = ov.swizzle.ww;
            Assert.That("(96)", Is.EqualTo(v.x));
            Assert.That("(96)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(0-2)", "(0-2)", "", "6");
            var v = ov.swizzle.wwx;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(0-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "-5", "-6", "(-14)");
            var v = ov.swizzle.wwxx;
            Assert.That("(-14)", Is.EqualTo(v.x));
            Assert.That("(-14)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-61)-1)", "", null, "-7");
            var v = ov.swizzle.wwxy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((-61)-1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((80)9)", "-3", "", "(62)");
            var v = ov.swizzle.wwxz;
            Assert.That("(62)", Is.EqualTo(v.x));
            Assert.That("(62)", Is.EqualTo(v.y));
            Assert.That("((80)9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "((59)-1)", "-7", "");
            var v = ov.swizzle.wwxw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(95)", "4", "-7", "((78)9)");
            var v = ov.swizzle.wwy;
            Assert.That("((78)9)", Is.EqualTo(v.x));
            Assert.That("((78)9)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "(1-9)", "2", null);
            var v = ov.swizzle.wwyx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(1-9)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((5-3)5)", "", "((45)2)");
            var v = ov.swizzle.wwyy;
            Assert.That("((45)2)", Is.EqualTo(v.x));
            Assert.That("((45)2)", Is.EqualTo(v.y));
            Assert.That("((5-3)5)", Is.EqualTo(v.z));
            Assert.That("((5-3)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((05)-5)", "(4-7)", "", null);
            var v = ov.swizzle.wwyz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(4-7)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-7)9)", "((-2-7)9)", "(2-2)", "4");
            var v = ov.swizzle.wwyw;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((-2-7)9)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-88)", "((-1-1)-6)", "");
            var v = ov.swizzle.wwz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-1-1)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-1", "((-87)1)", "(1-7)", "2");
            var v = ov.swizzle.wwzx;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(1-7)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-3", "-3", "((-9-1)4)");
            var v = ov.swizzle.wwzy;
            Assert.That("((-9-1)4)", Is.EqualTo(v.x));
            Assert.That("((-9-1)4)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "(-67)", "(-4-4)", "(-67)");
            var v = ov.swizzle.wwzz;
            Assert.That("(-67)", Is.EqualTo(v.x));
            Assert.That("(-67)", Is.EqualTo(v.y));
            Assert.That("(-4-4)", Is.EqualTo(v.z));
            Assert.That("(-4-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((79)7)", "(2-7)", "(0-2)", "2");
            var v = ov.swizzle.wwzw;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(0-2)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-6)", "((32)1)", "", "6");
            var v = ov.swizzle.www;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((5-9)-9)", "(1-7)", null, "((-8-4)1)");
            var v = ov.swizzle.wwwx;
            Assert.That("((-8-4)1)", Is.EqualTo(v.x));
            Assert.That("((-8-4)1)", Is.EqualTo(v.y));
            Assert.That("((-8-4)1)", Is.EqualTo(v.z));
            Assert.That("((5-9)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((6-9)7)", null, "-5");
            var v = ov.swizzle.wwwy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("((6-9)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-9", "((-1-4)-9)", "(85)");
            var v = ov.swizzle.wwwz;
            Assert.That("(85)", Is.EqualTo(v.x));
            Assert.That("(85)", Is.EqualTo(v.y));
            Assert.That("(85)", Is.EqualTo(v.z));
            Assert.That("((-1-4)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-9)-5)", "-2", null, "(25)");
            var v = ov.swizzle.wwww;
            Assert.That("(25)", Is.EqualTo(v.x));
            Assert.That("(25)", Is.EqualTo(v.y));
            Assert.That("(25)", Is.EqualTo(v.z));
            Assert.That("(25)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec4<string>("6", "(-3-1)", "((4-8)5)", "((-8-5)5)");
            var v = ov.swizzle.rr;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("", "((15)-9)", "((55)1)", "((55)1)");
            var v = ov.swizzle.rrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-4-9)-4)", "(1-3)", "-7", "(1-3)");
            var v = ov.swizzle.rrrr;
            Assert.That("((-4-9)-4)", Is.EqualTo(v.x));
            Assert.That("((-4-9)-4)", Is.EqualTo(v.y));
            Assert.That("((-4-9)-4)", Is.EqualTo(v.z));
            Assert.That("((-4-9)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((58)8)", "(23)", "((58)8)", "((-8-3)3)");
            var v = ov.swizzle.rrrg;
            Assert.That("((58)8)", Is.EqualTo(v.x));
            Assert.That("((58)8)", Is.EqualTo(v.y));
            Assert.That("((58)8)", Is.EqualTo(v.z));
            Assert.That("(23)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-4)", "2", "(-6-4)", "");
            var v = ov.swizzle.rrrb;
            Assert.That("(-6-4)", Is.EqualTo(v.x));
            Assert.That("(-6-4)", Is.EqualTo(v.y));
            Assert.That("(-6-4)", Is.EqualTo(v.z));
            Assert.That("(-6-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "2", "(24)", "");
            var v = ov.swizzle.rrra;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((31)9)", "((31)9)", "((31)9)", "(-95)");
            var v = ov.swizzle.rrg;
            Assert.That("((31)9)", Is.EqualTo(v.x));
            Assert.That("((31)9)", Is.EqualTo(v.y));
            Assert.That("((31)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(3-1)", "((1-3)9)", "(3-1)", "-4");
            var v = ov.swizzle.rrgr;
            Assert.That("(3-1)", Is.EqualTo(v.x));
            Assert.That("(3-1)", Is.EqualTo(v.y));
            Assert.That("((1-3)9)", Is.EqualTo(v.z));
            Assert.That("(3-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-5)", "", "(-37)", "-6");
            var v = ov.swizzle.rrgg;
            Assert.That("(2-5)", Is.EqualTo(v.x));
            Assert.That("(2-5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((84)5)", "(14)", "", "3");
            var v = ov.swizzle.rrgb;
            Assert.That("((84)5)", Is.EqualTo(v.x));
            Assert.That("((84)5)", Is.EqualTo(v.y));
            Assert.That("(14)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-38)9)", "((-52)-3)", "((-14)6)", "(54)");
            var v = ov.swizzle.rrga;
            Assert.That("((-38)9)", Is.EqualTo(v.x));
            Assert.That("((-38)9)", Is.EqualTo(v.y));
            Assert.That("((-52)-3)", Is.EqualTo(v.z));
            Assert.That("(54)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((83)1)", "((-7-5)-4)", "5", "((-7-5)-4)");
            var v = ov.swizzle.rrb;
            Assert.That("((83)1)", Is.EqualTo(v.x));
            Assert.That("((83)1)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((7-4)-1)", "", "-7", "8");
            var v = ov.swizzle.rrbr;
            Assert.That("((7-4)-1)", Is.EqualTo(v.x));
            Assert.That("((7-4)-1)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((7-4)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(82)", "((49)0)", "((49)0)");
            var v = ov.swizzle.rrbg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((49)0)", Is.EqualTo(v.z));
            Assert.That("(82)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-20)", "", "-5", "((-21)8)");
            var v = ov.swizzle.rrbb;
            Assert.That("(-20)", Is.EqualTo(v.x));
            Assert.That("(-20)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-92)", "((0-9)7)", "", "(-30)");
            var v = ov.swizzle.rrba;
            Assert.That("(-92)", Is.EqualTo(v.x));
            Assert.That("(-92)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-30)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-79)", null, "6", "((-29)-6)");
            var v = ov.swizzle.rra;
            Assert.That("(-79)", Is.EqualTo(v.x));
            Assert.That("(-79)", Is.EqualTo(v.y));
            Assert.That("((-29)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(39)", "(39)", "(39)", "4");
            var v = ov.swizzle.rrar;
            Assert.That("(39)", Is.EqualTo(v.x));
            Assert.That("(39)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(39)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", null, "-5");
            var v = ov.swizzle.rrag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(79)", "(79)", "((-81)0)", "((-81)0)");
            var v = ov.swizzle.rrab;
            Assert.That("(79)", Is.EqualTo(v.x));
            Assert.That("(79)", Is.EqualTo(v.y));
            Assert.That("((-81)0)", Is.EqualTo(v.z));
            Assert.That("((-81)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-1", "(68)", "2");
            var v = ov.swizzle.rraa;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "", "-1", "(-39)");
            var v = ov.swizzle.rg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("1", "1", "((-6-3)4)", "((91)1)");
            var v = ov.swizzle.rgr;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((80)0)", "-6", "((-4-8)9)", null);
            var v = ov.swizzle.rgrr;
            Assert.That("((80)0)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("((80)0)", Is.EqualTo(v.z));
            Assert.That("((80)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-3)2)", "6", "(07)", "((-4-3)2)");
            var v = ov.swizzle.rgrg;
            Assert.That("((-4-3)2)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("((-4-3)2)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((79)0)", null, "(1-6)");
            var v = ov.swizzle.rgrb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((79)0)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((29)-3)", "", "((29)-3)", "-2");
            var v = ov.swizzle.rgra;
            Assert.That("((29)-3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((29)-3)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-2)-4)", "(-3-3)", null, "((-2-2)-4)");
            var v = ov.swizzle.rgg;
            Assert.That("((-2-2)-4)", Is.EqualTo(v.x));
            Assert.That("(-3-3)", Is.EqualTo(v.y));
            Assert.That("(-3-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-8-3)-7)", "((-46)6)", "9", "(-79)");
            var v = ov.swizzle.rggr;
            Assert.That("((-8-3)-7)", Is.EqualTo(v.x));
            Assert.That("((-46)6)", Is.EqualTo(v.y));
            Assert.That("((-46)6)", Is.EqualTo(v.z));
            Assert.That("((-8-3)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "0", "((-77)4)", "((08)-4)");
            var v = ov.swizzle.rggg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "7", "((-23)-1)");
            var v = ov.swizzle.rggb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((39)6)", "(8-9)", null, "-5");
            var v = ov.swizzle.rgga;
            Assert.That("((39)6)", Is.EqualTo(v.x));
            Assert.That("(8-9)", Is.EqualTo(v.y));
            Assert.That("(8-9)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-91)", "7", "((-86)-2)", "((74)0)");
            var v = ov.swizzle.rgb;
            Assert.That("(-91)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("((-86)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("0", "(56)", "", "0");
            var v = ov.swizzle.rgbr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(56)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "(60)", "7", "3");
            var v = ov.swizzle.rgbg;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(60)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(60)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-9)", "1", "((8-1)-1)", "-6");
            var v = ov.swizzle.rgbb;
            Assert.That("(4-9)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("((8-1)-1)", Is.EqualTo(v.z));
            Assert.That("((8-1)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-67)-3)", null, "((-22)-4)", "(81)");
            var v = ov.swizzle.rgba;
            Assert.That("((-67)-3)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-22)-4)", Is.EqualTo(v.z));
            Assert.That("(81)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-87)5)", "", null, null);
            var v = ov.swizzle.rga;
            Assert.That("((-87)5)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((6-6)-7)", "0", null, "((-5-1)-4)");
            var v = ov.swizzle.rgar;
            Assert.That("((6-6)-7)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((-5-1)-4)", Is.EqualTo(v.z));
            Assert.That("((6-6)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(70)", "3", "((-2-3)7)", "3");
            var v = ov.swizzle.rgag;
            Assert.That("(70)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-9)0)", "((-1-9)0)", "(-43)", "(-89)");
            var v = ov.swizzle.rgab;
            Assert.That("((-1-9)0)", Is.EqualTo(v.x));
            Assert.That("((-1-9)0)", Is.EqualTo(v.y));
            Assert.That("(-89)", Is.EqualTo(v.z));
            Assert.That("(-43)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-48)-4)", null, "((58)-5)", "((58)-5)");
            var v = ov.swizzle.rgaa;
            Assert.That("((-48)-4)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((58)-5)", Is.EqualTo(v.z));
            Assert.That("((58)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "-5", "((48)2)", "((48)2)");
            var v = ov.swizzle.rb;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((48)2)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(2-9)", "((4-8)-8)", "", "-1");
            var v = ov.swizzle.rbr;
            Assert.That("(2-9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(2-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((6-4)8)", "(-11)", "((6-4)8)", "");
            var v = ov.swizzle.rbrr;
            Assert.That("((6-4)8)", Is.EqualTo(v.x));
            Assert.That("((6-4)8)", Is.EqualTo(v.y));
            Assert.That("((6-4)8)", Is.EqualTo(v.z));
            Assert.That("((6-4)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", null, "((-99)6)", "((6-6)8)");
            var v = ov.swizzle.rbrg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((-99)6)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((2-2)-1)", "", null);
            var v = ov.swizzle.rbrb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-21)0)", "((7-1)4)", "-1", "-1");
            var v = ov.swizzle.rbra;
            Assert.That("((-21)0)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((-21)0)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "(-3-8)", "((-44)-6)", "(-5-4)");
            var v = ov.swizzle.rbg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((-44)-6)", Is.EqualTo(v.y));
            Assert.That("(-3-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-7-8)", "((8-2)9)", null, "3");
            var v = ov.swizzle.rbgr;
            Assert.That("(-7-8)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((8-2)9)", Is.EqualTo(v.z));
            Assert.That("(-7-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-29)-6)", null, "", null);
            var v = ov.swizzle.rbgg;
            Assert.That("((-29)-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-76)6)", "(51)", "5", "(51)");
            var v = ov.swizzle.rbgb;
            Assert.That("((-76)6)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(51)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-2)-2)", "((14)-6)", "(-59)", "-1");
            var v = ov.swizzle.rbga;
            Assert.That("((0-2)-2)", Is.EqualTo(v.x));
            Assert.That("(-59)", Is.EqualTo(v.y));
            Assert.That("((14)-6)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-73)-2)", "((51)-5)", "-1", "-2");
            var v = ov.swizzle.rbb;
            Assert.That("((-73)-2)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("4", "4", "((-64)-5)", "-5");
            var v = ov.swizzle.rbbr;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((-64)-5)", Is.EqualTo(v.y));
            Assert.That("((-64)-5)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "(-95)", "7", "0");
            var v = ov.swizzle.rbbg;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(-95)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((5-7)9)", "((5-7)9)", "(-2-3)");
            var v = ov.swizzle.rbbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((5-7)9)", Is.EqualTo(v.y));
            Assert.That("((5-7)9)", Is.EqualTo(v.z));
            Assert.That("((5-7)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "", "-7", "((1-9)-9)");
            var v = ov.swizzle.rbba;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((1-9)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-12)9)", "9", "9", "9");
            var v = ov.swizzle.rba;
            Assert.That("((-12)9)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-8", "(-71)", "(-71)", "((85)4)");
            var v = ov.swizzle.rbar;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(-71)", Is.EqualTo(v.y));
            Assert.That("((85)4)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((52)-4)", "((0-3)-4)", "(-58)");
            var v = ov.swizzle.rbag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((0-3)-4)", Is.EqualTo(v.y));
            Assert.That("(-58)", Is.EqualTo(v.z));
            Assert.That("((52)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-1)", "", null, "((6-9)-2)");
            var v = ov.swizzle.rbab;
            Assert.That("(-1-1)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((6-9)-2)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, null, "(0-4)", "5");
            var v = ov.swizzle.rbaa;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(0-4)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-7)", "(-1-7)", "((9-1)-4)", null);
            var v = ov.swizzle.ra;
            Assert.That("(-1-7)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((47)-1)", "9", "-4", "(-54)");
            var v = ov.swizzle.rar;
            Assert.That("((47)-1)", Is.EqualTo(v.x));
            Assert.That("(-54)", Is.EqualTo(v.y));
            Assert.That("((47)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-7", "(5-3)", "((9-1)2)", "0");
            var v = ov.swizzle.rarr;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-5", "(4-6)", "-7");
            var v = ov.swizzle.rarg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-2)-8)", "-2", "(-6-8)", "(6-9)");
            var v = ov.swizzle.rarb;
            Assert.That("((-1-2)-8)", Is.EqualTo(v.x));
            Assert.That("(6-9)", Is.EqualTo(v.y));
            Assert.That("((-1-2)-8)", Is.EqualTo(v.z));
            Assert.That("(-6-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-2)", "(-6-2)", "((11)-9)", "(-9-7)");
            var v = ov.swizzle.rara;
            Assert.That("(-6-2)", Is.EqualTo(v.x));
            Assert.That("(-9-7)", Is.EqualTo(v.y));
            Assert.That("(-6-2)", Is.EqualTo(v.z));
            Assert.That("(-9-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-9)", "", "((3-1)0)", "(-8-3)");
            var v = ov.swizzle.rag;
            Assert.That("(-7-9)", Is.EqualTo(v.x));
            Assert.That("(-8-3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-5", "((57)5)", "-5", "-5");
            var v = ov.swizzle.ragr;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("((57)5)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((88)-7)", "(-76)", null, "8");
            var v = ov.swizzle.ragg;
            Assert.That("((88)-7)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-76)", Is.EqualTo(v.z));
            Assert.That("(-76)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-16)", "((-3-5)4)", "(-9-5)");
            var v = ov.swizzle.ragb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-9-5)", Is.EqualTo(v.y));
            Assert.That("(-16)", Is.EqualTo(v.z));
            Assert.That("((-3-5)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-62)3)", "(1-7)", "(62)", "((-2-9)-7)");
            var v = ov.swizzle.raga;
            Assert.That("((-62)3)", Is.EqualTo(v.x));
            Assert.That("((-2-9)-7)", Is.EqualTo(v.y));
            Assert.That("(1-7)", Is.EqualTo(v.z));
            Assert.That("((-2-9)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-7)", "(5-5)", "((7-4)9)", "((7-4)9)");
            var v = ov.swizzle.rab;
            Assert.That("(0-7)", Is.EqualTo(v.x));
            Assert.That("((7-4)9)", Is.EqualTo(v.y));
            Assert.That("((7-4)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(5-2)", "4", "((75)1)", "(-76)");
            var v = ov.swizzle.rabr;
            Assert.That("(5-2)", Is.EqualTo(v.x));
            Assert.That("(-76)", Is.EqualTo(v.y));
            Assert.That("((75)1)", Is.EqualTo(v.z));
            Assert.That("(5-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-8)", "((53)2)", "(0-7)", null);
            var v = ov.swizzle.rabg;
            Assert.That("(-4-8)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(0-7)", Is.EqualTo(v.z));
            Assert.That("((53)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((90)4)", null, "((8-1)-3)", "((90)4)");
            var v = ov.swizzle.rabb;
            Assert.That("((90)4)", Is.EqualTo(v.x));
            Assert.That("((90)4)", Is.EqualTo(v.y));
            Assert.That("((8-1)-3)", Is.EqualTo(v.z));
            Assert.That("((8-1)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((84)8)", "((-38)4)", null, "");
            var v = ov.swizzle.raba;
            Assert.That("((84)8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "7", "7", "(-21)");
            var v = ov.swizzle.raa;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-21)", Is.EqualTo(v.y));
            Assert.That("(-21)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-47)", "", "((-2-5)7)", "((41)-9)");
            var v = ov.swizzle.raar;
            Assert.That("(-47)", Is.EqualTo(v.x));
            Assert.That("((41)-9)", Is.EqualTo(v.y));
            Assert.That("((41)-9)", Is.EqualTo(v.z));
            Assert.That("(-47)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((-12)-6)", "(-59)", "-5");
            var v = ov.swizzle.raag;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("((-12)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-5)-4)", "-3", "(2-4)", null);
            var v = ov.swizzle.raab;
            Assert.That("((2-5)-4)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(2-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-34)", "3", "", "(-5-7)");
            var v = ov.swizzle.raaa;
            Assert.That("(-34)", Is.EqualTo(v.x));
            Assert.That("(-5-7)", Is.EqualTo(v.y));
            Assert.That("(-5-7)", Is.EqualTo(v.z));
            Assert.That("(-5-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(0-8)", "(0-8)", "-2");
            var v = ov.swizzle.gr;
            Assert.That("(0-8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-9-7)", "-9", null, "((-7-8)-2)");
            var v = ov.swizzle.grr;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("(-9-7)", Is.EqualTo(v.y));
            Assert.That("(-9-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(5-2)", null, "-8", "2");
            var v = ov.swizzle.grrr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(5-2)", Is.EqualTo(v.y));
            Assert.That("(5-2)", Is.EqualTo(v.z));
            Assert.That("(5-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-9)", "(-8-2)", "-5", "((62)-4)");
            var v = ov.swizzle.grrg;
            Assert.That("(-8-2)", Is.EqualTo(v.x));
            Assert.That("(-6-9)", Is.EqualTo(v.y));
            Assert.That("(-6-9)", Is.EqualTo(v.z));
            Assert.That("(-8-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-4)-1)", "((-99)2)", "(-9-1)", "((-99)2)");
            var v = ov.swizzle.grrb;
            Assert.That("((-99)2)", Is.EqualTo(v.x));
            Assert.That("((-1-4)-1)", Is.EqualTo(v.y));
            Assert.That("((-1-4)-1)", Is.EqualTo(v.z));
            Assert.That("(-9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(74)", "(6-5)", "4", "");
            var v = ov.swizzle.grra;
            Assert.That("(6-5)", Is.EqualTo(v.x));
            Assert.That("(74)", Is.EqualTo(v.y));
            Assert.That("(74)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "4", "4", "(16)");
            var v = ov.swizzle.grg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-35)", "((-11)7)", "((-11)7)", "(68)");
            var v = ov.swizzle.grgr;
            Assert.That("((-11)7)", Is.EqualTo(v.x));
            Assert.That("(-35)", Is.EqualTo(v.y));
            Assert.That("((-11)7)", Is.EqualTo(v.z));
            Assert.That("(-35)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(50)", "((-3-8)7)", "-9", null);
            var v = ov.swizzle.grgg;
            Assert.That("((-3-8)7)", Is.EqualTo(v.x));
            Assert.That("(50)", Is.EqualTo(v.y));
            Assert.That("((-3-8)7)", Is.EqualTo(v.z));
            Assert.That("((-3-8)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "(-9-8)", "1", "(4-8)");
            var v = ov.swizzle.grgb;
            Assert.That("(-9-8)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(-9-8)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-5)", "(-6-5)", "(-61)", "2");
            var v = ov.swizzle.grga;
            Assert.That("(-6-5)", Is.EqualTo(v.x));
            Assert.That("(-6-5)", Is.EqualTo(v.y));
            Assert.That("(-6-5)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(87)", "", "((-2-7)-4)", "1");
            var v = ov.swizzle.grb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(87)", Is.EqualTo(v.y));
            Assert.That("((-2-7)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-7", "(-5-5)", null, null);
            var v = ov.swizzle.grbr;
            Assert.That("(-5-5)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-20)-2)", "((-20)-2)", "(-34)", "9");
            var v = ov.swizzle.grbg;
            Assert.That("((-20)-2)", Is.EqualTo(v.x));
            Assert.That("((-20)-2)", Is.EqualTo(v.y));
            Assert.That("(-34)", Is.EqualTo(v.z));
            Assert.That("((-20)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "", "(50)", "");
            var v = ov.swizzle.grbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(50)", Is.EqualTo(v.z));
            Assert.That("(50)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "(96)", "", "");
            var v = ov.swizzle.grba;
            Assert.That("(96)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "", "((-9-4)3)", "((-3-1)-7)");
            var v = ov.swizzle.gra;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-3-1)-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(2-7)", "(2-7)", "(2-7)", "(3-3)");
            var v = ov.swizzle.grar;
            Assert.That("(2-7)", Is.EqualTo(v.x));
            Assert.That("(2-7)", Is.EqualTo(v.y));
            Assert.That("(3-3)", Is.EqualTo(v.z));
            Assert.That("(2-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "", null, "(-9-6)");
            var v = ov.swizzle.grag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-9-6)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-9)8)", "((07)5)", "-7", "((40)6)");
            var v = ov.swizzle.grab;
            Assert.That("((07)5)", Is.EqualTo(v.x));
            Assert.That("((0-9)8)", Is.EqualTo(v.y));
            Assert.That("((40)6)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "", "-1", "-4");
            var v = ov.swizzle.graa;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "((77)-8)", "((-77)3)", "-9");
            var v = ov.swizzle.gg;
            Assert.That("((77)-8)", Is.EqualTo(v.x));
            Assert.That("((77)-8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>(null, "", "((-16)4)", "");
            var v = ov.swizzle.ggr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-16)-6)", "8", "((-7-6)-8)", "(-66)");
            var v = ov.swizzle.ggrr;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("((-16)-6)", Is.EqualTo(v.z));
            Assert.That("((-16)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-6)-2)", "(2-3)", "((4-6)-2)", "2");
            var v = ov.swizzle.ggrg;
            Assert.That("(2-3)", Is.EqualTo(v.x));
            Assert.That("(2-3)", Is.EqualTo(v.y));
            Assert.That("((4-6)-2)", Is.EqualTo(v.z));
            Assert.That("(2-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "(3-7)", "(3-3)", null);
            var v = ov.swizzle.ggrb;
            Assert.That("(3-7)", Is.EqualTo(v.x));
            Assert.That("(3-7)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("(3-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(11)", "-3", "");
            var v = ov.swizzle.ggra;
            Assert.That("(11)", Is.EqualTo(v.x));
            Assert.That("(11)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((07)-8)", "(-12)", "((56)7)");
            var v = ov.swizzle.ggg;
            Assert.That("((07)-8)", Is.EqualTo(v.x));
            Assert.That("((07)-8)", Is.EqualTo(v.y));
            Assert.That("((07)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(-54)", "2", "(-59)");
            var v = ov.swizzle.gggr;
            Assert.That("(-54)", Is.EqualTo(v.x));
            Assert.That("(-54)", Is.EqualTo(v.y));
            Assert.That("(-54)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-1)2)", "(55)", null, null);
            var v = ov.swizzle.gggg;
            Assert.That("(55)", Is.EqualTo(v.x));
            Assert.That("(55)", Is.EqualTo(v.y));
            Assert.That("(55)", Is.EqualTo(v.z));
            Assert.That("(55)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "0", "(3-7)", null);
            var v = ov.swizzle.gggb;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("(3-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "6", null, "-6");
            var v = ov.swizzle.ggga;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(22)", "", "(-5-5)", null);
            var v = ov.swizzle.ggb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-5-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-7-3)7)", "3", "(-40)", "((-7-3)7)");
            var v = ov.swizzle.ggbr;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(-40)", Is.EqualTo(v.z));
            Assert.That("((-7-3)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "(-2-7)", "(87)", "(-2-7)");
            var v = ov.swizzle.ggbg;
            Assert.That("(-2-7)", Is.EqualTo(v.x));
            Assert.That("(-2-7)", Is.EqualTo(v.y));
            Assert.That("(87)", Is.EqualTo(v.z));
            Assert.That("(-2-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((02)9)", "((02)9)", "8", "");
            var v = ov.swizzle.ggbb;
            Assert.That("((02)9)", Is.EqualTo(v.x));
            Assert.That("((02)9)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "(29)", "", "-9");
            var v = ov.swizzle.ggba;
            Assert.That("(29)", Is.EqualTo(v.x));
            Assert.That("(29)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-9)", "(-64)", "(-64)", "(-70)");
            var v = ov.swizzle.gga;
            Assert.That("(-64)", Is.EqualTo(v.x));
            Assert.That("(-64)", Is.EqualTo(v.y));
            Assert.That("(-70)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-1-4)-2)", "7", null, null);
            var v = ov.swizzle.ggar;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((-1-4)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(46)", "((-2-9)8)", "(46)", "((-2-9)8)");
            var v = ov.swizzle.ggag;
            Assert.That("((-2-9)8)", Is.EqualTo(v.x));
            Assert.That("((-2-9)8)", Is.EqualTo(v.y));
            Assert.That("((-2-9)8)", Is.EqualTo(v.z));
            Assert.That("((-2-9)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(49)", "-7", "((-40)-4)");
            var v = ov.swizzle.ggab;
            Assert.That("(49)", Is.EqualTo(v.x));
            Assert.That("(49)", Is.EqualTo(v.y));
            Assert.That("((-40)-4)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "((82)3)", "((9-9)-7)", "");
            var v = ov.swizzle.ggaa;
            Assert.That("((82)3)", Is.EqualTo(v.x));
            Assert.That("((82)3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-97)", "(-1-4)", "((-39)-5)", "((-1-7)8)");
            var v = ov.swizzle.gb;
            Assert.That("(-1-4)", Is.EqualTo(v.x));
            Assert.That("((-39)-5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("3", "((-23)-9)", "6", "(2-6)");
            var v = ov.swizzle.gbr;
            Assert.That("((-23)-9)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-6-5)4)", "6", "-5", "-5");
            var v = ov.swizzle.gbrr;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("((-6-5)4)", Is.EqualTo(v.z));
            Assert.That("((-6-5)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", null, "6", "(-83)");
            var v = ov.swizzle.gbrg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", null, "((32)7)", null);
            var v = ov.swizzle.gbrb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((32)7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((32)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((-3-9)-5)", null, "-2");
            var v = ov.swizzle.gbra;
            Assert.That("((-3-9)-5)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "9", "((-4-6)8)", "");
            var v = ov.swizzle.gbg;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((-4-6)8)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-4-5)6)", "(-1-9)", "6", "-2");
            var v = ov.swizzle.gbgr;
            Assert.That("(-1-9)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(-1-9)", Is.EqualTo(v.z));
            Assert.That("((-4-5)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(87)", "((9-5)5)", "((4-2)-3)", null);
            var v = ov.swizzle.gbgg;
            Assert.That("((9-5)5)", Is.EqualTo(v.x));
            Assert.That("((4-2)-3)", Is.EqualTo(v.y));
            Assert.That("((9-5)5)", Is.EqualTo(v.z));
            Assert.That("((9-5)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-8-6)", "((0-6)-2)", "-3");
            var v = ov.swizzle.gbgb;
            Assert.That("(-8-6)", Is.EqualTo(v.x));
            Assert.That("((0-6)-2)", Is.EqualTo(v.y));
            Assert.That("(-8-6)", Is.EqualTo(v.z));
            Assert.That("((0-6)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-4)", "-1", "((-36)4)", "(-4-2)");
            var v = ov.swizzle.gbga;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((-36)4)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("(-4-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((6-3)8)", "", "(7-7)", "(7-7)");
            var v = ov.swizzle.gbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(7-7)", Is.EqualTo(v.y));
            Assert.That("(7-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-1", "(-59)", "((0-2)1)", "((8-6)4)");
            var v = ov.swizzle.gbbr;
            Assert.That("(-59)", Is.EqualTo(v.x));
            Assert.That("((0-2)1)", Is.EqualTo(v.y));
            Assert.That("((0-2)1)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-6)", "", "", "-8");
            var v = ov.swizzle.gbbg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-2)8)", null, "(-48)", null);
            var v = ov.swizzle.gbbb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-48)", Is.EqualTo(v.y));
            Assert.That("(-48)", Is.EqualTo(v.z));
            Assert.That("(-48)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-9)-7)", "9", "9", "((24)6)");
            var v = ov.swizzle.gbba;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("((24)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-2)", "((8-9)-3)", "(0-2)", "1");
            var v = ov.swizzle.gba;
            Assert.That("((8-9)-3)", Is.EqualTo(v.x));
            Assert.That("(0-2)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((5-3)0)", "0", "((5-3)0)", null);
            var v = ov.swizzle.gbar;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((5-3)0)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((5-3)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-8)", "(4-8)", null, "4");
            var v = ov.swizzle.gbag;
            Assert.That("(4-8)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(4-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-5)9)", "(03)", "0", "2");
            var v = ov.swizzle.gbab;
            Assert.That("(03)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(44)", "-5", "-5");
            var v = ov.swizzle.gbaa;
            Assert.That("(44)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-4)1)", "-9", "((2-2)9)", "(7-3)");
            var v = ov.swizzle.ga;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("(7-3)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>(null, "1", "", "((6-4)-9)");
            var v = ov.swizzle.gar;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((6-4)-9)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-39)", "0", "(-39)", "((-99)6)");
            var v = ov.swizzle.garr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((-99)6)", Is.EqualTo(v.y));
            Assert.That("(-39)", Is.EqualTo(v.z));
            Assert.That("(-39)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(03)", "((98)2)", "(03)", "(6-9)");
            var v = ov.swizzle.garg;
            Assert.That("((98)2)", Is.EqualTo(v.x));
            Assert.That("(6-9)", Is.EqualTo(v.y));
            Assert.That("(03)", Is.EqualTo(v.z));
            Assert.That("((98)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-2)7)", "(-81)", "8", null);
            var v = ov.swizzle.garb;
            Assert.That("(-81)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((7-2)7)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(1-5)", "(82)", null);
            var v = ov.swizzle.gara;
            Assert.That("(1-5)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-6)", "((2-2)4)", "(9-6)", "((-3-7)-2)");
            var v = ov.swizzle.gag;
            Assert.That("((2-2)4)", Is.EqualTo(v.x));
            Assert.That("((-3-7)-2)", Is.EqualTo(v.y));
            Assert.That("((2-2)4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-8", "((-9-1)-1)", "((-98)-7)", "6");
            var v = ov.swizzle.gagr;
            Assert.That("((-9-1)-1)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("((-9-1)-1)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "((-12)6)", null, "(89)");
            var v = ov.swizzle.gagg;
            Assert.That("((-12)6)", Is.EqualTo(v.x));
            Assert.That("(89)", Is.EqualTo(v.y));
            Assert.That("((-12)6)", Is.EqualTo(v.z));
            Assert.That("((-12)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "(9-7)", "-7", "-1");
            var v = ov.swizzle.gagb;
            Assert.That("(9-7)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(9-7)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-2)", "((7-2)-1)", "2", "(-9-4)");
            var v = ov.swizzle.gaga;
            Assert.That("((7-2)-1)", Is.EqualTo(v.x));
            Assert.That("(-9-4)", Is.EqualTo(v.y));
            Assert.That("((7-2)-1)", Is.EqualTo(v.z));
            Assert.That("(-9-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-5)-3)", "((0-7)-5)", "5", null);
            var v = ov.swizzle.gab;
            Assert.That("((0-7)-5)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((06)8)", "((-85)0)", "((06)8)", "(-35)");
            var v = ov.swizzle.gabr;
            Assert.That("((-85)0)", Is.EqualTo(v.x));
            Assert.That("(-35)", Is.EqualTo(v.y));
            Assert.That("((06)8)", Is.EqualTo(v.z));
            Assert.That("((06)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-9)", "(-6-1)", "(32)", "((4-2)3)");
            var v = ov.swizzle.gabg;
            Assert.That("(-6-1)", Is.EqualTo(v.x));
            Assert.That("((4-2)3)", Is.EqualTo(v.y));
            Assert.That("(32)", Is.EqualTo(v.z));
            Assert.That("(-6-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-32)7)", "7", "((-32)7)", "1");
            var v = ov.swizzle.gabb;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("((-32)7)", Is.EqualTo(v.z));
            Assert.That("((-32)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-7)9)", "(01)", "(5-8)", "((8-4)-8)");
            var v = ov.swizzle.gaba;
            Assert.That("(01)", Is.EqualTo(v.x));
            Assert.That("((8-4)-8)", Is.EqualTo(v.y));
            Assert.That("(5-8)", Is.EqualTo(v.z));
            Assert.That("((8-4)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-8)", "((90)-8)", "(6-8)", "((7-3)9)");
            var v = ov.swizzle.gaa;
            Assert.That("((90)-8)", Is.EqualTo(v.x));
            Assert.That("((7-3)9)", Is.EqualTo(v.y));
            Assert.That("((7-3)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("9", "", "(7-1)", "(20)");
            var v = ov.swizzle.gaar;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(20)", Is.EqualTo(v.y));
            Assert.That("(20)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-8)", "-6", "(-44)", "(-44)");
            var v = ov.swizzle.gaag;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("(-44)", Is.EqualTo(v.y));
            Assert.That("(-44)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(13)", "(7-4)", "((-3-6)4)", "");
            var v = ov.swizzle.gaab;
            Assert.That("(7-4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-3-6)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-46)", "((6-8)-9)", "1");
            var v = ov.swizzle.gaaa;
            Assert.That("(-46)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "", "((-3-7)3)", "-5");
            var v = ov.swizzle.br;
            Assert.That("((-3-7)3)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("2", "2", "", "");
            var v = ov.swizzle.brr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((9-6)2)", "((9-6)2)", "(-62)", "6");
            var v = ov.swizzle.brrr;
            Assert.That("(-62)", Is.EqualTo(v.x));
            Assert.That("((9-6)2)", Is.EqualTo(v.y));
            Assert.That("((9-6)2)", Is.EqualTo(v.z));
            Assert.That("((9-6)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "(16)", null, "(-52)");
            var v = ov.swizzle.brrg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("(16)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((36)-5)", "((36)-5)", "", "(0-6)");
            var v = ov.swizzle.brrb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((36)-5)", Is.EqualTo(v.y));
            Assert.That("((36)-5)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-7)", null, null, "0");
            var v = ov.swizzle.brra;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(2-7)", Is.EqualTo(v.y));
            Assert.That("(2-7)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((-3-5)3)", "((-3-5)3)", "3");
            var v = ov.swizzle.brg;
            Assert.That("((-3-5)3)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-3-5)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-7", "", null, "-5");
            var v = ov.swizzle.brgr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-82)1)", "-3", "-3", "((62)-1)");
            var v = ov.swizzle.brgg;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("((-82)1)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(35)", "(35)", null, "((94)-7)");
            var v = ov.swizzle.brgb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(35)", Is.EqualTo(v.y));
            Assert.That("(35)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", null, "(02)", "((-1-4)2)");
            var v = ov.swizzle.brga;
            Assert.That("(02)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((-1-4)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((58)-6)", "((-7-2)-6)", "-5", "-5");
            var v = ov.swizzle.brb;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("((58)-6)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(02)", "-4", "(3-8)", "-4");
            var v = ov.swizzle.brbr;
            Assert.That("(3-8)", Is.EqualTo(v.x));
            Assert.That("(02)", Is.EqualTo(v.y));
            Assert.That("(3-8)", Is.EqualTo(v.z));
            Assert.That("(02)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((6-3)9)", "((77)-1)", "-2", "((77)-1)");
            var v = ov.swizzle.brbg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((6-3)9)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("((77)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((96)-7)", "6", "((46)-5)", "6");
            var v = ov.swizzle.brbb;
            Assert.That("((46)-5)", Is.EqualTo(v.x));
            Assert.That("((96)-7)", Is.EqualTo(v.y));
            Assert.That("((46)-5)", Is.EqualTo(v.z));
            Assert.That("((46)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-56)7)", "-7", "(2-5)", "(-67)");
            var v = ov.swizzle.brba;
            Assert.That("(2-5)", Is.EqualTo(v.x));
            Assert.That("((-56)7)", Is.EqualTo(v.y));
            Assert.That("(2-5)", Is.EqualTo(v.z));
            Assert.That("(-67)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-41)", "((-2-4)2)", "2", "");
            var v = ov.swizzle.bra;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-41)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-1-3)2)", "(53)", "-7", "((-3-7)-1)");
            var v = ov.swizzle.brar;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-1-3)2)", Is.EqualTo(v.y));
            Assert.That("((-3-7)-1)", Is.EqualTo(v.z));
            Assert.That("((-1-3)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "((-82)0)", "((-98)-1)", null);
            var v = ov.swizzle.brag;
            Assert.That("((-98)-1)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((-82)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((84)-8)", "((3-7)9)", "((3-7)9)", "((3-7)9)");
            var v = ov.swizzle.brab;
            Assert.That("((3-7)9)", Is.EqualTo(v.x));
            Assert.That("((84)-8)", Is.EqualTo(v.y));
            Assert.That("((3-7)9)", Is.EqualTo(v.z));
            Assert.That("((3-7)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-9)-9)", "(-2-1)", "-7", "((05)-9)");
            var v = ov.swizzle.braa;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-2-9)-9)", Is.EqualTo(v.y));
            Assert.That("((05)-9)", Is.EqualTo(v.z));
            Assert.That("((05)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((-65)-3)", "((-65)-3)", "(65)");
            var v = ov.swizzle.bg;
            Assert.That("((-65)-3)", Is.EqualTo(v.x));
            Assert.That("((-65)-3)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-6", "(-3-2)", "(68)", "(68)");
            var v = ov.swizzle.bgr;
            Assert.That("(68)", Is.EqualTo(v.x));
            Assert.That("(-3-2)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-26)", "(-87)", "((-6-1)-6)", "(45)");
            var v = ov.swizzle.bgrr;
            Assert.That("((-6-1)-6)", Is.EqualTo(v.x));
            Assert.That("(-87)", Is.EqualTo(v.y));
            Assert.That("(-26)", Is.EqualTo(v.z));
            Assert.That("(-26)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-10)3)", "-5", "6", "(-1-3)");
            var v = ov.swizzle.bgrg;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("((-10)3)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-72)9)", "2", "", null);
            var v = ov.swizzle.bgrb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((-72)9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-9)", "((91)2)", "((1-4)4)", "(-24)");
            var v = ov.swizzle.bgra;
            Assert.That("((1-4)4)", Is.EqualTo(v.x));
            Assert.That("((91)2)", Is.EqualTo(v.y));
            Assert.That("(-4-9)", Is.EqualTo(v.z));
            Assert.That("(-24)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((00)-1)", "-1", "2");
            var v = ov.swizzle.bgg;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((00)-1)", Is.EqualTo(v.y));
            Assert.That("((00)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, null, null, "-9");
            var v = ov.swizzle.bggr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-1)", "6", "((2-3)8)", "-5");
            var v = ov.swizzle.bggg;
            Assert.That("((2-3)8)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((34)-9)", "4", "((34)-9)", "");
            var v = ov.swizzle.bggb;
            Assert.That("((34)-9)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("((34)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-3", "", "-7");
            var v = ov.swizzle.bgga;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-4)", "2", "((10)-3)", "(-5-1)");
            var v = ov.swizzle.bgb;
            Assert.That("((10)-3)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((10)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-30)-2)", "((91)2)", "", "(-2-5)");
            var v = ov.swizzle.bgbr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((91)2)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-30)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-7)5)", "(22)", "", "-2");
            var v = ov.swizzle.bgbg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(22)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(22)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-96)2)", "", "-6", "");
            var v = ov.swizzle.bgbb;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-60)", "(19)", "(-60)", "(19)");
            var v = ov.swizzle.bgba;
            Assert.That("(-60)", Is.EqualTo(v.x));
            Assert.That("(19)", Is.EqualTo(v.y));
            Assert.That("(-60)", Is.EqualTo(v.z));
            Assert.That("(19)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-3)", "((-94)-7)", "-1", "-1");
            var v = ov.swizzle.bga;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((-94)-7)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-7", "-8", "(0-2)", "((-3-7)-7)");
            var v = ov.swizzle.bgar;
            Assert.That("(0-2)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("((-3-7)-7)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-4)6)", "(2-1)", "", "(23)");
            var v = ov.swizzle.bgag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(2-1)", Is.EqualTo(v.y));
            Assert.That("(23)", Is.EqualTo(v.z));
            Assert.That("(2-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "-3", "1", "0");
            var v = ov.swizzle.bgab;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((1-1)-2)", "-8", "-2");
            var v = ov.swizzle.bgaa;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((1-1)-2)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((71)-6)", "((-72)7)", "1");
            var v = ov.swizzle.bb;
            Assert.That("((-72)7)", Is.EqualTo(v.x));
            Assert.That("((-72)7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-74)9)", "", null, "");
            var v = ov.swizzle.bbr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-74)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-56)-6)", "(63)", "0", "(-6-4)");
            var v = ov.swizzle.bbrr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((-56)-6)", Is.EqualTo(v.z));
            Assert.That("((-56)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(5-7)", "(0-4)", null);
            var v = ov.swizzle.bbrg;
            Assert.That("(0-4)", Is.EqualTo(v.x));
            Assert.That("(0-4)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(5-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-2)5)", "", null, null);
            var v = ov.swizzle.bbrb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((7-2)5)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-5)", "((8-5)0)", "3", "(-69)");
            var v = ov.swizzle.bbra;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(8-5)", Is.EqualTo(v.z));
            Assert.That("(-69)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-2)0)", "1", "7", "((7-4)2)");
            var v = ov.swizzle.bbg;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((9-9)-1)", "4", null, "(-44)");
            var v = ov.swizzle.bbgr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("((9-9)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(24)", "((40)4)", "(24)", "((40)4)");
            var v = ov.swizzle.bbgg;
            Assert.That("(24)", Is.EqualTo(v.x));
            Assert.That("(24)", Is.EqualTo(v.y));
            Assert.That("((40)4)", Is.EqualTo(v.z));
            Assert.That("((40)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "-3", null, "");
            var v = ov.swizzle.bbgb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((28)5)", "((8-5)2)", "((7-6)8)", null);
            var v = ov.swizzle.bbga;
            Assert.That("((7-6)8)", Is.EqualTo(v.x));
            Assert.That("((7-6)8)", Is.EqualTo(v.y));
            Assert.That("((8-5)2)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "(96)", "-7", "(17)");
            var v = ov.swizzle.bbb;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-9-5)", "", "((0-1)7)", "((0-1)7)");
            var v = ov.swizzle.bbbr;
            Assert.That("((0-1)7)", Is.EqualTo(v.x));
            Assert.That("((0-1)7)", Is.EqualTo(v.y));
            Assert.That("((0-1)7)", Is.EqualTo(v.z));
            Assert.That("(-9-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-7", null, "(-61)");
            var v = ov.swizzle.bbbg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-5-1)", "6", "((-2-2)4)");
            var v = ov.swizzle.bbbb;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-9)-1)", "(-6-9)", "5", "(80)");
            var v = ov.swizzle.bbba;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("(80)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "-2", "(-56)", null);
            var v = ov.swizzle.bba;
            Assert.That("(-56)", Is.EqualTo(v.x));
            Assert.That("(-56)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-53)9)", "(60)", "", "-7");
            var v = ov.swizzle.bbar;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((-53)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-40)0)", "5", "5", "");
            var v = ov.swizzle.bbag;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(86)", "(-59)", "7", "((-7-4)-4)");
            var v = ov.swizzle.bbab;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("((-7-4)-4)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-1)", "((7-9)-6)", "((07)6)", "-8");
            var v = ov.swizzle.bbaa;
            Assert.That("((07)6)", Is.EqualTo(v.x));
            Assert.That("((07)6)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-46)9)", "((-13)-7)", "((-76)-8)", "-7");
            var v = ov.swizzle.ba;
            Assert.That("((-76)-8)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("", "-8", "-1", null);
            var v = ov.swizzle.bar;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "((35)5)", "(2-4)", "8");
            var v = ov.swizzle.barr;
            Assert.That("(2-4)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-55)", "", "((98)9)", null);
            var v = ov.swizzle.barg;
            Assert.That("((98)9)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(-55)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((21)-9)", "2", "2");
            var v = ov.swizzle.barb;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "9", "(2-7)", "((58)6)");
            var v = ov.swizzle.bara;
            Assert.That("(2-7)", Is.EqualTo(v.x));
            Assert.That("((58)6)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((58)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-3)", "-9", "((-95)5)", null);
            var v = ov.swizzle.bag;
            Assert.That("((-95)5)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((5-9)5)", "-5", null, "(35)");
            var v = ov.swizzle.bagr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(35)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("((5-9)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((43)5)", "(-62)", null);
            var v = ov.swizzle.bagg;
            Assert.That("(-62)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((43)5)", Is.EqualTo(v.z));
            Assert.That("((43)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "(7-2)", "", "((-8-7)-5)");
            var v = ov.swizzle.bagb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-8-7)-5)", Is.EqualTo(v.y));
            Assert.That("(7-2)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "1", "((58)8)", "((-80)-3)");
            var v = ov.swizzle.baga;
            Assert.That("((58)8)", Is.EqualTo(v.x));
            Assert.That("((-80)-3)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("((-80)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-7)-8)", "0", "(74)", "-3");
            var v = ov.swizzle.bab;
            Assert.That("(74)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(74)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "((81)-8)", "((1-1)-4)", "4");
            var v = ov.swizzle.babr;
            Assert.That("((1-1)-4)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((1-1)-4)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "((94)-1)", "((94)-1)", "-4");
            var v = ov.swizzle.babg;
            Assert.That("((94)-1)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((94)-1)", Is.EqualTo(v.z));
            Assert.That("((94)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(2-2)", "(2-2)", "((-97)0)");
            var v = ov.swizzle.babb;
            Assert.That("(2-2)", Is.EqualTo(v.x));
            Assert.That("((-97)0)", Is.EqualTo(v.y));
            Assert.That("(2-2)", Is.EqualTo(v.z));
            Assert.That("(2-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "(-1-7)", "(92)", "(92)");
            var v = ov.swizzle.baba;
            Assert.That("(92)", Is.EqualTo(v.x));
            Assert.That("(92)", Is.EqualTo(v.y));
            Assert.That("(92)", Is.EqualTo(v.z));
            Assert.That("(92)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((-24)-8)", "(0-4)", "((-8-4)-9)");
            var v = ov.swizzle.baa;
            Assert.That("(0-4)", Is.EqualTo(v.x));
            Assert.That("((-8-4)-9)", Is.EqualTo(v.y));
            Assert.That("((-8-4)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-22)", "", "-8", "((-91)6)");
            var v = ov.swizzle.baar;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((-91)6)", Is.EqualTo(v.y));
            Assert.That("((-91)6)", Is.EqualTo(v.z));
            Assert.That("(-22)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-4-3)", "-4", "(-4-3)");
            var v = ov.swizzle.baag;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(-4-3)", Is.EqualTo(v.y));
            Assert.That("(-4-3)", Is.EqualTo(v.z));
            Assert.That("(-4-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-2)", "((79)-9)", "((-58)1)", "");
            var v = ov.swizzle.baab;
            Assert.That("((-58)1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-58)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-5)2)", "((43)-3)", "(-7-1)", "((2-3)4)");
            var v = ov.swizzle.baaa;
            Assert.That("(-7-1)", Is.EqualTo(v.x));
            Assert.That("((2-3)4)", Is.EqualTo(v.y));
            Assert.That("((2-3)4)", Is.EqualTo(v.z));
            Assert.That("((2-3)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, null, "3", "");
            var v = ov.swizzle.ar;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(0-1)", "9", "(0-1)", "(-39)");
            var v = ov.swizzle.arr;
            Assert.That("(-39)", Is.EqualTo(v.x));
            Assert.That("(0-1)", Is.EqualTo(v.y));
            Assert.That("(0-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-2-7)", "((-53)4)", null, "(-6-4)");
            var v = ov.swizzle.arrr;
            Assert.That("(-6-4)", Is.EqualTo(v.x));
            Assert.That("(-2-7)", Is.EqualTo(v.y));
            Assert.That("(-2-7)", Is.EqualTo(v.z));
            Assert.That("(-2-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-96)6)", "(-1-8)", "(04)");
            var v = ov.swizzle.arrg;
            Assert.That("(04)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-96)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(14)", "((29)9)", "4", "7");
            var v = ov.swizzle.arrb;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(14)", Is.EqualTo(v.y));
            Assert.That("(14)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "", null, "-8");
            var v = ov.swizzle.arra;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "(-6-5)", null);
            var v = ov.swizzle.arg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("3", "-9", "((84)-4)", "((84)-4)");
            var v = ov.swizzle.argr;
            Assert.That("((84)-4)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(30)", "0", "(-2-8)");
            var v = ov.swizzle.argg;
            Assert.That("(-2-8)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(30)", Is.EqualTo(v.z));
            Assert.That("(30)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-14)", "(-14)", "-1", "((79)-3)");
            var v = ov.swizzle.argb;
            Assert.That("((79)-3)", Is.EqualTo(v.x));
            Assert.That("(-14)", Is.EqualTo(v.y));
            Assert.That("(-14)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((6-9)0)", "((6-9)0)", "0");
            var v = ov.swizzle.arga;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((6-9)0)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-4-1)", "", "(-4-1)");
            var v = ov.swizzle.arb;
            Assert.That("(-4-1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-3", null, "(2-8)", "((70)9)");
            var v = ov.swizzle.arbr;
            Assert.That("((70)9)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(2-8)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-2)-5)", "(86)", "", "0");
            var v = ov.swizzle.arbg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((0-2)-5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(86)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", null, "0", "");
            var v = ov.swizzle.arbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "-4", null, "((05)-2)");
            var v = ov.swizzle.arba;
            Assert.That("((05)-2)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((05)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-70)", "(-70)", "((-33)0)", "(-3-3)");
            var v = ov.swizzle.ara;
            Assert.That("(-3-3)", Is.EqualTo(v.x));
            Assert.That("(-70)", Is.EqualTo(v.y));
            Assert.That("(-3-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "-2", "((-5-3)-4)", "-8");
            var v = ov.swizzle.arar;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(79)", "((-4-3)0)", "-4", "(-3-9)");
            var v = ov.swizzle.arag;
            Assert.That("(-3-9)", Is.EqualTo(v.x));
            Assert.That("(79)", Is.EqualTo(v.y));
            Assert.That("(-3-9)", Is.EqualTo(v.z));
            Assert.That("((-4-3)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-48)", "(-48)", "-8", "((-36)-4)");
            var v = ov.swizzle.arab;
            Assert.That("((-36)-4)", Is.EqualTo(v.x));
            Assert.That("(-48)", Is.EqualTo(v.y));
            Assert.That("((-36)-4)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "", "(-53)", "(69)");
            var v = ov.swizzle.araa;
            Assert.That("(69)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(69)", Is.EqualTo(v.z));
            Assert.That("(69)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "", "", "0");
            var v = ov.swizzle.ag;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((6-3)7)", "((2-5)2)", "((6-3)7)", "");
            var v = ov.swizzle.agr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((2-5)2)", Is.EqualTo(v.y));
            Assert.That("((6-3)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-1", "-8", "-8", "-8");
            var v = ov.swizzle.agrr;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "(-34)", "", null);
            var v = ov.swizzle.agrg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-34)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(-34)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-7)-5)", "(8-8)", "((-8-5)-2)", "(-76)");
            var v = ov.swizzle.agrb;
            Assert.That("(-76)", Is.EqualTo(v.x));
            Assert.That("(8-8)", Is.EqualTo(v.y));
            Assert.That("((-5-7)-5)", Is.EqualTo(v.z));
            Assert.That("((-8-5)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-12)-6)", "4", "(2-8)", "");
            var v = ov.swizzle.agra;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((-12)-6)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(-50)", "(-34)", "0");
            var v = ov.swizzle.agg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(-50)", Is.EqualTo(v.y));
            Assert.That("(-50)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-8-2)1)", "0", "((-8-2)1)", "(7-5)");
            var v = ov.swizzle.aggr;
            Assert.That("(7-5)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("((-8-2)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-6)-8)", "0", "(-75)", "((7-5)-5)");
            var v = ov.swizzle.aggg;
            Assert.That("((7-5)-5)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", null, "(93)", "4");
            var v = ov.swizzle.aggb;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(93)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(65)", "((9-5)0)", "", "((0-7)-3)");
            var v = ov.swizzle.agga;
            Assert.That("((0-7)-3)", Is.EqualTo(v.x));
            Assert.That("((9-5)0)", Is.EqualTo(v.y));
            Assert.That("((9-5)0)", Is.EqualTo(v.z));
            Assert.That("((0-7)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-7)0)", "-8", "3", "((-6-7)0)");
            var v = ov.swizzle.agb;
            Assert.That("((-6-7)0)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-25)", "((07)-3)", "-6", "((81)6)");
            var v = ov.swizzle.agbr;
            Assert.That("((81)6)", Is.EqualTo(v.x));
            Assert.That("((07)-3)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("(-25)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "3", null, "((2-2)9)");
            var v = ov.swizzle.agbg;
            Assert.That("((2-2)9)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-61)-2)", "", "((57)2)", "((-61)-2)");
            var v = ov.swizzle.agbb;
            Assert.That("((-61)-2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((57)2)", Is.EqualTo(v.z));
            Assert.That("((57)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-3)3)", "((1-2)-5)", "((-58)8)", "(-4-5)");
            var v = ov.swizzle.agba;
            Assert.That("(-4-5)", Is.EqualTo(v.x));
            Assert.That("((1-2)-5)", Is.EqualTo(v.y));
            Assert.That("((-58)8)", Is.EqualTo(v.z));
            Assert.That("(-4-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-4)-1)", "-7", "(5-6)", "(-43)");
            var v = ov.swizzle.aga;
            Assert.That("(-43)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(-43)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-1", "9", "-1", "(-9-4)");
            var v = ov.swizzle.agar;
            Assert.That("(-9-4)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("(-9-4)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-1)", "(9-1)", "1", "((3-6)-5)");
            var v = ov.swizzle.agag;
            Assert.That("((3-6)-5)", Is.EqualTo(v.x));
            Assert.That("(9-1)", Is.EqualTo(v.y));
            Assert.That("((3-6)-5)", Is.EqualTo(v.z));
            Assert.That("(9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-8)2)", "((0-8)2)", null, "2");
            var v = ov.swizzle.agab;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("((0-8)2)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-5)", "9", "(3-3)", "((86)7)");
            var v = ov.swizzle.agaa;
            Assert.That("((86)7)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("((86)7)", Is.EqualTo(v.z));
            Assert.That("((86)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-8)", "((-47)1)", "3", "((-7-2)-7)");
            var v = ov.swizzle.ab;
            Assert.That("((-7-2)-7)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>(null, "-1", null, "6");
            var v = ov.swizzle.abr;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>(null, "((-58)2)", "(-1-7)", "-4");
            var v = ov.swizzle.abrr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(-1-7)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "((3-3)1)", "(-62)", "1");
            var v = ov.swizzle.abrg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(-62)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("((3-3)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", null, "6", null);
            var v = ov.swizzle.abrb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-11)8)", "(-35)", "((-11)8)", null);
            var v = ov.swizzle.abra;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-11)8)", Is.EqualTo(v.y));
            Assert.That("((-11)8)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(41)", "0", "-3", "(4-8)");
            var v = ov.swizzle.abg;
            Assert.That("(4-8)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-5", "((92)7)", "((92)7)", null);
            var v = ov.swizzle.abgr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((92)7)", Is.EqualTo(v.y));
            Assert.That("((92)7)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-38)", "4", "1");
            var v = ov.swizzle.abgg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("(-38)", Is.EqualTo(v.z));
            Assert.That("(-38)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(58)", "((3-4)-4)", null, "((1-6)2)");
            var v = ov.swizzle.abgb;
            Assert.That("((1-6)2)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((3-4)-4)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "-5", "-5", "2");
            var v = ov.swizzle.abga;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-7)8)", "(18)", "4", "((62)-4)");
            var v = ov.swizzle.abb;
            Assert.That("((62)-4)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "-7", "(-1-2)", "((9-7)-7)");
            var v = ov.swizzle.abbr;
            Assert.That("((9-7)-7)", Is.EqualTo(v.x));
            Assert.That("(-1-2)", Is.EqualTo(v.y));
            Assert.That("(-1-2)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(1-4)", "((-31)8)", "(-7-2)");
            var v = ov.swizzle.abbg;
            Assert.That("(-7-2)", Is.EqualTo(v.x));
            Assert.That("((-31)8)", Is.EqualTo(v.y));
            Assert.That("((-31)8)", Is.EqualTo(v.z));
            Assert.That("(1-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "(3-9)", "(-99)", "((-91)1)");
            var v = ov.swizzle.abbb;
            Assert.That("((-91)1)", Is.EqualTo(v.x));
            Assert.That("(-99)", Is.EqualTo(v.y));
            Assert.That("(-99)", Is.EqualTo(v.z));
            Assert.That("(-99)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "(-12)", "((-4-7)4)", "(37)");
            var v = ov.swizzle.abba;
            Assert.That("(37)", Is.EqualTo(v.x));
            Assert.That("((-4-7)4)", Is.EqualTo(v.y));
            Assert.That("((-4-7)4)", Is.EqualTo(v.z));
            Assert.That("(37)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(41)", "(41)", "-8");
            var v = ov.swizzle.aba;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(41)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-8-5)", "(2-3)", "(-14)", "(-8-5)");
            var v = ov.swizzle.abar;
            Assert.That("(-8-5)", Is.EqualTo(v.x));
            Assert.That("(-14)", Is.EqualTo(v.y));
            Assert.That("(-8-5)", Is.EqualTo(v.z));
            Assert.That("(-8-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-7)", "9", "((65)-1)", "");
            var v = ov.swizzle.abag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((65)-1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((-4-6)-3)", "2", "((-4-6)-3)");
            var v = ov.swizzle.abab;
            Assert.That("((-4-6)-3)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((-4-6)-3)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "((-16)-6)", "((-7-7)9)", "3");
            var v = ov.swizzle.abaa;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((-7-7)9)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((76)-1)", null, "9", "((76)-1)");
            var v = ov.swizzle.aa;
            Assert.That("((76)-1)", Is.EqualTo(v.x));
            Assert.That("((76)-1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-5", "-2", "(99)", "(99)");
            var v = ov.swizzle.aar;
            Assert.That("(99)", Is.EqualTo(v.x));
            Assert.That("(99)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-87)-5)", "((54)-1)", "(-12)", "((54)-1)");
            var v = ov.swizzle.aarr;
            Assert.That("((54)-1)", Is.EqualTo(v.x));
            Assert.That("((54)-1)", Is.EqualTo(v.y));
            Assert.That("((-87)-5)", Is.EqualTo(v.z));
            Assert.That("((-87)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-31)1)", null, "((-31)1)", null);
            var v = ov.swizzle.aarg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-31)1)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((05)-2)", "", "(67)", "(67)");
            var v = ov.swizzle.aarb;
            Assert.That("(67)", Is.EqualTo(v.x));
            Assert.That("(67)", Is.EqualTo(v.y));
            Assert.That("((05)-2)", Is.EqualTo(v.z));
            Assert.That("(67)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-74)9)", "((-74)9)", "(-78)", "-8");
            var v = ov.swizzle.aara;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("((-74)9)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((33)-2)", "(-3-8)", "(-1-2)");
            var v = ov.swizzle.aag;
            Assert.That("(-1-2)", Is.EqualTo(v.x));
            Assert.That("(-1-2)", Is.EqualTo(v.y));
            Assert.That("((33)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-89)", "(-26)", "3", "8");
            var v = ov.swizzle.aagr;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-26)", Is.EqualTo(v.z));
            Assert.That("(-89)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "9", null, "");
            var v = ov.swizzle.aagg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(87)", "((-6-9)7)", null, "((0-2)7)");
            var v = ov.swizzle.aagb;
            Assert.That("((0-2)7)", Is.EqualTo(v.x));
            Assert.That("((0-2)7)", Is.EqualTo(v.y));
            Assert.That("((-6-9)7)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-74)", "", "((2-4)-8)", "");
            var v = ov.swizzle.aaga;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-1)", null, "((2-6)-3)", "");
            var v = ov.swizzle.aab;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((2-6)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-8", "((-50)-9)", "(6-5)", "");
            var v = ov.swizzle.aabr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(6-5)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "((-7-1)-1)", "1", "8");
            var v = ov.swizzle.aabg;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("((-7-1)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-5)-1)", "((7-4)1)", "(-75)", "((6-8)-6)");
            var v = ov.swizzle.aabb;
            Assert.That("((6-8)-6)", Is.EqualTo(v.x));
            Assert.That("((6-8)-6)", Is.EqualTo(v.y));
            Assert.That("(-75)", Is.EqualTo(v.z));
            Assert.That("(-75)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "((6-5)3)", "(-44)", "6");
            var v = ov.swizzle.aaba;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(-44)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-73)", "(-9-5)", "((2-3)-4)", "(4-3)");
            var v = ov.swizzle.aaa;
            Assert.That("(4-3)", Is.EqualTo(v.x));
            Assert.That("(4-3)", Is.EqualTo(v.y));
            Assert.That("(4-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-36)", "(-3-4)", "", "-8");
            var v = ov.swizzle.aaar;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("(-36)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "", "-7", "-3");
            var v = ov.swizzle.aaag;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>(null, "2", null, "((-64)3)");
            var v = ov.swizzle.aaab;
            Assert.That("((-64)3)", Is.EqualTo(v.x));
            Assert.That("((-64)3)", Is.EqualTo(v.y));
            Assert.That("((-64)3)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-72)", "", "((-45)8)", "");
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
            var v0 = new gvec4<string>("((-21)-6)", "2", "", "(-1-4)");
            var v1 = new gvec2<string>("-9", "");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-9", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That("(-1-4)", Is.EqualTo(v0.w));
        
            Assert.That("((-21)-6)", Is.EqualTo(v2.x));
            Assert.That("2", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>(null, "((-87)1)", null, "((-17)-3)");
            var v1 = new gvec2<string>("((5-3)-5)", "((-74)7)");
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((5-3)-5)", Is.EqualTo(v0.x));
            Assert.That("((-87)1)", Is.EqualTo(v0.y));
            Assert.That("((-74)7)", Is.EqualTo(v0.z));
            Assert.That("((-17)-3)", Is.EqualTo(v0.w));
        
            Assert.That(null, Is.EqualTo(v2.x));
            Assert.That(null, Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(61)", "(53)", "(61)", "(61)");
            var v1 = new gvec2<string>("((67)-2)", "((-5-4)-9)");
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(61)", Is.EqualTo(v0.x));
            Assert.That("((67)-2)", Is.EqualTo(v0.y));
            Assert.That("((-5-4)-9)", Is.EqualTo(v0.z));
            Assert.That("(61)", Is.EqualTo(v0.w));
        
            Assert.That("(53)", Is.EqualTo(v2.x));
            Assert.That("(61)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((-5-7)3)", "-2", "((2-2)-4)", "(-7-7)");
            var v1 = new gvec3<string>("((92)-4)", "3", "(-5-5)");
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((92)-4)", Is.EqualTo(v0.x));
            Assert.That("3", Is.EqualTo(v0.y));
            Assert.That("(-5-5)", Is.EqualTo(v0.z));
            Assert.That("(-7-7)", Is.EqualTo(v0.w));
        
            Assert.That("((-5-7)3)", Is.EqualTo(v2.x));
            Assert.That("-2", Is.EqualTo(v2.y));
            Assert.That("((2-2)-4)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("-6", "", "", null);
            var v1 = new gvec2<string>("((-40)-5)", "6");
            var v2 = v0.xw;
            v0.xw = v1;
            var v3 = v0.xw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-40)-5)", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That("6", Is.EqualTo(v0.w));
        
            Assert.That("-6", Is.EqualTo(v2.x));
            Assert.That(null, Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("9", "6", "2", "((-4-7)-3)");
            var v1 = new gvec2<string>("-8", "");
            var v2 = v0.yw;
            v0.yw = v1;
            var v3 = v0.yw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("9", Is.EqualTo(v0.x));
            Assert.That("-8", Is.EqualTo(v0.y));
            Assert.That("2", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("6", Is.EqualTo(v2.x));
            Assert.That("((-4-7)-3)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((-8-6)1)", "(71)", "5", "(6-1)");
            var v1 = new gvec3<string>("(-56)", "((7-9)-3)", "((83)2)");
            var v2 = v0.xyw;
            v0.xyw = v1;
            var v3 = v0.xyw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-56)", Is.EqualTo(v0.x));
            Assert.That("((7-9)-3)", Is.EqualTo(v0.y));
            Assert.That("5", Is.EqualTo(v0.z));
            Assert.That("((83)2)", Is.EqualTo(v0.w));
        
            Assert.That("((-8-6)1)", Is.EqualTo(v2.x));
            Assert.That("(71)", Is.EqualTo(v2.y));
            Assert.That("(6-1)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(1-3)", null, "-4", "-4");
            var v1 = new gvec2<string>("1", "2");
            var v2 = v0.zw;
            v0.zw = v1;
            var v3 = v0.zw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(1-3)", Is.EqualTo(v0.x));
            Assert.That(null, Is.EqualTo(v0.y));
            Assert.That("1", Is.EqualTo(v0.z));
            Assert.That("2", Is.EqualTo(v0.w));
        
            Assert.That("-4", Is.EqualTo(v2.x));
            Assert.That("-4", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((1-5)-2)", "(-9-6)", "1", "((80)9)");
            var v1 = new gvec3<string>("9", "", "9");
            var v2 = v0.xzw;
            v0.xzw = v1;
            var v3 = v0.xzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("9", Is.EqualTo(v0.x));
            Assert.That("(-9-6)", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That("9", Is.EqualTo(v0.w));
        
            Assert.That("((1-5)-2)", Is.EqualTo(v2.x));
            Assert.That("1", Is.EqualTo(v2.y));
            Assert.That("((80)9)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("((74)5)", "-5", "-8", "");
            var v1 = new gvec3<string>("((10)8)", "-9", "-5");
            var v2 = v0.yzw;
            v0.yzw = v1;
            var v3 = v0.yzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((74)5)", Is.EqualTo(v0.x));
            Assert.That("((10)8)", Is.EqualTo(v0.y));
            Assert.That("-9", Is.EqualTo(v0.z));
            Assert.That("-5", Is.EqualTo(v0.w));
        
            Assert.That("-5", Is.EqualTo(v2.x));
            Assert.That("-8", Is.EqualTo(v2.y));
            Assert.That("", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(-1-1)", "(89)", "-5", "-5");
            var v1 = new gvec4<string>("((00)-8)", "2", "", "(4-3)");
            var v2 = v0.xyzw;
            v0.xyzw = v1;
            var v3 = v0.xyzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((00)-8)", Is.EqualTo(v0.x));
            Assert.That("2", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That("(4-3)", Is.EqualTo(v0.w));
        
            Assert.That("(-1-1)", Is.EqualTo(v2.x));
            Assert.That("(89)", Is.EqualTo(v2.y));
            Assert.That("-5", Is.EqualTo(v2.z));
            Assert.That("-5", Is.EqualTo(v2.w));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            gvec4<string> v0 = new gvec4<string>("3", "(9-7)", "", null);
            string v1 = "((01)-6)";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((01)-6)", Is.EqualTo(v0.x));
            Assert.That("(9-7)", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That(null, Is.EqualTo(v0.w));
        
            Assert.That("3", Is.EqualTo(v2));
        }
        {
            gvec4<string> v0 = new gvec4<string>("((90)-5)", "(-23)", "((9-9)9)", "0");
            string v1 = null;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((90)-5)", Is.EqualTo(v0.x));
            Assert.That(null, Is.EqualTo(v0.y));
            Assert.That("((9-9)9)", Is.EqualTo(v0.z));
            Assert.That("0", Is.EqualTo(v0.w));
        
            Assert.That("(-23)", Is.EqualTo(v2));
        }
        {
            gvec4<string> v0 = new gvec4<string>("(12)", "(12)", "((-7-8)4)", "((-7-8)4)");
            gvec2<string> v1 = new gvec2<string>("7", null);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("7", Is.EqualTo(v0.x));
            Assert.That(null, Is.EqualTo(v0.y));
            Assert.That("((-7-8)4)", Is.EqualTo(v0.z));
            Assert.That("((-7-8)4)", Is.EqualTo(v0.w));
        
            Assert.That("(12)", Is.EqualTo(v2.x));
            Assert.That("(12)", Is.EqualTo(v2.y));
        }
        {
            gvec4<string> v0 = new gvec4<string>("-7", "", "(-8-4)", "(-9-8)");
            string v1 = null;
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-7", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That(null, Is.EqualTo(v0.z));
            Assert.That("(-9-8)", Is.EqualTo(v0.w));
        
            Assert.That("(-8-4)", Is.EqualTo(v2));
        }
        {
            gvec4<string> v0 = new gvec4<string>("-3", "((-6-1)-7)", "((-6-1)-7)", "");
            gvec2<string> v1 = new gvec2<string>("-1", "((6-3)0)");
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-1", Is.EqualTo(v0.x));
            Assert.That("((-6-1)-7)", Is.EqualTo(v0.y));
            Assert.That("((6-3)0)", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("-3", Is.EqualTo(v2.x));
            Assert.That("((-6-1)-7)", Is.EqualTo(v2.y));
        }
        {
            gvec4<string> v0 = new gvec4<string>("((63)-8)", "(25)", "", "((63)-8)");
            gvec2<string> v1 = new gvec2<string>("((-12)5)", "(0-8)");
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((63)-8)", Is.EqualTo(v0.x));
            Assert.That("((-12)5)", Is.EqualTo(v0.y));
            Assert.That("(0-8)", Is.EqualTo(v0.z));
            Assert.That("((63)-8)", Is.EqualTo(v0.w));
        
            Assert.That("(25)", Is.EqualTo(v2.x));
            Assert.That("", Is.EqualTo(v2.y));
        }
        {
            gvec4<string> v0 = new gvec4<string>("5", "(14)", "((-71)-9)", "-8");
            gvec3<string> v1 = new gvec3<string>("((98)3)", null, "(46)");
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((98)3)", Is.EqualTo(v0.x));
            Assert.That(null, Is.EqualTo(v0.y));
            Assert.That("(46)", Is.EqualTo(v0.z));
            Assert.That("-8", Is.EqualTo(v0.w));
        
            Assert.That("5", Is.EqualTo(v2.x));
            Assert.That("(14)", Is.EqualTo(v2.y));
            Assert.That("((-71)-9)", Is.EqualTo(v2.z));
        }
        {
            gvec4<string> v0 = new gvec4<string>("-4", "-4", "-4", "(-99)");
            string v1 = null;
            var v2 = v0.a;
            v0.a = v1;
            var v3 = v0.a;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-4", Is.EqualTo(v0.x));
            Assert.That("-4", Is.EqualTo(v0.y));
            Assert.That("-4", Is.EqualTo(v0.z));
            Assert.That(null, Is.EqualTo(v0.w));
        
            Assert.That("(-99)", Is.EqualTo(v2));
        }
        {
            gvec4<string> v0 = new gvec4<string>("((-8-7)2)", "8", "((-8-7)2)", "-6");
            gvec2<string> v1 = new gvec2<string>("(-96)", "(6-5)");
            var v2 = v0.ra;
            v0.ra = v1;
            var v3 = v0.ra;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-96)", Is.EqualTo(v0.x));
            Assert.That("8", Is.EqualTo(v0.y));
            Assert.That("((-8-7)2)", Is.EqualTo(v0.z));
            Assert.That("(6-5)", Is.EqualTo(v0.w));
        
            Assert.That("((-8-7)2)", Is.EqualTo(v2.x));
            Assert.That("-6", Is.EqualTo(v2.y));
        }
        {
            gvec4<string> v0 = new gvec4<string>("((31)4)", "((74)9)", null, "(-3-8)");
            gvec2<string> v1 = new gvec2<string>("(1-2)", "-2");
            var v2 = v0.ga;
            v0.ga = v1;
            var v3 = v0.ga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((31)4)", Is.EqualTo(v0.x));
            Assert.That("(1-2)", Is.EqualTo(v0.y));
            Assert.That(null, Is.EqualTo(v0.z));
            Assert.That("-2", Is.EqualTo(v0.w));
        
            Assert.That("((74)9)", Is.EqualTo(v2.x));
            Assert.That("(-3-8)", Is.EqualTo(v2.y));
        }
        {
            gvec4<string> v0 = new gvec4<string>("-6", "-6", "((08)8)", "(4-3)");
            gvec3<string> v1 = new gvec3<string>("((60)-6)", null, "-2");
            var v2 = v0.rga;
            v0.rga = v1;
            var v3 = v0.rga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((60)-6)", Is.EqualTo(v0.x));
            Assert.That(null, Is.EqualTo(v0.y));
            Assert.That("((08)8)", Is.EqualTo(v0.z));
            Assert.That("-2", Is.EqualTo(v0.w));
        
            Assert.That("-6", Is.EqualTo(v2.x));
            Assert.That("-6", Is.EqualTo(v2.y));
            Assert.That("(4-3)", Is.EqualTo(v2.z));
        }
        {
            gvec4<string> v0 = new gvec4<string>("((-27)-7)", "((08)8)", "", "3");
            gvec2<string> v1 = new gvec2<string>("(-92)", "((-9-5)-4)");
            var v2 = v0.ba;
            v0.ba = v1;
            var v3 = v0.ba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-27)-7)", Is.EqualTo(v0.x));
            Assert.That("((08)8)", Is.EqualTo(v0.y));
            Assert.That("(-92)", Is.EqualTo(v0.z));
            Assert.That("((-9-5)-4)", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("3", Is.EqualTo(v2.y));
        }
        {
            gvec4<string> v0 = new gvec4<string>("2", "(7-3)", "", "2");
            gvec3<string> v1 = new gvec3<string>(null, "7", "-5");
            var v2 = v0.rba;
            v0.rba = v1;
            var v3 = v0.rba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(null, Is.EqualTo(v0.x));
            Assert.That("(7-3)", Is.EqualTo(v0.y));
            Assert.That("7", Is.EqualTo(v0.z));
            Assert.That("-5", Is.EqualTo(v0.w));
        
            Assert.That("2", Is.EqualTo(v2.x));
            Assert.That("", Is.EqualTo(v2.y));
            Assert.That("2", Is.EqualTo(v2.z));
        }
        {
            gvec4<string> v0 = new gvec4<string>("0", "(80)", "0", "-3");
            gvec3<string> v1 = new gvec3<string>(null, null, "((3-7)8)");
            var v2 = v0.gba;
            v0.gba = v1;
            var v3 = v0.gba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("0", Is.EqualTo(v0.x));
            Assert.That(null, Is.EqualTo(v0.y));
            Assert.That(null, Is.EqualTo(v0.z));
            Assert.That("((3-7)8)", Is.EqualTo(v0.w));
        
            Assert.That("(80)", Is.EqualTo(v2.x));
            Assert.That("0", Is.EqualTo(v2.y));
            Assert.That("-3", Is.EqualTo(v2.z));
        }
        {
            gvec4<string> v0 = new gvec4<string>("-8", "((1-5)-8)", "(85)", "((-15)1)");
            gvec4<string> v1 = new gvec4<string>("((12)-1)", null, "2", "2");
            var v2 = v0.rgba;
            v0.rgba = v1;
            var v3 = v0.rgba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((12)-1)", Is.EqualTo(v0.x));
            Assert.That(null, Is.EqualTo(v0.y));
            Assert.That("2", Is.EqualTo(v0.z));
            Assert.That("2", Is.EqualTo(v0.w));
        
            Assert.That("-8", Is.EqualTo(v2.x));
            Assert.That("((1-5)-8)", Is.EqualTo(v2.y));
            Assert.That("(85)", Is.EqualTo(v2.z));
            Assert.That("((-15)1)", Is.EqualTo(v2.w));
        }
    }

}
