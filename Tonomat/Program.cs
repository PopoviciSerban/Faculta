using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonomat
{
    class Program
    {
        static void Main(string[] args)
        {
            char coin, answer;
            int amount;
            bool ok = true;

            while (ok == true)
            {
                Console.WriteLine("Do you want to buy? (Y / N)");
                answer = Console.ReadKey().KeyChar;

                if (answer == 'Y')
                {
                    amount = 0;

                    while (amount < 20)
                    {
                        Console.WriteLine("\nInsert a coin. (N / D / Q)");
                        coin = Console.ReadKey().KeyChar;

                        if (coin == 'N')
                        {
                            amount += 5;
                        }
                        else if (coin == 'D')
                        {
                            amount += 10;
                        }
                        else
                            amount += 25;
                    }

                    if (amount == 20)
                    {
                        Console.WriteLine("\nTake the merchandise.\n");
                    }

                    if (amount == 25)
                    {
                        Console.WriteLine("\nTake the merchandise. Don't forget about the remainder. (A Nickel)\n");
                    }

                    if (amount == 30)
                    {
                        Console.WriteLine("\nTake the merchandise. Don't forget about the remainder. (A Dime)\n");
                    }

                    if (amount == 35)
                    {
                        Console.WriteLine("\nTake the merchandise. Don't forget about the remainder. (A Dime + A Nickel)\n");
                    }

                    if (amount == 40)
                    {
                        Console.WriteLine("\nTake the merchandise. Don't forget about the remainder. (2 Dimes)\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nStay hungry then.");
                    Console.ReadKey();
                    ok = false;
                }
            }
        }
    }
}
