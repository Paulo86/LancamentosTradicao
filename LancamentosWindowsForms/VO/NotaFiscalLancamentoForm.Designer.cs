namespace LancamentosWindowsForms.VO
{
    partial class CorpoNotaFiscalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbFornecedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbEstabelecimento = new System.Windows.Forms.ComboBox();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroNotaFiscal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalNotaFiscal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalIpi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalDespesas = new System.Windows.Forms.TextBox();
            this.txtTotalIcms = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ConfirmarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorTotalDosProdutos = new System.Windows.Forms.TextBox();
            this.ExcluirProdutoButton = new System.Windows.Forms.Button();
            this.AlterarProdutoButton = new System.Windows.Forms.Button();
            this.NovoProdutoButton = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoSemImposto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoComImposto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fornecedor";
            // 
            // cbbFornecedor
            // 
            this.cbbFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbFornecedor.FormattingEnabled = true;
            this.cbbFornecedor.Location = new System.Drawing.Point(100, 39);
            this.cbbFornecedor.Name = "cbbFornecedor";
            this.cbbFornecedor.Size = new System.Drawing.Size(249, 21);
            this.cbbFornecedor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estabelecimento";
            // 
            // cbbEstabelecimento
            // 
            this.cbbEstabelecimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstabelecimento.FormattingEnabled = true;
            this.cbbEstabelecimento.Location = new System.Drawing.Point(100, 12);
            this.cbbEstabelecimento.Name = "cbbEstabelecimento";
            this.cbbEstabelecimento.Size = new System.Drawing.Size(291, 21);
            this.cbbEstabelecimento.TabIndex = 1;
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(410, 19);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(95, 20);
            this.dtpDataEntrada.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data Entrada";
            // 
            // dtpDataEmissao
            // 
            this.dtpDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmissao.Location = new System.Drawing.Point(232, 19);
            this.dtpDataEmissao.Name = "dtpDataEmissao";
            this.dtpDataEmissao.Size = new System.Drawing.Size(95, 20);
            this.dtpDataEmissao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Emissão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Num NF";
            // 
            // txtNumeroNotaFiscal
            // 
            this.txtNumeroNotaFiscal.Location = new System.Drawing.Point(64, 19);
            this.txtNumeroNotaFiscal.Name = "txtNumeroNotaFiscal";
            this.txtNumeroNotaFiscal.Size = new System.Drawing.Size(86, 20);
            this.txtNumeroNotaFiscal.TabIndex = 1;
            this.txtNumeroNotaFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroNotaFiscal_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalNotaFiscal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTotalIpi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTotalDespesas);
            this.groupBox2.Controls.Add(this.txtTotalIcms);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 65);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores Totais da Nota Fiscal";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtTotalNotaFiscal
            // 
            this.txtTotalNotaFiscal.Location = new System.Drawing.Point(73, 21);
            this.txtTotalNotaFiscal.Name = "txtTotalNotaFiscal";
            this.txtTotalNotaFiscal.Size = new System.Drawing.Size(114, 20);
            this.txtTotalNotaFiscal.TabIndex = 1;
            this.txtTotalNotaFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalNotaFiscal_KeyPress);
            this.txtTotalNotaFiscal.Leave += new System.EventHandler(this.txtTotalNotaFiscal_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total da NF";
            // 
            // txtTotalIpi
            // 
            this.txtTotalIpi.Location = new System.Drawing.Point(542, 21);
            this.txtTotalIpi.Name = "txtTotalIpi";
            this.txtTotalIpi.Size = new System.Drawing.Size(114, 20);
            this.txtTotalIpi.TabIndex = 5;
            this.txtTotalIpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalIpi_KeyPress);
            this.txtTotalIpi.Leave += new System.EventHandler(this.txtTotalIpi_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(682, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Outras Despesas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(474, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Total do IPI";
            // 
            // txtTotalDespesas
            // 
            this.txtTotalDespesas.Location = new System.Drawing.Point(776, 21);
            this.txtTotalDespesas.Name = "txtTotalDespesas";
            this.txtTotalDespesas.Size = new System.Drawing.Size(114, 20);
            this.txtTotalDespesas.TabIndex = 7;
            this.txtTotalDespesas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalDespesas_KeyPress);
            this.txtTotalDespesas.Leave += new System.EventHandler(this.txtTotalDespesas_Leave);
            // 
            // txtTotalIcms
            // 
            this.txtTotalIcms.Location = new System.Drawing.Point(329, 21);
            this.txtTotalIcms.Name = "txtTotalIcms";
            this.txtTotalIcms.Size = new System.Drawing.Size(114, 20);
            this.txtTotalIcms.TabIndex = 3;
            this.txtTotalIcms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalIcms_KeyPress);
            this.txtTotalIcms.Leave += new System.EventHandler(this.txtTotalIcms_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total do ICMS ST";
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.Location = new System.Drawing.Point(12, 562);
            this.ConfirmarButton.Name = "ConfirmarButton";
            this.ConfirmarButton.Size = new System.Drawing.Size(110, 26);
            this.ConfirmarButton.TabIndex = 7;
            this.ConfirmarButton.Text = "(F3) Confirmar";
            this.ConfirmarButton.UseVisualStyleBackColor = true;
            this.ConfirmarButton.Click += new System.EventHandler(this.ConfirmarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumeroNotaFiscal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpDataEntrada);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDataEmissao);
            this.groupBox1.Location = new System.Drawing.Point(397, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Nota Fiscal";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtValorTotalDosProdutos);
            this.groupBox3.Controls.Add(this.ExcluirProdutoButton);
            this.groupBox3.Controls.Add(this.AlterarProdutoButton);
            this.groupBox3.Controls.Add(this.NovoProdutoButton);
            this.groupBox3.Controls.Add(this.dgvProdutos);
            this.groupBox3.Location = new System.Drawing.Point(12, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(900, 392);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produtos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Valor total dos Produtos";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtValorTotalDosProdutos
            // 
            this.txtValorTotalDosProdutos.BackColor = System.Drawing.Color.White;
            this.txtValorTotalDosProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalDosProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtValorTotalDosProdutos.Location = new System.Drawing.Point(188, 351);
            this.txtValorTotalDosProdutos.Name = "txtValorTotalDosProdutos";
            this.txtValorTotalDosProdutos.ReadOnly = true;
            this.txtValorTotalDosProdutos.Size = new System.Drawing.Size(134, 26);
            this.txtValorTotalDosProdutos.TabIndex = 2;
            // 
            // ExcluirProdutoButton
            // 
            this.ExcluirProdutoButton.Location = new System.Drawing.Point(784, 351);
            this.ExcluirProdutoButton.Name = "ExcluirProdutoButton";
            this.ExcluirProdutoButton.Size = new System.Drawing.Size(110, 26);
            this.ExcluirProdutoButton.TabIndex = 5;
            this.ExcluirProdutoButton.Text = "Excluir";
            this.ExcluirProdutoButton.UseVisualStyleBackColor = true;
            this.ExcluirProdutoButton.Click += new System.EventHandler(this.ExcluirProdutoButton_Click);
            // 
            // AlterarProdutoButton
            // 
            this.AlterarProdutoButton.Location = new System.Drawing.Point(668, 351);
            this.AlterarProdutoButton.Name = "AlterarProdutoButton";
            this.AlterarProdutoButton.Size = new System.Drawing.Size(110, 26);
            this.AlterarProdutoButton.TabIndex = 4;
            this.AlterarProdutoButton.Text = "Alterar";
            this.AlterarProdutoButton.UseVisualStyleBackColor = true;
            this.AlterarProdutoButton.Click += new System.EventHandler(this.AlterarProdutoButton_Click);
            // 
            // NovoProdutoButton
            // 
            this.NovoProdutoButton.Location = new System.Drawing.Point(552, 351);
            this.NovoProdutoButton.Name = "NovoProdutoButton";
            this.NovoProdutoButton.Size = new System.Drawing.Size(110, 26);
            this.NovoProdutoButton.TabIndex = 3;
            this.NovoProdutoButton.Text = "Novo Produto";
            this.NovoProdutoButton.UseVisualStyleBackColor = true;
            this.NovoProdutoButton.Click += new System.EventHandler(this.NovoProdutoButton_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clNomeProduto,
            this.clQuantidade,
            this.clUnidade,
            this.clValorUnitario,
            this.clSt,
            this.clIPI,
            this.clValorDesconto,
            this.clValorTotal,
            this.clCustoSemImposto,
            this.clCustoComImposto});
            this.dgvProdutos.Location = new System.Drawing.Point(6, 19);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(888, 326);
            this.dgvProdutos.TabIndex = 0;
            // 
            // clCodigo
            // 
            this.clCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clCodigo.DataPropertyName = "idProduto";
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.ReadOnly = true;
            this.clCodigo.Width = 65;
            // 
            // clNomeProduto
            // 
            this.clNomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clNomeProduto.DataPropertyName = "nomeProduto";
            this.clNomeProduto.HeaderText = "Nome Produto";
            this.clNomeProduto.Name = "clNomeProduto";
            this.clNomeProduto.ReadOnly = true;
            this.clNomeProduto.Width = 92;
            // 
            // clQuantidade
            // 
            this.clQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clQuantidade.DataPropertyName = "quantidade";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.clQuantidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.clQuantidade.HeaderText = "Quantidade";
            this.clQuantidade.Name = "clQuantidade";
            this.clQuantidade.ReadOnly = true;
            this.clQuantidade.Width = 87;
            // 
            // clUnidade
            // 
            this.clUnidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clUnidade.DataPropertyName = "quantidadeEmbalagem";
            this.clUnidade.HeaderText = "Quantidade Embalagem";
            this.clUnidade.Name = "clUnidade";
            this.clUnidade.ReadOnly = true;
            this.clUnidade.Width = 132;
            // 
            // clValorUnitario
            // 
            this.clValorUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValorUnitario.DataPropertyName = "valorUnitario";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.clValorUnitario.DefaultCellStyle = dataGridViewCellStyle3;
            this.clValorUnitario.HeaderText = "Valor Unitáiro";
            this.clValorUnitario.Name = "clValorUnitario";
            this.clValorUnitario.ReadOnly = true;
            this.clValorUnitario.Width = 87;
            // 
            // clSt
            // 
            this.clSt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clSt.DataPropertyName = "valorIcmsSt";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.clSt.DefaultCellStyle = dataGridViewCellStyle4;
            this.clSt.HeaderText = "Valor ICMS ST";
            this.clSt.Name = "clSt";
            this.clSt.ReadOnly = true;
            this.clSt.Width = 81;
            // 
            // clIPI
            // 
            this.clIPI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clIPI.DataPropertyName = "valorIpi";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.clIPI.DefaultCellStyle = dataGridViewCellStyle5;
            this.clIPI.HeaderText = "Valor IPI";
            this.clIPI.Name = "clIPI";
            this.clIPI.ReadOnly = true;
            this.clIPI.Width = 67;
            // 
            // clValorDesconto
            // 
            this.clValorDesconto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValorDesconto.DataPropertyName = "valorDesconto";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.clValorDesconto.DefaultCellStyle = dataGridViewCellStyle6;
            this.clValorDesconto.HeaderText = "Valor Desconto";
            this.clValorDesconto.Name = "clValorDesconto";
            this.clValorDesconto.ReadOnly = true;
            this.clValorDesconto.Width = 96;
            // 
            // clValorTotal
            // 
            this.clValorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValorTotal.DataPropertyName = "valorTotal";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.clValorTotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.clValorTotal.HeaderText = "ValorTotal";
            this.clValorTotal.Name = "clValorTotal";
            this.clValorTotal.ReadOnly = true;
            this.clValorTotal.Width = 80;
            // 
            // clCustoSemImposto
            // 
            this.clCustoSemImposto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clCustoSemImposto.DataPropertyName = "CustoSemImposto";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.clCustoSemImposto.DefaultCellStyle = dataGridViewCellStyle8;
            this.clCustoSemImposto.HeaderText = "Custo Sem Imposto";
            this.clCustoSemImposto.Name = "clCustoSemImposto";
            this.clCustoSemImposto.ReadOnly = true;
            this.clCustoSemImposto.Width = 113;
            // 
            // clCustoComImposto
            // 
            this.clCustoComImposto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clCustoComImposto.DataPropertyName = "CustoComImposto";
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.clCustoComImposto.DefaultCellStyle = dataGridViewCellStyle9;
            this.clCustoComImposto.HeaderText = "Custo Com Imposto";
            this.clCustoComImposto.Name = "clCustoComImposto";
            this.clCustoComImposto.ReadOnly = true;
            this.clCustoComImposto.Width = 113;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(128, 562);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 26);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "(ESC) Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Location = new System.Drawing.Point(355, 39);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(36, 23);
            this.btnFornecedor.TabIndex = 15;
            this.btnFornecedor.Text = "...";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // CorpoNotaFiscalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 600);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConfirmarButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbEstabelecimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "CorpoNotaFiscalForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CorpoNotaFiscalForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CorpoNotaFiscalForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CorpoNotaFiscalForm_KeyPress);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbEstabelecimento;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataEmissao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeroNotaFiscal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalNotaFiscal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalIpi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalDespesas;
        private System.Windows.Forms.TextBox txtTotalIcms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ConfirmarButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ExcluirProdutoButton;
        private System.Windows.Forms.Button AlterarProdutoButton;
        private System.Windows.Forms.Button NovoProdutoButton;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoSemImposto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoComImposto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorTotalDosProdutos;
        private System.Windows.Forms.Button btnFornecedor;
    }
}