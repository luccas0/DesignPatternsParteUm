using CursoDesignPatterns.Modulo1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo4
{
    public class FiltroMenorQueCemReais : Filtro
    {
        public FiltroMenorQueCemReais(Filtro outroFiltro) : base(outroFiltro) { }
        public FiltroMenorQueCemReais() : base() { }
        public override IList<Conta> Filtra(IList contas)
        {
            IList<Conta> filtrada = new List<Conta>(); 
            foreach (Conta c in contas) 
            { 
                if (c.Saldo < 100) filtrada.Add(c); 
            }

            foreach (Conta c in Proximo(contas)) 
            { 
                filtrada.Add(c); 
            }

            return filtrada;
        }
    }
}