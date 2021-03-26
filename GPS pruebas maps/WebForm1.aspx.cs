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
        const string apikey = "AIzaSyCORercZbTYCl0ueNKojogpWGDyG7J99LA";
        static string url_api = "https://maps.googleapis.com/maps/api/geocode/json?address=";
        static string url_api_rev = "https://maps.googleapis.com/maps/api/geocode/json?latlng=";
        static string url_key = "&key=";
        string direccion = " ";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            direccion = TextBox1.Text;

            Response.Write(localizacion(direccion));

            mapageo.Attributes.Add("src", "https://www.google.com/maps/embed/v1/place?key=AIzaSyCORercZbTYCl0ueNKojogpWGDyG7J99LA&q=" + direccion);

        }

        static string localizacion(string dir)
        {
            string url = url_api + dir.Replace(" ", "+") + url_key + apikey;
            var json = new WebClient().DownloadString(url);
            geo_response r_json = JsonConvert.DeserializeObject<geo_response>(json);

            if (r_json.status == "OK")
            {
                string info = r_json.results[0].formatted_address;
                string cordenadas = r_json.results[0].geometry.location.lat + "  /  " + r_json.results[0].geometry.location.lng;
                return cordenadas;
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
                string cordenadas = r_json.results[0].geometry.location.lat + "  /  " + r_json.results[0].geometry.location.lng;
                return info;
            }
            else
            {
                return json;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string coorde = TextBox2.Text;
            Response.Write(rev_localizacion(coorde));

            mapageo.Attributes.Add("src", "https://www.google.com/maps/embed/v1/place?key=AIzaSyCORercZbTYCl0ueNKojogpWGDyG7J99LA&q=" + coorde);
        }
    }
}