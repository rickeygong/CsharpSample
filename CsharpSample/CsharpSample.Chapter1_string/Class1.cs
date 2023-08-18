using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSample.Chapter1_string
{
    public class Class1
    {
        static void Main(string[] args)
        {
            string[] sarray = { "Happy", "New", "Year" };
            List<string> list = new List<string>() { "But", "in", "the", "in" };
            Console.WriteLine(String.Join(" ", sarray));
            Console.WriteLine(String.Join(" ", list));
            Console.ReadKey();

        }
    }
}
