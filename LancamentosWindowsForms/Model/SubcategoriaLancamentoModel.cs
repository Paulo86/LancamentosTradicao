namespace LancamentosWindowsForms.Model
{
    public class SubcategoriaLancamentoModel
    {
        public SubcategoriaLancamentoModel()
        {
            this.IdSubcategoria = 0;
            this.NomeSubcategoria = string.Empty;
            this.CategoriaLancamento = new CategoriaLancamentoModel();
        }

        public int IdSubcategoria { get; set; }
        public string NomeSubcategoria { get; set; }
        public CategoriaLancamentoModel CategoriaLancamento { get; set; }
    }
}
