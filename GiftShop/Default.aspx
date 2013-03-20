<%@ Page Title="Gift Shop" Language="C#" MasterPageFile="~/GiftShop.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GiftShop.Default" %>
<%@ Register src="UserControls/ProductsList.ascx" tagname="ProductsList" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>
        <span class="CatalogTitle">Welcome to Gift Shop!</span>
    </h1>
    <h2>
        <span class="CatalogDescription">
            This week we have a special price for these items: 
        </span>
    </h2>
    <uc1:ProductsList ID="ProductsList1" runat="server" />
</asp:Content>
