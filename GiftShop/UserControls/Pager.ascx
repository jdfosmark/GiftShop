<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Pager.ascx.cs" Inherits="GiftShop.UserControls.Pager" %>

<p>
    Page
    <asp:Label ID="currentPageLabel" runat="server" />
    of
    <asp:Label ID="howManyPagesLabel" runat="server" />
    |

    <asp:HyperLink ID="previousLink" runat="server">Previous</asp:HyperLink>

    <asp:Repeater ID="pagesRepeater" runat="server">
        <ItemTemplate>
            <asp:HyperLink ID="hyperlink" runat="server" Text='<%# Eval("Page") %>' NavigateUrl='<%# Eval("Url") %>' />
        </ItemTemplate>
    </asp:Repeater>

    <asp:HyperLink ID="nextLink" runat="server">Next</asp:HyperLink>
</p>