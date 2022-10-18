<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="UsingCache.aspx.cs" Inherits="withScriptsTemplate.UsingCache" %>
<%@ OutputCache Duration="15" VaryByParam="ListBox1"%>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <h1>CHECK THE TIME FOR CHANGES</h1>
    <p>&nbsp;</p>
    <h4> <%= DateTime.Now.ToLongTimeString() %>Check the listbox for changes</h4>
    <h4> &nbsp;</h4>
    <h4> 
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
    </h4>
    <h4> 
        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
    </h4>
    <p> &nbsp;</p>
</asp:Content> 