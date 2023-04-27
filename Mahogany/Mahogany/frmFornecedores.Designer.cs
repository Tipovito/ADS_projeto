namespace Mahogany
{
    partial class frmFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedores));
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fornCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornRsocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornCNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornInsestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornfoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornrpstntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahoganyDataSet = new Mahogany.mahoganyDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.fornecedoresTableAdapter = new Mahogany.mahoganyDataSetTableAdapters.fornecedoresTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahoganyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(25, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(901, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "_________________________________________________________________________________" +
    "____________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(553, 650);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Excluir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(351, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Alterar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(122, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Novo Cadastro";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(71, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 401);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fornCDDataGridViewTextBoxColumn,
            this.fornRsocialDataGridViewTextBoxColumn,
            this.fornCNPJDataGridViewTextBoxColumn,
            this.fornInsestDataGridViewTextBoxColumn,
            this.fornendDataGridViewTextBoxColumn,
            this.fornfoneDataGridViewTextBoxColumn,
            this.fornemailDataGridViewTextBoxColumn,
            this.fornrpstntDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fornecedoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(770, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // fornCDDataGridViewTextBoxColumn
            // 
            this.fornCDDataGridViewTextBoxColumn.DataPropertyName = "forn_CD";
            this.fornCDDataGridViewTextBoxColumn.HeaderText = "Código";
            this.fornCDDataGridViewTextBoxColumn.Name = "fornCDDataGridViewTextBoxColumn";
            this.fornCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornRsocialDataGridViewTextBoxColumn
            // 
            this.fornRsocialDataGridViewTextBoxColumn.DataPropertyName = "forn_Rsocial";
            this.fornRsocialDataGridViewTextBoxColumn.HeaderText = "Razão Social";
            this.fornRsocialDataGridViewTextBoxColumn.Name = "fornRsocialDataGridViewTextBoxColumn";
            // 
            // fornCNPJDataGridViewTextBoxColumn
            // 
            this.fornCNPJDataGridViewTextBoxColumn.DataPropertyName = "forn_CNPJ";
            this.fornCNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.fornCNPJDataGridViewTextBoxColumn.Name = "fornCNPJDataGridViewTextBoxColumn";
            // 
            // fornInsestDataGridViewTextBoxColumn
            // 
            this.fornInsestDataGridViewTextBoxColumn.DataPropertyName = "forn_Ins_est";
            this.fornInsestDataGridViewTextBoxColumn.HeaderText = "Inscrição Estadual";
            this.fornInsestDataGridViewTextBoxColumn.Name = "fornInsestDataGridViewTextBoxColumn";
            // 
            // fornendDataGridViewTextBoxColumn
            // 
            this.fornendDataGridViewTextBoxColumn.DataPropertyName = "forn_end";
            this.fornendDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.fornendDataGridViewTextBoxColumn.Name = "fornendDataGridViewTextBoxColumn";
            // 
            // fornfoneDataGridViewTextBoxColumn
            // 
            this.fornfoneDataGridViewTextBoxColumn.DataPropertyName = "forn_fone";
            this.fornfoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.fornfoneDataGridViewTextBoxColumn.Name = "fornfoneDataGridViewTextBoxColumn";
            // 
            // fornemailDataGridViewTextBoxColumn
            // 
            this.fornemailDataGridViewTextBoxColumn.DataPropertyName = "forn_email";
            this.fornemailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.fornemailDataGridViewTextBoxColumn.Name = "fornemailDataGridViewTextBoxColumn";
            // 
            // fornrpstntDataGridViewTextBoxColumn
            // 
            this.fornrpstntDataGridViewTextBoxColumn.DataPropertyName = "forn_rpstnt";
            this.fornrpstntDataGridViewTextBoxColumn.HeaderText = "Representante";
            this.fornrpstntDataGridViewTextBoxColumn.Name = "fornrpstntDataGridViewTextBoxColumn";
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "fornecedores";
            this.fornecedoresBindingSource.DataSource = this.mahoganyDataSet;
            // 
            // mahoganyDataSet
            // 
            this.mahoganyDataSet.DataSetName = "mahoganyDataSet";
            this.mahoganyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(712, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(197, 665);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(559, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "_________________________________________________________________________________" +
    "___________";
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.button5.Location = new System.Drawing.Point(71, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.button4.Location = new System.Drawing.Point(90, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.button2.Location = new System.Drawing.Point(553, 600);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 47);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.button1.Location = new System.Drawing.Point(353, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 47);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(850, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 66;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(951, 700);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFornecedores";
            this.Text = "Pesquisa de Fornecedores";
            this.Load += new System.EventHandler(this.frmFornecedores_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahoganyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private mahoganyDataSet mahoganyDataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private mahoganyDataSetTableAdapters.fornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornRsocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornCNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornInsestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornfoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornrpstntDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}