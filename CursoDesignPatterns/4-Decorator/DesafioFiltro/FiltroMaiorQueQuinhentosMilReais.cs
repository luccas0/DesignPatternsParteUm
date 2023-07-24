

using CursoDesignPatterns.Modulo1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo4
{
    public class FiltroMaiorQueQuinhentosMilReais : Filtro
    {
        public FiltroMaiorQueQuinhentosMilReais(Filtro outroFiltro) : base(outroFiltro) { }
        public FiltroMaiorQueQuinhentosMilReais() : base() { }
        public override IList<Conta> Filtra(IList contas) 
        { 
            IList<Conta> filtrada = new List<Conta>(); 

            foreach (Conta c in contas) 
            {

                if (c.Saldo > 500000) filtrada.Add(c); 
            }

            foreach (Conta c in Proximo(contas)) 
            { 
                filtrada.Add(c); 
            } 

            return filtrada; 
        }
    }
}
