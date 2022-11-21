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
            Form fprodutos = new FormsProdutos();
            fprodutos.MdiParent = this;
            fprodutos.Show();
        }

        private void toolsLogin_Click(object sender, EventArgs e)
        {
            Form flogin = new FormLogin();
            flogin.MdiParent = this;
            flogin.Show();
        }
    }
}
