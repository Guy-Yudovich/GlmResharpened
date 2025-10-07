# GlmResharpened

Open-source MIT-licensed C#/.NET math library for small vectors and matrices.

Forked from [Philip Trettner's GlmSharp](https://github.com/Philip-Trettner/GlmSharp), and migrated from .NET Framework 2+ to .NET 8.0+.

## Example

```C#
vec3 v = new vec3(0, 1, 0);
vec3 left = vec3.Cross(v, new vec3(2f));

mat4 view = mat4.LookAt(vec3.Ones, vec3.Zero, vec3.UnitY);
vec4 v4 = view.Inverse * new vec4(v, 0f);

v4 *= glm.Smoothstep(0.2f, 0.4f, v.Length);

string s = v4.ToString();
vec4 vv = vec4.Parse(s);

vv.xy = v.swizzle.yy;
```

## NuGet

Coming soon.
For the original GlmSharp, install via [NuGet](https://www.nuget.org/packages/GlmSharp/)

Current version: _1.0.0_

## Overview

Supported types:
* `vec2`
* `vec3`
* `vec4`
* `mat2`
* `mat3`
* `mat4`
* `quat`
* non-quadratic mats (`mat2x3`, `mat2x4`, `mat3x4`, `mat3x2`, `mat4x2`, `mat4x3`)

Supported base types:
* `int` (`ivec`)
* `uint` (`uvec`)
* `long` (`lvec`)
* `float` (`vec`)
* `double` (`dvec`)
* `decimal` (`decvec`)
* `System.Numerics.Complex` (`cvec`)
* `long` (`lvec`)
* `bool` (`bvec`)
* `Half` (`hvec`)
* generic `T` (`gvec<T>`)

(Currently a total of 160 types in about 60k Lines of Executable Code)

Supports read-only swizzling, e.g. `v.swizzle.bgr` (or equivalently `v.swizzle.zyx`).
Supports read-write inline-swizzling, e.g. `v.zw = v.yx`.

## Syntax, Usage

Instead of introducing a `glm` namespace, GlmResharpened puts most functions in the respective type.
For example, `glm.dot(v1, v2)` for `vec3` is now `vec3.Dot(v1, v2)`.
The static class `glm` also provides most functionality in form of static functions, including operations on base types.

## Requirements

The code is written using C# 12 features, the NuGet package requires .NET 8.0.

## Features

* Arithmetic type support: `int`, `uint`, `long`, `float`, `double`, `decimal`
* Boolean vectors, matrices
* `System.Numerics.Complex` support
* Generic `gvec<T>, gmat<T>` support
* Swizzling
* Basetype constants are propagated (`double.Epsilon` => `dvec3.Epsilon`)
* Basetype functions are propagated
* Performance considerations
* Extensive operator overloading
* Proper `ToString`, `Parse`, `TryParse` for vectors (including format providers)
* Most `Math` and basetype functions work component-wise for vectors (e.g. `float.IsInfinite(v)` => `vec3.IsInfinite(v)`)
* Vectors and matrices implement `IReadOnlyList<>` and `IEquatable<>`
* Various constructors and explicit casts for vectors and matrices
* Implicit casts for vectors where base types can be casted implicitly
* Radians-only lib
* Serialization via `[Serializable]`, `[DataContract]` and `[DataMember]` (and thus [Json.NET](https://github.com/JamesNK/Newtonsoft.Json))
* Marshalling via `[StructLayout(LayoutKind.Sequential)]`
* Quaternions
* Support for .NET 8.0 and above
* Aggregated functionality in static `glm` class
* Support for 16-bit floating points (using [system.Half]([http://sourceforge.net/projects/csharp-half/](https://learn.microsoft.com/en-us/dotnet/api/system.half?view=net-8.0)))

### Swizzling

In theory, each swizzle string ('xyz') could be implemented as a property in the respective vector struct.
However, this absolutely spams Intellisense (706 combinations for vec4). (Extension methods are not solution either as tools like Resharper show all available methods.)

Thus, swizzling is implemented as a swizzle surrogate type (e.g. `swizzle_vec4`) that has all combinations as properties.
Each vector type has a `swizzle` property that returns an instance of the surrogate type.
Therefore, swizzling becomes `v.swizzle.xz`.

Swizzling is generated for `xyzw` and `rgba`.

Read-write inline-swizzling is supported. All ordered subsets of components can now be read and set, e.g. `v2.xzw = new vec3(v1.yx, 1f)`.

### Performance consideration

All vectors and matrices are value-types and contain all components directly. (A matrix is not an array of vectors.)
These types are therefore suited for serialization and marshalling.

Most functions are "rolled out" by the generator and should therefore have minimal overhead.

## License

This library is MIT-licensed.

## TODO-List

* generic math support for all classes
* test generation
* ToString, Parse, TryParse for matrices
* some GLU functions (e.g. PickMatrix)
* advanced glsl/glm functions
* extensive documentation (parameters, return values, formulas)
* noise functions
* random extensions
* explicit JSON support
* matrix column/row setter
* base type glm classes
