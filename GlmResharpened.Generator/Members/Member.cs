using GlmResharpenedGenerator.Types;

namespace GlmResharpenedGenerator.Members;

internal enum MemberType
{
	Field,
	Constructor,
	Property,
	StaticProperty,
	ImplicitOperator,
	ExplicitOperator,
	Operator,
	Function,
	Indexer,
	ComponentWiseStaticFunction,
	ComponentWiseOperator
}

internal sealed class AnyMember(string name, string comment, AbstractType originalType, MemberType memberType) : Member(name, comment, originalType, memberType)
{
	required public string[] Code { get; set; }

	public override IEnumerable<string> Lines
	{
		get
		{
			foreach (var line in base.Lines)
				yield return line;
			foreach (var codeLine in Code)
				yield return codeLine;
		}
	}
}

internal abstract class Member(string name, string comment, AbstractType originalType, MemberType memberType)
{
	/// <summary>
	/// Original type ref
	/// </summary>
	public AbstractType OriginalType { get; set; } = originalType;

	/// <summary>
	/// Member type
	/// </summary>
	public MemberType MemberType { get; set; } = memberType;

	/// <summary>
	/// Name of the member
	/// </summary>
	public string Name { get; set; } = name;

	/// <summary>
	/// Comment of the member
	/// </summary>
	public string Comment { get; set; } = comment;

	/// <summary>
	/// Visibility modifier
	/// </summary>
	public string Visibility { get; set; } = "public";

	/// <summary>
	/// True iff member is static
	/// </summary>
	public bool Static { get; set; }

	/// <summary>
	/// Attributes of this member
	/// </summary>
	public string[] Attributes { get; set; } = new string[] { };

	/// <summary>
	/// All lines of this member
	/// </summary>
	public virtual IEnumerable<string> Lines
	{
		get
		{
			foreach (var line in Comment.AsComment())
				yield return line;
			foreach (var attribute in Attributes)
				yield return $"[{attribute}]";
		}
	}

	/// <summary>
	/// Prefix for members (visibility, static)
	/// </summary>
	public virtual string MemberPrefix => Visibility + (Static ? " static" : "");

	/// <summary>
	/// Returns an enumeration of members used for the "glm" class
	/// </summary>
	public virtual IEnumerable<Member> GlmMembers() { yield break; }
}
