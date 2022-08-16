<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlDemoApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

      <%--      <asp:Literal ID="Literal1" runat="server" Mode="Encode" Text="a&lt;b"></asp:Literal>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="a&lt;b"></asp:Label>
&nbsp;<br />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Single Line"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Multi Line"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 0px" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Passcode"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>

       <br />
--%>

            <br />
            <asp:Panel ID="Panel1" runat="server" DefaultButton="btnDelete">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="btnDeletee" runat="server" Text="button1" OnClientClick="return confirm(&quot;Are you sure?&quot;)" OnClick="btnDelete_Click" />
            </asp:Panel>

            <asp:Panel ID="Panel2" runat="server" DefaultButton="button2">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="button2" runat="server" Text="button2" OnClientClick="alert('button2')" OnClick="btnDelete_Click" />
            </asp:Panel>
            
            <br />
            <br />
            <br />

            <asp:Button ID="btnAdd" runat="server" Text="Add" OnCommand="btnAdd_Command" CommandName ="Add" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnCommand="btnAdd_Command" CommandName ="Edit" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnCommand="btnAdd_Command" CommandName ="Delete" />


            &nbsp;


            <asp:ImageButton ID="ImageButton1" runat="server" Height="33px" ImageUrl="~/Images/smily.jpg" Width="35px" OnClientClick="return confirm(&quot;Are you sure?&quot;)" />

            <br />
            <br />

            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default2.aspx" Text="Default2"></asp:HyperLink>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:LinkButton ID="lbtn" runat="server" OnClick="lbtn_Click" OnClientClick="return confirm(&quot;Are you sure?&quot;)">LinkButton</asp:LinkButton>

            <br />
            
           





        </div>
    </form>
</body>
</html>
