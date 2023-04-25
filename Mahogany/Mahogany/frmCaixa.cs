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
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.control_caixa'. Você pode movê-la ou removê-la conforme necessário.
            this.control_caixaTableAdapter.Fill(this.mahoganyDataSet.control_caixa);
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.mahoganyDataSet.produtos);
            controlcaixaBindingSource.AddNew();
            dataGridView1.Columns[7].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "C2";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string pesquisa = textBox1.Text;
            foreach (DataGridViewRow row in
                dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value.ToString().Contains(pesquisa))
                {
                    Produtos.Items.Add(row.Cells[1].Value.ToString()
                        + " | " +
                        row.Cells[3].Value.ToString()
                        + " | R$ " +
                        row.Cells[7].Value.ToString()
                        );

                    listBox1.Items.Add(row.Cells[7].Value.ToString());
                    double valorTotal = 0;

                    //listBox2.Items.Add(row.Cells[0].Value.ToString());

                    foreach (string v in listBox1.Items)
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

        private void button5_Click(object sender, EventArgs e)
        {
            string pesquisa = textBox1.Text;
            foreach (DataGridViewRow row in
                dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value.ToString().Contains(pesquisa))
                {
                    Produtos.Items.Add(row.Cells[1].Value.ToString()
                        + " | " +
                        row.Cells[3].Value.ToString()
                        + " | R$ " +
                        row.Cells[7].Value.ToString()
                        );

                    listBox1.Items.Add(row.Cells[7].Value.ToString());
                    double valorTotal = 0;

                    //listBox2.Items.Add(row.Cells[0].Value.ToString());

                    foreach (string v in listBox1.Items)
                    {
                        double dv = Double.Parse(v);
                        valorTotal += dv;
                    }
                    textBox2.Text = "Valor total: " + valorTotal.ToString();

                    break;

                }


            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Produtos.Items.Count > 0)
            {
                string pesquisa = textBox1.Text;
                foreach (DataGridViewRow row in
                    dataGridView1.SelectedRows)
                {
                    if (row.Cells[0].Value.ToString().Contains(pesquisa))
                    {
                        Produtos.Items.Remove(
                            row.Cells[1].Value.ToString()
                            + " | " +
                            row.Cells[3].Value.ToString()
                            + " | R$ " +
                            row.Cells[7].Value.ToString()
                            );



                        listBox1.Items.Remove(row.Cells[7].Value.ToString());
                        double valorTotal = 0.0;

                        foreach (string v in listBox1.Items)
                        {
                            double dv = Double.Parse(v);
                            valorTotal += dv;
                        }
                        textBox2.Text = "Valor total: " + valorTotal.ToString();

                        break;

                    }


                }
                MessageBox.Show("O item foi removido com sucesso", "Remoção de item", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("O carrinho está vazio, nada para tirar", "Erro no caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
