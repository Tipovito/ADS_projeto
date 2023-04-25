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
    public partial class frmCadEstoque : Form
    {
        public frmCadEstoque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClearAllBoxes.AreTextBoxesFilled(this))
            {
                // Valida e salva o novo registro no banco de dados
                this.Validate();
                controlestoqueBindingSource.EndEdit();
                control_estoqueTableAdapter.Update(mahoganyDataSet.control_estoque);
                this.control_estoqueTableAdapter.Fill(this.mahoganyDataSet.control_estoque);
                controlestoqueBindingSource.MoveLast();

                // Adiciona um novo registro ao BindingSource
                controlestoqueBindingSource.AddNew();

                // Define o foco no TextBox2
                textBox2.Focus();

                // Exibe mensagem de sucesso
                MessageBox.Show("Produto de Estoque cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Preencha todos os Dados", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCadEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.control_estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.control_estoqueTableAdapter.Fill(this.mahoganyDataSet.control_estoque);
            controlestoqueBindingSource.AddNew();

            maskedTextBox5.Mask = "00/00/0000";
            maskedTextBox2.Mask = "00/00/0000";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllBoxes.LimparTudo(this);
        }
    }
}
