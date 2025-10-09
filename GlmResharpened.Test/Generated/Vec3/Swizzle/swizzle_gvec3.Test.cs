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
            var ov = new gvec3<string>("((-1-9)8)", "(-6-9)", "");
            var v = ov.swizzle.xx;
            Assert.That("((-1-9)8)", Is.EqualTo(v.x));
            Assert.That("((-1-9)8)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "-1", "1");
            var v = ov.swizzle.xxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-3-7)-5)", "2", "((3-3)6)");
            var v = ov.swizzle.xxxx;
            Assert.That("((-3-7)-5)", Is.EqualTo(v.x));
            Assert.That("((-3-7)-5)", Is.EqualTo(v.y));
            Assert.That("((-3-7)-5)", Is.EqualTo(v.z));
            Assert.That("((-3-7)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "((-8-2)7)", "-8");
            var v = ov.swizzle.xxxy;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((-8-2)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "1", "((40)-7)");
            var v = ov.swizzle.xxxz;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("((40)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-1-4)", "", "((4-3)-5)");
            var v = ov.swizzle.xxy;
            Assert.That("(-1-4)", Is.EqualTo(v.x));
            Assert.That("(-1-4)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "", "-2");
            var v = ov.swizzle.xxyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "-4", null);
            var v = ov.swizzle.xxyy;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "((-81)2)", "");
            var v = ov.swizzle.xxyz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-81)2)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(4-8)", "(4-8)", null);
            var v = ov.swizzle.xxz;
            Assert.That("(4-8)", Is.EqualTo(v.x));
            Assert.That("(4-8)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>(null, "(-31)", "-6");
            var v = ov.swizzle.xxzx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-21)", "7", "7");
            var v = ov.swizzle.xxzy;
            Assert.That("(-21)", Is.EqualTo(v.x));
            Assert.That("(-21)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-7-2)", "((-3-6)-9)", null);
            var v = ov.swizzle.xxzz;
            Assert.That("(-7-2)", Is.EqualTo(v.x));
            Assert.That("(-7-2)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "", "((-68)2)");
            var v = ov.swizzle.xy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((0-2)-3)", null, null);
            var v = ov.swizzle.xyx;
            Assert.That("((0-2)-3)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((0-2)-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((8-3)-5)", "(1-5)", "(14)");
            var v = ov.swizzle.xyxx;
            Assert.That("((8-3)-5)", Is.EqualTo(v.x));
            Assert.That("(1-5)", Is.EqualTo(v.y));
            Assert.That("((8-3)-5)", Is.EqualTo(v.z));
            Assert.That("((8-3)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-5", "(-82)", "((-16)-1)");
            var v = ov.swizzle.xyxy;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That("(-82)", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("(-82)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "", "3");
            var v = ov.swizzle.xyxz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-1-5)3)", "-8", "((-1-5)3)");
            var v = ov.swizzle.xyy;
            Assert.That("((-1-5)3)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "", "(-20)");
            var v = ov.swizzle.xyyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "(-70)", "-5");
            var v = ov.swizzle.xyyy;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("(-70)", Is.EqualTo(v.y));
            Assert.That("(-70)", Is.EqualTo(v.z));
            Assert.That("(-70)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "-3", null);
            var v = ov.swizzle.xyyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(30)", "(01)", "-6");
            var v = ov.swizzle.xyz;
            Assert.That("(30)", Is.EqualTo(v.x));
            Assert.That("(01)", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-56)", "-6", "(98)");
            var v = ov.swizzle.xyzx;
            Assert.That("(-56)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("(98)", Is.EqualTo(v.z));
            Assert.That("(-56)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-4-2)8)", "((-5-1)9)", "((-7-6)-2)");
            var v = ov.swizzle.xyzy;
            Assert.That("((-4-2)8)", Is.EqualTo(v.x));
            Assert.That("((-5-1)9)", Is.EqualTo(v.y));
            Assert.That("((-7-6)-2)", Is.EqualTo(v.z));
            Assert.That("((-5-1)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(48)", "((01)7)", "");
            var v = ov.swizzle.xyzz;
            Assert.That("(48)", Is.EqualTo(v.x));
            Assert.That("((01)7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "", null);
            var v = ov.swizzle.xz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(49)", "(-7-5)", "-2");
            var v = ov.swizzle.xzx;
            Assert.That("(49)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("(49)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("1", "((9-4)-1)", null);
            var v = ov.swizzle.xzxx;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "((0-6)-9)", "");
            var v = ov.swizzle.xzxy;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("((0-6)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((8-8)-7)", "5", "((1-1)4)");
            var v = ov.swizzle.xzxz;
            Assert.That("((8-8)-7)", Is.EqualTo(v.x));
            Assert.That("((1-1)4)", Is.EqualTo(v.y));
            Assert.That("((8-8)-7)", Is.EqualTo(v.z));
            Assert.That("((1-1)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "((-86)-6)", "((-86)-6)");
            var v = ov.swizzle.xzy;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("((-86)-6)", Is.EqualTo(v.y));
            Assert.That("((-86)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "-2", "(2-9)");
            var v = ov.swizzle.xzyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(2-9)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((78)6)", "8", "");
            var v = ov.swizzle.xzyy;
            Assert.That("((78)6)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("8", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-3", "((02)7)", "");
            var v = ov.swizzle.xzyz;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((02)7)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "-1", "(-1-8)");
            var v = ov.swizzle.xzz;
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("(-1-8)", Is.EqualTo(v.y));
            Assert.That("(-1-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(0-1)", "((-1-6)-6)", "((-8-5)0)");
            var v = ov.swizzle.xzzx;
            Assert.That("(0-1)", Is.EqualTo(v.x));
            Assert.That("((-8-5)0)", Is.EqualTo(v.y));
            Assert.That("((-8-5)0)", Is.EqualTo(v.z));
            Assert.That("(0-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-2-9)", "((-50)3)", "-1");
            var v = ov.swizzle.xzzy;
            Assert.That("(-2-9)", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("-1", Is.EqualTo(v.z));
            Assert.That("((-50)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-41)4)", "-7", "");
            var v = ov.swizzle.xzzz;
            Assert.That("((-41)4)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(04)", "((-89)-8)", "(04)");
            var v = ov.swizzle.yx;
            Assert.That("((-89)-8)", Is.EqualTo(v.x));
            Assert.That("(04)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(-5-3)", "(-5-3)", "");
            var v = ov.swizzle.yxx;
            Assert.That("(-5-3)", Is.EqualTo(v.x));
            Assert.That("(-5-3)", Is.EqualTo(v.y));
            Assert.That("(-5-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-6", "8", "8");
            var v = ov.swizzle.yxxx;
            Assert.That("8", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-6-9)2)", "7", "7");
            var v = ov.swizzle.yxxy;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((-6-9)2)", Is.EqualTo(v.y));
            Assert.That("((-6-9)2)", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(0-6)", null, "");
            var v = ov.swizzle.yxxz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(0-6)", Is.EqualTo(v.y));
            Assert.That("(0-6)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(4-9)", null, "5");
            var v = ov.swizzle.yxy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(4-9)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("2", null, "(5-3)");
            var v = ov.swizzle.yxyx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-3-1)", null, null);
            var v = ov.swizzle.yxyy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(-3-1)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-9-6)-9)", "(-62)");
            var v = ov.swizzle.yxyz;
            Assert.That("((-9-6)-9)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-9-6)-9)", Is.EqualTo(v.z));
            Assert.That("(-62)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((3-8)0)", "(42)", "(42)");
            var v = ov.swizzle.yxz;
            Assert.That("(42)", Is.EqualTo(v.x));
            Assert.That("((3-8)0)", Is.EqualTo(v.y));
            Assert.That("(42)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(13)", "(-49)", "(13)");
            var v = ov.swizzle.yxzx;
            Assert.That("(-49)", Is.EqualTo(v.x));
            Assert.That("(13)", Is.EqualTo(v.y));
            Assert.That("(13)", Is.EqualTo(v.z));
            Assert.That("(13)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "((47)-8)", "-5");
            var v = ov.swizzle.yxzy;
            Assert.That("((47)-8)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("((47)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((3-6)5)", "((-47)3)", "(-1-4)");
            var v = ov.swizzle.yxzz;
            Assert.That("((-47)3)", Is.EqualTo(v.x));
            Assert.That("((3-6)5)", Is.EqualTo(v.y));
            Assert.That("(-1-4)", Is.EqualTo(v.z));
            Assert.That("(-1-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((2-6)-7)", null, "(97)");
            var v = ov.swizzle.yy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-55)-4)", "", null);
            var v = ov.swizzle.yyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-55)-4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(47)", "", "-1");
            var v = ov.swizzle.yyxx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(47)", Is.EqualTo(v.z));
            Assert.That("(47)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((8-4)-7)", "(58)", "5");
            var v = ov.swizzle.yyxy;
            Assert.That("(58)", Is.EqualTo(v.x));
            Assert.That("(58)", Is.EqualTo(v.y));
            Assert.That("((8-4)-7)", Is.EqualTo(v.z));
            Assert.That("(58)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "", "((-1-6)-7)");
            var v = ov.swizzle.yyxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((-1-6)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "((63)-6)", "((0-4)-1)");
            var v = ov.swizzle.yyy;
            Assert.That("((63)-6)", Is.EqualTo(v.x));
            Assert.That("((63)-6)", Is.EqualTo(v.y));
            Assert.That("((63)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "6", "-7");
            var v = ov.swizzle.yyyx;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-9", null, "");
            var v = ov.swizzle.yyyy;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-74)", "3", "8");
            var v = ov.swizzle.yyyz;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-2", null, "(9-5)");
            var v = ov.swizzle.yyz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(9-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>(null, "-2", "((-9-6)5)");
            var v = ov.swizzle.yyzx;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((-9-6)5)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "((6-1)-1)", "((6-1)-1)");
            var v = ov.swizzle.yyzy;
            Assert.That("((6-1)-1)", Is.EqualTo(v.x));
            Assert.That("((6-1)-1)", Is.EqualTo(v.y));
            Assert.That("((6-1)-1)", Is.EqualTo(v.z));
            Assert.That("((6-1)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", "", "(6-4)");
            var v = ov.swizzle.yyzz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(6-4)", Is.EqualTo(v.z));
            Assert.That("(6-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", null, "((-4-5)6)");
            var v = ov.swizzle.yz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-4-5)6)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-75)4)", null, "((81)3)");
            var v = ov.swizzle.yzx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((81)3)", Is.EqualTo(v.y));
            Assert.That("((-75)4)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-2", null, "((-25)2)");
            var v = ov.swizzle.yzxx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-25)2)", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-79)", "", "9");
            var v = ov.swizzle.yzxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("(-79)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(4-9)", "3");
            var v = ov.swizzle.yzxz;
            Assert.That("(4-9)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-4-6)8)", "((-5-2)-8)", "");
            var v = ov.swizzle.yzy;
            Assert.That("((-5-2)-8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((-5-2)-8)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(80)", "", "");
            var v = ov.swizzle.yzyx;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(80)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("5", "((51)-3)", "((15)-1)");
            var v = ov.swizzle.yzyy;
            Assert.That("((51)-3)", Is.EqualTo(v.x));
            Assert.That("((15)-1)", Is.EqualTo(v.y));
            Assert.That("((51)-3)", Is.EqualTo(v.z));
            Assert.That("((51)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((3-1)-1)", "0", "((61)9)");
            var v = ov.swizzle.yzyz;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("((61)9)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("((61)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "(27)", "5");
            var v = ov.swizzle.yzz;
            Assert.That("(27)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-93)", "-5", null);
            var v = ov.swizzle.yzzx;
            Assert.That("-5", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(-93)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "1", "-7");
            var v = ov.swizzle.yzzy;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((47)9)", "((47)9)", "-8");
            var v = ov.swizzle.yzzz;
            Assert.That("((47)9)", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-45)7)", "", "(6-2)");
            var v = ov.swizzle.zx;
            Assert.That("(6-2)", Is.EqualTo(v.x));
            Assert.That("((-45)7)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(00)", "(-27)", "(-27)");
            var v = ov.swizzle.zxx;
            Assert.That("(-27)", Is.EqualTo(v.x));
            Assert.That("(00)", Is.EqualTo(v.y));
            Assert.That("(00)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("7", "((-1-4)-8)", "(-1-7)");
            var v = ov.swizzle.zxxx;
            Assert.That("(-1-7)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-84)", "5", "((3-4)1)");
            var v = ov.swizzle.zxxy;
            Assert.That("((3-4)1)", Is.EqualTo(v.x));
            Assert.That("(-84)", Is.EqualTo(v.y));
            Assert.That("(-84)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((79)-7)", "((-2-8)1)", "1");
            var v = ov.swizzle.zxxz;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("((79)-7)", Is.EqualTo(v.y));
            Assert.That("((79)-7)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-7-8)-5)", "5", "(53)");
            var v = ov.swizzle.zxy;
            Assert.That("(53)", Is.EqualTo(v.x));
            Assert.That("((-7-8)-5)", Is.EqualTo(v.y));
            Assert.That("5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-73)-5)", "7", "(-8-4)");
            var v = ov.swizzle.zxyx;
            Assert.That("(-8-4)", Is.EqualTo(v.x));
            Assert.That("((-73)-5)", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("((-73)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, null, "(2-1)");
            var v = ov.swizzle.zxyy;
            Assert.That("(2-1)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", null, "");
            var v = ov.swizzle.zxyz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((15)-6)", "(-35)", null);
            var v = ov.swizzle.zxz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((15)-6)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", null, "((1-1)1)");
            var v = ov.swizzle.zxzx;
            Assert.That("((1-1)1)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("((1-1)1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "((99)8)", "9");
            var v = ov.swizzle.zxzy;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("((99)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-37)", "((41)3)", "(-37)");
            var v = ov.swizzle.zxzz;
            Assert.That("(-37)", Is.EqualTo(v.x));
            Assert.That("(-37)", Is.EqualTo(v.y));
            Assert.That("(-37)", Is.EqualTo(v.z));
            Assert.That("(-37)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "", "(-68)");
            var v = ov.swizzle.zy;
            Assert.That("(-68)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(8-7)", "-4", "((-7-4)1)");
            var v = ov.swizzle.zyx;
            Assert.That("((-7-4)1)", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That("(8-7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-5-3)", "4", "((-1-5)-8)");
            var v = ov.swizzle.zyxx;
            Assert.That("((-1-5)-8)", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("(-5-3)", Is.EqualTo(v.z));
            Assert.That("(-5-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-2", "2", "");
            var v = ov.swizzle.zyxy;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", null, "");
            var v = ov.swizzle.zyxz;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(5-5)", "-5", "-3");
            var v = ov.swizzle.zyy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((17)8)", "((05)5)", null);
            var v = ov.swizzle.zyyx;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((05)5)", Is.EqualTo(v.y));
            Assert.That("((05)5)", Is.EqualTo(v.z));
            Assert.That("((17)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((94)-2)", "((1-1)-1)", "(-50)");
            var v = ov.swizzle.zyyy;
            Assert.That("(-50)", Is.EqualTo(v.x));
            Assert.That("((1-1)-1)", Is.EqualTo(v.y));
            Assert.That("((1-1)-1)", Is.EqualTo(v.z));
            Assert.That("((1-1)-1)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "(00)", "((59)0)");
            var v = ov.swizzle.zyyz;
            Assert.That("((59)0)", Is.EqualTo(v.x));
            Assert.That("(00)", Is.EqualTo(v.y));
            Assert.That("(00)", Is.EqualTo(v.z));
            Assert.That("((59)0)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "-9", "((49)-2)");
            var v = ov.swizzle.zyz;
            Assert.That("((49)-2)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That("((49)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "-8", "-8");
            var v = ov.swizzle.zyzx;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-9", null, "((-8-5)8)");
            var v = ov.swizzle.zyzy;
            Assert.That("((-8-5)8)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-8-5)8)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((40)-7)", "((-6-2)0)", "((6-4)4)");
            var v = ov.swizzle.zyzz;
            Assert.That("((6-4)4)", Is.EqualTo(v.x));
            Assert.That("((-6-2)0)", Is.EqualTo(v.y));
            Assert.That("((6-4)4)", Is.EqualTo(v.z));
            Assert.That("((6-4)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", "((6-4)0)", "(-8-9)");
            var v = ov.swizzle.zz;
            Assert.That("(-8-9)", Is.EqualTo(v.x));
            Assert.That("(-8-9)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-1-7)7)", "(1-4)", "3");
            var v = ov.swizzle.zzx;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("((-1-7)7)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-63)-3)", "-6", "(75)");
            var v = ov.swizzle.zzxx;
            Assert.That("(75)", Is.EqualTo(v.x));
            Assert.That("(75)", Is.EqualTo(v.y));
            Assert.That("((-63)-3)", Is.EqualTo(v.z));
            Assert.That("((-63)-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(2-3)", "((02)2)", "((02)2)");
            var v = ov.swizzle.zzxy;
            Assert.That("((02)2)", Is.EqualTo(v.x));
            Assert.That("((02)2)", Is.EqualTo(v.y));
            Assert.That("(2-3)", Is.EqualTo(v.z));
            Assert.That("((02)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "(-1-1)", "3");
            var v = ov.swizzle.zzxz;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("3", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "((-66)2)", "-3");
            var v = ov.swizzle.zzy;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That("((-66)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(42)", "(-5-8)", "((-1-8)-7)");
            var v = ov.swizzle.zzyx;
            Assert.That("((-1-8)-7)", Is.EqualTo(v.x));
            Assert.That("((-1-8)-7)", Is.EqualTo(v.y));
            Assert.That("(-5-8)", Is.EqualTo(v.z));
            Assert.That("(42)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-1-1)", "", "7");
            var v = ov.swizzle.zzyy;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(24)", null);
            var v = ov.swizzle.zzyz;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(24)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((79)-5)", "", "(80)");
            var v = ov.swizzle.zzz;
            Assert.That("(80)", Is.EqualTo(v.x));
            Assert.That("(80)", Is.EqualTo(v.y));
            Assert.That("(80)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(39)", "(39)", "9");
            var v = ov.swizzle.zzzx;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("9", Is.EqualTo(v.z));
            Assert.That("(39)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(87)", "(8-3)", "(8-3)");
            var v = ov.swizzle.zzzy;
            Assert.That("(8-3)", Is.EqualTo(v.x));
            Assert.That("(8-3)", Is.EqualTo(v.y));
            Assert.That("(8-3)", Is.EqualTo(v.z));
            Assert.That("(8-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "((-98)5)", "(-8-5)");
            var v = ov.swizzle.zzzz;
            Assert.That("(-8-5)", Is.EqualTo(v.x));
            Assert.That("(-8-5)", Is.EqualTo(v.y));
            Assert.That("(-8-5)", Is.EqualTo(v.z));
            Assert.That("(-8-5)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new gvec3<string>("0", "-9", "((-51)-8)");
            var v = ov.swizzle.rr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-9-3)-6)", "(-57)", "(-57)");
            var v = ov.swizzle.rrr;
            Assert.That("((-9-3)-6)", Is.EqualTo(v.x));
            Assert.That("((-9-3)-6)", Is.EqualTo(v.y));
            Assert.That("((-9-3)-6)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("1", "1", "((-12)-3)");
            var v = ov.swizzle.rrrr;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(-8-6)", "(4-6)");
            var v = ov.swizzle.rrrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-8-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "((-49)-2)", "((13)7)");
            var v = ov.swizzle.rrrb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((13)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-2", "2", "(95)");
            var v = ov.swizzle.rrg;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-10)9)", "(-1-8)", "-7");
            var v = ov.swizzle.rrgr;
            Assert.That("((-10)9)", Is.EqualTo(v.x));
            Assert.That("((-10)9)", Is.EqualTo(v.y));
            Assert.That("(-1-8)", Is.EqualTo(v.z));
            Assert.That("((-10)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "((7-6)2)", "((-8-6)2)");
            var v = ov.swizzle.rrgg;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("((7-6)2)", Is.EqualTo(v.z));
            Assert.That("((7-6)2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((45)2)", "", "1");
            var v = ov.swizzle.rrgb;
            Assert.That("((45)2)", Is.EqualTo(v.x));
            Assert.That("((45)2)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(34)", "((2-2)-2)", "((-65)3)");
            var v = ov.swizzle.rrb;
            Assert.That("(34)", Is.EqualTo(v.x));
            Assert.That("(34)", Is.EqualTo(v.y));
            Assert.That("((-65)3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("7", "(03)", "");
            var v = ov.swizzle.rrbr;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "5", "(-41)");
            var v = ov.swizzle.rrbg;
            Assert.That("6", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
            Assert.That("(-41)", Is.EqualTo(v.z));
            Assert.That("5", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(7-9)", "((79)-5)", "(1-6)");
            var v = ov.swizzle.rrbb;
            Assert.That("(7-9)", Is.EqualTo(v.x));
            Assert.That("(7-9)", Is.EqualTo(v.y));
            Assert.That("(1-6)", Is.EqualTo(v.z));
            Assert.That("(1-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("0", "(-9-6)", "(8-8)");
            var v = ov.swizzle.rg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(-9-6)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "(1-8)", "((-91)9)");
            var v = ov.swizzle.rgr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(1-8)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((1-5)9)", "(5-7)", "(7-5)");
            var v = ov.swizzle.rgrr;
            Assert.That("((1-5)9)", Is.EqualTo(v.x));
            Assert.That("(5-7)", Is.EqualTo(v.y));
            Assert.That("((1-5)9)", Is.EqualTo(v.z));
            Assert.That("((1-5)9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-6-3)", "", "((-93)6)");
            var v = ov.swizzle.rgrg;
            Assert.That("(-6-3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(-6-3)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", "-6", "(14)");
            var v = ov.swizzle.rgrb;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That("(14)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((8-2)-1)", "((8-2)-1)", "((26)4)");
            var v = ov.swizzle.rgg;
            Assert.That("((8-2)-1)", Is.EqualTo(v.x));
            Assert.That("((8-2)-1)", Is.EqualTo(v.y));
            Assert.That("((8-2)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("7", null, "((9-4)-1)");
            var v = ov.swizzle.rggr;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", null, "(-4-1)");
            var v = ov.swizzle.rggg;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-84)8)", "((-9-4)-8)", "");
            var v = ov.swizzle.rggb;
            Assert.That("((-84)8)", Is.EqualTo(v.x));
            Assert.That("((-9-4)-8)", Is.EqualTo(v.y));
            Assert.That("((-9-4)-8)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-8-8)", "2", "-8");
            var v = ov.swizzle.rgb;
            Assert.That("(-8-8)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-4", "8", "-4");
            var v = ov.swizzle.rgbr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", "((-8-3)8)", "(88)");
            var v = ov.swizzle.rgbg;
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("((-8-3)8)", Is.EqualTo(v.y));
            Assert.That("(88)", Is.EqualTo(v.z));
            Assert.That("((-8-3)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-5-7)", null, "-4");
            var v = ov.swizzle.rgbb;
            Assert.That("(-5-7)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-4", Is.EqualTo(v.z));
            Assert.That("-4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-6-7)", "-7", "((15)4)");
            var v = ov.swizzle.rb;
            Assert.That("(-6-7)", Is.EqualTo(v.x));
            Assert.That("((15)4)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("(71)", "(-27)", "((-62)-2)");
            var v = ov.swizzle.rbr;
            Assert.That("(71)", Is.EqualTo(v.x));
            Assert.That("((-62)-2)", Is.EqualTo(v.y));
            Assert.That("(71)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-7-3)", "(-8-3)", null);
            var v = ov.swizzle.rbrr;
            Assert.That("(-7-3)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(-7-3)", Is.EqualTo(v.z));
            Assert.That("(-7-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "0", "((-5-4)-4)");
            var v = ov.swizzle.rbrg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-5-4)-4)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-72)3)", "((-8-6)3)", "(-90)");
            var v = ov.swizzle.rbrb;
            Assert.That("((-72)3)", Is.EqualTo(v.x));
            Assert.That("(-90)", Is.EqualTo(v.y));
            Assert.That("((-72)3)", Is.EqualTo(v.z));
            Assert.That("(-90)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", "", "(-13)");
            var v = ov.swizzle.rbg;
            Assert.That("9", Is.EqualTo(v.x));
            Assert.That("(-13)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((00)6)", "", "(74)");
            var v = ov.swizzle.rbgr;
            Assert.That("((00)6)", Is.EqualTo(v.x));
            Assert.That("(74)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((00)6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-38)7)", "-8", "-2");
            var v = ov.swizzle.rbgg;
            Assert.That("((-38)7)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(93)", "-7", "7");
            var v = ov.swizzle.rbgb;
            Assert.That("(93)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((22)1)", "(7-1)", "(-53)");
            var v = ov.swizzle.rbb;
            Assert.That("((22)1)", Is.EqualTo(v.x));
            Assert.That("(-53)", Is.EqualTo(v.y));
            Assert.That("(-53)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-73)", "", "");
            var v = ov.swizzle.rbbr;
            Assert.That("(-73)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-73)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("0", "((7-8)-5)", "(-4-5)");
            var v = ov.swizzle.rbbg;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(-4-5)", Is.EqualTo(v.y));
            Assert.That("(-4-5)", Is.EqualTo(v.z));
            Assert.That("((7-8)-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "-5", null);
            var v = ov.swizzle.rbbb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("9", null, "5");
            var v = ov.swizzle.gr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "((-12)-3)", "(4-8)");
            var v = ov.swizzle.grr;
            Assert.That("((-12)-3)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-5-5)", "3", "((-46)1)");
            var v = ov.swizzle.grrr;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(-5-5)", Is.EqualTo(v.y));
            Assert.That("(-5-5)", Is.EqualTo(v.z));
            Assert.That("(-5-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-7", "(6-2)", "-7");
            var v = ov.swizzle.grrg;
            Assert.That("(6-2)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("(6-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-71)6)", "", "((-6-2)8)");
            var v = ov.swizzle.grrb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-71)6)", Is.EqualTo(v.y));
            Assert.That("((-71)6)", Is.EqualTo(v.z));
            Assert.That("((-6-2)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "7", "((85)-5)");
            var v = ov.swizzle.grg;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("7", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-4-9)", "", "((38)-6)");
            var v = ov.swizzle.grgr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-4-9)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-4-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-15)-3)", "((-1-1)8)", "((-1-1)8)");
            var v = ov.swizzle.grgg;
            Assert.That("((-1-1)8)", Is.EqualTo(v.x));
            Assert.That("((-15)-3)", Is.EqualTo(v.y));
            Assert.That("((-1-1)8)", Is.EqualTo(v.z));
            Assert.That("((-1-1)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "", null);
            var v = ov.swizzle.grgb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-1", "-1", "");
            var v = ov.swizzle.grb;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("-1", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("-2", "-4", "((1-2)-9)");
            var v = ov.swizzle.grbr;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((1-2)-9)", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("8", "((-5-4)7)", "(-74)");
            var v = ov.swizzle.grbg;
            Assert.That("((-5-4)7)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
            Assert.That("(-74)", Is.EqualTo(v.z));
            Assert.That("((-5-4)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(36)", "3", "(-2-6)");
            var v = ov.swizzle.grbb;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("(36)", Is.EqualTo(v.y));
            Assert.That("(-2-6)", Is.EqualTo(v.z));
            Assert.That("(-2-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("1", "(7-2)", "(5-7)");
            var v = ov.swizzle.gg;
            Assert.That("(7-2)", Is.EqualTo(v.x));
            Assert.That("(7-2)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("", "", "(63)");
            var v = ov.swizzle.ggr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((02)4)", "0", "9");
            var v = ov.swizzle.ggrr;
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((02)4)", Is.EqualTo(v.z));
            Assert.That("((02)4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("4", "4", "");
            var v = ov.swizzle.ggrg;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-64)0)", "-6", null);
            var v = ov.swizzle.ggrb;
            Assert.That("-6", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("((-64)0)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "((4-4)-1)", "(-8-9)");
            var v = ov.swizzle.ggg;
            Assert.That("((4-4)-1)", Is.EqualTo(v.x));
            Assert.That("((4-4)-1)", Is.EqualTo(v.y));
            Assert.That("((4-4)-1)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-41)8)", "-8", "(-8-7)");
            var v = ov.swizzle.gggr;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("((-41)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((1-7)7)", "", "-9");
            var v = ov.swizzle.gggg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-92)", "((2-7)-5)", "");
            var v = ov.swizzle.gggb;
            Assert.That("((2-7)-5)", Is.EqualTo(v.x));
            Assert.That("((2-7)-5)", Is.EqualTo(v.y));
            Assert.That("((2-7)-5)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((1-8)1)", "", null);
            var v = ov.swizzle.ggb;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("1", "(-3-4)", "((9-7)-6)");
            var v = ov.swizzle.ggbr;
            Assert.That("(-3-4)", Is.EqualTo(v.x));
            Assert.That("(-3-4)", Is.EqualTo(v.y));
            Assert.That("((9-7)-6)", Is.EqualTo(v.z));
            Assert.That("1", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("6", "(0-8)", "(0-8)");
            var v = ov.swizzle.ggbg;
            Assert.That("(0-8)", Is.EqualTo(v.x));
            Assert.That("(0-8)", Is.EqualTo(v.y));
            Assert.That("(0-8)", Is.EqualTo(v.z));
            Assert.That("(0-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(48)", "7", "-7");
            var v = ov.swizzle.ggbb;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-4", "((10)-7)", "(96)");
            var v = ov.swizzle.gb;
            Assert.That("((10)-7)", Is.EqualTo(v.x));
            Assert.That("(96)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-51)5)", "(-32)", "0");
            var v = ov.swizzle.gbr;
            Assert.That("(-32)", Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((-51)5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "-2", null);
            var v = ov.swizzle.gbrr;
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, null, "((-57)2)");
            var v = ov.swizzle.gbrg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-57)2)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((6-1)4)", null, "0");
            var v = ov.swizzle.gbrb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("((6-1)4)", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(02)", "1", "(-9-7)");
            var v = ov.swizzle.gbg;
            Assert.That("1", Is.EqualTo(v.x));
            Assert.That("(-9-7)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(2-9)", null, "-3");
            var v = ov.swizzle.gbgr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("-3", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(2-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-2-5)-6)", "", "(-9-7)");
            var v = ov.swizzle.gbgg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-9-7)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(17)", "(17)", "-7");
            var v = ov.swizzle.gbgb;
            Assert.That("(17)", Is.EqualTo(v.x));
            Assert.That("-7", Is.EqualTo(v.y));
            Assert.That("(17)", Is.EqualTo(v.z));
            Assert.That("-7", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(90)", "(90)", "((3-2)-5)");
            var v = ov.swizzle.gbb;
            Assert.That("(90)", Is.EqualTo(v.x));
            Assert.That("((3-2)-5)", Is.EqualTo(v.y));
            Assert.That("((3-2)-5)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("", "(4-7)", null);
            var v = ov.swizzle.gbbr;
            Assert.That("(4-7)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "(7-6)", "-5");
            var v = ov.swizzle.gbbg;
            Assert.That("(7-6)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("-5", Is.EqualTo(v.z));
            Assert.That("(7-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "3", "((87)-8)");
            var v = ov.swizzle.gbbb;
            Assert.That("3", Is.EqualTo(v.x));
            Assert.That("((87)-8)", Is.EqualTo(v.y));
            Assert.That("((87)-8)", Is.EqualTo(v.z));
            Assert.That("((87)-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "((-8-2)-4)", "((-34)8)");
            var v = ov.swizzle.br;
            Assert.That("((-34)8)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("((-5-3)2)", "((-4-3)-3)", "4");
            var v = ov.swizzle.brr;
            Assert.That("4", Is.EqualTo(v.x));
            Assert.That("((-5-3)2)", Is.EqualTo(v.y));
            Assert.That("((-5-3)2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("0", "(-63)", null);
            var v = ov.swizzle.brrr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("0", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
            Assert.That("0", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-6", null, "((-8-4)0)");
            var v = ov.swizzle.brrg;
            Assert.That("((-8-4)0)", Is.EqualTo(v.x));
            Assert.That("-6", Is.EqualTo(v.y));
            Assert.That("-6", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(4-8)", "((33)-2)");
            var v = ov.swizzle.brrb;
            Assert.That("((33)-2)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("((33)-2)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(9-9)", "((8-7)-2)", "((8-7)-2)");
            var v = ov.swizzle.brg;
            Assert.That("((8-7)-2)", Is.EqualTo(v.x));
            Assert.That("(9-9)", Is.EqualTo(v.y));
            Assert.That("((8-7)-2)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>(null, "-7", null);
            var v = ov.swizzle.brgr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("-7", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "((-89)7)", "((77)-6)");
            var v = ov.swizzle.brgg;
            Assert.That("((77)-6)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((-89)7)", Is.EqualTo(v.z));
            Assert.That("((-89)7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("7", "((0-7)3)", "((0-7)3)");
            var v = ov.swizzle.brgb;
            Assert.That("((0-7)3)", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("((0-7)3)", Is.EqualTo(v.z));
            Assert.That("((0-7)3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-34)2)", "(51)", "-3");
            var v = ov.swizzle.brb;
            Assert.That("-3", Is.EqualTo(v.x));
            Assert.That("((-34)2)", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-36)", "(-36)", "");
            var v = ov.swizzle.brbr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("(-36)", Is.EqualTo(v.y));
            Assert.That("", Is.EqualTo(v.z));
            Assert.That("(-36)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((-8-5)5)", "(1-8)", "(-8-2)");
            var v = ov.swizzle.brbg;
            Assert.That("(-8-2)", Is.EqualTo(v.x));
            Assert.That("((-8-5)5)", Is.EqualTo(v.y));
            Assert.That("(-8-2)", Is.EqualTo(v.z));
            Assert.That("(1-8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-1-3)", null, "((62)-9)");
            var v = ov.swizzle.brbb;
            Assert.That("((62)-9)", Is.EqualTo(v.x));
            Assert.That("(-1-3)", Is.EqualTo(v.y));
            Assert.That("((62)-9)", Is.EqualTo(v.z));
            Assert.That("((62)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-39)", "((-7-7)-3)", null);
            var v = ov.swizzle.bg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-7-7)-3)", Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("3", "3", "(84)");
            var v = ov.swizzle.bgr;
            Assert.That("(84)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-51)", "1", "(-51)");
            var v = ov.swizzle.bgrr;
            Assert.That("(-51)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
            Assert.That("(-51)", Is.EqualTo(v.z));
            Assert.That("(-51)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(8-6)", "((-98)-7)", "");
            var v = ov.swizzle.bgrg;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-98)-7)", Is.EqualTo(v.y));
            Assert.That("(8-6)", Is.EqualTo(v.z));
            Assert.That("((-98)-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-8", "(-7-2)", "-8");
            var v = ov.swizzle.bgrb;
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("(-7-2)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-8", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((1-8)6)", "(-51)", "-4");
            var v = ov.swizzle.bgg;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("(-51)", Is.EqualTo(v.y));
            Assert.That("(-51)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((44)8)", "3", "");
            var v = ov.swizzle.bggr;
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("3", Is.EqualTo(v.z));
            Assert.That("((44)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-9-5)", "(-9-5)", "-1");
            var v = ov.swizzle.bggg;
            Assert.That("-1", Is.EqualTo(v.x));
            Assert.That("(-9-5)", Is.EqualTo(v.y));
            Assert.That("(-9-5)", Is.EqualTo(v.z));
            Assert.That("(-9-5)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(-3-4)", "(38)");
            var v = ov.swizzle.bggb;
            Assert.That("(38)", Is.EqualTo(v.x));
            Assert.That("(-3-4)", Is.EqualTo(v.y));
            Assert.That("(-3-4)", Is.EqualTo(v.z));
            Assert.That("(38)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((5-6)-4)", "((-9-1)-4)", "(-64)");
            var v = ov.swizzle.bgb;
            Assert.That("(-64)", Is.EqualTo(v.x));
            Assert.That("((-9-1)-4)", Is.EqualTo(v.y));
            Assert.That("(-64)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("4", null, "((4-6)-9)");
            var v = ov.swizzle.bgbr;
            Assert.That("((4-6)-9)", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("((4-6)-9)", Is.EqualTo(v.z));
            Assert.That("4", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((0-5)-7)", "(3-7)", "((7-3)-2)");
            var v = ov.swizzle.bgbg;
            Assert.That("((7-3)-2)", Is.EqualTo(v.x));
            Assert.That("(3-7)", Is.EqualTo(v.y));
            Assert.That("((7-3)-2)", Is.EqualTo(v.z));
            Assert.That("(3-7)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("2", "(52)", "((6-7)8)");
            var v = ov.swizzle.bgbb;
            Assert.That("((6-7)8)", Is.EqualTo(v.x));
            Assert.That("(52)", Is.EqualTo(v.y));
            Assert.That("((6-7)8)", Is.EqualTo(v.z));
            Assert.That("((6-7)8)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((10)3)", null, null);
            var v = ov.swizzle.bb;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
        }
        {
            var ov = new gvec3<string>("6", "((4-8)0)", null);
            var v = ov.swizzle.bbr;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("6", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("(-56)", "7", "7");
            var v = ov.swizzle.bbrr;
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("7", Is.EqualTo(v.y));
            Assert.That("(-56)", Is.EqualTo(v.z));
            Assert.That("(-56)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>(null, "(27)", "-4");
            var v = ov.swizzle.bbrg;
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("-4", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("(27)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-4-7)", "2", "((42)-9)");
            var v = ov.swizzle.bbrb;
            Assert.That("((42)-9)", Is.EqualTo(v.x));
            Assert.That("((42)-9)", Is.EqualTo(v.y));
            Assert.That("(-4-7)", Is.EqualTo(v.z));
            Assert.That("((42)-9)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("-2", "(6-3)", null);
            var v = ov.swizzle.bbg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("(6-3)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("((-8-6)-6)", "4", "((-6-6)1)");
            var v = ov.swizzle.bbgr;
            Assert.That("((-6-6)1)", Is.EqualTo(v.x));
            Assert.That("((-6-6)1)", Is.EqualTo(v.y));
            Assert.That("4", Is.EqualTo(v.z));
            Assert.That("((-8-6)-6)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("", "(-3-3)", "((7-5)-8)");
            var v = ov.swizzle.bbgg;
            Assert.That("((7-5)-8)", Is.EqualTo(v.x));
            Assert.That("((7-5)-8)", Is.EqualTo(v.y));
            Assert.That("(-3-3)", Is.EqualTo(v.z));
            Assert.That("(-3-3)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("(-16)", "((7-1)0)", "(-18)");
            var v = ov.swizzle.bbgb;
            Assert.That("(-18)", Is.EqualTo(v.x));
            Assert.That("(-18)", Is.EqualTo(v.y));
            Assert.That("((7-1)0)", Is.EqualTo(v.z));
            Assert.That("(-18)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("((3-2)1)", null, "(80)");
            var v = ov.swizzle.bbb;
            Assert.That("(80)", Is.EqualTo(v.x));
            Assert.That("(80)", Is.EqualTo(v.y));
            Assert.That("(80)", Is.EqualTo(v.z));
        }
        {
            var ov = new gvec3<string>("2", "6", "(21)");
            var v = ov.swizzle.bbbr;
            Assert.That("(21)", Is.EqualTo(v.x));
            Assert.That("(21)", Is.EqualTo(v.y));
            Assert.That("(21)", Is.EqualTo(v.z));
            Assert.That("2", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "((-98)-4)", null);
            var v = ov.swizzle.bbbg;
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That("((-98)-4)", Is.EqualTo(v.w));
        }
        {
            var ov = new gvec3<string>("3", "(1-6)", "(1-6)");
            var v = ov.swizzle.bbbb;
            Assert.That("(1-6)", Is.EqualTo(v.x));
            Assert.That("(1-6)", Is.EqualTo(v.y));
            Assert.That("(1-6)", Is.EqualTo(v.z));
            Assert.That("(1-6)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new gvec3<string>("((-5-5)-9)", null, "((80)6)");
            var v1 = new gvec2<string>("4", "((69)7)");
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("4", Is.EqualTo(v0.x));
            Assert.That("((69)7)", Is.EqualTo(v0.y));
            Assert.That("((80)6)", Is.EqualTo(v0.z));
        
            Assert.That("((-5-5)-9)", Is.EqualTo(v2.x));
            Assert.That(null, Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("(77)", "(25)", null);
            var v1 = new gvec2<string>("(25)", "(-59)");
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(25)", Is.EqualTo(v0.x));
            Assert.That("(25)", Is.EqualTo(v0.y));
            Assert.That("(-59)", Is.EqualTo(v0.z));
        
            Assert.That("(77)", Is.EqualTo(v2.x));
            Assert.That(null, Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("", "((-2-7)4)", "-4");
            var v1 = new gvec2<string>("(04)", "((-8-9)-4)");
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("(04)", Is.EqualTo(v0.y));
            Assert.That("((-8-9)-4)", Is.EqualTo(v0.z));
        
            Assert.That("((-2-7)4)", Is.EqualTo(v2.x));
            Assert.That("-4", Is.EqualTo(v2.y));
        }
        {
            var v0 = new gvec3<string>("(-6-3)", "(-52)", "(-6-3)");
            var v1 = new gvec3<string>("(-26)", "-1", "-2");
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("(-26)", Is.EqualTo(v0.x));
            Assert.That("-1", Is.EqualTo(v0.y));
            Assert.That("-2", Is.EqualTo(v0.z));
        
            Assert.That("(-6-3)", Is.EqualTo(v2.x));
            Assert.That("(-52)", Is.EqualTo(v2.y));
            Assert.That("(-6-3)", Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            gvec3<string> v0 = new gvec3<string>("(-2-1)", "((78)-1)", "((7-6)-8)");
            string v1 = "";
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("", Is.EqualTo(v0.x));
            Assert.That("((78)-1)", Is.EqualTo(v0.y));
            Assert.That("((7-6)-8)", Is.EqualTo(v0.z));
        
            Assert.That("(-2-1)", Is.EqualTo(v2));
        }
        {
            gvec3<string> v0 = new gvec3<string>("((5-2)-9)", "((5-2)-9)", null);
            string v1 = "((7-6)9)";
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((5-2)-9)", Is.EqualTo(v0.x));
            Assert.That("((7-6)9)", Is.EqualTo(v0.y));
            Assert.That(null, Is.EqualTo(v0.z));
        
            Assert.That("((5-2)-9)", Is.EqualTo(v2));
        }
        {
            gvec3<string> v0 = new gvec3<string>("((78)-8)", "(-69)", "(-69)");
            gvec2<string> v1 = new gvec2<string>(null, "");
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(null, Is.EqualTo(v0.x));
            Assert.That("", Is.EqualTo(v0.y));
            Assert.That("(-69)", Is.EqualTo(v0.z));
        
            Assert.That("((78)-8)", Is.EqualTo(v2.x));
            Assert.That("(-69)", Is.EqualTo(v2.y));
        }
        {
            gvec3<string> v0 = new gvec3<string>("-8", "-9", "(-1-8)");
            string v1 = "((-73)4)";
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-8", Is.EqualTo(v0.x));
            Assert.That("-9", Is.EqualTo(v0.y));
            Assert.That("((-73)4)", Is.EqualTo(v0.z));
        
            Assert.That("(-1-8)", Is.EqualTo(v2));
        }
        {
            gvec3<string> v0 = new gvec3<string>("(-94)", "(79)", null);
            gvec2<string> v1 = new gvec2<string>("((3-1)-7)", "((-9-3)-6)");
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((3-1)-7)", Is.EqualTo(v0.x));
            Assert.That("(79)", Is.EqualTo(v0.y));
            Assert.That("((-9-3)-6)", Is.EqualTo(v0.z));
        
            Assert.That("(-94)", Is.EqualTo(v2.x));
            Assert.That(null, Is.EqualTo(v2.y));
        }
        {
            gvec3<string> v0 = new gvec3<string>("((3-1)-2)", "((1-7)-3)", "((46)8)");
            gvec2<string> v1 = new gvec2<string>("((81)2)", "((-6-4)6)");
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("((3-1)-2)", Is.EqualTo(v0.x));
            Assert.That("((81)2)", Is.EqualTo(v0.y));
            Assert.That("((-6-4)6)", Is.EqualTo(v0.z));
        
            Assert.That("((1-7)-3)", Is.EqualTo(v2.x));
            Assert.That("((46)8)", Is.EqualTo(v2.y));
        }
        {
            gvec3<string> v0 = new gvec3<string>("", "(21)", "(21)");
            gvec3<string> v1 = new gvec3<string>("-9", null, "(65)");
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That("-9", Is.EqualTo(v0.x));
            Assert.That(null, Is.EqualTo(v0.y));
            Assert.That("(65)", Is.EqualTo(v0.z));
        
            Assert.That("", Is.EqualTo(v2.x));
            Assert.That("(21)", Is.EqualTo(v2.y));
            Assert.That("(21)", Is.EqualTo(v2.z));
        }
    }

}
