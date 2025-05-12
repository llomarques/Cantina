using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantina
{
    internal class Venda
    {
        private string descricao;
        private int quantidade;
        private double valor;

        public string Descricao
        {
            get { return descricao; }
        }
        public double Valor
        {
            get { return valor; }
        }
         private int Quantidade
        {
            get { return quantidade; }
        }

        public Venda (int quantidade, string descricao, double valor)
        {
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.valor = valor;

        }
        public override string ToString()
        {
            return $" {quantidade}x {descricao} - R$ {valor:F2}";
        }

    }
}
