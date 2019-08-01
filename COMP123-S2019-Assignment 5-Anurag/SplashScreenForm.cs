﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment_5_Anurag
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            SplashScreenFormTimer.Enabled = true;
        }

        private void SplashScreenFormTimer_Tick(object sender, EventArgs e)
        {
            SplashScreenFormTimer.Enabled = false;
            Program.startForm.Show();
            this.Hide();
            
        }
    }
}