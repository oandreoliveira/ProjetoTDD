using System;

public class Livro : Produto, Imposto
    {
        public string Autor { get; private set; }
        public string Tema { get; private set; }
        public int QtdPag { get; private set; }
        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome, preco, qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
            Autor = autor;
            Tema = tema;
            QtdPag = qtdPag;
        }

        public double CalculaImposto()
        {
            if (Tema.Equals("educativo"))
            { 
                Console.Write($"Livro educativo não tem impostos: {this.Nome}.");
                return 0;
                
            }
                
                return Preco * 0.1; 
                
            
        }
    }