using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetoLogin3D2.DTO;
using ProjetoLogin3D2.BLL;

namespace ProjetoLogin3D2.UI
{
    public partial class FrmPesquisaFornecedores : System.Web.UI.Page
    {

        //Instanciar a classe para uso BLL e DTO
        tblFornecedorDTO dtoFornecedor = new tblFornecedorDTO();
        tblFornecedorBLL bllFornecedor = new tblFornecedorBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridFornecedor.DataSource = bllFornecedor.ListarClientes();
            this.GridFornecedor.DataBind();
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {

            this.GridFornecedor.DataSource = bllFornecedor.PesquisarCliente(txtPesquisa.Text);
            this.GridFornecedor.DataBind();
            //Response.Redirect("FrmMain.aspx");
        }
    }
}