<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3-2.aspx.cs" Inherits="Trabajo3.Ejercicio3_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Listado de libros:</h3>
&nbsp;<asp:GridView ID="grdLibros" runat="server">
            </asp:GridView>
            <br />
            <asp:HyperLink ID="hypOtroTema" runat="server">Consultar Otro Tema</asp:HyperLink>
        </div>
    </form>
</body>
</html>
