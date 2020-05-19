using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace model
{
    public class DatabaseAdministrator
    {
        //URL de la base de datos
        public const String URL = "https://www.datos.gov.co/resource/ysq6-ri4e.json";
        public const long TOTAL_AMOUNT_DATA = 15657064;

        //Rutas de los archivos de los nombres de las estaciones y municipios
        private const String STATION_NAMES_PATH = "..\\..\\..\\resources\\data\\stationNames.csv";
        private const String MUNICIPALITIES_PATH = "..\\..\\..\\resources\\data\\namesMunicipalities.csv";  

        //Identificador de cada columna al hacer una peticion a la base de datos
        public const String DATE = "fecha";
        public const String ENVIRONMENTAL_AUTHORITY = "autoridad_ambiental";
        public const String STATION_NAME = "nombre_de_la_estaci_n";
        public const String TECHNOLOGY = "tecnolog_a";
        public const String LATITUDE = "latitud";
        public const String LENGTH = "longitud";
        public const String DEPARTMENT_CODE = "c_digo_del_departamento";
        public const String DEPARTMENT = "departamento";
        public const String MUNICIPALITY_CODE = "c_digo_del_municipio";
        public const String MUNICIPALITY = "nombre_del_municipio";
        public const String STATION_TYPE = "tipo_de_estaci_n";
        public const String EXHIBITHION_TIME = "tiempo_de_exposici_n";
        public const String VARIABLE = "variable";
        public const String UNITS = "unidades";
        public const String CONCENTRATION = "concentraci_n";

        public List<String> enviromentalAuthoriry { get; set; }
        public List<String> stationName { get; set; }
        public List<String> technology { get; set; }
        public List<String> department { get; set; }
        public List<String> municipality { get; set; }
        public List<String> stationType { get; set; }
        public List<String> variable { get; set; }
        public List<String> units { get; set; }

        public List<Data> TheData { get; set; }

        public DatabaseAdministrator()
        {
            OptionsEnviromentalAuthorities();
            OptionsStationName();
            OptionsMunicipalitiesNames();
            OptionsDepartment();
            OptionsTechnology();
            OptionsStationType();
            OptionsUnits();
            OptionsVariable();
        }

        public String ConsultData(String URLData)
        {

            String valueOriginal = "";

            using (WebClient webClient = new System.Net.WebClient())
            {
                WebClient n = new WebClient();
                var json = n.DownloadString(URLData);
                valueOriginal = Convert.ToString(json);
                
            }

            return valueOriginal;
        }

        public List<Data> Getinformation(String URLData)
        {
            List<Data> list = JsonConvert.DeserializeObject<List<Data>>(ConsultData(URLData));
            TheData = list;

            return list;
        }



        #region Metodos para saber las opciones de filtrado que posee cada columna

        private void OptionsEnviromentalAuthorities()
        {
            this.enviromentalAuthoriry = new List<string>();

            this.enviromentalAuthoriry.Add("SDA");
            this.enviromentalAuthoriry.Add("AMVA");
            this.enviromentalAuthoriry.Add("DAGMA");
            this.enviromentalAuthoriry.Add("CDMB");
            this.enviromentalAuthoriry.Add("CORPOGUAJIRA");
            this.enviromentalAuthoriry.Add("CORPOBOYACA");
            this.enviromentalAuthoriry.Add("CORPAMAG");
            this.enviromentalAuthoriry.Add("CORANTIOQUIA");
            this.enviromentalAuthoriry.Add("CAR");
            this.enviromentalAuthoriry.Add("CORPOCESAR");
            this.enviromentalAuthoriry.Add("EPA Cartagena");
            this.enviromentalAuthoriry.Add("CVC");
            this.enviromentalAuthoriry.Add("EPA Barranquilla Verde");
            this.enviromentalAuthoriry.Add("CORTOLIMA");
            this.enviromentalAuthoriry.Add("CRA");
            this.enviromentalAuthoriry.Add("CORMACARENA");
            this.enviromentalAuthoriry.Add("CORPORINOQUIA");
            this.enviromentalAuthoriry.Add("CORNARE");
            this.enviromentalAuthoriry.Add("CRC");
            this.enviromentalAuthoriry.Add("CARDER");
            this.enviromentalAuthoriry.Add("CORPOCALDAS");
            this.enviromentalAuthoriry.Add("CRQ");
            this.enviromentalAuthoriry.Add("CAM");
            this.enviromentalAuthoriry.Add("CORPONOR");
            this.enviromentalAuthoriry.Add("CORPONARIÑO");
            this.enviromentalAuthoriry.Add("CVS");
            this.enviromentalAuthoriry.Add("CODECHOCO");
        }

        private void OptionsStationName()
        {
            this.stationName = new List<string>();

            StreamReader sr = new StreamReader(STATION_NAMES_PATH);
            String line = sr.ReadLine();
            line = sr.ReadLine();

            while (line != null)
            {
                this.stationName.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }

        private void OptionsMunicipalitiesNames()
        {
            this.municipality = new List<string>();

            StreamReader sr = new StreamReader(MUNICIPALITIES_PATH);
            String line = sr.ReadLine();
            line = sr.ReadLine();

            while (line != null)
            {
                this.municipality.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }

        private void OptionsDepartment()
        {
            this.department = new List<string>();

            this.department.Add("ANTIOQUIA");
            this.department.Add("ARAUCA");
            this.department.Add("ATLÁNTICO");
            this.department.Add("BOLÍVAR");
            this.department.Add("BOYACÁ");
            this.department.Add("CALDAS");
            this.department.Add("CASANARE");
            this.department.Add("CAUCA");
            this.department.Add("CESAR");
            this.department.Add("CHOCÓ");
            this.department.Add("CÓRDOBA");
            this.department.Add("CUNDINAMARCA");
            this.department.Add("HUILA");
            this.department.Add("LA GUAJIRA");
            this.department.Add("MAGDALENA");
            this.department.Add("META");
            this.department.Add("NARIÑO");
            this.department.Add("NORTE DE SANTANDER");
            this.department.Add("QUINDÍO");
            this.department.Add("RISARALDA");
            this.department.Add("SANTANDER");
            this.department.Add("TOLIMA");
            this.department.Add("VALLE DEL CAUCA");
        }

        private void OptionsTechnology()
        {
            this.technology = new List<string>();

            this.technology.Add("Automática");
            this.technology.Add("Manual");
        }

        private void OptionsStationType()
        {
            this.stationType = new List<string>();

            this.stationType.Add("Fija");
            this.stationType.Add("Indicativa");
        }

        private void OptionsUnits()
        {
            this.units = new List<string>();

            this.units.Add("%");
            this.units.Add("°");
            this.units.Add("°C");
            this.units.Add("µg/m3");
            this.units.Add("m/s");
            this.units.Add("MED/h");
            this.units.Add("mm");
            this.units.Add("mm Hg");
            this.units.Add("W/m2");
        }

        private void OptionsVariable()
        {
            this.variable = new List<string>();

            this.variable.Add("CO");
            this.variable.Add("Dirección del Viento");
            this.variable.Add("Humedad Relativa");
            this.variable.Add("Humedad Relativa 10 m");
            this.variable.Add("Humedad Relativa 2 m");
            this.variable.Add("NO");
            this.variable.Add("NO2");
            this.variable.Add("O3");
            this.variable.Add("PM10");
            this.variable.Add("PM2.5");
            this.variable.Add("Precioitación Líquida");
            this.variable.Add("Presión Atmosférica");
            this.variable.Add("PST");
            this.variable.Add("Radiación Solar Global");
            this.variable.Add("Radiación UVB");
            this.variable.Add("SO2");
            this.variable.Add("Temperatura");
            this.variable.Add("Temperatura a 10 m");
            this.variable.Add("Temperatura a 2 m");
            this.variable.Add("Velocidad del Viento");
        }

        #endregion
    }
}
