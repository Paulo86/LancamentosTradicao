using LancamentosWindowsForms.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancamentosWindowsForms.DAO
{

    public class SubcategoriaLancamentoDAO
    {
        DBCore dbCore;
        //
        public SubcategoriaLancamentoDAO()
        {
            this.dbCore = new DBCore();
        }
        //
        public string SubcategoriaManter(SubcategoriaLancamentoModel subcategoriaLancamentoModel)
        {
            var retorno = string.Empty;
            //
            try
            {
                this.dbCore.LimparParametros();
                this.dbCore.ComandoAdicionarParametro("@id_subcategoria", subcategoriaLancamentoModel.IdSubcategoria);
                this.dbCore.ComandoAdicionarParametro("@id_categoria", subcategoriaLancamentoModel.CategoriaLancamento.IdCategoria);
                this.dbCore.ComandoAdicionarParametro("@nome_subcategoria", subcategoriaLancamentoModel.NomeSubcategoria);
                //
                retorno = this.dbCore.ExecutarComando("usp_subcategoria_lancamento");
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }
        //
        public SubcategoriaLancamentoListModel SubCategoriaByAll()
        {
            var listasubcategoria = new SubcategoriaLancamentoListModel();
            //
            try
            {
                this.dbCore.LimparParametros();
                //
                foreach (DataRow subcategoria in this.dbCore.ExecutarConsulta("usp_subcategoria_lancamento_sel").Rows)
                {
                    listasubcategoria.Add(new SubcategoriaLancamentoModel
                    {
                        IdSubcategoria = Convert.ToInt32(subcategoria["id_subcategoria"]),
                        NomeSubcategoria = subcategoria["nome_subcategoria"].ToString(),
                        CategoriaLancamento = new CategoriaLancamentoModel
                        {
                            IdCategoria = Convert.ToInt32(subcategoria["id_categoria"]),
                            NomeCategoria = subcategoria["nome_categoria"].ToString()
                        }
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            //
            return listasubcategoria;
        }

    }
}
