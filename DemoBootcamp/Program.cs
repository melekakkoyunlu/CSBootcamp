using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBootcamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Internet bankaciligi";
            string head = "Kurlar";

            int age = 10;
            int age2 = 15;

            short age3 = 10;
            long age4 = 48;

            bool isAuth = false;  //isAuthentication
            bool isAdmin = true;

            double price = 47.4;
            decimal price2 = 48.5M;
            float price3 = 48.9F;

            char yerOrNo = 'y';

            Console.WriteLine(name);
            Console.WriteLine(head);
            Console.WriteLine(age);
            Console.WriteLine(age2);

            Console.ReadLine(); 
        }
    }
}
