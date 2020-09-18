﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMain.aspx.cs" Inherits="ProjetoLogin3D2.UI.FrmMain" %>

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
        <div>
             <img class="mb-4" src="../IMG/logocotemig.png" alt="" width="120" height="72">
              <h1 class="h3 mb-3 font-weight-normal">Loja Virtual</h1>
              <asp:Label ID="emailUsuario" runat="server" ForeColor="black" Text="." Visible="true"></asp:Label>
            <br />

            <div class="justify-content-end">
                
                <p> <asp:Button ID="btnMeuPerfil" class="btn btn-link" runat="server" Text="Meu Perfil" OnClick="btnMeuPerfil_Click" /></p>
                <p><asp:Button ID="btnAdministracao" class="btn btn-link" runat="server" Text="Consulta Clientes" OnClick="btnAdministracao_Click" /></p>
                <p><asp:Button ID="Button1" class="btn btn-link" runat="server" Text="Consulta Fornecedor" OnClick="Button1_Click"  /></p>
                <p><asp:Button ID="btnClientes" class="btn btn-link" runat="server" Text="Clientes" OnClick="btnClientes_Click" /></p>
                <p><asp:Button ID="BtnProdutos" class="btn btn-link" runat="server" Text="Produtos" OnClick="BtnProdutos_Click" /></p>
                <p><asp:Button ID="BtnSair" class="btn btn-link" runat="server" Text="Sair" OnClick="BtnSair_Click" /></p>

           </div>
        </div>
    </form>
</body>
</html>
