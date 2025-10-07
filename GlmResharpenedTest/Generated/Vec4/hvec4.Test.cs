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
public class HalfVec4Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new hvec4(((Half)(-7)));
            Assert.That(((Half)(-7)), Is.EqualTo(v.x));
            Assert.That(((Half)(-7)), Is.EqualTo(v.y));
            Assert.That(((Half)(-7)), Is.EqualTo(v.z));
            Assert.That(((Half)(-7)), Is.EqualTo(v.w));
        }
        {
            var v = new hvec4(((Half)(-2)), ((Half)(-0.5)), ((Half)(-4.5)), ((Half)(9.5)));
            Assert.That(((Half)(-2)), Is.EqualTo(v.x));
            Assert.That(((Half)(-0.5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-4.5)), Is.EqualTo(v.z));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.w));
        }
        {
            var v = new hvec4(new hvec2(((Half)(9.5)), ((Half)(2))));
            Assert.That(((Half)(9.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(2)), Is.EqualTo(v.y));
            Assert.That(Half.Zero, Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var v = new hvec4(new hvec3(((Half)(3.5)), ((Half)(5)), ((Half)(-6.5))));
            Assert.That(((Half)(3.5)), Is.EqualTo(v.x));
            Assert.That(((Half)(5)), Is.EqualTo(v.y));
            Assert.That(((Half)(-6.5)), Is.EqualTo(v.z));
            Assert.That(Half.Zero, Is.EqualTo(v.w));
        }
        {
            var v = new hvec4(new hvec4(((Half)(-1)), Half.One, ((Half)(8)), ((Half)(7.5))));
            Assert.That(((Half)(-1)), Is.EqualTo(v.x));
            Assert.That(Half.One, Is.EqualTo(v.y));
            Assert.That(((Half)(8)), Is.EqualTo(v.z));
            Assert.That(((Half)(7.5)), Is.EqualTo(v.w));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new hvec4(((Half)(4.5)), Half.One, ((Half)(7)), ((Half)(8)));
        Assert.That(((Half)(4.5)), Is.EqualTo(v[0]));
        Assert.That(Half.One, Is.EqualTo(v[1]));
        Assert.That(((Half)(7)), Is.EqualTo(v[2]));
        Assert.That(((Half)(8)), Is.EqualTo(v[3]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = Half.Zero; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = Half.Zero; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = Half.Zero; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = Half.Zero; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = Half.Zero; } );
        
        v[3] = Half.Zero;
        Assert.That(Half.Zero, Is.EqualTo(v[3]));
        v[0] = Half.One;
        Assert.That(Half.One, Is.EqualTo(v[0]));
        v[1] = ((Half)(2));
        Assert.That(((Half)(2)), Is.EqualTo(v[1]));
        v[2] = ((Half)(3));
        Assert.That(((Half)(3)), Is.EqualTo(v[2]));
        v[3] = ((Half)(4));
        Assert.That(((Half)(4)), Is.EqualTo(v[3]));
        v[3] = ((Half)(5));
        Assert.That(((Half)(5)), Is.EqualTo(v[3]));
        v[1] = ((Half)(6));
        Assert.That(((Half)(6)), Is.EqualTo(v[1]));
        v[0] = ((Half)(7));
        Assert.That(((Half)(7)), Is.EqualTo(v[0]));
        v[0] = ((Half)(8));
        Assert.That(((Half)(8)), Is.EqualTo(v[0]));
        v[0] = ((Half)(9));
        Assert.That(((Half)(9)), Is.EqualTo(v[0]));
        v[3] = ((Half)(-1));
        Assert.That(((Half)(-1)), Is.EqualTo(v[3]));
        v[1] = ((Half)(-2));
        Assert.That(((Half)(-2)), Is.EqualTo(v[1]));
        v[1] = ((Half)(-3));
        Assert.That(((Half)(-3)), Is.EqualTo(v[1]));
        v[2] = ((Half)(-4));
        Assert.That(((Half)(-4)), Is.EqualTo(v[2]));
        v[2] = ((Half)(-5));
        Assert.That(((Half)(-5)), Is.EqualTo(v[2]));
        v[2] = ((Half)(-6));
        Assert.That(((Half)(-6)), Is.EqualTo(v[2]));
        v[1] = ((Half)(-7));
        Assert.That(((Half)(-7)), Is.EqualTo(v[1]));
        v[0] = ((Half)(-8));
        Assert.That(((Half)(-8)), Is.EqualTo(v[0]));
        v[2] = ((Half)(-9));
        Assert.That(((Half)(-9)), Is.EqualTo(v[2]));
        v[3] = ((Half)(-9.5));
        Assert.That(((Half)(-9.5)), Is.EqualTo(v[3]));
        v[0] = ((Half)(-8.5));
        Assert.That(((Half)(-8.5)), Is.EqualTo(v[0]));
        v[1] = ((Half)(-7.5));
        Assert.That(((Half)(-7.5)), Is.EqualTo(v[1]));
        v[0] = ((Half)(-6.5));
        Assert.That(((Half)(-6.5)), Is.EqualTo(v[0]));
        v[3] = ((Half)(-5.5));
        Assert.That(((Half)(-5.5)), Is.EqualTo(v[3]));
        v[1] = ((Half)(-4.5));
        Assert.That(((Half)(-4.5)), Is.EqualTo(v[1]));
        v[3] = ((Half)(-3.5));
        Assert.That(((Half)(-3.5)), Is.EqualTo(v[3]));
        v[1] = ((Half)(-2.5));
        Assert.That(((Half)(-2.5)), Is.EqualTo(v[1]));
        v[0] = ((Half)(-1.5));
        Assert.That(((Half)(-1.5)), Is.EqualTo(v[0]));
        v[1] = ((Half)(-0.5));
        Assert.That(((Half)(-0.5)), Is.EqualTo(v[1]));
        v[3] = ((Half)(0.5));
        Assert.That(((Half)(0.5)), Is.EqualTo(v[3]));
        v[1] = ((Half)(1.5));
        Assert.That(((Half)(1.5)), Is.EqualTo(v[1]));
        v[1] = ((Half)(2.5));
        Assert.That(((Half)(2.5)), Is.EqualTo(v[1]));
        v[1] = ((Half)(3.5));
        Assert.That(((Half)(3.5)), Is.EqualTo(v[1]));
        v[0] = ((Half)(4.5));
        Assert.That(((Half)(4.5)), Is.EqualTo(v[0]));
        v[1] = ((Half)(5.5));
        Assert.That(((Half)(5.5)), Is.EqualTo(v[1]));
        v[3] = ((Half)(6.5));
        Assert.That(((Half)(6.5)), Is.EqualTo(v[3]));
        v[3] = ((Half)(7.5));
        Assert.That(((Half)(7.5)), Is.EqualTo(v[3]));
        v[2] = ((Half)(8.5));
        Assert.That(((Half)(8.5)), Is.EqualTo(v[2]));
        v[1] = ((Half)(9.5));
        Assert.That(((Half)(9.5)), Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new hvec4(((Half)(-1)), ((Half)(4)), ((Half)(-0.5)), ((Half)(-1)));
        var vals = v.Values;
        Assert.That(((Half)(-1)), Is.EqualTo(vals[0]));
        Assert.That(((Half)(4)), Is.EqualTo(vals[1]));
        Assert.That(((Half)(-0.5)), Is.EqualTo(vals[2]));
        Assert.That(((Half)(-1)), Is.EqualTo(vals[3]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(Half.Zero, Is.EqualTo(hvec4.Zero.x));
        Assert.That(Half.Zero, Is.EqualTo(hvec4.Zero.y));
        Assert.That(Half.Zero, Is.EqualTo(hvec4.Zero.z));
        Assert.That(Half.Zero, Is.EqualTo(hvec4.Zero.w));
        
        Assert.That(Half.One, Is.EqualTo(hvec4.Ones.x));
        Assert.That(Half.One, Is.EqualTo(hvec4.Ones.y));
        Assert.That(Half.One, Is.EqualTo(hvec4.Ones.z));
        Assert.That(Half.One, Is.EqualTo(hvec4.Ones.w));
        
        Assert.That(Half.One, Is.EqualTo(hvec4.UnitX.x));
        Assert.That(Half.Zero, Is.EqualTo(hvec4.UnitX.y));
        Assert.That(Half.Zero, Is.EqualTo(hvec4.UnitX.z));
        Assert.That(Half.Zero, Is.EqualTo(hvec4.UnitX.w));
        
        Assert.That(Half.Zero, Is.EqualTo(hvec4.UnitY.x));
        Assert.That(Half.One, Is.EqualTo(hvec4.UnitY.y));
        Assert.That(Half.Zero, Is.EqualTo(hvec4.UnitY.z));
        Assert.That(Half.Zero, Is.EqualTo(hvec4.UnitY.w));
        
        Assert.That(Half.Zero, Is.EqualTo(hvec4.UnitZ.x));
        Assert.That(Half.Zero, Is.EqualTo(hvec4.UnitZ.y));
        Assert.That(Half.One, Is.EqualTo(hvec4.UnitZ.z));
        Assert.That(Half.Zero, Is.EqualTo(hvec4.UnitZ.w));
        
        Assert.That(Half.Zero, Is.EqualTo(hvec4.UnitW.x));
        Assert.That(Half.Zero, Is.EqualTo(hvec4.UnitW.y));
        Assert.That(Half.Zero, Is.EqualTo(hvec4.UnitW.z));
        Assert.That(Half.One, Is.EqualTo(hvec4.UnitW.w));
        
        Assert.That(Half.MaxValue, Is.EqualTo(hvec4.MaxValue.x));
        Assert.That(Half.MaxValue, Is.EqualTo(hvec4.MaxValue.y));
        Assert.That(Half.MaxValue, Is.EqualTo(hvec4.MaxValue.z));
        Assert.That(Half.MaxValue, Is.EqualTo(hvec4.MaxValue.w));
        
        Assert.That(Half.MinValue, Is.EqualTo(hvec4.MinValue.x));
        Assert.That(Half.MinValue, Is.EqualTo(hvec4.MinValue.y));
        Assert.That(Half.MinValue, Is.EqualTo(hvec4.MinValue.z));
        Assert.That(Half.MinValue, Is.EqualTo(hvec4.MinValue.w));
        
        Assert.That(Half.Epsilon, Is.EqualTo(hvec4.Epsilon.x));
        Assert.That(Half.Epsilon, Is.EqualTo(hvec4.Epsilon.y));
        Assert.That(Half.Epsilon, Is.EqualTo(hvec4.Epsilon.z));
        Assert.That(Half.Epsilon, Is.EqualTo(hvec4.Epsilon.w));
        
        Assert.That(Half.NaN, Is.EqualTo(hvec4.NaN.x));
        Assert.That(Half.NaN, Is.EqualTo(hvec4.NaN.y));
        Assert.That(Half.NaN, Is.EqualTo(hvec4.NaN.z));
        Assert.That(Half.NaN, Is.EqualTo(hvec4.NaN.w));
        
        Assert.That(Half.NegativeInfinity, Is.EqualTo(hvec4.NegativeInfinity.x));
        Assert.That(Half.NegativeInfinity, Is.EqualTo(hvec4.NegativeInfinity.y));
        Assert.That(Half.NegativeInfinity, Is.EqualTo(hvec4.NegativeInfinity.z));
        Assert.That(Half.NegativeInfinity, Is.EqualTo(hvec4.NegativeInfinity.w));
        
        Assert.That(Half.PositiveInfinity, Is.EqualTo(hvec4.PositiveInfinity.x));
        Assert.That(Half.PositiveInfinity, Is.EqualTo(hvec4.PositiveInfinity.y));
        Assert.That(Half.PositiveInfinity, Is.EqualTo(hvec4.PositiveInfinity.z));
        Assert.That(Half.PositiveInfinity, Is.EqualTo(hvec4.PositiveInfinity.w));
    }

    [Test]
    public void Operators()
    {
        var v1 = new hvec4(((Half)(-2.5)), ((Half)(-9.5)), ((Half)(9)), ((Half)(7.5)));
        var v2 = new hvec4(((Half)(-2.5)), ((Half)(-9.5)), ((Half)(9)), ((Half)(7.5)));
        var v3 = new hvec4(((Half)(7.5)), ((Half)(9)), ((Half)(-9.5)), ((Half)(-2.5)));
        Assert.That(v1 == new hvec4(v1));
        Assert.That(v2 == new hvec4(v2));
        Assert.That(v3 == new hvec4(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new hvec4(((Half)(-4.5)), ((Half)(6)), ((Half)(-6.5)), ((Half)(-8)));
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
        
        var v0 = hvec4.Parse(s0);
        var v1 = hvec4.Parse(s1, "#");
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        var b0 = hvec4.TryParse(s0, out v0);
        var b1 = hvec4.TryParse(s1, "#", out v1);
        Assert.That(b0);
        Assert.That(b1);
        Assert.That(v, Is.EqualTo(v0));
        Assert.That(v, Is.EqualTo(v1));
        
        b0 = hvec4.TryParse(null, out v0);
        Assert.That(!b0);
        b0 = hvec4.TryParse("", out v0);
        Assert.That(!b0);
        b0 = hvec4.TryParse(s0 + ", 0", out v0);
        Assert.That(!b0);
        
        Assert.Throws<NullReferenceException>(() => { hvec4.Parse(null); });
        Assert.Throws<FormatException>(() => { hvec4.Parse(""); });
        Assert.Throws<FormatException>(() => { hvec4.Parse(s0 + ", 0"); });
        
        var s2 = v.ToString(";", CultureInfo.InvariantCulture);
        Assert.That(s2.Length > 0);
        
        var s3 = v.ToString("; ", "G");
        var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
        var v3 = hvec4.Parse(s3, "; ", NumberStyles.Number);
        var v4 = hvec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
        Assert.That(v, Is.EqualTo(v3));
        Assert.That(v, Is.EqualTo(v4));
        
        var b4 = hvec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
        Assert.That(b4);
        Assert.That(v, Is.EqualTo(v4));
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new hvec4(((Half)(-9.5)), ((Half)(-7.5)), ((Half)(2.5)), ((Half)(-3.5)));
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<hvec4>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

    [Test]
    public void InvariantId()
    {
        {
            var v0 = new hvec4(((Half)(-8)), ((Half)(-8.5)), ((Half)(3.5)), ((Half)(3)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec4(((Half)(-7)), ((Half)(0.5)), ((Half)(6.5)), ((Half)(1.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec4(((Half)(4.5)), ((Half)(2)), ((Half)(0.5)), ((Half)(4.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec4(((Half)(-6)), ((Half)(4.5)), ((Half)(7)), ((Half)(-4.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec4(((Half)(8)), ((Half)(9.5)), ((Half)(-2.5)), ((Half)(-5.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec4(((Half)(2.5)), ((Half)(-1.5)), ((Half)(-3.5)), ((Half)(7)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec4(((Half)(9.5)), ((Half)(9.5)), ((Half)(5)), ((Half)(8.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec4(((Half)(5.5)), ((Half)(-6)), ((Half)(-1.5)), ((Half)(4)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec4(((Half)(-7)), ((Half)(-4.5)), Half.Zero, ((Half)(-3.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
        {
            var v0 = new hvec4(((Half)(-4)), Half.One, ((Half)(-7)), ((Half)(2.5)));
            Assert.That(v0, Is.EqualTo(+v0));
        }
    }

    [Test]
    public void InvariantDouble()
    {
        {
            var v0 = new hvec4(((Half)(-3)), ((Half)(-0.5)), ((Half)(-3.5)), ((Half)(-9)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec4(((Half)(8.5)), Half.Zero, ((Half)(-1)), ((Half)(4)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-8.5)), ((Half)(5)), ((Half)(5)), ((Half)(4.5)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-7.5)), ((Half)(-7.5)), Half.Zero, ((Half)(9.5)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-8.5)), ((Half)(4)), ((Half)(1.5)), ((Half)(-3.5)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-3.5)), ((Half)(2)), ((Half)(-6)), ((Half)(5)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-3)), ((Half)(8.5)), ((Half)(5)), ((Half)(8)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-1.5)), ((Half)(-7.5)), ((Half)(3.5)), ((Half)(6)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-8)), ((Half)(-2.5)), ((Half)(1.5)), ((Half)(2)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-7.5)), ((Half)(6.5)), ((Half)(6.5)), ((Half)(-9)));
            Assert.That(v0 + v0, Is.EqualTo((byte)2 * v0));
        }
    }

    [Test]
    public void InvariantTriple()
    {
        {
            var v0 = new hvec4(((Half)(-4)), ((Half)(3.5)), ((Half)(8.5)), ((Half)(5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec4(Half.One, ((Half)(4.5)), ((Half)(3)), ((Half)(-9.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-9.5)), Half.Zero, ((Half)(-4.5)), ((Half)(-5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-5.5)), ((Half)(-4.5)), ((Half)(-8)), ((Half)(4.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-5.5)), ((Half)(6.5)), ((Half)(-7.5)), ((Half)(1.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-5.5)), ((Half)(-8.5)), ((Half)(5)), ((Half)(7)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-3.5)), Half.One, ((Half)(-2.5)), ((Half)(-9)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec4(((Half)(2.5)), ((Half)(9)), ((Half)(-6)), ((Half)(-5.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec4(((Half)(9)), ((Half)(-1.5)), Half.One, ((Half)(0.5)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
        {
            var v0 = new hvec4(((Half)(4.5)), ((Half)(-6)), ((Half)(2.5)), ((Half)(-7)));
            Assert.That(v0 + v0 + v0, Is.EqualTo((byte)3 * v0));
        }
    }

    [Test]
    public void InvariantCommutative()
    {
        {
            var v0 = new hvec4(((Half)(-5.5)), ((Half)(6)), ((Half)(-5)), ((Half)(1.5)));
            var v1 = new hvec4(((Half)(-6.5)), ((Half)(-6.5)), ((Half)(7.5)), ((Half)(-0.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-2.5)), ((Half)(8.5)), Half.One, ((Half)(5.5)));
            var v1 = new hvec4(((Half)(8.5)), ((Half)(-2.5)), ((Half)(-8)), ((Half)(-2.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-4)), ((Half)(-8)), ((Half)(-7.5)), ((Half)(1.5)));
            var v1 = new hvec4(((Half)(-5)), ((Half)(6.5)), ((Half)(6)), ((Half)(6.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec4(((Half)(4)), ((Half)(-9)), ((Half)(2.5)), ((Half)(8.5)));
            var v1 = new hvec4(((Half)(9)), ((Half)(-5)), ((Half)(6.5)), ((Half)(-7.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-7.5)), ((Half)(9.5)), ((Half)(-8.5)), ((Half)(5)));
            var v1 = new hvec4(((Half)(8.5)), ((Half)(8)), ((Half)(8.5)), ((Half)(4.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-7)), ((Half)(-1)), ((Half)(-2.5)), ((Half)(-3.5)));
            var v1 = new hvec4(((Half)(3.5)), ((Half)(2.5)), ((Half)(5.5)), ((Half)(2.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec4(((Half)(4.5)), ((Half)(-1)), ((Half)(-6.5)), ((Half)(0.5)));
            var v1 = new hvec4(((Half)(7)), ((Half)(9.5)), ((Half)(-5.5)), ((Half)(-1.5)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec4(Half.Zero, ((Half)(-9)), ((Half)(-3.5)), ((Half)(3)));
            var v1 = new hvec4(((Half)(0.5)), ((Half)(8.5)), ((Half)(-9)), ((Half)(-3)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec4(Half.One, ((Half)(-9.5)), ((Half)(-3)), ((Half)(8.5)));
            var v1 = new hvec4(((Half)(6)), ((Half)(-2)), ((Half)(-0.5)), ((Half)(4)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
        {
            var v0 = new hvec4(((Half)(-9.5)), ((Half)(-1.5)), ((Half)(-4)), ((Half)(4)));
            var v1 = new hvec4(((Half)(8)), ((Half)(-8.5)), ((Half)(3)), ((Half)(-3)));
            Assert.That(v0 * v1, Is.EqualTo(v1 * v0));
        }
    }

    [Test]
    public void InvariantAssociative()
    {
        {
            var v0 = new hvec4(((Half)(3)), ((Half)(-4)), ((Half)(-8)), ((Half)(-2.5)));
            var v1 = new hvec4(((Half)(-1.5)), ((Half)(2.5)), ((Half)(-0.5)), ((Half)(2.5)));
            var v2 = new hvec4(((Half)(-8)), ((Half)(2)), ((Half)(-8.5)), ((Half)(4)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(-6.5)), ((Half)(-1.5)), ((Half)(-6)), ((Half)(1.5)));
            var v1 = new hvec4(((Half)(2)), ((Half)(5.5)), ((Half)(5.5)), ((Half)(3)));
            var v2 = new hvec4(((Half)(-0.5)), ((Half)(8)), ((Half)(4)), ((Half)(-9)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(-5)), ((Half)(2.5)), ((Half)(-7)), ((Half)(8.5)));
            var v1 = new hvec4(((Half)(-1)), ((Half)(-5.5)), ((Half)(7)), Half.One);
            var v2 = new hvec4(((Half)(-7)), ((Half)(5.5)), ((Half)(3.5)), ((Half)(-2)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(6)), ((Half)(-9)), ((Half)(-3.5)), ((Half)(5.5)));
            var v1 = new hvec4(((Half)(-0.5)), ((Half)(7)), ((Half)(-2)), ((Half)(-5)));
            var v2 = new hvec4(((Half)(-4)), ((Half)(5)), ((Half)(-9.5)), ((Half)(-5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(4.5)), ((Half)(-3)), ((Half)(-6)), ((Half)(-9)));
            var v1 = new hvec4(((Half)(-7.5)), ((Half)(-7)), ((Half)(7.5)), ((Half)(5.5)));
            var v2 = new hvec4(((Half)(8)), ((Half)(9.5)), ((Half)(-2)), ((Half)(6.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(-6)), ((Half)(1.5)), ((Half)(-7.5)), ((Half)(4.5)));
            var v1 = new hvec4(((Half)(5.5)), ((Half)(-9.5)), ((Half)(-1.5)), ((Half)(-2.5)));
            var v2 = new hvec4(((Half)(5.5)), ((Half)(3)), ((Half)(-5.5)), ((Half)(-6.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(8)), ((Half)(9.5)), ((Half)(-4)), ((Half)(-7.5)));
            var v1 = new hvec4(((Half)(6.5)), ((Half)(-0.5)), ((Half)(4)), ((Half)(9)));
            var v2 = new hvec4(((Half)(-2)), Half.One, ((Half)(3)), ((Half)(7.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(8)), ((Half)(-1.5)), ((Half)(-9)), ((Half)(9.5)));
            var v1 = new hvec4(((Half)(7.5)), ((Half)(8.5)), ((Half)(3)), ((Half)(7)));
            var v2 = new hvec4(((Half)(6)), ((Half)(0.5)), ((Half)(-9.5)), ((Half)(8.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(-3.5)), ((Half)(-8)), ((Half)(-9.5)), ((Half)(4.5)));
            var v1 = new hvec4(((Half)(-7)), ((Half)(3.5)), ((Half)(-9.5)), ((Half)(0.5)));
            var v2 = new hvec4(((Half)(-0.5)), ((Half)(2.5)), ((Half)(9)), ((Half)(-7.5)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(3)), ((Half)(-6)), ((Half)(8.5)), ((Half)(-9)));
            var v1 = new hvec4(((Half)(4.5)), ((Half)(2)), ((Half)(-5.5)), ((Half)(-4)));
            var v2 = new hvec4(((Half)(-2.5)), ((Half)(-5.5)), ((Half)(-3.5)), ((Half)(6)));
            Assert.That(v0 * (v1 + v2), Is.EqualTo(v0 * v1 + v0 * v2));
        }
    }

    [Test]
    public void InvariantIdNeg()
    {
        {
            var v0 = new hvec4(((Half)(9)), ((Half)(1.5)), ((Half)(6.5)), ((Half)(-5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec4(((Half)(8)), ((Half)(-7.5)), ((Half)(6.5)), ((Half)(-8)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec4(((Half)(-5.5)), ((Half)(-8.5)), ((Half)(-3.5)), ((Half)(-6)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec4(((Half)(-1.5)), ((Half)(-9.5)), ((Half)(-5.5)), ((Half)(7.5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec4(((Half)(0.5)), ((Half)(1.5)), Half.One, ((Half)(-8.5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec4(((Half)(-1)), ((Half)(-1)), ((Half)(1.5)), ((Half)(-0.5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec4(((Half)(4)), ((Half)(-5)), ((Half)(-3)), ((Half)(5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec4(((Half)(-3)), ((Half)(-1.5)), ((Half)(3)), ((Half)(6.5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec4(((Half)(6)), ((Half)(7.5)), ((Half)(-2.5)), Half.One);
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
        {
            var v0 = new hvec4(((Half)(-1)), ((Half)(9.5)), ((Half)(-8)), ((Half)(1.5)));
            Assert.That(v0, Is.EqualTo(-(-v0)));
        }
    }

    [Test]
    public void InvariantCommutativeNeg()
    {
        {
            var v0 = new hvec4(((Half)(1.5)), ((Half)(-1)), ((Half)(-4.5)), ((Half)(9)));
            var v1 = new hvec4(((Half)(-1.5)), ((Half)(9)), ((Half)(-8.5)), ((Half)(3)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec4(((Half)(-0.5)), ((Half)(4.5)), ((Half)(-6)), ((Half)(-6)));
            var v1 = new hvec4(((Half)(-0.5)), ((Half)(-5.5)), ((Half)(7)), ((Half)(-3)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec4(((Half)(-5)), ((Half)(4.5)), ((Half)(-6)), ((Half)(5.5)));
            var v1 = new hvec4(((Half)(-2.5)), ((Half)(1.5)), ((Half)(8.5)), ((Half)(-4)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec4(((Half)(-9)), ((Half)(-4.5)), ((Half)(-8)), ((Half)(4)));
            var v1 = new hvec4(((Half)(-9)), ((Half)(-3)), ((Half)(1.5)), ((Half)(-7)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec4(((Half)(8)), ((Half)(-4.5)), ((Half)(-2)), ((Half)(-7.5)));
            var v1 = new hvec4(((Half)(-3)), ((Half)(6.5)), ((Half)(1.5)), ((Half)(-6.5)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec4(((Half)(5)), ((Half)(3)), ((Half)(5)), ((Half)(2.5)));
            var v1 = new hvec4(((Half)(-4)), ((Half)(9)), ((Half)(-5.5)), ((Half)(4)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec4(((Half)(2.5)), ((Half)(1.5)), ((Half)(-8)), ((Half)(-6.5)));
            var v1 = new hvec4(Half.One, ((Half)(-4.5)), ((Half)(-6)), Half.Zero);
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec4(((Half)(-3)), ((Half)(-1)), ((Half)(1.5)), ((Half)(3)));
            var v1 = new hvec4(((Half)(2.5)), ((Half)(-6)), ((Half)(-5.5)), ((Half)(-7)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec4(((Half)(3)), ((Half)(9.5)), ((Half)(7)), ((Half)(4)));
            var v1 = new hvec4(((Half)(-2)), ((Half)(-3.5)), Half.Zero, ((Half)(-8)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
        {
            var v0 = new hvec4(((Half)(2)), ((Half)(3.5)), ((Half)(-0.5)), ((Half)(-6.5)));
            var v1 = new hvec4(((Half)(-4.5)), ((Half)(5)), ((Half)(9.5)), ((Half)(8)));
            Assert.That(v0 - v1, Is.EqualTo(-(v1 - v0)));
        }
    }

    [Test]
    public void InvariantAssociativeNeg()
    {
        {
            var v0 = new hvec4(((Half)(8.5)), ((Half)(3.5)), ((Half)(-9)), Half.Zero);
            var v1 = new hvec4(((Half)(3)), Half.Zero, Half.Zero, ((Half)(-9.5)));
            var v2 = new hvec4(((Half)(-4.5)), Half.Zero, ((Half)(-9)), ((Half)(-5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(7.5)), ((Half)(-9.5)), ((Half)(-4.5)), ((Half)(8)));
            var v1 = new hvec4(((Half)(0.5)), Half.Zero, ((Half)(2.5)), ((Half)(2)));
            var v2 = new hvec4(((Half)(8)), Half.One, Half.Zero, ((Half)(2.5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(-9)), ((Half)(-9)), ((Half)(-5)), ((Half)(6.5)));
            var v1 = new hvec4(((Half)(-5.5)), ((Half)(3.5)), ((Half)(-3.5)), ((Half)(7)));
            var v2 = new hvec4(Half.Zero, ((Half)(4.5)), ((Half)(-4)), ((Half)(5.5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(3.5)), ((Half)(-6.5)), ((Half)(-3.5)), Half.One);
            var v1 = new hvec4(((Half)(-4.5)), ((Half)(3)), ((Half)(-1.5)), ((Half)(-6.5)));
            var v2 = new hvec4(((Half)(5.5)), ((Half)(-9)), ((Half)(-5.5)), ((Half)(5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(-7.5)), ((Half)(9)), ((Half)(3.5)), ((Half)(-1.5)));
            var v1 = new hvec4(((Half)(9.5)), ((Half)(7)), ((Half)(-4)), ((Half)(7.5)));
            var v2 = new hvec4(((Half)(2.5)), ((Half)(-2.5)), ((Half)(-7.5)), ((Half)(-5.5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(-4.5)), ((Half)(3)), ((Half)(5.5)), ((Half)(1.5)));
            var v1 = new hvec4(((Half)(-5)), ((Half)(-2)), ((Half)(-5)), ((Half)(3)));
            var v2 = new hvec4(((Half)(5)), ((Half)(0.5)), ((Half)(-6)), ((Half)(7)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(-4)), ((Half)(1.5)), ((Half)(-7)), ((Half)(5)));
            var v1 = new hvec4(((Half)(-3)), ((Half)(-8)), ((Half)(6.5)), ((Half)(9.5)));
            var v2 = new hvec4(((Half)(5.5)), ((Half)(9)), ((Half)(-5)), ((Half)(-5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec4(Half.Zero, ((Half)(7.5)), ((Half)(7)), ((Half)(3.5)));
            var v1 = new hvec4(((Half)(-8.5)), ((Half)(-7)), ((Half)(2)), ((Half)(5)));
            var v2 = new hvec4(Half.Zero, Half.One, ((Half)(-6)), ((Half)(-8.5)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(7)), ((Half)(6.5)), ((Half)(7)), ((Half)(-6.5)));
            var v1 = new hvec4(((Half)(4)), ((Half)(-8.5)), ((Half)(9.5)), ((Half)(1.5)));
            var v2 = new hvec4(((Half)(3.5)), ((Half)(-4.5)), ((Half)(-4)), ((Half)(8)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
        {
            var v0 = new hvec4(((Half)(0.5)), ((Half)(7)), ((Half)(-4.5)), ((Half)(-5)));
            var v1 = new hvec4(((Half)(0.5)), ((Half)(-7.5)), ((Half)(-1.5)), ((Half)(-6)));
            var v2 = new hvec4(((Half)(-0.5)), ((Half)(-8.5)), ((Half)(1.5)), ((Half)(-7)));
            Assert.That(v0 * (v1 - v2), Is.EqualTo(v0 * v1 - v0 * v2));
        }
    }

    [Test]
    public void TriangleInequality()
    {
        {
            var v0 = new hvec4(((Half)(-2)), ((Half)(-8)), ((Half)(6)), ((Half)(-4)));
            var v1 = new hvec4(((Half)(-1.5)), ((Half)(-9)), ((Half)(-5.5)), ((Half)(2.5)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec4(((Half)(-8.5)), ((Half)(-3)), ((Half)(-5.5)), Half.Zero);
            var v1 = new hvec4(((Half)(-7.5)), ((Half)(-9.5)), ((Half)(-3)), ((Half)(8)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec4(((Half)(-8)), ((Half)(6.5)), ((Half)(8)), ((Half)(1.5)));
            var v1 = new hvec4(((Half)(-9)), ((Half)(3)), ((Half)(8.5)), ((Half)(-7)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec4(((Half)(-1)), ((Half)(7.5)), ((Half)(-0.5)), ((Half)(-1.5)));
            var v1 = new hvec4(Half.Zero, Half.Zero, ((Half)(-6)), ((Half)(7)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec4(((Half)(2.5)), ((Half)(-7)), ((Half)(3)), ((Half)(-1.5)));
            var v1 = new hvec4(((Half)(-4)), ((Half)(8)), ((Half)(-5)), ((Half)(7.5)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec4(((Half)(3.5)), ((Half)(-8.5)), ((Half)(-7)), ((Half)(-6.5)));
            var v1 = new hvec4(((Half)(-8.5)), ((Half)(-7.5)), ((Half)(-4.5)), ((Half)(9.5)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec4(((Half)(-5)), ((Half)(4)), ((Half)(-2)), ((Half)(0.5)));
            var v1 = new hvec4(((Half)(-1)), ((Half)(-6)), ((Half)(7)), ((Half)(8)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec4(((Half)(-9)), ((Half)(-0.5)), ((Half)(2)), ((Half)(1.5)));
            var v1 = new hvec4(((Half)(-0.5)), ((Half)(5.5)), ((Half)(2.5)), ((Half)(-9.5)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec4(((Half)(7.5)), ((Half)(-6)), ((Half)(7)), ((Half)(5)));
            var v1 = new hvec4(((Half)(-7)), ((Half)(-5.5)), ((Half)(4.5)), ((Half)(9)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
        {
            var v0 = new hvec4(((Half)(-8.5)), ((Half)(-1)), ((Half)(7.5)), ((Half)(7.5)));
            var v1 = new hvec4(((Half)(-2.5)), ((Half)(-6)), ((Half)(5.5)), ((Half)(-0.5)));
            Assert.That(v0.NormMax + v1.NormMax, Is.GreaterThanOrEqualTo((v0 + v1).NormMax));
        }
    }

    [Test]
    public void InvariantNorm()
    {
        {
            var v0 = new hvec4(((Half)(-5)), ((Half)(-4.5)), ((Half)(-5)), ((Half)(-8)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec4(Half.Zero, ((Half)(-3.5)), ((Half)(-2.5)), ((Half)(2)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec4(((Half)(-5.5)), Half.One, ((Half)(-4)), ((Half)(-2.5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec4(((Half)(-3.5)), ((Half)(3.5)), ((Half)(6)), ((Half)(-6)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec4(Half.One, ((Half)(2.5)), ((Half)(5.5)), ((Half)(2.5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec4(((Half)(2.5)), ((Half)(-6.5)), ((Half)(-7.5)), ((Half)(6)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec4(((Half)(-2)), ((Half)(3)), ((Half)(-5)), ((Half)(7)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec4(((Half)(-2.5)), ((Half)(7.5)), ((Half)(-5.5)), ((Half)(4)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec4(((Half)(0.5)), ((Half)(-5.5)), ((Half)(-5.5)), ((Half)(9.5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
        {
            var v0 = new hvec4(((Half)(-3)), ((Half)(9)), ((Half)(-0.5)), ((Half)(5.5)));
            Assert.That(v0.NormMax, Is.LessThanOrEqualTo(v0.Norm));
        }
    }

    [Test]
    public void RandomUniform0()
    {
        var random = new Random(1494935908);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.Random(random, (sbyte)(-1), (sbyte)(1));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform1()
    {
        var random = new Random(2096138032);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.RandomUniform(random, (sbyte)(2), (sbyte)(3));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(2.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(2.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(2.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(2.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.08333333333333333).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.08333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform2()
    {
        var random = new Random(1811081714);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.Random(random, (sbyte)(4), (sbyte)(7));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(5.5).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(5.5).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(5.5).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(5.5).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.75).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.75).Within(3.0));
    }

    [Test]
    public void RandomUniform3()
    {
        var random = new Random(1832935485);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.RandomUniform(random, (sbyte)(-5), (sbyte)(-1));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-3).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-3).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-3).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-3).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(1.3333333333333333).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(1.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomUniform4()
    {
        var random = new Random(1955680478);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.Random(random, (sbyte)(-2), (sbyte)(0));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-1).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-1).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.3333333333333333).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.3333333333333333).Within(3.0));
    }

    [Test]
    public void RandomGaussian0()
    {
        var random = new Random(1924365945);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.RandomNormal(random, ((Half)(-0.12134380178588611)), ((Half)(9.209571107853936)));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-0.12134380178588611).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-0.12134380178588611).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-0.12134380178588611).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-0.12134380178588611).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(9.209571107853936).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(9.209571107853936).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(9.209571107853936).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(9.209571107853936).Within(3.0));
    }

    [Test]
    public void RandomGaussian1()
    {
        var random = new Random(1315792042);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.RandomGaussian(random, ((Half)(0.08142601795560944)), ((Half)(0.8906859303315571)));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.08142601795560944).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.08142601795560944).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.08142601795560944).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0.08142601795560944).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.8906859303315571).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.8906859303315571).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.8906859303315571).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.8906859303315571).Within(3.0));
    }

    [Test]
    public void RandomGaussian2()
    {
        var random = new Random(412954414);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.RandomNormal(random, ((Half)(1.8681086617839098)), ((Half)(2.1470942218541604)));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(1.8681086617839098).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(1.8681086617839098).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(1.8681086617839098).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(1.8681086617839098).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(2.1470942218541604).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(2.1470942218541604).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(2.1470942218541604).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(2.1470942218541604).Within(3.0));
    }

    [Test]
    public void RandomGaussian3()
    {
        var random = new Random(444374532);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.RandomGaussian(random, ((Half)(-1.9998402204363794)), ((Half)(0.9895862596992339)));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(-1.9998402204363794).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(-1.9998402204363794).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(-1.9998402204363794).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(-1.9998402204363794).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(0.9895862596992339).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(0.9895862596992339).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(0.9895862596992339).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(0.9895862596992339).Within(3.0));
    }

    [Test]
    public void RandomGaussian4()
    {
        var random = new Random(2076567482);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.RandomNormal(random, ((Half)(0.531006154851525)), ((Half)(8.326569850708625)));
            sum += (dvec4)v;
            sumSqr += glm.Pow2((dvec4)v);
        }
        
        var avg = sum / (double)count;
        var variance = sumSqr / (double)count - avg * avg;
        
        Assert.That(avg.x, Is.EqualTo(0.531006154851525).Within(1.0));
        Assert.That(avg.y, Is.EqualTo(0.531006154851525).Within(1.0));
        Assert.That(avg.z, Is.EqualTo(0.531006154851525).Within(1.0));
        Assert.That(avg.w, Is.EqualTo(0.531006154851525).Within(1.0));
        
        Assert.That(variance.x, Is.EqualTo(8.326569850708625).Within(3.0));
        Assert.That(variance.y, Is.EqualTo(8.326569850708625).Within(3.0));
        Assert.That(variance.z, Is.EqualTo(8.326569850708625).Within(3.0));
        Assert.That(variance.w, Is.EqualTo(8.326569850708625).Within(3.0));
    }

    [Test]
    public void RandomNormal0()
    {
        var random = new Random(503051792);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.RandomNormal(random);
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
        var random = new Random(454021898);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.RandomNormal(random);
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
        var random = new Random(1049177418);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.RandomNormal(random);
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
        var random = new Random(368911376);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.RandomNormal(random);
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
        var random = new Random(503120559);
        var sum = new dvec4(0.0);
        var sumSqr = new dvec4(0.0);
        
        const int count = 50000;
        for (var _ = 0; _ < count; ++_)
        {
            var v = hvec4.RandomNormal(random);
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
