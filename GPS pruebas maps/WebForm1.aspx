<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GPS_pruebas_maps.WebForm1" %>
<script runat="server">
protected void Page_Load(object sender, EventArgs e)
{
    this.Button2.Attributes.Add("OnClick", "javascript:return fnAceptar();");
}
</script>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <link href="index.css" rel="stylesheet" type="text/css">

    <title> 
        Cosas de prueba geo
    </title>
</head>
<body>


    <div class="cuerpo">
        <div class="estilop1">
    <form id="form2" runat="server">
        <section id="label1">
            <asp:Label ID="Label1" runat="server" Text="Ciudad o Pais"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </section>
        <div class="label1">
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" Height="26px" Width="56px" />
        </div>

        <section id="label2">
            <asp:Label ID="Label2" runat="server" Text="Insertar Coordenadas"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </section>
        <div class="label2">
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />

        </div>

        <hr />
        <br />

        <div class="mapa">
            <iframe id="mapageo" src="https://www.google.com/maps/embed/v1/place?key=AIzaSyCORercZbTYCl0ueNKojogpWGDyG7J99LA&q=Ciudad+Juarez" runat="server" height="450" frameborder="0" style="border-style: none; border-color: inherit; border-width: 0; width: 962px;" allowfullscreen></iframe>
        </div>
        
    </form>
            
        </div>
    </div>

</body>
</html>
