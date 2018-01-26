using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class VendaDiariaConsolidadaForm : Form
    {
        public VendaDiariaConsolidadaForm()
        {
            try
            {
                this.InitializeComponent();
                this.CarregarComboBoxEstabelecimento();
                this.dtpDataInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                this.dtpDataFinal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                this.CarregarGrid();
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }
        //
        private void CarregarGrid()
        {
            try
            {                
                this.dgvVendasCosolidadas.DataSource = new VendaConsolidadaDAO().DataTableVendaConsolidada(new VendaConsolidadaModel
                {
                    Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) },
                    DataMovimento = this.dtpDataInicial.Value,
                    DataAuxiliar = this.dtpDataFinal.Value
                });
                //
                var valorTotalMercearia = new decimal();
                var valorTotalAcougue = new decimal();
                var valorTotal = new decimal();
                foreach (DataGridViewRow vendaConsolidada in dgvVendasCosolidadas.Rows)
                {
                    valorTotalMercearia += Convert.ToDecimal(vendaConsolidada.Cells["clValorMercearia"].Value);
                    valorTotalAcougue += Convert.ToDecimal(vendaConsolidada.Cells["clValorAcougue"].Value);
                    valorTotal += Convert.ToDecimal(vendaConsolidada.Cells["clValorTotal"].Value);
                }
                //
                this.txtValorTotalMercearia.Text = valorTotalMercearia.ToString("C2");
                this.txtValorTotalAcougue.Text = valorTotalAcougue.ToString("C2");
                this.txtValorTotalValorTotal.Text = valorTotal.ToString("C2");
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

        private void VendaDiariaConsolidadaForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
                this.Close();
        }

        private void btnNovoLancamento_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new VendaDiariaConsolidadaLancamentoForm(null))
                {
                    f.ShowDialog();
                    this.CarregarGrid();
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = new VendaConsolidadaDAO().VendaConsolidadaListByAll(new VendaConsolidadaModel
                {
                    Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) },
                    DataMovimento = this.dtpDataInicial.Value,
                    DataAuxiliar = this.dtpDataFinal.Value
                });
                var vendaConsolidada = lista.Select(x => new
                {
                    idLancamento = x.IdLancamento,
                    idEstabelecimento = x.Estabelecimento.IdEstabelecimento,
                    dataMovimento = x.DataMovimento,
                    valorMercearia = x.ValorMercearia,
                    valorAcougue = x.ValorAcougue,
                    valorTotal = x.ValorTotal
                }).Where(x => x.idLancamento == Convert.ToInt32(this.dgvVendasCosolidadas.CurrentRow.Cells["clIdLancamento"].Value)).Single();
                //
                using (var f = new VendaDiariaConsolidadaLancamentoForm(new VendaConsolidadaModel
                {
                    IdLancamento = vendaConsolidada.idLancamento,
                    Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = vendaConsolidada.idEstabelecimento },
                    DataMovimento = vendaConsolidada.dataMovimento,
                    ValorMercearia = vendaConsolidada.valorMercearia,
                    ValorAcougue = vendaConsolidada.valorAcougue,
                    ValorTotal = vendaConsolidada.valorTotal
                }))
                {
                    f.ShowDialog();
                    this.CarregarGrid();
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
                this.CarregarGrid();
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
                if (MessageBox.Show("Deseja realmente excluir este lançamento ?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var retorno = new VendaConsolidadaDAO().VendaConsolidadaManter(new VendaConsolidadaModel
                    {
                        IdLancamento = Convert.ToInt32(this.dgvVendasCosolidadas.CurrentRow.Cells["clIdLancamento"].Value)
                    });
                    //
                    if (retorno == "DELETE OK")
                    {
                        MessageBox.Show("Lançamento excluído com sucesso !");
                        this.CarregarGrid();
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
    }
}
