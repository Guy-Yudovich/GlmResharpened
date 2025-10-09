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
            var v = new dvec3(-4.5d);
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(-4.5d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
        }
        {
            var v = new dvec3(-7.5d, 2d, 0.5d);
            Assert.That(-7.5d, Is.EqualTo(v.x));
            Assert.That(2d, Is.EqualTo(v.y));
            Assert.That(0.5d, Is.EqualTo(v.z));
        }
        {
            var v = new dvec3(new dvec2(9d, 8.5d));
            Assert.That(9d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
        }
        {
            var v = new dvec3(new dvec3(-3.5d, 2d, -2.5d));
            Assert.That(-3.5d, Is.EqualTo(v.x));
            Assert.That(2d, Is.EqualTo(v.y));
            Assert.That(-2.5d, Is.EqualTo(v.z));
        }
        {
            var v = new dvec3(new dvec4(2.5d, 3d, 6d, -0.5d));
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(3d, Is.EqualTo(v.y));
            Assert.That(6d, Is.EqualTo(v.z));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new dvec3(-5.5d, -2d, -4d);
        Assert.That(-5.5d, Is.EqualTo(v[0]));
        Assert.That(-2d, Is.EqualTo(v[1]));
        Assert.That(-4d, Is.EqualTo(v[2]));
        
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
        
        v[1] = 0.0;
        Assert.That(0.0, Is.EqualTo(v[1]));
        v[2] = 1.0;
        Assert.That(1.0, Is.EqualTo(v[2]));
        v[2] = 2d;
        Assert.That(2d, Is.EqualTo(v[2]));
        v[1] = 3d;
        Assert.That(3d, Is.EqualTo(v[1]));
        v[0] = 4d;
        Assert.That(4d, Is.EqualTo(v[0]));
        v[1] = 5d;
        Assert.That(5d, Is.EqualTo(v[1]));
        v[0] = 6d;
        Assert.That(6d, Is.EqualTo(v[0]));
        v[2] = 7d;
        Assert.That(7d, Is.EqualTo(v[2]));
        v[2] = 8d;
        Assert.That(8d, Is.EqualTo(v[2]));
        v[1] = 9d;
        Assert.That(9d, Is.EqualTo(v[1]));
        v[2] = -1d;
        Assert.That(-1d, Is.EqualTo(v[2]));
        v[0] = -2d;
        Assert.That(-2d, Is.EqualTo(v[0]));
        v[1] = -3d;
        Assert.That(-3d, Is.EqualTo(v[1]));
        v[1] = -4d;
        Assert.That(-4d, Is.EqualTo(v[1]));
        v[1] = -5d;
        Assert.That(-5d, Is.EqualTo(v[1]));
        v[2] = -6d;
        Assert.That(-6d, Is.EqualTo(v[2]));
        v[1] = -7d;
        Assert.That(-7d, Is.EqualTo(v[1]));
        v[0] = -8d;
        Assert.That(-8d, Is.EqualTo(v[0]));
        v[0] = -9d;
        Assert.That(-9d, Is.EqualTo(v[0]));
        v[1] = -9.5d;
        Assert.That(-9.5d, Is.EqualTo(v[1]));
        v[1] = -8.5d;
        Assert.That(-8.5d, Is.EqualTo(v[1]));
        v[2] = -7.5d;
        Assert.That(-7.5d, Is.EqualTo(v[2]));
        v[2] = -6.5d;
        Assert.That(-6.5d, Is.EqualTo(v[2]));
        v[1] = -5.5d;
        Assert.That(-5.5d, Is.EqualTo(v[1]));
        v[0] = -4.5d;
        Assert.That(-4.5d, Is.EqualTo(v[0]));
        v[1] = -3.5d;
        Assert.That(-3.5d, Is.EqualTo(v[1]));
        v[2] = -2.5d;
        Assert.That(-2.5d, Is.EqualTo(v[2]));
        v[2] = -1.5d;
        Assert.That(-1.5d, Is.EqualTo(v[2]));
        v[0] = -0.5d;
        Assert.That(-0.5d, Is.EqualTo(v[0]));
        v[1] = 0.5d;
        Assert.That(0.5d, Is.EqualTo(v[1]));
        v[1] = 1.5d;
        Assert.That(1.5d, Is.EqualTo(v[1]));
        v[2] = 2.5d;
        Assert.That(2.5d, Is.EqualTo(v[2]));
        v[1] = 3.5d;
        Assert.That(3.5d, Is.EqualTo(v[1]));
        v[2] = 4.5d;
        Assert.That(4.5d, Is.EqualTo(v[2]));
        v[2] = 5.5d;
        Assert.That(5.5d, Is.EqualTo(v[2]));
        v[1] = 6.5d;
        Assert.That(6.5d, Is.EqualTo(v[1]));
        v[0] = 7.5d;
        Assert.That(7.5d, Is.EqualTo(v[0]));
        v[0] = 8.5d;
        Assert.That(8.5d, Is.EqualTo(v[0]));
        v[1] = 9.5d;
        Assert.That(9.5d, Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new dvec3(-3.5d, -9.5d, 1.0);
        var vals = v.Values;
        Assert.That(-3.5d, Is.EqualTo(vals[0]));
        Assert.That(-9.5d, Is.EqualTo(vals[1]));
        Assert.That(1.0, Is.EqualTo(vals[2]));
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
        var v1 = new dvec3(6.5d, 2.5d, 9d);
        var v2 = new dvec3(6.5d, 2.5d, 9d);
        var v3 = new dvec3(9d, 2.5d, 6.5d);
        Assert.That(v1 == new dvec3(v1));
        Assert.That(v2 == new dvec3(v2));
        Assert.That(v3 == new dvec3(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new dvec3(6.5d, 2d, 3.5d);
        
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
        var v0 = new dvec3(4d, 2.5d, 3.5d);
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
            var v0 = new dvec3(3d, -1d, -7.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(-8.5d, 2.5d, -5.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(-1.5d, 8.5d, -4d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(0.5d, 7.5d, -2.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(1.5d, -7.5d, 0.0);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(-3.5d, -2.5d, -4.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(-7d, -3d, 3.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(8d, -7d, -3.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(1.0, 1.5d, -1d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec3(-2.5d, 5.5d, 2d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new dvec3(5d, -2.5d, 4.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(-0.5d, 2.5d, -7.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(-8d, -2.5d, 8.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(-9.5d, -6.5d, -1.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(3.5d, -6d, 0.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(-6d, 0.5d, -9d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(9.5d, -7d, 1.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(5.5d, 2.5d, -7d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(3.5d, -9.5d, 4.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec3(-7.5d, 2.5d, -1.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new dvec3(-9d, 1.0, 0.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(1.0, -8.5d, -4.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(-8d, 6.5d, 9d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(8.5d, 3.5d, -6d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(-7d, -6.5d, -5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(7d, -9.5d, 7d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(7.5d, -7d, 0.0);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(0.0, 4d, -0.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(7.5d, -3d, 7.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec3(3d, 6d, 3.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new dvec3(-7.5d, 2d, -2.5d);
            var v1 = new dvec3(7d, 5d, -0.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-6.5d, 8.5d, 3d);
            var v1 = new dvec3(6d, 0.5d, 1.0);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-1d, -5.5d, -6d);
            var v1 = new dvec3(3.5d, -5d, -2.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-1.5d, 1.5d, -7.5d);
            var v1 = new dvec3(-5.5d, -7.5d, 3d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-6d, -9d, 9d);
            var v1 = new dvec3(3.5d, -8.5d, -2d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-5d, -5.5d, -3.5d);
            var v1 = new dvec3(3d, 5d, 1.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-6d, -5.5d, -8d);
            var v1 = new dvec3(0.0, 4.5d, 0.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-6.5d, 3d, -7.5d);
            var v1 = new dvec3(-7d, -4.5d, -1.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-1.5d, 2.5d, 7.5d);
            var v1 = new dvec3(0.0, 0.0, -4.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec3(-6d, 7.5d, -8.5d);
            var v1 = new dvec3(-6.5d, 1.5d, -3.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new dvec3(2.5d, 5.5d, -0.5d);
            var v1 = new dvec3(3d, -1d, 6.5d);
            var v2 = new dvec3(-1.5d, 8.5d, -6d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(0.0, 7.5d, 1.0);
            var v1 = new dvec3(-2d, 8.5d, -4d);
            var v2 = new dvec3(1.5d, -7.5d, 5.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(3d, 0.0, 6d);
            var v1 = new dvec3(4.5d, -9d, -1.5d);
            var v2 = new dvec3(7d, 2d, -8d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(-6.5d, 6.5d, -7.5d);
            var v1 = new dvec3(-4d, 7d, 4.5d);
            var v2 = new dvec3(-6d, -3d, -3.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(-7d, 5d, -1.5d);
            var v1 = new dvec3(-2d, -8.5d, 8.5d);
            var v2 = new dvec3(2d, -7d, 6d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(2d, -7.5d, 5d);
            var v1 = new dvec3(-9.5d, -2d, -3d);
            var v2 = new dvec3(-0.5d, 6.5d, 7.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(8.5d, 8.5d, -6d);
            var v1 = new dvec3(0.0, 5.5d, 7d);
            var v2 = new dvec3(-8d, 4d, 2d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(3.5d, -2.5d, -0.5d);
            var v1 = new dvec3(7d, 6.5d, -4.5d);
            var v2 = new dvec3(-1.5d, -5d, -7d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(6d, 2.5d, -9d);
            var v1 = new dvec3(8d, 1.5d, 2d);
            var v2 = new dvec3(-7.5d, 5d, -8.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec3(-2d, 2d, -5.5d);
            var v1 = new dvec3(9d, -4.5d, -2d);
            var v2 = new dvec3(6.5d, -8d, -5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new dvec3(-6d, 3d, -3.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(2d, -3.5d, 1.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(1.0, 6.5d, 6d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(-9.5d, -8.5d, 8d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(0.5d, 1.0, 4d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(3.5d, 4.5d, 9d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(6d, 0.0, 3.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(8d, 2.5d, -9d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(-3.5d, -9.5d, -7d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec3(1.5d, -5.5d, 9.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new dvec3(0.0, 3d, -6d);
            var v1 = new dvec3(-4.5d, 4.5d, -2d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(8d, 4.5d, 5.5d);
            var v1 = new dvec3(8d, -2.5d, -7.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(1.0, 9d, 9.5d);
            var v1 = new dvec3(2.5d, -2d, 9d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(7d, 7d, -6d);
            var v1 = new dvec3(-8d, 5d, -3d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(8d, 6.5d, 0.0);
            var v1 = new dvec3(0.0, 0.0, -9d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(0.0, 2.5d, 0.5d);
            var v1 = new dvec3(5.5d, -1d, -4d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(1.0, -3d, -0.5d);
            var v1 = new dvec3(7.5d, -8d, -3.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(8d, -5.5d, -0.5d);
            var v1 = new dvec3(3d, 2d, -5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(-9d, -3.5d, 1.5d);
            var v1 = new dvec3(6.5d, -2d, 6d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec3(7.5d, -7.5d, 8.5d);
            var v1 = new dvec3(3d, -7d, 7.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new dvec3(-8.5d, 0.0, -9.5d);
            var v1 = new dvec3(1.0, -8.5d, -3.5d);
            var v2 = new dvec3(-9d, -8d, 1.0);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(-6.5d, -2d, -9d);
            var v1 = new dvec3(-4d, 0.0, -1.5d);
            var v2 = new dvec3(-4d, -2.5d, -8.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(-3d, 7.5d, -1.5d);
            var v1 = new dvec3(0.0, -6.5d, -8.5d);
            var v2 = new dvec3(5d, -0.5d, -7d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(0.5d, -2d, 8d);
            var v1 = new dvec3(0.5d, 2.5d, -1.5d);
            var v2 = new dvec3(-8d, -2.5d, 0.0);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(4.5d, 9.5d, 3d);
            var v1 = new dvec3(0.5d, -6.5d, 9.5d);
            var v2 = new dvec3(-7.5d, -7d, -4.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(7.5d, -8d, 0.5d);
            var v1 = new dvec3(-8d, 6d, -5d);
            var v2 = new dvec3(5.5d, 9.5d, 1.0);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(-8.5d, -8.5d, -7d);
            var v1 = new dvec3(9.5d, 5.5d, 2.5d);
            var v2 = new dvec3(8d, -1.5d, 6d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(2.5d, 2.5d, -9.5d);
            var v1 = new dvec3(0.5d, 5.5d, -3d);
            var v2 = new dvec3(-2.5d, -9d, -2.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(-7d, -7.5d, -5d);
            var v1 = new dvec3(-1.5d, -8d, 6d);
            var v2 = new dvec3(6.5d, 8d, -2d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec3(-3.5d, -3d, 4d);
            var v1 = new dvec3(4.5d, 5.5d, 2.5d);
            var v2 = new dvec3(-2.5d, 6.5d, 6d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new dvec3(-7.5d, -6.5d, 3.5d);
            var v1 = new dvec3(1.5d, 6d, -5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(-2.5d, 1.0, 5d);
            var v1 = new dvec3(0.5d, -3.5d, -4d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(-6.5d, -8d, 6.5d);
            var v1 = new dvec3(5.5d, -4.5d, -9.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(-1d, 6d, 6d);
            var v1 = new dvec3(0.5d, -3d, 2d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(-4.5d, -4d, 1.5d);
            var v1 = new dvec3(-1d, 0.0, 3.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(0.5d, -1d, 8d);
            var v1 = new dvec3(6d, -3.5d, 9d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(8.5d, 7.5d, 3d);
            var v1 = new dvec3(3.5d, 3d, 3.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(9.5d, 7d, -7.5d);
            var v1 = new dvec3(3d, 7d, 0.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(3.5d, -8.5d, 0.0);
            var v1 = new dvec3(3d, -9.5d, 8.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec3(2d, 1.5d, 9d);
            var v1 = new dvec3(1.5d, 5d, 2.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new dvec3(4.5d, 6d, 6d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(-5d, -0.5d, -2d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(5.5d, -8d, 1.0);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(4d, 3d, 6d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(1.5d, 0.5d, 4.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(-4d, 5.5d, -7.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(8d, -5.5d, 8.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(9d, 3.5d, 9.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(4d, 5d, 0.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec3(0.5d, -2.5d, -5.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void InvariantCrossDot()
    {
        {
            var v0 = new dvec3(-4.5d, 5d, 8d);
            var v1 = new dvec3(1.5d, 4d, 9d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(-6d, -6.5d, 1.0);
            var v1 = new dvec3(-4d, -6.5d, -3d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(5.5d, 7.5d, 1.0);
            var v1 = new dvec3(-4d, 9d, 8.5d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(4.5d, -2d, 9.5d);
            var v1 = new dvec3(0.5d, -2d, 9.5d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(6.5d, 6.5d, -8d);
            var v1 = new dvec3(-2.5d, -6.5d, -7.5d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(8.5d, 5.5d, -4.5d);
            var v1 = new dvec3(-5.5d, -2d, 1.0);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(-5.5d, 2d, -6.5d);
            var v1 = new dvec3(0.5d, -4.5d, 3d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(-1d, 8.5d, 2.5d);
            var v1 = new dvec3(4d, -7.5d, -8d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(-6d, -4d, -1d);
            var v1 = new dvec3(-2.5d, -6.5d, -8.5d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new dvec3(8.5d, 4.5d, 3.5d);
            var v1 = new dvec3(9d, 4.5d, 8d);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(1564103542);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.Random(random, (2), (5));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(2025793502);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomUniform(random, (2), (5));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(2020861045);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.Random(random, (4), (8));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(6).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(6).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(6).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(1726888122);
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
    public void RandomUniform4()
    {
        var random = new Random(1738899673);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.Random(random, (0), (4));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomGaussian0()
    {
        var random = new Random(1296396642);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomNormal(random, 0.6395661805940636d, 8.892503482705216d);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.6395661805940636).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.6395661805940636).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.6395661805940636).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(8.892503482705216).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(8.892503482705216).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(8.892503482705216).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(642810323);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomGaussian(random, 0.5010626886510581d, 3.048970179189449d);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.5010626886510581).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.5010626886510581).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.5010626886510581).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.048970179189449).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.048970179189449).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(3.048970179189449).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(1192277484);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomNormal(random, 0.3800751615222895d, 5.446486969220679d);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.3800751615222895).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.3800751615222895).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.3800751615222895).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(5.446486969220679).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(5.446486969220679).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(5.446486969220679).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(1286322116);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomGaussian(random, 0.1103583118460878d, 4.525783511123519d);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.1103583118460878).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.1103583118460878).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.1103583118460878).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(4.525783511123519).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(4.525783511123519).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(4.525783511123519).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(92735974);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec3.RandomNormal(random, 0.6582873811285417d, 6.589372170432179d);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.6582873811285417).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.6582873811285417).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.6582873811285417).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(6.589372170432179).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(6.589372170432179).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(6.589372170432179).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(1478214257);
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
        var random = new Random(2075276225);
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
        var random = new Random(1884394106);
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
        var random = new Random(1074416143);
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
        var random = new Random(1647181874);
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
