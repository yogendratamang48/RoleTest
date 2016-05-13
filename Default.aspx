<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RoleTest.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label runat="server" ID="lblUser">Username</asp:Label> 
        <asp:TextBox runat="server" ID="txtUsername"></asp:TextBox>

    </div>
        <div id="forPassword">
            <asp:Label runat="server" ID="Label1">Password</asp:Label> 
        <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox>
        </div>
        <div id="submit">
            <asp:Button runat="server" ID="btnSubmit" Text="LOG IN" OnClick="btnSubmit_Click" />        </div>
    </form>
</body>
</html>
