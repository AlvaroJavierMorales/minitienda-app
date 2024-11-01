<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Presentation.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
               <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
   <asp:TextBox ID="TBUsuario" runat="server"></asp:TextBox><br />

   <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
   <asp:TextBox ID="TBContrasena" runat="server" TextMode="Password"></asp:TextBox><br />

   <asp:Button ID="BtnIniciar" runat="server" Text="Iniciar" />
   <asp:Label ID="LblMensaje" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
