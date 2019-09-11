using System.Collections.Generic;
namespace ExamenRed.Clases{
    public class Red{
        private string empresa;
        private string propietario;
        private string domicilio;

        private List<Nodo> ip;

        public Red(string empresa, string propietario, string domicilio){
            this.empresa=empresa;
            this.propietario=propietario;
            this.domicilio=domicilio;
            ip = new List<Nodo>();
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
            get {return ip;}
        }

        public List<Nodo> Ip {
             get {return ip;}
        }

        public void AgregarNodo(Nodo nod){
            ip.Add(nod);
        }
    }
}