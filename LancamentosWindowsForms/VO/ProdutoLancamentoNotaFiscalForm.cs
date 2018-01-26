using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class ProdutoLancamentoNotaFiscalForm : Form
    {
        public static Int32 idProdutoAux = new Int32();
        NotaFiscalModel notaFiscalModel;
        ProdutoModel produtoModel;
        //
        //
        private void CalcularCusto()
        {
            try
            {
                this.txtQuantidade.Text = CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtQuantidade);
                if (Convert.ToDecimal(CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtQuantidadeEmbalagem)) == Convert.ToDecimal(0.0))
                    this.txtQuantidadeEmbalagem.Text = Convert.ToDecimal(1).ToString();
                this.txtValorUnitario.Text = CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtValorUnitario);
                this.txtValorIcmsSt.Text = CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtValorIcmsSt);
                this.txtVAlorIpi.Text = CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtVAlorIpi);
                this.txtValorDesconto.Text = CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtValorDesconto);
                //
                this.txtQuantidadeTotal.Text = (Convert.ToDecimal(this.txtQuantidade.Text) *
                    Convert.ToDecimal(this.txtQuantidadeEmbalagem.Text)).ToString("G", NumberFormatInfo.CurrentInfo);
                //
                var valorTotal = Convert.ToDecimal(this.txtValorUnitario.Text) *
                    Convert.ToDecimal(this.txtQuantidade.Text);
                //
                var custoSemImposto = (valorTotal - Convert.ToDecimal(this.txtValorDesconto.Text)) /
                    Convert.ToDecimal(this.txtQuantidadeTotal.Text);
                //
                var custoComImposto = (valorTotal - Convert.ToDecimal(this.txtValorDesconto.Text)
                    + Convert.ToDecimal(this.txtVAlorIpi.Text) +
                    Convert.ToDecimal(this.txtValorIcmsSt.Text)) /
                    Convert.ToDecimal(this.txtQuantidadeTotal.Text);
                //
                this.txtCustoSemImposto.Text = custoSemImposto.ToString("C2");
                this.txtCustoComImposto.Text = custoComImposto.ToString("C2");
                this.txtValorTotalProduto.Text = (custoComImposto * Convert.ToDecimal(this.txtQuantidadeTotal.Text)).ToString("C2");

            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }
        //
        private void LimparCampos()
        {
            try
            {
                this.txtCodigo.Clear();
                this.txtNomeProduto.Clear();
                this.txtQuantidade.Clear();
                this.txtQuantidadeEmbalagem.Text = "1";
                this.txtValorUnitario.Clear();
                this.txtCustoSemImposto.Clear();
                this.txtCustoComImposto.Clear();
                this.txtValorIcmsSt.Clear();
                this.txtVAlorIpi.Clear();
                this.txtValorDesconto.Clear();
                this.txtObservacao.Clear();

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CarregarProduto()
        {
            try
            {
                if (this.txtCodigo.Text.Trim() != string.Empty)
                {
                    foreach (DataRow dtRow in new ProdutoDAO().ProdutoListByAll(this.txtCodigo.Text, this.notaFiscalModel.Estabelecimento.IdEstabelecimento).Rows)
                    {
                        this.produtoModel = new ProdutoModel
                        {
                            IdProduto = Convert.ToInt32(dtRow["id_produto"]),
                            NomeProduto = dtRow["nome_produto"].ToString(),
                            Departamento = new DepartamentoProdutoModel
                            {
                                IdDepartamento = Convert.ToInt32(dtRow["id_departamento"]),
                                NomeDepartamento = dtRow["nome_departamento"].ToString()
                            },
                            PrecoCusto = Convert.ToDecimal(dtRow["preco_custo"]),
                            PrecoVenda = Convert.ToDecimal(dtRow["preco_venda"])
                        };
                        // var produto = new ProdutoDAO().ProdutoListByAll(idProdutoAux.ToString()).Single();
                        this.txtCodigo.Text = this.produtoModel.IdProduto.ToString();
                        this.txtNomeProduto.Text = this.produtoModel.NomeProduto;
                        //
                        //this.produtoModel = produto;
                        idProdutoAux = new Int32();
                        this.txtQuantidade.Focus();
                        this.txtQuantidade.SelectAll();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ProdutoLancamentoNotaFiscalForm(ProdutoNotaFiscalModel produtoNotaFiscalModel)
        {
            try
            {
                InitializeComponent();
                //
                this.notaFiscalModel = produtoNotaFiscalModel.NotaFiscal;
                //
                if (produtoNotaFiscalModel.Produto.IdProduto > 0)
                {
                    this.txtCodigo.Text = produtoNotaFiscalModel.Produto.IdProduto.ToString();
                    foreach (DataRow dtRow in new ProdutoDAO().ProdutoListByAll(this.txtCodigo.Text, this.notaFiscalModel.Estabelecimento.IdEstabelecimento).Rows)
                    {
                        this.produtoModel = new ProdutoModel
                        {
                            IdProduto = Convert.ToInt32(dtRow["id_produto"]),
                            NomeProduto = dtRow["nome_produto"].ToString(),
                            Departamento = new DepartamentoProdutoModel
                            {
                                IdDepartamento = Convert.ToInt32(dtRow["id_departamento"]),
                                NomeDepartamento = dtRow["nome_departamento"].ToString()
                            },
                            PrecoCusto = Convert.ToDecimal(dtRow["preco_custo"]),
                            PrecoVenda = Convert.ToDecimal(dtRow["preco_venda"])
                        };
                    }
                    //this.produtoModel = new ProdutoDAO().ProdutoListByAll(this.txtCodigo.Text).Single();
                    //
                    this.txtNomeProduto.Text = this.produtoModel.NomeProduto;
                    this.txtQuantidade.Text = produtoNotaFiscalModel.Quantidade.ToString("N2");
                    this.txtQuantidadeEmbalagem.Text = produtoNotaFiscalModel.QuantidadePorEmbalagem.ToString("N2");
                    this.txtValorUnitario.Text = produtoNotaFiscalModel.ValorUnitario.ToString("N2");
                    this.txtCustoSemImposto.Text = produtoNotaFiscalModel.CustoSemImposto.ToString("N2");
                    this.txtCustoComImposto.Text = produtoNotaFiscalModel.CustoComImposto.ToString("N2");
                    this.txtValorIcmsSt.Text = produtoNotaFiscalModel.ValorTotalDoIcmsSt.ToString("N2");
                    this.txtVAlorIpi.Text = produtoNotaFiscalModel.ValorTotalDoIpi.ToString("N2");
                    this.txtValorDesconto.Text = produtoNotaFiscalModel.ValorTotalDoDesconto.ToString("N2");
                    this.txtObservacao.Text = produtoNotaFiscalModel.Observacao.ToString();
                    this.Text = "Alteração de lançamento de produto";
                    this.txtCodigo.ReadOnly = true;
                    this.txtCodigo.BackColor = Color.White;
                    this.txtNomeProduto.ReadOnly = true;
                    this.txtNomeProduto.BackColor = Color.White;
                    this.btnProduto.Enabled = false;
                    this.CalcularCusto();
                }
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            using (var f = new ProdutoDataGridForm())
            {
                f.ShowDialog();
                try
                {
                    if (idProdutoAux > 0)
                    {
                        foreach (DataRow dtRow in new ProdutoDAO().ProdutoListByAll(idProdutoAux.ToString(), this.notaFiscalModel.Estabelecimento.IdEstabelecimento).Rows)
                        {
                            this.produtoModel = new ProdutoModel
                            {
                                IdProduto = Convert.ToInt32(dtRow["id_produto"]),
                                NomeProduto = dtRow["nome_produto"].ToString(),
                                Departamento = new DepartamentoProdutoModel
                                {
                                    IdDepartamento = Convert.ToInt32(dtRow["id_departamento"]),
                                    NomeDepartamento = dtRow["nome_departamento"].ToString()
                                },
                                PrecoCusto = Convert.ToDecimal(dtRow["preco_custo"]),
                                PrecoVenda = Convert.ToDecimal(dtRow["preco_venda"])
                            };
                            // var produto = new ProdutoDAO().ProdutoListByAll(idProdutoAux.ToString()).Single();
                            this.txtCodigo.Text = this.produtoModel.IdProduto.ToString();
                            this.txtNomeProduto.Text = this.produtoModel.NomeProduto;
                            //
                            //this.produtoModel = produto;
                            idProdutoAux = new Int32();
                            this.txtQuantidade.Focus();
                            this.txtQuantidade.SelectAll();
                        }
                    }
                }
                catch (Exception exception)
                {
                    Mensagens.MensagemErro(string.Format("Erro ao pesquisar Produto !\nDetalhes: {0}", exception.Message));
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != Convert.ToChar(Keys.Enter))
                {
                    e.Handled = true;
                }
                else
                {
                    if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    {
                        //idProdutoAux = Convert.ToInt32(this.txtCodigo.Text);
                        this.CarregarProduto();
                    }
                }
            }
            catch (Exception)
            {
                Mensagens.MensagemErro("produto não encontrado !");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProdutoNotaFiscalForm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtQuantidade)) == 0)
                {
                    this.txtQuantidade.Focus();
                    throw new Exception("Quantidade não pode ser ZERO !");
                }
                else if (Convert.ToDecimal(CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtQuantidadeEmbalagem)) == 0)
                {
                    this.txtQuantidadeEmbalagem.Focus();
                    throw new Exception("Quantidade por Embalagem não pode ser ZERO !");
                }
                else if (Convert.ToDecimal(CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtValorUnitario)) == Convert.ToDecimal(0))
                {
                    this.txtValorUnitario.Focus();
                    this.txtValorUnitario.SelectAll();
                    throw new Exception("Custo unitário não pode ser igual á ZERO !");
                }
                else
                {
                    var retorno = new NotaFiscalDAO().ProdutoNotaFiscalManter(new ProdutoNotaFiscalModel
                    {
                        NotaFiscal = this.notaFiscalModel,
                        Produto = this.produtoModel,
                        Quantidade = Convert.ToDecimal(this.txtQuantidade.Text),
                        QuantidadePorEmbalagem = Convert.ToDecimal(this.txtQuantidadeEmbalagem.Text),
                        ValorUnitario = Convert.ToDecimal(this.txtValorUnitario.Text),
                        CustoSemImposto = Convert.ToDecimal(this.txtCustoSemImposto.Text.Replace("R$", "")),
                        CustoComImposto = Convert.ToDecimal(this.txtCustoComImposto.Text.Replace("R$", "")),
                        ValorTotalDoDesconto = Convert.ToDecimal(this.txtValorDesconto.Text),
                        ValorTotalDoIcmsSt = Convert.ToDecimal(this.txtValorIcmsSt.Text),
                        ValorTotalDoIpi = Convert.ToDecimal(this.txtVAlorIpi.Text),
                        Observacao = this.txtObservacao.Text
                    });
                    //
                    switch (retorno)
                    {
                        case "INSERT OK":
                            Mensagens.MensagemInformacao("Produto gravado com Sucesso !");
                            this.Close();
                            break;
                        case "UPDATE OK":
                            Mensagens.MensagemInformacao("Produto atualizado com Sucesso !");
                            this.Close();
                            break;
                        default:
                            Mensagens.MensagemErro(retorno);
                            break;
                    }
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCodigo.Text.Trim() != string.Empty)
                {
                    //var produto = new ProdutoDAO().ProdutoListByAll(this.txtCodigo.Text).Single();
                    foreach (DataRow dtRow in new ProdutoDAO().ProdutoListByAll(this.txtCodigo.Text, this.notaFiscalModel.Estabelecimento.IdEstabelecimento).Rows)
                    {
                        this.produtoModel = new ProdutoModel
                        {
                            IdProduto = Convert.ToInt32(dtRow["id_produto"]),
                            NomeProduto = dtRow["nome_produto"].ToString(),
                            Departamento = new DepartamentoProdutoModel
                            {
                                IdDepartamento = Convert.ToInt32(dtRow["id_departamento"]),
                                NomeDepartamento = dtRow["nome_departamento"].ToString()
                            },
                            PrecoCusto = Convert.ToDecimal(dtRow["preco_custo"]),
                            PrecoVenda = Convert.ToDecimal(dtRow["preco_venda"])
                        };
                        //this.txtNomeProduto.Text = produto.NomeProduto;
                        //
                        //this.produtoModel = produto;
                        this.txtQuantidade.Focus();
                        this.txtQuantidade.SelectAll();
                    }

                }
            }
            catch (Exception)
            {
                Mensagens.MensagemErro("produto não encontrado !");
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            this.CalcularCusto();
        }

        private void txtQuantidadeEmbalagem_Leave(object sender, EventArgs e)
        {
            this.CalcularCusto();
        }

        private void txtValorDesconto_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (this.txtValorDesconto.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtValorDesconto.Text = "0,";
                            this.txtValorDesconto.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtValorDesconto.Text)
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

        private void txtValorIcmsSt_Leave(object sender, EventArgs e)
        {
            this.CalcularCusto();
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (this.txtQuantidade.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtQuantidade.Text = "0,";
                            this.txtQuantidade.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtQuantidade.Text)
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

        private void txtValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (this.txtValorUnitario.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtValorUnitario.Text = "0,";
                            this.txtValorUnitario.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtValorUnitario.Text)
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

        private void txtValorIcmsSt_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (this.txtValorIcmsSt.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtValorIcmsSt.Text = "0,";
                            this.txtValorIcmsSt.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtValorIcmsSt.Text)
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

        private void txtVAlorIpi_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (this.txtVAlorIpi.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtVAlorIpi.Text = "0,";
                            this.txtVAlorIpi.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtVAlorIpi.Text)
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

        private void txtValorDesconto_KeyPress_1(object sender, KeyPressEventArgs e)
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
                        if (this.txtValorDesconto.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtValorDesconto.Text = "0,";
                            this.txtValorDesconto.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtValorDesconto.Text)
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

        private void ProdutoLancamentoNotaFiscalForm_KeyDown(object sender, KeyEventArgs e)
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
