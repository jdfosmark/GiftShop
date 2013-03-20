<%@ Page Title="Gift Shop: Product Details" Language="C#" MasterPageFile="~/GiftShop.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="GiftShop.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <p>
        <asp:Label CssClass="CatalogTitle" ID="titleLabel" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Image ID="productImage" runat="server" />
    </p>
    <p>
        <asp:Label ID="descriptionLabel" runat="server"></asp:Label>
    </p>
    <p>
        <b>Price:</b>
        <asp:Label CssClass="ProductPrice" ID="priceLabel" runat="server"></asp:Label>
    </p>
</asp:Content>
