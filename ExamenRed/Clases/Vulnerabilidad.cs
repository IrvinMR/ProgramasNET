namespace ExamenRed.Clases
{
    public class Vulnerabilidad{
         private string clave;
         private string vendedor;
         private string descripcion;
         private string tipo;
         private string fecha;

        public Vulnerabilidad() { }
        public Vulnerabilidad(string clave, string vendedor, string descripcion, string tipo, string fecha) {
            this.clave = clave;
            this.vendedor=vendedor;
            this.descripcion=descripcion;
            this.tipo=tipo;
            this.fecha=fecha;
        }
        
        public string Clave{
            get { return clave; }
        }

        public string Vendedor{
            get { return vendedor; }
        }

        public string Descripcion{
            get { return descripcion; }
        }

        public string Tipo{
            get { return tipo; }
        }

        public string Fecha{
            get { return fecha; }
        }
    }
}