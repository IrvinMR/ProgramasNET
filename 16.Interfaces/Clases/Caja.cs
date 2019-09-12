namespace Interfaces.Clases{
    public class Caja : ICaja, IDimension{

        public string Color { get ; set ; }
        public bool EstaAbierta { get ; set ; }
        public string Contenido { get ; set ; }
        public double largo { get ; set ; }
        public double ancho { get ; set ; }

        public Caja(){
        }

        public Caja(string color, bool estaAbierta, string contenido){
            Color = color;
            EstaAbierta = estaAbierta;
            Contenido = contenido;
        }

        public Caja(string color, bool estaAbierta, string contenido, double largo, double ancho) : this(color, estaAbierta, contenido)
        {
            //este constructor manda llamar al que ya existia para agregar los parametros faltantes
            this.largo = largo;
            this.ancho = ancho;
        }

        public void Abrir(){

            if (!EstaAbierta) EstaAbierta=true;
        }

        public void Cerrar(){
            if (EstaAbierta) EstaAbierta=false;
        }

        public string Medidas()
        {
            return $"({largo} x {ancho})";
        }
    }
}