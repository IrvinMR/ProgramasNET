using System;
using ContBancario.Clases;


namespace ContBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria micuenta1= new CuentaBancaria();
            CuentaBancaria micuenta2= new CuentaBancaria(1000);
            CuentaAhorro miahorro = new CuentaAhorro(600,0.3);
            CuentaCheques micheque = new CuentaCheques(5000,1000);

            micuenta1.Deposita(300);
            micuenta2.Retirar(500);
            miahorro.Deposita(100);
            miahorro.Retirar(50);
            micheque.Deposita(3000);
            micheque.Retirar(9000);

            Console.WriteLine($"Cuenta 1 : {micuenta1.Saldo}");
            Console.WriteLine($"Cuenta 2 : {micuenta2.Saldo}");
            Console.WriteLine($"Cuenta 3 : {miahorro.Saldo}");
            Console.WriteLine($"Cuenta 4 : {micheque.Saldo}");

        }
    }
}
