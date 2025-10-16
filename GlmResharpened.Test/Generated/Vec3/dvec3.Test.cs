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
public class DoubleVec3Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new dvec3(-1.5d);
            Assert.That(-1.5d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(-1.5d, Is.EqualTo(v.z));
        }
        {
            var v = new dvec3(-7d, -3d, 1.0);
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(1.0, Is.EqualTo(v.z));
        }
        {
            var v = new dvec3(new dvec2(-7.5d, -1.5d));
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(-1.5d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
        }
        {
            var v = new dvec3(new dvec3(1.5d, 7d, -4.5d));
            Assert.That(1.5d, Is.EqualTo(v.x));
            Assert.That(7d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
        }
        {
            var v = new dvec3(new dvec4(6d, -6d, 5d, -4d));
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new dvec3(-6d, 0.5d, 0.5d);
        Assert.That(-6d, Is.EqualTo(v[0]));
        Assert.That(0.5d, Is.EqualTo(v[1]));
        Assert.That(0.5d, Is.EqualTo(v[2]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0.0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0.0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0.0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0.0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0.0; } );
        
        v[2] = 0.0;
        Assert.That(0.0, Is.EqualTo(v[2]));
        v[2] = 1.0;
        Assert.That(1.0, Is.EqualTo(v[2]));
        v[1] = 2d;
        Assert.That(2d, Is.EqualTo(v[1]));
        v[2] = 3d;
        Assert.That(3d, Is.EqualTo(v[2]));
        v[1] = 4d;
        Assert.That(4d, Is.EqualTo(v[1]));
        v[0] = 5d;
        Assert.That(5d, Is.EqualTo(v[0]));
        v[2] = 6d;
        Assert.That(6d, Is.EqualTo(v[2]));
        v[2] = 7d;
        Assert.That(7d, Is.EqualTo(v[2]));
        v[2] = 8d;
        Assert.That(8d, Is.EqualTo(v[2]));
        v[2] = 9d;
        Assert.That(9d, Is.EqualTo(v[2]));
        v[0] = -1d;
        Assert.That(-1d, Is.EqualTo(v[0]));
        v[2] = -2d;
        Assert.That(-2d, Is.EqualTo(v[2]));
        v[2] = -3d;
        Assert.That(-3d, Is.EqualTo(v[2]));
        v[0] = -4d;
        Assert.That(-4d, Is.EqualTo(v[0]));
        v[2] = -5d;
        Assert.That(-5d, Is.EqualTo(v[2]));
        v[2] = -6d;
        Assert.That(-6d, Is.EqualTo(v[2]));
        v[2] = -7d;
        Assert.That(-7d, Is.EqualTo(v[2]));
        v[2] = -8d;
        Assert.That(-8d, Is.EqualTo(v[2]));
        v[1] = -9d;
        Assert.That(-9d, Is.EqualTo(v[1]));
        v[1] = -9.5d;
        Assert.That(-9.5d, Is.EqualTo(v[1]));
        v[2] = -8.5d;
        Assert.That(-8.5d, Is.EqualTo(v[2]));
        v[2] = -7.5d;
        Assert.That(-7.5d, Is.EqualTo(v[2]));
        v[1] = -6.5d;
        Assert.That(-6.5d, Is.EqualTo(v[1]));
        v[2] = -5.5d;
        Assert.That(-5.5d, Is.EqualTo(v[2]));
        v[1] = -4.5d;
        Assert.That(-4.5d, Is.EqualTo(v[1]));
        v[1] = -3.5d;
        Assert.That(-3.5d, Is.EqualTo(v[1]));
        v[1] = -2.5d;
        Assert.That(-2.5d, Is.EqualTo(v[1]));
        v[0] = -1.5d;
        Assert.That(-1.5d, Is.EqualTo(v[0]));
        v[1] = -0.5d;
        Assert.That(-0.5d, Is.EqualTo(v[1]));
        v[1] = 0.5d;
        Assert.That(0.5d, Is.EqualTo(v[1]));
        v[2] = 1.5d;
        Assert.That(1.5d, Is.EqualTo(v[2]));
        v[2] = 2.5d;
        Assert.That(2.5d, Is.EqualTo(v[2]));
        v[2] = 3.5d;
        Assert.That(3.5d, Is.EqualTo(v[2]));
        v[1] = 4.5d;
        Assert.That(4.5d, Is.EqualTo(v[1]));
        v[1] = 5.5d;
        Assert.That(5.5d, Is.EqualTo(v[1]));
        v[0] = 6.5d;
        Assert.That(6.5d, Is.EqualTo(v[0]));
        v[0] = 7.5d;
        Assert.That(7.5d, Is.EqualTo(v[0]));
        v[2] = 8.5d;
        Assert.That(8.5d, Is.EqualTo(v[2]));
        v[2] = 9.5d;
        Assert.That(9.5d, Is.EqualTo(v[2]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new dvec3(-5.5d, 7.5d, 2d);
        var vals = v.Values;
        Assert.That(-5.5d, Is.EqualTo(vals[0]));
        Assert.That(7.5d, Is.EqualTo(vals[1]));
        Assert.That(2d, Is.EqualTo(vals[2]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0.0, Is.EqualTo(dvec3.Zero.x));
        Assert.That(0.0, Is.EqualTo(dvec3.Zero.y));
        Assert.That(0.0, Is.EqualTo(dvec3.Zero.z));
        
        Assert.That(1.0, Is.EqualTo(dvec3.Ones.x));
        Assert.That(1.0, Is.EqualTo(dvec3.Ones.y));
        Assert.That(1.0, Is.EqualTo(dvec3.Ones.z));
        
        Assert.That(1.0, Is.EqualTo(dvec3.UnitX.x));
        Assert.That(0.0, Is.EqualTo(dvec3.UnitX.y));
        Assert.That(0.0, Is.EqualTo(dvec3.UnitX.z));
        
        Assert.That(0.0, Is.EqualTo(dvec3.UnitY.x));
        Assert.That(1.0, Is.EqualTo(dvec3.UnitY.y));
        Assert.That(0.0, Is.EqualTo(dvec3.UnitY.z));
        
        Assert.That(0.0, Is.EqualTo(dvec3.UnitZ.x));
        Assert.That(0.0, Is.EqualTo(dvec3.UnitZ.y));
        Assert.That(1.0, Is.EqualTo(dvec3.UnitZ.z));
        
        Assert.That(double.MaxValue, Is.EqualTo(dvec3.MaxValue.x));
        Assert.That(double.MaxValue, Is.EqualTo(dvec3.MaxValue.y));
        Assert.That(double.MaxValue, Is.EqualTo(dvec3.MaxValue.z));
        
        Assert.That(double.MinValue, Is.EqualTo(dvec3.MinValue.x));
        Assert.That(double.MinValue, Is.EqualTo(dvec3.MinValue.y));
        Assert.That(double.MinValue, Is.EqualTo(dvec3.MinValue.z));
        
        Assert.That(double.Epsilon, Is.EqualTo(dvec3.Epsilon.x));
        Assert.That(double.Epsilon, Is.EqualTo(dvec3.Epsilon.y));
        Assert.That(double.Epsilon, Is.EqualTo(dvec3.Epsilon.z));
        
        Assert.That(double.NaN, Is.EqualTo(dvec3.NaN.x));
        Assert.That(double.NaN, Is.EqualTo(dvec3.NaN.y));
        Assert.That(double.NaN, Is.EqualTo(dvec3.NaN.z));
        
        Assert.That(double.NegativeInfinity, Is.EqualTo(dvec3.NegativeInfinity.x));
        Assert.That(double.NegativeInfinity, Is.EqualTo(dvec3.NegativeInfinity.y));
        Assert.That(double.NegativeInfinity, Is.EqualTo(dvec3.NegativeInfinity.z));
        
        Assert.That(double.PositiveInfinity, Is.EqualTo(dvec3.PositiveInfinity.x));
        Assert.That(double.PositiveInfinity, Is.EqualTo(dvec3.PositiveInfinity.y));
        Assert.That(double.PositiveInfinity, Is.EqualTo(dvec3.PositiveInfinity.z));
    }

    [Test]
    public void Operators()
    {
        var v1 = new dvec3(-2d, 2d, -0.5d);
        var v2 = new dvec3(-2d, 2d, -0.5d);
        var v3 = new dvec3(-0.5d, 2d, -2d);
        Assert.That((v1 == new dvec3(v1)).AllTrue);
        Assert.That((v2 == new dvec3(v2)).AllTrue);
        Assert.That((v3 == new dvec3(v3)).AllTrue);
        Assert.That((v1 == v2).AllTrue);
        Assert.That((v1 != v3).AllTrue);
        Assert.That((v2 != v3).AllTrue);
    }

    [Test]
    public void StringInterop()
    {
        var v = new dvec3(-2.5d, -4.5d, -4d);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = dvec3.Parse(s0);
        var v1 = dvec3.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = dvec3.TryParse(s0, out v0);
        var b1 = dvec3.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = dvec3.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = dvec3.TryParse("", out v0);
        Assert.That(!b0);
        b0 = dvec3.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { dvec3.Parse(null); });
        Assert.Throws<FormatException>(() => { dvec3.Parse(""); });
        Assert.Throws<FormatException>(() => { dvec3.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = dvec3.Parse(s3, "; ", NumberStyles.Number);
        var v4 = dvec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = dvec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new dvec3(2d, -5.5d, -7d);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<dvec3>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new dvec3(-4d, 3d, -7d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(-6.5d, 3.5d, -8.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(4.5d, 9.5d, -5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(0.0, 2d, -1.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(-8.5d, -5.5d, -2d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(7.5d, -2d, -5.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(0.5d, -5d, -7d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(-8d, 2d, 4.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(7d, -8.5d, -4d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(-7.5d, -9.5d, -1.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new dvec3(-7.5d, 2.5d, -9d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(3d, 9d, 6.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(0.0, -8.5d, 4.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(8d, 3.5d, -5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(8d, -9.5d, 5.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(-6d, 2.5d, -3.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(1.5d, -3d, 4.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(1.0, 6d, -5.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(8.5d, -8d, -8.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(5.5d, 6d, -7.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new dvec3(9.5d, -4d, 8d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(8d, 6.5d, -8d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(-5d, -1.5d, -6d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(9.5d, -5d, -3.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(1.0, 7d, -3d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(5d, -4d, 2.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(-5d, -6.5d, -7.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(-8.5d, -4d, -1.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(5d, 8d, -1d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(2d, -2d, -0.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new dvec3(9.5d, 9.5d, -1d);
            var v1 = new dvec3(-9.5d, -9d, -3.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-9d, 3d, -3.5d);
            var v1 = new dvec3(-8d, -2d, -3.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-9.5d, -2d, 8.5d);
            var v1 = new dvec3(8.5d, 6d, 2.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-3.5d, -5.5d, 3d);
            var v1 = new dvec3(9d, 7.5d, -6.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(6.5d, 8.5d, 2d);
            var v1 = new dvec3(-5d, -4d, 1.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(4d, -2.5d, -0.5d);
            var v1 = new dvec3(8.5d, 7.5d, -1.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-6.5d, -7d, 9d);
            var v1 = new dvec3(4.5d, 5d, -2d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-7.5d, -4d, 9d);
            var v1 = new dvec3(-8d, -5d, -4.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-4d, 7.5d, 0.5d);
            var v1 = new dvec3(-0.5d, -4d, 5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-8.5d, -0.5d, 1.0);
            var v1 = new dvec3(-2.5d, -5.5d, -9.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new dvec3(-4.5d, -5.5d, -4.5d);
            var v1 = new dvec3(1.5d, 4.5d, -0.5d);
            var v2 = new dvec3(8d, -6.5d, -1.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(6.5d, -4.5d, -3.5d);
            var v1 = new dvec3(1.5d, -9d, -7d);
            var v2 = new dvec3(-3.5d, -8.5d, -6d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(-8d, 5.5d, -7d);
            var v1 = new dvec3(6.5d, -2d, -3.5d);
            var v2 = new dvec3(3d, -9.5d, 8.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(-6d, 4.5d, 6d);
            var v1 = new dvec3(-7d, 0.5d, -8.5d);
            var v2 = new dvec3(-0.5d, -0.5d, 6d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(4d, 8.5d, 9.5d);
            var v1 = new dvec3(3d, 8d, 9d);
            var v2 = new dvec3(4.5d, 0.0, -4d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(3.5d, 9d, -4d);
            var v1 = new dvec3(-4d, -6.5d, 7d);
            var v2 = new dvec3(7d, -0.5d, -6.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(1.0, -0.5d, -2d);
            var v1 = new dvec3(8.5d, -2.5d, -4d);
            var v2 = new dvec3(0.5d, 3.5d, -1.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(-8.5d, -9d, 4.5d);
            var v1 = new dvec3(4d, 2d, -0.5d);
            var v2 = new dvec3(9d, -8.5d, -6.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(-6d, -4d, -2.5d);
            var v1 = new dvec3(7d, 1.0, -1d);
            var v2 = new dvec3(-2d, 9d, -1d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(-5.5d, 2d, -2d);
            var v1 = new dvec3(9.5d, 8d, 0.0);
            var v2 = new dvec3(8.5d, -2.5d, 0.0);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new dvec3(-2d, -8.5d, -3.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(1.5d, -6.5d, -5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(-8.5d, -0.5d, 7.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(3d, -9d, 2.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(4.5d, -3d, -6.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(4.5d, 0.0, 8d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(-2d, -4d, -0.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(4d, 0.0, -3.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(-5d, 1.5d, 3.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(-6.5d, 3.5d, 8d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new dvec3(-5.5d, -5d, -9.5d);
            var v1 = new dvec3(-2d, 9.5d, -5.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(-7d, 2d, -8d);
            var v1 = new dvec3(3d, -1d, -4.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(4d, 4.5d, -2d);
            var v1 = new dvec3(-8d, 7d, 3d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(2.5d, -4d, -4d);
            var v1 = new dvec3(0.0, 9d, -5.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(-2.5d, 0.5d, -2d);
            var v1 = new dvec3(2.5d, 1.5d, -7d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(-0.5d, 5d, 8.5d);
            var v1 = new dvec3(9d, 9d, 2.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(-1d, -7.5d, 1.5d);
            var v1 = new dvec3(-2.5d, -1.5d, -3.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(-2d, 8.5d, 0.5d);
            var v1 = new dvec3(-8.5d, -5d, -7d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(-4.5d, -3.5d, 5.5d);
            var v1 = new dvec3(-2d, 6d, 9d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(8.5d, -5.5d, 4d);
            var v1 = new dvec3(5.5d, -4.5d, 9d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new dvec3(2d, 4.5d, 0.0);
            var v1 = new dvec3(4.5d, -7d, -5d);
            var v2 = new dvec3(-8.5d, -7d, -6.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(-3d, 3d, -8.5d);
            var v1 = new dvec3(-3.5d, -2d, -0.5d);
            var v2 = new dvec3(4d, -4.5d, -4.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(7d, 8d, 4d);
            var v1 = new dvec3(-7d, -8d, -6d);
            var v2 = new dvec3(7d, 7d, -9d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(-9d, -5.5d, 4.5d);
            var v1 = new dvec3(7d, -5d, 2d);
            var v2 = new dvec3(-7d, -9d, -3.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(-5.5d, 8d, 1.0);
            var v1 = new dvec3(5.5d, 6d, 9d);
            var v2 = new dvec3(1.5d, 9d, 5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(0.5d, -3.5d, -7.5d);
            var v1 = new dvec3(6d, 8.5d, 3d);
            var v2 = new dvec3(-6d, -6.5d, 7.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(4.5d, -3.5d, -6d);
            var v1 = new dvec3(-5.5d, -3.5d, 9d);
            var v2 = new dvec3(5.5d, 1.0, 2.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(-1.5d, 5d, -1.5d);
            var v1 = new dvec3(-9d, 8d, 3.5d);
            var v2 = new dvec3(3d, -8.5d, -7d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(-5.5d, -3d, 2d);
            var v1 = new dvec3(4.5d, -4.5d, 8d);
            var v2 = new dvec3(-1d, -7d, -8.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(7.5d, -3d, -4.5d);
            var v1 = new dvec3(1.5d, 2.5d, 1.5d);
            var v2 = new dvec3(5d, -6.5d, 2.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new dvec3(8.5d, 2d, 0.0);
            var v1 = new dvec3(-1d, -4.5d, 7d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(-2.5d, -1.5d, -9.5d);
            var v1 = new dvec3(-1.5d, -4d, 3d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(4.5d, -2.5d, -1.5d);
            var v1 = new dvec3(0.0, 3d, -7.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(4d, -4d, 0.5d);
            var v1 = new dvec3(-1d, 1.0, 1.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(5d, -3d, -1.5d);
            var v1 = new dvec3(8.5d, 6d, 2.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(4d, -8d, 0.0);
            var v1 = new dvec3(-3.5d, 3d, -6.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(1.5d, 8.5d, 1.0);
            var v1 = new dvec3(-3.5d, 7d, -1d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(3.5d, 3.5d, -1.5d);
            var v1 = new dvec3(8.5d, 9d, -4d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(1.0, 0.5d, 9d);
            var v1 = new dvec3(7d, 4d, 7d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(9.5d, -1.5d, 0.0);
            var v1 = new dvec3(9d, 5d, -2d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new dvec3(3d, 0.0, 9.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(-6.5d, -0.5d, -2d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(8d, -8d, -2.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(-1d, -5.5d, -2.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(4.5d, -4d, 3.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(-8d, -9.5d, 4d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(-2d, 1.0, 2.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(-8d, 2d, 2d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(-7.5d, 0.5d, -9d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(1.5d, 5d, -5.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void InvariantCrossDot()
    {
        {
            var v0 = new dvec3(-8d, 8.5d, 6d);
            var v1 = new dvec3(0.5d, 5d, -6d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(-1d, -2d, -1d);
            var v1 = new dvec3(-2.5d, -2d, -7d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(-6d, -8.5d, 4.5d);
            var v1 = new dvec3(-7d, -3.5d, 8d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(-6d, -3d, 0.5d);
            var v1 = new dvec3(2.5d, -1.5d, -3d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(1.0, 9d, -6.5d);
            var v1 = new dvec3(4d, 7d, -8.5d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(-8d, -1.5d, -6.5d);
            var v1 = new dvec3(-6d, 4.5d, 8.5d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(-8d, -7d, -0.5d);
            var v1 = new dvec3(5.5d, 2.5d, 8.5d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(9.5d, -9.5d, -7d);
            var v1 = new dvec3(-4.5d, -3.5d, 0.0);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(-9.5d, -1.5d, 6d);
            var v1 = new dvec3(-7.5d, 4.5d, 4d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(8d, -4.5d, 9d);
            var v1 = new dvec3(4.5d, -0.5d, 6.5d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(814014155);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.Random(random, (3), (4));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(2136020578);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomUniform(random, (-2), (2));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(507305017);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.Random(random, (-5), (-3));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-4).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-4).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-4).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(449947222);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomUniform(random, (-1), (0));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(41515904);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.Random(random, (4), (6));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomGaussian0()
    {
        var random = new Random(1562095874);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomNormal(random, 1.5269259528847998d, 5.660918758092875d);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.5269259528847998).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.5269259528847998).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.5269259528847998).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(5.660918758092875).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(5.660918758092875).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(5.660918758092875).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(753245968);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomGaussian(random, 0.2766709859839973d, 6.199561108927969d);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.2766709859839973).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.2766709859839973).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.2766709859839973).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(6.199561108927969).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(6.199561108927969).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(6.199561108927969).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(2140136630);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomNormal(random, -1.4248433352563732d, 8.29975098757993d);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.4248433352563732).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.4248433352563732).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-1.4248433352563732).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(8.29975098757993).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(8.29975098757993).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(8.29975098757993).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(1400215310);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomGaussian(random, -0.2921220372859956d, 3.381248509223223d);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.2921220372859956).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.2921220372859956).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.2921220372859956).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.381248509223223).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.381248509223223).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(3.381248509223223).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(1567050015);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomNormal(random, -1.867946250302692d, 0.920564444232995d);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.867946250302692).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.867946250302692).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-1.867946250302692).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.920564444232995).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.920564444232995).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.920564444232995).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(1688450872);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomNormal(random);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1).Within(3.0));
    }

    [Test]
    public void RandomNormal1()
    {
        var random = new Random(1202213844);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomNormal(random);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1).Within(3.0));
    }

    [Test]
    public void RandomNormal2()
    {
        var random = new Random(1488646646);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomNormal(random);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1).Within(3.0));
    }

    [Test]
    public void RandomNormal3()
    {
        var random = new Random(1026792913);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomNormal(random);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1).Within(3.0));
    }

    [Test]
    public void RandomNormal4()
    {
        var random = new Random(1509550869);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomNormal(random);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1).Within(3.0));
    }

}
