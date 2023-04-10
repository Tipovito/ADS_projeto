namespace Mahogany
{
    partial class frmFuncionários
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionários));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.funcCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcCPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcRGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcDTnascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcnumcasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcfoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funccomissDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcsenhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funccargo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahoganyDataSet = new Mahogany.mahoganyDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.funcionariosTableAdapter = new Mahogany.mahoganyDataSetTableAdapters.funcionariosTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahoganyDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.funcCDDataGridViewTextBoxColumn,
            this.funcNMDataGridViewTextBoxColumn,
            this.funcCPFDataGridViewTextBoxColumn,
            this.funcRGDataGridViewTextBoxColumn,
            this.funcDTnascDataGridViewTextBoxColumn,
            this.funcendDataGridViewTextBoxColumn,
            this.funcnumcasaDataGridViewTextBoxColumn,
            this.funcfoneDataGridViewTextBoxColumn,
            this.funcemailDataGridViewTextBoxColumn,
            this.funccomissDataGridViewTextBoxColumn,
            this.funcloginDataGridViewTextBoxColumn,
            this.funcsenhaDataGridViewTextBoxColumn,
            this.funccargo2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.funcionariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(770, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // funcCDDataGridViewTextBoxColumn
            // 
            this.funcCDDataGridViewTextBoxColumn.DataPropertyName = "func_CD";
            this.funcCDDataGridViewTextBoxColumn.HeaderText = "Código";
            this.funcCDDataGridViewTextBoxColumn.Name = "funcCDDataGridViewTextBoxColumn";
            this.funcCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcNMDataGridViewTextBoxColumn
            // 
            this.funcNMDataGridViewTextBoxColumn.DataPropertyName = "func_NM";
            this.funcNMDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.funcNMDataGridViewTextBoxColumn.Name = "funcNMDataGridViewTextBoxColumn";
            // 
            // funcCPFDataGridViewTextBoxColumn
            // 
            this.funcCPFDataGridViewTextBoxColumn.DataPropertyName = "func_CPF";
            this.funcCPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.funcCPFDataGridViewTextBoxColumn.Name = "funcCPFDataGridViewTextBoxColumn";
            // 
            // funcRGDataGridViewTextBoxColumn
            // 
            this.funcRGDataGridViewTextBoxColumn.DataPropertyName = "func_RG";
            this.funcRGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.funcRGDataGridViewTextBoxColumn.Name = "funcRGDataGridViewTextBoxColumn";
            // 
            // funcDTnascDataGridViewTextBoxColumn
            // 
            this.funcDTnascDataGridViewTextBoxColumn.DataPropertyName = "func_DT_nasc";
            this.funcDTnascDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.funcDTnascDataGridViewTextBoxColumn.Name = "funcDTnascDataGridViewTextBoxColumn";
            // 
            // funcendDataGridViewTextBoxColumn
            // 
            this.funcendDataGridViewTextBoxColumn.DataPropertyName = "func_end";
            this.funcendDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.funcendDataGridViewTextBoxColumn.Name = "funcendDataGridViewTextBoxColumn";
            // 
            // funcnumcasaDataGridViewTextBoxColumn
            // 
            this.funcnumcasaDataGridViewTextBoxColumn.DataPropertyName = "func_numcasa";
            this.funcnumcasaDataGridViewTextBoxColumn.HeaderText = "Número da Casa";
            this.funcnumcasaDataGridViewTextBoxColumn.Name = "funcnumcasaDataGridViewTextBoxColumn";
            // 
            // funcfoneDataGridViewTextBoxColumn
            // 
            this.funcfoneDataGridViewTextBoxColumn.DataPropertyName = "func_fone";
            this.funcfoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.funcfoneDataGridViewTextBoxColumn.Name = "funcfoneDataGridViewTextBoxColumn";
            // 
            // funcemailDataGridViewTextBoxColumn
            // 
            this.funcemailDataGridViewTextBoxColumn.DataPropertyName = "func_email";
            this.funcemailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.funcemailDataGridViewTextBoxColumn.Name = "funcemailDataGridViewTextBoxColumn";
            // 
            // funccomissDataGridViewTextBoxColumn
            // 
            this.funccomissDataGridViewTextBoxColumn.DataPropertyName = "func_comiss";
            this.funccomissDataGridViewTextBoxColumn.HeaderText = "Comissão";
            this.funccomissDataGridViewTextBoxColumn.Name = "funccomissDataGridViewTextBoxColumn";
            // 
            // funcloginDataGridViewTextBoxColumn
            // 
            this.funcloginDataGridViewTextBoxColumn.DataPropertyName = "func_login";
            this.funcloginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.funcloginDataGridViewTextBoxColumn.Name = "funcloginDataGridViewTextBoxColumn";
            // 
            // funcsenhaDataGridViewTextBoxColumn
            // 
            this.funcsenhaDataGridViewTextBoxColumn.DataPropertyName = "func_senha";
            this.funcsenhaDataGridViewTextBoxColumn.HeaderText = "Senhas";
            this.funcsenhaDataGridViewTextBoxColumn.Name = "funcsenhaDataGridViewTextBoxColumn";
            // 
            // funccargo2DataGridViewTextBoxColumn
            // 
            this.funccargo2DataGridViewTextBoxColumn.DataPropertyName = "func_cargo2";
            this.funccargo2DataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.funccargo2DataGridViewTextBoxColumn.Name = "funccargo2DataGridViewTextBoxColumn";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.mahoganyDataSet;
            // 
            // mahoganyDataSet
            // 
            this.mahoganyDataSet.DataSetName = "mahoganyDataSet";
            this.mahoganyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.button1.Location = new System.Drawing.Point(347, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 47);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(748, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(195, 663);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(559, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "_________________________________________________________________________________" +
    "___________";
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(71, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 401);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
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
            this.button5.TabIndex = 5;
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
            this.button4.Location = new System.Drawing.Point(90, 123);
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
            this.button2.Location = new System.Drawing.Point(553, 595);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 47);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(122, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Novo Cadastro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(345, 647);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Alterar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(552, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Excluir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(25, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(901, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "_________________________________________________________________________________" +
    "____________________________________________________________________";
            // 
            // frmFuncionários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(951, 700);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFuncionários";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Funcionários";
            this.Load += new System.EventHandler(this.frmPesquisaFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahoganyDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private mahoganyDataSet mahoganyDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private mahoganyDataSetTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcCPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcRGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcDTnascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcnumcasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcfoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccomissDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcsenhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccargo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
    }
}