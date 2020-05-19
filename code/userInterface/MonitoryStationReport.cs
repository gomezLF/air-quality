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
        public MonitoryStationReport(DatabaseAdministrator databaseAdministrator)
        {
            InitializeComponent();
            this.databaseAdministrator = databaseAdministrator;
        }

        private void MonitoryStationReport_Load(object sender, EventArgs e)
        {
            loadCBDepartments();

            
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.DragButton = MouseButtons.Right;
            gmap.CanDragMap = true;
            gmap.MapProvider = GMapProviders.OpenStreetMap;
            gmap.ShowCenter = false;
            gmap.Zoom = 5;
            gmap.SetPositionByKeywords("Colombia");
            
        }

        private void loadCBDepartments()
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

        private void CreateMarker(String element)
        {
            PointLatLng point;
            gmap.GetPositionByKeywords(element, out point);


            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(4.6097102, -74.081749), GMarkerGoogleType.blue_pushpin);
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);
        }

        public void GetData()
        {
            
        }




    }
}
