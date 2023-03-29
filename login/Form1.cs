using System;
using System.Windows.Forms;
using System.Threading;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntcancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntlogin_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text == "diggo" && txtsenha.Text == "123")
            {
                MessageBox.Show("Bem vindo ao sistema!", " acesso ao sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seu acesso foi nagedo", " Acesso negado !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
