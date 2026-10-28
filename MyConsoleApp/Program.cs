using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Myname = "Josef Novotný";
            int Myage = 43;


            Console.WriteLine("Moje jméno je: " + Myname );
            Console.WriteLine("A můj věk je: " + Myage);

            Console.WriteLine("Napiš mě svoje jméno: ");
            String Yourname = Console.ReadLine();
            Console.WriteLine($"Tvoje jméno je: {Yourname} ");

            if (Myage == 45)
            {
                Console.WriteLine("Tvůj věk je 43 let!");
            }
            else
            {
                Console.WriteLine("Tvůj věk není 43 let, jseš jinak starý!");
            }



        }
    }
}
