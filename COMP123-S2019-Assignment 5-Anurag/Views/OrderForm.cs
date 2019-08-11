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

        /// <summary>
        /// This is the event handler when user selects the Print Tool option on the Menu Item list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Selection is printing!");
        }

        /// <summary>
        /// This is the event handler when the form is opened or activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ConditionDataLabel.Text = Program.product.condition;
            ManufactureDataLabel.Text = Program.product.manufacturer;
            PlatformDataLabel.Text = Program.product.platform;
            ModelDataLabel.Text = Program.product.model;
            LCDSizeDataLabel.Text = Program.product.screensize;
            MemoryDataLabel.Text = Program.product.RAM_size;
            CPUBrandDataLabel.Text = Program.product.CPU_brand;
            CPUTypeDataLabel.Text = Program.product.CPU_type;
            CPUNumberDataLabel.Text = Program.product.CPU_number;
            CPUSpeedDataLabel.Text = Program.product.CPU_speed;
            HDDDataLabel.Text = Program.product.HDD_size;
            GPUTypeDataLabel.Text = Program.product.GPU_Type;
            WebcamDataLabel.Text = Program.product.webcam;
            OSDataLabel.Text = Program.product.OS;
            PriceDataLabel.Text = "$"+Program.product.cost.ToString();
            double price = double.Parse(Program.product.cost.ToString());
            double salesTax = 0.13 * price;
            SalesTaxDataLabel.Text = "$" + price.ToString();
            double totalPrice = price + salesTax;
            TotalDataLabel.Text = "$"+Math.Round(totalPrice, 2).ToString();

        }

        /// <summary>
        /// This is the even handler when the user clicks the Finish Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            string message = "Thank you for your business\nYour order will process in 7-10 business days";
            DialogResult dialog = MessageBox.Show(message, "Ending message:", MessageBoxButtons.OK);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }

    }
}
