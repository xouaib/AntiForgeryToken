<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="UseAntiForgeryTokenForCSRFWebForm.UserPage.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Welcom to your profile</h1>
    <asp:HiddenField ID="forgeryToken" runat="server" />
    <asp:Button ID="DoPostback" runat="server" Text="Do PostBack" CssClass="btn btn-primary" />

</asp:Content>
