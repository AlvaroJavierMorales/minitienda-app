<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFUsers.aspx.cs" Inherits="Presentation.WFUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="LblId" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label1" runat="server" Text="Ingrese el correo"></asp:Label>
    <asp:TextBox ID="TBMail" runat="server" TextMode="Email"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Ingrese la contraseña"></asp:Label>
    <asp:TextBox ID="TBContrasena" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Estado"></asp:Label>
    <asp:DropDownList ID="DDLState" runat="server">
        <asp:ListItem Value="0">Seleccione</asp:ListItem>
        <asp:ListItem Value="Activo">Activo</asp:ListItem>
        <asp:ListItem Value="Inactivo">Inactivo</asp:ListItem>
    </asp:DropDownList>
    <br />
<%--    <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />--%>
    <br />
    <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
</div>
<div>
    <%--<asp:GridView ID="GVUsers" runat="server" CssClass="table" AutoGenerateColumns="False" OnSelectedIndexChanged="GVUsers_SelectedIndexChanged">--%>
        <columns>
            <asp:BoundField DataField="usu_id" HeaderText="Id" />
            <asp:BoundField DataField="usu_correo" HeaderText="Correo" />
            <asp:BoundField DataField="usu_contrasena" HeaderText="Contraseña" />
            <asp:BoundField DataField="usu_salt" HeaderText="Salt" />
            <asp:BoundField DataField="usu_estado" HeaderText="Estado" />
            <asp:CommandField ShowSelectButton="True" />
        </columns>
    </asp:GridView>
</div>
</asp:Content>
