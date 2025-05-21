using System.Configuration;
using System.Diagnostics.CodeAnalysis;
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
                MessageBox.Show("Indique uma quantidade v�lida!");
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
                double.TryParse(textBox2.Text, out double valorTroco);
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                comboBox1.SelectedIndex = -1;
                MessageBox.Show($"Dados do pedido: nome do cliente:{textBox1}\n\n" +
                    $"M�todo de pagamento: {comboBox1.SelectedItem}\n\n" +
                    $"Seu total � de : R$ {total:F2}");
                
                listBox2.Items.Clear();
                lblTotal.Text = $" TOTAL: R$ {total = 0}";
                textBox2.Clear();
                textBox1.Clear();
                textBox3.Clear();
            }
            else if (comboBox1.SelectedIndex==3 && valorTroco < total)
            {
               MessageBox.Show("Valor insuficiente");
            }


            else if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione o m�todo de pagamento!");
            }
            
           
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Produto("Coxinha", 5.00));
            listBox1.Items.Add(new Produto("Pastel de Carne", 6.00));
            listBox1.Items.Add(new Produto("Pastel de Queijo", 5.50));
            listBox1.Items.Add(new Produto("Refrigerante Lata", 4.50));
            listBox1.Items.Add(new Produto("Suco Natural (300ml)", 3.00));
            listBox1.Items.Add(new Produto("P�o de Queijo", 3.50));
            listBox1.Items.Add(new Produto("Hamb�rguer Simples", 8.00));
            listBox1.Items.Add(new Produto("Hamb�rguer com Queijo", 9.00));
            listBox1.Items.Add(new Produto("X-tudo", 12.00));
            listBox1.Items.Add(new Produto("�gua Mineral (500ml)", 2.50));

            comboBox1.Items.Add("Pix");
            comboBox1.Items.Add("Cart�o cr�dito");
            comboBox1.Items.Add("Cart�o d�bito");
            comboBox1.Items.Add("Dinheiro");

            buttonFinalizar.FlatStyle = FlatStyle.Flat;
            buttonFinalizar.FlatAppearance.BorderSize = 0;
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
            else
            {
                label6.Visible = false; 
                textBox2.Visible = false;
                label7.Visible = false;
                textBox3.Visible = false;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
