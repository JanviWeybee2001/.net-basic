<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demoTheme.aspx.cs" Inherits="Demo.demoTheme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="App_Themes/Theme1/StyleSheet1.css" rel="stylesheet" />
    <style>
        u {
            color:blueviolet;
            background-color:burlywood;
            line-height:35px;
        }

        b, i {
            border:dotted 0.2px black;
            background-color: pink;
        }

        b i {
            border:double 1px red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b style="color:Red; background-color:aqua">This is bold</b> <br />
            <i style="word-spacing:5px; letter-spacing:4px">This is Italic</i>  <br />
            <u>This is underLined</u>  <br />
            <u>This is underLined</u>  <br />
            <u>This is underLined</u>  <br />
            <b> <i>This is bold </i> </b> <br />
            <i>This is bold </i> <br />
            <p>This is <b>Bold</b> under P tag</p>
        </div>
    </form>
</body>
</html>
