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
public class LongVec3Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new lvec3(-3L);
            Assert.That(-3L, Is.EqualTo(v.x));
            Assert.That(-3L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
        }
        {
            var v = new lvec3(-7L, 2L, 3L);
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(2L, Is.EqualTo(v.y));
            Assert.That(3L, Is.EqualTo(v.z));
        }
        {
            var v = new lvec3(new lvec2(-1L, 3L));
            Assert.That(-1L, Is.EqualTo(v.x));
            Assert.That(3L, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var v = new lvec3(new lvec3(5L, -7L, 5L));
            Assert.That(5L, Is.EqualTo(v.x));
            Assert.That(-7L, Is.EqualTo(v.y));
            Assert.That(5L, Is.EqualTo(v.z));
        }
        {
            var v = new lvec3(new lvec4(-7L, 7L, -3L, -9L));
            Assert.That(-7L, Is.EqualTo(v.x));
            Assert.That(7L, Is.EqualTo(v.y));
            Assert.That(-3L, Is.EqualTo(v.z));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new lvec3(-1L, 2L, 7L);
        Assert.That(-1L, Is.EqualTo(v[0]));
        Assert.That(2L, Is.EqualTo(v[1]));
        Assert.That(7L, Is.EqualTo(v[2]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
        
        v[1] = 0;
        Assert.That(0, Is.EqualTo(v[1]));
        v[1] = 1;
        Assert.That(1, Is.EqualTo(v[1]));
        v[0] = 2L;
        Assert.That(2L, Is.EqualTo(v[0]));
        v[0] = 3L;
        Assert.That(3L, Is.EqualTo(v[0]));
        v[1] = 4L;
        Assert.That(4L, Is.EqualTo(v[1]));
        v[1] = 5L;
        Assert.That(5L, Is.EqualTo(v[1]));
        v[1] = 6L;
        Assert.That(6L, Is.EqualTo(v[1]));
        v[2] = 7L;
        Assert.That(7L, Is.EqualTo(v[2]));
        v[0] = 8L;
        Assert.That(8L, Is.EqualTo(v[0]));
        v[2] = 9L;
        Assert.That(9L, Is.EqualTo(v[2]));
        v[0] = -1L;
        Assert.That(-1L, Is.EqualTo(v[0]));
        v[0] = -2L;
        Assert.That(-2L, Is.EqualTo(v[0]));
        v[1] = -3L;
        Assert.That(-3L, Is.EqualTo(v[1]));
        v[2] = -4L;
        Assert.That(-4L, Is.EqualTo(v[2]));
        v[1] = -5L;
        Assert.That(-5L, Is.EqualTo(v[1]));
        v[2] = -6L;
        Assert.That(-6L, Is.EqualTo(v[2]));
        v[2] = -7L;
        Assert.That(-7L, Is.EqualTo(v[2]));
        v[0] = -8L;
        Assert.That(-8L, Is.EqualTo(v[0]));
        v[0] = -9L;
        Assert.That(-9L, Is.EqualTo(v[0]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new lvec3(-2L, -3L, -9L);
        var vals = v.Values;
        Assert.That(-2L, Is.EqualTo(vals[0]));
        Assert.That(-3L, Is.EqualTo(vals[1]));
        Assert.That(-9L, Is.EqualTo(vals[2]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0, Is.EqualTo(lvec3.Zero.x));
        Assert.That(0, Is.EqualTo(lvec3.Zero.y));
        Assert.That(0, Is.EqualTo(lvec3.Zero.z));
        
        Assert.That(1, Is.EqualTo(lvec3.Ones.x));
        Assert.That(1, Is.EqualTo(lvec3.Ones.y));
        Assert.That(1, Is.EqualTo(lvec3.Ones.z));
        
        Assert.That(1, Is.EqualTo(lvec3.UnitX.x));
        Assert.That(0, Is.EqualTo(lvec3.UnitX.y));
        Assert.That(0, Is.EqualTo(lvec3.UnitX.z));
        
        Assert.That(0, Is.EqualTo(lvec3.UnitY.x));
        Assert.That(1, Is.EqualTo(lvec3.UnitY.y));
        Assert.That(0, Is.EqualTo(lvec3.UnitY.z));
        
        Assert.That(0, Is.EqualTo(lvec3.UnitZ.x));
        Assert.That(0, Is.EqualTo(lvec3.UnitZ.y));
        Assert.That(1, Is.EqualTo(lvec3.UnitZ.z));
        
        Assert.That(long.MaxValue, Is.EqualTo(lvec3.MaxValue.x));
        Assert.That(long.MaxValue, Is.EqualTo(lvec3.MaxValue.y));
        Assert.That(long.MaxValue, Is.EqualTo(lvec3.MaxValue.z));
        
        Assert.That(long.MinValue, Is.EqualTo(lvec3.MinValue.x));
        Assert.That(long.MinValue, Is.EqualTo(lvec3.MinValue.y));
        Assert.That(long.MinValue, Is.EqualTo(lvec3.MinValue.z));
    }

    [Test]
    public void Operators()
    {
        var v1 = new lvec3(4L, -7L, 0);
        var v2 = new lvec3(4L, -7L, 0);
        var v3 = new lvec3(0, -7L, 4L);
        Assert.That(v1 == new lvec3(v1));
        Assert.That(v2 == new lvec3(v2));
        Assert.That(v3 == new lvec3(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new lvec3(5L, -2L, -6L);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = lvec3.Parse(s0);
        var v1 = lvec3.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = lvec3.TryParse(s0, out v0);
        var b1 = lvec3.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = lvec3.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = lvec3.TryParse("", out v0);
        Assert.That(!b0);
        b0 = lvec3.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { lvec3.Parse(null); });
        Assert.Throws<FormatException>(() => { lvec3.Parse(""); });
        Assert.Throws<FormatException>(() => { lvec3.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = lvec3.Parse(s3, "; ", NumberStyles.Number);
        var v4 = lvec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = lvec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new lvec3(-8L, 1, -6L);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<lvec3>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new lvec3(-4L, 5L, 8L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec3(-2L, -3L, -1L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec3(-6L, 2L, 6L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec3(0, 0, -8L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec3(-3L, -7L, 0);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec3(0, 2L, 7L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec3(-3L, 3L, -1L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec3(3L, 2L, -2L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec3(-2L, -1L, -6L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new lvec3(6L, -7L, -2L);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new lvec3(5L, -1L, 2L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec3(9L, -9L, -4L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec3(-5L, -6L, 1);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec3(-9L, -7L, 7L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec3(8L, 9L, 3L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec3(3L, 7L, -1L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec3(-4L, -2L, -5L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec3(8L, -9L, 9L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec3(0, 5L, 7L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new lvec3(-5L, -5L, 9L);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new lvec3(-6L, -2L, -2L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec3(-1L, -2L, 5L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec3(5L, -4L, -5L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec3(-1L, 3L, 3L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec3(8L, 1, 0);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec3(7L, -5L, -9L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec3(-1L, -6L, -9L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec3(3L, 1, 5L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec3(-4L, -2L, -7L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new lvec3(-8L, 5L, 4L);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new lvec3(-2L, 8L, -2L);
            var v1 = new lvec3(1, 9L, -9L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec3(-8L, 5L, -4L);
            var v1 = new lvec3(4L, -5L, -1L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec3(7L, 6L, 7L);
            var v1 = new lvec3(-1L, 1, 8L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec3(1, 4L, -6L);
            var v1 = new lvec3(-3L, 3L, 4L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec3(2L, 2L, 7L);
            var v1 = new lvec3(-1L, -8L, -1L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec3(6L, 9L, 1);
            var v1 = new lvec3(-2L, -8L, -9L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec3(-7L, 1, 7L);
            var v1 = new lvec3(9L, -8L, -4L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec3(7L, 6L, 9L);
            var v1 = new lvec3(-6L, -4L, -5L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec3(4L, -9L, -9L);
            var v1 = new lvec3(-5L, 5L, 7L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new lvec3(6L, -9L, 5L);
            var v1 = new lvec3(6L, -8L, 6L);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new lvec3(0, 6L, -8L);
            var v1 = new lvec3(-2L, 2L, -1L);
            var v2 = new lvec3(-7L, 0, -3L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec3(-2L, -7L, -4L);
            var v1 = new lvec3(9L, -7L, 0);
            var v2 = new lvec3(2L, 0, -4L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec3(4L, 9L, 6L);
            var v1 = new lvec3(4L, -4L, -5L);
            var v2 = new lvec3(4L, -5L, 7L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec3(7L, 3L, -6L);
            var v1 = new lvec3(3L, -3L, 8L);
            var v2 = new lvec3(2L, 3L, -7L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec3(8L, 5L, 2L);
            var v1 = new lvec3(2L, 5L, 8L);
            var v2 = new lvec3(-9L, -1L, 7L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec3(2L, 4L, 8L);
            var v1 = new lvec3(-5L, 5L, 2L);
            var v2 = new lvec3(-1L, -7L, -2L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec3(5L, -6L, -3L);
            var v1 = new lvec3(3L, 6L, 7L);
            var v2 = new lvec3(2L, 9L, -7L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec3(-6L, 7L, 3L);
            var v1 = new lvec3(4L, 7L, -3L);
            var v2 = new lvec3(2L, -3L, -4L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec3(-2L, 1, 4L);
            var v1 = new lvec3(-7L, 4L, 2L);
            var v2 = new lvec3(7L, 1, -1L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new lvec3(-9L, -2L, -8L);
            var v1 = new lvec3(-3L, -3L, -5L);
            var v2 = new lvec3(-6L, -6L, 6L);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new lvec3(-7L, -6L, -7L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec3(2L, -4L, 9L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec3(3L, -8L, 4L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec3(9L, -1L, 9L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec3(-4L, -7L, -8L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec3(-9L, 3L, 4L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec3(2L, 4L, -6L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec3(-4L, -7L, -9L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec3(4L, 4L, 4L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new lvec3(-5L, -3L, 4L);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new lvec3(0, -4L, 1);
            var v1 = new lvec3(3L, -2L, -2L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec3(4L, -2L, 4L);
            var v1 = new lvec3(1, -6L, 8L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec3(1, -7L, -4L);
            var v1 = new lvec3(-9L, -1L, -1L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec3(4L, -4L, 3L);
            var v1 = new lvec3(4L, -3L, 0);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec3(-5L, -6L, -8L);
            var v1 = new lvec3(7L, 6L, 4L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec3(4L, 9L, 5L);
            var v1 = new lvec3(-3L, 4L, -5L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec3(-9L, 3L, -4L);
            var v1 = new lvec3(6L, -7L, -7L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec3(-9L, -2L, 3L);
            var v1 = new lvec3(4L, 3L, -1L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec3(3L, -2L, 1);
            var v1 = new lvec3(2L, 8L, -4L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new lvec3(-7L, -6L, 0);
            var v1 = new lvec3(1, 7L, -6L);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new lvec3(-4L, -5L, -4L);
            var v1 = new lvec3(6L, 9L, 8L);
            var v2 = new lvec3(-9L, -8L, 4L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec3(-8L, 5L, 5L);
            var v1 = new lvec3(0, 4L, 4L);
            var v2 = new lvec3(-1L, 6L, -5L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec3(3L, 0, 3L);
            var v1 = new lvec3(4L, -2L, -1L);
            var v2 = new lvec3(6L, -3L, 3L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec3(-6L, 7L, -8L);
            var v1 = new lvec3(-1L, 1, 0);
            var v2 = new lvec3(-2L, -4L, -2L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec3(-5L, -4L, 9L);
            var v1 = new lvec3(1, -4L, -4L);
            var v2 = new lvec3(5L, -8L, -7L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec3(-3L, -4L, -1L);
            var v1 = new lvec3(-5L, 2L, -5L);
            var v2 = new lvec3(1, 7L, 2L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec3(5L, 9L, 3L);
            var v1 = new lvec3(2L, 0, -7L);
            var v2 = new lvec3(4L, 3L, -1L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec3(5L, 7L, 3L);
            var v1 = new lvec3(4L, 8L, -1L);
            var v2 = new lvec3(-2L, -5L, -3L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec3(5L, 2L, 6L);
            var v1 = new lvec3(8L, -8L, -3L);
            var v2 = new lvec3(-3L, -3L, -8L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new lvec3(-3L, 0, 5L);
            var v1 = new lvec3(3L, 8L, -3L);
            var v2 = new lvec3(-8L, 5L, 3L);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new lvec3(1, -7L, 3L);
            var v1 = new lvec3(-1L, -5L, 0);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec3(-9L, -4L, -5L);
            var v1 = new lvec3(6L, 9L, 6L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec3(2L, 4L, -3L);
            var v1 = new lvec3(-1L, 4L, -6L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec3(5L, 8L, -9L);
            var v1 = new lvec3(-6L, -2L, 9L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec3(9L, 1, 7L);
            var v1 = new lvec3(-9L, 2L, -2L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec3(-1L, -9L, 8L);
            var v1 = new lvec3(-5L, 2L, 7L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec3(8L, -5L, -4L);
            var v1 = new lvec3(3L, 5L, 3L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec3(-4L, 5L, -1L);
            var v1 = new lvec3(-9L, 2L, -3L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec3(-4L, -6L, -6L);
            var v1 = new lvec3(7L, -5L, -8L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new lvec3(-3L, 4L, 4L);
            var v1 = new lvec3(-3L, 0, -4L);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new lvec3(1, 5L, 0);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec3(4L, 7L, -2L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec3(-6L, 7L, 9L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec3(5L, -8L, 7L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec3(-7L, -1L, -4L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec3(5L, 6L, 8L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec3(-4L, -6L, 2L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec3(-3L, 9L, 5L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec3(9L, -1L, 5L);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new lvec3(-5L, 2L, 0);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void InvariantCrossDot()
    {
        {
            var v0 = new lvec3(-8L, 4L, -4L);
            var v1 = new lvec3(2L, -9L, -7L);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new lvec3(-7L, 4L, -7L);
            var v1 = new lvec3(-8L, 5L, 9L);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new lvec3(5L, 5L, 0);
            var v1 = new lvec3(7L, 3L, 6L);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new lvec3(-3L, -5L, 9L);
            var v1 = new lvec3(8L, 5L, 7L);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new lvec3(4L, 4L, -5L);
            var v1 = new lvec3(6L, -5L, 7L);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new lvec3(6L, 7L, -3L);
            var v1 = new lvec3(-5L, 0, -2L);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new lvec3(-3L, 8L, 9L);
            var v1 = new lvec3(-7L, 0, 5L);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new lvec3(0, 0, -3L);
            var v1 = new lvec3(-8L, 7L, 7L);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new lvec3(1, 4L, 2L);
            var v1 = new lvec3(4L, -6L, 9L);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new lvec3(2L, 9L, -9L);
            var v1 = new lvec3(6L, -8L, -5L);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(1205281754);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec3.Random(random, (-4), (0));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-2.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-2.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-2.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.25).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(832219650);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec3.RandomUniform(random, (3), (7));
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
    public void RandomUniform2()
    {
        var random = new Random(776353975);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec3.Random(random, (3), (5));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.25).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(1657597428);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec3.RandomUniform(random, (2), (7));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(4).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(144261657);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec3.Random(random, (3), (5));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.25).Within(3.0));
    }

    [Test]
    public void RandomPoisson0()
    {
        var random = new Random(1763257703);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec3.RandomPoisson(random, 2.929044239422793);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.929044239422793).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.929044239422793).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2.929044239422793).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.929044239422793).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.929044239422793).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.929044239422793).Within(3.0));
    }

    [Test]
    public void RandomPoisson1()
    {
        var random = new Random(654176974);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec3.RandomPoisson(random, 0.8407009673960046);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.8407009673960046).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.8407009673960046).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.8407009673960046).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.8407009673960046).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.8407009673960046).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.8407009673960046).Within(3.0));
    }

    [Test]
    public void RandomPoisson2()
    {
        var random = new Random(2058401089);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec3.RandomPoisson(random, 3.2639827587474057);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.2639827587474057).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.2639827587474057).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3.2639827587474057).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.2639827587474057).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.2639827587474057).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(3.2639827587474057).Within(3.0));
    }

    [Test]
    public void RandomPoisson3()
    {
        var random = new Random(1870851693);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec3.RandomPoisson(random, 2.2051833186788405);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.2051833186788405).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.2051833186788405).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2.2051833186788405).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.2051833186788405).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.2051833186788405).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.2051833186788405).Within(3.0));
    }

    [Test]
    public void RandomPoisson4()
    {
        var random = new Random(1511729909);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = lvec3.RandomPoisson(random, 3.490889572534193);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.490889572534193).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.490889572534193).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3.490889572534193).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.490889572534193).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.490889572534193).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(3.490889572534193).Within(3.0));
    }

}
