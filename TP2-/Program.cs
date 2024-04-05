using Atelier2C6_101_2024;
using Atelier2C6_101_2024.Application.Poker;

namespace TP2_
{
    internal class Program
    {
        static Util u = new Util();
        static void Main(string[] args)
        {
            u.Titrer("Partie de Poker");
            u.Pause();

            PartiePoker pp = new PartiePoker();
            pp.Jouer();
        }
    }
}
