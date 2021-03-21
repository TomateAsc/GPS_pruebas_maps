using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo1
{
    public class Resultado_Geo
    {
        public class geo_response
        {
            public string status { get; set; }
            public results[] results { get; set; }
        }

        public class results
        {
            public address_components[] address_components { get; set; }
            public string formatted_address { get; set; }
            public geometry geometry { get; set; }
            public string place_id { get; set; }
            public string[] types { get; set; }
        }

        public class address_components
        {
            public string long_name { get; set; }
            public string short_name { get; set; }
            public string[] types { get; set; }
        }

        public class geometry
        {
            public location location { get; set; }
            public string location_type { get; set; }
            public bounds bounds { get; set; }
        }

        public class location
        {
            public string lat { get; set; }
            public string lng { get; set; }
        }

        public class bounds
        {
            public location northeast { get; set; }
            public location southwest { get; set; }
        }
    }
}