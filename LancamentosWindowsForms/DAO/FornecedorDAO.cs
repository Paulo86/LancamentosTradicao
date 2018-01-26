using LancamentosWindowsForms.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancamentosWindowsForms.DAO
{
    public class FornecedorDAO
    {
        DBCore dbCore;
        //
        public FornecedorDAO()
        {
            this.dbCore = new DBCore();
        }

        public string FornecedorManterDAO(FornecedorModel fornecedorModel)
        {
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_fornecedor", fornecedorModel.IdFornecedor);
                this.dbCore.ComandoAdicionarParametro("@nome_fornecedor", fornecedorModel.NomeFornecedor);
                return this.dbCore.ExecutarComando("usp_fornecedor_manter");
            }
            catch (Exception)
            {

                throw;
            }
        }
        //
        public FornecedorListaModel ForncedorLista()
        {
            var fornecedorListaModel = new FornecedorListaModel();
            //
            try
            {
                this.dbCore.LimparParametros();
                //
                foreach (DataRow fornecedor in this.dbCore.ExecutarConsulta("usp_fornecedor_sel_by_all").Rows)
                {
                    fornecedorListaModel.Add(new FornecedorModel
                    {
                        IdFornecedor = Convert.ToInt32(fornecedor["id_fornecedor"]),
                        NomeFornecedor = fornecedor["nome_fornecedor"].ToString()
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
            //
            return fornecedorListaModel;
        }
        //
        public string FornecedorExcluir(int idFornecedor)
        {
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_fornecedor",idFornecedor);
                return this.dbCore.ExecutarComando("usp_fornecedor_del");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
