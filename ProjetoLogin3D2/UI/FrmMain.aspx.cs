using ProjetoLogin3D2.BLL;
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
        tblProdutoBLL bllproduto = new tblProdutoBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.emailUsuario.Text = Session["usuario"].ToString();
            // verificando se usuário é administrador
           
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

        protected void BtnSair_Click(object sender, EventArgs e)
        {
            Session["usuario"] = "";
            Session["tipoUsuario"] = "";

          Response.Redirect("/UI/signIn.aspx");
        }

        protected void btnPesquisa_Click(object sender, EventArgs e)
        {
            string condicao = "nomeproduto like '%" + txtPesquisa.Text + "%' order by nomeproduto";
            GridProdutos.DataSource = bllproduto.PesquisarProdutos(condicao);
            GridProdutos.DataBind();
        }
    }
}