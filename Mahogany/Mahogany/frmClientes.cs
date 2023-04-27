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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.mahoganyDataSet.clientes);

        }
         
        private void button3_Click(object sender, EventArgs e)
        {
            frmMenu frmClientes = new frmMenu();
            this.Hide();
            frmClientes.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clientesBindingSource.Filter = string.Format("clie_CD={0}",
            textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                clientesBindingSource.RemoveCurrent();
                clientesTableAdapter.Update(mahoganyDataSet.clientes); //salvar
                this.clientesTableAdapter.Fill(this.mahoganyDataSet.clientes);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.altera = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //this.Visible = false;
            frmAlteraCliente pesq = new frmAlteraCliente();
            pesq.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCadClientes frmClientes = new frmCadClientes();
            //this.Hide();
            frmClientes.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                clientesBindingSource.Filter = string.Format("clie_CD={0}", textBox1.Text);
            }
            else
            {
                clientesBindingSource.Filter = "";

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.mahoganyDataSet.clientes);
        }
    }
}
