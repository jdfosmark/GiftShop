<%@ Page Title="Gift Shop: Catalog" Language="C#" MasterPageFile="~/GiftShop.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="GiftShop.Catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>
        <asp:Label ID="catalogTitleLabel" CssClass="CatalogTitle" runat="server" />
    </h1>
    <h2>
        <asp:Label ID="catalogDescriptionLabel" CssClass="CatalogDescription" runat="server" />
    </h2>
    [List of Products Here]
</asp:Content>
