namespace LancamentosWindowsForms.VO
{
    partial class CategoriaLancamentoForm
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovoLancamento = new System.Windows.Forms.Button();
            this.dgvCategoriaLancamento = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriaLancamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(356, 345);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 26);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "(ESC) Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(124, 345);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 26);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovoLancamento
            // 
            this.btnNovoLancamento.Location = new System.Drawing.Point(8, 345);
            this.btnNovoLancamento.Name = "btnNovoLancamento";
            this.btnNovoLancamento.Size = new System.Drawing.Size(110, 26);
            this.btnNovoLancamento.TabIndex = 17;
            this.btnNovoLancamento.Text = "Novo cadastro";
            this.btnNovoLancamento.UseVisualStyleBackColor = true;
            this.btnNovoLancamento.Click += new System.EventHandler(this.btnNovoLancamento_Click);
            // 
            // dgvCategoriaLancamento
            // 
            this.dgvCategoriaLancamento.AllowUserToAddRows = false;
            this.dgvCategoriaLancamento.AllowUserToDeleteRows = false;
            this.dgvCategoriaLancamento.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCategoriaLancamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategoriaLancamento.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategoriaLancamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriaLancamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clNome});
            this.dgvCategoriaLancamento.Location = new System.Drawing.Point(8, 2);
            this.dgvCategoriaLancamento.Name = "dgvCategoriaLancamento";
            this.dgvCategoriaLancamento.ReadOnly = true;
            this.dgvCategoriaLancamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoriaLancamento.Size = new System.Drawing.Size(458, 337);
            this.dgvCategoriaLancamento.TabIndex = 16;
            // 
            // clCodigo
            // 
            this.clCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clCodigo.DataPropertyName = "IdCategoria";
            this.clCodigo.HeaderText = "Código categoria";
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.ReadOnly = true;
            this.clCodigo.Width = 103;
            // 
            // clNome
            // 
            this.clNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNome.DataPropertyName = "NomeCategoria";
            this.clNome.HeaderText = "Descrição categoria";
            this.clNome.Name = "clNome";
            this.clNome.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(240, 345);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 26);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // CategoriaLancamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 385);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovoLancamento);
            this.Controls.Add(this.dgvCategoriaLancamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoriaLancamentoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriaLancamentoForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CategoriaLancamentoForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriaLancamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovoLancamento;
        private System.Windows.Forms.DataGridView dgvCategoriaLancamento;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNome;
    }
}