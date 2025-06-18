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
    public partial class TelaChamada : Form
    {
        public string NomeSelecionado { get; set; }
    
        public TelaChamada()
        {
           
            InitializeComponent();
            
        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void TelaChamada_Load(object sender, EventArgs e)
        {

            //foreach (var produto in PersistenciaPedido.Pedidos)
            //{
            //    labelNome.Text = produto.Nome_cliente;
            //}
        }

        public void chamado (string nomeCliente)
        {
            labelNome.Text = nomeCliente;
        }
    }
}
