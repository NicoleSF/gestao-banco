using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Sistema_de_Banco
{
    class Program
    {
        enum Menu { Sacar = 1, Depositar, Transferir, Sair};
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while(escolheuSair == false)
            {
                Console.WriteLine("-- Bem vindo(a) ao Sistema do Banco --");
                Console.WriteLine("1 - Sacar\n2 - Depositar\n3 - Transferir\n4 - Sair");

                string opStr = Console.ReadLine();
                int opInt = int.Parse(opStr);

                if(opInt > 0 && opInt < 5)
                {
                    Menu escolha = (Menu)opInt;

                    switch (escolha)
                    {
                        case Menu.Sacar:
                            operacaoSaque();
                            break;

                        case Menu.Depositar:
                            operacaoDeposito();
                            break;

                        case Menu.Transferir:
                            operacaoTransferencia();
                            break;

                        case Menu.Sair:
                            escolheuSair = true;
                            break;
                    }
                }
                else
                {
                    escolheuSair = true;
                }
                Console.Clear();
            }
        }

        static void operacaoSaque()
        {
            Console.WriteLine("Quanto você deseja sacar? ");
            int saque = int.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente()
            {
                titular = "Nicole",
                agencia = 0207,
                conta = 3355,
                saldo = 500

            };

            if (saque > conta.saldo)
            {
                Console.WriteLine("Não foi possível realizar a transação. Saldo Insuficiente.");
            }
            else
            {
                Console.WriteLine("Saque realizado com sucesso!");
            }
            Console.ReadLine();
        }

        static void operacaoDeposito()
        {
            Console.WriteLine("Quanto você deseja depositar? ");
            int deposito = int.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente()
            {
                titular = "Nicole",
                agencia = 0207,
                conta = 3355,
                saldo = 500

            };

            conta.saldo = +deposito;
            
        }

        static void operacaoTransferencia()
        {
            Console.WriteLine("Digite a agência e conta do favorecido para transferir.");
            Console.Write("Agência: ");
            Console.ReadLine();
            Console.Write("Conta: ");
            Console.ReadLine();
            Console.WriteLine("Quanto você deseja transferir? ");
            int valor = int.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente()
            {
                titular = "Nicole",
                agencia = 0207,
                conta = 3355,
                saldo = 500

            };

            if (valor > conta.saldo)
            {
                Console.WriteLine("Não foi possível realizar a transferência. Saldo insuficiente.");
            }
            else
            {
                Console.WriteLine("Transferência realizada com sucesso!");
                
            }
            Console.ReadLine();

        }


    }
}
