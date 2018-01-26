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
    public partial class SubcategoriaLancamentoForm : Form
    {
        public SubcategoriaLancamentoForm()
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
        //
        private void CarregarDatagrid()
        {
            try
            {
                this.dgvPrincipal.DataSource = new SubcategoriaLancamentoDAO().SubCategoriaByAll().Select(x => new
                {
                    idSubcategoria = x.IdSubcategoria,
                    nomeSubcategoria = x.NomeSubcategoria,
                    idCategoria = x.CategoriaLancamento.IdCategoria,
                    nomeCategoria = x.CategoriaLancamento.NomeCategoria
                }).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        //
        private void SubcategoriaLancamentoForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }

        private void btnNovoLancamento_Click(object sender, EventArgs e)
        {
            try
            {
                using (var frmSubcategoriaLancamento = new SubcategoriaLancamentoPrincipalForm(null))
                {
                    frmSubcategoriaLancamento.ShowDialog();
                    this.CarregarDatagrid();
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
                if (this.dgvPrincipal.SelectedRows.Count > 0)
                {
                    using (var frmSubcategoriaLancamento = new SubcategoriaLancamentoPrincipalForm(new SubcategoriaLancamentoModel
                    {
                        IdSubcategoria = Convert.ToInt32(this.dgvPrincipal.CurrentRow.Cells["clIdSubcategoria"].Value),
                        NomeSubcategoria = this.dgvPrincipal.CurrentRow.Cells["clNomeSubcategoria"].Value.ToString(),
                        CategoriaLancamento = new CategoriaLancamentoModel
                        {
                            IdCategoria = Convert.ToInt32(this.dgvPrincipal.CurrentRow.Cells["clIdCategoria"].Value),
                            NomeCategoria = this.dgvPrincipal.CurrentRow.Cells["clNomeCategoria"].Value.ToString()
                        }
                    }))
                    {
                        frmSubcategoriaLancamento.ShowDialog();
                        this.CarregarDatagrid();
                    }
                }
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
