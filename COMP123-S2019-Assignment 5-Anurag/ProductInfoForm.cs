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
    public partial class ProductInfoForm : Form
    {
        /// <summary>
        /// This is the constructor of Product Info Form
        /// </summary>
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// This is the shared event handler when the User clicks the Exit Menu Selection or Cancel Button to terminate the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the shared event handler when the User clicks the Select Another Product or Select Another Product Button to select another
        /// product from Select Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Select_Another_Product_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        /// <summary>
        /// This is the event handler when the user clicks Next Button to show the Order Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }
    }
}
