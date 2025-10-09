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

namespace GlmResharpenedTest.Generated.Vec3_Swizzle;

[TestFixture]
public class TSwizzleVec3Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new gvec3<string>("((-57)9)", "((03)3)", "(65)");
            var v = ov.swizzle.xx;
            Assert.That("((-57)9)", Is.EqualTo(v.x));
            Assert.That("((-57)9)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((88)-2)", "(-76)", "((-1-7)9)");
            var v = ov.swizzle.xxx;
            Assert.That("((88)-2)", Is.EqualTo(v.x));
            Assert.That("((88)-2)", Is.EqualTo(v.y));
            Assert.That("((88)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(19)", "((5-7)-2)", "(19)");
            var v = ov.swizzle.xxxx;
            Assert.That("(19)", Is.EqualTo(v.x));
            Assert.That("(19)", Is.EqualTo(v.y));
            Assert.That("(19)", Is.EqualTo(v.z));
            Assert.That("(19)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((38)2)", "null", "((-35)-4)");
            var v = ov.swizzle.xxxy;
            Assert.That("((38)2)", Is.EqualTo(v.x));
            Assert.That("((38)2)", Is.EqualTo(v.y));
            Assert.That("((38)2)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "null", "(50)");
            var v = ov.swizzle.xxxz;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(50)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-2-2)", "((93)3)", "((93)3)");
            var v = ov.swizzle.xxy;
            Assert.That("(-2-2)", Is.EqualTo(v.x));
            Assert.That("(-2-2)", Is.EqualTo(v.y));
            Assert.That("((93)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-27)3)", "null", "-4");
            var v = ov.swizzle.xxyx;
            Assert.That("((-27)3)", Is.EqualTo(v.x));
            Assert.That("((-27)3)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-27)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "null", "-8");
            var v = ov.swizzle.xxyy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-5-8)-6)", "(9-7)");
            var v = ov.swizzle.xxyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-5-8)-6)", Is.EqualTo(v.z));
            Assert.That("(9-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((53)0)", "((53)0)", "(1-5)");
            var v = ov.swizzle.xxz;
            Assert.That("((53)0)", Is.EqualTo(v.x));
            Assert.That("((53)0)", Is.EqualTo(v.y));
            Assert.That("(1-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-76)-4)", "6", "((3-3)2)");
            var v = ov.swizzle.xxzx;
            Assert.That("((-76)-4)", Is.EqualTo(v.x));
            Assert.That("((-76)-4)", Is.EqualTo(v.y));
            Assert.That("((3-3)2)", Is.EqualTo(v.z));
            Assert.That("((-76)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((8-5)7)", "5", "");
            var v = ov.swizzle.xxzy;
            Assert.That("((8-5)7)", Is.EqualTo(v.x));
            Assert.That("((8-5)7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-5", "-9", "(-15)");
            var v = ov.swizzle.xxzz;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(-15)", Is.EqualTo(v.z));
            Assert.That("(-15)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-46)", "", "-2");
            var v = ov.swizzle.xy;
            Assert.That("(-46)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("null", "", "(-31)");
            var v = ov.swizzle.xyx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-2-8)", "", "((-6-2)7)");
            var v = ov.swizzle.xyxx;
            Assert.That("(-2-8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-2-8)", Is.EqualTo(v.z));
            Assert.That("(-2-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((66)-8)", "(36)", "((-89)-8)");
            var v = ov.swizzle.xyxy;
            Assert.That("((66)-8)", Is.EqualTo(v.x));
            Assert.That("(36)", Is.EqualTo(v.y));
            Assert.That("((66)-8)", Is.EqualTo(v.z));
            Assert.That("(36)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-7-4)-9)", "(02)", "");
            var v = ov.swizzle.xyxz;
            Assert.That("((-7-4)-9)", Is.EqualTo(v.x));
            Assert.That("(02)", Is.EqualTo(v.y));
            Assert.That("((-7-4)-9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-81)", "(41)", "-8");
            var v = ov.swizzle.xyy;
            Assert.That("(-81)", Is.EqualTo(v.x));
            Assert.That("(41)", Is.EqualTo(v.y));
            Assert.That("(41)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-7", "-1", "((-94)0)");
            var v = ov.swizzle.xyyx;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "(-5-8)", "(-8-4)");
            var v = ov.swizzle.xyyy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(-5-8)", Is.EqualTo(v.y));
            Assert.That("(-5-8)", Is.EqualTo(v.z));
            Assert.That("(-5-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", "null", "9");
            var v = ov.swizzle.xyyz;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "-7", "((8-4)-8)");
            var v = ov.swizzle.xyz;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((8-4)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "6", "null");
            var v = ov.swizzle.xyzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(40)", "-2", "((27)-3)");
            var v = ov.swizzle.xyzy;
            Assert.That("(40)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((27)-3)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "-4", "((15)-8)");
            var v = ov.swizzle.xyzz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((15)-8)", Is.EqualTo(v.z));
            Assert.That("((15)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-2-3)-9)", "(2-4)", "(2-4)");
            var v = ov.swizzle.xz;
            Assert.That("((-2-3)-9)", Is.EqualTo(v.x));
            Assert.That("(2-4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("null", "(-2-8)", "((11)-5)");
            var v = ov.swizzle.xzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((11)-5)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-8", "(8-1)", "0");
            var v = ov.swizzle.xzxx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "null", "((3-3)2)");
            var v = ov.swizzle.xzxy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((3-3)2)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "null", "(2-9)");
            var v = ov.swizzle.xzxz;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("(2-9)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("(2-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "(87)", "((01)5)");
            var v = ov.swizzle.xzy;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((01)5)", Is.EqualTo(v.y));
            Assert.That("(87)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-8-8)0)", "-1", "null");
            var v = ov.swizzle.xzyx;
            Assert.That("((-8-8)0)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("((-8-8)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(4-5)", "", "(94)");
            var v = ov.swizzle.xzyy;
            Assert.That("(4-5)", Is.EqualTo(v.x));
            Assert.That("(94)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "((9-2)1)", "((1-2)-5)");
            var v = ov.swizzle.xzyz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((1-2)-5)", Is.EqualTo(v.y));
            Assert.That("((9-2)1)", Is.EqualTo(v.z));
            Assert.That("((1-2)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-86)-4)", "6");
            var v = ov.swizzle.xzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "3", "");
            var v = ov.swizzle.xzzx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((62)-8)", "-9", "((77)1)");
            var v = ov.swizzle.xzzy;
            Assert.That("((62)-8)", Is.EqualTo(v.x));
            Assert.That("((77)1)", Is.EqualTo(v.y));
            Assert.That("((77)1)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((20)4)", "3", "(88)");
            var v = ov.swizzle.xzzz;
            Assert.That("((20)4)", Is.EqualTo(v.x));
            Assert.That("(88)", Is.EqualTo(v.y));
            Assert.That("(88)", Is.EqualTo(v.z));
            Assert.That("(88)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-15)1)", "((-17)5)", "((-93)3)");
            var v = ov.swizzle.yx;
            Assert.That("((-17)5)", Is.EqualTo(v.x));
            Assert.That("((-15)1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(63)", "", "-7");
            var v = ov.swizzle.yxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(63)", Is.EqualTo(v.y));
            Assert.That("(63)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-2-2)", "((-7-7)-5)", "(-2-2)");
            var v = ov.swizzle.yxxx;
            Assert.That("((-7-7)-5)", Is.EqualTo(v.x));
            Assert.That("(-2-2)", Is.EqualTo(v.y));
            Assert.That("(-2-2)", Is.EqualTo(v.z));
            Assert.That("(-2-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "(-29)", "");
            var v = ov.swizzle.yxxy;
            Assert.That("(-29)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(-29)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "-1", "(8-6)");
            var v = ov.swizzle.yxxz;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("(8-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-87)4)", "-9", "");
            var v = ov.swizzle.yxy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((-87)4)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "-3", "null");
            var v = ov.swizzle.yxyx;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "-3", "");
            var v = ov.swizzle.yxyy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-1-2)4)", "((-14)0)");
            var v = ov.swizzle.yxyz;
            Assert.That("((-1-2)4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-1-2)4)", Is.EqualTo(v.z));
            Assert.That("((-14)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-20)", "((52)8)", "((52)8)");
            var v = ov.swizzle.yxz;
            Assert.That("((52)8)", Is.EqualTo(v.x));
            Assert.That("(-20)", Is.EqualTo(v.y));
            Assert.That("((52)8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-8", "-8", "(-32)");
            var v = ov.swizzle.yxzx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(-32)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(76)", "5");
            var v = ov.swizzle.yxzy;
            Assert.That("(76)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("(76)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(14)", "2", "null");
            var v = ov.swizzle.yxzz;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(14)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-17)4)", "(3-5)", "((-11)-5)");
            var v = ov.swizzle.yy;
            Assert.That("(3-5)", Is.EqualTo(v.x));
            Assert.That("(3-5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("-4", "", "(34)");
            var v = ov.swizzle.yyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-4", "9", "(-8-8)");
            var v = ov.swizzle.yyxx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(70)", "((9-7)-4)", "((11)-6)");
            var v = ov.swizzle.yyxy;
            Assert.That("((9-7)-4)", Is.EqualTo(v.x));
            Assert.That("((9-7)-4)", Is.EqualTo(v.y));
            Assert.That("(70)", Is.EqualTo(v.z));
            Assert.That("((9-7)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "-4", "(27)");
            var v = ov.swizzle.yyxz;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(27)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "null", "4");
            var v = ov.swizzle.yyy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(1-1)", "null", "(36)");
            var v = ov.swizzle.yyyx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(1-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "(42)", "((-6-8)1)");
            var v = ov.swizzle.yyyy;
            Assert.That("(42)", Is.EqualTo(v.x));
            Assert.That("(42)", Is.EqualTo(v.y));
            Assert.That("(42)", Is.EqualTo(v.z));
            Assert.That("(42)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "(-7-4)", "3");
            var v = ov.swizzle.yyyz;
            Assert.That("(-7-4)", Is.EqualTo(v.x));
            Assert.That("(-7-4)", Is.EqualTo(v.y));
            Assert.That("(-7-4)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((4-2)-4)", "((4-2)-4)", "((7-1)-8)");
            var v = ov.swizzle.yyz;
            Assert.That("((4-2)-4)", Is.EqualTo(v.x));
            Assert.That("((4-2)-4)", Is.EqualTo(v.y));
            Assert.That("((7-1)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-65)", "((7-9)-5)", "((7-9)-5)");
            var v = ov.swizzle.yyzx;
            Assert.That("((7-9)-5)", Is.EqualTo(v.x));
            Assert.That("((7-9)-5)", Is.EqualTo(v.y));
            Assert.That("((7-9)-5)", Is.EqualTo(v.z));
            Assert.That("(-65)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-2", "(26)", "-6");
            var v = ov.swizzle.yyzy;
            Assert.That("(26)", Is.EqualTo(v.x));
            Assert.That("(26)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("(26)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-3-7)", "null", "((1-7)-3)");
            var v = ov.swizzle.yyzz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((1-7)-3)", Is.EqualTo(v.z));
            Assert.That("((1-7)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((5-6)-2)", "", "3");
            var v = ov.swizzle.yz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("1", "(-55)", "((-7-6)1)");
            var v = ov.swizzle.yzx;
            Assert.That("(-55)", Is.EqualTo(v.x));
            Assert.That("((-7-6)1)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-76)", "(77)", "3");
            var v = ov.swizzle.yzxx;
            Assert.That("(77)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(-76)", Is.EqualTo(v.z));
            Assert.That("(-76)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(75)", "((8-8)-1)", "(75)");
            var v = ov.swizzle.yzxy;
            Assert.That("((8-8)-1)", Is.EqualTo(v.x));
            Assert.That("(75)", Is.EqualTo(v.y));
            Assert.That("(75)", Is.EqualTo(v.z));
            Assert.That("((8-8)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "", "(-32)");
            var v = ov.swizzle.yzxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-32)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-32)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "((7-6)0)", "((0-3)2)");
            var v = ov.swizzle.yzy;
            Assert.That("((7-6)0)", Is.EqualTo(v.x));
            Assert.That("((0-3)2)", Is.EqualTo(v.y));
            Assert.That("((7-6)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-1-8)-6)", "6", "6");
            var v = ov.swizzle.yzyx;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("((-1-8)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(96)", "((-51)-3)", "-8");
            var v = ov.swizzle.yzyy;
            Assert.That("((-51)-3)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("((-51)-3)", Is.EqualTo(v.z));
            Assert.That("((-51)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-33)", "", "((-56)-9)");
            var v = ov.swizzle.yzyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-56)-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-56)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-98)", "null", "((-42)1)");
            var v = ov.swizzle.yzz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-42)1)", Is.EqualTo(v.y));
            Assert.That("((-42)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(4-5)", "(4-5)", "((24)-1)");
            var v = ov.swizzle.yzzx;
            Assert.That("(4-5)", Is.EqualTo(v.x));
            Assert.That("((24)-1)", Is.EqualTo(v.y));
            Assert.That("((24)-1)", Is.EqualTo(v.z));
            Assert.That("(4-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-3-7)-4)", "((-28)9)", "");
            var v = ov.swizzle.yzzy;
            Assert.That("((-28)9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-28)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((1-5)4)", "((9-7)-2)", "((9-7)-2)");
            var v = ov.swizzle.yzzz;
            Assert.That("((9-7)-2)", Is.EqualTo(v.x));
            Assert.That("((9-7)-2)", Is.EqualTo(v.y));
            Assert.That("((9-7)-2)", Is.EqualTo(v.z));
            Assert.That("((9-7)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(9-1)", "(65)", "-6");
            var v = ov.swizzle.zx;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("(9-1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("1", "((-73)2)", "(-18)");
            var v = ov.swizzle.zxx;
            Assert.That("(-18)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("9", "1", "((2-1)7)");
            var v = ov.swizzle.zxxx;
            Assert.That("((2-1)7)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-1-9)", "6", "6");
            var v = ov.swizzle.zxxy;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("(-1-9)", Is.EqualTo(v.y));
            Assert.That("(-1-9)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "-2", "((-80)-7)");
            var v = ov.swizzle.zxxz;
            Assert.That("((-80)-7)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("((-80)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((49)3)", "9", "((66)3)");
            var v = ov.swizzle.zxy;
            Assert.That("((66)3)", Is.EqualTo(v.x));
            Assert.That("((49)3)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-91)8)", "-7", "-7");
            var v = ov.swizzle.zxyx;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-91)8)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((-91)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "((-12)-9)", "-9");
            var v = ov.swizzle.zxyy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((-12)-9)", Is.EqualTo(v.z));
            Assert.That("((-12)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "null", "2");
            var v = ov.swizzle.zxyz;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-3-3)7)", "", "3");
            var v = ov.swizzle.zxz;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((-3-3)7)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-46)9)", "((-46)9)", "(-5-6)");
            var v = ov.swizzle.zxzx;
            Assert.That("(-5-6)", Is.EqualTo(v.x));
            Assert.That("((-46)9)", Is.EqualTo(v.y));
            Assert.That("(-5-6)", Is.EqualTo(v.z));
            Assert.That("((-46)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "((-1-1)-1)", "4");
            var v = ov.swizzle.zxzy;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("((-1-1)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "(8-9)", "((77)0)");
            var v = ov.swizzle.zxzz;
            Assert.That("((77)0)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("((77)0)", Is.EqualTo(v.z));
            Assert.That("((77)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "(-9-2)", "-6");
            var v = ov.swizzle.zy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("(-9-2)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(-63)", "(-33)", "(-33)");
            var v = ov.swizzle.zyx;
            Assert.That("(-33)", Is.EqualTo(v.x));
            Assert.That("(-33)", Is.EqualTo(v.y));
            Assert.That("(-63)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-3", "((-29)-8)", "((-25)-1)");
            var v = ov.swizzle.zyxx;
            Assert.That("((-25)-1)", Is.EqualTo(v.x));
            Assert.That("((-29)-8)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "-1", "((0-9)-4)");
            var v = ov.swizzle.zyxy;
            Assert.That("((0-9)-4)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-98)", "-3", "null");
            var v = ov.swizzle.zyxz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(-98)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", "1", "");
            var v = ov.swizzle.zyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "(-8-6)", "-4");
            var v = ov.swizzle.zyyx;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(-8-6)", Is.EqualTo(v.y));
            Assert.That("(-8-6)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "((0-9)-4)", "-8");
            var v = ov.swizzle.zyyy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((0-9)-4)", Is.EqualTo(v.y));
            Assert.That("((0-9)-4)", Is.EqualTo(v.z));
            Assert.That("((0-9)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "((2-7)1)", "((2-7)1)");
            var v = ov.swizzle.zyyz;
            Assert.That("((2-7)1)", Is.EqualTo(v.x));
            Assert.That("((2-7)1)", Is.EqualTo(v.y));
            Assert.That("((2-7)1)", Is.EqualTo(v.z));
            Assert.That("((2-7)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((11)3)", "(-26)", "((11)3)");
            var v = ov.swizzle.zyz;
            Assert.That("((11)3)", Is.EqualTo(v.x));
            Assert.That("(-26)", Is.EqualTo(v.y));
            Assert.That("((11)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-20)", "(18)", "null");
            var v = ov.swizzle.zyzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(18)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-20)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((4-1)3)", "((57)-1)", "((-4-8)0)");
            var v = ov.swizzle.zyzy;
            Assert.That("((-4-8)0)", Is.EqualTo(v.x));
            Assert.That("((57)-1)", Is.EqualTo(v.y));
            Assert.That("((-4-8)0)", Is.EqualTo(v.z));
            Assert.That("((57)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-4-4)", "-3", "-3");
            var v = ov.swizzle.zyzz;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((7-2)3)", "6", "6");
            var v = ov.swizzle.zz;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-21)3)", "3", "(-10)");
            var v = ov.swizzle.zzx;
            Assert.That("(-10)", Is.EqualTo(v.x));
            Assert.That("(-10)", Is.EqualTo(v.y));
            Assert.That("((-21)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-1-6)-1)", "(2-9)", "-1");
            var v = ov.swizzle.zzxx;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((-1-6)-1)", Is.EqualTo(v.z));
            Assert.That("((-1-6)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "-7", "(-8-3)");
            var v = ov.swizzle.zzxy;
            Assert.That("(-8-3)", Is.EqualTo(v.x));
            Assert.That("(-8-3)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "1", "1");
            var v = ov.swizzle.zzxz;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(57)", "(8-7)", "((-2-9)-7)");
            var v = ov.swizzle.zzy;
            Assert.That("((-2-9)-7)", Is.EqualTo(v.x));
            Assert.That("((-2-9)-7)", Is.EqualTo(v.y));
            Assert.That("(8-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((4-5)-9)", "(-6-3)", "1");
            var v = ov.swizzle.zzyx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("(-6-3)", Is.EqualTo(v.z));
            Assert.That("((4-5)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(07)", "null", "((-57)-7)");
            var v = ov.swizzle.zzyy;
            Assert.That("((-57)-7)", Is.EqualTo(v.x));
            Assert.That("((-57)-7)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "((7-8)-3)", "((54)-8)");
            var v = ov.swizzle.zzyz;
            Assert.That("((54)-8)", Is.EqualTo(v.x));
            Assert.That("((54)-8)", Is.EqualTo(v.y));
            Assert.That("((7-8)-3)", Is.EqualTo(v.z));
            Assert.That("((54)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "-4", "((-2-6)-7)");
            var v = ov.swizzle.zzz;
            Assert.That("((-2-6)-7)", Is.EqualTo(v.x));
            Assert.That("((-2-6)-7)", Is.EqualTo(v.y));
            Assert.That("((-2-6)-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-1", "2", "-1");
            var v = ov.swizzle.zzzx;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(-62)", "-9");
            var v = ov.swizzle.zzzy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("(-62)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", "-7", "(04)");
            var v = ov.swizzle.zzzz;
            Assert.That("(04)", Is.EqualTo(v.x));
            Assert.That("(04)", Is.EqualTo(v.y));
            Assert.That("(04)", Is.EqualTo(v.z));
            Assert.That("(04)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec3<string>("(-87)", "((-75)-9)", "(-8-2)");
            var v = ov.swizzle.rr;
            Assert.That("(-87)", Is.EqualTo(v.x));
            Assert.That("(-87)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("null", "null", "(06)");
            var v = ov.swizzle.rrr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("1", "(-22)", "((-55)7)");
            var v = ov.swizzle.rrrr;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-85)2)", "5", "((9-6)-3)");
            var v = ov.swizzle.rrrg;
            Assert.That("((-85)2)", Is.EqualTo(v.x));
            Assert.That("((-85)2)", Is.EqualTo(v.y));
            Assert.That("((-85)2)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(7-4)", "5", "0");
            var v = ov.swizzle.rrrb;
            Assert.That("(7-4)", Is.EqualTo(v.x));
            Assert.That("(7-4)", Is.EqualTo(v.y));
            Assert.That("(7-4)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-14)0)", "((-4-8)-7)");
            var v = ov.swizzle.rrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-14)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "(1-8)", "5");
            var v = ov.swizzle.rrgr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(1-8)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-9-4)", "((-12)9)", "(-9-4)");
            var v = ov.swizzle.rrgg;
            Assert.That("(-9-4)", Is.EqualTo(v.x));
            Assert.That("(-9-4)", Is.EqualTo(v.y));
            Assert.That("((-12)9)", Is.EqualTo(v.z));
            Assert.That("((-12)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "null", "null");
            var v = ov.swizzle.rrgb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "8", "(-18)");
            var v = ov.swizzle.rrb;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(-18)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "", "-1");
            var v = ov.swizzle.rrbr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-96)", "((-8-1)9)", "((-57)-5)");
            var v = ov.swizzle.rrbg;
            Assert.That("(-96)", Is.EqualTo(v.x));
            Assert.That("(-96)", Is.EqualTo(v.y));
            Assert.That("((-57)-5)", Is.EqualTo(v.z));
            Assert.That("((-8-1)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((90)3)", "-4", "((3-3)2)");
            var v = ov.swizzle.rrbb;
            Assert.That("((90)3)", Is.EqualTo(v.x));
            Assert.That("((90)3)", Is.EqualTo(v.y));
            Assert.That("((3-3)2)", Is.EqualTo(v.z));
            Assert.That("((3-3)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((9-6)8)", "(2-4)", "3");
            var v = ov.swizzle.rg;
            Assert.That("((9-6)8)", Is.EqualTo(v.x));
            Assert.That("(2-4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("-8", "(-14)", "((-3-2)8)");
            var v = ov.swizzle.rgr;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(-14)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-40)7)", "((-40)7)", "");
            var v = ov.swizzle.rgrr;
            Assert.That("((-40)7)", Is.EqualTo(v.x));
            Assert.That("((-40)7)", Is.EqualTo(v.y));
            Assert.That("((-40)7)", Is.EqualTo(v.z));
            Assert.That("((-40)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((34)-7)", "9", "9");
            var v = ov.swizzle.rgrg;
            Assert.That("((34)-7)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("((34)-7)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(2-5)", "7", "5");
            var v = ov.swizzle.rgrb;
            Assert.That("(2-5)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(2-5)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(49)", "-1", "(25)");
            var v = ov.swizzle.rgg;
            Assert.That("(49)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-1", "(-6-6)", "-4");
            var v = ov.swizzle.rggr;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("(-6-6)", Is.EqualTo(v.y));
            Assert.That("(-6-6)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(03)", "-4", "");
            var v = ov.swizzle.rggg;
            Assert.That("(03)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "-3", "-3");
            var v = ov.swizzle.rggb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-27)1)", "((-33)-9)", "6");
            var v = ov.swizzle.rgb;
            Assert.That("((-27)1)", Is.EqualTo(v.x));
            Assert.That("((-33)-9)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("1", "(88)", "1");
            var v = ov.swizzle.rgbr;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(88)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("5", "-3", "");
            var v = ov.swizzle.rgbg;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-5-3)", "((-17)0)", "((-17)0)");
            var v = ov.swizzle.rgbb;
            Assert.That("(-5-3)", Is.EqualTo(v.x));
            Assert.That("((-17)0)", Is.EqualTo(v.y));
            Assert.That("((-17)0)", Is.EqualTo(v.z));
            Assert.That("((-17)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-9-5)-3)", "(-42)", "");
            var v = ov.swizzle.rb;
            Assert.That("((-9-5)-3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((75)-8)", "(-77)", "null");
            var v = ov.swizzle.rbr;
            Assert.That("((75)-8)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((75)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "-6", "(-9-7)");
            var v = ov.swizzle.rbrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-9-7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "(-75)", "(-29)");
            var v = ov.swizzle.rbrg;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-29)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("(-75)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(64)", "(0-9)", "-1");
            var v = ov.swizzle.rbrb;
            Assert.That("(64)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(64)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-7-3)", "(-4-1)", "0");
            var v = ov.swizzle.rbg;
            Assert.That("(-7-3)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("(-4-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((78)6)", "((43)9)", "((43)9)");
            var v = ov.swizzle.rbgr;
            Assert.That("((78)6)", Is.EqualTo(v.x));
            Assert.That("((43)9)", Is.EqualTo(v.y));
            Assert.That("((43)9)", Is.EqualTo(v.z));
            Assert.That("((78)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-3-8)0)", "((9-3)-5)", "(75)");
            var v = ov.swizzle.rbgg;
            Assert.That("((-3-8)0)", Is.EqualTo(v.x));
            Assert.That("(75)", Is.EqualTo(v.y));
            Assert.That("((9-3)-5)", Is.EqualTo(v.z));
            Assert.That("((9-3)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(94)", "null", "-2");
            var v = ov.swizzle.rbgb;
            Assert.That("(94)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "4", "((49)9)");
            var v = ov.swizzle.rbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((49)9)", Is.EqualTo(v.y));
            Assert.That("((49)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "0", "((51)-7)");
            var v = ov.swizzle.rbbr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((51)-7)", Is.EqualTo(v.y));
            Assert.That("((51)-7)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-94)-1)", "7", "((-2-6)-8)");
            var v = ov.swizzle.rbbg;
            Assert.That("((-94)-1)", Is.EqualTo(v.x));
            Assert.That("((-2-6)-8)", Is.EqualTo(v.y));
            Assert.That("((-2-6)-8)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((80)0)", "(-7-9)", "(3-7)");
            var v = ov.swizzle.rbbb;
            Assert.That("((80)0)", Is.EqualTo(v.x));
            Assert.That("(3-7)", Is.EqualTo(v.y));
            Assert.That("(3-7)", Is.EqualTo(v.z));
            Assert.That("(3-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-65)", "", "(-4-3)");
            var v = ov.swizzle.gr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-65)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((99)9)", "", "");
            var v = ov.swizzle.grr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((99)9)", Is.EqualTo(v.y));
            Assert.That("((99)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-3-6)8)", "((-4-2)2)", "4");
            var v = ov.swizzle.grrr;
            Assert.That("((-4-2)2)", Is.EqualTo(v.x));
            Assert.That("((-3-6)8)", Is.EqualTo(v.y));
            Assert.That("((-3-6)8)", Is.EqualTo(v.z));
            Assert.That("((-3-6)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(26)", "((-4-9)-8)", "((-1-5)-7)");
            var v = ov.swizzle.grrg;
            Assert.That("((-4-9)-8)", Is.EqualTo(v.x));
            Assert.That("(26)", Is.EqualTo(v.y));
            Assert.That("(26)", Is.EqualTo(v.z));
            Assert.That("((-4-9)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "(-44)", "6");
            var v = ov.swizzle.grrb;
            Assert.That("(-44)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((85)9)", "(-46)", "((-25)0)");
            var v = ov.swizzle.grg;
            Assert.That("(-46)", Is.EqualTo(v.x));
            Assert.That("((85)9)", Is.EqualTo(v.y));
            Assert.That("(-46)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-7-3)-3)", "-8", "-4");
            var v = ov.swizzle.grgr;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((-7-3)-3)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("((-7-3)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(27)", "((-2-6)-1)", "(98)");
            var v = ov.swizzle.grgg;
            Assert.That("((-2-6)-1)", Is.EqualTo(v.x));
            Assert.That("(27)", Is.EqualTo(v.y));
            Assert.That("((-2-6)-1)", Is.EqualTo(v.z));
            Assert.That("((-2-6)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "2", "null");
            var v = ov.swizzle.grgb;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "(-36)", "null");
            var v = ov.swizzle.grb;
            Assert.That("(-36)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("6", "(-7-4)", "((-69)-2)");
            var v = ov.swizzle.grbr;
            Assert.That("(-7-4)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("((-69)-2)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "(-97)", "null");
            var v = ov.swizzle.grbg;
            Assert.That("(-97)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-97)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "((-1-4)-9)", "");
            var v = ov.swizzle.grbb;
            Assert.That("((-1-4)-9)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-65)", "(-10)", "((77)0)");
            var v = ov.swizzle.gg;
            Assert.That("(-10)", Is.EqualTo(v.x));
            Assert.That("(-10)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(-7-4)", "((3-6)-8)", "(99)");
            var v = ov.swizzle.ggr;
            Assert.That("((3-6)-8)", Is.EqualTo(v.x));
            Assert.That("((3-6)-8)", Is.EqualTo(v.y));
            Assert.That("(-7-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("8", "null", "(57)");
            var v = ov.swizzle.ggrr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "", "((-3-5)-2)");
            var v = ov.swizzle.ggrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-71)-3)", "((-75)3)", "4");
            var v = ov.swizzle.ggrb;
            Assert.That("((-75)3)", Is.EqualTo(v.x));
            Assert.That("((-75)3)", Is.EqualTo(v.y));
            Assert.That("((-71)-3)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(-8-7)", "-3");
            var v = ov.swizzle.ggg;
            Assert.That("(-8-7)", Is.EqualTo(v.x));
            Assert.That("(-8-7)", Is.EqualTo(v.y));
            Assert.That("(-8-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((91)3)", "(-6-4)", "(-7-4)");
            var v = ov.swizzle.gggr;
            Assert.That("(-6-4)", Is.EqualTo(v.x));
            Assert.That("(-6-4)", Is.EqualTo(v.y));
            Assert.That("(-6-4)", Is.EqualTo(v.z));
            Assert.That("((91)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "0", "((-5-2)1)");
            var v = ov.swizzle.gggg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-19)-9)", "(-42)", "null");
            var v = ov.swizzle.gggb;
            Assert.That("(-42)", Is.EqualTo(v.x));
            Assert.That("(-42)", Is.EqualTo(v.y));
            Assert.That("(-42)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((90)5)", "(2-9)", "((90)5)");
            var v = ov.swizzle.ggb;
            Assert.That("(2-9)", Is.EqualTo(v.x));
            Assert.That("(2-9)", Is.EqualTo(v.y));
            Assert.That("((90)5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-39)-6)", "-4", "((74)4)");
            var v = ov.swizzle.ggbr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((74)4)", Is.EqualTo(v.z));
            Assert.That("((-39)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-7-1)-5)", "((-74)3)", "((-74)3)");
            var v = ov.swizzle.ggbg;
            Assert.That("((-74)3)", Is.EqualTo(v.x));
            Assert.That("((-74)3)", Is.EqualTo(v.y));
            Assert.That("((-74)3)", Is.EqualTo(v.z));
            Assert.That("((-74)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "9", "(-9-9)");
            var v = ov.swizzle.ggbb;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("(-9-9)", Is.EqualTo(v.z));
            Assert.That("(-9-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((3-6)-5)", "((-51)-1)", "((-51)-1)");
            var v = ov.swizzle.gb;
            Assert.That("((-51)-1)", Is.EqualTo(v.x));
            Assert.That("((-51)-1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-17)-8)", "((-61)-6)", "(1-6)");
            var v = ov.swizzle.gbr;
            Assert.That("((-61)-6)", Is.EqualTo(v.x));
            Assert.That("(1-6)", Is.EqualTo(v.y));
            Assert.That("((-17)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-1-3)", "(-1-3)", "(72)");
            var v = ov.swizzle.gbrr;
            Assert.That("(-1-3)", Is.EqualTo(v.x));
            Assert.That("(72)", Is.EqualTo(v.y));
            Assert.That("(-1-3)", Is.EqualTo(v.z));
            Assert.That("(-1-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-59)", "((7-5)-1)", "null");
            var v = ov.swizzle.gbrg;
            Assert.That("((7-5)-1)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-59)", Is.EqualTo(v.z));
            Assert.That("((7-5)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "(3-5)", "(04)");
            var v = ov.swizzle.gbrb;
            Assert.That("(3-5)", Is.EqualTo(v.x));
            Assert.That("(04)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("(04)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "4", "4");
            var v = ov.swizzle.gbg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(33)", "(33)", "");
            var v = ov.swizzle.gbgr;
            Assert.That("(33)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(33)", Is.EqualTo(v.z));
            Assert.That("(33)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-8-9)", "-6", "((85)4)");
            var v = ov.swizzle.gbgg;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((85)4)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "(87)", "-3");
            var v = ov.swizzle.gbgb;
            Assert.That("(87)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(87)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-9-6)", "((-7-3)5)", "-5");
            var v = ov.swizzle.gbb;
            Assert.That("((-7-3)5)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-23)8)", "(6-2)", "null");
            var v = ov.swizzle.gbbr;
            Assert.That("(6-2)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-23)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(72)", "(4-7)", "(4-7)");
            var v = ov.swizzle.gbbg;
            Assert.That("(4-7)", Is.EqualTo(v.x));
            Assert.That("(4-7)", Is.EqualTo(v.y));
            Assert.That("(4-7)", Is.EqualTo(v.z));
            Assert.That("(4-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "null", "");
            var v = ov.swizzle.gbbb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-17)", "", "((-7-3)-2)");
            var v = ov.swizzle.br;
            Assert.That("((-7-3)-2)", Is.EqualTo(v.x));
            Assert.That("(-17)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("-1", "((48)9)", "");
            var v = ov.swizzle.brr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "(-54)", "(-54)");
            var v = ov.swizzle.brrr;
            Assert.That("(-54)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(-1-6)", "((4-7)3)");
            var v = ov.swizzle.brrg;
            Assert.That("((4-7)3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-1-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "(-24)", "5");
            var v = ov.swizzle.brrb;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "-3", "2");
            var v = ov.swizzle.brg;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("8", "-8", "(47)");
            var v = ov.swizzle.brgr;
            Assert.That("(47)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(1-2)", "-8", "0");
            var v = ov.swizzle.brgg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(1-2)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-64)9)", "(45)", "-5");
            var v = ov.swizzle.brgb;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("((-64)9)", Is.EqualTo(v.y));
            Assert.That("(45)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "((8-8)-6)", "((-4-8)-1)");
            var v = ov.swizzle.brb;
            Assert.That("((-4-8)-1)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((-4-8)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("4", "(-21)", "5");
            var v = ov.swizzle.brbr;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(0-6)", "(0-6)", "4");
            var v = ov.swizzle.brbg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("(0-6)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(0-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(78)", "(78)", "null");
            var v = ov.swizzle.brbb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(78)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(-9-4)", "");
            var v = ov.swizzle.bg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-9-4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(6-2)", "3", "((1-3)6)");
            var v = ov.swizzle.bgr;
            Assert.That("((1-3)6)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(6-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-9", "((08)-9)", "(8-1)");
            var v = ov.swizzle.bgrr;
            Assert.That("(8-1)", Is.EqualTo(v.x));
            Assert.That("((08)-9)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-9-5)", "((-4-5)-7)", "(9-4)");
            var v = ov.swizzle.bgrg;
            Assert.That("(9-4)", Is.EqualTo(v.x));
            Assert.That("((-4-5)-7)", Is.EqualTo(v.y));
            Assert.That("(-9-5)", Is.EqualTo(v.z));
            Assert.That("((-4-5)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-29)-6)", "null", "((54)-7)");
            var v = ov.swizzle.bgrb;
            Assert.That("((54)-7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-29)-6)", Is.EqualTo(v.z));
            Assert.That("((54)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-43)-7)", "", "-4");
            var v = ov.swizzle.bgg;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-3-7)", "null", "8");
            var v = ov.swizzle.bggr;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-3-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-4-3)", "((21)1)", "(-75)");
            var v = ov.swizzle.bggg;
            Assert.That("(-75)", Is.EqualTo(v.x));
            Assert.That("((21)1)", Is.EqualTo(v.y));
            Assert.That("((21)1)", Is.EqualTo(v.z));
            Assert.That("((21)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-8-3)2)", "((75)5)", "((-8-2)-6)");
            var v = ov.swizzle.bggb;
            Assert.That("((-8-2)-6)", Is.EqualTo(v.x));
            Assert.That("((75)5)", Is.EqualTo(v.y));
            Assert.That("((75)5)", Is.EqualTo(v.z));
            Assert.That("((-8-2)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "((-37)-3)", "4");
            var v = ov.swizzle.bgb;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((-37)-3)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-8-5)", "((-5-4)5)", "((-5-4)5)");
            var v = ov.swizzle.bgbr;
            Assert.That("((-5-4)5)", Is.EqualTo(v.x));
            Assert.That("((-5-4)5)", Is.EqualTo(v.y));
            Assert.That("((-5-4)5)", Is.EqualTo(v.z));
            Assert.That("(-8-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((9-7)-9)", "-5", "(45)");
            var v = ov.swizzle.bgbg;
            Assert.That("(45)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(45)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(33)", "", "-4");
            var v = ov.swizzle.bgbb;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-3-4)", "", "((73)-4)");
            var v = ov.swizzle.bb;
            Assert.That("((73)-4)", Is.EqualTo(v.x));
            Assert.That("((73)-4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("-6", "(2-4)", "");
            var v = ov.swizzle.bbr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("7", "(2-4)", "-3");
            var v = ov.swizzle.bbrr;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "((-37)8)", "");
            var v = ov.swizzle.bbrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-37)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-40)-6)", "5", "((-40)-6)");
            var v = ov.swizzle.bbrb;
            Assert.That("((-40)-6)", Is.EqualTo(v.x));
            Assert.That("((-40)-6)", Is.EqualTo(v.y));
            Assert.That("((-40)-6)", Is.EqualTo(v.z));
            Assert.That("((-40)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-15)-4)", "0");
            var v = ov.swizzle.bbg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((-15)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-4", "null", "");
            var v = ov.swizzle.bbgr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((5-1)-6)", "(6-9)", "(-8-7)");
            var v = ov.swizzle.bbgg;
            Assert.That("(-8-7)", Is.EqualTo(v.x));
            Assert.That("(-8-7)", Is.EqualTo(v.y));
            Assert.That("(6-9)", Is.EqualTo(v.z));
            Assert.That("(6-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "((-3-8)7)", "((-5-8)7)");
            var v = ov.swizzle.bbgb;
            Assert.That("((-5-8)7)", Is.EqualTo(v.x));
            Assert.That("((-5-8)7)", Is.EqualTo(v.y));
            Assert.That("((-3-8)7)", Is.EqualTo(v.z));
            Assert.That("((-5-8)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(4-6)", "-6", "-6");
            var v = ov.swizzle.bbb;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-9", "((98)3)", "((87)-1)");
            var v = ov.swizzle.bbbr;
            Assert.That("((87)-1)", Is.EqualTo(v.x));
            Assert.That("((87)-1)", Is.EqualTo(v.y));
            Assert.That("((87)-1)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((45)7)", "((31)-2)", "(63)");
            var v = ov.swizzle.bbbg;
            Assert.That("(63)", Is.EqualTo(v.x));
            Assert.That("(63)", Is.EqualTo(v.y));
            Assert.That("(63)", Is.EqualTo(v.z));
            Assert.That("((31)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(2-2)", "");
            var v = ov.swizzle.bbbb;
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
            var v0 = new gvec3<string>("(05)", "null", "((-4-5)-4)");
            var v1 = new gvec2<string>("-8", "((4-1)9)");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-8", Is.EqualTo(v0.x));
            Assert.That("((4-1)9)", Is.EqualTo(v0.y));
            Assert.That("((-4-5)-4)", Is.EqualTo(v0.z));
        
            Assert.That("(05)", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("(-25)", "5", "0");
            var v1 = new gvec2<string>("((6-3)1)", "7");
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((6-3)1)", Is.EqualTo(v0.x));
            Assert.That("5", Is.EqualTo(v0.y));
            Assert.That("7", Is.EqualTo(v0.z));
        
            Assert.That("(-25)", Is.EqualTo(v2.x));
            Assert.That("0", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("(-58)", "((2-2)6)", "(-92)");
            var v1 = new gvec2<string>("-9", "(-41)");
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-58)", Is.EqualTo(v0.x));
            Assert.That("-9", Is.EqualTo(v0.y));
            Assert.That("(-41)", Is.EqualTo(v0.z));
        
            Assert.That("((2-2)6)", Is.EqualTo(v2.x));
            Assert.That("(-92)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("-4", "-4", "null");
            var v1 = new gvec3<string>("((-4-5)-5)", "(67)", "((-74)-6)");
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-4-5)-5)", Is.EqualTo(v0.x));
            Assert.That("(67)", Is.EqualTo(v0.y));
            Assert.That("((-74)-6)", Is.EqualTo(v0.z));
        
            Assert.That("-4", Is.EqualTo(v2.x));
            Assert.That("-4", Is.EqualTo(v2.y));
            Assert.That("null", Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new gvec3<string>("3", "null", "(84)");
            var v1 = "((1-9)0)";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((1-9)0)", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("(84)", Is.EqualTo(v0.z));
        
            Assert.That("3", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec3<string>("(57)", "((3-7)-2)", "(-4-5)");
            var v1 = "((-88)6)";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(57)", Is.EqualTo(v0.x));
            Assert.That("((-88)6)", Is.EqualTo(v0.y));
            Assert.That("(-4-5)", Is.EqualTo(v0.z));
        
            Assert.That("((3-7)-2)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec3<string>("(-33)", "1", "((-71)9)");
            var v1 = new gvec2<string>("((14)9)", "7");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((14)9)", Is.EqualTo(v0.x));
            Assert.That("7", Is.EqualTo(v0.y));
            Assert.That("((-71)9)", Is.EqualTo(v0.z));
        
            Assert.That("(-33)", Is.EqualTo(v2.x));
            Assert.That("1", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("", "null", "1");
            var v1 = "(88)";
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("(88)", Is.EqualTo(v0.z));
        
            Assert.That("1", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec3<string>("", "(-70)", "((-9-5)-7)");
            var v1 = new gvec2<string>("", "null");
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("(-70)", Is.EqualTo(v0.y));
            Assert.That("null", Is.EqualTo(v0.z));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("((-9-5)-7)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("-9", "(2-2)", "(79)");
            var v1 = new gvec2<string>("null", "-5");
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-9", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("-5", Is.EqualTo(v0.z));
        
            Assert.That("(2-2)", Is.EqualTo(v2.x));
            Assert.That("(79)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("(-75)", "", "((7-8)0)");
            var v1 = new gvec3<string>("((-6-3)7)", "((-6-3)7)", "((-6-3)7)");
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-6-3)7)", Is.EqualTo(v0.x));
            Assert.That("((-6-3)7)", Is.EqualTo(v0.y));
            Assert.That("((-6-3)7)", Is.EqualTo(v0.z));
        
            Assert.That("(-75)", Is.EqualTo(v2.x));
            Assert.That("", Is.EqualTo(v2.y));
            Assert.That("((7-8)0)", Is.EqualTo(v2.z));
        }
    }

}
