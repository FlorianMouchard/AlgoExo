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
            menu.InsertLine(new MenuItem { Numero = 1, Titre = "Voyages" });
            menu.InsertLine(new MenuItem { Numero = 2, Titre = "Clients" });
            menu.InsertLine(new MenuItem { Numero = 3, Titre = "Dossiers" });


            menu.Afficher();
            int resultat = menu.Choisir();
            switch (resultat)
            {
                case 1:
                    {
                        SousMenuVoyages();
                        break;
                    }
                case 2:
                    {
                        SousMenuClients();
                        break;
                    }
                case 3:
                    {
                        SousMenuDossiers();
                        break;
                    }
            }
            Console.ReadKey();
        }

        private static void SousMenuDossiers()
        {
            Menu sousMenu = new Menu();
            sousMenu.InsertLine(new MenuItem { Numero = 1, Titre = "Créer" });
            sousMenu.InsertLine(new MenuItem { Numero = 2, Titre = "Supprimer" });

            sousMenu.Afficher();
            int resultatsChoix = sousMenu.Choisir();
            switch (resultatsChoix)
            {
                case 1:
                    {
                        Console.WriteLine("Vous souhaitez: Dossiers => Créer");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Vous souhaitez: Dossiers => Supprimer");
                        break;
                    }
            }
        }

        private static void SousMenuClients()
        {
            Menu sousMenu = new Menu();
            sousMenu.InsertLine(new MenuItem { Numero = 1, Titre = "Ajouter" });
            sousMenu.InsertLine(new MenuItem { Numero = 2, Titre = "Rechercher" });
            sousMenu.InsertLine(new MenuItem { Numero = 3, Titre = "Supprimer" });

            sousMenu.Afficher();
            int resultatsChoix = sousMenu.Choisir();
            switch (resultatsChoix)
            {
                case 1:
                    {
                        Console.WriteLine("Vous souhaitez: Clients => Ajouter");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Vous souhaitez: Clients => Rechercher");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Vous souhaitez: Clients => Supprimer");
                        break;
                    }
            }
        }

        private static void SousMenuVoyages()
        {
            Menu sousMenu = new Menu();
            sousMenu.InsertLine(new MenuItem { Numero = 1, Titre = "Destinations" });
            sousMenu.InsertLine(new MenuItem { Numero = 2, Titre = "Compagnie" });

            sousMenu.Afficher();
            int resultatsChoix = sousMenu.Choisir();
            switch (resultatsChoix)
            {
                case 1 :
                    {
                        Console.WriteLine("Vous souhaitez: Voyages => Destination");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Vous souhaitez: Voyages => Compagnies");
                        break;
                    }
            }
        }
    }
}
