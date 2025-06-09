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
    public partial class Cozinha : Form
    {
        public Cozinha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cozinha_Load(object sender, EventArgs e)
        {
            btnPronto.FlatStyle = FlatStyle.Flat;
            btnPronto.FlatAppearance.BorderSize = 3;

            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.FlatAppearance.BorderSize = 3;

            btnBalcao.FlatStyle = FlatStyle.Flat;
            btnBalcao.FlatAppearance.BorderSize = 3;

            foreach (var produto in PersistenciaPedido.Pedidos)
            {

                if (produto.Status == Status.Preparando)
                {
                    listCozinha.Items.Add(produto);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            TelaVendas telaVendas = new TelaVendas();
            telaVendas.Show();
        }

        private void btnPronto_Click(object sender, EventArgs e)
        {
            var pedidoSelecionado = listCozinha.SelectedItem as Venda;

            if (listCozinha.SelectedItem != null)
            {
                pedidoSelecionado.Status = Status.Pronto;
                listCozinha.Items.Remove(pedidoSelecionado);

            }
            else
            {
                MessageBox.Show("Selecione um item para marcar como pronto");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Balcao bal = new Balcao();
            bal.Show();
        }
    }
}

