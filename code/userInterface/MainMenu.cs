using System;
using System.Windows.Forms;
using model;

namespace userInterface
{
    public partial class MainMenu : Form
    {
        public DatabaseAdministrator DatabaseAdministrator;



        public MainMenu()
        {
            InitializeComponent();
            this.DatabaseAdministrator = new DatabaseAdministrator();
        }

        private void DataFilter_button_Click(object sender, EventArgs e)
        {
            FilterTableReport filterTable = new FilterTableReport(DatabaseAdministrator);
            OpenReport(filterTable);
        }

        private void HeatMap_button_Click(object sender, EventArgs e)
        {
            HeatMapReport heatMap = new HeatMapReport(DatabaseAdministrator);
            OpenReport(heatMap);
        }

        private void StudyPlace_button_Click(object sender, EventArgs e)
        {

        }

        private void LevelConcentration_button_Click(object sender, EventArgs e)
        {

        }

        private void MonitoryStation_button_Click(object sender, EventArgs e)
        {

        }


        private void OpenReport(Form currentReport)
        {
            currentReport.Show();
            this.Close();
        }
    }
}
