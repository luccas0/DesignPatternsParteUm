using CursoDesignPatterns.Modulo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo5
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados não recebem desconto extra");
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
