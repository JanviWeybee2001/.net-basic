<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyfirstWebApp.Default" %>

<!DOCTYPE html>
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
        //TextBox1.Text = "Demo";
    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" action="/" runat="server">
        <div>
            Enter the gritting people's name:-
            <br />
            <br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Button ID="Btn" runat="server" Text="Say hello" OnClick="Btn_Click" />
            <br />
            <br />
            <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
