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
            var v = new gvec4<string>("((-4-3)9)");
            Assert.That("((-4-3)9)", Is.EqualTo(v.x));
            Assert.That("((-4-3)9)", Is.EqualTo(v.y));
            Assert.That("((-4-3)9)", Is.EqualTo(v.z));
            Assert.That("((-4-3)9)", Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>("((86)9)", "9", "null", "null");
            Assert.That("((86)9)", Is.EqualTo(v.x));
            Assert.That("9", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>(new gvec2<string>("", "((-4-3)7)"));
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-4-3)7)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>(new gvec3<string>("(51)", "", "-3"));
            Assert.That("(51)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("-3", Is.EqualTo(v.z));
            Assert.That("null", Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>(new gvec4<string>("null", "((0-5)-3)", "null", "((0-5)-3)"));
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("((0-5)-3)", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
            Assert.That("((0-5)-3)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new gvec4<string>("(-7-1)", "((32)6)", "5", "5");
        Assert.That("(-7-1)", Is.EqualTo(v[0]));
        Assert.That("((32)6)", Is.EqualTo(v[1]));
        Assert.That("5", Is.EqualTo(v[2]));
        Assert.That("5", Is.EqualTo(v[3]));
        
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
        
        v[3] = "null";
        Assert.That("null", Is.EqualTo(v[3]));
        v[3] = "";
        Assert.That("", Is.EqualTo(v[3]));
        v[0] = "9";
        Assert.That("9", Is.EqualTo(v[0]));
        v[0] = "(-7-8)";
        Assert.That("(-7-8)", Is.EqualTo(v[0]));
        v[2] = "((01)7)";
        Assert.That("((01)7)", Is.EqualTo(v[2]));
        v[1] = "-7";
        Assert.That("-7", Is.EqualTo(v[1]));
        v[0] = "(3-9)";
        Assert.That("(3-9)", Is.EqualTo(v[0]));
        v[1] = "((2-5)0)";
        Assert.That("((2-5)0)", Is.EqualTo(v[1]));
        v[2] = "6";
        Assert.That("6", Is.EqualTo(v[2]));
        v[1] = "(-72)";
        Assert.That("(-72)", Is.EqualTo(v[1]));
        v[3] = "((-35)-3)";
        Assert.That("((-35)-3)", Is.EqualTo(v[3]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new gvec4<string>("(69)", "", "((-86)0)", "-1");
        var vals = v.Values;
        Assert.That("(69)", Is.EqualTo(vals[0]));
        Assert.That("", Is.EqualTo(vals[1]));
        Assert.That("((-86)0)", Is.EqualTo(vals[2]));
        Assert.That("-1", Is.EqualTo(vals[3]));
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
        var v1 = new gvec4<string>("(-7-2)", "(6-9)", "-7", "(-19)");
        var v2 = new gvec4<string>("(-7-2)", "(6-9)", "-7", "(-19)");
        var v3 = new gvec4<string>("(-19)", "-7", "(6-9)", "(-7-2)");
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
        var v = new gvec4<string>("null", "(9-7)", "(-2-9)", "((6-4)7)");
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new gvec4<string>("((2-7)-3)", "null", "", "((2-7)-3)");
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<gvec4<string>>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

}
