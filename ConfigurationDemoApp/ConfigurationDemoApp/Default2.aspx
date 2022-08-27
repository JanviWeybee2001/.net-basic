<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="ConfigurationDemoApp.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            K1: <%= System.Configuration.ConfigurationManager.AppSettings["k1"] %>
            <br />
            K2: <%= System.Configuration.ConfigurationManager.AppSettings["k2"] %>
            <br />
        </div>
    </form>
</body>
</html>
