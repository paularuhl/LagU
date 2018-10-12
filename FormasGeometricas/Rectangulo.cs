using System;

namespace Formas
{
    public class Rectangulo : Shapes
    {
        public double rBase = 2;
        public double altura = 3;
        public override string CalcularArea()
        {
            double area = this.rBase * this.altura;
            return string.Format("El area del rectangulo es: {0}cm2",area);
        }

        public override void PedirDatos()
        {
            Console.Write("Ingrese base del rectangulo: ");
            this.rBase = double.Parse(Console.ReadLine());            
        
            Console.Write("Ingrese altura del rectangulo: ");
            this.altura = double.Parse(Console.ReadLine());


        }
    }
}