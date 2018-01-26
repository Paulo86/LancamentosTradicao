using LancamentosWindowsForms.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancamentosWindowsForms.DAO
{
    public class EstabelecimentoDAO
    {
        DBCore dbCore;
        public EstabelecimentoDAO()
        {
            this.dbCore = new DBCore();
        }
        public EstabelecimentoListaModel EstabelecimentoLista()
        {
            try
            {
                var estabelecimentoListaModel = new EstabelecimentoListaModel();
                //
                try
                {
                    this.dbCore.LimparParametros();
                    //
                    foreach (DataRow estabelecimento in this.dbCore.ExecutarConsulta("usp_estabelecimento_sel_by_all").Rows)
                    {
                        estabelecimentoListaModel.Add(new EstabelecimentoModel
                        {
                            IdEstabelecimento = Convert.ToInt32(estabelecimento["id_estabelecimento"]),
                            NomeEstabelecimento = estabelecimento["nome_estabelecimento"].ToString()
                        });
                    }

                }
                catch (Exception)
                {

                    throw;
                }
                //
                return estabelecimentoListaModel;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
