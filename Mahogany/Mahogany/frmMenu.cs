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
    public partial class frmMenu : Form
    {
        private Button btnAtual;
        private Form formAtual;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void cadastroDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmFuncionários(), sender);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void AbrirForm(Form formSel, Object btnSender)
        {
            if (formAtual != null)
            {
                formAtual.Close();
            }
            AtivarBtn(btnSender);
            formAtual = formSel;
            formSel.TopLevel = false; //nivel de controle
            formSel.FormBorderStyle = FormBorderStyle.None;//caixa de controle desativada
            formSel.Dock = DockStyle.Fill; // Posicionamento
            this.panelContainer.Controls.Add(formSel); //adicionar o form ao painel
            this.panelContainer.Tag = formSel;
            formSel.BringToFront();//Traz o controle para frente na ordem Z
            formSel.Show();// Chama o Form
            label7.BringToFront();
            label7.Text = formSel.Text;

        }

        private void Resetar()
        {
            label7.Text = " ";
            btnHome.Visible = false;
            btnAtual = null;
        }

        //
        private void AtivarBtn(Object btnSender)
        {
            if (btnSender != null)
            {
                if (btnAtual != (Button)btnSender)
                {
                    btnHome.Visible = true;
                    btnAtual = (Button)btnSender;
                }
            }
        }

                              
        private void button6_Click(object sender, EventArgs e)
        {
            frmLogin frmMenu = new frmLogin();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmProdutos(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmClientes(), sender);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVendas(), sender);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (formAtual != null)
            {
                formAtual.Close();
                Resetar();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCaixa(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmBackRestore frmMenu = new frmBackRestore();
            this.Hide();
            frmMenu.ShowDialog();
        }
    }
}
