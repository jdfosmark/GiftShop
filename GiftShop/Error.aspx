<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="GiftShop.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gift Shop: Error!</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink ID="HeaderLink" ImageUrl="~/Images/banner1.png" NavigateUrl="~/" ToolTip="Gift Shop Logo" Text="Gift Shop Logo" runat="server" />
        <p>Your request generated an internal error!</p>
        <p>We apologize for the inconvenience. The error has been reported and will be fixed as soon as possible. Thank you!</p>
        <p>The <b>GiftShop</b> team</p>
    </form>
</body>
</html>
