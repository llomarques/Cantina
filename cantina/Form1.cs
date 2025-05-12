namespace cantina
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        double total = 0;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {


            if (listBox1.SelectedItem != null && numericQuant.Value > 0)
            {
                int quant = (int)numericQuant.Value;
                Produto produtoSelecionado = (Produto)listBox1.SelectedItem;
                Venda vendaFeita = (Venda) produtoSelecionado.
                listBox2.Items.Add(new Venda(quant, produtoSelecionado);
                total += produtoSelecionado.Valor * quant;
                lblTotal.Text = $" TOTAL: R$ {total:F2}";
                listBox1.SelectedIndex = -1;



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
                Venda produtoSelecionado = (Venda)listBox2.SelectedItem;
                listBox2.Items.Remove(produtoSelecionado);
                total -= produtoSelecionado.Valor * quant;
                lblTotal.Text = $" TOTAL: R$ {total:F2}";



            }
            else
            {
                MessageBox.Show("Selecione o item para remover!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"Seu total é de : R$ {total:F2}");
            listBox2.Items.Clear();
            lblTotal.Text = $" TOTAL: R$ {total = 0}";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Produto("Coxinha", 5.00));
            listBox1.Items.Add(new Produto("Pastel", 6.00));
            listBox1.Items.Add(new Produto("Refrigerante", 4.50));
            listBox1.Items.Add(new Produto("Suco", 3.00));
            listBox1.Items.Add(new Produto("Brigadeiro", 3.00));


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
