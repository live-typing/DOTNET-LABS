<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="UsingValidator.aspx.cs" Inherits="WithScriptTemplate.UsingValidator" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <hr />
    <center>
        <h1> Using All Validators</h1>
    </center>
    <hr />
    <asp:Label ID="Label1" runat="server" Text="Using Required:"></asp:Label>
&nbsp;<asp:TextBox ID="txt1" runat="server" Height="21px" Width="153px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt1" ErrorMessage="This field is mandatory" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="UsingCompare"></asp:Label>
    :
    <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
&nbsp;vs
    <asp:TextBox ID="txt3" runat="server"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt3" ControlToValidate="txt2" ErrorMessage="The values do not match" Operator="GreaterThan" Type="Integer" ForeColor="Red"></asp:CompareValidator>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="UsingRange"></asp:Label>
    :
    <asp:TextBox ID="txt5" runat="server"></asp:TextBox>
    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txt4" ErrorMessage="Please enter a valid range" SetFocusOnError="True" ForeColor="Red"></asp:RangeValidator>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="UsingRegularExpression"></asp:Label>
    :
    <asp:TextBox ID="txt4" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt5" ErrorMessage="invalid email address format" SetFocusOnError="True" ForeColor="Red"></asp:RegularExpressionValidator>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" />
</asp:Content>