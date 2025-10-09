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
            var v = new gvec2<string>("((-14)4)");
            Assert.That("((-14)4)", Is.EqualTo(v.x));
            Assert.That("((-14)4)", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>("", "6");
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("6", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>(new gvec2<string>("(-2-4)", "8"));
            Assert.That("(-2-4)", Is.EqualTo(v.x));
            Assert.That("8", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>(new gvec3<string>("(59)", "(-17)", "(76)"));
            Assert.That("(59)", Is.EqualTo(v.x));
            Assert.That("(-17)", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>(new gvec4<string>("", "-8", "null", "((36)-4)"));
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new gvec2<string>("(-35)", "null");
        Assert.That("(-35)", Is.EqualTo(v[0]));
        Assert.That("null", Is.EqualTo(v[1]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = "null"; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = "null"; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = "null"; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = "null"; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = "null"; } );
        
        v[0] = "null";
        Assert.That("null", Is.EqualTo(v[0]));
        v[0] = "";
        Assert.That("", Is.EqualTo(v[0]));
        v[1] = "2";
        Assert.That("2", Is.EqualTo(v[1]));
        v[1] = "(04)";
        Assert.That("(04)", Is.EqualTo(v[1]));
        v[1] = "((2-3)-9)";
        Assert.That("((2-3)-9)", Is.EqualTo(v[1]));
        v[1] = "-7";
        Assert.That("-7", Is.EqualTo(v[1]));
        v[1] = "(1-2)";
        Assert.That("(1-2)", Is.EqualTo(v[1]));
        v[1] = "((3-5)8)";
        Assert.That("((3-5)8)", Is.EqualTo(v[1]));
        v[1] = "-6";
        Assert.That("-6", Is.EqualTo(v[1]));
        v[0] = "(-24)";
        Assert.That("(-24)", Is.EqualTo(v[0]));
        v[0] = "((-8-6)5)";
        Assert.That("((-8-6)5)", Is.EqualTo(v[0]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new gvec2<string>("", "((23)-3)");
        var vals = v.Values;
        Assert.That("", Is.EqualTo(vals[0]));
        Assert.That("((23)-3)", Is.EqualTo(vals[1]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That("null", Is.EqualTo(gvec2<string>.Zero.x));
        Assert.That("null", Is.EqualTo(gvec2<string>.Zero.y));
    }

    [Test]
    public void Operators()
    {
        var v1 = new gvec2<string>("5", "((08)2)");
        var v2 = new gvec2<string>("5", "((08)2)");
        var v3 = new gvec2<string>("((08)2)", "5");
        Assert.That(v1 == new gvec2<string>(v1));
        Assert.That(v2 == new gvec2<string>(v2));
        Assert.That(v3 == new gvec2<string>(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new gvec2<string>("(9-1)", "((-9-7)-4)");
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new gvec2<string>("-7", "(-3-9)");
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<gvec2<string>>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

}
