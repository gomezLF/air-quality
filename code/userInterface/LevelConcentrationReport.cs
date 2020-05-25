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
            if (cbDepartments.SelectedItem != null)
            {
                pieChart1.Series["s1"].Points.Clear();
                pieChart1.Titles.Clear();
                pieChart1.Titles.Add($"Niveles de Concentración en {cbDepartments.SelectedItem}");
                pieChart1.Series["s1"].IsValueShownAsLabel = true;

                foreach (var variable in this.databaseAdministrator.variable)
                {
                    String url = DatabaseAdministrator.URL + $"?departamento={cbDepartments.SelectedItem}&variable={variable}&$select=avg({DatabaseAdministrator.CONCENTRATION})";
                    string theValue = this.databaseAdministrator.GetPieValue(this.databaseAdministrator.ConsultData(url));

                    pieChart1.Series["s1"].Points.AddXY(variable, theValue);
                }

            }else
            {
                MessageBox.Show("Para generar el grafico debe de llenar los campos requeridos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

    }
}   

        