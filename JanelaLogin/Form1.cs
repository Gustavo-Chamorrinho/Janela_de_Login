using static System.Net.WebRequestMethods;

namespace JanelaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 JaneladeCadastro = new Form2();
            JaneladeCadastro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Verificacao.CadastroUsuario == UsuLogin.Text && Verificacao.CadastroSenha == UsuSenha.Text)
            {
                MessageBox.Show("SEJA BEM VINDO AO APROVE RECEITAS.");
                Form3 JaneladeReceitas = new Form3();
                JaneladeReceitas.ShowDialog();

            }
            else
            {
                MessageBox.Show(" As informações não existem no sistema.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UsuSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UsuLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}