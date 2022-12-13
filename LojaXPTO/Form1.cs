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
    public partial class Form1 : Form
    {
        //definir as variáveis globais
        public static string utilizador;


        public void MostrarLogin(string u)
        {
            if (u == "")
            {
                toolLabel.Text = "LOGIN";
            }
            else
            {
                toolLabel.Text = u;
            }
        }

        public void MostrarMenus(int v)
        {
            if (v == 0)
            {
                ficheiroToolStripMenuItem.Enabled = false;
                produtosToolStripMenuItem.Enabled = false;
                vendasToolStripMenuItem.Enabled = false;
                reparaçõesToolStripMenuItem.Enabled = false;
            }
            else
            {
                ficheiroToolStripMenuItem.Enabled = true;
                produtosToolStripMenuItem.Enabled = true;
                vendasToolStripMenuItem.Enabled = true;
                reparaçõesToolStripMenuItem.Enabled = true;
            }
        }

        public void MostrarTools(int v)
        {
            if (v == 0)
            {
                toolsAbrir.Enabled = false;
                toolsConsultarVendas.Enabled = false;
                toolsGuardar.Enabled = false;
                toolsListagemProdutos.Enabled = false;
                toolsRegistarAvarias.Enabled = false;
            }
            else
            {
                toolsAbrir.Enabled = true;
                toolsConsultarVendas.Enabled = true;
                toolsGuardar.Enabled = true;
                toolsListagemProdutos.Enabled = true;
                toolsRegistarAvarias.Enabled = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void registoDeAvariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form favarias = new FormRegistoAvarias();
            favarias.MdiParent = this;
            favarias.Show();
        }

        private void toolsRegistarAvarias_Click(object sender, EventArgs e)
        {
            Form favarias = new FormRegistoAvarias();
            favarias.MdiParent = this;
            favarias.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int findex;
            if (!ExisteNoParent(typeof(FormLogin), out findex))
            {
                Form fprodutos = new FormsProdutos();
                fprodutos.MdiParent = this;
                fprodutos.Show();
                fprodutos.Location = new Point(5, 5);
                fprodutos.Dock = DockStyle.Fill;
            }
        }

        private void toolLogin_Click(object sender, EventArgs e)
        {
            int findex;
            if (!ExisteNoParent(typeof(FormLogin), out findex))
            {
                Form flogin = new FormLogin();
                flogin.MdiParent = this;
                flogin.Show();
                flogin.Location = new Point(5, 5);
                flogin.Dock = DockStyle.Fill;
            }
        }


        //esta função vai verificar na matriz MdiChildren (onde está
        //registado o index dos formulários abertos no nosso MDI) se
        //está o formulário que pretendemos abrir (instanciar).
        //se não existir devolve -1 e podemos abrir uma nova instância 
        bool ExisteNoParent(Type type, out int findex)
        {
            int contador = this.MdiChildren.Length;
            for (int i = 0; i < contador; i++)
            {
                if (this.MdiChildren[i].GetType() == type)
                {
                    findex = i;
                    return true;
                }
            }
            findex = -1;
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ajustar a label de utilizador
            MostrarLogin(utilizador);

            //ajustar os menus conforme o nível de acesso
            MostrarMenus(0);

            //ajustar ferramentas conforme o nivel de acesso
            MostrarTools(0);
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int findex;
            if (!ExisteNoParent(typeof(FormCategorias), out findex))
            {
                Form f = new FormCategorias();
                f.MdiParent = this;
                f.Show();
                f.Location = new Point(5, 5);
                f.Dock = DockStyle.Fill;
            }
        }
    }
}
