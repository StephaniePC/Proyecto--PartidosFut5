
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginSite.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bienvenido a Mis Mejengas</title>
</head>
<body>
    <p>Bienvendio a Mis Mejengas</p>
    <a href="#">Acceso</a> | <a href="Registration.aspx">Registrarse</a>
    <form id="form1" runat="server">
    <div>        
        <p>Enter Username (*)</p>
        <asp:TextBox ID="usernameTextBox" Text="Enter Username" runat="server" />
        <p>Enter Password (*)</p>
        <asp:TextBox ID="passwordTextBox" TextMode="Password" runat="server" />
        <p></p>
        <asp:Label ID="messageLabel" Text="(*) Username y password son requeridos" runat="server" />
        <asp:Button IG="submitButton" Text="Log in" runat="server" OnClick="submitEventMethod" />
    </div>
    </form>
</body>
</html>
