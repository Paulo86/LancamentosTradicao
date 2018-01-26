using LancamentosWindowsForms.Model;
using System;
using System.Data;

namespace LancamentosWindowsForms.DAO
{
    public class VendaConsolidadaDAO
    {
        private DBCore dbCore;
        //
        public VendaConsolidadaDAO()
        {
            this.dbCore = new DBCore();
        }
        //
        public string VendaConsolidadaManter(VendaConsolidadaModel vendaConsolidadaModel)
        {
            var retorno = string.Empty;
            //
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_lancamento", vendaConsolidadaModel.IdLancamento);
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento", vendaConsolidadaModel.Estabelecimento.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@data_movimento", vendaConsolidadaModel.DataMovimento);
                this.dbCore.ComandoAdicionarParametro("@valor_mercearia", vendaConsolidadaModel.ValorMercearia);
                this.dbCore.ComandoAdicionarParametro("@valor_acougue", vendaConsolidadaModel.ValorAcougue);
                //
                retorno = this.dbCore.ExecutarComando("usp_venda_consolidada_manter");
            }
            catch (Exception)
            {

                throw;
            }
            //
            return retorno;
        }
        //
        public VendaConsolidadaListModel VendaConsolidadaListByAll(VendaConsolidadaModel vendaConsolidadaModel)
        {
            var listaVendaConsolidada = new VendaConsolidadaListModel();
            //
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento", vendaConsolidadaModel.Estabelecimento.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@data_inicial", vendaConsolidadaModel.DataMovimento);
                this.dbCore.ComandoAdicionarParametro("@data_final", vendaConsolidadaModel.DataAuxiliar);
                //
                foreach (DataRow vendaConsolidada in this.dbCore.ExecutarConsulta("usp_venda_consolidada_sel").Rows)
                {
                    listaVendaConsolidada.Add(new VendaConsolidadaModel
                    {
                        IdLancamento = Convert.ToInt32(vendaConsolidada["id_lancamento"]),
                        Estabelecimento = new EstabelecimentoModel
                        {
                            IdEstabelecimento = Convert.ToInt32(vendaConsolidada["id_estabelecimento"]),
                            NomeEstabelecimento = vendaConsolidada["nome_estabelecimento"].ToString()
                        },
                        DataMovimento = Convert.ToDateTime(vendaConsolidada["data_movimento"]),
                        ValorAcougue = Convert.ToDecimal(vendaConsolidada["valor_acougue"]),
                        ValorMercearia = Convert.ToDecimal(vendaConsolidada["valor_mercearia"]),
                        ValorTotal = Convert.ToDecimal(vendaConsolidada["valor_total"])
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            //
            return listaVendaConsolidada;
        }
        //
        public DataTable DataTableVendaConsolidada(VendaConsolidadaModel vendaConsolidadaModel)
        {
            var listaVendaConsolidada = new DataTable();
            //
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento", vendaConsolidadaModel.Estabelecimento.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@data_inicial", vendaConsolidadaModel.DataMovimento);
                this.dbCore.ComandoAdicionarParametro("@data_final", vendaConsolidadaModel.DataAuxiliar);
                //
                listaVendaConsolidada = this.dbCore.ExecutarConsulta("usp_venda_consolidada_sel");
            }
            catch (Exception)
            {

                throw;
            }
            //
            return listaVendaConsolidada;
        }

    }
}
