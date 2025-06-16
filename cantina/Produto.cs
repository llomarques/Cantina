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
        private int quantidade = 0;
        private bool chapa;
        
        public bool Chapa
        {
            get { return chapa; }
            set { chapa = value; }
        }
        public string Descricao
        {
            get { return descricao; }
        }
        public double Valor
        {
            get { return valor; }
        }

        public int Quantidade
        {
            set { quantidade = value; }
            get { return quantidade; }  
        }

        public Produto( string descricao, double valor, bool chapa)
        {
            
            this.descricao = descricao;
            this.valor = valor;
            this.quantidade = 0;
            this.chapa = chapa;
          

        }
        public override string ToString()
        {    if (quantidade > 0) 
                return $" {quantidade}x {descricao} - R$ {valor:F2}";
        else return $"  {descricao} - R$ {valor:F2}"; 
        }
    }

}
