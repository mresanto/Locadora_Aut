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
            this.grdPesquisarAluguel = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtPesquisarDataAluguel = new System.Windows.Forms.TextBox();
            this.btnPesquisarAluguel = new System.Windows.Forms.Button();
            this.tabCadastroAluguel = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataDevAluguel = new System.Windows.Forms.TextBox();
            this.btnNovoAluguel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataAluguel = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoAluguel = new System.Windows.Forms.TextBox();
            this.btnSalvarAluguel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVeiculo = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisarAluguel)).BeginInit();
            this.tabCadastroAluguel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPesquisar);
            this.tabControl1.Controls.Add(this.tabCadastroAluguel);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 607);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPesquisar
            // 
            this.tabPesquisar.Controls.Add(this.grdPesquisarAluguel);
            this.tabPesquisar.Controls.Add(this.lblNome);
            this.tabPesquisar.Controls.Add(this.txtPesquisarDataAluguel);
            this.tabPesquisar.Controls.Add(this.btnPesquisarAluguel);
            this.tabPesquisar.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisar.Name = "tabPesquisar";
            this.tabPesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisar.Size = new System.Drawing.Size(562, 581);
            this.tabPesquisar.TabIndex = 1;
            this.tabPesquisar.Text = "Pesquisar";
            this.tabPesquisar.UseVisualStyleBackColor = true;
            // 
            // grdPesquisarAluguel
            // 
            this.grdPesquisarAluguel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPesquisarAluguel.Location = new System.Drawing.Point(14, 58);
            this.grdPesquisarAluguel.Name = "grdPesquisarAluguel";
            this.grdPesquisarAluguel.Size = new System.Drawing.Size(529, 503);
            this.grdPesquisarAluguel.TabIndex = 3;
            this.grdPesquisarAluguel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPesquisar_CellContentClick);
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
            // txtPesquisarDataAluguel
            // 
            this.txtPesquisarDataAluguel.Location = new System.Drawing.Point(14, 31);
            this.txtPesquisarDataAluguel.Name = "txtPesquisarDataAluguel";
            this.txtPesquisarDataAluguel.Size = new System.Drawing.Size(404, 20);
            this.txtPesquisarDataAluguel.TabIndex = 1;
            // 
            // btnPesquisarAluguel
            // 
            this.btnPesquisarAluguel.Location = new System.Drawing.Point(434, 16);
            this.btnPesquisarAluguel.Name = "btnPesquisarAluguel";
            this.btnPesquisarAluguel.Size = new System.Drawing.Size(109, 35);
            this.btnPesquisarAluguel.TabIndex = 0;
            this.btnPesquisarAluguel.Text = "Pesquisar";
            this.btnPesquisarAluguel.UseVisualStyleBackColor = true;
            this.btnPesquisarAluguel.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tabCadastroAluguel
            // 
            this.tabCadastroAluguel.Controls.Add(this.label5);
            this.tabCadastroAluguel.Controls.Add(this.cmbVeiculo);
            this.tabCadastroAluguel.Controls.Add(this.label3);
            this.tabCadastroAluguel.Controls.Add(this.cmbCliente);
            this.tabCadastroAluguel.Controls.Add(this.label4);
            this.tabCadastroAluguel.Controls.Add(this.txtDataDevAluguel);
            this.tabCadastroAluguel.Controls.Add(this.btnNovoAluguel);
            this.tabCadastroAluguel.Controls.Add(this.label2);
            this.tabCadastroAluguel.Controls.Add(this.txtDataAluguel);
            this.tabCadastroAluguel.Controls.Add(this.btnExcluir);
            this.tabCadastroAluguel.Controls.Add(this.label1);
            this.tabCadastroAluguel.Controls.Add(this.txtPrecoAluguel);
            this.tabCadastroAluguel.Controls.Add(this.btnSalvarAluguel);
            this.tabCadastroAluguel.Location = new System.Drawing.Point(4, 22);
            this.tabCadastroAluguel.Name = "tabCadastroAluguel";
            this.tabCadastroAluguel.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastroAluguel.Size = new System.Drawing.Size(562, 581);
            this.tabCadastroAluguel.TabIndex = 0;
            this.tabCadastroAluguel.Text = "Principal";
            this.tabCadastroAluguel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(6, 27);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(257, 21);
            this.cmbCliente.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data de devolução:";
            // 
            // txtDataDevAluguel
            // 
            this.txtDataDevAluguel.Location = new System.Drawing.Point(162, 67);
            this.txtDataDevAluguel.MaxLength = 16;
            this.txtDataDevAluguel.Name = "txtDataDevAluguel";
            this.txtDataDevAluguel.Size = new System.Drawing.Size(71, 20);
            this.txtDataDevAluguel.TabIndex = 11;
            // 
            // btnNovoAluguel
            // 
            this.btnNovoAluguel.Location = new System.Drawing.Point(124, 106);
            this.btnNovoAluguel.Name = "btnNovoAluguel";
            this.btnNovoAluguel.Size = new System.Drawing.Size(109, 35);
            this.btnNovoAluguel.TabIndex = 5;
            this.btnNovoAluguel.Text = "Novo";
            this.btnNovoAluguel.UseVisualStyleBackColor = true;
            this.btnNovoAluguel.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data do aluguel:";
            // 
            // txtDataAluguel
            // 
            this.txtDataAluguel.Location = new System.Drawing.Point(78, 67);
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
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Preço:";
            // 
            // txtPrecoAluguel
            // 
            this.txtPrecoAluguel.Location = new System.Drawing.Point(6, 67);
            this.txtPrecoAluguel.MaxLength = 30;
            this.txtPrecoAluguel.Name = "txtPrecoAluguel";
            this.txtPrecoAluguel.Size = new System.Drawing.Size(66, 20);
            this.txtPrecoAluguel.TabIndex = 1;
            // 
            // btnSalvarAluguel
            // 
            this.btnSalvarAluguel.Location = new System.Drawing.Point(9, 106);
            this.btnSalvarAluguel.Name = "btnSalvarAluguel";
            this.btnSalvarAluguel.Size = new System.Drawing.Size(109, 35);
            this.btnSalvarAluguel.TabIndex = 4;
            this.btnSalvarAluguel.Text = "Salvar";
            this.btnSalvarAluguel.UseVisualStyleBackColor = true;
            this.btnSalvarAluguel.Click += new System.EventHandler(this.btnSalvarAluguel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Veiculo:";
            // 
            // cmbVeiculo
            // 
            this.cmbVeiculo.FormattingEnabled = true;
            this.cmbVeiculo.Location = new System.Drawing.Point(269, 27);
            this.cmbVeiculo.Name = "cmbVeiculo";
            this.cmbVeiculo.Size = new System.Drawing.Size(257, 21);
            this.cmbVeiculo.TabIndex = 15;
            // 
            // frmAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 643);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAluguel";
            this.Text = "frmAluguel";
            this.Load += new System.EventHandler(this.frmAluguel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPesquisar.ResumeLayout(false);
            this.tabPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisarAluguel)).EndInit();
            this.tabCadastroAluguel.ResumeLayout(false);
            this.tabCadastroAluguel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPesquisar;
        private System.Windows.Forms.DataGridView grdPesquisarAluguel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPesquisarDataAluguel;
        private System.Windows.Forms.Button btnPesquisarAluguel;
        private System.Windows.Forms.TabPage tabCadastroAluguel;
        private System.Windows.Forms.Button btnNovoAluguel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataAluguel;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecoAluguel;
        private System.Windows.Forms.Button btnSalvarAluguel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataDevAluguel;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVeiculo;
    }
}