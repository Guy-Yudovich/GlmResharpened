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
public class UintSwizzleVec4Test
{

    [Test]
    public void XYZW()
    {
        {
            var ov = new uvec4(9u, 5u, 3u, 9u);
            var v = ov.swizzle.xx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(8u, 6u, 9u, 7u);
            var v = ov.swizzle.xxx;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(5u, 6u, 4u, 1u);
            var v = ov.swizzle.xxxx;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 1u, 2u, 6u);
            var v = ov.swizzle.xxxy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 9u, 7u, 5u);
            var v = ov.swizzle.xxxz;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 4u, 1u, 7u);
            var v = ov.swizzle.xxxw;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 8u, 4u, 4u);
            var v = ov.swizzle.xxy;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(1u, 8u, 3u, 8u);
            var v = ov.swizzle.xxyx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 5u, 9u, 1u);
            var v = ov.swizzle.xxyy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 8u, 6u, 6u);
            var v = ov.swizzle.xxyz;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 6u, 2u, 4u);
            var v = ov.swizzle.xxyw;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 8u, 6u, 7u);
            var v = ov.swizzle.xxz;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 7u, 5u, 3u);
            var v = ov.swizzle.xxzx;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 8u, 7u, 4u);
            var v = ov.swizzle.xxzy;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 6u, 1u, 0u);
            var v = ov.swizzle.xxzz;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 5u, 5u, 7u);
            var v = ov.swizzle.xxzw;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 6u, 8u, 4u);
            var v = ov.swizzle.xxw;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(2u, 1u, 8u, 6u);
            var v = ov.swizzle.xxwx;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 1u, 3u, 3u);
            var v = ov.swizzle.xxwy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 6u, 2u, 9u);
            var v = ov.swizzle.xxwz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 6u, 3u, 4u);
            var v = ov.swizzle.xxww;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 0u, 2u, 4u);
            var v = ov.swizzle.xy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(7u, 5u, 6u, 0u);
            var v = ov.swizzle.xyx;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(7u, 5u, 3u, 6u);
            var v = ov.swizzle.xyxx;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 5u, 1u, 8u);
            var v = ov.swizzle.xyxy;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 1u, 4u, 9u);
            var v = ov.swizzle.xyxz;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 8u, 9u, 4u);
            var v = ov.swizzle.xyxw;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 4u, 2u, 8u);
            var v = ov.swizzle.xyy;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 1u, 9u, 5u);
            var v = ov.swizzle.xyyx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 1u, 4u, 3u);
            var v = ov.swizzle.xyyy;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 4u, 7u, 7u);
            var v = ov.swizzle.xyyz;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 8u, 9u, 8u);
            var v = ov.swizzle.xyyw;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 6u, 2u, 6u);
            var v = ov.swizzle.xyz;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 4u, 0u, 9u);
            var v = ov.swizzle.xyzx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 3u, 5u, 3u);
            var v = ov.swizzle.xyzy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 7u, 9u, 3u);
            var v = ov.swizzle.xyzz;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 7u, 5u, 5u);
            var v = ov.swizzle.xyzw;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 7u, 5u, 8u);
            var v = ov.swizzle.xyw;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 8u, 4u, 5u);
            var v = ov.swizzle.xywx;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 6u, 4u, 0u);
            var v = ov.swizzle.xywy;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 0u, 6u, 8u);
            var v = ov.swizzle.xywz;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 5u, 3u, 0u);
            var v = ov.swizzle.xyww;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 9u, 3u, 7u);
            var v = ov.swizzle.xz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(6u, 0u, 2u, 6u);
            var v = ov.swizzle.xzx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 3u, 4u, 6u);
            var v = ov.swizzle.xzxx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 4u, 2u, 0u);
            var v = ov.swizzle.xzxy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 4u, 5u, 6u);
            var v = ov.swizzle.xzxz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 4u, 5u, 5u);
            var v = ov.swizzle.xzxw;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 4u, 4u, 9u);
            var v = ov.swizzle.xzy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(1u, 1u, 2u, 6u);
            var v = ov.swizzle.xzyx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 5u, 3u, 6u);
            var v = ov.swizzle.xzyy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 7u, 2u, 0u);
            var v = ov.swizzle.xzyz;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 8u, 1u, 1u);
            var v = ov.swizzle.xzyw;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 7u, 7u, 5u);
            var v = ov.swizzle.xzz;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 6u, 7u, 6u);
            var v = ov.swizzle.xzzx;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 7u, 0u, 7u);
            var v = ov.swizzle.xzzy;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 7u, 8u, 1u);
            var v = ov.swizzle.xzzz;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 2u, 5u, 2u);
            var v = ov.swizzle.xzzw;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 8u, 3u, 7u);
            var v = ov.swizzle.xzw;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(1u, 6u, 5u, 3u);
            var v = ov.swizzle.xzwx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 5u, 0u, 1u);
            var v = ov.swizzle.xzwy;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 4u, 3u, 1u);
            var v = ov.swizzle.xzwz;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 9u, 1u, 4u);
            var v = ov.swizzle.xzww;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 5u, 6u, 6u);
            var v = ov.swizzle.xw;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(5u, 5u, 2u, 6u);
            var v = ov.swizzle.xwx;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 0u, 3u, 3u);
            var v = ov.swizzle.xwxx;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 8u, 0u, 3u);
            var v = ov.swizzle.xwxy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 0u, 4u, 1u);
            var v = ov.swizzle.xwxz;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 3u, 5u, 4u);
            var v = ov.swizzle.xwxw;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 8u, 4u, 9u);
            var v = ov.swizzle.xwy;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 7u, 4u, 6u);
            var v = ov.swizzle.xwyx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 0u, 8u, 5u);
            var v = ov.swizzle.xwyy;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 6u, 2u, 5u);
            var v = ov.swizzle.xwyz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 9u, 4u, 1u);
            var v = ov.swizzle.xwyw;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 6u, 8u, 4u);
            var v = ov.swizzle.xwz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 9u, 6u, 7u);
            var v = ov.swizzle.xwzx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 0u, 3u, 0u);
            var v = ov.swizzle.xwzy;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 1u, 8u, 6u);
            var v = ov.swizzle.xwzz;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 2u, 1u, 1u);
            var v = ov.swizzle.xwzw;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 6u, 3u, 2u);
            var v = ov.swizzle.xww;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 4u, 2u, 8u);
            var v = ov.swizzle.xwwx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 8u, 7u, 1u);
            var v = ov.swizzle.xwwy;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 3u, 3u, 1u);
            var v = ov.swizzle.xwwz;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 9u, 5u, 5u);
            var v = ov.swizzle.xwww;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 6u, 1u, 0u);
            var v = ov.swizzle.yx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(7u, 8u, 5u, 9u);
            var v = ov.swizzle.yxx;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(7u, 5u, 3u, 1u);
            var v = ov.swizzle.yxxx;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 3u, 4u, 4u);
            var v = ov.swizzle.yxxy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 6u, 4u, 9u);
            var v = ov.swizzle.yxxz;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 7u, 8u, 6u);
            var v = ov.swizzle.yxxw;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 2u, 1u, 6u);
            var v = ov.swizzle.yxy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 7u, 6u, 1u);
            var v = ov.swizzle.yxyx;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 6u, 0u, 9u);
            var v = ov.swizzle.yxyy;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 3u, 4u, 1u);
            var v = ov.swizzle.yxyz;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 2u, 0u, 2u);
            var v = ov.swizzle.yxyw;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 6u, 3u, 5u);
            var v = ov.swizzle.yxz;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 8u, 8u, 2u);
            var v = ov.swizzle.yxzx;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 6u, 8u, 3u);
            var v = ov.swizzle.yxzy;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 5u, 8u, 4u);
            var v = ov.swizzle.yxzz;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 8u, 0u, 0u);
            var v = ov.swizzle.yxzw;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 1u, 4u, 0u);
            var v = ov.swizzle.yxw;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(3u, 5u, 9u, 9u);
            var v = ov.swizzle.yxwx;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 2u, 0u, 4u);
            var v = ov.swizzle.yxwy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 6u, 0u, 5u);
            var v = ov.swizzle.yxwz;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 6u, 7u, 0u);
            var v = ov.swizzle.yxww;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 3u, 6u, 0u);
            var v = ov.swizzle.yy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(8u, 6u, 1u, 0u);
            var v = ov.swizzle.yyx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(5u, 0u, 5u, 0u);
            var v = ov.swizzle.yyxx;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 9u, 3u, 4u);
            var v = ov.swizzle.yyxy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 3u, 2u, 4u);
            var v = ov.swizzle.yyxz;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 9u, 0u, 2u);
            var v = ov.swizzle.yyxw;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 4u, 5u, 1u);
            var v = ov.swizzle.yyy;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 2u, 6u, 0u);
            var v = ov.swizzle.yyyx;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 0u, 1u, 5u);
            var v = ov.swizzle.yyyy;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 3u, 2u, 6u);
            var v = ov.swizzle.yyyz;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 8u, 4u, 1u);
            var v = ov.swizzle.yyyw;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 9u, 2u, 7u);
            var v = ov.swizzle.yyz;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(3u, 6u, 2u, 5u);
            var v = ov.swizzle.yyzx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 3u, 0u, 9u);
            var v = ov.swizzle.yyzy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 3u, 5u, 4u);
            var v = ov.swizzle.yyzz;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 9u, 6u, 2u);
            var v = ov.swizzle.yyzw;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 4u, 9u, 1u);
            var v = ov.swizzle.yyw;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 7u, 8u, 9u);
            var v = ov.swizzle.yywx;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 5u, 0u, 0u);
            var v = ov.swizzle.yywy;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 9u, 5u, 6u);
            var v = ov.swizzle.yywz;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 7u, 8u, 7u);
            var v = ov.swizzle.yyww;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 1u, 6u, 8u);
            var v = ov.swizzle.yz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(9u, 2u, 2u, 1u);
            var v = ov.swizzle.yzx;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(7u, 8u, 5u, 4u);
            var v = ov.swizzle.yzxx;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 1u, 8u, 3u);
            var v = ov.swizzle.yzxy;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 1u, 9u, 5u);
            var v = ov.swizzle.yzxz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 3u, 4u, 8u);
            var v = ov.swizzle.yzxw;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 0u, 4u, 3u);
            var v = ov.swizzle.yzy;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 9u, 2u, 2u);
            var v = ov.swizzle.yzyx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 8u, 2u, 2u);
            var v = ov.swizzle.yzyy;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 1u, 1u, 5u);
            var v = ov.swizzle.yzyz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 7u, 1u, 2u);
            var v = ov.swizzle.yzyw;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 6u, 8u, 3u);
            var v = ov.swizzle.yzz;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 1u, 5u, 0u);
            var v = ov.swizzle.yzzx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 3u, 9u, 6u);
            var v = ov.swizzle.yzzy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 8u, 5u, 9u);
            var v = ov.swizzle.yzzz;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 9u, 3u, 8u);
            var v = ov.swizzle.yzzw;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 2u, 3u, 3u);
            var v = ov.swizzle.yzw;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 5u, 5u, 8u);
            var v = ov.swizzle.yzwx;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 3u, 0u, 0u);
            var v = ov.swizzle.yzwy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 1u, 8u, 5u);
            var v = ov.swizzle.yzwz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 1u, 2u, 6u);
            var v = ov.swizzle.yzww;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 1u, 4u, 7u);
            var v = ov.swizzle.yw;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(9u, 6u, 5u, 9u);
            var v = ov.swizzle.ywx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(6u, 1u, 8u, 5u);
            var v = ov.swizzle.ywxx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 2u, 6u, 7u);
            var v = ov.swizzle.ywxy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 5u, 4u, 5u);
            var v = ov.swizzle.ywxz;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 7u, 1u, 4u);
            var v = ov.swizzle.ywxw;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 8u, 3u, 5u);
            var v = ov.swizzle.ywy;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 9u, 8u, 5u);
            var v = ov.swizzle.ywyx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 6u, 5u, 4u);
            var v = ov.swizzle.ywyy;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 5u, 4u, 2u);
            var v = ov.swizzle.ywyz;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 5u, 2u, 8u);
            var v = ov.swizzle.ywyw;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 5u, 7u, 9u);
            var v = ov.swizzle.ywz;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 1u, 2u, 6u);
            var v = ov.swizzle.ywzx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 7u, 9u, 6u);
            var v = ov.swizzle.ywzy;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 0u, 5u, 0u);
            var v = ov.swizzle.ywzz;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 0u, 9u, 6u);
            var v = ov.swizzle.ywzw;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 2u, 8u, 7u);
            var v = ov.swizzle.yww;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(7u, 2u, 8u, 7u);
            var v = ov.swizzle.ywwx;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 2u, 4u, 0u);
            var v = ov.swizzle.ywwy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 2u, 8u, 6u);
            var v = ov.swizzle.ywwz;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 4u, 0u, 8u);
            var v = ov.swizzle.ywww;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 1u, 8u, 9u);
            var v = ov.swizzle.zx;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(6u, 9u, 4u, 7u);
            var v = ov.swizzle.zxx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 3u, 9u, 0u);
            var v = ov.swizzle.zxxx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 6u, 4u, 2u);
            var v = ov.swizzle.zxxy;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 0u, 1u, 2u);
            var v = ov.swizzle.zxxz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 5u, 5u, 5u);
            var v = ov.swizzle.zxxw;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 8u, 1u, 7u);
            var v = ov.swizzle.zxy;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(1u, 8u, 9u, 8u);
            var v = ov.swizzle.zxyx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 0u, 9u, 2u);
            var v = ov.swizzle.zxyy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 9u, 0u, 8u);
            var v = ov.swizzle.zxyz;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 1u, 6u, 7u);
            var v = ov.swizzle.zxyw;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 4u, 4u, 8u);
            var v = ov.swizzle.zxz;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 5u, 9u, 1u);
            var v = ov.swizzle.zxzx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 7u, 6u, 1u);
            var v = ov.swizzle.zxzy;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 3u, 6u, 8u);
            var v = ov.swizzle.zxzz;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 7u, 6u, 2u);
            var v = ov.swizzle.zxzw;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 0u, 0u, 5u);
            var v = ov.swizzle.zxw;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(6u, 2u, 8u, 7u);
            var v = ov.swizzle.zxwx;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 3u, 4u, 1u);
            var v = ov.swizzle.zxwy;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 8u, 2u, 8u);
            var v = ov.swizzle.zxwz;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 3u, 8u, 5u);
            var v = ov.swizzle.zxww;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 7u, 5u, 2u);
            var v = ov.swizzle.zy;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(4u, 7u, 6u, 0u);
            var v = ov.swizzle.zyx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(3u, 2u, 0u, 1u);
            var v = ov.swizzle.zyxx;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 4u, 3u, 2u);
            var v = ov.swizzle.zyxy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 9u, 1u, 5u);
            var v = ov.swizzle.zyxz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 1u, 1u, 8u);
            var v = ov.swizzle.zyxw;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 5u, 3u, 7u);
            var v = ov.swizzle.zyy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 7u, 3u, 4u);
            var v = ov.swizzle.zyyx;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 0u, 3u, 6u);
            var v = ov.swizzle.zyyy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 8u, 0u, 8u);
            var v = ov.swizzle.zyyz;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 7u, 4u, 7u);
            var v = ov.swizzle.zyyw;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 3u, 5u, 4u);
            var v = ov.swizzle.zyz;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 0u, 4u, 5u);
            var v = ov.swizzle.zyzx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 3u, 8u, 7u);
            var v = ov.swizzle.zyzy;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 6u, 8u, 9u);
            var v = ov.swizzle.zyzz;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 8u, 9u, 5u);
            var v = ov.swizzle.zyzw;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 6u, 2u, 4u);
            var v = ov.swizzle.zyw;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 7u, 6u, 5u);
            var v = ov.swizzle.zywx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 3u, 9u, 9u);
            var v = ov.swizzle.zywy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 3u, 6u, 0u);
            var v = ov.swizzle.zywz;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 9u, 3u, 0u);
            var v = ov.swizzle.zyww;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 8u, 2u, 5u);
            var v = ov.swizzle.zz;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(1u, 6u, 9u, 8u);
            var v = ov.swizzle.zzx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 1u, 4u, 7u);
            var v = ov.swizzle.zzxx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 8u, 9u, 6u);
            var v = ov.swizzle.zzxy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 1u, 3u, 6u);
            var v = ov.swizzle.zzxz;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 8u, 6u, 8u);
            var v = ov.swizzle.zzxw;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 9u, 9u, 2u);
            var v = ov.swizzle.zzy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 8u, 0u, 5u);
            var v = ov.swizzle.zzyx;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 9u, 1u, 9u);
            var v = ov.swizzle.zzyy;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 7u, 2u, 4u);
            var v = ov.swizzle.zzyz;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 8u, 6u, 7u);
            var v = ov.swizzle.zzyw;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 2u, 1u, 8u);
            var v = ov.swizzle.zzz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 0u, 9u, 7u);
            var v = ov.swizzle.zzzx;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 6u, 7u, 5u);
            var v = ov.swizzle.zzzy;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 4u, 1u, 2u);
            var v = ov.swizzle.zzzz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 7u, 7u, 0u);
            var v = ov.swizzle.zzzw;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 8u, 1u, 8u);
            var v = ov.swizzle.zzw;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(6u, 9u, 1u, 2u);
            var v = ov.swizzle.zzwx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 8u, 8u, 5u);
            var v = ov.swizzle.zzwy;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 9u, 9u, 1u);
            var v = ov.swizzle.zzwz;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 0u, 8u, 0u);
            var v = ov.swizzle.zzww;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 2u, 9u, 9u);
            var v = ov.swizzle.zw;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(2u, 6u, 8u, 9u);
            var v = ov.swizzle.zwx;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(6u, 0u, 8u, 0u);
            var v = ov.swizzle.zwxx;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 5u, 6u, 0u);
            var v = ov.swizzle.zwxy;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 2u, 1u, 5u);
            var v = ov.swizzle.zwxz;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 6u, 9u, 7u);
            var v = ov.swizzle.zwxw;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 1u, 3u, 2u);
            var v = ov.swizzle.zwy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 9u, 4u, 5u);
            var v = ov.swizzle.zwyx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 7u, 1u, 8u);
            var v = ov.swizzle.zwyy;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 1u, 6u, 0u);
            var v = ov.swizzle.zwyz;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 1u, 6u, 8u);
            var v = ov.swizzle.zwyw;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 8u, 4u, 6u);
            var v = ov.swizzle.zwz;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(3u, 9u, 0u, 5u);
            var v = ov.swizzle.zwzx;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 2u, 2u, 2u);
            var v = ov.swizzle.zwzy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 2u, 2u, 0u);
            var v = ov.swizzle.zwzz;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 6u, 5u, 6u);
            var v = ov.swizzle.zwzw;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 2u, 1u, 2u);
            var v = ov.swizzle.zww;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 7u, 1u, 8u);
            var v = ov.swizzle.zwwx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 1u, 3u, 6u);
            var v = ov.swizzle.zwwy;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 0u, 6u, 8u);
            var v = ov.swizzle.zwwz;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 7u, 8u, 4u);
            var v = ov.swizzle.zwww;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 8u, 6u, 6u);
            var v = ov.swizzle.wx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(5u, 9u, 5u, 6u);
            var v = ov.swizzle.wxx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 5u, 7u, 5u);
            var v = ov.swizzle.wxxx;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 9u, 2u, 8u);
            var v = ov.swizzle.wxxy;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 1u, 1u, 6u);
            var v = ov.swizzle.wxxz;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 1u, 9u, 7u);
            var v = ov.swizzle.wxxw;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 5u, 1u, 2u);
            var v = ov.swizzle.wxy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(5u, 3u, 3u, 5u);
            var v = ov.swizzle.wxyx;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 0u, 7u, 7u);
            var v = ov.swizzle.wxyy;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 5u, 7u, 4u);
            var v = ov.swizzle.wxyz;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 4u, 9u, 0u);
            var v = ov.swizzle.wxyw;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 8u, 0u, 0u);
            var v = ov.swizzle.wxz;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 8u, 2u, 5u);
            var v = ov.swizzle.wxzx;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 2u, 6u, 7u);
            var v = ov.swizzle.wxzy;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 9u, 6u, 9u);
            var v = ov.swizzle.wxzz;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 3u, 1u, 6u);
            var v = ov.swizzle.wxzw;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 1u, 7u, 5u);
            var v = ov.swizzle.wxw;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(2u, 4u, 2u, 1u);
            var v = ov.swizzle.wxwx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 7u, 4u, 4u);
            var v = ov.swizzle.wxwy;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 9u, 3u, 0u);
            var v = ov.swizzle.wxwz;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 1u, 3u, 6u);
            var v = ov.swizzle.wxww;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 8u, 9u, 5u);
            var v = ov.swizzle.wy;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(4u, 0u, 8u, 6u);
            var v = ov.swizzle.wyx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 7u, 7u, 7u);
            var v = ov.swizzle.wyxx;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 2u, 7u, 2u);
            var v = ov.swizzle.wyxy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 4u, 8u, 3u);
            var v = ov.swizzle.wyxz;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 0u, 0u, 8u);
            var v = ov.swizzle.wyxw;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 2u, 4u, 9u);
            var v = ov.swizzle.wyy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(5u, 6u, 4u, 6u);
            var v = ov.swizzle.wyyx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 4u, 5u, 4u);
            var v = ov.swizzle.wyyy;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 2u, 1u, 2u);
            var v = ov.swizzle.wyyz;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 5u, 3u, 7u);
            var v = ov.swizzle.wyyw;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 6u, 1u, 0u);
            var v = ov.swizzle.wyz;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(1u, 1u, 9u, 1u);
            var v = ov.swizzle.wyzx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 9u, 0u, 0u);
            var v = ov.swizzle.wyzy;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 1u, 8u, 2u);
            var v = ov.swizzle.wyzz;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 9u, 0u, 1u);
            var v = ov.swizzle.wyzw;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 1u, 7u, 8u);
            var v = ov.swizzle.wyw;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(7u, 3u, 0u, 8u);
            var v = ov.swizzle.wywx;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 6u, 7u, 0u);
            var v = ov.swizzle.wywy;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 3u, 8u, 0u);
            var v = ov.swizzle.wywz;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 4u, 7u, 4u);
            var v = ov.swizzle.wyww;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 2u, 3u, 0u);
            var v = ov.swizzle.wz;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(4u, 4u, 6u, 0u);
            var v = ov.swizzle.wzx;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(3u, 9u, 6u, 6u);
            var v = ov.swizzle.wzxx;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 1u, 3u, 8u);
            var v = ov.swizzle.wzxy;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 2u, 2u, 8u);
            var v = ov.swizzle.wzxz;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 0u, 8u, 6u);
            var v = ov.swizzle.wzxw;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 9u, 3u, 4u);
            var v = ov.swizzle.wzy;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(3u, 7u, 1u, 1u);
            var v = ov.swizzle.wzyx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 6u, 4u, 0u);
            var v = ov.swizzle.wzyy;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 7u, 3u, 2u);
            var v = ov.swizzle.wzyz;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 0u, 4u, 3u);
            var v = ov.swizzle.wzyw;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 1u, 5u, 5u);
            var v = ov.swizzle.wzz;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 0u, 1u, 8u);
            var v = ov.swizzle.wzzx;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 9u, 4u, 6u);
            var v = ov.swizzle.wzzy;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 6u, 8u, 4u);
            var v = ov.swizzle.wzzz;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 2u, 7u, 6u);
            var v = ov.swizzle.wzzw;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 4u, 4u, 8u);
            var v = ov.swizzle.wzw;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(6u, 3u, 0u, 1u);
            var v = ov.swizzle.wzwx;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 0u, 2u, 9u);
            var v = ov.swizzle.wzwy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 4u, 6u, 0u);
            var v = ov.swizzle.wzwz;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 7u, 4u, 2u);
            var v = ov.swizzle.wzww;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 2u, 0u, 2u);
            var v = ov.swizzle.ww;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(2u, 8u, 5u, 2u);
            var v = ov.swizzle.wwx;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 9u, 0u, 3u);
            var v = ov.swizzle.wwxx;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 8u, 5u, 5u);
            var v = ov.swizzle.wwxy;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 6u, 9u, 5u);
            var v = ov.swizzle.wwxz;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 9u, 9u, 0u);
            var v = ov.swizzle.wwxw;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 4u, 1u, 9u);
            var v = ov.swizzle.wwy;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 7u, 0u, 4u);
            var v = ov.swizzle.wwyx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 4u, 9u, 5u);
            var v = ov.swizzle.wwyy;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 1u, 6u, 8u);
            var v = ov.swizzle.wwyz;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 7u, 2u, 0u);
            var v = ov.swizzle.wwyw;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 8u, 6u, 6u);
            var v = ov.swizzle.wwz;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 1u, 3u, 7u);
            var v = ov.swizzle.wwzx;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 9u, 2u, 7u);
            var v = ov.swizzle.wwzy;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 9u, 6u, 7u);
            var v = ov.swizzle.wwzz;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 5u, 2u, 1u);
            var v = ov.swizzle.wwzw;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 6u, 5u, 8u);
            var v = ov.swizzle.www;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 0u, 1u, 4u);
            var v = ov.swizzle.wwwx;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 0u, 7u, 2u);
            var v = ov.swizzle.wwwy;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 9u, 1u, 7u);
            var v = ov.swizzle.wwwz;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 4u, 1u, 8u);
            var v = ov.swizzle.wwww;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void RGBA()
    {
        {
            var ov = new uvec4(9u, 0u, 2u, 0u);
            var v = ov.swizzle.rr;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(8u, 7u, 2u, 8u);
            var v = ov.swizzle.rrr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(5u, 2u, 7u, 1u);
            var v = ov.swizzle.rrrr;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 9u, 1u, 6u);
            var v = ov.swizzle.rrrg;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 1u, 7u, 1u);
            var v = ov.swizzle.rrrb;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 0u, 1u, 1u);
            var v = ov.swizzle.rrra;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 0u, 9u, 4u);
            var v = ov.swizzle.rrg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 6u, 4u, 5u);
            var v = ov.swizzle.rrgr;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 8u, 4u, 1u);
            var v = ov.swizzle.rrgg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 9u, 7u, 3u);
            var v = ov.swizzle.rrgb;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 7u, 7u, 5u);
            var v = ov.swizzle.rrga;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 0u, 6u, 1u);
            var v = ov.swizzle.rrb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 3u, 8u, 4u);
            var v = ov.swizzle.rrbr;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 5u, 4u, 8u);
            var v = ov.swizzle.rrbg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 0u, 0u, 7u);
            var v = ov.swizzle.rrbb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 8u, 4u, 9u);
            var v = ov.swizzle.rrba;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 1u, 9u, 8u);
            var v = ov.swizzle.rra;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(5u, 0u, 1u, 0u);
            var v = ov.swizzle.rrar;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 4u, 3u, 8u);
            var v = ov.swizzle.rrag;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 5u, 2u, 9u);
            var v = ov.swizzle.rrab;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 7u, 3u, 1u);
            var v = ov.swizzle.rraa;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 9u, 4u, 5u);
            var v = ov.swizzle.rg;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(3u, 5u, 2u, 4u);
            var v = ov.swizzle.rgr;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 9u, 5u, 9u);
            var v = ov.swizzle.rgrr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 8u, 6u, 7u);
            var v = ov.swizzle.rgrg;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 7u, 6u, 0u);
            var v = ov.swizzle.rgrb;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 7u, 9u, 7u);
            var v = ov.swizzle.rgra;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 5u, 5u, 3u);
            var v = ov.swizzle.rgg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 1u, 3u, 0u);
            var v = ov.swizzle.rggr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 3u, 1u, 8u);
            var v = ov.swizzle.rggg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 3u, 4u, 9u);
            var v = ov.swizzle.rggb;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 7u, 2u, 5u);
            var v = ov.swizzle.rgga;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 3u, 5u, 5u);
            var v = ov.swizzle.rgb;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 4u, 8u, 6u);
            var v = ov.swizzle.rgbr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 2u, 9u, 0u);
            var v = ov.swizzle.rgbg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 7u, 4u, 8u);
            var v = ov.swizzle.rgbb;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 8u, 6u, 7u);
            var v = ov.swizzle.rgba;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 5u, 5u, 9u);
            var v = ov.swizzle.rga;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(6u, 7u, 1u, 6u);
            var v = ov.swizzle.rgar;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 7u, 3u, 3u);
            var v = ov.swizzle.rgag;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 4u, 8u, 7u);
            var v = ov.swizzle.rgab;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 0u, 4u, 3u);
            var v = ov.swizzle.rgaa;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 6u, 9u, 2u);
            var v = ov.swizzle.rb;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(3u, 1u, 8u, 9u);
            var v = ov.swizzle.rbr;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 6u, 8u, 8u);
            var v = ov.swizzle.rbrr;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 4u, 9u, 3u);
            var v = ov.swizzle.rbrg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 6u, 8u, 0u);
            var v = ov.swizzle.rbrb;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 1u, 3u, 2u);
            var v = ov.swizzle.rbra;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 6u, 4u, 5u);
            var v = ov.swizzle.rbg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 6u, 8u, 0u);
            var v = ov.swizzle.rbgr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 2u, 4u, 8u);
            var v = ov.swizzle.rbgg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 3u, 6u, 5u);
            var v = ov.swizzle.rbgb;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 1u, 7u, 7u);
            var v = ov.swizzle.rbga;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 4u, 1u, 1u);
            var v = ov.swizzle.rbb;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(5u, 5u, 8u, 3u);
            var v = ov.swizzle.rbbr;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 3u, 9u, 1u);
            var v = ov.swizzle.rbbg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 6u, 2u, 6u);
            var v = ov.swizzle.rbbb;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 3u, 1u, 3u);
            var v = ov.swizzle.rbba;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 8u, 4u, 9u);
            var v = ov.swizzle.rba;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 0u, 8u, 5u);
            var v = ov.swizzle.rbar;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 2u, 1u, 2u);
            var v = ov.swizzle.rbag;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 6u, 4u, 5u);
            var v = ov.swizzle.rbab;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 3u, 0u, 3u);
            var v = ov.swizzle.rbaa;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 5u, 8u, 0u);
            var v = ov.swizzle.ra;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(3u, 3u, 5u, 8u);
            var v = ov.swizzle.rar;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 9u, 8u, 6u);
            var v = ov.swizzle.rarr;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 4u, 9u, 0u);
            var v = ov.swizzle.rarg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 2u, 1u, 4u);
            var v = ov.swizzle.rarb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 3u, 3u, 8u);
            var v = ov.swizzle.rara;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 7u, 7u, 7u);
            var v = ov.swizzle.rag;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(2u, 7u, 1u, 2u);
            var v = ov.swizzle.ragr;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 7u, 5u, 2u);
            var v = ov.swizzle.ragg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 4u, 6u, 5u);
            var v = ov.swizzle.ragb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 9u, 5u, 0u);
            var v = ov.swizzle.raga;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 5u, 2u, 9u);
            var v = ov.swizzle.rab;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(6u, 3u, 5u, 3u);
            var v = ov.swizzle.rabr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 6u, 6u, 4u);
            var v = ov.swizzle.rabg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 9u, 8u, 5u);
            var v = ov.swizzle.rabb;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 7u, 5u, 3u);
            var v = ov.swizzle.raba;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 5u, 3u, 2u);
            var v = ov.swizzle.raa;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 6u, 0u, 5u);
            var v = ov.swizzle.raar;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 5u, 8u, 7u);
            var v = ov.swizzle.raag;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 2u, 4u, 6u);
            var v = ov.swizzle.raab;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 7u, 0u, 9u);
            var v = ov.swizzle.raaa;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 8u, 0u, 6u);
            var v = ov.swizzle.gr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(1u, 1u, 0u, 0u);
            var v = ov.swizzle.grr;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(5u, 0u, 9u, 8u);
            var v = ov.swizzle.grrr;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 1u, 2u, 8u);
            var v = ov.swizzle.grrg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 9u, 1u, 0u);
            var v = ov.swizzle.grrb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 0u, 7u, 6u);
            var v = ov.swizzle.grra;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 9u, 6u, 9u);
            var v = ov.swizzle.grg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 2u, 0u, 9u);
            var v = ov.swizzle.grgr;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 5u, 1u, 0u);
            var v = ov.swizzle.grgg;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 7u, 0u, 7u);
            var v = ov.swizzle.grgb;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 0u, 9u, 5u);
            var v = ov.swizzle.grga;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 0u, 2u, 6u);
            var v = ov.swizzle.grb;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 6u, 4u, 5u);
            var v = ov.swizzle.grbr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 0u, 7u, 1u);
            var v = ov.swizzle.grbg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 4u, 8u, 2u);
            var v = ov.swizzle.grbb;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 1u, 5u, 3u);
            var v = ov.swizzle.grba;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 9u, 0u, 8u);
            var v = ov.swizzle.gra;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 2u, 3u, 4u);
            var v = ov.swizzle.grar;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 3u, 4u, 1u);
            var v = ov.swizzle.grag;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 1u, 0u, 7u);
            var v = ov.swizzle.grab;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 9u, 9u, 8u);
            var v = ov.swizzle.graa;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 4u, 3u, 6u);
            var v = ov.swizzle.gg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(8u, 0u, 9u, 1u);
            var v = ov.swizzle.ggr;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 8u, 2u, 3u);
            var v = ov.swizzle.ggrr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 5u, 5u, 6u);
            var v = ov.swizzle.ggrg;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 3u, 6u, 7u);
            var v = ov.swizzle.ggrb;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 9u, 6u, 2u);
            var v = ov.swizzle.ggra;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 5u, 0u, 9u);
            var v = ov.swizzle.ggg;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(3u, 1u, 5u, 4u);
            var v = ov.swizzle.gggr;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 7u, 5u, 5u);
            var v = ov.swizzle.gggg;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 3u, 9u, 9u);
            var v = ov.swizzle.gggb;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 2u, 5u, 1u);
            var v = ov.swizzle.ggga;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 0u, 6u, 5u);
            var v = ov.swizzle.ggb;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(6u, 4u, 7u, 2u);
            var v = ov.swizzle.ggbr;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 2u, 4u, 8u);
            var v = ov.swizzle.ggbg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 1u, 1u, 3u);
            var v = ov.swizzle.ggbb;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 9u, 7u, 8u);
            var v = ov.swizzle.ggba;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 7u, 1u, 8u);
            var v = ov.swizzle.gga;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 9u, 0u, 5u);
            var v = ov.swizzle.ggar;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 6u, 3u, 1u);
            var v = ov.swizzle.ggag;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 5u, 1u, 4u);
            var v = ov.swizzle.ggab;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 5u, 2u, 9u);
            var v = ov.swizzle.ggaa;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 3u, 1u, 0u);
            var v = ov.swizzle.gb;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(2u, 7u, 7u, 4u);
            var v = ov.swizzle.gbr;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(2u, 6u, 9u, 3u);
            var v = ov.swizzle.gbrr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 7u, 8u, 3u);
            var v = ov.swizzle.gbrg;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 7u, 5u, 7u);
            var v = ov.swizzle.gbrb;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 1u, 8u, 7u);
            var v = ov.swizzle.gbra;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 2u, 3u, 2u);
            var v = ov.swizzle.gbg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 6u, 4u, 4u);
            var v = ov.swizzle.gbgr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 8u, 4u, 9u);
            var v = ov.swizzle.gbgg;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 1u, 5u, 2u);
            var v = ov.swizzle.gbgb;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 5u, 3u, 8u);
            var v = ov.swizzle.gbga;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 0u, 7u, 7u);
            var v = ov.swizzle.gbb;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(6u, 7u, 5u, 1u);
            var v = ov.swizzle.gbbr;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 4u, 4u, 1u);
            var v = ov.swizzle.gbbg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 4u, 2u, 0u);
            var v = ov.swizzle.gbbb;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 4u, 4u, 5u);
            var v = ov.swizzle.gbba;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 4u, 5u, 6u);
            var v = ov.swizzle.gba;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(2u, 9u, 6u, 8u);
            var v = ov.swizzle.gbar;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 2u, 6u, 8u);
            var v = ov.swizzle.gbag;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 0u, 9u, 7u);
            var v = ov.swizzle.gbab;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 6u, 6u, 2u);
            var v = ov.swizzle.gbaa;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 3u, 4u, 2u);
            var v = ov.swizzle.ga;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(3u, 3u, 4u, 2u);
            var v = ov.swizzle.gar;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 5u, 8u, 6u);
            var v = ov.swizzle.garr;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 7u, 6u, 2u);
            var v = ov.swizzle.garg;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 0u, 4u, 6u);
            var v = ov.swizzle.garb;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 7u, 8u, 7u);
            var v = ov.swizzle.gara;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 6u, 2u, 4u);
            var v = ov.swizzle.gag;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 4u, 4u, 7u);
            var v = ov.swizzle.gagr;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 1u, 4u, 8u);
            var v = ov.swizzle.gagg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 3u, 3u, 9u);
            var v = ov.swizzle.gagb;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 3u, 8u, 7u);
            var v = ov.swizzle.gaga;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 9u, 7u, 1u);
            var v = ov.swizzle.gab;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(3u, 7u, 3u, 4u);
            var v = ov.swizzle.gabr;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 9u, 0u, 3u);
            var v = ov.swizzle.gabg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 7u, 4u, 7u);
            var v = ov.swizzle.gabb;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 9u, 8u, 4u);
            var v = ov.swizzle.gaba;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 1u, 7u, 9u);
            var v = ov.swizzle.gaa;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(2u, 7u, 2u, 1u);
            var v = ov.swizzle.gaar;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 5u, 0u, 7u);
            var v = ov.swizzle.gaag;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 1u, 3u, 8u);
            var v = ov.swizzle.gaab;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 1u, 0u, 6u);
            var v = ov.swizzle.gaaa;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 9u, 4u, 8u);
            var v = ov.swizzle.br;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(0u, 1u, 4u, 2u);
            var v = ov.swizzle.brr;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 6u, 9u, 6u);
            var v = ov.swizzle.brrr;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 4u, 6u, 2u);
            var v = ov.swizzle.brrg;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 7u, 8u, 6u);
            var v = ov.swizzle.brrb;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 1u, 7u, 6u);
            var v = ov.swizzle.brra;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 3u, 4u, 3u);
            var v = ov.swizzle.brg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(3u, 5u, 8u, 8u);
            var v = ov.swizzle.brgr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 1u, 3u, 0u);
            var v = ov.swizzle.brgg;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 8u, 8u, 1u);
            var v = ov.swizzle.brgb;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 9u, 2u, 1u);
            var v = ov.swizzle.brga;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 4u, 2u, 4u);
            var v = ov.swizzle.brb;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 1u, 6u, 0u);
            var v = ov.swizzle.brbr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 4u, 2u, 8u);
            var v = ov.swizzle.brbg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 7u, 9u, 7u);
            var v = ov.swizzle.brbb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 1u, 9u, 3u);
            var v = ov.swizzle.brba;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 0u, 7u, 4u);
            var v = ov.swizzle.bra;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 6u, 5u, 3u);
            var v = ov.swizzle.brar;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 7u, 3u, 5u);
            var v = ov.swizzle.brag;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 5u, 0u, 4u);
            var v = ov.swizzle.brab;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 0u, 9u, 2u);
            var v = ov.swizzle.braa;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 7u, 6u, 4u);
            var v = ov.swizzle.bg;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(9u, 4u, 8u, 8u);
            var v = ov.swizzle.bgr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 1u, 4u, 1u);
            var v = ov.swizzle.bgrr;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 8u, 3u, 5u);
            var v = ov.swizzle.bgrg;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 7u, 3u, 8u);
            var v = ov.swizzle.bgrb;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 3u, 1u, 5u);
            var v = ov.swizzle.bgra;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 7u, 9u, 6u);
            var v = ov.swizzle.bgg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(7u, 5u, 6u, 6u);
            var v = ov.swizzle.bggr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 7u, 4u, 9u);
            var v = ov.swizzle.bggg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 2u, 5u, 5u);
            var v = ov.swizzle.bggb;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 6u, 4u, 7u);
            var v = ov.swizzle.bgga;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 1u, 4u, 0u);
            var v = ov.swizzle.bgb;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(1u, 4u, 6u, 3u);
            var v = ov.swizzle.bgbr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 0u, 6u, 5u);
            var v = ov.swizzle.bgbg;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 0u, 3u, 1u);
            var v = ov.swizzle.bgbb;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 1u, 1u, 3u);
            var v = ov.swizzle.bgba;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 8u, 9u, 3u);
            var v = ov.swizzle.bga;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 4u, 1u, 4u);
            var v = ov.swizzle.bgar;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 8u, 0u, 9u);
            var v = ov.swizzle.bgag;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 3u, 2u, 9u);
            var v = ov.swizzle.bgab;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 8u, 4u, 2u);
            var v = ov.swizzle.bgaa;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 2u, 9u, 1u);
            var v = ov.swizzle.bb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(0u, 9u, 3u, 3u);
            var v = ov.swizzle.bbr;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(9u, 3u, 0u, 5u);
            var v = ov.swizzle.bbrr;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 0u, 2u, 4u);
            var v = ov.swizzle.bbrg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 1u, 6u, 7u);
            var v = ov.swizzle.bbrb;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 2u, 1u, 7u);
            var v = ov.swizzle.bbra;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 7u, 5u, 2u);
            var v = ov.swizzle.bbg;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 4u, 9u, 6u);
            var v = ov.swizzle.bbgr;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 9u, 4u, 2u);
            var v = ov.swizzle.bbgg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 8u, 2u, 4u);
            var v = ov.swizzle.bbgb;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 8u, 5u, 9u);
            var v = ov.swizzle.bbga;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 4u, 4u, 8u);
            var v = ov.swizzle.bbb;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 7u, 6u, 1u);
            var v = ov.swizzle.bbbr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 6u, 9u, 6u);
            var v = ov.swizzle.bbbg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 1u, 0u, 3u);
            var v = ov.swizzle.bbbb;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 0u, 4u, 4u);
            var v = ov.swizzle.bbba;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 3u, 8u, 5u);
            var v = ov.swizzle.bba;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(6u, 0u, 6u, 4u);
            var v = ov.swizzle.bbar;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 1u, 6u, 4u);
            var v = ov.swizzle.bbag;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 1u, 9u, 5u);
            var v = ov.swizzle.bbab;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 7u, 2u, 0u);
            var v = ov.swizzle.bbaa;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 8u, 3u, 0u);
            var v = ov.swizzle.ba;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(0u, 7u, 0u, 6u);
            var v = ov.swizzle.bar;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(7u, 9u, 0u, 1u);
            var v = ov.swizzle.barr;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 0u, 5u, 4u);
            var v = ov.swizzle.barg;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 8u, 1u, 0u);
            var v = ov.swizzle.barb;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 2u, 2u, 0u);
            var v = ov.swizzle.bara;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 5u, 0u, 9u);
            var v = ov.swizzle.bag;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(2u, 5u, 0u, 6u);
            var v = ov.swizzle.bagr;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 3u, 7u, 5u);
            var v = ov.swizzle.bagg;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 8u, 5u, 8u);
            var v = ov.swizzle.bagb;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 0u, 6u, 9u);
            var v = ov.swizzle.baga;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 5u, 0u, 5u);
            var v = ov.swizzle.bab;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(6u, 5u, 9u, 4u);
            var v = ov.swizzle.babr;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 1u, 9u, 4u);
            var v = ov.swizzle.babg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 3u, 9u, 4u);
            var v = ov.swizzle.babb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 0u, 4u, 2u);
            var v = ov.swizzle.baba;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 3u, 3u, 0u);
            var v = ov.swizzle.baa;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(3u, 9u, 4u, 8u);
            var v = ov.swizzle.baar;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 3u, 1u, 0u);
            var v = ov.swizzle.baag;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 2u, 9u, 5u);
            var v = ov.swizzle.baab;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 4u, 3u, 6u);
            var v = ov.swizzle.baaa;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 6u, 1u, 6u);
            var v = ov.swizzle.ar;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(3u, 2u, 0u, 6u);
            var v = ov.swizzle.arr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 0u, 1u, 8u);
            var v = ov.swizzle.arrr;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 4u, 0u, 7u);
            var v = ov.swizzle.arrg;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 9u, 2u, 7u);
            var v = ov.swizzle.arrb;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 1u, 0u, 2u);
            var v = ov.swizzle.arra;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 8u, 8u, 2u);
            var v = ov.swizzle.arg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 4u, 9u, 3u);
            var v = ov.swizzle.argr;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 7u, 6u, 2u);
            var v = ov.swizzle.argg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 6u, 6u, 1u);
            var v = ov.swizzle.argb;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 8u, 9u, 2u);
            var v = ov.swizzle.arga;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 2u, 4u, 1u);
            var v = ov.swizzle.arb;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(2u, 1u, 3u, 5u);
            var v = ov.swizzle.arbr;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 5u, 6u, 4u);
            var v = ov.swizzle.arbg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 8u, 6u, 4u);
            var v = ov.swizzle.arbb;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 7u, 2u, 4u);
            var v = ov.swizzle.arba;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 7u, 0u, 8u);
            var v = ov.swizzle.ara;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(7u, 7u, 5u, 5u);
            var v = ov.swizzle.arar;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 0u, 8u, 2u);
            var v = ov.swizzle.arag;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 8u, 0u, 7u);
            var v = ov.swizzle.arab;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 6u, 0u, 2u);
            var v = ov.swizzle.araa;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 4u, 0u, 2u);
            var v = ov.swizzle.ag;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(0u, 2u, 7u, 3u);
            var v = ov.swizzle.agr;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 1u, 6u, 2u);
            var v = ov.swizzle.agrr;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 5u, 2u, 3u);
            var v = ov.swizzle.agrg;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 6u, 3u, 4u);
            var v = ov.swizzle.agrb;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 8u, 2u, 1u);
            var v = ov.swizzle.agra;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 4u, 2u, 7u);
            var v = ov.swizzle.agg;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 8u, 0u, 7u);
            var v = ov.swizzle.aggr;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 9u, 3u, 6u);
            var v = ov.swizzle.aggg;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 8u, 8u, 5u);
            var v = ov.swizzle.aggb;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 1u, 4u, 1u);
            var v = ov.swizzle.agga;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 6u, 6u, 5u);
            var v = ov.swizzle.agb;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(5u, 6u, 5u, 7u);
            var v = ov.swizzle.agbr;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 6u, 6u, 2u);
            var v = ov.swizzle.agbg;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 9u, 4u, 6u);
            var v = ov.swizzle.agbb;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 0u, 5u, 1u);
            var v = ov.swizzle.agba;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 9u, 5u, 5u);
            var v = ov.swizzle.aga;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(2u, 5u, 6u, 3u);
            var v = ov.swizzle.agar;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 8u, 4u, 3u);
            var v = ov.swizzle.agag;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 1u, 7u, 0u);
            var v = ov.swizzle.agab;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 7u, 1u, 1u);
            var v = ov.swizzle.agaa;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 2u, 4u, 9u);
            var v = ov.swizzle.ab;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(2u, 0u, 4u, 7u);
            var v = ov.swizzle.abr;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(3u, 2u, 5u, 9u);
            var v = ov.swizzle.abrr;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(6u, 3u, 0u, 4u);
            var v = ov.swizzle.abrg;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 0u, 3u, 0u);
            var v = ov.swizzle.abrb;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 2u, 0u, 4u);
            var v = ov.swizzle.abra;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 3u, 9u, 0u);
            var v = ov.swizzle.abg;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(2u, 3u, 8u, 2u);
            var v = ov.swizzle.abgr;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 3u, 8u, 8u);
            var v = ov.swizzle.abgg;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(3u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 5u, 2u, 1u);
            var v = ov.swizzle.abgb;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(0u, 9u, 9u, 5u);
            var v = ov.swizzle.abga;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 4u, 7u, 9u);
            var v = ov.swizzle.abb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(0u, 3u, 0u, 6u);
            var v = ov.swizzle.abbr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 0u, 1u, 1u);
            var v = ov.swizzle.abbg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 9u, 7u, 9u);
            var v = ov.swizzle.abbb;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 3u, 5u, 9u);
            var v = ov.swizzle.abba;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 3u, 0u, 2u);
            var v = ov.swizzle.aba;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(5u, 2u, 8u, 4u);
            var v = ov.swizzle.abar;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 2u, 9u, 0u);
            var v = ov.swizzle.abag;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 4u, 1u, 7u);
            var v = ov.swizzle.abab;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(5u, 9u, 0u, 9u);
            var v = ov.swizzle.abaa;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 1u, 8u, 8u);
            var v = ov.swizzle.aa;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
        }
        {
            var ov = new uvec4(2u, 6u, 5u, 5u);
            var v = ov.swizzle.aar;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(7u, 3u, 9u, 6u);
            var v = ov.swizzle.aarr;
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 0u, 2u, 9u);
            var v = ov.swizzle.aarg;
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 4u, 4u, 8u);
            var v = ov.swizzle.aarb;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 5u, 8u, 1u);
            var v = ov.swizzle.aara;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(1u, 0u, 9u, 8u);
            var v = ov.swizzle.aag;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(8u, 0u, 3u, 2u);
            var v = ov.swizzle.aagr;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(8u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 6u, 5u, 1u);
            var v = ov.swizzle.aagg;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(6u, Is.EqualTo(v.z));
            Assert.That(6u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 1u, 0u, 8u);
            var v = ov.swizzle.aagb;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 3u, 7u, 4u);
            var v = ov.swizzle.aaga;
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(2u, 2u, 7u, 1u);
            var v = ov.swizzle.aab;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(2u, 2u, 2u, 1u);
            var v = ov.swizzle.aabr;
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
            Assert.That(2u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 2u, 4u, 8u);
            var v = ov.swizzle.aabg;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(4u, Is.EqualTo(v.z));
            Assert.That(2u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 6u, 7u, 2u);
            var v = ov.swizzle.aabb;
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(7u, 7u, 7u, 7u);
            var v = ov.swizzle.aaba;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(7u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(9u, 6u, 3u, 7u);
            var v = ov.swizzle.aaa;
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
        }
        {
            var ov = new uvec4(4u, 0u, 4u, 3u);
            var v = ov.swizzle.aaar;
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
            Assert.That(4u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(4u, 5u, 1u, 0u);
            var v = ov.swizzle.aaag;
            Assert.That(0u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(8u, 3u, 9u, 8u);
            var v = ov.swizzle.aaab;
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(8u, Is.EqualTo(v.y));
            Assert.That(8u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var ov = new uvec4(3u, 7u, 5u, 5u);
            var v = ov.swizzle.aaaa;
            Assert.That(5u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(5u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void InlineXYZW()
    {
        {
            var v0 = new uvec4(2u, 9u, 1u, 3u);
            var v1 = new uvec2(7u, 9u);
            var v2 = v0.xy;
            v0.xy = v1;
            var v3 = v0.xy;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(7u, Is.EqualTo(v0.x));
            Assert.That(9u, Is.EqualTo(v0.y));
            Assert.That(1u, Is.EqualTo(v0.z));
            Assert.That(3u, Is.EqualTo(v0.w));
        
            Assert.That(2u, Is.EqualTo(v2.x));
            Assert.That(9u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec4(8u, 9u, 4u, 2u);
            var v1 = new uvec2(1u, 8u);
            var v2 = v0.xz;
            v0.xz = v1;
            var v3 = v0.xz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(1u, Is.EqualTo(v0.x));
            Assert.That(9u, Is.EqualTo(v0.y));
            Assert.That(8u, Is.EqualTo(v0.z));
            Assert.That(2u, Is.EqualTo(v0.w));
        
            Assert.That(8u, Is.EqualTo(v2.x));
            Assert.That(4u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec4(4u, 9u, 5u, 0u);
            var v1 = new uvec2(1u, 1u);
            var v2 = v0.yz;
            v0.yz = v1;
            var v3 = v0.yz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4u, Is.EqualTo(v0.x));
            Assert.That(1u, Is.EqualTo(v0.y));
            Assert.That(1u, Is.EqualTo(v0.z));
            Assert.That(0u, Is.EqualTo(v0.w));
        
            Assert.That(9u, Is.EqualTo(v2.x));
            Assert.That(5u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec4(7u, 2u, 2u, 4u);
            var v1 = new uvec3(4u, 6u, 6u);
            var v2 = v0.xyz;
            v0.xyz = v1;
            var v3 = v0.xyz;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4u, Is.EqualTo(v0.x));
            Assert.That(6u, Is.EqualTo(v0.y));
            Assert.That(6u, Is.EqualTo(v0.z));
            Assert.That(4u, Is.EqualTo(v0.w));
        
            Assert.That(7u, Is.EqualTo(v2.x));
            Assert.That(2u, Is.EqualTo(v2.y));
            Assert.That(2u, Is.EqualTo(v2.z));
        }
        {
            var v0 = new uvec4(3u, 7u, 1u, 1u);
            var v1 = new uvec2(0u, 4u);
            var v2 = v0.xw;
            v0.xw = v1;
            var v3 = v0.xw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(0u, Is.EqualTo(v0.x));
            Assert.That(7u, Is.EqualTo(v0.y));
            Assert.That(1u, Is.EqualTo(v0.z));
            Assert.That(4u, Is.EqualTo(v0.w));
        
            Assert.That(3u, Is.EqualTo(v2.x));
            Assert.That(1u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec4(2u, 0u, 1u, 5u);
            var v1 = new uvec2(5u, 5u);
            var v2 = v0.yw;
            v0.yw = v1;
            var v3 = v0.yw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(2u, Is.EqualTo(v0.x));
            Assert.That(5u, Is.EqualTo(v0.y));
            Assert.That(1u, Is.EqualTo(v0.z));
            Assert.That(5u, Is.EqualTo(v0.w));
        
            Assert.That(0u, Is.EqualTo(v2.x));
            Assert.That(5u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec4(5u, 8u, 9u, 4u);
            var v1 = new uvec3(2u, 5u, 2u);
            var v2 = v0.xyw;
            v0.xyw = v1;
            var v3 = v0.xyw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(2u, Is.EqualTo(v0.x));
            Assert.That(5u, Is.EqualTo(v0.y));
            Assert.That(9u, Is.EqualTo(v0.z));
            Assert.That(2u, Is.EqualTo(v0.w));
        
            Assert.That(5u, Is.EqualTo(v2.x));
            Assert.That(8u, Is.EqualTo(v2.y));
            Assert.That(4u, Is.EqualTo(v2.z));
        }
        {
            var v0 = new uvec4(4u, 1u, 2u, 0u);
            var v1 = new uvec2(1u, 7u);
            var v2 = v0.zw;
            v0.zw = v1;
            var v3 = v0.zw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4u, Is.EqualTo(v0.x));
            Assert.That(1u, Is.EqualTo(v0.y));
            Assert.That(1u, Is.EqualTo(v0.z));
            Assert.That(7u, Is.EqualTo(v0.w));
        
            Assert.That(2u, Is.EqualTo(v2.x));
            Assert.That(0u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec4(9u, 4u, 1u, 9u);
            var v1 = new uvec3(1u, 7u, 4u);
            var v2 = v0.xzw;
            v0.xzw = v1;
            var v3 = v0.xzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(1u, Is.EqualTo(v0.x));
            Assert.That(4u, Is.EqualTo(v0.y));
            Assert.That(7u, Is.EqualTo(v0.z));
            Assert.That(4u, Is.EqualTo(v0.w));
        
            Assert.That(9u, Is.EqualTo(v2.x));
            Assert.That(1u, Is.EqualTo(v2.y));
            Assert.That(9u, Is.EqualTo(v2.z));
        }
        {
            var v0 = new uvec4(4u, 7u, 3u, 2u);
            var v1 = new uvec3(6u, 8u, 3u);
            var v2 = v0.yzw;
            v0.yzw = v1;
            var v3 = v0.yzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4u, Is.EqualTo(v0.x));
            Assert.That(6u, Is.EqualTo(v0.y));
            Assert.That(8u, Is.EqualTo(v0.z));
            Assert.That(3u, Is.EqualTo(v0.w));
        
            Assert.That(7u, Is.EqualTo(v2.x));
            Assert.That(3u, Is.EqualTo(v2.y));
            Assert.That(2u, Is.EqualTo(v2.z));
        }
        {
            var v0 = new uvec4(8u, 9u, 7u, 2u);
            var v1 = new uvec4(3u, 0u, 4u, 6u);
            var v2 = v0.xyzw;
            v0.xyzw = v1;
            var v3 = v0.xyzw;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(3u, Is.EqualTo(v0.x));
            Assert.That(0u, Is.EqualTo(v0.y));
            Assert.That(4u, Is.EqualTo(v0.z));
            Assert.That(6u, Is.EqualTo(v0.w));
        
            Assert.That(8u, Is.EqualTo(v2.x));
            Assert.That(9u, Is.EqualTo(v2.y));
            Assert.That(7u, Is.EqualTo(v2.z));
            Assert.That(2u, Is.EqualTo(v2.w));
        }
    }

    [Test]
    public void InlineRGBA()
    {
        {
            var v0 = new uvec4(3u, 5u, 7u, 0u);
            var v1 = 3u;
            var v2 = v0.r;
            v0.r = v1;
            var v3 = v0.r;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(3u, Is.EqualTo(v0.x));
            Assert.That(5u, Is.EqualTo(v0.y));
            Assert.That(7u, Is.EqualTo(v0.z));
            Assert.That(0u, Is.EqualTo(v0.w));
        
            Assert.That(3u, Is.EqualTo(v2));
        }
        {
            var v0 = new uvec4(5u, 0u, 5u, 0u);
            var v1 = 2u;
            var v2 = v0.g;
            v0.g = v1;
            var v3 = v0.g;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(5u, Is.EqualTo(v0.x));
            Assert.That(2u, Is.EqualTo(v0.y));
            Assert.That(5u, Is.EqualTo(v0.z));
            Assert.That(0u, Is.EqualTo(v0.w));
        
            Assert.That(0u, Is.EqualTo(v2));
        }
        {
            var v0 = new uvec4(3u, 0u, 6u, 7u);
            var v1 = new uvec2(2u, 6u);
            var v2 = v0.rg;
            v0.rg = v1;
            var v3 = v0.rg;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(2u, Is.EqualTo(v0.x));
            Assert.That(6u, Is.EqualTo(v0.y));
            Assert.That(6u, Is.EqualTo(v0.z));
            Assert.That(7u, Is.EqualTo(v0.w));
        
            Assert.That(3u, Is.EqualTo(v2.x));
            Assert.That(0u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec4(3u, 5u, 2u, 8u);
            var v1 = 9u;
            var v2 = v0.b;
            v0.b = v1;
            var v3 = v0.b;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(3u, Is.EqualTo(v0.x));
            Assert.That(5u, Is.EqualTo(v0.y));
            Assert.That(9u, Is.EqualTo(v0.z));
            Assert.That(8u, Is.EqualTo(v0.w));
        
            Assert.That(2u, Is.EqualTo(v2));
        }
        {
            var v0 = new uvec4(9u, 8u, 0u, 8u);
            var v1 = new uvec2(1u, 6u);
            var v2 = v0.rb;
            v0.rb = v1;
            var v3 = v0.rb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(1u, Is.EqualTo(v0.x));
            Assert.That(8u, Is.EqualTo(v0.y));
            Assert.That(6u, Is.EqualTo(v0.z));
            Assert.That(8u, Is.EqualTo(v0.w));
        
            Assert.That(9u, Is.EqualTo(v2.x));
            Assert.That(0u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec4(7u, 9u, 3u, 6u);
            var v1 = new uvec2(1u, 7u);
            var v2 = v0.gb;
            v0.gb = v1;
            var v3 = v0.gb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(7u, Is.EqualTo(v0.x));
            Assert.That(1u, Is.EqualTo(v0.y));
            Assert.That(7u, Is.EqualTo(v0.z));
            Assert.That(6u, Is.EqualTo(v0.w));
        
            Assert.That(9u, Is.EqualTo(v2.x));
            Assert.That(3u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec4(4u, 1u, 1u, 5u);
            var v1 = new uvec3(1u, 2u, 4u);
            var v2 = v0.rgb;
            v0.rgb = v1;
            var v3 = v0.rgb;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(1u, Is.EqualTo(v0.x));
            Assert.That(2u, Is.EqualTo(v0.y));
            Assert.That(4u, Is.EqualTo(v0.z));
            Assert.That(5u, Is.EqualTo(v0.w));
        
            Assert.That(4u, Is.EqualTo(v2.x));
            Assert.That(1u, Is.EqualTo(v2.y));
            Assert.That(1u, Is.EqualTo(v2.z));
        }
        {
            var v0 = new uvec4(9u, 6u, 8u, 3u);
            var v1 = 2u;
            var v2 = v0.a;
            v0.a = v1;
            var v3 = v0.a;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(9u, Is.EqualTo(v0.x));
            Assert.That(6u, Is.EqualTo(v0.y));
            Assert.That(8u, Is.EqualTo(v0.z));
            Assert.That(2u, Is.EqualTo(v0.w));
        
            Assert.That(3u, Is.EqualTo(v2));
        }
        {
            var v0 = new uvec4(2u, 4u, 9u, 2u);
            var v1 = new uvec2(4u, 9u);
            var v2 = v0.ra;
            v0.ra = v1;
            var v3 = v0.ra;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4u, Is.EqualTo(v0.x));
            Assert.That(4u, Is.EqualTo(v0.y));
            Assert.That(9u, Is.EqualTo(v0.z));
            Assert.That(9u, Is.EqualTo(v0.w));
        
            Assert.That(2u, Is.EqualTo(v2.x));
            Assert.That(2u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec4(1u, 6u, 7u, 3u);
            var v1 = new uvec2(3u, 7u);
            var v2 = v0.ga;
            v0.ga = v1;
            var v3 = v0.ga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(1u, Is.EqualTo(v0.x));
            Assert.That(3u, Is.EqualTo(v0.y));
            Assert.That(7u, Is.EqualTo(v0.z));
            Assert.That(7u, Is.EqualTo(v0.w));
        
            Assert.That(6u, Is.EqualTo(v2.x));
            Assert.That(3u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec4(7u, 1u, 1u, 9u);
            var v1 = new uvec3(3u, 5u, 7u);
            var v2 = v0.rga;
            v0.rga = v1;
            var v3 = v0.rga;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(3u, Is.EqualTo(v0.x));
            Assert.That(5u, Is.EqualTo(v0.y));
            Assert.That(1u, Is.EqualTo(v0.z));
            Assert.That(7u, Is.EqualTo(v0.w));
        
            Assert.That(7u, Is.EqualTo(v2.x));
            Assert.That(1u, Is.EqualTo(v2.y));
            Assert.That(9u, Is.EqualTo(v2.z));
        }
        {
            var v0 = new uvec4(5u, 1u, 3u, 1u);
            var v1 = new uvec2(5u, 0u);
            var v2 = v0.ba;
            v0.ba = v1;
            var v3 = v0.ba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(5u, Is.EqualTo(v0.x));
            Assert.That(1u, Is.EqualTo(v0.y));
            Assert.That(5u, Is.EqualTo(v0.z));
            Assert.That(0u, Is.EqualTo(v0.w));
        
            Assert.That(3u, Is.EqualTo(v2.x));
            Assert.That(1u, Is.EqualTo(v2.y));
        }
        {
            var v0 = new uvec4(0u, 2u, 3u, 7u);
            var v1 = new uvec3(9u, 3u, 1u);
            var v2 = v0.rba;
            v0.rba = v1;
            var v3 = v0.rba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(9u, Is.EqualTo(v0.x));
            Assert.That(2u, Is.EqualTo(v0.y));
            Assert.That(3u, Is.EqualTo(v0.z));
            Assert.That(1u, Is.EqualTo(v0.w));
        
            Assert.That(0u, Is.EqualTo(v2.x));
            Assert.That(3u, Is.EqualTo(v2.y));
            Assert.That(7u, Is.EqualTo(v2.z));
        }
        {
            var v0 = new uvec4(4u, 7u, 6u, 6u);
            var v1 = new uvec3(6u, 4u, 5u);
            var v2 = v0.gba;
            v0.gba = v1;
            var v3 = v0.gba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(4u, Is.EqualTo(v0.x));
            Assert.That(6u, Is.EqualTo(v0.y));
            Assert.That(4u, Is.EqualTo(v0.z));
            Assert.That(5u, Is.EqualTo(v0.w));
        
            Assert.That(7u, Is.EqualTo(v2.x));
            Assert.That(6u, Is.EqualTo(v2.y));
            Assert.That(6u, Is.EqualTo(v2.z));
        }
        {
            var v0 = new uvec4(3u, 5u, 5u, 9u);
            var v1 = new uvec4(1u, 8u, 4u, 7u);
            var v2 = v0.rgba;
            v0.rgba = v1;
            var v3 = v0.rgba;
        
            Assert.That(v1, Is.EqualTo(v3));
        
            Assert.That(1u, Is.EqualTo(v0.x));
            Assert.That(8u, Is.EqualTo(v0.y));
            Assert.That(4u, Is.EqualTo(v0.z));
            Assert.That(7u, Is.EqualTo(v0.w));
        
            Assert.That(3u, Is.EqualTo(v2.x));
            Assert.That(5u, Is.EqualTo(v2.y));
            Assert.That(5u, Is.EqualTo(v2.z));
            Assert.That(9u, Is.EqualTo(v2.w));
        }
    }

}
