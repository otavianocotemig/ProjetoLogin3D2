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
    public partial class FrmManProdutos : System.Web.UI.Page
    {
        //Instanciar as classes de BLL e DTO
        tblProdutoBLL produtoBLL = new tblProdutoBLL();
        tblProdutoDTO produtoDTO = new tblProdutoDTO();
        tblFornecedorBLL fornecedorBLL = new tblFornecedorBLL();
        tblCategoriaBLL categoriaBLL = new tblCategoriaBLL();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["usuario"] == null)
            {
                Response.Redirect("signin.aspx");
            }



            if (IsPostBack == false)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    DataTable dt = produtoBLL.ConsultarProdutos(id);
                    if (dt.Rows.Count > 0)
                    {
                        txtId.Text = dt.Rows[0][0].ToString();
                        txtNomeProduto.Text = dt.Rows[0][1].ToString();
                        txtDescricao.Text = dt.Rows[0][2].ToString();
                        txtPreco.Text = dt.Rows[0][3].ToString();
                        txtQuantidade.Text = dt.Rows[0][4].ToString();
                        txtPeso.Text = dt.Rows[0][5].ToString();
                        drpCategoria.SelectedValue = dt.Rows[0][6].ToString();
                        drpFornecedor.SelectedValue = dt.Rows[0][7].ToString();
                        ImgProduto.ImageUrl = "~//ImgProdutos//" + dt.Rows[0][8].ToString();

                    }
                    this.btnGravar.Text = "Alterar";

                }
                else
                {
                    this.btnGravar.Text = "Inserir";
                }


                this.PreencheCategoria();
                this.PreencheFornecedor();
            }

        }

        public void PreencheCategoria()
        {
            drpCategoria.DataSource = categoriaBLL.ListarCategoria();
            drpCategoria.DataTextField = "descricao";
            drpCategoria.DataValueField = "id";
            drpCategoria.DataBind();

        }

        public void PreencheFornecedor()
        {
            drpFornecedor.DataSource = fornecedorBLL.ListarFornecedor();
            drpFornecedor.DataTextField = "nome";
            drpFornecedor.DataValueField = "id";
            drpFornecedor.DataBind();

        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                // inserir os dados da UI no DTO
                produtoDTO.NomeProduto = txtNomeProduto.Text;
                produtoDTO.Descricao = txtDescricao.Text;
                produtoDTO.Preco = double.Parse(txtPreco.Text);
                produtoDTO.Quantidade = int.Parse(txtQuantidade.Text);
                produtoDTO.Peso = double.Parse(txtPeso.Text);
                produtoDTO.Tbl_categoria_id = int.Parse(drpCategoria.SelectedValue.ToString());
                produtoDTO.Tbl_fornecedor_id = int.Parse(drpFornecedor.SelectedValue.ToString());
                produtoDTO.Foto = FotoProduto.FileName.ToString();

                if (btnGravar.Text == "Alterar"){
                    produtoDTO.Id = int.Parse(txtId.Text);
                    produtoBLL.AlterarProduto(produtoDTO);

                }else
                {
                    // Inserir na tabela de clientes
                    produtoBLL.InserirProduto(produtoDTO);
                }
                // Fazer o Upload da imagem para o Servidor

               String localImagem = Server.MapPath("\\ImgProdutos\\" + FotoProduto.FileName);
               FotoProduto.SaveAs(localImagem);
             
                //
                Response.Redirect("/UI/FrmProdutos.aspx");
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmProdutos.aspx");
        }
    }
}