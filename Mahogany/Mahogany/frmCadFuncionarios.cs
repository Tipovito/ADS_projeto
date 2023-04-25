using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Mahogany
{
    public partial class frmCadFuncionarios : Form
    {
        public frmCadFuncionarios()
        {
            InitializeComponent();
        }

        
        private void frmCadFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'colabDataSet.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.mahoganyDataSet.funcionarios);
            funcionariosBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (ClearAllBoxes.AreTextBoxesFilled(this))
            {
                // Valida e salva o novo registro no banco de dados
                this.Validate();
                funcionariosBindingSource.EndEdit();
                funcionariosTableAdapter.Update(mahoganyDataSet.funcionarios);
                this.funcionariosTableAdapter.Fill(this.mahoganyDataSet.funcionarios);
                funcionariosBindingSource.MoveLast();

                // Adiciona um novo registro ao BindingSource
                funcionariosBindingSource.AddNew();

                // Define o foco no TextBox2
                textBox2.Focus();

                // Exibe mensagem de sucesso
                MessageBox.Show("Funcionário cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Preencha todos os dados", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearAllBoxes.LimparTudo(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmFuncionários frmCadFuncionarios = new frmFuncionários();
            this.Hide();
            frmCadFuncionarios.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }   
}
