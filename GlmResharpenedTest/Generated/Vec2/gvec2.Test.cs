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
            var v = new gvec2<string>("((09)-9)");
            Assert.That("((09)-9)", Is.EqualTo(v.x));
            Assert.That("((09)-9)", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>("7", "((-5-7)-2)");
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("((-5-7)-2)", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>(new gvec2<string>("((-81)-9)", "(4-9)"));
            Assert.That("((-81)-9)", Is.EqualTo(v.x));
            Assert.That("(4-9)", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>(new gvec3<string>("((-62)0)", "(-10)", "null"));
            Assert.That("((-62)0)", Is.EqualTo(v.x));
            Assert.That("(-10)", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>(new gvec4<string>("", "9", "", "((8-2)-2)"));
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new gvec2<string>("(29)", "((17)-1)");
        Assert.That("(29)", Is.EqualTo(v[0]));
        Assert.That("((17)-1)", Is.EqualTo(v[1]));
        
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
        v[1] = "";
        Assert.That("", Is.EqualTo(v[1]));
        v[0] = "4";
        Assert.That("4", Is.EqualTo(v[0]));
        v[1] = "(0-2)";
        Assert.That("(0-2)", Is.EqualTo(v[1]));
        v[1] = "((-29)6)";
        Assert.That("((-29)6)", Is.EqualTo(v[1]));
        v[1] = "-7";
        Assert.That("-7", Is.EqualTo(v[1]));
        v[0] = "(78)";
        Assert.That("(78)", Is.EqualTo(v[0]));
        v[0] = "((-63)0)";
        Assert.That("((-63)0)", Is.EqualTo(v[0]));
        v[1] = "4";
        Assert.That("4", Is.EqualTo(v[1]));
        v[1] = "(26)";
        Assert.That("(26)", Is.EqualTo(v[1]));
        v[0] = "((4-8)1)";
        Assert.That("((4-8)1)", Is.EqualTo(v[0]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new gvec2<string>("((52)-4)", "-4");
        var vals = v.Values;
        Assert.That("((52)-4)", Is.EqualTo(vals[0]));
        Assert.That("-4", Is.EqualTo(vals[1]));
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
        var v1 = new gvec2<string>("4", "-3");
        var v2 = new gvec2<string>("4", "-3");
        var v3 = new gvec2<string>("-3", "4");
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
        var v = new gvec2<string>("", "4");
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new gvec2<string>("(-65)", "4");
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<gvec2<string>>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

}
