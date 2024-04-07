using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024.Application.Poker
{
    internal class PartiePoker
    {
        const int COULEUR_TAPIS = 2;  // Vert
        const int COULEUR_TEXTE = 15; // Blanc
        const int NB_CARTE_DANS_UNE_MAIN = 5;
        const int NB_CARTE_DANS_UN_PAQUET = 52;

        MainJoueur[] _mainsJoueurs = new MainJoueur[4];

        Paquet lePaquet = new Paquet();
        bool partieEnCours = true;

        public PartiePoker()
        {
            for(int i=0; i<4; i++)
            {
                _mainsJoueurs[i] = new MainJoueur(i);
            }
        }
        public void Jouer()
        {
            Util u = new Util();
            u.Titrer("Poker 2C6 ");
            u.Pause();

            while(partieEnCours == true)
            {
                InitTable();


                // Donne 5 cartes aleatoires a chaque joueur
                lePaquet.Brasser();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        _mainsJoueurs[j].InitCarte(i, lePaquet.Distribuer());
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    _mainsJoueurs[i].Trier();
                    _mainsJoueurs[i].Afficher();
                    Evaluateur evaluateur = new Evaluateur(_mainsJoueurs[i]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(35, (i * 4) + 4);
                    evaluateur.Evaluer();
                }

                Console.SetCursorPosition(0, 20);
                Console.Write("Une autre ronde? (o/n)");
                if(u.SaisirChar() == 'n' || u.SaisirChar() == 'N')
                {
                    partieEnCours = false;
                }
            }
            
            
            Console.SetCursorPosition(0, 20);
        }

        void InitTable()
        {
            Console.BackgroundColor = (ConsoleColor)COULEUR_TAPIS;
            Console.ForegroundColor = (ConsoleColor)COULEUR_TEXTE;

            // La ligne suivante permet d'afficher les symboles unicodes des types de carte
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Clear();
        }
    }
}
