<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="M133Project.Register" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <label>Register</label>
    Username: <asp:TextBox runat="server" ID="TextBoxUsername"/><br />
    Password: <asp:TextBox runat="server" ID="TextBoxPassword" /><br />
    WalletAddress: <br/>
    <asp:TextBox runat="server" TextMode="MultiLine" Rows="1" Columns="80" ID="TextBoxWalletAddress"/>
    <asp:Label runat="server" ID="LabeErrorEmptyFields" Text="Error! Username or Password not set" Visible="False"></asp:Label> <br/>
    <asp:Label runat="server" ID="LabelErrorUserExists" Text="Error! User exists already" Visible="False"></asp:Label> <br/>

    <asp:Button runat="server" OnClick="OnClick" Text="Submit"/>

    <%--<table>
        <% 
            foreach (var text in Text)
            {
                %>
                    <tr><td><%= text %></td></tr>
                <% 
            }
        %>
    </table>--%>
    
<!-- Test Test-->
</asp:Content>
