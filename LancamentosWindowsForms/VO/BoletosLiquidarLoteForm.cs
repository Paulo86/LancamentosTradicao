using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class BoletosLiquidarLoteForm : Form
    {
        LancamentoListaModel lancamentoListaModel;
        //
        public BoletosLiquidarLoteForm(LancamentoListaModel lancamentoListaModel)
        {
            try
            {
                InitializeComponent();
                this.lancamentoListaModel = lancamentoListaModel;
                this.dataGridView1.DataSource = this.lancamentoListaModel.Select(x => new
                {
                    idLancamento = x.IdLancamento,
                    nomeParceiro = x.Fornecedor.NomeFornecedor,
                    valorTitulo = x.ValorTotal
                }).ToList();
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void LiquidarLancamentoLoteForm_KeyPress(object sender, KeyPressEventArgs e)
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
                var totalDespesas = new decimal();
                //
                try
                {
                    foreach (DataGridViewRow linha in this.dataGridView1.Rows)
                    {
                        if (linha.Cells["clValorPago"].Value == null)
                            throw new Exception("Valor Pago inválido !");
                        else if (Convert.ToDecimal(linha.Cells["clValorPago"].Value) < Convert.ToDecimal(linha.Cells["clValorTotal"].Value))
                            throw new Exception("Valor pago não pode ser menor que o valor do Título !");
                        else
                        {
                            totalDespesas += Convert.ToDecimal(linha.Cells["clValorPago"].Value) - Convert.ToDecimal(linha.Cells["clValorTotal"].Value);
                        }
                    }
                }
                catch (InvalidCastException)
                {
                    throw new Exception("Valor Pago inválido !");
                }
                catch (ArgumentNullException)
                {
                    throw new Exception("Valor Pago inválido !");
                }
                catch (NullReferenceException)
                {
                    throw new Exception("Valor Pago inválido !");
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
                //
                if (MessageBox.Show(string.Format("Confirma a líquidação de {0} título ?", this.lancamentoListaModel.Count.ToString()), "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {                        
                        foreach (DataGridViewRow linha in this.dataGridView1.Rows)
                        {
                            var retorno = string.Empty;
                            //
                            retorno = new LancamentoDAO().LancamentoInserir(new LancamentoModel
                            {
                                IdLancamento = Convert.ToInt32(linha.Cells["clIdLancamento"].Value),
                                DataLiquidacao = Convert.ToDateTime(this.dtpDataPagamento.Value),
                                ValorLiquidado = Convert.ToDecimal(linha.Cells["clValorPago"].Value)
                                //
                            });
                            //
                            if (!Char.IsNumber(retorno, 0))
                            {
                                throw new Exception(string.Format("Erro ao líquidar lançamento !\n{0}", retorno));
                            }
                        }
                        //
                        Mensagens.MensagemInformacao("Títulos líquidados com sucesso !");
                        if (totalDespesas > 0)
                        {
                            var estabelecimento = new EstabelecimentoModel();
                            var fornecedor = new FornecedorModel();
                            //
                            foreach (var item in this.lancamentoListaModel)
                            {
                                estabelecimento = new EstabelecimentoModel { IdEstabelecimento = item.Estabelecimento.IdEstabelecimento };
                                fornecedor = new FornecedorModel { IdFornecedor = item.Fornecedor.IdFornecedor };
                            }
                            using (var f = new DespesaBoletoForm(new DespesaModel
                            {
                                Valor = totalDespesas,
                                Parceiro = fornecedor,
                                Estabelecimento = estabelecimento,
                                DataMovimento = this.dtpDataPagamento.Value,
                                DescricaoDespesa = string.Format("TAXA BOL. LIQ LOTE")
                            }))
                            {
                                f.ShowDialog();
                            }
                        }

                        
                        this.Close();
                    }
                    catch (FormatException)
                    {
                        Mensagens.MensagemErro("Valor Inválido");
                    }
                    catch (Exception exception)
                    {
                        Mensagens.MensagemErro(exception.Message);
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

        private void BoletosLiquidarLoteForm_KeyDown(object sender, KeyEventArgs e)
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
