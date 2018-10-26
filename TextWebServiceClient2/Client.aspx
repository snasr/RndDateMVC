<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Client.aspx.cs" Inherits="TextWebServiceClient2.Client" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Input:&nbsp;
            <asp:TextBox ID="tbIn" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnGetLower" runat="server" OnClick="btnGetLower_Click" Text="Get Lower" />
            <br />
            <br />
            Output: <asp:TextBox ID="tbOut" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
