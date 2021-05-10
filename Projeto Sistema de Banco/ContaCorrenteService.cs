using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Sistema_de_Banco
{
    class ContaCorrenteService : ContaCorrente
    {
        public ContaCorrenteService(string titular, int agencia, int conta, double saldo)
        {
            this.titular = titular;
            this.agencia = agencia;
            this.conta = conta;
            this.saldo = saldo;
        }

       
    }
}
