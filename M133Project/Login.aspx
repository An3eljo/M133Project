<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="M133Project.Login" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form>
        <label>Login</label>
        Nutzername: <asp:TextBox runat="server" ID="TextBoxUsername"/><br />
        Passwort: <asp:TextBox runat="server" ID="TextBoxEmail" /><br />

        <asp:Button runat="server" OnClick="Submit_OnClick" Text="Submit"/>
     </form>
</asp:Content>
