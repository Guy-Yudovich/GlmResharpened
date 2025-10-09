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
public class IntVec2Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new ivec2(3);
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(3, Is.EqualTo(v.y));
        }
        {
            var v = new ivec2(9, 8);
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
        }
        {
            var v = new ivec2(new ivec2(-8, 2));
            Assert.That(-8, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
        }
        {
            var v = new ivec2(new ivec3(-1, 2, -3));
            Assert.That(-1, Is.EqualTo(v.x));
            Assert.That(2, Is.EqualTo(v.y));
        }
        {
            var v = new ivec2(new ivec4(9, 1, -1, 8));
            Assert.That(9, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new ivec2(-4, -1);
        Assert.That(-4, Is.EqualTo(v[0]));
        Assert.That(-1, Is.EqualTo(v[1]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
        
        v[1] = 0;
        Assert.That(0, Is.EqualTo(v[1]));
        v[0] = 1;
        Assert.That(1, Is.EqualTo(v[0]));
        v[1] = 2;
        Assert.That(2, Is.EqualTo(v[1]));
        v[0] = 3;
        Assert.That(3, Is.EqualTo(v[0]));
        v[1] = 4;
        Assert.That(4, Is.EqualTo(v[1]));
        v[1] = 5;
        Assert.That(5, Is.EqualTo(v[1]));
        v[1] = 6;
        Assert.That(6, Is.EqualTo(v[1]));
        v[0] = 7;
        Assert.That(7, Is.EqualTo(v[0]));
        v[0] = 8;
        Assert.That(8, Is.EqualTo(v[0]));
        v[1] = 9;
        Assert.That(9, Is.EqualTo(v[1]));
        v[0] = -1;
        Assert.That(-1, Is.EqualTo(v[0]));
        v[1] = -2;
        Assert.That(-2, Is.EqualTo(v[1]));
        v[1] = -3;
        Assert.That(-3, Is.EqualTo(v[1]));
        v[0] = -4;
        Assert.That(-4, Is.EqualTo(v[0]));
        v[1] = -5;
        Assert.That(-5, Is.EqualTo(v[1]));
        v[1] = -6;
        Assert.That(-6, Is.EqualTo(v[1]));
        v[0] = -7;
        Assert.That(-7, Is.EqualTo(v[0]));
        v[1] = -8;
        Assert.That(-8, Is.EqualTo(v[1]));
        v[1] = -9;
        Assert.That(-9, Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new ivec2(-7, -9);
        var vals = v.Values;
        Assert.That(-7, Is.EqualTo(vals[0]));
        Assert.That(-9, Is.EqualTo(vals[1]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0, Is.EqualTo(ivec2.Zero.x));
        Assert.That(0, Is.EqualTo(ivec2.Zero.y));
        
        Assert.That(1, Is.EqualTo(ivec2.Ones.x));
        Assert.That(1, Is.EqualTo(ivec2.Ones.y));
        
        Assert.That(1, Is.EqualTo(ivec2.UnitX.x));
        Assert.That(0, Is.EqualTo(ivec2.UnitX.y));
        
        Assert.That(0, Is.EqualTo(ivec2.UnitY.x));
        Assert.That(1, Is.EqualTo(ivec2.UnitY.y));
        
        Assert.That(int.MaxValue, Is.EqualTo(ivec2.MaxValue.x));
        Assert.That(int.MaxValue, Is.EqualTo(ivec2.MaxValue.y));
        
        Assert.That(int.MinValue, Is.EqualTo(ivec2.MinValue.x));
        Assert.That(int.MinValue, Is.EqualTo(ivec2.MinValue.y));
    }

    [Test]
    public void Operators()
    {
        var v1 = new ivec2(-2, -8);
        var v2 = new ivec2(-2, -8);
        var v3 = new ivec2(-8, -2);
        Assert.That(v1 == new ivec2(v1));
        Assert.That(v2 == new ivec2(v2));
        Assert.That(v3 == new ivec2(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new ivec2(-2, 3);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = ivec2.Parse(s0);
        var v1 = ivec2.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = ivec2.TryParse(s0, out v0);
        var b1 = ivec2.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = ivec2.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = ivec2.TryParse("", out v0);
        Assert.That(!b0);
        b0 = ivec2.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { ivec2.Parse(null); });
        Assert.Throws<FormatException>(() => { ivec2.Parse(""); });
        Assert.Throws<FormatException>(() => { ivec2.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = ivec2.Parse(s3, "; ", NumberStyles.Number);
        var v4 = ivec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = ivec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new ivec2(-2, 3);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<ivec2>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new ivec2(2, 3);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec2(-1, -4);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec2(9, 9);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec2(-8, 1);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec2(1, -6);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec2(-7, -5);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec2(-5, 5);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec2(0, -1);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec2(-1, 0);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec2(8, -3);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new ivec2(-3, -3);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec2(3, -6);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec2(7, 2);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec2(-6, 4);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec2(7, 9);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec2(-1, -9);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec2(-4, 5);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec2(1, 1);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec2(2, 3);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec2(3, 8);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new ivec2(-5, 7);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec2(-3, -9);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec2(9, -1);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec2(6, 5);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec2(-6, 5);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec2(-9, -5);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec2(3, 7);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec2(4, 6);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec2(8, 8);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec2(2, 5);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new ivec2(-3, 3);
            var v1 = new ivec2(-9, 7);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec2(6, 8);
            var v1 = new ivec2(-1, 0);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec2(3, -2);
            var v1 = new ivec2(1, -4);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec2(9, -8);
            var v1 = new ivec2(8, 6);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec2(1, -4);
            var v1 = new ivec2(-6, -3);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec2(2, 4);
            var v1 = new ivec2(-8, -6);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec2(8, -3);
            var v1 = new ivec2(9, 8);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec2(-7, 4);
            var v1 = new ivec2(1, -3);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec2(0, 7);
            var v1 = new ivec2(4, -6);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec2(3, 9);
            var v1 = new ivec2(-9, 5);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new ivec2(-7, -5);
            var v1 = new ivec2(0, 9);
            var v2 = new ivec2(1, -8);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec2(-5, 9);
            var v1 = new ivec2(-8, -2);
            var v2 = new ivec2(0, 6);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec2(-2, 9);
            var v1 = new ivec2(4, 6);
            var v2 = new ivec2(1, -2);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec2(-8, -1);
            var v1 = new ivec2(-8, 5);
            var v2 = new ivec2(-3, -1);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec2(5, 9);
            var v1 = new ivec2(-4, -2);
            var v2 = new ivec2(-6, 8);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec2(0, 3);
            var v1 = new ivec2(3, -8);
            var v2 = new ivec2(2, -8);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec2(3, -5);
            var v1 = new ivec2(5, 4);
            var v2 = new ivec2(-9, -5);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec2(2, 3);
            var v1 = new ivec2(3, 1);
            var v2 = new ivec2(5, -1);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec2(0, -3);
            var v1 = new ivec2(-7, -1);
            var v2 = new ivec2(3, 9);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec2(0, -1);
            var v1 = new ivec2(2, 9);
            var v2 = new ivec2(3, -2);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new ivec2(2, -6);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec2(-6, 2);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec2(9, -4);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec2(-6, -4);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec2(1, -1);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec2(-2, 3);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec2(7, -5);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec2(2, -3);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec2(-8, -6);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec2(2, -8);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new ivec2(-6, -6);
            var v1 = new ivec2(0, 1);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec2(-8, 4);
            var v1 = new ivec2(3, 4);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec2(-6, 3);
            var v1 = new ivec2(-2, -8);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec2(-6, -2);
            var v1 = new ivec2(-2, -5);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec2(-8, 9);
            var v1 = new ivec2(6, -7);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec2(5, -7);
            var v1 = new ivec2(1, 6);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec2(-9, -2);
            var v1 = new ivec2(3, -3);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec2(-3, 9);
            var v1 = new ivec2(1, -4);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec2(8, 1);
            var v1 = new ivec2(1, -7);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec2(-6, 8);
            var v1 = new ivec2(4, 0);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new ivec2(8, -2);
            var v1 = new ivec2(-2, 3);
            var v2 = new ivec2(-1, -6);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec2(9, -3);
            var v1 = new ivec2(8, 6);
            var v2 = new ivec2(8, -1);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec2(-3, -9);
            var v1 = new ivec2(3, 9);
            var v2 = new ivec2(0, -1);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec2(-1, -8);
            var v1 = new ivec2(3, -7);
            var v2 = new ivec2(-6, 4);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec2(-1, -3);
            var v1 = new ivec2(7, 2);
            var v2 = new ivec2(1, 5);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec2(9, -5);
            var v1 = new ivec2(8, -8);
            var v2 = new ivec2(0, -7);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec2(5, -2);
            var v1 = new ivec2(-2, -8);
            var v2 = new ivec2(3, 0);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec2(1, 6);
            var v1 = new ivec2(-3, -3);
            var v2 = new ivec2(-5, -7);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec2(-5, -7);
            var v1 = new ivec2(7, -8);
            var v2 = new ivec2(0, 1);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec2(9, -1);
            var v1 = new ivec2(-5, 7);
            var v2 = new ivec2(-2, -7);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new ivec2(7, -1);
            var v1 = new ivec2(-4, 5);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec2(-1, -3);
            var v1 = new ivec2(6, 1);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec2(-9, -7);
            var v1 = new ivec2(-5, -2);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec2(-5, -7);
            var v1 = new ivec2(7, -1);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec2(-8, -3);
            var v1 = new ivec2(-4, 9);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec2(0, -6);
            var v1 = new ivec2(4, 0);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec2(-3, -5);
            var v1 = new ivec2(1, 8);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec2(-4, -8);
            var v1 = new ivec2(-4, 2);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec2(-8, 2);
            var v1 = new ivec2(6, 9);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec2(3, 0);
            var v1 = new ivec2(9, 2);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new ivec2(4, -8);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec2(0, -6);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec2(-6, -6);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec2(5, 0);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec2(9, -9);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec2(-4, -5);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec2(0, -4);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec2(9, 0);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec2(-9, 2);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec2(-9, 5);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(2131579210);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec2.Random(random, (-1), (3));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.25).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(1054413074);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec2.RandomUniform(random, (2), (7));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(4).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(1317757176);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec2.Random(random, (0), (5));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(443057459);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec2.RandomUniform(random, (2), (5));
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
    public void RandomUniform4()
    {
        var random = new Random(332229816);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec2.Random(random, (2), (6));
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
        var random = new Random(1359527269);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec2.RandomPoisson(random, 2.4861659347015275);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.4861659347015275).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.4861659347015275).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.4861659347015275).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.4861659347015275).Within(3.0));
    }

    [Test]
    public void RandomPoisson1()
    {
        var random = new Random(1315155224);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec2.RandomPoisson(random, 2.054361937360075);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.054361937360075).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.054361937360075).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.054361937360075).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.054361937360075).Within(3.0));
    }

    [Test]
    public void RandomPoisson2()
    {
        var random = new Random(8976815);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec2.RandomPoisson(random, 2.6935094116225415);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.6935094116225415).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.6935094116225415).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.6935094116225415).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.6935094116225415).Within(3.0));
    }

    [Test]
    public void RandomPoisson3()
    {
        var random = new Random(150237752);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec2.RandomPoisson(random, 2.0735318570274544);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.0735318570274544).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.0735318570274544).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.0735318570274544).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.0735318570274544).Within(3.0));
    }

    [Test]
    public void RandomPoisson4()
    {
        var random = new Random(1640268820);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec2.RandomPoisson(random, 2.373923306294681);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.373923306294681).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.373923306294681).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.373923306294681).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.373923306294681).Within(3.0));
    }

}
