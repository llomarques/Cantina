using System.Configuration;
using System.Windows.Forms;

namespace cantina
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            GetButtonFinalizar();
        }


        double total = 0;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {


            if (listBox1.SelectedItem != null && numericQuant.Value > 0)
            {
                int quant = (int)numericQuant.Value;

                Produto produtoSelecionado = (Produto)listBox1.SelectedItem;
                Produto vendaFeita = new Produto(produtoSelecionado.Descricao, produtoSelecionado.Valor);
                vendaFeita.Quantidade = (int)numericQuant.Value;
                listBox2.Items.Add(vendaFeita);
                total += produtoSelecionado.Valor * quant;
                lblTotal.Text = $" TOTAL: R$ {total:F2}";
                listBox1.SelectedIndex = -1;
                numericQuant.Value = 0;



            }
            else if (numericQuant.Value <= 0)
            {
                MessageBox.Show("Indique uma quantidade válida!");
                numericQuant.Value = 1;

            }
            else
            {
                MessageBox.Show("Selecione o item para comprar!");
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                int quant = (int)numericQuant.Value;
                Produto produtoSelecionado = (Produto)listBox2.SelectedItem;
                listBox2.Items.Remove(produtoSelecionado);
                total -= produtoSelecionado.Valor * produtoSelecionado.Quantidade;
                lblTotal.Text = $" TOTAL: R$ {total:F2}";
                numericQuant.Value = 0;


            }
            else
            {
                MessageBox.Show("Selecione o item para remover!");
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"Seu total é de : R$ {total:F2}");
            listBox2.Items.Clear();
            lblTotal.Text = $" TOTAL: R$ {total = 0}";


            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione o método de pagamento para prosseguir!");
            }
            else
            {
                comboBox1.SelectedIndex = -1;
                textBox1 = null; 
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Produto("Coxinha", 5.00));
            listBox1.Items.Add(new Produto("Pastel de Carne", 6.00));
            listBox1.Items.Add(new Produto("Pastel de Queijo", 5.50));
            listBox1.Items.Add(new Produto("Refrigerante Lata", 4.50));
            listBox1.Items.Add(new Produto("Suco Natural (300ml)", 3.00));
            listBox1.Items.Add(new Produto("Pão de Queijo", 3.50));
            listBox1.Items.Add(new Produto("Hambúrguer Simples", 8.00));
            listBox1.Items.Add(new Produto("Hambúrguer com Queijo", 9.00));
            listBox1.Items.Add(new Produto("X-tudo", 12.00));
            listBox1.Items.Add(new Produto("Água Mineral (500ml)", 2.50));

            comboBox1.Items.Add("Pix");
            comboBox1.Items.Add("Cartão crédito");
            comboBox1.Items.Add("Cartão débito");
            comboBox1.Items.Add("Dinheiro");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                numericQuant.Value = 1;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {
                label6.Visible = true;
                textBox2.Visible = true;
                label7.Visible = true;
                textBox3.Visible = true;

                if (double.TryParse(textBox2.Text, out double valorTroco))
                {
                    if (valorTroco >= total)
                    {
                        double troco = valorTroco - total;
                        textBox3.Text = $"R$ {troco}";
                    }
                }

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 3)
            {
                label6.Visible = true;
                textBox2.Visible = true;
                label7.Visible = true;
                textBox3.Visible = true;
            }

            }
    }
}
