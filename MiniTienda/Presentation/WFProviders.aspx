<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProviders.aspx.cs" Inherits="Presentation.WFProviders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:TextBox ID="TBId" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Ingrese el nit"></asp:Label>
    <asp:TextBox ID="TBNit" runat="server"></asp:TextBox><br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre"></asp:Label>
    <asp:TextBox ID="TBName" runat="server"></asp:TextBox><br />
    <br />
    <%--<asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
    <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" /><br />
    <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>--%><br />
</div>
<div>
    <%--<asp:GridView ID="GVProvider" runat="server" OnSelectedIndexChanged="GVProvider_SelectedIndexChanged" OnRowDataBound="GVProducts_RowDataBound">--%>
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
</div>
</asp:Content>
