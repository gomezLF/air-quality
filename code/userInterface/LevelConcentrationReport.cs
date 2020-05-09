using LiveCharts;
using LiveCharts.Wpf;
using model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userInterface
{
    public partial class LevelConcentrationReport : Form
    {
        private AirQuality airQuality;


        public LevelConcentrationReport(AirQuality airQuality)
        {
            InitializeComponent();
            this.airQuality = airQuality;
        }

        private async void LevelConcentrationReport_Load(object sender, EventArgs e)
        {
            airQuality.ResultResponse = await airQuality.getHttps(airQuality.UrlBasic);
            airQuality.Meditions = JsonConvert.DeserializeObject<List<Medition>>(airQuality.ResultResponse);

            //addDepartments();
            addVaribles();
        }



        private void addDepartments()
        {
            cbDepartments.Items.Add("Seleccione un departamento");
            cbDepartments.SelectedIndex = 0;

            List<String> uniqueDepartments = airQuality.Meditions.Select(x => x.departamento).Distinct().ToList();

            foreach (String depart in uniqueDepartments)
            {
                cbDepartments.Items.Add(depart);
            }

        }


        private void addVaribles()
        {
            cbVariable.Items.Add("Seleccione una varible");
            cbVariable.SelectedIndex = 0;

            List<String> uniqueVaribles = airQuality.Meditions.Select(x => x.variable).Distinct().ToList();

            foreach (String vari in uniqueVaribles)
            {
                cbVariable.Items.Add(vari);
            }
        }


        public Double obtineAverageConcentrationPeerDepartment(String department)
        {
            Double average = 0.0;
            Double sum = 0.0;
            foreach (Medition med in airQuality.Meditions) {
                if (med.departamento.Equals(department)) {
                    sum += med.concentraci_n;
                }
            }
            average = sum / airQuality.Meditions.Count;
            return average;
        }

        public void mycreatePie(String varible) {

            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection piechartData = new SeriesCollection();

            /**
            foreach (Medition med in airQuality.Meditions) {

                if (med.variable.Equals(varible)) {

                    List<String> uniqueDepartments = airQuality.Meditions.Select(x => x.departamento).Distinct().ToList();

                    foreach (String dep in uniqueDepartments) {

                        Console.WriteLine(dep);
                        piechartData.Add(
                         new PieSeries
                         {
                             Title = dep,
                             Values = new ChartValues<double> { obtineAverageConcentrationPeerDepartment(dep) },
                             DataLabels = true,
                             LabelPoint = labelPoint,
                             Fill = System.Windows.Media.Brushes.Blue
                         }
                       );
                    }

                }
                 **/


            for (int i = 0; i < airQuality.Meditions.Count; i++)
            {

                if (airQuality.Meditions[i].variable.Equals(varible))
                {

                    piechartData.Add(
                     new PieSeries
                     {
                         Title = airQuality.Meditions[i].departamento,
                         Values = new ChartValues<double> { obtineAverageConcentrationPeerDepartment(airQuality.Meditions[i].departamento) },
                         DataLabels = true,
                         LabelPoint = labelPoint,
                         Fill = System.Windows.Media.Brushes.Blue
                     }
                   );

                }

            }


            // Define the collection of Values to display in the Pie Chart
              pieChart1.Series = piechartData;

            // Set the legend location to appear in the Right side of the chart
              pieChart1.LegendLocation = LegendLocation.Right;


        }


       



        private void cbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }


        private void cbVariable_SelectedIndexChanged(object sender, EventArgs e)
        {
            mycreatePie(cbVariable.SelectedItem+"");
        }
        

    
    }
}
