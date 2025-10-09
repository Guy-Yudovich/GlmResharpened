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
public class HalfVec2Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new hvec2(((Half)(8)));
            Assert.That(((Half)(8)), Is.EqualTo(v.x));
            Assert.That(((Half)(8)), Is.EqualTo(v.y));
        }
        {
            var v = new hvec2(((Half)(-1.5)), ((Half)(9)));
            Assert.That(((Half)(-1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(9)), Is.EqualTo(v.y));
        }
        {
            var v = new hvec2(new hvec2(((Half)(2)), ((Half)(-6))));
            Assert.That(((Half)(2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-6)), Is.EqualTo(v.y));
        }
        {
            var v = new hvec2(new hvec3(((Half)(-9.5)), ((Half)(-3.5)), ((Half)(5))));
            Assert.That(((Half)(-9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-3.5)), Is.EqualTo(v.y));
        }
        {
            var v = new hvec2(new hvec4(((Half)(-5.5)), ((Half)(3.5)), ((Half)(2)), ((Half)(-1))));
            Assert.That(((Half)(-5.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.y));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new hvec2(Half.Zero, ((Half)(-1)));
        Assert.That(Half.Zero, Is.EqualTo(v[0]));
        Assert.That(((Half)(-1)), Is.EqualTo(v[1]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = Half.Zero; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = Half.Zero; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = Half.Zero; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = Half.Zero; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = Half.Zero; } );
        
        v[0] = Half.Zero;
        Assert.That(Half.Zero, Is.EqualTo(v[0]));
        v[1] = Half.One;
        Assert.That(Half.One, Is.EqualTo(v[1]));
        v[1] = ((Half)(2));
        Assert.That(((Half)(2)), Is.EqualTo(v[1]));
        v[1] = ((Half)(3));
        Assert.That(((Half)(3)), Is.EqualTo(v[1]));
        v[1] = ((Half)(4));
        Assert.That(((Half)(4)), Is.EqualTo(v[1]));
        v[0] = ((Half)(5));
        Assert.That(((Half)(5)), Is.EqualTo(v[0]));
        v[0] = ((Half)(6));
        Assert.That(((Half)(6)), Is.EqualTo(v[0]));
        v[1] = ((Half)(7));
        Assert.That(((Half)(7)), Is.EqualTo(v[1]));
        v[0] = ((Half)(8));
        Assert.That(((Half)(8)), Is.EqualTo(v[0]));
        v[1] = ((Half)(9));
        Assert.That(((Half)(9)), Is.EqualTo(v[1]));
        v[0] = ((Half)(-1));
        Assert.That(((Half)(-1)), Is.EqualTo(v[0]));
        v[1] = ((Half)(-2));
        Assert.That(((Half)(-2)), Is.EqualTo(v[1]));
        v[0] = ((Half)(-3));
        Assert.That(((Half)(-3)), Is.EqualTo(v[0]));
        v[0] = ((Half)(-4));
        Assert.That(((Half)(-4)), Is.EqualTo(v[0]));
        v[1] = ((Half)(-5));
        Assert.That(((Half)(-5)), Is.EqualTo(v[1]));
        v[1] = ((Half)(-6));
        Assert.That(((Half)(-6)), Is.EqualTo(v[1]));
        v[0] = ((Half)(-7));
        Assert.That(((Half)(-7)), Is.EqualTo(v[0]));
        v[0] = ((Half)(-8));
        Assert.That(((Half)(-8)), Is.EqualTo(v[0]));
        v[1] = ((Half)(-9));
        Assert.That(((Half)(-9)), Is.EqualTo(v[1]));
        v[1] = ((Half)(-9.5));
        Assert.That(((Half)(-9.5)), Is.EqualTo(v[1]));
        v[1] = ((Half)(-8.5));
        Assert.That(((Half)(-8.5)), Is.EqualTo(v[1]));
        v[0] = ((Half)(-7.5));
        Assert.That(((Half)(-7.5)), Is.EqualTo(v[0]));
        v[0] = ((Half)(-6.5));
        Assert.That(((Half)(-6.5)), Is.EqualTo(v[0]));
        v[1] = ((Half)(-5.5));
        Assert.That(((Half)(-5.5)), Is.EqualTo(v[1]));
        v[1] = ((Half)(-4.5));
        Assert.That(((Half)(-4.5)), Is.EqualTo(v[1]));
        v[1] = ((Half)(-3.5));
        Assert.That(((Half)(-3.5)), Is.EqualTo(v[1]));
        v[0] = ((Half)(-2.5));
        Assert.That(((Half)(-2.5)), Is.EqualTo(v[0]));
        v[1] = ((Half)(-1.5));
        Assert.That(((Half)(-1.5)), Is.EqualTo(v[1]));
        v[0] = ((Half)(-0.5));
        Assert.That(((Half)(-0.5)), Is.EqualTo(v[0]));
        v[1] = ((Half)(0.5));
        Assert.That(((Half)(0.5)), Is.EqualTo(v[1]));
        v[0] = ((Half)(1.5));
        Assert.That(((Half)(1.5)), Is.EqualTo(v[0]));
        v[0] = ((Half)(2.5));
        Assert.That(((Half)(2.5)), Is.EqualTo(v[0]));
        v[0] = ((Half)(3.5));
        Assert.That(((Half)(3.5)), Is.EqualTo(v[0]));
        v[1] = ((Half)(4.5));
        Assert.That(((Half)(4.5)), Is.EqualTo(v[1]));
        v[0] = ((Half)(5.5));
        Assert.That(((Half)(5.5)), Is.EqualTo(v[0]));
        v[0] = ((Half)(6.5));
        Assert.That(((Half)(6.5)), Is.EqualTo(v[0]));
        v[0] = ((Half)(7.5));
        Assert.That(((Half)(7.5)), Is.EqualTo(v[0]));
        v[1] = ((Half)(8.5));
        Assert.That(((Half)(8.5)), Is.EqualTo(v[1]));
        v[0] = ((Half)(9.5));
        Assert.That(((Half)(9.5)), Is.EqualTo(v[0]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new hvec2(((Half)(5)), ((Half)(-9.5)));
        var vals = v.Values;
        Assert.That(((Half)(5)), Is.EqualTo(vals[0]));
        Assert.That(((Half)(-9.5)), Is.EqualTo(vals[1]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(Half.Zero, Is.EqualTo(hvec2.Zero.x));
        Assert.That(Half.Zero, Is.EqualTo(hvec2.Zero.y));
        
        Assert.That(Half.One, Is.EqualTo(hvec2.Ones.x));
        Assert.That(Half.One, Is.EqualTo(hvec2.Ones.y));
        
        Assert.That(Half.One, Is.EqualTo(hvec2.UnitX.x));
        Assert.That(Half.Zero, Is.EqualTo(hvec2.UnitX.y));
        
        Assert.That(Half.Zero, Is.EqualTo(hvec2.UnitY.x));
        Assert.That(Half.One, Is.EqualTo(hvec2.UnitY.y));
        
        Assert.That(Half.MaxValue, Is.EqualTo(hvec2.MaxValue.x));
        Assert.That(Half.MaxValue, Is.EqualTo(hvec2.MaxValue.y));
        
        Assert.That(Half.MinValue, Is.EqualTo(hvec2.MinValue.x));
        Assert.That(Half.MinValue, Is.EqualTo(hvec2.MinValue.y));
        
        Assert.That(Half.Epsilon, Is.EqualTo(hvec2.Epsilon.x));
        Assert.That(Half.Epsilon, Is.EqualTo(hvec2.Epsilon.y));
        
        Assert.That(Half.NaN, Is.EqualTo(hvec2.NaN.x));
        Assert.That(Half.NaN, Is.EqualTo(hvec2.NaN.y));
        
        Assert.That(Half.NegativeInfinity, Is.EqualTo(hvec2.NegativeInfinity.x));
        Assert.That(Half.NegativeInfinity, Is.EqualTo(hvec2.NegativeInfinity.y));
        
        Assert.That(Half.PositiveInfinity, Is.EqualTo(hvec2.PositiveInfinity.x));
        Assert.That(Half.PositiveInfinity, Is.EqualTo(hvec2.PositiveInfinity.y));
    }

    [Test]
    public void Operators()
    {
        var v1 = new hvec2(((Half)(-1.5)), Half.Zero);
        var v2 = new hvec2(((Half)(-1.5)), Half.Zero);
        var v3 = new hvec2(Half.Zero, ((Half)(-1.5)));
        Assert.That(v1 == new hvec2(v1));
        Assert.That(v2 == new hvec2(v2));
        Assert.That(v3 == new hvec2(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new hvec2(((Half)(2.5)), ((Half)(-8)));
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = hvec2.Parse(s0);
        var v1 = hvec2.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = hvec2.TryParse(s0, out v0);
        var b1 = hvec2.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = hvec2.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = hvec2.TryParse("", out v0);
        Assert.That(!b0);
        b0 = hvec2.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { hvec2.Parse(null); });
        Assert.Throws<FormatException>(() => { hvec2.Parse(""); });
        Assert.Throws<FormatException>(() => { hvec2.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = hvec2.Parse(s3, "; ", NumberStyles.Number);
        var v4 = hvec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = hvec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new hvec2(((Half)(-8)), ((Half)(6.5)));
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<hvec2>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new hvec2(((Half)(9)), ((Half)(4)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec2(((Half)(-7.5)), ((Half)(-9.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec2(((Half)(-8.5)), ((Half)(6.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec2(((Half)(6)), ((Half)(-7)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec2(((Half)(-3.5)), ((Half)(9.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec2(((Half)(-0.5)), ((Half)(-8.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec2(((Half)(-8.5)), ((Half)(-6)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec2(((Half)(5)), ((Half)(9)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec2(((Half)(-3)), ((Half)(-1)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec2(((Half)(-9)), ((Half)(-8.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new hvec2(((Half)(2.5)), ((Half)(-7)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-1)), ((Half)(-6)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec2(((Half)(2.5)), Half.One);
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec2(((Half)(5)), ((Half)(4)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-5)), ((Half)(7.5)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-5.5)), Half.Zero);
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-4)), Half.One);
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-1)), ((Half)(-6)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-5.5)), ((Half)(-7)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-9.5)), ((Half)(9.5)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new hvec2(((Half)(-1)), ((Half)(0.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-9.5)), ((Half)(-3.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec2(((Half)(0.5)), ((Half)(7.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec2(((Half)(7.5)), ((Half)(-9)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-8)), ((Half)(-6.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-9)), ((Half)(-7.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-7.5)), ((Half)(-7.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec2(((Half)(8.5)), ((Half)(5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-7.5)), ((Half)(3)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-0.5)), ((Half)(-8)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new hvec2(((Half)(-8)), ((Half)(5.5)));
            var v1 = new hvec2(((Half)(2.5)), ((Half)(4.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-5)), ((Half)(-5.5)));
            var v1 = new hvec2(((Half)(-2.5)), ((Half)(-3.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec2(((Half)(7)), ((Half)(-4.5)));
            var v1 = new hvec2(((Half)(-5.5)), ((Half)(6.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-3.5)), ((Half)(-2.5)));
            var v1 = new hvec2(((Half)(4)), ((Half)(5.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-2)), ((Half)(0.5)));
            var v1 = new hvec2(((Half)(-4)), ((Half)(-6)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec2(((Half)(9.5)), ((Half)(3)));
            var v1 = new hvec2(((Half)(6.5)), ((Half)(-3.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-5)), ((Half)(-1)));
            var v1 = new hvec2(((Half)(-3.5)), ((Half)(5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-6.5)), ((Half)(-5.5)));
            var v1 = new hvec2(((Half)(-5)), ((Half)(-2)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec2(((Half)(-4)), ((Half)(-2)));
            var v1 = new hvec2(Half.Zero, ((Half)(4.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec2(Half.One, ((Half)(-9.5)));
            var v1 = new hvec2(((Half)(-3.5)), ((Half)(6.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new hvec2(((Half)(-6.5)), ((Half)(7)));
            var v1 = new hvec2(Half.One, ((Half)(-9)));
            var v2 = new hvec2(((Half)(9.5)), ((Half)(6.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(9)), ((Half)(-3)));
            var v1 = new hvec2(((Half)(8.5)), ((Half)(-7.5)));
            var v2 = new hvec2(((Half)(-6.5)), ((Half)(-3)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(-5)), ((Half)(-6)));
            var v1 = new hvec2(((Half)(5)), ((Half)(-4)));
            var v2 = new hvec2(((Half)(8)), ((Half)(-6.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec2(Half.One, ((Half)(5.5)));
            var v1 = new hvec2(((Half)(-2.5)), ((Half)(-7.5)));
            var v2 = new hvec2(((Half)(-3.5)), ((Half)(-1)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(2.5)), ((Half)(4.5)));
            var v1 = new hvec2(((Half)(5)), ((Half)(-5)));
            var v2 = new hvec2(((Half)(-0.5)), ((Half)(-1.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec2(Half.One, ((Half)(-2.5)));
            var v1 = new hvec2(((Half)(2.5)), ((Half)(3.5)));
            var v2 = new hvec2(((Half)(-5.5)), ((Half)(-4)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(-3)), ((Half)(8)));
            var v1 = new hvec2(((Half)(8.5)), ((Half)(5.5)));
            var v2 = new hvec2(((Half)(-1)), ((Half)(3)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(-3)), ((Half)(-5.5)));
            var v1 = new hvec2(((Half)(-8)), ((Half)(-6)));
            var v2 = new hvec2(((Half)(-7.5)), ((Half)(6.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(4)), ((Half)(7.5)));
            var v1 = new hvec2(((Half)(7.5)), ((Half)(-0.5)));
            var v2 = new hvec2(((Half)(-3)), ((Half)(-6.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(-2.5)), Half.Zero);
            var v1 = new hvec2(((Half)(-8.5)), ((Half)(1.5)));
            var v2 = new hvec2(((Half)(-3.5)), ((Half)(5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new hvec2(((Half)(-6)), ((Half)(-3.5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec2(((Half)(8.5)), ((Half)(9.5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec2(((Half)(-7.5)), ((Half)(4.5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec2(((Half)(-6.5)), ((Half)(8)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec2(((Half)(-7.5)), ((Half)(-9)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec2(((Half)(9)), ((Half)(4)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec2(((Half)(-5.5)), ((Half)(-7)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec2(Half.Zero, ((Half)(9)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec2(((Half)(-6)), ((Half)(4)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec2(((Half)(6.5)), ((Half)(-4.5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new hvec2(((Half)(-6.5)), ((Half)(-7.5)));
            var v1 = new hvec2(((Half)(7)), ((Half)(2)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec2(((Half)(-9)), ((Half)(8.5)));
            var v1 = new hvec2(((Half)(-5.5)), ((Half)(5.5)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec2(((Half)(-7.5)), ((Half)(2)));
            var v1 = new hvec2(((Half)(-8.5)), ((Half)(2)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec2(((Half)(9.5)), ((Half)(-7)));
            var v1 = new hvec2(((Half)(1.5)), ((Half)(7)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec2(((Half)(0.5)), ((Half)(-7)));
            var v1 = new hvec2(((Half)(2)), ((Half)(3)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec2(((Half)(-9.5)), ((Half)(-6.5)));
            var v1 = new hvec2(((Half)(-4.5)), ((Half)(-9.5)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec2(((Half)(-4)), ((Half)(8.5)));
            var v1 = new hvec2(((Half)(-4.5)), ((Half)(-6)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec2(((Half)(5.5)), ((Half)(5)));
            var v1 = new hvec2(((Half)(3)), ((Half)(-8.5)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec2(((Half)(-3.5)), ((Half)(-6)));
            var v1 = new hvec2(((Half)(-4.5)), ((Half)(7)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec2(((Half)(3.5)), ((Half)(3)));
            var v1 = new hvec2(((Half)(-9.5)), ((Half)(3)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new hvec2(((Half)(7)), ((Half)(7.5)));
            var v1 = new hvec2(((Half)(-5.5)), ((Half)(-8)));
            var v2 = new hvec2(((Half)(-4.5)), ((Half)(3)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(-4.5)), ((Half)(-3.5)));
            var v1 = new hvec2(((Half)(7.5)), ((Half)(8.5)));
            var v2 = new hvec2(((Half)(-6.5)), ((Half)(-2.5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(6)), ((Half)(-0.5)));
            var v1 = new hvec2(((Half)(5)), ((Half)(-2)));
            var v2 = new hvec2(((Half)(6)), ((Half)(5.5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(-6)), ((Half)(-2.5)));
            var v1 = new hvec2(((Half)(2.5)), ((Half)(4.5)));
            var v2 = new hvec2(((Half)(-4.5)), Half.One);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(-0.5)), ((Half)(-8.5)));
            var v1 = new hvec2(((Half)(-8)), ((Half)(2.5)));
            var v2 = new hvec2(((Half)(3.5)), Half.One);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(-1.5)), ((Half)(3)));
            var v1 = new hvec2(((Half)(-1.5)), ((Half)(5.5)));
            var v2 = new hvec2(((Half)(-3)), ((Half)(6)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(6.5)), ((Half)(1.5)));
            var v1 = new hvec2(((Half)(-2.5)), ((Half)(-3)));
            var v2 = new hvec2(((Half)(-2.5)), ((Half)(3)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(8.5)), ((Half)(5.5)));
            var v1 = new hvec2(((Half)(2.5)), ((Half)(-7)));
            var v2 = new hvec2(((Half)(-5)), ((Half)(3)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(-7)), ((Half)(-8)));
            var v1 = new hvec2(((Half)(9.5)), ((Half)(6.5)));
            var v2 = new hvec2(((Half)(8.5)), ((Half)(7)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec2(((Half)(5.5)), ((Half)(-3)));
            var v1 = new hvec2(((Half)(-2)), ((Half)(-7.5)));
            var v2 = new hvec2(((Half)(-1.5)), ((Half)(4)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new hvec2(((Half)(-1)), ((Half)(-2.5)));
            var v1 = new hvec2(((Half)(9)), ((Half)(-9)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec2(((Half)(-7.5)), ((Half)(8)));
            var v1 = new hvec2(((Half)(1.5)), ((Half)(0.5)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec2(((Half)(3.5)), ((Half)(-2)));
            var v1 = new hvec2(((Half)(-8)), ((Half)(2)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec2(((Half)(2)), ((Half)(0.5)));
            var v1 = new hvec2(((Half)(8.5)), ((Half)(-6)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec2(((Half)(5.5)), ((Half)(-8)));
            var v1 = new hvec2(((Half)(9.5)), ((Half)(-4.5)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec2(((Half)(7)), ((Half)(-2.5)));
            var v1 = new hvec2(((Half)(6)), ((Half)(-4.5)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec2(((Half)(5)), ((Half)(-0.5)));
            var v1 = new hvec2(((Half)(9.5)), ((Half)(-6)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec2(((Half)(4)), ((Half)(9.5)));
            var v1 = new hvec2(((Half)(2)), Half.Zero);
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec2(Half.One, Half.One);
            var v1 = new hvec2(((Half)(-6)), ((Half)(-4.5)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec2(((Half)(-2)), ((Half)(-3)));
            var v1 = new hvec2(((Half)(9)), ((Half)(0.5)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new hvec2(((Half)(-4.5)), ((Half)(4)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec2(((Half)(5)), ((Half)(5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec2(((Half)(9)), ((Half)(8.5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec2(((Half)(5)), ((Half)(-3.5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec2(((Half)(2.5)), ((Half)(9)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec2(((Half)(-4.5)), Half.Zero);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec2(((Half)(-0.5)), ((Half)(2)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec2(((Half)(2.5)), ((Half)(-7.5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec2(((Half)(-7.5)), ((Half)(-2)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec2(((Half)(-7.5)), ((Half)(6)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(900518638);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.Random(random, (sbyte)(-1), (sbyte)(3));
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
        var random = new Random(1249194486);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.RandomUniform(random, (sbyte)(0), (sbyte)(1));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(1910446922);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.Random(random, (sbyte)(-1), (sbyte)(2));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(644206728);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.RandomUniform(random, (sbyte)(0), (sbyte)(1));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(1278354604);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.Random(random, (sbyte)(2), (sbyte)(4));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(3).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(3).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomGaussian0()
    {
        var random = new Random(1812223768);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.RandomNormal(random, ((Half)(0.6091910389294806)), ((Half)(4.701820870256899)));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.6091910389294806).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.6091910389294806).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(4.701820870256899).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(4.701820870256899).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(629263089);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.RandomGaussian(random, ((Half)(-1.7422723582676949)), ((Half)(7.434462484640285)));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.7422723582676949).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.7422723582676949).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(7.434462484640285).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(7.434462484640285).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(1432715902);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.RandomNormal(random, ((Half)(0.886148370283725)), ((Half)(6.85180908853738)));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.886148370283725).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.886148370283725).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(6.85180908853738).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(6.85180908853738).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(356235254);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.RandomGaussian(random, ((Half)(-1.8934362418453379)), ((Half)(2.3973485279815963)));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.8934362418453379).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.8934362418453379).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.3973485279815963).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.3973485279815963).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(187349703);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.RandomNormal(random, ((Half)(1.5044989900218786)), ((Half)(8.246154658611005)));
            sum += (dvec2)v;
            sumSqr += glm.Pow2((dvec2)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.5044989900218786).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.5044989900218786).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(8.246154658611005).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(8.246154658611005).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(268208356);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.RandomNormal(random);
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
        var random = new Random(22674788);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.RandomNormal(random);
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
        var random = new Random(2128421422);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.RandomNormal(random);
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
        var random = new Random(1812159046);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.RandomNormal(random);
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
        var random = new Random(1049116896);
        var sum = new dvec2(0.0);
        var sumSqr = new dvec2(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec2.RandomNormal(random);
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
