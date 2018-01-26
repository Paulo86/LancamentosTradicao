using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class InventarioForm : Form
    {
        public InventarioForm()
        {
            InitializeComponent();
        }

        private void DigitaEstoqueForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Escape))
                {
                    this.Close();
                }
                else if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    this.ProcessTabKey(true);
                }
            }
            catch (Exception)
            {

                return;
            }
        }
        private void DigitaEstoqueForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToChar(e.KeyData) == Convert.ToChar(Keys.F3))
                {
                    //this.btnConfirmar.PerformClick();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnNovoLancamento_Click(object sender, EventArgs e)
        {
            using (var f = new InventarioCadastroForm())
            {
                f.ShowDialog();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
