using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace InlineUnit.Assert
{
    public abstract class AssertAttribute : Attribute
    {
        public abstract bool Assert(MethodInfo method, object instance);
    }
}