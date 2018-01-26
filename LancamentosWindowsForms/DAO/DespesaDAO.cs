using LancamentosWindowsForms.Model;
using System;
using System.Data;

namespace LancamentosWindowsForms.DAO
{
    public class DespesaDAO
    {
        DBCore dbCore;
        public DespesaDAO()
        {
            this.dbCore = new DBCore();
        }
        //
        public string DespesaManter(DespesaModel despesaModel)
        {
            var retorno = string.Empty;
            //
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_despesa", despesaModel.IdDespesa);
                this.dbCore.ComandoAdicionarParametro("@id_categoria", despesaModel.CategoriaLancamento.IdCategoria);
                this.dbCore.ComandoAdicionarParametro("@id_subcategoria", despesaModel.SubcategoriaLancamento.IdSubcategoria);
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento", despesaModel.Estabelecimento.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@id_parceiro", despesaModel.Parceiro.IdFornecedor);
                this.dbCore.ComandoAdicionarParametro("@descricao_despesa", despesaModel.DescricaoDespesa);
                this.dbCore.ComandoAdicionarParametro("@data_movimento", despesaModel.DataMovimento);
                this.dbCore.ComandoAdicionarParametro("@valor", despesaModel.Valor);
                //
                retorno = this.dbCore.ExecutarComando("usp_despesa_manter");
            }
            catch (Exception)
            {

                throw;
            }
            //
            return retorno;
        }
        //
        public DataTable DespesaListByAll(DespesaModel despesaModel)
        {
            var listaDespesa = new DataTable();
            //
            try
            {
                this.dbCore.LimparParametros();
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento", despesaModel.Estabelecimento.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@data_inicial", despesaModel.DataMovimento);
                this.dbCore.ComandoAdicionarParametro("@data_final", despesaModel.DataAuxiliar);
                //
                listaDespesa = this.dbCore.ExecutarConsulta("usp_despesa_sel");
            }
            catch (Exception)
            {

                throw;
            }
            //
            return listaDespesa;
        }
        public DespesaListModel DespesaListaTipada(DespesaModel despesaModel)
        {
            var listaDespesa = new DespesaListModel();
            //
            try
            {
                this.dbCore.LimparParametros();
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento", despesaModel.Estabelecimento.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@data_inicial", despesaModel.DataMovimento);
                this.dbCore.ComandoAdicionarParametro("@data_final", despesaModel.DataAuxiliar);
                //

                foreach (DataRow despesa in this.dbCore.ExecutarConsulta("usp_despesa_sel").Rows)
                {
                    listaDespesa.Add(new DespesaModel
                    {
                        CategoriaLancamento = new CategoriaLancamentoModel
                        {
                            IdCategoria = Convert.ToInt32(despesa["id_categoria"]),
                            NomeCategoria = despesa["nome_categoria"].ToString()
                        },
                        //
                        SubcategoriaLancamento = new SubcategoriaLancamentoModel
                        {
                            IdSubcategoria = Convert.ToInt32(despesa["id_subcategoria"]),
                            NomeSubcategoria = despesa["nome_subcategoria"].ToString()
                        },
                        //
                        Parceiro = new FornecedorModel
                        {

                            IdFornecedor = Convert.ToInt32(despesa["id_parceiro"]),
                            NomeFornecedor = despesa["nome_fornecedor"].ToString()
                        },
                        //
                        DataMovimento = Convert.ToDateTime(despesa["data_movimento"]),
                        DescricaoDespesa = despesa["descricao_despesa"].ToString(),
                        IdDespesa = Convert.ToInt32(despesa["id_despesa"]),
                        Estabelecimento = new EstabelecimentoModel
                        {
                            IdEstabelecimento = Convert.ToInt32(despesa["id_estabelecimento"]),
                            NomeEstabelecimento = despesa["nome_estabelecimento"].ToString()
                        },
                        Valor = Convert.ToDecimal(despesa["valor"])
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            //
            return listaDespesa;
        }
    }
}
