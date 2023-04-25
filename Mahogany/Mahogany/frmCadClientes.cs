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
    public partial class frmCadClientes : Form
    {
        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.mahoganyDataSet.clientes);
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.mahoganyDataSet.clientes);
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.mahoganyDataSet.clientes);
            clientesBindingSource.AddNew();

            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox2.Mask = "00.000.000-0";
            maskedTextBox3.Mask = "00-00000000";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllBoxes.LimparTudo(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClearAllBoxes.AreTextBoxesFilled(this))
            {
                // Valida e salva o novo registro no banco de dados
                this.Validate();
                clientesBindingSource.EndEdit();
                clientesTableAdapter.Update(mahoganyDataSet.clientes);
                this.clientesTableAdapter.Fill(this.mahoganyDataSet.clientes);
                clientesBindingSource.MoveLast();

                // Adiciona um novo registro ao BindingSource
                clientesBindingSource.AddNew();

                // Define o foco no TextBox2
                textBox2.Focus();

                // Exibe mensagem de sucesso
                MessageBox.Show("Cliente cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Preencha todos os Dados", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
