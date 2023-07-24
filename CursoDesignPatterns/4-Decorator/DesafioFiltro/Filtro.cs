using CursoDesignPatterns.Modulo1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo4
{
    public abstract class Filtro
    {
        public Filtro() { }
        protected Filtro OutroFiltro { get; private set; }
        public Filtro(Filtro outroFiltro) 
        { 
            this.OutroFiltro = outroFiltro; 
        }
        
        
        public abstract IList<Conta> Filtra(IList contas); 
        protected IList<Conta> Proximo(IList contas)
        {
            if (OutroFiltro != null) 

                return OutroFiltro.Filtra(contas);
            else
            {
                return new List<Conta>();
            }
        }
    }
}
