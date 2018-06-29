<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="M133Project.Login" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <label>Login</label>
    Username: <asp:TextBox runat="server" ID="TextBoxUsername"/><br />
    Password: <asp:TextBox runat="server" ID="TextBoxPassword" /><br />
    <asp:Label runat="server" ID="LabelError" Text="Error! Password or username is incorrect" Visible="False"></asp:Label> <br/>

    <asp:Button runat="server" OnClick="Submit_OnClick" Text="Submit"/>

    <!-- Test Test-->
</asp:Content>
