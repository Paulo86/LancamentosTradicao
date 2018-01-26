namespace LancamentosWindowsForms.VO
{
    partial class DespesaBoletoForm
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
            this.btnSubcategoria = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbSubcategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblValorTaxa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubcategoria
            // 
            this.btnSubcategoria.Location = new System.Drawing.Point(435, 37);
            this.btnSubcategoria.Name = "btnSubcategoria";
            this.btnSubcategoria.Size = new System.Drawing.Size(36, 23);
            this.btnSubcategoria.TabIndex = 23;
            this.btnSubcategoria.Text = "...";
            this.btnSubcategoria.UseVisualStyleBackColor = true;
            this.btnSubcategoria.Click += new System.EventHandler(this.btnSubcategoria_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(435, 10);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(36, 23);
            this.btnCategoria.TabIndex = 22;
            this.btnCategoria.Text = "...";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Subcategoria de Lançamento";
            // 
            // cbbSubcategoria
            // 
            this.cbbSubcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubcategoria.FormattingEnabled = true;
            this.cbbSubcategoria.Location = new System.Drawing.Point(166, 39);
            this.cbbSubcategoria.Name = "cbbSubcategoria";
            this.cbbSubcategoria.Size = new System.Drawing.Size(263, 21);
            this.cbbSubcategoria.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Categoria de Lançamento";
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Location = new System.Drawing.Point(166, 12);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(263, 21);
            this.cbbCategoria.TabIndex = 19;
            this.cbbCategoria.SelectedValueChanged += new System.EventHandler(this.cbbCategoria_SelectedValueChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(262, 151);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 26);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar (ESC)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(166, 151);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 26);
            this.btnConfirmar.TabIndex = 24;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblValorTaxa
            // 
            this.lblValorTaxa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTaxa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblValorTaxa.Location = new System.Drawing.Point(166, 77);
            this.lblValorTaxa.Name = "lblValorTaxa";
            this.lblValorTaxa.Size = new System.Drawing.Size(263, 40);
            this.lblValorTaxa.TabIndex = 27;
            this.lblValorTaxa.Text = "Valor da taxa";
            this.lblValorTaxa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DespesaBoletoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 203);
            this.Controls.Add(this.lblValorTaxa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnSubcategoria);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbSubcategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DespesaBoletoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de despesas de Boleto";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DespesaBoletoForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DespesaBoletoForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubcategoria;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbSubcategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblValorTaxa;
    }
}