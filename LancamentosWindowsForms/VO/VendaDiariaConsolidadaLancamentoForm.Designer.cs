namespace LancamentosWindowsForms.VO
{
    partial class VendaDiariaConsolidadaLancamentoForm
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorMercearia = new System.Windows.Forms.TextBox();
            this.dtpDataMovimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbEstabelecimento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorAcougue = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(205, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 26);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar (ESC)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(109, 193);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 26);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "(F3) Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Valor Mercearia";
            // 
            // txtValorMercearia
            // 
            this.txtValorMercearia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorMercearia.Location = new System.Drawing.Point(111, 65);
            this.txtValorMercearia.Name = "txtValorMercearia";
            this.txtValorMercearia.Size = new System.Drawing.Size(96, 20);
            this.txtValorMercearia.TabIndex = 5;
            this.txtValorMercearia.Enter += new System.EventHandler(this.txtValorMercearia_Enter);
            this.txtValorMercearia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorMercearia_KeyPress);
            this.txtValorMercearia.Leave += new System.EventHandler(this.txtValorMercearia_Leave);
            // 
            // dtpDataMovimento
            // 
            this.dtpDataMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataMovimento.Location = new System.Drawing.Point(111, 39);
            this.dtpDataMovimento.Name = "dtpDataMovimento";
            this.dtpDataMovimento.Size = new System.Drawing.Size(96, 20);
            this.dtpDataMovimento.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data do Movimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Estabelecimento";
            // 
            // cbbEstabelecimento
            // 
            this.cbbEstabelecimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstabelecimento.FormattingEnabled = true;
            this.cbbEstabelecimento.Location = new System.Drawing.Point(111, 12);
            this.cbbEstabelecimento.Name = "cbbEstabelecimento";
            this.cbbEstabelecimento.Size = new System.Drawing.Size(280, 21);
            this.cbbEstabelecimento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor Açougue";
            // 
            // txtValorAcougue
            // 
            this.txtValorAcougue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorAcougue.Location = new System.Drawing.Point(111, 91);
            this.txtValorAcougue.Name = "txtValorAcougue";
            this.txtValorAcougue.Size = new System.Drawing.Size(96, 20);
            this.txtValorAcougue.TabIndex = 7;
            this.txtValorAcougue.Enter += new System.EventHandler(this.txtValorAcougue_Enter);
            this.txtValorAcougue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorAcougue_KeyPress);
            this.txtValorAcougue.Leave += new System.EventHandler(this.txtValorAcougue_Leave);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblValorTotal.Location = new System.Drawing.Point(109, 132);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(214, 31);
            this.lblValorTotal.TabIndex = 8;
            this.lblValorTotal.Text = "Valor da taxa";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VendaDiariaConsolidadaLancamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 231);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorAcougue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbEstabelecimento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValorMercearia);
            this.Controls.Add(this.dtpDataMovimento);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VendaDiariaConsolidadaLancamentoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VendaDiariaConsolidadaLancamentoForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VendaDiariaConsolidadaLancamentoForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorMercearia;
        private System.Windows.Forms.DateTimePicker dtpDataMovimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbEstabelecimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorAcougue;
        private System.Windows.Forms.Label lblValorTotal;
    }
}