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
public class LongVec2Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new lvec2(6L);
            Assert.That(6L, Is.EqualTo(v.x));
            Assert.That(6L, Is.EqualTo(v.y));
        }
        {
            var v = new lvec2(-9L, 4L);
            Assert.That(-9L, Is.EqualTo(v.x));
            Assert.That(4L, Is.EqualTo(v.y));
        }
        {
            var v = new lvec2(new lvec2(-7L, -2L));
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(-2L, Is.EqualTo(v.y));
        }
        {
            var v = new lvec2(new lvec3(-9L, 8L, 9L));
            Assert.That(-9L, Is.EqualTo(v.x));
            Assert.That(8L, Is.EqualTo(v.y));
        }
        {
            var v = new lvec2(new lvec4(8L, 4L, 6L, 5L));
            Assert.That(8L, Is.EqualTo(v.x));
            Assert.That(4L, Is.EqualTo(v.y));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new lvec2(6L, 4L);
        Assert.That(6L, Is.EqualTo(v[0]));
        Assert.That(4L, Is.EqualTo(v[1]));
        
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
        v[0] = 2L;
        Assert.That(2L, Is.EqualTo(v[0]));
        v[0] = 3L;
        Assert.That(3L, Is.EqualTo(v[0]));
        v[1] = 4L;
        Assert.That(4L, Is.EqualTo(v[1]));
        v[0] = 5L;
        Assert.That(5L, Is.EqualTo(v[0]));
        v[1] = 6L;
        Assert.That(6L, Is.EqualTo(v[1]));
        v[1] = 7L;
        Assert.That(7L, Is.EqualTo(v[1]));
        v[1] = 8L;
        Assert.That(8L, Is.EqualTo(v[1]));
        v[1] = 9L;
        Assert.That(9L, Is.EqualTo(v[1]));
        v[0] = -1L;
        Assert.That(-1L, Is.EqualTo(v[0]));
        v[1] = -2L;
        Assert.That(-2L, Is.EqualTo(v[1]));
        v[1] = -3L;
        Assert.That(-3L, Is.EqualTo(v[1]));
        v[1] = -4L;
        Assert.That(-4L, Is.EqualTo(v[1]));
        v[0] = -5L;
        Assert.That(-5L, Is.EqualTo(v[0]));
        v[0] = -6L;
        Assert.That(-6L, Is.EqualTo(v[0]));
        v[1] = -7L;
        Assert.That(-7L, Is.EqualTo(v[1]));
        v[1] = -8L;
        Assert.That(-8L, Is.EqualTo(v[1]));
        v[0] = -9L;
        Assert.That(-9L, Is.EqualTo(v[0]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new lvec2(5L, -6L);
        var vals = v.Values;
        Assert.That(5L, Is.EqualTo(vals[0]));
        Assert.That(-6L, Is.EqualTo(vals[1]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0, Is.EqualTo(lvec2.Zero.x));
        Assert.That(0, Is.EqualTo(lvec2.Zero.y));
        
        Assert.That(1, Is.EqualTo(lvec2.Ones.x));
        Assert.That(1, Is.EqualTo(lvec2.Ones.y));
        
        Assert.That(1, Is.EqualTo(lvec2.UnitX.x));
        Assert.That(0, Is.EqualTo(lvec2.UnitX.y));
        
        Assert.That(0, Is.EqualTo(lvec2.UnitY.x));
        Assert.That(1, Is.EqualTo(lvec2.UnitY.y));
        
        Assert.That(long.MaxValue, Is.EqualTo(lvec2.MaxValue.x));
        Assert.That(long.MaxValue, Is.EqualTo(lvec2.MaxValue.y));
        
        Assert.That(long.MinValue, Is.EqualTo(lvec2.MinValue.x));
        Assert.That(long.MinValue, Is.EqualTo(lvec2.MinValue.y));
    }

    [Test]
    public void Operators()
    {
        var v1 = new lvec2(1, 9L);
        var v2 = new lvec2(1, 9L);
        var v3 = new lvec2(9L, 1);
        Assert.That(v1 == new lvec2(v1));
        Assert.That(v2 == new lvec2(v2));
        Assert.That(v3 == new lvec2(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new lvec2(1, 4L);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = lvec2.Parse(s0);
        var v1 = lvec2.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = lvec2.TryParse(s0, out v0);
        var b1 = lvec2.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = lvec2.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = lvec2.TryParse("", out v0);
        Assert.That(!b0);
        b0 = lvec2.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { lvec2.Parse(null); });
        Assert.Throws<FormatException>(() => { lvec2.Parse(""); });
        Assert.Throws<FormatException>(() => { lvec2.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = lvec2.Parse(s3, "; ", NumberStyles.Number);
        var v4 = lvec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = lvec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new lvec2(-7L, -1L);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<lvec2>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new lvec2(-7L, 1);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec2(-2L, 9L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec2(1, 8L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec2(-4L, 4L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec2(-3L, 0);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec2(5L, 5L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec2(-1L, -7L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec2(8L, 9L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec2(1, -8L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec2(2L, 7L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new lvec2(-7L, -7L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec2(8L, -7L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec2(0, 7L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec2(-3L, -7L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec2(3L, -1L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec2(-7L, -5L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec2(-4L, 1);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec2(1, -6L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec2(-5L, 3L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec2(4L, -8L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new lvec2(9L, 5L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec2(7L, 0);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec2(6L, 7L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec2(-9L, 5L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec2(-5L, -6L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec2(7L, -1L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec2(-8L, -7L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec2(1, -8L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec2(4L, 7L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec2(-2L, 5L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new lvec2(-1L, 9L);
            var v1 = new lvec2(-8L, 7L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec2(-5L, 9L);
            var v1 = new lvec2(4L, -8L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec2(2L, -3L);
            var v1 = new lvec2(-9L, 9L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec2(6L, 3L);
            var v1 = new lvec2(-1L, 0);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec2(-1L, -3L);
            var v1 = new lvec2(2L, -6L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec2(-6L, 9L);
            var v1 = new lvec2(4L, 4L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec2(-6L, -3L);
            var v1 = new lvec2(1, -3L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec2(-7L, -7L);
            var v1 = new lvec2(7L, -9L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec2(4L, 5L);
            var v1 = new lvec2(-7L, -8L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec2(-2L, 8L);
            var v1 = new lvec2(-2L, -5L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new lvec2(3L, 8L);
            var v1 = new lvec2(8L, -9L);
            var v2 = new lvec2(-2L, 2L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec2(-4L, 4L);
            var v1 = new lvec2(-2L, -5L);
            var v2 = new lvec2(5L, -8L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec2(1, 9L);
            var v1 = new lvec2(2L, 6L);
            var v2 = new lvec2(3L, -3L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec2(8L, -4L);
            var v1 = new lvec2(3L, -6L);
            var v2 = new lvec2(-2L, 1);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec2(6L, 1);
            var v1 = new lvec2(4L, 5L);
            var v2 = new lvec2(7L, 0);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec2(9L, -2L);
            var v1 = new lvec2(8L, 6L);
            var v2 = new lvec2(2L, -5L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec2(-1L, -2L);
            var v1 = new lvec2(6L, 6L);
            var v2 = new lvec2(-8L, -2L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec2(-3L, -1L);
            var v1 = new lvec2(6L, -8L);
            var v2 = new lvec2(7L, 8L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec2(-7L, -3L);
            var v1 = new lvec2(2L, -4L);
            var v2 = new lvec2(-5L, 6L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec2(5L, 6L);
            var v1 = new lvec2(-6L, 6L);
            var v2 = new lvec2(-3L, -1L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new lvec2(-1L, 8L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec2(-3L, -1L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec2(3L, 2L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec2(0, -3L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec2(-9L, -1L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec2(-8L, 4L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec2(-6L, 8L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec2(-5L, 7L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec2(-3L, 7L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec2(0, 5L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new lvec2(-9L, 8L);
            var v1 = new lvec2(-8L, -9L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec2(-9L, -2L);
            var v1 = new lvec2(-7L, -4L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec2(4L, -6L);
            var v1 = new lvec2(-5L, -8L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec2(9L, 4L);
            var v1 = new lvec2(-7L, 8L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec2(4L, 7L);
            var v1 = new lvec2(0, 2L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec2(-5L, -5L);
            var v1 = new lvec2(1, -4L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec2(4L, 6L);
            var v1 = new lvec2(-5L, 2L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec2(8L, -7L);
            var v1 = new lvec2(-3L, -4L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec2(-8L, 6L);
            var v1 = new lvec2(-1L, 6L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec2(-4L, -6L);
            var v1 = new lvec2(-8L, 7L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new lvec2(8L, 6L);
            var v1 = new lvec2(-3L, 0);
            var v2 = new lvec2(6L, 7L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec2(-9L, -5L);
            var v1 = new lvec2(-9L, 4L);
            var v2 = new lvec2(-8L, 9L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec2(0, 7L);
            var v1 = new lvec2(-5L, -6L);
            var v2 = new lvec2(1, 0);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec2(4L, -5L);
            var v1 = new lvec2(-3L, -3L);
            var v2 = new lvec2(9L, 5L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec2(7L, 7L);
            var v1 = new lvec2(4L, 2L);
            var v2 = new lvec2(0, 6L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec2(1, 0);
            var v1 = new lvec2(-2L, 5L);
            var v2 = new lvec2(-5L, 7L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec2(2L, -5L);
            var v1 = new lvec2(-9L, -7L);
            var v2 = new lvec2(-7L, -2L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec2(2L, -1L);
            var v1 = new lvec2(-7L, 0);
            var v2 = new lvec2(9L, -7L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec2(-9L, -6L);
            var v1 = new lvec2(1, -1L);
            var v2 = new lvec2(-3L, 4L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec2(-4L, -5L);
            var v1 = new lvec2(-6L, 7L);
            var v2 = new lvec2(-3L, -8L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new lvec2(7L, -9L);
            var v1 = new lvec2(9L, 7L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec2(-1L, -2L);
            var v1 = new lvec2(-1L, -9L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec2(-4L, 8L);
            var v1 = new lvec2(2L, -6L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec2(-3L, 9L);
            var v1 = new lvec2(-4L, -6L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec2(4L, 2L);
            var v1 = new lvec2(4L, -2L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec2(-4L, 5L);
            var v1 = new lvec2(-1L, 6L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec2(-2L, -8L);
            var v1 = new lvec2(-7L, 0);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec2(4L, 0);
            var v1 = new lvec2(2L, 6L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec2(-6L, -3L);
            var v1 = new lvec2(-4L, -3L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec2(3L, -4L);
            var v1 = new lvec2(-3L, -8L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new lvec2(2L, 6L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec2(2L, 4L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec2(2L, -2L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec2(4L, 2L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec2(2L, -8L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec2(6L, 5L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec2(-5L, -4L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec2(0, -8L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec2(-3L, 2L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec2(0, -4L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(530583572);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec2.Random(random, (-3), (2));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(68893612);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec2.RandomUniform(random, (0), (3));
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
    public void RandomUniform2()
    {
        var random = new Random(71666369);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec2.Random(random, (-2), (1));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6666666666666666).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(606068153);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec2.RandomUniform(random, (-4), (-1));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-3).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-3).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6666666666666666).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(353627741);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec2.Random(random, (1), (3));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.25).Within(3.0));
    }

    [Test]
    public void RandomPoisson0()
    {
        var random = new Random(1815444793);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec2.RandomPoisson(random, 3.1097937229135044);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.1097937229135044).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.1097937229135044).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.1097937229135044).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.1097937229135044).Within(3.0));
    }

    [Test]
    public void RandomPoisson1()
    {
        var random = new Random(2133826522);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec2.RandomPoisson(random, 1.6022750223531737);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.6022750223531737).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.6022750223531737).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.6022750223531737).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.6022750223531737).Within(3.0));
    }

    [Test]
    public void RandomPoisson2()
    {
        var random = new Random(621151935);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec2.RandomPoisson(random, 1.282759436770696);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.282759436770696).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.282759436770696).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.282759436770696).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.282759436770696).Within(3.0));
    }

    [Test]
    public void RandomPoisson3()
    {
        var random = new Random(1893585475);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec2.RandomPoisson(random, 3.407828106967652);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.407828106967652).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.407828106967652).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.407828106967652).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.407828106967652).Within(3.0));
    }

    [Test]
    public void RandomPoisson4()
    {
        var random = new Random(1852697694);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec2.RandomPoisson(random, 2.362594711530299);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.362594711530299).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.362594711530299).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.362594711530299).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.362594711530299).Within(3.0));
    }

}
