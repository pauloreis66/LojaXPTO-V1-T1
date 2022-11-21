namespace LojaXPTO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasMensaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registoDeAvariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaGeralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.toolsAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolsGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsListagemProdutos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsConsultarVendas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsRegistarAvarias = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolLogin = new System.Windows.Forms.ToolStripButton();
            this.toolLabel = new System.Windows.Forms.ToolStripLabel();
            this.menu.SuspendLayout();
            this.tools.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.reparaçõesToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1112, 38);
            this.menu.TabIndex = 3;
            this.menu.Text = "menu";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem3,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(101, 34);
            this.ficheiroToolStripMenuItem.Text = "&Ficheiro";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.guardarComoToolStripMenuItem.Text = "&Guardar como...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.imprimirToolStripMenuItem.Text = "Im&primir";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(237, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.sairToolStripMenuItem.Text = "Sai&r";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listagemToolStripMenuItem,
            this.toolStripMenuItem4,
            this.novoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.apagarToolStripMenuItem,
            this.toolStripMenuItem5,
            this.categoriasToolStripMenuItem});
            this.produtosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(112, 34);
            this.produtosToolStripMenuItem.Text = "&Produtos";
            // 
            // listagemToolStripMenuItem
            // 
            this.listagemToolStripMenuItem.Name = "listagemToolStripMenuItem";
            this.listagemToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.listagemToolStripMenuItem.Text = "&Listagem";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(186, 6);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.novoToolStripMenuItem.Text = "&Novo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.editarToolStripMenuItem.Text = "&Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.apagarToolStripMenuItem.Text = "&Apagar";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(186, 6);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.vendasMensaisToolStripMenuItem});
            this.vendasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(95, 34);
            this.vendasToolStripMenuItem.Text = "&Vendas";
            // 
            // registarToolStripMenuItem
            // 
            this.registarToolStripMenuItem.Name = "registarToolStripMenuItem";
            this.registarToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.registarToolStripMenuItem.Text = "Registar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // vendasMensaisToolStripMenuItem
            // 
            this.vendasMensaisToolStripMenuItem.Name = "vendasMensaisToolStripMenuItem";
            this.vendasMensaisToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.vendasMensaisToolStripMenuItem.Text = "Vendas mensais";
            // 
            // reparaçõesToolStripMenuItem
            // 
            this.reparaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registoDeAvariasToolStripMenuItem,
            this.consultaGeralToolStripMenuItem});
            this.reparaçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.reparaçõesToolStripMenuItem.Name = "reparaçõesToolStripMenuItem";
            this.reparaçõesToolStripMenuItem.Size = new System.Drawing.Size(136, 34);
            this.reparaçõesToolStripMenuItem.Text = "&Reparações";
            // 
            // registoDeAvariasToolStripMenuItem
            // 
            this.registoDeAvariasToolStripMenuItem.Name = "registoDeAvariasToolStripMenuItem";
            this.registoDeAvariasToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.registoDeAvariasToolStripMenuItem.Text = "Registo de Avarias";
            this.registoDeAvariasToolStripMenuItem.Click += new System.EventHandler(this.registoDeAvariasToolStripMenuItem_Click);
            // 
            // consultaGeralToolStripMenuItem
            // 
            this.consultaGeralToolStripMenuItem.Name = "consultaGeralToolStripMenuItem";
            this.consultaGeralToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.consultaGeralToolStripMenuItem.Text = "Consulta geral";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.status.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.status.Location = new System.Drawing.Point(0, 590);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.status.Size = new System.Drawing.Size(1112, 22);
            this.status.TabIndex = 4;
            this.status.Text = "status";
            // 
            // tools
            // 
            this.tools.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsAbrir,
            this.toolsGuardar,
            this.toolStripSeparator1,
            this.toolsListagemProdutos,
            this.toolStripSeparator2,
            this.toolsConsultarVendas,
            this.toolStripSeparator3,
            this.toolsRegistarAvarias,
            this.toolStripSeparator4,
            this.toolLabel,
            this.toolLogin});
            this.tools.Location = new System.Drawing.Point(0, 38);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(1112, 39);
            this.tools.TabIndex = 5;
            this.tools.Text = "toolStrip1";
            // 
            // toolsAbrir
            // 
            this.toolsAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsAbrir.Image = global::LojaXPTO.Properties.Resources.Folder_icon;
            this.toolsAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsAbrir.Name = "toolsAbrir";
            this.toolsAbrir.Size = new System.Drawing.Size(36, 36);
            this.toolsAbrir.Text = "Abrir ficheiro";
            // 
            // toolsGuardar
            // 
            this.toolsGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsGuardar.Image = global::LojaXPTO.Properties.Resources.Floppy_disk_icon;
            this.toolsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsGuardar.Name = "toolsGuardar";
            this.toolsGuardar.Size = new System.Drawing.Size(36, 36);
            this.toolsGuardar.Text = "Guardar ficheiro";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolsListagemProdutos
            // 
            this.toolsListagemProdutos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsListagemProdutos.Image = global::LojaXPTO.Properties.Resources.Printer_modern_icon;
            this.toolsListagemProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsListagemProdutos.Name = "toolsListagemProdutos";
            this.toolsListagemProdutos.Size = new System.Drawing.Size(36, 36);
            this.toolsListagemProdutos.Text = "Listagem de Produtos";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolsConsultarVendas
            // 
            this.toolsConsultarVendas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsConsultarVendas.Image = global::LojaXPTO.Properties.Resources.Billing_icon;
            this.toolsConsultarVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsConsultarVendas.Name = "toolsConsultarVendas";
            this.toolsConsultarVendas.Size = new System.Drawing.Size(36, 36);
            this.toolsConsultarVendas.Text = "Consultar Vendas Mensais";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolsRegistarAvarias
            // 
            this.toolsRegistarAvarias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsRegistarAvarias.Image = global::LojaXPTO.Properties.Resources.Tools_icon;
            this.toolsRegistarAvarias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsRegistarAvarias.Name = "toolsRegistarAvarias";
            this.toolsRegistarAvarias.Size = new System.Drawing.Size(36, 36);
            this.toolsRegistarAvarias.Text = "Registo de avarias";
            this.toolsRegistarAvarias.Click += new System.EventHandler(this.toolsRegistarAvarias_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 513);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LojaXPTO.Properties.Resources.Tech_Support_icon;
            this.pictureBox1.Location = new System.Drawing.Point(23, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolLogin
            // 
            this.toolLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLogin.Image = global::LojaXPTO.Properties.Resources.User_icon;
            this.toolLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLogin.Name = "toolLogin";
            this.toolLogin.Size = new System.Drawing.Size(36, 36);
            this.toolLogin.Text = "Login";
            this.toolLogin.ToolTipText = "Login de Utilizador";
            this.toolLogin.Click += new System.EventHandler(this.toolLogin_Click);
            // 
            // toolLabel
            // 
            this.toolLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolLabel.AutoSize = false;
            this.toolLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolLabel.Name = "toolLabel";
            this.toolLabel.Size = new System.Drawing.Size(126, 36);
            this.toolLabel.Text = "Login";
            this.toolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja XPTO";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reparaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasMensaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registoDeAvariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaGeralToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolsAbrir;
        private System.Windows.Forms.ToolStripButton toolsGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolsListagemProdutos;
        private System.Windows.Forms.ToolStripButton toolsRegistarAvarias;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolsConsultarVendas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolLogin;
        private System.Windows.Forms.ToolStripLabel toolLabel;
    }
}

