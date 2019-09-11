using System.Collections.Generic;
namespace ExamenRed.Clases{
    public class Nodo{
        private string ip;
        private string tipo;
        private double puertos;
        private double saltos;
        private string so;

        private List<Vulnerabilidad> vulnerab;

        public Nodo (string ip,string tipo, double puertos, double saltos,string so){
            this.ip= ip;
            this.tipo=tipo;
            this.puertos=puertos;
            this.saltos=saltos;
            this.so=so;
            vulnerab = new List<Vulnerabilidad>();
        }

        public string Ip{
            get {return ip;}
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

        public List<Vulnerabilidad> Vulnerab{
            get {return vulnerab;}
        }

        public void AgregarVulnerab(Vulnerabilidad vul){
            vulnerab.Add(vul);
        }
    }
}