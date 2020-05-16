using System;
using System.Windows.Forms;
using model;

namespace userInterface
{
    public partial class MainMenu : Form
    {
        private DatabaseAdministrator DatabaseAdministrator;

        private FilterTableReport FilterTableReport;


        public MainMenu()
        {
            InitializeComponent();
            this.DatabaseAdministrator = new DatabaseAdministrator();
        }

        private void DataFilter_button_Click(object sender, EventArgs e)
        {
            if (this.FilterTableReport == null)
                this.FilterTableReport = new FilterTableReport(DatabaseAdministrator);

            OpenReport(this.FilterTableReport);
        }

        private void HeatMap_button_Click(object sender, EventArgs e)
        {

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
