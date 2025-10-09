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
            var v = new gvec4<string>("((97)-8)");
            Assert.That("((97)-8)", Is.EqualTo(v.x));
            Assert.That("((97)-8)", Is.EqualTo(v.y));
            Assert.That("((97)-8)", Is.EqualTo(v.z));
            Assert.That("((97)-8)", Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>("((-77)-1)", "((-77)-1)", "-8", "-2");
            Assert.That("((-77)-1)", Is.EqualTo(v.x));
            Assert.That("((-77)-1)", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>(new gvec2<string>("((-11)-5)", "-9"));
            Assert.That("((-11)-5)", Is.EqualTo(v.x));
            Assert.That("-9", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>(new gvec3<string>("(91)", "", "(91)"));
            Assert.That("(91)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(91)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>(new gvec4<string>("((-7-8)-5)", "(-43)", "((-22)9)", "-6"));
            Assert.That("((-7-8)-5)", Is.EqualTo(v.x));
            Assert.That("(-43)", Is.EqualTo(v.y));
            Assert.That("((-22)9)", Is.EqualTo(v.z));
            Assert.That("-6", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new gvec4<string>("(-6-4)", null, "((35)6)", null);
        Assert.That("(-6-4)", Is.EqualTo(v[0]));
        Assert.That(null, Is.EqualTo(v[1]));
        Assert.That("((35)6)", Is.EqualTo(v[2]));
        Assert.That(null, Is.EqualTo(v[3]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = null; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = null; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = null; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = null; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = null; } );
        
        v[1] = null;
        Assert.That(null, Is.EqualTo(v[1]));
        v[0] = "";
        Assert.That("", Is.EqualTo(v[0]));
        v[2] = "6";
        Assert.That("6", Is.EqualTo(v[2]));
        v[3] = "(-77)";
        Assert.That("(-77)", Is.EqualTo(v[3]));
        v[1] = "((-16)6)";
        Assert.That("((-16)6)", Is.EqualTo(v[1]));
        v[2] = "-8";
        Assert.That("-8", Is.EqualTo(v[2]));
        v[3] = "(-6-7)";
        Assert.That("(-6-7)", Is.EqualTo(v[3]));
        v[0] = "((6-1)3)";
        Assert.That("((6-1)3)", Is.EqualTo(v[0]));
        v[3] = "7";
        Assert.That("7", Is.EqualTo(v[3]));
        v[0] = "(-43)";
        Assert.That("(-43)", Is.EqualTo(v[0]));
        v[0] = "((76)-6)";
        Assert.That("((76)-6)", Is.EqualTo(v[0]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new gvec4<string>("", "(-3-6)", "(-22)", "(-3-6)");
        var vals = v.Values;
        Assert.That("", Is.EqualTo(vals[0]));
        Assert.That("(-3-6)", Is.EqualTo(vals[1]));
        Assert.That("(-22)", Is.EqualTo(vals[2]));
        Assert.That("(-3-6)", Is.EqualTo(vals[3]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(null, Is.EqualTo(gvec4<string>.Zero.x));
        Assert.That(null, Is.EqualTo(gvec4<string>.Zero.y));
        Assert.That(null, Is.EqualTo(gvec4<string>.Zero.z));
        Assert.That(null, Is.EqualTo(gvec4<string>.Zero.w));
    }

    [Test]
    public void Operators()
    {
        var v1 = new gvec4<string>("", "2", "2", "((8-3)6)");
        var v2 = new gvec4<string>("", "2", "2", "((8-3)6)");
        var v3 = new gvec4<string>("((8-3)6)", "2", "2", "");
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
        var v = new gvec4<string>("8", null, "((1-1)-4)", "(16)");
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new gvec4<string>("", "(5-4)", "((22)6)", "((81)1)");
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<gvec4<string>>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

}
