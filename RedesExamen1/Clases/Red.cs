using System.Collections.Generic;
namespace RedExamen.Clases{
    public class Red{
        private string empresa;
        private string propietario;
        private string domicilio;

        private List<Nodo> id;

        public Red(string empresa, string propietario, string domicilio){
            this.empresa=empresa;
            this.propietario=propietario;
            this.domicilio=domicilio;
            id = new List<Nodo>();
        }

        public string Empresa{
            get {return empresa;}
        }
        public string Propietario{
            get {return propietario;}
        }

        public string Domicilio{
            get {return domicilio;}
        }

        public List<Nodo> Id{
            get {return id;}
        }

        public void AgregarNodo(Nodo nod){
            id.Add(nod);
        }
    }
}