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
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            listBox1.Items.Clear();

            foreach (var pedido in PersistenciaPedido.Pedidos)
            {
                string item = $"{pedido.Cliente} - R$ {pedido.Total:F2} - {pedido.DataHora:HH:mm:ss} - {pedido.TipoConsumo}";
                listBox1.Items.Add(item);
            }
        }
    }
}
    
