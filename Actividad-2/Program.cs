using System;

namespace Actividad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un número:");
            numero = int.Parse(Console.ReadLine());

            if (numero == 0)
               Console.WriteLine("Cero");
            else if (numero > 0)
               Console.WriteLine("Positivo");
            else 
               Console.WriteLine("Negativo");
            

        }
    }
}
