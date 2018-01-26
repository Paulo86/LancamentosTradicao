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
    public partial class InventarioCadastroForm : Form
    {
        public InventarioCadastroForm()
        {
            try
            {
                InitializeComponent();
                this.CarregarComboBoxDepartamento();
                this.CarregarComboBoxEstabelecimento();
                this.CarregarComboBoxStatus();
            }
            catch (Exception exception)
            {

                Mensagens.MensagemErro(exception.Message);
            }
        }
        //
        private void CarregarComboBoxDepartamento()
        {
            var listaDepartamento = new List<Departamento>();
            listaDepartamento.Add(new Departamento { IdDepartamento = -1, NomeDepartamento = "(Selecione o Departamento)" });
            listaDepartamento.Add(new Departamento { IdDepartamento = 0, NomeDepartamento = "Mercearia" });
            listaDepartamento.Add(new Departamento { IdDepartamento = 1, NomeDepartamento = "Açougue" });
            //
            this.cbbDepartamento.ValueMember = "IdDepartamento";
            this.cbbDepartamento.DisplayMember = "NomeDepartamento";
            this.cbbDepartamento.DataSource = listaDepartamento;
            this.cbbDepartamento.SelectedValue = -1;
        }
        //
        private void CarregarComboBoxEstabelecimento()
        {
            try
            {
                var listaEstabelecimento = new EstabelecimentoListaModel();
                listaEstabelecimento.Add(new EstabelecimentoModel
                {
                    IdEstabelecimento = 0,
                    NomeEstabelecimento = "(Selecione o Estabelecimento)"
                });
                //
                foreach (var estabelecimento in new EstabelecimentoDAO().EstabelecimentoLista())
                {
                    listaEstabelecimento.Add(estabelecimento);
                }
                this.cbbEstabelecimento.DataSource = listaEstabelecimento;
                this.cbbEstabelecimento.DisplayMember = "NomeEstabelecimento";
                this.cbbEstabelecimento.ValueMember = "IdEstabelecimento";

            }
            catch (Exception exception)
            {

                throw new Exception(string.Format("Erro ao carregar Estabelecimentos cadastrados !\nDetalhes: {0}", exception.Message));
            }
        }
        //
        private void CarregarDatagridProduto()
        {
            try
            {
                var listaProduto = new ProdutoListModel();
                //
                foreach (DataRow produto in new ProdutoDAO().ProdutoListByAll(string.Empty, Convert.ToInt32(this.cbbEstabelecimento.SelectedValue)).Rows)
                {
                    listaProduto.Add(new ProdutoModel
                    {
                        IdProduto = Convert.ToInt32(produto["id_produto"]),
                        NomeProduto = produto["nome_produto"].ToString()
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        //
        private void CarregarComboBoxStatus()
        {
            try
            {
                var lista = new List<Status>();
                lista.Add(new Status { IdStatus = 0, DescricaoStatus = "Aberto" });
                lista.Add(new Status { IdStatus = 1, DescricaoStatus = "Finalizado" });
                //
                this.cbbStatus.DisplayMember = "DescricaoStatus";
                this.cbbStatus.ValueMember = "IdStatus";
                this.cbbStatus.DataSource = lista;
                this.cbbStatus.Update();
                this.cbbStatus.Refresh();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Erro ao carregar Status !\nDetalhes", ex.Message));
            }
        }
        //
        private void DigitaEstoqueProdutoForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception)
            {

                return;
            }
        }
        //
        private void DigitaEstoqueProdutoForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToChar(e.KeyData) == Convert.ToChar(Keys.F3))
                {
                    //this.btnConfirmar.PerformClick();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        //
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void InventarioCadastroForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Mensagens.MensagemErro("Erro ao gravar inventário !\nDetalhes: " + ex.Message);
            }
        }
    }
}
//
class Departamento
{
    public Departamento()
    {
        this.IdDepartamento = -1;
        this.NomeDepartamento = "Selecione o departamento...";
    }
    //
    public int IdDepartamento { get; set; }
    public string NomeDepartamento { get; set; }
}
//
class Status
{
    public Status()
    {
        this.IdStatus = 0;
        this.DescricaoStatus = string.Empty;
    }
    public int IdStatus { get; set; }
    public string DescricaoStatus { get; set; }
}

