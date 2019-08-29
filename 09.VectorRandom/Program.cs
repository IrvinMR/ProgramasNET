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



            Console.WriteLine("Hello World!");
        }
        static void imprime(strig[] args){
            for(int i== ;i<V.Length; i++)
                Console.WriteLine("");

        }
    }
}
