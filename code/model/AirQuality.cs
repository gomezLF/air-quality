using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace model
{
    public class AirQuality
    {
        // Atributes

        private String url;
        private String urlIntermediative;
        private String urlBasic;
        private String urlFinal;
        private String resultResponse;
        private List<Medition> meditions;


        // Constructor

        public AirQuality()
        {
            url = "https://www.datos.gov.co/resource/ysq6-ri4e.json?";
            urlIntermediative = url;
            urlBasic = "https://www.datos.gov.co/resource/ysq6-ri4e.json?$select=concentraci_n,tecnolog_a,unidades,nombre_de_la_estaci_n,variable,tiempo_de_exposici_n,tipo_de_estaci_n,latitud,c_digo_del_municipio,departamento,c_digo_del_departamento,longitud,nombre_del_municipio,fecha";
            urlFinal = "";
            resultResponse = "";
            meditions = new List<Medition>();

        }


        // Methods

        /**
         * Obtiene los datos de la url 
         */
        public async Task<string> getHttps(String urlFinal)
        {
            WebRequest request = WebRequest.Create(urlFinal);
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        /**
         * Agrega los datos a la lista de mediciones.
         * Esta lista contiene todos los datos,
         * por lo que se puede usar en todos reportes,
         * excepto el reporte principal.
         */
        public async void GetInformation() 
        {
            resultResponse = await getHttps(urlBasic);
            meditions = JsonConvert.DeserializeObject<List<Medition>>(resultResponse);
        }


        // Getters and Setters

        public string URL { get => url; set => url = value; }
        public string UrlIntermediative { get => urlIntermediative; set => urlIntermediative = value; }
        public String UrlBasic { get => urlBasic; set => urlBasic = value; }
        public string UrlFinal { get => urlFinal; set => urlFinal = value; }
        public string ResultResponse { get => resultResponse; set => resultResponse = value; }
        public List<Medition> Meditions { get => meditions; set => meditions = value; }



    }
        

}



    
