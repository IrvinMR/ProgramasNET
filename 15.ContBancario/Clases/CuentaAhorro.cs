namespace ContBancario.Clases
{
    public class CuentaAhorro:CuentaBancaria{
        private double tasa;

        public CuentaAhorro(double saldo, double tasa)
            : base (saldo) //invocamos constructor clase base
            {
                this.tasa=tasa;
            }
    }
    
}