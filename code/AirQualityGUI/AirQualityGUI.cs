using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;

namespace AirQualityGUI
{
    public partial class FormInicial : Form
    {

        private const String MAIN_REPORT = "MR";
        private const String HEATMAP_REPORT = "HR";
        private const String LEVEL_CONCENTRATION_REPORT = "LCR";
        private const String MONITORY_STATION_REPORT = "MSR";
        private const String STUDY_PLACE_REPORT = "SPR";

        private AirQuality airQuality;

        private MainReport mainReport;
        private HotMapReport hotMapReport;
        private LevelConcentrationReport levelConcentrationReport;
        private MonitoryStationReport monitoryStationReport;
        private StudyPlaceReport studyPlaceReport;

        public FormInicial()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            airQuality = new AirQuality();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panelFondoForms_Paint(object sender, PaintEventArgs e)
        {

        }


        #region Comportamiento Formularios
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;
        private void btMaximize_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btMaximize.Visible = false;
            btRestore.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btRestore_Click(object sender, EventArgs e)
        {
            btMaximize.Visible = true;
            btRestore.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBarraTutulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      
        //METODO PARA ARRASTRAR EL FORMULARIO------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion


        #region Manejo Reportes

        // Abrir Los reportes
        

        private void btMainReport_Click(object sender, EventArgs e)
        {
            if (this.mainReport == null)
            {
                this.mainReport = new MainReport();
            }

            this.mainReport.InitAirQuality(airQuality);
            mainReport.TopLevel = false;
            mainReport.FormBorderStyle = FormBorderStyle.None;
            mainReport.Dock = DockStyle.Fill;

            panelFondoForms.Controls.Add(mainReport);
            panelFondoForms.Tag = mainReport;
            mainReport.Show();
            mainReport.BringToFront();
        }

        private void btHotMapReport_Click(object sender, EventArgs e)
        {
            if (this.hotMapReport == null)
            {
                this.hotMapReport = new HotMapReport();
            }

            this.hotMapReport.InitAirQuality(airQuality);
            hotMapReport.TopLevel = false;
            hotMapReport.FormBorderStyle = FormBorderStyle.None;
            hotMapReport.Dock = DockStyle.Fill;

            panelFondoForms.Controls.Add(mainReport);
            panelFondoForms.Tag = mainReport;
            hotMapReport.Show();
            hotMapReport.BringToFront();

        }

        private void btStudyPlaceReport_Click(object sender, EventArgs e)
        {
            if (this.studyPlaceReport == null)
            {
                this.studyPlaceReport = new StudyPlaceReport();
            }

            this.studyPlaceReport.InitAirQuality(airQuality);
            studyPlaceReport.TopLevel = false;
            studyPlaceReport.FormBorderStyle = FormBorderStyle.None;
            studyPlaceReport.Dock = DockStyle.Fill;

            panelFondoForms.Controls.Add(mainReport);
            panelFondoForms.Tag = mainReport;
            studyPlaceReport.Show();
            studyPlaceReport.BringToFront();

        }

        private void btLevelConcentrationReport_Click(object sender, EventArgs e)
        {
            if (this.levelConcentrationReport == null)
            {
                this.levelConcentrationReport = new LevelConcentrationReport();
            }

            this.levelConcentrationReport.InitAirQuality(airQuality);
            levelConcentrationReport.TopLevel = false;
            levelConcentrationReport.FormBorderStyle = FormBorderStyle.None;
            levelConcentrationReport.Dock = DockStyle.Fill;

            panelFondoForms.Controls.Add(mainReport);
            panelFondoForms.Tag = mainReport;
            levelConcentrationReport.Show();
            levelConcentrationReport.BringToFront();

        }

        private void btMonitoryStationReport_Click(object sender, EventArgs e)
        {
            if (this.monitoryStationReport == null)
            {
                this.monitoryStationReport = new MonitoryStationReport();
            }

            this.monitoryStationReport.InitAirQuality(airQuality);
            monitoryStationReport.TopLevel = false;
            monitoryStationReport.FormBorderStyle = FormBorderStyle.None;
            monitoryStationReport.Dock = DockStyle.Fill;

            panelFondoForms.Controls.Add(mainReport);
            panelFondoForms.Tag = mainReport;
            monitoryStationReport.Show();
            monitoryStationReport.BringToFront();

        }
        #endregion









    }
}