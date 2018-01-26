namespace LancamentosWindowsForms.VO
{
    partial class BoletosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpVencido = new System.Windows.Forms.TabPage();
            this.dgvVencidos = new System.Windows.Forms.DataGridView();
            this.tpAVencer = new System.Windows.Forms.TabPage();
            this.dgvAVencer = new System.Windows.Forms.DataGridView();
            this.tpQuitados = new System.Windows.Forms.TabPage();
            this.dgvQuitados = new System.Windows.Forms.DataGridView();
            this.cbbEstabelecimento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbFornecedor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEntradaFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEntradaInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovoLancamento = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLiquidar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpVencimentoFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpVencimentoInicial = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLiquidados = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAVencer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalAberto = new System.Windows.Forms.TextBox();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorTotalLiquidado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataLiquidacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSelecionarAberto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clCodigoFornecedorAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdLancamentoAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeEstabelecimentoAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeFornecedorAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataEntradaAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataVencimentoAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlValorTotalAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumeroDocumentoAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdEstabelecimentoAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatusAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSelecionarAVencer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clIdFornecedorAVencer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdLancamentoAVencer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeEstabelecimentoAVencer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeFornecedorAVencer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataEntradaAVencer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataVencimentoAVencer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVAlorTotalAVencer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumeroDocumentoAVencer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdEstabelecimentoAVencer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatusAVencer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tpVencido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).BeginInit();
            this.tpAVencer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAVencer)).BeginInit();
            this.tpQuitados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuitados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpVencido);
            this.tabControl1.Controls.Add(this.tpAVencer);
            this.tabControl1.Controls.Add(this.tpQuitados);
            this.tabControl1.Location = new System.Drawing.Point(3, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 421);
            this.tabControl1.TabIndex = 6;
            // 
            // tpVencido
            // 
            this.tpVencido.Controls.Add(this.dgvVencidos);
            this.tpVencido.Location = new System.Drawing.Point(4, 22);
            this.tpVencido.Name = "tpVencido";
            this.tpVencido.Padding = new System.Windows.Forms.Padding(3);
            this.tpVencido.Size = new System.Drawing.Size(978, 395);
            this.tpVencido.TabIndex = 0;
            this.tpVencido.Text = "Vencidos/Abertos";
            this.tpVencido.UseVisualStyleBackColor = true;
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
            this.clSelecionarAberto,
            this.clCodigoFornecedorAberto,
            this.clIdLancamentoAberto,
            this.clNomeEstabelecimentoAberto,
            this.clNomeFornecedorAberto,
            this.clDataEntradaAberto,
            this.clDataVencimentoAberto,
            this.vlValorTotalAberto,
            this.clNumeroDocumentoAberto,
            this.clIdEstabelecimentoAberto,
            this.clStatusAberto});
            this.dgvVencidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVencidos.Location = new System.Drawing.Point(3, 3);
            this.dgvVencidos.MultiSelect = false;
            this.dgvVencidos.Name = "dgvVencidos";
            this.dgvVencidos.Size = new System.Drawing.Size(972, 389);
            this.dgvVencidos.TabIndex = 0;
            this.dgvVencidos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVencidos_ColumnHeaderMouseClick);
            // 
            // tpAVencer
            // 
            this.tpAVencer.Controls.Add(this.dgvAVencer);
            this.tpAVencer.Location = new System.Drawing.Point(4, 22);
            this.tpAVencer.Name = "tpAVencer";
            this.tpAVencer.Padding = new System.Windows.Forms.Padding(3);
            this.tpAVencer.Size = new System.Drawing.Size(978, 395);
            this.tpAVencer.TabIndex = 2;
            this.tpAVencer.Text = "Á vencer";
            this.tpAVencer.UseVisualStyleBackColor = true;
            // 
            // dgvAVencer
            // 
            this.dgvAVencer.AllowUserToAddRows = false;
            this.dgvAVencer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAVencer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAVencer.BackgroundColor = System.Drawing.Color.White;
            this.dgvAVencer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAVencer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSelecionarAVencer,
            this.clIdFornecedorAVencer,
            this.clIdLancamentoAVencer,
            this.clNomeEstabelecimentoAVencer,
            this.clNomeFornecedorAVencer,
            this.clDataEntradaAVencer,
            this.clDataVencimentoAVencer,
            this.clVAlorTotalAVencer,
            this.clNumeroDocumentoAVencer,
            this.clIdEstabelecimentoAVencer,
            this.clStatusAVencer});
            this.dgvAVencer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAVencer.Location = new System.Drawing.Point(3, 3);
            this.dgvAVencer.Name = "dgvAVencer";
            this.dgvAVencer.Size = new System.Drawing.Size(972, 389);
            this.dgvAVencer.TabIndex = 1;
            // 
            // tpQuitados
            // 
            this.tpQuitados.Controls.Add(this.dgvQuitados);
            this.tpQuitados.Location = new System.Drawing.Point(4, 22);
            this.tpQuitados.Name = "tpQuitados";
            this.tpQuitados.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuitados.Size = new System.Drawing.Size(978, 395);
            this.tpQuitados.TabIndex = 3;
            this.tpQuitados.Text = "Líquidados";
            this.tpQuitados.UseVisualStyleBackColor = true;
            // 
            // dgvQuitados
            // 
            this.dgvQuitados.AllowUserToAddRows = false;
            this.dgvQuitados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvQuitados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvQuitados.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuitados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.clValorTotalLiquidado,
            this.dataGridViewTextBoxColumn17,
            this.clValorPago,
            this.clDataLiquidacao,
            this.dataGridViewTextBoxColumn18,
            this.clStatus});
            this.dgvQuitados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuitados.Location = new System.Drawing.Point(3, 3);
            this.dgvQuitados.Name = "dgvQuitados";
            this.dgvQuitados.ReadOnly = true;
            this.dgvQuitados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuitados.Size = new System.Drawing.Size(972, 389);
            this.dgvQuitados.TabIndex = 1;
            // 
            // cbbEstabelecimento
            // 
            this.cbbEstabelecimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstabelecimento.FormattingEnabled = true;
            this.cbbEstabelecimento.Location = new System.Drawing.Point(106, 12);
            this.cbbEstabelecimento.Name = "cbbEstabelecimento";
            this.cbbEstabelecimento.Size = new System.Drawing.Size(263, 21);
            this.cbbEstabelecimento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estabelecimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
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
            this.cbbFornecedor.Location = new System.Drawing.Point(106, 39);
            this.cbbFornecedor.Name = "cbbFornecedor";
            this.cbbFornecedor.Size = new System.Drawing.Size(263, 21);
            this.cbbFornecedor.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEntradaFinal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpEntradaInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(375, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 48);
            this.groupBox1.TabIndex = 4;
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
            // btnNovoLancamento
            // 
            this.btnNovoLancamento.Location = new System.Drawing.Point(4, 571);
            this.btnNovoLancamento.Name = "btnNovoLancamento";
            this.btnNovoLancamento.Size = new System.Drawing.Size(110, 26);
            this.btnNovoLancamento.TabIndex = 7;
            this.btnNovoLancamento.Text = "Novo lançamento";
            this.btnNovoLancamento.UseVisualStyleBackColor = true;
            this.btnNovoLancamento.Click += new System.EventHandler(this.btnNovoLancamento_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(120, 571);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 26);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(876, 571);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 26);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "(ESC) Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLiquidar
            // 
            this.btnLiquidar.Location = new System.Drawing.Point(236, 571);
            this.btnLiquidar.Name = "btnLiquidar";
            this.btnLiquidar.Size = new System.Drawing.Size(110, 26);
            this.btnLiquidar.TabIndex = 9;
            this.btnLiquidar.Text = "Liquidar";
            this.btnLiquidar.UseVisualStyleBackColor = true;
            this.btnLiquidar.Click += new System.EventHandler(this.btnLiquidar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpVencimentoFinal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.dtpVencimentoInicial);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(643, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 48);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Período de  Vencimento";
            // 
            // dtpVencimentoFinal
            // 
            this.dtpVencimentoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimentoFinal.Location = new System.Drawing.Point(158, 19);
            this.dtpVencimentoFinal.Name = "dtpVencimentoFinal";
            this.dtpVencimentoFinal.Size = new System.Drawing.Size(96, 20);
            this.dtpVencimentoFinal.TabIndex = 3;
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
            // dtpVencimentoInicial
            // 
            this.dtpVencimentoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimentoInicial.Location = new System.Drawing.Point(32, 19);
            this.dtpVencimentoInicial.Name = "dtpVencimentoInicial";
            this.dtpVencimentoInicial.Size = new System.Drawing.Size(96, 20);
            this.dtpVencimentoInicial.TabIndex = 1;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtLiquidados);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtAVencer);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtTotalAberto);
            this.groupBox3.Location = new System.Drawing.Point(3, 514);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(980, 51);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valores totais";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(749, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Liquidados";
            // 
            // txtLiquidados
            // 
            this.txtLiquidados.BackColor = System.Drawing.Color.White;
            this.txtLiquidados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiquidados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtLiquidados.Location = new System.Drawing.Point(841, 15);
            this.txtLiquidados.Name = "txtLiquidados";
            this.txtLiquidados.ReadOnly = true;
            this.txtLiquidados.Size = new System.Drawing.Size(134, 26);
            this.txtLiquidados.TabIndex = 23;
            this.txtLiquidados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLiquidados_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(415, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Á vencer";
            // 
            // txtAVencer
            // 
            this.txtAVencer.BackColor = System.Drawing.Color.White;
            this.txtAVencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAVencer.ForeColor = System.Drawing.Color.Green;
            this.txtAVencer.Location = new System.Drawing.Point(492, 15);
            this.txtAVencer.Name = "txtAVencer";
            this.txtAVencer.ReadOnly = true;
            this.txtAVencer.Size = new System.Drawing.Size(134, 26);
            this.txtAVencer.TabIndex = 21;
            this.txtAVencer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAVencer_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Vencidos em abertos";
            // 
            // txtTotalAberto
            // 
            this.txtTotalAberto.BackColor = System.Drawing.Color.White;
            this.txtTotalAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAberto.ForeColor = System.Drawing.Color.Red;
            this.txtTotalAberto.Location = new System.Drawing.Point(170, 15);
            this.txtTotalAberto.Name = "txtTotalAberto";
            this.txtTotalAberto.ReadOnly = true;
            this.txtTotalAberto.Size = new System.Drawing.Size(134, 26);
            this.txtTotalAberto.TabIndex = 19;
            this.txtTotalAberto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalAberto_KeyPress);
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Sel";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn2.Width = 47;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id_fornecedor";
            this.dataGridViewTextBoxColumn10.HeaderText = "Código Fornecedor";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 122;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "id_lancamento";
            this.dataGridViewTextBoxColumn11.HeaderText = "Código lançamento";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 123;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "nome_estabelecimento";
            this.dataGridViewTextBoxColumn12.HeaderText = "Nome Estabelecimento";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 129;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "nome_fornecedor";
            this.dataGridViewTextBoxColumn13.HeaderText = "Nome Fornecedor";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 107;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "data_entrada";
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn14.HeaderText = "Data Entrada";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 87;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "data_vencimento";
            dataGridViewCellStyle11.Format = "d";
            dataGridViewCellStyle11.NullValue = null;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn15.HeaderText = "Data Vencimento";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 105;
            // 
            // clValorTotalLiquidado
            // 
            this.clValorTotalLiquidado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValorTotalLiquidado.DataPropertyName = "valor_total";
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.clValorTotalLiquidado.DefaultCellStyle = dataGridViewCellStyle12;
            this.clValorTotalLiquidado.HeaderText = "Valor do Título";
            this.clValorTotalLiquidado.Name = "clValorTotalLiquidado";
            this.clValorTotalLiquidado.ReadOnly = true;
            this.clValorTotalLiquidado.Width = 94;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "numero_documento";
            this.dataGridViewTextBoxColumn17.HeaderText = "Numero Documento";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 116;
            // 
            // clValorPago
            // 
            this.clValorPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValorPago.DataPropertyName = "valor_liquidado";
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.clValorPago.DefaultCellStyle = dataGridViewCellStyle13;
            this.clValorPago.HeaderText = "Valor Liquidado";
            this.clValorPago.Name = "clValorPago";
            this.clValorPago.ReadOnly = true;
            this.clValorPago.Width = 96;
            // 
            // clDataLiquidacao
            // 
            this.clDataLiquidacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clDataLiquidacao.DataPropertyName = "data_liquidacao";
            dataGridViewCellStyle14.Format = "d";
            dataGridViewCellStyle14.NullValue = null;
            this.clDataLiquidacao.DefaultCellStyle = dataGridViewCellStyle14;
            this.clDataLiquidacao.HeaderText = "Data Liquidação";
            this.clDataLiquidacao.Name = "clDataLiquidacao";
            this.clDataLiquidacao.ReadOnly = true;
            this.clDataLiquidacao.Width = 101;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "id_estabelecimento";
            this.dataGridViewTextBoxColumn18.HeaderText = "Codigo Estabelecimento";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            this.dataGridViewTextBoxColumn18.Width = 133;
            // 
            // clStatus
            // 
            this.clStatus.DataPropertyName = "status";
            this.clStatus.HeaderText = "Situação";
            this.clStatus.Name = "clStatus";
            this.clStatus.ReadOnly = true;
            // 
            // clSelecionarAberto
            // 
            this.clSelecionarAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clSelecionarAberto.HeaderText = "Sel";
            this.clSelecionarAberto.Name = "clSelecionarAberto";
            this.clSelecionarAberto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clSelecionarAberto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clSelecionarAberto.Width = 47;
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
            this.clIdLancamentoAberto.DataPropertyName = "id_lancamento";
            this.clIdLancamentoAberto.HeaderText = "Código lançamento";
            this.clIdLancamentoAberto.Name = "clIdLancamentoAberto";
            this.clIdLancamentoAberto.ReadOnly = true;
            this.clIdLancamentoAberto.Visible = false;
            this.clIdLancamentoAberto.Width = 123;
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
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.clDataEntradaAberto.DefaultCellStyle = dataGridViewCellStyle2;
            this.clDataEntradaAberto.HeaderText = "Data Entrada";
            this.clDataEntradaAberto.Name = "clDataEntradaAberto";
            this.clDataEntradaAberto.ReadOnly = true;
            this.clDataEntradaAberto.Width = 87;
            // 
            // clDataVencimentoAberto
            // 
            this.clDataVencimentoAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clDataVencimentoAberto.DataPropertyName = "data_vencimento";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.clDataVencimentoAberto.DefaultCellStyle = dataGridViewCellStyle3;
            this.clDataVencimentoAberto.HeaderText = "Data Vencimento";
            this.clDataVencimentoAberto.Name = "clDataVencimentoAberto";
            this.clDataVencimentoAberto.ReadOnly = true;
            this.clDataVencimentoAberto.Width = 105;
            // 
            // vlValorTotalAberto
            // 
            this.vlValorTotalAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vlValorTotalAberto.DataPropertyName = "valor_total";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.vlValorTotalAberto.DefaultCellStyle = dataGridViewCellStyle4;
            this.vlValorTotalAberto.HeaderText = "Valor do Título";
            this.vlValorTotalAberto.Name = "vlValorTotalAberto";
            this.vlValorTotalAberto.ReadOnly = true;
            this.vlValorTotalAberto.Width = 94;
            // 
            // clNumeroDocumentoAberto
            // 
            this.clNumeroDocumentoAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clNumeroDocumentoAberto.DataPropertyName = "numero_documento";
            this.clNumeroDocumentoAberto.HeaderText = "Numero Documento";
            this.clNumeroDocumentoAberto.Name = "clNumeroDocumentoAberto";
            this.clNumeroDocumentoAberto.ReadOnly = true;
            this.clNumeroDocumentoAberto.Width = 116;
            // 
            // clIdEstabelecimentoAberto
            // 
            this.clIdEstabelecimentoAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clIdEstabelecimentoAberto.DataPropertyName = "id_estabelecimento";
            this.clIdEstabelecimentoAberto.HeaderText = "Codigo Estabelecimento";
            this.clIdEstabelecimentoAberto.Name = "clIdEstabelecimentoAberto";
            this.clIdEstabelecimentoAberto.ReadOnly = true;
            this.clIdEstabelecimentoAberto.Visible = false;
            this.clIdEstabelecimentoAberto.Width = 133;
            // 
            // clStatusAberto
            // 
            this.clStatusAberto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clStatusAberto.DataPropertyName = "Status";
            this.clStatusAberto.HeaderText = "Situação";
            this.clStatusAberto.Name = "clStatusAberto";
            this.clStatusAberto.ReadOnly = true;
            this.clStatusAberto.Width = 74;
            // 
            // clSelecionarAVencer
            // 
            this.clSelecionarAVencer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clSelecionarAVencer.Frozen = true;
            this.clSelecionarAVencer.HeaderText = "Sel";
            this.clSelecionarAVencer.Name = "clSelecionarAVencer";
            this.clSelecionarAVencer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clSelecionarAVencer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clSelecionarAVencer.Width = 47;
            // 
            // clIdFornecedorAVencer
            // 
            this.clIdFornecedorAVencer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clIdFornecedorAVencer.DataPropertyName = "id_fornecedor";
            this.clIdFornecedorAVencer.HeaderText = "Código Fornecedor";
            this.clIdFornecedorAVencer.Name = "clIdFornecedorAVencer";
            this.clIdFornecedorAVencer.ReadOnly = true;
            this.clIdFornecedorAVencer.Visible = false;
            this.clIdFornecedorAVencer.Width = 122;
            // 
            // clIdLancamentoAVencer
            // 
            this.clIdLancamentoAVencer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clIdLancamentoAVencer.DataPropertyName = "id_lancamento";
            this.clIdLancamentoAVencer.HeaderText = "Código lançamento";
            this.clIdLancamentoAVencer.Name = "clIdLancamentoAVencer";
            this.clIdLancamentoAVencer.ReadOnly = true;
            this.clIdLancamentoAVencer.Visible = false;
            this.clIdLancamentoAVencer.Width = 123;
            // 
            // clNomeEstabelecimentoAVencer
            // 
            this.clNomeEstabelecimentoAVencer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clNomeEstabelecimentoAVencer.DataPropertyName = "nome_estabelecimento";
            this.clNomeEstabelecimentoAVencer.HeaderText = "Nome Estabelecimento";
            this.clNomeEstabelecimentoAVencer.Name = "clNomeEstabelecimentoAVencer";
            this.clNomeEstabelecimentoAVencer.ReadOnly = true;
            this.clNomeEstabelecimentoAVencer.Width = 129;
            // 
            // clNomeFornecedorAVencer
            // 
            this.clNomeFornecedorAVencer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNomeFornecedorAVencer.DataPropertyName = "nome_fornecedor";
            this.clNomeFornecedorAVencer.HeaderText = "Nome Fornecedor";
            this.clNomeFornecedorAVencer.Name = "clNomeFornecedorAVencer";
            this.clNomeFornecedorAVencer.ReadOnly = true;
            // 
            // clDataEntradaAVencer
            // 
            this.clDataEntradaAVencer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clDataEntradaAVencer.DataPropertyName = "data_entrada";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.clDataEntradaAVencer.DefaultCellStyle = dataGridViewCellStyle6;
            this.clDataEntradaAVencer.HeaderText = "Data Entrada";
            this.clDataEntradaAVencer.Name = "clDataEntradaAVencer";
            this.clDataEntradaAVencer.ReadOnly = true;
            this.clDataEntradaAVencer.Width = 87;
            // 
            // clDataVencimentoAVencer
            // 
            this.clDataVencimentoAVencer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clDataVencimentoAVencer.DataPropertyName = "data_vencimento";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.clDataVencimentoAVencer.DefaultCellStyle = dataGridViewCellStyle7;
            this.clDataVencimentoAVencer.HeaderText = "Data Vencimento";
            this.clDataVencimentoAVencer.Name = "clDataVencimentoAVencer";
            this.clDataVencimentoAVencer.ReadOnly = true;
            this.clDataVencimentoAVencer.Width = 105;
            // 
            // clVAlorTotalAVencer
            // 
            this.clVAlorTotalAVencer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clVAlorTotalAVencer.DataPropertyName = "valor_total";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.clVAlorTotalAVencer.DefaultCellStyle = dataGridViewCellStyle8;
            this.clVAlorTotalAVencer.HeaderText = "Valor do Título";
            this.clVAlorTotalAVencer.Name = "clVAlorTotalAVencer";
            this.clVAlorTotalAVencer.ReadOnly = true;
            this.clVAlorTotalAVencer.Width = 94;
            // 
            // clNumeroDocumentoAVencer
            // 
            this.clNumeroDocumentoAVencer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clNumeroDocumentoAVencer.DataPropertyName = "numero_documento";
            this.clNumeroDocumentoAVencer.HeaderText = "Numero Documento";
            this.clNumeroDocumentoAVencer.Name = "clNumeroDocumentoAVencer";
            this.clNumeroDocumentoAVencer.ReadOnly = true;
            this.clNumeroDocumentoAVencer.Width = 116;
            // 
            // clIdEstabelecimentoAVencer
            // 
            this.clIdEstabelecimentoAVencer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clIdEstabelecimentoAVencer.DataPropertyName = "id_estabelecimento";
            this.clIdEstabelecimentoAVencer.HeaderText = "Codigo Estabelecimento";
            this.clIdEstabelecimentoAVencer.Name = "clIdEstabelecimentoAVencer";
            this.clIdEstabelecimentoAVencer.ReadOnly = true;
            this.clIdEstabelecimentoAVencer.Visible = false;
            this.clIdEstabelecimentoAVencer.Width = 133;
            // 
            // clStatusAVencer
            // 
            this.clStatusAVencer.DataPropertyName = "status";
            this.clStatusAVencer.HeaderText = "Situação";
            this.clStatusAVencer.Name = "clStatusAVencer";
            this.clStatusAVencer.ReadOnly = true;
            // 
            // BoletosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 609);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLiquidar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovoLancamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbEstabelecimento);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BoletosForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boletos lançados";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrincipalForm_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.tpVencido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).EndInit();
            this.tpAVencer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAVencer)).EndInit();
            this.tpQuitados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuitados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpVencido;
        private System.Windows.Forms.ComboBox cbbEstabelecimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbFornecedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker dtpEntradaFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEntradaInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovoLancamento;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TabPage tpAVencer;
        private System.Windows.Forms.TabPage tpQuitados;
        private System.Windows.Forms.Button btnLiquidar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpVencimentoFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpVencimentoInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvAVencer;
        private System.Windows.Forms.DataGridView dgvQuitados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLiquidados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAVencer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalAberto;
        public System.Windows.Forms.DataGridView dgvVencidos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorTotalLiquidado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataLiquidacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clSelecionarAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigoFornecedorAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdLancamentoAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeEstabelecimentoAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeFornecedorAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataEntradaAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataVencimentoAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlValorTotalAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumeroDocumentoAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdEstabelecimentoAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatusAberto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clSelecionarAVencer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdFornecedorAVencer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdLancamentoAVencer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeEstabelecimentoAVencer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeFornecedorAVencer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataEntradaAVencer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataVencimentoAVencer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVAlorTotalAVencer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumeroDocumentoAVencer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdEstabelecimentoAVencer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatusAVencer;
    }
}