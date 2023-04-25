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
    public partial class frmAlteraFornecedores : Form
    {
        public frmAlteraFornecedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            fornecedoresBindingSource.EndEdit();
            fornecedoresTableAdapter.Update(mahoganyDataSet.fornecedores);
            this.fornecedoresTableAdapter.Fill(this.mahoganyDataSet.fornecedores);
            fornecedoresBindingSource.MoveLast();

            //aparece a mensagem quando der certo
            MessageBox.Show(" Produto alterado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox1.Focus();

            frmFornecedores frmAlteraFornecedores = new frmFornecedores();
            this.Hide();
            frmAlteraFornecedores.ShowDialog();
        }

        private void frmAlteraFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.mahoganyDataSet.fornecedores);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu frmAltera = new frmMenu();
            this.Hide();
            frmAltera.ShowDialog();
        }
    }
}
