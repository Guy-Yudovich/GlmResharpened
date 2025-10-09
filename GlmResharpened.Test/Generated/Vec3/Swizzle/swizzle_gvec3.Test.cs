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
            var ov = new gvec3<string>("1", "5", "");
            var v = ov.swizzle.xx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("4", "0", "");
            var v = ov.swizzle.xxx;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "", "(74)");
            var v = ov.swizzle.xxxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "((-1-2)-4)", "");
            var v = ov.swizzle.xxxy;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("((-1-2)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", "null", "-6");
            var v = ov.swizzle.xxxz;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", "((3-5)-7)", "4");
            var v = ov.swizzle.xxy;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((3-5)-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "7", "-6");
            var v = ov.swizzle.xxyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "(78)", "(09)");
            var v = ov.swizzle.xxyy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(78)", Is.EqualTo(v.z));
            Assert.That("(78)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-2-3)", "null", "0");
            var v = ov.swizzle.xxyz;
            Assert.That("(-2-3)", Is.EqualTo(v.x));
            Assert.That("(-2-3)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "0", "((-3-7)4)");
            var v = ov.swizzle.xxz;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((-3-7)4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((98)-4)", "", "(8-7)");
            var v = ov.swizzle.xxzx;
            Assert.That("((98)-4)", Is.EqualTo(v.x));
            Assert.That("((98)-4)", Is.EqualTo(v.y));
            Assert.That("(8-7)", Is.EqualTo(v.z));
            Assert.That("((98)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "-9", "9");
            var v = ov.swizzle.xxzy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "(0-2)", "(-78)");
            var v = ov.swizzle.xxzz;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(-78)", Is.EqualTo(v.z));
            Assert.That("(-78)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(5-5)", "(-50)", "(-50)");
            var v = ov.swizzle.xy;
            Assert.That("(5-5)", Is.EqualTo(v.x));
            Assert.That("(-50)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((1-3)-8)", "-8", "");
            var v = ov.swizzle.xyx;
            Assert.That("((1-3)-8)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("((1-3)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-1", "((56)-9)", "((56)-9)");
            var v = ov.swizzle.xyxx;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((56)-9)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-14)", "3", "((4-5)0)");
            var v = ov.swizzle.xyxy;
            Assert.That("(-14)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(-14)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((89)9)", "", "((-80)-2)");
            var v = ov.swizzle.xyxz;
            Assert.That("((89)9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((89)9)", Is.EqualTo(v.z));
            Assert.That("((-80)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-80)-4)", "", "4");
            var v = ov.swizzle.xyy;
            Assert.That("((-80)-4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-54)", "", "0");
            var v = ov.swizzle.xyyx;
            Assert.That("(-54)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-54)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-3-1)1)", "1", "");
            var v = ov.swizzle.xyyy;
            Assert.That("((-3-1)1)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-5-9)", "", "-8");
            var v = ov.swizzle.xyyz;
            Assert.That("(-5-9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(6-3)", "((24)-7)", "6");
            var v = ov.swizzle.xyz;
            Assert.That("(6-3)", Is.EqualTo(v.x));
            Assert.That("((24)-7)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-6-3)", "(-89)", "((-7-8)5)");
            var v = ov.swizzle.xyzx;
            Assert.That("(-6-3)", Is.EqualTo(v.x));
            Assert.That("(-89)", Is.EqualTo(v.y));
            Assert.That("((-7-8)5)", Is.EqualTo(v.z));
            Assert.That("(-6-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-3-6)-3)", "((3-3)3)", "((3-3)3)");
            var v = ov.swizzle.xyzy;
            Assert.That("((-3-6)-3)", Is.EqualTo(v.x));
            Assert.That("((3-3)3)", Is.EqualTo(v.y));
            Assert.That("((3-3)3)", Is.EqualTo(v.z));
            Assert.That("((3-3)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "(-77)", "3");
            var v = ov.swizzle.xyzz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-77)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "-9", "0");
            var v = ov.swizzle.xz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "-3", "-3");
            var v = ov.swizzle.xzx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-9", "(7-9)", "");
            var v = ov.swizzle.xzxx;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "null", "-4");
            var v = ov.swizzle.xzxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((9-7)-3)", "-1", "2");
            var v = ov.swizzle.xzxz;
            Assert.That("((9-7)-3)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((9-7)-3)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(7-7)", "(-95)", "((1-3)-7)");
            var v = ov.swizzle.xzy;
            Assert.That("(7-7)", Is.EqualTo(v.x));
            Assert.That("((1-3)-7)", Is.EqualTo(v.y));
            Assert.That("(-95)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((2-1)4)", "(9-2)", "null");
            var v = ov.swizzle.xzyx;
            Assert.That("((2-1)4)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(9-2)", Is.EqualTo(v.z));
            Assert.That("((2-1)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "((84)7)", "");
            var v = ov.swizzle.xzyy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((84)7)", Is.EqualTo(v.z));
            Assert.That("((84)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-59)", "", "0");
            var v = ov.swizzle.xzyz;
            Assert.That("(-59)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((41)-7)", "(-5-1)", "((27)-9)");
            var v = ov.swizzle.xzz;
            Assert.That("((41)-7)", Is.EqualTo(v.x));
            Assert.That("((27)-9)", Is.EqualTo(v.y));
            Assert.That("((27)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-9-1)-9)", "-1", "7");
            var v = ov.swizzle.xzzx;
            Assert.That("((-9-1)-9)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((-9-1)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-5-8)-6)", "-4");
            var v = ov.swizzle.xzzy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("((-5-8)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(9-1)", "((-8-9)2)", "((-8-9)2)");
            var v = ov.swizzle.xzzz;
            Assert.That("(9-1)", Is.EqualTo(v.x));
            Assert.That("((-8-9)2)", Is.EqualTo(v.y));
            Assert.That("((-8-9)2)", Is.EqualTo(v.z));
            Assert.That("((-8-9)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((5-5)-3)", "(-4-4)", "(-4-4)");
            var v = ov.swizzle.yx;
            Assert.That("(-4-4)", Is.EqualTo(v.x));
            Assert.That("((5-5)-3)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(-6-9)", "((07)-3)", "((14)0)");
            var v = ov.swizzle.yxx;
            Assert.That("((07)-3)", Is.EqualTo(v.x));
            Assert.That("(-6-9)", Is.EqualTo(v.y));
            Assert.That("(-6-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-5-4)-8)", "((-5-4)-8)", "-8");
            var v = ov.swizzle.yxxx;
            Assert.That("((-5-4)-8)", Is.EqualTo(v.x));
            Assert.That("((-5-4)-8)", Is.EqualTo(v.y));
            Assert.That("((-5-4)-8)", Is.EqualTo(v.z));
            Assert.That("((-5-4)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-80)5)", "-4", "-6");
            var v = ov.swizzle.yxxy;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("((-80)5)", Is.EqualTo(v.y));
            Assert.That("((-80)5)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(5-3)", "3", "(5-3)");
            var v = ov.swizzle.yxxz;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(5-3)", Is.EqualTo(v.y));
            Assert.That("(5-3)", Is.EqualTo(v.z));
            Assert.That("(5-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "((-2-9)7)", "null");
            var v = ov.swizzle.yxy;
            Assert.That("((-2-9)7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-2-9)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-4", "null", "((5-2)-6)");
            var v = ov.swizzle.yxyx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(16)", "((2-4)0)", "(29)");
            var v = ov.swizzle.yxyy;
            Assert.That("((2-4)0)", Is.EqualTo(v.x));
            Assert.That("(16)", Is.EqualTo(v.y));
            Assert.That("((2-4)0)", Is.EqualTo(v.z));
            Assert.That("((2-4)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((0-5)-4)", "null", "((1-4)0)");
            var v = ov.swizzle.yxyz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((0-5)-4)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((1-4)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(2-9)", "1");
            var v = ov.swizzle.yxz;
            Assert.That("(2-9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "null", "((-60)1)");
            var v = ov.swizzle.yxzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-60)1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "((-29)-2)", "3");
            var v = ov.swizzle.yxzy;
            Assert.That("((-29)-2)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("((-29)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", "((33)-6)", "((7-8)-6)");
            var v = ov.swizzle.yxzz;
            Assert.That("((33)-6)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((7-8)-6)", Is.EqualTo(v.z));
            Assert.That("((7-8)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "((58)5)", "(-53)");
            var v = ov.swizzle.yy;
            Assert.That("((58)5)", Is.EqualTo(v.x));
            Assert.That("((58)5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((98)-9)", "(-5-7)", "((76)-5)");
            var v = ov.swizzle.yyx;
            Assert.That("(-5-7)", Is.EqualTo(v.x));
            Assert.That("(-5-7)", Is.EqualTo(v.y));
            Assert.That("((98)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "(8-5)", "-6");
            var v = ov.swizzle.yyxx;
            Assert.That("(8-5)", Is.EqualTo(v.x));
            Assert.That("(8-5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((6-7)2)", "(-1-2)", "(-1-2)");
            var v = ov.swizzle.yyxy;
            Assert.That("(-1-2)", Is.EqualTo(v.x));
            Assert.That("(-1-2)", Is.EqualTo(v.y));
            Assert.That("((6-7)2)", Is.EqualTo(v.z));
            Assert.That("(-1-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "(-59)", "(-72)");
            var v = ov.swizzle.yyxz;
            Assert.That("(-59)", Is.EqualTo(v.x));
            Assert.That("(-59)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("(-72)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((6-6)-5)", "((6-6)-5)", "((-32)6)");
            var v = ov.swizzle.yyy;
            Assert.That("((6-6)-5)", Is.EqualTo(v.x));
            Assert.That("((6-6)-5)", Is.EqualTo(v.y));
            Assert.That("((6-6)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-18)0)", "4", "(30)");
            var v = ov.swizzle.yyyx;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("((-18)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-79)8)", "((0-5)8)", "-3");
            var v = ov.swizzle.yyyy;
            Assert.That("((0-5)8)", Is.EqualTo(v.x));
            Assert.That("((0-5)8)", Is.EqualTo(v.y));
            Assert.That("((0-5)8)", Is.EqualTo(v.z));
            Assert.That("((0-5)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(7-9)", "9", "");
            var v = ov.swizzle.yyyz;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-5-4)", "null", "(-5-4)");
            var v = ov.swizzle.yyz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-5-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-3", "-2", "(-3-9)");
            var v = ov.swizzle.yyzx;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("(-3-9)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-72)", "null", "4");
            var v = ov.swizzle.yyzy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "((1-9)-9)", "");
            var v = ov.swizzle.yyzz;
            Assert.That("((1-9)-9)", Is.EqualTo(v.x));
            Assert.That("((1-9)-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "0", "((37)1)");
            var v = ov.swizzle.yz;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((37)1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(-1-2)", "null", "((-35)-2)");
            var v = ov.swizzle.yzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-35)-2)", Is.EqualTo(v.y));
            Assert.That("(-1-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("4", "4", "(-30)");
            var v = ov.swizzle.yzxx;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("(-30)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(4-9)", "", "0");
            var v = ov.swizzle.yzxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("(4-9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((09)3)", "((0-2)5)", "((73)-4)");
            var v = ov.swizzle.yzxz;
            Assert.That("((0-2)5)", Is.EqualTo(v.x));
            Assert.That("((73)-4)", Is.EqualTo(v.y));
            Assert.That("((09)3)", Is.EqualTo(v.z));
            Assert.That("((73)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "((-9-9)-5)", "((43)-3)");
            var v = ov.swizzle.yzy;
            Assert.That("((-9-9)-5)", Is.EqualTo(v.x));
            Assert.That("((43)-3)", Is.EqualTo(v.y));
            Assert.That("((-9-9)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((18)3)", "(-41)", "(41)");
            var v = ov.swizzle.yzyx;
            Assert.That("(-41)", Is.EqualTo(v.x));
            Assert.That("(41)", Is.EqualTo(v.y));
            Assert.That("(-41)", Is.EqualTo(v.z));
            Assert.That("((18)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-3-4)-5)", "(-57)", "((00)-5)");
            var v = ov.swizzle.yzyy;
            Assert.That("(-57)", Is.EqualTo(v.x));
            Assert.That("((00)-5)", Is.EqualTo(v.y));
            Assert.That("(-57)", Is.EqualTo(v.z));
            Assert.That("(-57)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-9-6)-7)", "((-55)9)", "(-7-1)");
            var v = ov.swizzle.yzyz;
            Assert.That("((-55)9)", Is.EqualTo(v.x));
            Assert.That("(-7-1)", Is.EqualTo(v.y));
            Assert.That("((-55)9)", Is.EqualTo(v.z));
            Assert.That("(-7-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(77)", "(77)", "(4-8)");
            var v = ov.swizzle.yzz;
            Assert.That("(77)", Is.EqualTo(v.x));
            Assert.That("(4-8)", Is.EqualTo(v.y));
            Assert.That("(4-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("9", "9", "3");
            var v = ov.swizzle.yzzx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-2-8)-4)", "7");
            var v = ov.swizzle.yzzy;
            Assert.That("((-2-8)-4)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((-2-8)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(2-6)", "((-70)1)", "((-63)-5)");
            var v = ov.swizzle.yzzz;
            Assert.That("((-70)1)", Is.EqualTo(v.x));
            Assert.That("((-63)-5)", Is.EqualTo(v.y));
            Assert.That("((-63)-5)", Is.EqualTo(v.z));
            Assert.That("((-63)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((8-6)-5)", "null", "-9");
            var v = ov.swizzle.zx;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((8-6)-5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("null", "(86)", "-7");
            var v = ov.swizzle.zxx;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-4-8)", "-3", "(-4-8)");
            var v = ov.swizzle.zxxx;
            Assert.That("(-4-8)", Is.EqualTo(v.x));
            Assert.That("(-4-8)", Is.EqualTo(v.y));
            Assert.That("(-4-8)", Is.EqualTo(v.z));
            Assert.That("(-4-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "-3", "null");
            var v = ov.swizzle.zxxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "3", "3");
            var v = ov.swizzle.zxxz;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", "((-8-5)8)", "(-2-7)");
            var v = ov.swizzle.zxy;
            Assert.That("(-2-7)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((-8-5)8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-8", "((40)-9)", "6");
            var v = ov.swizzle.zxyx;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("((40)-9)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "((-89)1)", "3");
            var v = ov.swizzle.zxyy;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((-89)1)", Is.EqualTo(v.z));
            Assert.That("((-89)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-4-8)9)", "");
            var v = ov.swizzle.zxyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-4-8)9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-92)0)", "((9-4)-4)", "(5-8)");
            var v = ov.swizzle.zxz;
            Assert.That("(5-8)", Is.EqualTo(v.x));
            Assert.That("((-92)0)", Is.EqualTo(v.y));
            Assert.That("(5-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(4-2)", "((08)3)", "((-2-2)-9)");
            var v = ov.swizzle.zxzx;
            Assert.That("((-2-2)-9)", Is.EqualTo(v.x));
            Assert.That("(4-2)", Is.EqualTo(v.y));
            Assert.That("((-2-2)-9)", Is.EqualTo(v.z));
            Assert.That("(4-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((93)5)", "((93)5)", "(-21)");
            var v = ov.swizzle.zxzy;
            Assert.That("(-21)", Is.EqualTo(v.x));
            Assert.That("((93)5)", Is.EqualTo(v.y));
            Assert.That("(-21)", Is.EqualTo(v.z));
            Assert.That("((93)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-47)-9)", "(-72)", "-1");
            var v = ov.swizzle.zxzz;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((-47)-9)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "(27)", "(27)");
            var v = ov.swizzle.zy;
            Assert.That("(27)", Is.EqualTo(v.x));
            Assert.That("(27)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(4-6)", "3", "3");
            var v = ov.swizzle.zyx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(4-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "(19)", "((7-2)1)");
            var v = ov.swizzle.zyxx;
            Assert.That("((7-2)1)", Is.EqualTo(v.x));
            Assert.That("(19)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-4-3)", "(2-2)", "(53)");
            var v = ov.swizzle.zyxy;
            Assert.That("(53)", Is.EqualTo(v.x));
            Assert.That("(2-2)", Is.EqualTo(v.y));
            Assert.That("(-4-3)", Is.EqualTo(v.z));
            Assert.That("(2-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", "4", "(7-9)");
            var v = ov.swizzle.zyxz;
            Assert.That("(7-9)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(7-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(56)", "((-58)-9)", "(56)");
            var v = ov.swizzle.zyy;
            Assert.That("(56)", Is.EqualTo(v.x));
            Assert.That("((-58)-9)", Is.EqualTo(v.y));
            Assert.That("((-58)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-14)4)", "7", "(-99)");
            var v = ov.swizzle.zyyx;
            Assert.That("(-99)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((-14)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "7", "(-79)");
            var v = ov.swizzle.zyyy;
            Assert.That("(-79)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-8-3)8)", "-4", "((-8-3)4)");
            var v = ov.swizzle.zyyz;
            Assert.That("((-8-3)4)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("((-8-3)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-40)2)", "(-5-3)", "((-57)-4)");
            var v = ov.swizzle.zyz;
            Assert.That("((-57)-4)", Is.EqualTo(v.x));
            Assert.That("(-5-3)", Is.EqualTo(v.y));
            Assert.That("((-57)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "null", "8");
            var v = ov.swizzle.zyzx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-3-4)8)", "-4", "(-1-7)");
            var v = ov.swizzle.zyzy;
            Assert.That("(-1-7)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(-1-7)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "-8", "");
            var v = ov.swizzle.zyzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((4-5)1)", "((89)-6)", "(02)");
            var v = ov.swizzle.zz;
            Assert.That("(02)", Is.EqualTo(v.x));
            Assert.That("(02)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "((-1-7)8)", "((2-6)6)");
            var v = ov.swizzle.zzx;
            Assert.That("((2-6)6)", Is.EqualTo(v.x));
            Assert.That("((2-6)6)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-6", "-3", "((32)-8)");
            var v = ov.swizzle.zzxx;
            Assert.That("((32)-8)", Is.EqualTo(v.x));
            Assert.That("((32)-8)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-8-2)", "1", "-7");
            var v = ov.swizzle.zzxy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(-8-2)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-33)-6)", "(4-2)", "9");
            var v = ov.swizzle.zzxz;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("((-33)-6)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(63)", "((28)0)", "null");
            var v = ov.swizzle.zzy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((28)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(8-6)", "6", "((-96)-7)");
            var v = ov.swizzle.zzyx;
            Assert.That("((-96)-7)", Is.EqualTo(v.x));
            Assert.That("((-96)-7)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("(8-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "-8", "-8");
            var v = ov.swizzle.zzyy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((6-9)8)", "((6-9)8)", "8");
            var v = ov.swizzle.zzyz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("((6-9)8)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "-3", "(-7-5)");
            var v = ov.swizzle.zzz;
            Assert.That("(-7-5)", Is.EqualTo(v.x));
            Assert.That("(-7-5)", Is.EqualTo(v.y));
            Assert.That("(-7-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("9", "-9", "null");
            var v = ov.swizzle.zzzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "((-52)7)", "(12)");
            var v = ov.swizzle.zzzy;
            Assert.That("(12)", Is.EqualTo(v.x));
            Assert.That("(12)", Is.EqualTo(v.y));
            Assert.That("(12)", Is.EqualTo(v.z));
            Assert.That("((-52)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(8-9)", "-5", "(8-9)");
            var v = ov.swizzle.zzzz;
            Assert.That("(8-9)", Is.EqualTo(v.x));
            Assert.That("(8-9)", Is.EqualTo(v.y));
            Assert.That("(8-9)", Is.EqualTo(v.z));
            Assert.That("(8-9)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec3<string>("8", "", "(6-7)");
            var v = ov.swizzle.rr;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "((-66)7)", "-3");
            var v = ov.swizzle.rrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "((-36)-9)", "(93)");
            var v = ov.swizzle.rrrr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(85)", "(95)");
            var v = ov.swizzle.rrrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(85)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("0", "null", "0");
            var v = ov.swizzle.rrrb;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((4-3)-8)", "(60)", "6");
            var v = ov.swizzle.rrg;
            Assert.That("((4-3)-8)", Is.EqualTo(v.x));
            Assert.That("((4-3)-8)", Is.EqualTo(v.y));
            Assert.That("(60)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-2-7)5)", "-3", "null");
            var v = ov.swizzle.rrgr;
            Assert.That("((-2-7)5)", Is.EqualTo(v.x));
            Assert.That("((-2-7)5)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("((-2-7)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "", "((-43)-1)");
            var v = ov.swizzle.rrgg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "", "((2-4)-2)");
            var v = ov.swizzle.rrgb;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((2-4)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-41)", "(-41)", "(-5-9)");
            var v = ov.swizzle.rrb;
            Assert.That("(-41)", Is.EqualTo(v.x));
            Assert.That("(-41)", Is.EqualTo(v.y));
            Assert.That("(-5-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-6", "null", "(-29)");
            var v = ov.swizzle.rrbr;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(-29)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "(-2-4)", "");
            var v = ov.swizzle.rrbg;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-2-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(3-3)", "9", "(3-3)");
            var v = ov.swizzle.rrbb;
            Assert.That("(3-3)", Is.EqualTo(v.x));
            Assert.That("(3-3)", Is.EqualTo(v.y));
            Assert.That("(3-3)", Is.EqualTo(v.z));
            Assert.That("(3-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-9", "0", "8");
            var v = ov.swizzle.rg;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-4-7)-4)", "", "(-90)");
            var v = ov.swizzle.rgr;
            Assert.That("((-4-7)-4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-4-7)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(20)", "", "-1");
            var v = ov.swizzle.rgrr;
            Assert.That("(20)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(20)", Is.EqualTo(v.z));
            Assert.That("(20)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "(4-9)", "8");
            var v = ov.swizzle.rgrg;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("(4-9)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("(4-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-8-1)", "-3", "((6-7)0)");
            var v = ov.swizzle.rgrb;
            Assert.That("(-8-1)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(-8-1)", Is.EqualTo(v.z));
            Assert.That("((6-7)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-5", "", "(29)");
            var v = ov.swizzle.rgg;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-7", "1", "");
            var v = ov.swizzle.rggr;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-8-1)", "((33)-9)", "null");
            var v = ov.swizzle.rggg;
            Assert.That("(-8-1)", Is.EqualTo(v.x));
            Assert.That("((33)-9)", Is.EqualTo(v.y));
            Assert.That("((33)-9)", Is.EqualTo(v.z));
            Assert.That("((33)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(66)", "null", "((1-5)-6)");
            var v = ov.swizzle.rggb;
            Assert.That("(66)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((1-5)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-74)", "", "(-15)");
            var v = ov.swizzle.rgb;
            Assert.That("(-74)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-15)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "1", "null");
            var v = ov.swizzle.rgbr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-46)", "((8-1)-5)", "((8-1)-5)");
            var v = ov.swizzle.rgbg;
            Assert.That("(-46)", Is.EqualTo(v.x));
            Assert.That("((8-1)-5)", Is.EqualTo(v.y));
            Assert.That("((8-1)-5)", Is.EqualTo(v.z));
            Assert.That("((8-1)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-44)", "((-4-2)-4)", "-1");
            var v = ov.swizzle.rgbb;
            Assert.That("(-44)", Is.EqualTo(v.x));
            Assert.That("((-4-2)-4)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((54)6)", "null", "(-87)");
            var v = ov.swizzle.rb;
            Assert.That("((54)6)", Is.EqualTo(v.x));
            Assert.That("(-87)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-1-9)7)", "(51)", "(3-2)");
            var v = ov.swizzle.rbr;
            Assert.That("((-1-9)7)", Is.EqualTo(v.x));
            Assert.That("(3-2)", Is.EqualTo(v.y));
            Assert.That("((-1-9)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-20)", "-1", "(-71)");
            var v = ov.swizzle.rbrr;
            Assert.That("(-20)", Is.EqualTo(v.x));
            Assert.That("(-71)", Is.EqualTo(v.y));
            Assert.That("(-20)", Is.EqualTo(v.z));
            Assert.That("(-20)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "(82)", "((-7-4)-5)");
            var v = ov.swizzle.rbrg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-7-4)-5)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(82)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-21)1)", "5", "(-9-1)");
            var v = ov.swizzle.rbrb;
            Assert.That("((-21)1)", Is.EqualTo(v.x));
            Assert.That("(-9-1)", Is.EqualTo(v.y));
            Assert.That("((-21)1)", Is.EqualTo(v.z));
            Assert.That("(-9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-26)-4)", "null", "((-26)-4)");
            var v = ov.swizzle.rbg;
            Assert.That("((-26)-4)", Is.EqualTo(v.x));
            Assert.That("((-26)-4)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-13)", "((-3-9)9)", "((-3-9)9)");
            var v = ov.swizzle.rbgr;
            Assert.That("(-13)", Is.EqualTo(v.x));
            Assert.That("((-3-9)9)", Is.EqualTo(v.y));
            Assert.That("((-3-9)9)", Is.EqualTo(v.z));
            Assert.That("(-13)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "-4", "");
            var v = ov.swizzle.rbgg;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-76)", "((8-8)-1)", "(-76)");
            var v = ov.swizzle.rbgb;
            Assert.That("(-76)", Is.EqualTo(v.x));
            Assert.That("(-76)", Is.EqualTo(v.y));
            Assert.That("((8-8)-1)", Is.EqualTo(v.z));
            Assert.That("(-76)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", "-6", "((82)-6)");
            var v = ov.swizzle.rbb;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((82)-6)", Is.EqualTo(v.y));
            Assert.That("((82)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-14)4)", "8", "-1");
            var v = ov.swizzle.rbbr;
            Assert.That("((-14)4)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("((-14)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-13)", "-9", "");
            var v = ov.swizzle.rbbg;
            Assert.That("(-13)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "(-61)", "((95)4)");
            var v = ov.swizzle.rbbb;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((95)4)", Is.EqualTo(v.y));
            Assert.That("((95)4)", Is.EqualTo(v.z));
            Assert.That("((95)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "((-4-5)-4)", "-1");
            var v = ov.swizzle.gr;
            Assert.That("((-4-5)-4)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(-40)", "(-18)", "(-18)");
            var v = ov.swizzle.grr;
            Assert.That("(-18)", Is.EqualTo(v.x));
            Assert.That("(-40)", Is.EqualTo(v.y));
            Assert.That("(-40)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-4-5)-8)", "((5-1)-1)", "");
            var v = ov.swizzle.grrr;
            Assert.That("((5-1)-1)", Is.EqualTo(v.x));
            Assert.That("((-4-5)-8)", Is.EqualTo(v.y));
            Assert.That("((-4-5)-8)", Is.EqualTo(v.z));
            Assert.That("((-4-5)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(97)", "", "(-2-3)");
            var v = ov.swizzle.grrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(97)", Is.EqualTo(v.y));
            Assert.That("(97)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "", "");
            var v = ov.swizzle.grrb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "((-61)-6)", "(-71)");
            var v = ov.swizzle.grg;
            Assert.That("((-61)-6)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((-61)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((61)-9)", "((-38)-4)", "null");
            var v = ov.swizzle.grgr;
            Assert.That("((-38)-4)", Is.EqualTo(v.x));
            Assert.That("((61)-9)", Is.EqualTo(v.y));
            Assert.That("((-38)-4)", Is.EqualTo(v.z));
            Assert.That("((61)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "-2", "(69)");
            var v = ov.swizzle.grgg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "(-59)", "(12)");
            var v = ov.swizzle.grgb;
            Assert.That("(-59)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-59)", Is.EqualTo(v.z));
            Assert.That("(12)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "-5", "((80)-3)");
            var v = ov.swizzle.grb;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((80)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("6", "((32)-7)", "-4");
            var v = ov.swizzle.grbr;
            Assert.That("((32)-7)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-47)-9)", "-3");
            var v = ov.swizzle.grbg;
            Assert.That("((-47)-9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("((-47)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "((3-3)5)", "");
            var v = ov.swizzle.grbb;
            Assert.That("((3-3)5)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", "null", "4");
            var v = ov.swizzle.gg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-5-6)0)", "(73)", "");
            var v = ov.swizzle.ggr;
            Assert.That("(73)", Is.EqualTo(v.x));
            Assert.That("(73)", Is.EqualTo(v.y));
            Assert.That("((-5-6)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-2-9)-3)", "", "((-6-2)-8)");
            var v = ov.swizzle.ggrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-2-9)-3)", Is.EqualTo(v.z));
            Assert.That("((-2-9)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "0", "(-6-8)");
            var v = ov.swizzle.ggrg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((96)3)", "null", "null");
            var v = ov.swizzle.ggrb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((96)3)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(72)", "null", "null");
            var v = ov.swizzle.ggg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-5", "7", "");
            var v = ov.swizzle.gggr;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "((-46)-2)", "((-46)-2)");
            var v = ov.swizzle.gggg;
            Assert.That("((-46)-2)", Is.EqualTo(v.x));
            Assert.That("((-46)-2)", Is.EqualTo(v.y));
            Assert.That("((-46)-2)", Is.EqualTo(v.z));
            Assert.That("((-46)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((05)0)", "((-42)-6)", "(6-8)");
            var v = ov.swizzle.gggb;
            Assert.That("((-42)-6)", Is.EqualTo(v.x));
            Assert.That("((-42)-6)", Is.EqualTo(v.y));
            Assert.That("((-42)-6)", Is.EqualTo(v.z));
            Assert.That("(6-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((46)-6)", "((46)-6)", "8");
            var v = ov.swizzle.ggb;
            Assert.That("((46)-6)", Is.EqualTo(v.x));
            Assert.That("((46)-6)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "0", "(5-2)");
            var v = ov.swizzle.ggbr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("(5-2)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", "null", "0");
            var v = ov.swizzle.ggbg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "", "(14)");
            var v = ov.swizzle.ggbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(14)", Is.EqualTo(v.z));
            Assert.That("(14)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "0", "((-87)-8)");
            var v = ov.swizzle.gb;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((-87)-8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-40)-6)", "(-87)", "(-42)");
            var v = ov.swizzle.gbr;
            Assert.That("(-87)", Is.EqualTo(v.x));
            Assert.That("(-42)", Is.EqualTo(v.y));
            Assert.That("((-40)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((8-5)1)", "-7", "-7");
            var v = ov.swizzle.gbrr;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((8-5)1)", Is.EqualTo(v.z));
            Assert.That("((8-5)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((45)-2)", "(-78)", "0");
            var v = ov.swizzle.gbrg;
            Assert.That("(-78)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((45)-2)", Is.EqualTo(v.z));
            Assert.That("(-78)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(46)", "5", "-1");
            var v = ov.swizzle.gbrb;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(46)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((2-5)-9)", "(1-6)", "((8-9)3)");
            var v = ov.swizzle.gbg;
            Assert.That("(1-6)", Is.EqualTo(v.x));
            Assert.That("((8-9)3)", Is.EqualTo(v.y));
            Assert.That("(1-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "(-21)", "null");
            var v = ov.swizzle.gbgr;
            Assert.That("(-21)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-21)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "((-20)-8)", "(-7-5)");
            var v = ov.swizzle.gbgg;
            Assert.That("((-20)-8)", Is.EqualTo(v.x));
            Assert.That("(-7-5)", Is.EqualTo(v.y));
            Assert.That("((-20)-8)", Is.EqualTo(v.z));
            Assert.That("((-20)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(0-3)", "((-61)3)", "");
            var v = ov.swizzle.gbgb;
            Assert.That("((-61)3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-61)3)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "", "(5-6)");
            var v = ov.swizzle.gbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(5-6)", Is.EqualTo(v.y));
            Assert.That("(5-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-7", "", "((85)-7)");
            var v = ov.swizzle.gbbr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((85)-7)", Is.EqualTo(v.y));
            Assert.That("((85)-7)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-51)", "8", "((-1-1)6)");
            var v = ov.swizzle.gbbg;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((-1-1)6)", Is.EqualTo(v.y));
            Assert.That("((-1-1)6)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "-6", "(0-6)");
            var v = ov.swizzle.gbbb;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("(0-6)", Is.EqualTo(v.y));
            Assert.That("(0-6)", Is.EqualTo(v.z));
            Assert.That("(0-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((28)8)", "0", "");
            var v = ov.swizzle.br;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((28)8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "((-7-7)-2)", "0");
            var v = ov.swizzle.brr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("5", "((-96)7)", "5");
            var v = ov.swizzle.brrr;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((1-8)-6)", "7", "((-6-6)-2)");
            var v = ov.swizzle.brrg;
            Assert.That("((-6-6)-2)", Is.EqualTo(v.x));
            Assert.That("((1-8)-6)", Is.EqualTo(v.y));
            Assert.That("((1-8)-6)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "", "6");
            var v = ov.swizzle.brrb;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(5-4)", "null", "(5-4)");
            var v = ov.swizzle.brg;
            Assert.That("(5-4)", Is.EqualTo(v.x));
            Assert.That("(5-4)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("null", "0", "null");
            var v = ov.swizzle.brgr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-3-5)", "-6", "(-3-5)");
            var v = ov.swizzle.brgg;
            Assert.That("(-3-5)", Is.EqualTo(v.x));
            Assert.That("(-3-5)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((3-9)4)", "(-6-8)", "");
            var v = ov.swizzle.brgb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((3-9)4)", Is.EqualTo(v.y));
            Assert.That("(-6-8)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-14)", "((4-7)2)", "((4-7)2)");
            var v = ov.swizzle.brb;
            Assert.That("((4-7)2)", Is.EqualTo(v.x));
            Assert.That("(-14)", Is.EqualTo(v.y));
            Assert.That("((4-7)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "((5-9)9)", "");
            var v = ov.swizzle.brbr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-8-9)", "-7", "");
            var v = ov.swizzle.brbg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-8-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("0", "null", "((84)9)");
            var v = ov.swizzle.brbb;
            Assert.That("((84)9)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((84)9)", Is.EqualTo(v.z));
            Assert.That("((84)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((39)4)", "3");
            var v = ov.swizzle.bg;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((39)4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(-8-3)", "(-3-4)", "3");
            var v = ov.swizzle.bgr;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(-3-4)", Is.EqualTo(v.y));
            Assert.That("(-8-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(85)", "(-57)", "null");
            var v = ov.swizzle.bgrr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-57)", Is.EqualTo(v.y));
            Assert.That("(85)", Is.EqualTo(v.z));
            Assert.That("(85)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((1-6)-8)", "null", "");
            var v = ov.swizzle.bgrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((1-6)-8)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-9-3)", "((-58)7)", "-7");
            var v = ov.swizzle.bgrb;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-58)7)", Is.EqualTo(v.y));
            Assert.That("(-9-3)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(40)", "-9", "-6");
            var v = ov.swizzle.bgg;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-83)", "null", "-1");
            var v = ov.swizzle.bggr;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-83)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-9", "2", "((75)-2)");
            var v = ov.swizzle.bggg;
            Assert.That("((75)-2)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-85)1)", "((-68)-9)", "-9");
            var v = ov.swizzle.bggb;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((-68)-9)", Is.EqualTo(v.y));
            Assert.That("((-68)-9)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(22)", "(5-1)", "(85)");
            var v = ov.swizzle.bgb;
            Assert.That("(85)", Is.EqualTo(v.x));
            Assert.That("(5-1)", Is.EqualTo(v.y));
            Assert.That("(85)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("3", "null", "3");
            var v = ov.swizzle.bgbr;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((08)9)", "(-4-4)", "((99)7)");
            var v = ov.swizzle.bgbg;
            Assert.That("((99)7)", Is.EqualTo(v.x));
            Assert.That("(-4-4)", Is.EqualTo(v.y));
            Assert.That("((99)7)", Is.EqualTo(v.z));
            Assert.That("(-4-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((77)-8)", "-1", "(-72)");
            var v = ov.swizzle.bgbb;
            Assert.That("(-72)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(-72)", Is.EqualTo(v.z));
            Assert.That("(-72)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-5-3)", "null", "((-87)-5)");
            var v = ov.swizzle.bb;
            Assert.That("((-87)-5)", Is.EqualTo(v.x));
            Assert.That("((-87)-5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((3-9)-1)", "((-7-7)1)", "(-47)");
            var v = ov.swizzle.bbr;
            Assert.That("(-47)", Is.EqualTo(v.x));
            Assert.That("(-47)", Is.EqualTo(v.y));
            Assert.That("((3-9)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-5", "null", "2");
            var v = ov.swizzle.bbrr;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "4", "null");
            var v = ov.swizzle.bbrg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-53)", "", "9");
            var v = ov.swizzle.bbrb;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("(-53)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(0-7)", "(0-9)", "null");
            var v = ov.swizzle.bbg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(0-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(3-5)", "(8-1)", "(-28)");
            var v = ov.swizzle.bbgr;
            Assert.That("(-28)", Is.EqualTo(v.x));
            Assert.That("(-28)", Is.EqualTo(v.y));
            Assert.That("(8-1)", Is.EqualTo(v.z));
            Assert.That("(3-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-4-9)4)", "((7-3)-7)", "6");
            var v = ov.swizzle.bbgg;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("((7-3)-7)", Is.EqualTo(v.z));
            Assert.That("((7-3)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-4-7)2)", "3", "((-69)-6)");
            var v = ov.swizzle.bbgb;
            Assert.That("((-69)-6)", Is.EqualTo(v.x));
            Assert.That("((-69)-6)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("((-69)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((04)-3)", "((6-3)5)", "");
            var v = ov.swizzle.bbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-5", "(3-7)", "null");
            var v = ov.swizzle.bbbr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-14)", "4", "4");
            var v = ov.swizzle.bbbg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("null", "((56)7)", "((36)-3)");
            var v = ov.swizzle.bbbb;
            Assert.That("((36)-3)", Is.EqualTo(v.x));
            Assert.That("((36)-3)", Is.EqualTo(v.y));
            Assert.That("((36)-3)", Is.EqualTo(v.z));
            Assert.That("((36)-3)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec3<string>("(-4-4)", "-1", "((74)0)");
            var v1 = new gvec2<string>("3", "");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("3", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("((74)0)", Is.EqualTo(v0.z));
        
            Assert.That("(-4-4)", Is.EqualTo(v2.x));
            Assert.That("-1", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("(-80)", "((-6-8)7)", "((-4-3)4)");
            var v1 = new gvec2<string>("((-9-9)-6)", "(52)");
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-9-9)-6)", Is.EqualTo(v0.x));
            Assert.That("((-6-8)7)", Is.EqualTo(v0.y));
            Assert.That("(52)", Is.EqualTo(v0.z));
        
            Assert.That("(-80)", Is.EqualTo(v2.x));
            Assert.That("((-4-3)4)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("-5", "-5", "(3-1)");
            var v1 = new gvec2<string>("1", "");
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-5", Is.EqualTo(v0.x));
            Assert.That("1", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
        
            Assert.That("-5", Is.EqualTo(v2.x));
            Assert.That("(3-1)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("((-50)1)", "((-50)1)", "null");
            var v1 = new gvec3<string>("-9", "(1-6)", "(-9-9)");
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-9", Is.EqualTo(v0.x));
            Assert.That("(1-6)", Is.EqualTo(v0.y));
            Assert.That("(-9-9)", Is.EqualTo(v0.z));
        
            Assert.That("((-50)1)", Is.EqualTo(v2.x));
            Assert.That("((-50)1)", Is.EqualTo(v2.y));
            Assert.That("null", Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new gvec3<string>("((-45)-5)", "((-45)-5)", "((-45)-5)");
            var v1 = "9";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("9", Is.EqualTo(v0.x));
            Assert.That("((-45)-5)", Is.EqualTo(v0.y));
            Assert.That("((-45)-5)", Is.EqualTo(v0.z));
        
            Assert.That("((-45)-5)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec3<string>("0", "", "(-45)");
            var v1 = "5";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("0", Is.EqualTo(v0.x));
            Assert.That("5", Is.EqualTo(v0.y));
            Assert.That("(-45)", Is.EqualTo(v0.z));
        
            Assert.That("", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec3<string>("(95)", "((80)8)", "3");
            var v1 = new gvec2<string>("((10)5)", "((-49)-4)");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((10)5)", Is.EqualTo(v0.x));
            Assert.That("((-49)-4)", Is.EqualTo(v0.y));
            Assert.That("3", Is.EqualTo(v0.z));
        
            Assert.That("(95)", Is.EqualTo(v2.x));
            Assert.That("((80)8)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("null", "((99)0)", "(-58)");
            var v1 = "((-2-6)-1)";
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("((99)0)", Is.EqualTo(v0.y));
            Assert.That("((-2-6)-1)", Is.EqualTo(v0.z));
        
            Assert.That("(-58)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec3<string>("-4", "-4", "-4");
            var v1 = new gvec2<string>("", "1");
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("-4", Is.EqualTo(v0.y));
            Assert.That("1", Is.EqualTo(v0.z));
        
            Assert.That("-4", Is.EqualTo(v2.x));
            Assert.That("-4", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("(6-8)", "null", "((-6-8)0)");
            var v1 = new gvec2<string>("-5", "(4-4)");
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(6-8)", Is.EqualTo(v0.x));
            Assert.That("-5", Is.EqualTo(v0.y));
            Assert.That("(4-4)", Is.EqualTo(v0.z));
        
            Assert.That("null", Is.EqualTo(v2.x));
            Assert.That("((-6-8)0)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("1", "((9-1)8)", "null");
            var v1 = new gvec3<string>("(-94)", "(-94)", "((-15)5)");
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-94)", Is.EqualTo(v0.x));
            Assert.That("(-94)", Is.EqualTo(v0.y));
            Assert.That("((-15)5)", Is.EqualTo(v0.z));
        
            Assert.That("1", Is.EqualTo(v2.x));
            Assert.That("((9-1)8)", Is.EqualTo(v2.y));
            Assert.That("null", Is.EqualTo(v2.z));
        }
    }

}
