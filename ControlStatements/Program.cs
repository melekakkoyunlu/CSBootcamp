using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your nickname");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            if (name=="admin" && password=="1234")
            {
               Console.WriteLine("Welcome");
           
            }
            else
            {
                Console.WriteLine("Invalid password or nickname");
            }

            Console.ReadLine(); 
        }
    }
}
