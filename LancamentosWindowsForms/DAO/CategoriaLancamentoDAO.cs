using LancamentosWindowsForms.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancamentosWindowsForms.DAO
{
    public class CategoriaLancamentoDAO
    {
        DBCore sqlConnection;
        //
        public CategoriaLancamentoDAO()
        {
            this.sqlConnection = new DBCore();
        }
        public string LancamentoCategoriaManter(CategoriaLancamentoModel categoriaLancamentoModel)
        {
            var retorno = string.Empty;
            //
            try
            {
                this.sqlConnection.LimparParametros();
                //
                this.sqlConnection.ComandoAdicionarParametro("@id_categoria", categoriaLancamentoModel.IdCategoria);
                this.sqlConnection.ComandoAdicionarParametro("@nome_categoria", categoriaLancamentoModel.NomeCategoria);
                retorno = this.sqlConnection.ExecutarComando("usp_categoria_lancamento");
            }
            catch (Exception)
            {

                throw;
            }
            //
            return retorno;
        }
        //
        public CategoriaLancamentoListModel CategoriaLancamentoList()
        {
            var listaCategoria = new CategoriaLancamentoListModel();
            //
            try
            {
                this.sqlConnection.LimparParametros();
                foreach (DataRow categoria in this.sqlConnection.ExecutarConsulta("usp_lancamento_sel").Rows)
                {
                    listaCategoria.Add(new CategoriaLancamentoModel
                    {
                        IdCategoria = Convert.ToInt32(categoria["id_categoria"]),
                        NomeCategoria = categoria["nome_categoria"].ToString()
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            //
            return listaCategoria;
        }
    }
}
