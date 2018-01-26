using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class FornecedorPrincipalForm : Form
    {
        //AcaoForm acaoForm;
        //
        public FornecedorPrincipalForm()
        {
            try
            {
                this.InitializeComponent();
                this.CarregarDataGrid();

            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("{0}", exception.Message));
            }

        }
        //
        private void CarregarDataGrid()
        {
            try
            {
                this.dgvFornecedor.DataSource = new FornecedorDAO().ForncedorLista();
            }
            catch (Exception exception)
            {

                throw new Exception(string.Format("Erro ao carredar Fornecedores cadastrados !\nDetalhes: {0}", exception.Message));
            }
        }

        private void FornecedoresForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new FornecedorForm(null))
                {
                    f.ShowDialog();
                    this.CarregarDataGrid();
                }

                //if (this.txtNomeFornecedor.Text.Trim() != string.Empty)
                //{
                //    var idFornecedor = 0;
                //    //
                //    if (this.dgvFornecedor.Rows.Count != 0)
                //        idFornecedor = Convert.ToInt32(this.dgvFornecedor.CurrentRow.Cells["clCodigo"].Value);
                //    //
                //    var fornecdorModel = new FornecedorModel
                //    {
                //        IdFornecedor = idFornecedor,
                //        NomeFornecedor = this.txtNomeFornecedor.Text
                //    };
                //    //
                //    var retorno = new FornecedorDAO().FornecedorManterDAO(fornecdorModel);//new FornecedorModel
                //    //
                //    if (Char.IsNumber(retorno, 0))
                //    {
                //        MessageBox.Show("Fornecedor cadastrado com Sucesso !");
                //        //Carregar o grid
                //        this.txtNomeFornecedor.Clear();
                //        this.txtNomeFornecedor.Focus();
                //        this.CarregarDataGrid();
                //    }
                //    else
                //    {
                //        throw new Exception(retorno);
                //    }
                //}
                //else
                //{
                //    this.txtNomeFornecedor.Focus();
                //    throw new Exception("Informe o nome do Fornecedor !");
                //}

            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Erro ao cadastrar Fornecedor !\nDetalhes: {0}", exception.Message));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir este registro ?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var retorno = new FornecedorDAO().FornecedorExcluir(Convert.ToInt32(this.dgvFornecedor.CurrentRow.Cells["clCodigo"].Value));
                    if (Char.IsNumber(retorno, 0))
                    {
                        MessageBox.Show("Registro excluido com sucesso !");
                        this.CarregarDataGrid();
                    }
                    else
                        throw new Exception(retorno);
                }
                else
                    return;
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Erro ao excluir registro !\nDetalhes: {0}", exception.Message));

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                var fornecedor = new FornecedorDAO().ForncedorLista().Select(x => new
                {
                    idFornecedor = x.IdFornecedor,
                    nomeFornecedor = x.NomeFornecedor
                }).Where(x => x.idFornecedor == Convert.ToInt32(this.dgvFornecedor.CurrentRow.Cells["clCodigo"].Value)).Single();
                var fornecedorModel = new FornecedorModel
                {
                    IdFornecedor = fornecedor.idFornecedor,
                    NomeFornecedor = fornecedor.nomeFornecedor
                };
                //  
                using (var f = new FornecedorForm(fornecedorModel))
                {
                    f.ShowDialog();
                    this.CarregarDataGrid();
                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }
    }
}
