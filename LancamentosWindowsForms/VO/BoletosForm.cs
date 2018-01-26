using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class BoletosForm : Form
    {
        public BoletosForm()
        {
            try
            {
                InitializeComponent();
                this.CarregarComboBoxEstabelecimento();
                this.CarregarComboBoxFornecedores();
                this.dtpEntradaInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                this.dtpEntradaFinal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 31);
                this.dtpVencimentoInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                this.dtpVencimentoFinal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                this.CarregarTodosOsDatagrid();
                if (this.dgvVencidos.Rows.Count == 0)
                    this.tabControl1.SelectedTab = tpAVencer;
                else this.tabControl1.SelectedTab = tpVencido;
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);

            }
        }
        //
        private void CarregarTodosOsDatagrid()
        {
            try
            {
                this.dgvVencidos.AutoGenerateColumns = false;
                this.dgvAVencer.AutoGenerateColumns = false;
                this.dgvQuitados.AutoGenerateColumns = false;
                //
                var Titulos = new LancamentoDAO().BoletosDataTable(new LancamentoModel
                {
                    DataEntradaInicial = Convert.ToDateTime(this.dtpEntradaInicial.Value),
                    DataEntradaFinal = Convert.ToDateTime(this.dtpEntradaFinal.Value),
                    DataVencimentoInicial = Convert.ToDateTime(this.dtpVencimentoInicial.Value),
                    DataVencimentoFinal = Convert.ToDateTime(this.dtpVencimentoFinal.Value),
                    Fornecedor = new FornecedorModel { IdFornecedor = Convert.ToInt32(this.cbbFornecedor.SelectedValue) },
                    Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) }
                });
                //
                var valorTotalVencidos = new Decimal();
                var valorTotalAVencer = new Decimal();
                var valorTotalLiquidado = new Decimal();
                //
                var titulosVencidos = Titulos.Clone();
                var titulosAVencer = Titulos.Clone();
                var titulosLiquidados = Titulos.Clone();
                //
                foreach (DataRow linha in Titulos.Rows)
                {
                    switch (linha["status"].ToString())
                    {
                        case "Aberto":
                            valorTotalVencidos += Convert.ToDecimal(linha["valor_total"]);
                            titulosVencidos.ImportRow(linha);
                            break;
                        case "A vencer":
                            valorTotalAVencer += Convert.ToDecimal(linha["valor_total"]);
                            titulosAVencer.ImportRow(linha);
                            break;
                        case "Liquidado":
                            valorTotalLiquidado += Convert.ToDecimal(linha["valor_total"]);
                            titulosLiquidados.ImportRow(linha);
                            break;
                    }
                }
                //
                this.dgvVencidos.DataSource = titulosVencidos;
                this.dgvAVencer.DataSource = titulosAVencer;
                this.dgvQuitados.DataSource = titulosLiquidados;
                //
                //
                this.txtAVencer.Text = valorTotalAVencer.ToString("C2");
                this.txtTotalAberto.Text = valorTotalVencidos.ToString("C2");
                this.txtLiquidados.Text = valorTotalLiquidado.ToString("C2");
                //
                //
                if (this.dgvVencidos.Rows.Count == 0)
                    this.tabControl1.SelectedTab = tpAVencer;
                else this.tabControl1.SelectedTab = tpVencido;
            }
            catch (Exception)
            {

                throw;
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
                    NomeFornecedor = "[Todos os Fornecedores]"
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
                    NomeEstabelecimento = "[Todos os Estabelecimentos]"
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
        private void PrincipalForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();

            }
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoLancamento_Click(object sender, EventArgs e)
        {
            using (var lancamentoForm = new BoletosLancamentoForm(AcaoForm.NovoLancamento, null))
            {
                lancamentoForm.ShowDialog();
                this.CarregarComboBoxFornecedores();
                this.CarregarTodosOsDatagrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                var listaLancamento = new LancamentoListaModel();
                var retorno = string.Empty;
                if (this.tabControl1.SelectedTab == tpVencido || this.tabControl1.SelectedTab == tpAVencer)
                {
                    if (this.dgvVencidos.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in this.dgvVencidos.Rows)
                        {
                            if (bool.Parse(row.Cells["clSelecionarAberto"].EditedFormattedValue.ToString()))//(row.Cells["clSelecionarAberto"].Value != null)
                            {
                                listaLancamento.Add(new LancamentoModel { IdLancamento = Convert.ToInt32(row.Cells["clIdLancamentoAberto"].Value) });
                            }
                        }
                    }
                    //
                   else if (this.dgvAVencer.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in this.dgvAVencer.Rows)
                        {
                            if (bool.Parse(row.Cells["clSelecionarAVencer"].EditedFormattedValue.ToString()))//(row.Cells["clSelecionarAVencer"].Value != null)
                            {
                                listaLancamento.Add(new LancamentoModel { IdLancamento = Convert.ToInt32(row.Cells["clIdLancamentoAVencer"].Value) });
                            }
                        }
                    }
                    //
                    //
                    if (listaLancamento.Count <= 0)
                        throw new Exception("Nenhum Boleto selecionado para exclusão !");
                    else if (MessageBox.Show(string.Format("Deseja realmente excluir o(s) titulo(s) selecionado(s) ?"), "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (var item in listaLancamento)
                        {
                            retorno = new LancamentoDAO().LancamentoExcluir(item.IdLancamento);
                        }
                        MessageBox.Show(string.Format("Título(s) excluido(s) com sucesso ! {0}", listaLancamento.Count));
                        //
                        this.CarregarTodosOsDatagrid();
                    }
                    else
                    {
                        listaLancamento = new LancamentoListaModel();
                    }
                }
                else MessageBox.Show("O título selecinado não pode ser alterado pois já se encontra Liquidado !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                //this.CarregarDatagridVencidos();
                //this.CarregarDatagridAVencer();
                //this.CarregarDatagridQuitados();
                this.CarregarTodosOsDatagrid();

            }
            catch (Exception exception)
            {

                MessageBox.Show(string.Format("Erro ao carregar Lançancamentos !\nDetalhes: {0}", exception.Message));
            }
        }

        private void txtTotalAberto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Tab))
                e.Handled = true;
        }

        private void txtAVencer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Tab))
                e.Handled = true;
        }

        private void txtLiquidados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Tab))
                e.Handled = true;
        }

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            try
            {
                var lancamentoListaModel = new LancamentoListaModel();
                //
                if (this.tabControl1.SelectedTab == tpVencido)
                {
                    foreach (DataGridViewRow currentRow in this.dgvVencidos.Rows)
                    {
                        if (currentRow.Cells["clSelecionarAberto"].Value != null)
                        {
                            lancamentoListaModel.Add(new LancamentoModel
                            {
                                IdLancamento = Convert.ToInt32(currentRow.Cells["clIdLancamentoAberto"].Value),
                                ValorTotal = Convert.ToDecimal(currentRow.Cells["vlValorTotalAberto"].Value),
                                Fornecedor = new FornecedorModel
                                {
                                    IdFornecedor = Convert.ToInt32(currentRow.Cells["clCodigoFornecedorAberto"].Value),
                                    NomeFornecedor = currentRow.Cells["clNomeFornecedorAberto"].Value.ToString()
                                },
                                NumeroDocumento = currentRow.Cells["clNumeroDocumentoAberto"].Value.ToString(),
                                Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(currentRow.Cells["clIdEstabelecimentoAberto"].Value) }
                            });
                        }
                    }

                }
                else if (this.tabControl1.SelectedTab == tpAVencer)
                {
                    foreach (DataGridViewRow currentRow in this.dgvAVencer.Rows)
                    {
                        if (currentRow.Cells["clSelecionarAVencer"].Value != null)
                        {
                            lancamentoListaModel.Add(new LancamentoModel
                            {
                                IdLancamento = Convert.ToInt32(currentRow.Cells["clIdLancamentoAVencer"].Value),
                                ValorTotal = Convert.ToDecimal(currentRow.Cells["clVAlorTotalAVencer"].Value),
                                Fornecedor = new FornecedorModel
                                {
                                    IdFornecedor = Convert.ToInt32(currentRow.Cells["clIdFornecedorAVencer"].Value),
                                    NomeFornecedor = currentRow.Cells["clNomeFornecedorAVencer"].Value.ToString()
                                },
                                NumeroDocumento = currentRow.Cells["clNumeroDocumentoAVencer"].Value.ToString(),
                                Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(currentRow.Cells["clIdEstabelecimentoAVencer"].Value) }
                            });

                        }
                    }
                }
                else if (this.tabControl1.SelectedTab == tpQuitados)
                {
                    throw new Exception("Não é possível alterar um título Liquidado !");
                }
                //
                //
                if (lancamentoListaModel.Count <= 0)
                {
                    throw new Exception("Selecione um título para liquidação");
                }
                else
                {
                    if (lancamentoListaModel.Count > 1)
                    {
                        using (var liquidarLancamentoLoteForm = new BoletosLiquidarLoteForm(lancamentoListaModel))
                        {
                            liquidarLancamentoLoteForm.ShowDialog();
                            //
                            this.CarregarTodosOsDatagrid();
                        }
                    }
                    else
                    {
                        using (var liquidarLancamentoForm = new BoletosLiquidarForm(lancamentoListaModel.Single()))
                        {
                            liquidarLancamentoForm.ShowDialog();
                            //
                            this.CarregarTodosOsDatagrid();
                        }
                    }
                }

            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void dgvVencidos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
