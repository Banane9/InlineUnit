using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InlineUnit.Assert
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class TrueAttribute : AssertAttribute
    {
        public readonly object[] Arguments;

        public TrueAttribute(object[] arguments)
        {
            Arguments = arguments;
        }
    }
}