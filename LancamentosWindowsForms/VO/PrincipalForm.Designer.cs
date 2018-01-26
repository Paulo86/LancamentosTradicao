namespace LancamentosWindowsForms.VO
{
    partial class PrincipalForm
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
            this.LancamentoBoletosButton = new System.Windows.Forms.Button();
            this.LancamentoDespesasButton = new System.Windows.Forms.Button();
            this.LancamentoVendasButton = new System.Windows.Forms.Button();
            this.SairButton = new System.Windows.Forms.Button();
            this.LancamentoComprasButton = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LancamentoBoletosButton
            // 
            this.LancamentoBoletosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LancamentoBoletosButton.Location = new System.Drawing.Point(12, 12);
            this.LancamentoBoletosButton.Name = "LancamentoBoletosButton";
            this.LancamentoBoletosButton.Size = new System.Drawing.Size(328, 50);
            this.LancamentoBoletosButton.TabIndex = 0;
            this.LancamentoBoletosButton.Text = "Lançamentos de Boletos";
            this.LancamentoBoletosButton.UseVisualStyleBackColor = true;
            this.LancamentoBoletosButton.Click += new System.EventHandler(this.LancamentoBoletosButton_Click);
            // 
            // LancamentoDespesasButton
            // 
            this.LancamentoDespesasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LancamentoDespesasButton.Location = new System.Drawing.Point(12, 68);
            this.LancamentoDespesasButton.Name = "LancamentoDespesasButton";
            this.LancamentoDespesasButton.Size = new System.Drawing.Size(328, 50);
            this.LancamentoDespesasButton.TabIndex = 1;
            this.LancamentoDespesasButton.Text = "Lançamentos de Despesas";
            this.LancamentoDespesasButton.UseVisualStyleBackColor = true;
            this.LancamentoDespesasButton.Click += new System.EventHandler(this.LancamentoDespesasButton_Click);
            // 
            // LancamentoVendasButton
            // 
            this.LancamentoVendasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LancamentoVendasButton.Location = new System.Drawing.Point(12, 124);
            this.LancamentoVendasButton.Name = "LancamentoVendasButton";
            this.LancamentoVendasButton.Size = new System.Drawing.Size(328, 50);
            this.LancamentoVendasButton.TabIndex = 2;
            this.LancamentoVendasButton.Text = "Lançamentos de Vendas";
            this.LancamentoVendasButton.UseVisualStyleBackColor = true;
            this.LancamentoVendasButton.Click += new System.EventHandler(this.LancamentoVendasButton_Click);
            // 
            // SairButton
            // 
            this.SairButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairButton.Location = new System.Drawing.Point(12, 348);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(328, 50);
            this.SairButton.TabIndex = 6;
            this.SairButton.Text = "(ESC) Sair";
            this.SairButton.UseVisualStyleBackColor = true;
            this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
            // 
            // LancamentoComprasButton
            // 
            this.LancamentoComprasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LancamentoComprasButton.Location = new System.Drawing.Point(12, 180);
            this.LancamentoComprasButton.Name = "LancamentoComprasButton";
            this.LancamentoComprasButton.Size = new System.Drawing.Size(328, 50);
            this.LancamentoComprasButton.TabIndex = 3;
            this.LancamentoComprasButton.Text = "Lançamentos de Compras";
            this.LancamentoComprasButton.UseVisualStyleBackColor = true;
            this.LancamentoComprasButton.Click += new System.EventHandler(this.LancamentoComprasButton_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferencia.Location = new System.Drawing.Point(12, 236);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(328, 50);
            this.btnTransferencia.TabIndex = 4;
            this.btnTransferencia.Text = "Lançamentos de Transferencias";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Digitação de Estoque";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.LancamentoComprasButton);
            this.Controls.Add(this.SairButton);
            this.Controls.Add(this.LancamentoVendasButton);
            this.Controls.Add(this.LancamentoDespesasButton);
            this.Controls.Add(this.LancamentoBoletosButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincipalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Lançamentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalForm_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrincipalForm_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LancamentoBoletosButton;
        private System.Windows.Forms.Button LancamentoDespesasButton;
        private System.Windows.Forms.Button LancamentoVendasButton;
        private System.Windows.Forms.Button SairButton;
        private System.Windows.Forms.Button LancamentoComprasButton;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Button button1;
    }
}