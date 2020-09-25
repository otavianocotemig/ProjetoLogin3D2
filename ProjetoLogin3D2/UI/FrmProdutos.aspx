<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmProdutos.aspx.cs" Inherits="ProjetoLogin3D2.UI.FrmProdutos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Manutenção de Produtos</title>
     <link href="../Content/bootstrap.css" rel="stylesheet" />
     <link href="../Content/signin.css" rel="stylesheet" />
 
</head>
<body>
    <form id="form1" runat="server">
       <div >
           
           <h1 class="h3 mb-3 font-weight-normal">Manutenção de Produtos</h1>
           <div class="jumbotron">
            <p>
                <asp:TextBox ID="txtPesquisa" runat="server" Width="370px"></asp:TextBox>
                <asp:Button ID="btnPesquisar"   class="btn btn-lg btn-primary" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click" />
                <asp:Button ID="btnNovo"  class="btn btn-lg btn-primary"  runat="server" Text="Novo Produto" OnClick="btnNovo_Click"  />
                <asp:Button ID="btnRetornar"  class="btn btn-lg btn-primary"  runat="server" Text="Retornar" OnClick="btnRetornar_Click"  />
                </p>
               <p>
                   <asp:CheckBox ID="OrdenarNome" runat="server" Text="Ordenar pelo Nome"/>
            </p>
            <asp:GridView ID="GridProdutos" CssClass="table-responsive-sm" runat="server" AllowPaging="True" OnPageIndexChanging="GridProdutos_PageIndexChanging" OnRowDeleting="GridProdutos_RowDeleting" PageSize="15">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <a href='FrmManProdutos.aspx?id=<%# Eval("id") %>'> Alterar </a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                </Columns>
                <PagerSettings PageButtonCount="5" Position="TopAndBottom" />
            </asp:GridView>
            </div>
         <asp:Label ID="msgerro" runat="server" ForeColor="Red" Text="." Visible="false"></asp:Label>
              <br />
      
        </div>
    </form>
</body>
</html>
