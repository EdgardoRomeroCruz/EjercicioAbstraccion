using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class VolumenCilindro : FormulaMatematica
    {
        private double radio;
        private double altura;
        public VolumenCilindro(double radio, double altura)
        {
            this.radio = radio;
            this.altura = altura;
        }
        public override void Calcular()
        {
            double volumen = 3.1416 * radio * radio * altura;
            Console.WriteLine("el volumende un cilindro: "+volumen);
        }
        public override void Imprimir()
        {
            Console.WriteLine("la formula del volumen del cilindro es area de la base por altura ");
        }
    }
}
