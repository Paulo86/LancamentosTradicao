using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class DespesasLancamentoForm : Form
    {
        DespesaModel despesaModel;
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
        //
        private void CarregarComboBoxEstabelecimento()
        {
            try
            {
                var listaEstabelecimento = new EstabelecimentoListaModel();
                listaEstabelecimento.Add(new EstabelecimentoModel
                {
                    IdEstabelecimento = 0,
                    NomeEstabelecimento = "[Selecione o Estabelecimento]"
                });
                //
                foreach (var estabelecimento in new EstabelecimentoDAO().EstabelecimentoLista())
                {
                    listaEstabelecimento.Add(estabelecimento);
                }
                this.cbbEstabelecimento.DataSource = listaEstabelecimento;
                this.cbbEstabelecimento.DisplayMember = "NomeEstabelecimento";
                this.cbbEstabelecimento.ValueMember = "IdEstabelecimento";

            }
            catch (Exception exception)
            {

                throw new Exception(string.Format("Erro ao carredar Estabelecimentos cadastrados !\nDetalhes: {0}", exception.Message));
            }
        }
        //
        private void CarregarComboBoxParceiros()
        {
            try
            {
                var listaFornecedores = new FornecedorListaModel();
                listaFornecedores.Add(new FornecedorModel
                {
                    IdFornecedor = 0,
                    NomeFornecedor = "[Selecione o Fornecedor]"
                });
                //
                foreach (var fornecedor in new FornecedorDAO().ForncedorLista())
                {
                    listaFornecedores.Add(fornecedor);
                }
                this.cbbParceiro.DataSource = listaFornecedores;
                this.cbbParceiro.DisplayMember = "NomeFornecedor";
                this.cbbParceiro.ValueMember = "IdFornecedor";

            }
            catch (Exception exception)
            {

                throw new Exception(string.Format("Erro ao carregar Parceiros cadastrados !\nDetalhes: {0}", exception.Message));
            }
        }
        //
        public DespesasLancamentoForm(DespesaModel despesaModel)
        {
            try
            {
                InitializeComponent();
                this.CarregarComboBoxParceiros();
                this.CarregarComboBoxEstabelecimento();
                this.CarregarComboBoxCategoriaLancamento();
                //this.CarregarComboboxSubcategoriaLancamento();
                if (despesaModel == null)
                {
                    this.despesaModel = new DespesaModel();
                    this.Text = "Lançamento de nova despesa";
                }
                else
                {
                    this.despesaModel = despesaModel;
                    this.Text = "Alteraçao de lançamento de despesa";
                    this.txtDescricaoLancamento.Text = despesaModel.DescricaoDespesa;
                    this.cbbEstabelecimento.SelectedValue = despesaModel.Estabelecimento.IdEstabelecimento;
                    this.cbbCategoria.SelectedValue = despesaModel.CategoriaLancamento.IdCategoria;
                    this.cbbSubcategoria.SelectedValue = despesaModel.SubcategoriaLancamento.IdSubcategoria;
                    this.cbbParceiro.SelectedValue = despesaModel.Parceiro.IdFornecedor;
                    this.dtpDataMovimento.Value = despesaModel.DataMovimento;
                    this.txtValor.Text = despesaModel.Valor.ToString("N2");

                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void DespesasLancamentoForm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnParceiro_Click(object sender, EventArgs e)
        {
            using (var frmParceiro = new FornecedorPrincipalForm())
            {
                frmParceiro.ShowDialog();
                this.CarregarComboBoxParceiros();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtDescricaoLancamento.Text.Trim() == string.Empty)
                    throw new Exception("Informe a descrição do movimento !");
                else if (Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) == 0)
                    throw new Exception("Informe o Estabelecimento !");
                else if (Convert.ToInt32(this.cbbCategoria.SelectedValue) == 0)
                    throw new Exception("Informe a Categoria de Lançamento !");
                else if (Convert.ToInt32(this.cbbSubcategoria.SelectedValue) == 0)
                    throw new Exception("Informe a Subcategoria de Lançamento !");
                else if (Convert.ToInt32(this.cbbParceiro.SelectedValue) == 0)
                    throw new Exception("Informe o Parceiro !");
                else if (this.txtValor.Text.Trim() == string.Empty)
                    throw new Exception("Informe o Valor do Lançamento !");
                else
                {
                    var retorno = new DespesaDAO().DespesaManter(new DespesaModel
                    {
                        CategoriaLancamento = new CategoriaLancamentoModel { IdCategoria = Convert.ToInt32(this.cbbCategoria.SelectedValue) },
                        SubcategoriaLancamento = new SubcategoriaLancamentoModel { IdSubcategoria = Convert.ToInt32(this.cbbSubcategoria.SelectedValue) },
                        DataMovimento = this.dtpDataMovimento.Value,
                        DescricaoDespesa = this.txtDescricaoLancamento.Text.ToUpper(),
                        IdDespesa = this.despesaModel.IdDespesa,
                        Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) },
                        Parceiro = new FornecedorModel { IdFornecedor = Convert.ToInt32(this.cbbParceiro.SelectedValue) },
                        Valor = Convert.ToDecimal(this.txtValor.Text)
                    });
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
                        default:
                            Mensagens.MensagemInformacao(string.Format("EROOOOOOLLL !\n{0}", retorno));
                            break;
                    }
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            this.txtValor.Text = CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtValor);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                else
                {
                    if (e.KeyChar == ',')
                    {
                        if (this.txtValor.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtValor.Text = "0,";
                            this.txtValor.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtValor.Text)
                            {
                                if (item == Convert.ToChar(','))
                                {
                                    e.Handled = true;
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void DespesasLancamentoForm_KeyDown(object sender, KeyEventArgs e)
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
