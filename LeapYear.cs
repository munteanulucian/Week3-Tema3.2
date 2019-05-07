using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class LeapYear
    {
        public static void Year(int x)
        {
            if (x % 4 == 0)
            {
                if (!(x<100))
                {
                    if (!(x<400))
                    {
                        if (x%400 !=0)
                        {
                            Console.WriteLine(x + " este an bisect.");
                        }
                        else
                        {
                            Console.WriteLine(x + " nu este an bisect.");
                        }
                    }
                    else
                    {
                        Console.WriteLine(x + " este an bisect.");
                    }
                }
                else
                {
                    Console.WriteLine(x + " este an bisect.");
                }
            }
            else
            {
                Console.WriteLine(x + " nu este an bisect.");
            }
        }
    }
}
