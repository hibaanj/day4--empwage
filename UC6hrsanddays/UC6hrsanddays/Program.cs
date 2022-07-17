using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6
{
    class Uc6hrsanddays
    {
        public static void HRsanddays()
        {
            const int MAXHRS = 100;
            const int MAXDAYS = 20;
            const int FULLTIME = 1;
            const int PARTTIME = 2;
            const int WAGEPERHOUR = 20;

            //use looping
            int days = 0;
            int hrs = 0;
            int wage = 0;
            int wagemonth = 0;
            int emphr = 0;

            while (hrs < MAXHRS && days < MAXDAYS)
            {

                days++;

                Random r = new Random();
                int check = r.Next(0, 3);


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
                hrs += emphr;






            }

            wage = hrs * WAGEPERHOUR;
            Console.WriteLine("wage is" + wage);

            wagemonth += wage;
            Console.WriteLine("wage per month or when not crossing 100hrs is" + wagemonth);



        }
        public static void Main(string[] args)
        {
            HRsanddays();
        }
    }
}

