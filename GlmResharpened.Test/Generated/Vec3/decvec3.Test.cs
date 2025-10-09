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
            var v = new decvec3(-6.5m);
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(-6.5m, Is.EqualTo(v.y));
            Assert.That(-6.5m, Is.EqualTo(v.z));
        }
        {
            var v = new decvec3(3.5m, -6m, -9.5m);
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(-6m, Is.EqualTo(v.y));
            Assert.That(-9.5m, Is.EqualTo(v.z));
        }
        {
            var v = new decvec3(new decvec2(5m, 7m));
            Assert.That(5m, Is.EqualTo(v.x));
            Assert.That(7m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
        }
        {
            var v = new decvec3(new decvec3(0m, -7m, -7.5m));
            Assert.That(0m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(-7.5m, Is.EqualTo(v.z));
        }
        {
            var v = new decvec3(new decvec4(-6.5m, 9.5m, -5.5m, 1m));
            Assert.That(-6.5m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(-5.5m, Is.EqualTo(v.z));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new decvec3(6.5m, 1m, 5.5m);
        Assert.That(6.5m, Is.EqualTo(v[0]));
        Assert.That(1m, Is.EqualTo(v[1]));
        Assert.That(5.5m, Is.EqualTo(v[2]));
        
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
        
        v[2] = 0m;
        Assert.That(0m, Is.EqualTo(v[2]));
        v[2] = 1m;
        Assert.That(1m, Is.EqualTo(v[2]));
        v[0] = 2m;
        Assert.That(2m, Is.EqualTo(v[0]));
        v[2] = 3m;
        Assert.That(3m, Is.EqualTo(v[2]));
        v[0] = 4m;
        Assert.That(4m, Is.EqualTo(v[0]));
        v[1] = 5m;
        Assert.That(5m, Is.EqualTo(v[1]));
        v[1] = 6m;
        Assert.That(6m, Is.EqualTo(v[1]));
        v[2] = 7m;
        Assert.That(7m, Is.EqualTo(v[2]));
        v[1] = 8m;
        Assert.That(8m, Is.EqualTo(v[1]));
        v[1] = 9m;
        Assert.That(9m, Is.EqualTo(v[1]));
        v[2] = -1m;
        Assert.That(-1m, Is.EqualTo(v[2]));
        v[2] = -2m;
        Assert.That(-2m, Is.EqualTo(v[2]));
        v[2] = -3m;
        Assert.That(-3m, Is.EqualTo(v[2]));
        v[1] = -4m;
        Assert.That(-4m, Is.EqualTo(v[1]));
        v[2] = -5m;
        Assert.That(-5m, Is.EqualTo(v[2]));
        v[2] = -6m;
        Assert.That(-6m, Is.EqualTo(v[2]));
        v[1] = -7m;
        Assert.That(-7m, Is.EqualTo(v[1]));
        v[2] = -8m;
        Assert.That(-8m, Is.EqualTo(v[2]));
        v[1] = -9m;
        Assert.That(-9m, Is.EqualTo(v[1]));
        v[0] = -9.5m;
        Assert.That(-9.5m, Is.EqualTo(v[0]));
        v[2] = -8.5m;
        Assert.That(-8.5m, Is.EqualTo(v[2]));
        v[0] = -7.5m;
        Assert.That(-7.5m, Is.EqualTo(v[0]));
        v[2] = -6.5m;
        Assert.That(-6.5m, Is.EqualTo(v[2]));
        v[0] = -5.5m;
        Assert.That(-5.5m, Is.EqualTo(v[0]));
        v[1] = -4.5m;
        Assert.That(-4.5m, Is.EqualTo(v[1]));
        v[2] = -3.5m;
        Assert.That(-3.5m, Is.EqualTo(v[2]));
        v[2] = -2.5m;
        Assert.That(-2.5m, Is.EqualTo(v[2]));
        v[2] = -1.5m;
        Assert.That(-1.5m, Is.EqualTo(v[2]));
        v[2] = -0.5m;
        Assert.That(-0.5m, Is.EqualTo(v[2]));
        v[2] = 0.5m;
        Assert.That(0.5m, Is.EqualTo(v[2]));
        v[1] = 1.5m;
        Assert.That(1.5m, Is.EqualTo(v[1]));
        v[1] = 2.5m;
        Assert.That(2.5m, Is.EqualTo(v[1]));
        v[0] = 3.5m;
        Assert.That(3.5m, Is.EqualTo(v[0]));
        v[1] = 4.5m;
        Assert.That(4.5m, Is.EqualTo(v[1]));
        v[0] = 5.5m;
        Assert.That(5.5m, Is.EqualTo(v[0]));
        v[2] = 6.5m;
        Assert.That(6.5m, Is.EqualTo(v[2]));
        v[2] = 7.5m;
        Assert.That(7.5m, Is.EqualTo(v[2]));
        v[0] = 8.5m;
        Assert.That(8.5m, Is.EqualTo(v[0]));
        v[1] = 9.5m;
        Assert.That(9.5m, Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new decvec3(-0.5m, 8m, -0.5m);
        var vals = v.Values;
        Assert.That(-0.5m, Is.EqualTo(vals[0]));
        Assert.That(8m, Is.EqualTo(vals[1]));
        Assert.That(-0.5m, Is.EqualTo(vals[2]));
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
        var v1 = new decvec3(-9.5m, -1.5m, 9.5m);
        var v2 = new decvec3(-9.5m, -1.5m, 9.5m);
        var v3 = new decvec3(9.5m, -1.5m, -9.5m);
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
        var v = new decvec3(-9.5m, -8m, -7m);
        
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
        var v0 = new decvec3(6m, -9.5m, -8.5m);
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
            var v0 = new decvec3(6m, 9.5m, 8m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(1.5m, 6.5m, -6m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(-4m, -5.5m, -9.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(9.5m, 2m, 9m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(-9m, 2m, 8m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(9.5m, 1.5m, 6.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(-9m, 1.5m, 4m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(3m, 4m, -0.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(3.5m, -9.5m, 5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(8m, 6m, -5.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new decvec3(2m, 8.5m, 6m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(-9m, -1.5m, 1.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(1.5m, 1m, 2.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(-1m, -8m, 6m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(5m, 5.5m, -6.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(2m, -3.5m, 8m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(8.5m, 7.5m, -9.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(0m, 4m, -4m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(1m, 1.5m, 0m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(0m, -9.5m, 6m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new decvec3(8.5m, -9m, -9.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(9m, -1.5m, -8m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(-5.5m, -3m, 2.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(3m, 3m, -7.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(-9.5m, 5.5m, 1.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(1.5m, 8.5m, 1.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(-7m, -9.5m, -5.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(-2m, -8.5m, 8.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(4.5m, -2m, 2.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(0m, 7m, -6m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new decvec3(2.5m, 6.5m, 8m);
            var v1 = new decvec3(-3.5m, 2m, 3.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-8m, 1m, -4m);
            var v1 = new decvec3(-3m, -2.5m, -5.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-6m, -4.5m, -5m);
            var v1 = new decvec3(6m, -0.5m, -9m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-3.5m, -2m, 9m);
            var v1 = new decvec3(-8m, 6.5m, -2m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-9.5m, -7.5m, 0m);
            var v1 = new decvec3(-8m, 7m, -4.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-7m, -5m, -3.5m);
            var v1 = new decvec3(-5.5m, -4.5m, -6m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-2m, 1.5m, 3.5m);
            var v1 = new decvec3(0.5m, 3.5m, 2m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-3.5m, 1m, 0m);
            var v1 = new decvec3(-1m, -8.5m, 6m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(8m, -7m, 3m);
            var v1 = new decvec3(-1.5m, 7m, 2.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-6m, -4m, 9.5m);
            var v1 = new decvec3(7.5m, 5m, -8.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new decvec3(-5.5m, -4.5m, -8.5m);
            var v1 = new decvec3(7m, 8.5m, 7m);
            var v2 = new decvec3(-5m, -2m, -3.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(1m, 9.5m, 6.5m);
            var v1 = new decvec3(-3.5m, -9.5m, 2.5m);
            var v2 = new decvec3(6m, 6.5m, 2m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(-1m, 6.5m, -7m);
            var v1 = new decvec3(-9m, 6m, 9.5m);
            var v2 = new decvec3(-5.5m, -7.5m, -2m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(-9.5m, -8m, -2.5m);
            var v1 = new decvec3(-9.5m, 6m, 2m);
            var v2 = new decvec3(-6.5m, -1.5m, 0m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(4m, -2.5m, -6.5m);
            var v1 = new decvec3(2.5m, -4.5m, -4.5m);
            var v2 = new decvec3(6m, 2m, 6m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(-2.5m, -1m, -8.5m);
            var v1 = new decvec3(4m, -1.5m, 0m);
            var v2 = new decvec3(4m, 7m, -1.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(-2m, 5m, -9m);
            var v1 = new decvec3(-7.5m, -5.5m, -6m);
            var v2 = new decvec3(5.5m, 4.5m, 3.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(9.5m, -7.5m, 3.5m);
            var v1 = new decvec3(3.5m, 2m, 2.5m);
            var v2 = new decvec3(2.5m, 2m, 9m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(-9.5m, -8m, -1m);
            var v1 = new decvec3(2.5m, -2m, 3m);
            var v2 = new decvec3(2.5m, 6.5m, -2m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(0.5m, -6m, 0.5m);
            var v1 = new decvec3(-3.5m, -6m, 8.5m);
            var v2 = new decvec3(-4m, -1m, -7.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new decvec3(4m, 9m, -7.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(-2m, 4.5m, 4m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(-7m, -4.5m, 6.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(-1m, 6m, 9m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(7m, -7m, 2m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(-7.5m, 8.5m, 0m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(8m, 3m, 4m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(-4m, 4.5m, -3.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(-7.5m, -1m, -2m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(4m, 1.5m, -0.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new decvec3(-8.5m, 9m, 3.5m);
            var v1 = new decvec3(-0.5m, -3.5m, -5.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(9m, -2.5m, 7m);
            var v1 = new decvec3(-7.5m, 0m, 6.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(7.5m, 8m, 6m);
            var v1 = new decvec3(-6.5m, -8.5m, 0m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(8m, 6.5m, -8.5m);
            var v1 = new decvec3(4m, -8.5m, 3.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(9.5m, 4.5m, -1.5m);
            var v1 = new decvec3(6.5m, -5m, 8m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(-4.5m, 6m, -3m);
            var v1 = new decvec3(5m, 9.5m, 5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(7m, 0.5m, -2.5m);
            var v1 = new decvec3(6.5m, 8.5m, 6m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(6m, 8m, -4.5m);
            var v1 = new decvec3(4m, 5m, 2.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(-2.5m, -9.5m, 0.5m);
            var v1 = new decvec3(1m, -8.5m, -7.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(0m, -6m, -0.5m);
            var v1 = new decvec3(9.5m, 0.5m, 2.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new decvec3(5.5m, -9.5m, -0.5m);
            var v1 = new decvec3(9m, -2.5m, -7m);
            var v2 = new decvec3(-5.5m, 1.5m, 1m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-9.5m, -3.5m, -9m);
            var v1 = new decvec3(-5.5m, -7m, -9m);
            var v2 = new decvec3(-4.5m, 1.5m, -7m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(1m, 9.5m, 5.5m);
            var v1 = new decvec3(-2m, 2m, 6m);
            var v2 = new decvec3(-3.5m, 5.5m, -3m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-3m, 2m, 0m);
            var v1 = new decvec3(3m, -7.5m, 7m);
            var v2 = new decvec3(-8.5m, -3m, -4.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-2.5m, 3.5m, 7m);
            var v1 = new decvec3(-4m, -6.5m, -5.5m);
            var v2 = new decvec3(-2.5m, 2m, -1.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(1.5m, -5m, 6.5m);
            var v1 = new decvec3(7m, 3.5m, 9.5m);
            var v2 = new decvec3(8.5m, 4m, -5.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-0.5m, -6.5m, -8m);
            var v1 = new decvec3(-6.5m, -5.5m, 1.5m);
            var v2 = new decvec3(4m, -1m, -1.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(0m, -6m, 3m);
            var v1 = new decvec3(-1m, 3m, 4m);
            var v2 = new decvec3(3.5m, 8.5m, 8.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(8m, -2.5m, -6m);
            var v1 = new decvec3(-2m, -4.5m, 0m);
            var v2 = new decvec3(-8m, 4.5m, -8.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-6m, 5m, 9m);
            var v1 = new decvec3(1m, 5m, -8m);
            var v2 = new decvec3(-6.5m, 2.5m, 0.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new decvec3(0m, 2m, -1m);
            var v1 = new decvec3(1m, 4m, 4.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(3.5m, 5m, 6.5m);
            var v1 = new decvec3(-1m, -5m, 7m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(7m, 0.5m, -3.5m);
            var v1 = new decvec3(5.5m, 2.5m, -7m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(4m, 6.5m, -5m);
            var v1 = new decvec3(2m, 6m, -8.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(-2m, 0.5m, 0.5m);
            var v1 = new decvec3(-6.5m, 3m, -1m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(4m, 2.5m, -9.5m);
            var v1 = new decvec3(0.5m, 1m, 4.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(1.5m, -4m, -2m);
            var v1 = new decvec3(-0.5m, -8.5m, 9m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(-8m, -9.5m, 1.5m);
            var v1 = new decvec3(0m, -2m, -2.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(-1m, -9m, -8.5m);
            var v1 = new decvec3(4.5m, -6m, -9m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(4.5m, 8.5m, 5.5m);
            var v1 = new decvec3(0.5m, 0.5m, -4m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new decvec3(-2.5m, 6m, 2m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(9.5m, 1.5m, -5.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-6.5m, 2m, 2m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-3.5m, -4.5m, -2m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(6m, -1.5m, -3m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(2m, 7.5m, -1.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(7m, -9.5m, 8.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-3m, 3.5m, 6m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(3m, -4.5m, 8.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(5m, -1.5m, 3m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void InvariantCrossDot()
    {
        {
            var v0 = new decvec3(6.5m, 7m, 0m);
            var v1 = new decvec3(-6.5m, -6m, -2.5m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(2m, 8.5m, 2m);
            var v1 = new decvec3(-7m, 5m, 5m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(2m, -8.5m, 5m);
            var v1 = new decvec3(1m, -5.5m, -2m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-7.5m, 3.5m, 7.5m);
            var v1 = new decvec3(2.5m, -5m, 6m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-2m, 4.5m, -1m);
            var v1 = new decvec3(9m, 2.5m, 5m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-2.5m, 3m, -8m);
            var v1 = new decvec3(-7m, 8.5m, -8m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-4.5m, 0m, 3.5m);
            var v1 = new decvec3(3m, 1.5m, -0.5m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(5m, 5.5m, -7.5m);
            var v1 = new decvec3(3m, -2.5m, 0.5m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(1.5m, 2.5m, -1m);
            var v1 = new decvec3(-1m, 9m, 7m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(9.5m, 3m, 3.5m);
            var v1 = new decvec3(3.5m, -2m, -8.5m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(1497415605);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.Random(random, (-2), (2));
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
    public void RandomUniform1()
    {
        var random = new Random(1035725645);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomUniform(random, (2), (5));
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
        var random = new Random(1252317983);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.Random(random, (0), (2));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(1572900186);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomUniform(random, (4), (6));
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
    public void RandomUniform4()
    {
        var random = new Random(1584911737);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.Random(random, (3), (4));
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
    public void RandomGaussian0()
    {
        var random = new Random(1976782386);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomNormal(random, 1.797044148574138m, 2.0925125908537363m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.797044148574138).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.797044148574138).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.797044148574138).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.0925125908537363).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.0925125908537363).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.0925125908537363).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(482885058);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomGaussian(random, 0.880062220096617m, 9.111474472615622m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.880062220096617).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.880062220096617).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.880062220096617).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(9.111474472615622).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(9.111474472615622).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(9.111474472615622).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(1346265420);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomNormal(random, 1.001049747225386m, 6.71395771052407m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.001049747225386).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.001049747225386).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.001049747225386).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(6.71395771052407).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(6.71395771052407).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(6.71395771052407).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(1440310052);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomGaussian(random, -1.0471196561339868m, 1.3257744029749996m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.0471196561339868).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.0471196561339868).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-1.0471196561339868).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.3257744029749996).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.3257744029749996).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.3257744029749996).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(1032959407);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomNormal(random, -0.49919058685153295m, 3.389363034343982m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.49919058685153295).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.49919058685153295).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.49919058685153295).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.389363034343982).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.389363034343982).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(3.389363034343982).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(1632202193);
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
        var random = new Random(1197902803);
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
        var random = new Random(1730406170);
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
        var random = new Random(1228404079);
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
        var random = new Random(1625997154);
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
