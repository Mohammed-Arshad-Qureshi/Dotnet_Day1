using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Present = 1;
            int Wage_Per_Hr = 20;
            int DailyWage = 0;
            int WorkingHrs = 0;
            Random r = new Random();
            int check = r.Next(0,2);
            if (Is_Present == check)
                WorkingHrs = 8;
            else
                WorkingHrs = 0;
            DailyWage = WorkingHrs + Wage_Per_Hr;
            Console.WriteLine(DailyWage);
            Console.ReadLine();
        }
    }
}
