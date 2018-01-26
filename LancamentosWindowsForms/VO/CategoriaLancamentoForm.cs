using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
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
    public partial class CategoriaLancamentoForm : Form
    {
        public CategoriaLancamentoForm()
        {
            try
            {
                InitializeComponent();
                this.CarregarDatagrid();
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }
        private void CarregarDatagrid()
        {
            try
            {
                this.dgvCategoriaLancamento.DataSource = new CategoriaLancamentoDAO().CategoriaLancamentoList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CategoriaLancamentoForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoLancamento_Click(object sender, EventArgs e)
        {
            using (var frmCategoriaLancamento = new CategoriaLancamentoPrincipalForm(null))
            {
                frmCategoriaLancamento.ShowDialog();
                this.CarregarDatagrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCategoriaLancamento.SelectedRows.Count > 0)
                {
                    using (var frmCategoriaLancamento = new CategoriaLancamentoPrincipalForm(new CategoriaLancamentoModel
                    {
                        IdCategoria = Convert.ToInt32(this.dgvCategoriaLancamento.CurrentRow.Cells["clCodigo"].Value),
                        NomeCategoria = this.dgvCategoriaLancamento.CurrentRow.Cells["clNome"].Value.ToString()
                    }))
                    {
                        frmCategoriaLancamento.ShowDialog();
                        this.CarregarDatagrid();
                    }
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCategoriaLancamento.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Deseja realmente excluir este registro ?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.No)
                    {
                        var retorno = new CategoriaLancamentoDAO().LancamentoCategoriaManter(new CategoriaLancamentoModel
                        {
                            IdCategoria = Convert.ToInt32(this.dgvCategoriaLancamento.CurrentRow.Cells["clCodigo"].Value),
                        });
                        if (retorno == "DELETE OK")
                        {
                            Mensagens.MensagemInformacao("Categoria de Lançamento excluida com sucesso !");
                            this.CarregarDatagrid();
                        }
                        else
                        {
                            throw new Exception(retorno);
                        }
                    }
                }
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }
    }
}
