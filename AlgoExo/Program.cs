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
            List<Menu> list = new List<Menu>
            {
                new Menu{Numero = 1, Titre = "Menu 1"},
                new Menu{Numero = 2, Titre = "Menu 2"},
                new Menu{Numero = 42, Titre = "Menu 42"},
            };
            int result = GererMenu(list);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public static int GererMenu(List<Menu> menu)
        {
            //Affiche les éléments du menu
            foreach (Menu line in menu)
            {
                Console.WriteLine($"{line.Numero}-{line.Titre.ToUpper()}");
            }
            //Récupère le choix utilisateur
            Console.WriteLine("Saisissez un choix");
            int choix;
            choix = int.Parse(Console.ReadLine());

            //test du choix par rapport aux éléments du menu

            foreach (Menu item in menu)
            {
                if (item.Numero == choix)
                {
                    return choix;
                }
            }
            Console.WriteLine("Erreur lors de la saisie");
            return -1;

        }


    }
}
