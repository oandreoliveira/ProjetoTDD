using System;
using _01;
using _02;
using _03;
using _07;
using Jokenpo;
using FizzBuzz;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        _01.Program.play1();
                        break;
                    case "2":
                        _02.Program.play2();
                        break;
                    case "3":
                        _03.Program.play3();
                        break;
                    case "4":
                        _07.Program.play7();
                        break;
                    case "5":
                        Jokenpo.Program.playJoke();
                        break;
                    case "6":
                        FizzBuzz.Program.playFizz();
                        break;

                    default:

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("-----------------------OPÇÃO INVÁLIDA-------------------------");
                        Console.WriteLine();
                        break;


                }

                opcaoUsuario = ObterOpcaoUsuario();
            }


        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------Desafio TDD----------------------------");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine(" Qual Exercício você deseja corigir? Escolha uma das opções:");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" 1 - Exercício 01");
            Console.WriteLine(" 2 - Exercício 02");
            Console.WriteLine(" 3 - Exercício 03");
            Console.WriteLine(" 4 - Exercício 07");
            Console.WriteLine(" 5 - Jokenpo");
            Console.WriteLine(" 6 - Exercício Extra - FizzBuzz");
            Console.WriteLine(" X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;



        }
    }
}
