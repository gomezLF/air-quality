using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class AirQuality
    {
        // Atributes

        private String url;
        private String urlIntermediative;
        private String urlFinal;
        private String resultResponse;
        private List<Medition> meditions;

        // Constructor

        public AirQuality()
        {
            url = "https://www.datos.gov.co/resource/ysq6-ri4e.json?";
            urlIntermediative = url;
            urlFinal = "";
            resultResponse = "";
            meditions = new List<Medition>();

        }


        // Methods

        // Obtiene los datos de la url 
        public async Task<string> getHttps(String urlFinal)
        {
            WebRequest request = WebRequest.Create(urlFinal);
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();
        }


        // Getters and Setters

        public string URL { get => url; set => url = value; }
        public string UrlIntermediative { get => urlIntermediative; set => urlIntermediative = value; }
        public string UrlFinal { get => urlFinal; set => urlFinal = value; }
        public string ResultResponse { get => resultResponse; set => resultResponse = value; }
        public List<Medition> Meditions { get => meditions; set => meditions = value; }



    }
        

}



    
