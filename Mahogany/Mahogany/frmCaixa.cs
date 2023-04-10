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
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.mahoganyDataSet.produtos);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string pesquisa = textBox2.Text;
            foreach (DataGridViewRow row in
                dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value.ToString().Contains(pesquisa))
                {
                    Produtos.Items.Add(row.Cells[1].Value.ToString()
                        + " | " +
                        row.Cells[2].Value.ToString()
                        + " | R$ " +
                        row.Cells[3].Value.ToString()
                        
                        );

                    Produtos.Items.Add(row.Cells[3].Value.ToString());
                    double valorTotal = 0;

                    //listBox1.Items.Add(row.Cells[0].Value.ToString());

                    foreach (string v in Produtos.Items)
                    {
                        double dv = Double.Parse(v);
                        valorTotal += dv;
                    }
                    textBox2.Text = "Valor total: " + valorTotal.ToString();

                    break;

                }


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                produtosBindingSource.Filter = string.Format("prod_CD={0}", textBox1.Text);
            }
            else
            {
                produtosBindingSource.Filter = "";

            }
        }
    }
}
