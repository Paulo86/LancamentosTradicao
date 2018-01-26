using LancamentosWindowsForms.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancamentosWindowsForms.DAO
{
    public class LancamentoDAO
    {
        DBCore dbCore;
        public LancamentoDAO()
        {
            this.dbCore = new DBCore();
        }
        //
        public string LancamentoInserir(LancamentoModel lancamentoModel)
        {
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_lancamento", lancamentoModel.IdLancamento);
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento", lancamentoModel.Estabelecimento.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@id_fornecedor", lancamentoModel.Fornecedor.IdFornecedor);
                this.dbCore.ComandoAdicionarParametro("@data_entrada", lancamentoModel.DataEntradaInicial);
                this.dbCore.ComandoAdicionarParametro("@data_vencimento", lancamentoModel.DataVencimentoInicial);
                this.dbCore.ComandoAdicionarParametro("@numero_documento", lancamentoModel.NumeroDocumento);
                this.dbCore.ComandoAdicionarParametro("@valor_total", lancamentoModel.ValorTotal);
                this.dbCore.ComandoAdicionarParametro("@data_liquidacao", lancamentoModel.DataLiquidacao);
                this.dbCore.ComandoAdicionarParametro("@data_lancamento_liquidacao", lancamentoModel.DataLancamentoLiquidacao);
                this.dbCore.ComandoAdicionarParametro("@valor_liquidado", lancamentoModel.ValorLiquidado);
                this.dbCore.ComandoAdicionarParametro("@flag_liquidado", lancamentoModel.FlagLiquidado);
                //
                return this.dbCore.ExecutarComando("usp_lancamentos_manter");
            }
            catch (Exception)
            {

                throw;
            }

        }
        //
        public LancamentoListaModel LancamentoLista(LancamentoModel lancamentoModel)
        {
            var lancamentoListaModel = new LancamentoListaModel();
            //
            try
            {
                this.dbCore.LimparParametros();
                //                
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento", lancamentoModel.Estabelecimento.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@id_fornecedor", lancamentoModel.Fornecedor.IdFornecedor);
                this.dbCore.ComandoAdicionarParametro("@data_entrada_inicial", lancamentoModel.DataEntradaInicial);
                this.dbCore.ComandoAdicionarParametro("@data_entrada_final", lancamentoModel.DataEntradaFinal);
                this.dbCore.ComandoAdicionarParametro("@data_vencimento_inicial", lancamentoModel.DataVencimentoInicial);
                this.dbCore.ComandoAdicionarParametro("@data_vencimento_final", lancamentoModel.DataVencimentoFinal);
                //
                foreach (DataRow lancamento in this.dbCore.ExecutarConsulta("usp_lancamentos_sel_by_all").Rows)
                {
                    lancamentoListaModel.Add(new LancamentoModel
                    {
                        IdLancamento = Convert.ToInt32(lancamento["id_lancamento"]),
                        Estabelecimento = new EstabelecimentoModel
                        {
                            IdEstabelecimento = Convert.ToInt32(lancamento["id_estabelecimento"]),
                            NomeEstabelecimento = lancamento["nome_estabelecimento"].ToString()
                        },
                        Fornecedor = new FornecedorModel
                        {
                            IdFornecedor = Convert.ToInt32(lancamento["id_fornecedor"]),
                            NomeFornecedor = lancamento["nome_fornecedor"].ToString()
                        },
                        DataEntradaInicial = Convert.ToDateTime(lancamento["data_entrada"]),
                        DataVencimentoInicial = Convert.ToDateTime(lancamento["data_vencimento"]),
                        NumeroDocumento = lancamento["numero_documento"].ToString(),
                        ValorTotal = Convert.ToDecimal(lancamento["valor_total"]),
                        Status = lancamento["Status"].ToString(),
                        DataLiquidacao = Convert.ToDateTime(lancamento["data_liquidacao"]),
                        ValorLiquidado = Convert.ToDecimal(lancamento["valor_liquidado"])
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
            return lancamentoListaModel;
        }
        //
        public string LancamentoExcluir(int idLancamento)
        {
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_lancamento", idLancamento);
                //
                return this.dbCore.ExecutarComando("usp_lancamentos_del");
            }
            catch (Exception)
            {

                throw;
            }
        }
        //
        public DataTable BoletosDataTable(LancamentoModel lancamentoModel)
        {
            var lancamentoListaModel = new DataTable();
            //
            try
            {
                this.dbCore.LimparParametros();
                //                
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento", lancamentoModel.Estabelecimento.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@id_fornecedor", lancamentoModel.Fornecedor.IdFornecedor);
                this.dbCore.ComandoAdicionarParametro("@data_entrada_inicial", lancamentoModel.DataEntradaInicial);
                this.dbCore.ComandoAdicionarParametro("@data_entrada_final", lancamentoModel.DataEntradaFinal);
                this.dbCore.ComandoAdicionarParametro("@data_vencimento_inicial", lancamentoModel.DataVencimentoInicial);
                this.dbCore.ComandoAdicionarParametro("@data_vencimento_final", lancamentoModel.DataVencimentoFinal);
                //
                lancamentoListaModel = this.dbCore.ExecutarConsulta("usp_lancamentos_sel_by_all");               

            }
            catch (Exception)
            {

                throw;
            }
            return lancamentoListaModel;
        }
    }
}

