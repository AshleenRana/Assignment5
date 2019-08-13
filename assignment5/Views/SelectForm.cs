using assignment5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
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
        
    }
}
