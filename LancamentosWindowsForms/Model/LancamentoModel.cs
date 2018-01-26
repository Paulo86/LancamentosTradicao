using System;

namespace LancamentosWindowsForms.Model
{
    public class LancamentoModel
    {
        public LancamentoModel()
        {
            this.IdLancamento = 0;
            this.Fornecedor = new FornecedorModel();
            this.DataEntradaInicial = DateTime.Now;
            this.DataEntradaFinal = DateTime.Now;
            this.DataVencimentoInicial = DateTime.Now;
            this.DataVencimentoFinal = DateTime.Now;
            this.NumeroDocumento = string.Empty;
            this.ValorTotal = 0;
            this.Estabelecimento = new EstabelecimentoModel();
            this.DataLiquidacao = DateTime.Now;
            this.DataLancamentoLiquidacao = DateTime.Now;
            this.ValorLiquidado = 0;
            this.FlagLiquidado = 0;
        }
        public int IdLancamento { get; set; }
        public FornecedorModel Fornecedor { get; set; }
        public EstabelecimentoModel Estabelecimento { get; set; }
        public DateTime DataEntradaInicial { get; set; }
        public DateTime DataEntradaFinal { get; set; }
        public DateTime DataVencimentoInicial { get; set; }
        public DateTime DataVencimentoFinal { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataLiquidacao { get; set; }
        public DateTime DataLancamentoLiquidacao { get; set; }
        public Decimal ValorLiquidado { get; set; }
        public int FlagLiquidado { get; set; }
        public string Status { get; set; }
    }
}
