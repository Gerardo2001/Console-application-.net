using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IRettangolo facade = new Rettangolo();
            Console.WriteLine("Ciao! Cosa vuoi calcolare?");
            Console.Write("Area(a)/Perimetro(p)");
            var formula = Console.ReadLine();
            Console.Write("Inserisci la base: ");
            int.TryParse(Console.ReadLine(), out int latoBase);
            Console.Write("Inserisci l'altezza: ");
            int.TryParse(Console.ReadLine(), out int latoAltezza);

            int result = 0;

            switch(formula)
            {
                case "a":
                    result = facade.Area(latoBase, latoAltezza);
                    break;
                case "p":
                    result = facade.Perimetro(latoBase, latoAltezza);
                    break;
            }
           
            Console.Write("Il risultato è: "+ result);
            Console.ReadKey();
        }
    }
}
 