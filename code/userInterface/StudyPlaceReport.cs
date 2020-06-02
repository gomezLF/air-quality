using model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace userInterface
{
    public partial class StudyPlaceReport : Form
    {

        private readonly DatabaseAdministrator databaseAdministrator;
        private readonly List<string> variables;

        public StudyPlaceReport(DatabaseAdministrator databaseAdministrator)
        {
            InitializeComponent();
            this.databaseAdministrator = databaseAdministrator;
            variables = new List<string>();

            department_ComboBox.DataSource = this.databaseAdministrator.department;
            ChooseVariables();
            FillYearComboBox();
        }

        private void ChooseVariables()
        {
            variables.Add("Temperatura");
            variables.Add("Temperatura a 10 m");
            variables.Add("Temperatura a 2 m");
            variables.Add("Radiación Solar Global");
            variables.Add("Radiación UVB");
        }

        private void FillYearComboBox()
        {
            year_CB.Items.Add("2011");
            year_CB.Items.Add("2012");
            year_CB.Items.Add("2013");
            year_CB.Items.Add("2014");
            year_CB.Items.Add("2015");
            year_CB.Items.Add("2016");
            year_CB.Items.Add("2017");
        }

        private void DisplayOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (var i = 0; i < displayOptions.Items.Count; i++)
            {
                displayOptions.SetItemChecked(i, false);
            }

            var index = displayOptions.SelectedIndex;

            if (index != -1)
            {
                displayOptions.SetItemChecked(index, true);
            }
        }

        private void ShowInformation_button_Click(object sender, EventArgs e)
        {
            if (department_ComboBox.SelectedItem != null && displayOptions.CheckedItems.Count == 1 && year_CB.SelectedItem != null)
            {
                chartContainer_panel.Controls.Clear();

                switch (displayOptions.CheckedItems[0].ToString())
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

        private void btReturnToMainMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu {DatabaseAdministrator = databaseAdministrator};
            mainMenu.Show();
            Close();
        }

        private void CreateOnlyHistoricData(bool fullSize)
        {
            var chart = new Chart();
            chart.Titles.Add($"Datos Históricos del Departamento de {department_ComboBox.SelectedItem}");
            chartContainer_panel.Controls.Add(chart);

            var chA = new ChartArea("Default");
            chart.ChartAreas.Add(chA);

            if (fullSize)
            {
                chart.Dock = DockStyle.Fill;
            } else
            {
                chart.Dock = DockStyle.Bottom;
                chart.Size = new Size(chartContainer_panel.Width, chartContainer_panel.Height / 2);
            }

            chart.Series.Clear();
            chart.Legends.Clear();

            chart.Legends.Add(new Legend("Legend"));
            chart.Legends["Legend"].DockedToChartArea = "Default";
            chart.Legends["Legend"].Docking = Docking.Left;

            foreach (var t in variables)
            {
                var series = new Series
                {
                    Name = t,
                    ChartType = SeriesChartType.Column,
                    Legend = "Legend",
                    IsVisibleInLegend = true
                };

                var url = $"{DatabaseAdministrator.URL}?{DatabaseAdministrator.DEPARTMENT}={department_ComboBox.SelectedItem}&{DatabaseAdministrator.VARIABLE}={t}&$where={DatabaseAdministrator.DATE} between '01/01/{year_CB.SelectedItem} 01:00:00 a. m.' and '31/12/{year_CB.SelectedItem} 12:00:00 a. m.' &$select=avg({DatabaseAdministrator.CONCENTRATION})";
                Console.WriteLine(databaseAdministrator.GetChartValue(databaseAdministrator.ConsultData(url)));
                var valueData = databaseAdministrator.GetChartValue(databaseAdministrator.ConsultData(url));
                double value = 0;
                
                if (!valueData.Equals(""))
                {
                    value = double.Parse(valueData, CultureInfo.InvariantCulture);
                }
                
                series.Points.AddXY($"{year_CB.SelectedItem}", value.ToString("N2"));
                series.Label = value.ToString("N2");
                chart.Series.Add(series);
            }
            chart.Show();
        }

        private void CreateOnlyProjectedData(bool fullSize)
        {
            var chart = new Chart();
            chart.Titles.Add($"Datos Proyectados del Departamento de {department_ComboBox.SelectedItem}");
            chartContainer_panel.Controls.Add(chart);

            var chA = new ChartArea("Default");
            chart.ChartAreas.Add(chA);

            if (fullSize)
            {
                chart.Dock = DockStyle.Fill;
            }
            else
            {
                chart.Dock = DockStyle.Top;
                chart.Size = new Size(chartContainer_panel.Width, chartContainer_panel.Height / 2);
            }
            
            chart.Series.Clear();
            chart.Legends.Clear();

            chart.Legends.Add(new Legend("Legend"));
            chart.Legends["Legend"].DockedToChartArea = "Default";
            chart.Legends["Legend"].Docking = Docking.Left;
            
            var concentration = new List<double>();
            var years = new List<double>();
            years.Insert(0, 2011);
            years.Insert(1, 2012);
            years.Insert(2, 2013);
            years.Insert(3, 2014);
            years.Insert(4, 2015);
            years.Insert(5, 2016);
            years.Insert(6, 2017);
            
            foreach (var t in variables)
            {
                var algorithm = new Algorithms();
                var series = new Series
                {
                    Name = t,
                    ChartType = SeriesChartType.Column,
                    Legend = "Legend",
                    IsVisibleInLegend = true
                };
                
                for (var i = 0; i <= 7; i++)
                {
                    var url = $"{DatabaseAdministrator.URL}?{DatabaseAdministrator.DEPARTMENT}={department_ComboBox.SelectedItem}&{DatabaseAdministrator.VARIABLE}={t}&$where={DatabaseAdministrator.DATE} between '01/01/201{i+1} 01:00:00 a. m.' and '31/12/201{i+1} 12:00:00 a. m.' &$select=avg({DatabaseAdministrator.CONCENTRATION})";
                    Console.WriteLine(databaseAdministrator.GetChartValue(databaseAdministrator.ConsultData(url)));
                    var valueData = databaseAdministrator.GetChartValue(databaseAdministrator.ConsultData(url));
                    
                    if (!valueData.Equals(""))
                    {
                        var value = double.Parse(valueData, CultureInfo.InvariantCulture);
                        concentration.Insert(i, value);
                    }
                }
                algorithm.Coefficients(years, concentration, department_ComboBox.SelectedItem.ToString());

                var valueP = algorithm.LinearRegresion(Algorithms.PROJECTED_DATA);
                series.Points.AddXY($"{year_CB.SelectedItem}", valueP.ToString("N2"));
                series.Label = valueP.ToString("N2");
                chart.Series.Add(series);
            }
            chart.Show();
        }
    }
}
