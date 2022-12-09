namespace LojaXPTO
{
    partial class FormListarProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.grelha = new System.Windows.Forms.DataGridView();
            this.tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grelha)).BeginInit();
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tools.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSair});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(800, 39);
            this.tools.TabIndex = 0;
            this.tools.Text = "toolStrip1";
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = global::LojaXPTO.Properties.Resources.Windows_Close_Program_icon;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 36);
            this.btnSair.Text = "toolStripButton1";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grelha
            // 
            this.grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grelha.DefaultCellStyle = dataGridViewCellStyle1;
            this.grelha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grelha.Location = new System.Drawing.Point(0, 39);
            this.grelha.Name = "grelha";
            this.grelha.Size = new System.Drawing.Size(800, 411);
            this.grelha.TabIndex = 1;
            // 
            // FormListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grelha);
            this.Controls.Add(this.tools);
            this.Name = "FormListarProdutos";
            this.Load += new System.EventHandler(this.FormListarProdutos_Load);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grelha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.DataGridView grelha;
    }
}