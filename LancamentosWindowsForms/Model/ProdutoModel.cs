namespace LancamentosWindowsForms.Model
{
    public class ProdutoModel
    {
        public ProdutoModel()
        {            
            this.NomeProduto = string.Empty;
            this.PrecoCusto = 0;
            this.PrecoVenda = 0;
            this.Departamento = new DepartamentoProdutoModel();
        }
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        //
        public DepartamentoProdutoModel Departamento { get; set; }
    }
}
