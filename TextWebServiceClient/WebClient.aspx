<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebClient.aspx.cs" Inherits="TextWebServiceClient.WebClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Input Text:
            <asp:TextBox ID="tbInput" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnToLower" runat="server" OnClick="btnToLower_Click" Text="Call ToLower()" />
            <br />
            <br />
            <br />
            Result:
            <asp:TextBox ID="tbResult" runat="server"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
