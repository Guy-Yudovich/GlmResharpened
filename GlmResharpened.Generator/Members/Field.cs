using GlmResharpenedGenerator.Types;

namespace GlmResharpenedGenerator.Members;

internal class Field : Member
{
	/// <summary>
	/// Member type
	/// </summary>
	public AbstractType Type { get; set; }

	/// <summary>
	/// True iff field is readonly
	/// </summary>
	public bool Readonly { get; set; }

	public override string MemberPrefix => base.MemberPrefix + (Readonly ? " readonly" : "");

	public override IEnumerable<string> Lines
	{
		get
		{
			foreach (var line in base.Lines)
				yield return line;

			yield return $"{MemberPrefix} {Type.NameThat} {Name};";
		}
	}

	public Field(string name, AbstractType type) : base(name, "DUMMY << >> &&", type, MemberType.Field)
	{
		Name = name;
		Type = type;
		Attributes = new[] { "DataMember" };
	}
}
