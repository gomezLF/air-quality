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


namespace AirQualityGUI
{
    public partial class HotMapReport : Form
    {
        private GeoMap heatMap;

        public HotMapReport()
        {
            InitializeComponent();

            this.heatMap = new GeoMap();

            PrintHeatMap();
        }

        private void PrintHeatMap()
        {
            this.heatMap.Source = $"{Application.StartupPath}\\Colombia.xml";
            this.mapGenerator.Controls.Add(this.heatMap);
            this.heatMap.Dock = DockStyle.Fill;
        }
    }
}
