using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2_bis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buna, poti raspunde la urmatoarele intrebari ? ");
            Console.WriteLine("y/n");
            string raspuns = Console.ReadLine();

            if (raspuns.ToLower() == "y")
            {
                Console.WriteLine("Ok, sa incepem!");

                Console.WriteLine("Domnul / Doamna");
                string adresare = Console.ReadLine();

                Console.WriteLine("Care este numele tau ? ");
                string nume = Console.ReadLine();

                Console.WriteLine("Care este prenumele tau ?");
                string prenume = Console.ReadLine();

                Console.WriteLine("Care este adresa ta ? (strada)");
                string strada = Console.ReadLine();

                Console.WriteLine("Ce judet ?");
                string judet = Console.ReadLine();

                Console.WriteLine("Codul postal ?");
                string codPostal = Console.ReadLine();

                Console.WriteLine("Care este numarul tau de telefon ?");
                string telefon = Console.ReadLine();

                Console.WriteLine("Care este adresa ta de e-mail ?");
                string mail = Console.ReadLine();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(".");
                }

                Console.WriteLine($"Persoana: {adresare} {prenume} {nume} \n" +
                    $"Adressa: {strada}, {judet}, {codPostal} \n" +
                    $"Date de contact: {telefon}, {mail}");
            }
            else
            {
                Console.WriteLine("Ok, no problem");
            }

            Console.ReadLine();
        }
    }
}
