namespace LancamentosWindowsForms.VO
{
    partial class SubcategoriaLancamentoForm
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovoLancamento = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.clIdSubcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeSubcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(473, 345);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 26);
            this.btnSair.TabIndex = 24;
            this.btnSair.Text = "(ESC) Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(121, 345);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 26);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Alterar";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovoLancamento
            // 
            this.btnNovoLancamento.Location = new System.Drawing.Point(5, 345);
            this.btnNovoLancamento.Name = "btnNovoLancamento";
            this.btnNovoLancamento.Size = new System.Drawing.Size(110, 26);
            this.btnNovoLancamento.TabIndex = 22;
            this.btnNovoLancamento.Text = "Novo cadastro";
            this.btnNovoLancamento.UseVisualStyleBackColor = true;
            this.btnNovoLancamento.Click += new System.EventHandler(this.btnNovoLancamento_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIdSubcategoria,
            this.clNomeSubcategoria,
            this.clNomeCategoria,
            this.clIdCategoria});
            this.dgvPrincipal.Location = new System.Drawing.Point(5, 2);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(578, 337);
            this.dgvPrincipal.TabIndex = 21;
            // 
            // clIdSubcategoria
            // 
            this.clIdSubcategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clIdSubcategoria.DataPropertyName = "idSubcategoria";
            this.clIdSubcategoria.HeaderText = "Código";
            this.clIdSubcategoria.Name = "clIdSubcategoria";
            this.clIdSubcategoria.ReadOnly = true;
            this.clIdSubcategoria.Width = 65;
            // 
            // clNomeSubcategoria
            // 
            this.clNomeSubcategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNomeSubcategoria.DataPropertyName = "nomeSubcategoria";
            this.clNomeSubcategoria.HeaderText = "Descrição Subcategoria";
            this.clNomeSubcategoria.Name = "clNomeSubcategoria";
            this.clNomeSubcategoria.ReadOnly = true;
            // 
            // clNomeCategoria
            // 
            this.clNomeCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clNomeCategoria.DataPropertyName = "nomeCategoria";
            this.clNomeCategoria.HeaderText = "Categoria";
            this.clNomeCategoria.Name = "clNomeCategoria";
            this.clNomeCategoria.ReadOnly = true;
            this.clNomeCategoria.Width = 77;
            // 
            // clIdCategoria
            // 
            this.clIdCategoria.DataPropertyName = "idCategoria";
            this.clIdCategoria.HeaderText = "idCategoria";
            this.clIdCategoria.Name = "clIdCategoria";
            this.clIdCategoria.ReadOnly = true;
            this.clIdCategoria.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 26);
            this.button1.TabIndex = 25;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SubcategoriaLancamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 381);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovoLancamento);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubcategoriaLancamentoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubcategoriaLancamentoForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SubcategoriaLancamentoForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovoLancamento;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdSubcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeSubcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdCategoria;
    }
}