using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024.Application.Poker
{
    internal class MainJoueur
    {
        public Carte[] _lesCartes = new Carte[5];
        int _idJoueur;

        public MainJoueur(int idxJoueur) 
        { 
            for(int i=0; i < 5; i++) {
                _lesCartes[i] = new Carte();
            }
            _idJoueur = idxJoueur;
        }

        // Ordonner les cartes en ordre décroissant
        public void Trier()
        {
            Array.Sort(_lesCartes, CompareVal);
        }

        public void Afficher()
        {
            for (int i = 0; i < 5; i++)
            {
                _lesCartes[i].Afficher(true, i, _idJoueur);
            }

            // Afficher le contenu de la main (TEMPORAIRE)
            /*
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(35, (_idJoueur * 4)+4);
            Console.Write("Des cartes! Qui l'eu cru!");*/

            Console.WriteLine("\n\n");
        }     

        public void InitCarte(int idx, Carte laCarte)
        {
            _lesCartes[idx] = laCarte;
        }

        int CompareVal(Carte c1, Carte c2)
        {
            return c2._Valeur.CompareTo(c1._Valeur);
        }

    }
}
