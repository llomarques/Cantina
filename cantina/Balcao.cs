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
            btnEntregar.FlatStyle = FlatStyle.Flat;
            btnEntregar.FlatAppearance.BorderSize = 3;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderSize = 3;


            foreach (var produto in PersistenciaPedido.Pedidos)
            {

                if (produto.Status == Status.Pronto)
                {
                    listbalcao.Items.Add(produto);
                }

            }
            foreach (var produto in PersistenciaPedido.Pedidos)
            {

                if (produto.Status == Status.Entregue)
                {
                    listentrega.Items.Add(produto);
                }

            }
        }




        private void btnEntregar_Click_1(object sender, EventArgs e)
        {
            Venda pedidoSelecionado = (Venda)listbalcao.SelectedItem;
            


            if (listbalcao.SelectedItem != null)
            {

                if (listentrega.Items.Count == 5)
                {
                    listentrega.Items.RemoveAt(4);
                }

                pedidoSelecionado.Status = Status.Entregue;
                listentrega.Items.Insert(0, listbalcao.SelectedItem);
                listbalcao.Items.RemoveAt(listbalcao.SelectedIndex);
                PersistenciaPedido.saveToFile();


            }
            else
            {
                MessageBox.Show("Selecione um item para entregar.");
                return;
            }

            TelaChamada telaChamada = new TelaChamada();
            telaChamada.chamado(pedidoSelecionado.Nome_cliente);
            telaChamada.ShowDialog();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaVendas telaVendas = new TelaVendas();
            telaVendas.Show();
        }

        private void listbalcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            TelaChamada telaChamadaa = new TelaChamada();
            telaChamadaa.Show();
        }

        private void listentrega_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

    
