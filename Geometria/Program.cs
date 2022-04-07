// See https://aka.ms/new-console-template for more information

namespace Geometria
{
    class Program
    {
        static void Main (string[] args)
        {
            Rettangolo Rettangolo1 = new Rettangolo();

            Console.WriteLine("Inserisci l'altezza del rettangolo ");
            Rettangolo1.altezzaRettangolo = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la base del rettangolo ");
            Rettangolo1.baseRettangolo = int.Parse(Console.ReadLine());

            Rettangolo1.calcolaArea();
            Rettangolo1.calcolaPerimetro();

            //Console.ReadKey();
        }
    }
}

