using CursoDesignPatterns.Modulo5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo1.Desafio2
{
    public class RealizadorDeInvestimentos
    {
        public void Realiza(Conta conta, Investimento investimento)
        {
            double resultado = investimento.Calcula(conta);
            conta.Deposita(resultado * 0.75);
            Console.WriteLine("Novo saldo: " + conta.Saldo);
        }
    }
}
