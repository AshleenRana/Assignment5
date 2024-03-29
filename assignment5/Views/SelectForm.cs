﻿using assignment5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductDataGridView.Rows[rowIndex];
            var cost = currentRow.Cells[1].Value.ToString();
            var manufacturer = currentRow.Cells[2].Value.ToString();
            var model = currentRow.Cells[3].Value.ToString();

            string outputstring = manufacturer + " " + model + "  $" + cost;

            SelectionLabel.Text = outputstring;
            
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductDataGridView.Rows[rowIndex];

            //open the stream to write
            using (StreamWriter outputString = new StreamWriter(
                File.Open("Product.txt", FileMode.Create)))

            {
                //write stuff to the file
                outputString.WriteLine(currentRow.Cells[0].Value.ToString());
                outputString.WriteLine(currentRow.Cells[1].Value.ToString());
                outputString.WriteLine(currentRow.Cells[2].Value.ToString());
                outputString.WriteLine(currentRow.Cells[3].Value.ToString());
                outputString.WriteLine(currentRow.Cells[5].Value.ToString());
                outputString.WriteLine(currentRow.Cells[7].Value.ToString());
                outputString.WriteLine(currentRow.Cells[10].Value.ToString());
                outputString.WriteLine(currentRow.Cells[11].Value.ToString());
                outputString.WriteLine(currentRow.Cells[12].Value.ToString());
                outputString.WriteLine(currentRow.Cells[13].Value.ToString());
                outputString.WriteLine(currentRow.Cells[14].Value.ToString());
                outputString.WriteLine(currentRow.Cells[15].Value.ToString());
                outputString.WriteLine(currentRow.Cells[16].Value.ToString());
                outputString.WriteLine(currentRow.Cells[17].Value.ToString());
                outputString.WriteLine(currentRow.Cells[19].Value.ToString());
                outputString.WriteLine(currentRow.Cells[21].Value.ToString());
                outputString.WriteLine(currentRow.Cells[30].Value.ToString());
                outputString.WriteLine(currentRow.Cells[24].Value.ToString());
                outputString.WriteLine(currentRow.Cells[25].Value.ToString());
                outputString.WriteLine(currentRow.Cells[28].Value.ToString());
                outputString.WriteLine(currentRow.Cells[29].Value.ToString());


                //cleanup
                outputString.Close();
                outputString.Dispose();

                //message alerting user the file has been saved
                MessageBox.Show("File Saved...", "Saving file...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Program.productInfoForm.Show();
            }
        }
    }
}
