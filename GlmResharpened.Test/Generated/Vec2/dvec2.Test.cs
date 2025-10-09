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
public class DoubleVec2Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new dvec2(-8.5d);
            Assert.That(-8.5d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
        }
        {
            var v = new dvec2(6d, 9d);
            Assert.That(6d, Is.EqualTo(v.x));
            Assert.That(9d, Is.EqualTo(v.y));
        }
        {
            var v = new dvec2(new dvec2(-9d, -7d));
            Assert.That(-9d, Is.EqualTo(v.x));
            Assert.That(-7d, Is.EqualTo(v.y));
        }
        {
            var v = new dvec2(new dvec3(0.0, 0.5d, -4d));
            Assert.That(0.0, Is.EqualTo(v.x));
            Assert.That(0.5d, Is.EqualTo(v.y));
        }
        {
            var v = new dvec2(new dvec4(-7d, -8.5d, 3d, 0.5d));
            Assert.That(-7d, Is.EqualTo(v.x));
            Assert.That(-8.5d, Is.EqualTo(v.y));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new dvec2(7d, -1.5d);
        Assert.That(7d, Is.EqualTo(v[0]));
        Assert.That(-1.5d, Is.EqualTo(v[1]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0.0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0.0; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0.0; } );
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
        v[1] = 3d;
        Assert.That(3d, Is.EqualTo(v[1]));
        v[0] = 4d;
        Assert.That(4d, Is.EqualTo(v[0]));
        v[0] = 5d;
        Assert.That(5d, Is.EqualTo(v[0]));
        v[1] = 6d;
        Assert.That(6d, Is.EqualTo(v[1]));
        v[1] = 7d;
        Assert.That(7d, Is.EqualTo(v[1]));
        v[0] = 8d;
        Assert.That(8d, Is.EqualTo(v[0]));
        v[1] = 9d;
        Assert.That(9d, Is.EqualTo(v[1]));
        v[1] = -1d;
        Assert.That(-1d, Is.EqualTo(v[1]));
        v[0] = -2d;
        Assert.That(-2d, Is.EqualTo(v[0]));
        v[1] = -3d;
        Assert.That(-3d, Is.EqualTo(v[1]));
        v[1] = -4d;
        Assert.That(-4d, Is.EqualTo(v[1]));
        v[0] = -5d;
        Assert.That(-5d, Is.EqualTo(v[0]));
        v[1] = -6d;
        Assert.That(-6d, Is.EqualTo(v[1]));
        v[1] = -7d;
        Assert.That(-7d, Is.EqualTo(v[1]));
        v[0] = -8d;
        Assert.That(-8d, Is.EqualTo(v[0]));
        v[0] = -9d;
        Assert.That(-9d, Is.EqualTo(v[0]));
        v[0] = -9.5d;
        Assert.That(-9.5d, Is.EqualTo(v[0]));
        v[1] = -8.5d;
        Assert.That(-8.5d, Is.EqualTo(v[1]));
        v[1] = -7.5d;
        Assert.That(-7.5d, Is.EqualTo(v[1]));
        v[0] = -6.5d;
        Assert.That(-6.5d, Is.EqualTo(v[0]));
        v[1] = -5.5d;
        Assert.That(-5.5d, Is.EqualTo(v[1]));
        v[1] = -4.5d;
        Assert.That(-4.5d, Is.EqualTo(v[1]));
        v[0] = -3.5d;
        Assert.That(-3.5d, Is.EqualTo(v[0]));
        v[0] = -2.5d;
        Assert.That(-2.5d, Is.EqualTo(v[0]));
        v[0] = -1.5d;
        Assert.That(-1.5d, Is.EqualTo(v[0]));
        v[1] = -0.5d;
        Assert.That(-0.5d, Is.EqualTo(v[1]));
        v[0] = 0.5d;
        Assert.That(0.5d, Is.EqualTo(v[0]));
        v[1] = 1.5d;
        Assert.That(1.5d, Is.EqualTo(v[1]));
        v[1] = 2.5d;
        Assert.That(2.5d, Is.EqualTo(v[1]));
        v[1] = 3.5d;
        Assert.That(3.5d, Is.EqualTo(v[1]));
        v[1] = 4.5d;
        Assert.That(4.5d, Is.EqualTo(v[1]));
        v[0] = 5.5d;
        Assert.That(5.5d, Is.EqualTo(v[0]));
        v[0] = 6.5d;
        Assert.That(6.5d, Is.EqualTo(v[0]));
        v[0] = 7.5d;
        Assert.That(7.5d, Is.EqualTo(v[0]));
        v[1] = 8.5d;
        Assert.That(8.5d, Is.EqualTo(v[1]));
        v[0] = 9.5d;
        Assert.That(9.5d, Is.EqualTo(v[0]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new dvec2(-5.5d, -5d);
        var vals = v.Values;
        Assert.That(-5.5d, Is.EqualTo(vals[0]));
        Assert.That(-5d, Is.EqualTo(vals[1]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0.0, Is.EqualTo(dvec2.Zero.x));
        Assert.That(0.0, Is.EqualTo(dvec2.Zero.y));
        
        Assert.That(1.0, Is.EqualTo(dvec2.Ones.x));
        Assert.That(1.0, Is.EqualTo(dvec2.Ones.y));
        
        Assert.That(1.0, Is.EqualTo(dvec2.UnitX.x));
        Assert.That(0.0, Is.EqualTo(dvec2.UnitX.y));
        
        Assert.That(0.0, Is.EqualTo(dvec2.UnitY.x));
        Assert.That(1.0, Is.EqualTo(dvec2.UnitY.y));
        
        Assert.That(double.MaxValue, Is.EqualTo(dvec2.MaxValue.x));
        Assert.That(double.MaxValue, Is.EqualTo(dvec2.MaxValue.y));
        
        Assert.That(double.MinValue, Is.EqualTo(dvec2.MinValue.x));
        Assert.That(double.MinValue, Is.EqualTo(dvec2.MinValue.y));
        
        Assert.That(double.Epsilon, Is.EqualTo(dvec2.Epsilon.x));
        Assert.That(double.Epsilon, Is.EqualTo(dvec2.Epsilon.y));
        
        Assert.That(double.NaN, Is.EqualTo(dvec2.NaN.x));
        Assert.That(double.NaN, Is.EqualTo(dvec2.NaN.y));
        
        Assert.That(double.NegativeInfinity, Is.EqualTo(dvec2.NegativeInfinity.x));
        Assert.That(double.NegativeInfinity, Is.EqualTo(dvec2.NegativeInfinity.y));
        
        Assert.That(double.PositiveInfinity, Is.EqualTo(dvec2.PositiveInfinity.x));
        Assert.That(double.PositiveInfinity, Is.EqualTo(dvec2.PositiveInfinity.y));
    }

    [Test]
    public void Operators()
    {
        var v1 = new dvec2(-9.5d, 8.5d);
        var v2 = new dvec2(-9.5d, 8.5d);
        var v3 = new dvec2(8.5d, -9.5d);
        Assert.That(v1 == new dvec2(v1));
        Assert.That(v2 == new dvec2(v2));
        Assert.That(v3 == new dvec2(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new dvec2(7.5d, -7d);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = dvec2.Parse(s0);
        var v1 = dvec2.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = dvec2.TryParse(s0, out v0);
        var b1 = dvec2.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = dvec2.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = dvec2.TryParse("", out v0);
        Assert.That(!b0);
        b0 = dvec2.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { dvec2.Parse(null); });
        Assert.Throws<FormatException>(() => { dvec2.Parse(""); });
        Assert.Throws<FormatException>(() => { dvec2.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = dvec2.Parse(s3, "; ", NumberStyles.Number);
        var v4 = dvec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = dvec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new dvec2(-2d, 9.5d);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<dvec2>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new dvec2(-9.5d, 1.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec2(7.5d, 1.0);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec2(-2d, -5.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec2(9d, 2d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec2(-6d, -5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec2(-7d, -9d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec2(-9.5d, 6.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec2(3d, -5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec2(5.5d, -1.5d);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new dvec2(-9.5d, 1.0);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new dvec2(-7.5d, 0.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec2(-1.5d, -6d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec2(-2d, -6d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec2(-8d, -9.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec2(-8.5d, 5.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec2(-9.5d, -9.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec2(8.5d, -1.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec2(-7d, 3d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec2(8.5d, -2.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new dvec2(7.5d, 3.5d);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new dvec2(7.5d, 8d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec2(-9d, -9d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec2(5d, -8.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec2(6d, 2.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec2(-2.5d, 5.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec2(9.5d, 4.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec2(-3d, 2d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec2(5d, -5.5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec2(-8.5d, 5d);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new dvec2(2d, 1.0);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new dvec2(2d, 3d);
            var v1 = new dvec2(-3.5d, -7d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec2(-8d, 4.5d);
            var v1 = new dvec2(9d, -1d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec2(6.5d, -6.5d);
            var v1 = new dvec2(-8d, 8d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec2(2d, -5.5d);
            var v1 = new dvec2(0.5d, 9d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec2(9d, 8d);
            var v1 = new dvec2(4d, 5.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec2(0.5d, 7d);
            var v1 = new dvec2(6.5d, -6.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec2(-5d, -1d);
            var v1 = new dvec2(0.0, -1.5d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec2(-1d, 9d);
            var v1 = new dvec2(-0.5d, -4d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec2(9.5d, 0.0);
            var v1 = new dvec2(8.5d, 3d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new dvec2(-6.5d, -2.5d);
            var v1 = new dvec2(-8.5d, -2d);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new dvec2(6d, -1.5d);
            var v1 = new dvec2(-8d, 3d);
            var v2 = new dvec2(3.5d, -5.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec2(6d, 6d);
            var v1 = new dvec2(3d, 2.5d);
            var v2 = new dvec2(-6.5d, -2.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec2(-3.5d, 6.5d);
            var v1 = new dvec2(3d, -1d);
            var v2 = new dvec2(0.0, -6d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec2(7.5d, -2.5d);
            var v1 = new dvec2(6.5d, 9d);
            var v2 = new dvec2(7d, -6.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec2(-8.5d, 6.5d);
            var v1 = new dvec2(-6.5d, 2.5d);
            var v2 = new dvec2(-8.5d, -4d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec2(-0.5d, -1.5d);
            var v1 = new dvec2(-8d, 4d);
            var v2 = new dvec2(6.5d, -8.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec2(3.5d, 9d);
            var v1 = new dvec2(4.5d, -4.5d);
            var v2 = new dvec2(1.5d, -4d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec2(3.5d, -8d);
            var v1 = new dvec2(-7d, 3d);
            var v2 = new dvec2(-7.5d, 0.0);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec2(-6.5d, 0.0);
            var v1 = new dvec2(5.5d, 6.5d);
            var v2 = new dvec2(5.5d, -9.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new dvec2(-5.5d, 7.5d);
            var v1 = new dvec2(-9.5d, 4.5d);
            var v2 = new dvec2(-7.5d, 6.5d);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new dvec2(-4d, 8d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec2(-9.5d, -7.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec2(-2d, -3.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec2(3.5d, -1d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec2(-9d, 5.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec2(7.5d, 5.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec2(-7d, 5.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec2(8d, -6d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec2(3.5d, 4.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new dvec2(2d, 7.5d);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new dvec2(6d, -3d);
            var v1 = new dvec2(-2d, -9d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec2(-4d, -7.5d);
            var v1 = new dvec2(2.5d, -5.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec2(-9.5d, -2d);
            var v1 = new dvec2(-4.5d, 8.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec2(1.0, 5.5d);
            var v1 = new dvec2(-7d, -7d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec2(-8d, -6.5d);
            var v1 = new dvec2(7.5d, -9d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec2(3d, 8d);
            var v1 = new dvec2(8d, -3d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec2(9.5d, 3.5d);
            var v1 = new dvec2(3d, 0.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec2(-6d, 6.5d);
            var v1 = new dvec2(-2.5d, 4.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec2(-5.5d, -6.5d);
            var v1 = new dvec2(5.5d, -2.5d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new dvec2(-2d, -5d);
            var v1 = new dvec2(-2d, -6d);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new dvec2(0.0, 1.0);
            var v1 = new dvec2(-6d, -2.5d);
            var v2 = new dvec2(-1d, -5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec2(-9d, -4.5d);
            var v1 = new dvec2(7d, -8.5d);
            var v2 = new dvec2(6.5d, -0.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec2(-1.5d, 5.5d);
            var v1 = new dvec2(8.5d, -8d);
            var v2 = new dvec2(6.5d, -4d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec2(-6d, 2.5d);
            var v1 = new dvec2(4d, 8d);
            var v2 = new dvec2(2.5d, 8.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec2(6.5d, 3d);
            var v1 = new dvec2(-1d, 0.0);
            var v2 = new dvec2(-3.5d, 3.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec2(1.0, 4.5d);
            var v1 = new dvec2(1.0, 6d);
            var v2 = new dvec2(-7d, 4d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec2(0.5d, -3.5d);
            var v1 = new dvec2(9d, 5d);
            var v2 = new dvec2(2.5d, 5.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec2(-9.5d, -5d);
            var v1 = new dvec2(0.0, 2d);
            var v2 = new dvec2(-7.5d, 4.5d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec2(-2.5d, 0.5d);
            var v1 = new dvec2(2d, 8d);
            var v2 = new dvec2(0.5d, 4d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new dvec2(9.5d, 1.5d);
            var v1 = new dvec2(9d, -8d);
            var v2 = new dvec2(0.5d, 7d);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new dvec2(4d, 3d);
            var v1 = new dvec2(8d, 3.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec2(3.5d, -1.5d);
            var v1 = new dvec2(6d, 9.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec2(-7.5d, -0.5d);
            var v1 = new dvec2(3d, -9.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec2(-9d, 0.5d);
            var v1 = new dvec2(6.5d, 3.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec2(9.5d, 2d);
            var v1 = new dvec2(1.0, 6d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec2(8.5d, -8.5d);
            var v1 = new dvec2(7d, 6.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec2(8.5d, -3d);
            var v1 = new dvec2(-9.5d, 9d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec2(8d, 3d);
            var v1 = new dvec2(7.5d, 9.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec2(6d, 0.0);
            var v1 = new dvec2(-0.5d, -4.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new dvec2(2d, 5.5d);
            var v1 = new dvec2(-7.5d, 9.5d);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new dvec2(4d, 0.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec2(-3d, -7d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec2(-6.5d, -7.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec2(-1d, 3.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec2(9d, 4d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec2(-8.5d, 9.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec2(-2d, 9d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec2(-6d, 2d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec2(-3.5d, -2.5d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new dvec2(-8d, -6d);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(371445437);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.Random(random, (-4), (0));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-2).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-2).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(1778267687);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.RandomUniform(random, (4), (6));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(1834133362);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.Random(random, (-4), (-3));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-3.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-3.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(952889909);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.RandomUniform(random, (-2), (0));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(318742033);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.Random(random, (-4), (-3));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-3.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-3.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomGaussian0()
    {
        var random = new Random(777894123);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.RandomNormal(random, -1.0722697689534488d, 0.06482429805436371d);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.0722697689534488).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.0722697689534488).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.06482429805436371).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.06482429805436371).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(100189888);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.RandomGaussian(random, 1.6299057824676417d, 2.499559816205669d);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.6299057824676417).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.6299057824676417).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.499559816205669).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.499559816205669).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(1961789103);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.RandomNormal(random, -1.7648210822440782d, 1.4253775456107118d);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.7648210822440782).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.7648210822440782).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.4253775456107118).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.4253775456107118).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(885308455);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.RandomGaussian(random, 0.7575332106824653d, 7.823780042968588d);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.7575332106824653).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.7575332106824653).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(7.823780042968588).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(7.823780042968588).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(716422904);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.RandomNormal(random, 0.15546844254968128d, 3.672586229477351d);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.15546844254968128).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.15546844254968128).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.672586229477351).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.672586229477351).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(174425888);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.RandomNormal(random);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
    }

    [Test]
    public void RandomNormal1()
    {
        var random = new Random(1641085234);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.RandomNormal(random);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
    }

    [Test]
    public void RandomNormal2()
    {
        var random = new Random(510010976);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.RandomNormal(random);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
    }

    [Test]
    public void RandomNormal3()
    {
        var random = new Random(1932421238);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.RandomNormal(random);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
    }

    [Test]
    public void RandomNormal4()
    {
        var random = new Random(547979741);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = dvec2.RandomNormal(random);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1).Within(3.0));
    }

}
