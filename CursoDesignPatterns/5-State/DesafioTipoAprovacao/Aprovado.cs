using CursoDesignPatterns.Modulo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo5
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado!");
            }
        }
    }
}
