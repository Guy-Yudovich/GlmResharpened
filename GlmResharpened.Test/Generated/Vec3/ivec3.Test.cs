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
public class IntVec3Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new ivec3(-6);
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(-6, Is.EqualTo(v.z));
        }
        {
            var v = new ivec3(5, 8, 7);
            Assert.That(5, Is.EqualTo(v.x));
            Assert.That(8, Is.EqualTo(v.y));
            Assert.That(7, Is.EqualTo(v.z));
        }
        {
            var v = new ivec3(new ivec2(3, 0));
            Assert.That(3, Is.EqualTo(v.x));
            Assert.That(0, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
        }
        {
            var v = new ivec3(new ivec3(2, -4, 2));
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-4, Is.EqualTo(v.y));
            Assert.That(2, Is.EqualTo(v.z));
        }
        {
            var v = new ivec3(new ivec4(-6, 6, 5, 9));
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(5, Is.EqualTo(v.z));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new ivec3(-3, -4, -5);
        Assert.That(-3, Is.EqualTo(v[0]));
        Assert.That(-4, Is.EqualTo(v[1]));
        Assert.That(-5, Is.EqualTo(v[2]));
        
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
        
        v[2] = 0;
        Assert.That(0, Is.EqualTo(v[2]));
        v[1] = 1;
        Assert.That(1, Is.EqualTo(v[1]));
        v[1] = 2;
        Assert.That(2, Is.EqualTo(v[1]));
        v[1] = 3;
        Assert.That(3, Is.EqualTo(v[1]));
        v[1] = 4;
        Assert.That(4, Is.EqualTo(v[1]));
        v[2] = 5;
        Assert.That(5, Is.EqualTo(v[2]));
        v[2] = 6;
        Assert.That(6, Is.EqualTo(v[2]));
        v[1] = 7;
        Assert.That(7, Is.EqualTo(v[1]));
        v[2] = 8;
        Assert.That(8, Is.EqualTo(v[2]));
        v[2] = 9;
        Assert.That(9, Is.EqualTo(v[2]));
        v[0] = -1;
        Assert.That(-1, Is.EqualTo(v[0]));
        v[1] = -2;
        Assert.That(-2, Is.EqualTo(v[1]));
        v[2] = -3;
        Assert.That(-3, Is.EqualTo(v[2]));
        v[2] = -4;
        Assert.That(-4, Is.EqualTo(v[2]));
        v[1] = -5;
        Assert.That(-5, Is.EqualTo(v[1]));
        v[1] = -6;
        Assert.That(-6, Is.EqualTo(v[1]));
        v[0] = -7;
        Assert.That(-7, Is.EqualTo(v[0]));
        v[2] = -8;
        Assert.That(-8, Is.EqualTo(v[2]));
        v[1] = -9;
        Assert.That(-9, Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new ivec3(-6, -1, -8);
        var vals = v.Values;
        Assert.That(-6, Is.EqualTo(vals[0]));
        Assert.That(-1, Is.EqualTo(vals[1]));
        Assert.That(-8, Is.EqualTo(vals[2]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0, Is.EqualTo(ivec3.Zero.x));
        Assert.That(0, Is.EqualTo(ivec3.Zero.y));
        Assert.That(0, Is.EqualTo(ivec3.Zero.z));
        
        Assert.That(1, Is.EqualTo(ivec3.Ones.x));
        Assert.That(1, Is.EqualTo(ivec3.Ones.y));
        Assert.That(1, Is.EqualTo(ivec3.Ones.z));
        
        Assert.That(1, Is.EqualTo(ivec3.UnitX.x));
        Assert.That(0, Is.EqualTo(ivec3.UnitX.y));
        Assert.That(0, Is.EqualTo(ivec3.UnitX.z));
        
        Assert.That(0, Is.EqualTo(ivec3.UnitY.x));
        Assert.That(1, Is.EqualTo(ivec3.UnitY.y));
        Assert.That(0, Is.EqualTo(ivec3.UnitY.z));
        
        Assert.That(0, Is.EqualTo(ivec3.UnitZ.x));
        Assert.That(0, Is.EqualTo(ivec3.UnitZ.y));
        Assert.That(1, Is.EqualTo(ivec3.UnitZ.z));
        
        Assert.That(int.MaxValue, Is.EqualTo(ivec3.MaxValue.x));
        Assert.That(int.MaxValue, Is.EqualTo(ivec3.MaxValue.y));
        Assert.That(int.MaxValue, Is.EqualTo(ivec3.MaxValue.z));
        
        Assert.That(int.MinValue, Is.EqualTo(ivec3.MinValue.x));
        Assert.That(int.MinValue, Is.EqualTo(ivec3.MinValue.y));
        Assert.That(int.MinValue, Is.EqualTo(ivec3.MinValue.z));
    }

    [Test]
    public void Operators()
    {
        var v1 = new ivec3(-7, 7, -6);
        var v2 = new ivec3(-7, 7, -6);
        var v3 = new ivec3(-6, 7, -7);
        Assert.That(v1 == new ivec3(v1));
        Assert.That(v2 == new ivec3(v2));
        Assert.That(v3 == new ivec3(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new ivec3(-7, -3, 7);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = ivec3.Parse(s0);
        var v1 = ivec3.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = ivec3.TryParse(s0, out v0);
        var b1 = ivec3.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = ivec3.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = ivec3.TryParse("", out v0);
        Assert.That(!b0);
        b0 = ivec3.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { ivec3.Parse(null); });
        Assert.Throws<FormatException>(() => { ivec3.Parse(""); });
        Assert.Throws<FormatException>(() => { ivec3.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = ivec3.Parse(s3, "; ", NumberStyles.Number);
        var v4 = ivec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = ivec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new ivec3(7, 4, 2);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<ivec3>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new ivec3(7, -5, 8);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec3(-9, 9, 7);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec3(0, 0, -9);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec3(9, 5, 5);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec3(-8, -4, 2);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec3(-5, -1, 6);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec3(-3, -9, -3);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec3(-6, -9, 7);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec3(-7, 7, 3);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec3(1, -8, 6);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new ivec3(6, 2, -3);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec3(8, -2, 8);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec3(6, 1, -7);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec3(1, -7, -4);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec3(6, 4, 8);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec3(-1, 5, -5);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec3(-3, 5, 5);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec3(-9, 1, 7);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec3(4, -4, 2);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec3(-3, 2, -6);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new ivec3(8, -3, 6);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec3(-3, -2, -5);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec3(-1, -6, -7);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec3(5, 3, 6);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec3(0, 4, 4);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec3(-6, -9, 3);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec3(3, -5, 3);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec3(-4, -3, -5);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec3(8, 3, 6);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec3(-3, 8, -1);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new ivec3(4, -1, 4);
            var v1 = new ivec3(1, 2, 3);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec3(-3, 2, -5);
            var v1 = new ivec3(-4, -2, 5);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec3(8, 9, 1);
            var v1 = new ivec3(-8, 1, -4);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec3(0, -1, 9);
            var v1 = new ivec3(6, 5, 6);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec3(1, -1, -1);
            var v1 = new ivec3(7, -2, 0);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec3(-3, -7, -6);
            var v1 = new ivec3(-3, -5, -9);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec3(-8, -3, -9);
            var v1 = new ivec3(5, 9, 9);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec3(-2, 7, -5);
            var v1 = new ivec3(5, -3, 8);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec3(5, 0, 9);
            var v1 = new ivec3(-9, 4, -9);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec3(-4, -7, 4);
            var v1 = new ivec3(-8, -9, -1);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new ivec3(-5, 9, 5);
            var v1 = new ivec3(-4, 7, 0);
            var v2 = new ivec3(-5, -7, 0);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec3(6, 6, -9);
            var v1 = new ivec3(-7, -2, 3);
            var v2 = new ivec3(8, 0, -7);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec3(6, 6, 6);
            var v1 = new ivec3(9, 0, -4);
            var v2 = new ivec3(-4, -8, -7);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec3(3, 4, 5);
            var v1 = new ivec3(-3, 2, -5);
            var v2 = new ivec3(-5, 6, -9);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec3(4, 7, -1);
            var v1 = new ivec3(-3, 3, 0);
            var v2 = new ivec3(0, -8, -7);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec3(-5, 9, -6);
            var v1 = new ivec3(6, 6, 7);
            var v2 = new ivec3(-8, -1, 4);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec3(4, 5, 8);
            var v1 = new ivec3(-1, 0, 8);
            var v2 = new ivec3(3, -2, -2);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec3(-4, -3, 3);
            var v1 = new ivec3(4, 2, 5);
            var v2 = new ivec3(4, 3, -3);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec3(6, -4, 3);
            var v1 = new ivec3(5, 9, 2);
            var v2 = new ivec3(-7, -8, 8);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec3(1, -6, -7);
            var v1 = new ivec3(-8, -4, -1);
            var v2 = new ivec3(9, -1, 1);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new ivec3(8, 9, 1);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec3(8, -1, -3);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec3(-9, 0, -1);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec3(3, 2, 5);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec3(3, 7, 5);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec3(4, 7, 4);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec3(-8, -3, -3);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec3(-1, 4, 8);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec3(3, -3, 0);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec3(3, 5, 4);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new ivec3(0, 9, -6);
            var v1 = new ivec3(0, -5, 3);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec3(2, -9, 5);
            var v1 = new ivec3(-8, 5, -2);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec3(8, -2, 2);
            var v1 = new ivec3(3, -6, 4);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec3(-8, -7, 4);
            var v1 = new ivec3(-6, -1, 5);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec3(-4, 1, -2);
            var v1 = new ivec3(7, -4, -5);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec3(-4, -8, -7);
            var v1 = new ivec3(9, 4, 0);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec3(4, 1, -8);
            var v1 = new ivec3(-1, -6, -1);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec3(5, 1, 0);
            var v1 = new ivec3(7, 2, -4);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec3(-3, -2, -4);
            var v1 = new ivec3(-4, -3, -7);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec3(-3, 4, -8);
            var v1 = new ivec3(-1, 5, -4);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new ivec3(-9, 0, 8);
            var v1 = new ivec3(8, -5, 6);
            var v2 = new ivec3(4, -1, 5);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec3(-3, -8, 9);
            var v1 = new ivec3(6, 4, 8);
            var v2 = new ivec3(1, -1, 8);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec3(-5, 6, -5);
            var v1 = new ivec3(0, -6, 9);
            var v2 = new ivec3(-5, 8, 0);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec3(0, 9, 3);
            var v1 = new ivec3(5, 3, -9);
            var v2 = new ivec3(2, -1, 3);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec3(7, 9, -5);
            var v1 = new ivec3(-6, -6, 7);
            var v2 = new ivec3(-5, -2, 9);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec3(-8, 5, 9);
            var v1 = new ivec3(0, 4, 7);
            var v2 = new ivec3(6, -2, -3);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec3(-2, -8, 3);
            var v1 = new ivec3(-9, -4, 5);
            var v2 = new ivec3(6, 4, 0);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec3(2, 6, -4);
            var v1 = new ivec3(-1, 3, -3);
            var v2 = new ivec3(4, -4, 0);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec3(-4, -9, -1);
            var v1 = new ivec3(7, 5, 4);
            var v2 = new ivec3(0, -6, 2);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec3(-1, -9, 5);
            var v1 = new ivec3(-6, -9, -1);
            var v2 = new ivec3(6, -1, -3);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new ivec3(0, -9, 7);
            var v1 = new ivec3(0, 3, -2);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec3(7, 2, -1);
            var v1 = new ivec3(8, -3, 5);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec3(5, 4, 2);
            var v1 = new ivec3(-9, 7, 0);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec3(4, -1, -2);
            var v1 = new ivec3(-8, 1, -7);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec3(0, 1, 9);
            var v1 = new ivec3(9, -1, -8);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec3(3, 8, 0);
            var v1 = new ivec3(3, -5, -4);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec3(-9, -9, 7);
            var v1 = new ivec3(0, 0, 2);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec3(-6, 0, -5);
            var v1 = new ivec3(4, 1, 7);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec3(9, -7, -2);
            var v1 = new ivec3(6, 0, 1);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec3(-2, 2, -8);
            var v1 = new ivec3(9, 0, 2);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new ivec3(-7, -1, -2);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec3(-5, -2, 3);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec3(-5, -1, 8);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec3(-6, -4, 4);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec3(4, 1, 0);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec3(-4, 7, -1);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec3(-9, 5, -6);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec3(-2, 4, -9);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec3(-2, 5, 6);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec3(3, 7, -7);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void InvariantCrossDot()
    {
        {
            var v0 = new ivec3(-3, -1, -3);
            var v1 = new ivec3(3, 0, 2);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new ivec3(6, -4, 8);
            var v1 = new ivec3(0, 3, 7);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new ivec3(6, 5, 3);
            var v1 = new ivec3(-4, -5, -9);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new ivec3(-2, -9, -6);
            var v1 = new ivec3(1, -4, -9);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new ivec3(8, 0, 0);
            var v1 = new ivec3(1, 5, -6);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new ivec3(-3, -9, -4);
            var v1 = new ivec3(4, 5, -4);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new ivec3(-6, -6, -5);
            var v1 = new ivec3(7, -9, 0);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new ivec3(6, 8, 1);
            var v1 = new ivec3(7, -2, -5);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new ivec3(-1, 5, 3);
            var v1 = new ivec3(8, -9, 4);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new ivec3(-3, -1, -6);
            var v1 = new ivec3(-4, -5, -9);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(1491592823);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec3.Random(random, (-5), (-3));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-4.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-4.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-4.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.25).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(1953282783);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec3.RandomUniform(random, (-2), (1));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-1).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.6666666666666666).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(2093371764);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec3.Random(random, (0), (3));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.6666666666666666).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(1416108242);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec3.RandomUniform(random, (2), (5));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.6666666666666666).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(1404096691);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec3.Random(random, (-3), (1));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-1.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.25).Within(3.0));
    }

    [Test]
    public void RandomPoisson0()
    {
        var random = new Random(764975843);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec3.RandomPoisson(random, 0.9911269771359521);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.9911269771359521).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.9911269771359521).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.9911269771359521).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.9911269771359521).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.9911269771359521).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.9911269771359521).Within(3.0));
    }

    [Test]
    public void RandomPoisson1()
    {
        var random = new Random(1036811825);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec3.RandomPoisson(random, 0.7209417681307261);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.7209417681307261).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.7209417681307261).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.7209417681307261).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.7209417681307261).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.7209417681307261).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.7209417681307261).Within(3.0));
    }

    [Test]
    public void RandomPoisson2()
    {
        var random = new Random(1543886198);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec3.RandomPoisson(random, 2.1640926909931437);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.1640926909931437).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.1640926909931437).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2.1640926909931437).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.1640926909931437).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.1640926909931437).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.1640926909931437).Within(3.0));
    }

    [Test]
    public void RandomPoisson3()
    {
        var random = new Random(843116525);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec3.RandomPoisson(random, 3.3753025018960714);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.3753025018960714).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.3753025018960714).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3.3753025018960714).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.3753025018960714).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.3753025018960714).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(3.3753025018960714).Within(3.0));
    }

    [Test]
    public void RandomPoisson4()
    {
        var random = new Random(802228744);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec3.RandomPoisson(random, 1.4812614573078515);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.4812614573078515).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.4812614573078515).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.4812614573078515).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.4812614573078515).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.4812614573078515).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.4812614573078515).Within(3.0));
    }

}
