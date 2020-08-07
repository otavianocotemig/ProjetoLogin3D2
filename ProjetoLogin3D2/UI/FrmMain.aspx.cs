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
            if (Session["tipoUsuario"].ToString() == "1")
            {
                this.btnAdministracao.Visible = false;
            }
        }

        protected void btnMeuPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("/UI/FrmMeuPerfil.aspx");
        }
    }
}