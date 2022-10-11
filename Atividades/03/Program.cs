using System;
using System.Collections.Generic;

namespace _03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program.play3();

        }

        public static void play3()
        {
            List<string> habilidadeInicial = new List<string> { "Personagem Aprendendo habilidades..." };
            List<string> MagiaInicial = new List<string> { "Personagem Aprendendo Magias..." };
            Guerreiro ninja = new Guerreiro("ninja", 100, 100, 100, 100, 500, 1, habilidadeInicial);
            Mago Zara = new Mago("Zara", 50, 100, 800, 200, 10, 1, MagiaInicial);
            Console.WriteLine("===========================");

            Zara.AprenderMagia("Ressucitar");

            Console.WriteLine($"{Zara.Nome} deu um ataque de: {Zara.Attack()}");

            Zara.lvlUp();
            Console.WriteLine($"O Level de Zara é : {Zara.Level}");

            Console.WriteLine("===========================");

            ninja.AprenderHabilidade("Adaga");

            Console.WriteLine($"{ninja.Nome} deu um ataque de: {ninja.Attack()}");

            ninja.lvlUp();
            Console.WriteLine($"O Level do Ninja é : {ninja.Level}");
            Console.WriteLine("===========================");

            Zara.AprenderMagia("Dragão de Fogo");

            Console.WriteLine($"{Zara.Nome} deu um ataque de: {Zara.Attack()}");

            Zara.lvlUp();
            Console.WriteLine($"O Level de Zara é : {Zara.Level}");

            Console.WriteLine("===========================");
            ninja.AprenderHabilidade("Ataque Hanzo");

            Console.WriteLine($"{ninja.Nome} deu um ataque de: {ninja.Attack()}");

            ninja.lvlUp();
            Console.WriteLine($"O Level do Ninja é : {ninja.Level}");
            Console.WriteLine("===========================");
        }
    }
}
