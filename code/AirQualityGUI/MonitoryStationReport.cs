﻿using model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirQualityGUI
{
    public partial class MonitoryStationReport : Form
    {
        private AirQuality AirQuality;
        public MonitoryStationReport()
        {
            InitializeComponent();
            AirQuality = new AirQuality();
        }

        
    }
}
