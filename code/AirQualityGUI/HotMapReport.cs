using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.WinForms;
using model;

namespace AirQualityGUI
{
    public partial class HotMapReport : Form
    {
        private AirQuality airQuality;
        private GeoMap heatMap;

        public HotMapReport(AirQuality airQuality)
        {
            InitializeComponent();

            this.airQuality = airQuality;
            airQuality.GetInformation();
            AddDepartments();

            this.heatMap = new GeoMap();
            PrintHeatMap();
        }

        private void AddDepartments() 
        {
            cbDepartments.Items.Add("Seleccione un departamento");
            cbDepartments.SelectedIndex = 0;

            foreach (Medition medition in airQuality.Meditions) {
                String depart = medition.departamento;
                Console.WriteLine(depart);
                if (!cbDepartments.Items.Equals(depart)) {
                    cbDepartments.Items.Add(depart);
                }
            }
           
        }


        private void PrintHeatMap()
        {
            this.heatMap.Source = $"{Application.StartupPath}\\Colombia.xml";
            this.mapGenerator.Controls.Add(this.heatMap);
            this.heatMap.Dock = DockStyle.Fill;
        }
    }
}
