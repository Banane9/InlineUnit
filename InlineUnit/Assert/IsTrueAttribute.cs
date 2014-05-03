using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace InlineUnit.Assert
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class IsTrueAttribute : AssertAttribute
    {
        public readonly object[] Parameters;

        public IsTrueAttribute(object[] parameters)
        {
            Parameters = parameters;
        }

        public override bool Assert(MethodInfo method, object instance)
        {
            return true.Equals(method.Invoke(instance, Parameters));
        }
    }
}