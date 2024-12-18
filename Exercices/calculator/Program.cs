using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int nomnre = DemanderNombre();

            } while (DemanderContinuer());

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
        // Fonction pour demander un operateur arithmetique à l'utilisateur
        static Operateur()
        {

        }

        static bool DemanderContinuer()
        {
            string reponse;
            while (true)
            {
                // Demander à l'utilisateur s'il veut continuer ou quitter
                Console.WriteLine("Continuer  ou Quitter (=) ?");
                reponse = Console.ReadLine()?.ToLower();

                // Vérifier la réponse
                if (reponse != "=")
                    return true; // L'utilisateur veut continuer
                else if (reponse == "=")
                    return false; // L'utilisateur veut quitter
                else
                {
                    // Si l'utilisateur entre une réponse invalide, lui demander à nouveau
                    Console.WriteLine("Réponse invalide. Veuillez saisir un operateur(*,+,-/,**)  pour continuer ou '=' pour quitter.");
                }
            }
        }
        

    }
}
