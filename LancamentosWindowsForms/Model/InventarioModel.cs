using System;
namespace LancamentosWindowsForms.Model
{
   public class InventarioModel
    {
        public InventarioModel()
        {
            this.IdInventario = 0;
            this.DescricaoInventairo = string.Empty;
            this.IdDepartamento = -1;
            this.DataContagem = DateTime.Now;
            this.Status = -1;
            this.Estabelecimento = new EstabelecimentoModel();

        }
        public Int32 IdInventario { get; set; }
        public string DescricaoInventairo { get; set; }
        public Int32 IdDepartamento { get; set; }
        public DateTime DataContagem { get; set; }
        public int Status { get; set; }
        public EstabelecimentoModel Estabelecimento { get; set; }
    }
}
