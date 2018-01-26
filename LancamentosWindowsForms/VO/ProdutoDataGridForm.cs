using LancamentosWindowsForms.DAO;
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
    public partial class ProdutoDataGridForm : Form
    {
        private void CarregarDatagridProdutos()
        {
            try
            {
                this.dgvProdutos.AutoGenerateColumns = false;
                this.dgvProdutos.DataSource = new ProdutoDAO().ProdutoListByAll(this.txtPesquisa.Text, 0);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ProdutoDataGridForm()
        {
            try
            {
                InitializeComponent();
                this.CarregarDatagridProdutos();
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);

            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.CarregarDatagridProdutos();
                //if (e.KeyChar == Convert.ToChar(Keys.Enter))
                //{
                //    this.CarregarDatagridProdutos();
                //}
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CarregarDatagridProdutos();
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoLancamentoNotaFiscalForm.idProdutoAux = Convert.ToInt32(this.dgvProdutos.CurrentRow.Cells["clCodigo"].Value);
                this.Close();
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void dgvProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToChar(e.KeyValue) == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                ProdutoLancamentoNotaFiscalForm.idProdutoAux = Convert.ToInt32(this.dgvProdutos.CurrentRow.Cells["clCodigo"].Value);
                this.Close();
            }
        }

        private void ProdutoDataGridForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            ProdutoLancamentoNotaFiscalForm.idProdutoAux = Convert.ToInt32(this.dgvProdutos.CurrentRow.Cells["clCodigo"].Value);
            this.Close();
        }
    }
}
