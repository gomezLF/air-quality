using LiveCharts;
using LiveCharts.Wpf;
using model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;

namespace userInterface
{
    public partial class LevelConcentrationReport : Form
    {
        private DatabaseAdministrator databaseAdministrator;
        private String customUrl;
        private String defauldUrl;
        private List<Data> listData;

        public LevelConcentrationReport(DatabaseAdministrator databaseAdministrator)
        {
            InitializeComponent();
            this.databaseAdministrator = databaseAdministrator;
            customUrl = "https://www.datos.gov.co/resource/ysq6-ri4e.json";
            listData = new List<Data>();

        }

        private void LevelConcentrationReport_Load(object sender, System.EventArgs e)
        {
            loadCBDepartments();

        }

        public void loadCBDepartments()
        {
            foreach (string dep in this.databaseAdministrator.department)
            {
                cbDepartments.Items.Add(dep);
            }
        }

        
        private void btReturnMainMenu_Click(object sender, System.EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.DatabaseAdministrator = this.databaseAdministrator;
            mainMenu.Show();
            this.Close();
        }


        private void btShowPieChart_Click(object sender, EventArgs e)
        {

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            var collection = new SeriesCollection();

            foreach (string variable in this.databaseAdministrator.variable)
            {
                customUrl = DatabaseAdministrator.URL;
                customUrl += "?departamento="+cbDepartments.SelectedItem+ "&variable="+variable+"&$select=avg(concentraci_n)";
                listData = this.databaseAdministrator.Getinformation(customUrl);

                Console.WriteLine("Se cargaron los datossssss");
                
                collection.Add(new PieSeries
                {
                    Title = variable,
                    Values = new ChartValues<double> { (double) 5 },
                    DataLabels = true

                });
            }

            pieChart1.Series = collection;
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }



    }
}   

        