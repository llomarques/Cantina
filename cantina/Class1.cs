using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantina
{

    public class Produto
    {
        private string descricao;
        private double valor;
        


        public string Descricao
        {
            get { return descricao; }
        }
        public double Valor
        {
            get { return valor; }
        }
      

        public Produto( string descricao, double valor)
        {
            
            this.descricao = descricao;
            this.valor = valor;

        }
        public override string ToString()
        {
            return $" {descricao} - R$ {valor:F2}";
        }
    }

}
