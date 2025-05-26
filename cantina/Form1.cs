using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cantina
{
    public partial class Form1 : Form
    {
        List <Produto> extrato = new List <Produto> ();
        string metodo;
        public bool dinheiro()
        {
          
                double.TryParse(textBox2.Text, out double valorTroco);

                if (valorTroco >= total)
                {
                    double troco = valorTroco - total;
                    textBox3.Text = $"R$ {troco}";
                return true ;
                }
                else
                {
                    MessageBox.Show("Valor insuficiente");
                    return false ;
            }
           
        }
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
                extrato.Add(vendaFeita);
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
                extrato.Remove(produtoSelecionado);
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
            DateTime hora = DateTime.Now;
            string viagem = string.Empty;
            if (checkBox1.Checked)
            {
                viagem = "Para viagem";
            }
            else
            {
                viagem = "Para comer aqui";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                if (!dinheiro())
                {
                    return;
                }
            }

                if (textBox1 == null || comboBox1.SelectedItem == null || textBox2 == null)
                {
                    MessageBox.Show("Informação faltando!");
                    
                }

             else 
                {
                    
                    string extratop = string.Join("\n", extrato);
                    MessageBox.Show($"Dados do pedido:\n\n" +
                    $" Nome do cliente:{textBox1.Text}\n\n" +
                    $" Produtos: {extratop}\n\n" +
                    $"Método de pagamento: {comboBox1.SelectedItem}\n\n" +
                    $"Seu total é de : R$ {total:F2}\n\n" +
                    $"Data e hora: {hora}\n\n " + 
                    $" Viagem: {viagem}");

                    listBox2.Items.Clear();
                    lblTotal.Text = $" TOTAL: R$ {total = 0}";
                    textBox2.Clear();
                    textBox1.Clear();
                    textBox3.Clear();
                    extrato.Clear();
                    checkBox1.Checked= false;
                    comboBox1.SelectedIndex = -1;
                   
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

            buttonFinalizar.FlatStyle = FlatStyle.Flat;
            buttonFinalizar.FlatAppearance.BorderSize = 3;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.FlatAppearance.BorderSize = 3;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 3;



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
            bool mostrarTroco = false;
            if (comboBox1.SelectedIndex == 0)
            {
                metodo = "pix";
                mostrarTroco = false ;
            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                metodo = "Cartão crédito";
                mostrarTroco = false ;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                metodo = "Cartão débito";
                mostrarTroco = false ;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                mostrarTroco = true;
            }
            label6.Visible = mostrarTroco;
            textBox2.Visible = mostrarTroco;
            label7.Visible = mostrarTroco;
            textBox3.Visible = mostrarTroco;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
