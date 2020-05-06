using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using model;

namespace userInterface
{
    public partial class FormInicial : Form
    {
        private const int MAIN_REPORT = 1;
        private const int HOTMAP = 2;
        private const int MONITORY_STATION = 3;
        private const int LEVEL_CONCENTRATION = 4;
        private const int STUDY_PLACE = 5;

        private AirQuality airQuality;

        private MainReport mainReport;
        private HotMapReport heatMap;
        private MonitoryStationReport monitoryStation;
        private LevelConcentrationReport levelConcentration;
        private StudyPlaceReport studyPlace;

        public FormInicial()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            airQuality = new AirQuality();
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
        private void OpenReport(Form currentReport)
        {
            panelFondoForms.Controls.Clear();

            currentReport.TopLevel = false;
            currentReport.FormBorderStyle = FormBorderStyle.None;
            currentReport.Dock = DockStyle.Fill;

            panelFondoForms.Controls.Add(currentReport);
            panelFondoForms.Tag = currentReport;

            currentReport.Show();
            currentReport.BringToFront();
        }

        private void ReportButtonControl(int report)
        {
            this.btMainReport.Enabled = true;
            this.btHotMapReport.Enabled = true;
            this.btMonitoryStationReport.Enabled = true;
            this.btLevelConcentrationReport.Enabled = true;
            this.btStudyPlaceReport.Enabled = true;

            switch (report)
            {
                case MAIN_REPORT:
                    this.btMainReport.Enabled = false;
                    break;
                case HOTMAP:
                    this.btHotMapReport.Enabled = false;
                    break;
                case MONITORY_STATION:
                    this.btMonitoryStationReport.Enabled = false;
                    break;
                case LEVEL_CONCENTRATION:
                    this.btLevelConcentrationReport.Enabled = false;
                    break;
                case STUDY_PLACE:
                    this.btStudyPlaceReport.Enabled = false;
                    break;
            }
        }


        private void MainReport_Click(object sender, EventArgs e)
        {
            if (this.mainReport == null)
                this.mainReport = new MainReport(this.airQuality);

            OpenReport(this.mainReport);
            ReportButtonControl(MAIN_REPORT);
        }

        private void StudyPlaceReport_Click(object sender, EventArgs e)
        {
            if (this.studyPlace == null)
                this.studyPlace = new StudyPlaceReport(this.airQuality);

            OpenReport(this.studyPlace);
            ReportButtonControl(STUDY_PLACE);
        }

        private void HeatMapReport_Click(object sender, EventArgs e)
        {
            if (this.heatMap == null)
                this.heatMap = new HotMapReport(this.airQuality);

            OpenReport(this.heatMap);
            ReportButtonControl(HOTMAP);
        }

        private void MonitoryStationReport_Click(object sender, EventArgs e)
        {
            if (this.monitoryStation == null)
                this.monitoryStation = new MonitoryStationReport(this.airQuality);

            OpenReport(this.monitoryStation);
            ReportButtonControl(MONITORY_STATION);
        }

        private void LevelConcentrationReport_Click(object sender, EventArgs e)
        {
            if (this.levelConcentration == null)
                this.levelConcentration = new LevelConcentrationReport(this.airQuality);

            OpenReport(this.levelConcentration);
            ReportButtonControl(LEVEL_CONCENTRATION);
        }
        #endregion


    }
}