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

        public FormInicial()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
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
        private Form openReport<MyReport>() where MyReport : Form, new()
        {
            Form currentReport;
            currentReport = panelFondoForms.Controls.OfType<MyReport>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (currentReport == null)
            {
                currentReport = new MyReport();
                currentReport.TopLevel = false;
                currentReport.FormBorderStyle = FormBorderStyle.None;
                currentReport.Dock = DockStyle.Fill;
                panelFondoForms.Controls.Add(currentReport);
                panelFondoForms.Tag = currentReport;
                currentReport.Show();
                currentReport.BringToFront();
            }
            //si el reporte/instancia existe
            else
            {
                currentReport.BringToFront();
            }

            return currentReport;
        }

        private void btMainReport_Click(object sender, EventArgs e)
        {
            Form cForm = openReport<MainReport>();
           
        }

        private void btHotMapReport_Click(object sender, EventArgs e)
        {
            Form cForm = openReport<HotMapReport>();
        }

        private void btStudyPlaceReport_Click(object sender, EventArgs e)
        {
            Form cForm = openReport<StudyPlaceReport>();
        }

        private void panelFondoForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLevelConcentrationReport_Click(object sender, EventArgs e)
        {
            Form cForm = openReport<LevelConcentrationReport>();
        }

        private void btMonitoryStationReport_Click(object sender, EventArgs e)
        {
            Form cForm = openReport<MonitoryStationReport>();
        }
        #endregion









    }
}