using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empwage_object
{
    internal class Program


    {
        public const int emp_part = 1;
        public const int emp_full = 2;
        public const int rate_per_hour = 8;
        public const int working_days = 20;
        public const int total_maximum_hours = 100;

        public static int calculate()
        {
            int emphours = 0;
            int totalemphours = 0;
            int totalworkingdays = 0;

            while (emphours <= total_maximum_hours && totalworkingdays < working_days)
            {
                totalworkingdays++;
              
                Random random = new Random();
                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case emp_part:
                        emphours = 4;
                        break;
                    case emp_full:
                        emphours = 8;
                        break;

                    default:
                        emphours = 0;
                        break;
                }


                totalemphours = emphours + totalemphours;
                Console.WriteLine("days " + totalworkingdays + "  employee hours    " + emphours);

            }

            int totalempwages = totalemphours * rate_per_hour;
            Console.WriteLine("   total emp wage    " + totalempwages);
            return totalempwages;
        }

    

        static void Main(string[] args)
        {

            calculate();
        }
    }
}
