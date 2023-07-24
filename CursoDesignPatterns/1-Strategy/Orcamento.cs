using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns.Modulo2;
using CursoDesignPatterns.Modulo5;

namespace CursoDesignPatterns.Modulo1
{
    public class Orcamento
    {

        public IEstadoDeUmOrcamento EstadoAtual { get; set; }

        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }
        public string Nome { get; private set; }


        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }

    }
}
