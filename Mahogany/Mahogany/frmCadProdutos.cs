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
    public partial class frmCadProdutos : Form
    {
        public frmCadProdutos()
        {
            InitializeComponent();
        }

       
        private void frmCadProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.mahoganyDataSet.produtos);
            produtosBindingSource.AddNew();
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
            // Valida e salva o novo registro no banco de dados

            if (ClearAllBoxes. AreTextBoxesFilled(this))
            {
                this.Validate();
                produtosBindingSource.EndEdit();
                produtosTableAdapter.Update(mahoganyDataSet.produtos);
                this.produtosTableAdapter.Fill(this.mahoganyDataSet.produtos);
                produtosBindingSource.MoveLast();

                // Adiciona um novo registro ao BindingSource
                produtosBindingSource.AddNew();

                // Define o foco no TextBox2
                textBox2.Focus();

                // Exibe mensagem de sucesso

                MessageBox.Show("Produto cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Preencha todos os dados", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
