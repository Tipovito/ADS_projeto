namespace Mahogany
{
    partial class frmCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Produtos = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proddescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodtipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodmarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodmateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVLaquisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVLvendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahoganyDataSet = new Mahogany.mahoganyDataSet();
            this.produtosTableAdapter = new Mahogany.mahoganyDataSetTableAdapters.produtosTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahoganyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caixa de Produto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Produtos
            // 
            this.Produtos.FormattingEnabled = true;
            this.Produtos.Location = new System.Drawing.Point(546, 55);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(311, 95);
            this.Produtos.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(736, 189);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Valor total:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de Débito",
            "Cartão de Crédito"});
            this.comboBox1.Location = new System.Drawing.Point(736, 245);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(317, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Finalizar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodCDDataGridViewTextBoxColumn,
            this.proddescDataGridViewTextBoxColumn,
            this.prodtipoDataGridViewTextBoxColumn,
            this.prodmarcaDataGridViewTextBoxColumn,
            this.prodmateDataGridViewTextBoxColumn,
            this.prodQTDataGridViewTextBoxColumn,
            this.prodVLaquisiDataGridViewTextBoxColumn,
            this.prodVLvendaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // prodCDDataGridViewTextBoxColumn
            // 
            this.prodCDDataGridViewTextBoxColumn.DataPropertyName = "prod_CD";
            this.prodCDDataGridViewTextBoxColumn.HeaderText = "prod_CD";
            this.prodCDDataGridViewTextBoxColumn.Name = "prodCDDataGridViewTextBoxColumn";
            this.prodCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proddescDataGridViewTextBoxColumn
            // 
            this.proddescDataGridViewTextBoxColumn.DataPropertyName = "prod_desc";
            this.proddescDataGridViewTextBoxColumn.HeaderText = "prod_desc";
            this.proddescDataGridViewTextBoxColumn.Name = "proddescDataGridViewTextBoxColumn";
            // 
            // prodtipoDataGridViewTextBoxColumn
            // 
            this.prodtipoDataGridViewTextBoxColumn.DataPropertyName = "prod_tipo";
            this.prodtipoDataGridViewTextBoxColumn.HeaderText = "prod_tipo";
            this.prodtipoDataGridViewTextBoxColumn.Name = "prodtipoDataGridViewTextBoxColumn";
            // 
            // prodmarcaDataGridViewTextBoxColumn
            // 
            this.prodmarcaDataGridViewTextBoxColumn.DataPropertyName = "prod_marca";
            this.prodmarcaDataGridViewTextBoxColumn.HeaderText = "prod_marca";
            this.prodmarcaDataGridViewTextBoxColumn.Name = "prodmarcaDataGridViewTextBoxColumn";
            // 
            // prodmateDataGridViewTextBoxColumn
            // 
            this.prodmateDataGridViewTextBoxColumn.DataPropertyName = "prod_mate";
            this.prodmateDataGridViewTextBoxColumn.HeaderText = "prod_mate";
            this.prodmateDataGridViewTextBoxColumn.Name = "prodmateDataGridViewTextBoxColumn";
            // 
            // prodQTDataGridViewTextBoxColumn
            // 
            this.prodQTDataGridViewTextBoxColumn.DataPropertyName = "prod_QT";
            this.prodQTDataGridViewTextBoxColumn.HeaderText = "prod_QT";
            this.prodQTDataGridViewTextBoxColumn.Name = "prodQTDataGridViewTextBoxColumn";
            // 
            // prodVLaquisiDataGridViewTextBoxColumn
            // 
            this.prodVLaquisiDataGridViewTextBoxColumn.DataPropertyName = "prod_VL_aquisi";
            this.prodVLaquisiDataGridViewTextBoxColumn.HeaderText = "prod_VL_aquisi";
            this.prodVLaquisiDataGridViewTextBoxColumn.Name = "prodVLaquisiDataGridViewTextBoxColumn";
            // 
            // prodVLvendaDataGridViewTextBoxColumn
            // 
            this.prodVLvendaDataGridViewTextBoxColumn.DataPropertyName = "prod_VL_venda";
            this.prodVLvendaDataGridViewTextBoxColumn.HeaderText = "prod_VL_venda";
            this.prodVLvendaDataGridViewTextBoxColumn.Name = "prodVLvendaDataGridViewTextBoxColumn";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.mahoganyDataSet;
            // 
            // mahoganyDataSet
            // 
            this.mahoganyDataSet.DataSetName = "mahoganyDataSet";
            this.mahoganyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(940, 269);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 10;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Produtos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCaixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahoganyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox Produtos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mahoganyDataSet mahoganyDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private mahoganyDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proddescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodtipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodmarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodmateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodVLaquisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodVLvendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox1;
    }
}