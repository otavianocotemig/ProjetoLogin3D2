<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmClientes.aspx.cs" Inherits="ProjetoLogin3D2.UI.FrmClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Manutenção de Clientes</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/signin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
            <div class="jumbotron">
           
           <h1 class="h3 mb-3 font-weight-normal">Clientes</h1>

            <br />
            <asp:Label ID="msgerro" runat="server" ForeColor="Red" Text="." Visible="false"></asp:Label>
                <br />
             <asp:Label ID="lblNome" runat="server" Text="Nome "></asp:Label>
             <asp:TextBox ID="txtNome" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblSobrenome" runat="server" Text="SobreNome "></asp:Label>
             <asp:TextBox ID="txtSobrenome" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="Label2" runat="server" Text="CPF "></asp:Label>
             <asp:TextBox ID="txtCpf" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="Label3" runat="server" Text="Email "></asp:Label>
             <asp:TextBox ID="txtEmail" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="Label1" runat="server" Text="Senha"></asp:Label>
             <asp:TextBox ID="txtSenhaAtual" type="password" runat="server" CssClass="form-control" ></asp:TextBox>

              <asp:Label ID="Label4" runat="server" Text="Tipo do Usuário"></asp:Label>
              <asp:DropDownList ID="drpTipoUsuario" runat="server" CssClass="form-control"></asp:DropDownList>
  
           
            <asp:Button ID="btnInserir" class="btn btn-lg btn-primary" runat="server" Text="Gravar" OnClick="btnInserir_Click"  />
            <asp:Button ID="btnRetornar" class="btn btn-lg btn-primary" runat="server" Text="Retornar" OnClick="btnRetornar_Click"  />
       <br />
                <asp:GridView ID="GridClientes"  CssClass="table table-striped" runat="server" OnRowDeleting="GridClientes_RowDeleting" OnRowCancelingEdit="GridClientes_RowCancelingEdit" OnRowEditing="GridClientes_RowEditing" OnRowUpdating="GridClientes_RowUpdating">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
                        <asp:CommandField ButtonType="Button" ShowEditButton="True" UpdateText="Gravar" />
                    </Columns>
                </asp:GridView>
      
        </div>
  
    </form>
</body>
</html>
