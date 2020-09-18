<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="ProjetoLogin3D2.signIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sign In</title>
     <link href="../Content/bootstrap.css" rel="stylesheet" />
     <link href="../Content/signin.css" rel="stylesheet" />
</head>
<body class="text-center">
    <form id="form1" class="form-signin"  runat="server">
        <div>
            <img class="mb-4" src="../IMG/logocotemig.png" alt="" width="120" height="72">
            <h1 class="h3 mb-3 font-weight-normal">Acesso ao Sistema</h1>
            <br />
            <asp:Label ID="msgerro" runat="server" ForeColor="Red" Text="." Visible="false"></asp:Label>

            <br />

            <asp:Label ID="lblEmail" runat="server" Text="Email "></asp:Label>
            
            <asp:TextBox ID="txtEmail" type="email" required="true" runat="server" CssClass="form-control" ></asp:TextBox>
            <br />
            <asp:Label ID="lblSenha" runat="server" Text="Senha "></asp:Label>
            <asp:TextBox ID="txtSenha" type="password" required="true" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Button ID="btnSignin" class="btn btn-lg btn-primary btn-block" runat="server" Text="Login" OnClick="btnSignin_Click" />
            <br />
            <asp:LinkButton ID="btnCadastrar" class="btn btn-link"  runat="server" OnClick="btnCadastrar_Click">Não sou Cadastrado. Clique aqui</asp:LinkButton>
            <asp:LinkButton ID="btnEsqueciSenha" class="btn btn-link"  runat="server" OnClick="btnEsqueciSenha_Click">Esqueci Minha Senha.</asp:LinkButton>
        </div>
      <p class="mt-5 mb-3 text-muted">
            <asp:Label  ID="lblNomeEmpresa"  runat="server" Text ="nomeEmpresa"></asp:Label>
          &copy; 2017-2018</p>
        
       
        
    </form>
</body>
</html>
