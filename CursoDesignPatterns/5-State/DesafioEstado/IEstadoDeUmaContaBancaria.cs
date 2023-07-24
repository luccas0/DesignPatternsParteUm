using CursoDesignPatterns.Modulo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo5
{
    public interface IEstadoDeUmaContaBancaria
    {
        void Saca(Conta conta, double valor);
        void Deposita(Conta conta, double valor);
    }
}
