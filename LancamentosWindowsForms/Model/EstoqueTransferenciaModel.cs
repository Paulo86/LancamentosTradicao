using System;

namespace LancamentosWindowsForms.Model
{
    public class EstoqueTransferenciaModel
    {
        public EstoqueTransferenciaModel()
        {
            this.IdTransferencia = 0;
            this.Produto = new ProdutoModel();
            this.EstabelecimentoOrigem = new EstabelecimentoModel();
            this.EstabelecimentoDestino = new EstabelecimentoModel();
            this.QuantidadeTotal = new decimal();
            this.CustoSemImposto = new decimal();
            this.DataMovimentoInicial = DateTime.Now;
            this.DataMovimentoFinal = DateTime.Now;

        }
        public int IdTransferencia { get; set; }
        public ProdutoModel Produto { get; set; }
        public EstabelecimentoModel EstabelecimentoOrigem { get; set; }
        public EstabelecimentoModel EstabelecimentoDestino { get; set; }
        public decimal QuantidadeTotal { get; set; }
        public decimal CustoSemImposto { get; set; }
        public DateTime DataMovimentoInicial { get; set; }
        public DateTime DataMovimentoFinal { get; set; }

    }
}
