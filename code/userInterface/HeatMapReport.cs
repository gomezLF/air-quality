using System;
using System.Windows.Forms;
using LiveCharts.WinForms;
using model;

namespace userInterface
{
    public partial class HeatMapReport : Form
    {
        private DatabaseAdministrator databaseAdministrator;
        private GeoMap heatMap;

        public HeatMapReport(DatabaseAdministrator databaseAdministrator)
        {
            InitializeComponent();

            this.databaseAdministrator = databaseAdministrator;
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
