﻿using System;
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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMenu frmPesquisaProdutos = new frmMenu();
            this.Hide();
            frmPesquisaProdutos.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCadProdutos frmPesquisaProdutos = new frmCadProdutos();
            //this.Hide();
            frmPesquisaProdutos.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            produtosBindingSource.Filter = string.Format("prod_CD={0}",
            textBox1.Text);
        }

        private void frmPesquisaProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mahoganyDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.mahoganyDataSet.produtos);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                produtosBindingSource.RemoveCurrent();
                produtosTableAdapter.Update(mahoganyDataSet.produtos); //salvar
                this.produtosTableAdapter.Fill(this.mahoganyDataSet.produtos);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.altera = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //this.Visible = false;
            frmAlteraProdutos frmPesquisaProdutos = new frmAlteraProdutos();
            frmPesquisaProdutos.ShowDialog();
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

        private void button6_Click(object sender, EventArgs e)
        {
            frmCadFornecedores frmProdutos = new frmCadFornecedores();
            this.Hide();
            frmProdutos.ShowDialog();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.produtosTableAdapter.Fill(this.mahoganyDataSet.produtos);
        }
    }
}
