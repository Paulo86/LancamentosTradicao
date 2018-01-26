using System;

namespace LancamentosWindowsForms.Model
{
    public class NotaFiscalModel
    {
        public NotaFiscalModel()
        {
            this.IdNotaFiscal = 0;
            this.Estabelecimento = new EstabelecimentoModel();
            this.Fornecedor = new FornecedorModel();
            this.NumeroNotaFiscal = string.Empty;
            this.DataEmissaoInicial = DateTime.Now;
            this.DataEmissaoFinal = DateTime.Now;
            this.DataEntradaInicial = DateTime.Now;
            this.DataEntradaFinal = DateTime.Now;
            this.ValorTotalDaNota = 0;
            this.ValorTotalDoIcmsSt = 0;
            this.ValorTotalDoIpi = 0;
            this.ValorTotalDasDespesas = 0;
        }
        public int IdNotaFiscal { get; set; }
        public EstabelecimentoModel Estabelecimento { get; set; }
        public FornecedorModel Fornecedor { get; set; }
        public string NumeroNotaFiscal { get; set; }
        public DateTime DataEmissaoInicial { get; set; }
        public DateTime DataEmissaoFinal { get; set; }
        public DateTime DataEntradaInicial { get; set; }
        public DateTime DataEntradaFinal { get; set; }
        public Decimal ValorTotalDaNota { get; set; }
        public Decimal ValorTotalDoIcmsSt { get; set; }
        public Decimal ValorTotalDoIpi { get; set; }
        public Decimal ValorTotalDasDespesas { get; set; }
    }
}
