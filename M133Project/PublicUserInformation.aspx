<%@ Page Language="C#" Title="User Information" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PublicUserInformation.aspx.cs" Inherits="M133Project.PublicUserInformation" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="BodyContent">
    
    <h2><%= CurrentUser.Username %></h2>
    <br/>
    <br/>
    <br/>
    <table>
       <tr><th>Name</th><th>Price</th><th>Quantity</th></tr>
        <%
            for (int i = 0; i < ProductsFromUser.Count; i++)
            {
                %>
                    <tr><td><a href="/ProductDetails.aspx/?id=<%=ProductsFromUser[i].Id %>"><%= ProductsFromUser[i].Name %></a></td><td><%= ProductsFromUser[i].Price %></td> <td><%= ProductsFromUser[i].Quantity %></td></tr>
                <% 
            }
        %>
    </table>

</asp:Content>
