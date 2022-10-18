<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="FirstWebForm.Dashboard" %>
<asp:Content ContentPlaceHolderID="Pages" runat="server">
    <!DOCTYPE html>

<html>
<head>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View Hobbies" />
        <br />
        <br />
        Manually added items
        <br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
            <asp:ListItem Value="1001">Item 1</asp:ListItem>
            <asp:ListItem Value="1002">Item 2</asp:ListItem>
            <asp:ListItem Value="1003">item3</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Label ID="lblSelected" runat="server" Text="selected item"></asp:Label>
        <br />
        <br />
        Databound Items from session<br />
        <asp:ListBox ID="ListBox2" runat="server" Width="92px"></asp:ListBox>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="View Cookie" />
            <asp:GridView ID="GridView1" runat="server" BackColor="#00FF99" Width="286px" DataSourceID="SqlDataSource1">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="View Data" />
        </p>
    </form>
</body>
</html>
    </asp:Content>
