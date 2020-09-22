<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="Trabajo3.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 97px;
        }
        .auto-style3 {
            width: 140px;
        }
        .auto-style4 {
            width: 245px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Id Producto<br />
&nbsp;</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlProducto" runat="server" Height="16px" Width="101px">
                        <asp:ListItem>Igual a</asp:ListItem>
                        <asp:ListItem>Mayor a</asp:ListItem>
                        <asp:ListItem>Menor a</asp:ListItem>
                    </asp:DropDownList>
                    <br />
&nbsp;</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtProducto" runat="server" Width="200px"></asp:TextBox>
                    <br />
&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Id Categoría<br />
&nbsp;</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlCategoria" runat="server" Height="16px" Width="101px">
                        <asp:ListItem>Igual a</asp:ListItem>
                        <asp:ListItem>Mayor a</asp:ListItem>
                        <asp:ListItem>Menor a</asp:ListItem>
                    </asp:DropDownList>
                    <br />
&nbsp;</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtCategoria" runat="server" Width="200px"></asp:TextBox>
                    <br />
&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnQuitarFiltro" runat="server" OnClick="btnQuitarFiltro_Click" Text="Quitar Filtro" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p>
            <asp:GridView ID="gvFiltrado" runat="server">
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
