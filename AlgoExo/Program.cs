using AlgoExo.Classes_Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExo
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Menu menu = new Menu();
            menu.InsertLine(new MenuItem { Numero = 1, Titre = "Menu 1" });
            menu.InsertLine(new MenuItem { Numero = 2, Titre = "Menu 2" });
            menu.InsertLine(new MenuItem { Numero = 41, Titre = "Menu 42" });
            menu.InsertLine(new MenuItem { Numero = 42, Titre = "La réponse à la grande question" });

            menu.Afficher();
            int resultat = menu.Choisir();
            Console.WriteLine(resultat);
            Console.ReadKey();
        } 
        
    }
}
