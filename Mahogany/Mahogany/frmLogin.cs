using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahogany
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "victor") && (textBox2.Text == "123"))
            {
                this.Visible = false;
                frmMenu frmLogin = new frmMenu();
                frmLogin.ShowDialog();
            }
            else
                MessageBox.Show("Usuário ou Senha Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
