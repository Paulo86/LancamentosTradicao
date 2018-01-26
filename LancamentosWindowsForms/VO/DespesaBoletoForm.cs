using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class DespesaBoletoForm : Form
    {
        DespesaModel despesaModel;
        //
        public DespesaBoletoForm(DespesaModel despesaModel)
        {
            try
            {
                InitializeComponent();
                this.CarregarComboBoxCategoriaLancamento();
                this.despesaModel = despesaModel;
                this.lblValorTaxa.Text = string.Format("Taxa: R$ {0}", despesaModel.Valor.ToString("N2"));
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }
        //
        private void CarregarComboboxSubcategoriaLancamento()
        {
            try
            {
                var listaSubcategoriaLancamento = new SubcategoriaLancamentoListModel();
                listaSubcategoriaLancamento.Add(new SubcategoriaLancamentoModel
                {
                    IdSubcategoria = 0,
                    NomeSubcategoria = "[Selecione a Subcategoria]"
                });
                //
                foreach (var subcategoria in new SubcategoriaLancamentoDAO().SubCategoriaByAll().Select(x => new
                {
                    idCategoria = x.CategoriaLancamento.IdCategoria,
                    idSubcategoria = x.IdSubcategoria,
                    nomeSubcategoria = x.NomeSubcategoria
                }).Where(x => x.idCategoria.Equals(Convert.ToInt32(this.cbbCategoria.SelectedValue))))
                {
                    listaSubcategoriaLancamento.Add(new SubcategoriaLancamentoModel
                    {
                        IdSubcategoria = Convert.ToInt32(subcategoria.idSubcategoria),
                        NomeSubcategoria = subcategoria.nomeSubcategoria.ToString()
                    });
                }
                //
                this.cbbSubcategoria.DataSource = listaSubcategoriaLancamento;
                this.cbbSubcategoria.DisplayMember = "NomeSubcategoria";
                this.cbbSubcategoria.ValueMember = "IdSubcategoria";
                this.cbbSubcategoria.Update();
            }
            catch (Exception)
            {

                return;
            }
        }
        //
        private void CarregarComboBoxCategoriaLancamento()
        {
            try
            {
                var listaCategoria = new CategoriaLancamentoListModel();
                listaCategoria.Add(new CategoriaLancamentoModel
                {
                    IdCategoria = 0,
                    NomeCategoria = "[Selecione a Categoria de Lançamento]"

                });


                foreach (var categoria in new CategoriaLancamentoDAO().CategoriaLancamentoList())
                {
                    listaCategoria.Add(categoria);
                }
                this.cbbCategoria.DataSource = listaCategoria;
                this.cbbCategoria.DisplayMember = "NomeCategoria";
                this.cbbCategoria.ValueMember = "IdCategoria";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cbbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.CarregarComboboxSubcategoriaLancamento();
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                using (var frmCategoria = new CategoriaLancamentoForm())
                {
                    frmCategoria.ShowDialog();
                    this.CarregarComboBoxCategoriaLancamento();
                }
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void btnSubcategoria_Click(object sender, EventArgs e)
        {
            try
            {
                using (var frmSubcategoria = new SubcategoriaLancamentoForm())
                {
                    frmSubcategoria.ShowDialog();
                    this.CarregarComboboxSubcategoriaLancamento();
                }
            }
            catch (Exception)
            {

                throw;
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
                if (Convert.ToInt32(this.cbbCategoria.SelectedValue) == 0)
                    throw new Exception("Informe a Categoria de Lançamento !");
                else if (Convert.ToInt32(this.cbbSubcategoria.SelectedValue) == 0)
                    throw new Exception("Informe a Subcategoria de Lançamento !");
                else
                {
                    this.despesaModel.CategoriaLancamento = new CategoriaLancamentoModel { IdCategoria = Convert.ToInt32(this.cbbCategoria.SelectedValue) };
                    this.despesaModel.SubcategoriaLancamento = new SubcategoriaLancamentoModel { IdSubcategoria = Convert.ToInt32(this.cbbSubcategoria.SelectedValue) };
                    var retorno = new DespesaDAO().DespesaManter(this.despesaModel);
                    //
                    switch (retorno)
                    {
                        case "INSERT OK":
                            Mensagens.MensagemInformacao("Despesa lançada com sucesso !");
                            this.Close();
                            break;
                        case "UPDATE OK":
                            Mensagens.MensagemInformacao("Lançamento de despesa alterado com sucesso !");
                            this.Close();
                            break;
                    }
                    //
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void DespesaBoletoForm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DespesaBoletoForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToChar(e.KeyData) == Convert.ToChar(Keys.F3))
                {
                    this.btnConfirmar.PerformClick();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
