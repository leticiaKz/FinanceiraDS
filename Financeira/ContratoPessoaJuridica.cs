using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    internal class ContratoPessoaJuridica : Contrato
    {
        public string CNPJ { get; set; }
        public int InscricaoEstadual { get; set; }

        public ContratoPessoaJuridica() { }
        public ContratoPessoaJuridica(string cnpj, int inscricaoestadual)
        {
            CNPJ = cnpj;
            InscricaoEstadual = inscricaoestadual;
        }

        public double CalcularPrestacao(double Valor)
        {
            return (((3 / Valor)));
        }
    }
}
