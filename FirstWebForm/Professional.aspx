<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Professional.aspx.cs" Inherits="FirstWebForm.Professional" %>

<asp:Content ContentPlaceHolderID="Pages" runat="server">

    <form id="form1" runat="server">

    <h2> This is a content page </h2>
    <hr />
    <br />
    <strong>Add new Employeee<br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Employee Name is mandatory" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
    <br />
    </strong>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Invalid Range" ForeColor="#33CC33" MaximumValue="999999999999" MinimumValue="100000" SetFocusOnError="True" style="font-weight: 700"></asp:RangeValidator>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Salary cannot be empty" ForeColor="Fuchsia" SetFocusOnError="True" style="font-weight: 700"></asp:RequiredFieldValidator>
    <br />
    <h3>Databinding with Database</h3>
    
</form>
    
</asp:Content>
