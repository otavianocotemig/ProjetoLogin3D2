<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMeuPerfil.aspx.cs" Inherits="ProjetoLogin3D2.UI.FrmMeuPerfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Meu Perfil</title>
      <link href="../Content/bootstrap.css" rel="stylesheet" />
     <link href="../Content/signin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       <div class="jumbotron">
            <h1 class="h3 mb-3 font-weight-normal">Meu Perfil</h1>

             <asp:Label ID="lblNome" runat="server" Text="Nome "></asp:Label>
             <asp:TextBox ID="txtNome" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblSobrenome" runat="server" Text="SobreNome "></asp:Label>
             <asp:TextBox ID="txtSobrenome" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblSenha" runat="server" Text="Nova Senha"></asp:Label>
             <asp:TextBox ID="txtNovaSenha" type="password" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblRsenha" runat="server" Text="Repita Nova Senha"></asp:Label>
             <asp:TextBox ID="txtRNovaSenha" type="password" runat="server" CssClass="form-control" ></asp:TextBox>

            <asp:Button ID="btnGravar" class="btn btn-lg btn-primary btn-block" runat="server" Text="Gravar" />
            <asp:Button ID="btnRetornar" class="btn btn-lg btn-primary btn-block" runat="server" Text="Retornar" OnClick="btnRetornar_Click"  />
       <br />
        </div>
    </form>
</body>
</html>
