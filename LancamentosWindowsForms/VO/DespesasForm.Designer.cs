namespace LancamentosWindowsForms.VO
{
    partial class DespesasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbEstabelecimento = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovoLancamento = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.clIdDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clParceiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEstabelecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategoriaLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSubCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estabelecimento";
            // 
            // cbbEstabelecimento
            // 
            this.cbbEstabelecimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstabelecimento.FormattingEnabled = true;
            this.cbbEstabelecimento.Location = new System.Drawing.Point(94, 19);
            this.cbbEstabelecimento.Name = "cbbEstabelecimento";
            this.cbbEstabelecimento.Size = new System.Drawing.Size(402, 21);
            this.cbbEstabelecimento.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.dtpDataFinal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDataInicial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(502, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 48);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período de Movimento";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(260, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(158, 19);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(96, 20);
            this.dtpDataFinal.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "á:";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(32, 19);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(96, 20);
            this.dtpDataInicial.TabIndex = 1;
            this.dtpDataInicial.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "De";
            // 
            // dgvDespesas
            // 
            this.dgvDespesas.AllowUserToAddRows = false;
            this.dgvDespesas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDespesas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDespesas.BackgroundColor = System.Drawing.Color.White;
            this.dgvDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIdDespesa,
            this.clDataMovimento,
            this.clDescricao,
            this.clParceiro,
            this.clValor,
            this.clEstabelecimento,
            this.clCategoriaLancamento,
            this.clSubCategoria});
            this.dgvDespesas.Location = new System.Drawing.Point(6, 55);
            this.dgvDespesas.MultiSelect = false;
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.Size = new System.Drawing.Size(847, 404);
            this.dgvDespesas.TabIndex = 11;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(742, 497);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 26);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "(ESC) Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(239, 497);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 26);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovoLancamento
            // 
            this.btnNovoLancamento.Location = new System.Drawing.Point(7, 497);
            this.btnNovoLancamento.Name = "btnNovoLancamento";
            this.btnNovoLancamento.Size = new System.Drawing.Size(110, 26);
            this.btnNovoLancamento.TabIndex = 12;
            this.btnNovoLancamento.Text = "Novo lançamento";
            this.btnNovoLancamento.UseVisualStyleBackColor = true;
            this.btnNovoLancamento.Click += new System.EventHandler(this.btnNovoLancamento_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(123, 497);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 26);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(632, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Valor total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTotal.Location = new System.Drawing.Point(719, 465);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(134, 27);
            this.txtTotal.TabIndex = 22;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // clIdDespesa
            // 
            this.clIdDespesa.DataPropertyName = "id_despesa";
            this.clIdDespesa.HeaderText = "Codigo";
            this.clIdDespesa.Name = "clIdDespesa";
            this.clIdDespesa.ReadOnly = true;
            this.clIdDespesa.Visible = false;
            // 
            // clDataMovimento
            // 
            this.clDataMovimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clDataMovimento.DataPropertyName = "data_movimento";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.clDataMovimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.clDataMovimento.HeaderText = "Data movimento";
            this.clDataMovimento.Name = "clDataMovimento";
            this.clDataMovimento.ReadOnly = true;
            // 
            // clDescricao
            // 
            this.clDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clDescricao.DataPropertyName = "descricao_despesa";
            this.clDescricao.HeaderText = "Descrição";
            this.clDescricao.Name = "clDescricao";
            this.clDescricao.ReadOnly = true;
            this.clDescricao.Width = 80;
            // 
            // clParceiro
            // 
            this.clParceiro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clParceiro.DataPropertyName = "nome_fornecedor";
            this.clParceiro.HeaderText = "Parceiro";
            this.clParceiro.Name = "clParceiro";
            this.clParceiro.ReadOnly = true;
            this.clParceiro.Width = 71;
            // 
            // clValor
            // 
            this.clValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValor.DataPropertyName = "valor";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.clValor.DefaultCellStyle = dataGridViewCellStyle3;
            this.clValor.HeaderText = "Valor";
            this.clValor.Name = "clValor";
            this.clValor.ReadOnly = true;
            this.clValor.Width = 56;
            // 
            // clEstabelecimento
            // 
            this.clEstabelecimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clEstabelecimento.DataPropertyName = "nome_estabelecimento";
            this.clEstabelecimento.HeaderText = "Estabelecimento";
            this.clEstabelecimento.Name = "clEstabelecimento";
            this.clEstabelecimento.ReadOnly = true;
            this.clEstabelecimento.Width = 110;
            // 
            // clCategoriaLancamento
            // 
            this.clCategoriaLancamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clCategoriaLancamento.DataPropertyName = "nome_categoria";
            this.clCategoriaLancamento.HeaderText = "Categoria lançamento";
            this.clCategoriaLancamento.Name = "clCategoriaLancamento";
            this.clCategoriaLancamento.ReadOnly = true;
            this.clCategoriaLancamento.Width = 123;
            // 
            // clSubCategoria
            // 
            this.clSubCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clSubCategoria.DataPropertyName = "nome_subcategoria";
            this.clSubCategoria.HeaderText = "Subcategoria lançamento";
            this.clSubCategoria.Name = "clSubCategoria";
            this.clSubCategoria.ReadOnly = true;
            this.clSubCategoria.Width = 140;
            // 
            // DespesasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 535);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovoLancamento);
            this.Controls.Add(this.dgvDespesas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbEstabelecimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DespesasForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas";
            this.Load += new System.EventHandler(this.DespesasForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DespesasForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbEstabelecimento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovoLancamento;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataMovimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clParceiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEstabelecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategoriaLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSubCategoria;
    }
}