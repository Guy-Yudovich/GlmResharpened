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
            var v = new gvec3<string>("(-48)");
            Assert.That("(-48)", Is.EqualTo(v.x));
            Assert.That("(-48)", Is.EqualTo(v.y));
            Assert.That("(-48)", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>(null, "((-7-9)-9)", "((-7-9)-9)");
            Assert.That(null, Is.EqualTo(v.x));
            Assert.That("((-7-9)-9)", Is.EqualTo(v.y));
            Assert.That("((-7-9)-9)", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>(new gvec2<string>("(-98)", "2"));
            Assert.That("(-98)", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
            Assert.That(null, Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>(new gvec3<string>("2", "((9-3)9)", "((-4-8)9)"));
            Assert.That("2", Is.EqualTo(v.x));
            Assert.That("((9-3)9)", Is.EqualTo(v.y));
            Assert.That("((-4-8)9)", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>(new gvec4<string>("((47)4)", "((-9-5)4)", "((-9-5)4)", null));
            Assert.That("((47)4)", Is.EqualTo(v.x));
            Assert.That("((-9-5)4)", Is.EqualTo(v.y));
            Assert.That("((-9-5)4)", Is.EqualTo(v.z));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new gvec3<string>("((58)-3)", "2", "((58)-3)");
        Assert.That("((58)-3)", Is.EqualTo(v[0]));
        Assert.That("2", Is.EqualTo(v[1]));
        Assert.That("((58)-3)", Is.EqualTo(v[2]));
        
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = null; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = null; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = null; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = null; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
        Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = null; } );
        
        v[2] = null;
        Assert.That(null, Is.EqualTo(v[2]));
        v[2] = "";
        Assert.That("", Is.EqualTo(v[2]));
        v[0] = "-3";
        Assert.That("-3", Is.EqualTo(v[0]));
        v[0] = "(-61)";
        Assert.That("(-61)", Is.EqualTo(v[0]));
        v[1] = "((8-6)0)";
        Assert.That("((8-6)0)", Is.EqualTo(v[1]));
        v[2] = "-7";
        Assert.That("-7", Is.EqualTo(v[2]));
        v[2] = "(73)";
        Assert.That("(73)", Is.EqualTo(v[2]));
        v[0] = "((0-7)8)";
        Assert.That("((0-7)8)", Is.EqualTo(v[0]));
        v[0] = "9";
        Assert.That("9", Is.EqualTo(v[0]));
        v[0] = "(-6-7)";
        Assert.That("(-6-7)", Is.EqualTo(v[0]));
        v[0] = "((-7-5)-1)";
        Assert.That("((-7-5)-1)", Is.EqualTo(v[0]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new gvec3<string>("(7-4)", "-6", "");
        var vals = v.Values;
        Assert.That("(7-4)", Is.EqualTo(vals[0]));
        Assert.That("-6", Is.EqualTo(vals[1]));
        Assert.That("", Is.EqualTo(vals[2]));
        Assert.That(vals.SequenceEqual(v.ToArray()));
    }

    [Test]
    public void StaticProperties()
    {
        Assert.That(null, Is.EqualTo(gvec3<string>.Zero.x));
        Assert.That(null, Is.EqualTo(gvec3<string>.Zero.y));
        Assert.That(null, Is.EqualTo(gvec3<string>.Zero.z));
    }

    [Test]
    public void Operators()
    {
        var v1 = new gvec3<string>("((-1-1)-8)", "", null);
        var v2 = new gvec3<string>("((-1-1)-8)", "", null);
        var v3 = new gvec3<string>(null, "", "((-1-1)-8)");
        Assert.That((v1 == new gvec3<string>(v1)).AllTrue);
        Assert.That((v2 == new gvec3<string>(v2)).AllTrue);
        Assert.That((v3 == new gvec3<string>(v3)).AllTrue);
        Assert.That((v1 == v2).AllTrue);
        Assert.That((v1 != v3).AllTrue);
        Assert.That((v2 != v3).AllTrue);
    }

    [Test]
    public void StringInterop()
    {
        var v = new gvec3<string>("((2-6)9)", "(-81)", "((09)-8)");
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new gvec3<string>("", "((-29)1)", "8");
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<gvec3<string>>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

}
