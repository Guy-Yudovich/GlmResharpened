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
public class BoolSwizzleVec3Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.xx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.xxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.xxxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.xxxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.xxxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.xxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.xxyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.xxyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.xxyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.xxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.xxzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.xxzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.xxzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.xy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.xyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.xyxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.xyxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.xyxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.xyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.xyyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.xyyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.xyyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.xyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.xyzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.xyzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.xyzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.xz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.xzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.xzxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.xzxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.xzxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.xzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.xzyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.xzyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.xzyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.xzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.xzzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.xzzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.xzzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.yx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.yxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.yxxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.yxxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.yxxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.yxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.yxyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.yxyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.yxyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.yxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.yxzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.yxzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.yxzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.yy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.yyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.yyxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.yyxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.yyxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.yyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.yyyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.yyyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.yyyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.yyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.yyzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.yyzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.yyzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.yz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.yzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.yzxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.yzxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.yzxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.yzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.yzyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.yzyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.yzyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.yzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.yzzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.yzzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.yzzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.zx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.zxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.zxxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.zxxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.zxxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.zxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.zxyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.zxyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.zxyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.zxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.zxzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.zxzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.zxzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.zy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.zyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.zyxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.zyxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.zyxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.zyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.zyyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.zyyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.zyyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.zyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.zyzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.zyzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.zyzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.zz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.zzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.zzxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.zzxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.zzxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.zzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.zzyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.zzyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.zzyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.zzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.zzzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.zzzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.zzzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.rr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.rrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.rrrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.rrrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.rrrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.rrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.rrgr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.rrgg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.rrgb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.rrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.rrbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.rrbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.rrbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.rg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.rgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.rgrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.rgrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.rgrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.rgg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.rggr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.rggg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.rggb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.rgb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.rgbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.rgbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.rgbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.rb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.rbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.rbrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.rbrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.rbrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.rbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.rbgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.rbgg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.rbgb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.rbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.rbbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.rbbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.rbbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.gr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.grr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.grrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.grrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.grrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.grg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.grgr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.grgg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.grgb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.grb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.grbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.grbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.grbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.gg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.ggr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.ggrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.ggrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.ggrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.ggg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.gggr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.gggg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.gggb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.ggb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.ggbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.ggbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.ggbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.gb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.gbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.gbrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.gbrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.gbrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.gbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.gbgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.gbgg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.gbgb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.gbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.gbbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.gbbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.gbbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.br;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.brr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.brrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.brrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.brrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.brg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.brgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.brgg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.brgb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.brb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.brbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.brbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.brbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.bg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.bgr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.bgrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.bgrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.bgrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.bgg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.bggr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.bggg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.bggb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.bgb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.bgbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.bgbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.bgbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.bb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.bbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.bbrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.bbrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.bbrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.bbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.bbgr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.bbgg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.bbgb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.bbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.bbbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.bbbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.bbbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new bvec3(true, false, false);
            var v1 = new bvec2(true, true);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec3(true, true, false);
            var v1 = new bvec2(true, true);
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec3(true, false, false);
            var v1 = new bvec2(false, false);
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec3(false, false, true);
            var v1 = new bvec3(false, true, true);
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
            Assert.That(true, Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            bvec3 v0 = new bvec3(true, false, true);
            bool v1 = false;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
        
            Assert.That(true, Is.EqualTo(v2));
        }
        {
            bvec3 v0 = new bvec3(true, true, true);
            bool v1 = false;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
        
            Assert.That(true, Is.EqualTo(v2));
        }
        {
            bvec3 v0 = new bvec3(false, true, false);
            bvec2 v1 = new bvec2(true, true);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
        }
        {
            bvec3 v0 = new bvec3(true, true, false);
            bool v1 = false;
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
        
            Assert.That(false, Is.EqualTo(v2));
        }
        {
            bvec3 v0 = new bvec3(false, false, true);
            bvec2 v1 = new bvec2(true, true);
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
        }
        {
            bvec3 v0 = new bvec3(true, false, true);
            bvec2 v1 = new bvec2(true, false);
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
        }
        {
            bvec3 v0 = new bvec3(true, false, false);
            bvec3 v1 = new bvec3(false, false, true);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
            Assert.That(false, Is.EqualTo(v2.z));
        }
    }

}
