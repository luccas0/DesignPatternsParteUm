using CursoDesignPatterns.Modulo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo2.Desafio2
{
    public class RespostaEmCSV : Resposta
    {
        public Resposta OutraResposta { get; set; }

        public RespostaEmCSV(Resposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public RespostaEmCSV()
        {
            OutraResposta = null;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(req, conta);
            }
            else
            {

                throw new Exception("Formato de resposta não encontrado");
            }
        }
    }
}
