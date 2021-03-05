namespace Locadora.Formularios
{
    partial class frmAluguel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPesquisar = new System.Windows.Forms.TabPage();
            this.grdPesquisar = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtPesquisarNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataAluguel = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisar)).BeginInit();
            this.tabCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPesquisar);
            this.tabControl1.Controls.Add(this.tabCadastro);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 607);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPesquisar
            // 
            this.tabPesquisar.Controls.Add(this.grdPesquisar);
            this.tabPesquisar.Controls.Add(this.lblNome);
            this.tabPesquisar.Controls.Add(this.txtPesquisarNome);
            this.tabPesquisar.Controls.Add(this.btnPesquisar);
            this.tabPesquisar.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisar.Name = "tabPesquisar";
            this.tabPesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisar.Size = new System.Drawing.Size(562, 581);
            this.tabPesquisar.TabIndex = 1;
            this.tabPesquisar.Text = "Pesquisar";
            this.tabPesquisar.UseVisualStyleBackColor = true;
            // 
            // grdPesquisar
            // 
            this.grdPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPesquisar.Location = new System.Drawing.Point(14, 58);
            this.grdPesquisar.Name = "grdPesquisar";
            this.grdPesquisar.Size = new System.Drawing.Size(529, 503);
            this.grdPesquisar.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtPesquisarNome
            // 
            this.txtPesquisarNome.Location = new System.Drawing.Point(14, 31);
            this.txtPesquisarNome.Name = "txtPesquisarNome";
            this.txtPesquisarNome.Size = new System.Drawing.Size(404, 20);
            this.txtPesquisarNome.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(434, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 35);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.label4);
            this.tabCadastro.Controls.Add(this.textBox1);
            this.tabCadastro.Controls.Add(this.btnNovo);
            this.tabCadastro.Controls.Add(this.label2);
            this.tabCadastro.Controls.Add(this.txtDataAluguel);
            this.tabCadastro.Controls.Add(this.btnExcluir);
            this.tabCadastro.Controls.Add(this.label1);
            this.tabCadastro.Controls.Add(this.txtPreco);
            this.tabCadastro.Controls.Add(this.btnSalvar);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(562, 581);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Principal";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(124, 106);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(109, 35);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data do aluguel:";
            // 
            // txtDataAluguel
            // 
            this.txtDataAluguel.Location = new System.Drawing.Point(78, 29);
            this.txtDataAluguel.MaxLength = 16;
            this.txtDataAluguel.Name = "txtDataAluguel";
            this.txtDataAluguel.Size = new System.Drawing.Size(71, 20);
            this.txtDataAluguel.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(239, 106);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 35);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(6, 29);
            this.txtPreco.MaxLength = 30;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(66, 20);
            this.txtPreco.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(9, 106);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 35);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data de devolução:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 29);
            this.textBox1.MaxLength = 16;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 11;
            // 
            // frmAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 643);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAluguel";
            this.Text = "frmAluguel";
            this.tabControl1.ResumeLayout(false);
            this.tabPesquisar.ResumeLayout(false);
            this.tabPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisar)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPesquisar;
        private System.Windows.Forms.DataGridView grdPesquisar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPesquisarNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataAluguel;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}