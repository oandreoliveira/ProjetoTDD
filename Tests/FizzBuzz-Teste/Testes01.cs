using System;
using Xunit;
using FizzBuzz;

namespace FizzBuzz_Teste
{
    public class Testes01
    {
        [Fact]
        public void CalculoRetornaFizzBuzzSeOParametroForDivisivelPor3E5()
        {
            //Arrange
            var FizzBuzz = new Calcular();
            string dividePorTres = "Fizz";
            string dividePorCinco = "Buzz";

            var expected = dividePorTres + dividePorCinco;

            //Act
            var result = FizzBuzz.Calculo(15);

            //Assert
            Assert.Equal(expected, result);

        }
        [Fact]
        public void CalculoRstornaFizzSeOParametroForDivisivelPor3()
        {
            //Arrange
            var FizzBuzz = new Calcular();
            string dividePorTres = "Fizz";

            var expected = dividePorTres;

            //Act
            var result = FizzBuzz.Calculo(3);

            //Assert
            Assert.Equal(expected, result);

        }
        [Fact]
        public void CalculoRetornaBuzzSeOParametroForDivisivelPor5()
        {
            //Arrange
            var FizzBuzz = new Calcular();
            string dividePorCinco = "Buzz";

            var expected = dividePorCinco;

            //Act
            var result = FizzBuzz.Calculo(5);

            //Assert
            Assert.Equal(expected, result);

        }
        [Fact]
        public void CalculoRetornaOParametroSeNaoForDivisivelPor3Ou5()
        {
            //Arrange
            var FizzBuzz = new Calcular();

            var expected = 1;

            //Act
            var result = FizzBuzz.Calculo(1);

            //Assert
            Assert.Equal(expected.ToString(), result);

        }
    }
}
