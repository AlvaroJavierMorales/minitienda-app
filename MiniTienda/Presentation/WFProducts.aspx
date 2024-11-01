<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProducts.aspx.cs" Inherits="Presentation.WFProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:TextBox ID="TBId" runat="server" Visible="false"></asp:TextBox>
    <asp:Label ID="Label1" runat="server" Text="Ingrese el codigo"></asp:Label>
    <asp:TextBox ID="TBCode" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Ingrese la descripcion"></asp:Label>
    <asp:TextBox ID="TBDescription" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label3" runat="server" Text="Ingrese la cantidad"></asp:Label>
    <asp:TextBox ID="TBQuantity" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label4" runat="server" Text="Ingrese el precio"></asp:Label>
    <asp:TextBox ID="TBPrice" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label5" runat="server" Text="Seleccione la categoria"></asp:Label>
    <asp:DropDownList ID="DDLCategories" runat="server"></asp:DropDownList><br />
    <asp:Label ID="Label6" runat="server" Text="Seleccione el provedor"></asp:Label>
    <asp:DropDownList ID="DDLProviders" runat="server"></asp:DropDownList><br />
    <%--<asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />--%>
    <%--<asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />--%><br />
    <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
</div>
<div>
    <%--<asp:GridView ID="GVProducts" runat="server" OnRowDataBound="GVProducts_RowDataBound"--%>
        <%--AutoGenerateColumns="False" OnSelectedIndexChanged="GVProducts_SelectedIndexChanged">--%>
        <Columns>
            <asp:BoundField DataField="pro_id" HeaderText="id" />
            <asp:BoundField DataField="pro_codigo" HeaderText="Codigo" />
            <asp:BoundField DataField="pro_descripcion" HeaderText="Nombre" />
            <asp:BoundField DataField="pro_cantidad" HeaderText="Cantidad" />
            <asp:BoundField DataField="pro_precio" HeaderText="Precio" />
            <asp:BoundField DataField="tbl_categorias_cat_id" HeaderText="fkCategoria" />
            <asp:BoundField DataField="cat_descripcion" HeaderText="Categoria" />
            <asp:BoundField DataField="tbl_proveedores_prov_id" HeaderText="fkProveedor" />
            <asp:BoundField DataField="prov_nombre" HeaderText="Proveedor" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
</div>
</asp:Content>
