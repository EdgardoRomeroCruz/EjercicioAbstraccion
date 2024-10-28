// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using EjercicioAbstraccion;
using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        // Menu de opciones
        do
        {
            Console.WriteLine("Seleccione la fórmula a calcular:");
            Console.WriteLine("1. area del Círculo");
            Console.WriteLine("2. centigrados a farenheit");
            Console.WriteLine("3. volumen del cilindro");
            Console.WriteLine("4. salir");

           opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {      case 1:
                        Console.WriteLine("ingrese el radio del circulo");
                        double radioCirculo = double.Parse(Console.ReadLine());
                        var areaCirculo = new AreaCirculo(radioCirculo);
                        areaCirculo.Imprimir();
                        areaCirculo.Calcular();
                        break;
                    case 2:
                        Console.WriteLine("ingrese ingrese los grados centigrados");
                        double centigrados = double.Parse(Console.ReadLine());
                        var convertir = new CentigradosFarenhit(centigrados);
                        convertir.Imprimir();
                        convertir.Calcular();
                        break;
                    case 3:
                        Console.WriteLine("ingrese el radio del circulo");
                        double radioCilindro = double.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese la altura del cilindro");
                        double alturaCilindro = double.Parse(Console.ReadLine());
                        var volumenCilindro = new VolumenCilindro(radioCilindro, alturaCilindro);
                        volumenCilindro.Imprimir();
                        volumenCilindro.Calcular();
                        break;
                    case 4:
                        Console.WriteLine("saliendo");
                        break;

                    default:
                        Console.WriteLine("no existe esa opcion");
                        break;
            }
        } while (opcion != 4) ;

    }
}


