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
            var v = new vec2(6f);
            Assert.That(6f, Is.EqualTo(v.x));
            Assert.That(6f, Is.EqualTo(v.y));
        }
        {
            var v = new vec2(0.5f, -3f);
            Assert.That(0.5f, Is.EqualTo(v.x));
            Assert.That(-3f, Is.EqualTo(v.y));
        }
        {
            var v = new vec2(new vec2(3.5f, 7f));
            Assert.That(3.5f, Is.EqualTo(v.x));
            Assert.That(7f, Is.EqualTo(v.y));
        }
        {
            var v = new vec2(new vec3(-5.5f, 8f, -5f));
            Assert.That(-5.5f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
        }
        {
            var v = new vec2(new vec4(-5.5f, 8f, -5f, -5f));
            Assert.That(-5.5f, Is.EqualTo(v.x));
            Assert.That(8f, Is.EqualTo(v.y));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new vec2(-3f, 5f);
        Assert.That(-3f, Is.EqualTo(v[0]));
        Assert.That(5f, Is.EqualTo(v[1]));
        
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
        
        v[1] = 0f;
        Assert.That(0f, Is.EqualTo(v[1]));
        v[1] = 1f;
        Assert.That(1f, Is.EqualTo(v[1]));
        v[1] = 2f;
        Assert.That(2f, Is.EqualTo(v[1]));
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
        v[0] = -4f;
        Assert.That(-4f, Is.EqualTo(v[0]));
        v[1] = -5f;
        Assert.That(-5f, Is.EqualTo(v[1]));
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
        v[1] = -6.5f;
        Assert.That(-6.5f, Is.EqualTo(v[1]));
        v[0] = -5.5f;
        Assert.That(-5.5f, Is.EqualTo(v[0]));
        v[0] = -4.5f;
        Assert.That(-4.5f, Is.EqualTo(v[0]));
        v[1] = -3.5f;
        Assert.That(-3.5f, Is.EqualTo(v[1]));
        v[0] = -2.5f;
        Assert.That(-2.5f, Is.EqualTo(v[0]));
        v[1] = -1.5f;
        Assert.That(-1.5f, Is.EqualTo(v[1]));
        v[1] = -0.5f;
        Assert.That(-0.5f, Is.EqualTo(v[1]));
        v[0] = 0.5f;
        Assert.That(0.5f, Is.EqualTo(v[0]));
        v[1] = 1.5f;
        Assert.That(1.5f, Is.EqualTo(v[1]));
        v[1] = 2.5f;
        Assert.That(2.5f, Is.EqualTo(v[1]));
        v[1] = 3.5f;
        Assert.That(3.5f, Is.EqualTo(v[1]));
        v[0] = 4.5f;
        Assert.That(4.5f, Is.EqualTo(v[0]));
        v[1] = 5.5f;
        Assert.That(5.5f, Is.EqualTo(v[1]));
        v[1] = 6.5f;
        Assert.That(6.5f, Is.EqualTo(v[1]));
        v[1] = 7.5f;
        Assert.That(7.5f, Is.EqualTo(v[1]));
        v[0] = 8.5f;
        Assert.That(8.5f, Is.EqualTo(v[0]));
        v[0] = 9.5f;
        Assert.That(9.5f, Is.EqualTo(v[0]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new vec2(5f, -2f);
        var vals = v.Values;
        Assert.That(5f, Is.EqualTo(vals[0]));
        Assert.That(-2f, Is.EqualTo(vals[1]));
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
        var v1 = new vec2(4f, -5.5f);
        var v2 = new vec2(4f, -5.5f);
        var v3 = new vec2(-5.5f, 4f);
        Assert.That(v1 == new vec2(v1));
        Assert.That(v2 == new vec2(v2));
        Assert.That(v3 == new vec2(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new vec2(4f, -4f);
        
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
        var v0 = new vec2(-6.5f, -5.5f);
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
            var v0 = new vec2(-6.5f, 2f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(-2f, -9f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(4.5f, 9.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(5f, -3.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(-7f, -3f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(-3.5f, -9f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(-1.5f, -9f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(9f, -6.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(7f, -9.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec2(9.5f, -2.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new vec2(-3.5f, 5.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(4f, 1.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(0.5f, 6f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(0f, 9.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(5.5f, 7.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(4.5f, 7.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(7.5f, -9f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(-7.5f, -9f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(8f, -5.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec2(-8f, 2f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new vec2(-7.5f, -5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(-7f, -7.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(-0.5f, 4.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(2.5f, -2f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(4.5f, -0.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(-9.5f, -3f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(-2f, -9f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(0.5f, 7f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(-7.5f, 6f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec2(6.5f, -5.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new vec2(5f, 0.5f);
            var v1 = new vec2(-1.5f, -6f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(5.5f, 0.5f);
            var v1 = new vec2(-2f, -3f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(-9.5f, -8.5f);
            var v1 = new vec2(-9.5f, 3.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(4f, 7.5f);
            var v1 = new vec2(-0.5f, 7.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(-9.5f, -9f);
            var v1 = new vec2(3.5f, -3f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(8f, -4f);
            var v1 = new vec2(0.5f, -3f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(-3.5f, -5f);
            var v1 = new vec2(-7f, 7f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(-5f, -4.5f);
            var v1 = new vec2(-8f, 9.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(0f, -4.5f);
            var v1 = new vec2(-4.5f, -8f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec2(7.5f, -6.5f);
            var v1 = new vec2(-2.5f, -5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new vec2(8f, -8.5f);
            var v1 = new vec2(-9f, -8.5f);
            var v2 = new vec2(9.5f, -6.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(-6.5f, 9f);
            var v1 = new vec2(-0.5f, -1.5f);
            var v2 = new vec2(-6f, -2.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(-7f, 3f);
            var v1 = new vec2(1.5f, -6.5f);
            var v2 = new vec2(-9.5f, -9f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(0.5f, 0f);
            var v1 = new vec2(7.5f, 7.5f);
            var v2 = new vec2(0.5f, -2f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(6f, 7.5f);
            var v1 = new vec2(-1f, -2f);
            var v2 = new vec2(4.5f, 1f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(-6.5f, 1f);
            var v1 = new vec2(3.5f, 7f);
            var v2 = new vec2(-1f, -2.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(-0.5f, 5.5f);
            var v1 = new vec2(-4f, -2f);
            var v2 = new vec2(-9f, 4.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(-7f, -7.5f);
            var v1 = new vec2(-9f, 6f);
            var v2 = new vec2(-9f, 4.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(-1f, -8.5f);
            var v1 = new vec2(-4.5f, 0f);
            var v2 = new vec2(-8.5f, 2f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec2(-8f, -1f);
            var v1 = new vec2(1.5f, 6f);
            var v2 = new vec2(-5f, 2f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new vec2(-8.5f, -4f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(-4.5f, 9.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(2.5f, -1.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(8f, -2.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(4.5f, -4.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(1.5f, -9f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(-7f, 2.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(3f, 5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(-6f, -5.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec2(-0.5f, 9.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new vec2(6.5f, -4f);
            var v1 = new vec2(5.5f, -7f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(-5.5f, 7f);
            var v1 = new vec2(0f, -0.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(5f, 6.5f);
            var v1 = new vec2(-5.5f, 5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(6f, -5.5f);
            var v1 = new vec2(8f, 7f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(7.5f, -5.5f);
            var v1 = new vec2(-0.5f, 2.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(0f, -3.5f);
            var v1 = new vec2(7.5f, -9.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(-7f, -9f);
            var v1 = new vec2(-1.5f, 4f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(8.5f, 3.5f);
            var v1 = new vec2(-7.5f, -2f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(-8.5f, -7.5f);
            var v1 = new vec2(-6f, -8f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec2(-6.5f, -7.5f);
            var v1 = new vec2(6.5f, -8f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new vec2(-9f, -7f);
            var v1 = new vec2(-2.5f, -6.5f);
            var v2 = new vec2(-0.5f, 3.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(2.5f, -0.5f);
            var v1 = new vec2(3f, 5f);
            var v2 = new vec2(1f, 9f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(-5f, 1f);
            var v1 = new vec2(-7f, 1f);
            var v2 = new vec2(-5f, 3.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(-8.5f, 3f);
            var v1 = new vec2(-6f, 1.5f);
            var v2 = new vec2(-4.5f, -9f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(8f, -1f);
            var v1 = new vec2(-2f, 3f);
            var v2 = new vec2(-9f, -6f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(6f, -7f);
            var v1 = new vec2(9.5f, 5f);
            var v2 = new vec2(5.5f, -2f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(-2f, 1f);
            var v1 = new vec2(8.5f, 3.5f);
            var v2 = new vec2(-7f, 3.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(7.5f, -8.5f);
            var v1 = new vec2(0f, -1f);
            var v2 = new vec2(-6.5f, 9f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(-3f, -2.5f);
            var v1 = new vec2(-5.5f, 4.5f);
            var v2 = new vec2(-8f, 8.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec2(4.5f, -1.5f);
            var v1 = new vec2(1.5f, 7f);
            var v2 = new vec2(-5f, -8f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new vec2(7f, -9.5f);
            var v1 = new vec2(-7f, 6.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(-6.5f, -4f);
            var v1 = new vec2(6.5f, -6f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(-6f, 8.5f);
            var v1 = new vec2(1f, 1f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(-1.5f, -9.5f);
            var v1 = new vec2(1.5f, -1.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(-9f, 9f);
            var v1 = new vec2(4.5f, 4.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(6f, 9f);
            var v1 = new vec2(-1.5f, -9.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(8.5f, 7f);
            var v1 = new vec2(6.5f, -3.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(-7.5f, 8f);
            var v1 = new vec2(-1.5f, 8.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(5f, -5.5f);
            var v1 = new vec2(4f, 0f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec2(9f, -0.5f);
            var v1 = new vec2(1.5f, -4.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new vec2(2f, -1f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(4f, -2.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(-0.5f, 7f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(-5f, 4f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(9.5f, 0f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(8f, -8.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(-6f, 3f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(-4f, -3.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(-5f, -2f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec2(-1.5f, -6f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(629052989);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.Random(random, (-1), (3));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(167363029);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomUniform(random, (1), (3));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(2120680599);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.Random(random, (-1), (1));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(704537570);
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
    public void RandomUniform4()
    {
        var random = new Random(255158324);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.Random(random, (2), (3));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomGaussian0()
    {
        var random = new Random(697661355);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomNormal(random, 1.1117084245717659f, 3.897059151854859f);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.1117084245717659).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.1117084245717659).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.897059151854859).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.897059151854859).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(1351247674);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomGaussian(random, 1.250211916514771f, 9.74059242743095f);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.250211916514771).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.250211916514771).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(9.74059242743095).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(9.74059242743095).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(1000879047);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomNormal(random, 1.37119944364354f, 7.3430756373997195f);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.37119944364354).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.37119944364354).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(7.3430756373997195).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(7.3430756373997195).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(906834415);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomGaussian(random, 1.5629217771640613f, 7.385321295533944f);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.5629217771640613).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.5629217771640613).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(7.385321295533944).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(7.385321295533944).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(1901322023);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec2.RandomNormal(random, 1.0149927078816074f, 5.321732636225285f);
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.0149927078816074).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.0149927078816074).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(5.321732636225285).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(5.321732636225285).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(714942274);
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
        var random = new Random(2066265419);
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
        var random = new Random(862043554);
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
        var random = new Random(2096766695);
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
        var random = new Random(346876123);
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
