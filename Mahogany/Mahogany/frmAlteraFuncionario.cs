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
    public partial class frmAlteraFuncionario : Form
    {
        public frmAlteraFuncionario()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            funcionariosBindingSource.EndEdit();
            funcionariosTableAdapter.Update(mahoganyDataSet.funcionarios);
            this.funcionariosTableAdapter.Fill(this.mahoganyDataSet.funcionarios);
            funcionariosBindingSource.MoveLast();

            //aparece a mensagem quando der certo
            MessageBox.Show(" Funcionário alterado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox1.Focus();

            frmFuncionários pesq = new frmFuncionários();
            this.Hide();
            pesq.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFuncionários frmCadFuncionarios = new frmFuncionários();
            this.Hide();
            frmCadFuncionarios.ShowDialog();
        }

        private void frmAlteraFuncionario_Load(object sender, EventArgs e)
        {
            this.funcionariosTableAdapter.Fill(this.mahoganyDataSet.funcionarios);
            if (Class1.altera == "")
            { funcionariosBindingSource.AddNew(); }
            else
            { funcionariosBindingSource.Filter = string.Format("func_CD={0}", Class1.altera); }

        }
    }
}
