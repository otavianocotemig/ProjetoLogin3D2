<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmClientes.aspx.cs" Inherits="ProjetoLogin3D2.UI.FrmClientes" %>

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
           
           <h1 class="h3 mb-3 font-weight-normal">Clientes</h1>

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

             <asp:Label ID="Label5" runat="server" Text="CEP "></asp:Label>
             <asp:Button ID="btnConsultaCEP" class="btn btn-small btn-primary" runat="server" Text="Consultar CEP" OnClick="btnConsultaCEP_Click" Width="199px"   />
             <asp:TextBox ID="txtCep" type="text" runat="server" CssClass="form-control"></asp:TextBox>

             <asp:Label ID="Label6" runat="server" Text="Endereço "></asp:Label>
             <asp:TextBox ID="txtEndereco" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="Label7" runat="server" Text="Bairro "></asp:Label>
             <asp:TextBox ID="txtBairro" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="Label8" runat="server" Text="Cidade "></asp:Label>
             <asp:TextBox ID="txtCidade" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

              <asp:Label ID="Label4" runat="server" Text="Tipo do Usuário"></asp:Label>
              <asp:DropDownList ID="drpTipoUsuario" runat="server" CssClass="form-control"></asp:DropDownList>
  
           
            <asp:Button ID="btnInserir" class="btn btn-lg btn-primary" runat="server" Text="Gravar" OnClick="btnInserir_Click"  />
            <asp:Button ID="btnRetornar" class="btn btn-lg btn-primary" runat="server" Text="Retornar" OnClick="btnRetornar_Click"  />
       <br />
                <asp:GridView ID="GridClientes"  CssClass="table-responsive-sm" runat="server" OnRowDeleting="GridClientes_RowDeleting" OnRowCancelingEdit="GridClientes_RowCancelingEdit" OnRowEditing="GridClientes_RowEditing" OnRowUpdating="GridClientes_RowUpdating" AllowPaging="True" OnPageIndexChanging="GridClientes_PageIndexChanging" PageSize="5">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
                        <asp:CommandField ButtonType="Button" ShowEditButton="True" UpdateText="Gravar" />
                    </Columns>
                    <PagerSettings Position="TopAndBottom" />
                </asp:GridView>
      
        </div>
  
    </form>
</body>
</html>
