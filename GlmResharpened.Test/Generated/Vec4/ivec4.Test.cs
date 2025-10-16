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
            var v = new ivec4(6);
            Assert.That(6, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(6, Is.EqualTo(v.z));
            Assert.That(6, Is.EqualTo(v.w));
        }
        {
            var v = new ivec4(-9, -7, -2, 7);
            Assert.That(-9, Is.EqualTo(v.x));
            Assert.That(-7, Is.EqualTo(v.y));
            Assert.That(-2, Is.EqualTo(v.z));
            Assert.That(7, Is.EqualTo(v.w));
        }
        {
            var v = new ivec4(new ivec2(-6, -6));
            Assert.That(-6, Is.EqualTo(v.x));
            Assert.That(-6, Is.EqualTo(v.y));
            Assert.That(0, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var v = new ivec4(new ivec3(1, 6, -8));
            Assert.That(1, Is.EqualTo(v.x));
            Assert.That(6, Is.EqualTo(v.y));
            Assert.That(-8, Is.EqualTo(v.z));
            Assert.That(0, Is.EqualTo(v.w));
        }
        {
            var v = new ivec4(new ivec4(-2, -1, 8, -1));
            Assert.That(-2, Is.EqualTo(v.x));
            Assert.That(-1, Is.EqualTo(v.y));
            Assert.That(8, Is.EqualTo(v.z));
            Assert.That(-1, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new ivec4(0, 6, 5, 4);
        Assert.That(0, Is.EqualTo(v[0]));
        Assert.That(6, Is.EqualTo(v[1]));
        Assert.That(5, Is.EqualTo(v[2]));
        Assert.That(4, Is.EqualTo(v[3]));
        
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
        
        v[2] = 0;
        Assert.That(0, Is.EqualTo(v[2]));
        v[2] = 1;
        Assert.That(1, Is.EqualTo(v[2]));
        v[3] = 2;
        Assert.That(2, Is.EqualTo(v[3]));
        v[1] = 3;
        Assert.That(3, Is.EqualTo(v[1]));
        v[0] = 4;
        Assert.That(4, Is.EqualTo(v[0]));
        v[2] = 5;
        Assert.That(5, Is.EqualTo(v[2]));
        v[0] = 6;
        Assert.That(6, Is.EqualTo(v[0]));
        v[0] = 7;
        Assert.That(7, Is.EqualTo(v[0]));
        v[0] = 8;
        Assert.That(8, Is.EqualTo(v[0]));
        v[0] = 9;
        Assert.That(9, Is.EqualTo(v[0]));
        v[0] = -1;
        Assert.That(-1, Is.EqualTo(v[0]));
        v[3] = -2;
        Assert.That(-2, Is.EqualTo(v[3]));
        v[3] = -3;
        Assert.That(-3, Is.EqualTo(v[3]));
        v[3] = -4;
        Assert.That(-4, Is.EqualTo(v[3]));
        v[0] = -5;
        Assert.That(-5, Is.EqualTo(v[0]));
        v[1] = -6;
        Assert.That(-6, Is.EqualTo(v[1]));
        v[1] = -7;
        Assert.That(-7, Is.EqualTo(v[1]));
        v[1] = -8;
        Assert.That(-8, Is.EqualTo(v[1]));
        v[1] = -9;
        Assert.That(-9, Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new ivec4(-9, 7, 9, 7);
        var vals = v.Values;
        Assert.That(-9, Is.EqualTo(vals[0]));
        Assert.That(7, Is.EqualTo(vals[1]));
        Assert.That(9, Is.EqualTo(vals[2]));
        Assert.That(7, Is.EqualTo(vals[3]));
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
        var v1 = new ivec4(-8, -3, 5, -9);
        var v2 = new ivec4(-8, -3, 5, -9);
        var v3 = new ivec4(-9, 5, -3, -8);
        Assert.That((v1 == new ivec4(v1)).AllTrue);
        Assert.That((v2 == new ivec4(v2)).AllTrue);
        Assert.That((v3 == new ivec4(v3)).AllTrue);
        Assert.That((v1 == v2).AllTrue);
        Assert.That((v1 != v3).AllTrue);
        Assert.That((v2 != v3).AllTrue);
    }

    [Test]
    public void StringInterop()
    {
        var v = new ivec4(8, 3, 3, 9);
        
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
        var v0 = new ivec4(-4, 3, -9, -9);
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
            var v0 = new ivec4(-9, -3, -9, 2);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(-3, -2, -7, -7);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(1, -5, 5, 2);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(-2, -1, 7, 1);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(1, -3, 6, -6);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(-8, 4, 1, -5);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(8, -3, 0, -6);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(-4, -1, -3, 5);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(-4, -7, 5, 7);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new ivec4(-1, 4, -6, 0);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new ivec4(-8, 4, -8, -1);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(7, -6, -9, -3);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(3, 8, -2, -9);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(2, -1, -5, 4);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(0, -2, 4, -7);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(6, 5, 2, -4);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(-4, 6, -7, -2);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(-8, -3, 7, 0);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(-6, 5, -6, 2);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new ivec4(3, 6, 6, -5);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new ivec4(7, -5, -3, -3);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(1, 6, 6, -6);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(-3, 3, 2, 4);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(-9, 4, 3, -9);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(-1, -5, -6, 2);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(0, -5, 6, -5);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(-7, 1, -2, -6);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(1, -7, -9, 8);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(-9, -9, 9, 8);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new ivec4(-5, 3, -6, 3);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new ivec4(-1, -6, 0, 0);
            var v1 = new ivec4(-9, 4, -5, -8);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(6, -8, 1, -3);
            var v1 = new ivec4(1, 7, -3, 0);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(-6, 3, -8, -2);
            var v1 = new ivec4(-8, -2, 9, 9);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(1, 6, -5, 1);
            var v1 = new ivec4(5, -6, -1, 3);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(-6, -9, 7, -4);
            var v1 = new ivec4(3, -2, -3, -1);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(5, -3, -7, -1);
            var v1 = new ivec4(-6, 2, -4, 6);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(-5, -8, 0, 6);
            var v1 = new ivec4(-6, -8, 9, -8);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(5, 9, -8, -3);
            var v1 = new ivec4(8, -4, -2, 9);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(6, -7, -7, 2);
            var v1 = new ivec4(-9, -8, -7, 3);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new ivec4(9, 7, 5, 4);
            var v1 = new ivec4(-5, -8, -4, -8);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new ivec4(4, 3, 3, 6);
            var v1 = new ivec4(-3, -6, 5, 8);
            var v2 = new ivec4(7, -3, -7, 0);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(-7, 7, -1, -6);
            var v1 = new ivec4(6, 8, 0, 6);
            var v2 = new ivec4(-8, -3, 5, -1);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(6, -2, -2, -3);
            var v1 = new ivec4(1, 0, 9, 8);
            var v2 = new ivec4(0, -8, 9, -5);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(-5, -8, 5, -5);
            var v1 = new ivec4(-3, -3, -9, 0);
            var v2 = new ivec4(2, -9, -6, -2);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(-4, 3, 2, -1);
            var v1 = new ivec4(2, -2, 4, -2);
            var v2 = new ivec4(-7, -2, -9, 0);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(3, -2, 6, 6);
            var v1 = new ivec4(3, 7, 0, -9);
            var v2 = new ivec4(-8, -6, 0, 8);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(3, 4, -3, 5);
            var v1 = new ivec4(-4, 5, 7, 7);
            var v2 = new ivec4(-6, 0, -9, -7);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(-8, -9, 5, 7);
            var v1 = new ivec4(-3, -7, -8, 3);
            var v2 = new ivec4(-8, 4, -1, 1);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(5, -2, -7, -4);
            var v1 = new ivec4(-8, -7, -3, -8);
            var v2 = new ivec4(3, -4, 7, -8);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new ivec4(-8, -9, -8, -1);
            var v1 = new ivec4(3, -2, 4, 3);
            var v2 = new ivec4(-3, 8, 8, 3);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new ivec4(-8, 1, 4, 6);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(7, 8, -1, -2);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(-3, -7, -4, 3);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(-9, 5, -4, 0);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(-6, 5, -7, -6);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(4, -7, 0, -1);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(-2, -8, 9, -6);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(1, 1, -2, -4);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(8, -3, 9, 0);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new ivec4(2, -1, 2, -5);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new ivec4(-9, -6, -8, -4);
            var v1 = new ivec4(3, 9, 7, 3);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(-4, 5, 0, 4);
            var v1 = new ivec4(0, -8, 3, 5);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(7, 0, 4, -8);
            var v1 = new ivec4(-6, 4, 4, -4);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(7, -2, -2, -1);
            var v1 = new ivec4(-1, -1, -3, 8);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(8, 0, 9, 4);
            var v1 = new ivec4(-2, -2, 9, -9);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(4, 4, 3, -9);
            var v1 = new ivec4(-9, 7, -6, 3);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(4, 0, -8, -9);
            var v1 = new ivec4(-5, 3, -5, -5);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(-1, 4, 5, -1);
            var v1 = new ivec4(-7, -6, -2, 3);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(-3, -1, -5, -9);
            var v1 = new ivec4(8, -8, -4, -6);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new ivec4(9, 4, -3, -1);
            var v1 = new ivec4(0, 4, -5, 0);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new ivec4(8, 5, 8, 5);
            var v1 = new ivec4(-2, 5, 9, -1);
            var v2 = new ivec4(-7, -1, -7, 2);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(-1, 6, -2, -9);
            var v1 = new ivec4(-6, -1, -2, -5);
            var v2 = new ivec4(-2, -3, 8, 9);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(-8, 1, -6, 4);
            var v1 = new ivec4(7, -9, 1, -4);
            var v2 = new ivec4(-1, 4, -4, 1);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(-8, 5, -5, 3);
            var v1 = new ivec4(-4, -6, -4, 4);
            var v2 = new ivec4(6, -3, 1, 5);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(-5, 6, 2, 0);
            var v1 = new ivec4(3, -8, -3, -5);
            var v2 = new ivec4(-7, -9, 6, -1);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(8, 5, 2, -7);
            var v1 = new ivec4(8, 2, -1, 5);
            var v2 = new ivec4(-3, -1, 0, -1);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(-6, 8, 1, -5);
            var v1 = new ivec4(-9, 3, 3, 5);
            var v2 = new ivec4(-9, 9, 8, 1);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(-7, 1, 9, -3);
            var v1 = new ivec4(-1, -8, 4, -9);
            var v2 = new ivec4(-8, 3, -4, 8);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(-3, -6, -6, 3);
            var v1 = new ivec4(1, -5, -3, 4);
            var v2 = new ivec4(5, -1, 4, -5);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new ivec4(-6, -8, -6, -3);
            var v1 = new ivec4(-6, 1, -1, -9);
            var v2 = new ivec4(-6, 1, 0, 7);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new ivec4(-9, -5, 1, 3);
            var v1 = new ivec4(-4, -9, 1, -7);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(2, -3, 0, -8);
            var v1 = new ivec4(9, -7, 7, 1);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(-4, 0, 2, -5);
            var v1 = new ivec4(-3, -2, -1, 5);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(-5, -5, 5, 4);
            var v1 = new ivec4(3, -8, -5, 4);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(6, 9, 5, -8);
            var v1 = new ivec4(-4, -1, 9, 3);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(5, -7, -3, 0);
            var v1 = new ivec4(3, 1, -9, -1);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(-9, -5, -9, 1);
            var v1 = new ivec4(-5, 0, -7, 7);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(3, -5, 8, -8);
            var v1 = new ivec4(-4, -7, -4, 4);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(-7, -6, -2, 0);
            var v1 = new ivec4(-2, 8, 6, 2);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new ivec4(-1, -9, 9, -5);
            var v1 = new ivec4(-8, 9, 2, -3);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new ivec4(-4, 0, -9, -9);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(-7, -4, -1, -1);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(-1, 9, -5, -7);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(6, -3, -9, 8);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(8, -6, 9, 2);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(6, 9, -7, 1);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(-2, 3, -4, 6);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(-4, -4, -2, 2);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(-5, -3, 6, 3);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new ivec4(-9, -2, -3, -8);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(2651432);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.Random(random, (1), (3));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.25).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.25).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(799899654);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.RandomUniform(random, (4), (7));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.6666666666666666).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.6666666666666666).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(1843425941);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.Random(random, (-1), (4));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(2).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(1261309945);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.RandomUniform(random, (-5), (-1));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-3.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-3.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-3.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-3.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.25).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.25).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(852878627);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.Random(random, (-2), (3));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(2).Within(3.0));
    }

    [Test]
    public void RandomPoisson0()
    {
        var random = new Random(44602534);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.RandomPoisson(random, 1.4354035565328802);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.4354035565328802).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.4354035565328802).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.4354035565328802).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.4354035565328802).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.4354035565328802).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.4354035565328802).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.4354035565328802).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.4354035565328802).Within(3.0));
    }

    [Test]
    public void RandomPoisson1()
    {
        var random = new Random(1707509627);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.RandomPoisson(random, 2.1746145247829216);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.1746145247829216).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.1746145247829216).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2.1746145247829216).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(2.1746145247829216).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.1746145247829216).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.1746145247829216).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.1746145247829216).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(2.1746145247829216).Within(3.0));
    }

    [Test]
    public void RandomPoisson2()
    {
        var random = new Random(2075086999);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.RandomPoisson(random, 1.1843904450928748);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.1843904450928748).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.1843904450928748).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.1843904450928748).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.1843904450928748).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.1843904450928748).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.1843904450928748).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.1843904450928748).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.1843904450928748).Within(3.0));
    }

    [Test]
    public void RandomPoisson3()
    {
        var random = new Random(148838380);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.RandomPoisson(random, 1.514132067102069);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.514132067102069).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.514132067102069).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.514132067102069).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.514132067102069).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.514132067102069).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.514132067102069).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.514132067102069).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.514132067102069).Within(3.0));
    }

    [Test]
    public void RandomPoisson4()
    {
        var random = new Random(1966763786);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = ivec4.RandomPoisson(random, 2.525152443454206);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.525152443454206).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.525152443454206).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2.525152443454206).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(2.525152443454206).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.525152443454206).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.525152443454206).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.525152443454206).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(2.525152443454206).Within(3.0));
    }

}
