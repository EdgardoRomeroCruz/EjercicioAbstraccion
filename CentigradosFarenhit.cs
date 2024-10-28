using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class CentigradosFarenhit : FormulaMatematica
    {
        private double centigrados;

        public CentigradosFarenhit(double centigrados)
        {
            this.centigrados = centigrados;
        }

        public override void Calcular ()
        {
            double Farenheit = (centigrados * 9 / 5) + 32;
            Console.WriteLine("la temperatura en Farenheit: "+ Farenheit);

        }
        public override void Imprimir()
        {
            Console.WriteLine("conversion de Centigrados a Farenheit = °C × 9/5) + 32 ");
        }
    }
}
