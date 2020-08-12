using ProjetoLogin3D2.BLL;
using ProjetoLogin3D2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoLogin3D2.UI
{
    public partial class FrmMeuPerfil : System.Web.UI.Page
    {
        //Instanciar a classe para uso BLL e DTO
        tblClienteBLL bllCliente = new tblClienteBLL();
        tblClienteDTO dtoCliente = new tblClienteDTO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                DataTable dtResult = bllCliente.ListarClientes(Session["usuario"].ToString());
                this.txtNome.Text = dtResult.Rows[0]["nome_cliente"].ToString();
                this.txtSobrenome.Text = dtResult.Rows[0]["sobrenome_cliente"].ToString();
            }
            
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMain.aspx");
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                dtoCliente.Nome_cliente = txtNome.Text;
                dtoCliente.Sobrenome_cliente = txtSobrenome.Text;
                this.msgerro.Visible = false;
                // Consistencia se Senha atual é igual senha do banco
                if (txtSenhaAtual.Text != bllCliente.RecuperarSenha(Session["usuario"].ToString()))
                {
                    this.msgerro.Visible = true;
                    this.msgerro.Text = "A senha atual digitada não confere.";
                }
                if (txtNovaSenha.Text != txtRNovaSenha.Text)
                {
                    this.msgerro.Visible = true;
                    this.msgerro.Text = "As senhas digitadas não conferem.";
                }
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }

        }
    }
}