﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieSender.aspx.cs" Inherits="StateMgtDemo.CookieSender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Custid:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Enter custname:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit Data" />
    </form>
</body>
</html>
