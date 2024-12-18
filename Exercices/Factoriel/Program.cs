using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boucle principale du programme
            do
            {
                // Demander un nombre valide à l'utilisateur
                int nombre = DemanderNombre();

                // Calculer la factorielle
                int result = Factoriel(nombre);

                // Afficher le résultat
                Console.WriteLine($"La factorielle de {nombre} est {result}");

            } while (DemanderContinuer()); // Si l'utilisateur choisit de continuer

            // Message de fin lorsque l'utilisateur quitte
            Console.WriteLine("Au revoir !");

        }

        // Fonction pour demander à l'utilisateur s'il veut continuer ou quitter
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
        static public int Factoriel(int n)
        {
            // Cas de base : 0! = 1
            if (n == 0)
            {
                return 1;
            }
            // Cas récursif : n! = n * (n-1)!
            else
            {
                return n * Factoriel(n - 1);
            }
        }
        
    }
}
