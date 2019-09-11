using System.Collections.Generic;
namespace RedExamen.Clases{
    public class Nodo{
        private double id;
        private string tipo;
        private double puertos;
        private double saltos;
        private string so;

        private List<Vulnerabilidad> vulnerab;

        public Nodo (double id){
            this.id= id;
            vulnerab = new List<Vulnerabilidad>();
        }

        public double Id{
            get {return id;}
        }
        public string Tipo{
            get {return tipo;}
        }
        public double Puertos{
            get {return puertos;}
        }
        public double Saltos{
            get {return saltos;}
        }
        public string So{
            get {return so;}
        }

        public List<Vulnerabilidad> vulnerabilidads{
            get {return vulnerab;}
        }

        public void AgregarVulnerab(Vulnerabilidad vul){
            vulnerab.Add(vul);
        }
    }
}