using System;

namespace Formas
{

    public class Cuadrado : Shapes
    {
        public double lado;
        public override string CalcularArea()
        {
            double area = Math.Pow(this.lado,2);
            return string.Format("El area del cuadrado es: {0}cm2",area);
        }

        public override void PedirDatos()
        {
            Console.Write("Ingrese lado del cuadrado: ");
            this.lado = double.Parse(Console.ReadLine());            
        }
    }
}