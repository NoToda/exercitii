using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar;

            while (true)
            {
                Console.Write("Scrieti un numar: ");
                string numarInput = Console.ReadLine();

                bool success = int.TryParse(numarInput, out numar);

                if (success)
                {
                    Console.WriteLine("Rezultatul este: ");

                    for (int i = 0; i < 2; i++)
                    {
                        for (int u = 0; u < 4; u++)
                        {
                            Console.Write(numarInput + " ");
                        }

                        Console.WriteLine("\n");

                        for (int u = 0; u < 4; u++)
                        {
                            Console.Write(numarInput);
                        }

                        Console.WriteLine("\n");

                    }

                    break;

                }
                else
                {
                    Console.WriteLine("This is not an integer number! Try again.");

                    continue;
                }
            }

            Console.ReadLine();
        }
    }
}

