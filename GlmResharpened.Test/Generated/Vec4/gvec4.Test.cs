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
            var v = new gvec4<string>("-2");
            Assert.That("-2", Is.EqualTo(v.x));
            Assert.That("-2", Is.EqualTo(v.y));
            Assert.That("-2", Is.EqualTo(v.z));
            Assert.That("-2", Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>("((3-2)-1)", "3", "(6-1)", "");
            Assert.That("((3-2)-1)", Is.EqualTo(v.x));
            Assert.That("3", Is.EqualTo(v.y));
            Assert.That("(6-1)", Is.EqualTo(v.z));
            Assert.That("", Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>(new gvec2<string>("", "((-2-9)-9)"));
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("((-2-9)-9)", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>(new gvec3<string>("(-3-5)", "(-3-5)", "((75)0)"));
            Assert.That("(-3-5)", Is.EqualTo(v.x));
            Assert.That("(-3-5)", Is.EqualTo(v.y));
            Assert.That("((75)0)", Is.EqualTo(v.z));
            Assert.That(null, Is.EqualTo(v.w));
        }
        {
            var v = new gvec4<string>(new gvec4<string>("7", null, "2", "((-2-5)-2)"));
            Assert.That("7", Is.EqualTo(v.x));
            Assert.That(null, Is.EqualTo(v.y));
            Assert.That("2", Is.EqualTo(v.z));
            Assert.That("((-2-5)-2)", Is.EqualTo(v.w));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new gvec4<string>("((-9-2)-5)", "-5", "-5", "((-6-1)-4)");
        Assert.That("((-9-2)-5)", Is.EqualTo(v[0]));
        Assert.That("-5", Is.EqualTo(v[1]));
        Assert.That("-5", Is.EqualTo(v[2]));
        Assert.That("((-6-1)-4)", Is.EqualTo(v[3]));
        
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
        
        v[0] = null;
        Assert.That(null, Is.EqualTo(v[0]));
        v[2] = "";
        Assert.That("", Is.EqualTo(v[2]));
        v[2] = "-9";
        Assert.That("-9", Is.EqualTo(v[2]));
        v[3] = "(08)";
        Assert.That("(08)", Is.EqualTo(v[3]));
        v[3] = "((9-3)4)";
        Assert.That("((9-3)4)", Is.EqualTo(v[3]));
        v[2] = "-9";
        Assert.That("-9", Is.EqualTo(v[2]));
        v[2] = "(7-6)";
        Assert.That("(7-6)", Is.EqualTo(v[2]));
        v[3] = "((-8-2)-6)";
        Assert.That("((-8-2)-6)", Is.EqualTo(v[3]));
        v[2] = "-8";
        Assert.That("-8", Is.EqualTo(v[2]));
        v[2] = "(39)";
        Assert.That("(39)", Is.EqualTo(v[2]));
        v[1] = "((4-8)-6)";
        Assert.That("((4-8)-6)", Is.EqualTo(v[1]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new gvec4<string>("((-95)1)", "3", "2", "(47)");
        var vals = v.Values;
        Assert.That("((-95)1)", Is.EqualTo(vals[0]));
        Assert.That("3", Is.EqualTo(vals[1]));
        Assert.That("2", Is.EqualTo(vals[2]));
        Assert.That("(47)", Is.EqualTo(vals[3]));
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
        var v1 = new gvec4<string>("(90)", "", "((5-4)-9)", "(3-1)");
        var v2 = new gvec4<string>("(90)", "", "((5-4)-9)", "(3-1)");
        var v3 = new gvec4<string>("(3-1)", "((5-4)-9)", "", "(90)");
        Assert.That((v1 == new gvec4<string>(v1)).AllTrue);
        Assert.That((v2 == new gvec4<string>(v2)).AllTrue);
        Assert.That((v3 == new gvec4<string>(v3)).AllTrue);
        Assert.That((v1 == v2).AllTrue);
        Assert.That((v1 != v3).AllTrue);
        Assert.That((v2 != v3).AllTrue);
    }

    [Test]
    public void StringInterop()
    {
        var v = new gvec4<string>("((19)4)", "(-92)", "(3-4)", "((-19)-5)");
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new gvec4<string>(null, "((-24)-7)", "(-9-7)", "1");
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<gvec4<string>>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

}
