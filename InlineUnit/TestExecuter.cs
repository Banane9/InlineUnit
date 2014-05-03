using InlineUnit.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace InlineUnit
{
    public static class TestExecuter
    {
        public static void ExecuteTestsForAssembly(Assembly assembly)
        {
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                MethodInfo[] methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);

                foreach (TestMethodInfo testMethod in IterateTestMethods(methods))
                {
                    foreach (AssertAttribute assertAttribute in testMethod.AssertAttributes)
                    {
                        if (testMethod.Method.IsStatic)
                        {
                            Console.WriteLine(type.FullName + "." + testMethod.Method.Name + ": " + assertAttribute.Assert(testMethod.Method, null));
                        }
                        else
                        {
                            //Look for preparation stuff.
                        }
                    }
                }
            }
        }

        public static IEnumerable<TestMethodInfo> IterateTestMethods(MethodInfo[] methods)
        {
            foreach (MethodInfo method in methods)
            {
                AssertAttribute[] assertAttributes = method.GetCustomAttributes(typeof(AssertAttribute), false) as AssertAttribute[];

                if (assertAttributes.Length > 0)
                    yield return new TestMethodInfo(method, assertAttributes);
            }
        }
    }
}