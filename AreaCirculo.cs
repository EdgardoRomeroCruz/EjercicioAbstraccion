using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class AreaCirculo : FormulaMatematica
    {
        private double radio;
        public AreaCirculo(double radio)
        {
            this.radio = radio;
        }
        public override void Calcular()
        {
            double area= 3.1416 * radio * radio;
            Console.WriteLine("el area del circulo:  " + area);
        }
        public override void Imprimir()
        {
            Console.WriteLine("el arera del circulo es :  3.1416 * radio2");
        }

    }
}
