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

            //probar cliente y banco

            Banco MiBanco= new Banco ("Banco del Billeton");

            Cliente cte1 = new Cliente("Chente fox");
            Cliente cte2 = new Cliente("Feli pisto ");
            Cliente cte3 = new Cliente("quique peña");
            Cliente cte4 = new Cliente("amlover");

            cte1.AgregarCuenta( new CuentaCheques(2000,1000));
            cte2.AgregarCuenta( new CuentaCheques(1000,200));
            cte3.AgregarCuenta( new CuentaCheques(900,100));
            cte4.AgregarCuenta( new CuentaCheques(12000,1000));
            cte4.AgregarCuenta( new CuentaAhorro(2000,0.3));

            cte1.Cuentas[0].Retirar(300);
            cte3.Cuentas[0].Deposita(1200);
            cte4.Cuentas[1].Retirar(1000);

            MiBanco.AgregarCliente(cte1);
            MiBanco.AgregarCliente(cte2);
            MiBanco.AgregarCliente(cte3);
            MiBanco.AgregarCliente(cte4);

            MiBanco.AgregarCliente(new Cliente("Tello "));
            MiBanco.Clientes[4].AgregarCuenta(new CuentaCheques(3000,900));

            Console.WriteLine("------------Reporte de Clientes-------------");
            Console.WriteLine($"{MiBanco.Nombre}");

            foreach (Cliente cte in MiBanco.Clientes){
                Console.WriteLine($"Cliente: {cte.Nombre}");
                foreach (CuentaBancaria cta in cte.Cuentas){
                    if(cta is CuentaAhorro)
                        Console.WriteLine($"Cuenta de Ahorros {cta.Saldo}");
                    else
                        Console.WriteLine($"Cuenta de Cheques {cta.Saldo}");
                }
                Console.WriteLine(" ");
            }

        }
    }
}
