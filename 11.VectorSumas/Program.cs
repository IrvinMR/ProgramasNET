using System;

namespace _11.VectorSumas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[30];
            int neg=0, cer=0, pos=0,sumneg=0,sumpos=0;

            Random rnd = new Random();
            for (int i = 0; i < A.Length; i++)
                A[i]=rnd.Next(-10,15);
            
            for (int i = 0; i < A.Length; i++){
                if (A[i]<0){
                    sumneg+=A[i];
                    neg++;
                }
                else if (A[i]==0)
                    cer++;
                else{
                    sumpos+=A[i];
                    pos++;
                }

            }

            
            imprime(A);
            Console.WriteLine($"\nNumeros negativos {neg}");
            Console.WriteLine($"Ceros {cer}");
            Console.WriteLine($"Numeros positivos {pos}");
            Console.WriteLine($"Suma de numeros positivos {sumneg}");
            Console.WriteLine($"Suma de numeros positivos {sumpos}");
        }

        static void imprime(int[] v){
            for (int i = 0; i < v.Length; i++)
                Console.Write($"{v[i]} ");
        }
    }
}
