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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahoganyDataSet = new Mahogany.mahoganyDataSet();
            this.produtosTableAdapter = new Mahogany.mahoganyDataSetTableAdapters.produtosTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Produtos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodCDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proddescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodtipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodmarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodmateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVLaquisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVLvendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.controlcaixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.control_caixaTableAdapter = new Mahogany.mahoganyDataSetTableAdapters.control_caixaTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahoganyDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlcaixaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(600, 389);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(322, 87);
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
            this.comboBox1.Location = new System.Drawing.Point(600, 502);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(322, 21);
            this.comboBox1.TabIndex = 4;
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
            this.listBox1.Location = new System.Drawing.Point(957, 318);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 10;
            // 
            // Produtos
            // 
            this.Produtos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Produtos.FormattingEnabled = true;
            this.Produtos.Location = new System.Drawing.Point(600, 100);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(322, 262);
            this.Produtos.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(27, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 391);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodCDDataGridViewTextBoxColumn1,
            this.proddescDataGridViewTextBoxColumn,
            this.prodtipoDataGridViewTextBoxColumn,
            this.prodmarcaDataGridViewTextBoxColumn,
            this.prodmateDataGridViewTextBoxColumn,
            this.prodQTDataGridViewTextBoxColumn1,
            this.prodVLaquisiDataGridViewTextBoxColumn,
            this.prodVLvendaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(443, 346);
            this.dataGridView1.TabIndex = 1;
            // 
            // prodCDDataGridViewTextBoxColumn1
            // 
            this.prodCDDataGridViewTextBoxColumn1.DataPropertyName = "prod_CD";
            this.prodCDDataGridViewTextBoxColumn1.HeaderText = "prod_CD";
            this.prodCDDataGridViewTextBoxColumn1.Name = "prodCDDataGridViewTextBoxColumn1";
            this.prodCDDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // prodQTDataGridViewTextBoxColumn1
            // 
            this.prodQTDataGridViewTextBoxColumn1.DataPropertyName = "prod_QT";
            this.prodQTDataGridViewTextBoxColumn1.HeaderText = "prod_QT";
            this.prodQTDataGridViewTextBoxColumn1.Name = "prodQTDataGridViewTextBoxColumn1";
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.button5.Location = new System.Drawing.Point(27, 563);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 33);
            this.button5.TabIndex = 48;
            this.button5.Text = "Adicionar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.button1.Location = new System.Drawing.Point(172, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 33);
            this.button1.TabIndex = 49;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.button3.Location = new System.Drawing.Point(813, 563);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 33);
            this.button3.TabIndex = 51;
            this.button3.Text = "Finalizar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // controlcaixaBindingSource
            // 
            this.controlcaixaBindingSource.DataMember = "control_caixa";
            this.controlcaixaBindingSource.DataSource = this.mahoganyDataSet;
            // 
            // control_caixaTableAdapter
            // 
            this.control_caixaTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(24, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Código de Produto";
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 700);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Produtos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCaixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahoganyDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlcaixaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private mahoganyDataSet mahoganyDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private mahoganyDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox Produtos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource controlcaixaBindingSource;
        private mahoganyDataSetTableAdapters.control_caixaTableAdapter control_caixaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proddescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodtipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodmarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodmateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodVLaquisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodVLvendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}