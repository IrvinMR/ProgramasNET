using System;

namespace _12.VectorInverso
{
    class Program
    {
        static void Main(string[] args) {
            int[] A = new int[15];
            int[] B = new int[15];
          //  int j = 15;

            Random rnd = new Random();
            for (int i = 0 ; i < A.Length ; i++)
                A[i]=rnd.Next(1,30);
                
            for (int i = 0 ; i < A.Length ; i++){
                for (int j = 15; i < B.Length; j--){
                    A[i]=B[j];
                }
            }

            Console.WriteLine("Vector original: ");
            imprime(A);

            Console.WriteLine("\nVector inverso: ");
            imprime(B);
        }
        
        static void imprime(int[] v){
            for (int i = 0; i < v.Length; i++)
                Console.Write($"{v[i]} ");
        }
    }
}
