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
            var v = new dvec4(-2d);
            Assert.That(-2d, Is.EqualTo(v.x));
            Assert.That(-2d, Is.EqualTo(v.y));
            Assert.That(-2d, Is.EqualTo(v.z));
            Assert.That(-2d, Is.EqualTo(v.w));
        }
        {
            var v = new dvec4(2.5d, -3d, -4.5d, -3.5d);
            Assert.That(2.5d, Is.EqualTo(v.x));
            Assert.That(-3d, Is.EqualTo(v.y));
            Assert.That(-4.5d, Is.EqualTo(v.z));
            Assert.That(-3.5d, Is.EqualTo(v.w));
        }
        {
            var v = new dvec4(new dvec2(-0.5d, -5.5d));
            Assert.That(-0.5d, Is.EqualTo(v.x));
            Assert.That(-5.5d, Is.EqualTo(v.y));
            Assert.That(0.0, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var v = new dvec4(new dvec3(0.0, -6d, 3d));
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(-6d, Is.EqualTo(v.y));
            Assert.That(3d, Is.EqualTo(v.z));
            Assert.That(0.0, Is.EqualTo(v.w));
        }
        {
            var v = new dvec4(new dvec4(9.5d, -7d, 3.5d, -1.5d));
            Assert.That(9.5d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
            Assert.That(3.5d, Is.EqualTo(v.z));
            Assert.That(-1.5d, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new dvec4(3.5d, 5d, 7d, -1.5d);
        Assert.That(3.5d, Is.EqualTo(v[0]));
        Assert.That(5d, Is.EqualTo(v[1]));
        Assert.That(7d, Is.EqualTo(v[2]));
        Assert.That(-1.5d, Is.EqualTo(v[3]));
        
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
        
        v[1] = 0.0;
        Assert.That(0.0, Is.EqualTo(v[1]));
        v[0] = 1.0;
        Assert.That(1.0, Is.EqualTo(v[0]));
        v[0] = 2d;
        Assert.That(2d, Is.EqualTo(v[0]));
        v[0] = 3d;
        Assert.That(3d, Is.EqualTo(v[0]));
        v[2] = 4d;
        Assert.That(4d, Is.EqualTo(v[2]));
        v[2] = 5d;
        Assert.That(5d, Is.EqualTo(v[2]));
        v[2] = 6d;
        Assert.That(6d, Is.EqualTo(v[2]));
        v[0] = 7d;
        Assert.That(7d, Is.EqualTo(v[0]));
        v[0] = 8d;
        Assert.That(8d, Is.EqualTo(v[0]));
        v[0] = 9d;
        Assert.That(9d, Is.EqualTo(v[0]));
        v[2] = -1d;
        Assert.That(-1d, Is.EqualTo(v[2]));
        v[3] = -2d;
        Assert.That(-2d, Is.EqualTo(v[3]));
        v[1] = -3d;
        Assert.That(-3d, Is.EqualTo(v[1]));
        v[1] = -4d;
        Assert.That(-4d, Is.EqualTo(v[1]));
        v[3] = -5d;
        Assert.That(-5d, Is.EqualTo(v[3]));
        v[3] = -6d;
        Assert.That(-6d, Is.EqualTo(v[3]));
        v[1] = -7d;
        Assert.That(-7d, Is.EqualTo(v[1]));
        v[2] = -8d;
        Assert.That(-8d, Is.EqualTo(v[2]));
        v[1] = -9d;
        Assert.That(-9d, Is.EqualTo(v[1]));
        v[3] = -9.5d;
        Assert.That(-9.5d, Is.EqualTo(v[3]));
        v[1] = -8.5d;
        Assert.That(-8.5d, Is.EqualTo(v[1]));
        v[2] = -7.5d;
        Assert.That(-7.5d, Is.EqualTo(v[2]));
        v[2] = -6.5d;
        Assert.That(-6.5d, Is.EqualTo(v[2]));
        v[1] = -5.5d;
        Assert.That(-5.5d, Is.EqualTo(v[1]));
        v[2] = -4.5d;
        Assert.That(-4.5d, Is.EqualTo(v[2]));
        v[3] = -3.5d;
        Assert.That(-3.5d, Is.EqualTo(v[3]));
        v[0] = -2.5d;
        Assert.That(-2.5d, Is.EqualTo(v[0]));
        v[3] = -1.5d;
        Assert.That(-1.5d, Is.EqualTo(v[3]));
        v[1] = -0.5d;
        Assert.That(-0.5d, Is.EqualTo(v[1]));
        v[3] = 0.5d;
        Assert.That(0.5d, Is.EqualTo(v[3]));
        v[2] = 1.5d;
        Assert.That(1.5d, Is.EqualTo(v[2]));
        v[1] = 2.5d;
        Assert.That(2.5d, Is.EqualTo(v[1]));
        v[1] = 3.5d;
        Assert.That(3.5d, Is.EqualTo(v[1]));
        v[2] = 4.5d;
        Assert.That(4.5d, Is.EqualTo(v[2]));
        v[2] = 5.5d;
        Assert.That(5.5d, Is.EqualTo(v[2]));
        v[0] = 6.5d;
        Assert.That(6.5d, Is.EqualTo(v[0]));
        v[0] = 7.5d;
        Assert.That(7.5d, Is.EqualTo(v[0]));
        v[2] = 8.5d;
        Assert.That(8.5d, Is.EqualTo(v[2]));
        v[0] = 9.5d;
        Assert.That(9.5d, Is.EqualTo(v[0]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new dvec4(-5d, -6.5d, -1.5d, 7d);
        var vals = v.Values;
        Assert.That(-5d, Is.EqualTo(vals[0]));
        Assert.That(-6.5d, Is.EqualTo(vals[1]));
        Assert.That(-1.5d, Is.EqualTo(vals[2]));
        Assert.That(7d, Is.EqualTo(vals[3]));
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
        var v1 = new dvec4(-0.5d, 1.0, -3.5d, 6d);
        var v2 = new dvec4(-0.5d, 1.0, -3.5d, 6d);
        var v3 = new dvec4(6d, -3.5d, 1.0, -0.5d);
        Assert.That(v1 == new dvec4(v1));
        Assert.That(v2 == new dvec4(v2));
        Assert.That(v3 == new dvec4(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new dvec4(4d, 9.5d, 6d, 8d);
        
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
        var v0 = new dvec4(9d, 1.0, 8.5d, 5d);
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
            var v0 = new dvec4(4d, 4d, -5d, 0.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(-5.5d, 6.5d, 5d, 9d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(9.5d, 6.5d, -9d, 0.0);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(-3.5d, 7.5d, -3d, -0.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(0.0, -0.5d, -6d, 7d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(-2d, -7.5d, -8d, 5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(2d, -1d, -4.5d, 7d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(2.5d, -6.5d, 6d, -0.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(1.5d, 2.5d, -2d, -9.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec4(7.5d, -6.5d, 5d, -2.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new dvec4(7.5d, 5.5d, -9d, 0.0);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(-4d, 2.5d, -0.5d, 2d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(-4.5d, 8.5d, -7d, 2.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(6.5d, 6.5d, 0.0, 0.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(4.5d, -8.5d, 2.5d, -6d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(-9d, 3d, -1.5d, 1.0);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(4.5d, -6d, -3d, -6d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(7d, 2d, 0.5d, -5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(-7d, 9.5d, 4d, -0.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec4(4d, 4d, -5d, -4.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new dvec4(3d, -1.5d, -4.5d, 4.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(-2.5d, -8d, 0.0, -7.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(3.5d, 1.5d, -6d, 3d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(-9d, 9.5d, 3.5d, -2d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(5d, 5.5d, -9d, 5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(-4d, -1.5d, -8d, 3.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(-8d, -8.5d, -7.5d, -3d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(0.0, 2.5d, -6.5d, 4d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(9.5d, 6.5d, 8d, 1.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec4(-2d, -6d, 8.5d, -6d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new dvec4(7.5d, 0.0, 2.5d, 6.5d);
            var v1 = new dvec4(5d, 2d, 9.5d, 8d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(-8d, 4.5d, 5d, -7d);
            var v1 = new dvec4(9d, -7d, 4d, -6d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(-0.5d, 8d, 5d, -8d);
            var v1 = new dvec4(-3d, 7d, 2d, -0.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(-6.5d, 0.0, -3.5d, 0.0);
            var v1 = new dvec4(-2d, -1d, 9.5d, 4.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(4d, -8d, -3d, -7.5d);
            var v1 = new dvec4(-7d, 8d, 8d, 1.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(2.5d, 8d, 8d, -9d);
            var v1 = new dvec4(3d, 5d, 6d, 7.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(-6d, 5.5d, 0.0, -1.5d);
            var v1 = new dvec4(7d, -3d, -8d, -0.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(7.5d, 2d, -3d, 5d);
            var v1 = new dvec4(-6d, 8.5d, 6.5d, 6d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(4.5d, -1d, -2d, 2.5d);
            var v1 = new dvec4(3d, -6.5d, 9.5d, -9.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec4(0.0, -5d, -4.5d, 3d);
            var v1 = new dvec4(9.5d, -5.5d, -3.5d, -8d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new dvec4(-1.5d, -1.5d, -3d, -3.5d);
            var v1 = new dvec4(-2.5d, -4.5d, 0.0, -2d);
            var v2 = new dvec4(-3d, 8.5d, -6.5d, 0.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(8d, -7d, 0.5d, -2.5d);
            var v1 = new dvec4(6d, 3d, 3.5d, 2d);
            var v2 = new dvec4(-3d, -1.5d, 1.0, 4d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(-1d, -3.5d, 2d, 8d);
            var v1 = new dvec4(-2d, 4.5d, 5.5d, -3d);
            var v2 = new dvec4(8.5d, 6.5d, 7.5d, 4d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(-6d, -4.5d, -8.5d, 8d);
            var v1 = new dvec4(8d, 4.5d, 0.0, 3d);
            var v2 = new dvec4(9.5d, 3.5d, -4d, 6d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(-7.5d, 1.0, -6d, 6.5d);
            var v1 = new dvec4(-1.5d, -0.5d, 9.5d, 9.5d);
            var v2 = new dvec4(-3.5d, 8d, -6d, 1.0);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(-6.5d, 1.5d, 9.5d, -8d);
            var v1 = new dvec4(3d, 9d, 2.5d, -3d);
            var v2 = new dvec4(-9d, -3.5d, -2d, -8.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(-7.5d, -5.5d, 4.5d, -9d);
            var v1 = new dvec4(-1.5d, 7.5d, 5d, -8d);
            var v2 = new dvec4(-2d, 5.5d, -2.5d, 9d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(-9d, 8.5d, -5.5d, 9d);
            var v1 = new dvec4(6.5d, 7.5d, -8d, 7d);
            var v2 = new dvec4(9d, -9.5d, -3.5d, -7d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(4.5d, -6.5d, 0.0, -0.5d);
            var v1 = new dvec4(0.0, 0.0, -1.5d, 5.5d);
            var v2 = new dvec4(0.5d, 4.5d, -4d, 4d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec4(4.5d, -8.5d, -2d, -1.5d);
            var v1 = new dvec4(2d, 8.5d, -0.5d, -2.5d);
            var v2 = new dvec4(4d, 0.5d, 8.5d, 4d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new dvec4(-6d, 3.5d, -4.5d, -1.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(-7.5d, -2.5d, 6d, 6d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(1.5d, 5d, -3.5d, -2d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(-8.5d, -2.5d, 8d, 7.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(-3.5d, 1.5d, 1.5d, 4d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(5.5d, 0.5d, -8.5d, 7d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(-7d, 8d, -6d, -3d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(-8d, -6.5d, 0.0, -1.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(8.5d, 2d, 9d, -7.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec4(-9.5d, 5.5d, -8d, -5.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new dvec4(-7d, 5.5d, -0.5d, 9d);
            var v1 = new dvec4(-1.5d, -8.5d, 7.5d, 3d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(9d, -8d, 4d, -8d);
            var v1 = new dvec4(8.5d, -8.5d, -8.5d, 4.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(8.5d, 4d, 6.5d, -3.5d);
            var v1 = new dvec4(6.5d, -5.5d, -8.5d, 9.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(0.0, 3.5d, 6d, 8.5d);
            var v1 = new dvec4(7.5d, -0.5d, 0.0, -4d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(-2.5d, 9d, -6.5d, 2.5d);
            var v1 = new dvec4(-2.5d, -4d, 1.0, -2d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(4.5d, -5d, 3d, -6d);
            var v1 = new dvec4(-3d, -7.5d, 2.5d, 0.0);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(6d, 7.5d, -5.5d, -2d);
            var v1 = new dvec4(-7.5d, -8d, 6.5d, 3.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(-4d, -0.5d, 8d, 4.5d);
            var v1 = new dvec4(-4d, 9.5d, 6d, -9.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(-8d, 0.5d, 0.5d, -1.5d);
            var v1 = new dvec4(7.5d, -0.5d, 6d, -4.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec4(3d, -5.5d, 1.5d, -7.5d);
            var v1 = new dvec4(-8.5d, 5d, -2.5d, -8d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new dvec4(-2d, 4.5d, -1d, 5.5d);
            var v1 = new dvec4(4d, -5d, 7d, -8.5d);
            var v2 = new dvec4(5d, -2.5d, 1.0, -4d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(-4.5d, -4d, -6.5d, 6.5d);
            var v1 = new dvec4(-3.5d, 3d, -7d, 4.5d);
            var v2 = new dvec4(-4d, 8.5d, 8.5d, 4.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(-0.5d, 0.0, 3d, 5.5d);
            var v1 = new dvec4(-9.5d, -3.5d, 0.0, -6d);
            var v2 = new dvec4(3.5d, -0.5d, 4.5d, -2d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(-3d, -5.5d, 4d, -7.5d);
            var v1 = new dvec4(-8.5d, -1.5d, -8.5d, -2.5d);
            var v2 = new dvec4(-2d, -8d, -2.5d, -5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(1.5d, 3d, -2.5d, -9d);
            var v1 = new dvec4(8d, 2d, 8.5d, -3d);
            var v2 = new dvec4(5.5d, -7d, 6d, 3d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(-1d, -2d, 1.0, -9d);
            var v1 = new dvec4(-2.5d, -4.5d, -9.5d, 6.5d);
            var v2 = new dvec4(-9d, -2d, -5.5d, 2d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(8.5d, 5.5d, -4d, -3.5d);
            var v1 = new dvec4(-8d, -1d, -7.5d, -2d);
            var v2 = new dvec4(-3d, -0.5d, 4d, -7d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(9.5d, -8.5d, 6d, 1.5d);
            var v1 = new dvec4(1.5d, -8.5d, -6d, 6.5d);
            var v2 = new dvec4(-7d, 0.0, -2d, 8d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(-3.5d, 1.0, 0.0, -2.5d);
            var v1 = new dvec4(7.5d, 0.5d, 5.5d, -9.5d);
            var v2 = new dvec4(-9d, -5.5d, -9.5d, -4d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec4(-0.5d, -2d, 5.5d, -4.5d);
            var v1 = new dvec4(4.5d, 4.5d, 1.5d, -8.5d);
            var v2 = new dvec4(7d, -5.5d, -9.5d, 5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new dvec4(0.0, -5d, 4d, -5d);
            var v1 = new dvec4(-1.5d, -3.5d, 6.5d, 7d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(2d, 9d, -5.5d, 4.5d);
            var v1 = new dvec4(0.5d, -7d, 0.5d, -1.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(4.5d, -6d, -1d, 1.0);
            var v1 = new dvec4(8d, -3.5d, 5d, -9.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(-4.5d, 7d, -6d, -9.5d);
            var v1 = new dvec4(-1.5d, 4d, -0.5d, 8d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(9d, -6.5d, -4d, 8d);
            var v1 = new dvec4(4d, 0.0, -6d, -0.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(9.5d, -4d, -3d, -5d);
            var v1 = new dvec4(-2.5d, 1.5d, -1.5d, 5.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(3d, -5d, 8.5d, 5d);
            var v1 = new dvec4(-1d, 6d, -7.5d, -4d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(9d, -4.5d, 0.5d, -9.5d);
            var v1 = new dvec4(9d, -6d, -9d, 7.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(-9.5d, -6d, -4.5d, 6d);
            var v1 = new dvec4(2d, -8.5d, -6.5d, 3.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec4(9.5d, -7.5d, 2d, 5.5d);
            var v1 = new dvec4(-4d, 1.5d, 2.5d, 3.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new dvec4(-8.5d, 4d, -8.5d, -7d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(-3d, 4.5d, -8d, -2.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(-6d, -9.5d, -2d, -7.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(-7.5d, 8.5d, 3.5d, -1d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(-4d, -9.5d, 2d, -7.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(-0.5d, 6.5d, -1d, 3.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(-3.5d, -2d, 0.5d, -1.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(-1d, -7d, 2.5d, 2d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(-6d, -3d, 3d, 2d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec4(-6d, -2.5d, 1.5d, -4.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(2106111006);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.Random(random, (3), (6));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(4.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(1708711917);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomUniform(random, (1), (3));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(2).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(1936667287);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.Random(random, (4), (6));
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
    public void RandomUniform3()
    {
        var random = new Random(527095425);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomUniform(random, (-3), (-1));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-2).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-2).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-2).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-2).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(1364304790);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.Random(random, (3), (5));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(4).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomGaussian0()
    {
        var random = new Random(1385935214);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomNormal(random, 0.8165350308718788d, 1.9973989073175d);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.8165350308718788).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.8165350308718788).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.8165350308718788).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0.8165350308718788).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.9973989073175).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.9973989073175).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.9973989073175).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.9973989073175).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(1057724602);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomGaussian(random, -0.6554036748853529d, 9.544604951303734d);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.6554036748853529).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.6554036748853529).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.6554036748853529).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-0.6554036748853529).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(9.544604951303734).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(9.544604951303734).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(9.544604951303734).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(9.544604951303734).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(652722990);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomNormal(random, 1.145720123846885d, 0.019291755752308182d);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.145720123846885).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.145720123846885).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.145720123846885).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.145720123846885).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.019291755752308182).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.019291755752308182).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.019291755752308182).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.019291755752308182).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(351720576);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomGaussian(random, -1.0444543916007758d, 8.760369330998682d);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.0444543916007758).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.0444543916007758).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-1.0444543916007758).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-1.0444543916007758).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(8.760369330998682).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(8.760369330998682).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(8.760369330998682).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(8.760369330998682).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(955579884);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec4.RandomNormal(random, 0.5290489152674791d, 9.789267950593153d);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.5290489152674791).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.5290489152674791).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.5290489152674791).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0.5290489152674791).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(9.789267950593153).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(9.789267950593153).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(9.789267950593153).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(9.789267950593153).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(686464891);
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
        var random = new Random(879635525);
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
        var random = new Random(1726602066);
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
        var random = new Random(909757219);
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
        var random = new Random(1642605444);
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
