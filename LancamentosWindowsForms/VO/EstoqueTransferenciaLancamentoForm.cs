using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class EstoqueTransferenciaLancamentoForm : Form
    {
        EstoqueTransferenciaModel estoqueTransferenciaModel;// = new EstoqueTransferenciaModel();
        ProdutoModel produtoModel = new ProdutoModel();

        public EstoqueTransferenciaLancamentoForm()
        {
            try
            {
                InitializeComponent();
                //
                this.CarregarComboBoxEstabelecimentoOrigem();
                this.CarregarComboBoxEstabelecimentoDestino();
                this.estoqueTransferenciaModel = new EstoqueTransferenciaModel();
                this.rdbUltimoCusto.Checked = true;
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }
        //
        private void CarregarProduto()
        {
            try
            {
                if (this.txtCodigo.Text.Trim() != string.Empty)
                {
                    if (Convert.ToInt32(this.cbbEstabelecimentoOrigem.SelectedValue) == 0)
                    {
                        throw new Exception("Informe o estabelecimento de origem !");
                    }
                    foreach (DataRow dtRow in new ProdutoDAO().ProdutoListByAll(this.txtCodigo.Text, Convert.ToInt32(this.cbbEstabelecimentoOrigem.SelectedValue)).Rows)
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
                        ProdutoLancamentoNotaFiscalForm.idProdutoAux = new Int32();
                        this.txtCusto.Text = this.produtoModel.PrecoCusto.ToString("N2");
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
        //
        private void CarregarComboBoxEstabelecimentoOrigem()
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
                this.cbbEstabelecimentoOrigem.DataSource = listaEstabelecimento;
                this.cbbEstabelecimentoOrigem.DisplayMember = "NomeEstabelecimento";
                this.cbbEstabelecimentoOrigem.ValueMember = "IdEstabelecimento";

            }
            catch (Exception exception)
            {

                throw new Exception(string.Format("Erro ao carregar Estabelecimentos Origem !\nDetalhes: {0}", exception.Message));
            }
        }
        //
        private void CalcularQuantidade()
        {
            this.txtQuantidadeEmbalagem.Text = CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtQuantidadeEmbalagem);
            this.txtQuantidade.Text = CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtQuantidade);
            //
            var quantidadeTotal = Convert.ToDecimal(CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtQuantidade)) *
                Convert.ToDecimal(CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtQuantidadeEmbalagem));
            //
            this.txtQuantidadeTotal.Text = quantidadeTotal.ToString("N2");
        }
        //
        private void CarregarComboBoxEstabelecimentoDestino()
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
                this.cbbEstabelecimentoDestino.DataSource = listaEstabelecimento;
                this.cbbEstabelecimentoDestino.DisplayMember = "NomeEstabelecimento";
                this.cbbEstabelecimentoDestino.ValueMember = "IdEstabelecimento";

            }
            catch (Exception exception)
            {

                throw new Exception(string.Format("Erro ao carregar Estabelecimentos Destino !\nDetalhes: {0}", exception.Message));
            }
        }

        private void EstoqueTransferenciaLancamentoForm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnProduto_Click(object sender, EventArgs e)
        {
            using (var f = new ProdutoDataGridForm())
            {
                f.ShowDialog();
                try
                {
                    this.txtCodigo.Text = ProdutoLancamentoNotaFiscalForm.idProdutoAux.ToString();
                    this.CarregarProduto();
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
                    if (e.KeyChar == Convert.ToChar(Keys.Enter) && this.txtCodigo.Text.Trim() != string.Empty)
                    {
                        //ProdutoLancamentoNotaFiscalForm.idProdutoAux = Convert.ToInt32(this.txtCodigo.Text);
                        this.CarregarProduto();
                        //
                        this.estoqueTransferenciaModel.Produto = this.produtoModel;
                        this.txtQuantidade.Focus();
                        this.txtQuantidade.SelectAll();

                    }
                }
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
                if (Convert.ToInt32(this.cbbEstabelecimentoOrigem.SelectedValue) == 0)
                {
                    throw new Exception("Selecinone o Estabelecimento de Origem !");
                }
                else if (Convert.ToInt32(this.cbbEstabelecimentoDestino.SelectedValue) == 0)
                {
                    throw new Exception("Selecinone o Estabelecimento de Destino !");
                }
                else if (this.dtpMovimento.Value > DateTime.Now)
                {
                    this.dtpMovimento.Focus();
                    throw new Exception("Data do Movimento não pode ser maior que a data atual !");
                }
                else if (Convert.ToDecimal(CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtQuantidade)) == Convert.ToDecimal(0.0))
                {
                    this.txtQuantidade.Focus();
                    this.txtQuantidade.SelectAll();
                    throw new Exception("Informe uma a quantidade maior que ZERO !");
                }
                else if (Convert.ToInt32(this.cbbEstabelecimentoOrigem.SelectedValue) == Convert.ToInt32(this.cbbEstabelecimentoDestino.SelectedValue))
                {
                    throw new Exception("Estabelecimento de Destino e Origem não podem ser iguais !");
                }
                else if (Convert.ToDecimal(this.txtQuantidadeEmbalagem.Text) == Convert.ToDecimal(0.0))
                {
                    this.txtQuantidadeEmbalagem.Text = "1";
                }
                else
                {
                    this.estoqueTransferenciaModel.EstabelecimentoOrigem = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimentoOrigem.SelectedValue) };
                    this.estoqueTransferenciaModel.EstabelecimentoDestino = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimentoDestino.SelectedValue) };
                    this.estoqueTransferenciaModel.DataMovimentoInicial = Convert.ToDateTime(this.dtpMovimento.Value);
                    this.estoqueTransferenciaModel.QuantidadeTotal = Convert.ToDecimal(this.txtQuantidadeTotal.Text);
                    if (this.rdbUltimoCusto.Checked == true)
                        this.CarregarProduto();
                    else if (this.rdbCustoDigitado.Checked == true)
                    {
                        if (this.txtCusto.Text == string.Empty)
                            throw new Exception("Informe o custo unitário !");
                        //else if (Convert.ToDecimal(this.txtCusto.Text) < this.estoqueTransferenciaModel.Produto.PrecoCusto)
                           // throw new Exception("Custo do produto não pode ser menor que o custo atual !");
                        else
                        {
                            this.produtoModel.PrecoCusto = Convert.ToDecimal(this.txtCusto.Text);
                            this.estoqueTransferenciaModel.Produto = this.produtoModel;
                        }
                    }
                    //
                    var retorno = new EstoqueTransferenciaDAO().EstoqueTransferenciaManter(this.estoqueTransferenciaModel);
                    if (retorno == "INSERT OK")
                    {
                        Mensagens.MensagemInformacao("Transferência lançada com sucesso !");
                        if (MessageBox.Show("Deseja lançar mais transferencias entre os estabelecimentos ?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
                        {
                            this.Close();
                        }
                        else
                        {
                            this.cbbEstabelecimentoOrigem.Enabled = false;
                            this.cbbEstabelecimentoDestino.Enabled = false;
                            this.txtQuantidade.Clear();
                            this.txtQuantidadeEmbalagem.Text = "1";
                            this.txtQuantidadeTotal.Clear();
                            this.txtCusto.Clear();
                            this.rdbUltimoCusto.Checked = true;
                            this.txtCodigo.Focus();
                            this.txtCodigo.Clear();
                            this.txtNomeProduto.Clear();
                            
                        }
                        
                    }
                    else
                    {
                        throw new Exception(retorno);
                    }
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            this.CalcularQuantidade();
        }

        private void txtQuantidadeEmbalagem_Leave(object sender, EventArgs e)
        {
            this.CalcularQuantidade();
        }

        private void txtQuantidadeTotal_Leave(object sender, EventArgs e)
        {
            this.CalcularQuantidade();
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

        private void txtQuantidadeEmbalagem_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (this.txtQuantidadeEmbalagem.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtQuantidadeEmbalagem.Text = "0,";
                            this.txtQuantidadeEmbalagem.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtQuantidadeEmbalagem.Text)
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

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCodigo.Text.Trim() != string.Empty)
                {
                    ProdutoLancamentoNotaFiscalForm.idProdutoAux = Convert.ToInt32(this.txtCodigo.Text);
                    this.CarregarProduto();
                }
                //
                this.txtNomeProduto.Text = this.produtoModel.NomeProduto;
                this.estoqueTransferenciaModel.Produto = this.produtoModel;
                this.txtQuantidade.Focus();
                this.txtQuantidade.SelectAll();

            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void rdbUltimoCusto_CheckedChanged(object sender, EventArgs e)
        {
            this.lblCusto.Visible = false;
            this.txtCusto.Visible = false;
        }

        private void rdbCustoDigitado_CheckedChanged(object sender, EventArgs e)
        {
            this.lblCusto.Visible = true;
            this.txtCusto.Visible = true;
        }

        private void EstoqueTransferenciaLancamentoForm_KeyDown(object sender, KeyEventArgs e)
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
