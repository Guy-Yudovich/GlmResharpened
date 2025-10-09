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
public class DecimalVec2Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new decvec2(-4m);
            Assert.That(-4m, Is.EqualTo(v.x));
            Assert.That(-4m, Is.EqualTo(v.y));
        }
        {
            var v = new decvec2(-3m, -9m);
            Assert.That(-3m, Is.EqualTo(v.x));
            Assert.That(-9m, Is.EqualTo(v.y));
        }
        {
            var v = new decvec2(new decvec2(-9m, -9.5m));
            Assert.That(-9m, Is.EqualTo(v.x));
            Assert.That(-9.5m, Is.EqualTo(v.y));
        }
        {
            var v = new decvec2(new decvec3(-5.5m, -2m, -5.5m));
            Assert.That(-5.5m, Is.EqualTo(v.x));
            Assert.That(-2m, Is.EqualTo(v.y));
        }
        {
            var v = new decvec2(new decvec4(-4.5m, -3.5m, 9m, 1m));
            Assert.That(-4.5m, Is.EqualTo(v.x));
            Assert.That(-3.5m, Is.EqualTo(v.y));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new decvec2(-2.5m, -8.5m);
        Assert.That(-2.5m, Is.EqualTo(v[0]));
        Assert.That(-8.5m, Is.EqualTo(v[1]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0m; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0m; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0m; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0m; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0m; } );
        
        v[1] = 0m;
        Assert.That(0m, Is.EqualTo(v[1]));
        v[0] = 1m;
        Assert.That(1m, Is.EqualTo(v[0]));
        v[0] = 2m;
        Assert.That(2m, Is.EqualTo(v[0]));
        v[0] = 3m;
        Assert.That(3m, Is.EqualTo(v[0]));
        v[0] = 4m;
        Assert.That(4m, Is.EqualTo(v[0]));
        v[1] = 5m;
        Assert.That(5m, Is.EqualTo(v[1]));
        v[0] = 6m;
        Assert.That(6m, Is.EqualTo(v[0]));
        v[1] = 7m;
        Assert.That(7m, Is.EqualTo(v[1]));
        v[0] = 8m;
        Assert.That(8m, Is.EqualTo(v[0]));
        v[0] = 9m;
        Assert.That(9m, Is.EqualTo(v[0]));
        v[1] = -1m;
        Assert.That(-1m, Is.EqualTo(v[1]));
        v[1] = -2m;
        Assert.That(-2m, Is.EqualTo(v[1]));
        v[1] = -3m;
        Assert.That(-3m, Is.EqualTo(v[1]));
        v[1] = -4m;
        Assert.That(-4m, Is.EqualTo(v[1]));
        v[0] = -5m;
        Assert.That(-5m, Is.EqualTo(v[0]));
        v[1] = -6m;
        Assert.That(-6m, Is.EqualTo(v[1]));
        v[1] = -7m;
        Assert.That(-7m, Is.EqualTo(v[1]));
        v[0] = -8m;
        Assert.That(-8m, Is.EqualTo(v[0]));
        v[0] = -9m;
        Assert.That(-9m, Is.EqualTo(v[0]));
        v[0] = -9.5m;
        Assert.That(-9.5m, Is.EqualTo(v[0]));
        v[0] = -8.5m;
        Assert.That(-8.5m, Is.EqualTo(v[0]));
        v[0] = -7.5m;
        Assert.That(-7.5m, Is.EqualTo(v[0]));
        v[0] = -6.5m;
        Assert.That(-6.5m, Is.EqualTo(v[0]));
        v[1] = -5.5m;
        Assert.That(-5.5m, Is.EqualTo(v[1]));
        v[1] = -4.5m;
        Assert.That(-4.5m, Is.EqualTo(v[1]));
        v[0] = -3.5m;
        Assert.That(-3.5m, Is.EqualTo(v[0]));
        v[0] = -2.5m;
        Assert.That(-2.5m, Is.EqualTo(v[0]));
        v[1] = -1.5m;
        Assert.That(-1.5m, Is.EqualTo(v[1]));
        v[0] = -0.5m;
        Assert.That(-0.5m, Is.EqualTo(v[0]));
        v[1] = 0.5m;
        Assert.That(0.5m, Is.EqualTo(v[1]));
        v[1] = 1.5m;
        Assert.That(1.5m, Is.EqualTo(v[1]));
        v[0] = 2.5m;
        Assert.That(2.5m, Is.EqualTo(v[0]));
        v[0] = 3.5m;
        Assert.That(3.5m, Is.EqualTo(v[0]));
        v[0] = 4.5m;
        Assert.That(4.5m, Is.EqualTo(v[0]));
        v[0] = 5.5m;
        Assert.That(5.5m, Is.EqualTo(v[0]));
        v[0] = 6.5m;
        Assert.That(6.5m, Is.EqualTo(v[0]));
        v[0] = 7.5m;
        Assert.That(7.5m, Is.EqualTo(v[0]));
        v[1] = 8.5m;
        Assert.That(8.5m, Is.EqualTo(v[1]));
        v[0] = 9.5m;
        Assert.That(9.5m, Is.EqualTo(v[0]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new decvec2(3.5m, -5m);
        var vals = v.Values;
        Assert.That(3.5m, Is.EqualTo(vals[0]));
        Assert.That(-5m, Is.EqualTo(vals[1]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0m, Is.EqualTo(decvec2.Zero.x));
        Assert.That(0m, Is.EqualTo(decvec2.Zero.y));
        
        Assert.That(1m, Is.EqualTo(decvec2.Ones.x));
        Assert.That(1m, Is.EqualTo(decvec2.Ones.y));
        
        Assert.That(1m, Is.EqualTo(decvec2.UnitX.x));
        Assert.That(0m, Is.EqualTo(decvec2.UnitX.y));
        
        Assert.That(0m, Is.EqualTo(decvec2.UnitY.x));
        Assert.That(1m, Is.EqualTo(decvec2.UnitY.y));
        
        Assert.That(decimal.MaxValue, Is.EqualTo(decvec2.MaxValue.x));
        Assert.That(decimal.MaxValue, Is.EqualTo(decvec2.MaxValue.y));
        
        Assert.That(decimal.MinValue, Is.EqualTo(decvec2.MinValue.x));
        Assert.That(decimal.MinValue, Is.EqualTo(decvec2.MinValue.y));
        
        Assert.That(decimal.MinusOne, Is.EqualTo(decvec2.MinusOne.x));
        Assert.That(decimal.MinusOne, Is.EqualTo(decvec2.MinusOne.y));
    }

    [Test]
    public void Operators()
    {
        var v1 = new decvec2(2.5m, 4m);
        var v2 = new decvec2(2.5m, 4m);
        var v3 = new decvec2(4m, 2.5m);
        Assert.That(v1 == new decvec2(v1));
        Assert.That(v2 == new decvec2(v2));
        Assert.That(v3 == new decvec2(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new decvec2(1.5m, 5.5m);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = decvec2.Parse(s0);
        var v1 = decvec2.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = decvec2.TryParse(s0, out v0);
        var b1 = decvec2.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = decvec2.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = decvec2.TryParse("", out v0);
        Assert.That(!b0);
        b0 = decvec2.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { decvec2.Parse(null); });
        Assert.Throws<FormatException>(() => { decvec2.Parse(""); });
        Assert.Throws<FormatException>(() => { decvec2.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = decvec2.Parse(s3, "; ", NumberStyles.Number);
        var v4 = decvec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = decvec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new decvec2(-4.5m, 0.5m);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<decvec2>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new decvec2(5m, 1.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec2(-8.5m, -6.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec2(3.5m, 0.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec2(-4.5m, -8m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec2(1m, 9m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec2(-5.5m, -1.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec2(6m, 0.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec2(-4m, -2.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec2(-1m, 3.5m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new decvec2(2.5m, -7m);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new decvec2(0.5m, -5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec2(-3m, -8m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec2(-2.5m, -1.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec2(-1m, 9m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec2(-6.5m, -5.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec2(-2m, 8.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec2(4m, 6m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec2(-6.5m, 3.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec2(4.5m, 9.5m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new decvec2(3.5m, -8m);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new decvec2(-0.5m, 1.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec2(-2.5m, 4m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec2(5m, -1m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec2(-5.5m, 6.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec2(4.5m, 4.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec2(9m, 2.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec2(0.5m, 7.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec2(7.5m, 7m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec2(-0.5m, -4.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new decvec2(1.5m, -7.5m);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new decvec2(1m, 7m);
            var v1 = new decvec2(-2m, 4.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec2(-0.5m, -0.5m);
            var v1 = new decvec2(1m, -6m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec2(5m, -5m);
            var v1 = new decvec2(-9m, 6.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec2(3.5m, 1m);
            var v1 = new decvec2(5m, -3m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec2(-8m, -6.5m);
            var v1 = new decvec2(0m, -6.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec2(-1.5m, -7m);
            var v1 = new decvec2(-6.5m, -2.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec2(-9m, -1.5m);
            var v1 = new decvec2(0m, 3m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec2(5m, 7m);
            var v1 = new decvec2(8.5m, 4.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec2(0m, 9m);
            var v1 = new decvec2(9m, -4.5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new decvec2(-9m, -9m);
            var v1 = new decvec2(-4.5m, 5m);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new decvec2(-3.5m, 1m);
            var v1 = new decvec2(5.5m, 7.5m);
            var v2 = new decvec2(-6.5m, 8m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec2(-4.5m, 1.5m);
            var v1 = new decvec2(-1m, 3m);
            var v2 = new decvec2(0.5m, 5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec2(-8m, 8.5m);
            var v1 = new decvec2(-8m, 3m);
            var v2 = new decvec2(8m, -7m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec2(3.5m, -5.5m);
            var v1 = new decvec2(7.5m, -6.5m);
            var v2 = new decvec2(-4.5m, 5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec2(-2m, 6.5m);
            var v1 = new decvec2(-6.5m, 5m);
            var v2 = new decvec2(8.5m, 8m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec2(2.5m, -1m);
            var v1 = new decvec2(0.5m, -5.5m);
            var v2 = new decvec2(-3m, -2m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec2(8m, 9.5m);
            var v1 = new decvec2(-0.5m, 6.5m);
            var v2 = new decvec2(-2.5m, -5.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec2(4m, 3m);
            var v1 = new decvec2(5.5m, 1m);
            var v2 = new decvec2(-2m, 6.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec2(-3m, -3m);
            var v1 = new decvec2(-1.5m, 2m);
            var v2 = new decvec2(6m, -8m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new decvec2(-7.5m, 3m);
            var v1 = new decvec2(-7m, -0.5m);
            var v2 = new decvec2(-4.5m, -2.5m);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new decvec2(7m, -7m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec2(3.5m, 0m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec2(4.5m, 9.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec2(-9.5m, 3m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec2(0m, 9.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec2(-4m, 5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec2(2.5m, 8m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec2(-7m, 1.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec2(-5.5m, -3.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new decvec2(-9m, -1.5m);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new decvec2(-4.5m, 9m);
            var v1 = new decvec2(-9.5m, 6m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec2(6m, -5.5m);
            var v1 = new decvec2(5.5m, 9m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec2(7m, 6.5m);
            var v1 = new decvec2(8m, 2m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec2(1m, 5.5m);
            var v1 = new decvec2(1m, 7m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec2(4m, -2.5m);
            var v1 = new decvec2(-3.5m, 1m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec2(-7m, 4m);
            var v1 = new decvec2(9.5m, 2.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec2(-8m, -6m);
            var v1 = new decvec2(9.5m, -6.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec2(-1m, 2.5m);
            var v1 = new decvec2(-6.5m, 7m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec2(-4.5m, -5m);
            var v1 = new decvec2(0.5m, 0m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new decvec2(-6.5m, -3.5m);
            var v1 = new decvec2(-9m, 3.5m);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new decvec2(-6m, 0m);
            var v1 = new decvec2(-5.5m, -3m);
            var v2 = new decvec2(7m, -8.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec2(2.5m, -1m);
            var v1 = new decvec2(-9m, 6.5m);
            var v2 = new decvec2(-1.5m, -5.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec2(-1m, -9m);
            var v1 = new decvec2(5.5m, -5m);
            var v2 = new decvec2(-2m, -0.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec2(7m, 6m);
            var v1 = new decvec2(9m, 7m);
            var v2 = new decvec2(5.5m, -3m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec2(-5.5m, -5.5m);
            var v1 = new decvec2(-0.5m, 9.5m);
            var v2 = new decvec2(7.5m, -6m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec2(3.5m, 0.5m);
            var v1 = new decvec2(6.5m, -7m);
            var v2 = new decvec2(-6.5m, 8m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec2(-5.5m, 8.5m);
            var v1 = new decvec2(-5.5m, 4.5m);
            var v2 = new decvec2(1m, -4.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec2(8m, 3.5m);
            var v1 = new decvec2(-8m, 4.5m);
            var v2 = new decvec2(-8.5m, -4m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec2(7.5m, -5.5m);
            var v1 = new decvec2(4.5m, -3.5m);
            var v2 = new decvec2(-5m, -9.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new decvec2(-2.5m, 8m);
            var v1 = new decvec2(5m, -2m);
            var v2 = new decvec2(-1.5m, -5.5m);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new decvec2(7m, -5.5m);
            var v1 = new decvec2(-8.5m, 6.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec2(3m, -8m);
            var v1 = new decvec2(6.5m, 4.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec2(5.5m, 2m);
            var v1 = new decvec2(-3m, -3m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec2(-7m, -2m);
            var v1 = new decvec2(6m, -5.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec2(-5m, -3.5m);
            var v1 = new decvec2(-9.5m, -5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec2(-7.5m, -9m);
            var v1 = new decvec2(1m, 1m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec2(9m, 6m);
            var v1 = new decvec2(-2.5m, -1m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec2(-7.5m, 6m);
            var v1 = new decvec2(-1.5m, -0.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec2(0.5m, 1m);
            var v1 = new decvec2(-3.5m, 0.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new decvec2(4m, -6.5m);
            var v1 = new decvec2(-4m, -3.5m);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new decvec2(-2m, -9m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec2(0m, -2.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec2(6m, 4m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec2(0m, -7m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec2(-9m, -7m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec2(-8m, 0.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec2(-7m, 6m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec2(3.5m, 5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec2(-2.5m, 8.5m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new decvec2(-3m, 1m);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(2040617690);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.Random(random, (-2), (-1));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(104571882);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.RandomUniform(random, (-4), (0));
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
    public void RandomUniform2()
    {
        var random = new Random(1988711427);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.Random(random, (-3), (-2));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-2.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-2.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(437688466);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.RandomUniform(random, (-5), (-2));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-3.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-3.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(548516109);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.Random(random, (-3), (1));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomGaussian0()
    {
        var random = new Random(660334594);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.RandomNormal(random, -0.443133513649522m, 6.758898392673069m);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.443133513649522).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.443133513649522).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(6.758898392673069).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(6.758898392673069).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(193534209);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.RandomGaussian(random, 0.17306670088929454m, 8.706135744557779m);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.17306670088929454).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.17306670088929454).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(8.706135744557779).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(8.706135744557779).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(433119896);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.RandomNormal(random, -1.6331773864259838m, 5.837372716440528m);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.6331773864259838).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.6331773864259838).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(5.837372716440528).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(5.837372716440528).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(1426852292);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.RandomGaussian(random, -0.9126386693271988m, 1.4308484743492902m);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.9126386693271988).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.9126386693271988).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.4308484743492902).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.4308484743492902).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(1690158706);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.RandomNormal(random, -0.07082183010448784m, 1.1214866401262054m);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.07082183010448784).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.07082183010448784).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.1214866401262054).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.1214866401262054).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(1954486784);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.RandomNormal(random);
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
        var random = new Random(599517740);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.RandomNormal(random);
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
        var random = new Random(321962390);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.RandomNormal(random);
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
        var random = new Random(1421424309);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.RandomNormal(random);
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
        var random = new Random(462768726);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = decvec2.RandomNormal(random);
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
