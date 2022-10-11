namespace FizzBuzz
{
    public class Calcular
    {
        public string Calculo(int numero)
        {

            string dividePorTres = "Fizz";
            string dividePorCinco = "Buzz";

            if (numero % 3 == 0)
            {
                if (numero % 5 == 0)
                {
                    return dividePorTres + dividePorCinco;
                }
                return dividePorTres;
            }
            if (numero % 5 == 0)
            {
                return dividePorCinco;
            }
            return numero.ToString();

        }
    }
}