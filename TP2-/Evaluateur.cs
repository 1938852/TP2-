using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024.Application.Poker
{
    internal class Evaluateur
    {
        MainJoueur _Main {  get; set; }
        public Evaluateur(MainJoueur main)
        {
            _Main = main;
        }

        public void Evaluer()
        {
            if ((_Main._lesCartes[0]._Valeur - _Main._lesCartes[4]._Valeur == 4) 
                && (_Main._lesCartes[0]._Sorte == _Main._lesCartes[1]._Sorte 
                && _Main._lesCartes[0]._Sorte == _Main._lesCartes[2]._Sorte 
                && _Main._lesCartes[0]._Sorte == _Main._lesCartes[3]._Sorte
                && _Main._lesCartes[0]._Sorte == _Main._lesCartes[4]._Sorte))
            {
                Afficher(SequenceCouleur());
            }
            else if (_Main._lesCartes[0]._Valeur == _Main._lesCartes[3]._Valeur
               || _Main._lesCartes[1]._Valeur == _Main._lesCartes[4]._Valeur)
            {
                Afficher(Carre());
            }
            else if ((_Main._lesCartes[0]._Valeur == _Main._lesCartes[1]._Valeur
                && _Main._lesCartes[2]._Valeur == _Main._lesCartes[4]._Valeur)
                || _Main._lesCartes[0]._Valeur == _Main._lesCartes[2]._Valeur
                && _Main._lesCartes[3]._Valeur == _Main._lesCartes[4]._Valeur)
            {
                Afficher(MainPleine());
            }
            else if (_Main._lesCartes[0]._Sorte == _Main._lesCartes[1]._Sorte
                && _Main._lesCartes[0]._Sorte == _Main._lesCartes[2]._Sorte
                && _Main._lesCartes[0]._Sorte == _Main._lesCartes[3]._Sorte
                && _Main._lesCartes[0]._Sorte == _Main._lesCartes[4]._Sorte)
            {
                // couleur
                Afficher(Couleur());
            }
            else if (_Main._lesCartes[0]._Valeur - _Main._lesCartes[4]._Valeur == 4)
            {
                // Séquence
                Afficher(Sequence());
            }
            else if (_Main._lesCartes[0]._Valeur == _Main._lesCartes[2]._Valeur
               || _Main._lesCartes[1]._Valeur == _Main._lesCartes[3]._Valeur
               || _Main._lesCartes[2]._Valeur == _Main._lesCartes[4]._Valeur)
            {
                // Brelan
                Afficher(Brelan());
            }
            else if ((_Main._lesCartes[0]._Valeur == _Main._lesCartes[1]._Valeur
                && _Main._lesCartes[2]._Valeur == _Main._lesCartes[3]._Valeur)
                || (_Main._lesCartes[1]._Valeur == _Main._lesCartes[2]._Valeur
                && _Main._lesCartes[3]._Valeur == _Main._lesCartes[4]._Valeur)
                || (_Main._lesCartes[0]._Valeur == _Main._lesCartes[1]._Valeur
                && _Main._lesCartes[3]._Valeur == _Main._lesCartes[4]._Valeur))
            {
                // double paire
                Afficher(DoublePaire());
            }
            else if (_Main._lesCartes[0]._Valeur == _Main._lesCartes[1]._Valeur
                || _Main._lesCartes[1]._Valeur == _Main._lesCartes[2]._Valeur
                || _Main._lesCartes[2]._Valeur == _Main._lesCartes[3]._Valeur
                || _Main._lesCartes[3]._Valeur == _Main._lesCartes[4]._Valeur)
            {
                // paire
                Afficher(Paire());
            }
            else
            {
                // Carte la plus forte
                Afficher(CarteForte());
            }
        }

        // J'ai pris une mauvaise approche pour l'evaluation qui m'empeche de valider la valeur des mains...
        private string SequenceCouleur()
        {
            _Main._lesCartes[0].SetValeurTexte();
            _Main._lesCartes[4].SetValeurTexte();
            _Main._lesCartes[0].SetSorteTexte();
            string contenu = $"Séquence couleur de de {_Main._lesCartes[0]._valeurTexte} à {_Main._lesCartes[4]._valeurTexte}, {_Main._lesCartes[0]._sorteTexte}";

            return contenu;
        }
        private string Carre()
        {
            _Main._lesCartes[1].SetValeurTexte();
            string contenu = $"Carré de {_Main._lesCartes[1]._valeurTexte}";

            return contenu;
        }
        private string MainPleine()
        {
            string contenu = "Main pleine";

            return contenu;
        }
        private string Couleur()
        {
            _Main._lesCartes[0].SetSorteTexte();
            string contenu = $"Couleur: {_Main._lesCartes[0]._sorteTexte}";

            return contenu;
        }
        private string Sequence()
        {
            _Main._lesCartes[0].SetValeurTexte();
            _Main._lesCartes[4].SetValeurTexte();
            string contenu = $"Séquence de {_Main._lesCartes[0]._valeurTexte} à {_Main._lesCartes[4]._valeurTexte}";

            return contenu;
        }
        private string Brelan()
        {
            
            string contenu = "Brelan";

            return contenu;
        }
        private string DoublePaire()
        {
            string contenu = "Double paire";

            return contenu;
        }
        private string Paire()
        {
            string contenu = "paire";

            return contenu;
        }
        private string CarteForte()
        {
            _Main._lesCartes[0].SetValeurTexte();
            _Main._lesCartes[0].SetSorteTexte();
            string contenu = $"Carte plus forte : {_Main._lesCartes[0]._valeurTexte} de {_Main._lesCartes[0]._sorteTexte}";

            return contenu;
        }

        private void Afficher(string dansMain)
        {
            Console.Write(dansMain);
        }
    }
}
