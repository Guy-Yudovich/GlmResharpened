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
            var v = new decvec3(-9m);
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
            Assert.That(-9m, Is.EqualTo(v.z));
        }
        {
            var v = new decvec3(-9m, -2m, 1.5m);
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
            Assert.That(1.5m, Is.EqualTo(v.z));
        }
        {
            var v = new decvec3(new decvec2(-9.5m, -7m));
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-7m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
        }
        {
            var v = new decvec3(new decvec3(6m, 1.5m, 0m));
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(1.5m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
        }
        {
            var v = new decvec3(new decvec4(6m, -9.5m, -8m, -3.5m));
            Assert.That(6m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
            Assert.That(-8m, Is.EqualTo(v.z));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new decvec3(4m, 7m, 6.5m);
        Assert.That(4m, Is.EqualTo(v[0]));
        Assert.That(7m, Is.EqualTo(v[1]));
        Assert.That(6.5m, Is.EqualTo(v[2]));
        
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
        v[0] = 1m;
        Assert.That(1m, Is.EqualTo(v[0]));
        v[1] = 2m;
        Assert.That(2m, Is.EqualTo(v[1]));
        v[0] = 3m;
        Assert.That(3m, Is.EqualTo(v[0]));
        v[2] = 4m;
        Assert.That(4m, Is.EqualTo(v[2]));
        v[2] = 5m;
        Assert.That(5m, Is.EqualTo(v[2]));
        v[2] = 6m;
        Assert.That(6m, Is.EqualTo(v[2]));
        v[0] = 7m;
        Assert.That(7m, Is.EqualTo(v[0]));
        v[1] = 8m;
        Assert.That(8m, Is.EqualTo(v[1]));
        v[2] = 9m;
        Assert.That(9m, Is.EqualTo(v[2]));
        v[0] = -1m;
        Assert.That(-1m, Is.EqualTo(v[0]));
        v[1] = -2m;
        Assert.That(-2m, Is.EqualTo(v[1]));
        v[1] = -3m;
        Assert.That(-3m, Is.EqualTo(v[1]));
        v[1] = -4m;
        Assert.That(-4m, Is.EqualTo(v[1]));
        v[1] = -5m;
        Assert.That(-5m, Is.EqualTo(v[1]));
        v[2] = -6m;
        Assert.That(-6m, Is.EqualTo(v[2]));
        v[0] = -7m;
        Assert.That(-7m, Is.EqualTo(v[0]));
        v[1] = -8m;
        Assert.That(-8m, Is.EqualTo(v[1]));
        v[2] = -9m;
        Assert.That(-9m, Is.EqualTo(v[2]));
        v[2] = -9.5m;
        Assert.That(-9.5m, Is.EqualTo(v[2]));
        v[1] = -8.5m;
        Assert.That(-8.5m, Is.EqualTo(v[1]));
        v[2] = -7.5m;
        Assert.That(-7.5m, Is.EqualTo(v[2]));
        v[2] = -6.5m;
        Assert.That(-6.5m, Is.EqualTo(v[2]));
        v[1] = -5.5m;
        Assert.That(-5.5m, Is.EqualTo(v[1]));
        v[2] = -4.5m;
        Assert.That(-4.5m, Is.EqualTo(v[2]));
        v[1] = -3.5m;
        Assert.That(-3.5m, Is.EqualTo(v[1]));
        v[1] = -2.5m;
        Assert.That(-2.5m, Is.EqualTo(v[1]));
        v[1] = -1.5m;
        Assert.That(-1.5m, Is.EqualTo(v[1]));
        v[2] = -0.5m;
        Assert.That(-0.5m, Is.EqualTo(v[2]));
        v[1] = 0.5m;
        Assert.That(0.5m, Is.EqualTo(v[1]));
        v[1] = 1.5m;
        Assert.That(1.5m, Is.EqualTo(v[1]));
        v[1] = 2.5m;
        Assert.That(2.5m, Is.EqualTo(v[1]));
        v[1] = 3.5m;
        Assert.That(3.5m, Is.EqualTo(v[1]));
        v[0] = 4.5m;
        Assert.That(4.5m, Is.EqualTo(v[0]));
        v[1] = 5.5m;
        Assert.That(5.5m, Is.EqualTo(v[1]));
        v[0] = 6.5m;
        Assert.That(6.5m, Is.EqualTo(v[0]));
        v[0] = 7.5m;
        Assert.That(7.5m, Is.EqualTo(v[0]));
        v[2] = 8.5m;
        Assert.That(8.5m, Is.EqualTo(v[2]));
        v[1] = 9.5m;
        Assert.That(9.5m, Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new decvec3(3m, -8.5m, 0m);
        var vals = v.Values;
        Assert.That(3m, Is.EqualTo(vals[0]));
        Assert.That(-8.5m, Is.EqualTo(vals[1]));
        Assert.That(0m, Is.EqualTo(vals[2]));
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
        var v1 = new decvec3(-9m, 9.5m, 8.5m);
        var v2 = new decvec3(-9m, 9.5m, 8.5m);
        var v3 = new decvec3(8.5m, 9.5m, -9m);
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
        var v = new decvec3(3.5m, 7.5m, -9m);
        
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
        var v0 = new decvec3(7.5m, -7.5m, 5.5m);
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
            var v0 = new decvec3(3.5m, 2m, -3.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(6.5m, 1.5m, -4.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(3m, -4m, 0.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(7.5m, 2m, -3.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(2.5m, 6.5m, -6m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(0m, 0m, -2.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(-3.5m, 2.5m, 0m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(7m, 0m, -7.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(-7m, 4m, -3.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec3(6.5m, 2.5m, 0.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new decvec3(8m, 7.5m, 6m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(4.5m, 7m, 3m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(1.5m, 8.5m, 3.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(7.5m, 3.5m, 6m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(0.5m, 8.5m, 8.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(-8m, 4.5m, -6.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(-8.5m, 1.5m, 0.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(-8m, 4m, -4.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(-9.5m, -7.5m, -2m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec3(-3.5m, 8m, 5.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new decvec3(-5m, 0.5m, -3m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(-1.5m, -8.5m, -0.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(2m, -8m, 1m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(0.5m, 3.5m, -8m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(-4m, 0m, 0.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(9.5m, 5m, 7.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(7m, -7.5m, -4.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(2m, 4.5m, -8m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(3m, -1.5m, -8.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec3(-6.5m, 0m, -4.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new decvec3(9m, -8m, 9m);
            var v1 = new decvec3(8.5m, 7m, 9m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(8.5m, -2.5m, 5m);
            var v1 = new decvec3(9m, 1.5m, 9m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(5.5m, -0.5m, -9.5m);
            var v1 = new decvec3(-1m, -9m, -9.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(3m, 8m, -8.5m);
            var v1 = new decvec3(4.5m, -2.5m, 5.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-4.5m, 0.5m, -2m);
            var v1 = new decvec3(4m, 0m, 8.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(2.5m, -6.5m, -4.5m);
            var v1 = new decvec3(-8.5m, -9.5m, -6.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(2.5m, -0.5m, 8m);
            var v1 = new decvec3(1m, -1.5m, -8m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-9m, -7.5m, -5m);
            var v1 = new decvec3(6.5m, 3m, -4.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(-2m, -4m, -7.5m);
            var v1 = new decvec3(3m, -2.5m, 2.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec3(1m, -6m, 0.5m);
            var v1 = new decvec3(-4m, -4m, -8m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new decvec3(-7m, -4.5m, -4.5m);
            var v1 = new decvec3(2.5m, 4.5m, -4m);
            var v2 = new decvec3(8.5m, -6m, 3m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(9.5m, 5m, -6m);
            var v1 = new decvec3(-5m, -6m, 3.5m);
            var v2 = new decvec3(9.5m, 6m, 1m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(3m, -3.5m, 2m);
            var v1 = new decvec3(-4m, -4.5m, -8.5m);
            var v2 = new decvec3(-5.5m, -9m, 3m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(8.5m, -1m, 2m);
            var v1 = new decvec3(-7.5m, -7m, 2m);
            var v2 = new decvec3(1m, 4m, 5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(-8m, 2.5m, 8.5m);
            var v1 = new decvec3(-2m, -6.5m, 2m);
            var v2 = new decvec3(4m, -8.5m, 1m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(-0.5m, -6.5m, -4m);
            var v1 = new decvec3(-7m, 1m, 4m);
            var v2 = new decvec3(5.5m, -8.5m, 7.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(-6.5m, 3m, 0m);
            var v1 = new decvec3(4m, 7m, -5m);
            var v2 = new decvec3(9m, 0m, 4m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(1m, -8m, -1.5m);
            var v1 = new decvec3(-3m, -3m, -1m);
            var v2 = new decvec3(-1.5m, -8.5m, -4m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(3m, 2.5m, 2m);
            var v1 = new decvec3(9.5m, 9m, 3m);
            var v2 = new decvec3(-9m, 5.5m, 6.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec3(-0.5m, -7.5m, 8m);
            var v1 = new decvec3(7.5m, -2.5m, 6.5m);
            var v2 = new decvec3(4m, -9m, 1m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new decvec3(-6m, -7m, 0m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(-1.5m, -5.5m, -8m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(-6.5m, -4.5m, -4.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(3m, 2.5m, -6.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(8.5m, -3m, 2m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(3m, 6.5m, -9.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(-4m, -2.5m, -2m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(1.5m, 8m, 5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(2.5m, -1m, 6m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec3(-7.5m, 8m, 0m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new decvec3(-1.5m, 7.5m, -7m);
            var v1 = new decvec3(3m, -7.5m, 2.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(9.5m, 9.5m, -8m);
            var v1 = new decvec3(-7m, -8.5m, 2.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(2.5m, -7.5m, -8m);
            var v1 = new decvec3(-7.5m, 8.5m, 6m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(-4.5m, 2m, 6m);
            var v1 = new decvec3(9.5m, 8.5m, -6.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(-2.5m, 9.5m, 5m);
            var v1 = new decvec3(8m, 8.5m, -7.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(-3m, 8m, -6.5m);
            var v1 = new decvec3(4m, -6m, 0.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(-4.5m, 6m, -4.5m);
            var v1 = new decvec3(9m, -9.5m, 5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(9.5m, 8.5m, 9m);
            var v1 = new decvec3(-3.5m, -7.5m, 3.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(-2m, 7.5m, 4.5m);
            var v1 = new decvec3(-3m, -0.5m, 8m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec3(-3m, -0.5m, 9.5m);
            var v1 = new decvec3(3.5m, -7m, -7.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new decvec3(-6.5m, 6.5m, 8.5m);
            var v1 = new decvec3(-0.5m, 7.5m, -3.5m);
            var v2 = new decvec3(9m, -7m, -5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-3.5m, -8m, -1.5m);
            var v1 = new decvec3(-9m, -5m, -8.5m);
            var v2 = new decvec3(-4.5m, -3.5m, 5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(5m, -1m, -5.5m);
            var v1 = new decvec3(-4m, -5m, -8m);
            var v2 = new decvec3(-5m, 6m, 2m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(6m, -9.5m, -9m);
            var v1 = new decvec3(-3m, -1m, -0.5m);
            var v2 = new decvec3(-6.5m, -2.5m, -1m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-1m, -6m, -1.5m);
            var v1 = new decvec3(-9.5m, 5m, -9m);
            var v2 = new decvec3(-7m, -1m, 9m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-8.5m, -7m, 7m);
            var v1 = new decvec3(7.5m, 2m, 8.5m);
            var v2 = new decvec3(-9.5m, -6m, 4.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-4m, 9m, -8.5m);
            var v1 = new decvec3(-8.5m, -5m, 1.5m);
            var v2 = new decvec3(-6.5m, 3m, 6.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(5.5m, -3m, 6m);
            var v1 = new decvec3(9.5m, 6.5m, -1.5m);
            var v2 = new decvec3(9m, -5m, 9m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(-7m, -3.5m, 4m);
            var v1 = new decvec3(4m, 6.5m, 4m);
            var v2 = new decvec3(8m, 4.5m, -0.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec3(5.5m, 9m, -8m);
            var v1 = new decvec3(-8.5m, 3.5m, 4.5m);
            var v2 = new decvec3(5.5m, 8m, -8m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new decvec3(5m, 8m, 2.5m);
            var v1 = new decvec3(-7m, -4m, 0.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(5m, -1.5m, -7m);
            var v1 = new decvec3(5.5m, 5m, -5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(5.5m, 9m, 3m);
            var v1 = new decvec3(8.5m, -5m, -6.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(2.5m, -2.5m, -7.5m);
            var v1 = new decvec3(-0.5m, 2m, 0.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(9m, -5m, 3m);
            var v1 = new decvec3(-4m, -4m, 8.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(-4.5m, -6.5m, 2m);
            var v1 = new decvec3(-5m, -2.5m, -1m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(8m, -5.5m, -8m);
            var v1 = new decvec3(-7.5m, 8m, 3.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(-3.5m, -9m, 5.5m);
            var v1 = new decvec3(-4.5m, 9.5m, -2m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(5m, 4.5m, 4.5m);
            var v1 = new decvec3(-0.5m, 4m, -7.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec3(6m, -6m, 5m);
            var v1 = new decvec3(2m, 6m, 9.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new decvec3(9m, 1m, 3.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-6.5m, -9m, -6.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-6m, 1.5m, 7m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-8.5m, 5.5m, 6m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-1.5m, 7.5m, 6.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-7.5m, -4m, -8m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-4m, 5m, -9m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-7.5m, 3.5m, 9m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(9.5m, 5m, 1.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec3(-7m, 9m, -4.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void InvariantCrossDot()
    {
        {
            var v0 = new decvec3(-5.5m, -4.5m, 4.5m);
            var v1 = new decvec3(3m, 2.5m, -4.5m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(7.5m, 0m, 3m);
            var v1 = new decvec3(-0.5m, 9.5m, -1m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(7m, 0m, 7m);
            var v1 = new decvec3(-8.5m, -9m, 0.5m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-6m, -4m, 8.5m);
            var v1 = new decvec3(2m, 4m, -6m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-9m, -3m, 2m);
            var v1 = new decvec3(5.5m, -1m, 9m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(0m, -6m, -5m);
            var v1 = new decvec3(-9m, 6m, 2m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-1m, -8m, 7.5m);
            var v1 = new decvec3(9.5m, -1.5m, -3.5m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-2m, 6.5m, 0m);
            var v1 = new decvec3(4m, -0.5m, -1m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(9.5m, 9.5m, -5m);
            var v1 = new decvec3(-1m, 2m, 1.5m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new decvec3(-6.5m, -8.5m, -9.5m);
            var v1 = new decvec3(-9m, -5.5m, -9m);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(420684051);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.Random(random, (0), (1));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(818083140);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomUniform(random, (4), (7));
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
    public void RandomUniform2()
    {
        var random = new Random(1344271252);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.Random(random, (1), (3));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(1119491460);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomUniform(random, (-3), (1));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-1).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(1956700825);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.Random(random, (4), (5));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(4.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomGaussian0()
    {
        var random = new Random(793539179);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomNormal(random, 1.043983505593605m, 8.961710487008892m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.043983505593605).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.043983505593605).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.043983505593605).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(8.961710487008892).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(8.961710487008892).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(8.961710487008892).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(1650120637);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomGaussian(random, -0.8828521496070791m, 2.58029339955202m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.8828521496070791).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.8828521496070791).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.8828521496070791).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.58029339955202).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.58029339955202).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.58029339955202).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(1245119025);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomNormal(random, 1.3731685985686113m, 6.9836033354437m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.3731685985686113).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.3731685985686113).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.3731685985686113).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(6.9836033354437).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(6.9836033354437).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(6.9836033354437).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(944116611);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomGaussian(random, -0.8170059168790496m, 5.724680910690073m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.8170059168790496).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.8170059168790496).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.8170059168790496).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(5.724680910690073).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(5.724680910690073).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(5.724680910690073).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(1547975919);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec3.RandomNormal(random, 0.7564973899892053m, 6.7535795302845445m);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.7564973899892053).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.7564973899892053).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.7564973899892053).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(6.7535795302845445).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(6.7535795302845445).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(6.7535795302845445).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(94068856);
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
        var random = new Random(287239490);
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
        var random = new Random(171514454);
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
        var random = new Random(1502153254);
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
        var random = new Random(17814027);
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
