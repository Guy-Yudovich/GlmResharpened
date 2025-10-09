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
            var v = new gvec3<string>("((59)-4)");
            Assert.That("((59)-4)", Is.EqualTo(v.x));
            Assert.That("((59)-4)", Is.EqualTo(v.y));
            Assert.That("((59)-4)", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>("(-34)", "", "(1-9)");
            Assert.That("(-34)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
            Assert.That("(1-9)", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>(new gvec2<string>("((-2-5)7)", "5"));
            Assert.That("((-2-5)7)", Is.EqualTo(v.x));
            Assert.That("5", Is.EqualTo(v.y));
            Assert.That("null", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>(new gvec3<string>("-8", "((6-6)-2)", "((-47)-3)"));
            Assert.That("-8", Is.EqualTo(v.x));
            Assert.That("((6-6)-2)", Is.EqualTo(v.y));
            Assert.That("((-47)-3)", Is.EqualTo(v.z));
        }
        {
            var v = new gvec3<string>(new gvec4<string>("((80)2)", "((1-9)4)", "((00)4)", "7"));
            Assert.That("((80)2)", Is.EqualTo(v.x));
            Assert.That("((1-9)4)", Is.EqualTo(v.y));
            Assert.That("((00)4)", Is.EqualTo(v.z));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new gvec3<string>("5", "((84)-9)", "5");
        Assert.That("5", Is.EqualTo(v[0]));
        Assert.That("((84)-9)", Is.EqualTo(v[1]));
        Assert.That("5", Is.EqualTo(v[2]));
        
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
        
        v[2] = "null";
        Assert.That("null", Is.EqualTo(v[2]));
        v[0] = "";
        Assert.That("", Is.EqualTo(v[0]));
        v[0] = "0";
        Assert.That("0", Is.EqualTo(v[0]));
        v[2] = "(90)";
        Assert.That("(90)", Is.EqualTo(v[2]));
        v[2] = "((-98)-5)";
        Assert.That("((-98)-5)", Is.EqualTo(v[2]));
        v[0] = "8";
        Assert.That("8", Is.EqualTo(v[0]));
        v[1] = "(27)";
        Assert.That("(27)", Is.EqualTo(v[1]));
        v[0] = "((95)-2)";
        Assert.That("((95)-2)", Is.EqualTo(v[0]));
        v[0] = "1";
        Assert.That("1", Is.EqualTo(v[0]));
        v[1] = "(-5-9)";
        Assert.That("(-5-9)", Is.EqualTo(v[1]));
        v[0] = "((-39)2)";
        Assert.That("((-39)2)", Is.EqualTo(v[0]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new gvec3<string>("null", "(-15)", "6");
        var vals = v.Values;
        Assert.That("null", Is.EqualTo(vals[0]));
        Assert.That("(-15)", Is.EqualTo(vals[1]));
        Assert.That("6", Is.EqualTo(vals[2]));
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
        var v1 = new gvec3<string>("(9-2)", "4", "-3");
        var v2 = new gvec3<string>("(9-2)", "4", "-3");
        var v3 = new gvec3<string>("-3", "4", "(9-2)");
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
        var v = new gvec3<string>("null", "null", "(8-3)");
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new gvec3<string>("((1-9)-7)", "(54)", "(-8-7)");
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<gvec3<string>>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

}
