using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilderExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder("Hello to all");
            Console.WriteLine("------string builder class----------");
            Console.WriteLine(stringBuilder);
            Console.WriteLine(stringBuilder.GetHashCode());
            stringBuilder.Append(" My name is Rohan");
            Console.WriteLine(stringBuilder);
            Console.WriteLine(stringBuilder.GetHashCode());
            Console.WriteLine("------string class ---------");
            string s1 = "Hello to all";
            Console.WriteLine(s1);
            Console.WriteLine(s1.GetHashCode());

            s1 = s1 + " This is sample code";
            Console.WriteLine(s1);
            Console.WriteLine(s1.GetHashCode());
        }

    }
}

