using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "Software Engineering" , txt2="txt2";

            Console.WriteLine(txt.Length);
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());
            Console.WriteLine(txt[0]);
            Console.WriteLine(string.Concat(txt,txt2));
            
            Console.ReadLine(); 
        }
    }
}
