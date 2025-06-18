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


            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.FlatAppearance.BorderSize = 3;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 3;
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                Estoque estoque = (Estoque)listEstoque.SelectedItem;
                estoque.AdicionarQuantidade((int)numericUpDown1.Value);

                listEstoque.SelectedIndex = -1;
                Atualizarlista();

            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                Estoque estoque = (Estoque)listEstoque.SelectedItem;
                estoque.RemoverQuantidade((int)numericUpDown1.Value);

                listEstoque.SelectedIndex = -1;
                Atualizarlista();
            }
        }

        
        
    }
}
