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
        }
        public static int GererMenu(List<Menu> menu)
        {
            foreach (Menu line in menu)
            {
                Console.WriteLine($"{line.Numero}-{line.Titre}");
            }
            int choix;
            choix = int.Parse(Console.ReadLine());

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
