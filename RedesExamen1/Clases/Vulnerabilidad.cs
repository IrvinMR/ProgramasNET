namespace RedExamen.Clases
{
    public class Vulnerabilidad{
         private string clave;
         private string vendedor;
         private string descripcion;
         private string tipo;
         private string fecha;

 //       public Vulnerabilidad() {}
 //       public Vulnerabilidad(string clave) {
 //           this.clave = clave;
 //       }
        
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