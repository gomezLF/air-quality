using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using model;
using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace userInterface
{
    public partial class MonitoryStationReport : Form
    {
        private DatabaseAdministrator databaseAdministrator;
        private Dictionary<String, String> stationLoaded;
        
        public MonitoryStationReport(DatabaseAdministrator databaseAdministrator)
        {
            InitializeComponent();
            this.databaseAdministrator = databaseAdministrator;
            this.stationLoaded = new Dictionary<string, string>();
        }

        private void MonitoryStationReport_Load(object sender, EventArgs e)
        {
            LoadCBDepartments();

            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.DragButton = MouseButtons.Right;
            gmap.CanDragMap = true;
            gmap.MapProvider = GMapProviders.OpenStreetMap;
            gmap.ShowCenter = false;
            gmap.Zoom = 5;
            gmap.SetPositionByKeywords("Colombia");
        }

        private void ShowStationsByDepartments_Click(object sender, EventArgs e)
        {
            this.stationLoaded.Clear();
            this.gmap.Overlays.Clear();

            this.stationsTable.Rows.Clear();
            this.stationsTable.Columns.Clear();

            CreateStationByDepartment();
        }


        private void ShowAllStations_Click(object sender, EventArgs e)
        {
            this.stationLoaded.Clear();
            this.gmap.Overlays.Clear();

            this.stationsTable.Rows.Clear();
            this.stationsTable.Columns.Clear();

            CreateAllStationMarkers();
        }

        private void LoadCBDepartments()
        {
            foreach (string dep in this.databaseAdministrator.department)
            {
                cbDepartments.Items.Add(dep);
            }
        }

        private void ReturnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.DatabaseAdministrator = this.databaseAdministrator;
            mainMenu.Show();
            this.Close();
        }

        private void CreateStationByDepartment()
        {
            String url = $"{DatabaseAdministrator.URL}?$select=distinct {DatabaseAdministrator.MUNICIPALITY},{DatabaseAdministrator.DEPARTMENT},{DatabaseAdministrator.STATION_NAME}";
            List<Data> data = this.databaseAdministrator.Getinformation(url);
            
            foreach (Data element in data)
            {
                if (element.departamento.Equals(cbDepartments.SelectedItem.ToString()))
                {
                    String consult = $"{element.nombre_del_municipio}, {element.departamento}, Colombia";

                    if (!stationLoaded.ContainsKey(consult))
                    {
                        this.stationLoaded.Add(consult, element.nombre_de_la_estaci_n);
                    }
                    else
                    {
                        this.stationLoaded[consult] += "\n" + element.nombre_de_la_estaci_n;
                    }
                }
            }

            foreach (String variable in this.stationLoaded.Keys)
            {
                CreateMarker(variable, stationLoaded[variable]);
            }

            CreateStationTableByDepartment(data, true, cbDepartments.SelectedItem.ToString());
        }

        private void CreateAllStationMarkers()
        {
            String url = $"{DatabaseAdministrator.URL}?$select=distinct {DatabaseAdministrator.MUNICIPALITY},{DatabaseAdministrator.DEPARTMENT},{DatabaseAdministrator.STATION_NAME}";
            List<Data> data = this.databaseAdministrator.Getinformation(url);
            
            foreach (Data element in data)
            {
                String consult = $"{element.nombre_del_municipio}, {element.departamento}, Colombia";

                if (!stationLoaded.ContainsKey(consult))
                {
                    this.stationLoaded.Add(consult, element.nombre_de_la_estaci_n);
                }else
                {
                    this.stationLoaded[consult] += "\n" + element.nombre_de_la_estaci_n;
                }
            }

            foreach (String variable in this.stationLoaded.Keys)
            {
                CreateMarker(variable, stationLoaded[variable]);
            }

            CreateStationTableByDepartment(data, false, "");
        }

        private void CreateMarker(String ubication, String stations)
        {
            PointLatLng point;

            gmap.GetPositionByKeywords(ubication, out point);
            GMarkerGoogle marker = new GMarkerGoogle(point, GMarkerGoogleType.orange);

            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = String.Format($"Ubicación: {ubication} \n Estaciones: {stations}");

            GMapOverlay gMapOverlay = new GMapOverlay("Markers");
            gMapOverlay.Markers.Add(marker);
            gmap.Overlays.Add(gMapOverlay);
        }

        private void CreateStationTableByDepartment(List<Data> list, bool filter, String dpt)
        {
            stationsTable.ColumnCount = 3;

            DataGridViewColumn stationName = this.stationsTable.Columns[0];
            stationName.HeaderText = DatabaseAdministrator.STATION_NAME;

            DataGridViewColumn department = this.stationsTable.Columns[1];
            department.HeaderText = DatabaseAdministrator.DEPARTMENT;

            DataGridViewColumn municipality = this.stationsTable.Columns[1];
            municipality.HeaderText = DatabaseAdministrator.MUNICIPALITY;

            foreach (Data data in list)
            {
                if (filter)
                {
                    if (data.departamento.Equals(dpt))
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(stationsTable);

                        row.Cells[0].Value = data.nombre_de_la_estaci_n;
                        row.Cells[1].Value = data.departamento;
                        row.Cells[2].Value = data.nombre_del_municipio;

                        stationsTable.Rows.Add(row);
                    }
                }else
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(stationsTable);

                    row.Cells[0].Value = data.nombre_de_la_estaci_n;
                    row.Cells[1].Value = data.departamento;
                    row.Cells[2].Value = data.nombre_del_municipio;

                    stationsTable.Rows.Add(row);
                }
            }
        }

    }
}
