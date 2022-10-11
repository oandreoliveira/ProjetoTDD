using System;
using Xunit;
using _07;


namespace _07_Teste
{
    public class Testes01
    {
        [Fact]
        public void ConferenciaDeBonificacaoGerente()
        {
            //Arrange
            Gerente G1 = new (nome :"Raul", idade: 29, salario: 10000);
            var expected = G1.Salario + 10000;            
            
            //Act
            var result = G1.bonificacao();
        
            //Assert
            Assert.Equal(expected, result);


        }

         [Fact]
        public void ConferenciaDeBonificacaoSupervisor()
        {
            //Arrange
            Supervisor S1 = new (nome: "Thiago", idade: 35, salario: 5000);
            var expected = S1.Salario + 5000;            
            
            //Act
            var result = S1.bonificacao();
        
            //Assert
            Assert.Equal(expected, result);


        }
        [Fact]
        public void ConferenciaDeBonificacaoVendedor()
        {
            // Arrange
            Vendedor V1 = new Vendedor(nome: "Anderson", idade: 32, salario: 300 );
            var expected = V1.Salario + 3000;
            // Act
            var result = V1.bonificacao();
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
