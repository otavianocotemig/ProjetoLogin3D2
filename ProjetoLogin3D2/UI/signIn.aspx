<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="ProjetoLogin3D2.signIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sign In</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblEmail" runat="server" Text="Email "></asp:Label>
            <asp:TextBox ID="txtEmail" type="email" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSenha" runat="server" Text="Senha "></asp:Label>
            <asp:TextBox ID="txtSenha" type="password" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSignin" runat="server" Text="Login" />
            <p>
                
            </p>
            <asp:Label ID="lblNomeEmpresa" runat="server" Text="NomeEmpresa"></asp:Label>
        </div>
       
        
    </form>
</body>
</html>
