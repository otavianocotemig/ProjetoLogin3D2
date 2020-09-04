using ProjetoLogin3D2.BLL;
using ProjetoLogin3D2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoLogin3D2.UI
{
    public partial class FrmClientes : System.Web.UI.Page
    {
        // Instanciar Blls e DTOs
        tblClienteBLL bllCliente = new tblClienteBLL();
        tblClienteDTO dtoCliente = new tblClienteDTO();
        tblTipousuarioBLL bllTipoUsuario = new tblTipousuarioBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("signin.aspx");
            }

            if (IsPostBack == false)
            {
                this.PreencheTipoUsuario();
                this.ExibirGridClientes();
            }
          
        }

        public void PreencheTipoUsuario()
        {
            drpTipoUsuario.DataSource = bllTipoUsuario.ListarTipoUsuario();
            drpTipoUsuario.DataTextField = "descricao";
            drpTipoUsuario.DataValueField = "id";
            drpTipoUsuario.DataBind();

        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMain.aspx");
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                // inserir os dados da UI no DTO
                dtoCliente.Nome_cliente = txtNome.Text;
                dtoCliente.Sobrenome_cliente = txtSobrenome.Text;
                dtoCliente.Email_cliente = txtEmail.Text;
                dtoCliente.Cpf_cliente = txtCpf.Text;
                dtoCliente.Senha_cliente = txtSenhaAtual.Text;
                dtoCliente.Tp_usuario = int.Parse(drpTipoUsuario.SelectedValue.ToString());

                // Inserir na tabela de clientes
                bllCliente.InserirCliente(dtoCliente);
                msgerro.Visible = true;
                msgerro.Text = "Cliente Inserido com Sucesso";
                this.LimparCampos();
                this.ExibirGridClientes();


            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }

        // Metodo para Exibir Dados no Grid
        public void ExibirGridClientes()
        {
            GridClientes.DataSource = bllCliente.ListarClientes();
            GridClientes.DataBind();
        }

        protected void GridClientes_RowDeleting(object sender, GridViewDeleteEventArgs Registro)
        {
            try
            {
                dtoCliente.Id_cliente = Convert.ToInt32(Registro.Values[0]);
                bllCliente.ExcluirCliente(dtoCliente);
                this.ExibirGridClientes();
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
        public void LimparCampos()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtEmail.Text = "";
            txtCpf.Text = "";
            txtSenhaAtual.Text = "";
        }

        // Metodo para Edição de Dados no Grid
        protected void GridClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridClientes.EditIndex = e.NewEditIndex;
            this.ExibirGridClientes();
        }
        // Metodo Utilizado para Salvar a Edição dos dados do grid
        protected void GridClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                dtoCliente.Nome_cliente = e.NewValues[1].ToString();
                dtoCliente.Sobrenome_cliente = e.NewValues[2].ToString();
                dtoCliente.Email_cliente = e.NewValues[3].ToString();
                dtoCliente.Senha_cliente = e.NewValues[4].ToString();
                dtoCliente.Cpf_cliente = e.NewValues[5].ToString();
                bllCliente.AlterarCliente(dtoCliente);
                GridClientes.EditIndex = -1;
                this.ExibirGridClientes();
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
        // Metodo para Cancelar Edição no Grid
        protected void GridClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridClientes.EditIndex = -1;
            this.ExibirGridClientes();
        }

        protected void GridClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridClientes.PageIndex = e.NewPageIndex;
            this.ExibirGridClientes();
        }
    }
}