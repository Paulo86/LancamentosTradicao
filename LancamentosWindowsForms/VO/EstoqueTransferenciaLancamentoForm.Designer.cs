namespace LancamentosWindowsForms.VO
{
    partial class EstoqueTransferenciaLancamentoForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.cbbEstabelecimentoDestino = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbEstabelecimentoOrigem = new System.Windows.Forms.ComboBox();
            this.dtpMovimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnProduto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.rdbCustoDigitado = new System.Windows.Forms.RadioButton();
            this.rdbUltimoCusto = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidadeTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidadeEmbalagem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Destino";
            // 
            // cbbEstabelecimentoDestino
            // 
            this.cbbEstabelecimentoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstabelecimentoDestino.FormattingEnabled = true;
            this.cbbEstabelecimentoDestino.Location = new System.Drawing.Point(117, 46);
            this.cbbEstabelecimentoDestino.Name = "cbbEstabelecimentoDestino";
            this.cbbEstabelecimentoDestino.Size = new System.Drawing.Size(318, 21);
            this.cbbEstabelecimentoDestino.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Origem";
            // 
            // cbbEstabelecimentoOrigem
            // 
            this.cbbEstabelecimentoOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstabelecimentoOrigem.FormattingEnabled = true;
            this.cbbEstabelecimentoOrigem.Location = new System.Drawing.Point(117, 19);
            this.cbbEstabelecimentoOrigem.Name = "cbbEstabelecimentoOrigem";
            this.cbbEstabelecimentoOrigem.Size = new System.Drawing.Size(318, 21);
            this.cbbEstabelecimentoOrigem.TabIndex = 1;
            // 
            // dtpMovimento
            // 
            this.dtpMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMovimento.Location = new System.Drawing.Point(117, 74);
            this.dtpMovimento.Name = "dtpMovimento";
            this.dtpMovimento.Size = new System.Drawing.Size(96, 20);
            this.dtpMovimento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data do Movimento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNomeProduto);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.btnProduto);
            this.groupBox2.Location = new System.Drawing.Point(8, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produto";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.Color.White;
            this.txtNomeProduto.Location = new System.Drawing.Point(126, 18);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(338, 20);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 18);
            this.txtCodigo.MaxLength = 14;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(114, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(470, 16);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(36, 23);
            this.btnProduto.TabIndex = 2;
            this.btnProduto.Text = "...";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbEstabelecimentoOrigem);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpMovimento);
            this.groupBox1.Controls.Add(this.cbbEstabelecimentoDestino);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estabelecimentos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(266, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 26);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar (ESC)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(170, 318);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 26);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "(F3) Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtQuantidadeTotal);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtQuantidadeEmbalagem);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtQuantidade);
            this.groupBox3.Location = new System.Drawing.Point(8, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblCusto);
            this.groupBox4.Controls.Add(this.txtCusto);
            this.groupBox4.Controls.Add(this.rdbCustoDigitado);
            this.groupBox4.Controls.Add(this.rdbUltimoCusto);
            this.groupBox4.Location = new System.Drawing.Point(228, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 69);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Custo do Produto";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(136, 45);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(34, 13);
            this.lblCusto.TabIndex = 2;
            this.lblCusto.Text = "Custo";
            this.lblCusto.Visible = false;
            // 
            // txtCusto
            // 
            this.txtCusto.BackColor = System.Drawing.Color.White;
            this.txtCusto.Location = new System.Drawing.Point(176, 42);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(96, 20);
            this.txtCusto.TabIndex = 3;
            this.txtCusto.Visible = false;
            // 
            // rdbCustoDigitado
            // 
            this.rdbCustoDigitado.AutoSize = true;
            this.rdbCustoDigitado.Location = new System.Drawing.Point(6, 42);
            this.rdbCustoDigitado.Name = "rdbCustoDigitado";
            this.rdbCustoDigitado.Size = new System.Drawing.Size(92, 17);
            this.rdbCustoDigitado.TabIndex = 1;
            this.rdbCustoDigitado.TabStop = true;
            this.rdbCustoDigitado.Text = "Custo digitado";
            this.rdbCustoDigitado.UseVisualStyleBackColor = true;
            this.rdbCustoDigitado.CheckedChanged += new System.EventHandler(this.rdbCustoDigitado_CheckedChanged);
            // 
            // rdbUltimoCusto
            // 
            this.rdbUltimoCusto.AutoSize = true;
            this.rdbUltimoCusto.Location = new System.Drawing.Point(6, 19);
            this.rdbUltimoCusto.Name = "rdbUltimoCusto";
            this.rdbUltimoCusto.Size = new System.Drawing.Size(131, 17);
            this.rdbUltimoCusto.TabIndex = 0;
            this.rdbUltimoCusto.TabStop = true;
            this.rdbUltimoCusto.Text = "Usar Custo de entrada";
            this.rdbUltimoCusto.UseVisualStyleBackColor = true;
            this.rdbUltimoCusto.CheckedChanged += new System.EventHandler(this.rdbUltimoCusto_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade Total";
            // 
            // txtQuantidadeTotal
            // 
            this.txtQuantidadeTotal.BackColor = System.Drawing.Color.White;
            this.txtQuantidadeTotal.Location = new System.Drawing.Point(126, 71);
            this.txtQuantidadeTotal.Name = "txtQuantidadeTotal";
            this.txtQuantidadeTotal.ReadOnly = true;
            this.txtQuantidadeTotal.Size = new System.Drawing.Size(96, 20);
            this.txtQuantidadeTotal.TabIndex = 5;
            this.txtQuantidadeTotal.Leave += new System.EventHandler(this.txtQuantidadeTotal_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade por Embal.";
            // 
            // txtQuantidadeEmbalagem
            // 
            this.txtQuantidadeEmbalagem.Location = new System.Drawing.Point(126, 45);
            this.txtQuantidadeEmbalagem.Name = "txtQuantidadeEmbalagem";
            this.txtQuantidadeEmbalagem.Size = new System.Drawing.Size(96, 20);
            this.txtQuantidadeEmbalagem.TabIndex = 3;
            this.txtQuantidadeEmbalagem.Text = "1";
            this.txtQuantidadeEmbalagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeEmbalagem_KeyPress);
            this.txtQuantidadeEmbalagem.Leave += new System.EventHandler(this.txtQuantidadeEmbalagem_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(126, 19);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(96, 20);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // EstoqueTransferenciaLancamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 359);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EstoqueTransferenciaLancamentoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Transferencia";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EstoqueTransferenciaLancamentoForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EstoqueTransferenciaLancamentoForm_KeyPress);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbEstabelecimentoDestino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbEstabelecimentoOrigem;
        private System.Windows.Forms.DateTimePicker dtpMovimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidadeTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidadeEmbalagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.RadioButton rdbCustoDigitado;
        private System.Windows.Forms.RadioButton rdbUltimoCusto;
    }
}