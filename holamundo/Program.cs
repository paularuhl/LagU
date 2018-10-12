using System;
using System.Collections.Generic;

namespace holamundo
{
    class Program
    {
        //dotnet new console -o projectName 
        //code . 
        static void Main(string[] args)
        {
            //dotnet run
            //save for build
            //string nombre;
            //int numeroUno;
            //int numeroDos;

            //es como un arraylist dinamico
            List<int> numeros = new List<int>();

            numeros.Add(1);
            numeros.Add(4);
            numeros.Add(3);
            //hashmap es ocmo una matriz en java
            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
        
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] > 2)
                    Console.WriteLine(numeros[i]);
            }
            /*
                        Console.Write("Ingrese un numero: ");
                        numeroUno = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese otro numero: ");
                        numeroDos = int.Parse(Console.ReadLine());

                        Console.WriteLine($"El resultado de la suma es {Add(numeroUno,numeroDos)}");
                        Console.WriteLine($"El resultado de la resta es {Substract(numeroUno,numeroDos)}");
                        Console.WriteLine($"El resultado de la multiplicacion es {Multiply(numeroUno,numeroDos)}");
                        Console.WriteLine($"El resultado de la division es {Divide(numeroUno,numeroDos)}");
            */
            //Console.Write("Escriba su nombre: ");
            //nombre = Console.ReadLine();
            //forma mas 'corta' y agradable de concatenar un literal str con una variable
            //Console.WriteLine($"Hello World { ArmarString() }");
            //Console.WriteLine(ArmarString(nombre));

            //Console.WriteLine(String.Concat("Hello World ",nombre));

        }

/*        private static string ArmarString(string nombre)
        {
            string mensaje = $"Hello World! {nombre}";
            //return "";
            return mensaje; //self-explanatory
        }
        private static int Add(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }
        private static int Substract(int n1, int n2)
        {
            int resultado = n1 - n2;
            return resultado;
        }
        private static int Multiply(int n1, int n2)
        {
            int resultado = n1 * n2;
            return resultado;
        }
        private static int Divide(int n1, int n2)
        {
            int resultado = 0;
            try
            {
                resultado = n1 / n2;
            }
            catch (Exception)
            {
                Console.WriteLine("Error, contact admin");
            }


            return resultado;
        }*/

        void Martes()
        {
            //interfaz tiene las definiciones de un grupo de funcionalidades relacionadas,
            //por ejemplo la interfaz puede tener la firma de metodo caminar, hablar, comer,
            //y luego la implementan las clases alumno profesor y rector, que deben tener esos metodos
        }
    }
}
