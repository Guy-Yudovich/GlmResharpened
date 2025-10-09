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
            var ov = new gvec3<string>("((-99)1)", "-1", "null");
            var v = ov.swizzle.xx;
            Assert.That("((-99)1)", Is.EqualTo(v.x));
            Assert.That("((-99)1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(6-8)", "(74)", "-6");
            var v = ov.swizzle.xxx;
            Assert.That("(6-8)", Is.EqualTo(v.x));
            Assert.That("(6-8)", Is.EqualTo(v.y));
            Assert.That("(6-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "-3", "(32)");
            var v = ov.swizzle.xxxx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(1-2)", "(1-2)", "-3");
            var v = ov.swizzle.xxxy;
            Assert.That("(1-2)", Is.EqualTo(v.x));
            Assert.That("(1-2)", Is.EqualTo(v.y));
            Assert.That("(1-2)", Is.EqualTo(v.z));
            Assert.That("(1-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", "(0-2)", "");
            var v = ov.swizzle.xxxz;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((32)9)", "", "null");
            var v = ov.swizzle.xxy;
            Assert.That("((32)9)", Is.EqualTo(v.x));
            Assert.That("((32)9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(7-8)", "((96)1)", "null");
            var v = ov.swizzle.xxyx;
            Assert.That("(7-8)", Is.EqualTo(v.x));
            Assert.That("(7-8)", Is.EqualTo(v.y));
            Assert.That("((96)1)", Is.EqualTo(v.z));
            Assert.That("(7-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((7-6)7)", "((7-6)7)", "-8");
            var v = ov.swizzle.xxyy;
            Assert.That("((7-6)7)", Is.EqualTo(v.x));
            Assert.That("((7-6)7)", Is.EqualTo(v.y));
            Assert.That("((7-6)7)", Is.EqualTo(v.z));
            Assert.That("((7-6)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-9", "7", "(60)");
            var v = ov.swizzle.xxyz;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(60)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((46)2)", "(-9-8)", "(-2-2)");
            var v = ov.swizzle.xxz;
            Assert.That("((46)2)", Is.EqualTo(v.x));
            Assert.That("((46)2)", Is.EqualTo(v.y));
            Assert.That("(-2-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(7-9)", "-4", "-4");
            var v = ov.swizzle.xxzx;
            Assert.That("(7-9)", Is.EqualTo(v.x));
            Assert.That("(7-9)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(7-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-2-2)4)", "((39)-5)", "7");
            var v = ov.swizzle.xxzy;
            Assert.That("((-2-2)4)", Is.EqualTo(v.x));
            Assert.That("((-2-2)4)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((39)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((6-6)-1)", "2", "(-21)");
            var v = ov.swizzle.xxzz;
            Assert.That("((6-6)-1)", Is.EqualTo(v.x));
            Assert.That("((6-6)-1)", Is.EqualTo(v.y));
            Assert.That("(-21)", Is.EqualTo(v.z));
            Assert.That("(-21)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "(-15)", "(-15)");
            var v = ov.swizzle.xy;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("(-15)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("-3", "null", "-3");
            var v = ov.swizzle.xyx;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-9", "null", "-9");
            var v = ov.swizzle.xyxx;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(38)", "1", "((-18)-6)");
            var v = ov.swizzle.xyxy;
            Assert.That("(38)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("(38)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((3-1)0)", "((-4-4)0)", "(-35)");
            var v = ov.swizzle.xyxz;
            Assert.That("((3-1)0)", Is.EqualTo(v.x));
            Assert.That("((-4-4)0)", Is.EqualTo(v.y));
            Assert.That("((3-1)0)", Is.EqualTo(v.z));
            Assert.That("(-35)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(7-4)", "-2", "");
            var v = ov.swizzle.xyy;
            Assert.That("(7-4)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(55)", "-5", "((-60)3)");
            var v = ov.swizzle.xyyx;
            Assert.That("(55)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("(55)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-64)-8)", "null", "((-64)-8)");
            var v = ov.swizzle.xyyy;
            Assert.That("((-64)-8)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "(17)", "");
            var v = ov.swizzle.xyyz;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(17)", Is.EqualTo(v.y));
            Assert.That("(17)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "(-88)", "3");
            var v = ov.swizzle.xyz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(-88)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-57)-6)", "((-57)-6)", "(9-9)");
            var v = ov.swizzle.xyzx;
            Assert.That("((-57)-6)", Is.EqualTo(v.x));
            Assert.That("((-57)-6)", Is.EqualTo(v.y));
            Assert.That("(9-9)", Is.EqualTo(v.z));
            Assert.That("((-57)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "-8", "(-77)");
            var v = ov.swizzle.xyzy;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(-77)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-87)", "(-81)", "");
            var v = ov.swizzle.xyzz;
            Assert.That("(-87)", Is.EqualTo(v.x));
            Assert.That("(-81)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "", "9");
            var v = ov.swizzle.xz;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((7-1)-5)", "null", "");
            var v = ov.swizzle.xzx;
            Assert.That("((7-1)-5)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((7-1)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(9-3)", "null", "(9-3)");
            var v = ov.swizzle.xzxx;
            Assert.That("(9-3)", Is.EqualTo(v.x));
            Assert.That("(9-3)", Is.EqualTo(v.y));
            Assert.That("(9-3)", Is.EqualTo(v.z));
            Assert.That("(9-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-74)", "", "((-92)2)");
            var v = ov.swizzle.xzxy;
            Assert.That("(-74)", Is.EqualTo(v.x));
            Assert.That("((-92)2)", Is.EqualTo(v.y));
            Assert.That("(-74)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(4-3)", "(4-3)", "(-1-1)");
            var v = ov.swizzle.xzxz;
            Assert.That("(4-3)", Is.EqualTo(v.x));
            Assert.That("(-1-1)", Is.EqualTo(v.y));
            Assert.That("(4-3)", Is.EqualTo(v.z));
            Assert.That("(-1-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("0", "3", "");
            var v = ov.swizzle.xzy;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-5", "-3", "((2-9)-7)");
            var v = ov.swizzle.xzyx;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("((2-9)-7)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((20)6)", "-6", "-9");
            var v = ov.swizzle.xzyy;
            Assert.That("((20)6)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((17)1)", "((17)5)", "-2");
            var v = ov.swizzle.xzyz;
            Assert.That("((17)1)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((17)5)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "null", "((6-9)-5)");
            var v = ov.swizzle.xzz;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("((6-9)-5)", Is.EqualTo(v.y));
            Assert.That("((6-9)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(1-4)", "(48)", "7");
            var v = ov.swizzle.xzzx;
            Assert.That("(1-4)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(1-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "(2-7)", "(2-7)");
            var v = ov.swizzle.xzzy;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(2-7)", Is.EqualTo(v.y));
            Assert.That("(2-7)", Is.EqualTo(v.z));
            Assert.That("(2-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-3-3)2)", "-3", "(66)");
            var v = ov.swizzle.xzzz;
            Assert.That("((-3-3)2)", Is.EqualTo(v.x));
            Assert.That("(66)", Is.EqualTo(v.y));
            Assert.That("(66)", Is.EqualTo(v.z));
            Assert.That("(66)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-2-1)", "-1", "((77)-7)");
            var v = ov.swizzle.yx;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("(-2-1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "", "null");
            var v = ov.swizzle.yxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(7-5)", "((-10)8)", "");
            var v = ov.swizzle.yxxx;
            Assert.That("((-10)8)", Is.EqualTo(v.x));
            Assert.That("(7-5)", Is.EqualTo(v.y));
            Assert.That("(7-5)", Is.EqualTo(v.z));
            Assert.That("(7-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(6-6)", "(-42)", "(4-1)");
            var v = ov.swizzle.yxxy;
            Assert.That("(-42)", Is.EqualTo(v.x));
            Assert.That("(6-6)", Is.EqualTo(v.y));
            Assert.That("(6-6)", Is.EqualTo(v.z));
            Assert.That("(-42)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "((-37)9)", "((3-5)3)");
            var v = ov.swizzle.yxxz;
            Assert.That("((-37)9)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((3-5)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((90)1)", "((90)1)", "5");
            var v = ov.swizzle.yxy;
            Assert.That("((90)1)", Is.EqualTo(v.x));
            Assert.That("((90)1)", Is.EqualTo(v.y));
            Assert.That("((90)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((48)-9)", "", "((25)-8)");
            var v = ov.swizzle.yxyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((48)-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((48)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(-3-4)", "4");
            var v = ov.swizzle.yxyy;
            Assert.That("(-3-4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-3-4)", Is.EqualTo(v.z));
            Assert.That("(-3-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-5-7)", "(-1-5)", "-2");
            var v = ov.swizzle.yxyz;
            Assert.That("(-1-5)", Is.EqualTo(v.x));
            Assert.That("(-5-7)", Is.EqualTo(v.y));
            Assert.That("(-1-5)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-47)7)", "(03)", "(-4-6)");
            var v = ov.swizzle.yxz;
            Assert.That("(03)", Is.EqualTo(v.x));
            Assert.That("((-47)7)", Is.EqualTo(v.y));
            Assert.That("(-4-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(0-9)", "(-21)", "((-9-1)9)");
            var v = ov.swizzle.yxzx;
            Assert.That("(-21)", Is.EqualTo(v.x));
            Assert.That("(0-9)", Is.EqualTo(v.y));
            Assert.That("((-9-1)9)", Is.EqualTo(v.z));
            Assert.That("(0-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(11)", "", "null");
            var v = ov.swizzle.yxzy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(11)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", "", "(81)");
            var v = ov.swizzle.yxzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("(81)", Is.EqualTo(v.z));
            Assert.That("(81)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((4-6)4)", "((4-6)4)", "6");
            var v = ov.swizzle.yy;
            Assert.That("((4-6)4)", Is.EqualTo(v.x));
            Assert.That("((4-6)4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("3", "0", "((-7-4)-9)");
            var v = ov.swizzle.yyx;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-32)", "null", "9");
            var v = ov.swizzle.yyxx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-32)", Is.EqualTo(v.z));
            Assert.That("(-32)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-5-3)-7)", "3", "null");
            var v = ov.swizzle.yyxy;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((-5-3)-7)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-8-7)", "(-8-7)", "(9-5)");
            var v = ov.swizzle.yyxz;
            Assert.That("(-8-7)", Is.EqualTo(v.x));
            Assert.That("(-8-7)", Is.EqualTo(v.y));
            Assert.That("(-8-7)", Is.EqualTo(v.z));
            Assert.That("(9-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "", "9");
            var v = ov.swizzle.yyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "-7", "((-46)-1)");
            var v = ov.swizzle.yyyx;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-75)", "(-9-6)", "(-75)");
            var v = ov.swizzle.yyyy;
            Assert.That("(-9-6)", Is.EqualTo(v.x));
            Assert.That("(-9-6)", Is.EqualTo(v.y));
            Assert.That("(-9-6)", Is.EqualTo(v.z));
            Assert.That("(-9-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((3-1)-7)", "", "8");
            var v = ov.swizzle.yyyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", "", "-7");
            var v = ov.swizzle.yyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "1", "6");
            var v = ov.swizzle.yyzx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-3-8)6)", "-5", "((-3-8)6)");
            var v = ov.swizzle.yyzy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("((-3-8)6)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(7-1)", "(60)", "");
            var v = ov.swizzle.yyzz;
            Assert.That("(60)", Is.EqualTo(v.x));
            Assert.That("(60)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("0", "", "null");
            var v = ov.swizzle.yz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-3-4)-3)", "((-3-4)-3)", "((6-9)4)");
            var v = ov.swizzle.yzx;
            Assert.That("((-3-4)-3)", Is.EqualTo(v.x));
            Assert.That("((6-9)4)", Is.EqualTo(v.y));
            Assert.That("((-3-4)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-3-4)", "((51)8)", "-8");
            var v = ov.swizzle.yzxx;
            Assert.That("((51)8)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(-3-4)", Is.EqualTo(v.z));
            Assert.That("(-3-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "((49)-4)", "(-55)");
            var v = ov.swizzle.yzxy;
            Assert.That("((49)-4)", Is.EqualTo(v.x));
            Assert.That("(-55)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((49)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-2-8)5)", "(-58)", "(30)");
            var v = ov.swizzle.yzxz;
            Assert.That("(-58)", Is.EqualTo(v.x));
            Assert.That("(30)", Is.EqualTo(v.y));
            Assert.That("((-2-8)5)", Is.EqualTo(v.z));
            Assert.That("(30)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-4-8)-6)", "((-4-8)-6)", "((-4-8)-6)");
            var v = ov.swizzle.yzy;
            Assert.That("((-4-8)-6)", Is.EqualTo(v.x));
            Assert.That("((-4-8)-6)", Is.EqualTo(v.y));
            Assert.That("((-4-8)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("7", "null", "((71)-4)");
            var v = ov.swizzle.yzyx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((71)-4)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((2-4)-1)", "(-54)", "null");
            var v = ov.swizzle.yzyy;
            Assert.That("(-54)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-54)", Is.EqualTo(v.z));
            Assert.That("(-54)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "9", "-4");
            var v = ov.swizzle.yzyz;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(9-2)", "((-64)-7)", "(04)");
            var v = ov.swizzle.yzz;
            Assert.That("((-64)-7)", Is.EqualTo(v.x));
            Assert.That("(04)", Is.EqualTo(v.y));
            Assert.That("(04)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-74)-2)", "(-5-3)", "-9");
            var v = ov.swizzle.yzzx;
            Assert.That("(-5-3)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("((-74)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "((05)9)", "-8");
            var v = ov.swizzle.yzzy;
            Assert.That("((05)9)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("((05)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(7-2)", "4", "");
            var v = ov.swizzle.yzzz;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((23)-4)", "9", "-3");
            var v = ov.swizzle.zx;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("((23)-4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("-1", "(-9-6)", "null");
            var v = ov.swizzle.zxx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-83)4)", "(-12)", "((96)-6)");
            var v = ov.swizzle.zxxx;
            Assert.That("((96)-6)", Is.EqualTo(v.x));
            Assert.That("((-83)4)", Is.EqualTo(v.y));
            Assert.That("((-83)4)", Is.EqualTo(v.z));
            Assert.That("((-83)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-77)7)", "(64)", "-4");
            var v = ov.swizzle.zxxy;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("((-77)7)", Is.EqualTo(v.y));
            Assert.That("((-77)7)", Is.EqualTo(v.z));
            Assert.That("(64)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(3-8)", "((1-1)-1)", "1");
            var v = ov.swizzle.zxxz;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(3-8)", Is.EqualTo(v.y));
            Assert.That("(3-8)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-7-4)1)", "(80)", "");
            var v = ov.swizzle.zxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-7-4)1)", Is.EqualTo(v.y));
            Assert.That("(80)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-96)9)", "(39)", "0");
            var v = ov.swizzle.zxyx;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((-96)9)", Is.EqualTo(v.y));
            Assert.That("(39)", Is.EqualTo(v.z));
            Assert.That("((-96)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-1-9)6)", "-7");
            var v = ov.swizzle.zxyy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-1-9)6)", Is.EqualTo(v.z));
            Assert.That("((-1-9)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(9-6)", "(9-6)", "7");
            var v = ov.swizzle.zxyz;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(9-6)", Is.EqualTo(v.y));
            Assert.That("(9-6)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", "", "((-44)-7)");
            var v = ov.swizzle.zxz;
            Assert.That("((-44)-7)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("((-44)-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-5-4)", "null", "-3");
            var v = ov.swizzle.zxzx;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(-5-4)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(-5-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-89)", "((7-1)3)", "8");
            var v = ov.swizzle.zxzy;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(-89)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((7-1)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "-4", "-4");
            var v = ov.swizzle.zxzz;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", "((78)-8)", "(83)");
            var v = ov.swizzle.zy;
            Assert.That("(83)", Is.EqualTo(v.x));
            Assert.That("((78)-8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-76)-4)", "-2", "((76)8)");
            var v = ov.swizzle.zyx;
            Assert.That("((76)8)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((-76)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-84)-4)", "-4", "null");
            var v = ov.swizzle.zyxx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((-84)-4)", Is.EqualTo(v.z));
            Assert.That("((-84)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "null", "(5-6)");
            var v = ov.swizzle.zyxy;
            Assert.That("(5-6)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "7", "((-74)-4)");
            var v = ov.swizzle.zyxz;
            Assert.That("((-74)-4)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-74)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((89)-3)", "", "null");
            var v = ov.swizzle.zyy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(1-9)", "-4", "9");
            var v = ov.swizzle.zyyx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(1-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-2", "((4-4)-2)", "1");
            var v = ov.swizzle.zyyy;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((4-4)-2)", Is.EqualTo(v.y));
            Assert.That("((4-4)-2)", Is.EqualTo(v.z));
            Assert.That("((4-4)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((6-6)9)", "((-8-6)-2)", "null");
            var v = ov.swizzle.zyyz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-8-6)-2)", Is.EqualTo(v.y));
            Assert.That("((-8-6)-2)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(8-4)", "(-84)", "null");
            var v = ov.swizzle.zyz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-84)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "-5", "-2");
            var v = ov.swizzle.zyzx;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("0", "((-62)1)", "");
            var v = ov.swizzle.zyzy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-62)1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-62)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-48)-3)", "(8-2)", "-3");
            var v = ov.swizzle.zyzz;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(8-2)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-7-1)", "((59)9)", "(-7-1)");
            var v = ov.swizzle.zz;
            Assert.That("(-7-1)", Is.EqualTo(v.x));
            Assert.That("(-7-1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(-2-7)", "-6", "((27)-8)");
            var v = ov.swizzle.zzx;
            Assert.That("((27)-8)", Is.EqualTo(v.x));
            Assert.That("((27)-8)", Is.EqualTo(v.y));
            Assert.That("(-2-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-51)", "(1-7)", "((-33)2)");
            var v = ov.swizzle.zzxx;
            Assert.That("((-33)2)", Is.EqualTo(v.x));
            Assert.That("((-33)2)", Is.EqualTo(v.y));
            Assert.That("(-51)", Is.EqualTo(v.z));
            Assert.That("(-51)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("5", "null", "(9-6)");
            var v = ov.swizzle.zzxy;
            Assert.That("(9-6)", Is.EqualTo(v.x));
            Assert.That("(9-6)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((1-7)8)", "((1-7)8)", "((1-7)8)");
            var v = ov.swizzle.zzxz;
            Assert.That("((1-7)8)", Is.EqualTo(v.x));
            Assert.That("((1-7)8)", Is.EqualTo(v.y));
            Assert.That("((1-7)8)", Is.EqualTo(v.z));
            Assert.That("((1-7)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "null", "null");
            var v = ov.swizzle.zzy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(85)", "((09)6)", "");
            var v = ov.swizzle.zzyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((09)6)", Is.EqualTo(v.z));
            Assert.That("(85)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-7-4)-2)", "-8", "(-4-2)");
            var v = ov.swizzle.zzyy;
            Assert.That("(-4-2)", Is.EqualTo(v.x));
            Assert.That("(-4-2)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(2-9)", "-1", "-1");
            var v = ov.swizzle.zzyz;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", "(-6-1)", "(99)");
            var v = ov.swizzle.zzz;
            Assert.That("(99)", Is.EqualTo(v.x));
            Assert.That("(99)", Is.EqualTo(v.y));
            Assert.That("(99)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-6-3)", "-7", "9");
            var v = ov.swizzle.zzzx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("(-6-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-81)", "(-81)", "(85)");
            var v = ov.swizzle.zzzy;
            Assert.That("(85)", Is.EqualTo(v.x));
            Assert.That("(85)", Is.EqualTo(v.y));
            Assert.That("(85)", Is.EqualTo(v.z));
            Assert.That("(-81)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(27)", "-1", "(27)");
            var v = ov.swizzle.zzzz;
            Assert.That("(27)", Is.EqualTo(v.x));
            Assert.That("(27)", Is.EqualTo(v.y));
            Assert.That("(27)", Is.EqualTo(v.z));
            Assert.That("(27)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec3<string>("((7-3)-9)", "((-35)4)", "((-35)4)");
            var v = ov.swizzle.rr;
            Assert.That("((7-3)-9)", Is.EqualTo(v.x));
            Assert.That("((7-3)-9)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-7-5)-5)", "(-6-2)", "null");
            var v = ov.swizzle.rrr;
            Assert.That("((-7-5)-5)", Is.EqualTo(v.x));
            Assert.That("((-7-5)-5)", Is.EqualTo(v.y));
            Assert.That("((-7-5)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-7", "null", "((76)1)");
            var v = ov.swizzle.rrrr;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((38)6)", "null", "8");
            var v = ov.swizzle.rrrg;
            Assert.That("((38)6)", Is.EqualTo(v.x));
            Assert.That("((38)6)", Is.EqualTo(v.y));
            Assert.That("((38)6)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "((-44)-8)", "(8-7)");
            var v = ov.swizzle.rrrb;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(8-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "null", "((85)-9)");
            var v = ov.swizzle.rrg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "null", "");
            var v = ov.swizzle.rrgr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "(0-3)", "null");
            var v = ov.swizzle.rrgg;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(0-3)", Is.EqualTo(v.z));
            Assert.That("(0-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "", "");
            var v = ov.swizzle.rrgb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "", "1");
            var v = ov.swizzle.rrb;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-8", "((-3-2)8)", "(3-7)");
            var v = ov.swizzle.rrbr;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(3-7)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(60)", "(-88)", "(60)");
            var v = ov.swizzle.rrbg;
            Assert.That("(60)", Is.EqualTo(v.x));
            Assert.That("(60)", Is.EqualTo(v.y));
            Assert.That("(60)", Is.EqualTo(v.z));
            Assert.That("(-88)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((7-5)3)", "(7-8)", "((7-5)3)");
            var v = ov.swizzle.rrbb;
            Assert.That("((7-5)3)", Is.EqualTo(v.x));
            Assert.That("((7-5)3)", Is.EqualTo(v.y));
            Assert.That("((7-5)3)", Is.EqualTo(v.z));
            Assert.That("((7-5)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-72)1)", "(9-9)", "((1-3)6)");
            var v = ov.swizzle.rg;
            Assert.That("((-72)1)", Is.EqualTo(v.x));
            Assert.That("(9-9)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "", "((49)-2)");
            var v = ov.swizzle.rgr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-1-3)", "-3", "-3");
            var v = ov.swizzle.rgrr;
            Assert.That("(-1-3)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(-1-3)", Is.EqualTo(v.z));
            Assert.That("(-1-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("0", "(95)", "");
            var v = ov.swizzle.rgrg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(95)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("(95)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-3-9)", "((8-5)7)", "((8-5)7)");
            var v = ov.swizzle.rgrb;
            Assert.That("(-3-9)", Is.EqualTo(v.x));
            Assert.That("((8-5)7)", Is.EqualTo(v.y));
            Assert.That("(-3-9)", Is.EqualTo(v.z));
            Assert.That("((8-5)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "-3", "(-9-4)");
            var v = ov.swizzle.rgg;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-5-8)9)", "(-6-2)", "((79)2)");
            var v = ov.swizzle.rggr;
            Assert.That("((-5-8)9)", Is.EqualTo(v.x));
            Assert.That("(-6-2)", Is.EqualTo(v.y));
            Assert.That("(-6-2)", Is.EqualTo(v.z));
            Assert.That("((-5-8)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(13)", "(48)");
            var v = ov.swizzle.rggg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(13)", Is.EqualTo(v.y));
            Assert.That("(13)", Is.EqualTo(v.z));
            Assert.That("(13)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "(-33)", "((-52)3)");
            var v = ov.swizzle.rggb;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-33)", Is.EqualTo(v.y));
            Assert.That("(-33)", Is.EqualTo(v.z));
            Assert.That("((-52)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "((3-5)-8)", "(05)");
            var v = ov.swizzle.rgb;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((3-5)-8)", Is.EqualTo(v.y));
            Assert.That("(05)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("4", "((0-1)9)", "(-82)");
            var v = ov.swizzle.rgbr;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((0-1)9)", Is.EqualTo(v.y));
            Assert.That("(-82)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((61)1)", "((-43)4)", "");
            var v = ov.swizzle.rgbg;
            Assert.That("((61)1)", Is.EqualTo(v.x));
            Assert.That("((-43)4)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-43)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-8-7)-8)", "(-92)", "((-8-7)-8)");
            var v = ov.swizzle.rgbb;
            Assert.That("((-8-7)-8)", Is.EqualTo(v.x));
            Assert.That("(-92)", Is.EqualTo(v.y));
            Assert.That("((-8-7)-8)", Is.EqualTo(v.z));
            Assert.That("((-8-7)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", "null", "(77)");
            var v = ov.swizzle.rb;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(77)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "-5", "(-29)");
            var v = ov.swizzle.rbr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-29)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("5", "(-7-3)", "(-94)");
            var v = ov.swizzle.rbrr;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(-94)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "(7-8)", "-9");
            var v = ov.swizzle.rbrg;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("(7-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "", "((-6-8)-4)");
            var v = ov.swizzle.rbrb;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("((-6-8)-4)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("((-6-8)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("5", "((33)-6)", "null");
            var v = ov.swizzle.rbg;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((33)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-4", "null", "(-55)");
            var v = ov.swizzle.rbgr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(-55)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-5-5)", "((-5-4)6)", "0");
            var v = ov.swizzle.rbgg;
            Assert.That("(-5-5)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((-5-4)6)", Is.EqualTo(v.z));
            Assert.That("((-5-4)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-3-2)", "", "");
            var v = ov.swizzle.rbgb;
            Assert.That("(-3-2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "((94)-4)", "((-19)0)");
            var v = ov.swizzle.rbb;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((-19)0)", Is.EqualTo(v.y));
            Assert.That("((-19)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-5", "((0-4)5)", "null");
            var v = ov.swizzle.rbbr;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "-8", "5");
            var v = ov.swizzle.rbbg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(9-1)", "-7", "(9-1)");
            var v = ov.swizzle.rbbb;
            Assert.That("(9-1)", Is.EqualTo(v.x));
            Assert.That("(9-1)", Is.EqualTo(v.y));
            Assert.That("(9-1)", Is.EqualTo(v.z));
            Assert.That("(9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "-7", "-2");
            var v = ov.swizzle.gr;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("1", "7", "-7");
            var v = ov.swizzle.grr;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((58)0)", "-2", "(72)");
            var v = ov.swizzle.grrr;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((58)0)", Is.EqualTo(v.y));
            Assert.That("((58)0)", Is.EqualTo(v.z));
            Assert.That("((58)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "", "((60)8)");
            var v = ov.swizzle.grrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-5-2)-9)", "-7", "-1");
            var v = ov.swizzle.grrb;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-5-2)-9)", Is.EqualTo(v.y));
            Assert.That("((-5-2)-9)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(94)", "-3");
            var v = ov.swizzle.grg;
            Assert.That("(94)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(94)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((0-6)-9)", "7", "(-13)");
            var v = ov.swizzle.grgr;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((0-6)-9)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((0-6)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-2-8)", "((-9-6)-2)", "null");
            var v = ov.swizzle.grgg;
            Assert.That("((-9-6)-2)", Is.EqualTo(v.x));
            Assert.That("(-2-8)", Is.EqualTo(v.y));
            Assert.That("((-9-6)-2)", Is.EqualTo(v.z));
            Assert.That("((-9-6)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((4-7)5)", "0", "(-53)");
            var v = ov.swizzle.grgb;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((4-7)5)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("(-53)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "(87)", "((-7-6)3)");
            var v = ov.swizzle.grb;
            Assert.That("(87)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-7-6)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-64)-6)", "2", "(-43)");
            var v = ov.swizzle.grbr;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("((-64)-6)", Is.EqualTo(v.y));
            Assert.That("(-43)", Is.EqualTo(v.z));
            Assert.That("((-64)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "3", "(55)");
            var v = ov.swizzle.grbg;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(55)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "(1-1)", "((71)-2)");
            var v = ov.swizzle.grbb;
            Assert.That("(1-1)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((71)-2)", Is.EqualTo(v.z));
            Assert.That("((71)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "(-70)", "-6");
            var v = ov.swizzle.gg;
            Assert.That("(-70)", Is.EqualTo(v.x));
            Assert.That("(-70)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "", "((1-8)-9)");
            var v = ov.swizzle.ggr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "((38)6)", "7");
            var v = ov.swizzle.ggrr;
            Assert.That("((38)6)", Is.EqualTo(v.x));
            Assert.That("((38)6)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-2", "((-31)3)", "((-31)3)");
            var v = ov.swizzle.ggrg;
            Assert.That("((-31)3)", Is.EqualTo(v.x));
            Assert.That("((-31)3)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("((-31)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "(-7-8)", "-7");
            var v = ov.swizzle.ggrb;
            Assert.That("(-7-8)", Is.EqualTo(v.x));
            Assert.That("(-7-8)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-85)4)", "null", "(-99)");
            var v = ov.swizzle.ggg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-9-2)8)", "(91)", "(66)");
            var v = ov.swizzle.gggr;
            Assert.That("(91)", Is.EqualTo(v.x));
            Assert.That("(91)", Is.EqualTo(v.y));
            Assert.That("(91)", Is.EqualTo(v.z));
            Assert.That("((-9-2)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "null", "");
            var v = ov.swizzle.gggg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "2", "2");
            var v = ov.swizzle.gggb;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(92)", "(92)", "");
            var v = ov.swizzle.ggb;
            Assert.That("(92)", Is.EqualTo(v.x));
            Assert.That("(92)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-2-8)1)", "(93)", "(93)");
            var v = ov.swizzle.ggbr;
            Assert.That("(93)", Is.EqualTo(v.x));
            Assert.That("(93)", Is.EqualTo(v.y));
            Assert.That("(93)", Is.EqualTo(v.z));
            Assert.That("((-2-8)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(-3-8)", "0");
            var v = ov.swizzle.ggbg;
            Assert.That("(-3-8)", Is.EqualTo(v.x));
            Assert.That("(-3-8)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("(-3-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(45)", "(45)", "5");
            var v = ov.swizzle.ggbb;
            Assert.That("(45)", Is.EqualTo(v.x));
            Assert.That("(45)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "3", "((7-8)7)");
            var v = ov.swizzle.gb;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((7-8)7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(95)", "null", "null");
            var v = ov.swizzle.gbr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(95)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-63)1)", "(15)", "((-90)6)");
            var v = ov.swizzle.gbrr;
            Assert.That("(15)", Is.EqualTo(v.x));
            Assert.That("((-90)6)", Is.EqualTo(v.y));
            Assert.That("((-63)1)", Is.EqualTo(v.z));
            Assert.That("((-63)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-1-1)-2)", "7", "((32)-5)");
            var v = ov.swizzle.gbrg;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((32)-5)", Is.EqualTo(v.y));
            Assert.That("((-1-1)-2)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(8-1)", "((-4-2)-4)", "((-34)7)");
            var v = ov.swizzle.gbrb;
            Assert.That("((-4-2)-4)", Is.EqualTo(v.x));
            Assert.That("((-34)7)", Is.EqualTo(v.y));
            Assert.That("(8-1)", Is.EqualTo(v.z));
            Assert.That("((-34)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "(09)", "-9");
            var v = ov.swizzle.gbg;
            Assert.That("(09)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("(09)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-16)", "((-60)-6)", "(-16)");
            var v = ov.swizzle.gbgr;
            Assert.That("((-60)-6)", Is.EqualTo(v.x));
            Assert.That("(-16)", Is.EqualTo(v.y));
            Assert.That("((-60)-6)", Is.EqualTo(v.z));
            Assert.That("(-16)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "(-5-8)", "((85)-9)");
            var v = ov.swizzle.gbgg;
            Assert.That("(-5-8)", Is.EqualTo(v.x));
            Assert.That("((85)-9)", Is.EqualTo(v.y));
            Assert.That("(-5-8)", Is.EqualTo(v.z));
            Assert.That("(-5-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-85)-9)", "-3", "3");
            var v = ov.swizzle.gbgb;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-5-2)-5)", "null", "-8");
            var v = ov.swizzle.gbb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-91)1)", "9", "9");
            var v = ov.swizzle.gbbr;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("((-91)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((6-3)1)", "(-95)", "((-9-4)-4)");
            var v = ov.swizzle.gbbg;
            Assert.That("(-95)", Is.EqualTo(v.x));
            Assert.That("((-9-4)-4)", Is.EqualTo(v.y));
            Assert.That("((-9-4)-4)", Is.EqualTo(v.z));
            Assert.That("(-95)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "((-51)-6)", "(83)");
            var v = ov.swizzle.gbbb;
            Assert.That("((-51)-6)", Is.EqualTo(v.x));
            Assert.That("(83)", Is.EqualTo(v.y));
            Assert.That("(83)", Is.EqualTo(v.z));
            Assert.That("(83)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "6", "6");
            var v = ov.swizzle.br;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((31)-1)", "null", "(-8-5)");
            var v = ov.swizzle.brr;
            Assert.That("(-8-5)", Is.EqualTo(v.x));
            Assert.That("((31)-1)", Is.EqualTo(v.y));
            Assert.That("((31)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(4-1)", "1", "(4-1)");
            var v = ov.swizzle.brrr;
            Assert.That("(4-1)", Is.EqualTo(v.x));
            Assert.That("(4-1)", Is.EqualTo(v.y));
            Assert.That("(4-1)", Is.EqualTo(v.z));
            Assert.That("(4-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-64)-6)", "-1", "(-2-6)");
            var v = ov.swizzle.brrg;
            Assert.That("(-2-6)", Is.EqualTo(v.x));
            Assert.That("((-64)-6)", Is.EqualTo(v.y));
            Assert.That("((-64)-6)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-2", "(73)", "((2-4)4)");
            var v = ov.swizzle.brrb;
            Assert.That("((2-4)4)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("((2-4)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(9-8)", "((8-2)0)", "((-94)-5)");
            var v = ov.swizzle.brg;
            Assert.That("((-94)-5)", Is.EqualTo(v.x));
            Assert.That("(9-8)", Is.EqualTo(v.y));
            Assert.That("((8-2)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("6", "(7-4)", "(7-4)");
            var v = ov.swizzle.brgr;
            Assert.That("(7-4)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(7-4)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", "null", "((-6-1)0)");
            var v = ov.swizzle.brgg;
            Assert.That("((-6-1)0)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((8-7)9)", "", "0");
            var v = ov.swizzle.brgb;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((8-7)9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "null", "null");
            var v = ov.swizzle.brb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "((-3-6)-7)", "(6-1)");
            var v = ov.swizzle.brbr;
            Assert.That("(6-1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(6-1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", "9", "1");
            var v = ov.swizzle.brbg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((81)5)", "((81)5)", "null");
            var v = ov.swizzle.brbb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((81)5)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "", "5");
            var v = ov.swizzle.bg;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((21)0)", "((-40)1)", "-6");
            var v = ov.swizzle.bgr;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((-40)1)", Is.EqualTo(v.y));
            Assert.That("((21)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-7", "-8", "((63)5)");
            var v = ov.swizzle.bgrr;
            Assert.That("((63)5)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", "(-75)", "(-75)");
            var v = ov.swizzle.bgrg;
            Assert.That("(-75)", Is.EqualTo(v.x));
            Assert.That("(-75)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("(-75)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((00)1)", "((00)1)", "((-5-9)-7)");
            var v = ov.swizzle.bgrb;
            Assert.That("((-5-9)-7)", Is.EqualTo(v.x));
            Assert.That("((00)1)", Is.EqualTo(v.y));
            Assert.That("((00)1)", Is.EqualTo(v.z));
            Assert.That("((-5-9)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", "(9-3)", "((-10)5)");
            var v = ov.swizzle.bgg;
            Assert.That("((-10)5)", Is.EqualTo(v.x));
            Assert.That("(9-3)", Is.EqualTo(v.y));
            Assert.That("(9-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-21)1)", "(96)", "");
            var v = ov.swizzle.bggr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(96)", Is.EqualTo(v.y));
            Assert.That("(96)", Is.EqualTo(v.z));
            Assert.That("((-21)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-52)", "", "-4");
            var v = ov.swizzle.bggg;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(6-5)", "((76)-9)", "6");
            var v = ov.swizzle.bggb;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("((76)-9)", Is.EqualTo(v.y));
            Assert.That("((76)-9)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", "(-54)", "((-51)2)");
            var v = ov.swizzle.bgb;
            Assert.That("((-51)2)", Is.EqualTo(v.x));
            Assert.That("(-54)", Is.EqualTo(v.y));
            Assert.That("((-51)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "null", "((19)-5)");
            var v = ov.swizzle.bgbr;
            Assert.That("((19)-5)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((19)-5)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((3-2)2)", "null", "((3-2)2)");
            var v = ov.swizzle.bgbg;
            Assert.That("((3-2)2)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((3-2)2)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-11)", "0", "0");
            var v = ov.swizzle.bgbb;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-97)0)", "-9", "(-8-7)");
            var v = ov.swizzle.bb;
            Assert.That("(-8-7)", Is.EqualTo(v.x));
            Assert.That("(-8-7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-4-5)-4)", "((-2-5)9)", "((-8-6)-8)");
            var v = ov.swizzle.bbr;
            Assert.That("((-8-6)-8)", Is.EqualTo(v.x));
            Assert.That("((-8-6)-8)", Is.EqualTo(v.y));
            Assert.That("((-4-5)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-39)", "(-39)", "null");
            var v = ov.swizzle.bbrr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-39)", Is.EqualTo(v.z));
            Assert.That("(-39)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-2-4)-5)", "(4-4)", "null");
            var v = ov.swizzle.bbrg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-2-4)-5)", Is.EqualTo(v.z));
            Assert.That("(4-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((4-3)4)", "((4-3)4)", "7");
            var v = ov.swizzle.bbrb;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("((4-3)4)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "-5", "0");
            var v = ov.swizzle.bbg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((59)4)", "((59)4)", "((59)4)");
            var v = ov.swizzle.bbgr;
            Assert.That("((59)4)", Is.EqualTo(v.x));
            Assert.That("((59)4)", Is.EqualTo(v.y));
            Assert.That("((59)4)", Is.EqualTo(v.z));
            Assert.That("((59)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("0", "((-76)-4)", "((-76)-4)");
            var v = ov.swizzle.bbgg;
            Assert.That("((-76)-4)", Is.EqualTo(v.x));
            Assert.That("((-76)-4)", Is.EqualTo(v.y));
            Assert.That("((-76)-4)", Is.EqualTo(v.z));
            Assert.That("((-76)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", "((5-5)1)", "");
            var v = ov.swizzle.bbgb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((5-5)1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "", "((-15)-3)");
            var v = ov.swizzle.bbb;
            Assert.That("((-15)-3)", Is.EqualTo(v.x));
            Assert.That("((-15)-3)", Is.EqualTo(v.y));
            Assert.That("((-15)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-28)9)", "1", "(-2-8)");
            var v = ov.swizzle.bbbr;
            Assert.That("(-2-8)", Is.EqualTo(v.x));
            Assert.That("(-2-8)", Is.EqualTo(v.y));
            Assert.That("(-2-8)", Is.EqualTo(v.z));
            Assert.That("((-28)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "((43)-3)", "(-79)");
            var v = ov.swizzle.bbbg;
            Assert.That("(-79)", Is.EqualTo(v.x));
            Assert.That("(-79)", Is.EqualTo(v.y));
            Assert.That("(-79)", Is.EqualTo(v.z));
            Assert.That("((43)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((96)5)", "(6-2)", "-6");
            var v = ov.swizzle.bbbb;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec3<string>("6", "(22)", "(95)");
            var v1 = new gvec2<string>("(-6-5)", "-2");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-6-5)", Is.EqualTo(v0.x));
            Assert.That("-2", Is.EqualTo(v0.y));
            Assert.That("(95)", Is.EqualTo(v0.z));
        
            Assert.That("6", Is.EqualTo(v2.x));
            Assert.That("(22)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("null", "null", "(-84)");
            var v1 = new gvec2<string>("6", "-6");
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("6", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("-6", Is.EqualTo(v0.z));
        
            Assert.That("null", Is.EqualTo(v2.x));
            Assert.That("(-84)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("null", "-3", "-1");
            var v1 = new gvec2<string>("((-10)-6)", "3");
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("((-10)-6)", Is.EqualTo(v0.y));
            Assert.That("3", Is.EqualTo(v0.z));
        
            Assert.That("-3", Is.EqualTo(v2.x));
            Assert.That("-1", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("", "((07)2)", "(56)");
            var v1 = new gvec3<string>("(29)", "(5-2)", "null");
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(29)", Is.EqualTo(v0.x));
            Assert.That("(5-2)", Is.EqualTo(v0.y));
            Assert.That("null", Is.EqualTo(v0.z));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("((07)2)", Is.EqualTo(v2.y));
            Assert.That("(56)", Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new gvec3<string>("", "-3", "");
            var v1 = "((85)3)";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((85)3)", Is.EqualTo(v0.x));
            Assert.That("-3", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
        
            Assert.That("", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec3<string>("(34)", "((82)3)", "(34)");
            var v1 = "-3";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(34)", Is.EqualTo(v0.x));
            Assert.That("-3", Is.EqualTo(v0.y));
            Assert.That("(34)", Is.EqualTo(v0.z));
        
            Assert.That("((82)3)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec3<string>("-6", "null", "-6");
            var v1 = new gvec2<string>("8", "(68)");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("8", Is.EqualTo(v0.x));
            Assert.That("(68)", Is.EqualTo(v0.y));
            Assert.That("-6", Is.EqualTo(v0.z));
        
            Assert.That("-6", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("(-86)", "5", "8");
            var v1 = "(-4-6)";
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-86)", Is.EqualTo(v0.x));
            Assert.That("5", Is.EqualTo(v0.y));
            Assert.That("(-4-6)", Is.EqualTo(v0.z));
        
            Assert.That("8", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec3<string>("(9-3)", "9", "((8-9)2)");
            var v1 = new gvec2<string>("(-41)", "-3");
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-41)", Is.EqualTo(v0.x));
            Assert.That("9", Is.EqualTo(v0.y));
            Assert.That("-3", Is.EqualTo(v0.z));
        
            Assert.That("(9-3)", Is.EqualTo(v2.x));
            Assert.That("((8-9)2)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("-6", "-6", "((9-8)3)");
            var v1 = new gvec2<string>("((71)6)", "");
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-6", Is.EqualTo(v0.x));
            Assert.That("((71)6)", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
        
            Assert.That("-6", Is.EqualTo(v2.x));
            Assert.That("((9-8)3)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("null", "((72)-4)", "((72)-4)");
            var v1 = new gvec3<string>("-1", "", "((-41)-6)");
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-1", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("((-41)-6)", Is.EqualTo(v0.z));
        
            Assert.That("null", Is.EqualTo(v2.x));
            Assert.That("((72)-4)", Is.EqualTo(v2.y));
            Assert.That("((72)-4)", Is.EqualTo(v2.z));
        }
    }

}
