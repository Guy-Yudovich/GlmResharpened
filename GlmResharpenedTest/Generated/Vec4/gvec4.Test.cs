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
public class TVec4Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new gvec4<string>("(-9-8)");
            Assert.That("(-9-8)", Is.EqualTo(v.x));
            Assert.That("(-9-8)", Is.EqualTo(v.y));
            Assert.That("(-9-8)", Is.EqualTo(v.z));
            Assert.That("(-9-8)", Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>("0", "(-95)", "((17)1)", "(-95)");
            Assert.That("0", Is.EqualTo(v.x));
            Assert.That("(-95)", Is.EqualTo(v.y));
            Assert.That("((17)1)", Is.EqualTo(v.z));
            Assert.That("(-95)", Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>(new gvec2<string>("(-5-1)", "-5"));
            Assert.That("(-5-1)", Is.EqualTo(v.x));
            Assert.That("-5", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>(new gvec3<string>("-4", "((-6-6)6)", "((-6-6)6)"));
            Assert.That("-4", Is.EqualTo(v.x));
            Assert.That("((-6-6)6)", Is.EqualTo(v.y));
            Assert.That("((-6-6)6)", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>(new gvec4<string>("(68)", "(-49)", "((04)-7)", ""));
            Assert.That("(68)", Is.EqualTo(v.x));
            Assert.That("(-49)", Is.EqualTo(v.y));
            Assert.That("((04)-7)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new gvec4<string>("(-3-6)", "((-1-7)3)", "5", "(-4-5)");
        Assert.That("(-3-6)", Is.EqualTo(v[0]));
        Assert.That("((-1-7)3)", Is.EqualTo(v[1]));
        Assert.That("5", Is.EqualTo(v[2]));
        Assert.That("(-4-5)", Is.EqualTo(v[3]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = "null"; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = "null"; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = "null"; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = "null"; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = "null"; } );
        
        v[0] = "null";
        Assert.That("null", Is.EqualTo(v[0]));
        v[0] = "";
        Assert.That("", Is.EqualTo(v[0]));
        v[3] = "-1";
        Assert.That("-1", Is.EqualTo(v[3]));
        v[3] = "(6-1)";
        Assert.That("(6-1)", Is.EqualTo(v[3]));
        v[3] = "((-59)1)";
        Assert.That("((-59)1)", Is.EqualTo(v[3]));
        v[3] = "-9";
        Assert.That("-9", Is.EqualTo(v[3]));
        v[1] = "(18)";
        Assert.That("(18)", Is.EqualTo(v[1]));
        v[0] = "((94)3)";
        Assert.That("((94)3)", Is.EqualTo(v[0]));
        v[2] = "0";
        Assert.That("0", Is.EqualTo(v[2]));
        v[2] = "(1-7)";
        Assert.That("(1-7)", Is.EqualTo(v[2]));
        v[1] = "((7-5)1)";
        Assert.That("((7-5)1)", Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new gvec4<string>("((59)7)", "", "(91)", "6");
        var vals = v.Values;
        Assert.That("((59)7)", Is.EqualTo(vals[0]));
        Assert.That("", Is.EqualTo(vals[1]));
        Assert.That("(91)", Is.EqualTo(vals[2]));
        Assert.That("6", Is.EqualTo(vals[3]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That("null", Is.EqualTo(gvec4<string>.Zero.x));
        Assert.That("null", Is.EqualTo(gvec4<string>.Zero.y));
        Assert.That("null", Is.EqualTo(gvec4<string>.Zero.z));
        Assert.That("null", Is.EqualTo(gvec4<string>.Zero.w));
    }

    [Test]
    public void Operators()
    {
        var v1 = new gvec4<string>("-8", "-9", "((-57)8)", "null");
        var v2 = new gvec4<string>("-8", "-9", "((-57)8)", "null");
        var v3 = new gvec4<string>("null", "((-57)8)", "-9", "-8");
        Assert.That(v1 == new gvec4<string>(v1));
        Assert.That(v2 == new gvec4<string>(v2));
        Assert.That(v3 == new gvec4<string>(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new gvec4<string>("((-35)-6)", "", "-3", "((-5-6)7)");
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new gvec4<string>("(7-3)", "(82)", "-1", "((39)9)");
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<gvec4<string>>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

}
