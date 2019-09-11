using System;
using ExamenRed.Clases;

namespace ExamenRed
{
    class Program
    {
        static void Main(string[] args){
            // crear red
            Red mired= new Red ("Los amigos","El gober precioso","Las florecitas 12");
            //crear nodos
            Nodo nod1 = new Nodo("192.168.0.10","Servidor",5,10,"Linux");
            Nodo nod2 = new Nodo("192.168.0.12","Equipo activo",2,12,"IOS");
            Nodo nod3 = new Nodo("192.168.0.15","computadora",8,5,"Windows");
            Nodo nod4 = new Nodo("192.168.0.20","Servidor",10,22,"Linux");

            Console.WriteLine("--------Datos Generales de la Red----------");
            Console.WriteLine($"Empresa      : {mired.Empresa}\nPropietario  : {mired.Propietario}\nDomicilio    : {mired.Domicilio}");

            Console.WriteLine("\nTotal de nodos de la red");
            Console.WriteLine("Total de vulnerabilidades\n");

            Console.WriteLine("--------Datos Generales de los Nodos--------");
            Console.WriteLine($"Ip : {nod1.Ip}, Tipo : {nod1.Tipo}, Puertos : {nod1.Puertos}, Saltos : {nod1.Saltos}, So : {nod1.Saltos}");
            Console.WriteLine($"Ip : {nod2.Ip}, Tipo : {nod2.Tipo}, Puertos : {nod2.Puertos}, Saltos : {nod2.Saltos}, So : {nod2.Saltos}");
            Console.WriteLine($"Ip : {nod3.Ip}, Tipo : {nod3.Tipo}, Puertos : {nod3.Puertos}, Saltos : {nod3.Saltos}, So : {nod3.Saltos}");
            Console.WriteLine($"Ip : {nod4.Ip}, Tipo : {nod4.Tipo}, Puertos : {nod4.Puertos}, Saltos : {nod4.Saltos}, So : {nod4.Saltos}");

            //crear vulnerabilidades
            Console.WriteLine("\n--------Vulnerabilidades por Nodos--------");
            Vulnerabilidad vul1= new Vulnerabilidad("CVE-2015-1635","microsoft","HTTP.sys permite a atacantes remotos ejecutar código arbitrario","remota","04/14/2015");
            Vulnerabilidad vul2= new Vulnerabilidad("CVE-2017-0004","microsoft","El servicio LSASS permite causar una denegación de servicio","local","01/10/2001");
            Vulnerabilidad vul3= new Vulnerabilidad("CVE-2017-3847","cisco","Cisco Firepower Management Center XSS","remota","02/21/2017");
            Vulnerabilidad vul4= new Vulnerabilidad("CVE-2009-2504","microsoft","Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1","local","11/13/2009");
            Vulnerabilidad vul5= new Vulnerabilidad("CVE-2016-7271","microsoft","Elevación de privilegios Kernel Segura en Windows 10 Gold","local","12/20/2016");
            Vulnerabilidad vul6= new Vulnerabilidad("CVE-2017-2996","adobe","Adobe Flash Player 24.0.0.194 corrupción de memoria explotable","remota","15/05/2017");

            mired.AgregarNodo(nod1);
            mired.AgregarNodo(nod2);
            mired.AgregarNodo(nod3);
            mired.AgregarNodo(nod4);

            nod1.AgregarVulnerab(vul1);
            nod1.AgregarVulnerab(vul2);
            nod2.AgregarVulnerab(vul3);
            nod3.AgregarVulnerab(vul4);
            nod3.AgregarVulnerab(vul5);
            nod3.AgregarVulnerab(vul6);
           // nod4.AgregarVulnerab( );

            foreach (Nodo nod in mired.Ip){
                Console.WriteLine(" ");
                Console.WriteLine($"Ip : {nod.Ip},Tipo : {nod.Tipo}");
                Console.WriteLine("Vulnerabilidades");
                foreach (Vulnerabilidad vul in nod.Vulnerab ){
                    Console.WriteLine($"Clave : {vul.Clave}, Vendedor : {vul.Vendedor}, Descripcion : {vul.Descripcion}, Tipo : {vul.Tipo}, Fecha : {vul.Fecha}");
                    
                }
            }


            
        }
    }
}
