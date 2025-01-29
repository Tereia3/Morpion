using System;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Morpion
{
    class Program
    {
        public static int[,] grille = new int[3, 3]; // matrice pour stocker les coups joués

        // Fonction pour l'affichage du Morpion
        public static void AfficherMorpion()
        {
<<<<<<< HEAD
            Console.Clear(); // permet de mettre à jour quand une partie terminé
            for (int j = 0; j < 3; j++) // boucle for permetant d'afficher le tableau de dimention réelement
            {
                Console.WriteLine(" -------------");
                Console.Write("|");
                for (int i = 0; i < 3; i++) //réutilisation de la boucle FOR en local ET affichage invisible
                {
                    if (grille[j, i] == 1) //joueur 1 va joué en entrant des chiffres [0-3]
                        Console.Write(" O |"); //afficher le O
                    else if (grille[j, i] == 2) //joueur 2 va joué en entrant des chiffres [0-3]
                        Console.Write(" X |"); //afficher la X
                    else
                        Console.Write("   |");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" -------------");
=======
            // A compléter
            for (var p = 0; p < grille.GetLength(0); p++)
            {
                Console.Write("\n|----|----|----|\n");
                Console.Write("|");
                for (var i = 0; i < grille.GetLength(1); i++)
                {
                    Console.Write("    ");
                    Console.Write("|");
                }
            }
            Console.Write("\n|----|----|----|\n");

>>>>>>> 003d271b0d1b314e2c0006bfa5e11582fe81fda3
        }

        // Fonction pour jouer un coup
        public static bool AJouer(int l, int c, int joueur) //boucle booleen à false
        {
<<<<<<< HEAD
            if (l >= 0 && l < 3 && c >= 0 && c < 3 && grille[l, c] == 0) //condition: ne pas dépasser entre 0 et 3 (c= colonne & l=ligne)
            {
                grille[l, c] = joueur; //déplacement 60-61 pour faire un boolén 
=======
            // A compléter
            //initialiser une var bool en "false"
            //boucler en "while false" et réaliser une variable "JOUEUR"
            if (j >= 0 && j < 3 && k >= 0 && k < 3 && grille[j, k] == 0)
            {
                grille[j, k] = joueur;
>>>>>>> 003d271b0d1b314e2c0006bfa5e11582fe81fda3
                return true;
            }
            return false;
        }

<<<<<<< HEAD
=======
        // Fonction permettant de vérifier
        // si un joueur à gagner
        public static bool Gagner(int l, int c, int joueur)
        {

            // A compléter 
            return false;
        }
>>>>>>> 003d271b0d1b314e2c0006bfa5e11582fe81fda3

        // Programme principal
        static void Main(string[] args) //expliquer pourquoi c'est enlever: 
        {
<<<<<<< HEAD
            //retrait de "int LigneDébut = Console.CursorTop;
            //retrait de "int ColonneDébut = Console.CursorTop;
            int joueur = 1; // 1 pour le joueur 1, 2 pour le joueur 2
            int essais = 0; // compteur des essais
            bool gagner = false;

            // la grille
            for (int j = 0; j < 3; j++) //affiche toutes les conditions de la grille
                for (int k = 0; k < 3; k++) //affiche de tous les condions du joueur dans la grille
                    grille[j, k] = 0;

=======

            //--- Déclarations et initialisations --
            int LigneDébut = Console.CursorTop;     // par rapport au sommet de la fenêtre
            int ColonneDébut = Console.CursorLeft; // par rapport au sommet de la fenêtre

            int essais = 0;    // compteur d'essais
            int joueur = 1;   // 1 pour la premier joueur, 2 pour le second
            int l, c = 0;      // numéro de ligne et de colonne
            int j, k = 0;      // Parcourir le tableau en 2 dimensions
            bool gagner = false; // Permet de vérifier si un joueur à gagné 
            bool bonnePosition = false; // Permet de vérifier si la position souhaité est disponible

            //--- initialisation de la grille ---
            // On met chaque valeur du tableau à 10
            for (j = 0; j < grille.GetLength(0); j++)
                for (k = 0; k < grille.GetLength(1); k++)
                    grille[j, k] = 10;
>>>>>>> 003d271b0d1b314e2c0006bfa5e11582fe81fda3
            while (!gagner && essais != 9)
            {
                AfficherMorpion();
                Console.WriteLine($"C'est au tour du joueur {joueur} :");//réutilisation de la variable joueur au lieu de mettre complètement trois lignes

<<<<<<< HEAD
                int l, c; //déclaration lingne et colonnes pour afficher le jeu en lui même
                while (true) //ajout d'une boucle while, tant que l'utilisateur respect les lignes et colonnes
                             // si ne respecte pas il va mettre invalide (console.writeline (...)
                {
                    try
                    {
                        Console.Write("Ligne (1-3) : "); //affichage pour indiquer qu'il faut entrer des chiffres entre 1 et 3
                        l = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("Colonne (1-3) : ");
                        c = int.Parse(Console.ReadLine()) - 1;
=======
                // A compléter 
                AfficherMorpion(j, k);
                try
                {
                    Console.WriteLine("C'est au tout du joueur 1  :    ");
                    Console.WriteLine("Ligne   =    ");
                    Console.WriteLine("Colonne =    ");
                    // Peut changer en fonction de comment vous avez fait votre tableau.
                    Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 9); // Permet de manipuler le curseur dans la fenêtre 
                    l = int.Parse(Console.ReadLine()) - 1;
                    // Peut changer en fonction de comment vous avez fait votre tableau.
                    Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 10); // Permet de manipuler le curseur dans la fenêtre 
                    c = int.Parse(Console.ReadLine()) - 1;
>>>>>>> 003d271b0d1b314e2c0006bfa5e11582fe81fda3

                        if (AJouer(l, c, joueur))
                            break;
                        else
                            Console.WriteLine("Position invalide ou déja occuppé, veuillez réessayer."); //méssage de prévention si case occupé
                    }
                    catch
                    {
                        Console.WriteLine("Entrer invalide, veuillez entrer un nombre entre 1 et 3.");
                    }
                }

                essais++;

<<<<<<< HEAD
                joueur = (joueur == 1) ? 2 : 1;
            }

            Console.WriteLine("Fin de la partie. Appuyez sur une touche pour quitter."); //petit message préalablement mit pour une fin de partie
=======
            }; // Fin TQ

            // Fin de la partie
            // A compléter
            Console.WriteLine("Fin de la partie. Appuyez sur une touche pour quitter.");
>>>>>>> 003d271b0d1b314e2c0006bfa5e11582fe81fda3
            Console.ReadKey();
        }
    }
}
