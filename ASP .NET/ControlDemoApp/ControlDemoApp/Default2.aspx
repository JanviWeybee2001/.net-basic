<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="ControlDemoApp.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            
            <asp:DropDownList ID="ddlDemo" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lst_SelectedIndexChanged" >
                <asp:ListItem Text="Item1" Value="1"/>
                <asp:ListItem Text="Item2" Value="2" />
                <asp:ListItem Text="Item3" Value="3" />
            </asp:DropDownList>
            <br />
            
            <asp:listBox ID="lbDemo" runat="server" Rows="7" SelectionMode="Multiple" AutoPostBack="true" OnSelectedIndexChanged="lst_SelectedIndexChanged" >
                <asp:ListItem Text="Item1" Value="1"/>
                <asp:ListItem Text="Item2" Value="2" />
                <asp:ListItem Text="Item3" Value="3" />
            </asp:listBox>
            <br />

            <asp:CheckBoxList ID="cblDemo" runat="server" Rows="7" AutoPostBack="true" RepeatDirection="Horizontal" RepeatColumns="9"
                OnSelectedIndexChanged="lst_SelectedIndexChanged" >
                <asp:ListItem Text="Item1" Value="1" />
                <asp:ListItem Text="Item2" Value="2" />
                <asp:ListItem Text="Item3" Value="3" />
            </asp:CheckBoxList>
            <br />
            
            <asp:RadioButtonList ID="rdlDemo" runat="server" Rows="7" AutoPostBack="true" RepeatDirection="Vertical" RepeatLayout="OrderedList"
                OnSelectedIndexChanged="lst_SelectedIndexChanged" >
                <asp:ListItem Text="Item1" Value="1" />
                <asp:ListItem Text="Item2" Value="2" />
                <asp:ListItem Text="Item3" Value="3" />
            </asp:RadioButtonList>
            <br />
        </div>
    </form>
</body>
</html>


<%--OnSelectedIndexChanged="lst_SelectedIndexChanged"       OnSelectedIndexChanged="lst_SelectedIndexChanged"--%>