using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {
                int nombre = DemanderNombre();
                geometrie(nombre);
            } while (DemanderContinuer());

        }
        static void geometrie(int nombre)
        {
            for (int i = 0; i < nombre; i++)  // Chaque ligne
            {
                for (int j = 0; j < nombre; j++)  // Chaque colonne
                {
                    Console.Write("* ");  // Afficher le caractère étoile
                }
                Console.WriteLine();  // Sauter à la ligne suivante après avoir affiché une ligne du carré
            }
        }
        static bool DemanderContinuer()
        {
            string reponse;
            while (true)
            {
                // Demander à l'utilisateur s'il veut continuer ou quitter
                Console.WriteLine("Continuer (C) ou Quitter (Q / q) ?");
                reponse = Console.ReadLine()?.ToLower();

                // Vérifier la réponse
                if (reponse == "c")
                    return true; // L'utilisateur veut continuer
                else if (reponse == "q" || reponse == "q")
                    return false; // L'utilisateur veut quitter
                else
                {
                    // Si l'utilisateur entre une réponse invalide, lui demander à nouveau
                    Console.WriteLine("Réponse invalide. Veuillez saisir 'C' pour continuer ou 'Q'/'q' pour quitter.");
                }
            }
        }
        // Fonction pour demander un nombre entier positif à l'utilisateur
        static int DemanderNombre()
        {
            int nombre;
            while (true)
            {
                // Demander à l'utilisateur de saisir un nombre
                Console.Write("Saisir un nombre positif :");

                // Lire l'entrée utilisateur et vérifier si c'est un entier
                if (int.TryParse(Console.ReadLine(), out nombre) && nombre >= 0)
                {
                    return nombre; // Retourner le nombre valide
                }
                else
                {
                    // Si l'entrée est invalide, afficher un message d'erreur
                    Console.WriteLine("Entrée invalide. Veuillez saisir un nombre entier positif.");
                }
            }
        }


    }
}
