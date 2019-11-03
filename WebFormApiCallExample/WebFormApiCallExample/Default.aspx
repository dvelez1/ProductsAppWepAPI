<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormApiCallExample._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div>
        ESTO ES UN EJEMPLO ABAJO
    </div>
     <asp:TextBox ID="txtProdName" runat="server"></asp:TextBox>



<%--    Name:
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="Search" />
    <hr />
    <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField ItemStyle-Width="150px" DataField="Id" HeaderText="ProductID" />
            <asp:BoundField ItemStyle-Width="150px" DataField="Name" HeaderText="Product Name" />
        </Columns>
    </asp:GridView>--%>


</asp:Content>
