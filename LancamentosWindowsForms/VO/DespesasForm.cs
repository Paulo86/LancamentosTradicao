using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class DespesasForm : Form
    {
        public DespesasForm()
        {
            try
            {
                InitializeComponent();
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
        private void CarregarGrid()
        {
            try
            {
                this.dgvDespesas.AutoGenerateColumns = false;
                this.dgvDespesas.DataSource = new DespesaDAO().DespesaListByAll(new DespesaModel
                {
                    Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) },
                    DataMovimento = this.dtpDataInicial.Value,
                    DataAuxiliar = this.dtpDataFinal.Value
                });

                var totalDespesa = new decimal();
                foreach (DataGridViewRow linha in this.dgvDespesas.Rows)
                {
                    totalDespesa += Convert.ToDecimal(linha.Cells["clValor"].Value);
                }
                this.txtTotal.Text = totalDespesa.ToString("C2");
            }
            catch (Exception)
            {

                throw;
            }
        }
        //
        private void DespesasForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }

        private void btnNovoLancamento_Click(object sender, EventArgs e)
        {
            try
            {
                using (var despesasLancamentoForm = new DespesasLancamentoForm(null))
                {
                    DialogResult d = despesasLancamentoForm.ShowDialog();
                    this.CarregarGrid();
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                var g = new DespesaDAO().DespesaListaTipada(new DespesaModel
                {
                    Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = Convert.ToInt32(this.cbbEstabelecimento.SelectedValue) },
                    DataMovimento = this.dtpDataInicial.Value,
                    DataAuxiliar = this.dtpDataFinal.Value
                }).Select(x => new
                {
                    idDespesa = x.IdDespesa,
                    idCategoria = x.CategoriaLancamento.IdCategoria,
                    descricaoDespesa = x.DescricaoDespesa,
                    valorTotal = x.Valor,
                    nomeEstabelecimento = x.Estabelecimento.NomeEstabelecimento,
                    nomeCategoria = x.CategoriaLancamento.NomeCategoria,
                    idSubCategoria = x.SubcategoriaLancamento.IdSubcategoria,
                    nomeSubCategoria = x.SubcategoriaLancamento.NomeSubcategoria,
                    idEstabelecimento = x.Estabelecimento.IdEstabelecimento,
                    idParceiro = x.Parceiro.IdFornecedor,
                    nomeParceiro = x.Parceiro.NomeFornecedor,
                    dataMovimento = x.DataMovimento
                }).Where(x => x.idDespesa == Convert.ToInt32(this.dgvDespesas.CurrentRow.Cells["clIdDespesa"].Value)).Single();
                //
                var despesaModel = new DespesaModel
                {
                    IdDespesa = g.idDespesa,
                    CategoriaLancamento = new CategoriaLancamentoModel { IdCategoria = g.idCategoria },
                    DescricaoDespesa = g.descricaoDespesa,
                    Valor = g.valorTotal,
                    SubcategoriaLancamento = new SubcategoriaLancamentoModel { IdSubcategoria = g.idSubCategoria },
                    Estabelecimento = new EstabelecimentoModel { IdEstabelecimento = g.idEstabelecimento },
                    Parceiro = new FornecedorModel { IdFornecedor = g.idParceiro },
                    DataMovimento = g.dataMovimento
                };
                using (var despesasLancamentoForm = new DespesasLancamentoForm(despesaModel))
                {
                    DialogResult d = despesasLancamentoForm.ShowDialog();
                    this.CarregarGrid();
                }
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
                if (MessageBox.Show("Deseja realmente excluir este registro ?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var retorno = new DespesaDAO().DespesaManter(new DespesaModel { IdDespesa = Convert.ToInt32(this.dgvDespesas.CurrentRow.Cells["clIdDespesa"].Value) });
                    if (retorno == "DELETE OK")
                    {
                        Mensagens.MensagemInformacao("Lançamento de despesa Excluido com sucesso !");
                        this.CarregarGrid();
                    }
                }
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DespesasForm_Load(object sender, EventArgs e)
        {

        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Tab))
                e.Handled = true;
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
    }
}
