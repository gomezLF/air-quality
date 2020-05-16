using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using model;

namespace userInterface
{
    public partial class FilterTableReport : Form
    {

        private DatabaseAdministrator databaseAdministrator;

        private int pageNumber;

        public FilterTableReport(DatabaseAdministrator databaseAdministrator)
        {
            InitializeComponent();

            this.paging_panel.Visible = false;
            this.filter_panel.Visible = false;
            this.filter_button.Enabled = false;
            
            this.description_tooltip.SetToolTip(this.showData, "Desplegar Tabla de Datos");
            this.description_tooltip.SetToolTip(this.filter_button, "Añadir filtros a la tabla de Datos");

            this.pageNumber = 0;

            this.databaseAdministrator = databaseAdministrator;
        }

        private String FilterOptionsManager(String filter)
        {
            String filterOption = "";

            switch (filter)
            {
                case "Autoridad Ambiental":
                    filterOption = DatabaseAdministrator.ENVIRONMENTAL_AUTHORITY;
                    break;
                case "Concentración":
                    filterOption = DatabaseAdministrator.CONCENTRATION;
                    break;
                case "Departamento":
                    filterOption = DatabaseAdministrator.DEPARTMENT;
                    break;
                case "Fecha":
                    filterOption = DatabaseAdministrator.DATE;
                    break;
                case "Nombre de la Estación":
                    filterOption = DatabaseAdministrator.STATION_NAME;
                    break;
                case "Nombre del Municipio":
                    filterOption = DatabaseAdministrator.MUNICIPALITY;
                    break;
                case "Tecnología":
                    filterOption = DatabaseAdministrator.TECHNOLOGY;
                    break;
                case "Tiempo de Exposición":
                    filterOption = DatabaseAdministrator.EXHIBITHION_TIME;
                    break;
                case "Tipo de Estación":
                    filterOption = DatabaseAdministrator.STATION_TYPE;
                    break;
                case "Unidades":
                    filterOption = DatabaseAdministrator.UNITS;
                    break;
                case "Variable":
                    filterOption = DatabaseAdministrator.VARIABLE;
                    break;
            }

            return filterOption;
        }



        #region Creacion de las vistas

        private void CreateDataTable()
        {
            Console.WriteLine(ApplyFilter());
            List<Data> list = this.databaseAdministrator.Getinformation(ApplyFilter());
            this.dataViewer.Controls.Clear();

            DataGridView dataGrid = new DataGridView();
            dataGrid.DataSource = list;
            dataGrid.Dock = DockStyle.Fill;

            this.dataViewer.Controls.Add(dataGrid);

            if (dataGrid.Rows.Count < 100)
            {
                NextButtonManager(false);
            }
        }

        #endregion



        #region Botones de Paginacion

        private void Next_button_Click(object sender, EventArgs e)
        {
            PreviousButtonManager(true);

            this.pageNumber += 100;
            CreateDataTable();
        }

        private void Previous_button_Click(object sender, EventArgs e)
        {
            NextButtonManager(true);

            this.pageNumber -= 100;
            CreateDataTable();

            if (pageNumber == 0)
            {
                PreviousButtonManager(false);
            }
        }

        private void PreviousButtonManager(bool enable)
        {
            this.previous_button.Enabled = enable;
        }

        private void NextButtonManager(bool enable)
        {
            this.next_button.Enabled = enable;
        }

        #endregion



        #region Menu Seleccion de Datos
        private void ShowData_Click(object sender, EventArgs e)
        {
            this.showData.Enabled = false;
            this.paging_panel.Visible = true;
            this.filter_button.Enabled = true;

            PreviousButtonManager(false);
            AddFilters();
            CreateDataTable();
        }

        #endregion



        #region Menu de Filtrado

        private void Filter_button_Click(object sender, EventArgs e)
        {
            if (this.filter_panel.Visible == false)
            {
                this.filter_panel.Visible = true;
            } else
            {
                this.filter_panel.Visible = false;
            }
        }

        private void AddFilters()
        {
            filterOption_panel.Controls.Clear();

            foreach (String field in this.availableData_listBox.Items)
            {
                CreateDataFilterField(field);
            }
        }

        private void CreateDataFilterField(String field)
        {
            if (field.CompareTo("Fecha") == 0)
            {
                CreateDateFilterField(field);
            }
            else if (field.CompareTo("Concentración") == 0 || field.CompareTo("Tiempo de Exposición") == 0)
            {
                CreateConcentrationFilterField(field);
            }
            else
            {
                //Creacion del panel
                Panel panel = new Panel();
                panel.Name = "Empty";
                this.filterOption_panel.Controls.Add(panel);

                panel.Size = new Size(240, 87);
                panel.BackColor = SystemColors.GradientActiveCaption;

                //Ceracion del label
                Label label = new Label();
                label.AutoSize = true;
                panel.Controls.Add(label);

                label.Text = field;
                label.Location = new Point(4, 4);
                label.BackColor = SystemColors.GradientActiveCaption;
                label.BorderStyle = BorderStyle.None;
                label.Font = new Font(label.Font, FontStyle.Bold);

                //Creacion del ComboBox
                ComboBox comboBox = new ComboBox();
                panel.Controls.Add(comboBox);

                comboBox.Size = new Size(191, 21);
                comboBox.Location = new Point(3, 29);
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox.FlatStyle = FlatStyle.Flat;
                comboBox.BackColor = SystemColors.ControlLightLight;
                FillComboBox(field, comboBox);

                //Creacion de los botones
                createApplyFilterButton(panel, comboBox, field);
            }
        }

        private void CreateDateFilterField(String field)
        {
            //Creacion del panel
            Panel panel = new Panel();
            panel.Name = "Empty";
            this.filterOption_panel.Controls.Add(panel);

            panel.Size = new Size(240, 142);
            panel.BackColor = SystemColors.GradientActiveCaption;

            //Ceracion del label
            Label label = new Label();
            label.AutoSize = true;
            panel.Controls.Add(label);

            label.Text = field;
            label.Location = new Point(4, 4);
            label.BackColor = SystemColors.GradientActiveCaption;
            label.BorderStyle = BorderStyle.None;
            label.Font = new Font(label.Font, FontStyle.Bold);

            //Creacion de los ComboBox
            ComboBox year = new ComboBox();
            panel.Controls.Add(year);

            year.Size = new Size(88, 21);
            year.Location = new Point(142, 34);
            year.DropDownStyle = ComboBoxStyle.DropDownList;
            year.FlatStyle = FlatStyle.Flat;
            year.BackColor = SystemColors.ControlLightLight;

            year.Items.Add("2011");
            year.Items.Add("2012");
            year.Items.Add("2013");
            year.Items.Add("2014");
            year.Items.Add("2015");
            year.Items.Add("2016");
            year.Items.Add("2017");

            ComboBox date = new ComboBox();
            panel.Controls.Add(date);

            date.Size = new Size(121, 21);
            date.Location = new Point(58, 73);
            date.DropDownStyle = ComboBoxStyle.DropDownList;
            date.FlatStyle = FlatStyle.Flat;
            date.BackColor = SystemColors.ControlLightLight;

            for (int i = 1; i <= 12; i++)
            {
                String num = "";
                if (i <= 9)
                {
                    num = "0";
                }
                date.Items.Add(num + i + ":00:00 a. m.");
                date.Items.Add(num + i + ":00:00 p. m.");
            }

            //Creacion de los texBox
            TextBox day = new TextBox();
            panel.Controls.Add(day);

            day.Location = new Point(8, 34);
            day.Size = new Size(61, 20);
            day.Text = "Día";

            TextBox month = new TextBox();
            panel.Controls.Add(month);

            month.Location = new Point(75, 34);
            month.Size = new Size(61, 20);
            month.Text = "Mes";

            CreateApplyDateFilterButton(panel, day, month, year, date, field);
        }

        private void CreateConcentrationFilterField(String field)
        {
            //Creacion del panel
            Panel panel = new Panel();
            panel.Name = "Empty";
            this.filterOption_panel.Controls.Add(panel);

            panel.Size = new Size(240, 87);
            panel.BackColor = SystemColors.GradientActiveCaption;

            //Ceracion del label
            Label label = new Label();
            label.AutoSize = true;
            panel.Controls.Add(label);

            label.Text = field;
            label.Location = new Point(4, 4);
            label.BackColor = SystemColors.GradientActiveCaption;
            label.BorderStyle = BorderStyle.None;
            label.Font = new Font(label.Font, FontStyle.Bold);

            //Creacion del ComboBox
            ComboBox comboBox = new ComboBox();
            panel.Controls.Add(comboBox);

            comboBox.Size = new Size(108, 21);
            comboBox.Location = new Point(5, 29);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.BackColor = SystemColors.ControlLightLight;

            comboBox.Items.Add("=");
            comboBox.Items.Add("<");
            comboBox.Items.Add(">");

            //Creacion del TextBox
            TextBox textBox = new TextBox();
            panel.Controls.Add(textBox);

            textBox.Size = new Size(100, 20);
            textBox.Location = new Point(135, 29);

            CreateApplyConcentrationFilterButton(panel, comboBox, textBox, field);
        }

        private void FillComboBox(String filter, ComboBox comboBox)
        {
            switch (filter)
            {
                case "Autoridad Ambiental":
                    comboBox.Items.AddRange(databaseAdministrator.enviromentalAuthoriry.ToArray());
                    break;
                case "Nombre de la Estación":
                    comboBox.Items.AddRange(databaseAdministrator.stationName.ToArray());
                    break;
                case "Tecnologia":
                    comboBox.Items.AddRange(databaseAdministrator.technology.ToArray());
                    break;
                case "Departamento":
                    comboBox.Items.AddRange(databaseAdministrator.department.ToArray());
                    break;
                case "Nombre del Municipio":
                    comboBox.Items.AddRange(databaseAdministrator.municipality.ToArray());
                    break;
                case "Tipo de Estacion":
                    comboBox.Items.AddRange(databaseAdministrator.stationType.ToArray());
                    break;
                case "Variable":
                    comboBox.Items.AddRange(databaseAdministrator.variable.ToArray());
                    break;
                case "Unidades":
                    comboBox.Items.AddRange(databaseAdministrator.units.ToArray());
                    break;
            }
        }

        private void createApplyFilterButton(Panel panel, ComboBox comboBox, String field)
        {
            Button apply = new Button();
            apply.Text = "Aplicar Filtro";
            apply.Size = new Size(82, 26);
            panel.Controls.Add(apply);

            apply.Click += (s, e) =>
            {
                if (comboBox.SelectedItem != null)
                {
                    this.pageNumber = 0;
                    panel.Name = FilterOptionsManager(field) + "=" + comboBox.SelectedItem.ToString();
                    PreviousButtonManager(false);

                    CreateDataTable();
                }
                else
                {
                    MessageBox.Show("Para aplicar un filtro debe seleccionar primero uno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            apply.Location = new Point(3, 56);
            apply.FlatStyle = FlatStyle.Flat;
            apply.FlatAppearance.BorderSize = 0;
            apply.BackColor = SystemColors.ControlLight;
            apply.Cursor = Cursors.Hand;
        }

        private void CreateApplyDateFilterButton(Panel panel, TextBox day, TextBox month, ComboBox year, ComboBox date, String field)
        {
            Button apply = new Button();
            apply.Text = "Aplicar Filtro";
            apply.Size = new Size(82, 26);
            panel.Controls.Add(apply);

            apply.Click += (s, e) =>
            {
                if ((day.Text.CompareTo("") != 0 && day.Text.CompareTo("Día") != 0) && (month.Text.CompareTo("") != 0 && month.Text.CompareTo("Mes") != 0) && year.SelectedItem != null && date.SelectedItem != null)
                {
                    this.pageNumber = 0;
                    panel.Name = FilterOptionsManager(field) + $"={day.Text}/{month.Text}/{year.SelectedItem} {date.SelectedItem}";
                    PreviousButtonManager(false);

                    CreateDataTable();
                }
                else
                {
                    MessageBox.Show("Para aplicar el filtro debe llenar todos los campos requeridos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            apply.Location = new Point(3, 113);
            apply.FlatStyle = FlatStyle.Flat;
            apply.FlatAppearance.BorderSize = 0;
            apply.BackColor = SystemColors.ControlLight;
            apply.Cursor = Cursors.Hand;
        }

        private void CreateApplyConcentrationFilterButton(Panel panel, ComboBox comboBox, TextBox textBox, String field)
        {
            Button apply = new Button();
            apply.Text = "Aplicar Filtro";
            apply.Size = new Size(82, 26);
            panel.Controls.Add(apply);

            apply.Click += (s, e) =>
            {
                if (comboBox.SelectedItem != null && textBox.Text.CompareTo("") != 0)
                {
                    this.pageNumber = 0;
                    panel.Name = $"$where={FilterOptionsManager(field)} {comboBox.SelectedItem} {textBox.Text}";
                    PreviousButtonManager(false);

                    CreateDataTable();
                }
                else
                {
                    MessageBox.Show("Para aplicar el filtro debe llenar todos los campos requeridos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            apply.Location = new Point(3, 56);
            apply.FlatStyle = FlatStyle.Flat;
            apply.FlatAppearance.BorderSize = 0;
            apply.BackColor = SystemColors.ControlLight;
            apply.Cursor = Cursors.Hand;
        }

        private String ApplyFilter()
        {
            List<Panel> list = filterOption_panel.Controls.OfType<Panel>().Cast<Panel>().ToList();

            String URL = $"{DatabaseAdministrator.URL}?$offset={this.pageNumber}&$limit=100";

            foreach (Panel panel in list)
            {
                if (panel.Name.CompareTo("Empty") !=0)
                {
                    URL += $"&{panel.Name}";
                }
            }
            return URL;
        }

        #endregion

        
    }
}
