using System;

namespace holamundo
{
    public class Test
    {
        int pss;
        string cadena;
        ConsoleColor concol;

        //constructor
        public Test(){
            this.pss = 2;
            this.cadena = "Hola";
            this.concol = ConsoleColor.Red;
        }

        public Test(int num) : this()
        {
            this.pss=num;
        }
        

        //metodos


    }

}