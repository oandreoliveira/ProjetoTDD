using System;
using Xunit;
using _03;
using System.Collections.Generic;

namespace _03_Teste
{
    public class Testes01
    {
        // Mago
        [Fact]
        public void LvlUpDeveAumentarLevelinteligenciaEManaDoMago()
        {
        //Arrange
         List<string> MagiaInicial = new List<string> {"Personagem Aprendendo Magias..."};
         Mago M1 = new (nome: "M1",vida : 10, mana: 10, xp: 10, inteligencia: 20, forca: 5, level: 0, magias : MagiaInicial);
        
        var expectedLevel = 1;  
        var expectedInteligncia = 21; 
        var expectedMana = 11;           
            
        //Act
        M1.lvlUp();   
        var resultLevel = M1.Level;
        var resultInteligencia = M1.Inteligencia;
        var resultMana = M1.Mana;
        
        //Assert
        Assert.Equal(expectedLevel, resultLevel); 
        Assert.Equal(expectedInteligncia, resultInteligencia); 
        Assert.Equal(expectedMana, resultMana); 
        }

        [Fact]
        public void AprenderMagiaDeveAdicionarMagiaNaListaMagiaDoMago()
        {
        //Arrange
        List<string> MagiaInicial = new List<string> {"Personagem Aprendendo Magias..."};
        Mago M1 = new (nome: "M1",vida : 10, mana: 10, xp: 10, inteligencia: 20, forca: 5, level: 0, magias : MagiaInicial);
        var magia = "Nova Magia";
        var expected = true;
         //Act
        var result = M1.AprenderMagia(magia);
         //Assert
        Assert.Equal(expected, result);    
        Assert.Contains(M1.Magia, m => m == magia);
        }

        [Fact]
        public void AttackDoMagoDeveRetornarDanoDe1A300SomadoComInteligenciaVezesLevel()
        {
         List<string> MagiaInicial = new List<string> {"Personagem Aprendendo Magias..."};
         Mago M1 = new (nome: "M1",vida : 10, mana: 10, xp: 10, inteligencia: 20, forca: 5, level: 2, magias : MagiaInicial);
         var ataque = M1.Inteligencia * M1.Level;
        //Act
        
        var result = M1.Attack();
   
        //Assert
        Assert.True(result > 0); 
        Assert.True(result >= ataque);
        Assert.True (ataque <= 300 + ataque);
        
        }

        // Guerreiro

        [Fact]
        public void LvlUpDeveAumentarLevelForcaEVidaDoGuereiro()
        {

        //Arrange
         List<string> habilidadeInicial = new List<string> {"Personagem Aprendendo habilidades..."};
         Guerreiro G1 = new (nome: "G1",vida : 10, mana: 10, xp: 10, inteligencia: 20, forca: 5, level: 0, habilidades : habilidadeInicial);
        
        var expectedLevel = 1;  
        var expectedForca = 6; 
        var expectedVida = 11;           
            
        //Act
        G1.lvlUp();   
        var resultLevel = G1.Level;
        var resultForca = G1.Forca;
        var resultVida = G1.Vida;
        
        //Assert
        Assert.Equal(expectedLevel, resultLevel); 
        Assert.Equal(expectedForca, resultForca); 
        Assert.Equal(expectedVida, resultVida); 
        }

        [Fact]
        public void AprenderHabilidadeDeveAdicionarHabilidadeNaListaHabilidadeDoGuerreiro()
        {
        //Arrange
        List<string> habilidadeInicial = new List<string> {"Personagem Aprendendo habilidades..."};
         Guerreiro G1 = new (nome: "G1",vida : 10, mana: 10, xp: 10, inteligencia: 20, forca: 5, level: 0, habilidades : habilidadeInicial);
        var habilidade = "Nova Habilidade";
        var expected = true;
         //Act
        var result = G1.AprenderHabilidade(habilidade);
         //Assert
        Assert.Equal(expected, result);   
        Assert.Contains(G1.Habilidade, h => h == habilidade); 
        }

        [Fact]
        public void AttackDoGuerreiroDeveRetornarDanoDe1A300SomadoComForcaVezesLevel()
        {
         List<string> habilidadeInicial = new List<string> {"Personagem Aprendendo Magias..."};
         Guerreiro G1 = new (nome: "G1",vida : 10, mana: 10, xp: 10, inteligencia: 20, forca: 5, level: 2, habilidades : habilidadeInicial);
         var ataque = G1.Forca * G1.Level;
        //Act
        
        var result = G1.Attack();
   
        //Assert
        Assert.True(result > 0); 
        Assert.True(result >= ataque);
        Assert.True(ataque <= 300 + ataque);
        
        }
      

    }
}
