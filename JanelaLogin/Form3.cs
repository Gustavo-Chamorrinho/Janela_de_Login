using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanelaLogin
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionando Chocolate..");
            listaIngredientes.Add(new Ingredientes("CHOCOLATE"));
            textBox2.AppendText("CHOCOLATE" + Environment.NewLine);
    
            

        }
        List<Ingredientes> listaIngredientes = new List<Ingredientes>();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionando Trigo..");
            listaIngredientes.Add(new Ingredientes("TRIGO"));
            textBox2.AppendText("TRIGO" + Environment.NewLine);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
