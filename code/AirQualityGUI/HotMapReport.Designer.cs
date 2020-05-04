namespace AirQualityGUI
{
    partial class HotMapReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotMapReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbShowDateProyection = new System.Windows.Forms.RadioButton();
            this.rbShowDateHistorical = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbDepartmentHotMap = new System.Windows.Forms.RadioButton();
            this.rbColombiaHotMap = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btShowMap = new System.Windows.Forms.Button();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mapGenerator = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rbShowDateProyection);
            this.panel1.Controls.Add(this.rbShowDateHistorical);
            this.panel1.Location = new System.Drawing.Point(14, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 99);
            this.panel1.TabIndex = 0;
            // 
            // rbShowDateProyection
            // 
            this.rbShowDateProyection.AutoSize = true;
            this.rbShowDateProyection.Location = new System.Drawing.Point(77, 57);
            this.rbShowDateProyection.Name = "rbShowDateProyection";
            this.rbShowDateProyection.Size = new System.Drawing.Size(159, 17);
            this.rbShowDateProyection.TabIndex = 1;
            this.rbShowDateProyection.TabStop = true;
            this.rbShowDateProyection.Text = "Mostrar proyección de datos";
            this.rbShowDateProyection.UseVisualStyleBackColor = true;
            // 
            // rbShowDateHistorical
            // 
            this.rbShowDateHistorical.AutoSize = true;
            this.rbShowDateHistorical.Location = new System.Drawing.Point(77, 16);
            this.rbShowDateHistorical.Name = "rbShowDateHistorical";
            this.rbShowDateHistorical.Size = new System.Drawing.Size(140, 17);
            this.rbShowDateHistorical.TabIndex = 0;
            this.rbShowDateHistorical.TabStop = true;
            this.rbShowDateHistorical.Text = "Mostrar Datos Históricos";
            this.rbShowDateHistorical.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.rbDepartmentHotMap);
            this.panel2.Controls.Add(this.rbColombiaHotMap);
            this.panel2.Location = new System.Drawing.Point(14, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 128);
            this.panel2.TabIndex = 1;
            // 
            // rbDepartmentHotMap
            // 
            this.rbDepartmentHotMap.AutoSize = true;
            this.rbDepartmentHotMap.Location = new System.Drawing.Point(62, 77);
            this.rbDepartmentHotMap.Name = "rbDepartmentHotMap";
            this.rbDepartmentHotMap.Size = new System.Drawing.Size(187, 17);
            this.rbDepartmentHotMap.TabIndex = 1;
            this.rbDepartmentHotMap.TabStop = true;
            this.rbDepartmentHotMap.Text = "Mapa de Calor por Departamentos";
            this.rbDepartmentHotMap.UseVisualStyleBackColor = true;
            // 
            // rbColombiaHotMap
            // 
            this.rbColombiaHotMap.AutoSize = true;
            this.rbColombiaHotMap.Location = new System.Drawing.Point(62, 33);
            this.rbColombiaHotMap.Name = "rbColombiaHotMap";
            this.rbColombiaHotMap.Size = new System.Drawing.Size(155, 17);
            this.rbColombiaHotMap.TabIndex = 0;
            this.rbColombiaHotMap.TabStop = true;
            this.rbColombiaHotMap.Text = "Mapa de Calor de Calombia";
            this.rbColombiaHotMap.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btShowMap);
            this.panel3.Controls.Add(this.cbDepartments);
            this.panel3.Location = new System.Drawing.Point(14, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 116);
            this.panel3.TabIndex = 2;
            // 
            // btShowMap
            // 
            this.btShowMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btShowMap.Location = new System.Drawing.Point(102, 56);
            this.btShowMap.Name = "btShowMap";
            this.btShowMap.Size = new System.Drawing.Size(98, 29);
            this.btShowMap.TabIndex = 1;
            this.btShowMap.Text = "Mostrar";
            this.btShowMap.UseVisualStyleBackColor = false;
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(62, 13);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(204, 21);
            this.cbDepartments.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(747, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 533);
            this.panel4.TabIndex = 3;
            // 
            // mapGenerator
            // 
            this.mapGenerator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mapGenerator.AutoSize = true;
            this.mapGenerator.Location = new System.Drawing.Point(32, 25);
            this.mapGenerator.Name = "mapGenerator";
            this.mapGenerator.Size = new System.Drawing.Size(709, 545);
            this.mapGenerator.TabIndex = 4;
            // 
            // HotMapReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1072, 570);
            this.Controls.Add(this.mapGenerator);
            this.Controls.Add(this.panel4);
            this.Name = "HotMapReport";
            this.Text = "HotMapReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.RadioButton rbShowDateProyection;
        private System.Windows.Forms.RadioButton rbShowDateHistorical;
        private System.Windows.Forms.RadioButton rbDepartmentHotMap;
        private System.Windows.Forms.RadioButton rbColombiaHotMap;
        private System.Windows.Forms.Button btShowMap;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel mapGenerator;
    }
}