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
public class BoolSwizzleVec4Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.xx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.xxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.xxxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.xxxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.xxxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.xxxw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.xxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.xxyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.xxyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.xxyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.xxyw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.xxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.xxzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.xxzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.xxzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.xxzw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.xxw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.xxwx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.xxwy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.xxwz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.xxww;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.xy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.xyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.xyxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.xyxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.xyxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.xyxw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.xyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.xyyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.xyyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.xyyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.xyyw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.xyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.xyzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.xyzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.xyzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.xyzw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.xyw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.xywx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.xywy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.xywz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.xyww;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.xz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.xzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.xzxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.xzxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.xzxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.xzxw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.xzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.xzyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.xzyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.xzyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.xzyw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.xzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.xzzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.xzzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.xzzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.xzzw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.xzw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.xzwx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.xzwy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.xzwz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.xzww;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.xw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.xwx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.xwxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.xwxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.xwxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.xwxw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.xwy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.xwyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.xwyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.xwyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.xwyw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.xwz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.xwzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.xwzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.xwzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.xwzw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.xww;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.xwwx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.xwwy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.xwwz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.xwww;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.yx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.yxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.yxxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.yxxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.yxxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.yxxw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.yxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.yxyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.yxyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.yxyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.yxyw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.yxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.yxzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.yxzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.yxzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.yxzw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.yxw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.yxwx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.yxwy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.yxwz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.yxww;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.yy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.yyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.yyxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.yyxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.yyxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.yyxw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.yyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.yyyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.yyyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.yyyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.yyyw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.yyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.yyzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.yyzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.yyzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.yyzw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.yyw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.yywx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.yywy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.yywz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.yyww;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.yz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.yzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.yzxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.yzxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.yzxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.yzxw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.yzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.yzyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.yzyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.yzyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.yzyw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.yzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.yzzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.yzzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.yzzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.yzzw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.yzw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.yzwx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.yzwy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.yzwz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.yzww;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.yw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.ywx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.ywxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.ywxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.ywxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.ywxw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.ywy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.ywyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.ywyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.ywyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.ywyw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.ywz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.ywzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.ywzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.ywzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.ywzw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.yww;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.ywwx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.ywwy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.ywwz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.ywww;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.zx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.zxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.zxxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.zxxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.zxxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.zxxw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.zxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.zxyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.zxyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.zxyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.zxyw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.zxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.zxzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.zxzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.zxzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.zxzw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.zxw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.zxwx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.zxwy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.zxwz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.zxww;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.zy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.zyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.zyxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.zyxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.zyxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.zyxw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.zyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.zyyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.zyyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.zyyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.zyyw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.zyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.zyzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.zyzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.zyzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.zyzw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.zyw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.zywx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.zywy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.zywz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.zyww;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.zz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.zzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.zzxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.zzxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.zzxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.zzxw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.zzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.zzyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.zzyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.zzyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.zzyw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.zzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.zzzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.zzzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.zzzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.zzzw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.zzw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.zzwx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.zzwy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.zzwz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.zzww;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.zw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.zwx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.zwxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.zwxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.zwxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.zwxw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.zwy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.zwyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.zwyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.zwyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.zwyw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.zwz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.zwzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.zwzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.zwzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.zwzw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.zww;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.zwwx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.zwwy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.zwwz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.zwww;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.wx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.wxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.wxxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.wxxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.wxxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.wxxw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.wxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.wxyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.wxyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.wxyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.wxyw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.wxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.wxzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.wxzy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.wxzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.wxzw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.wxw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.wxwx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.wxwy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.wxwz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.wxww;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.wy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.wyx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.wyxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.wyxy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.wyxz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.wyxw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.wyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.wyyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.wyyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.wyyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.wyyw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.wyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.wyzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.wyzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.wyzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.wyzw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.wyw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.wywx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.wywy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.wywz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.wyww;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.wz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.wzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.wzxx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.wzxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.wzxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.wzxw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.wzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.wzyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.wzyy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.wzyz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.wzyw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.wzz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.wzzx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.wzzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.wzzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.wzzw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.wzw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.wzwx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.wzwy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.wzwz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.wzww;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.ww;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.wwx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.wwxx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.wwxy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.wwxz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.wwxw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.wwy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.wwyx;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.wwyy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.wwyz;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.wwyw;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.wwz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.wwzx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.wwzy;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.wwzz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.wwzw;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.www;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.wwwx;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.wwwy;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.wwwz;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.wwww;
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
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.rr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.rrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.rrrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.rrrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.rrrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.rrra;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.rrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.rrgr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.rrgg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.rrgb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.rrga;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.rrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.rrbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.rrbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.rrbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.rrba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.rra;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.rrar;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.rrag;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.rrab;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.rraa;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.rg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.rgr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.rgrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.rgrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.rgrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.rgra;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.rgg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.rggr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.rggg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.rggb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.rgga;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.rgb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.rgbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.rgbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.rgbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.rgba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.rga;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.rgar;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.rgag;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.rgab;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.rgaa;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.rb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.rbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.rbrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.rbrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.rbrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.rbra;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.rbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.rbgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.rbgg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.rbgb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.rbga;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.rbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.rbbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.rbbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.rbbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.rbba;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.rba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.rbar;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.rbag;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.rbab;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.rbaa;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.ra;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.rar;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.rarr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.rarg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.rarb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.rara;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.rag;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.ragr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.ragg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.ragb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.raga;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.rab;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.rabr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.rabg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.rabb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.raba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.raa;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.raar;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.raag;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.raab;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.raaa;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.gr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.grr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.grrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.grrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.grrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.grra;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.grg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.grgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.grgg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.grgb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.grga;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.grb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.grbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.grbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.grbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.grba;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.gra;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.grar;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.grag;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.grab;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.graa;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.gg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.ggr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.ggrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.ggrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.ggrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.ggra;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.ggg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.gggr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.gggg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.gggb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.ggga;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.ggb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.ggbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.ggbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.ggbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.ggba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.gga;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.ggar;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.ggag;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.ggab;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.ggaa;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.gb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.gbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.gbrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.gbrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.gbrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.gbra;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.gbg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.gbgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.gbgg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.gbgb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.gbga;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.gbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.gbbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.gbbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.gbbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.gbba;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.gba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.gbar;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.gbag;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.gbab;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.gbaa;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.ga;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.gar;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.garr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.garg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.garb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.gara;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.gag;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.gagr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.gagg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.gagb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.gaga;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.gab;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.gabr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.gabg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.gabb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.gaba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.gaa;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.gaar;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.gaag;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.gaab;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.gaaa;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.br;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.brr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.brrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.brrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.brrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.brra;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.brg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.brgr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.brgg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.brgb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.brga;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.brb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.brbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.brbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.brbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.brba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.bra;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.brar;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.brag;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.brab;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.braa;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.bg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.bgr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.bgrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.bgrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.bgrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.bgra;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.bgg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.bggr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.bggg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.bggb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.bgga;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.bgb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.bgbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.bgbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.bgbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.bgba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.bga;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.bgar;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.bgag;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.bgab;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.bgaa;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.bb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.bbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.bbrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.bbrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.bbrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.bbra;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.bbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.bbgr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.bbgg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.bbgb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.bbga;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.bbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.bbbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.bbbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.bbbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.bbba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.bba;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.bbar;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.bbag;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.bbab;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.bbaa;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.ba;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.bar;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.barr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.barg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.barb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.bara;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.bag;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.bagr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.bagg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.bagb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.baga;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.bab;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.babr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.babg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.babb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.baba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.baa;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.baar;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.baag;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.baab;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.baaa;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.ar;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.arr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.arrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.arrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.arrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.arra;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.arg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.argr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.argg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.argb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.arga;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.arb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.arbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.arbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.arbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.arba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.ara;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.arar;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.arag;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.arab;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.araa;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.ag;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.agr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.agrr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.agrg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, true);
            var v = ov.swizzle.agrb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.agra;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.agg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.aggr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.aggg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.aggb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.agga;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.agb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.agbr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.agbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.agbb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.agba;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.aga;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.agar;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.agag;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, true);
            var v = ov.swizzle.agab;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.agaa;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.ab;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.abr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.abrr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, true);
            var v = ov.swizzle.abrg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.abrb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.abra;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.abg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, true, false);
            var v = ov.swizzle.abgr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.abgg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.abgb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, false);
            var v = ov.swizzle.abga;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.abb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.abbr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.abbg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.abbb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.abba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.aba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.abar;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.abag;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.abab;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.abaa;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.aa;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
        }
        {
            var ov = new bvec4(false, false, true, false);
            var v = ov.swizzle.aar;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.aarr;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, false);
            var v = ov.swizzle.aarg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.aarb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.aara;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, true, true);
            var v = ov.swizzle.aag;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.aagr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.aagg;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, true, true);
            var v = ov.swizzle.aagb;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, true, false, true);
            var v = ov.swizzle.aaga;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.aab;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.aabr;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, false, false);
            var v = ov.swizzle.aabg;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, false, false, false);
            var v = ov.swizzle.aabb;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, true, false);
            var v = ov.swizzle.aaba;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.aaa;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
        }
        {
            var ov = new bvec4(true, true, false, false);
            var v = ov.swizzle.aaar;
            Assert.That(false, Is.EqualTo(v.x));
            Assert.That(false, Is.EqualTo(v.y));
            Assert.That(false, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(false, true, true, true);
            var v = ov.swizzle.aaag;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(true, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.aaab;
            Assert.That(true, Is.EqualTo(v.x));
            Assert.That(true, Is.EqualTo(v.y));
            Assert.That(true, Is.EqualTo(v.z));
            Assert.That(false, Is.EqualTo(v.w));
        }
        {
            var ov = new bvec4(true, false, false, true);
            var v = ov.swizzle.aaaa;
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
            var v0 = new bvec4(false, true, true, true);
            var v1 = new bvec2(false, false);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
            Assert.That(true, Is.EqualTo(v0.w));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec4(true, false, true, false);
            var v1 = new bvec2(false, true);
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec4(false, true, false, false);
            var v1 = new bvec2(false, false);
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec4(true, true, true, true);
            var v1 = new bvec3(true, true, false);
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
            Assert.That(true, Is.EqualTo(v0.w));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
            Assert.That(true, Is.EqualTo(v2.z));
        }
        {
            var v0 = new bvec4(true, true, false, true);
            var v1 = new bvec2(false, true);
            var v2 = v0.xw;
            v0.xw = v1;
            var v3 = v0.xw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
            Assert.That(true, Is.EqualTo(v0.w));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec4(false, false, true, true);
            var v1 = new bvec2(false, false);
            var v2 = v0.yw;
            v0.yw = v1;
            var v3 = v0.yw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec4(true, false, false, false);
            var v1 = new bvec3(true, false, false);
            var v2 = v0.xyw;
            v0.xyw = v1;
            var v3 = v0.xyw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
            Assert.That(false, Is.EqualTo(v2.z));
        }
        {
            var v0 = new bvec4(true, false, true, true);
            var v1 = new bvec2(true, true);
            var v2 = v0.zw;
            v0.zw = v1;
            var v3 = v0.zw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
            Assert.That(true, Is.EqualTo(v0.w));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
        }
        {
            var v0 = new bvec4(true, false, true, false);
            var v1 = new bvec3(true, false, false);
            var v2 = v0.xzw;
            v0.xzw = v1;
            var v3 = v0.xzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
            Assert.That(false, Is.EqualTo(v2.z));
        }
        {
            var v0 = new bvec4(false, false, true, false);
            var v1 = new bvec3(true, false, false);
            var v2 = v0.yzw;
            v0.yzw = v1;
            var v3 = v0.yzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
            Assert.That(false, Is.EqualTo(v2.z));
        }
        {
            var v0 = new bvec4(false, false, false, true);
            var v1 = new bvec4(false, true, false, false);
            var v2 = v0.xyzw;
            v0.xyzw = v1;
            var v3 = v0.xyzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
            Assert.That(false, Is.EqualTo(v2.z));
            Assert.That(true, Is.EqualTo(v2.w));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            bvec4 v0 = new bvec4(true, false, false, true);
            bool v1 = true;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
            Assert.That(true, Is.EqualTo(v0.w));
        
            Assert.That(true, Is.EqualTo(v2));
        }
        {
            bvec4 v0 = new bvec4(true, false, true, false);
            bool v1 = false;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(false, Is.EqualTo(v2));
        }
        {
            bvec4 v0 = new bvec4(false, false, true, false);
            bvec2 v1 = new bvec2(true, false);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
        }
        {
            bvec4 v0 = new bvec4(true, false, true, false);
            bool v1 = false;
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(true, Is.EqualTo(v2));
        }
        {
            bvec4 v0 = new bvec4(false, false, false, true);
            bvec2 v1 = new bvec2(false, false);
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
            Assert.That(true, Is.EqualTo(v0.w));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
        }
        {
            bvec4 v0 = new bvec4(true, false, false, false);
            bvec2 v1 = new bvec2(false, true);
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
        }
        {
            bvec4 v0 = new bvec4(false, false, true, false);
            bvec3 v1 = new bvec3(false, false, true);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
            Assert.That(true, Is.EqualTo(v2.z));
        }
        {
            bvec4 v0 = new bvec4(false, true, false, false);
            bool v1 = true;
            var v2 = v0.a;
            v0.a = v1;
            var v3 = v0.a;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
            Assert.That(true, Is.EqualTo(v0.w));
        
            Assert.That(false, Is.EqualTo(v2));
        }
        {
            bvec4 v0 = new bvec4(true, false, false, true);
            bvec2 v1 = new bvec2(false, true);
            var v2 = v0.ra;
            v0.ra = v1;
            var v3 = v0.ra;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
            Assert.That(true, Is.EqualTo(v0.w));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
        }
        {
            bvec4 v0 = new bvec4(false, true, true, false);
            bvec2 v1 = new bvec2(false, false);
            var v2 = v0.ga;
            v0.ga = v1;
            var v3 = v0.ga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
        }
        {
            bvec4 v0 = new bvec4(true, false, true, true);
            bvec3 v1 = new bvec3(true, false, true);
            var v2 = v0.rga;
            v0.rga = v1;
            var v3 = v0.rga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(true, Is.EqualTo(v0.x));
            Assert.That(false, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
            Assert.That(true, Is.EqualTo(v0.w));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
            Assert.That(true, Is.EqualTo(v2.z));
        }
        {
            bvec4 v0 = new bvec4(false, true, false, false);
            bvec2 v1 = new bvec2(false, true);
            var v2 = v0.ba;
            v0.ba = v1;
            var v3 = v0.ba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(false, Is.EqualTo(v0.z));
            Assert.That(true, Is.EqualTo(v0.w));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
        }
        {
            bvec4 v0 = new bvec4(false, true, true, false);
            bvec3 v1 = new bvec3(false, true, true);
            var v2 = v0.rba;
            v0.rba = v1;
            var v3 = v0.rba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
            Assert.That(true, Is.EqualTo(v0.w));
        
            Assert.That(false, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
            Assert.That(false, Is.EqualTo(v2.z));
        }
        {
            bvec4 v0 = new bvec4(false, true, true, false);
            bvec3 v1 = new bvec3(true, true, false);
            var v2 = v0.gba;
            v0.gba = v1;
            var v3 = v0.gba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(true, Is.EqualTo(v2.y));
            Assert.That(false, Is.EqualTo(v2.z));
        }
        {
            bvec4 v0 = new bvec4(true, false, false, false);
            bvec4 v1 = new bvec4(false, true, true, false);
            var v2 = v0.rgba;
            v0.rgba = v1;
            var v3 = v0.rgba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(false, Is.EqualTo(v0.x));
            Assert.That(true, Is.EqualTo(v0.y));
            Assert.That(true, Is.EqualTo(v0.z));
            Assert.That(false, Is.EqualTo(v0.w));
        
            Assert.That(true, Is.EqualTo(v2.x));
            Assert.That(false, Is.EqualTo(v2.y));
            Assert.That(false, Is.EqualTo(v2.z));
            Assert.That(false, Is.EqualTo(v2.w));
        }
    }

}
