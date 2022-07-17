using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc3
{
    internal class Uc3pertime
    {
        public static void partime()
        {
            int FULLTIME = 1;
            int Parttime = 2;
            int emphr = 0;
            Random random = new Random();
            int check = random.Next(0, 3);
            if (check == FULLTIME)
            {
                emphr = 12;
                Console.WriteLine("the emp was present full time and his working hrs are : " + emphr);
            }
            else if (check == Parttime)
            {
                emphr = 8;
                Console.WriteLine("the emp was present part time and his working hrs are : " + emphr);

            }
            else
            {
                emphr = 0;
                Console.WriteLine("emp is absnnt " + emphr);
            }

        }
        public static void Main(string[] args)
        {
            partime();
        } 


    }
}
