using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExo.Classes_Menu
{
    public class Menu
    {
        private List<MenuItem> menuItems;
        public Menu()
        {
            menuItems = new List<MenuItem>();
        }

        public void Afficher()
        {
            
            foreach (MenuItem line in menuItems)
            {
                Console.WriteLine($"{line.Numero}-{line.Titre.ToUpper()}");
            }
        }
        public void InsertLine(MenuItem item)
        {
            
           /* foreach (var line in menuItems)
            {
                if (line.Numero == item.Numero)
                {
                    throw new ArgumentException($"Le numéro {item.Numero} existe déjà dans le menu");
                }
                
            }*/
            if(menuItems.Exists( x=> x.Numero == item.Numero))
            {
                throw new ArgumentException($"Le numéro {item.Numero} existe déjà dans le menu");
            }
            menuItems.Add(item);
        }
        public int Choisir()
        {
            //Récupère le choix utilisateur
            Console.WriteLine("Saisissez un choix");
            int choix;
            choix = int.Parse(Console.ReadLine());

            //test du choix par rapport aux éléments du menu

            foreach (MenuItem item in menuItems)
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
