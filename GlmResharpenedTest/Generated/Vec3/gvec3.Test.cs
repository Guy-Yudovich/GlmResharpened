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
            var v = new gvec3<string>("null");
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>("(0-8)", "-2", "((-85)0)");
            Assert.That("(0-8)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("((-85)0)", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>(new gvec2<string>("(-7-1)", "-2"));
            Assert.That("(-7-1)", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>(new gvec3<string>("7", "", "(2-6)"));
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(2-6)", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>(new gvec4<string>("-8", "-8", "-8", "-8"));
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("-8", Is.EqualTo(v.y));
            Assert.That("-8", Is.EqualTo(v.z));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new gvec3<string>("((-97)-2)", "(09)", "(09)");
        Assert.That("((-97)-2)", Is.EqualTo(v[0]));
        Assert.That("(09)", Is.EqualTo(v[1]));
        Assert.That("(09)", Is.EqualTo(v[2]));
        
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
        v[2] = "";
        Assert.That("", Is.EqualTo(v[2]));
        v[1] = "1";
        Assert.That("1", Is.EqualTo(v[1]));
        v[0] = "(59)";
        Assert.That("(59)", Is.EqualTo(v[0]));
        v[0] = "((-98)-2)";
        Assert.That("((-98)-2)", Is.EqualTo(v[0]));
        v[2] = "-4";
        Assert.That("-4", Is.EqualTo(v[2]));
        v[0] = "(7-9)";
        Assert.That("(7-9)", Is.EqualTo(v[0]));
        v[2] = "((67)-6)";
        Assert.That("((67)-6)", Is.EqualTo(v[2]));
        v[1] = "3";
        Assert.That("3", Is.EqualTo(v[1]));
        v[2] = "(4-3)";
        Assert.That("(4-3)", Is.EqualTo(v[2]));
        v[1] = "((-6-9)3)";
        Assert.That("((-6-9)3)", Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new gvec3<string>("(6-7)", "(-63)", "((32)8)");
        var vals = v.Values;
        Assert.That("(6-7)", Is.EqualTo(vals[0]));
        Assert.That("(-63)", Is.EqualTo(vals[1]));
        Assert.That("((32)8)", Is.EqualTo(vals[2]));
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
        var v1 = new gvec3<string>("0", "((-5-2)-7)", "((41)6)");
        var v2 = new gvec3<string>("0", "((-5-2)-7)", "((41)6)");
        var v3 = new gvec3<string>("((41)6)", "((-5-2)-7)", "0");
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
        var v = new gvec3<string>("((-15)9)", "", "");
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new gvec3<string>("-1", "((0-7)8)", "((-32)-1)");
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<gvec3<string>>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

}
