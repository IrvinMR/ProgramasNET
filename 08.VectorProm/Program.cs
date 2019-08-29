using System;

namespace _08.VectorProm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = {
                10,20,30,40,50,60,70,80,90,100,
                10,20,30,40,50,60,70,80,90,100,
                10,20,30,40,50,60,70,80,90,100,
                10,20,30,40,50,60,70,80,90,100,
                10,20,30,40,50,60,70,80,90,100 };
            

            int suma=0, cont=0;
            float prom=0;

            Console.WriteLine("Los elementos del arrelgo son: \n");
            for(int i=1; i < vector.Length; i++){
                Console.WriteLine($"{vector[i]} ");
                suma += vector[i];
            }
            
            prom = suma / vector.Length;
            Console.WriteLine($"El promedio es {prom} ");
            
            Console.WriteLine("");
            for(int i=0; i<vector.Length; i++){
                if(vector[i] > prom){
                    Console.WriteLine($"{i} ");
                    cont++;
                }
            }
                Console.WriteLine($"Los numeros mayores al promedio son: \n{vector[i]} ");
                
            }
            
        }
    }
