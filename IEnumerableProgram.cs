using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class IEnumerableProgram {
        public void method()
        {
            List<string> Month = new List<string>();
            Month.Add("January");
            Month.Add("February");
            Month.Add("March");
            Month.Add("April");
            Month.Add("May");
            Month.Add("June");
            Month.Add("July");
            Month.Add("August");
            Month.Add("September");
            Month.Add("October");
            Month.Add("November");
            Month.Add("December");

            ///create IEnumerable of string
            IEnumerable<string> iEnumerableOfString = (IEnumerable<string>)Month;

            //If we want to retrieve all the items from this IEnumerable object, we can use a foreach loop.
            foreach (string AllMonths in iEnumerableOfString)
            {
                Console.WriteLine(AllMonths);
            }
        }
    }
}
