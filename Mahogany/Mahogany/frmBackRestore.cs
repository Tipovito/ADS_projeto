using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------------------------------------------------------------------
using System.Data.SqlClient;
//-------------------------------------------------------------------------

namespace Mahogany
{
    public partial class frmBackRestore : Form
    {
        //-----------------------------------------------------------------
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        string sql = " ";
        string connectionStrig = "";
        //-----------------------------------------------------------------

        public frmBackRestore()
        {
            InitializeComponent();
        }

        private void frmBackRestore_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            comboBox1.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
            button3.Enabled = false;
            button7.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-----------------------------------------------
            try
            {
                connectionStrig = "Data Source = " + textBox1.Text + "; User Id=" + textBox2.Text + "; Password=" + textBox3.Text + "";
                conn = new SqlConnection(connectionStrig);
                conn.Open();
                //sql = "EXEC sp_databases";
                sql = "SELECT * FROM sys.databases d WHERE  d.database_id>4";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                comboBox1.Items.Clear();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }
                reader.Dispose();
                conn.Close();
                conn.Dispose();

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                comboBox1.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;               
                {
                    MessageBox.Show("Por favor, Selecione o Banco de Dados");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //-----------------------------------------------
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button2.Enabled = true;
            comboBox1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = dlg.SelectedPath;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Por favor, Selecione o Banco de Dados.");
                    return;
                }
                conn = new SqlConnection(connectionStrig);
                conn.Open();
                sql = "BACKUP DATABASE " + comboBox1.Text + " TO DISK= '" + textBox4.Text + "\\" + comboBox1.Text + "-" + DateTime.Now.Ticks.ToString() + ".bak'";
                //sql = "BACKUP DATABASE" + comboBox1.Text + " TO DISK= " + textBox4.Text + "\\" + comboBox1.Text + "-" + DateTime.Now.Ticks.ToString() + " .bak";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Banco de Dados Restaurado com Sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = dlg.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Please, select a DATABASE.");
                    return;
                }
                conn = new SqlConnection(connectionStrig);
                conn.Open();
                sql = " Alter DATABASE " + comboBox1.Text + " Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore DATABASE " + comboBox1.Text + " FROM DISK = '" + textBox5.Text + "' WITH REPLACE;";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Banco de Dados restaurado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmMenu frmBackRestore = new frmMenu();
            this.Hide();
            frmBackRestore.ShowDialog();
        }
    }
}
