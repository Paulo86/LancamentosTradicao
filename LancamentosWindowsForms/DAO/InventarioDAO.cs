using LancamentosWindowsForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancamentosWindowsForms.DAO
{
    class InventarioDAO
    {
        DBCore dbCore;
        public InventarioDAO()
        {
            this.dbCore = new DBCore();
        }
        //
        public string InventarioManter(InventarioModel inventarioModel)
        {
            var retorno = String.Empty;
            //
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_inventario", inventarioModel.IdInventario);
                this.dbCore.ComandoAdicionarParametro("@descricao_inventario", inventarioModel.DescricaoInventairo);
                this.dbCore.ComandoAdicionarParametro("@id_departamento", inventarioModel.IdDepartamento);
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento", inventarioModel.Estabelecimento.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@data_contagem", inventarioModel.DataContagem);
                //
                retorno = this.dbCore.ExecutarComando("usp_inventario_manter");
            }
            catch (Exception)
            {

                throw;
            }
            //
            return retorno;
        }

    }
}
