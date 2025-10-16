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
            var ov = new gvec3<string>("((46)-4)", "-1", "-1");
            var v = ov.swizzle.xx;
            Assert.That("((46)-4)", Is.EqualTo(v.x));
            Assert.That("((46)-4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>(null, "(66)", "(-55)");
            var v = ov.swizzle.xxx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>(null, "(6-6)", "2");
            var v = ov.swizzle.xxxx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "((0-2)-8)", "(8-3)");
            var v = ov.swizzle.xxxy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((0-2)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(36)", "6", "((-8-9)0)");
            var v = ov.swizzle.xxxz;
            Assert.That("(36)", Is.EqualTo(v.x));
            Assert.That("(36)", Is.EqualTo(v.y));
            Assert.That("(36)", Is.EqualTo(v.z));
            Assert.That("((-8-9)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(7-9)", "(7-9)", "((-50)-3)");
            var v = ov.swizzle.xxy;
            Assert.That("(7-9)", Is.EqualTo(v.x));
            Assert.That("(7-9)", Is.EqualTo(v.y));
            Assert.That("(7-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(2-2)", "", "((32)-2)");
            var v = ov.swizzle.xxyx;
            Assert.That("(2-2)", Is.EqualTo(v.x));
            Assert.That("(2-2)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(2-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-60)", "", null);
            var v = ov.swizzle.xxyy;
            Assert.That("(-60)", Is.EqualTo(v.x));
            Assert.That("(-60)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-29)-3)", "(6-6)", "((-39)9)");
            var v = ov.swizzle.xxyz;
            Assert.That("((-29)-3)", Is.EqualTo(v.x));
            Assert.That("((-29)-3)", Is.EqualTo(v.y));
            Assert.That("(6-6)", Is.EqualTo(v.z));
            Assert.That("((-39)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-2-6)", "((-9-7)-8)", "((3-3)1)");
            var v = ov.swizzle.xxz;
            Assert.That("(-2-6)", Is.EqualTo(v.x));
            Assert.That("(-2-6)", Is.EqualTo(v.y));
            Assert.That("((3-3)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>(null, "(-8-6)", "(-8-6)");
            var v = ov.swizzle.xxzx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(-8-6)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "", "((-3-8)3)");
            var v = ov.swizzle.xxzy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-3-8)3)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-1-9)", "1", null);
            var v = ov.swizzle.xxzz;
            Assert.That("(-1-9)", Is.EqualTo(v.x));
            Assert.That("(-1-9)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-9-9)", "", "((-8-1)4)");
            var v = ov.swizzle.xy;
            Assert.That("(-9-9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(45)", "3", "3");
            var v = ov.swizzle.xyx;
            Assert.That("(45)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(45)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-9", "((-4-2)-3)", "");
            var v = ov.swizzle.xyxx;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("((-4-2)-3)", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-73)", "7", "((-6-2)6)");
            var v = ov.swizzle.xyxy;
            Assert.That("(-73)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(-73)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(4-8)", null, "(78)");
            var v = ov.swizzle.xyxz;
            Assert.That("(4-8)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(4-8)", Is.EqualTo(v.z));
            Assert.That("(78)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-2-9)", "-2", "(-2-9)");
            var v = ov.swizzle.xyy;
            Assert.That("(-2-9)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-10)-3)", "", "((4-2)9)");
            var v = ov.swizzle.xyyx;
            Assert.That("((-10)-3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-10)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-5", "((90)-5)", "((-13)-2)");
            var v = ov.swizzle.xyyy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("((90)-5)", Is.EqualTo(v.y));
            Assert.That("((90)-5)", Is.EqualTo(v.z));
            Assert.That("((90)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "(-97)", "((-4-9)-7)");
            var v = ov.swizzle.xyyz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-97)", Is.EqualTo(v.y));
            Assert.That("(-97)", Is.EqualTo(v.z));
            Assert.That("((-4-9)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "(-81)", "((-6-3)9)");
            var v = ov.swizzle.xyz;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("(-81)", Is.EqualTo(v.y));
            Assert.That("((-6-3)9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("1", "((8-6)4)", "9");
            var v = ov.swizzle.xyzx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((8-6)4)", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "(-86)", "(-3-6)");
            var v = ov.swizzle.xyzy;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(-86)", Is.EqualTo(v.y));
            Assert.That("(-3-6)", Is.EqualTo(v.z));
            Assert.That("(-86)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "(0-8)", "4");
            var v = ov.swizzle.xyzz;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("(0-8)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-78)2)", "5", "((-44)-6)");
            var v = ov.swizzle.xz;
            Assert.That("((-78)2)", Is.EqualTo(v.x));
            Assert.That("((-44)-6)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "-1", "6");
            var v = ov.swizzle.xzx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("7", "6", "((85)1)");
            var v = ov.swizzle.xzxx;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((85)1)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "", "-5");
            var v = ov.swizzle.xzxy;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-86)", null, "(-86)");
            var v = ov.swizzle.xzxz;
            Assert.That("(-86)", Is.EqualTo(v.x));
            Assert.That("(-86)", Is.EqualTo(v.y));
            Assert.That("(-86)", Is.EqualTo(v.z));
            Assert.That("(-86)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-34)9)", "((6-9)1)", "");
            var v = ov.swizzle.xzy;
            Assert.That("((-34)9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((6-9)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("9", "3", "-3");
            var v = ov.swizzle.xzyx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "((78)-9)", "((78)-9)");
            var v = ov.swizzle.xzyy;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("((78)-9)", Is.EqualTo(v.y));
            Assert.That("((78)-9)", Is.EqualTo(v.z));
            Assert.That("((78)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-18)8)", "((-18)8)");
            var v = ov.swizzle.xzyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-18)8)", Is.EqualTo(v.y));
            Assert.That("((-18)8)", Is.EqualTo(v.z));
            Assert.That("((-18)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("5", "(67)", "1");
            var v = ov.swizzle.xzz;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-6", "(54)", "(79)");
            var v = ov.swizzle.xzzx;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("(79)", Is.EqualTo(v.y));
            Assert.That("(79)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-31)3)", null, "((-31)3)");
            var v = ov.swizzle.xzzy;
            Assert.That("((-31)3)", Is.EqualTo(v.x));
            Assert.That("((-31)3)", Is.EqualTo(v.y));
            Assert.That("((-31)3)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", null, "3");
            var v = ov.swizzle.xzzz;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(-7-1)", "(-4-1)");
            var v = ov.swizzle.yx;
            Assert.That("(-7-1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("2", "", "((-4-1)-4)");
            var v = ov.swizzle.yxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-8", "(-1-7)", null);
            var v = ov.swizzle.yxxx;
            Assert.That("(-1-7)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-5-9)4)", "(-28)", "((-5-9)4)");
            var v = ov.swizzle.yxxy;
            Assert.That("(-28)", Is.EqualTo(v.x));
            Assert.That("((-5-9)4)", Is.EqualTo(v.y));
            Assert.That("((-5-9)4)", Is.EqualTo(v.z));
            Assert.That("(-28)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "", "(1-9)");
            var v = ov.swizzle.yxxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(1-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", null, "(2-5)");
            var v = ov.swizzle.yxy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "-9", "(-2-2)");
            var v = ov.swizzle.yxyx;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-7-1)", "(-5-5)", "4");
            var v = ov.swizzle.yxyy;
            Assert.That("(-5-5)", Is.EqualTo(v.x));
            Assert.That("(-7-1)", Is.EqualTo(v.y));
            Assert.That("(-5-5)", Is.EqualTo(v.z));
            Assert.That("(-5-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "-3", null);
            var v = ov.swizzle.yxyz;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((6-4)-6)", "((96)-4)", "-3");
            var v = ov.swizzle.yxz;
            Assert.That("((96)-4)", Is.EqualTo(v.x));
            Assert.That("((6-4)-6)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(85)", "((-27)9)", "((-27)9)");
            var v = ov.swizzle.yxzx;
            Assert.That("((-27)9)", Is.EqualTo(v.x));
            Assert.That("(85)", Is.EqualTo(v.y));
            Assert.That("((-27)9)", Is.EqualTo(v.z));
            Assert.That("(85)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(18)", "((-9-9)-6)", "(71)");
            var v = ov.swizzle.yxzy;
            Assert.That("((-9-9)-6)", Is.EqualTo(v.x));
            Assert.That("(18)", Is.EqualTo(v.y));
            Assert.That("(71)", Is.EqualTo(v.z));
            Assert.That("((-9-9)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((9-1)-1)", "", "(-26)");
            var v = ov.swizzle.yxzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((9-1)-1)", Is.EqualTo(v.y));
            Assert.That("(-26)", Is.EqualTo(v.z));
            Assert.That("(-26)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "((5-8)0)", "((-7-1)-9)");
            var v = ov.swizzle.yy;
            Assert.That("((5-8)0)", Is.EqualTo(v.x));
            Assert.That("((5-8)0)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((73)-1)", "((-8-2)6)", "(64)");
            var v = ov.swizzle.yyx;
            Assert.That("((-8-2)6)", Is.EqualTo(v.x));
            Assert.That("((-8-2)6)", Is.EqualTo(v.y));
            Assert.That("((73)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("4", "((-2-6)-2)", "((-1-9)1)");
            var v = ov.swizzle.yyxx;
            Assert.That("((-2-6)-2)", Is.EqualTo(v.x));
            Assert.That("((-2-6)-2)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "-5", "-5");
            var v = ov.swizzle.yyxy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("-5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((0-9)6)", "-1", null);
            var v = ov.swizzle.yyxz;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((0-9)6)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "-6", "");
            var v = ov.swizzle.yyy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "(81)", "((7-8)1)");
            var v = ov.swizzle.yyyx;
            Assert.That("(81)", Is.EqualTo(v.x));
            Assert.That("(81)", Is.EqualTo(v.y));
            Assert.That("(81)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "-9", "(8-2)");
            var v = ov.swizzle.yyyy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("-9", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(1-9)", "-1", "((-90)4)");
            var v = ov.swizzle.yyyz;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("((-90)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-58)8)", "((0-9)1)", "(81)");
            var v = ov.swizzle.yyz;
            Assert.That("((0-9)1)", Is.EqualTo(v.x));
            Assert.That("((0-9)1)", Is.EqualTo(v.y));
            Assert.That("(81)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-95)0)", "-1", "((74)-2)");
            var v = ov.swizzle.yyzx;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((74)-2)", Is.EqualTo(v.z));
            Assert.That("((-95)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(2-1)", "(2-1)", "(2-1)");
            var v = ov.swizzle.yyzy;
            Assert.That("(2-1)", Is.EqualTo(v.x));
            Assert.That("(2-1)", Is.EqualTo(v.y));
            Assert.That("(2-1)", Is.EqualTo(v.z));
            Assert.That("(2-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((8-1)-4)", "((-64)2)", "(45)");
            var v = ov.swizzle.yyzz;
            Assert.That("((-64)2)", Is.EqualTo(v.x));
            Assert.That("((-64)2)", Is.EqualTo(v.y));
            Assert.That("(45)", Is.EqualTo(v.z));
            Assert.That("(45)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((7-4)6)", "", "0");
            var v = ov.swizzle.yz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>(null, null, "");
            var v = ov.swizzle.yzx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-3", "3", "-3");
            var v = ov.swizzle.yzxx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(10)", "", "0");
            var v = ov.swizzle.yzxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("(10)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-14)-1)", "", "((-21)6)");
            var v = ov.swizzle.yzxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-21)6)", Is.EqualTo(v.y));
            Assert.That("((-14)-1)", Is.EqualTo(v.z));
            Assert.That("((-21)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(6-5)", "((53)6)", "-9");
            var v = ov.swizzle.yzy;
            Assert.That("((53)6)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((53)6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-8-4)", "((9-3)3)", null);
            var v = ov.swizzle.yzyx;
            Assert.That("((9-3)3)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((9-3)3)", Is.EqualTo(v.z));
            Assert.That("(-8-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "8", "((6-9)-9)");
            var v = ov.swizzle.yzyy;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("((6-9)-9)", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-2", "-2", "((-25)8)");
            var v = ov.swizzle.yzyz;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((-25)8)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("((-25)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((92)8)", "", "3");
            var v = ov.swizzle.yzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(4-6)", "((30)5)", "(-4-3)");
            var v = ov.swizzle.yzzx;
            Assert.That("((30)5)", Is.EqualTo(v.x));
            Assert.That("(-4-3)", Is.EqualTo(v.y));
            Assert.That("(-4-3)", Is.EqualTo(v.z));
            Assert.That("(4-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "8", "8");
            var v = ov.swizzle.yzzy;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "((74)-6)", "((-6-2)-6)");
            var v = ov.swizzle.yzzz;
            Assert.That("((74)-6)", Is.EqualTo(v.x));
            Assert.That("((-6-2)-6)", Is.EqualTo(v.y));
            Assert.That("((-6-2)-6)", Is.EqualTo(v.z));
            Assert.That("((-6-2)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "", "(-4-6)");
            var v = ov.swizzle.zx;
            Assert.That("(-4-6)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("3", "3", "-6");
            var v = ov.swizzle.zxx;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("2", "", "(-3-6)");
            var v = ov.swizzle.zxxx;
            Assert.That("(-3-6)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(2-9)", "1", "(0-1)");
            var v = ov.swizzle.zxxy;
            Assert.That("(0-1)", Is.EqualTo(v.x));
            Assert.That("(2-9)", Is.EqualTo(v.y));
            Assert.That("(2-9)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-1-1)", "5", "-8");
            var v = ov.swizzle.zxxz;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(-1-1)", Is.EqualTo(v.y));
            Assert.That("(-1-1)", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "((-31)-1)", "");
            var v = ov.swizzle.zxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("((-31)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-6", "((07)-3)", "((-9-1)9)");
            var v = ov.swizzle.zxyx;
            Assert.That("((-9-1)9)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("((07)-3)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((66)-8)", "(5-5)", "(-6-7)");
            var v = ov.swizzle.zxyy;
            Assert.That("(-6-7)", Is.EqualTo(v.x));
            Assert.That("((66)-8)", Is.EqualTo(v.y));
            Assert.That("(5-5)", Is.EqualTo(v.z));
            Assert.That("(5-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-9-5)", "((57)-7)", "");
            var v = ov.swizzle.zxyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-9-5)", Is.EqualTo(v.y));
            Assert.That("((57)-7)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-20)3)", "(-8-4)");
            var v = ov.swizzle.zxz;
            Assert.That("(-8-4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-8-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-25)4)", null, "(89)");
            var v = ov.swizzle.zxzx;
            Assert.That("(89)", Is.EqualTo(v.x));
            Assert.That("((-25)4)", Is.EqualTo(v.y));
            Assert.That("(89)", Is.EqualTo(v.z));
            Assert.That("((-25)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, null, "((-39)0)");
            var v = ov.swizzle.zxzy;
            Assert.That("((-39)0)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-39)0)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "1", "(-3-7)");
            var v = ov.swizzle.zxzz;
            Assert.That("(-3-7)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("(-3-7)", Is.EqualTo(v.z));
            Assert.That("(-3-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-2", "", "((-2-8)1)");
            var v = ov.swizzle.zy;
            Assert.That("((-2-8)1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "(84)", "((0-5)4)");
            var v = ov.swizzle.zyx;
            Assert.That("((0-5)4)", Is.EqualTo(v.x));
            Assert.That("(84)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-2", "6", "6");
            var v = ov.swizzle.zyxx;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "-9", "((51)4)");
            var v = ov.swizzle.zyxy;
            Assert.That("((51)4)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("-9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-2-5)8)", "((-2-5)8)", "((1-9)3)");
            var v = ov.swizzle.zyxz;
            Assert.That("((1-9)3)", Is.EqualTo(v.x));
            Assert.That("((-2-5)8)", Is.EqualTo(v.y));
            Assert.That("((-2-5)8)", Is.EqualTo(v.z));
            Assert.That("((1-9)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "((79)0)", "((-80)-9)");
            var v = ov.swizzle.zyy;
            Assert.That("((-80)-9)", Is.EqualTo(v.x));
            Assert.That("((79)0)", Is.EqualTo(v.y));
            Assert.That("((79)0)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-7-8)-8)", "(5-4)", "9");
            var v = ov.swizzle.zyyx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(5-4)", Is.EqualTo(v.y));
            Assert.That("(5-4)", Is.EqualTo(v.z));
            Assert.That("((-7-8)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "(-4-5)", "-3");
            var v = ov.swizzle.zyyy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(-4-5)", Is.EqualTo(v.y));
            Assert.That("(-4-5)", Is.EqualTo(v.z));
            Assert.That("(-4-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "9", "((-72)-5)");
            var v = ov.swizzle.zyyz;
            Assert.That("((-72)-5)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("((-72)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(-5-4)", "-3");
            var v = ov.swizzle.zyz;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(-5-4)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((1-5)-3)", "((1-5)-3)", "((-80)2)");
            var v = ov.swizzle.zyzx;
            Assert.That("((-80)2)", Is.EqualTo(v.x));
            Assert.That("((1-5)-3)", Is.EqualTo(v.y));
            Assert.That("((-80)2)", Is.EqualTo(v.z));
            Assert.That("((1-5)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "4", "((54)-3)");
            var v = ov.swizzle.zyzy;
            Assert.That("((54)-3)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("((54)-3)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-1-9)", "((-11)2)", "((88)4)");
            var v = ov.swizzle.zyzz;
            Assert.That("((88)4)", Is.EqualTo(v.x));
            Assert.That("((-11)2)", Is.EqualTo(v.y));
            Assert.That("((88)4)", Is.EqualTo(v.z));
            Assert.That("((88)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-9-5)-4)", "", "(93)");
            var v = ov.swizzle.zz;
            Assert.That("(93)", Is.EqualTo(v.x));
            Assert.That("(93)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>(null, "", "0");
            var v = ov.swizzle.zzx;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-3", "-3", "((-10)2)");
            var v = ov.swizzle.zzxx;
            Assert.That("((-10)2)", Is.EqualTo(v.x));
            Assert.That("((-10)2)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-18)", "((1-3)0)", "((24)-5)");
            var v = ov.swizzle.zzxy;
            Assert.That("((24)-5)", Is.EqualTo(v.x));
            Assert.That("((24)-5)", Is.EqualTo(v.y));
            Assert.That("(-18)", Is.EqualTo(v.z));
            Assert.That("((1-3)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-5", "((44)6)", "-3");
            var v = ov.swizzle.zzxz;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((78)2)", "(7-7)", "-9");
            var v = ov.swizzle.zzy;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("(7-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-78)", "((-3-5)5)", "");
            var v = ov.swizzle.zzyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-3-5)5)", Is.EqualTo(v.z));
            Assert.That("(-78)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(9-6)", "((0-1)6)", "(-6-6)");
            var v = ov.swizzle.zzyy;
            Assert.That("(-6-6)", Is.EqualTo(v.x));
            Assert.That("(-6-6)", Is.EqualTo(v.y));
            Assert.That("((0-1)6)", Is.EqualTo(v.z));
            Assert.That("((0-1)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "", "((19)-9)");
            var v = ov.swizzle.zzyz;
            Assert.That("((19)-9)", Is.EqualTo(v.x));
            Assert.That("((19)-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((19)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "(-79)", "");
            var v = ov.swizzle.zzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((7-7)-2)", "((6-6)-5)", "(4-8)");
            var v = ov.swizzle.zzzx;
            Assert.That("(4-8)", Is.EqualTo(v.x));
            Assert.That("(4-8)", Is.EqualTo(v.y));
            Assert.That("(4-8)", Is.EqualTo(v.z));
            Assert.That("((7-7)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "(30)", "(30)");
            var v = ov.swizzle.zzzy;
            Assert.That("(30)", Is.EqualTo(v.x));
            Assert.That("(30)", Is.EqualTo(v.y));
            Assert.That("(30)", Is.EqualTo(v.z));
            Assert.That("(30)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "(-1-1)", "((-35)-2)");
            var v = ov.swizzle.zzzz;
            Assert.That("((-35)-2)", Is.EqualTo(v.x));
            Assert.That("((-35)-2)", Is.EqualTo(v.y));
            Assert.That("((-35)-2)", Is.EqualTo(v.z));
            Assert.That("((-35)-2)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec3<string>(null, "(-2-1)", "((7-5)-9)");
            var v = ov.swizzle.rr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(-80)", "((1-5)2)", "((90)0)");
            var v = ov.swizzle.rrr;
            Assert.That("(-80)", Is.EqualTo(v.x));
            Assert.That("(-80)", Is.EqualTo(v.y));
            Assert.That("(-80)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-93)-5)", null, null);
            var v = ov.swizzle.rrrr;
            Assert.That("((-93)-5)", Is.EqualTo(v.x));
            Assert.That("((-93)-5)", Is.EqualTo(v.y));
            Assert.That("((-93)-5)", Is.EqualTo(v.z));
            Assert.That("((-93)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", "-4", "(11)");
            var v = ov.swizzle.rrrg;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(39)", "2", "8");
            var v = ov.swizzle.rrrb;
            Assert.That("(39)", Is.EqualTo(v.x));
            Assert.That("(39)", Is.EqualTo(v.y));
            Assert.That("(39)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", null, "((79)-8)");
            var v = ov.swizzle.rrg;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-98)", null, "(38)");
            var v = ov.swizzle.rrgr;
            Assert.That("(-98)", Is.EqualTo(v.x));
            Assert.That("(-98)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(-98)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("5", "5", "((79)1)");
            var v = ov.swizzle.rrgg;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-7-7)0)", "-5", null);
            var v = ov.swizzle.rrgb;
            Assert.That("((-7-7)0)", Is.EqualTo(v.x));
            Assert.That("((-7-7)0)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-6-4)1)", null, "((77)8)");
            var v = ov.swizzle.rrb;
            Assert.That("((-6-4)1)", Is.EqualTo(v.x));
            Assert.That("((-6-4)1)", Is.EqualTo(v.y));
            Assert.That("((77)8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((9-1)-9)", "(20)", null);
            var v = ov.swizzle.rrbr;
            Assert.That("((9-1)-9)", Is.EqualTo(v.x));
            Assert.That("((9-1)-9)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((9-1)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "3", "(28)");
            var v = ov.swizzle.rrbg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(28)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-26)", "((-6-8)3)", "((-6-8)3)");
            var v = ov.swizzle.rrbb;
            Assert.That("(-26)", Is.EqualTo(v.x));
            Assert.That("(-26)", Is.EqualTo(v.y));
            Assert.That("((-6-8)3)", Is.EqualTo(v.z));
            Assert.That("((-6-8)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-20)", "", "-5");
            var v = ov.swizzle.rg;
            Assert.That("(-20)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-9-2)4)", "-3", "((-15)1)");
            var v = ov.swizzle.rgr;
            Assert.That("((-9-2)4)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("((-9-2)4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "", "((63)6)");
            var v = ov.swizzle.rgrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-8-9)", "-4", "(-64)");
            var v = ov.swizzle.rgrg;
            Assert.That("(-8-9)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(-8-9)", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "8", "(-15)");
            var v = ov.swizzle.rgrb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-15)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(08)", "(-8-8)");
            var v = ov.swizzle.rgg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(08)", Is.EqualTo(v.y));
            Assert.That("(08)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((53)9)", "5", "-4");
            var v = ov.swizzle.rggr;
            Assert.That("((53)9)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("((53)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "((91)-3)", "(-9-3)");
            var v = ov.swizzle.rggg;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("((91)-3)", Is.EqualTo(v.y));
            Assert.That("((91)-3)", Is.EqualTo(v.z));
            Assert.That("((91)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-2-9)", "(-2-3)", "(-2-9)");
            var v = ov.swizzle.rggb;
            Assert.That("(-2-9)", Is.EqualTo(v.x));
            Assert.That("(-2-3)", Is.EqualTo(v.y));
            Assert.That("(-2-3)", Is.EqualTo(v.z));
            Assert.That("(-2-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", "(-63)", "((02)7)");
            var v = ov.swizzle.rgb;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("(-63)", Is.EqualTo(v.y));
            Assert.That("((02)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(2-6)", "", "(2-6)");
            var v = ov.swizzle.rgbr;
            Assert.That("(2-6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(2-6)", Is.EqualTo(v.z));
            Assert.That("(2-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "-2", null);
            var v = ov.swizzle.rgbg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "((-76)-3)", "(-1-6)");
            var v = ov.swizzle.rgbb;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((-76)-3)", Is.EqualTo(v.y));
            Assert.That("(-1-6)", Is.EqualTo(v.z));
            Assert.That("(-1-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, null, "-6");
            var v = ov.swizzle.rb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>(null, "8", "8");
            var v = ov.swizzle.rbr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "1", "(89)");
            var v = ov.swizzle.rbrr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(89)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-5", "(-28)", "((-97)-2)");
            var v = ov.swizzle.rbrg;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("((-97)-2)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("(-28)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "((-8-7)-7)", "2");
            var v = ov.swizzle.rbrb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((00)1)", "((00)1)", "(07)");
            var v = ov.swizzle.rbg;
            Assert.That("((00)1)", Is.EqualTo(v.x));
            Assert.That("(07)", Is.EqualTo(v.y));
            Assert.That("((00)1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(61)", "((-65)2)", "-8");
            var v = ov.swizzle.rbgr;
            Assert.That("(61)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("((-65)2)", Is.EqualTo(v.z));
            Assert.That("(61)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "(-61)", "-2");
            var v = ov.swizzle.rbgg;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("(-61)", Is.EqualTo(v.z));
            Assert.That("(-61)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", "(25)", "((2-3)-1)");
            var v = ov.swizzle.rbgb;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((2-3)-1)", Is.EqualTo(v.y));
            Assert.That("(25)", Is.EqualTo(v.z));
            Assert.That("((2-3)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-26)0)", "-4", "-4");
            var v = ov.swizzle.rbb;
            Assert.That("((-26)0)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "", "(-49)");
            var v = ov.swizzle.rbbr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-49)", Is.EqualTo(v.y));
            Assert.That("(-49)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-8-3)-2)", "(4-1)", "9");
            var v = ov.swizzle.rbbg;
            Assert.That("((-8-3)-2)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("(4-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "(48)", "(48)");
            var v = ov.swizzle.rbbb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(48)", Is.EqualTo(v.y));
            Assert.That("(48)", Is.EqualTo(v.z));
            Assert.That("(48)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-1-5)-5)", "((-1-5)-5)", "(3-4)");
            var v = ov.swizzle.gr;
            Assert.That("((-1-5)-5)", Is.EqualTo(v.x));
            Assert.That("((-1-5)-5)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("-3", "(-86)", "-3");
            var v = ov.swizzle.grr;
            Assert.That("(-86)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-34)", "(89)", "(-51)");
            var v = ov.swizzle.grrr;
            Assert.That("(89)", Is.EqualTo(v.x));
            Assert.That("(-34)", Is.EqualTo(v.y));
            Assert.That("(-34)", Is.EqualTo(v.z));
            Assert.That("(-34)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(8-1)", "(8-1)", "(7-4)");
            var v = ov.swizzle.grrg;
            Assert.That("(8-1)", Is.EqualTo(v.x));
            Assert.That("(8-1)", Is.EqualTo(v.y));
            Assert.That("(8-1)", Is.EqualTo(v.z));
            Assert.That("(8-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-53)", "((-77)3)", "7");
            var v = ov.swizzle.grrb;
            Assert.That("((-77)3)", Is.EqualTo(v.x));
            Assert.That("(-53)", Is.EqualTo(v.y));
            Assert.That("(-53)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", null, "((81)-3)");
            var v = ov.swizzle.grg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-3", "((-1-5)-2)", null);
            var v = ov.swizzle.grgr;
            Assert.That("((-1-5)-2)", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("((-1-5)-2)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-2-5)", "((-3-8)4)", "-9");
            var v = ov.swizzle.grgg;
            Assert.That("((-3-8)4)", Is.EqualTo(v.x));
            Assert.That("(-2-5)", Is.EqualTo(v.y));
            Assert.That("((-3-8)4)", Is.EqualTo(v.z));
            Assert.That("((-3-8)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-2", "-2", "(-76)");
            var v = ov.swizzle.grgb;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("(-76)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(9-6)", "(-3-2)", "((74)-9)");
            var v = ov.swizzle.grb;
            Assert.That("(-3-2)", Is.EqualTo(v.x));
            Assert.That("(9-6)", Is.EqualTo(v.y));
            Assert.That("((74)-9)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((9-5)4)", "-8", "((9-5)4)");
            var v = ov.swizzle.grbr;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((9-5)4)", Is.EqualTo(v.y));
            Assert.That("((9-5)4)", Is.EqualTo(v.z));
            Assert.That("((9-5)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((2-2)2)", "((20)-7)", "((-18)3)");
            var v = ov.swizzle.grbg;
            Assert.That("((20)-7)", Is.EqualTo(v.x));
            Assert.That("((2-2)2)", Is.EqualTo(v.y));
            Assert.That("((-18)3)", Is.EqualTo(v.z));
            Assert.That("((20)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-83)-7)", "(-83)", "((8-3)-3)");
            var v = ov.swizzle.grbb;
            Assert.That("(-83)", Is.EqualTo(v.x));
            Assert.That("((-83)-7)", Is.EqualTo(v.y));
            Assert.That("((8-3)-3)", Is.EqualTo(v.z));
            Assert.That("((8-3)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", "", null);
            var v = ov.swizzle.gg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "((-41)-1)", "((6-3)9)");
            var v = ov.swizzle.ggr;
            Assert.That("((-41)-1)", Is.EqualTo(v.x));
            Assert.That("((-41)-1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "((8-5)-5)", "5");
            var v = ov.swizzle.ggrr;
            Assert.That("((8-5)-5)", Is.EqualTo(v.x));
            Assert.That("((8-5)-5)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "(-4-1)", "((-71)2)");
            var v = ov.swizzle.ggrg;
            Assert.That("(-4-1)", Is.EqualTo(v.x));
            Assert.That("(-4-1)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("(-4-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", null, "7");
            var v = ov.swizzle.ggrb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-30)-4)", "-7", "((-30)-4)");
            var v = ov.swizzle.ggg;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((32)1)", null, "(-64)");
            var v = ov.swizzle.gggr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((32)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-4-5)1)", "((-31)-2)", "(1-4)");
            var v = ov.swizzle.gggg;
            Assert.That("((-31)-2)", Is.EqualTo(v.x));
            Assert.That("((-31)-2)", Is.EqualTo(v.y));
            Assert.That("((-31)-2)", Is.EqualTo(v.z));
            Assert.That("((-31)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((5-8)3)", "(9-8)", "");
            var v = ov.swizzle.gggb;
            Assert.That("(9-8)", Is.EqualTo(v.x));
            Assert.That("(9-8)", Is.EqualTo(v.y));
            Assert.That("(9-8)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-35)", null, null);
            var v = ov.swizzle.ggb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("9", "((-70)1)", null);
            var v = ov.swizzle.ggbr;
            Assert.That("((-70)1)", Is.EqualTo(v.x));
            Assert.That("((-70)1)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((3-3)-1)", "3", null);
            var v = ov.swizzle.ggbg;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(05)", "-9", "(-8-6)");
            var v = ov.swizzle.ggbb;
            Assert.That("-9", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("(-8-6)", Is.EqualTo(v.z));
            Assert.That("(-8-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(16)", "-3", "3");
            var v = ov.swizzle.gb;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("-2", "((-3-5)7)", null);
            var v = ov.swizzle.gbr;
            Assert.That("((-3-5)7)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("7", "(-43)", "8");
            var v = ov.swizzle.gbrr;
            Assert.That("(-43)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "", "(-35)");
            var v = ov.swizzle.gbrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-35)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-89)", "1", "((17)1)");
            var v = ov.swizzle.gbrb;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((17)1)", Is.EqualTo(v.y));
            Assert.That("(-89)", Is.EqualTo(v.z));
            Assert.That("((17)1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "(80)", "(80)");
            var v = ov.swizzle.gbg;
            Assert.That("(80)", Is.EqualTo(v.x));
            Assert.That("(80)", Is.EqualTo(v.y));
            Assert.That("(80)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((22)-6)", null, "");
            var v = ov.swizzle.gbgr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((22)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "", "0");
            var v = ov.swizzle.gbgg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-3-8)1)", "(-87)", "(8-1)");
            var v = ov.swizzle.gbgb;
            Assert.That("(-87)", Is.EqualTo(v.x));
            Assert.That("(8-1)", Is.EqualTo(v.y));
            Assert.That("(-87)", Is.EqualTo(v.z));
            Assert.That("(8-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(7-4)", "(3-9)", "");
            var v = ov.swizzle.gbb;
            Assert.That("(3-9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-71)9)", "(-32)", "-2");
            var v = ov.swizzle.gbbr;
            Assert.That("(-32)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("((-71)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-92)5)", "-3", "((-65)0)");
            var v = ov.swizzle.gbbg;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("((-65)0)", Is.EqualTo(v.y));
            Assert.That("((-65)0)", Is.EqualTo(v.z));
            Assert.That("-3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-42)0)", "-3", "(-53)");
            var v = ov.swizzle.gbbb;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(-53)", Is.EqualTo(v.y));
            Assert.That("(-53)", Is.EqualTo(v.z));
            Assert.That("(-53)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("0", "(-7-9)", null);
            var v = ov.swizzle.br;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("7", "(91)", "7");
            var v = ov.swizzle.brr;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-92)", "6", "-3");
            var v = ov.swizzle.brrr;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(-92)", Is.EqualTo(v.y));
            Assert.That("(-92)", Is.EqualTo(v.z));
            Assert.That("(-92)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("0", "9", null);
            var v = ov.swizzle.brrg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("9", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(58)", "1", "1");
            var v = ov.swizzle.brrb;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(58)", Is.EqualTo(v.y));
            Assert.That("(58)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(4-2)", "7", "");
            var v = ov.swizzle.brg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(4-2)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("8", "(-90)", "8");
            var v = ov.swizzle.brgr;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-90)", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-81)-8)", "((-81)-8)", "-2");
            var v = ov.swizzle.brgg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("((-81)-8)", Is.EqualTo(v.y));
            Assert.That("((-81)-8)", Is.EqualTo(v.z));
            Assert.That("((-81)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "(88)", "");
            var v = ov.swizzle.brgb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("(88)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-71)-9)", "3", "((-6-5)-4)");
            var v = ov.swizzle.brb;
            Assert.That("((-6-5)-4)", Is.EqualTo(v.x));
            Assert.That("((-71)-9)", Is.EqualTo(v.y));
            Assert.That("((-6-5)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("3", "", "((33)-7)");
            var v = ov.swizzle.brbr;
            Assert.That("((33)-7)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((33)-7)", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "(17)", "(2-4)");
            var v = ov.swizzle.brbg;
            Assert.That("(2-4)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(2-4)", Is.EqualTo(v.z));
            Assert.That("(17)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "", "(-7-5)");
            var v = ov.swizzle.brbb;
            Assert.That("(-7-5)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(-7-5)", Is.EqualTo(v.z));
            Assert.That("(-7-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-84)", "((89)7)", "((89)7)");
            var v = ov.swizzle.bg;
            Assert.That("((89)7)", Is.EqualTo(v.x));
            Assert.That("((89)7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("-6", "(-77)", "-4");
            var v = ov.swizzle.bgr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(-77)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-2-4)", "", null);
            var v = ov.swizzle.bgrr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-2-4)", Is.EqualTo(v.z));
            Assert.That("(-2-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-1-2)2)", "-1", "((-86)-6)");
            var v = ov.swizzle.bgrg;
            Assert.That("((-86)-6)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("((-1-2)2)", Is.EqualTo(v.z));
            Assert.That("-1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-1-4)", "-3", "");
            var v = ov.swizzle.bgrb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("(-1-4)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "(35)", "((-8-4)-3)");
            var v = ov.swizzle.bgg;
            Assert.That("((-8-4)-3)", Is.EqualTo(v.x));
            Assert.That("(35)", Is.EqualTo(v.y));
            Assert.That("(35)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-2", "(-58)", "-3");
            var v = ov.swizzle.bggr;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("(-58)", Is.EqualTo(v.y));
            Assert.That("(-58)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-99)", "((07)-1)", "-4");
            var v = ov.swizzle.bggg;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("((07)-1)", Is.EqualTo(v.y));
            Assert.That("((07)-1)", Is.EqualTo(v.z));
            Assert.That("((07)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-58)-1)", "0", "(80)");
            var v = ov.swizzle.bggb;
            Assert.That("(80)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("(80)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((8-7)-2)", "", "((94)-5)");
            var v = ov.swizzle.bgb;
            Assert.That("((94)-5)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((94)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-71)", "(-71)", "(0-4)");
            var v = ov.swizzle.bgbr;
            Assert.That("(0-4)", Is.EqualTo(v.x));
            Assert.That("(-71)", Is.EqualTo(v.y));
            Assert.That("(0-4)", Is.EqualTo(v.z));
            Assert.That("(-71)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-81)", "(-81)", "((-74)-8)");
            var v = ov.swizzle.bgbg;
            Assert.That("((-74)-8)", Is.EqualTo(v.x));
            Assert.That("(-81)", Is.EqualTo(v.y));
            Assert.That("((-74)-8)", Is.EqualTo(v.z));
            Assert.That("(-81)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(9-4)", "(15)", "((-15)3)");
            var v = ov.swizzle.bgbb;
            Assert.That("((-15)3)", Is.EqualTo(v.x));
            Assert.That("(15)", Is.EqualTo(v.y));
            Assert.That("((-15)3)", Is.EqualTo(v.z));
            Assert.That("((-15)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-34)3)", "((-50)1)", "((66)-9)");
            var v = ov.swizzle.bb;
            Assert.That("((66)-9)", Is.EqualTo(v.x));
            Assert.That("((66)-9)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "((-40)8)", "(45)");
            var v = ov.swizzle.bbr;
            Assert.That("(45)", Is.EqualTo(v.x));
            Assert.That("(45)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("5", "((20)-4)", "((9-2)9)");
            var v = ov.swizzle.bbrr;
            Assert.That("((9-2)9)", Is.EqualTo(v.x));
            Assert.That("((9-2)9)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "((-49)-9)", "((-4-2)-4)");
            var v = ov.swizzle.bbrg;
            Assert.That("((-4-2)-4)", Is.EqualTo(v.x));
            Assert.That("((-4-2)-4)", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("((-49)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "9", "((-97)-1)");
            var v = ov.swizzle.bbrb;
            Assert.That("((-97)-1)", Is.EqualTo(v.x));
            Assert.That("((-97)-1)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-97)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-63)-1)", "4", "((-6-5)2)");
            var v = ov.swizzle.bbg;
            Assert.That("((-6-5)2)", Is.EqualTo(v.x));
            Assert.That("((-6-5)2)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>(null, "(48)", "5");
            var v = ov.swizzle.bbgr;
            Assert.That("5", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("(48)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((1-8)-8)", "((6-5)-6)", "((6-5)-6)");
            var v = ov.swizzle.bbgg;
            Assert.That("((6-5)-6)", Is.EqualTo(v.x));
            Assert.That("((6-5)-6)", Is.EqualTo(v.y));
            Assert.That("((6-5)-6)", Is.EqualTo(v.z));
            Assert.That("((6-5)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "3", "(-3-5)");
            var v = ov.swizzle.bbgb;
            Assert.That("(-3-5)", Is.EqualTo(v.x));
            Assert.That("(-3-5)", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("(-3-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "", "");
            var v = ov.swizzle.bbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-4-9)-6)", "((-94)-6)", "((-94)-6)");
            var v = ov.swizzle.bbbr;
            Assert.That("((-94)-6)", Is.EqualTo(v.x));
            Assert.That("((-94)-6)", Is.EqualTo(v.y));
            Assert.That("((-94)-6)", Is.EqualTo(v.z));
            Assert.That("((-4-9)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-38)-3)", "", "((-38)-3)");
            var v = ov.swizzle.bbbg;
            Assert.That("((-38)-3)", Is.EqualTo(v.x));
            Assert.That("((-38)-3)", Is.EqualTo(v.y));
            Assert.That("((-38)-3)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(17)", "", "((76)-4)");
            var v = ov.swizzle.bbbb;
            Assert.That("((76)-4)", Is.EqualTo(v.x));
            Assert.That("((76)-4)", Is.EqualTo(v.y));
            Assert.That("((76)-4)", Is.EqualTo(v.z));
            Assert.That("((76)-4)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec3<string>(null, "((38)9)", "");
            var v1 = new gvec2<string>("((-88)7)", "((-8-3)-3)");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-88)7)", Is.EqualTo(v0.x));
            Assert.That("((-8-3)-3)", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
        
            Assert.That(null, Is.EqualTo(v2.x));
            Assert.That("((38)9)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("(-53)", "((99)8)", null);
            var v1 = new gvec2<string>(null, "9");
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(null, Is.EqualTo(v0.x));
            Assert.That("((99)8)", Is.EqualTo(v0.y));
            Assert.That("9", Is.EqualTo(v0.z));
        
            Assert.That("(-53)", Is.EqualTo(v2.x));
            Assert.That(null, Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("(0-9)", "((88)-2)", "((-63)-4)");
            var v1 = new gvec2<string>("6", "(36)");
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(0-9)", Is.EqualTo(v0.x));
            Assert.That("6", Is.EqualTo(v0.y));
            Assert.That("(36)", Is.EqualTo(v0.z));
        
            Assert.That("((88)-2)", Is.EqualTo(v2.x));
            Assert.That("((-63)-4)", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("(-89)", "((0-6)-4)", "((75)-7)");
            var v1 = new gvec3<string>("((23)2)", "((8-7)6)", "(-37)");
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((23)2)", Is.EqualTo(v0.x));
            Assert.That("((8-7)6)", Is.EqualTo(v0.y));
            Assert.That("(-37)", Is.EqualTo(v0.z));
        
            Assert.That("(-89)", Is.EqualTo(v2.x));
            Assert.That("((0-6)-4)", Is.EqualTo(v2.y));
            Assert.That("((75)-7)", Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            gvec3<string> v0 = new gvec3<string>("", "", "");
            string v1 = "((-52)6)";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((-52)6)", Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("", Is.EqualTo(v0.z));
        
            Assert.That("", Is.EqualTo(v2));
        }
        {
            gvec3<string> v0 = new gvec3<string>("(-37)", "", null);
            string v1 = "(-6-1)";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-37)", Is.EqualTo(v0.x));
            Assert.That("(-6-1)", Is.EqualTo(v0.y));
            Assert.That(null, Is.EqualTo(v0.z));
        
            Assert.That("", Is.EqualTo(v2));
        }
        {
            gvec3<string> v0 = new gvec3<string>("((2-7)9)", "-2", "-2");
            gvec2<string> v1 = new gvec2<string>("-4", "(-6-5)");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-4", Is.EqualTo(v0.x));
            Assert.That("(-6-5)", Is.EqualTo(v0.y));
            Assert.That("-2", Is.EqualTo(v0.z));
        
            Assert.That("((2-7)9)", Is.EqualTo(v2.x));
            Assert.That("-2", Is.EqualTo(v2.y));
        }
        {
            gvec3<string> v0 = new gvec3<string>(null, "(-1-4)", "((2-7)4)");
            string v1 = "-3";
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(null, Is.EqualTo(v0.x));
            Assert.That("(-1-4)", Is.EqualTo(v0.y));
            Assert.That("-3", Is.EqualTo(v0.z));
        
            Assert.That("((2-7)4)", Is.EqualTo(v2));
        }
        {
            gvec3<string> v0 = new gvec3<string>("((77)-6)", null, "");
            gvec2<string> v1 = new gvec2<string>("6", "(29)");
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("6", Is.EqualTo(v0.x));
            Assert.That(null, Is.EqualTo(v0.y));
            Assert.That("(29)", Is.EqualTo(v0.z));
        
            Assert.That("((77)-6)", Is.EqualTo(v2.x));
            Assert.That("", Is.EqualTo(v2.y));
        }
        {
            gvec3<string> v0 = new gvec3<string>("-8", "(-6-1)", "((9-3)-5)");
            gvec2<string> v1 = new gvec2<string>("(0-9)", "((-13)3)");
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-8", Is.EqualTo(v0.x));
            Assert.That("(0-9)", Is.EqualTo(v0.y));
            Assert.That("((-13)3)", Is.EqualTo(v0.z));
        
            Assert.That("(-6-1)", Is.EqualTo(v2.x));
            Assert.That("((9-3)-5)", Is.EqualTo(v2.y));
        }
        {
            gvec3<string> v0 = new gvec3<string>("((-5-1)-2)", "(27)", "(7-1)");
            gvec3<string> v1 = new gvec3<string>(null, "(-63)", "6");
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(null, Is.EqualTo(v0.x));
            Assert.That("(-63)", Is.EqualTo(v0.y));
            Assert.That("6", Is.EqualTo(v0.z));
        
            Assert.That("((-5-1)-2)", Is.EqualTo(v2.x));
            Assert.That("(27)", Is.EqualTo(v2.y));
            Assert.That("(7-1)", Is.EqualTo(v2.z));
        }
    }

}
