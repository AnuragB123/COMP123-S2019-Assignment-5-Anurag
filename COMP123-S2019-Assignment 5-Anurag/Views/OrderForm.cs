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
    public partial class OrderForm : Form
    {
        /// <summary>
        /// This is the constructor of Order Form
        /// </summary>
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the even handler when the user clicks the About Menu Selection to open the About Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.Show();
        }

       /// <summary>
       /// This is the shared event handler when the user clicks Back Menu Selection or Back Button to select another product from 
       /// Select Form
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void Go_Back_To_Product_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        /// <summary>
        /// This is the shared event handler when user clicks either Exit Menu Selection or Cancel Button to terminate application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Terminate_Application_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
