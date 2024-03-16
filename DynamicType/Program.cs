using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic example = 255;
            Console.WriteLine("Value : {0},Type:{1}", example, example.GetType());

            example = "Hello World";
            Console.WriteLine("Value : {0},Type:{1}", example, example.GetType());

            example = true;
            Console.WriteLine("Value : {0},Type:{1}", example, example.GetType());

            example = DateTime.Now;
            Console.WriteLine("Value : {0},Type:{1}", example, example.GetType());

            Console.ReadLine();
        }
    }
}
