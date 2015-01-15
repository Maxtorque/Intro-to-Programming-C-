using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfterTenYears
{
    class Program
    {
        static void Main()
        {
            DateTime birthDay = new DateTime(1989, 07, 12);
            DateTime todaysDate = DateTime.Now;
            var MyAge = todaysDate.Year - birthDay.Year;
            Console.WriteLine("My Age is: " + MyAge);
            var myFutureAge = MyAge + 10;
            Console.WriteLine("My Age in 10 years will be: " + myFutureAge);

        }
    }
}
