<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="LoginSite.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrese Para Partidos.</title>
</head>
<body>
    <p>Registro Para Partidos</p>
    <a href="Login.aspx">Acceso</a> | <a href="#">Registrarse</a>
    <form id="form1" runat="server">
    <div>
        <p>Digite un nombre de usuario (*)</p>                                      <%-- Explicacion aqui --%>
        <asp:TextBox ID="usernameTextBox" Text="" runat="server" />                 <%-- TextBox username--%>
        <p>Digite un password (*)</p>
        <asp:TextBox ID="passwordTextBox" TextMode="Password" runat="server" />     <%-- TextBox password--%>
        <p></p>
        <asp:Label ID="messageLabel" Text="(*)Username y password son requeridos" runat="server" />  <%-- Label para mostrar mensaje de error si la informacion no es correcto--%>      
        <asp:Button ID="registrartionButton" Text="Registrarse" runat="server" OnClick="resgisterEventMethod" /> <%-- Boton Registrar, OnClick es el evento--%>
    </div>
    </form>
</body>
</html>
