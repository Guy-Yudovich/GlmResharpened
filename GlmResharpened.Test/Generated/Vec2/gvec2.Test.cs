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
public class TVec2Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new gvec2<string>("-8");
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>(null, "(9-7)");
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("(9-7)", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>(new gvec2<string>("((4-5)-2)", "((6-1)0)"));
            Assert.That("((4-5)-2)", Is.EqualTo(v.x));
            Assert.That("((6-1)0)", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>(new gvec3<string>("((-2-4)2)", "((-2-4)2)", "((7-2)4)"));
            Assert.That("((-2-4)2)", Is.EqualTo(v.x));
            Assert.That("((-2-4)2)", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>(new gvec4<string>("((-71)5)", "1", null, ""));
            Assert.That("((-71)5)", Is.EqualTo(v.x));
            Assert.That("1", Is.EqualTo(v.y));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new gvec2<string>("1", "(-3-7)");
        Assert.That("1", Is.EqualTo(v[0]));
        Assert.That("(-3-7)", Is.EqualTo(v[1]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = null; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = null; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = null; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = null; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = null; } );
        
        v[0] = null;
        Assert.That(null, Is.EqualTo(v[0]));
        v[0] = "";
        Assert.That("", Is.EqualTo(v[0]));
        v[1] = "0";
        Assert.That("0", Is.EqualTo(v[1]));
        v[1] = "(-7-1)";
        Assert.That("(-7-1)", Is.EqualTo(v[1]));
        v[0] = "((40)-5)";
        Assert.That("((40)-5)", Is.EqualTo(v[0]));
        v[1] = "-5";
        Assert.That("-5", Is.EqualTo(v[1]));
        v[0] = "(-10)";
        Assert.That("(-10)", Is.EqualTo(v[0]));
        v[1] = "((-1-3)0)";
        Assert.That("((-1-3)0)", Is.EqualTo(v[1]));
        v[0] = "0";
        Assert.That("0", Is.EqualTo(v[0]));
        v[1] = "(7-9)";
        Assert.That("(7-9)", Is.EqualTo(v[1]));
        v[1] = "((-66)3)";
        Assert.That("((-66)3)", Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new gvec2<string>("", "9");
        var vals = v.Values;
        Assert.That("", Is.EqualTo(vals[0]));
        Assert.That("9", Is.EqualTo(vals[1]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(null, Is.EqualTo(gvec2<string>.Zero.x));
        Assert.That(null, Is.EqualTo(gvec2<string>.Zero.y));
    }

    [Test]
    public void Operators()
    {
        var v1 = new gvec2<string>("(-8-6)", "-9");
        var v2 = new gvec2<string>("(-8-6)", "-9");
        var v3 = new gvec2<string>("-9", "(-8-6)");
        Assert.That((v1 == new gvec2<string>(v1)).AllTrue);
        Assert.That((v2 == new gvec2<string>(v2)).AllTrue);
        Assert.That((v3 == new gvec2<string>(v3)).AllTrue);
        Assert.That((v1 == v2).AllTrue);
        Assert.That((v1 != v3).AllTrue);
        Assert.That((v2 != v3).AllTrue);
    }

    [Test]
    public void StringInterop()
    {
        var v = new gvec2<string>("(-7-4)", "((-5-5)-3)");
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new gvec2<string>("2", "(1-8)");
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<gvec2<string>>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

}
