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
    public partial class FrmPesquisaClientes : System.Web.UI.Page
    {
        //Instanciar a classe para uso BLL e DTO
        tblClienteBLL bllCliente = new tblClienteBLL();
        tblClienteDTO dtoCliente = new tblClienteDTO();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridClientes.DataSource = bllCliente.ListarClientes();
            this.GridClientes.DataBind();
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMain.aspx");
        }
    }
}