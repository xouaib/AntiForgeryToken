<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UseAntiForgeryTokenForCSRFWebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row" style="padding:20px">
        <div class="form-group">
            <asp:Label Text="Username" runat="server" />
            <asp:TextBox runat="server" CssClass="form-control" ID="UsernameTextBox"/>
            <asp:RequiredFieldValidator ID="UsernameReauiredValidator" runat="server" ErrorMessage="Username is required." Display="Dynamic" ControlToValidate="UsernameTextBox" ForeColor="Red"/>
        </div>
        <div class="form-group">
            <asp:Label Text="Password" runat="server" />
            <asp:TextBox runat="server" CssClass="form-control" TextMode="Password" ID="UserPasswordTextBox" />
            <asp:RequiredFieldValidator ID="UserPasswordRequiredValidator" runat="server" ErrorMessage="Password is required." Display="Dynamic" ControlToValidate="UserPasswordTextBox" ForeColor="Red"/>
        </div>
        <div class="form-group">
            <asp:Button ID="AuthenticateButton" runat="server" Text="Sign In" CssClass="btn btn-primary" OnClick="AuthenticateButton_Click"/>
        </div>
    </div>
</asp:Content>
