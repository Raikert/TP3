<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="Trabajo3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style4 {
            width: 102px;
        }
        .auto-style5 {
            font-size: large;
        }
        .auto-style6 {
            text-decoration: underline;
        }
    </style>
</head>
<body style="height: 510px">
    <form id="form1" runat="server">
        <div style="text-align: left">
            <table class="auto-style2">
                <tr>
                    <td class="auto-style5" colspan="2"><span class="auto-style6"><strong>DESTINO INICIO</strong></span><br />
                        <strong>&nbsp;</strong></td>
                </tr>
                <tr>
                    <td class="auto-style4">PROVINCIA:&nbsp;&nbsp;<br />
&nbsp;</td>
                    <td>
                        <asp:DropDownList ID="ddlProvi" runat="server" Height="16px" Width="180px" style="text-align: center" AutoPostBack="True" OnSelectedIndexChanged="ddlProvi_SelectedIndexChanged">
                        </asp:DropDownList>
                        <br />
&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">LOCALIDAD:<br />
&nbsp;</td>
                    <td>
                        <asp:DropDownList ID="ddlLocali" runat="server" Height="16px" Width="180px" style="text-align: center" AutoPostBack="True">
                        </asp:DropDownList>
                        <br />
&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2"><strong><span class="auto-style6">DESTINO FINAL</span><br />
&nbsp;</strong></td>
                </tr>
                <tr>
                    <td class="auto-style4">PROVINCIA:<br />
&nbsp;</td>
                    <td>
                        <asp:DropDownList ID="ddlProvF" runat="server" Height="16px" Width="180px" style="text-align: center" AutoPostBack="True" OnSelectedIndexChanged="ddlProvF_SelectedIndexChanged">
                        </asp:DropDownList>
                        <br />
&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">LOCALIDAD:
                        <br />
&nbsp;</td>
                    <td>
                        <asp:DropDownList ID="ddlLocalF" runat="server" Height="16px" Width="180px" style="text-align: center" AutoPostBack="True">
                        </asp:DropDownList>
                        <br />
&nbsp;</td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
