namespace COMP123_S2019_Assignment_5_Anurag
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TypeOfComputerLabel = new System.Windows.Forms.Label();
            this.ComputersDataGridView = new System.Windows.Forms.DataGridView();
            this.YourSelectionLabel = new System.Windows.Forms.Label();
            this.YourSelectionTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComputersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeOfComputerLabel
            // 
            this.TypeOfComputerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TypeOfComputerLabel.Location = new System.Drawing.Point(12, 9);
            this.TypeOfComputerLabel.Name = "TypeOfComputerLabel";
            this.TypeOfComputerLabel.Size = new System.Drawing.Size(495, 46);
            this.TypeOfComputerLabel.TabIndex = 0;
            this.TypeOfComputerLabel.Text = "Dollar Computer Hardware List";
            // 
            // ComputersDataGridView
            // 
            this.ComputersDataGridView.AllowUserToAddRows = false;
            this.ComputersDataGridView.AllowUserToDeleteRows = false;
            this.ComputersDataGridView.AllowUserToResizeColumns = false;
            this.ComputersDataGridView.AllowUserToResizeRows = false;
            this.ComputersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ComputersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ComputersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComputersDataGridView.Location = new System.Drawing.Point(12, 70);
            this.ComputersDataGridView.Name = "ComputersDataGridView";
            this.ComputersDataGridView.ReadOnly = true;
            this.ComputersDataGridView.RowTemplate.Height = 24;
            this.ComputersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComputersDataGridView.Size = new System.Drawing.Size(888, 412);
            this.ComputersDataGridView.TabIndex = 1;
            // 
            // YourSelectionLabel
            // 
            this.YourSelectionLabel.Location = new System.Drawing.Point(12, 494);
            this.YourSelectionLabel.Name = "YourSelectionLabel";
            this.YourSelectionLabel.Size = new System.Drawing.Size(257, 42);
            this.YourSelectionLabel.TabIndex = 2;
            this.YourSelectionLabel.Text = "Your Selection:";
            // 
            // YourSelectionTextBox
            // 
            this.YourSelectionTextBox.Location = new System.Drawing.Point(263, 494);
            this.YourSelectionTextBox.Name = "YourSelectionTextBox";
            this.YourSelectionTextBox.ReadOnly = true;
            this.YourSelectionTextBox.Size = new System.Drawing.Size(581, 45);
            this.YourSelectionTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(850, 491);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(194, 51);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(1050, 491);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(189, 50);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 543);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.YourSelectionTextBox);
            this.Controls.Add(this.YourSelectionLabel);
            this.Controls.Add(this.ComputersDataGridView);
            this.Controls.Add(this.TypeOfComputerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            ((System.ComponentModel.ISupportInitialize)(this.ComputersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypeOfComputerLabel;
        private System.Windows.Forms.DataGridView ComputersDataGridView;
        private System.Windows.Forms.Label YourSelectionLabel;
        private System.Windows.Forms.TextBox YourSelectionTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}