using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class ProdutosNotaFiscalForm : Form
    {
        NotaFiscalModel notaFiscalModel;
        private void CarregarDatagridProdutos()
        {
            try
            {
                this.dgvProdutos.DataSource = new NotaFiscalDAO().ProdutosNotaFiscalLista(new ProdutoNotaFiscalModel
                {
                    NotaFiscal = this.notaFiscalModel

                }).Select(x => new
                {
                    idProduto = x.Produto.IdProduto,
                    nomeProduto = x.Produto.NomeProduto,
                    quantidade = x.Quantidade,
                    quantidadeEmbalagem = x.QuantidadePorEmbalagem,
                    valorUnitario = x.ValorUnitario,
                    CustoSemImposto = x.CustoSemImposto,
                    CustoComImposto = x.CustoComImposto,
                    ValorIcmsSt = x.ValorTotalDoIcmsSt,
                    ValorIpi = x.ValorTotalDoIpi,
                    ValorDesconto = x.ValorTotalDoDesconto,
                    valorTotal = (x.Quantidade * x.ValorUnitario) + (x.ValorTotalDoIpi + x.ValorTotalDoIcmsSt - x.ValorTotalDoDesconto),
                    Observao = x.Observacao
                }).ToList();
                //
                var valorTotalDosProdutos = new Decimal();
                foreach (DataGridViewRow linha in this.dgvProdutos.Rows)
                {
                    valorTotalDosProdutos += Convert.ToDecimal(linha.Cells["clValorTotal"].Value);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ProdutosNotaFiscalForm(NotaFiscalModel notaFiscalModel)
        {
            try
            {
                InitializeComponent();
                this.notaFiscalModel = notaFiscalModel;
                this.CarregarDatagridProdutos();
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void ProdutosNotaFiscalForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
