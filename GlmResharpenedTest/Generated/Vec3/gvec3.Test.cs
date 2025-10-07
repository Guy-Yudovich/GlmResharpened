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
public class TVec3Test
{

    [Test]
    public void Constructors()
    {
        {
            var v = new gvec3<string>("((-64)5)");
            Assert.That("((-64)5)", Is.EqualTo(v.x));
            Assert.That("((-64)5)", Is.EqualTo(v.y));
            Assert.That("((-64)5)", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>("-7", "", "1");
            Assert.That("-7", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>(new gvec2<string>("(6-9)", "((95)-8)"));
            Assert.That("(6-9)", Is.EqualTo(v.x));
            Assert.That("((95)-8)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>(new gvec3<string>("", "((0-5)6)", "0"));
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((0-5)6)", Is.EqualTo(v.y));
            Assert.That("0", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>(new gvec4<string>("(5-8)", "(5-8)", "1", "-4"));
            Assert.That("(5-8)", Is.EqualTo(v.x));
            Assert.That("(5-8)", Is.EqualTo(v.y));
            Assert.That("1", Is.EqualTo(v.z));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new gvec3<string>("1", "", "-7");
        Assert.That("1", Is.EqualTo(v[0]));
        Assert.That("", Is.EqualTo(v[1]));
        Assert.That("-7", Is.EqualTo(v[2]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = "null"; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = "null"; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = "null"; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = "null"; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = "null"; } );
        
        v[1] = "null";
        Assert.That("null", Is.EqualTo(v[1]));
        v[1] = "";
        Assert.That("", Is.EqualTo(v[1]));
        v[1] = "-1";
        Assert.That("-1", Is.EqualTo(v[1]));
        v[2] = "(1-5)";
        Assert.That("(1-5)", Is.EqualTo(v[2]));
        v[2] = "((-65)7)";
        Assert.That("((-65)7)", Is.EqualTo(v[2]));
        v[2] = "-4";
        Assert.That("-4", Is.EqualTo(v[2]));
        v[0] = "(-1-5)";
        Assert.That("(-1-5)", Is.EqualTo(v[0]));
        v[2] = "((63)-3)";
        Assert.That("((63)-3)", Is.EqualTo(v[2]));
        v[2] = "1";
        Assert.That("1", Is.EqualTo(v[2]));
        v[0] = "(79)";
        Assert.That("(79)", Is.EqualTo(v[0]));
        v[1] = "((-63)6)";
        Assert.That("((-63)6)", Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new gvec3<string>("((-2-8)9)", "4", "((99)-6)");
        var vals = v.Values;
        Assert.That("((-2-8)9)", Is.EqualTo(vals[0]));
        Assert.That("4", Is.EqualTo(vals[1]));
        Assert.That("((99)-6)", Is.EqualTo(vals[2]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That("null", Is.EqualTo(gvec3<string>.Zero.x));
        Assert.That("null", Is.EqualTo(gvec3<string>.Zero.y));
        Assert.That("null", Is.EqualTo(gvec3<string>.Zero.z));
    }

    [Test]
    public void Operators()
    {
        var v1 = new gvec3<string>("(-29)", "((1-3)-4)", "(-29)");
        var v2 = new gvec3<string>("(-29)", "((1-3)-4)", "(-29)");
        var v3 = new gvec3<string>("(-29)", "((1-3)-4)", "(-29)");
        Assert.That(v1 == new gvec3<string>(v1));
        Assert.That(v2 == new gvec3<string>(v2));
        Assert.That(v3 == new gvec3<string>(v3));
        Assert.That(v1 == v2);
        Assert.That(v1 != v3);
        Assert.That(v2 != v3);
    }

    [Test]
    public void StringInterop()
    {
        var v = new gvec3<string>("-8", "((-90)-4)", "-8");
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new gvec3<string>("", "null", "0");
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<gvec3<string>>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

}
