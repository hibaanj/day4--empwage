using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc2
{
    internal class Uc2empwage
    {
        public static void Empwage()
        {
            int FULLTIME = 1;
            int rateperhour = 15;
            //calculating 
            int empwage = 0;
            int emphr = 0;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == FULLTIME)
            {
                Console.WriteLine("emp is present today");
                emphr = 8;
            }
            else
            {
                Console.WriteLine("emp is absent today");
                emphr = 0;
            }
            //wage calculation
            empwage = emphr * rateperhour;
            Console.WriteLine("todays wage is" + empwage);

        }
        public static void Main(string[] args)
        {
            Empwage();

        }

    }

}