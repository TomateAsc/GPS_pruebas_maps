using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net; //trabaja
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

using static Ejemplo1.Resultado_Geo; //importando mi clase, donde va caer el json.
namespace GPS_pruebas_maps
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        const string apikey = "AIzaSyCEXXEz9KDIZSV_7ij6A3xF-o6vUTHr_Uo";
        static string url_api = "https://maps.googleapis.com/maps/api/geocode/json?address=";
        static string url_api_rev = "https://maps.googleapis.com/maps/api/geocode/json?latlng=";
        static string url_key = "&key=";
        string direccion = "";
        string coordenada1 = "";
        string coordenada2 = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            direccion = TextBox1.Text;
            //coorde = TextBox1.Text;
            //echo "tu texto";
            //string coorde = ""
            
            coordenada1 = localizacionlat(direccion);
            //Response.Write(string.Concat("<input id='data1' value='", coordenada1, "' />"));
            TextBox2.Text = coordenada1;
            //return View(coordenada1);
            coordenada2 = localizacionlon(direccion);
            //Response.Write(string.Concat("<input id='data2' value='", coordenada2, "' />"));
            TextBox3.Text = coordenada2;
            //Response.Write(localizacion(coorde));
        }


        /*        public async Task SendMessage(string user, string message)
       {
           await Clients.All.SendAsync("ReceiveMessage", user, message);
       }
*/
        static string localizacionlat(string dir)
        {
            string url = url_api + dir.Replace(" ", "+") + url_key + apikey;
            var json = new WebClient().DownloadString(url);
            geo_response r_json = JsonConvert.DeserializeObject<geo_response>(json);

            if (r_json.status == "OK")
            {
                string info = r_json.results[0].formatted_address;
                string coordenadas = r_json.results[0].geometry.location.lat;
                return coordenadas;
            }
            else
            {
                return json;
            }
        }
        static string localizacionlon(string dir)
        {
            string url = url_api + dir.Replace(" ", "+") + url_key + apikey;
            var json = new WebClient().DownloadString(url);
            geo_response r_json = JsonConvert.DeserializeObject<geo_response>(json);

            if (r_json.status == "OK")
            {
                string info = r_json.results[0].formatted_address;
                string coordenadas = r_json.results[0].geometry.location.lng;
                return coordenadas;
            }
            else
            {
                return json;
            }
        }

        static string rev_localizacion(string coor)
        {
            string url = url_api_rev + coor + url_key + apikey;
            var json = new WebClient().DownloadString(url);
            geo_response r_json = JsonConvert.DeserializeObject<geo_response>(json);

            if (r_json.status == "OK")
            {
                string info = r_json.results[0].formatted_address;
                //string coordenadas = r_json.results[0].geometry.location.lat + " / " + r_json.results[0].geometry.location.lng;
                return info;
            }
            else
            {
                return json;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            coordenada1 = TextBox2.Text;
            coordenada2 = TextBox3.Text;

            string coorde = coordenada1 + ", " + coordenada2;

            TextBox1.Text = rev_localizacion(coorde);
        }
    }
}