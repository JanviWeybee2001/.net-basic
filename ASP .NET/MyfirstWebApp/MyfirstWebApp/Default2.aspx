<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="MyfirstWebApp.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblDemo" runat="server" Text="This is Demo text" BackColor="#FFFF99" BorderWidth="5px" Font-Size="Large" Width="300px"></asp:Label>
            <br />
            <br />
            <asp:RadioButton ID="rbnRED" runat="server" GroupName="color" Text="Red" OnCheckedChanged="rbnColor_CheckedChanged" AutoPostBack="True" />
&nbsp;&nbsp;
            <asp:RadioButton ID="rbnGreen" runat="server" GroupName="color" Text="Green" OnCheckedChanged="rbnColor_CheckedChanged" AutoPostBack="True" />
&nbsp;&nbsp;
            <asp:RadioButton ID="rbnBlue" runat="server" GroupName="color" Text="Blue" OnCheckedChanged="rbnColor_CheckedChanged" AutoPostBack="True" />
            <br />
            <br />

            <asp:Button ID="Button1" runat="server" Text="Submit" />

        </div>
    </form>
</body>
</html>
