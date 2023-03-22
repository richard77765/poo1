using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Cliente
    {
        public string Nome { get; private set; }

        public string Cpf { get; private set; }

        public int AnoNascimento { get; private set;}

        public Cliente (string nome, string cpf, int anoNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            AnoNascimento = anoNascimento;
            
            if(anoNascimento > 2005)
            {
                throw new Exception("o ano de nascimento não é válido");
            }
            if(cpf.Length !=11)
            {
                throw new Exception("CPF inválido");
            }
           

        }
 

    }
}

