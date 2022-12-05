using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    internal class PessoaFisica : Contrato
    {
        public int CPF { get; set; }
        public int Idade { get; set; }

        public PessoaFisica() { }

        public PessoaFisica(int cpf, int idade)
        {
            CPF = cpf;
            Idade = idade;
        }
        public double CalcularPrestacao(double valor)
        {
            return (((1 / Valor)));
        }

    }
}
