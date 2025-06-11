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
    public partial class TelaEstoque : Form
    {
        private void Atualizarlista()
        {
            listEstoque.Items.Clear();
            foreach (Estoque estoque in PersistenciaEstoque.ListaEstoque)
            {
                listEstoque.Items.Add(estoque);
            }


        }
        public TelaEstoque()
        {
            InitializeComponent();
        }

        private void TelaEstoque_Load(object sender, EventArgs e)
        {
            if (PersistenciaEstoque.ListaEstoque.Count == 0)
            {
                PersistenciaEstoque.IniciarEstoque();


            }
            Atualizarlista();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
           if (numericUpDown1.Value > 0 )
            {
                Estoque estoque = new Estoque();
                estoque.AdicionarQuantidade((int)numericUpDown1.Value);
            }
        }
    }
}
