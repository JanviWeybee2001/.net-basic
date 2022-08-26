<%@ Page Title="C Sharp Course Details" ClientIDMode="Predictable" Language="C#" MasterPageFile="~/CoursesMasterPage.Master" AutoEventWireup="true" CodeBehind="Csharp.aspx.cs" Inherits="MasterPagesDemoApp.Csharp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function Sayhello() {
            var name = document.getElementById("txtDemo").value;
            // Also we can written 'document.getElementById("<%=txtDemo.ClientID%>").value' for different ClientIDMode
            // Also,.. name = document.forms[0].<%=txtDemo.UniqueID%>.value
            alert("Hello.. " + name);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <p id="cphSourseDetails">
        C# Course Details..</p>
    <p> &nbsp;</p>
    <p>Following are the Details of the C# </p>
<p>&nbsp;</p>
<p>
    <asp:TextBox ID="txtDemo" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnDemo" runat="server" OnClick="btnDemo_Click" Text="Demo" OnClientClick="Sayhello();" />
</p>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="cphStartDate">
    1st February
</asp:Content>

