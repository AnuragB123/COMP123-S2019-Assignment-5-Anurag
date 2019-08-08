using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDDataLabel.Text = Program.product.productID.ToString();
            ConditionDataLabel.Text = Program.product.condition.ToString();
            CostDataLabel.Text = Program.product.cost.ToString();
            PlatformDataLabel.Text = Program.product.platform.ToString();
            OSDataLabel.Text = Program.product.OS.ToString();
            ManufactureDataLabel.Text = Program.product.manufacturer.ToString();
            ModelDataLabel.Text = Program.product.model.ToString();
            MemoryDataLabel.Text = Program.product.RAM_size.ToString();
            LCDSizeDataLabel.Text = Program.product.HDD_size.ToString();
            HDDDataLabel.Text = Program.product.HDD_size.ToString();
            CPUBrandDataLabel.Text = Program.product.CPU_brand.ToString();
            CPUNumberDataLabel.Text = Program.product.CPU_number.ToString();
            GPUTypeDataLabel.Text = Program.product.GPU_Type.ToString();
            CPUTypeDataLabel.Text = Program.product.CPU_type.ToString();
            CPUSpeedDataLabel.Text = Program.product.CPU_speed.ToString();
            WebcamDataLabel.Text = Program.product.webcam.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            ProductSaveFileDialog.FileName = "Product.txt";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Text Files (*.txt)|*txt|All Files (*.*)|*.*";

            //open the file dialog
            var result = ProductSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                //open the stream for writing
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(ProductSaveFileDialog.FileName, FileMode.Create)))
                {
                    //write content - string type - to the file
                    outputStream.WriteLine(Program.product.productID.ToString());
                    outputStream.WriteLine(Program.product.cost.ToString());
                    outputStream.WriteLine(Program.product.manufacturer);
                    outputStream.WriteLine(Program.product.model);
                    outputStream.WriteLine(Program.product.RAM_type);
                    outputStream.WriteLine(Program.product.RAM_size);
                    outputStream.WriteLine(Program.product.displaytype);
                    outputStream.WriteLine(Program.product.screensize);
                    outputStream.WriteLine(Program.product.resolution);
                    outputStream.WriteLine(Program.product.CPU_Class);
                    outputStream.WriteLine(Program.product.CPU_brand);
                    outputStream.WriteLine(Program.product.CPU_type);
                    outputStream.WriteLine(Program.product.CPU_speed);
                    outputStream.WriteLine(Program.product.CPU_number);
                    outputStream.WriteLine(Program.product.condition);
                    outputStream.WriteLine(Program.product.OS);
                    outputStream.WriteLine(Program.product.platform);
                    outputStream.WriteLine(Program.product.HDD_size);
                    outputStream.WriteLine(Program.product.HDD_speed);
                    outputStream.WriteLine(Program.product.CPU_type);
                    outputStream.WriteLine(Program.product.optical_drive);
                    outputStream.WriteLine(Program.product.Audio_type);
                    outputStream.WriteLine(Program.product.LAN);
                    outputStream.WriteLine(Program.product.WIFI);
                    outputStream.WriteLine(Program.product.width);
                    outputStream.WriteLine(Program.product.height);
                    outputStream.WriteLine(Program.product.depth);
                    outputStream.WriteLine(Program.product.weight);
                    outputStream.WriteLine(Program.product.moust_type);
                    outputStream.WriteLine(Program.product.power);
                    outputStream.WriteLine(Program.product.webcam);

                    //cleanup
                    outputStream.Close();
                    outputStream.Dispose();

                    //give feedback to the user that the file has been saved
                    //this is a "modal" form
                    MessageBox.Show("File Saved...", "Saving File...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
