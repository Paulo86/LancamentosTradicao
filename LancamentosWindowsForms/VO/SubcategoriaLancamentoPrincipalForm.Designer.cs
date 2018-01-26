namespace LancamentosWindowsForms.VO
{
    partial class SubcategoriaLancamentoPrincipalForm
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
            this.txtNomeSubcategoria = new System.Windows.Forms.TextBox();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(235, 92);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 26);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar (ESC)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(139, 92);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 26);
            this.btnConfirmar.TabIndex = 32;
            this.btnConfirmar.Text = "(F3) Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Descrição Subcategoria";
            // 
            // txtNomeSubcategoria
            // 
            this.txtNomeSubcategoria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeSubcategoria.Location = new System.Drawing.Point(150, 39);
            this.txtNomeSubcategoria.Name = "txtNomeSubcategoria";
            this.txtNomeSubcategoria.Size = new System.Drawing.Size(263, 20);
            this.txtNomeSubcategoria.TabIndex = 31;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(419, 10);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(36, 23);
            this.btnCategoria.TabIndex = 36;
            this.btnCategoria.Text = "...";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Categoria de Lançamento";
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Location = new System.Drawing.Point(150, 12);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(263, 21);
            this.cbbCategoria.TabIndex = 35;
            // 
            // SubcategoriaLancamentoPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 143);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomeSubcategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "SubcategoriaLancamentoPrincipalForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubcategoriaLancamentoPrincipal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SubcategoriaLancamentoPrincipalForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SubcategoriaLancamentoPrincipalForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeSubcategoria;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCategoria;
    }
}