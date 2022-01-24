using System;
using RPG.src.Entities;
using  static System. Console;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Random valorAleatorio = new Random();
            int meleeAtk;
            meleeAtk = valorAleatorio.Next(30);

            Random valorAle = new Random();
            int magicAtk;
            magicAtk = valorAleatorio.Next(30);

            Warrior leon  = new Warrior("Leon", 22, "Warrior", 100, 10);
            Wizard merlin  = new Wizard("Merlin", 22, "Wizard", 100, 95);
            Archer fletcher = new Archer("Fletcher", 20, "Archer", 90, 10);

            Devil firegoo = new Devil("Fire Goo", 55, "Devil", 170, 110);
            Zombi dogzombi = new Zombi("Dog Zombi", 45, "Zombi", 140, 20);

            WriteLine(leon);
            WriteLine(leon.Attack() + " " + meleeAtk);

            WriteLine(merlin);
            WriteLine(merlin.Attack(4) + " " + magicAtk);

            WriteLine(fletcher);
            WriteLine(fletcher.Attack(5) + " " + meleeAtk);

            WriteLine(firegoo);
            WriteLine(firegoo.Attack(6) + " " + magicAtk);

            WriteLine(dogzombi);
            WriteLine(dogzombi.Attack() + " " + meleeAtk);
            
        }
    }
}