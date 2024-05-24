using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace training10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter date as yyyy/mm/dd : ");
            string date =  Console.ReadLine();
            DateTime Date = DateTime.Parse(date);
            PersianCalendar persianCalendar = new PersianCalendar();
            
            persianCalendar.GetMonth(Date);
            Console.WriteLine( persianCalendar.GetYear(Date) + "/" + persianCalendar.GetMonth(Date) + "/" + persianCalendar.GetDayOfMonth(Date));


            Console.ReadLine();
        }
    }
}
