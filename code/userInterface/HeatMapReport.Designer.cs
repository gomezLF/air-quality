﻿namespace userInterface
{
    partial class HeatMapReport
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSelector = new System.Windows.Forms.CheckedListBox();
            this.mapGenerator = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(519, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 503);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(56, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Regresar al Menu Principal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ReturnMainMenu_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dataSelector);
            this.panel3.Location = new System.Drawing.Point(10, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 212);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(65, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ShowMap_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 2);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // dataSelector
            // 
            this.dataSelector.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataSelector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSelector.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSelector.FormattingEnabled = true;
            this.dataSelector.Items.AddRange(new object[] {
            "Mostrar Proyeccción de Datos",
            "Mostrar Datos Históricos"});
            this.dataSelector.Location = new System.Drawing.Point(9, 14);
            this.dataSelector.Name = "dataSelector";
            this.dataSelector.Size = new System.Drawing.Size(205, 32);
            this.dataSelector.TabIndex = 0;
            this.dataSelector.SelectedIndexChanged += new System.EventHandler(this.DataSelector_SelectedIndexChanged);
            // 
            // mapGenerator
            // 
            this.mapGenerator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mapGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapGenerator.Location = new System.Drawing.Point(0, 0);
            this.mapGenerator.Name = "mapGenerator";
            this.mapGenerator.Size = new System.Drawing.Size(519, 503);
            this.mapGenerator.TabIndex = 1;
            // 
            // HeatMapReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 503);
            this.Controls.Add(this.mapGenerator);
            this.Controls.Add(this.panel1);
            this.Name = "HeatMapReport";
            this.Text = "Mapa de Calor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox dataSelector;
        private System.Windows.Forms.Panel mapGenerator;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}