using System;

namespace _04.CalcPaga
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int horas,horasextra;
            float paga, tasa=0.3f;
            float bruta, extra, impuesto,neta;
            
            Console.Clear();
            Console.WriteLine("Programa que calcula la paga de un trabajador\n");
            Console.WriteLine("Nombre   "); nombre = Console.ReadLine();
            Console.WriteLine("Horas    "); horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Paga     "); paga = float.Parse(Console.ReadLine());
            
            horasextra = (horas<40 ? horas -40 : 0);
            extra=horasextra * (paga *2);
            bruta=(horas - horasextra) * paga + extra;
            impuesto= bruta * tasa;
            neta= bruta - impuesto;

            Console.WriteLine($"\n{nombre} : trabajo {horas} a una paga {paga}");
            Console.WriteLine($"Paga bruta: {bruta}");
            Console.WriteLine($"Impuestos:  {impuesto}");
            Console.WriteLine($"Paga neta:  {neta}\n\n");

            {
                
            }

        }
    }
}
