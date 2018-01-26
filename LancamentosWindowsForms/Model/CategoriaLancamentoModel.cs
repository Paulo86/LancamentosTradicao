namespace LancamentosWindowsForms.Model
{
    public class CategoriaLancamentoModel
    {
        public CategoriaLancamentoModel()
        {
            this.IdCategoria = 0;
            this.NomeCategoria = string.Empty;
        }
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
    }
}
