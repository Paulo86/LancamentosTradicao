namespace LancamentosWindowsForms.VO
{
    partial class InventarioCadastroForm
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
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDepartamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbEstabelecimento = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizarInventario = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAtualizarProduto = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(112, 66);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(96, 20);
            this.dtpDataEntrada.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data da Contagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dapartamento";
            // 
            // cbbDepartamento
            // 
            this.cbbDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartamento.FormattingEnabled = true;
            this.cbbDepartamento.Location = new System.Drawing.Point(112, 39);
            this.cbbDepartamento.Name = "cbbDepartamento";
            this.cbbDepartamento.Size = new System.Drawing.Size(265, 21);
            this.cbbDepartamento.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estabelecimento";
            // 
            // cbbEstabelecimento
            // 
            this.cbbEstabelecimento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbEstabelecimento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstabelecimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstabelecimento.FormattingEnabled = true;
            this.cbbEstabelecimento.Location = new System.Drawing.Point(112, 12);
            this.cbbEstabelecimento.Name = "cbbEstabelecimento";
            this.cbbEstabelecimento.Size = new System.Drawing.Size(265, 21);
            this.cbbEstabelecimento.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.Location = new System.Drawing.Point(13, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 262);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowDrop = true;
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clNomeProduto,
            this.clQuantidade});
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 16);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(719, 243);
            this.dgvProdutos.TabIndex = 2;
            // 
            // clCodigo
            // 
            this.clCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.Width = 65;
            // 
            // clNomeProduto
            // 
            this.clNomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNomeProduto.HeaderText = "Descrição Produto";
            this.clNomeProduto.Name = "clNomeProduto";
            // 
            // clQuantidade
            // 
            this.clQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clQuantidade.HeaderText = "Estoque digitado";
            this.clQuantidade.Name = "clQuantidade";
            this.clQuantidade.Width = 102;
            // 
            // btnFinalizarInventario
            // 
            this.btnFinalizarInventario.Location = new System.Drawing.Point(248, 432);
            this.btnFinalizarInventario.Name = "btnFinalizarInventario";
            this.btnFinalizarInventario.Size = new System.Drawing.Size(110, 26);
            this.btnFinalizarInventario.TabIndex = 14;
            this.btnFinalizarInventario.Text = "Finalizar Inventário";
            this.btnFinalizarInventario.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(16, 432);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(110, 26);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(625, 432);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 26);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "(ESC) Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAtualizarProduto
            // 
            this.btnAtualizarProduto.Location = new System.Drawing.Point(132, 432);
            this.btnAtualizarProduto.Name = "btnAtualizarProduto";
            this.btnAtualizarProduto.Size = new System.Drawing.Size(110, 26);
            this.btnAtualizarProduto.TabIndex = 16;
            this.btnAtualizarProduto.Text = "Atualizar Produtos";
            this.btnAtualizarProduto.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(112, 119);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(265, 20);
            this.txtDescricao.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Status";
            // 
            // cbbStatus
            // 
            this.cbbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.Enabled = false;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(112, 92);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(265, 21);
            this.cbbStatus.TabIndex = 20;
            // 
            // InventarioCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 465);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnAtualizarProduto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFinalizarInventario);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDataEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbDepartamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbEstabelecimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventarioCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InventarioCadastroForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DigitaEstoqueProdutoForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitaEstoqueProdutoForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbEstabelecimento;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnFinalizarInventario;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantidade;
        private System.Windows.Forms.Button btnAtualizarProduto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbStatus;
    }
}