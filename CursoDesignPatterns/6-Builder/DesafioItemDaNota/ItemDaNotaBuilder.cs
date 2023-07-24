using CursoDesignPatterns.Modulo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo6
{
    public class ItemDaNotaBuilder
    {
        public String Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNotaBuilder ComNome(String nome)
        {
            this.Nome = nome;
            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            this.Valor = valor;
            return this;
        }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Nome, Valor);
        }
    }
}
