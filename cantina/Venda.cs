using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantina
{
    class Venda
    {

        public List<Produto> pedido = new List<Produto>();
        private string nome_cliente;
        string metodo_pag;
        string isviagem;
        private Status status;
        string data;

        public string Nome_cliente
        {
            get { return nome_cliente; }
            set { nome_cliente = value; }
        }

        public Status Status
        {
            get { return status; }
            set { status = value; }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cliente: {this.Nome_cliente} -");
            if (this.Status == Status.Preparando)
            {
                foreach (var produto in pedido)
                {
                    if (produto.Chapa)
                    {
                        sb.Append($"  {produto.Quantidade}x {produto.Descricao} |");
                    }
                }
            }
            else
            {
                foreach (var produto in pedido)
                {
                    sb.Append($"  {produto.Quantidade}x {produto.Descricao} |");
                }
            }
            return sb.ToString();
        }

    }
          
}
    

