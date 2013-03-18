<%@ Page Title="Gift Shop" Language="C#" MasterPageFile="~/GiftShop.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GiftShop.Default" %>
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
    [List of Products Here]
</asp:Content>
