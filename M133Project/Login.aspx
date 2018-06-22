<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="M133Project.Login" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form>
        <label>Login</label>
        Nutzername: <asp:TextBox runat="server" ID="TextBoxUsername"/><br />
        Passwort: <asp:TextBox runat="server" ID="TextBoxEmail" /><br />

        <asp:Button runat="server" OnClick="Submit_OnClick" Text="Submit"/>
        
     </form>
    [WebMethod]
    public static string doSomething(int id)
        {
            $.ajax({
            type: "POST",
            url: "YourPage.aspx/doSomething",
            data: "{'id':'1'}",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                var returnedstring = data.d;
                var jsondata = $.parseJSON(data.d);//if you want your data in json
            }
        });
        }
    
</asp:Content>
