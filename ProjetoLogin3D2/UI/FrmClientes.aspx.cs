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
            if (IsPostBack == false)
            {
                this.PreencheTipoUsuario();
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


            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
    }
}