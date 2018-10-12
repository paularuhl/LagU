using System;

namespace Formas
{
    public class Triangulo : Shapes
    {
        public double tBase = 2;
        public double altura = 3;
        public override string CalcularArea()
        {
            double area = (this.tBase * this.altura) / 2;
            return string.Format("El area del triangulo es: {0}cm2", area);
        }

        public override void PedirDatos()
        {
            Console.Write("Ingrese base del triangulo: ");
            this.tBase = double.Parse(Console.ReadLine());

            Console.Write("Ingrese altura del triangulo: ");
            this.altura = double.Parse(Console.ReadLine());
        }
    }
}