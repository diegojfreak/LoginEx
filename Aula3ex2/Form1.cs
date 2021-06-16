using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool erros = false;

            if(txtLogin.Text.Trim() == "")
            {
                errorProvider1.SetError(txtLogin, "Campo Obrigatorio");
                erros = true;
            }

            if(txtSenha.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSenha, "Campo Obrigatorio");
                erros = true;
            }

            if(cboTipo.SelectedIndex == 0)
            {
                errorProvider1.SetError(cboTipo, "Campo Obrigatorio");
                erros = true;
            }

            if(erros == false)
            {
                MessageBox.Show("Dados cadastrados com sucesso!");

                txtLogin.Text = "";
                txtSenha.Text = "";
                cboTipo.SelectedIndex = 0;

                txtLogin.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTipo.SelectedIndex = 0;
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opcao = new OpenFileDialog();

            DialogResult resultado = opcao.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opcao.FileName);
            }
        }
    }
}
