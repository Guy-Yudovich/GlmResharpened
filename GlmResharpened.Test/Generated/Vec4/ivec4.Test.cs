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
public class IntVec4Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new ivec4(1);
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(1, Is.EqualTo(v.z));
            Assert.That(1, Is.EqualTo(v.w));
        }
        {
            var v = new ivec4(2, -7, -5, 7);
            Assert.That(2, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-5, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var v = new ivec4(new ivec2(1, -2));
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(-2, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var v = new ivec4(new ivec3(4, -8, 3));
            Assert.That(4, Is.EqualTo(v.x));
            Assert.That(-8, Is.EqualTo(v.y));
            Assert.That(3, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var v = new ivec4(new ivec4(1, 1, -9, 2));
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(1, Is.EqualTo(v.y));
            Assert.That(-9, Is.EqualTo(v.z));
            Assert.That(2, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new ivec4(7, -5, 7, -4);
        Assert.That(7, Is.EqualTo(v[0]));
        Assert.That(-5, Is.EqualTo(v[1]));
        Assert.That(7, Is.EqualTo(v[2]));
        Assert.That(-4, Is.EqualTo(v[3]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0; } );
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
        v[1] = 3;
        Assert.That(3, Is.EqualTo(v[1]));
        v[0] = 4;
        Assert.That(4, Is.EqualTo(v[0]));
        v[3] = 5;
        Assert.That(5, Is.EqualTo(v[3]));
        v[3] = 6;
        Assert.That(6, Is.EqualTo(v[3]));
        v[0] = 7;
        Assert.That(7, Is.EqualTo(v[0]));
        v[2] = 8;
        Assert.That(8, Is.EqualTo(v[2]));
        v[3] = 9;
        Assert.That(9, Is.EqualTo(v[3]));
        v[2] = -1;
        Assert.That(-1, Is.EqualTo(v[2]));
        v[3] = -2;
        Assert.That(-2, Is.EqualTo(v[3]));
        v[1] = -3;
        Assert.That(-3, Is.EqualTo(v[1]));
        v[0] = -4;
        Assert.That(-4, Is.EqualTo(v[0]));
        v[3] = -5;
        Assert.That(-5, Is.EqualTo(v[3]));
        v[0] = -6;
        Assert.That(-6, Is.EqualTo(v[0]));
        v[1] = -7;
        Assert.That(-7, Is.EqualTo(v[1]));
        v[2] = -8;
        Assert.That(-8, Is.EqualTo(v[2]));
        v[1] = -9;
        Assert.That(-9, Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new ivec4(4, -9, 4, 3);
        var vals = v.Values;
        Assert.That(4, Is.EqualTo(vals[0]));
        Assert.That(-9, Is.EqualTo(vals[1]));
        Assert.That(4, Is.EqualTo(vals[2]));
        Assert.That(3, Is.EqualTo(vals[3]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0, Is.EqualTo(ivec4.Zero.x));
        Assert.That(0, Is.EqualTo(ivec4.Zero.y));
        Assert.That(0, Is.EqualTo(ivec4.Zero.z));
        Assert.That(0, Is.EqualTo(ivec4.Zero.w));
        
        Assert.That(1, Is.EqualTo(ivec4.Ones.x));
        Assert.That(1, Is.EqualTo(ivec4.Ones.y));
        Assert.That(1, Is.EqualTo(ivec4.Ones.z));
        Assert.That(1, Is.EqualTo(ivec4.Ones.w));
        
        Assert.That(1, Is.EqualTo(ivec4.UnitX.x));
        Assert.That(0, Is.EqualTo(ivec4.UnitX.y));
        Assert.That(0, Is.EqualTo(ivec4.UnitX.z));
        Assert.That(0, Is.EqualTo(ivec4.UnitX.w));
        
        Assert.That(0, Is.EqualTo(ivec4.UnitY.x));
        Assert.That(1, Is.EqualTo(ivec4.UnitY.y));
        Assert.That(0, Is.EqualTo(ivec4.UnitY.z));
        Assert.That(0, Is.EqualTo(ivec4.UnitY.w));
        
        Assert.That(0, Is.EqualTo(ivec4.UnitZ.x));
        Assert.That(0, Is.EqualTo(ivec4.UnitZ.y));
        Assert.That(1, Is.EqualTo(ivec4.UnitZ.z));
        Assert.That(0, Is.EqualTo(ivec4.UnitZ.w));
        
        Assert.That(0, Is.EqualTo(ivec4.UnitW.x));
        Assert.That(0, Is.EqualTo(ivec4.UnitW.y));
        Assert.That(0, Is.EqualTo(ivec4.UnitW.z));
        Assert.That(1, Is.EqualTo(ivec4.UnitW.w));
        
        Assert.That(int.MaxValue, Is.EqualTo(ivec4.MaxValue.x));
        Assert.That(int.MaxValue, Is.EqualTo(ivec4.MaxValue.y));
        Assert.That(int.MaxValue, Is.EqualTo(ivec4.MaxValue.z));
        Assert.That(int.MaxValue, Is.EqualTo(ivec4.MaxValue.w));
        
        Assert.That(int.MinValue, Is.EqualTo(ivec4.MinValue.x));
        Assert.That(int.MinValue, Is.EqualTo(ivec4.MinValue.y));
        Assert.That(int.MinValue, Is.EqualTo(ivec4.MinValue.z));
        Assert.That(int.MinValue, Is.EqualTo(ivec4.MinValue.w));
    }

    [Test]
    public void Operators()
    {
        var v1 = new ivec4(0, -9, 8, 2);
        var v2 = new ivec4(0, -9, 8, 2);
        var v3 = new ivec4(2, 8, -9, 0);
        Assert.That(v1 == new ivec4(v1));
        Assert.That(v2 == new ivec4(v2));
        Assert.That(v3 == new ivec4(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new ivec4(0, -4, -7, 9);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = ivec4.Parse(s0);
        var v1 = ivec4.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = ivec4.TryParse(s0, out v0);
        var b1 = ivec4.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = ivec4.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = ivec4.TryParse("", out v0);
        Assert.That(!b0);
        b0 = ivec4.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { ivec4.Parse(null); });
        Assert.Throws<FormatException>(() => { ivec4.Parse(""); });
        Assert.Throws<FormatException>(() => { ivec4.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = ivec4.Parse(s3, "; ", NumberStyles.Number);
        var v4 = ivec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = ivec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new ivec4(-3, 4, 0, -2);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<ivec4>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new ivec4(-3, -4, -5, -1);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(-3, 9, -5, -6);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(1, 6, -9, -5);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(-1, 2, -7, -9);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(-3, 0, -3, 6);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(-3, 3, 5, 4);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(0, -7, -3, 3);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(-8, 4, 0, -6);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(8, 0, 9, -1);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(-4, 2, 5, 3);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new ivec4(-1, 4, -3, -4);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(-9, -3, 7, -7);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(4, -7, -1, -2);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(1, -6, -8, 1);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(-5, 1, -5, 7);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(-9, -8, -8, -7);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(-7, 7, 8, 0);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(-5, 9, -3, 1);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(-6, -1, -5, -5);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(7, -5, -9, -3);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new ivec4(8, -5, -9, 9);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(-9, 6, 4, 2);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(3, -4, 3, 0);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(8, -6, 2, -6);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(1, -2, 4, -8);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(1, 3, 6, 8);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(-3, -8, 4, 0);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(8, -5, 9, 5);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(8, 2, -4, 7);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(-4, 8, 4, -8);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new ivec4(6, 6, -6, -8);
            var v1 = new ivec4(-1, -2, -4, -8);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(4, -3, -9, -5);
            var v1 = new ivec4(-4, 7, 9, -2);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(-6, -1, -5, -6);
            var v1 = new ivec4(8, -6, -8, -6);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(-8, -8, 4, 4);
            var v1 = new ivec4(-4, 3, -1, -4);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(-1, -8, -8, -8);
            var v1 = new ivec4(-3, -7, 2, -8);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(-8, 7, -2, -9);
            var v1 = new ivec4(-3, -1, -1, 8);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(-4, 7, -3, 5);
            var v1 = new ivec4(3, 8, 2, -1);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(7, 0, -9, -3);
            var v1 = new ivec4(7, 9, 4, 0);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(2, 4, 4, -5);
            var v1 = new ivec4(8, -1, -8, -9);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(7, -6, -8, 1);
            var v1 = new ivec4(3, -9, 2, 7);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new ivec4(2, -7, 0, 8);
            var v1 = new ivec4(4, 1, -9, 1);
            var v2 = new ivec4(1, -3, 1, 7);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(-2, 8, 2, 3);
            var v1 = new ivec4(0, -8, 1, 6);
            var v2 = new ivec4(-8, 7, -9, 9);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(7, 3, -5, 9);
            var v1 = new ivec4(-3, 0, -3, 8);
            var v2 = new ivec4(-3, -4, 6, 0);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(9, 2, 0, 2);
            var v1 = new ivec4(8, -5, -9, 8);
            var v2 = new ivec4(1, 3, -6, 1);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(3, 5, 5, 4);
            var v1 = new ivec4(-5, -6, 7, -5);
            var v2 = new ivec4(-8, 9, 0, 0);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(6, 8, 7, 0);
            var v1 = new ivec4(-9, -2, -4, -7);
            var v2 = new ivec4(1, 2, -4, -7);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(-8, -9, -8, 2);
            var v1 = new ivec4(8, -1, 8, 4);
            var v2 = new ivec4(7, -3, 5, 7);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(-4, 8, -3, -6);
            var v1 = new ivec4(5, -2, 1, -9);
            var v2 = new ivec4(1, -9, -5, -9);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(6, -8, 8, 8);
            var v1 = new ivec4(9, -8, -9, 1);
            var v2 = new ivec4(-1, 8, 5, -6);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(-8, 4, 5, 7);
            var v1 = new ivec4(1, -6, -3, -4);
            var v2 = new ivec4(2, 0, 5, -1);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new ivec4(-2, -9, 1, 1);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(-2, 3, -6, -6);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(9, -3, 1, -6);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(4, 8, -4, 9);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(-7, 3, 7, -3);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(-3, 8, 0, 2);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(-4, -3, -7, 2);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(-1, 6, 5, -9);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(-7, 9, 1, 1);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(3, 8, 0, -1);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new ivec4(0, -9, 6, 9);
            var v1 = new ivec4(7, -4, -2, -7);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(-6, -9, -8, 8);
            var v1 = new ivec4(-9, 4, -7, -1);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(8, 2, 7, 9);
            var v1 = new ivec4(1, 3, -4, 6);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(3, 4, 4, -7);
            var v1 = new ivec4(2, -7, 8, -7);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(-4, 0, 6, 2);
            var v1 = new ivec4(-6, 5, 4, -2);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(2, 1, 7, -7);
            var v1 = new ivec4(-5, -2, -2, 4);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(-2, -8, 8, -8);
            var v1 = new ivec4(-9, 8, -8, -6);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(5, 0, 5, 3);
            var v1 = new ivec4(8, -4, -4, -8);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(9, 1, -5, -9);
            var v1 = new ivec4(-8, -4, -4, 2);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(-8, -5, 6, 0);
            var v1 = new ivec4(-6, -7, -2, -1);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new ivec4(7, -5, 4, 9);
            var v1 = new ivec4(-8, 6, 3, -2);
            var v2 = new ivec4(8, 2, -5, -8);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(-1, 7, -6, -3);
            var v1 = new ivec4(-7, 5, -7, 8);
            var v2 = new ivec4(6, 4, -7, -3);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(8, 9, -5, 6);
            var v1 = new ivec4(5, 7, 4, -7);
            var v2 = new ivec4(-6, -3, -9, -3);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(0, 5, -2, -3);
            var v1 = new ivec4(7, -4, 8, 8);
            var v2 = new ivec4(-2, 5, -8, 9);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(4, 8, 5, 1);
            var v1 = new ivec4(-4, -4, -6, 3);
            var v2 = new ivec4(-8, -1, 0, 7);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(-1, -7, 5, 1);
            var v1 = new ivec4(-7, -7, 2, -8);
            var v2 = new ivec4(7, 2, -2, -2);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(-3, 4, 0, -3);
            var v1 = new ivec4(-5, 8, 1, 2);
            var v2 = new ivec4(-2, 5, 1, -7);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(2, 3, 3, 1);
            var v1 = new ivec4(-6, -6, -5, 9);
            var v2 = new ivec4(4, 3, 1, 9);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(8, 7, -1, -4);
            var v1 = new ivec4(3, 0, 1, 2);
            var v2 = new ivec4(-6, -3, 7, 9);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(-4, 3, 7, 8);
            var v1 = new ivec4(8, -7, -6, 5);
            var v2 = new ivec4(-6, 7, -9, -3);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new ivec4(-7, -6, -1, -6);
            var v1 = new ivec4(-3, -6, -3, 1);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(-4, -1, 3, 0);
            var v1 = new ivec4(1, 8, -5, -2);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(3, 2, 7, -7);
            var v1 = new ivec4(2, -6, 8, -2);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(2, 7, 4, 1);
            var v1 = new ivec4(6, -8, 9, 6);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(-2, 9, 1, -7);
            var v1 = new ivec4(-7, 4, 2, -7);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(7, 1, 5, 3);
            var v1 = new ivec4(-3, -8, 8, -7);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(-5, 6, -6, 7);
            var v1 = new ivec4(0, 6, 6, 0);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(7, -8, -4, 5);
            var v1 = new ivec4(-1, -2, -4, -6);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(0, -7, 7, -1);
            var v1 = new ivec4(7, -8, -5, -9);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(-9, -1, 9, 0);
            var v1 = new ivec4(-1, 4, -9, 4);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new ivec4(3, -8, -2, -5);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(9, -4, -9, 4);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(-3, 0, -1, -6);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(4, -5, -9, 0);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(-7, -7, 6, 1);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(9, 7, 0, -3);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(5, -9, 9, 2);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(8, -4, -1, -7);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(-3, 0, 3, 3);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(-6, 0, 0, 8);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(440150824);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.Random(random, (-4), (-1));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-3).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-3).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-3).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-3).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.6666666666666666).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(2125944511);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.RandomUniform(random, (4), (6));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(4.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.25).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(162099117);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.Random(random, (3), (8));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(2).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(515635405);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.RandomUniform(random, (1), (6));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(3).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(2).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(527646956);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.Random(random, (-4), (0));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-2.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-2.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-2.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-2.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.25).Within(3.0));
    }

    [Test]
    public void RandomPoisson0()
    {
        var random = new Random(1490495038);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.RandomPoisson(random, 1.1430681248396022);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.1430681248396022).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.1430681248396022).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.1430681248396022).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.1430681248396022).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.1430681248396022).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.1430681248396022).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.1430681248396022).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.1430681248396022).Within(3.0));
    }

    [Test]
    public void RandomPoisson1()
    {
        var random = new Random(894931822);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.RandomPoisson(random, 1.7132791505257035);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.7132791505257035).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.7132791505257035).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.7132791505257035).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.7132791505257035).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.7132791505257035).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.7132791505257035).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.7132791505257035).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.7132791505257035).Within(3.0));
    }

    [Test]
    public void RandomPoisson2()
    {
        var random = new Random(711584683);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.RandomPoisson(random, 2.9701024109824106);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.9701024109824106).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.9701024109824106).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2.9701024109824106).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(2.9701024109824106).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.9701024109824106).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.9701024109824106).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.9701024109824106).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(2.9701024109824106).Within(3.0));
    }

    [Test]
    public void RandomPoisson3()
    {
        var random = new Random(1412354356);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.RandomPoisson(random, 2.058918416760358);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.058918416760358).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.058918416760358).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2.058918416760358).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(2.058918416760358).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.058918416760358).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.058918416760358).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.058918416760358).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(2.058918416760358).Within(3.0));
    }

    [Test]
    public void RandomPoisson4()
    {
        var random = new Random(1453242137);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.RandomPoisson(random, 0.9529594613485781);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.9529594613485781).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.9529594613485781).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.9529594613485781).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0.9529594613485781).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.9529594613485781).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.9529594613485781).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.9529594613485781).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.9529594613485781).Within(3.0));
    }

}
