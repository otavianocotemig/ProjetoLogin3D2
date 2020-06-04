<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="ProjetoLogin3D2.signIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sign In</title>
    <link href="../Content/bootstrap.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <asp:Label ID="lblEmail" runat="server" Text="Email "></asp:Label>
            
            <asp:TextBox ID="txtEmail" type="email" runat="server" CssClass="form-control" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="ValidacaoEmail"
             ControlToValidate="txtEmail"
             ErrorMessage="O Campo é obrigatório. Informe um email"
             ForeColor="Red"
             runat="server" />

            <br />
            <asp:Label ID="lblSenha" runat="server" Text="Senha "></asp:Label>
            <asp:TextBox ID="txtSenha" type="password" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Button ID="btnSignin" class="btn btn-lg btn-primary btn-block" runat="server" Text="Login" />
            <p>
                
                <asp:LinkButton ID="btnCadastrar" runat="server">Não sou cadastrado. Clique aqui.</asp:LinkButton>
                
            </p>

            <asp:Label ID="lblNomeEmpresa" runat="server" Text="NomeEmpresa"></asp:Label>
        </div>
       
        
    </form>
</body>
</html>
