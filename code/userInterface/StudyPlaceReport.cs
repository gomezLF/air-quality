using model;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace userInterface
{
    public partial class StudyPlaceReport : Form
    {

        private DatabaseAdministrator databaseAdministrator;

        public StudyPlaceReport(DatabaseAdministrator databaseAdministrator)
        {
            InitializeComponent();
            this.databaseAdministrator = databaseAdministrator;

            this.department_ComboBox.DataSource = this.databaseAdministrator.department;
        }

        private void DisplayOptions_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            for (int i = 0; i < displayOptions.Items.Count; i++)
            {
                displayOptions.SetItemChecked(i, false);
            }

            int index = displayOptions.SelectedIndex;

            if (index != -1)
            {
                displayOptions.SetItemChecked(index, true);
            }
        }

        private void ShowInformation_button_Click(object sender, System.EventArgs e)
        {
            if (this.department_ComboBox.SelectedItem != null && this.displayOptions.CheckedItems.Count == 1)
            {
                this.chartContainer_panel.Controls.Clear();

                switch (this.displayOptions.CheckedItems[0].ToString())
                {
                    case "Solo Datos Proyectados":
                        CreateOnlyProjectedData(true);
                        break;
                    case "Solo Datos Históricos":
                        CreateOnlyHistoricData(true);
                        break;
                    case "Comparar Datos Históricos con Datos Proyectados":
                        CreateOnlyProjectedData(false);
                        CreateOnlyHistoricData(false);
                        break;
                }

            }else
            {
                MessageBox.Show("Para desplegar la informacion debe previamente haber escogido un departamento y una opcion de depliego", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btReturnToMainMenu_Click(object sender, System.EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.DatabaseAdministrator = this.databaseAdministrator;
            mainMenu.Show();
            this.Close();
        }

        private void CreateOnlyHistoricData(bool fullSize)
        {
            Chart chart = new Chart();
            chart.Titles.Add($"Datos Históricos del Departamento de {this.department_ComboBox.SelectedItem}");
            this.chartContainer_panel.Controls.Add(chart);

            if (fullSize)
            {
                chart.Dock = DockStyle.Fill;
            } else
            {
                chart.Dock = DockStyle.Bottom;
                chart.Size = new Size(this.chartContainer_panel.Width, 263);
            }
        }

        private void CreateOnlyProjectedData(bool fullSize)
        {
            Chart chart = new Chart();
            chart.Titles.Add($"Datos Proyectados del Departamento de {this.department_ComboBox.SelectedItem}");
            this.chartContainer_panel.Controls.Add(chart);

            if (fullSize)
            {
                chart.Dock = DockStyle.Fill;
            }
            else
            {
                chart.Dock = DockStyle.Top;
                chart.Size = new Size(this.chartContainer_panel.Width, 263);
            }
        }
    }
}
