namespace AirQualityGUI
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
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btLast = new System.Windows.Forms.Button();
            this.btFirst = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.tlpFields = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tlpFields.SuspendLayout();
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
            this.panel2.Controls.Add(this.tlpFields);
            this.panel2.Controls.Add(this.btShowFields);
            this.panel2.Controls.Add(this.btDesmarkAll);
            this.panel2.Controls.Add(this.btMarkAll);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(123, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 252);
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
            // tlpFields
            // 
            this.tlpFields.AutoScroll = true;
            this.tlpFields.ColumnCount = 1;
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFields.Controls.Add(this.checkBox5, 0, 15);
            this.tlpFields.Controls.Add(this.checkBox10, 1, 9);
            this.tlpFields.Controls.Add(this.checkBox18, 1, 14);
            this.tlpFields.Controls.Add(this.checkBox19, 0, 9);
            this.tlpFields.Controls.Add(this.checkBox20, 0, 14);
            this.tlpFields.Controls.Add(this.checkBox21, 1, 0);
            this.tlpFields.Controls.Add(this.checkBox22, 1, 13);
            this.tlpFields.Controls.Add(this.checkBox23, 0, 0);
            this.tlpFields.Controls.Add(this.checkBox24, 0, 13);
            this.tlpFields.Controls.Add(this.checkBox25, 0, 10);
            this.tlpFields.Controls.Add(this.checkBox26, 0, 12);
            this.tlpFields.Controls.Add(this.checkBox27, 1, 11);
            this.tlpFields.Controls.Add(this.checkBox28, 0, 11);
            this.tlpFields.Controls.Add(this.checkBox29, 1, 10);
            this.tlpFields.Controls.Add(this.checkBox30, 1, 12);
            this.tlpFields.Location = new System.Drawing.Point(18, 19);
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
            this.tlpFields.Size = new System.Drawing.Size(295, 230);
            this.tlpFields.TabIndex = 31;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(3, 325);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(94, 17);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "concentraci_n";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(3, 72);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(79, 17);
            this.checkBox10.TabIndex = 3;
            this.checkBox10.Text = "tecnolog_a";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(3, 302);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(69, 17);
            this.checkBox18.TabIndex = 13;
            this.checkBox18.Text = "unidades";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(3, 49);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(139, 17);
            this.checkBox19.TabIndex = 2;
            this.checkBox19.Text = "nombre_de_la_estaci_n";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(3, 279);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(63, 17);
            this.checkBox20.TabIndex = 12;
            this.checkBox20.Text = "variable";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(3, 26);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(121, 17);
            this.checkBox21.TabIndex = 1;
            this.checkBox21.Text = "autoridad_ambiental";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Location = new System.Drawing.Point(3, 256);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(131, 17);
            this.checkBox22.TabIndex = 11;
            this.checkBox22.Text = "tiempo_de_exposici_n";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Location = new System.Drawing.Point(3, 3);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(53, 17);
            this.checkBox23.TabIndex = 0;
            this.checkBox23.Text = "fecha";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Location = new System.Drawing.Point(3, 233);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(107, 17);
            this.checkBox24.TabIndex = 10;
            this.checkBox24.Text = "tipo_de_estaci_n";
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Location = new System.Drawing.Point(3, 95);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(54, 17);
            this.checkBox25.TabIndex = 4;
            this.checkBox25.Text = "latitud";
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Location = new System.Drawing.Point(3, 187);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(128, 17);
            this.checkBox26.TabIndex = 8;
            this.checkBox26.Text = "c_digo_del_municipio";
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Location = new System.Drawing.Point(3, 164);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(91, 17);
            this.checkBox27.TabIndex = 7;
            this.checkBox27.Text = "departamento";
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.Location = new System.Drawing.Point(3, 141);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(149, 17);
            this.checkBox28.TabIndex = 6;
            this.checkBox28.Text = "c_digo_del_departamento";
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            this.checkBox29.AutoSize = true;
            this.checkBox29.Location = new System.Drawing.Point(3, 118);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(63, 17);
            this.checkBox29.TabIndex = 5;
            this.checkBox29.Text = "longitud";
            this.checkBox29.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            this.checkBox30.AutoSize = true;
            this.checkBox30.Location = new System.Drawing.Point(3, 210);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(131, 17);
            this.checkBox30.TabIndex = 9;
            this.checkBox30.Text = "nombre_del_municipio";
            this.checkBox30.UseVisualStyleBackColor = true;
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
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tlpFields.ResumeLayout(false);
            this.tlpFields.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btLast;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.TableLayoutPanel tlpFields;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.CheckBox checkBox28;
        private System.Windows.Forms.CheckBox checkBox29;
        private System.Windows.Forms.CheckBox checkBox30;
    }
}