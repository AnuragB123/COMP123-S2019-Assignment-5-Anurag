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
    public partial class SelectForm : Form
    {
        /// <summary>
        /// This is the constructor for Select Form
        /// </summary>
        public SelectForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// This is an event handler when the user clicks Cancel Button to terminate the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is an event handler when the user clicks Next Button to go to the Product Info Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);


        }

        private void ComputersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //local variables that are used as alias
           
        }
    }
}
