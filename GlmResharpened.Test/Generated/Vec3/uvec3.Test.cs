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

namespace GlmResharpenedTest.Generated.Vec3;

[TestFixture]
public class UintVec3Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new uvec3(9u);
            Assert.That(9u, Is.EqualTo(v.x));
            Assert.That(9u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
        {
            var v = new uvec3(1u, 5u, 0u);
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var v = new uvec3(new uvec2(4u, 0u));
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(0u, Is.EqualTo(v.y));
            Assert.That(0u, Is.EqualTo(v.z));
        }
        {
            var v = new uvec3(new uvec3(7u, 4u, 3u));
            Assert.That(7u, Is.EqualTo(v.x));
            Assert.That(4u, Is.EqualTo(v.y));
            Assert.That(3u, Is.EqualTo(v.z));
        }
        {
            var v = new uvec3(new uvec4(4u, 3u, 9u, 0u));
            Assert.That(4u, Is.EqualTo(v.x));
            Assert.That(3u, Is.EqualTo(v.y));
            Assert.That(9u, Is.EqualTo(v.z));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new uvec3(8u, 6u, 4u);
        Assert.That(8u, Is.EqualTo(v[0]));
        Assert.That(6u, Is.EqualTo(v[1]));
        Assert.That(4u, Is.EqualTo(v[2]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0u; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0u; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0u; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0u; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0u; } );
        
        v[2] = 0u;
        Assert.That(0u, Is.EqualTo(v[2]));
        v[0] = 1u;
        Assert.That(1u, Is.EqualTo(v[0]));
        v[1] = 2u;
        Assert.That(2u, Is.EqualTo(v[1]));
        v[0] = 3u;
        Assert.That(3u, Is.EqualTo(v[0]));
        v[0] = 4u;
        Assert.That(4u, Is.EqualTo(v[0]));
        v[2] = 5u;
        Assert.That(5u, Is.EqualTo(v[2]));
        v[2] = 6u;
        Assert.That(6u, Is.EqualTo(v[2]));
        v[0] = 7u;
        Assert.That(7u, Is.EqualTo(v[0]));
        v[1] = 8u;
        Assert.That(8u, Is.EqualTo(v[1]));
        v[2] = 9u;
        Assert.That(9u, Is.EqualTo(v[2]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new uvec3(0u, 3u, 6u);
        var vals = v.Values;
        Assert.That(0u, Is.EqualTo(vals[0]));
        Assert.That(3u, Is.EqualTo(vals[1]));
        Assert.That(6u, Is.EqualTo(vals[2]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0u, Is.EqualTo(uvec3.Zero.x));
        Assert.That(0u, Is.EqualTo(uvec3.Zero.y));
        Assert.That(0u, Is.EqualTo(uvec3.Zero.z));
        
        Assert.That(1u, Is.EqualTo(uvec3.Ones.x));
        Assert.That(1u, Is.EqualTo(uvec3.Ones.y));
        Assert.That(1u, Is.EqualTo(uvec3.Ones.z));
        
        Assert.That(1u, Is.EqualTo(uvec3.UnitX.x));
        Assert.That(0u, Is.EqualTo(uvec3.UnitX.y));
        Assert.That(0u, Is.EqualTo(uvec3.UnitX.z));
        
        Assert.That(0u, Is.EqualTo(uvec3.UnitY.x));
        Assert.That(1u, Is.EqualTo(uvec3.UnitY.y));
        Assert.That(0u, Is.EqualTo(uvec3.UnitY.z));
        
        Assert.That(0u, Is.EqualTo(uvec3.UnitZ.x));
        Assert.That(0u, Is.EqualTo(uvec3.UnitZ.y));
        Assert.That(1u, Is.EqualTo(uvec3.UnitZ.z));
        
        Assert.That(uint.MaxValue, Is.EqualTo(uvec3.MaxValue.x));
        Assert.That(uint.MaxValue, Is.EqualTo(uvec3.MaxValue.y));
        Assert.That(uint.MaxValue, Is.EqualTo(uvec3.MaxValue.z));
        
        Assert.That(uint.MinValue, Is.EqualTo(uvec3.MinValue.x));
        Assert.That(uint.MinValue, Is.EqualTo(uvec3.MinValue.y));
        Assert.That(uint.MinValue, Is.EqualTo(uvec3.MinValue.z));
    }

    [Test]
    public void Operators()
    {
        var v1 = new uvec3(0u, 9u, 7u);
        var v2 = new uvec3(0u, 9u, 7u);
        var v3 = new uvec3(7u, 9u, 0u);
        Assert.That(v1 == new uvec3(v1));
        Assert.That(v2 == new uvec3(v2));
        Assert.That(v3 == new uvec3(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new uvec3(3u, 4u, 8u);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = uvec3.Parse(s0);
        var v1 = uvec3.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = uvec3.TryParse(s0, out v0);
        var b1 = uvec3.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = uvec3.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = uvec3.TryParse("", out v0);
        Assert.That(!b0);
        b0 = uvec3.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { uvec3.Parse(null); });
        Assert.Throws<FormatException>(() => { uvec3.Parse(""); });
        Assert.Throws<FormatException>(() => { uvec3.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = uvec3.Parse(s3, "; ", NumberStyles.Number);
        var v4 = uvec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = uvec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new uvec3(7u, 9u, 8u);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<uvec3>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new uvec3(6u, 4u, 7u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec3(9u, 9u, 2u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec3(5u, 7u, 9u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec3(0u, 4u, 7u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec3(2u, 9u, 3u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec3(2u, 5u, 1u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec3(1u, 8u, 8u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec3(8u, 8u, 2u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec3(6u, 5u, 6u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec3(1u, 3u, 3u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new uvec3(1u, 7u, 4u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec3(8u, 2u, 3u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec3(4u, 4u, 6u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec3(9u, 2u, 2u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec3(0u, 5u, 4u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec3(3u, 8u, 2u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec3(1u, 3u, 0u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec3(0u, 6u, 1u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec3(0u, 2u, 2u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec3(5u, 2u, 2u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new uvec3(5u, 2u, 2u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec3(9u, 1u, 5u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec3(2u, 7u, 7u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec3(0u, 7u, 6u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec3(4u, 9u, 1u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec3(9u, 3u, 7u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec3(3u, 5u, 9u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec3(1u, 5u, 3u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec3(7u, 4u, 8u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec3(2u, 3u, 6u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new uvec3(7u, 5u, 5u);
            var v1 = new uvec3(2u, 1u, 5u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec3(5u, 6u, 5u);
            var v1 = new uvec3(9u, 4u, 9u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec3(4u, 9u, 1u);
            var v1 = new uvec3(5u, 8u, 6u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec3(5u, 9u, 7u);
            var v1 = new uvec3(7u, 5u, 5u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec3(2u, 7u, 0u);
            var v1 = new uvec3(2u, 4u, 9u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec3(8u, 2u, 5u);
            var v1 = new uvec3(0u, 6u, 4u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec3(6u, 4u, 8u);
            var v1 = new uvec3(8u, 5u, 4u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec3(7u, 4u, 0u);
            var v1 = new uvec3(6u, 3u, 5u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec3(3u, 3u, 9u);
            var v1 = new uvec3(0u, 1u, 3u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec3(1u, 0u, 0u);
            var v1 = new uvec3(0u, 9u, 4u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new uvec3(9u, 5u, 2u);
            var v1 = new uvec3(9u, 4u, 2u);
            var v2 = new uvec3(5u, 6u, 2u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec3(5u, 2u, 5u);
            var v1 = new uvec3(1u, 9u, 3u);
            var v2 = new uvec3(3u, 4u, 4u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec3(7u, 2u, 6u);
            var v1 = new uvec3(8u, 3u, 3u);
            var v2 = new uvec3(2u, 7u, 2u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec3(1u, 6u, 5u);
            var v1 = new uvec3(8u, 6u, 9u);
            var v2 = new uvec3(1u, 0u, 8u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec3(3u, 0u, 9u);
            var v1 = new uvec3(2u, 7u, 8u);
            var v2 = new uvec3(4u, 4u, 4u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec3(9u, 1u, 3u);
            var v1 = new uvec3(8u, 0u, 9u);
            var v2 = new uvec3(8u, 4u, 8u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec3(8u, 0u, 1u);
            var v1 = new uvec3(8u, 6u, 6u);
            var v2 = new uvec3(9u, 4u, 9u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec3(6u, 7u, 6u);
            var v1 = new uvec3(6u, 0u, 8u);
            var v2 = new uvec3(4u, 9u, 3u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec3(5u, 4u, 4u);
            var v1 = new uvec3(8u, 4u, 8u);
            var v2 = new uvec3(9u, 3u, 5u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec3(9u, 2u, 6u);
            var v1 = new uvec3(5u, 0u, 1u);
            var v2 = new uvec3(1u, 2u, 9u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new uvec3(6u, 9u, 1u);
            var v1 = new uvec3(4u, 5u, 7u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec3(1u, 9u, 5u);
            var v1 = new uvec3(4u, 6u, 7u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec3(1u, 6u, 3u);
            var v1 = new uvec3(5u, 6u, 7u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec3(9u, 7u, 2u);
            var v1 = new uvec3(6u, 1u, 2u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec3(0u, 0u, 1u);
            var v1 = new uvec3(2u, 3u, 5u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec3(0u, 7u, 4u);
            var v1 = new uvec3(1u, 6u, 7u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec3(8u, 9u, 2u);
            var v1 = new uvec3(9u, 6u, 1u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec3(2u, 8u, 9u);
            var v1 = new uvec3(2u, 0u, 4u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec3(6u, 6u, 5u);
            var v1 = new uvec3(4u, 3u, 4u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec3(1u, 0u, 8u);
            var v1 = new uvec3(8u, 3u, 5u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new uvec3(5u, 7u, 6u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec3(9u, 6u, 5u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec3(2u, 8u, 1u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec3(9u, 7u, 2u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec3(1u, 3u, 3u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec3(7u, 7u, 0u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec3(1u, 8u, 4u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec3(9u, 1u, 8u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec3(0u, 7u, 4u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec3(0u, 9u, 0u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void InvariantCrossDot()
    {
        {
            var v0 = new uvec3(0u, 0u, 4u);
            var v1 = new uvec3(7u, 6u, 2u);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new uvec3(1u, 5u, 2u);
            var v1 = new uvec3(9u, 8u, 6u);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new uvec3(6u, 2u, 7u);
            var v1 = new uvec3(1u, 7u, 6u);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new uvec3(1u, 0u, 1u);
            var v1 = new uvec3(7u, 5u, 7u);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new uvec3(1u, 1u, 9u);
            var v1 = new uvec3(5u, 2u, 6u);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new uvec3(6u, 4u, 1u);
            var v1 = new uvec3(8u, 1u, 6u);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new uvec3(7u, 6u, 6u);
            var v1 = new uvec3(7u, 5u, 9u);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new uvec3(5u, 1u, 5u);
            var v1 = new uvec3(1u, 4u, 4u);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new uvec3(9u, 4u, 3u);
            var v1 = new uvec3(0u, 1u, 3u);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new uvec3(5u, 2u, 4u);
            var v1 = new uvec3(6u, 6u, 4u);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(1667274834);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec3.Random(random, (3), (7));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(4.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.25).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(482438290);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec3.RandomUniform(random, (4), (6));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(4.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.25).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(529719471);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec3.Random(random, (4), (8));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(5.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(5.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(5.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.25).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(1804544159);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec3.RandomUniform(random, (3), (6));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(4).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.6666666666666666).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(2045110800);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec3.Random(random, (4), (7));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.6666666666666666).Within(3.0));
    }

    [Test]
    public void RandomPoisson0()
    {
        var random = new Random(1109298885);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec3.RandomPoisson(random, 3.469729084973097);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.469729084973097).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.469729084973097).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3.469729084973097).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.469729084973097).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.469729084973097).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(3.469729084973097).Within(3.0));
    }

    [Test]
    public void RandomPoisson1()
    {
        var random = new Random(660480966);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec3.RandomPoisson(random, 2.6039360357001127);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.6039360357001127).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.6039360357001127).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2.6039360357001127).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.6039360357001127).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.6039360357001127).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.6039360357001127).Within(3.0));
    }

    [Test]
    public void RandomPoisson2()
    {
        var random = new Random(1403740498);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec3.RandomPoisson(random, 0.859796258788461);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.859796258788461).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.859796258788461).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.859796258788461).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.859796258788461).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.859796258788461).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.859796258788461).Within(3.0));
    }

    [Test]
    public void RandomPoisson3()
    {
        var random = new Random(1591289894);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec3.RandomPoisson(random, 1.918595698857026);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.918595698857026).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.918595698857026).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.918595698857026).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.918595698857026).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.918595698857026).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.918595698857026).Within(3.0));
    }

    [Test]
    public void RandomPoisson4()
    {
        var random = new Random(1360826679);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec3.RandomPoisson(random, 0.6328894450016737);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.6328894450016737).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.6328894450016737).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.6328894450016737).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6328894450016737).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6328894450016737).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.6328894450016737).Within(3.0));
    }

}
