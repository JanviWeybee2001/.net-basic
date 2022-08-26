<%@ Page Title="ASP.NET Course Details" Language="C#" MasterPageFile="~/CoursesMasterPage.Master" AutoEventWireup="true" CodeBehind="ASPNET.aspx.cs" Inherits="MasterPagesDemoApp.ASPNET" %>
<%@ MasterType VirtualPath="~/CoursesMasterPage.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style5 {
        width: 58px;
        height: 53px;
    }
</style>
</asp:Content>


<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <p id="cphSourseDetails">
        ASP. Net Course Details..
    </p>
    <p> &nbsp;</p>
    <p> Following are the Details of the ASP.Net&nbsp; </p>
<p> &nbsp;</p>
<p> 
    <img alt="Happy" class="auto-style5" src="Images/smily.jpg" /></p>
    <p> &nbsp;</p>
    <p> 
        <asp:Button ID="btnDemo" runat="server" OnClick="btnDemo_Click" Text="Demo" />
    </p>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="cphStartDate">
    12th February
</asp:Content>
