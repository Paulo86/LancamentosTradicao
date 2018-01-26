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
    public partial class FornecedorForm : Form
    {
        FornecedorModel fornecedorModel;
        public FornecedorForm(FornecedorModel fornecedorModel)
        {
            try
            {
                InitializeComponent();
                if (fornecedorModel != null)
                {
                    this.Text = "Alteração de cadastro de Forncedor";
                    this.txtNomeFornecedor.Text = fornecedorModel.NomeFornecedor;
                    this.fornecedorModel = fornecedorModel;
                }
                else
                {
                    this.Text = "Cadastro de novo Fornecedor";
                    this.fornecedorModel = new FornecedorModel();
                }

            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FornecedorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.ProcessTabKey(true);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNomeFornecedor.Text.Trim() != string.Empty)
                {
                    this.fornecedorModel.NomeFornecedor = this.txtNomeFornecedor.Text;
                    //
                    var retorno = new FornecedorDAO().FornecedorManterDAO(this.fornecedorModel);//new FornecedorModel
                                                                                                //
                    if (Char.IsNumber(retorno, 0))
                    {
                        if (this.fornecedorModel.IdFornecedor == 0)
                        {
                            MessageBox.Show("Fornecedor cadastrado com Sucesso !");
                            this.Close();
                        }
                        else if (this.fornecedorModel.IdFornecedor > 0)
                        {
                            MessageBox.Show("Fornecedor atualizado com Sucesso !");
                            this.Close();
                        }
                    }
                    else
                    {
                        throw new Exception(retorno);
                    }
                }
                else
                {
                    this.txtNomeFornecedor.Focus();
                    throw new Exception("Informe o nome do Fornecedor !");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FornecedorForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToChar(e.KeyData) == Convert.ToChar(Keys.F3))
                {
                    this.btnConfirmar.PerformClick();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}

