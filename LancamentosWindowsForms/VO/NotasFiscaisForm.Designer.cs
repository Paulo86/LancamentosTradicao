namespace LancamentosWindowsForms.VO
{
    partial class NotasFiscaisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEntradaFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEntradaInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbFornecedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbEstabelecimento = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpEmissaoFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtpEmissaoInicial = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovoLancamento = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.dgvVencidos = new System.Windows.Forms.DataGridView();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.clCodigoFornecedorAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdLancamentoAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdEstabelecimentoAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeEstabelecimentoAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeFornecedorAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataEntradaAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataVencimentoAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumeroDocumentoAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlValorTotalAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorTotalProdutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEntradaFinal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpEntradaInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(376, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 48);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período de Entrada";
            // 
            // dtpEntradaFinal
            // 
            this.dtpEntradaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntradaFinal.Location = new System.Drawing.Point(158, 19);
            this.dtpEntradaFinal.Name = "dtpEntradaFinal";
            this.dtpEntradaFinal.Size = new System.Drawing.Size(96, 20);
            this.dtpEntradaFinal.TabIndex = 3;
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
            // dtpEntradaInicial
            // 
            this.dtpEntradaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntradaInicial.Location = new System.Drawing.Point(32, 19);
            this.dtpEntradaInicial.Name = "dtpEntradaInicial";
            this.dtpEntradaInicial.Size = new System.Drawing.Size(96, 20);
            this.dtpEntradaInicial.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fornecedor";
            // 
            // cbbFornecedor
            // 
            this.cbbFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbFornecedor.FormattingEnabled = true;
            this.cbbFornecedor.Location = new System.Drawing.Point(105, 39);
            this.cbbFornecedor.Name = "cbbFornecedor";
            this.cbbFornecedor.Size = new System.Drawing.Size(263, 21);
            this.cbbFornecedor.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Estabelecimento";
            // 
            // cbbEstabelecimento
            // 
            this.cbbEstabelecimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstabelecimento.FormattingEnabled = true;
            this.cbbEstabelecimento.Location = new System.Drawing.Point(105, 12);
            this.cbbEstabelecimento.Name = "cbbEstabelecimento";
            this.cbbEstabelecimento.Size = new System.Drawing.Size(263, 21);
            this.cbbEstabelecimento.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpEmissaoFinal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.dtpEmissaoInicial);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(644, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 48);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Período de  Emissao";
            // 
            // dtpEmissaoFinal
            // 
            this.dtpEmissaoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissaoFinal.Location = new System.Drawing.Point(158, 19);
            this.dtpEmissaoFinal.Name = "dtpEmissaoFinal";
            this.dtpEmissaoFinal.Size = new System.Drawing.Size(96, 20);
            this.dtpEmissaoFinal.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "á:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(260, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtpEmissaoInicial
            // 
            this.dtpEmissaoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissaoInicial.Location = new System.Drawing.Point(32, 19);
            this.dtpEmissaoInicial.Name = "dtpEmissaoInicial";
            this.dtpEmissaoInicial.Size = new System.Drawing.Size(96, 20);
            this.dtpEmissaoInicial.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "De";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(360, 471);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 26);
            this.btnSair.TabIndex = 22;
            this.btnSair.Text = "(ESC) Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(128, 471);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 26);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovoLancamento
            // 
            this.btnNovoLancamento.Location = new System.Drawing.Point(12, 471);
            this.btnNovoLancamento.Name = "btnNovoLancamento";
            this.btnNovoLancamento.Size = new System.Drawing.Size(110, 26);
            this.btnNovoLancamento.TabIndex = 19;
            this.btnNovoLancamento.Text = "Novo lançamento";
            this.btnNovoLancamento.UseVisualStyleBackColor = true;
            this.btnNovoLancamento.Click += new System.EventHandler(this.btnNovoLancamento_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(674, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Valor total das compras";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.Color.White;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtValorTotal.Location = new System.Drawing.Point(856, 471);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(134, 26);
            this.txtValorTotal.TabIndex = 24;
            // 
            // dgvVencidos
            // 
            this.dgvVencidos.AllowDrop = true;
            this.dgvVencidos.AllowUserToAddRows = false;
            this.dgvVencidos.AllowUserToDeleteRows = false;
            this.dgvVencidos.AllowUserToResizeColumns = false;
            this.dgvVencidos.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvVencidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvVencidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigoFornecedorAberto,
            this.clIdLancamentoAberto,
            this.clIdEstabelecimentoAberto,
            this.clNomeEstabelecimentoAberto,
            this.clNomeFornecedorAberto,
            this.clDataEntradaAberto,
            this.clDataVencimentoAberto,
            this.clNumeroDocumentoAberto,
            this.vlValorTotalAberto,
            this.clValorTotalProdutos});
            this.dgvVencidos.Location = new System.Drawing.Point(6, 76);
            this.dgvVencidos.MultiSelect = false;
            this.dgvVencidos.Name = "dgvVencidos";
            this.dgvVencidos.Size = new System.Drawing.Size(984, 389);
            this.dgvVencidos.TabIndex = 25;
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(244, 471);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(110, 26);
            this.btnProdutos.TabIndex = 26;
            this.btnProdutos.Text = "Visualizar Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // clCodigoFornecedorAberto
            // 
            this.clCodigoFornecedorAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clCodigoFornecedorAberto.DataPropertyName = "id_fornecedor";
            this.clCodigoFornecedorAberto.HeaderText = "Código Fornecedor";
            this.clCodigoFornecedorAberto.Name = "clCodigoFornecedorAberto";
            this.clCodigoFornecedorAberto.ReadOnly = true;
            this.clCodigoFornecedorAberto.Visible = false;
            this.clCodigoFornecedorAberto.Width = 122;
            // 
            // clIdLancamentoAberto
            // 
            this.clIdLancamentoAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clIdLancamentoAberto.DataPropertyName = "id_nota_fiscal";
            this.clIdLancamentoAberto.HeaderText = "Código lançamento";
            this.clIdLancamentoAberto.Name = "clIdLancamentoAberto";
            this.clIdLancamentoAberto.ReadOnly = true;
            this.clIdLancamentoAberto.Visible = false;
            this.clIdLancamentoAberto.Width = 123;
            // 
            // clIdEstabelecimentoAberto
            // 
            this.clIdEstabelecimentoAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clIdEstabelecimentoAberto.DataPropertyName = "id_estabelecimento";
            this.clIdEstabelecimentoAberto.HeaderText = "Codigo Estabelecimento";
            this.clIdEstabelecimentoAberto.Name = "clIdEstabelecimentoAberto";
            this.clIdEstabelecimentoAberto.ReadOnly = true;
            this.clIdEstabelecimentoAberto.Visible = false;
            this.clIdEstabelecimentoAberto.Width = 146;
            // 
            // clNomeEstabelecimentoAberto
            // 
            this.clNomeEstabelecimentoAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clNomeEstabelecimentoAberto.DataPropertyName = "nome_estabelecimento";
            this.clNomeEstabelecimentoAberto.HeaderText = "Nome Estabelecimento";
            this.clNomeEstabelecimentoAberto.Name = "clNomeEstabelecimentoAberto";
            this.clNomeEstabelecimentoAberto.ReadOnly = true;
            this.clNomeEstabelecimentoAberto.Width = 129;
            // 
            // clNomeFornecedorAberto
            // 
            this.clNomeFornecedorAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNomeFornecedorAberto.DataPropertyName = "nome_fornecedor";
            this.clNomeFornecedorAberto.HeaderText = "Nome Fornecedor";
            this.clNomeFornecedorAberto.Name = "clNomeFornecedorAberto";
            this.clNomeFornecedorAberto.ReadOnly = true;
            // 
            // clDataEntradaAberto
            // 
            this.clDataEntradaAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clDataEntradaAberto.DataPropertyName = "data_entrada";
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            this.clDataEntradaAberto.DefaultCellStyle = dataGridViewCellStyle12;
            this.clDataEntradaAberto.HeaderText = "Data Entrada";
            this.clDataEntradaAberto.Name = "clDataEntradaAberto";
            this.clDataEntradaAberto.ReadOnly = true;
            this.clDataEntradaAberto.Width = 87;
            // 
            // clDataVencimentoAberto
            // 
            this.clDataVencimentoAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clDataVencimentoAberto.DataPropertyName = "data_emissao";
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            this.clDataVencimentoAberto.DefaultCellStyle = dataGridViewCellStyle13;
            this.clDataVencimentoAberto.HeaderText = "Data Emissão";
            this.clDataVencimentoAberto.Name = "clDataVencimentoAberto";
            this.clDataVencimentoAberto.ReadOnly = true;
            this.clDataVencimentoAberto.Width = 89;
            // 
            // clNumeroDocumentoAberto
            // 
            this.clNumeroDocumentoAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clNumeroDocumentoAberto.DataPropertyName = "numero_nota_fiscal";
            this.clNumeroDocumentoAberto.HeaderText = "Numero da Nota";
            this.clNumeroDocumentoAberto.Name = "clNumeroDocumentoAberto";
            this.clNumeroDocumentoAberto.ReadOnly = true;
            this.clNumeroDocumentoAberto.Width = 80;
            // 
            // vlValorTotalAberto
            // 
            this.vlValorTotalAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vlValorTotalAberto.DataPropertyName = "valor_total_nota_fiscal";
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.vlValorTotalAberto.DefaultCellStyle = dataGridViewCellStyle14;
            this.vlValorTotalAberto.HeaderText = "Valor Total Nota";
            this.vlValorTotalAberto.Name = "vlValorTotalAberto";
            this.vlValorTotalAberto.ReadOnly = true;
            // 
            // clValorTotalProdutos
            // 
            this.clValorTotalProdutos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValorTotalProdutos.DataPropertyName = "total_produtos";
            dataGridViewCellStyle15.Format = "N2";
            this.clValorTotalProdutos.DefaultCellStyle = dataGridViewCellStyle15;
            this.clValorTotalProdutos.HeaderText = "Valor total produtos";
            this.clValorTotalProdutos.Name = "clValorTotalProdutos";
            this.clValorTotalProdutos.ReadOnly = true;
            this.clValorTotalProdutos.Width = 113;
            // 
            // NotasFiscaisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 520);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.dgvVencidos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbEstabelecimento);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovoLancamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotasFiscaisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotasFiscaisForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NotasFiscaisForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpEntradaFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEntradaInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbEstabelecimento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpEmissaoFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker dtpEmissaoInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovoLancamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorTotal;
        public System.Windows.Forms.DataGridView dgvVencidos;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigoFornecedorAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdLancamentoAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdEstabelecimentoAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeEstabelecimentoAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeFornecedorAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataEntradaAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataVencimentoAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumeroDocumentoAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlValorTotalAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorTotalProdutos;
    }
}