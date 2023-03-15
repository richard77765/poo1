using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Conta
    {

        private string _numero;
        private decimal _saldo;

        //Polimorfismo de sobrecarga
        public Conta(string numero)
        {
            _numero = numero;
        }

        public Conta(string numero, decimal saldo) 
        {
            _saldo = 2341.42m;
            _numero = "654321";
        }

        public string Numero {
            get => _numero; 
            private set => _numero = value; 
        }
        public decimal Saldo { 
            get => _saldo; 
            private set => _saldo = value; 
        }
    }
}
