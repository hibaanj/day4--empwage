using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC5
{
    internal class Uc5wageformonth
    {
        public static void Wageforamonth()
        {
            const int FULLTIME = 1;
            const int PARTTIME = 2;
            const int WAGEPERHOUR = 20;
            const int WORKINGDAYS = 20;
            int wage = 0;
            int wagemonth = 0;
            for (int day = 0; day < WORKINGDAYS; day++)
            {
                int emphr = 0;

                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case FULLTIME:
                        emphr = 12;
                        break;
                    case PARTTIME:
                        emphr = 8;
                        break;
                    default:
                        emphr = 0;
                        break;

                }
                wage = emphr * WAGEPERHOUR;
            }
            wagemonth += wage;

            Console.WriteLine("wage for a month is " + wagemonth);
        }
        public static void Main(string[] args)
        {
            Wageforamonth();
        }
    }
}
