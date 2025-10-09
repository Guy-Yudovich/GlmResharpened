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
public class DecimalVec4Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new decvec4(3.5m);
            Assert.That(3.5m, Is.EqualTo(v.x));
            Assert.That(3.5m, Is.EqualTo(v.y));
            Assert.That(3.5m, Is.EqualTo(v.z));
            Assert.That(3.5m, Is.EqualTo(v.w));
        }
        {
            var v = new decvec4(0.5m, 2m, -8.5m, 8m);
            Assert.That(0.5m, Is.EqualTo(v.x));
            Assert.That(2m, Is.EqualTo(v.y));
            Assert.That(-8.5m, Is.EqualTo(v.z));
            Assert.That(8m, Is.EqualTo(v.w));
        }
        {
            var v = new decvec4(new decvec2(-1.5m, 9.5m));
            Assert.That(-1.5m, Is.EqualTo(v.x));
            Assert.That(9.5m, Is.EqualTo(v.y));
            Assert.That(0m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var v = new decvec4(new decvec3(-9.5m, -4m, -2.5m));
            Assert.That(-9.5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-2.5m, Is.EqualTo(v.z));
            Assert.That(0m, Is.EqualTo(v.w));
        }
        {
            var v = new decvec4(new decvec4(-5m, -4m, -5m, -4.5m));
            Assert.That(-5m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
            Assert.That(-5m, Is.EqualTo(v.z));
            Assert.That(-4.5m, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new decvec4(2.5m, -9.5m, -3m, 6m);
        Assert.That(2.5m, Is.EqualTo(v[0]));
        Assert.That(-9.5m, Is.EqualTo(v[1]));
        Assert.That(-3m, Is.EqualTo(v[2]));
        Assert.That(6m, Is.EqualTo(v[3]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0m; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0m; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0m; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0m; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0m; } );
        
        v[2] = 0m;
        Assert.That(0m, Is.EqualTo(v[2]));
        v[2] = 1m;
        Assert.That(1m, Is.EqualTo(v[2]));
        v[3] = 2m;
        Assert.That(2m, Is.EqualTo(v[3]));
        v[2] = 3m;
        Assert.That(3m, Is.EqualTo(v[2]));
        v[0] = 4m;
        Assert.That(4m, Is.EqualTo(v[0]));
        v[0] = 5m;
        Assert.That(5m, Is.EqualTo(v[0]));
        v[0] = 6m;
        Assert.That(6m, Is.EqualTo(v[0]));
        v[0] = 7m;
        Assert.That(7m, Is.EqualTo(v[0]));
        v[0] = 8m;
        Assert.That(8m, Is.EqualTo(v[0]));
        v[2] = 9m;
        Assert.That(9m, Is.EqualTo(v[2]));
        v[1] = -1m;
        Assert.That(-1m, Is.EqualTo(v[1]));
        v[1] = -2m;
        Assert.That(-2m, Is.EqualTo(v[1]));
        v[2] = -3m;
        Assert.That(-3m, Is.EqualTo(v[2]));
        v[0] = -4m;
        Assert.That(-4m, Is.EqualTo(v[0]));
        v[3] = -5m;
        Assert.That(-5m, Is.EqualTo(v[3]));
        v[3] = -6m;
        Assert.That(-6m, Is.EqualTo(v[3]));
        v[1] = -7m;
        Assert.That(-7m, Is.EqualTo(v[1]));
        v[2] = -8m;
        Assert.That(-8m, Is.EqualTo(v[2]));
        v[1] = -9m;
        Assert.That(-9m, Is.EqualTo(v[1]));
        v[2] = -9.5m;
        Assert.That(-9.5m, Is.EqualTo(v[2]));
        v[1] = -8.5m;
        Assert.That(-8.5m, Is.EqualTo(v[1]));
        v[3] = -7.5m;
        Assert.That(-7.5m, Is.EqualTo(v[3]));
        v[2] = -6.5m;
        Assert.That(-6.5m, Is.EqualTo(v[2]));
        v[2] = -5.5m;
        Assert.That(-5.5m, Is.EqualTo(v[2]));
        v[2] = -4.5m;
        Assert.That(-4.5m, Is.EqualTo(v[2]));
        v[0] = -3.5m;
        Assert.That(-3.5m, Is.EqualTo(v[0]));
        v[3] = -2.5m;
        Assert.That(-2.5m, Is.EqualTo(v[3]));
        v[1] = -1.5m;
        Assert.That(-1.5m, Is.EqualTo(v[1]));
        v[1] = -0.5m;
        Assert.That(-0.5m, Is.EqualTo(v[1]));
        v[0] = 0.5m;
        Assert.That(0.5m, Is.EqualTo(v[0]));
        v[1] = 1.5m;
        Assert.That(1.5m, Is.EqualTo(v[1]));
        v[1] = 2.5m;
        Assert.That(2.5m, Is.EqualTo(v[1]));
        v[0] = 3.5m;
        Assert.That(3.5m, Is.EqualTo(v[0]));
        v[2] = 4.5m;
        Assert.That(4.5m, Is.EqualTo(v[2]));
        v[0] = 5.5m;
        Assert.That(5.5m, Is.EqualTo(v[0]));
        v[0] = 6.5m;
        Assert.That(6.5m, Is.EqualTo(v[0]));
        v[0] = 7.5m;
        Assert.That(7.5m, Is.EqualTo(v[0]));
        v[1] = 8.5m;
        Assert.That(8.5m, Is.EqualTo(v[1]));
        v[3] = 9.5m;
        Assert.That(9.5m, Is.EqualTo(v[3]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new decvec4(-8m, -2m, 1m, -6m);
        var vals = v.Values;
        Assert.That(-8m, Is.EqualTo(vals[0]));
        Assert.That(-2m, Is.EqualTo(vals[1]));
        Assert.That(1m, Is.EqualTo(vals[2]));
        Assert.That(-6m, Is.EqualTo(vals[3]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0m, Is.EqualTo(decvec4.Zero.x));
        Assert.That(0m, Is.EqualTo(decvec4.Zero.y));
        Assert.That(0m, Is.EqualTo(decvec4.Zero.z));
        Assert.That(0m, Is.EqualTo(decvec4.Zero.w));
        
        Assert.That(1m, Is.EqualTo(decvec4.Ones.x));
        Assert.That(1m, Is.EqualTo(decvec4.Ones.y));
        Assert.That(1m, Is.EqualTo(decvec4.Ones.z));
        Assert.That(1m, Is.EqualTo(decvec4.Ones.w));
        
        Assert.That(1m, Is.EqualTo(decvec4.UnitX.x));
        Assert.That(0m, Is.EqualTo(decvec4.UnitX.y));
        Assert.That(0m, Is.EqualTo(decvec4.UnitX.z));
        Assert.That(0m, Is.EqualTo(decvec4.UnitX.w));
        
        Assert.That(0m, Is.EqualTo(decvec4.UnitY.x));
        Assert.That(1m, Is.EqualTo(decvec4.UnitY.y));
        Assert.That(0m, Is.EqualTo(decvec4.UnitY.z));
        Assert.That(0m, Is.EqualTo(decvec4.UnitY.w));
        
        Assert.That(0m, Is.EqualTo(decvec4.UnitZ.x));
        Assert.That(0m, Is.EqualTo(decvec4.UnitZ.y));
        Assert.That(1m, Is.EqualTo(decvec4.UnitZ.z));
        Assert.That(0m, Is.EqualTo(decvec4.UnitZ.w));
        
        Assert.That(0m, Is.EqualTo(decvec4.UnitW.x));
        Assert.That(0m, Is.EqualTo(decvec4.UnitW.y));
        Assert.That(0m, Is.EqualTo(decvec4.UnitW.z));
        Assert.That(1m, Is.EqualTo(decvec4.UnitW.w));
        
        Assert.That(decimal.MaxValue, Is.EqualTo(decvec4.MaxValue.x));
        Assert.That(decimal.MaxValue, Is.EqualTo(decvec4.MaxValue.y));
        Assert.That(decimal.MaxValue, Is.EqualTo(decvec4.MaxValue.z));
        Assert.That(decimal.MaxValue, Is.EqualTo(decvec4.MaxValue.w));
        
        Assert.That(decimal.MinValue, Is.EqualTo(decvec4.MinValue.x));
        Assert.That(decimal.MinValue, Is.EqualTo(decvec4.MinValue.y));
        Assert.That(decimal.MinValue, Is.EqualTo(decvec4.MinValue.z));
        Assert.That(decimal.MinValue, Is.EqualTo(decvec4.MinValue.w));
        
        Assert.That(decimal.MinusOne, Is.EqualTo(decvec4.MinusOne.x));
        Assert.That(decimal.MinusOne, Is.EqualTo(decvec4.MinusOne.y));
        Assert.That(decimal.MinusOne, Is.EqualTo(decvec4.MinusOne.z));
        Assert.That(decimal.MinusOne, Is.EqualTo(decvec4.MinusOne.w));
    }

    [Test]
    public void Operators()
    {
        var v1 = new decvec4(-1.5m, -5.5m, -1m, -4.5m);
        var v2 = new decvec4(-1.5m, -5.5m, -1m, -4.5m);
        var v3 = new decvec4(-4.5m, -1m, -5.5m, -1.5m);
        Assert.That(v1 == new decvec4(v1));
        Assert.That(v2 == new decvec4(v2));
        Assert.That(v3 == new decvec4(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new decvec4(-1.5m, 4.5m, 3.5m, -1m);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = decvec4.Parse(s0);
        var v1 = decvec4.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = decvec4.TryParse(s0, out v0);
        var b1 = decvec4.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = decvec4.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = decvec4.TryParse("", out v0);
        Assert.That(!b0);
        b0 = decvec4.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { decvec4.Parse(null); });
        Assert.Throws<FormatException>(() => { decvec4.Parse(""); });
        Assert.Throws<FormatException>(() => { decvec4.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = decvec4.Parse(s3, "; ", NumberStyles.Number);
        var v4 = decvec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = decvec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new decvec4(6.5m, -5.5m, 3.5m, 4.5m);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<decvec4>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new decvec4(5.5m, 2m, -7.5m, 1.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec4(3.5m, 5.5m, -5m, -8.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec4(-1.5m, 4.5m, -3.5m, -9m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec4(6m, -3.5m, 2m, 2.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec4(-9m, 8.5m, -5m, 2m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec4(-6m, -5.5m, -1.5m, -9m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec4(-0.5m, 4.5m, 6m, -4m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec4(0.5m, 0.5m, 4m, -4.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec4(-6.5m, -1.5m, -8.5m, -0.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec4(-7.5m, -6.5m, -8.5m, -7m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new decvec4(-3m, 5.5m, 3.5m, -9.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec4(1.5m, -2m, 0.5m, 4m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec4(-5.5m, -6m, 4.5m, 6.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec4(-9m, -2m, -0.5m, 9m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec4(7.5m, 5m, 2m, -2.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec4(8m, -9.5m, -8.5m, -6.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec4(5m, -7m, 9.5m, 5.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec4(6.5m, 0m, -6.5m, -2m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec4(-3.5m, 5.5m, -0.5m, -4.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec4(-7.5m, -4m, -0.5m, -7m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new decvec4(-1m, 3.5m, 0.5m, -1m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec4(-7.5m, 6.5m, 5m, -9m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec4(-5.5m, 3m, -7.5m, 7m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec4(2.5m, -2.5m, -7m, -4m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec4(-2m, -8.5m, 5.5m, 6m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec4(-6.5m, -7m, -5m, -7.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec4(-4.5m, -6m, 2.5m, 0.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec4(1m, -8.5m, -3.5m, 8.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec4(3m, -7.5m, -4m, -5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec4(4.5m, 3m, 1m, -4m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new decvec4(-4.5m, 6.5m, 8.5m, -3m);
            var v1 = new decvec4(9.5m, -9m, 6.5m, 8m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec4(-1.5m, 9m, 7.5m, 3m);
            var v1 = new decvec4(-6m, -1.5m, -4.5m, 9.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec4(1.5m, -5.5m, -8.5m, 8.5m);
            var v1 = new decvec4(-3m, 9.5m, -7m, -6m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec4(-2.5m, 0m, 0m, -6.5m);
            var v1 = new decvec4(0.5m, -1.5m, -7.5m, -2m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec4(-7m, -1.5m, 9m, 0m);
            var v1 = new decvec4(3m, 1m, 3.5m, -5.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec4(8.5m, 5m, 1m, -6.5m);
            var v1 = new decvec4(6m, 6m, 5m, -4m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec4(2m, 9.5m, -6.5m, -8.5m);
            var v1 = new decvec4(-6m, -8.5m, 6.5m, -3.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec4(-9m, -6.5m, -4.5m, 8.5m);
            var v1 = new decvec4(-8m, -4m, -8m, 0m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec4(-1.5m, -3.5m, -3.5m, -1.5m);
            var v1 = new decvec4(-9m, -5.5m, 5.5m, 0.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec4(0.5m, 6.5m, 9.5m, 7m);
            var v1 = new decvec4(8.5m, 3.5m, 8m, -9.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new decvec4(-5.5m, -2.5m, -0.5m, -3m);
            var v1 = new decvec4(-2m, 6m, -5m, -8.5m);
            var v2 = new decvec4(-0.5m, 5m, -3.5m, 3.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec4(-3.5m, 2m, -6m, 7.5m);
            var v1 = new decvec4(-4m, 8m, 1m, 1.5m);
            var v2 = new decvec4(-0.5m, 9m, 0.5m, -7.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec4(6.5m, 6m, -3m, 9m);
            var v1 = new decvec4(1.5m, -1m, -8.5m, 1.5m);
            var v2 = new decvec4(5.5m, 8.5m, -2.5m, 0.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec4(3m, -7m, -1m, 6m);
            var v1 = new decvec4(-0.5m, 0m, -1.5m, -8m);
            var v2 = new decvec4(9m, -2m, -7.5m, -0.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec4(0.5m, 7.5m, -8m, 5.5m);
            var v1 = new decvec4(3.5m, -6.5m, -4m, -5m);
            var v2 = new decvec4(7.5m, 7m, -7m, 5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec4(3.5m, 4m, -0.5m, -9m);
            var v1 = new decvec4(-5.5m, 4.5m, 8.5m, -1.5m);
            var v2 = new decvec4(-5m, -3.5m, 4.5m, 7.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec4(8.5m, 4.5m, 1m, -0.5m);
            var v1 = new decvec4(-7.5m, -2m, -2m, -5.5m);
            var v2 = new decvec4(-5.5m, -5.5m, -9.5m, 4.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec4(2.5m, -4.5m, 8.5m, -2m);
            var v1 = new decvec4(-4.5m, -3m, 3.5m, 5.5m);
            var v2 = new decvec4(9.5m, 4m, -4m, -5.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec4(-1m, 8m, 4.5m, -5m);
            var v1 = new decvec4(-3m, 4.5m, -5m, 4m);
            var v2 = new decvec4(2m, -9.5m, 7.5m, 8.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec4(-8.5m, -4.5m, 2.5m, -4.5m);
            var v1 = new decvec4(5.5m, 2.5m, -8.5m, 9m);
            var v2 = new decvec4(-4.5m, 5.5m, -3.5m, 9.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new decvec4(-5.5m, -2m, -3.5m, 3.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec4(-4.5m, -8.5m, -5m, -4m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec4(3.5m, -5m, 2.5m, -7m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec4(-6m, 7.5m, 2m, -2.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec4(2m, 6.5m, 9m, -1m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec4(9m, 3.5m, -7.5m, -3.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec4(8.5m, -7m, -7.5m, 4m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec4(-0.5m, -1m, 9.5m, 5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec4(-5.5m, 2.5m, 5m, -1m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec4(1m, 4.5m, -8m, 4m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new decvec4(9m, -4m, 6m, -1.5m);
            var v1 = new decvec4(-6.5m, 2m, -1m, -5.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec4(-6m, -8m, -5.5m, 6m);
            var v1 = new decvec4(-5.5m, 1.5m, 0m, -6m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec4(8m, 2m, 4m, 7m);
            var v1 = new decvec4(2.5m, -3.5m, 4m, -6.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec4(5.5m, 8m, -0.5m, 1m);
            var v1 = new decvec4(8.5m, -5m, -8.5m, -2.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec4(4.5m, -2.5m, -5m, -1m);
            var v1 = new decvec4(-3.5m, -0.5m, -9m, 4.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec4(0.5m, 3.5m, -3.5m, 8.5m);
            var v1 = new decvec4(6m, -0.5m, -4.5m, 4m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec4(2m, -7m, 5m, -1.5m);
            var v1 = new decvec4(5.5m, -8m, 4.5m, -5.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec4(8m, -6.5m, 3.5m, -4m);
            var v1 = new decvec4(-4m, 8m, -4.5m, 0m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec4(6.5m, 7.5m, -3m, 7.5m);
            var v1 = new decvec4(-6m, -0.5m, -0.5m, -9.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec4(-6.5m, 9m, -8m, 8.5m);
            var v1 = new decvec4(9.5m, 5m, -7m, 5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new decvec4(-3m, 2.5m, -8.5m, -1m);
            var v1 = new decvec4(-7.5m, 6.5m, 5m, 0m);
            var v2 = new decvec4(-5m, -2.5m, 0m, -1m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec4(-1.5m, 4m, 0.5m, -9.5m);
            var v1 = new decvec4(-9m, 4.5m, -1m, -1.5m);
            var v2 = new decvec4(-1m, -6m, 4.5m, -4m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec4(3.5m, 2.5m, -2m, -8m);
            var v1 = new decvec4(6m, 6.5m, 7.5m, -6m);
            var v2 = new decvec4(-0.5m, 1m, 2m, 4m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec4(-8.5m, -1m, -4.5m, -4.5m);
            var v1 = new decvec4(0.5m, 1m, 7m, -9m);
            var v2 = new decvec4(-2.5m, 6m, -8m, -4m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec4(-2.5m, 1.5m, -9m, 2m);
            var v1 = new decvec4(7.5m, -2.5m, 7.5m, 7.5m);
            var v2 = new decvec4(7.5m, 6m, -7m, 0.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec4(-5.5m, -1.5m, 4.5m, -8m);
            var v1 = new decvec4(0.5m, -4.5m, -7.5m, -2.5m);
            var v2 = new decvec4(2m, -4.5m, 8.5m, 8m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec4(8m, -4.5m, 7.5m, 8m);
            var v1 = new decvec4(8m, -6m, -3.5m, -2.5m);
            var v2 = new decvec4(-5m, 8.5m, 0.5m, -5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec4(-7m, 5.5m, -9m, 2m);
            var v1 = new decvec4(3m, 5m, 6m, -5m);
            var v2 = new decvec4(4.5m, 5.5m, 1m, 2m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec4(7m, -0.5m, -1.5m, 2m);
            var v1 = new decvec4(-4.5m, 1.5m, -1m, 2m);
            var v2 = new decvec4(2.5m, -1m, 3.5m, -2m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec4(0.5m, -1.5m, -1.5m, -7.5m);
            var v1 = new decvec4(-9.5m, 0.5m, -5m, -4.5m);
            var v2 = new decvec4(8.5m, -9m, 0m, 5.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new decvec4(0.5m, 7m, 5m, 3.5m);
            var v1 = new decvec4(8.5m, -6.5m, 0.5m, 4.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec4(9m, 0m, -6.5m, 1.5m);
            var v1 = new decvec4(3m, -3m, 0.5m, 1m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec4(7.5m, 9m, 8m, -9.5m);
            var v1 = new decvec4(-8.5m, -7m, -4.5m, 2m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec4(8.5m, -1.5m, -6.5m, -7.5m);
            var v1 = new decvec4(4m, 7m, 7m, 4m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec4(2m, -4.5m, 7m, -2.5m);
            var v1 = new decvec4(3m, -2.5m, 6.5m, 1m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec4(-1m, -4.5m, 4.5m, -9.5m);
            var v1 = new decvec4(-7m, -6m, 4.5m, 4m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec4(-5.5m, 0m, 2.5m, 8m);
            var v1 = new decvec4(-1m, 7m, 6m, -3m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec4(-6.5m, 3m, 4.5m, -1m);
            var v1 = new decvec4(9.5m, 7m, -0.5m, 2m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec4(2.5m, -9m, -0.5m, -8m);
            var v1 = new decvec4(5m, 3m, 7.5m, 9m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec4(-3m, 7m, 8m, 5.5m);
            var v1 = new decvec4(-6.5m, 4m, -4.5m, -7.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new decvec4(2m, -5m, 5m, 5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec4(-1.5m, 1m, 7m, 5.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec4(-1.5m, 9.5m, -5m, -5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec4(-7m, -2.5m, 2.5m, 7m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec4(3m, 8m, -1m, 3.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec4(-6m, 4.5m, -7.5m, 5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec4(-7m, 2m, 5.5m, 3m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec4(2.5m, 6.5m, 0.5m, 8m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec4(1.5m, -2m, 2m, 6m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec4(-7m, -3m, -7m, 8m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(1128311792);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.Random(random, (-3), (-1));
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
    public void RandomUniform1()
    {
        var random = new Random(1625505331);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.RandomUniform(random, (0), (3));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(309169148);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.Random(random, (-1), (0));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-0.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(15196225);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.RandomUniform(random, (0), (4));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(2).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(27207776);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.Random(random, (2), (6));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(4).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomGaussian0()
    {
        var random = new Random(1732188392);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.RandomNormal(random, 1.4474978015979274m, 8.842563717087062m);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.4474978015979274).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.4474978015979274).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.4474978015979274).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.4474978015979274).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(8.842563717087062).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(8.842563717087062).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(8.842563717087062).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(8.842563717087062).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(1078602073);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.RandomGaussian(random, 1.3089943096549224m, 2.9990304135712935m);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.3089943096549224).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.3089943096549224).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.3089943096549224).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.3089943096549224).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.9990304135712935).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.9990304135712935).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.9990304135712935).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(2.9990304135712935).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(756485734);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.RandomNormal(random, 1.1880067825261533m, 5.396547203602524m);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.1880067825261533).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.1880067825261533).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.1880067825261533).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.1880067825261533).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(5.396547203602524).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(5.396547203602524).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(5.396547203602524).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(5.396547203602524).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(850530366);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.RandomGaussian(random, -0.6975733091577763m, 4.575723304681351m);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.6975733091577763).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.6975733091577763).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.6975733091577763).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-0.6975733091577763).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(4.575723304681351).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(4.575723304681351).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(4.575723304681351).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(4.575723304681351).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(443179721);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.RandomNormal(random, -0.14964423987532238m, 6.63931196399001m);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.14964423987532238).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.14964423987532238).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.14964423987532238).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-0.14964423987532238).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(6.63931196399001).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(6.63931196399001).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(6.63931196399001).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(6.63931196399001).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(1042422507);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.RandomNormal(random);
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
        var random = new Random(363584328);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.RandomNormal(random);
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
        var random = new Random(172702209);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.RandomNormal(random);
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
        var random = new Random(638624393);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.RandomNormal(random);
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
        var random = new Random(1036217468);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec4.RandomNormal(random);
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
