using CursoDesignPatterns.Modulo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo2
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
