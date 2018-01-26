using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class CorpoNotaFiscalForm : Form
    {
        public static int IdNotaFiscal = new Int32();
        private NotaFiscalModel notaFiscalModel;
        private ProdutoNotaFiscalListModel produtoNotaFiscalListModel;
        private AcaoForm acaoForm;
        private bool ConfirmarLancamento = false;
        //
        private void PreencherTextBoxVazio()
        {
            this.txtTotalNotaFiscal.Text = PreencherTextBoxComZero(this.txtTotalNotaFiscal);
            this.txtTotalDespesas.Text = PreencherTextBoxComZero(this.txtTotalDespesas);
            this.txtTotalIcms.Text = PreencherTextBoxComZero(this.txtTotalIcms);
            this.txtTotalIpi.Text = PreencherTextBoxComZero(this.txtTotalIpi);
            this.txtValorTotalDosProdutos.Text = PreencherTextBoxComZero(this.txtValorTotalDosProdutos);
        }
        //
        private void CarregarDatagridProdutos()
        {
            try
            {
                this.dgvProdutos.DataSource = new NotaFiscalDAO().ProdutosNotaFiscalLista(new ProdutoNotaFiscalModel
                {
                    NotaFiscal = this.notaFiscalModel

                }).Select(x => new
                {
                    idProduto = x.Produto.IdProduto,
                    nomeProduto = x.Produto.NomeProduto,
                    quantidade = x.Quantidade,
                    quantidadeEmbalagem = x.QuantidadePorEmbalagem,
                    valorUnitario = x.ValorUnitario,
                    CustoSemImposto = x.CustoSemImposto,
                    CustoComImposto = x.CustoComImposto,
                    ValorIcmsSt = x.ValorTotalDoIcmsSt,
                    ValorIpi = x.ValorTotalDoIpi,
                    ValorDesconto = x.ValorTotalDoDesconto,
                    valorTotal = (x.Quantidade * x.ValorUnitario) + (x.ValorTotalDoIpi + x.ValorTotalDoIcmsSt - x.ValorTotalDoDesconto),
                    Observao = x.Observacao
                }).ToList();
                //
                var valorTotalDosProdutos = new Decimal();
                foreach (DataGridViewRow linha in this.dgvProdutos.Rows)
                {
                    valorTotalDosProdutos += Convert.ToDecimal(linha.Cells["clValorTotal"].Value);
                }
                //
                this.txtValorTotalDosProdutos.Text = valorTotalDosProdutos.ToString("C2");
            }
            catch (Exception)
            {

                throw;
            }
        }
        //
        private void BloquearControles()
        {
            try
            {
                this.txtNumeroNotaFiscal.ReadOnly = true;
                this.txtNumeroNotaFiscal.BackColor = Color.White;
                this.txtTotalDespesas.ReadOnly = true;
                this.txtTotalDespesas.BackColor = Color.White;
                this.txtTotalIcms.ReadOnly = true;
                this.txtTotalIcms.BackColor = Color.White;
                this.txtTotalIpi.ReadOnly = true;
                this.txtTotalIpi.BackColor = Color.White;
                this.txtTotalNotaFiscal.ReadOnly = true;
                this.txtTotalNotaFiscal.BackColor = Color.White;
                this.dtpDataEmissao.Enabled = false;
                this.dtpDataEntrada.Enabled = false;
                this.cbbEstabelecimento.Enabled = false;
                this.cbbEstabelecimento.BackColor = Color.White;
                this.cbbFornecedor.Enabled = false;
                this.cbbFornecedor.BackColor = Color.White;
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
        private void CarregarComboBoxFornecedores()
        {
            try
            {
                var listaFornecedores = new FornecedorListaModel();
                listaFornecedores.Add(new FornecedorModel
                {
                    IdFornecedor = 0,
                    NomeFornecedor = "[Selecione Fornecedor]"
                });
                //
                foreach (var fornecedor in new FornecedorDAO().ForncedorLista())
                {
                    listaFornecedores.Add(fornecedor);
                }
                this.cbbFornecedor.DataSource = listaFornecedores;
                this.cbbFornecedor.DisplayMember = "NomeFornecedor";
                this.cbbFornecedor.ValueMember = "IdFornecedor";

            }
            catch (Exception exception)
            {

                throw new Exception(string.Format("Erro ao carredar Fornecedores cadastrados !\nDetalhes: {0}", exception.Message));
            }
        }
        //
        public static string PreencherTextBoxComZero(TextBox txt)
        {
            var retorno = string.Empty;
            if (txt.Text.Trim() == string.Empty)
                retorno = new decimal(0.0).ToString("N2");
            else
            {
                try
                {
                    retorno = Convert.ToDecimal(txt.Text).ToString("N2");
                }
                catch (Exception)
                {
                    retorno = new decimal(0.0).ToString();
                }
            }
            //
            return retorno;
        }
        //
        public CorpoNotaFiscalForm(NotaFiscalModel notaFiscalModel, AcaoForm acaoForm)
        {
            try
            {
                InitializeComponent();
                this.notaFiscalModel = new NotaFiscalModel();
                this.produtoNotaFiscalListModel = new ProdutoNotaFiscalListModel();
                this.acaoForm = acaoForm;
                //
                this.CarregarComboBoxEstabelecimento();
                this.CarregarComboBoxFornecedores();
                this.PreencherTextBoxVazio();
                //
                switch (acaoForm)
                {
                    case AcaoForm.NovoLancamento:
                        this.Text = "Novo lançamento de compras";
                        break;
                    case AcaoForm.AlterarLancamento:
                        this.Text = "Alteração de lançamento de compras";
                        this.notaFiscalModel = notaFiscalModel;
                        this.txtNumeroNotaFiscal.Text = notaFiscalModel.NumeroNotaFiscal;
                        this.txtTotalDespesas.Text = notaFiscalModel.ValorTotalDasDespesas.ToString("N2");
                        this.txtTotalIcms.Text = notaFiscalModel.ValorTotalDoIcmsSt.ToString("N2");
                        this.txtTotalIpi.Text = notaFiscalModel.ValorTotalDoIpi.ToString("N2");
                        this.txtTotalNotaFiscal.Text = notaFiscalModel.ValorTotalDaNota.ToString("N2");
                        //
                        this.BloquearControles();
                        break;
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }
        //
        private void NovoProdutoButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.acaoForm)
                {
                    case AcaoForm.NovoLancamento:
                        if (this.notaFiscalModel.IdNotaFiscal == 0)
                        {
                            if (Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) == 0)
                            {
                                this.cbbEstabelecimento.Focus();
                                throw new Exception("Informe o Estabelecimento para continuar !");
                            }
                            else if (Convert.ToInt32(this.cbbFornecedor.SelectedValue) == 0)
                            {
                                this.cbbFornecedor.Focus();
                                throw new Exception("Informe o Fornecedor para continuar !");
                            }
                            else if (this.txtNumeroNotaFiscal.Text.Trim() == string.Empty)
                            {
                                this.txtNumeroNotaFiscal.Focus();
                                throw new Exception("Informe o Número da Nota Fiscal para continuar !");
                            }
                            else if (this.txtTotalNotaFiscal.Text.Trim() == string.Empty)
                            {
                                this.txtTotalNotaFiscal.Focus();
                                throw new Exception("Informe o valor total da Nota Fiscal para continuar !");
                            }
                            else if (Convert.ToDateTime(this.dtpDataEmissao.Value.ToShortDateString()) > Convert.ToDateTime(this.dtpDataEntrada.Value.ToShortDateString()))
                            {
                                throw new Exception("Data de entrada não pode ser maior que a data de Emissão !");
                            }
                            else if (this.dtpDataEmissao.Value > DateTime.Now)
                            {
                                this.dtpDataEmissao.Focus();
                                throw new Exception("Data de emissão não pode ser maior que a data Atual !");
                            }

                            this.notaFiscalModel = new NotaFiscalModel
                            {
                                Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) },
                                Fornecedor = new FornecedorModel { IdFornecedor = Convert.ToInt32(this.cbbFornecedor.SelectedValue) },
                                DataEmissaoInicial = this.dtpDataEmissao.Value,
                                DataEntradaInicial = this.dtpDataEntrada.Value,
                                NumeroNotaFiscal = this.txtNumeroNotaFiscal.Text,
                                ValorTotalDaNota = Convert.ToDecimal(PreencherTextBoxComZero(this.txtTotalNotaFiscal)),//Convert.ToDecimal(this.txtTotalNotaFiscal.Text),
                                ValorTotalDasDespesas = Convert.ToDecimal(PreencherTextBoxComZero(this.txtTotalDespesas)),
                                ValorTotalDoIcmsSt = Convert.ToDecimal(PreencherTextBoxComZero(this.txtTotalIcms)),
                                ValorTotalDoIpi = Convert.ToDecimal(PreencherTextBoxComZero(this.txtTotalIpi))
                            };
                            var retorno = new NotaFiscalDAO().NotaFiscalManter(notaFiscalModel);
                            //
                            if (Char.IsNumber(retorno, 0))
                            {
                                this.notaFiscalModel.IdNotaFiscal = Convert.ToInt32(retorno);//new NotaFiscalModel { IdNotaFiscal = IdNotaFiscal = Convert.ToInt32(retorno) };
                                using (var f = new ProdutoLancamentoNotaFiscalForm(new ProdutoNotaFiscalModel { NotaFiscal = this.notaFiscalModel }))
                                {                                    
                                    this.BloquearControles();
                                    f.ShowDialog();

                                }
                            }
                            else throw new Exception(retorno);
                        }
                        else
                        {
                            using (var f = new ProdutoLancamentoNotaFiscalForm(new ProdutoNotaFiscalModel { NotaFiscal = this.notaFiscalModel }))
                            {
                                this.BloquearControles();
                                f.ShowDialog();

                            }
                        }
                        break;
                    case AcaoForm.AlterarLancamento:
                        using (var f = new ProdutoLancamentoNotaFiscalForm(new ProdutoNotaFiscalModel { NotaFiscal = this.notaFiscalModel }))
                        {
                            f.ShowDialog();
                        }
                        break;
                }
                //
                this.CarregarDatagridProdutos();
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }
        //
        private void CorpoNotaFiscalForm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(this.txtValorTotalDosProdutos.Text.Replace("R$", "")) > Convert.ToDecimal(0.0))
                {
                    Mensagens.MensagemInformacao("Nota Fiscal de compra lançada com sucesso !");
                    this.ConfirmarLancamento = true;
                    var valorTotalDespesas = Convert.ToDecimal(this.txtTotalIcms.Text) +
                        Convert.ToDecimal(this.txtTotalIpi.Text) +
                        Convert.ToDecimal(this.txtTotalDespesas.Text);
                    if (valorTotalDespesas > Convert.ToDecimal(0.0))
                    {
                        using (var f = new DespesaBoletoForm(new DespesaModel
                        {
                            Valor = valorTotalDespesas,
                            Parceiro = new FornecedorModel { IdFornecedor = Convert.ToInt32(this.cbbFornecedor.SelectedValue) },
                            Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) },
                            DataMovimento = this.dtpDataEntrada.Value,
                            DescricaoDespesa = string.Format("IMPOSTOS DA NF:{0}", this.txtNumeroNotaFiscal.Text)
                        }))
                        {
                            f.ShowDialog();
                        }
                    }
                    this.Close();
                }
                else
                {
                    throw new Exception("Valor dos produtos da nota fiscal é igual á ZERO !\nVerifique os Produtos da nota fiscal para confirmar.");
                }
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void AlterarProdutoButton_Click(object sender, EventArgs e)
        {
            try
            {
                //var produtoNotaFiscal = ;
                //
                using (var f = new ProdutoLancamentoNotaFiscalForm(new NotaFiscalDAO().ProdutosNotaFiscalLista(new ProdutoNotaFiscalModel
                {
                    NotaFiscal = this.notaFiscalModel,
                    Produto = new ProdutoModel { IdProduto = Convert.ToInt32(this.dgvProdutos.CurrentRow.Cells["clCodigo"].Value) }

                }).Single()))
                {
                    //this.BloquearControles();
                    f.ShowDialog();
                    this.CarregarDatagridProdutos();
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void ExcluirProdutoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir este produto do lançamento ?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var retorno = new NotaFiscalDAO().ProdutoNotaFiscalManter(new ProdutoNotaFiscalModel
                    {
                        NotaFiscal = this.notaFiscalModel,
                        Produto = new ProdutoModel { IdProduto = Convert.ToInt32(this.dgvProdutos.CurrentRow.Cells["clCodigo"].Value) },
                        Quantidade = 0
                    });
                    //
                    if (retorno == "DELETE OK")
                    {
                        Mensagens.MensagemInformacao("Produto excluido com sucesso !");
                        this.CarregarDatagridProdutos();
                    }
                    else throw new Exception(retorno);
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void CorpoNotaFiscalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.acaoForm == AcaoForm.NovoLancamento && this.notaFiscalModel.IdNotaFiscal > 0 && ConfirmarLancamento == false)
                {
                    if (MessageBox.Show("Deseja realmente cancelar este lançamento ?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (this.notaFiscalModel != null)
                        {
                            this.notaFiscalModel.Fornecedor.IdFornecedor = 0;
                            this.notaFiscalModel.Estabelecimento.IdEstabelecimento = 0;
                            var retorno = new NotaFiscalDAO().NotaFiscalManter(this.notaFiscalModel);
                            if (retorno == "DELETE OK")
                            {
                                return;
                            }
                            else throw new Exception(retorno);
                        }
                    }
                    else e.Cancel = true;
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void txtNumeroNotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtTotalNotaFiscal_Leave(object sender, EventArgs e)
        {
            this.PreencherTextBoxVazio();
        }
        private void txtTotalNotaFiscal_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            this.PreencherTextBoxVazio();
        }

        private void txtTotalNotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (this.txtTotalNotaFiscal.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtTotalNotaFiscal.Text = "0,";
                            this.txtTotalNotaFiscal.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtTotalNotaFiscal.Text)
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

        private void txtTotalIcms_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (this.txtTotalIcms.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtTotalIcms.Text = "0,";
                            this.txtTotalIcms.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtTotalIcms.Text)
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

        private void txtTotalIpi_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (this.txtTotalIpi.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtTotalIpi.Text = "0,";
                            this.txtTotalIpi.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtTotalIpi.Text)
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

        private void txtTotalDespesas_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (this.txtTotalDespesas.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtTotalDespesas.Text = "0,";
                            this.txtTotalDespesas.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtTotalDespesas.Text)
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

        private void txtTotalIcms_Leave(object sender, EventArgs e)
        {
            this.PreencherTextBoxVazio();
        }

        private void txtTotalIpi_Leave(object sender, EventArgs e)
        {
            this.PreencherTextBoxVazio();
        }

        private void txtTotalDespesas_Leave(object sender, EventArgs e)
        {
            this.PreencherTextBoxVazio();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            using (var fornecedorForm = new FornecedorPrincipalForm())
            {
                fornecedorForm.ShowDialog();
                this.CarregarComboBoxFornecedores();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CorpoNotaFiscalForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToChar(e.KeyData) == Convert.ToChar(Keys.F3))
                {
                    this.ConfirmarButton.PerformClick();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
