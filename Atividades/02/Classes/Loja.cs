using System;
using System.Collections.Generic;

public class Loja
    { 
        public string Nome {  get; private set; }
        public string CNPJ { get; private set;}
        public List<Livro> Livros { get; set; }
        public List<VideoGame> VideoGames { get; set; }

        public Loja(){
            
        }
    public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videogames)
        {
            Nome = nome;
            CNPJ = cnpj;
            Livros = livros;
            VideoGames = videogames;
        }

    public void ListaLivros()
    {
        if (Livros.Count == 0)
        {
         Console.WriteLine ($"A loja não possui livros em seu estoque!");
        }
        foreach (var item in Livros)
        {
            Console.WriteLine($"Título:{item.Nome}, preço : {item.Preco.ToString("C")}, quantidade: {item.Qtd} em estoque.");
        }
    }
    //     public string ListaLivros()
    // {
    //     if (Livros.Count == 0)
    //     {
    //      return $"A loja não possui livros em seu estoque!";
         
    //     }
    //     foreach (var item in Livros)
    //     {
    //      return $"Título:{item.Nome}, preço : {item.Preco.ToString("C")}, quantidade: {item.Qtd} em estoque.";
        
    //     }
    // }

    public void ListaVideoGames()
    {
        if (VideoGames.Count == 0)
        {
        Console.WriteLine ($"A loja não possui Video-Games em seu estoque!");
        }
        foreach (var item in VideoGames)
        {
        Console.WriteLine($"Video-game:{item.Modelo}, preço : {item.Preco.ToString("C")} , quantidade: {item.Qtd} em estoque.");
        }
    }

    public double CalculaPatrimonio()
    {
        double somaLivros = 0.0;
        double somaGames = 0.0;

        if (VideoGames.Count != 0)
        {
            foreach (var item in VideoGames)
        {
            somaGames += item.Preco * item.Qtd;
        }
        }
        if (Livros.Count != 0)
        {
            foreach (var item in Livros)
        {
             somaLivros += item.Preco * item.Qtd;
        }
        }
        return somaLivros + somaGames;
    }
    
    }