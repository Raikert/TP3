<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3-1.aspx.cs" Inherits="Trabajo3.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            Seleccionar tema:&nbsp;
            <asp:DropDownList ID="ddlTemas" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <br />
            <asp:HyperLink ID="hlkLibros" runat="server">Ver libros</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
