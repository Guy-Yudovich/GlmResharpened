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
public class DecimalVec3Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new decvec3(-0.5m);
            Assert.That(-0.5m, Is.EqualTo(v.x));
            Assert.That(-0.5m, Is.EqualTo(v.y));
            Assert.That(-0.5m, Is.EqualTo(v.z));
        }
        {
            var v = new decvec3(0.5m, 1.5m, -6.5m);
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
        }
        {
            var v = new decvec3(new decvec2(5m, 4.5m));
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(4.5m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
        }
        {
            var v = new decvec3(new decvec3(3.5m, 8m, 4.5m));
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(8m, Is.EqualTo(v.y));
            Assert.That(4.5m, Is.EqualTo(v.z));
        }
        {
            var v = new decvec3(new decvec4(-3.5m, 1.5m, -9m, 1.5m));
            Assert.That(-3.5m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new decvec3(0m, 4m, 6m);
        Assert.That(0m, Is.EqualTo(v[0]));
        Assert.That(4m, Is.EqualTo(v[1]));
        Assert.That(6m, Is.EqualTo(v[2]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0m; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0m; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0m; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0m; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0m; } );
        
        v[1] = 0m;
        Assert.That(0m, Is.EqualTo(v[1]));
        v[1] = 1m;
        Assert.That(1m, Is.EqualTo(v[1]));
        v[2] = 2m;
        Assert.That(2m, Is.EqualTo(v[2]));
        v[0] = 3m;
        Assert.That(3m, Is.EqualTo(v[0]));
        v[0] = 4m;
        Assert.That(4m, Is.EqualTo(v[0]));
        v[1] = 5m;
        Assert.That(5m, Is.EqualTo(v[1]));
        v[1] = 6m;
        Assert.That(6m, Is.EqualTo(v[1]));
        v[2] = 7m;
        Assert.That(7m, Is.EqualTo(v[2]));
        v[0] = 8m;
        Assert.That(8m, Is.EqualTo(v[0]));
        v[0] = 9m;
        Assert.That(9m, Is.EqualTo(v[0]));
        v[1] = -1m;
        Assert.That(-1m, Is.EqualTo(v[1]));
        v[0] = -2m;
        Assert.That(-2m, Is.EqualTo(v[0]));
        v[0] = -3m;
        Assert.That(-3m, Is.EqualTo(v[0]));
        v[1] = -4m;
        Assert.That(-4m, Is.EqualTo(v[1]));
        v[2] = -5m;
        Assert.That(-5m, Is.EqualTo(v[2]));
        v[2] = -6m;
        Assert.That(-6m, Is.EqualTo(v[2]));
        v[1] = -7m;
        Assert.That(-7m, Is.EqualTo(v[1]));
        v[0] = -8m;
        Assert.That(-8m, Is.EqualTo(v[0]));
        v[2] = -9m;
        Assert.That(-9m, Is.EqualTo(v[2]));
        v[2] = -9.5m;
        Assert.That(-9.5m, Is.EqualTo(v[2]));
        v[2] = -8.5m;
        Assert.That(-8.5m, Is.EqualTo(v[2]));
        v[0] = -7.5m;
        Assert.That(-7.5m, Is.EqualTo(v[0]));
        v[1] = -6.5m;
        Assert.That(-6.5m, Is.EqualTo(v[1]));
        v[1] = -5.5m;
        Assert.That(-5.5m, Is.EqualTo(v[1]));
        v[1] = -4.5m;
        Assert.That(-4.5m, Is.EqualTo(v[1]));
        v[2] = -3.5m;
        Assert.That(-3.5m, Is.EqualTo(v[2]));
        v[0] = -2.5m;
        Assert.That(-2.5m, Is.EqualTo(v[0]));
        v[0] = -1.5m;
        Assert.That(-1.5m, Is.EqualTo(v[0]));
        v[1] = -0.5m;
        Assert.That(-0.5m, Is.EqualTo(v[1]));
        v[0] = 0.5m;
        Assert.That(0.5m, Is.EqualTo(v[0]));
        v[2] = 1.5m;
        Assert.That(1.5m, Is.EqualTo(v[2]));
        v[0] = 2.5m;
        Assert.That(2.5m, Is.EqualTo(v[0]));
        v[0] = 3.5m;
        Assert.That(3.5m, Is.EqualTo(v[0]));
        v[2] = 4.5m;
        Assert.That(4.5m, Is.EqualTo(v[2]));
        v[0] = 5.5m;
        Assert.That(5.5m, Is.EqualTo(v[0]));
        v[2] = 6.5m;
        Assert.That(6.5m, Is.EqualTo(v[2]));
        v[0] = 7.5m;
        Assert.That(7.5m, Is.EqualTo(v[0]));
        v[2] = 8.5m;
        Assert.That(8.5m, Is.EqualTo(v[2]));
        v[2] = 9.5m;
        Assert.That(9.5m, Is.EqualTo(v[2]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new decvec3(-3.5m, -2.5m, -4.5m);
        var vals = v.Values;
        Assert.That(-3.5m, Is.EqualTo(vals[0]));
        Assert.That(-2.5m, Is.EqualTo(vals[1]));
        Assert.That(-4.5m, Is.EqualTo(vals[2]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0m, Is.EqualTo(decvec3.Zero.x));
        Assert.That(0m, Is.EqualTo(decvec3.Zero.y));
        Assert.That(0m, Is.EqualTo(decvec3.Zero.z));
        
        Assert.That(1m, Is.EqualTo(decvec3.Ones.x));
        Assert.That(1m, Is.EqualTo(decvec3.Ones.y));
        Assert.That(1m, Is.EqualTo(decvec3.Ones.z));
        
        Assert.That(1m, Is.EqualTo(decvec3.UnitX.x));
        Assert.That(0m, Is.EqualTo(decvec3.UnitX.y));
        Assert.That(0m, Is.EqualTo(decvec3.UnitX.z));
        
        Assert.That(0m, Is.EqualTo(decvec3.UnitY.x));
        Assert.That(1m, Is.EqualTo(decvec3.UnitY.y));
        Assert.That(0m, Is.EqualTo(decvec3.UnitY.z));
        
        Assert.That(0m, Is.EqualTo(decvec3.UnitZ.x));
        Assert.That(0m, Is.EqualTo(decvec3.UnitZ.y));
        Assert.That(1m, Is.EqualTo(decvec3.UnitZ.z));
        
        Assert.That(decimal.MaxValue, Is.EqualTo(decvec3.MaxValue.x));
        Assert.That(decimal.MaxValue, Is.EqualTo(decvec3.MaxValue.y));
        Assert.That(decimal.MaxValue, Is.EqualTo(decvec3.MaxValue.z));
        
        Assert.That(decimal.MinValue, Is.EqualTo(decvec3.MinValue.x));
        Assert.That(decimal.MinValue, Is.EqualTo(decvec3.MinValue.y));
        Assert.That(decimal.MinValue, Is.EqualTo(decvec3.MinValue.z));
        
        Assert.That(decimal.MinusOne, Is.EqualTo(decvec3.MinusOne.x));
        Assert.That(decimal.MinusOne, Is.EqualTo(decvec3.MinusOne.y));
        Assert.That(decimal.MinusOne, Is.EqualTo(decvec3.MinusOne.z));
    }

    [Test]
    public void Operators()
    {
        var v1 = new decvec3(7m, 3.5m, -6m);
        var v2 = new decvec3(7m, 3.5m, -6m);
        var v3 = new decvec3(-6m, 3.5m, 7m);
        Assert.That(v1 == new decvec3(v1));
        Assert.That(v2 == new decvec3(v2));
        Assert.That(v3 == new decvec3(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new decvec3(-4m, -4.5m, -9m);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = decvec3.Parse(s0);
        var v1 = decvec3.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = decvec3.TryParse(s0, out v0);
        var b1 = decvec3.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = decvec3.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = decvec3.TryParse("", out v0);
        Assert.That(!b0);
        b0 = decvec3.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { decvec3.Parse(null); });
        Assert.Throws<FormatException>(() => { decvec3.Parse(""); });
        Assert.Throws<FormatException>(() => { decvec3.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = decvec3.Parse(s3, "; ", NumberStyles.Number);
        var v4 = decvec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = decvec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new decvec3(-9.5m, -6.5m, 4m);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<decvec3>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new decvec3(-2.5m, -4m, -9m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(5m, 0m, -9m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(-3m, 7.5m, 2.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(-9m, 4m, 8m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(4m, -9.5m, 2.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(7.5m, 4.5m, -4m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(-1m, 4.5m, -8m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(-1.5m, -1.5m, -5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(9m, -9m, 0.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(-2m, -9.5m, -5.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new decvec3(5m, 1m, 0.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(9m, -0.5m, -4m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(-4m, -1m, 3m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(-8.5m, -1m, -0.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(-2m, 4.5m, -2.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(0.5m, -5.5m, 7m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(9m, -6m, 9m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(-8m, 4.5m, -8m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(3.5m, 0.5m, 6m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(5.5m, -4.5m, -0.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new decvec3(0.5m, -4.5m, 7.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(-5m, -7m, -2.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(3m, 7.5m, 9m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(1.5m, -2m, 5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(-1.5m, -9m, -7m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(2m, -8.5m, -9.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(-2m, 7m, -6.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(2.5m, -5m, -7.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(-8m, 1.5m, 0m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(-8m, 3m, -9m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new decvec3(-8m, -5.5m, -1.5m);
            var v1 = new decvec3(8m, 4.5m, -4m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-0.5m, 7.5m, -2m);
            var v1 = new decvec3(8.5m, -9.5m, -4m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(3.5m, -8.5m, -3.5m);
            var v1 = new decvec3(4.5m, -5m, -5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(2m, 4.5m, 3m);
            var v1 = new decvec3(-5.5m, -6m, 2.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-8m, 0m, -5.5m);
            var v1 = new decvec3(-7m, -6m, -6m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(7m, 7.5m, -7.5m);
            var v1 = new decvec3(9.5m, 8.5m, 7.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(5.5m, 8m, 7.5m);
            var v1 = new decvec3(7.5m, -8m, -9.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(8m, -1m, -9.5m);
            var v1 = new decvec3(-6m, 6.5m, -7.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-5m, 8m, 4m);
            var v1 = new decvec3(8m, -1m, 9m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-7m, 3.5m, 8m);
            var v1 = new decvec3(6.5m, 1.5m, 3.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new decvec3(-4m, -2m, 9.5m);
            var v1 = new decvec3(6m, -7.5m, -9m);
            var v2 = new decvec3(9m, 1m, -9.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(7.5m, -2m, -7m);
            var v1 = new decvec3(-1m, -8.5m, 2.5m);
            var v2 = new decvec3(2.5m, 9.5m, 1m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(-1.5m, -9.5m, -3.5m);
            var v1 = new decvec3(-3.5m, 5m, 8m);
            var v2 = new decvec3(-4.5m, -1m, 5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(-2m, 8m, -7m);
            var v1 = new decvec3(-3m, -9.5m, 5.5m);
            var v2 = new decvec3(9.5m, -7.5m, 9.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(5m, 8m, -3m);
            var v1 = new decvec3(5.5m, -2m, 4.5m);
            var v2 = new decvec3(1m, 2m, -5.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(0.5m, -4m, 1.5m);
            var v1 = new decvec3(9m, -6.5m, -5.5m);
            var v2 = new decvec3(-6m, 5.5m, 2m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(-2m, -2.5m, 5m);
            var v1 = new decvec3(0.5m, -7.5m, -1m);
            var v2 = new decvec3(-3m, 8.5m, 3.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(3m, -5.5m, 2.5m);
            var v1 = new decvec3(-8.5m, -2m, 9.5m);
            var v2 = new decvec3(3.5m, -2.5m, 1.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(-1.5m, 3.5m, 7m);
            var v1 = new decvec3(2.5m, -5.5m, 2m);
            var v2 = new decvec3(-5.5m, 4.5m, 7.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(-4m, 2m, -4.5m);
            var v1 = new decvec3(2.5m, 7.5m, -5.5m);
            var v2 = new decvec3(2.5m, -2.5m, 4.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new decvec3(-8.5m, 2.5m, 1m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(-3.5m, 9.5m, -9.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(7.5m, 5m, 6.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(0m, -4.5m, -5.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(1m, -9.5m, 7.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(7.5m, 2.5m, -9.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(3.5m, 1.5m, 6m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(7m, 7.5m, 0m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(-3.5m, 1.5m, -3m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(5.5m, -0.5m, 9.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new decvec3(-4m, 6.5m, 3.5m);
            var v1 = new decvec3(-6.5m, 2m, -7m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(5.5m, -9m, 6.5m);
            var v1 = new decvec3(-7m, -4m, -2.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(-3.5m, -9.5m, 6m);
            var v1 = new decvec3(9.5m, -8m, 8m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(-2.5m, -3m, 3.5m);
            var v1 = new decvec3(-3.5m, 6m, 8.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(3m, 7m, -3.5m);
            var v1 = new decvec3(9m, 2m, 9.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(-1m, -4.5m, 1m);
            var v1 = new decvec3(-7m, -9.5m, 4m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(-4.5m, -4m, 1.5m);
            var v1 = new decvec3(-3.5m, -1.5m, -7m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(3m, 1m, 1.5m);
            var v1 = new decvec3(-2.5m, -6m, -2.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(2.5m, -1m, -2.5m);
            var v1 = new decvec3(1.5m, -2m, 0m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(-1.5m, -1.5m, -0.5m);
            var v1 = new decvec3(4.5m, -9.5m, 5.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new decvec3(3.5m, -8m, 4.5m);
            var v1 = new decvec3(-6.5m, -7.5m, -8.5m);
            var v2 = new decvec3(-6m, 0.5m, 0.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-6m, 7m, 0m);
            var v1 = new decvec3(3m, -1m, 9m);
            var v2 = new decvec3(6.5m, 6.5m, -1.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-4.5m, 8.5m, -5m);
            var v1 = new decvec3(1.5m, 4.5m, -2m);
            var v2 = new decvec3(2.5m, -0.5m, -1.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-8.5m, 8.5m, 1.5m);
            var v1 = new decvec3(-7m, 3m, -5.5m);
            var v2 = new decvec3(-2m, 2.5m, -3.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-7m, -2.5m, 0.5m);
            var v1 = new decvec3(5.5m, -2m, -6m);
            var v2 = new decvec3(-1m, -0.5m, 3.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-5m, 0.5m, 3m);
            var v1 = new decvec3(0m, 7m, -4m);
            var v2 = new decvec3(-0.5m, 0.5m, -8.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-3m, 1m, -6.5m);
            var v1 = new decvec3(-6.5m, 0.5m, 3.5m);
            var v2 = new decvec3(2.5m, 5.5m, 1.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(9.5m, 8.5m, 4m);
            var v1 = new decvec3(-6m, 1.5m, -9m);
            var v2 = new decvec3(-6.5m, -9m, 9m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(7.5m, 0.5m, -2.5m);
            var v1 = new decvec3(9.5m, -8.5m, 4m);
            var v2 = new decvec3(-9m, -8m, 8.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-4.5m, -9.5m, 1.5m);
            var v1 = new decvec3(-7m, -1.5m, -3m);
            var v2 = new decvec3(2m, 9.5m, 0.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new decvec3(4m, -4.5m, -8m);
            var v1 = new decvec3(9m, -7.5m, -3.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(8m, -1.5m, 6m);
            var v1 = new decvec3(-9m, 8.5m, -5.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(3.5m, 9m, 6m);
            var v1 = new decvec3(5.5m, 3m, 2.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(6.5m, 8m, 2m);
            var v1 = new decvec3(9.5m, -8m, 8.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(-4.5m, 8.5m, -6.5m);
            var v1 = new decvec3(-1m, -8.5m, 9m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(-6.5m, -9m, -9m);
            var v1 = new decvec3(-9.5m, -4.5m, -1.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(8m, 1.5m, -8m);
            var v1 = new decvec3(8.5m, -2.5m, -4.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(-9.5m, -4.5m, 8.5m);
            var v1 = new decvec3(6.5m, -6m, -9m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(-2m, 0m, -9.5m);
            var v1 = new decvec3(-2m, -3.5m, -5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(-7m, 5m, 7m);
            var v1 = new decvec3(-9.5m, -5.5m, -5.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new decvec3(5m, -2m, -2.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-5.5m, 4m, -1.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-9m, 7m, -2m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-2m, -4m, 8m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-5m, 3m, 3.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-8m, 3m, -2.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(5m, -7m, 0.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-8m, -4.5m, -6m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(1m, -6.5m, -6.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-9m, 3.5m, 8.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void InvariantCrossDot()
    {
        {
            var v0 = new decvec3(-4.5m, 8.5m, 4.5m);
            var v1 = new decvec3(1.5m, 2m, 2m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-9.5m, -9m, 4m);
            var v1 = new decvec3(-6m, 7m, 2.5m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(3.5m, 8m, -7m);
            var v1 = new decvec3(1m, 4m, 4m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(6m, 9m, 1m);
            var v1 = new decvec3(-6.5m, 7m, -9m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(6.5m, 6m, 4m);
            var v1 = new decvec3(9.5m, -5.5m, -2m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-4.5m, 2.5m, 9.5m);
            var v1 = new decvec3(4m, -9.5m, -3.5m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-8.5m, 6.5m, 0.5m);
            var v1 = new decvec3(2m, 9.5m, 2.5m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-8.5m, -4.5m, 1m);
            var v1 = new decvec3(3m, 3m, 9m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-1.5m, 1m, 8.5m);
            var v1 = new decvec3(-6.5m, -4m, 6m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-9m, 1m, 0.5m);
            var v1 = new decvec3(-6m, 4.5m, 5.5m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(1106159048);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.Random(random, (4), (7));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(5.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(5.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(5.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(931342356);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomUniform(random, (3), (4));
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
    public void RandomUniform2()
    {
        var random = new Random(96230764);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.Random(random, (4), (8));
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
        var random = new Random(1362470958);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomUniform(random, (4), (8));
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
    public void RandomUniform4()
    {
        var random = new Random(728323082);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.Random(random, (2), (5));
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
    public void RandomGaussian0()
    {
        var random = new Random(368313074);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomNormal(random, 1.2632582277354123m, 5.410060247131652m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.2632582277354123).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.2632582277354123).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.2632582277354123).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(5.410060247131652).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(5.410060247131652).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(5.410060247131652).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(1377414597);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomGaussian(random, -0.7056222142212196m, 7.154323867128381m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.7056222142212196).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.7056222142212196).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.7056222142212196).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(7.154323867128381).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(7.154323867128381).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(7.154323867128381).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(747820940);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomNormal(random, 0.9863008963811679m, 3.2600720288511704m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.9863008963811679).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.9863008963811679).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.9863008963811679).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.2600720288511704).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.2600720288511704).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(3.2600720288511704).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(1824301588);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomGaussian(random, -0.5544583306435766m, 2.1914377958473925m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.5544583306435766).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.5544583306435766).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.5544583306435766).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.1914377958473925).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.1914377958473925).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.1914377958473925).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(1993187139);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomNormal(random, 0.04760643748920712m, 6.342631637278307m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.04760643748920712).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.04760643748920712).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.04760643748920712).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(6.342631637278307).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(6.342631637278307).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(6.342631637278307).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(1912328486);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomNormal(random);
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
        var random = new Random(1984002898);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomNormal(random);
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
        var random = new Random(52115420);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomNormal(random);
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
        var random = new Random(194518640);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomNormal(random);
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
        var random = new Random(957560790);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomNormal(random);
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
