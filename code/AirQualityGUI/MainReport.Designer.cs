﻿namespace AirQualityGUI
{
    partial class MainReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainReport));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbURLDataset = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btFilter = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbSeparater = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.cbFields = new System.Windows.Forms.ComboBox();
            this.tbNumberRows = new System.Windows.Forms.TextBox();
            this.cbClauses = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btShowFields = new System.Windows.Forms.Button();
            this.btDesmarkAll = new System.Windows.Forms.Button();
            this.btMarkAll = new System.Windows.Forms.Button();
            this.tlpFields = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btLast = new System.Windows.Forms.Button();
            this.btFirst = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tlpFields.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.tbURLDataset);
            this.panel5.Location = new System.Drawing.Point(-195, -101);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1191, 30);
            this.panel5.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agrege la URL del Dataset";
            // 
            // tbURLDataset
            // 
            this.tbURLDataset.AutoCompleteCustomSource.AddRange(new string[] {
            " https://www.datos.gov.co/resource/ysq6-ri4e.json"});
            this.tbURLDataset.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbURLDataset.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbURLDataset.Location = new System.Drawing.Point(467, 3);
            this.tbURLDataset.Name = "tbURLDataset";
            this.tbURLDataset.Size = new System.Drawing.Size(387, 20);
            this.tbURLDataset.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1048, 270);
            this.dataGridView1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btFilter);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.cbSeparater);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbValue);
            this.panel1.Controls.Add(this.cbFields);
            this.panel1.Controls.Add(this.tbNumberRows);
            this.panel1.Controls.Add(this.cbClauses);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(619, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 216);
            this.panel1.TabIndex = 27;
            // 
            // btFilter
            // 
            this.btFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFilter.Location = new System.Drawing.Point(93, 180);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(133, 23);
            this.btFilter.TabIndex = 0;
            this.btFilter.Text = "Filtrar";
            this.btFilter.UseVisualStyleBackColor = false;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(278, -82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 46);
            this.panel4.TabIndex = 21;
            // 
            // cbSeparater
            // 
            this.cbSeparater.FormattingEnabled = true;
            this.cbSeparater.Location = new System.Drawing.Point(41, 91);
            this.cbSeparater.Name = "cbSeparater";
            this.cbSeparater.Size = new System.Drawing.Size(80, 21);
            this.cbSeparater.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Separador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Valor ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo de Clausula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Campos";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(175, 92);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(112, 20);
            this.tbValue.TabIndex = 13;
            // 
            // cbFields
            // 
            this.cbFields.FormattingEnabled = true;
            this.cbFields.Location = new System.Drawing.Point(173, 49);
            this.cbFields.Name = "cbFields";
            this.cbFields.Size = new System.Drawing.Size(114, 21);
            this.cbFields.TabIndex = 14;
            this.cbFields.SelectedIndexChanged += new System.EventHandler(this.cbFields_SelectedIndexChanged);
            // 
            // tbNumberRows
            // 
            this.tbNumberRows.Location = new System.Drawing.Point(130, 144);
            this.tbNumberRows.Name = "tbNumberRows";
            this.tbNumberRows.Size = new System.Drawing.Size(48, 20);
            this.tbNumberRows.TabIndex = 15;
            // 
            // cbClauses
            // 
            this.cbClauses.FormattingEnabled = true;
            this.cbClauses.Location = new System.Drawing.Point(27, 49);
            this.cbClauses.Name = "cbClauses";
            this.cbClauses.Size = new System.Drawing.Size(121, 21);
            this.cbClauses.TabIndex = 16;
            this.cbClauses.SelectedIndexChanged += new System.EventHandler(this.cbClauses_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Filtros";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "No.  de filas";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btShowFields);
            this.panel2.Controls.Add(this.btDesmarkAll);
            this.panel2.Controls.Add(this.btMarkAll);
            this.panel2.Controls.Add(this.tlpFields);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(123, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 249);
            this.panel2.TabIndex = 28;
            // 
            // btShowFields
            // 
            this.btShowFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btShowFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowFields.Location = new System.Drawing.Point(317, 182);
            this.btShowFields.Name = "btShowFields";
            this.btShowFields.Size = new System.Drawing.Size(141, 23);
            this.btShowFields.TabIndex = 21;
            this.btShowFields.Text = "Mostrar Campos";
            this.btShowFields.UseVisualStyleBackColor = false;
            this.btShowFields.Click += new System.EventHandler(this.btShowFields_Click);
            // 
            // btDesmarkAll
            // 
            this.btDesmarkAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btDesmarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDesmarkAll.Location = new System.Drawing.Point(335, 113);
            this.btDesmarkAll.Name = "btDesmarkAll";
            this.btDesmarkAll.Size = new System.Drawing.Size(100, 23);
            this.btDesmarkAll.TabIndex = 20;
            this.btDesmarkAll.Text = "Desmarcar Todos";
            this.btDesmarkAll.UseVisualStyleBackColor = false;
            this.btDesmarkAll.Click += new System.EventHandler(this.btDesmarkAll_Click);
            // 
            // btMarkAll
            // 
            this.btMarkAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMarkAll.Location = new System.Drawing.Point(335, 80);
            this.btMarkAll.Name = "btMarkAll";
            this.btMarkAll.Size = new System.Drawing.Size(100, 23);
            this.btMarkAll.TabIndex = 19;
            this.btMarkAll.Text = "Marcar Todos";
            this.btMarkAll.UseVisualStyleBackColor = false;
            this.btMarkAll.Click += new System.EventHandler(this.btMarkAll_Click);
            // 
            // tlpFields
            // 
            this.tlpFields.AutoScroll = true;
            this.tlpFields.ColumnCount = 1;
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFields.Controls.Add(this.checkBox15, 0, 15);
            this.tlpFields.Controls.Add(this.checkBox4, 1, 9);
            this.tlpFields.Controls.Add(this.checkBox14, 1, 14);
            this.tlpFields.Controls.Add(this.checkBox3, 0, 9);
            this.tlpFields.Controls.Add(this.checkBox13, 0, 14);
            this.tlpFields.Controls.Add(this.checkBox12, 1, 13);
            this.tlpFields.Controls.Add(this.checkBox11, 0, 13);
            this.tlpFields.Controls.Add(this.checkBox16, 0, 10);
            this.tlpFields.Controls.Add(this.checkBox9, 0, 12);
            this.tlpFields.Controls.Add(this.checkBox8, 1, 11);
            this.tlpFields.Controls.Add(this.checkBox7, 0, 11);
            this.tlpFields.Controls.Add(this.checkBox6, 1, 10);
            this.tlpFields.Controls.Add(this.checkBox17, 1, 12);
            this.tlpFields.Controls.Add(this.checkBox1, 0, 0);
            this.tlpFields.Location = new System.Drawing.Point(16, 41);
            this.tlpFields.Name = "tlpFields";
            this.tlpFields.RowCount = 16;
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFields.Size = new System.Drawing.Size(295, 187);
            this.tlpFields.TabIndex = 18;
            this.tlpFields.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpFields_Paint);
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(3, 302);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(94, 17);
            this.checkBox15.TabIndex = 14;
            this.checkBox15.Text = "concentraci_n";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(3, 49);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(79, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "tecnolog_a";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(3, 279);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(69, 17);
            this.checkBox14.TabIndex = 13;
            this.checkBox14.Text = "unidades";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 26);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(139, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "nombre_de_la_estaci_n";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(3, 256);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(63, 17);
            this.checkBox13.TabIndex = 12;
            this.checkBox13.Text = "variable";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 23);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(121, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "autoridad_ambiental";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(3, 233);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(131, 17);
            this.checkBox12.TabIndex = 11;
            this.checkBox12.Text = "tiempo_de_exposici_n";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "fecha";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(3, 210);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(107, 17);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.Text = "tipo_de_estaci_n";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(3, 72);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(54, 17);
            this.checkBox16.TabIndex = 4;
            this.checkBox16.Text = "latitud";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(3, 164);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(128, 17);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "c_digo_del_municipio";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(3, 141);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(91, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "departamento";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(3, 118);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(149, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "c_digo_del_departamento";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(3, 95);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(63, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "longitud";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(3, 187);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(131, 17);
            this.checkBox17.TabIndex = 9;
            this.checkBox17.Text = "nombre_del_municipio";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(113, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Marque las campos que desea ver";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.btLast);
            this.panel6.Controls.Add(this.btFirst);
            this.panel6.Controls.Add(this.btNext);
            this.panel6.Controls.Add(this.btBack);
            this.panel6.Location = new System.Drawing.Point(134, 535);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(821, 30);
            this.panel6.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(424, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(406, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(387, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "0";
            // 
            // btLast
            // 
            this.btLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLast.Location = new System.Drawing.Point(530, 4);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(75, 23);
            this.btLast.TabIndex = 18;
            this.btLast.Text = "Última";
            this.btLast.UseVisualStyleBackColor = false;
            // 
            // btFirst
            // 
            this.btFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFirst.Location = new System.Drawing.Point(227, 4);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(75, 23);
            this.btFirst.TabIndex = 17;
            this.btFirst.Text = "Primera";
            this.btFirst.UseVisualStyleBackColor = false;
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.Location = new System.Drawing.Point(611, 3);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 16;
            this.btNext.Text = ">>>";
            this.btNext.UseVisualStyleBackColor = false;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Location = new System.Drawing.Point(146, 4);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 15;
            this.btBack.Text = "<<<";
            this.btBack.UseVisualStyleBackColor = false;
            // 
            // MainReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1072, 570);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainReport";
            this.Text = "MainReport";
            this.Load += new System.EventHandler(this.MainReport_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tlpFields.ResumeLayout(false);
            this.tlpFields.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbURLDataset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbSeparater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.ComboBox cbFields;
        private System.Windows.Forms.TextBox tbNumberRows;
        private System.Windows.Forms.ComboBox cbClauses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btShowFields;
        private System.Windows.Forms.Button btDesmarkAll;
        private System.Windows.Forms.Button btMarkAll;
        private System.Windows.Forms.TableLayoutPanel tlpFields;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btLast;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btBack;
    }
}