using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello");
            //sb.AppendLine("Hello C#");
            //sb.AppendLine("Hello World");

            // Console.WriteLine(sb);

            StringBuilder sbAmount = new StringBuilder("Tutar:");
            sbAmount.AppendFormat("{0:C}", 25);
            Console.WriteLine(sbAmount);


            Console.ReadLine();
        }
    }
}
