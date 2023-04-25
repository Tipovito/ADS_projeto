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
    public partial class frmAlteraCliente : Form
    {
        public frmAlteraCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            clientesBindingSource.EndEdit();
            clientesTableAdapter.Update(mahoganyDataSet.clientes);
            this.clientesTableAdapter.Fill(this.mahoganyDataSet.clientes);
            clientesBindingSource.MoveLast();

            //aparece a mensagem quando der certo
            MessageBox.Show(" Cliente alterado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox1.Focus();

            frmClientes pesq = new frmClientes();
            this.Hide();
            pesq.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlteraCliente_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.mahoganyDataSet.clientes);
            if (Class1.altera == "")
            { clientesBindingSource.AddNew(); }
            else
            { clientesBindingSource.Filter = string.Format("clie_CD={0}", Class1.altera); }
        }
    }
}
