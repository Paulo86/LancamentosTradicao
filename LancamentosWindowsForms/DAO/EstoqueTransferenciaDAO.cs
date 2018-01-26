using LancamentosWindowsForms.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancamentosWindowsForms.DAO
{
   public class EstoqueTransferenciaDAO
    {
        DBCore dbCore;
        //
        public EstoqueTransferenciaDAO()
        {
            this.dbCore = new DBCore();
        }
        //
        public string EstoqueTransferenciaManter(EstoqueTransferenciaModel estoqueTransferenciaModel)
        {
            var retorno = string.Empty;
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_transferencia", estoqueTransferenciaModel.IdTransferencia);
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento_origem", estoqueTransferenciaModel.EstabelecimentoOrigem.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento_destino", estoqueTransferenciaModel.EstabelecimentoDestino.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@id_produto", estoqueTransferenciaModel.Produto.IdProduto);
                this.dbCore.ComandoAdicionarParametro("@quantidade", estoqueTransferenciaModel.QuantidadeTotal);
                this.dbCore.ComandoAdicionarParametro("@data_movimento", estoqueTransferenciaModel.DataMovimentoInicial);
                this.dbCore.ComandoAdicionarParametro("@preco_custo", estoqueTransferenciaModel.Produto.PrecoCusto);
                //
                retorno = this.dbCore.ExecutarComando("usp_transferencia_estoque_manter");
            }
            catch (Exception)
            {

                throw;
            }
            //
            return retorno;
        }
        //
        public DataTable DataTableEstoqueTransferencia(EstoqueTransferenciaModel estoqueTransferenciaModel)
        {
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento_origem", estoqueTransferenciaModel.EstabelecimentoOrigem.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@id_estabecimento_destino", estoqueTransferenciaModel.EstabelecimentoDestino.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@data_movimento_inicial", estoqueTransferenciaModel.DataMovimentoInicial);
                this.dbCore.ComandoAdicionarParametro("@data_movimento_final", estoqueTransferenciaModel.DataMovimentoFinal);
                //
                return this.dbCore.ExecutarConsulta("usp_transferencia_estoque_sel");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
