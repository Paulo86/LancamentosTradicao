namespace LancamentosWindowsForms.VO
{
    partial class DespesasLancamentoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbbSubcategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.dtpDataMovimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbParceiro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbEstabelecimento = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnSubcategoria = new System.Windows.Forms.Button();
            this.btnParceiro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricaoLancamento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subcategoria de Lançamento";
            // 
            // cbbSubcategoria
            // 
            this.cbbSubcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubcategoria.FormattingEnabled = true;
            this.cbbSubcategoria.Location = new System.Drawing.Point(163, 95);
            this.cbbSubcategoria.Name = "cbbSubcategoria";
            this.cbbSubcategoria.Size = new System.Drawing.Size(263, 21);
            this.cbbSubcategoria.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categoria de Lançamento";
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Location = new System.Drawing.Point(163, 68);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(263, 21);
            this.cbbCategoria.TabIndex = 5;
            this.cbbCategoria.SelectedValueChanged += new System.EventHandler(this.cbbCategoria_SelectedValueChanged);
            // 
            // dtpDataMovimento
            // 
            this.dtpDataMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataMovimento.Location = new System.Drawing.Point(163, 149);
            this.dtpDataMovimento.Name = "dtpDataMovimento";
            this.dtpDataMovimento.Size = new System.Drawing.Size(96, 20);
            this.dtpDataMovimento.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data do Movimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Parceiro";
            // 
            // cbbParceiro
            // 
            this.cbbParceiro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbParceiro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbParceiro.FormattingEnabled = true;
            this.cbbParceiro.Location = new System.Drawing.Point(163, 122);
            this.cbbParceiro.Name = "cbbParceiro";
            this.cbbParceiro.Size = new System.Drawing.Size(263, 21);
            this.cbbParceiro.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor ";
            // 
            // txtValor
            // 
            this.txtValor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValor.Location = new System.Drawing.Point(163, 175);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(96, 20);
            this.txtValor.TabIndex = 13;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estabelecimento";
            // 
            // cbbEstabelecimento
            // 
            this.cbbEstabelecimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstabelecimento.FormattingEnabled = true;
            this.cbbEstabelecimento.Location = new System.Drawing.Point(163, 41);
            this.cbbEstabelecimento.Name = "cbbEstabelecimento";
            this.cbbEstabelecimento.Size = new System.Drawing.Size(305, 21);
            this.cbbEstabelecimento.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(241, 237);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 26);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar (ESC)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(145, 237);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 26);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "(F3) Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(432, 66);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(36, 23);
            this.btnCategoria.TabIndex = 16;
            this.btnCategoria.Text = "...";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnSubcategoria
            // 
            this.btnSubcategoria.Location = new System.Drawing.Point(432, 93);
            this.btnSubcategoria.Name = "btnSubcategoria";
            this.btnSubcategoria.Size = new System.Drawing.Size(36, 23);
            this.btnSubcategoria.TabIndex = 17;
            this.btnSubcategoria.Text = "...";
            this.btnSubcategoria.UseVisualStyleBackColor = true;
            this.btnSubcategoria.Click += new System.EventHandler(this.btnSubcategoria_Click);
            // 
            // btnParceiro
            // 
            this.btnParceiro.Location = new System.Drawing.Point(432, 120);
            this.btnParceiro.Name = "btnParceiro";
            this.btnParceiro.Size = new System.Drawing.Size(36, 23);
            this.btnParceiro.TabIndex = 18;
            this.btnParceiro.Text = "...";
            this.btnParceiro.UseVisualStyleBackColor = true;
            this.btnParceiro.Click += new System.EventHandler(this.btnParceiro_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Descrição Lançamento";
            // 
            // txtDescricaoLancamento
            // 
            this.txtDescricaoLancamento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescricaoLancamento.Location = new System.Drawing.Point(163, 15);
            this.txtDescricaoLancamento.Name = "txtDescricaoLancamento";
            this.txtDescricaoLancamento.Size = new System.Drawing.Size(305, 20);
            this.txtDescricaoLancamento.TabIndex = 1;
            // 
            // DespesasLancamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 285);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescricaoLancamento);
            this.Controls.Add(this.btnParceiro);
            this.Controls.Add(this.btnSubcategoria);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbEstabelecimento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbParceiro);
            this.Controls.Add(this.dtpDataMovimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbSubcategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DespesasLancamentoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DespesasLancamentoForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DespesasLancamentoForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbSubcategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.DateTimePicker dtpDataMovimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbParceiro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbEstabelecimento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnSubcategoria;
        private System.Windows.Forms.Button btnParceiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescricaoLancamento;
    }
}