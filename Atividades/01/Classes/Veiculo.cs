using System;

namespace _01
{



    public class Veiculo
    {
        // mudar para public
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Placa { get; private set; }
        public string Cor { get; private set; }
        public float Km { get; private set; }
        public bool isLigado { get; private set; }
        public int litrosCombustivel { get; private set; }
        public int Velocidade { get; private set; }
        public double Preco { get; private set; }

        public Veiculo() { Velocidade = 0; litrosCombustivel = 20; Cor = "Vermelho"; isLigado = true; }

        public Veiculo(string cor, bool isLigado, int litrosCombustivel, int velocidade)
        {

            Cor = cor;
            this.isLigado = isLigado;
            this.litrosCombustivel = litrosCombustivel;
            Velocidade = velocidade;

        }

        public int Acelerar()
        {
            return Velocidade += 20;
        }

        public bool Abastecer(int combustivel)
        {
            if ((litrosCombustivel < 60) && ((litrosCombustivel + combustivel) <= 60))
            {
                litrosCombustivel += combustivel;
                return true;
            }
            Console.WriteLine($"Este Tanque tem a capacidade de 60 litros, impossível abastecer!");
            return false;
        }
        public bool Frear()
        {
            if (Velocidade >= 20)
            {
                Velocidade -= 20;
                return true;
            }
            Console.WriteLine($"O carro está parado!");
            return false;
        }

        public void Pintar(string novaCor)
        {
            Cor = novaCor;
        }

        public bool Ligar()
        {
            if (isLigado == false && Velocidade == 0) // ver se altera algi do código
            {
                isLigado = true;
                Console.WriteLine($"Você ligou o carro!");
                return true;
            }
            Console.WriteLine($"O carro já está ligado!");
            return false;
        }
        public bool Desligar()
        {
            if (isLigado == true && Velocidade == 0)
            {
                isLigado = false;
                Console.WriteLine($"Você desligou o carro!");
                return true;
            }
            Console.WriteLine($"O carro está desligado ou em movimento, reduza até a velocidade zero!");
            return false;
        }

    }

}