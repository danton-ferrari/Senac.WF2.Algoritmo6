namespace solucao
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "USU�RIO")
                textBox1.Text = string.Empty;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
                textBox1.Text = "USU�RIO";

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "SENHA")
                textBox2.Text = string.Empty;
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
                textBox2.Text = "SENHA";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Voc� deseja encerrar o programa?",
                "Sair", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Esconde a tela de login
            this.Hide();
            // Cria uma nova inst�ncia do formu~l�rio principal
            var formPrincipal = new FormPrincipal();
            // Exibe o fomrul�rio principal
            formPrincipal.Show();
        }
    }
}
