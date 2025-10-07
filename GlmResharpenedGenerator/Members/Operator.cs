using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GlmResharpenedGenerator.Types;

namespace GlmResharpenedGenerator.Members
{
    class Operator : Function
    {
        public Operator(AbstractType type, string op) : base(type, "operator " + op)
        {
            Static = true;
        }
	}
}
