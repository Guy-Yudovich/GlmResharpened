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

namespace GlmResharpenedTest.Generated.Vec4;

[TestFixture]
public class UintVec4Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new uvec4(9u);
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
            Assert.That(9u, Is.EqualTo(v.w));
        }
        {
            var v = new uvec4(3u, 0u, 1u, 5u);
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(1u, Is.EqualTo(v.z));
            Assert.That(5u, Is.EqualTo(v.w));
        }
        {
            var v = new uvec4(new uvec2(9u, 4u));
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var v = new uvec4(new uvec3(3u, 3u, 7u));
            Assert.That(3u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(7u, Is.EqualTo(v.z));
            Assert.That(0u, Is.EqualTo(v.w));
        }
        {
            var v = new uvec4(new uvec4(1u, 6u, 0u, 1u));
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(6u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
            Assert.That(1u, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new uvec4(1u, 5u, 4u, 1u);
        Assert.That(1u, Is.EqualTo(v[0]));
        Assert.That(5u, Is.EqualTo(v[1]));
        Assert.That(4u, Is.EqualTo(v[2]));
        Assert.That(1u, Is.EqualTo(v[3]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0u; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0u; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0u; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0u; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0u; } );
        
        v[1] = 0u;
        Assert.That(0u, Is.EqualTo(v[1]));
        v[3] = 1u;
        Assert.That(1u, Is.EqualTo(v[3]));
        v[0] = 2u;
        Assert.That(2u, Is.EqualTo(v[0]));
        v[2] = 3u;
        Assert.That(3u, Is.EqualTo(v[2]));
        v[2] = 4u;
        Assert.That(4u, Is.EqualTo(v[2]));
        v[0] = 5u;
        Assert.That(5u, Is.EqualTo(v[0]));
        v[1] = 6u;
        Assert.That(6u, Is.EqualTo(v[1]));
        v[3] = 7u;
        Assert.That(7u, Is.EqualTo(v[3]));
        v[3] = 8u;
        Assert.That(8u, Is.EqualTo(v[3]));
        v[2] = 9u;
        Assert.That(9u, Is.EqualTo(v[2]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new uvec4(0u, 1u, 4u, 7u);
        var vals = v.Values;
        Assert.That(0u, Is.EqualTo(vals[0]));
        Assert.That(1u, Is.EqualTo(vals[1]));
        Assert.That(4u, Is.EqualTo(vals[2]));
        Assert.That(7u, Is.EqualTo(vals[3]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0u, Is.EqualTo(uvec4.Zero.x));
        Assert.That(0u, Is.EqualTo(uvec4.Zero.y));
        Assert.That(0u, Is.EqualTo(uvec4.Zero.z));
        Assert.That(0u, Is.EqualTo(uvec4.Zero.w));
        
        Assert.That(1u, Is.EqualTo(uvec4.Ones.x));
        Assert.That(1u, Is.EqualTo(uvec4.Ones.y));
        Assert.That(1u, Is.EqualTo(uvec4.Ones.z));
        Assert.That(1u, Is.EqualTo(uvec4.Ones.w));
        
        Assert.That(1u, Is.EqualTo(uvec4.UnitX.x));
        Assert.That(0u, Is.EqualTo(uvec4.UnitX.y));
        Assert.That(0u, Is.EqualTo(uvec4.UnitX.z));
        Assert.That(0u, Is.EqualTo(uvec4.UnitX.w));
        
        Assert.That(0u, Is.EqualTo(uvec4.UnitY.x));
        Assert.That(1u, Is.EqualTo(uvec4.UnitY.y));
        Assert.That(0u, Is.EqualTo(uvec4.UnitY.z));
        Assert.That(0u, Is.EqualTo(uvec4.UnitY.w));
        
        Assert.That(0u, Is.EqualTo(uvec4.UnitZ.x));
        Assert.That(0u, Is.EqualTo(uvec4.UnitZ.y));
        Assert.That(1u, Is.EqualTo(uvec4.UnitZ.z));
        Assert.That(0u, Is.EqualTo(uvec4.UnitZ.w));
        
        Assert.That(0u, Is.EqualTo(uvec4.UnitW.x));
        Assert.That(0u, Is.EqualTo(uvec4.UnitW.y));
        Assert.That(0u, Is.EqualTo(uvec4.UnitW.z));
        Assert.That(1u, Is.EqualTo(uvec4.UnitW.w));
        
        Assert.That(uint.MaxValue, Is.EqualTo(uvec4.MaxValue.x));
        Assert.That(uint.MaxValue, Is.EqualTo(uvec4.MaxValue.y));
        Assert.That(uint.MaxValue, Is.EqualTo(uvec4.MaxValue.z));
        Assert.That(uint.MaxValue, Is.EqualTo(uvec4.MaxValue.w));
        
        Assert.That(uint.MinValue, Is.EqualTo(uvec4.MinValue.x));
        Assert.That(uint.MinValue, Is.EqualTo(uvec4.MinValue.y));
        Assert.That(uint.MinValue, Is.EqualTo(uvec4.MinValue.z));
        Assert.That(uint.MinValue, Is.EqualTo(uvec4.MinValue.w));
    }

    [Test]
    public void Operators()
    {
        var v1 = new uvec4(4u, 5u, 3u, 7u);
        var v2 = new uvec4(4u, 5u, 3u, 7u);
        var v3 = new uvec4(7u, 3u, 5u, 4u);
        Assert.That(v1 == new uvec4(v1));
        Assert.That(v2 == new uvec4(v2));
        Assert.That(v3 == new uvec4(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new uvec4(7u, 5u, 9u, 7u);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = uvec4.Parse(s0);
        var v1 = uvec4.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = uvec4.TryParse(s0, out v0);
        var b1 = uvec4.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = uvec4.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = uvec4.TryParse("", out v0);
        Assert.That(!b0);
        b0 = uvec4.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { uvec4.Parse(null); });
        Assert.Throws<FormatException>(() => { uvec4.Parse(""); });
        Assert.Throws<FormatException>(() => { uvec4.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = uvec4.Parse(s3, "; ", NumberStyles.Number);
        var v4 = uvec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = uvec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new uvec4(5u, 4u, 2u, 6u);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<uvec4>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new uvec4(7u, 6u, 0u, 2u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec4(5u, 1u, 9u, 5u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec4(9u, 5u, 6u, 2u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec4(8u, 3u, 1u, 0u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec4(0u, 5u, 6u, 3u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec4(4u, 6u, 5u, 1u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec4(7u, 2u, 4u, 6u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec4(7u, 4u, 4u, 8u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec4(2u, 6u, 4u, 0u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec4(8u, 6u, 3u, 0u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new uvec4(2u, 3u, 7u, 4u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec4(4u, 5u, 9u, 7u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec4(6u, 3u, 2u, 5u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec4(7u, 4u, 2u, 3u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec4(8u, 6u, 5u, 2u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec4(3u, 9u, 5u, 0u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec4(1u, 4u, 4u, 9u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec4(2u, 1u, 4u, 2u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec4(9u, 1u, 9u, 1u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec4(1u, 9u, 1u, 2u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new uvec4(4u, 1u, 8u, 3u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec4(7u, 2u, 1u, 2u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec4(8u, 1u, 2u, 8u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec4(3u, 5u, 0u, 9u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec4(0u, 0u, 2u, 0u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec4(2u, 5u, 3u, 8u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec4(7u, 5u, 7u, 8u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec4(0u, 9u, 2u, 9u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec4(5u, 1u, 0u, 1u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec4(3u, 2u, 7u, 0u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new uvec4(3u, 3u, 1u, 0u);
            var v1 = new uvec4(1u, 3u, 9u, 2u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec4(5u, 4u, 3u, 6u);
            var v1 = new uvec4(5u, 6u, 0u, 6u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec4(1u, 2u, 1u, 9u);
            var v1 = new uvec4(9u, 4u, 2u, 6u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec4(9u, 9u, 9u, 2u);
            var v1 = new uvec4(2u, 6u, 5u, 4u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec4(3u, 8u, 8u, 5u);
            var v1 = new uvec4(4u, 4u, 2u, 7u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec4(8u, 9u, 5u, 1u);
            var v1 = new uvec4(0u, 2u, 7u, 3u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec4(3u, 1u, 0u, 7u);
            var v1 = new uvec4(9u, 3u, 2u, 8u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec4(1u, 4u, 1u, 1u);
            var v1 = new uvec4(4u, 7u, 0u, 9u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec4(9u, 8u, 3u, 6u);
            var v1 = new uvec4(8u, 4u, 1u, 6u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec4(9u, 3u, 1u, 9u);
            var v1 = new uvec4(8u, 1u, 5u, 6u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new uvec4(3u, 2u, 0u, 1u);
            var v1 = new uvec4(5u, 8u, 8u, 6u);
            var v2 = new uvec4(2u, 6u, 7u, 9u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec4(4u, 8u, 5u, 0u);
            var v1 = new uvec4(1u, 9u, 0u, 2u);
            var v2 = new uvec4(4u, 8u, 1u, 1u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec4(9u, 6u, 8u, 6u);
            var v1 = new uvec4(2u, 7u, 1u, 4u);
            var v2 = new uvec4(4u, 6u, 0u, 7u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec4(3u, 7u, 7u, 5u);
            var v1 = new uvec4(8u, 6u, 0u, 4u);
            var v2 = new uvec4(4u, 1u, 9u, 6u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec4(6u, 8u, 2u, 8u);
            var v1 = new uvec4(8u, 1u, 6u, 5u);
            var v2 = new uvec4(0u, 9u, 1u, 9u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec4(9u, 1u, 3u, 4u);
            var v1 = new uvec4(4u, 2u, 5u, 7u);
            var v2 = new uvec4(7u, 8u, 6u, 4u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec4(2u, 4u, 3u, 8u);
            var v1 = new uvec4(7u, 7u, 6u, 8u);
            var v2 = new uvec4(6u, 2u, 9u, 4u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec4(4u, 3u, 6u, 2u);
            var v1 = new uvec4(9u, 5u, 6u, 4u);
            var v2 = new uvec4(5u, 7u, 5u, 6u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec4(2u, 5u, 0u, 2u);
            var v1 = new uvec4(6u, 2u, 8u, 8u);
            var v2 = new uvec4(1u, 8u, 6u, 3u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec4(7u, 8u, 8u, 3u);
            var v1 = new uvec4(2u, 3u, 2u, 6u);
            var v2 = new uvec4(1u, 9u, 0u, 1u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new uvec4(6u, 9u, 1u, 2u);
            var v1 = new uvec4(1u, 4u, 1u, 7u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec4(9u, 8u, 3u, 3u);
            var v1 = new uvec4(3u, 6u, 8u, 6u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec4(4u, 2u, 0u, 1u);
            var v1 = new uvec4(9u, 1u, 0u, 3u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec4(2u, 6u, 9u, 7u);
            var v1 = new uvec4(8u, 3u, 8u, 7u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec4(8u, 0u, 7u, 8u);
            var v1 = new uvec4(0u, 0u, 4u, 6u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec4(5u, 8u, 2u, 7u);
            var v1 = new uvec4(3u, 5u, 1u, 4u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec4(1u, 7u, 0u, 9u);
            var v1 = new uvec4(4u, 3u, 8u, 5u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec4(8u, 8u, 9u, 4u);
            var v1 = new uvec4(4u, 3u, 8u, 6u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec4(0u, 5u, 4u, 3u);
            var v1 = new uvec4(8u, 9u, 6u, 4u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec4(8u, 3u, 5u, 0u);
            var v1 = new uvec4(9u, 3u, 9u, 7u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new uvec4(1u, 6u, 2u, 9u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec4(2u, 0u, 2u, 0u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec4(3u, 1u, 4u, 7u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec4(7u, 3u, 6u, 6u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec4(3u, 3u, 2u, 6u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec4(8u, 0u, 4u, 8u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec4(3u, 2u, 5u, 1u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec4(2u, 3u, 1u, 2u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec4(8u, 1u, 2u, 6u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec4(3u, 8u, 9u, 9u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(667440179);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec4.Random(random, (1), (4));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(2).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.6666666666666666).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(270041090);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec4.RandomUniform(random, (4), (8));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(5.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(5.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(5.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(5.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.25).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(1227854467);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec4.Random(random, (1), (5));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(2.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.25).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(1235908245);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec4.RandomUniform(random, (3), (5));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(3.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.25).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(2073117610);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec4.Random(random, (2), (6));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(3.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.25).Within(3.0));
    }

    [Test]
    public void RandomPoisson0()
    {
        var random = new Random(2055364191);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec4.RandomPoisson(random, 0.9687302720121715);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.9687302720121715).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.9687302720121715).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.9687302720121715).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0.9687302720121715).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.9687302720121715).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.9687302720121715).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.9687302720121715).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.9687302720121715).Within(3.0));
    }

    [Test]
    public void RandomPoisson1()
    {
        var random = new Random(501452354);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec4.RandomPoisson(random, 2.250150249688956);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.250150249688956).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.250150249688956).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2.250150249688956).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(2.250150249688956).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.250150249688956).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.250150249688956).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.250150249688956).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(2.250150249688956).Within(3.0));
    }

    [Test]
    public void RandomPoisson2()
    {
        var random = new Random(226749729);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec4.RandomPoisson(random, 1.399409582791575);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.399409582791575).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.399409582791575).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.399409582791575).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.399409582791575).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.399409582791575).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.399409582791575).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.399409582791575).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.399409582791575).Within(3.0));
    }

    [Test]
    public void RandomPoisson3()
    {
        var random = new Random(1788431559);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec4.RandomPoisson(random, 3.4448384996246726);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.4448384996246726).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.4448384996246726).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3.4448384996246726).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(3.4448384996246726).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.4448384996246726).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.4448384996246726).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(3.4448384996246726).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(3.4448384996246726).Within(3.0));
    }

    [Test]
    public void RandomPoisson4()
    {
        var random = new Random(1434590043);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec4.RandomPoisson(random, 2.781974251513357);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.781974251513357).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.781974251513357).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2.781974251513357).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(2.781974251513357).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.781974251513357).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.781974251513357).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.781974251513357).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(2.781974251513357).Within(3.0));
    }

}
