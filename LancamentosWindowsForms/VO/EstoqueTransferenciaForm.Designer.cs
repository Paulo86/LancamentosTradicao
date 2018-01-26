namespace LancamentosWindowsForms.VO
{
    partial class EstoqueTransferenciaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpMovimentoFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpMovimentoInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbEstabelecimentoOrigem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbEstabelecimentoDestino = new System.Windows.Forms.ComboBox();
            this.dgvVencidos = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovoLancamento = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.clIdTransferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEstabelecimentoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-111, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-111, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estabelecimento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.dtpMovimentoFinal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpMovimentoInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(402, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período de Entrada";
            // 
            // dtpMovimentoFinal
            // 
            this.dtpMovimentoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMovimentoFinal.Location = new System.Drawing.Point(158, 19);
            this.dtpMovimentoFinal.Name = "dtpMovimentoFinal";
            this.dtpMovimentoFinal.Size = new System.Drawing.Size(96, 20);
            this.dtpMovimentoFinal.TabIndex = 3;
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
            // dtpMovimentoInicial
            // 
            this.dtpMovimentoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMovimentoInicial.Location = new System.Drawing.Point(32, 19);
            this.dtpMovimentoInicial.Name = "dtpMovimentoInicial";
            this.dtpMovimentoInicial.Size = new System.Drawing.Size(96, 20);
            this.dtpMovimentoInicial.TabIndex = 1;
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
            // cbbEstabelecimentoOrigem
            // 
            this.cbbEstabelecimentoOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstabelecimentoOrigem.FormattingEnabled = true;
            this.cbbEstabelecimentoOrigem.Location = new System.Drawing.Point(133, 12);
            this.cbbEstabelecimentoOrigem.Name = "cbbEstabelecimentoOrigem";
            this.cbbEstabelecimentoOrigem.Size = new System.Drawing.Size(263, 21);
            this.cbbEstabelecimentoOrigem.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Estabelecimento Origem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Estabelecimento Destino";
            // 
            // cbbEstabelecimentoDestino
            // 
            this.cbbEstabelecimentoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstabelecimentoDestino.FormattingEnabled = true;
            this.cbbEstabelecimentoDestino.Location = new System.Drawing.Point(133, 39);
            this.cbbEstabelecimentoDestino.Name = "cbbEstabelecimentoDestino";
            this.cbbEstabelecimentoDestino.Size = new System.Drawing.Size(263, 21);
            this.cbbEstabelecimentoDestino.TabIndex = 3;
            // 
            // dgvVencidos
            // 
            this.dgvVencidos.AllowDrop = true;
            this.dgvVencidos.AllowUserToAddRows = false;
            this.dgvVencidos.AllowUserToDeleteRows = false;
            this.dgvVencidos.AllowUserToResizeColumns = false;
            this.dgvVencidos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvVencidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVencidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIdTransferencia,
            this.clDataMovimento,
            this.clOrigem,
            this.clEstabelecimentoDestino,
            this.clNomeProduto,
            this.clQuantidade,
            this.clCustoProduto,
            this.clValorTotal});
            this.dgvVencidos.Location = new System.Drawing.Point(8, 79);
            this.dgvVencidos.MultiSelect = false;
            this.dgvVencidos.Name = "dgvVencidos";
            this.dgvVencidos.ReadOnly = true;
            this.dgvVencidos.Size = new System.Drawing.Size(740, 318);
            this.dgvVencidos.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(124, 403);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 26);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovoLancamento
            // 
            this.btnNovoLancamento.Location = new System.Drawing.Point(8, 403);
            this.btnNovoLancamento.Name = "btnNovoLancamento";
            this.btnNovoLancamento.Size = new System.Drawing.Size(110, 26);
            this.btnNovoLancamento.TabIndex = 6;
            this.btnNovoLancamento.Text = "Novo lançamento";
            this.btnNovoLancamento.UseVisualStyleBackColor = true;
            this.btnNovoLancamento.Click += new System.EventHandler(this.btnNovoLancamento_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(638, 403);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 26);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "(ESC) Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(260, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // clIdTransferencia
            // 
            this.clIdTransferencia.DataPropertyName = "id_transferencia";
            this.clIdTransferencia.HeaderText = "idTransferencia";
            this.clIdTransferencia.Name = "clIdTransferencia";
            this.clIdTransferencia.ReadOnly = true;
            this.clIdTransferencia.Visible = false;
            // 
            // clDataMovimento
            // 
            this.clDataMovimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clDataMovimento.DataPropertyName = "data_movimento";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.clDataMovimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.clDataMovimento.HeaderText = "Data da Transferencia";
            this.clDataMovimento.Name = "clDataMovimento";
            this.clDataMovimento.ReadOnly = true;
            this.clDataMovimento.Width = 126;
            // 
            // clOrigem
            // 
            this.clOrigem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clOrigem.DataPropertyName = "estabelecimento_origem";
            this.clOrigem.HeaderText = "Estabelecimento Origem";
            this.clOrigem.Name = "clOrigem";
            this.clOrigem.ReadOnly = true;
            this.clOrigem.Width = 133;
            // 
            // clEstabelecimentoDestino
            // 
            this.clEstabelecimentoDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clEstabelecimentoDestino.DataPropertyName = "estabelecimento_destino";
            this.clEstabelecimentoDestino.HeaderText = "Estabelecimento Destino";
            this.clEstabelecimentoDestino.Name = "clEstabelecimentoDestino";
            this.clEstabelecimentoDestino.ReadOnly = true;
            this.clEstabelecimentoDestino.Width = 136;
            // 
            // clNomeProduto
            // 
            this.clNomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clNomeProduto.DataPropertyName = "nome_produto";
            this.clNomeProduto.HeaderText = "Nome Produto";
            this.clNomeProduto.Name = "clNomeProduto";
            this.clNomeProduto.ReadOnly = true;
            this.clNomeProduto.Width = 92;
            // 
            // clQuantidade
            // 
            this.clQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clQuantidade.DataPropertyName = "quantidade";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.clQuantidade.DefaultCellStyle = dataGridViewCellStyle3;
            this.clQuantidade.HeaderText = "Quantidade";
            this.clQuantidade.Name = "clQuantidade";
            this.clQuantidade.ReadOnly = true;
            this.clQuantidade.Width = 87;
            // 
            // clCustoProduto
            // 
            this.clCustoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clCustoProduto.DataPropertyName = "custo_sem_imposto";
            dataGridViewCellStyle4.Format = "C2";
            this.clCustoProduto.DefaultCellStyle = dataGridViewCellStyle4;
            this.clCustoProduto.HeaderText = "Preço Custo";
            this.clCustoProduto.Name = "clCustoProduto";
            this.clCustoProduto.ReadOnly = true;
            this.clCustoProduto.Width = 83;
            // 
            // clValorTotal
            // 
            this.clValorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValorTotal.DataPropertyName = "valor_total";
            dataGridViewCellStyle5.Format = "C2";
            this.clValorTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.clValorTotal.HeaderText = "Valor Total R$";
            this.clValorTotal.Name = "clValorTotal";
            this.clValorTotal.ReadOnly = true;
            this.clValorTotal.Width = 79;
            // 
            // EstoqueTransferenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 452);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovoLancamento);
            this.Controls.Add(this.dgvVencidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbEstabelecimentoDestino);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbEstabelecimentoOrigem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EstoqueTransferenciaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tranferencias";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EstoqueTransferenciaForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpMovimentoFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpMovimentoInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbEstabelecimentoOrigem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbEstabelecimentoDestino;
        public System.Windows.Forms.DataGridView dgvVencidos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovoLancamento;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdTransferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataMovimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEstabelecimentoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorTotal;
    }
}