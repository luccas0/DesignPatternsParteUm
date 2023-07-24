using CursoDesignPatterns.Modulo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo5
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }
        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }
    }
}
