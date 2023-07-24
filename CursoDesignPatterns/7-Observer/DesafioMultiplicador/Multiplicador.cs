using CursoDesignPatterns.Modulo6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo7
{
    public class Multiplicador : IAcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }

        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(notaFiscal.ValorBruto * this.Fator);
        }
    }
}
