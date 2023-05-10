using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploaula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamifero mamifero = new Mamifero(true, 01, "aloha", "caça", 20, 100, 80);
            Mamifero mamifero2 = new Mamifero();
            mamifero2.pelos = true;
            mamifero2.Nome = "Cleiton";

            Console.WriteLine(mamifero.Nome);
            Console.WriteLine(mamifero2.Nome);

            Console.Read();
        }
    }
}
