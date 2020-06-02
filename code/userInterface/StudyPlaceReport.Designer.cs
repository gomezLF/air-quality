﻿namespace userInterface
{
    partial class StudyPlaceReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.showInformation_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.department_ComboBox = new System.Windows.Forms.ComboBox();
            this.displayOptions = new System.Windows.Forms.CheckedListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btReturnToMainMenu = new System.Windows.Forms.Button();
            this.chartContainer_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.showInformation_button);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.department_ComboBox);
            this.panel1.Controls.Add(this.displayOptions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 89);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(398, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 85);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // showInformation_button
            // 
            this.showInformation_button.AutoSize = true;
            this.showInformation_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showInformation_button.Location = new System.Drawing.Point(96, 55);
            this.showInformation_button.Name = "showInformation_button";
            this.showInformation_button.Size = new System.Drawing.Size(157, 23);
            this.showInformation_button.TabIndex = 3;
            this.showInformation_button.Text = "Mostrar Información";
            this.showInformation_button.UseVisualStyleBackColor = true;
            this.showInformation_button.Click += new System.EventHandler(this.ShowInformation_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione un Departamento";
            // 
            // department_ComboBox
            // 
            this.department_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department_ComboBox.FormattingEnabled = true;
            this.department_ComboBox.Location = new System.Drawing.Point(56, 24);
            this.department_ComboBox.Name = "department_ComboBox";
            this.department_ComboBox.Size = new System.Drawing.Size(231, 21);
            this.department_ComboBox.TabIndex = 1;
            // 
            // displayOptions
            // 
            this.displayOptions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.displayOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayOptions.CheckOnClick = true;
            this.displayOptions.FormattingEnabled = true;
            this.displayOptions.Items.AddRange(new object[] {
            "Solo Datos Proyectados",
            "Solo Datos Históricos",
            "Comparar Datos Históricos con Datos Proyectados"});
            this.displayOptions.Location = new System.Drawing.Point(477, 18);
            this.displayOptions.Name = "displayOptions";
            this.displayOptions.Size = new System.Drawing.Size(270, 60);
            this.displayOptions.TabIndex = 0;
            this.displayOptions.SelectedIndexChanged += new System.EventHandler(this.DisplayOptions_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.btReturnToMainMenu);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 616);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(882, 38);
            this.panel7.TabIndex = 12;
            // 
            // btReturnToMainMenu
            // 
            this.btReturnToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturnToMainMenu.Location = new System.Drawing.Point(368, 3);
            this.btReturnToMainMenu.Name = "btReturnToMainMenu";
            this.btReturnToMainMenu.Size = new System.Drawing.Size(189, 31);
            this.btReturnToMainMenu.TabIndex = 0;
            this.btReturnToMainMenu.Text = "Regresar al Menú Principal";
            this.btReturnToMainMenu.UseVisualStyleBackColor = true;
            // 
            // chartContainer_panel
            // 
            this.chartContainer_panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chartContainer_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartContainer_panel.Location = new System.Drawing.Point(0, 89);
            this.chartContainer_panel.Name = "chartContainer_panel";
            this.chartContainer_panel.Size = new System.Drawing.Size(882, 527);
            this.chartContainer_panel.TabIndex = 13;
            // 
            // StudyPlaceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 654);
            this.Controls.Add(this.chartContainer_panel);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Name = "StudyPlaceReport";
            this.Text = "StudyPlaceReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button showInformation_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox department_ComboBox;
        private System.Windows.Forms.CheckedListBox displayOptions;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btReturnToMainMenu;
        private System.Windows.Forms.Panel chartContainer_panel;
    }
}