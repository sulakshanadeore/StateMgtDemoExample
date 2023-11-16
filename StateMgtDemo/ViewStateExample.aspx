<%@ Page Language="C#" AutoEventWireup="true" Trace="true" CodeBehind="ViewStateExample.aspx.cs" Inherits="StateMgtDemo.ViewStateExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Productid:
            <asp:TextBox ID="txtproductid" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Show Data" OnClick="Button1_Click" />

            <hr />
        </div>
        <p>
            You were searching for the product id:
            <asp:TextBox ID="txtsearch" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Show the  data you were searching for" OnClick="Button2_Click" />

            </p>
    </form>
</body>
</html>
