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
            Console.WriteLine(baseRettangolo * altezzaRettangolo);
        }

        public void calcolaPerimetro()
        {
            Console.WriteLine((baseRettangolo + altezzaRettangolo) * 2);
        }
    }
}
