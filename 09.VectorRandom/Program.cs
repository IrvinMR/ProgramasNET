using System;

namespace _09.VectorRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[15];
            int[] B = new int[15];
            int[] C = new int[15];

            Random rnd = new Random();

            for(int i=0; i<A.Length; i++){
                A[i]=rnd.Next(1,30);
                B[i]=rnd.Next(1,30);
                C[i]=rnd.Next(1,30);
            }
            Console.Clear();
            Console.WriteLine($" El vector 1:");
            imprime(A);
            Console.WriteLine($"\n El vector 2");
            imprime(B);
            Console.WriteLine($"\n Suma de los dos vectores");
            ImpSuma(A,B);
        }
        static void imprime(int[] V){
            for(int i=0 ;i<V.Length; i++)
                Console.Write($"{V[i]} ");
        }
        static void ImpSuma(int[] V, int[] v){
            for(int i=0 ;i<V.Length; i++)
                Console.Write($"{V[i] + v[i]} ");
        }
    }
}
