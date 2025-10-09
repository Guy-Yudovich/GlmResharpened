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
public class HalfVec3Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new hvec3(((Half)(0.5)));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(0.5)), Is.EqualTo(v.z));
        }
        {
            var v = new hvec3(((Half)(1.5)), Half.Zero, ((Half)(2)));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(((Half)(2)), Is.EqualTo(v.z));
        }
        {
            var v = new hvec3(new hvec2(((Half)(-8)), Half.Zero));
            Assert.That(((Half)(-8)), Is.EqualTo(v.x));
            Assert.That(Half.Zero, Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
        }
        {
            var v = new hvec3(new hvec3(((Half)(-2)), ((Half)(2.5)), ((Half)(8.5))));
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(8.5)), Is.EqualTo(v.z));
        }
        {
            var v = new hvec3(new hvec4(((Half)(1.5)), ((Half)(-7)), ((Half)(2.5)), ((Half)(-7))));
            Assert.That(((Half)(1.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(2.5)), Is.EqualTo(v.z));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new hvec3(((Half)(1.5)), Half.One, ((Half)(-0.5)));
        Assert.That(((Half)(1.5)), Is.EqualTo(v[0]));
        Assert.That(Half.One, Is.EqualTo(v[1]));
        Assert.That(((Half)(-0.5)), Is.EqualTo(v[2]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = Half.Zero; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = Half.Zero; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = Half.Zero; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = Half.Zero; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = Half.Zero; } );
        
        v[1] = Half.Zero;
        Assert.That(Half.Zero, Is.EqualTo(v[1]));
        v[2] = Half.One;
        Assert.That(Half.One, Is.EqualTo(v[2]));
        v[0] = ((Half)(2));
        Assert.That(((Half)(2)), Is.EqualTo(v[0]));
        v[1] = ((Half)(3));
        Assert.That(((Half)(3)), Is.EqualTo(v[1]));
        v[1] = ((Half)(4));
        Assert.That(((Half)(4)), Is.EqualTo(v[1]));
        v[0] = ((Half)(5));
        Assert.That(((Half)(5)), Is.EqualTo(v[0]));
        v[1] = ((Half)(6));
        Assert.That(((Half)(6)), Is.EqualTo(v[1]));
        v[2] = ((Half)(7));
        Assert.That(((Half)(7)), Is.EqualTo(v[2]));
        v[0] = ((Half)(8));
        Assert.That(((Half)(8)), Is.EqualTo(v[0]));
        v[2] = ((Half)(9));
        Assert.That(((Half)(9)), Is.EqualTo(v[2]));
        v[1] = ((Half)(-1));
        Assert.That(((Half)(-1)), Is.EqualTo(v[1]));
        v[0] = ((Half)(-2));
        Assert.That(((Half)(-2)), Is.EqualTo(v[0]));
        v[0] = ((Half)(-3));
        Assert.That(((Half)(-3)), Is.EqualTo(v[0]));
        v[2] = ((Half)(-4));
        Assert.That(((Half)(-4)), Is.EqualTo(v[2]));
        v[1] = ((Half)(-5));
        Assert.That(((Half)(-5)), Is.EqualTo(v[1]));
        v[1] = ((Half)(-6));
        Assert.That(((Half)(-6)), Is.EqualTo(v[1]));
        v[0] = ((Half)(-7));
        Assert.That(((Half)(-7)), Is.EqualTo(v[0]));
        v[2] = ((Half)(-8));
        Assert.That(((Half)(-8)), Is.EqualTo(v[2]));
        v[2] = ((Half)(-9));
        Assert.That(((Half)(-9)), Is.EqualTo(v[2]));
        v[2] = ((Half)(-9.5));
        Assert.That(((Half)(-9.5)), Is.EqualTo(v[2]));
        v[2] = ((Half)(-8.5));
        Assert.That(((Half)(-8.5)), Is.EqualTo(v[2]));
        v[2] = ((Half)(-7.5));
        Assert.That(((Half)(-7.5)), Is.EqualTo(v[2]));
        v[2] = ((Half)(-6.5));
        Assert.That(((Half)(-6.5)), Is.EqualTo(v[2]));
        v[2] = ((Half)(-5.5));
        Assert.That(((Half)(-5.5)), Is.EqualTo(v[2]));
        v[1] = ((Half)(-4.5));
        Assert.That(((Half)(-4.5)), Is.EqualTo(v[1]));
        v[1] = ((Half)(-3.5));
        Assert.That(((Half)(-3.5)), Is.EqualTo(v[1]));
        v[1] = ((Half)(-2.5));
        Assert.That(((Half)(-2.5)), Is.EqualTo(v[1]));
        v[2] = ((Half)(-1.5));
        Assert.That(((Half)(-1.5)), Is.EqualTo(v[2]));
        v[1] = ((Half)(-0.5));
        Assert.That(((Half)(-0.5)), Is.EqualTo(v[1]));
        v[2] = ((Half)(0.5));
        Assert.That(((Half)(0.5)), Is.EqualTo(v[2]));
        v[0] = ((Half)(1.5));
        Assert.That(((Half)(1.5)), Is.EqualTo(v[0]));
        v[0] = ((Half)(2.5));
        Assert.That(((Half)(2.5)), Is.EqualTo(v[0]));
        v[2] = ((Half)(3.5));
        Assert.That(((Half)(3.5)), Is.EqualTo(v[2]));
        v[0] = ((Half)(4.5));
        Assert.That(((Half)(4.5)), Is.EqualTo(v[0]));
        v[1] = ((Half)(5.5));
        Assert.That(((Half)(5.5)), Is.EqualTo(v[1]));
        v[2] = ((Half)(6.5));
        Assert.That(((Half)(6.5)), Is.EqualTo(v[2]));
        v[0] = ((Half)(7.5));
        Assert.That(((Half)(7.5)), Is.EqualTo(v[0]));
        v[1] = ((Half)(8.5));
        Assert.That(((Half)(8.5)), Is.EqualTo(v[1]));
        v[1] = ((Half)(9.5));
        Assert.That(((Half)(9.5)), Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new hvec3(((Half)(6.5)), Half.Zero, ((Half)(-4)));
        var vals = v.Values;
        Assert.That(((Half)(6.5)), Is.EqualTo(vals[0]));
        Assert.That(Half.Zero, Is.EqualTo(vals[1]));
        Assert.That(((Half)(-4)), Is.EqualTo(vals[2]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(Half.Zero, Is.EqualTo(hvec3.Zero.x));
        Assert.That(Half.Zero, Is.EqualTo(hvec3.Zero.y));
        Assert.That(Half.Zero, Is.EqualTo(hvec3.Zero.z));
        
        Assert.That(Half.One, Is.EqualTo(hvec3.Ones.x));
        Assert.That(Half.One, Is.EqualTo(hvec3.Ones.y));
        Assert.That(Half.One, Is.EqualTo(hvec3.Ones.z));
        
        Assert.That(Half.One, Is.EqualTo(hvec3.UnitX.x));
        Assert.That(Half.Zero, Is.EqualTo(hvec3.UnitX.y));
        Assert.That(Half.Zero, Is.EqualTo(hvec3.UnitX.z));
        
        Assert.That(Half.Zero, Is.EqualTo(hvec3.UnitY.x));
        Assert.That(Half.One, Is.EqualTo(hvec3.UnitY.y));
        Assert.That(Half.Zero, Is.EqualTo(hvec3.UnitY.z));
        
        Assert.That(Half.Zero, Is.EqualTo(hvec3.UnitZ.x));
        Assert.That(Half.Zero, Is.EqualTo(hvec3.UnitZ.y));
        Assert.That(Half.One, Is.EqualTo(hvec3.UnitZ.z));
        
        Assert.That(Half.MaxValue, Is.EqualTo(hvec3.MaxValue.x));
        Assert.That(Half.MaxValue, Is.EqualTo(hvec3.MaxValue.y));
        Assert.That(Half.MaxValue, Is.EqualTo(hvec3.MaxValue.z));
        
        Assert.That(Half.MinValue, Is.EqualTo(hvec3.MinValue.x));
        Assert.That(Half.MinValue, Is.EqualTo(hvec3.MinValue.y));
        Assert.That(Half.MinValue, Is.EqualTo(hvec3.MinValue.z));
        
        Assert.That(Half.Epsilon, Is.EqualTo(hvec3.Epsilon.x));
        Assert.That(Half.Epsilon, Is.EqualTo(hvec3.Epsilon.y));
        Assert.That(Half.Epsilon, Is.EqualTo(hvec3.Epsilon.z));
        
        Assert.That(Half.NaN, Is.EqualTo(hvec3.NaN.x));
        Assert.That(Half.NaN, Is.EqualTo(hvec3.NaN.y));
        Assert.That(Half.NaN, Is.EqualTo(hvec3.NaN.z));
        
        Assert.That(Half.NegativeInfinity, Is.EqualTo(hvec3.NegativeInfinity.x));
        Assert.That(Half.NegativeInfinity, Is.EqualTo(hvec3.NegativeInfinity.y));
        Assert.That(Half.NegativeInfinity, Is.EqualTo(hvec3.NegativeInfinity.z));
        
        Assert.That(Half.PositiveInfinity, Is.EqualTo(hvec3.PositiveInfinity.x));
        Assert.That(Half.PositiveInfinity, Is.EqualTo(hvec3.PositiveInfinity.y));
        Assert.That(Half.PositiveInfinity, Is.EqualTo(hvec3.PositiveInfinity.z));
    }

    [Test]
    public void Operators()
    {
        var v1 = new hvec3(((Half)(-3.5)), ((Half)(-1.5)), ((Half)(5)));
        var v2 = new hvec3(((Half)(-3.5)), ((Half)(-1.5)), ((Half)(5)));
        var v3 = new hvec3(((Half)(5)), ((Half)(-1.5)), ((Half)(-3.5)));
        Assert.That(v1 == new hvec3(v1));
        Assert.That(v2 == new hvec3(v2));
        Assert.That(v3 == new hvec3(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new hvec3(((Half)(-3.5)), ((Half)(-8)), ((Half)(-7.5)));
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = hvec3.Parse(s0);
        var v1 = hvec3.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = hvec3.TryParse(s0, out v0);
        var b1 = hvec3.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = hvec3.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = hvec3.TryParse("", out v0);
        Assert.That(!b0);
        b0 = hvec3.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { hvec3.Parse(null); });
        Assert.Throws<FormatException>(() => { hvec3.Parse(""); });
        Assert.Throws<FormatException>(() => { hvec3.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = hvec3.Parse(s3, "; ", NumberStyles.Number);
        var v4 = hvec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = hvec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new hvec3(((Half)(-9)), ((Half)(-0.5)), ((Half)(-6.5)));
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<hvec3>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new hvec3(((Half)(-9)), ((Half)(-1)), ((Half)(4.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec3(((Half)(-2)), ((Half)(9)), ((Half)(-5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec3(((Half)(4.5)), ((Half)(7.5)), ((Half)(6)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec3(((Half)(-9.5)), ((Half)(7)), ((Half)(1.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec3(((Half)(8.5)), ((Half)(6)), ((Half)(1.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec3(((Half)(6.5)), ((Half)(-2)), ((Half)(2.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec3(((Half)(7)), ((Half)(5.5)), ((Half)(-1.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec3(((Half)(1.5)), ((Half)(-4)), ((Half)(5.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec3(((Half)(7)), ((Half)(2.5)), ((Half)(5.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec3(((Half)(-8.5)), ((Half)(-1.5)), ((Half)(-8)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new hvec3(((Half)(9)), ((Half)(-3.5)), ((Half)(8)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec3(((Half)(4)), ((Half)(4.5)), ((Half)(-7)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec3(((Half)(-8.5)), ((Half)(7)), ((Half)(-2.5)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec3(((Half)(3)), ((Half)(7.5)), ((Half)(9)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec3(((Half)(-3)), ((Half)(2.5)), ((Half)(1.5)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec3(((Half)(-6)), ((Half)(-7.5)), ((Half)(-2)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec3(((Half)(5)), ((Half)(-6)), ((Half)(8)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec3(((Half)(9.5)), ((Half)(-0.5)), ((Half)(4.5)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec3(((Half)(7.5)), ((Half)(-3)), ((Half)(-7)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec3(((Half)(8)), ((Half)(-4)), ((Half)(-0.5)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new hvec3(((Half)(3)), ((Half)(-9.5)), ((Half)(-4.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec3(((Half)(1.5)), ((Half)(-8.5)), ((Half)(-4)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec3(((Half)(3)), Half.Zero, ((Half)(-1)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec3(((Half)(-1)), ((Half)(-2)), ((Half)(2)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec3(((Half)(-3)), ((Half)(5)), ((Half)(-6)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec3(((Half)(-6)), ((Half)(-9)), ((Half)(-1)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec3(((Half)(-2.5)), ((Half)(1.5)), ((Half)(-9.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec3(((Half)(8.5)), ((Half)(-3.5)), ((Half)(3.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec3(((Half)(-2)), ((Half)(9)), ((Half)(9)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec3(((Half)(5)), ((Half)(-7)), ((Half)(-2.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new hvec3(((Half)(-1)), ((Half)(-1)), ((Half)(-3.5)));
            var v1 = new hvec3(((Half)(3.5)), ((Half)(9)), ((Half)(-4.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec3(((Half)(6)), ((Half)(-8)), ((Half)(4)));
            var v1 = new hvec3(((Half)(7.5)), ((Half)(1.5)), ((Half)(-4.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec3(((Half)(9.5)), ((Half)(-5)), ((Half)(3)));
            var v1 = new hvec3(((Half)(-5)), ((Half)(-3)), ((Half)(9.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec3(((Half)(7)), ((Half)(-9.5)), ((Half)(-7.5)));
            var v1 = new hvec3(((Half)(8)), ((Half)(9.5)), ((Half)(-8.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec3(((Half)(-3)), ((Half)(3.5)), ((Half)(-0.5)));
            var v1 = new hvec3(((Half)(-4)), ((Half)(-1)), ((Half)(-4.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec3(((Half)(-7.5)), ((Half)(-6.5)), Half.One);
            var v1 = new hvec3(((Half)(-5.5)), ((Half)(-1.5)), ((Half)(-6.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec3(((Half)(-6.5)), ((Half)(-2.5)), ((Half)(-2)));
            var v1 = new hvec3(((Half)(-1)), ((Half)(-3)), ((Half)(-2)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec3(((Half)(-7.5)), ((Half)(-9)), ((Half)(5.5)));
            var v1 = new hvec3(((Half)(-1.5)), ((Half)(-3.5)), ((Half)(3)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec3(((Half)(-5)), ((Half)(-8.5)), ((Half)(8.5)));
            var v1 = new hvec3(((Half)(3)), ((Half)(8.5)), ((Half)(-1.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec3(((Half)(8.5)), ((Half)(2)), ((Half)(-1)));
            var v1 = new hvec3(((Half)(5)), ((Half)(-8.5)), ((Half)(-7)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new hvec3(((Half)(0.5)), ((Half)(-3.5)), ((Half)(-2.5)));
            var v1 = new hvec3(((Half)(-0.5)), ((Half)(1.5)), ((Half)(3)));
            var v2 = new hvec3(((Half)(4.5)), ((Half)(8.5)), ((Half)(4)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(8)), ((Half)(7)), ((Half)(-7)));
            var v1 = new hvec3(((Half)(-8)), ((Half)(0.5)), ((Half)(-7)));
            var v2 = new hvec3(((Half)(1.5)), ((Half)(-7)), ((Half)(-7.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(-8.5)), ((Half)(7)), ((Half)(-4)));
            var v1 = new hvec3(((Half)(5)), ((Half)(-2)), ((Half)(3.5)));
            var v2 = new hvec3(Half.Zero, ((Half)(-9.5)), ((Half)(-0.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(-4.5)), ((Half)(-2.5)), ((Half)(7.5)));
            var v1 = new hvec3(((Half)(-9.5)), ((Half)(-7.5)), ((Half)(4.5)));
            var v2 = new hvec3(((Half)(8.5)), ((Half)(6)), Half.Zero);
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(-5.5)), ((Half)(6)), ((Half)(-8)));
            var v1 = new hvec3(((Half)(-4)), ((Half)(7)), ((Half)(-5)));
            var v2 = new hvec3(((Half)(8)), ((Half)(-1.5)), ((Half)(-9.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(5.5)), ((Half)(6.5)), ((Half)(8)));
            var v1 = new hvec3(((Half)(6)), ((Half)(-2.5)), ((Half)(-9)));
            var v2 = new hvec3(((Half)(3.5)), ((Half)(4.5)), ((Half)(-5.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(-5.5)), ((Half)(-4.5)), ((Half)(-4)));
            var v1 = new hvec3(((Half)(3.5)), ((Half)(-0.5)), ((Half)(-1)));
            var v2 = new hvec3(((Half)(-5)), ((Half)(8)), ((Half)(-1)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(6)), ((Half)(-0.5)), ((Half)(-4.5)));
            var v1 = new hvec3(((Half)(-7.5)), ((Half)(-9)), ((Half)(-6.5)));
            var v2 = new hvec3(((Half)(-6)), ((Half)(6)), ((Half)(9)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(3)), ((Half)(7)), ((Half)(9.5)));
            var v1 = new hvec3(((Half)(9.5)), ((Half)(6.5)), ((Half)(-5.5)));
            var v2 = new hvec3(((Half)(-4)), ((Half)(5)), ((Half)(-5.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(-8.5)), ((Half)(-9)), ((Half)(9.5)));
            var v1 = new hvec3(((Half)(-9)), ((Half)(-2.5)), ((Half)(-1.5)));
            var v2 = new hvec3(((Half)(-1)), ((Half)(-5)), ((Half)(-7.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new hvec3(((Half)(8.5)), ((Half)(8)), ((Half)(-7)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec3(((Half)(0.5)), Half.One, ((Half)(7)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec3(((Half)(6.5)), ((Half)(8.5)), ((Half)(-9)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec3(((Half)(3)), ((Half)(9.5)), ((Half)(-0.5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec3(((Half)(-6)), ((Half)(6)), ((Half)(-8)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec3(((Half)(8.5)), ((Half)(-8)), ((Half)(-8.5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec3(((Half)(8.5)), ((Half)(2.5)), ((Half)(7)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec3(((Half)(-3.5)), ((Half)(-0.5)), ((Half)(2.5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec3(((Half)(4)), ((Half)(-3)), ((Half)(4.5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec3(((Half)(9.5)), ((Half)(-7.5)), ((Half)(-8)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new hvec3(((Half)(-5)), ((Half)(9)), ((Half)(-2.5)));
            var v1 = new hvec3(((Half)(7)), ((Half)(2.5)), ((Half)(-2.5)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec3(((Half)(-0.5)), Half.Zero, ((Half)(0.5)));
            var v1 = new hvec3(((Half)(-5)), ((Half)(3.5)), ((Half)(-6)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec3(((Half)(5)), ((Half)(7.5)), ((Half)(-7.5)));
            var v1 = new hvec3(((Half)(9.5)), Half.Zero, ((Half)(-8.5)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec3(((Half)(8.5)), ((Half)(-3.5)), ((Half)(-4.5)));
            var v1 = new hvec3(((Half)(-8)), ((Half)(-6)), ((Half)(8.5)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec3(((Half)(-7.5)), ((Half)(6.5)), ((Half)(-1)));
            var v1 = new hvec3(((Half)(0.5)), ((Half)(5)), ((Half)(7.5)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec3(((Half)(-4.5)), ((Half)(1.5)), ((Half)(-9.5)));
            var v1 = new hvec3(((Half)(0.5)), ((Half)(-9.5)), ((Half)(4)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec3(((Half)(-1.5)), ((Half)(9)), ((Half)(2.5)));
            var v1 = new hvec3(((Half)(-6)), ((Half)(-6)), ((Half)(-8)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec3(((Half)(4)), ((Half)(-6.5)), ((Half)(-2)));
            var v1 = new hvec3(((Half)(6.5)), ((Half)(-8.5)), ((Half)(4)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec3(((Half)(-4.5)), ((Half)(-8.5)), ((Half)(-2)));
            var v1 = new hvec3(((Half)(-3)), ((Half)(5.5)), ((Half)(-3.5)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec3(((Half)(-1.5)), ((Half)(7.5)), ((Half)(3.5)));
            var v1 = new hvec3(((Half)(-1.5)), ((Half)(-4.5)), ((Half)(6.5)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new hvec3(Half.One, ((Half)(-8.5)), ((Half)(5.5)));
            var v1 = new hvec3(((Half)(2.5)), ((Half)(-9.5)), ((Half)(-4)));
            var v2 = new hvec3(((Half)(3)), ((Half)(-9)), ((Half)(-9)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(-2.5)), ((Half)(3.5)), ((Half)(9.5)));
            var v1 = new hvec3(((Half)(-6)), ((Half)(-1.5)), ((Half)(3)));
            var v2 = new hvec3(((Half)(9)), ((Half)(-2)), ((Half)(6.5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(-3)), ((Half)(-1)), ((Half)(2.5)));
            var v1 = new hvec3(((Half)(9.5)), ((Half)(7)), Half.Zero);
            var v2 = new hvec3(((Half)(2)), ((Half)(3.5)), ((Half)(0.5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(-8)), ((Half)(-2)), ((Half)(-2)));
            var v1 = new hvec3(((Half)(3)), ((Half)(8.5)), Half.Zero);
            var v2 = new hvec3(((Half)(6.5)), ((Half)(2.5)), ((Half)(-3.5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(6)), ((Half)(-3)), ((Half)(2)));
            var v1 = new hvec3(((Half)(5.5)), ((Half)(5)), ((Half)(-3)));
            var v2 = new hvec3(((Half)(-0.5)), ((Half)(-2.5)), Half.One);
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec3(Half.Zero, Half.Zero, ((Half)(-5.5)));
            var v1 = new hvec3(((Half)(9)), ((Half)(3.5)), ((Half)(-7)));
            var v2 = new hvec3(((Half)(-2.5)), ((Half)(1.5)), ((Half)(-9.5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec3(Half.Zero, Half.One, ((Half)(-3)));
            var v1 = new hvec3(((Half)(4.5)), ((Half)(-0.5)), ((Half)(-2.5)));
            var v2 = new hvec3(((Half)(-5.5)), ((Half)(-3.5)), ((Half)(6)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(7)), ((Half)(-6.5)), ((Half)(5.5)));
            var v1 = new hvec3(((Half)(9.5)), ((Half)(-9.5)), ((Half)(5.5)));
            var v2 = new hvec3(((Half)(-7)), ((Half)(2)), ((Half)(8.5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(3.5)), ((Half)(-7)), ((Half)(4)));
            var v1 = new hvec3(((Half)(-9)), ((Half)(9)), ((Half)(-9.5)));
            var v2 = new hvec3(((Half)(9.5)), ((Half)(2)), ((Half)(3.5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec3(((Half)(5)), ((Half)(8)), ((Half)(-9)));
            var v1 = new hvec3(((Half)(4.5)), ((Half)(-7)), ((Half)(6)));
            var v2 = new hvec3(((Half)(-9.5)), ((Half)(5.5)), ((Half)(0.5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new hvec3(((Half)(-6)), ((Half)(1.5)), ((Half)(-1.5)));
            var v1 = new hvec3(Half.Zero, ((Half)(5)), ((Half)(-3.5)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec3(((Half)(3)), ((Half)(-4.5)), ((Half)(9)));
            var v1 = new hvec3(((Half)(-7)), Half.Zero, ((Half)(-6)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec3(((Half)(1.5)), ((Half)(-0.5)), ((Half)(-5)));
            var v1 = new hvec3(((Half)(7)), ((Half)(-2.5)), ((Half)(7.5)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec3(((Half)(9)), ((Half)(-8)), ((Half)(-7.5)));
            var v1 = new hvec3(((Half)(5)), ((Half)(-0.5)), ((Half)(-9)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec3(((Half)(-3.5)), ((Half)(-7.5)), ((Half)(9)));
            var v1 = new hvec3(((Half)(-2)), ((Half)(-3.5)), ((Half)(-2)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec3(((Half)(-8)), ((Half)(-3.5)), ((Half)(-4.5)));
            var v1 = new hvec3(((Half)(0.5)), Half.Zero, ((Half)(6)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec3(((Half)(1.5)), ((Half)(0.5)), ((Half)(-2.5)));
            var v1 = new hvec3(((Half)(6)), ((Half)(9)), ((Half)(7.5)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec3(((Half)(9.5)), ((Half)(3.5)), ((Half)(-3)));
            var v1 = new hvec3(((Half)(-5.5)), ((Half)(2)), ((Half)(4)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec3(((Half)(5.5)), Half.Zero, ((Half)(5.5)));
            var v1 = new hvec3(((Half)(0.5)), ((Half)(-1)), ((Half)(2)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec3(((Half)(6.5)), ((Half)(9)), Half.One);
            var v1 = new hvec3(((Half)(9)), ((Half)(-5)), ((Half)(-6.5)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new hvec3(((Half)(-8.5)), ((Half)(6)), ((Half)(6.5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec3(((Half)(-8)), ((Half)(7.5)), ((Half)(-2.5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec3(((Half)(3)), ((Half)(-6)), ((Half)(-5.5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec3(((Half)(-9)), ((Half)(-7)), ((Half)(1.5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec3(((Half)(-5)), ((Half)(-7)), ((Half)(-1.5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec3(((Half)(-8)), ((Half)(-7)), ((Half)(8)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec3(((Half)(6.5)), ((Half)(9)), Half.One);
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec3(((Half)(-3.5)), ((Half)(-1.5)), ((Half)(-2)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec3(((Half)(-3.5)), ((Half)(-2.5)), ((Half)(-8.5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec3(Half.Zero, ((Half)(-9)), ((Half)(2.5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void InvariantCrossDot()
    {
        {
            var v0 = new hvec3(((Half)(0.5)), ((Half)(7)), ((Half)(4.5)));
            var v1 = new hvec3(Half.One, ((Half)(-7.5)), ((Half)(0.5)));
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new hvec3(((Half)(-7.5)), ((Half)(-1)), ((Half)(-5.5)));
            var v1 = new hvec3(((Half)(9)), ((Half)(7.5)), ((Half)(-4.5)));
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new hvec3(((Half)(-1)), ((Half)(9)), ((Half)(-8.5)));
            var v1 = new hvec3(((Half)(-8)), ((Half)(3)), ((Half)(2.5)));
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new hvec3(((Half)(-2)), ((Half)(-7.5)), Half.Zero);
            var v1 = new hvec3(((Half)(5)), ((Half)(8)), ((Half)(-2)));
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new hvec3(((Half)(4.5)), ((Half)(6.5)), ((Half)(3.5)));
            var v1 = new hvec3(((Half)(3)), ((Half)(-7.5)), ((Half)(4.5)));
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new hvec3(((Half)(-2.5)), ((Half)(-1.5)), ((Half)(-3.5)));
            var v1 = new hvec3(Half.One, ((Half)(-9)), ((Half)(-8)));
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new hvec3(((Half)(5)), ((Half)(-9.5)), ((Half)(8.5)));
            var v1 = new hvec3(((Half)(-6.5)), ((Half)(8)), Half.Zero);
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new hvec3(((Half)(2)), ((Half)(9)), ((Half)(8)));
            var v1 = new hvec3(((Half)(5.5)), Half.One, ((Half)(2)));
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new hvec3(((Half)(-0.5)), ((Half)(3.5)), ((Half)(2.5)));
            var v1 = new hvec3(((Half)(-7.5)), ((Half)(-6.5)), ((Half)(-2)));
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
        {
            var v0 = new hvec3(((Half)(-2.5)), ((Half)(-4.5)), ((Half)(8.5)));
            var v1 = new hvec3(((Half)(-7.5)), ((Half)(7)), ((Half)(-3.5)));
            Assert.That(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), Is.LessThan(0.1));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(1805426092);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.Random(random, (sbyte)(4), (sbyte)(6));
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
    public void RandomUniform1()
    {
        var random = new Random(1343736132);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.RandomUniform(random, (sbyte)(2), (sbyte)(5));
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
        var random = new Random(944307496);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.Random(random, (sbyte)(0), (sbyte)(3));
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
    public void RandomUniform3()
    {
        var random = new Random(1880910673);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.RandomUniform(random, (sbyte)(4), (sbyte)(5));
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
    public void RandomUniform4()
    {
        var random = new Random(1226268868);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.Random(random, (sbyte)(3), (sbyte)(5));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(4).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(4).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomGaussian0()
    {
        var random = new Random(1668771899);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.RandomNormal(random, ((Half)(0.673182518534913)), ((Half)(1.8087799203622992)));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.673182518534913).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.673182518534913).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.673182518534913).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.8087799203622992).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.8087799203622992).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.8087799203622992).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(174874571);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.RandomGaussian(random, ((Half)(0.811686010477918)), ((Half)(7.65231319593839)));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.811686010477918).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.811686010477918).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.811686010477918).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(7.65231319593839).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(7.65231319593839).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(7.65231319593839).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(29768503);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.RandomNormal(random, ((Half)(0.932673537606687)), ((Half)(5.254796377967482)));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.932673537606687).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.932673537606687).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.932673537606687).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(5.254796377967482).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(5.254796377967482).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(5.254796377967482).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(2083207518);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.RandomGaussian(random, ((Half)(-1.9985523167990857)), ((Half)(9.473600527026505)));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.9985523167990857).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.9985523167990857).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-1.9985523167990857).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(9.473600527026505).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(9.473600527026505).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(9.473600527026505).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(724948920);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.RandomNormal(random, ((Half)(1.4535186139184604)), ((Half)(7.410011867717845)));
            sum += (dvec3)v;
            sumSqr += glm.Pow2((dvec3)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.4535186139184604).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.4535186139184604).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.4535186139184604).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(7.410011867717845).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(7.410011867717845).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(7.410011867717845).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(1891315377);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.RandomNormal(random);
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
        var random = new Random(889892316);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.RandomNormal(random);
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
        var random = new Random(1080774435);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.RandomNormal(random);
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
        var random = new Random(147629844);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.RandomNormal(random);
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
        var random = new Random(1317986667);
        var sum = new dvec3(0.0);
        var sumSqr = new dvec3(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec3.RandomNormal(random);
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
