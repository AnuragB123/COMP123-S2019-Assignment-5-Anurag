using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment_5_Anurag.Views
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

        /// <summary>
        /// This is the event handler when the Select Form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            //At the begginning, the Next Button will be disabled
            NextButton.Enabled = false;
            //If a row is selected, then the next Button is enabled
            if (ProductsDataGridView.SelectedRows.Count > 0)
            {
                NextButton.Enabled = true;
            }

        }

        /// <summary>
        /// This is the event handler when user selects a row or another row in the dat grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComputersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //local variables that are used as alias
            var currentCell = ProductsDataGridView.CurrentCell;
            var rowIndex = ProductsDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductsDataGridView.Rows[rowIndex];
            var columnCount = ProductsDataGridView.ColumnCount;
            var cells = currentRow.Cells;

            currentRow.Selected = true;

            string outputString = string.Empty;

            for (int index = 1; index < 4; index++)
            {
                outputString += cells[index].Value + " ";
            }

            YourSelectionTextBox.Text = outputString;

            Program.product.productID = short.Parse(cells[0].Value.ToString());
            Program.product.cost = Math.Round(decimal.Parse(cells[1].Value.ToString()));
            Program.product.manufacturer = cells[2].Value.ToString();
            Program.product.model = cells[3].Value.ToString();
            Program.product.RAM_type = cells[4].Value.ToString();
            Program.product.RAM_size = cells[5].Value.ToString();
            Program.product.displaytype = cells[6].Value.ToString();
            Program.product.screensize = cells[7].Value.ToString();
            Program.product.resolution = cells[8].Value.ToString();
            Program.product.CPU_Class = cells[9].Value.ToString();
            Program.product.CPU_brand = cells[10].Value.ToString();
            Program.product.CPU_type = cells[11].Value.ToString();
            Program.product.CPU_speed = cells[12].Value.ToString();
            Program.product.CPU_number = cells[13].Value.ToString();
            Program.product.condition = cells[14].Value.ToString();
            Program.product.OS = cells[15].Value.ToString();
            Program.product.platform = cells[16].Value.ToString();
            Program.product.HDD_size = cells[17].Value.ToString();
            Program.product.HDD_speed = cells[18].Value.ToString();
            Program.product.GPU_Type = cells[19].Value.ToString();
            Program.product.optical_drive = cells[20].Value.ToString();
            Program.product.Audio_type = cells[21].Value.ToString();
            Program.product.LAN = cells[22].Value.ToString();
            Program.product.WIFI = cells[23].Value.ToString();
            Program.product.width = cells[24].Value.ToString();
            Program.product.height = cells[25].Value.ToString();
            Program.product.depth = cells[26].Value.ToString();
            Program.product.weight = cells[27].Value.ToString();
            Program.product.moust_type = cells[28].Value.ToString();
            Program.product.power = cells[29].Value.ToString();
            Program.product.webcam = cells[30].Value.ToString();
        }

        
    }
}
