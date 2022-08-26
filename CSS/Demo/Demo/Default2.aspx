<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="Demo.WebForm1" Theme="Theme1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlTheme" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Theme1</asp:ListItem>
                <asp:ListItem>Theme2</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="This is a Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="This is a Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="This is a Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="This is a Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="This is a Label" SkinID="RedLabel"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="This is a Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="This is a Label"></asp:Label>

        &nbsp;
            <br />
            <br />
            <asp:Button runat="server" Text="Button" />

        </div>
    </form>
</body>
</html>
