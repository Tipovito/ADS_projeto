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
    public partial class frmCadFornecedores : Form
    {
        public frmCadFornecedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClearAllBoxes.AreTextBoxesFilled(this))
            {
                // Valida e salva o novo registro no banco de dados
                this.Validate();
                fornecedoresBindingSource.EndEdit();
                fornecedoresTableAdapter.Update(mahoganyDataSet.fornecedores);
                this.fornecedoresTableAdapter.Fill(this.mahoganyDataSet.fornecedores);
                fornecedoresBindingSource.MoveLast();

                // Adiciona um novo registro ao BindingSource
                fornecedoresBindingSource.AddNew();

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllBoxes.LimparTudo(this);
        }

        private void frmCadFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.mahoganyDataSet.fornecedores);
            fornecedoresBindingSource.AddNew();

            maskedTextBox1.Mask = "00-0000.0000";
        }
    }
}
