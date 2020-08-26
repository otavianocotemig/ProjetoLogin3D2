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
            // Verificar se o usuario está logado
            if (Session["usuario"] != null)
            {
                // Verifica administrador
                if (Session["tipoUsuario"].ToString() == "2")
                {
                    Response.Redirect("FrmMain.aspx");
                }
              
            }
            else
            {
                Response.Redirect("signin.aspx");
            }
            
        }

        protected void btnRetornar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("FrmMain.aspx");
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            string condicao = "nome_cliente like  '%" + txtPesquisa.Text + "%'" +
                              "or sobrenome_cliente like '%" + txtPesquisa.Text + "%'" +
                              "or email_cliente like '%" + txtPesquisa.Text + "%'";



            GridClientes.DataSource = bllCliente.PesquisarClientes(condicao);
            GridClientes.DataBind();
        }
    }
}