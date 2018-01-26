using LancamentosWindowsForms.Model;
using System;
using System.Data;

namespace LancamentosWindowsForms.DAO
{
    public class NotaFiscalDAO
    {
        DBCore dbCore;
        //
        public NotaFiscalDAO()
        {
            this.dbCore = new DBCore();
        }
        //
        public string NotaFiscalManter(NotaFiscalModel notaFiscalModel)
        {
            var retorno = string.Empty;
            //
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_nota_fiscal", notaFiscalModel.IdNotaFiscal);
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento", notaFiscalModel.Estabelecimento.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@id_fornecedor", notaFiscalModel.Fornecedor.IdFornecedor);
                this.dbCore.ComandoAdicionarParametro("@numero_nota_fiscal", notaFiscalModel.NumeroNotaFiscal);
                this.dbCore.ComandoAdicionarParametro("@data_emissao", notaFiscalModel.DataEmissaoInicial);
                this.dbCore.ComandoAdicionarParametro("@data_entrada", notaFiscalModel.DataEntradaInicial);
                this.dbCore.ComandoAdicionarParametro("@valor_total_nota_fiscal", notaFiscalModel.ValorTotalDaNota);
                this.dbCore.ComandoAdicionarParametro("@valor_total_icms_st", notaFiscalModel.ValorTotalDoIcmsSt);
                this.dbCore.ComandoAdicionarParametro("@valor_total_ipi", notaFiscalModel.ValorTotalDoIpi);
                this.dbCore.ComandoAdicionarParametro("@valor_total_depesa", notaFiscalModel.ValorTotalDasDespesas);
                //
                retorno = this.dbCore.ExecutarComando("usp_nota_fiscal_manter");
            }
            catch (Exception)
            {

                throw;
            }
            //
            return retorno;
        }
        //
        public string ProdutoNotaFiscalManter(ProdutoNotaFiscalModel produtoNotaFiscalModel)
        {
            var retorno = string.Empty;
            //
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_produto", produtoNotaFiscalModel.Produto.IdProduto);
                this.dbCore.ComandoAdicionarParametro("@id_nota_fiscal", produtoNotaFiscalModel.NotaFiscal.IdNotaFiscal);
                this.dbCore.ComandoAdicionarParametro("@quantidade", produtoNotaFiscalModel.Quantidade);
                this.dbCore.ComandoAdicionarParametro("@quantidade_embalagem", produtoNotaFiscalModel.QuantidadePorEmbalagem);
                this.dbCore.ComandoAdicionarParametro("@valor_unitario", produtoNotaFiscalModel.ValorUnitario);
                this.dbCore.ComandoAdicionarParametro("@custo_sem_imposto", produtoNotaFiscalModel.CustoSemImposto);
                this.dbCore.ComandoAdicionarParametro("@custo_com_imposto", produtoNotaFiscalModel.CustoComImposto);
                this.dbCore.ComandoAdicionarParametro("@valor_icms_st", produtoNotaFiscalModel.ValorTotalDoIcmsSt);
                this.dbCore.ComandoAdicionarParametro("@valor_ipi", produtoNotaFiscalModel.ValorTotalDoIpi);
                this.dbCore.ComandoAdicionarParametro("@valor_desconto", produtoNotaFiscalModel.ValorTotalDoDesconto);
                this.dbCore.ComandoAdicionarParametro("@observacao", produtoNotaFiscalModel.Observacao);
                //
                retorno = this.dbCore.ExecutarComando("usp_produto_nota_fiscal_manter");
            }
            catch (Exception)
            {

                throw;
            }
            //
            return retorno;
        }
        //
        public ProdutoNotaFiscalListModel ProdutosNotaFiscalLista(ProdutoNotaFiscalModel produtoNotaFiscalModel)
        {
            var listaProduto = new ProdutoNotaFiscalListModel();
            //
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_nota_fiscal", produtoNotaFiscalModel.NotaFiscal.IdNotaFiscal);
                this.dbCore.ComandoAdicionarParametro("@id_produto", produtoNotaFiscalModel.Produto.IdProduto);
                //
                foreach (DataRow produtoNotaFiscal in this.dbCore.ExecutarConsulta("usp_produto_nota_fiscal_sel").Rows)
                {
                    listaProduto.Add(new ProdutoNotaFiscalModel
                    {
                        Produto = new ProdutoModel
                        {
                            IdProduto = Convert.ToInt32(produtoNotaFiscal["id_produto"]),
                            NomeProduto = produtoNotaFiscal["nome_produto"].ToString()
                        },
                        NotaFiscal = new NotaFiscalModel
                        {
                            IdNotaFiscal = Convert.ToInt32(produtoNotaFiscal["id_nota_fiscal"])
                        },
                        Quantidade = Convert.ToDecimal(produtoNotaFiscal["quantidade"]),
                        QuantidadePorEmbalagem = Convert.ToDecimal(produtoNotaFiscal["quantidade_embalagem"]),
                        ValorUnitario = Convert.ToDecimal(produtoNotaFiscal["valor_unitario"]),
                        CustoSemImposto = Convert.ToDecimal(produtoNotaFiscal["custo_sem_imposto"]),
                        CustoComImposto = Convert.ToDecimal(produtoNotaFiscal["custo_com_imposto"]),
                        ValorTotalDoIcmsSt = Convert.ToDecimal(produtoNotaFiscal["valor_icms_st"]),
                        ValorTotalDoIpi = Convert.ToDecimal(produtoNotaFiscal["valor_ipi"]),
                        ValorTotalDoDesconto = Convert.ToDecimal(produtoNotaFiscal["valor_desconto"]), 
                        Observacao = produtoNotaFiscal["observacao"].ToString()
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            //
            return listaProduto;
        }
        //
        public DataTable DataTableNotaFiscal(NotaFiscalModel notaFiscalModel)
        {
            try
            {
                this.dbCore.LimparParametros();
                //
                this.dbCore.ComandoAdicionarParametro("@id_estabelecimento", notaFiscalModel.Estabelecimento.IdEstabelecimento);
                this.dbCore.ComandoAdicionarParametro("@id_fornecedor", notaFiscalModel.Fornecedor.IdFornecedor);
                this.dbCore.ComandoAdicionarParametro("@data_entrada_inicial", notaFiscalModel.DataEntradaInicial);
                this.dbCore.ComandoAdicionarParametro("@data_entrada_final", notaFiscalModel.DataEntradaFinal);
                this.dbCore.ComandoAdicionarParametro("@data_emissao_inicial", notaFiscalModel.DataEmissaoInicial);
                this.dbCore.ComandoAdicionarParametro("@data_emissao_final", notaFiscalModel.DataEmissaoFinal);
                //
                return this.dbCore.ExecutarConsulta("usp_nota_fiscal_sel");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
