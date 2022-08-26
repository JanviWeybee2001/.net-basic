<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoTry.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="FN" runat="server" Text="FirstName :-"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFN" runat="server" BorderStyle="Solid" ToolTip="frist name" Width="20%"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LN" runat="server" Text="LastName :-"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtLN" runat="server" BorderStyle="Solid" ToolTip="last name" Width="20%"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Gender" runat="server" Text="Gender :-"></asp:Label>
            <asp:RadioButtonList ID="genderList" runat="server" CellPadding="3" CellSpacing="1" >
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="Hobby" runat="server" Text="Hobby :-" ToolTip="Hobby"></asp:Label>
            <asp:CheckBoxList ID="HobbyList" runat="server">
                <asp:ListItem>Playing</asp:ListItem>
                <asp:ListItem>Reading</asp:ListItem>
                <asp:ListItem>Writing</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Label ID="Study" runat="server" Text="Study :-" ToolTip="Study"></asp:Label>
<br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="StudyList" runat="server">
                <asp:ListItem>SSC</asp:ListItem>
                <asp:ListItem>HSC</asp:ListItem>
                <asp:ListItem>Graduate</asp:ListItem>
                <asp:ListItem>Post Graduate</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Bdate" runat="server" Text="Birthdate :-" ToolTip="Birthdate"></asp:Label>
            <br />
            
            <%--<asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" SelectedDate="08/17/2022 12:46:23" VisibleDate="2022-08-17" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>--%>

            <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" Width="350px">
                <DayHeaderStyle BorderColor="#FF9966" BorderStyle="None" Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>

            <br />
            <br />
            <asp:Button ID="submit" runat="server" OnClientClick="return confirm(&quot;Are you Sure?&quot;)" Text="Submit" ToolTip="submit the form" Width="61px" OnClick="Display_Data" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />

            <div>
                Information :--------- <br />
            <br />
                <asp:Label ID="fullName" runat="server" Text="Full Name :- "></asp:Label>
            &nbsp;<asp:Label ID="fullNameDisplay" runat="server" ForeColor="#FF0066" Text=" "></asp:Label>
                <br />
                <br />
            <asp:Label ID="Gender0" runat="server" Text="Gender :-"></asp:Label>
&nbsp;
                <asp:Label ID="GenderDisplay" runat="server" ForeColor="#FF0066" Text=" "></asp:Label>
            <br />
                <br />
            <asp:Label ID="Hobby0" runat="server" Text="Hobby :-" ToolTip="Hobby"></asp:Label>
&nbsp;
                <asp:Label ID="HobbyDisplay" runat="server" Text=" " ToolTip="Hobby" ForeColor="#FF0066"></asp:Label>
                <br />
                <br />
            <asp:Label ID="Study0" runat="server" Text="Study :-" ToolTip="Study"></asp:Label>
&nbsp;
                <asp:Label ID="StudyDisplay" runat="server" ForeColor="#FF0066" Text="  " ToolTip="Study"></asp:Label>
                <br />
                <br />
            <asp:Label ID="Bdate0" runat="server" Text="Birthdate :-" ToolTip="Birthdate"></asp:Label>
&nbsp;&nbsp;
                <asp:Label ID="BDateDisplay" runat="server" ForeColor="#FF0066" Text=" " ToolTip="BirthDate"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
