using System;

namespace _03.AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float area, b, a;
            Console.WriteLine("Programam que calcula el area de un triangulo");

        if (args.Length<2){
            Console.WriteLine("Forma de uso");
            Console.WriteLine("<base> <altura>");
            Environment.Exit(0);
           }

        b=float.Parse(args[0]);
        a=float.Parse(args[1]);

        area= (b*a)/2;

        Console.WriteLine($"El area es {area}");

        }
    }
}
