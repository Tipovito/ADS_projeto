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
    public partial class frmFuncionários : Form
    {
        public frmFuncionários()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.altera = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            frmAlteraFuncionario frmPesquisaFuncionario = new frmAlteraFuncionario();
            frmPesquisaFuncionario.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMenu frmPesquisaFuncionarios = new frmMenu();
            this.Hide();
            frmPesquisaFuncionarios.ShowDialog();
        }

        private void frmPesquisaFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.mahoganyDataSet.funcionarios);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.Filter = string.Format("func_CD={0}",
            textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                funcionariosBindingSource.RemoveCurrent();
                funcionariosTableAdapter.Update(mahoganyDataSet.funcionarios); //salvar
                this.funcionariosTableAdapter.Fill(this.mahoganyDataSet.funcionarios);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCadFuncionarios frmPesquisaFuncionarios = new frmCadFuncionarios();
            this.Hide();
            frmPesquisaFuncionarios.ShowDialog();
        }
    }
}
