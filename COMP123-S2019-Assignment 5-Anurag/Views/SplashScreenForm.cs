using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Name: Anurag Bhattacharya
/// Lab 12 - Assignment 5 UI
/// 301050634
/// </summary>
namespace COMP123_S2019_Assignment_5_Anurag
{
    public partial class SplashScreenForm : Form
    {
        /// <summary>
        /// This is the constructor for Splash Screen Form
        /// </summary>
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler when the Splash Screen Form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            SplashScreenFormTimer.Enabled = true;
        }

        /// <summary>
        /// This is the event handler when the timer for the Splash Screen to transaction to Start Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreenFormTimer_Tick(object sender, EventArgs e)
        {
            SplashScreenFormTimer.Enabled = false;
            Program.startForm.Show();
            this.Hide();
            
        }
    }
}
