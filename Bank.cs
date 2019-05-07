using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Bank
    {
        public static void Card()
        {

            int bankBallance = 2000;
            int scos = 0;
            int adaugat = 0;
            Console.WriteLine("Ce operatiuni doriti sa efectuati?");
            do
            {
                Console.WriteLine("Mai doriti sa efectuati o operatiune?");
                Console.WriteLine("1. Verificare numerar");
                Console.WriteLine("2. Eliberare numerar");
                Console.WriteLine("3. Depunere numerar");
                Console.WriteLine("0. Scoateti cardul");
                if (Console.ReadKey(true).Key == ConsoleKey.D1)
                {
                    Console.WriteLine(bankBallance);
                    continue;
                }
                if (Console.ReadKey(true).Key == ConsoleKey.D2)
                {
                    
                    Console.Write("\nIntroduceti suma ce o doriti sa o scoateti: ");
                    scos = Convert.ToInt32(Console.ReadLine());
                    if (bankBallance >= scos)
                    {
                        bankBallance = bankBallance - scos;
                        continue;
                    }
                    else
                    {
                        while (scos > bankBallance)
                        {
                            Console.Write("\nSuma ce o doriti sa o scoateti este mai mare decat suma din cont. Introduceti alta suma:");
                            scos = Convert.ToInt32(Console.ReadLine());
                            continue;
                        }
                        bankBallance = bankBallance - scos;
                        continue;
                    }
                }
                if (Console.ReadKey(true).Key == ConsoleKey.D3)
                {
                    Console.Write("\nIntroduceti suma ce o doriti sa o depuneti: ");
                    adaugat = Convert.ToInt32(Console.ReadLine());
                    bankBallance = bankBallance + adaugat;
                    continue;
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.D0);
        }
    }
}
