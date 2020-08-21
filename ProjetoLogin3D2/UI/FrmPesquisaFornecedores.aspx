<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmPesquisaFornecedores.aspx.cs" Inherits="ProjetoLogin3D2.UI.FrmPesquisaFornecedores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>Pesquisar Clientes</title>
     <link href="../Content/bootstrap.css" rel="stylesheet" />
     <link href="../Content/signin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
           
           <h1 class="h3 mb-3 font-weight-normal">Listagem de Fornecedores</h1>
            <p>
                <asp:TextBox ID="txtPesquisa" runat="server" Width="370px"></asp:TextBox>
                <asp:Button ID="btnPesquisar"   class="btn btn-lg btn-primary" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click" />
                <asp:Button ID="btnRetornar"  class="btn btn-lg btn-primary"  runat="server" Text="Retornar"  />
            </p>

            <asp:GridView ID="GridFornecedor"  runat="server">
            </asp:GridView>
            </div>
        <div>
        </div>

    </form>
</body>
</html>
