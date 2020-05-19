using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using model;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


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

            CreateStationMarkers();
        }

        private void LoadCBDepartments()
        {
            foreach (string dep in this.databaseAdministrator.department)
            {
                cbDepartments.Items.Add(dep);
            }
        }

        private void btReturnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.DatabaseAdministrator = this.databaseAdministrator;
            mainMenu.Show();
            this.Close();
        }

        private void CreateStationMarkers()
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

        public void GetData()
        {
                
        }




    }
}
