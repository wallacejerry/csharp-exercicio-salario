using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n): ");
            char haveraDeposito = char.Parse(Console.ReadLine().ToLower());
            
            if (haveraDeposito == 's')
            {
                Console.Write("Entre o valor do depósito: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numeroConta, titularConta, depositoInicial);
            }
            else
            {
                c = new Conta(numeroConta, titularConta);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.DepositarValor(valorDeposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.SacarValor(valorSaque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
        }
    }
}
