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
    public partial class BoletosLancamentoForm : Form
    {
        LancamentoModel lancamentoModel;
        AcaoForm acaoForm;
        //
        public BoletosLancamentoForm(AcaoForm acaoForm, LancamentoModel lancamentoModel)
        {
            try
            {
                InitializeComponent();
                this.acaoForm = acaoForm;                
                this.CarregarComboBoxFornecedores();
                this.CarregarComboBoxEstabelecimento();
                //
                switch (acaoForm)
                {
                    case AcaoForm.NovoLancamento:
                        this.Text = "LANÇAMENTO DE NOVO BOLETO";
                        this.lancamentoModel = new LancamentoModel();
                        break;
                    case AcaoForm.AlterarLancamento:
                        this.lancamentoModel = lancamentoModel;
                        this.Text = string.Format("ALTERAÇÃO DE LANÇAMENTO - BOLETO N. {0}", lancamentoModel.NumeroDocumento);
                        this.cbbEstabelecimento.SelectedValue = lancamentoModel.Estabelecimento.IdEstabelecimento;
                        this.cbbFornecedor.SelectedValue = lancamentoModel.Fornecedor.IdFornecedor;
                        this.dtpDataEntrada.Value = lancamentoModel.DataEntradaInicial;
                        this.dtpDataVencimento.Value = lancamentoModel.DataVencimentoInicial;
                        this.txtValorTotal.Text = lancamentoModel.ValorTotal.ToString();
                        this.txtNumeroDocumento.Text = lancamentoModel.NumeroDocumento;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("{0}", exception.Message));
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
                    NomeFornecedor = "Selecione o Fornecedor..."
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
        private void CarregarComboBoxEstabelecimento()
        {
            try
            {
                var listaEstabelecimento = new EstabelecimentoListaModel();
                listaEstabelecimento.Add(new EstabelecimentoModel
                {
                    IdEstabelecimento = 0,
                    NomeEstabelecimento = "(Selecione o Estabelecimento)"
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
        private LancamentoModel ValidarLancamento(LancamentoModel lancamentoModel)
        {
            try
            {
                if (Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) == 0)
                    throw new Exception("Informe o Estabelecimento do Documento !");
                else if (Convert.ToInt32(this.cbbFornecedor.SelectedValue) == 0)
                    throw new Exception("Informe o Fornecedor do Documento !");
                else if (string.IsNullOrEmpty(this.txtNumeroDocumento.Text.Trim()))
                    throw new Exception("Informe o número do Documento !");
                else if (Convert.ToDecimal(this.txtValorTotal.Text) < 1)
                    throw new Exception("Informe o valor do Documento !");
                else if (this.dtpDataEntrada.Value > this.dtpDataVencimento.Value)
                    throw new Exception("Data de entrada não pode ser maior que a data de Vencimento !");
                return lancamentoModel;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void LancamentoForm_KeyPress(object sender, KeyPressEventArgs e)
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
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            using (var fornecedorForm = new FornecedorPrincipalForm())
            {
                fornecedorForm.ShowDialog();
                this.CarregarComboBoxFornecedores();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtValorTotal.Text.Trim()))
                    this.txtValorTotal.Text = Convert.ToDecimal(0).ToString();
                //
                var retorno = new LancamentoDAO().LancamentoInserir(this.ValidarLancamento(new LancamentoModel
                {
                    IdLancamento = this.lancamentoModel.IdLancamento,
                    DataEntradaInicial = Convert.ToDateTime(this.dtpDataEntrada.Value),
                    DataVencimentoInicial = Convert.ToDateTime(this.dtpDataVencimento.Value),
                    Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) },
                    Fornecedor = new FornecedorModel { IdFornecedor = Convert.ToInt32(this.cbbFornecedor.SelectedValue) },
                    NumeroDocumento = this.txtNumeroDocumento.Text,
                    ValorTotal = Convert.ToDecimal(this.txtValorTotal.Text)
                }));
                //
                if (Char.IsNumber(retorno, 0))
                {
                    MessageBox.Show("Lançamento de boleto efetuado com sucesso !");
                    this.Close();
                }
                else
                {
                    throw new Exception(retorno);
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(string.Format("Erro no lançamento do Boleto!\nDetalhes: {0}", exception.Message));
            }
        }

        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            this.txtValorTotal.Text = CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtValorTotal);
        }

        private void txtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (this.txtValorTotal.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtValorTotal.Text = "0,";
                            this.txtValorTotal.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtValorTotal.Text)
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

        private void cbbEstabelecimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.ProcessTabKey(true);
            }
        }

        private void BoletosLancamentoForm_KeyDown(object sender, KeyEventArgs e)
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
