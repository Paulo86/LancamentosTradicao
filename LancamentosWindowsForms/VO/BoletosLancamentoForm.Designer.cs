namespace LancamentosWindowsForms.VO
{
    partial class BoletosLancamentoForm
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbbEstabelecimento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbFornecedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(135, 202);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 26);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "(F3) Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(231, 202);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 26);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar (ESC)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbbEstabelecimento
            // 
            this.cbbEstabelecimento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbEstabelecimento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstabelecimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstabelecimento.FormattingEnabled = true;
            this.cbbEstabelecimento.Location = new System.Drawing.Point(113, 12);
            this.cbbEstabelecimento.Name = "cbbEstabelecimento";
            this.cbbEstabelecimento.Size = new System.Drawing.Size(294, 21);
            this.cbbEstabelecimento.TabIndex = 1;
            this.cbbEstabelecimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbEstabelecimento_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estabelecimento";
            // 
            // cbbFornecedor
            // 
            this.cbbFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbFornecedor.FormattingEnabled = true;
            this.cbbFornecedor.Location = new System.Drawing.Point(113, 39);
            this.cbbFornecedor.Name = "cbbFornecedor";
            this.cbbFornecedor.Size = new System.Drawing.Size(294, 21);
            this.cbbFornecedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fornecedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Entrada";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(113, 66);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(96, 20);
            this.dtpDataEntrada.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Vencimento";
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimento.Location = new System.Drawing.Point(113, 92);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(96, 20);
            this.dtpDataVencimento.TabIndex = 7;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(113, 144);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(96, 20);
            this.txtValorTotal.TabIndex = 11;
            this.txtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTotal_KeyPress);
            this.txtValorTotal.Leave += new System.EventHandler(this.txtValorTotal_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor total";
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Location = new System.Drawing.Point(413, 39);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(36, 23);
            this.btnFornecedor.TabIndex = 14;
            this.btnFornecedor.Text = "...";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Numero documento";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(113, 118);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(96, 20);
            this.txtNumeroDocumento.TabIndex = 9;
            // 
            // BoletosLancamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 240);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.dtpDataVencimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDataEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbEstabelecimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BoletosLancamentoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoletosLancamentoForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LancamentoForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbbEstabelecimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataVencimento;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
    }
}