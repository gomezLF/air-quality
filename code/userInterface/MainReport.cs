using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using model;
using System.Net;
using System.IO;

namespace userInterface
{
    public partial class MainReport : Form
    {
        private AirQuality airQuality;

        private Boolean boxChecked = false;
        private DataGridView totalData;
        private int totalRows;
        private int currentPage;
        private int maxPages;
        private int rowsPerPage;

        public MainReport(AirQuality airQuality)
        {
            InitializeComponent();
            this.airQuality = airQuality;
        }

        // Agre los componentes de los combobox a sus respectivos.
        public void AddDataEntitiesComboBox()
        {

            cbFields.Items.Add("Seleccione un campo");
            cbFields.SelectedIndex = 0;

            cbClauses.Items.Add("Seleccione un clausula");
            cbClauses.SelectedIndex = 0;
            cbClauses.Items.Add("select");
            cbClauses.Items.Add("where");
            cbClauses.Items.Add("order");

        }

        private void MainReport_Load(object sender, EventArgs e)
        {
            totalData = new DataGridView();
            totalRows = 0;
            currentPage = 0;
            maxPages = 0;
            rowsPerPage = 0;

            AddDataEntitiesComboBox();
            btShowFields.Enabled = false;
        }

       
        private void btMarkAll_Click(object sender, EventArgs e)
        {
            foreach (Control c in tlpFields.Controls)
            {
                CheckBox cb = (CheckBox)c;
                cb.Checked = true;
            }
            btShowFields.Enabled = true;
        }

        private void btDesmarkAll_Click(object sender, EventArgs e)
        {
            foreach (Control c in tlpFields.Controls)
            {
                CheckBox cb = (CheckBox)c;
                cb.Checked = false;
            }
            btShowFields.Enabled = false;
        }

        private async void btShowFields_Click(object sender, EventArgs e)
        {
            airQuality.URL += "$select=";
            foreach (Control c in tlpFields.Controls)
            {
                CheckBox cb = (CheckBox)c;
                if (cb.Checked)
                {
                    airQuality.URL += cb.Text + ",";
                    boxChecked = true;
                }
            }

            airQuality.URL = airQuality.URL.TrimEnd(',');
            airQuality.ResultResponse = await airQuality.getHttps(airQuality.URL);
            
            Console.WriteLine(airQuality.ResultResponse);

            if (airQuality.ResultResponse == null || airQuality.ResultResponse.Equals(""))
            {
                MessageBox.Show("El Dataset buscado no fue encontrado");
            }

            airQuality.Meditions = JsonConvert.DeserializeObject<List<Medition>>(airQuality.ResultResponse);

            foreach (Medition medition in airQuality.Meditions) {
                Console.WriteLine(medition);
            }
            
            if (boxChecked == true)
            {
                dataGridView1.DataSource = airQuality.Meditions;
            }
            else
            {
                MessageBox.Show("Debe marcar algún campo");
            }

            foreach (Control c in tlpFields.Controls)
            {
                CheckBox cb = (CheckBox)c;
                if (cb.Checked)
                {
                    cbFields.Items.Add(cb.Text);
                }
            }

            airQuality.URL = airQuality.UrlIntermediative;
        }

    
        private void cbClauses_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSeparater.Items.Clear();

            if (cbClauses.SelectedItem.Equals("select"))
            {
                cbSeparater.Items.Add("Seleccione un separador");
                cbSeparater.SelectedIndex = 0;
                cbSeparater.Items.Add("=");
            }
            else if (cbClauses.SelectedItem.Equals("where"))
            {
                cbSeparater.Items.Add("Seleccione un separador");
                cbSeparater.SelectedIndex = 0;
                cbSeparater.Items.Add("=");
                cbSeparater.Items.Add(">");
                cbSeparater.Items.Add("<");
            }
            else if (cbClauses.SelectedItem.Equals("order"))
            {
                cbSeparater.Items.Add("Seleccione un separador");
                cbSeparater.SelectedIndex = 0;
                cbSeparater.Items.Add("DESC");
                cbSeparater.Items.Add("ASC");
            }

            if (cbClauses.SelectedItem.Equals("select"))
            {
                cbSeparater.Enabled = false;
                tbValue.Enabled = false;
            }
            else if (cbClauses.SelectedItem.Equals("where"))
            {
                cbSeparater.Enabled = true;
                tbValue.Enabled = true;
            }
            else if (cbClauses.SelectedItem.Equals("order"))
            {
                cbSeparater.Enabled = true;
                tbValue.Enabled = false;
            }
        }

        private void tlpFields_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control c in tlpFields.Controls)
            {
                CheckBox cb = (CheckBox)c;
                if (cb.Checked == true)
                {
                    btShowFields.Enabled = true;
                }
            }
        }

        private void cbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClauses.SelectedIndex == 0)
            {
                cbSeparater.Enabled = false;
            }
        }

        private async void btFilter_Click(object sender, EventArgs e)
        {
            airQuality.UrlFinal = airQuality.UrlIntermediative;

            // Agrega la clausula indicada a la url
            if (!cbClauses.SelectedItem.Equals("Seleccione un clausula"))
            {
                if (cbClauses.SelectedItem.Equals("select"))
                {
                    airQuality.UrlFinal += "$" + cbClauses.SelectedItem + "=";

                    if (!cbFields.SelectedItem.Equals("Seleccione un campo"))
                    {
                        airQuality.UrlFinal += cbFields.SelectedItem;
                    }
                    if (!cbSeparater.SelectedItem.Equals("Seleccione un separador"))
                    {
                        airQuality.UrlFinal += "  " + cbSeparater.SelectedItem;
                    }
                    if (!tbValue.Text.Equals(" "))
                    {
                        airQuality.UrlFinal += tbValue.Text;
                    }

                }
                else if (cbClauses.SelectedItem.Equals("where"))
                {
                    airQuality.UrlFinal += "$" + cbClauses.SelectedItem + "=";

                    if (!cbFields.SelectedItem.Equals("Seleccione un campo"))
                    {
                        airQuality.UrlFinal += cbFields.SelectedItem;
                    }
                    if (!cbSeparater.SelectedItem.Equals("Seleccione un separador"))
                    {
                        airQuality.UrlFinal += "  " + cbSeparater.SelectedItem + "  ";
                    }
                    if (!tbValue.Text.Equals(" "))
                    {
                        airQuality.UrlFinal += tbValue.Text;
                    }

                }
                else if (cbClauses.SelectedItem.Equals("order"))
                {
                    airQuality.UrlFinal += "$" + cbClauses.SelectedItem + "=";

                    if (!cbFields.SelectedItem.Equals("Seleccione un campo"))
                    {
                        airQuality.UrlFinal += cbFields.SelectedItem;
                    }
                    if (!cbSeparater.SelectedItem.Equals("Seleccione un separador"))
                    {
                        airQuality.UrlFinal += "  " + cbSeparater.SelectedItem;
                    }
                    if (!tbValue.Text.Equals(" "))
                    {
                        airQuality.UrlFinal += tbValue.Text;
                    }
                }
            }


            // Agrega el límite del número de filas
            if (tbNumberRows.Text.Trim() != "")
            {
                airQuality.UrlFinal += "&$limit=" + tbNumberRows.Text;
            }

            Console.WriteLine(airQuality.UrlFinal);

            airQuality.ResultResponse = await airQuality.getHttps(airQuality.UrlFinal);
            airQuality.UrlFinal = "";

            Console.WriteLine(airQuality.UrlFinal);

            if (airQuality.ResultResponse == null || airQuality.ResultResponse.Equals(""))
            {
                MessageBox.Show("El Dataset buscado no fue encontrado");
            }

            airQuality.Meditions = JsonConvert.DeserializeObject<List<Medition>>(airQuality.ResultResponse);
            if (boxChecked == true)
            {
                dataGridView1.DataSource = airQuality.Meditions;

            }
            else
            {
                MessageBox.Show("Debe marcar algún campo");
            }

        }
    }
}
