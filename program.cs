using System;

namespace CalculatorTimpCalatorie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Citeste distanta de la tastatura
            Console.Write("Introdu distanta (în kilometri): ");
            double distanta = double.Parse(Console.ReadLine());

            // Citeste viteza de la tastatura
            Console.Write("Introdu viteza (în km/h): ");
            double viteza = double.Parse(Console.ReadLine());

            // Calculeaza timpul necesar
            double timp = distanta / viteza;

            // Afiseaza rezultatul
            Console.WriteLine("Timpul necesar pentru a parcurge distanța de {0} km la viteza de {1} km/h este de {2} ore.", distanta, viteza, timp);
        }
    }
}
