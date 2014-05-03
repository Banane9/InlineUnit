using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace InlineUnit.TestConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Testing");

            TestExecuter.ExecuteTestsForAssembly(Assembly.GetAssembly(typeof(Program)));

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        [Assert.AreEqual(new object[] { 5 }, 6)]
        private static int AddOne(int number)
        {
            return number + 1;
        }
    }
}