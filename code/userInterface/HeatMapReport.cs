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

        public HeatMapReport(DatabaseAdministrator databaseAdministrator)
        {
            InitializeComponent();
            FillLandidentificator();

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
            PrintHeatMap();
        }

        private void ReturnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.DatabaseAdministrator = this.databaseAdministrator;
            mainMenu.Show();

            this.Close();
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

        private void PrintHeatMap()
        {
            this.heatMap.Source = $"{Application.StartupPath}\\Colombia.xml";
            this.mapGenerator.Controls.Add(this.heatMap);
            this.heatMap.Dock = DockStyle.Fill;

            FillHeatMap();
        }

        private void FillHeatMap()
        {
            var values = new Dictionary<String, double>();
            
            foreach (String department in databaseAdministrator.department)
            {
                double average = 0.0;
                List<double> list = new List<double>();

                foreach (String variable in databaseAdministrator.variable)
                {
                    String url = DatabaseAdministrator.URL + $"?departamento={department}&variable={variable}&$select=avg({DatabaseAdministrator.CONCENTRATION})";
                    String valueData = databaseAdministrator.GetPieValue(databaseAdministrator.ConsultData(url));

                    if (!valueData.Equals(""))
                    {
                        double value = double.Parse(valueData, CultureInfo.InvariantCulture);

                        list.Add(value);
                    }
                }
                average = this.databaseAdministrator.DataAverage(list);

                values.Add(landIdentificator[department], average);
            }

            heatMap.HeatMap = values;
        }
    }
}
