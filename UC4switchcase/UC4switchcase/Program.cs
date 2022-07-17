using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4
{
    internal class Uc4switchcase
    {

        public static void Switchwage()
        {
            const int FULLTIME = 1;
            const int PARTTIME = 2;
            int rateperhour = 20;

            int emphr = 0;
            int wage = 0;
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
            wage = emphr * rateperhour;
            Console.WriteLine("wage is : " + wage);
        }
        public static void Main()
        {
            Switchwage();
        }
    }
}
