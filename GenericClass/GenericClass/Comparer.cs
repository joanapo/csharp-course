using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    internal class Comparer
    {
        public static bool AreEqual<T>(T first, T second) where T : class
        {
            return first == second;
        }
    }
}
