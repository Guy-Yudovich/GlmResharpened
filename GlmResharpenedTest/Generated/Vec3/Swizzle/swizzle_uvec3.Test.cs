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
public class UintSwizzleVec3Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new uvec3(5u, 4u, 9u);
            var v = ov.swizzle.xx;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(0u, 9u, 9u);
            var v = ov.swizzle.xxx;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(4u, 2u, 3u);
            var v = ov.swizzle.xxxx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 7u, 0u);
            var v = ov.swizzle.xxxy;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 0u, 4u);
            var v = ov.swizzle.xxxz;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 6u, 1u);
            var v = ov.swizzle.xxy;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(6u, 9u, 7u);
            var v = ov.swizzle.xxyx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 0u, 6u);
            var v = ov.swizzle.xxyy;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 3u, 2u);
            var v = ov.swizzle.xxyz;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 9u, 1u);
            var v = ov.swizzle.xxz;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(6u, 1u, 5u);
            var v = ov.swizzle.xxzx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 6u, 1u);
            var v = ov.swizzle.xxzy;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 3u, 4u);
            var v = ov.swizzle.xxzz;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(7u, 9u, 3u);
            var v = ov.swizzle.xy;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(9u, 7u, 1u);
            var v = ov.swizzle.xyx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(9u, 7u, 2u);
            var v = ov.swizzle.xyxx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 6u, 8u);
            var v = ov.swizzle.xyxy;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 3u, 7u);
            var v = ov.swizzle.xyxz;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(3u, 9u, 3u);
            var v = ov.swizzle.xyy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(2u, 5u, 5u);
            var v = ov.swizzle.xyyx;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 0u, 3u);
            var v = ov.swizzle.xyyy;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 5u, 5u);
            var v = ov.swizzle.xyyz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 2u, 4u);
            var v = ov.swizzle.xyz;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(2u, 7u, 3u);
            var v = ov.swizzle.xyzx;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(7u, 9u, 9u);
            var v = ov.swizzle.xyzy;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(3u, 6u, 2u);
            var v = ov.swizzle.xyzz;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 5u, 5u);
            var v = ov.swizzle.xz;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(9u, 6u, 3u);
            var v = ov.swizzle.xzx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(3u, 0u, 8u);
            var v = ov.swizzle.xzxx;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 0u, 6u);
            var v = ov.swizzle.xzxy;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 6u, 7u);
            var v = ov.swizzle.xzxz;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 1u, 9u);
            var v = ov.swizzle.xzy;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(0u, 7u, 2u);
            var v = ov.swizzle.xzyx;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 5u, 5u);
            var v = ov.swizzle.xzyy;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 6u, 8u);
            var v = ov.swizzle.xzyz;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 8u, 4u);
            var v = ov.swizzle.xzz;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(7u, 0u, 2u);
            var v = ov.swizzle.xzzx;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 7u, 9u);
            var v = ov.swizzle.xzzy;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 6u, 3u);
            var v = ov.swizzle.xzzz;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 8u, 4u);
            var v = ov.swizzle.yx;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(7u, 6u, 1u);
            var v = ov.swizzle.yxx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(7u, 4u, 1u);
            var v = ov.swizzle.yxxx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 8u, 7u);
            var v = ov.swizzle.yxxy;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 3u, 9u);
            var v = ov.swizzle.yxxz;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 9u, 0u);
            var v = ov.swizzle.yxy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(9u, 1u, 0u);
            var v = ov.swizzle.yxyx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 8u, 2u);
            var v = ov.swizzle.yxyy;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 1u, 0u);
            var v = ov.swizzle.yxyz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 7u, 8u);
            var v = ov.swizzle.yxz;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(8u, 7u, 4u);
            var v = ov.swizzle.yxzx;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 1u, 8u);
            var v = ov.swizzle.yxzy;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 8u, 9u);
            var v = ov.swizzle.yxzz;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 1u, 1u);
            var v = ov.swizzle.yy;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(7u, 9u, 9u);
            var v = ov.swizzle.yyx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(6u, 6u, 7u);
            var v = ov.swizzle.yyxx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 0u, 8u);
            var v = ov.swizzle.yyxy;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 0u, 5u);
            var v = ov.swizzle.yyxz;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(3u, 4u, 0u);
            var v = ov.swizzle.yyy;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(2u, 3u, 4u);
            var v = ov.swizzle.yyyx;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 2u, 7u);
            var v = ov.swizzle.yyyy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(3u, 7u, 1u);
            var v = ov.swizzle.yyyz;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(3u, 4u, 1u);
            var v = ov.swizzle.yyz;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(0u, 1u, 0u);
            var v = ov.swizzle.yyzx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 5u, 9u);
            var v = ov.swizzle.yyzy;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 7u, 8u);
            var v = ov.swizzle.yyzz;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 7u, 4u);
            var v = ov.swizzle.yz;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(3u, 2u, 6u);
            var v = ov.swizzle.yzx;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(9u, 8u, 7u);
            var v = ov.swizzle.yzxx;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 2u, 7u);
            var v = ov.swizzle.yzxy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 6u, 5u);
            var v = ov.swizzle.yzxz;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 3u, 8u);
            var v = ov.swizzle.yzy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(4u, 4u, 2u);
            var v = ov.swizzle.yzyx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 3u, 2u);
            var v = ov.swizzle.yzyy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 1u, 9u);
            var v = ov.swizzle.yzyz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 8u, 5u);
            var v = ov.swizzle.yzz;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(5u, 5u, 6u);
            var v = ov.swizzle.yzzx;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 9u, 5u);
            var v = ov.swizzle.yzzy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 7u, 9u);
            var v = ov.swizzle.yzzz;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 3u, 9u);
            var v = ov.swizzle.zx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(3u, 3u, 2u);
            var v = ov.swizzle.zxx;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(4u, 2u, 5u);
            var v = ov.swizzle.zxxx;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 6u, 2u);
            var v = ov.swizzle.zxxy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 3u, 3u);
            var v = ov.swizzle.zxxz;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 4u, 4u);
            var v = ov.swizzle.zxy;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(2u, 7u, 1u);
            var v = ov.swizzle.zxyx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(7u, 1u, 9u);
            var v = ov.swizzle.zxyy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 3u, 7u);
            var v = ov.swizzle.zxyz;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 6u, 6u);
            var v = ov.swizzle.zxz;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(9u, 3u, 5u);
            var v = ov.swizzle.zxzx;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 4u, 0u);
            var v = ov.swizzle.zxzy;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 4u, 9u);
            var v = ov.swizzle.zxzz;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 0u, 9u);
            var v = ov.swizzle.zy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(3u, 2u, 2u);
            var v = ov.swizzle.zyx;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(2u, 4u, 1u);
            var v = ov.swizzle.zyxx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 5u, 4u);
            var v = ov.swizzle.zyxy;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 8u, 0u);
            var v = ov.swizzle.zyxz;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 3u, 2u);
            var v = ov.swizzle.zyy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(9u, 1u, 0u);
            var v = ov.swizzle.zyyx;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 3u, 5u);
            var v = ov.swizzle.zyyy;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 6u, 2u);
            var v = ov.swizzle.zyyz;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 1u, 9u);
            var v = ov.swizzle.zyz;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(3u, 3u, 0u);
            var v = ov.swizzle.zyzx;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 2u, 6u);
            var v = ov.swizzle.zyzy;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 3u, 8u);
            var v = ov.swizzle.zyzz;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(7u, 9u, 8u);
            var v = ov.swizzle.zz;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(5u, 8u, 1u);
            var v = ov.swizzle.zzx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(2u, 7u, 4u);
            var v = ov.swizzle.zzxx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 0u, 0u);
            var v = ov.swizzle.zzxy;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(7u, 3u, 2u);
            var v = ov.swizzle.zzxz;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 3u, 7u);
            var v = ov.swizzle.zzy;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(3u, 4u, 6u);
            var v = ov.swizzle.zzyx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 6u, 2u);
            var v = ov.swizzle.zzyy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 8u, 1u);
            var v = ov.swizzle.zzyz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 6u, 6u);
            var v = ov.swizzle.zzz;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(3u, 6u, 9u);
            var v = ov.swizzle.zzzx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(3u, 2u, 2u);
            var v = ov.swizzle.zzzy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 9u, 5u);
            var v = ov.swizzle.zzzz;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new uvec3(4u, 5u, 5u);
            var v = ov.swizzle.rr;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(5u, 9u, 1u);
            var v = ov.swizzle.rrr;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(6u, 8u, 3u);
            var v = ov.swizzle.rrrr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 9u, 7u);
            var v = ov.swizzle.rrrg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 1u, 1u);
            var v = ov.swizzle.rrrb;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 8u, 1u);
            var v = ov.swizzle.rrg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(0u, 3u, 1u);
            var v = ov.swizzle.rrgr;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 7u, 3u);
            var v = ov.swizzle.rrgg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 8u, 2u);
            var v = ov.swizzle.rrgb;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 2u, 7u);
            var v = ov.swizzle.rrb;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(1u, 9u, 7u);
            var v = ov.swizzle.rrbr;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 9u, 7u);
            var v = ov.swizzle.rrbg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 3u, 0u);
            var v = ov.swizzle.rrbb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(7u, 2u, 8u);
            var v = ov.swizzle.rg;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(2u, 0u, 9u);
            var v = ov.swizzle.rgr;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(5u, 2u, 0u);
            var v = ov.swizzle.rgrr;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 0u, 4u);
            var v = ov.swizzle.rgrg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 2u, 6u);
            var v = ov.swizzle.rgrb;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 5u, 8u);
            var v = ov.swizzle.rgg;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(1u, 3u, 1u);
            var v = ov.swizzle.rggr;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 5u, 5u);
            var v = ov.swizzle.rggg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 3u, 9u);
            var v = ov.swizzle.rggb;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 7u, 1u);
            var v = ov.swizzle.rgb;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(3u, 3u, 4u);
            var v = ov.swizzle.rgbr;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 2u, 0u);
            var v = ov.swizzle.rgbg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 7u, 7u);
            var v = ov.swizzle.rgbb;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 7u, 6u);
            var v = ov.swizzle.rb;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(2u, 0u, 2u);
            var v = ov.swizzle.rbr;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(3u, 9u, 6u);
            var v = ov.swizzle.rbrr;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 8u, 4u);
            var v = ov.swizzle.rbrg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 7u, 0u);
            var v = ov.swizzle.rbrb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 8u, 7u);
            var v = ov.swizzle.rbg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(3u, 6u, 6u);
            var v = ov.swizzle.rbgr;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 5u, 5u);
            var v = ov.swizzle.rbgg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 6u, 7u);
            var v = ov.swizzle.rbgb;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 1u, 9u);
            var v = ov.swizzle.rbb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(6u, 3u, 8u);
            var v = ov.swizzle.rbbr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 6u, 6u);
            var v = ov.swizzle.rbbg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 7u, 4u);
            var v = ov.swizzle.rbbb;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(3u, 2u, 4u);
            var v = ov.swizzle.gr;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(3u, 9u, 8u);
            var v = ov.swizzle.grr;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(7u, 4u, 5u);
            var v = ov.swizzle.grrr;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 1u, 4u);
            var v = ov.swizzle.grrg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 9u, 0u);
            var v = ov.swizzle.grrb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 5u, 1u);
            var v = ov.swizzle.grg;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(1u, 3u, 4u);
            var v = ov.swizzle.grgr;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 4u, 8u);
            var v = ov.swizzle.grgg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 4u, 4u);
            var v = ov.swizzle.grgb;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 8u, 1u);
            var v = ov.swizzle.grb;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(4u, 4u, 0u);
            var v = ov.swizzle.grbr;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(3u, 9u, 3u);
            var v = ov.swizzle.grbg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 5u, 5u);
            var v = ov.swizzle.grbb;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 0u, 2u);
            var v = ov.swizzle.gg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(2u, 4u, 9u);
            var v = ov.swizzle.ggr;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(5u, 4u, 4u);
            var v = ov.swizzle.ggrr;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(7u, 0u, 1u);
            var v = ov.swizzle.ggrg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 3u, 3u);
            var v = ov.swizzle.ggrb;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 8u, 7u);
            var v = ov.swizzle.ggg;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(6u, 6u, 5u);
            var v = ov.swizzle.gggr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(3u, 1u, 6u);
            var v = ov.swizzle.gggg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(3u, 0u, 6u);
            var v = ov.swizzle.gggb;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 8u, 9u);
            var v = ov.swizzle.ggb;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(7u, 8u, 9u);
            var v = ov.swizzle.ggbr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 4u, 3u);
            var v = ov.swizzle.ggbg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 2u, 9u);
            var v = ov.swizzle.ggbb;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 1u, 0u);
            var v = ov.swizzle.gb;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(0u, 9u, 7u);
            var v = ov.swizzle.gbr;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(0u, 9u, 0u);
            var v = ov.swizzle.gbrr;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 3u, 0u);
            var v = ov.swizzle.gbrg;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 5u, 9u);
            var v = ov.swizzle.gbrb;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 2u, 9u);
            var v = ov.swizzle.gbg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(5u, 8u, 4u);
            var v = ov.swizzle.gbgr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(3u, 0u, 5u);
            var v = ov.swizzle.gbgg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 0u, 2u);
            var v = ov.swizzle.gbgb;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 8u, 9u);
            var v = ov.swizzle.gbb;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(0u, 7u, 6u);
            var v = ov.swizzle.gbbr;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(7u, 7u, 4u);
            var v = ov.swizzle.gbbg;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 3u, 2u);
            var v = ov.swizzle.gbbb;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(8u, 3u, 0u);
            var v = ov.swizzle.br;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(6u, 7u, 5u);
            var v = ov.swizzle.brr;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(9u, 0u, 2u);
            var v = ov.swizzle.brrr;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(0u, 4u, 2u);
            var v = ov.swizzle.brrg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(3u, 6u, 3u);
            var v = ov.swizzle.brrb;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 5u, 0u);
            var v = ov.swizzle.brg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(4u, 5u, 8u);
            var v = ov.swizzle.brgr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 8u, 0u);
            var v = ov.swizzle.brgg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 6u, 5u);
            var v = ov.swizzle.brgb;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 8u, 7u);
            var v = ov.swizzle.brb;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(4u, 5u, 9u);
            var v = ov.swizzle.brbr;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 6u, 5u);
            var v = ov.swizzle.brbg;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(3u, 6u, 3u);
            var v = ov.swizzle.brbb;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 5u, 9u);
            var v = ov.swizzle.bg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(9u, 1u, 3u);
            var v = ov.swizzle.bgr;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(7u, 6u, 1u);
            var v = ov.swizzle.bgrr;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 2u, 2u);
            var v = ov.swizzle.bgrg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 0u, 7u);
            var v = ov.swizzle.bgrb;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(3u, 3u, 4u);
            var v = ov.swizzle.bgg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(9u, 4u, 0u);
            var v = ov.swizzle.bggr;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 4u, 2u);
            var v = ov.swizzle.bggg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(5u, 5u, 9u);
            var v = ov.swizzle.bggb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 6u, 9u);
            var v = ov.swizzle.bgb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(8u, 1u, 8u);
            var v = ov.swizzle.bgbr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(7u, 5u, 0u);
            var v = ov.swizzle.bgbg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(9u, 6u, 7u);
            var v = ov.swizzle.bgbb;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(6u, 4u, 9u);
            var v = ov.swizzle.bb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec3(4u, 1u, 6u);
            var v = ov.swizzle.bbr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(4u, 0u, 5u);
            var v = ov.swizzle.bbrr;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 3u, 3u);
            var v = ov.swizzle.bbrg;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 3u, 2u);
            var v = ov.swizzle.bbrb;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(2u, 0u, 0u);
            var v = ov.swizzle.bbg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(6u, 3u, 6u);
            var v = ov.swizzle.bbgr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 4u, 9u);
            var v = ov.swizzle.bbgg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 4u, 0u);
            var v = ov.swizzle.bbgb;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(4u, 6u, 5u);
            var v = ov.swizzle.bbb;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec3(6u, 3u, 6u);
            var v = ov.swizzle.bbbr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(7u, 2u, 0u);
            var v = ov.swizzle.bbbg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec3(1u, 5u, 3u);
            var v = ov.swizzle.bbbb;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new uvec3(8u, 3u, 4u);
            var v1 = new uvec2(7u, 0u);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(7u, Is.EqualTo(v0.x));
            Assert.That(0u, Is.EqualTo(v0.y));
            Assert.That(4u, Is.EqualTo(v0.z));
        
            Assert.That(8u, Is.EqualTo(v2.x));
            Assert.That(3u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec3(1u, 8u, 5u);
            var v1 = new uvec2(9u, 7u);
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(9u, Is.EqualTo(v0.x));
            Assert.That(8u, Is.EqualTo(v0.y));
            Assert.That(7u, Is.EqualTo(v0.z));
        
            Assert.That(1u, Is.EqualTo(v2.x));
            Assert.That(5u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec3(8u, 8u, 9u);
            var v1 = new uvec2(8u, 5u);
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(8u, Is.EqualTo(v0.x));
            Assert.That(8u, Is.EqualTo(v0.y));
            Assert.That(5u, Is.EqualTo(v0.z));
        
            Assert.That(8u, Is.EqualTo(v2.x));
            Assert.That(9u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec3(9u, 1u, 8u);
            var v1 = new uvec3(6u, 3u, 5u);
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(6u, Is.EqualTo(v0.x));
            Assert.That(3u, Is.EqualTo(v0.y));
            Assert.That(5u, Is.EqualTo(v0.z));
        
            Assert.That(9u, Is.EqualTo(v2.x));
            Assert.That(1u, Is.EqualTo(v2.y));
            Assert.That(8u, Is.EqualTo(v2.z));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new uvec3(2u, 1u, 3u);
            var v1 = 3u;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(3u, Is.EqualTo(v0.x));
            Assert.That(1u, Is.EqualTo(v0.y));
            Assert.That(3u, Is.EqualTo(v0.z));
        
            Assert.That(2u, Is.EqualTo(v2));
        }
        {
            var v0 = new uvec3(4u, 7u, 3u);
            var v1 = 9u;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4u, Is.EqualTo(v0.x));
            Assert.That(9u, Is.EqualTo(v0.y));
            Assert.That(3u, Is.EqualTo(v0.z));
        
            Assert.That(7u, Is.EqualTo(v2));
        }
        {
            var v0 = new uvec3(3u, 6u, 6u);
            var v1 = new uvec2(1u, 5u);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(1u, Is.EqualTo(v0.x));
            Assert.That(5u, Is.EqualTo(v0.y));
            Assert.That(6u, Is.EqualTo(v0.z));
        
            Assert.That(3u, Is.EqualTo(v2.x));
            Assert.That(6u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec3(4u, 1u, 5u);
            var v1 = 5u;
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4u, Is.EqualTo(v0.x));
            Assert.That(1u, Is.EqualTo(v0.y));
            Assert.That(5u, Is.EqualTo(v0.z));
        
            Assert.That(5u, Is.EqualTo(v2));
        }
        {
            var v0 = new uvec3(7u, 4u, 2u);
            var v1 = new uvec2(0u, 3u);
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(0u, Is.EqualTo(v0.x));
            Assert.That(4u, Is.EqualTo(v0.y));
            Assert.That(3u, Is.EqualTo(v0.z));
        
            Assert.That(7u, Is.EqualTo(v2.x));
            Assert.That(2u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec3(8u, 6u, 2u);
            var v1 = new uvec2(4u, 5u);
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(8u, Is.EqualTo(v0.x));
            Assert.That(4u, Is.EqualTo(v0.y));
            Assert.That(5u, Is.EqualTo(v0.z));
        
            Assert.That(6u, Is.EqualTo(v2.x));
            Assert.That(2u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec3(2u, 4u, 7u);
            var v1 = new uvec3(1u, 4u, 4u);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(1u, Is.EqualTo(v0.x));
            Assert.That(4u, Is.EqualTo(v0.y));
            Assert.That(4u, Is.EqualTo(v0.z));
        
            Assert.That(2u, Is.EqualTo(v2.x));
            Assert.That(4u, Is.EqualTo(v2.y));
            Assert.That(7u, Is.EqualTo(v2.z));
        }
    }

}
