<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Source.aspx.cs" Inherits="RedirectingToAnotherDemoPage.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtDemo" runat="server"></asp:TextBox>
            <br />
            <br />
            <a href="Target.aspx">Target.aspx</a>&nbsp;
            <br />
            <br />
            <asp:Button ID="btnRedirect" runat="server" Text="Response.Redirect" OnClick="btnRedirect_Click" />
            <br />
            <br />
            <asp:Button ID="btnTrasfer" runat="server" Text="Serever.Transfer" OnClick="btnTrasfer_Click" />
            <br />
            <br />
            <asp:Button ID="btnCrossPagePostback" runat="server" OnClick="btnCrossPagePostback_Click" PostBackUrl="~/Target.aspx" Text="Cross-page Posting" />
        </div>
    </form>
</body>
</html>
