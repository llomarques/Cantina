using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cantina
{
    public partial class TelaVendas : Form
    {
        List<Produto> extrato = new List<Produto>();
        string metodo;
        public bool dinheiro()
        {

            double.TryParse(textBox2.Text, out double valorTroco);

            if (valorTroco >= total)
            {
                double troco = valorTroco - total;
                textBox3.Text = $"R$ {troco}";
                return true;
            }
            else
            {
                MessageBox.Show("Valor insuficiente");
                return false;
            }

        }
        public TelaVendas()
        {
            InitializeComponent();
            GetButtonFinalizar();
        }


        double total = 0;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int quant = (int)numericQuant.Value;
            Estoque estoque = new Estoque();

            if (listBox1.SelectedItem != null && numericQuant.Value > 0 && quant <= estoque.Quantidade &&  estoque != null)
            {
                
                Produto produtoSelecionado = (Produto)listBox1.SelectedItem;
                Produto vendaFeita = new Produto(produtoSelecionado.Descricao, produtoSelecionado.Valor, produtoSelecionado.Chapa);
                vendaFeita.Quantidade = (int)numericQuant.Value;
                listBox2.Items.Add(vendaFeita);
                extrato.Add(vendaFeita);
                total += produtoSelecionado.Valor * quant;
                lblTotal.Text = $" TOTAL: R$ {total:F2}";
                listBox1.SelectedIndex = -1;
                numericQuant.Value = 0;



            }
            else if (quant > estoque.Quantidade)
            {
                MessageBox.Show("Quantidade insuficiente no estoque!");
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

                Venda venda = new Venda();
                venda.pedido = listBox2.Items.Cast<Produto>().ToList();
                venda.Nome_cliente = textBox1.Text;

                bool pedidoChapa = false;

                foreach (Produto item in venda.pedido)
                {
                    if (item.Chapa)
                    {
                        pedidoChapa = true;
                        break;
                    }
                }
                if (pedidoChapa)
                {
                    venda.Status = Status.Preparando;

                }
                else
                {
                    venda.Status = Status.Pronto;
                }


                PersistenciaPedido.Pedidos.Add(venda);
                listBox2.Items.Clear();
                lblTotal.Text = $" TOTAL: R$ {total = 0}";
                textBox2.Clear();
                textBox1.Clear();
                textBox3.Clear();
                extrato.Clear();
                checkBox1.Checked = false;
                comboBox1.SelectedIndex = -1;

            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.Items.Add(new Produto("Coxinha", 5.00, false));
            //listBox1.Items.Add(new Produto("Pastel de Carne", 6.00, true));
            //listBox1.Items.Add(new Produto("Pastel de Queijo", 5.50, true));
            //listBox1.Items.Add(new Produto("Refrigerante Lata", 4.50, false));
            //listBox1.Items.Add(new Produto("Suco Natural (300ml)", 3.00, false));
            //listBox1.Items.Add(new Produto("Pão de Queijo", 3.50, false));
            //listBox1.Items.Add(new Produto("Hambúrguer Simples", 8.00, true));
            //listBox1.Items.Add(new Produto("Hambúrguer com Queijo", 9.00, true));
            //listBox1.Items.Add(new Produto("X-tudo", 12.00, true));
            //listBox1.Items.Add(new Produto("Água Mineral (500ml)", 2.50, false));

            foreach (var produto in PersistenciaProduto.ProdutosEstoque)
            {
                listBox1.Items.Add(produto);
            }
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
            btnCozinha.FlatStyle = FlatStyle.Flat;
            btnCozinha.FlatAppearance.BorderSize = 3;



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                numericQuant.Value = 1;
            }
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
                mostrarTroco = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                metodo = "Cartão crédito";
                mostrarTroco = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                metodo = "Cartão débito";
                mostrarTroco = false;
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

        private void buttonBalcao_Click(object sender, EventArgs e)
        {


            Balcao bal = new Balcao();
            bal.Show();
        }

        private void btnCozinha_Click(object sender, EventArgs e)
        {
            Cozinha cozinha = new Cozinha();
            cozinha.Show();
        }
    }
}