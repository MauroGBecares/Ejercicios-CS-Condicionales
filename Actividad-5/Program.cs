using System;

namespace Actividad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Ingrese un numero:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            d = int.Parse(Console.ReadLine());

            if(a > 100)
               Console.WriteLine("El número " + a + " es mayor a 100");
            if(b > 100)
               Console.WriteLine("El número " + b + " es mayor a 100");
            if(c > 100)
               Console.WriteLine("El número " + c + " es mayor a 100");
            if(d > 100)
               Console.WriteLine("El número " + d + " es mayor a 100");
           

        }
    }
}
