namespace LancamentosWindowsForms.VO
{
    partial class InventarioForm
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
            this.dgvInventarios = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovoLancamento = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventarios
            // 
            this.dgvInventarios.AllowDrop = true;
            this.dgvInventarios.AllowUserToAddRows = false;
            this.dgvInventarios.AllowUserToDeleteRows = false;
            this.dgvInventarios.AllowUserToResizeColumns = false;
            this.dgvInventarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInventarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarios.Location = new System.Drawing.Point(6, 12);
            this.dgvInventarios.MultiSelect = false;
            this.dgvInventarios.Name = "dgvInventarios";
            this.dgvInventarios.Size = new System.Drawing.Size(637, 246);
            this.dgvInventarios.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(122, 264);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 26);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovoLancamento
            // 
            this.btnNovoLancamento.Location = new System.Drawing.Point(6, 264);
            this.btnNovoLancamento.Name = "btnNovoLancamento";
            this.btnNovoLancamento.Size = new System.Drawing.Size(110, 26);
            this.btnNovoLancamento.TabIndex = 10;
            this.btnNovoLancamento.Text = "Novo Inventário";
            this.btnNovoLancamento.UseVisualStyleBackColor = true;
            this.btnNovoLancamento.Click += new System.EventHandler(this.btnNovoLancamento_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(533, 264);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 26);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "(ESC) Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // InventarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 300);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovoLancamento);
            this.Controls.Add(this.dgvInventarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventarioForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventários";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DigitaEstoqueForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitaEstoqueForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvInventarios;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovoLancamento;
        private System.Windows.Forms.Button btnSair;
    }
}