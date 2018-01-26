using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class BoletosLiquidarForm : Form
    {
        LancamentoModel lancamentoModel;
        //
        public BoletosLiquidarForm(LancamentoModel lancamentoModel)
        {
            InitializeComponent();
            this.lancamentoModel = lancamentoModel;
            this.txtValorPago.Text = lancamentoModel.ValorTotal.ToString("N2");
        }

        private void LiquidarLancamentoForm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtValorPago.Text.Trim() != string.Empty)
                {
                    var retorno = string.Empty;
                    //
                    retorno = new LancamentoDAO().LancamentoInserir(new LancamentoModel
                    {
                        IdLancamento = this.lancamentoModel.IdLancamento,
                        DataLiquidacao = Convert.ToDateTime(this.dtpDataPagamento.Value),
                        ValorLiquidado = Convert.ToDecimal(this.txtValorPago.Text)
                    });
                    //
                    if (Char.IsNumber(retorno, 0))
                    {
                        Mensagens.MensagemInformacao("Título liquídado com sucesso !");
                        if (Convert.ToDecimal(this.txtValorPago.Text) > this.lancamentoModel.ValorTotal)
                            using (var f = new DespesaBoletoForm(new DespesaModel
                            {
                                Valor = Convert.ToDecimal(this.txtValorPago.Text) - this.lancamentoModel.ValorTotal,
                                Parceiro = this.lancamentoModel.Fornecedor,
                                Estabelecimento = this.lancamentoModel.Estabelecimento,
                                DataMovimento = this.dtpDataPagamento.Value,
                                DescricaoDespesa = string.Format("TAXA BOL.{0} FORN.{1}", this.lancamentoModel.NumeroDocumento,
                                this.lancamentoModel.Fornecedor.NomeFornecedor)
                            }))
                            {
                                f.ShowDialog();
                            }
                        this.Close();
                    }
                    else
                    {
                        throw new Exception(string.Format("Erro ao líquidar lançamento !\n{0}", retorno));
                    }
                }
                else
                {
                    throw new Exception("Erro ao liquidar Lançamento !\nValor pago é Obrigatório.");
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            this.txtValorPago.Text = CorpoNotaFiscalForm.PreencherTextBoxComZero(this.txtValorPago);
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (this.txtValorPago.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtValorPago.Text = "0,";
                            this.txtValorPago.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtValorPago.Text)
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

        private void BoletosLiquidarForm_KeyDown(object sender, KeyEventArgs e)
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
