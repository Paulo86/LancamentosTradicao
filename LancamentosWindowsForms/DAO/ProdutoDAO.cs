using LancamentosWindowsForms.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancamentosWindowsForms.DAO
{
    public class ProdutoDAO
    {
        DBCore dbCore;
        //
        public ProdutoDAO()
        {
            this.dbCore = new DBCore();
        }
        //
        public DataTable ProdutoListByAll(string codigoDescricao, int idEstabelecimento)
        {
            var dtProdutos = new DataTable();
            //
            try
            {
                this.dbCore.LimparParametros();
                this.dbCore.ComandoAdicionarParametro("@dado_entrada", codigoDescricao);
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento", idEstabelecimento);
                //
                return this.dbCore.ExecutarConsulta("usp_produto_sel");
            }

            catch (Exception)
            {

                throw;
            }
            //
            //return listaProduto;
        }
    }
}
