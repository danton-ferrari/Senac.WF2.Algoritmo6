using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solucao
{
    public partial class FormPedidios : Form
    {
        public FormPedidios()
        {
            InitializeComponent();
        }

        private void x1_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Você deseja encerrar o programa?",
                "Sair", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menos1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Esconde a tela de login
            this.Hide();
            // Cria uma nova instância do formulário principal
            var formPrincipal = new FormPedidios();
            // Exibe o fomrulário principal
            formPrincipal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Esconde a tela de login
            this.Hide();
            // Cria uma nova instância do formulário principal
            var formPrincipal = new FormClientes();
            // Exibe o fomrulário principal
            formPrincipal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Esconde a tela de login
            this.Hide();
            // Cria uma nova instância do formulário principal
            var formPrincipal = new FormPagto();
            // Exibe o fomrulário principal
            formPrincipal.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Esconde a tela de login
            this.Hide();
            // Cria uma nova instância do formulário principal
            var formPrincipal = new FormEntrega();
            // Exibe o fomrulário principal
            formPrincipal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Esconde a tela de login
            this.Hide();
            // Cria uma nova instância do formulário principal
            var formPrincipal = new FormPrincipal();
            // Exibe o fomrulário principal
            formPrincipal.Show();
        }
    }
}
