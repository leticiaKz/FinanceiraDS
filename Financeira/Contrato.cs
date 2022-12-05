using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    internal class Contrato
    {
        public int Numero { get; set; }
        public string Contratante  { get; set; }
        public double Valor { get; set; }
        public int Prazo { get; set;  }

        public Contrato()
        {
        }

        public Contrato(int numero, string contratante, double valor, int prazo)
        {
            Numero = numero;
            Contratante = contratante;
            Valor = valor;
            Prazo = prazo;
        }
        public double CalcularPrestacao(double valor)
        {
            return (((1 / Valor)));
        }


    }
}
