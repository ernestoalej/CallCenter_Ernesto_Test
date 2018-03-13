<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CallCenterTest.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">

        <h1>Call Center</h1>
        <div>

        <p style="font-weight:bold">Cedula:
            <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox></p> 
            
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            
            <br/>
            <br/>
            
            <asp:GridView ID="grClientesPagos" runat="server">
            </asp:GridView>
            <br />
        </div>

    </form>
       
        <footer>
            <p>Desarrollado por: Ernesto Contreras</p>
            <p>Hispano Soluciones</p>
        </footer>
</body>
</html>
