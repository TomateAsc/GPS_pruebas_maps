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
    <link href="index.css" rel="stylesheet" type="text/css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> 
        Cosas de prueba
    </title>
    <script type="text/javascript">
        let map;
        let lati;
        let long;
        function fnAceptar() {
            lati = 34.0660545;
            lati = parseFloat(document.getElementById("TextBox2"));
            long = -118.2370216;
            long = parseFloat(document.getElementById("TextBox3"));
            map = new google.maps.Map(document.getElementById("map"), {
                center: { lat: lati, lng: long },
                zoom: 8,
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Conversor de direccion a coordenadas e inverso</h1>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br/>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br/>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br/>
            <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
        </div>
    </form>

        <br/><br/><br/><br/><br/>
    <div class="map">
        <h2>mapa funcional no tan funcional</h2>
        <button class="Button2" id="Button2" runat="server" text="mostrar mapa" />
        <div class="map" id="map" style="width: 400px; height: 350px; border: 5px solid #5E5454;">  
        </div>  
    
        <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAf-OB8eta1P90esfJDtvKSc1q518-Ouo8&callback=initMap&libraries=&v=weekly">

        </script>
        </div>
    </body>
</html>
