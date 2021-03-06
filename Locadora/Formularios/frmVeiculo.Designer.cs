namespace Locadora.Formularios
{
    partial class frmVeiculo
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPesquisarVei = new System.Windows.Forms.TabPage();
            this.grdPesquisarVei = new System.Windows.Forms.DataGridView();
            this.lblNomeVei = new System.Windows.Forms.Label();
            this.txtPesquisarNomeVei = new System.Windows.Forms.TextBox();
            this.btnPesquisarVei = new System.Windows.Forms.Button();
            this.tabCadastroVei = new System.Windows.Forms.TabPage();
            this.cbDis = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovoVei = new System.Windows.Forms.Button();
            this.label3Vei = new System.Windows.Forms.Label();
            this.txtInfoVei = new System.Windows.Forms.TextBox();
            this.label2Vei = new System.Windows.Forms.Label();
            this.txtCorVei = new System.Windows.Forms.TextBox();
            this.btnExcluirVei = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeVei = new System.Windows.Forms.TextBox();
            this.btnSalvarVei = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.tabPesquisarVei.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisarVei)).BeginInit();
            this.tabCadastroVei.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPesquisarVei);
            this.tabControl2.Controls.Add(this.tabCadastroVei);
            this.tabControl2.Location = new System.Drawing.Point(21, 40);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(570, 607);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPesquisarVei
            // 
            this.tabPesquisarVei.Controls.Add(this.grdPesquisarVei);
            this.tabPesquisarVei.Controls.Add(this.lblNomeVei);
            this.tabPesquisarVei.Controls.Add(this.txtPesquisarNomeVei);
            this.tabPesquisarVei.Controls.Add(this.btnPesquisarVei);
            this.tabPesquisarVei.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisarVei.Name = "tabPesquisarVei";
            this.tabPesquisarVei.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisarVei.Size = new System.Drawing.Size(562, 581);
            this.tabPesquisarVei.TabIndex = 1;
            this.tabPesquisarVei.Text = "Pesquisar";
            this.tabPesquisarVei.UseVisualStyleBackColor = true;
            // 
            // grdPesquisarVei
            // 
            this.grdPesquisarVei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPesquisarVei.Location = new System.Drawing.Point(14, 58);
            this.grdPesquisarVei.Name = "grdPesquisarVei";
            this.grdPesquisarVei.Size = new System.Drawing.Size(529, 503);
            this.grdPesquisarVei.TabIndex = 3;
            this.grdPesquisarVei.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPesquisar_CellContentClick);
            // 
            // lblNomeVei
            // 
            this.lblNomeVei.AutoSize = true;
            this.lblNomeVei.Location = new System.Drawing.Point(14, 15);
            this.lblNomeVei.Name = "lblNomeVei";
            this.lblNomeVei.Size = new System.Drawing.Size(38, 13);
            this.lblNomeVei.TabIndex = 2;
            this.lblNomeVei.Text = "Nome:";
            // 
            // txtPesquisarNomeVei
            // 
            this.txtPesquisarNomeVei.Location = new System.Drawing.Point(14, 31);
            this.txtPesquisarNomeVei.Name = "txtPesquisarNomeVei";
            this.txtPesquisarNomeVei.Size = new System.Drawing.Size(404, 20);
            this.txtPesquisarNomeVei.TabIndex = 1;
            // 
            // btnPesquisarVei
            // 
            this.btnPesquisarVei.Location = new System.Drawing.Point(434, 16);
            this.btnPesquisarVei.Name = "btnPesquisarVei";
            this.btnPesquisarVei.Size = new System.Drawing.Size(109, 35);
            this.btnPesquisarVei.TabIndex = 0;
            this.btnPesquisarVei.Text = "Pesquisar";
            this.btnPesquisarVei.UseVisualStyleBackColor = true;
            this.btnPesquisarVei.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tabCadastroVei
            // 
            this.tabCadastroVei.Controls.Add(this.cbDis);
            this.tabCadastroVei.Controls.Add(this.label2);
            this.tabCadastroVei.Controls.Add(this.btnNovoVei);
            this.tabCadastroVei.Controls.Add(this.label3Vei);
            this.tabCadastroVei.Controls.Add(this.txtInfoVei);
            this.tabCadastroVei.Controls.Add(this.label2Vei);
            this.tabCadastroVei.Controls.Add(this.txtCorVei);
            this.tabCadastroVei.Controls.Add(this.btnExcluirVei);
            this.tabCadastroVei.Controls.Add(this.label1);
            this.tabCadastroVei.Controls.Add(this.txtNomeVei);
            this.tabCadastroVei.Controls.Add(this.btnSalvarVei);
            this.tabCadastroVei.Location = new System.Drawing.Point(4, 22);
            this.tabCadastroVei.Name = "tabCadastroVei";
            this.tabCadastroVei.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastroVei.Size = new System.Drawing.Size(562, 581);
            this.tabCadastroVei.TabIndex = 0;
            this.tabCadastroVei.Text = "Principal";
            this.tabCadastroVei.UseVisualStyleBackColor = true;
            this.tabCadastroVei.Click += new System.EventHandler(this.tabCadastroVei_Click);
            // 
            // cbDis
            // 
            this.cbDis.AutoSize = true;
            this.cbDis.Location = new System.Drawing.Point(194, 73);
            this.cbDis.Name = "cbDis";
            this.cbDis.Size = new System.Drawing.Size(15, 14);
            this.cbDis.TabIndex = 14;
            this.cbDis.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Disponibilidade";
            // 
            // btnNovoVei
            // 
            this.btnNovoVei.Location = new System.Drawing.Point(124, 106);
            this.btnNovoVei.Name = "btnNovoVei";
            this.btnNovoVei.Size = new System.Drawing.Size(109, 35);
            this.btnNovoVei.TabIndex = 5;
            this.btnNovoVei.Text = "Novo";
            this.btnNovoVei.UseVisualStyleBackColor = true;
            this.btnNovoVei.Click += new System.EventHandler(this.btnNovoVei_Click);
            // 
            // label3Vei
            // 
            this.label3Vei.AutoSize = true;
            this.label3Vei.Location = new System.Drawing.Point(6, 164);
            this.label3Vei.Name = "label3Vei";
            this.label3Vei.Size = new System.Drawing.Size(25, 13);
            this.label3Vei.TabIndex = 10;
            this.label3Vei.Text = "Info";
            // 
            // txtInfoVei
            // 
            this.txtInfoVei.Location = new System.Drawing.Point(9, 190);
            this.txtInfoVei.MaxLength = 300;
            this.txtInfoVei.Multiline = true;
            this.txtInfoVei.Name = "txtInfoVei";
            this.txtInfoVei.Size = new System.Drawing.Size(519, 279);
            this.txtInfoVei.TabIndex = 3;
            // 
            // label2Vei
            // 
            this.label2Vei.AutoSize = true;
            this.label2Vei.Location = new System.Drawing.Point(6, 54);
            this.label2Vei.Name = "label2Vei";
            this.label2Vei.Size = new System.Drawing.Size(33, 13);
            this.label2Vei.TabIndex = 8;
            this.label2Vei.Text = "COR:";
            // 
            // txtCorVei
            // 
            this.txtCorVei.Location = new System.Drawing.Point(6, 70);
            this.txtCorVei.MaxLength = 16;
            this.txtCorVei.Name = "txtCorVei";
            this.txtCorVei.Size = new System.Drawing.Size(179, 20);
            this.txtCorVei.TabIndex = 2;
            // 
            // btnExcluirVei
            // 
            this.btnExcluirVei.Location = new System.Drawing.Point(239, 106);
            this.btnExcluirVei.Name = "btnExcluirVei";
            this.btnExcluirVei.Size = new System.Drawing.Size(109, 35);
            this.btnExcluirVei.TabIndex = 6;
            this.btnExcluirVei.Text = "Excluir";
            this.btnExcluirVei.UseVisualStyleBackColor = true;
            this.btnExcluirVei.Click += new System.EventHandler(this.btnExcluirVei_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // txtNomeVei
            // 
            this.txtNomeVei.Location = new System.Drawing.Point(6, 29);
            this.txtNomeVei.MaxLength = 30;
            this.txtNomeVei.Name = "txtNomeVei";
            this.txtNomeVei.Size = new System.Drawing.Size(550, 20);
            this.txtNomeVei.TabIndex = 1;
            // 
            // btnSalvarVei
            // 
            this.btnSalvarVei.Location = new System.Drawing.Point(9, 106);
            this.btnSalvarVei.Name = "btnSalvarVei";
            this.btnSalvarVei.Size = new System.Drawing.Size(109, 35);
            this.btnSalvarVei.TabIndex = 4;
            this.btnSalvarVei.Text = "Salvar";
            this.btnSalvarVei.UseVisualStyleBackColor = true;
            this.btnSalvarVei.Click += new System.EventHandler(this.btnSalvarVei_Click);
            // 
            // frmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 680);
            this.Controls.Add(this.tabControl2);
            this.Name = "frmVeiculo";
            this.Text = "frmVeiculo";
            this.Load += new System.EventHandler(this.frmVeiculo_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPesquisarVei.ResumeLayout(false);
            this.tabPesquisarVei.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisarVei)).EndInit();
            this.tabCadastroVei.ResumeLayout(false);
            this.tabCadastroVei.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPesquisarVei;
        private System.Windows.Forms.DataGridView grdPesquisarVei;
        private System.Windows.Forms.Label lblNomeVei;
        private System.Windows.Forms.TextBox txtPesquisarNomeVei;
        private System.Windows.Forms.Button btnPesquisarVei;
        private System.Windows.Forms.TabPage tabCadastroVei;
        private System.Windows.Forms.Button btnNovoVei;
        private System.Windows.Forms.Label label3Vei;
        private System.Windows.Forms.TextBox txtInfoVei;
        private System.Windows.Forms.Label label2Vei;
        private System.Windows.Forms.TextBox txtCorVei;
        private System.Windows.Forms.Button btnExcluirVei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeVei;
        private System.Windows.Forms.Button btnSalvarVei;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbDis;
    }
}