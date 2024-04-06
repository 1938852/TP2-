using Atelier2C6_101_2024;
using Atelier2C6_101_2024.Application.Poker;

namespace TP2_
{
    internal class Program
    {
        static Util u = new Util();
        static void Main(string[] args)
        {          
            PartiePoker pp = new PartiePoker();
            pp.Jouer();
        }
    }
}
