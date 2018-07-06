<%@ Page Title="Shopping Cart" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="M133Project.ShoppingCart" %>
<%@ Import Namespace="M133Project" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
    <h2>Shopping Cart</h2>
    <br/>
    <br/>
    <table>
       <tr><th>Name</th><th>Price</th><th>Seller</th></tr>
        <%
            foreach (var product in ShoppingCardFromUser)
            {
                var user = new M133_GoInternationalEntities1().User.First(usr => usr.Id == product.Seller);
                %>
                    <tr><td><a href="/ProductDetails.aspx/?id=<%=product.Id %>"><%= product.Name%></a></td><td><%= product.Price %></td> <td><a href="/PublicUserInformation.aspx/id=<%= user.Id %>"><%= user.Username %></a></td></tr>
                <% 
            }
        %>
    </table>
    
    <asp:Button runat="server" Text="Back" OnClick="OnBackClick" ID="ButtonBack"/><label>       </label><asp:Button runat="server" OnClick="ButtonHome_OnClick" Text="Home"/>  
    <br/>
    <br/>
    <asp:Button runat="server" Text="Checkout" OnClick="ButtonCheckout_OnClick"/>
</asp:Content>