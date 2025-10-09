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
public class FloatVec4Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new vec4(-7.5f);
            Assert.That(-7.5f, Is.EqualTo(v.x));
            Assert.That(-7.5f, Is.EqualTo(v.y));
            Assert.That(-7.5f, Is.EqualTo(v.z));
            Assert.That(-7.5f, Is.EqualTo(v.w));
        }
        {
            var v = new vec4(1.5f, -5.5f, -6f, 0.5f);
            Assert.That(1.5f, Is.EqualTo(v.x));
            Assert.That(-5.5f, Is.EqualTo(v.y));
            Assert.That(-6f, Is.EqualTo(v.z));
            Assert.That(0.5f, Is.EqualTo(v.w));
        }
        {
            var v = new vec4(new vec2(-2f, -7f));
            Assert.That(-2f, Is.EqualTo(v.x));
            Assert.That(-7f, Is.EqualTo(v.y));
            Assert.That(0f, Is.EqualTo(v.z));
            Assert.That(0f, Is.EqualTo(v.w));
        }
        {
            var v = new vec4(new vec3(2.5f, -1f, -1.5f));
            Assert.That(2.5f, Is.EqualTo(v.x));
            Assert.That(-1f, Is.EqualTo(v.y));
            Assert.That(-1.5f, Is.EqualTo(v.z));
            Assert.That(0f, Is.EqualTo(v.w));
        }
        {
            var v = new vec4(new vec4(-5.5f, 5f, 4f, -6f));
            Assert.That(-5.5f, Is.EqualTo(v.x));
            Assert.That(5f, Is.EqualTo(v.y));
            Assert.That(4f, Is.EqualTo(v.z));
            Assert.That(-6f, Is.EqualTo(v.w));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new vec4(-2.5f, 7f, 7.5f, -2f);
        Assert.That(-2.5f, Is.EqualTo(v[0]));
        Assert.That(7f, Is.EqualTo(v[1]));
        Assert.That(7.5f, Is.EqualTo(v[2]));
        Assert.That(-2f, Is.EqualTo(v[3]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0f; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0f; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0f; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0f; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0f; } );
        
        v[1] = 0f;
        Assert.That(0f, Is.EqualTo(v[1]));
        v[0] = 1f;
        Assert.That(1f, Is.EqualTo(v[0]));
        v[0] = 2f;
        Assert.That(2f, Is.EqualTo(v[0]));
        v[1] = 3f;
        Assert.That(3f, Is.EqualTo(v[1]));
        v[2] = 4f;
        Assert.That(4f, Is.EqualTo(v[2]));
        v[3] = 5f;
        Assert.That(5f, Is.EqualTo(v[3]));
        v[2] = 6f;
        Assert.That(6f, Is.EqualTo(v[2]));
        v[2] = 7f;
        Assert.That(7f, Is.EqualTo(v[2]));
        v[3] = 8f;
        Assert.That(8f, Is.EqualTo(v[3]));
        v[3] = 9f;
        Assert.That(9f, Is.EqualTo(v[3]));
        v[2] = -1f;
        Assert.That(-1f, Is.EqualTo(v[2]));
        v[1] = -2f;
        Assert.That(-2f, Is.EqualTo(v[1]));
        v[0] = -3f;
        Assert.That(-3f, Is.EqualTo(v[0]));
        v[3] = -4f;
        Assert.That(-4f, Is.EqualTo(v[3]));
        v[3] = -5f;
        Assert.That(-5f, Is.EqualTo(v[3]));
        v[3] = -6f;
        Assert.That(-6f, Is.EqualTo(v[3]));
        v[3] = -7f;
        Assert.That(-7f, Is.EqualTo(v[3]));
        v[1] = -8f;
        Assert.That(-8f, Is.EqualTo(v[1]));
        v[0] = -9f;
        Assert.That(-9f, Is.EqualTo(v[0]));
        v[1] = -9.5f;
        Assert.That(-9.5f, Is.EqualTo(v[1]));
        v[2] = -8.5f;
        Assert.That(-8.5f, Is.EqualTo(v[2]));
        v[3] = -7.5f;
        Assert.That(-7.5f, Is.EqualTo(v[3]));
        v[2] = -6.5f;
        Assert.That(-6.5f, Is.EqualTo(v[2]));
        v[1] = -5.5f;
        Assert.That(-5.5f, Is.EqualTo(v[1]));
        v[2] = -4.5f;
        Assert.That(-4.5f, Is.EqualTo(v[2]));
        v[0] = -3.5f;
        Assert.That(-3.5f, Is.EqualTo(v[0]));
        v[0] = -2.5f;
        Assert.That(-2.5f, Is.EqualTo(v[0]));
        v[0] = -1.5f;
        Assert.That(-1.5f, Is.EqualTo(v[0]));
        v[0] = -0.5f;
        Assert.That(-0.5f, Is.EqualTo(v[0]));
        v[2] = 0.5f;
        Assert.That(0.5f, Is.EqualTo(v[2]));
        v[3] = 1.5f;
        Assert.That(1.5f, Is.EqualTo(v[3]));
        v[2] = 2.5f;
        Assert.That(2.5f, Is.EqualTo(v[2]));
        v[0] = 3.5f;
        Assert.That(3.5f, Is.EqualTo(v[0]));
        v[2] = 4.5f;
        Assert.That(4.5f, Is.EqualTo(v[2]));
        v[3] = 5.5f;
        Assert.That(5.5f, Is.EqualTo(v[3]));
        v[3] = 6.5f;
        Assert.That(6.5f, Is.EqualTo(v[3]));
        v[1] = 7.5f;
        Assert.That(7.5f, Is.EqualTo(v[1]));
        v[3] = 8.5f;
        Assert.That(8.5f, Is.EqualTo(v[3]));
        v[3] = 9.5f;
        Assert.That(9.5f, Is.EqualTo(v[3]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new vec4(-9f, -6.5f, -8f, -0.5f);
        var vals = v.Values;
        Assert.That(-9f, Is.EqualTo(vals[0]));
        Assert.That(-6.5f, Is.EqualTo(vals[1]));
        Assert.That(-8f, Is.EqualTo(vals[2]));
        Assert.That(-0.5f, Is.EqualTo(vals[3]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(0f, Is.EqualTo(vec4.Zero.x));
        Assert.That(0f, Is.EqualTo(vec4.Zero.y));
        Assert.That(0f, Is.EqualTo(vec4.Zero.z));
        Assert.That(0f, Is.EqualTo(vec4.Zero.w));
        
        Assert.That(1f, Is.EqualTo(vec4.Ones.x));
        Assert.That(1f, Is.EqualTo(vec4.Ones.y));
        Assert.That(1f, Is.EqualTo(vec4.Ones.z));
        Assert.That(1f, Is.EqualTo(vec4.Ones.w));
        
        Assert.That(1f, Is.EqualTo(vec4.UnitX.x));
        Assert.That(0f, Is.EqualTo(vec4.UnitX.y));
        Assert.That(0f, Is.EqualTo(vec4.UnitX.z));
        Assert.That(0f, Is.EqualTo(vec4.UnitX.w));
        
        Assert.That(0f, Is.EqualTo(vec4.UnitY.x));
        Assert.That(1f, Is.EqualTo(vec4.UnitY.y));
        Assert.That(0f, Is.EqualTo(vec4.UnitY.z));
        Assert.That(0f, Is.EqualTo(vec4.UnitY.w));
        
        Assert.That(0f, Is.EqualTo(vec4.UnitZ.x));
        Assert.That(0f, Is.EqualTo(vec4.UnitZ.y));
        Assert.That(1f, Is.EqualTo(vec4.UnitZ.z));
        Assert.That(0f, Is.EqualTo(vec4.UnitZ.w));
        
        Assert.That(0f, Is.EqualTo(vec4.UnitW.x));
        Assert.That(0f, Is.EqualTo(vec4.UnitW.y));
        Assert.That(0f, Is.EqualTo(vec4.UnitW.z));
        Assert.That(1f, Is.EqualTo(vec4.UnitW.w));
        
        Assert.That(float.MaxValue, Is.EqualTo(vec4.MaxValue.x));
        Assert.That(float.MaxValue, Is.EqualTo(vec4.MaxValue.y));
        Assert.That(float.MaxValue, Is.EqualTo(vec4.MaxValue.z));
        Assert.That(float.MaxValue, Is.EqualTo(vec4.MaxValue.w));
        
        Assert.That(float.MinValue, Is.EqualTo(vec4.MinValue.x));
        Assert.That(float.MinValue, Is.EqualTo(vec4.MinValue.y));
        Assert.That(float.MinValue, Is.EqualTo(vec4.MinValue.z));
        Assert.That(float.MinValue, Is.EqualTo(vec4.MinValue.w));
        
        Assert.That(float.Epsilon, Is.EqualTo(vec4.Epsilon.x));
        Assert.That(float.Epsilon, Is.EqualTo(vec4.Epsilon.y));
        Assert.That(float.Epsilon, Is.EqualTo(vec4.Epsilon.z));
        Assert.That(float.Epsilon, Is.EqualTo(vec4.Epsilon.w));
        
        Assert.That(float.NaN, Is.EqualTo(vec4.NaN.x));
        Assert.That(float.NaN, Is.EqualTo(vec4.NaN.y));
        Assert.That(float.NaN, Is.EqualTo(vec4.NaN.z));
        Assert.That(float.NaN, Is.EqualTo(vec4.NaN.w));
        
        Assert.That(float.NegativeInfinity, Is.EqualTo(vec4.NegativeInfinity.x));
        Assert.That(float.NegativeInfinity, Is.EqualTo(vec4.NegativeInfinity.y));
        Assert.That(float.NegativeInfinity, Is.EqualTo(vec4.NegativeInfinity.z));
        Assert.That(float.NegativeInfinity, Is.EqualTo(vec4.NegativeInfinity.w));
        
        Assert.That(float.PositiveInfinity, Is.EqualTo(vec4.PositiveInfinity.x));
        Assert.That(float.PositiveInfinity, Is.EqualTo(vec4.PositiveInfinity.y));
        Assert.That(float.PositiveInfinity, Is.EqualTo(vec4.PositiveInfinity.z));
        Assert.That(float.PositiveInfinity, Is.EqualTo(vec4.PositiveInfinity.w));
    }

    [Test]
    public void Operators()
    {
        var v1 = new vec4(-5f, 7.5f, -6.5f, -8.5f);
        var v2 = new vec4(-5f, 7.5f, -6.5f, -8.5f);
        var v3 = new vec4(-8.5f, -6.5f, 7.5f, -5f);
        Assert.That(v1 == new vec4(v1));
        Assert.That(v2 == new vec4(v2));
        Assert.That(v3 == new vec4(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new vec4(5f, -8.5f, -2f, -0.5f);
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = vec4.Parse(s0);
        var v1 = vec4.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = vec4.TryParse(s0, out v0);
        var b1 = vec4.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = vec4.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = vec4.TryParse("", out v0);
        Assert.That(!b0);
        b0 = vec4.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { vec4.Parse(null); });
        Assert.Throws<FormatException>(() => { vec4.Parse(""); });
        Assert.Throws<FormatException>(() => { vec4.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = vec4.Parse(s3, "; ", NumberStyles.Number);
        var v4 = vec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = vec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new vec4(1.5f, 9.5f, -1f, -3.5f);
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<vec4>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new vec4(4.5f, -8f, -4.5f, -1f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec4(-8.5f, -7f, 5.5f, 2.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec4(-3.5f, -2.5f, -2f, -8.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec4(-9f, 1.5f, -4f, 5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec4(2.5f, 8.5f, -4.5f, -3.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec4(0.5f, -8.5f, -4f, 6.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec4(-7.5f, -6f, 6f, -1.5f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec4(4f, 5f, 4.5f, 9f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec4(-1f, 8f, -9.5f, -4f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new vec4(2.5f, -5.5f, 2f, 7f);
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new vec4(-3f, 5f, 6.5f, -5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec4(9f, -2f, 6.5f, 4f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec4(7.5f, -0.5f, -8f, 1f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec4(-2.5f, 5f, 7f, 9.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec4(-7.5f, 2.5f, -5.5f, 7f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec4(-6.5f, -1f, -9.5f, 9.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec4(4f, -2.5f, -6.5f, -2f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec4(8f, -1f, -0.5f, 2.5f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec4(-6.5f, -6f, 2.5f, -9f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
        {
            var v0 = new vec4(-4f, -6.5f, 1f, -6f);
            Assert.That(v0 + v0, Is.EqualTo(2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new vec4(7.5f, -2.5f, 5f, -3f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec4(-6f, 6f, 6f, 2.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec4(1.5f, -1.5f, 8.5f, -2.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec4(-3f, 2.5f, -9f, -9f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec4(9.5f, -4f, -9f, 9.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec4(-3.5f, 7f, -5.5f, -0.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec4(-8f, -9.5f, 9.5f, -5.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec4(6f, 4.5f, -4f, 6.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec4(9f, 7.5f, -1.5f, 4f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
        {
            var v0 = new vec4(-8f, -7f, -8f, 0.5f);
            Assert.That(v0 + v0 + v0, Is.EqualTo(3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new vec4(3.5f, 7.5f, 9.5f, -3.5f);
            var v1 = new vec4(-1.5f, 8.5f, -6f, -4f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec4(-9f, 0.5f, -7f, 5f);
            var v1 = new vec4(2.5f, -2.5f, -8.5f, -5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec4(-6.5f, -7f, 6f, -3f);
            var v1 = new vec4(-1.5f, -7.5f, 0.5f, -7.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec4(4.5f, 7.5f, -8.5f, 5.5f);
            var v1 = new vec4(-6.5f, -1f, -9.5f, -5.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec4(-4.5f, -6.5f, 3f, 7.5f);
            var v1 = new vec4(-9f, 1.5f, 9f, 4.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec4(9.5f, 1f, 0.5f, -1f);
            var v1 = new vec4(-1f, -7.5f, 7f, -7f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec4(-3.5f, 7f, -9.5f, 6f);
            var v1 = new vec4(-4f, 0.5f, 9.5f, -1f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec4(6f, -8f, 2.5f, 0.5f);
            var v1 = new vec4(-7f, -9.5f, 0.5f, 7f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec4(9f, 2.5f, -9.5f, 9f);
            var v1 = new vec4(-5.5f, -6.5f, 6.5f, 1.5f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new vec4(7f, -3f, -4f, -2.5f);
            var v1 = new vec4(2.5f, -9.5f, -2f, -3f);
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new vec4(-7.5f, -5f, 5f, -3f);
            var v1 = new vec4(2f, -8f, 2.5f, 6.5f);
            var v2 = new vec4(-4f, 4f, -9f, -0.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec4(-3.5f, 2.5f, -4f, 1f);
            var v1 = new vec4(7.5f, -3.5f, 2f, -2f);
            var v2 = new vec4(9.5f, -9.5f, 1.5f, 0.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec4(6.5f, 7f, -7.5f, -1.5f);
            var v1 = new vec4(2.5f, 8.5f, -9f, -0.5f);
            var v2 = new vec4(3.5f, -4.5f, -7.5f, 8f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec4(-7.5f, 2.5f, 8f, 5.5f);
            var v1 = new vec4(0f, -6f, 4f, 4.5f);
            var v2 = new vec4(6f, 5.5f, 0f, -8.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec4(9f, 2f, -7f, -9.5f);
            var v1 = new vec4(6.5f, 8.5f, 0f, 1f);
            var v2 = new vec4(-5.5f, -5f, -6f, 4.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec4(5.5f, 3f, 3f, -5f);
            var v1 = new vec4(-3.5f, 0.5f, 5.5f, 0f);
            var v2 = new vec4(9f, 5f, -9f, 4f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec4(-7f, 7f, -2f, -6.5f);
            var v1 = new vec4(-5f, 6.5f, -5.5f, 1f);
            var v2 = new vec4(7f, 1f, -8f, 0.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec4(-7.5f, 9.5f, 2.5f, 5.5f);
            var v1 = new vec4(-4.5f, -9.5f, -5.5f, 7f);
            var v2 = new vec4(-7f, -4f, 9.5f, 6.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec4(-3f, -0.5f, 8f, -6f);
            var v1 = new vec4(9.5f, 9.5f, -1f, 4f);
            var v2 = new vec4(-6.5f, -2f, 2f, -0.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new vec4(-3.5f, -7f, -2.5f, -1.5f);
            var v1 = new vec4(1.5f, -5f, -2.5f, 4.5f);
            var v2 = new vec4(-4.5f, -3f, 3.5f, -3.5f);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new vec4(-0.5f, -0.5f, -4f, -4f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec4(5.5f, -4.5f, -4f, 4.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec4(8f, -4f, 0.5f, 0f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec4(4.5f, 6f, -9.5f, 6.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec4(8.5f, 4.5f, 6f, 2f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec4(5f, -2.5f, -6f, -8.5f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec4(-9f, -4f, 5f, 2f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec4(0.5f, -3.5f, -4f, -3f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec4(1.5f, -8f, -3f, -7f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new vec4(-2f, 1.5f, -9.5f, 4f);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new vec4(-7.5f, 9.5f, 9.5f, -1.5f);
            var v1 = new vec4(-6.5f, -6f, -8f, -4f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec4(-0.5f, -5.5f, -8.5f, 9.5f);
            var v1 = new vec4(1f, 1.5f, -2.5f, 8f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec4(-6f, 3.5f, 1f, 3f);
            var v1 = new vec4(6f, -9f, 2.5f, -9.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec4(-5f, 4f, 2f, -2.5f);
            var v1 = new vec4(-2.5f, -8.5f, -7f, 4.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec4(0f, 3f, -9.5f, -4f);
            var v1 = new vec4(1f, 7.5f, -2.5f, -3.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec4(-6f, 9.5f, 6f, 3.5f);
            var v1 = new vec4(-4f, 1.5f, 2f, -6f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec4(3.5f, -0.5f, -9f, 5.5f);
            var v1 = new vec4(-3f, 5.5f, -7f, 2f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec4(7f, -9f, -4f, -9f);
            var v1 = new vec4(-3f, 1.5f, -2.5f, 8f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec4(7f, -3.5f, 9.5f, 8.5f);
            var v1 = new vec4(-1f, -3f, 6f, -8f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new vec4(6f, -6f, -1.5f, 7f);
            var v1 = new vec4(-3f, 9.5f, 6f, -6.5f);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new vec4(4.5f, 4.5f, 8f, 4f);
            var v1 = new vec4(-1f, -3f, 4.5f, 9.5f);
            var v2 = new vec4(-1f, 3f, 1f, 2.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec4(6.5f, 9.5f, -3.5f, -4.5f);
            var v1 = new vec4(-6.5f, 5f, 5f, 8f);
            var v2 = new vec4(4.5f, 8f, 3f, 9.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec4(2f, -8.5f, -1f, -8.5f);
            var v1 = new vec4(-2f, -7.5f, 3.5f, -6.5f);
            var v2 = new vec4(0.5f, -5f, 7f, 7f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec4(-1.5f, 1f, 6f, 6f);
            var v1 = new vec4(8.5f, 5f, 6f, 3.5f);
            var v2 = new vec4(-6.5f, 3f, -1f, -5.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec4(-9.5f, 9.5f, -9.5f, -1.5f);
            var v1 = new vec4(8.5f, -0.5f, 7f, -4.5f);
            var v2 = new vec4(0.5f, 8f, 1f, 0.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec4(1f, -4f, -1.5f, -0.5f);
            var v1 = new vec4(9f, -9f, 1f, -7.5f);
            var v2 = new vec4(1.5f, -9f, 6.5f, -7.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec4(9.5f, 8.5f, -1f, -1.5f);
            var v1 = new vec4(1f, -1f, -7f, 8.5f);
            var v2 = new vec4(-1f, -2.5f, 0f, -2f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec4(1f, 5f, -5.5f, 1f);
            var v1 = new vec4(6f, -7.5f, -7f, -9f);
            var v2 = new vec4(0f, -7f, 5f, -5.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec4(-8f, -8f, -6.5f, 4f);
            var v1 = new vec4(1f, -0.5f, 2.5f, 0f);
            var v2 = new vec4(2f, 8.5f, -0.5f, 9.5f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new vec4(-8f, -9.5f, -6.5f, -9.5f);
            var v1 = new vec4(2.5f, 2f, -9f, -4f);
            var v2 = new vec4(-3f, -7f, -1.5f, 4f);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new vec4(2.5f, -6f, 4.5f, -0.5f);
            var v1 = new vec4(-6f, 4f, 4.5f, 5.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec4(-5.5f, 5.5f, -3f, -4f);
            var v1 = new vec4(-3f, -9f, 2.5f, -4f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec4(-2.5f, -2f, -3.5f, 1.5f);
            var v1 = new vec4(-8f, -7.5f, 4f, -6.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec4(9f, 8f, -5.5f, -8f);
            var v1 = new vec4(0f, -2f, 3f, -8.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec4(-1.5f, 7.5f, 5f, -1f);
            var v1 = new vec4(7f, 2.5f, -0.5f, 4.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec4(9f, -0.5f, -2.5f, -9.5f);
            var v1 = new vec4(8f, -9.5f, -9.5f, -9.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec4(7.5f, 4f, -9.5f, 1f);
            var v1 = new vec4(6f, 5.5f, 5f, 9f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec4(-2f, -2f, -9f, 6f);
            var v1 = new vec4(-9.5f, -6f, 4.5f, -3f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec4(2.5f, 1.5f, -3.5f, -6f);
            var v1 = new vec4(-4f, -8.5f, 5f, 4.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new vec4(-6.5f, 1.5f, -8.5f, -0.5f);
            var v1 = new vec4(5.5f, -5.5f, -4f, -0.5f);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new vec4(8.5f, 7f, -9.5f, -9f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec4(-5.5f, -0.5f, 6.5f, -3f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec4(-9f, 4f, 6f, 5.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec4(9.5f, 2.5f, -3f, 8f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec4(5f, 1f, 1.5f, -4.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec4(-7f, -4.5f, 9.5f, 4.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec4(-0.5f, -3.5f, 7f, 2f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec4(8f, -7f, -6.5f, -0.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec4(-6.5f, -8.5f, -4f, 3.5f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new vec4(3f, -6.5f, 4.5f, 3f);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(1502130737);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.Random(random, (1), (4));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(2.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(535370667);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.RandomUniform(random, (4), (5));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(4.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(4.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(492202453);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.Random(random, (3), (6));
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
    public void RandomUniform3()
    {
        var random = new Random(1360748445);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.RandomUniform(random, (-5), (-4));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-4.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-4.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-4.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-4.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(1124294771);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.Random(random, (2), (5));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(3.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(3.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomGaussian0()
    {
        var random = new Random(1095682051);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.RandomNormal(random, 1.6382151207133266f, 6.999578553717387f);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.6382151207133266).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.6382151207133266).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.6382151207133266).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.6382151207133266).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(6.999578553717387).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(6.999578553717387).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(6.999578553717387).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(6.999578553717387).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(1773386286);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.RandomGaussian(random, 1.9665309246473623f, 3.775408120721303f);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.9665309246473623).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.9665309246473623).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.9665309246473623).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.9665309246473623).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(3.775408120721303).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(3.775408120721303).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(3.775408120721303).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(3.775408120721303).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(351849251);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.RandomNormal(random, 1.3612577893590823f, 4.849590363376583f);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.3612577893590823).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.3612577893590823).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.3612577893590823).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.3612577893590823).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(4.849590363376583).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(4.849590363376583).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(4.849590363376583).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(4.849590363376583).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(1428329899);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.RandomGaussian(random, -0.929415223621491f, 0.6019194892616567f);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.929415223621491).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.929415223621491).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.929415223621491).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-0.929415223621491).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.6019194892616567).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.6019194892616567).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.6019194892616567).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.6019194892616567).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(1597215450);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.RandomNormal(random, -0.3273504554887072f, 4.753113302752894f);
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.3273504554887072).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.3273504554887072).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.3273504554887072).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-0.3273504554887072).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(4.753113302752894).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(4.753113302752894).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(4.753113302752894).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(4.753113302752894).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(1699150286);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.RandomNormal(random);
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
        var random = new Random(232490940);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.RandomNormal(random);
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
        var random = new Random(1803627378);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.RandomNormal(random);
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
        var random = new Random(381217116);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.RandomNormal(random);
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
        var random = new Random(1353532479);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = vec4.RandomNormal(random);
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
