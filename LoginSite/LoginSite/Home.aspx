<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LoginSite.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Seleccione o Cree su partido.</title>
</head>
<body>
    <p>Seleccione o Cree su partido</p>
    <a href="#">Home site - Lista de Partidos</a>
    <form id="form1" runat="server">
    <div>
        <p></p>
        <asp:Label ID="messageLabel" Text="Busque o cree partidos." runat="server" />    
        <asp:Button ID="refreshButton" Text="Refresh" runat="server" OnClick="refreshEventMethod" />
        <asp:Table ID="Table1" runat="server" CellPadding="5" CellSpacing="5" >
            <asp:TableHeaderRow runat="server">
                <asp:TableHeaderCell>Partido</asp:TableHeaderCell>
                <asp:TableHeaderCell>Fecha</asp:TableHeaderCell>
                <asp:TableHeaderCell>Hora</asp:TableHeaderCell>
                <asp:TableHeaderCell>Registro</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow ID="TableRow1" runat="server" >
                <asp:TableCell>Heredia</asp:TableCell>
                <asp:TableCell>11-01-2016</asp:TableCell>
                <asp:TableCell>18:00</asp:TableCell>
                <asp:TableCell> <asp:Button ID="registrarseButton" Text="Registrarse" runat="server" /> </asp:TableCell>
            </asp:TableRow>
            <asp:TableFooterRow 
                runat="server" >
                <asp:TableCell ColumnSpan="3" HorizontalAlign="Right" >
                    Mis Mejengas
                </asp:TableCell>
            </asp:TableFooterRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
