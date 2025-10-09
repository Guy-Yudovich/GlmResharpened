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
            var ov = new gvec4<string>("(0-1)", "((-9-1)0)", "((4-5)5)", "((4-5)5)");
            var v = ov.swizzle.xx;
            Assert.That("(0-1)", Is.EqualTo(v.x));
            Assert.That("(0-1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-4", "(-95)", "(64)", "((3-1)5)");
            var v = ov.swizzle.xxx;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("4", "((41)-4)", "4", "((41)-4)");
            var v = ov.swizzle.xxxx;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-3-2)-1)", "((-3-2)-1)", "((-2-8)-1)");
            var v = ov.swizzle.xxxy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-3-2)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-52)", "null", "(-4-4)", "((2-5)6)");
            var v = ov.swizzle.xxxz;
            Assert.That("(-52)", Is.EqualTo(v.x));
            Assert.That("(-52)", Is.EqualTo(v.y));
            Assert.That("(-52)", Is.EqualTo(v.z));
            Assert.That("(-4-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-8)8)", "((0-8)8)", "((-5-6)7)", "(8-7)");
            var v = ov.swizzle.xxxw;
            Assert.That("((0-8)8)", Is.EqualTo(v.x));
            Assert.That("((0-8)8)", Is.EqualTo(v.y));
            Assert.That("((0-8)8)", Is.EqualTo(v.z));
            Assert.That("(8-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-73)-1)", "((-47)-5)", "((-73)-1)", "((37)3)");
            var v = ov.swizzle.xxy;
            Assert.That("((-73)-1)", Is.EqualTo(v.x));
            Assert.That("((-73)-1)", Is.EqualTo(v.y));
            Assert.That("((-47)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-50)-8)", "-7", "-7", "-9");
            var v = ov.swizzle.xxyx;
            Assert.That("((-50)-8)", Is.EqualTo(v.x));
            Assert.That("((-50)-8)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("((-50)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "", "8", "(3-1)");
            var v = ov.swizzle.xxyy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "((-28)-4)", "", "-4");
            var v = ov.swizzle.xxyz;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((-28)-4)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-2)6)", "null", "null", "");
            var v = ov.swizzle.xxyw;
            Assert.That("((-8-2)6)", Is.EqualTo(v.x));
            Assert.That("((-8-2)6)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-24)0)", "(83)", "null", "7");
            var v = ov.swizzle.xxz;
            Assert.That("((-24)0)", Is.EqualTo(v.x));
            Assert.That("((-24)0)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((18)-1)", "-7", "2", "(-80)");
            var v = ov.swizzle.xxzx;
            Assert.That("((18)-1)", Is.EqualTo(v.x));
            Assert.That("((18)-1)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("((18)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((20)7)", "((92)-8)", "-9", "");
            var v = ov.swizzle.xxzy;
            Assert.That("((20)7)", Is.EqualTo(v.x));
            Assert.That("((20)7)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("((92)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-58)", "(-58)", "((3-4)6)", "(-58)");
            var v = ov.swizzle.xxzz;
            Assert.That("(-58)", Is.EqualTo(v.x));
            Assert.That("(-58)", Is.EqualTo(v.y));
            Assert.That("((3-4)6)", Is.EqualTo(v.z));
            Assert.That("((3-4)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "(-5-2)", "(9-6)", "9");
            var v = ov.swizzle.xxzw;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(9-6)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-84)", "((30)9)", "7", "((30)9)");
            var v = ov.swizzle.xxw;
            Assert.That("(-84)", Is.EqualTo(v.x));
            Assert.That("(-84)", Is.EqualTo(v.y));
            Assert.That("((30)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-99)", "(26)", "((-2-5)-5)", "((-8-6)2)");
            var v = ov.swizzle.xxwx;
            Assert.That("(-99)", Is.EqualTo(v.x));
            Assert.That("(-99)", Is.EqualTo(v.y));
            Assert.That("((-8-6)2)", Is.EqualTo(v.z));
            Assert.That("(-99)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "((80)0)", "((-87)4)", "((1-3)0)");
            var v = ov.swizzle.xxwy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("((1-3)0)", Is.EqualTo(v.z));
            Assert.That("((80)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "(6-3)", "null", "((-8-5)1)");
            var v = ov.swizzle.xxwz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("((-8-5)1)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(23)", "((3-9)3)", "(-26)", "((3-9)3)");
            var v = ov.swizzle.xxww;
            Assert.That("(23)", Is.EqualTo(v.x));
            Assert.That("(23)", Is.EqualTo(v.y));
            Assert.That("((3-9)3)", Is.EqualTo(v.z));
            Assert.That("((3-9)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-1", "null", "(86)");
            var v = ov.swizzle.xy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(12)", "((95)7)", "((66)9)", "(12)");
            var v = ov.swizzle.xyx;
            Assert.That("(12)", Is.EqualTo(v.x));
            Assert.That("((95)7)", Is.EqualTo(v.y));
            Assert.That("(12)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-4-3)", "null", "null", "(-4-3)");
            var v = ov.swizzle.xyxx;
            Assert.That("(-4-3)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-4-3)", Is.EqualTo(v.z));
            Assert.That("(-4-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "(8-6)", "((2-1)3)", "((32)-5)");
            var v = ov.swizzle.xyxy;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(8-6)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("(8-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-7)", "null", "((2-5)3)", "(-25)");
            var v = ov.swizzle.xyxz;
            Assert.That("(6-7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(6-7)", Is.EqualTo(v.z));
            Assert.That("((2-5)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "(-49)", "7", "((-36)2)");
            var v = ov.swizzle.xyxw;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(-49)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("((-36)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-8)-2)", "9", "-3", "((8-8)-2)");
            var v = ov.swizzle.xyy;
            Assert.That("((8-8)-2)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(5-8)", "-5", "-5", "");
            var v = ov.swizzle.xyyx;
            Assert.That("(5-8)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("(5-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(10)", "(10)", "((-3-9)-7)", "((1-9)-7)");
            var v = ov.swizzle.xyyy;
            Assert.That("(10)", Is.EqualTo(v.x));
            Assert.That("(10)", Is.EqualTo(v.y));
            Assert.That("(10)", Is.EqualTo(v.z));
            Assert.That("(10)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-3)-7)", "", "((03)-6)", "((43)1)");
            var v = ov.swizzle.xyyz;
            Assert.That("((-7-3)-7)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((03)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "-3", "");
            var v = ov.swizzle.xyyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-3-5)1)", "((-5-4)3)", "(96)", "((-5-4)3)");
            var v = ov.swizzle.xyz;
            Assert.That("((-3-5)1)", Is.EqualTo(v.x));
            Assert.That("((-5-4)3)", Is.EqualTo(v.y));
            Assert.That("(96)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-2", "((-2-5)-3)", "", "((-43)-7)");
            var v = ov.swizzle.xyzx;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((-2-5)-3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-9)", "5", "-5", "");
            var v = ov.swizzle.xyzy;
            Assert.That("(6-9)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "-4", "(0-5)", "(-58)");
            var v = ov.swizzle.xyzz;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(0-5)", Is.EqualTo(v.z));
            Assert.That("(0-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-62)1)", "", "(6-2)");
            var v = ov.swizzle.xyzw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-62)1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(6-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "5", "null", "(8-7)");
            var v = ov.swizzle.xyw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(8-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-79)1)", "-1", "(7-4)", "((-79)1)");
            var v = ov.swizzle.xywx;
            Assert.That("((-79)1)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((-79)1)", Is.EqualTo(v.z));
            Assert.That("((-79)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(-3-9)", "2", "((2-9)-5)");
            var v = ov.swizzle.xywy;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-3-9)", Is.EqualTo(v.y));
            Assert.That("((2-9)-5)", Is.EqualTo(v.z));
            Assert.That("(-3-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-7)", "null", "(-5-4)", "(-5-4)");
            var v = ov.swizzle.xywz;
            Assert.That("(-1-7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-5-4)", Is.EqualTo(v.z));
            Assert.That("(-5-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-99)-4)", "(25)", "0", "null");
            var v = ov.swizzle.xyww;
            Assert.That("((-99)-4)", Is.EqualTo(v.x));
            Assert.That("(25)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(86)", "5", "", "(2-5)");
            var v = ov.swizzle.xz;
            Assert.That("(86)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-18)9)", "(7-5)", "(17)", "((-21)-1)");
            var v = ov.swizzle.xzx;
            Assert.That("((-18)9)", Is.EqualTo(v.x));
            Assert.That("(17)", Is.EqualTo(v.y));
            Assert.That("((-18)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "2", "-5", "-2");
            var v = ov.swizzle.xzxx;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "null", "(-5-6)", "((-6-5)-9)");
            var v = ov.swizzle.xzxy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(-5-6)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-28)-8)", "", "4", "");
            var v = ov.swizzle.xzxz;
            Assert.That("((-28)-8)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((-28)-8)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-5)", "-8", "-7", "((6-3)5)");
            var v = ov.swizzle.xzxw;
            Assert.That("(-9-5)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(-9-5)", Is.EqualTo(v.z));
            Assert.That("((6-3)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-1)", "null", "(-6-3)", "((24)4)");
            var v = ov.swizzle.xzy;
            Assert.That("(0-1)", Is.EqualTo(v.x));
            Assert.That("(-6-3)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-77)3)", "((9-6)1)", "((9-6)1)", "((9-6)1)");
            var v = ov.swizzle.xzyx;
            Assert.That("((-77)3)", Is.EqualTo(v.x));
            Assert.That("((9-6)1)", Is.EqualTo(v.y));
            Assert.That("((9-6)1)", Is.EqualTo(v.z));
            Assert.That("((-77)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-6)7)", "(-5-4)", "-6", "((-5-6)7)");
            var v = ov.swizzle.xzyy;
            Assert.That("((-5-6)7)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(-5-4)", Is.EqualTo(v.z));
            Assert.That("(-5-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-9)-9)", "", "null", "(-6-4)");
            var v = ov.swizzle.xzyz;
            Assert.That("((-2-9)-9)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-9)0)", "(-67)", "null", "-8");
            var v = ov.swizzle.xzyw;
            Assert.That("((-8-9)0)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-67)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "((0-3)4)", "(-3-6)", "8");
            var v = ov.swizzle.xzz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(-3-6)", Is.EqualTo(v.y));
            Assert.That("(-3-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(11)", "(-80)", "", "-2");
            var v = ov.swizzle.xzzx;
            Assert.That("(11)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(11)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "((20)-6)", "8", "((-6-1)7)");
            var v = ov.swizzle.xzzy;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("((20)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "9", "(-2-7)", "");
            var v = ov.swizzle.xzzz;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("(-2-7)", Is.EqualTo(v.y));
            Assert.That("(-2-7)", Is.EqualTo(v.z));
            Assert.That("(-2-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "null", "9", "(-3-7)");
            var v = ov.swizzle.xzzw;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("(-3-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-2-2)", "((67)-7)", "((67)-7)");
            var v = ov.swizzle.xzw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((67)-7)", Is.EqualTo(v.y));
            Assert.That("((67)-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((7-9)-3)", "(76)", "9", "(-45)");
            var v = ov.swizzle.xzwx;
            Assert.That("((7-9)-3)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("(-45)", Is.EqualTo(v.z));
            Assert.That("((7-9)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(65)", "null", "((-6-1)-3)", "4");
            var v = ov.swizzle.xzwy;
            Assert.That("(65)", Is.EqualTo(v.x));
            Assert.That("((-6-1)-3)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "((1-4)-9)", "((-29)-8)", "null");
            var v = ov.swizzle.xzwz;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-29)-8)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-29)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((-3-4)3)", "((8-3)0)", "(24)");
            var v = ov.swizzle.xzww;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("((8-3)0)", Is.EqualTo(v.y));
            Assert.That("(24)", Is.EqualTo(v.z));
            Assert.That("(24)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-7)", "(69)", "(69)", "null");
            var v = ov.swizzle.xw;
            Assert.That("(8-7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(2-2)", "(79)", "((1-8)-4)", "(79)");
            var v = ov.swizzle.xwx;
            Assert.That("(2-2)", Is.EqualTo(v.x));
            Assert.That("(79)", Is.EqualTo(v.y));
            Assert.That("(2-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-1", "", "-7", "-1");
            var v = ov.swizzle.xwxx;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "((00)-4)", "", "-1");
            var v = ov.swizzle.xwxy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((00)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-1)-3)", "((00)6)", "-8", "((-71)5)");
            var v = ov.swizzle.xwxz;
            Assert.That("((2-1)-3)", Is.EqualTo(v.x));
            Assert.That("((-71)5)", Is.EqualTo(v.y));
            Assert.That("((2-1)-3)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "(-75)", "(-8-2)", "");
            var v = ov.swizzle.xwxw;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "((8-2)-5)", "(54)", "(54)");
            var v = ov.swizzle.xwy;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("(54)", Is.EqualTo(v.y));
            Assert.That("((8-2)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "-7", "null", "(-20)");
            var v = ov.swizzle.xwyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-20)", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-1)", "-7", "6", "6");
            var v = ov.swizzle.xwyy;
            Assert.That("(8-1)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "(-2-1)", "(-65)", "(-2-1)");
            var v = ov.swizzle.xwyz;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(-2-1)", Is.EqualTo(v.y));
            Assert.That("(-2-1)", Is.EqualTo(v.z));
            Assert.That("(-65)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-37)", "((-7-5)5)", "(-4-7)", "(-1-5)");
            var v = ov.swizzle.xwyw;
            Assert.That("(-37)", Is.EqualTo(v.x));
            Assert.That("(-1-5)", Is.EqualTo(v.y));
            Assert.That("((-7-5)5)", Is.EqualTo(v.z));
            Assert.That("(-1-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "((-34)6)", "", "((-6-8)3)");
            var v = ov.swizzle.xwz;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("((-6-8)3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(04)", "(-10)", "");
            var v = ov.swizzle.xwzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-10)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "((26)4)", "7", "((44)-4)");
            var v = ov.swizzle.xwzy;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((44)-4)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((26)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-2)", "7", "(04)", "((-1-1)0)");
            var v = ov.swizzle.xwzz;
            Assert.That("(5-2)", Is.EqualTo(v.x));
            Assert.That("((-1-1)0)", Is.EqualTo(v.y));
            Assert.That("(04)", Is.EqualTo(v.z));
            Assert.That("(04)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-35)4)", "(-5-5)", "((-6-3)6)");
            var v = ov.swizzle.xwzw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-6-3)6)", Is.EqualTo(v.y));
            Assert.That("(-5-5)", Is.EqualTo(v.z));
            Assert.That("((-6-3)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-5)-2)", "(92)", "1", "((-46)-2)");
            var v = ov.swizzle.xww;
            Assert.That("((-9-5)-2)", Is.EqualTo(v.x));
            Assert.That("((-46)-2)", Is.EqualTo(v.y));
            Assert.That("((-46)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((71)5)", "", "-7", "((3-5)5)");
            var v = ov.swizzle.xwwx;
            Assert.That("((71)5)", Is.EqualTo(v.x));
            Assert.That("((3-5)5)", Is.EqualTo(v.y));
            Assert.That("((3-5)5)", Is.EqualTo(v.z));
            Assert.That("((71)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-8)9)", "((-6-4)-2)", "null", "((-6-4)-2)");
            var v = ov.swizzle.xwwy;
            Assert.That("((-5-8)9)", Is.EqualTo(v.x));
            Assert.That("((-6-4)-2)", Is.EqualTo(v.y));
            Assert.That("((-6-4)-2)", Is.EqualTo(v.z));
            Assert.That("((-6-4)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-24)8)", "(-9-2)", "(-5-8)");
            var v = ov.swizzle.xwwz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-5-8)", Is.EqualTo(v.y));
            Assert.That("(-5-8)", Is.EqualTo(v.z));
            Assert.That("(-9-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-18)", "-2", "(18)", "(1-3)");
            var v = ov.swizzle.xwww;
            Assert.That("(-18)", Is.EqualTo(v.x));
            Assert.That("(1-3)", Is.EqualTo(v.y));
            Assert.That("(1-3)", Is.EqualTo(v.z));
            Assert.That("(1-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "", "4", "((60)3)");
            var v = ov.swizzle.yx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("0", "(-7-1)", "((7-4)1)", "(-2-6)");
            var v = ov.swizzle.yxx;
            Assert.That("(-7-1)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(32)", "-6", "((81)-1)");
            var v = ov.swizzle.yxxx;
            Assert.That("(32)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "", "((-34)-5)", "9");
            var v = ov.swizzle.yxxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "((-90)1)", "-4", "-9");
            var v = ov.swizzle.yxxz;
            Assert.That("((-90)1)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "(69)", "(69)", "((74)3)");
            var v = ov.swizzle.yxxw;
            Assert.That("(69)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((74)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-2)", "(-96)", "(-96)", "(-3-8)");
            var v = ov.swizzle.yxy;
            Assert.That("(-96)", Is.EqualTo(v.x));
            Assert.That("(7-2)", Is.EqualTo(v.y));
            Assert.That("(-96)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(62)", "(2-3)", "-4", "-6");
            var v = ov.swizzle.yxyx;
            Assert.That("(2-3)", Is.EqualTo(v.x));
            Assert.That("(62)", Is.EqualTo(v.y));
            Assert.That("(2-3)", Is.EqualTo(v.z));
            Assert.That("(62)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-1)2)", "(25)", "(-4-8)", "-4");
            var v = ov.swizzle.yxyy;
            Assert.That("(25)", Is.EqualTo(v.x));
            Assert.That("((-8-1)2)", Is.EqualTo(v.y));
            Assert.That("(25)", Is.EqualTo(v.z));
            Assert.That("(25)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-1)6)", "null", "((0-1)6)", "((0-1)6)");
            var v = ov.swizzle.yxyz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((0-1)6)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((0-1)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "0", "((-13)-8)", "-2");
            var v = ov.swizzle.yxyw;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-7)9)", "-8", "", "3");
            var v = ov.swizzle.yxz;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((3-7)9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((00)3)", "1", "1", "null");
            var v = ov.swizzle.yxzx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((00)3)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("((00)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-3", "(6-6)", "(6-6)");
            var v = ov.swizzle.yxzy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(6-6)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((1-4)4)", "(-1-7)", "(-1-7)");
            var v = ov.swizzle.yxzz;
            Assert.That("((1-4)4)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-1-7)", Is.EqualTo(v.z));
            Assert.That("(-1-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-7)2)", "(12)", "(8-4)", "-7");
            var v = ov.swizzle.yxzw;
            Assert.That("(12)", Is.EqualTo(v.x));
            Assert.That("((4-7)2)", Is.EqualTo(v.y));
            Assert.That("(8-4)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-7)", "2", "2", "((2-4)-6)");
            var v = ov.swizzle.yxw;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-3-7)", Is.EqualTo(v.y));
            Assert.That("((2-4)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-2-4)", "5", "((5-9)-4)", "(-2-4)");
            var v = ov.swizzle.yxwx;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(-2-4)", Is.EqualTo(v.y));
            Assert.That("(-2-4)", Is.EqualTo(v.z));
            Assert.That("(-2-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(05)", "-7", "", "((-40)-5)");
            var v = ov.swizzle.yxwy;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(05)", Is.EqualTo(v.y));
            Assert.That("((-40)-5)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(79)", "((-4-2)9)", "(-33)");
            var v = ov.swizzle.yxwz;
            Assert.That("(79)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(-33)", Is.EqualTo(v.z));
            Assert.That("((-4-2)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-3)4)", "((92)8)", "(23)", "(-84)");
            var v = ov.swizzle.yxww;
            Assert.That("((92)8)", Is.EqualTo(v.x));
            Assert.That("((7-3)4)", Is.EqualTo(v.y));
            Assert.That("(-84)", Is.EqualTo(v.z));
            Assert.That("(-84)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "(-7-1)", "null", "((37)1)");
            var v = ov.swizzle.yy;
            Assert.That("(-7-1)", Is.EqualTo(v.x));
            Assert.That("(-7-1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(07)", "((49)3)", "(07)", "(49)");
            var v = ov.swizzle.yyx;
            Assert.That("((49)3)", Is.EqualTo(v.x));
            Assert.That("((49)3)", Is.EqualTo(v.y));
            Assert.That("(07)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((2-2)6)", "((2-2)6)", "((1-2)-2)", "");
            var v = ov.swizzle.yyxx;
            Assert.That("((2-2)6)", Is.EqualTo(v.x));
            Assert.That("((2-2)6)", Is.EqualTo(v.y));
            Assert.That("((2-2)6)", Is.EqualTo(v.z));
            Assert.That("((2-2)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-80)", "-8", "((-78)4)", "((7-2)4)");
            var v = ov.swizzle.yyxy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(-80)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-52)9)", "((-52)9)", "(48)", "-9");
            var v = ov.swizzle.yyxz;
            Assert.That("((-52)9)", Is.EqualTo(v.x));
            Assert.That("((-52)9)", Is.EqualTo(v.y));
            Assert.That("((-52)9)", Is.EqualTo(v.z));
            Assert.That("(48)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "((70)3)", "", "-8");
            var v = ov.swizzle.yyxw;
            Assert.That("((70)3)", Is.EqualTo(v.x));
            Assert.That("((70)3)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "7", "null", "null");
            var v = ov.swizzle.yyy;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(23)", "(-5-1)", "((6-9)-8)", "((6-9)-8)");
            var v = ov.swizzle.yyyx;
            Assert.That("(-5-1)", Is.EqualTo(v.x));
            Assert.That("(-5-1)", Is.EqualTo(v.y));
            Assert.That("(-5-1)", Is.EqualTo(v.z));
            Assert.That("(23)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(29)", "(35)", "9", "");
            var v = ov.swizzle.yyyy;
            Assert.That("(35)", Is.EqualTo(v.x));
            Assert.That("(35)", Is.EqualTo(v.y));
            Assert.That("(35)", Is.EqualTo(v.z));
            Assert.That("(35)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-4)", "((6-3)-5)", "-4", "((2-1)-4)");
            var v = ov.swizzle.yyyz;
            Assert.That("((6-3)-5)", Is.EqualTo(v.x));
            Assert.That("((6-3)-5)", Is.EqualTo(v.y));
            Assert.That("((6-3)-5)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((14)7)", "((8-4)-6)", "9", "null");
            var v = ov.swizzle.yyyw;
            Assert.That("((8-4)-6)", Is.EqualTo(v.x));
            Assert.That("((8-4)-6)", Is.EqualTo(v.y));
            Assert.That("((8-4)-6)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "3", "", "8");
            var v = ov.swizzle.yyz;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((6-6)9)", "((-78)8)", "null", "((73)-9)");
            var v = ov.swizzle.yyzx;
            Assert.That("((-78)8)", Is.EqualTo(v.x));
            Assert.That("((-78)8)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((6-6)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(1-5)", "null", "((-27)8)");
            var v = ov.swizzle.yyzy;
            Assert.That("(1-5)", Is.EqualTo(v.x));
            Assert.That("(1-5)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(1-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "(-5-5)", "((51)6)", "null");
            var v = ov.swizzle.yyzz;
            Assert.That("(-5-5)", Is.EqualTo(v.x));
            Assert.That("(-5-5)", Is.EqualTo(v.y));
            Assert.That("((51)6)", Is.EqualTo(v.z));
            Assert.That("((51)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-7)5)", "(-33)", "(93)", "((8-1)4)");
            var v = ov.swizzle.yyzw;
            Assert.That("(-33)", Is.EqualTo(v.x));
            Assert.That("(-33)", Is.EqualTo(v.y));
            Assert.That("(93)", Is.EqualTo(v.z));
            Assert.That("((8-1)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((32)3)", "((-2-1)2)", "(1-7)", "(1-7)");
            var v = ov.swizzle.yyw;
            Assert.That("((-2-1)2)", Is.EqualTo(v.x));
            Assert.That("((-2-1)2)", Is.EqualTo(v.y));
            Assert.That("(1-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "null", "(-86)", "(-86)");
            var v = ov.swizzle.yywx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-86)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-9)", "((31)-8)", "((2-3)-3)", "(45)");
            var v = ov.swizzle.yywy;
            Assert.That("((31)-8)", Is.EqualTo(v.x));
            Assert.That("((31)-8)", Is.EqualTo(v.y));
            Assert.That("(45)", Is.EqualTo(v.z));
            Assert.That("((31)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-4)1)", "(-95)", "", "3");
            var v = ov.swizzle.yywz;
            Assert.That("(-95)", Is.EqualTo(v.x));
            Assert.That("(-95)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "null", "(89)", "0");
            var v = ov.swizzle.yyww;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((48)1)", "-4", "(06)", "(06)");
            var v = ov.swizzle.yz;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(06)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("", "(-46)", "(-82)", "-8");
            var v = ov.swizzle.yzx;
            Assert.That("(-46)", Is.EqualTo(v.x));
            Assert.That("(-82)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-7-1)3)", "(1-2)", "(20)", "((8-8)5)");
            var v = ov.swizzle.yzxx;
            Assert.That("(1-2)", Is.EqualTo(v.x));
            Assert.That("(20)", Is.EqualTo(v.y));
            Assert.That("((-7-1)3)", Is.EqualTo(v.z));
            Assert.That("((-7-1)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-3", "null", "(-9-7)");
            var v = ov.swizzle.yzxy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "((6-6)-3)", "", "((-1-3)5)");
            var v = ov.swizzle.yzxz;
            Assert.That("((6-6)-3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-3)-5)", "(-4-5)", "(03)", "8");
            var v = ov.swizzle.yzxw;
            Assert.That("(-4-5)", Is.EqualTo(v.x));
            Assert.That("(03)", Is.EqualTo(v.y));
            Assert.That("((7-3)-5)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "(9-9)", "(-89)", "(-89)");
            var v = ov.swizzle.yzy;
            Assert.That("(9-9)", Is.EqualTo(v.x));
            Assert.That("(-89)", Is.EqualTo(v.y));
            Assert.That("(9-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-6-3)", "((-50)-5)", "((58)-8)", "(-35)");
            var v = ov.swizzle.yzyx;
            Assert.That("((-50)-5)", Is.EqualTo(v.x));
            Assert.That("((58)-8)", Is.EqualTo(v.y));
            Assert.That("((-50)-5)", Is.EqualTo(v.z));
            Assert.That("(-6-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((09)5)", "(6-5)", "4", "((-6-9)4)");
            var v = ov.swizzle.yzyy;
            Assert.That("(6-5)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("(6-5)", Is.EqualTo(v.z));
            Assert.That("(6-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-2)3)", "7", "((87)-6)", "null");
            var v = ov.swizzle.yzyz;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((87)-6)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((87)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-64)-2)", "(-8-1)", "(-8-1)", "(-26)");
            var v = ov.swizzle.yzyw;
            Assert.That("(-8-1)", Is.EqualTo(v.x));
            Assert.That("(-8-1)", Is.EqualTo(v.y));
            Assert.That("(-8-1)", Is.EqualTo(v.z));
            Assert.That("(-26)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "", "-8", "((40)-4)");
            var v = ov.swizzle.yzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("0", "0", "5", "(51)");
            var v = ov.swizzle.yzzx;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-7)-8)", "(-3-5)", "-9", "((-2-7)-8)");
            var v = ov.swizzle.yzzy;
            Assert.That("(-3-5)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("(-3-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-20)-9)", "(07)", "8");
            var v = ov.swizzle.yzzz;
            Assert.That("((-20)-9)", Is.EqualTo(v.x));
            Assert.That("(07)", Is.EqualTo(v.y));
            Assert.That("(07)", Is.EqualTo(v.z));
            Assert.That("(07)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "((-26)-1)", "(-96)", "-8");
            var v = ov.swizzle.yzzw;
            Assert.That("((-26)-1)", Is.EqualTo(v.x));
            Assert.That("(-96)", Is.EqualTo(v.y));
            Assert.That("(-96)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-1)", "(71)", "", "(71)");
            var v = ov.swizzle.yzw;
            Assert.That("(71)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(71)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "", "null", "5");
            var v = ov.swizzle.yzwx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-65)5)", "((-9-3)-5)", "((-9-3)-5)", "(97)");
            var v = ov.swizzle.yzwy;
            Assert.That("((-9-3)-5)", Is.EqualTo(v.x));
            Assert.That("((-9-3)-5)", Is.EqualTo(v.y));
            Assert.That("(97)", Is.EqualTo(v.z));
            Assert.That("((-9-3)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((0-7)-6)", "", "((0-7)-6)");
            var v = ov.swizzle.yzwz;
            Assert.That("((0-7)-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((0-7)-6)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "null", "(-4-3)", "((7-7)-5)");
            var v = ov.swizzle.yzww;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-4-3)", Is.EqualTo(v.y));
            Assert.That("((7-7)-5)", Is.EqualTo(v.z));
            Assert.That("((7-7)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-83)", "((-83)2)", "(-83)", "1");
            var v = ov.swizzle.yw;
            Assert.That("((-83)2)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((62)-6)", "((62)-6)", "((0-8)-4)", "((0-8)-4)");
            var v = ov.swizzle.ywx;
            Assert.That("((62)-6)", Is.EqualTo(v.x));
            Assert.That("((0-8)-4)", Is.EqualTo(v.y));
            Assert.That("((62)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("0", "(-43)", "((-44)3)", "null");
            var v = ov.swizzle.ywxx;
            Assert.That("(-43)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-24)-3)", "-5", "((7-2)-7)", "(24)");
            var v = ov.swizzle.ywxy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("(24)", Is.EqualTo(v.y));
            Assert.That("((-24)-3)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "((-3-8)-7)", "(-9-2)");
            var v = ov.swizzle.ywxz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-9-2)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-3-8)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-9)", "null", "-8", "");
            var v = ov.swizzle.ywxw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(9-9)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-5)", "(-15)", "7", "((-6-9)5)");
            var v = ov.swizzle.ywy;
            Assert.That("(-15)", Is.EqualTo(v.x));
            Assert.That("((-6-9)5)", Is.EqualTo(v.y));
            Assert.That("(-15)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-97)", "(-84)", "(-97)", "6");
            var v = ov.swizzle.ywyx;
            Assert.That("(-84)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(-84)", Is.EqualTo(v.z));
            Assert.That("(-97)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(8-5)", "((-9-9)8)", "0");
            var v = ov.swizzle.ywyy;
            Assert.That("(8-5)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("(8-5)", Is.EqualTo(v.z));
            Assert.That("(8-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-11)0)", "((-11)0)", "(5-8)", "(-8-9)");
            var v = ov.swizzle.ywyz;
            Assert.That("((-11)0)", Is.EqualTo(v.x));
            Assert.That("(-8-9)", Is.EqualTo(v.y));
            Assert.That("((-11)0)", Is.EqualTo(v.z));
            Assert.That("(5-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(3-2)", "((-93)4)", "((-95)8)");
            var v = ov.swizzle.ywyw;
            Assert.That("(3-2)", Is.EqualTo(v.x));
            Assert.That("((-95)8)", Is.EqualTo(v.y));
            Assert.That("(3-2)", Is.EqualTo(v.z));
            Assert.That("((-95)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(22)", "-1", "((8-3)-9)", "null");
            var v = ov.swizzle.ywz;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((8-3)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((2-3)-9)", "((2-3)-9)", "(02)", "(9-1)");
            var v = ov.swizzle.ywzx;
            Assert.That("((2-3)-9)", Is.EqualTo(v.x));
            Assert.That("(9-1)", Is.EqualTo(v.y));
            Assert.That("(02)", Is.EqualTo(v.z));
            Assert.That("((2-3)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-3)-4)", "(20)", "((-6-3)-4)", "((37)5)");
            var v = ov.swizzle.ywzy;
            Assert.That("(20)", Is.EqualTo(v.x));
            Assert.That("((37)5)", Is.EqualTo(v.y));
            Assert.That("((-6-3)-4)", Is.EqualTo(v.z));
            Assert.That("(20)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-76)0)", "((66)-8)", "((-13)-7)", "((66)-8)");
            var v = ov.swizzle.ywzz;
            Assert.That("((66)-8)", Is.EqualTo(v.x));
            Assert.That("((66)-8)", Is.EqualTo(v.y));
            Assert.That("((-13)-7)", Is.EqualTo(v.z));
            Assert.That("((-13)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "((52)1)", "8", "(8-7)");
            var v = ov.swizzle.ywzw;
            Assert.That("((52)1)", Is.EqualTo(v.x));
            Assert.That("(8-7)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("(8-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "3", "8", "(7-6)");
            var v = ov.swizzle.yww;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(7-6)", Is.EqualTo(v.y));
            Assert.That("(7-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "((-9-3)1)", "(6-7)", "");
            var v = ov.swizzle.ywwx;
            Assert.That("((-9-3)1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((06)4)", "(25)", "", "null");
            var v = ov.swizzle.ywwy;
            Assert.That("(25)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(25)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "(4-2)", "9", "(4-2)");
            var v = ov.swizzle.ywwz;
            Assert.That("(4-2)", Is.EqualTo(v.x));
            Assert.That("(4-2)", Is.EqualTo(v.y));
            Assert.That("(4-2)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-1-7)5)", "((-2-2)-2)", "-4");
            var v = ov.swizzle.ywww;
            Assert.That("((-1-7)5)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(-6-9)", "(-6-9)", "((4-3)-2)");
            var v = ov.swizzle.zx;
            Assert.That("(-6-9)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-2-7)", "(99)", "3", "((-2-9)-9)");
            var v = ov.swizzle.zxx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(-2-7)", Is.EqualTo(v.y));
            Assert.That("(-2-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-2", "null", "", "((-4-2)-2)");
            var v = ov.swizzle.zxxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(1-5)", "(1-5)", "((67)2)", "(-6-9)");
            var v = ov.swizzle.zxxy;
            Assert.That("((67)2)", Is.EqualTo(v.x));
            Assert.That("(1-5)", Is.EqualTo(v.y));
            Assert.That("(1-5)", Is.EqualTo(v.z));
            Assert.That("(1-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-9-7)", "(-9-7)", "null");
            var v = ov.swizzle.zxxz;
            Assert.That("(-9-7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-9-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "((-52)8)", "((50)3)", "(-84)");
            var v = ov.swizzle.zxxw;
            Assert.That("((50)3)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("(-84)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-93)1)", "((9-7)-6)", "((-93)1)", "((9-7)-6)");
            var v = ov.swizzle.zxy;
            Assert.That("((-93)1)", Is.EqualTo(v.x));
            Assert.That("((-93)1)", Is.EqualTo(v.y));
            Assert.That("((9-7)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-26)", "(-81)", "((-4-6)9)", "");
            var v = ov.swizzle.zxyx;
            Assert.That("((-4-6)9)", Is.EqualTo(v.x));
            Assert.That("(-26)", Is.EqualTo(v.y));
            Assert.That("(-81)", Is.EqualTo(v.z));
            Assert.That("(-26)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((84)-6)", "(-6-7)", "-1", "(-6-7)");
            var v = ov.swizzle.zxyy;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((84)-6)", Is.EqualTo(v.y));
            Assert.That("(-6-7)", Is.EqualTo(v.z));
            Assert.That("(-6-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((-5-9)-4)", "null", "(-95)");
            var v = ov.swizzle.zxyz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-5-9)-4)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-6-8)", "3", "(-6-8)");
            var v = ov.swizzle.zxyw;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-6-8)", Is.EqualTo(v.z));
            Assert.That("(-6-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((1-2)9)", "(44)", "((1-2)9)");
            var v = ov.swizzle.zxz;
            Assert.That("(44)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(44)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((91)7)", "(-34)", "7");
            var v = ov.swizzle.zxzx;
            Assert.That("(-34)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-34)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "", "((00)0)", "-3");
            var v = ov.swizzle.zxzy;
            Assert.That("((00)0)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("((00)0)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-73)", "-4", "((-8-1)4)", "null");
            var v = ov.swizzle.zxzz;
            Assert.That("((-8-1)4)", Is.EqualTo(v.x));
            Assert.That("(-73)", Is.EqualTo(v.y));
            Assert.That("((-8-1)4)", Is.EqualTo(v.z));
            Assert.That("((-8-1)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-7)", "2", "(-7-7)", "");
            var v = ov.swizzle.zxzw;
            Assert.That("(-7-7)", Is.EqualTo(v.x));
            Assert.That("(-7-7)", Is.EqualTo(v.y));
            Assert.That("(-7-7)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "(3-6)", "null", "9");
            var v = ov.swizzle.zxw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-87)5)", "((-87)5)", "((-4-8)-9)", "(12)");
            var v = ov.swizzle.zxwx;
            Assert.That("((-4-8)-9)", Is.EqualTo(v.x));
            Assert.That("((-87)5)", Is.EqualTo(v.y));
            Assert.That("(12)", Is.EqualTo(v.z));
            Assert.That("((-87)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "-5", "-5", "");
            var v = ov.swizzle.zxwy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-70)-3)", "3", "((6-6)2)", "(3-1)");
            var v = ov.swizzle.zxwz;
            Assert.That("((6-6)2)", Is.EqualTo(v.x));
            Assert.That("((-70)-3)", Is.EqualTo(v.y));
            Assert.That("(3-1)", Is.EqualTo(v.z));
            Assert.That("((6-6)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "3", "", "((4-5)-1)");
            var v = ov.swizzle.zxww;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((4-5)-1)", Is.EqualTo(v.z));
            Assert.That("((4-5)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "2", "(-3-2)", "(-2-6)");
            var v = ov.swizzle.zy;
            Assert.That("(-3-2)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-2-1)", "(27)", "((-8-4)7)", "0");
            var v = ov.swizzle.zyx;
            Assert.That("((-8-4)7)", Is.EqualTo(v.x));
            Assert.That("(27)", Is.EqualTo(v.y));
            Assert.That("(-2-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("4", "(-85)", "1", "((-3-6)6)");
            var v = ov.swizzle.zyxx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(-85)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(52)", "(52)", "(-53)", "(-53)");
            var v = ov.swizzle.zyxy;
            Assert.That("(-53)", Is.EqualTo(v.x));
            Assert.That("(52)", Is.EqualTo(v.y));
            Assert.That("(52)", Is.EqualTo(v.z));
            Assert.That("(52)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-17)1)", "6", "6", "-1");
            var v = ov.swizzle.zyxz;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("((-17)1)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((20)3)", "(6-5)", "null", "(-2-1)");
            var v = ov.swizzle.zyxw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(6-5)", Is.EqualTo(v.y));
            Assert.That("((20)3)", Is.EqualTo(v.z));
            Assert.That("(-2-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((11)-9)", "null", "");
            var v = ov.swizzle.zyy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((11)-9)", Is.EqualTo(v.y));
            Assert.That("((11)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(7-4)", "((6-7)9)", "9", "((6-7)9)");
            var v = ov.swizzle.zyyx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((6-7)9)", Is.EqualTo(v.y));
            Assert.That("((6-7)9)", Is.EqualTo(v.z));
            Assert.That("(7-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(6-9)", "((8-7)5)", "0");
            var v = ov.swizzle.zyyy;
            Assert.That("((8-7)5)", Is.EqualTo(v.x));
            Assert.That("(6-9)", Is.EqualTo(v.y));
            Assert.That("(6-9)", Is.EqualTo(v.z));
            Assert.That("(6-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(09)", "5", "((54)-3)");
            var v = ov.swizzle.zyyz;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(09)", Is.EqualTo(v.y));
            Assert.That("(09)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-5)4)", "((-2-9)-6)", "(-48)", "-1");
            var v = ov.swizzle.zyyw;
            Assert.That("(-48)", Is.EqualTo(v.x));
            Assert.That("((-2-9)-6)", Is.EqualTo(v.y));
            Assert.That("((-2-9)-6)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-9-8)2)", "((-9-8)2)", "null");
            var v = ov.swizzle.zyz;
            Assert.That("((-9-8)2)", Is.EqualTo(v.x));
            Assert.That("((-9-8)2)", Is.EqualTo(v.y));
            Assert.That("((-9-8)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-6", "((79)8)", "(60)", "(60)");
            var v = ov.swizzle.zyzx;
            Assert.That("(60)", Is.EqualTo(v.x));
            Assert.That("((79)8)", Is.EqualTo(v.y));
            Assert.That("(60)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-8)6)", "(88)", "(-3-2)", "(88)");
            var v = ov.swizzle.zyzy;
            Assert.That("(-3-2)", Is.EqualTo(v.x));
            Assert.That("(88)", Is.EqualTo(v.y));
            Assert.That("(-3-2)", Is.EqualTo(v.z));
            Assert.That("(88)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "8", "(-53)", "((13)4)");
            var v = ov.swizzle.zyzz;
            Assert.That("(-53)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-53)", Is.EqualTo(v.z));
            Assert.That("(-53)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-1)4)", "(-6-9)", "((0-1)4)", "(-77)");
            var v = ov.swizzle.zyzw;
            Assert.That("((0-1)4)", Is.EqualTo(v.x));
            Assert.That("(-6-9)", Is.EqualTo(v.y));
            Assert.That("((0-1)4)", Is.EqualTo(v.z));
            Assert.That("(-77)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((9-1)6)", "((-1-9)-6)", "1");
            var v = ov.swizzle.zyw;
            Assert.That("((-1-9)-6)", Is.EqualTo(v.x));
            Assert.That("((9-1)6)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((62)7)", "", "null");
            var v = ov.swizzle.zywx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((62)7)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "7", "((-3-8)-4)", "null");
            var v = ov.swizzle.zywy;
            Assert.That("((-3-8)-4)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-3", "9", "(-8-1)");
            var v = ov.swizzle.zywz;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(-8-1)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-1)6)", "(-8-1)", "((-38)-4)", "(-51)");
            var v = ov.swizzle.zyww;
            Assert.That("((-38)-4)", Is.EqualTo(v.x));
            Assert.That("(-8-1)", Is.EqualTo(v.y));
            Assert.That("(-51)", Is.EqualTo(v.z));
            Assert.That("(-51)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(96)", "((8-9)3)", "((8-9)3)", "(-1-2)");
            var v = ov.swizzle.zz;
            Assert.That("((8-9)3)", Is.EqualTo(v.x));
            Assert.That("((8-9)3)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-9-4)-7)", "null", "1", "(16)");
            var v = ov.swizzle.zzx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("((-9-4)-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((1-6)-7)", "(8-9)", "(52)", "5");
            var v = ov.swizzle.zzxx;
            Assert.That("(52)", Is.EqualTo(v.x));
            Assert.That("(52)", Is.EqualTo(v.y));
            Assert.That("((1-6)-7)", Is.EqualTo(v.z));
            Assert.That("((1-6)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(77)", "(77)", "(3-1)", "(3-6)");
            var v = ov.swizzle.zzxy;
            Assert.That("(3-1)", Is.EqualTo(v.x));
            Assert.That("(3-1)", Is.EqualTo(v.y));
            Assert.That("(77)", Is.EqualTo(v.z));
            Assert.That("(77)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-89)-2)", "((-89)-2)", "(12)", "null");
            var v = ov.swizzle.zzxz;
            Assert.That("(12)", Is.EqualTo(v.x));
            Assert.That("(12)", Is.EqualTo(v.y));
            Assert.That("((-89)-2)", Is.EqualTo(v.z));
            Assert.That("(12)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-80)", "(-80)", "7", "(-48)");
            var v = ov.swizzle.zzxw;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(-80)", Is.EqualTo(v.z));
            Assert.That("(-48)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("7", "7", "((-35)-7)", "((-35)-7)");
            var v = ov.swizzle.zzy;
            Assert.That("((-35)-7)", Is.EqualTo(v.x));
            Assert.That("((-35)-7)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(30)", "((4-6)-1)", "((7-9)4)", "0");
            var v = ov.swizzle.zzyx;
            Assert.That("((7-9)4)", Is.EqualTo(v.x));
            Assert.That("((7-9)4)", Is.EqualTo(v.y));
            Assert.That("((4-6)-1)", Is.EqualTo(v.z));
            Assert.That("(30)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((93)4)", "((93)4)", "-2", "null");
            var v = ov.swizzle.zzyy;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((93)4)", Is.EqualTo(v.z));
            Assert.That("((93)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-18)-8)", "(-7-7)", "-8", "(-7-7)");
            var v = ov.swizzle.zzyz;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(-7-7)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(8-5)", "((-3-5)3)", "(20)", "6");
            var v = ov.swizzle.zzyw;
            Assert.That("(20)", Is.EqualTo(v.x));
            Assert.That("(20)", Is.EqualTo(v.y));
            Assert.That("((-3-5)3)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(65)", "-1", "((6-5)0)", "5");
            var v = ov.swizzle.zzz;
            Assert.That("((6-5)0)", Is.EqualTo(v.x));
            Assert.That("((6-5)0)", Is.EqualTo(v.y));
            Assert.That("((6-5)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("5", "-6", "3", "(-57)");
            var v = ov.swizzle.zzzx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-2)", "((6-2)-1)", "(-7-2)", "7");
            var v = ov.swizzle.zzzy;
            Assert.That("(-7-2)", Is.EqualTo(v.x));
            Assert.That("(-7-2)", Is.EqualTo(v.y));
            Assert.That("(-7-2)", Is.EqualTo(v.z));
            Assert.That("((6-2)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-6)8)", "-2", "0", "((15)-5)");
            var v = ov.swizzle.zzzz;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-1)", "-8", "-1", "6");
            var v = ov.swizzle.zzzw;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((16)1)", "null", "((9-4)9)");
            var v = ov.swizzle.zzw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((9-4)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(4-5)", "((-97)-6)", "(4-5)");
            var v = ov.swizzle.zzwx;
            Assert.That("((-97)-6)", Is.EqualTo(v.x));
            Assert.That("((-97)-6)", Is.EqualTo(v.y));
            Assert.That("(4-5)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((27)-2)", "7", "(-1-3)", "(91)");
            var v = ov.swizzle.zzwy;
            Assert.That("(-1-3)", Is.EqualTo(v.x));
            Assert.That("(-1-3)", Is.EqualTo(v.y));
            Assert.That("(91)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((58)-9)", "((58)-9)", "-8", "null");
            var v = ov.swizzle.zzwz;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-8)1)", "((-2-9)0)", "((36)-4)", "");
            var v = ov.swizzle.zzww;
            Assert.That("((36)-4)", Is.EqualTo(v.x));
            Assert.That("((36)-4)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "null", "null", "-8");
            var v = ov.swizzle.zw;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(-7-5)", "(-7-5)", "((-90)-8)", "((-6-1)7)");
            var v = ov.swizzle.zwx;
            Assert.That("((-90)-8)", Is.EqualTo(v.x));
            Assert.That("((-6-1)7)", Is.EqualTo(v.y));
            Assert.That("(-7-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "7", "0", "((72)7)");
            var v = ov.swizzle.zwxx;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((72)7)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-6)1)", "((7-3)-3)", "((-4-5)1)", "");
            var v = ov.swizzle.zwxy;
            Assert.That("((-4-5)1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((1-6)1)", Is.EqualTo(v.z));
            Assert.That("((7-3)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((31)-5)", "((-77)3)", "((9-2)-5)", "((-77)3)");
            var v = ov.swizzle.zwxz;
            Assert.That("((9-2)-5)", Is.EqualTo(v.x));
            Assert.That("((-77)3)", Is.EqualTo(v.y));
            Assert.That("((31)-5)", Is.EqualTo(v.z));
            Assert.That("((9-2)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(4-5)", "((74)-8)", "((74)-8)", "(-96)");
            var v = ov.swizzle.zwxw;
            Assert.That("((74)-8)", Is.EqualTo(v.x));
            Assert.That("(-96)", Is.EqualTo(v.y));
            Assert.That("(4-5)", Is.EqualTo(v.z));
            Assert.That("(-96)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-2-8)", "((0-8)0)", "");
            var v = ov.swizzle.zwy;
            Assert.That("((0-8)0)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-2-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-71)-1)", "(0-9)", "null", "9");
            var v = ov.swizzle.zwyx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("(0-9)", Is.EqualTo(v.z));
            Assert.That("((-71)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((16)5)", "(-76)", "-8", "-4");
            var v = ov.swizzle.zwyy;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(-76)", Is.EqualTo(v.z));
            Assert.That("(-76)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(97)", "((-23)-8)", "((50)5)", "((50)5)");
            var v = ov.swizzle.zwyz;
            Assert.That("((50)5)", Is.EqualTo(v.x));
            Assert.That("((50)5)", Is.EqualTo(v.y));
            Assert.That("((-23)-8)", Is.EqualTo(v.z));
            Assert.That("((50)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-4)3)", "-3", "((71)9)", "-3");
            var v = ov.swizzle.zwyw;
            Assert.That("((71)9)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "2", "(-9-8)", "0");
            var v = ov.swizzle.zwz;
            Assert.That("(-9-8)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("(-9-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-2", "(-66)", "(-66)", "((-9-4)7)");
            var v = ov.swizzle.zwzx;
            Assert.That("(-66)", Is.EqualTo(v.x));
            Assert.That("((-9-4)7)", Is.EqualTo(v.y));
            Assert.That("(-66)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "((9-6)6)", "((0-1)-4)", "3");
            var v = ov.swizzle.zwzy;
            Assert.That("((0-1)-4)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((0-1)-4)", Is.EqualTo(v.z));
            Assert.That("((9-6)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(0-2)", "((2-9)-3)", "((2-9)-3)", "((-29)-7)");
            var v = ov.swizzle.zwzz;
            Assert.That("((2-9)-3)", Is.EqualTo(v.x));
            Assert.That("((-29)-7)", Is.EqualTo(v.y));
            Assert.That("((2-9)-3)", Is.EqualTo(v.z));
            Assert.That("((2-9)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-3)", "(11)", "(11)", "8");
            var v = ov.swizzle.zwzw;
            Assert.That("(11)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(11)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-6)8)", "(53)", "null", "(38)");
            var v = ov.swizzle.zww;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(38)", Is.EqualTo(v.y));
            Assert.That("(38)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(01)", "(70)", "2");
            var v = ov.swizzle.zwwx;
            Assert.That("(70)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "-8", "((03)-3)", "4");
            var v = ov.swizzle.zwwy;
            Assert.That("((03)-3)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((69)4)", "-2", "(-23)", "(15)");
            var v = ov.swizzle.zwwz;
            Assert.That("(-23)", Is.EqualTo(v.x));
            Assert.That("(15)", Is.EqualTo(v.y));
            Assert.That("(15)", Is.EqualTo(v.z));
            Assert.That("(-23)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-88)", "(-88)", "((8-1)-8)", "((1-2)0)");
            var v = ov.swizzle.zwww;
            Assert.That("((8-1)-8)", Is.EqualTo(v.x));
            Assert.That("((1-2)0)", Is.EqualTo(v.y));
            Assert.That("((1-2)0)", Is.EqualTo(v.z));
            Assert.That("((1-2)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((14)-6)", "((-4-1)5)", "((-4-1)5)", "((69)-2)");
            var v = ov.swizzle.wx;
            Assert.That("((69)-2)", Is.EqualTo(v.x));
            Assert.That("((14)-6)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(50)", "3", "(50)", "(64)");
            var v = ov.swizzle.wxx;
            Assert.That("(64)", Is.EqualTo(v.x));
            Assert.That("(50)", Is.EqualTo(v.y));
            Assert.That("(50)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-1", "-9", "-9", "8");
            var v = ov.swizzle.wxxx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((52)-9)", "6", "((52)-9)", "6");
            var v = ov.swizzle.wxxy;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("((52)-9)", Is.EqualTo(v.y));
            Assert.That("((52)-9)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "(2-5)", "(07)", "5");
            var v = ov.swizzle.wxxz;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("(07)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((-2-5)1)", "((-2-5)1)", "5");
            var v = ov.swizzle.wxxw;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "(-89)", "", "-1");
            var v = ov.swizzle.wxy;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(-89)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-2-5)1)", "((63)-7)", "", "");
            var v = ov.swizzle.wxyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-2-5)1)", Is.EqualTo(v.y));
            Assert.That("((63)-7)", Is.EqualTo(v.z));
            Assert.That("((-2-5)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(84)", "3", "-5", "(2-4)");
            var v = ov.swizzle.wxyy;
            Assert.That("(2-4)", Is.EqualTo(v.x));
            Assert.That("(84)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "", "", "(-7-8)");
            var v = ov.swizzle.wxyz;
            Assert.That("(-7-8)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-3)-6)", "(-8-1)", "-9", "((-16)1)");
            var v = ov.swizzle.wxyw;
            Assert.That("((-16)1)", Is.EqualTo(v.x));
            Assert.That("((-7-3)-6)", Is.EqualTo(v.y));
            Assert.That("(-8-1)", Is.EqualTo(v.z));
            Assert.That("((-16)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-84)", "((3-4)2)", "", "8");
            var v = ov.swizzle.wxz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("(-84)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "(85)", "", "(60)");
            var v = ov.swizzle.wxzx;
            Assert.That("(60)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "((7-7)2)", "((7-7)2)", "(-24)");
            var v = ov.swizzle.wxzy;
            Assert.That("(-24)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((7-7)2)", Is.EqualTo(v.z));
            Assert.That("((7-7)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(-70)", "(0-5)", "null");
            var v = ov.swizzle.wxzz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(0-5)", Is.EqualTo(v.z));
            Assert.That("(0-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((46)1)", "(67)", "-5", "");
            var v = ov.swizzle.wxzw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((46)1)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-14)4)", "", "-5", "");
            var v = ov.swizzle.wxw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-14)4)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((07)6)", "-9", "", "-9");
            var v = ov.swizzle.wxwx;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((07)6)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("((07)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-28)", "(8-3)", "((-4-9)4)", "(8-3)");
            var v = ov.swizzle.wxwy;
            Assert.That("(8-3)", Is.EqualTo(v.x));
            Assert.That("(-28)", Is.EqualTo(v.y));
            Assert.That("(8-3)", Is.EqualTo(v.z));
            Assert.That("(8-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-24)", "-7", "", "((-20)-4)");
            var v = ov.swizzle.wxwz;
            Assert.That("((-20)-4)", Is.EqualTo(v.x));
            Assert.That("(-24)", Is.EqualTo(v.y));
            Assert.That("((-20)-4)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-45)", "null", "((9-2)-3)", "((-16)3)");
            var v = ov.swizzle.wxww;
            Assert.That("((-16)3)", Is.EqualTo(v.x));
            Assert.That("(-45)", Is.EqualTo(v.y));
            Assert.That("((-16)3)", Is.EqualTo(v.z));
            Assert.That("((-16)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "-8", "(5-5)", "((-5-4)8)");
            var v = ov.swizzle.wy;
            Assert.That("((-5-4)8)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("2", "(-35)", "(-52)", "");
            var v = ov.swizzle.wyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-35)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "", "null", "((-4-5)2)");
            var v = ov.swizzle.wyxx;
            Assert.That("((-4-5)2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-5)", "-7", "2", "5");
            var v = ov.swizzle.wyxy;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(5-5)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(05)", "null", "((-25)3)");
            var v = ov.swizzle.wyxz;
            Assert.That("((-25)3)", Is.EqualTo(v.x));
            Assert.That("(05)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((99)1)", "((62)-3)", "((62)-3)", "((3-8)8)");
            var v = ov.swizzle.wyxw;
            Assert.That("((3-8)8)", Is.EqualTo(v.x));
            Assert.That("((62)-3)", Is.EqualTo(v.y));
            Assert.That("((99)1)", Is.EqualTo(v.z));
            Assert.That("((3-8)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-47)7)", "((25)-8)", "(26)", "8");
            var v = ov.swizzle.wyy;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((25)-8)", Is.EqualTo(v.y));
            Assert.That("((25)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(0-2)", "((8-2)9)", "((7-4)9)", "((8-2)9)");
            var v = ov.swizzle.wyyx;
            Assert.That("((8-2)9)", Is.EqualTo(v.x));
            Assert.That("((8-2)9)", Is.EqualTo(v.y));
            Assert.That("((8-2)9)", Is.EqualTo(v.z));
            Assert.That("(0-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(9-9)", "(00)", "null", "null");
            var v = ov.swizzle.wyyy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(00)", Is.EqualTo(v.y));
            Assert.That("(00)", Is.EqualTo(v.z));
            Assert.That("(00)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "(77)", "(-99)", "((16)-1)");
            var v = ov.swizzle.wyyz;
            Assert.That("((16)-1)", Is.EqualTo(v.x));
            Assert.That("(77)", Is.EqualTo(v.y));
            Assert.That("(77)", Is.EqualTo(v.z));
            Assert.That("(-99)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-3)", "(61)", "(5-3)", "");
            var v = ov.swizzle.wyyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(61)", Is.EqualTo(v.y));
            Assert.That("(61)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-3)-4)", "null", "((67)8)", "((0-1)7)");
            var v = ov.swizzle.wyz;
            Assert.That("((0-1)7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((67)8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((82)-4)", "(-57)", "0", "(62)");
            var v = ov.swizzle.wyzx;
            Assert.That("(62)", Is.EqualTo(v.x));
            Assert.That("(-57)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("((82)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "", "", "((-96)3)");
            var v = ov.swizzle.wyzy;
            Assert.That("((-96)3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-3)", "((9-7)-5)", "4", "8");
            var v = ov.swizzle.wyzz;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((9-7)-5)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "(51)", "(51)", "((-3-5)-1)");
            var v = ov.swizzle.wyzw;
            Assert.That("((-3-5)-1)", Is.EqualTo(v.x));
            Assert.That("(51)", Is.EqualTo(v.y));
            Assert.That("(51)", Is.EqualTo(v.z));
            Assert.That("((-3-5)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-27)0)", "((-27)0)", "null", "4");
            var v = ov.swizzle.wyw;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((-27)0)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(-4-8)", "null", "null");
            var v = ov.swizzle.wywx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(-4-8)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-26)", "(-26)", "7", "((67)-2)");
            var v = ov.swizzle.wywy;
            Assert.That("((67)-2)", Is.EqualTo(v.x));
            Assert.That("(-26)", Is.EqualTo(v.y));
            Assert.That("((67)-2)", Is.EqualTo(v.z));
            Assert.That("(-26)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((67)-6)", "", "((79)-4)");
            var v = ov.swizzle.wywz;
            Assert.That("((79)-4)", Is.EqualTo(v.x));
            Assert.That("((67)-6)", Is.EqualTo(v.y));
            Assert.That("((79)-4)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(8-4)", "(-99)", "-3");
            var v = ov.swizzle.wyww;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(8-4)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((4-2)-3)", "((4-2)-3)", "((-7-7)0)", "((-16)0)");
            var v = ov.swizzle.wz;
            Assert.That("((-16)0)", Is.EqualTo(v.x));
            Assert.That("((-7-7)0)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("7", "(6-5)", "((8-7)9)", "-8");
            var v = ov.swizzle.wzx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((8-7)9)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(7-1)", "null", "((-4-6)-4)");
            var v = ov.swizzle.wzxx;
            Assert.That("((-4-6)-4)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "(-9-9)", "7", "(39)");
            var v = ov.swizzle.wzxy;
            Assert.That("(39)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("(-9-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-78)", "-8", "-8", "((-9-7)9)");
            var v = ov.swizzle.wzxz;
            Assert.That("((-9-7)9)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(-78)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "0", "((-5-1)5)", "6");
            var v = ov.swizzle.wzxw;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("((-5-1)5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-98)-4)", "6", "(-10)", "(-6-3)");
            var v = ov.swizzle.wzy;
            Assert.That("(-6-3)", Is.EqualTo(v.x));
            Assert.That("(-10)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(61)", "7", "", "((-6-2)-5)");
            var v = ov.swizzle.wzyx;
            Assert.That("((-6-2)-5)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("(61)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-6)-5)", "(-13)", "-2", "");
            var v = ov.swizzle.wzyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("(-13)", Is.EqualTo(v.z));
            Assert.That("(-13)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "", "null", "(-3-7)");
            var v = ov.swizzle.wzyz;
            Assert.That("(-3-7)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-9)", "-5", "(-7-9)", "");
            var v = ov.swizzle.wzyw;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-7-9)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-2)-2)", "(-6-2)", "(2-1)", "((82)2)");
            var v = ov.swizzle.wzz;
            Assert.That("((82)2)", Is.EqualTo(v.x));
            Assert.That("(2-1)", Is.EqualTo(v.y));
            Assert.That("(2-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "2", "", "null");
            var v = ov.swizzle.wzzx;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-3)", "(-4-5)", "(-4-5)", "(66)");
            var v = ov.swizzle.wzzy;
            Assert.That("(66)", Is.EqualTo(v.x));
            Assert.That("(-4-5)", Is.EqualTo(v.y));
            Assert.That("(-4-5)", Is.EqualTo(v.z));
            Assert.That("(-4-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-68)9)", "null", "-1", "((0-1)2)");
            var v = ov.swizzle.wzzz;
            Assert.That("((0-1)2)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-3-9)5)", "", "-6");
            var v = ov.swizzle.wzzw;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-8-4)", "", "((66)8)");
            var v = ov.swizzle.wzw;
            Assert.That("((66)8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((66)8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-3-9)", "null", "((-3-2)4)", "(-93)");
            var v = ov.swizzle.wzwx;
            Assert.That("(-93)", Is.EqualTo(v.x));
            Assert.That("((-3-2)4)", Is.EqualTo(v.y));
            Assert.That("(-93)", Is.EqualTo(v.z));
            Assert.That("(-3-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-2)", "((5-3)4)", "(-3-7)", "1");
            var v = ov.swizzle.wzwy;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(-3-7)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("((5-3)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((1-9)-8)", "(-49)", "((1-9)-8)", "(-49)");
            var v = ov.swizzle.wzwz;
            Assert.That("(-49)", Is.EqualTo(v.x));
            Assert.That("((1-9)-8)", Is.EqualTo(v.y));
            Assert.That("(-49)", Is.EqualTo(v.z));
            Assert.That("((1-9)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-78)", "null", "((27)5)", "(7-5)");
            var v = ov.swizzle.wzww;
            Assert.That("(7-5)", Is.EqualTo(v.x));
            Assert.That("((27)5)", Is.EqualTo(v.y));
            Assert.That("(7-5)", Is.EqualTo(v.z));
            Assert.That("(7-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "(6-7)", "(23)", "((51)9)");
            var v = ov.swizzle.ww;
            Assert.That("((51)9)", Is.EqualTo(v.x));
            Assert.That("((51)9)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("null", "((-59)-4)", "-8", "((-3-2)-8)");
            var v = ov.swizzle.wwx;
            Assert.That("((-3-2)-8)", Is.EqualTo(v.x));
            Assert.That("((-3-2)-8)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("9", "(-1-9)", "(-1-9)", "((24)1)");
            var v = ov.swizzle.wwxx;
            Assert.That("((24)1)", Is.EqualTo(v.x));
            Assert.That("((24)1)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "", "((79)8)", "0");
            var v = ov.swizzle.wwxy;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-3)-3)", "((2-3)-3)", "7", "((2-3)-3)");
            var v = ov.swizzle.wwxz;
            Assert.That("((2-3)-3)", Is.EqualTo(v.x));
            Assert.That("((2-3)-3)", Is.EqualTo(v.y));
            Assert.That("((2-3)-3)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((-4-2)-4)", "2", "2");
            var v = ov.swizzle.wwxw;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(49)", "-1", "(49)", "((-3-4)7)");
            var v = ov.swizzle.wwy;
            Assert.That("((-3-4)7)", Is.EqualTo(v.x));
            Assert.That("((-3-4)7)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-73)2)", "", "null", "((-80)-5)");
            var v = ov.swizzle.wwyx;
            Assert.That("((-80)-5)", Is.EqualTo(v.x));
            Assert.That("((-80)-5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-73)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-2)-6)", "((8-2)-6)", "(80)", "");
            var v = ov.swizzle.wwyy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((8-2)-6)", Is.EqualTo(v.z));
            Assert.That("((8-2)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((-4-5)2)", "4", "-5");
            var v = ov.swizzle.wwyz;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("((-4-5)2)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-2)2)", "-1", "", "-2");
            var v = ov.swizzle.wwyw;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "((76)8)", "-1");
            var v = ov.swizzle.wwz;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((76)8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-36)", "((-48)-2)", "2", "(-36)");
            var v = ov.swizzle.wwzx;
            Assert.That("(-36)", Is.EqualTo(v.x));
            Assert.That("(-36)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("(-36)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(15)", "", "null");
            var v = ov.swizzle.wwzy;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(15)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-6)", "2", "(48)", "");
            var v = ov.swizzle.wwzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(48)", Is.EqualTo(v.z));
            Assert.That("(48)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-62)3)", "(-35)", "", "(95)");
            var v = ov.swizzle.wwzw;
            Assert.That("(95)", Is.EqualTo(v.x));
            Assert.That("(95)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(95)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "6", "4", "(1-4)");
            var v = ov.swizzle.www;
            Assert.That("(1-4)", Is.EqualTo(v.x));
            Assert.That("(1-4)", Is.EqualTo(v.y));
            Assert.That("(1-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(1-3)", "", "-2", "(72)");
            var v = ov.swizzle.wwwx;
            Assert.That("(72)", Is.EqualTo(v.x));
            Assert.That("(72)", Is.EqualTo(v.y));
            Assert.That("(72)", Is.EqualTo(v.z));
            Assert.That("(1-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(6-5)", "((9-8)-3)", "-1");
            var v = ov.swizzle.wwwy;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("(6-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-9)", "((-17)0)", "(85)", "null");
            var v = ov.swizzle.wwwz;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(85)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "(89)", "((-73)5)", "((5-1)4)");
            var v = ov.swizzle.wwww;
            Assert.That("((5-1)4)", Is.EqualTo(v.x));
            Assert.That("((5-1)4)", Is.EqualTo(v.y));
            Assert.That("((5-1)4)", Is.EqualTo(v.z));
            Assert.That("((5-1)4)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec4<string>("(1-4)", "-9", "((76)-4)", "-9");
            var v = ov.swizzle.rr;
            Assert.That("(1-4)", Is.EqualTo(v.x));
            Assert.That("(1-4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("", "null", "(-73)", "((-86)9)");
            var v = ov.swizzle.rrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("6", "((69)-5)", "-8", "((-46)-8)");
            var v = ov.swizzle.rrrr;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "null", "7", "((1-8)-3)");
            var v = ov.swizzle.rrrg;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-8)2)", "((-89)9)", "((-89)9)", "(3-3)");
            var v = ov.swizzle.rrrb;
            Assert.That("((8-8)2)", Is.EqualTo(v.x));
            Assert.That("((8-8)2)", Is.EqualTo(v.y));
            Assert.That("((8-8)2)", Is.EqualTo(v.z));
            Assert.That("((-89)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "-1", "-1", "-1");
            var v = ov.swizzle.rrra;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "(-7-2)", "((-25)2)", "(35)");
            var v = ov.swizzle.rrg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("(-7-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-63)", "(4-4)", "(-63)", "-5");
            var v = ov.swizzle.rrgr;
            Assert.That("(-63)", Is.EqualTo(v.x));
            Assert.That("(-63)", Is.EqualTo(v.y));
            Assert.That("(4-4)", Is.EqualTo(v.z));
            Assert.That("(-63)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-6", "((45)8)", "-6");
            var v = ov.swizzle.rrgg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(40)", "null", "((7-4)-7)", "null");
            var v = ov.swizzle.rrgb;
            Assert.That("(40)", Is.EqualTo(v.x));
            Assert.That("(40)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((7-4)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "(-54)", "1", "");
            var v = ov.swizzle.rrga;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(-54)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "3", "", "((-7-6)-9)");
            var v = ov.swizzle.rrb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "-9", "(55)", "((1-1)-3)");
            var v = ov.swizzle.rrbr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(55)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "((-7-7)-5)", "", "null");
            var v = ov.swizzle.rrbg;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-7-7)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "-7", "((-37)0)", "(-83)");
            var v = ov.swizzle.rrbb;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("((-37)0)", Is.EqualTo(v.z));
            Assert.That("((-37)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-98)", "((6-1)4)", "", "(2-2)");
            var v = ov.swizzle.rrba;
            Assert.That("(-98)", Is.EqualTo(v.x));
            Assert.That("(-98)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(2-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "(1-8)", "((24)-3)", "((-26)-1)");
            var v = ov.swizzle.rra;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("((-26)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((63)6)", "9", "9", "null");
            var v = ov.swizzle.rrar;
            Assert.That("((63)6)", Is.EqualTo(v.x));
            Assert.That("((63)6)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((63)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "", "((-28)-4)", "null");
            var v = ov.swizzle.rrag;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-72)", "-4", "((84)7)", "((-2-2)-2)");
            var v = ov.swizzle.rrab;
            Assert.That("(-72)", Is.EqualTo(v.x));
            Assert.That("(-72)", Is.EqualTo(v.y));
            Assert.That("((-2-2)-2)", Is.EqualTo(v.z));
            Assert.That("((84)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "-2", "", "((-6-5)8)");
            var v = ov.swizzle.rraa;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("((-6-5)8)", Is.EqualTo(v.z));
            Assert.That("((-6-5)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "", "-9", "(-3-4)");
            var v = ov.swizzle.rg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-1-3)-2)", "(1-9)", "4", "(1-9)");
            var v = ov.swizzle.rgr;
            Assert.That("((-1-3)-2)", Is.EqualTo(v.x));
            Assert.That("(1-9)", Is.EqualTo(v.y));
            Assert.That("((-1-3)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(3-6)", "0", "0", "((-82)-6)");
            var v = ov.swizzle.rgrr;
            Assert.That("(3-6)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("(3-6)", Is.EqualTo(v.z));
            Assert.That("(3-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((0-3)0)", "((33)-5)", "((0-3)0)");
            var v = ov.swizzle.rgrg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((0-3)0)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((0-3)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-1)", "((2-2)2)", "((32)0)", "((-80)3)");
            var v = ov.swizzle.rgrb;
            Assert.That("(5-1)", Is.EqualTo(v.x));
            Assert.That("((2-2)2)", Is.EqualTo(v.y));
            Assert.That("(5-1)", Is.EqualTo(v.z));
            Assert.That("((32)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(58)", "((-34)-2)", "((-34)-2)");
            var v = ov.swizzle.rgra;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(58)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-34)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((80)-8)", "8", "0");
            var v = ov.swizzle.rgg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((80)-8)", Is.EqualTo(v.y));
            Assert.That("((80)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("5", "(-45)", "((-35)-6)", "-8");
            var v = ov.swizzle.rggr;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(-45)", Is.EqualTo(v.y));
            Assert.That("(-45)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((19)-3)", "((19)-3)", "((19)-3)", "");
            var v = ov.swizzle.rggg;
            Assert.That("((19)-3)", Is.EqualTo(v.x));
            Assert.That("((19)-3)", Is.EqualTo(v.y));
            Assert.That("((19)-3)", Is.EqualTo(v.z));
            Assert.That("((19)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "null", "-3", "");
            var v = ov.swizzle.rggb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-2-3)", "((-10)3)", "-2", "null");
            var v = ov.swizzle.rgga;
            Assert.That("(-2-3)", Is.EqualTo(v.x));
            Assert.That("((-10)3)", Is.EqualTo(v.y));
            Assert.That("((-10)3)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(52)", "", "6", "(-6-7)");
            var v = ov.swizzle.rgb;
            Assert.That("(52)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(38)", "(0-5)", "", "((1-9)-1)");
            var v = ov.swizzle.rgbr;
            Assert.That("(38)", Is.EqualTo(v.x));
            Assert.That("(0-5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(38)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-28)", "null", "(-31)", "-9");
            var v = ov.swizzle.rgbg;
            Assert.That("(-28)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-31)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-2)", "((24)2)", "(2-6)", "(-6-2)");
            var v = ov.swizzle.rgbb;
            Assert.That("(-6-2)", Is.EqualTo(v.x));
            Assert.That("((24)2)", Is.EqualTo(v.y));
            Assert.That("(2-6)", Is.EqualTo(v.z));
            Assert.That("(2-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((3-5)2)", "((3-5)2)", "-9", "((-9-8)-7)");
            var v = ov.swizzle.rgba;
            Assert.That("((3-5)2)", Is.EqualTo(v.x));
            Assert.That("((3-5)2)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("((-9-8)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-9)-7)", "8", "(13)", "(-91)");
            var v = ov.swizzle.rga;
            Assert.That("((-8-9)-7)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-91)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-3", "((10)5)", "((10)5)", "((-90)0)");
            var v = ov.swizzle.rgar;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("((10)5)", Is.EqualTo(v.y));
            Assert.That("((-90)0)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "2", "((22)4)", "(-3-5)");
            var v = ov.swizzle.rgag;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(-3-5)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "null", "((-6-8)5)", "");
            var v = ov.swizzle.rgab;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-6-8)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((96)-7)", "(9-5)", "((96)-7)", "((-48)5)");
            var v = ov.swizzle.rgaa;
            Assert.That("((96)-7)", Is.EqualTo(v.x));
            Assert.That("(9-5)", Is.EqualTo(v.y));
            Assert.That("((-48)5)", Is.EqualTo(v.z));
            Assert.That("((-48)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "-4", "(-91)", "((-77)1)");
            var v = ov.swizzle.rb;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(-91)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-6", "1", "((69)2)", "(5-3)");
            var v = ov.swizzle.rbr;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((69)2)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "((7-2)8)", "-8", "(-53)");
            var v = ov.swizzle.rbrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(3-4)", "((84)-3)", "1");
            var v = ov.swizzle.rbrg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((84)-3)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(3-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-17)-1)", "null", "3", "-9");
            var v = ov.swizzle.rbrb;
            Assert.That("((-17)-1)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((-17)-1)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "7", "((-44)1)", "");
            var v = ov.swizzle.rbra;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-44)1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "(36)", "", "");
            var v = ov.swizzle.rbg;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(36)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-3-1)9)", "null", "null", "8");
            var v = ov.swizzle.rbgr;
            Assert.That("((-3-1)9)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-3-1)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-8)", "((1-9)1)", "null", "null");
            var v = ov.swizzle.rbgg;
            Assert.That("(-8-8)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((1-9)1)", Is.EqualTo(v.z));
            Assert.That("((1-9)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "((60)-5)", "((60)-5)", "-3");
            var v = ov.swizzle.rbgb;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((60)-5)", Is.EqualTo(v.y));
            Assert.That("((60)-5)", Is.EqualTo(v.z));
            Assert.That("((60)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "-1", "", "(-5-6)");
            var v = ov.swizzle.rbga;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("(-5-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "", "((9-8)-2)", "((22)-3)");
            var v = ov.swizzle.rbb;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((9-8)-2)", Is.EqualTo(v.y));
            Assert.That("((9-8)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-1-3)", "null", "-3", "4");
            var v = ov.swizzle.rbbr;
            Assert.That("(-1-3)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("(-1-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-7)-2)", "(-7-4)", "5", "((-43)-9)");
            var v = ov.swizzle.rbbg;
            Assert.That("((-8-7)-2)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("(-7-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-5)", "null", "(89)", "((59)-4)");
            var v = ov.swizzle.rbbb;
            Assert.That("(-4-5)", Is.EqualTo(v.x));
            Assert.That("(89)", Is.EqualTo(v.y));
            Assert.That("(89)", Is.EqualTo(v.z));
            Assert.That("(89)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-7-3)-2)", "", "((-7-3)-2)", "((-21)-2)");
            var v = ov.swizzle.rbba;
            Assert.That("((-7-3)-2)", Is.EqualTo(v.x));
            Assert.That("((-7-3)-2)", Is.EqualTo(v.y));
            Assert.That("((-7-3)-2)", Is.EqualTo(v.z));
            Assert.That("((-21)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "(-9-9)", "(8-8)", "((-30)-3)");
            var v = ov.swizzle.rba;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("(8-8)", Is.EqualTo(v.y));
            Assert.That("((-30)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((22)1)", "4", "4", "(89)");
            var v = ov.swizzle.rbar;
            Assert.That("((22)1)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("(89)", Is.EqualTo(v.z));
            Assert.That("((22)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-3)", "(-3-3)", "(90)", "((43)0)");
            var v = ov.swizzle.rbag;
            Assert.That("(-3-3)", Is.EqualTo(v.x));
            Assert.That("(90)", Is.EqualTo(v.y));
            Assert.That("((43)0)", Is.EqualTo(v.z));
            Assert.That("(-3-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-6-2)", "", "((3-4)-7)");
            var v = ov.swizzle.rbab;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((3-4)-7)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "(-8-7)", "(-8-7)", "-8");
            var v = ov.swizzle.rbaa;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(-8-7)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-6-1)", "null", "7", "(-6-1)");
            var v = ov.swizzle.ra;
            Assert.That("(-6-1)", Is.EqualTo(v.x));
            Assert.That("(-6-1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-86)-9)", "null", "1", "(9-3)");
            var v = ov.swizzle.rar;
            Assert.That("((-86)-9)", Is.EqualTo(v.x));
            Assert.That("(9-3)", Is.EqualTo(v.y));
            Assert.That("((-86)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-4-1)6)", "(-4-5)", "(29)", "-2");
            var v = ov.swizzle.rarr;
            Assert.That("((-4-1)6)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((-4-1)6)", Is.EqualTo(v.z));
            Assert.That("((-4-1)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-72)", "((6-5)7)", "0", "-6");
            var v = ov.swizzle.rarg;
            Assert.That("(-72)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(-72)", Is.EqualTo(v.z));
            Assert.That("((6-5)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "((-33)0)", "8", "");
            var v = ov.swizzle.rarb;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((15)4)", "-2", "null", "(3-3)");
            var v = ov.swizzle.rara;
            Assert.That("((15)4)", Is.EqualTo(v.x));
            Assert.That("(3-3)", Is.EqualTo(v.y));
            Assert.That("((15)4)", Is.EqualTo(v.z));
            Assert.That("(3-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-46)3)", "(-18)", "", "((-46)3)");
            var v = ov.swizzle.rag;
            Assert.That("((-46)3)", Is.EqualTo(v.x));
            Assert.That("((-46)3)", Is.EqualTo(v.y));
            Assert.That("(-18)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-46)", "0", "((53)-1)", "((-80)-3)");
            var v = ov.swizzle.ragr;
            Assert.That("(-46)", Is.EqualTo(v.x));
            Assert.That("((-80)-3)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("(-46)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "(4-1)", "(42)", "-5");
            var v = ov.swizzle.ragg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(4-1)", Is.EqualTo(v.z));
            Assert.That("(4-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(84)", "(79)", "((35)1)", "(84)");
            var v = ov.swizzle.ragb;
            Assert.That("(84)", Is.EqualTo(v.x));
            Assert.That("(84)", Is.EqualTo(v.y));
            Assert.That("(79)", Is.EqualTo(v.z));
            Assert.That("((35)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "", "0", "((-10)3)");
            var v = ov.swizzle.raga;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((-10)3)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-10)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-57)-3)", "null", "6", "((07)3)");
            var v = ov.swizzle.rab;
            Assert.That("((-57)-3)", Is.EqualTo(v.x));
            Assert.That("((07)3)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-5-2)", "", "((5-3)-5)", "(-5-2)");
            var v = ov.swizzle.rabr;
            Assert.That("(-5-2)", Is.EqualTo(v.x));
            Assert.That("(-5-2)", Is.EqualTo(v.y));
            Assert.That("((5-3)-5)", Is.EqualTo(v.z));
            Assert.That("(-5-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "-6", "null", "");
            var v = ov.swizzle.rabg;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-5)", "((16)4)", "null", "-7");
            var v = ov.swizzle.rabb;
            Assert.That("(7-5)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((24)-9)", "8", "((24)-9)", "(4-7)");
            var v = ov.swizzle.raba;
            Assert.That("((24)-9)", Is.EqualTo(v.x));
            Assert.That("(4-7)", Is.EqualTo(v.y));
            Assert.That("((24)-9)", Is.EqualTo(v.z));
            Assert.That("(4-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(-7-8)", "9", "(84)");
            var v = ov.swizzle.raa;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(84)", Is.EqualTo(v.y));
            Assert.That("(84)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("1", "null", "((-38)1)", "-4");
            var v = ov.swizzle.raar;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((88)-4)", "(-3-3)", "(5-1)", "((-30)-2)");
            var v = ov.swizzle.raag;
            Assert.That("((88)-4)", Is.EqualTo(v.x));
            Assert.That("((-30)-2)", Is.EqualTo(v.y));
            Assert.That("((-30)-2)", Is.EqualTo(v.z));
            Assert.That("(-3-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(26)", "((-47)5)", "((-47)5)", "null");
            var v = ov.swizzle.raab;
            Assert.That("(26)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-47)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-3)", "((4-9)-5)", "0", "");
            var v = ov.swizzle.raaa;
            Assert.That("(-1-3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-8", "null", "2");
            var v = ov.swizzle.gr;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((98)-4)", "null", "(-8-5)", "((23)6)");
            var v = ov.swizzle.grr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((98)-4)", Is.EqualTo(v.y));
            Assert.That("((98)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "1", "((-30)-7)", "null");
            var v = ov.swizzle.grrr;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "9", "((89)4)", "(0-6)");
            var v = ov.swizzle.grrg;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((0-6)-5)", "-8", "((0-6)-5)");
            var v = ov.swizzle.grrb;
            Assert.That("((0-6)-5)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(80)", "(80)", "", "((67)-3)");
            var v = ov.swizzle.grra;
            Assert.That("(80)", Is.EqualTo(v.x));
            Assert.That("(80)", Is.EqualTo(v.y));
            Assert.That("(80)", Is.EqualTo(v.z));
            Assert.That("((67)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "((-6-7)-7)", "null", "8");
            var v = ov.swizzle.grg;
            Assert.That("((-6-7)-7)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("((-6-7)-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-9", "((45)6)", "-1", "");
            var v = ov.swizzle.grgr;
            Assert.That("((45)6)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((45)6)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "7", "(-1-9)", "((36)7)");
            var v = ov.swizzle.grgg;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-2", "", "null", "((1-5)-9)");
            var v = ov.swizzle.grgb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(33)", "null", "(-3-8)", "-4");
            var v = ov.swizzle.grga;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(33)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(01)", "(-27)", "", "5");
            var v = ov.swizzle.grb;
            Assert.That("(-27)", Is.EqualTo(v.x));
            Assert.That("(01)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-35)", "(-57)", "", "((06)0)");
            var v = ov.swizzle.grbr;
            Assert.That("(-57)", Is.EqualTo(v.x));
            Assert.That("(-35)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-35)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((52)9)", "(-8-8)", "null", "((-51)1)");
            var v = ov.swizzle.grbg;
            Assert.That("(-8-8)", Is.EqualTo(v.x));
            Assert.That("((52)9)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("(-8-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(90)", "(1-1)", "(1-1)", "(90)");
            var v = ov.swizzle.grbb;
            Assert.That("(1-1)", Is.EqualTo(v.x));
            Assert.That("(90)", Is.EqualTo(v.y));
            Assert.That("(1-1)", Is.EqualTo(v.z));
            Assert.That("(1-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-68)5)", "(92)", "7", "3");
            var v = ov.swizzle.grba;
            Assert.That("(92)", Is.EqualTo(v.x));
            Assert.That("((-68)5)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-5)-7)", "((7-5)-7)", "(-18)", "(60)");
            var v = ov.swizzle.gra;
            Assert.That("((7-5)-7)", Is.EqualTo(v.x));
            Assert.That("((7-5)-7)", Is.EqualTo(v.y));
            Assert.That("(60)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((31)-3)", "", "-6", "((1-9)-4)");
            var v = ov.swizzle.grar;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((31)-3)", Is.EqualTo(v.y));
            Assert.That("((1-9)-4)", Is.EqualTo(v.z));
            Assert.That("((31)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "((21)1)", "(-7-8)", "((21)1)");
            var v = ov.swizzle.grag;
            Assert.That("((21)1)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((21)1)", Is.EqualTo(v.z));
            Assert.That("((21)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "((13)-3)", "(9-4)", "(9-4)");
            var v = ov.swizzle.grab;
            Assert.That("((13)-3)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(9-4)", Is.EqualTo(v.z));
            Assert.That("(9-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-4", "null", "-4");
            var v = ov.swizzle.graa;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "(-96)", "null");
            var v = ov.swizzle.gg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("8", "(-95)", "(-95)", "8");
            var v = ov.swizzle.ggr;
            Assert.That("(-95)", Is.EqualTo(v.x));
            Assert.That("(-95)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(22)", "((4-8)2)", "((-76)5)", "6");
            var v = ov.swizzle.ggrr;
            Assert.That("((4-8)2)", Is.EqualTo(v.x));
            Assert.That("((4-8)2)", Is.EqualTo(v.y));
            Assert.That("(22)", Is.EqualTo(v.z));
            Assert.That("(22)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "7", "((0-3)-2)", "((-20)-2)");
            var v = ov.swizzle.ggrg;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "3", "-5", "(-59)");
            var v = ov.swizzle.ggrb;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-8-2)8)", "2", "(6-8)", "(7-7)");
            var v = ov.swizzle.ggra;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("((-8-2)8)", Is.EqualTo(v.z));
            Assert.That("(7-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-2", "(89)", "-1");
            var v = ov.swizzle.ggg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-30)5)", "(-5-3)", "((2-1)5)", "((2-1)5)");
            var v = ov.swizzle.gggr;
            Assert.That("(-5-3)", Is.EqualTo(v.x));
            Assert.That("(-5-3)", Is.EqualTo(v.y));
            Assert.That("(-5-3)", Is.EqualTo(v.z));
            Assert.That("((-30)5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-3)", "9", "null", "(-6-5)");
            var v = ov.swizzle.gggg;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-14)2)", "(58)", "null", "((-87)6)");
            var v = ov.swizzle.gggb;
            Assert.That("(58)", Is.EqualTo(v.x));
            Assert.That("(58)", Is.EqualTo(v.y));
            Assert.That("(58)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "9", "((75)-5)", "-5");
            var v = ov.swizzle.ggga;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-4-9)", "-2", "(5-7)");
            var v = ov.swizzle.ggb;
            Assert.That("(-4-9)", Is.EqualTo(v.x));
            Assert.That("(-4-9)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "((-8-4)0)", "(17)", "1");
            var v = ov.swizzle.ggbr;
            Assert.That("((-8-4)0)", Is.EqualTo(v.x));
            Assert.That("((-8-4)0)", Is.EqualTo(v.y));
            Assert.That("(17)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "-8", "((-30)0)", "null");
            var v = ov.swizzle.ggbg;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("((-30)0)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-32)", "-2", "(-32)");
            var v = ov.swizzle.ggbb;
            Assert.That("(-32)", Is.EqualTo(v.x));
            Assert.That("(-32)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((1-6)-8)", "((3-9)-7)", "((-8-6)2)");
            var v = ov.swizzle.ggba;
            Assert.That("((1-6)-8)", Is.EqualTo(v.x));
            Assert.That("((1-6)-8)", Is.EqualTo(v.y));
            Assert.That("((3-9)-7)", Is.EqualTo(v.z));
            Assert.That("((-8-6)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(59)", "(34)", "(59)", "-6");
            var v = ov.swizzle.gga;
            Assert.That("(34)", Is.EqualTo(v.x));
            Assert.That("(34)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((37)9)", "((80)-3)", "0", "((37)9)");
            var v = ov.swizzle.ggar;
            Assert.That("((80)-3)", Is.EqualTo(v.x));
            Assert.That("((80)-3)", Is.EqualTo(v.y));
            Assert.That("((37)9)", Is.EqualTo(v.z));
            Assert.That("((37)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-41)-4)", "((-67)-5)", "", "4");
            var v = ov.swizzle.ggag;
            Assert.That("((-67)-5)", Is.EqualTo(v.x));
            Assert.That("((-67)-5)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("((-67)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-9-4)", "((-21)9)", "null");
            var v = ov.swizzle.ggab;
            Assert.That("(-9-4)", Is.EqualTo(v.x));
            Assert.That("(-9-4)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((-21)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((85)-1)", "(-30)", "(-30)", "");
            var v = ov.swizzle.ggaa;
            Assert.That("(-30)", Is.EqualTo(v.x));
            Assert.That("(-30)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-6)3)", "(83)", "(-6-5)", "((-1-1)7)");
            var v = ov.swizzle.gb;
            Assert.That("(83)", Is.EqualTo(v.x));
            Assert.That("(-6-5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("null", "(-12)", "-3", "null");
            var v = ov.swizzle.gbr;
            Assert.That("(-12)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((-95)6)", "", "1");
            var v = ov.swizzle.gbrr;
            Assert.That("((-95)6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-61)1)", "(74)", "((-61)1)", "1");
            var v = ov.swizzle.gbrg;
            Assert.That("(74)", Is.EqualTo(v.x));
            Assert.That("((-61)1)", Is.EqualTo(v.y));
            Assert.That("((-61)1)", Is.EqualTo(v.z));
            Assert.That("(74)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((42)1)", "((42)1)", "null");
            var v = ov.swizzle.gbrb;
            Assert.That("((42)1)", Is.EqualTo(v.x));
            Assert.That("((42)1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((42)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-58)", "-7", "-9", "null");
            var v = ov.swizzle.gbra;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("(-58)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "-5", "((33)5)", "(8-4)");
            var v = ov.swizzle.gbg;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("((33)5)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-6-9)-1)", "3", "1", "null");
            var v = ov.swizzle.gbgr;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("((-6-9)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(7-1)", "(75)", "-8", "(7-1)");
            var v = ov.swizzle.gbgg;
            Assert.That("(75)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(75)", Is.EqualTo(v.z));
            Assert.That("(75)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "", "(-33)", "((-31)2)");
            var v = ov.swizzle.gbgb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-33)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-33)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-6)", "(68)", "(05)", "null");
            var v = ov.swizzle.gbga;
            Assert.That("(68)", Is.EqualTo(v.x));
            Assert.That("(05)", Is.EqualTo(v.y));
            Assert.That("(68)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((5-1)8)", "(3-9)", "1", "null");
            var v = ov.swizzle.gbb;
            Assert.That("(3-9)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(-49)", "((-86)-8)", "(-49)");
            var v = ov.swizzle.gbbr;
            Assert.That("(-49)", Is.EqualTo(v.x));
            Assert.That("((-86)-8)", Is.EqualTo(v.y));
            Assert.That("((-86)-8)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "6", "null", "6");
            var v = ov.swizzle.gbbg;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-3)6)", "(-7-3)", "(-54)", "(-7-3)");
            var v = ov.swizzle.gbbb;
            Assert.That("(-7-3)", Is.EqualTo(v.x));
            Assert.That("(-54)", Is.EqualTo(v.y));
            Assert.That("(-54)", Is.EqualTo(v.z));
            Assert.That("(-54)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((7-9)-6)", "8", "((-65)3)", "((7-9)-6)");
            var v = ov.swizzle.gbba;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((-65)3)", Is.EqualTo(v.y));
            Assert.That("((-65)3)", Is.EqualTo(v.z));
            Assert.That("((7-9)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(5-2)", "(07)", "(2-1)", "(07)");
            var v = ov.swizzle.gba;
            Assert.That("(07)", Is.EqualTo(v.x));
            Assert.That("(2-1)", Is.EqualTo(v.y));
            Assert.That("(07)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-7-4)", "-4", "((48)1)", "");
            var v = ov.swizzle.gbar;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("((48)1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-7-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(3-4)", "3", "-4", "((5-4)6)");
            var v = ov.swizzle.gbag;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((5-4)6)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((65)2)", "5", "((-53)-6)", "");
            var v = ov.swizzle.gbab;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("((-53)-6)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-53)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((1-9)-3)", "((-55)-9)", "(34)");
            var v = ov.swizzle.gbaa;
            Assert.That("((1-9)-3)", Is.EqualTo(v.x));
            Assert.That("((-55)-9)", Is.EqualTo(v.y));
            Assert.That("(34)", Is.EqualTo(v.z));
            Assert.That("(34)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-45)-9)", "", "(3-7)", "(3-7)");
            var v = ov.swizzle.ga;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(3-7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("2", "null", "-5", "-7");
            var v = ov.swizzle.gar;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "((45)3)", "(33)", "(-65)");
            var v = ov.swizzle.garr;
            Assert.That("((45)3)", Is.EqualTo(v.x));
            Assert.That("(-65)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "(-7-3)", "((-23)-9)", "2");
            var v = ov.swizzle.garg;
            Assert.That("(-7-3)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(-7-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-7)-7)", "((-53)-3)", "(-30)", "-8");
            var v = ov.swizzle.garb;
            Assert.That("((-53)-3)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("((2-7)-7)", Is.EqualTo(v.z));
            Assert.That("(-30)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "null", "-5", "((-54)-5)");
            var v = ov.swizzle.gara;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-54)-5)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("((-54)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(08)", "null", "4", "");
            var v = ov.swizzle.gag;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-2-3)", "", "(-2-3)", "-3");
            var v = ov.swizzle.gagr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-2-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "1", "1", "(4-7)");
            var v = ov.swizzle.gagg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(4-7)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-44)", "(-44)", "((-6-8)3)", "(-44)");
            var v = ov.swizzle.gagb;
            Assert.That("(-44)", Is.EqualTo(v.x));
            Assert.That("(-44)", Is.EqualTo(v.y));
            Assert.That("(-44)", Is.EqualTo(v.z));
            Assert.That("((-6-8)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((25)2)", "((-6-5)-9)", "-3", "(69)");
            var v = ov.swizzle.gaga;
            Assert.That("((-6-5)-9)", Is.EqualTo(v.x));
            Assert.That("(69)", Is.EqualTo(v.y));
            Assert.That("((-6-5)-9)", Is.EqualTo(v.z));
            Assert.That("(69)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-2-4)-8)", "null", "3", "8");
            var v = ov.swizzle.gab;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((34)7)", "", "null", "(-4-6)");
            var v = ov.swizzle.gabr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-4-6)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((34)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "-1", "-4", "null");
            var v = ov.swizzle.gabg;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "9", "((19)-1)", "9");
            var v = ov.swizzle.gabb;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("((19)-1)", Is.EqualTo(v.z));
            Assert.That("((19)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-5)9)", "((67)9)", "null", "-4");
            var v = ov.swizzle.gaba;
            Assert.That("((67)9)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-4)", "((8-5)-9)", "5", "((62)-2)");
            var v = ov.swizzle.gaa;
            Assert.That("((8-5)-9)", Is.EqualTo(v.x));
            Assert.That("((62)-2)", Is.EqualTo(v.y));
            Assert.That("((62)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-8-4)", "-7", "(9-5)", "((-89)-9)");
            var v = ov.swizzle.gaar;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-89)-9)", Is.EqualTo(v.y));
            Assert.That("((-89)-9)", Is.EqualTo(v.z));
            Assert.That("(-8-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "((20)-1)", "(5-3)", "6");
            var v = ov.swizzle.gaag;
            Assert.That("((20)-1)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("((20)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "null", "(35)", "(35)");
            var v = ov.swizzle.gaab;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(35)", Is.EqualTo(v.y));
            Assert.That("(35)", Is.EqualTo(v.z));
            Assert.That("(35)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(3-3)", "null", "9");
            var v = ov.swizzle.gaaa;
            Assert.That("(3-3)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((12)-1)", "(2-4)", "-6", "(2-7)");
            var v = ov.swizzle.br;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((12)-1)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-3-8)-8)", "((-39)-8)", "((-3-8)-8)", "");
            var v = ov.swizzle.brr;
            Assert.That("((-3-8)-8)", Is.EqualTo(v.x));
            Assert.That("((-3-8)-8)", Is.EqualTo(v.y));
            Assert.That("((-3-8)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("5", "5", "((-7-1)1)", "(-1-7)");
            var v = ov.swizzle.brrr;
            Assert.That("((-7-1)1)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "(1-4)", "(07)", "(07)");
            var v = ov.swizzle.brrg;
            Assert.That("(07)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("(1-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-9)8)", "(-10)", "(-10)", "-6");
            var v = ov.swizzle.brrb;
            Assert.That("(-10)", Is.EqualTo(v.x));
            Assert.That("((2-9)8)", Is.EqualTo(v.y));
            Assert.That("((2-9)8)", Is.EqualTo(v.z));
            Assert.That("(-10)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(26)", "((-71)2)", "(26)", "(-6-4)");
            var v = ov.swizzle.brra;
            Assert.That("(26)", Is.EqualTo(v.x));
            Assert.That("(26)", Is.EqualTo(v.y));
            Assert.That("(26)", Is.EqualTo(v.z));
            Assert.That("(-6-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "((-76)0)", "-7", "((46)-1)");
            var v = ov.swizzle.brg;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((-76)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("1", "", "((-86)-2)", "null");
            var v = ov.swizzle.brgr;
            Assert.That("((-86)-2)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-81)3)", "((-81)3)", "6", "((20)-7)");
            var v = ov.swizzle.brgg;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("((-81)3)", Is.EqualTo(v.y));
            Assert.That("((-81)3)", Is.EqualTo(v.z));
            Assert.That("((-81)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(3-2)", "(3-5)", "null", "((72)9)");
            var v = ov.swizzle.brgb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("(3-2)", Is.EqualTo(v.y));
            Assert.That("(3-5)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "9", "9", "((-3-4)6)");
            var v = ov.swizzle.brga;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("((-3-4)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(69)", "(69)", "((47)-5)", "((20)4)");
            var v = ov.swizzle.brb;
            Assert.That("((47)-5)", Is.EqualTo(v.x));
            Assert.That("(69)", Is.EqualTo(v.y));
            Assert.That("((47)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-1", "(81)", "", "null");
            var v = ov.swizzle.brbr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-75)4)", "((84)-1)", "", "null");
            var v = ov.swizzle.brbg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-75)4)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((84)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "2", "(-89)", "((-5-2)-3)");
            var v = ov.swizzle.brbb;
            Assert.That("(-89)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-89)", Is.EqualTo(v.z));
            Assert.That("(-89)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(60)", "(60)", "(60)", "4");
            var v = ov.swizzle.brba;
            Assert.That("(60)", Is.EqualTo(v.x));
            Assert.That("(60)", Is.EqualTo(v.y));
            Assert.That("(60)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-2-5)", "", "");
            var v = ov.swizzle.bra;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((69)7)", "-9", "((-6-6)-6)", "(88)");
            var v = ov.swizzle.brar;
            Assert.That("((-6-6)-6)", Is.EqualTo(v.x));
            Assert.That("((69)7)", Is.EqualTo(v.y));
            Assert.That("(88)", Is.EqualTo(v.z));
            Assert.That("((69)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "(1-6)", "((6-8)-9)", "((90)4)");
            var v = ov.swizzle.brag;
            Assert.That("((6-8)-9)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("((90)4)", Is.EqualTo(v.z));
            Assert.That("(1-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-8)", "((-37)9)", "(-5-2)", "(-4-8)");
            var v = ov.swizzle.brab;
            Assert.That("(-5-2)", Is.EqualTo(v.x));
            Assert.That("(-4-8)", Is.EqualTo(v.y));
            Assert.That("(-4-8)", Is.EqualTo(v.z));
            Assert.That("(-5-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-9", "9", "(-95)", "((-2-3)7)");
            var v = ov.swizzle.braa;
            Assert.That("(-95)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((-2-3)7)", Is.EqualTo(v.z));
            Assert.That("((-2-3)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "((-6-9)-3)", "null", "");
            var v = ov.swizzle.bg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-6-9)-3)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("", "(52)", "((-6-1)1)", "");
            var v = ov.swizzle.bgr;
            Assert.That("((-6-1)1)", Is.EqualTo(v.x));
            Assert.That("(52)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((82)-3)", "((-28)-5)", "((82)-3)", "6");
            var v = ov.swizzle.bgrr;
            Assert.That("((82)-3)", Is.EqualTo(v.x));
            Assert.That("((-28)-5)", Is.EqualTo(v.y));
            Assert.That("((82)-3)", Is.EqualTo(v.z));
            Assert.That("((82)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-8)-3)", "-8", "-8", "((49)-4)");
            var v = ov.swizzle.bgrg;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("((2-8)-3)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-5)9)", "(72)", "6", "");
            var v = ov.swizzle.bgrb;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("(72)", Is.EqualTo(v.y));
            Assert.That("((8-5)9)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-60)-8)", "((-80)5)", "((-80)5)", "(5-2)");
            var v = ov.swizzle.bgra;
            Assert.That("((-80)5)", Is.EqualTo(v.x));
            Assert.That("((-80)5)", Is.EqualTo(v.y));
            Assert.That("((-60)-8)", Is.EqualTo(v.z));
            Assert.That("(5-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-7)", "((-46)0)", "((-46)0)", "((-31)-4)");
            var v = ov.swizzle.bgg;
            Assert.That("((-46)0)", Is.EqualTo(v.x));
            Assert.That("((-46)0)", Is.EqualTo(v.y));
            Assert.That("((-46)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("8", "((7-4)6)", "((5-9)-6)", "");
            var v = ov.swizzle.bggr;
            Assert.That("((5-9)-6)", Is.EqualTo(v.x));
            Assert.That("((7-4)6)", Is.EqualTo(v.y));
            Assert.That("((7-4)6)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "null", "null", "5");
            var v = ov.swizzle.bggg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(-77)", "(-63)", "2");
            var v = ov.swizzle.bggb;
            Assert.That("(-63)", Is.EqualTo(v.x));
            Assert.That("(-77)", Is.EqualTo(v.y));
            Assert.That("(-77)", Is.EqualTo(v.z));
            Assert.That("(-63)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(07)", "null", "5", "null");
            var v = ov.swizzle.bgga;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "-8", "((-32)0)", "null");
            var v = ov.swizzle.bgb;
            Assert.That("((-32)0)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("((-32)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("5", "", "((-5-5)-1)", "(7-2)");
            var v = ov.swizzle.bgbr;
            Assert.That("((-5-5)-1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-5-5)-1)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-65)", "((61)-5)", "((43)-3)", "");
            var v = ov.swizzle.bgbg;
            Assert.That("((43)-3)", Is.EqualTo(v.x));
            Assert.That("((61)-5)", Is.EqualTo(v.y));
            Assert.That("((43)-3)", Is.EqualTo(v.z));
            Assert.That("((61)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "(-7-5)", "-2", "-2");
            var v = ov.swizzle.bgbb;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("(-7-5)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-1)9)", "", "9", "((-68)8)");
            var v = ov.swizzle.bgba;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("((-68)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "((67)5)", "8", "");
            var v = ov.swizzle.bga;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((67)5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-46)", "(-46)", "5", "(7-2)");
            var v = ov.swizzle.bgar;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(-46)", Is.EqualTo(v.y));
            Assert.That("(7-2)", Is.EqualTo(v.z));
            Assert.That("(-46)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-3)-8)", "null", "((-9-3)-8)", "((-5-7)8)");
            var v = ov.swizzle.bgag;
            Assert.That("((-9-3)-8)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-5-7)8)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "0", "((-8-6)8)", "-3");
            var v = ov.swizzle.bgab;
            Assert.That("((-8-6)8)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("((-8-6)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((4-7)3)", "(-2-3)", "((3-4)2)");
            var v = ov.swizzle.bgaa;
            Assert.That("(-2-3)", Is.EqualTo(v.x));
            Assert.That("((4-7)3)", Is.EqualTo(v.y));
            Assert.That("((3-4)2)", Is.EqualTo(v.z));
            Assert.That("((3-4)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-6-1)8)", "-3", "(99)", "(-1-7)");
            var v = ov.swizzle.bb;
            Assert.That("(99)", Is.EqualTo(v.x));
            Assert.That("(99)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-49)-9)", "null", "(3-5)", "null");
            var v = ov.swizzle.bbr;
            Assert.That("(3-5)", Is.EqualTo(v.x));
            Assert.That("(3-5)", Is.EqualTo(v.y));
            Assert.That("((-49)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(57)", "(57)", "null", "((-67)-2)");
            var v = ov.swizzle.bbrr;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(57)", Is.EqualTo(v.z));
            Assert.That("(57)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-1)-6)", "((34)-1)", "((-4-1)-6)", "(84)");
            var v = ov.swizzle.bbrg;
            Assert.That("((-4-1)-6)", Is.EqualTo(v.x));
            Assert.That("((-4-1)-6)", Is.EqualTo(v.y));
            Assert.That("((-4-1)-6)", Is.EqualTo(v.z));
            Assert.That("((34)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((9-9)4)", "-2", "-2");
            var v = ov.swizzle.bbrb;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-2)9)", "-6", "((-19)6)", "8");
            var v = ov.swizzle.bbra;
            Assert.That("((-19)6)", Is.EqualTo(v.x));
            Assert.That("((-19)6)", Is.EqualTo(v.y));
            Assert.That("((-9-2)9)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-4-4)", "-1", "null", "(-2-2)");
            var v = ov.swizzle.bbg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((03)-4)", "(-24)", "-5", "(-24)");
            var v = ov.swizzle.bbgr;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("(-24)", Is.EqualTo(v.z));
            Assert.That("((03)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-28)", "(-5-7)", "((-8-7)2)", "");
            var v = ov.swizzle.bbgg;
            Assert.That("((-8-7)2)", Is.EqualTo(v.x));
            Assert.That("((-8-7)2)", Is.EqualTo(v.y));
            Assert.That("(-5-7)", Is.EqualTo(v.z));
            Assert.That("(-5-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((12)-5)", "((5-6)3)", "(1-9)", "(-7-2)");
            var v = ov.swizzle.bbgb;
            Assert.That("(1-9)", Is.EqualTo(v.x));
            Assert.That("(1-9)", Is.EqualTo(v.y));
            Assert.That("((5-6)3)", Is.EqualTo(v.z));
            Assert.That("(1-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-5-1)", "((-60)9)", "(6-9)", "-4");
            var v = ov.swizzle.bbga;
            Assert.That("(6-9)", Is.EqualTo(v.x));
            Assert.That("(6-9)", Is.EqualTo(v.y));
            Assert.That("((-60)9)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(42)", "4", "((7-6)6)", "(3-1)");
            var v = ov.swizzle.bbb;
            Assert.That("((7-6)6)", Is.EqualTo(v.x));
            Assert.That("((7-6)6)", Is.EqualTo(v.y));
            Assert.That("((7-6)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-8-4)", "((46)0)", "((46)0)", "null");
            var v = ov.swizzle.bbbr;
            Assert.That("((46)0)", Is.EqualTo(v.x));
            Assert.That("((46)0)", Is.EqualTo(v.y));
            Assert.That("((46)0)", Is.EqualTo(v.z));
            Assert.That("(-8-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((9-9)-8)", "(1-2)", "((-2-6)7)", "((-54)6)");
            var v = ov.swizzle.bbbg;
            Assert.That("((-2-6)7)", Is.EqualTo(v.x));
            Assert.That("((-2-6)7)", Is.EqualTo(v.y));
            Assert.That("((-2-6)7)", Is.EqualTo(v.z));
            Assert.That("(1-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((68)5)", "((68)5)", "-7", "2");
            var v = ov.swizzle.bbbb;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((01)6)", "-4", "((01)6)", "8");
            var v = ov.swizzle.bbba;
            Assert.That("((01)6)", Is.EqualTo(v.x));
            Assert.That("((01)6)", Is.EqualTo(v.y));
            Assert.That("((01)6)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-9-8)8)", "((-4-7)-1)", "((-4-7)-1)", "(3-6)");
            var v = ov.swizzle.bba;
            Assert.That("((-4-7)-1)", Is.EqualTo(v.x));
            Assert.That("((-4-7)-1)", Is.EqualTo(v.y));
            Assert.That("(3-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-5", "-8", "null", "(-7-5)");
            var v = ov.swizzle.bbar;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-7-5)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-24)7)", "8", "((-24)7)", "(75)");
            var v = ov.swizzle.bbag;
            Assert.That("((-24)7)", Is.EqualTo(v.x));
            Assert.That("((-24)7)", Is.EqualTo(v.y));
            Assert.That("(75)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-8-9)", "6", "8", "-8");
            var v = ov.swizzle.bbab;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(95)", "(2-5)", "-1");
            var v = ov.swizzle.bbaa;
            Assert.That("(2-5)", Is.EqualTo(v.x));
            Assert.That("(2-5)", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((51)2)", "(-9-1)", "((41)7)", "((41)7)");
            var v = ov.swizzle.ba;
            Assert.That("((41)7)", Is.EqualTo(v.x));
            Assert.That("((41)7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-5", "((-8-8)3)", "((99)-8)", "-7");
            var v = ov.swizzle.bar;
            Assert.That("((99)-8)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "-8", "(-52)", "((-2-1)-1)");
            var v = ov.swizzle.barr;
            Assert.That("(-52)", Is.EqualTo(v.x));
            Assert.That("((-2-1)-1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-26)", "((4-8)-9)", "-7", "(90)");
            var v = ov.swizzle.barg;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(90)", Is.EqualTo(v.y));
            Assert.That("(-26)", Is.EqualTo(v.z));
            Assert.That("((4-8)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((-51)-7)", "5", "(-4-1)");
            var v = ov.swizzle.barb;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(-4-1)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("0", "(51)", "((-29)6)", "0");
            var v = ov.swizzle.bara;
            Assert.That("((-29)6)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "(-6-6)", "(-23)");
            var v = ov.swizzle.bag;
            Assert.That("(-6-6)", Is.EqualTo(v.x));
            Assert.That("(-23)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-8-9)-6)", "-6", "", "((-71)-1)");
            var v = ov.swizzle.bagr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-71)-1)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((-8-9)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "0", "5", "((2-2)-7)");
            var v = ov.swizzle.bagg;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("((2-2)-7)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-7-3)", "", "(88)", "8");
            var v = ov.swizzle.bagb;
            Assert.That("(88)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(88)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-46)", "null", "((-44)-2)");
            var v = ov.swizzle.baga;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((-44)-2)", Is.EqualTo(v.y));
            Assert.That("(-46)", Is.EqualTo(v.z));
            Assert.That("((-44)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "-4", "(-2-7)");
            var v = ov.swizzle.bab;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(-2-7)", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(4-9)", "6", "-4", "-4");
            var v = ov.swizzle.babr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("(4-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-5-6)-7)", "", "((-77)0)", "null");
            var v = ov.swizzle.babg;
            Assert.That("((-77)0)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((-77)0)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "((-30)0)", "((-62)-7)", "(-8-1)");
            var v = ov.swizzle.babb;
            Assert.That("((-62)-7)", Is.EqualTo(v.x));
            Assert.That("(-8-1)", Is.EqualTo(v.y));
            Assert.That("((-62)-7)", Is.EqualTo(v.z));
            Assert.That("((-62)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-6)", "(-38)", "(6-6)", "null");
            var v = ov.swizzle.baba;
            Assert.That("(6-6)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(6-6)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-3", "6", "(-17)", "null");
            var v = ov.swizzle.baa;
            Assert.That("(-17)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "0", "((-93)8)", "0");
            var v = ov.swizzle.baar;
            Assert.That("((-93)8)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("8", "null", "", "null");
            var v = ov.swizzle.baag;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(75)", "8", "((61)9)", "((61)9)");
            var v = ov.swizzle.baab;
            Assert.That("((61)9)", Is.EqualTo(v.x));
            Assert.That("((61)9)", Is.EqualTo(v.y));
            Assert.That("((61)9)", Is.EqualTo(v.z));
            Assert.That("((61)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(2-4)", "((-22)8)", "");
            var v = ov.swizzle.baaa;
            Assert.That("((-22)8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("9", "", "((-36)4)", "");
            var v = ov.swizzle.ar;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-2", "((7-5)0)", "((7-5)-9)", "((7-5)-9)");
            var v = ov.swizzle.arr;
            Assert.That("((7-5)-9)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "(-4-9)", "(0-8)", "((-75)-8)");
            var v = ov.swizzle.arrr;
            Assert.That("((-75)-8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("6", "(-49)", "(-49)", "((68)-2)");
            var v = ov.swizzle.arrg;
            Assert.That("((68)-2)", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("(-49)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-66)5)", "((6-9)-4)", "", "-1");
            var v = ov.swizzle.arrb;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((-66)5)", Is.EqualTo(v.y));
            Assert.That("((-66)5)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-81)-8)", "", "(49)", "((0-2)9)");
            var v = ov.swizzle.arra;
            Assert.That("((0-2)9)", Is.EqualTo(v.x));
            Assert.That("((-81)-8)", Is.EqualTo(v.y));
            Assert.That("((-81)-8)", Is.EqualTo(v.z));
            Assert.That("((0-2)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(-2-1)", "-3", "(-2-1)");
            var v = ov.swizzle.arg;
            Assert.That("(-2-1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-2-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(36)", "0", "((8-6)5)", "-4");
            var v = ov.swizzle.argr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(36)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("(36)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-8", "(9-5)", "(9-2)", "-8");
            var v = ov.swizzle.argg;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("(9-5)", Is.EqualTo(v.z));
            Assert.That("(9-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "((-45)-6)", "((-45)-6)", "-7");
            var v = ov.swizzle.argb;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("((-45)-6)", Is.EqualTo(v.z));
            Assert.That("((-45)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "-9", "", "-9");
            var v = ov.swizzle.arga;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "null", "-6", "(-33)");
            var v = ov.swizzle.arb;
            Assert.That("(-33)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((3-5)-4)", "-3", "-6", "-6");
            var v = ov.swizzle.arbr;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("((3-5)-4)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((3-5)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "null", "null", "null");
            var v = ov.swizzle.arbg;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-40)", "(7-3)", "7", "");
            var v = ov.swizzle.arbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-40)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((0-9)-9)", "null", "((-59)-6)", "9");
            var v = ov.swizzle.arba;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("((0-9)-9)", Is.EqualTo(v.y));
            Assert.That("((-59)-6)", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-83)-1)", "(02)", "-3", "(5-9)");
            var v = ov.swizzle.ara;
            Assert.That("(5-9)", Is.EqualTo(v.x));
            Assert.That("((-83)-1)", Is.EqualTo(v.y));
            Assert.That("(5-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(-7-3)", "(20)", "null");
            var v = ov.swizzle.arar;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((17)-4)", "5", "-6", "((-7-4)-4)");
            var v = ov.swizzle.arag;
            Assert.That("((-7-4)-4)", Is.EqualTo(v.x));
            Assert.That("((17)-4)", Is.EqualTo(v.y));
            Assert.That("((-7-4)-4)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "(53)", "((04)0)", "(-27)");
            var v = ov.swizzle.arab;
            Assert.That("(-27)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("(-27)", Is.EqualTo(v.z));
            Assert.That("((04)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "(7-4)", "((-28)5)", "-3");
            var v = ov.swizzle.araa;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("3", "", "8", "((-8-3)6)");
            var v = ov.swizzle.ag;
            Assert.That("((-8-3)6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("((-1-3)6)", "3", "(-8-9)", "(-8-9)");
            var v = ov.swizzle.agr;
            Assert.That("(-8-9)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((-1-3)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("", "1", "(10)", "((-83)-7)");
            var v = ov.swizzle.agrr;
            Assert.That("((-83)-7)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "(-4-4)", "((-4-1)-6)", "5");
            var v = ov.swizzle.agrg;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("(-4-4)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("(-4-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "null", "(8-6)");
            var v = ov.swizzle.agrb;
            Assert.That("(8-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("5", "", "null", "((84)2)");
            var v = ov.swizzle.agra;
            Assert.That("((84)2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("((84)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-18)", "4", "(-18)", "");
            var v = ov.swizzle.agg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("((-95)-5)", "-9", "(96)", "0");
            var v = ov.swizzle.aggr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("((-95)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-7", "(7-9)", "-9", "");
            var v = ov.swizzle.aggg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(7-9)", Is.EqualTo(v.y));
            Assert.That("(7-9)", Is.EqualTo(v.z));
            Assert.That("(7-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-67)8)", "(79)", "((69)-6)", "7");
            var v = ov.swizzle.aggb;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(79)", Is.EqualTo(v.y));
            Assert.That("(79)", Is.EqualTo(v.z));
            Assert.That("((69)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((80)9)", "(-1-9)", "3", "(-8-5)");
            var v = ov.swizzle.agga;
            Assert.That("(-8-5)", Is.EqualTo(v.x));
            Assert.That("(-1-9)", Is.EqualTo(v.y));
            Assert.That("(-1-9)", Is.EqualTo(v.z));
            Assert.That("(-8-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-1", "(16)", "(-2-7)", "-2");
            var v = ov.swizzle.agb;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("(16)", Is.EqualTo(v.y));
            Assert.That("(-2-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(-64)", "", "((-7-3)-1)", "(-42)");
            var v = ov.swizzle.agbr;
            Assert.That("(-42)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-7-3)-1)", Is.EqualTo(v.z));
            Assert.That("(-64)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-6", "null", "((77)9)", "(87)");
            var v = ov.swizzle.agbg;
            Assert.That("(87)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("((77)9)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-5)6)", "-3", "2", "(74)");
            var v = ov.swizzle.agbb;
            Assert.That("(74)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-9-8)", "(-73)", "", "(-9-8)");
            var v = ov.swizzle.agba;
            Assert.That("(-9-8)", Is.EqualTo(v.x));
            Assert.That("(-73)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-9-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(47)", "", "null", "((-84)0)");
            var v = ov.swizzle.aga;
            Assert.That("((-84)0)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-84)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("7", "(92)", "((-3-4)-2)", "7");
            var v = ov.swizzle.agar;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("(92)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-66)", "-5", "-5", "((-8-3)-3)");
            var v = ov.swizzle.agag;
            Assert.That("((-8-3)-3)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("((-8-3)-3)", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "(6-6)", "((49)1)", "");
            var v = ov.swizzle.agab;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(6-6)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((49)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-4", "-4", "(0-8)", "((-5-5)-9)");
            var v = ov.swizzle.agaa;
            Assert.That("((-5-5)-9)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("((-5-5)-9)", Is.EqualTo(v.z));
            Assert.That("((-5-5)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-89)", "((-97)-4)", "(9-5)", "-3");
            var v = ov.swizzle.ab;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(9-5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("-1", "null", "", "((-8-1)-4)");
            var v = ov.swizzle.abr;
            Assert.That("((-8-1)-4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-9", "-9", "null", "(06)");
            var v = ov.swizzle.abrr;
            Assert.That("(06)", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-7)0)", "((5-3)-6)", "3", "((-11)-6)");
            var v = ov.swizzle.abrg;
            Assert.That("((-11)-6)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((-1-7)0)", Is.EqualTo(v.z));
            Assert.That("((5-3)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(25)", "(25)", "((9-9)1)", "((9-9)1)");
            var v = ov.swizzle.abrb;
            Assert.That("((9-9)1)", Is.EqualTo(v.x));
            Assert.That("((9-9)1)", Is.EqualTo(v.y));
            Assert.That("(25)", Is.EqualTo(v.z));
            Assert.That("((9-9)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "(-4-6)", "null", "4");
            var v = ov.swizzle.abra;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((51)-3)", "(-70)", "(-70)", "3");
            var v = ov.swizzle.abg;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(-70)", Is.EqualTo(v.y));
            Assert.That("(-70)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-8", "((60)1)", "((32)9)", "((60)1)");
            var v = ov.swizzle.abgr;
            Assert.That("((60)1)", Is.EqualTo(v.x));
            Assert.That("((32)9)", Is.EqualTo(v.y));
            Assert.That("((60)1)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((8-3)-9)", "(67)", "(67)", "");
            var v = ov.swizzle.abgg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(67)", Is.EqualTo(v.y));
            Assert.That("(67)", Is.EqualTo(v.z));
            Assert.That("(67)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "6", "-8", "((7-2)4)");
            var v = ov.swizzle.abgb;
            Assert.That("((7-2)4)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(77)", "-6", "((92)3)", "null");
            var v = ov.swizzle.abga;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((92)3)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((-3-1)2)", "((-3-1)2)", "(47)");
            var v = ov.swizzle.abb;
            Assert.That("(47)", Is.EqualTo(v.x));
            Assert.That("((-3-1)2)", Is.EqualTo(v.y));
            Assert.That("((-3-1)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("(57)", "-6", "-6", "(57)");
            var v = ov.swizzle.abbr;
            Assert.That("(57)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("(57)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-3-4)", "((-9-7)-1)", "", "((-9-7)-1)");
            var v = ov.swizzle.abbg;
            Assert.That("((-9-7)-1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-9-7)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(6-7)", "(6-7)", "null", "null");
            var v = ov.swizzle.abbb;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((2-2)-9)", "(-5-8)", "((2-2)-9)", "null");
            var v = ov.swizzle.abba;
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((2-2)-9)", Is.EqualTo(v.y));
            Assert.That("((2-2)-9)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "((-27)1)", "");
            var v = ov.swizzle.aba;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-27)1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "null", "-4", "(-67)");
            var v = ov.swizzle.abar;
            Assert.That("(-67)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(-67)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "", "((-49)2)", "(31)");
            var v = ov.swizzle.abag;
            Assert.That("(31)", Is.EqualTo(v.x));
            Assert.That("((-49)2)", Is.EqualTo(v.y));
            Assert.That("(31)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "8", "(-8-6)", "((1-4)-7)");
            var v = ov.swizzle.abab;
            Assert.That("((1-4)-7)", Is.EqualTo(v.x));
            Assert.That("(-8-6)", Is.EqualTo(v.y));
            Assert.That("((1-4)-7)", Is.EqualTo(v.z));
            Assert.That("(-8-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((45)3)", "(-8-6)", "5", "((77)1)");
            var v = ov.swizzle.abaa;
            Assert.That("((77)1)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("((77)1)", Is.EqualTo(v.z));
            Assert.That("((77)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("2", "((9-2)5)", "(59)", "8");
            var v = ov.swizzle.aa;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec4<string>("(93)", "5", "2", "5");
            var v = ov.swizzle.aar;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(93)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "(31)", "(-3-5)", "((02)0)");
            var v = ov.swizzle.aarr;
            Assert.That("((02)0)", Is.EqualTo(v.x));
            Assert.That("((02)0)", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-11)", "(2-3)", "((-4-6)4)", "((-4-6)4)");
            var v = ov.swizzle.aarg;
            Assert.That("((-4-6)4)", Is.EqualTo(v.x));
            Assert.That("((-4-6)4)", Is.EqualTo(v.y));
            Assert.That("(-11)", Is.EqualTo(v.z));
            Assert.That("(2-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "((80)-3)", "(5-5)", "-6");
            var v = ov.swizzle.aarb;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(5-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-4-9)0)", "((8-7)7)", "(2-3)", "(2-3)");
            var v = ov.swizzle.aara;
            Assert.That("(2-3)", Is.EqualTo(v.x));
            Assert.That("(2-3)", Is.EqualTo(v.y));
            Assert.That("((-4-9)0)", Is.EqualTo(v.z));
            Assert.That("(2-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "4", "((06)-2)", "2");
            var v = ov.swizzle.aag;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("null", "(55)", "3", "((-82)-6)");
            var v = ov.swizzle.aagr;
            Assert.That("((-82)-6)", Is.EqualTo(v.x));
            Assert.That("((-82)-6)", Is.EqualTo(v.y));
            Assert.That("(55)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(2-1)", "", "1", "");
            var v = ov.swizzle.aagg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("1", "1", "((-7-5)-3)", "((-7-5)-3)");
            var v = ov.swizzle.aagb;
            Assert.That("((-7-5)-3)", Is.EqualTo(v.x));
            Assert.That("((-7-5)-3)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("((-7-5)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(65)", "((-2-3)1)", "(-16)", "6");
            var v = ov.swizzle.aaga;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("((-2-3)1)", Is.EqualTo(v.z));
            Assert.That("6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "", "-3", "((7-9)-5)");
            var v = ov.swizzle.aab;
            Assert.That("((7-9)-5)", Is.EqualTo(v.x));
            Assert.That("((7-9)-5)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("-9", "(-33)", "((-80)2)", "0");
            var v = ov.swizzle.aabr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((-80)2)", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "((-58)0)", "-5", "(8-7)");
            var v = ov.swizzle.aabg;
            Assert.That("(8-7)", Is.EqualTo(v.x));
            Assert.That("(8-7)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("((-58)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("(-1-3)", "((1-5)-3)", "((-16)-3)", "7");
            var v = ov.swizzle.aabb;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("((-16)-3)", Is.EqualTo(v.z));
            Assert.That("((-16)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("null", "((4-4)1)", "", "-4");
            var v = ov.swizzle.aaba;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("-5", "(14)", "((9-2)-3)", "(-9-9)");
            var v = ov.swizzle.aaa;
            Assert.That("(-9-9)", Is.EqualTo(v.x));
            Assert.That("(-9-9)", Is.EqualTo(v.y));
            Assert.That("(-9-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec4<string>("2", "7", "7", "");
            var v = ov.swizzle.aaar;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("((-1-5)-5)", "null", "((-1-5)-5)", "-3");
            var v = ov.swizzle.aaag;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("4", "null", "((74)-3)", "(2-2)");
            var v = ov.swizzle.aaab;
            Assert.That("(2-2)", Is.EqualTo(v.x));
            Assert.That("(2-2)", Is.EqualTo(v.y));
            Assert.That("(2-2)", Is.EqualTo(v.z));
            Assert.That("((74)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec4<string>("", "-6", "(0-8)", "-1");
            var v = ov.swizzle.aaaa;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec4<string>("", "(-9-6)", "(-69)", "");
            var v1 = new gvec2<string>("(6-3)", "");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(6-3)", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("(-69)", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("(-9-6)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("-2", "null", "((09)8)", "7");
            var v1 = new gvec2<string>("-4", "((2-1)-5)");
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-4", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("((2-1)-5)", Is.EqualTo(v0.z));
            Assert.That("7", Is.EqualTo(v0.w));
        
            Assert.That("-2", Is.EqualTo(v2.x));
            Assert.That("((09)8)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((54)-5)", "", "(28)", "((54)-5)");
            var v1 = new gvec2<string>("(97)", "((-78)-5)");
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((54)-5)", Is.EqualTo(v0.x));
            Assert.That("(97)", Is.EqualTo(v0.y));
            Assert.That("((-78)-5)", Is.EqualTo(v0.z));
            Assert.That("((54)-5)", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("(28)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(-2-1)", "1", "((-6-7)6)", "(-2-1)");
            var v1 = new gvec3<string>("-3", "(76)", "null");
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-3", Is.EqualTo(v0.x));
            Assert.That("(76)", Is.EqualTo(v0.y));
            Assert.That("null", Is.EqualTo(v0.z));
            Assert.That("(-2-1)", Is.EqualTo(v0.w));
        
            Assert.That("(-2-1)", Is.EqualTo(v2.x));
            Assert.That("1", Is.EqualTo(v2.y));
            Assert.That("((-6-7)6)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("((81)9)", "", "-2", "((-36)6)");
            var v1 = new gvec2<string>("-4", "(02)");
            var v2 = v0.xw;
            v0.xw = v1;
            var v3 = v0.xw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-4", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("-2", Is.EqualTo(v0.z));
            Assert.That("(02)", Is.EqualTo(v0.w));
        
            Assert.That("((81)9)", Is.EqualTo(v2.x));
            Assert.That("((-36)6)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("3", "", "(33)", "(-69)");
            var v1 = new gvec2<string>("-1", "(8-2)");
            var v2 = v0.yw;
            v0.yw = v1;
            var v3 = v0.yw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("3", Is.EqualTo(v0.x));
            Assert.That("-1", Is.EqualTo(v0.y));
            Assert.That("(33)", Is.EqualTo(v0.z));
            Assert.That("(8-2)", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("(-69)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(21)", "null", "(21)", "");
            var v1 = new gvec3<string>("9", "null", "2");
            var v2 = v0.xyw;
            v0.xyw = v1;
            var v3 = v0.xyw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("9", Is.EqualTo(v0.x));
            Assert.That("null", Is.EqualTo(v0.y));
            Assert.That("(21)", Is.EqualTo(v0.z));
            Assert.That("2", Is.EqualTo(v0.w));
        
            Assert.That("(21)", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
            Assert.That("", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("", "-7", "(-5-2)", "(5-1)");
            var v1 = new gvec2<string>("((-30)4)", "((-7-8)8)");
            var v2 = v0.zw;
            v0.zw = v1;
            var v3 = v0.zw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("-7", Is.EqualTo(v0.y));
            Assert.That("((-30)4)", Is.EqualTo(v0.z));
            Assert.That("((-7-8)8)", Is.EqualTo(v0.w));
        
            Assert.That("(-5-2)", Is.EqualTo(v2.x));
            Assert.That("(5-1)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("6", "6", "null", "(00)");
            var v1 = new gvec3<string>("((-8-4)4)", "-9", "((00)2)");
            var v2 = v0.xzw;
            v0.xzw = v1;
            var v3 = v0.xzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-8-4)4)", Is.EqualTo(v0.x));
            Assert.That("6", Is.EqualTo(v0.y));
            Assert.That("-9", Is.EqualTo(v0.z));
            Assert.That("((00)2)", Is.EqualTo(v0.w));
        
            Assert.That("6", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
            Assert.That("(00)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("(11)", "(11)", "null", "(11)");
            var v1 = new gvec3<string>("(-6-3)", "(57)", "(-6-3)");
            var v2 = v0.yzw;
            v0.yzw = v1;
            var v3 = v0.yzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(11)", Is.EqualTo(v0.x));
            Assert.That("(-6-3)", Is.EqualTo(v0.y));
            Assert.That("(57)", Is.EqualTo(v0.z));
            Assert.That("(-6-3)", Is.EqualTo(v0.w));
        
            Assert.That("(11)", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
            Assert.That("(11)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("((-6-2)-6)", "(-41)", "0", "null");
            var v1 = new gvec4<string>("6", "(0-4)", "((04)-8)", "7");
            var v2 = v0.xyzw;
            v0.xyzw = v1;
            var v3 = v0.xyzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("6", Is.EqualTo(v0.x));
            Assert.That("(0-4)", Is.EqualTo(v0.y));
            Assert.That("((04)-8)", Is.EqualTo(v0.z));
            Assert.That("7", Is.EqualTo(v0.w));
        
            Assert.That("((-6-2)-6)", Is.EqualTo(v2.x));
            Assert.That("(-41)", Is.EqualTo(v2.y));
            Assert.That("0", Is.EqualTo(v2.z));
            Assert.That("null", Is.EqualTo(v2.w));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new gvec4<string>("((-54)-2)", "((29)9)", "null", "((29)9)");
            var v1 = "(3-3)";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(3-3)", Is.EqualTo(v0.x));
            Assert.That("((29)9)", Is.EqualTo(v0.y));
            Assert.That("null", Is.EqualTo(v0.z));
            Assert.That("((29)9)", Is.EqualTo(v0.w));
        
            Assert.That("((-54)-2)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("-1", "((-92)2)", "-1", "((-92)2)");
            var v1 = "";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-1", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("-1", Is.EqualTo(v0.z));
            Assert.That("((-92)2)", Is.EqualTo(v0.w));
        
            Assert.That("((-92)2)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("-1", "((-9-1)8)", "(2-2)", "null");
            var v1 = new gvec2<string>("((6-3)-5)", "((48)-7)");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((6-3)-5)", Is.EqualTo(v0.x));
            Assert.That("((48)-7)", Is.EqualTo(v0.y));
            Assert.That("(2-2)", Is.EqualTo(v0.z));
            Assert.That("null", Is.EqualTo(v0.w));
        
            Assert.That("-1", Is.EqualTo(v2.x));
            Assert.That("((-9-1)8)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("-3", "4", "(0-9)", "(0-9)");
            var v1 = "(-1-7)";
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-3", Is.EqualTo(v0.x));
            Assert.That("4", Is.EqualTo(v0.y));
            Assert.That("(-1-7)", Is.EqualTo(v0.z));
            Assert.That("(0-9)", Is.EqualTo(v0.w));
        
            Assert.That("(0-9)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("", "((9-8)2)", "null", "");
            var v1 = new gvec2<string>("(8-7)", "(8-7)");
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(8-7)", Is.EqualTo(v0.x));
            Assert.That("((9-8)2)", Is.EqualTo(v0.y));
            Assert.That("(8-7)", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("null", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(1-9)", "(49)", "-3", "-5");
            var v1 = new gvec2<string>("(2-2)", "((38)-8)");
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(1-9)", Is.EqualTo(v0.x));
            Assert.That("(2-2)", Is.EqualTo(v0.y));
            Assert.That("((38)-8)", Is.EqualTo(v0.z));
            Assert.That("-5", Is.EqualTo(v0.w));
        
            Assert.That("(49)", Is.EqualTo(v2.x));
            Assert.That("-3", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("(9-1)", "(-62)", "(9-1)", "(-5-7)");
            var v1 = new gvec3<string>("((5-4)7)", "((6-2)-5)", "8");
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((5-4)7)", Is.EqualTo(v0.x));
            Assert.That("((6-2)-5)", Is.EqualTo(v0.y));
            Assert.That("8", Is.EqualTo(v0.z));
            Assert.That("(-5-7)", Is.EqualTo(v0.w));
        
            Assert.That("(9-1)", Is.EqualTo(v2.x));
            Assert.That("(-62)", Is.EqualTo(v2.y));
            Assert.That("(9-1)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("((-10)-2)", "(6-3)", "((1-4)-9)", "((1-4)-9)");
            var v1 = "null";
            var v2 = v0.a;
            v0.a = v1;
            var v3 = v0.a;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-10)-2)", Is.EqualTo(v0.x));
            Assert.That("(6-3)", Is.EqualTo(v0.y));
            Assert.That("((1-4)-9)", Is.EqualTo(v0.z));
            Assert.That("null", Is.EqualTo(v0.w));
        
            Assert.That("((1-4)-9)", Is.EqualTo(v2));
        }
        {
            var v0 = new gvec4<string>("3", "(28)", "(28)", "-3");
            var v1 = new gvec2<string>("null", "((65)5)");
            var v2 = v0.ra;
            v0.ra = v1;
            var v3 = v0.ra;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("(28)", Is.EqualTo(v0.y));
            Assert.That("(28)", Is.EqualTo(v0.z));
            Assert.That("((65)5)", Is.EqualTo(v0.w));
        
            Assert.That("3", Is.EqualTo(v2.x));
            Assert.That("-3", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("8", "(8-2)", "(8-2)", "8");
            var v1 = new gvec2<string>("(2-5)", "-4");
            var v2 = v0.ga;
            v0.ga = v1;
            var v3 = v0.ga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("8", Is.EqualTo(v0.x));
            Assert.That("(2-5)", Is.EqualTo(v0.y));
            Assert.That("(8-2)", Is.EqualTo(v0.z));
            Assert.That("-4", Is.EqualTo(v0.w));
        
            Assert.That("(8-2)", Is.EqualTo(v2.x));
            Assert.That("8", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("((03)6)", "(-48)", "(58)", "6");
            var v1 = new gvec3<string>("((-1-5)-7)", "((-9-1)5)", "((-85)2)");
            var v2 = v0.rga;
            v0.rga = v1;
            var v3 = v0.rga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-1-5)-7)", Is.EqualTo(v0.x));
            Assert.That("((-9-1)5)", Is.EqualTo(v0.y));
            Assert.That("(58)", Is.EqualTo(v0.z));
            Assert.That("((-85)2)", Is.EqualTo(v0.w));
        
            Assert.That("((03)6)", Is.EqualTo(v2.x));
            Assert.That("(-48)", Is.EqualTo(v2.y));
            Assert.That("6", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("null", "-8", "null", "(0-9)");
            var v1 = new gvec2<string>("(-8-3)", "(-5-3)");
            var v2 = v0.ba;
            v0.ba = v1;
            var v3 = v0.ba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("-8", Is.EqualTo(v0.y));
            Assert.That("(-8-3)", Is.EqualTo(v0.z));
            Assert.That("(-5-3)", Is.EqualTo(v0.w));
        
            Assert.That("null", Is.EqualTo(v2.x));
            Assert.That("(0-9)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec4<string>("-2", "-2", "(-65)", "((55)-2)");
            var v1 = new gvec3<string>("1", "((-2-1)7)", "4");
            var v2 = v0.rba;
            v0.rba = v1;
            var v3 = v0.rba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("1", Is.EqualTo(v0.x));
            Assert.That("-2", Is.EqualTo(v0.y));
            Assert.That("((-2-1)7)", Is.EqualTo(v0.z));
            Assert.That("4", Is.EqualTo(v0.w));
        
            Assert.That("-2", Is.EqualTo(v2.x));
            Assert.That("(-65)", Is.EqualTo(v2.y));
            Assert.That("((55)-2)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("6", "(0-5)", "((-96)-6)", "((1-6)-9)");
            var v1 = new gvec3<string>("((-43)-8)", "(-86)", "(-86)");
            var v2 = v0.gba;
            v0.gba = v1;
            var v3 = v0.gba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("6", Is.EqualTo(v0.x));
            Assert.That("((-43)-8)", Is.EqualTo(v0.y));
            Assert.That("(-86)", Is.EqualTo(v0.z));
            Assert.That("(-86)", Is.EqualTo(v0.w));
        
            Assert.That("(0-5)", Is.EqualTo(v2.x));
            Assert.That("((-96)-6)", Is.EqualTo(v2.y));
            Assert.That("((1-6)-9)", Is.EqualTo(v2.z));
        }
        {
            var v0 = new gvec4<string>("-2", "((-85)6)", "((-1-6)1)", "-2");
            var v1 = new gvec4<string>("null", "1", "", "");
            var v2 = v0.rgba;
            v0.rgba = v1;
            var v3 = v0.rgba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("null", Is.EqualTo(v0.x));
            Assert.That("1", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
            Assert.That("", Is.EqualTo(v0.w));
        
            Assert.That("-2", Is.EqualTo(v2.x));
            Assert.That("((-85)6)", Is.EqualTo(v2.y));
            Assert.That("((-1-6)1)", Is.EqualTo(v2.z));
            Assert.That("-2", Is.EqualTo(v2.w));
        }
    }

}
