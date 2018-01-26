namespace LancamentosWindowsForms.VO
{
    partial class ProdutoDataGridForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Location = new System.Drawing.Point(7, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa por Código, Código EAN ou Descrição";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(6, 25);
            this.txtPesquisa.MaxLength = 30;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(465, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(477, 21);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 26);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clNomeProduto,
            this.clDepartamento});
            this.dgvProdutos.Location = new System.Drawing.Point(7, 82);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(573, 282);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.DoubleClick += new System.EventHandler(this.dgvProdutos_DoubleClick);
            this.dgvProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProdutos_KeyDown);
            // 
            // clCodigo
            // 
            this.clCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clCodigo.DataPropertyName = "id_produto";
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.ReadOnly = true;
            this.clCodigo.Width = 65;
            // 
            // clNomeProduto
            // 
            this.clNomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNomeProduto.DataPropertyName = "nome_produto";
            this.clNomeProduto.HeaderText = "Nome Produto";
            this.clNomeProduto.Name = "clNomeProduto";
            this.clNomeProduto.ReadOnly = true;
            // 
            // clDepartamento
            // 
            this.clDepartamento.DataPropertyName = "nome_departamento";
            this.clDepartamento.HeaderText = "Departamento";
            this.clDepartamento.Name = "clDepartamento";
            this.clDepartamento.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(299, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 26);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar (ESC)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(203, 370);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(90, 26);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // ProdutoDataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 408);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProdutoDataGridForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos Cadastrados";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProdutoDataGridForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDepartamento;
    }
}