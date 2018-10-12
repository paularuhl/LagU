using System;

namespace Formas
{

    public class Circulo : Shapes
    {
        public double ratio;
        public override string CalcularArea()
        {
            double area = Math.PI * Math.Pow(this.ratio,2);
            return string.Format("El area del circulo es: {0}cm2",area);
        }

        public override void PedirDatos()
        {
            Console.Write("Ingrese radio del circulo: ");
            this.ratio = double.Parse(Console.ReadLine());            
        }
    }
}