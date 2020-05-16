namespace userInterface
{
    partial class FilterTableReport
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
            this.components = new System.ComponentModel.Container();
            this.selectionData_panel = new System.Windows.Forms.Panel();
            this.availableData_listBox = new System.Windows.Forms.ListBox();
            this.showData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dataViewer = new System.Windows.Forms.Panel();
            this.filter_panel = new System.Windows.Forms.Panel();
            this.filterOption_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.paging_panel = new System.Windows.Forms.Panel();
            this.next_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filter_button = new System.Windows.Forms.Button();
            this.description_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.selectionData_panel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.filter_panel.SuspendLayout();
            this.paging_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectionData_panel
            // 
            this.selectionData_panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.selectionData_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectionData_panel.Controls.Add(this.availableData_listBox);
            this.selectionData_panel.Controls.Add(this.showData);
            this.selectionData_panel.Controls.Add(this.label4);
            this.selectionData_panel.Controls.Add(this.label3);
            this.selectionData_panel.Controls.Add(this.label1);
            this.selectionData_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectionData_panel.Location = new System.Drawing.Point(0, 0);
            this.selectionData_panel.Name = "selectionData_panel";
            this.selectionData_panel.Size = new System.Drawing.Size(200, 561);
            this.selectionData_panel.TabIndex = 2;
            // 
            // availableData_listBox
            // 
            this.availableData_listBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.availableData_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availableData_listBox.FormattingEnabled = true;
            this.availableData_listBox.Items.AddRange(new object[] {
            "Autoridad Ambiental",
            "Concentración",
            "Departamento",
            "Fecha",
            "Nombre de la Estación",
            "Nombre del Municipio",
            "Tecnología",
            "Tiempo de Exposición",
            "Tipo de Estación",
            "Unidades",
            "Variable"});
            this.availableData_listBox.Location = new System.Drawing.Point(11, 62);
            this.availableData_listBox.Name = "availableData_listBox";
            this.availableData_listBox.Size = new System.Drawing.Size(169, 247);
            this.availableData_listBox.Sorted = true;
            this.availableData_listBox.TabIndex = 7;
            // 
            // showData
            // 
            this.showData.AutoSize = true;
            this.showData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.showData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showData.FlatAppearance.BorderSize = 0;
            this.showData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showData.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showData.Location = new System.Drawing.Point(45, 359);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(104, 26);
            this.showData.TabIndex = 6;
            this.showData.Text = "Mostrar Datos";
            this.showData.UseVisualStyleBackColor = false;
            this.showData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(-2, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 2);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(-2, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 2);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Disponibles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainPanel.Controls.Add(this.dataViewer);
            this.mainPanel.Controls.Add(this.filter_panel);
            this.mainPanel.Controls.Add(this.paging_panel);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(884, 561);
            this.mainPanel.TabIndex = 4;
            // 
            // dataViewer
            // 
            this.dataViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewer.Location = new System.Drawing.Point(0, 30);
            this.dataViewer.Name = "dataViewer";
            this.dataViewer.Size = new System.Drawing.Size(614, 480);
            this.dataViewer.TabIndex = 6;
            // 
            // filter_panel
            // 
            this.filter_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filter_panel.Controls.Add(this.filterOption_panel);
            this.filter_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.filter_panel.Location = new System.Drawing.Point(614, 30);
            this.filter_panel.Name = "filter_panel";
            this.filter_panel.Size = new System.Drawing.Size(270, 480);
            this.filter_panel.TabIndex = 5;
            // 
            // filterOption_panel
            // 
            this.filterOption_panel.AutoScroll = true;
            this.filterOption_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterOption_panel.Location = new System.Drawing.Point(0, 0);
            this.filterOption_panel.Name = "filterOption_panel";
            this.filterOption_panel.Size = new System.Drawing.Size(266, 476);
            this.filterOption_panel.TabIndex = 1;
            // 
            // paging_panel
            // 
            this.paging_panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.paging_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paging_panel.Controls.Add(this.next_button);
            this.paging_panel.Controls.Add(this.previous_button);
            this.paging_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paging_panel.Location = new System.Drawing.Point(0, 510);
            this.paging_panel.Name = "paging_panel";
            this.paging_panel.Size = new System.Drawing.Size(884, 51);
            this.paging_panel.TabIndex = 4;
            // 
            // next_button
            // 
            this.next_button.AutoSize = true;
            this.next_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_button.FlatAppearance.BorderSize = 2;
            this.next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.Location = new System.Drawing.Point(447, 10);
            this.next_button.Margin = new System.Windows.Forms.Padding(23);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(83, 29);
            this.next_button.TabIndex = 1;
            this.next_button.Text = "Siguiente";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // previous_button
            // 
            this.previous_button.AutoSize = true;
            this.previous_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previous_button.FlatAppearance.BorderSize = 2;
            this.previous_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_button.Location = new System.Drawing.Point(60, 10);
            this.previous_button.Margin = new System.Windows.Forms.Padding(23);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(75, 29);
            this.previous_button.TabIndex = 0;
            this.previous_button.Text = "Anterior";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.Previous_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.filter_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 30);
            this.panel2.TabIndex = 2;
            // 
            // filter_button
            // 
            this.filter_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.filter_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filter_button.FlatAppearance.BorderSize = 0;
            this.filter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_button.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filter_button.Location = new System.Drawing.Point(771, 0);
            this.filter_button.Name = "filter_button";
            this.filter_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.filter_button.Size = new System.Drawing.Size(100, 30);
            this.filter_button.TabIndex = 7;
            this.filter_button.Text = "Filtros   ";
            this.filter_button.UseVisualStyleBackColor = false;
            this.filter_button.Click += new System.EventHandler(this.Filter_button_Click);
            // 
            // FilterTableReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.selectionData_panel);
            this.Name = "FilterTableReport";
            this.Text = "Tabla Filtradore de Informacion";
            this.selectionData_panel.ResumeLayout(false);
            this.selectionData_panel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.filter_panel.ResumeLayout(false);
            this.paging_panel.ResumeLayout(false);
            this.paging_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel selectionData_panel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip description_tooltip;
        private System.Windows.Forms.Panel paging_panel;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.Panel filter_panel;
        private System.Windows.Forms.Button showData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel filterOption_panel;
        private System.Windows.Forms.Panel dataViewer;
        private System.Windows.Forms.ListBox availableData_listBox;
    }
}