using System;
using System.Collections.Generic;
using Xunit;


namespace _02_Teste
{
    public class Testes01
    {
        [Fact]
        public void CalculaImpostoDoLivroSeTemaForEducativo()
        {
            
            //Arrange
            Livro L1 = new ("Java POO", 20.00, 50, "GFT", tema: "educativo", 500);
             
            var expected = 0.0;
                  
            //Act
            
            var result =  L1.CalculaImposto();
            //Assert
            Assert.Equal(expected, result);

        }[Fact]
        public void CalculaImpostoDoLivroSeTemaNaoForEducativo()
        {
            
            //Arrange
            Livro L1 = new ("Java POO", 20.00, 50, "GFT", tema: "Fantasia", 500);
             
            var expected = L1.Preco * 0.1;
                  
            //Act
            
            var result =  L1.CalculaImposto();
            //Assert
            Assert.Equal(expected, result);

        }
          [Fact]
            public void CalculaImpostoDoVideoGameSeEleForUsado()
        {
            //Arrange
            VideoGame Ps4 = new VideoGame("Ps4", 1000, 7, "Sony", "Slim",isUsado: true);
             
            var expected = Ps4.Preco * 0.25;
                  
            //Act
            
            var result =  Ps4.CalculaImposto();
            //Assert
            Assert.Equal(expected, result);
        }
          [Fact]
            public void CalculaImpostoDoVideoGameSeEleNaoForUsado()
        {
            //Arrange
            VideoGame Ps4 = new VideoGame("Ps4", 1000, 7, "Sony", "Slim",isUsado: false);
             
            var expected = Ps4.Preco * 0.45;
                  
            //Act
            
            var result =  Ps4.CalculaImposto();
            //Assert
            Assert.Equal(expected, result);
        }
          [Fact]
            public void CalculaPatrimonioTotalDaLoja()
        {
            //Arrange
            Livro L1 = new ("Java POO", 20.00, 50, "GFT", tema: "Fantasia", 500);
            VideoGame Ps4 = new VideoGame("Ps4", 1000, 7, "Sony", "Slim",isUsado: false);
            List<Livro> livros = new List<Livro>();
            livros.Add(L1);
            List<VideoGame> games = new List<VideoGame>();
            games.Add(Ps4);
            Loja americanas  = new Loja("Americanas", "12345678", livros, games);
            var somaLivros = L1.Preco * L1.Qtd;
            var somaGames = Ps4.Preco * Ps4.Qtd;
             
            var expected = somaLivros + somaGames;
                  
            //Act
            
            var result =  americanas.CalculaPatrimonio();
            //Assert
            Assert.Equal(expected, result);
        }
  
     }
}
