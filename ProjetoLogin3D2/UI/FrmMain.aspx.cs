using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoLogin3D2.UI
{
    public partial class FrmMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.emailUsuario.Text = Session["usuario"].ToString();
            // verificando se usuário é administrador
            if (Session["tipoUsuario"].ToString() == "2")
            {
                this.btnAdministracao.Visible = false;
            }
        }

        protected void btnMeuPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("/UI/FrmMeuPerfil.aspx");
        }

        protected void btnAdministracao_Click(object sender, EventArgs e)
        {
            Response.Redirect("/UI/FrmPesquisaClientes.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/UI/FrmPesquisaFornecedores.aspx");
        }

        protected void btnClientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("/UI/FrmClientes.aspx");
        }

        protected void BtnProdutos_Click(object sender, EventArgs e)
        {
            Response.Redirect("/UI/FrmProdutos.aspx");
        }
    }
}