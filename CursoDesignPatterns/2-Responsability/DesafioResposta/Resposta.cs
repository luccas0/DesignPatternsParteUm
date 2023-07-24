using CursoDesignPatterns.Modulo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo2.Desafio2
{
    public interface Resposta
    {
        void Responde(Requisicao req, Conta conta);
        Resposta OutraResposta { get; set; }
    }
}
