﻿using System;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Morpion
{
    class Program
    {
        public static int[,] grille = new int[3, 3]; // matrice pour stocker les coups joués

        // Fonction permettant l'affichage du Morpion
        public static void AfficherMorpion(int j, int k)
        {
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

        }

        // Fonction permettant de changer
        // dans le tableau qu'elle est le 
        // joueur qui à jouer
        // Bien vérifier que le joueur ne sort
        // pas du tableau et que la position
        // n'est pas déjà jouée
        public static bool AJouer(int j, int k, int joueur)
        {
            // A compléter
            //initialiser une var bool en "false"
            //boucler en "while false" et réaliser une variable "JOUEUR"
            if (j >= 0 && j < 3 && k >= 0 && k < 3 && grille[j, k] == 0)
            {
                grille[j, k] = joueur;
                return true;
            }
            return false;
        }

        // Fonction permettant de vérifier
        // si un joueur à gagner
        public static bool Gagner(int l, int c, int joueur)
        {
            // A compléter 
            for (int i = 0; i < 3; i++)
            {
                // VÃ©rif des lignes
                if (grille[i, 0] == joueur && grille[i, 1] == joueur && grille[i, 2] == joueur)
                    return true;

                // VÃ©rif des colonnes
                if (grille[0, i] == joueur && grille[1, i] == joueur && grille[2, i] == joueur)
                    return true;
            }

            // VÃ©rif des diagonales
            if (grille[0, 0] == joueur && grille[1, 1] == joueur && grille[2, 2] == joueur)
                return true;

            if (grille[0, 2] == joueur && grille[1, 1] == joueur && grille[2, 0] == joueur)
                return true;

            return false;
        }

        // Programme principal
        static void Main(string[] args)
        {

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
            while (!gagner && essais != 9)
            {

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

                    // A compléter 

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                // Changement de joueur
                // A compléter 

            }; // Fin TQ

            // Fin de la partie
            // A compléter
            Console.WriteLine("Fin de la partie. Appuyez sur une touche pour quitter.");
            Console.ReadKey();
        }
    }
}
