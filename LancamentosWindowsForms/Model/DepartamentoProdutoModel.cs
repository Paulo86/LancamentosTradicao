namespace LancamentosWindowsForms.Model
{
    public class DepartamentoProdutoModel
    {
        public DepartamentoProdutoModel()
        {
            this.IdDepartamento = -1;
            this.NomeDepartamento = string.Empty;
        }
        public int IdDepartamento { get; set; }
        public string NomeDepartamento { get; set; }
    }
}
