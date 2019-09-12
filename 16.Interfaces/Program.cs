using System;
using Interfaces.Clases;
using System.Collections.Generic;

namespace Interfaces
{
    class Program{

        static void Main(string[] args){
            List<Caja> costal = LlenarCostal();
            Caja micaja= new Caja("Roja",true,"Calzones",10,20);
            Console.WriteLine("Ejemplo de interfaces\n\n");
            //micaja.Cerrar();
            costal.Add(micaja);
            foreach (Caja c in costal){
                Console.WriteLine($"Color :{c.Color}");
                Console.WriteLine($"Estatus : {(c.EstaAbierta?"Abierta":"Cerrada")}"); // if de corto circuito
                Console.WriteLine($"Contenido : {(c.EstaAbierta?c.Contenido:"nel")}");
                Console.WriteLine($"Dimensiones : {c.Medidas()}");
            }
        }
         static public List<Caja> LlenarCostal() {
            List<Caja> todo = new List<Caja>();
            todo.Add(new Caja("Rojo",false,"Manzanas",10,10));
            todo.Add(new Caja("Verde",false,"Zapatos",10,10));
            todo.Add(new Caja("Azul",false,"Mascara",10,10));
            todo.Add(new Caja("Rosa",false,"playera",10,10));
            todo.Add(new Caja("Negro",false,"",10,10));
            todo.Add(new Caja("amarillo",false,"Carbon",10,10));
            return todo;
        }
    }
}
