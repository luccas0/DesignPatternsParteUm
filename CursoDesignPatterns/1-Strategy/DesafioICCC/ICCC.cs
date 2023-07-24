using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo1.Desafio1
{
    public class ICCC : Imposto
    {

        public ICCC(Imposto outroImposto) : base(outroImposto) { }
        public ICCC() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
            {
                return orcamento.Valor * 0.5;
            }

            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
            {
                return orcamento.Valor * 0.7;
            }

            else
            {
                return orcamento.Valor * 0.8 + 30.0;
            }

        }
    }
}
