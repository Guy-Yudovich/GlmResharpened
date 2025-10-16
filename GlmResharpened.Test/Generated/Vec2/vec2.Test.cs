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
public class FloatVec2Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new vec2(-2f);
            Assert.That(-2f, Is.EqualTo(v.x));
            Assert.That(-2f, Is.EqualTo(v.y));
        }
        {
            var v = new vec2(5f, 2.5f);
            Assert.That(5f, Is.EqualTo(v.x));
            Assert.That(2.5f, Is.EqualTo(v.y));
        }
        {
            var v = new vec2(new vec2(0f, 1f));
            Assert.That(0f, Is.EqualTo(v.x));
            Assert.That(1f, Is.EqualTo(v.y));
        }
        {
            var v = new vec2(new vec3(6f, -0.5f, 0f));
            Assert.That(6f, Is.EqualTo(v.x));
            Assert.That(-0.5f, Is.EqualTo(v.y));
        }
        {
            var v = new vec2(new vec4(5f, 7f, 8f, 2.5f));
            Assert.That(5f, Is.EqualTo(v.x));
            Assert.That(7f, Is.EqualTo(v.y));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new vec2(0f, -9f);
        Assert.That(0f, Is.EqualTo(v[0]));
        Assert.That(-9f, Is.EqualTo(v[1]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0f; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0f; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0f; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0f; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0f; } );
        
        v[0] = 0f;
        Assert.That(0f, Is.EqualTo(v[0]));
        v[1] = 1f;
        Assert.That(1f, Is.EqualTo(v[1]));
        v[0] = 2f;
        Assert.That(2f, Is.EqualTo(v[0]));
        v[1] = 3f;
        Assert.That(3f, Is.EqualTo(v[1]));
        v[1] = 4f;
        Assert.That(4f, Is.EqualTo(v[1]));
        v[0] = 5f;
        Assert.That(5f, Is.EqualTo(v[0]));
        v[1] = 6f;
        Assert.That(6f, Is.EqualTo(v[1]));
        v[1] = 7f;
        Assert.That(7f, Is.EqualTo(v[1]));
        v[1] = 8f;
        Assert.That(8f, Is.EqualTo(v[1]));
        v[1] = 9f;
        Assert.That(9f, Is.EqualTo(v[1]));
        v[1] = -1f;
        Assert.That(-1f, Is.EqualTo(v[1]));
        v[0] = -2f;
        Assert.That(-2f, Is.EqualTo(v[0]));
        v[1] = -3f;
        Assert.That(-3f, Is.EqualTo(v[1]));
        v[1] = -4f;
        Assert.That(-4f, Is.EqualTo(v[1]));
        v[0] = -5f;
        Assert.That(-5f, Is.EqualTo(v[0]));
        v[0] = -6f;
        Assert.That(-6f, Is.EqualTo(v[0]));
        v[0] = -7f;
        Assert.That(-7f, Is.EqualTo(v[0]));
        v[0] = -8f;
        Assert.That(-8f, Is.EqualTo(v[0]));
        v[0] = -9f;
        Assert.That(-9f, Is.EqualTo(v[0]));
        v[1] = -9.5f;
        Assert.That(-9.5f, Is.EqualTo(v[1]));
        v[0] = -8.5f;
        Assert.That(-8.5f, Is.EqualTo(v[0]));
        v[0] = -7.5f;
        Assert.That(-7.5f, Is.EqualTo(v[0]));
        v[0] = -6.5f;
        Assert.That(-6.5f, Is.EqualTo(v[0]));
        v[0] = -5.5f;
        Assert.That(-5.5f, Is.EqualTo(v[0]));
        v[1] = -4.5f;
        Assert.That(-4.5f, Is.EqualTo(v[1]));
        v[0] = -3.5f;
        Assert.That(-3.5f, Is.EqualTo(v[0]));
        v[0] = -2.5f;
        Assert.That(-2.5f, Is.EqualTo(v[0]));
        v[0] = -1.5f;
        Assert.That(-1.5f, Is.EqualTo(v[0]));
        v[0] = -0.5f;
        Assert.That(-0.5f, Is.EqualTo(v[0]));
        v[0] = 0.5f;
        Assert.That(0.5f, Is.EqualTo(v[0]));
        v[0] = 1.5f;
        Assert.That(1.5f, Is.EqualTo(v[0]));
        v[0] = 2.5f;
        Assert.That(2.5f, Is.EqualTo(v[0]));
        v[0] = 3.5f;
        Assert.That(3.5f, Is.EqualTo(v[0]));
        v[0] = 4.5f;
        Assert.That(4.5f, Is.EqualTo(v[0]));
        v[1] = 5.5f;
        Assert.That(5.5f, Is.EqualTo(v[1]));
        v[1] = 6.5f;
        Assert.That(6.5f, Is.EqualTo(v[1]));
        v[0] = 7.5f;
        Assert.That(7.5f, Is.EqualTo(v[0]));
        v[1] = 8.5f;
        Assert.That(8.5f, Is.EqualTo(v[1]));
        v[1] = 9.5f;
        Assert.That(9.5f, Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new vec2(0f, 9f);
        var vals = v.Values;
        Assert.That(0f, Is.EqualTo(vals[0]));
        Assert.That(9f, Is.EqualTo(vals[1]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0f, Is.EqualTo(vec2.Zero.x));
        Assert.That(0f, Is.EqualTo(vec2.Zero.y));
        
        Assert.That(1f, Is.EqualTo(vec2.Ones.x));
        Assert.That(1f, Is.EqualTo(vec2.Ones.y));
        
        Assert.That(1f, Is.EqualTo(vec2.UnitX.x));
        Assert.That(0f, Is.EqualTo(vec2.UnitX.y));
        
        Assert.That(0f, Is.EqualTo(vec2.UnitY.x));
        Assert.That(1f, Is.EqualTo(vec2.UnitY.y));
        
        Assert.That(float.MaxValue, Is.EqualTo(vec2.MaxValue.x));
        Assert.That(float.MaxValue, Is.EqualTo(vec2.MaxValue.y));
        
        Assert.That(float.MinValue, Is.EqualTo(vec2.MinValue.x));
        Assert.That(float.MinValue, Is.EqualTo(vec2.MinValue.y));
        
        Assert.That(float.Epsilon, Is.EqualTo(vec2.Epsilon.x));
        Assert.That(float.Epsilon, Is.EqualTo(vec2.Epsilon.y));
        
        Assert.That(float.NaN, Is.EqualTo(vec2.NaN.x));
        Assert.That(float.NaN, Is.EqualTo(vec2.NaN.y));
        
        Assert.That(float.NegativeInfinity, Is.EqualTo(vec2.NegativeInfinity.x));
        Assert.That(float.NegativeInfinity, Is.EqualTo(vec2.NegativeInfinity.y));
        
        Assert.That(float.PositiveInfinity, Is.EqualTo(vec2.PositiveInfinity.x));
        Assert.That(float.PositiveInfinity, Is.EqualTo(vec2.PositiveInfinity.y));
    }

    [Test]
    public void Operators()
    {
        var v1 = new vec2(5.5f, 1.5f);
        var v2 = new vec2(5.5f, 1.5f);
        var v3 = new vec2(1.5f, 5.5f);
        Assert.That((v1 == new vec2(v1)).AllTrue);
        Assert.That((v2 == new vec2(v2)).AllTrue);
        Assert.That((v3 == new vec2(v3)).AllTrue);
        Assert.That((v1 == v2).AllTrue);
        Assert.That((v1 != v3).AllTrue);
        Assert.That((v2 != v3).AllTrue);
    }

    [Test]
    public void StringInterop()
    {
        var v = new vec2(-6f, -2f);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = vec2.Parse(s0);
        var v1 = vec2.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = vec2.TryParse(s0, out v0);
        var b1 = vec2.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = vec2.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = vec2.TryParse("", out v0);
        Assert.That(!b0);
        b0 = vec2.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { vec2.Parse(null); });
        Assert.Throws<FormatException>(() => { vec2.Parse(""); });
        Assert.Throws<FormatException>(() => { vec2.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = vec2.Parse(s3, "; ", NumberStyles.Number);
        var v4 = vec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = vec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new vec2(-3.5f, -2f);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<vec2>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new vec2(8.5f, 1.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(6.5f, -8.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(-4f, 9.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(2.5f, 2.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(5.5f, 1f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(5.5f, -6f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(6f, -0.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(4.5f, 9.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(-9.5f, 5.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(-8.5f, 0f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new vec2(8.5f, 3f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(0f, 5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(-0.5f, -8f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(2f, -1.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(-4f, 6f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(0f, -2.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(-6.5f, -5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(-4f, -4f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(-6.5f, -6f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(0f, -2.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new vec2(3f, -6.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(7f, -2f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(5.5f, 5.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(-2f, 9.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(-3f, -4f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(-9.5f, -8.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(8f, 6.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(-5.5f, 8f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(-8f, -2.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(2.5f, -9f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new vec2(5f, -1.5f);
            var v1 = new vec2(0.5f, -7f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(7f, 9.5f);
            var v1 = new vec2(4f, 8f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(6.5f, 8.5f);
            var v1 = new vec2(-1.5f, 9f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(-4.5f, 8.5f);
            var v1 = new vec2(-4f, 0.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(-4f, -5f);
            var v1 = new vec2(-9f, 1f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(7.5f, 1f);
            var v1 = new vec2(2f, -5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(5.5f, 6f);
            var v1 = new vec2(-6.5f, -5.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(5.5f, -9.5f);
            var v1 = new vec2(2f, 2.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(5.5f, -8.5f);
            var v1 = new vec2(9f, 7.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(-7.5f, 4f);
            var v1 = new vec2(-2.5f, 4f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new vec2(9f, -2f);
            var v1 = new vec2(4f, -0.5f);
            var v2 = new vec2(-4f, 7f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(6f, -6f);
            var v1 = new vec2(8f, 7.5f);
            var v2 = new vec2(-8f, -3f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(-7f, -5.5f);
            var v1 = new vec2(9.5f, -1.5f);
            var v2 = new vec2(0.5f, -2.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(8f, -7.5f);
            var v1 = new vec2(8.5f, 4f);
            var v2 = new vec2(0f, 7.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(1.5f, -3f);
            var v1 = new vec2(1.5f, -6f);
            var v2 = new vec2(-5.5f, 9f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(-2f, -5f);
            var v1 = new vec2(9f, -1f);
            var v2 = new vec2(-2f, -8.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(-6f, 5f);
            var v1 = new vec2(3f, -6f);
            var v2 = new vec2(-9.5f, 1.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(6f, -6f);
            var v1 = new vec2(7f, 3f);
            var v2 = new vec2(-6f, 3.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(-7.5f, -4f);
            var v1 = new vec2(7.5f, 8.5f);
            var v2 = new vec2(-6.5f, -8f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(-9f, 4f);
            var v1 = new vec2(-1f, 6f);
            var v2 = new vec2(7.5f, 1f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new vec2(-7.5f, -6f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(-6f, -6f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(-4f, -2f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(-4f, -4f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(-9.5f, -7f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(-2f, -8f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(0.5f, -9.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(3.5f, 5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(-9.5f, -9.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(-1f, -4.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new vec2(0f, -3.5f);
            var v1 = new vec2(0f, -4f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(-9.5f, 5f);
            var v1 = new vec2(-9f, 9f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(7.5f, 1f);
            var v1 = new vec2(-7f, 7.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(-9f, -0.5f);
            var v1 = new vec2(-0.5f, -6f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(8.5f, 2.5f);
            var v1 = new vec2(1f, -1.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(2.5f, 1.5f);
            var v1 = new vec2(-9.5f, -3f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(9.5f, 7.5f);
            var v1 = new vec2(-8f, 2.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(2f, -4f);
            var v1 = new vec2(5.5f, -9.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(8f, -2.5f);
            var v1 = new vec2(-2.5f, -8f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(9.5f, -4f);
            var v1 = new vec2(-2.5f, -5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new vec2(-9f, 6f);
            var v1 = new vec2(-8.5f, 5.5f);
            var v2 = new vec2(7.5f, 6.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(-6.5f, -5.5f);
            var v1 = new vec2(2f, -2f);
            var v2 = new vec2(9f, 4.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(0f, 6f);
            var v1 = new vec2(7f, 2f);
            var v2 = new vec2(-6f, -4f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(-7f, -6.5f);
            var v1 = new vec2(-6.5f, 7f);
            var v2 = new vec2(-0.5f, 4f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(-9.5f, -5f);
            var v1 = new vec2(-3.5f, -9f);
            var v2 = new vec2(5.5f, 1.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(-4f, 0.5f);
            var v1 = new vec2(-4f, 5.5f);
            var v2 = new vec2(6.5f, -2f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(-2f, 0f);
            var v1 = new vec2(7.5f, -6.5f);
            var v2 = new vec2(4.5f, -2.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(-9f, 4.5f);
            var v1 = new vec2(-2f, -8.5f);
            var v2 = new vec2(-8.5f, 2f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(7.5f, 6f);
            var v1 = new vec2(-3f, -4.5f);
            var v2 = new vec2(-0.5f, 2f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(-7f, -1f);
            var v1 = new vec2(-8f, -6f);
            var v2 = new vec2(-6f, -7.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new vec2(-1f, -3f);
            var v1 = new vec2(-5.5f, -4f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(5f, -2f);
            var v1 = new vec2(2f, 1f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(-2f, -4.5f);
            var v1 = new vec2(-1.5f, -1f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(-6.5f, 2f);
            var v1 = new vec2(4.5f, -8f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(0f, 0f);
            var v1 = new vec2(9f, -9.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(7.5f, 9f);
            var v1 = new vec2(-2.5f, -9f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(-9.5f, -1f);
            var v1 = new vec2(-7f, -4f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(-6f, -1.5f);
            var v1 = new vec2(-8f, -6.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(-5.5f, -8.5f);
            var v1 = new vec2(-1.5f, -5.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(0.5f, 2f);
            var v1 = new vec2(8.5f, -8.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new vec2(0.5f, 6.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(2f, -6.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(6f, -4f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(-3.5f, -5.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(0.5f, 9f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(5f, -6.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(1.5f, -9f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(-7.5f, -7.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(0f, -5.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(-1f, 7.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(2092308421);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.Random(random, (-2), (-1));
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
        var random = new Random(857726312);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomUniform(random, (-5), (-3));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-4).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-4).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(1785599283);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.Random(random, (-2), (2));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(1319136603);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomUniform(random, (-3), (0));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(157318151);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.Random(random, (-3), (1));
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
        var random = new Random(278800952);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomNormal(random, -1.8337614554137742f, 8.50172676541923f);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.8337614554137742).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.8337614554137742).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(8.50172676541923).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(8.50172676541923).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(1622435349);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomGaussian(random, -0.5452807892790441f, 4.338460836717142f);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.5452807892790441).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.5452807892790441).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(4.338460836717142).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(4.338460836717142).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(1270947249);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomNormal(random, -0.2320560152791702f, 3.4773191173920965f);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.2320560152791702).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.2320560152791702).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.4773191173920965).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.4773191173920965).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(531025929);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomGaussian(random, -1.4849093572631986f, 8.20368035147138f);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.4849093572631986).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.4849093572631986).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(8.20368035147138).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(8.20368035147138).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(697860634);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomNormal(random, 0.9392664297201048f, 5.742996314420829f);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.9392664297201048).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.9392664297201048).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(5.742996314420829).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(5.742996314420829).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(819261491);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomNormal(random);
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
        var random = new Random(638682982);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomNormal(random);
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
        var random = new Random(619457265);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomNormal(random);
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
        var random = new Random(157603532);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomNormal(random);
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
        var random = new Random(231256603);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomNormal(random);
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
