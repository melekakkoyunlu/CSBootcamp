using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTypes
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           int day =(int) WeekDays.Monday;
           Console.WriteLine(day);  
           Console.WriteLine(WeekDays.Monday);

            //str convertlenir

            string strNum = "10";
            int convert = Convert.ToInt32(strNum);

            long a = 10000;
            short b = (short)a;

            //
            var wd = (WeekDays)5;
            Console.WriteLine(wd);
          
           Console.ReadLine();
        }
    }
}
