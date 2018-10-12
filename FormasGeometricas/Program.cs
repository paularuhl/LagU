using System;
using System.Collections.Generic;
using Formas;

namespace FormasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shapes> formas = new List<Shapes>();
            
            formas.Add(new Cuadrado());
            formas.Add(new Rectangulo());
            formas.Add(new Triangulo());

            formas[0].PedirDatos();
            formas[1].PedirDatos();
            formas[2].PedirDatos();

            foreach(Shapes item in formas)
            {
                Console.WriteLine(item.CalcularArea());
            }

            //historial de archivos, cambios realizados
        }
    }
}
