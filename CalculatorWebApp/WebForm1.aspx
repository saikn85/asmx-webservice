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
                    <td>
                        <asp:Label ID="lblResult" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GridView1" runat="server" Style="margin-top: 16px">
                        </asp:GridView>
                        <asp:Button ID="btnAdd" runat="server" Text="Sum" OnClick="btnAdd_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="gvCalculations" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
