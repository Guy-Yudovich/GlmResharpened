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
public class DoubleVec4Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new dvec4(9.5d);
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(9.5d, Is.EqualTo(v.z));
            Assert.That(9.5d, Is.EqualTo(v.w));
        }
        {
            var v = new dvec4(2d, 8.5d, 5d, 2.5d);
            Assert.That(2d, Is.EqualTo(v.x));
            Assert.That(8.5d, Is.EqualTo(v.y));
            Assert.That(5d, Is.EqualTo(v.z));
            Assert.That(2.5d, Is.EqualTo(v.w));
        }
        {
            var v = new dvec4(new dvec2(-4.5d, 5.5d));
            Assert.That(-4.5d, Is.EqualTo(v.x));
            Assert.That(5.5d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var v = new dvec4(new dvec3(-1d, 9.5d, -7d));
            Assert.That(-1d, Is.EqualTo(v.x));
            Assert.That(9.5d, Is.EqualTo(v.y));
            Assert.That(-7d, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var v = new dvec4(new dvec4(-5.5d, -3d, 3d, 2d));
            Assert.That(-5.5d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(2d, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new dvec4(-1.5d, -6d, -6d, 1.5d);
        Assert.That(-1.5d, Is.EqualTo(v[0]));
        Assert.That(-6d, Is.EqualTo(v[1]));
        Assert.That(-6d, Is.EqualTo(v[2]));
        Assert.That(1.5d, Is.EqualTo(v[3]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0.0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0.0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0.0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0.0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0.0; } );
        
        v[0] = 0.0;
        Assert.That(0.0, Is.EqualTo(v[0]));
        v[1] = 1.0;
        Assert.That(1.0, Is.EqualTo(v[1]));
        v[3] = 2d;
        Assert.That(2d, Is.EqualTo(v[3]));
        v[2] = 3d;
        Assert.That(3d, Is.EqualTo(v[2]));
        v[2] = 4d;
        Assert.That(4d, Is.EqualTo(v[2]));
        v[0] = 5d;
        Assert.That(5d, Is.EqualTo(v[0]));
        v[0] = 6d;
        Assert.That(6d, Is.EqualTo(v[0]));
        v[0] = 7d;
        Assert.That(7d, Is.EqualTo(v[0]));
        v[2] = 8d;
        Assert.That(8d, Is.EqualTo(v[2]));
        v[2] = 9d;
        Assert.That(9d, Is.EqualTo(v[2]));
        v[1] = -1d;
        Assert.That(-1d, Is.EqualTo(v[1]));
        v[1] = -2d;
        Assert.That(-2d, Is.EqualTo(v[1]));
        v[0] = -3d;
        Assert.That(-3d, Is.EqualTo(v[0]));
        v[2] = -4d;
        Assert.That(-4d, Is.EqualTo(v[2]));
        v[1] = -5d;
        Assert.That(-5d, Is.EqualTo(v[1]));
        v[0] = -6d;
        Assert.That(-6d, Is.EqualTo(v[0]));
        v[3] = -7d;
        Assert.That(-7d, Is.EqualTo(v[3]));
        v[0] = -8d;
        Assert.That(-8d, Is.EqualTo(v[0]));
        v[2] = -9d;
        Assert.That(-9d, Is.EqualTo(v[2]));
        v[1] = -9.5d;
        Assert.That(-9.5d, Is.EqualTo(v[1]));
        v[1] = -8.5d;
        Assert.That(-8.5d, Is.EqualTo(v[1]));
        v[0] = -7.5d;
        Assert.That(-7.5d, Is.EqualTo(v[0]));
        v[0] = -6.5d;
        Assert.That(-6.5d, Is.EqualTo(v[0]));
        v[3] = -5.5d;
        Assert.That(-5.5d, Is.EqualTo(v[3]));
        v[0] = -4.5d;
        Assert.That(-4.5d, Is.EqualTo(v[0]));
        v[1] = -3.5d;
        Assert.That(-3.5d, Is.EqualTo(v[1]));
        v[3] = -2.5d;
        Assert.That(-2.5d, Is.EqualTo(v[3]));
        v[3] = -1.5d;
        Assert.That(-1.5d, Is.EqualTo(v[3]));
        v[0] = -0.5d;
        Assert.That(-0.5d, Is.EqualTo(v[0]));
        v[0] = 0.5d;
        Assert.That(0.5d, Is.EqualTo(v[0]));
        v[1] = 1.5d;
        Assert.That(1.5d, Is.EqualTo(v[1]));
        v[1] = 2.5d;
        Assert.That(2.5d, Is.EqualTo(v[1]));
        v[2] = 3.5d;
        Assert.That(3.5d, Is.EqualTo(v[2]));
        v[2] = 4.5d;
        Assert.That(4.5d, Is.EqualTo(v[2]));
        v[3] = 5.5d;
        Assert.That(5.5d, Is.EqualTo(v[3]));
        v[3] = 6.5d;
        Assert.That(6.5d, Is.EqualTo(v[3]));
        v[1] = 7.5d;
        Assert.That(7.5d, Is.EqualTo(v[1]));
        v[2] = 8.5d;
        Assert.That(8.5d, Is.EqualTo(v[2]));
        v[0] = 9.5d;
        Assert.That(9.5d, Is.EqualTo(v[0]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new dvec4(-2d, -3d, -7d, 5.5d);
        var vals = v.Values;
        Assert.That(-2d, Is.EqualTo(vals[0]));
        Assert.That(-3d, Is.EqualTo(vals[1]));
        Assert.That(-7d, Is.EqualTo(vals[2]));
        Assert.That(5.5d, Is.EqualTo(vals[3]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0.0, Is.EqualTo(dvec4.Zero.x));
        Assert.That(0.0, Is.EqualTo(dvec4.Zero.y));
        Assert.That(0.0, Is.EqualTo(dvec4.Zero.z));
        Assert.That(0.0, Is.EqualTo(dvec4.Zero.w));
        
        Assert.That(1.0, Is.EqualTo(dvec4.Ones.x));
        Assert.That(1.0, Is.EqualTo(dvec4.Ones.y));
        Assert.That(1.0, Is.EqualTo(dvec4.Ones.z));
        Assert.That(1.0, Is.EqualTo(dvec4.Ones.w));
        
        Assert.That(1.0, Is.EqualTo(dvec4.UnitX.x));
        Assert.That(0.0, Is.EqualTo(dvec4.UnitX.y));
        Assert.That(0.0, Is.EqualTo(dvec4.UnitX.z));
        Assert.That(0.0, Is.EqualTo(dvec4.UnitX.w));
        
        Assert.That(0.0, Is.EqualTo(dvec4.UnitY.x));
        Assert.That(1.0, Is.EqualTo(dvec4.UnitY.y));
        Assert.That(0.0, Is.EqualTo(dvec4.UnitY.z));
        Assert.That(0.0, Is.EqualTo(dvec4.UnitY.w));
        
        Assert.That(0.0, Is.EqualTo(dvec4.UnitZ.x));
        Assert.That(0.0, Is.EqualTo(dvec4.UnitZ.y));
        Assert.That(1.0, Is.EqualTo(dvec4.UnitZ.z));
        Assert.That(0.0, Is.EqualTo(dvec4.UnitZ.w));
        
        Assert.That(0.0, Is.EqualTo(dvec4.UnitW.x));
        Assert.That(0.0, Is.EqualTo(dvec4.UnitW.y));
        Assert.That(0.0, Is.EqualTo(dvec4.UnitW.z));
        Assert.That(1.0, Is.EqualTo(dvec4.UnitW.w));
        
        Assert.That(double.MaxValue, Is.EqualTo(dvec4.MaxValue.x));
        Assert.That(double.MaxValue, Is.EqualTo(dvec4.MaxValue.y));
        Assert.That(double.MaxValue, Is.EqualTo(dvec4.MaxValue.z));
        Assert.That(double.MaxValue, Is.EqualTo(dvec4.MaxValue.w));
        
        Assert.That(double.MinValue, Is.EqualTo(dvec4.MinValue.x));
        Assert.That(double.MinValue, Is.EqualTo(dvec4.MinValue.y));
        Assert.That(double.MinValue, Is.EqualTo(dvec4.MinValue.z));
        Assert.That(double.MinValue, Is.EqualTo(dvec4.MinValue.w));
        
        Assert.That(double.Epsilon, Is.EqualTo(dvec4.Epsilon.x));
        Assert.That(double.Epsilon, Is.EqualTo(dvec4.Epsilon.y));
        Assert.That(double.Epsilon, Is.EqualTo(dvec4.Epsilon.z));
        Assert.That(double.Epsilon, Is.EqualTo(dvec4.Epsilon.w));
        
        Assert.That(double.NaN, Is.EqualTo(dvec4.NaN.x));
        Assert.That(double.NaN, Is.EqualTo(dvec4.NaN.y));
        Assert.That(double.NaN, Is.EqualTo(dvec4.NaN.z));
        Assert.That(double.NaN, Is.EqualTo(dvec4.NaN.w));
        
        Assert.That(double.NegativeInfinity, Is.EqualTo(dvec4.NegativeInfinity.x));
        Assert.That(double.NegativeInfinity, Is.EqualTo(dvec4.NegativeInfinity.y));
        Assert.That(double.NegativeInfinity, Is.EqualTo(dvec4.NegativeInfinity.z));
        Assert.That(double.NegativeInfinity, Is.EqualTo(dvec4.NegativeInfinity.w));
        
        Assert.That(double.PositiveInfinity, Is.EqualTo(dvec4.PositiveInfinity.x));
        Assert.That(double.PositiveInfinity, Is.EqualTo(dvec4.PositiveInfinity.y));
        Assert.That(double.PositiveInfinity, Is.EqualTo(dvec4.PositiveInfinity.z));
        Assert.That(double.PositiveInfinity, Is.EqualTo(dvec4.PositiveInfinity.w));
    }

    [Test]
    public void Operators()
    {
        var v1 = new dvec4(-5.5d, -1.5d, -5d, -9.5d);
        var v2 = new dvec4(-5.5d, -1.5d, -5d, -9.5d);
        var v3 = new dvec4(-9.5d, -5d, -1.5d, -5.5d);
        Assert.That((v1 == new dvec4(v1)).AllTrue);
        Assert.That((v2 == new dvec4(v2)).AllTrue);
        Assert.That((v3 == new dvec4(v3)).AllTrue);
        Assert.That((v1 == v2).AllTrue);
        Assert.That((v1 != v3).AllTrue);
        Assert.That((v2 != v3).AllTrue);
    }

    [Test]
    public void StringInterop()
    {
        var v = new dvec4(4d, 9d, 9d, 0.0);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = dvec4.Parse(s0);
        var v1 = dvec4.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = dvec4.TryParse(s0, out v0);
        var b1 = dvec4.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = dvec4.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = dvec4.TryParse("", out v0);
        Assert.That(!b0);
        b0 = dvec4.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { dvec4.Parse(null); });
        Assert.Throws<FormatException>(() => { dvec4.Parse(""); });
        Assert.Throws<FormatException>(() => { dvec4.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = dvec4.Parse(s3, "; ", NumberStyles.Number);
        var v4 = dvec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = dvec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new dvec4(-5d, 8d, 3d, -9.5d);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<dvec4>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new dvec4(-3.5d, -1.5d, 3d, -3.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(3d, -8d, 7.5d, 2d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(-1.5d, -2d, -1d, 6.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(-1d, 2d, -2.5d, -4d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(-4d, -8d, -6.5d, -5.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(-8d, 0.0, -3d, -5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(5.5d, 4d, 4.5d, 0.0);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(5d, -2.5d, 2d, 3d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(-5.5d, 3d, 2d, -4d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(0.0, 5d, 5d, 4.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new dvec4(-1d, 6d, 3.5d, 0.0);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(9.5d, 9.5d, 6.5d, -7d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(-9.5d, 7.5d, -4.5d, 7d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(-9d, 1.0, -9.5d, 9.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(0.5d, 3.5d, 8.5d, 2d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(3.5d, -9.5d, 6.5d, 3d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(-1d, 4.5d, 0.0, -7d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(-8.5d, -6.5d, 0.0, 8d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(7.5d, 2d, 1.0, 8d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(0.5d, -7d, 9.5d, 9.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new dvec4(2.5d, -9.5d, -5d, -7d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(-4.5d, -4d, -7d, -1d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(6d, -6.5d, 5.5d, 1.0);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(-4d, 9d, -7d, -6.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(-1d, 9d, 4.5d, 2d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(-5d, 8d, 8d, -5.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(5d, -0.5d, 3.5d, 1.0);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(9.5d, 0.0, -9.5d, 1.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(-2d, -2d, -1d, 4d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(-6d, 3.5d, -7.5d, -3.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new dvec4(-7d, -6.5d, 8d, 3.5d);
            var v1 = new dvec4(2d, 2d, -2.5d, 8d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(-2d, -2.5d, 0.5d, 3.5d);
            var v1 = new dvec4(6.5d, 3d, 7.5d, 5.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(-9.5d, 0.0, -7.5d, 6d);
            var v1 = new dvec4(-2.5d, 8d, 2.5d, 8.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(-0.5d, -1.5d, 1.5d, 5.5d);
            var v1 = new dvec4(-9.5d, -1.5d, 1.5d, -0.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(1.0, -4.5d, -6.5d, 4d);
            var v1 = new dvec4(-9.5d, -6.5d, 8d, -7d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(0.0, 7d, -8.5d, -7.5d);
            var v1 = new dvec4(-6d, 0.5d, 2d, 2.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(-8d, -9.5d, -1.5d, -4d);
            var v1 = new dvec4(-9d, 2d, -3d, 7d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(1.5d, -1d, 4d, -4d);
            var v1 = new dvec4(-2d, 1.5d, -0.5d, -6.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(6.5d, 1.0, 1.5d, -1d);
            var v1 = new dvec4(-9.5d, 2.5d, -5d, 6.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(1.5d, 4d, 5d, -9d);
            var v1 = new dvec4(-2.5d, 9d, -7.5d, 8.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new dvec4(7.5d, 8d, -1d, 4.5d);
            var v1 = new dvec4(3d, -3.5d, -3d, -3.5d);
            var v2 = new dvec4(2d, 6d, 3.5d, 3.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(-8.5d, 7.5d, 2.5d, 2d);
            var v1 = new dvec4(-6.5d, 9d, -1d, 5d);
            var v2 = new dvec4(-9d, -8d, -7.5d, 6d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(1.5d, 4d, -9d, 4.5d);
            var v1 = new dvec4(-9.5d, 6d, 6.5d, 9d);
            var v2 = new dvec4(6.5d, 5d, -2d, -2.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(8d, 2.5d, -4.5d, -6.5d);
            var v1 = new dvec4(8.5d, 0.0, -1.5d, 0.0);
            var v2 = new dvec4(4.5d, 7d, -3d, -2.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(0.5d, -0.5d, 6.5d, -6d);
            var v1 = new dvec4(9d, -5d, 2d, -9d);
            var v2 = new dvec4(-2.5d, 3d, 3d, 9.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(6d, -8d, 5d, 5.5d);
            var v1 = new dvec4(-1d, -6.5d, 7.5d, -5d);
            var v2 = new dvec4(-3.5d, 4d, 3.5d, 1.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(-5.5d, -2.5d, 6d, -8d);
            var v1 = new dvec4(-0.5d, -7.5d, -3d, -5.5d);
            var v2 = new dvec4(1.5d, 1.5d, 3d, 1.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(9d, -9.5d, 0.0, -8.5d);
            var v1 = new dvec4(3d, 2.5d, 0.0, 5d);
            var v2 = new dvec4(-0.5d, -3.5d, -6d, -8.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(4.5d, 2.5d, -0.5d, -1d);
            var v1 = new dvec4(-1d, 7.5d, 1.0, -3.5d);
            var v2 = new dvec4(5.5d, 5d, 2.5d, -7.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(8d, -4.5d, 0.5d, 4d);
            var v1 = new dvec4(1.5d, -9d, 7d, -5d);
            var v2 = new dvec4(-4d, -5d, -3.5d, 0.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new dvec4(4.5d, -9d, 8d, 9d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(-5.5d, 3.5d, 7d, 2d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(-3.5d, 7d, 6.5d, 7.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(-3.5d, 6d, 0.0, 1.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(-3.5d, 7.5d, 8d, 0.0);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(4.5d, 1.0, -1.5d, 5.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(-3d, -2.5d, -8.5d, -3d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(-5.5d, 8.5d, -6d, -5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(-1d, 4d, 9.5d, -7.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(-9.5d, -1d, 8d, -4d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new dvec4(-3d, -0.5d, 3.5d, 7d);
            var v1 = new dvec4(-0.5d, -2.5d, -3d, 9.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(3d, 2.5d, 2d, -7d);
            var v1 = new dvec4(-5d, -6d, 6.5d, 1.0);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(5d, 9d, 9.5d, 4d);
            var v1 = new dvec4(-2d, -8d, 9.5d, 3d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(9.5d, 5d, 0.5d, -4d);
            var v1 = new dvec4(5d, -7d, 9d, -3.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(-6.5d, 2.5d, -1.5d, -2d);
            var v1 = new dvec4(6d, -2.5d, 5d, 7d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(7.5d, 5.5d, -8d, 9.5d);
            var v1 = new dvec4(9d, 6d, -1d, 4d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(7d, -9d, 5d, 3d);
            var v1 = new dvec4(-3.5d, -8d, 7.5d, 4.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(0.5d, 0.5d, 8d, -5.5d);
            var v1 = new dvec4(6.5d, 9.5d, 3.5d, -3.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(-7.5d, -6d, 4.5d, -7.5d);
            var v1 = new dvec4(-1.5d, -5.5d, 5.5d, -8d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(3d, 2.5d, 6d, -7d);
            var v1 = new dvec4(9.5d, 9.5d, 3.5d, 2.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new dvec4(0.5d, 9d, -4d, 0.5d);
            var v1 = new dvec4(7d, -8d, -8d, -3d);
            var v2 = new dvec4(8d, 2d, 5.5d, -4d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(6.5d, 3.5d, -4d, -1.5d);
            var v1 = new dvec4(-6.5d, 1.5d, -5d, 9.5d);
            var v2 = new dvec4(2d, 4.5d, 7d, 5.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(-9.5d, -5.5d, 8.5d, 0.0);
            var v1 = new dvec4(8.5d, 4.5d, -1.5d, 6.5d);
            var v2 = new dvec4(-2.5d, 0.0, 6.5d, 5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(-9d, -5d, -6d, -6d);
            var v1 = new dvec4(-6d, -9d, 7.5d, 9d);
            var v2 = new dvec4(-4.5d, -7d, -6.5d, 8d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(-0.5d, 2.5d, -4d, 7d);
            var v1 = new dvec4(3d, 5d, 3.5d, 6.5d);
            var v2 = new dvec4(1.0, -9d, -1d, -5.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(-9.5d, -7d, -4d, -4d);
            var v1 = new dvec4(-4d, 9.5d, -3.5d, 5.5d);
            var v2 = new dvec4(7.5d, 8d, 8d, 8d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(-6d, 9.5d, -6.5d, -5.5d);
            var v1 = new dvec4(7.5d, 7.5d, -1d, 3d);
            var v2 = new dvec4(0.0, -0.5d, -2d, 6d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(-8.5d, -8.5d, 2.5d, -7.5d);
            var v1 = new dvec4(6d, 0.0, 4d, 0.0);
            var v2 = new dvec4(3d, 2.5d, 6.5d, 8.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(4d, -5.5d, 6.5d, -4.5d);
            var v1 = new dvec4(0.5d, -2.5d, -2d, -8.5d);
            var v2 = new dvec4(-5.5d, 5d, 1.5d, 4d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(-7.5d, 9d, 9.5d, 3d);
            var v1 = new dvec4(8d, 6d, -6.5d, 0.5d);
            var v2 = new dvec4(5d, 7d, 2.5d, 2.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new dvec4(-9.5d, 0.5d, 7d, 1.5d);
            var v1 = new dvec4(7d, -2d, -9.5d, -7d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(6d, -2d, -7.5d, 9d);
            var v1 = new dvec4(-9d, 8d, -3.5d, 8.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(-6.5d, 3.5d, 6.5d, -3d);
            var v1 = new dvec4(1.0, 6d, 7d, 5.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(6d, 1.5d, -9d, 8.5d);
            var v1 = new dvec4(2.5d, 1.5d, -0.5d, 1.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(2.5d, 8.5d, -9d, -6.5d);
            var v1 = new dvec4(-9.5d, 6.5d, 9d, 9d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(-7.5d, 9d, -1.5d, 6d);
            var v1 = new dvec4(-6d, 9d, -0.5d, -2d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(-2d, -1.5d, -1d, -6.5d);
            var v1 = new dvec4(-3.5d, 9d, 9d, -4d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(-6.5d, -3d, -5.5d, -7d);
            var v1 = new dvec4(2.5d, -7.5d, -5.5d, -6d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(-6.5d, 0.5d, -7d, -8.5d);
            var v1 = new dvec4(-0.5d, 3d, -8d, -3.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(-5.5d, -3.5d, 1.5d, 1.5d);
            var v1 = new dvec4(-8d, 0.0, -9d, 7.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new dvec4(2d, 9.5d, 6.5d, -8d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(-7d, 5.5d, -9.5d, -4d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(7.5d, 9.5d, 0.5d, 2d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(-3.5d, 5d, -0.5d, 7d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(6d, 1.0, 9d, -4d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(2.5d, -2.5d, -3.5d, -9d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(5d, -1.5d, 5.5d, 4d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(-3d, -6.5d, 8d, -3d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(4.5d, -7d, -7.5d, -1d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(-8.5d, -1.5d, -2d, 4d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(1445280902);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.Random(random, (-2), (1));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-0.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(1504753831);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomUniform(random, (4), (6));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(1138571764);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.Random(random, (-2), (2));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(1966164122);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomUniform(random, (-4), (-1));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-2.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-2.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-2.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-2.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(1657774279);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.Random(random, (-3), (0));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-1.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-1.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomGaussian0()
    {
        var random = new Random(45878974);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomNormal(random, 1.8643721043432002d, 0.17663798768848088d);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.8643721043432002).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.8643721043432002).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.8643721043432002).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.8643721043432002).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.17663798768848088).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.17663798768848088).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.17663798768848088).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.17663798768848088).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(121979221);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomGaussian(random, -1.2179827742362315d, 2.6969041734453776d);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.2179827742362315).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.2179827742362315).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-1.2179827742362315).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-1.2179827742362315).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.6969041734453776).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.6969041734453776).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.6969041734453776).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(2.6969041734453776).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(623919730);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomNormal(random, 0.06981042496385559d, 1.802407923062522d);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.06981042496385559).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.06981042496385559).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.06981042496385559).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0.06981042496385559).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.802407923062522).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.802407923062522).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.802407923062522).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.802407923062522).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(2031482057);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomGaussian(random, -1.7867757975062242d, 9.878591573740632d);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.7867757975062242).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.7867757975062242).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-1.7867757975062242).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-1.7867757975062242).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(9.878591573740632).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(9.878591573740632).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(9.878591573740632).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(9.878591573740632).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(50833115);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomNormal(random, 0.6373999894770792d, 7.41790753669008d);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.6373999894770792).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.6373999894770792).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.6373999894770792).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0.6373999894770792).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(7.41790753669008).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(7.41790753669008).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(7.41790753669008).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(7.41790753669008).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(172233972);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomNormal(random);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1).Within(3.0));
    }

    [Test]
    public void RandomNormal1()
    {
        var random = new Random(1833480591);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomNormal(random);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1).Within(3.0));
    }

    [Test]
    public void RandomNormal2()
    {
        var random = new Random(2119913393);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomNormal(random);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1).Within(3.0));
    }

    [Test]
    public void RandomNormal3()
    {
        var random = new Random(1658059660);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomNormal(random);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1).Within(3.0));
    }

    [Test]
    public void RandomNormal4()
    {
        var random = new Random(878284122);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomNormal(random);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1).Within(3.0));
    }

}
