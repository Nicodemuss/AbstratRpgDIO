using System;
using abs_RPG.src.entities;

namespace abs_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight aarus = new Knight("aarus", 15, "guerreiro");
            Mage moona = new Mage("Moona", 17, "Maga");
            Console.WriteLine(aarus.ToString());
            //x>30 para efeito
            Console.WriteLine(aarus.Attack(59));
            Console.WriteLine(moona.ToString());
            Console.WriteLine(moona.Attack());

        }
    }
}
