namespace LancamentosWindowsForms.VO
{
    partial class BoletosLiquidarLoteForm
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dtpDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clIdLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeParceiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(281, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 26);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar (ESC)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(185, 284);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 26);
            this.btnConfirmar.TabIndex = 22;
            this.btnConfirmar.Text = "(F3) Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dtpDataPagamento
            // 
            this.dtpDataPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPagamento.Location = new System.Drawing.Point(165, 15);
            this.dtpDataPagamento.Name = "dtpDataPagamento";
            this.dtpDataPagamento.Size = new System.Drawing.Size(119, 26);
            this.dtpDataPagamento.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data do Pagamento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(11, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 224);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boletos á serem Liquidados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIdLancamento,
            this.clNomeParceiro,
            this.clValorTotal,
            this.clValorPago});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 205);
            this.dataGridView1.TabIndex = 25;
            // 
            // clIdLancamento
            // 
            this.clIdLancamento.DataPropertyName = "idLancamento";
            this.clIdLancamento.HeaderText = "idLancamento";
            this.clIdLancamento.Name = "clIdLancamento";
            this.clIdLancamento.Visible = false;
            // 
            // clNomeParceiro
            // 
            this.clNomeParceiro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNomeParceiro.DataPropertyName = "nomeParceiro";
            this.clNomeParceiro.HeaderText = "Parceiro";
            this.clNomeParceiro.Name = "clNomeParceiro";
            // 
            // clValorTotal
            // 
            this.clValorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValorTotal.DataPropertyName = "valorTitulo";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.clValorTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.clValorTotal.HeaderText = "Valor Total Título";
            this.clValorTotal.Name = "clValorTotal";
            this.clValorTotal.Width = 105;
            // 
            // clValorPago
            // 
            this.clValorPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.clValorPago.DefaultCellStyle = dataGridViewCellStyle3;
            this.clValorPago.HeaderText = "Valor Pago";
            this.clValorPago.Name = "clValorPago";
            this.clValorPago.Width = 78;
            // 
            // BoletosLiquidarLoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dtpDataPagamento);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BoletosLiquidarLoteForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liquidar lançamento em lote";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoletosLiquidarLoteForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LiquidarLancamentoLoteForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DateTimePicker dtpDataPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeParceiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorPago;
    }
}