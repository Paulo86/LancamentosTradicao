using System;

namespace LancamentosWindowsForms.Model
{
    public class ProdutoNotaFiscalModel
    {
        public ProdutoNotaFiscalModel()
        {
            this.Produto = new ProdutoModel();
            this.NotaFiscal = new NotaFiscalModel();
            this.Quantidade = 0;
            this.QuantidadePorEmbalagem = 0;
            this.ValorUnitario = 0;
            this.CustoSemImposto = 0;
            this.CustoComImposto = 0;
            this.ValorTotalDoIcmsSt = 0;
            this.ValorTotalDoIpi = 0;
            this.ValorTotalDoDesconto = 0;
            this.Observacao = string.Empty;
        }
        //
        public ProdutoModel Produto { get; set; }
        public NotaFiscalModel NotaFiscal { get; set; }
        public decimal Quantidade { get; set; }
        public decimal QuantidadePorEmbalagem { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal CustoSemImposto { get; set; }
        public decimal CustoComImposto { get; set; }
        public decimal ValorTotalDoIcmsSt { get; set; }
        public decimal ValorTotalDoIpi { get; set; }
        public decimal ValorTotalDoDesconto { get; set; }
        public String Observacao { get; set; }
    }
}
