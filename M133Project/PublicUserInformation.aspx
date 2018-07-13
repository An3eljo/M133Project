<%@ Page Language="C#" Title="User Information" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PublicUserInformation.aspx.cs" Inherits="M133Project.PublicUserInformation" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="BodyContent">
    
    <h2><%= CurrentUser.Username %></h2>
    <br/>
    <br/>
    <table>
       <tr><th>Name</th><th>&nbsp;&nbsp;&nbsp;</th><th>Price</th><th>&nbsp;&nbsp;&nbsp;</th><th>Quantity</th></tr>
        <%
            foreach (var product in ProductsFromUser)
            {
                %>
                    <tr><td><a href="/ProductDetails.aspx/?id=<%=product.Id %>"><%= product.Name %></a></td><td>&nbsp;&nbsp;&nbsp;</td><td><%= product.Price %></td><td>&nbsp;&nbsp;&nbsp;</td><td><%= product.Quantity %></td></tr>
                <% 
            }
        %>
    </table>

</asp:Content>
