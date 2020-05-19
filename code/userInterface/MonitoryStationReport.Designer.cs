namespace userInterface
{
    partial class MonitoryStationReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoryStationReport));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btReturnMainMenu = new System.Windows.Forms.Button();
            this.btShowAllStations = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estaciones de Monitoreo";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btShowAllStations);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbDepartments);
            this.panel2.Location = new System.Drawing.Point(51, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 39);
            this.panel2.TabIndex = 1;
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(316, 6);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(232, 21);
            this.cbDepartments.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(658, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 409);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(320, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.gmap);
            this.panel4.Location = new System.Drawing.Point(-43, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(698, 507);
            this.panel4.TabIndex = 3;
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(48, 0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(647, 497);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 5D;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btReturnMainMenu);
            this.panel1.Location = new System.Drawing.Point(658, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 85);
            this.panel1.TabIndex = 4;
            // 
            // btReturnMainMenu
            // 
            this.btReturnMainMenu.Location = new System.Drawing.Point(39, 27);
            this.btReturnMainMenu.Name = "btReturnMainMenu";
            this.btReturnMainMenu.Size = new System.Drawing.Size(244, 34);
            this.btReturnMainMenu.TabIndex = 0;
            this.btReturnMainMenu.Text = "Regresar al menú Principal";
            this.btReturnMainMenu.UseVisualStyleBackColor = true;
            this.btReturnMainMenu.Click += new System.EventHandler(this.btReturnMainMenu_Click);
            // 
            // btShowAllStations
            // 
            this.btShowAllStations.Location = new System.Drawing.Point(616, 6);
            this.btShowAllStations.Name = "btShowAllStations";
            this.btShowAllStations.Size = new System.Drawing.Size(185, 23);
            this.btShowAllStations.TabIndex = 1;
            this.btShowAllStations.Text = "Mostrar todas las estaciones";
            this.btShowAllStations.UseVisualStyleBackColor = true;
            // 
            // MonitoryStationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(985, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "MonitoryStationReport";
            this.Text = "MonitoryStationReport";
            this.Load += new System.EventHandler(this.MonitoryStationReport_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btReturnMainMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button btShowAllStations;
    }
}