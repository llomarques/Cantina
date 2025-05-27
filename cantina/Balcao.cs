using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cantina
{
    public partial class Balcao : Form
    {
        public Balcao()
        {
            InitializeComponent();
        }

        private void Balcao_Load(object sender, EventArgs e)
        {
            foreach (var produto in PersistenciaPedido.Pedidos)
            {
                bool pedidoChapa = false; 

                foreach (var item in produto.pedido)
                { if (item.Chapa)
                    {

                        pedidoChapa = true;
                        break;
                    }
                    if (!pedidoChapa)
                    {
                        listbalcao.Items.Add($"{item.Quantidade}x {item.Descricao}");
                    }
                }
                

            }
        }
    }
}
    
