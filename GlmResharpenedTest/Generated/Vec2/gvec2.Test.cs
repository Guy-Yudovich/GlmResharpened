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
            var v = new gvec2<string>("null");
            Assert.That("null", Is.EqualTo(v.x));
            Assert.That("null", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>("(-94)", "");
            Assert.That("(-94)", Is.EqualTo(v.x));
            Assert.That("", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>(new gvec2<string>("", "4"));
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("4", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>(new gvec3<string>("((19)6)", "((-60)3)", "null"));
            Assert.That("((19)6)", Is.EqualTo(v.x));
            Assert.That("((-60)3)", Is.EqualTo(v.y));
        }
        {
            var v = new gvec2<string>(new gvec4<string>("", "2", "(25)", ""));
            Assert.That("", Is.EqualTo(v.x));
            Assert.That("2", Is.EqualTo(v.y));
        }
    }

    [Test]
    public void Indexer()
    {
        var v = new gvec2<string>("-6", "1");
        Assert.That("-6", Is.EqualTo(v[0]));
        Assert.That("1", Is.EqualTo(v[1]));
        
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
        v[1] = "-1";
        Assert.That("-1", Is.EqualTo(v[1]));
        v[1] = "(7-2)";
        Assert.That("(7-2)", Is.EqualTo(v[1]));
        v[0] = "((-3-3)-1)";
        Assert.That("((-3-3)-1)", Is.EqualTo(v[0]));
        v[0] = "0";
        Assert.That("0", Is.EqualTo(v[0]));
        v[1] = "(1-7)";
        Assert.That("(1-7)", Is.EqualTo(v[1]));
        v[1] = "((6-2)-4)";
        Assert.That("((6-2)-4)", Is.EqualTo(v[1]));
        v[0] = "2";
        Assert.That("2", Is.EqualTo(v[0]));
        v[1] = "(-91)";
        Assert.That("(-91)", Is.EqualTo(v[1]));
        v[0] = "((-48)-2)";
        Assert.That("((-48)-2)", Is.EqualTo(v[0]));
    }

    [Test]
    public void PropertyValues()
    {
        var v = new gvec2<string>("(-6-9)", "((-8-1)-2)");
        var vals = v.Values;
        Assert.That("(-6-9)", Is.EqualTo(vals[0]));
        Assert.That("((-8-1)-2)", Is.EqualTo(vals[1]));
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
        var v1 = new gvec2<string>("6", "(-63)");
        var v2 = new gvec2<string>("6", "(-63)");
        var v3 = new gvec2<string>("(-63)", "6");
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
        var v = new gvec2<string>("((5-5)-3)", "(-85)");
        
        var s0 = v.ToString();
        var s1 = v.ToString("#");
    }

    [Test]
    public void SerializationJson()
    {
        var v0 = new gvec2<string>("(17)", "((-60)-7)");
        var s0 = JsonConvert.SerializeObject(v0);
        
        var v1 = JsonConvert.DeserializeObject<gvec2<string>>(s0);
        var s1 = JsonConvert.SerializeObject(v1);
        
        Assert.That(v0, Is.EqualTo(v1));
        Assert.That(s0, Is.EqualTo(s1));
    }

}
