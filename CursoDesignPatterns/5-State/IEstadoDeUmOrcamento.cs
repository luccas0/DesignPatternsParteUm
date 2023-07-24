using CursoDesignPatterns.Modulo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo5
{
    public interface IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta em estado de aprovacao");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta aprovado, não pode ser reprosdo agora");
        }
        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
