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

        public Venda (string nome_cliente, string metodo_pag, string isviagem)
        {
            this.pedido = pedido;
            this.status = Status;
            this.nome_cliente = nome_cliente;
            this.metodo_pag = metodo_pag;
            this.isviagem = isviagem;
        }

        public override string ToString()
        {
            return $"Cliente: {nome_cliente}, \n\n" +
                $"Pedido: {string.Join("\n, ", pedido)}";
        }
    }
}
