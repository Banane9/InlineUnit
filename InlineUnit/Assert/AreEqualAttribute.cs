﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace InlineUnit.Assert
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class AreEqualAttribute : AssertAttribute
    {
        public readonly object[] Parameters;

        public readonly object Expected;

        public AreEqualAttribute(object[] parameters, object expected)
        {
            Parameters = parameters;
            Expected = expected;
        }

        public override bool Assert(MethodInfo method, object instance)
        {
            return Expected.Equals(method.Invoke(instance, Parameters));
        }
    }
}