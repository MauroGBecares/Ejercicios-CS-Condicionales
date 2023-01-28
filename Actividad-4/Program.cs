using System;

namespace Actividad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, m;

            Console.WriteLine("Ingrese un numero:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero:");  
            d = int.Parse(Console.ReadLine());

            if (a < b)
               m = a;
            else
               m = b;            
            if (c < m)
               m = c;
            if (d < m)
               m = d;
            
            Console.WriteLine("El menor numero es: " + m);

                  

        }
    }
}
