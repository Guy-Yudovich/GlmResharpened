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
            var ov = new gvec4<string>("((0-9)7)", "-9", "((-12)-5)", "(-12)");
            var v = ov.swizzle.xx;
            Assert.That("((0-9)7)", Is.EqualTo(v.x));
            Assert.That("((0-9)7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((5-1)-2)", "-3", "((1-1)-7)", "((34)-7)");
            var v = ov.swizzle.xxx;
            Assert.That("((5-1)-2)", Is.EqualTo(v.x));
            Assert.That("((5-1)-2)", Is.EqualTo(v.y));
            Assert.That("((5-1)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("6", "(-81)", "(62)", "-9");
            var v = ov.swizzle.xxxx;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-47)", "6", "((19)-7)");
            var v = ov.swizzle.xxxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-47)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(00)", "", "((20)4)");
            var v = ov.swizzle.xxxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-6)", "", "-6", "(-7-6)");
            var v = ov.swizzle.xxxw;
            Assert.That("(-7-6)", Is.EqualTo(v.x));
            Assert.That("(-7-6)", Is.EqualTo(v.y));
            Assert.That("(-7-6)", Is.EqualTo(v.z));
            Assert.That("(-7-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((-5-9)7)", "2", "(43)");
            var v = ov.swizzle.xxy;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((-5-9)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-99)-7)", "null", "(69)", "6");
            var v = ov.swizzle.xxyx;
            Assert.That("((-99)-7)", Is.EqualTo(v.x));
            Assert.That("((-99)-7)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-99)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-8)", "((29)-5)", "3", "(4-3)");
            var v = ov.swizzle.xxyy;
            Assert.That("(-4-8)", Is.EqualTo(v.x));
            Assert.That("(-4-8)", Is.EqualTo(v.y));
            Assert.That("((29)-5)", Is.EqualTo(v.z));
            Assert.That("((29)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-4)", "((2-3)8)", "null", "6");
            var v = ov.swizzle.xxyz;
            Assert.That("(-5-4)", Is.EqualTo(v.x));
            Assert.That("(-5-4)", Is.EqualTo(v.y));
            Assert.That("((2-3)8)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(94)", "", "(94)", "6");
            var v = ov.swizzle.xxyw;
            Assert.That("(94)", Is.EqualTo(v.x));
            Assert.That("(94)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((99)0)", "-4", "((-1-6)7)", "((-15)4)");
            var v = ov.swizzle.xxz;
            Assert.That("((99)0)", Is.EqualTo(v.x));
            Assert.That("((99)0)", Is.EqualTo(v.y));
            Assert.That("((-1-6)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-3-2)6)", "(23)", "((-84)-5)", "((-84)-5)");
            var v = ov.swizzle.xxzx;
            Assert.That("((-3-2)6)", Is.EqualTo(v.x));
            Assert.That("((-3-2)6)", Is.EqualTo(v.y));
            Assert.That("((-84)-5)", Is.EqualTo(v.z));
            Assert.That("((-3-2)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-6)8)", "null", "((7-4)-9)", "(96)");
            var v = ov.swizzle.xxzy;
            Assert.That("((-1-6)8)", Is.EqualTo(v.x));
            Assert.That("((-1-6)8)", Is.EqualTo(v.y));
            Assert.That("((7-4)-9)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-3)", "-2", "3", "((53)9)");
            var v = ov.swizzle.xxzz;
            Assert.That("(-8-3)", Is.EqualTo(v.x));
            Assert.That("(-8-3)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "(-9-3)", "9", "-2");
            var v = ov.swizzle.xxzw;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "(-98)", "((8-3)9)", "-2");
            var v = ov.swizzle.xxw;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-30)", "", "null", "(-30)");
            var v = ov.swizzle.xxwx;
            Assert.That("(-30)", Is.EqualTo(v.x));
            Assert.That("(-30)", Is.EqualTo(v.y));
            Assert.That("(-30)", Is.EqualTo(v.z));
            Assert.That("(-30)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((76)-4)", "", "9", "null");
            var v = ov.swizzle.xxwy;
            Assert.That("((76)-4)", Is.EqualTo(v.x));
            Assert.That("((76)-4)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(0-5)", "-7", "((-4-7)0)");
            var v = ov.swizzle.xxwz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-4-7)0)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "(0-5)", "((-4-5)2)", "(-36)");
            var v = ov.swizzle.xxww;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(-36)", Is.EqualTo(v.z));
            Assert.That("(-36)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-8)", "(-76)", "((-5-3)-3)", "-7");
            var v = ov.swizzle.xy;
            Assert.That("(-9-8)", Is.EqualTo(v.x));
            Assert.That("(-76)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("7", "(6-3)", "(7-6)", "-2");
            var v = ov.swizzle.xyx;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(6-3)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("7", "((-2-9)-5)", "((-8-4)5)", "(-11)");
            var v = ov.swizzle.xyxx;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((-2-9)-5)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-3)7)", "", "null", "((0-1)3)");
            var v = ov.swizzle.xyxy;
            Assert.That("((1-3)7)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((1-3)7)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-9)", "(99)", "-1", "(88)");
            var v = ov.swizzle.xyxz;
            Assert.That("(-2-9)", Is.EqualTo(v.x));
            Assert.That("(99)", Is.EqualTo(v.y));
            Assert.That("(-2-9)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((35)-4)", "(-20)", "(-20)", "-4");
            var v = ov.swizzle.xyxw;
            Assert.That("((35)-4)", Is.EqualTo(v.x));
            Assert.That("(-20)", Is.EqualTo(v.y));
            Assert.That("((35)-4)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "(-96)", "", "((3-1)-1)");
            var v = ov.swizzle.xyy;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(-96)", Is.EqualTo(v.y));
            Assert.That("(-96)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "((22)2)", "((22)2)", "1");
            var v = ov.swizzle.xyyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((22)2)", Is.EqualTo(v.y));
            Assert.That("((22)2)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-7)", "-3", "(06)", "(-1-7)");
            var v = ov.swizzle.xyyy;
            Assert.That("(-1-7)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(-2-3)", "null", "-4");
            var v = ov.swizzle.xyyz;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-2-3)", Is.EqualTo(v.y));
            Assert.That("(-2-3)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-8)", "3", "null", "3");
            var v = ov.swizzle.xyyw;
            Assert.That("(8-8)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "6", "-4", "((-5-1)-3)");
            var v = ov.swizzle.xyz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-69)0)", "((-57)-8)", "-6", "");
            var v = ov.swizzle.xyzx;
            Assert.That("((-69)0)", Is.EqualTo(v.x));
            Assert.That("((-57)-8)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((-69)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-1)8)", "((-78)-6)", "null", "(0-9)");
            var v = ov.swizzle.xyzy;
            Assert.That("((-8-1)8)", Is.EqualTo(v.x));
            Assert.That("((-78)-6)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-78)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((23)-5)", "(-53)", "0", "0");
            var v = ov.swizzle.xyzz;
            Assert.That("((23)-5)", Is.EqualTo(v.x));
            Assert.That("(-53)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(17)", "9", "((-61)-4)", "(17)");
            var v = ov.swizzle.xyzw;
            Assert.That("(17)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("((-61)-4)", Is.EqualTo(v.z));
            Assert.That("(17)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-5)5)", "null", "(1-9)", "null");
            var v = ov.swizzle.xyw;
            Assert.That("((0-5)5)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("3", "(30)", "5", "((17)-9)");
            var v = ov.swizzle.xywx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(30)", Is.EqualTo(v.y));
            Assert.That("((17)-9)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "(52)", "((-28)-6)", "((-4-8)-3)");
            var v = ov.swizzle.xywy;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(52)", Is.EqualTo(v.y));
            Assert.That("((-4-8)-3)", Is.EqualTo(v.z));
            Assert.That("(52)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-36)", "", "-2", "-7");
            var v = ov.swizzle.xywz;
            Assert.That("(-36)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(87)", "((-7-4)7)", "null", "");
            var v = ov.swizzle.xyww;
            Assert.That("(87)", Is.EqualTo(v.x));
            Assert.That("((-7-4)7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "((-19)-1)", "9", "((96)5)");
            var v = ov.swizzle.xz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((4-5)1)", "5", "(-82)", "");
            var v = ov.swizzle.xzx;
            Assert.That("((4-5)1)", Is.EqualTo(v.x));
            Assert.That("(-82)", Is.EqualTo(v.y));
            Assert.That("((4-5)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-72)", "((6-9)1)", "-8", "((6-9)1)");
            var v = ov.swizzle.xzxx;
            Assert.That("(-72)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(-72)", Is.EqualTo(v.z));
            Assert.That("(-72)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "((2-4)-9)", "((2-4)-9)", "((2-4)-9)");
            var v = ov.swizzle.xzxy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("((2-4)-9)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("((2-4)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "", "(-24)", "(-7-9)");
            var v = ov.swizzle.xzxz;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(-24)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("(-24)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "((-9-9)8)", "(-1-5)");
            var v = ov.swizzle.xzxw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-9-9)8)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-1-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-94)1)", "((-94)1)", "(9-5)", "(-8-4)");
            var v = ov.swizzle.xzy;
            Assert.That("((-94)1)", Is.EqualTo(v.x));
            Assert.That("(9-5)", Is.EqualTo(v.y));
            Assert.That("((-94)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-5-2)-1)", "((-1-2)2)", "", "(43)");
            var v = ov.swizzle.xzyx;
            Assert.That("((-5-2)-1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-1-2)2)", Is.EqualTo(v.z));
            Assert.That("((-5-2)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-8)5)", "((1-8)5)", "-8", "-8");
            var v = ov.swizzle.xzyy;
            Assert.That("((1-8)5)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("((1-8)5)", Is.EqualTo(v.z));
            Assert.That("((1-8)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((8-7)0)", "((-2-6)-4)", "((-2-6)-4)");
            var v = ov.swizzle.xzyz;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((-2-6)-4)", Is.EqualTo(v.y));
            Assert.That("((8-7)0)", Is.EqualTo(v.z));
            Assert.That("((-2-6)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-9)", "(56)", "null", "((22)6)");
            var v = ov.swizzle.xzyw;
            Assert.That("(2-9)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(56)", Is.EqualTo(v.z));
            Assert.That("((22)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-88)", "((38)9)", "(4-3)", "((38)9)");
            var v = ov.swizzle.xzz;
            Assert.That("(-88)", Is.EqualTo(v.x));
            Assert.That("(4-3)", Is.EqualTo(v.y));
            Assert.That("(4-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((26)-1)", "null", "((26)-1)", "(-3-2)");
            var v = ov.swizzle.xzzx;
            Assert.That("((26)-1)", Is.EqualTo(v.x));
            Assert.That("((26)-1)", Is.EqualTo(v.y));
            Assert.That("((26)-1)", Is.EqualTo(v.z));
            Assert.That("((26)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-88)-3)", "-4", "((-7-6)-6)", "");
            var v = ov.swizzle.xzzy;
            Assert.That("((-88)-3)", Is.EqualTo(v.x));
            Assert.That("((-7-6)-6)", Is.EqualTo(v.y));
            Assert.That("((-7-6)-6)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "(-46)", "-9", "((5-4)5)");
            var v = ov.swizzle.xzzz;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(11)", "(-7-5)", "((-36)9)", "");
            var v = ov.swizzle.xzzw;
            Assert.That("(11)", Is.EqualTo(v.x));
            Assert.That("((-36)9)", Is.EqualTo(v.y));
            Assert.That("((-36)9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(-65)", "-5", "(-65)");
            var v = ov.swizzle.xzw;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(-65)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((88)6)", "7", "(09)", "(-67)");
            var v = ov.swizzle.xzwx;
            Assert.That("((88)6)", Is.EqualTo(v.x));
            Assert.That("(09)", Is.EqualTo(v.y));
            Assert.That("(-67)", Is.EqualTo(v.z));
            Assert.That("((88)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-45)", "2", "null");
            var v = ov.swizzle.xzwy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-45)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-7)", "(84)", "(2-7)", "((-41)-8)");
            var v = ov.swizzle.xzwz;
            Assert.That("(2-7)", Is.EqualTo(v.x));
            Assert.That("(2-7)", Is.EqualTo(v.y));
            Assert.That("((-41)-8)", Is.EqualTo(v.z));
            Assert.That("(2-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-4)9)", "(-1-6)", "", "(-1-6)");
            var v = ov.swizzle.xzww;
            Assert.That("((-9-4)9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-1-6)", Is.EqualTo(v.z));
            Assert.That("(-1-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "", "-9", "-7");
            var v = ov.swizzle.xw;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("1", "(-2-3)", "((33)3)", "((3-8)4)");
            var v = ov.swizzle.xwx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((3-8)4)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("5", "((-9-1)9)", "((-9-1)9)", "6");
            var v = ov.swizzle.xwxx;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-8)", "(0-8)", "(2-1)", "(-36)");
            var v = ov.swizzle.xwxy;
            Assert.That("(0-8)", Is.EqualTo(v.x));
            Assert.That("(-36)", Is.EqualTo(v.y));
            Assert.That("(0-8)", Is.EqualTo(v.z));
            Assert.That("(0-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-2-6)", "", "((-10)3)");
            var v = ov.swizzle.xwxz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-10)3)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-3)-2)", "(20)", "((-65)0)", "((3-3)-2)");
            var v = ov.swizzle.xwxw;
            Assert.That("((3-3)-2)", Is.EqualTo(v.x));
            Assert.That("((3-3)-2)", Is.EqualTo(v.y));
            Assert.That("((3-3)-2)", Is.EqualTo(v.z));
            Assert.That("((3-3)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((54)-1)", "-3", "0", "-3");
            var v = ov.swizzle.xwy;
            Assert.That("((54)-1)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "-2", "-7", "null");
            var v = ov.swizzle.xwyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((83)8)", "", "(-9-2)", "((-46)1)");
            var v = ov.swizzle.xwyy;
            Assert.That("((83)8)", Is.EqualTo(v.x));
            Assert.That("((-46)1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-5)", "((4-9)-7)", "-1", "(61)");
            var v = ov.swizzle.xwyz;
            Assert.That("(8-5)", Is.EqualTo(v.x));
            Assert.That("(61)", Is.EqualTo(v.y));
            Assert.That("((4-9)-7)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "7", "(1-5)", "((85)-2)");
            var v = ov.swizzle.xwyw;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((85)-2)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((85)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-28)0)", "null", "((-28)0)", "((-5-3)-8)");
            var v = ov.swizzle.xwz;
            Assert.That("((-28)0)", Is.EqualTo(v.x));
            Assert.That("((-5-3)-8)", Is.EqualTo(v.y));
            Assert.That("((-28)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(8-1)", "(-4-8)", "9", "4");
            var v = ov.swizzle.xwzx;
            Assert.That("(8-1)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("(8-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-2)-2)", "", "null", "2");
            var v = ov.swizzle.xwzy;
            Assert.That("((-5-2)-2)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "null", "", "((23)-3)");
            var v = ov.swizzle.xwzz;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((23)-3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "(3-3)", "null", "-4");
            var v = ov.swizzle.xwzw;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-4)", "((1-2)0)", "", "-2");
            var v = ov.swizzle.xww;
            Assert.That("(-6-4)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-66)", "(-8-9)", "(33)", "4");
            var v = ov.swizzle.xwwx;
            Assert.That("(-66)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(-66)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-5", "5", "-5");
            var v = ov.swizzle.xwwy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "((3-4)-1)", "(15)", "(15)");
            var v = ov.swizzle.xwwz;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(15)", Is.EqualTo(v.y));
            Assert.That("(15)", Is.EqualTo(v.z));
            Assert.That("(15)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-1)", "1", "((9-1)7)", "0");
            var v = ov.swizzle.xwww;
            Assert.That("(8-1)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-2)6)", "", "0", "(-8-2)");
            var v = ov.swizzle.yx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-3-2)6)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-21)-5)", "7", "(-21)", "7");
            var v = ov.swizzle.yxx;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((-21)-5)", Is.EqualTo(v.y));
            Assert.That("((-21)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-65)-9)", "", "(-92)", "null");
            var v = ov.swizzle.yxxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-65)-9)", Is.EqualTo(v.y));
            Assert.That("((-65)-9)", Is.EqualTo(v.z));
            Assert.That("((-65)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "-4", "(-84)", "null");
            var v = ov.swizzle.yxxy;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(3-7)", "((-6-9)-7)", "(49)", "((-32)7)");
            var v = ov.swizzle.yxxz;
            Assert.That("((-6-9)-7)", Is.EqualTo(v.x));
            Assert.That("(3-7)", Is.EqualTo(v.y));
            Assert.That("(3-7)", Is.EqualTo(v.z));
            Assert.That("(49)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-4)-6)", "((8-4)-6)", "7", "(-4-1)");
            var v = ov.swizzle.yxxw;
            Assert.That("((8-4)-6)", Is.EqualTo(v.x));
            Assert.That("((8-4)-6)", Is.EqualTo(v.y));
            Assert.That("((8-4)-6)", Is.EqualTo(v.z));
            Assert.That("(-4-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "3", "3", "");
            var v = ov.swizzle.yxy;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(12)", "null", "5", "(12)");
            var v = ov.swizzle.yxyx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(12)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(12)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-99)1)", "(3-8)", "(3-8)", "((-99)1)");
            var v = ov.swizzle.yxyy;
            Assert.That("(3-8)", Is.EqualTo(v.x));
            Assert.That("((-99)1)", Is.EqualTo(v.y));
            Assert.That("(3-8)", Is.EqualTo(v.z));
            Assert.That("(3-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "6", "-7", "6");
            var v = ov.swizzle.yxyz;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((77)-4)", "null", "((-35)0)");
            var v = ov.swizzle.yxyw;
            Assert.That("((77)-4)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((77)-4)", Is.EqualTo(v.z));
            Assert.That("((-35)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-66)", "(-5-7)", "-4", "");
            var v = ov.swizzle.yxz;
            Assert.That("(-5-7)", Is.EqualTo(v.x));
            Assert.That("(-66)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-9-4)-6)", "null", "((-16)-1)", "((-9-4)-6)");
            var v = ov.swizzle.yxzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-9-4)-6)", Is.EqualTo(v.y));
            Assert.That("((-16)-1)", Is.EqualTo(v.z));
            Assert.That("((-9-4)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "(-29)", "1", "(-29)");
            var v = ov.swizzle.yxzy;
            Assert.That("(-29)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("(-29)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-4", "(08)", "-4");
            var v = ov.swizzle.yxzz;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(08)", Is.EqualTo(v.z));
            Assert.That("(08)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-73)", "((8-9)5)", "(39)", "7");
            var v = ov.swizzle.yxzw;
            Assert.That("((8-9)5)", Is.EqualTo(v.x));
            Assert.That("(-73)", Is.EqualTo(v.y));
            Assert.That("(39)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-4)9)", "(28)", "", "((0-9)7)");
            var v = ov.swizzle.yxw;
            Assert.That("(28)", Is.EqualTo(v.x));
            Assert.That("((-4-4)9)", Is.EqualTo(v.y));
            Assert.That("((0-9)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(9-3)", "", "((-26)9)", "null");
            var v = ov.swizzle.yxwx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(9-3)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(9-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-1)-4)", "((7-1)-4)", "null", "-6");
            var v = ov.swizzle.yxwy;
            Assert.That("((7-1)-4)", Is.EqualTo(v.x));
            Assert.That("((7-1)-4)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((7-1)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-33)", "", "((0-2)9)", "(40)");
            var v = ov.swizzle.yxwz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-33)", Is.EqualTo(v.y));
            Assert.That("(40)", Is.EqualTo(v.z));
            Assert.That("((0-2)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-3)-9)", "-8", "(-74)", "((8-9)-1)");
            var v = ov.swizzle.yxww;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((3-3)-9)", Is.EqualTo(v.y));
            Assert.That("((8-9)-1)", Is.EqualTo(v.z));
            Assert.That("((8-9)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(69)", "", "2", "");
            var v = ov.swizzle.yy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-9-5)-8)", "null", "((47)-2)", "null");
            var v = ov.swizzle.yyx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-9-5)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-9-1)6)", "((-9-1)6)", "null", "((5-7)-8)");
            var v = ov.swizzle.yyxx;
            Assert.That("((-9-1)6)", Is.EqualTo(v.x));
            Assert.That("((-9-1)6)", Is.EqualTo(v.y));
            Assert.That("((-9-1)6)", Is.EqualTo(v.z));
            Assert.That("((-9-1)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-5)8)", "6", "((2-5)5)", "6");
            var v = ov.swizzle.yyxy;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("((-4-5)8)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(66)", "(66)", "-6", "");
            var v = ov.swizzle.yyxz;
            Assert.That("(66)", Is.EqualTo(v.x));
            Assert.That("(66)", Is.EqualTo(v.y));
            Assert.That("(66)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-36)", "(-36)", "((-3-1)8)");
            var v = ov.swizzle.yyxw;
            Assert.That("(-36)", Is.EqualTo(v.x));
            Assert.That("(-36)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-3-1)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "6", "null", "((0-5)5)");
            var v = ov.swizzle.yyy;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-7-4)", "((-2-1)5)", "((9-3)5)", "-9");
            var v = ov.swizzle.yyyx;
            Assert.That("((-2-1)5)", Is.EqualTo(v.x));
            Assert.That("((-2-1)5)", Is.EqualTo(v.y));
            Assert.That("((-2-1)5)", Is.EqualTo(v.z));
            Assert.That("(-7-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((16)0)", "(0-3)", "1", "((16)0)");
            var v = ov.swizzle.yyyy;
            Assert.That("(0-3)", Is.EqualTo(v.x));
            Assert.That("(0-3)", Is.EqualTo(v.y));
            Assert.That("(0-3)", Is.EqualTo(v.z));
            Assert.That("(0-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((6-1)9)", "null", "4");
            var v = ov.swizzle.yyyz;
            Assert.That("((6-1)9)", Is.EqualTo(v.x));
            Assert.That("((6-1)9)", Is.EqualTo(v.y));
            Assert.That("((6-1)9)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-3)", "-8", "(4-3)", "null");
            var v = ov.swizzle.yyyw;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-2)-1)", "(04)", "(04)", "((2-2)8)");
            var v = ov.swizzle.yyz;
            Assert.That("(04)", Is.EqualTo(v.x));
            Assert.That("(04)", Is.EqualTo(v.y));
            Assert.That("(04)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(-29)", "(7-5)", "6");
            var v = ov.swizzle.yyzx;
            Assert.That("(-29)", Is.EqualTo(v.x));
            Assert.That("(-29)", Is.EqualTo(v.y));
            Assert.That("(7-5)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-3)", "-6", "((-1-4)-1)", "((-37)9)");
            var v = ov.swizzle.yyzy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("((-1-4)-1)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(02)", "(-2-4)", "null", "");
            var v = ov.swizzle.yyzz;
            Assert.That("(-2-4)", Is.EqualTo(v.x));
            Assert.That("(-2-4)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "", "((-3-3)8)", "4");
            var v = ov.swizzle.yyzw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-3-3)8)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(54)", "((-98)-7)", "null");
            var v = ov.swizzle.yyw;
            Assert.That("(54)", Is.EqualTo(v.x));
            Assert.That("(54)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-72)", "(-72)", "9", "(-72)");
            var v = ov.swizzle.yywx;
            Assert.That("(-72)", Is.EqualTo(v.x));
            Assert.That("(-72)", Is.EqualTo(v.y));
            Assert.That("(-72)", Is.EqualTo(v.z));
            Assert.That("(-72)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "0", "0", "((0-8)-7)");
            var v = ov.swizzle.yywy;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((0-8)-7)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-4)", "3", "3", "((7-1)-7)");
            var v = ov.swizzle.yywz;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((7-1)-7)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(21)", "(6-8)", "((6-3)-9)", "(6-8)");
            var v = ov.swizzle.yyww;
            Assert.That("(6-8)", Is.EqualTo(v.x));
            Assert.That("(6-8)", Is.EqualTo(v.y));
            Assert.That("(6-8)", Is.EqualTo(v.z));
            Assert.That("(6-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((6-2)-2)", "(-7-4)", "(-9-7)", "(-9-7)");
            var v = ov.swizzle.yz;
            Assert.That("(-7-4)", Is.EqualTo(v.x));
            Assert.That("(-9-7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-14)", "8", "6", "((57)4)");
            var v = ov.swizzle.yzx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(-14)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("7", "", "", "(-58)");
            var v = ov.swizzle.yzxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "8", "8", "((7-5)6)");
            var v = ov.swizzle.yzxy;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(64)", "4", "(-9-7)", "1");
            var v = ov.swizzle.yzxz;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("(-9-7)", Is.EqualTo(v.y));
            Assert.That("(64)", Is.EqualTo(v.z));
            Assert.That("(-9-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-1-7)8)", "((-2-9)9)", "((-2-9)9)");
            var v = ov.swizzle.yzxw;
            Assert.That("((-1-7)8)", Is.EqualTo(v.x));
            Assert.That("((-2-9)9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-2-9)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(20)", "0", "((8-7)8)", "null");
            var v = ov.swizzle.yzy;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((8-7)8)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("5", "(-3-2)", "(-73)", "(-3-2)");
            var v = ov.swizzle.yzyx;
            Assert.That("(-3-2)", Is.EqualTo(v.x));
            Assert.That("(-73)", Is.EqualTo(v.y));
            Assert.That("(-3-2)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((93)5)", "2", "", "(-1-3)");
            var v = ov.swizzle.yzyy;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-54)8)", "(05)", "-3", "");
            var v = ov.swizzle.yzyz;
            Assert.That("(05)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(05)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-7)", "((5-5)9)", "((5-5)9)", "((2-1)2)");
            var v = ov.swizzle.yzyw;
            Assert.That("((5-5)9)", Is.EqualTo(v.x));
            Assert.That("((5-5)9)", Is.EqualTo(v.y));
            Assert.That("((5-5)9)", Is.EqualTo(v.z));
            Assert.That("((2-1)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-7)-6)", "((3-4)-7)", "((96)9)", "1");
            var v = ov.swizzle.yzz;
            Assert.That("((3-4)-7)", Is.EqualTo(v.x));
            Assert.That("((96)9)", Is.EqualTo(v.y));
            Assert.That("((96)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-3", "", "((64)5)", "(-7-3)");
            var v = ov.swizzle.yzzx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((64)5)", Is.EqualTo(v.y));
            Assert.That("((64)5)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-27)", "((-66)-3)", "1", "-5");
            var v = ov.swizzle.yzzy;
            Assert.That("((-66)-3)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("((-66)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-4)", "-8", "((8-8)-5)", "(9-4)");
            var v = ov.swizzle.yzzz;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((8-8)-5)", Is.EqualTo(v.y));
            Assert.That("((8-8)-5)", Is.EqualTo(v.z));
            Assert.That("((8-8)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-6)1)", "(-71)", "null", "");
            var v = ov.swizzle.yzzw;
            Assert.That("(-71)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((87)2)", "-4", "-4");
            var v = ov.swizzle.yzw;
            Assert.That("((87)2)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(58)", "9", "((7-4)9)", "(-5-5)");
            var v = ov.swizzle.yzwx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((7-4)9)", Is.EqualTo(v.y));
            Assert.That("(-5-5)", Is.EqualTo(v.z));
            Assert.That("(58)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(03)", "(03)", "-7", "-8");
            var v = ov.swizzle.yzwy;
            Assert.That("(03)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("(03)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-8)", "((-2-6)-9)", "(04)", "((-2-6)-9)");
            var v = ov.swizzle.yzwz;
            Assert.That("((-2-6)-9)", Is.EqualTo(v.x));
            Assert.That("(04)", Is.EqualTo(v.y));
            Assert.That("((-2-6)-9)", Is.EqualTo(v.z));
            Assert.That("(04)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-7)", "null", "-4", "-2");
            var v = ov.swizzle.yzww;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-9)2)", "8", "((-78)-4)", "");
            var v = ov.swizzle.yw;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(65)", "((33)9)", "-8", "-8");
            var v = ov.swizzle.ywx;
            Assert.That("((33)9)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(65)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "null", "0", "9");
            var v = ov.swizzle.ywxx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "(-56)", "null", "((5-4)8)");
            var v = ov.swizzle.ywxy;
            Assert.That("(-56)", Is.EqualTo(v.x));
            Assert.That("((5-4)8)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(-56)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-25)", "((5-7)7)", "(33)", "null");
            var v = ov.swizzle.ywxz;
            Assert.That("((5-7)7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-25)", Is.EqualTo(v.z));
            Assert.That("(33)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((33)-1)", "(6-4)", "((-95)-7)", "((33)-1)");
            var v = ov.swizzle.ywxw;
            Assert.That("(6-4)", Is.EqualTo(v.x));
            Assert.That("((33)-1)", Is.EqualTo(v.y));
            Assert.That("((33)-1)", Is.EqualTo(v.z));
            Assert.That("((33)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-2)", "((-82)2)", "(-8-2)", "4");
            var v = ov.swizzle.ywy;
            Assert.That("((-82)2)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((-82)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-59)", "((1-6)-4)", "(-59)", "-9");
            var v = ov.swizzle.ywyx;
            Assert.That("((1-6)-4)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((1-6)-4)", Is.EqualTo(v.z));
            Assert.That("(-59)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-92)8)", "((8-6)-9)", "((2-8)-6)", "-2");
            var v = ov.swizzle.ywyy;
            Assert.That("((8-6)-9)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((8-6)-9)", Is.EqualTo(v.z));
            Assert.That("((8-6)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "", "");
            var v = ov.swizzle.ywyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "(2-7)", "(2-7)", "((5-9)-1)");
            var v = ov.swizzle.ywyw;
            Assert.That("(2-7)", Is.EqualTo(v.x));
            Assert.That("((5-9)-1)", Is.EqualTo(v.y));
            Assert.That("(2-7)", Is.EqualTo(v.z));
            Assert.That("((5-9)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(66)", "", "((14)8)", "");
            var v = ov.swizzle.ywz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((14)8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(8-7)", "-2", "8");
            var v = ov.swizzle.ywzx;
            Assert.That("(8-7)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(69)", "-2", "((32)7)", "(-2-8)");
            var v = ov.swizzle.ywzy;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("(-2-8)", Is.EqualTo(v.y));
            Assert.That("((32)7)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(44)", "(-39)", "((-5-3)3)");
            var v = ov.swizzle.ywzz;
            Assert.That("(44)", Is.EqualTo(v.x));
            Assert.That("((-5-3)3)", Is.EqualTo(v.y));
            Assert.That("(-39)", Is.EqualTo(v.z));
            Assert.That("(-39)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((81)4)", "((-94)-9)", "null", "-4");
            var v = ov.swizzle.ywzw;
            Assert.That("((-94)-9)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "3", "3", "((8-4)4)");
            var v = ov.swizzle.yww;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((8-4)4)", Is.EqualTo(v.y));
            Assert.That("((8-4)4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((4-2)4)", "6", "(-81)", "6");
            var v = ov.swizzle.ywwx;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("((4-2)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(83)", "((95)8)", "((95)8)");
            var v = ov.swizzle.ywwy;
            Assert.That("(83)", Is.EqualTo(v.x));
            Assert.That("((95)8)", Is.EqualTo(v.y));
            Assert.That("((95)8)", Is.EqualTo(v.z));
            Assert.That("(83)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "8", "6", "3");
            var v = ov.swizzle.ywwz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((62)5)", "7", "((73)1)", "null");
            var v = ov.swizzle.ywww;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-56)", "((4-8)-9)", "", "(-56)");
            var v = ov.swizzle.zx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-56)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("null", "(-5-2)", "", "(-5-2)");
            var v = ov.swizzle.zxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-32)", "(-2-3)", "((-4-9)-3)", "(-32)");
            var v = ov.swizzle.zxxx;
            Assert.That("((-4-9)-3)", Is.EqualTo(v.x));
            Assert.That("(-32)", Is.EqualTo(v.y));
            Assert.That("(-32)", Is.EqualTo(v.z));
            Assert.That("(-32)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-99)", "(-99)", "2", "");
            var v = ov.swizzle.zxxy;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-99)", Is.EqualTo(v.y));
            Assert.That("(-99)", Is.EqualTo(v.z));
            Assert.That("(-99)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-1)1)", "", "", "6");
            var v = ov.swizzle.zxxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((5-1)1)", Is.EqualTo(v.y));
            Assert.That("((5-1)1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(6-9)", "((-3-4)0)", "(-21)");
            var v = ov.swizzle.zxxw;
            Assert.That("((-3-4)0)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("(-21)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((18)6)", "(08)", "((0-9)1)");
            var v = ov.swizzle.zxy;
            Assert.That("(08)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((18)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(-47)", "((-15)-3)", "((3-7)5)");
            var v = ov.swizzle.zxyx;
            Assert.That("((-15)-3)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-47)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-1)", "-8", "((99)0)", "((-7-4)3)");
            var v = ov.swizzle.zxyy;
            Assert.That("((99)0)", Is.EqualTo(v.x));
            Assert.That("(-3-1)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((-4-9)4)", "null", "-1");
            var v = ov.swizzle.zxyz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((-4-9)4)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "", "(1-7)");
            var v = ov.swizzle.zxyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(1-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((41)9)", "((41)9)", "(-9-4)", "-6");
            var v = ov.swizzle.zxz;
            Assert.That("(-9-4)", Is.EqualTo(v.x));
            Assert.That("((41)9)", Is.EqualTo(v.y));
            Assert.That("(-9-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(2-1)", "null", "-5", "0");
            var v = ov.swizzle.zxzx;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("(2-1)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("(2-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(-7-3)", "((-90)-7)", "8");
            var v = ov.swizzle.zxzy;
            Assert.That("((-90)-7)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((-90)-7)", Is.EqualTo(v.z));
            Assert.That("(-7-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-13)-5)", "((-13)-5)", "6", "((23)-8)");
            var v = ov.swizzle.zxzz;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("((-13)-5)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-6)1)", "(-52)", "(-52)", "((-97)-3)");
            var v = ov.swizzle.zxzw;
            Assert.That("(-52)", Is.EqualTo(v.x));
            Assert.That("((-5-6)1)", Is.EqualTo(v.y));
            Assert.That("(-52)", Is.EqualTo(v.z));
            Assert.That("((-97)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-8)", "0", "((-44)7)", "2");
            var v = ov.swizzle.zxw;
            Assert.That("((-44)7)", Is.EqualTo(v.x));
            Assert.That("(5-8)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(48)", "(-2-5)", "null", "((72)8)");
            var v = ov.swizzle.zxwx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(48)", Is.EqualTo(v.y));
            Assert.That("((72)8)", Is.EqualTo(v.z));
            Assert.That("(48)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "(76)", "((05)-2)", "(46)");
            var v = ov.swizzle.zxwy;
            Assert.That("((05)-2)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(46)", Is.EqualTo(v.z));
            Assert.That("(76)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "8", "null", "-6");
            var v = ov.swizzle.zxwz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "-1", "", "2");
            var v = ov.swizzle.zxww;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "2", "7", "2");
            var v = ov.swizzle.zy;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-6-4)", "-9", "((6-3)-8)", "(3-8)");
            var v = ov.swizzle.zyx;
            Assert.That("((6-3)-8)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("(-6-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "-1", "((-30)4)", "-6");
            var v = ov.swizzle.zyxx;
            Assert.That("((-30)4)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "-5", "-5", "null");
            var v = ov.swizzle.zyxy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "((52)0)", "0", "null");
            var v = ov.swizzle.zyxz;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((52)0)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "-1", "3", "null");
            var v = ov.swizzle.zyxw;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-97)", "", "-1", "-7");
            var v = ov.swizzle.zyy;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(54)", "((55)-6)", "7", "-2");
            var v = ov.swizzle.zyyx;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((55)-6)", Is.EqualTo(v.y));
            Assert.That("((55)-6)", Is.EqualTo(v.z));
            Assert.That("(54)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-70)1)", "null", "(-9-4)", "null");
            var v = ov.swizzle.zyyy;
            Assert.That("(-9-4)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "-7", "-1", "((6-3)6)");
            var v = ov.swizzle.zyyz;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-2)6)", "(56)", "(-50)", "((-54)-3)");
            var v = ov.swizzle.zyyw;
            Assert.That("(-50)", Is.EqualTo(v.x));
            Assert.That("(56)", Is.EqualTo(v.y));
            Assert.That("(56)", Is.EqualTo(v.z));
            Assert.That("((-54)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-49)4)", "((-8-5)-5)", "");
            var v = ov.swizzle.zyz;
            Assert.That("((-8-5)-5)", Is.EqualTo(v.x));
            Assert.That("((-49)4)", Is.EqualTo(v.y));
            Assert.That("((-8-5)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-4", "(50)", "-4", "(57)");
            var v = ov.swizzle.zyzx;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(50)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-4)-2)", "-9", "(3-7)", "(-6-1)");
            var v = ov.swizzle.zyzy;
            Assert.That("(3-7)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("(3-7)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-3)-6)", "(0-5)", "5", "");
            var v = ov.swizzle.zyzz;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(0-5)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "(-7-1)", "(-3-7)", "((-2-6)6)");
            var v = ov.swizzle.zyzw;
            Assert.That("(-3-7)", Is.EqualTo(v.x));
            Assert.That("(-7-1)", Is.EqualTo(v.y));
            Assert.That("(-3-7)", Is.EqualTo(v.z));
            Assert.That("((-2-6)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-90)-3)", "", "((-90)-3)", "(3-3)");
            var v = ov.swizzle.zyw;
            Assert.That("((-90)-3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(3-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(12)", "-6", "8", "8");
            var v = ov.swizzle.zywx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("(12)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-82)", "((85)-1)", "(7-9)", "null");
            var v = ov.swizzle.zywy;
            Assert.That("(7-9)", Is.EqualTo(v.x));
            Assert.That("((85)-1)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((85)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "2", "1", "");
            var v = ov.swizzle.zywz;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "(7-8)", "(1-3)", "");
            var v = ov.swizzle.zyww;
            Assert.That("(1-3)", Is.EqualTo(v.x));
            Assert.That("(7-8)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "", "(06)", "");
            var v = ov.swizzle.zz;
            Assert.That("(06)", Is.EqualTo(v.x));
            Assert.That("(06)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("", "9", "9", "1");
            var v = ov.swizzle.zzx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-5", "-5", "-5", "null");
            var v = ov.swizzle.zzxx;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-3)-8)", "((-7-2)3)", "((-7-2)3)", "((-7-2)3)");
            var v = ov.swizzle.zzxy;
            Assert.That("((-7-2)3)", Is.EqualTo(v.x));
            Assert.That("((-7-2)3)", Is.EqualTo(v.y));
            Assert.That("((2-3)-8)", Is.EqualTo(v.z));
            Assert.That("((-7-2)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "", "-6", "(4-2)");
            var v = ov.swizzle.zzxz;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((37)-4)", "((-95)8)", "((-95)8)", "6");
            var v = ov.swizzle.zzxw;
            Assert.That("((-95)8)", Is.EqualTo(v.x));
            Assert.That("((-95)8)", Is.EqualTo(v.y));
            Assert.That("((37)-4)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "-7", "-7", "-7");
            var v = ov.swizzle.zzy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-76)4)", "3", "(-1-6)", "3");
            var v = ov.swizzle.zzyx;
            Assert.That("(-1-6)", Is.EqualTo(v.x));
            Assert.That("(-1-6)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("((-76)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "(-91)", "(-68)", "5");
            var v = ov.swizzle.zzyy;
            Assert.That("(-68)", Is.EqualTo(v.x));
            Assert.That("(-68)", Is.EqualTo(v.y));
            Assert.That("(-91)", Is.EqualTo(v.z));
            Assert.That("(-91)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-7)8)", "(9-1)", "((0-7)8)", "((15)-8)");
            var v = ov.swizzle.zzyz;
            Assert.That("((0-7)8)", Is.EqualTo(v.x));
            Assert.That("((0-7)8)", Is.EqualTo(v.y));
            Assert.That("(9-1)", Is.EqualTo(v.z));
            Assert.That("((0-7)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-15)", "((-63)-6)", "", "((-63)-6)");
            var v = ov.swizzle.zzyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-63)-6)", Is.EqualTo(v.z));
            Assert.That("((-63)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-4)5)", "((04)-4)", "((-1-4)5)", "7");
            var v = ov.swizzle.zzz;
            Assert.That("((-1-4)5)", Is.EqualTo(v.x));
            Assert.That("((-1-4)5)", Is.EqualTo(v.y));
            Assert.That("((-1-4)5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "", "((09)5)", "((-32)6)");
            var v = ov.swizzle.zzzx;
            Assert.That("((09)5)", Is.EqualTo(v.x));
            Assert.That("((09)5)", Is.EqualTo(v.y));
            Assert.That("((09)5)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-3)-5)", "(88)", "null", "(88)");
            var v = ov.swizzle.zzzy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(88)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((60)7)", "null", "(0-1)");
            var v = ov.swizzle.zzzz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(73)", "((6-8)5)", "3");
            var v = ov.swizzle.zzzw;
            Assert.That("((6-8)5)", Is.EqualTo(v.x));
            Assert.That("((6-8)5)", Is.EqualTo(v.y));
            Assert.That("((6-8)5)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-84)7)", "7", "(03)", "-3");
            var v = ov.swizzle.zzw;
            Assert.That("(03)", Is.EqualTo(v.x));
            Assert.That("(03)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-4-9)", "((4-4)7)", "", "(1-7)");
            var v = ov.swizzle.zzwx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(1-7)", Is.EqualTo(v.z));
            Assert.That("(-4-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "((-1-8)3)", "", "null");
            var v = ov.swizzle.zzwy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-1-8)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-7)", "(86)", "((-71)4)", "-7");
            var v = ov.swizzle.zzwz;
            Assert.That("((-71)4)", Is.EqualTo(v.x));
            Assert.That("((-71)4)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((-71)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "2", "(-7-2)", "(-7-2)");
            var v = ov.swizzle.zzww;
            Assert.That("(-7-2)", Is.EqualTo(v.x));
            Assert.That("(-7-2)", Is.EqualTo(v.y));
            Assert.That("(-7-2)", Is.EqualTo(v.z));
            Assert.That("(-7-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((58)1)", "((6-9)1)", "((58)1)");
            var v = ov.swizzle.zw;
            Assert.That("((6-9)1)", Is.EqualTo(v.x));
            Assert.That("((58)1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-8", "(-36)", "(-45)", "((-96)-1)");
            var v = ov.swizzle.zwx;
            Assert.That("(-45)", Is.EqualTo(v.x));
            Assert.That("((-96)-1)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-87)0)", "6", "", "((-5-5)-6)");
            var v = ov.swizzle.zwxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-5-5)-6)", Is.EqualTo(v.y));
            Assert.That("((-87)0)", Is.EqualTo(v.z));
            Assert.That("((-87)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((-29)2)", "null", "9");
            var v = ov.swizzle.zwxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("((-29)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-5)-8)", "(-7-1)", "null", "((-2-6)-8)");
            var v = ov.swizzle.zwxz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-2-6)-8)", Is.EqualTo(v.y));
            Assert.That("((4-5)-8)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((47)5)", "((-1-8)-3)", "", "((-1-8)-3)");
            var v = ov.swizzle.zwxw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-1-8)-3)", Is.EqualTo(v.y));
            Assert.That("((47)5)", Is.EqualTo(v.z));
            Assert.That("((-1-8)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "((13)-5)", "1", "(-6-9)");
            var v = ov.swizzle.zwy;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(-6-9)", Is.EqualTo(v.y));
            Assert.That("((13)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("9", "(5-9)", "9", "((-74)-7)");
            var v = ov.swizzle.zwyx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((-74)-7)", Is.EqualTo(v.y));
            Assert.That("(5-9)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-6)", "((3-4)9)", "((7-2)-7)", "");
            var v = ov.swizzle.zwyy;
            Assert.That("((7-2)-7)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((3-4)9)", Is.EqualTo(v.z));
            Assert.That("((3-4)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "", "(-5-1)", "((-84)5)");
            var v = ov.swizzle.zwyz;
            Assert.That("(-5-1)", Is.EqualTo(v.x));
            Assert.That("((-84)5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-5-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-33)", "((50)-1)", "-9", "");
            var v = ov.swizzle.zwyw;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((50)-1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-4)", "-1", "(-4-4)", "-1");
            var v = ov.swizzle.zwz;
            Assert.That("(-4-4)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("(-4-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-2-5)", "null", "((8-8)-5)", "-9");
            var v = ov.swizzle.zwzx;
            Assert.That("((8-8)-5)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((8-8)-5)", Is.EqualTo(v.z));
            Assert.That("(-2-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "-3", "(6-1)", "(8-3)");
            var v = ov.swizzle.zwzy;
            Assert.That("(6-1)", Is.EqualTo(v.x));
            Assert.That("(8-3)", Is.EqualTo(v.y));
            Assert.That("(6-1)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-70)-6)", "((-7-5)4)", "(-3-2)", "((9-8)-7)");
            var v = ov.swizzle.zwzz;
            Assert.That("(-3-2)", Is.EqualTo(v.x));
            Assert.That("((9-8)-7)", Is.EqualTo(v.y));
            Assert.That("(-3-2)", Is.EqualTo(v.z));
            Assert.That("(-3-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "((8-2)-5)", "null", "((-57)-2)");
            var v = ov.swizzle.zwzw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-57)-2)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-57)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-9-7)-9)", "null", "(6-1)");
            var v = ov.swizzle.zww;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(6-1)", Is.EqualTo(v.y));
            Assert.That("(6-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(2-2)", "((-36)-6)", "(-73)", "((-36)-6)");
            var v = ov.swizzle.zwwx;
            Assert.That("(-73)", Is.EqualTo(v.x));
            Assert.That("((-36)-6)", Is.EqualTo(v.y));
            Assert.That("((-36)-6)", Is.EqualTo(v.z));
            Assert.That("(2-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-3)-7)", "(-5-2)", "-6", "7");
            var v = ov.swizzle.zwwy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(-5-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(30)", "(-5-3)", "(30)");
            var v = ov.swizzle.zwwz;
            Assert.That("(-5-3)", Is.EqualTo(v.x));
            Assert.That("(30)", Is.EqualTo(v.y));
            Assert.That("(30)", Is.EqualTo(v.z));
            Assert.That("(-5-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(9-2)", "((-50)-7)", "-3");
            var v = ov.swizzle.zwww;
            Assert.That("((-50)-7)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "3", "-4", "(-31)");
            var v = ov.swizzle.wx;
            Assert.That("(-31)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-57)-9)", "-3", "(-6-4)", "((9-3)1)");
            var v = ov.swizzle.wxx;
            Assert.That("((9-3)1)", Is.EqualTo(v.x));
            Assert.That("((-57)-9)", Is.EqualTo(v.y));
            Assert.That("((-57)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-52)", "((44)-6)", "(-7-3)", "(-52)");
            var v = ov.swizzle.wxxx;
            Assert.That("(-52)", Is.EqualTo(v.x));
            Assert.That("(-52)", Is.EqualTo(v.y));
            Assert.That("(-52)", Is.EqualTo(v.z));
            Assert.That("(-52)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-56)", "", "((-4-1)5)", "8");
            var v = ov.swizzle.wxxy;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(-56)", Is.EqualTo(v.y));
            Assert.That("(-56)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(-6-9)", "((2-1)-2)", "-2");
            var v = ov.swizzle.wxxz;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("((2-1)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-2", "", "((-7-3)-5)");
            var v = ov.swizzle.wxxw;
            Assert.That("((-7-3)-5)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-7-3)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-1)6)", "", "-5", "(75)");
            var v = ov.swizzle.wxy;
            Assert.That("(75)", Is.EqualTo(v.x));
            Assert.That("((-3-1)6)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-8", "(10)", "-6", "((-87)5)");
            var v = ov.swizzle.wxyx;
            Assert.That("((-87)5)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(10)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-2)", "-5", "", "(8-3)");
            var v = ov.swizzle.wxyy;
            Assert.That("(8-3)", Is.EqualTo(v.x));
            Assert.That("(7-2)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "(-24)", "null", "(-2-1)");
            var v = ov.swizzle.wxyz;
            Assert.That("(-2-1)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(-24)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(68)", "null", "null", "-5");
            var v = ov.swizzle.wxyw;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("(68)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "((56)9)", "-5", "((-53)2)");
            var v = ov.swizzle.wxz;
            Assert.That("((-53)2)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-85)", "", "null", "((73)-8)");
            var v = ov.swizzle.wxzx;
            Assert.That("((73)-8)", Is.EqualTo(v.x));
            Assert.That("(-85)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-85)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "((47)9)", "((-5-3)-2)");
            var v = ov.swizzle.wxzy;
            Assert.That("((-5-3)-2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((47)9)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-3)", "(-7-9)", "((6-8)7)", "((6-2)9)");
            var v = ov.swizzle.wxzz;
            Assert.That("((6-2)9)", Is.EqualTo(v.x));
            Assert.That("(5-3)", Is.EqualTo(v.y));
            Assert.That("((6-8)7)", Is.EqualTo(v.z));
            Assert.That("((6-8)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(00)", "9", "(00)", "(00)");
            var v = ov.swizzle.wxzw;
            Assert.That("(00)", Is.EqualTo(v.x));
            Assert.That("(00)", Is.EqualTo(v.y));
            Assert.That("(00)", Is.EqualTo(v.z));
            Assert.That("(00)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(97)", "null", "(97)", "((-98)-9)");
            var v = ov.swizzle.wxw;
            Assert.That("((-98)-9)", Is.EqualTo(v.x));
            Assert.That("(97)", Is.EqualTo(v.y));
            Assert.That("((-98)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "((14)4)", "8", "0");
            var v = ov.swizzle.wxwx;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-6)-4)", "(-48)", "(55)", "(-22)");
            var v = ov.swizzle.wxwy;
            Assert.That("(-22)", Is.EqualTo(v.x));
            Assert.That("((3-6)-4)", Is.EqualTo(v.y));
            Assert.That("(-22)", Is.EqualTo(v.z));
            Assert.That("(-48)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-8-5)-2)", "null", "((-4-1)6)");
            var v = ov.swizzle.wxwz;
            Assert.That("((-4-1)6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-4-1)6)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-98)", "(-98)", "((3-6)9)", "");
            var v = ov.swizzle.wxww;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-98)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((2-1)0)", "-3", "(-34)");
            var v = ov.swizzle.wy;
            Assert.That("(-34)", Is.EqualTo(v.x));
            Assert.That("((2-1)0)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-3", "(-60)", "((-4-9)6)", "-3");
            var v = ov.swizzle.wyx;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(-60)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-32)", "", "(42)", "(42)");
            var v = ov.swizzle.wyxx;
            Assert.That("(42)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-32)", Is.EqualTo(v.z));
            Assert.That("(-32)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-3)", "((42)-8)", "(-1-3)", "null");
            var v = ov.swizzle.wyxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((42)-8)", Is.EqualTo(v.y));
            Assert.That("(-1-3)", Is.EqualTo(v.z));
            Assert.That("((42)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-74)", "(-4-3)", "(43)", "(43)");
            var v = ov.swizzle.wyxz;
            Assert.That("(43)", Is.EqualTo(v.x));
            Assert.That("(-4-3)", Is.EqualTo(v.y));
            Assert.That("(-74)", Is.EqualTo(v.z));
            Assert.That("(43)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((96)3)", "(-9-1)", "-5");
            var v = ov.swizzle.wyxw;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("((96)3)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((95)1)", "((-9-5)9)", "null", "((-9-5)9)");
            var v = ov.swizzle.wyy;
            Assert.That("((-9-5)9)", Is.EqualTo(v.x));
            Assert.That("((-9-5)9)", Is.EqualTo(v.y));
            Assert.That("((-9-5)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-9-9)8)", "((6-4)-5)", "((8-9)1)", "-4");
            var v = ov.swizzle.wyyx;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("((6-4)-5)", Is.EqualTo(v.y));
            Assert.That("((6-4)-5)", Is.EqualTo(v.z));
            Assert.That("((-9-9)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-80)", "", "((-4-8)-7)", "((-4-8)-7)");
            var v = ov.swizzle.wyyy;
            Assert.That("((-4-8)-7)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "((76)8)", "(38)", "0");
            var v = ov.swizzle.wyyz;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((76)8)", Is.EqualTo(v.y));
            Assert.That("((76)8)", Is.EqualTo(v.z));
            Assert.That("(38)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "1", "5", "");
            var v = ov.swizzle.wyyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((07)2)", "((-41)-9)", "(-6-7)", "null");
            var v = ov.swizzle.wyz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-41)-9)", Is.EqualTo(v.y));
            Assert.That("(-6-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(0-3)", "null", "((3-2)-8)", "");
            var v = ov.swizzle.wyzx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((3-2)-8)", Is.EqualTo(v.z));
            Assert.That("(0-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-41)", "null", "(-77)", "-8");
            var v = ov.swizzle.wyzy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-77)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "", "1", "((98)-3)");
            var v = ov.swizzle.wyzz;
            Assert.That("((98)-3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "(18)", "6", "(18)");
            var v = ov.swizzle.wyzw;
            Assert.That("(18)", Is.EqualTo(v.x));
            Assert.That("(18)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("(18)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "-7", "(99)", "");
            var v = ov.swizzle.wyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((04)-4)", "2", "-7", "(6-8)");
            var v = ov.swizzle.wywx;
            Assert.That("(6-8)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(6-8)", Is.EqualTo(v.z));
            Assert.That("((04)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(7-6)", "-3", "(3-4)");
            var v = ov.swizzle.wywy;
            Assert.That("(3-4)", Is.EqualTo(v.x));
            Assert.That("(7-6)", Is.EqualTo(v.y));
            Assert.That("(3-4)", Is.EqualTo(v.z));
            Assert.That("(7-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "((92)4)", "2");
            var v = ov.swizzle.wywz;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("((92)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-52)-1)", "((-50)1)", "null", "((-52)-1)");
            var v = ov.swizzle.wyww;
            Assert.That("((-52)-1)", Is.EqualTo(v.x));
            Assert.That("((-50)1)", Is.EqualTo(v.y));
            Assert.That("((-52)-1)", Is.EqualTo(v.z));
            Assert.That("((-52)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(25)", "9", "((-4-7)-8)", "9");
            var v = ov.swizzle.wz;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((-4-7)-8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(49)", "(49)", "((1-3)8)", "null");
            var v = ov.swizzle.wzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((1-3)8)", Is.EqualTo(v.y));
            Assert.That("(49)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-4-3)-5)", "(1-5)", "null", "-9");
            var v = ov.swizzle.wzxx;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-4-3)-5)", Is.EqualTo(v.z));
            Assert.That("((-4-3)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-51)5)", "", "2", "");
            var v = ov.swizzle.wzxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((-51)5)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "7", "((-5-6)-8)", "((-5-6)-8)");
            var v = ov.swizzle.wzxz;
            Assert.That("((-5-6)-8)", Is.EqualTo(v.x));
            Assert.That("((-5-6)-8)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((-5-6)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-4", "((8-5)5)", "((1-9)-8)");
            var v = ov.swizzle.wzxw;
            Assert.That("((1-9)-8)", Is.EqualTo(v.x));
            Assert.That("((8-5)5)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((1-9)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-7)5)", "-3", "-3", "null");
            var v = ov.swizzle.wzy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-8", "(9-6)", "null", "((90)-8)");
            var v = ov.swizzle.wzyx;
            Assert.That("((90)-8)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(9-6)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-79)", "(-79)", "-7", "((-44)-1)");
            var v = ov.swizzle.wzyy;
            Assert.That("((-44)-1)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(-79)", Is.EqualTo(v.z));
            Assert.That("(-79)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((60)3)", "-7", "((-96)0)", "(-33)");
            var v = ov.swizzle.wzyz;
            Assert.That("(-33)", Is.EqualTo(v.x));
            Assert.That("((-96)0)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((-96)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-8)", "null", "((38)3)", "(-3-1)");
            var v = ov.swizzle.wzyw;
            Assert.That("(-3-1)", Is.EqualTo(v.x));
            Assert.That("((38)3)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-3-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-50)", "((13)7)", "(-50)");
            var v = ov.swizzle.wzz;
            Assert.That("(-50)", Is.EqualTo(v.x));
            Assert.That("((13)7)", Is.EqualTo(v.y));
            Assert.That("((13)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((1-1)6)", "((7-2)-6)", "((60)-1)", "((7-2)-6)");
            var v = ov.swizzle.wzzx;
            Assert.That("((7-2)-6)", Is.EqualTo(v.x));
            Assert.That("((60)-1)", Is.EqualTo(v.y));
            Assert.That("((60)-1)", Is.EqualTo(v.z));
            Assert.That("((1-1)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-9)", "(-9-9)", "-3", "(-9-9)");
            var v = ov.swizzle.wzzy;
            Assert.That("(-9-9)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(-9-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-7)0)", "-3", "((9-6)5)", "7");
            var v = ov.swizzle.wzzz;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((9-6)5)", Is.EqualTo(v.y));
            Assert.That("((9-6)5)", Is.EqualTo(v.z));
            Assert.That("((9-6)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-4", "(3-7)", "(9-8)");
            var v = ov.swizzle.wzzw;
            Assert.That("(9-8)", Is.EqualTo(v.x));
            Assert.That("(3-7)", Is.EqualTo(v.y));
            Assert.That("(3-7)", Is.EqualTo(v.z));
            Assert.That("(9-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "((9-4)1)", "(-3-3)", "-7");
            var v = ov.swizzle.wzw;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(-3-3)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-73)-3)", "-3", "((-73)-3)", "-6");
            var v = ov.swizzle.wzwx;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((-73)-3)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((-73)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-70)1)", "(6-6)", "9", "(5-5)");
            var v = ov.swizzle.wzwy;
            Assert.That("(5-5)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("(5-5)", Is.EqualTo(v.z));
            Assert.That("(6-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "-5", "", "(28)");
            var v = ov.swizzle.wzwz;
            Assert.That("(28)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(28)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "((3-4)2)", "((-31)7)", "-5");
            var v = ov.swizzle.wzww;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("((-31)7)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((48)3)", "((48)3)", "((-1-1)-4)", "(-60)");
            var v = ov.swizzle.ww;
            Assert.That("(-60)", Is.EqualTo(v.x));
            Assert.That("(-60)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("4", "null", "", "4");
            var v = ov.swizzle.wwx;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-2-8)", "4", "4", "((-13)-4)");
            var v = ov.swizzle.wwxx;
            Assert.That("((-13)-4)", Is.EqualTo(v.x));
            Assert.That("((-13)-4)", Is.EqualTo(v.y));
            Assert.That("(-2-8)", Is.EqualTo(v.z));
            Assert.That("(-2-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "(-8-2)", "(13)", "((-1-2)9)");
            var v = ov.swizzle.wwxy;
            Assert.That("((-1-2)9)", Is.EqualTo(v.x));
            Assert.That("((-1-2)9)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(-8-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(41)", "(30)", "8", "null");
            var v = ov.swizzle.wwxz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(41)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-9)", "(-6-3)", "-6", "");
            var v = ov.swizzle.wwxw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(9-9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "((89)-8)", "(5-5)");
            var v = ov.swizzle.wwy;
            Assert.That("(5-5)", Is.EqualTo(v.x));
            Assert.That("(5-5)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "6", "(-87)", "((33)1)");
            var v = ov.swizzle.wwyx;
            Assert.That("((33)1)", Is.EqualTo(v.x));
            Assert.That("((33)1)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(81)", "", "9", "-4");
            var v = ov.swizzle.wwyy;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-1)", "-3", "(-9-1)", "((26)-9)");
            var v = ov.swizzle.wwyz;
            Assert.That("((26)-9)", Is.EqualTo(v.x));
            Assert.That("((26)-9)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(-9-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "(-5-9)", "(-96)");
            var v = ov.swizzle.wwyw;
            Assert.That("(-96)", Is.EqualTo(v.x));
            Assert.That("(-96)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-96)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(13)", "((-9-2)-5)", "(13)", "-9");
            var v = ov.swizzle.wwz;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("(13)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "8", "(-84)", "8");
            var v = ov.swizzle.wwzx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-84)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-70)-2)", "(-56)", "((-7-3)-7)", "null");
            var v = ov.swizzle.wwzy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-7-3)-7)", Is.EqualTo(v.z));
            Assert.That("(-56)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "((8-6)-6)", "((7-3)3)", "((7-3)3)");
            var v = ov.swizzle.wwzz;
            Assert.That("((7-3)3)", Is.EqualTo(v.x));
            Assert.That("((7-3)3)", Is.EqualTo(v.y));
            Assert.That("((7-3)3)", Is.EqualTo(v.z));
            Assert.That("((7-3)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-1)-9)", "(-80)", "((-5-7)-1)", "(-85)");
            var v = ov.swizzle.wwzw;
            Assert.That("(-85)", Is.EqualTo(v.x));
            Assert.That("(-85)", Is.EqualTo(v.y));
            Assert.That("((-5-7)-1)", Is.EqualTo(v.z));
            Assert.That("(-85)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "((03)6)", "((-36)-1)");
            var v = ov.swizzle.www;
            Assert.That("((-36)-1)", Is.EqualTo(v.x));
            Assert.That("((-36)-1)", Is.EqualTo(v.y));
            Assert.That("((-36)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-85)", "((9-7)0)", "-8", "((-71)1)");
            var v = ov.swizzle.wwwx;
            Assert.That("((-71)1)", Is.EqualTo(v.x));
            Assert.That("((-71)1)", Is.EqualTo(v.y));
            Assert.That("((-71)1)", Is.EqualTo(v.z));
            Assert.That("(-85)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-8)9)", "0", "((4-5)-3)", "-2");
            var v = ov.swizzle.wwwy;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-35)5)", "((-35)5)", "-6", "(90)");
            var v = ov.swizzle.wwwz;
            Assert.That("(90)", Is.EqualTo(v.x));
            Assert.That("(90)", Is.EqualTo(v.y));
            Assert.That("(90)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-8", "-1", "((-1-1)7)");
            var v = ov.swizzle.wwww;
            Assert.That("((-1-1)7)", Is.EqualTo(v.x));
            Assert.That("((-1-1)7)", Is.EqualTo(v.y));
            Assert.That("((-1-1)7)", Is.EqualTo(v.z));
            Assert.That("((-1-1)7)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec4<string>("1", "1", "", "((-95)-7)");
            var v = ov.swizzle.rr;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-98)", "((-70)-3)", "(-62)", "(-5-1)");
            var v = ov.swizzle.rrr;
            Assert.That("(-98)", Is.EqualTo(v.x));
            Assert.That("(-98)", Is.EqualTo(v.y));
            Assert.That("(-98)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-6-2)", "(-6-2)", "((-83)0)", "((8-7)8)");
            var v = ov.swizzle.rrrr;
            Assert.That("(-6-2)", Is.EqualTo(v.x));
            Assert.That("(-6-2)", Is.EqualTo(v.y));
            Assert.That("(-6-2)", Is.EqualTo(v.z));
            Assert.That("(-6-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "(-8-9)", "-3", "null");
            var v = ov.swizzle.rrrg;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("(-8-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((5-3)0)", "((0-1)-6)", "-3");
            var v = ov.swizzle.rrrb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((0-1)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "9", "((-7-3)-4)", "8");
            var v = ov.swizzle.rrra;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "null", "((-69)6)", "(78)");
            var v = ov.swizzle.rrg;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-66)", "((5-9)6)", "(87)", "((28)4)");
            var v = ov.swizzle.rrgr;
            Assert.That("(-66)", Is.EqualTo(v.x));
            Assert.That("(-66)", Is.EqualTo(v.y));
            Assert.That("((5-9)6)", Is.EqualTo(v.z));
            Assert.That("(-66)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "null", "((-9-4)-6)", "((6-3)-4)");
            var v = ov.swizzle.rrgg;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "6", "null", "(7-6)");
            var v = ov.swizzle.rrgb;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-3)", "((-25)-6)", "null", "-9");
            var v = ov.swizzle.rrga;
            Assert.That("(-1-3)", Is.EqualTo(v.x));
            Assert.That("(-1-3)", Is.EqualTo(v.y));
            Assert.That("((-25)-6)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-7)-8)", "3", "((-9-2)5)", "((-9-2)5)");
            var v = ov.swizzle.rrb;
            Assert.That("((-7-7)-8)", Is.EqualTo(v.x));
            Assert.That("((-7-7)-8)", Is.EqualTo(v.y));
            Assert.That("((-9-2)5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(55)", "2", "(55)", "((09)-1)");
            var v = ov.swizzle.rrbr;
            Assert.That("(55)", Is.EqualTo(v.x));
            Assert.That("(55)", Is.EqualTo(v.y));
            Assert.That("(55)", Is.EqualTo(v.z));
            Assert.That("(55)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "(-7-8)", "((-1-5)3)", "6");
            var v = ov.swizzle.rrbg;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("((-1-5)3)", Is.EqualTo(v.z));
            Assert.That("(-7-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-9)", "null", "-3", "((-2-1)2)");
            var v = ov.swizzle.rrbb;
            Assert.That("(-5-9)", Is.EqualTo(v.x));
            Assert.That("(-5-9)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(-30)", "((06)9)", "-7");
            var v = ov.swizzle.rrba;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("((06)9)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-9)-5)", "0", "(-9-5)", "((8-2)5)");
            var v = ov.swizzle.rra;
            Assert.That("((-8-9)-5)", Is.EqualTo(v.x));
            Assert.That("((-8-9)-5)", Is.EqualTo(v.y));
            Assert.That("((8-2)5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-52)", "null", "((-61)-1)", "0");
            var v = ov.swizzle.rrar;
            Assert.That("(-52)", Is.EqualTo(v.x));
            Assert.That("(-52)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("(-52)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-54)-6)", "null", "", "");
            var v = ov.swizzle.rrag;
            Assert.That("((-54)-6)", Is.EqualTo(v.x));
            Assert.That("((-54)-6)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-1)-8)", "4", "((-92)-6)", "4");
            var v = ov.swizzle.rrab;
            Assert.That("((2-1)-8)", Is.EqualTo(v.x));
            Assert.That("((2-1)-8)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("((-92)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-8)", "(-12)", "(5-5)", "");
            var v = ov.swizzle.rraa;
            Assert.That("(-3-8)", Is.EqualTo(v.x));
            Assert.That("(-3-8)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "(-77)", "((01)4)", "(2-3)");
            var v = ov.swizzle.rg;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(-77)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-8-2)", "((-21)-8)", "((62)-5)", "((-21)-8)");
            var v = ov.swizzle.rgr;
            Assert.That("(-8-2)", Is.EqualTo(v.x));
            Assert.That("((-21)-8)", Is.EqualTo(v.y));
            Assert.That("(-8-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((9-5)7)", "2", "(40)");
            var v = ov.swizzle.rgrr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((9-5)7)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-7)", "-8", "((-90)7)", "((7-7)-7)");
            var v = ov.swizzle.rgrg;
            Assert.That("(-6-7)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(-6-7)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((09)6)", "null", "-5", "((6-2)1)");
            var v = ov.swizzle.rgrb;
            Assert.That("((09)6)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((09)6)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-7)", "(8-2)", "((33)3)", "(8-2)");
            var v = ov.swizzle.rgra;
            Assert.That("(-2-7)", Is.EqualTo(v.x));
            Assert.That("(8-2)", Is.EqualTo(v.y));
            Assert.That("(-2-7)", Is.EqualTo(v.z));
            Assert.That("(8-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-2)", "(4-2)", "", "6");
            var v = ov.swizzle.rgg;
            Assert.That("(4-2)", Is.EqualTo(v.x));
            Assert.That("(4-2)", Is.EqualTo(v.y));
            Assert.That("(4-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-58)", "7", "-7", "((-6-7)2)");
            var v = ov.swizzle.rggr;
            Assert.That("(-58)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(-58)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-6)-1)", "-6", "1", "(09)");
            var v = ov.swizzle.rggg;
            Assert.That("((3-6)-1)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-37)9)", "((5-5)1)", "", "(-43)");
            var v = ov.swizzle.rggb;
            Assert.That("((-37)9)", Is.EqualTo(v.x));
            Assert.That("((5-5)1)", Is.EqualTo(v.y));
            Assert.That("((5-5)1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-2)", "(-4-2)", "(-4-2)", "null");
            var v = ov.swizzle.rgga;
            Assert.That("(-4-2)", Is.EqualTo(v.x));
            Assert.That("(-4-2)", Is.EqualTo(v.y));
            Assert.That("(-4-2)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-4)", "((18)-6)", "", "(5-3)");
            var v = ov.swizzle.rgb;
            Assert.That("(2-4)", Is.EqualTo(v.x));
            Assert.That("((18)-6)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-41)", "", "null", "((-8-4)2)");
            var v = ov.swizzle.rgbr;
            Assert.That("(-41)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-41)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(-28)", "((14)6)", "((-4-7)7)");
            var v = ov.swizzle.rgbg;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-28)", Is.EqualTo(v.y));
            Assert.That("((14)6)", Is.EqualTo(v.z));
            Assert.That("(-28)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(81)", "5", "(-53)", "(-49)");
            var v = ov.swizzle.rgbb;
            Assert.That("(81)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(-53)", Is.EqualTo(v.z));
            Assert.That("(-53)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-6)", "((-6-4)-2)", "(4-3)", "(-3-6)");
            var v = ov.swizzle.rgba;
            Assert.That("(-3-6)", Is.EqualTo(v.x));
            Assert.That("((-6-4)-2)", Is.EqualTo(v.y));
            Assert.That("(4-3)", Is.EqualTo(v.z));
            Assert.That("(-3-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-9)", "(-39)", "(-5-9)", "(-8-4)");
            var v = ov.swizzle.rga;
            Assert.That("(-5-9)", Is.EqualTo(v.x));
            Assert.That("(-39)", Is.EqualTo(v.y));
            Assert.That("(-8-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((73)5)", "((73)5)", "null", "(-68)");
            var v = ov.swizzle.rgar;
            Assert.That("((73)5)", Is.EqualTo(v.x));
            Assert.That("((73)5)", Is.EqualTo(v.y));
            Assert.That("(-68)", Is.EqualTo(v.z));
            Assert.That("((73)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-4", "2", "((-6-2)9)");
            var v = ov.swizzle.rgag;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((-6-2)9)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "((-2-1)-6)", "((64)-7)");
            var v = ov.swizzle.rgab;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((64)-7)", Is.EqualTo(v.z));
            Assert.That("((-2-1)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-7)", "null", "((41)4)", "(-3-7)");
            var v = ov.swizzle.rgaa;
            Assert.That("(-3-7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-3-7)", Is.EqualTo(v.z));
            Assert.That("(-3-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "(8-7)", "((67)-8)", "(-78)");
            var v = ov.swizzle.rb;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((67)-8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((2-7)-3)", "-5", "(13)", "(-28)");
            var v = ov.swizzle.rbr;
            Assert.That("((2-7)-3)", Is.EqualTo(v.x));
            Assert.That("(13)", Is.EqualTo(v.y));
            Assert.That("((2-7)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(-9-1)", "null", "((-6-9)-4)");
            var v = ov.swizzle.rbrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-7)-5)", "", "null", "(61)");
            var v = ov.swizzle.rbrg;
            Assert.That("((4-7)-5)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((4-7)-5)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "", "(18)", "-8");
            var v = ov.swizzle.rbrb;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(18)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("(18)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "0", "((-6-2)5)", "((-6-2)5)");
            var v = ov.swizzle.rbra;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((-6-2)5)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("((-6-2)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-9)", "((-6-2)-2)", "0", "null");
            var v = ov.swizzle.rbg;
            Assert.That("(-2-9)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((-6-2)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-90)0)", "(-2-8)", "(6-2)", "((2-1)6)");
            var v = ov.swizzle.rbgr;
            Assert.That("((-90)0)", Is.EqualTo(v.x));
            Assert.That("(6-2)", Is.EqualTo(v.y));
            Assert.That("(-2-8)", Is.EqualTo(v.z));
            Assert.That("((-90)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-8)-8)", "((-28)-1)", "((68)0)", "((-28)-1)");
            var v = ov.swizzle.rbgg;
            Assert.That("((4-8)-8)", Is.EqualTo(v.x));
            Assert.That("((68)0)", Is.EqualTo(v.y));
            Assert.That("((-28)-1)", Is.EqualTo(v.z));
            Assert.That("((-28)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-6)8)", "2", "8", "(-4-7)");
            var v = ov.swizzle.rbgb;
            Assert.That("((-2-6)8)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "null", "0", "((8-5)8)");
            var v = ov.swizzle.rbga;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((8-5)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-6)-5)", "-8", "(74)", "5");
            var v = ov.swizzle.rbb;
            Assert.That("((-6-6)-5)", Is.EqualTo(v.x));
            Assert.That("(74)", Is.EqualTo(v.y));
            Assert.That("(74)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(-4-9)", "-2", "null");
            var v = ov.swizzle.rbbr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "(5-1)", "1", "-8");
            var v = ov.swizzle.rbbg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("(5-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "-2", "(9-6)", "(9-6)");
            var v = ov.swizzle.rbbb;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(9-6)", Is.EqualTo(v.y));
            Assert.That("(9-6)", Is.EqualTo(v.z));
            Assert.That("(9-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-6)-3)", "2", "2", "(7-7)");
            var v = ov.swizzle.rbba;
            Assert.That("((2-6)-3)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("(7-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(19)", "null", "(1-1)", "((-39)0)");
            var v = ov.swizzle.rba;
            Assert.That("(19)", Is.EqualTo(v.x));
            Assert.That("(1-1)", Is.EqualTo(v.y));
            Assert.That("((-39)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-3-2)", "-9", "-9", "((-87)4)");
            var v = ov.swizzle.rbar;
            Assert.That("(-3-2)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((-87)4)", Is.EqualTo(v.z));
            Assert.That("(-3-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(5-8)", "-7", "(-73)");
            var v = ov.swizzle.rbag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(-73)", Is.EqualTo(v.z));
            Assert.That("(5-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((14)-9)", "(42)", "7");
            var v = ov.swizzle.rbab;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(42)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(42)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "-9", "(6-2)", "(6-2)");
            var v = ov.swizzle.rbaa;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(6-2)", Is.EqualTo(v.y));
            Assert.That("(6-2)", Is.EqualTo(v.z));
            Assert.That("(6-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-80)", "2", "1", "(-72)");
            var v = ov.swizzle.ra;
            Assert.That("(-80)", Is.EqualTo(v.x));
            Assert.That("(-72)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-5", "-5", "null", "");
            var v = ov.swizzle.rar;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-72)-3)", "(-9-4)", "((-72)-3)", "2");
            var v = ov.swizzle.rarr;
            Assert.That("((-72)-3)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((-72)-3)", Is.EqualTo(v.z));
            Assert.That("((-72)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "7", "((56)9)", "(-23)");
            var v = ov.swizzle.rarg;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(-23)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-8)-6)", "null", "(1-4)", "(-83)");
            var v = ov.swizzle.rarb;
            Assert.That("((2-8)-6)", Is.EqualTo(v.x));
            Assert.That("(-83)", Is.EqualTo(v.y));
            Assert.That("((2-8)-6)", Is.EqualTo(v.z));
            Assert.That("(1-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-14)7)", "-9", "3", "(36)");
            var v = ov.swizzle.rara;
            Assert.That("((-14)7)", Is.EqualTo(v.x));
            Assert.That("(36)", Is.EqualTo(v.y));
            Assert.That("((-14)7)", Is.EqualTo(v.z));
            Assert.That("(36)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-42)", "(43)", "((7-1)-5)");
            var v = ov.swizzle.rag;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((7-1)-5)", Is.EqualTo(v.y));
            Assert.That("(-42)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((-84)-7)", "(9-2)", "5");
            var v = ov.swizzle.ragr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("((-84)-7)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-6)", "(-2-6)", "((59)-1)", "");
            var v = ov.swizzle.ragg;
            Assert.That("(-2-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-2-6)", Is.EqualTo(v.z));
            Assert.That("(-2-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((84)-1)", "-1", "9");
            var v = ov.swizzle.ragb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("((84)-1)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "((37)5)", "(12)", "0");
            var v = ov.swizzle.raga;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((37)5)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-52)", "3", "(67)", "null");
            var v = ov.swizzle.rab;
            Assert.That("(-52)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(67)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-9", "(-6-5)", "8", "(-6-5)");
            var v = ov.swizzle.rabr;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("(-6-5)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "((-57)-5)", "((-57)-5)", "");
            var v = ov.swizzle.rabg;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-57)-5)", Is.EqualTo(v.z));
            Assert.That("((-57)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-4)4)", "-5", "((9-4)4)", "((-80)4)");
            var v = ov.swizzle.rabb;
            Assert.That("((9-4)4)", Is.EqualTo(v.x));
            Assert.That("((-80)4)", Is.EqualTo(v.y));
            Assert.That("((9-4)4)", Is.EqualTo(v.z));
            Assert.That("((9-4)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-7)", "(2-9)", "((93)-9)", "((-9-4)4)");
            var v = ov.swizzle.raba;
            Assert.That("(9-7)", Is.EqualTo(v.x));
            Assert.That("((-9-4)4)", Is.EqualTo(v.y));
            Assert.That("((93)-9)", Is.EqualTo(v.z));
            Assert.That("((-9-4)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "", "((28)6)", "((28)6)");
            var v = ov.swizzle.raa;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((28)6)", Is.EqualTo(v.y));
            Assert.That("((28)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "9", "-2", "6");
            var v = ov.swizzle.raar;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-4-6)1)", "-4", "null");
            var v = ov.swizzle.raag;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-4-6)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-1", "((-19)-8)", "");
            var v = ov.swizzle.raab;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-19)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((68)2)", "((66)-6)", "(08)", "0");
            var v = ov.swizzle.raaa;
            Assert.That("((68)2)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((38)7)", "((-73)3)", "-1");
            var v = ov.swizzle.gr;
            Assert.That("((38)7)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(76)", "null", "(76)", "(76)");
            var v = ov.swizzle.grr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(76)", Is.EqualTo(v.y));
            Assert.That("(76)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "-5", "(-5-3)", "2");
            var v = ov.swizzle.grrr;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-1)", "null", "((6-9)8)", "((-97)3)");
            var v = ov.swizzle.grrg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-6-1)", Is.EqualTo(v.y));
            Assert.That("(-6-1)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(20)", "((66)8)", "((-1-9)-1)", "null");
            var v = ov.swizzle.grrb;
            Assert.That("((66)8)", Is.EqualTo(v.x));
            Assert.That("(20)", Is.EqualTo(v.y));
            Assert.That("(20)", Is.EqualTo(v.z));
            Assert.That("((-1-9)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-6)1)", "null", "(5-3)", "(03)");
            var v = ov.swizzle.grra;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-7-6)1)", Is.EqualTo(v.y));
            Assert.That("((-7-6)1)", Is.EqualTo(v.z));
            Assert.That("(03)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-8)", "", "9", "");
            var v = ov.swizzle.grg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(6-8)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((03)2)", "(43)", "-6");
            var v = ov.swizzle.grgr;
            Assert.That("((03)2)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((03)2)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(3-2)", "-4", "", "null");
            var v = ov.swizzle.grgg;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(3-2)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-12)", "1", "0", "(-12)");
            var v = ov.swizzle.grgb;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(-12)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-1-2)-2)", "null", "((-82)8)");
            var v = ov.swizzle.grga;
            Assert.That("((-1-2)-2)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-1-2)-2)", Is.EqualTo(v.z));
            Assert.That("((-82)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "1", "", "-1");
            var v = ov.swizzle.grb;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((82)-6)", "-2", "(-97)", "((17)0)");
            var v = ov.swizzle.grbr;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((82)-6)", Is.EqualTo(v.y));
            Assert.That("(-97)", Is.EqualTo(v.z));
            Assert.That("((82)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "", "", "(77)");
            var v = ov.swizzle.grbg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-99)-7)", "", "((-99)-7)", "-9");
            var v = ov.swizzle.grbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-99)-7)", Is.EqualTo(v.y));
            Assert.That("((-99)-7)", Is.EqualTo(v.z));
            Assert.That("((-99)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-3", "7", "null");
            var v = ov.swizzle.grba;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-78)6)", "6", "-3", "-3");
            var v = ov.swizzle.gra;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("((-78)6)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((79)-5)", "(-3-3)", "null", "(39)");
            var v = ov.swizzle.grar;
            Assert.That("(-3-3)", Is.EqualTo(v.x));
            Assert.That("((79)-5)", Is.EqualTo(v.y));
            Assert.That("(39)", Is.EqualTo(v.z));
            Assert.That("((79)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "", "8", "((43)-2)");
            var v = ov.swizzle.grag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("((43)-2)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "-8", "4", "(0-9)");
            var v = ov.swizzle.grab;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("(0-9)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "null", "null", "(59)");
            var v = ov.swizzle.graa;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(59)", Is.EqualTo(v.z));
            Assert.That("(59)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-5)-4)", "((35)2)", "((-2-5)-4)", "((-2-5)-4)");
            var v = ov.swizzle.gg;
            Assert.That("((35)2)", Is.EqualTo(v.x));
            Assert.That("((35)2)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-7-8)-9)", "((-3-2)-2)", "((-7-8)-9)", "-9");
            var v = ov.swizzle.ggr;
            Assert.That("((-3-2)-2)", Is.EqualTo(v.x));
            Assert.That("((-3-2)-2)", Is.EqualTo(v.y));
            Assert.That("((-7-8)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("8", "-3", "(01)", "5");
            var v = ov.swizzle.ggrr;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-7)", "-8", "", "");
            var v = ov.swizzle.ggrg;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(9-7)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "", "((94)4)");
            var v = ov.swizzle.ggrb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "null", "(1-9)", "8");
            var v = ov.swizzle.ggra;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((00)2)", "((13)2)", "7", "((13)2)");
            var v = ov.swizzle.ggg;
            Assert.That("((13)2)", Is.EqualTo(v.x));
            Assert.That("((13)2)", Is.EqualTo(v.y));
            Assert.That("((13)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(26)", "-4", "-1", "((18)6)");
            var v = ov.swizzle.gggr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(26)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "((1-4)1)", "2", "((1-4)1)");
            var v = ov.swizzle.gggg;
            Assert.That("((1-4)1)", Is.EqualTo(v.x));
            Assert.That("((1-4)1)", Is.EqualTo(v.y));
            Assert.That("((1-4)1)", Is.EqualTo(v.z));
            Assert.That("((1-4)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((42)1)", "((-62)2)", "0");
            var v = ov.swizzle.gggb;
            Assert.That("((42)1)", Is.EqualTo(v.x));
            Assert.That("((42)1)", Is.EqualTo(v.y));
            Assert.That("((42)1)", Is.EqualTo(v.z));
            Assert.That("((-62)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-1", "4", "((4-8)6)");
            var v = ov.swizzle.ggga;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("((4-8)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(-1-8)", "", "(-1-8)");
            var v = ov.swizzle.ggb;
            Assert.That("(-1-8)", Is.EqualTo(v.x));
            Assert.That("(-1-8)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("4", "((6-9)7)", "-7", "((-65)6)");
            var v = ov.swizzle.ggbr;
            Assert.That("((6-9)7)", Is.EqualTo(v.x));
            Assert.That("((6-9)7)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((7-6)-7)", "((-7-2)-9)", "1");
            var v = ov.swizzle.ggbg;
            Assert.That("((7-6)-7)", Is.EqualTo(v.x));
            Assert.That("((7-6)-7)", Is.EqualTo(v.y));
            Assert.That("((-7-2)-9)", Is.EqualTo(v.z));
            Assert.That("((7-6)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "null", "((-3-1)7)", "(-6-3)");
            var v = ov.swizzle.ggbb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-3-1)7)", Is.EqualTo(v.z));
            Assert.That("((-3-1)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "5", "5", "((-2-2)8)");
            var v = ov.swizzle.ggba;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("((-2-2)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-8)", "null", "(44)", "-1");
            var v = ov.swizzle.gga;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(4-1)", "1", "((13)7)", "");
            var v = ov.swizzle.ggar;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(4-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "((32)0)", "null", "");
            var v = ov.swizzle.ggag;
            Assert.That("((32)0)", Is.EqualTo(v.x));
            Assert.That("((32)0)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((32)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-93)", "(-93)", "(-49)", "6");
            var v = ov.swizzle.ggab;
            Assert.That("(-93)", Is.EqualTo(v.x));
            Assert.That("(-93)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("(-49)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "((2-7)-6)", "((-50)-6)", "null");
            var v = ov.swizzle.ggaa;
            Assert.That("((2-7)-6)", Is.EqualTo(v.x));
            Assert.That("((2-7)-6)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((84)-7)", "(7-6)", "", "(7-6)");
            var v = ov.swizzle.gb;
            Assert.That("(7-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((6-5)-9)", "(0-2)", "((6-5)-9)", "(9-7)");
            var v = ov.swizzle.gbr;
            Assert.That("(0-2)", Is.EqualTo(v.x));
            Assert.That("((6-5)-9)", Is.EqualTo(v.y));
            Assert.That("((6-5)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((75)8)", "5", "(70)", "((-5-2)6)");
            var v = ov.swizzle.gbrr;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(70)", Is.EqualTo(v.y));
            Assert.That("((75)8)", Is.EqualTo(v.z));
            Assert.That("((75)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "-2", "((9-4)1)", "((5-2)-8)");
            var v = ov.swizzle.gbrg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((9-4)1)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "null", "((-65)-9)", "(63)");
            var v = ov.swizzle.gbrb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-65)-9)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((-65)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-75)", "", "(41)", "0");
            var v = ov.swizzle.gbra;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(41)", Is.EqualTo(v.y));
            Assert.That("(-75)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(-2-3)", "(-9-4)", "((40)9)");
            var v = ov.swizzle.gbg;
            Assert.That("(-2-3)", Is.EqualTo(v.x));
            Assert.That("(-9-4)", Is.EqualTo(v.y));
            Assert.That("(-2-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "-9", "(39)", "((40)-6)");
            var v = ov.swizzle.gbgr;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("(39)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(97)", "((-38)-2)", "", "-1");
            var v = ov.swizzle.gbgg;
            Assert.That("((-38)-2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-38)-2)", Is.EqualTo(v.z));
            Assert.That("((-38)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-22)", "(4-1)", "(-53)", "null");
            var v = ov.swizzle.gbgb;
            Assert.That("(4-1)", Is.EqualTo(v.x));
            Assert.That("(-53)", Is.EqualTo(v.y));
            Assert.That("(4-1)", Is.EqualTo(v.z));
            Assert.That("(-53)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "(-4-1)", "8", "(-1-8)");
            var v = ov.swizzle.gbga;
            Assert.That("(-4-1)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-4-1)", Is.EqualTo(v.z));
            Assert.That("(-1-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(51)", "((-73)7)", "(38)");
            var v = ov.swizzle.gbb;
            Assert.That("(51)", Is.EqualTo(v.x));
            Assert.That("((-73)7)", Is.EqualTo(v.y));
            Assert.That("((-73)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-5-9)9)", "(-32)", "-7", "((-45)-7)");
            var v = ov.swizzle.gbbr;
            Assert.That("(-32)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((-5-9)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-3)", "((-19)-4)", "(0-3)", "((-19)-4)");
            var v = ov.swizzle.gbbg;
            Assert.That("((-19)-4)", Is.EqualTo(v.x));
            Assert.That("(0-3)", Is.EqualTo(v.y));
            Assert.That("(0-3)", Is.EqualTo(v.z));
            Assert.That("((-19)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((72)3)", "((-28)-1)", "");
            var v = ov.swizzle.gbbb;
            Assert.That("((72)3)", Is.EqualTo(v.x));
            Assert.That("((-28)-1)", Is.EqualTo(v.y));
            Assert.That("((-28)-1)", Is.EqualTo(v.z));
            Assert.That("((-28)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-74)5)", "(97)", "-8", "5");
            var v = ov.swizzle.gbba;
            Assert.That("(97)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(25)", "(25)", "(25)");
            var v = ov.swizzle.gba;
            Assert.That("(25)", Is.EqualTo(v.x));
            Assert.That("(25)", Is.EqualTo(v.y));
            Assert.That("(25)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(9-3)", "((-1-1)-9)", "-7", "(9-3)");
            var v = ov.swizzle.gbar;
            Assert.That("((-1-1)-9)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(9-3)", Is.EqualTo(v.z));
            Assert.That("(9-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "null", "((13)1)");
            var v = ov.swizzle.gbag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((13)1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((82)5)", "((82)5)", "(5-3)", "7");
            var v = ov.swizzle.gbab;
            Assert.That("((82)5)", Is.EqualTo(v.x));
            Assert.That("(5-3)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(5-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-7)", "null", "((-73)9)", "((-73)9)");
            var v = ov.swizzle.gbaa;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-73)9)", Is.EqualTo(v.y));
            Assert.That("((-73)9)", Is.EqualTo(v.z));
            Assert.That("((-73)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-99)", "4", "(-18)", "null");
            var v = ov.swizzle.ga;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("5", "(6-5)", "((-70)-7)", "-4");
            var v = ov.swizzle.gar;
            Assert.That("(6-5)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-35)", "4", "-3", "-3");
            var v = ov.swizzle.garr;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(-35)", Is.EqualTo(v.z));
            Assert.That("(-35)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-62)9)", "-8", "", "(1-2)");
            var v = ov.swizzle.garg;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(1-2)", Is.EqualTo(v.y));
            Assert.That("((-62)9)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "null", "6", "(-60)");
            var v = ov.swizzle.garb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-60)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-1)", "(-6-9)", "-5", "6");
            var v = ov.swizzle.gara;
            Assert.That("(-6-9)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(-5-1)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "(34)", "(-3-4)", "9");
            var v = ov.swizzle.gag;
            Assert.That("(34)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("(34)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("4", "((-35)4)", "null", "null");
            var v = ov.swizzle.gagr;
            Assert.That("((-35)4)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-35)4)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "((-86)-8)", "-3", "((-9-9)5)");
            var v = ov.swizzle.gagg;
            Assert.That("((-86)-8)", Is.EqualTo(v.x));
            Assert.That("((-9-9)5)", Is.EqualTo(v.y));
            Assert.That("((-86)-8)", Is.EqualTo(v.z));
            Assert.That("((-86)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-6)", "((36)3)", "(-9-6)", "(-9-6)");
            var v = ov.swizzle.gagb;
            Assert.That("((36)3)", Is.EqualTo(v.x));
            Assert.That("(-9-6)", Is.EqualTo(v.y));
            Assert.That("((36)3)", Is.EqualTo(v.z));
            Assert.That("(-9-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-8)-7)", "((01)8)", "((9-8)-7)", "");
            var v = ov.swizzle.gaga;
            Assert.That("((01)8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((01)8)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((50)-8)", "null", "-4", "(61)");
            var v = ov.swizzle.gab;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(61)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-7-2)", "-6", "(-7-2)", "(-7-2)");
            var v = ov.swizzle.gabr;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("(-7-2)", Is.EqualTo(v.y));
            Assert.That("(-7-2)", Is.EqualTo(v.z));
            Assert.That("(-7-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "-2", "((66)-1)", "");
            var v = ov.swizzle.gabg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((66)-1)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-9)6)", "-2", "((-9-9)-9)", "(59)");
            var v = ov.swizzle.gabb;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("(59)", Is.EqualTo(v.y));
            Assert.That("((-9-9)-9)", Is.EqualTo(v.z));
            Assert.That("((-9-9)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(42)", "(61)", "((52)4)");
            var v = ov.swizzle.gaba;
            Assert.That("(42)", Is.EqualTo(v.x));
            Assert.That("((52)4)", Is.EqualTo(v.y));
            Assert.That("(61)", Is.EqualTo(v.z));
            Assert.That("((52)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-83)", "((0-9)-8)", "(-83)");
            var v = ov.swizzle.gaa;
            Assert.That("(-83)", Is.EqualTo(v.x));
            Assert.That("(-83)", Is.EqualTo(v.y));
            Assert.That("(-83)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("1", "((7-4)8)", "1", "((25)7)");
            var v = ov.swizzle.gaar;
            Assert.That("((7-4)8)", Is.EqualTo(v.x));
            Assert.That("((25)7)", Is.EqualTo(v.y));
            Assert.That("((25)7)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-2)", "", "(1-2)", "null");
            var v = ov.swizzle.gaag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "null", "", "((7-8)-3)");
            var v = ov.swizzle.gaab;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((7-8)-3)", Is.EqualTo(v.y));
            Assert.That("((7-8)-3)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((94)-2)", "((0-3)1)", "(60)", "8");
            var v = ov.swizzle.gaaa;
            Assert.That("((0-3)1)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-66)", "(-67)", "8", "((-60)-1)");
            var v = ov.swizzle.br;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(-66)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-9-1)", "8", "(3-2)", "((59)3)");
            var v = ov.swizzle.brr;
            Assert.That("(3-2)", Is.EqualTo(v.x));
            Assert.That("(-9-1)", Is.EqualTo(v.y));
            Assert.That("(-9-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(69)", "2", "((5-5)0)", "3");
            var v = ov.swizzle.brrr;
            Assert.That("((5-5)0)", Is.EqualTo(v.x));
            Assert.That("(69)", Is.EqualTo(v.y));
            Assert.That("(69)", Is.EqualTo(v.z));
            Assert.That("(69)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-6", "", "-3");
            var v = ov.swizzle.brrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-76)", "((7-5)-3)", "((-58)2)", "-4");
            var v = ov.swizzle.brrb;
            Assert.That("((-58)2)", Is.EqualTo(v.x));
            Assert.That("(-76)", Is.EqualTo(v.y));
            Assert.That("(-76)", Is.EqualTo(v.z));
            Assert.That("((-58)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-7)", "(5-1)", "(1-7)", "((0-9)1)");
            var v = ov.swizzle.brra;
            Assert.That("(1-7)", Is.EqualTo(v.x));
            Assert.That("(1-7)", Is.EqualTo(v.y));
            Assert.That("(1-7)", Is.EqualTo(v.z));
            Assert.That("((0-9)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "(-8-7)", "5", "(-35)");
            var v = ov.swizzle.brg;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(-8-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("5", "5", "null", "((09)-9)");
            var v = ov.swizzle.brgr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((63)8)", "", "(50)", "(50)");
            var v = ov.swizzle.brgg;
            Assert.That("(50)", Is.EqualTo(v.x));
            Assert.That("((63)8)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-3)-6)", "2", "((-9-6)6)", "(56)");
            var v = ov.swizzle.brgb;
            Assert.That("((-9-6)6)", Is.EqualTo(v.x));
            Assert.That("((-7-3)-6)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("((-9-6)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "-7", "((42)9)", "-1");
            var v = ov.swizzle.brga;
            Assert.That("((42)9)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((22)2)", "((22)2)", "((90)-9)");
            var v = ov.swizzle.brb;
            Assert.That("((22)2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((22)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-86)", "((53)-3)", "", "(-34)");
            var v = ov.swizzle.brbr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-86)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-86)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-8)", "(8-8)", "((-1-6)-3)", "null");
            var v = ov.swizzle.brbg;
            Assert.That("((-1-6)-3)", Is.EqualTo(v.x));
            Assert.That("(8-8)", Is.EqualTo(v.y));
            Assert.That("((-1-6)-3)", Is.EqualTo(v.z));
            Assert.That("(8-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "", "(51)", "null");
            var v = ov.swizzle.brbb;
            Assert.That("(51)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("(51)", Is.EqualTo(v.z));
            Assert.That("(51)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((-3-4)2)", "((5-3)9)", "5");
            var v = ov.swizzle.brba;
            Assert.That("((5-3)9)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((5-3)9)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "null", "(46)", "-9");
            var v = ov.swizzle.bra;
            Assert.That("(46)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-26)", "-9", "((46)-5)", "null");
            var v = ov.swizzle.brar;
            Assert.That("((46)-5)", Is.EqualTo(v.x));
            Assert.That("(-26)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-26)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "(-45)", "-9", "(-45)");
            var v = ov.swizzle.brag;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("(-45)", Is.EqualTo(v.z));
            Assert.That("(-45)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "((-97)9)", "((5-1)-8)", "((5-1)-8)");
            var v = ov.swizzle.brab;
            Assert.That("((5-1)-8)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("((5-1)-8)", Is.EqualTo(v.z));
            Assert.That("((5-1)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((33)-5)", "-6", "(-78)", "((33)-5)");
            var v = ov.swizzle.braa;
            Assert.That("(-78)", Is.EqualTo(v.x));
            Assert.That("((33)-5)", Is.EqualTo(v.y));
            Assert.That("((33)-5)", Is.EqualTo(v.z));
            Assert.That("((33)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "-6", "(56)", "((0-7)0)");
            var v = ov.swizzle.bg;
            Assert.That("(56)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-72)-1)", "-4", "-4", "((-8-6)-7)");
            var v = ov.swizzle.bgr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((-72)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-4", "", "(-79)", "-4");
            var v = ov.swizzle.bgrr;
            Assert.That("(-79)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "((-50)-3)", "1", "(0-8)");
            var v = ov.swizzle.bgrg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((-50)-3)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("((-50)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "4", "((62)8)", "((62)8)");
            var v = ov.swizzle.bgrb;
            Assert.That("((62)8)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((62)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-5", "null", "(-7-9)");
            var v = ov.swizzle.bgra;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-7-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-6)", "((3-7)-5)", "((3-7)-5)", "((-52)-5)");
            var v = ov.swizzle.bgg;
            Assert.That("((3-7)-5)", Is.EqualTo(v.x));
            Assert.That("((3-7)-5)", Is.EqualTo(v.y));
            Assert.That("((3-7)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((2-6)-9)", "(-75)", "null", "((2-6)-9)");
            var v = ov.swizzle.bggr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-75)", Is.EqualTo(v.y));
            Assert.That("(-75)", Is.EqualTo(v.z));
            Assert.That("((2-6)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-2)", "(-9-7)", "null", "((15)-5)");
            var v = ov.swizzle.bggg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-9-7)", Is.EqualTo(v.y));
            Assert.That("(-9-7)", Is.EqualTo(v.z));
            Assert.That("(-9-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-42)", "((95)2)", "null", "((55)0)");
            var v = ov.swizzle.bggb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((95)2)", Is.EqualTo(v.y));
            Assert.That("((95)2)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "-1", "", "");
            var v = ov.swizzle.bgga;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(69)", "(66)", "", "9");
            var v = ov.swizzle.bgb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(66)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(53)", "(53)", "((4-6)7)", "-7");
            var v = ov.swizzle.bgbr;
            Assert.That("((4-6)7)", Is.EqualTo(v.x));
            Assert.That("(53)", Is.EqualTo(v.y));
            Assert.That("((4-6)7)", Is.EqualTo(v.z));
            Assert.That("(53)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((59)8)", "8", "3", "(-83)");
            var v = ov.swizzle.bgbg;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "6", "null", "null");
            var v = ov.swizzle.bgbb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((6-5)0)", "(-2-5)", "null", "((6-5)0)");
            var v = ov.swizzle.bgba;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-2-5)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((6-5)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-7)", "6", "((-14)-5)", "(-62)");
            var v = ov.swizzle.bga;
            Assert.That("((-14)-5)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(-62)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-3", "(1-3)", "((71)-1)", "((71)-1)");
            var v = ov.swizzle.bgar;
            Assert.That("((71)-1)", Is.EqualTo(v.x));
            Assert.That("(1-3)", Is.EqualTo(v.y));
            Assert.That("((71)-1)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-78)", "4", "((-90)6)", "-6");
            var v = ov.swizzle.bgag;
            Assert.That("((-90)6)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "((29)-8)", "(73)", "((2-8)-2)");
            var v = ov.swizzle.bgab;
            Assert.That("(73)", Is.EqualTo(v.x));
            Assert.That("((29)-8)", Is.EqualTo(v.y));
            Assert.That("((2-8)-2)", Is.EqualTo(v.z));
            Assert.That("(73)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(5-5)", "((26)-8)", "(5-5)");
            var v = ov.swizzle.bgaa;
            Assert.That("((26)-8)", Is.EqualTo(v.x));
            Assert.That("(5-5)", Is.EqualTo(v.y));
            Assert.That("(5-5)", Is.EqualTo(v.z));
            Assert.That("(5-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(1-4)", "((-83)-2)", "8");
            var v = ov.swizzle.bb;
            Assert.That("((-83)-2)", Is.EqualTo(v.x));
            Assert.That("((-83)-2)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((8-5)-9)", "((8-5)-9)", "((75)1)", "5");
            var v = ov.swizzle.bbr;
            Assert.That("((75)1)", Is.EqualTo(v.x));
            Assert.That("((75)1)", Is.EqualTo(v.y));
            Assert.That("((8-5)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-37)0)", "(-76)", "((97)-7)", "");
            var v = ov.swizzle.bbrr;
            Assert.That("((97)-7)", Is.EqualTo(v.x));
            Assert.That("((97)-7)", Is.EqualTo(v.y));
            Assert.That("((-37)0)", Is.EqualTo(v.z));
            Assert.That("((-37)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "0", "(1-8)", "8");
            var v = ov.swizzle.bbrg;
            Assert.That("(1-8)", Is.EqualTo(v.x));
            Assert.That("(1-8)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-27)", "4", "(2-2)", "((-25)7)");
            var v = ov.swizzle.bbrb;
            Assert.That("(2-2)", Is.EqualTo(v.x));
            Assert.That("(2-2)", Is.EqualTo(v.y));
            Assert.That("(-27)", Is.EqualTo(v.z));
            Assert.That("(2-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((73)-2)", "-3", "(08)", "-5");
            var v = ov.swizzle.bbra;
            Assert.That("(08)", Is.EqualTo(v.x));
            Assert.That("(08)", Is.EqualTo(v.y));
            Assert.That("((73)-2)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-2)7)", "-9", "null", "(-22)");
            var v = ov.swizzle.bbg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "", "null", "0");
            var v = ov.swizzle.bbgr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-72)", "(31)", "((80)6)", "(-72)");
            var v = ov.swizzle.bbgg;
            Assert.That("((80)6)", Is.EqualTo(v.x));
            Assert.That("((80)6)", Is.EqualTo(v.y));
            Assert.That("(31)", Is.EqualTo(v.z));
            Assert.That("(31)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "((-70)-2)", "((-7-1)9)");
            var v = ov.swizzle.bbgb;
            Assert.That("((-70)-2)", Is.EqualTo(v.x));
            Assert.That("((-70)-2)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-70)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "((92)8)", "", "8");
            var v = ov.swizzle.bbga;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((92)8)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-38)", "-5", "null", "(-73)");
            var v = ov.swizzle.bbb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(8-7)", "-2", "");
            var v = ov.swizzle.bbbr;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-24)-7)", "(5-9)", "((-7-4)-6)", "((-35)7)");
            var v = ov.swizzle.bbbg;
            Assert.That("((-7-4)-6)", Is.EqualTo(v.x));
            Assert.That("((-7-4)-6)", Is.EqualTo(v.y));
            Assert.That("((-7-4)-6)", Is.EqualTo(v.z));
            Assert.That("(5-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-1)", "(-3-1)", "-7", "((7-3)-5)");
            var v = ov.swizzle.bbbb;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-5)5)", "(4-5)", "-9", "-8");
            var v = ov.swizzle.bbba;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(63)", "-4", "(-80)", "((29)7)");
            var v = ov.swizzle.bba;
            Assert.That("(-80)", Is.EqualTo(v.x));
            Assert.That("(-80)", Is.EqualTo(v.y));
            Assert.That("((29)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((08)8)", "((08)8)", "", "((3-5)3)");
            var v = ov.swizzle.bbar;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((3-5)3)", Is.EqualTo(v.z));
            Assert.That("((08)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "2", "2", "(9-2)");
            var v = ov.swizzle.bbag;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(9-2)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((62)-1)", "((-49)9)", "8", "(92)");
            var v = ov.swizzle.bbab;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(92)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(02)", "((54)-1)", "(02)", "((9-8)9)");
            var v = ov.swizzle.bbaa;
            Assert.That("(02)", Is.EqualTo(v.x));
            Assert.That("(02)", Is.EqualTo(v.y));
            Assert.That("((9-8)9)", Is.EqualTo(v.z));
            Assert.That("((9-8)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(55)", "8", "(11)", "(55)");
            var v = ov.swizzle.ba;
            Assert.That("(11)", Is.EqualTo(v.x));
            Assert.That("(55)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(04)", "null", "(-61)", "6");
            var v = ov.swizzle.bar;
            Assert.That("(-61)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(04)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-51)", "-8", "(2-5)", "((-5-7)-9)");
            var v = ov.swizzle.barr;
            Assert.That("(2-5)", Is.EqualTo(v.x));
            Assert.That("((-5-7)-9)", Is.EqualTo(v.y));
            Assert.That("(-51)", Is.EqualTo(v.z));
            Assert.That("(-51)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-7)-7)", "(-65)", "1", "null");
            var v = ov.swizzle.barg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-7-7)-7)", Is.EqualTo(v.z));
            Assert.That("(-65)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-18)", "-5", "(0-5)", "(0-5)");
            var v = ov.swizzle.barb;
            Assert.That("(0-5)", Is.EqualTo(v.x));
            Assert.That("(0-5)", Is.EqualTo(v.y));
            Assert.That("(-18)", Is.EqualTo(v.z));
            Assert.That("(0-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(5-5)", "null", "(5-5)");
            var v = ov.swizzle.bara;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(5-5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(5-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-4)8)", "((9-4)8)", "null", "(-94)");
            var v = ov.swizzle.bag;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-94)", Is.EqualTo(v.y));
            Assert.That("((9-4)8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("6", "(62)", "0", "((-7-3)6)");
            var v = ov.swizzle.bagr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((-7-3)6)", Is.EqualTo(v.y));
            Assert.That("(62)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-6-4)-2)", "((-6-4)-2)", "(-20)");
            var v = ov.swizzle.bagg;
            Assert.That("((-6-4)-2)", Is.EqualTo(v.x));
            Assert.That("(-20)", Is.EqualTo(v.y));
            Assert.That("((-6-4)-2)", Is.EqualTo(v.z));
            Assert.That("((-6-4)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(38)", "(7-9)", "", "((-7-2)0)");
            var v = ov.swizzle.bagb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-7-2)0)", Is.EqualTo(v.y));
            Assert.That("(7-9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "null", "(-3-7)", "(3-6)");
            var v = ov.swizzle.baga;
            Assert.That("(-3-7)", Is.EqualTo(v.x));
            Assert.That("(3-6)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(3-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((-2-9)-8)", "null", "6");
            var v = ov.swizzle.bab;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-3", "((30)-8)", "(90)", "((6-8)-5)");
            var v = ov.swizzle.babr;
            Assert.That("(90)", Is.EqualTo(v.x));
            Assert.That("((6-8)-5)", Is.EqualTo(v.y));
            Assert.That("(90)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "(55)", "null", "null");
            var v = ov.swizzle.babg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(55)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-7-8)7)", "(-5-8)", "(-5-8)");
            var v = ov.swizzle.babb;
            Assert.That("(-5-8)", Is.EqualTo(v.x));
            Assert.That("(-5-8)", Is.EqualTo(v.y));
            Assert.That("(-5-8)", Is.EqualTo(v.z));
            Assert.That("(-5-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-6)", "2", "(-7-8)", "2");
            var v = ov.swizzle.baba;
            Assert.That("(-7-8)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(-7-8)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-51)", "null", "((-29)-1)", "(-51)");
            var v = ov.swizzle.baa;
            Assert.That("((-29)-1)", Is.EqualTo(v.x));
            Assert.That("(-51)", Is.EqualTo(v.y));
            Assert.That("(-51)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(4-2)", "(42)", "1", "(-96)");
            var v = ov.swizzle.baar;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(-96)", Is.EqualTo(v.y));
            Assert.That("(-96)", Is.EqualTo(v.z));
            Assert.That("(4-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-91)", "(-91)", "null", "8");
            var v = ov.swizzle.baag;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("(-91)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "(-51)", "(-5-9)", "4");
            var v = ov.swizzle.baab;
            Assert.That("(-5-9)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(-5-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-1-9)", "", "");
            var v = ov.swizzle.baaa;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-3-6)", "(51)", "((6-2)-5)");
            var v = ov.swizzle.ar;
            Assert.That("((6-2)-5)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-96)7)", "((-96)7)", "(14)", "(14)");
            var v = ov.swizzle.arr;
            Assert.That("(14)", Is.EqualTo(v.x));
            Assert.That("((-96)7)", Is.EqualTo(v.y));
            Assert.That("((-96)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-3-3)3)", "(-2-6)", "2", "((2-3)-7)");
            var v = ov.swizzle.arrr;
            Assert.That("((2-3)-7)", Is.EqualTo(v.x));
            Assert.That("((-3-3)3)", Is.EqualTo(v.y));
            Assert.That("((-3-3)3)", Is.EqualTo(v.z));
            Assert.That("((-3-3)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-6)-4)", "(-7-3)", "", "(-7-3)");
            var v = ov.swizzle.arrg;
            Assert.That("(-7-3)", Is.EqualTo(v.x));
            Assert.That("((8-6)-4)", Is.EqualTo(v.y));
            Assert.That("((8-6)-4)", Is.EqualTo(v.z));
            Assert.That("(-7-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-9)", "((-3-7)-5)", "", "");
            var v = ov.swizzle.arrb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-3-9)", Is.EqualTo(v.y));
            Assert.That("(-3-9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(3-3)", "-3", "-3", "-3");
            var v = ov.swizzle.arra;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(3-3)", Is.EqualTo(v.y));
            Assert.That("(3-3)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((49)-8)", "-6", "-6");
            var v = ov.swizzle.arg;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((49)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("6", "6", "((57)5)", "6");
            var v = ov.swizzle.argr;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "", "((19)-2)", "-1");
            var v = ov.swizzle.argg;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "((-4-2)-9)", "-1", "(48)");
            var v = ov.swizzle.argb;
            Assert.That("(48)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((-4-2)-9)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "-5", "-5", "3");
            var v = ov.swizzle.arga;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-5)", "(-26)", "((15)-6)", "");
            var v = ov.swizzle.arb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(6-5)", Is.EqualTo(v.y));
            Assert.That("((15)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(50)", "", "", "(62)");
            var v = ov.swizzle.arbr;
            Assert.That("(62)", Is.EqualTo(v.x));
            Assert.That("(50)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(50)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-6)", "((03)2)", "(8-6)", "(85)");
            var v = ov.swizzle.arbg;
            Assert.That("(85)", Is.EqualTo(v.x));
            Assert.That("(8-6)", Is.EqualTo(v.y));
            Assert.That("(8-6)", Is.EqualTo(v.z));
            Assert.That("((03)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-9)", "((-6-7)-8)", "2", "5");
            var v = ov.swizzle.arbb;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(9-9)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "3", "((13)1)");
            var v = ov.swizzle.arba;
            Assert.That("((13)1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("((13)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "(30)", "(-99)", "(-99)");
            var v = ov.swizzle.ara;
            Assert.That("(-99)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(-99)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-9-6)-6)", "(13)", "-4", "(4-5)");
            var v = ov.swizzle.arar;
            Assert.That("(4-5)", Is.EqualTo(v.x));
            Assert.That("((-9-6)-6)", Is.EqualTo(v.y));
            Assert.That("(4-5)", Is.EqualTo(v.z));
            Assert.That("((-9-6)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((28)3)", "(10)", "((28)3)", "-9");
            var v = ov.swizzle.arag;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((28)3)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("(10)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "-3", "7", "(0-9)");
            var v = ov.swizzle.arab;
            Assert.That("(0-9)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(0-9)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "((3-8)2)", "(-99)", "-2");
            var v = ov.swizzle.araa;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-17)", "8", "");
            var v = ov.swizzle.ag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-17)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("7", "((40)7)", "null", "-6");
            var v = ov.swizzle.agr;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((40)7)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((66)0)", "7", "", "null");
            var v = ov.swizzle.agrr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("((66)0)", Is.EqualTo(v.z));
            Assert.That("((66)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "-2", "(0-5)", "-2");
            var v = ov.swizzle.agrg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-2)", "", "null", "((2-6)-6)");
            var v = ov.swizzle.agrb;
            Assert.That("((2-6)-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(9-2)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-4)-7)", "((-2-4)-9)", "-3", "(-3-5)");
            var v = ov.swizzle.agra;
            Assert.That("(-3-5)", Is.EqualTo(v.x));
            Assert.That("((-2-4)-9)", Is.EqualTo(v.y));
            Assert.That("((-7-4)-7)", Is.EqualTo(v.z));
            Assert.That("(-3-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "((38)-5)", "1", "1");
            var v = ov.swizzle.agg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((38)-5)", Is.EqualTo(v.y));
            Assert.That("((38)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-2", "-2", "null", "-1");
            var v = ov.swizzle.aggr;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((25)-5)", "(1-6)", "((25)-5)", "");
            var v = ov.swizzle.aggg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(1-6)", Is.EqualTo(v.y));
            Assert.That("(1-6)", Is.EqualTo(v.z));
            Assert.That("(1-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-1)0)", "(-39)", "7", "(-3-7)");
            var v = ov.swizzle.aggb;
            Assert.That("(-3-7)", Is.EqualTo(v.x));
            Assert.That("(-39)", Is.EqualTo(v.y));
            Assert.That("(-39)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-87)", "(-87)", "((24)6)", "(-87)");
            var v = ov.swizzle.agga;
            Assert.That("(-87)", Is.EqualTo(v.x));
            Assert.That("(-87)", Is.EqualTo(v.y));
            Assert.That("(-87)", Is.EqualTo(v.z));
            Assert.That("(-87)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "((-16)-4)", "8", "(-28)");
            var v = ov.swizzle.agb;
            Assert.That("(-28)", Is.EqualTo(v.x));
            Assert.That("((-16)-4)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-7-3)4)", "(03)", "5", "(-9-9)");
            var v = ov.swizzle.agbr;
            Assert.That("(-9-9)", Is.EqualTo(v.x));
            Assert.That("(03)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("((-7-3)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "5", "(16)", "5");
            var v = ov.swizzle.agbg;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(16)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-6)-8)", "(-7-3)", "-7", "((8-2)6)");
            var v = ov.swizzle.agbb;
            Assert.That("((8-2)6)", Is.EqualTo(v.x));
            Assert.That("(-7-3)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "null", "-7", "((5-9)-1)");
            var v = ov.swizzle.agba;
            Assert.That("((5-9)-1)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((5-9)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((16)-8)", "-6", "(5-1)", "3");
            var v = ov.swizzle.aga;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((2-4)9)", "(-4-6)", "3", "(87)");
            var v = ov.swizzle.agar;
            Assert.That("(87)", Is.EqualTo(v.x));
            Assert.That("(-4-6)", Is.EqualTo(v.y));
            Assert.That("(87)", Is.EqualTo(v.z));
            Assert.That("((2-4)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "((-67)1)", "null", "((1-2)-6)");
            var v = ov.swizzle.agag;
            Assert.That("((1-2)-6)", Is.EqualTo(v.x));
            Assert.That("((-67)1)", Is.EqualTo(v.y));
            Assert.That("((1-2)-6)", Is.EqualTo(v.z));
            Assert.That("((-67)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-74)4)", "((-74)4)", "((-90)-3)");
            var v = ov.swizzle.agab;
            Assert.That("((-90)-3)", Is.EqualTo(v.x));
            Assert.That("((-74)4)", Is.EqualTo(v.y));
            Assert.That("((-90)-3)", Is.EqualTo(v.z));
            Assert.That("((-74)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-14)4)", "((-14)4)", "(-67)");
            var v = ov.swizzle.agaa;
            Assert.That("(-67)", Is.EqualTo(v.x));
            Assert.That("((-14)4)", Is.EqualTo(v.y));
            Assert.That("(-67)", Is.EqualTo(v.z));
            Assert.That("(-67)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-18)", "(77)", "(77)", "9");
            var v = ov.swizzle.ab;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(77)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((30)-6)", "((-5-9)7)", "((-5-9)7)", "(-45)");
            var v = ov.swizzle.abr;
            Assert.That("(-45)", Is.EqualTo(v.x));
            Assert.That("((-5-9)7)", Is.EqualTo(v.y));
            Assert.That("((30)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-7-9)-8)", "", "((06)-7)", "4");
            var v = ov.swizzle.abrr;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((06)-7)", Is.EqualTo(v.y));
            Assert.That("((-7-9)-8)", Is.EqualTo(v.z));
            Assert.That("((-7-9)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((09)-8)", "((9-1)-7)", "((9-1)-7)", "");
            var v = ov.swizzle.abrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((9-1)-7)", Is.EqualTo(v.y));
            Assert.That("((09)-8)", Is.EqualTo(v.z));
            Assert.That("((9-1)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-50)", "", "2", "-5");
            var v = ov.swizzle.abrb;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(-50)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-43)", "2", "");
            var v = ov.swizzle.abra;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-6)", "(7-7)", "((59)-3)", "-2");
            var v = ov.swizzle.abg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((59)-3)", Is.EqualTo(v.y));
            Assert.That("(7-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "2", "", "0");
            var v = ov.swizzle.abgr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-1)-3)", "", "(-9-2)", "(-68)");
            var v = ov.swizzle.abgg;
            Assert.That("(-68)", Is.EqualTo(v.x));
            Assert.That("(-9-2)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-2)", "((-36)-7)", "0", "-3");
            var v = ov.swizzle.abgb;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((-36)-7)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-8)", "null", "(-4-6)", "(94)");
            var v = ov.swizzle.abga;
            Assert.That("(94)", Is.EqualTo(v.x));
            Assert.That("(-4-6)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(94)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((70)-3)", "((19)-3)", "");
            var v = ov.swizzle.abb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((19)-3)", Is.EqualTo(v.y));
            Assert.That("((19)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "", "", "3");
            var v = ov.swizzle.abbr;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "(11)", "3", "(11)");
            var v = ov.swizzle.abbg;
            Assert.That("(11)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("(11)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-9)", "((3-7)-5)", "-3", "-2");
            var v = ov.swizzle.abbb;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "((-81)-7)", "1");
            var v = ov.swizzle.abba;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((-81)-7)", Is.EqualTo(v.y));
            Assert.That("((-81)-7)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-58)-8)", "(-16)", "3", "null");
            var v = ov.swizzle.aba;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-90)2)", "-1", "((-90)2)", "-1");
            var v = ov.swizzle.abar;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((-90)2)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("((-90)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-5)7)", "", "((37)6)", "-9");
            var v = ov.swizzle.abag;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((37)6)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(75)", "((41)6)", "(-57)", "((-47)8)");
            var v = ov.swizzle.abab;
            Assert.That("((-47)8)", Is.EqualTo(v.x));
            Assert.That("(-57)", Is.EqualTo(v.y));
            Assert.That("((-47)8)", Is.EqualTo(v.z));
            Assert.That("(-57)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "((-6-1)-7)", "((1-9)-1)", "null");
            var v = ov.swizzle.abaa;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((1-9)-1)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(12)", "((0-8)-2)", "0");
            var v = ov.swizzle.aa;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("1", "((37)1)", "(48)", "((-1-8)2)");
            var v = ov.swizzle.aar;
            Assert.That("((-1-8)2)", Is.EqualTo(v.x));
            Assert.That("((-1-8)2)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((6-4)5)", "null", "(35)", "null");
            var v = ov.swizzle.aarr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((6-4)5)", Is.EqualTo(v.z));
            Assert.That("((6-4)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-2)", "0", "(84)", "(64)");
            var v = ov.swizzle.aarg;
            Assert.That("(64)", Is.EqualTo(v.x));
            Assert.That("(64)", Is.EqualTo(v.y));
            Assert.That("(-8-2)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-14)-1)", "7", "4");
            var v = ov.swizzle.aarb;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "(-97)", "null", "");
            var v = ov.swizzle.aara;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "-9", "", "9");
            var v = ov.swizzle.aag;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "", "((61)2)", "6");
            var v = ov.swizzle.aagr;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((5-8)-1)", "(-3-7)", "((54)7)");
            var v = ov.swizzle.aagg;
            Assert.That("((54)7)", Is.EqualTo(v.x));
            Assert.That("((54)7)", Is.EqualTo(v.y));
            Assert.That("((5-8)-1)", Is.EqualTo(v.z));
            Assert.That("((5-8)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-6)-2)", "-8", "((7-6)7)", "0");
            var v = ov.swizzle.aagb;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("((7-6)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-8)", "", "null", "(2-9)");
            var v = ov.swizzle.aaga;
            Assert.That("(2-9)", Is.EqualTo(v.x));
            Assert.That("(2-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(2-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "", "((12)-7)");
            var v = ov.swizzle.aab;
            Assert.That("((12)-7)", Is.EqualTo(v.x));
            Assert.That("((12)-7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-8-3)", "", "((08)8)", "(6-2)");
            var v = ov.swizzle.aabr;
            Assert.That("(6-2)", Is.EqualTo(v.x));
            Assert.That("(6-2)", Is.EqualTo(v.y));
            Assert.That("((08)8)", Is.EqualTo(v.z));
            Assert.That("(-8-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-53)", "(-53)", "((-7-5)-9)", "null");
            var v = ov.swizzle.aabg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-7-5)-9)", Is.EqualTo(v.z));
            Assert.That("(-53)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-1)", "0", "8", "(2-2)");
            var v = ov.swizzle.aabb;
            Assert.That("(2-2)", Is.EqualTo(v.x));
            Assert.That("(2-2)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((1-2)8)", "7", "-5");
            var v = ov.swizzle.aaba;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((35)7)", "", "", "(2-8)");
            var v = ov.swizzle.aaa;
            Assert.That("(2-8)", Is.EqualTo(v.x));
            Assert.That("(2-8)", Is.EqualTo(v.y));
            Assert.That("(2-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("8", "null", "null", "null");
            var v = ov.swizzle.aaar;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-50)5)", "-5", "(-5-6)", "-2");
            var v = ov.swizzle.aaag;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(07)", "((0-2)-1)", "0");
            var v = ov.swizzle.aaab;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("((0-2)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "5", "(90)");
            var v = ov.swizzle.aaaa;
            Assert.That("(90)", Is.EqualTo(v.x));
            Assert.That("(90)", Is.EqualTo(v.y));
            Assert.That("(90)", Is.EqualTo(v.z));
            Assert.That("(90)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec4<string>("((39)1)", "((39)1)", "", "((0-6)6)");
            var v1 = new gvec2<string>("((0-3)3)", "9");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((0-3)3)", Is.EqualTo(v0.x));
            Assert.That("9", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That("((0-6)6)", Is.EqualTo(v0.w));
        
            Assert.That("((39)1)", Is.EqualTo(v2.x));
            Assert.That("((39)1)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((-6-6)-3)", "7", "((95)3)", "(5-4)");
            var v1 = new gvec2<string>("((7-4)8)", "(5-4)");
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((7-4)8)", Is.EqualTo(v0.x));
            Assert.That("7", Is.EqualTo(v0.y));
            Assert.That("(5-4)", Is.EqualTo(v0.z));
            Assert.That("(5-4)", Is.EqualTo(v0.w));
        
            Assert.That("((-6-6)-3)", Is.EqualTo(v2.x));
            Assert.That("((95)3)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(-54)", "4", "", "(-54)");
            var v1 = new gvec2<string>("-6", "null");
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-54)", Is.EqualTo(v0.x));
            Assert.That("-6", Is.EqualTo(v0.y));
            Assert.That("null", Is.EqualTo(v0.z));
            Assert.That("(-54)", Is.EqualTo(v0.w));
        
            Assert.That("4", Is.EqualTo(v2.x));
            Assert.That("", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((8-5)-3)", "null", "8", "(-6-3)");
            var v1 = new gvec3<string>("9", "", "((3-9)-8)");
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("9", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("((3-9)-8)", Is.EqualTo(v0.z));
            Assert.That("(-6-3)", Is.EqualTo(v0.w));
        
            Assert.That("((8-5)-3)", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
            Assert.That("8", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(0-5)", "((-33)1)", "", "((43)3)");
            var v1 = new gvec2<string>("((03)7)", "(-45)");
            var v2 = v0.xw;
            v0.xw = v1;
            var v3 = v0.xw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((03)7)", Is.EqualTo(v0.x));
            Assert.That("((-33)1)", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That("(-45)", Is.EqualTo(v0.w));
        
            Assert.That("(0-5)", Is.EqualTo(v2.x));
            Assert.That("((43)3)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(9-8)", "", "6", "(-31)");
            var v1 = new gvec2<string>("(-5-3)", "-4");
            var v2 = v0.yw;
            v0.yw = v1;
            var v3 = v0.yw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(9-8)", Is.EqualTo(v0.x));
            Assert.That("(-5-3)", Is.EqualTo(v0.y));
            Assert.That("6", Is.EqualTo(v0.z));
            Assert.That("-4", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("(-31)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("-6", "null", "", "(-7-9)");
            var v1 = new gvec3<string>("", "((35)5)", "(95)");
            var v2 = v0.xyw;
            v0.xyw = v1;
            var v3 = v0.xyw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("((35)5)", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That("(95)", Is.EqualTo(v0.w));
        
            Assert.That("-6", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
            Assert.That("(-7-9)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(0-8)", "(0-8)", "5", "null");
            var v1 = new gvec2<string>("(0-3)", "((-63)-5)");
            var v2 = v0.zw;
            v0.zw = v1;
            var v3 = v0.zw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(0-8)", Is.EqualTo(v0.x));
            Assert.That("(0-8)", Is.EqualTo(v0.y));
            Assert.That("(0-3)", Is.EqualTo(v0.z));
            Assert.That("((-63)-5)", Is.EqualTo(v0.w));
        
            Assert.That("5", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(05)", "((-2-2)2)", "(98)", "(0-8)");
            var v1 = new gvec3<string>("-9", "(04)", "-7");
            var v2 = v0.xzw;
            v0.xzw = v1;
            var v3 = v0.xzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-9", Is.EqualTo(v0.x));
            Assert.That("((-2-2)2)", Is.EqualTo(v0.y));
            Assert.That("(04)", Is.EqualTo(v0.z));
            Assert.That("-7", Is.EqualTo(v0.w));
        
            Assert.That("(05)", Is.EqualTo(v2.x));
            Assert.That("(98)", Is.EqualTo(v2.y));
            Assert.That("(0-8)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(46)", "null", "1", "(55)");
            var v1 = new gvec3<string>("(-6-4)", "-8", "(-35)");
            var v2 = v0.yzw;
            v0.yzw = v1;
            var v3 = v0.yzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(46)", Is.EqualTo(v0.x));
            Assert.That("(-6-4)", Is.EqualTo(v0.y));
            Assert.That("-8", Is.EqualTo(v0.z));
            Assert.That("(-35)", Is.EqualTo(v0.w));
        
            Assert.That("null", Is.EqualTo(v2.x));
            Assert.That("1", Is.EqualTo(v2.y));
            Assert.That("(55)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(03)", "((35)3)", "-3", "-3");
            var v1 = new gvec4<string>("(-5-1)", "(1-3)", "", "(1-3)");
            var v2 = v0.xyzw;
            v0.xyzw = v1;
            var v3 = v0.xyzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-5-1)", Is.EqualTo(v0.x));
            Assert.That("(1-3)", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That("(1-3)", Is.EqualTo(v0.w));
        
            Assert.That("(03)", Is.EqualTo(v2.x));
            Assert.That("((35)3)", Is.EqualTo(v2.y));
            Assert.That("-3", Is.EqualTo(v2.z));
            Assert.That("-3", Is.EqualTo(v2.w));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new gvec4<string>("(45)", "null", "-2", "");
            var v1 = "(5-1)";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(5-1)", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("-2", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("(45)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("null", "", "null", "((-5-6)-1)");
            var v1 = "(7-9)";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("(7-9)", Is.EqualTo(v0.y));
            Assert.That("null", Is.EqualTo(v0.z));
            Assert.That("((-5-6)-1)", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("", "", "4", "((6-7)2)");
            var v1 = new gvec2<string>("-6", "(-3-9)");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-6", Is.EqualTo(v0.x));
            Assert.That("(-3-9)", Is.EqualTo(v0.y));
            Assert.That("4", Is.EqualTo(v0.z));
            Assert.That("((6-7)2)", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((5-6)-9)", "((5-6)-9)", "(-5-1)", "null");
            var v1 = "null";
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((5-6)-9)", Is.EqualTo(v0.x));
            Assert.That("((5-6)-9)", Is.EqualTo(v0.y));
            Assert.That("null", Is.EqualTo(v0.z));
            Assert.That("null", Is.EqualTo(v0.w));
        
            Assert.That("(-5-1)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("", "0", "(-8-6)", "(-5-7)");
            var v1 = new gvec2<string>("-4", "((-48)6)");
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-4", Is.EqualTo(v0.x));
            Assert.That("0", Is.EqualTo(v0.y));
            Assert.That("((-48)6)", Is.EqualTo(v0.z));
            Assert.That("(-5-7)", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("(-8-6)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(2-2)", "(-8-4)", "2", "((0-9)2)");
            var v1 = new gvec2<string>("null", "(3-2)");
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(2-2)", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("(3-2)", Is.EqualTo(v0.z));
            Assert.That("((0-9)2)", Is.EqualTo(v0.w));
        
            Assert.That("(-8-4)", Is.EqualTo(v2.x));
            Assert.That("2", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((-8-1)0)", "((-4-7)8)", "(-6-3)", "-9");
            var v1 = new gvec3<string>("((-18)-1)", "((-18)-1)", "");
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-18)-1)", Is.EqualTo(v0.x));
            Assert.That("((-18)-1)", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That("-9", Is.EqualTo(v0.w));
        
            Assert.That("((-8-1)0)", Is.EqualTo(v2.x));
            Assert.That("((-4-7)8)", Is.EqualTo(v2.y));
            Assert.That("(-6-3)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("((9-9)7)", "-4", "((-2-2)4)", "null");
            var v1 = "";
            var v2 = v0.a;
            v0.a = v1;
            var v3 = v0.a;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((9-9)7)", Is.EqualTo(v0.x));
            Assert.That("-4", Is.EqualTo(v0.y));
            Assert.That("((-2-2)4)", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("null", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("((-6-5)0)", "", "(71)", "");
            var v1 = new gvec2<string>("-2", "((4-1)-7)");
            var v2 = v0.ra;
            v0.ra = v1;
            var v3 = v0.ra;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-2", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("(71)", Is.EqualTo(v0.z));
            Assert.That("((4-1)-7)", Is.EqualTo(v0.w));
        
            Assert.That("((-6-5)0)", Is.EqualTo(v2.x));
            Assert.That("", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("-4", "5", "5", "((40)3)");
            var v1 = new gvec2<string>("", "(66)");
            var v2 = v0.ga;
            v0.ga = v1;
            var v3 = v0.ga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-4", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("5", Is.EqualTo(v0.z));
            Assert.That("(66)", Is.EqualTo(v0.w));
        
            Assert.That("5", Is.EqualTo(v2.x));
            Assert.That("((40)3)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(-94)", "", "4", "(-94)");
            var v1 = new gvec3<string>("(-68)", "(-68)", "");
            var v2 = v0.rga;
            v0.rga = v1;
            var v3 = v0.rga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-68)", Is.EqualTo(v0.x));
            Assert.That("(-68)", Is.EqualTo(v0.y));
            Assert.That("4", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("(-94)", Is.EqualTo(v2.x));
            Assert.That("", Is.EqualTo(v2.y));
            Assert.That("(-94)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(6-7)", "((4-8)6)", "-4", "2");
            var v1 = new gvec2<string>("-5", "");
            var v2 = v0.ba;
            v0.ba = v1;
            var v3 = v0.ba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(6-7)", Is.EqualTo(v0.x));
            Assert.That("((4-8)6)", Is.EqualTo(v0.y));
            Assert.That("-5", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("-4", Is.EqualTo(v2.x));
            Assert.That("2", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("6", "((-5-1)-3)", "(-28)", "0");
            var v1 = new gvec3<string>("((4-5)2)", "", "-7");
            var v2 = v0.rba;
            v0.rba = v1;
            var v3 = v0.rba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((4-5)2)", Is.EqualTo(v0.x));
            Assert.That("((-5-1)-3)", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That("-7", Is.EqualTo(v0.w));
        
            Assert.That("6", Is.EqualTo(v2.x));
            Assert.That("(-28)", Is.EqualTo(v2.y));
            Assert.That("0", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("4", "4", "null", "(05)");
            var v1 = new gvec3<string>("(-3-7)", "null", "-1");
            var v2 = v0.gba;
            v0.gba = v1;
            var v3 = v0.gba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("4", Is.EqualTo(v0.x));
            Assert.That("(-3-7)", Is.EqualTo(v0.y));
            Assert.That("null", Is.EqualTo(v0.z));
            Assert.That("-1", Is.EqualTo(v0.w));
        
            Assert.That("4", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
            Assert.That("(05)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(-50)", "6", "((77)5)", "-1");
            var v1 = new gvec4<string>("-3", "((-48)4)", "(-26)", "(2-7)");
            var v2 = v0.rgba;
            v0.rgba = v1;
            var v3 = v0.rgba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-3", Is.EqualTo(v0.x));
            Assert.That("((-48)4)", Is.EqualTo(v0.y));
            Assert.That("(-26)", Is.EqualTo(v0.z));
            Assert.That("(2-7)", Is.EqualTo(v0.w));
        
            Assert.That("(-50)", Is.EqualTo(v2.x));
            Assert.That("6", Is.EqualTo(v2.y));
            Assert.That("((77)5)", Is.EqualTo(v2.z));
            Assert.That("-1", Is.EqualTo(v2.w));
        }
    }

}
