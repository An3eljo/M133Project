<%@ Page Title="Details" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="M133Project.ProductDetails" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
    <h2><%= Product.Name %></h2>
    <label><%= Product.Description %></label>
    <br/>
    Verkäufer: <a href="/PublicUserInformation.aspx/?id=<%=Seller.Id %>"><h4><%= Seller.Username %></h4></a>
    <br/>
    
    Price: <label><%= Product.Price %></label>
    <br/>
    Quantity: <label><%= Product.Quantity %></label>
    <br/>
    <br/>
    <asp:Button runat="server" Text="Buy" OnClick="OnBuyClick"/>


</asp:Content>