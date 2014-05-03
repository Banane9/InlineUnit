using InlineUnit.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace InlineUnit
{
    public class TestMethodInfo
    {
        public MethodInfo Method { get; private set; }

        public AssertAttribute[] AssertAttributes { get; private set; }

        public TestMethodInfo(MethodInfo method, AssertAttribute[] assertAttributes)
        {
            Method = method;
            AssertAttributes = assertAttributes;
        }
    }
}