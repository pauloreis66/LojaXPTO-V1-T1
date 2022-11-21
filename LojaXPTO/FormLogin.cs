using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaXPTO
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //encerrar o formulário
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar os campos
            txtUser.ResetText();
            txtPassword.Clear();
            txtNome.Text = "";
            txtUser.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //verificar as credenciais
            //tratamento de exceçoes
            try
            {
                if (txtUser.Text =="" && txtPassword.Text=="")
                {
                    throw new Exception("Digite o seu login e a senha.");
                }

                if (txtUser.Text=="")
                {
                    throw new Exception("Digite o seu login de utilizador");
                }

                if (txtPassword.Text == "")
                {
                    throw new Exception("Digite a sua Senha.");
                }

                if (!txtUser.Text.Equals("admin") && !txtPassword.Text.Equals("admin"))
                {
                    throw new Exception("Utilizadador e Senha não são válidas.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            //
            MessageBox.Show("Autenticado com sucesso.", "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            //ajustar a label do formulário principal
            Form1.utilizador = txtUser.Text;
            Form1 pobjForm = (Form1)this.MdiParent;
            pobjForm.MostrarLogin(txtUser.Text);
            pobjForm.MostrarMenus(1);
            pobjForm.MostrarTools(1);

            //encerrar o formulário
            this.Close();

        }
    }
}
