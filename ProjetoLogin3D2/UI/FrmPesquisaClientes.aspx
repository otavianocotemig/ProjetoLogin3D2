<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmPesquisaClientes.aspx.cs" Inherits="ProjetoLogin3D2.UI.FrmPesquisaClientes" %>

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
           
           <h1 class="h3 mb-3 font-weight-normal">Listagem de Clientes</h1>

            <asp:GridView ID="GridClientes" runat="server">
            </asp:GridView>
            </div>
        <div>
                      <asp:Button ID="btnRetornar" class="btn btn-lg btn-primary btn-block" runat="server" Text="Retornar" OnClick="btnRetornar_Click" />
        </div>

    </form>
</body>
</html>
