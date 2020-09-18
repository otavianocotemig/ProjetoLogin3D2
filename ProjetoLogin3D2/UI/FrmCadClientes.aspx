<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCadClientes.aspx.cs" Inherits="ProjetoLogin3D2.UI.FrmCadClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Manutenção de Clientes</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/signin.css" rel="stylesheet" />
</head>
<body class="align-content-center">
    <form id="form1" runat="server">
            <div class="jumbotron">
           
           <h1 class="h3 mb-3 font-weight-normal">Novo Cliente</h1>

             <asp:Label ID="msgerro" runat="server" ForeColor="Red" Text="." Visible="false"></asp:Label>
              <br />
             <asp:Label ID="lblNome" runat="server" Text="Nome "></asp:Label>
             <asp:TextBox ID="txtNome" type="text" required="true" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblSobrenome" runat="server" Text="SobreNome "></asp:Label>
             <asp:TextBox ID="txtSobrenome" type="text" required="true" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="Label2" runat="server" Text="CPF "></asp:Label>
             <asp:TextBox ID="txtCpf" type="text" required="true" placeholder="Informe somente números." runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="Label3" runat="server" Text="Email "></asp:Label>
             <asp:TextBox ID="txtEmail" type="text" runat="server" CssClass="form-control" required="true"  ></asp:TextBox>

             <asp:Label ID="Label1" runat="server" Text="Senha"></asp:Label>
             <asp:TextBox ID="txtSenhaAtual" type="password" required="true" runat="server" CssClass="form-control" ></asp:TextBox>

                     
            <asp:Button ID="btnInserir" class="btn btn-lg btn-primary" runat="server" Text="Gravar" OnClick="btnInserir_Click"   />
       
              
      
        </div>
  
    </form>
</body>
</html>
