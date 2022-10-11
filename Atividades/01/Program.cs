using System;

namespace _01
{
    public class Program
    {
        static void Main(string[] args)
        {   //Externo.play1();
            Program.play1();

        }
        public static void play1()
        {
            Console.WriteLine();
            Console.WriteLine("Carro ligado");
            Console.WriteLine();
            Veiculo carro = new Veiculo();
            Console.WriteLine("Carro com 20 litros de Combustível no Tanque:");
            Console.WriteLine("Abastecendo mais 20 litros");
            carro.Abastecer(20);
            Console.WriteLine($"O Total de litros de Combustível no Tanque é: {carro.litrosCombustivel}");
            Console.WriteLine("Abastecendo mais 22 litros");
            carro.Abastecer(22);
            Console.WriteLine($"O Total de litros de Combustível no Tanque é: {carro.litrosCombustivel}");
            Console.WriteLine();
            Console.WriteLine($"A cor atual do carro é: {carro.Cor}");
            Console.WriteLine("Pintando o carro de Branco");
            carro.Pintar("Branco");
            Console.WriteLine($"A nova cor do carro é: {carro.Cor}");
            Console.WriteLine();
            Console.WriteLine($"A velocidade atual do carro é: {carro.Velocidade}");
            Console.WriteLine($"Acelerando o carro em 20km");
            carro.Acelerar();
            Console.WriteLine($"Acelerando o carro em 20km");
            carro.Acelerar();
            Console.WriteLine($"A velocidade atual do carro é: {carro.Velocidade}");
            Console.WriteLine();
            Console.WriteLine($"Tentando desligar o carro");
            Console.WriteLine(carro.Desligar());
            Console.WriteLine("Freando o carro em 20km");
            carro.Frear();
            Console.WriteLine("Freando o carro em 20km");
            carro.Frear();
            Console.WriteLine($"A velocidade atual do carro é: {carro.Velocidade}");
            Console.WriteLine($"Tentando desligar o carro");
            Console.WriteLine(carro.Desligar());


        }


    }
}
