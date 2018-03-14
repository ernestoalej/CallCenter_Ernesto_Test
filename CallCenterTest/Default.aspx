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
            
            <asp:GridView ID="grClientesPagos" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="nombreCompleto" HeaderText="Nombre Completo" SortExpression="nombreCompleto"></asp:BoundField>
                    <asp:BoundField DataField="FechaPago" DataFormatString="{0:MM/dd/yyyy}" HeaderText="Fecha de Pago" SortExpression="FechaPago" />
                    <asp:BoundField DataField="Monto" HeaderText="Monto" SortExpression="Monto" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CallCenterConnectionString %>" SelectCommand="ConsultaPagosCliente" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:FormParameter FormField="txtCedula" Name="Cedula" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
        </div>

    </form>
       
        <footer>
            <p>Desarrollado por: Ernesto Contreras   <p>Hispano Soluciones</p>
        </footer>
</body>
</html>
