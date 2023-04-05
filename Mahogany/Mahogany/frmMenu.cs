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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cadastroDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFuncionários frmMenu = new frmFuncionários();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            label1.Parent = panel1;
            label1.BackColor = Color.Transparent;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmLogin frmMenu = new frmLogin();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmProdutos frmMenu = new frmProdutos();
            this.Hide();
            frmMenu.ShowDialog();
        }
    }
}
