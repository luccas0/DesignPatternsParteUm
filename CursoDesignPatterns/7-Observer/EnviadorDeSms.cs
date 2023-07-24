using CursoDesignPatterns.Modulo6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo7
{
    public class EnviadorDeSms : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("SMS");
        }
    }
}
