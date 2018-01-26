using System;
using System.Data;
using System.Data.SqlClient;

namespace LancamentosWindowsForms.DAO
{
    public class DBCore
    {
        private SqlConnection novaConexaoLancamento()
        {
            try
            {
                //Data Source=192.168.1.197;Initial Catalog=Lancamentos;User ID=sa;Password=hiper

                return new SqlConnection("Data Source=cctradicao.dyndns.org;Initial Catalog=Lancamentos;User ID=sa;Password=hiper");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            this.sqlParameterCollection.Clear();
        }

        public void ComandoAdicionarParametro(String nomeParametro, Object valorParametro)
        {
            try
            {
                sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public String ExecutarComando(String nomeProcedure)
        {
            //SqlConnection cn = novaConexao();
            using (var conexao = new SqlConnection(Properties.Settings.Default.strConexaoBancoDadosLancamento))
            //
            //SqlCommand cmd = conexao.CreateCommand();
            using (var sqlCommand = new SqlCommand(nomeProcedure, conexao))
            {
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 7200;
                //
                foreach (SqlParameter parametro in this.sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(parametro.ParameterName, parametro.Value));
                }
                //
                try
                {
                    conexao.Open();
                    String retorno = sqlCommand.ExecuteScalar().ToString();
                    conexao.Close();
                    return retorno;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                        conexao.Dispose();
                    }
                }
            }


        }

        public DataTable ExecutarConsulta(String nomeProcedure)
        {
            DataTable dt = new DataTable();
            //
            using (var conexao = new SqlConnection(Properties.Settings.Default.strConexaoBancoDadosLancamento))
            {
                using (var sqlCommand = new SqlCommand(nomeProcedure, conexao))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 7200;
                    //
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    //
                    foreach (SqlParameter parametro in sqlParameterCollection)
                    {
                        sqlCommand.Parameters.Add(new SqlParameter(parametro.ParameterName, parametro.Value));
                    }
                    //
                    try
                    {
                        da.Fill(dt);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            //
            return dt;
        }

        public void ImportarProdutoHiper()
        {
            try
            {
                DataTable dt = new DataTable();
                //
                using (var conexao = new SqlConnection(Properties.Settings.Default.strConexaoBancoDadosHiper))
                {
                    var scriptSql = "SELECT id_produto, nome, preco_custo, preco_venda, produto_integrado_balanca as id_departamento FROM produto";
                    using (var sqlCommand = new SqlCommand(scriptSql, conexao))
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandTimeout = 7200;
                        //
                        SqlDataAdapter daProduto = new SqlDataAdapter(sqlCommand);
                        //
                        foreach (SqlParameter parametro in sqlParameterCollection)
                        {
                            sqlCommand.Parameters.Add(new SqlParameter(parametro.ParameterName, parametro.Value));
                        }
                        //
                        try
                        {
                            daProduto.Fill(dt);
                            foreach (DataRow produto in dt.Rows)
                            {
                                var retorno = string.Empty;
                                this.LimparParametros();
                                //
                                this.ComandoAdicionarParametro("@id_produto", Convert.ToDecimal(produto["id_produto"]));
                                this.ComandoAdicionarParametro("@nome_produto", produto["nome"].ToString());
                                this.ComandoAdicionarParametro("@id_departamento", Convert.ToInt32(produto["id_departamento"]));
                                this.ComandoAdicionarParametro("@preco_custo", Convert.ToDecimal(produto["preco_custo"]));
                                this.ComandoAdicionarParametro("@preco_venda", Convert.ToDecimal(produto["preco_venda"]));
                                retorno = this.ExecutarComando("usp_produto_manter");
                                //
                            }
                        }                        
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ImportarProdutoEanHiper()
        {
            try
            {
                DataTable dt = new DataTable();
                //
                using (var conexao = new SqlConnection(Properties.Settings.Default.strConexaoBancoDadosHiper))
                {
                    var scriptSql = "SELECT id_produto, codigo_barras FROM produto_sinonimo";
                    using (var sqlCommand = new SqlCommand(scriptSql, conexao))
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandTimeout = 7200;
                        //
                        SqlDataAdapter daProduto = new SqlDataAdapter(sqlCommand);
                        //
                        foreach (SqlParameter parametro in sqlParameterCollection)
                        {
                            sqlCommand.Parameters.Add(new SqlParameter(parametro.ParameterName, parametro.Value));
                        }
                        //
                        try
                        {
                            daProduto.Fill(dt);
                            foreach (DataRow produto in dt.Rows)
                            {
                                var retorno = string.Empty;
                                this.LimparParametros();
                                //
                                this.ComandoAdicionarParametro("@id_produto", Convert.ToDecimal(produto["id_produto"]));
                                this.ComandoAdicionarParametro("@codigo_ean", produto["codigo_barras"].ToString());
                                retorno = this.ExecutarComando("usp_produto_ean_manter");
                                //
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
