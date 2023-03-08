<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Enter First Number</td>
                    <td>
                        <asp:TextBox ID="txtfirstNum" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Second Number</td>
                    <td>
                        <asp:TextBox ID="txtSecondNum" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Result</td>
                    <td><asp:Label ID="lblResult" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnAdd" runat="server" Text="Sum" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
