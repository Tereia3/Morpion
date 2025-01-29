using System;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Morpion
{
    class Program
    {
        public static int[,] grille = new int[3, 3]; // matrice pour stocker les coups jouÃ©s

        // Fonction pour l'affichage du Morpion
        public static void AfficherMorpion()
        {
            Console.Clear(); //mettre à jour quand partie terminé
            for (int i = 0; i < 3; i++) // boucle permet d'afficher le morpion réelement
            {
                Console.WriteLine(" -------------");
                Console.Write("|");
                for (int j = 0; j < 3; j++) //réutilisation de la boucle FOR en local ET affichage invisiblement
                {
                    if (grille[i, j] == 1)
                        Console.Write(" O |"); //afficher le O
                    else if (grille[i, j] == 2)
                        Console.Write(" X |"); //afficher la X
                    else
                        Console.Write("   |");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" -------------");
        }

        // Fonction pour jouer un coup
        public static bool AJouer(int j, int k, int joueur) //boucle booleen
        {
            if (j >= 0 && j < 3 && k >= 0 && k < 3 && grille[j, k] == 0) //condition: ne pas dépasser entre 0 (j= colonne & k=ligne)
            {
                grille[j, k] = joueur; //déplacemt 60-61 pour faire un boolén 
                return true;
            }
            return false;
        }


        // Programme principal
        static void Main(string[] args) //expliquer pourquoi c'est enlever: 
        {
            //retrait de "int LigneDébut = Console.CursorTop;
            //retrait de "int ColonneDébut = Console.CursorTop;
            int joueur = 1; // 1 pour le joueur 1, 2 pour le joueur 2
            int essais = 0; // compteur des essais
            bool gagner = false;

            // la grille
            for (int i = 0; i < 3; i++) //affiche toutes les conditions de la grille
                for (int j = 0; j < 3; j++) //affiche de tous les condions du joueur dans la grille
                    grille[i, j] = 0;

            while (!gagner && essais < 9)
            {
                AfficherMorpion();
                Console.WriteLine($"C'est au tour du joueur {joueur} :");

                int l, c; //déclaration lingne et colonnes pour afficher le jeu en lui même
                while (true) //ajout d'une boucle while, tant que l'utilisateur respect les lignes et colonnes
                             // si ne respecte pas il va mettre invalide (console.writeline (...)
                {
                    try
                    {
                        Console.Write("Ligne (1-3) : ");
                        l = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("Colonne (1-3) : ");
                        c = int.Parse(Console.ReadLine()) - 1;

                        if (AJouer(l, c, joueur))
                            break;
                        else
                            Console.WriteLine("Position invalide ou dÃ©jÃ  occupÃ©e, veuillez rÃ©essayer.");
                    }
                    catch
                    {
                        Console.WriteLine("EntrÃ©e invalide, veuillez entrer un nombre entre 1 et 3.");
                    }
                }

                essais++;

                joueur = (joueur == 1) ? 2 : 1;
            }

            Console.WriteLine("Fin de la partie. Appuyez sur une touche pour quitter."); //petit message de la fin de la partie
            Console.ReadKey();
        }
    }
}
