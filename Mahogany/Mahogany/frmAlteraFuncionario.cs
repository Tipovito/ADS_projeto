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
            maskedTextBox1.Mask = "00.000.000-0";
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Mask = "00-0000.0000";
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

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
