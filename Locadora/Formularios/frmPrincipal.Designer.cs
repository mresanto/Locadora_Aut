namespace Locadora
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadAlugle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadCliente,
            this.mnuCadVeiculo,
            this.mnuCadAlugle});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // mnuCadCliente
            // 
            this.mnuCadCliente.Name = "mnuCadCliente";
            this.mnuCadCliente.Size = new System.Drawing.Size(115, 22);
            this.mnuCadCliente.Text = "Cliente";
            this.mnuCadCliente.Click += new System.EventHandler(this.mnuCadCliente_Click);
            // 
            // mnuCadVeiculo
            // 
            this.mnuCadVeiculo.Name = "mnuCadVeiculo";
            this.mnuCadVeiculo.Size = new System.Drawing.Size(115, 22);
            this.mnuCadVeiculo.Text = "Veículo";
            this.mnuCadVeiculo.Click += new System.EventHandler(this.mnuCadVeiculo_Click);
            // 
            // mnuCadAlugle
            // 
            this.mnuCadAlugle.Name = "mnuCadAlugle";
            this.mnuCadAlugle.Size = new System.Drawing.Size(115, 22);
            this.mnuCadAlugle.Text = "Aluguel";
            this.mnuCadAlugle.Click += new System.EventHandler(this.mnuCadAlugle_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 596);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCadCliente;
        private System.Windows.Forms.ToolStripMenuItem mnuCadVeiculo;
        private System.Windows.Forms.ToolStripMenuItem mnuCadAlugle;
    }
}

