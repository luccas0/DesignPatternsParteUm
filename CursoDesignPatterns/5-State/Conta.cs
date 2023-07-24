using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Modulo5
{
    public class Conta
    {
        public String Titular { get; private set; }
        public double Saldo { get; set; }
        public String Nome { get; set; }
        public int Numero { get; set; }
        public string Agencia { get; set; }
        public DateTime DataAbertura { get; set; }
        public IEstadoDeUmaContaBancaria Estado;
        
        

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }

        public Conta(String titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}
