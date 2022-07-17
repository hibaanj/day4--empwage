using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    public class Uc1emppresent
    {
        public static void Emppresent()
        {
            int FULLTIME = 1;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == FULLTIME)
            {
                Console.WriteLine("emp is present today");

            }
            else
            {
                Console.WriteLine("emp is absent today");

            }

        }
        public static void Main(string[] args)
        {
            Emppresent();

        }
    }

}

