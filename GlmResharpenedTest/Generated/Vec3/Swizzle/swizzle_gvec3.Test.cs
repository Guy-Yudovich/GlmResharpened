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
            var ov = new gvec3<string>("8", "((5-9)9)", "null");
            var v = ov.swizzle.xx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((7-5)-5)", "((46)-8)", "((46)-8)");
            var v = ov.swizzle.xxx;
            Assert.That("((7-5)-5)", Is.EqualTo(v.x));
            Assert.That("((7-5)-5)", Is.EqualTo(v.y));
            Assert.That("((7-5)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((37)-9)", "4", "(9-8)");
            var v = ov.swizzle.xxxx;
            Assert.That("((37)-9)", Is.EqualTo(v.x));
            Assert.That("((37)-9)", Is.EqualTo(v.y));
            Assert.That("((37)-9)", Is.EqualTo(v.z));
            Assert.That("((37)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(14)", "null", "6");
            var v = ov.swizzle.xxxy;
            Assert.That("(14)", Is.EqualTo(v.x));
            Assert.That("(14)", Is.EqualTo(v.y));
            Assert.That("(14)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "-9", "(-95)");
            var v = ov.swizzle.xxxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-95)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "-4", "(9-2)");
            var v = ov.swizzle.xxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("1", "-2", "1");
            var v = ov.swizzle.xxyx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((9-9)-8)", "(-9-2)", "null");
            var v = ov.swizzle.xxyy;
            Assert.That("((9-9)-8)", Is.EqualTo(v.x));
            Assert.That("((9-9)-8)", Is.EqualTo(v.y));
            Assert.That("(-9-2)", Is.EqualTo(v.z));
            Assert.That("(-9-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-84)", "null", "((-5-9)-3)");
            var v = ov.swizzle.xxyz;
            Assert.That("(-84)", Is.EqualTo(v.x));
            Assert.That("(-84)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-5-9)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-7-5)", "(-7-5)", "null");
            var v = ov.swizzle.xxz;
            Assert.That("(-7-5)", Is.EqualTo(v.x));
            Assert.That("(-7-5)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((05)2)", "-2", "null");
            var v = ov.swizzle.xxzx;
            Assert.That("((05)2)", Is.EqualTo(v.x));
            Assert.That("((05)2)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((05)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "", "");
            var v = ov.swizzle.xxzy;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-5", "-7", "");
            var v = ov.swizzle.xxzz;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "1", "((24)5)");
            var v = ov.swizzle.xy;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("-9", "((55)-9)", "((55)-9)");
            var v = ov.swizzle.xyx;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((55)-9)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((9-9)-3)", "-3", "-3");
            var v = ov.swizzle.xyxx;
            Assert.That("((9-9)-3)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("((9-9)-3)", Is.EqualTo(v.z));
            Assert.That("((9-9)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-2-7)1)", "((-77)3)", "");
            var v = ov.swizzle.xyxy;
            Assert.That("((-2-7)1)", Is.EqualTo(v.x));
            Assert.That("((-77)3)", Is.EqualTo(v.y));
            Assert.That("((-2-7)1)", Is.EqualTo(v.z));
            Assert.That("((-77)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((9-2)4)", "null");
            var v = ov.swizzle.xyxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((9-2)4)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-9", "((-44)9)", "8");
            var v = ov.swizzle.xyy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((-44)9)", Is.EqualTo(v.y));
            Assert.That("((-44)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(7-6)", "", "(-85)");
            var v = ov.swizzle.xyyx;
            Assert.That("(7-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(7-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-4-4)-9)", "((-4-4)-9)", "((-3-3)5)");
            var v = ov.swizzle.xyyy;
            Assert.That("((-4-4)-9)", Is.EqualTo(v.x));
            Assert.That("((-4-4)-9)", Is.EqualTo(v.y));
            Assert.That("((-4-4)-9)", Is.EqualTo(v.z));
            Assert.That("((-4-4)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-2-7)", "((-6-7)-9)", "7");
            var v = ov.swizzle.xyyz;
            Assert.That("(-2-7)", Is.EqualTo(v.x));
            Assert.That("((-6-7)-9)", Is.EqualTo(v.y));
            Assert.That("((-6-7)-9)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(85)", "(6-2)", "9");
            var v = ov.swizzle.xyz;
            Assert.That("(85)", Is.EqualTo(v.x));
            Assert.That("(6-2)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "", "8");
            var v = ov.swizzle.xyzx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-5-4)-4)", "(-8-2)", "((-40)-2)");
            var v = ov.swizzle.xyzy;
            Assert.That("((-5-4)-4)", Is.EqualTo(v.x));
            Assert.That("(-8-2)", Is.EqualTo(v.y));
            Assert.That("((-40)-2)", Is.EqualTo(v.z));
            Assert.That("(-8-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((50)7)", "(-74)");
            var v = ov.swizzle.xyzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((50)7)", Is.EqualTo(v.y));
            Assert.That("(-74)", Is.EqualTo(v.z));
            Assert.That("(-74)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-1-5)", "(-1-5)", "((-7-7)-4)");
            var v = ov.swizzle.xz;
            Assert.That("(-1-5)", Is.EqualTo(v.x));
            Assert.That("((-7-7)-4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-45)3)", "((74)3)", "null");
            var v = ov.swizzle.xzx;
            Assert.That("((-45)3)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-45)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-8", "((-9-5)1)", "((-9-5)1)");
            var v = ov.swizzle.xzxx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((-9-5)1)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(0-5)", "(0-5)", "(-29)");
            var v = ov.swizzle.xzxy;
            Assert.That("(0-5)", Is.EqualTo(v.x));
            Assert.That("(-29)", Is.EqualTo(v.y));
            Assert.That("(0-5)", Is.EqualTo(v.z));
            Assert.That("(0-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((26)-5)", "(7-4)", "((93)-4)");
            var v = ov.swizzle.xzxz;
            Assert.That("((26)-5)", Is.EqualTo(v.x));
            Assert.That("((93)-4)", Is.EqualTo(v.y));
            Assert.That("((26)-5)", Is.EqualTo(v.z));
            Assert.That("((93)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "", "-3");
            var v = ov.swizzle.xzy;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(17)", "-9", "(19)");
            var v = ov.swizzle.xzyx;
            Assert.That("(17)", Is.EqualTo(v.x));
            Assert.That("(19)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("(17)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "(31)", "6");
            var v = ov.swizzle.xzyy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(31)", Is.EqualTo(v.z));
            Assert.That("(31)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("5", "5", "((2-8)-9)");
            var v = ov.swizzle.xzyz;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("((2-8)-9)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("((2-8)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "((39)-1)", "(-50)");
            var v = ov.swizzle.xzz;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(-50)", Is.EqualTo(v.y));
            Assert.That("(-50)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-5-7)-6)", "((-5-7)-6)", "-1");
            var v = ov.swizzle.xzzx;
            Assert.That("((-5-7)-6)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("((-5-7)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "", "null");
            var v = ov.swizzle.xzzy;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(-8-7)", "-6");
            var v = ov.swizzle.xzzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(56)", "null", "((54)-5)");
            var v = ov.swizzle.yx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(56)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(90)", "(96)", "((0-2)-7)");
            var v = ov.swizzle.yxx;
            Assert.That("(96)", Is.EqualTo(v.x));
            Assert.That("(90)", Is.EqualTo(v.y));
            Assert.That("(90)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-71)-6)", "2", "-5");
            var v = ov.swizzle.yxxx;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("((-71)-6)", Is.EqualTo(v.y));
            Assert.That("((-71)-6)", Is.EqualTo(v.z));
            Assert.That("((-71)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "", "4");
            var v = ov.swizzle.yxxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(5-1)", "((-19)-5)", "-7");
            var v = ov.swizzle.yxxz;
            Assert.That("((-19)-5)", Is.EqualTo(v.x));
            Assert.That("(5-1)", Is.EqualTo(v.y));
            Assert.That("(5-1)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((2-1)6)", "((2-1)6)", "(1-1)");
            var v = ov.swizzle.yxy;
            Assert.That("((2-1)6)", Is.EqualTo(v.x));
            Assert.That("((2-1)6)", Is.EqualTo(v.y));
            Assert.That("((2-1)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-65)-7)", "3", "null");
            var v = ov.swizzle.yxyx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((-65)-7)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("((-65)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "", "((-8-8)2)");
            var v = ov.swizzle.yxyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-90)4)", "(-2-4)", "((-49)0)");
            var v = ov.swizzle.yxyz;
            Assert.That("(-2-4)", Is.EqualTo(v.x));
            Assert.That("((-90)4)", Is.EqualTo(v.y));
            Assert.That("(-2-4)", Is.EqualTo(v.z));
            Assert.That("((-49)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-3-2)3)", "(-4-9)");
            var v = ov.swizzle.yxz;
            Assert.That("((-3-2)3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-4-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(2-5)", "", "((-7-5)-7)");
            var v = ov.swizzle.yxzx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(2-5)", Is.EqualTo(v.y));
            Assert.That("((-7-5)-7)", Is.EqualTo(v.z));
            Assert.That("(2-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-9-2)-8)", "9", "null");
            var v = ov.swizzle.yxzy;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((-9-2)-8)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "4", "null");
            var v = ov.swizzle.yxzz;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-89)-7)", "((-89)-7)", "(-17)");
            var v = ov.swizzle.yy;
            Assert.That("((-89)-7)", Is.EqualTo(v.x));
            Assert.That("((-89)-7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-83)1)", "-2", "((-83)1)");
            var v = ov.swizzle.yyx;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((-83)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("2", "null", "null");
            var v = ov.swizzle.yyxx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "8", "null");
            var v = ov.swizzle.yyxy;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((2-4)-9)", "(3-9)", "");
            var v = ov.swizzle.yyxz;
            Assert.That("(3-9)", Is.EqualTo(v.x));
            Assert.That("(3-9)", Is.EqualTo(v.y));
            Assert.That("((2-4)-9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(71)", "null", "0");
            var v = ov.swizzle.yyy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "((-5-2)-7)", "(1-8)");
            var v = ov.swizzle.yyyx;
            Assert.That("((-5-2)-7)", Is.EqualTo(v.x));
            Assert.That("((-5-2)-7)", Is.EqualTo(v.y));
            Assert.That("((-5-2)-7)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "((50)-2)", "-2");
            var v = ov.swizzle.yyyy;
            Assert.That("((50)-2)", Is.EqualTo(v.x));
            Assert.That("((50)-2)", Is.EqualTo(v.y));
            Assert.That("((50)-2)", Is.EqualTo(v.z));
            Assert.That("((50)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", "2", "4");
            var v = ov.swizzle.yyyz;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-6-5)-9)", "-8", "(8-1)");
            var v = ov.swizzle.yyz;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(8-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "-7", "(7-1)");
            var v = ov.swizzle.yyzx;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(7-1)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "-7", "((71)-1)");
            var v = ov.swizzle.yyzy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((71)-1)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-58)-1)", "(0-5)", "((-58)-1)");
            var v = ov.swizzle.yyzz;
            Assert.That("(0-5)", Is.EqualTo(v.x));
            Assert.That("(0-5)", Is.EqualTo(v.y));
            Assert.That("((-58)-1)", Is.EqualTo(v.z));
            Assert.That("((-58)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", "((24)3)", "((-7-3)-3)");
            var v = ov.swizzle.yz;
            Assert.That("((24)3)", Is.EqualTo(v.x));
            Assert.That("((-7-3)-3)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-5-4)3)", "((-6-3)3)", "(9-1)");
            var v = ov.swizzle.yzx;
            Assert.That("((-6-3)3)", Is.EqualTo(v.x));
            Assert.That("(9-1)", Is.EqualTo(v.y));
            Assert.That("((-5-4)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-76)-1)", "-2", "((-22)1)");
            var v = ov.swizzle.yzxx;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((-22)1)", Is.EqualTo(v.y));
            Assert.That("((-76)-1)", Is.EqualTo(v.z));
            Assert.That("((-76)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-30)4)", "");
            var v = ov.swizzle.yzxy;
            Assert.That("((-30)4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-30)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(8-6)", "3", "");
            var v = ov.swizzle.yzxz;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(8-6)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", "((-9-7)2)", "");
            var v = ov.swizzle.yzy;
            Assert.That("((-9-7)2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-9-7)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "-8", "(-67)");
            var v = ov.swizzle.yzyx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(-67)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(70)", "(-4-1)", "1");
            var v = ov.swizzle.yzyy;
            Assert.That("(-4-1)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("(-4-1)", Is.EqualTo(v.z));
            Assert.That("(-4-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "(-31)", "null");
            var v = ov.swizzle.yzyz;
            Assert.That("(-31)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-31)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(15)", "", "");
            var v = ov.swizzle.yzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "7", "((0-5)9)");
            var v = ov.swizzle.yzzx;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((0-5)9)", Is.EqualTo(v.y));
            Assert.That("((0-5)9)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-7-8)9)", "((74)-1)", "((-7-8)9)");
            var v = ov.swizzle.yzzy;
            Assert.That("((74)-1)", Is.EqualTo(v.x));
            Assert.That("((-7-8)9)", Is.EqualTo(v.y));
            Assert.That("((-7-8)9)", Is.EqualTo(v.z));
            Assert.That("((74)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "", "");
            var v = ov.swizzle.yzzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-5-8)5)", "-5", "(2-2)");
            var v = ov.swizzle.zx;
            Assert.That("(2-2)", Is.EqualTo(v.x));
            Assert.That("((-5-8)5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(-20)", "", "-1");
            var v = ov.swizzle.zxx;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("(-20)", Is.EqualTo(v.y));
            Assert.That("(-20)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(6-8)", "((0-5)-6)", "((4-7)-2)");
            var v = ov.swizzle.zxxx;
            Assert.That("((4-7)-2)", Is.EqualTo(v.x));
            Assert.That("(6-8)", Is.EqualTo(v.y));
            Assert.That("(6-8)", Is.EqualTo(v.z));
            Assert.That("(6-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(33)", "", "(-31)");
            var v = ov.swizzle.zxxy;
            Assert.That("(-31)", Is.EqualTo(v.x));
            Assert.That("(33)", Is.EqualTo(v.y));
            Assert.That("(33)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-51)", "((55)-4)", "((55)-4)");
            var v = ov.swizzle.zxxz;
            Assert.That("((55)-4)", Is.EqualTo(v.x));
            Assert.That("(-51)", Is.EqualTo(v.y));
            Assert.That("(-51)", Is.EqualTo(v.z));
            Assert.That("((55)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((2-4)6)", "null");
            var v = ov.swizzle.zxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((2-4)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-9", "(55)", "(-6-3)");
            var v = ov.swizzle.zxyx;
            Assert.That("(-6-3)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("(55)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(5-1)", "6", "((-6-8)4)");
            var v = ov.swizzle.zxyy;
            Assert.That("((-6-8)4)", Is.EqualTo(v.x));
            Assert.That("(5-1)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-77)6)", "((6-3)-3)", "(33)");
            var v = ov.swizzle.zxyz;
            Assert.That("(33)", Is.EqualTo(v.x));
            Assert.That("((-77)6)", Is.EqualTo(v.y));
            Assert.That("((6-3)-3)", Is.EqualTo(v.z));
            Assert.That("(33)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((7-2)-2)", "-2", "((-45)-4)");
            var v = ov.swizzle.zxz;
            Assert.That("((-45)-4)", Is.EqualTo(v.x));
            Assert.That("((7-2)-2)", Is.EqualTo(v.y));
            Assert.That("((-45)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-7-7)-2)", "(19)", "null");
            var v = ov.swizzle.zxzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-7-7)-2)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-7-7)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-8-2)-5)", "null", "null");
            var v = ov.swizzle.zxzy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-8-2)-5)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "((09)7)", "((95)-8)");
            var v = ov.swizzle.zxzz;
            Assert.That("((95)-8)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((95)-8)", Is.EqualTo(v.z));
            Assert.That("((95)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((6-4)4)", "-9");
            var v = ov.swizzle.zy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((6-4)4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("null", "(-71)", "7");
            var v = ov.swizzle.zyx;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(-71)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-8", "-8", "((4-4)3)");
            var v = ov.swizzle.zyxx;
            Assert.That("((4-4)3)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(92)", "null", "null");
            var v = ov.swizzle.zyxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(92)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "(84)", "2");
            var v = ov.swizzle.zyxz;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(84)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-51)", "-7", "((0-7)-4)");
            var v = ov.swizzle.zyy;
            Assert.That("((0-7)-4)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "-7", "null");
            var v = ov.swizzle.zyyx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-16)3)", "-7", "(-24)");
            var v = ov.swizzle.zyyy;
            Assert.That("(-24)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-16)-3)", "((-5-6)4)", "((-16)-3)");
            var v = ov.swizzle.zyyz;
            Assert.That("((-16)-3)", Is.EqualTo(v.x));
            Assert.That("((-5-6)4)", Is.EqualTo(v.y));
            Assert.That("((-5-6)4)", Is.EqualTo(v.z));
            Assert.That("((-16)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "9", "((0-4)-7)");
            var v = ov.swizzle.zyz;
            Assert.That("((0-4)-7)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("((0-4)-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("2", "", "-3");
            var v = ov.swizzle.zyzx;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(6-1)", "(38)");
            var v = ov.swizzle.zyzy;
            Assert.That("(38)", Is.EqualTo(v.x));
            Assert.That("(6-1)", Is.EqualTo(v.y));
            Assert.That("(38)", Is.EqualTo(v.z));
            Assert.That("(6-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "(-7-3)", "-8");
            var v = ov.swizzle.zyzz;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(-7-3)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "(-85)", "");
            var v = ov.swizzle.zz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("8", "(-13)", "");
            var v = ov.swizzle.zzx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("1", "((14)-8)", "((14)-8)");
            var v = ov.swizzle.zzxx;
            Assert.That("((14)-8)", Is.EqualTo(v.x));
            Assert.That("((14)-8)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(14)", "((-25)-1)", "((-25)-1)");
            var v = ov.swizzle.zzxy;
            Assert.That("((-25)-1)", Is.EqualTo(v.x));
            Assert.That("((-25)-1)", Is.EqualTo(v.y));
            Assert.That("(14)", Is.EqualTo(v.z));
            Assert.That("((-25)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-77)-8)", "(-6-7)", "((-77)-8)");
            var v = ov.swizzle.zzxz;
            Assert.That("((-77)-8)", Is.EqualTo(v.x));
            Assert.That("((-77)-8)", Is.EqualTo(v.y));
            Assert.That("((-77)-8)", Is.EqualTo(v.z));
            Assert.That("((-77)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", "((91)-9)", "-7");
            var v = ov.swizzle.zzy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((91)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-1-1)", "7", "-6");
            var v = ov.swizzle.zzyx;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(-1-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-7-8)-5)", "null", "((92)0)");
            var v = ov.swizzle.zzyy;
            Assert.That("((92)0)", Is.EqualTo(v.x));
            Assert.That("((92)0)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((52)3)", "8", "((-8-3)2)");
            var v = ov.swizzle.zzyz;
            Assert.That("((-8-3)2)", Is.EqualTo(v.x));
            Assert.That("((-8-3)2)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((-8-3)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((2-6)4)", "(-78)", "((2-6)4)");
            var v = ov.swizzle.zzz;
            Assert.That("((2-6)4)", Is.EqualTo(v.x));
            Assert.That("((2-6)4)", Is.EqualTo(v.y));
            Assert.That("((2-6)4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-5", "-5", "((-10)-6)");
            var v = ov.swizzle.zzzx;
            Assert.That("((-10)-6)", Is.EqualTo(v.x));
            Assert.That("((-10)-6)", Is.EqualTo(v.y));
            Assert.That("((-10)-6)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(8-9)", "((26)-8)", "null");
            var v = ov.swizzle.zzzy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((26)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-1-8)2)", "((-57)3)", "");
            var v = ov.swizzle.zzzz;
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
            var ov = new gvec3<string>("-7", "-5", "-5");
            var v = ov.swizzle.rr;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "-2", "(-39)");
            var v = ov.swizzle.rrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-95)", "-8", "((5-9)9)");
            var v = ov.swizzle.rrrr;
            Assert.That("(-95)", Is.EqualTo(v.x));
            Assert.That("(-95)", Is.EqualTo(v.y));
            Assert.That("(-95)", Is.EqualTo(v.z));
            Assert.That("(-95)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-4-6)", "((27)5)", "(-4-6)");
            var v = ov.swizzle.rrrg;
            Assert.That("(-4-6)", Is.EqualTo(v.x));
            Assert.That("(-4-6)", Is.EqualTo(v.y));
            Assert.That("(-4-6)", Is.EqualTo(v.z));
            Assert.That("((27)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(8-1)", "((-54)5)", "null");
            var v = ov.swizzle.rrrb;
            Assert.That("(8-1)", Is.EqualTo(v.x));
            Assert.That("(8-1)", Is.EqualTo(v.y));
            Assert.That("(8-1)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", "((2-8)4)", "(8-6)");
            var v = ov.swizzle.rrg;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("((2-8)4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(0-6)", "(72)", "-9");
            var v = ov.swizzle.rrgr;
            Assert.That("(0-6)", Is.EqualTo(v.x));
            Assert.That("(0-6)", Is.EqualTo(v.y));
            Assert.That("(72)", Is.EqualTo(v.z));
            Assert.That("(0-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "-9", "((-32)4)");
            var v = ov.swizzle.rrgg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", "((-96)4)", "(1-5)");
            var v = ov.swizzle.rrgb;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((-96)4)", Is.EqualTo(v.z));
            Assert.That("(1-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(0-5)", "(0-3)", "((-22)2)");
            var v = ov.swizzle.rrb;
            Assert.That("(0-5)", Is.EqualTo(v.x));
            Assert.That("(0-5)", Is.EqualTo(v.y));
            Assert.That("((-22)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "((-1-9)3)", "null");
            var v = ov.swizzle.rrbr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "3", "(-14)");
            var v = ov.swizzle.rrbg;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(-14)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((0-8)8)", "");
            var v = ov.swizzle.rrbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "", "((-5-1)2)");
            var v = ov.swizzle.rg;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-85)-7)", "((-85)-7)", "2");
            var v = ov.swizzle.rgr;
            Assert.That("((-85)-7)", Is.EqualTo(v.x));
            Assert.That("((-85)-7)", Is.EqualTo(v.y));
            Assert.That("((-85)-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("8", "(-1-7)", "((7-4)-6)");
            var v = ov.swizzle.rgrr;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(-1-7)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "", "((59)0)");
            var v = ov.swizzle.rgrg;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", "(76)", "-2");
            var v = ov.swizzle.rgrb;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(76)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(6-7)", "(6-7)", "null");
            var v = ov.swizzle.rgg;
            Assert.That("(6-7)", Is.EqualTo(v.x));
            Assert.That("(6-7)", Is.EqualTo(v.y));
            Assert.That("(6-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-53)", "((-4-4)-5)", "4");
            var v = ov.swizzle.rggr;
            Assert.That("(-53)", Is.EqualTo(v.x));
            Assert.That("((-4-4)-5)", Is.EqualTo(v.y));
            Assert.That("((-4-4)-5)", Is.EqualTo(v.z));
            Assert.That("(-53)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((88)9)", "(8-9)", "(-30)");
            var v = ov.swizzle.rggg;
            Assert.That("((88)9)", Is.EqualTo(v.x));
            Assert.That("(8-9)", Is.EqualTo(v.y));
            Assert.That("(8-9)", Is.EqualTo(v.z));
            Assert.That("(8-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(6-9)", "(-89)", "(-89)");
            var v = ov.swizzle.rggb;
            Assert.That("(6-9)", Is.EqualTo(v.x));
            Assert.That("(-89)", Is.EqualTo(v.y));
            Assert.That("(-89)", Is.EqualTo(v.z));
            Assert.That("(-89)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(-32)", "(-5-4)");
            var v = ov.swizzle.rgb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-32)", Is.EqualTo(v.y));
            Assert.That("(-5-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((56)-5)", "null", "");
            var v = ov.swizzle.rgbr;
            Assert.That("((56)-5)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((56)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "((9-4)-1)", "-9");
            var v = ov.swizzle.rgbg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((9-4)-1)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("((9-4)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "4", "null");
            var v = ov.swizzle.rgbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-11)", "-8", "(-11)");
            var v = ov.swizzle.rb;
            Assert.That("(-11)", Is.EqualTo(v.x));
            Assert.That("(-11)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("3", "(0-6)", "((-2-8)8)");
            var v = ov.swizzle.rbr;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((-2-8)8)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-1-6)-9)", "", "");
            var v = ov.swizzle.rbrr;
            Assert.That("((-1-6)-9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-1-6)-9)", Is.EqualTo(v.z));
            Assert.That("((-1-6)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "(1-4)", "(1-4)");
            var v = ov.swizzle.rbrg;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(1-4)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("(1-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(7-8)", "7", "(7-8)");
            var v = ov.swizzle.rbrb;
            Assert.That("(7-8)", Is.EqualTo(v.x));
            Assert.That("(7-8)", Is.EqualTo(v.y));
            Assert.That("(7-8)", Is.EqualTo(v.z));
            Assert.That("(7-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((57)-7)", "8", "((-12)-5)");
            var v = ov.swizzle.rbg;
            Assert.That("((57)-7)", Is.EqualTo(v.x));
            Assert.That("((-12)-5)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(01)", "((6-4)-6)", "((00)4)");
            var v = ov.swizzle.rbgr;
            Assert.That("(01)", Is.EqualTo(v.x));
            Assert.That("((00)4)", Is.EqualTo(v.y));
            Assert.That("((6-4)-6)", Is.EqualTo(v.z));
            Assert.That("(01)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(96)", "(-44)", "-4");
            var v = ov.swizzle.rbgg;
            Assert.That("(96)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(-44)", Is.EqualTo(v.z));
            Assert.That("(-44)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((3-5)5)", "-6", "((17)-9)");
            var v = ov.swizzle.rbgb;
            Assert.That("((3-5)5)", Is.EqualTo(v.x));
            Assert.That("((17)-9)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((17)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-23)", "((44)6)", "(-23)");
            var v = ov.swizzle.rbb;
            Assert.That("(-23)", Is.EqualTo(v.x));
            Assert.That("(-23)", Is.EqualTo(v.y));
            Assert.That("(-23)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-15)-2)", "8", "8");
            var v = ov.swizzle.rbbr;
            Assert.That("((-15)-2)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((-15)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-74)5)", "-1", "1");
            var v = ov.swizzle.rbbg;
            Assert.That("((-74)5)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-2-7)-4)", "-9", "-9");
            var v = ov.swizzle.rbbb;
            Assert.That("((-2-7)-4)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((89)0)", "", "9");
            var v = ov.swizzle.gr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((89)0)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-20)-5)", "(8-2)", "-3");
            var v = ov.swizzle.grr;
            Assert.That("(8-2)", Is.EqualTo(v.x));
            Assert.That("((-20)-5)", Is.EqualTo(v.y));
            Assert.That("((-20)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "(-59)", "1");
            var v = ov.swizzle.grrr;
            Assert.That("(-59)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-9-6)0)", "(4-8)", "(-63)");
            var v = ov.swizzle.grrg;
            Assert.That("(4-8)", Is.EqualTo(v.x));
            Assert.That("((-9-6)0)", Is.EqualTo(v.y));
            Assert.That("((-9-6)0)", Is.EqualTo(v.z));
            Assert.That("(4-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-14)", "(61)", "(-14)");
            var v = ov.swizzle.grrb;
            Assert.That("(61)", Is.EqualTo(v.x));
            Assert.That("(-14)", Is.EqualTo(v.y));
            Assert.That("(-14)", Is.EqualTo(v.z));
            Assert.That("(-14)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-1-5)", "(77)", "3");
            var v = ov.swizzle.grg;
            Assert.That("(77)", Is.EqualTo(v.x));
            Assert.That("(-1-5)", Is.EqualTo(v.y));
            Assert.That("(77)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-1", "(5-9)", "(32)");
            var v = ov.swizzle.grgr;
            Assert.That("(5-9)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(5-9)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-2", "-6", "-6");
            var v = ov.swizzle.grgg;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "9", "null");
            var v = ov.swizzle.grgb;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "null", "(-5-9)");
            var v = ov.swizzle.grb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(-5-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-8-5)", "2", "2");
            var v = ov.swizzle.grbr;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-8-5)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("(-8-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-17)0)", "((25)4)");
            var v = ov.swizzle.grbg;
            Assert.That("((-17)0)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((25)4)", Is.EqualTo(v.z));
            Assert.That("((-17)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((84)-3)", "9", "(0-3)");
            var v = ov.swizzle.grbb;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((84)-3)", Is.EqualTo(v.y));
            Assert.That("(0-3)", Is.EqualTo(v.z));
            Assert.That("(0-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-9-4)", "((-1-4)-6)", "null");
            var v = ov.swizzle.gg;
            Assert.That("((-1-4)-6)", Is.EqualTo(v.x));
            Assert.That("((-1-4)-6)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-7-4)8)", "null", "-4");
            var v = ov.swizzle.ggr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-7-4)8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "((2-6)-6)", "-7");
            var v = ov.swizzle.ggrr;
            Assert.That("((2-6)-6)", Is.EqualTo(v.x));
            Assert.That("((2-6)-6)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "", "null");
            var v = ov.swizzle.ggrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((99)7)", "9", "(-8-1)");
            var v = ov.swizzle.ggrb;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("((99)7)", Is.EqualTo(v.z));
            Assert.That("(-8-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-5-8)", "(26)", "-4");
            var v = ov.swizzle.ggg;
            Assert.That("(26)", Is.EqualTo(v.x));
            Assert.That("(26)", Is.EqualTo(v.y));
            Assert.That("(26)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-98)", "(-98)", "(-98)");
            var v = ov.swizzle.gggr;
            Assert.That("(-98)", Is.EqualTo(v.x));
            Assert.That("(-98)", Is.EqualTo(v.y));
            Assert.That("(-98)", Is.EqualTo(v.z));
            Assert.That("(-98)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(8-3)", "(08)", "((7-8)9)");
            var v = ov.swizzle.gggg;
            Assert.That("(08)", Is.EqualTo(v.x));
            Assert.That("(08)", Is.EqualTo(v.y));
            Assert.That("(08)", Is.EqualTo(v.z));
            Assert.That("(08)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "((97)-7)", "");
            var v = ov.swizzle.gggb;
            Assert.That("((97)-7)", Is.EqualTo(v.x));
            Assert.That("((97)-7)", Is.EqualTo(v.y));
            Assert.That("((97)-7)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "(0-8)", "((4-8)9)");
            var v = ov.swizzle.ggb;
            Assert.That("(0-8)", Is.EqualTo(v.x));
            Assert.That("(0-8)", Is.EqualTo(v.y));
            Assert.That("((4-8)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-3-2)", "(-15)", "((9-5)-9)");
            var v = ov.swizzle.ggbr;
            Assert.That("(-15)", Is.EqualTo(v.x));
            Assert.That("(-15)", Is.EqualTo(v.y));
            Assert.That("((9-5)-9)", Is.EqualTo(v.z));
            Assert.That("(-3-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "-1", "4");
            var v = ov.swizzle.ggbg;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-2-5)", "(-2-5)", "(-2-5)");
            var v = ov.swizzle.ggbb;
            Assert.That("(-2-5)", Is.EqualTo(v.x));
            Assert.That("(-2-5)", Is.EqualTo(v.y));
            Assert.That("(-2-5)", Is.EqualTo(v.z));
            Assert.That("(-2-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "-9", "((5-3)1)");
            var v = ov.swizzle.gb;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((5-3)1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("0", "", "(2-9)");
            var v = ov.swizzle.gbr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(2-9)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(4-7)", "-9", "");
            var v = ov.swizzle.gbrr;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(4-7)", Is.EqualTo(v.z));
            Assert.That("(4-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "-9", "-9");
            var v = ov.swizzle.gbrg;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-10)3)", "1", "");
            var v = ov.swizzle.gbrb;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-10)3)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((53)9)", "(5-3)", "(-9-9)");
            var v = ov.swizzle.gbg;
            Assert.That("(5-3)", Is.EqualTo(v.x));
            Assert.That("(-9-9)", Is.EqualTo(v.y));
            Assert.That("(5-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((21)3)", "((10)-9)", "((21)3)");
            var v = ov.swizzle.gbgr;
            Assert.That("((10)-9)", Is.EqualTo(v.x));
            Assert.That("((21)3)", Is.EqualTo(v.y));
            Assert.That("((10)-9)", Is.EqualTo(v.z));
            Assert.That("((21)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(5-1)", "((51)5)", "-1");
            var v = ov.swizzle.gbgg;
            Assert.That("((51)5)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((51)5)", Is.EqualTo(v.z));
            Assert.That("((51)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-2-9)", "(-51)", "7");
            var v = ov.swizzle.gbgb;
            Assert.That("(-51)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(-51)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "(73)", "((3-4)-5)");
            var v = ov.swizzle.gbb;
            Assert.That("(73)", Is.EqualTo(v.x));
            Assert.That("((3-4)-5)", Is.EqualTo(v.y));
            Assert.That("((3-4)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-26)-2)", "((18)-6)", "5");
            var v = ov.swizzle.gbbr;
            Assert.That("((18)-6)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("((-26)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "null", "");
            var v = ov.swizzle.gbbg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-46)-5)", "2", "((3-2)1)");
            var v = ov.swizzle.gbbb;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("((3-2)1)", Is.EqualTo(v.y));
            Assert.That("((3-2)1)", Is.EqualTo(v.z));
            Assert.That("((3-2)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((2-4)5)", "-2", "null");
            var v = ov.swizzle.br;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((2-4)5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-27)-3)", "(0-2)", "(0-2)");
            var v = ov.swizzle.brr;
            Assert.That("(0-2)", Is.EqualTo(v.x));
            Assert.That("((-27)-3)", Is.EqualTo(v.y));
            Assert.That("((-27)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(88)", "0", "0");
            var v = ov.swizzle.brrr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(88)", Is.EqualTo(v.y));
            Assert.That("(88)", Is.EqualTo(v.z));
            Assert.That("(88)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "(6-9)", "(22)");
            var v = ov.swizzle.brrg;
            Assert.That("(22)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(6-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "(1-6)", "(1-6)");
            var v = ov.swizzle.brrb;
            Assert.That("(1-6)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(1-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-90)", "-6", "((-80)4)");
            var v = ov.swizzle.brg;
            Assert.That("((-80)4)", Is.EqualTo(v.x));
            Assert.That("(-90)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-70)", "((08)-6)", "");
            var v = ov.swizzle.brgr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-70)", Is.EqualTo(v.y));
            Assert.That("((08)-6)", Is.EqualTo(v.z));
            Assert.That("(-70)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((83)-9)", "((83)-9)", "((3-5)-6)");
            var v = ov.swizzle.brgg;
            Assert.That("((3-5)-6)", Is.EqualTo(v.x));
            Assert.That("((83)-9)", Is.EqualTo(v.y));
            Assert.That("((83)-9)", Is.EqualTo(v.z));
            Assert.That("((83)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(47)", "", "4");
            var v = ov.swizzle.brgb;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("(47)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "((25)-3)", "(-87)");
            var v = ov.swizzle.brb;
            Assert.That("(-87)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("(-87)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "(3-2)", "(3-2)");
            var v = ov.swizzle.brbr;
            Assert.That("(3-2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(3-2)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "null", "((2-4)-4)");
            var v = ov.swizzle.brbg;
            Assert.That("((2-4)-4)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("((2-4)-4)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-8-2)", "(-3-6)", "2");
            var v = ov.swizzle.brbb;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-8-2)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((13)4)", "", "null");
            var v = ov.swizzle.bg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "8", "((-3-2)4)");
            var v = ov.swizzle.bgr;
            Assert.That("((-3-2)4)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((9-9)-7)", "-4", "null");
            var v = ov.swizzle.bgrr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((9-9)-7)", Is.EqualTo(v.z));
            Assert.That("((9-9)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(1-7)", "((0-6)1)", "(4-7)");
            var v = ov.swizzle.bgrg;
            Assert.That("(4-7)", Is.EqualTo(v.x));
            Assert.That("((0-6)1)", Is.EqualTo(v.y));
            Assert.That("(1-7)", Is.EqualTo(v.z));
            Assert.That("((0-6)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "-8", "(74)");
            var v = ov.swizzle.bgrb;
            Assert.That("(74)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("(74)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-73)7)", "((-73)7)", "null");
            var v = ov.swizzle.bgg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-73)7)", Is.EqualTo(v.y));
            Assert.That("((-73)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-51)", "4", "4");
            var v = ov.swizzle.bggr;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(-51)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("5", "(0-3)", "((37)-4)");
            var v = ov.swizzle.bggg;
            Assert.That("((37)-4)", Is.EqualTo(v.x));
            Assert.That("(0-3)", Is.EqualTo(v.y));
            Assert.That("(0-3)", Is.EqualTo(v.z));
            Assert.That("(0-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-9-9)-5)", "((-9-9)-5)", "(-37)");
            var v = ov.swizzle.bggb;
            Assert.That("(-37)", Is.EqualTo(v.x));
            Assert.That("((-9-9)-5)", Is.EqualTo(v.y));
            Assert.That("((-9-9)-5)", Is.EqualTo(v.z));
            Assert.That("(-37)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "null", "((-4-7)0)");
            var v = ov.swizzle.bgb;
            Assert.That("((-4-7)0)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-4-7)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-5-8)6)", "((5-6)-7)", "(-16)");
            var v = ov.swizzle.bgbr;
            Assert.That("(-16)", Is.EqualTo(v.x));
            Assert.That("((5-6)-7)", Is.EqualTo(v.y));
            Assert.That("(-16)", Is.EqualTo(v.z));
            Assert.That("((-5-8)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "(9-8)", "-3");
            var v = ov.swizzle.bgbg;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(9-8)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(9-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "null", "((04)-8)");
            var v = ov.swizzle.bgbb;
            Assert.That("((04)-8)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((04)-8)", Is.EqualTo(v.z));
            Assert.That("((04)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-21)", "-2", "null");
            var v = ov.swizzle.bb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(-4-8)", "", "-7");
            var v = ov.swizzle.bbr;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(-4-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-2-1)", "((-19)-8)", "(50)");
            var v = ov.swizzle.bbrr;
            Assert.That("(50)", Is.EqualTo(v.x));
            Assert.That("(50)", Is.EqualTo(v.y));
            Assert.That("(-2-1)", Is.EqualTo(v.z));
            Assert.That("(-2-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-5", "", "(7-5)");
            var v = ov.swizzle.bbrg;
            Assert.That("(7-5)", Is.EqualTo(v.x));
            Assert.That("(7-5)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "(-6-9)", "(-6-9)");
            var v = ov.swizzle.bbrb;
            Assert.That("(-6-9)", Is.EqualTo(v.x));
            Assert.That("(-6-9)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("(-6-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(15)", "((-1-3)4)", "((-1-3)4)");
            var v = ov.swizzle.bbg;
            Assert.That("((-1-3)4)", Is.EqualTo(v.x));
            Assert.That("((-1-3)4)", Is.EqualTo(v.y));
            Assert.That("((-1-3)4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-5-8)", "(-87)", "-5");
            var v = ov.swizzle.bbgr;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(-87)", Is.EqualTo(v.z));
            Assert.That("(-5-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-2-2)2)", "null", "");
            var v = ov.swizzle.bbgg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((26)-2)", "-7", "null");
            var v = ov.swizzle.bbgb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "null", "((2-6)-3)");
            var v = ov.swizzle.bbb;
            Assert.That("((2-6)-3)", Is.EqualTo(v.x));
            Assert.That("((2-6)-3)", Is.EqualTo(v.y));
            Assert.That("((2-6)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("2", "(-37)", "2");
            var v = ov.swizzle.bbbr;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-7-6)2)", "", "");
            var v = ov.swizzle.bbbg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-44)-9)", "(7-6)", "-7");
            var v = ov.swizzle.bbbb;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec3<string>("", "(-68)", "(-68)");
            var v1 = new gvec2<string>("(-44)", "(-77)");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-44)", Is.EqualTo(v0.x));
            Assert.That("(-77)", Is.EqualTo(v0.y));
            Assert.That("(-68)", Is.EqualTo(v0.z));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("(-68)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("((-51)4)", "(-5-1)", "(-5-1)");
            var v1 = new gvec2<string>("((-23)0)", "((-4-5)4)");
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-23)0)", Is.EqualTo(v0.x));
            Assert.That("(-5-1)", Is.EqualTo(v0.y));
            Assert.That("((-4-5)4)", Is.EqualTo(v0.z));
        
            Assert.That("((-51)4)", Is.EqualTo(v2.x));
            Assert.That("(-5-1)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("(7-9)", "-7", "null");
            var v1 = new gvec2<string>("-2", "7");
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(7-9)", Is.EqualTo(v0.x));
            Assert.That("-2", Is.EqualTo(v0.y));
            Assert.That("7", Is.EqualTo(v0.z));
        
            Assert.That("-7", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("4", "((0-6)6)", "-8");
            var v1 = new gvec3<string>("(-59)", "((-8-7)-2)", "((-2-3)-9)");
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-59)", Is.EqualTo(v0.x));
            Assert.That("((-8-7)-2)", Is.EqualTo(v0.y));
            Assert.That("((-2-3)-9)", Is.EqualTo(v0.z));
        
            Assert.That("4", Is.EqualTo(v2.x));
            Assert.That("((0-6)6)", Is.EqualTo(v2.y));
            Assert.That("-8", Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new gvec3<string>("((-54)0)", "1", "((8-6)5)");
            var v1 = "null";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("1", Is.EqualTo(v0.y));
            Assert.That("((8-6)5)", Is.EqualTo(v0.z));
        
            Assert.That("((-54)0)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec3<string>("9", "((-4-6)1)", "");
            var v1 = "(-78)";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("9", Is.EqualTo(v0.x));
            Assert.That("(-78)", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
        
            Assert.That("((-4-6)1)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec3<string>("(-9-7)", "(-2-2)", "(-9-7)");
            var v1 = new gvec2<string>("(9-1)", "7");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(9-1)", Is.EqualTo(v0.x));
            Assert.That("7", Is.EqualTo(v0.y));
            Assert.That("(-9-7)", Is.EqualTo(v0.z));
        
            Assert.That("(-9-7)", Is.EqualTo(v2.x));
            Assert.That("(-2-2)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("-3", "", "");
            var v1 = "(-28)";
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-3", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("(-28)", Is.EqualTo(v0.z));
        
            Assert.That("", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec3<string>("((82)5)", "-5", "-4");
            var v1 = new gvec2<string>("(7-2)", "");
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(7-2)", Is.EqualTo(v0.x));
            Assert.That("-5", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
        
            Assert.That("((82)5)", Is.EqualTo(v2.x));
            Assert.That("-4", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("null", "((-8-4)3)", "((-7-3)-4)");
            var v1 = new gvec2<string>("1", "null");
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("1", Is.EqualTo(v0.y));
            Assert.That("null", Is.EqualTo(v0.z));
        
            Assert.That("((-8-4)3)", Is.EqualTo(v2.x));
            Assert.That("((-7-3)-4)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("(9-5)", "((6-6)-8)", "(9-5)");
            var v1 = new gvec3<string>("-5", "((-1-4)-9)", "(52)");
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-5", Is.EqualTo(v0.x));
            Assert.That("((-1-4)-9)", Is.EqualTo(v0.y));
            Assert.That("(52)", Is.EqualTo(v0.z));
        
            Assert.That("(9-5)", Is.EqualTo(v2.x));
            Assert.That("((6-6)-8)", Is.EqualTo(v2.y));
            Assert.That("(9-5)", Is.EqualTo(v2.z));
        }
    }

}
