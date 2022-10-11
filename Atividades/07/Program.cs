using System;

namespace _07
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program.play7();

        }

        public static void play7()
        {
            Gerente gerente = new Gerente("João", 40, 8000.00);
            Supervisor supervisor = new Supervisor("Maria", 30, 4000.00);
            Vendedor vendedor = new Vendedor("Ana", 20, 1500.00);

            Console.WriteLine("Salários antes das bonificações:");
            Console.WriteLine($"Gerente: {gerente.Salario}");
            Console.WriteLine($"Supervisor: {supervisor.Salario}");
            Console.WriteLine($"Vendedor: {vendedor.Salario}");
            Console.WriteLine();
            Console.WriteLine("Salários depois das bonificações:");
            Console.WriteLine($"Gerente:{gerente.bonificacao()}");
            Console.WriteLine($"Supervisor:{supervisor.bonificacao()}");
            Console.WriteLine($"Vendedor: {vendedor.bonificacao()}");



        }
    }
}
