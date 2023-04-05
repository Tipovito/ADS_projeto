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
    public partial class frmAlteraProdutos : Form
    {
        public frmAlteraProdutos()
        {
            InitializeComponent();
        }

        private void frmAlteraProdutos_Load(object sender, EventArgs e)
        {
            this.produtosTableAdapter.Fill(this.mahoganyDataSet.produtos);
            if (Class1.altera == "")
            { produtosBindingSource.AddNew(); }
            else
            { produtosBindingSource.Filter = string.Format("prod_CD={0}", Class1.altera); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            produtosBindingSource.EndEdit();
            produtosTableAdapter.Update(mahoganyDataSet.produtos);
            this.produtosTableAdapter.Fill(this.mahoganyDataSet.produtos);
            produtosBindingSource.MoveLast();

            //aparece a mensagem quando der certo
            MessageBox.Show(" Produto alterado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox1.Focus();

            frmProdutos pesq = new frmProdutos();
            this.Hide();
            pesq.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmProdutos frmCadprodutos = new frmProdutos();
            this.Hide();
            frmCadprodutos.ShowDialog();
        }
    }
}
