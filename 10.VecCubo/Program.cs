using System;

namespace _10.VecCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[20];
            int[] cu = new int[20];

            Random rnd = new Random();
            for (int i = 0; i < A.Length; i++)
                A[i]=rnd.Next(1,30);

            Console.WriteLine("Vector original: ");
            imprime(A);

            Console.WriteLine("\n\nVector elevado al cubo:");
            cubo(A);
            
        }

        static void imprime(int[] v){
            for (int i = 0; i < v.Length; i++)
                Console.Write($"{v[i]} ");
        }

        static void cubo(int[] v){
            for (int i = 0; i < v.Length; i++){
                v[i]= v[i] * v[i] * v[i];
                Console.Write($"{v[i]} ");
            }
        }
    }
}
