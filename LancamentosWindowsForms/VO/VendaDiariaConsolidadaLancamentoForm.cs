using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class VendaDiariaConsolidadaLancamentoForm : Form
    {
        VendaConsolidadaModel vendaConsolidadaModel;
        //
        private void CalcularTotalVenda()
        {
            try
            {
                var valorAcougue = new decimal();
                var valorMercearia = new decimal();
                //
                if (this.txtValorMercearia.Text.Trim() == string.Empty)
                    valorMercearia = 0;
                else
                    valorMercearia = Convert.ToDecimal(this.txtValorMercearia.Text);
                //
                if (this.txtValorAcougue.Text.Trim() == string.Empty)
                    valorAcougue = 0;
                else
                    valorAcougue = Convert.ToDecimal(this.txtValorAcougue.Text);
                this.txtValorMercearia.Text = valorMercearia.ToString("N2");
                this.txtValorAcougue.Text = valorAcougue.ToString("N2");
                this.lblValorTotal.Text = string.Format("Valor total R$ {0}", (valorAcougue + valorMercearia).ToString("N2"));
            }
            catch (Exception)
            {

                throw;
            }
        }
        //
        public VendaDiariaConsolidadaLancamentoForm(VendaConsolidadaModel vendaConsolidadaModel)
        {
            try
            {
                this.InitializeComponent();
                this.CarregarComboBoxEstabelecimento();
                //
                if (vendaConsolidadaModel == null)
                {
                    this.vendaConsolidadaModel = new VendaConsolidadaModel();
                    this.Text = "Novo lançamento de venda diária";
                }
                else
                {
                    this.vendaConsolidadaModel = vendaConsolidadaModel;
                    this.cbbEstabelecimento.SelectedValue = vendaConsolidadaModel.Estabelecimento.IdEstabelecimento;
                    this.dtpDataMovimento.Value = vendaConsolidadaModel.DataMovimento;
                    this.txtValorMercearia.Text = vendaConsolidadaModel.ValorMercearia.ToString("N2");
                    this.txtValorAcougue.Text = vendaConsolidadaModel.ValorAcougue.ToString("N2");
                    this.lblValorTotal.Text = string.Format("Valor total R$ {0}", (vendaConsolidadaModel.ValorAcougue + vendaConsolidadaModel.ValorMercearia).ToString("N2"));
                    this.Text = "alteração de lançamento de venda diária";
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
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
        private void VendaDiariaConsolidadaLancamentoForm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Tab))
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValorMercearia_Leave(object sender, EventArgs e)
        {
            try
            {
                this.CalcularTotalVenda();
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void txtValorAcougue_Leave(object sender, EventArgs e)
        {
            try
            {
                this.CalcularTotalVenda();
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void txtValorMercearia_Enter(object sender, EventArgs e)
        {
            this.txtValorMercearia.SelectAll();
        }

        private void txtValorAcougue_Enter(object sender, EventArgs e)
        {
            this.txtValorAcougue.SelectAll();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtValorMercearia.Text.Trim() == string.Empty || this.txtValorMercearia.Text.Trim() == string.Empty)
                    this.CalcularTotalVenda();
                //
                if (Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) == 0)
                {
                    this.cbbEstabelecimento.Focus();
                    throw new Exception("Selecione o Estabelecimento para continuar !");
                }
                else if (this.dtpDataMovimento.Value > DateTime.Now)
                {
                    this.dtpDataMovimento.Focus();
                    throw new Exception("Data do movimento não pode ser maior que a data atual !");
                }                
                else
                {
                    var retorno = new VendaConsolidadaDAO().VendaConsolidadaManter(new VendaConsolidadaModel
                    {
                        IdLancamento = this.vendaConsolidadaModel.IdLancamento,
                        Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) },
                        DataMovimento = this.dtpDataMovimento.Value,
                        ValorAcougue = Convert.ToDecimal(this.txtValorAcougue.Text),
                        ValorMercearia = Convert.ToDecimal(this.txtValorMercearia.Text)
                    });
                    //
                    switch (retorno)
                    {
                        case "INSERT OK":
                            Mensagens.MensagemInformacao("Novo lançamento de Vendas efetuado com sucesso !");
                            this.Close();
                            break;
                        case "UPDATE OK":
                            Mensagens.MensagemInformacao("Lançamento de Vendas atualizado com sucesso !");
                            this.Close();
                            break;
                        default:
                            Mensagens.MensagemErro(string.Format("Erro de lançamento de vendas !\n Detalhes: {0}", retorno));
                            break;
                    }
                }

            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void txtValorMercearia_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (this.txtValorMercearia.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtValorMercearia.Text = "0,";
                            this.txtValorMercearia.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtValorMercearia.Text)
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

        private void txtValorAcougue_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (this.txtValorAcougue.Text.Trim() == String.Empty)
                        {
                            e.Handled = true;
                            this.txtValorAcougue.Text = "0,";
                            this.txtValorAcougue.SelectionStart = 3;
                        }
                        else
                        {
                            foreach (Char item in this.txtValorAcougue.Text)
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

        private void VendaDiariaConsolidadaLancamentoForm_KeyDown(object sender, KeyEventArgs e)
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
