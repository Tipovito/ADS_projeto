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
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.mahoganyDataSet.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.mahoganyDataSet.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.mahoganyDataSet.funcionarios);

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
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Entre com os dados");
            }
            else
            {
                funcionariosBindingSource.Filter = "func_login='" + textBox1.Text + "'";

                if (textBox1.Text.ToUpper() != textBox3.Text.ToUpper())
                {
                    MessageBox.Show("Usuário Incorreto");
                    return;
                }
                if (textBox2.Text.ToUpper() != textBox4.Text.ToUpper())
                {
                    MessageBox.Show("Senha Incorreta");
                    return;
                }
                this.Visible = false;
                frmMenu newmenu = new frmMenu();
                newmenu.ShowDialog();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
