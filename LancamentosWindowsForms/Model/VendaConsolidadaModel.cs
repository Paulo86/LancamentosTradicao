using System;

namespace LancamentosWindowsForms.Model
{
    public class VendaConsolidadaModel
    {
       public VendaConsolidadaModel()
        {
            this.IdLancamento = 0;
            this.DataMovimento = DateTime.Now;
            this.ValorMercearia = 0;
            this.ValorAcougue = 0;
            this.ValorTotal = 0;
            this.Estabelecimento = new EstabelecimentoModel();
            this.DataAuxiliar = DateTime.Now;
        }
        //
        public int IdLancamento { get; set; }
        public DateTime DataMovimento { get; set; }
        public decimal ValorMercearia { get; set; }
        public decimal ValorAcougue { get; set; }
        public decimal ValorTotal { get; set; }
        public EstabelecimentoModel Estabelecimento { get; set; }
        public DateTime DataAuxiliar { get; set; }
    }
}
