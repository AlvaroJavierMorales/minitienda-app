<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFCategories.aspx.cs" Inherits="Presentation.WFCategories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div>
       <asp:TextBox ID="TBId" runat="server" Visible="false"></asp:TextBox><br />
       <asp:Label ID="Label1" runat="server" Text="Ingrese la descripcion"></asp:Label>
       <asp:TextBox ID="TBDescription" runat="server"></asp:TextBox>
       <%--<asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />--%>
       <%--<asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />--%><br />
       <%--<asp:Label ID="LblMsj" runat="server" Text=""></asp:Label><br />--%>
   </div>
 <%--  <div>
       <asp:GridView ID="GVCategory" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVCategory_SelectedIndexChanged" OnRowDeleting="GVCategory_RowDeleting">
           <Columns>
               <asp:BoundField DataField="cat_id" HeaderText="Id" />
               <asp:BoundField DataField="cat_descripcion" HeaderText="Descripcion" />
               <asp:CommandField ShowSelectButton="True" />
               <asp:CommandField ShowDeleteButton="True" />
           </Columns>
       </asp:GridView>
   </div>--%>
</asp:Content>
