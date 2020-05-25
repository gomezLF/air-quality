using model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace userInterface
{
    public partial class StudyPlaceReport : Form
    {

        private DatabaseAdministrator databaseAdministrator;
        private List<String> variables;

        public StudyPlaceReport(DatabaseAdministrator databaseAdministrator)
        {
            InitializeComponent();
            this.databaseAdministrator = databaseAdministrator;
            this.variables = new List<String>();

            this.department_ComboBox.DataSource = this.databaseAdministrator.department;
            ChooseVariables();
        }

        private void ChooseVariables()
        {
            this.variables.Add("Temperatura");
            this.variables.Add("Temperatura a 10 m");
            this.variables.Add("Temperatura a 2 m");
            this.variables.Add("Radiación Solar Global");
            this.variables.Add("Radiación UVB");
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
                chart.Size = new Size(this.chartContainer_panel.Width, this.chartContainer_panel.Height / 2);
            }

            //chart.Series.Clear();
            for (int i = 0; i < variables.Count; i++)
            {
                int year = 1;

                Series series = new Series();
                series.Name = variables[i];
                series.ChartType = SeriesChartType.Column;
                chart.Series.Add(series);

                String url_2011 = $"{DatabaseAdministrator.URL}?{DatabaseAdministrator.DEPARTMENT}={this.department_ComboBox.SelectedItem}&{DatabaseAdministrator.VARIABLE}={variables[i]}&$where={DatabaseAdministrator.DATE} between '01/01/201{year} 01:00:00 a. m.' and '31/12/{year} 12:00:00 a. m.' &$select=avg({DatabaseAdministrator.CONCENTRATION})";
                String valueData_2011 = databaseAdministrator.GetChartValue(databaseAdministrator.ConsultData(url_2011));
                chart.Series[i].Points.AddXY($"201{year}", valueData_2011);
                year++;

                String url_2012 = $"{DatabaseAdministrator.URL}?{DatabaseAdministrator.DEPARTMENT}={this.department_ComboBox.SelectedItem}&{DatabaseAdministrator.VARIABLE}={variables[i]}&$where={DatabaseAdministrator.DATE} between '01/01/201{year} 01:00:00 a. m.' and '31/12/201{year} 12:00:00 a. m.'&$select=avg({DatabaseAdministrator.CONCENTRATION})";
                String valueData_2012 = databaseAdministrator.GetChartValue(databaseAdministrator.ConsultData(url_2012));
                chart.Series[i].Points.AddXY($"201{year}", valueData_2011);
                year++;

                String url_2013 = $"{DatabaseAdministrator.URL}?{DatabaseAdministrator.DEPARTMENT}={this.department_ComboBox.SelectedItem}&{DatabaseAdministrator.VARIABLE}={variables[i]}&$where={DatabaseAdministrator.DATE} between '01/01/201{year} 01:00:00 a. m.' and '31/12/201{year} 12:00:00 a. m.'&$select=avg({DatabaseAdministrator.CONCENTRATION})";
                String valueData_2013= databaseAdministrator.GetChartValue(databaseAdministrator.ConsultData(url_2013));
                chart.Series[i].Points.AddXY($"201{year}", valueData_2011);
                year++;

                String url_2014 = $"{DatabaseAdministrator.URL}?{DatabaseAdministrator.DEPARTMENT}={this.department_ComboBox.SelectedItem}&{DatabaseAdministrator.VARIABLE}={variables[i]}&$where={DatabaseAdministrator.DATE} between '01/01/201{year} 01:00:00 a. m.' and '31/12/201{year} 12:00:00 a. m.'&$select=avg({DatabaseAdministrator.CONCENTRATION})";
                String valueData_2014 = databaseAdministrator.GetChartValue(databaseAdministrator.ConsultData(url_2014));
                chart.Series[i].Points.AddXY($"201{year}", valueData_2011);
                year++;

                String url_2015 = $"{DatabaseAdministrator.URL}?{DatabaseAdministrator.DEPARTMENT}={this.department_ComboBox.SelectedItem}&{DatabaseAdministrator.VARIABLE}={variables[i]}&$where={DatabaseAdministrator.DATE} between '01/01/201{year} 01:00:00 a. m.' and '31/12/201{year} 12:00:00 a. m.'&$select=avg({DatabaseAdministrator.CONCENTRATION})";
                String valueData_2015 = databaseAdministrator.GetChartValue(databaseAdministrator.ConsultData(url_2015));
                chart.Series[i].Points.AddXY($"201{year}", valueData_2011);
                year++;

                String url_2016 = $"{DatabaseAdministrator.URL}?{DatabaseAdministrator.DEPARTMENT}={this.department_ComboBox.SelectedItem}&{DatabaseAdministrator.VARIABLE}={variables[i]}&$where={DatabaseAdministrator.DATE} between '01/01/201{year} 01:00:00 a. m.' and '31/12/201{year} 12:00:00 a. m.'&$select=avg({DatabaseAdministrator.CONCENTRATION})";
                String valueData_2016 = databaseAdministrator.GetChartValue(databaseAdministrator.ConsultData(url_2016));
                chart.Series[i].Points.AddXY($"201{year}", valueData_2011);
                year++;

                String url_2017 = $"{DatabaseAdministrator.URL}?{DatabaseAdministrator.DEPARTMENT}={this.department_ComboBox.SelectedItem}&{DatabaseAdministrator.VARIABLE}={variables[i]}&$where={DatabaseAdministrator.DATE} between '01/01/201{year} 01:00:00 a. m.' and '31/12/201{year} 12:00:00 a. m.'&$select=avg({DatabaseAdministrator.CONCENTRATION})";
                String valueData_2017 = databaseAdministrator.GetChartValue(databaseAdministrator.ConsultData(url_2017));
                chart.Series[i].Points.AddXY($"201{year}", valueData_2011);
            }
        }

        private void CreateOnlyProjectedData(bool fullSize)
        {
            Chart chart = new Chart();
            chart.Titles.Add($"Datos Proyectados del Departamento de {this.department_ComboBox.SelectedItem}");
            chart.Series[0].ChartType = SeriesChartType.Column;
            this.chartContainer_panel.Controls.Add(chart);

            if (fullSize)
            {
                chart.Dock = DockStyle.Fill;
            }
            else
            {
                chart.Dock = DockStyle.Top;
                chart.Size = new Size(this.chartContainer_panel.Width, this.chartContainer_panel.Height / 2);
            }
        }
    }
}
