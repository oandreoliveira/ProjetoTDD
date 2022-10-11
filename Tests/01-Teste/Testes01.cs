using System;
using Xunit;
using _01;


namespace _01_Teste
{
    public class Testes01
    {
        [Fact]
        public void AcelerDeveACrescentar20NaVelocidade()
        {
            //Arrange
            Veiculo V1 = new (cor : "Vermelho",  isLigado : true, litrosCombustivel : 20,  velocidade : 10);
             
            var expected = V1.Velocidade + 20;
                  
            //Act
            
            var result =  V1.Acelerar();
            //Assert
            Assert.Equal(expected, result);
            

        }
        [Fact]
        public void AbastecerVeiculoAte60LitrosNoTanque()
        {
             //Arrange
            Veiculo V1 = new (cor : "Vermelho",  isLigado : true, litrosCombustivel : 0,  velocidade : 0);
           
            var expected = V1.litrosCombustivel <= 60;       
            
            //Act
            
            var result = V1.Abastecer(50);
        
            //Assert
            Assert.Equal(expected,result); 
            
           

        }
        [Fact]
        public void FrearOVeiculoDe20em20SeEstiverComVelocidadeMaiorOuIgualA20()
        {
             //Arrange
            Veiculo V1 = new (cor : "Vermelho",  isLigado : true, litrosCombustivel : 20,  velocidade : 30);
           // V1.Acelerar();
            var expected = true;            
            
            //Act
            
            var result = V1.Frear();
        
            //Assert
            Assert.Equal(expected, result); 
                       

        }
        [Fact]
        public void NaoFreiarOVeiculoDe20em20SeEstiverComVelocidadeMaiorOuIgualA0EMenorQue20() // verificar
        {
             //Arrange
            Veiculo V1 = new (cor : "Vermelho",  isLigado : true, litrosCombustivel : 20,  velocidade : 0);
           
            //Act
            
            var result = V1.Frear();
        
            //Assert
            Assert.False(result); 
            
           

        }

        [Fact]
        public void PintarVeiculoEMudarACorDoVeiculo()
        {
            //Arrange
            Veiculo V1 = new (cor : "Vermelho",  isLigado : true, litrosCombustivel : 20,  velocidade : 10);
            
            var expected = "Branco";
            V1.Pintar("Branco");
                  
            //Act
            var result =  V1.Cor;
            //Assert
            Assert.Equal(expected, result);
            

        }
        [Fact]
        public void LigarVeiculoSeEstiverDesligado()
        {
            //Arrange
            Veiculo V1 = new (cor : "Vermelho",  isLigado : false, litrosCombustivel : 20,  velocidade : 0);
            //var expected = V1.Velocidade + 20;   
            var expected = true;
                  
            //Act
            var result =  V1.Ligar();
            //Assert
            Assert.Equal(expected, result);
            

        }
        [Fact]
        public void LigarVeiculoSeEstiverligado()
        {
            //Arrange
            Veiculo V1 = new (cor : "Vermelho",  isLigado : true, litrosCombustivel : 20,  velocidade : 0);
            //var expected = V1.Velocidade + 20;   
            var expected = false;
                  
            //Act
            var result =  V1.Ligar();
            //Assert
            Assert.Equal(expected, result);
            

        }
        [Fact]
        public void DesligarVeiculoSeEstiverLigadoEVelocidadeIgualAZero()
        {
            //Arrange
            Veiculo V1 = new (cor : "Vermelho",  isLigado : true, litrosCombustivel : 20,  velocidade : 0);
               
            var expected = true;
                  
            //Act
            var result =  V1.Desligar();
            //Assert
            Assert.Equal(expected, result);
            

        }
       [Fact]
        public void esligarVeiculoSeRetornaFalsoSeJaEstiverDesligado()
        {
            //Arrange
            Veiculo V1 = new (cor : "Vermelho",  isLigado : false, litrosCombustivel : 20,  velocidade : 0);
               
            var expected = false;
                  
            //Act
            var result =  V1.Desligar();
            //Assert
            Assert.Equal(expected, result);
            

        }


    }
        
}
