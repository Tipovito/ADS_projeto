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
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.mahoganyDataSet.fornecedores);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                fornecedoresBindingSource.Filter = string.Format("forn_CD={0}", textBox1.Text);
            }
            else
            {
                fornecedoresBindingSource.Filter = "";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fornecedoresBindingSource.Filter = string.Format("forn_CD={0}",
           textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                fornecedoresBindingSource.RemoveCurrent();
                fornecedoresTableAdapter.Update(mahoganyDataSet.fornecedores); //salvar
                this.fornecedoresTableAdapter.Fill(this.mahoganyDataSet.fornecedores);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCadFornecedores frmFornecedores = new frmCadFornecedores();
            //this.Hide();
            frmFornecedores.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.altera = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //this.Visible = false;
            frmAlteraFornecedores frmFornecedores = new frmAlteraFornecedores();
            frmFornecedores.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.fornecedoresTableAdapter.Fill(this.mahoganyDataSet.fornecedores);
        }
    }
}
