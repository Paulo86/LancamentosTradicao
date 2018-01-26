
namespace LancamentosWindowsForms.Model
{
   public class EstabelecimentoModel
    {
       public EstabelecimentoModel()
        {
            this.IdEstabelecimento = 0;
            this.NomeEstabelecimento = string.Empty;
        }
        public int IdEstabelecimento { get; set; }
        public string NomeEstabelecimento { get; set; }
    }
}
