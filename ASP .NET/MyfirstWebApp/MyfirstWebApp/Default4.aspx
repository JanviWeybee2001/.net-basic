<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default4.aspx.cs" Inherits="MyfirstWebApp.Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table>
                <tr>
                    <td>
                        <asp:ListBox ID="LstLeft" runat="server" OnSelectedIndexChanged="LBleft_SelectedIndexChanged">
                            <asp:ListItem>one</asp:ListItem>
                            <asp:ListItem>Three</asp:ListItem>
                            <asp:ListItem>Five</asp:ListItem>
                            <asp:ListItem>Six</asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td>
                        <table>
                            <tr>
                                <td>
                                    <asp:Button ID="isMoveLtoR" runat="server" Text="&gt;&gt;" OnClick="isMoveLtoR_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="isMoveRtoL" runat="server" Text="&lt;&lt;" OnClick="isMoveRtoL_Click" />
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                        <asp:ListBox ID="LstRight" runat="server">
                            <asp:ListItem>Two</asp:ListItem>
                            <asp:ListItem>Four</asp:ListItem>
                        </asp:ListBox>
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
