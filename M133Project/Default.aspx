<%@ Page Title="hallooosfjapsjfpaj" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="M133Project._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <form id="form1" runat="server">
        <asp:ScriptManager ID="MainScriptManager" runat="server" />
        <asp:UpdatePanel ID="pnlHelloWorld" runat="server">
            <ContentTemplate>
                <asp:Label runat="server" ID="lblHelloWorld" Text="Click the button!" />
                <br /><br />
                <asp:Button runat="server" ID="btnHelloWorld" OnClick="btnHelloWorld_Click" Text="Update label!" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>

   <%-- <asp:TextBox runat="server" ID="Test"></asp:TextBox>
    <input type="button" onclick="ShowCurrentTime"/>
    <asp:TextBox runat="server" ID="textbox"></asp:TextBox>
    
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>
    <script type = "text/javascript">
        function ShowCurrentTime() {
            var page = '<%=ResolveUrl("~/AjaxService.cs")%>';
            $.ajax({
                type: "POST",
                url: page + "/GetCurrentTime",
                data: '{name: "' + "#<%=Test.Text%>" + '" }',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success:
                    function(data) {
                        alert(data);
                    },
                failure: function(response) {
                    alert(response.d);
                }
            });
        }

        function getter(parameter) {
            
        }
    </script>--%>
</asp:Content>
