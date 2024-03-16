using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            DateTime addDay0 = dateTime.AddDays(1);
            DateTime addDay1 = dateTime.AddDays(-1);
            DateTime utc = DateTime.UtcNow;

            var year = String.Format("{0:y yy yyy yyyy", dateTime);
            var month = String.Format("{0:m MM MMM MMMM", dateTime);
            var day = String.Format("{0:d DD DDD DDDD", dateTime);

            Console.WriteLine(dateTime);
            Console.WriteLine(addDay0);
            Console.WriteLine(addDay1);
            Console.WriteLine(month);

            Console.ReadLine();
        }
    }
}
