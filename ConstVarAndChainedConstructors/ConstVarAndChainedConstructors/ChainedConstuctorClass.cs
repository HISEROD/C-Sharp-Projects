using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarAndChainedConstructors
{
    class ChainedConstuctorClass
    {
        // make a regular constructor that has a parameter for each property
        public ChainedConstuctorClass(float x, float y)
        {
            X = x;
            Y = y;
        }
        // create a second constructor that automatically assigns 0 to Y
        public ChainedConstuctorClass(float x) : this(x, 0.0f) { }
        public float X { get; set; }
        public float Y { get; set; }
    }
}
