using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demande à l'utilisateur de saisir le montant des dommages
            Console.Write("Montant des dommages : ");
            // Récupère la saisie de l'utilisateur et la convertit en un nombre de type double
            double montantDommages = Convert.ToDouble(Console.ReadLine());

            // Calcule la franchise, qui est 10% du montant des dommages
            double franchise = montantDommages * 0.10;

            // Si la franchise dépasse 4000 euros, on limite la franchise à 4000 euros
            if (franchise > 4000)
            {
                franchise = 4000;
            }

            // Calcule le montant à rembourser en soustrayant la franchise du montant des dommages
            double montantRembourse = montantDommages - franchise;

            // Affiche le montant de la franchise
            Console.WriteLine($"Le montant de la franchise est : {franchise} euros");

            // Affiche le montant qui sera effectivement remboursé
            Console.WriteLine($"Le montant qui sera remboursé est : {montantRembourse} euros");
        }
    }
}
