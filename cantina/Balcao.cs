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
                {
                    if (item.Chapa)
                    {

                        pedidoChapa = true;
                        break;
                    }
                    if (!pedidoChapa)
                    {
                        listbalcao.Items.Add($"{item.Nome}{item.Quantidade}x {item.Descricao}");
                    }
                }
                btnEntregar.FlatStyle = FlatStyle.Flat;
                btnEntregar.FlatAppearance.BorderSize = 3;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void btnEntregar_Click_1(object sender, EventArgs e)
        {
            if (listentrega.Items.Count >= 5)
            {
                listentrega.Items.RemoveAt(4);
                listentrega.Items.Insert(0,listbalcao.SelectedItem);
            }
            if (listentrega.Items.Count<5)
                   if (listbalcao.SelectedItem != null)
            {

                listentrega.Items.Insert(0,listbalcao.SelectedItem);
                listbalcao.Items.RemoveAt(listbalcao.SelectedIndex);



            } 
           
                else
                
                MessageBox.Show("Selecione um item para entregar.");
            }
        }
    }
    

    
