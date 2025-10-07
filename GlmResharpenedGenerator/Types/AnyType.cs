using GlmResharpenedGenerator.Members;

namespace GlmResharpenedGenerator.Types;

internal class AnyType : AbstractType
{
	public AnyType(string name) => Name = name;

	public override string Name { get; }

	public override string TypeComment => throw new NotSupportedException();

	public override IEnumerable<Member> GenerateMembers() => throw new NotSupportedException();
}
