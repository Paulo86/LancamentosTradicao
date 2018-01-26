using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class EstoqueTransferenciaForm : Form
    {
        public EstoqueTransferenciaForm()
        {
            try
            {
                InitializeComponent();
                //
                this.dtpMovimentoInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                this.dtpMovimentoFinal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                //
                this.CarregarComboBoxEstabelecimentoOrigem();
                this.CarregarComboBoxEstabelecimentoDestino();
                this.CarregarDatagrid();
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }
        //
        private void CarregarDatagrid()
        {
            try
            {
                this.dgvVencidos.AutoGenerateColumns = false;
                this.dgvVencidos.DataSource = new EstoqueTransferenciaDAO().DataTableEstoqueTransferencia(new EstoqueTransferenciaModel
                {
                    EstabelecimentoOrigem = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimentoOrigem.SelectedValue) },
                    EstabelecimentoDestino = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimentoDestino.SelectedValue) },
                    DataMovimentoInicial = Convert.ToDateTime(this.dtpMovimentoInicial.Value),
                    DataMovimentoFinal = Convert.ToDateTime(this.dtpMovimentoFinal.Value),
                });
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
                    NomeEstabelecimento = "[Todos os Estabelecimentos]"
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
        private void CarregarComboBoxEstabelecimentoDestino()
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
                this.cbbEstabelecimentoDestino.DataSource = listaEstabelecimento;
                this.cbbEstabelecimentoDestino.DisplayMember = "NomeEstabelecimento";
                this.cbbEstabelecimentoDestino.ValueMember = "IdEstabelecimento";

            }
            catch (Exception exception)
            {

                throw new Exception(string.Format("Erro ao carregar Estabelecimentos Destino !\nDetalhes: {0}", exception.Message));
            }
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EstoqueTransferenciaForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }

        private void btnNovoLancamento_Click(object sender, EventArgs e)
        {
            using (var f = new EstoqueTransferenciaLancamentoForm())
            {
                f.ShowDialog();
                this.CarregarDatagrid();
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
                if (MessageBox.Show("Deseja realmente Excluir este lanlamento ?","Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var retorno = new EstoqueTransferenciaDAO().EstoqueTransferenciaManter(new EstoqueTransferenciaModel
                    {
                        IdTransferencia = Convert.ToInt32(this.dgvVencidos.CurrentRow.Cells["clIdTransferencia"].Value)
                    });
                    //
                    if (retorno == "DELETE OK")
                    {
                        Mensagens.MensagemInformacao("Transferencia Excuida com sucesso !");
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
    }
}
