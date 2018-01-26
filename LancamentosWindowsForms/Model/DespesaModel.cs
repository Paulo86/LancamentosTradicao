using System;

namespace LancamentosWindowsForms.Model
{
   public class DespesaModel
    {
        public DespesaModel()
        {
            this.IdDespesa = 0;
            this.DescricaoDespesa = string.Empty;
            this.DataMovimento = DateTime.Now;
            this.Valor = 0;
            this.Estabelecimento = new EstabelecimentoModel();
            this.CategoriaLancamento = new CategoriaLancamentoModel();
            this.SubcategoriaLancamento = new SubcategoriaLancamentoModel();
            this.Parceiro = new FornecedorModel();
            this.DataAuxiliar = DateTime.Now;
        }
        //
        public int IdDespesa { get; set; }
        public string DescricaoDespesa { get; set; }
        public DateTime DataMovimento { get; set; }
        public Decimal Valor { get; set; }
        public EstabelecimentoModel Estabelecimento { get; set; }
        public CategoriaLancamentoModel CategoriaLancamento { get; set; }
        public SubcategoriaLancamentoModel SubcategoriaLancamento { get; set; }
        public FornecedorModel Parceiro { get; set; }
        public DateTime DataAuxiliar { get; set; }

    }
}
