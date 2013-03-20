<%@ Page Title="Gift Shop: Catalog" Language="C#" MasterPageFile="~/GiftShop.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="GiftShop.Catalog" %>
<%@ Register src="UserControls/ProductsList.ascx" tagname="ProductsList" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>
        <asp:Label ID="catalogTitleLabel" CssClass="CatalogTitle" runat="server" />
    </h1>
    <h2>
        <asp:Label ID="catalogDescriptionLabel" CssClass="CatalogDescription" runat="server" />
    </h2>
    <uc1:ProductsList ID="ProductsList1" runat="server" />
</asp:Content>
