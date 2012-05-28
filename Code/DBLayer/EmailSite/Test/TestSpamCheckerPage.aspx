<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestSpamCheckerPage.aspx.cs" Inherits="EmailSite.Test.TestSpamCheckerPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Height="281px" Width="301px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Check Spam" 
            onclick="Button1_Click" />
            <asp:TextBox ID="TextBox2" runat="server" Height="281px" Width="301px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
