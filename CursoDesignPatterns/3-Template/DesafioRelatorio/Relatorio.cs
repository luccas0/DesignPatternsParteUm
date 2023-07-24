using CursoDesignPatterns.Modulo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo3.Desafio2
{
    public abstract class Relatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<Conta> conta);

        public void Imprime(IList<Conta> contsas)
        {
            Cabecalho();
            Corpo(contsas);
            Rodape();
        }
    }
}
