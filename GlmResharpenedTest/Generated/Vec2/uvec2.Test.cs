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

namespace GlmResharpenedTest.Generated.Vec2;

[TestFixture]
public class UintVec2Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new uvec2(2u);
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
        }
        {
            var v = new uvec2(2u, 5u);
            Assert.That(2u, Is.EqualTo(v.x));
            Assert.That(5u, Is.EqualTo(v.y));
        }
        {
            var v = new uvec2(new uvec2(8u, 2u));
            Assert.That(8u, Is.EqualTo(v.x));
            Assert.That(2u, Is.EqualTo(v.y));
        }
        {
            var v = new uvec2(new uvec3(1u, 7u, 3u));
            Assert.That(1u, Is.EqualTo(v.x));
            Assert.That(7u, Is.EqualTo(v.y));
        }
        {
            var v = new uvec2(new uvec4(6u, 1u, 0u, 4u));
            Assert.That(6u, Is.EqualTo(v.x));
            Assert.That(1u, Is.EqualTo(v.y));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new uvec2(7u, 2u);
        Assert.That(7u, Is.EqualTo(v[0]));
        Assert.That(2u, Is.EqualTo(v[1]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0u; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0u; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0u; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0u; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0u; } );
        
        v[1] = 0u;
        Assert.That(0u, Is.EqualTo(v[1]));
        v[0] = 1u;
        Assert.That(1u, Is.EqualTo(v[0]));
        v[0] = 2u;
        Assert.That(2u, Is.EqualTo(v[0]));
        v[0] = 3u;
        Assert.That(3u, Is.EqualTo(v[0]));
        v[1] = 4u;
        Assert.That(4u, Is.EqualTo(v[1]));
        v[1] = 5u;
        Assert.That(5u, Is.EqualTo(v[1]));
        v[1] = 6u;
        Assert.That(6u, Is.EqualTo(v[1]));
        v[1] = 7u;
        Assert.That(7u, Is.EqualTo(v[1]));
        v[1] = 8u;
        Assert.That(8u, Is.EqualTo(v[1]));
        v[1] = 9u;
        Assert.That(9u, Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new uvec2(4u, 1u);
        var vals = v.Values;
        Assert.That(4u, Is.EqualTo(vals[0]));
        Assert.That(1u, Is.EqualTo(vals[1]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0u, Is.EqualTo(uvec2.Zero.x));
        Assert.That(0u, Is.EqualTo(uvec2.Zero.y));
        
        Assert.That(1u, Is.EqualTo(uvec2.Ones.x));
        Assert.That(1u, Is.EqualTo(uvec2.Ones.y));
        
        Assert.That(1u, Is.EqualTo(uvec2.UnitX.x));
        Assert.That(0u, Is.EqualTo(uvec2.UnitX.y));
        
        Assert.That(0u, Is.EqualTo(uvec2.UnitY.x));
        Assert.That(1u, Is.EqualTo(uvec2.UnitY.y));
        
        Assert.That(uint.MaxValue, Is.EqualTo(uvec2.MaxValue.x));
        Assert.That(uint.MaxValue, Is.EqualTo(uvec2.MaxValue.y));
        
        Assert.That(uint.MinValue, Is.EqualTo(uvec2.MinValue.x));
        Assert.That(uint.MinValue, Is.EqualTo(uvec2.MinValue.y));
    }

    [Test]
    public void Operators()
    {
        var v1 = new uvec2(5u, 4u);
        var v2 = new uvec2(5u, 4u);
        var v3 = new uvec2(4u, 5u);
        Assert.That(v1 == new uvec2(v1));
        Assert.That(v2 == new uvec2(v2));
        Assert.That(v3 == new uvec2(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new uvec2(6u, 4u);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = uvec2.Parse(s0);
        var v1 = uvec2.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = uvec2.TryParse(s0, out v0);
        var b1 = uvec2.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = uvec2.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = uvec2.TryParse("", out v0);
        Assert.That(!b0);
        b0 = uvec2.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { uvec2.Parse(null); });
        Assert.Throws<FormatException>(() => { uvec2.Parse(""); });
        Assert.Throws<FormatException>(() => { uvec2.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = uvec2.Parse(s3, "; ", NumberStyles.Number);
        var v4 = uvec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = uvec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new uvec2(6u, 5u);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<uvec2>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new uvec2(3u, 4u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec2(5u, 2u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec2(6u, 9u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec2(5u, 2u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec2(3u, 5u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec2(5u, 2u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec2(6u, 6u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec2(6u, 8u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec2(5u, 3u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new uvec2(3u, 9u);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new uvec2(4u, 7u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec2(8u, 2u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec2(7u, 8u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec2(5u, 6u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec2(0u, 6u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec2(3u, 4u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec2(2u, 8u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec2(5u, 7u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec2(2u, 7u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new uvec2(1u, 3u);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new uvec2(2u, 7u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec2(7u, 3u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec2(2u, 0u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec2(7u, 0u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec2(9u, 5u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec2(4u, 7u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec2(8u, 3u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec2(8u, 0u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec2(9u, 2u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new uvec2(1u, 1u);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new uvec2(8u, 9u);
            var v1 = new uvec2(2u, 5u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec2(1u, 3u);
            var v1 = new uvec2(5u, 6u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec2(8u, 6u);
            var v1 = new uvec2(2u, 2u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec2(7u, 5u);
            var v1 = new uvec2(5u, 0u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec2(6u, 5u);
            var v1 = new uvec2(6u, 2u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec2(0u, 3u);
            var v1 = new uvec2(2u, 4u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec2(2u, 9u);
            var v1 = new uvec2(6u, 1u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec2(3u, 1u);
            var v1 = new uvec2(8u, 1u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec2(7u, 8u);
            var v1 = new uvec2(5u, 6u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new uvec2(8u, 8u);
            var v1 = new uvec2(2u, 5u);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new uvec2(2u, 3u);
            var v1 = new uvec2(6u, 4u);
            var v2 = new uvec2(4u, 6u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec2(0u, 3u);
            var v1 = new uvec2(9u, 5u);
            var v2 = new uvec2(7u, 7u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec2(3u, 9u);
            var v1 = new uvec2(9u, 5u);
            var v2 = new uvec2(7u, 5u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec2(2u, 7u);
            var v1 = new uvec2(3u, 2u);
            var v2 = new uvec2(5u, 9u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec2(8u, 6u);
            var v1 = new uvec2(9u, 2u);
            var v2 = new uvec2(9u, 0u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec2(4u, 8u);
            var v1 = new uvec2(7u, 4u);
            var v2 = new uvec2(8u, 1u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec2(1u, 4u);
            var v1 = new uvec2(5u, 7u);
            var v2 = new uvec2(9u, 5u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec2(9u, 8u);
            var v1 = new uvec2(3u, 1u);
            var v2 = new uvec2(2u, 5u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec2(8u, 5u);
            var v1 = new uvec2(4u, 5u);
            var v2 = new uvec2(0u, 0u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new uvec2(6u, 9u);
            var v1 = new uvec2(8u, 7u);
            var v2 = new uvec2(6u, 7u);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new uvec2(1u, 8u);
            var v1 = new uvec2(5u, 5u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec2(6u, 7u);
            var v1 = new uvec2(1u, 3u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec2(5u, 7u);
            var v1 = new uvec2(7u, 2u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec2(4u, 8u);
            var v1 = new uvec2(2u, 5u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec2(1u, 0u);
            var v1 = new uvec2(4u, 9u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec2(8u, 4u);
            var v1 = new uvec2(7u, 2u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec2(4u, 9u);
            var v1 = new uvec2(3u, 3u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec2(6u, 0u);
            var v1 = new uvec2(9u, 4u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec2(6u, 5u);
            var v1 = new uvec2(5u, 2u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new uvec2(5u, 8u);
            var v1 = new uvec2(6u, 9u);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new uvec2(4u, 6u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec2(5u, 2u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec2(7u, 4u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec2(0u, 5u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec2(1u, 5u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec2(5u, 3u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec2(3u, 0u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec2(7u, 1u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec2(7u, 4u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new uvec2(2u, 4u);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(1789913422);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec2.Random(random, (1), (5));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.25).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(1801160518);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec2.RandomUniform(random, (2), (5));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6666666666666666).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(1013131864);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec2.Random(random, (4), (7));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6666666666666666).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(2127912999);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec2.RandomUniform(random, (0), (3));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6666666666666666).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(103174345);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec2.Random(random, (2), (6));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.25).Within(3.0));
    }

    [Test]
    public void RandomPoisson0()
    {
        var random = new Random(1450124609);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec2.RandomPoisson(random, 2.0432259880673262);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.0432259880673262).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.0432259880673262).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.0432259880673262).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.0432259880673262).Within(3.0));
    }

    [Test]
    public void RandomPoisson1()
    {
        var random = new Random(135127503);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec2.RandomPoisson(random, 1.1654277889362665);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.1654277889362665).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.1654277889362665).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.1654277889362665).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.1654277889362665).Within(3.0));
    }

    [Test]
    public void RandomPoisson2()
    {
        var random = new Random(843053100);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec2.RandomPoisson(random, 1.2744107524745216);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.2744107524745216).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.2744107524745216).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.2744107524745216).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.2744107524745216).Within(3.0));
    }

    [Test]
    public void RandomPoisson3()
    {
        var random = new Random(931914830);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec2.RandomPoisson(random, 2.8644152634611424);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.8644152634611424).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.8644152634611424).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.8644152634611424).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.8644152634611424).Within(3.0));
    }

    [Test]
    public void RandomPoisson4()
    {
        var random = new Random(1159931210);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = uvec2.RandomPoisson(random, 3.4727704725101454);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.4727704725101454).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.4727704725101454).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.4727704725101454).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.4727704725101454).Within(3.0));
    }

}
