using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InlineUnit.Assert
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class AreEqualAttribute : AssertAttribute
    {
        public readonly object[] Arguments;

        public readonly object Expected;

        public AreEqualAttribute(object[] arguments, object expected)
        {
            Arguments = arguments;
            Expected = expected;
        }
    }
}