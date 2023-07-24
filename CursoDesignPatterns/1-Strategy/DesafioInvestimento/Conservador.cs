using CursoDesignPatterns.Modulo5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo1.Desafio2
{
    public class Conservador : Investimento
    {
        public double Calcula(Conta conta)
        {
            return conta.Saldo * 0.008;
        }


    }
}
