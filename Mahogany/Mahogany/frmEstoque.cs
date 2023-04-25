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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.control_estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.control_estoqueTableAdapter.Fill(this.mahoganyDataSet.control_estoque);
            label6.BackColor = this.BackColor;

            label6.BackColor = Color.Transparent;

            label6.Update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCadEstoque frmEstoque = new frmCadEstoque();
            this.Hide();
            frmEstoque.ShowDialog();
        }
    }
}
