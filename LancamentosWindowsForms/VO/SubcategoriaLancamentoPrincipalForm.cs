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
    public partial class SubcategoriaLancamentoPrincipalForm : Form
    {
        SubcategoriaLancamentoModel subcategoriaLancamentoModel;
        //
        public SubcategoriaLancamentoPrincipalForm(SubcategoriaLancamentoModel subcategoriaLancamentoModel)
        {
            try
            {
                this.InitializeComponent();
                this.CarregarComboBoxCategoriaLancamento();
                //
                if (subcategoriaLancamentoModel != null)
                {
                    this.subcategoriaLancamentoModel = subcategoriaLancamentoModel;
                    this.Text = "Alteração de Subcategoria de Lançamento";
                    //
                    this.cbbCategoria.SelectedValue = subcategoriaLancamentoModel.CategoriaLancamento.IdCategoria;
                    this.txtNomeSubcategoria.Text = subcategoriaLancamentoModel.NomeSubcategoria;
                }
                else
                {
                    this.subcategoriaLancamentoModel = new SubcategoriaLancamentoModel();
                    this.Text = "Cadastro de nova Subcategoria de Lançamento";
                }

            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }
        //
        private void CarregarComboBoxCategoriaLancamento()
        {
            try
            {
                var listaCategoria = new CategoriaLancamentoListModel();
                listaCategoria.Add(new CategoriaLancamentoModel
                {
                    IdCategoria = 0,
                    NomeCategoria = "[Selecione a Categoria de Lançamento]"

                });


                foreach (var categoria in new CategoriaLancamentoDAO().CategoriaLancamentoList())
                {
                    listaCategoria.Add(categoria);
                }
                this.cbbCategoria.DataSource = listaCategoria;
                this.cbbCategoria.DisplayMember = "NomeCategoria";
                this.cbbCategoria.ValueMember = "IdCategoria";
            }
            catch (Exception)
            {
                throw;
            }
        }
        //
        private void SubcategoriaLancamentoPrincipalForm_KeyPress(object sender, KeyPressEventArgs e)
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
        //
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                using (var frmCategoria = new CategoriaLancamentoForm())
                {
                    frmCategoria.ShowDialog();
                    this.CarregarComboBoxCategoriaLancamento();

                }
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }
        //
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(this.cbbCategoria.SelectedValue) == 0)
                    throw new Exception("Informe a Categoria de Lançamento !");
                else if (this.txtNomeSubcategoria.Text.Trim() == string.Empty)
                    throw new Exception("Informe a Descrição da subcategoria !");
                else
                {
                    this.subcategoriaLancamentoModel.CategoriaLancamento.IdCategoria = Convert.ToInt32(this.cbbCategoria.SelectedValue);
                    this.subcategoriaLancamentoModel.NomeSubcategoria = this.txtNomeSubcategoria.Text;
                    var retorno = new SubcategoriaLancamentoDAO().SubcategoriaManter(this.subcategoriaLancamentoModel);
                    //
                    switch (retorno)
                    {
                        case "INSERT OK":
                            Mensagens.MensagemInformacao("Subcategoria de Lançamento cadastrada com sucesso !");
                            this.Close();
                            break;
                        //
                        case "UPDATE OK":
                            Mensagens.MensagemInformacao("Subcategoria de Lançamento atualizada com sucesso !");
                            this.Close();
                            break;
                        //
                        default:
                            Mensagens.MensagemErro(retorno);
                            break;
                    }

                }
            }
            catch (Exception exception)
            {
                Mensagens.MensagemErro(exception.Message);                
            }
        }

        private void SubcategoriaLancamentoPrincipalForm_KeyDown(object sender, KeyEventArgs e)
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
