using LancamentosWindowsForms.DAO;
using System;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            try
            {
                InitializeComponent();
                //DBCore dbCore = new DBCore();
                //dbCore.ImportarProdutoHiper();
                //dbCore.ImportarProdutoEanHiper();
            }
            catch (Exception e)
            {
                Mensagens.MensagemErro(e.Message);
            }
        }

        private void PrincipalForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LancamentoBoletosButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var boletosForm = new BoletosForm())
                {
                    boletosForm.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LancamentoDespesasButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var despesasForm = new DespesasForm())
                {
                    despesasForm.ShowDialog();
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void LancamentoVendasButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new VendaDiariaConsolidadaForm())
                {
                    f.ShowDialog();
                }
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void LancamentoComprasButton_Click(object sender, EventArgs e)
        {
            using (var f = new NotasFiscaisForm())
            {
                f.ShowDialog();
            }
        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema ?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            using (var f = new EstoqueTransferenciaForm())
            {
                f.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var f = new InventarioForm())
            {
                f.ShowDialog();
            }
        }
    }
}
