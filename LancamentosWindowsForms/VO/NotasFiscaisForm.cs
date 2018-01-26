using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class NotasFiscaisForm : Form
    {
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
        private void CarregarDatagrid()
        {
            try
            {
                this.dgvVencidos.DataSource = new NotaFiscalDAO().DataTableNotaFiscal(new NotaFiscalModel {
                    DataEntradaInicial = Convert.ToDateTime(this.dtpEntradaInicial.Value),
                    DataEntradaFinal = Convert.ToDateTime(this.dtpEntradaFinal.Value),
                    DataEmissaoInicial = Convert.ToDateTime(this.dtpEmissaoInicial.Value),
                    DataEmissaoFinal = Convert.ToDateTime(this.dtpEmissaoFinal.Value),
                    Fornecedor = new FornecedorModel { IdFornecedor = Convert.ToInt32(this.cbbFornecedor.SelectedValue) },
                    Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) }
                });
                //
                var valorTotalLancamentos = new Decimal();
                foreach (DataGridViewRow linha in this.dgvVencidos.Rows)
                {
                    valorTotalLancamentos += Convert.ToDecimal(linha.Cells["clValorTotalProdutos"].Value);
                }
                //
                this.txtValorTotal.Text = valorTotalLancamentos.ToString("C2");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public NotasFiscaisForm()
        {
            try
            {
                InitializeComponent();
                //
                this.CarregarComboBoxEstabelecimento();
                this.CarregarComboBoxFornecedores();
                this.dtpEntradaInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                this.dtpEntradaFinal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                this.dtpEmissaoInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                this.dtpEmissaoFinal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                //
                this.CarregarDatagrid();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);

            }
        }

        private void NotasFiscaisForm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoLancamento_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new CorpoNotaFiscalForm(null, AcaoForm.NovoLancamento))
                {
                    f.ShowDialog();
                    this.CarregarDatagrid();
                }
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
                this.CarregarDatagrid();
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente cancelar este lançamento ?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                        var retorno = new NotaFiscalDAO().NotaFiscalManter(new NotaFiscalModel {
                            IdNotaFiscal = Convert.ToInt32(this.dgvVencidos.CurrentRow.Cells["clIdLancamentoAberto"].Value)
                        });
                        if (retorno == "DELETE OK")
                        {
                        Mensagens.MensagemInformacao("Lançamento de Compras excluído com sucesso !");
                        this.CarregarDatagrid();
                        }
                        else throw new Exception(retorno);
                    
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new ProdutosNotaFiscalForm(new NotaFiscalModel
                {
                    IdNotaFiscal = Convert.ToInt32(this.dgvVencidos.CurrentRow.Cells["clIdLancamentoAberto"].Value)
                }))
                {
                    f.ShowDialog();
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemInformacao(exception.Message);
            }
        }
    }
}