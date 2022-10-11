using System;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program.playFizz();

        }
        public static void playFizz()
        {
            Calcular FizzBuzz = new Calcular();

            for (var i = 0; i <= 100; i++)
            {
                var result = FizzBuzz.Calculo(i);
                Console.WriteLine(result);
            }

        }

    }
}
