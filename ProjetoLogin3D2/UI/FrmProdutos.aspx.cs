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
            // Verificar se usuário está logado
            if (Session["usuario"] == null)
            {
                Response.Redirect("signin.aspx");
            }
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMain.aspx");
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            try {
                this.ExibirGridProdutos();
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }

        protected void GridProdutos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                dtoProduto.Id = Convert.ToInt32(e.Values[0]);
                bllProduto.ExcluirProdutos(dtoProduto);
                this.ExibirGridProdutos();
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
        // Metodo Utilizado para ExibirDados do Grid
        public void ExibirGridProdutos()
        {
            string condicao = "";
            if (OrdenarNome.Checked == true)
            {
                condicao = "nomeproduto like '%" + txtPesquisa.Text + "%' order by nomeproduto";
            }
            else
            {
                condicao = "nomeproduto like '%" + txtPesquisa.Text + "%' order by id";
            }
            
            GridProdutos.DataSource = bllProduto.PesquisarProdutos(condicao);
            GridProdutos.DataBind();
        }

        protected void GridProdutos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridProdutos.PageIndex = e.NewPageIndex;
            this.ExibirGridProdutos();
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("/UI/FrmManProdutos.aspx");
        }
    }
}