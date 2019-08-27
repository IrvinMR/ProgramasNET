using System;

namespace _06.Pizza
{
    class Program
    {
        static int Main(string[] args)
        {
            string tamano="", ingredientes="", cubierta="", para="";
            string[] ing;
            char tam, cub, par;

            if(args.Length<4){
                Console.Clear();
                Console.WriteLine("Debes especificar como quieres tu pizza\n");
                Console.WriteLine("<Tamano> <ing1 + ing2 + ...> <Cubierta> <Para>\n");
                menu();
                return 1;
            }

            //tamaño
            tam=char.Parse(args[0]);
            if(tam=='P') tamano="Pequeño";
            else if(tam=='M') tamano="Mediano";
            else tamano="Grande";

            //ingredientes
            ing= args[1].Split("+");
            foreach (string i in ing) {
                if(i=="E") ingredientes+="Extra queso ";
                else if(i=="C") ingredientes+="Champiñones ";
                else if(i=="P") ingredientes+="Peperoni ";                
            }

            //cubierta
            cub=char.Parse(args[2]);
            if(cub=='D') cubierta = "Delgada";
            else cubierta= "Gruesa";

            //para
            par=char.Parse(args[3]);
            if(par=='A') para = "Aqui";
            else para = "Llevar";

            //omprimir pedido
            Console.WriteLine("Tu orden es una pizza con:\n");
            Console.WriteLine($"Tamaño:------------{tamano}");
            Console.WriteLine($"Ingredientes:------{ingredientes}");
            Console.WriteLine($"Cubierta:----------{cubierta}");
            Console.WriteLine($"Para:--------------{para}");

            return 0;
        }
        static void menu(){
            Console.WriteLine("---------------Menu---------------\n");
            Console.WriteLine("Tamaño:   [P]equeña [M]ediana [G]rande");
            Console.WriteLine("Ingredientes: [E]xtra Queso [C]hampiñones [P]eperoni");
            Console.WriteLine("Cubierta:      [D]elgada  [G]ruesa");
            Console.WriteLine("Para Comer:        [A]quí o [L]levar");

        }
    }
}
