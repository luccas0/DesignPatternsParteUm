using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CursoDesignPatterns.Modulo1
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double icms = imposto.Calcula(orcamento);
            Console.WriteLine(icms);
        }
    }
}
