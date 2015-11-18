<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePageCalculator.aspx.cs" Inherits="CalculatorWebApplication.HomePageCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:Label ID="Label1" runat="server" ForeColor="#666666"></asp:Label>
    
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Font-Bold="False" Style="text-align:right" Font-Size="XX-Large" Height="45px" Width="216px" OnTextChanged="TextBox1_TextChanged" BackColor="#33CCCC" BorderStyle="Inset">0</asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" Font-Bold="True" Height="31px" Text="7" Width="35px" OnClick="Button7_Click1" BackColor="#CCCCFF" />
        &nbsp;<asp:Button ID="Button8" runat="server" Font-Bold="True" Height="31px" Text="8" Width="35px" OnClick="Button8_Click" BackColor="#CCCCFF" />
        &nbsp;<asp:Button ID="Button9" runat="server" Font-Bold="True" Height="31px" Text="9" Width="35px" OnClick="Button9_Click" BackColor="#CCCCFF" />
        &nbsp;<asp:Button ID="Button16" runat="server" Height="31px" Text="/" Width="35px" Font-Bold="True" Font-Size="Medium" OnClick="Button16_Click" BackColor="#FFCCFF" />
        &nbsp;<asp:Button ID="Button19" runat="server" Height="31px" Text="&lt;--" Width="45px" Font-Bold="True" Font-Size="Medium" OnClick="Button19_Click" BackColor="#CCFFCC" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" Font-Bold="True" Height="31px" Text="4" Width="35px" OnClick="Button4_Click" BackColor="#CCCCFF" />
        &nbsp;<asp:Button ID="Button5" runat="server" Font-Bold="True" Height="31px" Text="5" Width="35px" OnClick="Button5_Click" BackColor="#CCCCFF" />
        &nbsp;<asp:Button ID="Button6" runat="server" Font-Bold="True" Height="31px" Text="6" Width="35px" OnClick="Button6_Click" BackColor="#CCCCFF" />
        &nbsp;<asp:Button ID="Button15" runat="server" Font-Bold="True" Height="31px" Text="*" Width="35px" Font-Size="Medium" OnClick="Button15_Click" BackColor="#FFCCFF" />
        &nbsp;<asp:Button ID="Button18" runat="server" Height="31px" Text="CE" Width="45px" Font-Bold="True" Font-Size="Medium" OnClick="Button18_Click" BackColor="#CCFFCC" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Font-Bold="True" Height="31px" Text="1" Width="35px" OnClick="Button1_Click" BackColor="#CCCCFF" />
        &nbsp;<asp:Button ID="Button2" runat="server" Font-Bold="True" Height="31px" Text="2" Width="35px" OnClick="Button2_Click1" BackColor="#CCCCFF" />
        &nbsp;<asp:Button ID="Button3" runat="server" Font-Bold="True" Height="31px" Text="3" Width="35px" OnClick="Button3_Click1" BackColor="#CCCCFF" />
        &nbsp;<asp:Button ID="Button14" runat="server" Height="31px" Text="-" Width="35px" Font-Bold="True" Font-Size="Medium" OnClick="Button14_Click" BackColor="#FFCCFF" />
        &nbsp;<asp:Button ID="Button17" runat="server" Height="31px" Text="C" Width="45px" Font-Bold="True" Font-Size="Medium" OnClick="Button17_Click" BackColor="#CCFFCC" />
        <br />
        <br />
        <asp:Button ID="Button0" runat="server" Font-Bold="True" Height="31px" Text="0" Width="48px" OnClick="Button0_Click" BackColor="#CCCCFF" />
        &nbsp;<asp:Button ID="Button11" runat="server" Height="31px" Text="." Width="48px" Font-Bold="True" Font-Size="Medium" style="margin-left: 0px" OnClick="Button11_Click" BackColor="#CCCCFF" />
        &nbsp;<asp:Button ID="Button12" runat="server" Height="31px" Text="+" Width="48px" Font-Bold="True" Font-Size="Medium" OnClick="Button12_Click" BackColor="#FFCCFF" />
        &nbsp;<asp:Button ID="Button13" runat="server" Height="31px" Text="=" Width="50px" Font-Bold="True" Font-Size="Medium" OnClick="Button13_Click" BackColor="#FF9966" ForeColor="Black" />
        &nbsp;</div>
    </form>
</body>
</html>
