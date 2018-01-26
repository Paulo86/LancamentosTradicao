namespace LancamentosWindowsForms.VO
{
    partial class ProdutosNotaFiscalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoSemImposto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustoComImposto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clNomeProduto,
            this.clQuantidade,
            this.clUnidade,
            this.clValorUnitario,
            this.clCustoSemImposto,
            this.clCustoComImposto,
            this.clSt,
            this.clIPI,
            this.clValorDesconto,
            this.clValorTotal});
            this.dgvProdutos.Location = new System.Drawing.Point(4, 4);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(707, 353);
            this.dgvProdutos.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(601, 363);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 26);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "(ESC) Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // clCodigo
            // 
            this.clCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clCodigo.DataPropertyName = "idProduto";
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.ReadOnly = true;
            this.clCodigo.Width = 65;
            // 
            // clNomeProduto
            // 
            this.clNomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clNomeProduto.DataPropertyName = "nomeProduto";
            this.clNomeProduto.HeaderText = "Nome Produto";
            this.clNomeProduto.Name = "clNomeProduto";
            this.clNomeProduto.ReadOnly = true;
            // 
            // clQuantidade
            // 
            this.clQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clQuantidade.DataPropertyName = "quantidade";
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.clQuantidade.DefaultCellStyle = dataGridViewCellStyle11;
            this.clQuantidade.HeaderText = "Quantidade";
            this.clQuantidade.Name = "clQuantidade";
            this.clQuantidade.ReadOnly = true;
            this.clQuantidade.Width = 87;
            // 
            // clUnidade
            // 
            this.clUnidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clUnidade.DataPropertyName = "quantidadeEmbalagem";
            this.clUnidade.HeaderText = "Quantidade Embalagem";
            this.clUnidade.Name = "clUnidade";
            this.clUnidade.ReadOnly = true;
            this.clUnidade.Width = 132;
            // 
            // clValorUnitario
            // 
            this.clValorUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValorUnitario.DataPropertyName = "valorUnitario";
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.clValorUnitario.DefaultCellStyle = dataGridViewCellStyle12;
            this.clValorUnitario.HeaderText = "Valor Unitáiro";
            this.clValorUnitario.Name = "clValorUnitario";
            this.clValorUnitario.ReadOnly = true;
            this.clValorUnitario.Width = 87;
            // 
            // clCustoSemImposto
            // 
            this.clCustoSemImposto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clCustoSemImposto.DataPropertyName = "CustoSemImposto";
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.clCustoSemImposto.DefaultCellStyle = dataGridViewCellStyle13;
            this.clCustoSemImposto.HeaderText = "Custo Sem Imposto";
            this.clCustoSemImposto.Name = "clCustoSemImposto";
            this.clCustoSemImposto.ReadOnly = true;
            this.clCustoSemImposto.Width = 113;
            // 
            // clCustoComImposto
            // 
            this.clCustoComImposto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clCustoComImposto.DataPropertyName = "CustoComImposto";
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.clCustoComImposto.DefaultCellStyle = dataGridViewCellStyle14;
            this.clCustoComImposto.HeaderText = "Custo Com Imposto";
            this.clCustoComImposto.Name = "clCustoComImposto";
            this.clCustoComImposto.ReadOnly = true;
            this.clCustoComImposto.Width = 113;
            // 
            // clSt
            // 
            this.clSt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clSt.DataPropertyName = "valorIcmsSt";
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.clSt.DefaultCellStyle = dataGridViewCellStyle15;
            this.clSt.HeaderText = "Valor ICMS ST";
            this.clSt.Name = "clSt";
            this.clSt.ReadOnly = true;
            this.clSt.Width = 81;
            // 
            // clIPI
            // 
            this.clIPI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clIPI.DataPropertyName = "valorIpi";
            dataGridViewCellStyle16.Format = "N2";
            dataGridViewCellStyle16.NullValue = null;
            this.clIPI.DefaultCellStyle = dataGridViewCellStyle16;
            this.clIPI.HeaderText = "Valor IPI";
            this.clIPI.Name = "clIPI";
            this.clIPI.ReadOnly = true;
            this.clIPI.Width = 67;
            // 
            // clValorDesconto
            // 
            this.clValorDesconto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValorDesconto.DataPropertyName = "valorDesconto";
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.clValorDesconto.DefaultCellStyle = dataGridViewCellStyle17;
            this.clValorDesconto.HeaderText = "Valor Desconto";
            this.clValorDesconto.Name = "clValorDesconto";
            this.clValorDesconto.ReadOnly = true;
            this.clValorDesconto.Width = 96;
            // 
            // clValorTotal
            // 
            this.clValorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clValorTotal.DataPropertyName = "valorTotal";
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = null;
            this.clValorTotal.DefaultCellStyle = dataGridViewCellStyle18;
            this.clValorTotal.HeaderText = "ValorTotal";
            this.clValorTotal.Name = "clValorTotal";
            this.clValorTotal.ReadOnly = true;
            this.clValorTotal.Width = 80;
            // 
            // ProdutosNotaFiscalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 405);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvProdutos);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProdutosNotaFiscalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutosNotaFiscalForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProdutosNotaFiscalForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoSemImposto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustoComImposto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorTotal;
    }
}