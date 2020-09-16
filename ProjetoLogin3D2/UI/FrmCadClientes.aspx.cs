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
    public partial class FrmCadClientes : System.Web.UI.Page
    {
        tblClienteBLL bllCliente = new tblClienteBLL();
        tblClienteDTO dtoCliente = new tblClienteDTO();

        protected void Page_Load(object sender, EventArgs e)
        {

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
                // Valor Padrao para tipo de usuario
                dtoCliente.Tp_usuario = 2;

                // Inserir na tabela de clientes
                bllCliente.InserirCliente(dtoCliente);
                msgerro.Visible = true;
                Response.Redirect("signin.aspx");


            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
    }
}