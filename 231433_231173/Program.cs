using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231433_231173
{
    internal class Program
    {
        static double saldo = 0;

        static void Main(string[] args)
        {
            int continuar = 1;

            while (continuar == 1)
            {
                Console.WriteLine("Insira uma opção (D) Efetuar Depósito, (S) Efetuar Saque, (P) Efetuar Pagamento, (C) Consultar Saldo: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "D":
                        EfetuarDeposito();
                            break;
                    case "S":
                        EfetuarSaque();
                        break;
                    case "P":
                        EfetuarPagamento();
                        break;
                    case "C":
                        ConsultarSaldo();
                        break;
                    default: Console.WriteLine("Opção Inválida. Tente novamente.");
                        break;
                }
                Console.WriteLine("Deseja continuar? (1)Sim (2)Não: ");
                continuar = int.Parse(Console.ReadLine());
            }

        }
        static void EfetuarDeposito()
        {
            Console.WriteLine("Digite o valor do depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            saldo += deposito;
        }

        static void EfetuarSaque()
        {
            Console.WriteLine("Digite o valor do saque: ");
            double saque = double.Parse(Console.ReadLine());

            if (saldo < saque)
            {
                Console.WriteLine("Saldo insuficiente. Não foi possível efetuar o saque."); }
            else
            {
                saldo -= saque;
                Console.WriteLine("Saldo suficiente. Saque efetuado com sucesso.");
            }

        }

        static void EfetuarPagamento()
        {
            Console.WriteLine("Digite o valor do pagamento: ");
            double pagamento = double.Parse(Console.ReadLine());

            if (saldo < pagamento)
            { 
                Console.WriteLine("Saldo insuficiente. Não foi possível efetuar o pagamento."); }
            else {
                saldo -= pagamento;
                Console.WriteLine("Saldo suficiente. Pagamento efetuado com sucesso."); }
        }
        
        static void ConsultarSaldo()
        {
            Console.WriteLine("Seu saldo é: R$" + saldo);
        }


    }
}
