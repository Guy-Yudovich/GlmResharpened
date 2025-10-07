using GlmResharpenedGenerator.Types;

namespace GlmResharpenedGenerator.Members;

internal class Operator : Function
{
	public Operator(AbstractType type, string op) : base(type, "operator " + op) => Static = true;
}
