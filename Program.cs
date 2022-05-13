using System;
using Projeto1GFT.src.Models;


namespace projeto1gft
{
    class Program
    {

        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Leonor", 76, "Wizard");
            Archer archer = new Archer("Robin", 78, "Archer");
            Beserker beserker = new Beserker("Khorn", 81, "Beserker");
            Knight knight = new Knight("Meranus", 81, "Knight");
            Priest priest = new Priest("Elliot", 80, "Priest");

        
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(archer.Attack(8));
            Console.WriteLine(beserker.Attack(8));
            Console.WriteLine(knight.Attack());
            Console.WriteLine(priest.Attack(6));
        
        }

    }
}




