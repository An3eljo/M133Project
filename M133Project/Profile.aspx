<%@ Page Title="My Profile" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="M133Project.Profile" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
    Username: <asp:TextBox runat="server" ID="TextBoxUsername"/>
    Password: <asp:TextBox runat="server" ID="TextBoxPassword"/>
    Walletaddress: <asp:TextBox runat="server" ID="TextBoxWalletAddress"/>

</asp:Content>