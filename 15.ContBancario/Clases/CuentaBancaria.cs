namespace ContBancario.Clases
{
    public class CuentaBancaria{
        //private double saldo;
        protected double saldo; //permite acceso a las clases que hereden
        
        public CuentaBancaria() {}
        public CuentaBancaria(double saldo) {
            this.saldo = saldo;
        }
        
        public double Saldo{
            get { return saldo; }
        }

        public void Deposita(double cantidad){
            if (cantidad>0)
                saldo+=cantidad;
        }

        public virtual bool Retirar(double cantidad){ //virtual permite la sobrecarga para no tener que hacer otro metodo con el mismo nombre
            if(saldo>=cantidad){
                saldo-=cantidad;
                return true;
            } else return false;

        }
    }
}