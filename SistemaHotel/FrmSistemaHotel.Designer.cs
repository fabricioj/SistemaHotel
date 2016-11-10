namespace SistemaHotel
{
    partial class FrmSistemaHotel
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
            this.mnuSistema = new System.Windows.Forms.MenuStrip();
            this.mnuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMovimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrcamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSistema
            // 
            this.mnuSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastros,
            this.mnuMovimentos});
            this.mnuSistema.Location = new System.Drawing.Point(0, 0);
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Size = new System.Drawing.Size(784, 24);
            this.mnuSistema.TabIndex = 0;
            this.mnuSistema.Text = "menuStrip1";
            // 
            // mnuCadastros
            // 
            this.mnuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProdutos,
            this.toolStripSeparator1,
            this.mnuFornecedores});
            this.mnuCadastros.Name = "mnuCadastros";
            this.mnuCadastros.Size = new System.Drawing.Size(71, 20);
            this.mnuCadastros.Text = "Cadastros";
            // 
            // mnuProdutos
            // 
            this.mnuProdutos.Name = "mnuProdutos";
            this.mnuProdutos.Size = new System.Drawing.Size(145, 22);
            this.mnuProdutos.Text = "Produtos";
            this.mnuProdutos.Click += new System.EventHandler(this.mnuProdutos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuFornecedores
            // 
            this.mnuFornecedores.Name = "mnuFornecedores";
            this.mnuFornecedores.Size = new System.Drawing.Size(145, 22);
            this.mnuFornecedores.Text = "Fornecedores";
            this.mnuFornecedores.Click += new System.EventHandler(this.mnuFornecedores_Click);
            // 
            // mnuMovimentos
            // 
            this.mnuMovimentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOrcamentos});
            this.mnuMovimentos.Name = "mnuMovimentos";
            this.mnuMovimentos.Size = new System.Drawing.Size(86, 20);
            this.mnuMovimentos.Text = "Movimentos";
            // 
            // mnuOrcamentos
            // 
            this.mnuOrcamentos.Name = "mnuOrcamentos";
            this.mnuOrcamentos.Size = new System.Drawing.Size(152, 22);
            this.mnuOrcamentos.Text = "Orçamentos";
            this.mnuOrcamentos.Click += new System.EventHandler(this.mnuOrcamentos_Click);
            // 
            // FrmSistemaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mnuSistema);
            this.Name = "FrmSistemaHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema hotel";
            this.mnuSistema.ResumeLayout(false);
            this.mnuSistema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastros;
        private System.Windows.Forms.ToolStripMenuItem mnuProdutos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem mnuMovimentos;
        private System.Windows.Forms.ToolStripMenuItem mnuOrcamentos;
    }
}

