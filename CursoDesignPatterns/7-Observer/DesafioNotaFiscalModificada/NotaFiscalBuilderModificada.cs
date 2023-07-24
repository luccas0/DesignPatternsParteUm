using CursoDesignPatterns.Modulo6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo7.Desafio2
{
    public class NotaFiscalBuilderModificada
    {
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public String Observacoes { get; private set; }
        public DateTime Data { get; private set; }
        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        private IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();


        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);

            foreach (IAcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            return nf;
        }


        public void AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }



        public NotaFiscalBuilderModificada ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilderModificada ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilderModificada NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }


        public NotaFiscalBuilderModificada ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilderModificada ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }
    }
}

