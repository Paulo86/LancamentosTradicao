using LancamentosWindowsForms.DAO;
using LancamentosWindowsForms.Model;
using System;
using System.Windows.Forms;

namespace LancamentosWindowsForms.VO
{
    public partial class CategoriaLancamentoPrincipalForm : Form
    {
        CategoriaLancamentoModel categoriaLancamentoModel;
        //
        public CategoriaLancamentoPrincipalForm(CategoriaLancamentoModel categoriaLancamentoModel)
        {
            this.categoriaLancamentoModel = new CategoriaLancamentoModel();
            //
            InitializeComponent();
            if (categoriaLancamentoModel != null)
            {
                this.categoriaLancamentoModel = categoriaLancamentoModel;
                this.txtNomeCategoria.Text = categoriaLancamentoModel.NomeCategoria;
            }

        }

        private void CategoriaLancamentoPrincipalForm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNomeCategoria.Text.Trim() == string.Empty)
                {
                    throw new Exception("Nome Categoria é obrigatório !");
                }
                //
                var retorno = new CategoriaLancamentoDAO().LancamentoCategoriaManter(new CategoriaLancamentoModel
                {
                    IdCategoria = this.categoriaLancamentoModel.IdCategoria,
                    NomeCategoria = this.txtNomeCategoria.Text.ToUpper()
                });
                //
                switch (retorno)
                {
                    case "INSERT OK":
                        Mensagens.MensagemInformacao("Categoria de Lançamento cadastrada com sucesso !");
                        this.Close();
                        break;
                    //
                    case "UPDATE OK":
                        Mensagens.MensagemInformacao("Categoria de Lançamento atualizada com sucesso !");
                        this.Close();
                        break;
                    //
                    default:
                        Mensagens.MensagemErro(retorno);
                        break;
                }
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }

        private void CategoriaLancamentoPrincipalForm_KeyDown(object sender, KeyEventArgs e)
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
