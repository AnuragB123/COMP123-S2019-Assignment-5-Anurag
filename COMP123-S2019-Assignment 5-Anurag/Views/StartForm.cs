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
    public partial class StartForm : Form
    {
        /// <summary>
        /// This is the constructor for Start Form
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler when the user clicks Exit Button to terminate the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the even handler when the user clicks Start a New Order to select new order and product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        /// <summary>
        /// This is the even handler when the user clicks a Open Saved Order which shows Product Info Form and opens the file dialog of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
            //Program.productInfoForm.Show();
            //this.Hide();
        }
    }
}
