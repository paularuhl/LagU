using System;
using Classes;

namespace ejemploInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre de usuario: ");
            string name = Console.ReadLine();
            User newUser = new User(name);

            //mas util para validar datos, pedir de nuevo el nombre etc.
            //Console.WriteLine("Ingrese nombre de usuario: ");
            //string name = Console.ReadLine();
            newUser.SetName(name);

            //corre riesgo de que quede un enter vacio
            Console.WriteLine("Ingrese apellido de usuario: ");
            newUser.SetLastName(Console.ReadLine());

            Console.WriteLine(newUser.GetFullName());


        }
    }
}
