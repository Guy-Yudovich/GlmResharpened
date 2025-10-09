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
public class FloatVec3Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new vec3(-2.5f);
            Assert.That(-2.5f, Is.EqualTo(v.x));
            Assert.That(-2.5f, Is.EqualTo(v.y));
            Assert.That(-2.5f, Is.EqualTo(v.z));
        }
        {
            var v = new vec3(0.5f, 2.5f, -1.5f);
            Assert.That(0.5f, Is.EqualTo(v.x));
            Assert.That(2.5f, Is.EqualTo(v.y));
            Assert.That(-1.5f, Is.EqualTo(v.z));
        }
        {
            var v = new vec3(new vec2(6f, 2f));
            Assert.That(6f, Is.EqualTo(v.x));
            Assert.That(2f, Is.EqualTo(v.y));
            Assert.That(0f, Is.EqualTo(v.z));
        }
        {
            var v = new vec3(new vec3(-5.5f, -8.5f, 3f));
            Assert.That(-5.5f, Is.EqualTo(v.x));
            Assert.That(-8.5f, Is.EqualTo(v.y));
            Assert.That(3f, Is.EqualTo(v.z));
        }
        {
            var v = new vec3(new vec4(-8.5f, -2f, -1f, -9f));
            Assert.That(-8.5f, Is.EqualTo(v.x));
            Assert.That(-2f, Is.EqualTo(v.y));
            Assert.That(-1f, Is.EqualTo(v.z));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new vec3(-8.5f, 9f, -0.5f);
        Assert.That(-8.5f, Is.EqualTo(v[0]));
        Assert.That(9f, Is.EqualTo(v[1]));
        Assert.That(-0.5f, Is.EqualTo(v[2]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0f; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0f; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0f; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0f; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0f; } );
        
        v[0] = 0f;
        Assert.That(0f, Is.EqualTo(v[0]));
        v[0] = 1f;
        Assert.That(1f, Is.EqualTo(v[0]));
        v[0] = 2f;
        Assert.That(2f, Is.EqualTo(v[0]));
        v[2] = 3f;
        Assert.That(3f, Is.EqualTo(v[2]));
        v[2] = 4f;
        Assert.That(4f, Is.EqualTo(v[2]));
        v[2] = 5f;
        Assert.That(5f, Is.EqualTo(v[2]));
        v[2] = 6f;
        Assert.That(6f, Is.EqualTo(v[2]));
        v[2] = 7f;
        Assert.That(7f, Is.EqualTo(v[2]));
        v[1] = 8f;
        Assert.That(8f, Is.EqualTo(v[1]));
        v[1] = 9f;
        Assert.That(9f, Is.EqualTo(v[1]));
        v[2] = -1f;
        Assert.That(-1f, Is.EqualTo(v[2]));
        v[2] = -2f;
        Assert.That(-2f, Is.EqualTo(v[2]));
        v[2] = -3f;
        Assert.That(-3f, Is.EqualTo(v[2]));
        v[0] = -4f;
        Assert.That(-4f, Is.EqualTo(v[0]));
        v[2] = -5f;
        Assert.That(-5f, Is.EqualTo(v[2]));
        v[2] = -6f;
        Assert.That(-6f, Is.EqualTo(v[2]));
        v[0] = -7f;
        Assert.That(-7f, Is.EqualTo(v[0]));
        v[0] = -8f;
        Assert.That(-8f, Is.EqualTo(v[0]));
        v[0] = -9f;
        Assert.That(-9f, Is.EqualTo(v[0]));
        v[2] = -9.5f;
        Assert.That(-9.5f, Is.EqualTo(v[2]));
        v[1] = -8.5f;
        Assert.That(-8.5f, Is.EqualTo(v[1]));
        v[0] = -7.5f;
        Assert.That(-7.5f, Is.EqualTo(v[0]));
        v[0] = -6.5f;
        Assert.That(-6.5f, Is.EqualTo(v[0]));
        v[1] = -5.5f;
        Assert.That(-5.5f, Is.EqualTo(v[1]));
        v[2] = -4.5f;
        Assert.That(-4.5f, Is.EqualTo(v[2]));
        v[2] = -3.5f;
        Assert.That(-3.5f, Is.EqualTo(v[2]));
        v[2] = -2.5f;
        Assert.That(-2.5f, Is.EqualTo(v[2]));
        v[1] = -1.5f;
        Assert.That(-1.5f, Is.EqualTo(v[1]));
        v[2] = -0.5f;
        Assert.That(-0.5f, Is.EqualTo(v[2]));
        v[2] = 0.5f;
        Assert.That(0.5f, Is.EqualTo(v[2]));
        v[1] = 1.5f;
        Assert.That(1.5f, Is.EqualTo(v[1]));
        v[1] = 2.5f;
        Assert.That(2.5f, Is.EqualTo(v[1]));
        v[2] = 3.5f;
        Assert.That(3.5f, Is.EqualTo(v[2]));
        v[0] = 4.5f;
        Assert.That(4.5f, Is.EqualTo(v[0]));
        v[1] = 5.5f;
        Assert.That(5.5f, Is.EqualTo(v[1]));
        v[0] = 6.5f;
        Assert.That(6.5f, Is.EqualTo(v[0]));
        v[1] = 7.5f;
        Assert.That(7.5f, Is.EqualTo(v[1]));
        v[0] = 8.5f;
        Assert.That(8.5f, Is.EqualTo(v[0]));
        v[2] = 9.5f;
        Assert.That(9.5f, Is.EqualTo(v[2]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new vec3(5.5f, -2.5f, -1f);
        var vals = v.Values;
        Assert.That(5.5f, Is.EqualTo(vals[0]));
        Assert.That(-2.5f, Is.EqualTo(vals[1]));
        Assert.That(-1f, Is.EqualTo(vals[2]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0f, Is.EqualTo(vec3.Zero.x));
        Assert.That(0f, Is.EqualTo(vec3.Zero.y));
        Assert.That(0f, Is.EqualTo(vec3.Zero.z));
        
        Assert.That(1f, Is.EqualTo(vec3.Ones.x));
        Assert.That(1f, Is.EqualTo(vec3.Ones.y));
        Assert.That(1f, Is.EqualTo(vec3.Ones.z));
        
        Assert.That(1f, Is.EqualTo(vec3.UnitX.x));
        Assert.That(0f, Is.EqualTo(vec3.UnitX.y));
        Assert.That(0f, Is.EqualTo(vec3.UnitX.z));
        
        Assert.That(0f, Is.EqualTo(vec3.UnitY.x));
        Assert.That(1f, Is.EqualTo(vec3.UnitY.y));
        Assert.That(0f, Is.EqualTo(vec3.UnitY.z));
        
        Assert.That(0f, Is.EqualTo(vec3.UnitZ.x));
        Assert.That(0f, Is.EqualTo(vec3.UnitZ.y));
        Assert.That(1f, Is.EqualTo(vec3.UnitZ.z));
        
        Assert.That(float.MaxValue, Is.EqualTo(vec3.MaxValue.x));
        Assert.That(float.MaxValue, Is.EqualTo(vec3.MaxValue.y));
        Assert.That(float.MaxValue, Is.EqualTo(vec3.MaxValue.z));
        
        Assert.That(float.MinValue, Is.EqualTo(vec3.MinValue.x));
        Assert.That(float.MinValue, Is.EqualTo(vec3.MinValue.y));
        Assert.That(float.MinValue, Is.EqualTo(vec3.MinValue.z));
        
        Assert.That(float.Epsilon, Is.EqualTo(vec3.Epsilon.x));
        Assert.That(float.Epsilon, Is.EqualTo(vec3.Epsilon.y));
        Assert.That(float.Epsilon, Is.EqualTo(vec3.Epsilon.z));
        
        Assert.That(float.NaN, Is.EqualTo(vec3.NaN.x));
        Assert.That(float.NaN, Is.EqualTo(vec3.NaN.y));
        Assert.That(float.NaN, Is.EqualTo(vec3.NaN.z));
        
        Assert.That(float.NegativeInfinity, Is.EqualTo(vec3.NegativeInfinity.x));
        Assert.That(float.NegativeInfinity, Is.EqualTo(vec3.NegativeInfinity.y));
        Assert.That(float.NegativeInfinity, Is.EqualTo(vec3.NegativeInfinity.z));
        
        Assert.That(float.PositiveInfinity, Is.EqualTo(vec3.PositiveInfinity.x));
        Assert.That(float.PositiveInfinity, Is.EqualTo(vec3.PositiveInfinity.y));
        Assert.That(float.PositiveInfinity, Is.EqualTo(vec3.PositiveInfinity.z));
    }

    [Test]
    public void Operators()
    {
        var v1 = new vec3(8f, -3.5f, 6f);
        var v2 = new vec3(8f, -3.5f, 6f);
        var v3 = new vec3(6f, -3.5f, 8f);
        Assert.That(v1 == new vec3(v1));
        Assert.That(v2 == new vec3(v2));
        Assert.That(v3 == new vec3(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new vec3(8f, -0.5f, -7f);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = vec3.Parse(s0);
        var v1 = vec3.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = vec3.TryParse(s0, out v0);
        var b1 = vec3.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = vec3.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = vec3.TryParse("", out v0);
        Assert.That(!b0);
        b0 = vec3.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { vec3.Parse(null); });
        Assert.Throws<FormatException>(() => { vec3.Parse(""); });
        Assert.Throws<FormatException>(() => { vec3.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = vec3.Parse(s3, "; ", NumberStyles.Number);
        var v4 = vec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = vec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new vec3(6.5f, 7.5f, -9f);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<vec3>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new vec3(-0.5f, 5f, 4f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec3(5f, -2f, -9f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec3(5f, 3.5f, 4f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec3(-1.5f, 8.5f, -7.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec3(5f, 8f, -6.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec3(-5.5f, 2.5f, 2f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec3(2.5f, -1.5f, -8.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec3(9f, 6.5f, 6.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec3(-3f, 9f, 3.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec3(-2f, 0.5f, 6f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new vec3(-1f, -8f, 3.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec3(1f, -6.5f, -5.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec3(3f, -9.5f, 3.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec3(-3.5f, 2.5f, 1f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec3(7.5f, 5.5f, -0.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec3(0.5f, 2f, 8f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec3(3.5f, 5f, -0.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec3(-9.5f, 0.5f, 2.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec3(0.5f, 8.5f, -7f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec3(-1.5f, -3.5f, 1f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new vec3(1.5f, -1.5f, 7.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec3(0f, 9.5f, -5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec3(9.5f, 2f, 8.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec3(5.5f, -1f, -7.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec3(8.5f, -1.5f, -9.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec3(1.5f, 3f, -3f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec3(-6f, -1f, 9.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec3(5f, -3f, 9.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec3(9.5f, 6.5f, 4.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec3(8.5f, -5f, -1.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new vec3(-0.5f, 3f, 3.5f);
            var v1 = new vec3(3.5f, 1f, 7.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec3(9.5f, -6f, -3f);
            var v1 = new vec3(5.5f, 5f, -8.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec3(9.5f, -4f, 6.5f);
            var v1 = new vec3(1f, -3.5f, -1f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec3(9.5f, -8.5f, -1.5f);
            var v1 = new vec3(2.5f, 3f, 1f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec3(-1f, -8f, -3.5f);
            var v1 = new vec3(-2f, 7.5f, -7.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec3(8f, 7.5f, 8f);
            var v1 = new vec3(-1f, -2.5f, -2f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec3(9f, -3.5f, 8f);
            var v1 = new vec3(-3f, 3.5f, 1f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec3(-4.5f, 1.5f, -9f);
            var v1 = new vec3(7f, -5.5f, -5.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec3(-2f, 5.5f, -9f);
            var v1 = new vec3(2.5f, 0f, -3f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec3(-8.5f, 7.5f, 9.5f);
            var v1 = new vec3(2.5f, -7.5f, -6.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new vec3(2f, 8f, -5.5f);
            var v1 = new vec3(4f, 0.5f, -9f);
            var v2 = new vec3(7f, -1.5f, -7f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec3(9f, 1.5f, -4f);
            var v1 = new vec3(9.5f, 8f, -5.5f);
            var v2 = new vec3(-1.5f, -2.5f, -5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec3(-5f, 1f, -3f);
            var v1 = new vec3(-1f, -9f, 2f);
            var v2 = new vec3(7.5f, -8f, -8f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec3(-2f, 2f, -4f);
            var v1 = new vec3(-6f, -6.5f, 6f);
            var v2 = new vec3(-1.5f, 6f, 3f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec3(-7f, 7.5f, -5f);
            var v1 = new vec3(9f, -3f, 5.5f);
            var v2 = new vec3(-3.5f, 7f, -7.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec3(5f, 2.5f, -5.5f);
            var v1 = new vec3(-4.5f, 7.5f, 2.5f);
            var v2 = new vec3(3f, 1f, 2f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec3(6.5f, 1.5f, -0.5f);
            var v1 = new vec3(-7.5f, 6f, -3f);
            var v2 = new vec3(0f, 5.5f, -3.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec3(2f, 3.5f, 8f);
            var v1 = new vec3(6f, -1f, 2f);
            var v2 = new vec3(-9.5f, -2f, 0.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec3(9.5f, 4f, -0.5f);
            var v1 = new vec3(-7f, -4.5f, -1f);
            var v2 = new vec3(-9.5f, 2.5f, -4.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec3(3.5f, -2.5f, 5f);
            var v1 = new vec3(-7.5f, -3f, -8.5f);
            var v2 = new vec3(3f, 1.5f, -5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new vec3(5.5f, -2.5f, -7.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec3(-4.5f, -3f, -7f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec3(-8.5f, -5.5f, 0f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec3(6f, -8f, 5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec3(8f, 9f, -9f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec3(-5.5f, 4.5f, 6.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec3(9f, 1.5f, 2.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec3(0.5f, -2.5f, -1f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec3(7.5f, 7.5f, -1f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec3(-1.5f, -7.5f, 1.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new vec3(1f, -5.5f, 0.5f);
            var v1 = new vec3(-1.5f, 9f, -9.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec3(-7.5f, -1f, 0f);
            var v1 = new vec3(0.5f, 0.5f, 2f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec3(-6.5f, 9f, 9f);
            var v1 = new vec3(-7.5f, 9f, 7f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec3(-5f, 9f, 5f);
            var v1 = new vec3(-2f, -8f, -2f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec3(-9.5f, -8.5f, 7.5f);
            var v1 = new vec3(-4f, 8f, 1.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec3(-8f, -7f, 0f);
            var v1 = new vec3(9f, 7f, 7.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec3(8.5f, 2.5f, 7.5f);
            var v1 = new vec3(-9f, 7.5f, -3f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec3(-4.5f, 9f, -5f);
            var v1 = new vec3(9f, 0.5f, -0.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec3(2f, -1f, -0.5f);
            var v1 = new vec3(-1.5f, -4.5f, 4f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec3(-9f, 0.5f, 5f);
            var v1 = new vec3(-8f, 8f, -1.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new vec3(-1.5f, 5.5f, 0f);
            var v1 = new vec3(2.5f, 4.5f, -8.5f);
            var v2 = new vec3(-2.5f, -1f, -9f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec3(-1f, -4f, -2.5f);
            var v1 = new vec3(-7.5f, 6.5f, -2.5f);
            var v2 = new vec3(7.5f, -2.5f, 4f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec3(2f, -9.5f, 7f);
            var v1 = new vec3(5f, 2.5f, 9f);
            var v2 = new vec3(-5.5f, 7.5f, 5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec3(5.5f, -9.5f, -6f);
            var v1 = new vec3(-3f, 7f, -4f);
            var v2 = new vec3(0f, 0.5f, -6f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec3(1.5f, 2f, 9f);
            var v1 = new vec3(8.5f, -4.5f, -2f);
            var v2 = new vec3(-4.5f, -2f, -2.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec3(-3.5f, 4f, -5f);
            var v1 = new vec3(6.5f, -8f, 4f);
            var v2 = new vec3(-6.5f, -1f, -1.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec3(-2.5f, -6.5f, 3f);
            var v1 = new vec3(0.5f, 7f, 6.5f);
            var v2 = new vec3(-5f, 2.5f, 0.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec3(2f, 7.5f, 6f);
            var v1 = new vec3(-3f, -8.5f, 5f);
            var v2 = new vec3(-2f, 5f, -4.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec3(4.5f, 4f, 5.5f);
            var v1 = new vec3(6.5f, -9.5f, -9.5f);
            var v2 = new vec3(-6.5f, 7.5f, 3.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec3(1.5f, 9.5f, 2f);
            var v1 = new vec3(-1f, 0.5f, 7.5f);
            var v2 = new vec3(-3.5f, -4f, 7f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new vec3(-4.5f, 8f, -3.5f);
            var v1 = new vec3(-4f, 1f, -7.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec3(-4.5f, -1.5f, -5.5f);
            var v1 = new vec3(-6f, 0.5f, 7.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec3(4f, 9.5f, 9f);
            var v1 = new vec3(3.5f, -8.5f, 9f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec3(1.5f, -5f, 7f);
            var v1 = new vec3(9f, 4f, 0f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec3(-9f, -7f, -4f);
            var v1 = new vec3(-8.5f, 0f, -8f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec3(0f, 7f, -5.5f);
            var v1 = new vec3(4f, 5.5f, 3.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec3(-3f, -2f, -8.5f);
            var v1 = new vec3(8.5f, -8.5f, -1.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec3(-6.5f, -6.5f, -6.5f);
            var v1 = new vec3(-8f, -1.5f, -8f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec3(-2f, 6.5f, -5f);
            var v1 = new vec3(-6f, -3f, -3.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec3(3.5f, -6f, 4f);
            var v1 = new vec3(-4.5f, 5.5f, -4.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new vec3(-6f, 2f, 8f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec3(1.5f, -2f, -4f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec3(-5.5f, 3.5f, 7.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec3(-4f, 7f, -9f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec3(-2f, 3f, 3f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec3(-6f, -8.5f, 5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec3(-7.5f, 2f, 2.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec3(-9.5f, 2f, 6f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec3(-6f, 4f, -1f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec3(6.5f, -4.5f, 8f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void InvariantCrossDot()
    {
        {
            var v0 = new vec3(6.5f, -6f, 1f);
            var v1 = new vec3(-5.5f, -5f, 9.5f);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new vec3(-6.5f, -7.5f, 3f);
            var v1 = new vec3(-1f, -4f, 4.5f);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new vec3(3.5f, 8.5f, -9.5f);
            var v1 = new vec3(2.5f, -9.5f, -1.5f);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new vec3(-8.5f, 9f, -9.5f);
            var v1 = new vec3(-5f, -9f, 3f);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new vec3(-8.5f, -8.5f, -0.5f);
            var v1 = new vec3(-6f, 4.5f, 4.5f);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new vec3(4f, -9f, 8.5f);
            var v1 = new vec3(8f, 2f, -6f);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new vec3(-2.5f, 2.5f, 9f);
            var v1 = new vec3(0.5f, 7.5f, 4.5f);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new vec3(-5f, -7f, -9f);
            var v1 = new vec3(7.5f, 2.5f, 7f);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new vec3(8f, -6.5f, -9.5f);
            var v1 = new vec3(-1.5f, -3.5f, 2f);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new vec3(-9.5f, -7.5f, 6.5f);
            var v1 = new vec3(7.5f, 3f, 4.5f);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(1918079133);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.Random(random, (-3), (-2));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-2.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-2.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-2.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(231633991);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.RandomUniform(random, (1), (4));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(780523770);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.Random(random, (-1), (0));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(1661767223);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.RandomUniform(random, (0), (3));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(148431452);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.Random(random, (2), (6));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(4).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomGaussian0()
    {
        var random = new Random(794663273);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.RandomNormal(random, 0.7443291185164496f, 0.40629741754676096f);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.7443291185164496).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.7443291185164496).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.7443291185164496).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.40629741754676096).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.40629741754676096).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.40629741754676096).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(1646823584);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.RandomGaussian(random, -1.8774104378546637f, 1.729985909410746f);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.8774104378546637).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.8774104378546637).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-1.8774104378546637).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.729985909410746).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.729985909410746).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.729985909410746).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(415155407);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.RandomNormal(random, 1.0212864498706935f, 2.5562856358272423f);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.0212864498706935).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.0212864498706935).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.0212864498706935).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.5562856358272423).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.5562856358272423).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.5562856358272423).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(1486158406);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.RandomGaussian(random, 1.9714256785676936f, 6.692871952752057f);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.9714256785676936).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.9714256785676936).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.9714256785676936).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(6.692871952752057).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(6.692871952752057).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(6.692871952752057).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(1317272855);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.RandomNormal(random, 1.3693609104349096f, 2.54167813926082f);
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.3693609104349096).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.3693609104349096).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.3693609104349096).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.54167813926082).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.54167813926082).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.54167813926082).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(1398131508);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.RandomNormal(random);
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
        var random = new Random(1040235283);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.RandomNormal(random);
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
        var random = new Random(1110860927);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.RandomNormal(random);
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
        var random = new Random(682235894);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.RandomNormal(random);
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
        var random = new Random(2066677391);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec3.RandomNormal(random);
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
