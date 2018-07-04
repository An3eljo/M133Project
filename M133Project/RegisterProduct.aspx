<%@ Page Title="Register New Product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterProduct.aspx.cs" Inherits="M133Project.RegisterProduct" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <%-- todo: errorhandling --%>
    <label>New Product</label>
    Name: <asp:TextBox runat="server" ID="TextBoxProductName"/><br/>
    Price: <asp:TextBox runat="server" ID="TextBoxPrice"/><br/>
    Quantity <asp:TextBox runat="server" ID="TextBoxQuantity"/><br/>
    Description <asp:TextBox runat="server" ID="TextBoxDescription"/>

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