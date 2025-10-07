﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

using GlmResharpenedGenerator.Members;
using GlmResharpenedGenerator.Tests;

using GlmResharpenedGenerator.Types;

namespace GlmResharpenedGenerator.Types
{
	abstract class AbstractType
	{
		/// <summary>
		/// true iff test generation is active
		/// </summary>
		public static bool TestMode { get; set; }

		/// <summary>
		/// Random
		/// </summary>
		public static Random Random = new Random(1234);

		/// <summary>
		/// All known types
		/// </summary>
		public static readonly Dictionary<string, AbstractType> Types = new Dictionary<string, AbstractType>();

		/// <summary>
		/// Math class prefix
		/// </summary>
		public virtual string MathClass => BaseType?.MathClass;

		/// <summary>
		/// Base name (e.g. vec, mat, quat)
		/// </summary>
		public string BaseName { get; set; } = "vec";
		/// <summary>
		/// Name of the base type
		/// </summary>
		public string BaseTypeName => BaseType.Name;
		/// <summary>
		/// Cast to base type
		/// </summary>
		public string BaseTypeCast => "(" + BaseTypeName + ")";
		/// <summary>
		/// Actual name of the type (e.g. the C# class name)
		/// </summary>
		public abstract string Name { get; }
		/// <summary>
		/// Name used for parameter types (for generics has T)
		/// </summary>
		public string NameThat => Name + GenericSuffix;
		/// <summary>
		/// Suffix for generic types
		/// </summary>
		public virtual string GenericSuffix => BaseType?.Generic ?? false ? TestMode ? "<string>" : "<T>" : "";
		/// <summary>
		/// Reference to base type
		/// </summary>
		public BuiltinType BaseType { get; set; }

		/// <summary>
		/// Namespace of this type
		/// </summary>
		public virtual string Namespace { get; } = "GlmResharpened";

		/// <summary>
		/// Additional arg for data contracts
		/// </summary>
		public virtual string DataContractArg { get; } = "";

		/// <summary>
		/// Folder for this type
		/// </summary>
		public virtual string Folder { get; } = "";
		/// <summary>
		/// Class name for tests
		/// </summary>
		public virtual string TestClassName => BaseTypeName.Capitalized() + Folder.Replace('/', '_').Replace('\\', '_') + "Test";
		/// <summary>
		/// Folder with trailing /
		/// </summary>
		public string ClassPathOf(string basePath) => string.IsNullOrEmpty(Folder) ? Path.Combine(basePath, Name + ".cs") : Path.Combine(basePath, Folder, Name + ".cs");
		public string GlmPathOf(string basePath) => string.IsNullOrEmpty(Folder) ? Path.Combine(basePath, Name + ".cs") : Path.Combine(basePath, Folder, Name + ".glm.cs");
		public string TestPathOf(string basePath) => string.IsNullOrEmpty(Folder) ? Path.Combine(basePath, Name + ".cs") : Path.Combine(basePath, Folder, Name + ".Test.cs");

		/// <summary>
		/// Comment of this type
		/// </summary>
		public abstract string TypeComment { get; }

		/// <summary>
		/// List of C# base classes (mostly interfaces)
		/// </summary>
		public virtual IEnumerable<string> BaseClasses { get { yield break; } }

		/// <summary>
		/// All members
		/// </summary>
		private Member[] members;
		private Field[] fields;
		private Constructor[] constructors;
		private Property[] properties;
		private Property[] staticProperties;
		private ImplicitOperator[] implicitOperators;
		private ExplicitOperator[] explicitOperators;
		private Operator[] operators;
		private Function[] functions;
		private Function[] staticFunctions;
		private Indexer[] indexer;
		private ComponentWiseStaticFunction[] componentWiseStaticFunctions;
		private ComponentWiseOperator[] componentWiseOp;
		private Member[] glmMembers;

		/// <summary>
		/// Generate all members
		/// </summary>
		public abstract IEnumerable<Member> GenerateMembers();

		/// <summary>
		/// Generates type members and sorts them
		/// </summary>
		public void Generate()
		{
			members = GenerateMembers().ToArray();

			if (members.Any(m => string.IsNullOrEmpty(m.Comment)))
				throw new InvalidOperationException("Missing comment");

			foreach (var member in members)
				member.OriginalType = this;

			fields = members.OfType<Field>().ToArray();
			constructors = members.OfType<Constructor>().ToArray();
			properties = members.Where(m => !m.Static).OfType<Property>().ToArray();
			staticProperties = members.Where(m => m.Static).OfType<Property>().ToArray();
			implicitOperators = members.OfType<ImplicitOperator>().ToArray();
			explicitOperators = members.OfType<ExplicitOperator>().ToArray();
			operators = members.OfType<Operator>().ToArray();
			functions = members.Where(m => !m.Static && m.GetType() == typeof(Function)).OfType<Function>().ToArray();
			staticFunctions = members.Where(m => m.Static && m.GetType() == typeof(Function)).OfType<Function>().ToArray();
			indexer = members.OfType<Indexer>().ToArray();
			componentWiseStaticFunctions = members.OfType<ComponentWiseStaticFunction>().ToArray();
			componentWiseOp = members.OfType<ComponentWiseOperator>().ToArray();

			glmMembers = members.SelectMany(m => m.GlmMembers()).ToArray();
		}

		/// <summary>
		/// Constructs an object of a given type
		/// </summary>
		public string Construct(AbstractType type, IEnumerable<string> args) => $"new {type.NameThat}({args.CommaSeparated()})";
		/// <summary>
		/// Constructs an object of a given type
		/// </summary>
		public string Construct(AbstractType type, params string[] args) => $"new {type.NameThat}({args.CommaSeparated()})";

		/// <summary>
		/// Generate tests for this class
		/// </summary>
		public virtual IEnumerable<TestFunc> GenerateTests() { yield break; }

		public void ResetRandom(int x)
		{
			Random = new Random(x + TestClassName.GetHashCode());
		}

		private static IEnumerable<string> MembersRegion(Member[] members, string regionName, int indent)
		{
			if (members.Length == 0)
				yield break;

			yield return $"#region {regionName}".Indent(indent);
			foreach (var member in members)
				foreach (var line in member.Lines)
					yield return line.Indent(indent);
			yield return $"#endregion".Indent(indent);
		}

		private static IEnumerable<string> MembersRegions(int indent, params (Member[] members, string regionName)[] regions)
		{
			var first = true;
			foreach (var (members, regionName) in regions)
			{
				if (members.Length == 0)
					continue;
				if (!first)
					yield return "";
				first = false;
				foreach (var line in MembersRegion(members, regionName, indent))
					yield return line;
			}
		}

		private static IEnumerable<string> FileHeaderLines(string @namespace, bool isTests = false)
		{
			yield return "#pragma warning disable";
			yield return "using System;";
			yield return "using System.Collections;";
			yield return "using System.Collections.Generic;";
			yield return "using System.Globalization;";
			yield return "using System.Runtime.InteropServices;";
			yield return "using System.Runtime.Serialization;";
			yield return "using System.Numerics;";
			yield return "using System.Linq;";
			if (isTests)
			{
				yield return "using NUnit.Framework;";
				yield return "using Newtonsoft.Json;";
			}
			yield return "using GlmResharpened;";
			yield return "using GlmResharpened.Swizzle;";
			yield return "";
			yield return $"namespace {@namespace};";
			yield return "";
		}

		public bool HasClassFile => members.Length - glmMembers.Length > 0;

		public IEnumerable<string> ClassFile
		{
			get
			{
				var baseClasses = BaseClasses.ToArray();

				foreach (var line in FileHeaderLines(Namespace))
					yield return line;

				foreach (var line in TypeComment.AsComment())
					yield return line.Indent(0);
				yield return "[Serializable]";
				yield return $"[DataContract{DataContractArg}]";
				yield return "[StructLayout(LayoutKind.Sequential)]";
				yield return "public struct " + Name + GenericSuffix + (baseClasses.Length == 0 ? "" : " : " + baseClasses.CommaSeparated());
				yield return "{";

				foreach (var line in MembersRegions(
					1,
					(fields, "Fields"),
					(properties, "Properties"),
					(indexer, "Indexer"),
					(constructors, "Constructors"),
					(functions, "Functions"),
					(operators, "Operators"),
					(staticProperties, "Static Properties"),
					(staticFunctions, "Static Functions"),
					(componentWiseStaticFunctions, "Component-Wise Static Functions"),
					(componentWiseOp, "Component-Wise Operator Overloads"),
					(implicitOperators, "Implicit Operators"),
					(explicitOperators, "Explicit Operators")
				))
					yield return line;

				foreach (var line in Body)
					yield return line.Indent(1);
				yield return "}";
			}
		}

		public bool HasGlmFile => glmMembers.Length > 0;

		public IEnumerable<string> GlmFile
		{
			get
			{
				foreach (var line in FileHeaderLines(Namespace))
					yield return line;

				yield return "/// <summary>";
				yield return "/// Static class that contains static glm functions";
				yield return "/// </summary>";
				yield return "public static partial class glm";
				yield return "{";
				foreach (var member in glmMembers)
					foreach (var line in member.Lines)
						yield return line.Indent(1);
				yield return "";
				yield return "}";
			}
		}

		public bool HasTestFile => !string.IsNullOrEmpty(Folder) && GenerateTests().Any();

		public IEnumerable<string> TestFile
		{
			get
			{
				if (string.IsNullOrEmpty(Folder))
					throw new NotSupportedException();

				foreach (var line in FileHeaderLines($"GlmResharpenedTest.Generated.{Folder.Replace('/', '_').Replace('\\', '_')}", true))
					yield return line;

				yield return "[TestFixture]";
				yield return "public class " + TestClassName;
				yield return "{";
				TestMode = true;
				ResetRandom(1234);
				foreach (var test in GenerateTests())
				{
					yield return "";
					yield return "[Test]".Indent(1);
					yield return $"public void {test.Name}()".Indent(1);
					yield return "{".Indent(1);
					foreach (var line in test.Code)
						yield return line.Indent(2);
					yield return "}".Indent(1);
				}
				TestMode = false;
				yield return "";
				yield return "}";
			}
		}

		protected virtual IEnumerable<string> Body { get { yield break; } }

		public string Comparer(string val) => BaseType.Generic ?
			string.Format("EqualityComparer<T>.Default.Equals({0}, rhs.{0})", val) :
			string.Format("{0}.Equals(rhs.{0})", val);

		public virtual string ZeroValue => BaseType.ZeroValue;
		public virtual string OneValue => BaseType.OneValue;

		public string HashCodeOf(string val) => BaseType.Generic ? $"EqualityComparer<T>.Default.GetHashCode({val})" : $"{val}.GetHashCode()";


		public string SqrOf(string s) => BaseType.IsComplex ? s + ".LengthSqr()" : s + "*" + s;
		public string SqrOf(char s) => SqrOf(s.ToString());

		public string SqrtOf(string s) => BaseType.Decimal ? "(" + s + ").Sqrt()" : $"Math.Sqrt({s})";
		public string SqrtOf(char s) => SqrOf(s.ToString());

		public string DotFormatString => BaseType.IsComplex ? "lhs.{0} * Complex.Conjugate(rhs.{0})" : "lhs.{0} * rhs.{0}";

		public string AbsString(string s) => BaseType.IsSigned ? BaseType.IsComplex ? s + ".Magnitude" : MathClass + $".Abs({s})" : s;
		public string AbsString(char s) => BaseType.IsSigned ? BaseType.IsComplex ? s + ".Magnitude" : MathClass + $".Abs({s})" : s.ToString();

		public string ConstantSuffixFor(string s)
		{
			var type = BaseType ?? this;

			if (type.Name == "float")
				return s + "f";

			if (type.Name == "bool")
				return s;

			if (type.Name == "Complex")
				return s;

			if (type.Name == "Half")
				return $"((Half)({s}))";

			if (type.Name == "double")
				return s + "d";

			if (type.Name == "decimal")
				return s + "m";

			if (type.Name == "int")
				return s;

			if (type.Name == "uint")
				return s + "u";

			if (type.Name == "long")
				return s + "L";

			throw new InvalidOperationException("unknown type " + this + ", " + type.Name);
		}

		public string ConstantStringFor(string s)
		{
			var type = BaseType ?? this;

			if (type.Name == "Half")
				return $"((Half)({s}))";

			return s;
		}

		public IEnumerable<string> SwitchIndex(IEnumerable<string> cases)
		{
			yield return "switch (index)";
			yield return "{";
			foreach (var @case in cases)
				yield return @case.Indent();
			yield return "    default: throw new ArgumentOutOfRangeException(\"index\");";
			yield return "}";
		}

		public static Dictionary<string, AbstractType> InitTypes()
		{
			Types.Clear();

			// vectors
			foreach (var type in BuiltinType.BaseTypes)
				for (var comp = 2; comp <= 4; ++comp)
				{
					var vec = new VectorType(type, comp);
					var swizzler = vec.SwizzleType;
					Types.Add(vec.Name, vec);
					Types.Add(swizzler.Name, swizzler);
				}

			// quat
			foreach (var type in BuiltinType.BaseTypes)
			{
				var quat = new QuaternionType(type);
				Types.Add(quat.Name, quat);
			}

			// matrices
			foreach (var type in BuiltinType.BaseTypes)
				for (var rows = 2; rows <= 4; ++rows)
					for (var cols = 2; cols <= 4; ++cols)
					{
						var matt = new MatrixType(type, cols, rows);
						Types.Add(matt.Name, matt);
					}

			// generate types
			foreach (var type in Types.Values)
				type.Generate();

			return Types;
		}

		private static string NestedSymmetricFunction(IReadOnlyList<string> fields, string funcFormat, int start, int end)
		{
			if (start == end)
				return fields[start];

			var mid = (start + end) / 2;
			return string.Format(funcFormat,
				NestedSymmetricFunction(fields, funcFormat, start, mid),
				NestedSymmetricFunction(fields, funcFormat, mid + 1, end));
		}
		public static string NestedSymmetricFunction(IEnumerable<string> ffs, string funcFormat)
		{
			var fs = ffs.ToArray();
			return NestedSymmetricFunction(fs, funcFormat, 0, fs.Length - 1);
		}
		public string TypeCast(BuiltinType otherType, string c)
		{
			if (otherType.HasArithmetics && BaseType.IsBool)
				return $"{c} ? {otherType.OneValue} : {otherType.ZeroValue}";

			if (otherType.IsBool && BaseType.HasArithmetics)
				return $"{c} != {BaseType.ZeroValue}";

			return $"({otherType.Name}){c}";
		}


		protected static string ToRgba(string xyzw)
		{
			var s = "";
			foreach (var c in xyzw)
			{
				switch (c)
				{
					case 'x':
						s += 'r';
						break;
					case 'y':
						s += 'g';
						break;
					case 'z':
						s += 'b';
						break;
					case 'w':
						s += 'a';
						break;
				}
			}
			return s;
		}
	}
}
