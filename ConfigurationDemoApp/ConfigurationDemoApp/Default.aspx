<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConfigurationDemoApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .aspNetDisabled{
            color: gray;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            K1: <%= System.Configuration.ConfigurationManager.AppSettings["k1"] %>
            <br />
            K2: <%= System.Configuration.ConfigurationManager.AppSettings["k2"] %>
            <br />
            <%--K3: <%= System.Configuration.ConfigurationManager.AppSettings["k3"] %>--%>            <%--it is not give the Eroor but it gives the warning..--%>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
&nbsp;<br />
            <asp:Label ID="Label1" runat="server" Enabled="False" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnException" runat="server" OnClick="btnException_Click" Text="Throw Exception" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:TextBox ID="txtDemo" runat="server"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            &nbsp;
            <br />
            <br />
            <asp:Literal ID="ltrDemo" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
