using CursoDesignPatterns.Modulo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo3
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public TemplateDeImpostoCondicional(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public TemplateDeImpostoCondicional()
        {
            this.OutroImposto = null;
        }
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
