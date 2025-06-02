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
            
            foreach (var produto in PersistenciaPedido.Pedidos= s)

            btnEntregar.FlatStyle = FlatStyle.Flat;
            btnEntregar.FlatAppearance.BorderSize = 3;
        }




        private void btnEntregar_Click_1(object sender, EventArgs e)
        {
            if (listbalcao.SelectedItem != null)
            {

                if (listentrega.Items.Count == 5)
                {
                    listentrega.Items.RemoveAt(4);
                }

                listentrega.Items.Insert(0, listbalcao.SelectedItem);

                listbalcao.Items.RemoveAt(listbalcao.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione um item para entregar.");
            }
        }


        private void listbalcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

    
