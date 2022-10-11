using System;
using System.Collections.Generic;


namespace _02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program.play2();
        }
        public static void play2()
        {

            Livro l1 = new Livro("Harry Potter", 40, 50, "J. K. Rolling", "fantasia", 300);
            Livro l2 = new Livro("O Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            Livro l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("Ps4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("Ps4", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<VideoGame> games = new List<VideoGame>();
            games.Add(ps4);
            games.Add(ps4Usado);
            games.Add(xbox);

            Loja americanas = new Loja("Americanas", "12345678", livros, games);

            Console.WriteLine();

            Console.WriteLine($"R$ {l2.CalculaImposto().ToString("C")} de impostos sobre o livro {l2.Nome}.");
            Console.WriteLine(l3.CalculaImposto());


            Console.WriteLine($"Imposto {ps4Usado.Nome} é: R$ {ps4Usado.CalculaImposto().ToString("C")}");
            Console.WriteLine($"Imposto {ps4.Nome} é: R$ {ps4.CalculaImposto().ToString("C")}");

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"A Loja {americanas.Nome} possui estes livros para venda:");
            americanas.ListaLivros();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"A Loja {americanas.Nome} possui estes video-games para venda:");
            americanas.ListaVideoGames();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"O patrimônio da loja: {americanas.Nome} é de R$ {americanas.CalculaPatrimonio().ToString("C")}");
            Console.WriteLine();
        }



    }
}
