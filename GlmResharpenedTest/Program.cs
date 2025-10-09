using System;
using System.Numerics;

using GlmResharpened;

namespace GlmResharpenedTest;

internal class Program
{
	private static void Main()
	{
		var v = new vec4();
		var vv = v.swizzle.zxy;
		var unused = vv.swizzle.bgr;
		var iv = (ivec2)v;

		iv += 2;
		iv /= 3;
		iv *= iv;
		var unused1 = 2 + iv;

		var g = vec3.UnitY;
		g = g.Normalized * 3;

		cvec3 cg = g;

		Complex c = 1.0;
		// FIXME: Upcasting
		//vec2 fv = iv * 1f;
		//dvec2 dv = iv * 1.0;
		//dv += c.Imaginary;

		//cvec4 cv = v * c;
		//c.Magnitude
		var cv = cvec4.ImaginaryOnes;

		var acv = cvec4.Abs(cv);
		var unused2 = dvec4.Tanh(acv);

		_ = bvec2.Parse("true, false");

		double d;
		_ = double.TryParse("1", out d);

		var gbvec = new gvec4<bool>(true, false, true, false);
		var gsvec = new gvec3<string>("", "", null);
		var gpvec = new gvec2<Program>(null, null);
		var gopvec = new gvec2<object>(null, null);
		var gtpvec = new gvec3<Type>(typeof(int), 1.GetType(), "".GetType());
	}
}
