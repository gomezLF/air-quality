using System;
using System.Windows.Forms;
using LiveCharts.WinForms;
using LiveCharts.Maps;
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
            heatMap.LandClick += GeoMap1_LandClick;

            String a = "AMAZONAS";
            String b = "Amazonas";

            if (String.Equals(a, b, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine(true);

            
        }

        private void GeoMap1_LandClick(object arg1, MapData arg2)
        {
            Console.WriteLine(arg2.LvcMap);
        }

        private void DataSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void PrintHeatMap()
        {
            this.heatMap.Source = $"{Application.StartupPath}\\Colombia.xml";
            this.mapGenerator.Controls.Add(this.heatMap);
            this.heatMap.Dock = DockStyle.Fill;

            
        }

        
    }
}
