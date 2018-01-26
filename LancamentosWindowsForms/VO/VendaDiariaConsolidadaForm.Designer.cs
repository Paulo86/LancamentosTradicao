namespace LancamentosWindowsForms.VO
{
    partial class VendaDiariaConsolidadaForm
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovoLancamento = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvVendasCosolidadas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbEstabelecimento = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValorTotalAcougue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorTotalMercearia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorTotalValorTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clIdLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEstabelecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdEstabelecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorMercearia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorAcougue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendasCosolidadas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(120, 506);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 26);
            this.btnAlterar.TabIndex = 30;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(593, 506);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 26);
            this.btnSair.TabIndex = 29;
            this.btnSair.Text = "(ESC) Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(236, 506);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 26);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovoLancamento
            // 
            this.btnNovoLancamento.Location = new System.Drawing.Point(4, 506);
            this.btnNovoLancamento.Name = "btnNovoLancamento";
            this.btnNovoLancamento.Size = new System.Drawing.Size(110, 26);
            this.btnNovoLancamento.TabIndex = 27;
            this.btnNovoLancamento.Text = "Novo lançamento";
            this.btnNovoLancamento.UseVisualStyleBackColor = true;
            this.btnNovoLancamento.Click += new System.EventHandler(this.btnNovoLancamento_Click);
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
            // dgvVendasCosolidadas
            // 
            this.dgvVendasCosolidadas.AllowUserToAddRows = false;
            this.dgvVendasCosolidadas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvVendasCosolidadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendasCosolidadas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVendasCosolidadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendasCosolidadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIdLancamento,
            this.clDataMovimento,
            this.clEstabelecimento,
            this.clIdEstabelecimento,
            this.clValorMercearia,
            this.clValorAcougue,
            this.clValorTotal});
            this.dgvVendasCosolidadas.Location = new System.Drawing.Point(6, 64);
            this.dgvVendasCosolidadas.MultiSelect = false;
            this.dgvVendasCosolidadas.Name = "dgvVendasCosolidadas";
            this.dgvVendasCosolidadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendasCosolidadas.Size = new System.Drawing.Size(697, 360);
            this.dgvVendasCosolidadas.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.dtpDataFinal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDataInicial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(352, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 48);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período de Movimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Estabelecimento";
            // 
            // cbbEstabelecimento
            // 
            this.cbbEstabelecimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstabelecimento.FormattingEnabled = true;
            this.cbbEstabelecimento.Location = new System.Drawing.Point(92, 28);
            this.cbbEstabelecimento.Name = "cbbEstabelecimento";
            this.cbbEstabelecimento.Size = new System.Drawing.Size(254, 21);
            this.cbbEstabelecimento.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtValorTotalAcougue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtValorTotalMercearia);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtValorTotalValorTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(4, 430);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 70);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores totais";
            // 
            // txtValorTotalAcougue
            // 
            this.txtValorTotalAcougue.BackColor = System.Drawing.Color.White;
            this.txtValorTotalAcougue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalAcougue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtValorTotalAcougue.Location = new System.Drawing.Point(320, 28);
            this.txtValorTotalAcougue.Name = "txtValorTotalAcougue";
            this.txtValorTotalAcougue.ReadOnly = true;
            this.txtValorTotalAcougue.Size = new System.Drawing.Size(134, 26);
            this.txtValorTotalAcougue.TabIndex = 42;
            this.txtValorTotalAcougue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Açougue";
            // 
            // txtValorTotalMercearia
            // 
            this.txtValorTotalMercearia.BackColor = System.Drawing.Color.White;
            this.txtValorTotalMercearia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalMercearia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtValorTotalMercearia.Location = new System.Drawing.Point(90, 28);
            this.txtValorTotalMercearia.Name = "txtValorTotalMercearia";
            this.txtValorTotalMercearia.ReadOnly = true;
            this.txtValorTotalMercearia.Size = new System.Drawing.Size(134, 26);
            this.txtValorTotalMercearia.TabIndex = 40;
            this.txtValorTotalMercearia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mercearia";
            // 
            // txtValorTotalValorTotal
            // 
            this.txtValorTotalValorTotal.BackColor = System.Drawing.Color.White;
            this.txtValorTotalValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtValorTotalValorTotal.Location = new System.Drawing.Point(559, 28);
            this.txtValorTotalValorTotal.Name = "txtValorTotalValorTotal";
            this.txtValorTotalValorTotal.ReadOnly = true;
            this.txtValorTotalValorTotal.Size = new System.Drawing.Size(134, 26);
            this.txtValorTotalValorTotal.TabIndex = 38;
            this.txtValorTotalValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(472, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Valor total";
            // 
            // clIdLancamento
            // 
            this.clIdLancamento.DataPropertyName = "id_lancamento";
            this.clIdLancamento.HeaderText = "Codigo Lancamento";
            this.clIdLancamento.Name = "clIdLancamento";
            this.clIdLancamento.ReadOnly = true;
            this.clIdLancamento.Visible = false;
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
            // clEstabelecimento
            // 
            this.clEstabelecimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clEstabelecimento.DataPropertyName = "nome_estabelecimento";
            this.clEstabelecimento.HeaderText = "Estabelecimento";
            this.clEstabelecimento.Name = "clEstabelecimento";
            this.clEstabelecimento.ReadOnly = true;
            // 
            // clIdEstabelecimento
            // 
            this.clIdEstabelecimento.DataPropertyName = "id_estabelecimento";
            this.clIdEstabelecimento.HeaderText = "Codigo Estabelecimento";
            this.clIdEstabelecimento.Name = "clIdEstabelecimento";
            this.clIdEstabelecimento.ReadOnly = true;
            this.clIdEstabelecimento.Visible = false;
            // 
            // clValorMercearia
            // 
            this.clValorMercearia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValorMercearia.DataPropertyName = "valor_mercearia";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.clValorMercearia.DefaultCellStyle = dataGridViewCellStyle3;
            this.clValorMercearia.HeaderText = "Valor Mercearia";
            this.clValorMercearia.Name = "clValorMercearia";
            this.clValorMercearia.ReadOnly = true;
            this.clValorMercearia.Width = 97;
            // 
            // clValorAcougue
            // 
            this.clValorAcougue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValorAcougue.DataPropertyName = "valor_acougue";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.clValorAcougue.DefaultCellStyle = dataGridViewCellStyle4;
            this.clValorAcougue.HeaderText = "Valor Açougue";
            this.clValorAcougue.Name = "clValorAcougue";
            this.clValorAcougue.ReadOnly = true;
            this.clValorAcougue.Width = 94;
            // 
            // clValorTotal
            // 
            this.clValorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValorTotal.DataPropertyName = "valor_total";
            dataGridViewCellStyle5.Format = "N2";
            this.clValorTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.clValorTotal.HeaderText = "Valor Total";
            this.clValorTotal.Name = "clValorTotal";
            this.clValorTotal.ReadOnly = true;
            this.clValorTotal.Width = 77;
            // 
            // VendaDiariaConsolidadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovoLancamento);
            this.Controls.Add(this.dgvVendasCosolidadas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbEstabelecimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "VendaDiariaConsolidadaForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VendaDiariaConsolidadaForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendasCosolidadas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovoLancamento;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvVendasCosolidadas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbEstabelecimento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtValorTotalAcougue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorTotalMercearia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorTotalValorTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataMovimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEstabelecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdEstabelecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorMercearia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorAcougue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorTotal;
    }
}