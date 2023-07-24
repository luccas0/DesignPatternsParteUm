﻿using CursoDesignPatterns.Modulo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo2.Desafio2
{
    public class RespostaEmXml : Resposta
    {
        public Resposta OutraResposta { get; set; }

        public RespostaEmXml(Resposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public RespostaEmXml()
        {
            OutraResposta = null;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
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
