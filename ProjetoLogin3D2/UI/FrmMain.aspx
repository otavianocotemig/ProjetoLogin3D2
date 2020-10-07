<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMain.aspx.cs" Inherits="ProjetoLogin3D2.UI.FrmMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Principal - Loja Virtual</title>
     <link href="../Content/bootstrap.css" rel="stylesheet" />
     <link href="../Content/signin.css" rel="stylesheet" />
</head>
<body>

    <form id="form1" runat="server">

 
          <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
            
              <a class="navbar-brand" href="FrmMain.aspx">Loja Virtual</a>
              <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
              </button>

              <div class="collapse navbar-collapse" id="navbarsExampleDefault">
                <ul class="navbar-nav mr-auto">
                  
                  <li class="nav-item">
                    <a class="nav-link" href="FrmMeuPerfil.aspx">Meu Perfil</a>
                  </li>
                  <li class="nav-item">
                    <a class="nav-link" href="FrmProdutos.aspx">Produtos</a>
                  </li>
                      <li class="nav-item">
                    <a class="nav-link" href="FrmClientes.aspx">Clientes</a>
                  </li>
                     <li>
                      <li class="nav-item">
                    <a class="nav-link" href="FrmPesquisaClientes.aspx">Consulta Clientes</a>
                  </li>
                     <li>
                      <li class="nav-item">
                    <a class="nav-link" href="FrmPesquisaFornecedores.aspx">Consulta Fornecedor</a>
                  </li>
                
                </ul>
              
                   <asp:Label ID="emailUsuario" runat="server" ForeColor="white" Text="." Visible="true"></asp:Label>
                  <br />
                  <asp:Button ID="BtnSair" class="btn btn-outline-success my-2 my-sm-0" runat="server" Text="Sair" OnClick="BtnSair_Click" />
              
              </div>
            </nav>


          <div>
              <p>
               <asp:TextBox ID="txtPesquisa" type="text" runat="server" ></asp:TextBox>
               <asp:Button ID="btnPesquisa" class="btn btn-outline-success my-2 my-sm-0" runat="server" Text="Pesquisar" OnClick="btnPesquisa_Click"  />
           </p>
           </div>
        <br />
           <asp:GridView ID="GridProdutos" CssClass="table table-light" runat="server">
                <Columns>
                    
                 
                    <asp:TemplateField>
                         <ItemTemplate>
                            <asp:ImageButton ID="ImgBtn1" runat="server" ImageUrl='<%# "~//ImgProdutos//"+Eval("Foto")%>' Width="110px" Height="100px" Style="cursor: pointer" 
           OnClientClick = "return LoadDiv(this.src);"/>
                    </ItemTemplate>
                    </asp:TemplateField>
                 
                </Columns>
               
            </asp:GridView>
    </form>
</body>
</html>
