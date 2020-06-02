using System;
using System.Windows.Forms;
using LiveCharts.WinForms;
using LiveCharts.Maps;
using model;
using System.Collections.Generic;
using System.Globalization;

namespace userInterface
{
    public partial class HeatMapReport : Form
    {
        
        private DatabaseAdministrator databaseAdministrator;
        private GeoMap heatMap;
        private Dictionary<String, String> landIdentificator;
        private List<String> variables;

        public HeatMapReport(DatabaseAdministrator databaseAdministrator)
        {
            InitializeComponent();
            FillLandidentificator();
            FillVariables();
            
            this.heatMap = new GeoMap();
            heatMap.LandClick += HeatMap_LandClick;

            this.databaseAdministrator = databaseAdministrator;
        }

        private void HeatMap_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            if (heatMap.HeatMap.ContainsKey(arg2.Id))
            {
                this.department_txtBox.Text = arg2.Name;
                this.contamination_txtBox.Text = "" + heatMap.HeatMap[arg2.Id];
            }else
            {
                this.department_txtBox.Text = arg2.Name;
                this.contamination_txtBox.Text = "Lugar no Estudiado";
            }
        }

        private void DataSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataSelector.Items.Count; i++)
            {
                dataSelector.SetItemChecked(i, false);
            }

            int index = dataSelector.SelectedIndex;

            if (index != -1)
            {
                dataSelector.SetItemChecked(index, true);
            }
        }

        private void ShowMap_Click(object sender, EventArgs e)
        {
            if (dataSelector.CheckedItems.Count == 1 && this.variable_CB.SelectedItem != null)
            {
                this.mapGenerator.Controls.Clear();
                PrintHeatMap(dataSelector.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Para generar el mapa de calor, seleccione los campos de proyeccción o histórico y una variable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void ReturnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.DatabaseAdministrator = this.databaseAdministrator;
            mainMenu.Show();

            this.Close();
        }

        private void FillVariables()
        {
            this.variables = new List<string>();
            
            this.variables.Add("CO");
            this.variables.Add("NO2");
            this.variables.Add("PM10");
            this.variables.Add("PM2.5");
            this.variables.Add("SO2");

            this.variable_CB.DataSource = this.variables;
        }

        private void FillLandidentificator()
        {
            this.landIdentificator = new Dictionary<String, String>();

            landIdentificator.Add("ANTIOQUIA", "1157");
            landIdentificator.Add("ARAUCA", "1148");
            landIdentificator.Add("ATLÁNTICO", "1144");
            landIdentificator.Add("BOLÍVAR", "172");
            landIdentificator.Add("BOYACÁ", "1158");
            landIdentificator.Add("CALDAS", "1134");
            landIdentificator.Add("CASANARE", "1150");
            landIdentificator.Add("CAUCA", "626");
            landIdentificator.Add("CESAR", "1145");
            landIdentificator.Add("CHOCÓ", "1091");
            landIdentificator.Add("CÓRDOBA", "1159");
            landIdentificator.Add("CUNDINAMARCA", "1135");
            landIdentificator.Add("HUILA", "1141");
            landIdentificator.Add("LA GUAJIRA", "1161");
            landIdentificator.Add("MAGDALENA", "1146");
            landIdentificator.Add("META", "1153");
            landIdentificator.Add("NARIÑO", "1084");
            landIdentificator.Add("NORTE DE SANTANDER", "1149");
            landIdentificator.Add("QUINDÍO", "1137");
            landIdentificator.Add("RISARALDA", "1138");
            landIdentificator.Add("SANTANDER", "1160");
            landIdentificator.Add("TOLIMA", "1139");
            landIdentificator.Add("VALLE DEL CAUCA", "1143");
        }

        private void PrintHeatMap(String map)
        {
            this.heatMap.Source = $"{Application.StartupPath}\\Colombia.xml";
            this.mapGenerator.Controls.Add(this.heatMap);
            this.heatMap.Dock = DockStyle.Fill;

            if (map.Equals("Mostrar Proyeccción de Datos"))
            {
                FillProjectedHeapMap();
            }else if (map.Equals("Mostrar Datos Históricos"))
            {
                FillHistoricHeatMap();
            }
        }

        private void FillHistoricHeatMap()
        {
            var values = new Dictionary<String, double>();
            
            foreach (String department in databaseAdministrator.department)
            {
                String url = DatabaseAdministrator.URL + $"?departamento={department}&variable={variable_CB.SelectedItem}&$select=avg({DatabaseAdministrator.CONCENTRATION})";
                String valueData = databaseAdministrator.GetChartValue(databaseAdministrator.ConsultData(url));

                if (!valueData.Equals(""))
                {
                    double value = double.Parse(valueData, CultureInfo.InvariantCulture);
                    values.Add(landIdentificator[department], value);
                }
            }
            heatMap.HeatMap = values;
        }

        private void FillProjectedHeapMap()
        {
            var values = new Dictionary<String, double>();
            var concentration = new List<Double>();
            
            var years = new List<Double>();
            years.Insert(0, 2011);
            years.Insert(1, 2012);
            years.Insert(2, 2013);
            years.Insert(3, 2014);
            years.Insert(4, 2015);
            years.Insert(5, 2016);
            years.Insert(6, 2017);
            
            foreach (var department in databaseAdministrator.department)
            {
                Algorithms algorithms = new Algorithms();
                
                for (var i = 0; i < 7; i++)
                {
                    var url = $"{DatabaseAdministrator.URL}?{DatabaseAdministrator.DEPARTMENT}={department}&{DatabaseAdministrator.VARIABLE}={variable_CB.SelectedItem}&$where={DatabaseAdministrator.DATE} between '01/01/201{i+1} 01:00:00 a. m.' and '31/12/201{i+1} 12:00:00 a. m.' &$select=avg({DatabaseAdministrator.CONCENTRATION})";
                    var valueData = databaseAdministrator.GetChartValue(databaseAdministrator.ConsultData(url));
                    
                    if (!valueData.Equals(""))
                    {
                        var value = double.Parse(valueData, CultureInfo.InvariantCulture);
                        concentration.Insert(i, value);
                    }
                }
                algorithms.Coefficients(years, concentration, department);
                values.Add(landIdentificator[department], algorithms.LinearRegresion(Algorithms.PROJECTED_DATA));
            }
            heatMap.HeatMap = values;
        }
    }
}
