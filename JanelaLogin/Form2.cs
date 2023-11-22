using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JanelaLogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UsuCad_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Verificacao.CadastroUsuario = UsuCad.Text;
            Verificacao.CadastroSenha = SenhaCad.Text;
            Verificacao.ConfirmarSenha = ConfirnCad.Text;

            if (Verificacao.CadastroUsuario.Contains("@"))          //verificar se possui @.
            {

            }
            else
            {
                MessageBox.Show("O email precisa conter um '@'.");
            }





            if (Verificacao.CadastroUsuario == "")                  //Validação de campos em branco.
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            if (Verificacao.CadastroSenha == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            if (Verificacao.ConfirmarSenha == "")
            {
                MessageBox.Show("Preencha todos os campos!");      //três validação de campos.
            }






            if (Verificacao.CadastroSenha != Verificacao.ConfirmarSenha)         //validação de senhas ser diferentes.
            {
                MessageBox.Show("As senhas não são iguais, Verifique!");
            }

            else if (!Regex.IsMatch(Verificacao.CadastroSenha, @"[A-Z]"))          //senha possuir 6 caracteres e um maiusculo.
            {
                MessageBox.Show("As senhas precisam ter um caracter Maiúsculo.");
            }
            else if (!Regex.IsMatch(Verificacao.ConfirmarSenha, @"[A-Z]"))
            {
                MessageBox.Show("As senhas precisam ter um caracter Maiúsculo.");
            }
            else
            {
                MessageBox.Show("Cadastro Realizado");
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 JaneladeLogin = new Form1();
            JaneladeLogin.ShowDialog();
        }
    }
}
