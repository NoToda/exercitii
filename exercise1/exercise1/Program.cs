using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrieti un numar: ");
            string numarInput = Console.ReadLine();

            Console.WriteLine("Rezultatul este: ");

            Console.WriteLine($"{numarInput} {numarInput} {numarInput} {numarInput}");
            Console.WriteLine($"{numarInput}{numarInput}{numarInput}{numarInput}");

            Console.WriteLine($"{numarInput} {numarInput} {numarInput} {numarInput}");
            Console.WriteLine($"{numarInput}{numarInput}{numarInput}{numarInput}");

            Console.ReadLine();
        }
    }
}