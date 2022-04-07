using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
        
        public int baseRettangolo;
        public int altezzaRettangolo;
   
        public void calcolaArea()
        {
            Console.WriteLine("L'area del rettangolo è: " + (baseRettangolo * altezzaRettangolo));
        }

        public void calcolaPerimetro()
        {
            Console.WriteLine("Il perimetro del rettangolo è: " + ((baseRettangolo + altezzaRettangolo) * 2));
        }

        public void StampaRettangolo ()
        {
            Console.WriteLine("--Rettangolo1--");
            Console.WriteLine("base: " + baseRettangolo + " cm");
            Console.WriteLine("altezza: " + altezzaRettangolo + " cm");
            Console.WriteLine("Perimetro: " + ((baseRettangolo + altezzaRettangolo) * 2) + " cm");
            Console.WriteLine("Area: " + (baseRettangolo * altezzaRettangolo) + " cm2");
        }
    }
}
