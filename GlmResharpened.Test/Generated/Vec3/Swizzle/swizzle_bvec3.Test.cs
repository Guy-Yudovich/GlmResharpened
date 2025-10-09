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
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.xx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.xxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.xxxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
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
            var ov = new bvec3(true, true, true);
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
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.xxyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
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
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.xxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.xxzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.xxzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.xxzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.xy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.xyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.xyxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.xyxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.xyxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.xyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.xyyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.xyyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.xyyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.xyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.xyzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.xyzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.xyzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.xz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.xzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, false);
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
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.xzxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.xzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.xzyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.xzyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.xzyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.xzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.xzzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.xzzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.xzzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.yx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
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
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.yxxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.yxxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.yxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.yxyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.yxyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.yxyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.yxz;
            Assert.That(true, Is.EqualTo(v.x));
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
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.yxzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.yy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.yyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.yyxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.yyxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.yyxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.yyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.yyyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.yyyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.yyyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.yyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.yyzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.yyzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.yyzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.yz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.yzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.yzxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.yzxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.yzxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.yzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
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
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.yzyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.yzyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.yzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.yzzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.yzzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.yzzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.zx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.zxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.zxxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.zxxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.zxxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.zxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
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
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.zxyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.zxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.zxzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.zxzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.zxzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
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
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.zyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.zyxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.zyxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.zyxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.zyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.zyyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.zyyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.zyyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.zyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.zyzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.zyzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.zyzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
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
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.zzxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
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
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.zzxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.zzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
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
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.zzyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.zzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.zzzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.zzzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.zzzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.rr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.rrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
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
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.rrrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.rrrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.rrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.rrgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
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
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.rrgb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.rrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.rrbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.rrbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.rrbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.rg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.rgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.rgrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.rgrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.rgrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.rgg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.rggr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
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
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.rggb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.rgb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.rgbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.rgbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.rgbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.rb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.rbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.rbrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.rbrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.rbrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.rbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
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
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.rbgg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.rbgb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.rbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.rbbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.rbbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.rbbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.gr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.grr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.grrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.grrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.grrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.grg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.grgr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
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
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.grgb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.grb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.grbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
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
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.grbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.gg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.ggr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, true);
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
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.ggrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.ggg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.gggr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.gggg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.gggb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.ggb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.ggbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.ggbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.ggbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.gb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.gbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.gbrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.gbrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.gbrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.gbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.gbgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.gbgg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.gbgb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.gbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.gbbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.gbbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.gbbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.br;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.brr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.brrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, false);
            var v = ov.swizzle.brrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.brrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.brg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.brgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.brgg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.brgb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.brb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.brbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.brbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
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
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.bg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.bgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.bgrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.bgrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, false);
            var v = ov.swizzle.bgrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.bgg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.bggr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.bggg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.bggb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.bgb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(false, false, false);
            var v = ov.swizzle.bgbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.bgbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.bgbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.bb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.bbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
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
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.bbrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(true, true, true);
            var v = ov.swizzle.bbrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.bbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec3(true, false, true);
            var v = ov.swizzle.bbgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.bbgg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.bbgb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
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
            var ov = new bvec3(false, true, true);
            var v = ov.swizzle.bbbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, true, false);
            var v = ov.swizzle.bbbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec3(false, false, true);
            var v = ov.swizzle.bbbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new bvec3(false, true, true);
            var v1 = new bvec2(false, false);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec3(false, true, true);
            var v1 = new bvec2(false, false);
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec3(true, true, false);
            var v1 = new bvec2(true, true);
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec3(true, true, true);
            var v1 = new bvec3(false, false, true);
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
            Assert.That(true, Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new bvec3(false, true, false);
            var v1 = true;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
        
            Assert.That(false, Is.EqualTo(v2));
        }
        {
            var v0 = new bvec3(true, true, false);
            var v1 = true;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
        
            Assert.That(true, Is.EqualTo(v2));
        }
        {
            var v0 = new bvec3(true, false, true);
            var v1 = new bvec2(false, true);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec3(true, true, true);
            var v1 = false;
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
        
            Assert.That(true, Is.EqualTo(v2));
        }
        {
            var v0 = new bvec3(true, false, true);
            var v1 = new bvec2(true, true);
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec3(false, false, true);
            var v1 = new bvec2(false, false);
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec3(true, true, true);
            var v1 = new bvec3(true, false, false);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
            Assert.That(true, Is.EqualTo(v2.z));
        }
    }

}
