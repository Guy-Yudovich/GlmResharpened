using GlmResharpenedGenerator.Types;

namespace GlmResharpenedGenerator.Members;

internal class StaticProperty : Property
{
	public StaticProperty(string name, AbstractType type) : base(name, type) => Static = true;
}
