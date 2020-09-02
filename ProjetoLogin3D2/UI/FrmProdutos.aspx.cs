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
    public partial class FrmProdutos : System.Web.UI.Page
    {
        //Instancia do meu DTO e BLL
        tblProdutoBLL bllProduto = new tblProdutoBLL();
        tblProdutoDTO dtoProduto = new tblProdutoDTO();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMain.aspx");
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            try { 
                string condicao = "nomeproduto like '%" + txtPesquisa.Text + "%'";
                GridProdutos.DataSource = bllProduto.PesquisarProdutos(condicao);
                GridProdutos.DataBind();
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
    }
}