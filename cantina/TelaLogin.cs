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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtlogin.Text) || string.IsNullOrEmpty(txtsenha.Text))
            {
                MessageBox.Show("Por favor, preencha os campos.");
                return;
            }
            string usuario = txtlogin.Text.Trim();
            string senhna = txtsenha.Text.Trim();

            if (Validar(usuario, senhna))
            {
                AbrirFormPorTipoUsuario(usuario);
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERRO: Usuario ou senha inválido");
                txtlogin.Focus();
            }
        }

        private bool Validar(string usuario, string senha)
        {
            switch (usuario.ToLower())
            {
                case "adm":
                    return senha == "123";

                case "cozinheiro":
                    return senha == "1234";


                default:
                    return false;
            }

        }
        private void AbrirFormPorTipoUsuario(string usuario)
        {
            switch (usuario.ToLower())
            {
                case "cozinheiro":
                    Cozinha cozinha = new Cozinha();
                    cozinha.Show();
                    break;

                case "adm":
                    TelaVendas telaPrincipalAdm = new TelaVendas();
                    telaPrincipalAdm.Show();
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
