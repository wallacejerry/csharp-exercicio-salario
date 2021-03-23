using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio5
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double quantia) : this(numero, titular)
        {
            Depositar(quantia);
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }

        public void Sacar(double quantia)
        {
            double taxaSaque = 5.00;
            Saldo -= (quantia + taxaSaque);
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
